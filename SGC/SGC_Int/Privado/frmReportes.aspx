<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Privado/PlantillaSGCInt.Master" CodeBehind="frmReportes.aspx.vb" Inherits="SGC_Int.frmReportes" %>

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
        <table border="0" cellpadding="0" cellspacing="0">
            <tr>
                <td>
                    test
                </td>
                <td>
                    <table border="0" cellpadding="0" cellspacing="0">
                        <tr>
                            <td><asp:DropDownList ID="ddlComite" runat="server"></asp:DropDownList></td>       
                        </tr>
                        <tr>
                            <td><asp:DropDownList ID="ddlTipo" runat="server"></asp:DropDownList></td>       
                        </tr>
                        <tr>
                            <td><asp:CheckBox ID="chkActividades" runat="server" Text="Todas" /></td>    
                        </tr>
                        <tr>
                            <td><asp:CheckBoxList ID="cblActividades" runat="server"></asp:CheckBoxList></td>
                        </tr>
                        <tr>
                            <td><asp:TextBox ID="txtFechaInicio" runat="server"></asp:TextBox></td>
                        </tr>
                        <tr>
                            <td><asp:TextBox ID="txtFechaFin" runat="server"></asp:TextBox></td>
                        </tr>
                        <tr>
                            <td><asp:CheckBox ID="chkVariables" runat="server" Text="Todas" /></td>
                        </tr>
                        <tr>
                            <td><asp:CheckBoxList ID="cblVariables" runat="server"></asp:CheckBoxList></td>
                        </tr>
                    </table>
                </td>
            </tr>
        </table>
        <ajaxToolkit:CalendarExtender ID="CalendarExtender1" runat="server" TargetControlID="txtFechaInicio" Format="dd/MM/yyyy">
        </ajaxToolkit:CalendarExtender>
        <ajaxToolkit:CalendarExtender ID="CalendarExtender2" runat="server" TargetControlID="txtFechaFin" Format="dd/MM/yyyy">
        </ajaxToolkit:CalendarExtender>
    </ContentTemplate>
    </asp:UpdatePanel>
</asp:Content>
