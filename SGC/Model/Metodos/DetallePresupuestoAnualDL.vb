Imports SGC.Model
Imports SGC.Model.Entidades
Imports SGC.Model.Interfaces
Imports System.Configuration
Imports System.Data.SqlClient

Public Class DetallePresupuestoAnualDL
    Implements IDetallePresupuestoAnual



#Region "Select"

    Public Function ListarDetallePresupuestoAnual(id_presupuesto As Integer?) As System.Collections.Generic.List(Of SGC.Model.Entidades.DetallePresupuestoAnualBE) Implements SGC.Model.Interfaces.IDetallePresupuestoAnual.ListarDetallePresupuestoAnual
        Dim oListadoDetalle As New List(Of DetallePresupuestoAnualBE)
        Dim oDetalle As DetallePresupuestoAnualBE
        Dim strConn As String = ConfigurationManager.ConnectionStrings("SGC").ConnectionString
        Dim sqlConn As New SqlConnection(strConn)
        Dim sqlCmd As New SqlCommand("comite.SP_LISTAR_DETALLE_PRESUPUESTO_ANUAL", sqlConn)
        Dim dr As SqlDataReader = Nothing
        sqlCmd.CommandType = CommandType.StoredProcedure
        sqlCmd.Parameters.Add("@id_presupuesto", SqlDbType.Int).Value = id_presupuesto

        Try
            sqlConn.Open()
            dr = sqlCmd.ExecuteReader()

            While dr.Read()
                oDetalle = New DetallePresupuestoAnualBE
                oDetalle.id_detalle = dr("id_detalle")
                oDetalle.id_presupuesto_anual = dr("id_presupuesto_anual")
                oDetalle.idItem = dr("id_item")
                oDetalle.tipo_item = dr("tipo_item")
                oDetalle.cantidad = dr("cantidad")
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

    Public Function ObtenerRecursosPersonalAnual(id_plan As Integer?) As System.Collections.Generic.List(Of SGC.Model.Entidades.DetallePresupuestoAnualBE) Implements SGC.Model.Interfaces.IDetallePresupuestoAnual.ObtenerRecursosPersonalAnual
        Dim oListadoDetalle As New List(Of DetallePresupuestoAnualBE)
        Dim oDetalle As DetallePresupuestoAnualBE
        Dim strConn As String = ConfigurationManager.ConnectionStrings("SGC").ConnectionString
        Dim sqlConn As New SqlConnection(strConn)
        Dim sqlCmd As New SqlCommand("comite.SP_LISTAR_RECURSOS_TIPO_PERSONAL", sqlConn)
        Dim dr As SqlDataReader = Nothing
        sqlCmd.CommandType = CommandType.StoredProcedure
        sqlCmd.Parameters.Add("@id_plan", SqlDbType.Int).Value = id_plan

        Try
            sqlConn.Open()
            dr = sqlCmd.ExecuteReader()

            While dr.Read()
                oDetalle = New DetallePresupuestoAnualBE
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

    Public Function InsertarDetallePresupuestoAnual(ByRef oDetallePresupuesto As SGC.Model.Entidades.DetallePresupuestoAnualBE) As Integer Implements SGC.Model.Interfaces.IDetallePresupuestoAnual.InsertarDetallePresupuestoAnual

        Dim strConn As String = ConfigurationManager.ConnectionStrings("SGC").ConnectionString
        Dim sqlConn As New SqlConnection(strConn)
        Dim sqlCmd As New SqlCommand("comite.SP_INSERTAR_DETALLE_PRESUPUESTO_ANUAL", sqlConn)

        Dim recordId As Integer = 0
        sqlCmd.CommandType = CommandType.StoredProcedure
        sqlCmd.Parameters.Add("@id_presupuesto", SqlDbType.VarChar).Value = oDetallePresupuesto.id_presupuesto_anual
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

