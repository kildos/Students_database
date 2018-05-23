<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAlumnos
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.txtCodigo = New System.Windows.Forms.TextBox()
        Me.lblCodigo = New System.Windows.Forms.Label()
        Me.txtNIF = New System.Windows.Forms.TextBox()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.lblNIF = New System.Windows.Forms.Label()
        Me.lblNombre = New System.Windows.Forms.Label()
        Me.dtpFecha = New System.Windows.Forms.DateTimePicker()
        Me.cmbCurso = New System.Windows.Forms.ComboBox()
        Me.cmbSexo = New System.Windows.Forms.ComboBox()
        Me.lblFecha = New System.Windows.Forms.Label()
        Me.lblCurso = New System.Windows.Forms.Label()
        Me.lblSexo = New System.Windows.Forms.Label()
        Me.btnNuevo = New System.Windows.Forms.Button()
        Me.btnBorrar = New System.Windows.Forms.Button()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.btnEditar = New System.Windows.Forms.Button()
        Me.btnExportar = New System.Windows.Forms.Button()
        Me.grbOperaciones = New System.Windows.Forms.GroupBox()
        Me.grbConfirmacion = New System.Windows.Forms.GroupBox()
        Me.btnNo = New System.Windows.Forms.Button()
        Me.btnSi = New System.Windows.Forms.Button()
        Me.grbDesplazamiento = New System.Windows.Forms.GroupBox()
        Me.lblDesplazamiento = New System.Windows.Forms.Label()
        Me.btnUltimo = New System.Windows.Forms.Button()
        Me.btnSiguiente = New System.Windows.Forms.Button()
        Me.btnAnterior = New System.Windows.Forms.Button()
        Me.btnPrimero = New System.Windows.Forms.Button()
        Me.grbOperaciones.SuspendLayout()
        Me.grbConfirmacion.SuspendLayout()
        Me.grbDesplazamiento.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtCodigo
        '
        Me.txtCodigo.Enabled = False
        Me.txtCodigo.Location = New System.Drawing.Point(108, 40)
        Me.txtCodigo.MaxLength = 5
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.Size = New System.Drawing.Size(101, 22)
        Me.txtCodigo.TabIndex = 0
        Me.txtCodigo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblCodigo
        '
        Me.lblCodigo.AutoSize = True
        Me.lblCodigo.Location = New System.Drawing.Point(24, 43)
        Me.lblCodigo.Name = "lblCodigo"
        Me.lblCodigo.Size = New System.Drawing.Size(52, 17)
        Me.lblCodigo.TabIndex = 1
        Me.lblCodigo.Text = "Código"
        '
        'txtNIF
        '
        Me.txtNIF.Enabled = False
        Me.txtNIF.Location = New System.Drawing.Point(108, 80)
        Me.txtNIF.MaxLength = 9
        Me.txtNIF.Name = "txtNIF"
        Me.txtNIF.Size = New System.Drawing.Size(121, 22)
        Me.txtNIF.TabIndex = 2
        '
        'txtNombre
        '
        Me.txtNombre.Enabled = False
        Me.txtNombre.Location = New System.Drawing.Point(108, 120)
        Me.txtNombre.MaxLength = 50
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(181, 22)
        Me.txtNombre.TabIndex = 3
        '
        'lblNIF
        '
        Me.lblNIF.AutoSize = True
        Me.lblNIF.Location = New System.Drawing.Point(24, 83)
        Me.lblNIF.Name = "lblNIF"
        Me.lblNIF.Size = New System.Drawing.Size(29, 17)
        Me.lblNIF.TabIndex = 4
        Me.lblNIF.Text = "NIF"
        '
        'lblNombre
        '
        Me.lblNombre.AutoSize = True
        Me.lblNombre.Location = New System.Drawing.Point(24, 123)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(58, 17)
        Me.lblNombre.TabIndex = 5
        Me.lblNombre.Text = "Nombre"
        '
        'dtpFecha
        '
        Me.dtpFecha.Enabled = False
        Me.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFecha.Location = New System.Drawing.Point(140, 160)
        Me.dtpFecha.Name = "dtpFecha"
        Me.dtpFecha.Size = New System.Drawing.Size(110, 22)
        Me.dtpFecha.TabIndex = 6
        '
        'cmbCurso
        '
        Me.cmbCurso.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbCurso.Enabled = False
        Me.cmbCurso.FormattingEnabled = True
        Me.cmbCurso.Items.AddRange(New Object() {"ASD-1", "ASD-2", "ADF-1", "ADF-2", "DAM-1", "DAM-2"})
        Me.cmbCurso.Location = New System.Drawing.Point(108, 200)
        Me.cmbCurso.Name = "cmbCurso"
        Me.cmbCurso.Size = New System.Drawing.Size(121, 24)
        Me.cmbCurso.TabIndex = 7
        '
        'cmbSexo
        '
        Me.cmbSexo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbSexo.Enabled = False
        Me.cmbSexo.FormattingEnabled = True
        Me.cmbSexo.Items.AddRange(New Object() {"V", "M"})
        Me.cmbSexo.Location = New System.Drawing.Point(108, 240)
        Me.cmbSexo.Name = "cmbSexo"
        Me.cmbSexo.Size = New System.Drawing.Size(121, 24)
        Me.cmbSexo.TabIndex = 8
        '
        'lblFecha
        '
        Me.lblFecha.AutoSize = True
        Me.lblFecha.Location = New System.Drawing.Point(24, 163)
        Me.lblFecha.Name = "lblFecha"
        Me.lblFecha.Size = New System.Drawing.Size(98, 17)
        Me.lblFecha.TabIndex = 9
        Me.lblFecha.Text = "Fecha ingreso"
        '
        'lblCurso
        '
        Me.lblCurso.AutoSize = True
        Me.lblCurso.Location = New System.Drawing.Point(24, 203)
        Me.lblCurso.Name = "lblCurso"
        Me.lblCurso.Size = New System.Drawing.Size(45, 17)
        Me.lblCurso.TabIndex = 10
        Me.lblCurso.Text = "Curso"
        '
        'lblSexo
        '
        Me.lblSexo.AutoSize = True
        Me.lblSexo.Location = New System.Drawing.Point(24, 243)
        Me.lblSexo.Name = "lblSexo"
        Me.lblSexo.Size = New System.Drawing.Size(39, 17)
        Me.lblSexo.TabIndex = 11
        Me.lblSexo.Text = "Sexo"
        '
        'btnNuevo
        '
        Me.btnNuevo.Location = New System.Drawing.Point(58, 31)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(75, 23)
        Me.btnNuevo.TabIndex = 12
        Me.btnNuevo.Text = "Nuevo"
        Me.btnNuevo.UseVisualStyleBackColor = True
        '
        'btnBorrar
        '
        Me.btnBorrar.Location = New System.Drawing.Point(58, 110)
        Me.btnBorrar.Name = "btnBorrar"
        Me.btnBorrar.Size = New System.Drawing.Size(75, 23)
        Me.btnBorrar.TabIndex = 13
        Me.btnBorrar.Text = "Borrar"
        Me.btnBorrar.UseVisualStyleBackColor = True
        '
        'btnBuscar
        '
        Me.btnBuscar.Location = New System.Drawing.Point(58, 70)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(75, 23)
        Me.btnBuscar.TabIndex = 14
        Me.btnBuscar.Text = "Buscar"
        Me.btnBuscar.UseVisualStyleBackColor = True
        '
        'btnEditar
        '
        Me.btnEditar.Location = New System.Drawing.Point(58, 152)
        Me.btnEditar.Name = "btnEditar"
        Me.btnEditar.Size = New System.Drawing.Size(75, 23)
        Me.btnEditar.TabIndex = 15
        Me.btnEditar.Text = "Editar"
        Me.btnEditar.UseVisualStyleBackColor = True
        '
        'btnExportar
        '
        Me.btnExportar.Location = New System.Drawing.Point(58, 190)
        Me.btnExportar.Name = "btnExportar"
        Me.btnExportar.Size = New System.Drawing.Size(75, 23)
        Me.btnExportar.TabIndex = 16
        Me.btnExportar.Text = "Exportar"
        Me.btnExportar.UseVisualStyleBackColor = True
        '
        'grbOperaciones
        '
        Me.grbOperaciones.Controls.Add(Me.btnEditar)
        Me.grbOperaciones.Controls.Add(Me.btnExportar)
        Me.grbOperaciones.Controls.Add(Me.btnNuevo)
        Me.grbOperaciones.Controls.Add(Me.btnBorrar)
        Me.grbOperaciones.Controls.Add(Me.btnBuscar)
        Me.grbOperaciones.Location = New System.Drawing.Point(356, 29)
        Me.grbOperaciones.Name = "grbOperaciones"
        Me.grbOperaciones.Size = New System.Drawing.Size(191, 235)
        Me.grbOperaciones.TabIndex = 17
        Me.grbOperaciones.TabStop = False
        Me.grbOperaciones.Text = "Operaciones"
        '
        'grbConfirmacion
        '
        Me.grbConfirmacion.Controls.Add(Me.btnNo)
        Me.grbConfirmacion.Controls.Add(Me.btnSi)
        Me.grbConfirmacion.Enabled = False
        Me.grbConfirmacion.Location = New System.Drawing.Point(347, 282)
        Me.grbConfirmacion.Name = "grbConfirmacion"
        Me.grbConfirmacion.Size = New System.Drawing.Size(200, 100)
        Me.grbConfirmacion.TabIndex = 18
        Me.grbConfirmacion.TabStop = False
        Me.grbConfirmacion.Text = "Confirmación"
        '
        'btnNo
        '
        Me.btnNo.Location = New System.Drawing.Point(67, 60)
        Me.btnNo.Name = "btnNo"
        Me.btnNo.Size = New System.Drawing.Size(75, 23)
        Me.btnNo.TabIndex = 1
        Me.btnNo.Text = "Cancelar"
        Me.btnNo.UseVisualStyleBackColor = True
        '
        'btnSi
        '
        Me.btnSi.Location = New System.Drawing.Point(67, 21)
        Me.btnSi.Name = "btnSi"
        Me.btnSi.Size = New System.Drawing.Size(75, 23)
        Me.btnSi.TabIndex = 0
        Me.btnSi.Text = "Aceptar"
        Me.btnSi.UseVisualStyleBackColor = True
        '
        'grbDesplazamiento
        '
        Me.grbDesplazamiento.Controls.Add(Me.lblDesplazamiento)
        Me.grbDesplazamiento.Controls.Add(Me.btnUltimo)
        Me.grbDesplazamiento.Controls.Add(Me.btnSiguiente)
        Me.grbDesplazamiento.Controls.Add(Me.btnAnterior)
        Me.grbDesplazamiento.Controls.Add(Me.btnPrimero)
        Me.grbDesplazamiento.Location = New System.Drawing.Point(27, 291)
        Me.grbDesplazamiento.Name = "grbDesplazamiento"
        Me.grbDesplazamiento.Size = New System.Drawing.Size(302, 110)
        Me.grbDesplazamiento.TabIndex = 19
        Me.grbDesplazamiento.TabStop = False
        Me.grbDesplazamiento.Text = "Desplazamiento"
        '
        'lblDesplazamiento
        '
        Me.lblDesplazamiento.Location = New System.Drawing.Point(43, 80)
        Me.lblDesplazamiento.Name = "lblDesplazamiento"
        Me.lblDesplazamiento.Size = New System.Drawing.Size(231, 23)
        Me.lblDesplazamiento.TabIndex = 4
        '
        'btnUltimo
        '
        Me.btnUltimo.Location = New System.Drawing.Point(226, 32)
        Me.btnUltimo.Name = "btnUltimo"
        Me.btnUltimo.Size = New System.Drawing.Size(40, 40)
        Me.btnUltimo.TabIndex = 3
        Me.btnUltimo.Text = ">|"
        Me.btnUltimo.UseVisualStyleBackColor = True
        '
        'btnSiguiente
        '
        Me.btnSiguiente.Location = New System.Drawing.Point(166, 32)
        Me.btnSiguiente.Name = "btnSiguiente"
        Me.btnSiguiente.Size = New System.Drawing.Size(40, 40)
        Me.btnSiguiente.TabIndex = 2
        Me.btnSiguiente.Text = ">"
        Me.btnSiguiente.UseVisualStyleBackColor = True
        '
        'btnAnterior
        '
        Me.btnAnterior.Location = New System.Drawing.Point(106, 32)
        Me.btnAnterior.Name = "btnAnterior"
        Me.btnAnterior.Size = New System.Drawing.Size(40, 40)
        Me.btnAnterior.TabIndex = 1
        Me.btnAnterior.Text = "<"
        Me.btnAnterior.UseVisualStyleBackColor = True
        '
        'btnPrimero
        '
        Me.btnPrimero.Location = New System.Drawing.Point(46, 32)
        Me.btnPrimero.Name = "btnPrimero"
        Me.btnPrimero.Size = New System.Drawing.Size(40, 40)
        Me.btnPrimero.TabIndex = 0
        Me.btnPrimero.Text = "|<"
        Me.btnPrimero.UseVisualStyleBackColor = True
        '
        'frmAlumnos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(589, 426)
        Me.Controls.Add(Me.grbDesplazamiento)
        Me.Controls.Add(Me.grbConfirmacion)
        Me.Controls.Add(Me.grbOperaciones)
        Me.Controls.Add(Me.lblSexo)
        Me.Controls.Add(Me.lblCurso)
        Me.Controls.Add(Me.lblFecha)
        Me.Controls.Add(Me.cmbSexo)
        Me.Controls.Add(Me.cmbCurso)
        Me.Controls.Add(Me.dtpFecha)
        Me.Controls.Add(Me.lblNombre)
        Me.Controls.Add(Me.lblNIF)
        Me.Controls.Add(Me.txtNombre)
        Me.Controls.Add(Me.txtNIF)
        Me.Controls.Add(Me.lblCodigo)
        Me.Controls.Add(Me.txtCodigo)
        Me.Name = "frmAlumnos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Alumnos"
        Me.grbOperaciones.ResumeLayout(False)
        Me.grbConfirmacion.ResumeLayout(False)
        Me.grbDesplazamiento.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtCodigo As System.Windows.Forms.TextBox
    Friend WithEvents lblCodigo As System.Windows.Forms.Label
    Friend WithEvents txtNIF As System.Windows.Forms.TextBox
    Friend WithEvents txtNombre As System.Windows.Forms.TextBox
    Friend WithEvents lblNIF As System.Windows.Forms.Label
    Friend WithEvents lblNombre As System.Windows.Forms.Label
    Friend WithEvents dtpFecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents cmbCurso As System.Windows.Forms.ComboBox
    Friend WithEvents cmbSexo As System.Windows.Forms.ComboBox
    Friend WithEvents lblFecha As System.Windows.Forms.Label
    Friend WithEvents lblCurso As System.Windows.Forms.Label
    Friend WithEvents lblSexo As System.Windows.Forms.Label
    Friend WithEvents btnNuevo As System.Windows.Forms.Button
    Friend WithEvents btnBorrar As System.Windows.Forms.Button
    Friend WithEvents btnBuscar As System.Windows.Forms.Button
    Friend WithEvents btnEditar As System.Windows.Forms.Button
    Friend WithEvents btnExportar As System.Windows.Forms.Button
    Friend WithEvents grbOperaciones As System.Windows.Forms.GroupBox
    Friend WithEvents grbConfirmacion As System.Windows.Forms.GroupBox
    Friend WithEvents btnNo As System.Windows.Forms.Button
    Friend WithEvents btnSi As System.Windows.Forms.Button
    Friend WithEvents grbDesplazamiento As System.Windows.Forms.GroupBox
    Friend WithEvents btnUltimo As System.Windows.Forms.Button
    Friend WithEvents btnSiguiente As System.Windows.Forms.Button
    Friend WithEvents btnAnterior As System.Windows.Forms.Button
    Friend WithEvents btnPrimero As System.Windows.Forms.Button
    Friend WithEvents lblDesplazamiento As System.Windows.Forms.Label

End Class
