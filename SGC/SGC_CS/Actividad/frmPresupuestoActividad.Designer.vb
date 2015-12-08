<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPresupuestoActividad
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
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.SgcGroupBox2 = New SGC_CS.SGCGroupBox(Me.components)
        Me.SgcTextBox1 = New SGC_CS.SGCTextBox(Me.components)
        Me.SgcButton2 = New SGC_CS.SGCButton(Me.components)
        Me.SgcDataGridView1 = New SGC_CS.SGCDataGridView(Me.components)
        Me.lblTitulo = New SGC_CS.SGCLabel(Me.components)
        Me.SgcButton1 = New SGC_CS.SGCButton(Me.components)
        Me.SgcGroupBox2.SuspendLayout()
        CType(Me.SgcDataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SgcGroupBox2
        '
        Me.SgcGroupBox2.Controls.Add(Me.SgcButton1)
        Me.SgcGroupBox2.Controls.Add(Me.SgcTextBox1)
        Me.SgcGroupBox2.Controls.Add(Me.SgcButton2)
        Me.SgcGroupBox2.Controls.Add(Me.SgcDataGridView1)
        Me.SgcGroupBox2.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SgcGroupBox2.Location = New System.Drawing.Point(12, 89)
        Me.SgcGroupBox2.Name = "SgcGroupBox2"
        Me.SgcGroupBox2.Size = New System.Drawing.Size(441, 260)
        Me.SgcGroupBox2.TabIndex = 16
        Me.SgcGroupBox2.TabStop = False
        Me.SgcGroupBox2.Text = "Items"
        '
        'SgcTextBox1
        '
        Me.SgcTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.SgcTextBox1.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SgcTextBox1.ForeColor = System.Drawing.Color.Black
        Me.SgcTextBox1.Location = New System.Drawing.Point(321, 220)
        Me.SgcTextBox1.Name = "SgcTextBox1"
        Me.SgcTextBox1.Size = New System.Drawing.Size(100, 26)
        Me.SgcTextBox1.TabIndex = 19
        '
        'SgcButton2
        '
        Me.SgcButton2.BackColor = System.Drawing.Color.WhiteSmoke
        Me.SgcButton2.FlatAppearance.BorderColor = System.Drawing.Color.Silver
        Me.SgcButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.SgcButton2.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SgcButton2.ForeColor = System.Drawing.Color.SteelBlue
        Me.SgcButton2.Location = New System.Drawing.Point(13, 216)
        Me.SgcButton2.Name = "SgcButton2"
        Me.SgcButton2.Size = New System.Drawing.Size(75, 31)
        Me.SgcButton2.TabIndex = 10
        Me.SgcButton2.Text = "Agregar"
        Me.SgcButton2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.SgcButton2.UseVisualStyleBackColor = False
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
        Me.SgcDataGridView1.Location = New System.Drawing.Point(13, 26)
        Me.SgcDataGridView1.Name = "SgcDataGridView1"
        Me.SgcDataGridView1.Size = New System.Drawing.Size(408, 184)
        Me.SgcDataGridView1.TabIndex = 0
        '
        'lblTitulo
        '
        Me.lblTitulo.AutoSize = True
        Me.lblTitulo.BackColor = System.Drawing.Color.White
        Me.lblTitulo.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitulo.ForeColor = System.Drawing.Color.ForestGreen
        Me.lblTitulo.Location = New System.Drawing.Point(118, 18)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(212, 23)
        Me.lblTitulo.TabIndex = 17
        Me.lblTitulo.Text = "Presupuesto de Actividad"
        '
        'SgcButton1
        '
        Me.SgcButton1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.SgcButton1.FlatAppearance.BorderColor = System.Drawing.Color.Silver
        Me.SgcButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.SgcButton1.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SgcButton1.ForeColor = System.Drawing.Color.SteelBlue
        Me.SgcButton1.Location = New System.Drawing.Point(94, 216)
        Me.SgcButton1.Name = "SgcButton1"
        Me.SgcButton1.Size = New System.Drawing.Size(75, 31)
        Me.SgcButton1.TabIndex = 20
        Me.SgcButton1.Text = "Quitar"
        Me.SgcButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.SgcButton1.UseVisualStyleBackColor = False
        '
        'frmPresupuestoActividad
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 18.0!)
        Me.ClientSize = New System.Drawing.Size(474, 364)
        Me.Controls.Add(Me.lblTitulo)
        Me.Controls.Add(Me.SgcGroupBox2)
        Me.Name = "frmPresupuestoActividad"
        Me.SgcGroupBox2.ResumeLayout(False)
        Me.SgcGroupBox2.PerformLayout()
        CType(Me.SgcDataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents SgcGroupBox2 As SGC_CS.SGCGroupBox
    Friend WithEvents SgcTextBox1 As SGC_CS.SGCTextBox
    Friend WithEvents SgcButton2 As SGC_CS.SGCButton
    Friend WithEvents SgcDataGridView1 As SGC_CS.SGCDataGridView
    Friend WithEvents SgcButton1 As SGC_CS.SGCButton
    Friend WithEvents lblTitulo As SGC_CS.SGCLabel

End Class
