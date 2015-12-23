<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRegistroIncidencias
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmRegistroIncidencias))
        Me.SgcGroupBox3 = New SGC_CS.SGCGroupBox(Me.components)
        Me.txtIncidencias = New SGC_CS.SGCTextBox(Me.components)
        Me.SgcGroupBox4 = New SGC_CS.SGCGroupBox(Me.components)
        Me.dgvProgramacion = New SGC_CS.SGCDataGridView(Me.components)
        Me.lblTitulo = New SGC_CS.SGCLabel(Me.components)
        Me.SgcLabel1 = New SGC_CS.SGCLabel(Me.components)
        Me.txtCodigo = New SGC_CS.SGCTextBox(Me.components)
        Me.SgcLabel11 = New SGC_CS.SGCLabel(Me.components)
        Me.txtActividad = New SGC_CS.SGCTextBox(Me.components)
        Me.btnBuscar = New SGC_CS.SGCButton(Me.components)
        Me.SgcGroupBox1 = New SGC_CS.SGCGroupBox(Me.components)
        Me.tsMenu = New SGC_CS.SGCToolStrip(Me.components)
        Me.tsbLimpiar = New System.Windows.Forms.ToolStripButton()
        Me.tsbGuardar = New System.Windows.Forms.ToolStripButton()
        Me.SgcLabel3 = New SGC_CS.SGCLabel(Me.components)
        Me.colSede = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colEspacio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colFecInicio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colHoraInicio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colFecFin = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colHoraFin = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SgcGroupBox3.SuspendLayout()
        Me.SgcGroupBox4.SuspendLayout()
        CType(Me.dgvProgramacion, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SgcGroupBox1.SuspendLayout()
        Me.tsMenu.SuspendLayout()
        Me.SuspendLayout()
        '
        'SgcGroupBox3
        '
        Me.SgcGroupBox3.Controls.Add(Me.txtIncidencias)
        Me.SgcGroupBox3.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SgcGroupBox3.Location = New System.Drawing.Point(60, 321)
        Me.SgcGroupBox3.Name = "SgcGroupBox3"
        Me.SgcGroupBox3.Size = New System.Drawing.Size(883, 249)
        Me.SgcGroupBox3.TabIndex = 33
        Me.SgcGroupBox3.TabStop = False
        Me.SgcGroupBox3.Text = "Incidencias"
        '
        'txtIncidencias
        '
        Me.txtIncidencias.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtIncidencias.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIncidencias.ForeColor = System.Drawing.Color.Black
        Me.txtIncidencias.Location = New System.Drawing.Point(22, 34)
        Me.txtIncidencias.Multiline = True
        Me.txtIncidencias.Name = "txtIncidencias"
        Me.txtIncidencias.Size = New System.Drawing.Size(842, 197)
        Me.txtIncidencias.TabIndex = 18
        '
        'SgcGroupBox4
        '
        Me.SgcGroupBox4.Controls.Add(Me.dgvProgramacion)
        Me.SgcGroupBox4.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SgcGroupBox4.Location = New System.Drawing.Point(582, 106)
        Me.SgcGroupBox4.Name = "SgcGroupBox4"
        Me.SgcGroupBox4.Size = New System.Drawing.Size(361, 203)
        Me.SgcGroupBox4.TabIndex = 34
        Me.SgcGroupBox4.TabStop = False
        Me.SgcGroupBox4.Text = "Programación"
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
        Me.dgvProgramacion.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colSede, Me.colEspacio, Me.colFecInicio, Me.colHoraInicio, Me.colFecFin, Me.colHoraFin})
        Me.dgvProgramacion.Location = New System.Drawing.Point(21, 19)
        Me.dgvProgramacion.Name = "dgvProgramacion"
        Me.dgvProgramacion.ReadOnly = True
        Me.dgvProgramacion.Size = New System.Drawing.Size(320, 177)
        Me.dgvProgramacion.TabIndex = 2
        '
        'lblTitulo
        '
        Me.lblTitulo.AutoSize = True
        Me.lblTitulo.BackColor = System.Drawing.Color.ForestGreen
        Me.lblTitulo.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitulo.ForeColor = System.Drawing.Color.White
        Me.lblTitulo.Location = New System.Drawing.Point(428, 11)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(185, 23)
        Me.lblTitulo.TabIndex = 35
        Me.lblTitulo.Text = "Registro de Incidencia"
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
        'SgcLabel11
        '
        Me.SgcLabel11.AutoSize = True
        Me.SgcLabel11.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SgcLabel11.ForeColor = System.Drawing.Color.SteelBlue
        Me.SgcLabel11.Location = New System.Drawing.Point(19, 76)
        Me.SgcLabel11.Name = "SgcLabel11"
        Me.SgcLabel11.Size = New System.Drawing.Size(70, 18)
        Me.SgcLabel11.TabIndex = 16
        Me.SgcLabel11.Text = "Actividad:"
        '
        'txtActividad
        '
        Me.txtActividad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtActividad.Enabled = False
        Me.txtActividad.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtActividad.ForeColor = System.Drawing.Color.Black
        Me.txtActividad.Location = New System.Drawing.Point(109, 76)
        Me.txtActividad.Multiline = True
        Me.txtActividad.Name = "txtActividad"
        Me.txtActividad.Size = New System.Drawing.Size(384, 127)
        Me.txtActividad.TabIndex = 17
        '
        'btnBuscar
        '
        Me.btnBuscar.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnBuscar.FlatAppearance.BorderColor = System.Drawing.Color.Silver
        Me.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBuscar.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBuscar.ForeColor = System.Drawing.Color.SteelBlue
        Me.btnBuscar.Image = CType(resources.GetObject("btnBuscar.Image"), System.Drawing.Image)
        Me.btnBuscar.Location = New System.Drawing.Point(215, 33)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(45, 31)
        Me.btnBuscar.TabIndex = 25
        Me.btnBuscar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnBuscar.UseVisualStyleBackColor = False
        '
        'SgcGroupBox1
        '
        Me.SgcGroupBox1.Controls.Add(Me.btnBuscar)
        Me.SgcGroupBox1.Controls.Add(Me.txtActividad)
        Me.SgcGroupBox1.Controls.Add(Me.SgcLabel11)
        Me.SgcGroupBox1.Controls.Add(Me.txtCodigo)
        Me.SgcGroupBox1.Controls.Add(Me.SgcLabel1)
        Me.SgcGroupBox1.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SgcGroupBox1.Location = New System.Drawing.Point(60, 106)
        Me.SgcGroupBox1.Name = "SgcGroupBox1"
        Me.SgcGroupBox1.Size = New System.Drawing.Size(513, 209)
        Me.SgcGroupBox1.TabIndex = 31
        Me.SgcGroupBox1.TabStop = False
        Me.SgcGroupBox1.Text = "Actividad"
        '
        'tsMenu
        '
        Me.tsMenu.BackColor = System.Drawing.Color.Silver
        Me.tsMenu.Dock = System.Windows.Forms.DockStyle.None
        Me.tsMenu.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tsMenu.ImageScalingSize = New System.Drawing.Size(30, 30)
        Me.tsMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsbLimpiar, Me.tsbGuardar})
        Me.tsMenu.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow
        Me.tsMenu.Location = New System.Drawing.Point(60, 65)
        Me.tsMenu.Name = "tsMenu"
        Me.tsMenu.Size = New System.Drawing.Size(91, 37)
        Me.tsMenu.TabIndex = 36
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
        Me.tsbGuardar.Visible = False
        '
        'SgcLabel3
        '
        Me.SgcLabel3.AutoSize = True
        Me.SgcLabel3.BackColor = System.Drawing.Color.ForestGreen
        Me.SgcLabel3.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SgcLabel3.ForeColor = System.Drawing.Color.White
        Me.SgcLabel3.Location = New System.Drawing.Point(428, 11)
        Me.SgcLabel3.Name = "SgcLabel3"
        Me.SgcLabel3.Size = New System.Drawing.Size(185, 23)
        Me.SgcLabel3.TabIndex = 37
        Me.SgcLabel3.Text = "Registro de Incidencia" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
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
        'frmRegistroIncidencias
        '
        Me.ClientSize = New System.Drawing.Size(1016, 733)
        Me.Controls.Add(Me.SgcLabel3)
        Me.Controls.Add(Me.tsMenu)
        Me.Controls.Add(Me.lblTitulo)
        Me.Controls.Add(Me.SgcGroupBox4)
        Me.Controls.Add(Me.SgcGroupBox3)
        Me.Controls.Add(Me.SgcGroupBox1)
        Me.Name = "frmRegistroIncidencias"
        Me.Controls.SetChildIndex(Me.SgcGroupBox1, 0)
        Me.Controls.SetChildIndex(Me.SgcGroupBox3, 0)
        Me.Controls.SetChildIndex(Me.SgcGroupBox4, 0)
        Me.Controls.SetChildIndex(Me.lblTitulo, 0)
        Me.Controls.SetChildIndex(Me.tsMenu, 0)
        Me.Controls.SetChildIndex(Me.SgcLabel3, 0)
        Me.SgcGroupBox3.ResumeLayout(False)
        Me.SgcGroupBox3.PerformLayout()
        Me.SgcGroupBox4.ResumeLayout(False)
        CType(Me.dgvProgramacion, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SgcGroupBox1.ResumeLayout(False)
        Me.SgcGroupBox1.PerformLayout()
        Me.tsMenu.ResumeLayout(False)
        Me.tsMenu.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents SgcGroupBox3 As SGC_CS.SGCGroupBox
    Friend WithEvents txtIncidencias As SGC_CS.SGCTextBox
    Friend WithEvents SgcGroupBox4 As SGC_CS.SGCGroupBox
    Friend WithEvents lblTitulo As SGC_CS.SGCLabel
    Friend WithEvents SgcLabel1 As SGC_CS.SGCLabel
    Friend WithEvents txtCodigo As SGC_CS.SGCTextBox
    Friend WithEvents SgcLabel11 As SGC_CS.SGCLabel
    Friend WithEvents txtActividad As SGC_CS.SGCTextBox
    Friend WithEvents btnBuscar As SGC_CS.SGCButton
    Friend WithEvents SgcGroupBox1 As SGC_CS.SGCGroupBox
    Friend WithEvents tsMenu As SGC_CS.SGCToolStrip
    Friend WithEvents tsbLimpiar As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsbGuardar As System.Windows.Forms.ToolStripButton
    Friend WithEvents SgcLabel3 As SGC_CS.SGCLabel
    Friend WithEvents dgvProgramacion As SGC_CS.SGCDataGridView
    Friend WithEvents colSede As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colEspacio As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colFecInicio As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colHoraInicio As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colFecFin As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colHoraFin As System.Windows.Forms.DataGridViewTextBoxColumn

End Class
