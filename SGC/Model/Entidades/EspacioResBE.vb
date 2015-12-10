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

    End Class
End Namespace

