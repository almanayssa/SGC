Imports SGC.Model.Entidades
Imports SGC.Controller

Public Class frmActualizarParametros
    Inherits System.Web.UI.Page

    Private bc As New BusinessController

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not Page.IsPostBack Then
            ListarParametros()
        End If
    End Sub

    Private Sub ListarParametros()
        Dim oListadoParametro As List(Of ParametroBE) = bc.ListarParametro()
        gvwParametros.DataSource = oListadoParametro
        gvwParametros.DataBind()
    End Sub

    Protected Sub lbtnGuardar_Click(sender As Object, e As EventArgs) Handles lbtnGuardar.Click
        Dim countVacios As Integer = 0

        For Each row As GridViewRow In gvwParametros.Rows
            Dim txtItem As TextBox = DirectCast(row.FindControl("txtValor"), TextBox)

            If txtItem.Text.Trim = String.Empty Then
                countVacios += 1
            End If
        Next

        If countVacios > 0 Then
            lblMensaje.Text = "Ingrese un valor para todos los parámetros"
            Exit Sub
        End If

        Dim affectedRows As Integer = 0
        Dim listado As New List(Of ParametroBE)
        Dim oParametro As ParametroBE

        For Each row As GridViewRow In gvwParametros.Rows
            Dim lblCodigo As Label = DirectCast(row.FindControl("lblCodigo"), Label)
            Dim lblNombre As Label = DirectCast(row.FindControl("lblNombre"), Label)
            Dim txtValor As TextBox = DirectCast(row.FindControl("txtValor"), TextBox)
            oParametro = New ParametroBE
            oParametro.id_parametro = lblCodigo.Text
            oParametro.nombre = lblNombre.Text
            oParametro.valor = txtValor.Text.Trim
            listado.Add(oParametro)
        Next

        If bc.ActualizarParametros(listado) Then
            ListarParametros()
            lblMensaje.Text = "Se actualizaron los parámetros satisfactoriamente."
        Else
            lblMensaje.Text = "Error al actualizar."
        End If
    End Sub
End Class