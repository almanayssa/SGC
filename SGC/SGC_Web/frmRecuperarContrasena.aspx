<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="frmRecuperarContrasena.aspx.vb" Inherits=".frmRecuperarContrasena" %>

<%@ Register Src="controles/usrEncabezado.ascx" TagName="usrEncabezado" TagPrefix="uc1" %>

<%@ Register Src="controles/usrPie.ascx" TagName="usrPie" TagPrefix="uc2" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title>Bienvenidos al Bosque Virtual</title>
    <link href="estilos/comunes.css" rel="stylesheet" type="text/css" />
    <link href="estilos/styles.css" rel="stylesheet" type="text/css" />
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <style type="text/css">
    body,td,th {
	    font-family: Tahoma, Arial, "Microsoft Sans Serif";
    }
    body {
	    background-color: #ECEBE7;
    }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:ScriptManager ID="ScriptManager1" runat="server">
            </asp:ScriptManager>
            <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                <ContentTemplate> 
                    <uc1:usrEncabezado ID="usrEncabezado2" runat="server" />                    <table class="tablita">
                        <tr>
                            <td style="width: 866px">
                                <div class="centrado">
                                    <div class="DatosSocio3">
                                        <br />
                                        <asp:Label ID="Label10" runat="server" CssClass="lblnegro" Text="Si ha olvidado su contraseña, ingrese su correo electrónico y la contraseña será enviada a la dirección proporcionada siempre y cuando dicha dirección se encuentre registrada en el sistema."></asp:Label>
                                        <br />
                                        <br />
                                        <asp:UpdatePanel ID="upnlCorreo" runat="server" UpdateMode="Conditional">
                                            <ContentTemplate>
                                                <asp:Panel ID="Panel1" runat="server" BackColor="White" ForeColor="#82AE1D" GroupingText="Recuperar Contraseña" Width="799px">
                                                    <br />
                                                    <table border="0" cellpadding="0" cellspacing="2" style="width:100%;">
                                                        <tr>
                                                            <td class="lblnegro">Correo:</td>
                                                            <td><asp:TextBox ID="txtCorreo" runat="server"></asp:TextBox></td>       
                                                            <td><asp:RequiredFieldValidator ID="rfvCorreo" runat="server" Display="None" ErrorMessage="Ingrese correo" ControlToValidate="txtCorreo" ValidationGroup="Correo" ForeColor="Red"></asp:RequiredFieldValidator></td>                        
                                                        </tr>                                    
                                                        <tr>
                                                            <td></td>
                                                            <td><asp:ImageButton ID="ibtnEnviar" runat="server" AlternateText="Modificar" ImageUrl="~/imagenes/botones/enviar.jpg" ValidationGroup="Correo"/></td>
                                                            <td></td>
                                                        </tr> 
                                                        <tr>
                                                            <td colspan="3">
                                                                <asp:Label ID="lblMensaje" runat="server" Visible="false"></asp:Label>
                                                                <asp:RegularExpressionValidator ID="revCorreo" runat="server" ControlToValidate="txtCorreo" ValidationExpression="^[\w._%-]+@[\w.-]+\.[a-zA-Z]{2,4}$" Display="None" ErrorMessage="Verique formato de correo" ValidationGroup="Correo"></asp:RegularExpressionValidator>
                                                                <asp:ValidationSummary ID="vsumCorreo" runat="server" ValidationGroup="Correo" DisplayMode="BulletList" ShowMessageBox="false" ShowSummary="true" ForeColor="Red" />
                                                            </td>
                                                        </tr>
                                                    </table>
                                                    <br />
                                                </asp:Panel>
                                                <br />
                                            </ContentTemplate>
                                        </asp:UpdatePanel>
                                    </div>
                                </div>
                            </td>
                        </tr>
                    </table>   
                    <uc2:usrPie ID="UsrPie1" runat="server" />
                </ContentTemplate>
            </asp:UpdatePanel>
        </div>
    </form>
</body>
</html>
