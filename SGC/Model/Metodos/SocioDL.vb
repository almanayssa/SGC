Imports SGC.Model
Imports SGC.Model.Entidades
Imports SGC.Model.Interfaces
Imports System.Configuration
Imports System.Data.SqlClient

Public Class SocioDL
    Implements ISocio


#Region "Select"

    Public Function ListarSocios(ByRef oSocioFiltro As SocioBE) As System.Collections.Generic.List(Of Entidades.SocioBE) Implements Interfaces.ISocio.ListarSocios
        Dim oListadoSocios As New List(Of SocioBE)
        Dim oSocio As SocioBE
        Dim strConn As String = ConfigurationManager.ConnectionStrings("SGC").ConnectionString
        Dim sqlConn As New SqlConnection(strConn)
        Dim sqlCmd As New SqlCommand("comite.SP_LISTAR_SOCIOS", sqlConn)
        Dim dr As SqlDataReader = Nothing
        sqlCmd.CommandType = CommandType.StoredProcedure
        sqlCmd.Parameters.Add("@id_accion", SqlDbType.NVarChar).Value = oSocioFiltro.id_accion
        sqlCmd.Parameters.Add("@nombre_completo", SqlDbType.VarChar).Value = oSocioFiltro.nombre_completo

        Try
            sqlConn.Open()
            dr = sqlCmd.ExecuteReader()

            While dr.Read()
                oSocio = New SocioBE
                oSocio.id_socio = dr("id_socio")
                oSocio.id_accion = dr("id_accion")
                oSocio.nombre_completo = dr("nombre_completo")
                oListadoSocios.Add(oSocio)
            End While
            dr.Close()
            Return oListadoSocios
        Catch ex As System.Exception
            Throw ex
        Finally
            sqlConn.Close()
        End Try
    End Function

#End Region

End Class

