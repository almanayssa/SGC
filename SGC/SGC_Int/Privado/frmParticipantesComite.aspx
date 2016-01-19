<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Privado/PlantillaSGCInt.Master" CodeBehind="frmParticipantesComite.aspx.vb" Inherits=".frmParticipantesComite" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <div class="contenedor-pagina">
        <div class="contenedor-pagina-titulo">
            CANTIDAD DE PARTICIPANTES POR COMITÉ
        </div>
        <br />
        <table border="0" cellpadding="0" cellspacing="0" >
            <tr>
                <td>
                    <asp:Literal ID="ltrParticipantes" runat="server"></asp:Literal>
                </td>
            </tr>
        </table>
    </div>
</asp:Content>
