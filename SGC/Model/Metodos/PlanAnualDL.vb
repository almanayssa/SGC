Imports SGC.Model
Imports SGC.Model.Entidades
Imports SGC.Model.Interfaces
Imports System.Configuration
Imports System.Data.SqlClient

Public Class PlanAnualDL
    Implements IPlanAnual


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
                oPlan.id_comite = dr("id_comite")
                oPlan.comite = dr("comite")
                oPlan.descripcion = dr("descripcion")
                oPlan.anio = dr("anio")
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

#End Region

End Class

