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
        PanelTitulo = New Panel()
        lblTitulo = New Label()
        PanelLogo = New Panel()
        PictureBox1 = New PictureBox()
        TabControl1 = New TabControl()
        tpCargar = New TabPage()
        btnLimpiar = New Button()
        btnIniciar = New Button()
        DataGridView1 = New DataGridView()
        tpGuardar = New TabPage()
        btnGuardar = New Button()
        DataGridView2 = New DataGridView()
        idPersona = New DataGridViewTextBoxColumn()
        perIdentificacion = New DataGridViewTextBoxColumn()
        perNombres = New DataGridViewTextBoxColumn()
        perApellidos = New DataGridViewTextBoxColumn()
        perGenero = New DataGridViewTextBoxColumn()
        perCorreo = New DataGridViewTextBoxColumn()
        perFechaNacimiento = New DataGridViewTextBoxColumn()
        PanelTitulo.SuspendLayout()
        PanelLogo.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        TabControl1.SuspendLayout()
        tpCargar.SuspendLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        tpGuardar.SuspendLayout()
        CType(DataGridView2, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' PanelTitulo
        ' 
        PanelTitulo.BackColor = Color.FromArgb(CByte(18), CByte(32), CByte(47))
        PanelTitulo.BorderStyle = BorderStyle.FixedSingle
        PanelTitulo.Controls.Add(lblTitulo)
        PanelTitulo.Controls.Add(PanelLogo)
        PanelTitulo.Dock = DockStyle.Top
        PanelTitulo.ForeColor = Color.FromArgb(CByte(70), CByte(70), CByte(70))
        PanelTitulo.Location = New Point(0, 0)
        PanelTitulo.Name = "PanelTitulo"
        PanelTitulo.Size = New Size(890, 67)
        PanelTitulo.TabIndex = 0
        ' 
        ' lblTitulo
        ' 
        lblTitulo.AutoSize = True
        lblTitulo.Font = New Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblTitulo.ForeColor = Color.FromArgb(CByte(0), CByte(204), CByte(255))
        lblTitulo.Location = New Point(97, 27)
        lblTitulo.Name = "lblTitulo"
        lblTitulo.Size = New Size(263, 23)
        lblTitulo.TabIndex = 1
        lblTitulo.Text = "CONEXIÓN A LA BASE DE DATOS"
        ' 
        ' PanelLogo
        ' 
        PanelLogo.Controls.Add(PictureBox1)
        PanelLogo.Dock = DockStyle.Left
        PanelLogo.Location = New Point(0, 0)
        PanelLogo.Name = "PanelLogo"
        PanelLogo.Size = New Size(82, 65)
        PanelLogo.TabIndex = 0
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Dock = DockStyle.Fill
        PictureBox1.Image = My.Resources.Resources.base_de_datos
        PictureBox1.Location = New Point(0, 0)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(82, 65)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.TabIndex = 2
        PictureBox1.TabStop = False
        ' 
        ' TabControl1
        ' 
        TabControl1.Controls.Add(tpCargar)
        TabControl1.Controls.Add(tpGuardar)
        TabControl1.Location = New Point(37, 107)
        TabControl1.Name = "TabControl1"
        TabControl1.SelectedIndex = 0
        TabControl1.Size = New Size(821, 619)
        TabControl1.TabIndex = 1
        ' 
        ' tpCargar
        ' 
        tpCargar.Controls.Add(btnLimpiar)
        tpCargar.Controls.Add(btnIniciar)
        tpCargar.Controls.Add(DataGridView1)
        tpCargar.Location = New Point(4, 24)
        tpCargar.Name = "tpCargar"
        tpCargar.Padding = New Padding(3)
        tpCargar.Size = New Size(813, 591)
        tpCargar.TabIndex = 0
        tpCargar.Text = "Cargar"
        tpCargar.UseVisualStyleBackColor = True
        ' 
        ' btnLimpiar
        ' 
        btnLimpiar.BackColor = Color.FromArgb(CByte(18), CByte(32), CByte(47))
        btnLimpiar.FlatStyle = FlatStyle.Flat
        btnLimpiar.Font = New Font("Calibri", 12F, FontStyle.Bold)
        btnLimpiar.ForeColor = Color.White
        btnLimpiar.Location = New Point(123, 24)
        btnLimpiar.Name = "btnLimpiar"
        btnLimpiar.Size = New Size(86, 43)
        btnLimpiar.TabIndex = 2
        btnLimpiar.Text = "Limpiar"
        btnLimpiar.UseVisualStyleBackColor = False
        ' 
        ' btnIniciar
        ' 
        btnIniciar.BackColor = Color.FromArgb(CByte(18), CByte(32), CByte(47))
        btnIniciar.FlatStyle = FlatStyle.Flat
        btnIniciar.Font = New Font("Calibri", 12F, FontStyle.Bold)
        btnIniciar.ForeColor = Color.White
        btnIniciar.Location = New Point(19, 24)
        btnIniciar.Name = "btnIniciar"
        btnIniciar.Size = New Size(86, 43)
        btnIniciar.TabIndex = 1
        btnIniciar.Text = "Iniciar"
        btnIniciar.UseVisualStyleBackColor = False
        ' 
        ' DataGridView1
        ' 
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(19, 84)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.Size = New Size(779, 469)
        DataGridView1.TabIndex = 0
        ' 
        ' tpGuardar
        ' 
        tpGuardar.Controls.Add(btnGuardar)
        tpGuardar.Controls.Add(DataGridView2)
        tpGuardar.Location = New Point(4, 24)
        tpGuardar.Name = "tpGuardar"
        tpGuardar.Padding = New Padding(3)
        tpGuardar.Size = New Size(813, 591)
        tpGuardar.TabIndex = 1
        tpGuardar.Text = "Guardar"
        tpGuardar.UseVisualStyleBackColor = True
        ' 
        ' btnGuardar
        ' 
        btnGuardar.BackColor = Color.FromArgb(CByte(18), CByte(32), CByte(47))
        btnGuardar.FlatStyle = FlatStyle.Flat
        btnGuardar.Font = New Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnGuardar.ForeColor = Color.White
        btnGuardar.Location = New Point(15, 26)
        btnGuardar.Name = "btnGuardar"
        btnGuardar.Size = New Size(86, 43)
        btnGuardar.TabIndex = 2
        btnGuardar.Text = "Guardar"
        btnGuardar.UseVisualStyleBackColor = False
        ' 
        ' DataGridView2
        ' 
        DataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView2.Columns.AddRange(New DataGridViewColumn() {idPersona, perIdentificacion, perNombres, perApellidos, perGenero, perCorreo, perFechaNacimiento})
        DataGridView2.Location = New Point(15, 85)
        DataGridView2.Name = "DataGridView2"
        DataGridView2.Size = New Size(776, 471)
        DataGridView2.TabIndex = 0
        ' 
        ' idPersona
        ' 
        idPersona.HeaderText = "ID"
        idPersona.Name = "idPersona"
        ' 
        ' perIdentificacion
        ' 
        perIdentificacion.HeaderText = "Identificación"
        perIdentificacion.Name = "perIdentificacion"
        ' 
        ' perNombres
        ' 
        perNombres.HeaderText = "Nombre"
        perNombres.Name = "perNombres"
        ' 
        ' perApellidos
        ' 
        perApellidos.HeaderText = "Apellidos"
        perApellidos.Name = "perApellidos"
        ' 
        ' perGenero
        ' 
        perGenero.HeaderText = "Genero"
        perGenero.Name = "perGenero"
        ' 
        ' perCorreo
        ' 
        perCorreo.HeaderText = "Email"
        perCorreo.Name = "perCorreo"
        ' 
        ' perFechaNacimiento
        ' 
        perFechaNacimiento.HeaderText = "Fecha de nacimiento"
        perFechaNacimiento.Name = "perFechaNacimiento"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(28), CByte(36), CByte(48))
        ClientSize = New Size(890, 753)
        Controls.Add(TabControl1)
        Controls.Add(PanelTitulo)
        Name = "Form1"
        Text = "Form1"
        PanelTitulo.ResumeLayout(False)
        PanelTitulo.PerformLayout()
        PanelLogo.ResumeLayout(False)
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        TabControl1.ResumeLayout(False)
        tpCargar.ResumeLayout(False)
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        tpGuardar.ResumeLayout(False)
        CType(DataGridView2, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents PanelTitulo As Panel
    Friend WithEvents lblTitulo As Label
    Friend WithEvents PanelLogo As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents tpCargar As TabPage
    Friend WithEvents tpGuardar As TabPage
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents DataGridView2 As DataGridView
    Friend WithEvents btnLimpiar As Button
    Friend WithEvents btnIniciar As Button
    Friend WithEvents btnGuardar As Button
    Friend WithEvents idPersona As DataGridViewTextBoxColumn
    Friend WithEvents perNombres As DataGridViewTextBoxColumn
    Friend WithEvents perApellidos As DataGridViewTextBoxColumn
    Friend WithEvents perGenero As DataGridViewTextBoxColumn
    Friend WithEvents perCorreo As DataGridViewTextBoxColumn
    Friend WithEvents perFechaNacimiento As DataGridViewTextBoxColumn
    Friend WithEvents perIdentificacion As DataGridViewTextBoxColumn

End Class
