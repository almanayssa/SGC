Imports SGC.Model.Interfaces
Imports SGC.Model.Entidades
Imports System.Data
Imports System.Data.SqlClient
Imports System.Text
Imports System.Configuration

Namespace SGC.Model.Metodos

    Public Class RecursoDL
        Implements IRecurso


#Region "Select"

        Public Function ListarRecursos(ByVal descripcion As String) As List(Of RecursoBE) Implements IRecurso.ListarRecursos
            Dim oListadoRecursos As New List(Of RecursoBE)
            Dim oRecurso As RecursoBE
            Dim strConn As String = ConfigurationManager.ConnectionStrings("SGC").ConnectionString
            Dim sqlConn As New SqlConnection(strConn)
            Dim sqlCmd As New SqlCommand("comite.SP_LISTAR_RECURSOS", sqlConn)
            Dim dr As SqlDataReader = Nothing
            sqlCmd.CommandType = CommandType.StoredProcedure
            sqlCmd.Parameters.Add("@descripcion", SqlDbType.VarChar).Value = descripcion

            Try
                sqlConn.Open()
                dr = sqlCmd.ExecuteReader()

                While dr.Read()
                    oRecurso = New RecursoBE
                    oRecurso.id_recurso = dr("id_recurso")
                    oRecurso.descripcion = dr("descripcion")
                    oListadoRecursos.Add(oRecurso)
                End While
                dr.Close()
                Return oListadoRecursos
            Catch ex As System.Exception
                Throw ex
            Finally
                sqlConn.Close()
            End Try

        End Function

        Public Function ListarRecursosXActividad(ByVal id_actividad As Integer) As System.Collections.Generic.List(Of Entidades.RecursoBE) Implements Interfaces.IRecurso.ListarRecursosXActividad
            Dim oListadoRecursos As New List(Of RecursoBE)
            Dim oRecurso As RecursoBE
            Dim strConn As String = ConfigurationManager.ConnectionStrings("SGC").ConnectionString
            Dim sqlConn As New SqlConnection(strConn)
            Dim sqlCmd As New SqlCommand("comite.SP_LISTAR_RECURSOS_X_ACTIVIDAD", sqlConn)
            Dim dr As SqlDataReader = Nothing
            sqlCmd.CommandType = CommandType.StoredProcedure
            sqlCmd.Parameters.Add("@id_actividad", SqlDbType.Int).Value = id_actividad

            Try
                sqlConn.Open()
                dr = sqlCmd.ExecuteReader()

                While dr.Read()
                    oRecurso = New RecursoBE
                    oRecurso.id_recurso = dr("id_recurso")
                    oRecurso.descripcion = dr("descripcion")
                    oRecurso.cantidad = dr("cantidad")
                    oRecurso.cantidad_real = IIf(dr("cantidad_real") Is DBNull.Value, Nothing, dr("cantidad_real"))
                    oListadoRecursos.Add(oRecurso)
                End While
                dr.Close()
                Return oListadoRecursos
            Catch ex As System.Exception
                Throw ex
            Finally
                sqlConn.Close()
            End Try
        End Function

        Public Function ObtenerRecursosDemanda(id_comite As String, id_tipo As String) As System.Collections.Generic.List(Of Entidades.RecursoBE) Implements Interfaces.IRecurso.ObtenerRecursosDemanda
            Dim oListadoRecursos As New List(Of RecursoBE)
            Dim oRecurso As RecursoBE
            Dim strConn As String = ConfigurationManager.ConnectionStrings("SGC").ConnectionString
            Dim sqlConn As New SqlConnection(strConn)
            Dim sqlCmd As New SqlCommand("comite.SP_OBTENER_RECURSO_MAX_DEMANDA", sqlConn)
            Dim dr As SqlDataReader = Nothing
            sqlCmd.CommandType = CommandType.StoredProcedure
            sqlCmd.Parameters.Add("@id_comite", SqlDbType.VarChar).Value = id_comite
            sqlCmd.Parameters.Add("@id_tipo_act", SqlDbType.VarChar).Value = id_tipo

            Try
                sqlConn.Open()
                dr = sqlCmd.ExecuteReader()

                While dr.Read()
                    oRecurso = New RecursoBE
                    oRecurso.id_recurso = dr("id_recurso")
                    oRecurso.descripcion = dr("descripcion")
                    oRecurso.cantidad = dr("cant")
                    oListadoRecursos.Add(oRecurso)
                End While
                dr.Close()
                Return oListadoRecursos
            Catch ex As System.Exception
                Throw ex
            Finally
                sqlConn.Close()
            End Try
        End Function

#End Region

    End Class

End Namespace

