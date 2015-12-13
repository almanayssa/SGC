Imports SGC.Model.Interfaces
Imports SGC.Model.Entidades
Imports System.Data
Imports System.Data.SqlClient
Imports System.Text
Imports System.Configuration

Namespace SGC.Model.Metodos

    Public Class EspacioDL
        Implements IEspacio

#Region "Select"

        Public Function ListarEspacios(id_sede As String, id_lugar As Integer) As System.Collections.Generic.List(Of Entidades.EspacioBE) Implements Interfaces.IEspacio.ListarEspacios
            Dim oListadoEspacios As New List(Of EspacioBE)
            Dim oEspacio As EspacioBE
            Dim strConn As String = ConfigurationManager.ConnectionStrings("SGC").ConnectionString
            Dim sqlConn As New SqlConnection(strConn)
            Dim sqlCmd As New SqlCommand("comite.SP_LISTAR_ESPACIOS", sqlConn)
            Dim dr As SqlDataReader = Nothing
            sqlCmd.CommandType = CommandType.StoredProcedure
            sqlCmd.Parameters.Add("@id_sede", SqlDbType.VarChar).Value = id_sede
            sqlCmd.Parameters.Add("@id_lugar", SqlDbType.Int).Value = id_lugar

            Try
                sqlConn.Open()
                dr = sqlCmd.ExecuteReader()

                While dr.Read()
                    oEspacio = New EspacioBE
                    oEspacio.id_espacio = dr("id_espacio")
                    oEspacio.nombre = dr("nombre")
                    oListadoEspacios.Add(oEspacio)
                End While
                dr.Close()
                Return oListadoEspacios
            Catch ex As System.Exception
                Throw ex
            Finally
                sqlConn.Close()
            End Try
        End Function

        Public Function ObtenerEspacio(id_espacio As Integer) As Entidades.EspacioBE Implements Interfaces.IEspacio.ObtenerEspacio
            Dim oEspacio As New EspacioBE
            Dim strConn As String = ConfigurationManager.ConnectionStrings("SGC").ConnectionString
            Dim sqlConn As New SqlConnection(strConn)
            Dim sqlCmd As New SqlCommand("comite.SP_OBTENER_ESPACIO", sqlConn)
            Dim dr As SqlDataReader = Nothing
            sqlCmd.CommandType = CommandType.StoredProcedure
            sqlCmd.Parameters.Add("@id_espacio", SqlDbType.Int).Value = id_espacio

            Try
                sqlConn.Open()
                dr = sqlCmd.ExecuteReader()

                While dr.Read()
                    oEspacio = New EspacioBE
                    oEspacio.id_espacio = dr("id_espacio")
                    oEspacio.id_sede = dr("id_sede")
                    oEspacio.id_lugar = dr("id_lugar")
                    oEspacio.nombre = dr("nombre")
                End While
                dr.Close()
                Return oEspacio
            Catch ex As System.Exception
                Throw ex
            Finally
                sqlConn.Close()
            End Try
        End Function

#End Region

#Region "Insert"

        Public Function InsertarEspacio(ByRef oEspacio As EspacioBE) As Integer Implements IEspacio.InsertarEspacio
            Dim strConn As String = ConfigurationManager.ConnectionStrings("SGC").ConnectionString
            Dim sqlConn As New SqlConnection(strConn)
            Dim sqlCmd As New SqlCommand("comite.SP_INSERTAR_ESPACIO", sqlConn)

            Dim recordId As Integer = 0
            sqlCmd.CommandType = CommandType.StoredProcedure
            sqlCmd.Parameters.Add("@nombre", SqlDbType.VarChar).Value = IIf(oEspacio.nombre Is Nothing, DBNull.Value, oEspacio.nombre)
            sqlCmd.Parameters.Add("@direccion", SqlDbType.VarChar).Value = IIf(oEspacio.direccion Is Nothing, DBNull.Value, oEspacio.direccion)
            sqlCmd.Parameters.Add("@id_lugar", SqlDbType.Int).Value = IIf(oEspacio.id_lugar Is Nothing, DBNull.Value, oEspacio.id_lugar)
            sqlCmd.Parameters.Add("@id_estado_espacio", SqlDbType.VarChar).Value = IIf(oEspacio.id_estado_espacio Is Nothing, DBNull.Value, oEspacio.id_estado_espacio)
            sqlCmd.Parameters.Add("@id_sede", SqlDbType.VarChar).Value = IIf(oEspacio.id_sede Is Nothing, DBNull.Value, oEspacio.id_sede)

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

#Region "Update"

        Public Function ActualizarEspacio(ByRef oEspacio As Entidades.EspacioBE) As Integer Implements Interfaces.IEspacio.ActualizarEspacio
            Dim strConn As String = ConfigurationManager.ConnectionStrings("SGC").ConnectionString
            Dim sqlConn As New SqlConnection(strConn)
            Dim sqlCmd As New SqlCommand("comite.SP_ACTUALIZAR_ESPACIO", sqlConn)

            Dim affectedRows As Integer = 0
            sqlCmd.CommandType = CommandType.StoredProcedure
            sqlCmd.Parameters.Add("@id_espacio", SqlDbType.Int).Value = oEspacio.id_espacio
            sqlCmd.Parameters.Add("@nombre", SqlDbType.VarChar).Value = IIf(oEspacio.nombre Is Nothing, DBNull.Value, oEspacio.nombre)
            sqlCmd.Parameters.Add("@direccion", SqlDbType.VarChar).Value = IIf(oEspacio.direccion Is Nothing, DBNull.Value, oEspacio.direccion)
            sqlCmd.Parameters.Add("@id_lugar", SqlDbType.Int).Value = IIf(oEspacio.id_lugar Is Nothing, DBNull.Value, oEspacio.id_lugar)
            sqlCmd.Parameters.Add("@id_sede", SqlDbType.VarChar).Value = IIf(oEspacio.id_sede Is Nothing, DBNull.Value, oEspacio.id_sede)

            Try
                sqlConn.Open()
                affectedRows = sqlCmd.ExecuteNonQuery

                Return affectedRows
            Catch ex As System.Exception
                Throw ex
            Finally
                sqlConn.Close()
            End Try
        End Function

#End Region

#Region "Delete"

        Public Function BorrarEspacio(ByVal id_espacio As Integer) As Integer Implements Interfaces.IEspacio.BorrarEspacio
            Dim strConn As String = ConfigurationManager.ConnectionStrings("SGC").ConnectionString
            Dim sqlConn As New SqlConnection(strConn)
            Dim sqlCmd As New SqlCommand("comite.SP_BORRAR_ESPACIO", sqlConn)

            Dim affectedRows As Integer = 0
            sqlCmd.CommandType = CommandType.StoredProcedure
            sqlCmd.Parameters.Add("@id_espacio", SqlDbType.Int).Value = id_espacio

            Try
                sqlConn.Open()
                affectedRows = sqlCmd.ExecuteNonQuery

                Return affectedRows
            Catch ex As System.Exception
                Throw ex
            Finally
                sqlConn.Close()
            End Try
        End Function

#End Region

    End Class

End Namespace

