Imports SGC.Controller
Imports SGC.Model.Entidades

Public Class frmMisSuscripciones
    Inherits System.Web.UI.Page

    Private bc As New BusinessController

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not Page.IsPostBack Then
            ListarSuscripciones()
        End If
    End Sub

    Private Sub ListarSuscripciones()
        Dim oListadoSuscripcion As List(Of SuscripcionComiteBE) = bc.ListarSuscripcionComites(Sesiones.UsuarioLogueado.id_socio)
        gvwSuscripciones.DataSource = oListadoSuscripcion
        gvwSuscripciones.DataBind()
    End Sub

    Protected Sub btnRegistrar_Click(sender As Object, e As System.Web.UI.ImageClickEventArgs) Handles btnRegistrar.Click
        Dim countChecks As Integer = 0

        For Each row As GridViewRow In gvwSuscripciones.Rows
            Dim chkItem As CheckBox = DirectCast(row.FindControl("chkSeleccionar"), CheckBox)

            If chkItem.Checked Then
                countChecks += 1
            End If
        Next

        If countChecks = 0 Then
            lblmsjerror0.Text = "Seleccione un comité por lo menos"
            Exit Sub
        End If

        Dim affectedRows As Integer = 0
        Dim listado As New List(Of SuscripcionComiteBE)
        Dim oSusComite As SuscripcionComiteBE

        For Each row As GridViewRow In gvwSuscripciones.Rows
            Dim chkItem As CheckBox = DirectCast(row.FindControl("chkSeleccionar"), CheckBox)

            If chkItem.Checked Then
                oSusComite = New SuscripcionComiteBE
                oSusComite.id_comite = row.Cells(1).Text
                listado.Add(oSusComite)
            End If
        Next

        Dim oSocio As New SocioBE
        oSocio.id_socio = Sesiones.UsuarioLogueado.id_socio

        If bc.InsertarSuscripcionComite(listado, oSocio) Then
            Sesiones.MsgTituloRemover()
            Sesiones.MsgDescripcionRemover()
            Sesiones.MsgContinuarRemover()
            Sesiones.MsgTitulo = "Mensaje"
            Sesiones.MsgDescripcion = "La suscripción se registró satisfactoriamente"
            Sesiones.MsgContinuar = "~\inicio.aspx"
            Response.Redirect("~\Mensaje.aspx", True)
        Else
            Sesiones.MsgTituloRemover()
            Sesiones.MsgDescripcionRemover()
            Sesiones.MsgContinuarRemover()
            Sesiones.MsgTitulo = "Mensaje"
            Sesiones.MsgDescripcion = "Error al grabar"
            Sesiones.MsgContinuar = "~\inicio.aspx"
            Response.Redirect("~\Mensaje.aspx", True)
        End If
    End Sub
End Class