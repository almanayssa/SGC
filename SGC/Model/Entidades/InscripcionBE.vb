Namespace SGC.Model.Entidades
    Public Class InscripcionBE

        Private _id_inscripcion As Integer
        Public Property id_inscripcion() As Integer
            Get
                Return _id_inscripcion
            End Get
            Set(ByVal value As Integer)
                _id_inscripcion = value
            End Set
        End Property

        Private _id_socio As String
        Public Property id_socio() As String
            Get
                Return _id_socio
            End Get
            Set(ByVal value As String)
                _id_socio = value
            End Set
        End Property

        Private _fecha_registro As DateTime
        Public Property fecha_registro() As DateTime
            Get
                Return _fecha_registro
            End Get
            Set(ByVal value As DateTime)
                _fecha_registro = value
            End Set
        End Property

        Private _serie As String
        Public Property serie() As String
            Get
                Return _serie
            End Get
            Set(ByVal value As String)
                _serie = value
            End Set
        End Property

        Private _correlativo As String
        Public Property correlativo() As String
            Get
                Return _correlativo
            End Get
            Set(ByVal value As String)
                _correlativo = value
            End Set
        End Property

        Private _tipo_doc As String
        Public Property tipo_doc() As String
            Get
                Return _tipo_doc
            End Get
            Set(ByVal value As String)
                _tipo_doc = value
            End Set
        End Property

        Private _flg_web As Boolean
        Public Property flg_web() As Boolean
            Get
                Return _flg_web
            End Get
            Set(ByVal value As Boolean)
                _flg_web = value
            End Set
        End Property

        Private _flg_anulado As String
        Public Property flg_anulado() As String
            Get
                Return _flg_anulado
            End Get
            Set(ByVal value As String)
                _flg_anulado = value
            End Set
        End Property

        Private _fecha_anulacion As DateTime
        Public Property fecha_anulacion() As DateTime
            Get
                Return _fecha_anulacion
            End Get
            Set(ByVal value As DateTime)
                _fecha_anulacion = value
            End Set
        End Property

        Private _monto As Decimal
        Public Property monto() As Decimal
            Get
                Return _monto
            End Get
            Set(ByVal value As Decimal)
                _monto = value
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

        Private _fecha_recurrente As DateTime
        Public Property fecha_recurrente() As DateTime
            Get
                Return _fecha_recurrente
            End Get
            Set(ByVal value As DateTime)
                _fecha_recurrente = value
            End Set
        End Property

        Private _flg_bosque As Boolean
        Public Property flg_bosque() As Boolean
            Get
                Return _flg_bosque
            End Get
            Set(ByVal value As Boolean)
                _flg_bosque = value
            End Set
        End Property

        Private _ListaPersona As List(Of PersonaBE)
        Public Property ListaPersona() As List(Of PersonaBE)
            Get
                Return _ListaPersona
            End Get
            Set(ByVal value As List(Of PersonaBE))
                _ListaPersona = value
            End Set
        End Property

        Private _ListaInvitado As List(Of InvitadoBE)
        Public Property ListaInvitado() As List(Of InvitadoBE)
            Get
                Return _ListaInvitado
            End Get
            Set(ByVal value As List(Of InvitadoBE))
                _ListaInvitado = value
            End Set
        End Property

        Private _nombre_actividad As String
        Public Property nombre_actividad() As String
            Get
                Return _nombre_actividad
            End Get
            Set(ByVal value As String)
                _nombre_actividad = value
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

        Private _tipo_actividad As String
        Public Property tipo_actividad() As String
            Get
                Return _tipo_actividad
            End Get
            Set(ByVal value As String)
                _tipo_actividad = value
            End Set
        End Property


    End Class
End Namespace

