<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="frmLogin.aspx.vb" Inherits="frmLogin" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>ACC El Bosque - Intranet</title>
    <link href="App_Themes/SGC/sgc.css" rel="Stylesheet" type="text/css" />
</head>
<body>
    <form id="form1" runat="server">
        <div class="contenedor">
        <div class="contenedor-cabecera">
            <div class="contenedor-logo">AEB</div>
        </div>
        <center>
            <div class="contenedor-login-externo">
            <div class="contenedor-login">
                <div style="width: 280px; height: 121px; text-align:left; margin-top:147px;">
                    <fieldset style="width:100%">
                        <legend>Login</legend>
                        <table cellpadding="0" cellspacing="4" border="0" style="padding:10px;">
                            <tr>
                                <td align="right" style="padding-left: 15px; padding-bottom:10px;">
                                    Usuario:
                                </td>
                                <td align="left">
                                    <asp:TextBox ID="tbxUsuario" runat="server" Width="173px" CssClass="estilo_textbox"></asp:TextBox>
                                </td>
                            </tr>
                            <tr>
                                <td align="right">
                                    Contraseña:
                                </td>
                                <td align="left">
                                    <asp:TextBox ID="tbxContrasenia" runat="server" TextMode="Password" Width="173px" CssClass="estilo_textbox"></asp:TextBox>
                                </td>
                            </tr>
                            <tr>
                                <td></td>
                                <td align="left" style="padding-top:5px;">
                                    <asp:LinkButton ID="lbtnIniciarSesion" runat="server" OnClick="lbtnIniciarSesion_Click" CssClass="estilo_boton" Text="Iniciar Sesión"></asp:LinkButton>
                                </td>
                            </tr> 
                        </table>
                    </fieldset>
                </div>
                <br />        
                <table cellpadding="0" cellspacing="0" border="0">
                    <tr>
                        <td>
                            <asp:Label ID="lblMensajeError" runat="server" ForeColor="Red"></asp:Label>
                        </td>
                    </tr>
                </table>
            </div>
            </div>
        </center>
        <div class="pie_pagina">
            Copyright © ACC El Bosque 
            <%=DateTime.Now.Year %>
        </div>
    </div>
    </form>
</body>
</html>
