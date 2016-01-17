Namespace SGC.Model.Entidades

    Public Class FactPersonalBE

        Private _id As Integer
        Public Property id() As Integer
            Get
                Return _id
            End Get
            Set(ByVal value As Integer)
                _id = value
            End Set
        End Property

        Private _id_actividad As Integer
        Public Property id_actividad() As Integer
            Get
                Return _id_actividad
            End Get
            Set(ByVal value As Integer)
                _id_actividad = value
            End Set
        End Property

        Private _id_personal As Integer
        Public Property id_personal() As Integer
            Get
                Return _id_personal
            End Get
            Set(ByVal value As Integer)
                _id_personal = value
            End Set
        End Property

        Private _id_tipo As String
        Public Property id_tipo() As String
            Get
                Return _id_tipo
            End Get
            Set(ByVal value As String)
                _id_tipo = value
            End Set
        End Property

        Private _id_comite As String
        Public Property id_comite() As String
            Get
                Return _id_comite
            End Get
            Set(ByVal value As String)
                _id_comite = value
            End Set
        End Property

        Private _nombre_personal As String
        Public Property nombre_personal() As String
            Get
                Return _nombre_personal
            End Get
            Set(ByVal value As String)
                _nombre_personal = value
            End Set
        End Property

        Private _cant_actividades As Integer
        Public Property cant_actividades() As Integer
            Get
                Return _cant_actividades
            End Get
            Set(ByVal value As Integer)
                _cant_actividades = value
            End Set
        End Property

    End Class

End Namespace

