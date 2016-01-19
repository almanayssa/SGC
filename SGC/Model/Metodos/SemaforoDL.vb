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

        Public Function ListarCorrelacionMensual(ByVal id_comite As Integer, ByVal tipo_1 As String, ByVal tipo_2 As String, ByVal anio_fin As Integer) As System.Collections.Generic.List(Of Entidades.SemaforoBE) Implements Interfaces.ISemaforo.ListarCorrelacionMensual
            Dim oListadoFact As New List(Of SemaforoBE)
            Dim oFact As SemaforoBE
            Dim strConn As String = ConfigurationManager.ConnectionStrings("SGCBI").ConnectionString
            Dim sqlConn As New SqlConnection(strConn)
            Dim sqlCmd As New SqlCommand("USP_RELACION_MENSUAL_X_TIPOS", sqlConn)
            Dim dr As SqlDataReader = Nothing
            Dim mes As String = ""
            Dim part1 As Integer = 0
            Dim part2 As Integer = 0
            sqlCmd.CommandType = CommandType.StoredProcedure
            sqlCmd.Parameters.Add("@id_comite", SqlDbType.NVarChar).Value = id_comite
            sqlCmd.Parameters.Add("@tipo_1", SqlDbType.NVarChar).Value = tipo_1
            sqlCmd.Parameters.Add("@tipo_2", SqlDbType.NVarChar).Value = tipo_2
            sqlCmd.Parameters.Add("@anio_fin", SqlDbType.NVarChar).Value = anio_fin

            Try
                sqlConn.Open()
                dr = sqlCmd.ExecuteReader()

                While dr.Read()
                    oFact = New SemaforoBE
                    oFact.nombre_mes = dr("mes")
                    oFact.anio = dr("anio")
                    oFact.correlacion = dr("r")
                    oFact.participantes1 = dr("part1")
                    oFact.participantes2 = dr("part2")
                    oFact.porc1 = dr("porc_part1")
                    oFact.porc2 = dr("porc_part2")
                    oFact.prompart1 = dr("prom_part1")
                    oFact.prompart2 = dr("prom_part2")
                    oFact.promporc1 = dr("prom_porc1")
                    oFact.promporc2 = dr("prom_porc2")
                    oFact.participantes = dr("total_part")
                    If oFact.nombre_mes <> mes Then
                        oFact.tasa1 = "0"
                        oFact.tasa2 = "0"
                        part1 = oFact.participantes1
                        part2 = oFact.participantes2
                        mes = oFact.nombre_mes
                    Else
                        If part1 = 0 Then
                            oFact.tasa1 = 0
                        Else
                            oFact.tasa1 = Math.Round((oFact.participantes1 - part1) * 100.0 / part1, 2)
                        End If
                        If part2 = 0 Then
                            oFact.tasa2 = 0
                        Else
                            oFact.tasa2 = Math.Round((oFact.participantes2 - part2) * 100.0 / part2, 2)
                        End If

                        part1 = oFact.participantes1
                        part2 = oFact.participantes2
                    End If
                    oListadoFact.Add(oFact)
                End While
                dr.Close()
                Return oListadoFact
            Catch ex As System.Exception
                Throw ex
            Finally
                sqlConn.Close()
            End Try
        End Function

#End Region

    End Class

End Namespace

