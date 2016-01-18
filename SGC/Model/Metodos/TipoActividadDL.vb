Imports SGC.Model.Interfaces
Imports SGC.Model.Entidades
Imports System.Data
Imports System.Data.SqlClient
Imports System.Text
Imports System.Configuration

Namespace SGC.Model.Metodos

    Public Class TipoActividadDL
        Implements ITipoActividad

#Region "Select"

        Public Function ListarTipoActividad() As System.Collections.Generic.List(Of Entidades.TipoActividadBE) Implements Interfaces.ITipoActividad.ListarTipoActividad
            Dim oListadoTipoActividad As New List(Of TipoActividadBE)
            Dim oTipo As TipoActividadBE
            Dim strConn As String = ConfigurationManager.ConnectionStrings("SGC").ConnectionString
            Dim sqlConn As New SqlConnection(strConn)
            Dim sqlCmd As New SqlCommand("comite.SP_LISTAR_TIPOS_ACTIVIDAD", sqlConn)
            Dim dr As SqlDataReader = Nothing
            sqlCmd.CommandType = CommandType.StoredProcedure

            Try
                sqlConn.Open()
                dr = sqlCmd.ExecuteReader()

                While dr.Read()
                    oTipo = New TipoActividadBE
                    oTipo.id_tipo_act = dr("id_tipo_act")
                    oTipo.desc_tipo = dr("desc_tipo")
                    oListadoTipoActividad.Add(oTipo)
                End While
                dr.Close()
                Return oListadoTipoActividad
            Catch ex As System.Exception
                Throw ex
            Finally
                sqlConn.Close()
            End Try
        End Function


        Public Function ListarTipoActividadVal(ByVal idTipo As String) As System.Collections.Generic.List(Of Entidades.TipoActividadBE) Implements Interfaces.ITipoActividad.ListarTipoActividadVal
            Dim oListadoTipoActividad As New List(Of TipoActividadBE)
            Dim oTipo As TipoActividadBE
            Dim strConn As String = ConfigurationManager.ConnectionStrings("SGC").ConnectionString
            Dim sqlConn As New SqlConnection(strConn)
            Dim sqlCmd As New SqlCommand("comite.SP_LISTAR_TIPOS_ACTIVIDAD_VAL", sqlConn)
            Dim dr As SqlDataReader = Nothing
            sqlCmd.CommandType = CommandType.StoredProcedure
            sqlCmd.Parameters.Add("@idtipo", SqlDbType.NVarChar).Value = idTipo

            Try
                sqlConn.Open()
                dr = sqlCmd.ExecuteReader()

                While dr.Read()
                    oTipo = New TipoActividadBE
                    oTipo.id_tipo_act = dr("id_tipo_act")
                    oTipo.desc_tipo = dr("desc_tipo")
                    oListadoTipoActividad.Add(oTipo)
                End While
                dr.Close()
                Return oListadoTipoActividad
            Catch ex As System.Exception
                Throw ex
            Finally
                sqlConn.Close()
            End Try
        End Function

#End Region

    End Class

End Namespace

