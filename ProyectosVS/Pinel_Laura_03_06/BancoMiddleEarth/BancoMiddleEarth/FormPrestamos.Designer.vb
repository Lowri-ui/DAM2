<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormPrestamos
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
        lblBienvenido = New Label()
        txbNombreUsuario = New TextBox()
        lblDatosPersonales = New Label()
        lblDetallesPrestamo = New Label()
        cbRaza = New ComboBox()
        cbLugarOrigen = New ComboBox()
        cbCuotas = New ComboBox()
        txbMonto = New TextBox()
        lblRaza = New Label()
        lblLugarOrigen = New Label()
        lblMonto = New Label()
        lblCuotas = New Label()
        btnConfirmarSolicitud = New Button()
        btnVolver = New Button()
        SuspendLayout()
        ' 
        ' lblBienvenido
        ' 
        lblBienvenido.AutoSize = True
        lblBienvenido.Font = New Font("Times New Roman", 18F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblBienvenido.Location = New Point(69, 73)
        lblBienvenido.Name = "lblBienvenido"
        lblBienvenido.Size = New Size(144, 27)
        lblBienvenido.TabIndex = 0
        lblBienvenido.Text = "Bienvenid@, "
        ' 
        ' txbNombreUsuario
        ' 
        txbNombreUsuario.Font = New Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txbNombreUsuario.Location = New Point(211, 72)
        txbNombreUsuario.Name = "txbNombreUsuario"
        txbNombreUsuario.Size = New Size(210, 29)
        txbNombreUsuario.TabIndex = 1
        ' 
        ' lblDatosPersonales
        ' 
        lblDatosPersonales.AutoSize = True
        lblDatosPersonales.Font = New Font("Times New Roman", 14.25F, FontStyle.Bold)
        lblDatosPersonales.Location = New Point(106, 161)
        lblDatosPersonales.Name = "lblDatosPersonales"
        lblDatosPersonales.Size = New Size(152, 22)
        lblDatosPersonales.TabIndex = 2
        lblDatosPersonales.Text = "Datos Personales"
        ' 
        ' lblDetallesPrestamo
        ' 
        lblDetallesPrestamo.AutoSize = True
        lblDetallesPrestamo.Font = New Font("Times New Roman", 14.25F, FontStyle.Bold)
        lblDetallesPrestamo.Location = New Point(432, 161)
        lblDetallesPrestamo.Name = "lblDetallesPrestamo"
        lblDetallesPrestamo.Size = New Size(186, 22)
        lblDetallesPrestamo.TabIndex = 3
        lblDetallesPrestamo.Text = "Detalles del préstamo"
        ' 
        ' cbRaza
        ' 
        cbRaza.FormattingEnabled = True
        cbRaza.Items.AddRange(New Object() {"Elfo", "Hobbit", "Humano", "Troll", "Orco", "Mago"})
        cbRaza.Location = New Point(106, 247)
        cbRaza.Name = "cbRaza"
        cbRaza.Size = New Size(160, 23)
        cbRaza.TabIndex = 4
        ' 
        ' cbLugarOrigen
        ' 
        cbLugarOrigen.FormattingEnabled = True
        cbLugarOrigen.Items.AddRange(New Object() {"Ciudad del Valle", "Rivendell", "Rohan", "Hobbiton", "La Montaña Solitaria", "Mordor"})
        cbLugarOrigen.Location = New Point(106, 329)
        cbLugarOrigen.Name = "cbLugarOrigen"
        cbLugarOrigen.Size = New Size(160, 23)
        cbLugarOrigen.TabIndex = 5
        ' 
        ' cbCuotas
        ' 
        cbCuotas.FormattingEnabled = True
        cbCuotas.Items.AddRange(New Object() {"3", "6", "12", "18", "24"})
        cbCuotas.Location = New Point(432, 329)
        cbCuotas.Name = "cbCuotas"
        cbCuotas.Size = New Size(160, 23)
        cbCuotas.TabIndex = 7
        ' 
        ' txbMonto
        ' 
        txbMonto.Location = New Point(432, 247)
        txbMonto.Name = "txbMonto"
        txbMonto.Size = New Size(160, 23)
        txbMonto.TabIndex = 8
        ' 
        ' lblRaza
        ' 
        lblRaza.AutoSize = True
        lblRaza.Font = New Font("Times New Roman", 11.25F)
        lblRaza.Location = New Point(106, 222)
        lblRaza.Name = "lblRaza"
        lblRaza.Size = New Size(38, 17)
        lblRaza.TabIndex = 9
        lblRaza.Text = "Raza"
        ' 
        ' lblLugarOrigen
        ' 
        lblLugarOrigen.AutoSize = True
        lblLugarOrigen.Font = New Font("Times New Roman", 11.25F)
        lblLugarOrigen.Location = New Point(106, 304)
        lblLugarOrigen.Name = "lblLugarOrigen"
        lblLugarOrigen.Size = New Size(105, 17)
        lblLugarOrigen.TabIndex = 10
        lblLugarOrigen.Text = "Lugar de Origen"
        ' 
        ' lblMonto
        ' 
        lblMonto.AutoSize = True
        lblMonto.Font = New Font("Times New Roman", 11.25F)
        lblMonto.Location = New Point(432, 222)
        lblMonto.Name = "lblMonto"
        lblMonto.Size = New Size(125, 17)
        lblMonto.TabIndex = 11
        lblMonto.Text = "Monto del préstamo"
        ' 
        ' lblCuotas
        ' 
        lblCuotas.AutoSize = True
        lblCuotas.Font = New Font("Times New Roman", 11.25F)
        lblCuotas.Location = New Point(432, 304)
        lblCuotas.Name = "lblCuotas"
        lblCuotas.Size = New Size(49, 17)
        lblCuotas.TabIndex = 12
        lblCuotas.Text = "Cuotas"
        ' 
        ' btnConfirmarSolicitud
        ' 
        btnConfirmarSolicitud.BackColor = Color.Tan
        btnConfirmarSolicitud.Font = New Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnConfirmarSolicitud.Location = New Point(292, 404)
        btnConfirmarSolicitud.Name = "btnConfirmarSolicitud"
        btnConfirmarSolicitud.Size = New Size(129, 55)
        btnConfirmarSolicitud.TabIndex = 13
        btnConfirmarSolicitud.Text = "Confirmar solicitud"
        btnConfirmarSolicitud.UseVisualStyleBackColor = False
        ' 
        ' btnVolver
        ' 
        btnVolver.BackColor = Color.Coral
        btnVolver.Font = New Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnVolver.ForeColor = Color.White
        btnVolver.Location = New Point(601, 440)
        btnVolver.Name = "btnVolver"
        btnVolver.Size = New Size(90, 44)
        btnVolver.TabIndex = 15
        btnVolver.Text = "Volver"
        btnVolver.UseVisualStyleBackColor = False
        ' 
        ' FormPrestamos
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.BlanchedAlmond
        ClientSize = New Size(703, 496)
        Controls.Add(btnVolver)
        Controls.Add(btnConfirmarSolicitud)
        Controls.Add(lblCuotas)
        Controls.Add(lblMonto)
        Controls.Add(lblLugarOrigen)
        Controls.Add(lblRaza)
        Controls.Add(txbMonto)
        Controls.Add(cbCuotas)
        Controls.Add(cbLugarOrigen)
        Controls.Add(cbRaza)
        Controls.Add(lblDetallesPrestamo)
        Controls.Add(lblDatosPersonales)
        Controls.Add(txbNombreUsuario)
        Controls.Add(lblBienvenido)
        Name = "FormPrestamos"
        Text = "FormPréstamos"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblBienvenido As Label
    Friend WithEvents txbNombreUsuario As TextBox
    Friend WithEvents lblDatosPersonales As Label
    Friend WithEvents lblDetallesPrestamo As Label
    Friend WithEvents cbRaza As ComboBox
    Friend WithEvents cbLugarOrigen As ComboBox
    Friend WithEvents cbCuotas As ComboBox
    Friend WithEvents txbMonto As TextBox
    Friend WithEvents lblRaza As Label
    Friend WithEvents lblLugarOrigen As Label
    Friend WithEvents lblMonto As Label
    Friend WithEvents lblCuotas As Label
    Friend WithEvents btnConfirmarSolicitud As Button
    Friend WithEvents btnVolver As Button
End Class
