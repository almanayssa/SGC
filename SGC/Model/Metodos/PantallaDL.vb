Imports SGC.Model.Interfaces
Imports SGC.Model.Entidades
Imports System.Data
Imports System.Data.SqlClient
Imports System.Text
Imports System.Configuration

Namespace SGC.Model.Metodos

    Public Class PantallaDL
        Implements IPantalla

#Region "Select"

        Public Function ListarOpciones() As System.Collections.Generic.List(Of Entidades.PantallaBE) Implements Interfaces.IPantalla.ListarOpciones
            Dim oListadoOpciones As New List(Of PantallaBE)
            Dim oOpcion As PantallaBE
            Dim strConn As String = ConfigurationManager.ConnectionStrings("SGC").ConnectionString
            Dim sqlConn As New SqlConnection(strConn)
            Dim sqlCmd As New SqlCommand("comite.SP_LISTAR_PANTALLAS", sqlConn)
            Dim dr As SqlDataReader = Nothing
            sqlCmd.CommandType = CommandType.StoredProcedure

            Try
                sqlConn.Open()
                dr = sqlCmd.ExecuteReader()

                While dr.Read()
                    oOpcion = New PantallaBE
                    oOpcion.id_pantalla = dr("id_pantalla")
                    oOpcion.nom_pantalla = dr("nom_pantalla")
                    oListadoOpciones.Add(oOpcion)
                End While
                dr.Close()
                Return oListadoOpciones
            Catch ex As System.Exception
                Throw ex
            Finally
                sqlConn.Close()
            End Try
        End Function

        Public Function ListarOpcionesXPerfil(ByVal id_perfil_usuario As Integer) As System.Collections.Generic.List(Of Entidades.PantallaBE) Implements Interfaces.IPantalla.ListarOpcionesXPerfil
            Dim oListadoOpciones As New List(Of PantallaBE)
            Dim oOpcion As PantallaBE
            Dim strConn As String = ConfigurationManager.ConnectionStrings("SGC").ConnectionString
            Dim sqlConn As New SqlConnection(strConn)
            Dim sqlCmd As New SqlCommand("comite.SP_LISTAR_OPCIONES_X_PERFIL", sqlConn)
            Dim dr As SqlDataReader = Nothing
            sqlCmd.CommandType = CommandType.StoredProcedure
            sqlCmd.Parameters.Add("@id_Perfil_Usuario", SqlDbType.VarChar).Value = id_perfil_usuario

            Try
                sqlConn.Open()
                dr = sqlCmd.ExecuteReader()

                While dr.Read()
                    oOpcion = New PantallaBE
                    oOpcion.id_Perfil_Usuario = dr("id_Perfil_Usuario")
                    oOpcion.id_pantalla = dr("id_pantalla")
                    oOpcion.nom_pantalla = dr("nom_pantalla")
                    oListadoOpciones.Add(oOpcion)
                End While
                dr.Close()
                Return oListadoOpciones
            Catch ex As System.Exception
                Throw ex
            Finally
                sqlConn.Close()
            End Try
        End Function

#End Region

    End Class

End Namespace

