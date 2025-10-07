<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormInicio
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
        pbBankImage = New PictureBox()
        lblNombreBanco = New Label()
        lblNombre = New Label()
        TextBox1 = New TextBox()
        btnSolicitud = New Button()
        btnSalir = New Button()
        CType(pbBankImage, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' pbBankImage
        ' 
        pbBankImage.BackColor = Color.Transparent
        pbBankImage.Image = My.Resources.Resources.bancoImage
        pbBankImage.Location = New Point(26, 48)
        pbBankImage.Name = "pbBankImage"
        pbBankImage.Size = New Size(204, 134)
        pbBankImage.SizeMode = PictureBoxSizeMode.Zoom
        pbBankImage.TabIndex = 0
        pbBankImage.TabStop = False
        ' 
        ' lblNombreBanco
        ' 
        lblNombreBanco.AutoSize = True
        lblNombreBanco.Font = New Font("Times New Roman", 24F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblNombreBanco.Location = New Point(236, 98)
        lblNombreBanco.Name = "lblNombreBanco"
        lblNombreBanco.Size = New Size(400, 36)
        lblNombreBanco.TabIndex = 1
        lblNombreBanco.Text = "Banco de la Montaña Solitaria"
        ' 
        ' lblNombre
        ' 
        lblNombre.AutoSize = True
        lblNombre.Font = New Font("Times New Roman", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblNombre.Location = New Point(143, 249)
        lblNombre.Name = "lblNombre"
        lblNombre.Size = New Size(170, 23)
        lblNombre.TabIndex = 2
        lblNombre.Text = "Indique su nombre:"
        ' 
        ' TextBox1
        ' 
        TextBox1.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TextBox1.Location = New Point(334, 247)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(211, 29)
        TextBox1.TabIndex = 3
        ' 
        ' btnSolicitud
        ' 
        btnSolicitud.BackColor = Color.Tan
        btnSolicitud.Font = New Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnSolicitud.ForeColor = Color.Black
        btnSolicitud.Location = New Point(271, 345)
        btnSolicitud.Name = "btnSolicitud"
        btnSolicitud.Size = New Size(168, 62)
        btnSolicitud.TabIndex = 4
        btnSolicitud.Text = "Solicitar Préstamo"
        btnSolicitud.UseVisualStyleBackColor = False
        ' 
        ' btnSalir
        ' 
        btnSalir.BackColor = Color.Coral
        btnSalir.Font = New Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnSalir.ForeColor = Color.White
        btnSalir.Location = New Point(601, 440)
        btnSalir.Name = "btnSalir"
        btnSalir.Size = New Size(90, 44)
        btnSalir.TabIndex = 5
        btnSalir.Text = "Salir"
        btnSalir.UseVisualStyleBackColor = False
        ' 
        ' FormInicio
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.BlanchedAlmond
        ClientSize = New Size(703, 496)
        Controls.Add(btnSalir)
        Controls.Add(btnSolicitud)
        Controls.Add(TextBox1)
        Controls.Add(lblNombre)
        Controls.Add(lblNombreBanco)
        Controls.Add(pbBankImage)
        Name = "FormInicio"
        Text = "Form1"
        CType(pbBankImage, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents pbBankImage As PictureBox
    Friend WithEvents lblNombreBanco As Label
    Friend WithEvents lblNombre As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents btnSolicitud As Button
    Friend WithEvents btnSalir As Button

End Class
