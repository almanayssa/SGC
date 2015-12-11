Imports SGC.Model.Interfaces
Imports SGC.Model.Entidades
Imports System.Data
Imports System.Data.SqlClient
Imports System.Text
Imports System.Configuration

Namespace SGC.Model.Metodos

    Public Class LugarDL
        Implements ILugar

#Region "Select"

        Public Function ListarLugares() As System.Collections.Generic.List(Of Entidades.LugarBE) Implements Interfaces.ILugar.ListarLugares
            Dim oListadoLugares As New List(Of LugarBE)
            Dim oLugar As LugarBE
            Dim strConn As String = ConfigurationManager.ConnectionStrings("SGC").ConnectionString
            Dim sqlConn As New SqlConnection(strConn)
            Dim sqlCmd As New SqlCommand("comite.SP_LISTAR_LUGARES", sqlConn)
            Dim dr As SqlDataReader = Nothing
            sqlCmd.CommandType = CommandType.StoredProcedure

            Try
                sqlConn.Open()
                dr = sqlCmd.ExecuteReader()

                While dr.Read()
                    oLugar = New LugarBE
                    oLugar.id_lugar = dr("id_lugar")
                    oLugar.desc_lugar = dr("desc_lugar")
                    oListadoLugares.Add(oLugar)
                End While
                dr.Close()
                Return oListadoLugares
            Catch ex As System.Exception
                Throw ex
            Finally
                sqlConn.Close()
            End Try
        End Function

#End Region

    End Class

End Namespace

