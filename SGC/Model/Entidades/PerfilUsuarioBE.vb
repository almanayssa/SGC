Namespace SGC.Model.Entidades

    Public Class PerfilUsuarioBE

        Private _id_perfil_usuario As Integer
        Public Property id_perfil_usuario() As Integer
            Get
                Return _id_perfil_usuario
            End Get
            Set(ByVal value As Integer)
                _id_perfil_usuario = value
            End Set
        End Property

        Private _nombre As String
        Public Property nombre() As String
            Get
                Return _nombre
            End Get
            Set(ByVal value As String)
                _nombre = value
            End Set
        End Property

        Private _ListaOpciones As List(Of PantallaBE)
        Public Property ListaOpciones() As List(Of PantallaBE)
            Get
                Return _ListaOpciones
            End Get
            Set(ByVal value As List(Of PantallaBE))
                _ListaOpciones = value
            End Set
        End Property

    End Class

End Namespace

