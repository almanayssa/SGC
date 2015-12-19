Imports SGC.Model.Interfaces
Imports SGC.Model.Entidades
Imports System.Data
Imports System.Data.SqlClient
Imports System.Text
Imports System.Configuration

Namespace SGC.Model.Metodos

    Public Class TipoPagoDL
        Implements ITipoPago

#Region "Select"

        Public Function ListarTiposPago() As System.Collections.Generic.List(Of Entidades.TipoPagoBE) Implements Interfaces.ITipoPago.ListarTiposPago
            Dim oListadoTipos As New List(Of TipoPagoBE)
            Dim oTipo As TipoPagoBE
            Dim strConn As String = ConfigurationManager.ConnectionStrings("SGC").ConnectionString
            Dim sqlConn As New SqlConnection(strConn)
            Dim sqlCmd As New SqlCommand("comite.SP_LISTAR_TIPOS_PAGO", sqlConn)
            Dim dr As SqlDataReader = Nothing
            sqlCmd.CommandType = CommandType.StoredProcedure

            Try
                sqlConn.Open()
                dr = sqlCmd.ExecuteReader()

                While dr.Read()
                    oTipo = New TipoPagoBE
                    oTipo.id_tipo_pago = dr("id_tipo_pago")
                    oTipo.des_tip = dr("des_tip")
                    oListadoTipos.Add(oTipo)
                End While
                dr.Close()
                Return oListadoTipos
            Catch ex As System.Exception
                Throw ex
            Finally
                sqlConn.Close()
            End Try
        End Function

#End Region

    End Class

End Namespace

