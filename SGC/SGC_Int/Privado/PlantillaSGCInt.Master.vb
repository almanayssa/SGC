Imports SGC.Model.Entidades
Imports SGC.Controller

Public Class PlantillaSGCInt
    Inherits System.Web.UI.MasterPage

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not Page.IsPostBack Then
            Dim oUsuario As UsuarioBE = Session("usuario")
            If oUsuario IsNot Nothing Then
                lblUsuario.Text = "Bienvenido: " & oUsuario.username
            End If
        End If
    End Sub

    Private Sub lbtnCerrarSesion_Click(sender As Object, e As System.EventArgs) Handles lbtnCerrarSesion.Click
        Session.RemoveAll()
        Response.Redirect("~/frmLogin.aspx", True)
    End Sub
End Class