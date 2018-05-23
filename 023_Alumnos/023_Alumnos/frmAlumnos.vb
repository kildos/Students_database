Public Class frmAlumnos
    'int codigo entre 1 y 99999
    'string nif tiene que ser el dni nacional (8 caracteres numericos y una letra que hay que calcular)
    'string nombre no puede estar en blanco
    'date data de ingreso es un data picker 
    'string 6 cursos posibles de ciclo
    'char sexo v o m
    'si el archivo esta vacio, los botones de desplazamiento estan vacios 
    'si estamos en el primer registro, que no aparezcan habilitados los botones de inicio y viceversa
    'si no hay datos en el archivo, solo debe estar habilitado es el de NUEVO
    'los de confirmar no están activados al abrir el programa y la parte izquierda del formulario debe estar deshabilitada
    'al pulsar NUEVO: desplazamiento desactivado,confirmaciones activados (el resto de botones no) y textbox tambien
    'no pueden existir codigos repetidos
    'en el data picker está por defecto la fecha de hoy
    Dim ficAlumnos As Integer
    Dim rutAlumnos As String = "..\..\Datos\alumnos.dat"
    Dim ficTemporal As Integer
    Dim rutTemporal As String = "..\..\Datos\alumnos.tmp"
    Dim operacionActual As String 'variable para saber como debe actuar el boton aceptar, dependiendo de la operacion a realizar
    Dim codAlu As Integer 'codigo del alumno
    Dim nifAlu As String 'nif del alumno
    Dim nomAlu As String 'nombre del alumno
    Dim fechaAlu As Date 'fecha de ingreso del alumno
    Dim curAlu As String 'curso que hace el alumno
    Dim sexAlu As Char 'sexo del alumno
    Dim registroActual As Integer = 0
    Dim totalRegistros As Integer = 0
    Dim codigoAGuardar As Integer = 0




    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'procesos al abrir el formulario
        If Not My.Computer.FileSystem.FileExists(rutAlumnos) Then
            MsgBox("No existe el archivo de base de datos." & Chr(13) & "Póngase en contacto con su proveedor de software.", vbInformation, "Socios")
            Me.Close()
        Else
            'cmbCurso.SelectedIndex = 0
            'cmbSexo.SelectedIndex = 0
            dtpFecha.Value = Now
            If FileLen(rutAlumnos) = 0 Then
                'si el archivo de alumnos está vacío, deshabilitamos lo innecesario
                grbDesplazamiento.Enabled = False
                'deshabilitar("Nuevo")
                btnBuscar.Enabled = False
                btnBorrar.Enabled = False
                btnEditar.Enabled = False
                btnExportar.Enabled = False
            Else
                ficAlumnos = FreeFile()
                FileOpen(ficAlumnos, rutAlumnos, OpenMode.Input)
                While Not EOF(ficAlumnos)
                    'ahora vamos a leer os rexitros
                    Input(ficAlumnos, codAlu)       'leemos el codigo
                    Input(ficAlumnos, nifAlu)      'leemos el NIF
                    Input(ficAlumnos, nomAlu)         'leemos el nombre
                    Input(ficAlumnos, fechaAlu)         'leemos la fecha de ingreso
                    Input(ficAlumnos, curAlu)   'leemos el curso
                    Input(ficAlumnos, sexAlu)   'leemos el sexo
                    registroActual = registroActual + 1
                    totalRegistros = totalRegistros + 1
                End While
                registroActual = 0
                btnPrimero.Enabled = False
                btnAnterior.Enabled = False
                FileClose(ficAlumnos)
                leer()

            End If

        End If
    End Sub
    Sub deshabilitar(ByVal caso)
        'rutina para deshabilitar la parte del formulario que necesitamos
        Select Case caso
            Case "operaciones"
                btnNuevo.Enabled = False
                btnBorrar.Enabled = False
                btnBuscar.Enabled = False
                btnEditar.Enabled = False
                btnExportar.Enabled = False
            Case "cajasTexto"
                txtCodigo.Enabled = False
                txtNIF.Enabled = False
                txtNombre.Enabled = False
                dtpFecha.Enabled = False
                cmbCurso.Enabled = False
                cmbSexo.Enabled = False
            Case "confirmacion"
                grbConfirmacion.Enabled = False
            Case "desplazamiento"
                grbDesplazamiento.Enabled = False
            Case "botonesDeAvance"
                btnPrimero.Enabled = True
                btnAnterior.Enabled = True
                btnSiguiente.Enabled = False
                btnUltimo.Enabled = False
            Case "botonesDeRetroceso"
                btnPrimero.Enabled = False
                btnAnterior.Enabled = False
                btnSiguiente.Enabled = True
                btnUltimo.Enabled = True
        End Select

    End Sub
    Sub habilitar(ByVal boton)
        'rutina para habilitar lo necesario cuando pulsamos segun que boton
        Select Case boton
            Case "Nuevo"
                txtCodigo.Enabled = True
                txtNIF.Enabled = True
                txtNombre.Enabled = True
                dtpFecha.Enabled = True
                cmbCurso.Enabled = True
                cmbSexo.Enabled = True
                cmbCurso.SelectedIndex = 0
                cmbSexo.SelectedIndex = 0
                grbConfirmacion.Enabled = True
                grbDesplazamiento.Enabled = False
                lblDesplazamiento.Visible = False
            Case "cajasTexto"
                txtCodigo.Enabled = True
                txtNIF.Enabled = True
                txtNombre.Enabled = True
                dtpFecha.Enabled = True
                cmbCurso.Enabled = True
                cmbSexo.Enabled = True
            Case "operaciones"
                btnNuevo.Enabled = True
                btnBorrar.Enabled = True
                btnBuscar.Enabled = True
                btnEditar.Enabled = True
                btnExportar.Enabled = True
            Case "desplazamiento"
                grbDesplazamiento.Enabled = True
            Case "confirmacion"
                grbConfirmacion.Enabled = True
        End Select
    End Sub
    Sub limpiar()
        'rutina para limpiar los campos del formulario
        txtCodigo.Clear()
        txtNIF.Clear()
        txtNombre.Clear()
        cmbCurso.SelectedIndex = 0
        cmbSexo.SelectedIndex = 0
        dtpFecha.Value = Now
    End Sub
    Private Sub btnNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNuevo.Click
        habilitar("Nuevo")
        deshabilitar("operaciones")
        txtCodigo.Focus()
        limpiar()
        operacionActual = "Nuevo"

    End Sub
    Function letraCorrecta(ByVal numero) As Boolean
        'funcion para comprobar si la letra introducida en el nif es la correcta
        Dim listaLetras As String = "TRWAGMYFPDXBNJZSQVHLCKET" 'cadena de letras para los NIFs
        Dim letra As String
        letra = listaLetras.Chars(CInt(numero.Substring(0, 8) Mod 23)) 'cogemos el NIF sin la letra y calculamos que letra debería tener
        If letra <> numero.chars(8) Then 'comprobamos si la letra introducida es la correcta
            Return False
        Else
            Return True
        End If
    End Function
    Function Repetido(ByVal codigo) As Boolean
        'con esta funcion sabremos si ya existe un registro con el mismo código que intentamos introducir
        'abrimos o arquivo de input para poder leelo
        Repetido = False
        ficAlumnos = FreeFile()
        FileOpen(ficAlumnos, rutAlumnos, OpenMode.Input)
        'abrimos el archivo y leemos de el hasta que no sea final de archivo
        While Not EOF(ficAlumnos) And Repetido = False
            'ahora vamos a leer os rexitros
            Input(ficAlumnos, codAlu)   'leemos el codigo
            Input(ficAlumnos, nifAlu)   'leemos el nif
            Input(ficAlumnos, nomAlu)   'leemos el nombre
            Input(ficAlumnos, fechaAlu) 'leemos la fecha de ingreso
            Input(ficAlumnos, curAlu)   'leemos el curso del alumno
            Input(ficAlumnos, sexAlu)   'leemos el sexo del alumno
            'ahora vamos a ir comprobando ya existe un registro con ese codigo
            If codAlu = codigo Then
                Repetido = True
            End If
        End While
        FileClose(ficAlumnos)
        Return Repetido
    End Function

    Private Sub btnSi_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSi.Click
        'rutina al pulsar el boton si, dependiendo de que operacion queramos hacer
        If operacionActual = "Nuevo" Then
            If Trim(txtCodigo.Text = "") Then
                MsgBox("Introduzca un código válido (1-99999)", vbInformation, "Alumnos")
                txtCodigo.SelectAll()
                txtCodigo.Focus()
            ElseIf CInt(txtCodigo.Text) < 1 Then
                MsgBox("Introduzca un código válido (1-99999)", vbInformation, "Alumnos")
                txtCodigo.SelectAll()
                txtCodigo.Focus()
            ElseIf (Repetido(CInt(txtCodigo.Text))) Then
                MsgBox("Ya existe un alumno con ese código!", vbInformation, "Alumnos")
                txtCodigo.SelectAll()
                txtCodigo.Focus()
            ElseIf Trim(txtNIF.Text = "") Then
                MsgBox("Introduzca un NIF", vbInformation, "Alumnos")
                txtNIF.SelectAll()
                txtNIF.Focus()
            ElseIf Trim(txtNIF.Text).Length < 9 Then
                MsgBox("Introduzca un NIF válido", vbInformation, "Alumnos")
                txtNIF.SelectAll()
                txtNIF.Focus()
            ElseIf Not IsNumeric(txtNIF.Text.Substring(0, 8)) Then
                MsgBox("Introduzca un NIF válido", vbInformation, "Alumnos")
                txtNIF.SelectAll()
                txtNIF.Focus()
            ElseIf Not letraCorrecta(txtNIF.Text) Then
                MsgBox("La letra del NIF no es correcta", vbInformation, "Alumnos")
                txtNIF.SelectAll()
                txtNIF.Focus()
            ElseIf Trim(txtNombre.Text) = "" Then
                MsgBox("Introduzca un nombre válido", vbInformation, "Alumnos")
                txtNombre.Focus()
            Else
                ficAlumnos = FreeFile()
                FileOpen(ficAlumnos, rutAlumnos, OpenMode.Append)
                WriteLine(ficAlumnos, CInt(txtCodigo.Text), txtNIF.Text, txtNombre.Text, CDate(dtpFecha.Text), cmbCurso.SelectedItem, cmbSexo.SelectedItem)
                FileClose(ficAlumnos)
                MsgBox("Registro guardado correctamente.", vbInformation, "Alumnos")
                limpiar()
                btnNuevo.Enabled = True
                btnBuscar.Enabled = True
                btnBorrar.Enabled = True
                btnEditar.Enabled = True
                btnExportar.Enabled = True
                deshabilitar("cajasTexto")
                deshabilitar("confirmacion")
                habilitar("desplazamiento")
                lblDesplazamiento.Visible = True
                totalRegistros = totalRegistros + 1
                registroActual = totalRegistros - 1
                deshabilitar("botonesDeAvance")
                habilitar("botonesDeRetroceso")
                leer()
                End If
        ElseIf operacionActual = "Buscar" Then
                Dim codigo As String 'variable para guardar el valor en el que tenemos que encontrar coincidencia
                If txtCodigo.Text <> "" And txtNIF.Text <> "" Then
                    MsgBox("Introduzca solo un campo a buscar (codigo/NIF)", vbInformation, "Alumnos")
                    txtCodigo.Focus()
                ElseIf txtCodigo.Text = "" And txtNIF.Text = "" Then
                    MsgBox("Introzuca algún campo a buscar (código/NIF)", vbInformation, "Alumnos")
                    txtCodigo.Focus()
                ElseIf txtCodigo.Text <> "" And txtNIF.Text = "" Then
                    If CInt(txtCodigo.Text) < 1 Then
                        MsgBox("Introzuca un codigo válido (1-99999)", vbInformation, "Alumnos")
                        txtCodigo.Focus()
                    Else
                        codigo = CInt(txtCodigo.Text)
                        buscarPorCodigo(codigo)

                    End If

                Else
                    If Not IsNumeric(txtNIF.Text.Substring(0, 8)) Then
                        MsgBox("Introduzca un NIF válido", vbInformation, "Alumnos")
                        txtNIF.SelectAll()
                        txtNIF.Focus()
                    ElseIf IsNumeric(txtNIF.Text.Chars(8)) Then
                        MsgBox("Introduzca un NIF válido", vbInformation, "Alumnos")
                        txtNIF.SelectAll()
                        txtNIF.Focus()
                    Else
                        codigo = txtNIF.Text
                        buscarPorNIF(codigo)
                    End If
                End If
        ElseIf operacionActual = "editar" Then
            If Trim(txtCodigo.Text = "") Then
                MsgBox("Introduzca un código válido (1-99999)", vbInformation, "Alumnos")
                txtCodigo.SelectAll()
                txtCodigo.Focus()
            ElseIf CInt(txtCodigo.Text) < 1 Then
                MsgBox("Introduzca un código válido (1-99999)", vbInformation, "Alumnos")
                txtCodigo.SelectAll()
                txtCodigo.Focus()
            ElseIf Trim(txtNIF.Text = "") Then
                MsgBox("Introduzca un NIF", vbInformation, "Alumnos")
                txtNIF.SelectAll()
                txtNIF.Focus()
            ElseIf Trim(txtNIF.Text).Length < 9 Then
                MsgBox("Introduzca un NIF válido", vbInformation, "Alumnos")
                txtNIF.SelectAll()
                txtNIF.Focus()
            ElseIf Not IsNumeric(txtNIF.Text.Substring(0, 8)) Then
                MsgBox("Introduzca un NIF válido", vbInformation, "Alumnos")
                txtNIF.SelectAll()
                txtNIF.Focus()
            ElseIf Not letraCorrecta(txtNIF.Text) Then
                MsgBox("La letra del NIF no es correcta", vbInformation, "Alumnos")
                txtNIF.SelectAll()
                txtNIF.Focus()
            ElseIf Trim(txtNombre.Text) = "" Then
                MsgBox("Introduzca un nombre válido", vbInformation, "Alumnos")
                txtNombre.Focus()
            Else
                ficAlumnos = FreeFile()
                FileOpen(ficAlumnos, rutAlumnos, OpenMode.Input)
                ficTemporal = FreeFile()
                FileOpen(ficTemporal, rutTemporal, OpenMode.Output)
                For i As Integer = 0 To totalRegistros - 1
                    Input(ficAlumnos, codAlu)   'leemos el codigo
                    Input(ficAlumnos, nifAlu)   'leemos el nif
                    Input(ficAlumnos, nomAlu)   'leemos el nombre
                    Input(ficAlumnos, fechaAlu) 'leemos la fecha de ingreso
                    Input(ficAlumnos, curAlu)   'leemos el curso del alumno
                    Input(ficAlumnos, sexAlu)   'leemos el sexo del alumno
                    If codAlu <> codigoAGuardar Then
                        WriteLine(ficTemporal, codAlu, nifAlu, nomAlu, fechaAlu, curAlu, sexAlu)
                    Else
                        WriteLine(ficTemporal, CInt(txtCodigo.Text), txtNIF.Text, txtNombre.Text, CDate(dtpFecha.Text), cmbCurso.SelectedItem, cmbSexo.SelectedItem)
                    End If
                Next

                FileClose(ficTemporal) 'cerramos los ficheros
                FileClose(ficAlumnos)
                Kill(rutAlumnos)
                Rename(rutTemporal, rutAlumnos) 'borramos el viejo archivo y lo sustituimos por el nuevo con los cambios realizados

                btnNuevo.Enabled = True
                btnBuscar.Enabled = True
                btnBorrar.Enabled = True
                btnEditar.Enabled = True
                btnExportar.Enabled = True
                deshabilitar("cajasTexto")
                deshabilitar("confirmacion")
                habilitar("desplazamiento")
                lblDesplazamiento.Visible = True
                leer()
            End If
        End If
        'lblDesplazamiento.Text = "Registro " & (registroActual + 1) & " de " & totalRegistros
        'deshabilitar("confirmacion")
        'habilitar("desplazamiento")
        'habilitar("operaciones")
        'lblDesplazamiento.Visible = True


    End Sub

    Private Sub txtCodigo_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCodigo.KeyPress
        'control de teclas pulsadas para el codigo
        If InStr("0123456789" & Chr(8), e.KeyChar) = 0 Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtNIF_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtNIF.KeyPress
        If InStr("0123456789TRWAGMYFPDXBNJZSQVHLCKE" & Chr(8), e.KeyChar) = 0 Then
            e.Handled = True
        End If
    End Sub


    Private Sub btnNo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNo.Click
        If FileLen(rutAlumnos) = 0 Then
            'si el archivo de alumnos está vacío, deshabilitamos lo innecesario
            grbDesplazamiento.Enabled = False
            btnNuevo.Enabled = True
            btnBuscar.Enabled = False
            btnBorrar.Enabled = False
            btnEditar.Enabled = False
            btnExportar.Enabled = False
            deshabilitar("cajasTexto")
            deshabilitar("confirmacion")
        Else
            btnNuevo.Enabled = True
            btnBuscar.Enabled = True
            btnBorrar.Enabled = True
            btnEditar.Enabled = True
            btnExportar.Enabled = True
            deshabilitar("cajasTexto")
            leer()
            habilitar("desplazamiento")
            deshabilitar("confirmacion")
            lblDesplazamiento.Visible = True
        End If

    End Sub
    Sub leer()
        'rutina para leer el registro pertinente
        ficAlumnos = FreeFile()
        FileOpen(ficAlumnos, rutAlumnos, OpenMode.Input)
        For i As Integer = 0 To registroActual
            Input(ficAlumnos, codAlu)   'leemos el codigo
            Input(ficAlumnos, nifAlu)   'leemos el nif
            Input(ficAlumnos, nomAlu)   'leemos el nombre
            Input(ficAlumnos, fechaAlu) 'leemos la fecha de ingreso
            Input(ficAlumnos, curAlu)   'leemos el curso del alumno
            Input(ficAlumnos, sexAlu)   'leemos el sexo del alumno
        Next
        FileClose(ficAlumnos)
        txtCodigo.Text = codAlu
        txtNIF.Text = nifAlu
        txtNombre.Text = nomAlu
        dtpFecha.Text = fechaAlu
        Select Case curAlu
            Case "ASD-1"
                cmbCurso.SelectedIndex = 0
            Case "ASD-2"
                cmbCurso.SelectedIndex = 1
            Case "ADF-1"
                cmbCurso.SelectedIndex = 2
            Case "ADF-2"
                cmbCurso.SelectedIndex = 3
            Case "DAM-1"
                cmbCurso.SelectedIndex = 4
            Case "DAM-2"
                cmbCurso.SelectedIndex = 5
        End Select
        If sexAlu = "V" Then
            cmbSexo.SelectedIndex = 0
        Else
            cmbSexo.SelectedIndex = 1
        End If
        lblDesplazamiento.Text = "Registro " & (registroActual + 1) & " de " & totalRegistros
        If totalRegistros = 1 Then
            grbDesplazamiento.Enabled = False
        End If
        If registroActual = 0 And totalRegistros = 2 Then 'comprobacion para que cuando tengamos un registro y añadamos uno, se habiliten los botones necesarios
            btnSiguiente.Enabled = True
            btnUltimo.Enabled = True
        ElseIf totalRegistros = 1 Then
            btnPrimero.Enabled = False
            btnAnterior.Enabled = False
            lblDesplazamiento.Text = "Registro 1 de 1"
        End If
    End Sub

    Private Sub btnSiguiente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSiguiente.Click
        registroActual = registroActual + 1
        If registroActual = totalRegistros - 1 Then
            btnUltimo.Enabled = False
            btnSiguiente.Enabled = False
        End If
        btnAnterior.Enabled = True
        btnPrimero.Enabled = True
        leer()
    End Sub

    Private Sub btnAnterior_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAnterior.Click
        registroActual = registroActual - 1
        If registroActual = 0 Then
            btnPrimero.Enabled = False
            btnAnterior.Enabled = False
        End If
        btnSiguiente.Enabled = True
        btnUltimo.Enabled = True
        leer()
    End Sub

    Private Sub btnPrimero_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrimero.Click
        btnPrimero.Enabled = False
        btnAnterior.Enabled = False
        btnSiguiente.Enabled = True
        btnUltimo.Enabled = True
        registroActual = 0
        leer()
    End Sub

    Private Sub btnUltimo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUltimo.Click
        btnUltimo.Enabled = False
        btnSiguiente.Enabled = False
        btnAnterior.Enabled = True
        btnPrimero.Enabled = True
        registroActual = totalRegistros - 1
        leer()
    End Sub

    Private Sub txtNombre_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtNombre.KeyPress
        'Solo numeros  y letra en mayuscula para o nombre
        If InStr(Chr(8) & "QWERTYUIOPLKJHGFDSAZXCVBNMÑÁÉÍÓÚ" & "qwertyuioplkjhgfdsazxcvbnñmáéíóú" & " ", e.KeyChar) = 0 Then
            e.KeyChar = Chr(0)
        End If
    End Sub

    Private Sub btnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscar.Click
        'Dim contadorTextBox As Integer = 0
        operacionActual = "Buscar"
        limpiar()
        habilitar("confirmacion")
        deshabilitar("desplazamiento")
        deshabilitar("operaciones")
        habilitar("cajasTexto")
        txtNombre.Enabled = False 'deshabilitamos las cajas de texto innecesarias
        dtpFecha.Enabled = False
        cmbCurso.Enabled = False
        cmbSexo.Enabled = False
        txtCodigo.Focus()
        
    End Sub
    Sub buscarPorCodigo(ByVal codigo)
        Dim encontrado As Boolean = False
        'abrimos o arquivo de input para poder leelo
        ficAlumnos = FreeFile()
        FileOpen(ficAlumnos, rutAlumnos, OpenMode.Input)
        'abrimos el archivo y leemos de el hasta que no sea final de archivo
        For i As Integer = 0 To totalRegistros - 1
            'ahora vamos a leer os rexitros
            Input(ficAlumnos, codAlu)       'leemos el codigo
            Input(ficAlumnos, nifAlu)       'leemos el NIF
            Input(ficAlumnos, nomAlu)    'leemos el nombre
            Input(ficAlumnos, fechaAlu)     'leemos la fecha de ingreso
            Input(ficAlumnos, curAlu)       'leemos el curso
            Input(ficAlumnos, sexAlu)       'leemos el sexo
            'ahora vamos a ir comprobando ha encontradoo un registro con ese codigo
            If codAlu = CInt(codigo) Then
                encontrado = True
                registroActual = i
                Select Case curAlu
                    Case "ASD-1"
                        cmbCurso.SelectedIndex = 0
                    Case "ASD-2"
                        cmbCurso.SelectedIndex = 1
                    Case "ADF-1"
                        cmbCurso.SelectedIndex = 2
                    Case "ADF-2"
                        cmbCurso.SelectedIndex = 3
                    Case "DAM-1"
                        cmbCurso.SelectedIndex = 4
                    Case "DAM-2"
                        cmbCurso.SelectedIndex = 5
                End Select
                txtCodigo.Text = codAlu
                txtNIF.Text = nifAlu
                txtNombre.Text = nomAlu
                dtpFecha.Value = fechaAlu
                If sexAlu = "V" Then
                    cmbSexo.SelectedIndex = 0
                Else
                    cmbSexo.SelectedIndex = 1
                End If
                txtCodigo.SelectAll()
                txtCodigo.Focus()
                
                Exit For
                
            End If
            
        Next
        If registroActual = totalRegistros - 1 Then
            btnAnterior.Enabled = True
            btnPrimero.Enabled = True
            btnSiguiente.Enabled = False
            btnUltimo.Enabled = False
        ElseIf registroActual = 0 Then
            deshabilitar("botonesDeRetroceso")
        End If
        FileClose(ficAlumnos) 'cerramos el archivo
        If Not encontrado Then 'si no encontramos un registro con el codigo que hemos buscado
            MsgBox("No se ha encontrado el registro con código " & codigo, vbInformation, "Buscar")
            txtCodigo.SelectAll()
            txtCodigo.Focus()
            leer()
        End If
        deshabilitar("cajasTexto")

    End Sub

    Sub buscarPorNIF(ByVal codigo)
        Dim encontrado As Boolean = False
        'abrimos o arquivo de input para poder leelo
        ficAlumnos = FreeFile()
        FileOpen(ficAlumnos, rutAlumnos, OpenMode.Input)
        'abrimos el archivo y leemos de el hasta que no sea final de archivo
        For i As Integer = 0 To totalRegistros - 1
            'ahora vamos a leer os rexitros
            Input(ficAlumnos, codAlu)       'leemos el codigo
            Input(ficAlumnos, nifAlu)       'leemos el NIF
            Input(ficAlumnos, nomAlu)    'leemos el nombre
            Input(ficAlumnos, fechaAlu)     'leemos la fecha de ingreso
            Input(ficAlumnos, curAlu)       'leemos el curso
            Input(ficAlumnos, sexAlu)       'leemos el sexo
            'ahora vamos a ir comprobando ha encontradoo un registro con ese codigo
            If nifAlu = codigo Then
                encontrado = True
                registroActual = i
                Select Case curAlu
                    Case "ASD-1"
                        cmbCurso.SelectedIndex = 0
                    Case "ASD-2"
                        cmbCurso.SelectedIndex = 1
                    Case "ADF-1"
                        cmbCurso.SelectedIndex = 2
                    Case "ADF-2"
                        cmbCurso.SelectedIndex = 3
                    Case "DAM-1"
                        cmbCurso.SelectedIndex = 4
                    Case "DAM-2"
                        cmbCurso.SelectedIndex = 5
                End Select
                txtCodigo.Text = codAlu
                txtNIF.Text = nifAlu
                txtNombre.Text = nomAlu
                dtpFecha.Value = fechaAlu
                If sexAlu = "V" Then
                    cmbSexo.SelectedIndex = 0
                Else
                    cmbSexo.SelectedIndex = 1
                End If
                txtCodigo.SelectAll()
                txtCodigo.Focus()
                Exit For

            End If
        Next
        If registroActual = totalRegistros - 1 Then
            btnAnterior.Enabled = True
            btnPrimero.Enabled = True
            btnSiguiente.Enabled = False
            btnUltimo.Enabled = False
        ElseIf registroActual = 0 Then
            deshabilitar("botonesDeRetroceso")
        End If
        FileClose(ficAlumnos) 'cerramos el archivo
        If Not encontrado Then 'si no encontramos un registro con el codigo que hemos buscado
            MsgBox("No se ha encontrado el registro con NIF " & codigo, vbInformation, "Buscar")
            txtCodigo.SelectAll()
            txtCodigo.Focus()
        End If
        deshabilitar("cajasTexto")

    End Sub

    Private Sub btnBorrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBorrar.Click
        If MsgBox("Está seguro que desea borrar el registro actual?", vbInformation + vbYesNo, "Borrar") = vbYes Then
            Dim registroABorrar As Integer = CInt(txtCodigo.Text)
            'abrimos o arquivo de input para poder leelo
            ficAlumnos = FreeFile()
            FileOpen(ficAlumnos, rutAlumnos, OpenMode.Input)
            ficTemporal = FreeFile()
            FileOpen(ficTemporal, rutTemporal, OpenMode.Output)
            'abrimos el archivo y leemos de el   hasta que no sea final de archivo
            For i As Integer = 0 To totalRegistros - 1
                'ahora vamos a leer os rexitros
                Input(ficAlumnos, codAlu)       'leemos el codigo
                Input(ficAlumnos, nifAlu)       'leemos el NIF
                Input(ficAlumnos, nomAlu)       'leemos el nombre
                Input(ficAlumnos, fechaAlu)     'leemos la fecha de ingreso
                Input(ficAlumnos, curAlu)       'leemos el curso    
                Input(ficAlumnos, sexAlu)       'leemos el sexo
                'ahora vamos a ir comprobando ha encontrado un registro con ese codigo
                If codAlu <> registroABorrar Then
                    WriteLine(ficTemporal, codAlu, nifAlu, nomAlu, fechaAlu, curAlu, sexAlu)
                End If
            Next
            FileClose(ficTemporal)
            FileClose(ficAlumnos) 'cerramos los archivos
            Kill(rutAlumnos)
            Rename(rutTemporal, rutAlumnos) 'borramos el viejo archivo y lo sustituimos por el nuevo con los cambios realizados
            totalRegistros = totalRegistros - 1

            If totalRegistros = 0 Then
                limpiar()
                deshabilitar("desplazamiento")
                lblDesplazamiento.Text = ""
                grbDesplazamiento.Enabled = False
                'deshabilitar("Nuevo")
                btnBuscar.Enabled = False
                btnBorrar.Enabled = False
                btnEditar.Enabled = False
                btnExportar.Enabled = False
            ElseIf totalRegistros = 1 Then
                deshabilitar("desplazamiento")
                lblDesplazamiento.Text = "Registro 1 de 1"
                leer()
            Else
                If (registroActual > 1) Then
                    registroActual = registroActual - 1
                End If
                lblDesplazamiento.Text = "Registro " & (registroActual + 1) & " de " & totalRegistros
                leer()
            End If

        End If
    End Sub

    Private Sub btnEditar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEditar.Click
        'procesos al pulsar el boton editar
        codigoAGuardar = CInt(txtCodigo.Text)
        operacionActual = "editar"
        habilitar("cajasTexto")
        habilitar("confirmacion")
        deshabilitar("operaciones")
        deshabilitar("desplazamiento")
        txtCodigo.Enabled = False
    End Sub

    Private Sub btnExportar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExportar.Click
        frmExportar.ShowDialog()
    End Sub
End Class