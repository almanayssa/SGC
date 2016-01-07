<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmInfo
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
        Me.txtInfo = New SGC_CS.SGCTextBox(Me.components)
        Me.SuspendLayout()
        '
        'txtInfo
        '
        Me.txtInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtInfo.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtInfo.ForeColor = System.Drawing.Color.Black
        Me.txtInfo.Location = New System.Drawing.Point(26, 22)
        Me.txtInfo.Multiline = True
        Me.txtInfo.Name = "txtInfo"
        Me.txtInfo.ReadOnly = True
        Me.txtInfo.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtInfo.Size = New System.Drawing.Size(480, 368)
        Me.txtInfo.TabIndex = 0
        '
        'frmInfo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 18.0!)
        Me.ClientSize = New System.Drawing.Size(540, 420)
        Me.Controls.Add(Me.txtInfo)
        Me.Name = "frmInfo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Información"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtInfo As SGC_CS.SGCTextBox

End Class
