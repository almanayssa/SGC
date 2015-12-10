Namespace SGC.Model.Entidades
    Public Class EncuestaActividadBE

        Private _id_encuesta As Integer
        Public Property id_encuesta() As Integer
            Get
                Return _id_encuesta
            End Get
            Set(ByVal value As Integer)
                _id_encuesta = value
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

        Private _id_actividad As Integer
        Public Property id_actividad() As Integer
            Get
                Return _id_actividad
            End Get
            Set(ByVal value As Integer)
                _id_actividad = value
            End Set
        End Property

    End Class
End Namespace

