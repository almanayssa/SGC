Namespace SGC.Model.Entidades
    Public Class EspacioBE

        Private _id_espacio As Integer
        Public Property id_espacio() As Integer
            Get
                Return _id_espacio
            End Get
            Set(ByVal value As Integer)
                _id_espacio = value
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

        Private _direccion As String
        Public Property direccion() As String
            Get
                Return _direccion
            End Get
            Set(ByVal value As String)
                _direccion = value
            End Set
        End Property

        Private _id_lugar As Integer?
        Public Property id_lugar() As Integer?
            Get
                Return _id_lugar
            End Get
            Set(ByVal value As Integer?)
                _id_lugar = value
            End Set
        End Property

        Private _id_estado_espacio As String
        Public Property id_estado_espacio() As String
            Get
                Return _id_estado_espacio
            End Get
            Set(ByVal value As String)
                _id_estado_espacio = value
            End Set
        End Property

        Private _id_sede As String
        Public Property id_sede() As String
            Get
                Return _id_sede
            End Get
            Set(ByVal value As String)
                _id_sede = value
            End Set
        End Property

    End Class
End Namespace

