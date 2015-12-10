Imports SGC.Model.Interfaces
Imports SGC.Model.Entidades
Imports System.Data
Imports System.Data.SqlClient
Imports System.Text
Imports System.Configuration

Namespace SGC.Model.Metodos

    Public Class CatTipoActividadDL
        Implements ICatTipoActividad

#Region "Select"

        Public Function ListarCatTipoActividad(ByVal id_tipo_act As String) As List(Of CatTipoActividadBE) Implements Interfaces.ICatTipoActividad.ListarCatTipoActividad
            Dim oListadoCatTipoActividad As New List(Of CatTipoActividadBE)
            Dim oCategoria As CatTipoActividadBE
            Dim strConn As String = ConfigurationManager.ConnectionStrings("SGC").ConnectionString
            Dim sqlConn As New SqlConnection(strConn)
            Dim sqlCmd As New SqlCommand("comite.SP_LISTAR_CATEGORIAS_ACTIVIDAD", sqlConn)
            Dim dr As SqlDataReader = Nothing
            sqlCmd.CommandType = CommandType.StoredProcedure
            sqlCmd.Parameters.Add("@id_tipo_act", SqlDbType.VarChar).Value = id_tipo_act

            Try
                sqlConn.Open()
                dr = sqlCmd.ExecuteReader()

                While dr.Read()
                    oCategoria = New CatTipoActividadBE
                    oCategoria.id_cattipo_act = dr("id_cattipo_act")
                    oCategoria.descripcion = dr("descripcion")
                    oListadoCatTipoActividad.Add(oCategoria)
                End While
                dr.Close()
                Return oListadoCatTipoActividad
            Catch ex As System.Exception
                Throw ex
            Finally
                sqlConn.Close()
            End Try
        End Function

#End Region

    End Class

End Namespace

