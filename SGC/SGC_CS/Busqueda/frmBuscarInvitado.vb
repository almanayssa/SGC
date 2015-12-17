Imports SGC.Controller
Imports SGC.Model.Entidades

Public Class frmBuscarInvitado

    Dim bc As New BusinessController

#Region "Inicializacion"

    Public Sub New()

        InitializeComponent()

        dgvListado.AutoGenerateColumns = False
        colNombre.DataPropertyName = "nombre_completo"
        colDNI.DataPropertyName = "dni_inv"
    End Sub

#End Region

#Region "Propiedades"

    Private _InvitadoSeleccionado As InvitadoBE
    Public Property InvitadoSeleccionado() As InvitadoBE
        Get
            Return _InvitadoSeleccionado
        End Get
        Set(ByVal value As InvitadoBE)
            _InvitadoSeleccionado = value
        End Set
    End Property

#End Region

#Region "Metodos Personalizados"

    Private Sub ListarInvitadosAInscribir()
        Dim ListadoPersonasAInscribir As List(Of InvitadoBE) = bc.ListarInvitados(txtAccion.Text.Trim, txtNombre.Text.Trim)
        dgvListado.DataSource = Nothing
        dgvListado.DataSource = ListadoPersonasAInscribir
    End Sub

#End Region

#Region "Cargar"

    Private Sub frmBuscarPersonaInscribir_Load(ByVal sender As Object, ByVal e As System.EventArgs)
        ListarInvitadosAInscribir()
    End Sub

#End Region

#Region "Metodos Controles"

    Private Sub btnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscar.Click
        ListarInvitadosAInscribir()
    End Sub

#End Region

#Region "Metodos Grilla"

    Private Sub dgvListado_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvListado.CellDoubleClick
        InvitadoSeleccionado = DirectCast(dgvListado.CurrentRow.DataBoundItem, InvitadoBE)
        Me.Close()
    End Sub

#End Region

End Class
