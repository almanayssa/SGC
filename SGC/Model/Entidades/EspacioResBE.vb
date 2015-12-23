Namespace SGC.Model.Entidades
    Public Class EspacioResBE

        Private _id_res As Integer
        Public Property id_res() As Integer
            Get
                Return _id_res
            End Get
            Set(ByVal value As Integer)
                _id_res = value
            End Set
        End Property

        Private _fec_ini As DateTime
        Public Property fec_ini() As DateTime
            Get
                Return _fec_ini
            End Get
            Set(ByVal value As DateTime)
                _fec_ini = value
            End Set
        End Property

        Private _fec_fin As DateTime
        Public Property fec_fin() As DateTime
            Get
                Return _fec_fin
            End Get
            Set(ByVal value As DateTime)
                _fec_fin = value
            End Set
        End Property

        Private _id_estado_espacio As String
        Public Property id_estado_espacio() As String
            Get
                Return _id_estado_espacio
            End Get
            Set(ByVal value As String)
                _id_estado_espacio = value
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

        Private _id_espacio As Integer
        Public Property id_espacio() As Integer
            Get
                Return _id_espacio
            End Get
            Set(ByVal value As Integer)
                _id_espacio = value
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

        Private _hora_inicio As String
        Public Property hora_inicio() As String
            Get
                Return _hora_inicio
            End Get
            Set(ByVal value As String)
                _hora_inicio = value
            End Set
        End Property

        Private _hora_fin As String
        Public Property hora_fin() As String
            Get
                Return _hora_fin
            End Get
            Set(ByVal value As String)
                _hora_fin = value
            End Set
        End Property

        Private _estado As String
        Public Property estado() As String
            Get
                Return _estado
            End Get
            Set(ByVal value As String)
                _estado = value
            End Set
        End Property

        Private _nombre_comite As String
        Public Property nombre_comite() As String
            Get
                Return _nombre_comite
            End Get
            Set(ByVal value As String)
                _nombre_comite = value
            End Set
        End Property

        Private _id_sede As String
        Public Property id_sede() As String
            Get
                Return _id_sede
            End Get
            Set(ByVal value As String)
                _id_sede = value
            End Set
        End Property

        Private _des_sede As String
        Public Property des_sede() As String
            Get
                Return _des_sede
            End Get
            Set(ByVal value As String)
                _des_sede = value
            End Set
        End Property

        Private _nombre_espacio As String
        Public Property nombre_espacio() As String
            Get
                Return _nombre_espacio
            End Get
            Set(ByVal value As String)
                _nombre_espacio = value
            End Set
        End Property

    End Class
End Namespace

