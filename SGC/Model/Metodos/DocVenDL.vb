Imports SGC.Model.Interfaces
Imports SGC.Model.Entidades
Imports System.Data
Imports System.Data.SqlClient
Imports System.Text
Imports System.Configuration

Namespace SGC.Model.Metodos

    Public Class DocVenDL
        Implements IDocVen


#Region "Select"

        Public Function ObtenerCorrelativo() As Entidades.DocVenBE Implements Interfaces.IDocVen.ObtenerCorrelativo
            Dim oDoc As New DocVenBE
            Dim strConn As String = ConfigurationManager.ConnectionStrings("SGC").ConnectionString
            Dim sqlConn As New SqlConnection(strConn)
            Dim sqlCmd As New SqlCommand("comite.SP_OBTENER_DOC_CORRELATIVO", sqlConn)
            Dim dr As SqlDataReader = Nothing
            sqlCmd.CommandType = CommandType.StoredProcedure

            Try
                sqlConn.Open()
                dr = sqlCmd.ExecuteReader()

                While dr.Read()
                    oDoc = New DocVenBE
                    oDoc.id_serie = dr("id_serie")
                    oDoc.id_correlativo = dr("id_correlativo")
                End While
                dr.Close()
                Return oDoc
            Catch ex As System.Exception
                Throw ex
            Finally
                sqlConn.Close()
            End Try
        End Function

        Public Function ListarDocumentos(ByVal id_socio As String) As System.Collections.Generic.List(Of Entidades.DocVenBE) Implements Interfaces.IDocVen.ListarDocumentos
            Dim oListadoDocumentos As New List(Of DocVenBE)
            Dim oDocumento As DocVenBE
            Dim strConn As String = ConfigurationManager.ConnectionStrings("SGC").ConnectionString
            Dim sqlConn As New SqlConnection(strConn)
            Dim sqlCmd As New SqlCommand("comite.SP_LISTAR_DOCUMENTOS", sqlConn)
            Dim dr As SqlDataReader = Nothing
            sqlCmd.CommandType = CommandType.StoredProcedure
            sqlCmd.Parameters.Add("@id_socio", SqlDbType.VarChar).Value = id_socio

            Try
                sqlConn.Open()
                dr = sqlCmd.ExecuteReader()

                While dr.Read()
                    oDocumento = New DocVenBE
                    oDocumento.id_serie = dr("id_serie")
                    oDocumento.id_correlativo = dr("id_correlativo")
                    oDocumento.id_entidad = dr("id_entidad")
                    oDocumento.id_est_doc = dr("id_est_doc")
                    oDocumento.fec_reg = dr("fec_reg")
                    oDocumento.fec_ven = dr("fec_ven")
                    oDocumento.mon_bru = dr("mon_bru")
                    oDocumento.igv = dr("igv")
                    oDocumento.tot_mon = dr("tot_mon")
                    oDocumento.id_tipo_doc = dr("id_tipo_doc")
                    oDocumento.sal_doc = dr("sal_doc")
                    oDocumento.obs_doc = dr("obs_doc")
                    oDocumento.mon_det = dr("mon_det")
                    oDocumento.id_moneda = dr("id_moneda")

                    oListadoDocumentos.Add(oDocumento)
                End While
                dr.Close()
                Return oListadoDocumentos
            Catch ex As System.Exception
                Throw ex
            Finally
                sqlConn.Close()
            End Try
        End Function


#End Region

#Region "Insert"

        Public Function InsertarDocVen(ByRef oDocumento As Entidades.DocVenBE) As Integer Implements Interfaces.IDocVen.InsertarDocVen
            Dim strConn As String = ConfigurationManager.ConnectionStrings("SGC").ConnectionString
            Dim sqlConn As New SqlConnection(strConn)
            Dim sqlCmd As New SqlCommand("comite.SP_INSERTAR_DOC_VEN", sqlConn)

            Dim recordId As Integer = 0
            sqlCmd.CommandType = CommandType.StoredProcedure
            sqlCmd.Parameters.Add("@id_serie", SqlDbType.VarChar).Value = IIf(oDocumento.id_serie Is Nothing, DBNull.Value, oDocumento.id_serie)
            sqlCmd.Parameters.Add("@id_correlativo", SqlDbType.VarChar).Value = IIf(oDocumento.id_correlativo Is Nothing, DBNull.Value, oDocumento.id_correlativo)
            sqlCmd.Parameters.Add("@id_entidad", SqlDbType.VarChar).Value = IIf(oDocumento.id_entidad Is Nothing, DBNull.Value, oDocumento.id_entidad)
            sqlCmd.Parameters.Add("@id_est_doc", SqlDbType.VarChar).Value = IIf(oDocumento.id_est_doc Is Nothing, DBNull.Value, oDocumento.id_est_doc)
            sqlCmd.Parameters.Add("@fec_ven", SqlDbType.Date).Value = IIf(oDocumento.fec_ven Is Nothing, DBNull.Value, oDocumento.fec_ven)
            sqlCmd.Parameters.Add("@mon_bru", SqlDbType.Decimal).Value = IIf(oDocumento.mon_bru Is Nothing, DBNull.Value, oDocumento.mon_bru)
            sqlCmd.Parameters.Add("@igv", SqlDbType.Decimal).Value = IIf(oDocumento.igv Is Nothing, DBNull.Value, oDocumento.igv)
            sqlCmd.Parameters.Add("@tot_mon", SqlDbType.Decimal).Value = IIf(oDocumento.tot_mon Is Nothing, DBNull.Value, oDocumento.tot_mon)
            sqlCmd.Parameters.Add("@flg_prv", SqlDbType.Bit).Value = 0
            sqlCmd.Parameters.Add("@flg_art", SqlDbType.Bit).Value = 0
            sqlCmd.Parameters.Add("@id_tipo_doc", SqlDbType.VarChar).Value = "02"
            sqlCmd.Parameters.Add("@sal_doc", SqlDbType.Decimal).Value = IIf(oDocumento.tot_mon Is Nothing, DBNull.Value, oDocumento.tot_mon)
            sqlCmd.Parameters.Add("@obs_doc", SqlDbType.VarChar).Value = IIf(oDocumento.obs_doc Is Nothing, DBNull.Value, oDocumento.obs_doc)
            sqlCmd.Parameters.Add("@mon_det", SqlDbType.Decimal).Value = 0
            sqlCmd.Parameters.Add("@id_moneda", SqlDbType.VarChar).Value = IIf(oDocumento.id_moneda Is Nothing, DBNull.Value, oDocumento.id_moneda)
            sqlCmd.Parameters.Add("@mon_uti", SqlDbType.Decimal).Value = 0


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

