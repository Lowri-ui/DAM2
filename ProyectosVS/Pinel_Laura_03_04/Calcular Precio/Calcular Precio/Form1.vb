Public Class Form1
    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        End
    End Sub
    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        chbDescuento.Checked = False
        chbIva.Checked = False
        txtDescuento.Clear()
        txtPrecioConIva.Clear()
        txtPrecioSinIva.Clear()
        txtTotal.Clear()
    End Sub
    Private Sub btnGenerar_Click(sender As Object, e As EventArgs) Handles btnGenerar.Click
        Dim PrecioSinIva, PrecioConIva, Descuento, Total As Double

        'Validar entrada de precio sin IVA
        If Not Double.TryParse(txtPrecioSinIva.Text, PrecioSinIva) Then
            MessageBox.Show("Ingrese un número válido para el precio sin IVA.", "Error de entrada", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        'Calcular precio con IVA
        If chbIva.Checked Then
            PrecioConIva = PrecioSinIva * 1.21
        Else
            PrecioConIva = PrecioSinIva
        End If
        'Mostrar precio con IVA
        txtPrecioConIva.Text = Format(PrecioConIva)

        'Calcular descuento
        If chbDescuento.Checked Then
            If PrecioConIva >= 1000 Then
                Descuento = PrecioConIva * 0.15
            ElseIf PrecioConIva >= 500 Then
                Descuento = PrecioConIva * 0.1
            ElseIf PrecioConIva >= 100 Then
                Descuento = PrecioConIva * 0.05
            Else
                'Mostrar mensaje si no hay descuento
                MessageBox.Show("No hay descuento para precios menores a 100€.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Descuento = 0
            End If
        Else
            Descuento = 0
        End If
        'Mostrar descuento
        txtDescuento.Text = Format(Descuento)

        'Calcular total a pagar
        Total = PrecioConIva - Descuento
        'Mostrar total a pagar
        txtTotal.Text = Format(Total)
    End Sub

End Class
