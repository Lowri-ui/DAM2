Public Class Form1

    Private Sub btnRestablecer_Click(sender As Object, e As EventArgs) Handles btnRestablecer.Click
        ' Restablecer la imagen original
        pcbCubo.Size = New Size(100, 50)
        ' Restablecer el color de fondo a blanco
        pcbCubo.BackColor = Color.Transparent
        'Restablecer la posición de la imagen'
        pcbCubo.Location = New Point(426, 194)
        ' Restablecer las selecciones de los RadioButtons
        rbBlanco.Checked = True
        rbNormal.Checked = True
        rbCentro.Checked = True
    End Sub
    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        End
    End Sub

    Private Sub rbBlanco_CheckedChanged(sender As Object, e As EventArgs) Handles rbBlanco.CheckedChanged
        If rbBlanco.Checked Then
            pcbCubo.BackColor = Color.White
        End If
    End Sub
    Private Sub rbRojo_CheckedChanged(sender As Object, e As EventArgs) Handles rbRojo.CheckedChanged
        If rbRojo.Checked Then
            pcbCubo.BackColor = Color.Red
        End If
    End Sub
    Private Sub rbAmarillo_CheckedChanged(sender As Object, e As EventArgs) Handles rbAmarillo.CheckedChanged
        If rbAmarillo.Checked Then
            pcbCubo.BackColor = Color.Yellow
        End If
    End Sub
    Private Sub rbVerde_CheckedChanged(sender As Object, e As EventArgs) Handles rbVerde.CheckedChanged
        If rbVerde.Checked Then
            pcbCubo.BackColor = Color.Green
        End If
    End Sub
    Private Sub rbAzul_CheckedChanged(sender As Object, e As EventArgs) Handles rbAzul.CheckedChanged
        If rbAzul.Checked Then
            pcbCubo.BackColor = Color.Blue
        End If
    End Sub
    Private Sub rbNormal_CheckedChanged(sender As Object, e As EventArgs) Handles rbNormal.CheckedChanged
        If rbNormal.Checked Then
            pcbCubo.Size = New Size(100, 50)
        End If
    End Sub
    Private Sub rbPequeño_CheckedChanged(sender As Object, e As EventArgs) Handles rbPequeño.CheckedChanged
        If rbPequeño.Checked Then
            pcbCubo.Size = New Size(50, 25)
        End If
    End Sub
    Private Sub rbGrande_CheckedChanged(sender As Object, e As EventArgs) Handles rbGrande.CheckedChanged
        If rbGrande.Checked Then
            pcbCubo.Size = New Size(200, 100)
        End If
    End Sub

    Private Sub rbCentro_CheckedChanged(sender As Object, e As EventArgs) Handles rbCentro.CheckedChanged
        If rbCentro.Checked Then
            pcbCubo.Location = New Point((Me.ClientSize.Width - pcbCubo.Width) / 2, (Me.ClientSize.Height - pcbCubo.Height) / 2)
        End If
    End Sub
    Private Sub rbArriba_CheckedChanged(sender As Object, e As EventArgs) Handles rbArriba.CheckedChanged
        If rbArriba.Checked Then
            pcbCubo.Location = New Point((Me.ClientSize.Width - pcbCubo.Width) / 2, 0)
        End If
    End Sub
    Private Sub rbAbajo_CheckedChanged(sender As Object, e As EventArgs) Handles rbAbajo.CheckedChanged
        If rbAbajo.Checked Then
            pcbCubo.Location = New Point((Me.ClientSize.Width - pcbCubo.Width) / 2, Me.ClientSize.Height - pcbCubo.Height)
        End If
    End Sub

End Class
