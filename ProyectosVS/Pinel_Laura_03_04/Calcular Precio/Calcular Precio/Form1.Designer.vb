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
        txtPrecioSinIva = New TextBox()
        txtPrecioConIva = New TextBox()
        txtDescuento = New TextBox()
        txtTotal = New TextBox()
        chbIva = New CheckBox()
        chbDescuento = New CheckBox()
        btnGenerar = New Button()
        btnLimpiar = New Button()
        btnSalir = New Button()
        lblSinIva = New Label()
        lblConIva = New Label()
        lblDescuento = New Label()
        lblTotal = New Label()
        SuspendLayout()
        ' 
        ' txtPrecioSinIva
        ' 
        txtPrecioSinIva.Location = New Point(231, 60)
        txtPrecioSinIva.Name = "txtPrecioSinIva"
        txtPrecioSinIva.Size = New Size(110, 23)
        txtPrecioSinIva.TabIndex = 0
        ' 
        ' txtPrecioConIva
        ' 
        txtPrecioConIva.Location = New Point(231, 139)
        txtPrecioConIva.Name = "txtPrecioConIva"
        txtPrecioConIva.Size = New Size(110, 23)
        txtPrecioConIva.TabIndex = 1
        ' 
        ' txtDescuento
        ' 
        txtDescuento.Location = New Point(231, 231)
        txtDescuento.Name = "txtDescuento"
        txtDescuento.Size = New Size(110, 23)
        txtDescuento.TabIndex = 2
        ' 
        ' txtTotal
        ' 
        txtTotal.Location = New Point(231, 317)
        txtTotal.Name = "txtTotal"
        txtTotal.Size = New Size(110, 23)
        txtTotal.TabIndex = 3
        ' 
        ' chbIva
        ' 
        chbIva.AutoSize = True
        chbIva.BackColor = Color.Transparent
        chbIva.Font = New Font("Verdana", 9F)
        chbIva.Location = New Point(454, 147)
        chbIva.Name = "chbIva"
        chbIva.Size = New Size(115, 18)
        chbIva.TabIndex = 4
        chbIva.Text = "Precio con IVA"
        chbIva.UseVisualStyleBackColor = False
        ' 
        ' chbDescuento
        ' 
        chbDescuento.AutoSize = True
        chbDescuento.BackColor = Color.Transparent
        chbDescuento.Font = New Font("Verdana", 9F)
        chbDescuento.Location = New Point(454, 200)
        chbDescuento.Name = "chbDescuento"
        chbDescuento.Size = New Size(93, 18)
        chbDescuento.TabIndex = 5
        chbDescuento.Text = "Descuento"
        chbDescuento.UseVisualStyleBackColor = False
        ' 
        ' btnGenerar
        ' 
        btnGenerar.Font = New Font("Verdana", 9F, FontStyle.Bold)
        btnGenerar.Location = New Point(454, 267)
        btnGenerar.Name = "btnGenerar"
        btnGenerar.Size = New Size(97, 31)
        btnGenerar.TabIndex = 6
        btnGenerar.Text = "Generar"
        btnGenerar.UseVisualStyleBackColor = True
        ' 
        ' btnLimpiar
        ' 
        btnLimpiar.Font = New Font("Verdana", 9F, FontStyle.Bold)
        btnLimpiar.Location = New Point(583, 267)
        btnLimpiar.Name = "btnLimpiar"
        btnLimpiar.Size = New Size(97, 31)
        btnLimpiar.TabIndex = 7
        btnLimpiar.Text = "Limpiar"
        btnLimpiar.UseVisualStyleBackColor = True
        ' 
        ' btnSalir
        ' 
        btnSalir.BackColor = Color.Sienna
        btnSalir.Font = New Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnSalir.ForeColor = Color.Snow
        btnSalir.Location = New Point(681, 398)
        btnSalir.Name = "btnSalir"
        btnSalir.Size = New Size(97, 31)
        btnSalir.TabIndex = 8
        btnSalir.Text = "Salir"
        btnSalir.UseVisualStyleBackColor = False
        ' 
        ' lblSinIva
        ' 
        lblSinIva.AutoSize = True
        lblSinIva.BackColor = Color.PeachPuff
        lblSinIva.Font = New Font("Verdana", 9.75F, FontStyle.Bold)
        lblSinIva.ForeColor = Color.Black
        lblSinIva.Location = New Point(95, 62)
        lblSinIva.Name = "lblSinIva"
        lblSinIva.Size = New Size(108, 16)
        lblSinIva.TabIndex = 9
        lblSinIva.Text = "Precio Sin IVA"
        ' 
        ' lblConIva
        ' 
        lblConIva.AutoSize = True
        lblConIva.BackColor = Color.PeachPuff
        lblConIva.Font = New Font("Verdana", 9.75F, FontStyle.Bold)
        lblConIva.ForeColor = Color.Black
        lblConIva.Location = New Point(95, 141)
        lblConIva.Name = "lblConIva"
        lblConIva.Size = New Size(114, 16)
        lblConIva.TabIndex = 10
        lblConIva.Text = "Precio Con IVA"
        ' 
        ' lblDescuento
        ' 
        lblDescuento.AutoSize = True
        lblDescuento.BackColor = Color.PeachPuff
        lblDescuento.Font = New Font("Verdana", 9.75F, FontStyle.Bold)
        lblDescuento.ForeColor = Color.Black
        lblDescuento.Location = New Point(95, 233)
        lblDescuento.Name = "lblDescuento"
        lblDescuento.Size = New Size(84, 16)
        lblDescuento.TabIndex = 11
        lblDescuento.Text = "Descuento"
        ' 
        ' lblTotal
        ' 
        lblTotal.AutoSize = True
        lblTotal.BackColor = Color.PeachPuff
        lblTotal.Font = New Font("Verdana", 9.75F, FontStyle.Bold)
        lblTotal.ForeColor = Color.Black
        lblTotal.Location = New Point(95, 319)
        lblTotal.Name = "lblTotal"
        lblTotal.Size = New Size(102, 16)
        lblTotal.TabIndex = 12
        lblTotal.Text = "Total a Pagar"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = My.Resources.Resources.fondo
        ClientSize = New Size(800, 450)
        Controls.Add(lblTotal)
        Controls.Add(lblDescuento)
        Controls.Add(lblConIva)
        Controls.Add(lblSinIva)
        Controls.Add(btnSalir)
        Controls.Add(btnLimpiar)
        Controls.Add(btnGenerar)
        Controls.Add(chbDescuento)
        Controls.Add(chbIva)
        Controls.Add(txtTotal)
        Controls.Add(txtDescuento)
        Controls.Add(txtPrecioConIva)
        Controls.Add(txtPrecioSinIva)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents txtPrecioSinIva As TextBox
    Friend WithEvents txtPrecioConIva As TextBox
    Friend WithEvents txtDescuento As TextBox
    Friend WithEvents txtTotal As TextBox
    Friend WithEvents chbIva As CheckBox
    Friend WithEvents chbDescuento As CheckBox
    Friend WithEvents btnGenerar As Button
    Friend WithEvents btnLimpiar As Button
    Friend WithEvents btnSalir As Button
    Friend WithEvents lblSinIva As Label
    Friend WithEvents lblConIva As Label
    Friend WithEvents lblDescuento As Label
    Friend WithEvents lblTotal As Label

End Class
