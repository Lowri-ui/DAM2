<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormClientes
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
        DataGridView1 = New DataGridView()
        lblListadoClientes = New Label()
        lblTotalClientes = New Label()
        PanelTitulo.SuspendLayout()
        PanelLogo.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
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
        PanelTitulo.Size = New Size(800, 67)
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
        ' DataGridView1
        ' 
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(12, 156)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.Size = New Size(776, 219)
        DataGridView1.TabIndex = 2
        ' 
        ' lblListadoClientes
        ' 
        lblListadoClientes.AutoSize = True
        lblListadoClientes.Font = New Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblListadoClientes.ForeColor = Color.White
        lblListadoClientes.Location = New Point(315, 118)
        lblListadoClientes.Name = "lblListadoClientes"
        lblListadoClientes.Size = New Size(160, 23)
        lblListadoClientes.TabIndex = 3
        lblListadoClientes.Text = "Listado de Clientes"
        ' 
        ' lblTotalClientes
        ' 
        lblTotalClientes.AutoSize = True
        lblTotalClientes.BorderStyle = BorderStyle.FixedSingle
        lblTotalClientes.Font = New Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblTotalClientes.ForeColor = Color.White
        lblTotalClientes.Location = New Point(340, 393)
        lblTotalClientes.Name = "lblTotalClientes"
        lblTotalClientes.Size = New Size(119, 25)
        lblTotalClientes.TabIndex = 4
        lblTotalClientes.Text = "Total Clientes"
        ' 
        ' FormClientes
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(28), CByte(36), CByte(48))
        ClientSize = New Size(800, 450)
        Controls.Add(lblTotalClientes)
        Controls.Add(lblListadoClientes)
        Controls.Add(DataGridView1)
        Controls.Add(PanelTitulo)
        Name = "FormClientes"
        Text = "Form1"
        PanelTitulo.ResumeLayout(False)
        PanelTitulo.PerformLayout()
        PanelLogo.ResumeLayout(False)
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents PanelTitulo As Panel
    Friend WithEvents lblTitulo As Label
    Friend WithEvents PanelLogo As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents lblListadoClientes As Label
    Friend WithEvents lblTotalClientes As Label

End Class
