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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        gbColor = New GroupBox()
        rbAzul = New RadioButton()
        rbVerde = New RadioButton()
        rbAmarillo = New RadioButton()
        rbRojo = New RadioButton()
        rbBlanco = New RadioButton()
        gbPosicion = New GroupBox()
        rbAbajo = New RadioButton()
        rbArriba = New RadioButton()
        rbCentro = New RadioButton()
        gbTamaño = New GroupBox()
        rbGrande = New RadioButton()
        rbPequeño = New RadioButton()
        rbNormal = New RadioButton()
        btnRestablecer = New Button()
        btnSalir = New Button()
        pcbCubo = New PictureBox()
        gbColor.SuspendLayout()
        gbPosicion.SuspendLayout()
        gbTamaño.SuspendLayout()
        CType(pcbCubo, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' gbColor
        ' 
        gbColor.BackColor = Color.DarkSlateBlue
        gbColor.Controls.Add(rbAzul)
        gbColor.Controls.Add(rbVerde)
        gbColor.Controls.Add(rbAmarillo)
        gbColor.Controls.Add(rbRojo)
        gbColor.Controls.Add(rbBlanco)
        gbColor.Font = New Font("Segoe UI", 9.75F)
        gbColor.ForeColor = SystemColors.ButtonHighlight
        gbColor.Location = New Point(63, 29)
        gbColor.Name = "gbColor"
        gbColor.Size = New Size(150, 146)
        gbColor.TabIndex = 0
        gbColor.TabStop = False
        gbColor.Text = "Color"
        ' 
        ' rbAzul
        ' 
        rbAzul.AutoSize = True
        rbAzul.Location = New Point(11, 120)
        rbAzul.Name = "rbAzul"
        rbAzul.Size = New Size(50, 21)
        rbAzul.TabIndex = 4
        rbAzul.TabStop = True
        rbAzul.Text = "Azul"
        rbAzul.UseVisualStyleBackColor = True
        ' 
        ' rbVerde
        ' 
        rbVerde.AutoSize = True
        rbVerde.Location = New Point(11, 96)
        rbVerde.Name = "rbVerde"
        rbVerde.Size = New Size(60, 21)
        rbVerde.TabIndex = 3
        rbVerde.TabStop = True
        rbVerde.Text = "Verde"
        rbVerde.UseVisualStyleBackColor = True
        ' 
        ' rbAmarillo
        ' 
        rbAmarillo.AutoSize = True
        rbAmarillo.Location = New Point(11, 71)
        rbAmarillo.Name = "rbAmarillo"
        rbAmarillo.Size = New Size(74, 21)
        rbAmarillo.TabIndex = 2
        rbAmarillo.TabStop = True
        rbAmarillo.Text = "Amarillo"
        rbAmarillo.UseVisualStyleBackColor = True
        ' 
        ' rbRojo
        ' 
        rbRojo.AutoSize = True
        rbRojo.Location = New Point(11, 46)
        rbRojo.Name = "rbRojo"
        rbRojo.Size = New Size(53, 21)
        rbRojo.TabIndex = 1
        rbRojo.TabStop = True
        rbRojo.Text = "Rojo"
        rbRojo.UseVisualStyleBackColor = True
        ' 
        ' rbBlanco
        ' 
        rbBlanco.AutoSize = True
        rbBlanco.Location = New Point(11, 22)
        rbBlanco.Name = "rbBlanco"
        rbBlanco.Size = New Size(64, 21)
        rbBlanco.TabIndex = 0
        rbBlanco.TabStop = True
        rbBlanco.Text = "Blanco"
        rbBlanco.UseVisualStyleBackColor = True
        ' 
        ' gbPosicion
        ' 
        gbPosicion.BackColor = Color.DarkSlateBlue
        gbPosicion.Controls.Add(rbAbajo)
        gbPosicion.Controls.Add(rbArriba)
        gbPosicion.Controls.Add(rbCentro)
        gbPosicion.Font = New Font("Segoe UI", 9.75F)
        gbPosicion.ForeColor = SystemColors.ButtonHighlight
        gbPosicion.Location = New Point(63, 181)
        gbPosicion.Name = "gbPosicion"
        gbPosicion.Size = New Size(150, 107)
        gbPosicion.TabIndex = 1
        gbPosicion.TabStop = False
        gbPosicion.Text = "Posición"
        ' 
        ' rbAbajo
        ' 
        rbAbajo.AutoSize = True
        rbAbajo.Location = New Point(11, 82)
        rbAbajo.Name = "rbAbajo"
        rbAbajo.Size = New Size(60, 21)
        rbAbajo.TabIndex = 4
        rbAbajo.TabStop = True
        rbAbajo.Text = "Abajo"
        rbAbajo.UseVisualStyleBackColor = True
        ' 
        ' rbArriba
        ' 
        rbArriba.AutoSize = True
        rbArriba.Location = New Point(11, 57)
        rbArriba.Name = "rbArriba"
        rbArriba.Size = New Size(62, 21)
        rbArriba.TabIndex = 3
        rbArriba.TabStop = True
        rbArriba.Text = "Arriba"
        rbArriba.UseVisualStyleBackColor = True
        ' 
        ' rbCentro
        ' 
        rbCentro.AutoSize = True
        rbCentro.Location = New Point(11, 32)
        rbCentro.Name = "rbCentro"
        rbCentro.Size = New Size(65, 21)
        rbCentro.TabIndex = 2
        rbCentro.TabStop = True
        rbCentro.Text = "Centro"
        rbCentro.UseVisualStyleBackColor = True
        ' 
        ' gbTamaño
        ' 
        gbTamaño.BackColor = Color.DarkSlateBlue
        gbTamaño.Controls.Add(rbGrande)
        gbTamaño.Controls.Add(rbPequeño)
        gbTamaño.Controls.Add(rbNormal)
        gbTamaño.Font = New Font("Segoe UI", 9.75F)
        gbTamaño.ForeColor = SystemColors.ButtonHighlight
        gbTamaño.Location = New Point(63, 294)
        gbTamaño.Name = "gbTamaño"
        gbTamaño.Size = New Size(150, 144)
        gbTamaño.TabIndex = 1
        gbTamaño.TabStop = False
        gbTamaño.Text = "Tamaño"
        ' 
        ' rbGrande
        ' 
        rbGrande.AutoSize = True
        rbGrande.Location = New Point(11, 83)
        rbGrande.Name = "rbGrande"
        rbGrande.Size = New Size(69, 21)
        rbGrande.TabIndex = 4
        rbGrande.TabStop = True
        rbGrande.Text = "Grande"
        rbGrande.UseVisualStyleBackColor = True
        ' 
        ' rbPequeño
        ' 
        rbPequeño.AutoSize = True
        rbPequeño.Location = New Point(11, 58)
        rbPequeño.Name = "rbPequeño"
        rbPequeño.Size = New Size(77, 21)
        rbPequeño.TabIndex = 3
        rbPequeño.TabStop = True
        rbPequeño.Text = "Pequeño"
        rbPequeño.UseVisualStyleBackColor = True
        ' 
        ' rbNormal
        ' 
        rbNormal.AutoSize = True
        rbNormal.Location = New Point(11, 33)
        rbNormal.Name = "rbNormal"
        rbNormal.Size = New Size(70, 21)
        rbNormal.TabIndex = 2
        rbNormal.TabStop = True
        rbNormal.Text = "Normal"
        rbNormal.UseVisualStyleBackColor = True
        ' 
        ' btnRestablecer
        ' 
        btnRestablecer.BackColor = Color.CadetBlue
        btnRestablecer.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnRestablecer.ForeColor = SystemColors.ButtonFace
        btnRestablecer.Location = New Point(551, 377)
        btnRestablecer.Name = "btnRestablecer"
        btnRestablecer.Size = New Size(103, 33)
        btnRestablecer.TabIndex = 2
        btnRestablecer.Text = "Restablecer"
        btnRestablecer.UseVisualStyleBackColor = False
        ' 
        ' btnSalir
        ' 
        btnSalir.BackColor = Color.LightBlue
        btnSalir.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnSalir.ForeColor = Color.Firebrick
        btnSalir.Location = New Point(671, 377)
        btnSalir.Name = "btnSalir"
        btnSalir.Size = New Size(103, 33)
        btnSalir.TabIndex = 3
        btnSalir.Text = "Salir"
        btnSalir.UseVisualStyleBackColor = False
        ' 
        ' pcbCubo
        ' 
        pcbCubo.BackColor = Color.Transparent
        pcbCubo.Image = CType(resources.GetObject("pcbCubo.Image"), Image)
        pcbCubo.Location = New Point(426, 194)
        pcbCubo.Name = "pcbCubo"
        pcbCubo.Size = New Size(100, 50)
        pcbCubo.SizeMode = PictureBoxSizeMode.Zoom
        pcbCubo.TabIndex = 4
        pcbCubo.TabStop = False
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(800, 450)
        Controls.Add(pcbCubo)
        Controls.Add(btnSalir)
        Controls.Add(btnRestablecer)
        Controls.Add(gbTamaño)
        Controls.Add(gbPosicion)
        Controls.Add(gbColor)
        Name = "Form1"
        Text = "Form1"
        gbColor.ResumeLayout(False)
        gbColor.PerformLayout()
        gbPosicion.ResumeLayout(False)
        gbPosicion.PerformLayout()
        gbTamaño.ResumeLayout(False)
        gbTamaño.PerformLayout()
        CType(pcbCubo, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents gbColor As GroupBox
    Friend WithEvents rbVerde As RadioButton
    Friend WithEvents rbAmarillo As RadioButton
    Friend WithEvents rbRojo As RadioButton
    Friend WithEvents rbBlanco As RadioButton
    Friend WithEvents gbPosicion As GroupBox
    Friend WithEvents gbTamaño As GroupBox
    Friend WithEvents rbAzul As RadioButton
    Friend WithEvents rbAbajo As RadioButton
    Friend WithEvents rbArriba As RadioButton
    Friend WithEvents rbCentro As RadioButton
    Friend WithEvents rbGrande As RadioButton
    Friend WithEvents rbPequeño As RadioButton
    Friend WithEvents rbNormal As RadioButton
    Friend WithEvents btnRestablecer As Button
    Friend WithEvents btnSalir As Button
    Friend WithEvents pcbCubo As PictureBox

End Class
