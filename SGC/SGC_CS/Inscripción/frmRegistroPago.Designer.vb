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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.SgcGroupBox4 = New SGC_CS.SGCGroupBox(Me.components)
        Me.btnBuscar = New SGC_CS.SGCButton(Me.components)
        Me.txtNombre = New SGC_CS.SGCTextBox(Me.components)
        Me.SgcLabel6 = New SGC_CS.SGCLabel(Me.components)
        Me.txtAccion = New SGC_CS.SGCTextBox(Me.components)
        Me.SgcLabel16 = New SGC_CS.SGCLabel(Me.components)
        Me.SgcGroupBox6 = New SGC_CS.SGCGroupBox(Me.components)
        Me.txtTotal = New SGC_CS.SGCTextBox(Me.components)
        Me.SgcLabel12 = New SGC_CS.SGCLabel(Me.components)
        Me.txtObservacion = New SGC_CS.SGCTextBox(Me.components)
        Me.SgcLabel11 = New SGC_CS.SGCLabel(Me.components)
        Me.SgcLabel10 = New SGC_CS.SGCLabel(Me.components)
        Me.SgcLabel9 = New SGC_CS.SGCLabel(Me.components)
        Me.SgcLabel5 = New SGC_CS.SGCLabel(Me.components)
        Me.btnDocumento = New SGC_CS.SGCButton(Me.components)
        Me.SgcLabel1 = New SGC_CS.SGCLabel(Me.components)
        Me.SgcLabel4 = New SGC_CS.SGCLabel(Me.components)
        Me.SgcLabel8 = New SGC_CS.SGCLabel(Me.components)
        Me.dgvDocumentos = New SGC_CS.SGCDataGridView(Me.components)
        Me.SgcLabel3 = New SGC_CS.SGCLabel(Me.components)
        Me.SgcLabel7 = New SGC_CS.SGCLabel(Me.components)
        Me.SgcGroupBox1 = New SGC_CS.SGCGroupBox(Me.components)
        Me.cboTipoPago = New SGC_CS.SGCComboBox(Me.components)
        Me.SgcLabel2 = New SGC_CS.SGCLabel(Me.components)
        Me.lblTitulo = New SGC_CS.SGCLabel(Me.components)
        Me.SgcGroupBox4.SuspendLayout()
        Me.SgcGroupBox6.SuspendLayout()
        CType(Me.dgvDocumentos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SgcGroupBox1.SuspendLayout()
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
        Me.SgcGroupBox4.Location = New System.Drawing.Point(60, 74)
        Me.SgcGroupBox4.Name = "SgcGroupBox4"
        Me.SgcGroupBox4.Size = New System.Drawing.Size(532, 111)
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
        Me.SgcGroupBox6.Controls.Add(Me.txtTotal)
        Me.SgcGroupBox6.Controls.Add(Me.SgcLabel12)
        Me.SgcGroupBox6.Controls.Add(Me.txtObservacion)
        Me.SgcGroupBox6.Controls.Add(Me.SgcLabel11)
        Me.SgcGroupBox6.Controls.Add(Me.SgcLabel10)
        Me.SgcGroupBox6.Controls.Add(Me.SgcLabel9)
        Me.SgcGroupBox6.Controls.Add(Me.SgcLabel5)
        Me.SgcGroupBox6.Controls.Add(Me.btnDocumento)
        Me.SgcGroupBox6.Controls.Add(Me.SgcLabel1)
        Me.SgcGroupBox6.Controls.Add(Me.SgcLabel4)
        Me.SgcGroupBox6.Controls.Add(Me.SgcLabel8)
        Me.SgcGroupBox6.Controls.Add(Me.dgvDocumentos)
        Me.SgcGroupBox6.Controls.Add(Me.SgcLabel3)
        Me.SgcGroupBox6.Controls.Add(Me.SgcLabel7)
        Me.SgcGroupBox6.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SgcGroupBox6.Location = New System.Drawing.Point(60, 191)
        Me.SgcGroupBox6.Name = "SgcGroupBox6"
        Me.SgcGroupBox6.Size = New System.Drawing.Size(897, 347)
        Me.SgcGroupBox6.TabIndex = 25
        Me.SgcGroupBox6.TabStop = False
        Me.SgcGroupBox6.Text = "Documentos"
        '
        'txtTotal
        '
        Me.txtTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTotal.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotal.ForeColor = System.Drawing.Color.Black
        Me.txtTotal.Location = New System.Drawing.Point(733, 280)
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.Size = New System.Drawing.Size(149, 26)
        Me.txtTotal.TabIndex = 27
        '
        'SgcLabel12
        '
        Me.SgcLabel12.AutoSize = True
        Me.SgcLabel12.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SgcLabel12.ForeColor = System.Drawing.Color.SteelBlue
        Me.SgcLabel12.Location = New System.Drawing.Point(677, 282)
        Me.SgcLabel12.Name = "SgcLabel12"
        Me.SgcLabel12.Size = New System.Drawing.Size(42, 18)
        Me.SgcLabel12.TabIndex = 28
        Me.SgcLabel12.Text = "Total:"
        '
        'txtObservacion
        '
        Me.txtObservacion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtObservacion.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtObservacion.ForeColor = System.Drawing.Color.Black
        Me.txtObservacion.Location = New System.Drawing.Point(105, 255)
        Me.txtObservacion.Multiline = True
        Me.txtObservacion.Name = "txtObservacion"
        Me.txtObservacion.Size = New System.Drawing.Size(384, 77)
        Me.txtObservacion.TabIndex = 27
        '
        'SgcLabel11
        '
        Me.SgcLabel11.AutoSize = True
        Me.SgcLabel11.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SgcLabel11.ForeColor = System.Drawing.Color.SteelBlue
        Me.SgcLabel11.Location = New System.Drawing.Point(10, 257)
        Me.SgcLabel11.Name = "SgcLabel11"
        Me.SgcLabel11.Size = New System.Drawing.Size(89, 18)
        Me.SgcLabel11.TabIndex = 27
        Me.SgcLabel11.Text = "Observación:"
        '
        'SgcLabel10
        '
        Me.SgcLabel10.AutoSize = True
        Me.SgcLabel10.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SgcLabel10.ForeColor = System.Drawing.Color.Black
        Me.SgcLabel10.Location = New System.Drawing.Point(751, 32)
        Me.SgcLabel10.Name = "SgcLabel10"
        Me.SgcLabel10.Size = New System.Drawing.Size(0, 18)
        Me.SgcLabel10.TabIndex = 31
        '
        'SgcLabel9
        '
        Me.SgcLabel9.AutoSize = True
        Me.SgcLabel9.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SgcLabel9.ForeColor = System.Drawing.Color.Black
        Me.SgcLabel9.Location = New System.Drawing.Point(590, 32)
        Me.SgcLabel9.Name = "SgcLabel9"
        Me.SgcLabel9.Size = New System.Drawing.Size(0, 18)
        Me.SgcLabel9.TabIndex = 30
        '
        'SgcLabel5
        '
        Me.SgcLabel5.AutoSize = True
        Me.SgcLabel5.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SgcLabel5.ForeColor = System.Drawing.Color.Black
        Me.SgcLabel5.Location = New System.Drawing.Point(361, 32)
        Me.SgcLabel5.Name = "SgcLabel5"
        Me.SgcLabel5.Size = New System.Drawing.Size(0, 18)
        Me.SgcLabel5.TabIndex = 28
        '
        'btnDocumento
        '
        Me.btnDocumento.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnDocumento.FlatAppearance.BorderColor = System.Drawing.Color.Silver
        Me.btnDocumento.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDocumento.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDocumento.ForeColor = System.Drawing.Color.SteelBlue
        Me.btnDocumento.Image = Global.SGC_CS.My.Resources.Resources.btn_buscar
        Me.btnDocumento.Location = New System.Drawing.Point(109, 20)
        Me.btnDocumento.Name = "btnDocumento"
        Me.btnDocumento.Size = New System.Drawing.Size(45, 31)
        Me.btnDocumento.TabIndex = 26
        Me.btnDocumento.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnDocumento.UseVisualStyleBackColor = False
        '
        'SgcLabel1
        '
        Me.SgcLabel1.AutoSize = True
        Me.SgcLabel1.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SgcLabel1.ForeColor = System.Drawing.Color.SteelBlue
        Me.SgcLabel1.Location = New System.Drawing.Point(210, 32)
        Me.SgcLabel1.Name = "SgcLabel1"
        Me.SgcLabel1.Size = New System.Drawing.Size(133, 18)
        Me.SgcLabel1.TabIndex = 16
        Me.SgcLabel1.Text = "Tipo de Documento:"
        '
        'SgcLabel4
        '
        Me.SgcLabel4.AutoSize = True
        Me.SgcLabel4.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SgcLabel4.ForeColor = System.Drawing.Color.SteelBlue
        Me.SgcLabel4.Location = New System.Drawing.Point(668, 32)
        Me.SgcLabel4.Name = "SgcLabel4"
        Me.SgcLabel4.Size = New System.Drawing.Size(77, 18)
        Me.SgcLabel4.TabIndex = 27
        Me.SgcLabel4.Text = "Correlativo"
        '
        'SgcLabel8
        '
        Me.SgcLabel8.AutoSize = True
        Me.SgcLabel8.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SgcLabel8.ForeColor = System.Drawing.Color.SteelBlue
        Me.SgcLabel8.Location = New System.Drawing.Point(19, 32)
        Me.SgcLabel8.Name = "SgcLabel8"
        Me.SgcLabel8.Size = New System.Drawing.Size(84, 18)
        Me.SgcLabel8.TabIndex = 28
        Me.SgcLabel8.Text = "Documento:"
        '
        'dgvDocumentos
        '
        Me.dgvDocumentos.AllowUserToAddRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.WhiteSmoke
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.SteelBlue
        Me.dgvDocumentos.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvDocumentos.BackgroundColor = System.Drawing.Color.WhiteSmoke
        Me.dgvDocumentos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dgvDocumentos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDocumentos.Location = New System.Drawing.Point(13, 68)
        Me.dgvDocumentos.Name = "dgvDocumentos"
        Me.dgvDocumentos.Size = New System.Drawing.Size(869, 176)
        Me.dgvDocumentos.TabIndex = 1
        '
        'SgcLabel3
        '
        Me.SgcLabel3.AutoSize = True
        Me.SgcLabel3.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SgcLabel3.ForeColor = System.Drawing.Color.SteelBlue
        Me.SgcLabel3.Location = New System.Drawing.Point(544, 32)
        Me.SgcLabel3.Name = "SgcLabel3"
        Me.SgcLabel3.Size = New System.Drawing.Size(40, 18)
        Me.SgcLabel3.TabIndex = 20
        Me.SgcLabel3.Text = "Serie"
        '
        'SgcLabel7
        '
        Me.SgcLabel7.AutoSize = True
        Me.SgcLabel7.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SgcLabel7.ForeColor = System.Drawing.Color.SteelBlue
        Me.SgcLabel7.Location = New System.Drawing.Point(122, 26)
        Me.SgcLabel7.Name = "SgcLabel7"
        Me.SgcLabel7.Size = New System.Drawing.Size(0, 18)
        Me.SgcLabel7.TabIndex = 29
        '
        'SgcGroupBox1
        '
        Me.SgcGroupBox1.Controls.Add(Me.cboTipoPago)
        Me.SgcGroupBox1.Controls.Add(Me.SgcLabel2)
        Me.SgcGroupBox1.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SgcGroupBox1.Location = New System.Drawing.Point(610, 74)
        Me.SgcGroupBox1.Name = "SgcGroupBox1"
        Me.SgcGroupBox1.Size = New System.Drawing.Size(347, 111)
        Me.SgcGroupBox1.TabIndex = 26
        Me.SgcGroupBox1.TabStop = False
        Me.SgcGroupBox1.Text = "Pago"
        '
        'cboTipoPago
        '
        Me.cboTipoPago.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboTipoPago.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cboTipoPago.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboTipoPago.ForeColor = System.Drawing.Color.Black
        Me.cboTipoPago.FormattingEnabled = True
        Me.cboTipoPago.Location = New System.Drawing.Point(166, 36)
        Me.cboTipoPago.Name = "cboTipoPago"
        Me.cboTipoPago.Size = New System.Drawing.Size(171, 26)
        Me.cboTipoPago.TabIndex = 18
        '
        'SgcLabel2
        '
        Me.SgcLabel2.AutoSize = True
        Me.SgcLabel2.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SgcLabel2.ForeColor = System.Drawing.Color.SteelBlue
        Me.SgcLabel2.Location = New System.Drawing.Point(19, 39)
        Me.SgcLabel2.Name = "SgcLabel2"
        Me.SgcLabel2.Size = New System.Drawing.Size(91, 18)
        Me.SgcLabel2.TabIndex = 0
        Me.SgcLabel2.Text = "Tipo de Pago:"
        '
        'lblTitulo
        '
        Me.lblTitulo.AutoSize = True
        Me.lblTitulo.BackColor = System.Drawing.Color.ForestGreen
        Me.lblTitulo.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitulo.ForeColor = System.Drawing.Color.White
        Me.lblTitulo.Location = New System.Drawing.Point(425, 9)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(143, 23)
        Me.lblTitulo.TabIndex = 27
        Me.lblTitulo.Text = "Registro de Pago" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'frmRegistroPago
        '
        Me.ClientSize = New System.Drawing.Size(1016, 733)
        Me.Controls.Add(Me.lblTitulo)
        Me.Controls.Add(Me.SgcGroupBox1)
        Me.Controls.Add(Me.SgcGroupBox6)
        Me.Controls.Add(Me.SgcGroupBox4)
        Me.Name = "frmRegistroPago"
        Me.Controls.SetChildIndex(Me.SgcGroupBox4, 0)
        Me.Controls.SetChildIndex(Me.SgcGroupBox6, 0)
        Me.Controls.SetChildIndex(Me.SgcGroupBox1, 0)
        Me.Controls.SetChildIndex(Me.lblTitulo, 0)
        Me.SgcGroupBox4.ResumeLayout(False)
        Me.SgcGroupBox4.PerformLayout()
        Me.SgcGroupBox6.ResumeLayout(False)
        Me.SgcGroupBox6.PerformLayout()
        CType(Me.dgvDocumentos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SgcGroupBox1.ResumeLayout(False)
        Me.SgcGroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents SgcGroupBox4 As SGC_CS.SGCGroupBox
    Friend WithEvents txtNombre As SGC_CS.SGCTextBox
    Friend WithEvents SgcLabel6 As SGC_CS.SGCLabel
    Friend WithEvents txtAccion As SGC_CS.SGCTextBox
    Friend WithEvents SgcLabel16 As SGC_CS.SGCLabel
    Friend WithEvents SgcGroupBox6 As SGC_CS.SGCGroupBox
    Friend WithEvents dgvDocumentos As SGC_CS.SGCDataGridView
    Friend WithEvents btnBuscar As SGC_CS.SGCButton
    Friend WithEvents SgcGroupBox1 As SGC_CS.SGCGroupBox
    Friend WithEvents cboTipoPago As SGC_CS.SGCComboBox
    Friend WithEvents SgcLabel1 As SGC_CS.SGCLabel
    Friend WithEvents SgcLabel2 As SGC_CS.SGCLabel
    Friend WithEvents SgcLabel4 As SGC_CS.SGCLabel
    Friend WithEvents SgcLabel3 As SGC_CS.SGCLabel
    Friend WithEvents txtTotal As SGC_CS.SGCTextBox
    Friend WithEvents SgcLabel12 As SGC_CS.SGCLabel
    Friend WithEvents txtObservacion As SGC_CS.SGCTextBox
    Friend WithEvents SgcLabel11 As SGC_CS.SGCLabel
    Friend WithEvents SgcLabel10 As SGC_CS.SGCLabel
    Friend WithEvents SgcLabel9 As SGC_CS.SGCLabel
    Friend WithEvents SgcLabel5 As SGC_CS.SGCLabel
    Friend WithEvents btnDocumento As SGC_CS.SGCButton
    Friend WithEvents SgcLabel8 As SGC_CS.SGCLabel
    Friend WithEvents SgcLabel7 As SGC_CS.SGCLabel
    Friend WithEvents lblTitulo As SGC_CS.SGCLabel

End Class
