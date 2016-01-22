Imports SGC.Model.Entidades
Imports SGC.Controller
Imports System.Net
Imports System.Net.Mail

Public Class frmRegistroActividad

    Dim bc As New BusinessController
    Private Actividad As ActividadBE
    Private ListadoActividadDetalles As List(Of ActividadDetalleBE)
    Private ListadoTipoPersonal As List(Of TipoPersonalBE)
    Private ListadoRecursos As List(Of RecursoBE)
    Private ListadoRestricciones As List(Of RestriccionesBE)
    Private oPersonalPendiente As TipoPersonalBE
    Private oRecursoPendiente As RecursoBE
    Private _id_actividad As Integer
    Private ListadoProgramacion As List(Of ActividadDetalleBE)
    Dim msjTipo As String
    Dim msjVacantes As String
    Dim msjFecha As String
    Dim msjRecursos As String
    Dim msjTipoPersonal As String

#Region "Inicializacion"

    Public Sub New()
        InitializeComponent()

        cboComite.ValueMember = "id_comite"
        cboComite.DisplayMember = "nombre"

        cboTipo.ValueMember = "id_tipo_act"
        cboTipo.DisplayMember = "desc_tipo"

        dgvProgramacion.AutoGenerateColumns = False
        dgvRestricciones.AutoGenerateColumns = False
        dgvTipoPersonal.AutoGenerateColumns = False
        dgvRecursos.AutoGenerateColumns = False

        colSede.DataPropertyName = "des_sede"
        colEspacio.DataPropertyName = "nombre_espacio"
        colFecInicio.DataPropertyName = "fecha"
        colHoraInicio.DataPropertyName = "hora_ini"
        'colFecFin.DataPropertyName = "fecha_fin"
        colHoraFin.DataPropertyName = "hora_fin"

        colRestriccionID.DataPropertyName = "id_restriccion"
        colDescripcionRestriccion.DataPropertyName = "descripcion"
        colCondicionRestriccion.DataPropertyName = "signo"
        colCantidadRestriccion.DataPropertyName = "valor"
        colFlgCondicion.DataPropertyName = "flg_condicion"

        colDescripcionPersonal.DataPropertyName = "descripcion"
        colCantidadPersonal.DataPropertyName = "cantidad"

        colDescripcionRecurso.DataPropertyName = "descripcion"
        colCantidadRecurso.DataPropertyName = "cantidad"
        
    End Sub

#End Region

#Region "Propiedades"

    Private _id_act As String
    Public Property id_act() As String
        Get
            Return _id_act
        End Get
        Set(ByVal value As String)
            _id_act = value
        End Set
    End Property
#End Region

#Region "Metodos Personalizados"

    Private Sub FormularioEnModoEdicion()
        tsbLimpiar.Visible = False
        tsbGuardar.Visible = True
        tsbEditar.Visible = False
        tsbEliminar.Visible = False
        tsbCancelar.Visible = True
        tsbReprogramacion.Visible = False

        cboComite.Enabled = True
        cboTipo.Enabled = True
        If cboCategoria.DataSource IsNot Nothing Then
            cboCategoria.Enabled = True
        Else
            cboCategoria.Enabled = False
        End If
        txtNombre.Enabled = True
        txtDescripcion.Enabled = True
        nudPago.Enabled = True

        btnEscoger.Enabled = True
        btnLimpiar.Enabled = True
        btnBuscarPersonal.Enabled = True
        btnAgregarTipoPersonal.Enabled = True
        btnQuitarTipoPersonal.Enabled = True
        txtCantidadPersonal.Enabled = True
        btnBuscarRecurso.Enabled = True
        btnAgregarRecurso.Enabled = True
        btnQuitarRecurso.Enabled = True
        txtCantidadRecurso.Enabled = True

        dgvRestricciones.ReadOnly = False
    End Sub

    Private Sub FormularioEnModoVista()
        tsbLimpiar.Visible = True
        tsbGuardar.Visible = False
        tsbEditar.Visible = True
        tsbEliminar.Visible = True
        tsbCancelar.Visible = False
        tsbReprogramacion.Visible = True

        cboComite.Enabled = False
        cboTipo.Enabled = False
        cboCategoria.Enabled = False
        txtNombre.Enabled = False
        txtDescripcion.Enabled = False
        nudPago.Enabled = False
        nudVacantes.Enabled = False

        btnEscoger.Enabled = False
        btnLimpiar.Enabled = False
        btnBuscarPersonal.Enabled = False
        btnAgregarTipoPersonal.Enabled = False
        btnQuitarTipoPersonal.Enabled = False
        txtCantidadPersonal.Enabled = False
        btnBuscarRecurso.Enabled = False
        btnAgregarRecurso.Enabled = False
        btnQuitarRecurso.Enabled = False
        txtCantidadRecurso.Enabled = False
        dgvRestricciones.ReadOnly = True
    End Sub

    Private Sub FormularioEnModoReprogramacion()
        tsbLimpiar.Visible = True
        tsbGuardar.Visible = True
        tsbEditar.Visible = False
        tsbEliminar.Visible = False
        tsbCancelar.Visible = True
        tsbReprogramacion.Visible = False

        cboComite.Enabled = False
        cboTipo.Enabled = False
        cboCategoria.Enabled = False
        txtNombre.Enabled = False
        txtDescripcion.Enabled = False
        nudPago.Enabled = False
        nudVacantes.Enabled = False

        btnEscoger.Enabled = True
        btnLimpiar.Enabled = True
        btnBuscarPersonal.Enabled = False
        btnAgregarTipoPersonal.Enabled = False
        btnQuitarTipoPersonal.Enabled = False
        txtCantidadPersonal.Enabled = False
        btnBuscarRecurso.Enabled = False
        btnAgregarRecurso.Enabled = False
        btnQuitarRecurso.Enabled = False
        txtCantidadRecurso.Enabled = False
        dgvRestricciones.ReadOnly = True

        ListadoProgramacion = dgvProgramacion.DataSource
    End Sub

    Private Sub ListarComites()
        Dim oComite As New ComiteBE
        oComite.id_comite = "000"
        oComite.nombre = "- Seleccione -"

        Dim ListadoComites As List(Of ComiteBE) = bc.ListarComites()
        ListadoComites.Insert(0, oComite)
        cboComite.DataSource = Nothing
        cboComite.DataSource = ListadoComites
    End Sub

    Private Sub ListarTipoActividad()
        Dim ListadoTipoActividad As List(Of TipoActividadBE) = bc.ListarTipoActividad()
        cboTipo.DataSource = Nothing
        cboTipo.DataSource = ListadoTipoActividad
    End Sub

    Private Sub ListarRestricciones()
        Dim ListadoRestricciones As List(Of RestriccionesBE) = bc.ListarRestricciones()
        dgvRestricciones.DataSource = Nothing
        dgvRestricciones.DataSource = ListadoRestricciones
    End Sub

    Private Sub ListarSignos()
        Dim ListadoSignos As List(Of SignosBE) = bc.ListarSignos()
        Dim colCondicionRestriccion As DataGridViewComboBoxColumn
        colCondicionRestriccion = dgvRestricciones.Columns("colCondicionRestriccion")
        colCondicionRestriccion.DataSource = ListadoSignos
        colCondicionRestriccion.ValueMember = "id_signo"
        colCondicionRestriccion.DisplayMember = "signo"
    End Sub

    Private Sub CargarActividad(ByVal id_actividad As Integer)
        Dim oActividad As ActividadBE = bc.CargarActividadCabecera(id_actividad)
        Actividad = oActividad
        txtCodigo.Text = oActividad.id_actividad
        cboComite.SelectedValue = oActividad.id_comite
        cboTipo.SelectedValue = oActividad.id_tipo_act
        If oActividad.id_cattipo_act IsNot Nothing Then
            cboCategoria.SelectedValue = oActividad.id_cattipo_act
        End If
        txtNombre.Text = oActividad.nombre
        txtDescripcion.Text = oActividad.descripcion
        nudPago.Value = oActividad.monto_pago
        nudVacantes.Value = oActividad.vacantes

        ListarDetallesXActividad()
        ListarTipoPersonalXActividad()
        ListarRecursosXActividad()
        ListarRestriccionesXActividad()
    End Sub

    Private Sub CargarTipoPersonal(ByRef oTipoPersonal As TipoPersonalBE)
        txtDescripcionPersonal.Text = oTipoPersonal.descripcion
    End Sub

    Private Sub CargarRecurso(ByRef oRecurso As RecursoBE)
        txtDescripcionRecurso.Text = oRecurso.descripcion
    End Sub

    Private Function ValidarAgregarTipoPersonal() As String
        Dim msg As String = String.Empty

        If txtDescripcionPersonal.Text = String.Empty Then
            msg &= vbCrLf & "- Seleccione un tipo de personal"
        End If

        If txtCantidadPersonal.Text = String.Empty Then
            msg &= vbCrLf & "- Ingrese una cantidad para el tipo de personal"
        Else
            If CInt(txtCantidadPersonal.Text) = 0 Then
                msg &= vbCrLf & "- La cantidad debe ser mayor a cero (0)"
            End If
        End If

        Return msg
    End Function

    Private Function ValidarAgregarRecurso() As String
        Dim msg As String = String.Empty

        If txtDescripcionRecurso.Text = String.Empty Then
            msg &= vbCrLf & "- Seleccione un recurso"
        End If

        If txtCantidadRecurso.Text = String.Empty Then
            msg &= vbCrLf & "- Ingrese una cantidad para el recurso"
        Else
            If CInt(txtCantidadRecurso.Text) = 0 Then
                msg &= vbCrLf & "- La cantidad debe ser mayor a cero (0)"
            End If
        End If

        Return msg
    End Function

    Private Sub ListarDetallesXActividad()
        ListadoActividadDetalles = bc.ListarDetallesXActividad(CInt(txtCodigo.Text.Trim))
        dgvProgramacion.DataSource = Nothing
        dgvProgramacion.DataSource = ListadoActividadDetalles
    End Sub

    Private Sub ListarTipoPersonalXActividad()
        ListadoTipoPersonal = bc.ListarTipoPersonalXActividad(CInt(txtCodigo.Text.Trim))
        dgvTipoPersonal.DataSource = Nothing
        dgvTipoPersonal.DataSource = ListadoTipoPersonal
    End Sub

    Private Sub ListarRecursosXActividad()
        ListadoRecursos = bc.ListarRecursosXActividad(CInt(txtCodigo.Text.Trim))
        dgvRecursos.DataSource = Nothing
        dgvRecursos.DataSource = ListadoRecursos
    End Sub

    Private Sub ListarRestriccionesXActividad()
        ListarRestricciones()
        ListadoRestricciones = bc.ListarRestriccionesXActividad(CInt(txtCodigo.Text.Trim))

        If ListadoRestricciones IsNot Nothing AndAlso ListadoRestricciones.Count > 0 Then
            For Each row As DataGridViewRow In dgvRestricciones.Rows
                Dim chk = DirectCast(row.Cells(colSeleccionar.Index), DataGridViewCheckBoxCell)
                Dim id As Integer = CInt(row.Cells(colRestriccionID.Index).Value)

                For Each oRestriccion As RestriccionesBE In ListadoRestricciones
                    If oRestriccion.id_restriccion = id Then
                        chk.Value = True
                        row.Cells(colCondicionRestriccion.Index).Value = oRestriccion.id_signo
                        row.Cells(colCantidadRestriccion.Index).Value = oRestriccion.valor
                        Exit For
                    End If
                Next
            Next
        End If
    End Sub

    Private Sub AgregarTipoPersonal(ByRef oTipoPersonal As TipoPersonalBE)
        If ValidarAgregarTipoPersonal() <> String.Empty Then
            MessageBox.Show(ValidarAgregarTipoPersonal, "Información")
            Exit Sub
        End If

        If ListadoTipoPersonal Is Nothing Then
            ListadoTipoPersonal = New List(Of TipoPersonalBE)
        End If
        oTipoPersonal.cantidad = txtCantidadPersonal.Text.Trim
        ListadoTipoPersonal.Add(oTipoPersonal)
        txtDescripcionPersonal.Text = String.Empty
        txtCantidadPersonal.Text = String.Empty
        dgvTipoPersonal.DataSource = Nothing
        dgvTipoPersonal.DataSource = ListadoTipoPersonal
    End Sub

    Private Sub AgregarRecurso(ByRef oRecurso As RecursoBE)
        If ValidarAgregarRecurso() <> String.Empty Then
            MessageBox.Show(ValidarAgregarRecurso, "Información")
            Exit Sub
        End If

        If ListadoRecursos Is Nothing Then
            ListadoRecursos = New List(Of RecursoBE)
        End If
        oRecurso.cantidad = txtCantidadRecurso.Text.Trim
        oRecurso.cantidad_real = txtCantidadRecurso.Text.Trim
        ListadoRecursos.Add(oRecurso)
        txtDescripcionRecurso.Text = String.Empty
        txtCantidadRecurso.Text = String.Empty
        dgvRecursos.DataSource = Nothing
        dgvRecursos.DataSource = ListadoRecursos
    End Sub

    Private Sub QuitarTipoPersonal(ByRef oTipoPersonal As TipoPersonalBE)
        If ListadoTipoPersonal IsNot Nothing Then
            ListadoTipoPersonal.Remove(oTipoPersonal)
        End If
        dgvTipoPersonal.DataSource = Nothing
        dgvTipoPersonal.DataSource = ListadoTipoPersonal
    End Sub

    Private Sub QuitarRecurso(ByRef oRecurso As RecursoBE)
        If ListadoRecursos IsNot Nothing Then
            ListadoRecursos.Remove(oRecurso)
        End If
        dgvRecursos.DataSource = Nothing
        dgvRecursos.DataSource = ListadoRecursos
    End Sub

    Private Sub LimpiarFormulario()
        tsbLimpiar.Visible = True
        tsbGuardar.Visible = True
        tsbEditar.Visible = False
        tsbEliminar.Visible = False
        tsbCancelar.Visible = False
        tsbReprogramacion.Visible = False

        txtCodigo.Text = String.Empty
        cboComite.SelectedIndex = 0
        cboTipo.SelectedIndex = 0
        cboCategoria.SelectedIndex = -1
        txtNombre.Text = String.Empty
        txtDescripcion.Text = String.Empty
        nudPago.Value = 0.0
        nudVacantes.Value = 0

        txtDescripcionPersonal.Text = String.Empty
        txtCantidadPersonal.Text = String.Empty
        txtDescripcionRecurso.Text = String.Empty
        txtCantidadRecurso.Text = String.Empty

        dgvProgramacion.DataSource = Nothing
        dgvTipoPersonal.DataSource = Nothing
        dgvRecursos.DataSource = Nothing

        ListadoActividadDetalles = Nothing
        ListadoRecursos = Nothing
        ListadoRestricciones = Nothing
        ListadoTipoPersonal = Nothing
        oPersonalPendiente = Nothing
        oRecursoPendiente = Nothing

        ListarRestricciones()

        cboComite.Enabled = True
        cboTipo.Enabled = True
        If cboCategoria.DataSource IsNot Nothing Then
            cboCategoria.Enabled = True
        Else
            cboCategoria.Enabled = False
        End If
        txtNombre.Enabled = True
        txtDescripcion.Enabled = True
        nudPago.Enabled = True

        btnEscoger.Enabled = True
        btnLimpiar.Enabled = True
        btnBuscarPersonal.Enabled = True
        btnAgregarTipoPersonal.Enabled = True
        btnQuitarTipoPersonal.Enabled = True
        txtCantidadPersonal.Enabled = True
        btnBuscarRecurso.Enabled = True
        btnAgregarRecurso.Enabled = True
        btnQuitarRecurso.Enabled = True
        txtCantidadRecurso.Enabled = True
        nudVacantes.Enabled = True

        dgvRestricciones.ReadOnly = False

        btntipo.Visible = False
        btnVacantes.Visible = False
        btnFechas.Visible = False
        btnRecursos.Visible = False
        btnTipoPersonal.Visible = False

        msjTipo = ""
        msjVacantes = ""
        msjFecha = ""
        msjRecursos = ""
        msjTipoPersonal = ""
    End Sub

    Private Function ValidarCamposRequeridos() As String
        Dim msg As String = String.Empty

        If cboComite.SelectedValue = "000" Then
            msg &= vbCrLf & "- Seleccione un comité"
        End If

        If cboTipo.SelectedValue = "00" Then
            msg &= vbCrLf & "- Seleccione un tipo"
        End If

        If cboCategoria.Enabled Then
            If cboCategoria.SelectedValue = 0 Then
                msg &= vbCrLf & "- Seleccione una categoría"
            End If
        End If

        If txtNombre.Text.Trim = String.Empty Then
            msg &= vbCrLf & "- Ingrese un nombre"
        End If

        If txtDescripcion.Text.Trim = String.Empty Then
            msg &= vbCrLf & "- Ingrese una descripción"
        End If

        If dgvProgramacion.Rows.Count = 0 Then
            msg &= vbCrLf & "- Ingrese un detalle en la programación"
        End If

        msg &= ValidarProgramacion()

        msg &= ValidarRestricciones()

        Return msg
    End Function

    Private Function ValidarProgramacion() As String
        Dim msg As String = String.Empty
        Dim count As Integer = 0
        Dim tempDate As Date = Nothing

        For Each row As DataGridViewRow In dgvProgramacion.Rows
            Dim value As Date = CType(dgvProgramacion.Item(colFecInicio.Index, row.Index).EditedFormattedValue, Date)
            If tempDate = Nothing Then
                tempDate = value
            Else
                If value <> tempDate Then
                    count += 1
                    Exit For
                End If
            End If
        Next

        If count > 0 Then
            msg &= vbCrLf & "- Sólo se permite ingresar horas de una sola fecha"
        End If

        Return msg
    End Function

    Private Function ValidarRestricciones() As String
        Dim msg As String = String.Empty

        For Each row As DataGridViewRow In dgvRestricciones.Rows
            Dim value As Boolean = CType(dgvRestricciones.Item(colSeleccionar.Index, row.Index).EditedFormattedValue, Boolean)

            If value Then
                If row.Cells(colCondicionRestriccion.Index).Value = Nothing Then
                    msg &= vbCrLf & "- Seleccione condición en todas las restricciones"
                End If

                If row.Cells(colCantidadRestriccion.Index).Value = Nothing Then
                    msg &= vbCrLf & "- Ingrese cantidad en todas las restricciones"
                    'Else
                    '    If row.Cells(colCantidadRestriccion.Index).Value = 0 Then
                    '        msg &= vbCrLf & "- La cantidad debe ser mayor a 0 en todos los detalles"
                    '    End If
                End If
            End If
        Next

        Return msg
    End Function

    Private Function GuardarActividad() As Boolean
        Dim flag As Boolean = True

        If ValidarCamposRequeridos() <> String.Empty Then
            MessageBox.Show(ValidarCamposRequeridos, "Información")
            flag = False
            Return flag
            Exit Function
        End If

        Dim affectedRows As Integer = 0
        Dim oActividad As New ActividadBE
        'oActividad.fec_ini = Today
        'oActividad.fec_fin = Today
        'oActividad.hora_ini = Now.TimeOfDay
        'oActividad.hora_fin = Now.TimeOfDay
        oActividad.monto_pago = nudPago.Value
        oActividad.id_cattipo_act = cboCategoria.SelectedValue
        oActividad.id_comite = cboComite.SelectedValue
        oActividad.id_tipo_act = cboTipo.SelectedValue
        oActividad.descripcion = txtDescripcion.Text.Trim
        oActividad.nombre = txtNombre.Text.Trim
        oActividad.flg_plan_anual = False
        oActividad.flg_web = True
        oActividad.tipo_inscripcion = "A"
        oActividad.vacantes = nudVacantes.Value
        oActividad.ListaActividadDetalle = dgvProgramacion.DataSource
        oActividad.ListaTipoPersonal = dgvTipoPersonal.DataSource
        oActividad.ListaRecursos = dgvRecursos.DataSource

        Dim startDateTime As DateTime = Nothing
        Dim endDateTime As DateTime = Nothing

        For Each oActividadDetalle As ActividadDetalleBE In oActividad.ListaActividadDetalle
            startDateTime = Convert.ToDateTime(oActividadDetalle.fecha).Add(oActividadDetalle.hora_ini)
            endDateTime = Convert.ToDateTime(oActividadDetalle.fecha).Add(oActividadDetalle.hora_fin)

            If Convert.ToDateTime(oActividadDetalle.fecha).Add(oActividadDetalle.hora_ini) < startDateTime Then
                startDateTime = Convert.ToDateTime(oActividadDetalle.fecha).Add(oActividadDetalle.hora_ini)
            End If

            If Convert.ToDateTime(oActividadDetalle.fecha).Add(oActividadDetalle.hora_fin) > endDateTime Then
                endDateTime = Convert.ToDateTime(oActividadDetalle.fecha).Add(oActividadDetalle.hora_fin)
            End If
        Next

        oActividad.fecha = startDateTime.Date
        oActividad.hora_ini = startDateTime.TimeOfDay
        'oActividad.fec_fin = endDateTime.Date
        oActividad.hora_fin = endDateTime.TimeOfDay

        For Each row As DataGridViewRow In dgvRestricciones.Rows
            Dim value As Boolean = CType(dgvRestricciones.Item(colSeleccionar.Index, row.Index).EditedFormattedValue, Boolean)
            Dim oRestriccion As RestriccionesBE = row.DataBoundItem

            If value Then

                If oActividad.ListaRestricciones Is Nothing Then
                    oActividad.ListaRestricciones = New List(Of RestriccionesBE)
                End If

                oRestriccion.id_signo = row.Cells(colCondicionRestriccion.Index).Value
                oRestriccion.valor = row.Cells(colCantidadRestriccion.Index).Value
                oActividad.ListaRestricciones.Add(oRestriccion)
            End If
        Next

        If txtCodigo.Text = String.Empty Then
            oActividad.id_estado = "EST001" 'Registrada
            affectedRows = bc.InsertarActividad(oActividad)
        Else
            oActividad.id_actividad = txtCodigo.Text
            affectedRows = bc.ActualizarActividad(oActividad)
        End If

        If affectedRows = 0 Then
            MessageBox.Show("Error al grabar", "Información")
            flag = False
        Else
            If txtCodigo.Text = String.Empty Then
                txtCodigo.Text = affectedRows
                _id_actividad = affectedRows
                MessageBox.Show("La actividad se registró satisfactoriamente", "Información")
            Else
                _id_actividad = oActividad.id_actividad
                MessageBox.Show("La actividad se actualizó satisfactoriamente", "Información")
            End If
        End If

        Return flag

    End Function

    Private Sub AgregarProgramacion(ByRef oListadoEspacioRes As List(Of EspacioResBE))
        Dim oActividadDetalle As ActividadDetalleBE

        If ListadoActividadDetalles Is Nothing Then
            ListadoActividadDetalles = New List(Of ActividadDetalleBE)
        End If

        For Each oEspacioRes As EspacioResBE In oListadoEspacioRes
            oActividadDetalle = New ActividadDetalleBE
            oActividadDetalle.fecha = oEspacioRes.fec_ini
            'oActividadDetalle.fecha_fin = oEspacioRes.fec_fin
            oActividadDetalle.hora_ini = Convert.ToDateTime(oEspacioRes.hora_inicio).TimeOfDay
            oActividadDetalle.hora_fin = Convert.ToDateTime(oEspacioRes.hora_fin).TimeOfDay
            oActividadDetalle.id_sede = oEspacioRes.id_sede
            oActividadDetalle.des_sede = oEspacioRes.des_sede
            oActividadDetalle.id_espacio = oEspacioRes.id_espacio
            oActividadDetalle.nombre_espacio = oEspacioRes.nombre_espacio
            ListadoActividadDetalles.Add(oActividadDetalle)
        Next

        dgvProgramacion.DataSource = Nothing
        dgvProgramacion.DataSource = ListadoActividadDetalles
    End Sub

    Private Sub LimpiarProgramacion()
        If ListadoActividadDetalles IsNot Nothing Then
            ListadoActividadDetalles = Nothing
        End If

        dgvProgramacion.DataSource = Nothing
        dgvProgramacion.DataSource = ListadoActividadDetalles
    End Sub

    Private Function EnviarEmail(ByRef oPersona As PersonaBE, ByVal asunto As String, ByVal descripcion As String) As Boolean
        Dim flag As Boolean = False
        Dim remitente = New MailAddress("accelbosque@gmail.com", "Asociación Country Club El Bosque")
        Dim destinatario = New MailAddress(oPersona.email, oPersona.nombre_completo)
        Const fromPassword As String = "elbosque"

        Dim smtp As New SmtpClient

        With smtp
            .Host = "smtp.gmail.com"
            .Port = 587
            .EnableSsl = True
            .DeliveryMethod = SmtpDeliveryMethod.Network
            .UseDefaultCredentials = False
            .Credentials = New NetworkCredential(remitente.Address, fromPassword)
        End With

        Using mensaje As New MailMessage(remitente, destinatario)
            With mensaje
                .Subject = asunto
                .Body = descripcion
                .IsBodyHtml = True
            End With

            Try
                smtp.Send(mensaje)
                Return True
            Catch ex As Exception
                Return False
            End Try

        End Using

    End Function

    Private Sub ComunicarUsuariosCancelacion(ByRef oActividad As ActividadBE)
        Dim ListadoPersona As List(Of PersonaBE) = bc.ListarPersonaXActividad(CInt(txtCodigo.Text.Trim))

        If ListadoPersona IsNot Nothing AndAlso ListadoPersona.Count > 0 Then
            For Each oPersona As PersonaBE In ListadoPersona
                EnviarEmail(oPersona, "Cancelación de Actividad", "Estimado(a) socio(a)<br/><br/>La presente es para informarle la cancelación de la actividad <b>" & _
            oActividad.nombre & "</b> a la cual se encontraba inscrito(a).<br/>Asimismo lamentamos las molestias que ésta cancelación pudiera ocasionarle.<br/><br/>" & _
            "Para cualquier consulta adicional, comunicarse a los siguientes teléfonos: 2070670 anexo 123, directo 2070695, o enviando un correo a <a href='mailto:admision@elbosque.org.pe'>admision@elbosque.org.pe</a>.<br/><br/>Atentamente,<br/><b>ACC El Bosque</b>")
            Next
        End If
    End Sub

    Private Sub ComunicarUsuariosReprogramacion(ByRef oActividad As ActividadBE)
        Dim ListadoPersona As List(Of PersonaBE) = bc.ListarPersonaXActividad(CInt(txtCodigo.Text.Trim))

        If ListadoPersona IsNot Nothing AndAlso ListadoPersona.Count > 0 Then
            For Each oPersona As PersonaBE In ListadoPersona
                EnviarEmail(oPersona, "Reprogramación de Actividad", "Estimado(a) socio(a)<br/><br/>La presente es para informarle la reprogramación de la actividad <b>" & _
            oActividad.nombre & "</b> a la cual se encuentra inscrito(a).<br/>Asimismo lamentamos las molestias que ésta reprogramación pudiera ocasionarle.<br/><br/>" & _
            "Para cualquier consulta adicional, comunicarse a los siguientes teléfonos: 2070670 anexo 123, directo 2070695, o enviando un correo a <a href='mailto:admision@elbosque.org.pe'>admision@elbosque.org.pe</a>.<br/><br/>Atentamente,<br/><b>ACC El Bosque</b>")
            Next
        End If
    End Sub

    Sub SugerenciaTipoActividad()

        Dim oParam As ParametrosBE = bc.ObtenerParametro(1)
        Dim fecIni As Date = DateAdd(DateInterval.Month, CInt(oParam.val_param) * -1, Now)

        Dim oListado As List(Of FactActividadSumBE) = bc.ListarTotalesFactActividadSum(fecIni, Now, cboComite.SelectedValue, Nothing)
        Dim maxPart As Decimal = 0.0
        Dim resultado As String = ""
        msjTipo = ""

        If oListado IsNot Nothing AndAlso oListado.Count > 0 Then
            msjTipo = "DEMANDA DE TIPO DE ACTIVIDAD (Cantidad de Participaciones promedio):" & vbCrLf & vbCrLf
            msjTipo &= "Comite: " & cboComite.GetItemText(cboComite.SelectedItem) & vbCrLf
            msjTipo &= "Fechas: " & fecIni.Date & " - " & Now.Date & vbCrLf
            msjTipo &= "Fórmula Participantes: Cantidad de participantes / Cantidad de actividades" & vbCrLf
            msjTipo &= "Fórmula Satisfacción: (Cantidad de Satisfacción / Cantidad Total) * 100.00 %" & vbCrLf

            For Each oFact As FactActividadSumBE In oListado
                oFact.part_x_actividad = Math.Round(oFact.total_participantes * 1.0 / oFact.total_actividades * 1.0)
                msjTipo &= "- " & oFact.tipo_actividad & " : " & oFact.total_participantes & " / " & oFact.total_actividades & " = " & oFact.part_x_actividad & " pers." & vbCrLf
                If oFact.cant_satisfaccion + oFact.cant_nsno + oFact.cant_nosatisfaccion <> 0 Then
                    oFact.satisfaccion = oFact.cant_satisfaccion * 100.0 / (oFact.cant_satisfaccion + oFact.cant_nsno + oFact.cant_nosatisfaccion) * 1.0
                    msjTipo &= "  Satisfacción: (" & oFact.cant_satisfaccion & " / " & oFact.cant_satisfaccion + oFact.cant_nsno + oFact.cant_nosatisfaccion & ") * 100.00 = " & oFact.satisfaccion & " % " & vbCrLf
                End If
                If oFact.part_x_actividad > maxPart Then
                    maxPart = oFact.part_x_actividad
                    resultado = oFact.tipo_actividad & " - " & oFact.part_x_actividad & " personas en cada actividad"
                ElseIf oFact.part_x_actividad = maxPart Then
                    resultado &= vbCrLf & oFact.tipo_actividad & " - " & oFact.part_x_actividad & " personas en cada actividad"
                End If
            Next

            msjTipo &= vbCrLf & "Sugerencia del Tipo de Actividad con mayor demanda en el promedio de participantes de cada actividad:" & vbCrLf & vbCrLf & resultado & vbCrLf & vbCrLf


            msjTipo &= vbCrLf & "SUGERENCIA POR MES" & vbCrLf & vbCrLf

            ''opcion por fechas
            'Dim oListadoMes As List(Of FactActividadSumBE) = bc.ListarMesesParticipacion(fecIni, Now, cboComite.SelectedValue, Nothing)

            '' opcion por meses
            Dim oListadoMes As List(Of FactActividadSumBE) = bc.ListarMesesParticipacion2(cboComite.SelectedValue, Now.Year)

            For Each oFact As FactActividadSumBE In oListadoMes
                ''opcion por fechas
                'msjTipo &= "- " & MonthName(oFact.mes.Substring(4, 2)).ToUpper & " " & oFact.mes.Substring(0, 4) & vbCrLf

                '' opcion por meses
                msjTipo &= "- " & oFact.mes.ToUpper & vbCrLf

                msjTipo &= "  " & oFact.obs_max_part & " pers.  "
                If oFact.obs_min_part <> "" Then
                    msjTipo &= "  " & oFact.obs_min_part & " pers."

                    If oFact.coeficiente >= 0.5 And oFact.coeficiente <= 1 Then
                        msjTipo &= vbCrLf & "  Sugerencia: " & oFact.max_part & " y " & oFact.min_part & " son complementarios en el mes."
                    ElseIf oFact.coeficiente >= -0.5 And oFact.coeficiente <= 0.5 Then
                        msjTipo &= vbCrLf & "  Sugerencia: " & oFact.max_part & " tiene mayor participación en el mes."
                    ElseIf oFact.coeficiente >= -1 And oFact.coeficiente <= -0.5 Then
                        msjTipo &= vbCrLf & "  Sugerencia: " & oFact.max_part & " y " & oFact.min_part & " son incompatibles en el mes."
                    End If

                End If
                msjTipo &= vbCrLf
            Next


        Else
            msjTipo = "No hay sugerencias"
        End If


        Dim msj As String = ""

        If resultado <> String.Empty Then
            msj = "Sugerencia de Tipo de actividad con mayor demanda en el promedio de participantes de cada actividad: " & vbCrLf
            msj &= resultado & vbCrLf

        Else
            msj = "No hay sugerencias"
        End If


        SugerenciasToolTip.SetToolTip(btntipo, msj)

    End Sub

    Sub SugerenciaVacantes()

        ''''Participantes

        Dim oParam As ParametrosBE = bc.ObtenerParametro(1)
        Dim fecIni As Date = DateAdd(DateInterval.Month, CInt(oParam.val_param) * -1, Now)
        Dim fecFin As Date = Now

        Dim oListado As List(Of FactActividadSumBE) = bc.ListarTotalesFactActividadSum(fecIni, Now, cboComite.SelectedValue, cboTipo.SelectedValue)
        Dim maxPart As Decimal = 0.0
        Dim resultado As String = ""
        msjVacantes = ""

        If oListado IsNot Nothing AndAlso oListado.Count > 0 Then
            msjVacantes = "Comite: " & cboComite.GetItemText(cboComite.SelectedItem) & vbCrLf
            msjVacantes &= "Tipo Actividad: " & cboTipo.GetItemText(cboTipo.SelectedItem) & vbCrLf
            msjVacantes &= "Fechas: " & fecIni.Date & " - " & Now.Date & vbCrLf & vbCrLf
            msjVacantes &= "Promedio de participantes de Actividad de un tipo (Cantidad de Participaciones):" & vbCrLf
            msjVacantes &= "Fórmula: Cantidad de participantes / Cantidad de actividades" & vbCrLf

            oListado.Item(0).part_x_actividad = Math.Round(oListado.Item(0).total_participantes * 1.0 / oListado.Item(0).total_actividades * 1.0)
            msjVacantes &= "- " & oListado.Item(0).tipo_actividad & " : " & oListado.Item(0).total_participantes & " / " & oListado.Item(0).total_actividades & " = " & oListado.Item(0).part_x_actividad & " pers." & vbCrLf & vbCrLf

            If oListado.Item(0).cant_satisfaccion + oListado.Item(0).cant_nsno + oListado.Item(0).cant_nosatisfaccion <> 0 Then
                oListado.Item(0).satisfaccion = oListado.Item(0).cant_satisfaccion * 100.0 / (oListado.Item(0).cant_satisfaccion + oListado.Item(0).cant_nsno + oListado.Item(0).cant_nosatisfaccion) * 1.0
                msjVacantes &= "Fórmula Satisfacción: (Cantidad de Satisfacción / Cantidad Total) * 100.00" & vbCrLf
                msjVacantes &= " - (" & oListado.Item(0).cant_satisfaccion & " / " & oListado.Item(0).cant_satisfaccion + oListado.Item(0).cant_nsno + oListado.Item(0).cant_nosatisfaccion & ") * 100.00 = " & oListado.Item(0).satisfaccion & " % " & vbCrLf
            End If

            If oListado.Item(0).part_x_actividad > maxPart Then
                maxPart = oListado.Item(0).part_x_actividad
                resultado = oListado.Item(0).tipo_actividad & " - " & oListado.Item(0).part_x_actividad
            ElseIf oListado.Item(0).part_x_actividad = maxPart Then
                resultado &= vbCrLf & oListado.Item(0).tipo_actividad & " - " & oListado.Item(0).part_x_actividad
            End If

        Else
            msjVacantes = "No hay sugerencias"
        End If


        If resultado = "" Then
            btnVacantes.Visible = False
        Else
            btnVacantes.Visible = True
            SugerenciasToolTip.SetToolTip(btnVacantes, resultado)
        End If

    End Sub

    Sub SugerenciaFechas()

        Dim oParam As ParametrosBE = bc.ObtenerParametro(1)
        Dim fecIni As Date = DateAdd(DateInterval.Month, CInt(oParam.val_param) * -1, Now)
        Dim fecFin As Date = Now

        ''''Fechas

        Dim oListadoFec As List(Of FactActividadSumBE) = bc.ObtenerMesesParticipacion(fecIni, fecFin, cboComite.SelectedValue, cboTipo.SelectedValue)
        Dim maxPartFec As Decimal = 0.0
        Dim resultadoFec As String = ""
        msjFecha = ""
        Dim enero As Integer = 0
        Dim febrero As Integer = 0
        Dim marzo As Integer = 0
        Dim abril As Integer = 0
        Dim mayo As Integer = 0
        Dim junio As Integer = 0
        Dim julio As Integer = 0
        Dim agosto As Integer = 0
        Dim setiembre As Integer = 0
        Dim octubre As Integer = 0
        Dim noviembre As Integer = 0
        Dim diciembre As Integer = 0

        If oListadoFec IsNot Nothing AndAlso oListadoFec.Count > 0 Then
            msjFecha = "Meses con mayor demanda (Cantidad de Participaciones):" & vbCrLf & vbCrLf
            msjFecha &= "Comite: " & cboComite.GetItemText(cboComite.SelectedItem) & vbCrLf
            msjFecha &= "Fechas: " & fecIni.Date & " - " & Now.Date & vbCrLf
            msjFecha &= "Fórmula por mes: Cantidad de participantes / Cantidad de actividades" & vbCrLf

            For Each oFact As FactActividadSumBE In oListadoFec
                oFact.part_x_actividad = Math.Round(oFact.total_participantes * 1.0 / oFact.total_actividades * 1.0)
                msjFecha &= "- " & oFact.mes.Substring(0, 4) & " " & MonthName(oFact.mes.Substring(4, 2)) & " : " & oFact.total_participantes & " / " & oFact.total_actividades & " = " & oFact.part_x_actividad & " pers." & vbCrLf

                If CInt(oFact.mes.Substring(4, 2)) = 1 Then
                    enero += oFact.total_participantes
                ElseIf CInt(oFact.mes.Substring(4, 2)) = 2 Then
                    febrero += oFact.total_participantes
                ElseIf CInt(oFact.mes.Substring(4, 2)) = 3 Then
                    marzo += oFact.total_participantes
                ElseIf CInt(oFact.mes.Substring(4, 2)) = 4 Then
                    abril += oFact.total_participantes
                ElseIf CInt(oFact.mes.Substring(4, 2)) = 5 Then
                    mayo += oFact.total_participantes
                ElseIf CInt(oFact.mes.Substring(4, 2)) = 6 Then
                    junio += oFact.total_participantes
                ElseIf CInt(oFact.mes.Substring(4, 2)) = 7 Then
                    julio += oFact.total_participantes
                ElseIf CInt(oFact.mes.Substring(4, 2)) = 8 Then
                    agosto += oFact.total_participantes
                ElseIf CInt(oFact.mes.Substring(4, 2)) = 9 Then
                    setiembre += oFact.total_participantes
                ElseIf CInt(oFact.mes.Substring(4, 2)) = 10 Then
                    octubre += oFact.total_participantes
                ElseIf CInt(oFact.mes.Substring(4, 2)) = 11 Then
                    noviembre += oFact.total_participantes
                ElseIf CInt(oFact.mes.Substring(4, 2)) = 12 Then
                    diciembre += oFact.total_participantes
                End If
            Next


            If enero = maxPartFec Then
                resultadoFec &= "Enero" & vbCrLf
            ElseIf enero > maxPartFec Then
                maxPartFec = enero
                resultadoFec = "Enero" & vbCrLf
            End If

            If febrero = maxPartFec Then
                resultadoFec &= "Febrero" & vbCrLf
            ElseIf febrero > maxPartFec Then
                maxPartFec = febrero
                resultadoFec = "Febrero" & vbCrLf
            End If

            If marzo = maxPartFec Then
                resultadoFec &= "Marzo" & vbCrLf
            ElseIf marzo > maxPartFec Then
                maxPartFec = marzo
                resultadoFec = "Marzo" & vbCrLf
            End If

            If abril = maxPartFec Then
                resultadoFec &= "Abril" & vbCrLf
            ElseIf abril > maxPartFec Then
                maxPartFec = abril
                resultadoFec = "Abril" & vbCrLf
            End If

            If mayo = maxPartFec Then
                resultadoFec &= "Mayo" & vbCrLf
            ElseIf mayo > maxPartFec Then
                maxPartFec = mayo
                resultadoFec = "Mayo" & vbCrLf
            End If

            If junio = maxPartFec Then
                resultadoFec &= "Junio" & vbCrLf
            ElseIf junio > maxPartFec Then
                maxPartFec = junio
                resultadoFec = "Junio" & vbCrLf
            End If

            If julio = maxPartFec Then
                resultadoFec &= "Julio" & vbCrLf
            ElseIf julio > maxPartFec Then
                maxPartFec = julio
                resultadoFec = "Julio" & vbCrLf
            End If

            If agosto = maxPartFec Then
                resultadoFec &= "Agosto" & vbCrLf
            ElseIf agosto > maxPartFec Then
                maxPartFec = agosto
                resultadoFec = "Agosto" & vbCrLf
            End If

            If setiembre = maxPartFec Then
                resultadoFec &= "Setiembre" & vbCrLf
            ElseIf setiembre > maxPartFec Then
                maxPartFec = setiembre
                resultadoFec = "Setiembre" & vbCrLf
            End If

            If octubre = maxPartFec Then
                resultadoFec &= "Octubre" & vbCrLf
            ElseIf octubre > maxPartFec Then
                maxPartFec = octubre
                resultadoFec = "Octubre" & vbCrLf
            End If

            If noviembre = maxPartFec Then
                resultadoFec &= "Noviembre" & vbCrLf
            ElseIf noviembre > maxPartFec Then
                maxPartFec = noviembre
                resultadoFec = "Noviembre" & vbCrLf
            End If

            If diciembre = maxPartFec Then
                resultadoFec &= "Diciembre" & vbCrLf
            ElseIf diciembre > maxPartFec Then
                maxPartFec = diciembre
                resultadoFec = "Diciembre" & vbCrLf
            End If

            msjFecha &= vbCrLf & "Resultados:" & vbCrLf & resultadoFec

        Else
            msjFecha = "No hay sugerencias"
        End If


        If resultadoFec = "" Then
            btnFechas.Visible = False
        Else
            btnFechas.Visible = True
            SugerenciasToolTip.SetToolTip(btnFechas, resultadoFec)
        End If


    End Sub

    Sub SugerenciaRecursos()

        Dim oParam As ParametrosBE = bc.ObtenerParametro(1)
        Dim fecIni As Date = DateAdd(DateInterval.Month, CInt(oParam.val_param) * -1, Now)

        Dim oListado As List(Of RecursoBE) = bc.ListarDemandaRecursos(fecIni, Now, cboComite.SelectedValue, cboTipo.SelectedValue)
        Dim maxCant As Integer = 0
        Dim resultado As String = ""
        msjRecursos = ""

        If oListado IsNot Nothing AndAlso oListado.Count > 0 Then
            msjRecursos = "Demanda de Recursos" & vbCrLf & "(Cantidad de Recursos):" & vbCrLf & vbCrLf
            msjRecursos &= "Comite: " & cboComite.GetItemText(cboComite.SelectedItem) & vbCrLf
            msjRecursos &= "Fechas: " & fecIni.Date & " - " & Now.Date & vbCrLf & vbCrLf
            
            For Each oFact As RecursoBE In oListado

                msjRecursos &= "- " & oFact.descripcion & " : " & oFact.cantidad & vbCrLf
                
                If oFact.cantidad > maxCant Then
                    maxCant = oFact.cantidad
                    resultado = oFact.descripcion & " - " & oFact.cantidad
                ElseIf oFact.cantidad = maxCant Then
                    resultado &= vbCrLf & oFact.descripcion & " - " & oFact.cantidad
                End If
            Next

            msjRecursos &= vbCrLf & "Resultados:" & vbCrLf & resultado

        Else
            msjRecursos = "No hay sugerencias"
        End If


        If resultado = "" Then
            btnRecursos.Visible = False
        Else
            btnRecursos.Visible = True
            SugerenciasToolTip.SetToolTip(btnRecursos, resultado)
        End If

    End Sub

    Sub SugerenciaTipoPersonal()

        Dim oParam As ParametrosBE = bc.ObtenerParametro(1)
        Dim fecIni As Date = DateAdd(DateInterval.Month, CInt(oParam.val_param) * -1, Now)

        Dim oListado As List(Of TipoPersonalBE) = bc.ListarDemandaTipoPersonal(fecIni, Now, cboComite.SelectedValue, cboTipo.SelectedValue)
        Dim maxCant As Integer = 0
        Dim resultado As String = ""
        msjTipoPersonal = ""

        If oListado IsNot Nothing AndAlso oListado.Count > 0 Then
            msjTipoPersonal = "Demanda de Tipo de Personal" & vbCrLf & "(Cantidad de Tipo de Personal):" & vbCrLf & vbCrLf
            msjTipoPersonal &= "Comite: " & cboComite.GetItemText(cboComite.SelectedItem) & vbCrLf
            msjTipoPersonal &= "Fechas: " & fecIni.Date & " - " & Now.Date & vbCrLf & vbCrLf

            For Each oFact As TipoPersonalBE In oListado

                msjTipoPersonal &= "- " & oFact.descripcion & " : " & oFact.cantidad & vbCrLf

                If oFact.cantidad > maxCant Then
                    maxCant = oFact.cantidad
                    resultado = oFact.descripcion & " - " & oFact.cantidad
                ElseIf oFact.cantidad = maxCant Then
                    resultado &= vbCrLf & oFact.descripcion & " - " & oFact.cantidad
                End If
            Next

            msjTipoPersonal &= vbCrLf & "Resultados:" & vbCrLf & resultado

        Else
            msjTipoPersonal = "No hay sugerencias"
        End If


        If resultado = "" Then
            btnTipoPersonal.Visible = False
        Else
            btnTipoPersonal.Visible = True
            SugerenciasToolTip.SetToolTip(btnTipoPersonal, resultado)
        End If

    End Sub

#End Region

#Region "Cargar"

    Private Sub frmRegistroActividad_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        ListarComites()
        ListarTipoActividad()
        ListarRestricciones()
        ListarSignos()

        If id_act IsNot Nothing Then
            _id_actividad = id_act
            CargarActividad(id_act)
            FormularioEnModoVista()
        End If

        btnFechas.Visible = False
        btntipo.Visible = False
        btnVacantes.Visible = False
        btnRecursos.Visible = False
    End Sub

#End Region

#Region "Metodos Controles"

    Private Sub tsbLimpiar_Click(sender As System.Object, e As System.EventArgs) Handles tsbLimpiar.Click
        LimpiarFormulario()
    End Sub

    Private Sub tsbGuardar_Click(sender As System.Object, e As System.EventArgs) Handles tsbGuardar.Click
        If GuardarActividad() Then
            LimpiarFormulario()
            CargarActividad(_id_actividad)
            FormularioEnModoVista()

            If Actividad.id_estado = "EST005" Then
                If ListadoProgramacion IsNot Nothing AndAlso ListadoProgramacion.Count > 0 Then
                    If Not dgvProgramacion.DataSource.Equals(ListadoProgramacion) Then
                        ComunicarUsuariosReprogramacion(Actividad)
                        ListadoProgramacion = Nothing
                    End If
                End If
            End If
        End If
    End Sub

    Private Sub tsbEditar_Click(sender As System.Object, e As System.EventArgs) Handles tsbEditar.Click
        FormularioEnModoEdicion()
    End Sub

    Private Sub tsbEliminar_Click(sender As System.Object, e As System.EventArgs) Handles tsbEliminar.Click
        If txtCodigo.Text.Trim <> String.Empty Then
            If MsgBox("Seguro que desea anular la actividad?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                Dim affectedRows As Integer = 0
                affectedRows = bc.BorrarActividad(CInt(txtCodigo.Text.Trim))

                If affectedRows = 0 Then
                    MessageBox.Show("Error al borrar", "Información")
                Else
                    MessageBox.Show("La actividad se anuló satisfactoriamente", "Información")
                    If Actividad.id_estado = "EST005" Then
                        ComunicarUsuariosCancelacion(Actividad)
                    End If
                End If

                LimpiarFormulario()
            End If
        End If
    End Sub

    Private Sub tsbCancelar_Click(sender As System.Object, e As System.EventArgs) Handles tsbCancelar.Click
        If MsgBox("Seguro que desea cancelar la operación?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            CargarActividad(_id_actividad)
            FormularioEnModoVista()
        End If
    End Sub

    Private Sub tsbReprogramacion_Click(sender As System.Object, e As System.EventArgs) Handles tsbReprogramacion.Click
        FormularioEnModoReprogramacion()
    End Sub

    Private Sub btnBuscarActividad_Click(sender As System.Object, e As System.EventArgs) Handles btnBuscarActividad.Click
        Dim frmBuscarActividad As New frmBuscarActividad
        'frmBuscarActividad.id_estado = "EST001"
        frmBuscarActividad.ShowDialog()

        If frmBuscarActividad.ActividadSeleccionada IsNot Nothing Then
            tsbEditar.Visible = True
            tsbEliminar.Visible = True
            _id_actividad = frmBuscarActividad.ActividadSeleccionada.id_actividad
            CargarActividad(frmBuscarActividad.ActividadSeleccionada.id_actividad)
            FormularioEnModoVista()
        End If
    End Sub

    Private Sub btnBuscarPersonal_Click(sender As System.Object, e As System.EventArgs) Handles btnBuscarPersonal.Click
        Dim frmBuscarTipoPersonal As New frmBuscarTipoPersonal
        frmBuscarTipoPersonal.ShowDialog()

        Dim result As Boolean = False

            If frmBuscarTipoPersonal.TipoPersonalSeleccionado IsNot Nothing Then

            If ListadoTipoPersonal IsNot Nothing Then

                For Each oTipoPersonal As TipoPersonalBE In ListadoTipoPersonal
                    If oTipoPersonal.id_tipo_personal = frmBuscarTipoPersonal.TipoPersonalSeleccionado.id_tipo_personal Then
                        result = True
                    End If
                Next

            End If

            If result = False Then

                CargarTipoPersonal(frmBuscarTipoPersonal.TipoPersonalSeleccionado)
                oPersonalPendiente = frmBuscarTipoPersonal.TipoPersonalSeleccionado
            Else
                MsgBox("El Tipo de personal existe en la lista")
            End If

        End If

    End Sub

    Private Sub btnAgregarTipoPersonal_Click(sender As System.Object, e As System.EventArgs) Handles btnAgregarTipoPersonal.Click

        AgregarTipoPersonal(oPersonalPendiente)
        oPersonalPendiente = Nothing
    End Sub

    Private Sub btnQuitarTipoPersonal_Click(sender As System.Object, e As System.EventArgs) Handles btnQuitarTipoPersonal.Click
        If dgvTipoPersonal.CurrentRow IsNot Nothing Then
            QuitarTipoPersonal(DirectCast(dgvTipoPersonal.CurrentRow.DataBoundItem, TipoPersonalBE))
        End If
    End Sub

    Private Sub txtCantidadPersonal_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCantidadPersonal.KeyPress
        e.Handled = Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar)
    End Sub

    Private Sub btnBuscarRecurso_Click(sender As System.Object, e As System.EventArgs) Handles btnBuscarRecurso.Click
        Dim frmBuscarRecurso As New frmBuscarRecurso
        frmBuscarRecurso.ShowDialog()

        Dim result As Boolean = False

        If frmBuscarRecurso.RecursoSeleccionado IsNot Nothing Then

            If ListadoRecursos IsNot Nothing Then

                For Each oRecurso As RecursoBE In ListadoRecursos
                    If oRecurso.id_recurso = frmBuscarRecurso.RecursoSeleccionado.id_recurso Then
                        result = True
                    End If
                Next

            End If

            If result = False Then

                CargarRecurso(frmBuscarRecurso.RecursoSeleccionado)
                oRecursoPendiente = frmBuscarRecurso.RecursoSeleccionado

            Else
                MsgBox("El recurso existe en la lista")
            End If
        End If
    End Sub

    Private Sub btnAgregarRecurso_Click(sender As System.Object, e As System.EventArgs) Handles btnAgregarRecurso.Click
        AgregarRecurso(oRecursoPendiente)
        oRecursoPendiente = Nothing
    End Sub

    Private Sub btnQuitarRecurso_Click(sender As System.Object, e As System.EventArgs) Handles btnQuitarRecurso.Click
        If dgvRecursos.CurrentRow IsNot Nothing Then
            QuitarRecurso(DirectCast(dgvRecursos.CurrentRow.DataBoundItem, RecursoBE))
        End If
    End Sub

    Private Sub txtCantidadRecurso_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCantidadRecurso.KeyPress
        e.Handled = Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar)
    End Sub

    Private Sub cboTipo_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboTipo.SelectedValueChanged
        If cboTipo.SelectedValue IsNot Nothing Then
            If cboTipo.SelectedValue = "00" Then
                cboCategoria.Enabled = False
                cboCategoria.DataSource = Nothing
            Else
                Dim ListadoCategorias As List(Of CatTipoActividadBE) = bc.ListarCatTipoActividad(cboTipo.SelectedValue)

                If ListadoCategorias.Count = 0 Then
                    cboCategoria.Enabled = False
                    cboCategoria.DataSource = Nothing
                Else
                    cboCategoria.Enabled = True
                    Dim oCategoriaActividad As New CatTipoActividadBE
                    oCategoriaActividad.id_cattipo_act = 0
                    oCategoriaActividad.descripcion = "- Seleccione -"

                    ListadoCategorias.Insert(0, oCategoriaActividad)
                    cboCategoria.DataSource = Nothing
                    cboCategoria.DataSource = ListadoCategorias
                    cboCategoria.ValueMember = "id_cattipo_act"
                    cboCategoria.DisplayMember = "descripcion"
                End If
            End If
        End If
    End Sub

    Private Sub btnEscoger_Click(sender As System.Object, e As System.EventArgs) Handles btnEscoger.Click
        Dim frmBuscarDisponibilidadEspacio As New frmBuscarDisponibilidadEspacio
        frmBuscarDisponibilidadEspacio.ShowDialog()

        If frmBuscarDisponibilidadEspacio.ListadoEspacioRes IsNot Nothing Then
            AgregarProgramacion(frmBuscarDisponibilidadEspacio.ListadoEspacioRes)
        End If
    End Sub

    Private Sub btnLimpiar_Click(sender As System.Object, e As System.EventArgs) Handles btnLimpiar.Click
        LimpiarProgramacion()
    End Sub

    Private Sub cboComite_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cboComite.SelectedIndexChanged

        If cboComite.SelectedIndex > 0 Then

            'Dim oListadoFact As List(Of FactActividadSumBE) = bc.ObtenerMaxInscritosXTipoActividad(cboComite.SelectedValue, Nothing)
            'Dim msj As String = ""

            'If oListadoFact IsNot Nothing AndAlso oListadoFact.Count > 0 Then
            '    msj = "Sugerencia de Tipo de actividad: " & vbCrLf
            '    For Each oFact As FactActividadSumBE In oListadoFact
            '        msj &= oFact.tipo_actividad & " - " & oFact.ins_x_actividad & " pers. por actividad." & vbCrLf
            '    Next
            'Else
            '    msj = "No hay sugerencias"
            'End If



            btntipo.Visible = True
            btnVacantes.Visible = False
            btnFechas.Visible = False
            btnRecursos.Visible = False

            SugerenciaTipoActividad()

        End If

    End Sub

    Private Sub cboTipo_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cboTipo.SelectedIndexChanged

        If cboTipo.SelectedIndex > 0 Then

            btntipo.Visible = False
            btnVacantes.Visible = False
            btnFechas.Visible = False
            btnRecursos.Visible = False
            btnTipoPersonal.Visible = False

            '    '''''INSCRITOS
            '    Dim oListadoFact As List(Of FactActividadSumBE) = bc.ObtenerMaxInscritosXTipoActividad(cboComite.SelectedValue, cboTipo.SelectedValue)

            '    Dim oSexo As FactActividadSumBE = bc.ObtenerSexoParticipantesXTipoActividad(cboComite.SelectedValue, cboTipo.SelectedValue)

            '    Dim oSatis As List(Of FactActividadSumBE) = bc.ObtenerMaxSatisfaccionXTipoActividad(cboComite.SelectedValue, cboTipo.SelectedValue)

            '    Dim msj As String = ""

            '    If oListadoFact IsNot Nothing AndAlso oListadoFact.Count > 0 Then
            '        msj &= "Promedio: " & oListadoFact.Item(0).ins_x_actividad & " pers." & vbCrLf
            '    End If

            '    If oSexo IsNot Nothing AndAlso oSexo.max_sexo <> "" Then
            '        msj &= "La mayor cantidad de inscritos son: " & oSexo.max_sexo & vbCrLf
            '    End If

            '    If oSatis IsNot Nothing AndAlso oSatis.Count > 0 Then
            '        msj &= "Aprobación: " & Math.Round(oSatis.Item(0).satisfaccion * 100.0, 2, MidpointRounding.ToEven) & " %" & vbCrLf
            '    End If

            '    If msj = "" Then
            '        btnVacantes.Visible = False
            '    Else
            '        btnVacantes.Visible = True
            '        SugerenciasToolTip.SetToolTip(btnVacantes, msj)
            '    End If


            '    ''''FECHAS

            '    Dim msj2 As String = ""

            '    Dim oListadoMes As List(Of FactActividadSumBE) = bc.ObtenerMesInscripcionXTipoActividad(cboComite.SelectedValue, cboTipo.SelectedValue)

            '    If oListadoMes IsNot Nothing AndAlso oListadoMes.Count > 0 Then
            '        msj2 = "Mes con mayor demanda: " & vbCrLf
            '        For Each oFact As FactActividadSumBE In oListadoMes
            '            msj2 &= "- " & MonthName(CInt(oFact.mes)) & vbCrLf
            '        Next
            '    End If

            '    If msj2 = "" Then
            '        btnFechas.Visible = False
            '    Else
            '        btnFechas.Visible = True
            '        SugerenciasToolTip.SetToolTip(btnFechas, msj2)
            '    End If

            '    ''''RECURSOS

            '    Dim msj3 As String = ""

            '    Dim oListadoRecursos As List(Of RecursoBE) = bc.ObtenerRecursosDemanda(cboComite.SelectedValue, cboTipo.SelectedValue)

            '    If oListadoRecursos IsNot Nothing AndAlso oListadoRecursos.Count > 0 Then
            '        msj3 = "Recursos con mayor demanda: " & vbCrLf
            '        For Each oRecurso As RecursoBE In oListadoRecursos
            '            msj3 &= "- " & oRecurso.descripcion & vbCrLf
            '        Next
            '    End If

            '    If msj3 = "" Then
            '        btnRecursos.Visible = False
            '    Else
            '        btnRecursos.Visible = True
            '        SugerenciasToolTip.SetToolTip(btnRecursos, msj3)
            '    End If


            '    ''''TIPO PERSONAL

            '    Dim msj4 As String = ""

            '    Dim oListadoTipo As List(Of TipoPersonalBE) = bc.ObtenerTipoPersonalDemanda(cboComite.SelectedValue, cboTipo.SelectedValue)

            '    If oListadoTipo IsNot Nothing AndAlso oListadoTipo.Count > 0 Then
            '        msj4 = "Tipo de Personal con mayor demanda: " & vbCrLf
            '        For Each oTipo As TipoPersonalBE In oListadoTipo
            '            msj4 &= "- " & oTipo.descripcion & vbCrLf
            '        Next
            '    End If

            '    If msj4 = "" Then
            '        btnTipoPersonal.Visible = False
            '    Else
            '        btnTipoPersonal.Visible = True
            '        SugerenciasToolTip.SetToolTip(btnTipoPersonal, msj4)
            '    End If

            SugerenciaVacantes()
            SugerenciaFechas()
            SugerenciaRecursos()
            SugerenciaTipoPersonal()

        End If

    End Sub

    Private Sub btntipo_Click(sender As System.Object, e As System.EventArgs) Handles btntipo.Click
        'MsgBox(msjTipo, MsgBoxStyle.Information)


        Dim frm As New frmInfo
        frm.info = msjTipo
        frm.ShowDialog()

    End Sub

    Private Sub btnVacantes_Click(sender As System.Object, e As System.EventArgs) Handles btnVacantes.Click
        MsgBox(msjVacantes, MsgBoxStyle.Information)
    End Sub

    Private Sub btnFechas_Click(sender As System.Object, e As System.EventArgs) Handles btnFechas.Click
        MsgBox(msjFecha, MsgBoxStyle.Information)
    End Sub

    Private Sub btnTipoPersonal_Click(sender As System.Object, e As System.EventArgs) Handles btnTipoPersonal.Click
        MsgBox(msjTipoPersonal, MsgBoxStyle.Information)
    End Sub

    Private Sub btnRecursos_Click(sender As System.Object, e As System.EventArgs) Handles btnRecursos.Click
        MsgBox(msjRecursos, MsgBoxStyle.Information)
    End Sub

#End Region

#Region "Metodos Grilla"

    Private Sub dgvRestricciones_EditingControlShowing(sender As Object, e As System.Windows.Forms.DataGridViewEditingControlShowingEventArgs) Handles dgvRestricciones.EditingControlShowing
        Dim columnIndex As Integer = dgvRestricciones.CurrentCell.ColumnIndex
        Dim rowIndex As Integer = dgvRestricciones.CurrentCell.RowIndex
        Dim flgCondicion As Boolean = dgvRestricciones.Item(colFlgCondicion.Index, rowIndex).Value

        If dgvRestricciones.Columns(columnIndex).Name = colCantidadRestriccion.Name Then
            Dim txtCantidad As DataGridViewTextBoxEditingControl = DirectCast(e.Control, DataGridViewTextBoxEditingControl)

            RemoveHandler txtCantidad.KeyPress, AddressOf txtNumeric_KeyPress
            AddHandler txtCantidad.KeyPress, AddressOf txtNumeric_KeyPress

            If flgCondicion = False Then
                txtCantidad.ReadOnly = True
            Else
                txtCantidad.ReadOnly = False
            End If

        ElseIf dgvRestricciones.Columns(columnIndex).Name = colCondicionRestriccion.Name Then
            Dim cboCondicion As ComboBox = DirectCast(e.Control, ComboBox)

            If flgCondicion = False Then
                cboCondicion.Enabled = False
            Else
                cboCondicion.Enabled = True
            End If
        End If

    End Sub

    Private Sub txtNumeric_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        e.Handled = Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar)
    End Sub

#End Region

End Class

