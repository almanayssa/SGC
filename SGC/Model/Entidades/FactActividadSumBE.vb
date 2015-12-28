Namespace SGC.Model.Entidades

    Public Class FactActividadSumBE

        Private _id As String
        Public Property id() As String
            Get
                Return _id
            End Get
            Set(ByVal value As String)
                _id = value
            End Set
        End Property

        Private _id_actividad As String
        Public Property id_actividad() As String
            Get
                Return _id_actividad
            End Get
            Set(ByVal value As String)
                _id_actividad = value
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

        Private _id_fecha_ini As String
        Public Property id_fecha_ini() As String
            Get
                Return _id_fecha_ini
            End Get
            Set(ByVal value As String)
                _id_fecha_ini = value
            End Set
        End Property

        Private _id_fecha_fin As String
        Public Property id_fecha_fin() As String
            Get
                Return _id_fecha_fin
            End Get
            Set(ByVal value As String)
                _id_fecha_fin = value
            End Set
        End Property

        Private _total_inscritos As Integer
        Public Property total_inscritos() As Integer
            Get
                Return _total_inscritos
            End Get
            Set(ByVal value As Integer)
                _total_inscritos = value
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

        Private _cant_satisfaccion As Integer
        Public Property cant_satisfaccion() As Integer
            Get
                Return _cant_satisfaccion
            End Get
            Set(ByVal value As Integer)
                _cant_satisfaccion = value
            End Set
        End Property

        Private _cant_nosatisfaccion As Integer
        Public Property cant_nosatisfaccion() As Integer
            Get
                Return _cant_nosatisfaccion
            End Get
            Set(ByVal value As Integer)
                _cant_nosatisfaccion = value
            End Set
        End Property

        Private _cant_nsno As Integer
        Public Property cant_nsno() As Integer
            Get
                Return _cant_nsno
            End Get
            Set(ByVal value As Integer)
                _cant_nsno = value
            End Set
        End Property

        Private _cant_encuestados As Integer
        Public Property cant_encuestados() As Integer
            Get
                Return _cant_encuestados
            End Get
            Set(ByVal value As Integer)
                _cant_encuestados = value
            End Set
        End Property

        Private _total_ninios_ins As Integer
        Public Property total_ninios_ins() As Integer
            Get
                Return _total_ninios_ins
            End Get
            Set(ByVal value As Integer)
                _total_ninios_ins = value
            End Set
        End Property

        Private _total_mujeres_ins As Integer
        Public Property total_mujeres_ins() As Integer
            Get
                Return _total_mujeres_ins
            End Get
            Set(ByVal value As Integer)
                _total_mujeres_ins = value
            End Set
        End Property

        Private _total_varones_ins As Integer
        Public Property total_varones_ins() As Integer
            Get
                Return _total_varones_ins
            End Get
            Set(ByVal value As Integer)
                _total_varones_ins = value
            End Set
        End Property

        Private _total_ninios_part As Integer
        Public Property total_ninios_part() As Integer
            Get
                Return _total_ninios_part
            End Get
            Set(ByVal value As Integer)
                _total_ninios_part = value
            End Set
        End Property

        Private _total_mujeres_part As Integer
        Public Property total_mujeres_part() As Integer
            Get
                Return _total_mujeres_part
            End Get
            Set(ByVal value As Integer)
                _total_mujeres_part = value
            End Set
        End Property

        Private _total_varones_part As Integer
        Public Property total_varones_part() As Integer
            Get
                Return _total_varones_part
            End Get
            Set(ByVal value As Integer)
                _total_varones_part = value
            End Set
        End Property

        Public Property total_actividades As Integer
        Public Property ins_x_actividad As Integer
        Public Property tipo_actividad As String
        Public Property comite As String
        Public Property satisfaccion As Decimal

    End Class

End Namespace