<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRegistroPlanAnual
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
        Me.lblTitulo = New SGC_CS.SGCLabel(Me.components)
        Me.gbPlan = New SGC_CS.SGCGroupBox(Me.components)
        Me.btnBuscar = New SGC_CS.SGCButton(Me.components)
        Me.btnPresupuesto = New SGC_CS.SGCButton(Me.components)
        Me.btnEditarPlan = New SGC_CS.SGCButton(Me.components)
        Me.btnGrabarPlan = New SGC_CS.SGCButton(Me.components)
        Me.lblEstado = New SGC_CS.SGCLabel(Me.components)
        Me.dtpFecFin = New SGC_CS.SGCDateTimePicker(Me.components)
        Me.dtpFecIni = New SGC_CS.SGCDateTimePicker(Me.components)
        Me.SgcLabel6 = New SGC_CS.SGCLabel(Me.components)
        Me.SgcLabel5 = New SGC_CS.SGCLabel(Me.components)
        Me.SgcLabel4 = New SGC_CS.SGCLabel(Me.components)
        Me.cboAnio = New SGC_CS.SGCComboBox(Me.components)
        Me.SgcLabel3 = New SGC_CS.SGCLabel(Me.components)
        Me.cboComite = New SGC_CS.SGCComboBox(Me.components)
        Me.SgcLabel2 = New SGC_CS.SGCLabel(Me.components)
        Me.txtCodigo = New SGC_CS.SGCTextBox(Me.components)
        Me.SgcLabel1 = New SGC_CS.SGCLabel(Me.components)
        Me.gbDetalle = New SGC_CS.SGCGroupBox(Me.components)
        Me.dgvActividades = New SGC_CS.SGCDataGridView(Me.components)
        Me.btnGrabarDetalle = New SGC_CS.SGCButton(Me.components)
        Me.gbPlan.SuspendLayout()
        Me.gbDetalle.SuspendLayout()
        CType(Me.dgvActividades, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblTitulo
        '
        Me.lblTitulo.AutoSize = True
        Me.lblTitulo.BackColor = System.Drawing.Color.ForestGreen
        Me.lblTitulo.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitulo.ForeColor = System.Drawing.Color.White
        Me.lblTitulo.Location = New System.Drawing.Point(428, 11)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(189, 23)
        Me.lblTitulo.TabIndex = 12
        Me.lblTitulo.Text = "Registro de Plan Anual"
        '
        'gbPlan
        '
        Me.gbPlan.Controls.Add(Me.btnBuscar)
        Me.gbPlan.Controls.Add(Me.btnPresupuesto)
        Me.gbPlan.Controls.Add(Me.btnEditarPlan)
        Me.gbPlan.Controls.Add(Me.btnGrabarPlan)
        Me.gbPlan.Controls.Add(Me.lblEstado)
        Me.gbPlan.Controls.Add(Me.dtpFecFin)
        Me.gbPlan.Controls.Add(Me.dtpFecIni)
        Me.gbPlan.Controls.Add(Me.SgcLabel6)
        Me.gbPlan.Controls.Add(Me.SgcLabel5)
        Me.gbPlan.Controls.Add(Me.SgcLabel4)
        Me.gbPlan.Controls.Add(Me.cboAnio)
        Me.gbPlan.Controls.Add(Me.SgcLabel3)
        Me.gbPlan.Controls.Add(Me.cboComite)
        Me.gbPlan.Controls.Add(Me.SgcLabel2)
        Me.gbPlan.Controls.Add(Me.txtCodigo)
        Me.gbPlan.Controls.Add(Me.SgcLabel1)
        Me.gbPlan.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbPlan.Location = New System.Drawing.Point(60, 70)
        Me.gbPlan.Name = "gbPlan"
        Me.gbPlan.Size = New System.Drawing.Size(900, 153)
        Me.gbPlan.TabIndex = 13
        Me.gbPlan.TabStop = False
        Me.gbPlan.Text = "Plan Anual"
        '
        'btnBuscar
        '
        Me.btnBuscar.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnBuscar.FlatAppearance.BorderColor = System.Drawing.Color.Silver
        Me.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBuscar.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBuscar.ForeColor = System.Drawing.Color.SteelBlue
        Me.btnBuscar.Image = Global.SGC_CS.My.Resources.Resources.btn_buscar
        Me.btnBuscar.Location = New System.Drawing.Point(254, 35)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(45, 31)
        Me.btnBuscar.TabIndex = 25
        Me.btnBuscar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnBuscar.UseVisualStyleBackColor = False
        '
        'btnPresupuesto
        '
        Me.btnPresupuesto.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnPresupuesto.Enabled = False
        Me.btnPresupuesto.FlatAppearance.BorderColor = System.Drawing.Color.Silver
        Me.btnPresupuesto.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPresupuesto.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPresupuesto.ForeColor = System.Drawing.Color.SteelBlue
        Me.btnPresupuesto.Location = New System.Drawing.Point(736, 104)
        Me.btnPresupuesto.Name = "btnPresupuesto"
        Me.btnPresupuesto.Size = New System.Drawing.Size(125, 31)
        Me.btnPresupuesto.TabIndex = 15
        Me.btnPresupuesto.Text = "Presupuesto"
        Me.btnPresupuesto.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnPresupuesto.UseVisualStyleBackColor = False
        '
        'btnEditarPlan
        '
        Me.btnEditarPlan.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnEditarPlan.Enabled = False
        Me.btnEditarPlan.FlatAppearance.BorderColor = System.Drawing.Color.Silver
        Me.btnEditarPlan.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEditarPlan.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEditarPlan.ForeColor = System.Drawing.Color.SteelBlue
        Me.btnEditarPlan.Location = New System.Drawing.Point(736, 69)
        Me.btnEditarPlan.Name = "btnEditarPlan"
        Me.btnEditarPlan.Size = New System.Drawing.Size(125, 31)
        Me.btnEditarPlan.TabIndex = 14
        Me.btnEditarPlan.Text = "Editar"
        Me.btnEditarPlan.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnEditarPlan.UseVisualStyleBackColor = False
        '
        'btnGrabarPlan
        '
        Me.btnGrabarPlan.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnGrabarPlan.FlatAppearance.BorderColor = System.Drawing.Color.Silver
        Me.btnGrabarPlan.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGrabarPlan.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGrabarPlan.ForeColor = System.Drawing.Color.SteelBlue
        Me.btnGrabarPlan.Location = New System.Drawing.Point(736, 34)
        Me.btnGrabarPlan.Name = "btnGrabarPlan"
        Me.btnGrabarPlan.Size = New System.Drawing.Size(125, 31)
        Me.btnGrabarPlan.TabIndex = 13
        Me.btnGrabarPlan.Text = "Grabar"
        Me.btnGrabarPlan.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnGrabarPlan.UseVisualStyleBackColor = False
        '
        'lblEstado
        '
        Me.lblEstado.AutoSize = True
        Me.lblEstado.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEstado.ForeColor = System.Drawing.Color.Black
        Me.lblEstado.Location = New System.Drawing.Point(525, 110)
        Me.lblEstado.Name = "lblEstado"
        Me.lblEstado.Size = New System.Drawing.Size(49, 18)
        Me.lblEstado.TabIndex = 12
        Me.lblEstado.Text = "Nuevo"
        '
        'dtpFecFin
        '
        Me.dtpFecFin.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFecFin.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFecFin.Location = New System.Drawing.Point(528, 69)
        Me.dtpFecFin.Name = "dtpFecFin"
        Me.dtpFecFin.Size = New System.Drawing.Size(100, 26)
        Me.dtpFecFin.TabIndex = 11
        '
        'dtpFecIni
        '
        Me.dtpFecIni.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFecIni.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFecIni.Location = New System.Drawing.Point(528, 34)
        Me.dtpFecIni.Name = "dtpFecIni"
        Me.dtpFecIni.Size = New System.Drawing.Size(100, 26)
        Me.dtpFecIni.TabIndex = 10
        '
        'SgcLabel6
        '
        Me.SgcLabel6.AutoSize = True
        Me.SgcLabel6.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SgcLabel6.ForeColor = System.Drawing.Color.SteelBlue
        Me.SgcLabel6.Location = New System.Drawing.Point(437, 110)
        Me.SgcLabel6.Name = "SgcLabel6"
        Me.SgcLabel6.Size = New System.Drawing.Size(53, 18)
        Me.SgcLabel6.TabIndex = 9
        Me.SgcLabel6.Text = "Estado:"
        '
        'SgcLabel5
        '
        Me.SgcLabel5.AutoSize = True
        Me.SgcLabel5.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SgcLabel5.ForeColor = System.Drawing.Color.SteelBlue
        Me.SgcLabel5.Location = New System.Drawing.Point(437, 75)
        Me.SgcLabel5.Name = "SgcLabel5"
        Me.SgcLabel5.Size = New System.Drawing.Size(70, 18)
        Me.SgcLabel5.TabIndex = 8
        Me.SgcLabel5.Text = "Fecha Fin:"
        '
        'SgcLabel4
        '
        Me.SgcLabel4.AutoSize = True
        Me.SgcLabel4.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SgcLabel4.ForeColor = System.Drawing.Color.SteelBlue
        Me.SgcLabel4.Location = New System.Drawing.Point(437, 40)
        Me.SgcLabel4.Name = "SgcLabel4"
        Me.SgcLabel4.Size = New System.Drawing.Size(85, 18)
        Me.SgcLabel4.TabIndex = 7
        Me.SgcLabel4.Text = "Fecha Inicio:"
        '
        'cboAnio
        '
        Me.cboAnio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboAnio.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cboAnio.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboAnio.ForeColor = System.Drawing.Color.Black
        Me.cboAnio.FormattingEnabled = True
        Me.cboAnio.Location = New System.Drawing.Point(127, 107)
        Me.cboAnio.Name = "cboAnio"
        Me.cboAnio.Size = New System.Drawing.Size(121, 26)
        Me.cboAnio.TabIndex = 6
        '
        'SgcLabel3
        '
        Me.SgcLabel3.AutoSize = True
        Me.SgcLabel3.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SgcLabel3.ForeColor = System.Drawing.Color.SteelBlue
        Me.SgcLabel3.Location = New System.Drawing.Point(32, 110)
        Me.SgcLabel3.Name = "SgcLabel3"
        Me.SgcLabel3.Size = New System.Drawing.Size(37, 18)
        Me.SgcLabel3.TabIndex = 5
        Me.SgcLabel3.Text = "Año:"
        '
        'cboComite
        '
        Me.cboComite.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboComite.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cboComite.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboComite.ForeColor = System.Drawing.Color.Black
        Me.cboComite.FormattingEnabled = True
        Me.cboComite.Location = New System.Drawing.Point(127, 72)
        Me.cboComite.Name = "cboComite"
        Me.cboComite.Size = New System.Drawing.Size(170, 26)
        Me.cboComite.TabIndex = 4
        '
        'SgcLabel2
        '
        Me.SgcLabel2.AutoSize = True
        Me.SgcLabel2.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SgcLabel2.ForeColor = System.Drawing.Color.SteelBlue
        Me.SgcLabel2.Location = New System.Drawing.Point(32, 75)
        Me.SgcLabel2.Name = "SgcLabel2"
        Me.SgcLabel2.Size = New System.Drawing.Size(57, 18)
        Me.SgcLabel2.TabIndex = 3
        Me.SgcLabel2.Text = "Comité:"
        '
        'txtCodigo
        '
        Me.txtCodigo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCodigo.Enabled = False
        Me.txtCodigo.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCodigo.ForeColor = System.Drawing.Color.Black
        Me.txtCodigo.Location = New System.Drawing.Point(127, 38)
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.Size = New System.Drawing.Size(121, 26)
        Me.txtCodigo.TabIndex = 1
        '
        'SgcLabel1
        '
        Me.SgcLabel1.AutoSize = True
        Me.SgcLabel1.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SgcLabel1.ForeColor = System.Drawing.Color.SteelBlue
        Me.SgcLabel1.Location = New System.Drawing.Point(32, 40)
        Me.SgcLabel1.Name = "SgcLabel1"
        Me.SgcLabel1.Size = New System.Drawing.Size(78, 18)
        Me.SgcLabel1.TabIndex = 0
        Me.SgcLabel1.Text = "Plan Anual:"
        '
        'gbDetalle
        '
        Me.gbDetalle.Controls.Add(Me.dgvActividades)
        Me.gbDetalle.Controls.Add(Me.btnGrabarDetalle)
        Me.gbDetalle.Enabled = False
        Me.gbDetalle.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbDetalle.Location = New System.Drawing.Point(60, 240)
        Me.gbDetalle.Name = "gbDetalle"
        Me.gbDetalle.Size = New System.Drawing.Size(900, 423)
        Me.gbDetalle.TabIndex = 14
        Me.gbDetalle.TabStop = False
        Me.gbDetalle.Text = "Actividades"
        '
        'dgvActividades
        '
        Me.dgvActividades.AllowUserToAddRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.WhiteSmoke
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.SteelBlue
        Me.dgvActividades.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvActividades.BackgroundColor = System.Drawing.Color.WhiteSmoke
        Me.dgvActividades.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dgvActividades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvActividades.Location = New System.Drawing.Point(13, 69)
        Me.dgvActividades.Name = "dgvActividades"
        Me.dgvActividades.Size = New System.Drawing.Size(875, 340)
        Me.dgvActividades.TabIndex = 16
        '
        'btnGrabarDetalle
        '
        Me.btnGrabarDetalle.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnGrabarDetalle.FlatAppearance.BorderColor = System.Drawing.Color.Silver
        Me.btnGrabarDetalle.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGrabarDetalle.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGrabarDetalle.ForeColor = System.Drawing.Color.SteelBlue
        Me.btnGrabarDetalle.Location = New System.Drawing.Point(13, 25)
        Me.btnGrabarDetalle.Name = "btnGrabarDetalle"
        Me.btnGrabarDetalle.Size = New System.Drawing.Size(125, 31)
        Me.btnGrabarDetalle.TabIndex = 14
        Me.btnGrabarDetalle.Text = "Grabar"
        Me.btnGrabarDetalle.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnGrabarDetalle.UseVisualStyleBackColor = False
        '
        'frmRegistroPlanAnual
        '
        Me.ClientSize = New System.Drawing.Size(1016, 733)
        Me.Controls.Add(Me.gbDetalle)
        Me.Controls.Add(Me.gbPlan)
        Me.Controls.Add(Me.lblTitulo)
        Me.Name = "frmRegistroPlanAnual"
        Me.Controls.SetChildIndex(Me.lblTitulo, 0)
        Me.Controls.SetChildIndex(Me.gbPlan, 0)
        Me.Controls.SetChildIndex(Me.gbDetalle, 0)
        Me.gbPlan.ResumeLayout(False)
        Me.gbPlan.PerformLayout()
        Me.gbDetalle.ResumeLayout(False)
        CType(Me.dgvActividades, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblTitulo As SGC_CS.SGCLabel
    Friend WithEvents gbPlan As SGC_CS.SGCGroupBox
    Friend WithEvents txtCodigo As SGC_CS.SGCTextBox
    Friend WithEvents SgcLabel1 As SGC_CS.SGCLabel
    Friend WithEvents SgcLabel6 As SGC_CS.SGCLabel
    Friend WithEvents SgcLabel5 As SGC_CS.SGCLabel
    Friend WithEvents SgcLabel4 As SGC_CS.SGCLabel
    Friend WithEvents cboAnio As SGC_CS.SGCComboBox
    Friend WithEvents SgcLabel3 As SGC_CS.SGCLabel
    Friend WithEvents cboComite As SGC_CS.SGCComboBox
    Friend WithEvents SgcLabel2 As SGC_CS.SGCLabel
    Friend WithEvents btnEditarPlan As SGC_CS.SGCButton
    Friend WithEvents btnGrabarPlan As SGC_CS.SGCButton
    Friend WithEvents lblEstado As SGC_CS.SGCLabel
    Friend WithEvents dtpFecFin As SGC_CS.SGCDateTimePicker
    Friend WithEvents dtpFecIni As SGC_CS.SGCDateTimePicker
    Friend WithEvents gbDetalle As SGC_CS.SGCGroupBox
    Friend WithEvents dgvActividades As SGC_CS.SGCDataGridView
    Friend WithEvents btnGrabarDetalle As SGC_CS.SGCButton
    Friend WithEvents btnPresupuesto As SGC_CS.SGCButton
    Friend WithEvents btnBuscar As SGC_CS.SGCButton

End Class
