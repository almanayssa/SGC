Imports SGC.Model.Interfaces
Imports SGC.Model.Entidades
Imports System.Data
Imports System.Data.SqlClient
Imports System.Text
Imports System.Configuration

Namespace SGC.Model.Metodos

    Public Class EncuestaDetalleDL
        Implements IEncuestaDetalle

#Region "Select"

        Public Function ListarEncuestaDetalle(id_encuesta As Integer) As List(Of Entidades.EncuestaDetalleBE) Implements Interfaces.IEncuestaDetalle.ListarEncuestaDetalle
            Dim oListadoEncuestaDetalle As New List(Of EncuestaDetalleBE)
            Dim oEncuestaDetalle As New EncuestaDetalleBE
            Dim strConn As String = ConfigurationManager.ConnectionStrings("SGC").ConnectionString
            Dim sqlConn As New SqlConnection(strConn)
            Dim sqlCmd As New SqlCommand("comite.SP_LISTAR_ENCUESTA_DETALLE", sqlConn)
            Dim dr As SqlDataReader = Nothing
            sqlCmd.CommandType = CommandType.StoredProcedure
            sqlCmd.Parameters.Add("@id_encuesta", SqlDbType.Int).Value = id_encuesta

            Try
                sqlConn.Open()
                dr = sqlCmd.ExecuteReader()

                While dr.Read()
                    oEncuestaDetalle = New EncuestaDetalleBE
                    oEncuestaDetalle.id_detalle = dr("id_detalle")
                    oEncuestaDetalle.pregunta = dr("pregunta")
                    oEncuestaDetalle.pregunta = dr("opcion1")
                    oEncuestaDetalle.pregunta = dr("opcion2")
                    oEncuestaDetalle.pregunta = dr("opcion3")
                    oListadoEncuestaDetalle.Add(oEncuestaDetalle)
                End While
                dr.Close()
                Return oListadoEncuestaDetalle
            Catch ex As System.Exception
                Throw ex
            Finally
                sqlConn.Close()
            End Try
        End Function

#End Region

#Region "Insert"

        Public Function InsertarEncuestaDetalle(ByRef oEncuestaDetalle As Entidades.EncuestaDetalleBE) As Integer Implements Interfaces.IEncuestaDetalle.InsertarEncuestaDetalle
            Dim strConn As String = ConfigurationManager.ConnectionStrings("SGC").ConnectionString
            Dim sqlConn As New SqlConnection(strConn)
            Dim sqlCmd As New SqlCommand("comite.SP_INSERTAR_ENCUESTA", sqlConn)

            Dim recordId As Integer = 0
            sqlCmd.CommandType = CommandType.StoredProcedure
            sqlCmd.Parameters.Add("@id_encuesta", SqlDbType.Int).Value = oEncuestaDetalle.id_encuesta
            sqlCmd.Parameters.Add("@pregunta", SqlDbType.VarChar).Value = oEncuestaDetalle.pregunta
            sqlCmd.Parameters.Add("@opcion1", SqlDbType.Int).Value = oEncuestaDetalle.opcion1
            sqlCmd.Parameters.Add("@opcion2", SqlDbType.Int).Value = oEncuestaDetalle.opcion2
            sqlCmd.Parameters.Add("@opcion3", SqlDbType.Int).Value = oEncuestaDetalle.opcion3

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

