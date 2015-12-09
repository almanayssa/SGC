Namespace SGC.Model.Entidades
    Public Class ActividadRestriccionesBE

        Private _id_restriccion As Integer
        Public Property id_restriccion() As Integer
            Get
                Return _id_restriccion
            End Get
            Set(ByVal value As Integer)
                _id_restriccion = value
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

    End Class
End Namespace

