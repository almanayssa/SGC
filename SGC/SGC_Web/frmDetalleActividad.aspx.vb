﻿Imports SGC.Model.Entidades
Imports SGC.Controller

Public Class frmDetalleActividad
    Inherits System.Web.UI.Page

    Private bc As New BusinessController

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not Page.IsPostBack Then
            CargarActividad()
        End If
    End Sub

    Protected Sub CargarActividad()
        Dim oActividad As ActividadBE = Sesiones.ActividadSeleccionada

        lblNombre.Text = oActividad.nombre
        lblComite.Text = oActividad.nombrecomite
        lblTipo.Text = oActividad.desc_tipo
        lblFechaInicio.Text = oActividad.fec_ini
        lblHoraInicio.Text = oActividad.hora_ini.ToString()
        lblFechaFin.Text = oActividad.fec_fin
        lblHoraFin.Text = oActividad.hora_fin.ToString()
        lblDescripcion.Text = oActividad.descripcion

        Dim fechaHora As DateTime = Convert.ToDateTime(oActividad.fec_fin).Add(oActividad.hora_fin)

        If DateDiff(DateInterval.Second, fechaHora, Now) > 0 Then
            tdActividadFinalizada.Visible = True
        Else
            tdActividadFinalizada.Visible = False
        End If
    End Sub

    Protected Sub ibtnRegresar_Click(sender As Object, e As System.Web.UI.ImageClickEventArgs) Handles ibtnRegresar.Click
        Response.Redirect("frmCronogramaActividades.aspx", True)
    End Sub

    Protected Sub ibtnInscribir_Click(sender As Object, e As System.Web.UI.ImageClickEventArgs) Handles ibtnInscribir.Click
        Response.Redirect("frmRegistroInscripcion.aspx", True)
    End Sub
End Class