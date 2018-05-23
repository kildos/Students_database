<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmExportar
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
        Me.btnCSV = New System.Windows.Forms.Button()
        Me.btnTxt = New System.Windows.Forms.Button()
        Me.grbArchivotxt = New System.Windows.Forms.GroupBox()
        Me.cmbOrdenacion = New System.Windows.Forms.ComboBox()
        Me.lblOrdenacion = New System.Windows.Forms.Label()
        Me.radAscendente = New System.Windows.Forms.RadioButton()
        Me.radDescentente = New System.Windows.Forms.RadioButton()
        Me.grbArchivotxt.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnCSV
        '
        Me.btnCSV.Location = New System.Drawing.Point(150, 30)
        Me.btnCSV.Name = "btnCSV"
        Me.btnCSV.Size = New System.Drawing.Size(109, 28)
        Me.btnCSV.TabIndex = 0
        Me.btnCSV.Text = "Archivo CSV"
        Me.btnCSV.UseVisualStyleBackColor = True
        '
        'btnTxt
        '
        Me.btnTxt.Location = New System.Drawing.Point(79, 121)
        Me.btnTxt.Name = "btnTxt"
        Me.btnTxt.Size = New System.Drawing.Size(109, 28)
        Me.btnTxt.TabIndex = 1
        Me.btnTxt.Text = "Exportar"
        Me.btnTxt.UseVisualStyleBackColor = True
        '
        'grbArchivotxt
        '
        Me.grbArchivotxt.Controls.Add(Me.radDescentente)
        Me.grbArchivotxt.Controls.Add(Me.radAscendente)
        Me.grbArchivotxt.Controls.Add(Me.lblOrdenacion)
        Me.grbArchivotxt.Controls.Add(Me.cmbOrdenacion)
        Me.grbArchivotxt.Controls.Add(Me.btnTxt)
        Me.grbArchivotxt.Location = New System.Drawing.Point(71, 76)
        Me.grbArchivotxt.Name = "grbArchivotxt"
        Me.grbArchivotxt.Size = New System.Drawing.Size(267, 165)
        Me.grbArchivotxt.TabIndex = 2
        Me.grbArchivotxt.TabStop = False
        Me.grbArchivotxt.Text = "Archivo TXT"
        '
        'cmbOrdenacion
        '
        Me.cmbOrdenacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbOrdenacion.FormattingEnabled = True
        Me.cmbOrdenacion.Items.AddRange(New Object() {"Codigo", "Nombre", "Fecha alta"})
        Me.cmbOrdenacion.Location = New System.Drawing.Point(119, 31)
        Me.cmbOrdenacion.Name = "cmbOrdenacion"
        Me.cmbOrdenacion.Size = New System.Drawing.Size(121, 24)
        Me.cmbOrdenacion.TabIndex = 2
        '
        'lblOrdenacion
        '
        Me.lblOrdenacion.AutoSize = True
        Me.lblOrdenacion.Location = New System.Drawing.Point(27, 34)
        Me.lblOrdenacion.Name = "lblOrdenacion"
        Me.lblOrdenacion.Size = New System.Drawing.Size(86, 17)
        Me.lblOrdenacion.TabIndex = 3
        Me.lblOrdenacion.Text = "Ordenar por"
        '
        'radAscendente
        '
        Me.radAscendente.AutoSize = True
        Me.radAscendente.Location = New System.Drawing.Point(76, 61)
        Me.radAscendente.Name = "radAscendente"
        Me.radAscendente.Size = New System.Drawing.Size(104, 21)
        Me.radAscendente.TabIndex = 4
        Me.radAscendente.TabStop = True
        Me.radAscendente.Text = "Ascendente"
        Me.radAscendente.UseVisualStyleBackColor = True
        '
        'radDescentente
        '
        Me.radDescentente.AutoSize = True
        Me.radDescentente.Location = New System.Drawing.Point(76, 88)
        Me.radDescentente.Name = "radDescentente"
        Me.radDescentente.Size = New System.Drawing.Size(113, 21)
        Me.radDescentente.TabIndex = 5
        Me.radDescentente.TabStop = True
        Me.radDescentente.Text = "Descendente"
        Me.radDescentente.UseVisualStyleBackColor = True
        '
        'frmExportar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(408, 253)
        Me.Controls.Add(Me.grbArchivotxt)
        Me.Controls.Add(Me.btnCSV)
        Me.Name = "frmExportar"
        Me.Text = "frmExportar"
        Me.grbArchivotxt.ResumeLayout(False)
        Me.grbArchivotxt.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnCSV As System.Windows.Forms.Button
    Friend WithEvents btnTxt As System.Windows.Forms.Button
    Friend WithEvents grbArchivotxt As System.Windows.Forms.GroupBox
    Friend WithEvents radDescentente As System.Windows.Forms.RadioButton
    Friend WithEvents radAscendente As System.Windows.Forms.RadioButton
    Friend WithEvents lblOrdenacion As System.Windows.Forms.Label
    Friend WithEvents cmbOrdenacion As System.Windows.Forms.ComboBox
End Class
