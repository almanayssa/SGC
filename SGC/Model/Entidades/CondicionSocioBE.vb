Namespace SGC.Model.Entidades
    Public Class CondicionSocioBE

        Private _id_condicion As String
        Public Property id_condicion() As String
            Get
                Return _id_condicion
            End Get
            Set(ByVal value As String)
                _id_condicion = value
            End Set
        End Property

        Private _des_cod As String
        Public Property des_cod() As String
            Get
                Return _des_cod
            End Get
            Set(ByVal value As String)
                _des_cod = value
            End Set
        End Property

    End Class
End Namespace

