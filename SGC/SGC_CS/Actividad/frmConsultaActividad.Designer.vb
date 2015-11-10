<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmConsultaActividad
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
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.SgcGroupBox1 = New SGC_CS.SGCGroupBox(Me.components)
        Me.SgcButton1 = New SGC_CS.SGCButton(Me.components)
        Me.SgcLabel2 = New SGC_CS.SGCLabel(Me.components)
        Me.SgcComboBox1 = New SGC_CS.SGCComboBox(Me.components)
        Me.SgcLabel1 = New SGC_CS.SGCLabel(Me.components)
        Me.tcPlanAnual = New SGC_CS.SGCTabControl(Me.components)
        Me.tpTodos = New System.Windows.Forms.TabPage()
        Me.SgcDataGridView1 = New SGC_CS.SGCDataGridView(Me.components)
        Me.tpRegistrados = New System.Windows.Forms.TabPage()
        Me.tpEvaluacion = New System.Windows.Forms.TabPage()
        Me.tpAprobadas = New System.Windows.Forms.TabPage()
        Me.tpRechazadas = New System.Windows.Forms.TabPage()
        Me.SgcDateTimePicker1 = New SGC_CS.SGCDateTimePicker(Me.components)
        Me.SgcDateTimePicker2 = New SGC_CS.SGCDateTimePicker(Me.components)
        Me.SgcLabel3 = New SGC_CS.SGCLabel(Me.components)
        Me.tbHabilitadas = New System.Windows.Forms.TabPage()
        Me.tpFinalizadas = New System.Windows.Forms.TabPage()
        Me.lblTitulo = New SGC_CS.SGCLabel(Me.components)
        Me.SgcGroupBox1.SuspendLayout()
        Me.tcPlanAnual.SuspendLayout()
        Me.tpTodos.SuspendLayout()
        CType(Me.SgcDataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SgcGroupBox1
        '
        Me.SgcGroupBox1.Controls.Add(Me.SgcDateTimePicker2)
        Me.SgcGroupBox1.Controls.Add(Me.SgcLabel3)
        Me.SgcGroupBox1.Controls.Add(Me.SgcDateTimePicker1)
        Me.SgcGroupBox1.Controls.Add(Me.SgcButton1)
        Me.SgcGroupBox1.Controls.Add(Me.SgcLabel2)
        Me.SgcGroupBox1.Controls.Add(Me.SgcComboBox1)
        Me.SgcGroupBox1.Controls.Add(Me.SgcLabel1)
        Me.SgcGroupBox1.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SgcGroupBox1.Location = New System.Drawing.Point(60, 70)
        Me.SgcGroupBox1.Name = "SgcGroupBox1"
        Me.SgcGroupBox1.Size = New System.Drawing.Size(900, 99)
        Me.SgcGroupBox1.TabIndex = 9
        Me.SgcGroupBox1.TabStop = False
        Me.SgcGroupBox1.Text = "Filtros"
        '
        'SgcButton1
        '
        Me.SgcButton1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.SgcButton1.FlatAppearance.BorderColor = System.Drawing.Color.Silver
        Me.SgcButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.SgcButton1.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SgcButton1.ForeColor = System.Drawing.Color.SteelBlue
        Me.SgcButton1.Location = New System.Drawing.Point(722, 27)
        Me.SgcButton1.Name = "SgcButton1"
        Me.SgcButton1.Size = New System.Drawing.Size(120, 31)
        Me.SgcButton1.TabIndex = 4
        Me.SgcButton1.Text = "Buscar"
        Me.SgcButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.SgcButton1.UseVisualStyleBackColor = False
        '
        'SgcLabel2
        '
        Me.SgcLabel2.AutoSize = True
        Me.SgcLabel2.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SgcLabel2.ForeColor = System.Drawing.Color.SteelBlue
        Me.SgcLabel2.Location = New System.Drawing.Point(393, 34)
        Me.SgcLabel2.Name = "SgcLabel2"
        Me.SgcLabel2.Size = New System.Drawing.Size(85, 18)
        Me.SgcLabel2.TabIndex = 2
        Me.SgcLabel2.Text = "Fecha Inicio:"
        '
        'SgcComboBox1
        '
        Me.SgcComboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.SgcComboBox1.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SgcComboBox1.ForeColor = System.Drawing.Color.Black
        Me.SgcComboBox1.FormattingEnabled = True
        Me.SgcComboBox1.Location = New System.Drawing.Point(99, 30)
        Me.SgcComboBox1.Name = "SgcComboBox1"
        Me.SgcComboBox1.Size = New System.Drawing.Size(121, 26)
        Me.SgcComboBox1.TabIndex = 1
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
        'tcPlanAnual
        '
        Me.tcPlanAnual.Controls.Add(Me.tpTodos)
        Me.tcPlanAnual.Controls.Add(Me.tpRegistrados)
        Me.tcPlanAnual.Controls.Add(Me.tpEvaluacion)
        Me.tcPlanAnual.Controls.Add(Me.tpAprobadas)
        Me.tcPlanAnual.Controls.Add(Me.tpRechazadas)
        Me.tcPlanAnual.Controls.Add(Me.tbHabilitadas)
        Me.tcPlanAnual.Controls.Add(Me.tpFinalizadas)
        Me.tcPlanAnual.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tcPlanAnual.Location = New System.Drawing.Point(60, 195)
        Me.tcPlanAnual.Name = "tcPlanAnual"
        Me.tcPlanAnual.SelectedIndex = 0
        Me.tcPlanAnual.Size = New System.Drawing.Size(896, 395)
        Me.tcPlanAnual.TabIndex = 10
        '
        'tpTodos
        '
        Me.tpTodos.Controls.Add(Me.SgcDataGridView1)
        Me.tpTodos.Location = New System.Drawing.Point(4, 27)
        Me.tpTodos.Name = "tpTodos"
        Me.tpTodos.Padding = New System.Windows.Forms.Padding(3)
        Me.tpTodos.Size = New System.Drawing.Size(888, 364)
        Me.tpTodos.TabIndex = 0
        Me.tpTodos.Text = "Todos"
        Me.tpTodos.UseVisualStyleBackColor = True
        '
        'SgcDataGridView1
        '
        Me.SgcDataGridView1.AllowUserToAddRows = False
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.WhiteSmoke
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.SteelBlue
        Me.SgcDataGridView1.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle2
        Me.SgcDataGridView1.BackgroundColor = System.Drawing.Color.WhiteSmoke
        Me.SgcDataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.SgcDataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.SgcDataGridView1.Location = New System.Drawing.Point(9, 11)
        Me.SgcDataGridView1.Name = "SgcDataGridView1"
        Me.SgcDataGridView1.Size = New System.Drawing.Size(873, 343)
        Me.SgcDataGridView1.TabIndex = 0
        '
        'tpRegistrados
        '
        Me.tpRegistrados.Location = New System.Drawing.Point(4, 27)
        Me.tpRegistrados.Name = "tpRegistrados"
        Me.tpRegistrados.Padding = New System.Windows.Forms.Padding(3)
        Me.tpRegistrados.Size = New System.Drawing.Size(888, 364)
        Me.tpRegistrados.TabIndex = 1
        Me.tpRegistrados.Text = "Registrados"
        Me.tpRegistrados.UseVisualStyleBackColor = True
        '
        'tpEvaluacion
        '
        Me.tpEvaluacion.Location = New System.Drawing.Point(4, 27)
        Me.tpEvaluacion.Name = "tpEvaluacion"
        Me.tpEvaluacion.Size = New System.Drawing.Size(888, 364)
        Me.tpEvaluacion.TabIndex = 2
        Me.tpEvaluacion.Text = "En Evaluación"
        Me.tpEvaluacion.UseVisualStyleBackColor = True
        '
        'tpAprobadas
        '
        Me.tpAprobadas.Location = New System.Drawing.Point(4, 27)
        Me.tpAprobadas.Name = "tpAprobadas"
        Me.tpAprobadas.Size = New System.Drawing.Size(888, 364)
        Me.tpAprobadas.TabIndex = 3
        Me.tpAprobadas.Text = "Aprobadas"
        Me.tpAprobadas.UseVisualStyleBackColor = True
        '
        'tpRechazadas
        '
        Me.tpRechazadas.Location = New System.Drawing.Point(4, 27)
        Me.tpRechazadas.Name = "tpRechazadas"
        Me.tpRechazadas.Size = New System.Drawing.Size(888, 364)
        Me.tpRechazadas.TabIndex = 4
        Me.tpRechazadas.Text = "Rechazadas"
        Me.tpRechazadas.UseVisualStyleBackColor = True
        '
        'SgcDateTimePicker1
        '
        Me.SgcDateTimePicker1.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SgcDateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.SgcDateTimePicker1.Location = New System.Drawing.Point(484, 28)
        Me.SgcDateTimePicker1.Name = "SgcDateTimePicker1"
        Me.SgcDateTimePicker1.Size = New System.Drawing.Size(100, 26)
        Me.SgcDateTimePicker1.TabIndex = 5
        '
        'SgcDateTimePicker2
        '
        Me.SgcDateTimePicker2.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SgcDateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.SgcDateTimePicker2.Location = New System.Drawing.Point(484, 61)
        Me.SgcDateTimePicker2.Name = "SgcDateTimePicker2"
        Me.SgcDateTimePicker2.Size = New System.Drawing.Size(100, 26)
        Me.SgcDateTimePicker2.TabIndex = 7
        '
        'SgcLabel3
        '
        Me.SgcLabel3.AutoSize = True
        Me.SgcLabel3.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SgcLabel3.ForeColor = System.Drawing.Color.SteelBlue
        Me.SgcLabel3.Location = New System.Drawing.Point(393, 67)
        Me.SgcLabel3.Name = "SgcLabel3"
        Me.SgcLabel3.Size = New System.Drawing.Size(70, 18)
        Me.SgcLabel3.TabIndex = 6
        Me.SgcLabel3.Text = "Fecha Fin:"
        '
        'tbHabilitadas
        '
        Me.tbHabilitadas.Location = New System.Drawing.Point(4, 27)
        Me.tbHabilitadas.Name = "tbHabilitadas"
        Me.tbHabilitadas.Size = New System.Drawing.Size(888, 364)
        Me.tbHabilitadas.TabIndex = 5
        Me.tbHabilitadas.Text = "Habilitadas"
        Me.tbHabilitadas.UseVisualStyleBackColor = True
        '
        'tpFinalizadas
        '
        Me.tpFinalizadas.Location = New System.Drawing.Point(4, 27)
        Me.tpFinalizadas.Name = "tpFinalizadas"
        Me.tpFinalizadas.Size = New System.Drawing.Size(888, 364)
        Me.tpFinalizadas.TabIndex = 6
        Me.tpFinalizadas.Text = "Finalizadas"
        Me.tpFinalizadas.UseVisualStyleBackColor = True
        '
        'lblTitulo
        '
        Me.lblTitulo.AutoSize = True
        Me.lblTitulo.BackColor = System.Drawing.Color.ForestGreen
        Me.lblTitulo.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitulo.ForeColor = System.Drawing.Color.White
        Me.lblTitulo.Location = New System.Drawing.Point(397, 9)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(199, 23)
        Me.lblTitulo.TabIndex = 12
        Me.lblTitulo.Text = "Consulta de Actividades"
        '
        'frmConsultaActividad
        '
        Me.ClientSize = New System.Drawing.Size(1016, 738)
        Me.Controls.Add(Me.lblTitulo)
        Me.Controls.Add(Me.tcPlanAnual)
        Me.Controls.Add(Me.SgcGroupBox1)
        Me.Name = "frmConsultaActividad"
        Me.Controls.SetChildIndex(Me.SgcGroupBox1, 0)
        Me.Controls.SetChildIndex(Me.tcPlanAnual, 0)
        Me.Controls.SetChildIndex(Me.lblTitulo, 0)
        Me.SgcGroupBox1.ResumeLayout(False)
        Me.SgcGroupBox1.PerformLayout()
        Me.tcPlanAnual.ResumeLayout(False)
        Me.tpTodos.ResumeLayout(False)
        CType(Me.SgcDataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents SgcGroupBox1 As SGC_CS.SGCGroupBox
    Friend WithEvents SgcButton1 As SGC_CS.SGCButton
    Friend WithEvents SgcLabel2 As SGC_CS.SGCLabel
    Friend WithEvents SgcComboBox1 As SGC_CS.SGCComboBox
    Friend WithEvents SgcLabel1 As SGC_CS.SGCLabel
    Friend WithEvents tcPlanAnual As SGC_CS.SGCTabControl
    Friend WithEvents tpTodos As System.Windows.Forms.TabPage
    Friend WithEvents SgcDataGridView1 As SGC_CS.SGCDataGridView
    Friend WithEvents tpRegistrados As System.Windows.Forms.TabPage
    Friend WithEvents tpEvaluacion As System.Windows.Forms.TabPage
    Friend WithEvents tpAprobadas As System.Windows.Forms.TabPage
    Friend WithEvents tpRechazadas As System.Windows.Forms.TabPage
    Friend WithEvents SgcDateTimePicker2 As SGC_CS.SGCDateTimePicker
    Friend WithEvents SgcLabel3 As SGC_CS.SGCLabel
    Friend WithEvents SgcDateTimePicker1 As SGC_CS.SGCDateTimePicker
    Friend WithEvents tbHabilitadas As System.Windows.Forms.TabPage
    Friend WithEvents tpFinalizadas As System.Windows.Forms.TabPage
    Friend WithEvents lblTitulo As SGC_CS.SGCLabel

End Class
