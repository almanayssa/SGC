Namespace SGC.Model.Entidades
    Public Class ParentescoBE
        Private _id_parentesco As Integer
        Public Property id_parentesco() As Integer
            Get
                Return _id_parentesco
            End Get
            Set(ByVal value As Integer)
                _id_parentesco = value
            End Set
        End Property

        Private _des_par As String
        Public Property des_par() As String
            Get
                Return _des_par
            End Get
            Set(ByVal value As String)
                _des_par = value
            End Set
        End Property

    End Class
End Namespace

