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
                    'oFact.total_inscritos = dr("total_inscritos")
                    'oFact.total_participantes = dr("total_participantes")
                    'oFact.cant_satisfaccion = dr("cant_satisfaccion")
                    'oFact.cant_nosatisfaccion = dr("cant_nosatisfaccion")
                    'oFact.cant_nsno = dr("cant_nsno")
                    'oFact.cant_encuestados = dr("cant_encuestados")
                    'oFact.total_ninios_ins = dr("total_ninios_ins")
                    'oFact.total_mujeres_ins = dr("total_mujeres_ins")
                    'oFact.total_varones_ins = dr("total_varones_ins")
                    'oFact.total_ninios_part = dr("total_ninios_part")
                    'oFact.total_mujeres_part = dr("total_mujeres_part")
                    'oFact.total_varones_part = dr("total_varones_part")
                    oFact.total_inscritos = IIf(dr("total_inscritos") Is DBNull.Value, 0, dr("total_inscritos"))
                    oFact.total_participantes = IIf(dr("total_participantes") Is DBNull.Value, 0, dr("total_participantes"))
                    oFact.cant_satisfaccion = IIf(dr("cant_satisfaccion") Is DBNull.Value, 0, dr("cant_satisfaccion"))
                    oFact.cant_nosatisfaccion = IIf(dr("cant_nosatisfaccion") Is DBNull.Value, 0, dr("cant_nosatisfaccion"))
                    oFact.cant_nsno = IIf(dr("cant_nsno") Is DBNull.Value, 0, dr("cant_nsno"))
                    oFact.cant_encuestados = IIf(dr("cant_encuestados") Is DBNull.Value, 0, dr("cant_encuestados"))
                    oFact.total_ninios_ins = IIf(dr("total_ninios_ins") Is DBNull.Value, 0, dr("total_ninios_ins"))
                    oFact.total_mujeres_ins = IIf(dr("total_mujeres_ins") Is DBNull.Value, 0, dr("total_mujeres_ins"))
                    oFact.total_varones_ins = IIf(dr("total_varones_ins") Is DBNull.Value, 0, dr("total_varones_ins"))
                    oFact.total_ninios_part = IIf(dr("total_ninios_part") Is DBNull.Value, 0, dr("total_ninios_part"))
                    oFact.total_mujeres_part = IIf(dr("total_mujeres_part") Is DBNull.Value, 0, dr("total_mujeres_part"))
                    oFact.total_varones_part = IIf(dr("total_varones_part") Is DBNull.Value, 0, dr("total_varones_part"))
                    'oFact.total_actividades = IIf(dr("total_actividades") Is DBNull.Value, 0, dr("total_actividades"))

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
                    oFact.total_inscritos = IIf(dr("total_inscritos") Is DBNull.Value, 0, dr("total_inscritos"))
                    oFact.total_participantes = IIf(dr("total_participantes") Is DBNull.Value, 0, dr("total_participantes"))
                    oFact.cant_satisfaccion = IIf(dr("cant_satisfaccion") Is DBNull.Value, 0, dr("cant_satisfaccion"))
                    oFact.cant_nosatisfaccion = IIf(dr("cant_nosatisfaccion") Is DBNull.Value, 0, dr("cant_nosatisfaccion"))
                    oFact.cant_nsno = IIf(dr("cant_nsno") Is DBNull.Value, 0, dr("cant_nsno"))
                    oFact.cant_encuestados = IIf(dr("cant_encuestados") Is DBNull.Value, 0, dr("cant_encuestados"))
                    'oFact.total_ninios_ins = IIf(dr("total_ninios_ins") Is DBNull.Value, 0, dr("total_ninios_ins"))
                    'oFact.total_mujeres_ins = IIf(dr("total_mujeres_ins") Is DBNull.Value, 0, dr("total_mujeres_ins"))
                    'oFact.total_varones_ins = IIf(dr("total_varones_ins") Is DBNull.Value, 0, dr("total_varones_ins"))
                    'oFact.total_ninios_part = IIf(dr("total_ninios_part") Is DBNull.Value, 0, dr("total_ninios_part"))
                    'oFact.total_mujeres_part = IIf(dr("total_mujeres_part") Is DBNull.Value, 0, dr("total_mujeres_part"))
                    'oFact.total_varones_part = IIf(dr("total_varones_part") Is DBNull.Value, 0, dr("total_varones_part"))
                    oFact.total_actividades = IIf(dr("total_actividades") Is DBNull.Value, 0, dr("total_actividades"))
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

        Public Function ObtenerMesesParticipacion(ByVal fecIni As Date, ByVal fecFin As Date, id_comite As String, id_tipo As String) As System.Collections.Generic.List(Of Entidades.FactActividadSumBE) Implements Interfaces.IFactActividadSum.ObtenerMesesParticipacion
            Dim oListadoFact As New List(Of FactActividadSumBE)
            Dim oFact As FactActividadSumBE
            Dim strConn As String = ConfigurationManager.ConnectionStrings("SGCBI").ConnectionString
            Dim sqlConn As New SqlConnection(strConn)
            Dim sqlCmd As New SqlCommand("USP_OBTENER_MESES_PARTICIPACION", sqlConn)
            Dim dr As SqlDataReader = Nothing
            sqlCmd.CommandType = CommandType.StoredProcedure
            sqlCmd.Parameters.Add("@FECINI", SqlDbType.DateTime).Value = fecIni
            sqlCmd.Parameters.Add("@FECFIN", SqlDbType.DateTime).Value = fecFin
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

        Public Function ListarMesesParticipacion(ByVal fecIni As Date, ByVal fecFin As Date, id_comite As String, id_tipo As String) As System.Collections.Generic.List(Of Entidades.FactActividadSumBE) Implements Interfaces.IFactActividadSum.ListarMesesParticipacion
            Dim oListadoFact As New List(Of FactActividadSumBE)
            Dim oFact As FactActividadSumBE
            Dim strConn As String = ConfigurationManager.ConnectionStrings("SGCBI").ConnectionString
            Dim sqlConn As New SqlConnection(strConn)
            Dim sqlCmd As New SqlCommand("USP_LISTAR_PARTICIPACION_X_MES", sqlConn)
            Dim dr As SqlDataReader = Nothing
            sqlCmd.CommandType = CommandType.StoredProcedure
            sqlCmd.Parameters.Add("@FECINI", SqlDbType.DateTime).Value = fecIni
            sqlCmd.Parameters.Add("@FECFIN", SqlDbType.DateTime).Value = fecFin
            sqlCmd.Parameters.Add("@id_comite", SqlDbType.VarChar).Value = id_comite
            sqlCmd.Parameters.Add("@id_tipo", SqlDbType.VarChar).Value = id_tipo

            Try
                sqlConn.Open()
                dr = sqlCmd.ExecuteReader()

                While dr.Read()
                    oFact = New FactActividadSumBE
                    oFact.mes = dr("mes")
                    oFact.max_part = dr("TIPO_MX")
                    oFact.min_part = dr("TIPO_MN")
                    oFact.obs_max_part = dr("OBS_TIPO_MX")
                    oFact.obs_min_part = dr("OBS_TIPO_MN")
                    oFact.coeficiente = dr("R")
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

        Public Function ListarMesesParticipacion2(id_comite As String, anio_fin As Integer) As System.Collections.Generic.List(Of Entidades.FactActividadSumBE) Implements Interfaces.IFactActividadSum.ListarMesesParticipacion2
            Dim oListadoFact As New List(Of FactActividadSumBE)
            Dim oFact As FactActividadSumBE
            Dim strConn As String = ConfigurationManager.ConnectionStrings("SGCBI").ConnectionString
            Dim sqlConn As New SqlConnection(strConn)
            Dim sqlCmd As New SqlCommand("USP_LISTAR_PARTICIPACION_X_MES2", sqlConn)
            Dim dr As SqlDataReader = Nothing
            sqlCmd.CommandType = CommandType.StoredProcedure
            sqlCmd.Parameters.Add("@id_comite", SqlDbType.VarChar).Value = id_comite
            sqlCmd.Parameters.Add("@anio_fin", SqlDbType.Int).Value = anio_fin

            Try
                sqlConn.Open()
                dr = sqlCmd.ExecuteReader()

                While dr.Read()
                    oFact = New FactActividadSumBE
                    oFact.mes = dr("mes")
                    oFact.max_part = dr("TIPO_MX")
                    oFact.min_part = dr("TIPO_MN")
                    oFact.obs_max_part = dr("OBS_TIPO_MX")
                    oFact.obs_min_part = dr("OBS_TIPO_MN")
                    oFact.coeficiente = dr("R")
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

        Public Function ListarComitesParticipacion() As System.Collections.Generic.List(Of Entidades.FactActividadSumBE) Implements Interfaces.IFactActividadSum.ListarComitesParticipacion
            Dim oListadoFact As New List(Of FactActividadSumBE)
            Dim oFact As FactActividadSumBE
            Dim strConn As String = ConfigurationManager.ConnectionStrings("SGCBI").ConnectionString
            Dim sqlConn As New SqlConnection(strConn)
            Dim sqlCmd As New SqlCommand("USP_LISTAR_COMITES_PARTICIPACION", sqlConn)
            Dim dr As SqlDataReader = Nothing
            sqlCmd.CommandType = CommandType.StoredProcedure

            Try
                sqlConn.Open()
                dr = sqlCmd.ExecuteReader()

                While dr.Read()
                    oFact = New FactActividadSumBE
                    oFact.nombre_comite = dr("nombre")
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

        Public Function ListarComitesSatisfaccion() As System.Collections.Generic.List(Of Entidades.FactActividadSumBE) Implements Interfaces.IFactActividadSum.ListarComitesSatisfaccion
            Dim oListadoFact As New List(Of FactActividadSumBE)
            Dim oFact As FactActividadSumBE
            Dim strConn As String = ConfigurationManager.ConnectionStrings("SGCBI").ConnectionString
            Dim sqlConn As New SqlConnection(strConn)
            Dim sqlCmd As New SqlCommand("USP_LISTAR_COMITES_SATISFACCION", sqlConn)
            Dim dr As SqlDataReader = Nothing
            sqlCmd.CommandType = CommandType.StoredProcedure

            Try
                sqlConn.Open()
                dr = sqlCmd.ExecuteReader()

                While dr.Read()
                    oFact = New FactActividadSumBE
                    oFact.nombre_comite = dr("nombre")
                    oFact.cant_satisfaccion = dr("cant_satisfaccion")
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

        Public Function ObtenerSatisfaccionTotal() As Decimal Implements Interfaces.IFactActividadSum.ObtenerSatisfaccionTotal
            Dim satisfaccion As Decimal
            Dim strConn As String = ConfigurationManager.ConnectionStrings("SGCBI").ConnectionString
            Dim sqlConn As New SqlConnection(strConn)
            Dim sqlCmd As New SqlCommand("USP_OBTENER_SATISFACCION_TOTAL", sqlConn)
            Dim dr As SqlDataReader = Nothing
            sqlCmd.CommandType = CommandType.StoredProcedure

            Try
                sqlConn.Open()
                dr = sqlCmd.ExecuteReader()

                If dr.Read() Then
                    satisfaccion = dr("cant_satisfaccion")
                End If
                dr.Close()
                Return satisfaccion
            Catch ex As System.Exception
                Throw ex
            Finally
                sqlConn.Close()
            End Try
        End Function

        Public Function ListarTiposParticipacion() As System.Collections.Generic.List(Of Entidades.FactActividadSumBE) Implements Interfaces.IFactActividadSum.ListarTiposParticipacion
            Dim oListadoFact As New List(Of FactActividadSumBE)
            Dim oFact As FactActividadSumBE
            Dim strConn As String = ConfigurationManager.ConnectionStrings("SGCBI").ConnectionString
            Dim sqlConn As New SqlConnection(strConn)
            Dim sqlCmd As New SqlCommand("USP_LISTAR_TIPOS_PARTICIPACION", sqlConn)
            Dim dr As SqlDataReader = Nothing
            sqlCmd.CommandType = CommandType.StoredProcedure

            Try
                sqlConn.Open()
                dr = sqlCmd.ExecuteReader()

                While dr.Read()
                    oFact = New FactActividadSumBE
                    oFact.nombre_tipo = dr("descripcion")
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

        Public Function ListarComitesActividades() As System.Collections.Generic.List(Of Entidades.FactActividadSumBE) Implements Interfaces.IFactActividadSum.ListarComitesActividades
            Dim oListadoFact As New List(Of FactActividadSumBE)
            Dim oFact As FactActividadSumBE
            Dim strConn As String = ConfigurationManager.ConnectionStrings("SGCBI").ConnectionString
            Dim sqlConn As New SqlConnection(strConn)
            Dim sqlCmd As New SqlCommand("USP_LISTAR_COMITES_ACTIVIDADES", sqlConn)
            Dim dr As SqlDataReader = Nothing
            sqlCmd.CommandType = CommandType.StoredProcedure

            Try
                sqlConn.Open()
                dr = sqlCmd.ExecuteReader()

                While dr.Read()
                    oFact = New FactActividadSumBE
                    oFact.nombre_comite = dr("nombre")
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

        Public Function ListarTiposActividades() As System.Collections.Generic.List(Of Entidades.FactActividadSumBE) Implements Interfaces.IFactActividadSum.ListarTiposActividades
            Dim oListadoFact As New List(Of FactActividadSumBE)
            Dim oFact As FactActividadSumBE
            Dim strConn As String = ConfigurationManager.ConnectionStrings("SGCBI").ConnectionString
            Dim sqlConn As New SqlConnection(strConn)
            Dim sqlCmd As New SqlCommand("USP_LISTAR_TIPOS_ACTIVIDADES", sqlConn)
            Dim dr As SqlDataReader = Nothing
            sqlCmd.CommandType = CommandType.StoredProcedure

            Try
                sqlConn.Open()
                dr = sqlCmd.ExecuteReader()

                While dr.Read()
                    oFact = New FactActividadSumBE
                    oFact.nombre_tipo = dr("descripcion")
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

        Public Function ObtenerTotalActividades() As Integer Implements Interfaces.IFactActividadSum.ObtenerTotalActividades
            Dim total As Integer
            Dim strConn As String = ConfigurationManager.ConnectionStrings("SGCBI").ConnectionString
            Dim sqlConn As New SqlConnection(strConn)
            Dim sqlCmd As New SqlCommand("USP_OBTENER_TOTAL_ACTIVIDADES", sqlConn)
            Dim dr As SqlDataReader = Nothing
            sqlCmd.CommandType = CommandType.StoredProcedure

            Try
                sqlConn.Open()
                dr = sqlCmd.ExecuteReader()

                If dr.Read() Then
                    total = dr("total_actividades")
                End If
                dr.Close()
                Return total
            Catch ex As System.Exception
                Throw ex
            Finally
                sqlConn.Close()
            End Try
        End Function

        Public Function ListarParticipantesPorAnio() As System.Collections.Generic.List(Of Entidades.FactActividadSumBE) Implements Interfaces.IFactActividadSum.ListarParticipantesPorAnio
            Dim oListadoFact As New List(Of FactActividadSumBE)
            Dim oFact As FactActividadSumBE
            Dim strConn As String = ConfigurationManager.ConnectionStrings("SGCBI").ConnectionString
            Dim sqlConn As New SqlConnection(strConn)
            Dim sqlCmd As New SqlCommand("USP_LISTAR_PARTICIPANTES_POR_ANIO", sqlConn)
            Dim dr As SqlDataReader = Nothing
            sqlCmd.CommandType = CommandType.StoredProcedure

            Try
                sqlConn.Open()
                dr = sqlCmd.ExecuteReader()

                While dr.Read()
                    oFact = New FactActividadSumBE
                    oFact.anio = dr("anio")
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

