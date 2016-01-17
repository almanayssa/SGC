<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Privado/PlantillaSGCInt.Master" CodeBehind="frmPersonalParticipante.aspx.vb" Inherits=".frmPersonalParticipante" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <div class="contenedor-pagina">
        <div class="contenedor-pagina-titulo">
            PERSONAL MÁS SOLICITADO / PERSONAS MÁS PARTICIPATIVAS
        </div>
        <br />
        <table style="width: 100%; height: 450px" cellpadding="0" cellspacing="0" >
            <tr>
                <td>
                    <div style="position: relative; width: 450px; height: 450px; overflow: auto;"">
                        <asp:Literal ID="ltrPersonal" runat="server"></asp:Literal>
                    </div>
                </td>
                <td style="padding-left:20px">
                    <div style="position: relative; width: 450px; height: 450px; overflow: auto; top: 0px; left: 0px;">
                        <asp:Literal ID="ltrParticipante" runat="server"></asp:Literal>
                    </div>
                </td>
            </tr>
        </table>
    </div>
</asp:Content>
