<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBuscarEspacio
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
        Me.lblSede = New SGC_CS.SGCLabel(Me.components)
        Me.cboSede = New SGC_CS.SGCComboBox(Me.components)
        Me.btnBuscar = New SGC_CS.SGCButton(Me.components)
        Me.lblLugar = New SGC_CS.SGCLabel(Me.components)
        Me.cboLugar = New SGC_CS.SGCComboBox(Me.components)
        Me.dgvListado = New SGC_CS.SGCDataGridView(Me.components)
        Me.colNombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.gbxFiltros.SuspendLayout()
        CType(Me.dgvListado, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gbxFiltros
        '
        Me.gbxFiltros.Controls.Add(Me.lblSede)
        Me.gbxFiltros.Controls.Add(Me.cboSede)
        Me.gbxFiltros.Controls.Add(Me.btnBuscar)
        Me.gbxFiltros.Controls.Add(Me.lblLugar)
        Me.gbxFiltros.Controls.Add(Me.cboLugar)
        Me.gbxFiltros.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbxFiltros.Location = New System.Drawing.Point(12, 12)
        Me.gbxFiltros.Name = "gbxFiltros"
        Me.gbxFiltros.Size = New System.Drawing.Size(373, 124)
        Me.gbxFiltros.TabIndex = 19
        Me.gbxFiltros.TabStop = False
        Me.gbxFiltros.Text = "Filtros"
        '
        'lblSede
        '
        Me.lblSede.AutoSize = True
        Me.lblSede.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSede.ForeColor = System.Drawing.Color.SteelBlue
        Me.lblSede.Location = New System.Drawing.Point(23, 23)
        Me.lblSede.Name = "lblSede"
        Me.lblSede.Size = New System.Drawing.Size(43, 18)
        Me.lblSede.TabIndex = 16
        Me.lblSede.Text = "Sede:"
        '
        'cboSede
        '
        Me.cboSede.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboSede.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cboSede.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboSede.ForeColor = System.Drawing.Color.Black
        Me.cboSede.FormattingEnabled = True
        Me.cboSede.Location = New System.Drawing.Point(132, 20)
        Me.cboSede.Name = "cboSede"
        Me.cboSede.Size = New System.Drawing.Size(121, 26)
        Me.cboSede.TabIndex = 17
        '
        'btnBuscar
        '
        Me.btnBuscar.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnBuscar.FlatAppearance.BorderColor = System.Drawing.Color.Silver
        Me.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBuscar.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBuscar.ForeColor = System.Drawing.Color.SteelBlue
        Me.btnBuscar.Location = New System.Drawing.Point(132, 84)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(75, 31)
        Me.btnBuscar.TabIndex = 11
        Me.btnBuscar.Text = "Buscar"
        Me.btnBuscar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnBuscar.UseVisualStyleBackColor = False
        '
        'lblLugar
        '
        Me.lblLugar.AutoSize = True
        Me.lblLugar.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLugar.ForeColor = System.Drawing.Color.SteelBlue
        Me.lblLugar.Location = New System.Drawing.Point(23, 55)
        Me.lblLugar.Name = "lblLugar"
        Me.lblLugar.Size = New System.Drawing.Size(45, 18)
        Me.lblLugar.TabIndex = 6
        Me.lblLugar.Text = "Lugar:"
        '
        'cboLugar
        '
        Me.cboLugar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboLugar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cboLugar.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboLugar.ForeColor = System.Drawing.Color.Black
        Me.cboLugar.FormattingEnabled = True
        Me.cboLugar.Location = New System.Drawing.Point(132, 52)
        Me.cboLugar.Name = "cboLugar"
        Me.cboLugar.Size = New System.Drawing.Size(121, 26)
        Me.cboLugar.TabIndex = 8
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
        Me.dgvListado.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colNombre})
        Me.dgvListado.Location = New System.Drawing.Point(12, 142)
        Me.dgvListado.Name = "dgvListado"
        Me.dgvListado.ReadOnly = True
        Me.dgvListado.Size = New System.Drawing.Size(373, 186)
        Me.dgvListado.TabIndex = 20
        '
        'colNombre
        '
        Me.colNombre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.colNombre.HeaderText = "Nombre"
        Me.colNombre.Name = "colNombre"
        Me.colNombre.ReadOnly = True
        '
        'frmBuscarEspacio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 18.0!)
        Me.ClientSize = New System.Drawing.Size(399, 339)
        Me.Controls.Add(Me.dgvListado)
        Me.Controls.Add(Me.gbxFiltros)
        Me.Name = "frmBuscarEspacio"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Buscar Espacio"
        Me.gbxFiltros.ResumeLayout(False)
        Me.gbxFiltros.PerformLayout()
        CType(Me.dgvListado, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents gbxFiltros As SGC_CS.SGCGroupBox
    Friend WithEvents lblLugar As SGC_CS.SGCLabel
    Friend WithEvents cboLugar As SGC_CS.SGCComboBox
    Friend WithEvents dgvListado As SGC_CS.SGCDataGridView
    Friend WithEvents lblSede As SGC_CS.SGCLabel
    Friend WithEvents cboSede As SGC_CS.SGCComboBox
    Friend WithEvents btnBuscar As SGC_CS.SGCButton
    Friend WithEvents colNombre As System.Windows.Forms.DataGridViewTextBoxColumn

End Class
