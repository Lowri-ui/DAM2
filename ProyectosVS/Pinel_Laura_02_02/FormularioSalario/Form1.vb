Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub lblHijos_Click(sender As Object, e As EventArgs) Handles lblHijos.Click
        Me.nudHijos.ForeColor = Color.SteelBlue
    End Sub

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        rbObrero.Checked = True
        rbAdministrativo.Checked = True
        rbTecnico.Checked = True
        rbProfesional.Checked = True
        rbSi.Checked = True
        rbNo.Checked = True
        rbMas.Checked = True
        rbMenos.Checked = True
        rbEntre.Checked = True
        nudHijos.Value = 0
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        End
    End Sub

    Private Sub btnCalcular_Click(sender As Object, e As EventArgs) Handles btnCalcular.Click
        Dim desglose As String
        Dim sueldo As Integer
        desglose = ""

        If rbObrero.Checked Then
            sueldo = 800
            desglose &= "Sueldo base: " & sueldo & vbCrLf
        ElseIf rbAdministrativo.Checked Then
            sueldo = 900
            desglose &= "Sueldo base: " & sueldo & vbCrLf
        ElseIf rbTecnico.Checked Then
            sueldo = 1000
            desglose &= "Sueldo base: " & sueldo & vbCrLf
        ElseIf rbProfesional.Checked Then
            sueldo = 1200
            desglose &= "Sueldo base: " & sueldo & vbCrLf
        End If

        If rbSi.Checked Then
            sueldo += 50
            desglose &= "Aumento por afiliación: 50" & vbCrLf
        End If

        If rbNo.Checked Then
            sueldo -= 25
            desglose &= "Descuento por no estar afiliado: -25" & vbCrLf
        End If

        If rbMas.Checked Then
            sueldo += 200
            desglose &= "Aumento por años: 200" & vbCrLf
        ElseIf rbMenos.Checked Then
            sueldo += 50
            desglose &= "Aumento por años: 50" & vbCrLf
        ElseIf rbEntre.Checked Then
            sueldo += 100
            desglose &= "Aumento por años: 100" & vbCrLf
        End If

        If nudHijos.Value > 0 Then
            Dim aumentoHijos As Integer = nudHijos.Value * 100
            sueldo += aumentoHijos
            desglose &= "Aumento por hijos (" & nudHijos.Value & "): " & aumentoHijos & vbCrLf
        End If

        desglose &= "Sueldo total: " & sueldo
        MessageBox.Show(desglose, "Desglose del sueldo")

    End Sub
End Class
