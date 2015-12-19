Imports SGC.Model.Entidades
Imports SGC.Model.Interfaces
Imports SGC.Model.Metodos
Imports System.Transactions

Namespace SGC.Controller

    Partial Public Class BusinessController

#Region "Select"

        Public Function ListarDocumentos(ByVal id_socio As String) As List(Of DocVenBE)
            Try
                Dim oListadoDocs As List(Of DocVenBE) = Nothing

                Dim iDocVen As IDocVen

                iDocVen = New DocVenDL
                oListadoDocs = iDocVen.ListarDocumentos(id_socio)

                Return oListadoDocs

            Catch ex As Exception
                Return Nothing
            End Try
        End Function

#End Region

#Region "Insert"

        Public Function InsertarDocVen(ByRef oDocumento As DocVenBE) As DocVenBE
            Try
                Using ts As New TransactionScope

                    Dim iDocVen As IDocVen
                    iDocVen = New DocVenDL

                    Dim iArticuloCobranza As IArticuloCobranza
                    iArticuloCobranza = New ArticuloCobranzaDL

                    Dim oDocVen As New DocVenBE
                    Dim oArticuloCobranza As New ArticuloCobranzaBE

                    Dim affectedRows As Integer


                    oDocVen = iDocVen.ObtenerCorrelativo()

                    oDocumento.id_serie = oDocVen.id_serie
                    oDocumento.id_correlativo = oDocVen.id_correlativo
                    oDocumento.id_est_doc = "ED00001"
                    oDocumento.fec_ven = Today.Date
                    oDocumento.mon_bru = oDocumento.tot_mon * 0.82
                    oDocumento.igv = oDocumento.tot_mon * 0.18
                    oDocumento.id_moneda = "001"
                    iDocVen.InsertarDocVen(oDocumento)

                    oArticuloCobranza.id_serie = oDocVen.id_serie
                    oArticuloCobranza.id_correlativo = oDocVen.id_correlativo
                    oArticuloCobranza.id_tipo_doc = "02"
                    oArticuloCobranza.id_articulo = 340
                    oArticuloCobranza.id_subconcepto = 190
                    oArticuloCobranza.id_concepto = 15
                    oArticuloCobranza.id_moneda = "001"
                    oArticuloCobranza.precio_art_pro = oDocumento.mon_bru
                    oArticuloCobranza.cant_art_pro = 1
                    oArticuloCobranza.mon_art_pro = oDocumento.tot_mon
                    oArticuloCobranza.obs_art_pro = "Inscripción a Actividad"
                    oArticuloCobranza.mora = 0
                    oArticuloCobranza.gasto = 0
                    oArticuloCobranza.igv = oDocumento.igv
                    oArticuloCobranza.detraccion = 0
                    oArticuloCobranza.utilidad = 0
                    iArticuloCobranza.InsertarArticuloCobranza(oArticuloCobranza)

                    ts.Complete()
                    Return oDocVen

                End Using
            Catch ex As Exception
                Return Nothing
            End Try
        End Function

#End Region

    End Class

End Namespace


