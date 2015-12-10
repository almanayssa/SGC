Namespace SGC.Model.Entidades
    Public Class PersonalXActividadBE

        Private _id_actividad As Integer
        Public Property id_actividad() As Integer
            Get
                Return _id_actividad
            End Get
            Set(ByVal value As Integer)
                _id_actividad = value
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

    End Class
End Namespace

