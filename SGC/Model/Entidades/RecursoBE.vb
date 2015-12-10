Namespace SGC.Model.Entidades
    Public Class RecursoBE

        Private _id_recurso As Integer
        Public Property id_recurso() As Integer
            Get
                Return _id_recurso
            End Get
            Set(ByVal value As Integer)
                _id_recurso = value
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

        Private _costo As Decimal
        Public Property costo() As Decimal
            Get
                Return _costo
            End Get
            Set(ByVal value As Decimal)
                _costo = value
            End Set
        End Property


    End Class
End Namespace

