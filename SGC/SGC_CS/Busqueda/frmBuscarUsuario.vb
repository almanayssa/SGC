Imports SGC.Controller
Imports SGC.Model.Entidades

Public Class frmBuscarUsuario

    Dim bc As New BusinessController

#Region "Inicializacion"

    Public Sub New()
        InitializeComponent()

        cboPerfil.ValueMember = "id_Perfil_Usuario"
        cboPerfil.DisplayMember = "Nombre"

        dgvListado.AutoGenerateColumns = False
        colUsuario.DataPropertyName = "username"
        colNombre.DataPropertyName = "nombres"
        colApellido.DataPropertyName = "ape_pat"
        colEmail.DataPropertyName = "email"
    End Sub

#End Region

#Region "Propiedades"

    Private _UsuarioSeleccionado As UsuarioBE
    Public Property UsuarioSeleccionado() As UsuarioBE
        Get
            Return _UsuarioSeleccionado
        End Get
        Set(ByVal value As UsuarioBE)
            _UsuarioSeleccionado = value
        End Set
    End Property

#End Region

#Region "Metodos Personalizados"

    Private Sub ListarPerfiles()
        Dim oPerfil As New PerfilUsuarioBE
        oPerfil.id_perfil_usuario = 0
        oPerfil.nombre = "- Seleccione -"

        Dim ListadoPerfil As List(Of PerfilUsuarioBE) = bc.ListarPerfiles()
        ListadoPerfil.Insert(0, oPerfil)
        cboPerfil.DataSource = Nothing
        cboPerfil.DataSource = ListadoPerfil
    End Sub

    Private Sub ListarUsuarios()
        Dim ListadoUsuarios As List(Of UsuarioBE) = bc.ListarUsuarios(cboPerfil.SelectedValue)
        dgvListado.DataSource = Nothing
        dgvListado.DataSource = ListadoUsuarios
    End Sub

#End Region

#Region "Cargar"

    Private Sub frmBuscarUsuario_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        ListarPerfiles()
    End Sub

#End Region

#Region "Metodos Controles"

    Private Sub btnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscar.Click
        If cboPerfil.SelectedValue = 0 Then
            MessageBox.Show("Seleccione un perfil", "Información")
            Exit Sub
        Else
            ListarUsuarios()
        End If
    End Sub

#End Region

#Region "Metodos Grilla"

    Private Sub dgvListado_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvListado.CellDoubleClick
        UsuarioSeleccionado = DirectCast(dgvListado.CurrentRow.DataBoundItem, UsuarioBE)
        Me.Close()
    End Sub

#End Region

End Class