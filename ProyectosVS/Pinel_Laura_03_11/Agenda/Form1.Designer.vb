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
        Dim DataGridViewCellStyle1 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As DataGridViewCellStyle = New DataGridViewCellStyle()
        PanelTitulo = New Panel()
        PanelIcono = New Panel()
        pbLogo = New PictureBox()
        Label1 = New Label()
        gbDatos = New GroupBox()
        cbSexo = New ComboBox()
        lblSexo = New Label()
        tbDireccion = New TextBox()
        lblDireccion = New Label()
        tbTelefono = New TextBox()
        lblTelefono = New Label()
        tbDni = New TextBox()
        lblDni = New Label()
        tbNombre = New TextBox()
        lblNombre = New Label()
        PanelDatos = New Panel()
        btnSalir = New Button()
        btnGuardar = New Button()
        btnEliminar = New Button()
        btnModificar = New Button()
        btnAgregar = New Button()
        PanelLista = New Panel()
        gbLista = New GroupBox()
        DataGridView1 = New DataGridView()
        Column1 = New DataGridViewTextBoxColumn()
        Column2 = New DataGridViewTextBoxColumn()
        Column3 = New DataGridViewTextBoxColumn()
        Column4 = New DataGridViewTextBoxColumn()
        Column5 = New DataGridViewTextBoxColumn()
        PanelTitulo.SuspendLayout()
        PanelIcono.SuspendLayout()
        CType(pbLogo, ComponentModel.ISupportInitialize).BeginInit()
        gbDatos.SuspendLayout()
        PanelDatos.SuspendLayout()
        PanelLista.SuspendLayout()
        gbLista.SuspendLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' PanelTitulo
        ' 
        PanelTitulo.BackColor = Color.FromArgb(CByte(255), CByte(228), CByte(230))
        PanelTitulo.Controls.Add(PanelIcono)
        PanelTitulo.Controls.Add(Label1)
        PanelTitulo.Dock = DockStyle.Top
        PanelTitulo.ForeColor = Color.FromArgb(CByte(255), CByte(228), CByte(230))
        PanelTitulo.Location = New Point(0, 0)
        PanelTitulo.Name = "PanelTitulo"
        PanelTitulo.Size = New Size(750, 59)
        PanelTitulo.TabIndex = 0
        ' 
        ' PanelIcono
        ' 
        PanelIcono.Controls.Add(pbLogo)
        PanelIcono.Dock = DockStyle.Left
        PanelIcono.Location = New Point(0, 0)
        PanelIcono.Name = "PanelIcono"
        PanelIcono.Size = New Size(76, 59)
        PanelIcono.TabIndex = 2
        ' 
        ' pbLogo
        ' 
        pbLogo.Dock = DockStyle.Fill
        pbLogo.Image = My.Resources.Resources.usuario
        pbLogo.Location = New Point(0, 0)
        pbLogo.Name = "pbLogo"
        pbLogo.Size = New Size(76, 59)
        pbLogo.SizeMode = PictureBoxSizeMode.Zoom
        pbLogo.TabIndex = 0
        pbLogo.TabStop = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Verdana", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.FromArgb(CByte(80), CByte(52), CByte(42))
        Label1.Location = New Point(82, 19)
        Label1.Name = "Label1"
        Label1.Size = New Size(110, 25)
        Label1.TabIndex = 1
        Label1.Text = "AGENDA"
        ' 
        ' gbDatos
        ' 
        gbDatos.Controls.Add(cbSexo)
        gbDatos.Controls.Add(lblSexo)
        gbDatos.Controls.Add(tbDireccion)
        gbDatos.Controls.Add(lblDireccion)
        gbDatos.Controls.Add(tbTelefono)
        gbDatos.Controls.Add(lblTelefono)
        gbDatos.Controls.Add(tbDni)
        gbDatos.Controls.Add(lblDni)
        gbDatos.Controls.Add(tbNombre)
        gbDatos.Controls.Add(lblNombre)
        gbDatos.Font = New Font("Verdana", 12F, FontStyle.Bold)
        gbDatos.ForeColor = Color.FromArgb(CByte(80), CByte(52), CByte(42))
        gbDatos.Location = New Point(47, 19)
        gbDatos.Name = "gbDatos"
        gbDatos.Size = New Size(515, 270)
        gbDatos.TabIndex = 1
        gbDatos.TabStop = False
        gbDatos.Text = "Datos del contacto"
        ' 
        ' cbSexo
        ' 
        cbSexo.DropDownStyle = ComboBoxStyle.DropDownList
        cbSexo.FormattingEnabled = True
        cbSexo.Location = New Point(146, 223)
        cbSexo.Name = "cbSexo"
        cbSexo.Size = New Size(304, 26)
        cbSexo.TabIndex = 4
        ' 
        ' lblSexo
        ' 
        lblSexo.AutoSize = True
        lblSexo.Font = New Font("Verdana", 9.75F)
        lblSexo.ForeColor = Color.FromArgb(CByte(80), CByte(52), CByte(42))
        lblSexo.Location = New Point(68, 228)
        lblSexo.Name = "lblSexo"
        lblSexo.Size = New Size(45, 16)
        lblSexo.TabIndex = 8
        lblSexo.Text = "Sexo:"
        ' 
        ' tbDireccion
        ' 
        tbDireccion.Font = New Font("Verdana", 9.75F)
        tbDireccion.Location = New Point(146, 174)
        tbDireccion.Name = "tbDireccion"
        tbDireccion.Size = New Size(304, 23)
        tbDireccion.TabIndex = 7
        ' 
        ' lblDireccion
        ' 
        lblDireccion.AutoSize = True
        lblDireccion.Font = New Font("Verdana", 9.75F)
        lblDireccion.ForeColor = Color.FromArgb(CByte(80), CByte(52), CByte(42))
        lblDireccion.Location = New Point(68, 181)
        lblDireccion.Name = "lblDireccion"
        lblDireccion.Size = New Size(73, 16)
        lblDireccion.TabIndex = 6
        lblDireccion.Text = "Dirección:"
        ' 
        ' tbTelefono
        ' 
        tbTelefono.Font = New Font("Verdana", 9.75F)
        tbTelefono.Location = New Point(146, 127)
        tbTelefono.Name = "tbTelefono"
        tbTelefono.Size = New Size(304, 23)
        tbTelefono.TabIndex = 5
        ' 
        ' lblTelefono
        ' 
        lblTelefono.AutoSize = True
        lblTelefono.Font = New Font("Verdana", 9.75F)
        lblTelefono.ForeColor = Color.FromArgb(CByte(80), CByte(52), CByte(42))
        lblTelefono.Location = New Point(68, 134)
        lblTelefono.Name = "lblTelefono"
        lblTelefono.Size = New Size(69, 16)
        lblTelefono.TabIndex = 4
        lblTelefono.Text = "Teléfono:"
        ' 
        ' tbDni
        ' 
        tbDni.Font = New Font("Verdana", 9.75F)
        tbDni.Location = New Point(146, 83)
        tbDni.Name = "tbDni"
        tbDni.Size = New Size(304, 23)
        tbDni.TabIndex = 3
        ' 
        ' lblDni
        ' 
        lblDni.AutoSize = True
        lblDni.Font = New Font("Verdana", 9.75F)
        lblDni.ForeColor = Color.FromArgb(CByte(80), CByte(52), CByte(42))
        lblDni.Location = New Point(68, 90)
        lblDni.Name = "lblDni"
        lblDni.Size = New Size(36, 16)
        lblDni.TabIndex = 2
        lblDni.Text = "DNI:"
        ' 
        ' tbNombre
        ' 
        tbNombre.Font = New Font("Verdana", 9.75F)
        tbNombre.Location = New Point(146, 38)
        tbNombre.Name = "tbNombre"
        tbNombre.Size = New Size(304, 23)
        tbNombre.TabIndex = 1
        ' 
        ' lblNombre
        ' 
        lblNombre.AutoSize = True
        lblNombre.Font = New Font("Verdana", 9.75F)
        lblNombre.ForeColor = Color.FromArgb(CByte(80), CByte(52), CByte(42))
        lblNombre.Location = New Point(68, 45)
        lblNombre.Name = "lblNombre"
        lblNombre.Size = New Size(62, 16)
        lblNombre.TabIndex = 0
        lblNombre.Text = "Nombre:"
        ' 
        ' PanelDatos
        ' 
        PanelDatos.Controls.Add(btnSalir)
        PanelDatos.Controls.Add(btnGuardar)
        PanelDatos.Controls.Add(btnEliminar)
        PanelDatos.Controls.Add(btnModificar)
        PanelDatos.Controls.Add(btnAgregar)
        PanelDatos.Controls.Add(gbDatos)
        PanelDatos.Dock = DockStyle.Top
        PanelDatos.Location = New Point(0, 59)
        PanelDatos.Name = "PanelDatos"
        PanelDatos.Size = New Size(750, 303)
        PanelDatos.TabIndex = 2
        ' 
        ' btnSalir
        ' 
        btnSalir.BackColor = Color.LightCoral
        btnSalir.FlatAppearance.BorderSize = 0
        btnSalir.FlatStyle = FlatStyle.Flat
        btnSalir.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold)
        btnSalir.ForeColor = Color.White
        btnSalir.Location = New Point(608, 251)
        btnSalir.Name = "btnSalir"
        btnSalir.Size = New Size(72, 36)
        btnSalir.TabIndex = 6
        btnSalir.Text = "Salir"
        btnSalir.UseVisualStyleBackColor = False
        ' 
        ' btnGuardar
        ' 
        btnGuardar.BackColor = Color.LightCoral
        btnGuardar.FlatAppearance.BorderSize = 0
        btnGuardar.FlatStyle = FlatStyle.Flat
        btnGuardar.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold)
        btnGuardar.ForeColor = Color.White
        btnGuardar.Location = New Point(608, 193)
        btnGuardar.Name = "btnGuardar"
        btnGuardar.Size = New Size(72, 36)
        btnGuardar.TabIndex = 5
        btnGuardar.Text = "Guardar"
        btnGuardar.UseVisualStyleBackColor = False
        ' 
        ' btnEliminar
        ' 
        btnEliminar.BackColor = Color.LightCoral
        btnEliminar.FlatAppearance.BorderSize = 0
        btnEliminar.FlatStyle = FlatStyle.Flat
        btnEliminar.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold)
        btnEliminar.ForeColor = Color.White
        btnEliminar.Location = New Point(608, 133)
        btnEliminar.Name = "btnEliminar"
        btnEliminar.Size = New Size(72, 36)
        btnEliminar.TabIndex = 4
        btnEliminar.Text = "Eliminar"
        btnEliminar.UseVisualStyleBackColor = False
        ' 
        ' btnModificar
        ' 
        btnModificar.BackColor = Color.LightCoral
        btnModificar.FlatAppearance.BorderSize = 0
        btnModificar.FlatStyle = FlatStyle.Flat
        btnModificar.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold)
        btnModificar.ForeColor = Color.White
        btnModificar.Location = New Point(608, 77)
        btnModificar.Name = "btnModificar"
        btnModificar.Size = New Size(72, 36)
        btnModificar.TabIndex = 3
        btnModificar.Text = "Modificar"
        btnModificar.UseVisualStyleBackColor = False
        ' 
        ' btnAgregar
        ' 
        btnAgregar.BackColor = Color.LightCoral
        btnAgregar.FlatAppearance.BorderSize = 0
        btnAgregar.FlatStyle = FlatStyle.Flat
        btnAgregar.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold)
        btnAgregar.ForeColor = Color.White
        btnAgregar.Location = New Point(608, 19)
        btnAgregar.Name = "btnAgregar"
        btnAgregar.Size = New Size(72, 36)
        btnAgregar.TabIndex = 2
        btnAgregar.Text = "Agregar"
        btnAgregar.UseVisualStyleBackColor = False
        ' 
        ' PanelLista
        ' 
        PanelLista.BorderStyle = BorderStyle.FixedSingle
        PanelLista.Controls.Add(gbLista)
        PanelLista.Dock = DockStyle.Top
        PanelLista.ForeColor = SystemColors.ControlText
        PanelLista.Location = New Point(0, 362)
        PanelLista.Name = "PanelLista"
        PanelLista.Size = New Size(750, 216)
        PanelLista.TabIndex = 3
        ' 
        ' gbLista
        ' 
        gbLista.Controls.Add(DataGridView1)
        gbLista.FlatStyle = FlatStyle.Flat
        gbLista.Font = New Font("Verdana", 12F, FontStyle.Bold)
        gbLista.ForeColor = Color.FromArgb(CByte(80), CByte(52), CByte(42))
        gbLista.Location = New Point(47, 19)
        gbLista.Name = "gbLista"
        gbLista.Size = New Size(584, 186)
        gbLista.TabIndex = 1
        gbLista.TabStop = False
        gbLista.Text = "Lista de contactos"
        ' 
        ' DataGridView1
        ' 
        DataGridViewCellStyle1.BackColor = Color.FromArgb(CByte(255), CByte(228), CByte(230))
        DataGridViewCellStyle1.ForeColor = Color.Black
        DataGridViewCellStyle1.SelectionBackColor = Color.LightCoral
        DataGridViewCellStyle1.SelectionForeColor = Color.White
        DataGridView1.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        DataGridView1.BackgroundColor = Color.FromArgb(CByte(255), CByte(242), CByte(242))
        DataGridView1.BorderStyle = BorderStyle.None
        DataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal
        DataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single
        DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = Color.FromArgb(CByte(255), CByte(228), CByte(230))
        DataGridViewCellStyle2.Font = New Font("Verdana", 10F)
        DataGridViewCellStyle2.ForeColor = Color.FromArgb(CByte(80), CByte(52), CByte(42))
        DataGridViewCellStyle2.SelectionBackColor = Color.LightCoral
        DataGridViewCellStyle2.SelectionForeColor = Color.White
        DataGridViewCellStyle2.WrapMode = DataGridViewTriState.False
        DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Columns.AddRange(New DataGridViewColumn() {Column1, Column2, Column3, Column4, Column5})
        DataGridView1.Dock = DockStyle.Fill
        DataGridView1.GridColor = Color.FromArgb(CByte(220), CByte(170), CByte(170))
        DataGridView1.Location = New Point(3, 23)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single
        DataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle8.BackColor = Color.FromArgb(CByte(255), CByte(228), CByte(230))
        DataGridViewCellStyle8.Font = New Font("Verdana", 10F)
        DataGridViewCellStyle8.ForeColor = Color.FromArgb(CByte(80), CByte(52), CByte(42))
        DataGridViewCellStyle8.SelectionBackColor = Color.LightCoral
        DataGridViewCellStyle8.SelectionForeColor = Color.White
        DataGridViewCellStyle8.WrapMode = DataGridViewTriState.False
        DataGridView1.RowHeadersDefaultCellStyle = DataGridViewCellStyle8
        DataGridViewCellStyle9.BackColor = Color.FromArgb(CByte(255), CByte(228), CByte(230))
        DataGridViewCellStyle9.Font = New Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle9.ForeColor = Color.FromArgb(CByte(80), CByte(52), CByte(42))
        DataGridViewCellStyle9.SelectionBackColor = Color.LightCoral
        DataGridViewCellStyle9.SelectionForeColor = Color.White
        DataGridViewCellStyle9.WrapMode = DataGridViewTriState.False
        DataGridView1.RowsDefaultCellStyle = DataGridViewCellStyle9
        DataGridView1.Size = New Size(578, 160)
        DataGridView1.TabIndex = 0
        ' 
        ' Column1
        ' 
        DataGridViewCellStyle3.BackColor = Color.FromArgb(CByte(255), CByte(228), CByte(230))
        DataGridViewCellStyle3.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle3.ForeColor = Color.Black
        DataGridViewCellStyle3.SelectionBackColor = Color.LightCoral
        DataGridViewCellStyle3.SelectionForeColor = Color.White
        Column1.DefaultCellStyle = DataGridViewCellStyle3
        Column1.HeaderText = "Nombre"
        Column1.Name = "Column1"
        ' 
        ' Column2
        ' 
        DataGridViewCellStyle4.BackColor = Color.FromArgb(CByte(255), CByte(228), CByte(230))
        DataGridViewCellStyle4.Font = New Font("Segoe UI", 9.75F)
        DataGridViewCellStyle4.ForeColor = Color.Black
        DataGridViewCellStyle4.SelectionBackColor = Color.LightCoral
        DataGridViewCellStyle4.SelectionForeColor = Color.White
        Column2.DefaultCellStyle = DataGridViewCellStyle4
        Column2.HeaderText = "DNI"
        Column2.Name = "Column2"
        ' 
        ' Column3
        ' 
        DataGridViewCellStyle5.BackColor = Color.FromArgb(CByte(255), CByte(228), CByte(230))
        DataGridViewCellStyle5.Font = New Font("Segoe UI", 9.75F)
        DataGridViewCellStyle5.ForeColor = Color.Black
        DataGridViewCellStyle5.SelectionBackColor = Color.LightCoral
        DataGridViewCellStyle5.SelectionForeColor = Color.White
        Column3.DefaultCellStyle = DataGridViewCellStyle5
        Column3.HeaderText = "Teléfono"
        Column3.Name = "Column3"
        ' 
        ' Column4
        ' 
        DataGridViewCellStyle6.BackColor = Color.FromArgb(CByte(255), CByte(228), CByte(230))
        DataGridViewCellStyle6.Font = New Font("Segoe UI", 9.75F)
        DataGridViewCellStyle6.ForeColor = Color.Black
        DataGridViewCellStyle6.SelectionBackColor = Color.LightCoral
        DataGridViewCellStyle6.SelectionForeColor = Color.White
        Column4.DefaultCellStyle = DataGridViewCellStyle6
        Column4.HeaderText = "Dirección"
        Column4.Name = "Column4"
        ' 
        ' Column5
        ' 
        DataGridViewCellStyle7.BackColor = Color.FromArgb(CByte(255), CByte(228), CByte(230))
        DataGridViewCellStyle7.Font = New Font("Segoe UI", 9.75F)
        DataGridViewCellStyle7.ForeColor = Color.Black
        DataGridViewCellStyle7.SelectionBackColor = Color.LightCoral
        DataGridViewCellStyle7.SelectionForeColor = Color.White
        Column5.DefaultCellStyle = DataGridViewCellStyle7
        Column5.HeaderText = "Sexo"
        Column5.Name = "Column5"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(255), CByte(248), CByte(240))
        ClientSize = New Size(750, 579)
        Controls.Add(PanelLista)
        Controls.Add(PanelDatos)
        Controls.Add(PanelTitulo)
        FormBorderStyle = FormBorderStyle.None
        Name = "Form1"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Form1"
        PanelTitulo.ResumeLayout(False)
        PanelTitulo.PerformLayout()
        PanelIcono.ResumeLayout(False)
        CType(pbLogo, ComponentModel.ISupportInitialize).EndInit()
        gbDatos.ResumeLayout(False)
        gbDatos.PerformLayout()
        PanelDatos.ResumeLayout(False)
        PanelLista.ResumeLayout(False)
        gbLista.ResumeLayout(False)
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents PanelTitulo As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents PanelIcono As Panel
    Friend WithEvents pbLogo As PictureBox
    Friend WithEvents gbDatos As GroupBox
    Friend WithEvents PanelDatos As Panel
    Friend WithEvents PanelLista As Panel
    Friend WithEvents gbLista As GroupBox
    Friend WithEvents lblSexo As Label
    Friend WithEvents tbDireccion As TextBox
    Friend WithEvents lblDireccion As Label
    Friend WithEvents tbTelefono As TextBox
    Friend WithEvents lblTelefono As Label
    Friend WithEvents tbDni As TextBox
    Friend WithEvents lblDni As Label
    Friend WithEvents tbNombre As TextBox
    Friend WithEvents lblNombre As Label
    Friend WithEvents btnSalir As Button
    Friend WithEvents btnGuardar As Button
    Friend WithEvents btnEliminar As Button
    Friend WithEvents btnModificar As Button
    Friend WithEvents btnAgregar As Button
    Friend WithEvents cbSexo As ComboBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn

End Class
