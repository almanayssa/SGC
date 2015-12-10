Namespace SGC.Model.Entidades
    Public Class ComiteAnualBE

        Private _id As Integer

        Public Property id() As Integer
            Get
                Return _id
            End Get
            Set(ByVal value As Integer)
                _id = value
            End Set
        End Property

        Private _id_socio As String
        Public Property id_socio() As String
            Get
                Return _id_socio
            End Get
            Set(ByVal value As String)
                _id_socio = value
            End Set
        End Property

        Private _anio As String
        Public Property anio() As String
            Get
                Return _anio
            End Get
            Set(ByVal value As String)
                _anio = value
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

        Private _id_cargo As Integer
        Public Property id_cargo() As Integer
            Get
                Return _id_cargo
            End Get
            Set(ByVal value As Integer)
                _id_cargo = value
            End Set
        End Property
    End Class
End Namespace

