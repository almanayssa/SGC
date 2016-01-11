Imports SGC.Model.Entidades
Imports SGC.Controller

Public Class frmRegistroAsistenciaParticipantes

    Dim bc As New BusinessController
    Private Actividad As ActividadBE
    Private ListadoActividadDetalles As List(Of ActividadDetalleBE)
    Private ListadoPersona As List(Of PersonaBE)
    Private ListadoAsistencia As List(Of AsistenciaBE)
    Private _id_actividad As Integer

#Region "Inicializacion"

    Public Sub New()
        InitializeComponent()

        dgvProgramacion.AutoGenerateColumns = False
        dgvPersona.AutoGenerateColumns = False

        colSede.DataPropertyName = "des_sede"
        colEspacio.DataPropertyName = "nombre_espacio"
        colFecInicio.DataPropertyName = "fecha"
        colHoraInicio.DataPropertyName = "hora_ini"
        'colFecFin.DataPropertyName = "fecha_fin"
        colHoraFin.DataPropertyName = "hora_fin"

        colDetalleID.DataPropertyName = "id_detalle"
        colPersonaID.DataPropertyName = "id_persona"
        colNombre.DataPropertyName = "nombre_completo"

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
        ListarPersonaXActividad()
        ListarAsistencia()
    End Sub

    Private Sub ListarDetallesXActividad()
        ListadoActividadDetalles = bc.ListarDetallesXActividad(CInt(txtCodigo.Text.Trim))
        dgvProgramacion.DataSource = Nothing
        dgvProgramacion.DataSource = ListadoActividadDetalles
    End Sub

    Private Sub ListarPersonaXActividad()
        ListadoPersona = bc.ListarPersonaXActividad(CInt(txtCodigo.Text.Trim))
        dgvPersona.DataSource = Nothing
        dgvPersona.DataSource = ListadoPersona
    End Sub

    Private Sub ListarAsistencia()
        ListadoAsistencia = bc.ListarAsistencia(CInt(txtCodigo.Text.Trim))

        If ListadoAsistencia IsNot Nothing AndAlso ListadoAsistencia.Count > 0 Then
            For Each row As DataGridViewRow In dgvPersona.Rows
                Dim chk = DirectCast(row.Cells(colSeleccionar.Index), DataGridViewCheckBoxCell)
                Dim id As String = row.Cells(colPersonaID.Index).Value

                For Each oAsistencia As AsistenciaBE In ListadoAsistencia
                    If oAsistencia.id_persona = id Then
                        chk.Value = oAsistencia.flg_asistencia
                        Exit For
                    End If
                Next
            Next
        End If
    End Sub

    Private Sub LimpiarFormulario()
        tsbGuardar.Visible = False

        txtCodigo.Text = String.Empty
        txtActividad.Text = String.Empty

        ListadoActividadDetalles = Nothing
        ListadoAsistencia = Nothing
        ListadoPersona = Nothing

        dgvProgramacion.DataSource = Nothing
        dgvPersona.DataSource = Nothing

    End Sub

    Private Function GuardarAsistencia() As Boolean
        Dim flag As Boolean = True

        Dim affectedRows As Integer = 0
        Dim oActividad As New ActividadBE
        oActividad.id_actividad = txtCodigo.Text

        Dim oAsistencia As AsistenciaBE

        For Each row As DataGridViewRow In dgvPersona.Rows
            Dim value As Boolean = CType(dgvPersona.Item(colSeleccionar.Index, row.Index).EditedFormattedValue, Boolean)
            Dim oPersona As PersonaBE = row.DataBoundItem

            oAsistencia = New AsistenciaBE
            oAsistencia.id_detalle = oPersona.id_detalle
            oAsistencia.fecha = Now
            oAsistencia.flg_asistencia = value

            If oActividad.ListaAsistencia Is Nothing Then
                oActividad.ListaAsistencia = New List(Of AsistenciaBE)
            End If

            oActividad.ListaAsistencia.Add(oAsistencia)
        Next

        affectedRows = bc.InsertarAsistencia(oActividad)

        If affectedRows = 0 Then
            MessageBox.Show("Error al grabar", "Información")
            flag = False
        Else
            _id_actividad = oActividad.id_actividad
            MessageBox.Show("La asistencia de los participantes se registró satisfactoriamente", "Información")
        End If

        Return flag
    End Function

#End Region

#Region "Cargar"

    Private Sub frmRegistroAsistenciaParticipantes_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        LimpiarFormulario()
    End Sub

#End Region

#Region "Metodos Controles"

    Private Sub tsbLimpiar_Click(sender As System.Object, e As System.EventArgs) Handles tsbLimpiar.Click
        LimpiarFormulario()
    End Sub

    Private Sub tsbGuardar_Click(sender As System.Object, e As System.EventArgs) Handles tsbGuardar.Click
        If GuardarAsistencia() Then
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
            If ListadoAsistencia IsNot Nothing AndAlso ListadoAsistencia.Count > 0 Then
                tsbGuardar.Visible = False
                dgvPersona.ReadOnly = True
            Else
                tsbGuardar.Visible = True
                dgvPersona.ReadOnly = False
            End If
        End If
    End Sub

#End Region

End Class