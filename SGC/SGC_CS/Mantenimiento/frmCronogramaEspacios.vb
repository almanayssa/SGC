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

    Private Sub ListarAnio()
        Dim id As String() = New String(1) {"2015", "2016"}
        Dim desc As String() = New String(1) {"2015", "2016"}

        Dim dt As New DataTable
        dt.Columns.Add("id")
        dt.Columns.Add("desc")

        Dim dr As DataRow

        For i As Integer = 0 To 1
            dr = dt.NewRow()
            dr("id") = id(i)
            dr("desc") = desc(i)
            dt.Rows.Add(dr)
        Next

        dt.AcceptChanges()

        cboAnio.DataSource = dt
        cboAnio.DisplayMember = "desc"
        cboAnio.ValueMember = "id"


        cboAnio.SelectedValue = Now.Year + 1
    End Sub

#End Region

#Region "Cargar"

    Private Sub frmCronogramaEspacios_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        ListarSedes()
        ListarLugares()
        ListarAnio()
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

#End Region

End Class
