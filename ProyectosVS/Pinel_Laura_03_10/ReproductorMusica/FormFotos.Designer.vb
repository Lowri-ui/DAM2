<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormFotos
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
        lblGaleriaFotos = New Label()
        FlowLayoutPanel1 = New FlowLayoutPanel()
        btnAgregarFoto = New Button()
        SuspendLayout()
        ' 
        ' lblGaleriaFotos
        ' 
        lblGaleriaFotos.AutoSize = True
        lblGaleriaFotos.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblGaleriaFotos.ForeColor = Color.WhiteSmoke
        lblGaleriaFotos.Location = New Point(101, 28)
        lblGaleriaFotos.Name = "lblGaleriaFotos"
        lblGaleriaFotos.Size = New Size(122, 21)
        lblGaleriaFotos.TabIndex = 7
        lblGaleriaFotos.Text = "Galeria de Fotos"
        ' 
        ' FlowLayoutPanel1
        ' 
        FlowLayoutPanel1.Location = New Point(101, 74)
        FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        FlowLayoutPanel1.Size = New Size(645, 305)
        FlowLayoutPanel1.TabIndex = 8
        ' 
        ' btnAgregarFoto
        ' 
        btnAgregarFoto.BackColor = Color.FromArgb(CByte(164), CByte(56), CByte(186))
        btnAgregarFoto.FlatAppearance.BorderSize = 0
        btnAgregarFoto.FlatStyle = FlatStyle.Flat
        btnAgregarFoto.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnAgregarFoto.ForeColor = Color.WhiteSmoke
        btnAgregarFoto.Location = New Point(628, 385)
        btnAgregarFoto.Name = "btnAgregarFoto"
        btnAgregarFoto.Size = New Size(118, 38)
        btnAgregarFoto.TabIndex = 11
        btnAgregarFoto.Text = "Agregar Foto"
        btnAgregarFoto.UseVisualStyleBackColor = False
        ' 
        ' FormFotos
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(68), CByte(68), CByte(68))
        ClientSize = New Size(800, 450)
        Controls.Add(btnAgregarFoto)
        Controls.Add(FlowLayoutPanel1)
        Controls.Add(lblGaleriaFotos)
        Name = "FormFotos"
        Text = "FormFotos"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblGaleriaFotos As Label
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents btnAgregarFoto As Button
End Class
