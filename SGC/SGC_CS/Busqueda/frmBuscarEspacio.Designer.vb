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
        Me.btnBuscar = New SGC_CS.SGCButton(Me.components)
        Me.lblLugar = New SGC_CS.SGCLabel(Me.components)
        Me.cboLugar = New SGC_CS.SGCComboBox(Me.components)
        Me.dtpFecha = New SGC_CS.SGCDateTimePicker(Me.components)
        Me.lblFecha = New SGC_CS.SGCLabel(Me.components)
        Me.dgvListado = New SGC_CS.SGCDataGridView(Me.components)
        Me.gbxFiltros.SuspendLayout()
        CType(Me.dgvListado, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gbxFiltros
        '
        Me.gbxFiltros.Controls.Add(Me.lblFecha)
        Me.gbxFiltros.Controls.Add(Me.dtpFecha)
        Me.gbxFiltros.Controls.Add(Me.btnBuscar)
        Me.gbxFiltros.Controls.Add(Me.lblLugar)
        Me.gbxFiltros.Controls.Add(Me.cboLugar)
        Me.gbxFiltros.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbxFiltros.Location = New System.Drawing.Point(12, 12)
        Me.gbxFiltros.Name = "gbxFiltros"
        Me.gbxFiltros.Size = New System.Drawing.Size(374, 139)
        Me.gbxFiltros.TabIndex = 19
        Me.gbxFiltros.TabStop = False
        Me.gbxFiltros.Text = "Filtros"
        '
        'btnBuscar
        '
        Me.btnBuscar.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnBuscar.FlatAppearance.BorderColor = System.Drawing.Color.Silver
        Me.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBuscar.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBuscar.ForeColor = System.Drawing.Color.SteelBlue
        Me.btnBuscar.Location = New System.Drawing.Point(132, 92)
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
        Me.lblLugar.Location = New System.Drawing.Point(20, 31)
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
        Me.cboLugar.Location = New System.Drawing.Point(132, 28)
        Me.cboLugar.Name = "cboLugar"
        Me.cboLugar.Size = New System.Drawing.Size(121, 26)
        Me.cboLugar.TabIndex = 8
        '
        'dtpFecha
        '
        Me.dtpFecha.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFecha.Location = New System.Drawing.Point(132, 60)
        Me.dtpFecha.Name = "dtpFecha"
        Me.dtpFecha.Size = New System.Drawing.Size(100, 26)
        Me.dtpFecha.TabIndex = 12
        '
        'lblFecha
        '
        Me.lblFecha.AutoSize = True
        Me.lblFecha.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFecha.ForeColor = System.Drawing.Color.SteelBlue
        Me.lblFecha.Location = New System.Drawing.Point(20, 66)
        Me.lblFecha.Name = "lblFecha"
        Me.lblFecha.Size = New System.Drawing.Size(48, 18)
        Me.lblFecha.TabIndex = 13
        Me.lblFecha.Text = "Fecha:"
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
        Me.dgvListado.Location = New System.Drawing.Point(12, 157)
        Me.dgvListado.Name = "dgvListado"
        Me.dgvListado.Size = New System.Drawing.Size(374, 191)
        Me.dgvListado.TabIndex = 20
        '
        'frmBuscarEspacio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 18.0!)
        Me.ClientSize = New System.Drawing.Size(425, 358)
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
    Friend WithEvents lblFecha As SGC_CS.SGCLabel
    Friend WithEvents dtpFecha As SGC_CS.SGCDateTimePicker
    Friend WithEvents btnBuscar As SGC_CS.SGCButton
    Friend WithEvents lblLugar As SGC_CS.SGCLabel
    Friend WithEvents cboLugar As SGC_CS.SGCComboBox
    Friend WithEvents dgvListado As SGC_CS.SGCDataGridView

End Class
