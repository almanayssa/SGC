Imports SGC.Model.Interfaces
Imports SGC.Model.Entidades
Imports System.Data
Imports System.Data.SqlClient
Imports System.Text
Imports System.Configuration

Namespace SGC.Model.Metodos

    Public Class FactPersonalDL
        Implements IFactPersonal

#Region "Select"

        Public Function ListarPersonalMasSolicitado() As System.Collections.Generic.List(Of Entidades.FactPersonalBE) Implements Interfaces.IFactPersonal.ListarPersonalMasSolicitado
            Dim oListadoFact As New List(Of FactPersonalBE)
            Dim oFact As FactPersonalBE
            Dim strConn As String = ConfigurationManager.ConnectionStrings("SGCBI").ConnectionString
            Dim sqlConn As New SqlConnection(strConn)
            Dim sqlCmd As New SqlCommand("USP_LISTAR_PERSONAL_MAS_SOLICITADO", sqlConn)
            Dim dr As SqlDataReader = Nothing
            sqlCmd.CommandType = CommandType.StoredProcedure

            Try
                sqlConn.Open()
                dr = sqlCmd.ExecuteReader()

                While dr.Read()
                    oFact = New FactPersonalBE
                    oFact.nombre_personal = dr("nombre_completo")
                    oFact.cant_actividades = dr("cant_actividades")
                    oListadoFact.Add(oFact)
                End While
                dr.Close()
                Return oListadoFact
            Catch ex As System.Exception
                Throw ex
            Finally
                sqlConn.Close()
            End Try
        End Function

#End Region

    End Class

End Namespace

