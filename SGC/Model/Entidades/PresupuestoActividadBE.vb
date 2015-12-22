Namespace SGC.Model.Entidades
    Public Class PresupuestoActividadBE

        Private _id_presupuesto_actividad As Integer
        Public Property id_presupuesto_actividad() As Integer
            Get
                Return _id_presupuesto_actividad
            End Get
            Set(ByVal value As Integer)
                _id_presupuesto_actividad = value
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

        Private _monto As Decimal
        Public Property monto() As Decimal
            Get
                Return _monto
            End Get
            Set(ByVal value As Decimal)
                _monto = value
            End Set
        End Property

        Private _ListadoDetallePresupuesto As List(Of DetallePresupuestoActBE)
        Public Property ListadoDetallePresupuesto() As List(Of DetallePresupuestoActBE)
            Get
                Return _ListadoDetallePresupuesto
            End Get
            Set(ByVal value As List(Of DetallePresupuestoActBE))
                _ListadoDetallePresupuesto = value
            End Set
        End Property

    End Class
End Namespace

