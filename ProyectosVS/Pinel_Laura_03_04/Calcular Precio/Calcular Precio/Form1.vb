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
        If chbIva.Checked Then
            txtPrecioConIva = PrecioSinIva * 1.21
            txtPrecioConIva = Format(txtPrecioConIva, "0.00")
        Else
            txtPrecioConIva = txtPrecioSinIva
            txtPrecioConIva = Format(txtPrecioConIva, "0.00")
        End If
        If chbDescuento.Checked Then
            If txtPrecioConIva >= 100 Then
                txtDescuento = txtPrecioConIva * 0.05
                txtDescuento = Format(txtDescuento, "0.00")
            ElseIf txtPrecioConIva >= 500 Then
                txtPrecioConIva = txtPrecioConIva * 0.1
                txtDescuento = Format(txtDescuento, "0.00")
            ElseIf txtPrecioConIva >= 1000 Then
                txtDescuento = txtPrecioConIva * 0.15
                txtDescuento = Format(txtDescuento, "0.00")
            End If
        Else
            txtDescuento = 0
            txtDescuento = Format(txtDescuento, "0.00")
        End If
        txtTotal = txtPrecioConIva - txtDescuento
        txtTotal = Format(txtTotal, "0.00")
    End Sub

End Class
