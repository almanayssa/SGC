<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRegistroInscripcion
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
        Me.tsMenu = New SGC_CS.SGCToolStrip(Me.components)
        Me.tsbLimpiar = New System.Windows.Forms.ToolStripButton()
        Me.tsbGuardar = New System.Windows.Forms.ToolStripButton()
        Me.tsbEliminar = New System.Windows.Forms.ToolStripButton()
        Me.dgvProgramacion = New SGC_CS.SGCDataGridView(Me.components)
        Me.SgcGroupBox1 = New SGC_CS.SGCGroupBox(Me.components)
        Me.SgcLabel2 = New SGC_CS.SGCLabel(Me.components)
        Me.txtActividad = New SGC_CS.SGCTextBox(Me.components)
        Me.btnBuscarActividad = New SGC_CS.SGCButton(Me.components)
        Me.txtCodigo = New SGC_CS.SGCTextBox(Me.components)
        Me.SgcLabel1 = New SGC_CS.SGCLabel(Me.components)
        Me.nudMonto = New SGC_CS.SGCNumericUpDown(Me.components)
        Me.dgvRestricciones = New SGC_CS.SGCDataGridView(Me.components)
        Me.SgcGroupBox4 = New SGC_CS.SGCGroupBox(Me.components)
        Me.btnBuscarSocio = New SGC_CS.SGCButton(Me.components)
        Me.txtNombre = New SGC_CS.SGCTextBox(Me.components)
        Me.SgcLabel6 = New SGC_CS.SGCLabel(Me.components)
        Me.txtAccion = New SGC_CS.SGCTextBox(Me.components)
        Me.SgcLabel16 = New SGC_CS.SGCLabel(Me.components)
        Me.SgcGroupBox5 = New SGC_CS.SGCGroupBox(Me.components)
        Me.SgcLabel4 = New SGC_CS.SGCLabel(Me.components)
        Me.txtNumDoc = New SGC_CS.SGCTextBox(Me.components)
        Me.txtSerie = New SGC_CS.SGCTextBox(Me.components)
        Me.SgcLabel3 = New SGC_CS.SGCLabel(Me.components)
        Me.SgcGroupBox6 = New SGC_CS.SGCGroupBox(Me.components)
        Me.btnQuitarInscrito = New SGC_CS.SGCButton(Me.components)
        Me.btnAgregarPersona = New SGC_CS.SGCButton(Me.components)
        Me.dgvInscritos = New SGC_CS.SGCDataGridView(Me.components)
        Me.colNombres = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colNombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colApePat = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colApeMat = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colNacimiento = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colDNI = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colRelacion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colInscripcion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colPersona = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SgcGroupBox7 = New SGC_CS.SGCGroupBox(Me.components)
        Me.btnQuitarInvitado = New SGC_CS.SGCButton(Me.components)
        Me.btnAgregarInvitado = New SGC_CS.SGCButton(Me.components)
        Me.dgvInvitados = New SGC_CS.SGCDataGridView(Me.components)
        Me.colIdInv = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colINombres = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colIDNI = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.lblTitulo = New SGC_CS.SGCLabel(Me.components)
        Me.SgcGroupBox3 = New SGC_CS.SGCGroupBox(Me.components)
        Me.SgcGroupBox2 = New SGC_CS.SGCGroupBox(Me.components)
        Me.tsMenu.SuspendLayout()
        CType(Me.dgvProgramacion, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SgcGroupBox1.SuspendLayout()
        CType(Me.nudMonto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvRestricciones, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SgcGroupBox4.SuspendLayout()
        Me.SgcGroupBox5.SuspendLayout()
        Me.SgcGroupBox6.SuspendLayout()
        CType(Me.dgvInscritos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SgcGroupBox7.SuspendLayout()
        CType(Me.dgvInvitados, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SgcGroupBox3.SuspendLayout()
        Me.SgcGroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'tsMenu
        '
        Me.tsMenu.BackColor = System.Drawing.Color.Silver
        Me.tsMenu.Dock = System.Windows.Forms.DockStyle.None
        Me.tsMenu.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tsMenu.ImageScalingSize = New System.Drawing.Size(30, 30)
        Me.tsMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsbLimpiar, Me.tsbGuardar, Me.tsbEliminar})
        Me.tsMenu.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow
        Me.tsMenu.Location = New System.Drawing.Point(60, 60)
        Me.tsMenu.Name = "tsMenu"
        Me.tsMenu.Size = New System.Drawing.Size(185, 37)
        Me.tsMenu.TabIndex = 20
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
        'dgvProgramacion
        '
        Me.dgvProgramacion.AllowUserToAddRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.WhiteSmoke
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.SteelBlue
        Me.dgvProgramacion.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvProgramacion.BackgroundColor = System.Drawing.Color.WhiteSmoke
        Me.dgvProgramacion.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dgvProgramacion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvProgramacion.Location = New System.Drawing.Point(18, 25)
        Me.dgvProgramacion.Name = "dgvProgramacion"
        Me.dgvProgramacion.Size = New System.Drawing.Size(348, 97)
        Me.dgvProgramacion.TabIndex = 1
        '
        'SgcGroupBox1
        '
        Me.SgcGroupBox1.Controls.Add(Me.SgcLabel2)
        Me.SgcGroupBox1.Controls.Add(Me.txtActividad)
        Me.SgcGroupBox1.Controls.Add(Me.btnBuscarActividad)
        Me.SgcGroupBox1.Controls.Add(Me.txtCodigo)
        Me.SgcGroupBox1.Controls.Add(Me.SgcLabel1)
        Me.SgcGroupBox1.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SgcGroupBox1.Location = New System.Drawing.Point(60, 100)
        Me.SgcGroupBox1.Name = "SgcGroupBox1"
        Me.SgcGroupBox1.Size = New System.Drawing.Size(504, 209)
        Me.SgcGroupBox1.TabIndex = 18
        Me.SgcGroupBox1.TabStop = False
        Me.SgcGroupBox1.Text = "Actividad"
        '
        'SgcLabel2
        '
        Me.SgcLabel2.AutoSize = True
        Me.SgcLabel2.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SgcLabel2.ForeColor = System.Drawing.Color.SteelBlue
        Me.SgcLabel2.Location = New System.Drawing.Point(19, 72)
        Me.SgcLabel2.Name = "SgcLabel2"
        Me.SgcLabel2.Size = New System.Drawing.Size(70, 18)
        Me.SgcLabel2.TabIndex = 27
        Me.SgcLabel2.Text = "Actividad:"
        '
        'txtActividad
        '
        Me.txtActividad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtActividad.Enabled = False
        Me.txtActividad.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtActividad.ForeColor = System.Drawing.Color.Black
        Me.txtActividad.Location = New System.Drawing.Point(109, 70)
        Me.txtActividad.Multiline = True
        Me.txtActividad.Name = "txtActividad"
        Me.txtActividad.Size = New System.Drawing.Size(374, 127)
        Me.txtActividad.TabIndex = 26
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
        Me.btnBuscarActividad.TabIndex = 25
        Me.btnBuscarActividad.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnBuscarActividad.UseVisualStyleBackColor = False
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
        'nudMonto
        '
        Me.nudMonto.DecimalPlaces = 2
        Me.nudMonto.Location = New System.Drawing.Point(297, 24)
        Me.nudMonto.Name = "nudMonto"
        Me.nudMonto.Size = New System.Drawing.Size(69, 26)
        Me.nudMonto.TabIndex = 11
        '
        'dgvRestricciones
        '
        Me.dgvRestricciones.AllowUserToAddRows = False
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.WhiteSmoke
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.SteelBlue
        Me.dgvRestricciones.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvRestricciones.BackgroundColor = System.Drawing.Color.WhiteSmoke
        Me.dgvRestricciones.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dgvRestricciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvRestricciones.Location = New System.Drawing.Point(18, 25)
        Me.dgvRestricciones.Name = "dgvRestricciones"
        Me.dgvRestricciones.Size = New System.Drawing.Size(348, 97)
        Me.dgvRestricciones.TabIndex = 1
        '
        'SgcGroupBox4
        '
        Me.SgcGroupBox4.Controls.Add(Me.btnBuscarSocio)
        Me.SgcGroupBox4.Controls.Add(Me.txtNombre)
        Me.SgcGroupBox4.Controls.Add(Me.SgcLabel6)
        Me.SgcGroupBox4.Controls.Add(Me.txtAccion)
        Me.SgcGroupBox4.Controls.Add(Me.SgcLabel16)
        Me.SgcGroupBox4.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SgcGroupBox4.Location = New System.Drawing.Point(60, 315)
        Me.SgcGroupBox4.Name = "SgcGroupBox4"
        Me.SgcGroupBox4.Size = New System.Drawing.Size(504, 135)
        Me.SgcGroupBox4.TabIndex = 22
        Me.SgcGroupBox4.TabStop = False
        Me.SgcGroupBox4.Text = "Socio"
        '
        'btnBuscarSocio
        '
        Me.btnBuscarSocio.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnBuscarSocio.FlatAppearance.BorderColor = System.Drawing.Color.Silver
        Me.btnBuscarSocio.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBuscarSocio.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBuscarSocio.ForeColor = System.Drawing.Color.SteelBlue
        Me.btnBuscarSocio.Image = Global.SGC_CS.My.Resources.Resources.btn_buscar
        Me.btnBuscarSocio.Location = New System.Drawing.Point(227, 33)
        Me.btnBuscarSocio.Name = "btnBuscarSocio"
        Me.btnBuscarSocio.Size = New System.Drawing.Size(43, 31)
        Me.btnBuscarSocio.TabIndex = 21
        Me.btnBuscarSocio.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnBuscarSocio.UseVisualStyleBackColor = False
        '
        'txtNombre
        '
        Me.txtNombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNombre.Enabled = False
        Me.txtNombre.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombre.ForeColor = System.Drawing.Color.Black
        Me.txtNombre.Location = New System.Drawing.Point(109, 69)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(384, 26)
        Me.txtNombre.TabIndex = 17
        '
        'SgcLabel6
        '
        Me.SgcLabel6.AutoSize = True
        Me.SgcLabel6.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SgcLabel6.ForeColor = System.Drawing.Color.SteelBlue
        Me.SgcLabel6.Location = New System.Drawing.Point(19, 71)
        Me.SgcLabel6.Name = "SgcLabel6"
        Me.SgcLabel6.Size = New System.Drawing.Size(63, 18)
        Me.SgcLabel6.TabIndex = 16
        Me.SgcLabel6.Text = "Nombre:"
        '
        'txtAccion
        '
        Me.txtAccion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtAccion.Enabled = False
        Me.txtAccion.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAccion.ForeColor = System.Drawing.Color.Black
        Me.txtAccion.Location = New System.Drawing.Point(109, 37)
        Me.txtAccion.Name = "txtAccion"
        Me.txtAccion.Size = New System.Drawing.Size(100, 26)
        Me.txtAccion.TabIndex = 3
        '
        'SgcLabel16
        '
        Me.SgcLabel16.AutoSize = True
        Me.SgcLabel16.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SgcLabel16.ForeColor = System.Drawing.Color.SteelBlue
        Me.SgcLabel16.Location = New System.Drawing.Point(19, 39)
        Me.SgcLabel16.Name = "SgcLabel16"
        Me.SgcLabel16.Size = New System.Drawing.Size(53, 18)
        Me.SgcLabel16.TabIndex = 0
        Me.SgcLabel16.Text = "Acción:"
        '
        'SgcGroupBox5
        '
        Me.SgcGroupBox5.Controls.Add(Me.SgcLabel4)
        Me.SgcGroupBox5.Controls.Add(Me.txtNumDoc)
        Me.SgcGroupBox5.Controls.Add(Me.txtSerie)
        Me.SgcGroupBox5.Controls.Add(Me.SgcLabel3)
        Me.SgcGroupBox5.Controls.Add(Me.nudMonto)
        Me.SgcGroupBox5.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SgcGroupBox5.Location = New System.Drawing.Point(580, 386)
        Me.SgcGroupBox5.Name = "SgcGroupBox5"
        Me.SgcGroupBox5.Size = New System.Drawing.Size(382, 64)
        Me.SgcGroupBox5.TabIndex = 23
        Me.SgcGroupBox5.TabStop = False
        Me.SgcGroupBox5.Text = "Pago"
        '
        'SgcLabel4
        '
        Me.SgcLabel4.AutoSize = True
        Me.SgcLabel4.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SgcLabel4.ForeColor = System.Drawing.Color.SteelBlue
        Me.SgcLabel4.Location = New System.Drawing.Point(243, 27)
        Me.SgcLabel4.Name = "SgcLabel4"
        Me.SgcLabel4.Size = New System.Drawing.Size(54, 18)
        Me.SgcLabel4.TabIndex = 29
        Me.SgcLabel4.Text = "Monto:"
        '
        'txtNumDoc
        '
        Me.txtNumDoc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNumDoc.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNumDoc.ForeColor = System.Drawing.Color.Black
        Me.txtNumDoc.Location = New System.Drawing.Point(149, 25)
        Me.txtNumDoc.Name = "txtNumDoc"
        Me.txtNumDoc.Size = New System.Drawing.Size(88, 26)
        Me.txtNumDoc.TabIndex = 28
        '
        'txtSerie
        '
        Me.txtSerie.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtSerie.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSerie.ForeColor = System.Drawing.Color.Black
        Me.txtSerie.Location = New System.Drawing.Point(99, 25)
        Me.txtSerie.Name = "txtSerie"
        Me.txtSerie.Size = New System.Drawing.Size(44, 26)
        Me.txtSerie.TabIndex = 27
        '
        'SgcLabel3
        '
        Me.SgcLabel3.AutoSize = True
        Me.SgcLabel3.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SgcLabel3.ForeColor = System.Drawing.Color.SteelBlue
        Me.SgcLabel3.Location = New System.Drawing.Point(15, 27)
        Me.SgcLabel3.Name = "SgcLabel3"
        Me.SgcLabel3.Size = New System.Drawing.Size(84, 18)
        Me.SgcLabel3.TabIndex = 17
        Me.SgcLabel3.Text = "Documento:"
        '
        'SgcGroupBox6
        '
        Me.SgcGroupBox6.Controls.Add(Me.btnQuitarInscrito)
        Me.SgcGroupBox6.Controls.Add(Me.btnAgregarPersona)
        Me.SgcGroupBox6.Controls.Add(Me.dgvInscritos)
        Me.SgcGroupBox6.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SgcGroupBox6.Location = New System.Drawing.Point(60, 456)
        Me.SgcGroupBox6.Name = "SgcGroupBox6"
        Me.SgcGroupBox6.Size = New System.Drawing.Size(452, 189)
        Me.SgcGroupBox6.TabIndex = 24
        Me.SgcGroupBox6.TabStop = False
        Me.SgcGroupBox6.Text = "Inscritos"
        '
        'btnQuitarInscrito
        '
        Me.btnQuitarInscrito.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnQuitarInscrito.FlatAppearance.BorderColor = System.Drawing.Color.Silver
        Me.btnQuitarInscrito.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnQuitarInscrito.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnQuitarInscrito.ForeColor = System.Drawing.Color.SteelBlue
        Me.btnQuitarInscrito.Location = New System.Drawing.Point(94, 20)
        Me.btnQuitarInscrito.Name = "btnQuitarInscrito"
        Me.btnQuitarInscrito.Size = New System.Drawing.Size(75, 31)
        Me.btnQuitarInscrito.TabIndex = 3
        Me.btnQuitarInscrito.Text = "Quitar"
        Me.btnQuitarInscrito.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnQuitarInscrito.UseVisualStyleBackColor = False
        '
        'btnAgregarPersona
        '
        Me.btnAgregarPersona.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnAgregarPersona.FlatAppearance.BorderColor = System.Drawing.Color.Silver
        Me.btnAgregarPersona.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAgregarPersona.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAgregarPersona.ForeColor = System.Drawing.Color.SteelBlue
        Me.btnAgregarPersona.Location = New System.Drawing.Point(13, 20)
        Me.btnAgregarPersona.Name = "btnAgregarPersona"
        Me.btnAgregarPersona.Size = New System.Drawing.Size(75, 31)
        Me.btnAgregarPersona.TabIndex = 2
        Me.btnAgregarPersona.Text = "Agregar"
        Me.btnAgregarPersona.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnAgregarPersona.UseVisualStyleBackColor = False
        '
        'dgvInscritos
        '
        Me.dgvInscritos.AllowUserToAddRows = False
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.WhiteSmoke
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.SteelBlue
        Me.dgvInscritos.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle3
        Me.dgvInscritos.BackgroundColor = System.Drawing.Color.WhiteSmoke
        Me.dgvInscritos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dgvInscritos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvInscritos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colNombres, Me.colNombre, Me.colApePat, Me.colApeMat, Me.colNacimiento, Me.colDNI, Me.colRelacion, Me.colInscripcion, Me.colPersona})
        Me.dgvInscritos.Location = New System.Drawing.Point(13, 57)
        Me.dgvInscritos.Name = "dgvInscritos"
        Me.dgvInscritos.Size = New System.Drawing.Size(420, 126)
        Me.dgvInscritos.TabIndex = 1
        '
        'colNombres
        '
        Me.colNombres.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.colNombres.HeaderText = "Nombres"
        Me.colNombres.Name = "colNombres"
        Me.colNombres.ReadOnly = True
        '
        'colNombre
        '
        Me.colNombre.HeaderText = "Nombre"
        Me.colNombre.Name = "colNombre"
        Me.colNombre.ReadOnly = True
        Me.colNombre.Visible = False
        '
        'colApePat
        '
        Me.colApePat.HeaderText = "Apellido Paterno"
        Me.colApePat.Name = "colApePat"
        Me.colApePat.ReadOnly = True
        Me.colApePat.Visible = False
        '
        'colApeMat
        '
        Me.colApeMat.HeaderText = "Apellido Materno"
        Me.colApeMat.Name = "colApeMat"
        Me.colApeMat.ReadOnly = True
        Me.colApeMat.Visible = False
        '
        'colNacimiento
        '
        Me.colNacimiento.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.colNacimiento.HeaderText = "Fecha Nacimiento"
        Me.colNacimiento.Name = "colNacimiento"
        Me.colNacimiento.ReadOnly = True
        '
        'colDNI
        '
        Me.colDNI.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.colDNI.HeaderText = "DNI"
        Me.colDNI.Name = "colDNI"
        Me.colDNI.ReadOnly = True
        '
        'colRelacion
        '
        Me.colRelacion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.colRelacion.FillWeight = 150.0!
        Me.colRelacion.HeaderText = "Relacion"
        Me.colRelacion.Name = "colRelacion"
        Me.colRelacion.ReadOnly = True
        '
        'colInscripcion
        '
        Me.colInscripcion.HeaderText = "Inscripcion"
        Me.colInscripcion.Name = "colInscripcion"
        Me.colInscripcion.ReadOnly = True
        Me.colInscripcion.Visible = False
        '
        'colPersona
        '
        Me.colPersona.HeaderText = "Persona"
        Me.colPersona.Name = "colPersona"
        Me.colPersona.ReadOnly = True
        Me.colPersona.Visible = False
        '
        'SgcGroupBox7
        '
        Me.SgcGroupBox7.Controls.Add(Me.btnQuitarInvitado)
        Me.SgcGroupBox7.Controls.Add(Me.btnAgregarInvitado)
        Me.SgcGroupBox7.Controls.Add(Me.dgvInvitados)
        Me.SgcGroupBox7.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SgcGroupBox7.Location = New System.Drawing.Point(518, 456)
        Me.SgcGroupBox7.Name = "SgcGroupBox7"
        Me.SgcGroupBox7.Size = New System.Drawing.Size(444, 189)
        Me.SgcGroupBox7.TabIndex = 25
        Me.SgcGroupBox7.TabStop = False
        Me.SgcGroupBox7.Text = "Invitados"
        '
        'btnQuitarInvitado
        '
        Me.btnQuitarInvitado.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnQuitarInvitado.FlatAppearance.BorderColor = System.Drawing.Color.Silver
        Me.btnQuitarInvitado.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnQuitarInvitado.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnQuitarInvitado.ForeColor = System.Drawing.Color.SteelBlue
        Me.btnQuitarInvitado.Location = New System.Drawing.Point(99, 20)
        Me.btnQuitarInvitado.Name = "btnQuitarInvitado"
        Me.btnQuitarInvitado.Size = New System.Drawing.Size(75, 31)
        Me.btnQuitarInvitado.TabIndex = 4
        Me.btnQuitarInvitado.Text = "Quitar"
        Me.btnQuitarInvitado.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnQuitarInvitado.UseVisualStyleBackColor = False
        '
        'btnAgregarInvitado
        '
        Me.btnAgregarInvitado.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnAgregarInvitado.FlatAppearance.BorderColor = System.Drawing.Color.Silver
        Me.btnAgregarInvitado.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAgregarInvitado.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAgregarInvitado.ForeColor = System.Drawing.Color.SteelBlue
        Me.btnAgregarInvitado.Location = New System.Drawing.Point(18, 20)
        Me.btnAgregarInvitado.Name = "btnAgregarInvitado"
        Me.btnAgregarInvitado.Size = New System.Drawing.Size(75, 31)
        Me.btnAgregarInvitado.TabIndex = 3
        Me.btnAgregarInvitado.Text = "Agregar"
        Me.btnAgregarInvitado.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnAgregarInvitado.UseVisualStyleBackColor = False
        '
        'dgvInvitados
        '
        Me.dgvInvitados.AllowUserToAddRows = False
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.WhiteSmoke
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.SteelBlue
        Me.dgvInvitados.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle4
        Me.dgvInvitados.BackgroundColor = System.Drawing.Color.WhiteSmoke
        Me.dgvInvitados.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dgvInvitados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvInvitados.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colIdInv, Me.colINombres, Me.colIDNI})
        Me.dgvInvitados.Location = New System.Drawing.Point(18, 57)
        Me.dgvInvitados.Name = "dgvInvitados"
        Me.dgvInvitados.Size = New System.Drawing.Size(410, 126)
        Me.dgvInvitados.TabIndex = 1
        '
        'colIdInv
        '
        Me.colIdInv.HeaderText = "idInvitado"
        Me.colIdInv.Name = "colIdInv"
        Me.colIdInv.Visible = False
        '
        'colINombres
        '
        Me.colINombres.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.colINombres.HeaderText = "Nombres"
        Me.colINombres.Name = "colINombres"
        '
        'colIDNI
        '
        Me.colIDNI.HeaderText = "DNI"
        Me.colIDNI.Name = "colIDNI"
        '
        'lblTitulo
        '
        Me.lblTitulo.AutoSize = True
        Me.lblTitulo.BackColor = System.Drawing.Color.ForestGreen
        Me.lblTitulo.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitulo.ForeColor = System.Drawing.Color.White
        Me.lblTitulo.Location = New System.Drawing.Point(425, 9)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(198, 23)
        Me.lblTitulo.TabIndex = 26
        Me.lblTitulo.Text = "Inscripción de Actividad"
        '
        'SgcGroupBox3
        '
        Me.SgcGroupBox3.Controls.Add(Me.dgvRestricciones)
        Me.SgcGroupBox3.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SgcGroupBox3.Location = New System.Drawing.Point(580, 243)
        Me.SgcGroupBox3.Name = "SgcGroupBox3"
        Me.SgcGroupBox3.Size = New System.Drawing.Size(382, 137)
        Me.SgcGroupBox3.TabIndex = 21
        Me.SgcGroupBox3.TabStop = False
        Me.SgcGroupBox3.Text = "Restricciones"
        '
        'SgcGroupBox2
        '
        Me.SgcGroupBox2.Controls.Add(Me.dgvProgramacion)
        Me.SgcGroupBox2.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SgcGroupBox2.Location = New System.Drawing.Point(580, 100)
        Me.SgcGroupBox2.Name = "SgcGroupBox2"
        Me.SgcGroupBox2.Size = New System.Drawing.Size(382, 137)
        Me.SgcGroupBox2.TabIndex = 19
        Me.SgcGroupBox2.TabStop = False
        Me.SgcGroupBox2.Text = "Programación"
        '
        'frmRegistroInscripcion
        '
        Me.ClientSize = New System.Drawing.Size(1016, 733)
        Me.Controls.Add(Me.lblTitulo)
        Me.Controls.Add(Me.SgcGroupBox7)
        Me.Controls.Add(Me.SgcGroupBox6)
        Me.Controls.Add(Me.SgcGroupBox5)
        Me.Controls.Add(Me.SgcGroupBox4)
        Me.Controls.Add(Me.SgcGroupBox3)
        Me.Controls.Add(Me.tsMenu)
        Me.Controls.Add(Me.SgcGroupBox2)
        Me.Controls.Add(Me.SgcGroupBox1)
        Me.Name = "frmRegistroInscripcion"
        Me.Controls.SetChildIndex(Me.SgcGroupBox1, 0)
        Me.Controls.SetChildIndex(Me.SgcGroupBox2, 0)
        Me.Controls.SetChildIndex(Me.tsMenu, 0)
        Me.Controls.SetChildIndex(Me.SgcGroupBox3, 0)
        Me.Controls.SetChildIndex(Me.SgcGroupBox4, 0)
        Me.Controls.SetChildIndex(Me.SgcGroupBox5, 0)
        Me.Controls.SetChildIndex(Me.SgcGroupBox6, 0)
        Me.Controls.SetChildIndex(Me.SgcGroupBox7, 0)
        Me.Controls.SetChildIndex(Me.lblTitulo, 0)
        Me.tsMenu.ResumeLayout(False)
        Me.tsMenu.PerformLayout()
        CType(Me.dgvProgramacion, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SgcGroupBox1.ResumeLayout(False)
        Me.SgcGroupBox1.PerformLayout()
        CType(Me.nudMonto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvRestricciones, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SgcGroupBox4.ResumeLayout(False)
        Me.SgcGroupBox4.PerformLayout()
        Me.SgcGroupBox5.ResumeLayout(False)
        Me.SgcGroupBox5.PerformLayout()
        Me.SgcGroupBox6.ResumeLayout(False)
        CType(Me.dgvInscritos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SgcGroupBox7.ResumeLayout(False)
        CType(Me.dgvInvitados, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SgcGroupBox3.ResumeLayout(False)
        Me.SgcGroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents tsMenu As SGC_CS.SGCToolStrip
    Friend WithEvents tsbLimpiar As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsbGuardar As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsbEliminar As System.Windows.Forms.ToolStripButton
    Friend WithEvents dgvProgramacion As SGC_CS.SGCDataGridView
    Friend WithEvents SgcGroupBox1 As SGC_CS.SGCGroupBox
    Friend WithEvents nudMonto As SGC_CS.SGCNumericUpDown
    Friend WithEvents txtCodigo As SGC_CS.SGCTextBox
    Friend WithEvents SgcLabel1 As SGC_CS.SGCLabel
    Friend WithEvents dgvRestricciones As SGC_CS.SGCDataGridView
    Friend WithEvents SgcGroupBox4 As SGC_CS.SGCGroupBox
    Friend WithEvents txtNombre As SGC_CS.SGCTextBox
    Friend WithEvents SgcLabel6 As SGC_CS.SGCLabel
    Friend WithEvents txtAccion As SGC_CS.SGCTextBox
    Friend WithEvents SgcLabel16 As SGC_CS.SGCLabel
    Friend WithEvents SgcGroupBox5 As SGC_CS.SGCGroupBox
    Friend WithEvents SgcGroupBox6 As SGC_CS.SGCGroupBox
    Friend WithEvents dgvInscritos As SGC_CS.SGCDataGridView
    Friend WithEvents SgcGroupBox7 As SGC_CS.SGCGroupBox
    Friend WithEvents dgvInvitados As SGC_CS.SGCDataGridView
    Friend WithEvents lblTitulo As SGC_CS.SGCLabel
    Friend WithEvents btnBuscarSocio As SGC_CS.SGCButton
    Friend WithEvents btnBuscarActividad As SGC_CS.SGCButton
    Friend WithEvents SgcLabel2 As SGC_CS.SGCLabel
    Friend WithEvents txtActividad As SGC_CS.SGCTextBox
    Friend WithEvents SgcLabel4 As SGC_CS.SGCLabel
    Friend WithEvents txtNumDoc As SGC_CS.SGCTextBox
    Friend WithEvents txtSerie As SGC_CS.SGCTextBox
    Friend WithEvents SgcLabel3 As SGC_CS.SGCLabel
    Friend WithEvents SgcGroupBox3 As SGC_CS.SGCGroupBox
    Friend WithEvents SgcGroupBox2 As SGC_CS.SGCGroupBox
    Friend WithEvents btnAgregarPersona As SGC_CS.SGCButton
    Friend WithEvents btnAgregarInvitado As SGC_CS.SGCButton
    Friend WithEvents btnQuitarInscrito As SGC_CS.SGCButton
    Friend WithEvents btnQuitarInvitado As SGC_CS.SGCButton
    Friend WithEvents colNombres As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colNombre As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colApePat As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colApeMat As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colNacimiento As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colDNI As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colRelacion As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colInscripcion As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colPersona As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colIdInv As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colINombres As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colIDNI As System.Windows.Forms.DataGridViewTextBoxColumn

End Class
