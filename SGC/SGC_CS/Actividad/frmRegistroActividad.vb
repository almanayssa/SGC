Imports SGC.Model.Entidades
Imports SGC.Controller

Public Class frmRegistroActividad

    Dim bc As New BusinessController

    Private Sub frmRegistroActividad_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        ListarComites()
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

    Private Sub CargarTipoActividad()

    End Sub

    Private Sub CargarCategorias()

    End Sub

    Private Sub sbGuardar_Click(sender As System.Object, e As System.EventArgs) Handles sbGuardar.Click

    End Sub
End Class
