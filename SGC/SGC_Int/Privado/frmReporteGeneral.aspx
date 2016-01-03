<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Privado/PlantillaSGCInt.Master" CodeBehind="frmReporteGeneral.aspx.vb" Inherits="SGC_Int.frmReporteGeneral" %>

<%@ Register Assembly="Microsoft.ReportViewer.WebForms, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a"
    Namespace="Microsoft.Reporting.WebForms" TagPrefix="rsweb" %>

<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit" tagprefix="ajaxToolkit" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <ajaxToolkit:ToolkitScriptManager ID="ToolkitScriptManager1" runat="server">
    </ajaxToolkit:ToolkitScriptManager>
    <asp:UpdatePanel ID="upnlReporte" runat="server" UpdateMode="Conditional">
    <ContentTemplate>
    <div class="contenedor-pagina">
        <div class="contenedor-pagina-titulo">
            REPORTE GENERAL
        </div>
        <br />        
        <table id="tblComite" runat="server" border="0" cellpadding="0" cellspacing="0" width="918px">
            <tr>
                <td valign="top" style="width:700px;">
                    <rsweb:ReportViewer ID="rvwComite" runat="server" ProcessingMode="Remote" 
                        Width="700px">
                    </rsweb:ReportViewer>
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
                        <table border="0" cellpadding="0" cellspacing="0">
                            <tr>
                                <td>Tipo:</td>
                            </tr>
                            <tr>
                                <td><asp:DropDownList ID="ddlTipo" runat="server" CssClass="estilo_textbox" AutoPostBack="true"></asp:DropDownList></td>       
                            </tr>
                        </table>
                        <br />
                        <table border="0" cellpadding="0" cellspacing="0">
                            <tr>
                                <td>Actividades:</td>
                            </tr>
                            <tr>
                                <td><asp:CheckBox ID="chkActividades" runat="server" CssClass="estilo_textbox" Text="Todas" AutoPostBack="true" /></td>    
                            </tr>
                            <tr>
                                <td><asp:CheckBoxList ID="cblActividades" CssClass="estilo_textbox" runat="server"></asp:CheckBoxList></td>
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
                        <table border="0" cellpadding="0" cellspacing="0">
                            <tr>
                                <td>Variables:</td>
                            </tr>
                            <tr>
                                <td><asp:CheckBox ID="chkVariables" runat="server" Text="Todas" AutoPostBack="true" /></td>
                            </tr>                        
                            <tr>
                                <td><asp:CheckBoxList ID="cblVariables" runat="server"></asp:CheckBoxList></td>
                            </tr>                        
                        </table>
                    </fieldset>
                </td>
            </tr>
        </table>        
        <br />
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
    </div>
    <ajaxToolkit:CalendarExtender ID="CalendarExtender1" runat="server" TargetControlID="txtFechaInicio" Format="dd/MM/yyyy">
    </ajaxToolkit:CalendarExtender>
    <ajaxToolkit:CalendarExtender ID="CalendarExtender2" runat="server" TargetControlID="txtFechaFin" Format="dd/MM/yyyy">
    </ajaxToolkit:CalendarExtender>
    </ContentTemplate>
    </asp:UpdatePanel>
</asp:Content>
