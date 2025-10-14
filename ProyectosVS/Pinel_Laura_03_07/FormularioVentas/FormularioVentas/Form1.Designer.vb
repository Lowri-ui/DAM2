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
        lblNombre = New Label()
        lblTelefono = New Label()
        lblDireccion = New Label()
        lblPedido = New Label()
        lblPedidosLaura = New Label()
        btnLimpiar = New Button()
        btnConfirmar = New Button()
        btnSalir = New Button()
        lblDatosUsuarioPedido = New Label()
        ListBox1 = New ListBox()
        txbNombre = New TextBox()
        txbTelefono = New TextBox()
        txbDireccion = New TextBox()
        txbPedido = New TextBox()
        lblFecha = New Label()
        DateTimePicker1 = New DateTimePicker()
        SuspendLayout()
        ' 
        ' lblNombre
        ' 
        lblNombre.AutoSize = True
        lblNombre.Font = New Font("Verdana", 9F)
        lblNombre.Location = New Point(413, 114)
        lblNombre.Name = "lblNombre"
        lblNombre.Size = New Size(61, 14)
        lblNombre.TabIndex = 0
        lblNombre.Text = "Nombre:"
        ' 
        ' lblTelefono
        ' 
        lblTelefono.AutoSize = True
        lblTelefono.Font = New Font("Verdana", 9F)
        lblTelefono.Location = New Point(413, 176)
        lblTelefono.Name = "lblTelefono"
        lblTelefono.Size = New Size(101, 14)
        lblTelefono.TabIndex = 1
        lblTelefono.Text = "Teléfono móvil:"
        ' 
        ' lblDireccion
        ' 
        lblDireccion.AutoSize = True
        lblDireccion.Font = New Font("Verdana", 9F)
        lblDireccion.Location = New Point(413, 231)
        lblDireccion.Name = "lblDireccion"
        lblDireccion.Size = New Size(68, 14)
        lblDireccion.TabIndex = 2
        lblDireccion.Text = "Dirección:"
        ' 
        ' lblPedido
        ' 
        lblPedido.AutoSize = True
        lblPedido.Font = New Font("Verdana", 9F)
        lblPedido.Location = New Point(413, 293)
        lblPedido.Name = "lblPedido"
        lblPedido.Size = New Size(55, 14)
        lblPedido.TabIndex = 3
        lblPedido.Text = "Pedido:"
        ' 
        ' lblPedidosLaura
        ' 
        lblPedidosLaura.AutoSize = True
        lblPedidosLaura.Font = New Font("Times New Roman", 24F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblPedidosLaura.ForeColor = Color.White
        lblPedidosLaura.Location = New Point(49, 47)
        lblPedidosLaura.Name = "lblPedidosLaura"
        lblPedidosLaura.Size = New Size(223, 36)
        lblPedidosLaura.TabIndex = 4
        lblPedidosLaura.Text = "Pedidos Laura."
        ' 
        ' btnLimpiar
        ' 
        btnLimpiar.BackColor = SystemColors.GradientActiveCaption
        btnLimpiar.Font = New Font("Verdana", 9F)
        btnLimpiar.Location = New Point(122, 398)
        btnLimpiar.Name = "btnLimpiar"
        btnLimpiar.Size = New Size(81, 32)
        btnLimpiar.TabIndex = 5
        btnLimpiar.Text = "Limpiar"
        btnLimpiar.UseVisualStyleBackColor = False
        ' 
        ' btnConfirmar
        ' 
        btnConfirmar.BackColor = SystemColors.GradientActiveCaption
        btnConfirmar.Font = New Font("Verdana", 9F)
        btnConfirmar.Location = New Point(263, 398)
        btnConfirmar.Name = "btnConfirmar"
        btnConfirmar.Size = New Size(81, 32)
        btnConfirmar.TabIndex = 6
        btnConfirmar.Text = "Confirmar"
        btnConfirmar.UseVisualStyleBackColor = False
        ' 
        ' btnSalir
        ' 
        btnSalir.Anchor = AnchorStyles.Top
        btnSalir.BackColor = SystemColors.Control
        btnSalir.Font = New Font("Verdana", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnSalir.ForeColor = Color.Red
        btnSalir.Location = New Point(688, 445)
        btnSalir.Name = "btnSalir"
        btnSalir.Size = New Size(81, 32)
        btnSalir.TabIndex = 7
        btnSalir.Text = "Salir"
        btnSalir.UseVisualStyleBackColor = False
        ' 
        ' lblDatosUsuarioPedido
        ' 
        lblDatosUsuarioPedido.AutoSize = True
        lblDatosUsuarioPedido.Font = New Font("Verdana", 9.75F, FontStyle.Bold)
        lblDatosUsuarioPedido.Location = New Point(413, 61)
        lblDatosUsuarioPedido.Name = "lblDatosUsuarioPedido"
        lblDatosUsuarioPedido.Size = New Size(206, 16)
        lblDatosUsuarioPedido.TabIndex = 8
        lblDatosUsuarioPedido.Text = "Datos de usuario y compra:"
        ' 
        ' ListBox1
        ' 
        ListBox1.Font = New Font("Verdana", 9F)
        ListBox1.FormattingEnabled = True
        ListBox1.ItemHeight = 14
        ListBox1.Location = New Point(122, 101)
        ListBox1.Name = "ListBox1"
        ListBox1.Size = New Size(222, 270)
        ListBox1.TabIndex = 9
        ' 
        ' txbNombre
        ' 
        txbNombre.Font = New Font("Verdana", 9F)
        txbNombre.Location = New Point(530, 111)
        txbNombre.Name = "txbNombre"
        txbNombre.Size = New Size(188, 22)
        txbNombre.TabIndex = 10
        ' 
        ' txbTelefono
        ' 
        txbTelefono.Font = New Font("Verdana", 9F)
        txbTelefono.Location = New Point(530, 168)
        txbTelefono.Name = "txbTelefono"
        txbTelefono.Size = New Size(188, 22)
        txbTelefono.TabIndex = 11
        ' 
        ' txbDireccion
        ' 
        txbDireccion.Font = New Font("Verdana", 9F)
        txbDireccion.Location = New Point(530, 228)
        txbDireccion.Name = "txbDireccion"
        txbDireccion.Size = New Size(188, 22)
        txbDireccion.TabIndex = 12
        ' 
        ' txbPedido
        ' 
        txbPedido.Font = New Font("Verdana", 9F)
        txbPedido.Location = New Point(530, 290)
        txbPedido.Name = "txbPedido"
        txbPedido.Size = New Size(188, 22)
        txbPedido.TabIndex = 13
        ' 
        ' lblFecha
        ' 
        lblFecha.AutoSize = True
        lblFecha.Font = New Font("Verdana", 9F)
        lblFecha.Location = New Point(414, 349)
        lblFecha.Name = "lblFecha"
        lblFecha.Size = New Size(49, 14)
        lblFecha.TabIndex = 14
        lblFecha.Text = "Fecha:"
        ' 
        ' DateTimePicker1
        ' 
        DateTimePicker1.Font = New Font("Verdana", 9F)
        DateTimePicker1.Location = New Point(530, 349)
        DateTimePicker1.Name = "DateTimePicker1"
        DateTimePicker1.Size = New Size(188, 22)
        DateTimePicker1.TabIndex = 16
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        AutoSizeMode = AutoSizeMode.GrowAndShrink
        BackColor = SystemColors.ActiveCaption
        ClientSize = New Size(795, 489)
        Controls.Add(DateTimePicker1)
        Controls.Add(lblFecha)
        Controls.Add(txbPedido)
        Controls.Add(txbDireccion)
        Controls.Add(txbTelefono)
        Controls.Add(txbNombre)
        Controls.Add(ListBox1)
        Controls.Add(lblDatosUsuarioPedido)
        Controls.Add(btnSalir)
        Controls.Add(btnConfirmar)
        Controls.Add(btnLimpiar)
        Controls.Add(lblPedidosLaura)
        Controls.Add(lblPedido)
        Controls.Add(lblDireccion)
        Controls.Add(lblTelefono)
        Controls.Add(lblNombre)
        Name = "Form1"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblNombre As Label
    Friend WithEvents lblTelefono As Label
    Friend WithEvents lblDireccion As Label
    Friend WithEvents lblPedido As Label
    Friend WithEvents lblPedidosLaura As Label
    Friend WithEvents btnLimpiar As Button
    Friend WithEvents btnConfirmar As Button
    Friend WithEvents btnSalir As Button
    Friend WithEvents lblDatosUsuarioPedido As Label
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents txbNombre As TextBox
    Friend WithEvents txbTelefono As TextBox
    Friend WithEvents txbDireccion As TextBox
    Friend WithEvents txbPedido As TextBox
    Friend WithEvents lblFecha As Label
    Friend WithEvents DateTimePicker1 As DateTimePicker

End Class
