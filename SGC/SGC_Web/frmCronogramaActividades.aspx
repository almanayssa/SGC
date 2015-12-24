<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/PlantillaSGC.master" CodeBehind="frmCronogramaActividades.aspx.vb" Inherits=".frmCronogramaActividades" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="ajaxToolkit" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<table class="tablita">
    <tr>
        <td style="width: 866px">
            <div>
                <div class="DatosSocio3">
                    <br />
                    <asp:Label ID="Label10" runat="server" CssClass="lblnegro" Text="Para inscribirse a las actividades siga los pasos que se muestran a continuación:"></asp:Label>
                    <br />
                    <br />
                    <table border="0" cellpadding="0" cellspacing="0">
                        <tr>
                            <td valign="top">
                                <asp:Panel ID="Panel1" runat="server" BackColor="White" ForeColor="#82AE1D" GroupingText="Calendario de Actividades" Width="300px">
                                    <br />
                                    &nbsp;&nbsp;&nbsp;
                                    <asp:Label ID="Label7" runat="server" CssClass="lblnegro" Text="Seleccione una fecha para filtrar"></asp:Label>
                                    <br />
                                    <br />
                                    <br />
                                    <table border="0" cellpadding="0" cellspacing="0">
	                                    <tr>
	                                        <td style="width:151px;">
                                                <asp:Calendar ID="calActividades" runat="server" BorderStyle="None" CellSpacing="2" DayNameFormat="FirstLetter" Width="151px" OnVisibleMonthChanged="CalendarioOtroAnioMes">
                                                    <TitleStyle CssClass="calendarDayHeader" BackColor="Transparent" />
                                                    <DayStyle ForeColor="#333333" CssClass="calendarGeneral" />
                                                    <DayHeaderStyle CssClass="calendarDayHeader" />
                                                    <TodayDayStyle CssClass="calendarTodayDay" ForeColor="White" />
                                                    <SelectedDayStyle BackColor="White" ForeColor="#005787" />
                                                    <OtherMonthDayStyle CssClass="calendarOtherMonthDay" ForeColor="#A7A7A7" />
                                                    <NextPrevStyle ForeColor="#005787" />
                                                </asp:Calendar><br />
	                                        </td>
	                                        <td valign="top" style="padding-left:5px;">
	                                            <asp:LinkButton ID="lbtnHoy" runat="server" Text="-Hoy" CssClass="lblverde"></asp:LinkButton><br />
	                                            <asp:LinkButton ID="lbtnEstaSemana" runat="server" Text="-Esta Semana" CssClass="lblverde"></asp:LinkButton><br />
	                                            <asp:LinkButton ID="lbtnEsteMes" runat="server" Text="-Esta Mes" CssClass="lblverde"></asp:LinkButton>
                                                <asp:HiddenField ID="hdnFechaInicio" runat="server" />
                                                <asp:HiddenField ID="hdnFechaFin" runat="server" />
	                                        </td>
	                                    </tr>
	                                </table>
                                    <br />
                                </asp:Panel>
                            </td>
                            <td valign="top">
                                <asp:Panel ID="Panel2" runat="server" BackColor="White" ForeColor="#82AE1D" GroupingText="Listado de Actividades" Width="566px">
                                    <br />
                                    &nbsp;&nbsp;&nbsp;
                                    <asp:Label ID="lblTituloCalendario" runat="server" Font-Size="Small" Font-Bold="true"></asp:Label>
                                    <br />
                                    <br />
                                    &nbsp;&nbsp;&nbsp;
                                    <asp:Label ID="Label2" runat="server" CssClass="lblnegro" Text="Dé clic en Inscribir para inscribirse a la actividad de su preferencia."></asp:Label>
                                    <br />
                                    <br />                                 
                                    <asp:UpdatePanel ID="upnlActividades" runat="server" UpdateMode="Conditional"><ContentTemplate>
				                    <asp:Repeater ID="rptCalendarioActividades" runat="server"> <%--DataSource='<%#GetEvents()%>'>--%>
                                        <ItemTemplate>
                                            <table border="0" cellpadding="0" cellspacing="0">
                                                <tr>                                
                                                    <td class="contentEventsCalendar" align="justify" valign="top">
                                                        <asp:LinkButton ID="lbtnTituloActividad" runat="server" CommandName="DetalleActividad"
                                                            CommandArgument='<%#Eval("id_actividad") %>' Text='<%# Eval("nombre") %>'
                                                            ToolTip='<%# Eval("nombre") %>' CssClass="lblverde" Font-Size="Small"></asp:LinkButton><br />
                                                        <asp:Label ID="lblEventDateHourHome" runat="server" CssClass="lblmarron" Font-Size="Smaller" Text='<%#IIf(CType(Eval("fec_ini"),DateTime).ToShortDateString() = CType(Eval("fec_fin"),DateTime).ToShortDateString(), String.Concat(CType(Eval("fec_ini"),DateTime).ToShortDateString(), " (", CType(Eval("fec_ini"),DateTime).ToShortTimeString(), " - ", CType(Eval("fec_fin"),DateTime).ToShortTimeString(), ")"), String.Concat(CType(Eval("fec_ini"),DateTime).ToShortDateString(), " ", CType(Eval("fec_ini"),DateTime).ToShortTimeString(), " - ", CType(Eval("fec_fin"),DateTime).ToShortDateString(), " ",CType(Eval("fec_fin"),DateTime).ToShortTimeString())) %>'></asp:Label><br />
                                                        <asp:Label ID="lblDefinitionEvent" runat="server" CssClass="lblmarron" Font-Size="Smaller" Text='<%# Eval("descripcion") %>'></asp:Label>
                                                    </td>
                                                    <td class="contentEventsLinks">
                                                        <table border="0" cellpadding="0" cellspacing="0" id="tblRegisterNow" runat="server"
                                                            style="display: block;">
                                                            <tr>
                                                                <td>
                                                                    <asp:ImageButton ID="ibtnInscribirse" runat="server" ImageUrl="~/imagenes/botones/inscribir.jpg" PostBackUrl='<%#String.Concat("~/frmRegistroInscripcion.aspx?id=", Eval("id_actividad")) %>' />                                                
                                                                </td>
                                                            </tr>
                                                        </table>
                                                    </td>
                                                </tr>
                                            </table>
                                            <br />
                                        </ItemTemplate>
                                    </asp:Repeater>
				                    <table id="tblMsgNoActividades" runat="server" style="display:none;" border="0" cellpadding="0" cellspacing="0">
					                    <tr>
						                    <td class="bodyEvents">
							                    <table border="0" cellpadding="0" cellspacing="0">
								                    <tr><td class="lblNotEvent">&nbsp;&nbsp;&nbsp;&nbsp;<asp:Label ID="lblNoActividades" runat="server" CssClass="lblnegro" Font-Bold="true"></asp:Label></td></tr>
							                    </table>
						                    </td>
					                    </tr>
				                    </table>
			                    </ContentTemplate>
                                </asp:UpdatePanel>
                                    <br />
                                </asp:Panel>                            
                            </td>
                        </tr>
                    </table>
                </div>
            </div>
        </td>
    </tr>
</table>
</asp:Content>
