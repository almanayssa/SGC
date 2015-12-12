Namespace SGC.Model.Entidades
    Public Class ActividadRecurrenteBE

        Private _id_actividad_recurrente As Integer
        Public Property id_actividad_recurrente() As Integer
            Get
                Return _id_actividad_recurrente
            End Get
            Set(ByVal value As Integer)
                _id_actividad_recurrente = value
            End Set
        End Property

        Private _tipo As String
        Public Property tipo() As String
            Get
                Return _tipo
            End Get
            Set(ByVal value As String)
                _tipo = value
            End Set
        End Property

        Private _num_rep As Integer?
        Public Property num_rep() As Integer?
            Get
                Return _num_rep
            End Get
            Set(ByVal value As Integer?)
                _num_rep = value
            End Set
        End Property

        Private _chk_dom As Boolean?
        Public Property chk_dom() As Boolean?
            Get
                Return _chk_dom
            End Get
            Set(ByVal value As Boolean?)
                _chk_dom = value
            End Set
        End Property

        Private _chk_lun As Boolean?
        Public Property chk_lun() As Boolean?
            Get
                Return _chk_lun
            End Get
            Set(ByVal value As Boolean?)
                _chk_lun = value
            End Set
        End Property

        Private _chk_mar As Boolean?
        Public Property chk_mar() As Boolean?
            Get
                Return _chk_mar
            End Get
            Set(ByVal value As Boolean?)
                _chk_mar = value
            End Set
        End Property

        Private _chk_mie As Boolean?
        Public Property chk_mie() As Boolean?
            Get
                Return _chk_mie
            End Get
            Set(ByVal value As Boolean?)
                _chk_mie = value
            End Set
        End Property

        Private _chk_jue As Boolean?
        Public Property chk_jue() As Boolean?
            Get
                Return _chk_jue
            End Get
            Set(ByVal value As Boolean?)
                _chk_jue = value
            End Set
        End Property

        Private _chk_vie As Boolean?
        Public Property chk_vie() As Boolean?
            Get
                Return _chk_vie
            End Get
            Set(ByVal value As Boolean?)
                _chk_vie = value
            End Set
        End Property

        Private _chk_sab As Boolean?
        Public Property chk_sab() As Boolean?
            Get
                Return _chk_sab
            End Get
            Set(ByVal value As Boolean?)
                _chk_sab = value
            End Set
        End Property

        Private _dia_mes As Integer?
        Public Property dia_mes() As Integer?
            Get
                Return _dia_mes
            End Get
            Set(ByVal value As Integer?)
                _dia_mes = value
            End Set
        End Property

        Private _ordinal As Integer?
        Public Property ordinal() As Integer?
            Get
                Return _ordinal
            End Get
            Set(ByVal value As Integer?)
                _ordinal = value
            End Set
        End Property

        Private _dia_semana As Integer?
        Public Property dia_semana() As Integer?
            Get
                Return _dia_semana
            End Get
            Set(ByVal value As Integer?)
                _dia_semana = value
            End Set
        End Property

        Private _fecha_ini As DateTime?
        Public Property fecha_ini() As DateTime?
            Get
                Return _fecha_ini
            End Get
            Set(ByVal value As DateTime?)
                _fecha_ini = value
            End Set
        End Property

        Private _fecha_fin As DateTime?
        Public Property fecha_fin() As DateTime?
            Get
                Return _fecha_fin
            End Get
            Set(ByVal value As DateTime?)
                _fecha_fin = value
            End Set
        End Property

        Private _id_espacio As Integer?
        Public Property id_espacio() As Integer?
            Get
                Return _id_espacio
            End Get
            Set(ByVal value As Integer?)
                _id_espacio = value
            End Set
        End Property

        Private _vacantes As Integer?
        Public Property vacantes() As Integer?
            Get
                Return _vacantes
            End Get
            Set(ByVal value As Integer?)
                _vacantes = value
            End Set
        End Property

        Private _hora_ini As DateTime?
        Public Property hora_ini() As DateTime?
            Get
                Return _hora_ini
            End Get
            Set(ByVal value As DateTime?)
                _hora_ini = value
            End Set
        End Property

        Private _hora_fin As DateTime?
        Public Property hora_fin() As DateTime?
            Get
                Return _hora_fin
            End Get
            Set(ByVal value As DateTime?)
                _hora_fin = value
            End Set
        End Property

        Private _Actividad As ActividadBE
        Public Property Actividad() As ActividadBE
            Get
                Return _Actividad
            End Get
            Set(ByVal value As ActividadBE)
                _Actividad = value
            End Set
        End Property

    End Class
End Namespace

