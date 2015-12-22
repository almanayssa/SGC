Imports SGC.Model
Imports SGC.Model.Entidades
Imports SGC.Model.Interfaces
Imports System.Configuration
Imports System.Data.SqlClient

Public Class PresupuestoActividadDL
    Implements IPresupuestoActividad

#Region "Select"

    Public Function ObtenerPresupuestoActividad(ByVal id_actividad As Integer?) As SGC.Model.Entidades.PresupuestoActividadBE Implements SGC.Model.Interfaces.IPresupuestoActividad.ObtenerPresupuestoActividad

        Dim oPresupuesto As New PresupuestoActividadBE
        Dim strConn As String = ConfigurationManager.ConnectionStrings("SGC").ConnectionString
        Dim sqlConn As New SqlConnection(strConn)
        Dim sqlCmd As New SqlCommand("comite.SP_OBTENER_PRESUPUESTO_ACTIVIDAD", sqlConn)
        Dim dr As SqlDataReader = Nothing
        sqlCmd.CommandType = CommandType.StoredProcedure
        sqlCmd.Parameters.Add("@id_actividad", SqlDbType.Int).Value = id_actividad

        Try
            sqlConn.Open()
            dr = sqlCmd.ExecuteReader()

            If dr.Read() Then
                oPresupuesto = New PresupuestoActividadBE
                oPresupuesto.id_presupuesto_actividad = dr("id_presupuesto_actividad")
                oPresupuesto.id_actividad = dr("id_actividad")
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

    Public Function InsertarPresupuestoActividad(ByRef oPresupuesto As SGC.Model.Entidades.PresupuestoActividadBE) As Integer Implements SGC.Model.Interfaces.IPresupuestoActividad.InsertarPresupuestoActividad

        Dim strConn As String = ConfigurationManager.ConnectionStrings("SGC").ConnectionString
        Dim sqlConn As New SqlConnection(strConn)
        Dim sqlCmd As New SqlCommand("comite.SP_INSERTAR_PRESUPUESTO_ACTIVIDAD", sqlConn)

        Dim recordId As Integer = 0
        sqlCmd.CommandType = CommandType.StoredProcedure
        sqlCmd.Parameters.Add("@id_actividad", SqlDbType.Int).Value = oPresupuesto.id_actividad
        sqlCmd.Parameters.Add("@monto", SqlDbType.Decimal).Value = oPresupuesto.monto

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
