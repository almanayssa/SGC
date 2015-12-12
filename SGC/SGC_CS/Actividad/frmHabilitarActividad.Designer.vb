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
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.tcPlanAnual = New SGC_CS.SGCTabControl(Me.components)
        Me.tpRestricciones = New System.Windows.Forms.TabPage()
        Me.SgcGroupBox3 = New SGC_CS.SGCGroupBox(Me.components)
        Me.dgvRestricciones = New SGC_CS.SGCDataGridView(Me.components)
        Me.tpPersonal = New System.Windows.Forms.TabPage()
        Me.SgcGroupBox5 = New SGC_CS.SGCGroupBox(Me.components)
        Me.btnQuitarPersonal = New SGC_CS.SGCButton(Me.components)
        Me.btnAgregarPersonal = New SGC_CS.SGCButton(Me.components)
        Me.dgvPersonal = New SGC_CS.SGCDataGridView(Me.components)
        Me.SgcGroupBox7 = New SGC_CS.SGCGroupBox(Me.components)
        Me.dgvTipoPersonal = New SGC_CS.SGCDataGridView(Me.components)
        Me.tpRecursos = New System.Windows.Forms.TabPage()
        Me.SgcGroupBox6 = New SGC_CS.SGCGroupBox(Me.components)
        Me.dgvRecursos = New SGC_CS.SGCDataGridView(Me.components)
        Me.tsMenu = New SGC_CS.SGCToolStrip(Me.components)
        Me.tsbLimpiar = New System.Windows.Forms.ToolStripButton()
        Me.tsbGuardar = New System.Windows.Forms.ToolStripButton()
        Me.SgcGroupBox2 = New SGC_CS.SGCGroupBox(Me.components)
        Me.dgvProgramacion = New SGC_CS.SGCDataGridView(Me.components)
        Me.SgcGroupBox1 = New SGC_CS.SGCGroupBox(Me.components)
        Me.btnBuscarActividad = New SGC_CS.SGCButton(Me.components)
        Me.SgcLabel12 = New SGC_CS.SGCLabel(Me.components)
        Me.txtDescripcion = New SGC_CS.SGCTextBox(Me.components)
        Me.txtNombre = New SGC_CS.SGCTextBox(Me.components)
        Me.SgcLabel11 = New SGC_CS.SGCLabel(Me.components)
        Me.SgcLabel10 = New SGC_CS.SGCLabel(Me.components)
        Me.nudPago = New SGC_CS.SGCNumericUpDown(Me.components)
        Me.SgcLabel7 = New SGC_CS.SGCLabel(Me.components)
        Me.cboCategoria = New SGC_CS.SGCComboBox(Me.components)
        Me.SgcLabel4 = New SGC_CS.SGCLabel(Me.components)
        Me.cboTipo = New SGC_CS.SGCComboBox(Me.components)
        Me.cboComite = New SGC_CS.SGCComboBox(Me.components)
        Me.txtCodigo = New SGC_CS.SGCTextBox(Me.components)
        Me.SgcLabel3 = New SGC_CS.SGCLabel(Me.components)
        Me.SgcLabel2 = New SGC_CS.SGCLabel(Me.components)
        Me.SgcLabel1 = New SGC_CS.SGCLabel(Me.components)
        Me.nudVacantes = New SGC_CS.SGCNumericUpDown(Me.components)
        Me.SgcLabel6 = New SGC_CS.SGCLabel(Me.components)
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
        CType(Me.nudPago, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudVacantes, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.SgcGroupBox3.Size = New System.Drawing.Size(869, 213)
        Me.SgcGroupBox3.TabIndex = 10
        Me.SgcGroupBox3.TabStop = False
        Me.SgcGroupBox3.Text = "Restricciones"
        '
        'dgvRestricciones
        '
        Me.dgvRestricciones.AllowUserToAddRows = False
        DataGridViewCellStyle7.BackColor = System.Drawing.Color.WhiteSmoke
        DataGridViewCellStyle7.ForeColor = System.Drawing.Color.SteelBlue
        Me.dgvRestricciones.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle7
        Me.dgvRestricciones.BackgroundColor = System.Drawing.Color.WhiteSmoke
        Me.dgvRestricciones.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dgvRestricciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvRestricciones.Location = New System.Drawing.Point(15, 25)
        Me.dgvRestricciones.Name = "dgvRestricciones"
        Me.dgvRestricciones.Size = New System.Drawing.Size(840, 172)
        Me.dgvRestricciones.TabIndex = 3
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
        Me.SgcGroupBox5.Size = New System.Drawing.Size(460, 213)
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
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.WhiteSmoke
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.SteelBlue
        Me.dgvPersonal.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle6
        Me.dgvPersonal.BackgroundColor = System.Drawing.Color.WhiteSmoke
        Me.dgvPersonal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dgvPersonal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvPersonal.Location = New System.Drawing.Point(15, 25)
        Me.dgvPersonal.Name = "dgvPersonal"
        Me.dgvPersonal.Size = New System.Drawing.Size(342, 171)
        Me.dgvPersonal.TabIndex = 1
        '
        'SgcGroupBox7
        '
        Me.SgcGroupBox7.Controls.Add(Me.dgvTipoPersonal)
        Me.SgcGroupBox7.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SgcGroupBox7.Location = New System.Drawing.Point(11, 3)
        Me.SgcGroupBox7.Name = "SgcGroupBox7"
        Me.SgcGroupBox7.Size = New System.Drawing.Size(375, 213)
        Me.SgcGroupBox7.TabIndex = 13
        Me.SgcGroupBox7.TabStop = False
        Me.SgcGroupBox7.Text = "Tipo de Personal"
        '
        'dgvTipoPersonal
        '
        Me.dgvTipoPersonal.AllowUserToAddRows = False
        DataGridViewCellStyle8.BackColor = System.Drawing.Color.WhiteSmoke
        DataGridViewCellStyle8.ForeColor = System.Drawing.Color.SteelBlue
        Me.dgvTipoPersonal.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle8
        Me.dgvTipoPersonal.BackgroundColor = System.Drawing.Color.WhiteSmoke
        Me.dgvTipoPersonal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dgvTipoPersonal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvTipoPersonal.Location = New System.Drawing.Point(15, 25)
        Me.dgvTipoPersonal.Name = "dgvTipoPersonal"
        Me.dgvTipoPersonal.Size = New System.Drawing.Size(342, 171)
        Me.dgvTipoPersonal.TabIndex = 1
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
        Me.SgcGroupBox6.Size = New System.Drawing.Size(454, 213)
        Me.SgcGroupBox6.TabIndex = 16
        Me.SgcGroupBox6.TabStop = False
        Me.SgcGroupBox6.Text = "Recursos"
        '
        'dgvRecursos
        '
        Me.dgvRecursos.AllowUserToAddRows = False
        DataGridViewCellStyle9.BackColor = System.Drawing.Color.WhiteSmoke
        DataGridViewCellStyle9.ForeColor = System.Drawing.Color.SteelBlue
        Me.dgvRecursos.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle9
        Me.dgvRecursos.BackgroundColor = System.Drawing.Color.WhiteSmoke
        Me.dgvRecursos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dgvRecursos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvRecursos.Location = New System.Drawing.Point(15, 25)
        Me.dgvRecursos.Name = "dgvRecursos"
        Me.dgvRecursos.Size = New System.Drawing.Size(424, 171)
        Me.dgvRecursos.TabIndex = 1
        '
        'tsMenu
        '
        Me.tsMenu.BackColor = System.Drawing.Color.Silver
        Me.tsMenu.Dock = System.Windows.Forms.DockStyle.None
        Me.tsMenu.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tsMenu.ImageScalingSize = New System.Drawing.Size(30, 30)
        Me.tsMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsbLimpiar, Me.tsbGuardar})
        Me.tsMenu.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow
        Me.tsMenu.Location = New System.Drawing.Point(60, 51)
        Me.tsMenu.Name = "tsMenu"
        Me.tsMenu.Size = New System.Drawing.Size(188, 37)
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
        'tsbGuardar
        '
        Me.tsbGuardar.BackColor = System.Drawing.Color.WhiteSmoke
        Me.tsbGuardar.Image = Global.SGC_CS.My.Resources.Resources.menu_validar
        Me.tsbGuardar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbGuardar.Margin = New System.Windows.Forms.Padding(1, 1, 1, 2)
        Me.tsbGuardar.Name = "tsbGuardar"
        Me.tsbGuardar.Size = New System.Drawing.Size(95, 34)
        Me.tsbGuardar.Text = "Habilitar"
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
        DataGridViewCellStyle10.BackColor = System.Drawing.Color.WhiteSmoke
        DataGridViewCellStyle10.ForeColor = System.Drawing.Color.SteelBlue
        Me.dgvProgramacion.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle10
        Me.dgvProgramacion.BackgroundColor = System.Drawing.Color.WhiteSmoke
        Me.dgvProgramacion.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dgvProgramacion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvProgramacion.Location = New System.Drawing.Point(18, 31)
        Me.dgvProgramacion.Name = "dgvProgramacion"
        Me.dgvProgramacion.Size = New System.Drawing.Size(320, 177)
        Me.dgvProgramacion.TabIndex = 1
        '
        'SgcGroupBox1
        '
        Me.SgcGroupBox1.Controls.Add(Me.nudVacantes)
        Me.SgcGroupBox1.Controls.Add(Me.SgcLabel6)
        Me.SgcGroupBox1.Controls.Add(Me.btnBuscarActividad)
        Me.SgcGroupBox1.Controls.Add(Me.SgcLabel12)
        Me.SgcGroupBox1.Controls.Add(Me.txtDescripcion)
        Me.SgcGroupBox1.Controls.Add(Me.txtNombre)
        Me.SgcGroupBox1.Controls.Add(Me.SgcLabel11)
        Me.SgcGroupBox1.Controls.Add(Me.SgcLabel10)
        Me.SgcGroupBox1.Controls.Add(Me.nudPago)
        Me.SgcGroupBox1.Controls.Add(Me.SgcLabel7)
        Me.SgcGroupBox1.Controls.Add(Me.cboCategoria)
        Me.SgcGroupBox1.Controls.Add(Me.SgcLabel4)
        Me.SgcGroupBox1.Controls.Add(Me.cboTipo)
        Me.SgcGroupBox1.Controls.Add(Me.cboComite)
        Me.SgcGroupBox1.Controls.Add(Me.txtCodigo)
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
        'txtDescripcion
        '
        Me.txtDescripcion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDescripcion.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDescripcion.ForeColor = System.Drawing.Color.Black
        Me.txtDescripcion.Location = New System.Drawing.Point(109, 166)
        Me.txtDescripcion.Multiline = True
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.Size = New System.Drawing.Size(384, 42)
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
        Me.SgcLabel10.Location = New System.Drawing.Point(445, 42)
        Me.SgcLabel10.Name = "SgcLabel10"
        Me.SgcLabel10.Size = New System.Drawing.Size(56, 18)
        Me.SgcLabel10.TabIndex = 14
        Me.SgcLabel10.Text = "soles(s)"
        '
        'nudPago
        '
        Me.nudPago.Location = New System.Drawing.Point(369, 39)
        Me.nudPago.Name = "nudPago"
        Me.nudPago.Size = New System.Drawing.Size(69, 26)
        Me.nudPago.TabIndex = 11
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
        'cboCategoria
        '
        Me.cboCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboCategoria.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cboCategoria.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboCategoria.ForeColor = System.Drawing.Color.Black
        Me.cboCategoria.FormattingEnabled = True
        Me.cboCategoria.Location = New System.Drawing.Point(369, 102)
        Me.cboCategoria.Name = "cboCategoria"
        Me.cboCategoria.Size = New System.Drawing.Size(121, 26)
        Me.cboCategoria.TabIndex = 7
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
        Me.txtCodigo.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCodigo.ForeColor = System.Drawing.Color.Black
        Me.txtCodigo.Location = New System.Drawing.Point(109, 37)
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.Size = New System.Drawing.Size(100, 26)
        Me.txtCodigo.TabIndex = 3
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
        'nudVacantes
        '
        Me.nudVacantes.Location = New System.Drawing.Point(369, 69)
        Me.nudVacantes.Name = "nudVacantes"
        Me.nudVacantes.Size = New System.Drawing.Size(69, 26)
        Me.nudVacantes.TabIndex = 25
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
        'frmHabilitarActividad
        '
        Me.ClientSize = New System.Drawing.Size(1016, 733)
        Me.Controls.Add(Me.tcPlanAnual)
        Me.Controls.Add(Me.tsMenu)
        Me.Controls.Add(Me.SgcGroupBox2)
        Me.Controls.Add(Me.SgcGroupBox1)
        Me.Name = "frmHabilitarActividad"
        Me.Controls.SetChildIndex(Me.SgcGroupBox1, 0)
        Me.Controls.SetChildIndex(Me.SgcGroupBox2, 0)
        Me.Controls.SetChildIndex(Me.tsMenu, 0)
        Me.Controls.SetChildIndex(Me.tcPlanAnual, 0)
        Me.tcPlanAnual.ResumeLayout(False)
        Me.tpRestricciones.ResumeLayout(False)
        Me.SgcGroupBox3.ResumeLayout(False)
        CType(Me.dgvRestricciones, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tpPersonal.ResumeLayout(False)
        Me.SgcGroupBox5.ResumeLayout(False)
        CType(Me.dgvPersonal, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SgcGroupBox7.ResumeLayout(False)
        CType(Me.dgvTipoPersonal, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tpRecursos.ResumeLayout(False)
        Me.SgcGroupBox6.ResumeLayout(False)
        CType(Me.dgvRecursos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tsMenu.ResumeLayout(False)
        Me.tsMenu.PerformLayout()
        Me.SgcGroupBox2.ResumeLayout(False)
        CType(Me.dgvProgramacion, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SgcGroupBox1.ResumeLayout(False)
        Me.SgcGroupBox1.PerformLayout()
        CType(Me.nudPago, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudVacantes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents tcPlanAnual As SGC_CS.SGCTabControl
    Friend WithEvents tpRestricciones As System.Windows.Forms.TabPage
    Friend WithEvents SgcGroupBox3 As SGC_CS.SGCGroupBox
    Friend WithEvents dgvRestricciones As SGC_CS.SGCDataGridView
    Friend WithEvents tpPersonal As System.Windows.Forms.TabPage
    Friend WithEvents tpRecursos As System.Windows.Forms.TabPage
    Friend WithEvents tsMenu As SGC_CS.SGCToolStrip
    Friend WithEvents tsbLimpiar As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsbGuardar As System.Windows.Forms.ToolStripButton
    Friend WithEvents SgcGroupBox2 As SGC_CS.SGCGroupBox
    Friend WithEvents dgvProgramacion As SGC_CS.SGCDataGridView
    Friend WithEvents SgcGroupBox1 As SGC_CS.SGCGroupBox
    Friend WithEvents SgcLabel12 As SGC_CS.SGCLabel
    Friend WithEvents txtDescripcion As SGC_CS.SGCTextBox
    Friend WithEvents txtNombre As SGC_CS.SGCTextBox
    Friend WithEvents SgcLabel11 As SGC_CS.SGCLabel
    Friend WithEvents SgcLabel10 As SGC_CS.SGCLabel
    Friend WithEvents nudPago As SGC_CS.SGCNumericUpDown
    Friend WithEvents SgcLabel7 As SGC_CS.SGCLabel
    Friend WithEvents cboCategoria As SGC_CS.SGCComboBox
    Friend WithEvents SgcLabel4 As SGC_CS.SGCLabel
    Friend WithEvents cboTipo As SGC_CS.SGCComboBox
    Friend WithEvents cboComite As SGC_CS.SGCComboBox
    Friend WithEvents txtCodigo As SGC_CS.SGCTextBox
    Friend WithEvents SgcLabel3 As SGC_CS.SGCLabel
    Friend WithEvents SgcLabel2 As SGC_CS.SGCLabel
    Friend WithEvents SgcLabel1 As SGC_CS.SGCLabel
    Friend WithEvents SgcGroupBox5 As SGC_CS.SGCGroupBox
    Friend WithEvents dgvPersonal As SGC_CS.SGCDataGridView
    Friend WithEvents SgcGroupBox7 As SGC_CS.SGCGroupBox
    Friend WithEvents dgvTipoPersonal As SGC_CS.SGCDataGridView
    Friend WithEvents btnQuitarPersonal As SGC_CS.SGCButton
    Friend WithEvents btnAgregarPersonal As SGC_CS.SGCButton
    Friend WithEvents SgcGroupBox6 As SGC_CS.SGCGroupBox
    Friend WithEvents dgvRecursos As SGC_CS.SGCDataGridView
    Friend WithEvents btnBuscarActividad As SGC_CS.SGCButton
    Friend WithEvents nudVacantes As SGC_CS.SGCNumericUpDown
    Friend WithEvents SgcLabel6 As SGC_CS.SGCLabel

End Class
