Namespace SGC.Model.Entidades
    Public Class SeguimientoEvaluacionPlanBE

        Private _id_seguimiento As Integer
        Public Property id_seguimiento() As Integer
            Get
                Return _id_seguimiento
            End Get
            Set(ByVal value As Integer)
                _id_seguimiento = value
            End Set
        End Property

        Private _id_area As Integer
        Public Property id_area() As Integer
            Get
                Return _id_area
            End Get
            Set(ByVal value As Integer)
                _id_area = value
            End Set
        End Property

        Private _fecha As DateTime
        Public Property fecha() As DateTime
            Get
                Return _fecha
            End Get
            Set(ByVal value As DateTime)
                _fecha = value
            End Set
        End Property

        Private _id_usuario As String
        Public Property id_usuario() As String
            Get
                Return _id_usuario
            End Get
            Set(ByVal value As String)
                _id_usuario = value
            End Set
        End Property

        Private _id_plan As Integer
        Public Property id_plan() As Integer
            Get
                Return _id_plan
            End Get
            Set(ByVal value As Integer)
                _id_plan = value
            End Set
        End Property

        Private _observacion As String
        Public Property observacion() As String
            Get
                Return _observacion
            End Get
            Set(ByVal value As String)
                _observacion = value
            End Set
        End Property

        Private _id_estado As String
        Public Property id_estado() As String
            Get
                Return _id_estado
            End Get
            Set(ByVal value As String)
                _id_estado = value
            End Set
        End Property


    End Class
End Namespace

