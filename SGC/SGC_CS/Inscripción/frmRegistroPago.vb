Imports SGC.Model.Entidades
Imports SGC.Controller

Public Class frmRegistroPago

    Dim bc As New BusinessController
    Private _id_socio As String
    Private doc As DocVenBE

#Region "Inicializacion"

    Public Sub New()

        InitializeComponent()

        dgvArticulos.AutoGenerateColumns = False

        cboTipoPago.ValueMember = "id_tipo_pago"
        cboTipoPago.DisplayMember = "des_tip"

        colDesArt.DataPropertyName = "articulo"
        colConcepto.DataPropertyName = "concepto"
        colCant.DataPropertyName = "cant_art_pro"
        colAbr.DataPropertyName = "abr_mon"
        colTotal.DataPropertyName = "mon_art_pro"

    End Sub

#End Region

#Region "Metodos Controles"

    Private Sub btnBuscar_Click(sender As System.Object, e As System.EventArgs) Handles btnBuscar.Click
        Dim frmBuscarSocio As New frmBuscarSocio
        frmBuscarSocio.ShowDialog()

        If frmBuscarSocio.SocioSeleccionado IsNot Nothing Then

            CargarSocio(frmBuscarSocio.SocioSeleccionado)

        End If
    End Sub

    Private Sub btnDocumento_Click(sender As System.Object, e As System.EventArgs) Handles btnDocumento.Click
        Dim frm As New frmListadoDocumentos
        frm.id_socio = _id_socio
        frm.ShowDialog()

        If frm.DocSeleccionado IsNot Nothing Then
            doc = New DocVenBE
            doc = frm.DocSeleccionado
            CargarDocumento(frm.DocSeleccionado)

        End If
    End Sub

    Private Sub tsbGuardar_Click(sender As System.Object, e As System.EventArgs) Handles tsbGuardar.Click
        GuardarPago()
    End Sub

    Private Sub tsbLimpiar_Click(sender As System.Object, e As System.EventArgs) Handles tsbLimpiar.Click
        doc = Nothing
        _id_socio = ""
        Limpiar()
    End Sub

#End Region

#Region "Cargar"

    Private Sub frmRegistroPago_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        ListarTipo()
    End Sub

#End Region

#Region "Metodos Personalizados"

    Private Sub CargarSocio(ByRef oSocio As SocioBE)

        txtAccion.Text = oSocio.id_accion
        txtNombre.Text = oSocio.nombre_completo
        _id_socio = oSocio.id_socio

    End Sub

    Private Sub ListarTipo()

        Dim ListadoTipo As List(Of TipoPagoBE) = bc.ListarTiposPago()
        cboTipoPago.DataSource = Nothing
        cboTipoPago.DataSource = ListadoTipo
    End Sub

    Private Sub CargarDocumento(ByRef oDoc As DocVenBE)

        lblTipoDoc.Text = oDoc.tipo_doc
        lblSerie.Text = oDoc.id_serie
        lblCorrelativo.Text = oDoc.id_correlativo
        txtObservacion.Text = oDoc.obs_doc
        txtTotal.Text = oDoc.tot_mon

        Dim ListadoArtDocs As List(Of ArticuloCobranzaBE) = bc.ListarArticulosCobranza(oDoc.id_serie, oDoc.id_correlativo, oDoc.id_tipo_doc)
        dgvArticulos.DataSource = Nothing
        dgvArticulos.DataSource = ListadoArtDocs


    End Sub

    Private Sub GuardarPago()

        If ValidarCamposRequeridos() <> String.Empty Then
            MessageBox.Show(ValidarCamposRequeridos, "Información")
            Exit Sub
        End If

        Dim oPago As New CanjeAdelantosBE
        oPago.id_serie2 = doc.id_serie
        oPago.id_correlativo2 = doc.id_correlativo
        oPago.id_tipo_doc2 = doc.id_tipo_doc
        oPago.tot_doc = doc.tot_mon
        oPago.pago = txtTotal.Text
        oPago.id_tipo_pago = cboTipoPago.SelectedValue
        oPago.id_sede = "002"
        oPago.pago_dolares = oPago.pago * 2.85
        oPago.nro_tarjeta = ""
        oPago.nro_boucher = ""

        oPago.id_canje_adelantos = bc.InsertarCanjeAdelantos(oPago)

        If oPago.id_canje_adelantos = 0 Then
            MessageBox.Show("Error al grabar", "Información")
        Else
            MessageBox.Show("El pago se registró satisfactoriamente", "Información")
            
        End If
    End Sub

    Private Function ValidarCamposRequeridos() As String
        Dim msg As String = String.Empty

        If txtAccion.Text.Trim = String.Empty Then
            msg &= vbCrLf & "- Ingrese un asociado"
        End If

        If lblSerie.Text.Trim = String.Empty Then
            msg &= vbCrLf & "- Seleccione un documento a pagar"
        End If

        Return msg
    End Function

    Private Sub Limpiar()
        txtAccion.Text = ""
        txtNombre.Text = ""
        lblSerie.Text = ""
        lblCorrelativo.Text = ""
        lblTipoDoc.Text = ""
        dgvArticulos.DataSource = Nothing
        txtTotal.Text = 0.0
        txtObservacion.Text = ""
    End Sub

#End Region

End Class
