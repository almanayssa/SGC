Imports SGC.Model.Interfaces
Imports SGC.Model.Entidades
Imports System.Data
Imports System.Data.SqlClient
Imports System.Text
Imports System.Configuration

Namespace SGC.Model.Metodos

    Public Class InscripcionDL
        Implements IInscripcion

#Region "Select"

        Public Function ListarInscripciones(id_socio As String) As List(Of Entidades.InscripcionBE) Implements Interfaces.IInscripcion.ListarInscripciones
            Dim oListadoInscripcion As New List(Of InscripcionBE)
            Dim oInscripcion As InscripcionBE
            Dim strConn As String = ConfigurationManager.ConnectionStrings("SGC").ConnectionString
            Dim sqlConn As New SqlConnection(strConn)
            Dim sqlCmd As New SqlCommand("comite.LISTAR_INSCRIPCIONES", sqlConn)
            Dim dr As SqlDataReader = Nothing
            sqlCmd.CommandType = CommandType.StoredProcedure
            sqlCmd.Parameters.Add("@id_socio", SqlDbType.VarChar).Value = id_socio

            Try
                sqlConn.Open()
                dr = sqlCmd.ExecuteReader()

                While dr.Read()
                    oInscripcion = New InscripcionBE
                    oInscripcion.nombre_actividad = dr("nombre")
                    oInscripcion.nombre_comite = dr("nombrecomite")
                    oInscripcion.tipo_actividad = dr("desc_tipo")
                    oInscripcion.fecha_registro = dr("fecha_registro")
                    oInscripcion.monto = dr("monto")
                    oListadoInscripcion.Add(oInscripcion)
                End While
                dr.Close()
                Return oListadoInscripcion
            Catch ex As System.Exception
                Throw ex
            Finally
                sqlConn.Close()
            End Try
        End Function

#End Region

#Region "Insert"
        
        Public Function InsertarInscripcion(ByRef oInscripcion As Entidades.InscripcionBE) As Integer Implements Interfaces.IInscripcion.InsertarInscripcion
            Dim strConn As String = ConfigurationManager.ConnectionStrings("SGC").ConnectionString
            Dim sqlConn As New SqlConnection(strConn)
            Dim sqlCmd As New SqlCommand("comite.SP_INSERTAR_INSCRIPCION", sqlConn)

            'Dim prm As New SqlParameter("@id", SqlDbType.Int)
            Dim recordId As Integer
            sqlCmd.CommandType = CommandType.StoredProcedure
            sqlCmd.Parameters.Add("@id_socio", SqlDbType.VarChar).Value = oInscripcion.id_socio
            If oInscripcion.serie <> "" AndAlso oInscripcion.correlativo <> "" Then
                sqlCmd.Parameters.Add("@tipo_doc", SqlDbType.VarChar).Value = oInscripcion.tipo_doc
                sqlCmd.Parameters.Add("@serie", SqlDbType.VarChar).Value = oInscripcion.serie
                sqlCmd.Parameters.Add("@correlativo", SqlDbType.VarChar).Value = oInscripcion.correlativo
            End If
            sqlCmd.Parameters.Add("@flg_web", SqlDbType.VarChar).Value = oInscripcion.flg_web
            sqlCmd.Parameters.Add("@monto", SqlDbType.Decimal).Value = oInscripcion.monto
            sqlCmd.Parameters.Add("@id_actividad", SqlDbType.Int).Value = oInscripcion.id_actividad

            Try
                sqlConn.Open()
                recordId = sqlCmd.ExecuteScalar()
                'recordId = CType(prm.Value, Integer)
                Return recordId
            Catch ex As System.Exception
                Throw ex
            Finally
                sqlConn.Close()
            End Try

        End Function

        Public Function InsertarInscrito(ByRef oPersona As Entidades.PersonaBE, ByVal entidad As String) As Integer Implements Interfaces.IInscripcion.InsertarInscrito
            Dim strConn As String = ConfigurationManager.ConnectionStrings("SGC").ConnectionString
            Dim sqlConn As New SqlConnection(strConn)
            Dim sqlCmd As New SqlCommand("comite.SP_INSERTAR_INSCRITO", sqlConn)
            Dim rows As Integer = 0
            sqlCmd.CommandType = CommandType.StoredProcedure
            sqlCmd.Parameters.Add("@id_inscripcion", SqlDbType.Int).Value = oPersona.id_inscripcion
            sqlCmd.Parameters.Add("@id_persona", SqlDbType.VarChar).Value = oPersona.id_persona
            sqlCmd.Parameters.Add("@tipo_familiar", SqlDbType.VarChar).Value = oPersona.tipo_familiar
            sqlCmd.Parameters.Add("@entidad", SqlDbType.VarChar).Value = entidad

            Try
                sqlConn.Open()
                rows = sqlCmd.ExecuteNonQuery()

                Return rows
            Catch ex As System.Exception
                Throw ex
            Finally
                sqlConn.Close()
            End Try

        End Function

#End Region

    End Class
End Namespace

