<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBuscarComite
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
        Me.SgcButton1 = New SGC_CS.SGCButton(Me.components)
        Me.SgcTextBox1 = New SGC_CS.SGCTextBox(Me.components)
        Me.SgcLabel2 = New SGC_CS.SGCLabel(Me.components)
        Me.SgcDataGridView1 = New SGC_CS.SGCDataGridView(Me.components)
        Me.SgcGroupBox2.SuspendLayout()
        CType(Me.SgcDataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SgcGroupBox2
        '
        Me.SgcGroupBox2.Controls.Add(Me.SgcButton1)
        Me.SgcGroupBox2.Controls.Add(Me.SgcTextBox1)
        Me.SgcGroupBox2.Controls.Add(Me.SgcLabel2)
        Me.SgcGroupBox2.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SgcGroupBox2.Location = New System.Drawing.Point(12, 12)
        Me.SgcGroupBox2.Name = "SgcGroupBox2"
        Me.SgcGroupBox2.Size = New System.Drawing.Size(374, 103)
        Me.SgcGroupBox2.TabIndex = 18
        Me.SgcGroupBox2.TabStop = False
        Me.SgcGroupBox2.Text = "Filtros"
        '
        'SgcButton1
        '
        Me.SgcButton1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.SgcButton1.FlatAppearance.BorderColor = System.Drawing.Color.Silver
        Me.SgcButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.SgcButton1.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SgcButton1.ForeColor = System.Drawing.Color.SteelBlue
        Me.SgcButton1.Location = New System.Drawing.Point(124, 61)
        Me.SgcButton1.Name = "SgcButton1"
        Me.SgcButton1.Size = New System.Drawing.Size(75, 31)
        Me.SgcButton1.TabIndex = 8
        Me.SgcButton1.Text = "Buscar"
        Me.SgcButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.SgcButton1.UseVisualStyleBackColor = False
        '
        'SgcTextBox1
        '
        Me.SgcTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.SgcTextBox1.Enabled = False
        Me.SgcTextBox1.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SgcTextBox1.ForeColor = System.Drawing.Color.Black
        Me.SgcTextBox1.Location = New System.Drawing.Point(124, 29)
        Me.SgcTextBox1.Name = "SgcTextBox1"
        Me.SgcTextBox1.Size = New System.Drawing.Size(121, 26)
        Me.SgcTextBox1.TabIndex = 7
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
        Me.SgcLabel2.Text = "Comite:"
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
        Me.SgcDataGridView1.Location = New System.Drawing.Point(12, 121)
        Me.SgcDataGridView1.Name = "SgcDataGridView1"
        Me.SgcDataGridView1.Size = New System.Drawing.Size(374, 199)
        Me.SgcDataGridView1.TabIndex = 19
        '
        'frmBuscarComite
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 18.0!)
        Me.ClientSize = New System.Drawing.Size(397, 338)
        Me.Controls.Add(Me.SgcDataGridView1)
        Me.Controls.Add(Me.SgcGroupBox2)
        Me.Name = "frmBuscarComite"
        Me.Text = "Buscar Comité"
        Me.SgcGroupBox2.ResumeLayout(False)
        Me.SgcGroupBox2.PerformLayout()
        CType(Me.SgcDataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SgcGroupBox2 As SGC_CS.SGCGroupBox
    Friend WithEvents SgcLabel2 As SGC_CS.SGCLabel
    Friend WithEvents SgcTextBox1 As SGC_CS.SGCTextBox
    Friend WithEvents SgcDataGridView1 As SGC_CS.SGCDataGridView
    Friend WithEvents SgcButton1 As SGC_CS.SGCButton

End Class
