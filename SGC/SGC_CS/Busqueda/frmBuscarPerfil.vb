Imports SGC.Controller
Imports SGC.Model.Entidades

Public Class frmBuscarPerfil

    Dim bc As New BusinessController

#Region "Inicializacion"

    Public Sub New()
        InitializeComponent()

        dgvListado.AutoGenerateColumns = False
        colNombre.DataPropertyName = "Nombre"
    End Sub

#End Region

#Region "Propiedades"

    Private _PerfilSeleccionado As PerfilUsuarioBE
    Public Property PerfilSeleccionado() As PerfilUsuarioBE
        Get
            Return _PerfilSeleccionado
        End Get
        Set(ByVal value As PerfilUsuarioBE)
            _PerfilSeleccionado = value
        End Set
    End Property

#End Region

#Region "Metodos Personalizados"

    Private Sub ListarPerfiles()
        Dim ListadoEspacios As List(Of PerfilUsuarioBE) = bc.ListarPerfilesBusqueda(txtNombre.Text)
        dgvListado.DataSource = Nothing
        dgvListado.DataSource = ListadoEspacios
    End Sub

#End Region

#Region "Cargar"

    Private Sub frmBuscarPerfil_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        ListarPerfiles()
    End Sub

#End Region

#Region "Metodos Controles"

    Private Sub btnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscar.Click
        ListarPerfiles()
    End Sub

#End Region

#Region "Metodos Grilla"

    Private Sub dgvListado_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvListado.CellDoubleClick
        PerfilSeleccionado = DirectCast(dgvListado.CurrentRow.DataBoundItem, PerfilUsuarioBE)
        Me.Close()
    End Sub

#End Region

End Class