<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRegistroPago
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
        Me.SgcGroupBox4 = New SGC_CS.SGCGroupBox(Me.components)
        Me.SgcButton2 = New SGC_CS.SGCButton(Me.components)
        Me.SgcTextBox5 = New SGC_CS.SGCTextBox(Me.components)
        Me.SgcLabel6 = New SGC_CS.SGCLabel(Me.components)
        Me.SgcTextBox6 = New SGC_CS.SGCTextBox(Me.components)
        Me.SgcLabel16 = New SGC_CS.SGCLabel(Me.components)
        Me.SgcGroupBox6 = New SGC_CS.SGCGroupBox(Me.components)
        Me.SgcDataGridView3 = New SGC_CS.SGCDataGridView(Me.components)
        Me.SgcGroupBox4.SuspendLayout()
        Me.SgcGroupBox6.SuspendLayout()
        CType(Me.SgcDataGridView3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SgcGroupBox4
        '
        Me.SgcGroupBox4.Controls.Add(Me.SgcButton2)
        Me.SgcGroupBox4.Controls.Add(Me.SgcTextBox5)
        Me.SgcGroupBox4.Controls.Add(Me.SgcLabel6)
        Me.SgcGroupBox4.Controls.Add(Me.SgcTextBox6)
        Me.SgcGroupBox4.Controls.Add(Me.SgcLabel16)
        Me.SgcGroupBox4.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SgcGroupBox4.Location = New System.Drawing.Point(60, 74)
        Me.SgcGroupBox4.Name = "SgcGroupBox4"
        Me.SgcGroupBox4.Size = New System.Drawing.Size(532, 145)
        Me.SgcGroupBox4.TabIndex = 23
        Me.SgcGroupBox4.TabStop = False
        Me.SgcGroupBox4.Text = "Socio"
        '
        'SgcButton2
        '
        Me.SgcButton2.BackColor = System.Drawing.Color.WhiteSmoke
        Me.SgcButton2.FlatAppearance.BorderColor = System.Drawing.Color.Silver
        Me.SgcButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.SgcButton2.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SgcButton2.ForeColor = System.Drawing.Color.SteelBlue
        Me.SgcButton2.Location = New System.Drawing.Point(227, 33)
        Me.SgcButton2.Name = "SgcButton2"
        Me.SgcButton2.Size = New System.Drawing.Size(43, 31)
        Me.SgcButton2.TabIndex = 21
        Me.SgcButton2.Text = "Buscar"
        Me.SgcButton2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.SgcButton2.UseVisualStyleBackColor = False
        '
        'SgcTextBox5
        '
        Me.SgcTextBox5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.SgcTextBox5.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SgcTextBox5.ForeColor = System.Drawing.Color.Black
        Me.SgcTextBox5.Location = New System.Drawing.Point(109, 69)
        Me.SgcTextBox5.Name = "SgcTextBox5"
        Me.SgcTextBox5.Size = New System.Drawing.Size(384, 26)
        Me.SgcTextBox5.TabIndex = 17
        '
        'SgcLabel6
        '
        Me.SgcLabel6.AutoSize = True
        Me.SgcLabel6.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SgcLabel6.ForeColor = System.Drawing.Color.SteelBlue
        Me.SgcLabel6.Location = New System.Drawing.Point(19, 71)
        Me.SgcLabel6.Name = "SgcLabel6"
        Me.SgcLabel6.Size = New System.Drawing.Size(63, 18)
        Me.SgcLabel6.TabIndex = 16
        Me.SgcLabel6.Text = "Nombre:"
        '
        'SgcTextBox6
        '
        Me.SgcTextBox6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.SgcTextBox6.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SgcTextBox6.ForeColor = System.Drawing.Color.Black
        Me.SgcTextBox6.Location = New System.Drawing.Point(109, 37)
        Me.SgcTextBox6.Name = "SgcTextBox6"
        Me.SgcTextBox6.Size = New System.Drawing.Size(100, 26)
        Me.SgcTextBox6.TabIndex = 3
        '
        'SgcLabel16
        '
        Me.SgcLabel16.AutoSize = True
        Me.SgcLabel16.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SgcLabel16.ForeColor = System.Drawing.Color.SteelBlue
        Me.SgcLabel16.Location = New System.Drawing.Point(19, 39)
        Me.SgcLabel16.Name = "SgcLabel16"
        Me.SgcLabel16.Size = New System.Drawing.Size(53, 18)
        Me.SgcLabel16.TabIndex = 0
        Me.SgcLabel16.Text = "Acción:"
        '
        'SgcGroupBox6
        '
        Me.SgcGroupBox6.Controls.Add(Me.SgcDataGridView3)
        Me.SgcGroupBox6.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SgcGroupBox6.Location = New System.Drawing.Point(60, 225)
        Me.SgcGroupBox6.Name = "SgcGroupBox6"
        Me.SgcGroupBox6.Size = New System.Drawing.Size(906, 211)
        Me.SgcGroupBox6.TabIndex = 25
        Me.SgcGroupBox6.TabStop = False
        Me.SgcGroupBox6.Text = "Inscritos"
        '
        'SgcDataGridView3
        '
        Me.SgcDataGridView3.AllowUserToAddRows = False
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.WhiteSmoke
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.SteelBlue
        Me.SgcDataGridView3.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle2
        Me.SgcDataGridView3.BackgroundColor = System.Drawing.Color.WhiteSmoke
        Me.SgcDataGridView3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.SgcDataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.SgcDataGridView3.Location = New System.Drawing.Point(18, 25)
        Me.SgcDataGridView3.Name = "SgcDataGridView3"
        Me.SgcDataGridView3.Size = New System.Drawing.Size(420, 97)
        Me.SgcDataGridView3.TabIndex = 1
        '
        'frmRegistroPago
        '
        Me.ClientSize = New System.Drawing.Size(1016, 733)
        Me.Controls.Add(Me.SgcGroupBox6)
        Me.Controls.Add(Me.SgcGroupBox4)
        Me.Name = "frmRegistroPago"
        Me.Controls.SetChildIndex(Me.SgcGroupBox4, 0)
        Me.Controls.SetChildIndex(Me.SgcGroupBox6, 0)
        Me.SgcGroupBox4.ResumeLayout(False)
        Me.SgcGroupBox4.PerformLayout()
        Me.SgcGroupBox6.ResumeLayout(False)
        CType(Me.SgcDataGridView3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SgcGroupBox4 As SGC_CS.SGCGroupBox
    Friend WithEvents SgcButton2 As SGC_CS.SGCButton
    Friend WithEvents SgcTextBox5 As SGC_CS.SGCTextBox
    Friend WithEvents SgcLabel6 As SGC_CS.SGCLabel
    Friend WithEvents SgcTextBox6 As SGC_CS.SGCTextBox
    Friend WithEvents SgcLabel16 As SGC_CS.SGCLabel
    Friend WithEvents SgcGroupBox6 As SGC_CS.SGCGroupBox
    Friend WithEvents SgcDataGridView3 As SGC_CS.SGCDataGridView

End Class
