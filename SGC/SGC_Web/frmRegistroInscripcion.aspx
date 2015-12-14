﻿<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/PlantillaSGC.master" CodeBehind="frmRegistroInscripcion.aspx.vb" Inherits=".frmRegistroInscripcion" %>

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
                        <asp:Label ID="Label10" runat="server" CssClass="lblnegro" Text="Para inscribirse a las actividades siga los pasos que se muestran a continuación:"></asp:Label>
                        <br />
                        <br />
                        <asp:Panel ID="Panel3" runat="server" BackColor="White" ForeColor="#82AE1D" GroupingText="Paso 1"
                            Width="799px">
                            <br />
                            <asp:Label ID="Label7" runat="server" CssClass="lblnegro" Text="Actividad seleccionada a la cual desea participar."></asp:Label>
                            <br />
                            <br />
                            <br />
                            Actividad:
                            <asp:TextBox ID="txtActividad" runat="server" BorderStyle="None" Enabled="False"
                                Width="111px"></asp:TextBox>
                            Datos:
                            <asp:TextBox ID="txtDatos" runat="server" BorderStyle="None" Enabled="False" 
                                Width="247px"></asp:TextBox>
                            <br />
                        </asp:Panel>
                        <br />
                        <asp:Panel ID="Panel2" runat="server" BackColor="White" ForeColor="#82AE1D" GroupingText="Paso 2"
                            Width="799px" style="margin-bottom: 55px">
                            <br />
                            <asp:Label ID="Label8" runat="server" CssClass="lblnegro" Text="Escoja la fecha a la cual inscribirse."></asp:Label>
                            <br />
                            <br />
                            ¿A que fechas desea participar?
                            <br />
                            <asp:GridView ID="gvwDetalles" runat="server" AutoGenerateColumns="False" CssClass="mGrid"
                                EmptyDataText="No existen fechas" Height="30px" Width="780px">
                                <Columns>
                                    <asp:TemplateField HeaderText="Seleccionar Inscripcion">
                                        <ItemStyle Width="70px" />
                                        <ItemTemplate>
                                            <asp:CheckBox ID="chkSeleccionar" runat="server" />
                                        </ItemTemplate>
                                    </asp:TemplateField>
                                    <asp:BoundField DataField="id_actividad_detalle" HeaderText="Detalle">
                                        <FooterStyle ForeColor="White" />
                                    </asp:BoundField>
                                    <asp:BoundField DataField="fecha_ini" DataFormatString="{0:dd/MM/yyyy}" HeaderText="Fecha Inicio"
                                        HtmlEncode="false" />
                                    <asp:BoundField DataField="hora_ini" HeaderText="Hora Inicio" HtmlEncode="false" />
                                    <asp:BoundField DataField="fecha_fin" DataFormatString="{0:dd/MM/yyyy}" HeaderText="Fecha Fin"
                                        HtmlEncode="false" />
                                    <asp:BoundField DataField="hora_fin" HeaderText="Hora Fin" HtmlEncode="false" />
                                    <asp:BoundField DataField="des_sede" HeaderText="Sede" HtmlEncode="False" />
                                    <asp:BoundField DataField="lugar" HeaderText="Lugar" HtmlEncode="False" />
                                    <asp:BoundField DataField="vacantes" HeaderText="Vacantes" Visible="False" />
                                </Columns>
                            </asp:GridView>
                            <br />
                            <br />
                            <asp:ImageButton ID="btnAgregar" runat="server" ImageUrl="~/imagenes/botones/agregar_inv.jpg" />
                            <asp:Label ID="Label6" runat="server" Font-Bold="True" ForeColor="Red" Visible="False"></asp:Label>
                            <asp:Label ID="lblmsjerror" runat="server" CssClass="lblrojo"></asp:Label>
                            <asp:Label ID="lblerrorfecha" runat="server" CssClass="lblrojo"></asp:Label>
                            <asp:Label ID="Label1" runat="server" CssClass="lblrojo"></asp:Label>
                            <asp:HyperLink ID="hplink1" runat="server" NavigateUrl="#" Visible="False">Clic Aquí</asp:HyperLink>
                        </asp:Panel>
                        <br />
                        <asp:Panel ID="Panel4" runat="server" BackColor="White" ForeColor="#82AE1D" GroupingText="Paso 3"
                            Width="799px" Visible="false">
                            <br />
                            <asp:Label ID="Label2" runat="server" CssClass="lblnegro" Text="Dé clic en Buscar Familia para seleccionar a las personas que pueden participar."></asp:Label>
                            <br />
                            <br />
                            <asp:ImageButton ID="btnBuscarFamiliares" runat="server" ImageUrl="~/imagenes/botones/bus_inv.jpg" />
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
                        <asp:Panel ID="Panel1" runat="server" BackColor="White" ForeColor="#82AE1D" GroupingText="Paso 4"
                            Width="799px" Visible="false" Height="326px">
                            <br />
                            <asp:Label ID="Label9" runat="server" CssClass="lblnegro" Text="Seleccione agregar familiar para inscribirlo"></asp:Label>
                            <br />
                            <asp:ImageButton ID="btnAgregarFamiliares" runat="server" ImageUrl="~/imagenes/botones/agregar_inv.jpg" />
                            <asp:Label ID="lblnofamiliares" runat="server" CssClass="lblrojo"></asp:Label>
                            <br />
                            <asp:Label ID="Label11" runat="server" CssClass="lblnegro" Text="Dé clic en Grabar cuando haya registrado todas las personas que participaran en la actividad, de lo contrario realice el Paso 1, 2 y 3 nuevamente."></asp:Label>
                            <br />
                            <asp:Label ID="lblmsjpta" runat="server" CssClass="lblnegro" Text="Luego de grabar, la persona estara registrada para participar en la actividad."
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
                                    <asp:CommandField DeleteText="Quitar" HeaderText="Quitar" ShowDeleteButton="True" />
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
