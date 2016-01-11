<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmActEvaluacionGG
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
        Me.SgcGroupBox2 = New SGC_CS.SGCGroupBox(Me.components)
        Me.dgvListado = New SGC_CS.SGCDataGridView(Me.components)
        Me.btnRechazar = New SGC_CS.SGCButton(Me.components)
        Me.btnAprobar = New SGC_CS.SGCButton(Me.components)
        Me.SgcGroupBox1 = New SGC_CS.SGCGroupBox(Me.components)
        Me.btnBuscar = New SGC_CS.SGCButton(Me.components)
        Me.cboComite = New SGC_CS.SGCComboBox(Me.components)
        Me.SgcLabel1 = New SGC_CS.SGCLabel(Me.components)
        Me.lblTitulo = New SGC_CS.SGCLabel(Me.components)
        Me.colSeleccionar = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.colNombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colTipo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colCategoria = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colFecInicio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colFecFin = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colPago = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colVacantes = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colEstado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SgcGroupBox2.SuspendLayout()
        CType(Me.dgvListado, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SgcGroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'SgcGroupBox2
        '
        Me.SgcGroupBox2.Controls.Add(Me.dgvListado)
        Me.SgcGroupBox2.Controls.Add(Me.btnRechazar)
        Me.SgcGroupBox2.Controls.Add(Me.btnAprobar)
        Me.SgcGroupBox2.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SgcGroupBox2.Location = New System.Drawing.Point(60, 140)
        Me.SgcGroupBox2.Name = "SgcGroupBox2"
        Me.SgcGroupBox2.Size = New System.Drawing.Size(900, 366)
        Me.SgcGroupBox2.TabIndex = 18
        Me.SgcGroupBox2.TabStop = False
        Me.SgcGroupBox2.Text = "Listado"
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
        Me.dgvListado.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colSeleccionar, Me.colNombre, Me.colTipo, Me.colCategoria, Me.colFecInicio, Me.colFecFin, Me.colPago, Me.colVacantes, Me.colEstado})
        Me.dgvListado.Location = New System.Drawing.Point(13, 25)
        Me.dgvListado.Name = "dgvListado"
        Me.dgvListado.Size = New System.Drawing.Size(874, 298)
        Me.dgvListado.TabIndex = 8
        '
        'btnRechazar
        '
        Me.btnRechazar.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnRechazar.FlatAppearance.BorderColor = System.Drawing.Color.Silver
        Me.btnRechazar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRechazar.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRechazar.ForeColor = System.Drawing.Color.SteelBlue
        Me.btnRechazar.Location = New System.Drawing.Point(766, 329)
        Me.btnRechazar.Name = "btnRechazar"
        Me.btnRechazar.Size = New System.Drawing.Size(120, 31)
        Me.btnRechazar.TabIndex = 6
        Me.btnRechazar.Text = "Rechazar"
        Me.btnRechazar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnRechazar.UseVisualStyleBackColor = False
        '
        'btnAprobar
        '
        Me.btnAprobar.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnAprobar.FlatAppearance.BorderColor = System.Drawing.Color.Silver
        Me.btnAprobar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAprobar.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAprobar.ForeColor = System.Drawing.Color.SteelBlue
        Me.btnAprobar.Location = New System.Drawing.Point(640, 329)
        Me.btnAprobar.Name = "btnAprobar"
        Me.btnAprobar.Size = New System.Drawing.Size(120, 31)
        Me.btnAprobar.TabIndex = 5
        Me.btnAprobar.Text = "Aprobar"
        Me.btnAprobar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnAprobar.UseVisualStyleBackColor = False
        '
        'SgcGroupBox1
        '
        Me.SgcGroupBox1.Controls.Add(Me.btnBuscar)
        Me.SgcGroupBox1.Controls.Add(Me.cboComite)
        Me.SgcGroupBox1.Controls.Add(Me.SgcLabel1)
        Me.SgcGroupBox1.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SgcGroupBox1.Location = New System.Drawing.Point(60, 55)
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
        Me.lblTitulo.Location = New System.Drawing.Point(363, 9)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(324, 23)
        Me.lblTitulo.TabIndex = 20
        Me.lblTitulo.Text = "Evaluación Actividad - Gerencia General"
        '
        'colSeleccionar
        '
        Me.colSeleccionar.HeaderText = ""
        Me.colSeleccionar.Name = "colSeleccionar"
        Me.colSeleccionar.Width = 30
        '
        'colNombre
        '
        Me.colNombre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.colNombre.HeaderText = "Nombre"
        Me.colNombre.Name = "colNombre"
        '
        'colTipo
        '
        Me.colTipo.HeaderText = "Tipo"
        Me.colTipo.Name = "colTipo"
        '
        'colCategoria
        '
        Me.colCategoria.HeaderText = "Categoría"
        Me.colCategoria.Name = "colCategoria"
        '
        'colFecInicio
        '
        Me.colFecInicio.HeaderText = "Fecha"
        Me.colFecInicio.Name = "colFecInicio"
        '
        'colFecFin
        '
        Me.colFecFin.HeaderText = "Fec. Fin"
        Me.colFecFin.Name = "colFecFin"
        Me.colFecFin.Visible = False
        '
        'colPago
        '
        Me.colPago.HeaderText = "Pago"
        Me.colPago.Name = "colPago"
        '
        'colVacantes
        '
        Me.colVacantes.HeaderText = "Vacantes"
        Me.colVacantes.Name = "colVacantes"
        '
        'colEstado
        '
        Me.colEstado.HeaderText = "Estado"
        Me.colEstado.Name = "colEstado"
        '
        'frmActEvaluacionGG
        '
        Me.ClientSize = New System.Drawing.Size(1016, 733)
        Me.Controls.Add(Me.lblTitulo)
        Me.Controls.Add(Me.SgcGroupBox2)
        Me.Controls.Add(Me.SgcGroupBox1)
        Me.Name = "frmActEvaluacionGG"
        Me.Controls.SetChildIndex(Me.SgcGroupBox1, 0)
        Me.Controls.SetChildIndex(Me.SgcGroupBox2, 0)
        Me.Controls.SetChildIndex(Me.lblTitulo, 0)
        Me.SgcGroupBox2.ResumeLayout(False)
        CType(Me.dgvListado, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents lblTitulo As SGC_CS.SGCLabel
    Friend WithEvents btnRechazar As SGC_CS.SGCButton
    Friend WithEvents btnAprobar As SGC_CS.SGCButton
    Friend WithEvents dgvListado As SGC_CS.SGCDataGridView
    Friend WithEvents colSeleccionar As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents colNombre As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colTipo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colCategoria As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colFecInicio As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colFecFin As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colPago As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colVacantes As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colEstado As System.Windows.Forms.DataGridViewTextBoxColumn

End Class
