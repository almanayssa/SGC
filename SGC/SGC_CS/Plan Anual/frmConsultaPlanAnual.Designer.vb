<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmConsultaPlanAnual
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
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.SgcGroupBox1 = New SGC_CS.SGCGroupBox(Me.components)
        Me.btnBuscar = New SGC_CS.SGCButton(Me.components)
        Me.cboAnio = New SGC_CS.SGCComboBox(Me.components)
        Me.SgcLabel2 = New SGC_CS.SGCLabel(Me.components)
        Me.cboComite = New SGC_CS.SGCComboBox(Me.components)
        Me.SgcLabel1 = New SGC_CS.SGCLabel(Me.components)
        Me.tcPlanAnual = New SGC_CS.SGCTabControl(Me.components)
        Me.tpTodos = New System.Windows.Forms.TabPage()
        Me.tpRegistrados = New System.Windows.Forms.TabPage()
        Me.tpEvaluacion = New System.Windows.Forms.TabPage()
        Me.tpAprobados = New System.Windows.Forms.TabPage()
        Me.tpRechazados = New System.Windows.Forms.TabPage()
        Me.btnNuevo = New SGC_CS.SGCButton(Me.components)
        Me.lblTitulo = New SGC_CS.SGCLabel(Me.components)
        Me.dgvTodos = New SGC_CS.SGCDataGridView(Me.components)
        Me.ctoDescripcion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ctoComite = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ctoAnio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ctoFecInicio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ctoFecFin = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ctoEstado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvRegistrados = New SGC_CS.SGCDataGridView(Me.components)
        Me.dgvEnEvaluacion = New SGC_CS.SGCDataGridView(Me.components)
        Me.dgvAprobados = New SGC_CS.SGCDataGridView(Me.components)
        Me.dgvRechazados = New SGC_CS.SGCDataGridView(Me.components)
        Me.tpAnulados = New System.Windows.Forms.TabPage()
        Me.dgvAnulados = New SGC_CS.SGCDataGridView(Me.components)
        Me.creDescripcion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.creComite = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.creAnio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.creFecInicio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.creFecFin = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ceeDescripcion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ceeComite = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ceeAnio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ceeFecInicio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ceeFecFin = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.canDescripcion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.canComite = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.canAnio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.canFecInicio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.canFecFin = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.capDescripcion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.capComite = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.capAnio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.capFecInicio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.capFecFin = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.crcDescripcion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.crcComite = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.crcAnio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.crcFecInicio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.crcFecFin = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SgcGroupBox1.SuspendLayout()
        Me.tcPlanAnual.SuspendLayout()
        Me.tpTodos.SuspendLayout()
        Me.tpRegistrados.SuspendLayout()
        Me.tpEvaluacion.SuspendLayout()
        Me.tpAprobados.SuspendLayout()
        Me.tpRechazados.SuspendLayout()
        CType(Me.dgvTodos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvRegistrados, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvEnEvaluacion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvAprobados, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvRechazados, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tpAnulados.SuspendLayout()
        CType(Me.dgvAnulados, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SgcGroupBox1
        '
        Me.SgcGroupBox1.Controls.Add(Me.btnBuscar)
        Me.SgcGroupBox1.Controls.Add(Me.cboAnio)
        Me.SgcGroupBox1.Controls.Add(Me.SgcLabel2)
        Me.SgcGroupBox1.Controls.Add(Me.cboComite)
        Me.SgcGroupBox1.Controls.Add(Me.SgcLabel1)
        Me.SgcGroupBox1.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SgcGroupBox1.Location = New System.Drawing.Point(60, 70)
        Me.SgcGroupBox1.Name = "SgcGroupBox1"
        Me.SgcGroupBox1.Size = New System.Drawing.Size(900, 79)
        Me.SgcGroupBox1.TabIndex = 8
        Me.SgcGroupBox1.TabStop = False
        Me.SgcGroupBox1.Text = "Filtros"
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
        'cboAnio
        '
        Me.cboAnio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboAnio.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cboAnio.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboAnio.ForeColor = System.Drawing.Color.Black
        Me.cboAnio.FormattingEnabled = True
        Me.cboAnio.Location = New System.Drawing.Point(470, 31)
        Me.cboAnio.Name = "cboAnio"
        Me.cboAnio.Size = New System.Drawing.Size(121, 26)
        Me.cboAnio.TabIndex = 3
        '
        'SgcLabel2
        '
        Me.SgcLabel2.AutoSize = True
        Me.SgcLabel2.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SgcLabel2.ForeColor = System.Drawing.Color.SteelBlue
        Me.SgcLabel2.Location = New System.Drawing.Point(393, 34)
        Me.SgcLabel2.Name = "SgcLabel2"
        Me.SgcLabel2.Size = New System.Drawing.Size(37, 18)
        Me.SgcLabel2.TabIndex = 2
        Me.SgcLabel2.Text = "Año:"
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
        'tcPlanAnual
        '
        Me.tcPlanAnual.Controls.Add(Me.tpTodos)
        Me.tcPlanAnual.Controls.Add(Me.tpRegistrados)
        Me.tcPlanAnual.Controls.Add(Me.tpEvaluacion)
        Me.tcPlanAnual.Controls.Add(Me.tpAnulados)
        Me.tcPlanAnual.Controls.Add(Me.tpAprobados)
        Me.tcPlanAnual.Controls.Add(Me.tpRechazados)
        Me.tcPlanAnual.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tcPlanAnual.Location = New System.Drawing.Point(60, 203)
        Me.tcPlanAnual.Name = "tcPlanAnual"
        Me.tcPlanAnual.SelectedIndex = 0
        Me.tcPlanAnual.Size = New System.Drawing.Size(896, 395)
        Me.tcPlanAnual.TabIndex = 9
        '
        'tpTodos
        '
        Me.tpTodos.Controls.Add(Me.dgvTodos)
        Me.tpTodos.Location = New System.Drawing.Point(4, 27)
        Me.tpTodos.Name = "tpTodos"
        Me.tpTodos.Padding = New System.Windows.Forms.Padding(3)
        Me.tpTodos.Size = New System.Drawing.Size(888, 364)
        Me.tpTodos.TabIndex = 0
        Me.tpTodos.Text = "Todos"
        Me.tpTodos.UseVisualStyleBackColor = True
        '
        'tpRegistrados
        '
        Me.tpRegistrados.Controls.Add(Me.dgvRegistrados)
        Me.tpRegistrados.Location = New System.Drawing.Point(4, 27)
        Me.tpRegistrados.Name = "tpRegistrados"
        Me.tpRegistrados.Padding = New System.Windows.Forms.Padding(3)
        Me.tpRegistrados.Size = New System.Drawing.Size(888, 364)
        Me.tpRegistrados.TabIndex = 1
        Me.tpRegistrados.Text = "Registrados"
        Me.tpRegistrados.UseVisualStyleBackColor = True
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
        'tpAprobados
        '
        Me.tpAprobados.Controls.Add(Me.dgvAprobados)
        Me.tpAprobados.Location = New System.Drawing.Point(4, 27)
        Me.tpAprobados.Name = "tpAprobados"
        Me.tpAprobados.Size = New System.Drawing.Size(888, 364)
        Me.tpAprobados.TabIndex = 3
        Me.tpAprobados.Text = "Aprobados"
        Me.tpAprobados.UseVisualStyleBackColor = True
        '
        'tpRechazados
        '
        Me.tpRechazados.Controls.Add(Me.dgvRechazados)
        Me.tpRechazados.Location = New System.Drawing.Point(4, 27)
        Me.tpRechazados.Name = "tpRechazados"
        Me.tpRechazados.Size = New System.Drawing.Size(888, 364)
        Me.tpRechazados.TabIndex = 4
        Me.tpRechazados.Text = "Rechazados"
        Me.tpRechazados.UseVisualStyleBackColor = True
        '
        'btnNuevo
        '
        Me.btnNuevo.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnNuevo.FlatAppearance.BorderColor = System.Drawing.Color.Silver
        Me.btnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNuevo.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNuevo.ForeColor = System.Drawing.Color.SteelBlue
        Me.btnNuevo.Location = New System.Drawing.Point(60, 161)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(176, 31)
        Me.btnNuevo.TabIndex = 10
        Me.btnNuevo.Text = "Registrar Plan Anual"
        Me.btnNuevo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnNuevo.UseVisualStyleBackColor = False
        '
        'lblTitulo
        '
        Me.lblTitulo.AutoSize = True
        Me.lblTitulo.BackColor = System.Drawing.Color.ForestGreen
        Me.lblTitulo.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitulo.ForeColor = System.Drawing.Color.White
        Me.lblTitulo.Location = New System.Drawing.Point(433, 9)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(191, 23)
        Me.lblTitulo.TabIndex = 11
        Me.lblTitulo.Text = "Consulta de Plan Anual"
        '
        'dgvTodos
        '
        Me.dgvTodos.AllowUserToAddRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.WhiteSmoke
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.SteelBlue
        Me.dgvTodos.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvTodos.BackgroundColor = System.Drawing.Color.WhiteSmoke
        Me.dgvTodos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dgvTodos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvTodos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ctoDescripcion, Me.ctoComite, Me.ctoAnio, Me.ctoFecInicio, Me.ctoFecFin, Me.ctoEstado})
        Me.dgvTodos.Location = New System.Drawing.Point(8, 11)
        Me.dgvTodos.Name = "dgvTodos"
        Me.dgvTodos.ReadOnly = True
        Me.dgvTodos.Size = New System.Drawing.Size(873, 343)
        Me.dgvTodos.TabIndex = 1
        '
        'ctoDescripcion
        '
        Me.ctoDescripcion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.ctoDescripcion.HeaderText = "Descripción"
        Me.ctoDescripcion.Name = "ctoDescripcion"
        Me.ctoDescripcion.ReadOnly = True
        '
        'ctoComite
        '
        Me.ctoComite.HeaderText = "Comité"
        Me.ctoComite.Name = "ctoComite"
        Me.ctoComite.ReadOnly = True
        '
        'ctoAnio
        '
        Me.ctoAnio.HeaderText = "Año"
        Me.ctoAnio.Name = "ctoAnio"
        Me.ctoAnio.ReadOnly = True
        '
        'ctoFecInicio
        '
        Me.ctoFecInicio.HeaderText = "Fec. Inicio"
        Me.ctoFecInicio.Name = "ctoFecInicio"
        Me.ctoFecInicio.ReadOnly = True
        '
        'ctoFecFin
        '
        Me.ctoFecFin.HeaderText = "Fec. Fin"
        Me.ctoFecFin.Name = "ctoFecFin"
        Me.ctoFecFin.ReadOnly = True
        '
        'ctoEstado
        '
        Me.ctoEstado.HeaderText = "Estado"
        Me.ctoEstado.Name = "ctoEstado"
        Me.ctoEstado.ReadOnly = True
        '
        'dgvRegistrados
        '
        Me.dgvRegistrados.AllowUserToAddRows = False
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.WhiteSmoke
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.SteelBlue
        Me.dgvRegistrados.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvRegistrados.BackgroundColor = System.Drawing.Color.WhiteSmoke
        Me.dgvRegistrados.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dgvRegistrados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvRegistrados.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.creDescripcion, Me.creComite, Me.creAnio, Me.creFecInicio, Me.creFecFin})
        Me.dgvRegistrados.Location = New System.Drawing.Point(8, 11)
        Me.dgvRegistrados.Name = "dgvRegistrados"
        Me.dgvRegistrados.ReadOnly = True
        Me.dgvRegistrados.Size = New System.Drawing.Size(873, 343)
        Me.dgvRegistrados.TabIndex = 2
        '
        'dgvEnEvaluacion
        '
        Me.dgvEnEvaluacion.AllowUserToAddRows = False
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.WhiteSmoke
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.SteelBlue
        Me.dgvEnEvaluacion.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle3
        Me.dgvEnEvaluacion.BackgroundColor = System.Drawing.Color.WhiteSmoke
        Me.dgvEnEvaluacion.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dgvEnEvaluacion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvEnEvaluacion.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ceeDescripcion, Me.ceeComite, Me.ceeAnio, Me.ceeFecInicio, Me.ceeFecFin})
        Me.dgvEnEvaluacion.Location = New System.Drawing.Point(8, 11)
        Me.dgvEnEvaluacion.Name = "dgvEnEvaluacion"
        Me.dgvEnEvaluacion.ReadOnly = True
        Me.dgvEnEvaluacion.Size = New System.Drawing.Size(873, 343)
        Me.dgvEnEvaluacion.TabIndex = 2
        '
        'dgvAprobados
        '
        Me.dgvAprobados.AllowUserToAddRows = False
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.WhiteSmoke
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.SteelBlue
        Me.dgvAprobados.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle5
        Me.dgvAprobados.BackgroundColor = System.Drawing.Color.WhiteSmoke
        Me.dgvAprobados.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dgvAprobados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvAprobados.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.capDescripcion, Me.capComite, Me.capAnio, Me.capFecInicio, Me.capFecFin})
        Me.dgvAprobados.Location = New System.Drawing.Point(8, 11)
        Me.dgvAprobados.Name = "dgvAprobados"
        Me.dgvAprobados.ReadOnly = True
        Me.dgvAprobados.Size = New System.Drawing.Size(873, 343)
        Me.dgvAprobados.TabIndex = 2
        '
        'dgvRechazados
        '
        Me.dgvRechazados.AllowUserToAddRows = False
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.WhiteSmoke
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.SteelBlue
        Me.dgvRechazados.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle6
        Me.dgvRechazados.BackgroundColor = System.Drawing.Color.WhiteSmoke
        Me.dgvRechazados.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dgvRechazados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvRechazados.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.crcDescripcion, Me.crcComite, Me.crcAnio, Me.crcFecInicio, Me.crcFecFin})
        Me.dgvRechazados.Location = New System.Drawing.Point(8, 11)
        Me.dgvRechazados.Name = "dgvRechazados"
        Me.dgvRechazados.ReadOnly = True
        Me.dgvRechazados.Size = New System.Drawing.Size(873, 343)
        Me.dgvRechazados.TabIndex = 2
        '
        'tpAnulados
        '
        Me.tpAnulados.Controls.Add(Me.dgvAnulados)
        Me.tpAnulados.Location = New System.Drawing.Point(4, 27)
        Me.tpAnulados.Name = "tpAnulados"
        Me.tpAnulados.Size = New System.Drawing.Size(888, 364)
        Me.tpAnulados.TabIndex = 5
        Me.tpAnulados.Text = "Anulados"
        Me.tpAnulados.UseVisualStyleBackColor = True
        '
        'dgvAnulados
        '
        Me.dgvAnulados.AllowUserToAddRows = False
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.WhiteSmoke
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.SteelBlue
        Me.dgvAnulados.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle4
        Me.dgvAnulados.BackgroundColor = System.Drawing.Color.WhiteSmoke
        Me.dgvAnulados.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dgvAnulados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvAnulados.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.canDescripcion, Me.canComite, Me.canAnio, Me.canFecInicio, Me.canFecFin})
        Me.dgvAnulados.Location = New System.Drawing.Point(8, 11)
        Me.dgvAnulados.Name = "dgvAnulados"
        Me.dgvAnulados.ReadOnly = True
        Me.dgvAnulados.Size = New System.Drawing.Size(873, 343)
        Me.dgvAnulados.TabIndex = 3
        '
        'creDescripcion
        '
        Me.creDescripcion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.creDescripcion.HeaderText = "Descripción"
        Me.creDescripcion.Name = "creDescripcion"
        Me.creDescripcion.ReadOnly = True
        '
        'creComite
        '
        Me.creComite.HeaderText = "Comité"
        Me.creComite.Name = "creComite"
        Me.creComite.ReadOnly = True
        '
        'creAnio
        '
        Me.creAnio.HeaderText = "Año"
        Me.creAnio.Name = "creAnio"
        Me.creAnio.ReadOnly = True
        '
        'creFecInicio
        '
        Me.creFecInicio.HeaderText = "Fec. Inicio"
        Me.creFecInicio.Name = "creFecInicio"
        Me.creFecInicio.ReadOnly = True
        '
        'creFecFin
        '
        Me.creFecFin.HeaderText = "Fec. Fin"
        Me.creFecFin.Name = "creFecFin"
        Me.creFecFin.ReadOnly = True
        '
        'ceeDescripcion
        '
        Me.ceeDescripcion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.ceeDescripcion.HeaderText = "Descripción"
        Me.ceeDescripcion.Name = "ceeDescripcion"
        Me.ceeDescripcion.ReadOnly = True
        '
        'ceeComite
        '
        Me.ceeComite.HeaderText = "Comité"
        Me.ceeComite.Name = "ceeComite"
        Me.ceeComite.ReadOnly = True
        '
        'ceeAnio
        '
        Me.ceeAnio.HeaderText = "Año"
        Me.ceeAnio.Name = "ceeAnio"
        Me.ceeAnio.ReadOnly = True
        '
        'ceeFecInicio
        '
        Me.ceeFecInicio.HeaderText = "Fec. Inicio"
        Me.ceeFecInicio.Name = "ceeFecInicio"
        Me.ceeFecInicio.ReadOnly = True
        '
        'ceeFecFin
        '
        Me.ceeFecFin.HeaderText = "Fec. Fin"
        Me.ceeFecFin.Name = "ceeFecFin"
        Me.ceeFecFin.ReadOnly = True
        '
        'canDescripcion
        '
        Me.canDescripcion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.canDescripcion.HeaderText = "Descripción"
        Me.canDescripcion.Name = "canDescripcion"
        Me.canDescripcion.ReadOnly = True
        '
        'canComite
        '
        Me.canComite.HeaderText = "Comité"
        Me.canComite.Name = "canComite"
        Me.canComite.ReadOnly = True
        '
        'canAnio
        '
        Me.canAnio.HeaderText = "Año"
        Me.canAnio.Name = "canAnio"
        Me.canAnio.ReadOnly = True
        '
        'canFecInicio
        '
        Me.canFecInicio.HeaderText = "Fec. Inicio"
        Me.canFecInicio.Name = "canFecInicio"
        Me.canFecInicio.ReadOnly = True
        '
        'canFecFin
        '
        Me.canFecFin.HeaderText = "Fec. Fin"
        Me.canFecFin.Name = "canFecFin"
        Me.canFecFin.ReadOnly = True
        '
        'capDescripcion
        '
        Me.capDescripcion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.capDescripcion.HeaderText = "Descripción"
        Me.capDescripcion.Name = "capDescripcion"
        Me.capDescripcion.ReadOnly = True
        '
        'capComite
        '
        Me.capComite.HeaderText = "Comité"
        Me.capComite.Name = "capComite"
        Me.capComite.ReadOnly = True
        '
        'capAnio
        '
        Me.capAnio.HeaderText = "Año"
        Me.capAnio.Name = "capAnio"
        Me.capAnio.ReadOnly = True
        '
        'capFecInicio
        '
        Me.capFecInicio.HeaderText = "Fec. Inicio"
        Me.capFecInicio.Name = "capFecInicio"
        Me.capFecInicio.ReadOnly = True
        '
        'capFecFin
        '
        Me.capFecFin.HeaderText = "Fec. Fin"
        Me.capFecFin.Name = "capFecFin"
        Me.capFecFin.ReadOnly = True
        '
        'crcDescripcion
        '
        Me.crcDescripcion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.crcDescripcion.HeaderText = "Descripción"
        Me.crcDescripcion.Name = "crcDescripcion"
        Me.crcDescripcion.ReadOnly = True
        '
        'crcComite
        '
        Me.crcComite.HeaderText = "Comité"
        Me.crcComite.Name = "crcComite"
        Me.crcComite.ReadOnly = True
        '
        'crcAnio
        '
        Me.crcAnio.HeaderText = "Año"
        Me.crcAnio.Name = "crcAnio"
        Me.crcAnio.ReadOnly = True
        '
        'crcFecInicio
        '
        Me.crcFecInicio.HeaderText = "Fec. Inicio"
        Me.crcFecInicio.Name = "crcFecInicio"
        Me.crcFecInicio.ReadOnly = True
        '
        'crcFecFin
        '
        Me.crcFecFin.HeaderText = "Fec. Fin"
        Me.crcFecFin.Name = "crcFecFin"
        Me.crcFecFin.ReadOnly = True
        '
        'frmConsultaPlanAnual
        '
        Me.ClientSize = New System.Drawing.Size(1016, 733)
        Me.Controls.Add(Me.lblTitulo)
        Me.Controls.Add(Me.btnNuevo)
        Me.Controls.Add(Me.tcPlanAnual)
        Me.Controls.Add(Me.SgcGroupBox1)
        Me.Name = "frmConsultaPlanAnual"
        Me.Controls.SetChildIndex(Me.SgcGroupBox1, 0)
        Me.Controls.SetChildIndex(Me.tcPlanAnual, 0)
        Me.Controls.SetChildIndex(Me.btnNuevo, 0)
        Me.Controls.SetChildIndex(Me.lblTitulo, 0)
        Me.SgcGroupBox1.ResumeLayout(False)
        Me.SgcGroupBox1.PerformLayout()
        Me.tcPlanAnual.ResumeLayout(False)
        Me.tpTodos.ResumeLayout(False)
        Me.tpRegistrados.ResumeLayout(False)
        Me.tpEvaluacion.ResumeLayout(False)
        Me.tpAprobados.ResumeLayout(False)
        Me.tpRechazados.ResumeLayout(False)
        CType(Me.dgvTodos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvRegistrados, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvEnEvaluacion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvAprobados, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvRechazados, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tpAnulados.ResumeLayout(False)
        CType(Me.dgvAnulados, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents SgcGroupBox1 As SGC_CS.SGCGroupBox
    Friend WithEvents tcPlanAnual As SGC_CS.SGCTabControl
    Friend WithEvents tpTodos As System.Windows.Forms.TabPage
    Friend WithEvents tpRegistrados As System.Windows.Forms.TabPage
    Friend WithEvents btnNuevo As SGC_CS.SGCButton
    Friend WithEvents btnBuscar As SGC_CS.SGCButton
    Friend WithEvents cboAnio As SGC_CS.SGCComboBox
    Friend WithEvents SgcLabel2 As SGC_CS.SGCLabel
    Friend WithEvents cboComite As SGC_CS.SGCComboBox
    Friend WithEvents SgcLabel1 As SGC_CS.SGCLabel
    Friend WithEvents tpEvaluacion As System.Windows.Forms.TabPage
    Friend WithEvents tpAprobados As System.Windows.Forms.TabPage
    Friend WithEvents tpRechazados As System.Windows.Forms.TabPage
    Friend WithEvents lblTitulo As SGC_CS.SGCLabel
    Friend WithEvents dgvTodos As SGC_CS.SGCDataGridView
    Friend WithEvents ctoDescripcion As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ctoComite As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ctoAnio As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ctoFecInicio As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ctoFecFin As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ctoEstado As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dgvRegistrados As SGC_CS.SGCDataGridView
    Friend WithEvents dgvEnEvaluacion As SGC_CS.SGCDataGridView
    Friend WithEvents dgvAprobados As SGC_CS.SGCDataGridView
    Friend WithEvents dgvRechazados As SGC_CS.SGCDataGridView
    Friend WithEvents tpAnulados As System.Windows.Forms.TabPage
    Friend WithEvents dgvAnulados As SGC_CS.SGCDataGridView
    Friend WithEvents creDescripcion As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents creComite As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents creAnio As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents creFecInicio As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents creFecFin As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ceeDescripcion As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ceeComite As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ceeAnio As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ceeFecInicio As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ceeFecFin As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents canDescripcion As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents canComite As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents canAnio As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents canFecInicio As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents canFecFin As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents capDescripcion As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents capComite As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents capAnio As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents capFecInicio As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents capFecFin As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents crcDescripcion As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents crcComite As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents crcAnio As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents crcFecInicio As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents crcFecFin As System.Windows.Forms.DataGridViewTextBoxColumn

End Class
