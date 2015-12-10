Namespace SGC.Model.Entidades
    Public Class SedeBE

        Private _id_sede As String
        Public Property id_sede() As String
            Get
                Return _id_sede
            End Get
            Set(ByVal value As String)
                _id_sede = value
            End Set
        End Property

        Private _des_sede As String
        Public Property des_sede() As String
            Get
                Return _des_sede
            End Get
            Set(ByVal value As String)
                _des_sede = value
            End Set
        End Property

    End Class
End Namespace

