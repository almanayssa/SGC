Namespace SGC.Model.Entidades
    Public Class InscripcionDetalleBE

        Private _id_detalle As Integer
        Public Property id_detalle() As Integer
            Get
                Return _id_detalle
            End Get
            Set(ByVal value As Integer)
                _id_detalle = value
            End Set
        End Property

        Private _id_inscripcion As Integer
        Public Property id_inscripcion() As Integer
            Get
                Return _id_inscripcion
            End Get
            Set(ByVal value As Integer)
                _id_inscripcion = value
            End Set
        End Property

        Private _id_entidad As String
        Public Property id_entidad() As String
            Get
                Return _id_entidad
            End Get
            Set(ByVal value As String)
                _id_entidad = value
            End Set
        End Property

        Private _relacion As String
        Public Property relacion() As String
            Get
                Return _relacion
            End Get
            Set(ByVal value As String)
                _relacion = value
            End Set
        End Property

        Private _entidad As String
        Public Property entidad() As String
            Get
                Return _entidad
            End Get
            Set(ByVal value As String)
                _entidad = value
            End Set
        End Property

    End Class
End Namespace

