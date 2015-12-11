Imports SGC.Model.Interfaces
Imports SGC.Model.Entidades
Imports System.Data
Imports System.Data.SqlClient
Imports System.Text
Imports System.Configuration

Namespace SGC.Model.Metodos

    Public Class SedeDL
        Implements ISede

#Region "Select"

        Public Function ListarSedes() As System.Collections.Generic.List(Of Entidades.SedeBE) Implements Interfaces.ISede.ListarSedes
            Dim oListadoSedes As New List(Of SedeBE)
            Dim oSede As SedeBE
            Dim strConn As String = ConfigurationManager.ConnectionStrings("SGC").ConnectionString
            Dim sqlConn As New SqlConnection(strConn)
            Dim sqlCmd As New SqlCommand("comite.SP_LISTAR_SEDES", sqlConn)
            Dim dr As SqlDataReader = Nothing
            sqlCmd.CommandType = CommandType.StoredProcedure

            Try
                sqlConn.Open()
                dr = sqlCmd.ExecuteReader()

                While dr.Read()
                    oSede = New SedeBE
                    oSede.id_sede = dr("id_sede")
                    oSede.des_sede = dr("des_sede")
                    oListadoSedes.Add(oSede)
                End While
                dr.Close()
                Return oListadoSedes
            Catch ex As System.Exception
                Throw ex
            Finally
                sqlConn.Close()
            End Try
        End Function

#End Region

    End Class

End Namespace

