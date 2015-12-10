Namespace SGC.Model.Entidades
    Public Class EstadoDocBE

        Private _id_est_doc As String
        Public Property id_est_doc() As String
            Get
                Return _id_est_doc
            End Get
            Set(ByVal value As String)
                _id_est_doc = value
            End Set
        End Property

        Private _des_est As String
        Public Property des_est() As String
            Get
                Return _des_est
            End Get
            Set(ByVal value As String)
                _des_est = value
            End Set
        End Property

    End Class
End Namespace

