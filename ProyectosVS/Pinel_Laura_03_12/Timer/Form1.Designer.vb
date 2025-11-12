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
        components = New ComponentModel.Container()
        pbBob = New PictureBox()
        btnIniciar = New Button()
        btnVolver = New Button()
        pbOficina = New PictureBox()
        lblTitulo = New Label()
        btnPausa = New Button()
        Panel1 = New Panel()
        btnSalir = New Button()
        lblTimer = New Label()
        Panel2 = New Panel()
        Timer1 = New System.Windows.Forms.Timer(components)
        CType(pbBob, ComponentModel.ISupportInitialize).BeginInit()
        CType(pbOficina, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        Panel2.SuspendLayout()
        SuspendLayout()
        ' 
        ' pbBob
        ' 
        pbBob.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left
        pbBob.BackColor = Color.Transparent
        pbBob.Image = My.Resources.Resources.ocupado
        pbBob.Location = New Point(0, 0)
        pbBob.Name = "pbBob"
        pbBob.Size = New Size(153, 168)
        pbBob.SizeMode = PictureBoxSizeMode.Zoom
        pbBob.TabIndex = 0
        pbBob.TabStop = False
        ' 
        ' btnIniciar
        ' 
        btnIniciar.Anchor = AnchorStyles.Bottom
        btnIniciar.Font = New Font("Microsoft Sans Serif", 14.25F)
        btnIniciar.Location = New Point(193, 78)
        btnIniciar.Name = "btnIniciar"
        btnIniciar.Size = New Size(88, 37)
        btnIniciar.TabIndex = 1
        btnIniciar.Text = "Iniciar"
        btnIniciar.UseVisualStyleBackColor = True
        ' 
        ' btnVolver
        ' 
        btnVolver.Anchor = AnchorStyles.Bottom
        btnVolver.Font = New Font("Microsoft Sans Serif", 14.25F)
        btnVolver.Location = New Point(305, 78)
        btnVolver.Name = "btnVolver"
        btnVolver.Size = New Size(88, 37)
        btnVolver.TabIndex = 2
        btnVolver.Text = "Volver"
        btnVolver.UseVisualStyleBackColor = True
        ' 
        ' pbOficina
        ' 
        pbOficina.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Right
        pbOficina.BackColor = Color.Transparent
        pbOficina.Image = My.Resources.Resources.edificio_de_oficinas
        pbOficina.Location = New Point(523, 0)
        pbOficina.Name = "pbOficina"
        pbOficina.Size = New Size(156, 168)
        pbOficina.SizeMode = PictureBoxSizeMode.Zoom
        pbOficina.TabIndex = 3
        pbOficina.TabStop = False
        ' 
        ' lblTitulo
        ' 
        lblTitulo.Anchor = AnchorStyles.Top
        lblTitulo.AutoSize = True
        lblTitulo.BackColor = Color.SandyBrown
        lblTitulo.Font = New Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblTitulo.Location = New Point(184, 32)
        lblTitulo.Name = "lblTitulo"
        lblTitulo.Size = New Size(339, 29)
        lblTitulo.TabIndex = 4
        lblTitulo.Text = "Ayuda a Bob a llegar al trabajo"
        ' 
        ' btnPausa
        ' 
        btnPausa.Anchor = AnchorStyles.Bottom
        btnPausa.Font = New Font("Microsoft Sans Serif", 14.25F)
        btnPausa.Location = New Point(414, 78)
        btnPausa.Name = "btnPausa"
        btnPausa.Size = New Size(88, 37)
        btnPausa.TabIndex = 5
        btnPausa.Text = "Pausa"
        btnPausa.UseVisualStyleBackColor = True
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.DimGray
        Panel1.Controls.Add(btnSalir)
        Panel1.Controls.Add(lblTimer)
        Panel1.Controls.Add(btnPausa)
        Panel1.Controls.Add(lblTitulo)
        Panel1.Controls.Add(btnVolver)
        Panel1.Controls.Add(btnIniciar)
        Panel1.Dock = DockStyle.Bottom
        Panel1.Location = New Point(0, 170)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(681, 253)
        Panel1.TabIndex = 6
        ' 
        ' btnSalir
        ' 
        btnSalir.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        btnSalir.BackColor = Color.Orange
        btnSalir.FlatAppearance.BorderSize = 0
        btnSalir.FlatStyle = FlatStyle.Flat
        btnSalir.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnSalir.ForeColor = Color.Black
        btnSalir.Location = New Point(597, 204)
        btnSalir.Name = "btnSalir"
        btnSalir.Size = New Size(72, 37)
        btnSalir.TabIndex = 7
        btnSalir.Text = "Salir"
        btnSalir.UseVisualStyleBackColor = False
        ' 
        ' lblTimer
        ' 
        lblTimer.Anchor = AnchorStyles.Top
        lblTimer.AutoSize = True
        lblTimer.Font = New Font("Microsoft Sans Serif", 36F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblTimer.ForeColor = Color.Gold
        lblTimer.Location = New Point(305, 141)
        lblTimer.Name = "lblTimer"
        lblTimer.Size = New Size(78, 55)
        lblTimer.TabIndex = 6
        lblTimer.Text = "45"
        ' 
        ' Panel2
        ' 
        Panel2.BackgroundImage = My.Resources.Resources.calleee
        Panel2.BackgroundImageLayout = ImageLayout.Stretch
        Panel2.BorderStyle = BorderStyle.FixedSingle
        Panel2.Controls.Add(pbOficina)
        Panel2.Controls.Add(pbBob)
        Panel2.Dock = DockStyle.Fill
        Panel2.Location = New Point(0, 0)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(681, 170)
        Panel2.TabIndex = 7
        ' 
        ' Timer1
        ' 
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(681, 423)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        Name = "Form1"
        Text = "Form1"
        CType(pbBob, ComponentModel.ISupportInitialize).EndInit()
        CType(pbOficina, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        Panel2.ResumeLayout(False)
        ResumeLayout(False)
    End Sub

    Friend WithEvents pbBob As PictureBox
    Friend WithEvents btnIniciar As Button
    Friend WithEvents btnVolver As Button
    Friend WithEvents pbOficina As PictureBox
    Friend WithEvents lblTitulo As Label
    Friend WithEvents btnPausa As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents lblTimer As Label
    Friend WithEvents btnSalir As Button

End Class
