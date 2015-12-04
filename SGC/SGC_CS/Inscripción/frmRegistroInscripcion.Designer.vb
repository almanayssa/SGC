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
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.tsMenu = New SGC_CS.SGCToolStrip(Me.components)
        Me.sbLimpiar = New System.Windows.Forms.ToolStripButton()
        Me.sbGuardar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.SgcGroupBox2 = New SGC_CS.SGCGroupBox(Me.components)
        Me.SgcDataGridView1 = New SGC_CS.SGCDataGridView(Me.components)
        Me.SgcGroupBox1 = New SGC_CS.SGCGroupBox(Me.components)
        Me.SgcRadioButton2 = New SGC_CS.SGCRadioButton(Me.components)
        Me.SgcRadioButton1 = New SGC_CS.SGCRadioButton(Me.components)
        Me.SgcLabel12 = New SGC_CS.SGCLabel(Me.components)
        Me.SgcTextBox4 = New SGC_CS.SGCTextBox(Me.components)
        Me.SgcTextBox2 = New SGC_CS.SGCTextBox(Me.components)
        Me.SgcLabel11 = New SGC_CS.SGCLabel(Me.components)
        Me.SgcLabel10 = New SGC_CS.SGCLabel(Me.components)
        Me.SgcNumericUpDown1 = New SGC_CS.SGCNumericUpDown(Me.components)
        Me.SgcLabel7 = New SGC_CS.SGCLabel(Me.components)
        Me.SgcComboBox3 = New SGC_CS.SGCComboBox(Me.components)
        Me.SgcLabel4 = New SGC_CS.SGCLabel(Me.components)
        Me.SgcComboBox2 = New SGC_CS.SGCComboBox(Me.components)
        Me.SgcComboBox1 = New SGC_CS.SGCComboBox(Me.components)
        Me.SgcTextBox1 = New SGC_CS.SGCTextBox(Me.components)
        Me.SgcLabel3 = New SGC_CS.SGCLabel(Me.components)
        Me.SgcLabel2 = New SGC_CS.SGCLabel(Me.components)
        Me.SgcLabel1 = New SGC_CS.SGCLabel(Me.components)
        Me.SgcGroupBox3 = New SGC_CS.SGCGroupBox(Me.components)
        Me.SgcDataGridView2 = New SGC_CS.SGCDataGridView(Me.components)
        Me.SgcGroupBox4 = New SGC_CS.SGCGroupBox(Me.components)
        Me.SgcLabel5 = New SGC_CS.SGCLabel(Me.components)
        Me.SgcTextBox3 = New SGC_CS.SGCTextBox(Me.components)
        Me.SgcTextBox5 = New SGC_CS.SGCTextBox(Me.components)
        Me.SgcLabel6 = New SGC_CS.SGCLabel(Me.components)
        Me.SgcTextBox6 = New SGC_CS.SGCTextBox(Me.components)
        Me.SgcLabel16 = New SGC_CS.SGCLabel(Me.components)
        Me.SgcGroupBox5 = New SGC_CS.SGCGroupBox(Me.components)
        Me.SgcGroupBox6 = New SGC_CS.SGCGroupBox(Me.components)
        Me.SgcDataGridView3 = New SGC_CS.SGCDataGridView(Me.components)
        Me.SgcGroupBox7 = New SGC_CS.SGCGroupBox(Me.components)
        Me.SgcDataGridView4 = New SGC_CS.SGCDataGridView(Me.components)
        Me.tsMenu.SuspendLayout()
        Me.SgcGroupBox2.SuspendLayout()
        CType(Me.SgcDataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SgcGroupBox1.SuspendLayout()
        CType(Me.SgcNumericUpDown1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SgcGroupBox3.SuspendLayout()
        CType(Me.SgcDataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SgcGroupBox4.SuspendLayout()
        Me.SgcGroupBox6.SuspendLayout()
        CType(Me.SgcDataGridView3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SgcGroupBox7.SuspendLayout()
        CType(Me.SgcDataGridView4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tsMenu
        '
        Me.tsMenu.BackColor = System.Drawing.Color.Silver
        Me.tsMenu.Dock = System.Windows.Forms.DockStyle.None
        Me.tsMenu.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tsMenu.ImageScalingSize = New System.Drawing.Size(30, 30)
        Me.tsMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.sbLimpiar, Me.sbGuardar, Me.ToolStripButton1})
        Me.tsMenu.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow
        Me.tsMenu.Location = New System.Drawing.Point(60, 60)
        Me.tsMenu.Name = "tsMenu"
        Me.tsMenu.Size = New System.Drawing.Size(185, 37)
        Me.tsMenu.TabIndex = 20
        Me.tsMenu.Text = "SgcToolStrip1"
        '
        'sbLimpiar
        '
        Me.sbLimpiar.BackColor = System.Drawing.Color.WhiteSmoke
        Me.sbLimpiar.Image = Global.SGC_CS.My.Resources.Resources.menu_limpiar
        Me.sbLimpiar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.sbLimpiar.Margin = New System.Windows.Forms.Padding(1, 1, 1, 2)
        Me.sbLimpiar.Name = "sbLimpiar"
        Me.sbLimpiar.Size = New System.Drawing.Size(88, 34)
        Me.sbLimpiar.Text = "Limpiar"
        '
        'sbGuardar
        '
        Me.sbGuardar.BackColor = System.Drawing.Color.WhiteSmoke
        Me.sbGuardar.Image = Global.SGC_CS.My.Resources.Resources.menu_validar
        Me.sbGuardar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.sbGuardar.Margin = New System.Windows.Forms.Padding(1, 1, 1, 2)
        Me.sbGuardar.Name = "sbGuardar"
        Me.sbGuardar.Size = New System.Drawing.Size(92, 34)
        Me.sbGuardar.Text = "Guardar"
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ToolStripButton1.Image = Global.SGC_CS.My.Resources.Resources.menu_eliminar
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Margin = New System.Windows.Forms.Padding(1, 1, 1, 2)
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(93, 34)
        Me.ToolStripButton1.Text = "Eliminar"
        Me.ToolStripButton1.Visible = False
        '
        'SgcGroupBox2
        '
        Me.SgcGroupBox2.Controls.Add(Me.SgcDataGridView1)
        Me.SgcGroupBox2.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SgcGroupBox2.Location = New System.Drawing.Point(608, 100)
        Me.SgcGroupBox2.Name = "SgcGroupBox2"
        Me.SgcGroupBox2.Size = New System.Drawing.Size(354, 137)
        Me.SgcGroupBox2.TabIndex = 19
        Me.SgcGroupBox2.TabStop = False
        Me.SgcGroupBox2.Text = "Programación"
        '
        'SgcDataGridView1
        '
        Me.SgcDataGridView1.AllowUserToAddRows = False
        DataGridViewCellStyle9.BackColor = System.Drawing.Color.WhiteSmoke
        DataGridViewCellStyle9.ForeColor = System.Drawing.Color.SteelBlue
        Me.SgcDataGridView1.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle9
        Me.SgcDataGridView1.BackgroundColor = System.Drawing.Color.WhiteSmoke
        Me.SgcDataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.SgcDataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.SgcDataGridView1.Location = New System.Drawing.Point(18, 25)
        Me.SgcDataGridView1.Name = "SgcDataGridView1"
        Me.SgcDataGridView1.Size = New System.Drawing.Size(320, 97)
        Me.SgcDataGridView1.TabIndex = 1
        '
        'SgcGroupBox1
        '
        Me.SgcGroupBox1.Controls.Add(Me.SgcRadioButton2)
        Me.SgcGroupBox1.Controls.Add(Me.SgcRadioButton1)
        Me.SgcGroupBox1.Controls.Add(Me.SgcLabel12)
        Me.SgcGroupBox1.Controls.Add(Me.SgcTextBox4)
        Me.SgcGroupBox1.Controls.Add(Me.SgcTextBox2)
        Me.SgcGroupBox1.Controls.Add(Me.SgcLabel11)
        Me.SgcGroupBox1.Controls.Add(Me.SgcLabel10)
        Me.SgcGroupBox1.Controls.Add(Me.SgcNumericUpDown1)
        Me.SgcGroupBox1.Controls.Add(Me.SgcLabel7)
        Me.SgcGroupBox1.Controls.Add(Me.SgcComboBox3)
        Me.SgcGroupBox1.Controls.Add(Me.SgcLabel4)
        Me.SgcGroupBox1.Controls.Add(Me.SgcComboBox2)
        Me.SgcGroupBox1.Controls.Add(Me.SgcComboBox1)
        Me.SgcGroupBox1.Controls.Add(Me.SgcTextBox1)
        Me.SgcGroupBox1.Controls.Add(Me.SgcLabel3)
        Me.SgcGroupBox1.Controls.Add(Me.SgcLabel2)
        Me.SgcGroupBox1.Controls.Add(Me.SgcLabel1)
        Me.SgcGroupBox1.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SgcGroupBox1.Location = New System.Drawing.Point(60, 100)
        Me.SgcGroupBox1.Name = "SgcGroupBox1"
        Me.SgcGroupBox1.Size = New System.Drawing.Size(532, 209)
        Me.SgcGroupBox1.TabIndex = 18
        Me.SgcGroupBox1.TabStop = False
        Me.SgcGroupBox1.Text = "Actividad"
        '
        'SgcRadioButton2
        '
        Me.SgcRadioButton2.AutoSize = True
        Me.SgcRadioButton2.Location = New System.Drawing.Point(398, 37)
        Me.SgcRadioButton2.Name = "SgcRadioButton2"
        Me.SgcRadioButton2.Size = New System.Drawing.Size(95, 22)
        Me.SgcRadioButton2.TabIndex = 22
        Me.SgcRadioButton2.TabStop = True
        Me.SgcRadioButton2.Text = "Por Detalle"
        Me.SgcRadioButton2.UseVisualStyleBackColor = True
        '
        'SgcRadioButton1
        '
        Me.SgcRadioButton1.AutoSize = True
        Me.SgcRadioButton1.Location = New System.Drawing.Point(282, 37)
        Me.SgcRadioButton1.Name = "SgcRadioButton1"
        Me.SgcRadioButton1.Size = New System.Drawing.Size(108, 22)
        Me.SgcRadioButton1.TabIndex = 21
        Me.SgcRadioButton1.TabStop = True
        Me.SgcRadioButton1.Text = "Por Actividad"
        Me.SgcRadioButton1.UseVisualStyleBackColor = True
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
        'SgcTextBox4
        '
        Me.SgcTextBox4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.SgcTextBox4.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SgcTextBox4.ForeColor = System.Drawing.Color.Black
        Me.SgcTextBox4.Location = New System.Drawing.Point(109, 166)
        Me.SgcTextBox4.Name = "SgcTextBox4"
        Me.SgcTextBox4.Size = New System.Drawing.Size(384, 26)
        Me.SgcTextBox4.TabIndex = 19
        '
        'SgcTextBox2
        '
        Me.SgcTextBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.SgcTextBox2.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SgcTextBox2.ForeColor = System.Drawing.Color.Black
        Me.SgcTextBox2.Location = New System.Drawing.Point(109, 134)
        Me.SgcTextBox2.Name = "SgcTextBox2"
        Me.SgcTextBox2.Size = New System.Drawing.Size(384, 26)
        Me.SgcTextBox2.TabIndex = 17
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
        Me.SgcLabel10.Location = New System.Drawing.Point(445, 72)
        Me.SgcLabel10.Name = "SgcLabel10"
        Me.SgcLabel10.Size = New System.Drawing.Size(56, 18)
        Me.SgcLabel10.TabIndex = 14
        Me.SgcLabel10.Text = "soles(s)"
        '
        'SgcNumericUpDown1
        '
        Me.SgcNumericUpDown1.Location = New System.Drawing.Point(369, 70)
        Me.SgcNumericUpDown1.Name = "SgcNumericUpDown1"
        Me.SgcNumericUpDown1.Size = New System.Drawing.Size(69, 26)
        Me.SgcNumericUpDown1.TabIndex = 11
        '
        'SgcLabel7
        '
        Me.SgcLabel7.AutoSize = True
        Me.SgcLabel7.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SgcLabel7.ForeColor = System.Drawing.Color.SteelBlue
        Me.SgcLabel7.Location = New System.Drawing.Point(279, 72)
        Me.SgcLabel7.Name = "SgcLabel7"
        Me.SgcLabel7.Size = New System.Drawing.Size(42, 18)
        Me.SgcLabel7.TabIndex = 8
        Me.SgcLabel7.Text = "Pago:"
        '
        'SgcComboBox3
        '
        Me.SgcComboBox3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.SgcComboBox3.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.SgcComboBox3.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SgcComboBox3.ForeColor = System.Drawing.Color.Black
        Me.SgcComboBox3.FormattingEnabled = True
        Me.SgcComboBox3.Location = New System.Drawing.Point(369, 101)
        Me.SgcComboBox3.Name = "SgcComboBox3"
        Me.SgcComboBox3.Size = New System.Drawing.Size(121, 26)
        Me.SgcComboBox3.TabIndex = 7
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
        'SgcComboBox2
        '
        Me.SgcComboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.SgcComboBox2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.SgcComboBox2.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SgcComboBox2.ForeColor = System.Drawing.Color.Black
        Me.SgcComboBox2.FormattingEnabled = True
        Me.SgcComboBox2.Location = New System.Drawing.Point(109, 101)
        Me.SgcComboBox2.Name = "SgcComboBox2"
        Me.SgcComboBox2.Size = New System.Drawing.Size(121, 26)
        Me.SgcComboBox2.TabIndex = 5
        '
        'SgcComboBox1
        '
        Me.SgcComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.SgcComboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.SgcComboBox1.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SgcComboBox1.ForeColor = System.Drawing.Color.Black
        Me.SgcComboBox1.FormattingEnabled = True
        Me.SgcComboBox1.Location = New System.Drawing.Point(109, 69)
        Me.SgcComboBox1.Name = "SgcComboBox1"
        Me.SgcComboBox1.Size = New System.Drawing.Size(121, 26)
        Me.SgcComboBox1.TabIndex = 4
        '
        'SgcTextBox1
        '
        Me.SgcTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.SgcTextBox1.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SgcTextBox1.ForeColor = System.Drawing.Color.Black
        Me.SgcTextBox1.Location = New System.Drawing.Point(109, 37)
        Me.SgcTextBox1.Name = "SgcTextBox1"
        Me.SgcTextBox1.Size = New System.Drawing.Size(100, 26)
        Me.SgcTextBox1.TabIndex = 3
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
        'SgcGroupBox3
        '
        Me.SgcGroupBox3.Controls.Add(Me.SgcDataGridView2)
        Me.SgcGroupBox3.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SgcGroupBox3.Location = New System.Drawing.Point(608, 243)
        Me.SgcGroupBox3.Name = "SgcGroupBox3"
        Me.SgcGroupBox3.Size = New System.Drawing.Size(354, 137)
        Me.SgcGroupBox3.TabIndex = 21
        Me.SgcGroupBox3.TabStop = False
        Me.SgcGroupBox3.Text = "Restricciones"
        '
        'SgcDataGridView2
        '
        Me.SgcDataGridView2.AllowUserToAddRows = False
        DataGridViewCellStyle10.BackColor = System.Drawing.Color.WhiteSmoke
        DataGridViewCellStyle10.ForeColor = System.Drawing.Color.SteelBlue
        Me.SgcDataGridView2.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle10
        Me.SgcDataGridView2.BackgroundColor = System.Drawing.Color.WhiteSmoke
        Me.SgcDataGridView2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.SgcDataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.SgcDataGridView2.Location = New System.Drawing.Point(18, 25)
        Me.SgcDataGridView2.Name = "SgcDataGridView2"
        Me.SgcDataGridView2.Size = New System.Drawing.Size(320, 97)
        Me.SgcDataGridView2.TabIndex = 1
        '
        'SgcGroupBox4
        '
        Me.SgcGroupBox4.Controls.Add(Me.SgcLabel5)
        Me.SgcGroupBox4.Controls.Add(Me.SgcTextBox3)
        Me.SgcGroupBox4.Controls.Add(Me.SgcTextBox5)
        Me.SgcGroupBox4.Controls.Add(Me.SgcLabel6)
        Me.SgcGroupBox4.Controls.Add(Me.SgcTextBox6)
        Me.SgcGroupBox4.Controls.Add(Me.SgcLabel16)
        Me.SgcGroupBox4.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SgcGroupBox4.Location = New System.Drawing.Point(60, 315)
        Me.SgcGroupBox4.Name = "SgcGroupBox4"
        Me.SgcGroupBox4.Size = New System.Drawing.Size(532, 145)
        Me.SgcGroupBox4.TabIndex = 22
        Me.SgcGroupBox4.TabStop = False
        Me.SgcGroupBox4.Text = "Socio"
        '
        'SgcLabel5
        '
        Me.SgcLabel5.AutoSize = True
        Me.SgcLabel5.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SgcLabel5.ForeColor = System.Drawing.Color.SteelBlue
        Me.SgcLabel5.Location = New System.Drawing.Point(19, 103)
        Me.SgcLabel5.Name = "SgcLabel5"
        Me.SgcLabel5.Size = New System.Drawing.Size(84, 18)
        Me.SgcLabel5.TabIndex = 20
        Me.SgcLabel5.Text = "Descripción:"
        '
        'SgcTextBox3
        '
        Me.SgcTextBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.SgcTextBox3.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SgcTextBox3.ForeColor = System.Drawing.Color.Black
        Me.SgcTextBox3.Location = New System.Drawing.Point(109, 101)
        Me.SgcTextBox3.Name = "SgcTextBox3"
        Me.SgcTextBox3.Size = New System.Drawing.Size(384, 26)
        Me.SgcTextBox3.TabIndex = 19
        '
        'SgcTextBox5
        '
        Me.SgcTextBox5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.SgcTextBox5.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SgcTextBox5.ForeColor = System.Drawing.Color.Black
        Me.SgcTextBox5.Location = New System.Drawing.Point(109, 69)
        Me.SgcTextBox5.Name = "SgcTextBox5"
        Me.SgcTextBox5.Size = New System.Drawing.Size(384, 26)
        Me.SgcTextBox5.TabIndex = 17
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
        'SgcTextBox6
        '
        Me.SgcTextBox6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.SgcTextBox6.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SgcTextBox6.ForeColor = System.Drawing.Color.Black
        Me.SgcTextBox6.Location = New System.Drawing.Point(109, 37)
        Me.SgcTextBox6.Name = "SgcTextBox6"
        Me.SgcTextBox6.Size = New System.Drawing.Size(100, 26)
        Me.SgcTextBox6.TabIndex = 3
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
        Me.SgcGroupBox5.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SgcGroupBox5.Location = New System.Drawing.Point(608, 386)
        Me.SgcGroupBox5.Name = "SgcGroupBox5"
        Me.SgcGroupBox5.Size = New System.Drawing.Size(354, 74)
        Me.SgcGroupBox5.TabIndex = 23
        Me.SgcGroupBox5.TabStop = False
        Me.SgcGroupBox5.Text = "Pago Comite"
        '
        'SgcGroupBox6
        '
        Me.SgcGroupBox6.Controls.Add(Me.SgcDataGridView3)
        Me.SgcGroupBox6.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SgcGroupBox6.Location = New System.Drawing.Point(60, 476)
        Me.SgcGroupBox6.Name = "SgcGroupBox6"
        Me.SgcGroupBox6.Size = New System.Drawing.Size(452, 137)
        Me.SgcGroupBox6.TabIndex = 24
        Me.SgcGroupBox6.TabStop = False
        Me.SgcGroupBox6.Text = "Inscritos"
        '
        'SgcDataGridView3
        '
        Me.SgcDataGridView3.AllowUserToAddRows = False
        DataGridViewCellStyle11.BackColor = System.Drawing.Color.WhiteSmoke
        DataGridViewCellStyle11.ForeColor = System.Drawing.Color.SteelBlue
        Me.SgcDataGridView3.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle11
        Me.SgcDataGridView3.BackgroundColor = System.Drawing.Color.WhiteSmoke
        Me.SgcDataGridView3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.SgcDataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.SgcDataGridView3.Location = New System.Drawing.Point(18, 25)
        Me.SgcDataGridView3.Name = "SgcDataGridView3"
        Me.SgcDataGridView3.Size = New System.Drawing.Size(420, 97)
        Me.SgcDataGridView3.TabIndex = 1
        '
        'SgcGroupBox7
        '
        Me.SgcGroupBox7.Controls.Add(Me.SgcDataGridView4)
        Me.SgcGroupBox7.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SgcGroupBox7.Location = New System.Drawing.Point(518, 476)
        Me.SgcGroupBox7.Name = "SgcGroupBox7"
        Me.SgcGroupBox7.Size = New System.Drawing.Size(444, 137)
        Me.SgcGroupBox7.TabIndex = 25
        Me.SgcGroupBox7.TabStop = False
        Me.SgcGroupBox7.Text = "Invitados"
        '
        'SgcDataGridView4
        '
        Me.SgcDataGridView4.AllowUserToAddRows = False
        DataGridViewCellStyle12.BackColor = System.Drawing.Color.WhiteSmoke
        DataGridViewCellStyle12.ForeColor = System.Drawing.Color.SteelBlue
        Me.SgcDataGridView4.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle12
        Me.SgcDataGridView4.BackgroundColor = System.Drawing.Color.WhiteSmoke
        Me.SgcDataGridView4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.SgcDataGridView4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.SgcDataGridView4.Location = New System.Drawing.Point(18, 25)
        Me.SgcDataGridView4.Name = "SgcDataGridView4"
        Me.SgcDataGridView4.Size = New System.Drawing.Size(410, 97)
        Me.SgcDataGridView4.TabIndex = 1
        '
        'frmRegistroInscripcion
        '
        Me.ClientSize = New System.Drawing.Size(1016, 738)
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
        Me.tsMenu.ResumeLayout(False)
        Me.tsMenu.PerformLayout()
        Me.SgcGroupBox2.ResumeLayout(False)
        CType(Me.SgcDataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SgcGroupBox1.ResumeLayout(False)
        Me.SgcGroupBox1.PerformLayout()
        CType(Me.SgcNumericUpDown1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SgcGroupBox3.ResumeLayout(False)
        CType(Me.SgcDataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SgcGroupBox4.ResumeLayout(False)
        Me.SgcGroupBox4.PerformLayout()
        Me.SgcGroupBox6.ResumeLayout(False)
        CType(Me.SgcDataGridView3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SgcGroupBox7.ResumeLayout(False)
        CType(Me.SgcDataGridView4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents tsMenu As SGC_CS.SGCToolStrip
    Friend WithEvents sbLimpiar As System.Windows.Forms.ToolStripButton
    Friend WithEvents sbGuardar As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents SgcGroupBox2 As SGC_CS.SGCGroupBox
    Friend WithEvents SgcDataGridView1 As SGC_CS.SGCDataGridView
    Friend WithEvents SgcGroupBox1 As SGC_CS.SGCGroupBox
    Friend WithEvents SgcRadioButton2 As SGC_CS.SGCRadioButton
    Friend WithEvents SgcRadioButton1 As SGC_CS.SGCRadioButton
    Friend WithEvents SgcLabel12 As SGC_CS.SGCLabel
    Friend WithEvents SgcTextBox4 As SGC_CS.SGCTextBox
    Friend WithEvents SgcTextBox2 As SGC_CS.SGCTextBox
    Friend WithEvents SgcLabel11 As SGC_CS.SGCLabel
    Friend WithEvents SgcLabel10 As SGC_CS.SGCLabel
    Friend WithEvents SgcNumericUpDown1 As SGC_CS.SGCNumericUpDown
    Friend WithEvents SgcLabel7 As SGC_CS.SGCLabel
    Friend WithEvents SgcComboBox3 As SGC_CS.SGCComboBox
    Friend WithEvents SgcLabel4 As SGC_CS.SGCLabel
    Friend WithEvents SgcComboBox2 As SGC_CS.SGCComboBox
    Friend WithEvents SgcComboBox1 As SGC_CS.SGCComboBox
    Friend WithEvents SgcTextBox1 As SGC_CS.SGCTextBox
    Friend WithEvents SgcLabel3 As SGC_CS.SGCLabel
    Friend WithEvents SgcLabel2 As SGC_CS.SGCLabel
    Friend WithEvents SgcLabel1 As SGC_CS.SGCLabel
    Friend WithEvents SgcGroupBox3 As SGC_CS.SGCGroupBox
    Friend WithEvents SgcDataGridView2 As SGC_CS.SGCDataGridView
    Friend WithEvents SgcGroupBox4 As SGC_CS.SGCGroupBox
    Friend WithEvents SgcLabel5 As SGC_CS.SGCLabel
    Friend WithEvents SgcTextBox3 As SGC_CS.SGCTextBox
    Friend WithEvents SgcTextBox5 As SGC_CS.SGCTextBox
    Friend WithEvents SgcLabel6 As SGC_CS.SGCLabel
    Friend WithEvents SgcTextBox6 As SGC_CS.SGCTextBox
    Friend WithEvents SgcLabel16 As SGC_CS.SGCLabel
    Friend WithEvents SgcGroupBox5 As SGC_CS.SGCGroupBox
    Friend WithEvents SgcGroupBox6 As SGC_CS.SGCGroupBox
    Friend WithEvents SgcDataGridView3 As SGC_CS.SGCDataGridView
    Friend WithEvents SgcGroupBox7 As SGC_CS.SGCGroupBox
    Friend WithEvents SgcDataGridView4 As SGC_CS.SGCDataGridView

End Class
