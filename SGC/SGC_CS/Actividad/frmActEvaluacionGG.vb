Imports SGC.Model.Entidades
Imports SGC.Controller

Public Class frmActEvaluacionGG

    Dim bc As New BusinessController
    Private ListadoActividad As List(Of ActividadBE)

#Region "Inicializacion"

    Public Sub New()
        InitializeComponent()

        cboComite.ValueMember = "id_comite"
        cboComite.DisplayMember = "nombre"

        dgvListado.AutoGenerateColumns = False

        colNombre.DataPropertyName = "nombre"
        colTipo.DataPropertyName = "desc_tipo"
        colCategoria.DataPropertyName = "desc_cat"
        colFecInicio.DataPropertyName = "fecha"
        'colFecFin.DataPropertyName = "fec_fin"
        colPago.DataPropertyName = "monto_pago"
        colVacantes.DataPropertyName = "vacantes"
        colEstado.DataPropertyName = "desc_estado"

        colPago.Visible = False
        colVacantes.Visible = False

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
        ListadoActividad = bc.ListarActividadesGG(cboComite.SelectedValue)
        dgvListado.DataSource = Nothing
        dgvListado.DataSource = ListadoActividad
    End Sub

#End Region

#Region "Cargar"

    Private Sub frmActEvaluacionGG_Load(sender As Object, e As System.EventArgs) Handles Me.Load
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

    Private Sub btnAprobar_Click(sender As System.Object, e As System.EventArgs) Handles btnAprobar.Click
        Dim ListadoActividades As New List(Of ActividadBE)

        For Each row As DataGridViewRow In dgvListado.Rows
            Dim value As Boolean = CType(dgvListado.Item(colSeleccionar.Index, row.Index).EditedFormattedValue, Boolean)
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
                affectedRows = bc.InsertarSeguimientoActividades(ListadoActividades, 2, 4)

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

        For Each row As DataGridViewRow In dgvListado.Rows
            Dim value As Boolean = CType(dgvListado.Item(colSeleccionar.Index, row.Index).EditedFormattedValue, Boolean)
            Dim oActividad As ActividadBE = row.DataBoundItem

            If value Then
                ListadoActividades.Add(oActividad)
            End If
        Next

        If ListadoActividades.Count = 0 Then
            MessageBox.Show("Seleccione una actividad al menos", "Información")
            Exit Sub
        Else
            If MsgBox("Seguro que desea rechazar la(s) actividad(es)?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                Dim affectedRows As Integer = 0
                affectedRows = bc.InsertarSeguimientoActividades(ListadoActividades, 2, 6)

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
