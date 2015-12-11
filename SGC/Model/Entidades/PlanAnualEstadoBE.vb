Namespace SGC.Model.Entidades
    Public Class PlanAnualEstadoBE

        Private _id_estado As String
        Public Property id_estado() As String
            Get
                Return _id_estado
            End Get
            Set(ByVal value As String)
                _id_estado = value
            End Set
        End Property

        Private _desc_estado As String
        Public Property desc_estado() As String
            Get
                Return _desc_estado
            End Get
            Set(ByVal value As String)
                _desc_estado = value
            End Set
        End Property

    End Class
End Namespace

