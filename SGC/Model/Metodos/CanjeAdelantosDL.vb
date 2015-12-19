Imports SGC.Model.Interfaces
Imports SGC.Model.Entidades
Imports System.Data
Imports System.Data.SqlClient
Imports System.Text
Imports System.Configuration

Namespace SGC.Model.Metodos

    Public Class CanjeAdelantosDL
        Implements ICanjeAdelantos



#Region "Insert"

        Public Function InsertarCanjeAdelantos(ByRef oDocumento As Entidades.CanjeAdelantosBE) As Integer Implements Interfaces.ICanjeAdelantos.InsertarCanjeAdelantos
            Dim strConn As String = ConfigurationManager.ConnectionStrings("SGC").ConnectionString
            Dim sqlConn As New SqlConnection(strConn)
            Dim sqlCmd As New SqlCommand("comite.SP_INSERTAR_CANJE_ADELANTOS", sqlConn)

            Dim recordId As Integer = 0
            sqlCmd.CommandType = CommandType.StoredProcedure
            sqlCmd.Parameters.Add("@id_tipo_doc2", SqlDbType.VarChar).Value = IIf(oDocumento.id_tipo_doc2 Is Nothing, DBNull.Value, oDocumento.id_tipo_doc2)
            sqlCmd.Parameters.Add("@id_serie2", SqlDbType.VarChar).Value = IIf(oDocumento.id_serie2 Is Nothing, DBNull.Value, oDocumento.id_serie2)
            sqlCmd.Parameters.Add("@id_correlativo2", SqlDbType.VarChar).Value = IIf(oDocumento.id_correlativo2 Is Nothing, DBNull.Value, oDocumento.id_correlativo2)
            sqlCmd.Parameters.Add("@tot_doc", SqlDbType.Decimal).Value = IIf(oDocumento.tot_doc Is Nothing, DBNull.Value, oDocumento.tot_doc)
            sqlCmd.Parameters.Add("@pago", SqlDbType.Decimal).Value = IIf(oDocumento.pago Is Nothing, DBNull.Value, oDocumento.pago)
            sqlCmd.Parameters.Add("@id_tipo_plan", SqlDbType.Int).Value = 1
            sqlCmd.Parameters.Add("@fec_canc", SqlDbType.DateTime).Value = IIf(oDocumento.fec_canc Is Nothing, DBNull.Value, oDocumento.fec_canc)
            sqlCmd.Parameters.Add("@id_tipo_pago", SqlDbType.Int).Value = IIf(oDocumento.id_tipo_pago Is Nothing, DBNull.Value, oDocumento.id_tipo_pago)
            sqlCmd.Parameters.Add("@id_sede", SqlDbType.VarChar).Value = IIf(oDocumento.id_sede Is Nothing, DBNull.Value, oDocumento.id_sede)
            sqlCmd.Parameters.Add("@id_moneda", SqlDbType.VarChar).Value = "001"
            sqlCmd.Parameters.Add("@pago_dolares", SqlDbType.Decimal).Value = IIf(oDocumento.pago_dolares Is Nothing, DBNull.Value, oDocumento.pago_dolares)
            sqlCmd.Parameters.Add("@flg_anulado", SqlDbType.Bit).Value = 0
            sqlCmd.Parameters.Add("@nro_tarjeta", SqlDbType.VarChar).Value = IIf(oDocumento.nro_tarjeta Is Nothing, DBNull.Value, oDocumento.nro_tarjeta)
            sqlCmd.Parameters.Add("@nro_boucher", SqlDbType.VarChar).Value = IIf(oDocumento.nro_boucher Is Nothing, DBNull.Value, oDocumento.nro_boucher)
            sqlCmd.Parameters.Add("@id_tipo_trans", SqlDbType.Decimal).Value = 1
            sqlCmd.Parameters.Add("@PAGO_SAP", SqlDbType.Bit).Value = 0

            Try
                sqlConn.Open()
                recordId = sqlCmd.ExecuteScalar()

                Return recordId
            Catch ex As System.Exception
                Throw ex
            Finally
                sqlConn.Close()
            End Try
        End Function

#End Region

    End Class
End Namespace

