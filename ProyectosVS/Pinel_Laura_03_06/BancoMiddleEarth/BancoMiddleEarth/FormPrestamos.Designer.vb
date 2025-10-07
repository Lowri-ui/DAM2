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
        txbNombre = New TextBox()
        lblDatosPersonales = New Label()
        lblDetallesPrestamo = New Label()
        ComboBox1 = New ComboBox()
        ComboBox2 = New ComboBox()
        ComboBox4 = New ComboBox()
        TextBox1 = New TextBox()
        lblRaza = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        btnConfirmar = New Button()
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
        ' txbNombre
        ' 
        txbNombre.Font = New Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txbNombre.Location = New Point(211, 72)
        txbNombre.Name = "txbNombre"
        txbNombre.Size = New Size(210, 29)
        txbNombre.TabIndex = 1
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
        ' ComboBox1
        ' 
        ComboBox1.FormattingEnabled = True
        ComboBox1.Items.AddRange(New Object() {"Elfo", "Hobbit", "Humano", "Troll", "Orco", "Mago"})
        ComboBox1.Location = New Point(106, 247)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(160, 23)
        ComboBox1.TabIndex = 4
        ' 
        ' ComboBox2
        ' 
        ComboBox2.FormattingEnabled = True
        ComboBox2.Location = New Point(106, 329)
        ComboBox2.Name = "ComboBox2"
        ComboBox2.Size = New Size(160, 23)
        ComboBox2.TabIndex = 5
        ' 
        ' ComboBox4
        ' 
        ComboBox4.FormattingEnabled = True
        ComboBox4.Location = New Point(432, 329)
        ComboBox4.Name = "ComboBox4"
        ComboBox4.Size = New Size(160, 23)
        ComboBox4.TabIndex = 7
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(432, 247)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(160, 23)
        TextBox1.TabIndex = 8
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
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Times New Roman", 11.25F)
        Label2.Location = New Point(106, 304)
        Label2.Name = "Label2"
        Label2.Size = New Size(105, 17)
        Label2.TabIndex = 10
        Label2.Text = "Lugar de Origen"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Times New Roman", 11.25F)
        Label3.Location = New Point(432, 222)
        Label3.Name = "Label3"
        Label3.Size = New Size(125, 17)
        Label3.TabIndex = 11
        Label3.Text = "Monto del préstamo"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Times New Roman", 11.25F)
        Label4.Location = New Point(432, 304)
        Label4.Name = "Label4"
        Label4.Size = New Size(49, 17)
        Label4.TabIndex = 12
        Label4.Text = "Cuotas"
        ' 
        ' btnConfirmar
        ' 
        btnConfirmar.BackColor = Color.Tan
        btnConfirmar.Font = New Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnConfirmar.Location = New Point(292, 404)
        btnConfirmar.Name = "btnConfirmar"
        btnConfirmar.Size = New Size(129, 55)
        btnConfirmar.TabIndex = 13
        btnConfirmar.Text = "Confirmar solicitud"
        btnConfirmar.UseVisualStyleBackColor = False
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
        Controls.Add(btnConfirmar)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(lblRaza)
        Controls.Add(TextBox1)
        Controls.Add(ComboBox4)
        Controls.Add(ComboBox2)
        Controls.Add(ComboBox1)
        Controls.Add(lblDetallesPrestamo)
        Controls.Add(lblDatosPersonales)
        Controls.Add(txbNombre)
        Controls.Add(lblBienvenido)
        Name = "FormPrestamos"
        Text = "FormPréstamos"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblBienvenido As Label
    Friend WithEvents txbNombre As TextBox
    Friend WithEvents lblDatosPersonales As Label
    Friend WithEvents lblDetallesPrestamo As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents ComboBox4 As ComboBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents lblRaza As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents btnConfirmar As Button
    Friend WithEvents btnVolver As Button
End Class
