<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Privado/PlantillaSGCInt.Master" CodeBehind="frmDashboard.aspx.vb" Inherits="frmDashboard" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">        
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
        <div style="background-color: White; height: auto; color:#000000;">
        <br />
        <table border="0" cellpadding="0" cellspacing="0">
        <tr>
            <td>
                <table border="0" cellpadding="0" cellspacing="0" style="width:940px; height:auto;">
                    <tr>
                        <td>
                            <table border="0" cellpadding="0" cellspacing="0">
                                <tr>
                                    <td>
                                        <table border="0" cellpadding="0" cellspacing="0" style="width:460px; height:152px; border: 1px solid #DADADA;">
                                            <tr>
                                                <td class="dashboardTableTitle">CANTIDAD DE PARTICIPANTES POR COMITÉ</td>
                                            </tr>
                                            <tr>
                                                <td><asp:Literal ID="ltrParticipantesComite" runat="server"></asp:Literal></td>
                                            </tr>
                                        </table>
                                    </td>
                                    <td style="padding-left:20px;">
                                        <table border="0" cellpadding="0" cellspacing="0" style="width:460px; height:152px; border: 1px solid #DADADA;">
                                            <tr>
                                                <td class="dashboardTableTitle">CANTIDAD DE PARTICIPANTES POR TIPO</td>
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
                                                            <td>CANTIDAD DE ACTIVIDADES POR COMITÉ</td>
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
                                    <td style="padding-left:20px;">
                                        <table border="0" cellpadding="0" cellspacing="0" style="width:300px; height:150px; border: 1px solid #DADADA;">
                                            <tr>
                                                <td class="dashboardTableTitle">
                                                    <table border="0" cellpadding="0" cellspacing="0" style="width:100%;">
                                                        <tr>
                                                            <td>NIVEL DE SATISFACCIÓN</td>
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
                                    <td style="padding-left:20px;">
                                        <table border="0" cellpadding="0" cellspacing="0" style="width:300px; height:150px; border: 1px solid #DADADA;">
                                            <tr>
                                                <td class="dashboardTableTitle">
                                                    <table border="0" cellpadding="0" cellspacing="0" style="width:100%;">
                                                        <tr>
                                                            <td>CANTIDAD DE ACTIVIDADES POR TIPO</td>
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
                                        <table border="0" cellpadding="0" cellspacing="0" style="width:460px; height:152px; border: 1px solid #DADADA;">
                                            <tr>
                                                <td class="dashboardTableTitle">PERSONAL MÁS SOLICITADO</td>
                                            </tr>
                                            <tr>
                                                <td><asp:Literal ID="ltrPersonal" runat="server"></asp:Literal></td>
                                            </tr>
                                        </table>
                                    </td>
                                    <td style="padding-left:20px;">
                                        <table border="0" cellpadding="0" cellspacing="0" style="width:460px; height:152px; border: 1px solid #DADADA;">
                                            <tr>
                                                <td class="dashboardTableTitle">PERSONAS MÁS PARTICIPATIVAS</td>
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
        <table border="0" cellpadding="0" cellspacing="0" style="width:940px; height:232px; border: 1px solid #DADADA;">
            <tr>
                <td class="dashboardTableTitle">TASA DE CRECIMIENTO</td>
            </tr>
            <tr>
                <td><asp:Literal ID="ltrTasaCrecimiento" runat="server"></asp:Literal></td>
            </tr>
        </table>
        <br />
        <table border="0" cellpadding="0" cellspacing="0" style="width:940px; height:232px; border: 1px solid #DADADA;">
            <tr>
                <td class="dashboardTableTitle">CANTIDAD DE PARTICIPANTES RESPECTO AL ÚLTIMO AÑO (2015)</td>
            </tr>
            <tr>
                <td><asp:Literal ID="ltrUltimoAnio" runat="server"></asp:Literal></td>
            </tr>
        </table>
        <br />
    </div>
</asp:Content>
