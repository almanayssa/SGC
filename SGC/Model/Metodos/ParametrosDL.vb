Imports SGC.Model.Interfaces
Imports SGC.Model.Entidades
Imports System.Data
Imports System.Data.SqlClient
Imports System.Text
Imports System.Configuration

Namespace SGC.Model.Metodos

    Public Class ParametrosDL
        Implements IParametros


#Region "Select"

        Public Function ListarParametros() As System.Collections.Generic.List(Of Entidades.ParametrosBE) Implements Interfaces.IParametros.ListarParametros
            Dim oListado As New List(Of ParametrosBE)
            Dim oParametro As ParametrosBE
            Dim strConn As String = ConfigurationManager.ConnectionStrings("SGC").ConnectionString
            Dim sqlConn As New SqlConnection(strConn)
            Dim sqlCmd As New SqlCommand("comite.SP_LISTAR_PARAMETROS", sqlConn)
            Dim dr As SqlDataReader = Nothing
            sqlCmd.CommandType = CommandType.StoredProcedure

            Try
                sqlConn.Open()
                dr = sqlCmd.ExecuteReader()

                While dr.Read()
                    oParametro = New ParametrosBE
                    oParametro.id_parametro = dr("id_parametro")
                    oParametro.des_param = dr("des_param")
                    oParametro.val_param = dr("val_param")
                    oParametro.observacion = dr("observacion")
                    oListado.Add(oParametro)
                End While
                dr.Close()
                Return oListado
            Catch ex As System.Exception
                Throw ex
            Finally
                sqlConn.Close()
            End Try
        End Function

        Public Function ObtenerParametro(ByVal id As String) As Entidades.ParametrosBE Implements Interfaces.IParametros.ObtenerParametro
            Dim oParametro As ParametrosBE
            Dim strConn As String = ConfigurationManager.ConnectionStrings("SGC").ConnectionString
            Dim sqlConn As New SqlConnection(strConn)
            Dim sqlCmd As New SqlCommand("comite.SP_OBTENER_PARAMETRO", sqlConn)
            Dim dr As SqlDataReader = Nothing
            sqlCmd.CommandType = CommandType.StoredProcedure
            sqlCmd.Parameters.Add("@id_parametro", SqlDbType.Int).Value = id

            Try
                sqlConn.Open()
                dr = sqlCmd.ExecuteReader()

                If dr.Read() Then
                    oParametro = New ParametrosBE
                    oParametro.id_parametro = dr("id_parametro")
                    oParametro.des_param = dr("des_param")
                    oParametro.val_param = dr("val_param")
                    oParametro.observacion = dr("observacion")
                End If
                dr.Close()
                Return oParametro
            Catch ex As System.Exception
                Throw ex
            Finally
                sqlConn.Close()
            End Try
        End Function

#End Region

#Region "Insert"

#End Region

#Region "Update"

        Public Function ActualizarParametro(oParametro As Entidades.ParametrosBE) As Integer Implements Interfaces.IParametros.ActualizarParametro
            Dim strConn As String = ConfigurationManager.ConnectionStrings("SGC").ConnectionString
            Dim sqlConn As New SqlConnection(strConn)
            Dim sqlCmd As New SqlCommand("comite.SP_ACTUALIZAR_PARAMETRO", sqlConn)

            Dim affectedRows As Integer = 0
            sqlCmd.CommandType = CommandType.StoredProcedure
            sqlCmd.Parameters.Add("@id_parametro", SqlDbType.Int).Value = oParametro.id_parametro
            sqlCmd.Parameters.Add("@val_param", SqlDbType.VarChar).Value = IIf(oParametro.val_param Is Nothing, DBNull.Value, oParametro.val_param)
            sqlCmd.Parameters.Add("@des_param", SqlDbType.VarChar).Value = IIf(oParametro.des_param Is Nothing, DBNull.Value, oParametro.des_param)
            sqlCmd.Parameters.Add("@observacion", SqlDbType.VarChar).Value = IIf(oParametro.observacion Is Nothing, DBNull.Value, oParametro.observacion)

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

