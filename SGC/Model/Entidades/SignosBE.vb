Namespace SGC.Model.Entidades
    Public Class SignosBE

        Private _id_signo As Integer
        Public Property id_signo() As Integer
            Get
                Return _id_signo
            End Get
            Set(ByVal value As Integer)
                _id_signo = value
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

        Private _des_signo As String
        Public Property des_signo() As String
            Get
                Return _des_signo
            End Get
            Set(ByVal value As String)
                _des_signo = value
            End Set
        End Property

    End Class
End Namespace

