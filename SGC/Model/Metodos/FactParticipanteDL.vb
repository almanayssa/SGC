Imports SGC.Model.Interfaces
Imports SGC.Model.Entidades
Imports System.Data
Imports System.Data.SqlClient
Imports System.Text
Imports System.Configuration

Namespace SGC.Model.Metodos

    Public Class FactParticipanteDL
        Implements IFactParticipante

#Region "Select"

        Public Function ListarPersonasMasParticipativas() As System.Collections.Generic.List(Of Entidades.FactParticipanteBE) Implements Interfaces.IFactParticipante.ListarPersonasMasParticipativas
            Dim oListadoFact As New List(Of FactParticipanteBE)
            Dim oFact As FactParticipanteBE
            Dim strConn As String = ConfigurationManager.ConnectionStrings("SGCBI").ConnectionString
            Dim sqlConn As New SqlConnection(strConn)
            Dim sqlCmd As New SqlCommand("USP_LISTAR_PERSONAS_MAS_PARTICIPATIVAS", sqlConn)
            Dim dr As SqlDataReader = Nothing
            sqlCmd.CommandType = CommandType.StoredProcedure

            Try
                sqlConn.Open()
                dr = sqlCmd.ExecuteReader()

                While dr.Read()
                    oFact = New FactParticipanteBE
                    oFact.nombre_persona = dr("nombre_completo")
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

