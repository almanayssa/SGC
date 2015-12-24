<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/PlantillaSGC.master" CodeBehind="frmCambiarContrasena.aspx.vb" Inherits=".frmCambiarContrasena" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<table class="tablita">
    <tr>
        <td style="width: 866px">
            <div class="centrado">
                <div class="DatosSocio3">
                    <br />
                    <asp:Label ID="Label10" runat="server" CssClass="lblnegro" Text="Para cambiar su contraseña llene los datos que se muestran a continuación:"></asp:Label>
                    <br />
                    <br />
                    <asp:UpdatePanel ID="upnlContrasena" runat="server" UpdateMode="Conditional">
                        <ContentTemplate>
                            <asp:Panel ID="Panel1" runat="server" BackColor="White" ForeColor="#82AE1D" GroupingText="Cambiar Contraseña" Width="799px">
                                <br />
                                <table border="0" cellpadding="0" cellspacing="0" style="width:100%;">
                                    <tr>
                                        <td class="lblnegro">Ingrese contraseña actual:</td>
                                        <td><asp:TextBox ID="txtContrasenaActual" runat="server" TextMode="Password"></asp:TextBox></td>       
                                        <td><asp:RequiredFieldValidator ID="rfvContrasenaActual" runat="server" Display="None" ErrorMessage="Ingrese contraseña actual" ControlToValidate="txtContrasenaActual" ValidationGroup="Contrasena" ForeColor="Red"></asp:RequiredFieldValidator></td>                        
                                    </tr>
                                    <tr>
                                        <td class="lblnegro">Ingrese nueva contraseña</td>
                                        <td><asp:TextBox ID="txtNuevaContrasena" runat="server" TextMode="Password"></asp:TextBox></td>
                                        <td><asp:RequiredFieldValidator ID="rfvNuevaContrasena" runat="server" Display="None" ErrorMessage="Ingrese una nueva contraseña" ControlToValidate="txtNuevaContrasena" ValidationGroup="Contrasena" ForeColor="Red"></asp:RequiredFieldValidator></td>
                                    </tr>
                                    <tr>
                                        <td class="lblnegro">Confirme nueva contraseña</td>
                                            <td><asp:TextBox ID="txtNuevaContrasena2" runat="server" TextMode="Password"></asp:TextBox></td>
                                            <td><asp:RequiredFieldValidator ID="rfvNuevaContrasena2" runat="server" Display="None" ErrorMessage="Confirme nueva contraseña" ControlToValidate="txtNuevaContrasena2" ValidationGroup="Contrasena" ForeColor="Red"></asp:RequiredFieldValidator></td>
                                    </tr>
                                    <tr>
                                        <td></td>
                                        <td><asp:ImageButton ID="ibtnModificar" runat="server" AlternateText="Modificar" ImageUrl="~/imagenes/botones/boton_modificar.gif" ValidationGroup="Contrasena"/></td>
                                        <td></td>
                                    </tr> 
                                    <tr>
                                        <td colspan="3">
                                            <asp:Label ID="lblMensaje" runat="server" Visible="false"></asp:Label>
                                            <asp:CustomValidator ID="cvContrasenaActual" runat="server" ValidationGroup="Contrasena" ErrorMessage="La contraseña actual no es correcta" OnServerValidate="ValidarContrasenaActual" Display="None" ForeColor="Red"></asp:CustomValidator>
                                            <asp:CustomValidator ID="cvNuevaContrasena" runat="server" ValidationGroup="Contrasena" ErrorMessage="Contraseñas no coinciden" OnServerValidate="ValidarNuevaContrasena" Display="None" ForeColor="Red"></asp:CustomValidator>
                                            <asp:ValidationSummary ID="vsumContrasena" runat="server" ValidationGroup="Contrasena" DisplayMode="BulletList" ShowMessageBox="false" ShowSummary="true" ForeColor="Red" />
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
</asp:Content>
