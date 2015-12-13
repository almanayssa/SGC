Imports SGC.Model.Interfaces
Imports SGC.Model.Entidades
Imports System.Data
Imports System.Data.SqlClient
Imports System.Text
Imports System.Configuration

Namespace SGC.Model.Metodos

    Public Class SeguimientoEvaluacionActividadDL
        Implements ISeguimientoEvaluacionActividad

#Region "Insert"

        Public Function InsertarSeguimientoEvaluacionActividad(ByRef oSeguimientoEvaluacionActividad As Entidades.SeguimientoEvaluacionActividadBE) As Integer Implements Interfaces.ISeguimientoEvaluacionActividad.InsertarSeguimientoEvaluacionActividad
            Dim strConn As String = ConfigurationManager.ConnectionStrings("SGC").ConnectionString
            Dim sqlConn As New SqlConnection(strConn)
            Dim sqlCmd As New SqlCommand("comite.SP_INSERTAR_SEGUIMIENTO_EVALUACION_ACTIVIDAD", sqlConn)

            Dim recordId As Integer = 0
            sqlCmd.CommandType = CommandType.StoredProcedure
            sqlCmd.Parameters.Add("@fecha", SqlDbType.DateTime).Value = IIf(oSeguimientoEvaluacionActividad.fecha Is Nothing, DBNull.Value, oSeguimientoEvaluacionActividad.fecha)
            sqlCmd.Parameters.Add("@id_usuario", SqlDbType.VarChar).Value = IIf(oSeguimientoEvaluacionActividad.id_usuario Is Nothing, DBNull.Value, oSeguimientoEvaluacionActividad.id_usuario)
            sqlCmd.Parameters.Add("@id_actividad", SqlDbType.Int).Value = IIf(oSeguimientoEvaluacionActividad.id_actividad Is Nothing, DBNull.Value, oSeguimientoEvaluacionActividad.id_actividad)
            sqlCmd.Parameters.Add("@observacion", SqlDbType.VarChar).Value = IIf(oSeguimientoEvaluacionActividad.observacion Is Nothing, DBNull.Value, oSeguimientoEvaluacionActividad.observacion)
            sqlCmd.Parameters.Add("@id_area", SqlDbType.Int).Value = IIf(oSeguimientoEvaluacionActividad.id_area Is Nothing, DBNull.Value, oSeguimientoEvaluacionActividad.id_area)
            sqlCmd.Parameters.Add("@id_estado", SqlDbType.VarChar).Value = IIf(oSeguimientoEvaluacionActividad.id_estado Is Nothing, DBNull.Value, oSeguimientoEvaluacionActividad.id_estado)

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

