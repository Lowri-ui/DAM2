Public Class Form1
    Dim memoria1 As Double = 0.0
    Dim memoria2 As Double = 0.0
    Dim signo As String

    'BOTONES NUMÉRICOS

    Private Sub btn0_Click(sender As Object, e As EventArgs) Handles btn0.Click
        txb1.Text &= "0"
    End Sub

    Private Sub btn1_Click(sender As Object, e As EventArgs) Handles btn1.Click
        txb1.Text &= "1"
    End Sub

    Private Sub btn2_Click(sender As Object, e As EventArgs) Handles btn2.Click
        txb1.Text &= "2"
    End Sub

    Private Sub btn3_Click(sender As Object, e As EventArgs) Handles btn3.Click
        txb1.Text &= "3"
    End Sub

    Private Sub btn4_Click(sender As Object, e As EventArgs) Handles btn4.Click
        txb1.Text &= "4"
    End Sub

    Private Sub btn5_Click(sender As Object, e As EventArgs) Handles btn5.Click
        txb1.Text &= "5"
    End Sub

    Private Sub btn6_Click(sender As Object, e As EventArgs) Handles btn6.Click
        txb1.Text &= "6"
    End Sub

    Private Sub btn7_Click(sender As Object, e As EventArgs) Handles btn7.Click
        txb1.Text &= "7"
    End Sub

    Private Sub btn8_Click(sender As Object, e As EventArgs) Handles btn8.Click
        txb1.Text &= "8"
    End Sub

    Private Sub btn9_Click(sender As Object, e As EventArgs) Handles btn9.Click
        txb1.Text &= "9"
    End Sub

    'OPERACIONES

    Private Sub btnSumar_Click(sender As Object, e As EventArgs) Handles btnSumar.Click
        If txb1.Text <> "" Then
            memoria1 = Val(txb1.Text)
            signo = "+"
            txb1.Clear()
        End If
    End Sub

    Private Sub btnRestar_Click(sender As Object, e As EventArgs) Handles btnRestar.Click
        If txb1.Text <> "" Then
            memoria1 = Val(txb1.Text)
            signo = "-"
            txb1.Clear()
        End If
    End Sub

    Private Sub btnMultiplicar_Click(sender As Object, e As EventArgs) Handles btnMultiplicar.Click
        If txb1.Text <> "" Then
            memoria1 = Val(txb1.Text)
            signo = "*"
            txb1.Clear()
        End If
    End Sub

    Private Sub btnDividir_Click(sender As Object, e As EventArgs) Handles btnDividir.Click
        If txb1.Text <> "" Then
            memoria1 = Val(txb1.Text)
            signo = "/"
            txb1.Clear()
        End If
    End Sub

    Private Sub btnRaizCuadrada_Click(sender As Object, e As EventArgs) Handles btnRaizCuadrada.Click
        If txb1.Text <> "" Then
            memoria1 = Val(txb1.Text)
            signo = "raiz"
            txb1.Clear()
        End If
    End Sub

    Private Sub btnPotencia_Click(sender As Object, e As EventArgs) Handles btnPotencia.Click
        If txb1.Text <> "" Then
            memoria1 = Val(txb1.Text)
            signo = "exponente"
            txb1.Clear()
        End If
    End Sub

    Private Sub btnPorcentaje_Click(sender As Object, e As EventArgs) Handles btnPorcentaje.Click
        If txb1.Text <> "" Then
            memoria1 = Val(txb1.Text)
            signo = "%"
            txb1.Clear()
        End If
    End Sub

    'BOTONES ESPECIALES

    Private Sub btnCE_Click(sender As Object, e As EventArgs) Handles btnCE.Click
        txb1.Clear()
        memoria1 = 0.0
        memoria2 = 0.0
        signo = String.Empty
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        If txb1.Text <> "" Then
            txb1.Text = Mid(txb1.Text, 1, txb1.Text.Length - 1)
        End If
    End Sub

    Private Sub btnMasMenos_Click(sender As Object, e As EventArgs) Handles btnMasMenos.Click
        If txb1.Text <> "" Then
            txb1.Text = Val(txb1.Text) * (-1)
        End If
    End Sub

    Private Sub btnFraccion_Click(sender As Object, e As EventArgs) Handles btnFraccion.Click
        If txb1.Text <> "" Then
            txb1.Text = 1 / Val(txb1.Text)
        End If
    End Sub

    Private Sub btnPuntoDecimal_Click(sender As Object, e As EventArgs) Handles btnPuntoDecimal.Click
        If InStr(txb1.Text, ".", CompareMethod.Text) = 0 Then
            If txb1.Text = "" Then
                txb1.Text = "0."
            Else
                txb1.Text &= "."
            End If
        End If
    End Sub

    'BOTÓN IGUAL

    Private Sub btnResultado_Click(sender As Object, e As EventArgs) Handles btnResultado.Click
        If txb1.Text <> "" And memoria1 <> 0.0 Then
            memoria2 = Val(txb1.Text)
            calculadora()
        End If
    End Sub

    Private Sub calculadora()
        Select Case signo
            Case "+"
                txb1.Text = memoria1 + memoria2
            Case "-"
                txb1.Text = memoria1 - memoria2
            Case "*"
                txb1.Text = memoria1 * memoria2
            Case "/"
                txb1.Text = memoria1 / memoria2
            Case "raiz"
                txb1.Text = memoria1 ^ (1 / memoria2)
            Case "exponente"
                txb1.Text = memoria1 ^ memoria2
            Case "%"
                txb1.Text = (memoria1 * memoria2) / 100
            Case Else
                MsgBox("Error")
        End Select
    End Sub

    'EXTRA: Centrar el panel en el formulario
    'Código para centrar el panel en el formulario al cargar y redimensionar
    Private Sub Form1_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        ' Centra el panel en el medio del formulario
        Panel1.Left = (Me.ClientSize.Width - Panel1.Width) / 2
        Panel1.Top = (Me.ClientSize.Height - Panel1.Height) / 2 - 30 ' lo subimos un poco
    End Sub

End Class
