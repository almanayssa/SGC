<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBuscarActividad
    Inherits SGC_CS.frmPopup

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
        Me.gbxFiltros = New SGC_CS.SGCGroupBox(Me.components)
        Me.txtNombre = New SGC_CS.SGCTextBox(Me.components)
        Me.btnBuscar = New SGC_CS.SGCButton(Me.components)
        Me.lblNombre = New SGC_CS.SGCLabel(Me.components)
        Me.lblComite = New SGC_CS.SGCLabel(Me.components)
        Me.cboComite = New SGC_CS.SGCComboBox(Me.components)
        Me.dgvListado = New SGC_CS.SGCDataGridView(Me.components)
        Me.colComite = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colNombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colFechaInicio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colHoraInicio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colFechaFin = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colHoraFin = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.gbxFiltros.SuspendLayout()
        CType(Me.dgvListado, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gbxFiltros
        '
        Me.gbxFiltros.Controls.Add(Me.txtNombre)
        Me.gbxFiltros.Controls.Add(Me.btnBuscar)
        Me.gbxFiltros.Controls.Add(Me.lblNombre)
        Me.gbxFiltros.Controls.Add(Me.lblComite)
        Me.gbxFiltros.Controls.Add(Me.cboComite)
        Me.gbxFiltros.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbxFiltros.Location = New System.Drawing.Point(12, 12)
        Me.gbxFiltros.Name = "gbxFiltros"
        Me.gbxFiltros.Size = New System.Drawing.Size(645, 131)
        Me.gbxFiltros.TabIndex = 19
        Me.gbxFiltros.TabStop = False
        Me.gbxFiltros.Text = "Filtros"
        '
        'txtNombre
        '
        Me.txtNombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNombre.Enabled = False
        Me.txtNombre.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombre.ForeColor = System.Drawing.Color.Black
        Me.txtNombre.Location = New System.Drawing.Point(153, 58)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(121, 26)
        Me.txtNombre.TabIndex = 23
        '
        'btnBuscar
        '
        Me.btnBuscar.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnBuscar.FlatAppearance.BorderColor = System.Drawing.Color.Silver
        Me.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBuscar.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBuscar.ForeColor = System.Drawing.Color.SteelBlue
        Me.btnBuscar.Location = New System.Drawing.Point(153, 90)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(75, 31)
        Me.btnBuscar.TabIndex = 20
        Me.btnBuscar.Text = "Buscar"
        Me.btnBuscar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnBuscar.UseVisualStyleBackColor = False
        '
        'lblNombre
        '
        Me.lblNombre.AutoSize = True
        Me.lblNombre.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombre.ForeColor = System.Drawing.Color.SteelBlue
        Me.lblNombre.Location = New System.Drawing.Point(20, 66)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(63, 18)
        Me.lblNombre.TabIndex = 11
        Me.lblNombre.Text = "Nombre:"
        '
        'lblComite
        '
        Me.lblComite.AutoSize = True
        Me.lblComite.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblComite.ForeColor = System.Drawing.Color.SteelBlue
        Me.lblComite.Location = New System.Drawing.Point(20, 36)
        Me.lblComite.Name = "lblComite"
        Me.lblComite.Size = New System.Drawing.Size(57, 18)
        Me.lblComite.TabIndex = 6
        Me.lblComite.Text = "Comité:"
        '
        'cboComite
        '
        Me.cboComite.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboComite.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cboComite.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboComite.ForeColor = System.Drawing.Color.Black
        Me.cboComite.FormattingEnabled = True
        Me.cboComite.Location = New System.Drawing.Point(153, 28)
        Me.cboComite.Name = "cboComite"
        Me.cboComite.Size = New System.Drawing.Size(121, 26)
        Me.cboComite.TabIndex = 8
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
        Me.dgvListado.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colComite, Me.colNombre, Me.colFechaInicio, Me.colHoraInicio, Me.colFechaFin, Me.colHoraFin})
        Me.dgvListado.Location = New System.Drawing.Point(12, 149)
        Me.dgvListado.Name = "dgvListado"
        Me.dgvListado.Size = New System.Drawing.Size(645, 270)
        Me.dgvListado.TabIndex = 22
        '
        'colComite
        '
        Me.colComite.HeaderText = "Comité"
        Me.colComite.Name = "colComite"
        '
        'colNombre
        '
        Me.colNombre.HeaderText = "Descripción"
        Me.colNombre.Name = "colNombre"
        '
        'colFechaInicio
        '
        Me.colFechaInicio.HeaderText = "F. Inicio"
        Me.colFechaInicio.Name = "colFechaInicio"
        '
        'colHoraInicio
        '
        Me.colHoraInicio.HeaderText = "H. Inicio"
        Me.colHoraInicio.Name = "colHoraInicio"
        '
        'colFechaFin
        '
        Me.colFechaFin.HeaderText = "F. Fin"
        Me.colFechaFin.Name = "colFechaFin"
        '
        'colHoraFin
        '
        Me.colHoraFin.HeaderText = "H. Fin"
        Me.colHoraFin.Name = "colHoraFin"
        '
        'frmBuscarActividad
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 18.0!)
        Me.ClientSize = New System.Drawing.Size(666, 430)
        Me.Controls.Add(Me.dgvListado)
        Me.Controls.Add(Me.gbxFiltros)
        Me.Name = "frmBuscarActividad"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Buscar Actividad"
        Me.gbxFiltros.ResumeLayout(False)
        Me.gbxFiltros.PerformLayout()
        CType(Me.dgvListado, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents gbxFiltros As SGC_CS.SGCGroupBox
    Friend WithEvents lblComite As SGC_CS.SGCLabel
    Friend WithEvents cboComite As SGC_CS.SGCComboBox
    Friend WithEvents lblNombre As SGC_CS.SGCLabel
    Friend WithEvents btnBuscar As SGC_CS.SGCButton
    Friend WithEvents dgvListado As SGC_CS.SGCDataGridView
    Friend WithEvents txtNombre As SGC_CS.SGCTextBox
    Friend WithEvents colComite As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colNombre As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colFechaInicio As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colHoraInicio As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colFechaFin As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colHoraFin As System.Windows.Forms.DataGridViewTextBoxColumn

End Class
