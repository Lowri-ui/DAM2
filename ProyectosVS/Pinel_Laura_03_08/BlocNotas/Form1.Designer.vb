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
        Panel1 = New Panel()
        ToolStrip2 = New ToolStrip()
        cbTipografia = New ToolStripComboBox()
        ToolStripSeparator11 = New ToolStripSeparator()
        btnNegrita = New ToolStripButton()
        ToolStripSeparator12 = New ToolStripSeparator()
        btnCursiva = New ToolStripButton()
        ToolStripSeparator13 = New ToolStripSeparator()
        lblTamaño = New ToolStripLabel()
        txbTamañoLetra = New ToolStripTextBox()
        ToolStripSeparator14 = New ToolStripSeparator()
        ToolStripButton2 = New ToolStripButton()
        MenuStrip2 = New MenuStrip()
        ToolStripMenuArchivo = New ToolStripMenuItem()
        ToolStripMenuItem2 = New ToolStripMenuItem()
        ToolStripMenuItem3 = New ToolStripMenuItem()
        ToolStripMenuItem4 = New ToolStripMenuItem()
        ToolStripSeparator8 = New ToolStripSeparator()
        ToolStripMenuItem5 = New ToolStripMenuItem()
        ToolStripMenuEditar = New ToolStripMenuItem()
        ToolStripMenuItem7 = New ToolStripMenuItem()
        ToolStripMenuItem8 = New ToolStripMenuItem()
        ToolStripMenuItem9 = New ToolStripMenuItem()
        ToolStripSeparator9 = New ToolStripSeparator()
        ToolStripMenuItem10 = New ToolStripMenuItem()
        ToolStripSeparator10 = New ToolStripSeparator()
        ToolStripMenuItem11 = New ToolStripMenuItem()
        ToolStripMenuItem12 = New ToolStripMenuItem()
        rtbxBloc = New RichTextBox()
        Panel2 = New Panel()
        lbTitulo = New Label()
        pbImagen = New PictureBox()
        btnMinimizar = New Button()
        btnMaximizar = New Button()
        btnSalir = New Button()
        Panel1.SuspendLayout()
        ToolStrip2.SuspendLayout()
        MenuStrip2.SuspendLayout()
        Panel2.SuspendLayout()
        CType(pbImagen, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        Panel1.BackColor = Color.DimGray
        Panel1.Controls.Add(ToolStrip2)
        Panel1.Controls.Add(MenuStrip2)
        Panel1.Location = New Point(2, 39)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(800, 61)
        Panel1.TabIndex = 2
        ' 
        ' ToolStrip2
        ' 
        ToolStrip2.BackColor = Color.DimGray
        ToolStrip2.Items.AddRange(New ToolStripItem() {cbTipografia, ToolStripSeparator11, btnNegrita, ToolStripSeparator12, btnCursiva, ToolStripSeparator13, lblTamaño, txbTamañoLetra, ToolStripSeparator14, ToolStripButton2})
        ToolStrip2.Location = New Point(0, 24)
        ToolStrip2.Name = "ToolStrip2"
        ToolStrip2.Size = New Size(800, 25)
        ToolStrip2.TabIndex = 3
        ToolStrip2.Text = "ToolStrip2"
        ' 
        ' cbTipografia
        ' 
        cbTipografia.Name = "cbTipografia"
        cbTipografia.Size = New Size(121, 25)
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
        btnNegrita.Text = "N"
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
        btnCursiva.Text = "K"
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
        ' ToolStripButton2
        ' 
        ToolStripButton2.BackColor = Color.Black
        ToolStripButton2.DisplayStyle = ToolStripItemDisplayStyle.Image
        ToolStripButton2.ImageTransparentColor = Color.Magenta
        ToolStripButton2.Name = "ToolStripButton2"
        ToolStripButton2.Size = New Size(23, 22)
        ToolStripButton2.Text = "btnColorLetra"
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
        ToolStripMenuArchivo.DropDownItems.AddRange(New ToolStripItem() {ToolStripMenuItem2, ToolStripMenuItem3, ToolStripMenuItem4, ToolStripSeparator8, ToolStripMenuItem5})
        ToolStripMenuArchivo.ForeColor = SystemColors.ButtonFace
        ToolStripMenuArchivo.Name = "ToolStripMenuArchivo"
        ToolStripMenuArchivo.Size = New Size(60, 20)
        ToolStripMenuArchivo.Text = "Archivo"
        ' 
        ' ToolStripMenuItem2
        ' 
        ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        ToolStripMenuItem2.Size = New Size(146, 22)
        ToolStripMenuItem2.Text = "Nuevo"
        ' 
        ' ToolStripMenuItem3
        ' 
        ToolStripMenuItem3.Name = "ToolStripMenuItem3"
        ToolStripMenuItem3.Size = New Size(146, 22)
        ToolStripMenuItem3.Text = "Abrir"
        ' 
        ' ToolStripMenuItem4
        ' 
        ToolStripMenuItem4.Name = "ToolStripMenuItem4"
        ToolStripMenuItem4.Size = New Size(146, 22)
        ToolStripMenuItem4.Text = "Guarda como"
        ' 
        ' ToolStripSeparator8
        ' 
        ToolStripSeparator8.Name = "ToolStripSeparator8"
        ToolStripSeparator8.Size = New Size(143, 6)
        ' 
        ' ToolStripMenuItem5
        ' 
        ToolStripMenuItem5.Name = "ToolStripMenuItem5"
        ToolStripMenuItem5.Size = New Size(146, 22)
        ToolStripMenuItem5.Text = "Salir"
        ' 
        ' ToolStripMenuEditar
        ' 
        ToolStripMenuEditar.DropDownItems.AddRange(New ToolStripItem() {ToolStripMenuItem7, ToolStripMenuItem8, ToolStripMenuItem9, ToolStripSeparator9, ToolStripMenuItem10, ToolStripSeparator10, ToolStripMenuItem11, ToolStripMenuItem12})
        ToolStripMenuEditar.ForeColor = SystemColors.ButtonFace
        ToolStripMenuEditar.Name = "ToolStripMenuEditar"
        ToolStripMenuEditar.Size = New Size(49, 20)
        ToolStripMenuEditar.Text = "Editar"
        ' 
        ' ToolStripMenuItem7
        ' 
        ToolStripMenuItem7.Name = "ToolStripMenuItem7"
        ToolStripMenuItem7.Size = New Size(162, 22)
        ToolStripMenuItem7.Text = "Copiar"
        ' 
        ' ToolStripMenuItem8
        ' 
        ToolStripMenuItem8.Name = "ToolStripMenuItem8"
        ToolStripMenuItem8.Size = New Size(162, 22)
        ToolStripMenuItem8.Text = "Cortar"
        ' 
        ' ToolStripMenuItem9
        ' 
        ToolStripMenuItem9.Name = "ToolStripMenuItem9"
        ToolStripMenuItem9.Size = New Size(162, 22)
        ToolStripMenuItem9.Text = "Pegar"
        ' 
        ' ToolStripSeparator9
        ' 
        ToolStripSeparator9.Name = "ToolStripSeparator9"
        ToolStripSeparator9.Size = New Size(159, 6)
        ' 
        ' ToolStripMenuItem10
        ' 
        ToolStripMenuItem10.Name = "ToolStripMenuItem10"
        ToolStripMenuItem10.Size = New Size(162, 22)
        ToolStripMenuItem10.Text = "Seleccionar todo"
        ' 
        ' ToolStripSeparator10
        ' 
        ToolStripSeparator10.Name = "ToolStripSeparator10"
        ToolStripSeparator10.Size = New Size(159, 6)
        ' 
        ' ToolStripMenuItem11
        ' 
        ToolStripMenuItem11.Name = "ToolStripMenuItem11"
        ToolStripMenuItem11.Size = New Size(162, 22)
        ToolStripMenuItem11.Text = "Deshacer"
        ' 
        ' ToolStripMenuItem12
        ' 
        ToolStripMenuItem12.Name = "ToolStripMenuItem12"
        ToolStripMenuItem12.Size = New Size(162, 22)
        ToolStripMenuItem12.Text = "Rehacer"
        ' 
        ' rtbxBloc
        ' 
        rtbxBloc.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        rtbxBloc.Location = New Point(12, 106)
        rtbxBloc.Name = "rtbxBloc"
        rtbxBloc.Size = New Size(776, 332)
        rtbxBloc.TabIndex = 3
        rtbxBloc.Text = ""
        ' 
        ' Panel2
        ' 
        Panel2.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        Panel2.BackColor = Color.IndianRed
        Panel2.Controls.Add(btnSalir)
        Panel2.Controls.Add(btnMaximizar)
        Panel2.Controls.Add(btnMinimizar)
        Panel2.Controls.Add(lbTitulo)
        Panel2.Controls.Add(pbImagen)
        Panel2.Location = New Point(2, 2)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(800, 36)
        Panel2.TabIndex = 4
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
        ' btnMinimizar
        ' 
        btnMinimizar.BackColor = SystemColors.InactiveBorder
        btnMinimizar.ForeColor = Color.Transparent
        btnMinimizar.Image = My.Resources.Resources.minimizar_signo
        btnMinimizar.Location = New Point(684, 19)
        btnMinimizar.Name = "btnMinimizar"
        btnMinimizar.Size = New Size(30, 10)
        btnMinimizar.TabIndex = 6
        btnMinimizar.UseVisualStyleBackColor = False
        ' 
        ' btnMaximizar
        ' 
        btnMaximizar.Image = My.Resources.Resources.maximizar
        btnMaximizar.Location = New Point(720, 10)
        btnMaximizar.Name = "btnMaximizar"
        btnMaximizar.Size = New Size(30, 19)
        btnMaximizar.TabIndex = 7
        btnMaximizar.UseVisualStyleBackColor = True
        ' 
        ' btnSalir
        ' 
        btnSalir.Location = New Point(756, 10)
        btnSalir.Name = "btnSalir"
        btnSalir.Size = New Size(30, 19)
        btnSalir.TabIndex = 8
        btnSalir.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 510)
        Controls.Add(Panel2)
        Controls.Add(rtbxBloc)
        Controls.Add(Panel1)
        ForeColor = SystemColors.Control
        Name = "Form1"
        Text = "Form1"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ToolStrip2.ResumeLayout(False)
        ToolStrip2.PerformLayout()
        MenuStrip2.ResumeLayout(False)
        MenuStrip2.PerformLayout()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        CType(pbImagen, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub
    Friend WithEvents Panel1 As Panel
    Friend WithEvents ToolStrip2 As ToolStrip
    Friend WithEvents cbTipografia As ToolStripComboBox
    Friend WithEvents ToolStripSeparator11 As ToolStripSeparator
    Friend WithEvents ToolStripSeparator12 As ToolStripSeparator
    Friend WithEvents ToolStripSeparator13 As ToolStripSeparator
    Friend WithEvents lblTamaño As ToolStripLabel
    Friend WithEvents txbTamañoLetra As ToolStripTextBox
    Friend WithEvents ToolStripSeparator14 As ToolStripSeparator
    Friend WithEvents ToolStripButton2 As ToolStripButton
    Friend WithEvents MenuStrip2 As MenuStrip
    Friend WithEvents ToolStripMenuArchivo As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem3 As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem4 As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator8 As ToolStripSeparator
    Friend WithEvents ToolStripMenuItem5 As ToolStripMenuItem
    Friend WithEvents ToolStripMenuEditar As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem7 As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem8 As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem9 As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator9 As ToolStripSeparator
    Friend WithEvents ToolStripMenuItem10 As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator10 As ToolStripSeparator
    Friend WithEvents ToolStripMenuItem11 As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem12 As ToolStripMenuItem
    Friend WithEvents rtbxBloc As RichTextBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents pbImagen As PictureBox
    Friend WithEvents lbTitulo As Label
    Friend WithEvents btnNegrita As ToolStripButton
    Friend WithEvents btnCursiva As ToolStripButton
    Friend WithEvents btnSalir As Button
    Friend WithEvents btnMaximizar As Button
    Friend WithEvents btnMinimizar As Button

End Class
