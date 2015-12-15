Imports SGC.Controller
Imports SGC.Model.Entidades

Public Class frmBuscarPersonal

    Dim bc As New BusinessController

#Region "Inicializacion"

    Public Sub New()

        InitializeComponent()

        dgvListado.AutoGenerateColumns = False
        colNombre.DataPropertyName = "nombre_completo"

        cboTipo.ValueMember = "id_tipo_personal"
        cboTipo.DisplayMember = "descripcion"

    End Sub

#End Region

#Region "Propiedades"

    Private _PersonalSeleccionado As PersonalBE
    Public Property PersonalSeleccionado() As PersonalBE
        Get
            Return _PersonalSeleccionado
        End Get
        Set(ByVal value As PersonalBE)
            _PersonalSeleccionado = value
        End Set
    End Property

#End Region

#Region "Metodos Personalizados"

    Private Sub ListarTipos()
        Dim oTipoPersonal As New TipoPersonalBE
        oTipoPersonal.id_tipo_personal = 0
        oTipoPersonal.descripcion = "- Seleccione -"

        Dim ListadoTipos As List(Of TipoPersonalBE) = bc.ListarTipoPersonal(String.Empty)
        ListadoTipos.Insert(0, oTipoPersonal)
        cboTipo.DataSource = Nothing
        cboTipo.DataSource = ListadoTipos
    End Sub

    Private Sub ListarPersonal()
        Dim ListadoPersonal As List(Of PersonalBE) = bc.ListarPersonal(cboTipo.SelectedValue, txtNombre.Text.Trim)
        dgvListado.DataSource = Nothing
        dgvListado.DataSource = ListadoPersonal
    End Sub

#End Region

#Region "Cargar"

    Private Sub frmBuscarActividad_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        ListarTipos()
    End Sub

#End Region

#Region "Metodos Controles"

    Private Sub btnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscar.Click
        If cboTipo.SelectedValue = 0 Then
            MessageBox.Show("Seleccione un tipo", "Información")
            Exit Sub
        Else
            ListarPersonal()
        End If
    End Sub

#End Region

#Region "Metodos Grilla"

    Private Sub dgvListado_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvListado.CellDoubleClick
        PersonalSeleccionado = DirectCast(dgvListado.CurrentRow.DataBoundItem, PersonalBE)
        Me.Close()
    End Sub

#End Region

End Class