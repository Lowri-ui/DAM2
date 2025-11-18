Public Class Form1

    Dim num1 As Double
    Dim num2 As Double
    Dim num3 As Double

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        End
    End Sub

    Private Sub Limpiar_Click(sender As Object, e As EventArgs) Handles btnBorrar.Click
        tbValor1.Clear()
        tbValor2.Clear()
        tbResultado.Clear()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles btnMultiplicar.Click
        num1 = Val(tbValor1.Text)
        num2 = Val(tbValor2.Text)
        num3 = num1 * num2
        tbResultado.Text = num3
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles btnDividir.Click
        num1 = Val(tbValor1.Text)
        num2 = Val(tbValor2.Text)
        num3 = num1 / num2
        tbResultado.Text = num3
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles btnSuma.Click
        num1 = Val(tbValor1.Text)
        num2 = Val(tbValor2.Text)
        num3 = num1 + num2
        tbResultado.Text = num3
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnResta.Click
        num1 = Val(tbValor1.Text)
        num2 = Val(tbValor2.Text)
        num3 = num1 - num2
        tbResultado.Text = num3
    End Sub

End Class
