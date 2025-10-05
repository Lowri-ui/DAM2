Public Class Form1
    Private Sub btnInicio_Click(sender As Object, e As EventArgs) Handles btnInicio.Click
        btnInicio.Show()
        Me.Hide()
    End Sub
    Private Sub btnMouseEnter_Click(sender As Object, e As EventArgs) Handles btnMouseEnter.Click
        MsgBox("Hola!, has entrado al botón")
    End Sub
    Private Sub btnMouseDown_Click(sender As Object, e As EventArgs) Handles btnMouseDown.Click
        MsgBox("Has presionado el botón")
    End Sub
    Private Sub btnMouseHover_Click(sender As Object, e As EventArgs) Handles btnMouseHover.Click
        Me.BackColor = Color.Aqua
    End Sub
    Private Sub btnMouseLeave_Click(sender As Object, e As EventArgs) Handles btnMouseLeave.Click
        Me.BackColor = Color.LightGray
    End Sub
    Private Sub btnMouseUp_Click(sender As Object, e As EventArgs) Handles btnMouseUP.Click
        MsgBox("Has soltado el botón")
    End Sub
    Private Sub btnMouseMove_Click(sender As Object, e As EventArgs) Handles btnMouseMove.Click
        Me.BackColor = Color.LightGreen
    End Sub
    Private Sub btnMouseWheel_Click(sender As Object, e As EventArgs) Handles btnMouseWheel.Click
        btnMouseWheel.Text = "Has usado la rueda del ratón"
    End Sub
    Private Sub btnKeyPress_Click(sender As Object, e As EventArgs) Handles btnKeyPress.Click
        Me.BackColor = Color.LightPink
    End Sub
End Class
