Public Class Form1
    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        txbNombre.Clear()
        txbDireccion.Clear()
        txbTelefono.Clear()
        txbPedido.Clear()
        DateTimePicker1.Value = DateTime.Now
    End Sub
    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        End
    End Sub
    Private Sub btnConfirmar_Click(sender As Object, e As EventArgs) Handles btnConfirmar.Click
        Dim nombre As String = txbNombre.Text
        Dim direccion As String = txbDireccion.Text
        Dim telefono As String = txbTelefono.Text
        Dim pedido As String = txbPedido.Text
        Dim fecha As String = DateTimePicker1.Value.ToShortDateString()

        ListBox1.Items.Add(nombre)
        ListBox1.Items.Add(direccion)
        ListBox1.Items.Add(telefono)
        ListBox1.Items.Add(pedido)
        ListBox1.Items.Add(fecha)
        ListBox1.Items.Add("--------------------------------------------------")

        Dim rutaPedidos As String = "D:\Pedidos\pedidos.txt"
        My.Computer.FileSystem.WriteAllText(rutaPedidos, vbCrLf & "Nombre: " & nombre & " Teléfono: " & telefono & " Dirección: " & direccion & " Pedido: " & pedido & " Fecha: " & fecha & vbCrLf, True)
        MessageBox.Show("Pedido guardado en " & rutaPedidos, "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub
End Class
