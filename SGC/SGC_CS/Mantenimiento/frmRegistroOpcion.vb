Imports SGC.Model.Entidades
Imports SGC.Controller

Public Class frmRegistroOpcion

    Dim bc As New BusinessController
    Private Perfil As PerfilUsuarioBE
    Private ListadoOpciones As List(Of PantallaBE)
    Private _id_perfil As Integer

#Region "Inicializacion"

    Public Sub New()
        InitializeComponent()

        dgvOpciones.AutoGenerateColumns = False

        colPantallaID.DataPropertyName = "id_pantalla"
        colPantalla.DataPropertyName = "nom_pantalla"

    End Sub

#End Region

#Region "Metodos Personalizados"

    Private Sub FormularioEnModoEdicion()
        tsbLimpiar.Visible = False
        tsbGuardar.Visible = True
        tsbEditar.Visible = False
        tsbCancelar.Visible = True

        dgvOpciones.ReadOnly = False
    End Sub

    Private Sub FormularioEnModoVista()
        tsbLimpiar.Visible = True
        tsbGuardar.Visible = False
        tsbEditar.Visible = True
        tsbCancelar.Visible = False

        dgvOpciones.ReadOnly = True
    End Sub

    Private Sub ListarOpciones()
        Dim ListadoOpciones As List(Of PantallaBE) = bc.ListarOpciones()
        dgvOpciones.DataSource = Nothing
        dgvOpciones.DataSource = ListadoOpciones
    End Sub

    Private Sub CargarPerfil(ByVal id_perfil As Integer)
        Dim oPerfil As PerfilUsuarioBE = bc.ObtenerPerfil(id_perfil)
        Perfil = oPerfil
        txtCodigo.Text = oPerfil.id_perfil_usuario
        txtPerfil.Text = oPerfil.nombre

        ListarOpcionesXPerfil()
    End Sub

    Private Sub ListarOpcionesXPerfil()
        ListarOpciones()
        ListadoOpciones = bc.ListarOpcionesXPerfil(CInt(txtCodigo.Text.Trim))
         
        If ListadoOpciones IsNot Nothing AndAlso ListadoOpciones.Count > 0 Then
            For Each row As DataGridViewRow In dgvOpciones.Rows
                Dim chk = DirectCast(row.Cells(colSeleccionar.Index), DataGridViewCheckBoxCell)
                Dim id As Integer = CInt(row.Cells(colPantallaID.Index).Value)

                For Each oOpcion As PantallaBE In ListadoOpciones
                    If oOpcion.id_pantalla = id Then
                        chk.Value = True
                        Exit For
                    End If
                Next
            Next
        End If
    End Sub

    Private Sub LimpiarFormulario()
        tsbLimpiar.Visible = True
        tsbGuardar.Visible = True
        tsbEditar.Visible = False
        tsbCancelar.Visible = False

        txtCodigo.Text = String.Empty
        txtPerfil.Text = String.Empty
        
        ListarOpciones()

        dgvOpciones.ReadOnly = True
    End Sub

    Private Function ValidarOpciones() As String
        Dim msg As String = String.Empty
        Dim count As Integer = 0

        For Each row As DataGridViewRow In dgvOpciones.Rows
            Dim value As Boolean = CType(dgvOpciones.Item(colSeleccionar.Index, row.Index).EditedFormattedValue, Boolean)

            If value Then
                count += 1
            End If
        Next

        If count = 0 Then
            msg &= vbCrLf & "- Seleccione una pantalla por lo menos"
        End If

        Return msg
    End Function

    Private Function GuardarOpciones() As Boolean
        Dim flag As Boolean = True

        If ValidarOpciones() <> String.Empty Then
            MessageBox.Show(ValidarOpciones, "Información")
            flag = False
            Return flag
            Exit Function
        End If

        Dim affectedRows As String = String.Empty
        Dim oPerfil As New PerfilUsuarioBE
        oPerfil.id_perfil_usuario = txtCodigo.Text

        For Each row As DataGridViewRow In dgvOpciones.Rows
            Dim value As Boolean = CType(dgvOpciones.Item(colSeleccionar.Index, row.Index).EditedFormattedValue, Boolean)
            Dim oOpcion As PantallaBE = row.DataBoundItem

            If value Then
                If oPerfil.ListaOpciones Is Nothing Then
                    oPerfil.ListaOpciones = New List(Of PantallaBE)
                End If

                oPerfil.ListaOpciones.Add(oOpcion)
            End If
        Next

        affectedRows = bc.GuardarOpcionesPerfil(oPerfil)

        If affectedRows = String.Empty Then
            MessageBox.Show("Error al grabar", "Información")
            flag = False
        Else
            _id_perfil = oPerfil.id_perfil_usuario
            MessageBox.Show("Las opciones del perfil se registraron satisfactoriamente", "Información")
        End If

        Return flag

    End Function

#End Region

#Region "Cargar"

    Private Sub frmRegistroUsuario_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        ListarOpciones()
    End Sub

#End Region

#Region "Metodos Controles"

    Private Sub tsbLimpiar_Click(sender As System.Object, e As System.EventArgs) Handles tsbLimpiar.Click
        LimpiarFormulario()
    End Sub

    Private Sub tsbGuardar_Click(sender As Object, e As System.EventArgs) Handles tsbGuardar.Click
        If GuardarOpciones() Then
            LimpiarFormulario()
            CargarPerfil(_id_perfil)
            FormularioEnModoVista()
        End If
    End Sub

    Private Sub tsbEditar_Click(sender As System.Object, e As System.EventArgs) Handles tsbEditar.Click
        FormularioEnModoEdicion()
    End Sub

    Private Sub tsbEliminar_Click(sender As System.Object, e As System.EventArgs)
        If txtCodigo.Text.Trim <> String.Empty Then
            If MsgBox("Seguro que desea anular el usuario?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                Dim affectedRows As Integer = 0
                affectedRows = bc.BorrarUsuario(CInt(txtCodigo.Text.Trim))

                If affectedRows = 0 Then
                    MessageBox.Show("Error al borrar", "Información")
                Else
                    MessageBox.Show("El perfil se anuló satisfactoriamente", "Información")
                End If

                LimpiarFormulario()
            End If
        End If
    End Sub

    Private Sub tsbCancelar_Click(sender As System.Object, e As System.EventArgs) Handles tsbCancelar.Click
        If MsgBox("Seguro que desea cancelar la operación?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            CargarPerfil(_id_perfil)
            FormularioEnModoVista()
        End If
    End Sub

    Private Sub btnBuscar_Click(sender As System.Object, e As System.EventArgs) Handles btnBuscar.Click
        Dim frmBuscarPerfil As New frmBuscarPerfil
        frmBuscarPerfil.ShowDialog()

        If frmBuscarPerfil.PerfilSeleccionado IsNot Nothing Then
            tsbEditar.Visible = True
            _id_perfil = frmBuscarPerfil.PerfilSeleccionado.id_perfil_usuario
            CargarPerfil(frmBuscarPerfil.PerfilSeleccionado.id_perfil_usuario)
            FormularioEnModoVista()
        End If
    End Sub

#End Region

End Class