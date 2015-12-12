<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCronogramaEspacios
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
        Me.lblTitulo = New SGC_CS.SGCLabel(Me.components)
        Me.SgcGroupBox1 = New SGC_CS.SGCGroupBox(Me.components)
        Me.cboEspacio = New SGC_CS.SGCComboBox(Me.components)
        Me.SgcLabel5 = New SGC_CS.SGCLabel(Me.components)
        Me.cboSede = New SGC_CS.SGCComboBox(Me.components)
        Me.SgcLabel4 = New SGC_CS.SGCLabel(Me.components)
        Me.cboAnio = New SGC_CS.SGCComboBox(Me.components)
        Me.SgcLabel3 = New SGC_CS.SGCLabel(Me.components)
        Me.btnBuscar = New SGC_CS.SGCButton(Me.components)
        Me.cboMes = New SGC_CS.SGCComboBox(Me.components)
        Me.SgcLabel2 = New SGC_CS.SGCLabel(Me.components)
        Me.cboLugar = New SGC_CS.SGCComboBox(Me.components)
        Me.SgcLabel1 = New SGC_CS.SGCLabel(Me.components)
        Me.SgcGroupBox2 = New SGC_CS.SGCGroupBox(Me.components)
        Me.dgvCalendario = New SGC_CS.SGCDataGridView(Me.components)
        Me.SgcGroupBox1.SuspendLayout()
        Me.SgcGroupBox2.SuspendLayout()
        CType(Me.dgvCalendario, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblTitulo
        '
        Me.lblTitulo.AutoSize = True
        Me.lblTitulo.BackColor = System.Drawing.Color.ForestGreen
        Me.lblTitulo.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitulo.ForeColor = System.Drawing.Color.White
        Me.lblTitulo.Location = New System.Drawing.Point(409, 9)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(201, 23)
        Me.lblTitulo.TabIndex = 16
        Me.lblTitulo.Text = "Cronograma de Espacios"
        '
        'SgcGroupBox1
        '
        Me.SgcGroupBox1.Controls.Add(Me.cboEspacio)
        Me.SgcGroupBox1.Controls.Add(Me.SgcLabel5)
        Me.SgcGroupBox1.Controls.Add(Me.cboSede)
        Me.SgcGroupBox1.Controls.Add(Me.SgcLabel4)
        Me.SgcGroupBox1.Controls.Add(Me.cboAnio)
        Me.SgcGroupBox1.Controls.Add(Me.SgcLabel3)
        Me.SgcGroupBox1.Controls.Add(Me.btnBuscar)
        Me.SgcGroupBox1.Controls.Add(Me.cboMes)
        Me.SgcGroupBox1.Controls.Add(Me.SgcLabel2)
        Me.SgcGroupBox1.Controls.Add(Me.cboLugar)
        Me.SgcGroupBox1.Controls.Add(Me.SgcLabel1)
        Me.SgcGroupBox1.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SgcGroupBox1.Location = New System.Drawing.Point(60, 70)
        Me.SgcGroupBox1.Name = "SgcGroupBox1"
        Me.SgcGroupBox1.Size = New System.Drawing.Size(900, 136)
        Me.SgcGroupBox1.TabIndex = 17
        Me.SgcGroupBox1.TabStop = False
        Me.SgcGroupBox1.Text = "Filtros"
        '
        'cboEspacio
        '
        Me.cboEspacio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboEspacio.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cboEspacio.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboEspacio.ForeColor = System.Drawing.Color.Black
        Me.cboEspacio.FormattingEnabled = True
        Me.cboEspacio.Location = New System.Drawing.Point(125, 93)
        Me.cboEspacio.Name = "cboEspacio"
        Me.cboEspacio.Size = New System.Drawing.Size(243, 26)
        Me.cboEspacio.TabIndex = 10
        '
        'SgcLabel5
        '
        Me.SgcLabel5.AutoSize = True
        Me.SgcLabel5.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SgcLabel5.ForeColor = System.Drawing.Color.SteelBlue
        Me.SgcLabel5.Location = New System.Drawing.Point(45, 96)
        Me.SgcLabel5.Name = "SgcLabel5"
        Me.SgcLabel5.Size = New System.Drawing.Size(58, 18)
        Me.SgcLabel5.TabIndex = 9
        Me.SgcLabel5.Text = "Espacio:"
        '
        'cboSede
        '
        Me.cboSede.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboSede.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cboSede.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboSede.ForeColor = System.Drawing.Color.Black
        Me.cboSede.FormattingEnabled = True
        Me.cboSede.Location = New System.Drawing.Point(125, 29)
        Me.cboSede.Name = "cboSede"
        Me.cboSede.Size = New System.Drawing.Size(121, 26)
        Me.cboSede.TabIndex = 8
        '
        'SgcLabel4
        '
        Me.SgcLabel4.AutoSize = True
        Me.SgcLabel4.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SgcLabel4.ForeColor = System.Drawing.Color.SteelBlue
        Me.SgcLabel4.Location = New System.Drawing.Point(45, 33)
        Me.SgcLabel4.Name = "SgcLabel4"
        Me.SgcLabel4.Size = New System.Drawing.Size(43, 18)
        Me.SgcLabel4.TabIndex = 7
        Me.SgcLabel4.Text = "Sede:"
        '
        'cboAnio
        '
        Me.cboAnio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboAnio.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cboAnio.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboAnio.ForeColor = System.Drawing.Color.Black
        Me.cboAnio.FormattingEnabled = True
        Me.cboAnio.Location = New System.Drawing.Point(561, 61)
        Me.cboAnio.Name = "cboAnio"
        Me.cboAnio.Size = New System.Drawing.Size(121, 26)
        Me.cboAnio.TabIndex = 6
        '
        'SgcLabel3
        '
        Me.SgcLabel3.AutoSize = True
        Me.SgcLabel3.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SgcLabel3.ForeColor = System.Drawing.Color.SteelBlue
        Me.SgcLabel3.Location = New System.Drawing.Point(503, 64)
        Me.SgcLabel3.Name = "SgcLabel3"
        Me.SgcLabel3.Size = New System.Drawing.Size(37, 18)
        Me.SgcLabel3.TabIndex = 5
        Me.SgcLabel3.Text = "Año:"
        '
        'btnBuscar
        '
        Me.btnBuscar.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnBuscar.FlatAppearance.BorderColor = System.Drawing.Color.Silver
        Me.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBuscar.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBuscar.ForeColor = System.Drawing.Color.SteelBlue
        Me.btnBuscar.Location = New System.Drawing.Point(742, 29)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(120, 31)
        Me.btnBuscar.TabIndex = 4
        Me.btnBuscar.Text = "Buscar"
        Me.btnBuscar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnBuscar.UseVisualStyleBackColor = False
        '
        'cboMes
        '
        Me.cboMes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboMes.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cboMes.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboMes.ForeColor = System.Drawing.Color.Black
        Me.cboMes.FormattingEnabled = True
        Me.cboMes.Location = New System.Drawing.Point(561, 31)
        Me.cboMes.Name = "cboMes"
        Me.cboMes.Size = New System.Drawing.Size(121, 26)
        Me.cboMes.TabIndex = 3
        '
        'SgcLabel2
        '
        Me.SgcLabel2.AutoSize = True
        Me.SgcLabel2.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SgcLabel2.ForeColor = System.Drawing.Color.SteelBlue
        Me.SgcLabel2.Location = New System.Drawing.Point(501, 34)
        Me.SgcLabel2.Name = "SgcLabel2"
        Me.SgcLabel2.Size = New System.Drawing.Size(39, 18)
        Me.SgcLabel2.TabIndex = 2
        Me.SgcLabel2.Text = "Mes:"
        '
        'cboLugar
        '
        Me.cboLugar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboLugar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cboLugar.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboLugar.ForeColor = System.Drawing.Color.Black
        Me.cboLugar.FormattingEnabled = True
        Me.cboLugar.Location = New System.Drawing.Point(125, 61)
        Me.cboLugar.Name = "cboLugar"
        Me.cboLugar.Size = New System.Drawing.Size(243, 26)
        Me.cboLugar.TabIndex = 1
        '
        'SgcLabel1
        '
        Me.SgcLabel1.AutoSize = True
        Me.SgcLabel1.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SgcLabel1.ForeColor = System.Drawing.Color.SteelBlue
        Me.SgcLabel1.Location = New System.Drawing.Point(45, 64)
        Me.SgcLabel1.Name = "SgcLabel1"
        Me.SgcLabel1.Size = New System.Drawing.Size(45, 18)
        Me.SgcLabel1.TabIndex = 0
        Me.SgcLabel1.Text = "Lugar:"
        '
        'SgcGroupBox2
        '
        Me.SgcGroupBox2.Controls.Add(Me.dgvCalendario)
        Me.SgcGroupBox2.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SgcGroupBox2.Location = New System.Drawing.Point(60, 212)
        Me.SgcGroupBox2.Name = "SgcGroupBox2"
        Me.SgcGroupBox2.Size = New System.Drawing.Size(900, 329)
        Me.SgcGroupBox2.TabIndex = 18
        Me.SgcGroupBox2.TabStop = False
        Me.SgcGroupBox2.Text = "Calendario"
        '
        'dgvCalendario
        '
        Me.dgvCalendario.AllowUserToAddRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.WhiteSmoke
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.SteelBlue
        Me.dgvCalendario.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvCalendario.BackgroundColor = System.Drawing.Color.WhiteSmoke
        Me.dgvCalendario.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dgvCalendario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvCalendario.Location = New System.Drawing.Point(13, 25)
        Me.dgvCalendario.Name = "dgvCalendario"
        Me.dgvCalendario.Size = New System.Drawing.Size(872, 283)
        Me.dgvCalendario.TabIndex = 2
        '
        'frmCronogramaEspacios
        '
        Me.ClientSize = New System.Drawing.Size(1016, 733)
        Me.Controls.Add(Me.SgcGroupBox2)
        Me.Controls.Add(Me.SgcGroupBox1)
        Me.Controls.Add(Me.lblTitulo)
        Me.Name = "frmCronogramaEspacios"
        Me.Controls.SetChildIndex(Me.lblTitulo, 0)
        Me.Controls.SetChildIndex(Me.SgcGroupBox1, 0)
        Me.Controls.SetChildIndex(Me.SgcGroupBox2, 0)
        Me.SgcGroupBox1.ResumeLayout(False)
        Me.SgcGroupBox1.PerformLayout()
        Me.SgcGroupBox2.ResumeLayout(False)
        CType(Me.dgvCalendario, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblTitulo As SGC_CS.SGCLabel
    Friend WithEvents SgcGroupBox1 As SGC_CS.SGCGroupBox
    Friend WithEvents cboAnio As SGC_CS.SGCComboBox
    Friend WithEvents SgcLabel3 As SGC_CS.SGCLabel
    Friend WithEvents btnBuscar As SGC_CS.SGCButton
    Friend WithEvents cboMes As SGC_CS.SGCComboBox
    Friend WithEvents SgcLabel2 As SGC_CS.SGCLabel
    Friend WithEvents cboLugar As SGC_CS.SGCComboBox
    Friend WithEvents SgcLabel1 As SGC_CS.SGCLabel
    Friend WithEvents SgcGroupBox2 As SGC_CS.SGCGroupBox
    Friend WithEvents cboSede As SGC_CS.SGCComboBox
    Friend WithEvents SgcLabel4 As SGC_CS.SGCLabel
    Friend WithEvents cboEspacio As SGC_CS.SGCComboBox
    Friend WithEvents SgcLabel5 As SGC_CS.SGCLabel
    Friend WithEvents dgvCalendario As SGC_CS.SGCDataGridView

End Class
