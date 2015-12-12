Imports SGC.Model.Entidades
Imports SGC.Controller

Public Class frmRegistroEspacio

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

#End Region

#Region "Cargar"

    Private Sub frmRegistroEspacio_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        ListarSedes()
        ListarLugares()
    End Sub

#End Region

End Class
