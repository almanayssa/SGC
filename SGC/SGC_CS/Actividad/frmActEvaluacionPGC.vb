Imports SGC.Model.Entidades
Imports SGC.Controller

Public Class frmActEvaluacionPGC

    Dim bc As New BusinessController
    Private ListadoActividadPendiente As List(Of ActividadBE)
    Private ListadoActividadAprobada As List(Of ActividadBE)
    Private ListadoActividadRechazada As List(Of ActividadBE)

#Region "Inicializacion"

    Public Sub New()
        InitializeComponent()

        cboComite.ValueMember = "id_comite"
        cboComite.DisplayMember = "nombre"

        dgvRegistradas.AutoGenerateColumns = False
        dgvAprobadas.AutoGenerateColumns = False
        dgvRechazadas.AutoGenerateColumns = False

        creNombre.DataPropertyName = "nombre"
        creTipo.DataPropertyName = "desc_tipo"
        creCategoria.DataPropertyName = "desc_cat"
        creFecInicio.DataPropertyName = "fec_ini"
        creFecFin.DataPropertyName = "fec_fin"
        crePago.DataPropertyName = "monto_pago"
        creVacantes.DataPropertyName = "vacantes"
        creEstado.DataPropertyName = "desc_estado"

        crePago.Visible = False
        creVacantes.Visible = False

        capNombre.DataPropertyName = "nombre"
        capTipo.DataPropertyName = "desc_tipo"
        capCategoria.DataPropertyName = "desc_cat"
        capFecInicio.DataPropertyName = "fec_ini"
        capFecFin.DataPropertyName = "fec_fin"
        capPago.DataPropertyName = "monto_pago"
        capVacantes.DataPropertyName = "vacantes"
        capEstado.DataPropertyName = "desc_estado"

        capPago.Visible = False
        capVacantes.Visible = False

        crcNombre.DataPropertyName = "nombre"
        crcTipo.DataPropertyName = "desc_tipo"
        crcCategoria.DataPropertyName = "desc_cat"
        crcFecInicio.DataPropertyName = "fec_ini"
        crcFecFin.DataPropertyName = "fec_fin"
        crcPago.DataPropertyName = "monto_pago"
        crcVacantes.DataPropertyName = "vacantes"
        crcEstado.DataPropertyName = "desc_estado"

        crcPago.Visible = False
        crcVacantes.Visible = False

    End Sub

#End Region

#Region "Metodos Personalizados"

    Private Sub ListarComites()
        Dim oComite As New ComiteBE
        oComite.id_comite = "000"
        oComite.nombre = "- Seleccione -"

        Dim ListadoComites As List(Of ComiteBE) = bc.ListarComites()
        ListadoComites.Insert(0, oComite)
        cboComite.DataSource = Nothing
        cboComite.DataSource = ListadoComites
    End Sub

    Private Sub ListarActividades()
        ListadoActividadPendiente = bc.ListarActividadesPendientesPGC(cboComite.SelectedValue)
        dgvRegistradas.DataSource = Nothing
        dgvRegistradas.DataSource = ListadoActividadPendiente

        ListadoActividadAprobada = bc.ListarActividadesAprobadasPGC(cboComite.SelectedValue)
        dgvAprobadas.DataSource = Nothing
        dgvAprobadas.DataSource = ListadoActividadAprobada

        ListadoActividadRechazada = bc.ListarActividadesRechazadasPGC(cboComite.SelectedValue)
        dgvRechazadas.DataSource = Nothing
        dgvRechazadas.DataSource = ListadoActividadRechazada
    End Sub

#End Region

#Region "Cargar"

    Private Sub frmActEvaluacionPGC_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        ListarComites()
    End Sub

#End Region

#Region "Metodos Controles"

    Private Sub btnBuscar_Click(sender As System.Object, e As System.EventArgs) Handles btnBuscar.Click
        If cboComite.SelectedValue = "000" Then
            MessageBox.Show("Seleccione un comité", "Información")
            Exit Sub
        Else
            ListarActividades()
        End If
    End Sub

    Private Sub btnEnviarGG_Click(sender As System.Object, e As System.EventArgs) Handles btnEnviarGG.Click
        Dim ListadoActividades As New List(Of ActividadBE)

        For Each row As DataGridViewRow In dgvRegistradas.Rows
            Dim value As Boolean = CType(dgvRegistradas.Item(creSeleccionar.Index, row.Index).EditedFormattedValue, Boolean)
            Dim oActividad As ActividadBE = row.DataBoundItem

            If value Then
                ListadoActividades.Add(oActividad)
            End If
        Next

        If ListadoActividades.Count = 0 Then
            MessageBox.Show("Seleccione una actividad al menos", "Información")
            Exit Sub
        Else
            If MsgBox("Seguro que desea enviar la(s) actividad(es) a Gerencia General?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                Dim affectedRows As Integer = 0
                affectedRows = bc.InsertarSeguimientoActividades(ListadoActividades, 1, 2)

                If affectedRows = 0 Then
                    MessageBox.Show("Error al enviar", "Información")
                    Exit Sub
                Else
                    MessageBox.Show("La(s) actividad(es) fue(fueron) enviada(s) satisfactoriamente", "Información")
                    ListarActividades()
                End If
            End If
        End If
    End Sub

    Private Sub btnEnviarCD_Click(sender As System.Object, e As System.EventArgs) Handles btnEnviarCD.Click
        Dim ListadoActividades As New List(Of ActividadBE)

        For Each row As DataGridViewRow In dgvRegistradas.Rows
            Dim value As Boolean = CType(dgvRegistradas.Item(creSeleccionar.Index, row.Index).EditedFormattedValue, Boolean)
            Dim oActividad As ActividadBE = row.DataBoundItem

            If value Then
                ListadoActividades.Add(oActividad)
            End If
        Next

        If ListadoActividades.Count = 0 Then
            MessageBox.Show("Seleccione una actividad al menos", "Información")
            Exit Sub
        Else
            If MsgBox("Seguro que desea enviar la(s) actividad(es) a Consejo Directivo?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                Dim affectedRows As Integer = 0
                affectedRows = bc.InsertarSeguimientoActividades(ListadoActividades, 1, 1)

                If affectedRows = 0 Then
                    MessageBox.Show("Error al enviar", "Información")
                    Exit Sub
                Else
                    MessageBox.Show("La(s) actividad(es) fue(fueron) enviada(s) satisfactoriamente", "Información")
                    ListarActividades()
                End If
            End If
        End If
    End Sub

    Private Sub btnAprobar_Click(sender As System.Object, e As System.EventArgs) Handles btnAprobar.Click
        Dim ListadoActividades As New List(Of ActividadBE)

        For Each row As DataGridViewRow In dgvAprobadas.Rows
            Dim value As Boolean = CType(dgvAprobadas.Item(capSeleccionar.Index, row.Index).EditedFormattedValue, Boolean)
            Dim oActividad As ActividadBE = row.DataBoundItem

            If value Then
                ListadoActividades.Add(oActividad)
            End If
        Next

        If ListadoActividades.Count = 0 Then
            MessageBox.Show("Seleccione una actividad al menos", "Información")
            Exit Sub
        Else
            If MsgBox("Seguro que desea aprobar la(s) actividad(es)?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                Dim affectedRows As Integer = 0
                affectedRows = bc.ActualizarActividadEstado(ListadoActividades, "EST004")

                If affectedRows = 0 Then
                    MessageBox.Show("Error al aprobar", "Información")
                    Exit Sub
                Else
                    MessageBox.Show("La(s) actividad(es) fue(fueron) aprobada(s) satisfactoriamente", "Información")
                    ListarActividades()
                End If
            End If
        End If
    End Sub

    Private Sub btnRechazar_Click(sender As System.Object, e As System.EventArgs) Handles btnRechazar.Click
        Dim ListadoActividades As New List(Of ActividadBE)

        For Each row As DataGridViewRow In dgvRechazadas.Rows
            Dim value As Boolean = CType(dgvRechazadas.Item(crcSeleccionar.Index, row.Index).EditedFormattedValue, Boolean)
            Dim oActividad As ActividadBE = row.DataBoundItem

            If value Then
                ListadoActividades.Add(oActividad)
            End If
        Next

        If ListadoActividades.Count = 0 Then
            MessageBox.Show("Seleccione una actividad al rechazar", "Información")
            Exit Sub
        Else
            If MsgBox("Seguro que desea rechazar la(s) actividad(es)?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                Dim affectedRows As Integer = 0
                affectedRows = bc.ActualizarActividadEstado(ListadoActividades, "EST006")

                If affectedRows = 0 Then
                    MessageBox.Show("Error al rechazar", "Información")
                    Exit Sub
                Else
                    MessageBox.Show("La(s) actividad(es) fue(fueron) rechazada(s) satisfactoriamente", "Información")
                    ListarActividades()
                End If
            End If
        End If
    End Sub

#End Region

End Class
