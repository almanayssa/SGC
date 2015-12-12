<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSuscripcionComite
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
        Me.SgcGroupBox4 = New SGC_CS.SGCGroupBox(Me.components)
        Me.btnBuscar = New SGC_CS.SGCButton(Me.components)
        Me.txtNombre = New SGC_CS.SGCTextBox(Me.components)
        Me.SgcLabel6 = New SGC_CS.SGCLabel(Me.components)
        Me.txtAccion = New SGC_CS.SGCTextBox(Me.components)
        Me.SgcLabel16 = New SGC_CS.SGCLabel(Me.components)
        Me.SgcGroupBox6 = New SGC_CS.SGCGroupBox(Me.components)
        Me.dgvComites = New SGC_CS.SGCDataGridView(Me.components)
        Me.lblTitulo = New SGC_CS.SGCLabel(Me.components)
        Me.SgcGroupBox4.SuspendLayout()
        Me.SgcGroupBox6.SuspendLayout()
        CType(Me.dgvComites, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SgcGroupBox4
        '
        Me.SgcGroupBox4.Controls.Add(Me.btnBuscar)
        Me.SgcGroupBox4.Controls.Add(Me.txtNombre)
        Me.SgcGroupBox4.Controls.Add(Me.SgcLabel6)
        Me.SgcGroupBox4.Controls.Add(Me.txtAccion)
        Me.SgcGroupBox4.Controls.Add(Me.SgcLabel16)
        Me.SgcGroupBox4.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SgcGroupBox4.Location = New System.Drawing.Point(60, 71)
        Me.SgcGroupBox4.Name = "SgcGroupBox4"
        Me.SgcGroupBox4.Size = New System.Drawing.Size(532, 145)
        Me.SgcGroupBox4.TabIndex = 23
        Me.SgcGroupBox4.TabStop = False
        Me.SgcGroupBox4.Text = "Socio"
        '
        'btnBuscar
        '
        Me.btnBuscar.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnBuscar.FlatAppearance.BorderColor = System.Drawing.Color.Silver
        Me.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBuscar.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBuscar.ForeColor = System.Drawing.Color.SteelBlue
        Me.btnBuscar.Image = Global.SGC_CS.My.Resources.Resources.btn_buscar
        Me.btnBuscar.Location = New System.Drawing.Point(215, 33)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(45, 31)
        Me.btnBuscar.TabIndex = 25
        Me.btnBuscar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnBuscar.UseVisualStyleBackColor = False
        '
        'txtNombre
        '
        Me.txtNombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNombre.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombre.ForeColor = System.Drawing.Color.Black
        Me.txtNombre.Location = New System.Drawing.Point(109, 69)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(384, 26)
        Me.txtNombre.TabIndex = 17
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
        'txtAccion
        '
        Me.txtAccion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtAccion.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAccion.ForeColor = System.Drawing.Color.Black
        Me.txtAccion.Location = New System.Drawing.Point(109, 37)
        Me.txtAccion.Name = "txtAccion"
        Me.txtAccion.Size = New System.Drawing.Size(100, 26)
        Me.txtAccion.TabIndex = 3
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
        Me.SgcGroupBox6.Controls.Add(Me.dgvComites)
        Me.SgcGroupBox6.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SgcGroupBox6.Location = New System.Drawing.Point(60, 234)
        Me.SgcGroupBox6.Name = "SgcGroupBox6"
        Me.SgcGroupBox6.Size = New System.Drawing.Size(532, 330)
        Me.SgcGroupBox6.TabIndex = 26
        Me.SgcGroupBox6.TabStop = False
        Me.SgcGroupBox6.Text = "Comites"
        '
        'dgvComites
        '
        Me.dgvComites.AllowUserToAddRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.WhiteSmoke
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.SteelBlue
        Me.dgvComites.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvComites.BackgroundColor = System.Drawing.Color.WhiteSmoke
        Me.dgvComites.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dgvComites.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvComites.Location = New System.Drawing.Point(18, 25)
        Me.dgvComites.Name = "dgvComites"
        Me.dgvComites.Size = New System.Drawing.Size(491, 283)
        Me.dgvComites.TabIndex = 1
        '
        'lblTitulo
        '
        Me.lblTitulo.AutoSize = True
        Me.lblTitulo.BackColor = System.Drawing.Color.ForestGreen
        Me.lblTitulo.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitulo.ForeColor = System.Drawing.Color.White
        Me.lblTitulo.Location = New System.Drawing.Point(425, 9)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(174, 23)
        Me.lblTitulo.TabIndex = 28
        Me.lblTitulo.Text = "Suscripción a Comité"
        '
        'frmSuscripcionComite
        '
        Me.ClientSize = New System.Drawing.Size(1016, 733)
        Me.Controls.Add(Me.lblTitulo)
        Me.Controls.Add(Me.SgcGroupBox6)
        Me.Controls.Add(Me.SgcGroupBox4)
        Me.Name = "frmSuscripcionComite"
        Me.Controls.SetChildIndex(Me.SgcGroupBox4, 0)
        Me.Controls.SetChildIndex(Me.SgcGroupBox6, 0)
        Me.Controls.SetChildIndex(Me.lblTitulo, 0)
        Me.SgcGroupBox4.ResumeLayout(False)
        Me.SgcGroupBox4.PerformLayout()
        Me.SgcGroupBox6.ResumeLayout(False)
        CType(Me.dgvComites, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents SgcGroupBox4 As SGC_CS.SGCGroupBox
    Friend WithEvents txtNombre As SGC_CS.SGCTextBox
    Friend WithEvents SgcLabel6 As SGC_CS.SGCLabel
    Friend WithEvents txtAccion As SGC_CS.SGCTextBox
    Friend WithEvents SgcLabel16 As SGC_CS.SGCLabel
    Friend WithEvents SgcGroupBox6 As SGC_CS.SGCGroupBox
    Friend WithEvents dgvComites As SGC_CS.SGCDataGridView
    Friend WithEvents btnBuscar As SGC_CS.SGCButton
    Friend WithEvents lblTitulo As SGC_CS.SGCLabel

End Class
