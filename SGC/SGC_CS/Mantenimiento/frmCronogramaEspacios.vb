Imports SGC.Model.Entidades
Imports SGC.Controller

Public Class frmCronogramaEspacios

    Dim bc As New BusinessController

#Region "Inicializacion"

    Public Sub New()
        InitializeComponent()

        cboSede.ValueMember = "id_sede"
        cboSede.DisplayMember = "des_sede"

        cboLugar.ValueMember = "id_lugar"
        cboLugar.DisplayMember = "desc_lugar"

        dgvCalendario.AutoGenerateColumns = False

        colHoraInicio.DataPropertyName = "hora_inicio"
        colHoraFin.DataPropertyName = "hora_fin"
        colEstado.DataPropertyName = "estado"
        colComite.DataPropertyName = "nombre_comite"
        colObservacion.DataPropertyName = "observacion"

    End Sub

#End Region

#Region "Metodos Personalizados"

    Private Sub ListarSedes()
        Dim ListadoSede As List(Of SedeBE) = bc.ListarSedes()
        cboSede.DataSource = Nothing
        cboSede.DataSource = ListadoSede
    End Sub

    Private Sub ListarLugares()
        Dim ListadoLugar As List(Of LugarBE) = bc.ListarLugares()
        cboLugar.DataSource = Nothing
        cboLugar.DataSource = ListadoLugar
    End Sub

    Private Function ValidarCamposRequeridos() As String
        Dim msg As String = String.Empty

        If cboSede.SelectedValue = "000" Then
            msg &= vbCrLf & "- Seleccione una sede"
        End If

        If cboLugar.SelectedValue = 0 Then
            msg &= vbCrLf & "- Seleccione un lugar"
        End If

        If cboEspacio.SelectedValue = 0 Then
            msg &= vbCrLf & "- Seleccione un espacio"
        End If

        Return msg
    End Function

    Private Sub ListarCronogramaEspacios()
        Dim ListadoEspacioRes As List(Of EspacioResBE) = bc.ListarCronogramaEspacios(cboEspacio.SelectedValue, dtpFecha.Value)
        dgvCalendario.DataSource = Nothing
        dgvCalendario.DataSource = ListadoEspacioRes
    End Sub

#End Region

#Region "Cargar"

    Private Sub frmCronogramaEspacios_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        ListarSedes()
        ListarLugares()
    End Sub

#End Region

#Region "Metodos Controles"

    Private Sub cboSede_SelectedValueChanged(sender As Object, e As System.EventArgs) Handles cboSede.SelectedValueChanged, cboLugar.SelectedValueChanged
        If cboSede.SelectedValue IsNot Nothing And cboLugar.SelectedValue IsNot Nothing Then
            If cboSede.SelectedValue = "000" Or cboLugar.SelectedValue = 0 Then
                cboEspacio.Enabled = False
                cboEspacio.DataSource = Nothing
            Else
                Dim ListadoEspacios As List(Of EspacioBE) = bc.ListarEspacios(cboSede.SelectedValue, cboLugar.SelectedValue)

                If ListadoEspacios.Count = 0 Then
                    cboEspacio.Enabled = False
                    cboEspacio.DataSource = Nothing
                Else
                    cboEspacio.Enabled = True
                    Dim oEspacio As New EspacioBE
                    oEspacio.id_espacio = 0
                    oEspacio.nombre = "- Seleccione -"

                    ListadoEspacios.Insert(0, oEspacio)
                    cboEspacio.DataSource = Nothing
                    cboEspacio.DataSource = ListadoEspacios
                    cboEspacio.ValueMember = "id_espacio"
                    cboEspacio.DisplayMember = "nombre"
                End If
            End If
        End If
    End Sub

    Private Sub btnBuscar_Click(sender As System.Object, e As System.EventArgs) Handles btnBuscar.Click
        If ValidarCamposRequeridos() <> String.Empty Then
            MessageBox.Show(ValidarCamposRequeridos, "Información")
            Exit Sub
        End If

        ListarCronogramaEspacios()
    End Sub

#End Region

End Class
