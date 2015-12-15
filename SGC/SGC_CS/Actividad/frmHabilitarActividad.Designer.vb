<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmHabilitarActividad
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
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.tcPlanAnual = New SGC_CS.SGCTabControl(Me.components)
        Me.tpRestricciones = New System.Windows.Forms.TabPage()
        Me.SgcGroupBox3 = New SGC_CS.SGCGroupBox(Me.components)
        Me.dgvRestricciones = New SGC_CS.SGCDataGridView(Me.components)
        Me.colRestriccionID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colDescripcionRestriccion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colCondicionRestriccion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colCantidadRestriccion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tpPersonal = New System.Windows.Forms.TabPage()
        Me.SgcGroupBox5 = New SGC_CS.SGCGroupBox(Me.components)
        Me.btnQuitarPersonal = New SGC_CS.SGCButton(Me.components)
        Me.btnAgregarPersonal = New SGC_CS.SGCButton(Me.components)
        Me.dgvPersonal = New SGC_CS.SGCDataGridView(Me.components)
        Me.colNombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SgcGroupBox7 = New SGC_CS.SGCGroupBox(Me.components)
        Me.dgvTipoPersonal = New SGC_CS.SGCDataGridView(Me.components)
        Me.colTipoPersonalID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colDescripcionTipoPersonal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colCantidadTipoPersonal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tpRecursos = New System.Windows.Forms.TabPage()
        Me.SgcGroupBox6 = New SGC_CS.SGCGroupBox(Me.components)
        Me.dgvRecursos = New SGC_CS.SGCDataGridView(Me.components)
        Me.colDescripcionRecurso = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colCantidadRecurso = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colCantidadReal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tsMenu = New SGC_CS.SGCToolStrip(Me.components)
        Me.tsbLimpiar = New System.Windows.Forms.ToolStripButton()
        Me.tsbHabilitar = New System.Windows.Forms.ToolStripButton()
        Me.SgcGroupBox2 = New SGC_CS.SGCGroupBox(Me.components)
        Me.dgvProgramacion = New SGC_CS.SGCDataGridView(Me.components)
        Me.SgcGroupBox1 = New SGC_CS.SGCGroupBox(Me.components)
        Me.lblCategoria = New SGC_CS.SGCLabel(Me.components)
        Me.lblVacantes = New SGC_CS.SGCLabel(Me.components)
        Me.lblPago = New SGC_CS.SGCLabel(Me.components)
        Me.lblDescripcion = New SGC_CS.SGCLabel(Me.components)
        Me.lblNombre = New SGC_CS.SGCLabel(Me.components)
        Me.lblTipo = New SGC_CS.SGCLabel(Me.components)
        Me.lblCodigo = New SGC_CS.SGCLabel(Me.components)
        Me.lblComite = New SGC_CS.SGCLabel(Me.components)
        Me.SgcLabel6 = New SGC_CS.SGCLabel(Me.components)
        Me.btnBuscarActividad = New SGC_CS.SGCButton(Me.components)
        Me.SgcLabel12 = New SGC_CS.SGCLabel(Me.components)
        Me.SgcLabel11 = New SGC_CS.SGCLabel(Me.components)
        Me.SgcLabel10 = New SGC_CS.SGCLabel(Me.components)
        Me.SgcLabel7 = New SGC_CS.SGCLabel(Me.components)
        Me.SgcLabel4 = New SGC_CS.SGCLabel(Me.components)
        Me.SgcLabel3 = New SGC_CS.SGCLabel(Me.components)
        Me.SgcLabel2 = New SGC_CS.SGCLabel(Me.components)
        Me.SgcLabel1 = New SGC_CS.SGCLabel(Me.components)
        Me.lblTitulo = New SGC_CS.SGCLabel(Me.components)
        Me.colSede = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colEspacio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colFecInicio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colHoraInicio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colFecFin = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colHoraFin = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colVacantes = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tcPlanAnual.SuspendLayout()
        Me.tpRestricciones.SuspendLayout()
        Me.SgcGroupBox3.SuspendLayout()
        CType(Me.dgvRestricciones, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tpPersonal.SuspendLayout()
        Me.SgcGroupBox5.SuspendLayout()
        CType(Me.dgvPersonal, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SgcGroupBox7.SuspendLayout()
        CType(Me.dgvTipoPersonal, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tpRecursos.SuspendLayout()
        Me.SgcGroupBox6.SuspendLayout()
        CType(Me.dgvRecursos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tsMenu.SuspendLayout()
        Me.SgcGroupBox2.SuspendLayout()
        CType(Me.dgvProgramacion, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SgcGroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'tcPlanAnual
        '
        Me.tcPlanAnual.Controls.Add(Me.tpRestricciones)
        Me.tcPlanAnual.Controls.Add(Me.tpPersonal)
        Me.tcPlanAnual.Controls.Add(Me.tpRecursos)
        Me.tcPlanAnual.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tcPlanAnual.Location = New System.Drawing.Point(60, 322)
        Me.tcPlanAnual.Name = "tcPlanAnual"
        Me.tcPlanAnual.SelectedIndex = 0
        Me.tcPlanAnual.Size = New System.Drawing.Size(900, 246)
        Me.tcPlanAnual.TabIndex = 22
        '
        'tpRestricciones
        '
        Me.tpRestricciones.Controls.Add(Me.SgcGroupBox3)
        Me.tpRestricciones.Location = New System.Drawing.Point(4, 27)
        Me.tpRestricciones.Name = "tpRestricciones"
        Me.tpRestricciones.Padding = New System.Windows.Forms.Padding(3)
        Me.tpRestricciones.Size = New System.Drawing.Size(892, 215)
        Me.tpRestricciones.TabIndex = 0
        Me.tpRestricciones.Text = "Restricciones"
        Me.tpRestricciones.UseVisualStyleBackColor = True
        '
        'SgcGroupBox3
        '
        Me.SgcGroupBox3.Controls.Add(Me.dgvRestricciones)
        Me.SgcGroupBox3.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SgcGroupBox3.Location = New System.Drawing.Point(11, 3)
        Me.SgcGroupBox3.Name = "SgcGroupBox3"
        Me.SgcGroupBox3.Size = New System.Drawing.Size(869, 206)
        Me.SgcGroupBox3.TabIndex = 10
        Me.SgcGroupBox3.TabStop = False
        Me.SgcGroupBox3.Text = "Restricciones"
        '
        'dgvRestricciones
        '
        Me.dgvRestricciones.AllowUserToAddRows = False
        Me.dgvRestricciones.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.WhiteSmoke
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.SteelBlue
        Me.dgvRestricciones.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvRestricciones.BackgroundColor = System.Drawing.Color.WhiteSmoke
        Me.dgvRestricciones.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dgvRestricciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvRestricciones.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colRestriccionID, Me.colDescripcionRestriccion, Me.colCondicionRestriccion, Me.colCantidadRestriccion})
        Me.dgvRestricciones.Location = New System.Drawing.Point(7, 18)
        Me.dgvRestricciones.Name = "dgvRestricciones"
        Me.dgvRestricciones.ReadOnly = True
        Me.dgvRestricciones.Size = New System.Drawing.Size(856, 182)
        Me.dgvRestricciones.TabIndex = 4
        '
        'colRestriccionID
        '
        Me.colRestriccionID.HeaderText = ""
        Me.colRestriccionID.Name = "colRestriccionID"
        Me.colRestriccionID.ReadOnly = True
        Me.colRestriccionID.Visible = False
        '
        'colDescripcionRestriccion
        '
        Me.colDescripcionRestriccion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.colDescripcionRestriccion.HeaderText = "Descripción"
        Me.colDescripcionRestriccion.Name = "colDescripcionRestriccion"
        Me.colDescripcionRestriccion.ReadOnly = True
        '
        'colCondicionRestriccion
        '
        Me.colCondicionRestriccion.HeaderText = "Condición"
        Me.colCondicionRestriccion.Name = "colCondicionRestriccion"
        Me.colCondicionRestriccion.ReadOnly = True
        Me.colCondicionRestriccion.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        '
        'colCantidadRestriccion
        '
        Me.colCantidadRestriccion.HeaderText = "Cantidad"
        Me.colCantidadRestriccion.MaxInputLength = 2
        Me.colCantidadRestriccion.Name = "colCantidadRestriccion"
        Me.colCantidadRestriccion.ReadOnly = True
        '
        'tpPersonal
        '
        Me.tpPersonal.Controls.Add(Me.SgcGroupBox5)
        Me.tpPersonal.Controls.Add(Me.SgcGroupBox7)
        Me.tpPersonal.Location = New System.Drawing.Point(4, 27)
        Me.tpPersonal.Name = "tpPersonal"
        Me.tpPersonal.Size = New System.Drawing.Size(892, 215)
        Me.tpPersonal.TabIndex = 2
        Me.tpPersonal.Text = "Personal"
        Me.tpPersonal.UseVisualStyleBackColor = True
        '
        'SgcGroupBox5
        '
        Me.SgcGroupBox5.Controls.Add(Me.btnQuitarPersonal)
        Me.SgcGroupBox5.Controls.Add(Me.btnAgregarPersonal)
        Me.SgcGroupBox5.Controls.Add(Me.dgvPersonal)
        Me.SgcGroupBox5.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SgcGroupBox5.Location = New System.Drawing.Point(392, 3)
        Me.SgcGroupBox5.Name = "SgcGroupBox5"
        Me.SgcGroupBox5.Size = New System.Drawing.Size(460, 207)
        Me.SgcGroupBox5.TabIndex = 14
        Me.SgcGroupBox5.TabStop = False
        Me.SgcGroupBox5.Text = "Personal"
        '
        'btnQuitarPersonal
        '
        Me.btnQuitarPersonal.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnQuitarPersonal.FlatAppearance.BorderColor = System.Drawing.Color.Silver
        Me.btnQuitarPersonal.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnQuitarPersonal.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnQuitarPersonal.ForeColor = System.Drawing.Color.SteelBlue
        Me.btnQuitarPersonal.Image = Global.SGC_CS.My.Resources.Resources.btn_eliminar
        Me.btnQuitarPersonal.Location = New System.Drawing.Point(364, 62)
        Me.btnQuitarPersonal.Name = "btnQuitarPersonal"
        Me.btnQuitarPersonal.Size = New System.Drawing.Size(90, 31)
        Me.btnQuitarPersonal.TabIndex = 14
        Me.btnQuitarPersonal.Text = "Quitar"
        Me.btnQuitarPersonal.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnQuitarPersonal.UseVisualStyleBackColor = False
        '
        'btnAgregarPersonal
        '
        Me.btnAgregarPersonal.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnAgregarPersonal.FlatAppearance.BorderColor = System.Drawing.Color.Silver
        Me.btnAgregarPersonal.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAgregarPersonal.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAgregarPersonal.ForeColor = System.Drawing.Color.SteelBlue
        Me.btnAgregarPersonal.Image = Global.SGC_CS.My.Resources.Resources.btn_agregar
        Me.btnAgregarPersonal.Location = New System.Drawing.Point(364, 25)
        Me.btnAgregarPersonal.Name = "btnAgregarPersonal"
        Me.btnAgregarPersonal.Size = New System.Drawing.Size(90, 31)
        Me.btnAgregarPersonal.TabIndex = 13
        Me.btnAgregarPersonal.Text = "Agregar"
        Me.btnAgregarPersonal.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnAgregarPersonal.UseVisualStyleBackColor = False
        '
        'dgvPersonal
        '
        Me.dgvPersonal.AllowUserToAddRows = False
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.WhiteSmoke
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.SteelBlue
        Me.dgvPersonal.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvPersonal.BackgroundColor = System.Drawing.Color.WhiteSmoke
        Me.dgvPersonal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dgvPersonal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvPersonal.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colNombre})
        Me.dgvPersonal.Location = New System.Drawing.Point(15, 25)
        Me.dgvPersonal.Name = "dgvPersonal"
        Me.dgvPersonal.ReadOnly = True
        Me.dgvPersonal.Size = New System.Drawing.Size(342, 171)
        Me.dgvPersonal.TabIndex = 1
        '
        'colNombre
        '
        Me.colNombre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.colNombre.HeaderText = "Nombre"
        Me.colNombre.Name = "colNombre"
        Me.colNombre.ReadOnly = True
        '
        'SgcGroupBox7
        '
        Me.SgcGroupBox7.Controls.Add(Me.dgvTipoPersonal)
        Me.SgcGroupBox7.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SgcGroupBox7.Location = New System.Drawing.Point(11, 3)
        Me.SgcGroupBox7.Name = "SgcGroupBox7"
        Me.SgcGroupBox7.Size = New System.Drawing.Size(375, 207)
        Me.SgcGroupBox7.TabIndex = 13
        Me.SgcGroupBox7.TabStop = False
        Me.SgcGroupBox7.Text = "Tipo de Personal"
        '
        'dgvTipoPersonal
        '
        Me.dgvTipoPersonal.AllowUserToAddRows = False
        Me.dgvTipoPersonal.AllowUserToDeleteRows = False
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.WhiteSmoke
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.SteelBlue
        Me.dgvTipoPersonal.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle3
        Me.dgvTipoPersonal.BackgroundColor = System.Drawing.Color.WhiteSmoke
        Me.dgvTipoPersonal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dgvTipoPersonal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvTipoPersonal.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colTipoPersonalID, Me.colDescripcionTipoPersonal, Me.colCantidadTipoPersonal})
        Me.dgvTipoPersonal.Location = New System.Drawing.Point(7, 16)
        Me.dgvTipoPersonal.Name = "dgvTipoPersonal"
        Me.dgvTipoPersonal.ReadOnly = True
        Me.dgvTipoPersonal.Size = New System.Drawing.Size(362, 180)
        Me.dgvTipoPersonal.TabIndex = 2
        '
        'colTipoPersonalID
        '
        Me.colTipoPersonalID.HeaderText = ""
        Me.colTipoPersonalID.Name = "colTipoPersonalID"
        Me.colTipoPersonalID.ReadOnly = True
        Me.colTipoPersonalID.Visible = False
        '
        'colDescripcionTipoPersonal
        '
        Me.colDescripcionTipoPersonal.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.colDescripcionTipoPersonal.HeaderText = "Descripción"
        Me.colDescripcionTipoPersonal.Name = "colDescripcionTipoPersonal"
        Me.colDescripcionTipoPersonal.ReadOnly = True
        '
        'colCantidadTipoPersonal
        '
        Me.colCantidadTipoPersonal.HeaderText = "Cantidad"
        Me.colCantidadTipoPersonal.Name = "colCantidadTipoPersonal"
        Me.colCantidadTipoPersonal.ReadOnly = True
        '
        'tpRecursos
        '
        Me.tpRecursos.Controls.Add(Me.SgcGroupBox6)
        Me.tpRecursos.Location = New System.Drawing.Point(4, 27)
        Me.tpRecursos.Name = "tpRecursos"
        Me.tpRecursos.Size = New System.Drawing.Size(892, 215)
        Me.tpRecursos.TabIndex = 3
        Me.tpRecursos.Text = "Recursos"
        Me.tpRecursos.UseVisualStyleBackColor = True
        '
        'SgcGroupBox6
        '
        Me.SgcGroupBox6.Controls.Add(Me.dgvRecursos)
        Me.SgcGroupBox6.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SgcGroupBox6.Location = New System.Drawing.Point(9, 3)
        Me.SgcGroupBox6.Name = "SgcGroupBox6"
        Me.SgcGroupBox6.Size = New System.Drawing.Size(454, 201)
        Me.SgcGroupBox6.TabIndex = 16
        Me.SgcGroupBox6.TabStop = False
        Me.SgcGroupBox6.Text = "Recursos"
        '
        'dgvRecursos
        '
        Me.dgvRecursos.AllowUserToAddRows = False
        Me.dgvRecursos.AllowUserToDeleteRows = False
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.WhiteSmoke
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.SteelBlue
        Me.dgvRecursos.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle4
        Me.dgvRecursos.BackgroundColor = System.Drawing.Color.WhiteSmoke
        Me.dgvRecursos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dgvRecursos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvRecursos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colDescripcionRecurso, Me.colCantidadRecurso, Me.colCantidadReal})
        Me.dgvRecursos.Location = New System.Drawing.Point(9, 21)
        Me.dgvRecursos.Name = "dgvRecursos"
        Me.dgvRecursos.Size = New System.Drawing.Size(439, 174)
        Me.dgvRecursos.TabIndex = 2
        '
        'colDescripcionRecurso
        '
        Me.colDescripcionRecurso.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.colDescripcionRecurso.HeaderText = "Descripción"
        Me.colDescripcionRecurso.Name = "colDescripcionRecurso"
        '
        'colCantidadRecurso
        '
        Me.colCantidadRecurso.HeaderText = "Cantidad"
        Me.colCantidadRecurso.Name = "colCantidadRecurso"
        '
        'colCantidadReal
        '
        Me.colCantidadReal.HeaderText = "Cantidad Real"
        Me.colCantidadReal.Name = "colCantidadReal"
        Me.colCantidadReal.Width = 120
        '
        'tsMenu
        '
        Me.tsMenu.BackColor = System.Drawing.Color.Silver
        Me.tsMenu.Dock = System.Windows.Forms.DockStyle.None
        Me.tsMenu.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tsMenu.ImageScalingSize = New System.Drawing.Size(30, 30)
        Me.tsMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsbLimpiar, Me.tsbHabilitar})
        Me.tsMenu.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow
        Me.tsMenu.Location = New System.Drawing.Point(60, 51)
        Me.tsMenu.Name = "tsMenu"
        Me.tsMenu.Size = New System.Drawing.Size(91, 37)
        Me.tsMenu.TabIndex = 21
        Me.tsMenu.Text = "SgcToolStrip1"
        '
        'tsbLimpiar
        '
        Me.tsbLimpiar.BackColor = System.Drawing.Color.WhiteSmoke
        Me.tsbLimpiar.Image = Global.SGC_CS.My.Resources.Resources.menu_limpiar
        Me.tsbLimpiar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbLimpiar.Margin = New System.Windows.Forms.Padding(1, 1, 1, 2)
        Me.tsbLimpiar.Name = "tsbLimpiar"
        Me.tsbLimpiar.Size = New System.Drawing.Size(88, 34)
        Me.tsbLimpiar.Text = "Limpiar"
        '
        'tsbHabilitar
        '
        Me.tsbHabilitar.BackColor = System.Drawing.Color.WhiteSmoke
        Me.tsbHabilitar.Image = Global.SGC_CS.My.Resources.Resources.menu_validar
        Me.tsbHabilitar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbHabilitar.Margin = New System.Windows.Forms.Padding(1, 1, 1, 2)
        Me.tsbHabilitar.Name = "tsbHabilitar"
        Me.tsbHabilitar.Size = New System.Drawing.Size(95, 34)
        Me.tsbHabilitar.Text = "Habilitar"
        Me.tsbHabilitar.Visible = False
        '
        'SgcGroupBox2
        '
        Me.SgcGroupBox2.Controls.Add(Me.dgvProgramacion)
        Me.SgcGroupBox2.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SgcGroupBox2.Location = New System.Drawing.Point(606, 91)
        Me.SgcGroupBox2.Name = "SgcGroupBox2"
        Me.SgcGroupBox2.Size = New System.Drawing.Size(354, 225)
        Me.SgcGroupBox2.TabIndex = 20
        Me.SgcGroupBox2.TabStop = False
        Me.SgcGroupBox2.Text = "Programación"
        '
        'dgvProgramacion
        '
        Me.dgvProgramacion.AllowUserToAddRows = False
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.WhiteSmoke
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.SteelBlue
        Me.dgvProgramacion.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle5
        Me.dgvProgramacion.BackgroundColor = System.Drawing.Color.WhiteSmoke
        Me.dgvProgramacion.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dgvProgramacion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvProgramacion.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colSede, Me.colEspacio, Me.colFecInicio, Me.colHoraInicio, Me.colFecFin, Me.colHoraFin, Me.colVacantes})
        Me.dgvProgramacion.Location = New System.Drawing.Point(18, 31)
        Me.dgvProgramacion.Name = "dgvProgramacion"
        Me.dgvProgramacion.ReadOnly = True
        Me.dgvProgramacion.Size = New System.Drawing.Size(320, 177)
        Me.dgvProgramacion.TabIndex = 1
        '
        'SgcGroupBox1
        '
        Me.SgcGroupBox1.Controls.Add(Me.lblCategoria)
        Me.SgcGroupBox1.Controls.Add(Me.lblVacantes)
        Me.SgcGroupBox1.Controls.Add(Me.lblPago)
        Me.SgcGroupBox1.Controls.Add(Me.lblDescripcion)
        Me.SgcGroupBox1.Controls.Add(Me.lblNombre)
        Me.SgcGroupBox1.Controls.Add(Me.lblTipo)
        Me.SgcGroupBox1.Controls.Add(Me.lblCodigo)
        Me.SgcGroupBox1.Controls.Add(Me.lblComite)
        Me.SgcGroupBox1.Controls.Add(Me.SgcLabel6)
        Me.SgcGroupBox1.Controls.Add(Me.btnBuscarActividad)
        Me.SgcGroupBox1.Controls.Add(Me.SgcLabel12)
        Me.SgcGroupBox1.Controls.Add(Me.SgcLabel11)
        Me.SgcGroupBox1.Controls.Add(Me.SgcLabel10)
        Me.SgcGroupBox1.Controls.Add(Me.SgcLabel7)
        Me.SgcGroupBox1.Controls.Add(Me.SgcLabel4)
        Me.SgcGroupBox1.Controls.Add(Me.SgcLabel3)
        Me.SgcGroupBox1.Controls.Add(Me.SgcLabel2)
        Me.SgcGroupBox1.Controls.Add(Me.SgcLabel1)
        Me.SgcGroupBox1.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SgcGroupBox1.Location = New System.Drawing.Point(60, 91)
        Me.SgcGroupBox1.Name = "SgcGroupBox1"
        Me.SgcGroupBox1.Size = New System.Drawing.Size(532, 225)
        Me.SgcGroupBox1.TabIndex = 19
        Me.SgcGroupBox1.TabStop = False
        Me.SgcGroupBox1.Text = "Datos"
        '
        'lblCategoria
        '
        Me.lblCategoria.AutoSize = True
        Me.lblCategoria.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCategoria.ForeColor = System.Drawing.Color.Black
        Me.lblCategoria.Location = New System.Drawing.Point(356, 104)
        Me.lblCategoria.Name = "lblCategoria"
        Me.lblCategoria.Size = New System.Drawing.Size(83, 18)
        Me.lblCategoria.TabIndex = 32
        Me.lblCategoria.Text = "lblCategoria"
        '
        'lblVacantes
        '
        Me.lblVacantes.AutoSize = True
        Me.lblVacantes.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVacantes.ForeColor = System.Drawing.Color.Black
        Me.lblVacantes.Location = New System.Drawing.Point(356, 72)
        Me.lblVacantes.Name = "lblVacantes"
        Me.lblVacantes.Size = New System.Drawing.Size(79, 18)
        Me.lblVacantes.TabIndex = 31
        Me.lblVacantes.Text = "lblVacantes"
        '
        'lblPago
        '
        Me.lblPago.AutoSize = True
        Me.lblPago.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPago.ForeColor = System.Drawing.Color.Black
        Me.lblPago.Location = New System.Drawing.Point(356, 39)
        Me.lblPago.Name = "lblPago"
        Me.lblPago.Size = New System.Drawing.Size(54, 18)
        Me.lblPago.TabIndex = 30
        Me.lblPago.Text = "lblPago"
        '
        'lblDescripcion
        '
        Me.lblDescripcion.AutoSize = True
        Me.lblDescripcion.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDescripcion.ForeColor = System.Drawing.Color.Black
        Me.lblDescripcion.Location = New System.Drawing.Point(109, 168)
        Me.lblDescripcion.Name = "lblDescripcion"
        Me.lblDescripcion.Size = New System.Drawing.Size(96, 18)
        Me.lblDescripcion.TabIndex = 29
        Me.lblDescripcion.Text = "lblDescripcion"
        '
        'lblNombre
        '
        Me.lblNombre.AutoSize = True
        Me.lblNombre.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombre.ForeColor = System.Drawing.Color.Black
        Me.lblNombre.Location = New System.Drawing.Point(109, 136)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(75, 18)
        Me.lblNombre.TabIndex = 28
        Me.lblNombre.Text = "lblNombre"
        '
        'lblTipo
        '
        Me.lblTipo.AutoSize = True
        Me.lblTipo.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTipo.ForeColor = System.Drawing.Color.Black
        Me.lblTipo.Location = New System.Drawing.Point(110, 104)
        Me.lblTipo.Name = "lblTipo"
        Me.lblTipo.Size = New System.Drawing.Size(51, 18)
        Me.lblTipo.TabIndex = 27
        Me.lblTipo.Text = "lblTipo"
        '
        'lblCodigo
        '
        Me.lblCodigo.AutoSize = True
        Me.lblCodigo.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCodigo.ForeColor = System.Drawing.Color.Black
        Me.lblCodigo.Location = New System.Drawing.Point(110, 39)
        Me.lblCodigo.Name = "lblCodigo"
        Me.lblCodigo.Size = New System.Drawing.Size(67, 18)
        Me.lblCodigo.TabIndex = 26
        Me.lblCodigo.Text = "lblCodigo"
        '
        'lblComite
        '
        Me.lblComite.AutoSize = True
        Me.lblComite.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblComite.ForeColor = System.Drawing.Color.Black
        Me.lblComite.Location = New System.Drawing.Point(110, 72)
        Me.lblComite.Name = "lblComite"
        Me.lblComite.Size = New System.Drawing.Size(69, 18)
        Me.lblComite.TabIndex = 25
        Me.lblComite.Text = "lblComite"
        '
        'SgcLabel6
        '
        Me.SgcLabel6.AutoSize = True
        Me.SgcLabel6.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SgcLabel6.ForeColor = System.Drawing.Color.SteelBlue
        Me.SgcLabel6.Location = New System.Drawing.Point(279, 72)
        Me.SgcLabel6.Name = "SgcLabel6"
        Me.SgcLabel6.Size = New System.Drawing.Size(67, 18)
        Me.SgcLabel6.TabIndex = 24
        Me.SgcLabel6.Text = "Vacantes:"
        '
        'btnBuscarActividad
        '
        Me.btnBuscarActividad.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnBuscarActividad.FlatAppearance.BorderColor = System.Drawing.Color.Silver
        Me.btnBuscarActividad.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBuscarActividad.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBuscarActividad.ForeColor = System.Drawing.Color.SteelBlue
        Me.btnBuscarActividad.Image = Global.SGC_CS.My.Resources.Resources.btn_buscar
        Me.btnBuscarActividad.Location = New System.Drawing.Point(215, 33)
        Me.btnBuscarActividad.Name = "btnBuscarActividad"
        Me.btnBuscarActividad.Size = New System.Drawing.Size(45, 31)
        Me.btnBuscarActividad.TabIndex = 23
        Me.btnBuscarActividad.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnBuscarActividad.UseVisualStyleBackColor = False
        '
        'SgcLabel12
        '
        Me.SgcLabel12.AutoSize = True
        Me.SgcLabel12.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SgcLabel12.ForeColor = System.Drawing.Color.SteelBlue
        Me.SgcLabel12.Location = New System.Drawing.Point(19, 168)
        Me.SgcLabel12.Name = "SgcLabel12"
        Me.SgcLabel12.Size = New System.Drawing.Size(84, 18)
        Me.SgcLabel12.TabIndex = 20
        Me.SgcLabel12.Text = "Descripción:"
        '
        'SgcLabel11
        '
        Me.SgcLabel11.AutoSize = True
        Me.SgcLabel11.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SgcLabel11.ForeColor = System.Drawing.Color.SteelBlue
        Me.SgcLabel11.Location = New System.Drawing.Point(19, 136)
        Me.SgcLabel11.Name = "SgcLabel11"
        Me.SgcLabel11.Size = New System.Drawing.Size(63, 18)
        Me.SgcLabel11.TabIndex = 16
        Me.SgcLabel11.Text = "Nombre:"
        '
        'SgcLabel10
        '
        Me.SgcLabel10.AutoSize = True
        Me.SgcLabel10.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SgcLabel10.ForeColor = System.Drawing.Color.Black
        Me.SgcLabel10.Location = New System.Drawing.Point(438, 39)
        Me.SgcLabel10.Name = "SgcLabel10"
        Me.SgcLabel10.Size = New System.Drawing.Size(56, 18)
        Me.SgcLabel10.TabIndex = 14
        Me.SgcLabel10.Text = "soles(s)"
        '
        'SgcLabel7
        '
        Me.SgcLabel7.AutoSize = True
        Me.SgcLabel7.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SgcLabel7.ForeColor = System.Drawing.Color.SteelBlue
        Me.SgcLabel7.Location = New System.Drawing.Point(279, 42)
        Me.SgcLabel7.Name = "SgcLabel7"
        Me.SgcLabel7.Size = New System.Drawing.Size(42, 18)
        Me.SgcLabel7.TabIndex = 8
        Me.SgcLabel7.Text = "Pago:"
        '
        'SgcLabel4
        '
        Me.SgcLabel4.AutoSize = True
        Me.SgcLabel4.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SgcLabel4.ForeColor = System.Drawing.Color.SteelBlue
        Me.SgcLabel4.Location = New System.Drawing.Point(279, 104)
        Me.SgcLabel4.Name = "SgcLabel4"
        Me.SgcLabel4.Size = New System.Drawing.Size(71, 18)
        Me.SgcLabel4.TabIndex = 6
        Me.SgcLabel4.Text = "Categoria:"
        '
        'SgcLabel3
        '
        Me.SgcLabel3.AutoSize = True
        Me.SgcLabel3.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SgcLabel3.ForeColor = System.Drawing.Color.SteelBlue
        Me.SgcLabel3.Location = New System.Drawing.Point(19, 104)
        Me.SgcLabel3.Name = "SgcLabel3"
        Me.SgcLabel3.Size = New System.Drawing.Size(39, 18)
        Me.SgcLabel3.TabIndex = 2
        Me.SgcLabel3.Text = "Tipo:"
        '
        'SgcLabel2
        '
        Me.SgcLabel2.AutoSize = True
        Me.SgcLabel2.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SgcLabel2.ForeColor = System.Drawing.Color.SteelBlue
        Me.SgcLabel2.Location = New System.Drawing.Point(19, 72)
        Me.SgcLabel2.Name = "SgcLabel2"
        Me.SgcLabel2.Size = New System.Drawing.Size(57, 18)
        Me.SgcLabel2.TabIndex = 1
        Me.SgcLabel2.Text = "Comite:"
        '
        'SgcLabel1
        '
        Me.SgcLabel1.AutoSize = True
        Me.SgcLabel1.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SgcLabel1.ForeColor = System.Drawing.Color.SteelBlue
        Me.SgcLabel1.Location = New System.Drawing.Point(19, 39)
        Me.SgcLabel1.Name = "SgcLabel1"
        Me.SgcLabel1.Size = New System.Drawing.Size(55, 18)
        Me.SgcLabel1.TabIndex = 0
        Me.SgcLabel1.Text = "Codigo:"
        '
        'lblTitulo
        '
        Me.lblTitulo.AutoSize = True
        Me.lblTitulo.BackColor = System.Drawing.Color.ForestGreen
        Me.lblTitulo.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitulo.ForeColor = System.Drawing.Color.White
        Me.lblTitulo.Location = New System.Drawing.Point(397, 9)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(157, 23)
        Me.lblTitulo.TabIndex = 23
        Me.lblTitulo.Text = "Habilitar Actividad"
        '
        'colSede
        '
        Me.colSede.HeaderText = "Sede"
        Me.colSede.Name = "colSede"
        Me.colSede.ReadOnly = True
        '
        'colEspacio
        '
        Me.colEspacio.HeaderText = "Espacio"
        Me.colEspacio.Name = "colEspacio"
        Me.colEspacio.ReadOnly = True
        '
        'colFecInicio
        '
        Me.colFecInicio.HeaderText = "Fec. Inicio"
        Me.colFecInicio.Name = "colFecInicio"
        Me.colFecInicio.ReadOnly = True
        '
        'colHoraInicio
        '
        Me.colHoraInicio.HeaderText = "H. Inicio"
        Me.colHoraInicio.Name = "colHoraInicio"
        Me.colHoraInicio.ReadOnly = True
        '
        'colFecFin
        '
        Me.colFecFin.HeaderText = "Fec. Fin"
        Me.colFecFin.Name = "colFecFin"
        Me.colFecFin.ReadOnly = True
        '
        'colHoraFin
        '
        Me.colHoraFin.HeaderText = "H. Fin"
        Me.colHoraFin.Name = "colHoraFin"
        Me.colHoraFin.ReadOnly = True
        '
        'colVacantes
        '
        Me.colVacantes.HeaderText = "Vacantes"
        Me.colVacantes.Name = "colVacantes"
        Me.colVacantes.ReadOnly = True
        '
        'frmHabilitarActividad
        '
        Me.ClientSize = New System.Drawing.Size(1016, 733)
        Me.Controls.Add(Me.lblTitulo)
        Me.Controls.Add(Me.tcPlanAnual)
        Me.Controls.Add(Me.tsMenu)
        Me.Controls.Add(Me.SgcGroupBox2)
        Me.Controls.Add(Me.SgcGroupBox1)
        Me.Name = "frmHabilitarActividad"
        Me.Controls.SetChildIndex(Me.SgcGroupBox1, 0)
        Me.Controls.SetChildIndex(Me.SgcGroupBox2, 0)
        Me.Controls.SetChildIndex(Me.tsMenu, 0)
        Me.Controls.SetChildIndex(Me.tcPlanAnual, 0)
        Me.Controls.SetChildIndex(Me.lblTitulo, 0)
        Me.tcPlanAnual.ResumeLayout(false)
        Me.tpRestricciones.ResumeLayout(false)
        Me.SgcGroupBox3.ResumeLayout(false)
        CType(Me.dgvRestricciones,System.ComponentModel.ISupportInitialize).EndInit
        Me.tpPersonal.ResumeLayout(false)
        Me.SgcGroupBox5.ResumeLayout(false)
        CType(Me.dgvPersonal,System.ComponentModel.ISupportInitialize).EndInit
        Me.SgcGroupBox7.ResumeLayout(false)
        CType(Me.dgvTipoPersonal,System.ComponentModel.ISupportInitialize).EndInit
        Me.tpRecursos.ResumeLayout(false)
        Me.SgcGroupBox6.ResumeLayout(false)
        CType(Me.dgvRecursos,System.ComponentModel.ISupportInitialize).EndInit
        Me.tsMenu.ResumeLayout(false)
        Me.tsMenu.PerformLayout
        Me.SgcGroupBox2.ResumeLayout(false)
        CType(Me.dgvProgramacion,System.ComponentModel.ISupportInitialize).EndInit
        Me.SgcGroupBox1.ResumeLayout(false)
        Me.SgcGroupBox1.PerformLayout
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub
    Friend WithEvents tcPlanAnual As SGC_CS.SGCTabControl
    Friend WithEvents tpRestricciones As System.Windows.Forms.TabPage
    Friend WithEvents SgcGroupBox3 As SGC_CS.SGCGroupBox
    Friend WithEvents tpPersonal As System.Windows.Forms.TabPage
    Friend WithEvents tpRecursos As System.Windows.Forms.TabPage
    Friend WithEvents tsMenu As SGC_CS.SGCToolStrip
    Friend WithEvents tsbLimpiar As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsbHabilitar As System.Windows.Forms.ToolStripButton
    Friend WithEvents SgcGroupBox2 As SGC_CS.SGCGroupBox
    Friend WithEvents dgvProgramacion As SGC_CS.SGCDataGridView
    Friend WithEvents SgcGroupBox1 As SGC_CS.SGCGroupBox
    Friend WithEvents SgcLabel12 As SGC_CS.SGCLabel
    Friend WithEvents SgcLabel11 As SGC_CS.SGCLabel
    Friend WithEvents SgcLabel10 As SGC_CS.SGCLabel
    Friend WithEvents SgcLabel7 As SGC_CS.SGCLabel
    Friend WithEvents SgcLabel4 As SGC_CS.SGCLabel
    Friend WithEvents SgcLabel3 As SGC_CS.SGCLabel
    Friend WithEvents SgcLabel2 As SGC_CS.SGCLabel
    Friend WithEvents SgcLabel1 As SGC_CS.SGCLabel
    Friend WithEvents SgcGroupBox5 As SGC_CS.SGCGroupBox
    Friend WithEvents dgvPersonal As SGC_CS.SGCDataGridView
    Friend WithEvents SgcGroupBox7 As SGC_CS.SGCGroupBox
    Friend WithEvents btnQuitarPersonal As SGC_CS.SGCButton
    Friend WithEvents btnAgregarPersonal As SGC_CS.SGCButton
    Friend WithEvents SgcGroupBox6 As SGC_CS.SGCGroupBox
    Friend WithEvents btnBuscarActividad As SGC_CS.SGCButton
    Friend WithEvents SgcLabel6 As SGC_CS.SGCLabel
    Friend WithEvents lblTitulo As SGC_CS.SGCLabel
    Friend WithEvents dgvRestricciones As SGC_CS.SGCDataGridView
    Friend WithEvents dgvTipoPersonal As SGC_CS.SGCDataGridView
    Friend WithEvents dgvRecursos As SGC_CS.SGCDataGridView
    Friend WithEvents colDescripcionRecurso As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colCantidadRecurso As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colCantidadReal As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents lblCategoria As SGC_CS.SGCLabel
    Friend WithEvents lblVacantes As SGC_CS.SGCLabel
    Friend WithEvents lblPago As SGC_CS.SGCLabel
    Friend WithEvents lblDescripcion As SGC_CS.SGCLabel
    Friend WithEvents lblNombre As SGC_CS.SGCLabel
    Friend WithEvents lblTipo As SGC_CS.SGCLabel
    Friend WithEvents lblCodigo As SGC_CS.SGCLabel
    Friend WithEvents lblComite As SGC_CS.SGCLabel
    Friend WithEvents colNombre As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colTipoPersonalID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colDescripcionTipoPersonal As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colCantidadTipoPersonal As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colRestriccionID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colDescripcionRestriccion As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colCondicionRestriccion As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colCantidadRestriccion As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colSede As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colEspacio As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colFecInicio As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colHoraInicio As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colFecFin As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colHoraFin As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colVacantes As System.Windows.Forms.DataGridViewTextBoxColumn

End Class
