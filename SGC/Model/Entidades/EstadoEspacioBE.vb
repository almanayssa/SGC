Namespace SGC.Model.Entidades
    Public Class EstadoEspacioBE

        Private _id_estado_espacio As String
        Public Property id_estado_espacio() As String
            Get
                Return _id_estado_espacio
            End Get
            Set(ByVal value As String)
                _id_estado_espacio = value
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

    End Class
End Namespace

