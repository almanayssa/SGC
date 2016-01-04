Imports SGC.Model.Interfaces
Imports SGC.Model.Entidades
Imports System.Data
Imports System.Data.SqlClient
Imports System.Text
Imports System.Configuration

Namespace SGC.Model.Metodos

    Public Class ParametroDL
        Implements IParametro

#Region "Select"

        Public Function ListarParametros() As System.Collections.Generic.List(Of Entidades.ParametroBE) Implements Interfaces.IParametro.ListarParametros
            Dim oListado As New List(Of ParametroBE)
            Dim oParametro As ParametroBE
            Dim strConn As String = ConfigurationManager.ConnectionStrings("SGCBI").ConnectionString
            Dim sqlConn As New SqlConnection(strConn)
            Dim sqlCmd As New SqlCommand("USP_LISTAR_PARAMETROS", sqlConn)
            Dim dr As SqlDataReader = Nothing
            sqlCmd.CommandType = CommandType.StoredProcedure

            Try
                sqlConn.Open()
                dr = sqlCmd.ExecuteReader()

                While dr.Read()
                    oParametro = New ParametroBE
                    oParametro.id_parametro = dr("id_parametro")
                    oParametro.nombre = dr("nombre")
                    oParametro.valor = dr("valor")
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

#End Region

#Region "Update"

        Public Function ActualizarParametro(oParametro As Entidades.ParametroBE) As Integer Implements Interfaces.IParametro.ActualizarParametro
            Dim strConn As String = ConfigurationManager.ConnectionStrings("SGCBI").ConnectionString
            Dim sqlConn As New SqlConnection(strConn)
            Dim sqlCmd As New SqlCommand("USP_ACTUALIZAR_PARAMETRO", sqlConn)

            Dim affectedRows As Integer = 0
            sqlCmd.CommandType = CommandType.StoredProcedure
            sqlCmd.Parameters.Add("@id_parametro", SqlDbType.Int).Value = oParametro.id_parametro
            sqlCmd.Parameters.Add("@nombre", SqlDbType.VarChar).Value = oParametro.nombre
            sqlCmd.Parameters.Add("@valor", SqlDbType.Int).Value = oParametro.valor

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

