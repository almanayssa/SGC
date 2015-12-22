Imports SGC.Model
Imports SGC.Model.Entidades
Imports SGC.Model.Interfaces
Imports System.Configuration
Imports System.Data.SqlClient

Public Class DetallePresupuestoActDL
    Implements IDetallePresupuestoAct

#Region "Select"

    Public Function ListarDetallePresupuestoAct(id_presupuesto As Integer?) As System.Collections.Generic.List(Of SGC.Model.Entidades.DetallePresupuestoActBE) Implements SGC.Model.Interfaces.IDetallePresupuestoAct.ListarDetallePresupuestoAct
        Dim oListadoDetalle As New List(Of DetallePresupuestoActBE)
        Dim oDetalle As DetallePresupuestoActBE
        Dim strConn As String = ConfigurationManager.ConnectionStrings("SGC").ConnectionString
        Dim sqlConn As New SqlConnection(strConn)
        Dim sqlCmd As New SqlCommand("comite.SP_LISTAR_DETALLE_PRESUPUESTO_ACTIVIDAD", sqlConn)
        Dim dr As SqlDataReader = Nothing
        sqlCmd.CommandType = CommandType.StoredProcedure
        sqlCmd.Parameters.Add("@id_presupuesto", SqlDbType.Int).Value = id_presupuesto

        Try
            sqlConn.Open()
            dr = sqlCmd.ExecuteReader()

            While dr.Read()
                oDetalle = New DetallePresupuestoActBE
                oDetalle.id_detalle = dr("id_detalle")
                oDetalle.id_presupuesto_actividad = dr("id_presupuesto_actividad")
                oDetalle.idItem = dr("id_item")
                oDetalle.tipo_item = dr("tipo_item")
                oDetalle.cantidad = dr("cant")
                oDetalle.monto = dr("monto")
                oDetalle.descripcion = dr("descripcion")
                oListadoDetalle.Add(oDetalle)
            End While
            dr.Close()
            Return oListadoDetalle
        Catch ex As System.Exception
            Throw ex
        Finally
            sqlConn.Close()
        End Try

    End Function

    Public Function ObtenerRecursosPersonalAct(id_actividad As Integer?) As System.Collections.Generic.List(Of SGC.Model.Entidades.DetallePresupuestoActBE) Implements SGC.Model.Interfaces.IDetallePresupuestoAct.ObtenerRecursosPersonalAct
        Dim oListadoDetalle As New List(Of DetallePresupuestoActBE)
        Dim oDetalle As DetallePresupuestoActBE
        Dim strConn As String = ConfigurationManager.ConnectionStrings("SGC").ConnectionString
        Dim sqlConn As New SqlConnection(strConn)
        Dim sqlCmd As New SqlCommand("comite.SP_LISTAR_RECURSOS_TIPO_PERSONAL_ACT", sqlConn)
        Dim dr As SqlDataReader = Nothing
        sqlCmd.CommandType = CommandType.StoredProcedure
        sqlCmd.Parameters.Add("@id_actividad", SqlDbType.Int).Value = id_actividad

        Try
            sqlConn.Open()
            dr = sqlCmd.ExecuteReader()

            While dr.Read()
                oDetalle = New DetallePresupuestoActBE
                oDetalle.idItem = dr("id_item")
                oDetalle.tipo_item = dr("tipo_item")
                oDetalle.descripcion = dr("descripcion")
                oDetalle.cantidad = dr("cant")
                oDetalle.monto = dr("monto")
                oListadoDetalle.Add(oDetalle)
            End While
            dr.Close()
            Return oListadoDetalle
        Catch ex As System.Exception
            Throw ex
        Finally
            sqlConn.Close()
        End Try

    End Function


#End Region

#Region "Insert"

    Public Function InsertarDetallePresupuestoAct(ByRef oDetallePresupuesto As SGC.Model.Entidades.DetallePresupuestoActBE) As Integer Implements SGC.Model.Interfaces.IDetallePresupuestoAct.InsertarDetallePresupuestoAct

        Dim strConn As String = ConfigurationManager.ConnectionStrings("SGC").ConnectionString
        Dim sqlConn As New SqlConnection(strConn)
        Dim sqlCmd As New SqlCommand("comite.SP_INSERTAR_DETALLE_PRESUPUESTO_ACTIVIDAD", sqlConn)

        Dim recordId As Integer = 0
        sqlCmd.CommandType = CommandType.StoredProcedure
        sqlCmd.Parameters.Add("@id_presupuesto", SqlDbType.Int).Value = oDetallePresupuesto.id_presupuesto_actividad
        sqlCmd.Parameters.Add("@cantidad", SqlDbType.Int).Value = oDetallePresupuesto.cantidad
        sqlCmd.Parameters.Add("@monto", SqlDbType.Decimal).Value = oDetallePresupuesto.monto
        sqlCmd.Parameters.Add("@id_item", SqlDbType.Int).Value = oDetallePresupuesto.idItem
        sqlCmd.Parameters.Add("@tipo_item", SqlDbType.Char).Value = oDetallePresupuesto.tipo_item

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
