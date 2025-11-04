<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormMultimedia
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
        lblCentroMultimedia = New Label()
        lbxMultimedia = New ListBox()
        btnPause3 = New Button()
        btnPlay3 = New Button()
        btnStop2 = New Button()
        btnBuscar = New Button()
        SuspendLayout()
        ' 
        ' lblCentroMultimedia
        ' 
        lblCentroMultimedia.AutoSize = True
        lblCentroMultimedia.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblCentroMultimedia.ForeColor = Color.WhiteSmoke
        lblCentroMultimedia.Location = New Point(101, 28)
        lblCentroMultimedia.Name = "lblCentroMultimedia"
        lblCentroMultimedia.Size = New Size(140, 21)
        lblCentroMultimedia.TabIndex = 9
        lblCentroMultimedia.Text = "Centro Multimedia"
        ' 
        ' lbxMultimedia
        ' 
        lbxMultimedia.FormattingEnabled = True
        lbxMultimedia.ItemHeight = 15
        lbxMultimedia.Location = New Point(194, 96)
        lbxMultimedia.Name = "lbxMultimedia"
        lbxMultimedia.Size = New Size(412, 259)
        lbxMultimedia.TabIndex = 10
        ' 
        ' btnPause3
        ' 
        btnPause3.BackColor = Color.FromArgb(CByte(28), CByte(28), CByte(28))
        btnPause3.FlatAppearance.BorderSize = 0
        btnPause3.FlatStyle = FlatStyle.Flat
        btnPause3.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnPause3.ForeColor = Color.WhiteSmoke
        btnPause3.Location = New Point(651, 317)
        btnPause3.Name = "btnPause3"
        btnPause3.Size = New Size(102, 38)
        btnPause3.TabIndex = 14
        btnPause3.Text = "Pause"
        btnPause3.UseVisualStyleBackColor = False
        ' 
        ' btnPlay3
        ' 
        btnPlay3.BackColor = Color.FromArgb(CByte(28), CByte(28), CByte(28))
        btnPlay3.FlatAppearance.BorderSize = 0
        btnPlay3.FlatStyle = FlatStyle.Flat
        btnPlay3.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnPlay3.ForeColor = Color.WhiteSmoke
        btnPlay3.Location = New Point(651, 273)
        btnPlay3.Name = "btnPlay3"
        btnPlay3.Size = New Size(102, 38)
        btnPlay3.TabIndex = 13
        btnPlay3.Text = "Play"
        btnPlay3.UseVisualStyleBackColor = False
        ' 
        ' btnStop2
        ' 
        btnStop2.BackColor = Color.FromArgb(CByte(28), CByte(28), CByte(28))
        btnStop2.FlatAppearance.BorderSize = 0
        btnStop2.FlatStyle = FlatStyle.Flat
        btnStop2.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnStop2.ForeColor = Color.WhiteSmoke
        btnStop2.Location = New Point(651, 229)
        btnStop2.Name = "btnStop2"
        btnStop2.Size = New Size(102, 38)
        btnStop2.TabIndex = 12
        btnStop2.Text = "Stop"
        btnStop2.UseVisualStyleBackColor = False
        ' 
        ' btnBuscar
        ' 
        btnBuscar.BackColor = Color.FromArgb(CByte(164), CByte(56), CByte(186))
        btnBuscar.FlatAppearance.BorderSize = 0
        btnBuscar.FlatStyle = FlatStyle.Flat
        btnBuscar.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnBuscar.ForeColor = Color.WhiteSmoke
        btnBuscar.Location = New Point(651, 96)
        btnBuscar.Name = "btnBuscar"
        btnBuscar.Size = New Size(102, 38)
        btnBuscar.TabIndex = 11
        btnBuscar.Text = "Reproducir"
        btnBuscar.UseVisualStyleBackColor = False
        ' 
        ' FormMultimedia
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(68), CByte(68), CByte(68))
        ClientSize = New Size(800, 450)
        Controls.Add(btnPause3)
        Controls.Add(btnPlay3)
        Controls.Add(btnStop2)
        Controls.Add(btnBuscar)
        Controls.Add(lbxMultimedia)
        Controls.Add(lblCentroMultimedia)
        Name = "FormMultimedia"
        Text = "FormMultimedia"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblCentroMultimedia As Label
    Friend WithEvents lbxMultimedia As ListBox
    Friend WithEvents btnPause3 As Button
    Friend WithEvents btnPlay3 As Button
    Friend WithEvents btnStop2 As Button
    Friend WithEvents btnBuscar As Button
End Class
