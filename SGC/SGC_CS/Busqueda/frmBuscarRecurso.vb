Imports SGC.Controller
Imports SGC.Model.Entidades

Public Class frmBuscarRecurso

    Dim bc As New BusinessController

#Region "Inicializacion"

    Public Sub New()
        InitializeComponent()

        dgvListado.AutoGenerateColumns = False
        colDescripcion.DataPropertyName = "Descripcion"
    End Sub

#End Region

#Region "Propiedades"

    Private _RecursoSeleccionado As RecursoBE
    Public Property RecursoSeleccionado() As RecursoBE
        Get
            Return _RecursoSeleccionado
        End Get
        Set(ByVal value As RecursoBE)
            _RecursoSeleccionado = value
        End Set
    End Property

#End Region

#Region "Metodos Personalizados"

    Private Sub ListarRecursos()
        Dim ListadoRecursos As List(Of RecursoBE) = bc.ListarRecursos(txtNombre.Text.Trim)
        dgvListado.DataSource = Nothing
        dgvListado.DataSource = ListadoRecursos
    End Sub

#End Region

#Region "Cargar"

    Private Sub frmBuscarRecurso_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        ListarRecursos()
    End Sub

#End Region

#Region "Metodos Controles"

    Private Sub btnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscar.Click
        ListarRecursos()
    End Sub

#End Region

#Region "Metodos Grilla"

    Private Sub dgvRecursos_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvListado.CellDoubleClick
        RecursoSeleccionado = DirectCast(dgvListado.CurrentRow.DataBoundItem, RecursoBE)
        Me.Close()
    End Sub

#End Region

End Class
