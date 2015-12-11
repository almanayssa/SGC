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

#End Region

    End Class

End Namespace

