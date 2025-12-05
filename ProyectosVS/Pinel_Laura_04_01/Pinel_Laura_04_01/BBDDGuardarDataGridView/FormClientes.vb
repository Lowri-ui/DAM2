Imports Microsoft.Data.SqlClient

Public Class FormClientes

    ' Variable para almacenar los datos
    Private dt As New DataTable()

    ' Cadena de conexión
    Private connString As String = "Data Source=.\SQLEXPRESS;Initial Catalog=Clientes;Integrated Security=True;TrustServerCertificate=True;"

    ' Evento Load: se ejecuta al abrir el formulario
    Private Sub FormClientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarDatos()
    End Sub

    ' Método para cargar los datos al DataGridView
    Private Sub CargarDatos()
        Try
            dt.Clear()

            ' Consulta 
            Dim query As String = "SELECT * FROM Personas"

            Using conn As New SqlConnection(connString)
                Using cmd As New SqlCommand(query, conn)
                    conn.Open()
                    dt.Load(cmd.ExecuteReader())
                End Using
            End Using

            DataGridView1.DataSource = dt

        Catch ex As Exception
            MessageBox.Show("Error al cargar datos: " & ex.Message)
        End Try
    End Sub

End Class
