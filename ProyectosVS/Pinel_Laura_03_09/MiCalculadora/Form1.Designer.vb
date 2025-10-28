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
        txb1 = New TextBox()
        btnCE = New Button()
        btnEliminar = New Button()
        btnMasMenos = New Button()
        btnPorcentaje = New Button()
        btnRaizCuadrada = New Button()
        btnPotencia = New Button()
        btnDividir = New Button()
        btn9 = New Button()
        btn8 = New Button()
        btn7 = New Button()
        btnFraccion = New Button()
        btnMultiplicar = New Button()
        btn6 = New Button()
        btn5 = New Button()
        btn4 = New Button()
        btnResultado = New Button()
        btnRestar = New Button()
        btn3 = New Button()
        btn2 = New Button()
        btn1 = New Button()
        btnSumar = New Button()
        btnPuntoDecimal = New Button()
        btn0 = New Button()
        lblNombreCalculadora = New Label()
        Panel1 = New Panel()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' txb1
        ' 
        txb1.Font = New Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txb1.Location = New Point(15, 20)
        txb1.Name = "txb1"
        txb1.Size = New Size(630, 33)
        txb1.TabIndex = 0
        ' 
        ' btnCE
        ' 
        btnCE.BackColor = Color.FromArgb(CByte(0), CByte(150), CByte(136))
        btnCE.FlatAppearance.BorderSize = 0
        btnCE.FlatStyle = FlatStyle.Flat
        btnCE.Font = New Font("Verdana", 9F, FontStyle.Bold)
        btnCE.ForeColor = Color.WhiteSmoke
        btnCE.Location = New Point(91, 78)
        btnCE.Name = "btnCE"
        btnCE.Size = New Size(70, 72)
        btnCE.TabIndex = 1
        btnCE.Text = "CE"
        btnCE.UseVisualStyleBackColor = False
        ' 
        ' btnEliminar
        ' 
        btnEliminar.BackColor = Color.FromArgb(CByte(80), CByte(80), CByte(80))
        btnEliminar.FlatAppearance.BorderSize = 0
        btnEliminar.FlatStyle = FlatStyle.Flat
        btnEliminar.Font = New Font("Verdana", 9F, FontStyle.Bold)
        btnEliminar.ForeColor = Color.WhiteSmoke
        btnEliminar.Location = New Point(187, 78)
        btnEliminar.Name = "btnEliminar"
        btnEliminar.Size = New Size(70, 72)
        btnEliminar.TabIndex = 2
        btnEliminar.Text = "<--"
        btnEliminar.UseVisualStyleBackColor = False
        ' 
        ' btnMasMenos
        ' 
        btnMasMenos.BackColor = Color.FromArgb(CByte(80), CByte(80), CByte(80))
        btnMasMenos.FlatAppearance.BorderSize = 0
        btnMasMenos.FlatStyle = FlatStyle.Flat
        btnMasMenos.Font = New Font("Verdana", 9F, FontStyle.Bold)
        btnMasMenos.ForeColor = Color.WhiteSmoke
        btnMasMenos.Location = New Point(393, 78)
        btnMasMenos.Name = "btnMasMenos"
        btnMasMenos.Size = New Size(70, 72)
        btnMasMenos.TabIndex = 4
        btnMasMenos.Text = "+/-"
        btnMasMenos.UseVisualStyleBackColor = False
        ' 
        ' btnPorcentaje
        ' 
        btnPorcentaje.BackColor = Color.FromArgb(CByte(80), CByte(80), CByte(80))
        btnPorcentaje.FlatAppearance.BorderSize = 0
        btnPorcentaje.FlatStyle = FlatStyle.Flat
        btnPorcentaje.Font = New Font("Verdana", 9F, FontStyle.Bold)
        btnPorcentaje.ForeColor = Color.WhiteSmoke
        btnPorcentaje.Location = New Point(288, 78)
        btnPorcentaje.Name = "btnPorcentaje"
        btnPorcentaje.Size = New Size(70, 72)
        btnPorcentaje.TabIndex = 3
        btnPorcentaje.Text = "%"
        btnPorcentaje.UseVisualStyleBackColor = False
        ' 
        ' btnRaizCuadrada
        ' 
        btnRaizCuadrada.BackColor = Color.FromArgb(CByte(80), CByte(80), CByte(80))
        btnRaizCuadrada.FlatAppearance.BorderSize = 0
        btnRaizCuadrada.FlatStyle = FlatStyle.Flat
        btnRaizCuadrada.Font = New Font("Verdana", 9F, FontStyle.Bold)
        btnRaizCuadrada.ForeColor = Color.WhiteSmoke
        btnRaizCuadrada.Location = New Point(491, 78)
        btnRaizCuadrada.Name = "btnRaizCuadrada"
        btnRaizCuadrada.Size = New Size(70, 72)
        btnRaizCuadrada.TabIndex = 5
        btnRaizCuadrada.Text = "√"
        btnRaizCuadrada.UseVisualStyleBackColor = False
        ' 
        ' btnPotencia
        ' 
        btnPotencia.BackColor = Color.FromArgb(CByte(80), CByte(80), CByte(80))
        btnPotencia.FlatAppearance.BorderSize = 0
        btnPotencia.FlatStyle = FlatStyle.Flat
        btnPotencia.Font = New Font("Verdana", 9F, FontStyle.Bold)
        btnPotencia.ForeColor = Color.WhiteSmoke
        btnPotencia.Location = New Point(491, 174)
        btnPotencia.Name = "btnPotencia"
        btnPotencia.Size = New Size(70, 72)
        btnPotencia.TabIndex = 10
        btnPotencia.Text = "^"
        btnPotencia.UseVisualStyleBackColor = False
        ' 
        ' btnDividir
        ' 
        btnDividir.BackColor = Color.FromArgb(CByte(80), CByte(80), CByte(80))
        btnDividir.FlatAppearance.BorderSize = 0
        btnDividir.FlatStyle = FlatStyle.Flat
        btnDividir.Font = New Font("Verdana", 9F, FontStyle.Bold)
        btnDividir.ForeColor = Color.WhiteSmoke
        btnDividir.Location = New Point(393, 174)
        btnDividir.Name = "btnDividir"
        btnDividir.Size = New Size(70, 72)
        btnDividir.TabIndex = 9
        btnDividir.Text = "/"
        btnDividir.UseVisualStyleBackColor = False
        ' 
        ' btn9
        ' 
        btn9.BackColor = Color.FromArgb(CByte(60), CByte(60), CByte(60))
        btn9.FlatAppearance.BorderSize = 0
        btn9.FlatStyle = FlatStyle.Flat
        btn9.Font = New Font("Verdana", 9F, FontStyle.Bold)
        btn9.ForeColor = Color.WhiteSmoke
        btn9.Location = New Point(288, 174)
        btn9.Name = "btn9"
        btn9.Size = New Size(70, 72)
        btn9.TabIndex = 8
        btn9.Text = "9"
        btn9.UseVisualStyleBackColor = False
        ' 
        ' btn8
        ' 
        btn8.BackColor = Color.FromArgb(CByte(60), CByte(60), CByte(60))
        btn8.FlatAppearance.BorderSize = 0
        btn8.FlatStyle = FlatStyle.Flat
        btn8.Font = New Font("Verdana", 9F, FontStyle.Bold)
        btn8.ForeColor = Color.WhiteSmoke
        btn8.Location = New Point(187, 174)
        btn8.Name = "btn8"
        btn8.Size = New Size(70, 72)
        btn8.TabIndex = 7
        btn8.Text = "8"
        btn8.UseVisualStyleBackColor = False
        ' 
        ' btn7
        ' 
        btn7.BackColor = Color.FromArgb(CByte(60), CByte(60), CByte(60))
        btn7.FlatAppearance.BorderSize = 0
        btn7.FlatStyle = FlatStyle.Flat
        btn7.Font = New Font("Verdana", 9F, FontStyle.Bold)
        btn7.ForeColor = Color.WhiteSmoke
        btn7.Location = New Point(91, 174)
        btn7.Name = "btn7"
        btn7.Size = New Size(70, 72)
        btn7.TabIndex = 6
        btn7.Text = "7"
        btn7.UseVisualStyleBackColor = False
        ' 
        ' btnFraccion
        ' 
        btnFraccion.BackColor = Color.FromArgb(CByte(80), CByte(80), CByte(80))
        btnFraccion.FlatAppearance.BorderSize = 0
        btnFraccion.FlatStyle = FlatStyle.Flat
        btnFraccion.Font = New Font("Verdana", 9F, FontStyle.Bold)
        btnFraccion.ForeColor = Color.WhiteSmoke
        btnFraccion.Location = New Point(491, 267)
        btnFraccion.Name = "btnFraccion"
        btnFraccion.Size = New Size(70, 72)
        btnFraccion.TabIndex = 15
        btnFraccion.Text = "1/X"
        btnFraccion.UseVisualStyleBackColor = False
        ' 
        ' btnMultiplicar
        ' 
        btnMultiplicar.BackColor = Color.FromArgb(CByte(80), CByte(80), CByte(80))
        btnMultiplicar.FlatAppearance.BorderSize = 0
        btnMultiplicar.FlatStyle = FlatStyle.Flat
        btnMultiplicar.Font = New Font("Verdana", 9F, FontStyle.Bold)
        btnMultiplicar.ForeColor = Color.WhiteSmoke
        btnMultiplicar.Location = New Point(393, 267)
        btnMultiplicar.Name = "btnMultiplicar"
        btnMultiplicar.Size = New Size(70, 72)
        btnMultiplicar.TabIndex = 14
        btnMultiplicar.Text = "*"
        btnMultiplicar.UseVisualStyleBackColor = False
        ' 
        ' btn6
        ' 
        btn6.BackColor = Color.FromArgb(CByte(60), CByte(60), CByte(60))
        btn6.FlatAppearance.BorderSize = 0
        btn6.FlatStyle = FlatStyle.Flat
        btn6.Font = New Font("Verdana", 9F, FontStyle.Bold)
        btn6.ForeColor = Color.WhiteSmoke
        btn6.Location = New Point(288, 267)
        btn6.Name = "btn6"
        btn6.Size = New Size(70, 72)
        btn6.TabIndex = 13
        btn6.Text = "6"
        btn6.UseVisualStyleBackColor = False
        ' 
        ' btn5
        ' 
        btn5.BackColor = Color.FromArgb(CByte(60), CByte(60), CByte(60))
        btn5.FlatAppearance.BorderSize = 0
        btn5.FlatStyle = FlatStyle.Flat
        btn5.Font = New Font("Verdana", 9F, FontStyle.Bold)
        btn5.ForeColor = Color.WhiteSmoke
        btn5.Location = New Point(187, 267)
        btn5.Name = "btn5"
        btn5.Size = New Size(70, 72)
        btn5.TabIndex = 12
        btn5.Text = "5"
        btn5.UseVisualStyleBackColor = False
        ' 
        ' btn4
        ' 
        btn4.BackColor = Color.FromArgb(CByte(60), CByte(60), CByte(60))
        btn4.FlatAppearance.BorderSize = 0
        btn4.FlatStyle = FlatStyle.Flat
        btn4.Font = New Font("Verdana", 9F, FontStyle.Bold)
        btn4.ForeColor = Color.WhiteSmoke
        btn4.Location = New Point(91, 267)
        btn4.Name = "btn4"
        btn4.Size = New Size(70, 72)
        btn4.TabIndex = 11
        btn4.Text = "4"
        btn4.UseVisualStyleBackColor = False
        ' 
        ' btnResultado
        ' 
        btnResultado.BackColor = Color.FromArgb(CByte(0), CByte(150), CByte(136))
        btnResultado.FlatAppearance.BorderSize = 0
        btnResultado.FlatStyle = FlatStyle.Flat
        btnResultado.Font = New Font("Verdana", 9F, FontStyle.Bold)
        btnResultado.ForeColor = Color.WhiteSmoke
        btnResultado.Location = New Point(491, 359)
        btnResultado.Name = "btnResultado"
        btnResultado.Size = New Size(70, 151)
        btnResultado.TabIndex = 20
        btnResultado.Text = "="
        btnResultado.UseVisualStyleBackColor = False
        ' 
        ' btnRestar
        ' 
        btnRestar.BackColor = Color.FromArgb(CByte(80), CByte(80), CByte(80))
        btnRestar.FlatAppearance.BorderSize = 0
        btnRestar.FlatStyle = FlatStyle.Flat
        btnRestar.Font = New Font("Verdana", 9F, FontStyle.Bold)
        btnRestar.ForeColor = Color.WhiteSmoke
        btnRestar.Location = New Point(393, 359)
        btnRestar.Name = "btnRestar"
        btnRestar.Size = New Size(70, 72)
        btnRestar.TabIndex = 19
        btnRestar.Text = "-"
        btnRestar.UseVisualStyleBackColor = False
        ' 
        ' btn3
        ' 
        btn3.BackColor = Color.FromArgb(CByte(60), CByte(60), CByte(60))
        btn3.FlatAppearance.BorderSize = 0
        btn3.FlatStyle = FlatStyle.Flat
        btn3.Font = New Font("Verdana", 9F, FontStyle.Bold)
        btn3.ForeColor = Color.WhiteSmoke
        btn3.Location = New Point(288, 359)
        btn3.Name = "btn3"
        btn3.Size = New Size(70, 72)
        btn3.TabIndex = 18
        btn3.Text = "3"
        btn3.UseVisualStyleBackColor = False
        ' 
        ' btn2
        ' 
        btn2.BackColor = Color.FromArgb(CByte(60), CByte(60), CByte(60))
        btn2.FlatAppearance.BorderSize = 0
        btn2.FlatStyle = FlatStyle.Flat
        btn2.Font = New Font("Verdana", 9F, FontStyle.Bold)
        btn2.ForeColor = Color.WhiteSmoke
        btn2.Location = New Point(187, 359)
        btn2.Name = "btn2"
        btn2.Size = New Size(70, 72)
        btn2.TabIndex = 17
        btn2.Text = "2"
        btn2.UseVisualStyleBackColor = False
        ' 
        ' btn1
        ' 
        btn1.BackColor = Color.FromArgb(CByte(60), CByte(60), CByte(60))
        btn1.FlatAppearance.BorderSize = 0
        btn1.FlatStyle = FlatStyle.Flat
        btn1.Font = New Font("Verdana", 9F, FontStyle.Bold)
        btn1.ForeColor = Color.WhiteSmoke
        btn1.Location = New Point(91, 359)
        btn1.Name = "btn1"
        btn1.Size = New Size(70, 72)
        btn1.TabIndex = 16
        btn1.Text = "1"
        btn1.UseVisualStyleBackColor = False
        ' 
        ' btnSumar
        ' 
        btnSumar.BackColor = Color.FromArgb(CByte(80), CByte(80), CByte(80))
        btnSumar.FlatAppearance.BorderSize = 0
        btnSumar.FlatStyle = FlatStyle.Flat
        btnSumar.Font = New Font("Verdana", 9F, FontStyle.Bold)
        btnSumar.ForeColor = Color.WhiteSmoke
        btnSumar.Location = New Point(393, 438)
        btnSumar.Name = "btnSumar"
        btnSumar.Size = New Size(70, 72)
        btnSumar.TabIndex = 24
        btnSumar.Text = "+"
        btnSumar.UseVisualStyleBackColor = False
        ' 
        ' btnPuntoDecimal
        ' 
        btnPuntoDecimal.BackColor = Color.FromArgb(CByte(80), CByte(80), CByte(80))
        btnPuntoDecimal.FlatAppearance.BorderSize = 0
        btnPuntoDecimal.FlatStyle = FlatStyle.Flat
        btnPuntoDecimal.Font = New Font("Verdana", 9F, FontStyle.Bold)
        btnPuntoDecimal.ForeColor = Color.WhiteSmoke
        btnPuntoDecimal.Location = New Point(288, 438)
        btnPuntoDecimal.Name = "btnPuntoDecimal"
        btnPuntoDecimal.Size = New Size(70, 72)
        btnPuntoDecimal.TabIndex = 23
        btnPuntoDecimal.Text = "."
        btnPuntoDecimal.UseVisualStyleBackColor = False
        ' 
        ' btn0
        ' 
        btn0.BackColor = Color.FromArgb(CByte(60), CByte(60), CByte(60))
        btn0.FlatAppearance.BorderSize = 0
        btn0.FlatStyle = FlatStyle.Flat
        btn0.Font = New Font("Verdana", 9F, FontStyle.Bold)
        btn0.ForeColor = Color.WhiteSmoke
        btn0.Location = New Point(91, 438)
        btn0.Name = "btn0"
        btn0.Size = New Size(166, 72)
        btn0.TabIndex = 22
        btn0.Text = "0"
        btn0.UseVisualStyleBackColor = False
        ' 
        ' lblNombreCalculadora
        ' 
        lblNombreCalculadora.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        lblNombreCalculadora.AutoSize = True
        lblNombreCalculadora.Font = New Font("Rockwell", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblNombreCalculadora.ForeColor = Color.WhiteSmoke
        lblNombreCalculadora.Location = New Point(412, 544)
        lblNombreCalculadora.Name = "lblNombreCalculadora"
        lblNombreCalculadora.Size = New Size(235, 14)
        lblNombreCalculadora.TabIndex = 25
        lblNombreCalculadora.Text = "CALCULADORAS Laura Pinel García ®"
        ' 
        ' Panel1
        ' 
        Panel1.Anchor = AnchorStyles.None
        Panel1.Controls.Add(lblNombreCalculadora)
        Panel1.Controls.Add(btnResultado)
        Panel1.Controls.Add(btnSumar)
        Panel1.Controls.Add(txb1)
        Panel1.Controls.Add(btnPuntoDecimal)
        Panel1.Controls.Add(btnCE)
        Panel1.Controls.Add(btn0)
        Panel1.Controls.Add(btnEliminar)
        Panel1.Controls.Add(btnPorcentaje)
        Panel1.Controls.Add(btnRestar)
        Panel1.Controls.Add(btnMasMenos)
        Panel1.Controls.Add(btn3)
        Panel1.Controls.Add(btnRaizCuadrada)
        Panel1.Controls.Add(btn2)
        Panel1.Controls.Add(btn7)
        Panel1.Controls.Add(btn1)
        Panel1.Controls.Add(btn8)
        Panel1.Controls.Add(btnFraccion)
        Panel1.Controls.Add(btn9)
        Panel1.Controls.Add(btnMultiplicar)
        Panel1.Controls.Add(btnDividir)
        Panel1.Controls.Add(btn6)
        Panel1.Controls.Add(btnPotencia)
        Panel1.Controls.Add(btn5)
        Panel1.Controls.Add(btn4)
        Panel1.Location = New Point(12, 12)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(659, 568)
        Panel1.TabIndex = 26
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(40), CByte(40), CByte(40))
        ClientSize = New Size(670, 584)
        Controls.Add(Panel1)
        Name = "Form1"
        Text = "Form1"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents txb1 As TextBox
    Friend WithEvents btnCE As Button
    Friend WithEvents btnEliminar As Button
    Friend WithEvents btnMasMenos As Button
    Friend WithEvents btnPorcentaje As Button
    Friend WithEvents btnRaizCuadrada As Button
    Friend WithEvents btnPotencia As Button
    Friend WithEvents btnDividir As Button
    Friend WithEvents btn9 As Button
    Friend WithEvents btn8 As Button
    Friend WithEvents btn7 As Button
    Friend WithEvents btnFraccion As Button
    Friend WithEvents btnMultiplicar As Button
    Friend WithEvents btn6 As Button
    Friend WithEvents btn5 As Button
    Friend WithEvents btn4 As Button
    Friend WithEvents btnResultado As Button
    Friend WithEvents btnRestar As Button
    Friend WithEvents btn3 As Button
    Friend WithEvents btn2 As Button
    Friend WithEvents btn1 As Button
    Friend WithEvents btnSumar As Button
    Friend WithEvents btnPuntoDecimal As Button
    Friend WithEvents btn0 As Button
    Friend WithEvents lblNombreCalculadora As Label
    Friend WithEvents Panel1 As Panel

End Class
