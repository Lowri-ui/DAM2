Public Class FormPrestamos
    Private Sub btnVolver_Click(sender As Object, e As EventArgs) Handles btnVolver.Click
        Me.Hide()
        FormInicio.Show()
    End Sub
    Private Sub btnConfirmarSolicitud_Click(sender As Object, e As EventArgs) Handles btnConfirmarSolicitud.Click
        Dim solucion As Double
        Dim penalizacionRaza As Double = 0
        Dim penalizacionLugar As Double = 0

        'Penalización por raza'
        Select Case cbRaza.SelectedItem.ToString()
            Case "Elfo"
                penalizacionRaza = 0.01  ' +1%
            Case "Hobbit"
                penalizacionRaza = 0.02  ' +2%
            Case "Humano"
                penalizacionRaza = 0.03  ' +3%
            Case "Troll"
                penalizacionRaza = 0.04  ' +4%
            Case "Orco"
                penalizacionRaza = 0.05  ' +5%
            Case "Mago"
                penalizacionRaza = 0.0   ' sin penalización
        End Select
        'Penalización por lugar'
        Select Case cbLugarOrigen.SelectedItem.ToString()
            Case "Mordor", "La Montaña Solitaria"
                penalizacionLugar = 100
            Case Else
                penalizacionLugar = 0
        End Select
        'Cálculo total'
        solucion = ((Val(txbMonto.Text) * (1 + penalizacionRaza)) + penalizacionLugar) / Val(cbCuotas.Text)
        FormSolucion.txbCuotaTotal.Text = Int(solucion)
        FormSolucion.Show()
        Me.Hide()

    End Sub
End Class