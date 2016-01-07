Imports SGC.Model.Interfaces
Imports SGC.Model.Entidades
Imports System.Data
Imports System.Data.SqlClient
Imports System.Text
Imports System.Configuration

Namespace SGC.Model.Metodos

    Public Class SemaforoDL
        Implements ISemaforo

#Region "Select"

        Public Function ListarSemaforoPorFechas(ByVal id_comite As String, ByVal id_tipo_1 As String, ByVal id_tipo_2 As String, ByVal fec_ini As DateTime, ByVal fec_fin As DateTime) As System.Collections.Generic.List(Of Entidades.SemaforoBE) Implements Interfaces.ISemaforo.ListarSemaforoPorFechas
            Dim oListadoSemaforo As New List(Of SemaforoBE)
            Dim oSemaforo As SemaforoBE
            Dim strConn As String = ConfigurationManager.ConnectionStrings("SGCBI").ConnectionString
            Dim sqlConn As New SqlConnection(strConn)
            Dim sqlCmd As New SqlCommand("USP_SEMAFORO_POR_FECHAS", sqlConn)
            Dim dr As SqlDataReader = Nothing
            sqlCmd.CommandType = CommandType.StoredProcedure
            sqlCmd.Parameters.Add("@id_comite", SqlDbType.VarChar).Value = id_comite
            sqlCmd.Parameters.Add("@tipo_1", SqlDbType.VarChar).Value = id_tipo_1
            sqlCmd.Parameters.Add("@tipo_2", SqlDbType.VarChar).Value = id_tipo_2
            sqlCmd.Parameters.Add("@fec_ini", SqlDbType.DateTime).Value = fec_ini
            sqlCmd.Parameters.Add("@fec_fin", SqlDbType.DateTime).Value = fec_fin

            Try
                sqlConn.Open()
                dr = sqlCmd.ExecuteReader()

                While dr.Read()
                    oSemaforo = New SemaforoBE
                    oSemaforo.anio_mes = dr("anio_mes_des")
                    oSemaforo.participantes1 = dr("participantes_1")
                    oSemaforo.participantes2 = dr("participantes_2")
                    oSemaforo.correlacion = dr("correlacion")
                    oListadoSemaforo.Add(oSemaforo)
                End While
                dr.Close()
                Return oListadoSemaforo
            Catch ex As System.Exception
                Throw ex
            Finally
                sqlConn.Close()
            End Try
        End Function

        Public Function ListarSemaforoPorMes(ByVal id_comite As String, ByVal id_tipo_1 As String, ByVal id_tipo_2 As String, ByVal anio_mes As String) As System.Collections.Generic.List(Of Entidades.SemaforoBE) Implements Interfaces.ISemaforo.ListarSemaforoPorMes
            Dim oListadoSemaforo As New List(Of SemaforoBE)
            Dim oSemaforo As SemaforoBE
            Dim strConn As String = ConfigurationManager.ConnectionStrings("SGCBI").ConnectionString
            Dim sqlConn As New SqlConnection(strConn)
            Dim sqlCmd As New SqlCommand("USP_SEMAFORO_POR_MES", sqlConn)
            Dim dr As SqlDataReader = Nothing
            sqlCmd.CommandType = CommandType.StoredProcedure
            sqlCmd.Parameters.Add("@id_comite", SqlDbType.VarChar).Value = id_comite
            sqlCmd.Parameters.Add("@tipo_1", SqlDbType.VarChar).Value = id_tipo_1
            sqlCmd.Parameters.Add("@tipo_2", SqlDbType.VarChar).Value = id_tipo_2
            sqlCmd.Parameters.Add("@anio_mes", SqlDbType.VarChar).Value = anio_mes

            Try
                sqlConn.Open()
                dr = sqlCmd.ExecuteReader()

                While dr.Read()
                    oSemaforo = New SemaforoBE
                    oSemaforo.fecha = dr("fecha")
                    oSemaforo.participantes1 = dr("participantes_1")
                    oSemaforo.participantes2 = dr("participantes_2")
                    oListadoSemaforo.Add(oSemaforo)
                End While
                dr.Close()
                Return oListadoSemaforo
            Catch ex As System.Exception
                Throw ex
            Finally
                sqlConn.Close()
            End Try
        End Function

        Public Function ListarSemaforoVariables(ByVal id_comite As String, ByVal id_tipo_1 As String, ByVal id_tipo_2 As String, ByVal anio_mes As String) As String Implements Interfaces.ISemaforo.ListarSemaforoVariables
            Dim variables As String = String.Empty
            Dim strConn As String = ConfigurationManager.ConnectionStrings("SGCBI").ConnectionString
            Dim sqlConn As New SqlConnection(strConn)
            Dim sqlCmd As New SqlCommand("UPS_LISTAR_DATOS_PCC", sqlConn)
            Dim dr As SqlDataReader = Nothing
            sqlCmd.CommandType = CommandType.StoredProcedure
            sqlCmd.Parameters.Add("@id_comite", SqlDbType.VarChar).Value = id_comite
            sqlCmd.Parameters.Add("@tipo_max", SqlDbType.VarChar).Value = id_tipo_1
            sqlCmd.Parameters.Add("@tipo_min", SqlDbType.VarChar).Value = id_tipo_2
            sqlCmd.Parameters.Add("@anio_mes", SqlDbType.Int).Value = anio_mes

            Try
                sqlConn.Open()
                dr = sqlCmd.ExecuteReader()

                If dr.Read() Then
                    variables = dr("variables")
                End If
                dr.Close()
                Return variables
            Catch ex As System.Exception
                Throw ex
            Finally
                sqlConn.Close()
            End Try
        End Function

        Public Function ListarComparativoTipo(ByVal id_comite As String, id_tipo As String, ByVal fec_ini As DateTime, ByVal fec_fin As DateTime) As System.Collections.Generic.List(Of Entidades.SemaforoBE) Implements Interfaces.ISemaforo.ListarComparativoTipo
            Dim oListadoSemaforo As New List(Of SemaforoBE)
            Dim oSemaforo As SemaforoBE
            Dim strConn As String = ConfigurationManager.ConnectionStrings("SGCBI").ConnectionString
            Dim sqlConn As New SqlConnection(strConn)
            Dim sqlCmd As New SqlCommand("USP_COMPARATIVO_TIPO", sqlConn)
            Dim dr As SqlDataReader = Nothing
            sqlCmd.CommandType = CommandType.StoredProcedure
            sqlCmd.Parameters.Add("@id_comite", SqlDbType.VarChar).Value = id_comite
            sqlCmd.Parameters.Add("@id_tipo", SqlDbType.VarChar).Value = id_tipo
            sqlCmd.Parameters.Add("@fec_ini", SqlDbType.DateTime).Value = fec_ini
            sqlCmd.Parameters.Add("@fec_fin", SqlDbType.DateTime).Value = fec_fin

            Try
                sqlConn.Open()
                dr = sqlCmd.ExecuteReader()

                While dr.Read()
                    oSemaforo = New SemaforoBE
                    oSemaforo.anio_mes = dr("anio_mes_des")
                    oSemaforo.participantes = dr("participantes")
                    oSemaforo.participantes1 = dr("participantes_1")
                    oSemaforo.participantes2 = dr("participantes_2")
                    oSemaforo.correlacion1 = dr("correlacion_1")
                    oSemaforo.correlacion2 = dr("correlacion_2")
                    oListadoSemaforo.Add(oSemaforo)
                End While
                dr.Close()
                Return oListadoSemaforo
            Catch ex As System.Exception
                Throw ex
            Finally
                sqlConn.Close()
            End Try
        End Function

#End Region

    End Class

End Namespace

