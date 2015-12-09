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
        Me.lblFechaRealizacionA = New SGC_CS.SGCLabel(Me.components)
        Me.lblFechaCreacionA = New SGC_CS.SGCLabel(Me.components)
        Me.dtpFecRealizacionHasta = New SGC_CS.SGCDateTimePicker(Me.components)
        Me.dtpFecRealizacionDesde = New SGC_CS.SGCDateTimePicker(Me.components)
        Me.dtpFecCreacionHasta = New SGC_CS.SGCDateTimePicker(Me.components)
        Me.dtpFecCreacionDesde = New SGC_CS.SGCDateTimePicker(Me.components)
        Me.lblNombre = New SGC_CS.SGCLabel(Me.components)
        Me.lblFechaRealizacion = New SGC_CS.SGCLabel(Me.components)
        Me.lblComite = New SGC_CS.SGCLabel(Me.components)
        Me.lblFechaCreacion = New SGC_CS.SGCLabel(Me.components)
        Me.cboComite = New SGC_CS.SGCComboBox(Me.components)
        Me.dgvListado = New SGC_CS.SGCDataGridView(Me.components)
        Me.gbxFiltros.SuspendLayout()
        CType(Me.dgvListado, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gbxFiltros
        '
        Me.gbxFiltros.Controls.Add(Me.txtNombre)
        Me.gbxFiltros.Controls.Add(Me.btnBuscar)
        Me.gbxFiltros.Controls.Add(Me.lblFechaRealizacionA)
        Me.gbxFiltros.Controls.Add(Me.lblFechaCreacionA)
        Me.gbxFiltros.Controls.Add(Me.dtpFecRealizacionHasta)
        Me.gbxFiltros.Controls.Add(Me.dtpFecRealizacionDesde)
        Me.gbxFiltros.Controls.Add(Me.dtpFecCreacionHasta)
        Me.gbxFiltros.Controls.Add(Me.dtpFecCreacionDesde)
        Me.gbxFiltros.Controls.Add(Me.lblNombre)
        Me.gbxFiltros.Controls.Add(Me.lblFechaRealizacion)
        Me.gbxFiltros.Controls.Add(Me.lblComite)
        Me.gbxFiltros.Controls.Add(Me.lblFechaCreacion)
        Me.gbxFiltros.Controls.Add(Me.cboComite)
        Me.gbxFiltros.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbxFiltros.Location = New System.Drawing.Point(12, 12)
        Me.gbxFiltros.Name = "gbxFiltros"
        Me.gbxFiltros.Size = New System.Drawing.Size(392, 207)
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
        Me.txtNombre.Location = New System.Drawing.Point(153, 127)
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
        Me.btnBuscar.Location = New System.Drawing.Point(153, 159)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(75, 31)
        Me.btnBuscar.TabIndex = 20
        Me.btnBuscar.Text = "Buscar"
        Me.btnBuscar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnBuscar.UseVisualStyleBackColor = False
        '
        'lblFechaRealizacionA
        '
        Me.lblFechaRealizacionA.AutoSize = True
        Me.lblFechaRealizacionA.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFechaRealizacionA.ForeColor = System.Drawing.Color.SteelBlue
        Me.lblFechaRealizacionA.Location = New System.Drawing.Point(261, 101)
        Me.lblFechaRealizacionA.Name = "lblFechaRealizacionA"
        Me.lblFechaRealizacionA.Size = New System.Drawing.Size(15, 18)
        Me.lblFechaRealizacionA.TabIndex = 21
        Me.lblFechaRealizacionA.Text = "a"
        '
        'lblFechaCreacionA
        '
        Me.lblFechaCreacionA.AutoSize = True
        Me.lblFechaCreacionA.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFechaCreacionA.ForeColor = System.Drawing.Color.SteelBlue
        Me.lblFechaCreacionA.Location = New System.Drawing.Point(261, 67)
        Me.lblFechaCreacionA.Name = "lblFechaCreacionA"
        Me.lblFechaCreacionA.Size = New System.Drawing.Size(15, 18)
        Me.lblFechaCreacionA.TabIndex = 20
        Me.lblFechaCreacionA.Text = "a"
        '
        'dtpFecRealizacionHasta
        '
        Me.dtpFecRealizacionHasta.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFecRealizacionHasta.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFecRealizacionHasta.Location = New System.Drawing.Point(286, 95)
        Me.dtpFecRealizacionHasta.Name = "dtpFecRealizacionHasta"
        Me.dtpFecRealizacionHasta.Size = New System.Drawing.Size(100, 26)
        Me.dtpFecRealizacionHasta.TabIndex = 15
        '
        'dtpFecRealizacionDesde
        '
        Me.dtpFecRealizacionDesde.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFecRealizacionDesde.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFecRealizacionDesde.Location = New System.Drawing.Point(153, 95)
        Me.dtpFecRealizacionDesde.Name = "dtpFecRealizacionDesde"
        Me.dtpFecRealizacionDesde.Size = New System.Drawing.Size(100, 26)
        Me.dtpFecRealizacionDesde.TabIndex = 14
        '
        'dtpFecCreacionHasta
        '
        Me.dtpFecCreacionHasta.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFecCreacionHasta.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFecCreacionHasta.Location = New System.Drawing.Point(286, 63)
        Me.dtpFecCreacionHasta.Name = "dtpFecCreacionHasta"
        Me.dtpFecCreacionHasta.Size = New System.Drawing.Size(100, 26)
        Me.dtpFecCreacionHasta.TabIndex = 13
        '
        'dtpFecCreacionDesde
        '
        Me.dtpFecCreacionDesde.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFecCreacionDesde.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFecCreacionDesde.Location = New System.Drawing.Point(153, 63)
        Me.dtpFecCreacionDesde.Name = "dtpFecCreacionDesde"
        Me.dtpFecCreacionDesde.Size = New System.Drawing.Size(100, 26)
        Me.dtpFecCreacionDesde.TabIndex = 12
        '
        'lblNombre
        '
        Me.lblNombre.AutoSize = True
        Me.lblNombre.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombre.ForeColor = System.Drawing.Color.SteelBlue
        Me.lblNombre.Location = New System.Drawing.Point(20, 129)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(63, 18)
        Me.lblNombre.TabIndex = 11
        Me.lblNombre.Text = "Nombre:"
        '
        'lblFechaRealizacion
        '
        Me.lblFechaRealizacion.AutoSize = True
        Me.lblFechaRealizacion.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFechaRealizacion.ForeColor = System.Drawing.Color.SteelBlue
        Me.lblFechaRealizacion.Location = New System.Drawing.Point(20, 101)
        Me.lblFechaRealizacion.Name = "lblFechaRealizacion"
        Me.lblFechaRealizacion.Size = New System.Drawing.Size(121, 18)
        Me.lblFechaRealizacion.TabIndex = 10
        Me.lblFechaRealizacion.Text = "Fecha Realización:"
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
        'lblFechaCreacion
        '
        Me.lblFechaCreacion.AutoSize = True
        Me.lblFechaCreacion.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFechaCreacion.ForeColor = System.Drawing.Color.SteelBlue
        Me.lblFechaCreacion.Location = New System.Drawing.Point(20, 69)
        Me.lblFechaCreacion.Name = "lblFechaCreacion"
        Me.lblFechaCreacion.Size = New System.Drawing.Size(105, 18)
        Me.lblFechaCreacion.TabIndex = 7
        Me.lblFechaCreacion.Text = "Fecha Creación:"
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
        Me.dgvListado.Location = New System.Drawing.Point(12, 225)
        Me.dgvListado.Name = "dgvListado"
        Me.dgvListado.Size = New System.Drawing.Size(392, 194)
        Me.dgvListado.TabIndex = 22
        '
        'frmBuscarActividad
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 18.0!)
        Me.ClientSize = New System.Drawing.Size(425, 430)
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
    Friend WithEvents lblFechaCreacion As SGC_CS.SGCLabel
    Friend WithEvents cboComite As SGC_CS.SGCComboBox
    Friend WithEvents lblNombre As SGC_CS.SGCLabel
    Friend WithEvents lblFechaRealizacion As SGC_CS.SGCLabel
    Friend WithEvents lblFechaRealizacionA As SGC_CS.SGCLabel
    Friend WithEvents lblFechaCreacionA As SGC_CS.SGCLabel
    Friend WithEvents dtpFecRealizacionHasta As SGC_CS.SGCDateTimePicker
    Friend WithEvents dtpFecRealizacionDesde As SGC_CS.SGCDateTimePicker
    Friend WithEvents dtpFecCreacionHasta As SGC_CS.SGCDateTimePicker
    Friend WithEvents dtpFecCreacionDesde As SGC_CS.SGCDateTimePicker
    Friend WithEvents btnBuscar As SGC_CS.SGCButton
    Friend WithEvents dgvListado As SGC_CS.SGCDataGridView
    Friend WithEvents txtNombre As SGC_CS.SGCTextBox

End Class
