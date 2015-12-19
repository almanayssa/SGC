Imports SGC.Model.Interfaces
Imports SGC.Model.Entidades
Imports System.Data
Imports System.Data.SqlClient
Imports System.Text
Imports System.Configuration

Namespace SGC.Model.Metodos

    Public Class ArticuloCobranzaDL
        Implements IArticuloCobranza



#Region "Insert"

        Public Function InsertarArticuloCobranza(ByRef oDocumento As Entidades.ArticuloCobranzaBE) As Integer Implements Interfaces.IArticuloCobranza.InsertarArticuloCobranza
            Dim strConn As String = ConfigurationManager.ConnectionStrings("SGC").ConnectionString
            Dim sqlConn As New SqlConnection(strConn)
            Dim sqlCmd As New SqlCommand("comite.SP_INSERTAR_ARTICULO_COBRANZA", sqlConn)

            Dim recordId As Integer = 0
            sqlCmd.CommandType = CommandType.StoredProcedure
            sqlCmd.Parameters.Add("@id_serie", SqlDbType.VarChar).Value = IIf(oDocumento.id_serie Is Nothing, DBNull.Value, oDocumento.id_serie)
            sqlCmd.Parameters.Add("@id_correlativo", SqlDbType.VarChar).Value = IIf(oDocumento.id_correlativo Is Nothing, DBNull.Value, oDocumento.id_correlativo)
            sqlCmd.Parameters.Add("@id_tipo_doc", SqlDbType.VarChar).Value = IIf(oDocumento.id_tipo_doc Is Nothing, DBNull.Value, oDocumento.id_tipo_doc)
            sqlCmd.Parameters.Add("@id_articulo", SqlDbType.Int).Value = IIf(oDocumento.id_articulo Is Nothing, DBNull.Value, oDocumento.id_articulo)
            sqlCmd.Parameters.Add("@id_subconcepto", SqlDbType.Int).Value = IIf(oDocumento.id_subconcepto Is Nothing, DBNull.Value, oDocumento.id_subconcepto)
            sqlCmd.Parameters.Add("@id_concepto", SqlDbType.Int).Value = IIf(oDocumento.id_concepto Is Nothing, DBNull.Value, oDocumento.id_concepto)
            sqlCmd.Parameters.Add("@id_moneda", SqlDbType.VarChar).Value = IIf(oDocumento.id_moneda Is Nothing, DBNull.Value, oDocumento.id_moneda)
            sqlCmd.Parameters.Add("@precio_art_pro", SqlDbType.Decimal).Value = IIf(oDocumento.precio_art_pro Is Nothing, DBNull.Value, oDocumento.precio_art_pro)
            sqlCmd.Parameters.Add("@can_art_pro", SqlDbType.Int).Value = IIf(oDocumento.cant_art_pro Is Nothing, DBNull.Value, oDocumento.cant_art_pro)
            sqlCmd.Parameters.Add("@mon_art_pro", SqlDbType.Decimal).Value = IIf(oDocumento.mon_art_pro Is Nothing, DBNull.Value, oDocumento.mon_art_pro)
            sqlCmd.Parameters.Add("@obs_art_pro", SqlDbType.VarChar).Value = IIf(oDocumento.obs_art_pro Is Nothing, DBNull.Value, oDocumento.obs_art_pro)
            sqlCmd.Parameters.Add("@mora", SqlDbType.Decimal).Value = IIf(oDocumento.mora Is Nothing, DBNull.Value, oDocumento.mora)
            sqlCmd.Parameters.Add("@gasto", SqlDbType.Decimal).Value = IIf(oDocumento.gasto Is Nothing, DBNull.Value, oDocumento.gasto)
            sqlCmd.Parameters.Add("@igv", SqlDbType.Decimal).Value = IIf(oDocumento.igv Is Nothing, DBNull.Value, oDocumento.igv)
            sqlCmd.Parameters.Add("@detraccion", SqlDbType.Decimal).Value = IIf(oDocumento.detraccion Is Nothing, DBNull.Value, oDocumento.detraccion)
            sqlCmd.Parameters.Add("@utilidad", SqlDbType.Decimal).Value = IIf(oDocumento.utilidad Is Nothing, DBNull.Value, oDocumento.utilidad)


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

