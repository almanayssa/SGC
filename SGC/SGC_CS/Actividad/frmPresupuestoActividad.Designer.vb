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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.SgcGroupBox2 = New SGC_CS.SGCGroupBox(Me.components)
        Me.btnQuitar = New SGC_CS.SGCButton(Me.components)
        Me.SgcTextBox1 = New SGC_CS.SGCTextBox(Me.components)
        Me.btnAgregar = New SGC_CS.SGCButton(Me.components)
        Me.dgvPresupuesto = New SGC_CS.SGCDataGridView(Me.components)
        Me.lblTitulo = New SGC_CS.SGCLabel(Me.components)
        Me.SgcGroupBox2.SuspendLayout()
        CType(Me.dgvPresupuesto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SgcGroupBox2
        '
        Me.SgcGroupBox2.Controls.Add(Me.btnQuitar)
        Me.SgcGroupBox2.Controls.Add(Me.SgcTextBox1)
        Me.SgcGroupBox2.Controls.Add(Me.btnAgregar)
        Me.SgcGroupBox2.Controls.Add(Me.dgvPresupuesto)
        Me.SgcGroupBox2.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SgcGroupBox2.Location = New System.Drawing.Point(12, 89)
        Me.SgcGroupBox2.Name = "SgcGroupBox2"
        Me.SgcGroupBox2.Size = New System.Drawing.Size(441, 260)
        Me.SgcGroupBox2.TabIndex = 16
        Me.SgcGroupBox2.TabStop = False
        Me.SgcGroupBox2.Text = "Items"
        '
        'btnQuitar
        '
        Me.btnQuitar.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnQuitar.FlatAppearance.BorderColor = System.Drawing.Color.Silver
        Me.btnQuitar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnQuitar.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnQuitar.ForeColor = System.Drawing.Color.SteelBlue
        Me.btnQuitar.Location = New System.Drawing.Point(94, 216)
        Me.btnQuitar.Name = "btnQuitar"
        Me.btnQuitar.Size = New System.Drawing.Size(75, 31)
        Me.btnQuitar.TabIndex = 20
        Me.btnQuitar.Text = "Quitar"
        Me.btnQuitar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnQuitar.UseVisualStyleBackColor = False
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
        'btnAgregar
        '
        Me.btnAgregar.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnAgregar.FlatAppearance.BorderColor = System.Drawing.Color.Silver
        Me.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAgregar.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAgregar.ForeColor = System.Drawing.Color.SteelBlue
        Me.btnAgregar.Location = New System.Drawing.Point(13, 216)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(75, 31)
        Me.btnAgregar.TabIndex = 10
        Me.btnAgregar.Text = "Agregar"
        Me.btnAgregar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnAgregar.UseVisualStyleBackColor = False
        '
        'dgvPresupuesto
        '
        Me.dgvPresupuesto.AllowUserToAddRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.WhiteSmoke
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.SteelBlue
        Me.dgvPresupuesto.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvPresupuesto.BackgroundColor = System.Drawing.Color.WhiteSmoke
        Me.dgvPresupuesto.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dgvPresupuesto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvPresupuesto.Location = New System.Drawing.Point(13, 26)
        Me.dgvPresupuesto.Name = "dgvPresupuesto"
        Me.dgvPresupuesto.Size = New System.Drawing.Size(408, 184)
        Me.dgvPresupuesto.TabIndex = 0
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
        'frmPresupuestoActividad
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 18.0!)
        Me.ClientSize = New System.Drawing.Size(474, 364)
        Me.Controls.Add(Me.lblTitulo)
        Me.Controls.Add(Me.SgcGroupBox2)
        Me.Name = "frmPresupuestoActividad"
        Me.SgcGroupBox2.ResumeLayout(False)
        Me.SgcGroupBox2.PerformLayout()
        CType(Me.dgvPresupuesto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents SgcGroupBox2 As SGC_CS.SGCGroupBox
    Friend WithEvents SgcTextBox1 As SGC_CS.SGCTextBox
    Friend WithEvents btnAgregar As SGC_CS.SGCButton
    Friend WithEvents dgvPresupuesto As SGC_CS.SGCDataGridView
    Friend WithEvents btnQuitar As SGC_CS.SGCButton
    Friend WithEvents lblTitulo As SGC_CS.SGCLabel

End Class
