<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBuscarPlan
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
        Me.SgcGroupBox2 = New SGC_CS.SGCGroupBox(Me.components)
        Me.SgcLabel2 = New SGC_CS.SGCLabel(Me.components)
        Me.SgcLabel3 = New SGC_CS.SGCLabel(Me.components)
        Me.SgcComboBox2 = New SGC_CS.SGCComboBox(Me.components)
        Me.SgcComboBox1 = New SGC_CS.SGCComboBox(Me.components)
        Me.SgcDataGridView1 = New SGC_CS.SGCDataGridView(Me.components)
        Me.SgcButton1 = New SGC_CS.SGCButton(Me.components)
        Me.SgcGroupBox2.SuspendLayout()
        CType(Me.SgcDataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SgcGroupBox2
        '
        Me.SgcGroupBox2.Controls.Add(Me.SgcButton1)
        Me.SgcGroupBox2.Controls.Add(Me.SgcLabel2)
        Me.SgcGroupBox2.Controls.Add(Me.SgcLabel3)
        Me.SgcGroupBox2.Controls.Add(Me.SgcComboBox2)
        Me.SgcGroupBox2.Controls.Add(Me.SgcComboBox1)
        Me.SgcGroupBox2.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SgcGroupBox2.Location = New System.Drawing.Point(12, 12)
        Me.SgcGroupBox2.Name = "SgcGroupBox2"
        Me.SgcGroupBox2.Size = New System.Drawing.Size(374, 139)
        Me.SgcGroupBox2.TabIndex = 18
        Me.SgcGroupBox2.TabStop = False
        Me.SgcGroupBox2.Text = "Filtros"
        '
        'SgcLabel2
        '
        Me.SgcLabel2.AutoSize = True
        Me.SgcLabel2.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SgcLabel2.ForeColor = System.Drawing.Color.SteelBlue
        Me.SgcLabel2.Location = New System.Drawing.Point(20, 31)
        Me.SgcLabel2.Name = "SgcLabel2"
        Me.SgcLabel2.Size = New System.Drawing.Size(57, 18)
        Me.SgcLabel2.TabIndex = 6
        Me.SgcLabel2.Text = "Comité:"
        '
        'SgcLabel3
        '
        Me.SgcLabel3.AutoSize = True
        Me.SgcLabel3.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SgcLabel3.ForeColor = System.Drawing.Color.SteelBlue
        Me.SgcLabel3.Location = New System.Drawing.Point(20, 63)
        Me.SgcLabel3.Name = "SgcLabel3"
        Me.SgcLabel3.Size = New System.Drawing.Size(37, 18)
        Me.SgcLabel3.TabIndex = 7
        Me.SgcLabel3.Text = "Año:"
        '
        'SgcComboBox2
        '
        Me.SgcComboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.SgcComboBox2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.SgcComboBox2.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SgcComboBox2.ForeColor = System.Drawing.Color.Black
        Me.SgcComboBox2.FormattingEnabled = True
        Me.SgcComboBox2.Location = New System.Drawing.Point(132, 60)
        Me.SgcComboBox2.Name = "SgcComboBox2"
        Me.SgcComboBox2.Size = New System.Drawing.Size(121, 26)
        Me.SgcComboBox2.TabIndex = 9
        '
        'SgcComboBox1
        '
        Me.SgcComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.SgcComboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.SgcComboBox1.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SgcComboBox1.ForeColor = System.Drawing.Color.Black
        Me.SgcComboBox1.FormattingEnabled = True
        Me.SgcComboBox1.Location = New System.Drawing.Point(132, 28)
        Me.SgcComboBox1.Name = "SgcComboBox1"
        Me.SgcComboBox1.Size = New System.Drawing.Size(121, 26)
        Me.SgcComboBox1.TabIndex = 8
        '
        'SgcDataGridView1
        '
        Me.SgcDataGridView1.AllowUserToAddRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.WhiteSmoke
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.SteelBlue
        Me.SgcDataGridView1.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.SgcDataGridView1.BackgroundColor = System.Drawing.Color.WhiteSmoke
        Me.SgcDataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.SgcDataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.SgcDataGridView1.Location = New System.Drawing.Point(12, 157)
        Me.SgcDataGridView1.Name = "SgcDataGridView1"
        Me.SgcDataGridView1.Size = New System.Drawing.Size(374, 191)
        Me.SgcDataGridView1.TabIndex = 11
        '
        'SgcButton1
        '
        Me.SgcButton1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.SgcButton1.FlatAppearance.BorderColor = System.Drawing.Color.Silver
        Me.SgcButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.SgcButton1.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SgcButton1.ForeColor = System.Drawing.Color.SteelBlue
        Me.SgcButton1.Location = New System.Drawing.Point(132, 92)
        Me.SgcButton1.Name = "SgcButton1"
        Me.SgcButton1.Size = New System.Drawing.Size(75, 31)
        Me.SgcButton1.TabIndex = 11
        Me.SgcButton1.Text = "Buscar"
        Me.SgcButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.SgcButton1.UseVisualStyleBackColor = False
        '
        'frmBuscarPlan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 18.0!)
        Me.ClientSize = New System.Drawing.Size(395, 358)
        Me.Controls.Add(Me.SgcDataGridView1)
        Me.Controls.Add(Me.SgcGroupBox2)
        Me.Name = "frmBuscarPlan"
        Me.Text = "Buscar Plan"
        Me.SgcGroupBox2.ResumeLayout(False)
        Me.SgcGroupBox2.PerformLayout()
        CType(Me.SgcDataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SgcGroupBox2 As SGC_CS.SGCGroupBox
    Friend WithEvents SgcLabel2 As SGC_CS.SGCLabel
    Friend WithEvents SgcDataGridView1 As SGC_CS.SGCDataGridView
    Friend WithEvents SgcLabel3 As SGC_CS.SGCLabel
    Friend WithEvents SgcComboBox2 As SGC_CS.SGCComboBox
    Friend WithEvents SgcComboBox1 As SGC_CS.SGCComboBox
    Friend WithEvents SgcButton1 As SGC_CS.SGCButton

End Class
