Namespace SGC.Model.Entidades

    Public Class FactParticipanteBE

        Private _id As Integer
        Public Property id() As Integer
            Get
                Return _id
            End Get
            Set(ByVal value As Integer)
                _id = value
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

        Private _id_persona As String
        Public Property id_persona() As String
            Get
                Return _id_persona
            End Get
            Set(ByVal value As String)
                _id_persona = value
            End Set
        End Property

        Private _id_tipo As String
        Public Property id_tipo() As String
            Get
                Return _id_tipo
            End Get
            Set(ByVal value As String)
                _id_tipo = value
            End Set
        End Property

        Private _id_comite As String
        Public Property id_comite() As String
            Get
                Return _id_comite
            End Get
            Set(ByVal value As String)
                _id_comite = value
            End Set
        End Property

        Private _nombre_persona As String
        Public Property nombre_persona() As String
            Get
                Return _nombre_persona
            End Get
            Set(ByVal value As String)
                _nombre_persona = value
            End Set
        End Property

        Private _cant_actividades As Integer
        Public Property cant_actividades() As Integer
            Get
                Return _cant_actividades
            End Get
            Set(ByVal value As Integer)
                _cant_actividades = value
            End Set
        End Property

        Private _anio_mes As String
        Public Property anio_mes() As String
            Get
                Return _anio_mes
            End Get
            Set(ByVal value As String)
                _anio_mes = value
            End Set
        End Property

        Private _total_participantes As Integer
        Public Property total_participantes() As Integer
            Get
                Return _total_participantes
            End Get
            Set(ByVal value As Integer)
                _total_participantes = value
            End Set
        End Property

        Private _participantes_constantes As Integer
        Public Property participantes_constantes() As Integer
            Get
                Return _participantes_constantes
            End Get
            Set(ByVal value As Integer)
                _participantes_constantes = value
            End Set
        End Property

        Private _participantes_nuevos As Integer
        Public Property participantes_nuevos() As Integer
            Get
                Return _participantes_nuevos
            End Get
            Set(ByVal value As Integer)
                _participantes_nuevos = value
            End Set
        End Property

        Private _participantes_retirados As Integer
        Public Property participantes_retirados() As Integer
            Get
                Return _participantes_retirados
            End Get
            Set(ByVal value As Integer)
                _participantes_retirados = value
            End Set
        End Property

    End Class

End Namespace


