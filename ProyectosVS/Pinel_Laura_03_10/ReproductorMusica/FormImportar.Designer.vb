<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormImportar
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
        lblImportar = New Label()
        btnImportar = New Button()
        lbxImportar = New ListBox()
        SuspendLayout()
        ' 
        ' lblImportar
        ' 
        lblImportar.AutoSize = True
        lblImportar.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblImportar.ForeColor = Color.WhiteSmoke
        lblImportar.Location = New Point(101, 28)
        lblImportar.Name = "lblImportar"
        lblImportar.Size = New Size(71, 21)
        lblImportar.TabIndex = 6
        lblImportar.Text = "Importar"
        ' 
        ' btnImportar
        ' 
        btnImportar.BackColor = Color.FromArgb(CByte(164), CByte(56), CByte(186))
        btnImportar.FlatAppearance.BorderSize = 0
        btnImportar.FlatStyle = FlatStyle.Flat
        btnImportar.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnImportar.ForeColor = Color.WhiteSmoke
        btnImportar.Location = New Point(504, 356)
        btnImportar.Name = "btnImportar"
        btnImportar.Size = New Size(102, 38)
        btnImportar.TabIndex = 10
        btnImportar.Text = "Importar"
        btnImportar.UseVisualStyleBackColor = False
        ' 
        ' lbxImportar
        ' 
        lbxImportar.FormattingEnabled = True
        lbxImportar.ItemHeight = 15
        lbxImportar.Location = New Point(194, 57)
        lbxImportar.Name = "lbxImportar"
        lbxImportar.Size = New Size(412, 259)
        lbxImportar.TabIndex = 9
        ' 
        ' FormImportar
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(68), CByte(68), CByte(68))
        ClientSize = New Size(800, 450)
        Controls.Add(btnImportar)
        Controls.Add(lbxImportar)
        Controls.Add(lblImportar)
        Name = "FormImportar"
        Text = "FormImportar"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblImportar As Label
    Friend WithEvents btnImportar As Button
    Friend WithEvents lbxImportar As ListBox
End Class
