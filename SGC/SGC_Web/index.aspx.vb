Imports SGC.Model.Entidades
Imports SGC.Controller

Public Class index
    Inherits System.Web.UI.Page

    Private bc As New BusinessController
    Private Usuario As UsuarioBE

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

        If oUsuario.id_usuario > 0 Then
            Usuario = oUsuario
            Session("usuario") = Usuario.username
            Session("nombre") = Usuario.nombres
            Session("apellido") = Usuario.ape_pat

            Response.Redirect("inicio.aspx")
        Else
            Label1.Visible = True
            Label1.Text = "Verifique sus datos"
        End If
    End Sub

End Class