<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmListadoDocumentos
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
        Me.dgvListadoDoc = New SGC_CS.SGCDataGridView(Me.components)
        Me.colSerie = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colCorrelativo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colObservacion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colTipo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colMoneda = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colTotal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colSaldo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colFecha = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colVencimiento = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colEstado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.dgvListadoDoc, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvListadoDoc
        '
        Me.dgvListadoDoc.AllowUserToAddRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.WhiteSmoke
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.SteelBlue
        Me.dgvListadoDoc.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvListadoDoc.BackgroundColor = System.Drawing.Color.WhiteSmoke
        Me.dgvListadoDoc.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dgvListadoDoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvListadoDoc.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colSerie, Me.colCorrelativo, Me.colObservacion, Me.colTipo, Me.colMoneda, Me.colTotal, Me.colSaldo, Me.colFecha, Me.colVencimiento, Me.colEstado})
        Me.dgvListadoDoc.Location = New System.Drawing.Point(12, 21)
        Me.dgvListadoDoc.Name = "dgvListadoDoc"
        Me.dgvListadoDoc.Size = New System.Drawing.Size(751, 233)
        Me.dgvListadoDoc.TabIndex = 0
        '
        'colSerie
        '
        Me.colSerie.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.colSerie.HeaderText = "Serie"
        Me.colSerie.Name = "colSerie"
        Me.colSerie.Width = 65
        '
        'colCorrelativo
        '
        Me.colCorrelativo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.colCorrelativo.HeaderText = "Correlativo"
        Me.colCorrelativo.Name = "colCorrelativo"
        Me.colCorrelativo.Width = 102
        '
        'colObservacion
        '
        Me.colObservacion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.colObservacion.HeaderText = "Observacion"
        Me.colObservacion.Name = "colObservacion"
        Me.colObservacion.Width = 110
        '
        'colTipo
        '
        Me.colTipo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.colTipo.HeaderText = "Tipo"
        Me.colTipo.Name = "colTipo"
        Me.colTipo.Width = 60
        '
        'colMoneda
        '
        Me.colMoneda.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.colMoneda.HeaderText = "Moneda"
        Me.colMoneda.Name = "colMoneda"
        Me.colMoneda.Width = 85
        '
        'colTotal
        '
        Me.colTotal.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.colTotal.HeaderText = "Total"
        Me.colTotal.Name = "colTotal"
        Me.colTotal.Width = 63
        '
        'colSaldo
        '
        Me.colSaldo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.colSaldo.HeaderText = "Saldo"
        Me.colSaldo.Name = "colSaldo"
        Me.colSaldo.Width = 67
        '
        'colFecha
        '
        Me.colFecha.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.colFecha.HeaderText = "Fecha"
        Me.colFecha.Name = "colFecha"
        Me.colFecha.Width = 69
        '
        'colVencimiento
        '
        Me.colVencimiento.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.colVencimiento.HeaderText = "Vencimiento"
        Me.colVencimiento.Name = "colVencimiento"
        Me.colVencimiento.Width = 112
        '
        'colEstado
        '
        Me.colEstado.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.colEstado.HeaderText = "Estado"
        Me.colEstado.Name = "colEstado"
        Me.colEstado.Width = 74
        '
        'frmListadoDocumentos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 18.0!)
        Me.ClientSize = New System.Drawing.Size(779, 275)
        Me.Controls.Add(Me.dgvListadoDoc)
        Me.Name = "frmListadoDocumentos"
        CType(Me.dgvListadoDoc, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents dgvListadoDoc As SGC_CS.SGCDataGridView
    Friend WithEvents colSerie As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colCorrelativo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colObservacion As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colTipo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colMoneda As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colTotal As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colSaldo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colFecha As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colVencimiento As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colEstado As System.Windows.Forms.DataGridViewTextBoxColumn

End Class
