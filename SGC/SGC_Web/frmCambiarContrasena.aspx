<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/PlantillaSGC.master" CodeBehind="frmCambiarContrasena.aspx.vb" Inherits=".frmCambiarContrasena" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<div class="DatosSocio" style="height: 370px">
<p style="padding-top:30px">
<span id="Label1" class="lblmarron" style="display:inline-block;height:58px;width:432px;">Si ha olvidado su contraseña, ingrese su correo electrónico y la contraseña será enviada a la dirección proporcionada siempre y cuando dicha dirección se encuentre registrada en el sistema. </span>
</p>
<br />
<p>
<span class="tab">Dirección de correo: </span>
<asp:TextBox ID="txtCorreo" runat="server" MaxLength="120" Width="140px"></asp:TextBox>
</p>
<asp:ImageButton ID="ibtnEnviar" runat="server" ImageUrl="~/imagenes/botones/boton_enviar.jpg" />
<br />
<asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ErrorMessage="Correo incorrecto" ControlToValidate="txtCorreo" ForeColor="Red" ValidationExpression="[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?"></asp:RegularExpressionValidator>
    </div>
</asp:Content>
