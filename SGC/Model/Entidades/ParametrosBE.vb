Namespace SGC.Model.Entidades
    Public Class ParametrosBE
        Private _id_parametro As Integer
        Public Property id_parametro() As Integer
            Get
                Return _id_parametro
            End Get
            Set(ByVal value As Integer)
                _id_parametro = value
            End Set
        End Property

        Private _des_param As String
        Public Property des_param() As String
            Get
                Return _des_param
            End Get
            Set(ByVal value As String)
                _des_param = value
            End Set
        End Property

        Private _val_param As String
        Public Property val_param() As String
            Get
                Return _val_param
            End Get
            Set(ByVal value As String)
                _val_param = value
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

    End Class
End Namespace

