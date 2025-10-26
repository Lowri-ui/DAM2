Imports System.Runtime.InteropServices
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class Form1

    'Código parapoder desplazar la aplicación con el mouse desde cualquier parte del formulario (panel del titulo, menu y base)
    'Drag Form
    <DllImport("user32.DLL", EntryPoint:="ReleaseCapture")>
    Private Shared Sub ReleaseCapture()
    End Sub
    <DllImport("user32.DLL", EntryPoint:="SendMessage")>
    Private Shared Sub SendMessage(ByVal hWnd As System.IntPtr, ByVal wMsg As Integer, ByVal wParam As Integer, ByVal lParam As Integer)
    End Sub
    Private Sub Form1_MouseDown(sender As Object, e As MouseEventArgs) Handles MyBase.MouseDown
        ReleaseCapture()
        SendMessage(Me.Handle, &H112&, &HF012&, 0)
    End Sub
    Private Sub PanelTitulo_MouseDown(sender As Object, e As MouseEventArgs) Handles PanelTitulo.MouseDown
        ReleaseCapture()
        SendMessage(Me.Handle, &H112&, &HF012&, 0)
    End Sub
    Private Sub PanelMenu_MouseDown(sender As Object, e As MouseEventArgs) Handles PanelMenu.MouseDown
        ReleaseCapture()
        SendMessage(Me.Handle, &H112&, &HF012&, 0)
    End Sub

    Private Sub btnMinimizar_Click(sender As Object, e As EventArgs) Handles btnMinimizar.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub btnMaximizar_Click(sender As Object, e As EventArgs) Handles btnMaximizar.Click
        If Me.WindowState = FormWindowState.Maximized Then
            Me.WindowState = FormWindowState.Normal
        Else
            Me.WindowState = FormWindowState.Maximized
        End If
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            cbFuentes.Items.Clear() 'Borra todo los item que tenga el comboBox
            For Each fuentes As FontFamily In FontFamily.Families 'Instalar las fuentes del ordenador
                Dim tipo As String 'Las fuentes se guardan en la variable tipo
                tipo = fuentes.Name
                cbFuentes.Items.Add(tipo) 'Añadimos las fuentes al comboBox cbFuentes
            Next
            cbFuentes.Text = "Arial" 'Fuente por defecto
        Catch ex As Exception
            cbFuentes.SelectedItem = 0 'Si da error que coloque la primera y muestre un mensaje
            MessageBox.Show("Error al cargar las fuentes: " & ex.Message)
        End Try
    End Sub

    Private Sub cbFuentes_Click(sender As Object, e As EventArgs) Handles cbFuentes.Click

        Try
            Dim fuenteSeleccionada = cbFuentes.SelectedItem.ToString 'Obtenemos la fuente seleccionada
            txtEditor.Font = New Font(fuenteSeleccionada, txtEditor.Font.Size) 'Cambiamos la fuente del TextBox al seleccionado
        Catch ex As Exception
            MessageBox.Show("Error al cambiar la fuente: " & ex.Message)
        End Try
    End Sub

    'En inicio deshabilitadas
    Dim negrita As Boolean = False
    Dim cursiva As Boolean = False
    Private Function ObtenerFuenteSeleccionada() As String 'Obtiene la fuente seleccionada en el ComboBox
        If cbFuentes.SelectedItem IsNot Nothing Then
            Return cbFuentes.SelectedItem.ToString()
        Else
            Return txtEditor.SelectionFont.FontFamily.Name ' Usa la actual
        End If
    End Function

    'Obtiene el estilo de fuente basado en las variables negrita y cursiva
    Private Function ObtenerEstilo() As FontStyle
        Dim estilo As FontStyle = FontStyle.Regular
        If negrita Then
            estilo = estilo Or FontStyle.Bold
        End If
        If cursiva Then
            estilo = estilo Or FontStyle.Italic
        End If
        Return estilo
    End Function

    Private Sub txbTamañoLetra_TextChanged(sender As Object, e As EventArgs) Handles txbTamañoLetra.TextChanged
        Dim nuevoTamaño As Single

        ' Intentar convertir el texto a número
        If Single.TryParse(txbTamañoLetra.Text, nuevoTamaño) Then
            ' Cambiar el tamaño de la fuente manteniendo el tipo de letra actual
            txtEditor.Font = New Font(txtEditor.Font.FontFamily, nuevoTamaño, txtEditor.Font.Style)
        End If
    End Sub

    'Para cambiar el tipo de fuente manteniendo tamaño y estilo
    Private Sub cbFuentes_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbFuentes.SelectedIndexChanged
        If cbFuentes.SelectedItem IsNot Nothing Then
            Dim fuente As String = cbFuentes.SelectedItem.ToString()
            txtEditor.SelectionFont = New Font(fuente, txtEditor.SelectionFont.Size, ObtenerEstilo())
        End If
    End Sub

    'Para cambiar de negrita a normal y viceversa
    Private Sub btnNegrita_Click(sender As Object, e As EventArgs) Handles btnNegrita.Click
        negrita = Not negrita 'Alterna negrita
        txtEditor.SelectionFont = New Font(txtEditor.SelectionFont.FontFamily, txtEditor.SelectionFont.Size, ObtenerEstilo())
    End Sub

    'Para cambiar de cursiva a normal y viceversa
    Private Sub btnCursiva_Click(sender As Object, e As EventArgs) Handles btnCursiva.Click
        Try
            If cursiva = True Then
                cursiva = False
                ' Aplica el estilo combinado usando ObtenerEstilo()
                txtEditor.SelectionFont = New Font(txtEditor.SelectionFont.FontFamily, txtEditor.SelectionFont.Size, ObtenerEstilo())
                btnCursiva.ForeColor = Color.Black
            Else
                cursiva = True
                ' Aplica el estilo combinado usando ObtenerEstilo()
                txtEditor.SelectionFont = New Font(txtEditor.SelectionFont.FontFamily, txtEditor.SelectionFont.Size, ObtenerEstilo())
                btnCursiva.ForeColor = Color.White
            End If
        Catch ex As Exception
            ' Puedes mostrar un mensaje opcional
            MessageBox.Show("Error al cambiar cursiva: " & ex.Message)
        End Try
    End Sub


    'Establece el color del texto mostrando el cuadro de dialogo con la paleta de colores con la clase ColorDialog
    Private Sub btnColor_Click(sender As Object, e As EventArgs) Handles btnColor.Click
        Try
            Dim dig = New ColorDialog 'en la variable dig se almacenará el
            'Color que se ha elegido dig.Color = txtEditor.SelectionColor
            If dig.ShowDialog = DialogResult.OK Then
                txtEditor.SelectionColor = dig.Color
                btnColor.BackColor = dig.Color
            End If
        Catch ex As Exception
            MessageBox.Show("Error al cambiar el color: " & ex.Message)
        End Try
    End Sub

    Private Sub TrackBar_Scroll(sender As Object, e As EventArgs) Handles TrackBar.Scroll
        ' Ajusta zoom y etiqueta de porcentaje
        lblPorcentaje.Text = TrackBar.Value * 100 & "%"
        txtEditor.ZoomFactor = TrackBar.Value
    End Sub

    ' Funciones de portapapeles desde menú
    Private Sub ToolStripMenuCopiar_Click(sender As Object, e As EventArgs) Handles ToolStripMenuCopiar.Click
        txtEditor.Copy()
    End Sub

    Private Sub ToolStripMenuCortar_Click(sender As Object, e As EventArgs) Handles ToolStripMenuCortar.Click
        txtEditor.Cut()
    End Sub

    Private Sub ToolStripMenuPegar_Click(sender As Object, e As EventArgs) Handles ToolStripMenuPegar.Click
        txtEditor.Paste()
    End Sub

    Private Sub ToolStripMenuSeleccionarTodo_Click(sender As Object, e As EventArgs) Handles ToolStripMenuSeleccionarTodo.Click
        txtEditor.SelectAll()
    End Sub

    Private Sub ToolStripMenuDeshacer_Click(sender As Object, e As EventArgs) Handles ToolStripMenuDeshacer.Click
        txtEditor.Undo()
    End Sub

    Private Sub ToolStripMenuRehacerClick(sender As Object, e As EventArgs) Handles ToolStripMenuRehacer.Click
        txtEditor.Redo()
    End Sub

    ' Funciones de portapapeles desde menú contextual (CLICK DERECHO)
    Private Sub CortarContextMenuStrip_Click(sender As Object, e As EventArgs) Handles CortarContextMenuStrip.Click
        txtEditor.Cut()
    End Sub

    Private Sub CopiarContextMenuStrip_Click(sender As Object, e As EventArgs) Handles CopiarContextMenuStrip.Click
        txtEditor.Copy()
    End Sub

    Private Sub PegarContextMenuStrip_Click(sender As Object, e As EventArgs) Handles PegarContextMenuStrip.Click
        txtEditor.Paste()
    End Sub

    Private Sub SeleccionarTodoContextMenuStrip_Click(sender As Object, e As EventArgs) Handles SeleccionarTodoContextMenuStrip.Click
        txtEditor.SelectAll()
    End Sub

    ' Nuevo documento
    Private Sub ToolStripMenuNuevo_Click(sender As Object, e As EventArgs) Handles ToolStripMenuNuevo.Click
        txtEditor.Clear()
    End Sub

    ' Abrir archivo de texto
    Private Sub ToolStripMenuAbrir_Click(sender As Object, e As EventArgs) Handles ToolStripMenuAbrir.Click
        Dim Open As New OpenFileDialog
        Dim MyStreamReader As System.IO.StreamReader
        Open.Filter = "text (*.txt)|*.txt|All Files(*.*)|*.*"
        Open.CheckFileExists = True
        Open.Title = "Abrir como"
        Open.ShowDialog(Me)
        Try
            MyStreamReader = System.IO.File.OpenText(Open.FileName)
            txtEditor.Text = MyStreamReader.ReadToEnd()
        Catch ex As Exception
            ' Ignora errores al abrir archivo
        End Try
    End Sub

    ' Guardar archivo con opción "Guardar como"
    Private Sub ToolStripMenuGuardarComo_Click(sender As Object, e As EventArgs) Handles ToolStripMenuGuardarComo.Click
        Dim save As New SaveFileDialog
        Dim MyStreamWriter As System.IO.StreamWriter
        save.Filter = "text (*.txt)|*.txt|Html (*.html*)|*.html|php(*.php*)|*.php*|AllFiles(*.*)|*.*"
        save.CheckFileExists = False
        save.Title = "Guardar como"
        save.ShowDialog(Me)
        Try
            MyStreamWriter = System.IO.File.AppendText(save.FileName)
            MyStreamWriter.Write(txtEditor.Text)
            MyStreamWriter.Flush()
        Catch ex As Exception
            ' Ignora errores al guardar
        End Try
    End Sub

    ' Salir de la aplicación
    Private Sub ToolStripMenuSalir_Click(sender As Object, e As EventArgs) Handles ToolStripMenuSalir.Click
        End
    End Sub

    ' Actualiza controles según la selección de texto
    Dim estado As Integer = 0
    Private Sub txtEditor_SelectionChanged(sender As Object, e As EventArgs) Handles txtEditor.SelectionChanged
        Try
            cbFuentes.Text = txtEditor.SelectionFont.Name
            estado = txtEditor.SelectionFont.Style
            ' Cambia color de botones negrita/cursiva según estilo
            If estado = 0 Then
                btnNegrita.ForeColor = Color.White
                btnCursiva.ForeColor = Color.White
            ElseIf estado = 1 Then
                btnNegrita.ForeColor = Color.Chocolate
                btnCursiva.ForeColor = Color.White
            ElseIf estado = 2 Then
                btnNegrita.ForeColor = Color.White
                btnCursiva.ForeColor = Color.Chocolate
            End If
            ' Actualiza color del botón de color
            btnColor.BackColor = txtEditor.SelectionColor
        Catch ex As Exception
            ' Ignora errores al actualizar controles
        End Try
    End Sub


End Class
