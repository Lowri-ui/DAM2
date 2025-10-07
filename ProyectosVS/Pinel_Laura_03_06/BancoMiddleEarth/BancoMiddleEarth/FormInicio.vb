Public Class FormInicio
    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        End
    End Sub
    Private Sub btnSolicitud_Click(sender As Object, e As EventArgs) Handles btnSolicitud.Click
        ' Validar que haya nombre
        If txbIngresoDeNombre.Text.Trim() = "" Then
            MessageBox.Show("Por favor, ingrese su nombre.")
            Return
        End If

        ' Guardar el nombre en la variable pública o pasarla al siguiente formulario
        FormPrestamos.lblBienvenido.Text = "Bienvenid@, " & txbIngresoDeNombre.Text

        ' Mostrar FormPrestamos y ocultar este
        FormPrestamos.Show()
        Me.Hide()
    End Sub
End Class
