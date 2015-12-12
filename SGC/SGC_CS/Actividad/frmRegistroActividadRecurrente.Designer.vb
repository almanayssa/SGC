<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRegistroActividadRecurrente
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
        Me.tsMenu = New SGC_CS.SGCToolStrip(Me.components)
        Me.tsbLimpiar = New System.Windows.Forms.ToolStripButton()
        Me.tsbGuardar = New System.Windows.Forms.ToolStripButton()
        Me.SgcGroupBox1 = New SGC_CS.SGCGroupBox(Me.components)
        Me.nudVacantes = New SGC_CS.SGCNumericUpDown(Me.components)
        Me.SgcLabel6 = New SGC_CS.SGCLabel(Me.components)
        Me.SgcLabel12 = New SGC_CS.SGCLabel(Me.components)
        Me.txtDescripcion = New SGC_CS.SGCTextBox(Me.components)
        Me.txtNombre = New SGC_CS.SGCTextBox(Me.components)
        Me.SgcLabel11 = New SGC_CS.SGCLabel(Me.components)
        Me.nudPago = New SGC_CS.SGCNumericUpDown(Me.components)
        Me.SgcLabel7 = New SGC_CS.SGCLabel(Me.components)
        Me.cboCategoria = New SGC_CS.SGCComboBox(Me.components)
        Me.SgcLabel4 = New SGC_CS.SGCLabel(Me.components)
        Me.cboTipo = New SGC_CS.SGCComboBox(Me.components)
        Me.cboComite = New SGC_CS.SGCComboBox(Me.components)
        Me.SgcLabel3 = New SGC_CS.SGCLabel(Me.components)
        Me.SgcLabel2 = New SGC_CS.SGCLabel(Me.components)
        Me.gbxRecurrencia = New System.Windows.Forms.GroupBox()
        Me.pnlMensual = New System.Windows.Forms.Panel()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.cboNombreDia = New System.Windows.Forms.ComboBox()
        Me.cboOrdinal = New System.Windows.Forms.ComboBox()
        Me.nudNumeroMes2 = New System.Windows.Forms.NumericUpDown()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.nudNumeroMes = New System.Windows.Forms.NumericUpDown()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.nudNumeroDia = New System.Windows.Forms.NumericUpDown()
        Me.rbntEl = New System.Windows.Forms.RadioButton()
        Me.rbtnDia = New System.Windows.Forms.RadioButton()
        Me.pnlRepeticiones = New System.Windows.Forms.Panel()
        Me.lblDiasSemanas = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.nudDiasSemanas = New System.Windows.Forms.NumericUpDown()
        Me.pnlHoras = New System.Windows.Forms.Panel()
        Me.dtpHoraFin = New System.Windows.Forms.DateTimePicker()
        Me.dtpHoraInicio = New System.Windows.Forms.DateTimePicker()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.Label33 = New System.Windows.Forms.Label()
        Me.cboTipoRecurrencia = New System.Windows.Forms.ComboBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.pnlDuracionRecurrencia = New System.Windows.Forms.Panel()
        Me.Label35 = New System.Windows.Forms.Label()
        Me.dtpFechaInicio = New System.Windows.Forms.DateTimePicker()
        Me.dtpFechaFin = New System.Windows.Forms.DateTimePicker()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.pnlSemanal = New System.Windows.Forms.Panel()
        Me.chkDomingo = New System.Windows.Forms.CheckBox()
        Me.chkSabado = New System.Windows.Forms.CheckBox()
        Me.chkViernes = New System.Windows.Forms.CheckBox()
        Me.chkJueves = New System.Windows.Forms.CheckBox()
        Me.chkMiercoles = New System.Windows.Forms.CheckBox()
        Me.chkMartes = New System.Windows.Forms.CheckBox()
        Me.chkLunes = New System.Windows.Forms.CheckBox()
        Me.lblTitulo = New SGC_CS.SGCLabel(Me.components)
        Me.tsMenu.SuspendLayout()
        Me.SgcGroupBox1.SuspendLayout()
        CType(Me.nudVacantes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudPago, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbxRecurrencia.SuspendLayout()
        Me.pnlMensual.SuspendLayout()
        CType(Me.nudNumeroMes2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudNumeroMes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudNumeroDia, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlRepeticiones.SuspendLayout()
        CType(Me.nudDiasSemanas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlHoras.SuspendLayout()
        Me.pnlDuracionRecurrencia.SuspendLayout()
        Me.pnlSemanal.SuspendLayout()
        Me.SuspendLayout()
        '
        'tsMenu
        '
        Me.tsMenu.BackColor = System.Drawing.Color.Silver
        Me.tsMenu.Dock = System.Windows.Forms.DockStyle.None
        Me.tsMenu.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tsMenu.ImageScalingSize = New System.Drawing.Size(30, 30)
        Me.tsMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsbLimpiar, Me.tsbGuardar})
        Me.tsMenu.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow
        Me.tsMenu.Location = New System.Drawing.Point(60, 49)
        Me.tsMenu.Name = "tsMenu"
        Me.tsMenu.Size = New System.Drawing.Size(185, 37)
        Me.tsMenu.TabIndex = 18
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
        'SgcGroupBox1
        '
        Me.SgcGroupBox1.Controls.Add(Me.nudVacantes)
        Me.SgcGroupBox1.Controls.Add(Me.SgcLabel6)
        Me.SgcGroupBox1.Controls.Add(Me.SgcLabel12)
        Me.SgcGroupBox1.Controls.Add(Me.txtDescripcion)
        Me.SgcGroupBox1.Controls.Add(Me.txtNombre)
        Me.SgcGroupBox1.Controls.Add(Me.SgcLabel11)
        Me.SgcGroupBox1.Controls.Add(Me.nudPago)
        Me.SgcGroupBox1.Controls.Add(Me.SgcLabel7)
        Me.SgcGroupBox1.Controls.Add(Me.cboCategoria)
        Me.SgcGroupBox1.Controls.Add(Me.SgcLabel4)
        Me.SgcGroupBox1.Controls.Add(Me.cboTipo)
        Me.SgcGroupBox1.Controls.Add(Me.cboComite)
        Me.SgcGroupBox1.Controls.Add(Me.SgcLabel3)
        Me.SgcGroupBox1.Controls.Add(Me.SgcLabel2)
        Me.SgcGroupBox1.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SgcGroupBox1.Location = New System.Drawing.Point(60, 89)
        Me.SgcGroupBox1.Name = "SgcGroupBox1"
        Me.SgcGroupBox1.Size = New System.Drawing.Size(471, 232)
        Me.SgcGroupBox1.TabIndex = 19
        Me.SgcGroupBox1.TabStop = False
        Me.SgcGroupBox1.Text = "Datos"
        '
        'nudVacantes
        '
        Me.nudVacantes.Location = New System.Drawing.Point(369, 72)
        Me.nudVacantes.Name = "nudVacantes"
        Me.nudVacantes.Size = New System.Drawing.Size(69, 26)
        Me.nudVacantes.TabIndex = 22
        '
        'SgcLabel6
        '
        Me.SgcLabel6.AutoSize = True
        Me.SgcLabel6.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SgcLabel6.ForeColor = System.Drawing.Color.SteelBlue
        Me.SgcLabel6.Location = New System.Drawing.Point(279, 74)
        Me.SgcLabel6.Name = "SgcLabel6"
        Me.SgcLabel6.Size = New System.Drawing.Size(67, 18)
        Me.SgcLabel6.TabIndex = 21
        Me.SgcLabel6.Text = "Vacantes:"
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
        Me.txtDescripcion.Size = New System.Drawing.Size(329, 53)
        Me.txtDescripcion.TabIndex = 19
        '
        'txtNombre
        '
        Me.txtNombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNombre.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombre.ForeColor = System.Drawing.Color.Black
        Me.txtNombre.Location = New System.Drawing.Point(109, 134)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(329, 26)
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
        'nudPago
        '
        Me.nudPago.Location = New System.Drawing.Point(369, 35)
        Me.nudPago.Name = "nudPago"
        Me.nudPago.Size = New System.Drawing.Size(69, 26)
        Me.nudPago.TabIndex = 11
        '
        'SgcLabel7
        '
        Me.SgcLabel7.AutoSize = True
        Me.SgcLabel7.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SgcLabel7.ForeColor = System.Drawing.Color.SteelBlue
        Me.SgcLabel7.Location = New System.Drawing.Point(279, 37)
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
        Me.cboCategoria.Location = New System.Drawing.Point(109, 98)
        Me.cboCategoria.Name = "cboCategoria"
        Me.cboCategoria.Size = New System.Drawing.Size(121, 26)
        Me.cboCategoria.TabIndex = 7
        '
        'SgcLabel4
        '
        Me.SgcLabel4.AutoSize = True
        Me.SgcLabel4.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SgcLabel4.ForeColor = System.Drawing.Color.SteelBlue
        Me.SgcLabel4.Location = New System.Drawing.Point(19, 102)
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
        Me.cboTipo.Location = New System.Drawing.Point(109, 69)
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
        Me.cboComite.Location = New System.Drawing.Point(109, 37)
        Me.cboComite.Name = "cboComite"
        Me.cboComite.Size = New System.Drawing.Size(121, 26)
        Me.cboComite.TabIndex = 4
        '
        'SgcLabel3
        '
        Me.SgcLabel3.AutoSize = True
        Me.SgcLabel3.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SgcLabel3.ForeColor = System.Drawing.Color.SteelBlue
        Me.SgcLabel3.Location = New System.Drawing.Point(19, 72)
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
        Me.SgcLabel2.Location = New System.Drawing.Point(19, 40)
        Me.SgcLabel2.Name = "SgcLabel2"
        Me.SgcLabel2.Size = New System.Drawing.Size(57, 18)
        Me.SgcLabel2.TabIndex = 1
        Me.SgcLabel2.Text = "Comite:"
        '
        'gbxRecurrencia
        '
        Me.gbxRecurrencia.Controls.Add(Me.pnlMensual)
        Me.gbxRecurrencia.Controls.Add(Me.pnlRepeticiones)
        Me.gbxRecurrencia.Controls.Add(Me.pnlHoras)
        Me.gbxRecurrencia.Controls.Add(Me.cboTipoRecurrencia)
        Me.gbxRecurrencia.Controls.Add(Me.Label19)
        Me.gbxRecurrencia.Controls.Add(Me.pnlDuracionRecurrencia)
        Me.gbxRecurrencia.Controls.Add(Me.pnlSemanal)
        Me.gbxRecurrencia.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbxRecurrencia.ForeColor = System.Drawing.Color.Black
        Me.gbxRecurrencia.Location = New System.Drawing.Point(537, 89)
        Me.gbxRecurrencia.Name = "gbxRecurrencia"
        Me.gbxRecurrencia.Size = New System.Drawing.Size(467, 232)
        Me.gbxRecurrencia.TabIndex = 20
        Me.gbxRecurrencia.TabStop = False
        Me.gbxRecurrencia.Text = "Recurrencia"
        '
        'pnlMensual
        '
        Me.pnlMensual.Controls.Add(Me.Label24)
        Me.pnlMensual.Controls.Add(Me.Label23)
        Me.pnlMensual.Controls.Add(Me.cboNombreDia)
        Me.pnlMensual.Controls.Add(Me.cboOrdinal)
        Me.pnlMensual.Controls.Add(Me.nudNumeroMes2)
        Me.pnlMensual.Controls.Add(Me.Label22)
        Me.pnlMensual.Controls.Add(Me.nudNumeroMes)
        Me.pnlMensual.Controls.Add(Me.Label21)
        Me.pnlMensual.Controls.Add(Me.nudNumeroDia)
        Me.pnlMensual.Controls.Add(Me.rbntEl)
        Me.pnlMensual.Controls.Add(Me.rbtnDia)
        Me.pnlMensual.Location = New System.Drawing.Point(9, 54)
        Me.pnlMensual.Name = "pnlMensual"
        Me.pnlMensual.Size = New System.Drawing.Size(433, 72)
        Me.pnlMensual.TabIndex = 38
        Me.pnlMensual.Visible = False
        '
        'Label24
        '
        Me.Label24.ForeColor = System.Drawing.Color.Black
        Me.Label24.Location = New System.Drawing.Point(327, 46)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(60, 17)
        Me.Label24.TabIndex = 45
        Me.Label24.Text = "mes(es)"
        '
        'Label23
        '
        Me.Label23.ForeColor = System.Drawing.Color.Black
        Me.Label23.Location = New System.Drawing.Point(226, 46)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(56, 17)
        Me.Label23.TabIndex = 44
        Me.Label23.Text = "de cada"
        '
        'cboNombreDia
        '
        Me.cboNombreDia.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cboNombreDia.ForeColor = System.Drawing.Color.Black
        Me.cboNombreDia.FormattingEnabled = True
        Me.cboNombreDia.Items.AddRange(New Object() {"Lunes", "Martes", "Miércoles", "Jueves", "Viernes", "Sábado", "Domingo"})
        Me.cboNombreDia.Location = New System.Drawing.Point(138, 40)
        Me.cboNombreDia.Name = "cboNombreDia"
        Me.cboNombreDia.Size = New System.Drawing.Size(85, 26)
        Me.cboNombreDia.TabIndex = 43
        '
        'cboOrdinal
        '
        Me.cboOrdinal.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cboOrdinal.ForeColor = System.Drawing.Color.Black
        Me.cboOrdinal.FormattingEnabled = True
        Me.cboOrdinal.Items.AddRange(New Object() {"primer", "segundo", "tercer", "cuarto", "último"})
        Me.cboOrdinal.Location = New System.Drawing.Point(55, 40)
        Me.cboOrdinal.Name = "cboOrdinal"
        Me.cboOrdinal.Size = New System.Drawing.Size(80, 26)
        Me.cboOrdinal.TabIndex = 39
        '
        'nudNumeroMes2
        '
        Me.nudNumeroMes2.Location = New System.Drawing.Point(286, 40)
        Me.nudNumeroMes2.Maximum = New Decimal(New Integer() {12, 0, 0, 0})
        Me.nudNumeroMes2.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nudNumeroMes2.Name = "nudNumeroMes2"
        Me.nudNumeroMes2.Size = New System.Drawing.Size(40, 26)
        Me.nudNumeroMes2.TabIndex = 42
        Me.nudNumeroMes2.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Label22
        '
        Me.Label22.ForeColor = System.Drawing.Color.Black
        Me.Label22.Location = New System.Drawing.Point(194, 13)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(60, 17)
        Me.Label22.TabIndex = 41
        Me.Label22.Text = "mes(es)"
        '
        'nudNumeroMes
        '
        Me.nudNumeroMes.Location = New System.Drawing.Point(152, 11)
        Me.nudNumeroMes.Maximum = New Decimal(New Integer() {12, 0, 0, 0})
        Me.nudNumeroMes.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nudNumeroMes.Name = "nudNumeroMes"
        Me.nudNumeroMes.Size = New System.Drawing.Size(40, 26)
        Me.nudNumeroMes.TabIndex = 40
        Me.nudNumeroMes.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Label21
        '
        Me.Label21.ForeColor = System.Drawing.Color.Black
        Me.Label21.Location = New System.Drawing.Point(97, 14)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(56, 17)
        Me.Label21.TabIndex = 39
        Me.Label21.Text = "de cada"
        '
        'nudNumeroDia
        '
        Me.nudNumeroDia.Location = New System.Drawing.Point(55, 11)
        Me.nudNumeroDia.Maximum = New Decimal(New Integer() {31, 0, 0, 0})
        Me.nudNumeroDia.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nudNumeroDia.Name = "nudNumeroDia"
        Me.nudNumeroDia.Size = New System.Drawing.Size(40, 26)
        Me.nudNumeroDia.TabIndex = 39
        Me.nudNumeroDia.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'rbntEl
        '
        Me.rbntEl.AutoSize = True
        Me.rbntEl.Location = New System.Drawing.Point(8, 44)
        Me.rbntEl.Name = "rbntEl"
        Me.rbntEl.Size = New System.Drawing.Size(41, 22)
        Me.rbntEl.TabIndex = 36
        Me.rbntEl.TabStop = True
        Me.rbntEl.Text = "El:"
        Me.rbntEl.UseVisualStyleBackColor = True
        '
        'rbtnDia
        '
        Me.rbtnDia.AutoSize = True
        Me.rbtnDia.Checked = True
        Me.rbtnDia.Location = New System.Drawing.Point(8, 12)
        Me.rbtnDia.Name = "rbtnDia"
        Me.rbtnDia.Size = New System.Drawing.Size(50, 22)
        Me.rbtnDia.TabIndex = 35
        Me.rbtnDia.TabStop = True
        Me.rbtnDia.Text = "Día:"
        Me.rbtnDia.UseVisualStyleBackColor = True
        '
        'pnlRepeticiones
        '
        Me.pnlRepeticiones.Controls.Add(Me.lblDiasSemanas)
        Me.pnlRepeticiones.Controls.Add(Me.Label20)
        Me.pnlRepeticiones.Controls.Add(Me.nudDiasSemanas)
        Me.pnlRepeticiones.Location = New System.Drawing.Point(9, 54)
        Me.pnlRepeticiones.Name = "pnlRepeticiones"
        Me.pnlRepeticiones.Size = New System.Drawing.Size(317, 33)
        Me.pnlRepeticiones.TabIndex = 54
        '
        'lblDiasSemanas
        '
        Me.lblDiasSemanas.ForeColor = System.Drawing.Color.Black
        Me.lblDiasSemanas.Location = New System.Drawing.Point(145, 8)
        Me.lblDiasSemanas.Name = "lblDiasSemanas"
        Me.lblDiasSemanas.Size = New System.Drawing.Size(165, 17)
        Me.lblDiasSemanas.TabIndex = 33
        Me.lblDiasSemanas.Text = "día(s)"
        '
        'Label20
        '
        Me.Label20.ForeColor = System.Drawing.Color.SteelBlue
        Me.Label20.Location = New System.Drawing.Point(4, 10)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(89, 17)
        Me.Label20.TabIndex = 23
        Me.Label20.Text = "Repetir cada:"
        '
        'nudDiasSemanas
        '
        Me.nudDiasSemanas.Location = New System.Drawing.Point(102, 4)
        Me.nudDiasSemanas.Maximum = New Decimal(New Integer() {14, 0, 0, 0})
        Me.nudDiasSemanas.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nudDiasSemanas.Name = "nudDiasSemanas"
        Me.nudDiasSemanas.Size = New System.Drawing.Size(40, 26)
        Me.nudDiasSemanas.TabIndex = 32
        Me.nudDiasSemanas.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'pnlHoras
        '
        Me.pnlHoras.Controls.Add(Me.dtpHoraFin)
        Me.pnlHoras.Controls.Add(Me.dtpHoraInicio)
        Me.pnlHoras.Controls.Add(Me.Label30)
        Me.pnlHoras.Controls.Add(Me.Label33)
        Me.pnlHoras.Location = New System.Drawing.Point(103, 86)
        Me.pnlHoras.Name = "pnlHoras"
        Me.pnlHoras.Size = New System.Drawing.Size(278, 31)
        Me.pnlHoras.TabIndex = 53
        '
        'dtpHoraFin
        '
        Me.dtpHoraFin.CustomFormat = "HH:mm"
        Me.dtpHoraFin.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpHoraFin.Location = New System.Drawing.Point(211, 2)
        Me.dtpHoraFin.Name = "dtpHoraFin"
        Me.dtpHoraFin.ShowUpDown = True
        Me.dtpHoraFin.Size = New System.Drawing.Size(55, 26)
        Me.dtpHoraFin.TabIndex = 45
        '
        'dtpHoraInicio
        '
        Me.dtpHoraInicio.CustomFormat = "HH:mm"
        Me.dtpHoraInicio.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpHoraInicio.Location = New System.Drawing.Point(85, 2)
        Me.dtpHoraInicio.Name = "dtpHoraInicio"
        Me.dtpHoraInicio.ShowUpDown = True
        Me.dtpHoraInicio.Size = New System.Drawing.Size(55, 26)
        Me.dtpHoraInicio.TabIndex = 44
        '
        'Label30
        '
        Me.Label30.ForeColor = System.Drawing.Color.Black
        Me.Label30.Location = New System.Drawing.Point(3, 6)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(83, 17)
        Me.Label30.TabIndex = 46
        Me.Label30.Text = "hora inicio:"
        '
        'Label33
        '
        Me.Label33.ForeColor = System.Drawing.Color.Black
        Me.Label33.Location = New System.Drawing.Point(146, 5)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(63, 17)
        Me.Label33.TabIndex = 47
        Me.Label33.Text = "hora fin:"
        '
        'cboTipoRecurrencia
        '
        Me.cboTipoRecurrencia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboTipoRecurrencia.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cboTipoRecurrencia.ForeColor = System.Drawing.Color.Black
        Me.cboTipoRecurrencia.FormattingEnabled = True
        Me.cboTipoRecurrencia.Items.AddRange(New Object() {"Diaria", "Semanal", "Mensual"})
        Me.cboTipoRecurrencia.Location = New System.Drawing.Point(111, 25)
        Me.cboTipoRecurrencia.Name = "cboTipoRecurrencia"
        Me.cboTipoRecurrencia.Size = New System.Drawing.Size(160, 26)
        Me.cboTipoRecurrencia.TabIndex = 22
        '
        'Label19
        '
        Me.Label19.ForeColor = System.Drawing.Color.SteelBlue
        Me.Label19.Location = New System.Drawing.Point(13, 31)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(89, 17)
        Me.Label19.TabIndex = 21
        Me.Label19.Text = "Recurrencia:"
        '
        'pnlDuracionRecurrencia
        '
        Me.pnlDuracionRecurrencia.Controls.Add(Me.Label35)
        Me.pnlDuracionRecurrencia.Controls.Add(Me.dtpFechaInicio)
        Me.pnlDuracionRecurrencia.Controls.Add(Me.dtpFechaFin)
        Me.pnlDuracionRecurrencia.Controls.Add(Me.Label25)
        Me.pnlDuracionRecurrencia.Location = New System.Drawing.Point(9, 124)
        Me.pnlDuracionRecurrencia.Name = "pnlDuracionRecurrencia"
        Me.pnlDuracionRecurrencia.Size = New System.Drawing.Size(433, 58)
        Me.pnlDuracionRecurrencia.TabIndex = 43
        '
        'Label35
        '
        Me.Label35.ForeColor = System.Drawing.Color.SteelBlue
        Me.Label35.Location = New System.Drawing.Point(3, 7)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(94, 17)
        Me.Label35.TabIndex = 44
        Me.Label35.Text = "Fecha Inicio:"
        '
        'dtpFechaInicio
        '
        Me.dtpFechaInicio.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaInicio.Location = New System.Drawing.Point(97, 3)
        Me.dtpFechaInicio.Name = "dtpFechaInicio"
        Me.dtpFechaInicio.Size = New System.Drawing.Size(109, 26)
        Me.dtpFechaInicio.TabIndex = 43
        '
        'dtpFechaFin
        '
        Me.dtpFechaFin.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaFin.Location = New System.Drawing.Point(97, 30)
        Me.dtpFechaFin.Name = "dtpFechaFin"
        Me.dtpFechaFin.Size = New System.Drawing.Size(109, 26)
        Me.dtpFechaFin.TabIndex = 42
        '
        'Label25
        '
        Me.Label25.ForeColor = System.Drawing.Color.SteelBlue
        Me.Label25.Location = New System.Drawing.Point(3, 34)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(94, 17)
        Me.Label25.TabIndex = 39
        Me.Label25.Text = "Fecha Fin:"
        '
        'pnlSemanal
        '
        Me.pnlSemanal.Controls.Add(Me.chkDomingo)
        Me.pnlSemanal.Controls.Add(Me.chkSabado)
        Me.pnlSemanal.Controls.Add(Me.chkViernes)
        Me.pnlSemanal.Controls.Add(Me.chkJueves)
        Me.pnlSemanal.Controls.Add(Me.chkMiercoles)
        Me.pnlSemanal.Controls.Add(Me.chkMartes)
        Me.pnlSemanal.Controls.Add(Me.chkLunes)
        Me.pnlSemanal.Location = New System.Drawing.Point(111, 86)
        Me.pnlSemanal.Name = "pnlSemanal"
        Me.pnlSemanal.Size = New System.Drawing.Size(303, 68)
        Me.pnlSemanal.TabIndex = 34
        Me.pnlSemanal.Visible = False
        '
        'chkDomingo
        '
        Me.chkDomingo.AutoSize = True
        Me.chkDomingo.Location = New System.Drawing.Point(212, 3)
        Me.chkDomingo.Name = "chkDomingo"
        Me.chkDomingo.Size = New System.Drawing.Size(83, 22)
        Me.chkDomingo.TabIndex = 6
        Me.chkDomingo.Text = "Domingo"
        Me.chkDomingo.UseVisualStyleBackColor = True
        '
        'chkSabado
        '
        Me.chkSabado.AutoSize = True
        Me.chkSabado.Location = New System.Drawing.Point(113, 42)
        Me.chkSabado.Name = "chkSabado"
        Me.chkSabado.Size = New System.Drawing.Size(72, 22)
        Me.chkSabado.TabIndex = 5
        Me.chkSabado.Text = "Sábado"
        Me.chkSabado.UseVisualStyleBackColor = True
        '
        'chkViernes
        '
        Me.chkViernes.AutoSize = True
        Me.chkViernes.Location = New System.Drawing.Point(113, 22)
        Me.chkViernes.Name = "chkViernes"
        Me.chkViernes.Size = New System.Drawing.Size(75, 22)
        Me.chkViernes.TabIndex = 4
        Me.chkViernes.Text = "Viernes"
        Me.chkViernes.UseVisualStyleBackColor = True
        '
        'chkJueves
        '
        Me.chkJueves.AutoSize = True
        Me.chkJueves.Location = New System.Drawing.Point(113, 3)
        Me.chkJueves.Name = "chkJueves"
        Me.chkJueves.Size = New System.Drawing.Size(69, 22)
        Me.chkJueves.TabIndex = 3
        Me.chkJueves.Text = "Jueves"
        Me.chkJueves.UseVisualStyleBackColor = True
        '
        'chkMiercoles
        '
        Me.chkMiercoles.AutoSize = True
        Me.chkMiercoles.Location = New System.Drawing.Point(3, 42)
        Me.chkMiercoles.Name = "chkMiercoles"
        Me.chkMiercoles.Size = New System.Drawing.Size(89, 22)
        Me.chkMiercoles.TabIndex = 2
        Me.chkMiercoles.Text = "Miércoles"
        Me.chkMiercoles.UseVisualStyleBackColor = True
        '
        'chkMartes
        '
        Me.chkMartes.AutoSize = True
        Me.chkMartes.Location = New System.Drawing.Point(3, 22)
        Me.chkMartes.Name = "chkMartes"
        Me.chkMartes.Size = New System.Drawing.Size(71, 22)
        Me.chkMartes.TabIndex = 1
        Me.chkMartes.Text = "Martes"
        Me.chkMartes.UseVisualStyleBackColor = True
        '
        'chkLunes
        '
        Me.chkLunes.AutoSize = True
        Me.chkLunes.Location = New System.Drawing.Point(3, 3)
        Me.chkLunes.Name = "chkLunes"
        Me.chkLunes.Size = New System.Drawing.Size(63, 22)
        Me.chkLunes.TabIndex = 0
        Me.chkLunes.Text = "Lunes"
        Me.chkLunes.UseVisualStyleBackColor = True
        '
        'lblTitulo
        '
        Me.lblTitulo.AutoSize = True
        Me.lblTitulo.BackColor = System.Drawing.Color.ForestGreen
        Me.lblTitulo.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitulo.ForeColor = System.Drawing.Color.White
        Me.lblTitulo.Location = New System.Drawing.Point(397, 9)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(249, 23)
        Me.lblTitulo.TabIndex = 25
        Me.lblTitulo.Text = "Registro Actividad Recurrente"
        '
        'frmRegistroActividadRecurrente
        '
        Me.ClientSize = New System.Drawing.Size(1016, 733)
        Me.Controls.Add(Me.lblTitulo)
        Me.Controls.Add(Me.gbxRecurrencia)
        Me.Controls.Add(Me.SgcGroupBox1)
        Me.Controls.Add(Me.tsMenu)
        Me.Name = "frmRegistroActividadRecurrente"
        Me.Controls.SetChildIndex(Me.tsMenu, 0)
        Me.Controls.SetChildIndex(Me.SgcGroupBox1, 0)
        Me.Controls.SetChildIndex(Me.gbxRecurrencia, 0)
        Me.Controls.SetChildIndex(Me.lblTitulo, 0)
        Me.tsMenu.ResumeLayout(False)
        Me.tsMenu.PerformLayout()
        Me.SgcGroupBox1.ResumeLayout(False)
        Me.SgcGroupBox1.PerformLayout()
        CType(Me.nudVacantes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudPago, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbxRecurrencia.ResumeLayout(False)
        Me.pnlMensual.ResumeLayout(False)
        Me.pnlMensual.PerformLayout()
        CType(Me.nudNumeroMes2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudNumeroMes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudNumeroDia, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlRepeticiones.ResumeLayout(False)
        CType(Me.nudDiasSemanas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlHoras.ResumeLayout(False)
        Me.pnlDuracionRecurrencia.ResumeLayout(False)
        Me.pnlSemanal.ResumeLayout(False)
        Me.pnlSemanal.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents tsMenu As SGC_CS.SGCToolStrip
    Friend WithEvents tsbGuardar As System.Windows.Forms.ToolStripButton
    Friend WithEvents SgcGroupBox1 As SGC_CS.SGCGroupBox
    Friend WithEvents nudVacantes As SGC_CS.SGCNumericUpDown
    Friend WithEvents SgcLabel6 As SGC_CS.SGCLabel
    Friend WithEvents SgcLabel12 As SGC_CS.SGCLabel
    Friend WithEvents txtDescripcion As SGC_CS.SGCTextBox
    Friend WithEvents txtNombre As SGC_CS.SGCTextBox
    Friend WithEvents SgcLabel11 As SGC_CS.SGCLabel
    Friend WithEvents nudPago As SGC_CS.SGCNumericUpDown
    Friend WithEvents SgcLabel7 As SGC_CS.SGCLabel
    Friend WithEvents cboCategoria As SGC_CS.SGCComboBox
    Friend WithEvents SgcLabel4 As SGC_CS.SGCLabel
    Friend WithEvents cboTipo As SGC_CS.SGCComboBox
    Friend WithEvents cboComite As SGC_CS.SGCComboBox
    Friend WithEvents SgcLabel3 As SGC_CS.SGCLabel
    Friend WithEvents SgcLabel2 As SGC_CS.SGCLabel
    Friend WithEvents gbxRecurrencia As System.Windows.Forms.GroupBox
    Friend WithEvents pnlMensual As System.Windows.Forms.Panel
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents cboNombreDia As System.Windows.Forms.ComboBox
    Friend WithEvents cboOrdinal As System.Windows.Forms.ComboBox
    Friend WithEvents nudNumeroMes2 As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents nudNumeroMes As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents nudNumeroDia As System.Windows.Forms.NumericUpDown
    Friend WithEvents rbntEl As System.Windows.Forms.RadioButton
    Friend WithEvents rbtnDia As System.Windows.Forms.RadioButton
    Friend WithEvents pnlRepeticiones As System.Windows.Forms.Panel
    Friend WithEvents lblDiasSemanas As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents nudDiasSemanas As System.Windows.Forms.NumericUpDown
    Friend WithEvents pnlHoras As System.Windows.Forms.Panel
    Friend WithEvents dtpHoraFin As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpHoraInicio As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label30 As System.Windows.Forms.Label
    Friend WithEvents Label33 As System.Windows.Forms.Label
    Friend WithEvents cboTipoRecurrencia As System.Windows.Forms.ComboBox
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents pnlDuracionRecurrencia As System.Windows.Forms.Panel
    Friend WithEvents Label35 As System.Windows.Forms.Label
    Friend WithEvents dtpFechaInicio As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpFechaFin As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents pnlSemanal As System.Windows.Forms.Panel
    Friend WithEvents chkDomingo As System.Windows.Forms.CheckBox
    Friend WithEvents chkSabado As System.Windows.Forms.CheckBox
    Friend WithEvents chkViernes As System.Windows.Forms.CheckBox
    Friend WithEvents chkJueves As System.Windows.Forms.CheckBox
    Friend WithEvents chkMiercoles As System.Windows.Forms.CheckBox
    Friend WithEvents chkMartes As System.Windows.Forms.CheckBox
    Friend WithEvents chkLunes As System.Windows.Forms.CheckBox
    Friend WithEvents tsbLimpiar As System.Windows.Forms.ToolStripButton
    Friend WithEvents lblTitulo As SGC_CS.SGCLabel

End Class
