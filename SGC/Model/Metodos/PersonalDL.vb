Imports SGC.Model.Interfaces
Imports SGC.Model.Entidades
Imports System.Data
Imports System.Data.SqlClient
Imports System.Text
Imports System.Configuration

Namespace SGC.Model.Metodos

    Public Class PersonalDL
        Implements IPersonal

#Region "Select"

        Public Function ListarPersonal(id_tipo As Integer, nombre As String) As System.Collections.Generic.List(Of Entidades.PersonalBE) Implements Interfaces.IPersonal.ListarPersonal
            Dim oListadoPersonal As New List(Of PersonalBE)
            Dim oPersonal As PersonalBE
            Dim strConn As String = ConfigurationManager.ConnectionStrings("SGC").ConnectionString
            Dim sqlConn As New SqlConnection(strConn)
            Dim sqlCmd As New SqlCommand("comite.SP_LISTAR_PERSONAL", sqlConn)
            Dim dr As SqlDataReader = Nothing
            sqlCmd.CommandType = CommandType.StoredProcedure
            sqlCmd.Parameters.Add("@id_tipo_personal", SqlDbType.Int).Value = id_tipo
            sqlCmd.Parameters.Add("@nombre", SqlDbType.VarChar).Value = nombre

            Try
                sqlConn.Open()
                dr = sqlCmd.ExecuteReader()

                While dr.Read()
                    oPersonal = New PersonalBE
                    oPersonal.id_personal = dr("id_personal")
                    oPersonal.nombre_completo = dr("nombre_completo")
                    oListadoPersonal.Add(oPersonal)
                End While
                dr.Close()
                Return oListadoPersonal
            Catch ex As System.Exception
                Throw ex
            Finally
                sqlConn.Close()
            End Try
        End Function

        Public Function ListarPersonalXActividad(ByVal id_actividad As Integer) As System.Collections.Generic.List(Of Entidades.PersonalBE) Implements Interfaces.IPersonal.ListarPersonalXActividad
            Dim oListadoPersonal As New List(Of PersonalBE)
            Dim oPersonal As PersonalBE
            Dim strConn As String = ConfigurationManager.ConnectionStrings("SGC").ConnectionString
            Dim sqlConn As New SqlConnection(strConn)
            Dim sqlCmd As New SqlCommand("comite.SP_LISTAR_PERSONAL_X_ACTIVIDAD", sqlConn)
            Dim dr As SqlDataReader = Nothing
            sqlCmd.CommandType = CommandType.StoredProcedure
            sqlCmd.Parameters.Add("@id_actividad", SqlDbType.Int).Value = id_actividad

            Try
                sqlConn.Open()
                dr = sqlCmd.ExecuteReader()

                While dr.Read()
                    oPersonal = New PersonalBE
                    oPersonal.id_personal = dr("id_personal")
                    oPersonal.nombre_completo = dr("nombre_completo")
                    oListadoPersonal.Add(oPersonal)
                End While
                dr.Close()
                Return oListadoPersonal
            Catch ex As System.Exception
                Throw ex
            Finally
                sqlConn.Close()
            End Try
        End Function

#End Region

    End Class

End Namespace

