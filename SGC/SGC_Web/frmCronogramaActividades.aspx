<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/PlantillaSGC.master" CodeBehind="frmCronogramaActividades.aspx.vb" Inherits=".frmCronogramaActividades" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="ajaxToolkit" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div style="height: 370px; width: 745px; text-align: justify; margin-left: 100px; margin-top:10px;">
        <table border="0" cellpadding="0" cellspacing="0">
	        <tr>
                <td class="borderLeftL004">&nbsp;</td>	
	            <td valign="top" style="padding:0px 10px 10px 10px; border-right:solid 1px #FFFFFF; width:200px;">
                    <table border="0" cellpadding="0" cellspacing="0"><tr><td class="generalTextSectionTitle" style="width:250px;"><span style="font-size:small;">Calendario de Actividades</span></td></tr></table><br />
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
                                <asp:HiddenField ID="hdnFechaInicio" runat="server" /><asp:HiddenField ID="hdnFechaFin" runat="server" />
	                        </td>
	                    </tr>
	                </table>
	            </td>
	            <td style="border-left:solid 1px #D8D8D8; padding:10px 10px 10px 10px;" valign="top" align="left">
			        <asp:UpdatePanel ID="upnlActividades" runat="server" UpdateMode="Conditional"><ContentTemplate>
				        <table border="0" cellpadding="0" cellspacing="0"><tr><td style="color:#005787; text-transform:uppercase; font-weight:bold;"><asp:Label ID="lblTituloCalendario" runat="server" Font-Size="Medium"></asp:Label></td></tr></table><br />
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
								        <tr><td class="lblNotEvent"><asp:Label ID="lblNoActividades" runat="server" Font-Size="Small" CssClass="lblmarron"></asp:Label></td></tr>
							        </table>
						        </td>
					        </tr>
				        </table>
			        </ContentTemplate></asp:UpdatePanel>
	            </td>
	            <td class="borderRightL004">&nbsp;</td>	    
            </tr>
        </table>        
    </div>
</asp:Content>
