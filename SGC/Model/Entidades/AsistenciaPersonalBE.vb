Namespace SGC.Model.Entidades
    Public Class AsistenciaPersonalBE

        Private _id_asistencia As Integer
        Public Property id_asistencia() As Integer
            Get
                Return _id_asistencia
            End Get
            Set(ByVal value As Integer)
                _id_asistencia = value
            End Set
        End Property

        Private _id_personal As Integer
        Public Property id_personal() As Integer
            Get
                Return _id_personal
            End Get
            Set(ByVal value As Integer)
                _id_personal = value
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

        Private _nombre_completo As String
        Public Property nombre_completo() As String
            Get
                Return _nombre_completo
            End Get
            Set(ByVal value As String)
                _nombre_completo = value
            End Set
        End Property

    End Class
End Namespace

