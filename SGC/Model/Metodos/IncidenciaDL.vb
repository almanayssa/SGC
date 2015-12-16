Imports SGC.Model.Interfaces
Imports SGC.Model.Entidades
Imports System.Data
Imports System.Data.SqlClient
Imports System.Text
Imports System.Configuration

Namespace SGC.Model.Metodos

    Public Class IncidenciaDL
        Implements IIncidencia

#Region "Select"

        Public Function ObtenerIncidencia(id_actividad_detalle As Integer) As Entidades.IncidenciaBE Implements Interfaces.IIncidencia.ObtenerIncidencia
            Dim oIncidencia As New IncidenciaBE
            Dim strConn As String = ConfigurationManager.ConnectionStrings("SGC").ConnectionString
            Dim sqlConn As New SqlConnection(strConn)
            Dim sqlCmd As New SqlCommand("comite.SP_OBTENER_INCIDENCIA", sqlConn)
            Dim dr As SqlDataReader = Nothing
            sqlCmd.CommandType = CommandType.StoredProcedure
            sqlCmd.Parameters.Add("@id_actividad_detalle", SqlDbType.Int).Value = id_actividad_detalle

            Try
                sqlConn.Open()
                dr = sqlCmd.ExecuteReader()

                If dr.Read() Then
                    oIncidencia.id_incidencia = dr("id_incidencia")
                    oIncidencia.incidencia = dr("incidencia")
                End If
                dr.Close()
                Return oIncidencia
            Catch ex As System.Exception
                Throw ex
            Finally
                sqlConn.Close()
            End Try
        End Function

#End Region

#Region "Insert"

        Public Function InsertarIncidencia(ByRef oIncidencia As Entidades.IncidenciaBE) As Integer Implements Interfaces.IIncidencia.InsertarIncidencia
            Dim strConn As String = ConfigurationManager.ConnectionStrings("SGC").ConnectionString
            Dim sqlConn As New SqlConnection(strConn)
            Dim sqlCmd As New SqlCommand("comite.SP_INSERTAR_INCIDENCIA", sqlConn)

            Dim recordId As Integer = 0
            sqlCmd.CommandType = CommandType.StoredProcedure
            sqlCmd.Parameters.Add("@id_actividad_detalle", SqlDbType.Int).Value = oIncidencia.id_actividad_detalle
            sqlCmd.Parameters.Add("@incidencia", SqlDbType.VarChar).Value = oIncidencia.incidencia

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

