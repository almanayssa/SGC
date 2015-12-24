Imports SGC.Controller
Imports SGC.Model.Entidades

Public Class frmRegistroInscripcion
    Inherits System.Web.UI.Page

    Private bc As New BusinessController

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not Page.IsPostBack Then
            If Request.QueryString("id") <> String.Empty Then
                Sesiones.ActividadSeleccionadaRemover()
                Sesiones.ActividadSeleccionada = bc.CargarActividadCabecera(CInt(Request.QueryString("id")))
            End If
            CargarActividad()
        End If
    End Sub

    Private Sub CargarActividad()
        txtActividad.Text = Sesiones.ActividadSeleccionada.nombre
        txtDatos.Text = "Tipo de Actividad: " & Sesiones.ActividadSeleccionada.desc_tipo & vbCrLf & _
                            "Comite: " & Sesiones.ActividadSeleccionada.nombrecomite & vbCrLf & _
                            "Pago: " & Sesiones.ActividadSeleccionada.monto_pago & vbCrLf & _
                            "Vacantes: " & Sesiones.ActividadSeleccionada.vacantes
    End Sub

    Protected Sub btnBuscarFamiliares_Click(sender As Object, e As System.Web.UI.ImageClickEventArgs) Handles btnBuscarFamiliares.Click
        Dim oListadoPersonas As List(Of PersonaBE) = bc.ListarPersonasFamilia(Sesiones.UsuarioLogueado.id_accion, String.Empty)
        gvwFamiliares.DataSource = oListadoPersonas
        gvwFamiliares.DataBind()
    End Sub

    Protected Sub btnAgregarFamiliares_Click(sender As Object, e As System.Web.UI.ImageClickEventArgs) Handles btnAgregarFamiliares.Click
        Dim countChecks As Integer = 0

        For Each row As GridViewRow In gvwFamiliares.Rows
            Dim chkItem As CheckBox = DirectCast(row.FindControl("chkSeleccionar"), CheckBox)

            If chkItem.Checked Then
                countChecks += 1
            End If
        Next

        If countChecks = 0 Then
            lblnofamiliares.Text = "Seleccione un familiar por lo menos"
            Exit Sub
        Else
            lblnofamiliares.Text = ""

            Dim oListadoFamiliares As New List(Of PersonaBE)

            For Each row As GridViewRow In gvwFamiliares.Rows
                Dim chkItem As CheckBox = DirectCast(row.FindControl("chkSeleccionar"), CheckBox)

                If chkItem.Checked Then
                    'Dim oPersona As PersonaBE = row.DataItem 
                    'oListadoFamiliares.Add(oPersona)

                    Dim opersona As New PersonaBE
                    opersona.nombre_completo = row.Cells(2).Text
                    opersona.id_persona = row.Cells(1).Text
                    opersona.tipo_familiar = row.Cells(3).Text
                    oListadoFamiliares.Add(opersona)
                End If
            Next

            Sesiones.ListadoFamiliaresRemover()
            Sesiones.ListadoFamiliares = oListadoFamiliares

            gvwParticipantes.DataSource = oListadoFamiliares
            gvwParticipantes.DataBind()

            btnRegistrar.Visible = True
        End If
    End Sub

    Protected Sub btnRegistrar_Click(sender As Object, e As System.Web.UI.ImageClickEventArgs) Handles btnRegistrar.Click
        Dim oInscripcion As New InscripcionBE
        oInscripcion.id_actividad = Sesiones.ActividadSeleccionada.id_actividad
        oInscripcion.id_socio = Sesiones.UsuarioLogueado.id_socio
        oInscripcion.ListaPersona = New List(Of PersonaBE)
        oInscripcion.ListaPersona = Sesiones.ListadoFamiliares
        'oInscripcion.serie = txtSerie.Text
        'oInscripcion.correlativo = txtNumDoc.Text
        oInscripcion.tipo_doc = "02"
        oInscripcion.flg_web = False
        oInscripcion.monto = oInscripcion.ListaPersona.Count * Sesiones.ActividadSeleccionada.monto_pago

        oInscripcion.id_inscripcion = bc.InsertarInscripcion(oInscripcion)

        Dim oDocVen As New DocVenBE

        If Sesiones.ActividadSeleccionada.monto_pago > 0 Then
            oDocVen = CrearDocumento(oInscripcion)
        End If

        If oInscripcion.id_inscripcion = 0 Then
            Sesiones.MsgTituloRemover()
            Sesiones.MsgDescripcionRemover()
            Sesiones.MsgContinuarRemover()
            Sesiones.MsgTitulo = "Mensaje"
            Sesiones.MsgDescripcion = "Error al grabar"
            Sesiones.MsgContinuar = "~\frmCronogramaActividades.aspx"
            Response.Redirect("~\Mensaje.aspx", True)
        Else
            Sesiones.MsgTituloRemover()
            Sesiones.MsgDescripcionRemover()
            Sesiones.MsgContinuarRemover()
            Sesiones.MsgTitulo = "Mensaje"
            Sesiones.MsgDescripcion = "- La inscripción se registró satisfactoriamente"
            If oDocVen IsNot Nothing Then
                Sesiones.MsgDescripcion = Sesiones.MsgDescripcion & "<br/>- Se generó el documento " & oDocVen.id_serie & " - " & oDocVen.id_correlativo
            End If
            Sesiones.MsgContinuar = "~\frmCronogramaActividades.aspx"
            Response.Redirect("~\Mensaje.aspx", True)
        End If
    End Sub

    Private Function CrearDocumento(ByRef oInscripcion As InscripcionBE) As DocVenBE
        Dim oDocVen As New DocVenBE
        oDocVen.id_entidad = oInscripcion.id_socio
        oDocVen.obs_doc = "Actividad: " & Sesiones.ActividadSeleccionada.nombre & " Tipo de Actividad: " & Sesiones.ActividadSeleccionada.desc_tipo & " Comite: " & Sesiones.ActividadSeleccionada.nombrecomite
        oDocVen.tot_mon = oInscripcion.monto

        oDocVen = bc.InsertarDocVen(oDocVen)

        Return oDocVen

    End Function

    Private Sub gvwParticipantes_RowCommand(sender As Object, e As System.Web.UI.WebControls.GridViewCommandEventArgs) Handles gvwParticipantes.RowCommand
        If e.CommandName = "Quitar" Then
            Dim id As String = e.CommandArgument

            For Each row As GridViewRow In gvwFamiliares.Rows
                Dim chkItem As CheckBox = DirectCast(row.FindControl("chkSeleccionar"), CheckBox)
                
                If row.Cells(1).Text = id Then
                    chkItem.Checked = False
                End If
            Next

            Dim oListadoFamiliares As New List(Of PersonaBE)

            For Each row As GridViewRow In gvwFamiliares.Rows
                Dim chkItem As CheckBox = DirectCast(row.FindControl("chkSeleccionar"), CheckBox)

                If chkItem.Checked Then
                    Dim opersona As New PersonaBE
                    opersona.nombre_completo = row.Cells(2).Text
                    opersona.id_persona = row.Cells(1).Text
                    opersona.tipo_familiar = row.Cells(3).Text
                    oListadoFamiliares.Add(opersona)
                End If
            Next

            Sesiones.ListadoFamiliaresRemover()
            Sesiones.ListadoFamiliares = oListadoFamiliares

            gvwParticipantes.DataSource = oListadoFamiliares
            gvwParticipantes.DataBind()

            Dim countChecks As Integer = 0

            For Each row As GridViewRow In gvwFamiliares.Rows
                Dim chkItem As CheckBox = DirectCast(row.FindControl("chkSeleccionar"), CheckBox)

                If chkItem.Checked Then
                    countChecks += 1
                End If
            Next

            If countChecks = 0 Then
                lblnofamiliares.Text = "Seleccione un familiar por lo menos"
                btnRegistrar.Visible = False
            Else
                lblnofamiliares.Text = ""
                btnRegistrar.Visible = True
            End If
        End If
    End Sub
End Class