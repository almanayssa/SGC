Imports SGC.Model.Entidades
Imports SGC.Controller

Public Class index
    Inherits System.Web.UI.Page

    Private bc As New BusinessController

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not Page.IsPostBack Then
            txtUsuario.Focus()
        End If
        Label1.Visible = False
    End Sub

    Protected Sub btnAcceder_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles btnAcceder.Click
        Dim strPage As String = Me.Request.ServerVariables("script_name")
        strPage = Right(strPage, Len(strPage) - InStrRev(strPage, "/"))

        Dim oUsuario As UsuarioBE = bc.ObtenerUsuario(txtUsuario.Text.Trim, txtClave.Text.Trim)

        If oUsuario.id_usuario <> String.Empty AndAlso oUsuario.id_perfil_usuario = 6 Then
            Sesiones.UsuarioLogueadoRemover()
            Sesiones.UsuarioLogueado = oUsuario
            Session("ubosque") = oUsuario.username
            Session("nombre") = oUsuario.nombres
            Session("apellido") = oUsuario.ape_pat

            Response.Redirect("inicio.aspx")
        Else
            Label1.Visible = True
            Label1.Text = "Verifique sus datos"
        End If
    End Sub

End Class