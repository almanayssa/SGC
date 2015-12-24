<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/PlantillaSGC.master" CodeBehind="frmMisInscripciones.aspx.vb" Inherits=".frmMisInscripciones" %>

<%@ Register Assembly="BusyBoxDotNet" Namespace="BusyBoxDotNet" TagPrefix="busyboxdotnet" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="cc1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table class="tablita">
        <tr>
            <td style="width: 866px">
                <div class="centrado">
                    <div class="DatosSocio3">
                        <br />
                        <asp:Label ID="Label10" runat="server" CssClass="lblnegro" Text="Estimado socio, usted se encuentra inscrito a las siguientes actividades:"></asp:Label>
                        <br />
                        <br />
                        <asp:Panel ID="Panel1" runat="server" BackColor="White" ForeColor="#82AE1D" GroupingText="Mis Inscripciones" Width="799px">
                            <br />
                            <asp:GridView ID="gvwInscripciones" runat="server" AutoGenerateColumns="False" CssClass="mGrid"
                                EmptyDataText="No existen inscripciones" Height="30px" Width="780px">
                                <Columns>
                                    <asp:BoundField DataField="nombre_actividad" HeaderText="Actividad">
                                        <FooterStyle ForeColor="White" />
                                    </asp:BoundField>
                                    <asp:BoundField DataField="nombre_comite" HeaderText="Comité"  />
                                    <asp:BoundField DataField="tipo_actividad" HeaderText="Tipo" />
                                    <asp:BoundField DataField="fecha_registro" HeaderText="Fecha Registro" />
                                    <asp:BoundField DataField="monto" HeaderText="Monto" />
                                </Columns>
                            </asp:GridView>
                            <br />
                        </asp:Panel>
                        <br />
                    </div>
                </div>
            </td>
        </tr>
    </table>
</asp:Content>
