Imports SGC.Model.Interfaces
Imports SGC.Model.Entidades
Imports System.Data
Imports System.Data.SqlClient
Imports System.Text
Imports System.Configuration

Namespace SGC.Model.Metodos

    Public Class FactActividadSumDL
        Implements IFactActividadSum


#Region "Select"

        Public Function ListarFactActividadSum() As System.Collections.Generic.List(Of Entidades.FactActividadSumBE) Implements Interfaces.IFactActividadSum.ListarFactActividadSum
            Dim oListadoFact As New List(Of FactActividadSumBE)
            Dim oFact As FactActividadSumBE
            Dim strConn As String = ConfigurationManager.ConnectionStrings("SGCBI").ConnectionString
            Dim sqlConn As New SqlConnection(strConn)
            Dim sqlCmd As New SqlCommand("USP_LISTAR_FACTACTIVIDADSUM", sqlConn)
            Dim dr As SqlDataReader = Nothing
            sqlCmd.CommandType = CommandType.StoredProcedure

            Try
                sqlConn.Open()
                dr = sqlCmd.ExecuteReader()

                While dr.Read()
                    oFact = New FactActividadSumBE
                    oFact.id = dr("id")
                    oFact.id_actividad = dr("id_actividad")
                    oFact.id_comite = dr("id_comite")
                    oFact.id_tipo = dr("id_tipo")
                    oFact.id_fecha_ini = dr("id_fecha_ini")
                    oFact.id_fecha_fin = dr("id_fecha_fin")
                    oFact.total_inscritos = dr("total_inscritos")
                    oFact.total_participantes = dr("total_participantes")
                    oFact.cant_satisfaccion = dr("cant_satisfaccion")
                    oFact.cant_nosatisfaccion = dr("cant_nosatisfaccion")
                    oFact.cant_nsno = dr("cant_nsno")
                    oFact.cant_encuestados = dr("cant_encuestados")
                    oFact.total_ninios_ins = dr("total_ninios_ins")
                    oFact.total_mujeres_ins = dr("total_mujeres_ins")
                    oFact.total_varones_ins = dr("total_varones_ins")
                    oFact.total_ninios_part = dr("total_ninios_part")
                    oFact.total_mujeres_part = dr("total_mujeres_part")
                    oFact.total_varones_part = dr("total_varones_part")
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

        Public Function ListarTotalesFactActividadSum(ByVal fecIni As Date, ByVal fecFin As Date, ByVal id_comite As String, ByVal id_tipo As String) As System.Collections.Generic.List(Of Entidades.FactActividadSumBE) Implements Interfaces.IFactActividadSum.ListarTotalesFactActividadSum
            Dim oListadoFact As New List(Of FactActividadSumBE)
            Dim oFact As FactActividadSumBE
            Dim strConn As String = ConfigurationManager.ConnectionStrings("SGCBI").ConnectionString
            Dim sqlConn As New SqlConnection(strConn)
            Dim sqlCmd As New SqlCommand("USP_LISTAR_FACT_X_COMITE", sqlConn)
            Dim dr As SqlDataReader = Nothing
            sqlCmd.CommandType = CommandType.StoredProcedure
            sqlCmd.Parameters.Add("@FECINI", SqlDbType.DateTime).Value = fecIni
            sqlCmd.Parameters.Add("@FECFIN", SqlDbType.DateTime).Value = fecFin
            sqlCmd.Parameters.Add("@id_comite", SqlDbType.VarChar).Value = id_comite
            sqlCmd.Parameters.Add("@ID_TIPO", SqlDbType.VarChar).Value = id_tipo

            Try
                sqlConn.Open()
                dr = sqlCmd.ExecuteReader()

                While dr.Read()
                    oFact = New FactActividadSumBE
                    oFact.id_comite = dr("id_comite")
                    oFact.comite = dr("comite")
                    oFact.id_tipo = dr("id_tipo")
                    oFact.tipo_actividad = dr("tipo")
                    oFact.total_inscritos = dr("total_inscritos")
                    oFact.total_participantes = dr("total_participantes")
                    oFact.cant_satisfaccion = dr("cant_satisfaccion")
                    oFact.cant_nosatisfaccion = dr("cant_nosatisfaccion")
                    oFact.cant_nsno = dr("cant_nsno")
                    oFact.cant_encuestados = dr("cant_encuestados")
                    oFact.total_ninios_ins = dr("total_ninios_ins")
                    oFact.total_mujeres_ins = dr("total_mujeres_ins")
                    oFact.total_varones_ins = dr("total_varones_ins")
                    oFact.total_ninios_part = dr("total_ninios_part")
                    oFact.total_mujeres_part = dr("total_mujeres_part")
                    oFact.total_varones_part = dr("total_varones_part")
                    oFact.total_actividades = dr("total_actividades")
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

        Public Function ObtenerMaxInscritosXTipoActividad(id_comite As String, ByVal ID_TIPO As String) As System.Collections.Generic.List(Of Entidades.FactActividadSumBE) Implements Interfaces.IFactActividadSum.ObtenerMaxInscritosXTipoActividad
            Dim oListadoFact As New List(Of FactActividadSumBE)
            Dim oFact As FactActividadSumBE
            Dim strConn As String = ConfigurationManager.ConnectionStrings("SGCBI").ConnectionString
            Dim sqlConn As New SqlConnection(strConn)
            Dim sqlCmd As New SqlCommand("USP_OBTENER_TIPO_X_COMITE", sqlConn)
            Dim dr As SqlDataReader = Nothing
            sqlCmd.CommandType = CommandType.StoredProcedure
            sqlCmd.Parameters.Add("@id_comite", SqlDbType.VarChar).Value = id_comite
            sqlCmd.Parameters.Add("@ID_TIPO", SqlDbType.VarChar).Value = ID_TIPO

            Try
                sqlConn.Open()
                dr = sqlCmd.ExecuteReader()

                While dr.Read()
                    oFact = New FactActividadSumBE
                    oFact.id_tipo = dr("id_tipo")
                    oFact.tipo_actividad = dr("tipo_actividad")
                    oFact.id_comite = dr("id_comite")
                    oFact.comite = dr("comite")
                    oFact.id_tipo = dr("id_tipo")
                    oFact.ins_x_actividad = Math.Round(CDec(dr("ins_x_actividad")), 0, MidpointRounding.ToEven)
                    oFact.total_actividades = dr("total_actividades")
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

        Public Function ObtenerMaxSatisfaccionXTipoActividad(id_comite As String, id_tipo As String) As System.Collections.Generic.List(Of Entidades.FactActividadSumBE) Implements Interfaces.IFactActividadSum.ObtenerMaxSatisfaccionXTipoActividad
            Dim oListadoFact As New List(Of FactActividadSumBE)
            Dim oFact As FactActividadSumBE
            Dim strConn As String = ConfigurationManager.ConnectionStrings("SGCBI").ConnectionString
            Dim sqlConn As New SqlConnection(strConn)
            Dim sqlCmd As New SqlCommand("USP_OBTENER_COMITE_SATISFACCION", sqlConn)
            Dim dr As SqlDataReader = Nothing
            sqlCmd.CommandType = CommandType.StoredProcedure
            sqlCmd.Parameters.Add("@id_comite", SqlDbType.VarChar).Value = id_comite
            sqlCmd.Parameters.Add("@id_tipo", SqlDbType.VarChar).Value = id_tipo

            Try
                sqlConn.Open()
                dr = sqlCmd.ExecuteReader()

                While dr.Read()
                    oFact = New FactActividadSumBE
                    oFact.id_tipo = dr("id_tipo")
                    oFact.tipo_actividad = dr("tipo_actividad")
                    oFact.id_comite = dr("id_comite")
                    oFact.comite = dr("comite")
                    oFact.id_tipo = dr("id_tipo")
                    oFact.satisfaccion = dr("satisfaccion")
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

        Public Function ObtenerSexoParticipantesXTipoActividad(id_comite As String, id_tipo As String) As Entidades.FactActividadSumBE Implements Interfaces.IFactActividadSum.ObtenerSexoParticipantesXTipoActividad

            Dim oFact As FactActividadSumBE
            Dim strConn As String = ConfigurationManager.ConnectionStrings("SGCBI").ConnectionString
            Dim sqlConn As New SqlConnection(strConn)
            Dim sqlCmd As New SqlCommand("USP_OBTENER_MAX_SEXO_TIPOACTIVIDAD", sqlConn)
            Dim dr As SqlDataReader = Nothing
            sqlCmd.CommandType = CommandType.StoredProcedure
            sqlCmd.Parameters.Add("@id_comite", SqlDbType.VarChar).Value = id_comite
            sqlCmd.Parameters.Add("@id_tipo", SqlDbType.VarChar).Value = id_tipo

            Try
                sqlConn.Open()
                dr = sqlCmd.ExecuteReader()

                If dr.Read() Then
                    oFact = New FactActividadSumBE
                    oFact.id_tipo = dr("id_tipo")
                    oFact.tipo_actividad = dr("tipo_actividad")
                    oFact.id_comite = dr("id_comite")
                    oFact.comite = dr("comite")
                    oFact.max_sexo = dr("MAXSEXO")
                End If
                dr.Close()
                Return oFact
            Catch ex As System.Exception
                Throw ex
            Finally
                sqlConn.Close()
            End Try
        End Function

        Public Function ObtenerMesInscripcionXTipoActividad(id_comite As String, id_tipo As String) As System.Collections.Generic.List(Of Entidades.FactActividadSumBE) Implements Interfaces.IFactActividadSum.ObtenerMesInscripcionXTipoActividad
            Dim oListadoFact As New List(Of FactActividadSumBE)
            Dim oFact As FactActividadSumBE
            Dim strConn As String = ConfigurationManager.ConnectionStrings("SGCBI").ConnectionString
            Dim sqlConn As New SqlConnection(strConn)
            Dim sqlCmd As New SqlCommand("USP_OBTENER_MES_INSCRIPCION", sqlConn)
            Dim dr As SqlDataReader = Nothing
            sqlCmd.CommandType = CommandType.StoredProcedure
            sqlCmd.Parameters.Add("@id_comite", SqlDbType.VarChar).Value = id_comite
            sqlCmd.Parameters.Add("@id_tipo", SqlDbType.VarChar).Value = id_tipo

            Try
                sqlConn.Open()
                dr = sqlCmd.ExecuteReader()

                While dr.Read()
                    oFact = New FactActividadSumBE
                    oFact.mes = dr("mes")
                    oFact.total_inscritos = dr("total_inscritos")
                    oFact.total_participantes = dr("total_participantes")
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

