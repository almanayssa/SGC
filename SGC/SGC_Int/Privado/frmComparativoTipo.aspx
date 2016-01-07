<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Privado/PlantillaSGCInt.Master" CodeBehind="frmComparativoTipo.aspx.vb" Inherits="SGC_Int.frmComparativoTipo" %>

<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit" tagprefix="ajaxToolkit" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
   <ajaxToolkit:ToolkitScriptManager ID="ToolkitScriptManager1" runat="server">
    </ajaxToolkit:ToolkitScriptManager>
    <asp:UpdatePanel ID="upnlSemaforo" runat="server" UpdateMode="Conditional">
    <ContentTemplate>
    <div class="contenedor-pagina">
        <div class="contenedor-pagina-titulo">
            COMPARATIVO DE TIPO DE ACTIVIDAD
        </div>
        <br />
        <table id="tblComite" runat="server" border="0" cellpadding="0" cellspacing="0" width="918px">
            <tr>
                <td valign="top" style="width:700px;">
                    <asp:Label ID="lblMensaje" runat="server" Text="Para mostrar el semáforo, elegir los filtros deseados y hacer click en Generar."></asp:Label>
                    <asp:Label ID="lblTitulo" runat="server"></asp:Label>
                    <asp:Label ID="lblInformacionTipo" runat="server"></asp:Label>
                    <asp:GridView ID="gvwSemaforo" runat="server" AutoGenerateColumns="false" AllowPaging="false"
                        CssClass="tabla-grilla" Width="700px" BorderWidth="0px" BorderColor="White">
                        <HeaderStyle CssClass="tabla-grilla-cabecera" />
                        <RowStyle CssClass="tabla-grilla-filas" />
                        <Columns>                            
                            <asp:TemplateField HeaderText="Mes">
                                <ItemTemplate>
                                    <asp:Label ID="lblMes" runat="server" Text='<%#Eval("anio_mes") %>'></asp:Label>
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField HeaderText="Participantes">
                                <ItemTemplate>
                                    <asp:Label ID="lblParticipantes" runat="server" Text='<%#Eval("participantes") %>'></asp:Label>
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField HeaderText="Participantes Tipo 1">
                                <ItemTemplate>
                                    <asp:Label ID="lblParticipantes1" runat="server" Text='<%#Eval("participantes1") %>'></asp:Label>
                                </ItemTemplate>
                            </asp:TemplateField>                            
                            <asp:TemplateField HeaderText="Participantes Tipo 2">
                                <ItemTemplate>
                                    <asp:Label ID="lblParticipantes2" runat="server" Text='<%#Eval("participantes2") %>'></asp:Label>
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField HeaderText="Resultado">
                                <ItemTemplate>
                                    <asp:Image ID="imgSemaforo1" runat="server" ToolTip='<%#Eval("correlacion1") %>' ImageUrl='<%#IIf(Eval("correlacion1")>0.5,"~/App_Themes/img/semaforo_verde.jpg",IIf(Eval("correlacion1")<-0.5,"~/App_Themes/img/semaforo_rojo.jpg","~/App_Themes/img/semaforo_amarillo.jpg")) %>' />
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField HeaderText="Resultado">
                                <ItemTemplate>                                    
                                    <asp:Image ID="imgSemaforo2" runat="server" ToolTip='<%#Eval("correlacion2") %>' ImageUrl='<%#IIf(Eval("correlacion2")>0.5,"~/App_Themes/img/semaforo_verde.jpg",IIf(Eval("correlacion2")<-0.5,"~/App_Themes/img/semaforo_rojo.jpg","~/App_Themes/img/semaforo_amarillo.jpg")) %>' />
                                </ItemTemplate>
                            </asp:TemplateField>
                        </Columns>
                    </asp:GridView>
                    <div id="divLeyenda" runat="server" visible="false">
                        <fieldset>
                            <legend>Leyenda</legend>
                            <asp:Image ID="Image1" runat="server" ImageUrl="~/App_Themes/img/semaforo_rojo.jpg" />
                            <asp:Label ID="Label1" runat="server" Text="No se recomienda la creación de ambas actividades porque compiten entre sí."></asp:Label><br />
                            <asp:Image ID="Image2" runat="server" ImageUrl="~/App_Themes/img/semaforo_amarillo.jpg" />
                            <asp:Label ID="Label2" runat="server" Text="Se recomienda la creación de ambas o cualquiera de las actividades."></asp:Label><br />
                            <asp:Image ID="Image3" runat="server" ImageUrl="~/App_Themes/img/semaforo_verde.jpg" />
                            <asp:Label ID="Label3" runat="server" Text="Se recomienda la creación de ambas actividades porque colaboran entre sí."></asp:Label><br />                            
                        </fieldset>                        
                    </div>
                </td>
                <td style="width:10px;"></td>
                <td valign="top" style="width:208px;">
                    <fieldset style="width:100%">
                        <legend>Filtros</legend>
                        <table border="0" cellpadding="0" cellspacing="0">
                            <tr>
                                <td>Comité:</td>
                            </tr>
                            <tr>
                                <td><asp:DropDownList ID="ddlComite" runat="server" CssClass="estilo_textbox" AutoPostBack="true"></asp:DropDownList></td>       
                            </tr>
                        </table>
                        <br />
                        <table id="tblTipos" runat="server" border="0" cellpadding="0" cellspacing="0">
                            <tr>
                                <td>Tipo de Actividad:</td>
                            </tr>
                            <tr>
                                <td><asp:DropDownList ID="ddlTipoActividad" runat="server" CssClass="estilo_textbox" AutoPostBack="true"></asp:DropDownList></td>
                            </tr>
                        </table>
                        <br />
                        <table border="0" cellpadding="0" cellspacing="0">
                            <tr>
                                <td>Fecha Inicio:</td>
                            </tr>
                            <tr>
                                <td><asp:TextBox ID="txtFechaInicio" CssClass="estilo_textbox" runat="server"></asp:TextBox></td>
                            </tr>
                        </table>
                        <br />
                        <table border="0" cellpadding="0" cellspacing="0">
                            <tr>
                                <td>Fecha Fin:</td>
                            </tr>
                            <tr>
                                <td><asp:TextBox ID="txtFechaFin" CssClass="estilo_textbox" runat="server"></asp:TextBox></td>
                            </tr>
                        </table>
                        <br />
                        <table>
                            <tr>
                                <td>
                                    <asp:LinkButton ID="lbtnGenerar" runat="server" OnClick="lbtnGenerar_Click" CssClass="estilo_boton" Text="Generar"></asp:LinkButton>
                                </td>
                            </tr>
                        </table>
                    </fieldset>
                </td>
            </tr>
        </table>
    </div>
    <ajaxToolkit:CalendarExtender ID="CalendarExtender1" runat="server" TargetControlID="txtFechaInicio" Format="dd/MM/yyyy">
    </ajaxToolkit:CalendarExtender>
    <ajaxToolkit:CalendarExtender ID="CalendarExtender2" runat="server" TargetControlID="txtFechaFin" Format="dd/MM/yyyy">
    </ajaxToolkit:CalendarExtender>
    </ContentTemplate>
    </asp:UpdatePanel>
</asp:Content>
