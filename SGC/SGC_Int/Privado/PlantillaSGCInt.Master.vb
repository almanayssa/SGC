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

            If Session("menu") = "dashboard" Then
                liDashboard.Attributes.Add("class", "current")
            Else
                liDashboard.Attributes.Remove("class")
            End If

            If Session("menu") = "semaforo" Then
                liSemaforo.Attributes.Add("class", "current")
            Else
                liSemaforo.Attributes.Remove("class")
            End If

            If Session("menu") = "comparativo" Then
                liComparativo.Attributes.Add("class", "current")
            Else
                liComparativo.Attributes.Remove("class")
            End If

            If Session("menu") = "reportes" Then
                liReportes.Attributes.Add("class", "current")
            Else
                liReportes.Attributes.Remove("class")
            End If
        End If
    End Sub

    Private Sub lbtnCerrarSesion_Click(sender As Object, e As System.EventArgs) Handles lbtnCerrarSesion.Click
        Session.RemoveAll()
        Response.Redirect("~/frmLogin.aspx", True)
    End Sub
End Class