Imports SGC.Model.Entidades

Namespace SGC.Model.Interfaces

    Public Interface IUsuario

#Region "Select"

        Function ObtenerUsuario(ByVal username As String, ByVal password As String) As UsuarioBE
        Function ObtenerUsuarioPorId(ByVal id_usuario As String) As UsuarioBE
        Function ObtenerUsuarioPorEmail(ByVal email As String) As UsuarioBE

#End Region

#Region "Insert"

        Function InsertarUsuario(ByRef oUsuario As UsuarioBE) As Integer

#End Region

#Region "Update"

        Function ActualizarUsuario(ByRef oUsuario As UsuarioBE) As Integer

#End Region

#Region "Delete"

        Function BorrarUsuario(ByVal id_usuario As String) As Integer

#End Region

    End Interface

End Namespace

