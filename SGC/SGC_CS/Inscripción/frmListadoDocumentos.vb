Imports SGC.Controller
Imports SGC.Model.Entidades

Public Class frmListadoDocumentos

    Dim bc As New BusinessController

#Region "Inicializacion"

    Public Sub New()

        InitializeComponent()

        dgvListadoDoc.AutoGenerateColumns = False

        colSerie.DataPropertyName = "id_serie"
        colCorrelativo.DataPropertyName = "id_correlativo"
        colObservacion.DataPropertyName = "obs_doc"
        colTipo.DataPropertyName = "tipo_doc"
        colMoneda.DataPropertyName = "abr_mon"
        colTotal.DataPropertyName = "tot_mon"
        colSaldo.DataPropertyName = "sal_doc"
        colFecha.DataPropertyName = "fec_reg"
        colFecha.ValueType = GetType(DateTime)
        colFecha.DefaultCellStyle.Format = "dd/MM/yyyy"
        colVencimiento.DataPropertyName = "fec_ven"
        colVencimiento.ValueType = GetType(DateTime)
        colVencimiento.DefaultCellStyle.Format = "dd/MM/yyyy"
        colEstado.DataPropertyName = "est_doc"



    End Sub

#Region "Propiedades"

    Private _id_socio As String
    Public Property id_socio() As String
        Get
            Return _id_socio
        End Get
        Set(ByVal value As String)
            _id_socio = value
        End Set
    End Property

    Private _DocSeleccionado As DocVenBE
    Public Property DocSeleccionado() As DocVenBE
        Get
            Return _DocSeleccionado
        End Get
        Set(ByVal value As DocVenBE)
            _DocSeleccionado = value
        End Set
    End Property

#End Region

#End Region

    Private Sub frmListadoDocumentos_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        Dim ListadoDocs As List(Of DocVenBE) = bc.ListarDocumentos(id_socio)
        dgvListadoDoc.DataSource = Nothing
        dgvListadoDoc.DataSource = ListadoDocs
    End Sub

    Private Sub dgvListadoDoc_CellDoubleClick(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvListadoDoc.CellDoubleClick
        DocSeleccionado = DirectCast(dgvListadoDoc.CurrentRow.DataBoundItem, DocVenBE)
        Me.Close()
    End Sub
End Class
