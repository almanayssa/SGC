Namespace SGC.Model.Entidades

    Public Class UsuarioBE

        Private _username As String
        Public Property username() As String
            Get
                Return _username
            End Get
            Set(ByVal value As String)
                _username = value
            End Set
        End Property

        Private _password As String
        Public Property password() As String
            Get
                Return _password
            End Get
            Set(ByVal value As String)
                _password = value
            End Set
        End Property

        Private _email As String
        Public Property email() As String
            Get
                Return _email
            End Get
            Set(ByVal value As String)
                _email = value
            End Set
        End Property

        Private _id_est_usu As String
        Public Property id_est_usu() As String
            Get
                Return _id_est_usu
            End Get
            Set(ByVal value As String)
                _id_est_usu = value
            End Set
        End Property

        Private _nombres As String
        Public Property nombres() As String
            Get
                Return _nombres
            End Get
            Set(ByVal value As String)
                _nombres = value
            End Set
        End Property

        Private _ape_pat As String
        Public Property ape_pat() As String
            Get
                Return _ape_pat
            End Get
            Set(ByVal value As String)
                _ape_pat = value
            End Set
        End Property

        Private _id_perfil_usuario As Integer
        Public Property id_perfil_usuario() As Integer
            Get
                Return _id_perfil_usuario
            End Get
            Set(ByVal value As Integer)
                _id_perfil_usuario = value
            End Set
        End Property

    End Class

End Namespace

