<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBuscarPersonal
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
        Me.lblNombre = New SGC_CS.SGCLabel(Me.components)
        Me.btnBuscar = New SGC_CS.SGCButton(Me.components)
        Me.lblTipoPersonal = New SGC_CS.SGCLabel(Me.components)
        Me.cboTipoPersonal = New SGC_CS.SGCComboBox(Me.components)
        Me.dgvListado = New SGC_CS.SGCDataGridView(Me.components)
        Me.gbxFiltros.SuspendLayout()
        CType(Me.dgvListado, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gbxFiltros
        '
        Me.gbxFiltros.Controls.Add(Me.txtNombre)
        Me.gbxFiltros.Controls.Add(Me.lblNombre)
        Me.gbxFiltros.Controls.Add(Me.btnBuscar)
        Me.gbxFiltros.Controls.Add(Me.lblTipoPersonal)
        Me.gbxFiltros.Controls.Add(Me.cboTipoPersonal)
        Me.gbxFiltros.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbxFiltros.Location = New System.Drawing.Point(12, 12)
        Me.gbxFiltros.Name = "gbxFiltros"
        Me.gbxFiltros.Size = New System.Drawing.Size(374, 139)
        Me.gbxFiltros.TabIndex = 20
        Me.gbxFiltros.TabStop = False
        Me.gbxFiltros.Text = "Filtros"
        '
        'txtNombre
        '
        Me.txtNombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNombre.Enabled = False
        Me.txtNombre.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombre.ForeColor = System.Drawing.Color.Black
        Me.txtNombre.Location = New System.Drawing.Point(132, 60)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(121, 26)
        Me.txtNombre.TabIndex = 25
        '
        'lblNombre
        '
        Me.lblNombre.AutoSize = True
        Me.lblNombre.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombre.ForeColor = System.Drawing.Color.SteelBlue
        Me.lblNombre.Location = New System.Drawing.Point(20, 64)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(63, 18)
        Me.lblNombre.TabIndex = 24
        Me.lblNombre.Text = "Nombre:"
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
        'lblTipoPersonal
        '
        Me.lblTipoPersonal.AutoSize = True
        Me.lblTipoPersonal.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTipoPersonal.ForeColor = System.Drawing.Color.SteelBlue
        Me.lblTipoPersonal.Location = New System.Drawing.Point(20, 31)
        Me.lblTipoPersonal.Name = "lblTipoPersonal"
        Me.lblTipoPersonal.Size = New System.Drawing.Size(96, 18)
        Me.lblTipoPersonal.TabIndex = 6
        Me.lblTipoPersonal.Text = "Tipo Personal:"
        '
        'cboTipoPersonal
        '
        Me.cboTipoPersonal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboTipoPersonal.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cboTipoPersonal.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboTipoPersonal.ForeColor = System.Drawing.Color.Black
        Me.cboTipoPersonal.FormattingEnabled = True
        Me.cboTipoPersonal.Location = New System.Drawing.Point(132, 28)
        Me.cboTipoPersonal.Name = "cboTipoPersonal"
        Me.cboTipoPersonal.Size = New System.Drawing.Size(121, 26)
        Me.cboTipoPersonal.TabIndex = 8
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
        Me.dgvListado.TabIndex = 21
        '
        'frmBuscarPersonal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 18.0!)
        Me.ClientSize = New System.Drawing.Size(399, 358)
        Me.Controls.Add(Me.dgvListado)
        Me.Controls.Add(Me.gbxFiltros)
        Me.Name = "frmBuscarPersonal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Buscar Personal"
        Me.gbxFiltros.ResumeLayout(False)
        Me.gbxFiltros.PerformLayout()
        CType(Me.dgvListado, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents gbxFiltros As SGC_CS.SGCGroupBox
    Friend WithEvents btnBuscar As SGC_CS.SGCButton
    Friend WithEvents lblTipoPersonal As SGC_CS.SGCLabel
    Friend WithEvents cboTipoPersonal As SGC_CS.SGCComboBox
    Friend WithEvents dgvListado As SGC_CS.SGCDataGridView
    Friend WithEvents txtNombre As SGC_CS.SGCTextBox
    Friend WithEvents lblNombre As SGC_CS.SGCLabel

End Class
