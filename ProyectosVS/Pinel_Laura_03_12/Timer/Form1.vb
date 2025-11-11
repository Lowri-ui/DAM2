Public Class Form1
    Dim tiempoRestante As Integer = 30 ' Tiempo en segundos para el juego
    Dim distanciaBob As Integer = 20 ' Distancia en pixeles que Bob va a recorrer con cada clic de Inicio
    Dim juegoIniciado As Boolean = False ' Estado del juego

    Private Sub btnIniciar_Click(sender As Object, e As EventArgs) Handles btnIniciar.Click
        If Not juegoIniciado Then
            juegoIniciado = True
            tiempoRestante = 30
            lblTimer.Text = tiempoRestante.ToString()
            Timer1.Start()
        End If

        pbBob.Left += distanciaBob 'movemos a Bob hacia la derecha

        ' Verificamos si Bob ha llegado a la oficina
        If pbBob.Right >= pbOficina.Left Then
            MessageBox.Show("¡Felicidades! Bob ha llegado al final.")
            Timer1.Stop()
            juegoIniciado = False
        End If
    End Sub


End Class
