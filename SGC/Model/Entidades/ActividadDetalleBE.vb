Namespace SGC.Model.Entidades
    Public Class ActividadDetalleBE

        Private _id_actividad_detalle As Integer
        Public Property id_actividad_detalle() As Integer
            Get
                Return _id_actividad_detalle
            End Get
            Set(ByVal value As Integer)
                _id_actividad_detalle = value
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

        Private _fecha_ini As DateTime
        Public Property fecha_ini() As DateTime
            Get
                Return _fecha_ini
            End Get
            Set(ByVal value As DateTime)
                _fecha_ini = value
            End Set
        End Property

        Private _hora_ini As DateTime
        Public Property hora_ini() As DateTime
            Get
                Return _hora_ini
            End Get
            Set(ByVal value As DateTime)
                _hora_ini = value
            End Set
        End Property

        Private _fecha_fin As DateTime
        Public Property fecha_fin() As DateTime
            Get
                Return _fecha_fin
            End Get
            Set(ByVal value As DateTime)
                _fecha_fin = value
            End Set
        End Property

        Private _hora_fin As DateTime
        Public Property hora_fin() As DateTime
            Get
                Return _hora_fin
            End Get
            Set(ByVal value As DateTime)
                _hora_fin = value
            End Set
        End Property

        Private _id_sede As Integer
        Public Property id_sede() As Integer
            Get
                Return _id_sede
            End Get
            Set(ByVal value As Integer)
                _id_sede = value
            End Set
        End Property

        Private _id_espacio As Integer
        Public Property id_espacio() As Integer
            Get
                Return _id_espacio
            End Get
            Set(ByVal value As Integer)
                _id_espacio = value
            End Set
        End Property

        Private _vacantes As Integer
        Public Property vacantes() As Integer
            Get
                Return _vacantes
            End Get
            Set(ByVal value As Integer)
                _vacantes = value
            End Set
        End Property

    End Class
End Namespace

