Imports SGC.Model.Entidades
Imports SGC.Model.Interfaces
Imports SGC.Model.Metodos
Imports System.Transactions

Namespace SGC.Controller

    Partial Public Class BusinessController

#Region "Select"

#End Region

#Region "Insert"

        Public Function InsertarCanjeAdelantos(ByRef oPago As CanjeAdelantosBE) As Integer
            Try
                
                Dim iCanjeAdelantos As ICanjeAdelantos
                iCanjeAdelantos = New CanjeAdelantosDL

                Dim affectedRows As Integer

                'oPago.id_serie = oDocVen.id_serie
                'oPago.id_correlativo = oDocVen.id_correlativo
                'oPago.id_tipo_doc = "02"
                'oPago.id_articulo = 340
                'oPago.id_subconcepto = 190
                'oPago.id_concepto = 15
                'oPago.id_moneda = "001"
                'oPago.precio_art_pro = oDocumento.mon_bru
                'oPago.cant_art_pro = 1
                'oPago.mon_art_pro = oDocumento.tot_mon
                'oPago.obs_art_pro = "Inscripción a Actividad"
                'oPago.mora = 0
                'oPago.gasto = 0
                'oPago.igv = oDocumento.igv
                'oPago.detraccion = 0
                'oPago.utilidad = 0

                affectedRows = iCanjeAdelantos.InsertarCanjeAdelantos(oPago)

                Return affectedRows

            Catch ex As Exception
                Return Nothing
            End Try
        End Function

#End Region

    End Class

End Namespace


