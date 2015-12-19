Imports SGC.Model.Entidades
Imports SGC.Controller

Public Class frmSuscripcionComite

    Dim bc As New BusinessController
    Private oSocio As SocioBE

#Region "Inicializacion"

    Public Sub New()

        InitializeComponent()

        dgvComites.AutoGenerateColumns = False

        colId.DataPropertyName = "id_comite"
        colComite.DataPropertyName = "comite"
        colSel.DataPropertyName = "flg"

    End Sub

#End Region

#Region "Metodos Controles"

    Private Sub btnBuscar_Click(sender As System.Object, e As System.EventArgs) Handles btnBuscar.Click
        Dim frmBuscarSocio As New frmBuscarSocio
        frmBuscarSocio.ShowDialog()

        If frmBuscarSocio.SocioSeleccionado IsNot Nothing Then

            oSocio = New SocioBE
            oSocio = frmBuscarSocio.SocioSeleccionado

            CargarSocio(frmBuscarSocio.SocioSeleccionado)

            CargarComites(frmBuscarSocio.SocioSeleccionado)
        End If
    End Sub

    Private Sub tsbGuardar_Click(sender As System.Object, e As System.EventArgs) Handles tsbGuardar.Click
        If GuardarSuscripcion() Then
            dgvComites.DataSource = Nothing
            CargarSocio(oSocio)
            CargarComites(oSocio)
        End If
    End Sub

    Private Sub tsbLimpiar_Click(sender As System.Object, e As System.EventArgs) Handles tsbLimpiar.Click

        oSocio = New SocioBE
        dgvComites.DataSource = Nothing
        txtAccion.Text = ""
        txtNombre.Text = ""
    End Sub

#End Region

#Region "Metodos Personalizados"

    Private Sub CargarSocio(ByRef oSocio As SocioBE)

        txtAccion.Text = oSocio.id_accion
        txtNombre.Text = oSocio.nombre_completo

    End Sub

    Private Sub CargarComites(ByRef oSocio As SocioBE)

        Dim ListadoSusComite As List(Of SuscripcionComiteBE) = bc.ListarSuscripcionComites(oSocio.id_socio)
        dgvComites.DataSource = Nothing
        dgvComites.DataSource = ListadoSusComite

    End Sub

    Private Function GuardarSuscripcion() As Boolean
        Dim flag As Boolean = True

        If ValidarCamposRequeridos() <> String.Empty Then
            MessageBox.Show(ValidarCamposRequeridos, "Información")
            flag = False
            Return flag
            Exit Function
        End If

        Dim affectedRows As Integer = 0
        Dim listado As New List(Of SuscripcionComiteBE)

        For Each row As DataGridViewRow In dgvComites.Rows
            Dim value As Boolean = CType(dgvComites.Item(colSel.Index, row.Index).EditedFormattedValue, Boolean)
            Dim oSusComite As SuscripcionComiteBE = row.DataBoundItem

            If value Then
                listado.Add(oSusComite)
            End If
        Next

        If bc.InsertarSuscripcionComite(listado, oSocio) Then
            MessageBox.Show("La suscripción se registró satisfactoriamente", "Información")
            flag = True
        Else
            MessageBox.Show("Error al grabar", "Información")
            flag = False
        End If

        Return flag

    End Function

    Private Function ValidarCamposRequeridos() As String
        Dim msg As String = String.Empty

        If txtAccion.Text.Trim = String.Empty Then
            msg &= vbCrLf & "- Seleccione un asociado"
        End If


        Return msg
    End Function

#End Region


End Class
