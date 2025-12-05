Imports Microsoft.Data.SqlClient

Public Class Form1

    ' Tabla para cargar datos
    Private dt As New DataTable()
    Private connString As String = "Data Source=.\SQLEXPRESS;Initial Catalog=Clientes;Integrated Security=True;TrustServerCertificate=True;"

    ' ---------------------------
    ' BOTÓN INICIAR: CARGAR DATOS
    ' ---------------------------
    Private Sub btnIniciar_Click(sender As Object, e As EventArgs) Handles btnIniciar.Click
        CargarDatos()
    End Sub

    ' Método para cargar los datos en DataGridView1
    Private Sub CargarDatos()
        Try
            dt.Clear()
            Dim query As String = "SELECT idPersona, perIdentificacion, perNombres, perApellidos, perGenero, perCorreo, perFechaNacimiento FROM Personas"

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

    ' ---------------------------
    ' BOTÓN GUARDAR: INSERTAR CLIENTE NUEVO
    ' ---------------------------
    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Try
            Using conn As New SqlConnection(connString)
                conn.Open()

                For Each row As DataGridViewRow In DataGridView2.Rows
                    If Not row.IsNewRow Then

                        ' Validar perIdentificacion
                        Dim identificacionValor As Object = row.Cells("perIdentificacion").Value
                        If identificacionValor Is Nothing OrElse String.IsNullOrWhiteSpace(identificacionValor.ToString()) Then
                            MessageBox.Show("Error: la columna perIdentificacion no puede estar vacía.")
                            Continue For
                        End If

                        ' Validar perCorreo
                        Dim correoValor As Object = row.Cells("perCorreo").Value
                        If correoValor Is Nothing OrElse String.IsNullOrWhiteSpace(correoValor.ToString()) Then
                            MessageBox.Show("Error: la columna perCorreo no puede estar vacía.")
                            Continue For
                        End If

                        ' Verificar si el correo ya existe
                        Dim checkQuery As String = "SELECT COUNT(*) FROM Personas WHERE perCorreo = @perCorreo"
                        Using checkCmd As New SqlCommand(checkQuery, conn)
                            checkCmd.Parameters.AddWithValue("@perCorreo", correoValor)
                            Dim count As Integer = Convert.ToInt32(checkCmd.ExecuteScalar())
                            If count > 0 Then
                                MessageBox.Show("El correo '" & correoValor.ToString() & "' ya existe en la base de datos. No se puede duplicar.")
                                Continue For
                            End If
                        End Using

                        ' Preparar INSERT
                        Dim insertQuery As String = "INSERT INTO Personas (perIdentificacion, perNombres, perApellidos, perGenero, perCorreo, perFechaNacimiento) " &
                                                    "VALUES (@perIdentificacion, @perNombres, @perApellidos, @perGenero, @perCorreo, @perFechaNacimiento)"

                        Using cmd As New SqlCommand(insertQuery, conn)
                            cmd.Parameters.AddWithValue("@perIdentificacion", identificacionValor)
                            cmd.Parameters.AddWithValue("@perNombres", If(row.Cells("perNombres").Value, DBNull.Value))
                            cmd.Parameters.AddWithValue("@perApellidos", If(row.Cells("perApellidos").Value, DBNull.Value))
                            cmd.Parameters.AddWithValue("@perGenero", If(row.Cells("perGenero").Value, DBNull.Value))
                            cmd.Parameters.AddWithValue("@perCorreo", correoValor)

                            ' Validación de FechaNacimiento
                            Dim fechaValor As Object = row.Cells("perFechaNacimiento").Value
                            If fechaValor IsNot Nothing AndAlso IsDate(fechaValor) Then
                                fechaValor = CDate(fechaValor)
                            Else
                                fechaValor = DBNull.Value
                            End If
                            cmd.Parameters.AddWithValue("@perFechaNacimiento", fechaValor)

                            cmd.ExecuteNonQuery()
                        End Using
                    End If
                Next
            End Using

            MessageBox.Show("Datos guardados correctamente.")

            ' Refrescar DataGridView1 para mostrar los clientes
            CargarDatos()

        Catch ex As Exception
            MessageBox.Show("Error al guardar datos: " & ex.Message)
        End Try
    End Sub

    ' ---------------------------
    ' BOTÓN LIMPIAR: LIMPIAR DATAGRIDVIEW2
    ' ---------------------------
    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        DataGridView2.Rows.Clear()

    End Sub

End Class
