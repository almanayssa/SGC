<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPlanEvaluacionPGC
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
        Me.lblTitulo = New SGC_CS.SGCLabel(Me.components)
        Me.SgcGroupBox1 = New SGC_CS.SGCGroupBox(Me.components)
        Me.btnBuscar = New SGC_CS.SGCButton(Me.components)
        Me.cboAnio = New SGC_CS.SGCComboBox(Me.components)
        Me.SgcLabel2 = New SGC_CS.SGCLabel(Me.components)
        Me.cboComite = New SGC_CS.SGCComboBox(Me.components)
        Me.SgcLabel1 = New SGC_CS.SGCLabel(Me.components)
        Me.SgcGroupBox2 = New SGC_CS.SGCGroupBox(Me.components)
        Me.tbListado = New SGC_CS.SGCTabControl(Me.components)
        Me.tpRegistrados = New System.Windows.Forms.TabPage()
        Me.btnEnviarCD = New SGC_CS.SGCButton(Me.components)
        Me.dgvRegistrados = New SGC_CS.SGCDataGridView(Me.components)
        Me.tpAprobados = New System.Windows.Forms.TabPage()
        Me.btnAprobar = New SGC_CS.SGCButton(Me.components)
        Me.dgvAprobados = New SGC_CS.SGCDataGridView(Me.components)
        Me.tpRechazados = New System.Windows.Forms.TabPage()
        Me.btnRechazar = New SGC_CS.SGCButton(Me.components)
        Me.dgvRechazados = New SGC_CS.SGCDataGridView(Me.components)
        Me.SgcGroupBox1.SuspendLayout()
        Me.SgcGroupBox2.SuspendLayout()
        Me.tbListado.SuspendLayout()
        Me.tpRegistrados.SuspendLayout()
        CType(Me.dgvRegistrados, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tpAprobados.SuspendLayout()
        CType(Me.dgvAprobados, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tpRechazados.SuspendLayout()
        CType(Me.dgvRechazados, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblTitulo
        '
        Me.lblTitulo.AutoSize = True
        Me.lblTitulo.BackColor = System.Drawing.Color.ForestGreen
        Me.lblTitulo.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitulo.ForeColor = System.Drawing.Color.White
        Me.lblTitulo.Location = New System.Drawing.Point(287, 9)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(448, 23)
        Me.lblTitulo.TabIndex = 13
        Me.lblTitulo.Text = "Evaluación Plan Anual - Presidencia General de Comités"
        '
        'SgcGroupBox1
        '
        Me.SgcGroupBox1.Controls.Add(Me.btnBuscar)
        Me.SgcGroupBox1.Controls.Add(Me.cboAnio)
        Me.SgcGroupBox1.Controls.Add(Me.SgcLabel2)
        Me.SgcGroupBox1.Controls.Add(Me.cboComite)
        Me.SgcGroupBox1.Controls.Add(Me.SgcLabel1)
        Me.SgcGroupBox1.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SgcGroupBox1.Location = New System.Drawing.Point(60, 70)
        Me.SgcGroupBox1.Name = "SgcGroupBox1"
        Me.SgcGroupBox1.Size = New System.Drawing.Size(900, 79)
        Me.SgcGroupBox1.TabIndex = 14
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
        'cboAnio
        '
        Me.cboAnio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboAnio.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cboAnio.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboAnio.ForeColor = System.Drawing.Color.Black
        Me.cboAnio.FormattingEnabled = True
        Me.cboAnio.Location = New System.Drawing.Point(470, 31)
        Me.cboAnio.Name = "cboAnio"
        Me.cboAnio.Size = New System.Drawing.Size(121, 26)
        Me.cboAnio.TabIndex = 3
        '
        'SgcLabel2
        '
        Me.SgcLabel2.AutoSize = True
        Me.SgcLabel2.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SgcLabel2.ForeColor = System.Drawing.Color.SteelBlue
        Me.SgcLabel2.Location = New System.Drawing.Point(393, 34)
        Me.SgcLabel2.Name = "SgcLabel2"
        Me.SgcLabel2.Size = New System.Drawing.Size(37, 18)
        Me.SgcLabel2.TabIndex = 2
        Me.SgcLabel2.Text = "Año:"
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
        Me.cboComite.Size = New System.Drawing.Size(220, 26)
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
        'SgcGroupBox2
        '
        Me.SgcGroupBox2.Controls.Add(Me.tbListado)
        Me.SgcGroupBox2.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SgcGroupBox2.Location = New System.Drawing.Point(60, 156)
        Me.SgcGroupBox2.Name = "SgcGroupBox2"
        Me.SgcGroupBox2.Size = New System.Drawing.Size(900, 410)
        Me.SgcGroupBox2.TabIndex = 15
        Me.SgcGroupBox2.TabStop = False
        Me.SgcGroupBox2.Text = "Listado"
        '
        'tbListado
        '
        Me.tbListado.Controls.Add(Me.tpRegistrados)
        Me.tbListado.Controls.Add(Me.tpAprobados)
        Me.tbListado.Controls.Add(Me.tpRechazados)
        Me.tbListado.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbListado.Location = New System.Drawing.Point(13, 26)
        Me.tbListado.Name = "tbListado"
        Me.tbListado.SelectedIndex = 0
        Me.tbListado.Size = New System.Drawing.Size(870, 365)
        Me.tbListado.TabIndex = 1
        '
        'tpRegistrados
        '
        Me.tpRegistrados.Controls.Add(Me.btnEnviarCD)
        Me.tpRegistrados.Controls.Add(Me.dgvRegistrados)
        Me.tpRegistrados.Location = New System.Drawing.Point(4, 27)
        Me.tpRegistrados.Name = "tpRegistrados"
        Me.tpRegistrados.Padding = New System.Windows.Forms.Padding(3)
        Me.tpRegistrados.Size = New System.Drawing.Size(862, 334)
        Me.tpRegistrados.TabIndex = 0
        Me.tpRegistrados.Text = "Registrados"
        Me.tpRegistrados.UseVisualStyleBackColor = True
        '
        'btnEnviarCD
        '
        Me.btnEnviarCD.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnEnviarCD.FlatAppearance.BorderColor = System.Drawing.Color.Silver
        Me.btnEnviarCD.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEnviarCD.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEnviarCD.ForeColor = System.Drawing.Color.SteelBlue
        Me.btnEnviarCD.Location = New System.Drawing.Point(736, 292)
        Me.btnEnviarCD.Name = "btnEnviarCD"
        Me.btnEnviarCD.Size = New System.Drawing.Size(120, 31)
        Me.btnEnviarCD.TabIndex = 17
        Me.btnEnviarCD.Text = "Enviar a CD"
        Me.btnEnviarCD.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnEnviarCD.UseVisualStyleBackColor = False
        '
        'dgvRegistrados
        '
        Me.dgvRegistrados.AllowUserToAddRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.WhiteSmoke
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.SteelBlue
        Me.dgvRegistrados.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvRegistrados.BackgroundColor = System.Drawing.Color.WhiteSmoke
        Me.dgvRegistrados.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dgvRegistrados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvRegistrados.Location = New System.Drawing.Point(6, 6)
        Me.dgvRegistrados.Name = "dgvRegistrados"
        Me.dgvRegistrados.Size = New System.Drawing.Size(850, 280)
        Me.dgvRegistrados.TabIndex = 0
        '
        'tpAprobados
        '
        Me.tpAprobados.Controls.Add(Me.btnAprobar)
        Me.tpAprobados.Controls.Add(Me.dgvAprobados)
        Me.tpAprobados.Location = New System.Drawing.Point(4, 27)
        Me.tpAprobados.Name = "tpAprobados"
        Me.tpAprobados.Padding = New System.Windows.Forms.Padding(3)
        Me.tpAprobados.Size = New System.Drawing.Size(862, 334)
        Me.tpAprobados.TabIndex = 1
        Me.tpAprobados.Text = "Aprobados"
        Me.tpAprobados.UseVisualStyleBackColor = True
        '
        'btnAprobar
        '
        Me.btnAprobar.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnAprobar.FlatAppearance.BorderColor = System.Drawing.Color.Silver
        Me.btnAprobar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAprobar.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAprobar.ForeColor = System.Drawing.Color.SteelBlue
        Me.btnAprobar.Location = New System.Drawing.Point(736, 292)
        Me.btnAprobar.Name = "btnAprobar"
        Me.btnAprobar.Size = New System.Drawing.Size(120, 31)
        Me.btnAprobar.TabIndex = 7
        Me.btnAprobar.Text = "Aprobar"
        Me.btnAprobar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnAprobar.UseVisualStyleBackColor = False
        '
        'dgvAprobados
        '
        Me.dgvAprobados.AllowUserToAddRows = False
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.WhiteSmoke
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.SteelBlue
        Me.dgvAprobados.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvAprobados.BackgroundColor = System.Drawing.Color.WhiteSmoke
        Me.dgvAprobados.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dgvAprobados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvAprobados.Location = New System.Drawing.Point(6, 6)
        Me.dgvAprobados.Name = "dgvAprobados"
        Me.dgvAprobados.Size = New System.Drawing.Size(850, 280)
        Me.dgvAprobados.TabIndex = 1
        '
        'tpRechazados
        '
        Me.tpRechazados.Controls.Add(Me.btnRechazar)
        Me.tpRechazados.Controls.Add(Me.dgvRechazados)
        Me.tpRechazados.Location = New System.Drawing.Point(4, 27)
        Me.tpRechazados.Name = "tpRechazados"
        Me.tpRechazados.Size = New System.Drawing.Size(862, 334)
        Me.tpRechazados.TabIndex = 2
        Me.tpRechazados.Text = "Rechazados"
        Me.tpRechazados.UseVisualStyleBackColor = True
        '
        'btnRechazar
        '
        Me.btnRechazar.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnRechazar.FlatAppearance.BorderColor = System.Drawing.Color.Silver
        Me.btnRechazar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRechazar.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRechazar.ForeColor = System.Drawing.Color.SteelBlue
        Me.btnRechazar.Location = New System.Drawing.Point(736, 292)
        Me.btnRechazar.Name = "btnRechazar"
        Me.btnRechazar.Size = New System.Drawing.Size(120, 31)
        Me.btnRechazar.TabIndex = 8
        Me.btnRechazar.Text = "Rechazar"
        Me.btnRechazar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnRechazar.UseVisualStyleBackColor = False
        '
        'dgvRechazados
        '
        Me.dgvRechazados.AllowUserToAddRows = False
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.WhiteSmoke
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.SteelBlue
        Me.dgvRechazados.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle3
        Me.dgvRechazados.BackgroundColor = System.Drawing.Color.WhiteSmoke
        Me.dgvRechazados.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dgvRechazados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvRechazados.Location = New System.Drawing.Point(6, 6)
        Me.dgvRechazados.Name = "dgvRechazados"
        Me.dgvRechazados.Size = New System.Drawing.Size(850, 280)
        Me.dgvRechazados.TabIndex = 1
        '
        'frmPlanEvaluacionPGC
        '
        Me.ClientSize = New System.Drawing.Size(1016, 733)
        Me.Controls.Add(Me.SgcGroupBox2)
        Me.Controls.Add(Me.SgcGroupBox1)
        Me.Controls.Add(Me.lblTitulo)
        Me.Name = "frmPlanEvaluacionPGC"
        Me.Controls.SetChildIndex(Me.lblTitulo, 0)
        Me.Controls.SetChildIndex(Me.SgcGroupBox1, 0)
        Me.Controls.SetChildIndex(Me.SgcGroupBox2, 0)
        Me.SgcGroupBox1.ResumeLayout(False)
        Me.SgcGroupBox1.PerformLayout()
        Me.SgcGroupBox2.ResumeLayout(False)
        Me.tbListado.ResumeLayout(False)
        Me.tpRegistrados.ResumeLayout(False)
        CType(Me.dgvRegistrados, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tpAprobados.ResumeLayout(False)
        CType(Me.dgvAprobados, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tpRechazados.ResumeLayout(False)
        CType(Me.dgvRechazados, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblTitulo As SGC_CS.SGCLabel
    Friend WithEvents SgcGroupBox1 As SGC_CS.SGCGroupBox
    Friend WithEvents btnBuscar As SGC_CS.SGCButton
    Friend WithEvents cboAnio As SGC_CS.SGCComboBox
    Friend WithEvents SgcLabel2 As SGC_CS.SGCLabel
    Friend WithEvents cboComite As SGC_CS.SGCComboBox
    Friend WithEvents SgcLabel1 As SGC_CS.SGCLabel
    Friend WithEvents SgcGroupBox2 As SGC_CS.SGCGroupBox
    Friend WithEvents dgvRegistrados As SGC_CS.SGCDataGridView
    Friend WithEvents tbListado As SGC_CS.SGCTabControl
    Friend WithEvents tpRegistrados As System.Windows.Forms.TabPage
    Friend WithEvents tpAprobados As System.Windows.Forms.TabPage
    Friend WithEvents tpRechazados As System.Windows.Forms.TabPage
    Friend WithEvents dgvAprobados As SGC_CS.SGCDataGridView
    Friend WithEvents dgvRechazados As SGC_CS.SGCDataGridView
    Friend WithEvents btnEnviarCD As SGC_CS.SGCButton
    Friend WithEvents btnAprobar As SGC_CS.SGCButton
    Friend WithEvents btnRechazar As SGC_CS.SGCButton

End Class
