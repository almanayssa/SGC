Namespace SGC.Model.Entidades
    Public Class AsistenciaBE

        Private _id_asistencia As Integer
        Public Property id_asistencia() As Integer
            Get
                Return _id_asistencia
            End Get
            Set(ByVal value As Integer)
                _id_asistencia = value
            End Set
        End Property

        Private _id_detalle As Integer
        Public Property id_detalle() As Integer
            Get
                Return _id_detalle
            End Get
            Set(ByVal value As Integer)
                _id_detalle = value
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

        Private _flg_asistencia As Boolean
        Public Property flg_asistencia() As Boolean
            Get
                Return _flg_asistencia
            End Get
            Set(ByVal value As Boolean)
                _flg_asistencia = value
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

    End Class
End Namespace

