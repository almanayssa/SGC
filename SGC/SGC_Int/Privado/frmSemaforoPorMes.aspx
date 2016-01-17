<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Privado/PlantillaSGCInt.Master" CodeBehind="frmSemaforoPorMes.aspx.vb" Inherits="frmSemaforoPorMes" %>

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
            SEMÁFORO DE ACTIVIDADES POR MES
        </div>
        <br />
        <table id="tblComite" runat="server" border="0" cellpadding="0" cellspacing="0" width="918px">
            <tr>
                <td valign="top" style="width:700px;">
                    <asp:Label ID="lblMensaje" runat="server" Text="Para mostrar el semáforo, elegir los filtros deseados y hacer click en Generar."></asp:Label>
                    <asp:Label ID="lblTitulo" runat="server" Text=""></asp:Label>
                    <asp:GridView ID="gvwSemaforo" runat="server" AutoGenerateColumns="false" AllowPaging="false"
                        CssClass="tabla-grilla" Width="700px" BorderWidth="0px" BorderColor="White">
                        <HeaderStyle CssClass="tabla-grilla-cabecera" />
                        <RowStyle CssClass="tabla-grilla-filas" />
                        <Columns>                            
                            <asp:TemplateField HeaderText="Mes">
                                <ItemTemplate>
                                    <asp:Label ID="lblFecha" runat="server" Text='<%#Eval("fecha") %>'></asp:Label>
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField HeaderText="Participantes">
                                <ItemTemplate>
                                    <asp:Label ID="lblParticipantes1" runat="server" Text='<%#Eval("participantes1") %>'></asp:Label>
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField HeaderText="Participantes">
                                <ItemTemplate>
                                    <asp:Label ID="lblParticipantes2" runat="server" Text='<%#Eval("participantes2") %>'></asp:Label>
                                </ItemTemplate>
                            </asp:TemplateField>
                        </Columns>
                    </asp:GridView>
                    <div id="divLeyenda" runat="server" visible="false">
                        <fieldset>
                            <legend>Análisis</legend>
                            <asp:Label ID="lblResultado" runat="server"></asp:Label>
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
                                <td>Tipos de Actividad:</td>
                            </tr>
                            <tr>
                                <td><asp:CheckBoxList ID="cblTipos" CssClass="estilo_textbox" runat="server" AutoPostBack="true"></asp:CheckBoxList></td>
                            </tr>
                        </table>
                        <br />
                        <table border="0" cellpadding="0" cellspacing="0">
                            <tr>
                                <td>Mes y Año:</td>
                            </tr>
                            <tr>
                                <td>
                                    <asp:DropDownList ID="ddlMes" runat="server"></asp:DropDownList>
                                    <asp:DropDownList ID="ddlAnio" runat="server"></asp:DropDownList>                                    
                                </td>
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
    </ContentTemplate>
    </asp:UpdatePanel>
</asp:Content>
