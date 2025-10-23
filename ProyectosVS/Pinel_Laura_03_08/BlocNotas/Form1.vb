Public Class Form1
    Private Sub btnMinimizar_Click(sender As Object, e As EventArgs) Handles btnMinimizar.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub btnMaximizar_Click(sender As Object, e As EventArgs) Handles btnMaximizar.Click
        If Me.WindowState = FormWindowState.Maximized Then
            Me.WindowState = FormWindowState.Normal
        Else
            Me.WindowState = FormWindowState.Maximized
        End If
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            cbFuentes.Items.Clear() 'Borra todo los item que tenga el comboBox
            For Each fuentes As FontFamily In FontFamily.Families 'Instalar las fuentes del ordenador
                Dim tipo As String 'Las fuentes se guardan en la variable tipo
                tipo = fuentes.Name
                cbFuentes.Items.Add(tipo) 'Añadimos las fuentes al comboBox cbFuentes
            Next
            cbFuentes.Text = "Arial" 'Fuente por defecto
        Catch ex As Exception
            cbFuentes.SelectedItem = 0 'Si da error que coloque la primera y muestre un mensaje
            MessageBox.Show("Error al cargar las fuentes: " & ex.Message)
        End Try
    End Sub

    Private Sub cbFuentes_Click(sender As Object, e As EventArgs) Handles cbFuentes.Click

        Try
            Dim fuenteSeleccionada As String = cbFuentes.SelectedItem.ToString() 'Obtenemos la fuente seleccionada
            txtEditor.Font = New Font(fuenteSeleccionada, txtEditor.Font.Size) 'Cambiamos la fuente del TextBox al seleccionado
        Catch ex As Exception
            MessageBox.Show("Error al cambiar la fuente: " & ex.Message)
        End Try
    End Sub

    'En inicio deshabilitadas
    Dim negrita As Boolean = False
    Dim cursiva As Boolean = False

    'Para cambiar el tipo de fuente manteniendo tamaño y estilo
    Private Sub btnNegrita_Click(sender As Object, e As EventArgs) Handles btnNegrita.Click

        If negrita = True Then
            txtEditor.SelectionFont = New Font(cbFuentes.SelectedItem.ToString, FontStyle.Bold)
        Else
            txtEditor.SelectionFont = New Font(cbFuentes.SelectedItem.ToString, FontStyle.Regular)
        End If
    End Sub

    'Para cambiar de cursiva a normal y viceversa
    Private Sub btnCursiva_Click(sender As Object, e As EventArgs) Handles btnCursiva.Click
        Try
            If cursiva = True Then
                txtEditor.SelectionFont = New Font(cbFuentes.Text, Int(txtSize.Text), FontStyle.Italic)
                btnCursiva.ForeColor = Color.Chocolate
                cursiva = False
            Else
                txtEditor.SelectionFont = New Font(cbFuentes.Text, Int(txtSize.Text),
FontStyle.Regular)
                btnCursiva.ForeColor = Color.White
                cursiva = True
            End If
        Catch ex As Exception
        End Try
    End Sub
    'Private Sub txtSize_TextChanged(sender As Object, e As EventArgs) Handles txtSize.TextChanged
    'Try
    'If negrita = True Then
    'RichTextBox1.SelectionFont = New Font(cbFuentes.Text, Int(txtSize.Text),FontStyle.Bold)
    'Else
    'RichTextBox1.SelectionFont = New Font(cbFuentes.Text, Int(txtSize.Text),FontStyle.Regular)
    'End If
    'Catch ex As Exception
    'End Try
    'End Sub
    'Establece el color del texto mostrando el cuadro de dialogo con la paleta de colores con la clase ColorDialog
    Private Sub btnColor_Click(sender As Object, e As EventArgs) Handles btnColor.Click
        Try
            Dim dig As ColorDialog = New ColorDialog 'en la variable dig se almacenará el
            'Color que se ha elegido dig.Color = RichTextBox1.SelectionColor
            If dig.ShowDialog = System.Windows.Forms.DialogResult.OK Then
                txtEditor.SelectionColor = dig.Color
                btnColor.BackColor = dig.Color
            End If
        Catch ex As Exception
        End Try
    End Sub


End Class
