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
        btnMouseEnter = New Button()
        btnMouseDown = New Button()
        btnMouseHover = New Button()
        btnMouseUP = New Button()
        btnMouseMove = New Button()
        btnMouseWheel = New Button()
        btnKeyPress = New Button()
        btnInicio = New Button()
        btnMouseLeave = New Button()
        SuspendLayout()
        ' 
        ' btnMouseEnter
        ' 
        btnMouseEnter.Font = New Font("Imprint MT Shadow", 9.75F)
        btnMouseEnter.Location = New Point(49, 46)
        btnMouseEnter.Name = "btnMouseEnter"
        btnMouseEnter.Size = New Size(131, 64)
        btnMouseEnter.TabIndex = 0
        btnMouseEnter.Text = "MouseEnter"
        btnMouseEnter.UseVisualStyleBackColor = True
        ' 
        ' btnMouseDown
        ' 
        btnMouseDown.Font = New Font("Imprint MT Shadow", 9.75F)
        btnMouseDown.Location = New Point(248, 46)
        btnMouseDown.Name = "btnMouseDown"
        btnMouseDown.Size = New Size(131, 64)
        btnMouseDown.TabIndex = 1
        btnMouseDown.Text = "MouseDown"
        btnMouseDown.UseVisualStyleBackColor = True
        ' 
        ' btnMouseHover
        ' 
        btnMouseHover.Font = New Font("Imprint MT Shadow", 9.75F)
        btnMouseHover.Location = New Point(439, 46)
        btnMouseHover.Name = "btnMouseHover"
        btnMouseHover.Size = New Size(131, 64)
        btnMouseHover.TabIndex = 2
        btnMouseHover.Text = "Mouse Hover"
        btnMouseHover.UseVisualStyleBackColor = True
        ' 
        ' btnMouseUP
        ' 
        btnMouseUP.Font = New Font("Imprint MT Shadow", 9.75F)
        btnMouseUP.Location = New Point(49, 183)
        btnMouseUP.Name = "btnMouseUP"
        btnMouseUP.Size = New Size(131, 64)
        btnMouseUP.TabIndex = 3
        btnMouseUP.Text = "MouseUP"
        btnMouseUP.UseVisualStyleBackColor = True
        ' 
        ' btnMouseMove
        ' 
        btnMouseMove.Font = New Font("Imprint MT Shadow", 9.75F)
        btnMouseMove.Location = New Point(248, 183)
        btnMouseMove.Name = "btnMouseMove"
        btnMouseMove.Size = New Size(131, 64)
        btnMouseMove.TabIndex = 4
        btnMouseMove.Text = "MouseMove"
        btnMouseMove.UseVisualStyleBackColor = True
        ' 
        ' btnMouseWheel
        ' 
        btnMouseWheel.Font = New Font("Imprint MT Shadow", 9.75F)
        btnMouseWheel.Location = New Point(49, 323)
        btnMouseWheel.Name = "btnMouseWheel"
        btnMouseWheel.Size = New Size(131, 64)
        btnMouseWheel.TabIndex = 5
        btnMouseWheel.Text = "Mouse Wheel"
        btnMouseWheel.UseVisualStyleBackColor = True
        ' 
        ' btnKeyPress
        ' 
        btnKeyPress.Font = New Font("Imprint MT Shadow", 9.75F)
        btnKeyPress.Location = New Point(248, 323)
        btnKeyPress.Name = "btnKeyPress"
        btnKeyPress.Size = New Size(131, 64)
        btnKeyPress.TabIndex = 6
        btnKeyPress.Text = "KeyPress"
        btnKeyPress.UseVisualStyleBackColor = True
        ' 
        ' btnInicio
        ' 
        btnInicio.Font = New Font("Imprint MT Shadow", 9.75F)
        btnInicio.Location = New Point(439, 323)
        btnInicio.Name = "btnInicio"
        btnInicio.Size = New Size(131, 64)
        btnInicio.TabIndex = 7
        btnInicio.Text = "Ir a Inicio"
        btnInicio.UseVisualStyleBackColor = True
        ' 
        ' btnMouseLeave
        ' 
        btnMouseLeave.Font = New Font("Imprint MT Shadow", 9.75F)
        btnMouseLeave.Location = New Point(439, 183)
        btnMouseLeave.Name = "btnMouseLeave"
        btnMouseLeave.Size = New Size(131, 64)
        btnMouseLeave.TabIndex = 8
        btnMouseLeave.Text = "MouseLeave"
        btnMouseLeave.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ActiveCaption
        ClientSize = New Size(628, 450)
        Controls.Add(btnMouseLeave)
        Controls.Add(btnInicio)
        Controls.Add(btnKeyPress)
        Controls.Add(btnMouseWheel)
        Controls.Add(btnMouseMove)
        Controls.Add(btnMouseUP)
        Controls.Add(btnMouseHover)
        Controls.Add(btnMouseDown)
        Controls.Add(btnMouseEnter)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
    End Sub

    Friend WithEvents btnMouseEnter As Button
    Friend WithEvents btnMouseDown As Button
    Friend WithEvents btnMouseHover As Button
    Friend WithEvents btnMouseUP As Button
    Friend WithEvents btnMouseMove As Button
    Friend WithEvents btnMouseWheel As Button
    Friend WithEvents btnKeyPress As Button
    Friend WithEvents btnInicio As Button
    Friend WithEvents btnMouseLeave As Button

End Class
