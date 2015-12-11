Namespace SGC.Model.Entidades
    Public Class PlanAnualBE

        Private _id_plan As Integer
        Public Property id_plan() As Integer
            Get
                Return _id_plan
            End Get
            Set(ByVal value As Integer)
                _id_plan = value
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

        Private _fec_lim_pres As DateTime
        Public Property fec_lim_pres() As DateTime
            Get
                Return _fec_lim_pres
            End Get
            Set(ByVal value As DateTime)
                _fec_lim_pres = value
            End Set
        End Property

        Private _anio As String
        Public Property anio() As String
            Get
                Return _anio
            End Get
            Set(ByVal value As String)
                _anio = value
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


        Public Property comite As String

    End Class

End Namespace

