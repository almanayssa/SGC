Imports SGC.Model.Entidades
Imports SGC.Controller

Public Class frmConsultaActividadRecurrente

    Dim bc As New BusinessController
    Private ListadoActividad As List(Of ActividadBE)

#Region "Inicializacion"

    Public Sub New()
        InitializeComponent()

        cboComite.ValueMember = "id_comite"
        cboComite.DisplayMember = "nombre"

        dgvTodas.AutoGenerateColumns = False
       
        ctoNombre.DataPropertyName = "nombre"
        ctoTipo.DataPropertyName = "desc_tipo"
        ctoCategoria.DataPropertyName = "descripcion"
        ctoFecInicio.DataPropertyName = "fec_ini"
        ctoFecFin.DataPropertyName = "fec_fin"
        ctoPago.DataPropertyName = "monto_pago"
        ctoVacantes.DataPropertyName = "vacantes"
        ctoEstado.DataPropertyName = "desc_estado"

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
        ListadoActividad = bc.ListarActividades(cboComite.SelectedValue, dtpFecInicio.Value, dtpFecFin.Value)
        dgvTodas.DataSource = Nothing
        dgvTodas.DataSource = ListadoActividad
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
            ListarActividades()
        End If
    End Sub

#End Region

End Class
