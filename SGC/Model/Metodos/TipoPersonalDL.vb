﻿Imports SGC.Model.Interfaces
Imports SGC.Model.Entidades
Imports System.Data
Imports System.Data.SqlClient
Imports System.Text
Imports System.Configuration

Namespace SGC.Model.Metodos

    Public Class TipoPersonalDL
        Implements ITipoPersonal

#Region "Select"

        Public Function ListarTipoPersonal(ByVal descripcion As String) As System.Collections.Generic.List(Of Entidades.TipoPersonalBE) Implements Interfaces.ITipoPersonal.ListarTipoPersonal
            Dim oListadoTipos As New List(Of TipoPersonalBE)
            Dim oTipo As TipoPersonalBE
            Dim strConn As String = ConfigurationManager.ConnectionStrings("SGC").ConnectionString
            Dim sqlConn As New SqlConnection(strConn)
            Dim sqlCmd As New SqlCommand("comite.SP_LISTAR_TIPOS_PERSONAL", sqlConn)
            Dim dr As SqlDataReader = Nothing
            sqlCmd.CommandType = CommandType.StoredProcedure
            sqlCmd.Parameters.Add("@descripcion", SqlDbType.VarChar).Value = descripcion

            Try
                sqlConn.Open()
                dr = sqlCmd.ExecuteReader()

                While dr.Read()
                    oTipo = New TipoPersonalBE
                    oTipo.id_tipo_personal = dr("id_tipo_personal")
                    oTipo.descripcion = dr("descripcion")
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

        Public Function ListarTipoPersonalXActividad(ByVal id_actividad As Integer) As System.Collections.Generic.List(Of Entidades.TipoPersonalBE) Implements Interfaces.ITipoPersonal.ListarTipoPersonalXActividad
            Dim oListadoTipos As New List(Of TipoPersonalBE)
            Dim oTipo As TipoPersonalBE
            Dim strConn As String = ConfigurationManager.ConnectionStrings("SGC").ConnectionString
            Dim sqlConn As New SqlConnection(strConn)
            Dim sqlCmd As New SqlCommand("comite.SP_LISTAR_TIPOPERSONAL_X_ACTIVIDAD", sqlConn)
            Dim dr As SqlDataReader = Nothing
            sqlCmd.CommandType = CommandType.StoredProcedure
            sqlCmd.Parameters.Add("@id_actividad", SqlDbType.Int).Value = id_actividad

            Try
                sqlConn.Open()
                dr = sqlCmd.ExecuteReader()

                While dr.Read()
                    oTipo = New TipoPersonalBE
                    oTipo.id_tipo_personal = dr("id_tipo_personal")
                    oTipo.descripcion = dr("descripcion")
                    oTipo.cantidad = dr("cantidad")
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

        Public Function ObtenerTipoPersonalDemanda(id_comite As String, id_tipo As String) As System.Collections.Generic.List(Of Entidades.TipoPersonalBE) Implements Interfaces.ITipoPersonal.ObtenerTipoPersonalDemanda
            Dim oListadoTipoPersonal As New List(Of TipoPersonalBE)
            Dim oTipoPersonal As TipoPersonalBE
            Dim strConn As String = ConfigurationManager.ConnectionStrings("SGC").ConnectionString
            Dim sqlConn As New SqlConnection(strConn)
            Dim sqlCmd As New SqlCommand("comite.SP_OBTENER_TIPOPERSONAL_MAX_DEMANDA", sqlConn)
            Dim dr As SqlDataReader = Nothing
            sqlCmd.CommandType = CommandType.StoredProcedure
            sqlCmd.Parameters.Add("@id_comite", SqlDbType.VarChar).Value = id_comite
            sqlCmd.Parameters.Add("@id_tipo_act", SqlDbType.VarChar).Value = id_tipo

            Try
                sqlConn.Open()
                dr = sqlCmd.ExecuteReader()

                While dr.Read()
                    oTipoPersonal = New TipoPersonalBE
                    oTipoPersonal.id_tipo_personal = dr("id_recurso")
                    oTipoPersonal.descripcion = dr("descripcion")
                    oTipoPersonal.cantidad = dr("cant")
                    oListadoTipoPersonal.Add(oTipoPersonal)
                End While
                dr.Close()
                Return oListadoTipoPersonal
            Catch ex As System.Exception
                Throw ex
            Finally
                sqlConn.Close()
            End Try
        End Function

#End Region

    End Class

End Namespace

