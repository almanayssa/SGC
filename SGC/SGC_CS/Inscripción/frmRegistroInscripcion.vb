Imports SGC.Model.Entidades
Imports SGC.Controller


Public Class frmRegistroInscripcion

    Dim bc As New BusinessController
    Private Actividad As ActividadBE
    Private _id_socio As String
    Private _id_inscripcion As Integer?
    Private ListadoInscritos As List(Of PersonaBE)
    Private ListadoPersona As List(Of PersonaBE)
    Private ListadoInvitado As List(Of InvitadoBE)

#Region "Inicializacion"

    Public Sub New()

        InitializeComponent()

        ListadoInscritos = New List(Of PersonaBE)


        dgvInscritos.AutoGenerateColumns = False
        colNombres.DataPropertyName = "nombre_completo"
        colNombre.DataPropertyName = "nom_per"
        colApePat.DataPropertyName = "ape_pat"
        colApeMat.DataPropertyName = "ape_mat"
        colDNI.DataPropertyName = "dni_per"
        'colInscripcion.DataPropertyName = "idinscripcion"
        colNacimiento.DataPropertyName = "fec_nac_per"
        colRelacion.DataPropertyName = "tipo_familiar"
        colPersona.DataPropertyName = "id_persona"


        dgvInvitados.AutoGenerateColumns = False
        colIdInv.DataPropertyName = "id_invitado"
        colINombres.DataPropertyName = "nombre_completo"
        colIDNI.DataPropertyName = "dni_inv"

    End Sub

#End Region

#Region "Métodos Controles"

    Private Sub btnBuscarActividad_Click(sender As System.Object, e As System.EventArgs) Handles btnBuscarActividad.Click
        Dim frmBuscarActividad As New frmBuscarActividad
        frmBuscarActividad.id_estado = "EST005"
        frmBuscarActividad.ShowDialog()

        If frmBuscarActividad.ActividadSeleccionada IsNot Nothing Then
            CargarActividad(frmBuscarActividad.ActividadSeleccionada.id_actividad)

        End If
    End Sub

    Private Sub btnBuscarSocio_Click(sender As System.Object, e As System.EventArgs) Handles btnBuscarSocio.Click
        Dim frmBuscarSocio As New frmBuscarSocio
        frmBuscarSocio.ShowDialog()

        If frmBuscarSocio.SocioSeleccionado IsNot Nothing Then

            CargarSocio(frmBuscarSocio.SocioSeleccionado)

        End If
    End Sub

    Private Sub btnAgregarPersona_Click(sender As System.Object, e As System.EventArgs) Handles btnAgregarPersona.Click
        If txtAccion.Text.Trim <> String.Empty Then

            Dim frm As New frmBuscarFamiliares
            frm.txtAccion.Text = txtAccion.Text
            frm.ShowDialog()

            If frm.PersonaSeleccionada IsNot Nothing Then
                AgregarInscrito(frm.PersonaSeleccionada)
            End If

            CalcularMonto()

        Else
            MsgBox("Ingresar codigo del asociado")
        End If
    End Sub

    Private Sub btnQuitarInscrito_Click(sender As System.Object, e As System.EventArgs) Handles btnQuitarInscrito.Click
        If Not dgvInscritos.CurrentRow Is Nothing Then
            Try
                Dim lista As List(Of PersonaBE)
                lista = dgvInscritos.DataSource

                lista.RemoveAt(dgvInscritos.CurrentRow.Index)

                dgvInscritos.DataSource = Nothing
                dgvInscritos.DataSource = lista

                CalcularMonto()

            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        Else
            MsgBox("Debe Seleccionar un Elemento para Quitarlo", MsgBoxStyle.Information)
        End If
    End Sub

    Private Sub tsbLimpiar_Click(sender As System.Object, e As System.EventArgs) Handles tsbLimpiar.Click
        Actividad = Nothing
        _id_socio = ""
        ListadoInscritos = New List(Of PersonaBE)
        ListadoPersona = New List(Of PersonaBE)
        ListadoInvitado = New List(Of InvitadoBE)

        limpiarFormulario()
    End Sub

    Private Sub tsbGuardar_Click(sender As System.Object, e As System.EventArgs) Handles tsbGuardar.Click
        GuardarInscripcion()
    End Sub

    Private Sub btnAgregarInvitado_Click(sender As System.Object, e As System.EventArgs) Handles btnAgregarInvitado.Click
        If txtAccion.Text.Trim <> String.Empty Then

            Dim frm As New frmBuscarInvitado
            frm.txtAccion.Text = txtAccion.Text
            frm.ShowDialog()

            If frm.InvitadoSeleccionado IsNot Nothing Then
                AgregarInvitado(frm.InvitadoSeleccionado)
            End If

            CalcularMonto()

        Else
            MsgBox("Ingresar codigo del asociado")
        End If
    End Sub

    Private Sub btnQuitarInvitado_Click(sender As System.Object, e As System.EventArgs) Handles btnQuitarInvitado.Click
        If Not dgvInvitados.CurrentRow Is Nothing Then
            Try
                Dim lista As List(Of InvitadoBE)
                lista = dgvInvitados.DataSource

                lista.RemoveAt(dgvInvitados.CurrentRow.Index)

                dgvInvitados.DataSource = Nothing
                dgvInvitados.DataSource = lista

                CalcularMonto()

            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        Else
            MsgBox("Debe Seleccionar un Elemento para Quitarlo", MsgBoxStyle.Information)
        End If
    End Sub

#End Region

#Region "Métodos Personalizados"

    Private Sub CalcularMonto()
        Dim cantIns As Integer = 0

        If ListadoPersona IsNot Nothing Then
            cantIns += ListadoPersona.Count
        End If

        If ListadoInvitado IsNot Nothing Then
            cantIns += ListadoInvitado.Count
        End If

        nudMonto.Value = Actividad.monto_pago * cantIns
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

        ListarRestriccionesXActividad()
        VerProgramacionxActividad()


    End Sub

    Private Sub CargarSocio(ByRef oSocio As SocioBE)
        Dim resul As String = ValidarRestricciones(oSocio.id_socio)

        If resul = "" Then
            txtAccion.Text = oSocio.id_accion
            txtNombre.Text = oSocio.nombre_completo
            _id_socio = oSocio.id_socio
        Else
            MsgBox(resul)
            Exit Sub
        End If

    End Sub

    Private Sub ListarRestriccionesXActividad()


        dgvRestricciones.Columns.Clear()
        dgvRestricciones.DataSource = Nothing


        Dim ListadoRestricciones As List(Of RestriccionesBE) = bc.ListarRestriccionesXActividad(CInt(txtCodigo.Text.Trim))

        If ListadoRestricciones IsNot Nothing AndAlso ListadoRestricciones.Count > 0 Then

            Actividad.ListaRestricciones = ListadoRestricciones

            Dim Col_Text As DataGridViewTextBoxColumn
            Dim Col_Chk As DataGridViewCheckBoxColumn
            Dim Row As DataGridViewRow
            Dim Cell As DataGridViewCell

            Col_Text = New DataGridViewTextBoxColumn
            Col_Text.Name = "id_restriccion"
            Col_Text.HeaderText = "Id"
            Col_Text.ReadOnly = True
            Col_Text.Visible = False
            dgvRestricciones.Columns.Add(Col_Text)

            Col_Text = New DataGridViewTextBoxColumn
            Col_Text.Name = "descripcion"
            Col_Text.HeaderText = "Descripción"
            Col_Text.ReadOnly = True
            Col_Text.Visible = True
            Col_Text.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            dgvRestricciones.Columns.Add(Col_Text)

            Col_Text = New DataGridViewTextBoxColumn
            Col_Text.Name = "id_signo"
            Col_Text.HeaderText = "idSigno"
            Col_Text.ReadOnly = True
            Col_Text.Visible = False
            Col_Text.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            dgvRestricciones.Columns.Add(Col_Text)

            Col_Text = New DataGridViewTextBoxColumn
            Col_Text.Name = "signo"
            Col_Text.HeaderText = "Signo"
            Col_Text.ReadOnly = True
            Col_Text.Visible = True
            Col_Text.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            dgvRestricciones.Columns.Add(Col_Text)

            Col_Chk = New DataGridViewCheckBoxColumn
            Col_Chk.Name = "valor"
            Col_Chk.HeaderText = "Valor"
            Col_Chk.ReadOnly = False
            Col_Chk.Visible = True
            Col_Chk.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            dgvRestricciones.Columns.Add(Col_Chk)

            For Each a As RestriccionesBE In ListadoRestricciones
                Row = New DataGridViewRow

                Cell = New DataGridViewTextBoxCell
                Cell.Value = a.id_restriccion
                Row.Cells.Add(Cell)
                Cell = New DataGridViewTextBoxCell
                Cell.Value = a.descripcion
                Row.Cells.Add(Cell)
                Cell = New DataGridViewTextBoxCell
                Cell.Value = a.id_signo
                Row.Cells.Add(Cell)
                Cell = New DataGridViewTextBoxCell
                Cell.Value = a.des_signo
                Row.Cells.Add(Cell)
                Cell = New DataGridViewTextBoxCell
                Cell.Value = a.valor
                Row.Cells.Add(Cell)

                dgvRestricciones.Rows.Add(Row)
            Next

        End If
    End Sub

    Private Sub VerProgramacionxActividad()

        dgvProgramacion.Columns.Clear()
        dgvProgramacion.DataSource = Nothing

        Dim ListadoProgramacion As List(Of ActividadDetalleBE) = bc.ListarDetallesXActividad(CInt(txtCodigo.Text.Trim))

        If ListadoProgramacion IsNot Nothing AndAlso ListadoProgramacion.Count > 0 Then

            Dim Col_Text As DataGridViewTextBoxColumn
            Dim Col_Chk As DataGridViewCheckBoxColumn
            Dim Row As DataGridViewRow
            Dim Cell As DataGridViewCell

            Col_Text = New DataGridViewTextBoxColumn
            Col_Text.Name = "fecha"
            Col_Text.HeaderText = "Fecha"
            Col_Text.ReadOnly = True
            Col_Text.Visible = True
            dgvProgramacion.Columns.Add(Col_Text)

            Col_Text = New DataGridViewTextBoxColumn
            Col_Text.Name = "hora_ini"
            Col_Text.HeaderText = "Inicio"
            Col_Text.ReadOnly = True
            Col_Text.Visible = True
            Col_Text.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            dgvProgramacion.Columns.Add(Col_Text)

            Col_Text = New DataGridViewTextBoxColumn
            Col_Text.Name = "hora_fin"
            Col_Text.HeaderText = "Fin"
            Col_Text.ReadOnly = True
            Col_Text.Visible = True
            Col_Text.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            dgvProgramacion.Columns.Add(Col_Text)

            Col_Text = New DataGridViewTextBoxColumn
            Col_Text.Name = "sede"
            Col_Text.HeaderText = "Sede"
            Col_Text.ReadOnly = True
            Col_Text.Visible = True
            Col_Text.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            dgvProgramacion.Columns.Add(Col_Text)

            Col_Chk = New DataGridViewCheckBoxColumn
            Col_Chk.Name = "espacio"
            Col_Chk.HeaderText = "Ubicacion"
            Col_Chk.ReadOnly = True
            Col_Chk.Visible = True
            Col_Chk.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            dgvProgramacion.Columns.Add(Col_Chk)

            For Each a As ActividadDetalleBE In ListadoProgramacion
                Row = New DataGridViewRow

                Cell = New DataGridViewTextBoxCell
                Cell.Value = a.fecha
                Row.Cells.Add(Cell)
                Cell = New DataGridViewTextBoxCell
                Cell.Value = a.hora_ini
                Row.Cells.Add(Cell)
                Cell = New DataGridViewTextBoxCell
                Cell.Value = a.hora_fin
                Row.Cells.Add(Cell)
                Cell = New DataGridViewTextBoxCell
                Cell.Value = a.des_sede
                Row.Cells.Add(Cell)
                Cell = New DataGridViewTextBoxCell
                Cell.Value = a.nombre_espacio
                Row.Cells.Add(Cell)

                dgvProgramacion.Rows.Add(Row)
            Next

        End If
    End Sub

    Private Function ValidarRestricciones(ByVal id_socio As String) As String
        Dim result As String = ""
        Dim msj As String = ""
        If Actividad.ListaRestricciones IsNot Nothing Then
            For Each oRestriccion As RestriccionesBE In Actividad.ListaRestricciones
                result = bc.ObtenerCantidadXRestriccion(Actividad.id_actividad, oRestriccion.id_restriccion, id_socio, Nothing, Nothing)
                If result IsNot Nothing AndAlso result.Trim <> "" Then
                    msj &= result
                End If
            Next
        End If
        Return msj.Trim
    End Function

    Private Sub AgregarInscrito(ByRef oPersona As PersonaBE)
        If ListadoPersona Is Nothing Then
            ListadoPersona = New List(Of PersonaBE)
        End If

        ListadoPersona.Add(oPersona)
        dgvInscritos.DataSource = Nothing
        dgvInscritos.DataSource = ListadoPersona


    End Sub

    Private Sub AgregarInvitado(ByRef oInvitado As InvitadoBE)
        If ListadoInvitado Is Nothing Then
            ListadoInvitado = New List(Of InvitadoBE)
        End If

        ListadoInvitado.Add(oInvitado)
        dgvInvitados.DataSource = Nothing
        dgvInvitados.DataSource = ListadoInvitado
    End Sub

    Private Sub LimpiarFormulario()
        txtCodigo.Text = ""
        txtActividad.Text = ""
        dgvProgramacion.DataSource = Nothing
        dgvRestricciones.DataSource = Nothing
        txtNumDoc.Text = ""
        txtSerie.Text = ""
        nudMonto.Value = 0
        txtAccion.Text = ""
        txtNombre.Text = ""
        dgvInscritos.DataSource = Nothing
        dgvInvitados.DataSource = Nothing
    End Sub

    Private Sub GuardarInscripcion()

        If ValidarCamposRequeridos() <> String.Empty Then
            MessageBox.Show(ValidarCamposRequeridos, "Información")
            Exit Sub
        End If

        Dim oInscripcion As New InscripcionBE
        oInscripcion.id_actividad = txtCodigo.Text.Trim
        oInscripcion.id_socio = _id_socio
        oInscripcion.ListaPersona = New List(Of PersonaBE)
        oInscripcion.ListaPersona = dgvInscritos.DataSource
        oInscripcion.ListaInvitado = dgvInvitados.DataSource
        oInscripcion.serie = txtSerie.Text
        oInscripcion.correlativo = txtNumDoc.Text
        oInscripcion.tipo_doc = "02"
        oInscripcion.flg_web = False
        oInscripcion.monto = nudMonto.Value

        oInscripcion.id_inscripcion = bc.InsertarInscripcion(oInscripcion)

        Dim oDocVen As New DocVenBE

        If Actividad.monto_pago > 0 Then
            If nudMonto.Value = 0 OrElse txtSerie.Text.Trim = String.Empty OrElse txtNumDoc.Text.Trim = String.Empty Then
                oDocVen = CrearDocumento(oInscripcion)
            End If
        End If

        If oInscripcion.id_inscripcion = 0 Then
            MessageBox.Show("Error al grabar", "Información")
        Else
            _id_inscripcion = oInscripcion.id_inscripcion
            MessageBox.Show("La inscripción se registró satisfactoriamente", "Información")
            If oDocVen IsNot Nothing AndAlso oDocVen.id_serie <> "" Then
                MessageBox.Show("Se generó el documento " & oDocVen.id_serie & " - " & oDocVen.id_correlativo, "Información")
            End If

        End If
    End Sub

    Private Function ValidarCamposRequeridos() As String
        Dim msg As String = String.Empty

        If txtCodigo.Text.Trim = String.Empty Then
            msg &= vbCrLf & "- Ingrese una actividad"
        End If

        Return msg
    End Function

    Private Function CrearDocumento(ByRef oInscripcion As InscripcionBE) As DocVenBE

        Dim oDocVen As New DocVenBE
        oDocVen.id_entidad = _id_socio
        oDocVen.obs_doc = "Actividad: " & Actividad.nombre & " Tipo de Actividad: " & Actividad.desc_tipo & " Comite: " & Actividad.nombrecomite
        oDocVen.tot_mon = nudMonto.Value

        oDocVen = bc.InsertarDocVen(oDocVen)

        Return oDocVen

    End Function

#End Region

End Class
