<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/PlantillaSGC.master" CodeBehind="frmRegistroInscripcion.aspx.vb" Inherits=".frmRegistroInscripcion" %>

<%@ Register Assembly="BusyBoxDotNet" Namespace="BusyBoxDotNet" TagPrefix="busyboxdotnet" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="cc1" %>

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
                        <asp:Label ID="Label10" runat="server" CssClass="lblnegro" Text="Para inscribirse a las actividades siga los pasos que se muestran a continuación:"></asp:Label>
                        <br />
                        <br />
                        <asp:Panel ID="Panel1" runat="server" BackColor="White" ForeColor="#82AE1D" GroupingText="Paso 1"
                            Width="799px">
                            <br />
                            <asp:Label ID="Label7" runat="server" CssClass="lblnegro" Text="Actividad seleccionada a la cual desea participar."></asp:Label>
                            <br />
                            <br />
                            <br />
                            <table border="0" cellpadding="0" cellspacing="0" style="width:100%;">
                                <tr>
                                    <td style="vertical-align:top">Actividad:</td>
                                    <td style="vertical-align:top"><asp:TextBox ID="txtActividad" runat="server" BorderStyle="None" Enabled="False"
                                Width="111px"></asp:TextBox></td>
                                    <td style="vertical-align:top">Datos:</td>
                                    <td style="vertical-align:top"><asp:TextBox ID="txtDatos" runat="server" BorderStyle="None" Enabled="False" TextMode="MultiLine" 
                                Width="247px"></asp:TextBox></td>
                                </tr>
                            </table>
                            <br />
                        </asp:Panel>
                        <br />
                        <asp:Panel ID="Panel2" runat="server" BackColor="White" ForeColor="#82AE1D" GroupingText="Paso 2" Width="799px">
                            <br />
                            <asp:Label ID="Label2" runat="server" CssClass="lblnegro" 
                                Text="Dé clic en Familiares para seleccionar a las personas que pueden participar."></asp:Label>
                            <br />
                            <br />
                            <asp:ImageButton ID="btnBuscarFamiliares" runat="server" ImageUrl="~/imagenes/botones/familiares.jpg" />
                            <br />
                            <%--<br />
                            DNI / C.E:
                            <asp:TextBox ID="TextBox1" runat="server" BorderStyle="None" Enabled="False" Width="111px"></asp:TextBox>
                            Nombre:
                            <asp:TextBox ID="TextBox2" runat="server" BorderStyle="None" Enabled="False" Width="109px"></asp:TextBox>--%>
                            <asp:GridView ID="gvwFamiliares" runat="server" AutoGenerateColumns="False" CssClass="mGrid"
                                EmptyDataText="No existen familiares" Height="30px" Width="780px">
                                <Columns>
                                    <asp:TemplateField HeaderText="Seleccionar Inscripcion">
                                        <ItemStyle Width="70px" />
                                        <ItemTemplate>
                                            <asp:CheckBox ID="chkSeleccionar" runat="server" />
                                        </ItemTemplate>
                                    </asp:TemplateField>
                                    <asp:BoundField DataField="id_persona" HeaderText="Familiar">
                                        <FooterStyle ForeColor="White" />
                                    </asp:BoundField>
                                    <asp:BoundField DataField="dni_per" HeaderText="DNI / C.E"  />
                                    <asp:BoundField DataField="nombre_completo" HeaderText="Nombre" />
                                    <asp:BoundField DataField="tipo_familiar" HeaderText="Relación" />
                                </Columns>
                            </asp:GridView>
                            <br />
                        </asp:Panel>
                        <br />
                    </div>
                    <div class="DatosSocio3">
                        <asp:Panel ID="Panel3" runat="server" BackColor="White" ForeColor="#82AE1D" GroupingText="Paso 3" Width="799px" Height="326px">
                            <br />
                            <asp:Label ID="Label9" runat="server" CssClass="lblnegro" 
                                Text="Seleccione Inscribir para inscribir a los familiares seleccionados"></asp:Label>
                            <br />
                            <asp:ImageButton ID="btnAgregarFamiliares" runat="server" ImageUrl="~/imagenes/botones/inscribir.jpg" />
                            <asp:Label ID="lblnofamiliares" runat="server" CssClass="lblrojo"></asp:Label>
                            <br />
                            <asp:Label ID="Label11" runat="server" CssClass="lblnegro" Text="Dé clic en Grabar cuando haya registrado todas las personas que participaran en la actividad, de lo contrario realice el Paso 1, 2 y 3 nuevamente."></asp:Label>
                            <br />
                            <asp:Label ID="lblmsjpta" runat="server" CssClass="lblnegro" Text="Luego de grabar, la(s) persona(s) estará(n) registrada(s) para participar en la actividad."
                                Visible="False"></asp:Label>
                            &nbsp;<br />
                            <br />
                            <br />
                            Mis familiares a participar<br />
                            <br />
                            <asp:GridView ID="gvwParticipantes" runat="server" AutoGenerateColumns="False" CssClass="mGrid"
                                EmptyDataText="Aún no ha agregado participantes." Height="30px" Width="780px">
                                <Columns>
                                    <asp:BoundField DataField="id_persona" HeaderText="Familiar">
                                        <FooterStyle ForeColor="White" />
                                    </asp:BoundField>
                                    <asp:BoundField DataField="nombre_completo" HeaderText="Nombre" />
                                    <asp:BoundField DataField="tipo_familiar" HeaderText="Relación" />
                                    <asp:TemplateField HeaderText="Quitar">
                                        <ItemTemplate>
                                            <asp:LinkButton ID="lbtnQuitar" runat="server" Text="Quitar" CommandName="Quitar" CommandArgument='<%# Eval("id_persona") %>'></asp:LinkButton>
                                        </ItemTemplate>
                                    </asp:TemplateField>
                                </Columns>
                            </asp:GridView>
                            <br />
                            <asp:ImageButton ID="btnRegistrar" runat="server" ImageUrl="~/imagenes/botones/grabar.jpg" Visible="False" ImageAlign="Right" BackColor="White" />
                            <asp:Label ID="lblmsjerror0" runat="server" CssClass="lblrojo"></asp:Label>
                        </asp:Panel>
                        <br />
                        <asp:Label ID="lblobs2" runat="server" Visible="False"></asp:Label>
                        <asp:Label ID="lblprov2" runat="server" Visible="False"></asp:Label>
                        <asp:Label ID="lblobs" runat="server" Text="Label" Visible="False"></asp:Label>
                        <asp:Label ID="lblprov" runat="server" Text="Label" Visible="False"></asp:Label>
                        <br />
                        <br />
                    </div>
                </div>
            </td>
        </tr>
    </table>
</asp:Content>
