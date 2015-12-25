Imports SGC.Model.Interfaces
Imports SGC.Model.Entidades
Imports System.Data
Imports System.Data.SqlClient
Imports System.Text
Imports System.Configuration

Namespace SGC.Model.Metodos

    Public Class ActividadDetalleDL
        Implements IActividadDetalle

#Region "Select"

        Public Function ListarDetallesXActividad(id_actividad As Integer) As System.Collections.Generic.List(Of Entidades.ActividadDetalleBE) Implements Interfaces.IActividadDetalle.ListarDetallesXActividad
            Dim oListadoActividadDetalles As New List(Of ActividadDetalleBE)
            Dim oActividadDetalle As ActividadDetalleBE
            Dim strConn As String = ConfigurationManager.ConnectionStrings("SGC").ConnectionString
            Dim sqlConn As New SqlConnection(strConn)
            Dim sqlCmd As New SqlCommand("comite.SP_LISTAR_DETALLES_X_ACTIVIDAD", sqlConn)
            Dim dr As SqlDataReader = Nothing
            sqlCmd.CommandType = CommandType.StoredProcedure
            sqlCmd.Parameters.Add("@id_actividad", SqlDbType.Int).Value = id_actividad

            Try
                sqlConn.Open()
                dr = sqlCmd.ExecuteReader()

                While dr.Read()
                    oActividadDetalle = New ActividadDetalleBE
                    oActividadDetalle.id_actividad_detalle = dr("id_actividad_detalle")
                    oActividadDetalle.fecha_ini = dr("fecha_ini")
                    oActividadDetalle.hora_ini = dr("hora_ini")
                    oActividadDetalle.fecha_fin = dr("fecha_fin")
                    oActividadDetalle.hora_fin = dr("hora_fin")
                    oActividadDetalle.id_sede = dr("id_sede")
                    oActividadDetalle.des_sede = dr("des_sede")
                    oActividadDetalle.id_lugar = dr("id_lugar")
                    oActividadDetalle.id_espacio = dr("id_espacio")
                    oActividadDetalle.nombre_espacio = dr("nombre")
                    oActividadDetalle.vacantes = dr("vacantes")
                    oListadoActividadDetalles.Add(oActividadDetalle)
                End While
                dr.Close()
                Return oListadoActividadDetalles
            Catch ex As System.Exception
                Throw ex
            Finally
                sqlConn.Close()
            End Try
        End Function

#End Region

    End Class

End Namespace

