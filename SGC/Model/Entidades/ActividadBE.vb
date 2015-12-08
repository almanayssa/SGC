Namespace SGC.Model.Entidades
    Public Class ActividadBE

        Private _id_actividad As Integer
        Private _nombre As String
        Private _descripcion As String
        Private _id_comite As String
        Private _id_tipo_act As String
        Private _id_cattipo_act As Integer
        Private _fec_ini As Date
        Private _fec_fin As Date
        Private _hora_ini As Date
        Private _hora_fin As Date
        Private _monto_pago As Decimal
        Private _id_estado As String
        Private _id_actividad_recurrente As Integer
        Private _flg_plan_anual As Boolean
        Private _flg_registro As Boolean
        Private _dias_registro As Integer
        Private _flg_web As Boolean
        Private _dias_web As Integer
        Private _tipo_inscripcion As String
        Private _id_plan As Integer

        Public Property id_actividad() As Integer
            Get
                Return _id_actividad

            End Get
            Set(value As Integer)
                _id_actividad = value
            End Set
        End Property

        Public Property nombre() As String
            Get
                Return _nombre

            End Get
            Set(value As String)
                _nombre = value
            End Set
        End Property

        Public Property descripcion() As String
            Get
                Return _descripcion

            End Get
            Set(value As String)
                _descripcion = value
            End Set
        End Property

        Public Property id_comite() As String
            Get
                Return _id_comite

            End Get
            Set(value As String)
                _id_comite = value
            End Set
        End Property

        Public Property id_tipo_act() As String
            Get
                Return _id_tipo_act

            End Get
            Set(value As String)
                _id_tipo_act = value
            End Set
        End Property

        Public Property id_cattipo_act() As String
            Get
                Return _id_cattipo_act

            End Get
            Set(value As String)
                _id_cattipo_act = value
            End Set
        End Property

        Public Property fec_ini() As Date
            Get
                Return _fec_ini

            End Get
            Set(value As Date)
                _fec_ini = value
            End Set
        End Property

        Public Property fec_fin() As Date
            Get
                Return _fec_fin

            End Get
            Set(value As Date)
                _fec_fin = value
            End Set
        End Property

        Public Property hora_ini() As Date
            Get
                Return _hora_ini

            End Get
            Set(value As Date)
                _hora_ini = value
            End Set
        End Property

        Public Property hora_fin() As Date
            Get
                Return _hora_fin

            End Get
            Set(value As Date)
                _hora_fin = value
            End Set
        End Property

        Public Property monto_pago() As Decimal
            Get
                Return _monto_pago

            End Get
            Set(value As Decimal)
                _monto_pago = value
            End Set
        End Property

        Public Property id_estado() As String
            Get
                Return _id_estado

            End Get
            Set(value As String)
                _id_estado = value
            End Set
        End Property

        Public Property id_actividad_recurrente() As Integer
            Get
                Return _id_actividad_recurrente

            End Get
            Set(value As Integer)
                _id_actividad_recurrente = value
            End Set
        End Property

        Public Property flg_plan_anual() As Boolean
            Get
                Return _flg_plan_anual

            End Get
            Set(value As Boolean)
                _flg_plan_anual = value
            End Set
        End Property

        Public Property flg_registro() As Boolean
            Get
                Return _flg_registro

            End Get
            Set(value As Boolean)
                _flg_registro = value
            End Set
        End Property

        Public Property dias_registro() As Integer
            Get
                Return _dias_registro

            End Get
            Set(value As Integer)
                _dias_registro = value
            End Set
        End Property

        Public Property flg_web() As Boolean
            Get
                Return _flg_web

            End Get
            Set(value As Boolean)
                _flg_web = value
            End Set
        End Property

        Public Property dias_web() As Integer
            Get
                Return _dias_web

            End Get
            Set(value As Integer)
                _dias_web = value
            End Set
        End Property

        Public Property tipo_inscripcion() As String
            Get
                Return _tipo_inscripcion

            End Get
            Set(value As String)
                _tipo_inscripcion = value
            End Set
        End Property

        Public Property id_plan() As Integer
            Get
                Return _id_plan

            End Get
            Set(value As Integer)
                _id_plan = value
            End Set
        End Property

    End Class
End Namespace


