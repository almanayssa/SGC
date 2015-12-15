Imports SGC.Model.Interfaces
Imports SGC.Model.Entidades
Imports System.Data
Imports System.Data.SqlClient
Imports System.Text
Imports System.Configuration

Namespace SGC.Model.Metodos

    Public Class SeguimientoEvaluacionPlanDL
        Implements ISeguimientoEvaluacionPlan


#Region "Insert"

        Public Function InsertarSeguimientoEvaluacionPlan(ByRef oSeguimientoEvaluacionPlan As Entidades.SeguimientoEvaluacionPlanBE) As Integer Implements Interfaces.ISeguimientoEvaluacionPlan.InsertarSeguimientoEvaluacionPlan

            Dim strConn As String = ConfigurationManager.ConnectionStrings("SGC").ConnectionString
            Dim sqlConn As New SqlConnection(strConn)
            Dim sqlCmd As New SqlCommand("comite.SP_INSERTAR_SEGUIMIENTO_EVALUACION_PLAN", sqlConn)

            Dim recordId As Integer = 0
            sqlCmd.CommandType = CommandType.StoredProcedure
            sqlCmd.Parameters.Add("@id_area", SqlDbType.Int).Value = IIf(oSeguimientoEvaluacionPlan.id_area Is Nothing, DBNull.Value, oSeguimientoEvaluacionPlan.id_area)
            sqlCmd.Parameters.Add("@fecha", SqlDbType.DateTime).Value = IIf(oSeguimientoEvaluacionPlan.fecha Is Nothing, DBNull.Value, oSeguimientoEvaluacionPlan.fecha)
            sqlCmd.Parameters.Add("@id_usuario", SqlDbType.VarChar).Value = IIf(oSeguimientoEvaluacionPlan.id_usuario Is Nothing, DBNull.Value, oSeguimientoEvaluacionPlan.id_usuario)
            sqlCmd.Parameters.Add("@id_plan", SqlDbType.Int).Value = IIf(oSeguimientoEvaluacionPlan.id_plan Is Nothing, DBNull.Value, oSeguimientoEvaluacionPlan.id_plan)
            sqlCmd.Parameters.Add("@observacion", SqlDbType.VarChar).Value = IIf(oSeguimientoEvaluacionPlan.observacion Is Nothing, DBNull.Value, oSeguimientoEvaluacionPlan.observacion)
            sqlCmd.Parameters.Add("@id_estado", SqlDbType.VarChar).Value = IIf(oSeguimientoEvaluacionPlan.id_estado Is Nothing, DBNull.Value, oSeguimientoEvaluacionPlan.id_estado)

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

