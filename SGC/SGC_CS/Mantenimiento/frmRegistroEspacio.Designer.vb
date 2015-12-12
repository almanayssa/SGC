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
        Me.tsbLimpiar = New System.Windows.Forms.ToolStripButton()
        Me.tsbGuardar = New System.Windows.Forms.ToolStripButton()
        Me.tsbEditar = New System.Windows.Forms.ToolStripButton()
        Me.tsbEliminar = New System.Windows.Forms.ToolStripButton()
        Me.tsbCancelar = New System.Windows.Forms.ToolStripButton()
        Me.SgcGroupBox1 = New SGC_CS.SGCGroupBox(Me.components)
        Me.nudAforo = New SGC_CS.SGCNumericUpDown(Me.components)
        Me.chkAforo = New SGC_CS.SGCCheckBox(Me.components)
        Me.SgcLabel4 = New SGC_CS.SGCLabel(Me.components)
        Me.txtEspacio = New SGC_CS.SGCTextBox(Me.components)
        Me.cboLugar = New SGC_CS.SGCComboBox(Me.components)
        Me.cboSede = New SGC_CS.SGCComboBox(Me.components)
        Me.SgcLabel3 = New SGC_CS.SGCLabel(Me.components)
        Me.SgcLabel2 = New SGC_CS.SGCLabel(Me.components)
        Me.SgcLabel1 = New SGC_CS.SGCLabel(Me.components)
        Me.tsMenu.SuspendLayout()
        Me.SgcGroupBox1.SuspendLayout()
        CType(Me.nudAforo, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.tsMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsbLimpiar, Me.tsbGuardar, Me.tsbEditar, Me.tsbEliminar, Me.tsbCancelar})
        Me.tsMenu.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow
        Me.tsMenu.Location = New System.Drawing.Point(60, 71)
        Me.tsMenu.Name = "tsMenu"
        Me.tsMenu.Size = New System.Drawing.Size(457, 37)
        Me.tsMenu.TabIndex = 16
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
        '
        'SgcGroupBox1
        '
        Me.SgcGroupBox1.Controls.Add(Me.nudAforo)
        Me.SgcGroupBox1.Controls.Add(Me.chkAforo)
        Me.SgcGroupBox1.Controls.Add(Me.SgcLabel4)
        Me.SgcGroupBox1.Controls.Add(Me.txtEspacio)
        Me.SgcGroupBox1.Controls.Add(Me.cboLugar)
        Me.SgcGroupBox1.Controls.Add(Me.cboSede)
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
        'nudAforo
        '
        Me.nudAforo.Location = New System.Drawing.Point(227, 147)
        Me.nudAforo.Name = "nudAforo"
        Me.nudAforo.Size = New System.Drawing.Size(99, 26)
        Me.nudAforo.TabIndex = 8
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
        'txtEspacio
        '
        Me.txtEspacio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtEspacio.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEspacio.ForeColor = System.Drawing.Color.Black
        Me.txtEspacio.Location = New System.Drawing.Point(205, 105)
        Me.txtEspacio.Name = "txtEspacio"
        Me.txtEspacio.Size = New System.Drawing.Size(121, 26)
        Me.txtEspacio.TabIndex = 5
        '
        'cboLugar
        '
        Me.cboLugar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboLugar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cboLugar.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboLugar.ForeColor = System.Drawing.Color.Black
        Me.cboLugar.FormattingEnabled = True
        Me.cboLugar.Location = New System.Drawing.Point(205, 67)
        Me.cboLugar.Name = "cboLugar"
        Me.cboLugar.Size = New System.Drawing.Size(121, 26)
        Me.cboLugar.TabIndex = 4
        '
        'cboSede
        '
        Me.cboSede.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboSede.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cboSede.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboSede.ForeColor = System.Drawing.Color.Black
        Me.cboSede.FormattingEnabled = True
        Me.cboSede.Location = New System.Drawing.Point(205, 34)
        Me.cboSede.Name = "cboSede"
        Me.cboSede.Size = New System.Drawing.Size(121, 26)
        Me.cboSede.TabIndex = 3
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
        'frmRegistroEspacio
        '
        Me.ClientSize = New System.Drawing.Size(1016, 733)
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
        CType(Me.nudAforo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblTitulo As SGC_CS.SGCLabel
    Friend WithEvents tsMenu As SGC_CS.SGCToolStrip
    Friend WithEvents tsbLimpiar As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsbGuardar As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsbEditar As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsbEliminar As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsbCancelar As System.Windows.Forms.ToolStripButton
    Friend WithEvents SgcGroupBox1 As SGC_CS.SGCGroupBox
    Friend WithEvents nudAforo As SGC_CS.SGCNumericUpDown
    Friend WithEvents chkAforo As SGC_CS.SGCCheckBox
    Friend WithEvents SgcLabel4 As SGC_CS.SGCLabel
    Friend WithEvents txtEspacio As SGC_CS.SGCTextBox
    Friend WithEvents cboLugar As SGC_CS.SGCComboBox
    Friend WithEvents cboSede As SGC_CS.SGCComboBox
    Friend WithEvents SgcLabel3 As SGC_CS.SGCLabel
    Friend WithEvents SgcLabel2 As SGC_CS.SGCLabel
    Friend WithEvents SgcLabel1 As SGC_CS.SGCLabel

End Class
