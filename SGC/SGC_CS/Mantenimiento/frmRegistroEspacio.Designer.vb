<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRegistroEspacio
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
        Me.lblTitulo = New SGC_CS.SGCLabel(Me.components)
        Me.tsMenu = New SGC_CS.SGCToolStrip(Me.components)
        Me.sbLimpiar = New System.Windows.Forms.ToolStripButton()
        Me.sbGuardar = New System.Windows.Forms.ToolStripButton()
        Me.sbEditar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton2 = New System.Windows.Forms.ToolStripButton()
        Me.SgcGroupBox1 = New SGC_CS.SGCGroupBox(Me.components)
        Me.tsMenu.SuspendLayout()
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
        Me.lblTitulo.Size = New System.Drawing.Size(172, 23)
        Me.lblTitulo.TabIndex = 15
        Me.lblTitulo.Text = "Registro de Espacios"
        '
        'tsMenu
        '
        Me.tsMenu.BackColor = System.Drawing.Color.Silver
        Me.tsMenu.Dock = System.Windows.Forms.DockStyle.None
        Me.tsMenu.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tsMenu.ImageScalingSize = New System.Drawing.Size(30, 30)
        Me.tsMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.sbLimpiar, Me.sbGuardar, Me.sbEditar, Me.ToolStripButton1, Me.ToolStripButton2})
        Me.tsMenu.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow
        Me.tsMenu.Location = New System.Drawing.Point(60, 71)
        Me.tsMenu.Name = "tsMenu"
        Me.tsMenu.Size = New System.Drawing.Size(480, 37)
        Me.tsMenu.TabIndex = 16
        Me.tsMenu.Text = "SgcToolStrip1"
        '
        'sbLimpiar
        '
        Me.sbLimpiar.BackColor = System.Drawing.Color.WhiteSmoke
        Me.sbLimpiar.Image = Global.SGC_CS.My.Resources.Resources.menu_limpiar
        Me.sbLimpiar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.sbLimpiar.Margin = New System.Windows.Forms.Padding(1, 1, 1, 2)
        Me.sbLimpiar.Name = "sbLimpiar"
        Me.sbLimpiar.Size = New System.Drawing.Size(88, 34)
        Me.sbLimpiar.Text = "Limpiar"
        '
        'sbGuardar
        '
        Me.sbGuardar.BackColor = System.Drawing.Color.WhiteSmoke
        Me.sbGuardar.Image = Global.SGC_CS.My.Resources.Resources.menu_validar
        Me.sbGuardar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.sbGuardar.Margin = New System.Windows.Forms.Padding(1, 1, 1, 2)
        Me.sbGuardar.Name = "sbGuardar"
        Me.sbGuardar.Size = New System.Drawing.Size(92, 34)
        Me.sbGuardar.Text = "Guardar"
        '
        'sbEditar
        '
        Me.sbEditar.BackColor = System.Drawing.Color.WhiteSmoke
        Me.sbEditar.Image = Global.SGC_CS.My.Resources.Resources.menu_editar
        Me.sbEditar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.sbEditar.Margin = New System.Windows.Forms.Padding(1, 1, 1, 2)
        Me.sbEditar.Name = "sbEditar"
        Me.sbEditar.Size = New System.Drawing.Size(101, 34)
        Me.sbEditar.Text = "Modificar"
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ToolStripButton1.Image = Global.SGC_CS.My.Resources.Resources.menu_eliminar
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Margin = New System.Windows.Forms.Padding(1, 1, 1, 2)
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(93, 34)
        Me.ToolStripButton1.Text = "Eliminar"
        '
        'ToolStripButton2
        '
        Me.ToolStripButton2.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ToolStripButton2.Image = Global.SGC_CS.My.Resources.Resources.menu_cancel
        Me.ToolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton2.Margin = New System.Windows.Forms.Padding(1, 1, 1, 2)
        Me.ToolStripButton2.Name = "ToolStripButton2"
        Me.ToolStripButton2.Size = New System.Drawing.Size(95, 34)
        Me.ToolStripButton2.Text = "Cancelar"
        '
        'SgcGroupBox1
        '
        Me.SgcGroupBox1.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SgcGroupBox1.Location = New System.Drawing.Point(60, 127)
        Me.SgcGroupBox1.Name = "SgcGroupBox1"
        Me.SgcGroupBox1.Size = New System.Drawing.Size(596, 278)
        Me.SgcGroupBox1.TabIndex = 17
        Me.SgcGroupBox1.TabStop = False
        Me.SgcGroupBox1.Text = "SgcGroupBox1"
        '
        'frmRegistroEspacio
        '
        Me.ClientSize = New System.Drawing.Size(1016, 738)
        Me.Controls.Add(Me.SgcGroupBox1)
        Me.Controls.Add(Me.tsMenu)
        Me.Controls.Add(Me.lblTitulo)
        Me.Name = "frmRegistroEspacio"
        Me.Controls.SetChildIndex(Me.lblTitulo, 0)
        Me.Controls.SetChildIndex(Me.tsMenu, 0)
        Me.Controls.SetChildIndex(Me.SgcGroupBox1, 0)
        Me.tsMenu.ResumeLayout(False)
        Me.tsMenu.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblTitulo As SGC_CS.SGCLabel
    Friend WithEvents tsMenu As SGC_CS.SGCToolStrip
    Friend WithEvents sbLimpiar As System.Windows.Forms.ToolStripButton
    Friend WithEvents sbGuardar As System.Windows.Forms.ToolStripButton
    Friend WithEvents sbEditar As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton2 As System.Windows.Forms.ToolStripButton
    Friend WithEvents SgcGroupBox1 As SGC_CS.SGCGroupBox

End Class
