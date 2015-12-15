Namespace SGC.Model.Entidades
    Public Class PersonalBE

        Private _id_personal As Integer
        Public Property id_personal() As Integer
            Get
                Return _id_personal
            End Get
            Set(ByVal value As Integer)
                _id_personal = value
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

        Private _ape_pat As String
        Public Property ape_pat() As String
            Get
                Return _ape_pat
            End Get
            Set(ByVal value As String)
                _ape_pat = value
            End Set
        End Property

        Private _ape_mat As String
        Public Property ape_mat() As String
            Get
                Return _ape_mat
            End Get
            Set(ByVal value As String)
                _ape_mat = value
            End Set
        End Property

        Private _id_tipo_personal As Integer
        Public Property id_tipo_personal() As Integer
            Get
                Return _id_tipo_personal
            End Get
            Set(ByVal value As Integer)
                _id_tipo_personal = value
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

        Private _nombre_completo As String
        Public Property nombre_completo() As String
            Get
                Return _nombre_completo
            End Get
            Set(ByVal value As String)
                _nombre_completo = value
            End Set
        End Property

    End Class
End Namespace

