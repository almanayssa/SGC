<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/PlantillaSGC.master" CodeBehind="frmMisSuscripciones.aspx.vb" Inherits=".frmMisSuscripciones" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <script src="js/jquery.alerts.js" type="text/javascript"></script>
    <script src="js/jquery.ui.draggable.js" type="text/javascript"></script>
    <script type="text/javascript" language="javascript">

        function popup() {

            jAlert('Registro exitoso', 'Alert Dialog');
        }
    
    </script>
    <table class="tablita">
        <tr>
            <td style="width: 866px">
                <div class="centrado">
                    <div class="DatosSocio3">
                        <br />
                        <asp:Label ID="Label10" runat="server" CssClass="lblnegro" Text="Para suscribirse a las comités siga los pasos que se muestran a continuación:"></asp:Label>
                        <br />
                        <br />
                        <asp:Panel ID="Panel2" runat="server" BackColor="White" ForeColor="#82AE1D" GroupingText="Mis Suscripciones" Width="799px">
                            <br />
                            <asp:Label ID="Label2" runat="server" CssClass="lblnegro" 
                                Text="Seleccione los comités a los que desea suscribirse."></asp:Label>
                            <br />
                            <br />
                            <asp:GridView ID="gvwSuscripciones" runat="server" AutoGenerateColumns="False" CssClass="mGrid"
                                EmptyDataText="No existen suscripciones" Height="30px" Width="780px">
                                <Columns>
                                    <asp:TemplateField HeaderText="Seleccionar Comité">
                                        <ItemStyle Width="70px" />
                                        <ItemTemplate>
                                            <asp:CheckBox ID="chkSeleccionar" runat="server" Checked='<%#Convert.ToBoolean(Eval("flg"))%>' />
                                        </ItemTemplate>
                                    </asp:TemplateField>
                                    <asp:BoundField DataField="id_comite" HeaderText="Comité ID">
                                        <FooterStyle ForeColor="White" />
                                    </asp:BoundField>
                                    <asp:BoundField DataField="comite" HeaderText="Comité Nombre"  />
                                </Columns>
                            </asp:GridView>
                            <br />
                            <asp:ImageButton ID="btnRegistrar" runat="server" ImageUrl="~/imagenes/botones/grabar.jpg" ImageAlign="Right" BackColor="White" />
                            <asp:Label ID="lblmsjerror0" runat="server" CssClass="lblrojo"></asp:Label>
                        </asp:Panel>
                        <br />
                    </div>
                </div>
            </td>
        </tr>
    </table>
</asp:Content>
