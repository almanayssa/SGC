Imports SGC.Model.Entidades
Imports SGC.Controller

Public Class frmConsultaActividadRecurrente

    Dim bc As New BusinessController
    Private ListadoActividadRecurrente As List(Of ActividadRecurrenteBE)

#Region "Inicializacion"

    Public Sub New()
        InitializeComponent()

        cboComite.ValueMember = "id_comite"
        cboComite.DisplayMember = "nombre"

        dgvListado.AutoGenerateColumns = False

        colNombre.DataPropertyName = "nombre"
        colTipo.DataPropertyName = "desc_tipo"
        colCategoria.DataPropertyName = "descripcion"
        colFecInicio.DataPropertyName = "fecha_ini"
        colFecFin.DataPropertyName = "fecha_fin"
        colPago.DataPropertyName = "monto_pago"
        colVacantes.DataPropertyName = "vacantes"

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

    Private Sub ListarActividadesRecurrentes()
        ListadoActividadRecurrente = bc.ListarActividadesRecurrentes(cboComite.SelectedValue, dtpFecInicio.Value, dtpFecFin.Value)
        dgvListado.DataSource = Nothing
        dgvListado.DataSource = ListadoActividadRecurrente
    End Sub

#End Region

#Region "Cargar"

    Private Sub frmConsultaActividad_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        ListarComites()
    End Sub

#End Region

#Region "Metodos Controles"

    Private Sub btnBuscar_Click(sender As System.Object, e As System.EventArgs) Handles btnBuscar.Click
        If cboComite.SelectedValue = "000" Then
            MessageBox.Show("Seleccione un comité", "Información")
            Exit Sub
        Else
            ListarActividadesRecurrentes()
        End If
    End Sub

#End Region

End Class
