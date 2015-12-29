<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPresupuestoActividad
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPresupuestoActividad))
        Me.lblTitulo = New SGC_CS.SGCLabel(Me.components)
        Me.SgcGroupBox1 = New SGC_CS.SGCGroupBox(Me.components)
        Me.lblEstado = New SGC_CS.SGCLabel(Me.components)
        Me.SgcLabel8 = New SGC_CS.SGCLabel(Me.components)
        Me.lblFecFin = New SGC_CS.SGCLabel(Me.components)
        Me.lblFecIni = New SGC_CS.SGCLabel(Me.components)
        Me.lblTipo = New SGC_CS.SGCLabel(Me.components)
        Me.lblComite = New SGC_CS.SGCLabel(Me.components)
        Me.lblNombre = New SGC_CS.SGCLabel(Me.components)
        Me.btnBuscar = New SGC_CS.SGCButton(Me.components)
        Me.SgcLabel5 = New SGC_CS.SGCLabel(Me.components)
        Me.SgcLabel4 = New SGC_CS.SGCLabel(Me.components)
        Me.SgcLabel3 = New SGC_CS.SGCLabel(Me.components)
        Me.SgcLabel2 = New SGC_CS.SGCLabel(Me.components)
        Me.SgcLabel1 = New SGC_CS.SGCLabel(Me.components)
        Me.gbItems = New SGC_CS.SGCGroupBox(Me.components)
        Me.pbPresupuesto = New System.Windows.Forms.PictureBox()
        Me.btnPersonal = New SGC_CS.SGCButton(Me.components)
        Me.btnQuitar = New SGC_CS.SGCButton(Me.components)
        Me.txtMontoTotal = New SGC_CS.SGCTextBox(Me.components)
        Me.SgcLabel6 = New SGC_CS.SGCLabel(Me.components)
        Me.btnAgregar = New SGC_CS.SGCButton(Me.components)
        Me.dgvListado = New SGC_CS.SGCDataGridView(Me.components)
        Me.tsMenu = New SGC_CS.SGCToolStrip(Me.components)
        Me.sbLimpiar = New System.Windows.Forms.ToolStripButton()
        Me.sbGuardar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton3 = New System.Windows.Forms.ToolStripButton()
        Me.SugerenciasToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.SgcGroupBox1.SuspendLayout()
        Me.gbItems.SuspendLayout()
        CType(Me.pbPresupuesto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvListado, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tsMenu.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblTitulo
        '
        Me.lblTitulo.AutoSize = True
        Me.lblTitulo.BackColor = System.Drawing.Color.ForestGreen
        Me.lblTitulo.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitulo.ForeColor = System.Drawing.Color.White
        Me.lblTitulo.Location = New System.Drawing.Point(396, 11)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(212, 23)
        Me.lblTitulo.TabIndex = 12
        Me.lblTitulo.Text = "Presupuesto de Actividad"
        '
        'SgcGroupBox1
        '
        Me.SgcGroupBox1.Controls.Add(Me.lblEstado)
        Me.SgcGroupBox1.Controls.Add(Me.SgcLabel8)
        Me.SgcGroupBox1.Controls.Add(Me.lblFecFin)
        Me.SgcGroupBox1.Controls.Add(Me.lblFecIni)
        Me.SgcGroupBox1.Controls.Add(Me.lblTipo)
        Me.SgcGroupBox1.Controls.Add(Me.lblComite)
        Me.SgcGroupBox1.Controls.Add(Me.lblNombre)
        Me.SgcGroupBox1.Controls.Add(Me.btnBuscar)
        Me.SgcGroupBox1.Controls.Add(Me.SgcLabel5)
        Me.SgcGroupBox1.Controls.Add(Me.SgcLabel4)
        Me.SgcGroupBox1.Controls.Add(Me.SgcLabel3)
        Me.SgcGroupBox1.Controls.Add(Me.SgcLabel2)
        Me.SgcGroupBox1.Controls.Add(Me.SgcLabel1)
        Me.SgcGroupBox1.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SgcGroupBox1.Location = New System.Drawing.Point(60, 122)
        Me.SgcGroupBox1.Name = "SgcGroupBox1"
        Me.SgcGroupBox1.Size = New System.Drawing.Size(900, 153)
        Me.SgcGroupBox1.TabIndex = 14
        Me.SgcGroupBox1.TabStop = False
        Me.SgcGroupBox1.Text = "Actividad"
        '
        'lblEstado
        '
        Me.lblEstado.AutoSize = True
        Me.lblEstado.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEstado.ForeColor = System.Drawing.Color.Black
        Me.lblEstado.Location = New System.Drawing.Point(528, 110)
        Me.lblEstado.Name = "lblEstado"
        Me.lblEstado.Size = New System.Drawing.Size(13, 18)
        Me.lblEstado.TabIndex = 32
        Me.lblEstado.Text = "-"
        '
        'SgcLabel8
        '
        Me.SgcLabel8.AutoSize = True
        Me.SgcLabel8.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SgcLabel8.ForeColor = System.Drawing.Color.SteelBlue
        Me.SgcLabel8.Location = New System.Drawing.Point(437, 110)
        Me.SgcLabel8.Name = "SgcLabel8"
        Me.SgcLabel8.Size = New System.Drawing.Size(53, 18)
        Me.SgcLabel8.TabIndex = 31
        Me.SgcLabel8.Text = "Estado:"
        '
        'lblFecFin
        '
        Me.lblFecFin.AutoSize = True
        Me.lblFecFin.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFecFin.ForeColor = System.Drawing.Color.Black
        Me.lblFecFin.Location = New System.Drawing.Point(528, 75)
        Me.lblFecFin.Name = "lblFecFin"
        Me.lblFecFin.Size = New System.Drawing.Size(13, 18)
        Me.lblFecFin.TabIndex = 30
        Me.lblFecFin.Text = "-"
        '
        'lblFecIni
        '
        Me.lblFecIni.AutoSize = True
        Me.lblFecIni.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFecIni.ForeColor = System.Drawing.Color.Black
        Me.lblFecIni.Location = New System.Drawing.Point(528, 40)
        Me.lblFecIni.Name = "lblFecIni"
        Me.lblFecIni.Size = New System.Drawing.Size(13, 18)
        Me.lblFecIni.TabIndex = 29
        Me.lblFecIni.Text = "-"
        '
        'lblTipo
        '
        Me.lblTipo.AutoSize = True
        Me.lblTipo.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTipo.ForeColor = System.Drawing.Color.Black
        Me.lblTipo.Location = New System.Drawing.Point(116, 110)
        Me.lblTipo.Name = "lblTipo"
        Me.lblTipo.Size = New System.Drawing.Size(13, 18)
        Me.lblTipo.TabIndex = 28
        Me.lblTipo.Text = "-"
        '
        'lblComite
        '
        Me.lblComite.AutoSize = True
        Me.lblComite.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblComite.ForeColor = System.Drawing.Color.Black
        Me.lblComite.Location = New System.Drawing.Point(116, 75)
        Me.lblComite.Name = "lblComite"
        Me.lblComite.Size = New System.Drawing.Size(13, 18)
        Me.lblComite.TabIndex = 27
        Me.lblComite.Text = "-"
        '
        'lblNombre
        '
        Me.lblNombre.AutoSize = True
        Me.lblNombre.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombre.ForeColor = System.Drawing.Color.Black
        Me.lblNombre.Location = New System.Drawing.Point(116, 40)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(13, 18)
        Me.lblNombre.TabIndex = 26
        Me.lblNombre.Text = "-"
        '
        'btnBuscar
        '
        Me.btnBuscar.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnBuscar.FlatAppearance.BorderColor = System.Drawing.Color.Silver
        Me.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBuscar.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBuscar.ForeColor = System.Drawing.Color.SteelBlue
        Me.btnBuscar.Image = Global.SGC_CS.My.Resources.Resources.btn_buscar
        Me.btnBuscar.Location = New System.Drawing.Point(305, 34)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(45, 31)
        Me.btnBuscar.TabIndex = 25
        Me.btnBuscar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnBuscar.UseVisualStyleBackColor = False
        '
        'SgcLabel5
        '
        Me.SgcLabel5.AutoSize = True
        Me.SgcLabel5.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SgcLabel5.ForeColor = System.Drawing.Color.SteelBlue
        Me.SgcLabel5.Location = New System.Drawing.Point(437, 75)
        Me.SgcLabel5.Name = "SgcLabel5"
        Me.SgcLabel5.Size = New System.Drawing.Size(70, 18)
        Me.SgcLabel5.TabIndex = 8
        Me.SgcLabel5.Text = "Fecha Fin:"
        '
        'SgcLabel4
        '
        Me.SgcLabel4.AutoSize = True
        Me.SgcLabel4.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SgcLabel4.ForeColor = System.Drawing.Color.SteelBlue
        Me.SgcLabel4.Location = New System.Drawing.Point(437, 40)
        Me.SgcLabel4.Name = "SgcLabel4"
        Me.SgcLabel4.Size = New System.Drawing.Size(85, 18)
        Me.SgcLabel4.TabIndex = 7
        Me.SgcLabel4.Text = "Fecha Inicio:"
        '
        'SgcLabel3
        '
        Me.SgcLabel3.AutoSize = True
        Me.SgcLabel3.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SgcLabel3.ForeColor = System.Drawing.Color.SteelBlue
        Me.SgcLabel3.Location = New System.Drawing.Point(32, 110)
        Me.SgcLabel3.Name = "SgcLabel3"
        Me.SgcLabel3.Size = New System.Drawing.Size(39, 18)
        Me.SgcLabel3.TabIndex = 5
        Me.SgcLabel3.Text = "Tipo:"
        '
        'SgcLabel2
        '
        Me.SgcLabel2.AutoSize = True
        Me.SgcLabel2.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SgcLabel2.ForeColor = System.Drawing.Color.SteelBlue
        Me.SgcLabel2.Location = New System.Drawing.Point(32, 75)
        Me.SgcLabel2.Name = "SgcLabel2"
        Me.SgcLabel2.Size = New System.Drawing.Size(57, 18)
        Me.SgcLabel2.TabIndex = 3
        Me.SgcLabel2.Text = "Comité:"
        '
        'SgcLabel1
        '
        Me.SgcLabel1.AutoSize = True
        Me.SgcLabel1.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SgcLabel1.ForeColor = System.Drawing.Color.SteelBlue
        Me.SgcLabel1.Location = New System.Drawing.Point(32, 40)
        Me.SgcLabel1.Name = "SgcLabel1"
        Me.SgcLabel1.Size = New System.Drawing.Size(63, 18)
        Me.SgcLabel1.TabIndex = 0
        Me.SgcLabel1.Text = "Nombre:"
        '
        'gbItems
        '
        Me.gbItems.Controls.Add(Me.pbPresupuesto)
        Me.gbItems.Controls.Add(Me.btnPersonal)
        Me.gbItems.Controls.Add(Me.btnQuitar)
        Me.gbItems.Controls.Add(Me.txtMontoTotal)
        Me.gbItems.Controls.Add(Me.SgcLabel6)
        Me.gbItems.Controls.Add(Me.btnAgregar)
        Me.gbItems.Controls.Add(Me.dgvListado)
        Me.gbItems.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbItems.Location = New System.Drawing.Point(60, 281)
        Me.gbItems.Name = "gbItems"
        Me.gbItems.Size = New System.Drawing.Size(900, 298)
        Me.gbItems.TabIndex = 15
        Me.gbItems.TabStop = False
        Me.gbItems.Text = "Items"
        '
        'pbPresupuesto
        '
        Me.pbPresupuesto.ErrorImage = Nothing
        Me.pbPresupuesto.Image = Global.SGC_CS.My.Resources.Resources.get_info
        Me.pbPresupuesto.Location = New System.Drawing.Point(365, 256)
        Me.pbPresupuesto.Name = "pbPresupuesto"
        Me.pbPresupuesto.Size = New System.Drawing.Size(22, 22)
        Me.pbPresupuesto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbPresupuesto.TabIndex = 28
        Me.pbPresupuesto.TabStop = False
        Me.pbPresupuesto.Visible = False
        '
        'btnPersonal
        '
        Me.btnPersonal.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnPersonal.FlatAppearance.BorderColor = System.Drawing.Color.Silver
        Me.btnPersonal.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPersonal.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPersonal.ForeColor = System.Drawing.Color.SteelBlue
        Me.btnPersonal.Location = New System.Drawing.Point(144, 252)
        Me.btnPersonal.Name = "btnPersonal"
        Me.btnPersonal.Size = New System.Drawing.Size(125, 31)
        Me.btnPersonal.TabIndex = 21
        Me.btnPersonal.Text = "Agregar Personal"
        Me.btnPersonal.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnPersonal.UseVisualStyleBackColor = False
        '
        'btnQuitar
        '
        Me.btnQuitar.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnQuitar.FlatAppearance.BorderColor = System.Drawing.Color.Silver
        Me.btnQuitar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnQuitar.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnQuitar.ForeColor = System.Drawing.Color.SteelBlue
        Me.btnQuitar.Location = New System.Drawing.Point(275, 252)
        Me.btnQuitar.Name = "btnQuitar"
        Me.btnQuitar.Size = New System.Drawing.Size(75, 31)
        Me.btnQuitar.TabIndex = 20
        Me.btnQuitar.Text = "Quitar"
        Me.btnQuitar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnQuitar.UseVisualStyleBackColor = False
        '
        'txtMontoTotal
        '
        Me.txtMontoTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtMontoTotal.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMontoTotal.ForeColor = System.Drawing.Color.Black
        Me.txtMontoTotal.Location = New System.Drawing.Point(717, 256)
        Me.txtMontoTotal.Name = "txtMontoTotal"
        Me.txtMontoTotal.Size = New System.Drawing.Size(161, 26)
        Me.txtMontoTotal.TabIndex = 19
        '
        'SgcLabel6
        '
        Me.SgcLabel6.AutoSize = True
        Me.SgcLabel6.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SgcLabel6.ForeColor = System.Drawing.Color.SteelBlue
        Me.SgcLabel6.Location = New System.Drawing.Point(612, 258)
        Me.SgcLabel6.Name = "SgcLabel6"
        Me.SgcLabel6.Size = New System.Drawing.Size(83, 18)
        Me.SgcLabel6.TabIndex = 19
        Me.SgcLabel6.Text = "Monto Total"
        '
        'btnAgregar
        '
        Me.btnAgregar.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnAgregar.FlatAppearance.BorderColor = System.Drawing.Color.Silver
        Me.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAgregar.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAgregar.ForeColor = System.Drawing.Color.SteelBlue
        Me.btnAgregar.Location = New System.Drawing.Point(13, 252)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(125, 31)
        Me.btnAgregar.TabIndex = 10
        Me.btnAgregar.Text = "Agregar Recursos"
        Me.btnAgregar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnAgregar.UseVisualStyleBackColor = False
        '
        'dgvListado
        '
        Me.dgvListado.AllowUserToAddRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.WhiteSmoke
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.SteelBlue
        Me.dgvListado.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvListado.BackgroundColor = System.Drawing.Color.WhiteSmoke
        Me.dgvListado.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dgvListado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvListado.Location = New System.Drawing.Point(13, 26)
        Me.dgvListado.Name = "dgvListado"
        Me.dgvListado.Size = New System.Drawing.Size(865, 220)
        Me.dgvListado.TabIndex = 0
        '
        'tsMenu
        '
        Me.tsMenu.BackColor = System.Drawing.Color.Silver
        Me.tsMenu.Dock = System.Windows.Forms.DockStyle.None
        Me.tsMenu.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tsMenu.ImageScalingSize = New System.Drawing.Size(30, 30)
        Me.tsMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.sbLimpiar, Me.sbGuardar, Me.ToolStripButton3})
        Me.tsMenu.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow
        Me.tsMenu.Location = New System.Drawing.Point(60, 70)
        Me.tsMenu.Name = "tsMenu"
        Me.tsMenu.Size = New System.Drawing.Size(91, 37)
        Me.tsMenu.TabIndex = 17
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
        Me.sbGuardar.Visible = False
        '
        'ToolStripButton3
        '
        Me.ToolStripButton3.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ToolStripButton3.Image = CType(resources.GetObject("ToolStripButton3.Image"), System.Drawing.Image)
        Me.ToolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton3.Margin = New System.Windows.Forms.Padding(1, 1, 1, 2)
        Me.ToolStripButton3.Name = "ToolStripButton3"
        Me.ToolStripButton3.Size = New System.Drawing.Size(105, 34)
        Me.ToolStripButton3.Text = "Impresión"
        Me.ToolStripButton3.Visible = False
        '
        'frmPresupuestoActividad
        '
        Me.ClientSize = New System.Drawing.Size(1016, 733)
        Me.Controls.Add(Me.tsMenu)
        Me.Controls.Add(Me.gbItems)
        Me.Controls.Add(Me.SgcGroupBox1)
        Me.Controls.Add(Me.lblTitulo)
        Me.Name = "frmPresupuestoActividad"
        Me.Controls.SetChildIndex(Me.lblTitulo, 0)
        Me.Controls.SetChildIndex(Me.SgcGroupBox1, 0)
        Me.Controls.SetChildIndex(Me.gbItems, 0)
        Me.Controls.SetChildIndex(Me.tsMenu, 0)
        Me.SgcGroupBox1.ResumeLayout(False)
        Me.SgcGroupBox1.PerformLayout()
        Me.gbItems.ResumeLayout(False)
        Me.gbItems.PerformLayout()
        CType(Me.pbPresupuesto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvListado, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tsMenu.ResumeLayout(False)
        Me.tsMenu.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblTitulo As SGC_CS.SGCLabel
    Friend WithEvents SgcGroupBox1 As SGC_CS.SGCGroupBox
    Friend WithEvents SgcLabel5 As SGC_CS.SGCLabel
    Friend WithEvents SgcLabel4 As SGC_CS.SGCLabel
    Friend WithEvents SgcLabel3 As SGC_CS.SGCLabel
    Friend WithEvents SgcLabel2 As SGC_CS.SGCLabel
    Friend WithEvents SgcLabel1 As SGC_CS.SGCLabel
    Friend WithEvents gbItems As SGC_CS.SGCGroupBox
    Friend WithEvents dgvListado As SGC_CS.SGCDataGridView
    Friend WithEvents tsMenu As SGC_CS.SGCToolStrip
    Friend WithEvents sbLimpiar As System.Windows.Forms.ToolStripButton
    Friend WithEvents sbGuardar As System.Windows.Forms.ToolStripButton
    Friend WithEvents txtMontoTotal As SGC_CS.SGCTextBox
    Friend WithEvents btnAgregar As SGC_CS.SGCButton
    Friend WithEvents SgcLabel6 As SGC_CS.SGCLabel
    Friend WithEvents ToolStripButton3 As System.Windows.Forms.ToolStripButton
    Friend WithEvents lblTipo As SGC_CS.SGCLabel
    Friend WithEvents lblComite As SGC_CS.SGCLabel
    Friend WithEvents lblNombre As SGC_CS.SGCLabel
    Friend WithEvents lblFecFin As SGC_CS.SGCLabel
    Friend WithEvents lblFecIni As SGC_CS.SGCLabel
    Friend WithEvents lblEstado As SGC_CS.SGCLabel
    Friend WithEvents SgcLabel8 As SGC_CS.SGCLabel
    Friend WithEvents btnBuscar As SGC_CS.SGCButton
    Friend WithEvents btnQuitar As SGC_CS.SGCButton
    Friend WithEvents btnPersonal As SGC_CS.SGCButton
    Friend WithEvents SugerenciasToolTip As System.Windows.Forms.ToolTip
    Friend WithEvents pbPresupuesto As System.Windows.Forms.PictureBox

End Class
