Imports System.Xml

Namespace SGC.Model.Entidades
    Public Class PlanAnualBE

        Private _id_plan As Integer
        Public Property id_plan() As Integer
            Get
                Return _id_plan
            End Get
            Set(ByVal value As Integer)
                _id_plan = value
            End Set
        End Property

        Private _descripcion As String
        Public Property descripcion() As String
            Get
                Return _descripcion
            End Get
            Set(ByVal value As String)
                _descripcion = value
            End Set
        End Property

        Private _fec_ini As DateTime
        Public Property fec_ini() As DateTime
            Get
                Return _fec_ini
            End Get
            Set(ByVal value As DateTime)
                _fec_ini = value
            End Set
        End Property

        Private _fec_fin As DateTime
        Public Property fec_fin() As DateTime
            Get
                Return _fec_fin
            End Get
            Set(ByVal value As DateTime)
                _fec_fin = value
            End Set
        End Property

        Private _fec_lim_pres As DateTime
        Public Property fec_lim_pres() As DateTime
            Get
                Return _fec_lim_pres
            End Get
            Set(ByVal value As DateTime)
                _fec_lim_pres = value
            End Set
        End Property

        Private _anio As String
        Public Property anio() As String
            Get
                Return _anio
            End Get
            Set(ByVal value As String)
                _anio = value
            End Set
        End Property

        Private _id_comite As String
        Public Property id_comite() As String
            Get
                Return _id_comite
            End Get
            Set(ByVal value As String)
                _id_comite = value
            End Set
        End Property

        Private _id_estado As String
        Public Property id_estado() As String
            Get
                Return _id_estado
            End Get
            Set(ByVal value As String)
                _id_estado = value
            End Set
        End Property

        Private _ListadoActividades As List(Of ActividadBE)
        Public Property ListadoActividades As List(Of ActividadBE)
            Get
                Return _ListadoActividades
            End Get
            Set(ByVal value As List(Of ActividadBE))
                _ListadoActividades = value
            End Set
        End Property


        Public Property comite As String
        Public Property estado As String



        Public Function GetActividadesPlanXML() As String
            Dim objXMLDoc As New XmlDocument
            Dim objNode As XmlNode

            'Se crea un nodo elemento XML
            objNode = objXMLDoc.CreateElement("ITEMS")

            'Se agrega el nodo al Documento XML
            objXMLDoc.AppendChild(objNode)

            'Se itera la coleccion para generar la estructura XML
            For Each obj As ActividadBE In ListadoActividades
                objNode = objXMLDoc.CreateElement("ITEM")

                Dim Node1 As XmlNode
                Node1 = objXMLDoc.CreateAttribute("id_actividad")
                Node1.Value = obj.id_actividad

                Dim Node2 As XmlNode
                Node2 = objXMLDoc.CreateAttribute("id_plan")
                Node2.Value = obj.id_plan

                objNode.Attributes.Append(Node1)
                objNode.Attributes.Append(Node2)

                objXMLDoc.DocumentElement.AppendChild(objNode)
            Next

            Return objXMLDoc.InnerXml
        End Function


    End Class

End Namespace

