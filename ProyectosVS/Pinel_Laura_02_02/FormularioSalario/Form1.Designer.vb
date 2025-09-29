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
        gbClase = New GroupBox()
        rbProfesional = New RadioButton()
        rbTecnico = New RadioButton()
        rbAdministrativo = New RadioButton()
        rbObrero = New RadioButton()
        gbSindicato = New GroupBox()
        rbNo = New RadioButton()
        rbSi = New RadioButton()
        gbAños = New GroupBox()
        rbMas = New RadioButton()
        rbEntre = New RadioButton()
        rbMenos = New RadioButton()
        lblHijos = New Label()
        nudHijos = New NumericUpDown()
        btnCalcular = New Button()
        btnLimpiar = New Button()
        btnSalir = New Button()
        gbClase.SuspendLayout()
        gbSindicato.SuspendLayout()
        gbAños.SuspendLayout()
        CType(nudHijos, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' gbClase
        ' 
        gbClase.BackColor = SystemColors.GradientActiveCaption
        gbClase.Controls.Add(rbProfesional)
        gbClase.Controls.Add(rbTecnico)
        gbClase.Controls.Add(rbAdministrativo)
        gbClase.Controls.Add(rbObrero)
        gbClase.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold)
        gbClase.Location = New Point(70, 78)
        gbClase.Name = "gbClase"
        gbClase.Size = New Size(164, 172)
        gbClase.TabIndex = 0
        gbClase.TabStop = False
        gbClase.Text = "Clase de Trabajador"
        ' 
        ' rbProfesional
        ' 
        rbProfesional.AutoSize = True
        rbProfesional.Location = New Point(13, 111)
        rbProfesional.Name = "rbProfesional"
        rbProfesional.Size = New Size(93, 21)
        rbProfesional.TabIndex = 3
        rbProfesional.TabStop = True
        rbProfesional.Text = "Profesional"
        rbProfesional.UseVisualStyleBackColor = True
        ' 
        ' rbTecnico
        ' 
        rbTecnico.AutoSize = True
        rbTecnico.Location = New Point(13, 86)
        rbTecnico.Name = "rbTecnico"
        rbTecnico.Size = New Size(70, 21)
        rbTecnico.TabIndex = 2
        rbTecnico.TabStop = True
        rbTecnico.Text = "Técnico"
        rbTecnico.UseVisualStyleBackColor = True
        ' 
        ' rbAdministrativo
        ' 
        rbAdministrativo.AutoSize = True
        rbAdministrativo.Location = New Point(13, 61)
        rbAdministrativo.Name = "rbAdministrativo"
        rbAdministrativo.Size = New Size(115, 21)
        rbAdministrativo.TabIndex = 1
        rbAdministrativo.TabStop = True
        rbAdministrativo.Text = "Administrativo"
        rbAdministrativo.UseVisualStyleBackColor = True
        ' 
        ' rbObrero
        ' 
        rbObrero.AutoSize = True
        rbObrero.Location = New Point(13, 36)
        rbObrero.Name = "rbObrero"
        rbObrero.Size = New Size(69, 21)
        rbObrero.TabIndex = 0
        rbObrero.TabStop = True
        rbObrero.Text = "Obrero"
        rbObrero.UseVisualStyleBackColor = True
        ' 
        ' gbSindicato
        ' 
        gbSindicato.BackColor = SystemColors.GradientActiveCaption
        gbSindicato.Controls.Add(rbNo)
        gbSindicato.Controls.Add(rbSi)
        gbSindicato.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold)
        gbSindicato.Location = New Point(273, 78)
        gbSindicato.Name = "gbSindicato"
        gbSindicato.Size = New Size(164, 172)
        gbSindicato.TabIndex = 1
        gbSindicato.TabStop = False
        gbSindicato.Text = "¿Inscrito en un Sindicato?"
        ' 
        ' rbNo
        ' 
        rbNo.AutoSize = True
        rbNo.Location = New Point(33, 96)
        rbNo.Name = "rbNo"
        rbNo.Size = New Size(44, 21)
        rbNo.TabIndex = 2
        rbNo.TabStop = True
        rbNo.Text = "No"
        rbNo.UseVisualStyleBackColor = True
        ' 
        ' rbSi
        ' 
        rbSi.AutoSize = True
        rbSi.Location = New Point(33, 61)
        rbSi.Name = "rbSi"
        rbSi.Size = New Size(36, 21)
        rbSi.TabIndex = 1
        rbSi.TabStop = True
        rbSi.Text = "Sí"
        rbSi.UseVisualStyleBackColor = True
        ' 
        ' gbAños
        ' 
        gbAños.BackColor = SystemColors.GradientActiveCaption
        gbAños.Controls.Add(rbMas)
        gbAños.Controls.Add(rbEntre)
        gbAños.Controls.Add(rbMenos)
        gbAños.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold)
        gbAños.Location = New Point(473, 78)
        gbAños.Name = "gbAños"
        gbAños.Size = New Size(164, 172)
        gbAños.TabIndex = 2
        gbAños.TabStop = False
        gbAños.Text = "Años de Servicio"
        ' 
        ' rbMas
        ' 
        rbMas.AutoSize = True
        rbMas.Location = New Point(16, 86)
        rbMas.Name = "rbMas"
        rbMas.Size = New Size(119, 21)
        rbMas.TabIndex = 3
        rbMas.TabStop = True
        rbMas.Text = "Más de 10 años"
        rbMas.UseVisualStyleBackColor = True
        ' 
        ' rbEntre
        ' 
        rbEntre.AutoSize = True
        rbEntre.Location = New Point(16, 61)
        rbEntre.Name = "rbEntre"
        rbEntre.Size = New Size(129, 21)
        rbEntre.TabIndex = 2
        rbEntre.TabStop = True
        rbEntre.Text = "Entre 5 y 10 años"
        rbEntre.UseVisualStyleBackColor = True
        ' 
        ' rbMenos
        ' 
        rbMenos.AutoSize = True
        rbMenos.Location = New Point(16, 36)
        rbMenos.Name = "rbMenos"
        rbMenos.Size = New Size(130, 21)
        rbMenos.TabIndex = 1
        rbMenos.TabStop = True
        rbMenos.Text = "Menos de 5 años"
        rbMenos.UseVisualStyleBackColor = True
        ' 
        ' lblHijos
        ' 
        lblHijos.AutoSize = True
        lblHijos.BackColor = SystemColors.GradientInactiveCaption
        lblHijos.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblHijos.ForeColor = SystemColors.ControlText
        lblHijos.Location = New Point(51, 311)
        lblHijos.Name = "lblHijos"
        lblHijos.Size = New Size(106, 17)
        lblHijos.TabIndex = 3
        lblHijos.Text = "Número de hijos"
        ' 
        ' nudHijos
        ' 
        nudHijos.Location = New Point(163, 311)
        nudHijos.Name = "nudHijos"
        nudHijos.Size = New Size(82, 23)
        nudHijos.TabIndex = 4
        ' 
        ' btnCalcular
        ' 
        btnCalcular.BackColor = SystemColors.ButtonHighlight
        btnCalcular.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold)
        btnCalcular.Location = New Point(306, 334)
        btnCalcular.Name = "btnCalcular"
        btnCalcular.Size = New Size(80, 30)
        btnCalcular.TabIndex = 5
        btnCalcular.Text = "Calcular"
        btnCalcular.UseVisualStyleBackColor = False
        ' 
        ' btnLimpiar
        ' 
        btnLimpiar.BackColor = SystemColors.ButtonHighlight
        btnLimpiar.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold)
        btnLimpiar.Location = New Point(423, 334)
        btnLimpiar.Name = "btnLimpiar"
        btnLimpiar.Size = New Size(80, 30)
        btnLimpiar.TabIndex = 6
        btnLimpiar.Text = "Limpiar"
        btnLimpiar.UseVisualStyleBackColor = False
        ' 
        ' btnSalir
        ' 
        btnSalir.BackColor = SystemColors.ButtonHighlight
        btnSalir.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold)
        btnSalir.ForeColor = Color.IndianRed
        btnSalir.Location = New Point(537, 334)
        btnSalir.Name = "btnSalir"
        btnSalir.Size = New Size(80, 30)
        btnSalir.TabIndex = 7
        btnSalir.Text = "Salir"
        btnSalir.UseVisualStyleBackColor = False
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(btnSalir)
        Controls.Add(btnLimpiar)
        Controls.Add(btnCalcular)
        Controls.Add(nudHijos)
        Controls.Add(lblHijos)
        Controls.Add(gbAños)
        Controls.Add(gbSindicato)
        Controls.Add(gbClase)
        Name = "Form1"
        Text = "Form1"
        gbClase.ResumeLayout(False)
        gbClase.PerformLayout()
        gbSindicato.ResumeLayout(False)
        gbSindicato.PerformLayout()
        gbAños.ResumeLayout(False)
        gbAños.PerformLayout()
        CType(nudHijos, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents gbClase As GroupBox
    Friend WithEvents rbProfesional As RadioButton
    Friend WithEvents rbTecnico As RadioButton
    Friend WithEvents rbAdministrativo As RadioButton
    Friend WithEvents rbObrero As RadioButton
    Friend WithEvents gbSindicato As GroupBox
    Friend WithEvents rbNo As RadioButton
    Friend WithEvents rbSi As RadioButton
    Friend WithEvents gbAños As GroupBox
    Friend WithEvents rbMas As RadioButton
    Friend WithEvents rbEntre As RadioButton
    Friend WithEvents rbMenos As RadioButton
    Friend WithEvents lblHijos As Label
    Friend WithEvents nudHijos As NumericUpDown
    Friend WithEvents btnCalcular As Button
    Friend WithEvents btnLimpiar As Button
    Friend WithEvents btnSalir As Button

End Class
