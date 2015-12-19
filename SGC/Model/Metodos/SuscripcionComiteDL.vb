Imports SGC.Model.Interfaces
Imports SGC.Model.Entidades
Imports System.Data
Imports System.Data.SqlClient
Imports System.Text
Imports System.Configuration

Namespace SGC.Model.Metodos

    Public Class SuscripcionComiteDL
        Implements ISuscripcionComite


#Region "Select"

        Public Function ListarSuscripcionComites(ByVal id_socio As String) As System.Collections.Generic.List(Of Entidades.SuscripcionComiteBE) Implements Interfaces.ISuscripcionComite.ListarSuscripcionComites
            Dim oListadoSuscipcionComites As New List(Of SuscripcionComiteBE)
            Dim oSuscripcionComite As SuscripcionComiteBE
            Dim strConn As String = ConfigurationManager.ConnectionStrings("SGC").ConnectionString
            Dim sqlConn As New SqlConnection(strConn)
            Dim sqlCmd As New SqlCommand("comite.SP_LISTAR_COMITE_SUS", sqlConn)
            Dim dr As SqlDataReader = Nothing
            sqlCmd.CommandType = CommandType.StoredProcedure
            sqlCmd.Parameters.Add("@id_socio", SqlDbType.NVarChar).Value = id_socio

            Try
                sqlConn.Open()
                dr = sqlCmd.ExecuteReader()

                While dr.Read()
                    oSuscripcionComite = New SuscripcionComiteBE
                    oSuscripcionComite.id_comite = dr("id_comite")
                    oSuscripcionComite.id_socio = id_socio
                    oSuscripcionComite.comite = dr("nombre")
                    oSuscripcionComite.flg = dr("flg")
                    oListadoSuscipcionComites.Add(oSuscripcionComite)
                End While
                dr.Close()
                Return oListadoSuscipcionComites
            Catch ex As System.Exception
                Throw ex
            Finally
                sqlConn.Close()
            End Try
        End Function

#End Region

#Region "Insert"

        Public Function InsertarSuscripcionComite(ByRef oSuscripcion As Entidades.SuscripcionComiteBE) As Integer Implements Interfaces.ISuscripcionComite.InsertarSuscripcionComite
            Dim strConn As String = ConfigurationManager.ConnectionStrings("SGC").ConnectionString
            Dim sqlConn As New SqlConnection(strConn)
            Dim sqlCmd As New SqlCommand("comite.SP_INSERTAR_SUSCRIPCION_COMITE", sqlConn)

            Dim recordId As Integer = 0
            sqlCmd.CommandType = CommandType.StoredProcedure
            sqlCmd.Parameters.Add("@id_comite", SqlDbType.VarChar).Value = IIf(oSuscripcion.id_comite Is Nothing, DBNull.Value, oSuscripcion.id_comite)
            sqlCmd.Parameters.Add("@id_socio", SqlDbType.VarChar).Value = IIf(oSuscripcion.id_socio Is Nothing, DBNull.Value, oSuscripcion.id_socio)
            
            Try
                sqlConn.Open()
                recordId = sqlCmd.ExecuteScalar()

                Return recordId
            Catch ex As System.Exception
                Throw ex
            Finally
                sqlConn.Close()
            End Try
        End Function

#End Region

#Region "Delete"

        Public Function BorrarSuscripcionComite(ByVal id_socio As String) As Integer Implements Interfaces.ISuscripcionComite.BorrarSuscripcionComite
            Dim strConn As String = ConfigurationManager.ConnectionStrings("SGC").ConnectionString
            Dim sqlConn As New SqlConnection(strConn)
            Dim sqlCmd As New SqlCommand("comite.SP_BORRAR_SUSCRIPCION_COMITE", sqlConn)

            Dim recordId As Integer = 0
            sqlCmd.CommandType = CommandType.StoredProcedure
            sqlCmd.Parameters.Add("@id_socio", SqlDbType.VarChar).Value = IIf(id_socio Is Nothing, DBNull.Value, id_socio)

            Try
                sqlConn.Open()
                recordId = sqlCmd.ExecuteScalar()

                Return recordId
            Catch ex As System.Exception
                Throw ex
            Finally
                sqlConn.Close()
            End Try
        End Function

#End Region

    End Class

End Namespace

