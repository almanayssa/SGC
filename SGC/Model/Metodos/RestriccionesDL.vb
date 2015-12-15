Imports SGC.Model.Interfaces
Imports SGC.Model.Entidades
Imports System.Data
Imports System.Data.SqlClient
Imports System.Text
Imports System.Configuration

Namespace SGC.Model.Metodos

    Public Class RestriccionesDL
        Implements IRestricciones

#Region "Select"

        Public Function ListarRestricciones() As System.Collections.Generic.List(Of Entidades.RestriccionesBE) Implements Interfaces.IRestricciones.ListarRestricciones
            Dim oListadoRestricciones As New List(Of RestriccionesBE)
            Dim oRestriccion As RestriccionesBE
            Dim strConn As String = ConfigurationManager.ConnectionStrings("SGC").ConnectionString
            Dim sqlConn As New SqlConnection(strConn)
            Dim sqlCmd As New SqlCommand("comite.SP_LISTAR_RESTRICCIONES", sqlConn)
            Dim dr As SqlDataReader = Nothing
            sqlCmd.CommandType = CommandType.StoredProcedure

            Try
                sqlConn.Open()
                dr = sqlCmd.ExecuteReader()

                While dr.Read()
                    oRestriccion = New RestriccionesBE
                    oRestriccion.id_restriccion = dr("id_restriccion")
                    oRestriccion.descripcion = dr("descripcion")
                    oRestriccion.flg_condicion = dr("flg_condicion")
                    oListadoRestricciones.Add(oRestriccion)
                End While
                dr.Close()
                Return oListadoRestricciones
            Catch ex As System.Exception
                Throw ex
            Finally
                sqlConn.Close()
            End Try
        End Function

        Public Function ListarRestriccionesXActividad(ByVal id_actividad As Integer) As System.Collections.Generic.List(Of Entidades.RestriccionesBE) Implements Interfaces.IRestricciones.ListarRestriccionesXActividad
            Dim oListadoRestricciones As New List(Of RestriccionesBE)
            Dim oRestriccion As RestriccionesBE
            Dim strConn As String = ConfigurationManager.ConnectionStrings("SGC").ConnectionString
            Dim sqlConn As New SqlConnection(strConn)
            Dim sqlCmd As New SqlCommand("comite.SP_LISTAR_RESTRICCIONES_X_ACTIVIDAD", sqlConn)
            Dim dr As SqlDataReader = Nothing
            sqlCmd.CommandType = CommandType.StoredProcedure
            sqlCmd.Parameters.Add("@id_actividad", SqlDbType.VarChar).Value = id_actividad

            Try
                sqlConn.Open()
                dr = sqlCmd.ExecuteReader()

                While dr.Read()
                    oRestriccion = New RestriccionesBE
                    oRestriccion.id_restriccion = dr("id_restriccion")
                    oRestriccion.descripcion = dr("descripcion")
                    oRestriccion.id_signo = dr("id_signo")
                    oRestriccion.valor = dr("valor")
                    oRestriccion.signo = dr("signo")
                    oListadoRestricciones.Add(oRestriccion)
                End While
                dr.Close()
                Return oListadoRestricciones
            Catch ex As System.Exception
                Throw ex
            Finally
                sqlConn.Close()
            End Try
        End Function

#End Region

    End Class

End Namespace

