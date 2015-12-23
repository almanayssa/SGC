Imports SGC.Model.Entidades
Imports SGC.Controller

Public Class frmRegistroAsistenciaPersonal

    Dim bc As New BusinessController
    Private Actividad As ActividadBE
    Private ListadoActividadDetalles As List(Of ActividadDetalleBE)
    Private ListadoPersonal As List(Of PersonalBE)
    Private ListadoAsistenciaPersonal As List(Of AsistenciaPersonalBE)
    Private _id_actividad As Integer

#Region "Inicializacion"

    Public Sub New()
        InitializeComponent()

        dgvProgramacion.AutoGenerateColumns = False
        dgvPersonal.AutoGenerateColumns = False

        colSede.DataPropertyName = "des_sede"
        colEspacio.DataPropertyName = "nombre_espacio"
        colFecInicio.DataPropertyName = "fecha_ini"
        colHoraInicio.DataPropertyName = "hora_ini"
        colFecFin.DataPropertyName = "fecha_fin"
        colHoraFin.DataPropertyName = "hora_fin"

        colPersonalID.DataPropertyName = "id_personal"
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
        ListarPersonalXActividad()
        ListarAsistenciaPersonal()
    End Sub

    Private Sub ListarDetallesXActividad()
        ListadoActividadDetalles = bc.ListarDetallesXActividad(CInt(txtCodigo.Text.Trim))
        dgvProgramacion.DataSource = Nothing
        dgvProgramacion.DataSource = ListadoActividadDetalles
    End Sub

    Private Sub ListarPersonalXActividad()
        ListadoPersonal = bc.ListarPersonalXActividad(CInt(txtCodigo.Text.Trim))
        dgvPersonal.DataSource = Nothing
        dgvPersonal.DataSource = ListadoPersonal
    End Sub

    Private Sub ListarAsistenciaPersonal()
        ListadoAsistenciaPersonal = bc.ListarAsistenciaPersonal(CInt(txtCodigo.Text.Trim))

        If ListadoAsistenciaPersonal IsNot Nothing AndAlso ListadoAsistenciaPersonal.Count > 0 Then
            For Each row As DataGridViewRow In dgvPersonal.Rows
                Dim chk = DirectCast(row.Cells(colSeleccionar.Index), DataGridViewCheckBoxCell)
                Dim id As Integer = row.Cells(colPersonalID.Index).Value

                For Each oAsistencia As AsistenciaPersonalBE In ListadoAsistenciaPersonal
                    If oAsistencia.id_personal = id Then
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
        ListadoAsistenciaPersonal = Nothing
        ListadoPersonal = Nothing

        dgvProgramacion.DataSource = Nothing
        dgvPersonal.DataSource = Nothing

    End Sub

    Private Function GuardarAsistenciaPersonal() As Boolean
        Dim flag As Boolean = True

        Dim affectedRows As Integer = 0
        Dim oActividad As New ActividadBE
        oActividad.id_actividad = txtCodigo.Text

        Dim oAsistenciaPersonal As AsistenciaPersonalBE

        For Each row As DataGridViewRow In dgvPersonal.Rows
            Dim value As Boolean = CType(dgvPersonal.Item(colSeleccionar.Index, row.Index).EditedFormattedValue, Boolean)
            Dim oPersonal As PersonalBE = row.DataBoundItem

            oAsistenciaPersonal = New AsistenciaPersonalBE
            oAsistenciaPersonal.id_personal = oPersonal.id_personal
            oAsistenciaPersonal.fecha = Now
            oAsistenciaPersonal.flg_asistencia = value

            If oActividad.ListaAsistenciaPersonal Is Nothing Then
                oActividad.ListaAsistenciaPersonal = New List(Of AsistenciaPersonalBE)
            End If

            oActividad.ListaAsistenciaPersonal.Add(oAsistenciaPersonal)
        Next

        affectedRows = bc.InsertarAsistenciaPersonal(oActividad)

        If affectedRows = 0 Then
            MessageBox.Show("Error al grabar", "Información")
            flag = False
        Else
            _id_actividad = oActividad.id_actividad
            MessageBox.Show("La asistencia del personal se registró satisfactoriamente", "Información")
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
        If GuardarAsistenciaPersonal() Then
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
            If ListadoAsistenciaPersonal IsNot Nothing AndAlso ListadoAsistenciaPersonal.Count > 0 Then
                tsbGuardar.Visible = False
                dgvPersonal.ReadOnly = True
            Else
                tsbGuardar.Visible = True
                dgvPersonal.ReadOnly = False
            End If
        End If
    End Sub

#End Region

End Class
