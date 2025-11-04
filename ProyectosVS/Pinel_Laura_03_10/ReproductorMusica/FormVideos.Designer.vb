<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormVideos
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormVideos))
        lblReproductorVideos = New Label()
        panelPlayer2 = New Panel()
        MediaPlayer2 = New AxWMPLib.AxWindowsMediaPlayer()
        btnCargarVideo = New Button()
        btnPause2 = New Button()
        btnPlay2 = New Button()
        panelPlayer2.SuspendLayout()
        CType(MediaPlayer2, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' lblReproductorVideos
        ' 
        lblReproductorVideos.AutoSize = True
        lblReproductorVideos.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblReproductorVideos.ForeColor = Color.WhiteSmoke
        lblReproductorVideos.Location = New Point(101, 28)
        lblReproductorVideos.Name = "lblReproductorVideos"
        lblReproductorVideos.Size = New Size(169, 21)
        lblReproductorVideos.TabIndex = 8
        lblReproductorVideos.Text = "Reproductor de Videos"
        ' 
        ' panelPlayer2
        ' 
        panelPlayer2.BackColor = Color.FromArgb(CByte(107), CByte(107), CByte(107))
        panelPlayer2.Controls.Add(MediaPlayer2)
        panelPlayer2.Dock = DockStyle.Bottom
        panelPlayer2.Location = New Point(0, 371)
        panelPlayer2.Name = "panelPlayer2"
        panelPlayer2.Size = New Size(800, 79)
        panelPlayer2.TabIndex = 10
        ' 
        ' MediaPlayer2
        ' 
        MediaPlayer2.Dock = DockStyle.Bottom
        MediaPlayer2.Enabled = True
        MediaPlayer2.Location = New Point(0, 33)
        MediaPlayer2.Name = "MediaPlayer2"
        MediaPlayer2.OcxState = CType(resources.GetObject("MediaPlayer2.OcxState"), AxHost.State)
        MediaPlayer2.Size = New Size(800, 46)
        MediaPlayer2.TabIndex = 0
        ' 
        ' btnCargarVideo
        ' 
        btnCargarVideo.BackColor = Color.FromArgb(CByte(164), CByte(56), CByte(186))
        btnCargarVideo.FlatAppearance.BorderSize = 0
        btnCargarVideo.FlatStyle = FlatStyle.Flat
        btnCargarVideo.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnCargarVideo.ForeColor = Color.WhiteSmoke
        btnCargarVideo.Location = New Point(441, 327)
        btnCargarVideo.Name = "btnCargarVideo"
        btnCargarVideo.Size = New Size(131, 38)
        btnCargarVideo.TabIndex = 11
        btnCargarVideo.Text = "Cargar Video"
        btnCargarVideo.UseVisualStyleBackColor = False
        ' 
        ' btnPause2
        ' 
        btnPause2.BackColor = Color.FromArgb(CByte(28), CByte(28), CByte(28))
        btnPause2.FlatAppearance.BorderSize = 0
        btnPause2.FlatStyle = FlatStyle.Flat
        btnPause2.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnPause2.ForeColor = Color.WhiteSmoke
        btnPause2.Location = New Point(686, 327)
        btnPause2.Name = "btnPause2"
        btnPause2.Size = New Size(102, 38)
        btnPause2.TabIndex = 13
        btnPause2.Text = "Pause"
        btnPause2.UseVisualStyleBackColor = False
        ' 
        ' btnPlay2
        ' 
        btnPlay2.BackColor = Color.FromArgb(CByte(28), CByte(28), CByte(28))
        btnPlay2.FlatAppearance.BorderSize = 0
        btnPlay2.FlatStyle = FlatStyle.Flat
        btnPlay2.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnPlay2.ForeColor = Color.WhiteSmoke
        btnPlay2.Location = New Point(578, 327)
        btnPlay2.Name = "btnPlay2"
        btnPlay2.Size = New Size(102, 38)
        btnPlay2.TabIndex = 12
        btnPlay2.Text = "Play"
        btnPlay2.UseVisualStyleBackColor = False
        ' 
        ' FormVideos
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(68), CByte(68), CByte(68))
        ClientSize = New Size(800, 450)
        Controls.Add(btnPause2)
        Controls.Add(btnPlay2)
        Controls.Add(btnCargarVideo)
        Controls.Add(panelPlayer2)
        Controls.Add(lblReproductorVideos)
        Name = "FormVideos"
        Text = "FormVideos"
        panelPlayer2.ResumeLayout(False)
        CType(MediaPlayer2, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblReproductorVideos As Label
    Friend WithEvents panelPlayer2 As Panel
    Friend WithEvents MediaPlayer2 As AxWMPLib.AxWindowsMediaPlayer
    Friend WithEvents btnCargarVideo As Button
    Friend WithEvents btnPause2 As Button
    Friend WithEvents btnPlay2 As Button
End Class
