Namespace SGC.Model.Entidades
    Public Class ActividadBE

        Private _id_actividad As Integer
        Public Property id_actividad() As Integer
            Get
                Return _id_actividad
            End Get
            Set(ByVal value As Integer)
                _id_actividad = value
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

        Private _hora_ini As TimeSpan
        Public Property hora_ini() As TimeSpan
            Get
                Return _hora_ini
            End Get
            Set(ByVal value As TimeSpan)
                _hora_ini = value
            End Set
        End Property

        Private _hora_fin As TimeSpan
        Public Property hora_fin() As TimeSpan
            Get
                Return _hora_fin
            End Get
            Set(ByVal value As TimeSpan)
                _hora_fin = value
            End Set
        End Property

        Private _monto_pago As Decimal
        Public Property monto_pago() As Decimal
            Get
                Return _monto_pago
            End Get
            Set(ByVal value As Decimal)
                _monto_pago = value
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

        Private _id_cattipo_act As Integer?
        Public Property id_cattipo_act() As Integer?
            Get
                Return _id_cattipo_act
            End Get
            Set(ByVal value As Integer?)
                _id_cattipo_act = value
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

        Private _id_tipo_act As String
        Public Property id_tipo_act() As String
            Get
                Return _id_tipo_act
            End Get
            Set(ByVal value As String)
                _id_tipo_act = value
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

        Private _nombre As String
        Public Property nombre() As String
            Get
                Return _nombre
            End Get
            Set(ByVal value As String)
                _nombre = value
            End Set
        End Property

        Private _id_actividad_recurrente As Integer
        Public Property id_actividad_recurrente() As Integer
            Get
                Return _id_actividad_recurrente
            End Get
            Set(ByVal value As Integer)
                _id_actividad_recurrente = value
            End Set
        End Property

        Private _flg_plan_anual As Boolean
        Public Property flg_plan_anual() As Boolean
            Get
                Return _flg_plan_anual
            End Get
            Set(ByVal value As Boolean)
                _flg_plan_anual = value
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

        Private _tipo_inscripcion As String
        Public Property tipo_inscripcion() As String
            Get
                Return _tipo_inscripcion
            End Get
            Set(ByVal value As String)
                _tipo_inscripcion = value
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

        Private _vacantes As Integer
        Public Property vacantes() As Integer
            Get
                Return _vacantes
            End Get
            Set(ByVal value As Integer)
                _vacantes = value
            End Set
        End Property

        Private _ListaTipoPersonal As List(Of TipoPersonalBE)
        Public Property ListaTipoPersonal() As List(Of TipoPersonalBE)
            Get
                Return _ListaTipoPersonal
            End Get
            Set(ByVal value As List(Of TipoPersonalBE))
                _ListaTipoPersonal = value
            End Set
        End Property

        Private _ListaRecursos As List(Of RecursoBE)
        Public Property ListaRecursos() As List(Of RecursoBE)
            Get
                Return _ListaRecursos
            End Get
            Set(ByVal value As List(Of RecursoBE))
                _ListaRecursos = value
            End Set
        End Property

        Private _ListaRestricciones As List(Of RestriccionesBE)
        Public Property ListaRestricciones() As List(Of RestriccionesBE)
            Get
                Return _ListaRestricciones
            End Get
            Set(ByVal value As List(Of RestriccionesBE))
                _ListaRestricciones = value
            End Set
        End Property

        Private _nombrecomite As String
        Public Property nombrecomite() As String
            Get
                Return _nombrecomite
            End Get
            Set(ByVal value As String)
                _nombrecomite = value
            End Set
        End Property

    End Class
End Namespace


