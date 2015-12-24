<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/PlantillaSGC.master" CodeBehind="Mensaje.aspx.vb" Inherits=".Mensaje" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table class="tablita">
        <tr>
            <td style="width: 500px">
                <div class="centrado">
                    <div class="DatosSocio3">
                        <br />
                        <asp:Label ID="lblMessagePage" runat="server" CssClass="lblverde" Font-Size="Small"></asp:Label>
                        <br />
                        <br />                        
                        <br />
                        <asp:Label ID="lblMessageDescription" runat="server" CssClass="lblnegro"></asp:Label>
                        <br />
                        <br />
                        <br />
                        <asp:ImageButton ID="ibtContinue" runat="server" ImageUrl="~/imagenes/botones/continuar.jpg" />
                        <br />
                    </div>
                </div>
            </td>
        </tr>
    </table>
</asp:Content>
