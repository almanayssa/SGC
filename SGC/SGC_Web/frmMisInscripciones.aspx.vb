Imports SGC.Controller
Imports SGC.Model.Entidades

Public Class frmMisInscripciones
    Inherits System.Web.UI.Page

    Private bc As New BusinessController

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not Page.IsPostBack Then
            ListarInscripciones()
        End If
    End Sub

    Private Sub ListarInscripciones()
        Dim oListadoInscripcion As List(Of InscripcionBE) = bc.ListarInscripciones(Sesiones.UsuarioLogueado.id_socio)
        gvwInscripciones.DataSource = oListadoInscripcion
        gvwInscripciones.DataBind()
    End Sub
End Class