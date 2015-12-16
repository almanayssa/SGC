Imports SGC.Model.Interfaces
Imports SGC.Model.Entidades
Imports System.Data
Imports System.Data.SqlClient
Imports System.Text
Imports System.Configuration

Namespace SGC.Model.Metodos

    Public Class AsistenciaPersonalDL
        Implements IAsistenciaPersonal

#Region "Select"

        Public Function ListarAsistenciaPersonal(id_actividad As Integer) As System.Collections.Generic.List(Of Entidades.AsistenciaPersonalBE) Implements Interfaces.IAsistenciaPersonal.ListarAsistenciaPersonal
            Dim oListadoAsistenciaPersonal As New List(Of AsistenciaPersonalBE)
            Dim oAsistenciaPersonal As AsistenciaPersonalBE
            Dim strConn As String = ConfigurationManager.ConnectionStrings("SGC").ConnectionString
            Dim sqlConn As New SqlConnection(strConn)
            Dim sqlCmd As New SqlCommand("comite.SP_LISTAR_ASISTENCIA_PERSONAL", sqlConn)
            Dim dr As SqlDataReader = Nothing
            sqlCmd.CommandType = CommandType.StoredProcedure
            sqlCmd.Parameters.Add("@id_actividad", SqlDbType.Int).Value = id_actividad

            Try
                sqlConn.Open()
                dr = sqlCmd.ExecuteReader()

                While dr.Read()
                    oAsistenciaPersonal = New AsistenciaPersonalBE
                    oAsistenciaPersonal.id_actividad = dr("id_actividad")
                    oAsistenciaPersonal.nombre_completo = dr("nombre_completo")
                    oAsistenciaPersonal.flg_asistencia = dr("flg_asistencia")
                    oListadoAsistenciaPersonal.Add(oAsistenciaPersonal)
                End While
                dr.Close()
                Return oListadoAsistenciaPersonal
            Catch ex As System.Exception
                Throw ex
            Finally
                sqlConn.Close()
            End Try
        End Function

#End Region

#Region "Insert"

        Public Function InsertarAsistenciaPersonal(ByRef oAsistenciaPersonal As Entidades.AsistenciaPersonalBE) As Integer Implements Interfaces.IAsistenciaPersonal.InsertarAsistenciaPersonal
            Dim strConn As String = ConfigurationManager.ConnectionStrings("SGC").ConnectionString
            Dim sqlConn As New SqlConnection(strConn)
            Dim sqlCmd As New SqlCommand("comite.INSERTAR_ASISTENCIA_PERSONAL", sqlConn)

            Dim recordId As Integer = 0
            sqlCmd.CommandType = CommandType.StoredProcedure
            sqlCmd.Parameters.Add("@id_actividad", SqlDbType.Int).Value = oAsistenciaPersonal.id_actividad
            sqlCmd.Parameters.Add("@id_personal", SqlDbType.Int).Value = oAsistenciaPersonal.id_personal
            sqlCmd.Parameters.Add("@flg_asistencia", SqlDbType.Bit).Value = oAsistenciaPersonal.flg_asistencia

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

