Imports SGC.Model.Interfaces
Imports SGC.Model.Entidades
Imports System.Data
Imports System.Data.SqlClient
Imports System.Text
Imports System.Configuration

Namespace SGC.Model.Metodos

    Public Class AsistenciaDL
        Implements IAsistencia

#Region "Select"

        Public Function ListarAsistencia(id_actividad As Integer) As System.Collections.Generic.List(Of Entidades.AsistenciaBE) Implements Interfaces.IAsistencia.ListarAsistencia
            Dim oListadoAsistencia As New List(Of AsistenciaBE)
            Dim oAsistencia As AsistenciaBE
            Dim strConn As String = ConfigurationManager.ConnectionStrings("SGC").ConnectionString
            Dim sqlConn As New SqlConnection(strConn)
            Dim sqlCmd As New SqlCommand("comite.SP_LISTAR_ASISTENCIA", sqlConn)
            Dim dr As SqlDataReader = Nothing
            sqlCmd.CommandType = CommandType.StoredProcedure
            sqlCmd.Parameters.Add("@id_actividad", SqlDbType.Int).Value = id_actividad

            Try
                sqlConn.Open()
                dr = sqlCmd.ExecuteReader()

                While dr.Read()
                    oAsistencia = New AsistenciaBE
                    oAsistencia.id_persona = dr("id_entidad")
                    oAsistencia.nombre_completo = dr("nombre_completo")
                    oAsistencia.flg_asistencia = dr("flg_asistencia")
                    oListadoAsistencia.Add(oAsistencia)
                End While
                dr.Close()
                Return oListadoAsistencia
            Catch ex As System.Exception
                Throw ex
            Finally
                sqlConn.Close()
            End Try
        End Function

#End Region

#Region "Insert"

        Public Function InsertarAsistencia(ByRef oAsistencia As Entidades.AsistenciaBE) As Integer Implements Interfaces.IAsistencia.InsertarAsistencia
            Dim strConn As String = ConfigurationManager.ConnectionStrings("SGC").ConnectionString
            Dim sqlConn As New SqlConnection(strConn)
            Dim sqlCmd As New SqlCommand("comite.INSERTAR_ASISTENCIA", sqlConn)

            Dim recordId As Integer = 0
            sqlCmd.CommandType = CommandType.StoredProcedure
            sqlCmd.Parameters.Add("@id_detalle", SqlDbType.Int).Value = oAsistencia.id_detalle
            sqlCmd.Parameters.Add("@flg_asistencia", SqlDbType.Bit).Value = oAsistencia.flg_asistencia

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

