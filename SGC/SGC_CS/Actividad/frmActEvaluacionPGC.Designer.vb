<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmActEvaluacionPGC
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
        Me.SgcGroupBox2 = New SGC_CS.SGCGroupBox(Me.components)
        Me.SgcTabControl1 = New SGC_CS.SGCTabControl(Me.components)
        Me.tpRegistradas = New System.Windows.Forms.TabPage()
        Me.dgvRegistradas = New SGC_CS.SGCDataGridView(Me.components)
        Me.creSeleccionar = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.creNombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.creTipo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.creCategoria = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.creFecInicio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.creFecFin = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.crePago = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.creVacantes = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.creEstado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnEnviarCD = New SGC_CS.SGCButton(Me.components)
        Me.btnEnviarGG = New SGC_CS.SGCButton(Me.components)
        Me.tpAprobadas = New System.Windows.Forms.TabPage()
        Me.dgvAprobadas = New SGC_CS.SGCDataGridView(Me.components)
        Me.capSeleccionar = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.capNombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.capTipo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.capCategoria = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.capFecInicio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.capFecFin = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.capPago = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.capVacantes = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.capEstado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnAprobar = New SGC_CS.SGCButton(Me.components)
        Me.tpRechazadas = New System.Windows.Forms.TabPage()
        Me.dgvRechazadas = New SGC_CS.SGCDataGridView(Me.components)
        Me.crcSeleccionar = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.crcNombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.crcTipo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.crcCategoria = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.crcFecInicio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.crcFecFin = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.crcPago = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.crcVacantes = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.crcEstado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnRechazar = New SGC_CS.SGCButton(Me.components)
        Me.SgcGroupBox1 = New SGC_CS.SGCGroupBox(Me.components)
        Me.btnBuscar = New SGC_CS.SGCButton(Me.components)
        Me.cboComite = New SGC_CS.SGCComboBox(Me.components)
        Me.SgcLabel1 = New SGC_CS.SGCLabel(Me.components)
        Me.lblTitulo = New SGC_CS.SGCLabel(Me.components)
        Me.SgcGroupBox2.SuspendLayout()
        Me.SgcTabControl1.SuspendLayout()
        Me.tpRegistradas.SuspendLayout()
        CType(Me.dgvRegistradas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tpAprobadas.SuspendLayout()
        CType(Me.dgvAprobadas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tpRechazadas.SuspendLayout()
        CType(Me.dgvRechazadas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SgcGroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'SgcGroupBox2
        '
        Me.SgcGroupBox2.Controls.Add(Me.SgcTabControl1)
        Me.SgcGroupBox2.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SgcGroupBox2.Location = New System.Drawing.Point(60, 137)
        Me.SgcGroupBox2.Name = "SgcGroupBox2"
        Me.SgcGroupBox2.Size = New System.Drawing.Size(900, 403)
        Me.SgcGroupBox2.TabIndex = 18
        Me.SgcGroupBox2.TabStop = False
        Me.SgcGroupBox2.Text = "Listado"
        '
        'SgcTabControl1
        '
        Me.SgcTabControl1.Controls.Add(Me.tpRegistradas)
        Me.SgcTabControl1.Controls.Add(Me.tpAprobadas)
        Me.SgcTabControl1.Controls.Add(Me.tpRechazadas)
        Me.SgcTabControl1.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SgcTabControl1.Location = New System.Drawing.Point(13, 25)
        Me.SgcTabControl1.Name = "SgcTabControl1"
        Me.SgcTabControl1.SelectedIndex = 0
        Me.SgcTabControl1.Size = New System.Drawing.Size(881, 372)
        Me.SgcTabControl1.TabIndex = 0
        '
        'tpRegistradas
        '
        Me.tpRegistradas.Controls.Add(Me.dgvRegistradas)
        Me.tpRegistradas.Controls.Add(Me.btnEnviarCD)
        Me.tpRegistradas.Controls.Add(Me.btnEnviarGG)
        Me.tpRegistradas.Location = New System.Drawing.Point(4, 27)
        Me.tpRegistradas.Name = "tpRegistradas"
        Me.tpRegistradas.Size = New System.Drawing.Size(873, 341)
        Me.tpRegistradas.TabIndex = 3
        Me.tpRegistradas.Text = "Registradas"
        Me.tpRegistradas.UseVisualStyleBackColor = True
        '
        'dgvRegistradas
        '
        Me.dgvRegistradas.AllowUserToAddRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.WhiteSmoke
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.SteelBlue
        Me.dgvRegistradas.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvRegistradas.BackgroundColor = System.Drawing.Color.WhiteSmoke
        Me.dgvRegistradas.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dgvRegistradas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvRegistradas.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.creSeleccionar, Me.creNombre, Me.creTipo, Me.creCategoria, Me.creFecInicio, Me.creFecFin, Me.crePago, Me.creVacantes, Me.creEstado})
        Me.dgvRegistradas.Location = New System.Drawing.Point(0, -1)
        Me.dgvRegistradas.Name = "dgvRegistradas"
        Me.dgvRegistradas.Size = New System.Drawing.Size(873, 296)
        Me.dgvRegistradas.TabIndex = 7
        '
        'creSeleccionar
        '
        Me.creSeleccionar.HeaderText = ""
        Me.creSeleccionar.Name = "creSeleccionar"
        Me.creSeleccionar.Width = 30
        '
        'creNombre
        '
        Me.creNombre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.creNombre.HeaderText = "Nombre"
        Me.creNombre.Name = "creNombre"
        '
        'creTipo
        '
        Me.creTipo.HeaderText = "Tipo"
        Me.creTipo.Name = "creTipo"
        '
        'creCategoria
        '
        Me.creCategoria.HeaderText = "Categoría"
        Me.creCategoria.Name = "creCategoria"
        '
        'creFecInicio
        '
        Me.creFecInicio.HeaderText = "Fec. Inicio"
        Me.creFecInicio.Name = "creFecInicio"
        '
        'creFecFin
        '
        Me.creFecFin.HeaderText = "Fec. Fin"
        Me.creFecFin.Name = "creFecFin"
        '
        'crePago
        '
        Me.crePago.HeaderText = "Pago"
        Me.crePago.Name = "crePago"
        '
        'creVacantes
        '
        Me.creVacantes.HeaderText = "Vacantes"
        Me.creVacantes.Name = "creVacantes"
        '
        'creEstado
        '
        Me.creEstado.HeaderText = "Estado"
        Me.creEstado.Name = "creEstado"
        '
        'btnEnviarCD
        '
        Me.btnEnviarCD.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnEnviarCD.FlatAppearance.BorderColor = System.Drawing.Color.Silver
        Me.btnEnviarCD.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEnviarCD.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEnviarCD.ForeColor = System.Drawing.Color.SteelBlue
        Me.btnEnviarCD.Location = New System.Drawing.Point(750, 301)
        Me.btnEnviarCD.Name = "btnEnviarCD"
        Me.btnEnviarCD.Size = New System.Drawing.Size(120, 31)
        Me.btnEnviarCD.TabIndex = 6
        Me.btnEnviarCD.Text = "Enviar a CD"
        Me.btnEnviarCD.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnEnviarCD.UseVisualStyleBackColor = False
        '
        'btnEnviarGG
        '
        Me.btnEnviarGG.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnEnviarGG.FlatAppearance.BorderColor = System.Drawing.Color.Silver
        Me.btnEnviarGG.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEnviarGG.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEnviarGG.ForeColor = System.Drawing.Color.SteelBlue
        Me.btnEnviarGG.Location = New System.Drawing.Point(624, 301)
        Me.btnEnviarGG.Name = "btnEnviarGG"
        Me.btnEnviarGG.Size = New System.Drawing.Size(120, 31)
        Me.btnEnviarGG.TabIndex = 5
        Me.btnEnviarGG.Text = "Enviar a GG"
        Me.btnEnviarGG.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnEnviarGG.UseVisualStyleBackColor = False
        '
        'tpAprobadas
        '
        Me.tpAprobadas.Controls.Add(Me.dgvAprobadas)
        Me.tpAprobadas.Controls.Add(Me.btnAprobar)
        Me.tpAprobadas.Location = New System.Drawing.Point(4, 27)
        Me.tpAprobadas.Name = "tpAprobadas"
        Me.tpAprobadas.Padding = New System.Windows.Forms.Padding(3)
        Me.tpAprobadas.Size = New System.Drawing.Size(873, 341)
        Me.tpAprobadas.TabIndex = 1
        Me.tpAprobadas.Text = "Aprobadas"
        Me.tpAprobadas.UseVisualStyleBackColor = True
        '
        'dgvAprobadas
        '
        Me.dgvAprobadas.AllowUserToAddRows = False
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.WhiteSmoke
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.SteelBlue
        Me.dgvAprobadas.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvAprobadas.BackgroundColor = System.Drawing.Color.WhiteSmoke
        Me.dgvAprobadas.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dgvAprobadas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvAprobadas.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.capSeleccionar, Me.capNombre, Me.capTipo, Me.capCategoria, Me.capFecInicio, Me.capFecFin, Me.capPago, Me.capVacantes, Me.capEstado})
        Me.dgvAprobadas.Location = New System.Drawing.Point(0, -1)
        Me.dgvAprobadas.Name = "dgvAprobadas"
        Me.dgvAprobadas.Size = New System.Drawing.Size(873, 299)
        Me.dgvAprobadas.TabIndex = 8
        '
        'capSeleccionar
        '
        Me.capSeleccionar.HeaderText = ""
        Me.capSeleccionar.Name = "capSeleccionar"
        Me.capSeleccionar.Width = 30
        '
        'capNombre
        '
        Me.capNombre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.capNombre.HeaderText = "Nombre"
        Me.capNombre.Name = "capNombre"
        '
        'capTipo
        '
        Me.capTipo.HeaderText = "Tipo"
        Me.capTipo.Name = "capTipo"
        '
        'capCategoria
        '
        Me.capCategoria.HeaderText = "Categoría"
        Me.capCategoria.Name = "capCategoria"
        '
        'capFecInicio
        '
        Me.capFecInicio.HeaderText = "Fec. Inicio"
        Me.capFecInicio.Name = "capFecInicio"
        '
        'capFecFin
        '
        Me.capFecFin.HeaderText = "Fec. Fin"
        Me.capFecFin.Name = "capFecFin"
        '
        'capPago
        '
        Me.capPago.HeaderText = "Pago"
        Me.capPago.Name = "capPago"
        '
        'capVacantes
        '
        Me.capVacantes.HeaderText = "Vacantes"
        Me.capVacantes.Name = "capVacantes"
        '
        'capEstado
        '
        Me.capEstado.HeaderText = "Estado"
        Me.capEstado.Name = "capEstado"
        '
        'btnAprobar
        '
        Me.btnAprobar.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnAprobar.FlatAppearance.BorderColor = System.Drawing.Color.Silver
        Me.btnAprobar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAprobar.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAprobar.ForeColor = System.Drawing.Color.SteelBlue
        Me.btnAprobar.Location = New System.Drawing.Point(747, 304)
        Me.btnAprobar.Name = "btnAprobar"
        Me.btnAprobar.Size = New System.Drawing.Size(120, 31)
        Me.btnAprobar.TabIndex = 6
        Me.btnAprobar.Text = "Aprobar"
        Me.btnAprobar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnAprobar.UseVisualStyleBackColor = False
        '
        'tpRechazadas
        '
        Me.tpRechazadas.Controls.Add(Me.dgvRechazadas)
        Me.tpRechazadas.Controls.Add(Me.btnRechazar)
        Me.tpRechazadas.Location = New System.Drawing.Point(4, 27)
        Me.tpRechazadas.Name = "tpRechazadas"
        Me.tpRechazadas.Size = New System.Drawing.Size(873, 341)
        Me.tpRechazadas.TabIndex = 2
        Me.tpRechazadas.Text = "Rechazadas"
        Me.tpRechazadas.UseVisualStyleBackColor = True
        '
        'dgvRechazadas
        '
        Me.dgvRechazadas.AllowUserToAddRows = False
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.WhiteSmoke
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.SteelBlue
        Me.dgvRechazadas.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle3
        Me.dgvRechazadas.BackgroundColor = System.Drawing.Color.WhiteSmoke
        Me.dgvRechazadas.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dgvRechazadas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvRechazadas.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.crcSeleccionar, Me.crcNombre, Me.crcTipo, Me.crcCategoria, Me.crcFecInicio, Me.crcFecFin, Me.crcPago, Me.crcVacantes, Me.crcEstado})
        Me.dgvRechazadas.Location = New System.Drawing.Point(0, -1)
        Me.dgvRechazadas.Name = "dgvRechazadas"
        Me.dgvRechazadas.Size = New System.Drawing.Size(873, 296)
        Me.dgvRechazadas.TabIndex = 8
        '
        'crcSeleccionar
        '
        Me.crcSeleccionar.HeaderText = ""
        Me.crcSeleccionar.Name = "crcSeleccionar"
        Me.crcSeleccionar.Width = 30
        '
        'crcNombre
        '
        Me.crcNombre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.crcNombre.HeaderText = "Nombre"
        Me.crcNombre.Name = "crcNombre"
        '
        'crcTipo
        '
        Me.crcTipo.HeaderText = "Tipo"
        Me.crcTipo.Name = "crcTipo"
        '
        'crcCategoria
        '
        Me.crcCategoria.HeaderText = "Categoría"
        Me.crcCategoria.Name = "crcCategoria"
        '
        'crcFecInicio
        '
        Me.crcFecInicio.HeaderText = "Fec. Inicio"
        Me.crcFecInicio.Name = "crcFecInicio"
        '
        'crcFecFin
        '
        Me.crcFecFin.HeaderText = "Fec. Fin"
        Me.crcFecFin.Name = "crcFecFin"
        '
        'crcPago
        '
        Me.crcPago.HeaderText = "Pago"
        Me.crcPago.Name = "crcPago"
        '
        'crcVacantes
        '
        Me.crcVacantes.HeaderText = "Vacantes"
        Me.crcVacantes.Name = "crcVacantes"
        '
        'crcEstado
        '
        Me.crcEstado.HeaderText = "Estado"
        Me.crcEstado.Name = "crcEstado"
        '
        'btnRechazar
        '
        Me.btnRechazar.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnRechazar.FlatAppearance.BorderColor = System.Drawing.Color.Silver
        Me.btnRechazar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRechazar.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRechazar.ForeColor = System.Drawing.Color.SteelBlue
        Me.btnRechazar.Location = New System.Drawing.Point(750, 301)
        Me.btnRechazar.Name = "btnRechazar"
        Me.btnRechazar.Size = New System.Drawing.Size(120, 31)
        Me.btnRechazar.TabIndex = 7
        Me.btnRechazar.Text = "Rechazar"
        Me.btnRechazar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnRechazar.UseVisualStyleBackColor = False
        '
        'SgcGroupBox1
        '
        Me.SgcGroupBox1.Controls.Add(Me.btnBuscar)
        Me.SgcGroupBox1.Controls.Add(Me.cboComite)
        Me.SgcGroupBox1.Controls.Add(Me.SgcLabel1)
        Me.SgcGroupBox1.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SgcGroupBox1.Location = New System.Drawing.Point(60, 52)
        Me.SgcGroupBox1.Name = "SgcGroupBox1"
        Me.SgcGroupBox1.Size = New System.Drawing.Size(900, 79)
        Me.SgcGroupBox1.TabIndex = 17
        Me.SgcGroupBox1.TabStop = False
        Me.SgcGroupBox1.Text = "Filtros"
        '
        'btnBuscar
        '
        Me.btnBuscar.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnBuscar.FlatAppearance.BorderColor = System.Drawing.Color.Silver
        Me.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBuscar.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBuscar.ForeColor = System.Drawing.Color.SteelBlue
        Me.btnBuscar.Location = New System.Drawing.Point(722, 27)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(120, 31)
        Me.btnBuscar.TabIndex = 4
        Me.btnBuscar.Text = "Buscar"
        Me.btnBuscar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnBuscar.UseVisualStyleBackColor = False
        '
        'cboComite
        '
        Me.cboComite.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboComite.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cboComite.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboComite.ForeColor = System.Drawing.Color.Black
        Me.cboComite.FormattingEnabled = True
        Me.cboComite.Location = New System.Drawing.Point(99, 30)
        Me.cboComite.Name = "cboComite"
        Me.cboComite.Size = New System.Drawing.Size(121, 26)
        Me.cboComite.TabIndex = 1
        '
        'SgcLabel1
        '
        Me.SgcLabel1.AutoSize = True
        Me.SgcLabel1.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SgcLabel1.ForeColor = System.Drawing.Color.SteelBlue
        Me.SgcLabel1.Location = New System.Drawing.Point(19, 34)
        Me.SgcLabel1.Name = "SgcLabel1"
        Me.SgcLabel1.Size = New System.Drawing.Size(57, 18)
        Me.SgcLabel1.TabIndex = 0
        Me.SgcLabel1.Text = "Comite:"
        '
        'lblTitulo
        '
        Me.lblTitulo.AutoSize = True
        Me.lblTitulo.BackColor = System.Drawing.Color.ForestGreen
        Me.lblTitulo.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitulo.ForeColor = System.Drawing.Color.White
        Me.lblTitulo.Location = New System.Drawing.Point(392, 9)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(230, 23)
        Me.lblTitulo.TabIndex = 19
        Me.lblTitulo.Text = "Seguimiento de Actividades"
        '
        'frmActEvaluacionPGC
        '
        Me.ClientSize = New System.Drawing.Size(1016, 733)
        Me.Controls.Add(Me.lblTitulo)
        Me.Controls.Add(Me.SgcGroupBox2)
        Me.Controls.Add(Me.SgcGroupBox1)
        Me.Name = "frmActEvaluacionPGC"
        Me.Controls.SetChildIndex(Me.SgcGroupBox1, 0)
        Me.Controls.SetChildIndex(Me.SgcGroupBox2, 0)
        Me.Controls.SetChildIndex(Me.lblTitulo, 0)
        Me.SgcGroupBox2.ResumeLayout(False)
        Me.SgcTabControl1.ResumeLayout(False)
        Me.tpRegistradas.ResumeLayout(False)
        CType(Me.dgvRegistradas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tpAprobadas.ResumeLayout(False)
        CType(Me.dgvAprobadas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tpRechazadas.ResumeLayout(False)
        CType(Me.dgvRechazadas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SgcGroupBox1.ResumeLayout(False)
        Me.SgcGroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents SgcGroupBox2 As SGC_CS.SGCGroupBox
    Friend WithEvents SgcGroupBox1 As SGC_CS.SGCGroupBox
    Friend WithEvents btnBuscar As SGC_CS.SGCButton
    Friend WithEvents cboComite As SGC_CS.SGCComboBox
    Friend WithEvents SgcLabel1 As SGC_CS.SGCLabel
    Friend WithEvents SgcTabControl1 As SGC_CS.SGCTabControl
    Friend WithEvents tpRegistradas As System.Windows.Forms.TabPage
    Friend WithEvents tpAprobadas As System.Windows.Forms.TabPage
    Friend WithEvents tpRechazadas As System.Windows.Forms.TabPage
    Friend WithEvents btnEnviarCD As SGC_CS.SGCButton
    Friend WithEvents btnEnviarGG As SGC_CS.SGCButton
    Friend WithEvents btnAprobar As SGC_CS.SGCButton
    Friend WithEvents btnRechazar As SGC_CS.SGCButton
    Friend WithEvents lblTitulo As SGC_CS.SGCLabel
    Friend WithEvents dgvRegistradas As SGC_CS.SGCDataGridView
    Friend WithEvents dgvAprobadas As SGC_CS.SGCDataGridView
    Friend WithEvents dgvRechazadas As SGC_CS.SGCDataGridView
    Friend WithEvents creSeleccionar As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents creNombre As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents creTipo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents creCategoria As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents creFecInicio As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents creFecFin As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents crePago As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents creVacantes As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents creEstado As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents capSeleccionar As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents capNombre As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents capTipo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents capCategoria As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents capFecInicio As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents capFecFin As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents capPago As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents capVacantes As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents capEstado As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents crcSeleccionar As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents crcNombre As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents crcTipo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents crcCategoria As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents crcFecInicio As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents crcFecFin As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents crcPago As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents crcVacantes As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents crcEstado As System.Windows.Forms.DataGridViewTextBoxColumn

End Class
