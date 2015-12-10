Imports SGC.Model.Interfaces
Imports SGC.Model.Entidades
Imports System.Data
Imports System.Data.SqlClient
Imports System.Text
Imports System.Configuration

Namespace SGC.Model.Metodos
    Public Class ActividadDL
        Implements IActividad


#Region "Select"

        'Public Function ObtenerActividad(ByVal id_actividad As Integer) As Entidades.ActividadBE Implements Interfaces.IActividad.ObtenerActividad
        '    Dim oActividad As New ActividadBE
        '    Dim strConn As String = ConfigurationManager.ConnectionStrings("SGC").ConnectionString
        '    Dim sqlConn As New SqlConnection(strConn)
        '    Dim sqlCmd As New SqlCommand("comite.SP_OBTENER_ACTIVIDAD", sqlConn)
        '    Dim dr As SqlDataReader = Nothing
        '    sqlCmd.CommandType = CommandType.StoredProcedure
        '    sqlCmd.Parameters.Add("@id_actividad", SqlDbType.Int).Value = id_actividad

        '    Try
        '        sqlConn.Open()
        '        dr = sqlCmd.ExecuteReader()

        '        If dr.Read() Then
        '            oActividad = New ActividadBE
        '            oActividad.id_actividad = dr("id_actividad")
        '            oActividad.fec_ini = dr("fec_ini")
        '            oActividad.fec_fin = IIf(dr("fec_fin") Is DBNull.Value, Nothing, dr("fec_fin"))
        '            oActividad.hora_ini = dr.GetTimeSpan(3)
        '            oActividad.hora_fin = dr.GetTimeSpan(4)
        '            oActividad.nombre = dr("nombre")
        '            oActividad.descripcion = dr("descripcion")
        '            oActividad.dias_registro = dr("dias_registro")
        '            oActividad.id_estado = dr("id_estado")
        '            oActividad.id_actividad_recurrente = IIf(dr("id_actividad_recurrente") Is DBNull.Value, Nothing, dr("id_actividad_recurrente"))
        '            oActividad.des_sede = dr("des_sede")
        '            oActividad.nom_lug = dr("nom_lug")
        '            oActividad.direccion = dr("direccion")
        '            oActividad.des_urbanizacion = dr("des_urbanizacion")
        '            oActividad.des_cal = dr("des_cal")
        '            oActividad.des_dis = dr("des_dis")
        '            oActividad.des_reg = dr("des_reg")
        '            oActividad.fec_registro = dr("fec_registro")
        '        End If
        '        dr.Close()
        '        Return oActividad
        '    Catch ex As System.Exception
        '        Throw ex
        '    Finally
        '        sqlConn.Close()
        '    End Try
        'End Function

        Public Function ListarActividades(ByVal id_comite As String, ByVal nombre As String) As System.Collections.Generic.List(Of Entidades.ActividadBE) Implements Interfaces.IActividad.ListarActividades
            Dim oListadoActividades As New List(Of ActividadBE)
            Dim oActividad As ActividadBE
            Dim strConn As String = ConfigurationManager.ConnectionStrings("SGC").ConnectionString
            Dim sqlConn As New SqlConnection(strConn)
            Dim sqlCmd As New SqlCommand("comite.SP_LISTAR_ACTIVIDADES", sqlConn)
            Dim dr As SqlDataReader = Nothing
            sqlCmd.CommandType = CommandType.StoredProcedure
            sqlCmd.Parameters.Add("@id_comite", SqlDbType.VarChar).Value = IIf(id_comite = "000", DBNull.Value, id_comite)
            sqlCmd.Parameters.Add("@nombre", SqlDbType.VarChar).Value = nombre

            Try
                sqlConn.Open()
                dr = sqlCmd.ExecuteReader()

                While dr.Read()
                    oActividad = New ActividadBE
                    oActividad.id_actividad = dr("id_actividad")
                    oActividad.nombre = dr("nombre")
                    oActividad.fec_ini = dr("fec_ini")
                    oActividad.fec_fin = IIf(dr("fec_fin") Is DBNull.Value, Nothing, dr("fec_fin"))
                    oActividad.hora_ini = dr.GetTimeSpan(4)
                    oActividad.hora_fin = dr.GetTimeSpan(5)
                    oActividad.id_comite = dr("id_comite")
                    oActividad.nombreComite = dr("nombreComite")
                    oListadoActividades.Add(oActividad)
                End While
                dr.Close()
                Return oListadoActividades
            Catch ex As System.Exception
                Throw ex
            Finally
                sqlConn.Close()
            End Try
        End Function

#End Region

    End Class
End Namespace

