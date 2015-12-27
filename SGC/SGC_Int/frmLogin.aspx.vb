Imports SGC.Model.Entidades
Imports SGC.Controller

Public Class frmLogin
    Inherits System.Web.UI.Page

    Private bc As New BusinessController

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not Page.IsPostBack Then
            lblMensajeError.Text = String.Empty
        End If
    End Sub

    Protected Sub lbtnIniciarSesion_Click(sender As Object, e As EventArgs) Handles lbtnIniciarSesion.Click
        Dim oUsuario As UsuarioBE = bc.ObtenerUsuario(tbxUsuario.Text.Trim, tbxContrasenia.Text.Trim)

        If oUsuario IsNot Nothing AndAlso oUsuario.id_usuario <> String.Empty Then
            Session.RemoveAll()
            Session("usuario") = oUsuario
            Response.Redirect("~/Privado/frmReporteActividades.aspx", True)
        Else
            lblMensajeError.Text = "Usuario y/o contraseña incorrectos"
        End If
    End Sub
End Class