Imports SGC.Model.Entidades
Imports SGC.Controller

Public Class frmRegistroActividad

    Dim bc As New BusinessController

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        cboComite.ValueMember = "id_comite"
        cboComite.DisplayMember = "nombre"

        cboTipo.ValueMember = "id_tipo_act"
        cboTipo.DisplayMember = "desc_tipo"

        cboCategoria.ValueMember = "id_tipo_act"
        cboCategoria.DisplayMember = "desc_tipo"
    End Sub

    Private Sub frmRegistroActividad_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        ListarComites()
        ListarTipoActividad()
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

    Private Sub tsbGuardar_Click(sender As System.Object, e As System.EventArgs) Handles tsbGuardar.Click

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
End Class
