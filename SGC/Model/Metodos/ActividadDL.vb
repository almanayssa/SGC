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

        Public Function ListarActividades(ByVal id_comite As String, ByVal id_tipo_act As String, ByVal fec_ini As DateTime, ByVal fec_fin As DateTime) As System.Collections.Generic.List(Of Entidades.ActividadBE) Implements Interfaces.IActividad.ListarActividades
            Dim oListadoActividades As New List(Of ActividadBE)
            Dim oActividad As ActividadBE
            Dim strConn As String = ConfigurationManager.ConnectionStrings("SGC").ConnectionString
            Dim sqlConn As New SqlConnection(strConn)
            Dim sqlCmd As New SqlCommand("comite.SP_LISTAR_ACTIVIDADES", sqlConn)
            Dim dr As SqlDataReader = Nothing
            sqlCmd.CommandType = CommandType.StoredProcedure
            sqlCmd.Parameters.Add("@id_comite", SqlDbType.VarChar).Value = IIf(id_comite = "000", Nothing, id_comite)
            sqlCmd.Parameters.Add("@id_tipo_act", SqlDbType.VarChar).Value = IIf(id_tipo_act = "00", Nothing, id_tipo_act)
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
                    oActividad.fecha = IIf(dr("fecha") Is DBNull.Value, Nothing, dr("fecha"))
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

        Public Function ListarActividadesBusqueda(ByVal id_comite As String, ByVal nombre As String, ByVal id_estado As String) As System.Collections.Generic.List(Of Entidades.ActividadBE) Implements Interfaces.IActividad.ListarActividadesBusqueda
            Dim oListadoActividades As New List(Of ActividadBE)
            Dim oActividad As ActividadBE
            Dim strConn As String = ConfigurationManager.ConnectionStrings("SGC").ConnectionString
            Dim sqlConn As New SqlConnection(strConn)
            Dim sqlCmd As New SqlCommand("comite.SP_LISTAR_ACTIVIDADES_BUSQUEDA", sqlConn)
            Dim dr As SqlDataReader = Nothing
            sqlCmd.CommandType = CommandType.StoredProcedure
            sqlCmd.Parameters.Add("@id_comite", SqlDbType.VarChar).Value = id_comite
            sqlCmd.Parameters.Add("@nombre", SqlDbType.VarChar).Value = nombre
            sqlCmd.Parameters.Add("@id_estado", SqlDbType.VarChar).Value = id_estado

            Try
                sqlConn.Open()
                dr = sqlCmd.ExecuteReader()

                While dr.Read()
                    oActividad = New ActividadBE
                    oActividad.id_actividad = dr("id_actividad")
                    oActividad.nombre = dr("nombre")
                    oActividad.fecha = IIf(dr("fecha") Is DBNull.Value, Nothing, dr("fecha"))
                    oActividad.hora_ini = IIf(dr("hora_ini") Is DBNull.Value, Nothing, dr("hora_ini"))
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
                    oActividad.fecha = dr("fecha")
                    oActividad.hora_ini = dr.GetTimeSpan(3) 'dr("hora_ini")
                    oActividad.hora_fin = dr("hora_fin") 'dr.GetTimeSpan(4)
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
                    oActividad.id_actividad_recurrente = IIf(dr("id_actividad_recurrente") Is DBNull.Value, Nothing, dr("id_actividad_recurrente"))
                    oActividad.vacantes = dr("vacantes")
                    oActividad.desc_tipo = dr("desc_tipo")
                    oActividad.desc_cat = IIf(dr("desc_cat") Is DBNull.Value, Nothing, dr("desc_cat"))
                    oActividad.nombrecomite = dr("nombrecomite")
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
                    oActividad.fecha = dr("fecha")
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
                    oActividad.fecha = IIf(dr("fecha") Is DBNull.Value, Nothing, dr("fecha"))
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
                    oActividad.fecha = IIf(dr("fecha") Is DBNull.Value, Nothing, dr("fecha"))
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
                    oActividad.fecha = IIf(dr("fecha") Is DBNull.Value, Nothing, dr("fecha"))
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
                    oActividad.fecha = IIf(dr("fecha") Is DBNull.Value, Nothing, dr("fecha"))
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
                    oActividad.fecha = IIf(dr("fecha") Is DBNull.Value, Nothing, dr("fecha"))
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

        Public Function ListarActividadesCalendario(ByVal diaCalendario As Date, ByVal diaInicio As Date, ByVal diaFin As Date) As System.Collections.Generic.List(Of Entidades.ActividadBE) Implements Interfaces.IActividad.ListarActividadesCalendario
            Dim oListadoActividades As New List(Of ActividadBE)
            Dim oActividad As ActividadBE
            Dim strConn As String = ConfigurationManager.ConnectionStrings("SGC").ConnectionString
            Dim sqlConn As New SqlConnection(strConn)

            Dim sqlCmd As New SqlCommand("comite.SP_LISTAR_ACTIVIDADES_CALENDARIO", sqlConn)
            Dim dr As SqlDataReader = Nothing

            sqlCmd.CommandType = CommandType.StoredProcedure
            sqlCmd.Parameters.Add("@diaCalendario", SqlDbType.Date).Value = IIf(diaCalendario = Nothing, DBNull.Value, diaCalendario)
            sqlCmd.Parameters.Add("@diaInicio", SqlDbType.Date).Value = IIf(diaInicio = Nothing, DBNull.Value, diaInicio)
            sqlCmd.Parameters.Add("@diaFin", SqlDbType.Date).Value = IIf(diaFin = Nothing, DBNull.Value, diaFin)

            Try
                sqlConn.Open()
                dr = sqlCmd.ExecuteReader()

                While dr.Read()
                    oActividad = New ActividadBE
                    oActividad.id_actividad = dr("id_actividad")
                    oActividad.fecha = dr("fecha")
                    oActividad.hora_ini = dr.GetTimeSpan(3) 'dr("hora_ini")
                    oActividad.hora_fin = dr.GetTimeSpan(4) 'dr("hora_fin")
                    oActividad.monto_pago = dr("monto_pago")
                    oActividad.descripcion = dr("descripcion")
                    oActividad.nombre = dr("nombre")
                    oActividad.id_actividad_recurrente = IIf(dr("id_actividad_recurrente") Is DBNull.Value, Nothing, dr("id_actividad_recurrente"))
                    oActividad.flg_web = dr("flg_web")
                    oActividad.tipo_inscripcion = dr("tipo_inscripcion")
                    oActividad.nombrecomite = dr("nom_comite")
                    oActividad.desc_tipo = dr("tipo_act")
                    oActividad.desc_cat = IIf(dr("cat_act") Is DBNull.Value, Nothing, dr("cat_act"))

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
            sqlCmd.Parameters.Add("@fecha", SqlDbType.DateTime).Value = IIf(oActividad.fecha Is Nothing, DBNull.Value, oActividad.fecha)
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

        Public Function InsertarActividadDetalle(ByRef oActividadDetalle As ActividadDetalleBE) As Integer Implements IActividad.InsertarActividadDetalle
            Dim strConn As String = ConfigurationManager.ConnectionStrings("SGC").ConnectionString
            Dim sqlConn As New SqlConnection(strConn)
            Dim sqlCmd As New SqlCommand("comite.SP_INSERTAR_ACTIVIDAD_DETALLE", sqlConn)

            Dim recordId As Integer = 0
            sqlCmd.CommandType = CommandType.StoredProcedure
            sqlCmd.Parameters.Add("@id_actividad", SqlDbType.Int).Value = oActividadDetalle.id_actividad
            sqlCmd.Parameters.Add("@fecha", SqlDbType.DateTime).Value = oActividadDetalle.fecha
            sqlCmd.Parameters.Add("@hora_ini", SqlDbType.Time).Value = oActividadDetalle.hora_ini
            'sqlCmd.Parameters.Add("@fecha_fin", SqlDbType.DateTime).Value = oActividadDetalle.fecha_fin
            sqlCmd.Parameters.Add("@hora_fin", SqlDbType.Time).Value = oActividadDetalle.hora_fin
            sqlCmd.Parameters.Add("@id_sede", SqlDbType.VarChar).Value = oActividadDetalle.id_sede
            sqlCmd.Parameters.Add("@id_espacio", SqlDbType.Int).Value = oActividadDetalle.id_espacio
            sqlCmd.Parameters.Add("@vacantes", SqlDbType.Int).Value = oActividadDetalle.vacantes

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
            sqlCmd.Parameters.Add("@cantidad_real", SqlDbType.Int).Value = oRecurso.cantidad_real

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

        Public Function InsertarPersonalXActividad(ByRef oPersonal As PersonalBE) As Integer Implements IActividad.InsertarPersonalXActividad
            Dim strConn As String = ConfigurationManager.ConnectionStrings("SGC").ConnectionString
            Dim sqlConn As New SqlConnection(strConn)
            Dim sqlCmd As New SqlCommand("comite.SP_INSERTAR_PERSONAL_X_ACTIVIDAD", sqlConn)

            Dim recordId As Integer = 0
            sqlCmd.CommandType = CommandType.StoredProcedure
            sqlCmd.Parameters.Add("@id_personal", SqlDbType.Int).Value = oPersonal.id_personal
            sqlCmd.Parameters.Add("@id_actividad", SqlDbType.Int).Value = oPersonal.id_actividad

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

#Region "Update"

        Public Function ActualizarActividad(ByRef oActividad As Entidades.ActividadBE) As Integer Implements Interfaces.IActividad.ActualizarActividad
            Dim strConn As String = ConfigurationManager.ConnectionStrings("SGC").ConnectionString
            Dim sqlConn As New SqlConnection(strConn)
            Dim sqlCmd As New SqlCommand("comite.SP_ACTUALIZAR_ACTIVIDAD", sqlConn)

            Dim affectedRows As Integer = 0
            sqlCmd.CommandType = CommandType.StoredProcedure
            sqlCmd.Parameters.Add("@id_actividad", SqlDbType.Int).Value = oActividad.id_actividad
            sqlCmd.Parameters.Add("@fecha", SqlDbType.DateTime).Value = IIf(oActividad.fecha Is Nothing, DBNull.Value, oActividad.fecha)
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

        Public Function ActualizarActividadEstadoPlan(ByVal id_plan As Integer, ByVal id_estado As String) As Integer Implements Interfaces.IActividad.ActualizarActividadEstadoPlan
            Dim strConn As String = ConfigurationManager.ConnectionStrings("SGC").ConnectionString
            Dim sqlConn As New SqlConnection(strConn)
            Dim sqlCmd As New SqlCommand("comite.SP_ACTUALIZAR_ACTIVIDAD_ESTADO_PLAN", sqlConn)

            Dim affectedRows As Integer = 0
            sqlCmd.CommandType = CommandType.StoredProcedure
            sqlCmd.Parameters.Add("@id_plan", SqlDbType.Int).Value = id_plan
            sqlCmd.Parameters.Add("@id_estado", SqlDbType.VarChar).Value = id_estado

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

        Public Function BorrarActividadDetalle(ByVal id_actividad As Integer) As Integer Implements Interfaces.IActividad.BorrarActividadDetalle
            Dim strConn As String = ConfigurationManager.ConnectionStrings("SGC").ConnectionString
            Dim sqlConn As New SqlConnection(strConn)
            Dim sqlCmd As New SqlCommand("comite.SP_BORRAR_ACTIVIDAD_DETALLE", sqlConn)

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

        Public Function BorrarPersonalXActividad(ByVal id_actividad As Integer) As Integer Implements Interfaces.IActividad.BorrarPersonalXActividad
            Dim strConn As String = ConfigurationManager.ConnectionStrings("SGC").ConnectionString
            Dim sqlConn As New SqlConnection(strConn)
            Dim sqlCmd As New SqlCommand("comite.SP_BORRAR_PERSONAL_X_ACTIVIDAD", sqlConn)

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

