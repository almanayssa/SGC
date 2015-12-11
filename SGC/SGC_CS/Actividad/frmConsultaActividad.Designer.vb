<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmConsultaActividad
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
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle13 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle14 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.SgcGroupBox1 = New SGC_CS.SGCGroupBox(Me.components)
        Me.dtpFecFin = New SGC_CS.SGCDateTimePicker(Me.components)
        Me.SgcLabel3 = New SGC_CS.SGCLabel(Me.components)
        Me.dtpFecInicio = New SGC_CS.SGCDateTimePicker(Me.components)
        Me.btnBuscar = New SGC_CS.SGCButton(Me.components)
        Me.SgcLabel2 = New SGC_CS.SGCLabel(Me.components)
        Me.cboComite = New SGC_CS.SGCComboBox(Me.components)
        Me.SgcLabel1 = New SGC_CS.SGCLabel(Me.components)
        Me.tabControl = New SGC_CS.SGCTabControl(Me.components)
        Me.tpTodas = New System.Windows.Forms.TabPage()
        Me.dgvTodas = New SGC_CS.SGCDataGridView(Me.components)
        Me.tpRegistradas = New System.Windows.Forms.TabPage()
        Me.tpEvaluacion = New System.Windows.Forms.TabPage()
        Me.tpAprobadas = New System.Windows.Forms.TabPage()
        Me.tpRechazadas = New System.Windows.Forms.TabPage()
        Me.tbHabilitadas = New System.Windows.Forms.TabPage()
        Me.tpFinalizadas = New System.Windows.Forms.TabPage()
        Me.lblTitulo = New SGC_CS.SGCLabel(Me.components)
        Me.dgvRegistradas = New SGC_CS.SGCDataGridView(Me.components)
        Me.dgvEnEvaluacion = New SGC_CS.SGCDataGridView(Me.components)
        Me.dgvAprobadas = New SGC_CS.SGCDataGridView(Me.components)
        Me.dgvRechazadas = New SGC_CS.SGCDataGridView(Me.components)
        Me.dgvHabilitadas = New SGC_CS.SGCDataGridView(Me.components)
        Me.dgvFinalizadas = New SGC_CS.SGCDataGridView(Me.components)
        Me.creNombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.creTipo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.creCategoria = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.creFecInicio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.creFecFin = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.crePago = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.creVacantes = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ceeNombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ceeTipo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ceeCategoria = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ceeFecInicio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ceeFecFin = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ceePago = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ceeVacantes = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.capNombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.capTipo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.capCategoria = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.capFecInicio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.capFecFin = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.capPago = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.capVacantes = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.crcNombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.crcTipo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.crcCategoria = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.crcFecInicio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.crcFecFin = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.crcPago = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.crcVacantes = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.chaNombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.chaTipo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.chaCategoria = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.chaFecInicio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.chaFecFin = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.chaPago = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.chaVacantes = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cfiNombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cfiTipo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cfiCategoria = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cfiFecInicio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cfiFecFin = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cfiPago = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cfiVacantes = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ctoNombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ctoTipo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ctoCategoria = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ctoFecInicio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ctoFecFin = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ctoPago = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ctoVacantes = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ctoEstado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SgcGroupBox1.SuspendLayout()
        Me.tabControl.SuspendLayout()
        Me.tpTodas.SuspendLayout()
        CType(Me.dgvTodas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tpRegistradas.SuspendLayout()
        Me.tpEvaluacion.SuspendLayout()
        Me.tpAprobadas.SuspendLayout()
        Me.tpRechazadas.SuspendLayout()
        Me.tbHabilitadas.SuspendLayout()
        Me.tpFinalizadas.SuspendLayout()
        CType(Me.dgvRegistradas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvEnEvaluacion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvAprobadas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvRechazadas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvHabilitadas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvFinalizadas, System.ComponentModel.ISupportInitialize).BeginInit()
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
        'tabControl
        '
        Me.tabControl.Controls.Add(Me.tpTodas)
        Me.tabControl.Controls.Add(Me.tpRegistradas)
        Me.tabControl.Controls.Add(Me.tpEvaluacion)
        Me.tabControl.Controls.Add(Me.tpAprobadas)
        Me.tabControl.Controls.Add(Me.tpRechazadas)
        Me.tabControl.Controls.Add(Me.tbHabilitadas)
        Me.tabControl.Controls.Add(Me.tpFinalizadas)
        Me.tabControl.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tabControl.Location = New System.Drawing.Point(60, 195)
        Me.tabControl.Name = "tabControl"
        Me.tabControl.SelectedIndex = 0
        Me.tabControl.Size = New System.Drawing.Size(896, 395)
        Me.tabControl.TabIndex = 10
        '
        'tpTodas
        '
        Me.tpTodas.Controls.Add(Me.dgvTodas)
        Me.tpTodas.Location = New System.Drawing.Point(4, 27)
        Me.tpTodas.Name = "tpTodas"
        Me.tpTodas.Padding = New System.Windows.Forms.Padding(3)
        Me.tpTodas.Size = New System.Drawing.Size(888, 364)
        Me.tpTodas.TabIndex = 0
        Me.tpTodas.Text = "Todas"
        Me.tpTodas.UseVisualStyleBackColor = True
        '
        'dgvTodas
        '
        Me.dgvTodas.AllowUserToAddRows = False
        DataGridViewCellStyle8.BackColor = System.Drawing.Color.WhiteSmoke
        DataGridViewCellStyle8.ForeColor = System.Drawing.Color.SteelBlue
        Me.dgvTodas.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle8
        Me.dgvTodas.BackgroundColor = System.Drawing.Color.WhiteSmoke
        Me.dgvTodas.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dgvTodas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvTodas.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ctoNombre, Me.ctoTipo, Me.ctoCategoria, Me.ctoFecInicio, Me.ctoFecFin, Me.ctoPago, Me.ctoVacantes, Me.ctoEstado})
        Me.dgvTodas.Location = New System.Drawing.Point(8, 11)
        Me.dgvTodas.Name = "dgvTodas"
        Me.dgvTodas.Size = New System.Drawing.Size(873, 343)
        Me.dgvTodas.TabIndex = 0
        '
        'tpRegistradas
        '
        Me.tpRegistradas.Controls.Add(Me.dgvRegistradas)
        Me.tpRegistradas.Location = New System.Drawing.Point(4, 27)
        Me.tpRegistradas.Name = "tpRegistradas"
        Me.tpRegistradas.Padding = New System.Windows.Forms.Padding(3)
        Me.tpRegistradas.Size = New System.Drawing.Size(888, 364)
        Me.tpRegistradas.TabIndex = 1
        Me.tpRegistradas.Text = "Registradas"
        Me.tpRegistradas.UseVisualStyleBackColor = True
        '
        'tpEvaluacion
        '
        Me.tpEvaluacion.Controls.Add(Me.dgvEnEvaluacion)
        Me.tpEvaluacion.Location = New System.Drawing.Point(4, 27)
        Me.tpEvaluacion.Name = "tpEvaluacion"
        Me.tpEvaluacion.Size = New System.Drawing.Size(888, 364)
        Me.tpEvaluacion.TabIndex = 2
        Me.tpEvaluacion.Text = "En Evaluación"
        Me.tpEvaluacion.UseVisualStyleBackColor = True
        '
        'tpAprobadas
        '
        Me.tpAprobadas.Controls.Add(Me.dgvAprobadas)
        Me.tpAprobadas.Location = New System.Drawing.Point(4, 27)
        Me.tpAprobadas.Name = "tpAprobadas"
        Me.tpAprobadas.Size = New System.Drawing.Size(888, 364)
        Me.tpAprobadas.TabIndex = 3
        Me.tpAprobadas.Text = "Aprobadas"
        Me.tpAprobadas.UseVisualStyleBackColor = True
        '
        'tpRechazadas
        '
        Me.tpRechazadas.Controls.Add(Me.dgvRechazadas)
        Me.tpRechazadas.Location = New System.Drawing.Point(4, 27)
        Me.tpRechazadas.Name = "tpRechazadas"
        Me.tpRechazadas.Size = New System.Drawing.Size(888, 364)
        Me.tpRechazadas.TabIndex = 4
        Me.tpRechazadas.Text = "Rechazadas"
        Me.tpRechazadas.UseVisualStyleBackColor = True
        '
        'tbHabilitadas
        '
        Me.tbHabilitadas.Controls.Add(Me.dgvHabilitadas)
        Me.tbHabilitadas.Location = New System.Drawing.Point(4, 27)
        Me.tbHabilitadas.Name = "tbHabilitadas"
        Me.tbHabilitadas.Size = New System.Drawing.Size(888, 364)
        Me.tbHabilitadas.TabIndex = 5
        Me.tbHabilitadas.Text = "Habilitadas"
        Me.tbHabilitadas.UseVisualStyleBackColor = True
        '
        'tpFinalizadas
        '
        Me.tpFinalizadas.Controls.Add(Me.dgvFinalizadas)
        Me.tpFinalizadas.Location = New System.Drawing.Point(4, 27)
        Me.tpFinalizadas.Name = "tpFinalizadas"
        Me.tpFinalizadas.Size = New System.Drawing.Size(888, 364)
        Me.tpFinalizadas.TabIndex = 6
        Me.tpFinalizadas.Text = "Finalizadas"
        Me.tpFinalizadas.UseVisualStyleBackColor = True
        '
        'lblTitulo
        '
        Me.lblTitulo.AutoSize = True
        Me.lblTitulo.BackColor = System.Drawing.Color.ForestGreen
        Me.lblTitulo.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitulo.ForeColor = System.Drawing.Color.White
        Me.lblTitulo.Location = New System.Drawing.Point(397, 9)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(199, 23)
        Me.lblTitulo.TabIndex = 12
        Me.lblTitulo.Text = "Consulta de Actividades"
        '
        'dgvRegistradas
        '
        Me.dgvRegistradas.AllowUserToAddRows = False
        DataGridViewCellStyle9.BackColor = System.Drawing.Color.WhiteSmoke
        DataGridViewCellStyle9.ForeColor = System.Drawing.Color.SteelBlue
        Me.dgvRegistradas.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle9
        Me.dgvRegistradas.BackgroundColor = System.Drawing.Color.WhiteSmoke
        Me.dgvRegistradas.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dgvRegistradas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvRegistradas.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.creNombre, Me.creTipo, Me.creCategoria, Me.creFecInicio, Me.creFecFin, Me.crePago, Me.creVacantes})
        Me.dgvRegistradas.Location = New System.Drawing.Point(8, 11)
        Me.dgvRegistradas.Name = "dgvRegistradas"
        Me.dgvRegistradas.Size = New System.Drawing.Size(873, 343)
        Me.dgvRegistradas.TabIndex = 1
        '
        'dgvEnEvaluacion
        '
        Me.dgvEnEvaluacion.AllowUserToAddRows = False
        DataGridViewCellStyle10.BackColor = System.Drawing.Color.WhiteSmoke
        DataGridViewCellStyle10.ForeColor = System.Drawing.Color.SteelBlue
        Me.dgvEnEvaluacion.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle10
        Me.dgvEnEvaluacion.BackgroundColor = System.Drawing.Color.WhiteSmoke
        Me.dgvEnEvaluacion.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dgvEnEvaluacion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvEnEvaluacion.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ceeNombre, Me.ceeTipo, Me.ceeCategoria, Me.ceeFecInicio, Me.ceeFecFin, Me.ceePago, Me.ceeVacantes})
        Me.dgvEnEvaluacion.Location = New System.Drawing.Point(8, 11)
        Me.dgvEnEvaluacion.Name = "dgvEnEvaluacion"
        Me.dgvEnEvaluacion.Size = New System.Drawing.Size(873, 343)
        Me.dgvEnEvaluacion.TabIndex = 1
        '
        'dgvAprobadas
        '
        Me.dgvAprobadas.AllowUserToAddRows = False
        DataGridViewCellStyle11.BackColor = System.Drawing.Color.WhiteSmoke
        DataGridViewCellStyle11.ForeColor = System.Drawing.Color.SteelBlue
        Me.dgvAprobadas.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle11
        Me.dgvAprobadas.BackgroundColor = System.Drawing.Color.WhiteSmoke
        Me.dgvAprobadas.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dgvAprobadas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvAprobadas.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.capNombre, Me.capTipo, Me.capCategoria, Me.capFecInicio, Me.capFecFin, Me.capPago, Me.capVacantes})
        Me.dgvAprobadas.Location = New System.Drawing.Point(8, 11)
        Me.dgvAprobadas.Name = "dgvAprobadas"
        Me.dgvAprobadas.Size = New System.Drawing.Size(873, 343)
        Me.dgvAprobadas.TabIndex = 1
        '
        'dgvRechazadas
        '
        Me.dgvRechazadas.AllowUserToAddRows = False
        DataGridViewCellStyle12.BackColor = System.Drawing.Color.WhiteSmoke
        DataGridViewCellStyle12.ForeColor = System.Drawing.Color.SteelBlue
        Me.dgvRechazadas.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle12
        Me.dgvRechazadas.BackgroundColor = System.Drawing.Color.WhiteSmoke
        Me.dgvRechazadas.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dgvRechazadas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvRechazadas.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.crcNombre, Me.crcTipo, Me.crcCategoria, Me.crcFecInicio, Me.crcFecFin, Me.crcPago, Me.crcVacantes})
        Me.dgvRechazadas.Location = New System.Drawing.Point(8, 11)
        Me.dgvRechazadas.Name = "dgvRechazadas"
        Me.dgvRechazadas.Size = New System.Drawing.Size(873, 343)
        Me.dgvRechazadas.TabIndex = 1
        '
        'dgvHabilitadas
        '
        Me.dgvHabilitadas.AllowUserToAddRows = False
        DataGridViewCellStyle13.BackColor = System.Drawing.Color.WhiteSmoke
        DataGridViewCellStyle13.ForeColor = System.Drawing.Color.SteelBlue
        Me.dgvHabilitadas.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle13
        Me.dgvHabilitadas.BackgroundColor = System.Drawing.Color.WhiteSmoke
        Me.dgvHabilitadas.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dgvHabilitadas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvHabilitadas.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.chaNombre, Me.chaTipo, Me.chaCategoria, Me.chaFecInicio, Me.chaFecFin, Me.chaPago, Me.chaVacantes})
        Me.dgvHabilitadas.Location = New System.Drawing.Point(8, 11)
        Me.dgvHabilitadas.Name = "dgvHabilitadas"
        Me.dgvHabilitadas.Size = New System.Drawing.Size(873, 343)
        Me.dgvHabilitadas.TabIndex = 1
        '
        'dgvFinalizadas
        '
        Me.dgvFinalizadas.AllowUserToAddRows = False
        DataGridViewCellStyle14.BackColor = System.Drawing.Color.WhiteSmoke
        DataGridViewCellStyle14.ForeColor = System.Drawing.Color.SteelBlue
        Me.dgvFinalizadas.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle14
        Me.dgvFinalizadas.BackgroundColor = System.Drawing.Color.WhiteSmoke
        Me.dgvFinalizadas.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dgvFinalizadas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvFinalizadas.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.cfiNombre, Me.cfiTipo, Me.cfiCategoria, Me.cfiFecInicio, Me.cfiFecFin, Me.cfiPago, Me.cfiVacantes})
        Me.dgvFinalizadas.Location = New System.Drawing.Point(8, 11)
        Me.dgvFinalizadas.Name = "dgvFinalizadas"
        Me.dgvFinalizadas.Size = New System.Drawing.Size(873, 343)
        Me.dgvFinalizadas.TabIndex = 1
        '
        'creNombre
        '
        Me.creNombre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.creNombre.HeaderText = "Nombre"
        Me.creNombre.Name = "creNombre"
        '
        'creTipo
        '
        Me.creTipo.HeaderText = "Tipo"
        Me.creTipo.Name = "creTipo"
        '
        'creCategoria
        '
        Me.creCategoria.HeaderText = "Categoría"
        Me.creCategoria.Name = "creCategoria"
        '
        'creFecInicio
        '
        Me.creFecInicio.HeaderText = "Fec. Inicio"
        Me.creFecInicio.Name = "creFecInicio"
        '
        'creFecFin
        '
        Me.creFecFin.HeaderText = "Fec. Fin"
        Me.creFecFin.Name = "creFecFin"
        '
        'crePago
        '
        Me.crePago.HeaderText = "Pago"
        Me.crePago.Name = "crePago"
        '
        'creVacantes
        '
        Me.creVacantes.HeaderText = "Vacantes"
        Me.creVacantes.Name = "creVacantes"
        '
        'ceeNombre
        '
        Me.ceeNombre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.ceeNombre.HeaderText = "Nombre"
        Me.ceeNombre.Name = "ceeNombre"
        '
        'ceeTipo
        '
        Me.ceeTipo.HeaderText = "Tipo"
        Me.ceeTipo.Name = "ceeTipo"
        '
        'ceeCategoria
        '
        Me.ceeCategoria.HeaderText = "Categoría"
        Me.ceeCategoria.Name = "ceeCategoria"
        '
        'ceeFecInicio
        '
        Me.ceeFecInicio.HeaderText = "Fec. Inicio"
        Me.ceeFecInicio.Name = "ceeFecInicio"
        '
        'ceeFecFin
        '
        Me.ceeFecFin.HeaderText = "Fec. Fin"
        Me.ceeFecFin.Name = "ceeFecFin"
        '
        'ceePago
        '
        Me.ceePago.HeaderText = "Pago"
        Me.ceePago.Name = "ceePago"
        '
        'ceeVacantes
        '
        Me.ceeVacantes.HeaderText = "Vacantes"
        Me.ceeVacantes.Name = "ceeVacantes"
        '
        'capNombre
        '
        Me.capNombre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.capNombre.HeaderText = "Nombre"
        Me.capNombre.Name = "capNombre"
        '
        'capTipo
        '
        Me.capTipo.HeaderText = "Tipo"
        Me.capTipo.Name = "capTipo"
        '
        'capCategoria
        '
        Me.capCategoria.HeaderText = "Categoría"
        Me.capCategoria.Name = "capCategoria"
        '
        'capFecInicio
        '
        Me.capFecInicio.HeaderText = "Fec. Inicio"
        Me.capFecInicio.Name = "capFecInicio"
        '
        'capFecFin
        '
        Me.capFecFin.HeaderText = "Fec. Fin"
        Me.capFecFin.Name = "capFecFin"
        '
        'capPago
        '
        Me.capPago.HeaderText = "Pago"
        Me.capPago.Name = "capPago"
        '
        'capVacantes
        '
        Me.capVacantes.HeaderText = "Vacantes"
        Me.capVacantes.Name = "capVacantes"
        '
        'crcNombre
        '
        Me.crcNombre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.crcNombre.HeaderText = "Nombre"
        Me.crcNombre.Name = "crcNombre"
        '
        'crcTipo
        '
        Me.crcTipo.HeaderText = "Tipo"
        Me.crcTipo.Name = "crcTipo"
        '
        'crcCategoria
        '
        Me.crcCategoria.HeaderText = "Categoría"
        Me.crcCategoria.Name = "crcCategoria"
        '
        'crcFecInicio
        '
        Me.crcFecInicio.HeaderText = "Fec. Inicio"
        Me.crcFecInicio.Name = "crcFecInicio"
        '
        'crcFecFin
        '
        Me.crcFecFin.HeaderText = "Fec. Fin"
        Me.crcFecFin.Name = "crcFecFin"
        '
        'crcPago
        '
        Me.crcPago.HeaderText = "Pago"
        Me.crcPago.Name = "crcPago"
        '
        'crcVacantes
        '
        Me.crcVacantes.HeaderText = "Vacantes"
        Me.crcVacantes.Name = "crcVacantes"
        '
        'chaNombre
        '
        Me.chaNombre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.chaNombre.HeaderText = "Nombre"
        Me.chaNombre.Name = "chaNombre"
        '
        'chaTipo
        '
        Me.chaTipo.HeaderText = "Tipo"
        Me.chaTipo.Name = "chaTipo"
        '
        'chaCategoria
        '
        Me.chaCategoria.HeaderText = "Categoría"
        Me.chaCategoria.Name = "chaCategoria"
        '
        'chaFecInicio
        '
        Me.chaFecInicio.HeaderText = "Fec. Inicio"
        Me.chaFecInicio.Name = "chaFecInicio"
        '
        'chaFecFin
        '
        Me.chaFecFin.HeaderText = "Fec. Fin"
        Me.chaFecFin.Name = "chaFecFin"
        '
        'chaPago
        '
        Me.chaPago.HeaderText = "Pago"
        Me.chaPago.Name = "chaPago"
        '
        'chaVacantes
        '
        Me.chaVacantes.HeaderText = "Vacantes"
        Me.chaVacantes.Name = "chaVacantes"
        '
        'cfiNombre
        '
        Me.cfiNombre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.cfiNombre.HeaderText = "Nombre"
        Me.cfiNombre.Name = "cfiNombre"
        '
        'cfiTipo
        '
        Me.cfiTipo.HeaderText = "Tipo"
        Me.cfiTipo.Name = "cfiTipo"
        '
        'cfiCategoria
        '
        Me.cfiCategoria.HeaderText = "Categoría"
        Me.cfiCategoria.Name = "cfiCategoria"
        '
        'cfiFecInicio
        '
        Me.cfiFecInicio.HeaderText = "Fec. Inicio"
        Me.cfiFecInicio.Name = "cfiFecInicio"
        '
        'cfiFecFin
        '
        Me.cfiFecFin.HeaderText = "Fec. Fin"
        Me.cfiFecFin.Name = "cfiFecFin"
        '
        'cfiPago
        '
        Me.cfiPago.HeaderText = "Pago"
        Me.cfiPago.Name = "cfiPago"
        '
        'cfiVacantes
        '
        Me.cfiVacantes.HeaderText = "Vacantes"
        Me.cfiVacantes.Name = "cfiVacantes"
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
        'frmConsultaActividad
        '
        Me.ClientSize = New System.Drawing.Size(1016, 733)
        Me.Controls.Add(Me.lblTitulo)
        Me.Controls.Add(Me.tabControl)
        Me.Controls.Add(Me.SgcGroupBox1)
        Me.Name = "frmConsultaActividad"
        Me.Controls.SetChildIndex(Me.SgcGroupBox1, 0)
        Me.Controls.SetChildIndex(Me.tabControl, 0)
        Me.Controls.SetChildIndex(Me.lblTitulo, 0)
        Me.SgcGroupBox1.ResumeLayout(False)
        Me.SgcGroupBox1.PerformLayout()
        Me.tabControl.ResumeLayout(False)
        Me.tpTodas.ResumeLayout(False)
        CType(Me.dgvTodas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tpRegistradas.ResumeLayout(False)
        Me.tpEvaluacion.ResumeLayout(False)
        Me.tpAprobadas.ResumeLayout(False)
        Me.tpRechazadas.ResumeLayout(False)
        Me.tbHabilitadas.ResumeLayout(False)
        Me.tpFinalizadas.ResumeLayout(False)
        CType(Me.dgvRegistradas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvEnEvaluacion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvAprobadas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvRechazadas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvHabilitadas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvFinalizadas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents SgcGroupBox1 As SGC_CS.SGCGroupBox
    Friend WithEvents btnBuscar As SGC_CS.SGCButton
    Friend WithEvents SgcLabel2 As SGC_CS.SGCLabel
    Friend WithEvents cboComite As SGC_CS.SGCComboBox
    Friend WithEvents SgcLabel1 As SGC_CS.SGCLabel
    Friend WithEvents tabControl As SGC_CS.SGCTabControl
    Friend WithEvents tpTodas As System.Windows.Forms.TabPage
    Friend WithEvents dgvTodas As SGC_CS.SGCDataGridView
    Friend WithEvents tpRegistradas As System.Windows.Forms.TabPage
    Friend WithEvents tpEvaluacion As System.Windows.Forms.TabPage
    Friend WithEvents tpAprobadas As System.Windows.Forms.TabPage
    Friend WithEvents tpRechazadas As System.Windows.Forms.TabPage
    Friend WithEvents dtpFecFin As SGC_CS.SGCDateTimePicker
    Friend WithEvents SgcLabel3 As SGC_CS.SGCLabel
    Friend WithEvents dtpFecInicio As SGC_CS.SGCDateTimePicker
    Friend WithEvents tbHabilitadas As System.Windows.Forms.TabPage
    Friend WithEvents tpFinalizadas As System.Windows.Forms.TabPage
    Friend WithEvents lblTitulo As SGC_CS.SGCLabel
    Friend WithEvents dgvRegistradas As SGC_CS.SGCDataGridView
    Friend WithEvents dgvEnEvaluacion As SGC_CS.SGCDataGridView
    Friend WithEvents dgvAprobadas As SGC_CS.SGCDataGridView
    Friend WithEvents dgvRechazadas As SGC_CS.SGCDataGridView
    Friend WithEvents dgvHabilitadas As SGC_CS.SGCDataGridView
    Friend WithEvents dgvFinalizadas As SGC_CS.SGCDataGridView
    Friend WithEvents creNombre As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents creTipo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents creCategoria As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents creFecInicio As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents creFecFin As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents crePago As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents creVacantes As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ceeNombre As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ceeTipo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ceeCategoria As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ceeFecInicio As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ceeFecFin As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ceePago As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ceeVacantes As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents capNombre As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents capTipo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents capCategoria As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents capFecInicio As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents capFecFin As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents capPago As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents capVacantes As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents crcNombre As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents crcTipo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents crcCategoria As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents crcFecInicio As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents crcFecFin As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents crcPago As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents crcVacantes As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents chaNombre As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents chaTipo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents chaCategoria As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents chaFecInicio As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents chaFecFin As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents chaPago As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents chaVacantes As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cfiNombre As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cfiTipo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cfiCategoria As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cfiFecInicio As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cfiFecFin As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cfiPago As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cfiVacantes As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ctoNombre As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ctoTipo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ctoCategoria As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ctoFecInicio As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ctoFecFin As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ctoPago As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ctoVacantes As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ctoEstado As System.Windows.Forms.DataGridViewTextBoxColumn

End Class
