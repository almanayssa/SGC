Namespace SGC.Model.Entidades

    Public Class SemaforoBE

        Private _id_tipo As String
        Public Property id_tipo() As String
            Get
                Return _id_tipo
            End Get
            Set(ByVal value As String)
                _id_tipo = value
            End Set
        End Property

        Private _descripcion As String
        Public Property descripcion() As String
            Get
                Return _descripcion
            End Get
            Set(ByVal value As String)
                _descripcion = value
            End Set
        End Property

        Private _anio_mes As String
        Public Property anio_mes() As String
            Get
                Return _anio_mes
            End Get
            Set(ByVal value As String)
                _anio_mes = value
            End Set
        End Property

        Private _participantes1 As Integer
        Public Property participantes1() As Integer
            Get
                Return _participantes1
            End Get
            Set(ByVal value As Integer)
                _participantes1 = value
            End Set
        End Property

        Private _participantes2 As Integer
        Public Property participantes2() As Integer
            Get
                Return _participantes2
            End Get
            Set(ByVal value As Integer)
                _participantes2 = value
            End Set
        End Property

        Private _correlacion As Decimal
        Public Property correlacion() As Decimal
            Get
                Return _correlacion
            End Get
            Set(ByVal value As Decimal)
                _correlacion = value
            End Set
        End Property

        Private _fecha As DateTime
        Public Property fecha() As DateTime
            Get
                Return _fecha
            End Get
            Set(ByVal value As DateTime)
                _fecha = value
            End Set
        End Property

        Private _participantes As Integer
        Public Property participantes() As Integer
            Get
                Return _participantes
            End Get
            Set(ByVal value As Integer)
                _participantes = value
            End Set
        End Property

        Private _correlacion1 As Decimal
        Public Property correlacion1() As Decimal
            Get
                Return _correlacion1
            End Get
            Set(ByVal value As Decimal)
                _correlacion1 = value
            End Set
        End Property

        Private _correlacion2 As Decimal
        Public Property correlacion2() As Decimal
            Get
                Return _correlacion2
            End Get
            Set(ByVal value As Decimal)
                _correlacion2 = value
            End Set
        End Property


    End Class

End Namespace
