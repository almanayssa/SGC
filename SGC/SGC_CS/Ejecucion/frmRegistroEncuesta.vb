Imports SGC.Model.Entidades
Imports SGC.Controller

Public Class frmRegistroEncuesta

    Dim bc As New BusinessController
    Private Actividad As ActividadBE
    Private Encuesta As EncuestaActividadBE
    Private ListadoEncuestaDetalle As List(Of EncuestaDetalleBE)
    Private ListadoPreguntas As List(Of EncuestaDetalleBE)
    Private _id_actividad As Integer

#Region "Inicializacion"

    Public Sub New()
        InitializeComponent()

        dgvPreguntas.AutoGenerateColumns = False

        colPregunta.DataPropertyName = "pregunta"
        colOpcion1.DataPropertyName = "opcion1"
        colOpcion2.DataPropertyName = "opcion2"
        colOpcion3.DataPropertyName = "opcion3"

    End Sub

#End Region

#Region "Métodos Personalizados"

    Private Sub FormularioEnModoEdicion()
        tsbGuardar.Visible = True
        txtDescripcion.Enabled = True
        dgvPreguntas.ReadOnly = False
        btnAgregarPregunta.Enabled = True
        btnQuitarPregunta.Enabled = True
    End Sub

    Private Sub FormularioEnModoVista()
        tsbGuardar.Visible = False
        txtDescripcion.Enabled = False
        dgvPreguntas.ReadOnly = True
        btnAgregarPregunta.Enabled = False
        btnQuitarPregunta.Enabled = False
    End Sub

    Private Sub CargarActividad(ByVal id_actividad As String)
        Dim oActividad As ActividadBE = bc.CargarActividadCabecera(id_actividad)
        Actividad = oActividad
        txtCodigo.Text = oActividad.id_actividad
        txtActividad.Text = "Actividad: " & oActividad.nombre & vbCrLf & _
                            "Tipo de Actividad: " & oActividad.desc_tipo & vbCrLf & _
                            "Comite: " & oActividad.nombrecomite & vbCrLf & _
                            "Pago: " & oActividad.monto_pago & vbCrLf & _
                            "Vacantes: " & oActividad.vacantes

        ObtenerEncuesta()
    End Sub

    Private Sub ObtenerEncuesta()
        Encuesta = bc.ObtenerEncuesta(CInt(txtCodigo.Text.Trim))
        txtDescripcion.Text = Encuesta.descripcion

        ListadoEncuestaDetalle = Encuesta.ListadoEncuestaDetalle
        dgvPreguntas.DataSource = Nothing
        dgvPreguntas.DataSource = ListadoEncuestaDetalle
    End Sub

    Private Sub AgregarPregunta()
        Dim oEncuestaDetalle As New EncuestaDetalleBE

        oEncuestaDetalle.pregunta = Nothing
        oEncuestaDetalle.opcion1 = Nothing
        oEncuestaDetalle.opcion2 = Nothing
        oEncuestaDetalle.opcion3 = Nothing

        If ListadoPreguntas Is Nothing Then
            ListadoPreguntas = New List(Of EncuestaDetalleBE)
        End If

        ListadoPreguntas.Add(oEncuestaDetalle)

        dgvPreguntas.DataSource = Nothing
        dgvPreguntas.DataSource = ListadoPreguntas
    End Sub

    Private Sub QuitarPregunta()
        Dim oListadoEncuestaDetalle As New List(Of EncuestaDetalleBE)

        For Each row As DataGridViewRow In dgvPreguntas.Rows
            Dim oEncuestaDetalle As EncuestaDetalleBE = row.DataBoundItem
            If row.Selected = False Then
                oListadoEncuestaDetalle.Add(oEncuestaDetalle)
            End If
        Next

        ListadoPreguntas = oListadoEncuestaDetalle
        dgvPreguntas.DataSource = Nothing
        dgvPreguntas.DataSource = ListadoPreguntas
    End Sub

    Private Sub LimpiarFormulario()
        tsbGuardar.Visible = False

        txtCodigo.Text = String.Empty
        txtActividad.Text = String.Empty
        txtDescripcion.Text = String.Empty

        ListadoEncuestaDetalle = Nothing
        ListadoPreguntas = Nothing

        dgvPreguntas.DataSource = Nothing

        btnAgregarPregunta.Enabled = False
        btnQuitarPregunta.Enabled = False

    End Sub

    Private Function ValidarCamposRequeridos() As String
        Dim msg As String = String.Empty

        If txtDescripcion.Text.Trim = String.Empty Then
            msg &= vbCrLf & "- Ingrese una descripción"
        End If

        msg &= ValidarPreguntas()

        Return msg
    End Function

    Private Function ValidarPreguntas() As String
        Dim msg As String = String.Empty

        If dgvPreguntas.Rows.Count = 0 Then
            msg &= vbCrLf & "- Agregue una pregunta por lo menos"
        End If

        For Each row As DataGridViewRow In dgvPreguntas.Rows
            If msg <> String.Empty Then
                Exit For
            End If

            If row.Cells(colPregunta.Index).Value = Nothing Then
                msg &= vbCrLf & "- Ingrese la descripción de todas las preguntas"
            End If

            If row.Cells(colOpcion1.Index).Value = Nothing Then
                msg &= vbCrLf & "- Ingrese una cantidad en la opción 1 de todas las preguntas"
            End If

            If row.Cells(colOpcion2.Index).Value = Nothing Then
                msg &= vbCrLf & "- Ingrese una cantidad en la opción 2 de todas las preguntas"
            End If

            If row.Cells(colOpcion3.Index).Value = Nothing Then
                msg &= vbCrLf & "- Ingrese una cantidad en la opción 3 de todas las preguntas"
            End If
        Next

        Return msg
    End Function

    Private Function GuardarEncuesta() As Boolean
        Dim flag As Boolean = True

        If ValidarCamposRequeridos() <> String.Empty Then
            MessageBox.Show(ValidarCamposRequeridos, "Información")
            flag = False
            Return flag
            Exit Function
        End If

        Dim affectedRows As Integer = 0
        Dim oEncuesta As New EncuestaActividadBE
        oEncuesta.descripcion = txtDescripcion.Text
        oEncuesta.id_actividad = txtCodigo.Text

        Dim oEncuestaDetalle As EncuestaDetalleBE

        For Each row As DataGridViewRow In dgvPreguntas.Rows
            oEncuestaDetalle = New EncuestaDetalleBE
            oEncuestaDetalle.pregunta = row.Cells(colPregunta.Index).Value
            oEncuestaDetalle.opcion1 = row.Cells(colOpcion1.Index).Value
            oEncuestaDetalle.opcion2 = row.Cells(colOpcion2.Index).Value
            oEncuestaDetalle.opcion3 = row.Cells(colOpcion3.Index).Value

            If ListadoEncuestaDetalle Is Nothing Then
                ListadoEncuestaDetalle = New List(Of EncuestaDetalleBE)
            End If

            ListadoEncuestaDetalle.Add(oEncuestaDetalle)
        Next

        oEncuesta.ListadoEncuestaDetalle = ListadoEncuestaDetalle
        affectedRows = bc.InsertarEncuesta(oEncuesta)

        If affectedRows = 0 Then
            MessageBox.Show("Error al grabar", "Información")
            flag = False
        Else
            MessageBox.Show("La encuesta se registró satisfactoriamente", "Información")
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
        If GuardarEncuesta() Then
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
            If Encuesta IsNot Nothing AndAlso Encuesta.id_encuesta > 0 Then
                FormularioEnModoVista()
            Else
                FormularioEnModoEdicion()
            End If
        End If
    End Sub

    Private Sub btnAgregarPregunta_Click(sender As System.Object, e As System.EventArgs) Handles btnAgregarPregunta.Click
        AgregarPregunta()
    End Sub

    Private Sub btnQuitarPregunta_Click(sender As System.Object, e As System.EventArgs) Handles btnQuitarPregunta.Click
        QuitarPregunta()
    End Sub

#End Region

End Class
