Public Class Form1

    ' Variable para guardar el formulario actual abierto
    Private FormularioActual As Form = Nothing

    ' Al cargar el formulario principal
    Private Sub FormInicio_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        OcultarSubMenu()
    End Sub

    ' Método para ocultar los submenús
    Private Sub OcultarSubMenu()
        PanelArchivo.Visible = False
        PanelGaleria.Visible = False
    End Sub

    ' Método para mostrar un submenú
    Private Sub MostrarSubMenu(submenu As Panel)
        If submenu.Visible = False Then
            OcultarSubMenu()
            submenu.Visible = True
        Else
            submenu.Visible = False
        End If
    End Sub

    ' Método para abrir formularios hijos dentro del panel contenedor
    Private Sub AbrirFormHijo(formularioHijo As Form)
        If FormularioActual IsNot Nothing Then
            FormularioActual.Close()
        End If

        FormularioActual = formularioHijo
        formularioHijo.TopLevel = False
        formularioHijo.FormBorderStyle = FormBorderStyle.None
        formularioHijo.Dock = DockStyle.Fill
        panelHijo.Controls.Add(formularioHijo)
        panelHijo.Tag = formularioHijo
        formularioHijo.BringToFront()
        formularioHijo.Show()
    End Sub

    ' -----------------------------
    ' EVENTOS DE LOS BOTONES DEL MENÚ
    ' -----------------------------

    Private Sub btnArchivo_Click(sender As Object, e As EventArgs) Handles btnArchivo.Click
        MostrarSubMenu(PanelArchivo)
    End Sub

    Private Sub btnGaleria_Click(sender As Object, e As EventArgs) Handles btnGaleria.Click
        MostrarSubMenu(PanelGaleria)
    End Sub

    ' Submenú Archivo
    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        AbrirFormHijo(New FormBuscar)
        OcultarSubMenu()
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        AbrirFormHijo(New FormGuardar)
        OcultarSubMenu()
    End Sub

    Private Sub btnImportar_Click(sender As Object, e As EventArgs) Handles btnImportar.Click
        AbrirFormHijo(New FormImportar)
        OcultarSubMenu()
    End Sub

    ' Botón salir
    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        OcultarSubMenu()
        Application.Exit()
    End Sub

    ' Submenú Galería
    Private Sub btnFososs_Click(sender As Object, e As EventArgs) Handles btnFotos.Click
        AbrirFormHijo(New FormFotos)
        OcultarSubMenu()
    End Sub

    Private Sub btnVideos_Click(sender As Object, e As EventArgs) Handles btnVideos.Click
        AbrirFormHijo(New FormVideos)
        OcultarSubMenu()
    End Sub

    Private Sub btnMultimedia_Click(sender As Object, e As EventArgs) Handles btnMultimedia.Click
        AbrirFormHijo(New FormMultimedia)
        OcultarSubMenu()
    End Sub

End Class

Public Class FormBuscar
    Dim ofd As New OpenFileDialog
    Dim ruta As String

    ' Método para abrir archivos de música
    Sub abrir()
        ofd.Filter = "Música en MP3 | *.mp3;"
        If ofd.ShowDialog = DialogResult.OK Then
            ruta = ofd.FileName
            Form1.MediaPlayer.URL = ruta
            Form1.MediaPlayer.Ctlcontrols.play()
            lbxBuscar.Items.Add(ruta)
        End If
    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        abrir()
    End Sub

    Private Sub btnStop_Click(sender As Object, e As EventArgs) Handles btnStop.Click
        Form1.MediaPlayer.Ctlcontrols.stop()
    End Sub

    Private Sub btnPlay_Click(sender As Object, e As EventArgs) Handles btnPlay.Click
        Form1.MediaPlayer.Ctlcontrols.play()
    End Sub

    Private Sub btnPause_Click(sender As Object, e As EventArgs) Handles btnPause.Click
        Form1.MediaPlayer.Ctlcontrols.pause()
    End Sub
End Class

Public Class FormGuardar
    Dim ofd As New OpenFileDialog()
    Dim ruta As String

    'Método para abrir y reproducir un archivo MP3
    Sub abrir()
        ofd.Filter = "Música en MP3 | *.mp3;"
        If ofd.ShowDialog() = DialogResult.OK Then
            ruta = ofd.FileName
            Form1.MediaPlayer.URL = ruta
            Form1.MediaPlayer.Ctlcontrols.play()
            lbxGuardar.Items.Add(ruta)
        End If
    End Sub

    'Evento del botón Guardar: guarda la lista en un archivo .txt
    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Dim save As New SaveFileDialog()
        save.Filter = "Archivo de texto | *.txt"

        If save.ShowDialog() = DialogResult.OK Then
            Dim sw As New System.IO.StreamWriter(save.FileName)
            For Each item In lbxGuardar.Items
                sw.WriteLine(item.ToString())
            Next
            sw.Close()
        End If
    End Sub

    'Evento del botón Abrir: permite seleccionar y reproducir un archivo
    Private Sub btnAbrir_Click(sender As Object, e As EventArgs) Handles btnAbrir.Click
        abrir()
    End Sub
End Class

Public Class FormImportar

    Private Sub btnImportar_Click(sender As Object, e As EventArgs) Handles btnImportar.Click
        Dim stRuta As String = ""
        Dim openFD As New OpenFileDialog()

        With openFD
            .Title = "Seleccionar archivos"
            .Filter = "Archivos de texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*"
            .Multiselect = False
            .InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyMusic
        End With

        If openFD.ShowDialog() = DialogResult.OK Then
            stRuta = openFD.FileName
        End If

        ' Si el usuario selecciona un archivo, lo leemos línea por línea
        If stRuta <> "" Then
            Dim sr As New System.IO.StreamReader(stRuta)
            While Not sr.EndOfStream
                lbxImportar.Items.Add(sr.ReadLine())
            End While
            sr.Close()
        End If
    End Sub

    Private Sub lbxImportar_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lbxImportar.SelectedIndexChanged
        ' Reproducir la canción seleccionada en el MediaPlayer del formulario principal
        If lbxImportar.SelectedItem IsNot Nothing Then
            Form1.MediaPlayer.URL = lbxImportar.SelectedItem.ToString()
            Form1.MediaPlayer.Ctlcontrols.play()
        End If
    End Sub

End Class



