﻿Namespace SGC.Model.Entidades
    Public Class PresupuestoAnualBE

        Private _id_presupuesto_anual As Integer
        Public Property id_presupuesto_anual() As Integer
            Get
                Return _id_presupuesto_anual
            End Get
            Set(ByVal value As Integer)
                _id_presupuesto_anual = value
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

        Private _id_plan As Integer
        Public Property id_plan() As Integer
            Get
                Return _id_plan
            End Get
            Set(ByVal value As Integer)
                _id_plan = value
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

        Private _ListadoDetallePresupuesto As List(Of DetallePresupuestoAnualBE)
        Public Property ListadoDetallePresupuesto() As List(Of DetallePresupuestoAnualBE)
            Get
                Return _ListadoDetallePresupuesto
            End Get
            Set(value As List(Of DetallePresupuestoAnualBE))
                _ListadoDetallePresupuesto = value
            End Set
        End Property

    End Class
End Namespace

