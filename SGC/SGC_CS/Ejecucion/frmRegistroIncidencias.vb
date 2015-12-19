Imports SGC.Model.Entidades
Imports SGC.Controller

Public Class frmRegistroIncidencias

    Dim bc As New BusinessController
    Private Actividad As ActividadBE
    Private ListadoActividadDetalles As List(Of ActividadDetalleBE)
    Private Incidencia As IncidenciaBE
    Private _id_actividad As Integer

#Region "Inicializacion"

    Public Sub New()
        InitializeComponent()

        dgvProgramacion.AutoGenerateColumns = False

        colSede.DataPropertyName = "des_sede"
        colEspacio.DataPropertyName = "nombre_espacio"
        colFecInicio.DataPropertyName = "fecha_ini"
        colHoraInicio.DataPropertyName = "hora_ini"
        colFecFin.DataPropertyName = "fecha_fin"
        colHoraFin.DataPropertyName = "hora_fin"
        colVacantes.DataPropertyName = "vacantes"

    End Sub

#End Region

#Region "Métodos Personalizados"

    Private Sub CargarActividad(ByVal id_actividad As String)
        Dim oActividad As ActividadBE = bc.CargarActividadCabecera(id_actividad)
        Actividad = oActividad
        txtCodigo.Text = oActividad.id_actividad
        txtActividad.Text = "Actividad: " & oActividad.nombre & vbCrLf & _
                            "Tipo de Actividad: " & oActividad.desc_tipo & vbCrLf & _
                            "Comite: " & oActividad.nombrecomite & vbCrLf & _
                            "Pago: " & oActividad.monto_pago & vbCrLf & _
                            "Vacantes: " & oActividad.vacantes

        ListarDetallesXActividad()
        ObtenerIncidencia()
    End Sub

    Private Sub ListarDetallesXActividad()
        ListadoActividadDetalles = bc.ListarDetallesXActividad(CInt(txtCodigo.Text.Trim))
        dgvProgramacion.DataSource = Nothing
        dgvProgramacion.DataSource = ListadoActividadDetalles
    End Sub

    Private Sub ObtenerIncidencia()
        Incidencia = bc.ObtenerIncidencia(CInt(txtCodigo.Text.Trim))
        txtIncidencias.Text = Incidencia.incidencia
    End Sub

    Private Sub LimpiarFormulario()
        tsbGuardar.Visible = False

        txtCodigo.Text = String.Empty
        txtActividad.Text = String.Empty
        txtIncidencias.Text = String.Empty

        ListadoActividadDetalles = Nothing
        dgvProgramacion.DataSource = Nothing

        txtIncidencias.Enabled = False
    End Sub

    Private Function ValidarCamposRequeridos() As String
        Dim msg As String = String.Empty

        If txtIncidencias.Text.Trim = String.Empty Then
            msg &= vbCrLf & "- Ingrese una incidencia"
        End If

        Return msg
    End Function

    Private Function GuardarIncidencias() As Boolean
        Dim flag As Boolean = True

        If ValidarCamposRequeridos() <> String.Empty Then
            MessageBox.Show(ValidarCamposRequeridos, "Información")
            flag = False
            Return flag
            Exit Function
        End If

        Dim affectedRows As Integer = 0
        Dim oIncidencia As New IncidenciaBE
        oIncidencia.id_actividad = txtCodigo.Text
        oIncidencia.incidencia = txtIncidencias.Text.Trim

        affectedRows = bc.InsertarIncidencia(oIncidencia)

        If affectedRows = 0 Then
            MessageBox.Show("Error al grabar", "Información")
            flag = False
        Else
            MessageBox.Show("La incidencia se registró satisfactoriamente", "Información")
        End If

        Return flag
    End Function

#End Region

#Region "Cargar"

    Private Sub frmRegistroAsistenciaPersonal_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        LimpiarFormulario()
    End Sub

#End Region

#Region "Metodos Controles"

    Private Sub tsbLimpiar_Click(sender As System.Object, e As System.EventArgs) Handles tsbLimpiar.Click
        LimpiarFormulario()
    End Sub

    Private Sub tsbGuardar_Click(sender As System.Object, e As System.EventArgs) Handles tsbGuardar.Click
        If GuardarIncidencias() Then
            LimpiarFormulario()
        End If
    End Sub

    Private Sub btnBuscar_Click(sender As System.Object, e As System.EventArgs) Handles btnBuscar.Click
        Dim frmBuscarActividad As New frmBuscarActividad
        frmBuscarActividad.id_estado = "EST005"
        frmBuscarActividad.ShowDialog()

        If frmBuscarActividad.ActividadSeleccionada IsNot Nothing Then
            _id_actividad = frmBuscarActividad.ActividadSeleccionada.id_actividad
            CargarActividad(frmBuscarActividad.ActividadSeleccionada.id_actividad)
            If Incidencia IsNot Nothing AndAlso Incidencia.id_incidencia > 0 Then
                tsbGuardar.Visible = False
                txtIncidencias.Enabled = False
            Else
                tsbGuardar.Visible = True
                txtIncidencias.Enabled = True
            End If
        End If
    End Sub

#End Region

End Class
