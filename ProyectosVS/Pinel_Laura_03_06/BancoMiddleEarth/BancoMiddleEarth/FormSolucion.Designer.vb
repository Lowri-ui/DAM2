<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormSolucion
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
        txbCuotaTotal = New TextBox()
        lblCuota = New Label()
        btnSalir2 = New Button()
        btnVolver2 = New Button()
        SuspendLayout()
        ' 
        ' txbCuotaTotal
        ' 
        txbCuotaTotal.Font = New Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txbCuotaTotal.Location = New Point(245, 241)
        txbCuotaTotal.Name = "txbCuotaTotal"
        txbCuotaTotal.Size = New Size(210, 29)
        txbCuotaTotal.TabIndex = 3
        ' 
        ' lblCuota
        ' 
        lblCuota.AutoSize = True
        lblCuota.Font = New Font("Times New Roman", 18F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblCuota.Location = New Point(274, 176)
        lblCuota.Name = "lblCuota"
        lblCuota.Size = New Size(127, 27)
        lblCuota.TabIndex = 2
        lblCuota.Text = "Su cuota es:"
        ' 
        ' btnSalir2
        ' 
        btnSalir2.BackColor = Color.Coral
        btnSalir2.Font = New Font("Times New Roman", 12F, FontStyle.Bold)
        btnSalir2.ForeColor = Color.White
        btnSalir2.Location = New Point(601, 440)
        btnSalir2.Name = "btnSalir2"
        btnSalir2.Size = New Size(90, 44)
        btnSalir2.TabIndex = 16
        btnSalir2.Text = "Salir"
        btnSalir2.UseVisualStyleBackColor = False
        ' 
        ' btnVolver2
        ' 
        btnVolver2.BackColor = Color.Coral
        btnVolver2.Font = New Font("Times New Roman", 12F, FontStyle.Bold)
        btnVolver2.ForeColor = Color.White
        btnVolver2.Location = New Point(32, 440)
        btnVolver2.Name = "btnVolver2"
        btnVolver2.Size = New Size(90, 44)
        btnVolver2.TabIndex = 17
        btnVolver2.Text = "Volver"
        btnVolver2.UseVisualStyleBackColor = False
        ' 
        ' FormSolucion
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.BlanchedAlmond
        ClientSize = New Size(703, 496)
        Controls.Add(btnVolver2)
        Controls.Add(btnSalir2)
        Controls.Add(txbCuotaTotal)
        Controls.Add(lblCuota)
        Name = "FormSolucion"
        Text = "FormSolucion"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents txbCuotaTotal As TextBox
    Friend WithEvents lblCuota As Label
    Friend WithEvents btnSalir2 As Button
    Friend WithEvents btnVolver2 As Button
End Class
