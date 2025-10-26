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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        PanelMenu = New Panel()
        ToolStrip2 = New ToolStrip()
        cbFuentes = New ToolStripComboBox()
        ToolStripSeparator11 = New ToolStripSeparator()
        btnNegrita = New ToolStripButton()
        ToolStripSeparator12 = New ToolStripSeparator()
        btnCursiva = New ToolStripButton()
        ToolStripSeparator13 = New ToolStripSeparator()
        lblTamaño = New ToolStripLabel()
        txbTamañoLetra = New ToolStripTextBox()
        ToolStripSeparator14 = New ToolStripSeparator()
        btnColor = New ToolStripButton()
        MenuStrip2 = New MenuStrip()
        ToolStripMenuArchivo = New ToolStripMenuItem()
        ToolStripMenuNuevo = New ToolStripMenuItem()
        ToolStripMenuAbrir = New ToolStripMenuItem()
        ToolStripMenuGuardarComo = New ToolStripMenuItem()
        ToolStripSeparator8 = New ToolStripSeparator()
        ToolStripMenuSalir = New ToolStripMenuItem()
        ToolStripMenuEditar = New ToolStripMenuItem()
        ToolStripMenuCopiar = New ToolStripMenuItem()
        ToolStripMenuCortar = New ToolStripMenuItem()
        ToolStripMenuPegar = New ToolStripMenuItem()
        ToolStripSeparator9 = New ToolStripSeparator()
        ToolStripMenuSeleccionarTodo = New ToolStripMenuItem()
        ToolStripSeparator10 = New ToolStripSeparator()
        ToolStripMenuDeshacer = New ToolStripMenuItem()
        ToolStripMenuRehacer = New ToolStripMenuItem()
        txtEditor = New RichTextBox()
        ContextMenuStrip1 = New ContextMenuStrip(components)
        CortarContextMenuStrip = New ToolStripMenuItem()
        CopiarContextMenuStrip = New ToolStripMenuItem()
        PegarContextMenuStrip = New ToolStripMenuItem()
        SeleccionarTodoContextMenuStrip = New ToolStripMenuItem()
        PanelTitulo = New Panel()
        btnSalir = New Button()
        btnMaximizar = New Button()
        btnMinimizar = New Button()
        lbTitulo = New Label()
        pbImagen = New PictureBox()
        TrackBar = New TrackBar()
        lblPorcentaje = New Label()
        PanelMenu.SuspendLayout()
        ToolStrip2.SuspendLayout()
        MenuStrip2.SuspendLayout()
        ContextMenuStrip1.SuspendLayout()
        PanelTitulo.SuspendLayout()
        CType(pbImagen, ComponentModel.ISupportInitialize).BeginInit()
        CType(TrackBar, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' PanelMenu
        ' 
        PanelMenu.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        PanelMenu.BackColor = Color.DimGray
        PanelMenu.Controls.Add(ToolStrip2)
        PanelMenu.Controls.Add(MenuStrip2)
        PanelMenu.Location = New Point(2, 39)
        PanelMenu.Name = "PanelMenu"
        PanelMenu.Size = New Size(800, 61)
        PanelMenu.TabIndex = 2
        ' 
        ' ToolStrip2
        ' 
        ToolStrip2.BackColor = Color.DimGray
        ToolStrip2.Items.AddRange(New ToolStripItem() {cbFuentes, ToolStripSeparator11, btnNegrita, ToolStripSeparator12, btnCursiva, ToolStripSeparator13, lblTamaño, txbTamañoLetra, ToolStripSeparator14, btnColor})
        ToolStrip2.Location = New Point(0, 24)
        ToolStrip2.Name = "ToolStrip2"
        ToolStrip2.Size = New Size(800, 25)
        ToolStrip2.TabIndex = 3
        ToolStrip2.Text = "ToolStrip2"
        ' 
        ' cbFuentes
        ' 
        cbFuentes.Name = "cbFuentes"
        cbFuentes.Size = New Size(121, 25)
        ' 
        ' ToolStripSeparator11
        ' 
        ToolStripSeparator11.Name = "ToolStripSeparator11"
        ToolStripSeparator11.Size = New Size(6, 25)
        ' 
        ' btnNegrita
        ' 
        btnNegrita.DisplayStyle = ToolStripItemDisplayStyle.Image
        btnNegrita.ForeColor = SystemColors.ButtonFace
        btnNegrita.Image = CType(resources.GetObject("btnNegrita.Image"), Image)
        btnNegrita.ImageTransparentColor = Color.Magenta
        btnNegrita.Name = "btnNegrita"
        btnNegrita.Size = New Size(23, 22)
        btnNegrita.Text = "Negrita"
        ' 
        ' ToolStripSeparator12
        ' 
        ToolStripSeparator12.Name = "ToolStripSeparator12"
        ToolStripSeparator12.Size = New Size(6, 25)
        ' 
        ' btnCursiva
        ' 
        btnCursiva.DisplayStyle = ToolStripItemDisplayStyle.Image
        btnCursiva.ForeColor = SystemColors.ButtonFace
        btnCursiva.Image = CType(resources.GetObject("btnCursiva.Image"), Image)
        btnCursiva.ImageTransparentColor = Color.Magenta
        btnCursiva.Name = "btnCursiva"
        btnCursiva.Size = New Size(23, 22)
        btnCursiva.Text = "Cursiva"
        ' 
        ' ToolStripSeparator13
        ' 
        ToolStripSeparator13.ForeColor = SystemColors.ButtonFace
        ToolStripSeparator13.Name = "ToolStripSeparator13"
        ToolStripSeparator13.Size = New Size(6, 25)
        ' 
        ' lblTamaño
        ' 
        lblTamaño.ForeColor = SystemColors.ButtonFace
        lblTamaño.Name = "lblTamaño"
        lblTamaño.Size = New Size(53, 22)
        lblTamaño.Text = "Tamaño:"
        ' 
        ' txbTamañoLetra
        ' 
        txbTamañoLetra.Name = "txbTamañoLetra"
        txbTamañoLetra.Size = New Size(100, 25)
        ' 
        ' ToolStripSeparator14
        ' 
        ToolStripSeparator14.Name = "ToolStripSeparator14"
        ToolStripSeparator14.Size = New Size(6, 25)
        ' 
        ' btnColor
        ' 
        btnColor.BackColor = Color.Black
        btnColor.DisplayStyle = ToolStripItemDisplayStyle.Image
        btnColor.ImageTransparentColor = Color.Magenta
        btnColor.Name = "btnColor"
        btnColor.Size = New Size(23, 22)
        ' 
        ' MenuStrip2
        ' 
        MenuStrip2.BackColor = Color.DimGray
        MenuStrip2.Items.AddRange(New ToolStripItem() {ToolStripMenuArchivo, ToolStripMenuEditar})
        MenuStrip2.Location = New Point(0, 0)
        MenuStrip2.Name = "MenuStrip2"
        MenuStrip2.Size = New Size(800, 24)
        MenuStrip2.TabIndex = 2
        MenuStrip2.Text = "MenuStrip2"
        ' 
        ' ToolStripMenuArchivo
        ' 
        ToolStripMenuArchivo.DropDownItems.AddRange(New ToolStripItem() {ToolStripMenuNuevo, ToolStripMenuAbrir, ToolStripMenuGuardarComo, ToolStripSeparator8, ToolStripMenuSalir})
        ToolStripMenuArchivo.ForeColor = SystemColors.ButtonFace
        ToolStripMenuArchivo.Name = "ToolStripMenuArchivo"
        ToolStripMenuArchivo.Size = New Size(60, 20)
        ToolStripMenuArchivo.Text = "Archivo"
        ' 
        ' ToolStripMenuNuevo
        ' 
        ToolStripMenuNuevo.Name = "ToolStripMenuNuevo"
        ToolStripMenuNuevo.Size = New Size(146, 22)
        ToolStripMenuNuevo.Text = "Nuevo"
        ' 
        ' ToolStripMenuAbrir
        ' 
        ToolStripMenuAbrir.Name = "ToolStripMenuAbrir"
        ToolStripMenuAbrir.Size = New Size(146, 22)
        ToolStripMenuAbrir.Text = "Abrir"
        ' 
        ' ToolStripMenuGuardarComo
        ' 
        ToolStripMenuGuardarComo.Name = "ToolStripMenuGuardarComo"
        ToolStripMenuGuardarComo.Size = New Size(146, 22)
        ToolStripMenuGuardarComo.Text = "Guarda como"
        ' 
        ' ToolStripSeparator8
        ' 
        ToolStripSeparator8.Name = "ToolStripSeparator8"
        ToolStripSeparator8.Size = New Size(143, 6)
        ' 
        ' ToolStripMenuSalir
        ' 
        ToolStripMenuSalir.Name = "ToolStripMenuSalir"
        ToolStripMenuSalir.Size = New Size(146, 22)
        ToolStripMenuSalir.Text = "Salir"
        ' 
        ' ToolStripMenuEditar
        ' 
        ToolStripMenuEditar.DropDownItems.AddRange(New ToolStripItem() {ToolStripMenuCopiar, ToolStripMenuCortar, ToolStripMenuPegar, ToolStripSeparator9, ToolStripMenuSeleccionarTodo, ToolStripSeparator10, ToolStripMenuDeshacer, ToolStripMenuRehacer})
        ToolStripMenuEditar.ForeColor = SystemColors.ButtonFace
        ToolStripMenuEditar.Name = "ToolStripMenuEditar"
        ToolStripMenuEditar.Size = New Size(49, 20)
        ToolStripMenuEditar.Text = "Editar"
        ' 
        ' ToolStripMenuCopiar
        ' 
        ToolStripMenuCopiar.Name = "ToolStripMenuCopiar"
        ToolStripMenuCopiar.Size = New Size(162, 22)
        ToolStripMenuCopiar.Text = "Copiar"
        ' 
        ' ToolStripMenuCortar
        ' 
        ToolStripMenuCortar.Name = "ToolStripMenuCortar"
        ToolStripMenuCortar.Size = New Size(162, 22)
        ToolStripMenuCortar.Text = "Cortar"
        ' 
        ' ToolStripMenuPegar
        ' 
        ToolStripMenuPegar.Name = "ToolStripMenuPegar"
        ToolStripMenuPegar.Size = New Size(162, 22)
        ToolStripMenuPegar.Text = "Pegar"
        ' 
        ' ToolStripSeparator9
        ' 
        ToolStripSeparator9.Name = "ToolStripSeparator9"
        ToolStripSeparator9.Size = New Size(159, 6)
        ' 
        ' ToolStripMenuSeleccionarTodo
        ' 
        ToolStripMenuSeleccionarTodo.Name = "ToolStripMenuSeleccionarTodo"
        ToolStripMenuSeleccionarTodo.Size = New Size(162, 22)
        ToolStripMenuSeleccionarTodo.Text = "Seleccionar todo"
        ' 
        ' ToolStripSeparator10
        ' 
        ToolStripSeparator10.Name = "ToolStripSeparator10"
        ToolStripSeparator10.Size = New Size(159, 6)
        ' 
        ' ToolStripMenuDeshacer
        ' 
        ToolStripMenuDeshacer.Name = "ToolStripMenuDeshacer"
        ToolStripMenuDeshacer.Size = New Size(162, 22)
        ToolStripMenuDeshacer.Text = "Deshacer"
        ' 
        ' ToolStripMenuRehacer
        ' 
        ToolStripMenuRehacer.Name = "ToolStripMenuRehacer"
        ToolStripMenuRehacer.Size = New Size(162, 22)
        ToolStripMenuRehacer.Text = "Rehacer"
        ' 
        ' txtEditor
        ' 
        txtEditor.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        txtEditor.ContextMenuStrip = ContextMenuStrip1
        txtEditor.Location = New Point(130, 130)
        txtEditor.Name = "txtEditor"
        txtEditor.Size = New Size(500, 368)
        txtEditor.TabIndex = 3
        txtEditor.Text = ""
        ' 
        ' ContextMenuStrip1
        ' 
        ContextMenuStrip1.Items.AddRange(New ToolStripItem() {CortarContextMenuStrip, CopiarContextMenuStrip, PegarContextMenuStrip, SeleccionarTodoContextMenuStrip})
        ContextMenuStrip1.Name = "ContextMenuStrip1"
        ContextMenuStrip1.Size = New Size(163, 92)
        ' 
        ' CortarContextMenuStrip
        ' 
        CortarContextMenuStrip.Name = "CortarContextMenuStrip"
        CortarContextMenuStrip.Size = New Size(162, 22)
        CortarContextMenuStrip.Text = "Cortar"
        ' 
        ' CopiarContextMenuStrip
        ' 
        CopiarContextMenuStrip.Name = "CopiarContextMenuStrip"
        CopiarContextMenuStrip.Size = New Size(162, 22)
        CopiarContextMenuStrip.Text = "Copiar"
        ' 
        ' PegarContextMenuStrip
        ' 
        PegarContextMenuStrip.Name = "PegarContextMenuStrip"
        PegarContextMenuStrip.Size = New Size(162, 22)
        PegarContextMenuStrip.Text = "Pegar"
        ' 
        ' SeleccionarTodoContextMenuStrip
        ' 
        SeleccionarTodoContextMenuStrip.Name = "SeleccionarTodoContextMenuStrip"
        SeleccionarTodoContextMenuStrip.Size = New Size(162, 22)
        SeleccionarTodoContextMenuStrip.Text = "Seleccionar todo"
        ' 
        ' PanelTitulo
        ' 
        PanelTitulo.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        PanelTitulo.BackColor = Color.IndianRed
        PanelTitulo.Controls.Add(btnSalir)
        PanelTitulo.Controls.Add(btnMaximizar)
        PanelTitulo.Controls.Add(btnMinimizar)
        PanelTitulo.Controls.Add(lbTitulo)
        PanelTitulo.Controls.Add(pbImagen)
        PanelTitulo.Location = New Point(2, 2)
        PanelTitulo.Name = "PanelTitulo"
        PanelTitulo.Size = New Size(800, 36)
        PanelTitulo.TabIndex = 4
        ' 
        ' btnSalir
        ' 
        btnSalir.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btnSalir.BackColor = Color.LightCoral
        btnSalir.BackgroundImage = My.Resources.Resources.cruz
        btnSalir.BackgroundImageLayout = ImageLayout.Zoom
        btnSalir.FlatAppearance.BorderSize = 0
        btnSalir.FlatStyle = FlatStyle.Flat
        btnSalir.ForeColor = Color.Transparent
        btnSalir.Location = New Point(754, 7)
        btnSalir.Name = "btnSalir"
        btnSalir.Size = New Size(32, 24)
        btnSalir.TabIndex = 8
        btnSalir.UseVisualStyleBackColor = False
        ' 
        ' btnMaximizar
        ' 
        btnMaximizar.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btnMaximizar.BackColor = Color.LightCoral
        btnMaximizar.BackgroundImage = My.Resources.Resources.maximizar
        btnMaximizar.BackgroundImageLayout = ImageLayout.Zoom
        btnMaximizar.FlatAppearance.BorderSize = 0
        btnMaximizar.FlatStyle = FlatStyle.Flat
        btnMaximizar.Image = My.Resources.Resources.maximizar
        btnMaximizar.Location = New Point(712, 7)
        btnMaximizar.Name = "btnMaximizar"
        btnMaximizar.Size = New Size(38, 24)
        btnMaximizar.TabIndex = 7
        btnMaximizar.UseVisualStyleBackColor = False
        ' 
        ' btnMinimizar
        ' 
        btnMinimizar.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btnMinimizar.BackColor = Color.LightCoral
        btnMinimizar.BackgroundImage = My.Resources.Resources.minimizar_signo
        btnMinimizar.BackgroundImageLayout = ImageLayout.Zoom
        btnMinimizar.FlatAppearance.BorderSize = 0
        btnMinimizar.FlatStyle = FlatStyle.Flat
        btnMinimizar.ForeColor = Color.Transparent
        btnMinimizar.Location = New Point(668, 7)
        btnMinimizar.Name = "btnMinimizar"
        btnMinimizar.Size = New Size(40, 24)
        btnMinimizar.TabIndex = 6
        btnMinimizar.UseVisualStyleBackColor = False
        ' 
        ' lbTitulo
        ' 
        lbTitulo.AutoSize = True
        lbTitulo.Font = New Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lbTitulo.ForeColor = Color.Maroon
        lbTitulo.Location = New Point(80, 7)
        lbTitulo.Name = "lbTitulo"
        lbTitulo.Size = New Size(182, 20)
        lbTitulo.TabIndex = 5
        lbTitulo.Text = "BLOC DE NOTAS LAURA "
        ' 
        ' pbImagen
        ' 
        pbImagen.BackColor = Color.Transparent
        pbImagen.Image = My.Resources.Resources.notas_adhesivas1
        pbImagen.InitialImage = CType(resources.GetObject("pbImagen.InitialImage"), Image)
        pbImagen.Location = New Point(10, 4)
        pbImagen.Name = "pbImagen"
        pbImagen.Size = New Size(64, 29)
        pbImagen.SizeMode = PictureBoxSizeMode.Zoom
        pbImagen.TabIndex = 0
        pbImagen.TabStop = False
        ' 
        ' TrackBar
        ' 
        TrackBar.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        TrackBar.Location = New Point(670, 476)
        TrackBar.Name = "TrackBar"
        TrackBar.Size = New Size(132, 45)
        TrackBar.TabIndex = 10
        ' 
        ' lblPorcentaje
        ' 
        lblPorcentaje.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        lblPorcentaje.AutoSize = True
        lblPorcentaje.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblPorcentaje.ForeColor = SystemColors.ActiveCaptionText
        lblPorcentaje.Location = New Point(756, 456)
        lblPorcentaje.Name = "lblPorcentaje"
        lblPorcentaje.Size = New Size(19, 17)
        lblPorcentaje.TabIndex = 11
        lblPorcentaje.Text = "%"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 510)
        Controls.Add(lblPorcentaje)
        Controls.Add(TrackBar)
        Controls.Add(PanelTitulo)
        Controls.Add(txtEditor)
        Controls.Add(PanelMenu)
        ForeColor = SystemColors.Control
        Name = "Form1"
        Text = "Form1"
        PanelMenu.ResumeLayout(False)
        PanelMenu.PerformLayout()
        ToolStrip2.ResumeLayout(False)
        ToolStrip2.PerformLayout()
        MenuStrip2.ResumeLayout(False)
        MenuStrip2.PerformLayout()
        ContextMenuStrip1.ResumeLayout(False)
        PanelTitulo.ResumeLayout(False)
        PanelTitulo.PerformLayout()
        CType(pbImagen, ComponentModel.ISupportInitialize).EndInit()
        CType(TrackBar, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents PanelMenu As Panel
    Friend WithEvents ToolStrip2 As ToolStrip
    Friend WithEvents cbFuentes As ToolStripComboBox
    Friend WithEvents ToolStripSeparator11 As ToolStripSeparator
    Friend WithEvents ToolStripSeparator12 As ToolStripSeparator
    Friend WithEvents ToolStripSeparator13 As ToolStripSeparator
    Friend WithEvents lblTamaño As ToolStripLabel
    Friend WithEvents txbTamañoLetra As ToolStripTextBox
    Friend WithEvents ToolStripSeparator14 As ToolStripSeparator
    Friend WithEvents btnColor As ToolStripButton
    Friend WithEvents MenuStrip2 As MenuStrip
    Friend WithEvents ToolStripMenuArchivo As ToolStripMenuItem
    Friend WithEvents ToolStripMenuNuevo As ToolStripMenuItem
    Friend WithEvents ToolStripMenuAbrir As ToolStripMenuItem
    Friend WithEvents ToolStripMenuGuardarComo As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator8 As ToolStripSeparator
    Friend WithEvents ToolStripMenuSalir As ToolStripMenuItem
    Friend WithEvents ToolStripMenuEditar As ToolStripMenuItem
    Friend WithEvents ToolStripMenuCopiar As ToolStripMenuItem
    Friend WithEvents ToolStripMenuCortar As ToolStripMenuItem
    Friend WithEvents ToolStripMenuPegar As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator9 As ToolStripSeparator
    Friend WithEvents ToolStripMenuSeleccionarTodo As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator10 As ToolStripSeparator
    Friend WithEvents ToolStripMenuDeshacer As ToolStripMenuItem
    Friend WithEvents ToolStripMenuRehacer As ToolStripMenuItem
    Friend WithEvents txtEditor As RichTextBox
    Friend WithEvents PanelTitulo As Panel
    Friend WithEvents pbImagen As PictureBox
    Friend WithEvents lbTitulo As Label
    Friend WithEvents btnNegrita As ToolStripButton
    Friend WithEvents btnCursiva As ToolStripButton
    Friend WithEvents btnSalir As Button
    Friend WithEvents btnMaximizar As Button
    Friend WithEvents btnMinimizar As Button
    Friend WithEvents TrackBar As TrackBar
    Friend WithEvents lblPorcentaje As Label
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents CortarContextMenuStrip As ToolStripMenuItem
    Friend WithEvents CopiarContextMenuStrip As ToolStripMenuItem
    Friend WithEvents PegarContextMenuStrip As ToolStripMenuItem
    Friend WithEvents SeleccionarTodoContextMenuStrip As ToolStripMenuItem

End Class
