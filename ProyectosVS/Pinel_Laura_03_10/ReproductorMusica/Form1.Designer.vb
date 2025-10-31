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
        PanelMenuLateral = New Panel()
        btnSalir = New Button()
        PanelGaleria = New Panel()
        btnMultimedia = New Button()
        btnVideos = New Button()
        btnFotoss = New Button()
        btnGaleria = New Button()
        PanelArchivo = New Panel()
        btnImportar = New Button()
        btnGuardar = New Button()
        btnBuscar = New Button()
        PanelLogo = New Panel()
        btnArchivo = New Button()
        PanelReproduccion = New Panel()
        Panel1 = New Panel()
        PanelMenuLateral.SuspendLayout()
        PanelGaleria.SuspendLayout()
        PanelArchivo.SuspendLayout()
        PanelLogo.SuspendLayout()
        PanelReproduccion.SuspendLayout()
        SuspendLayout()
        ' 
        ' PanelMenuLateral
        ' 
        PanelMenuLateral.BackColor = Color.FromArgb(CByte(28), CByte(28), CByte(28))
        PanelMenuLateral.Controls.Add(btnSalir)
        PanelMenuLateral.Controls.Add(PanelGaleria)
        PanelMenuLateral.Controls.Add(btnGaleria)
        PanelMenuLateral.Controls.Add(PanelArchivo)
        PanelMenuLateral.Controls.Add(PanelLogo)
        PanelMenuLateral.Dock = DockStyle.Left
        PanelMenuLateral.Location = New Point(0, 0)
        PanelMenuLateral.Name = "PanelMenuLateral"
        PanelMenuLateral.Size = New Size(273, 561)
        PanelMenuLateral.TabIndex = 0
        ' 
        ' btnSalir
        ' 
        btnSalir.BackColor = Color.FromArgb(CByte(25), CByte(180), CByte(80))
        btnSalir.Cursor = Cursors.Cross
        btnSalir.Dock = DockStyle.Bottom
        btnSalir.FlatAppearance.BorderSize = 0
        btnSalir.FlatStyle = FlatStyle.Flat
        btnSalir.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnSalir.Location = New Point(0, 516)
        btnSalir.Name = "btnSalir"
        btnSalir.Padding = New Padding(35, 0, 0, 0)
        btnSalir.Size = New Size(273, 45)
        btnSalir.TabIndex = 4
        btnSalir.Text = "Salir"
        btnSalir.TextAlign = ContentAlignment.MiddleLeft
        btnSalir.TextImageRelation = TextImageRelation.ImageBeforeText
        btnSalir.UseVisualStyleBackColor = False
        ' 
        ' PanelGaleria
        ' 
        PanelGaleria.Controls.Add(btnMultimedia)
        PanelGaleria.Controls.Add(btnVideos)
        PanelGaleria.Controls.Add(btnFotoss)
        PanelGaleria.Dock = DockStyle.Top
        PanelGaleria.Location = New Point(0, 349)
        PanelGaleria.Name = "PanelGaleria"
        PanelGaleria.Size = New Size(273, 138)
        PanelGaleria.TabIndex = 3
        ' 
        ' btnMultimedia
        ' 
        btnMultimedia.BackColor = Color.FromArgb(CByte(80), CByte(80), CByte(80))
        btnMultimedia.Cursor = Cursors.Cross
        btnMultimedia.Dock = DockStyle.Top
        btnMultimedia.FlatAppearance.BorderSize = 0
        btnMultimedia.FlatStyle = FlatStyle.Flat
        btnMultimedia.Font = New Font("Segoe UI", 9.75F)
        btnMultimedia.ForeColor = Color.WhiteSmoke
        btnMultimedia.Location = New Point(0, 90)
        btnMultimedia.Name = "btnMultimedia"
        btnMultimedia.Padding = New Padding(85, 0, 0, 0)
        btnMultimedia.Size = New Size(273, 45)
        btnMultimedia.TabIndex = 3
        btnMultimedia.Text = "Multimedia"
        btnMultimedia.TextAlign = ContentAlignment.MiddleLeft
        btnMultimedia.TextImageRelation = TextImageRelation.ImageBeforeText
        btnMultimedia.UseVisualStyleBackColor = False
        ' 
        ' btnVideos
        ' 
        btnVideos.BackColor = Color.FromArgb(CByte(80), CByte(80), CByte(80))
        btnVideos.Cursor = Cursors.Cross
        btnVideos.Dock = DockStyle.Top
        btnVideos.FlatAppearance.BorderSize = 0
        btnVideos.FlatStyle = FlatStyle.Flat
        btnVideos.Font = New Font("Segoe UI", 9.75F)
        btnVideos.ForeColor = Color.WhiteSmoke
        btnVideos.Location = New Point(0, 45)
        btnVideos.Name = "btnVideos"
        btnVideos.Padding = New Padding(85, 0, 0, 0)
        btnVideos.Size = New Size(273, 45)
        btnVideos.TabIndex = 2
        btnVideos.Text = "Videos"
        btnVideos.TextAlign = ContentAlignment.MiddleLeft
        btnVideos.TextImageRelation = TextImageRelation.ImageBeforeText
        btnVideos.UseVisualStyleBackColor = False
        ' 
        ' btnFotoss
        ' 
        btnFotoss.BackColor = Color.FromArgb(CByte(80), CByte(80), CByte(80))
        btnFotoss.Cursor = Cursors.Cross
        btnFotoss.Dock = DockStyle.Top
        btnFotoss.FlatAppearance.BorderSize = 0
        btnFotoss.FlatStyle = FlatStyle.Flat
        btnFotoss.Font = New Font("Segoe UI", 9.75F)
        btnFotoss.ForeColor = Color.WhiteSmoke
        btnFotoss.Location = New Point(0, 0)
        btnFotoss.Name = "btnFotoss"
        btnFotoss.Padding = New Padding(85, 0, 0, 0)
        btnFotoss.Size = New Size(273, 45)
        btnFotoss.TabIndex = 1
        btnFotoss.Text = "Fotos"
        btnFotoss.TextAlign = ContentAlignment.MiddleLeft
        btnFotoss.TextImageRelation = TextImageRelation.ImageBeforeText
        btnFotoss.UseVisualStyleBackColor = False
        ' 
        ' btnGaleria
        ' 
        btnGaleria.BackColor = Color.FromArgb(CByte(40), CByte(40), CByte(40))
        btnGaleria.Cursor = Cursors.Cross
        btnGaleria.Dock = DockStyle.Top
        btnGaleria.FlatAppearance.BorderSize = 0
        btnGaleria.FlatStyle = FlatStyle.Flat
        btnGaleria.Font = New Font("Segoe UI", 9.75F)
        btnGaleria.ForeColor = Color.WhiteSmoke
        btnGaleria.Location = New Point(0, 304)
        btnGaleria.Name = "btnGaleria"
        btnGaleria.Padding = New Padding(35, 0, 0, 0)
        btnGaleria.Size = New Size(273, 45)
        btnGaleria.TabIndex = 2
        btnGaleria.Text = "Galería"
        btnGaleria.TextAlign = ContentAlignment.MiddleLeft
        btnGaleria.TextImageRelation = TextImageRelation.ImageBeforeText
        btnGaleria.UseVisualStyleBackColor = False
        ' 
        ' PanelArchivo
        ' 
        PanelArchivo.Controls.Add(btnImportar)
        PanelArchivo.Controls.Add(btnGuardar)
        PanelArchivo.Controls.Add(btnBuscar)
        PanelArchivo.Dock = DockStyle.Top
        PanelArchivo.Location = New Point(0, 167)
        PanelArchivo.Name = "PanelArchivo"
        PanelArchivo.Size = New Size(273, 137)
        PanelArchivo.TabIndex = 1
        ' 
        ' btnImportar
        ' 
        btnImportar.BackColor = Color.FromArgb(CByte(80), CByte(80), CByte(80))
        btnImportar.Cursor = Cursors.Cross
        btnImportar.Dock = DockStyle.Top
        btnImportar.FlatAppearance.BorderSize = 0
        btnImportar.FlatStyle = FlatStyle.Flat
        btnImportar.Font = New Font("Segoe UI", 9.75F)
        btnImportar.ForeColor = Color.WhiteSmoke
        btnImportar.Location = New Point(0, 90)
        btnImportar.Name = "btnImportar"
        btnImportar.Padding = New Padding(85, 0, 0, 0)
        btnImportar.RightToLeft = RightToLeft.No
        btnImportar.Size = New Size(273, 45)
        btnImportar.TabIndex = 3
        btnImportar.Text = "Importar"
        btnImportar.TextAlign = ContentAlignment.MiddleLeft
        btnImportar.TextImageRelation = TextImageRelation.ImageBeforeText
        btnImportar.UseVisualStyleBackColor = False
        ' 
        ' btnGuardar
        ' 
        btnGuardar.BackColor = Color.FromArgb(CByte(80), CByte(80), CByte(80))
        btnGuardar.Cursor = Cursors.Cross
        btnGuardar.Dock = DockStyle.Top
        btnGuardar.FlatAppearance.BorderSize = 0
        btnGuardar.FlatStyle = FlatStyle.Flat
        btnGuardar.Font = New Font("Segoe UI", 9.75F)
        btnGuardar.ForeColor = Color.WhiteSmoke
        btnGuardar.Location = New Point(0, 45)
        btnGuardar.Name = "btnGuardar"
        btnGuardar.Padding = New Padding(85, 0, 0, 0)
        btnGuardar.RightToLeft = RightToLeft.No
        btnGuardar.Size = New Size(273, 45)
        btnGuardar.TabIndex = 2
        btnGuardar.Text = "Guardar"
        btnGuardar.TextAlign = ContentAlignment.MiddleLeft
        btnGuardar.TextImageRelation = TextImageRelation.ImageBeforeText
        btnGuardar.UseVisualStyleBackColor = False
        ' 
        ' btnBuscar
        ' 
        btnBuscar.BackColor = Color.FromArgb(CByte(80), CByte(80), CByte(80))
        btnBuscar.Cursor = Cursors.Cross
        btnBuscar.Dock = DockStyle.Top
        btnBuscar.FlatAppearance.BorderSize = 0
        btnBuscar.FlatStyle = FlatStyle.Flat
        btnBuscar.Font = New Font("Segoe UI", 9.75F)
        btnBuscar.ForeColor = Color.WhiteSmoke
        btnBuscar.Location = New Point(0, 0)
        btnBuscar.Name = "btnBuscar"
        btnBuscar.Padding = New Padding(85, 0, 0, 0)
        btnBuscar.RightToLeft = RightToLeft.No
        btnBuscar.Size = New Size(273, 45)
        btnBuscar.TabIndex = 1
        btnBuscar.Text = "Buscar"
        btnBuscar.TextAlign = ContentAlignment.MiddleLeft
        btnBuscar.TextImageRelation = TextImageRelation.ImageBeforeText
        btnBuscar.UseVisualStyleBackColor = False
        ' 
        ' PanelLogo
        ' 
        PanelLogo.BackColor = Color.FromArgb(CByte(28), CByte(28), CByte(28))
        PanelLogo.Controls.Add(btnArchivo)
        PanelLogo.Dock = DockStyle.Top
        PanelLogo.Location = New Point(0, 0)
        PanelLogo.Name = "PanelLogo"
        PanelLogo.Size = New Size(273, 167)
        PanelLogo.TabIndex = 1
        ' 
        ' btnArchivo
        ' 
        btnArchivo.BackColor = Color.FromArgb(CByte(40), CByte(40), CByte(40))
        btnArchivo.Cursor = Cursors.Cross
        btnArchivo.Dock = DockStyle.Bottom
        btnArchivo.FlatAppearance.BorderSize = 0
        btnArchivo.FlatStyle = FlatStyle.Flat
        btnArchivo.Font = New Font("Segoe UI", 9.75F)
        btnArchivo.ForeColor = Color.WhiteSmoke
        btnArchivo.Location = New Point(0, 122)
        btnArchivo.Name = "btnArchivo"
        btnArchivo.Padding = New Padding(35, 0, 0, 0)
        btnArchivo.Size = New Size(273, 45)
        btnArchivo.TabIndex = 0
        btnArchivo.Text = "Archivo"
        btnArchivo.TextAlign = ContentAlignment.MiddleLeft
        btnArchivo.TextImageRelation = TextImageRelation.ImageBeforeText
        btnArchivo.UseVisualStyleBackColor = False
        ' 
        ' PanelReproduccion
        ' 
        PanelReproduccion.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        PanelReproduccion.BackColor = Color.FromArgb(CByte(18), CByte(18), CByte(18))
        PanelReproduccion.Controls.Add(Panel1)
        PanelReproduccion.Location = New Point(273, 0)
        PanelReproduccion.Name = "PanelReproduccion"
        PanelReproduccion.Size = New Size(661, 561)
        PanelReproduccion.TabIndex = 1
        ' 
        ' Panel1
        ' 
        Panel1.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Panel1.BackColor = Color.FromArgb(CByte(22), CByte(22), CByte(22))
        Panel1.Location = New Point(2, 487)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(661, 75)
        Panel1.TabIndex = 0
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(934, 561)
        Controls.Add(PanelReproduccion)
        Controls.Add(PanelMenuLateral)
        Name = "Form1"
        Text = "Form1"
        PanelMenuLateral.ResumeLayout(False)
        PanelGaleria.ResumeLayout(False)
        PanelArchivo.ResumeLayout(False)
        PanelLogo.ResumeLayout(False)
        PanelReproduccion.ResumeLayout(False)
        ResumeLayout(False)
    End Sub

    Friend WithEvents PanelMenuLateral As Panel
    Friend WithEvents btnArchivo As Button
    Friend WithEvents PanelLogo As Panel
    Friend WithEvents PanelArchivo As Panel
    Friend WithEvents PanelGaleria As Panel
    Friend WithEvents btnSalir As Button
    Friend WithEvents btnMultimedia As Button
    Friend WithEvents btnVideos As Button
    Friend WithEvents btnFotoss As Button
    Friend WithEvents btnImportar As Button
    Friend WithEvents btnGuardar As Button
    Friend WithEvents btnBuscar As Button
    Friend WithEvents btnGaleria As Button
    Friend WithEvents PanelReproduccion As Panel
    Friend WithEvents Panel1 As Panel

End Class
