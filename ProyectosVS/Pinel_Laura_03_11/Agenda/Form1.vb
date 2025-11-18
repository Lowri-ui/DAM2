Imports System.IO

Public Class Form1

    ' Variables globales
    Dim nombre, dni, telefono, direccion, sexo As String
    Dim validadosCampos, dniValidado As Boolean
    Dim filaActual As Integer

    ' Cargar datos desde el fichero
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        If File.Exists("./datos.txt") Then
            Dim ficheroDatos As StreamReader = New StreamReader("./datos.txt")
            While Not ficheroDatos.EndOfStream
                Dim linea As String = ficheroDatos.ReadLine()
                Dim dato As String() = linea.Split(";"c)
                DataGridView1.Rows.Add(dato)
            End While
            ficheroDatos.Close()
        End If
    End Sub

    ' AGREGAR
    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click

        nombre = tbNombre.Text
        dni = tbDni.Text
        telefono = tbTelefono.Text
        direccion = tbDireccion.Text
        sexo = cbSexo.Text
        validadosCampos = validarCampos(nombre, dni, telefono, direccion, sexo)

        If validadosCampos = True Then
            dniValidado = validarDNI(dni)
            If dniValidado = True Then
                DataGridView1.Rows.Add(nombre, dni, telefono, direccion, sexo)
                MsgBox("Se agregó el nuevo contacto correctamente", MsgBoxStyle.Information)
                limpiar()
            End If
        End If
    End Sub

    ' DOBLE CLICK PARA EDITAR
    Private Sub DataGridView1_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellDoubleClick

        filaActual = DataGridView1.CurrentRow.Index
        tbNombre.Text = DataGridView1.Rows(filaActual).Cells("ColumnNombre").Value
        tbDni.Text = DataGridView1.Rows(filaActual).Cells("ColumnDni").Value
        tbTelefono.Text = DataGridView1.Rows(filaActual).Cells("ColumnTelefono").Value
        tbDireccion.Text = DataGridView1.Rows(filaActual).Cells("ColumnDireccion").Value
        cbSexo.Text = DataGridView1.Rows(filaActual).Cells("ColumnSexo").Value
        DesactivarBotones()
    End Sub

    ' MODIFICAR
    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click

        nombre = tbNombre.Text
        dni = tbDni.Text
        telefono = tbTelefono.Text
        direccion = tbDireccion.Text
        sexo = cbSexo.Text
        validadosCampos = validarCampos(nombre, dni, telefono, direccion, sexo)
        filaActual = DataGridView1.CurrentRow.Index
        dniValidado = True

        If validadosCampos = True Then

            If dni <> DataGridView1.Rows(filaActual).Cells("ColumnDni").Value Then
                dniValidado = validarDNI(dni)
            End If

            If dniValidado = True Then
                DataGridView1.Rows(filaActual).Cells("ColumnNombre").Value = nombre
                DataGridView1.Rows(filaActual).Cells("ColumnDni").Value = dni
                DataGridView1.Rows(filaActual).Cells("ColumnTelefono").Value = telefono
                DataGridView1.Rows(filaActual).Cells("ColumnDireccion").Value = direccion
                DataGridView1.Rows(filaActual).Cells("ColumnSexo").Value = sexo

                MsgBox("El contacto se ha modificado correctamente", MsgBoxStyle.Information)
                ActivarBotones()
                limpiar()
            End If
        End If
    End Sub

    ' ELIMINAR
    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        Dim pregunta As Integer = MsgBox("¿Estás seguro/a que deseas eliminar este contacto?", MsgBoxStyle.YesNo)

        If pregunta = vbYes Then
            filaActual = DataGridView1.CurrentRow.Index
            DataGridView1.Rows.Remove(DataGridView1.Rows(filaActual))
            MsgBox("El contacto se ha eliminado correctamente", MsgBoxStyle.Information)
            ActivarBotones()
            limpiar()
        End If
    End Sub

    ' GUARDAR EN FICHERO
    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        GuardarDatos()
    End Sub

    ' SALIR
    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        End
    End Sub

    ' VALIDAR CAMPOS
    Function validarCampos(n As String, d As String, t As String, dir As String, s As String) As Boolean

        If n = "" Then
            MsgBox("Debe introducir un nombre", MsgBoxStyle.Critical)
            ErrorProvider1.SetError(tbNombre, "Ingrese un nombre")
            Return False
        ElseIf d = "" Then
            MsgBox("Debe introducir un DNI", MsgBoxStyle.Critical)
            ErrorProvider1.SetError(tbDni, "Ingrese un DNI")
            Return False
        ElseIf t = "" Then
            MsgBox("Debe introducir un teléfono", MsgBoxStyle.Critical)
            ErrorProvider1.SetError(tbTelefono, "Ingrese un teléfono")
            Return False
        ElseIf dir = "" Then
            MsgBox("Debe introducir una dirección", MsgBoxStyle.Critical)
            ErrorProvider1.SetError(tbDireccion, "Ingrese una dirección")
            Return False
        ElseIf s = "" Then
            MsgBox("Debe seleccionar un sexo", MsgBoxStyle.Critical)
            ErrorProvider1.SetError(cbSexo, "Seleccione un sexo")
            Return False
        End If
        ErrorProvider1.Clear()
        Return True
    End Function

    ' VALIDAR DNI REPETIDO
    Function validarDNI(parDNI As String) As Boolean

        For i = 0 To DataGridView1.RowCount - 1
            If parDNI = DataGridView1.Rows(i).Cells("ColumnDni").Value Then
                MsgBox("Este DNI ya existe.", MsgBoxStyle.Critical)
                ErrorProvider1.SetError(tbDni, "DNI repetido")
                Return False
            End If
        Next
        ErrorProvider1.SetError(tbDni, "")
        Return True

    End Function


    ' LIMPIAR CAMPOS
    Sub limpiar()
        tbNombre.Clear()
        tbDni.Clear()
        tbTelefono.Clear()
        tbDireccion.Clear()
        cbSexo.Text = ""
    End Sub

    ' DESACTIVAR BOTONES
    Sub DesactivarBotones()
        btnAgregar.Enabled = False
        btnGuardar.Enabled = False
        btnModificar.Enabled = True
        btnEliminar.Enabled = True
    End Sub

    ' ACTIVAR BOTONES
    Sub ActivarBotones()
        btnAgregar.Enabled = True
        btnGuardar.Enabled = True
        btnModificar.Enabled = False
        btnEliminar.Enabled = False
    End Sub

    ' GUARDAR EN ARCHIVO
    Sub GuardarDatos()

        Dim ficheroDatos As StreamWriter = New StreamWriter("./datos.txt")
        For i = 0 To DataGridView1.RowCount - 1
            Dim linea As String =
                DataGridView1.Rows(i).Cells("ColumnNombre").Value & ";" &
                DataGridView1.Rows(i).Cells("ColumnDni").Value & ";" &
                DataGridView1.Rows(i).Cells("ColumnTelefono").Value & ";" &
                DataGridView1.Rows(i).Cells("ColumnDireccion").Value & ";" &
                DataGridView1.Rows(i).Cells("ColumnSexo").Value & ";"

            ficheroDatos.WriteLine(linea)
        Next
        ficheroDatos.Close()
        MsgBox("Los datos se han guardado correctamente", MsgBoxStyle.Information)

    End Sub

End Class
