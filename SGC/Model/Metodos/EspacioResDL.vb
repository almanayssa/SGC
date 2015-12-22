Imports SGC.Model.Interfaces
Imports SGC.Model.Entidades
Imports System.Data
Imports System.Data.SqlClient
Imports System.Text
Imports System.Configuration

Namespace SGC.Model.Metodos

    Public Class EspacioResDL
        Implements IEspacioRes

#Region "Select"

        Public Function ListarCronogramaEspacios(id_espacio As Integer, fecha As DateTime) As System.Collections.Generic.List(Of Entidades.EspacioResBE) Implements Interfaces.IEspacioRes.ListarCronogramaEspacios
            Dim oListadoEspacioRes As New List(Of EspacioResBE)
            Dim oEspacioRes As EspacioResBE
            Dim strConn As String = ConfigurationManager.ConnectionStrings("SGC").ConnectionString
            Dim sqlConn As New SqlConnection(strConn)
            Dim sqlCmd As New SqlCommand("comite.LISTAR_CRONOGRAMA_ESPACIOS", sqlConn)
            Dim dr As SqlDataReader = Nothing
            sqlCmd.CommandType = CommandType.StoredProcedure
            sqlCmd.Parameters.Add("@id_espacio", SqlDbType.Int).Value = id_espacio
            sqlCmd.Parameters.Add("@fecha", SqlDbType.DateTime).Value = fecha

            Try
                sqlConn.Open()
                dr = sqlCmd.ExecuteReader()

                While dr.Read()
                    oEspacioRes = New EspacioResBE
                    oEspacioRes.hora_inicio = dr("hora_inicio")
                    oEspacioRes.hora_fin = dr("hora_fin")
                    oEspacioRes.estado = dr("estado")
                    oEspacioRes.nombre_comite = IIf(dr("nombre") Is DBNull.Value, Nothing, dr("nombre"))
                    oEspacioRes.observacion = IIf(dr("observacion") Is DBNull.Value, Nothing, dr("observacion"))
                    oListadoEspacioRes.Add(oEspacioRes)
                End While
                dr.Close()
                Return oListadoEspacioRes
            Catch ex As System.Exception
                Throw ex
            Finally
                sqlConn.Close()
            End Try
        End Function

#End Region

    End Class

End Namespace

