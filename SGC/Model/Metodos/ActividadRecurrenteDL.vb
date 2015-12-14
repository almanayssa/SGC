Imports SGC.Model.Interfaces
Imports SGC.Model.Entidades
Imports System.Data
Imports System.Data.SqlClient
Imports System.Text
Imports System.Configuration

Namespace SGC.Model.Metodos

    Public Class ActividadRecurrenteDL
        Implements IActividadRecurrente

#Region "Select"

        Public Function ListarActividadesRecurrentes(ByVal id_comite As String, ByVal fec_ini As DateTime, ByVal fec_fin As DateTime) As System.Collections.Generic.List(Of Entidades.ActividadRecurrenteBE) Implements Interfaces.IActividadRecurrente.ListarActividadesRecurrentes
            Dim oListadoActividadesRecurrentes As New List(Of ActividadRecurrenteBE)
            Dim oActividadRecurrente As ActividadRecurrenteBE
            Dim strConn As String = ConfigurationManager.ConnectionStrings("SGC").ConnectionString
            Dim sqlConn As New SqlConnection(strConn)
            Dim sqlCmd As New SqlCommand("comite.SP_LISTAR_ACTIVIDADES_RECURRENTES", sqlConn)
            Dim dr As SqlDataReader = Nothing
            sqlCmd.CommandType = CommandType.StoredProcedure
            sqlCmd.Parameters.Add("@id_comite", SqlDbType.VarChar).Value = id_comite
            sqlCmd.Parameters.Add("@fec_ini", SqlDbType.DateTime).Value = fec_ini
            sqlCmd.Parameters.Add("@fec_fin", SqlDbType.DateTime).Value = fec_fin

            Try
                sqlConn.Open()
                dr = sqlCmd.ExecuteReader()

                While dr.Read()
                    oActividadRecurrente = New ActividadRecurrenteBE
                    oActividadRecurrente.nombre = dr("nombre")
                    oActividadRecurrente.descripcion = dr("descripcion")
                    oActividadRecurrente.id_tipo_act = dr("id_tipo_act")
                    oActividadRecurrente.desc_tipo = dr("desc_tipo")
                    oActividadRecurrente.id_cattipo_act = IIf(dr("id_cattipo_act") Is DBNull.Value, Nothing, dr("id_cattipo_act"))
                    oActividadRecurrente.desc_cat = IIf(dr("desc_cat") Is DBNull.Value, Nothing, dr("desc_cat"))
                    oActividadRecurrente.fecha_ini = IIf(dr("fecha_ini") Is DBNull.Value, Nothing, dr("fecha_ini"))
                    oActividadRecurrente.fecha_fin = IIf(dr("fecha_fin") Is DBNull.Value, Nothing, dr("fecha_fin"))
                    oActividadRecurrente.monto_pago = dr("monto_pago")
                    oActividadRecurrente.vacantes = dr("vacantes")
                    oListadoActividadesRecurrentes.Add(oActividadRecurrente)
                End While
                dr.Close()
                Return oListadoActividadesRecurrentes
            Catch ex As System.Exception
                Throw ex
            Finally
                sqlConn.Close()
            End Try
        End Function

#End Region

#Region "Insert"

        Public Function InsertarActividadRecurrente(ByRef oActividadRecurrente As Entidades.ActividadRecurrenteBE) As Integer Implements Interfaces.IActividadRecurrente.InsertarActividadRecurrente
            Dim strConn As String = ConfigurationManager.ConnectionStrings("SGC").ConnectionString
            Dim sqlConn As New SqlConnection(strConn)
            Dim sqlCmd As New SqlCommand("comite.SP_INSERTAR_ACTIVIDAD_RECURRENTE", sqlConn)

            Dim recordId As Integer = 0
            sqlCmd.CommandType = CommandType.StoredProcedure

            sqlCmd.Parameters.Add("@tipo", SqlDbType.Char).Value = IIf(oActividadRecurrente.tipo Is Nothing, DBNull.Value, oActividadRecurrente.tipo)
            sqlCmd.Parameters.Add("@num_rep", SqlDbType.Int).Value = IIf(oActividadRecurrente.num_rep Is Nothing, DBNull.Value, oActividadRecurrente.num_rep)
            sqlCmd.Parameters.Add("@chk_dom", SqlDbType.Bit).Value = IIf(oActividadRecurrente.chk_dom Is Nothing, DBNull.Value, oActividadRecurrente.chk_dom)
            sqlCmd.Parameters.Add("@chk_lun", SqlDbType.Bit).Value = IIf(oActividadRecurrente.chk_lun Is Nothing, DBNull.Value, oActividadRecurrente.chk_lun)
            sqlCmd.Parameters.Add("@chk_mar", SqlDbType.Bit).Value = IIf(oActividadRecurrente.chk_mar Is Nothing, DBNull.Value, oActividadRecurrente.chk_mar)
            sqlCmd.Parameters.Add("@chk_mie", SqlDbType.Bit).Value = IIf(oActividadRecurrente.chk_mie Is Nothing, DBNull.Value, oActividadRecurrente.chk_mie)
            sqlCmd.Parameters.Add("@chk_jue", SqlDbType.Bit).Value = IIf(oActividadRecurrente.chk_jue Is Nothing, DBNull.Value, oActividadRecurrente.chk_jue)
            sqlCmd.Parameters.Add("@chk_vie", SqlDbType.Bit).Value = IIf(oActividadRecurrente.chk_vie Is Nothing, DBNull.Value, oActividadRecurrente.chk_vie)
            sqlCmd.Parameters.Add("@chk_sab", SqlDbType.Bit).Value = IIf(oActividadRecurrente.chk_sab Is Nothing, DBNull.Value, oActividadRecurrente.chk_sab)
            sqlCmd.Parameters.Add("@dia_mes", SqlDbType.Int).Value = IIf(oActividadRecurrente.dia_mes Is Nothing, DBNull.Value, oActividadRecurrente.dia_mes)
            sqlCmd.Parameters.Add("@ordinal", SqlDbType.Int).Value = IIf(oActividadRecurrente.ordinal Is Nothing, DBNull.Value, oActividadRecurrente.ordinal)
            sqlCmd.Parameters.Add("@dia_semana", SqlDbType.Int).Value = IIf(oActividadRecurrente.dia_semana Is Nothing, DBNull.Value, oActividadRecurrente.dia_semana)
            sqlCmd.Parameters.Add("@fecha_ini", SqlDbType.DateTime).Value = IIf(oActividadRecurrente.fecha_ini Is Nothing, DBNull.Value, oActividadRecurrente.fecha_ini)
            sqlCmd.Parameters.Add("@fecha_fin", SqlDbType.DateTime).Value = IIf(oActividadRecurrente.fecha_fin Is Nothing, DBNull.Value, oActividadRecurrente.fecha_fin)
            sqlCmd.Parameters.Add("@id_espacio", SqlDbType.Int).Value = IIf(oActividadRecurrente.id_espacio Is Nothing, DBNull.Value, oActividadRecurrente.id_espacio)
            sqlCmd.Parameters.Add("@vacantes", SqlDbType.Int).Value = IIf(oActividadRecurrente.vacantes Is Nothing, DBNull.Value, oActividadRecurrente.vacantes)
            sqlCmd.Parameters.Add("@hora_ini", SqlDbType.Time).Value = IIf(oActividadRecurrente.hora_ini Is Nothing, DBNull.Value, oActividadRecurrente.hora_ini)
            sqlCmd.Parameters.Add("@hora_fin", SqlDbType.Time).Value = IIf(oActividadRecurrente.hora_fin Is Nothing, DBNull.Value, oActividadRecurrente.hora_fin)
            sqlCmd.Parameters.Add("@nombre", SqlDbType.VarChar).Value = IIf(oActividadRecurrente.nombre Is Nothing, DBNull.Value, oActividadRecurrente.nombre)
            sqlCmd.Parameters.Add("@descripcion", SqlDbType.VarChar).Value = IIf(oActividadRecurrente.descripcion Is Nothing, DBNull.Value, oActividadRecurrente.descripcion)
            sqlCmd.Parameters.Add("@id_comite", SqlDbType.VarChar).Value = IIf(oActividadRecurrente.id_comite Is Nothing, DBNull.Value, oActividadRecurrente.id_comite)
            sqlCmd.Parameters.Add("@id_tipo_act", SqlDbType.VarChar).Value = IIf(oActividadRecurrente.id_tipo_act Is Nothing, DBNull.Value, oActividadRecurrente.id_tipo_act)
            sqlCmd.Parameters.Add("@id_cattipo_act", SqlDbType.Int).Value = IIf(oActividadRecurrente.id_cattipo_act Is Nothing, DBNull.Value, oActividadRecurrente.id_cattipo_act)
            sqlCmd.Parameters.Add("@monto_pago", SqlDbType.Decimal).Value = IIf(oActividadRecurrente.monto_pago Is Nothing, DBNull.Value, oActividadRecurrente.monto_pago)

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

