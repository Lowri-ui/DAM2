<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormGuardar
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
        lblGuardar = New Label()
        lbxGuardar = New ListBox()
        btnAbrir = New Button()
        btnGuardar = New Button()
        SuspendLayout()
        ' 
        ' lblGuardar
        ' 
        lblGuardar.AutoSize = True
        lblGuardar.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblGuardar.ForeColor = Color.WhiteSmoke
        lblGuardar.Location = New Point(101, 28)
        lblGuardar.Name = "lblGuardar"
        lblGuardar.Size = New Size(67, 21)
        lblGuardar.TabIndex = 5
        lblGuardar.Text = "Guardar"
        ' 
        ' lbxGuardar
        ' 
        lbxGuardar.FormattingEnabled = True
        lbxGuardar.ItemHeight = 15
        lbxGuardar.Location = New Point(202, 43)
        lbxGuardar.Name = "lbxGuardar"
        lbxGuardar.Size = New Size(412, 259)
        lbxGuardar.TabIndex = 6
        ' 
        ' btnAbrir
        ' 
        btnAbrir.BackColor = Color.FromArgb(CByte(164), CByte(56), CByte(186))
        btnAbrir.FlatAppearance.BorderSize = 0
        btnAbrir.FlatStyle = FlatStyle.Flat
        btnAbrir.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnAbrir.ForeColor = Color.WhiteSmoke
        btnAbrir.Location = New Point(202, 342)
        btnAbrir.Name = "btnAbrir"
        btnAbrir.Size = New Size(102, 38)
        btnAbrir.TabIndex = 7
        btnAbrir.Text = "Abrir"
        btnAbrir.UseVisualStyleBackColor = False
        ' 
        ' btnGuardar
        ' 
        btnGuardar.BackColor = Color.FromArgb(CByte(164), CByte(56), CByte(186))
        btnGuardar.FlatAppearance.BorderSize = 0
        btnGuardar.FlatStyle = FlatStyle.Flat
        btnGuardar.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnGuardar.ForeColor = Color.WhiteSmoke
        btnGuardar.Location = New Point(512, 342)
        btnGuardar.Name = "btnGuardar"
        btnGuardar.Size = New Size(102, 38)
        btnGuardar.TabIndex = 8
        btnGuardar.Text = "Guardar"
        btnGuardar.UseVisualStyleBackColor = False
        ' 
        ' FormGuardar
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(68), CByte(68), CByte(68))
        ClientSize = New Size(800, 450)
        Controls.Add(btnGuardar)
        Controls.Add(btnAbrir)
        Controls.Add(lbxGuardar)
        Controls.Add(lblGuardar)
        Name = "FormGuardar"
        Text = "FormGuardar"
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents lblGuardar As Label
    Friend WithEvents lbxGuardar As ListBox
    Friend WithEvents btnAbrir As Button
    Friend WithEvents btnGuardar As Button
End Class
