<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/PlantillaSGC.master" CodeBehind="frmCambiarContrasena.aspx.vb" Inherits=".frmCambiarContrasena" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<table class="tablitaDatosSocio">
        <tr>
            <td>
                <div class="DatosSocio" 
                    style="height: 370px; width: 380px; text-align: justify; margin-top:10px;">
                    <br />
                    <br />
                    <br />
                    <br />
                    <table border="0" cellpadding="2" cellspacing="2">
                        <tr><td colspan="2" style="text-align:center;"><h3>Cambio de Contraseña</h3></td></tr>
                        <tr>
                            <td class="lblnegro">Ingrese contraseña actual</td>
                            <td><asp:TextBox ID="txtContrasenaActual" runat="server" TextMode="Password"></asp:TextBox></td>
                        </tr>
                        <tr>
                            <td class="lblnegro">Ingrese nueva contraseña</td>
                            <td><asp:TextBox ID="txtNuevaContrasena" runat="server" TextMode="Password"></asp:TextBox></td>
                        </tr>
                        <tr>
                            <td class="lblnegro">Confirme nueva contraseña</td>
                            <td><asp:TextBox ID="txtNuevaContrasena2" runat="server" TextMode="Password"></asp:TextBox></td>
                        </tr>
                        <tr>
                            <td colspan="2" align="right"><asp:ImageButton ID="ibtnModificar" runat="server" AlternateText="Modificar" ImageUrl="~/imagenes/botones/boton_modificar.gif"/></td>
                        </tr>
                    </table>                 
                </div>
            </td>
        </tr>
    </table>
</asp:Content>
