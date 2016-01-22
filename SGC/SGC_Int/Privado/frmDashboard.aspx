<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Privado/PlantillaSGCInt.Master" CodeBehind="frmDashboard.aspx.vb" Inherits="frmDashboard" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">        
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
        <div class="contenedor-pagina">
        <div class="contenedor-pagina-titulo">
            DASHBOARD PRINCIPAL
        </div>
        <br />
        <table border="0" cellpadding="0" cellspacing="0">
        <tr>
            <td>
                <table border="0" cellpadding="0" cellspacing="0" style="width:920px; height:auto;">
                    <tr>
                        <td>
                            <table border="0" cellpadding="0" cellspacing="0">
                                <tr>
                                    <td>
                                        <table border="0" cellpadding="0" cellspacing="0" style="width:450px; height:152px; border: 1px solid #DADADA;">
                                            <tr>
                                                <td class="dashboardTableTitle"><a href="frmParticipantesComite.aspx" class="linkD">CANTIDAD DE PARTICIPANTES POR COMITÉ</a></td>
                                            </tr>
                                            <tr>
                                                <td><asp:Literal ID="ltrParticipantesComite" runat="server"></asp:Literal></td>
                                            </tr>
                                        </table>
                                    </td>
                                    <td style="padding-left:20px;">
                                        <table border="0" cellpadding="0" cellspacing="0" style="width:450px; height:152px; border: 1px solid #DADADA;">
                                            <tr>
                                                <td class="dashboardTableTitle">CANTIDAD DE PARTICIPANTES POR TIPO<br />(Con respecto a toda la historia)</td>
                                            </tr>
                                            <tr>
                                                <td><asp:Literal ID="ltrParticipantesTipo" runat="server"></asp:Literal></td>
                                            </tr>
                                        </table>
                                    </td>                                    
                                </tr>
                            </table>
                            <br />
                            <table border="0" cellpadding="0" cellspacing="0">
                                <tr>
                                    <td>
                                        <table border="0" cellpadding="0" cellspacing="0" style="width:300px; height:150px; border: 1px solid #DADADA;">
                                            <tr>
                                                <td class="dashboardTableTitle">
                                                    <table border="0" cellpadding="0" cellspacing="0" style="width:100%;">
                                                        <tr>
                                                            <td><a href="frmActividadesComite.aspx" class="linkD">CANTIDAD DE ACTIVIDADES POR COMITÉ<br />(Con respecto a toda la historia)</a></td>
                                                        </tr>
                                                    </table>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td>
                                                    <asp:Literal ID="ltrActividadesPorComite" runat="server"></asp:Literal>
                                                </td>
                                            </tr>
                                        </table>
                                    </td>
                                    <td style="padding-left:10px;">
                                        <table border="0" cellpadding="0" cellspacing="0" style="width:300px; height:150px; border: 1px solid #DADADA;">
                                            <tr>
                                                <td class="dashboardTableTitle">
                                                    <table border="0" cellpadding="0" cellspacing="0" style="width:100%;">
                                                        <tr>
                                                            <td><a href="frmSatisfaccionPorComite.aspx" class="linkD">NIVEL DE SATISFACCIÓN<br />(Con respecto a toda la historia)</a></td>
                                                        </tr>
                                                    </table>                                                    
                                                </td>
                                            </tr>
                                            <tr>
                                                <td>                                                    
                                                    <asp:Literal ID="ltrComiteSatisfaccion" runat="server"></asp:Literal>
                                                </td>
                                            </tr>
                                        </table>                                        
                                    </td>
                                    <td style="padding-left:10px;">
                                        <table border="0" cellpadding="0" cellspacing="0" style="width:300px; height:150px; border: 1px solid #DADADA;">
                                            <tr>
                                                <td class="dashboardTableTitle">
                                                    <table border="0" cellpadding="0" cellspacing="0" style="width:100%;">
                                                        <tr>
                                                            <td>CANTIDAD DE ACTIVIDADES POR TIPO<br />(Con respecto a toda la historia)</td>
                                                        </tr>
                                                    </table>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td>
                                                    <asp:Literal ID="ltrActividadesPorTipo" runat="server"></asp:Literal>
                                                </td>
                                            </tr>
                                        </table>
                                    </td>
                                </tr>
                            </table>
                            <br />
                            <table border="0" cellpadding="0" cellspacing="0">
                                <tr>
                                    <td>
                                        <table border="0" cellpadding="0" cellspacing="0" style="width:400px; height:152px; border: 1px solid #DADADA;">
                                            <tr>
                                                <td class="dashboardTableTitle"><a href="frmPersonalParticipante.aspx" class="linkD">PERSONAL MÁS SOLICITADO<br />(Con respecto a toda la historia)</a></td>
                                            </tr>
                                            <tr>
                                                <td><asp:Literal ID="ltrPersonal" runat="server"></asp:Literal></td>
                                            </tr>
                                        </table>
                                    </td>
                                    <td style="padding-left:20px;">
                                        <table border="0" cellpadding="0" cellspacing="0" style="width:500px; height:152px; border: 1px solid #DADADA;">
                                            <tr>
                                                <td class="dashboardTableTitle"><a href="frmPersonalParticipante.aspx" class="linkD">PERSONAS MÁS PARTICIPATIVAS<br />(Con respecto a toda la historia)</a></td>
                                            </tr>
                                            <tr>
                                                <td><asp:Literal ID="ltrParticipantes" runat="server"></asp:Literal></td>
                                            </tr>
                                        </table>
                                    </td>                                    
                                </tr>
                            </table>
                        </td>
                    </tr>
                </table>
            </td>
        </tr>
        </table>
        <br />
        <table border="0" cellpadding="0" cellspacing="0" style="width:920px; height:232px; border: 1px solid #DADADA;">
            <tr>
                <td class="dashboardTableTitle">CANTIDAD DE PARTICIPANTES POR MES RESPECTO AL ÚLTIMO AÑO FIJO (2015)</td>
            </tr>
            <tr>
                <td><asp:Literal ID="ltrUltimoAnio" runat="server"></asp:Literal></td>
            </tr>
        </table>
        <br />     
        <table border="0" cellpadding="0" cellspacing="0" style="width:920px; height:232px; border: 1px solid #DADADA;">
            <tr>
                <td class="dashboardTableTitle">TASA DE CRECIMIENTO ANUAL<br />(Con respecto a toda la historia)</td>
            </tr>
            <tr>
                <td><asp:Literal ID="ltrTasaCrecimiento" runat="server"></asp:Literal></td>
            </tr>
        </table>        
        <br />
    </div>
</asp:Content>
