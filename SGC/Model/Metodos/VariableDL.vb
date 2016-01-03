Imports SGC.Model.Interfaces
Imports SGC.Model.Entidades
Imports System.Data
Imports System.Data.SqlClient
Imports System.Text
Imports System.Configuration

Namespace SGC.Model.Metodos

    Public Class VariableDL
        Implements IVariable

#Region "Select"

        Public Function ListarVariables() As System.Collections.Generic.List(Of Entidades.VariableBE) Implements Interfaces.IVariable.ListarVariables
            Dim oListadoVariable As New List(Of VariableBE)
            Dim oVariable As VariableBE
            Dim strConn As String = ConfigurationManager.ConnectionStrings("SGCBI").ConnectionString
            Dim sqlConn As New SqlConnection(strConn)
            Dim sqlCmd As New SqlCommand("USP_LISTAR_VARIABLES", sqlConn)
            Dim dr As SqlDataReader = Nothing
            sqlCmd.CommandType = CommandType.StoredProcedure

            Try
                sqlConn.Open()
                dr = sqlCmd.ExecuteReader()

                While dr.Read()
                    oVariable = New VariableBE
                    oVariable.id_variable = dr("id_variable")
                    oVariable.nombre = dr("nombre")
                    oVariable.nom_sp = dr("nom_sp")
                    oVariable.flg_anulado = dr("flg_anulado")
                    oListadoVariable.Add(oVariable)
                End While
                dr.Close()
                Return oListadoVariable
            Catch ex As System.Exception
                Throw ex
            Finally
                sqlConn.Close()
            End Try
        End Function

#End Region

    End Class

End Namespace

