<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBuscarFamiliares
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
        Me.dgvListado = New SGC_CS.SGCDataGridView(Me.components)
        Me.gbxFiltros = New SGC_CS.SGCGroupBox(Me.components)
        Me.SgcButton2 = New SGC_CS.SGCButton(Me.components)
        Me.SgcTextBox5 = New SGC_CS.SGCTextBox(Me.components)
        Me.SgcLabel6 = New SGC_CS.SGCLabel(Me.components)
        Me.SgcTextBox6 = New SGC_CS.SGCTextBox(Me.components)
        Me.SgcLabel16 = New SGC_CS.SGCLabel(Me.components)
        Me.SgcButton1 = New SGC_CS.SGCButton(Me.components)
        CType(Me.dgvListado, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbxFiltros.SuspendLayout()
        Me.SuspendLayout()
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
        Me.dgvListado.Location = New System.Drawing.Point(9, 154)
        Me.dgvListado.Name = "dgvListado"
        Me.dgvListado.Size = New System.Drawing.Size(404, 206)
        Me.dgvListado.TabIndex = 27
        '
        'gbxFiltros
        '
        Me.gbxFiltros.Controls.Add(Me.SgcButton1)
        Me.gbxFiltros.Controls.Add(Me.SgcButton2)
        Me.gbxFiltros.Controls.Add(Me.SgcTextBox5)
        Me.gbxFiltros.Controls.Add(Me.SgcLabel6)
        Me.gbxFiltros.Controls.Add(Me.SgcTextBox6)
        Me.gbxFiltros.Controls.Add(Me.SgcLabel16)
        Me.gbxFiltros.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbxFiltros.Location = New System.Drawing.Point(9, 12)
        Me.gbxFiltros.Name = "gbxFiltros"
        Me.gbxFiltros.Size = New System.Drawing.Size(404, 136)
        Me.gbxFiltros.TabIndex = 28
        Me.gbxFiltros.TabStop = False
        Me.gbxFiltros.Text = "Filtros"
        '
        'SgcButton2
        '
        Me.SgcButton2.BackColor = System.Drawing.Color.WhiteSmoke
        Me.SgcButton2.FlatAppearance.BorderColor = System.Drawing.Color.Silver
        Me.SgcButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.SgcButton2.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SgcButton2.ForeColor = System.Drawing.Color.SteelBlue
        Me.SgcButton2.Image = Global.SGC_CS.My.Resources.Resources.btn_buscar
        Me.SgcButton2.Location = New System.Drawing.Point(223, 25)
        Me.SgcButton2.Name = "SgcButton2"
        Me.SgcButton2.Size = New System.Drawing.Size(43, 31)
        Me.SgcButton2.TabIndex = 26
        Me.SgcButton2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.SgcButton2.UseVisualStyleBackColor = False
        '
        'SgcTextBox5
        '
        Me.SgcTextBox5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.SgcTextBox5.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SgcTextBox5.ForeColor = System.Drawing.Color.Black
        Me.SgcTextBox5.Location = New System.Drawing.Point(105, 61)
        Me.SgcTextBox5.Name = "SgcTextBox5"
        Me.SgcTextBox5.Size = New System.Drawing.Size(277, 26)
        Me.SgcTextBox5.TabIndex = 25
        '
        'SgcLabel6
        '
        Me.SgcLabel6.AutoSize = True
        Me.SgcLabel6.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SgcLabel6.ForeColor = System.Drawing.Color.SteelBlue
        Me.SgcLabel6.Location = New System.Drawing.Point(15, 63)
        Me.SgcLabel6.Name = "SgcLabel6"
        Me.SgcLabel6.Size = New System.Drawing.Size(63, 18)
        Me.SgcLabel6.TabIndex = 24
        Me.SgcLabel6.Text = "Nombre:"
        '
        'SgcTextBox6
        '
        Me.SgcTextBox6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.SgcTextBox6.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SgcTextBox6.ForeColor = System.Drawing.Color.Black
        Me.SgcTextBox6.Location = New System.Drawing.Point(105, 29)
        Me.SgcTextBox6.Name = "SgcTextBox6"
        Me.SgcTextBox6.Size = New System.Drawing.Size(100, 26)
        Me.SgcTextBox6.TabIndex = 23
        '
        'SgcLabel16
        '
        Me.SgcLabel16.AutoSize = True
        Me.SgcLabel16.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SgcLabel16.ForeColor = System.Drawing.Color.SteelBlue
        Me.SgcLabel16.Location = New System.Drawing.Point(15, 31)
        Me.SgcLabel16.Name = "SgcLabel16"
        Me.SgcLabel16.Size = New System.Drawing.Size(53, 18)
        Me.SgcLabel16.TabIndex = 22
        Me.SgcLabel16.Text = "Acción:"
        '
        'SgcButton1
        '
        Me.SgcButton1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.SgcButton1.FlatAppearance.BorderColor = System.Drawing.Color.Silver
        Me.SgcButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.SgcButton1.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SgcButton1.ForeColor = System.Drawing.Color.SteelBlue
        Me.SgcButton1.Location = New System.Drawing.Point(139, 93)
        Me.SgcButton1.Name = "SgcButton1"
        Me.SgcButton1.Size = New System.Drawing.Size(85, 31)
        Me.SgcButton1.TabIndex = 27
        Me.SgcButton1.Text = "Buscar"
        Me.SgcButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.SgcButton1.UseVisualStyleBackColor = False
        '
        'frmBuscarFamiliares
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 18.0!)
        Me.ClientSize = New System.Drawing.Size(425, 372)
        Me.Controls.Add(Me.gbxFiltros)
        Me.Controls.Add(Me.dgvListado)
        Me.Name = "frmBuscarFamiliares"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Buscar Familiares"
        CType(Me.dgvListado, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbxFiltros.ResumeLayout(False)
        Me.gbxFiltros.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents dgvListado As SGC_CS.SGCDataGridView
    Friend WithEvents gbxFiltros As SGC_CS.SGCGroupBox
    Friend WithEvents SgcButton1 As SGC_CS.SGCButton
    Friend WithEvents SgcButton2 As SGC_CS.SGCButton
    Friend WithEvents SgcTextBox5 As SGC_CS.SGCTextBox
    Friend WithEvents SgcLabel6 As SGC_CS.SGCLabel
    Friend WithEvents SgcTextBox6 As SGC_CS.SGCTextBox
    Friend WithEvents SgcLabel16 As SGC_CS.SGCLabel

End Class
