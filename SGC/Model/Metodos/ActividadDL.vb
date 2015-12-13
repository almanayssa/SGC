Imports SGC.Model.Interfaces
Imports SGC.Model.Entidades
Imports System.Data
Imports System.Data.SqlClient
Imports System.Text
Imports System.Configuration

Namespace SGC.Model.Metodos
    Public Class ActividadDL
        Implements IActividad

#Region "Select"

        Public Function ListarActividades(ByVal id_comite As String, ByVal fec_ini As DateTime, ByVal fec_fin As DateTime) As System.Collections.Generic.List(Of Entidades.ActividadBE) Implements Interfaces.IActividad.ListarActividades
            Dim oListadoActividades As New List(Of ActividadBE)
            Dim oActividad As ActividadBE
            Dim strConn As String = ConfigurationManager.ConnectionStrings("SGC").ConnectionString
            Dim sqlConn As New SqlConnection(strConn)
            Dim sqlCmd As New SqlCommand("comite.SP_LISTAR_ACTIVIDADES", sqlConn)
            Dim dr As SqlDataReader = Nothing
            sqlCmd.CommandType = CommandType.StoredProcedure
            sqlCmd.Parameters.Add("@id_comite", SqlDbType.VarChar).Value = id_comite
            sqlCmd.Parameters.Add("@fec_ini", SqlDbType.DateTime).Value = fec_ini
            sqlCmd.Parameters.Add("@fec_fin", SqlDbType.DateTime).Value = fec_fin

            Try
                sqlConn.Open()
                dr = sqlCmd.ExecuteReader()

                While dr.Read()
                    oActividad = New ActividadBE
                    oActividad.id_actividad = dr("id_actividad")
                    oActividad.nombre = dr("nombre")
                    oActividad.descripcion = dr("descripcion")
                    oActividad.id_tipo_act = dr("id_tipo_act")
                    oActividad.desc_tipo = dr("desc_tipo")
                    oActividad.id_cattipo_act = IIf(dr("id_cattipo_act") Is DBNull.Value, Nothing, dr("id_cattipo_act"))
                    oActividad.desc_cat = IIf(dr("desc_cat") Is DBNull.Value, Nothing, dr("desc_cat"))
                    oActividad.fec_ini = IIf(dr("fec_ini") Is DBNull.Value, Nothing, dr("fec_ini"))
                    oActividad.fec_fin = IIf(dr("fec_fin") Is DBNull.Value, Nothing, dr("fec_fin"))
                    oActividad.monto_pago = dr("monto_pago")
                    oActividad.vacantes = dr("vacantes")
                    oActividad.id_estado = dr("id_estado")
                    oActividad.desc_estado = dr("estado")
                    oListadoActividades.Add(oActividad)
                End While
                dr.Close()
                Return oListadoActividades
            Catch ex As System.Exception
                Throw ex
            Finally
                sqlConn.Close()
            End Try
        End Function

        Public Function ListarActividadesBusqueda(ByVal id_comite As String, ByVal nombre As String) As System.Collections.Generic.List(Of Entidades.ActividadBE) Implements Interfaces.IActividad.ListarActividadesBusqueda
            Dim oListadoActividades As New List(Of ActividadBE)
            Dim oActividad As ActividadBE
            Dim strConn As String = ConfigurationManager.ConnectionStrings("SGC").ConnectionString
            Dim sqlConn As New SqlConnection(strConn)
            Dim sqlCmd As New SqlCommand("comite.SP_LISTAR_ACTIVIDADES_BUSQUEDA", sqlConn)
            Dim dr As SqlDataReader = Nothing
            sqlCmd.CommandType = CommandType.StoredProcedure
            sqlCmd.Parameters.Add("@id_comite", SqlDbType.VarChar).Value = id_comite
            sqlCmd.Parameters.Add("@nombre", SqlDbType.VarChar).Value = nombre

            Try
                sqlConn.Open()
                dr = sqlCmd.ExecuteReader()

                While dr.Read()
                    oActividad = New ActividadBE
                    oActividad.id_actividad = dr("id_actividad")
                    oActividad.nombre = dr("nombre")
                    oActividad.fec_ini = IIf(dr("fec_ini") Is DBNull.Value, Nothing, dr("fec_ini"))
                    oActividad.hora_ini = IIf(dr("hora_ini") Is DBNull.Value, Nothing, dr("hora_ini"))
                    oActividad.fec_fin = IIf(dr("fec_fin") Is DBNull.Value, Nothing, dr("fec_fin"))
                    oActividad.hora_fin = IIf(dr("hora_fin") Is DBNull.Value, Nothing, dr("hora_fin"))
                    oListadoActividades.Add(oActividad)
                End While
                dr.Close()
                Return oListadoActividades
            Catch ex As System.Exception
                Throw ex
            Finally
                sqlConn.Close()
            End Try
        End Function

        Public Function CargarActividadCabecera(ByVal id_actividad As Integer) As Entidades.ActividadBE Implements Interfaces.IActividad.CargarActividadCabecera
            Dim oActividad As New ActividadBE
            Dim strConn As String = ConfigurationManager.ConnectionStrings("SGC").ConnectionString
            Dim sqlConn As New SqlConnection(strConn)
            Dim sqlCmd As New SqlCommand("comite.SP_CARGAR_ACTIVIDAD_CABECERA", sqlConn)
            Dim dr As SqlDataReader = Nothing
            sqlCmd.CommandType = CommandType.StoredProcedure
            sqlCmd.Parameters.Add("@id_actividad", SqlDbType.Int).Value = id_actividad

            Try
                sqlConn.Open()
                dr = sqlCmd.ExecuteReader()

                If dr.Read() Then
                    oActividad.id_actividad = dr("id_actividad")
                    oActividad.fec_ini = dr("fec_ini")
                    oActividad.fec_fin = IIf(dr("fec_fin") Is DBNull.Value, Nothing, dr("fec_fin"))
                    oActividad.hora_ini = dr.GetTimeSpan(3) 'dr("hora_ini")
                    oActividad.hora_fin = dr.GetTimeSpan(4) 'dr("hora_fin")
                    oActividad.monto_pago = dr("monto_pago")
                    oActividad.id_estado = dr("id_estado")
                    oActividad.id_cattipo_act = IIf(dr("id_cattipo_act") Is DBNull.Value, Nothing, dr("id_cattipo_act"))
                    oActividad.id_comite = dr("id_comite")
                    oActividad.id_tipo_act = dr("id_tipo_act")
                    oActividad.descripcion = dr("descripcion")
                    oActividad.nombre = dr("nombre")
                    oActividad.flg_plan_anual = dr("flg_plan_anual")
                    oActividad.flg_web = dr("flg_web")
                    oActividad.tipo_inscripcion = dr("tipo_inscripcion")
                End If
                dr.Close()
                Return oActividad
            Catch ex As System.Exception
                Throw ex
            Finally
                sqlConn.Close()
            End Try
        End Function

        Public Function ListarActividadesPlan(id_comite As String, id_plan As Integer?) As System.Collections.Generic.List(Of Entidades.ActividadBE) Implements Interfaces.IActividad.ListarActividadesPlan
            Dim oListadoActividades As New List(Of ActividadBE)
            Dim oActividad As ActividadBE
            Dim strConn As String = ConfigurationManager.ConnectionStrings("SGC").ConnectionString
            Dim sqlConn As New SqlConnection(strConn)
            Dim sqlCmd As New SqlCommand("comite.SP_LISTAR_ACTIVIDADES_PLAN", sqlConn)
            Dim dr As SqlDataReader = Nothing
            sqlCmd.CommandType = CommandType.StoredProcedure
            sqlCmd.Parameters.Add("@id_comite", SqlDbType.VarChar).Value = IIf(id_comite = "000", DBNull.Value, id_comite)
            sqlCmd.Parameters.Add("@id_plan", SqlDbType.VarChar).Value = IIf(id_plan Is Nothing, DBNull.Value, id_plan)

            Try
                sqlConn.Open()
                dr = sqlCmd.ExecuteReader()

                While dr.Read()
                    oActividad = New ActividadBE
                    oActividad.id_actividad = dr("id_actividad")
                    oActividad.nombre = dr("nombre")
                    oActividad.fec_ini = dr("fec_ini")
                    oActividad.fec_fin = IIf(dr("fec_fin") Is DBNull.Value, Nothing, dr("fec_fin"))
                    oActividad.monto_pago = dr("monto_pago")
                    oActividad.id_estado = dr("id_estado")
                    oActividad.id_cattipo_act = dr("id_cattipo_act")
                    oActividad.id_comite = dr("id_comite")
                    oActividad.id_tipo_act = dr("id_tipo_act")
                    oActividad.flg_plan_anual = dr("flg_plan_anual")
                    oActividad.id_plan = IIf(dr("id_plan") Is DBNull.Value, Nothing, dr("id_plan"))
                    oActividad.vacantes = dr("vacantes")
                    oActividad.nombrecomite = dr("nombreComite")
                    oListadoActividades.Add(oActividad)
                End While
                dr.Close()
                Return oListadoActividades
            Catch ex As System.Exception
                Throw ex
            Finally
                sqlConn.Close()
            End Try
        End Function

        Public Function ListarActividadesPendientesPGC(ByVal id_comite As String) As System.Collections.Generic.List(Of Entidades.ActividadBE) Implements Interfaces.IActividad.ListarActividadesPendientesPGC
            Dim oListadoActividades As New List(Of ActividadBE)
            Dim oActividad As ActividadBE
            Dim strConn As String = ConfigurationManager.ConnectionStrings("SGC").ConnectionString
            Dim sqlConn As New SqlConnection(strConn)
            Dim sqlCmd As New SqlCommand("comite.SP_LISTAR_ACTIVIDADES_PENDIENTES_PGC", sqlConn)
            Dim dr As SqlDataReader = Nothing
            sqlCmd.CommandType = CommandType.StoredProcedure
            sqlCmd.Parameters.Add("@id_comite", SqlDbType.VarChar).Value = id_comite

            Try
                sqlConn.Open()
                dr = sqlCmd.ExecuteReader()

                While dr.Read()
                    oActividad = New ActividadBE
                    oActividad.id_actividad = dr("id_actividad")
                    oActividad.nombre = dr("nombre")
                    oActividad.descripcion = dr("descripcion")
                    oActividad.id_tipo_act = dr("id_tipo_act")
                    oActividad.desc_tipo = dr("desc_tipo")
                    oActividad.id_cattipo_act = IIf(dr("id_cattipo_act") Is DBNull.Value, Nothing, dr("id_cattipo_act"))
                    oActividad.desc_cat = IIf(dr("desc_cat") Is DBNull.Value, Nothing, dr("desc_cat"))
                    oActividad.fec_ini = IIf(dr("fec_ini") Is DBNull.Value, Nothing, dr("fec_ini"))
                    oActividad.fec_fin = IIf(dr("fec_fin") Is DBNull.Value, Nothing, dr("fec_fin"))
                    oActividad.monto_pago = dr("monto_pago")
                    oActividad.vacantes = dr("vacantes")
                    oActividad.id_estado = dr("id_estado")
                    oActividad.desc_estado = dr("estado")
                    oListadoActividades.Add(oActividad)
                End While
                dr.Close()
                Return oListadoActividades
            Catch ex As System.Exception
                Throw ex
            Finally
                sqlConn.Close()
            End Try
        End Function

        Public Function ListarActividadesAprobadasPGC(ByVal id_comite As String) As System.Collections.Generic.List(Of Entidades.ActividadBE) Implements Interfaces.IActividad.ListarActividadesAprobadasPGC
            Dim oListadoActividades As New List(Of ActividadBE)
            Dim oActividad As ActividadBE
            Dim strConn As String = ConfigurationManager.ConnectionStrings("SGC").ConnectionString
            Dim sqlConn As New SqlConnection(strConn)
            Dim sqlCmd As New SqlCommand("comite.SP_LISTAR_ACTIVIDADES_APROBADAS_PGC", sqlConn)
            Dim dr As SqlDataReader = Nothing
            sqlCmd.CommandType = CommandType.StoredProcedure
            sqlCmd.Parameters.Add("@id_comite", SqlDbType.VarChar).Value = id_comite

            Try
                sqlConn.Open()
                dr = sqlCmd.ExecuteReader()

                While dr.Read()
                    oActividad = New ActividadBE
                    oActividad.id_actividad = dr("id_actividad")
                    oActividad.nombre = dr("nombre")
                    oActividad.descripcion = dr("descripcion")
                    oActividad.id_tipo_act = dr("id_tipo_act")
                    oActividad.desc_tipo = dr("desc_tipo")
                    oActividad.id_cattipo_act = IIf(dr("id_cattipo_act") Is DBNull.Value, Nothing, dr("id_cattipo_act"))
                    oActividad.desc_cat = IIf(dr("desc_cat") Is DBNull.Value, Nothing, dr("desc_cat"))
                    oActividad.fec_ini = IIf(dr("fec_ini") Is DBNull.Value, Nothing, dr("fec_ini"))
                    oActividad.fec_fin = IIf(dr("fec_fin") Is DBNull.Value, Nothing, dr("fec_fin"))
                    oActividad.monto_pago = dr("monto_pago")
                    oActividad.vacantes = dr("vacantes")
                    oActividad.id_estado = dr("id_estado")
                    oActividad.desc_estado = dr("estado")
                    oListadoActividades.Add(oActividad)
                End While
                dr.Close()
                Return oListadoActividades
            Catch ex As System.Exception
                Throw ex
            Finally
                sqlConn.Close()
            End Try
        End Function

        Public Function ListarActividadesRechazadasPGC(ByVal id_comite As String) As System.Collections.Generic.List(Of Entidades.ActividadBE) Implements Interfaces.IActividad.ListarActividadesRechazadasPGC
            Dim oListadoActividades As New List(Of ActividadBE)
            Dim oActividad As ActividadBE
            Dim strConn As String = ConfigurationManager.ConnectionStrings("SGC").ConnectionString
            Dim sqlConn As New SqlConnection(strConn)
            Dim sqlCmd As New SqlCommand("comite.SP_LISTAR_ACTIVIDADES_RECHAZADAS_PGC", sqlConn)
            Dim dr As SqlDataReader = Nothing
            sqlCmd.CommandType = CommandType.StoredProcedure
            sqlCmd.Parameters.Add("@id_comite", SqlDbType.VarChar).Value = id_comite

            Try
                sqlConn.Open()
                dr = sqlCmd.ExecuteReader()

                While dr.Read()
                    oActividad = New ActividadBE
                    oActividad.id_actividad = dr("id_actividad")
                    oActividad.nombre = dr("nombre")
                    oActividad.descripcion = dr("descripcion")
                    oActividad.id_tipo_act = dr("id_tipo_act")
                    oActividad.desc_tipo = dr("desc_tipo")
                    oActividad.id_cattipo_act = IIf(dr("id_cattipo_act") Is DBNull.Value, Nothing, dr("id_cattipo_act"))
                    oActividad.desc_cat = IIf(dr("desc_cat") Is DBNull.Value, Nothing, dr("desc_cat"))
                    oActividad.fec_ini = IIf(dr("fec_ini") Is DBNull.Value, Nothing, dr("fec_ini"))
                    oActividad.fec_fin = IIf(dr("fec_fin") Is DBNull.Value, Nothing, dr("fec_fin"))
                    oActividad.monto_pago = dr("monto_pago")
                    oActividad.vacantes = dr("vacantes")
                    oActividad.id_estado = dr("id_estado")
                    oActividad.desc_estado = dr("estado")
                    oListadoActividades.Add(oActividad)
                End While
                dr.Close()
                Return oListadoActividades
            Catch ex As System.Exception
                Throw ex
            Finally
                sqlConn.Close()
            End Try
        End Function

        Public Function ListarActividadesCD(ByVal id_comite As String) As System.Collections.Generic.List(Of Entidades.ActividadBE) Implements Interfaces.IActividad.ListarActividadesCD
            Dim oListadoActividades As New List(Of ActividadBE)
            Dim oActividad As ActividadBE
            Dim strConn As String = ConfigurationManager.ConnectionStrings("SGC").ConnectionString
            Dim sqlConn As New SqlConnection(strConn)
            Dim sqlCmd As New SqlCommand("comite.SP_LISTAR_ACTIVIDADES_CD", sqlConn)
            Dim dr As SqlDataReader = Nothing
            sqlCmd.CommandType = CommandType.StoredProcedure
            sqlCmd.Parameters.Add("@id_comite", SqlDbType.VarChar).Value = id_comite

            Try
                sqlConn.Open()
                dr = sqlCmd.ExecuteReader()

                While dr.Read()
                    oActividad = New ActividadBE
                    oActividad.id_actividad = dr("id_actividad")
                    oActividad.nombre = dr("nombre")
                    oActividad.descripcion = dr("descripcion")
                    oActividad.id_tipo_act = dr("id_tipo_act")
                    oActividad.desc_tipo = dr("desc_tipo")
                    oActividad.id_cattipo_act = IIf(dr("id_cattipo_act") Is DBNull.Value, Nothing, dr("id_cattipo_act"))
                    oActividad.desc_cat = IIf(dr("desc_cat") Is DBNull.Value, Nothing, dr("desc_cat"))
                    oActividad.fec_ini = IIf(dr("fec_ini") Is DBNull.Value, Nothing, dr("fec_ini"))
                    oActividad.fec_fin = IIf(dr("fec_fin") Is DBNull.Value, Nothing, dr("fec_fin"))
                    oActividad.monto_pago = dr("monto_pago")
                    oActividad.vacantes = dr("vacantes")
                    oActividad.id_estado = dr("id_estado")
                    oActividad.desc_estado = dr("estado")
                    oListadoActividades.Add(oActividad)
                End While
                dr.Close()
                Return oListadoActividades
            Catch ex As System.Exception
                Throw ex
            Finally
                sqlConn.Close()
            End Try
        End Function

        Public Function ListarActividadesGG(ByVal id_comite As String) As System.Collections.Generic.List(Of Entidades.ActividadBE) Implements Interfaces.IActividad.ListarActividadesGG
            Dim oListadoActividades As New List(Of ActividadBE)
            Dim oActividad As ActividadBE
            Dim strConn As String = ConfigurationManager.ConnectionStrings("SGC").ConnectionString
            Dim sqlConn As New SqlConnection(strConn)
            Dim sqlCmd As New SqlCommand("comite.SP_LISTAR_ACTIVIDADES_GG", sqlConn)
            Dim dr As SqlDataReader = Nothing
            sqlCmd.CommandType = CommandType.StoredProcedure
            sqlCmd.Parameters.Add("@id_comite", SqlDbType.VarChar).Value = id_comite

            Try
                sqlConn.Open()
                dr = sqlCmd.ExecuteReader()

                While dr.Read()
                    oActividad = New ActividadBE
                    oActividad.id_actividad = dr("id_actividad")
                    oActividad.nombre = dr("nombre")
                    oActividad.descripcion = dr("descripcion")
                    oActividad.id_tipo_act = dr("id_tipo_act")
                    oActividad.desc_tipo = dr("desc_tipo")
                    oActividad.id_cattipo_act = IIf(dr("id_cattipo_act") Is DBNull.Value, Nothing, dr("id_cattipo_act"))
                    oActividad.desc_cat = IIf(dr("desc_cat") Is DBNull.Value, Nothing, dr("desc_cat"))
                    oActividad.fec_ini = IIf(dr("fec_ini") Is DBNull.Value, Nothing, dr("fec_ini"))
                    oActividad.fec_fin = IIf(dr("fec_fin") Is DBNull.Value, Nothing, dr("fec_fin"))
                    oActividad.monto_pago = dr("monto_pago")
                    oActividad.vacantes = dr("vacantes")
                    oActividad.id_estado = dr("id_estado")
                    oActividad.desc_estado = dr("estado")
                    oListadoActividades.Add(oActividad)
                End While
                dr.Close()
                Return oListadoActividades
            Catch ex As System.Exception
                Throw ex
            Finally
                sqlConn.Close()
            End Try
        End Function
#End Region

#Region "Insert"

        Public Function InsertarActividad(ByRef oActividad As ActividadBE) As Integer Implements IActividad.InsertarActividad
            Dim strConn As String = ConfigurationManager.ConnectionStrings("SGC").ConnectionString
            Dim sqlConn As New SqlConnection(strConn)
            Dim sqlCmd As New SqlCommand("comite.SP_INSERTAR_ACTIVIDAD", sqlConn)

            Dim recordId As Integer = 0
            sqlCmd.CommandType = CommandType.StoredProcedure
            sqlCmd.Parameters.Add("@fec_ini", SqlDbType.DateTime).Value = IIf(oActividad.fec_ini Is Nothing, DBNull.Value, oActividad.fec_ini)
            sqlCmd.Parameters.Add("@fec_fin", SqlDbType.DateTime).Value = IIf(oActividad.fec_fin Is Nothing, DBNull.Value, oActividad.fec_fin)
            sqlCmd.Parameters.Add("@hora_ini", SqlDbType.Time).Value = IIf(oActividad.hora_ini Is Nothing, DBNull.Value, oActividad.hora_ini)
            sqlCmd.Parameters.Add("@hora_fin", SqlDbType.Time).Value = IIf(oActividad.hora_fin Is Nothing, DBNull.Value, oActividad.hora_fin)
            sqlCmd.Parameters.Add("@monto_pago", SqlDbType.Decimal).Value = IIf(oActividad.monto_pago Is Nothing, DBNull.Value, oActividad.monto_pago)
            sqlCmd.Parameters.Add("@id_estado", SqlDbType.VarChar).Value = IIf(oActividad.id_estado Is Nothing, DBNull.Value, oActividad.id_estado)
            sqlCmd.Parameters.Add("@id_cattipo_act", SqlDbType.Int).Value = IIf(oActividad.id_cattipo_act Is Nothing, DBNull.Value, oActividad.id_cattipo_act)
            sqlCmd.Parameters.Add("@id_comite", SqlDbType.NVarChar).Value = IIf(oActividad.id_comite Is Nothing, DBNull.Value, oActividad.id_comite)
            sqlCmd.Parameters.Add("@id_tipo_act", SqlDbType.VarChar).Value = IIf(oActividad.id_tipo_act Is Nothing, DBNull.Value, oActividad.id_tipo_act)
            sqlCmd.Parameters.Add("@descripcion", SqlDbType.VarChar).Value = IIf(oActividad.descripcion Is Nothing, DBNull.Value, oActividad.descripcion)
            sqlCmd.Parameters.Add("@nombre", SqlDbType.VarChar).Value = IIf(oActividad.nombre Is Nothing, DBNull.Value, oActividad.nombre)
            sqlCmd.Parameters.Add("@id_actividad_recurrente", SqlDbType.Int).Value = IIf(oActividad.id_actividad_recurrente Is Nothing, DBNull.Value, oActividad.id_actividad_recurrente)
            sqlCmd.Parameters.Add("@flg_plan_anual", SqlDbType.Bit).Value = IIf(oActividad.flg_plan_anual Is Nothing, False, oActividad.flg_plan_anual)
            sqlCmd.Parameters.Add("@flg_web", SqlDbType.Bit).Value = IIf(oActividad.flg_web Is Nothing, False, oActividad.flg_web)
            sqlCmd.Parameters.Add("@tipo_inscripcion", SqlDbType.Char).Value = IIf(oActividad.tipo_inscripcion Is Nothing, DBNull.Value, oActividad.tipo_inscripcion)
            sqlCmd.Parameters.Add("@id_plan", SqlDbType.Int).Value = IIf(oActividad.id_plan Is Nothing, DBNull.Value, oActividad.id_plan)
            sqlCmd.Parameters.Add("@vacantes", SqlDbType.Int).Value = IIf(oActividad.vacantes Is Nothing, DBNull.Value, oActividad.vacantes)

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

        Public Function InsertarTipoPersonalXActividad(ByRef oTipoPersonal As TipoPersonalBE) As Integer Implements IActividad.InsertarTipoPersonalXActividad
            Dim strConn As String = ConfigurationManager.ConnectionStrings("SGC").ConnectionString
            Dim sqlConn As New SqlConnection(strConn)
            Dim sqlCmd As New SqlCommand("comite.SP_INSERTAR_TIPOPERSONAL_X_ACTIVIDAD", sqlConn)

            Dim recordId As Integer = 0
            sqlCmd.CommandType = CommandType.StoredProcedure
            sqlCmd.Parameters.Add("@id_actividad", SqlDbType.Int).Value = oTipoPersonal.id_actividad
            sqlCmd.Parameters.Add("@id_tipo_personal", SqlDbType.Int).Value = oTipoPersonal.id_tipo_personal
            sqlCmd.Parameters.Add("@cantidad", SqlDbType.Int).Value = oTipoPersonal.cantidad

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

        Public Function InsertarRecursoXActividad(ByRef oRecurso As RecursoBE) As Integer Implements IActividad.InsertarRecursoXActividad
            Dim strConn As String = ConfigurationManager.ConnectionStrings("SGC").ConnectionString
            Dim sqlConn As New SqlConnection(strConn)
            Dim sqlCmd As New SqlCommand("comite.SP_INSERTAR_RECURSO_X_ACTIVIDAD", sqlConn)

            Dim recordId As Integer = 0
            sqlCmd.CommandType = CommandType.StoredProcedure
            sqlCmd.Parameters.Add("@id_actividad", SqlDbType.Int).Value = oRecurso.id_actividad
            sqlCmd.Parameters.Add("@id_recurso", SqlDbType.Int).Value = oRecurso.id_recurso
            sqlCmd.Parameters.Add("@cantidad", SqlDbType.Int).Value = oRecurso.cantidad

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

        Public Function InsertarRestriccionXActividad(ByRef oRestriccion As RestriccionesBE) As Integer Implements IActividad.InsertarRestriccionXActividad
            Dim strConn As String = ConfigurationManager.ConnectionStrings("SGC").ConnectionString
            Dim sqlConn As New SqlConnection(strConn)
            Dim sqlCmd As New SqlCommand("comite.SP_INSERTAR_RESTRICCION_X_ACTIVIDAD", sqlConn)

            Dim recordId As Integer = 0
            sqlCmd.CommandType = CommandType.StoredProcedure
            sqlCmd.Parameters.Add("@id_restriccion", SqlDbType.Int).Value = oRestriccion.id_restriccion
            sqlCmd.Parameters.Add("@id_actividad", SqlDbType.Int).Value = oRestriccion.id_actividad
            sqlCmd.Parameters.Add("@id_signo", SqlDbType.Int).Value = IIf(oRestriccion.id_signo = Nothing, DBNull.Value, oRestriccion.id_signo)
            sqlCmd.Parameters.Add("@valor", SqlDbType.VarChar).Value = IIf(oRestriccion.valor Is Nothing, DBNull.Value, oRestriccion.valor)

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

        Public Function InsertarActividadesPlanXML(ByRef oPlan As PlanAnualBE) As Boolean Implements Interfaces.IActividad.InsertarActividadesPlanXML

            Dim strConn As String = ConfigurationManager.ConnectionStrings("SGC").ConnectionString
            Dim sqlConn As New SqlConnection(strConn)
            Dim sqlCmd As New SqlCommand("COMITE.USP_INSERTAR_ACTIVIDADES_PLAN_XML", sqlConn)

            Dim recordId As String = ""
            sqlCmd.CommandType = CommandType.StoredProcedure
            sqlCmd.Parameters.Add("@idPlan", SqlDbType.Int).Value = oPlan.id_plan
            sqlCmd.Parameters.Add("@XMLActividades", SqlDbType.Xml).Value = oPlan.GetActividadesPlanXML


            Try
                sqlConn.Open()
                recordId = sqlCmd.ExecuteScalar()

                Return True
            Catch ex As System.Exception
                Throw ex
                Return False
            Finally
                sqlConn.Close()
            End Try

        End Function

#End Region

#Region "Update"

        Public Function ActualizarActividad(ByRef oActividad As Entidades.ActividadBE) As Integer Implements Interfaces.IActividad.ActualizarActividad
            Dim strConn As String = ConfigurationManager.ConnectionStrings("SGC").ConnectionString
            Dim sqlConn As New SqlConnection(strConn)
            Dim sqlCmd As New SqlCommand("comite.SP_ACTUALIZAR_ACTIVIDAD", sqlConn)

            Dim affectedRows As Integer = 0
            sqlCmd.CommandType = CommandType.StoredProcedure
            sqlCmd.Parameters.Add("@id_actividad", SqlDbType.Int).Value = oActividad.id_actividad
            sqlCmd.Parameters.Add("@fec_ini", SqlDbType.DateTime).Value = IIf(oActividad.fec_ini Is Nothing, DBNull.Value, oActividad.fec_ini)
            sqlCmd.Parameters.Add("@fec_fin", SqlDbType.DateTime).Value = IIf(oActividad.fec_fin Is Nothing, DBNull.Value, oActividad.fec_fin)
            sqlCmd.Parameters.Add("@hora_ini", SqlDbType.Time).Value = IIf(oActividad.hora_ini Is Nothing, DBNull.Value, oActividad.hora_ini)
            sqlCmd.Parameters.Add("@hora_fin", SqlDbType.Time).Value = IIf(oActividad.hora_fin Is Nothing, DBNull.Value, oActividad.hora_fin)
            sqlCmd.Parameters.Add("@monto_pago", SqlDbType.Decimal).Value = IIf(oActividad.monto_pago Is Nothing, DBNull.Value, oActividad.monto_pago)
            sqlCmd.Parameters.Add("@id_cattipo_act", SqlDbType.Int).Value = IIf(oActividad.id_cattipo_act Is Nothing, DBNull.Value, oActividad.id_cattipo_act)
            sqlCmd.Parameters.Add("@id_comite", SqlDbType.NVarChar).Value = IIf(oActividad.id_comite Is Nothing, DBNull.Value, oActividad.id_comite)
            sqlCmd.Parameters.Add("@id_tipo_act", SqlDbType.VarChar).Value = IIf(oActividad.id_tipo_act Is Nothing, DBNull.Value, oActividad.id_tipo_act)
            sqlCmd.Parameters.Add("@descripcion", SqlDbType.VarChar).Value = IIf(oActividad.descripcion Is Nothing, DBNull.Value, oActividad.descripcion)
            sqlCmd.Parameters.Add("@nombre", SqlDbType.VarChar).Value = IIf(oActividad.nombre Is Nothing, DBNull.Value, oActividad.nombre)
            sqlCmd.Parameters.Add("@id_actividad_recurrente", SqlDbType.Int).Value = IIf(oActividad.id_actividad_recurrente Is Nothing, DBNull.Value, oActividad.id_actividad_recurrente)
            sqlCmd.Parameters.Add("@flg_plan_anual", SqlDbType.Bit).Value = IIf(oActividad.flg_plan_anual Is Nothing, False, oActividad.flg_plan_anual)
            sqlCmd.Parameters.Add("@flg_web", SqlDbType.Bit).Value = IIf(oActividad.flg_web Is Nothing, False, oActividad.flg_web)
            sqlCmd.Parameters.Add("@tipo_inscripcion", SqlDbType.Char).Value = IIf(oActividad.tipo_inscripcion Is Nothing, DBNull.Value, oActividad.tipo_inscripcion)
            sqlCmd.Parameters.Add("@id_plan", SqlDbType.Int).Value = IIf(oActividad.id_plan Is Nothing, DBNull.Value, oActividad.id_plan)
            sqlCmd.Parameters.Add("@vacantes", SqlDbType.Int).Value = IIf(oActividad.vacantes Is Nothing, DBNull.Value, oActividad.vacantes)

            Try
                sqlConn.Open()
                affectedRows = sqlCmd.ExecuteNonQuery

                Return affectedRows
            Catch ex As System.Exception
                Throw ex
            Finally
                sqlConn.Close()
            End Try
        End Function

        Public Function ActualizarActividadEstado(ByRef oActividad As Entidades.ActividadBE) As Integer Implements Interfaces.IActividad.ActualizarActividadEstado
            Dim strConn As String = ConfigurationManager.ConnectionStrings("SGC").ConnectionString
            Dim sqlConn As New SqlConnection(strConn)
            Dim sqlCmd As New SqlCommand("comite.SP_ACTUALIZAR_ACTIVIDAD_ESTADO", sqlConn)

            Dim affectedRows As Integer = 0
            sqlCmd.CommandType = CommandType.StoredProcedure
            sqlCmd.Parameters.Add("@id_actividad", SqlDbType.Int).Value = oActividad.id_actividad
            sqlCmd.Parameters.Add("@id_estado", SqlDbType.VarChar).Value = oActividad.id_estado

            Try
                sqlConn.Open()
                affectedRows = sqlCmd.ExecuteNonQuery

                Return affectedRows
            Catch ex As System.Exception
                Throw ex
            Finally
                sqlConn.Close()
            End Try
        End Function

#End Region

#Region "Delete"

        Public Function BorrarActividad(ByVal id_actividad As Integer) As Integer Implements Interfaces.IActividad.BorrarActividad
            Dim strConn As String = ConfigurationManager.ConnectionStrings("SGC").ConnectionString
            Dim sqlConn As New SqlConnection(strConn)
            Dim sqlCmd As New SqlCommand("comite.SP_BORRAR_ACTIVIDAD", sqlConn)

            Dim affectedRows As Integer = 0
            sqlCmd.CommandType = CommandType.StoredProcedure
            sqlCmd.Parameters.Add("@id_actividad", SqlDbType.Int).Value = id_actividad

            Try
                sqlConn.Open()
                affectedRows = sqlCmd.ExecuteNonQuery

                Return affectedRows
            Catch ex As System.Exception
                Throw ex
            Finally
                sqlConn.Close()
            End Try
        End Function

        Public Function BorrarTipoPersonalXActividad(ByVal id_actividad As Integer) As Integer Implements Interfaces.IActividad.BorrarTipoPersonalXActividad
            Dim strConn As String = ConfigurationManager.ConnectionStrings("SGC").ConnectionString
            Dim sqlConn As New SqlConnection(strConn)
            Dim sqlCmd As New SqlCommand("comite.SP_BORRAR_TIPOPERSONAL_X_ACTIVIDAD", sqlConn)

            Dim affectedRows As Integer = 0
            sqlCmd.CommandType = CommandType.StoredProcedure
            sqlCmd.Parameters.Add("@id_actividad", SqlDbType.Int).Value = id_actividad

            Try
                sqlConn.Open()
                affectedRows = sqlCmd.ExecuteNonQuery

                Return affectedRows
            Catch ex As System.Exception
                Throw ex
            Finally
                sqlConn.Close()
            End Try
        End Function

        Public Function BorrarRecursosXActividad(ByVal id_actividad As Integer) As Integer Implements Interfaces.IActividad.BorrarRecursosXActividad
            Dim strConn As String = ConfigurationManager.ConnectionStrings("SGC").ConnectionString
            Dim sqlConn As New SqlConnection(strConn)
            Dim sqlCmd As New SqlCommand("comite.SP_BORRAR_RECURSO_X_ACTIVIDAD", sqlConn)

            Dim affectedRows As Integer = 0
            sqlCmd.CommandType = CommandType.StoredProcedure
            sqlCmd.Parameters.Add("@id_actividad", SqlDbType.Int).Value = id_actividad

            Try
                sqlConn.Open()
                affectedRows = sqlCmd.ExecuteNonQuery

                Return affectedRows
            Catch ex As System.Exception
                Throw ex
            Finally
                sqlConn.Close()
            End Try
        End Function

        Public Function BorrarRestriccionesXActividad(ByVal id_actividad As Integer) As Integer Implements Interfaces.IActividad.BorrarRestriccionesXActividad
            Dim strConn As String = ConfigurationManager.ConnectionStrings("SGC").ConnectionString
            Dim sqlConn As New SqlConnection(strConn)
            Dim sqlCmd As New SqlCommand("comite.SP_BORRAR_RESTRICCION_X_ACTIVIDAD", sqlConn)

            Dim affectedRows As Integer = 0
            sqlCmd.CommandType = CommandType.StoredProcedure
            sqlCmd.Parameters.Add("@id_actividad", SqlDbType.Int).Value = id_actividad

            Try
                sqlConn.Open()
                affectedRows = sqlCmd.ExecuteNonQuery

                Return affectedRows
            Catch ex As System.Exception
                Throw ex
            Finally
                sqlConn.Close()
            End Try
        End Function

#End Region

    End Class
End Namespace

