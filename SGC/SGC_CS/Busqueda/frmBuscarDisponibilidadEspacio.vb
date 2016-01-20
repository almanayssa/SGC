Imports SGC.Controller
Imports SGC.Model.Entidades

Public Class frmBuscarDisponibilidadEspacio

    Dim bc As New BusinessController

#Region "Inicializacion"

    Public Sub New()
        InitializeComponent()

        cboSede.ValueMember = "id_sede"
        cboSede.DisplayMember = "des_sede"

        cboLugar.ValueMember = "id_lugar"
        cboLugar.DisplayMember = "desc_lugar"

        dgvListado.AutoGenerateColumns = False

        colHoraInicio.DataPropertyName = "hora_inicio"
        colHoraFin.DataPropertyName = "hora_fin"
    End Sub

#End Region

#Region "Propiedades"

    Private _ListadoEspacioRes As List(Of EspacioResBE)
    Public Property ListadoEspacioRes() As List(Of EspacioResBE)
        Get
            Return _ListadoEspacioRes
        End Get
        Set(ByVal value As List(Of EspacioResBE))
            _ListadoEspacioRes = value
        End Set
    End Property

#End Region

#Region "Metodos Personalizados"

    Private Sub ListarSedes()
        Dim ListadoSede As List(Of SedeBE) = bc.ListarSedes()
        cboSede.DataSource = Nothing
        cboSede.DataSource = ListadoSede
    End Sub

    Private Sub ListarLugares()
        Dim oLugar As New LugarBE
        oLugar.id_lugar = 0
        oLugar.desc_lugar = "- Seleccione -"

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

    Private Sub ListarDisponibilidadEspacio()
        Dim ListadoEspacioRes As List(Of EspacioResBE) = bc.ListarCronogramaEspacios(cboEspacio.SelectedValue, dtpFecha.Value)
        Dim newListadoEspacioRes As New List(Of EspacioResBE)

        For Each oEspacioRes As EspacioResBE In ListadoEspacioRes
            If oEspacioRes.estado = "Disponible" Then
                newListadoEspacioRes.Add(oEspacioRes)
            End If
        Next

        dgvListado.DataSource = Nothing
        dgvListado.DataSource = newListadoEspacioRes
    End Sub

#End Region

#Region "Cargar"

    Private Sub frmBuscarEspacio_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
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

        ListarDisponibilidadEspacio()
    End Sub

    Private Sub btnAgregar_Click(sender As System.Object, e As System.EventArgs) Handles btnAgregar.Click
        'Dim val As String = String.Empty

        For Each row As DataGridViewRow In dgvListado.Rows
            Dim value As Boolean = CType(dgvListado.Item(colSeleccionar.Index, row.Index).EditedFormattedValue, Boolean)
            Dim oEspacioRes As EspacioResBE = row.DataBoundItem

            If value Then
                'If val = String.Empty Then
                '    val = "1"
                'End If

                If ListadoEspacioRes Is Nothing Then
                    ListadoEspacioRes = New List(Of EspacioResBE)
                End If
                oEspacioRes.fec_ini = dtpFecha.Value.ToShortDateString()
                oEspacioRes.fec_fin = dtpFecha.Value.ToShortDateString()
                oEspacioRes.id_sede = cboSede.SelectedValue
                oEspacioRes.des_sede = cboSede.GetItemText(cboSede.SelectedItem)
                oEspacioRes.id_espacio = cboEspacio.SelectedValue
                oEspacioRes.nombre_espacio = cboEspacio.GetItemText(cboEspacio.SelectedItem)
                ListadoEspacioRes.Add(oEspacioRes)
                'Else
                '    If val <> String.Empty Then
                '        val = "0"
                '        Exit For
                '    End If
            End If
        Next

        'If val = "0" Then
        '    MessageBox.Show("No se puede elegir horas salteadas", "Información")
        'End If
    End Sub

#End Region

End Class