<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/PlantillaSGC.master" CodeBehind="frmDetalleActividad.aspx.vb" Inherits=".frmDetalleActividad" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<table border="0" cellpadding="0" cellspacing="0">
	<tr>
	    <td class="borderLeftL004">&nbsp;</td>	
        <td valign="top" style="background-color:Transparent;">
	        <table border="0" cellpadding="0" cellspacing="0" class="zoneCenterWithoutMenu">
	            <tr>
	                <td valign="top" style="padding-top:15px;">
	                    <table border="0" cellpadding="0" cellspacing="0" style="background-color:Transparent; width:865px;">
	                        <tr>
	                            <td align="left" valign="top" style="padding-left:50px; padding-right:30px;">
                                    <table border="0" cellpadding="5" cellspacing="0">
						                <tr>
							                <td class="textTitleLeft"><asp:HiddenField ID="hdnCompanyID" runat="server" /><asp:Label ID="lblTitleEvent" runat="server" CssClass="lblnegro" Font-Size="Medium" Font-Bold="true"></asp:Label></td>
						                </tr>
					                </table>
					                <table border="0" cellpadding="5" cellspacing="0">
						                <tr>
							                <td class="titleControls" style="width:60px;"><span class="lblverde" style="font-size:small;">Fecha:</span></td>
							                <td class="titleControls"><asp:Label ID="lblDateEvent" runat="server" CssClass="lblmarron" Font-Size="Small"></asp:Label></td>
						                </tr>
					                </table>
					                <table border="0" cellpadding="5" cellspacing="0">
						                <tr>
							                <td class="titleControls" style="width:60px;"><span class="lblverde" style="font-size:small;">Hora:</span></td>
							                <td class="titleControls"><asp:Label ID="lblHourEvent" runat="server" CssClass="lblmarron" Font-Size="Small"></asp:Label></td>
						                </tr>
					                </table>
					                <table border="0" cellpadding="5" cellspacing="0">
						                <tr>
							                <td class="titleControls" style="width:60px;"><span class="lblverde" style="font-size:small;">Dirección:</span></td>
							                <td class="titleControls"><asp:Label ID="lblAddressEvent" runat="server" CssClass="lblmarron" Font-Size="Small"></asp:Label></td>
						                </tr>
					                </table><br />
					                <table border="0" cellpadding="5" cellspacing="0">
						                <tr>
							                <td class="detailEvent" align="justify"><asp:Label ID="lblDescriptionEvent" runat="server" CssClass="lblmarron" Font-Size="Small"></asp:Label></td>
						                </tr>
					                </table>
					                <br />
					                <table id="RegisterNow" border="0" cellpadding="0" cellspacing="0" runat="server" style="display:block; visibility:visible; padding-bottom:15px;">
			                            <tr>
				                            <td>
					                            <table border="0" cellpadding="0" cellspacing="0">
						                            <tr>
                                                        <td><asp:ImageButton ID="ibtnRegresar" runat="server" ImageUrl="~/imagenes/botones/regresar.jpg" /></td>
							                            <td style="font-size:16px; font-weight:normal;">
								                            <asp:ImageButton ID="ibtnRegisterNow" SkinID="ibtnRegisterNow" runat="server" ImageUrl="~/imagenes/botones/reservar.jpg" />	
								                            <asp:Label ID="lblRegistrationClosed" runat="server" Text="" Visible="false" CssClass="lblnegro" Font-Size="Small" Font-Bold="true"></asp:Label>							
							                            </td>
						                            </tr>
					                            </table>
				                            </td>
			                            </tr>
		                            </table>
                                    <table border="0" cellpadding="0" cellspacing="0">
			                            <tr>
				                            <td id="tdMessageEndDateEvent" runat="server" style="display:none">
					                            <table border="0" cellpadding="0" cellspacing="0">
						                            <tr>
							                            <td class="messageEndEventDate">
								                            <asp:Label ID="lblMessageEndDateEvent" runat="server" CssClass="lblnegro" Font-Size="Small" Font-Bold="true"></asp:Label>
							                            </td>
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
	    </td>
        <td class="borderRightL004">&nbsp;</td>	    
	</tr>
</table>
</asp:Content>
