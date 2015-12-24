Imports System.Collections.Generic
Imports SGC.Model.Entidades

Partial Class inicio
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        'Validación si la sesión esta abierta para que pueda ingresar al sistema
        If Session("ubosque") = "" Then
            Response.Redirect("index.aspx", True)
        End If

        lblApellidosNombre.Text = Session("nombre") & " " & Session("apellido")
    End Sub

End Class