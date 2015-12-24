<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/PlantillaSGC.master" CodeBehind="Mensaje.aspx.vb" Inherits=".Mensaje" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<div class="DatosSocio" style="height: 370px">
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
							                <td class="textTitleLeft"><asp:Label ID="lblMessagePage" runat="server" CssClass="lblnegro" Font-Size="Medium" Font-Bold="true"></asp:Label></td>
						                </tr>
					                </table> 
					                <table border="0" cellpadding="5" cellspacing="0">
						                <tr>
							                <td class="detailEvent" align="justify"><asp:Label ID="lblMessageDescription" runat="server" CssClass="lblmarron" Font-Size="Small"></asp:Label></td>
						                </tr>
					                </table>
					                <br />
					                <table id="Table1" border="0" cellpadding="0" cellspacing="0" runat="server" style="display:block; visibility:visible; padding-bottom:15px;">
			                            <tr>
				                            <td>
					                            <table border="0" cellpadding="0" cellspacing="0">
						                            <tr>
                                                        <td><asp:ImageButton ID="ibtContinue" runat="server" ImageUrl="~/imagenes/botones/continuar.jpg" /></td>
						                            </tr>
					                            </table>
				                            </td>
			                            </tr>
		                            </table>
                                    <br />                            
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
</div>   
</asp:Content>
