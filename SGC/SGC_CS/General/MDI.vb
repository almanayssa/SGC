Imports System.Data
Imports System.Data.SqlClient
Imports System.Drawing.Color
Imports System.ComponentModel

Public Class MDI
    'Dim X As New Configuration.AppSettingsReader
    'Dim cad As String = X.GetValue("conexion", Type.GetType("System.String"))
    'Dim bd As String = X.GetValue("bd", Type.GetType("System.String"))

    'Dim cnx As New SqlConnection(cad)

#Region "Cargar"

    Private Sub MDI_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.Text = "Bienvenido - Versión 1.0"

        'Me.lblTipoC.Margin = New System.Windows.Forms.Padding(Me.Width - 300, 3, 0, 2)
        'lblMdi.Text = "Conectado a: " & bd
        'If Modulo_Parametros.area_usuario = "CAJA" Or Modulo_Parametros.area_usuario = "COBRANZA" Then
        '    lblTipoC.Text = "Tipo de Cambio:"
        '    If Modulo_Parametros.tipo_cambio = 0 Then
        '        lblValorTC.Text = "S/V"
        '    Else
        '        lblValorTC.Text = CStr(Format(Modulo_Parametros.tipo_cambio, "####.000"))
        '    End If

        'End If

    End Sub

#End Region

#Region "Cerrar"

    Private Sub MDI_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        Dim rpta As Integer
        rpta = MsgBox("Desea salir?", MsgBoxStyle.YesNo + MsgBoxStyle.Question)
        If rpta = MsgBoxResult.No Then
            e.Cancel = True
        ElseIf rpta = MsgBoxResult.Yes Then
            End
        End If
    End Sub

#End Region

#Region "Metodos Botones"

    Private Sub btnLimpiar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLimpiar.Click
        Try
            If Not IsNothing(Modulo_Parametros.modulo_activo) Then
                Modulo_Parametros.modulo_activo.Modulo_Limpiar()
            Else
                MsgBox("Opción no Disponible")
            End If
        Catch ex As Exception
            MsgBox(" Opción no Disponible en este Módulo ")
        End Try

    End Sub

    Private Sub btnImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImprimir.Click
        Try
            If Not IsNothing(Modulo_Parametros.modulo_activo) Then
                Modulo_Parametros.modulo_activo.Modulo_Imprimir()
            Else
                MsgBox("Opción no Disponible")
            End If
        Catch ex As Exception
            MsgBox(" Opción no Disponible en este Módulo ")
        End Try

    End Sub

    Private Sub btnModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModificar.Click
        Try
            If Not IsNothing(Modulo_Parametros.modulo_activo) Then
                Modulo_Parametros.modulo_activo.Modulo_Modificar()
            Else
                MsgBox("Opción no Disponible")
            End If
        Catch ex As Exception
            MsgBox(" Opción no Disponible en este Módulo ")
        End Try
    End Sub

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        Try
            If Not IsNothing(Modulo_Parametros.modulo_activo) Then
                Modulo_Parametros.modulo_activo.Modulo_Eliminar()
            Else
                MsgBox("Opción no Disponible")
            End If
        Catch ex As Exception
            MsgBox(" Opción no Disponible en este Módulo ")
        End Try

    End Sub

    Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click
        Try
            If Not IsNothing(Modulo_Parametros.modulo_activo) Then
                Modulo_Parametros.modulo_activo.Modulo_Grabar()
            Else
                MsgBox("Opción no Disponible")
            End If
        Catch ex As Exception
            MsgBox(" Opción no Disponible en este Módulo ")
        End Try
    End Sub

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

#End Region

#Region "Metodos Menu"

#End Region

    Private Sub ConsultaPlanAnualToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ConsultaPlanAnualToolStripMenuItem.Click
        frmConsultaPlanAnual.Close()
        frmConsultaPlanAnual.MdiParent = Me
        frmConsultaPlanAnual.Show()
    End Sub

    Private Sub RegistroPlanAnualToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles RegistroPlanAnualToolStripMenuItem.Click
        frmRegistroPlanAnual.Close()
        frmRegistroPlanAnual.MdiParent = Me
        frmRegistroPlanAnual.Show()
    End Sub

    Private Sub PresupuestoPlanAnualToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles PresupuestoPlanAnualToolStripMenuItem.Click
        frmPresupuestoPlanAnual.Close()
        frmPresupuestoPlanAnual.MdiParent = Me
        frmPresupuestoPlanAnual.Show()
    End Sub

    Private Sub EvaluacionPresidenciaGeneralToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles EvaluacionPresidenciaGeneralToolStripMenuItem.Click
        frmPlanEvaluacionPGC.Close()
        frmPlanEvaluacionPGC.MdiParent = Me
        frmPlanEvaluacionPGC.Show()
    End Sub

    Private Sub EvaluacionConsejoDirectivoToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles EvaluacionConsejoDirectivoToolStripMenuItem.Click
        frmPlanEvaluacionCD.Close()
        frmPlanEvaluacionCD.MdiParent = Me
        frmPlanEvaluacionCD.Show()
    End Sub

    Private Sub ConsultaDeActividadesToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ConsultaDeActividadesToolStripMenuItem.Click
        frmConsultaActividad.Close()
        frmConsultaActividad.MdiParent = Me
        frmConsultaActividad.Show()
    End Sub

    Private Sub RegistroActividadToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles RegistroActividadToolStripMenuItem.Click
        frmRegistroActividad.Close()
        frmRegistroActividad.MdiParent = Me
        frmRegistroActividad.Show()
    End Sub

    Private Sub ConsultDeActividadesRecurrentesToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ConsultDeActividadesRecurrentesToolStripMenuItem.Click
        frmConsultaActividadRecurrente.Close()
        frmConsultaActividadRecurrente.MdiParent = Me
        frmConsultaActividadRecurrente.Show()
    End Sub

    Private Sub RegistroDeActividadRecurrenteToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles RegistroDeActividadRecurrenteToolStripMenuItem.Click
        frmRegistroActividadRecurrente.Close()
        frmRegistroActividadRecurrente.MdiParent = Me
        frmRegistroActividadRecurrente.Show()
    End Sub

    Private Sub HabilitarActividadToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles HabilitarActividadToolStripMenuItem.Click
        frmHabilitarActividad.Close()
        frmHabilitarActividad.MdiParent = Me
        frmHabilitarActividad.Show()
    End Sub

    Private Sub EvaluacionPresidenteGeneralToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles EvaluacionPresidenteGeneralToolStripMenuItem.Click
        frmActEvaluacionPGC.Close()
        frmActEvaluacionPGC.MdiParent = Me
        frmActEvaluacionPGC.Show()
    End Sub

    Private Sub EvaluacionGerenciaGeneralToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles EvaluacionGerenciaGeneralToolStripMenuItem.Click
        frmActEvaluacionGG.Close()
        frmActEvaluacionGG.MdiParent = Me
        frmActEvaluacionGG.Show()
    End Sub

    Private Sub EvaluacionConsejoDirectivoToolStripMenuItem1_Click(sender As System.Object, e As System.EventArgs) Handles EvaluacionConsejoDirectivoToolStripMenuItem1.Click
        frmActEvaluacionCD.Close()
        frmActEvaluacionCD.MdiParent = Me
        frmActEvaluacionCD.Show()
    End Sub

    Private Sub RegistroDeInscripciónToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles RegistroDeInscripciónToolStripMenuItem.Click
        frmRegistroInscripcion.Close()
        frmRegistroInscripcion.MdiParent = Me
        frmRegistroInscripcion.Show()
    End Sub

    Private Sub RegistroDePagoToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles RegistroDePagoToolStripMenuItem.Click
        frmRegistroPago.Close()
        frmRegistroPago.MdiParent = Me
        frmRegistroPago.Show()
    End Sub

    Private Sub SuscripciónAComitéToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles SuscripciónAComitéToolStripMenuItem.Click
        frmSuscripcionComite.Close()
        frmSuscripcionComite.MdiParent = Me
        frmSuscripcionComite.Show()
    End Sub

    Private Sub RegistrarAsistenciaDeParticipantesToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles RegistrarAsistenciaDeParticipantesToolStripMenuItem.Click
        frmRegistroAsistenciaParticipantes.Close()
        frmRegistroAsistenciaParticipantes.MdiParent = Me
        frmRegistroAsistenciaParticipantes.Show()
    End Sub

    Private Sub RegistrarPersonalToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles RegistrarPersonalToolStripMenuItem.Click
        frmRegistroAsistenciaPersonal.Close()
        frmRegistroAsistenciaPersonal.MdiParent = Me
        frmRegistroAsistenciaPersonal.Show()
    End Sub

    Private Sub RegistrarIncidenciasToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles RegistrarIncidenciasToolStripMenuItem.Click
        frmRegistroIncidencias.Close()
        frmRegistroIncidencias.MdiParent = Me
        frmRegistroIncidencias.Show()
    End Sub

    Private Sub RegistrarEncuestaToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles RegistrarEncuestaToolStripMenuItem.Click
        frmRegistroEncuesta.Close()
        frmRegistroEncuesta.MdiParent = Me
        frmRegistroEncuesta.Show()
    End Sub

    Private Sub ConsultaDeEspaciosToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ConsultaDeEspaciosToolStripMenuItem.Click
        frmCronogramaEspacios.Close()
        frmCronogramaEspacios.MdiParent = Me
        frmCronogramaEspacios.Show()
    End Sub

    Private Sub RegistroDeEspacioToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles RegistroDeEspacioToolStripMenuItem.Click
        frmRegistroEspacio.Close()
        frmRegistroEspacio.MdiParent = Me
        frmRegistroEspacio.Show()
    End Sub
End Class