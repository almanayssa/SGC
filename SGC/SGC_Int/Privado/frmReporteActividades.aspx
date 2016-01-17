<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Privado/PlantillaSGCInt.Master" CodeBehind="frmReporteActividades.aspx.vb" Inherits="frmReporteActividades" %>

<%@ Register Assembly="Microsoft.ReportViewer.WebForms, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a"
    Namespace="Microsoft.Reporting.WebForms" TagPrefix="rsweb" %>

<%@ Register Assembly="System.Web.DataVisualization, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35"
    Namespace="System.Web.UI.DataVisualization.Charting" TagPrefix="asp" %>

<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit" tagprefix="ajaxToolkit" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <ajaxToolkit:ToolkitScriptManager ID="ToolkitScriptManager1" runat="server">
    </ajaxToolkit:ToolkitScriptManager>
    <asp:UpdatePanel ID="upnlActividad" runat="server">
    <ContentTemplate>
    <div class="contenedor-pagina">
        <div class="contenedor-pagina-titulo">
            REPORTE DE DEMANDA POR TIPOS DE ACTIVIDAD
        </div>
        <br />
        <table border="0" cellpadding="0" cellspacing="0">
            <tr>
                <td class="textbox-espaciado">
                    Fecha:
                </td>
                <td class="textbox-espaciado">
                    <asp:TextBox ID="txtFechaInicio" runat="server" CssClass="estilo_textbox" Width="75px" ReadOnly="true"></asp:TextBox>
                    
                </td>                
                <td class="textbox-espaciado">
                    a
                </td>
                <td class="textbox-espaciado">
                    <asp:TextBox ID="txtFechaFin" runat="server" CssClass="estilo_textbox" Width="75px" ReadOnly="true"></asp:TextBox>
                    
                </td>
                <td class="textbox-espaciado">
                    <asp:LinkButton ID="lbtnBuscar" runat="server" OnClick="lbtnBuscar_Click" CssClass="estilo_boton" Text="Buscar"></asp:LinkButton>
                </td>
            </tr>
        </table>
        <div id="divMensaje" runat="server">
            <br />
            <table border="0" cellpadding="0" cellspacing="0">
                <tr>
                    <td>
                        <asp:Label ID="lblMensaje" runat="server"></asp:Label>
                    </td>
                </tr>
            </table>
        </div>
        <br />
        <table id="tblActividad" runat="server" border="0" cellpadding="0" cellspacing="0">
            <tr>
                <td>                    
                    <rsweb:ReportViewer ID="rvwActividad" runat="server" ProcessingMode="Remote" 
                        Width="918px">
                    </rsweb:ReportViewer>
                </td>
            </tr>
        </table>
        <br />
    </div>
    <ajaxToolkit:CalendarExtender ID="CalendarExtender1" runat="server" TargetControlID="txtFechaInicio" Format="dd/MM/yyyy">
    </ajaxToolkit:CalendarExtender>
    <ajaxToolkit:CalendarExtender ID="CalendarExtender2" runat="server" TargetControlID="txtFechaFin" Format="dd/MM/yyyy">
    </ajaxToolkit:CalendarExtender>
    </ContentTemplate>
    </asp:UpdatePanel>
</asp:Content>
