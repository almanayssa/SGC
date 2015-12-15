Namespace SGC.Model.Entidades
    Public Class RestriccionesBE

        Private _id_restriccion As Integer
        Public Property id_restriccion() As Integer
            Get
                Return _id_restriccion
            End Get
            Set(ByVal value As Integer)
                _id_restriccion = value
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

        Private _flg_condicion As Boolean
        Public Property flg_condicion() As Boolean
            Get
                Return _flg_condicion
            End Get
            Set(ByVal value As Boolean)
                _flg_condicion = value
            End Set
        End Property

        Private _consulta As String
        Public Property consulta() As String
            Get
                Return _consulta
            End Get
            Set(ByVal value As String)
                _consulta = value
            End Set
        End Property

        Private _mensaje As String
        Public Property mensaje() As String
            Get
                Return _mensaje
            End Get
            Set(ByVal value As String)
                _mensaje = value
            End Set
        End Property

        Private _id_signo As Integer
        Public Property id_signo() As Integer
            Get
                Return _id_signo
            End Get
            Set(ByVal value As Integer)
                _id_signo = value
            End Set
        End Property

        Private _valor As String
        Public Property valor() As String
            Get
                Return _valor
            End Get
            Set(ByVal value As String)
                _valor = value
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

        Private _signo As String
        Public Property signo() As String
            Get
                Return _signo
            End Get
            Set(ByVal value As String)
                _signo = value
            End Set
        End Property

    End Class

End Namespace

