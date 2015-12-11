Imports SGC.Model.Interfaces
Imports SGC.Model.Entidades
Imports System.Data
Imports System.Data.SqlClient
Imports System.Text
Imports System.Configuration

Namespace SGC.Model.Metodos

    Public Class SignosDL
        Implements ISignos

#Region "Select"

        Public Function ListarSignos() As System.Collections.Generic.List(Of Entidades.SignosBE) Implements Interfaces.ISignos.ListarSignos
            Dim oListadoSignos As New List(Of SignosBE)
            Dim oSigno As SignosBE
            Dim strConn As String = ConfigurationManager.ConnectionStrings("SGC").ConnectionString
            Dim sqlConn As New SqlConnection(strConn)
            Dim sqlCmd As New SqlCommand("comite.SP_LISTAR_SIGNOS", sqlConn)
            Dim dr As SqlDataReader = Nothing
            sqlCmd.CommandType = CommandType.StoredProcedure

            Try
                sqlConn.Open()
                dr = sqlCmd.ExecuteReader()

                While dr.Read()
                    oSigno = New SignosBE
                    oSigno.id_signo = dr("id_signo")
                    oSigno.signo = dr("signo")
                    oListadoSignos.Add(oSigno)
                End While
                dr.Close()
                Return oListadoSignos
            Catch ex As System.Exception
                Throw ex
            Finally
                sqlConn.Close()
            End Try
        End Function

#End Region

    End Class

End Namespace

