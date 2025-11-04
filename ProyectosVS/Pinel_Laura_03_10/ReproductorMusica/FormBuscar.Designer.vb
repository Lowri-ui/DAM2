<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormBuscar
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
        lblBuscar = New Label()
        TextBox1 = New TextBox()
        btnBuscar = New Button()
        lbxBuscar = New ListBox()
        btnStop = New Button()
        btnPlay = New Button()
        btnPause = New Button()
        SuspendLayout()
        ' 
        ' lblBuscar
        ' 
        lblBuscar.AutoSize = True
        lblBuscar.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblBuscar.ForeColor = Color.WhiteSmoke
        lblBuscar.Location = New Point(101, 28)
        lblBuscar.Name = "lblBuscar"
        lblBuscar.Size = New Size(170, 21)
        lblBuscar.TabIndex = 0
        lblBuscar.Text = "Buscar Archivo o Video"
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(293, 28)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(436, 23)
        TextBox1.TabIndex = 1
        ' 
        ' btnBuscar
        ' 
        btnBuscar.BackColor = Color.FromArgb(CByte(164), CByte(56), CByte(186))
        btnBuscar.FlatAppearance.BorderSize = 0
        btnBuscar.FlatStyle = FlatStyle.Flat
        btnBuscar.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnBuscar.ForeColor = Color.WhiteSmoke
        btnBuscar.Location = New Point(627, 80)
        btnBuscar.Name = "btnBuscar"
        btnBuscar.Size = New Size(102, 38)
        btnBuscar.TabIndex = 2
        btnBuscar.Text = "Buscar"
        btnBuscar.UseVisualStyleBackColor = False
        ' 
        ' lbxBuscar
        ' 
        lbxBuscar.FormattingEnabled = True
        lbxBuscar.ItemHeight = 15
        lbxBuscar.Location = New Point(101, 80)
        lbxBuscar.Name = "lbxBuscar"
        lbxBuscar.Size = New Size(480, 319)
        lbxBuscar.TabIndex = 3
        ' 
        ' btnStop
        ' 
        btnStop.BackColor = Color.FromArgb(CByte(28), CByte(28), CByte(28))
        btnStop.FlatAppearance.BorderSize = 0
        btnStop.FlatStyle = FlatStyle.Flat
        btnStop.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnStop.ForeColor = Color.WhiteSmoke
        btnStop.Location = New Point(627, 273)
        btnStop.Name = "btnStop"
        btnStop.Size = New Size(102, 38)
        btnStop.TabIndex = 4
        btnStop.Text = "Stop"
        btnStop.UseVisualStyleBackColor = False
        ' 
        ' btnPlay
        ' 
        btnPlay.BackColor = Color.FromArgb(CByte(28), CByte(28), CByte(28))
        btnPlay.FlatAppearance.BorderSize = 0
        btnPlay.FlatStyle = FlatStyle.Flat
        btnPlay.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnPlay.ForeColor = Color.WhiteSmoke
        btnPlay.Location = New Point(627, 317)
        btnPlay.Name = "btnPlay"
        btnPlay.Size = New Size(102, 38)
        btnPlay.TabIndex = 5
        btnPlay.Text = "Play"
        btnPlay.UseVisualStyleBackColor = False
        ' 
        ' btnPause
        ' 
        btnPause.BackColor = Color.FromArgb(CByte(28), CByte(28), CByte(28))
        btnPause.FlatAppearance.BorderSize = 0
        btnPause.FlatStyle = FlatStyle.Flat
        btnPause.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnPause.ForeColor = Color.WhiteSmoke
        btnPause.Location = New Point(627, 361)
        btnPause.Name = "btnPause"
        btnPause.Size = New Size(102, 38)
        btnPause.TabIndex = 6
        btnPause.Text = "Pause"
        btnPause.UseVisualStyleBackColor = False
        ' 
        ' FormBuscar
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(68), CByte(68), CByte(68))
        ClientSize = New Size(800, 450)
        Controls.Add(btnPause)
        Controls.Add(btnPlay)
        Controls.Add(btnStop)
        Controls.Add(lbxBuscar)
        Controls.Add(btnBuscar)
        Controls.Add(TextBox1)
        Controls.Add(lblBuscar)
        Name = "FormBuscar"
        Text = "FormBuscar"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblBuscar As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents btnBuscar As Button
    Friend WithEvents lbxBuscar As ListBox
    Friend WithEvents btnStop As Button
    Friend WithEvents btnPlay As Button
    Friend WithEvents btnPause As Button
End Class
