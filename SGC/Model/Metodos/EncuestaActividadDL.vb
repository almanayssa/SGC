Imports SGC.Model.Interfaces
Imports SGC.Model.Entidades
Imports System.Data
Imports System.Data.SqlClient
Imports System.Text
Imports System.Configuration

Namespace SGC.Model.Metodos

    Public Class EncuestaActividadDL
        Implements IEncuestaActividad

#Region "Select"

        Public Function ObtenerEncuesta(id_actividad As Integer) As Entidades.EncuestaActividadBE Implements Interfaces.IEncuestaActividad.ObtenerEncuesta
            Dim oEncuestaActividad As New EncuestaActividadBE
            Dim strConn As String = ConfigurationManager.ConnectionStrings("SGC").ConnectionString
            Dim sqlConn As New SqlConnection(strConn)
            Dim sqlCmd As New SqlCommand("comite.SP_OBTENER_ENCUESTA", sqlConn)
            Dim dr As SqlDataReader = Nothing
            sqlCmd.CommandType = CommandType.StoredProcedure
            sqlCmd.Parameters.Add("@id_actividad", SqlDbType.Int).Value = id_actividad

            Try
                sqlConn.Open()
                dr = sqlCmd.ExecuteReader()

                If dr.Read() Then
                    oEncuestaActividad.id_encuesta = dr("id_encuesta")
                    oEncuestaActividad.descripcion = dr("descripcion")
                End If
                dr.Close()
                Return oEncuestaActividad
            Catch ex As System.Exception
                Throw ex
            Finally
                sqlConn.Close()
            End Try
        End Function

#End Region

#Region "Insert"

        Public Function InsertarEncuesta(ByRef oEncuestaActividad As Entidades.EncuestaActividadBE) As Integer Implements Interfaces.IEncuestaActividad.InsertarEncuesta
            Dim strConn As String = ConfigurationManager.ConnectionStrings("SGC").ConnectionString
            Dim sqlConn As New SqlConnection(strConn)
            Dim sqlCmd As New SqlCommand("comite.SP_INSERTAR_ENCUESTA", sqlConn)

            Dim recordId As Integer = 0
            sqlCmd.CommandType = CommandType.StoredProcedure
            sqlCmd.Parameters.Add("@descripcion", SqlDbType.Int).Value = oEncuestaActividad.descripcion
            sqlCmd.Parameters.Add("@id_actividad", SqlDbType.Int).Value = oEncuestaActividad.id_actividad

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

