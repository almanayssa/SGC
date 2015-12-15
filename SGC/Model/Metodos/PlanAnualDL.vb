Imports SGC.Model
Imports SGC.Model.Entidades
Imports SGC.Model.Interfaces
Imports System.Configuration
Imports System.Data.SqlClient

Public Class PlanAnualDL
    Implements IPlanAnual


#Region "Select"

    Public Function ListarPlanes(ByRef oPlanFiltro As PlanAnualBE) As System.Collections.Generic.List(Of Entidades.PlanAnualBE) Implements Interfaces.IPlanAnual.ListarPlanes
        Dim oListadoPlanes As New List(Of PlanAnualBE)
        Dim oPlan As PlanAnualBE
        Dim strConn As String = ConfigurationManager.ConnectionStrings("SGC").ConnectionString
        Dim sqlConn As New SqlConnection(strConn)
        Dim sqlCmd As New SqlCommand("comite.SP_LISTAR_PLAN_ANUAL", sqlConn)
        Dim dr As SqlDataReader = Nothing
        sqlCmd.CommandType = CommandType.StoredProcedure
        sqlCmd.Parameters.Add("@id_comite", SqlDbType.NVarChar).Value = oPlanFiltro.id_comite
        sqlCmd.Parameters.Add("@anio", SqlDbType.VarChar).Value = oPlanFiltro.anio

        Try
            sqlConn.Open()
            dr = sqlCmd.ExecuteReader()

            While dr.Read()
                oPlan = New PlanAnualBE
                oPlan.id_plan = dr("id_plan")
                oPlan.descripcion = dr("descripcion")
                oPlan.id_comite = dr("id_comite")
                oPlan.comite = dr("comite")
                oPlan.anio = dr("anio")
                oPlan.fec_ini = dr("fec_ini")
                oPlan.fec_fin = dr("fec_fin")
                oPlan.id_estado = dr("id_estado")
                oPlan.estado = dr("estado")
                oListadoPlanes.Add(oPlan)
            End While
            dr.Close()
            Return oListadoPlanes
        Catch ex As System.Exception
            Throw ex
        Finally
            sqlConn.Close()
        End Try
    End Function

    Public Function ObtenerPlan(id_plan As String) As SGC.Model.Entidades.PlanAnualBE Implements SGC.Model.Interfaces.IPlanAnual.ObtenerPlan

        Dim oPlan As New PlanAnualBE
        Dim strConn As String = ConfigurationManager.ConnectionStrings("SGC").ConnectionString
        Dim sqlConn As New SqlConnection(strConn)
        Dim sqlCmd As New SqlCommand("comite.SP_OBTENER_PLAN_ANUAL", sqlConn)
        Dim dr As SqlDataReader = Nothing
        sqlCmd.CommandType = CommandType.StoredProcedure
        sqlCmd.Parameters.Add("@id_plan", SqlDbType.Int).Value = id_plan

        Try
            sqlConn.Open()
            dr = sqlCmd.ExecuteReader()

            If dr.Read() Then
                oPlan = New PlanAnualBE
                oPlan.id_plan = dr("id_plan")
                oPlan.id_comite = dr("id_comite")
                oPlan.anio = dr("anio")
                oPlan.fec_ini = IIf(dr("fec_ini") Is DBNull.Value, Nothing, dr("fec_ini"))
                oPlan.fec_fin = IIf(dr("fec_fin") Is DBNull.Value, Nothing, dr("fec_fin"))
                oPlan.id_estado = dr("id_estado")
                oPlan.estado = dr("estado")

            End If
            dr.Close()
            Return oPlan
        Catch ex As System.Exception
            Throw ex
        Finally
            sqlConn.Close()
        End Try

    End Function

    Public Function ListarPlanesPendientesPGC(id_comite As String, anio As String) As System.Collections.Generic.List(Of SGC.Model.Entidades.PlanAnualBE) Implements SGC.Model.Interfaces.IPlanAnual.ListarPlanesPendientesPGC
        Dim oListadoPlanes As New List(Of PlanAnualBE)
        Dim oPlanAnual As PlanAnualBE
        Dim strConn As String = ConfigurationManager.ConnectionStrings("SGC").ConnectionString
        Dim sqlConn As New SqlConnection(strConn)
        Dim sqlCmd As New SqlCommand("comite.SP_LISTAR_PLANES_PENDIENTES_PGC", sqlConn)
        Dim dr As SqlDataReader = Nothing
        sqlCmd.CommandType = CommandType.StoredProcedure
        sqlCmd.Parameters.Add("@id_comite", SqlDbType.VarChar).Value = id_comite
        sqlCmd.Parameters.Add("@anio", SqlDbType.VarChar).Value = anio

        Try
            sqlConn.Open()
            dr = sqlCmd.ExecuteReader()

            While dr.Read()
                oPlanAnual = New PlanAnualBE
                oPlanAnual.id_plan = dr("id_plan")
                oPlanAnual.descripcion = dr("descripcion")
                oPlanAnual.id_comite = dr("id_comite")
                oPlanAnual.comite = dr("comite")
                oPlanAnual.anio = dr("anio")
                oPlanAnual.fec_ini = IIf(dr("fec_ini") Is DBNull.Value, Nothing, dr("fec_ini"))
                oPlanAnual.fec_fin = IIf(dr("fec_fin") Is DBNull.Value, Nothing, dr("fec_fin"))
                oPlanAnual.id_estado = dr("id_estado")
                oPlanAnual.estado = dr("estado")
                oListadoPlanes.Add(oPlanAnual)
            End While
            dr.Close()
            Return oListadoPlanes
        Catch ex As System.Exception
            Throw ex
        Finally
            sqlConn.Close()
        End Try
    End Function

    Public Function ListarPlanesAprobadosPGC(id_comite As String, anio As String) As System.Collections.Generic.List(Of SGC.Model.Entidades.PlanAnualBE) Implements SGC.Model.Interfaces.IPlanAnual.ListarPlanesAprobadosPGC
        Dim oListadoPlanes As New List(Of PlanAnualBE)
        Dim oPlanAnual As PlanAnualBE
        Dim strConn As String = ConfigurationManager.ConnectionStrings("SGC").ConnectionString
        Dim sqlConn As New SqlConnection(strConn)
        Dim sqlCmd As New SqlCommand("comite.SP_LISTAR_PLANES_APROBADAS_PGC", sqlConn)
        Dim dr As SqlDataReader = Nothing
        sqlCmd.CommandType = CommandType.StoredProcedure
        sqlCmd.Parameters.Add("@id_comite", SqlDbType.VarChar).Value = id_comite
        sqlCmd.Parameters.Add("@anio", SqlDbType.VarChar).Value = anio

        Try
            sqlConn.Open()
            dr = sqlCmd.ExecuteReader()

            While dr.Read()
                oPlanAnual = New PlanAnualBE
                oPlanAnual.id_plan = dr("id_plan")
                oPlanAnual.descripcion = dr("descripcion")
                oPlanAnual.id_comite = dr("id_comite")
                oPlanAnual.comite = dr("comite")
                oPlanAnual.anio = dr("anio")
                oPlanAnual.fec_ini = IIf(dr("fec_ini") Is DBNull.Value, Nothing, dr("fec_ini"))
                oPlanAnual.fec_fin = IIf(dr("fec_fin") Is DBNull.Value, Nothing, dr("fec_fin"))
                oPlanAnual.id_estado = dr("id_estado")
                oPlanAnual.estado = dr("estado")
                oListadoPlanes.Add(oPlanAnual)

            End While
            dr.Close()
            Return oListadoPlanes
        Catch ex As System.Exception
            Throw ex
        Finally
            sqlConn.Close()
        End Try
    End Function

    Public Function ListarPlanesRechazadosPGC(id_comite As String, anio As String) As System.Collections.Generic.List(Of SGC.Model.Entidades.PlanAnualBE) Implements SGC.Model.Interfaces.IPlanAnual.ListarPlanesRechazadosPGC
        Dim oListadoPlanes As New List(Of PlanAnualBE)
        Dim oPlanAnual As PlanAnualBE
        Dim strConn As String = ConfigurationManager.ConnectionStrings("SGC").ConnectionString
        Dim sqlConn As New SqlConnection(strConn)
        Dim sqlCmd As New SqlCommand("comite.SP_LISTAR_PLANES_RECHAZADAS_PGC", sqlConn)
        Dim dr As SqlDataReader = Nothing
        sqlCmd.CommandType = CommandType.StoredProcedure
        sqlCmd.Parameters.Add("@id_comite", SqlDbType.VarChar).Value = id_comite
        sqlCmd.Parameters.Add("@anio", SqlDbType.VarChar).Value = anio

        Try
            sqlConn.Open()
            dr = sqlCmd.ExecuteReader()

            While dr.Read()
                oPlanAnual = New PlanAnualBE
                oPlanAnual.id_plan = dr("id_plan")
                oPlanAnual.descripcion = dr("descripcion")
                oPlanAnual.id_comite = dr("id_comite")
                oPlanAnual.comite = dr("comite")
                oPlanAnual.anio = dr("anio")
                oPlanAnual.fec_ini = IIf(dr("fec_ini") Is DBNull.Value, Nothing, dr("fec_ini"))
                oPlanAnual.fec_fin = IIf(dr("fec_fin") Is DBNull.Value, Nothing, dr("fec_fin"))
                oPlanAnual.id_estado = dr("id_estado")
                oPlanAnual.estado = dr("estado")
                oListadoPlanes.Add(oPlanAnual)

            End While
            dr.Close()
            Return oListadoPlanes
        Catch ex As System.Exception
            Throw ex
        Finally
            sqlConn.Close()
        End Try
    End Function

    Public Function ListarPlanesCD(id_comite As String, anio As String) As System.Collections.Generic.List(Of SGC.Model.Entidades.PlanAnualBE) Implements SGC.Model.Interfaces.IPlanAnual.ListarPlanesCD
        Dim oListadoPlanes As New List(Of PlanAnualBE)
        Dim oPlanAnual As PlanAnualBE
        Dim strConn As String = ConfigurationManager.ConnectionStrings("SGC").ConnectionString
        Dim sqlConn As New SqlConnection(strConn)
        Dim sqlCmd As New SqlCommand("comite.SP_LISTAR_PLANES_CD", sqlConn)
        Dim dr As SqlDataReader = Nothing
        sqlCmd.CommandType = CommandType.StoredProcedure
        sqlCmd.Parameters.Add("@id_comite", SqlDbType.VarChar).Value = id_comite
        sqlCmd.Parameters.Add("@anio", SqlDbType.VarChar).Value = anio

        Try
            sqlConn.Open()
            dr = sqlCmd.ExecuteReader()

            While dr.Read()
                oPlanAnual = New PlanAnualBE
                oPlanAnual.id_plan = dr("id_plan")
                oPlanAnual.descripcion = dr("descripcion")
                oPlanAnual.id_comite = dr("id_comite")
                oPlanAnual.comite = dr("comite")
                oPlanAnual.anio = dr("anio")
                oPlanAnual.fec_ini = IIf(dr("fec_ini") Is DBNull.Value, Nothing, dr("fec_ini"))
                oPlanAnual.fec_fin = IIf(dr("fec_fin") Is DBNull.Value, Nothing, dr("fec_fin"))
                oPlanAnual.id_estado = dr("id_estado")
                oPlanAnual.estado = dr("estado")
                oListadoPlanes.Add(oPlanAnual)
            End While
            dr.Close()
            Return oListadoPlanes
        Catch ex As System.Exception
            Throw ex
        Finally
            sqlConn.Close()
        End Try
    End Function

#End Region

#Region "Insert"

    Public Function InsertarPlanAnual(ByRef oPlan As Entidades.PlanAnualBE) As Integer Implements Interfaces.IPlanAnual.InsertarPlanAnual

        Dim strConn As String = ConfigurationManager.ConnectionStrings("SGC").ConnectionString
        Dim sqlConn As New SqlConnection(strConn)
        Dim sqlCmd As New SqlCommand("comite.SP_INSERTAR_PLAN_ANUAL", sqlConn)

        Dim recordId As Integer = 0
        sqlCmd.CommandType = CommandType.StoredProcedure
        sqlCmd.Parameters.Add("@descripcion", SqlDbType.VarChar).Value = IIf(oPlan.descripcion Is Nothing, DBNull.Value, oPlan.descripcion)
        sqlCmd.Parameters.Add("@id_comite", SqlDbType.VarChar).Value = oPlan.id_comite
        sqlCmd.Parameters.Add("@anio", SqlDbType.VarChar).Value = oPlan.anio
        sqlCmd.Parameters.Add("@fec_Ini", SqlDbType.DateTime).Value = oPlan.fec_ini
        sqlCmd.Parameters.Add("@fec_fin", SqlDbType.DateTime).Value = oPlan.fec_fin
        sqlCmd.Parameters.Add("@id_Estado", SqlDbType.VarChar).Value = oPlan.id_estado

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

#Region "Actualizar"

    Public Function ActualizarPlanAnual(ByRef oPlan As SGC.Model.Entidades.PlanAnualBE) As Integer Implements SGC.Model.Interfaces.IPlanAnual.ActualizarPlanAnual
        Dim strConn As String = ConfigurationManager.ConnectionStrings("SGC").ConnectionString
        Dim sqlConn As New SqlConnection(strConn)
        Dim sqlCmd As New SqlCommand("comite.SP_ACTUALIZAR_PLAN_ANUAL", sqlConn)

        Dim affectedRows As Integer = 0
        sqlCmd.CommandType = CommandType.StoredProcedure
        sqlCmd.Parameters.Add("@id_plan", SqlDbType.Int).Value = oPlan.id_plan
        sqlCmd.Parameters.Add("@fec_ini", SqlDbType.DateTime).Value = oPlan.fec_ini
        sqlCmd.Parameters.Add("@fec_fin", SqlDbType.DateTime).Value = oPlan.fec_fin
        sqlCmd.Parameters.Add("@id_comite", SqlDbType.NVarChar).Value = IIf(oPlan.id_comite Is Nothing, DBNull.Value, oPlan.id_comite)

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

    Public Function ActualizarPlanEstado(ByRef oPlan As Entidades.PlanAnualBE) As Integer Implements Interfaces.IPlanAnual.ActualizarPlanEstado
        Dim strConn As String = ConfigurationManager.ConnectionStrings("SGC").ConnectionString
        Dim sqlConn As New SqlConnection(strConn)
        Dim sqlCmd As New SqlCommand("comite.SP_ACTUALIZAR_PLAN_ESTADO", sqlConn)

        Dim affectedRows As Integer = 0
        sqlCmd.CommandType = CommandType.StoredProcedure
        sqlCmd.Parameters.Add("@id_plan", SqlDbType.Int).Value = oPlan.id_plan
        sqlCmd.Parameters.Add("@id_estado", SqlDbType.VarChar).Value = oPlan.id_estado

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

