Imports SGC.Model
Imports SGC.Model.Entidades
Imports SGC.Model.Interfaces
Imports System.Configuration
Imports System.Data.SqlClient

Public Class PresupuestoAnualDL
    Implements IPresupuestoAnual


#Region "Select"

    Public Function ObtenerPresupuestoAnual(ByVal id_plan As Integer?, ByVal id_presupuesto As Integer?) As SGC.Model.Entidades.PresupuestoAnualBE Implements SGC.Model.Interfaces.IPresupuestoAnual.ObtenerPresupuestoAnual

        Dim oPresupuesto As New PresupuestoAnualBE
        Dim strConn As String = ConfigurationManager.ConnectionStrings("SGC").ConnectionString
        Dim sqlConn As New SqlConnection(strConn)
        Dim sqlCmd As New SqlCommand("comite.SP_OBTENER_PRESUPUESTO_ANUAL", sqlConn)
        Dim dr As SqlDataReader = Nothing
        sqlCmd.CommandType = CommandType.StoredProcedure
        sqlCmd.Parameters.Add("@id_plan", SqlDbType.Int).Value = id_plan

        Try
            sqlConn.Open()
            dr = sqlCmd.ExecuteReader()

            If dr.Read() Then
                oPresupuesto = New PresupuestoAnualBE
                oPresupuesto.id_presupuesto_anual = dr("id_presupuesto_anual")
                oPresupuesto.id_plan = dr("id_plan")
                oPresupuesto.id_comite = dr("id_comite")
                oPresupuesto.monto = dr("monto")

            End If
            dr.Close()
            Return oPresupuesto
        Catch ex As System.Exception
            Throw ex
        Finally
            sqlConn.Close()
        End Try

    End Function


#End Region

#Region "Insert"

    Public Function InsertarPresupuestoAnual(ByRef oPresupuesto As SGC.Model.Entidades.PresupuestoAnualBE) As Integer Implements SGC.Model.Interfaces.IPresupuestoAnual.InsertarPresupuestoAnual

        Dim strConn As String = ConfigurationManager.ConnectionStrings("SGC").ConnectionString
        Dim sqlConn As New SqlConnection(strConn)
        Dim sqlCmd As New SqlCommand("comite.SP_INSERTAR_PRESUPUESTO_ANUAL", sqlConn)

        Dim recordId As Integer = 0
        sqlCmd.CommandType = CommandType.StoredProcedure
        sqlCmd.Parameters.Add("@id_plan", SqlDbType.VarChar).Value = oPresupuesto.id_plan
        sqlCmd.Parameters.Add("@id_comite", SqlDbType.VarChar).Value = oPresupuesto.id_comite
        sqlCmd.Parameters.Add("@monto", SqlDbType.VarChar).Value = oPresupuesto.monto

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

