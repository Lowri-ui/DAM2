<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        lblNumero1 = New Label()
        lblNumero2 = New Label()
        tbValor1 = New TextBox()
        tbValor2 = New TextBox()
        tbResultado = New TextBox()
        lblResultado = New Label()
        btnSuma = New Button()
        btnResta = New Button()
        btnMultiplicar = New Button()
        btnDividir = New Button()
        btnBorrar = New Button()
        btnSalir = New Button()
        SuspendLayout()
        ' 
        ' lblNumero1
        ' 
        lblNumero1.AutoSize = True
        lblNumero1.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold)
        lblNumero1.ForeColor = SystemColors.ActiveCaptionText
        lblNumero1.Location = New Point(182, 50)
        lblNumero1.Name = "lblNumero1"
        lblNumero1.Size = New Size(177, 17)
        lblNumero1.TabIndex = 0
        lblNumero1.Text = "Introduce el primer número"
        ' 
        ' lblNumero2
        ' 
        lblNumero2.AutoSize = True
        lblNumero2.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold)
        lblNumero2.ForeColor = SystemColors.ActiveCaptionText
        lblNumero2.Location = New Point(182, 150)
        lblNumero2.Name = "lblNumero2"
        lblNumero2.Size = New Size(190, 17)
        lblNumero2.TabIndex = 1
        lblNumero2.Text = "Introduce el segundo número"
        ' 
        ' tbValor1
        ' 
        tbValor1.Location = New Point(196, 81)
        tbValor1.Name = "tbValor1"
        tbValor1.Size = New Size(145, 23)
        tbValor1.TabIndex = 2
        ' 
        ' tbValor2
        ' 
        tbValor2.Location = New Point(196, 180)
        tbValor2.Name = "tbValor2"
        tbValor2.Size = New Size(145, 23)
        tbValor2.TabIndex = 3
        ' 
        ' tbResultado
        ' 
        tbResultado.Location = New Point(196, 408)
        tbResultado.Name = "tbResultado"
        tbResultado.Size = New Size(145, 23)
        tbResultado.TabIndex = 4
        ' 
        ' lblResultado
        ' 
        lblResultado.AutoSize = True
        lblResultado.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold)
        lblResultado.ForeColor = SystemColors.ActiveCaptionText
        lblResultado.Location = New Point(230, 375)
        lblResultado.Name = "lblResultado"
        lblResultado.Size = New Size(71, 17)
        lblResultado.TabIndex = 5
        lblResultado.Text = "Resultado:"
        ' 
        ' btnSuma
        ' 
        btnSuma.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold)
        btnSuma.ForeColor = Color.DarkSlateGray
        btnSuma.Location = New Point(167, 260)
        btnSuma.Name = "btnSuma"
        btnSuma.Size = New Size(93, 34)
        btnSuma.TabIndex = 6
        btnSuma.Text = "SUMAR"
        btnSuma.UseVisualStyleBackColor = True
        ' 
        ' btnResta
        ' 
        btnResta.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold)
        btnResta.ForeColor = Color.DarkSlateGray
        btnResta.Location = New Point(275, 260)
        btnResta.Name = "btnResta"
        btnResta.Size = New Size(93, 34)
        btnResta.TabIndex = 7
        btnResta.Text = "RESTAR"
        btnResta.UseVisualStyleBackColor = True
        ' 
        ' btnMultiplicar
        ' 
        btnMultiplicar.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold)
        btnMultiplicar.ForeColor = Color.DarkSlateGray
        btnMultiplicar.Location = New Point(167, 301)
        btnMultiplicar.Name = "btnMultiplicar"
        btnMultiplicar.Size = New Size(102, 34)
        btnMultiplicar.TabIndex = 8
        btnMultiplicar.Text = "MULTIPLICAR"
        btnMultiplicar.UseVisualStyleBackColor = True
        ' 
        ' btnDividir
        ' 
        btnDividir.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold)
        btnDividir.ForeColor = Color.DarkSlateGray
        btnDividir.Location = New Point(275, 301)
        btnDividir.Name = "btnDividir"
        btnDividir.Size = New Size(93, 34)
        btnDividir.TabIndex = 9
        btnDividir.Text = "DIVIDIR"
        btnDividir.UseVisualStyleBackColor = True
        ' 
        ' btnBorrar
        ' 
        btnBorrar.Font = New Font("Segoe UI", 11.25F, FontStyle.Bold)
        btnBorrar.ForeColor = Color.DarkSlateGray
        btnBorrar.Location = New Point(182, 471)
        btnBorrar.Name = "btnBorrar"
        btnBorrar.Size = New Size(75, 30)
        btnBorrar.TabIndex = 10
        btnBorrar.Text = "BORRAR"
        btnBorrar.UseVisualStyleBackColor = True
        ' 
        ' btnSalir
        ' 
        btnSalir.Font = New Font("Segoe UI", 11.25F, FontStyle.Bold)
        btnSalir.ForeColor = Color.DarkSlateGray
        btnSalir.Location = New Point(275, 471)
        btnSalir.Name = "btnSalir"
        btnSalir.Size = New Size(75, 30)
        btnSalir.TabIndex = 11
        btnSalir.Text = "SALIR"
        btnSalir.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.LightSteelBlue
        ClientSize = New Size(543, 558)
        Controls.Add(btnSalir)
        Controls.Add(btnBorrar)
        Controls.Add(btnDividir)
        Controls.Add(btnMultiplicar)
        Controls.Add(btnResta)
        Controls.Add(btnSuma)
        Controls.Add(lblResultado)
        Controls.Add(tbResultado)
        Controls.Add(tbValor2)
        Controls.Add(tbValor1)
        Controls.Add(lblNumero2)
        Controls.Add(lblNumero1)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblNumero1 As Label
    Friend WithEvents lblNumero2 As Label
    Friend WithEvents tbValor1 As TextBox
    Friend WithEvents tbValor2 As TextBox
    Friend WithEvents tbResultado As TextBox
    Friend WithEvents lblResultado As Label
    Friend WithEvents btnSuma As Button
    Friend WithEvents btnResta As Button
    Friend WithEvents btnMultiplicar As Button
    Friend WithEvents btnDividir As Button
    Friend WithEvents btnBorrar As Button
    Friend WithEvents btnSalir As Button

End Class
