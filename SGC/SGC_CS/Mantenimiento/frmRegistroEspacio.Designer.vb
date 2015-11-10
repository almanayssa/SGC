<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRegistroEspacio
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
        Me.lblTitulo = New SGC_CS.SGCLabel(Me.components)
        Me.tsMenu = New SGC_CS.SGCToolStrip(Me.components)
        Me.sbLimpiar = New System.Windows.Forms.ToolStripButton()
        Me.sbGuardar = New System.Windows.Forms.ToolStripButton()
        Me.sbEditar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton2 = New System.Windows.Forms.ToolStripButton()
        Me.SgcGroupBox1 = New SGC_CS.SGCGroupBox(Me.components)
        Me.SgcLabel1 = New SGC_CS.SGCLabel(Me.components)
        Me.SgcLabel2 = New SGC_CS.SGCLabel(Me.components)
        Me.SgcLabel3 = New SGC_CS.SGCLabel(Me.components)
        Me.SgcComboBox1 = New SGC_CS.SGCComboBox(Me.components)
        Me.SgcComboBox2 = New SGC_CS.SGCComboBox(Me.components)
        Me.SgcTextBox1 = New SGC_CS.SGCTextBox(Me.components)
        Me.SgcLabel4 = New SGC_CS.SGCLabel(Me.components)
        Me.chkAforo = New SGC_CS.SGCCheckBox(Me.components)
        Me.SgcNumericUpDown1 = New SGC_CS.SGCNumericUpDown(Me.components)
        Me.tsMenu.SuspendLayout()
        Me.SgcGroupBox1.SuspendLayout()
        CType(Me.SgcNumericUpDown1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblTitulo
        '
        Me.lblTitulo.AutoSize = True
        Me.lblTitulo.BackColor = System.Drawing.Color.ForestGreen
        Me.lblTitulo.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitulo.ForeColor = System.Drawing.Color.White
        Me.lblTitulo.Location = New System.Drawing.Point(401, 11)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(172, 23)
        Me.lblTitulo.TabIndex = 15
        Me.lblTitulo.Text = "Registro de Espacios"
        '
        'tsMenu
        '
        Me.tsMenu.BackColor = System.Drawing.Color.Silver
        Me.tsMenu.Dock = System.Windows.Forms.DockStyle.None
        Me.tsMenu.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tsMenu.ImageScalingSize = New System.Drawing.Size(30, 30)
        Me.tsMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.sbLimpiar, Me.sbGuardar, Me.sbEditar, Me.ToolStripButton1, Me.ToolStripButton2})
        Me.tsMenu.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow
        Me.tsMenu.Location = New System.Drawing.Point(60, 71)
        Me.tsMenu.Name = "tsMenu"
        Me.tsMenu.Size = New System.Drawing.Size(480, 37)
        Me.tsMenu.TabIndex = 16
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
        'sbEditar
        '
        Me.sbEditar.BackColor = System.Drawing.Color.WhiteSmoke
        Me.sbEditar.Image = Global.SGC_CS.My.Resources.Resources.menu_editar
        Me.sbEditar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.sbEditar.Margin = New System.Windows.Forms.Padding(1, 1, 1, 2)
        Me.sbEditar.Name = "sbEditar"
        Me.sbEditar.Size = New System.Drawing.Size(101, 34)
        Me.sbEditar.Text = "Modificar"
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
        '
        'ToolStripButton2
        '
        Me.ToolStripButton2.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ToolStripButton2.Image = Global.SGC_CS.My.Resources.Resources.menu_cancel
        Me.ToolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton2.Margin = New System.Windows.Forms.Padding(1, 1, 1, 2)
        Me.ToolStripButton2.Name = "ToolStripButton2"
        Me.ToolStripButton2.Size = New System.Drawing.Size(95, 34)
        Me.ToolStripButton2.Text = "Cancelar"
        '
        'SgcGroupBox1
        '
        Me.SgcGroupBox1.Controls.Add(Me.SgcNumericUpDown1)
        Me.SgcGroupBox1.Controls.Add(Me.chkAforo)
        Me.SgcGroupBox1.Controls.Add(Me.SgcLabel4)
        Me.SgcGroupBox1.Controls.Add(Me.SgcTextBox1)
        Me.SgcGroupBox1.Controls.Add(Me.SgcComboBox2)
        Me.SgcGroupBox1.Controls.Add(Me.SgcComboBox1)
        Me.SgcGroupBox1.Controls.Add(Me.SgcLabel3)
        Me.SgcGroupBox1.Controls.Add(Me.SgcLabel2)
        Me.SgcGroupBox1.Controls.Add(Me.SgcLabel1)
        Me.SgcGroupBox1.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SgcGroupBox1.Location = New System.Drawing.Point(60, 127)
        Me.SgcGroupBox1.Name = "SgcGroupBox1"
        Me.SgcGroupBox1.Size = New System.Drawing.Size(596, 204)
        Me.SgcGroupBox1.TabIndex = 17
        Me.SgcGroupBox1.TabStop = False
        Me.SgcGroupBox1.Text = "Espacio"
        '
        'SgcLabel1
        '
        Me.SgcLabel1.AutoSize = True
        Me.SgcLabel1.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SgcLabel1.ForeColor = System.Drawing.Color.SteelBlue
        Me.SgcLabel1.Location = New System.Drawing.Point(139, 37)
        Me.SgcLabel1.Name = "SgcLabel1"
        Me.SgcLabel1.Size = New System.Drawing.Size(43, 18)
        Me.SgcLabel1.TabIndex = 0
        Me.SgcLabel1.Text = "Sede:"
        '
        'SgcLabel2
        '
        Me.SgcLabel2.AutoSize = True
        Me.SgcLabel2.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SgcLabel2.ForeColor = System.Drawing.Color.SteelBlue
        Me.SgcLabel2.Location = New System.Drawing.Point(139, 70)
        Me.SgcLabel2.Name = "SgcLabel2"
        Me.SgcLabel2.Size = New System.Drawing.Size(45, 18)
        Me.SgcLabel2.TabIndex = 1
        Me.SgcLabel2.Text = "Lugar:"
        '
        'SgcLabel3
        '
        Me.SgcLabel3.AutoSize = True
        Me.SgcLabel3.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SgcLabel3.ForeColor = System.Drawing.Color.SteelBlue
        Me.SgcLabel3.Location = New System.Drawing.Point(139, 107)
        Me.SgcLabel3.Name = "SgcLabel3"
        Me.SgcLabel3.Size = New System.Drawing.Size(58, 18)
        Me.SgcLabel3.TabIndex = 2
        Me.SgcLabel3.Text = "Espacio:"
        '
        'SgcComboBox1
        '
        Me.SgcComboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.SgcComboBox1.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SgcComboBox1.ForeColor = System.Drawing.Color.Black
        Me.SgcComboBox1.FormattingEnabled = True
        Me.SgcComboBox1.Location = New System.Drawing.Point(205, 34)
        Me.SgcComboBox1.Name = "SgcComboBox1"
        Me.SgcComboBox1.Size = New System.Drawing.Size(121, 26)
        Me.SgcComboBox1.TabIndex = 3
        '
        'SgcComboBox2
        '
        Me.SgcComboBox2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.SgcComboBox2.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SgcComboBox2.ForeColor = System.Drawing.Color.Black
        Me.SgcComboBox2.FormattingEnabled = True
        Me.SgcComboBox2.Location = New System.Drawing.Point(205, 67)
        Me.SgcComboBox2.Name = "SgcComboBox2"
        Me.SgcComboBox2.Size = New System.Drawing.Size(121, 26)
        Me.SgcComboBox2.TabIndex = 4
        '
        'SgcTextBox1
        '
        Me.SgcTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.SgcTextBox1.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SgcTextBox1.ForeColor = System.Drawing.Color.Black
        Me.SgcTextBox1.Location = New System.Drawing.Point(205, 105)
        Me.SgcTextBox1.Name = "SgcTextBox1"
        Me.SgcTextBox1.Size = New System.Drawing.Size(121, 26)
        Me.SgcTextBox1.TabIndex = 5
        '
        'SgcLabel4
        '
        Me.SgcLabel4.AutoSize = True
        Me.SgcLabel4.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SgcLabel4.ForeColor = System.Drawing.Color.SteelBlue
        Me.SgcLabel4.Location = New System.Drawing.Point(139, 149)
        Me.SgcLabel4.Name = "SgcLabel4"
        Me.SgcLabel4.Size = New System.Drawing.Size(47, 18)
        Me.SgcLabel4.TabIndex = 6
        Me.SgcLabel4.Text = "Aforo:"
        '
        'chkAforo
        '
        Me.chkAforo.AutoSize = True
        Me.chkAforo.BackColor = System.Drawing.Color.White
        Me.chkAforo.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkAforo.ForeColor = System.Drawing.Color.Black
        Me.chkAforo.Location = New System.Drawing.Point(205, 152)
        Me.chkAforo.Name = "chkAforo"
        Me.chkAforo.Size = New System.Drawing.Size(15, 14)
        Me.chkAforo.TabIndex = 7
        Me.chkAforo.UseVisualStyleBackColor = True
        '
        'SgcNumericUpDown1
        '
        Me.SgcNumericUpDown1.Location = New System.Drawing.Point(227, 147)
        Me.SgcNumericUpDown1.Name = "SgcNumericUpDown1"
        Me.SgcNumericUpDown1.Size = New System.Drawing.Size(99, 26)
        Me.SgcNumericUpDown1.TabIndex = 8
        '
        'frmRegistroEspacio
        '
        Me.ClientSize = New System.Drawing.Size(1016, 738)
        Me.Controls.Add(Me.SgcGroupBox1)
        Me.Controls.Add(Me.tsMenu)
        Me.Controls.Add(Me.lblTitulo)
        Me.Name = "frmRegistroEspacio"
        Me.Controls.SetChildIndex(Me.lblTitulo, 0)
        Me.Controls.SetChildIndex(Me.tsMenu, 0)
        Me.Controls.SetChildIndex(Me.SgcGroupBox1, 0)
        Me.tsMenu.ResumeLayout(False)
        Me.tsMenu.PerformLayout()
        Me.SgcGroupBox1.ResumeLayout(False)
        Me.SgcGroupBox1.PerformLayout()
        CType(Me.SgcNumericUpDown1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblTitulo As SGC_CS.SGCLabel
    Friend WithEvents tsMenu As SGC_CS.SGCToolStrip
    Friend WithEvents sbLimpiar As System.Windows.Forms.ToolStripButton
    Friend WithEvents sbGuardar As System.Windows.Forms.ToolStripButton
    Friend WithEvents sbEditar As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton2 As System.Windows.Forms.ToolStripButton
    Friend WithEvents SgcGroupBox1 As SGC_CS.SGCGroupBox
    Friend WithEvents SgcNumericUpDown1 As SGC_CS.SGCNumericUpDown
    Friend WithEvents chkAforo As SGC_CS.SGCCheckBox
    Friend WithEvents SgcLabel4 As SGC_CS.SGCLabel
    Friend WithEvents SgcTextBox1 As SGC_CS.SGCTextBox
    Friend WithEvents SgcComboBox2 As SGC_CS.SGCComboBox
    Friend WithEvents SgcComboBox1 As SGC_CS.SGCComboBox
    Friend WithEvents SgcLabel3 As SGC_CS.SGCLabel
    Friend WithEvents SgcLabel2 As SGC_CS.SGCLabel
    Friend WithEvents SgcLabel1 As SGC_CS.SGCLabel

End Class
