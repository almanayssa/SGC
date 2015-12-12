<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmConsultaActividadRecurrente
    Inherits SGC_CS.frmPadre

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.SgcGroupBox1 = New SGC_CS.SGCGroupBox(Me.components)
        Me.dtpFecFin = New SGC_CS.SGCDateTimePicker(Me.components)
        Me.SgcLabel3 = New SGC_CS.SGCLabel(Me.components)
        Me.dtpFecInicio = New SGC_CS.SGCDateTimePicker(Me.components)
        Me.btnBuscar = New SGC_CS.SGCButton(Me.components)
        Me.SgcLabel2 = New SGC_CS.SGCLabel(Me.components)
        Me.cboComite = New SGC_CS.SGCComboBox(Me.components)
        Me.SgcLabel1 = New SGC_CS.SGCLabel(Me.components)
        Me.lblTitulo = New SGC_CS.SGCLabel(Me.components)
        Me.cfiVacantes = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cfiPago = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cfiFecFin = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cfiFecInicio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cfiCategoria = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cfiTipo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cfiNombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvTodas = New SGC_CS.SGCDataGridView(Me.components)
        Me.ctoNombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ctoTipo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ctoCategoria = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ctoFecInicio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ctoFecFin = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ctoPago = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ctoVacantes = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ctoEstado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SgcGroupBox1.SuspendLayout()
        CType(Me.dgvTodas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SgcGroupBox1
        '
        Me.SgcGroupBox1.Controls.Add(Me.dtpFecFin)
        Me.SgcGroupBox1.Controls.Add(Me.SgcLabel3)
        Me.SgcGroupBox1.Controls.Add(Me.dtpFecInicio)
        Me.SgcGroupBox1.Controls.Add(Me.btnBuscar)
        Me.SgcGroupBox1.Controls.Add(Me.SgcLabel2)
        Me.SgcGroupBox1.Controls.Add(Me.cboComite)
        Me.SgcGroupBox1.Controls.Add(Me.SgcLabel1)
        Me.SgcGroupBox1.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SgcGroupBox1.Location = New System.Drawing.Point(60, 70)
        Me.SgcGroupBox1.Name = "SgcGroupBox1"
        Me.SgcGroupBox1.Size = New System.Drawing.Size(900, 99)
        Me.SgcGroupBox1.TabIndex = 9
        Me.SgcGroupBox1.TabStop = False
        Me.SgcGroupBox1.Text = "Filtros"
        '
        'dtpFecFin
        '
        Me.dtpFecFin.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFecFin.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFecFin.Location = New System.Drawing.Point(484, 61)
        Me.dtpFecFin.Name = "dtpFecFin"
        Me.dtpFecFin.Size = New System.Drawing.Size(100, 26)
        Me.dtpFecFin.TabIndex = 7
        '
        'SgcLabel3
        '
        Me.SgcLabel3.AutoSize = True
        Me.SgcLabel3.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SgcLabel3.ForeColor = System.Drawing.Color.SteelBlue
        Me.SgcLabel3.Location = New System.Drawing.Point(393, 67)
        Me.SgcLabel3.Name = "SgcLabel3"
        Me.SgcLabel3.Size = New System.Drawing.Size(70, 18)
        Me.SgcLabel3.TabIndex = 6
        Me.SgcLabel3.Text = "Fecha Fin:"
        '
        'dtpFecInicio
        '
        Me.dtpFecInicio.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFecInicio.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFecInicio.Location = New System.Drawing.Point(484, 28)
        Me.dtpFecInicio.Name = "dtpFecInicio"
        Me.dtpFecInicio.Size = New System.Drawing.Size(100, 26)
        Me.dtpFecInicio.TabIndex = 5
        '
        'btnBuscar
        '
        Me.btnBuscar.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnBuscar.FlatAppearance.BorderColor = System.Drawing.Color.Silver
        Me.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBuscar.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBuscar.ForeColor = System.Drawing.Color.SteelBlue
        Me.btnBuscar.Location = New System.Drawing.Point(722, 27)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(120, 31)
        Me.btnBuscar.TabIndex = 4
        Me.btnBuscar.Text = "Buscar"
        Me.btnBuscar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnBuscar.UseVisualStyleBackColor = False
        '
        'SgcLabel2
        '
        Me.SgcLabel2.AutoSize = True
        Me.SgcLabel2.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SgcLabel2.ForeColor = System.Drawing.Color.SteelBlue
        Me.SgcLabel2.Location = New System.Drawing.Point(393, 34)
        Me.SgcLabel2.Name = "SgcLabel2"
        Me.SgcLabel2.Size = New System.Drawing.Size(85, 18)
        Me.SgcLabel2.TabIndex = 2
        Me.SgcLabel2.Text = "Fecha Inicio:"
        '
        'cboComite
        '
        Me.cboComite.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboComite.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cboComite.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboComite.ForeColor = System.Drawing.Color.Black
        Me.cboComite.FormattingEnabled = True
        Me.cboComite.Location = New System.Drawing.Point(99, 30)
        Me.cboComite.Name = "cboComite"
        Me.cboComite.Size = New System.Drawing.Size(121, 26)
        Me.cboComite.TabIndex = 1
        '
        'SgcLabel1
        '
        Me.SgcLabel1.AutoSize = True
        Me.SgcLabel1.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SgcLabel1.ForeColor = System.Drawing.Color.SteelBlue
        Me.SgcLabel1.Location = New System.Drawing.Point(19, 34)
        Me.SgcLabel1.Name = "SgcLabel1"
        Me.SgcLabel1.Size = New System.Drawing.Size(57, 18)
        Me.SgcLabel1.TabIndex = 0
        Me.SgcLabel1.Text = "Comite:"
        '
        'lblTitulo
        '
        Me.lblTitulo.AutoSize = True
        Me.lblTitulo.BackColor = System.Drawing.Color.ForestGreen
        Me.lblTitulo.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitulo.ForeColor = System.Drawing.Color.White
        Me.lblTitulo.Location = New System.Drawing.Point(397, 9)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(301, 23)
        Me.lblTitulo.TabIndex = 12
        Me.lblTitulo.Text = "Consulta de Actividades Recurrentes"
        '
        'cfiVacantes
        '
        Me.cfiVacantes.HeaderText = "Vacantes"
        Me.cfiVacantes.Name = "cfiVacantes"
        '
        'cfiPago
        '
        Me.cfiPago.HeaderText = "Pago"
        Me.cfiPago.Name = "cfiPago"
        '
        'cfiFecFin
        '
        Me.cfiFecFin.HeaderText = "Fec. Fin"
        Me.cfiFecFin.Name = "cfiFecFin"
        '
        'cfiFecInicio
        '
        Me.cfiFecInicio.HeaderText = "Fec. Inicio"
        Me.cfiFecInicio.Name = "cfiFecInicio"
        '
        'cfiCategoria
        '
        Me.cfiCategoria.HeaderText = "Categoría"
        Me.cfiCategoria.Name = "cfiCategoria"
        '
        'cfiTipo
        '
        Me.cfiTipo.HeaderText = "Tipo"
        Me.cfiTipo.Name = "cfiTipo"
        '
        'cfiNombre
        '
        Me.cfiNombre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.cfiNombre.HeaderText = "Nombre"
        Me.cfiNombre.Name = "cfiNombre"
        '
        'dgvTodas
        '
        Me.dgvTodas.AllowUserToAddRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.WhiteSmoke
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.SteelBlue
        Me.dgvTodas.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvTodas.BackgroundColor = System.Drawing.Color.WhiteSmoke
        Me.dgvTodas.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dgvTodas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvTodas.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ctoNombre, Me.ctoTipo, Me.ctoCategoria, Me.ctoFecInicio, Me.ctoFecFin, Me.ctoPago, Me.ctoVacantes, Me.ctoEstado})
        Me.dgvTodas.Location = New System.Drawing.Point(60, 175)
        Me.dgvTodas.Name = "dgvTodas"
        Me.dgvTodas.Size = New System.Drawing.Size(900, 343)
        Me.dgvTodas.TabIndex = 13
        '
        'ctoNombre
        '
        Me.ctoNombre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.ctoNombre.HeaderText = "Nombre"
        Me.ctoNombre.Name = "ctoNombre"
        '
        'ctoTipo
        '
        Me.ctoTipo.HeaderText = "Tipo"
        Me.ctoTipo.Name = "ctoTipo"
        '
        'ctoCategoria
        '
        Me.ctoCategoria.HeaderText = "Categoría"
        Me.ctoCategoria.Name = "ctoCategoria"
        '
        'ctoFecInicio
        '
        Me.ctoFecInicio.HeaderText = "Fec. Inicio"
        Me.ctoFecInicio.Name = "ctoFecInicio"
        '
        'ctoFecFin
        '
        Me.ctoFecFin.HeaderText = "Fec. Fin"
        Me.ctoFecFin.Name = "ctoFecFin"
        '
        'ctoPago
        '
        Me.ctoPago.HeaderText = "Pago"
        Me.ctoPago.Name = "ctoPago"
        '
        'ctoVacantes
        '
        Me.ctoVacantes.HeaderText = "Vacantes"
        Me.ctoVacantes.Name = "ctoVacantes"
        '
        'ctoEstado
        '
        Me.ctoEstado.HeaderText = "Estado"
        Me.ctoEstado.Name = "ctoEstado"
        '
        'frmConsultaActividadRecurrente
        '
        Me.ClientSize = New System.Drawing.Size(1016, 733)
        Me.Controls.Add(Me.dgvTodas)
        Me.Controls.Add(Me.lblTitulo)
        Me.Controls.Add(Me.SgcGroupBox1)
        Me.Name = "frmConsultaActividadRecurrente"
        Me.Controls.SetChildIndex(Me.SgcGroupBox1, 0)
        Me.Controls.SetChildIndex(Me.lblTitulo, 0)
        Me.Controls.SetChildIndex(Me.dgvTodas, 0)
        Me.SgcGroupBox1.ResumeLayout(False)
        Me.SgcGroupBox1.PerformLayout()
        CType(Me.dgvTodas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents SgcGroupBox1 As SGC_CS.SGCGroupBox
    Friend WithEvents btnBuscar As SGC_CS.SGCButton
    Friend WithEvents SgcLabel2 As SGC_CS.SGCLabel
    Friend WithEvents cboComite As SGC_CS.SGCComboBox
    Friend WithEvents SgcLabel1 As SGC_CS.SGCLabel
    Friend WithEvents dtpFecFin As SGC_CS.SGCDateTimePicker
    Friend WithEvents SgcLabel3 As SGC_CS.SGCLabel
    Friend WithEvents dtpFecInicio As SGC_CS.SGCDateTimePicker
    Friend WithEvents lblTitulo As SGC_CS.SGCLabel
    Friend WithEvents cfiVacantes As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cfiPago As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cfiFecFin As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cfiFecInicio As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cfiCategoria As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cfiTipo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cfiNombre As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dgvTodas As SGC_CS.SGCDataGridView
    Friend WithEvents ctoNombre As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ctoTipo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ctoCategoria As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ctoFecInicio As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ctoFecFin As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ctoPago As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ctoVacantes As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ctoEstado As System.Windows.Forms.DataGridViewTextBoxColumn

End Class
