Imports SGC.Controller
Imports SGC.Model.Entidades

Public Class frmListadoDocumentos

    Dim bc As New BusinessController

#Region "Inicializacion"

    Public Sub New()

        InitializeComponent()

        dgvListadoDoc.AutoGenerateColumns = False

        colSerie.DataPropertyName = "nombre"
        colCorrelativo.DataPropertyName = "nombre"
        colConcepto.DataPropertyName = "nombre"
        colObservacion.DataPropertyName = "nombre"
        colTipo.DataPropertyName = "nombre"
        colMoneda.DataPropertyName = "nombre"
        colTotal.DataPropertyName = "nombre"
        colSaldo.DataPropertyName = "nombre"
        colFecha.DataPropertyName = "nombre"
        colFecha.ValueType = GetType(DateTime)
        colFecha.DefaultCellStyle.Format = "dd/MM/yyyy"
        colVencimiento.DataPropertyName = "nombre"
        colVencimiento.ValueType = GetType(DateTime)
        colVencimiento.DefaultCellStyle.Format = "dd/MM/yyyy"
        colEstado.DataPropertyName = "nombre"



    End Sub

#Region "Propiedades"

    Private _Socio As SocioBE
    Public Property Socio() As SocioBE
        Get
            Return _Socio
        End Get
        Set(ByVal value As SocioBE)
            _Socio = value
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
        Dim ListadoDocs As List(Of DocVenBE) = bc.ListarDocumentos(_Socio.id_socio)
        dgvListadoDoc.DataSource = Nothing
        dgvListadoDoc.DataSource = ListadoDocs
    End Sub

    Private Sub dgvListadoDoc_CellDoubleClick(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvListadoDoc.CellDoubleClick
        DocSeleccionado = DirectCast(dgvListadoDoc.CurrentRow.DataBoundItem, DocVenBE)
        Me.Close()
    End Sub
End Class
