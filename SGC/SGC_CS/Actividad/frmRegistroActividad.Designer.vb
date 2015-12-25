<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRegistroActividad
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
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmRegistroActividad))
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.SgcGroupBox1 = New SGC_CS.SGCGroupBox(Me.components)
        Me.btnBuscarActividad = New SGC_CS.SGCButton(Me.components)
        Me.nudVacantes = New SGC_CS.SGCNumericUpDown(Me.components)
        Me.lblVacantes = New SGC_CS.SGCLabel(Me.components)
        Me.lblDescripcion = New SGC_CS.SGCLabel(Me.components)
        Me.txtDescripcion = New SGC_CS.SGCTextBox(Me.components)
        Me.txtNombre = New SGC_CS.SGCTextBox(Me.components)
        Me.lblNombre = New SGC_CS.SGCLabel(Me.components)
        Me.lblSoles = New SGC_CS.SGCLabel(Me.components)
        Me.nudPago = New SGC_CS.SGCNumericUpDown(Me.components)
        Me.lblPago = New SGC_CS.SGCLabel(Me.components)
        Me.cboCategoria = New SGC_CS.SGCComboBox(Me.components)
        Me.lblCategoria = New SGC_CS.SGCLabel(Me.components)
        Me.cboTipo = New SGC_CS.SGCComboBox(Me.components)
        Me.cboComite = New SGC_CS.SGCComboBox(Me.components)
        Me.txtCodigo = New SGC_CS.SGCTextBox(Me.components)
        Me.lblTipo = New SGC_CS.SGCLabel(Me.components)
        Me.lblComite = New SGC_CS.SGCLabel(Me.components)
        Me.lblCodigo = New SGC_CS.SGCLabel(Me.components)
        Me.SgcGroupBox2 = New SGC_CS.SGCGroupBox(Me.components)
        Me.dgvProgramacion = New SGC_CS.SGCDataGridView(Me.components)
        Me.colSede = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colEspacio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colFecInicio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colHoraInicio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colFecFin = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colHoraFin = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnEscoger = New SGC_CS.SGCButton(Me.components)
        Me.SgcGroupBox3 = New SGC_CS.SGCGroupBox(Me.components)
        Me.dgvRestricciones = New SGC_CS.SGCDataGridView(Me.components)
        Me.colSeleccionar = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.colRestriccionID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colDescripcionRestriccion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colCondicionRestriccion = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.colCantidadRestriccion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colFlgCondicion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnQuitarTipoPersonal = New SGC_CS.SGCButton(Me.components)
        Me.btnAgregarTipoPersonal = New SGC_CS.SGCButton(Me.components)
        Me.tsMenu = New SGC_CS.SGCToolStrip(Me.components)
        Me.tsbLimpiar = New System.Windows.Forms.ToolStripButton()
        Me.tsbGuardar = New System.Windows.Forms.ToolStripButton()
        Me.tsbEditar = New System.Windows.Forms.ToolStripButton()
        Me.tsbEliminar = New System.Windows.Forms.ToolStripButton()
        Me.tsbCancelar = New System.Windows.Forms.ToolStripButton()
        Me.tsbReprogramacion = New System.Windows.Forms.ToolStripButton()
        Me.tcPlanAnual = New SGC_CS.SGCTabControl(Me.components)
        Me.tpRestricciones = New System.Windows.Forms.TabPage()
        Me.tpTipoPersonal = New System.Windows.Forms.TabPage()
        Me.SgcGroupBox7 = New SGC_CS.SGCGroupBox(Me.components)
        Me.btnBuscarPersonal = New SGC_CS.SGCButton(Me.components)
        Me.SgcLabel3 = New SGC_CS.SGCLabel(Me.components)
        Me.txtCantidadPersonal = New SGC_CS.SGCTextBox(Me.components)
        Me.txtDescripcionPersonal = New SGC_CS.SGCTextBox(Me.components)
        Me.SgcLabel4 = New SGC_CS.SGCLabel(Me.components)
        Me.dgvTipoPersonal = New SGC_CS.SGCDataGridView(Me.components)
        Me.colDescripcionPersonal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colCantidadPersonal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tpRecursos = New System.Windows.Forms.TabPage()
        Me.SgcGroupBox5 = New SGC_CS.SGCGroupBox(Me.components)
        Me.btnBuscarRecurso = New SGC_CS.SGCButton(Me.components)
        Me.SgcLabel2 = New SGC_CS.SGCLabel(Me.components)
        Me.txtCantidadRecurso = New SGC_CS.SGCTextBox(Me.components)
        Me.txtDescripcionRecurso = New SGC_CS.SGCTextBox(Me.components)
        Me.SgcLabel1 = New SGC_CS.SGCLabel(Me.components)
        Me.dgvRecursos = New SGC_CS.SGCDataGridView(Me.components)
        Me.colDescripcionRecurso = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colCantidadRecurso = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnQuitarRecurso = New SGC_CS.SGCButton(Me.components)
        Me.btnAgregarRecurso = New SGC_CS.SGCButton(Me.components)
        Me.lblTitulo = New SGC_CS.SGCLabel(Me.components)
        Me.btnLimpiar = New SGC_CS.SGCButton(Me.components)
        Me.SgcGroupBox1.SuspendLayout()
        CType(Me.nudVacantes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudPago, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SgcGroupBox2.SuspendLayout()
        CType(Me.dgvProgramacion, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SgcGroupBox3.SuspendLayout()
        CType(Me.dgvRestricciones, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tsMenu.SuspendLayout()
        Me.tcPlanAnual.SuspendLayout()
        Me.tpRestricciones.SuspendLayout()
        Me.tpTipoPersonal.SuspendLayout()
        Me.SgcGroupBox7.SuspendLayout()
        CType(Me.dgvTipoPersonal, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tpRecursos.SuspendLayout()
        Me.SgcGroupBox5.SuspendLayout()
        CType(Me.dgvRecursos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SgcGroupBox1
        '
        Me.SgcGroupBox1.Controls.Add(Me.btnBuscarActividad)
        Me.SgcGroupBox1.Controls.Add(Me.nudVacantes)
        Me.SgcGroupBox1.Controls.Add(Me.lblVacantes)
        Me.SgcGroupBox1.Controls.Add(Me.lblDescripcion)
        Me.SgcGroupBox1.Controls.Add(Me.txtDescripcion)
        Me.SgcGroupBox1.Controls.Add(Me.txtNombre)
        Me.SgcGroupBox1.Controls.Add(Me.lblNombre)
        Me.SgcGroupBox1.Controls.Add(Me.lblSoles)
        Me.SgcGroupBox1.Controls.Add(Me.nudPago)
        Me.SgcGroupBox1.Controls.Add(Me.lblPago)
        Me.SgcGroupBox1.Controls.Add(Me.cboCategoria)
        Me.SgcGroupBox1.Controls.Add(Me.lblCategoria)
        Me.SgcGroupBox1.Controls.Add(Me.cboTipo)
        Me.SgcGroupBox1.Controls.Add(Me.cboComite)
        Me.SgcGroupBox1.Controls.Add(Me.txtCodigo)
        Me.SgcGroupBox1.Controls.Add(Me.lblTipo)
        Me.SgcGroupBox1.Controls.Add(Me.lblComite)
        Me.SgcGroupBox1.Controls.Add(Me.lblCodigo)
        Me.SgcGroupBox1.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SgcGroupBox1.Location = New System.Drawing.Point(60, 91)
        Me.SgcGroupBox1.Name = "SgcGroupBox1"
        Me.SgcGroupBox1.Size = New System.Drawing.Size(532, 226)
        Me.SgcGroupBox1.TabIndex = 8
        Me.SgcGroupBox1.TabStop = False
        Me.SgcGroupBox1.Text = "Datos"
        '
        'btnBuscarActividad
        '
        Me.btnBuscarActividad.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnBuscarActividad.FlatAppearance.BorderColor = System.Drawing.Color.Silver
        Me.btnBuscarActividad.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBuscarActividad.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBuscarActividad.ForeColor = System.Drawing.Color.SteelBlue
        Me.btnBuscarActividad.Image = Global.SGC_CS.My.Resources.Resources.btn_buscar
        Me.btnBuscarActividad.Location = New System.Drawing.Point(215, 35)
        Me.btnBuscarActividad.Name = "btnBuscarActividad"
        Me.btnBuscarActividad.Size = New System.Drawing.Size(45, 31)
        Me.btnBuscarActividad.TabIndex = 24
        Me.btnBuscarActividad.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnBuscarActividad.UseVisualStyleBackColor = False
        '
        'nudVacantes
        '
        Me.nudVacantes.Location = New System.Drawing.Point(369, 102)
        Me.nudVacantes.Name = "nudVacantes"
        Me.nudVacantes.Size = New System.Drawing.Size(69, 26)
        Me.nudVacantes.TabIndex = 22
        '
        'lblVacantes
        '
        Me.lblVacantes.AutoSize = True
        Me.lblVacantes.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVacantes.ForeColor = System.Drawing.Color.SteelBlue
        Me.lblVacantes.Location = New System.Drawing.Point(279, 104)
        Me.lblVacantes.Name = "lblVacantes"
        Me.lblVacantes.Size = New System.Drawing.Size(67, 18)
        Me.lblVacantes.TabIndex = 21
        Me.lblVacantes.Text = "Vacantes:"
        '
        'lblDescripcion
        '
        Me.lblDescripcion.AutoSize = True
        Me.lblDescripcion.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDescripcion.ForeColor = System.Drawing.Color.SteelBlue
        Me.lblDescripcion.Location = New System.Drawing.Point(19, 168)
        Me.lblDescripcion.Name = "lblDescripcion"
        Me.lblDescripcion.Size = New System.Drawing.Size(84, 18)
        Me.lblDescripcion.TabIndex = 20
        Me.lblDescripcion.Text = "Descripción:"
        '
        'txtDescripcion
        '
        Me.txtDescripcion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDescripcion.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDescripcion.ForeColor = System.Drawing.Color.Black
        Me.txtDescripcion.Location = New System.Drawing.Point(109, 166)
        Me.txtDescripcion.Multiline = True
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.Size = New System.Drawing.Size(384, 48)
        Me.txtDescripcion.TabIndex = 19
        '
        'txtNombre
        '
        Me.txtNombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNombre.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombre.ForeColor = System.Drawing.Color.Black
        Me.txtNombre.Location = New System.Drawing.Point(109, 134)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(384, 26)
        Me.txtNombre.TabIndex = 17
        '
        'lblNombre
        '
        Me.lblNombre.AutoSize = True
        Me.lblNombre.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombre.ForeColor = System.Drawing.Color.SteelBlue
        Me.lblNombre.Location = New System.Drawing.Point(19, 136)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(63, 18)
        Me.lblNombre.TabIndex = 16
        Me.lblNombre.Text = "Nombre:"
        '
        'lblSoles
        '
        Me.lblSoles.AutoSize = True
        Me.lblSoles.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSoles.ForeColor = System.Drawing.Color.Black
        Me.lblSoles.Location = New System.Drawing.Point(446, 73)
        Me.lblSoles.Name = "lblSoles"
        Me.lblSoles.Size = New System.Drawing.Size(56, 18)
        Me.lblSoles.TabIndex = 14
        Me.lblSoles.Text = "soles(s)"
        '
        'nudPago
        '
        Me.nudPago.Location = New System.Drawing.Point(370, 71)
        Me.nudPago.Name = "nudPago"
        Me.nudPago.Size = New System.Drawing.Size(69, 26)
        Me.nudPago.TabIndex = 11
        '
        'lblPago
        '
        Me.lblPago.AutoSize = True
        Me.lblPago.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPago.ForeColor = System.Drawing.Color.SteelBlue
        Me.lblPago.Location = New System.Drawing.Point(280, 73)
        Me.lblPago.Name = "lblPago"
        Me.lblPago.Size = New System.Drawing.Size(42, 18)
        Me.lblPago.TabIndex = 8
        Me.lblPago.Text = "Pago:"
        '
        'cboCategoria
        '
        Me.cboCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboCategoria.Enabled = False
        Me.cboCategoria.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cboCategoria.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboCategoria.ForeColor = System.Drawing.Color.Black
        Me.cboCategoria.FormattingEnabled = True
        Me.cboCategoria.Location = New System.Drawing.Point(369, 37)
        Me.cboCategoria.Name = "cboCategoria"
        Me.cboCategoria.Size = New System.Drawing.Size(121, 26)
        Me.cboCategoria.TabIndex = 7
        '
        'lblCategoria
        '
        Me.lblCategoria.AutoSize = True
        Me.lblCategoria.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCategoria.ForeColor = System.Drawing.Color.SteelBlue
        Me.lblCategoria.Location = New System.Drawing.Point(280, 40)
        Me.lblCategoria.Name = "lblCategoria"
        Me.lblCategoria.Size = New System.Drawing.Size(71, 18)
        Me.lblCategoria.TabIndex = 6
        Me.lblCategoria.Text = "Categoria:"
        '
        'cboTipo
        '
        Me.cboTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboTipo.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cboTipo.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboTipo.ForeColor = System.Drawing.Color.Black
        Me.cboTipo.FormattingEnabled = True
        Me.cboTipo.Location = New System.Drawing.Point(109, 101)
        Me.cboTipo.Name = "cboTipo"
        Me.cboTipo.Size = New System.Drawing.Size(121, 26)
        Me.cboTipo.TabIndex = 5
        '
        'cboComite
        '
        Me.cboComite.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboComite.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cboComite.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboComite.ForeColor = System.Drawing.Color.Black
        Me.cboComite.FormattingEnabled = True
        Me.cboComite.Location = New System.Drawing.Point(109, 69)
        Me.cboComite.Name = "cboComite"
        Me.cboComite.Size = New System.Drawing.Size(121, 26)
        Me.cboComite.TabIndex = 4
        '
        'txtCodigo
        '
        Me.txtCodigo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCodigo.Enabled = False
        Me.txtCodigo.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCodigo.ForeColor = System.Drawing.Color.Black
        Me.txtCodigo.Location = New System.Drawing.Point(109, 37)
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.Size = New System.Drawing.Size(100, 26)
        Me.txtCodigo.TabIndex = 3
        '
        'lblTipo
        '
        Me.lblTipo.AutoSize = True
        Me.lblTipo.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTipo.ForeColor = System.Drawing.Color.SteelBlue
        Me.lblTipo.Location = New System.Drawing.Point(19, 104)
        Me.lblTipo.Name = "lblTipo"
        Me.lblTipo.Size = New System.Drawing.Size(39, 18)
        Me.lblTipo.TabIndex = 2
        Me.lblTipo.Text = "Tipo:"
        '
        'lblComite
        '
        Me.lblComite.AutoSize = True
        Me.lblComite.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblComite.ForeColor = System.Drawing.Color.SteelBlue
        Me.lblComite.Location = New System.Drawing.Point(19, 72)
        Me.lblComite.Name = "lblComite"
        Me.lblComite.Size = New System.Drawing.Size(57, 18)
        Me.lblComite.TabIndex = 1
        Me.lblComite.Text = "Comite:"
        '
        'lblCodigo
        '
        Me.lblCodigo.AutoSize = True
        Me.lblCodigo.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCodigo.ForeColor = System.Drawing.Color.SteelBlue
        Me.lblCodigo.Location = New System.Drawing.Point(19, 39)
        Me.lblCodigo.Name = "lblCodigo"
        Me.lblCodigo.Size = New System.Drawing.Size(55, 18)
        Me.lblCodigo.TabIndex = 0
        Me.lblCodigo.Text = "Codigo:"
        '
        'SgcGroupBox2
        '
        Me.SgcGroupBox2.Controls.Add(Me.btnLimpiar)
        Me.SgcGroupBox2.Controls.Add(Me.dgvProgramacion)
        Me.SgcGroupBox2.Controls.Add(Me.btnEscoger)
        Me.SgcGroupBox2.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SgcGroupBox2.Location = New System.Drawing.Point(606, 91)
        Me.SgcGroupBox2.Name = "SgcGroupBox2"
        Me.SgcGroupBox2.Size = New System.Drawing.Size(354, 226)
        Me.SgcGroupBox2.TabIndex = 9
        Me.SgcGroupBox2.TabStop = False
        Me.SgcGroupBox2.Text = "Programación"
        '
        'dgvProgramacion
        '
        Me.dgvProgramacion.AllowUserToAddRows = False
        DataGridViewCellStyle9.BackColor = System.Drawing.Color.WhiteSmoke
        DataGridViewCellStyle9.ForeColor = System.Drawing.Color.SteelBlue
        Me.dgvProgramacion.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle9
        Me.dgvProgramacion.BackgroundColor = System.Drawing.Color.WhiteSmoke
        Me.dgvProgramacion.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dgvProgramacion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvProgramacion.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colSede, Me.colEspacio, Me.colFecInicio, Me.colHoraInicio, Me.colFecFin, Me.colHoraFin})
        Me.dgvProgramacion.Location = New System.Drawing.Point(18, 63)
        Me.dgvProgramacion.Name = "dgvProgramacion"
        Me.dgvProgramacion.ReadOnly = True
        Me.dgvProgramacion.Size = New System.Drawing.Size(320, 151)
        Me.dgvProgramacion.TabIndex = 2
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
        'btnEscoger
        '
        Me.btnEscoger.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnEscoger.FlatAppearance.BorderColor = System.Drawing.Color.Silver
        Me.btnEscoger.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEscoger.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEscoger.ForeColor = System.Drawing.Color.SteelBlue
        Me.btnEscoger.Location = New System.Drawing.Point(16, 26)
        Me.btnEscoger.Name = "btnEscoger"
        Me.btnEscoger.Size = New System.Drawing.Size(75, 31)
        Me.btnEscoger.TabIndex = 0
        Me.btnEscoger.Text = "Escoger"
        Me.btnEscoger.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnEscoger.UseVisualStyleBackColor = False
        '
        'SgcGroupBox3
        '
        Me.SgcGroupBox3.Controls.Add(Me.dgvRestricciones)
        Me.SgcGroupBox3.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SgcGroupBox3.Location = New System.Drawing.Point(11, 3)
        Me.SgcGroupBox3.Name = "SgcGroupBox3"
        Me.SgcGroupBox3.Size = New System.Drawing.Size(869, 213)
        Me.SgcGroupBox3.TabIndex = 10
        Me.SgcGroupBox3.TabStop = False
        Me.SgcGroupBox3.Text = "Restricciones"
        '
        'dgvRestricciones
        '
        Me.dgvRestricciones.AllowUserToAddRows = False
        Me.dgvRestricciones.AllowUserToDeleteRows = False
        DataGridViewCellStyle10.BackColor = System.Drawing.Color.WhiteSmoke
        DataGridViewCellStyle10.ForeColor = System.Drawing.Color.SteelBlue
        Me.dgvRestricciones.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle10
        Me.dgvRestricciones.BackgroundColor = System.Drawing.Color.WhiteSmoke
        Me.dgvRestricciones.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dgvRestricciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvRestricciones.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colSeleccionar, Me.colRestriccionID, Me.colDescripcionRestriccion, Me.colCondicionRestriccion, Me.colCantidadRestriccion, Me.colFlgCondicion})
        Me.dgvRestricciones.Location = New System.Drawing.Point(17, 21)
        Me.dgvRestricciones.Name = "dgvRestricciones"
        Me.dgvRestricciones.Size = New System.Drawing.Size(836, 182)
        Me.dgvRestricciones.TabIndex = 3
        '
        'colSeleccionar
        '
        Me.colSeleccionar.HeaderText = ""
        Me.colSeleccionar.Name = "colSeleccionar"
        Me.colSeleccionar.Width = 30
        '
        'colRestriccionID
        '
        Me.colRestriccionID.HeaderText = ""
        Me.colRestriccionID.Name = "colRestriccionID"
        Me.colRestriccionID.Visible = False
        '
        'colDescripcionRestriccion
        '
        Me.colDescripcionRestriccion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.colDescripcionRestriccion.HeaderText = "Descripción"
        Me.colDescripcionRestriccion.Name = "colDescripcionRestriccion"
        '
        'colCondicionRestriccion
        '
        Me.colCondicionRestriccion.HeaderText = "Condición"
        Me.colCondicionRestriccion.Name = "colCondicionRestriccion"
        Me.colCondicionRestriccion.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'colCantidadRestriccion
        '
        Me.colCantidadRestriccion.HeaderText = "Cantidad"
        Me.colCantidadRestriccion.MaxInputLength = 2
        Me.colCantidadRestriccion.Name = "colCantidadRestriccion"
        '
        'colFlgCondicion
        '
        Me.colFlgCondicion.HeaderText = ""
        Me.colFlgCondicion.Name = "colFlgCondicion"
        Me.colFlgCondicion.Visible = False
        '
        'btnQuitarTipoPersonal
        '
        Me.btnQuitarTipoPersonal.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnQuitarTipoPersonal.FlatAppearance.BorderColor = System.Drawing.Color.Silver
        Me.btnQuitarTipoPersonal.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnQuitarTipoPersonal.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnQuitarTipoPersonal.ForeColor = System.Drawing.Color.SteelBlue
        Me.btnQuitarTipoPersonal.Image = Global.SGC_CS.My.Resources.Resources.btn_eliminar
        Me.btnQuitarTipoPersonal.Location = New System.Drawing.Point(292, 52)
        Me.btnQuitarTipoPersonal.Name = "btnQuitarTipoPersonal"
        Me.btnQuitarTipoPersonal.Size = New System.Drawing.Size(90, 31)
        Me.btnQuitarTipoPersonal.TabIndex = 12
        Me.btnQuitarTipoPersonal.Text = "Quitar"
        Me.btnQuitarTipoPersonal.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnQuitarTipoPersonal.UseVisualStyleBackColor = False
        '
        'btnAgregarTipoPersonal
        '
        Me.btnAgregarTipoPersonal.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnAgregarTipoPersonal.FlatAppearance.BorderColor = System.Drawing.Color.Silver
        Me.btnAgregarTipoPersonal.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAgregarTipoPersonal.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAgregarTipoPersonal.ForeColor = System.Drawing.Color.SteelBlue
        Me.btnAgregarTipoPersonal.Image = Global.SGC_CS.My.Resources.Resources.btn_agregar
        Me.btnAgregarTipoPersonal.Location = New System.Drawing.Point(292, 17)
        Me.btnAgregarTipoPersonal.Name = "btnAgregarTipoPersonal"
        Me.btnAgregarTipoPersonal.Size = New System.Drawing.Size(90, 31)
        Me.btnAgregarTipoPersonal.TabIndex = 12
        Me.btnAgregarTipoPersonal.Text = "Agregar"
        Me.btnAgregarTipoPersonal.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnAgregarTipoPersonal.UseVisualStyleBackColor = False
        '
        'tsMenu
        '
        Me.tsMenu.BackColor = System.Drawing.Color.Silver
        Me.tsMenu.Dock = System.Windows.Forms.DockStyle.None
        Me.tsMenu.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tsMenu.ImageScalingSize = New System.Drawing.Size(30, 30)
        Me.tsMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsbLimpiar, Me.tsbGuardar, Me.tsbEditar, Me.tsbEliminar, Me.tsbCancelar, Me.tsbReprogramacion})
        Me.tsMenu.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow
        Me.tsMenu.Location = New System.Drawing.Point(60, 51)
        Me.tsMenu.Name = "tsMenu"
        Me.tsMenu.Size = New System.Drawing.Size(185, 37)
        Me.tsMenu.TabIndex = 17
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
        'tsbGuardar
        '
        Me.tsbGuardar.BackColor = System.Drawing.Color.WhiteSmoke
        Me.tsbGuardar.Image = Global.SGC_CS.My.Resources.Resources.menu_validar
        Me.tsbGuardar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbGuardar.Margin = New System.Windows.Forms.Padding(1, 1, 1, 2)
        Me.tsbGuardar.Name = "tsbGuardar"
        Me.tsbGuardar.Size = New System.Drawing.Size(92, 34)
        Me.tsbGuardar.Text = "Guardar"
        '
        'tsbEditar
        '
        Me.tsbEditar.BackColor = System.Drawing.Color.WhiteSmoke
        Me.tsbEditar.Image = Global.SGC_CS.My.Resources.Resources.menu_editar
        Me.tsbEditar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbEditar.Margin = New System.Windows.Forms.Padding(1, 1, 1, 2)
        Me.tsbEditar.Name = "tsbEditar"
        Me.tsbEditar.Size = New System.Drawing.Size(78, 34)
        Me.tsbEditar.Text = "Editar"
        Me.tsbEditar.Visible = False
        '
        'tsbEliminar
        '
        Me.tsbEliminar.BackColor = System.Drawing.Color.WhiteSmoke
        Me.tsbEliminar.Image = Global.SGC_CS.My.Resources.Resources.menu_eliminar
        Me.tsbEliminar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbEliminar.Margin = New System.Windows.Forms.Padding(1, 1, 1, 2)
        Me.tsbEliminar.Name = "tsbEliminar"
        Me.tsbEliminar.Size = New System.Drawing.Size(93, 34)
        Me.tsbEliminar.Text = "Eliminar"
        Me.tsbEliminar.Visible = False
        '
        'tsbCancelar
        '
        Me.tsbCancelar.BackColor = System.Drawing.Color.WhiteSmoke
        Me.tsbCancelar.Image = Global.SGC_CS.My.Resources.Resources.menu_cancel
        Me.tsbCancelar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbCancelar.Margin = New System.Windows.Forms.Padding(1, 1, 1, 2)
        Me.tsbCancelar.Name = "tsbCancelar"
        Me.tsbCancelar.Size = New System.Drawing.Size(95, 34)
        Me.tsbCancelar.Text = "Cancelar"
        Me.tsbCancelar.Visible = False
        '
        'tsbReprogramacion
        '
        Me.tsbReprogramacion.BackColor = System.Drawing.Color.WhiteSmoke
        Me.tsbReprogramacion.Image = CType(resources.GetObject("tsbReprogramacion.Image"), System.Drawing.Image)
        Me.tsbReprogramacion.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbReprogramacion.Margin = New System.Windows.Forms.Padding(1, 1, 1, 2)
        Me.tsbReprogramacion.Name = "tsbReprogramacion"
        Me.tsbReprogramacion.Size = New System.Drawing.Size(143, 34)
        Me.tsbReprogramacion.Text = "Reprogramación"
        Me.tsbReprogramacion.Visible = False
        '
        'tcPlanAnual
        '
        Me.tcPlanAnual.Controls.Add(Me.tpRestricciones)
        Me.tcPlanAnual.Controls.Add(Me.tpTipoPersonal)
        Me.tcPlanAnual.Controls.Add(Me.tpRecursos)
        Me.tcPlanAnual.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tcPlanAnual.Location = New System.Drawing.Point(60, 323)
        Me.tcPlanAnual.Name = "tcPlanAnual"
        Me.tcPlanAnual.SelectedIndex = 0
        Me.tcPlanAnual.Size = New System.Drawing.Size(900, 257)
        Me.tcPlanAnual.TabIndex = 18
        '
        'tpRestricciones
        '
        Me.tpRestricciones.Controls.Add(Me.SgcGroupBox3)
        Me.tpRestricciones.Location = New System.Drawing.Point(4, 27)
        Me.tpRestricciones.Name = "tpRestricciones"
        Me.tpRestricciones.Padding = New System.Windows.Forms.Padding(3)
        Me.tpRestricciones.Size = New System.Drawing.Size(892, 226)
        Me.tpRestricciones.TabIndex = 0
        Me.tpRestricciones.Text = "Restricciones"
        Me.tpRestricciones.UseVisualStyleBackColor = True
        '
        'tpTipoPersonal
        '
        Me.tpTipoPersonal.Controls.Add(Me.SgcGroupBox7)
        Me.tpTipoPersonal.Location = New System.Drawing.Point(4, 27)
        Me.tpTipoPersonal.Name = "tpTipoPersonal"
        Me.tpTipoPersonal.Size = New System.Drawing.Size(892, 226)
        Me.tpTipoPersonal.TabIndex = 2
        Me.tpTipoPersonal.Text = "Tipo de Personal"
        Me.tpTipoPersonal.UseVisualStyleBackColor = True
        '
        'SgcGroupBox7
        '
        Me.SgcGroupBox7.Controls.Add(Me.btnBuscarPersonal)
        Me.SgcGroupBox7.Controls.Add(Me.SgcLabel3)
        Me.SgcGroupBox7.Controls.Add(Me.txtCantidadPersonal)
        Me.SgcGroupBox7.Controls.Add(Me.txtDescripcionPersonal)
        Me.SgcGroupBox7.Controls.Add(Me.SgcLabel4)
        Me.SgcGroupBox7.Controls.Add(Me.dgvTipoPersonal)
        Me.SgcGroupBox7.Controls.Add(Me.btnQuitarTipoPersonal)
        Me.SgcGroupBox7.Controls.Add(Me.btnAgregarTipoPersonal)
        Me.SgcGroupBox7.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SgcGroupBox7.Location = New System.Drawing.Point(9, 3)
        Me.SgcGroupBox7.Name = "SgcGroupBox7"
        Me.SgcGroupBox7.Size = New System.Drawing.Size(393, 210)
        Me.SgcGroupBox7.TabIndex = 14
        Me.SgcGroupBox7.TabStop = False
        Me.SgcGroupBox7.Text = "Tipo de Personal"
        '
        'btnBuscarPersonal
        '
        Me.btnBuscarPersonal.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnBuscarPersonal.FlatAppearance.BorderColor = System.Drawing.Color.Silver
        Me.btnBuscarPersonal.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBuscarPersonal.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBuscarPersonal.ForeColor = System.Drawing.Color.SteelBlue
        Me.btnBuscarPersonal.Image = Global.SGC_CS.My.Resources.Resources.btn_buscar
        Me.btnBuscarPersonal.Location = New System.Drawing.Point(241, 17)
        Me.btnBuscarPersonal.Name = "btnBuscarPersonal"
        Me.btnBuscarPersonal.Size = New System.Drawing.Size(45, 31)
        Me.btnBuscarPersonal.TabIndex = 30
        Me.btnBuscarPersonal.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnBuscarPersonal.UseVisualStyleBackColor = False
        '
        'SgcLabel3
        '
        Me.SgcLabel3.AutoSize = True
        Me.SgcLabel3.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SgcLabel3.ForeColor = System.Drawing.Color.SteelBlue
        Me.SgcLabel3.Location = New System.Drawing.Point(12, 53)
        Me.SgcLabel3.Name = "SgcLabel3"
        Me.SgcLabel3.Size = New System.Drawing.Size(67, 18)
        Me.SgcLabel3.TabIndex = 29
        Me.SgcLabel3.Text = "Cantidad:"
        '
        'txtCantidadPersonal
        '
        Me.txtCantidadPersonal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCantidadPersonal.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCantidadPersonal.ForeColor = System.Drawing.Color.Black
        Me.txtCantidadPersonal.Location = New System.Drawing.Point(96, 51)
        Me.txtCantidadPersonal.Name = "txtCantidadPersonal"
        Me.txtCantidadPersonal.Size = New System.Drawing.Size(48, 26)
        Me.txtCantidadPersonal.TabIndex = 28
        '
        'txtDescripcionPersonal
        '
        Me.txtDescripcionPersonal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDescripcionPersonal.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDescripcionPersonal.ForeColor = System.Drawing.Color.Black
        Me.txtDescripcionPersonal.Location = New System.Drawing.Point(96, 19)
        Me.txtDescripcionPersonal.Name = "txtDescripcionPersonal"
        Me.txtDescripcionPersonal.Size = New System.Drawing.Size(139, 26)
        Me.txtDescripcionPersonal.TabIndex = 27
        '
        'SgcLabel4
        '
        Me.SgcLabel4.AutoSize = True
        Me.SgcLabel4.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SgcLabel4.ForeColor = System.Drawing.Color.SteelBlue
        Me.SgcLabel4.Location = New System.Drawing.Point(12, 23)
        Me.SgcLabel4.Name = "SgcLabel4"
        Me.SgcLabel4.Size = New System.Drawing.Size(84, 18)
        Me.SgcLabel4.TabIndex = 26
        Me.SgcLabel4.Text = "Descripción:"
        '
        'dgvTipoPersonal
        '
        Me.dgvTipoPersonal.AllowUserToAddRows = False
        Me.dgvTipoPersonal.AllowUserToDeleteRows = False
        DataGridViewCellStyle11.BackColor = System.Drawing.Color.WhiteSmoke
        DataGridViewCellStyle11.ForeColor = System.Drawing.Color.SteelBlue
        Me.dgvTipoPersonal.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle11
        Me.dgvTipoPersonal.BackgroundColor = System.Drawing.Color.WhiteSmoke
        Me.dgvTipoPersonal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dgvTipoPersonal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvTipoPersonal.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colDescripcionPersonal, Me.colCantidadPersonal})
        Me.dgvTipoPersonal.Location = New System.Drawing.Point(15, 89)
        Me.dgvTipoPersonal.Name = "dgvTipoPersonal"
        Me.dgvTipoPersonal.ReadOnly = True
        Me.dgvTipoPersonal.Size = New System.Drawing.Size(367, 107)
        Me.dgvTipoPersonal.TabIndex = 1
        '
        'colDescripcionPersonal
        '
        Me.colDescripcionPersonal.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.colDescripcionPersonal.HeaderText = "Descripción"
        Me.colDescripcionPersonal.Name = "colDescripcionPersonal"
        Me.colDescripcionPersonal.ReadOnly = True
        '
        'colCantidadPersonal
        '
        Me.colCantidadPersonal.HeaderText = "Cantidad"
        Me.colCantidadPersonal.Name = "colCantidadPersonal"
        Me.colCantidadPersonal.ReadOnly = True
        '
        'tpRecursos
        '
        Me.tpRecursos.Controls.Add(Me.SgcGroupBox5)
        Me.tpRecursos.Location = New System.Drawing.Point(4, 27)
        Me.tpRecursos.Name = "tpRecursos"
        Me.tpRecursos.Size = New System.Drawing.Size(892, 226)
        Me.tpRecursos.TabIndex = 3
        Me.tpRecursos.Text = "Recursos"
        Me.tpRecursos.UseVisualStyleBackColor = True
        '
        'SgcGroupBox5
        '
        Me.SgcGroupBox5.Controls.Add(Me.btnBuscarRecurso)
        Me.SgcGroupBox5.Controls.Add(Me.SgcLabel2)
        Me.SgcGroupBox5.Controls.Add(Me.txtCantidadRecurso)
        Me.SgcGroupBox5.Controls.Add(Me.txtDescripcionRecurso)
        Me.SgcGroupBox5.Controls.Add(Me.SgcLabel1)
        Me.SgcGroupBox5.Controls.Add(Me.dgvRecursos)
        Me.SgcGroupBox5.Controls.Add(Me.btnQuitarRecurso)
        Me.SgcGroupBox5.Controls.Add(Me.btnAgregarRecurso)
        Me.SgcGroupBox5.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SgcGroupBox5.Location = New System.Drawing.Point(9, 3)
        Me.SgcGroupBox5.Name = "SgcGroupBox5"
        Me.SgcGroupBox5.Size = New System.Drawing.Size(396, 213)
        Me.SgcGroupBox5.TabIndex = 15
        Me.SgcGroupBox5.TabStop = False
        Me.SgcGroupBox5.Text = "Recursos"
        '
        'btnBuscarRecurso
        '
        Me.btnBuscarRecurso.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnBuscarRecurso.FlatAppearance.BorderColor = System.Drawing.Color.Silver
        Me.btnBuscarRecurso.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBuscarRecurso.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBuscarRecurso.ForeColor = System.Drawing.Color.SteelBlue
        Me.btnBuscarRecurso.Image = Global.SGC_CS.My.Resources.Resources.btn_buscar
        Me.btnBuscarRecurso.Location = New System.Drawing.Point(241, 16)
        Me.btnBuscarRecurso.Name = "btnBuscarRecurso"
        Me.btnBuscarRecurso.Size = New System.Drawing.Size(45, 31)
        Me.btnBuscarRecurso.TabIndex = 25
        Me.btnBuscarRecurso.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnBuscarRecurso.UseVisualStyleBackColor = False
        '
        'SgcLabel2
        '
        Me.SgcLabel2.AutoSize = True
        Me.SgcLabel2.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SgcLabel2.ForeColor = System.Drawing.Color.SteelBlue
        Me.SgcLabel2.Location = New System.Drawing.Point(12, 52)
        Me.SgcLabel2.Name = "SgcLabel2"
        Me.SgcLabel2.Size = New System.Drawing.Size(67, 18)
        Me.SgcLabel2.TabIndex = 16
        Me.SgcLabel2.Text = "Cantidad:"
        '
        'txtCantidadRecurso
        '
        Me.txtCantidadRecurso.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCantidadRecurso.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCantidadRecurso.ForeColor = System.Drawing.Color.Black
        Me.txtCantidadRecurso.Location = New System.Drawing.Point(96, 50)
        Me.txtCantidadRecurso.Name = "txtCantidadRecurso"
        Me.txtCantidadRecurso.Size = New System.Drawing.Size(48, 26)
        Me.txtCantidadRecurso.TabIndex = 15
        '
        'txtDescripcionRecurso
        '
        Me.txtDescripcionRecurso.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDescripcionRecurso.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDescripcionRecurso.ForeColor = System.Drawing.Color.Black
        Me.txtDescripcionRecurso.Location = New System.Drawing.Point(96, 18)
        Me.txtDescripcionRecurso.Name = "txtDescripcionRecurso"
        Me.txtDescripcionRecurso.Size = New System.Drawing.Size(139, 26)
        Me.txtDescripcionRecurso.TabIndex = 14
        '
        'SgcLabel1
        '
        Me.SgcLabel1.AutoSize = True
        Me.SgcLabel1.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SgcLabel1.ForeColor = System.Drawing.Color.SteelBlue
        Me.SgcLabel1.Location = New System.Drawing.Point(12, 22)
        Me.SgcLabel1.Name = "SgcLabel1"
        Me.SgcLabel1.Size = New System.Drawing.Size(84, 18)
        Me.SgcLabel1.TabIndex = 13
        Me.SgcLabel1.Text = "Descripción:"
        '
        'dgvRecursos
        '
        Me.dgvRecursos.AllowUserToAddRows = False
        Me.dgvRecursos.AllowUserToDeleteRows = False
        DataGridViewCellStyle12.BackColor = System.Drawing.Color.WhiteSmoke
        DataGridViewCellStyle12.ForeColor = System.Drawing.Color.SteelBlue
        Me.dgvRecursos.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle12
        Me.dgvRecursos.BackgroundColor = System.Drawing.Color.WhiteSmoke
        Me.dgvRecursos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dgvRecursos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvRecursos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colDescripcionRecurso, Me.colCantidadRecurso})
        Me.dgvRecursos.Location = New System.Drawing.Point(15, 88)
        Me.dgvRecursos.Name = "dgvRecursos"
        Me.dgvRecursos.ReadOnly = True
        Me.dgvRecursos.Size = New System.Drawing.Size(366, 119)
        Me.dgvRecursos.TabIndex = 1
        '
        'colDescripcionRecurso
        '
        Me.colDescripcionRecurso.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.colDescripcionRecurso.HeaderText = "Descripción"
        Me.colDescripcionRecurso.Name = "colDescripcionRecurso"
        Me.colDescripcionRecurso.ReadOnly = True
        '
        'colCantidadRecurso
        '
        Me.colCantidadRecurso.HeaderText = "Cantidad"
        Me.colCantidadRecurso.Name = "colCantidadRecurso"
        Me.colCantidadRecurso.ReadOnly = True
        '
        'btnQuitarRecurso
        '
        Me.btnQuitarRecurso.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnQuitarRecurso.FlatAppearance.BorderColor = System.Drawing.Color.Silver
        Me.btnQuitarRecurso.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnQuitarRecurso.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnQuitarRecurso.ForeColor = System.Drawing.Color.SteelBlue
        Me.btnQuitarRecurso.Image = Global.SGC_CS.My.Resources.Resources.btn_eliminar
        Me.btnQuitarRecurso.Location = New System.Drawing.Point(292, 51)
        Me.btnQuitarRecurso.Name = "btnQuitarRecurso"
        Me.btnQuitarRecurso.Size = New System.Drawing.Size(89, 31)
        Me.btnQuitarRecurso.TabIndex = 12
        Me.btnQuitarRecurso.Text = "Quitar"
        Me.btnQuitarRecurso.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnQuitarRecurso.UseVisualStyleBackColor = False
        '
        'btnAgregarRecurso
        '
        Me.btnAgregarRecurso.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnAgregarRecurso.FlatAppearance.BorderColor = System.Drawing.Color.Silver
        Me.btnAgregarRecurso.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAgregarRecurso.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAgregarRecurso.ForeColor = System.Drawing.Color.SteelBlue
        Me.btnAgregarRecurso.Image = Global.SGC_CS.My.Resources.Resources.btn_agregar
        Me.btnAgregarRecurso.Location = New System.Drawing.Point(292, 16)
        Me.btnAgregarRecurso.Name = "btnAgregarRecurso"
        Me.btnAgregarRecurso.Size = New System.Drawing.Size(89, 31)
        Me.btnAgregarRecurso.TabIndex = 12
        Me.btnAgregarRecurso.Text = "Agregar"
        Me.btnAgregarRecurso.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnAgregarRecurso.UseVisualStyleBackColor = False
        '
        'lblTitulo
        '
        Me.lblTitulo.AutoSize = True
        Me.lblTitulo.BackColor = System.Drawing.Color.ForestGreen
        Me.lblTitulo.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitulo.ForeColor = System.Drawing.Color.White
        Me.lblTitulo.Location = New System.Drawing.Point(397, 9)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(155, 23)
        Me.lblTitulo.TabIndex = 24
        Me.lblTitulo.Text = "Registro Actividad"
        '
        'btnLimpiar
        '
        Me.btnLimpiar.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnLimpiar.FlatAppearance.BorderColor = System.Drawing.Color.Silver
        Me.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLimpiar.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLimpiar.ForeColor = System.Drawing.Color.SteelBlue
        Me.btnLimpiar.Location = New System.Drawing.Point(97, 26)
        Me.btnLimpiar.Name = "btnLimpiar"
        Me.btnLimpiar.Size = New System.Drawing.Size(75, 31)
        Me.btnLimpiar.TabIndex = 31
        Me.btnLimpiar.Text = "Limpiar"
        Me.btnLimpiar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnLimpiar.UseVisualStyleBackColor = False
        '
        'frmRegistroActividad
        '
        Me.ClientSize = New System.Drawing.Size(1016, 733)
        Me.Controls.Add(Me.lblTitulo)
        Me.Controls.Add(Me.tcPlanAnual)
        Me.Controls.Add(Me.tsMenu)
        Me.Controls.Add(Me.SgcGroupBox2)
        Me.Controls.Add(Me.SgcGroupBox1)
        Me.Name = "frmRegistroActividad"
        Me.Controls.SetChildIndex(Me.SgcGroupBox1, 0)
        Me.Controls.SetChildIndex(Me.SgcGroupBox2, 0)
        Me.Controls.SetChildIndex(Me.tsMenu, 0)
        Me.Controls.SetChildIndex(Me.tcPlanAnual, 0)
        Me.Controls.SetChildIndex(Me.lblTitulo, 0)
        Me.SgcGroupBox1.ResumeLayout(False)
        Me.SgcGroupBox1.PerformLayout()
        CType(Me.nudVacantes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudPago, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SgcGroupBox2.ResumeLayout(False)
        CType(Me.dgvProgramacion, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SgcGroupBox3.ResumeLayout(False)
        CType(Me.dgvRestricciones, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tsMenu.ResumeLayout(False)
        Me.tsMenu.PerformLayout()
        Me.tcPlanAnual.ResumeLayout(False)
        Me.tpRestricciones.ResumeLayout(False)
        Me.tpTipoPersonal.ResumeLayout(False)
        Me.SgcGroupBox7.ResumeLayout(False)
        Me.SgcGroupBox7.PerformLayout()
        CType(Me.dgvTipoPersonal, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tpRecursos.ResumeLayout(False)
        Me.SgcGroupBox5.ResumeLayout(False)
        Me.SgcGroupBox5.PerformLayout()
        CType(Me.dgvRecursos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents SgcGroupBox1 As SGC_CS.SGCGroupBox
    Friend WithEvents nudPago As SGC_CS.SGCNumericUpDown
    Friend WithEvents lblPago As SGC_CS.SGCLabel
    Friend WithEvents cboCategoria As SGC_CS.SGCComboBox
    Friend WithEvents lblCategoria As SGC_CS.SGCLabel
    Friend WithEvents cboTipo As SGC_CS.SGCComboBox
    Friend WithEvents cboComite As SGC_CS.SGCComboBox
    Friend WithEvents txtCodigo As SGC_CS.SGCTextBox
    Friend WithEvents lblTipo As SGC_CS.SGCLabel
    Friend WithEvents lblComite As SGC_CS.SGCLabel
    Friend WithEvents lblCodigo As SGC_CS.SGCLabel
    Friend WithEvents lblDescripcion As SGC_CS.SGCLabel
    Friend WithEvents txtDescripcion As SGC_CS.SGCTextBox
    Friend WithEvents txtNombre As SGC_CS.SGCTextBox
    Friend WithEvents lblNombre As SGC_CS.SGCLabel
    Friend WithEvents lblSoles As SGC_CS.SGCLabel
    Friend WithEvents SgcGroupBox2 As SGC_CS.SGCGroupBox
    Friend WithEvents btnEscoger As SGC_CS.SGCButton
    Friend WithEvents SgcGroupBox3 As SGC_CS.SGCGroupBox
    Friend WithEvents dgvRestricciones As SGC_CS.SGCDataGridView
    Friend WithEvents btnQuitarTipoPersonal As SGC_CS.SGCButton
    Friend WithEvents btnAgregarTipoPersonal As SGC_CS.SGCButton
    Friend WithEvents tsMenu As SGC_CS.SGCToolStrip
    Friend WithEvents tsbLimpiar As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsbGuardar As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsbEditar As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsbEliminar As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsbCancelar As System.Windows.Forms.ToolStripButton
    Friend WithEvents tcPlanAnual As SGC_CS.SGCTabControl
    Friend WithEvents tpRestricciones As System.Windows.Forms.TabPage
    Friend WithEvents tpTipoPersonal As System.Windows.Forms.TabPage
    Friend WithEvents tpRecursos As System.Windows.Forms.TabPage
    Friend WithEvents SgcGroupBox7 As SGC_CS.SGCGroupBox
    Friend WithEvents dgvTipoPersonal As SGC_CS.SGCDataGridView
    Friend WithEvents SgcGroupBox5 As SGC_CS.SGCGroupBox
    Friend WithEvents dgvRecursos As SGC_CS.SGCDataGridView
    Friend WithEvents btnQuitarRecurso As SGC_CS.SGCButton
    Friend WithEvents btnAgregarRecurso As SGC_CS.SGCButton
    Friend WithEvents nudVacantes As SGC_CS.SGCNumericUpDown
    Friend WithEvents lblVacantes As SGC_CS.SGCLabel
    Friend WithEvents btnBuscarActividad As SGC_CS.SGCButton
    Friend WithEvents tsbReprogramacion As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnBuscarRecurso As SGC_CS.SGCButton
    Friend WithEvents SgcLabel2 As SGC_CS.SGCLabel
    Friend WithEvents txtCantidadRecurso As SGC_CS.SGCTextBox
    Friend WithEvents txtDescripcionRecurso As SGC_CS.SGCTextBox
    Friend WithEvents SgcLabel1 As SGC_CS.SGCLabel
    Friend WithEvents btnBuscarPersonal As SGC_CS.SGCButton
    Friend WithEvents SgcLabel3 As SGC_CS.SGCLabel
    Friend WithEvents txtCantidadPersonal As SGC_CS.SGCTextBox
    Friend WithEvents txtDescripcionPersonal As SGC_CS.SGCTextBox
    Friend WithEvents SgcLabel4 As SGC_CS.SGCLabel
    Friend WithEvents colSeleccionar As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents colRestriccionID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colDescripcionRestriccion As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colCondicionRestriccion As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents colCantidadRestriccion As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colFlgCondicion As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colDescripcionPersonal As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colCantidadPersonal As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colDescripcionRecurso As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colCantidadRecurso As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents lblTitulo As SGC_CS.SGCLabel
    Friend WithEvents dgvProgramacion As SGC_CS.SGCDataGridView
    Friend WithEvents colSede As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colEspacio As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colFecInicio As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colHoraInicio As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colFecFin As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colHoraFin As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents btnLimpiar As SGC_CS.SGCButton

End Class
