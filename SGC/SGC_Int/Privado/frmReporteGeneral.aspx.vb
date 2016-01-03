Imports SGC.Model.Entidades
Imports SGC.Controller

Public Class frmReporteGeneral
    Inherits System.Web.UI.Page

    Private bc As New BusinessController

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not Page.IsPostBack Then
            ListarComites()
            ListarTipoActividad()
            ListarVariables()
            txtFechaInicio.Text = "01/01/2015"
            txtFechaFin.Text = Now.ToString("dd/MM/yyyy")
        End If
    End Sub

    Private Sub ListarComites()
        Dim oComite As New ComiteBE
        oComite.id_comite = "000"
        oComite.nombre = "- Seleccione -"

        Dim ListadoComites As List(Of ComiteBE) = bc.ListarComites()
        ListadoComites.Insert(0, oComite)
        ddlComite.DataSource = ListadoComites
        ddlComite.DataValueField = "id_comite"
        ddlComite.DataTextField = "nombre"
        ddlComite.DataBind()
    End Sub

    Private Sub ListarTipoActividad()
        Dim ListadoTipoActividad As List(Of TipoActividadBE) = bc.ListarTipoActividad()
        ddlTipo.DataSource = Nothing
        ddlTipo.DataSource = ListadoTipoActividad
        ddlTipo.DataValueField = "id_tipo_act"
        ddlTipo.DataTextField = "desc_tipo"
        ddlTipo.DataBind()
    End Sub

    Private Sub ListarActividades()
        Dim ListadoActividades As List(Of ActividadBE) = bc.ListarActividades(ddlComite.SelectedValue, ddlTipo.SelectedValue, txtFechaInicio.Text.Trim, txtFechaFin.Text.Trim)
        cblActividades.DataSource = ListadoActividades
        cblActividades.DataValueField = "id_actividad"
        cblActividades.DataTextField = "nombre"
        cblActividades.DataBind()
    End Sub

    Protected Sub ddlComite_SelectedIndexChanged(sender As Object, e As System.EventArgs) Handles ddlComite.SelectedIndexChanged
        ListarActividades()
    End Sub

    Protected Sub chkActividades_CheckedChanged(sender As Object, e As System.EventArgs) Handles chkActividades.CheckedChanged
        For Each chkActividad As ListItem In cblActividades.Items
            chkActividad.Selected = chkActividades.Checked
        Next
    End Sub

    Private Sub ListarVariables()
        Dim ListadoActividades As List(Of VariableBE) = bc.ListarVariables()
        cblVariables.DataSource = ListadoActividades
        cblVariables.DataValueField = "id_variable"
        cblVariables.DataTextField = "nombre"
        cblVariables.DataBind()
    End Sub

    Protected Sub ddlTipo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ddlTipo.SelectedIndexChanged
        ListarActividades()
    End Sub

    Protected Sub chkVariables_CheckedChanged(sender As Object, e As EventArgs) Handles chkVariables.CheckedChanged
        For Each chkVariable As ListItem In cblVariables.Items
            chkVariable.Selected = chkVariables.Checked
        Next
    End Sub
End Class