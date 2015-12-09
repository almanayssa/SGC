<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRegistroAsistenciaParticipantes
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
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.SgcGroupBox1 = New SGC_CS.SGCGroupBox(Me.components)
        Me.SgcButton1 = New SGC_CS.SGCButton(Me.components)
        Me.SgcTextBox2 = New SGC_CS.SGCTextBox(Me.components)
        Me.SgcTextBox1 = New SGC_CS.SGCTextBox(Me.components)
        Me.SgcLabel1 = New SGC_CS.SGCLabel(Me.components)
        Me.SgcLabel11 = New SGC_CS.SGCLabel(Me.components)
        Me.SgcGroupBox2 = New SGC_CS.SGCGroupBox(Me.components)
        Me.SgcDataGridView1 = New SGC_CS.SGCDataGridView(Me.components)
        Me.SgcGroupBox6 = New SGC_CS.SGCGroupBox(Me.components)
        Me.SgcDataGridView3 = New SGC_CS.SGCDataGridView(Me.components)
        Me.SgcGroupBox1.SuspendLayout()
        Me.SgcGroupBox2.SuspendLayout()
        CType(Me.SgcDataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SgcGroupBox6.SuspendLayout()
        CType(Me.SgcDataGridView3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SgcGroupBox1
        '
        Me.SgcGroupBox1.Controls.Add(Me.SgcButton1)
        Me.SgcGroupBox1.Controls.Add(Me.SgcTextBox2)
        Me.SgcGroupBox1.Controls.Add(Me.SgcLabel11)
        Me.SgcGroupBox1.Controls.Add(Me.SgcTextBox1)
        Me.SgcGroupBox1.Controls.Add(Me.SgcLabel1)
        Me.SgcGroupBox1.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SgcGroupBox1.Location = New System.Drawing.Point(60, 65)
        Me.SgcGroupBox1.Name = "SgcGroupBox1"
        Me.SgcGroupBox1.Size = New System.Drawing.Size(513, 209)
        Me.SgcGroupBox1.TabIndex = 19
        Me.SgcGroupBox1.TabStop = False
        Me.SgcGroupBox1.Text = "Actividad"
        '
        'SgcButton1
        '
        Me.SgcButton1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.SgcButton1.FlatAppearance.BorderColor = System.Drawing.Color.Silver
        Me.SgcButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.SgcButton1.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SgcButton1.ForeColor = System.Drawing.Color.SteelBlue
        Me.SgcButton1.Image = Global.SGC_CS.My.Resources.Resources.btn_buscar
        Me.SgcButton1.Location = New System.Drawing.Point(215, 33)
        Me.SgcButton1.Name = "SgcButton1"
        Me.SgcButton1.Size = New System.Drawing.Size(45, 31)
        Me.SgcButton1.TabIndex = 25
        Me.SgcButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.SgcButton1.UseVisualStyleBackColor = False
        '
        'SgcTextBox2
        '
        Me.SgcTextBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.SgcTextBox2.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SgcTextBox2.ForeColor = System.Drawing.Color.Black
        Me.SgcTextBox2.Location = New System.Drawing.Point(109, 76)
        Me.SgcTextBox2.Multiline = True
        Me.SgcTextBox2.Name = "SgcTextBox2"
        Me.SgcTextBox2.Size = New System.Drawing.Size(384, 127)
        Me.SgcTextBox2.TabIndex = 17
        '
        'SgcTextBox1
        '
        Me.SgcTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.SgcTextBox1.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SgcTextBox1.ForeColor = System.Drawing.Color.Black
        Me.SgcTextBox1.Location = New System.Drawing.Point(109, 37)
        Me.SgcTextBox1.Name = "SgcTextBox1"
        Me.SgcTextBox1.Size = New System.Drawing.Size(100, 26)
        Me.SgcTextBox1.TabIndex = 3
        '
        'SgcLabel1
        '
        Me.SgcLabel1.AutoSize = True
        Me.SgcLabel1.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SgcLabel1.ForeColor = System.Drawing.Color.SteelBlue
        Me.SgcLabel1.Location = New System.Drawing.Point(19, 39)
        Me.SgcLabel1.Name = "SgcLabel1"
        Me.SgcLabel1.Size = New System.Drawing.Size(55, 18)
        Me.SgcLabel1.TabIndex = 0
        Me.SgcLabel1.Text = "Codigo:"
        '
        'SgcLabel11
        '
        Me.SgcLabel11.AutoSize = True
        Me.SgcLabel11.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SgcLabel11.ForeColor = System.Drawing.Color.SteelBlue
        Me.SgcLabel11.Location = New System.Drawing.Point(19, 76)
        Me.SgcLabel11.Name = "SgcLabel11"
        Me.SgcLabel11.Size = New System.Drawing.Size(70, 18)
        Me.SgcLabel11.TabIndex = 16
        Me.SgcLabel11.Text = "Actividad:"
        '
        'SgcGroupBox2
        '
        Me.SgcGroupBox2.Controls.Add(Me.SgcDataGridView1)
        Me.SgcGroupBox2.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SgcGroupBox2.Location = New System.Drawing.Point(589, 65)
        Me.SgcGroupBox2.Name = "SgcGroupBox2"
        Me.SgcGroupBox2.Size = New System.Drawing.Size(354, 209)
        Me.SgcGroupBox2.TabIndex = 26
        Me.SgcGroupBox2.TabStop = False
        Me.SgcGroupBox2.Text = "Programación"
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
        Me.SgcDataGridView1.Location = New System.Drawing.Point(18, 25)
        Me.SgcDataGridView1.Name = "SgcDataGridView1"
        Me.SgcDataGridView1.Size = New System.Drawing.Size(320, 178)
        Me.SgcDataGridView1.TabIndex = 1
        '
        'SgcGroupBox6
        '
        Me.SgcGroupBox6.Controls.Add(Me.SgcDataGridView3)
        Me.SgcGroupBox6.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SgcGroupBox6.Location = New System.Drawing.Point(60, 280)
        Me.SgcGroupBox6.Name = "SgcGroupBox6"
        Me.SgcGroupBox6.Size = New System.Drawing.Size(883, 296)
        Me.SgcGroupBox6.TabIndex = 27
        Me.SgcGroupBox6.TabStop = False
        Me.SgcGroupBox6.Text = "Inscritos"
        '
        'SgcDataGridView3
        '
        Me.SgcDataGridView3.AllowUserToAddRows = False
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.WhiteSmoke
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.SteelBlue
        Me.SgcDataGridView3.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle3
        Me.SgcDataGridView3.BackgroundColor = System.Drawing.Color.WhiteSmoke
        Me.SgcDataGridView3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.SgcDataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.SgcDataGridView3.Location = New System.Drawing.Point(18, 25)
        Me.SgcDataGridView3.Name = "SgcDataGridView3"
        Me.SgcDataGridView3.Size = New System.Drawing.Size(849, 254)
        Me.SgcDataGridView3.TabIndex = 1
        '
        'frmRegistroAsistenciaParticipantes
        '
        Me.ClientSize = New System.Drawing.Size(1016, 733)
        Me.Controls.Add(Me.SgcGroupBox6)
        Me.Controls.Add(Me.SgcGroupBox2)
        Me.Controls.Add(Me.SgcGroupBox1)
        Me.Name = "frmRegistroAsistenciaParticipantes"
        Me.Controls.SetChildIndex(Me.SgcGroupBox1, 0)
        Me.Controls.SetChildIndex(Me.SgcGroupBox2, 0)
        Me.Controls.SetChildIndex(Me.SgcGroupBox6, 0)
        Me.SgcGroupBox1.ResumeLayout(False)
        Me.SgcGroupBox1.PerformLayout()
        Me.SgcGroupBox2.ResumeLayout(False)
        CType(Me.SgcDataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SgcGroupBox6.ResumeLayout(False)
        CType(Me.SgcDataGridView3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SgcGroupBox1 As SGC_CS.SGCGroupBox
    Friend WithEvents SgcButton1 As SGC_CS.SGCButton
    Friend WithEvents SgcTextBox2 As SGC_CS.SGCTextBox
    Friend WithEvents SgcTextBox1 As SGC_CS.SGCTextBox
    Friend WithEvents SgcLabel1 As SGC_CS.SGCLabel
    Friend WithEvents SgcLabel11 As SGC_CS.SGCLabel
    Friend WithEvents SgcGroupBox2 As SGC_CS.SGCGroupBox
    Friend WithEvents SgcDataGridView1 As SGC_CS.SGCDataGridView
    Friend WithEvents SgcGroupBox6 As SGC_CS.SGCGroupBox
    Friend WithEvents SgcDataGridView3 As SGC_CS.SGCDataGridView

End Class
