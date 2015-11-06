<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmConsultaPlanAnual
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
        Me.SgcGroupBox1 = New SGC_CS.SGCGroupBox(Me.components)
        Me.SuspendLayout()
        '
        'SgcGroupBox1
        '
        Me.SgcGroupBox1.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SgcGroupBox1.Location = New System.Drawing.Point(73, 85)
        Me.SgcGroupBox1.Name = "SgcGroupBox1"
        Me.SgcGroupBox1.Size = New System.Drawing.Size(896, 100)
        Me.SgcGroupBox1.TabIndex = 8
        Me.SgcGroupBox1.TabStop = False
        Me.SgcGroupBox1.Text = "SgcGroupBox1"
        '
        'frmConsultaPlanAnual
        '
        Me.ClientSize = New System.Drawing.Size(1016, 738)
        Me.Controls.Add(Me.SgcGroupBox1)
        Me.Name = "frmConsultaPlanAnual"
        Me.Controls.SetChildIndex(Me.SgcGroupBox1, 0)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SgcGroupBox1 As SGC_CS.SGCGroupBox

End Class
