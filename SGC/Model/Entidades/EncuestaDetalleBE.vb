Namespace SGC.Model.Entidades
    Public Class EncuestaDetalleBE

        Private _id_detalle As Integer
        Public Property id_detalle() As Integer
            Get
                Return _id_detalle
            End Get
            Set(ByVal value As Integer)
                _id_detalle = value
            End Set
        End Property

        Private _id_encuesta As Integer
        Public Property id_encuesta() As Integer
            Get
                Return _id_encuesta
            End Get
            Set(ByVal value As Integer)
                _id_encuesta = value
            End Set
        End Property

        Private _pregunta As String
        Public Property pregunta() As String
            Get
                Return _pregunta
            End Get
            Set(ByVal value As String)
                _pregunta = value
            End Set
        End Property

        Private _flg_marcar As Boolean
        Public Property flg_marcar() As Boolean
            Get
                Return _flg_marcar
            End Get
            Set(ByVal value As Boolean)
                _flg_marcar = value
            End Set
        End Property

        Private _opcion1 As Integer?
        Public Property opcion1() As Integer?
            Get
                Return _opcion1
            End Get
            Set(ByVal value As Integer?)
                _opcion1 = value
            End Set
        End Property

        Private _opcion2 As Integer?
        Public Property opcion2() As Integer?
            Get
                Return _opcion2
            End Get
            Set(ByVal value As Integer?)
                _opcion2 = value
            End Set
        End Property

        Private _opcion3 As Integer?
        Public Property opcion3() As Integer?
            Get
                Return _opcion3
            End Get
            Set(ByVal value As Integer?)
                _opcion3 = value
            End Set
        End Property

    End Class
End Namespace

