Imports SGC.Controller
Imports SGC.Model.Entidades

Public Class frmBuscarFamiliares

    Dim bc As New BusinessController

#Region "Inicializacion"

    Public Sub New()

        InitializeComponent()

        dgvListado.AutoGenerateColumns = False
        colNombre.DataPropertyName = "nombre_completo"
        colRelacion.DataPropertyName = "tipo_familiar"
        colFechaNacimiento.DataPropertyName = "fec_nac_per"
        colDNI.DataPropertyName = "dni_per"
    End Sub

#End Region

#Region "Propiedades"

    Private _PersonaSeleccionada As PersonaBE
    Public Property PersonaSeleccionada() As PersonaBE
        Get
            Return _PersonaSeleccionada
        End Get
        Set(ByVal value As PersonaBE)
            _PersonaSeleccionada = value
        End Set
    End Property

#End Region

#Region "Metodos Personalizados"

    Private Sub ListarPersonasAInscribir()
        Dim ListadoPersonasAInscribir As List(Of PersonaBE) = bc.ListarPersonasFamilia(txtAccion.Text.Trim, txtNombre.Text.Trim)
        dgvListado.DataSource = Nothing
        dgvListado.DataSource = ListadoPersonasAInscribir
    End Sub

#End Region

#Region "Cargar"

    Private Sub frmBuscarPersonaInscribir_Load(ByVal sender As Object, ByVal e As System.EventArgs)
        ListarPersonasAInscribir()
    End Sub

#End Region

#Region "Metodos Controles"

    Private Sub btnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscar.Click
        ListarPersonasAInscribir()
    End Sub

#End Region

#Region "Metodos Grilla"

    Private Sub dgvListado_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvListado.CellDoubleClick
        PersonaSeleccionada = DirectCast(dgvListado.CurrentRow.DataBoundItem, PersonaBE)
        Me.Close()
    End Sub

#End Region

End Class
