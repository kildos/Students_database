Public Class frmExportar
    Dim ficAlumnos As Integer
    Dim ficTxt As Integer
    Dim ficTxtTEMP As Integer
    Dim rutTxt As String = "..\..\Datos\alumnos.txt"
    Dim rutTxtTEMP As String = "..\..\Datos\alumnosTEMP.txt"
    Dim rutAlumnos As String = "..\..\Datos\alumnos.dat"
    Dim rutCSV As String = "..\..\Datos\alumnos.csv"
    Dim codAlu As Integer 'codigo del alumno
    Dim nifAlu As String 'nif del alumno
    Dim nomAlu As String 'nombre del alumno
    Dim fechaAlu As Date 'fecha de ingreso del alumno
    Dim curAlu As String 'curso que hace el alumno
    Dim sexAlu As Char 'sexo del alumno
    Dim ordenacion As Integer
    Private Sub btnCSV_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCSV.Click
        'rutina para crear el archivo .CSV a partir de alumnos.dat
        Dim archivo As System.IO.StreamWriter
        If My.Computer.FileSystem.FileExists(rutCSV) Then
            Kill(rutCSV)
            Me.Close()
        End If
        ficAlumnos = FreeFile()
        FileOpen(ficAlumnos, rutAlumnos, OpenMode.Input)
        archivo = My.Computer.FileSystem.OpenTextFileWriter(rutCSV, True)
        While Not EOF(ficAlumnos)
            'ahora vamos a leer os rexitros
            Input(ficAlumnos, codAlu)       'leemos el codigo
            Input(ficAlumnos, nifAlu)      'leemos el NIF
            Input(ficAlumnos, nomAlu)         'leemos el nombre
            Input(ficAlumnos, fechaAlu)         'leemos la fecha de ingreso
            Input(ficAlumnos, curAlu)   'leemos el curso
            Input(ficAlumnos, sexAlu)   'leemos el sexo
            archivo.WriteLine(codAlu & ";" & nifAlu & ";" & nomAlu & ";" & fechaAlu & ";" & curAlu & ";" & sexAlu)
        End While
        FileClose(ficAlumnos)
        archivo.Close()
        Shell("C:\Program Files (x86)\Microsoft Office\root\Office16\EXCEL.EXE " & rutCSV, AppWinStyle.MaximizedFocus)
    End Sub

    Private Sub btnTxt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTxt.Click
        'If My.Computer.FileSystem.FileExists(rutTxt) Then
        '    Kill(rutTxt)
        '    Me.Close()
        'End If
        'ficTxt = FreeFile()
        'FileOpen(ficTxt, rutTxt, OpenMode.Output)
        'ficAlumnos = FreeFile()
        'FileOpen(ficAlumnos, rutAlumnos, OpenMode.Input)
        'WriteLine(ficTxt, SPC(4), "Código", SPC(1), "NIF", SPC(7), "Nombre", SPC(20), "Fecha alta", SPC(1), "Curso", SPC(1), "Sexo")
        'WriteLine(ficTxt, SPC(4), "-------------------------------------------------------------------------------")
        'While Not EOF(ficAlumnos)
        '    'ahora vamos a leer os rexitros
        '    Input(ficAlumnos, codAlu)       'leemos el codigo
        '    Input(ficAlumnos, nifAlu)      'leemos el NIF
        '    Input(ficAlumnos, nomAlu)         'leemos el nombre
        '    Input(ficAlumnos, fechaAlu)         'leemos la fecha de ingreso
        '    Input(ficAlumnos, curAlu)   'leemos el curso
        '    Input(ficAlumnos, sexAlu)   'leemos el sexo
        '    'WriteLine(ficTxt, SPC(4 + (6 - Len(CStr(codAlu)))), CStr(codAlu), SPC(1), nifAlu, SPC(1), nomAlu, SPC(26 - Len(nomAlu)), fechaAlu, SPC(1), curAlu, SPC(8 - Len(curAlu)), sexAlu)
        '    WriteLine(ficTxt, SPC(4), (Format(codAlu, "00000")), CStr(codAlu), SPC(1), nifAlu, SPC(1), nomAlu, SPC(26 - Len(nomAlu)), fechaAlu, SPC(1), curAlu, SPC(8 - Len(curAlu)), sexAlu)

        'End While
        'FileClose(ficAlumnos)
        'FileClose(ficTxt)
        'Me.Close()
        'Shell("notepad " & rutTxt, AppWinStyle.MaximizedFocus)


        If My.Computer.FileSystem.FileExists(rutTxt) Then
            Kill(rutTxt)
            Me.Close()
        End If
        ordenacion = cmbOrdenacion.SelectedIndex
        Select Case ordenacion
            Case 0
                ordenacion = 2
            Case 1
                ordenacion = 24
            Case 2
                ordenacion = 53
        End Select
        ficTxtTEMP = FreeFile()
        FileOpen(ficTxtTEMP, rutTxtTEMP, OpenMode.Output)
        ficAlumnos = FreeFile()
        FileOpen(ficAlumnos, rutAlumnos, OpenMode.Input)
        'WriteLine(ficTxt, SPC(4), "Código", SPC(1), "NIF", SPC(7), "Nombre", SPC(20), "Fecha alta", SPC(1), "Curso", SPC(1), "Sexo")
        'WriteLine(ficTxt, SPC(4), "-------------------------------------------------------------------------------")

        While Not EOF(ficAlumnos)
            'ahora vamos a leer os rexitros
            Input(ficAlumnos, codAlu)   'leemos el codigo
            Input(ficAlumnos, nifAlu)   'leemos el NIF
            Input(ficAlumnos, nomAlu)   'leemos el nombre
            Input(ficAlumnos, fechaAlu) 'leemos la fecha de ingreso
            Input(ficAlumnos, curAlu)   'leemos el curso
            Input(ficAlumnos, sexAlu)   'leemos el sexo
            WriteLine(ficTxtTEMP, (Format(codAlu, "00000")), SPC(1), nifAlu, SPC(1), nomAlu, SPC(26 - Len(nomAlu)), fechaAlu, SPC(1), curAlu, SPC(8 - Len(curAlu)), sexAlu)
        End While

        FileClose(ficAlumnos)
        FileClose(ficTxtTEMP)
        'Shell("cmd.exe /c sort [/r][/columna] <archivoEntrada.txt>archivoSalida.txt"
        If radDescentente.Checked Then
            Shell("cmd.exe /c SORT /r /+" & ordenacion & "<" & rutTxtTEMP & ">" & rutTxt)
        Else
            Shell("cmd.exe /c SORT /+" & ordenacion & "<" & rutTxtTEMP & ">" & rutTxt)
        End If

        Me.Close()
        Shell("notepad " & rutTxt, AppWinStyle.MaximizedFocus)

    End Sub

    Private Sub frmExportar_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cmbOrdenacion.SelectedIndex = 0
        radAscendente.Checked = True
    End Sub
End Class