Namespace SGC.Model.Entidades
    Public Class RecursoXActividadBE

        Private _id_actividad As Integer
        Public Property id_actividad() As Integer
            Get
                Return _id_actividad
            End Get
            Set(ByVal value As Integer)
                _id_actividad = value
            End Set
        End Property

        Private _id_recurso As Integer
        Public Property id_recurso() As Integer
            Get
                Return _id_recurso
            End Get
            Set(ByVal value As Integer)
                _id_recurso = value
            End Set
        End Property

        Private _cantidad As Integer
        Public Property cantidad() As Integer
            Get
                Return _cantidad
            End Get
            Set(ByVal value As Integer)
                _cantidad = value
            End Set
        End Property

        Private _cantidad_real As Integer
        Public Property cantidad_real() As Integer
            Get
                Return _cantidad_real
            End Get
            Set(ByVal value As Integer)
                _cantidad_real = value
            End Set
        End Property

        Private _flg_planificado As Boolean
        Public Property flg_planificado() As Boolean
            Get
                Return _flg_planificado
            End Get
            Set(ByVal value As Boolean)
                _flg_planificado = value
            End Set
        End Property

    End Class
End Namespace

