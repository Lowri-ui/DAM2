Public Class Form1

    Dim tiempoRestante As Integer = 45 ' Tiempo en segundos para el juego
    Dim distanciaBob As Integer = 25 ' Distancia en pixeles que Bob va a recorrer con cada clic de Inicio
    Dim juegoIniciado As Boolean = False ' Estado del juego

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        End 'salimos del juego  
    End Sub
    Private Sub btnIniciar_Click(sender As Object, e As EventArgs) Handles btnIniciar.Click
        If Not juegoIniciado Then 'si el juego no ha iniciado
            juegoIniciado = True 'cambiamos el estado del juego a iniciado
            tiempoRestante = 45 'reseteamos el tiempo restante
            lblTimer.Text = tiempoRestante.ToString() 'actualizamos el label del timer
            Timer1.Start() 'iniciamos el timer
        End If

        pbBob.Left += distanciaBob 'movemos a Bob hacia la derecha
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If Not juegoIniciado Then
            Return ' Si el juego no ha iniciado, no hacemos nada
        End If

        tiempoRestante -= 1 'disminuimos el tiempo restante
        lblTimer.Text = tiempoRestante.ToString() 'actualizamos el label del timer

        If tiempoRestante <= 0 Then 'si el tiempo se ha acabado
            Timer1.Stop() 'detenemos el timer
            juegoIniciado = False 'reiniciamos el estado del juego
            If pbBob.Right < pbOficina.Left Then 'si Bob no ha llegado a la oficina
                MessageBox.Show("¡Se acabó el tiempo! Bob no llegó a la oficina a tiempo.") 'mostramos mensaje de que se acabó el tiempo
            End If
        End If

        If pbBob.Right >= pbOficina.Left Then 'si Bob ha llegado a la oficina
            Timer1.Stop() 'detenemos el timer
            juegoIniciado = False 'reiniciamos el estado del juego
            MessageBox.Show("¡Felicidades! Bob ha llegado a la oficina.")
        End If
    End Sub

    Private Sub btnPausa_Click(sender As Object, e As EventArgs) Handles btnPausa.Click
        If juegoIniciado Then 'si el juego ha iniciado
            Timer1.Stop() 'detenemos el timer
            juegoIniciado = False 'reiniciamos el estado del juego
        End If
    End Sub
    Private Sub btnVolver_Click(sender As Object, e As EventArgs) Handles btnVolver.Click
        Timer1.Stop() ' Detener el temporizador
        juegoIniciado = False ' Reiniciar el estado del juego
        tiempoRestante = 30 ' Restablecer el tiempo restante
        lblTimer.Text = tiempoRestante.ToString() ' Actualizar el label del temporizador

        ' Restablecer posición del muñeco
        pbBob.Left = 10

    End Sub

End Class
