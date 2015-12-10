Namespace SGS.Model.Entidades
    Public Class IncidenciaBE

        Private _id_incidencia As String
        Public Property id_incidencia() As String
            Get
                Return _id_incidencia
            End Get
            Set(ByVal value As String)
                _id_incidencia = value
            End Set
        End Property

        Private _id_actividad_detalle As Integer
        Public Property id_actividad_detalle() As Integer
            Get
                Return _id_actividad_detalle
            End Get
            Set(ByVal value As Integer)
                _id_actividad_detalle = value
            End Set
        End Property

        Private _incidencia As String
        Public Property incidencia() As String
            Get
                Return _incidencia
            End Get
            Set(ByVal value As String)
                _incidencia = value
            End Set
        End Property

    End Class
End Namespace

