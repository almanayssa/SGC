﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRegistroOpcion
    Inherits SGC_CS.frmPadre

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
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
        Me.SgcGroupBox1 = New SGC_CS.SGCGroupBox(Me.components)
        Me.lblCodigo = New SGC_CS.SGCLabel(Me.components)
        Me.btnBuscar = New SGC_CS.SGCButton(Me.components)
        Me.txtCodigo = New SGC_CS.SGCTextBox(Me.components)
        Me.txtEspacio = New SGC_CS.SGCTextBox(Me.components)
        Me.SgcLabel3 = New SGC_CS.SGCLabel(Me.components)
        Me.tsMenu = New SGC_CS.SGCToolStrip(Me.components)
        Me.tsbLimpiar = New System.Windows.Forms.ToolStripButton()
        Me.tsbGuardar = New System.Windows.Forms.ToolStripButton()
        Me.tsbEditar = New System.Windows.Forms.ToolStripButton()
        Me.tsbEliminar = New System.Windows.Forms.ToolStripButton()
        Me.tsbCancelar = New System.Windows.Forms.ToolStripButton()
        Me.SgcGroupBox2 = New SGC_CS.SGCGroupBox(Me.components)
        Me.dgvOpciones = New SGC_CS.SGCDataGridView(Me.components)
        Me.colSeleccionar = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.colPantalla = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SgcGroupBox1.SuspendLayout()
        Me.tsMenu.SuspendLayout()
        Me.SgcGroupBox2.SuspendLayout()
        CType(Me.dgvOpciones, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblTitulo
        '
        Me.lblTitulo.AutoSize = True
        Me.lblTitulo.BackColor = System.Drawing.Color.ForestGreen
        Me.lblTitulo.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitulo.ForeColor = System.Drawing.Color.White
        Me.lblTitulo.Location = New System.Drawing.Point(401, 11)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(179, 23)
        Me.lblTitulo.TabIndex = 16
        Me.lblTitulo.Text = "Registro de Opciones"
        '
        'SgcGroupBox1
        '
        Me.SgcGroupBox1.Controls.Add(Me.lblCodigo)
        Me.SgcGroupBox1.Controls.Add(Me.btnBuscar)
        Me.SgcGroupBox1.Controls.Add(Me.txtCodigo)
        Me.SgcGroupBox1.Controls.Add(Me.txtEspacio)
        Me.SgcGroupBox1.Controls.Add(Me.SgcLabel3)
        Me.SgcGroupBox1.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SgcGroupBox1.Location = New System.Drawing.Point(60, 127)
        Me.SgcGroupBox1.Name = "SgcGroupBox1"
        Me.SgcGroupBox1.Size = New System.Drawing.Size(596, 110)
        Me.SgcGroupBox1.TabIndex = 19
        Me.SgcGroupBox1.TabStop = False
        Me.SgcGroupBox1.Text = "Perfil"
        '
        'lblCodigo
        '
        Me.lblCodigo.AutoSize = True
        Me.lblCodigo.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCodigo.ForeColor = System.Drawing.Color.SteelBlue
        Me.lblCodigo.Location = New System.Drawing.Point(140, 27)
        Me.lblCodigo.Name = "lblCodigo"
        Me.lblCodigo.Size = New System.Drawing.Size(55, 18)
        Me.lblCodigo.TabIndex = 27
        Me.lblCodigo.Text = "Codigo:"
        '
        'btnBuscar
        '
        Me.btnBuscar.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnBuscar.FlatAppearance.BorderColor = System.Drawing.Color.Silver
        Me.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBuscar.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBuscar.ForeColor = System.Drawing.Color.SteelBlue
        Me.btnBuscar.Image = Global.SGC_CS.My.Resources.Resources.btn_buscar
        Me.btnBuscar.Location = New System.Drawing.Point(312, 21)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(45, 31)
        Me.btnBuscar.TabIndex = 26
        Me.btnBuscar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnBuscar.UseVisualStyleBackColor = False
        '
        'txtCodigo
        '
        Me.txtCodigo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCodigo.Enabled = False
        Me.txtCodigo.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCodigo.ForeColor = System.Drawing.Color.Black
        Me.txtCodigo.Location = New System.Drawing.Point(206, 25)
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.Size = New System.Drawing.Size(100, 26)
        Me.txtCodigo.TabIndex = 25
        '
        'txtEspacio
        '
        Me.txtEspacio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtEspacio.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEspacio.ForeColor = System.Drawing.Color.Black
        Me.txtEspacio.Location = New System.Drawing.Point(206, 58)
        Me.txtEspacio.Name = "txtEspacio"
        Me.txtEspacio.Size = New System.Drawing.Size(121, 26)
        Me.txtEspacio.TabIndex = 5
        '
        'SgcLabel3
        '
        Me.SgcLabel3.AutoSize = True
        Me.SgcLabel3.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SgcLabel3.ForeColor = System.Drawing.Color.SteelBlue
        Me.SgcLabel3.Location = New System.Drawing.Point(140, 64)
        Me.SgcLabel3.Name = "SgcLabel3"
        Me.SgcLabel3.Size = New System.Drawing.Size(45, 18)
        Me.SgcLabel3.TabIndex = 2
        Me.SgcLabel3.Text = "Perfil:"
        '
        'tsMenu
        '
        Me.tsMenu.BackColor = System.Drawing.Color.Silver
        Me.tsMenu.Dock = System.Windows.Forms.DockStyle.None
        Me.tsMenu.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tsMenu.ImageScalingSize = New System.Drawing.Size(30, 30)
        Me.tsMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsbLimpiar, Me.tsbGuardar, Me.tsbEditar, Me.tsbEliminar, Me.tsbCancelar})
        Me.tsMenu.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow
        Me.tsMenu.Location = New System.Drawing.Point(60, 71)
        Me.tsMenu.Name = "tsMenu"
        Me.tsMenu.Size = New System.Drawing.Size(185, 37)
        Me.tsMenu.TabIndex = 18
        Me.tsMenu.Text = "SgcToolStrip1"
        '
        'tsbLimpiar
        '
        Me.tsbLimpiar.BackColor = System.Drawing.Color.WhiteSmoke
        Me.tsbLimpiar.Image = Global.SGC_CS.My.Resources.Resources.menu_limpiar
        Me.tsbLimpiar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbLimpiar.Margin = New System.Windows.Forms.Padding(1, 1, 1, 2)
        Me.tsbLimpiar.Name = "tsbLimpiar"
        Me.tsbLimpiar.Size = New System.Drawing.Size(88, 34)
        Me.tsbLimpiar.Text = "Limpiar"
        '
        'tsbGuardar
        '
        Me.tsbGuardar.BackColor = System.Drawing.Color.WhiteSmoke
        Me.tsbGuardar.Image = Global.SGC_CS.My.Resources.Resources.menu_validar
        Me.tsbGuardar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbGuardar.Margin = New System.Windows.Forms.Padding(1, 1, 1, 2)
        Me.tsbGuardar.Name = "tsbGuardar"
        Me.tsbGuardar.Size = New System.Drawing.Size(92, 34)
        Me.tsbGuardar.Text = "Guardar"
        '
        'tsbEditar
        '
        Me.tsbEditar.BackColor = System.Drawing.Color.WhiteSmoke
        Me.tsbEditar.Image = Global.SGC_CS.My.Resources.Resources.menu_editar
        Me.tsbEditar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbEditar.Margin = New System.Windows.Forms.Padding(1, 1, 1, 2)
        Me.tsbEditar.Name = "tsbEditar"
        Me.tsbEditar.Size = New System.Drawing.Size(78, 34)
        Me.tsbEditar.Text = "Editar"
        Me.tsbEditar.Visible = False
        '
        'tsbEliminar
        '
        Me.tsbEliminar.BackColor = System.Drawing.Color.WhiteSmoke
        Me.tsbEliminar.Image = Global.SGC_CS.My.Resources.Resources.menu_eliminar
        Me.tsbEliminar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbEliminar.Margin = New System.Windows.Forms.Padding(1, 1, 1, 2)
        Me.tsbEliminar.Name = "tsbEliminar"
        Me.tsbEliminar.Size = New System.Drawing.Size(93, 34)
        Me.tsbEliminar.Text = "Eliminar"
        Me.tsbEliminar.Visible = False
        '
        'tsbCancelar
        '
        Me.tsbCancelar.BackColor = System.Drawing.Color.WhiteSmoke
        Me.tsbCancelar.Image = Global.SGC_CS.My.Resources.Resources.menu_cancel
        Me.tsbCancelar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbCancelar.Margin = New System.Windows.Forms.Padding(1, 1, 1, 2)
        Me.tsbCancelar.Name = "tsbCancelar"
        Me.tsbCancelar.Size = New System.Drawing.Size(95, 34)
        Me.tsbCancelar.Text = "Cancelar"
        Me.tsbCancelar.Visible = False
        '
        'SgcGroupBox2
        '
        Me.SgcGroupBox2.Controls.Add(Me.dgvOpciones)
        Me.SgcGroupBox2.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SgcGroupBox2.Location = New System.Drawing.Point(60, 243)
        Me.SgcGroupBox2.Name = "SgcGroupBox2"
        Me.SgcGroupBox2.Size = New System.Drawing.Size(596, 333)
        Me.SgcGroupBox2.TabIndex = 20
        Me.SgcGroupBox2.TabStop = False
        Me.SgcGroupBox2.Text = "Opciones"
        '
        'dgvOpciones
        '
        Me.dgvOpciones.AllowUserToAddRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.WhiteSmoke
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.SteelBlue
        Me.dgvOpciones.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvOpciones.BackgroundColor = System.Drawing.Color.WhiteSmoke
        Me.dgvOpciones.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dgvOpciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvOpciones.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colSeleccionar, Me.colPantalla})
        Me.dgvOpciones.Location = New System.Drawing.Point(13, 25)
        Me.dgvOpciones.Name = "dgvOpciones"
        Me.dgvOpciones.Size = New System.Drawing.Size(564, 290)
        Me.dgvOpciones.TabIndex = 0
        '
        'colSeleccionar
        '
        Me.colSeleccionar.HeaderText = ""
        Me.colSeleccionar.Name = "colSeleccionar"
        Me.colSeleccionar.Width = 30
        '
        'colPantalla
        '
        Me.colPantalla.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.colPantalla.HeaderText = "Pantalla"
        Me.colPantalla.Name = "colPantalla"
        Me.colPantalla.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.colPantalla.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'frmRegistroOpcion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1016, 733)
        Me.Controls.Add(Me.SgcGroupBox2)
        Me.Controls.Add(Me.SgcGroupBox1)
        Me.Controls.Add(Me.tsMenu)
        Me.Controls.Add(Me.lblTitulo)
        Me.Name = "frmRegistroOpcion"
        Me.Controls.SetChildIndex(Me.lblTitulo, 0)
        Me.Controls.SetChildIndex(Me.tsMenu, 0)
        Me.Controls.SetChildIndex(Me.SgcGroupBox1, 0)
        Me.Controls.SetChildIndex(Me.SgcGroupBox2, 0)
        Me.SgcGroupBox1.ResumeLayout(False)
        Me.SgcGroupBox1.PerformLayout()
        Me.tsMenu.ResumeLayout(False)
        Me.tsMenu.PerformLayout()
        Me.SgcGroupBox2.ResumeLayout(False)
        CType(Me.dgvOpciones, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblTitulo As SGC_CS.SGCLabel
    Friend WithEvents SgcGroupBox1 As SGC_CS.SGCGroupBox
    Friend WithEvents lblCodigo As SGC_CS.SGCLabel
    Friend WithEvents btnBuscar As SGC_CS.SGCButton
    Friend WithEvents txtCodigo As SGC_CS.SGCTextBox
    Friend WithEvents txtEspacio As SGC_CS.SGCTextBox
    Friend WithEvents SgcLabel3 As SGC_CS.SGCLabel
    Friend WithEvents tsMenu As SGC_CS.SGCToolStrip
    Friend WithEvents tsbLimpiar As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsbGuardar As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsbEditar As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsbEliminar As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsbCancelar As System.Windows.Forms.ToolStripButton
    Friend WithEvents SgcGroupBox2 As SGC_CS.SGCGroupBox
    Friend WithEvents dgvOpciones As SGC_CS.SGCDataGridView
    Friend WithEvents colSeleccionar As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents colPantalla As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
