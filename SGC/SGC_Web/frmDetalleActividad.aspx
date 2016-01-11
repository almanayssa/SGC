<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/PlantillaSGC.master" CodeBehind="frmDetalleActividad.aspx.vb" Inherits=".frmDetalleActividad" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<table class="tablita">
    <tr>
        <td style="width: 500px">
            <div class="centrado">
                <div class="DatosSocio3">
                    <br />
                    <asp:Label ID="lblNombre" runat="server" CssClass="lblverde" Font-Size="Small" Font-Bold="true"></asp:Label>
                    <br />
                    <br />                        
                    <br />
                    <span class="lblnegro">Comité:</span>
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:Label ID="lblComite" runat="server" CssClass="lblnegro"></asp:Label>
                    <br />                        
                    <br />
                    <span class="lblnegro" >Tipo:</span>
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:Label ID="lblTipo" runat="server" CssClass="lblnegro"></asp:Label>
                    <br />                        
                    <br />
                    <span class="lblnegro">Fecha Inicio:</span>
                    &nbsp;
                    <asp:Label ID="lblFechaInicio" runat="server" CssClass="lblnegro"></asp:Label>
                    <br />                        
                    <br />
                    <span class="lblnegro">Hora Inicio:</span>
                    &nbsp;&nbsp;&nbsp;
                    <asp:Label ID="lblHoraInicio" runat="server" CssClass="lblnegro"></asp:Label>
                    <br />                        
                    <br />
                    <%--<span class="lblnegro">Fecha Fin:</span>
                    &nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:Label ID="lblFechaFin" runat="server" CssClass="lblnegro"></asp:Label>
                    <br />                        
                    <br />--%>
                    <span class="lblnegro">Hora Fin:</span>
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:Label ID="lblHoraFin" runat="server" CssClass="lblnegro"></asp:Label>
					<br />
                    <br />
                    <asp:Label ID="lblDescripcion" runat="server" CssClass="lblnegro"></asp:Label>
					<br />
                    <br />
                    <asp:ImageButton ID="ibtnRegresar" runat="server" ImageUrl="~/imagenes/botones/regresar.jpg" />
                    <asp:ImageButton ID="ibtnInscribir" runat="server" ImageUrl="~/imagenes/botones/inscribir.jpg" />
                    <br />
                    <br />
                    <asp:Label ID="lblActividadFinalizada" runat="server" CssClass="lblnegro"></asp:Label>
                </div>
            </div>
        </td>
    </tr>
</table>
</asp:Content>
