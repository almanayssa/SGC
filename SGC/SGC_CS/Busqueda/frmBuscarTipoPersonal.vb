Imports SGC.Controller
Imports SGC.Model.Entidades

Public Class frmBuscarTipoPersonal

    Dim bc As New BusinessController

#Region "Inicializacion"

    Public Sub New()
        InitializeComponent()

        dgvListado.AutoGenerateColumns = False
        colDescripcion.DataPropertyName = "Descripcion"
    End Sub

#End Region

#Region "Propiedades"

    Private _TipoPersonalSeleccionado As TipoPersonalBE
    Public Property TipoPersonalSeleccionado() As TipoPersonalBE
        Get
            Return _TipoPersonalSeleccionado
        End Get
        Set(ByVal value As TipoPersonalBE)
            _TipoPersonalSeleccionado = value
        End Set
    End Property

#End Region

#Region "Metodos Personalizados"

    Private Sub ListarTipoPersonal()
        Dim ListadoTipoPersonal As List(Of TipoPersonalBE) = bc.ListarTipoPersonal(txtNombre.Text.Trim)
        dgvListado.DataSource = Nothing
        dgvListado.DataSource = ListadoTipoPersonal
    End Sub

#End Region

#Region "Cargar"

    Private Sub frmBuscarTipoPersonal_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        ListarTipoPersonal()
    End Sub

#End Region

#Region "Metodos Controles"

    Private Sub btnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscar.Click
        ListarTipoPersonal()
    End Sub

#End Region

#Region "Metodos Grilla"

    Private Sub dgvPersonal_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvListado.CellDoubleClick
        TipoPersonalSeleccionado = DirectCast(dgvListado.CurrentRow.DataBoundItem, TipoPersonalBE)
        Me.Close()
    End Sub

#End Region

End Class
