<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Privado/PlantillaSGCInt.Master" CodeBehind="frmCorrelacion.aspx.vb" Inherits="frmCorrelacion" %>

<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit" tagprefix="ajaxToolkit" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
   <ajaxToolkit:ToolkitScriptManager ID="ToolkitScriptManager1" runat="server">
    </ajaxToolkit:ToolkitScriptManager>
    <asp:UpdatePanel ID="upnlSemaforo" runat="server" UpdateMode="Conditional">
    <ContentTemplate>
    <div class="contenedor-pagina">
        <div class="contenedor-pagina-titulo">
            SEMÁFORO DE ACTIVIDADES POR RANGO DE FECHAS
        </div>
        <br />
        <table id="tblComite" runat="server" border="0" cellpadding="0" cellspacing="0" width="918px">
            <tr>
                <td valign="top" style="width:700px;">
                    <asp:Label ID="lblMensaje" runat="server" Text="Para mostrar el semáforo, elegir los filtros deseados y hacer click en Generar."></asp:Label>
                    <asp:GridView ID="gvwSemaforo" runat="server" AutoGenerateColumns="false" AllowPaging="false"
                        CssClass="tabla-grilla" Width="700px" BorderWidth="0px" BorderColor="White">
                        <HeaderStyle CssClass="tabla-grilla-cabecera" />
                        <RowStyle CssClass="tabla-grilla-filas" />
                        <Columns>                            
                            <asp:TemplateField HeaderText="Mes">
                                <ItemTemplate>
                                    <asp:Label ID="lblMes" runat="server" Text='<%#Eval("nombre_mes") %>' ></asp:Label>
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField HeaderText="Porc1" Visible="false">
                                <ItemTemplate>
                                    <asp:Label ID="lblPorc1" runat="server" Text='<%#Eval("porc1") %>' ></asp:Label>
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField HeaderText="Porc2" Visible="false">
                                <ItemTemplate>
                                    <asp:Label ID="lblPorc2" runat="server" Text='<%#Eval("porc2") %>'></asp:Label>
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField HeaderText="Coef" Visible="false" >
                                <ItemTemplate>
                                    <asp:Label ID="lblCoef" runat="server" Text='<%#Eval("coeficiente") %>' ></asp:Label>
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField HeaderText="Conclusión">
                                <ItemTemplate>
                                    <asp:Image ID="imgSemaforo" runat="server" ToolTip='<%#Eval("coeficiente") %>' ImageUrl='<%#IIf(Eval("coeficiente")>0.5,"~/App_Themes/img/semaforo_verde.jpg",IIf(Eval("coeficiente")<-0.5,"~/App_Themes/img/semaforo_rojo.jpg","~/App_Themes/img/semaforo_amarillo.jpg")) %>' />
                                    <%--<asp:Label ID="lblConclusion" runat="server" Text='<%#Eval("conclusion") %>'></asp:Label>--%>
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField HeaderText="Sugerencia">
                                <ItemTemplate>
                                    <%--<asp:Label ID="lblSugerencia" runat="server" Text='<%#Eval("sugerencia") %>'></asp:Label>--%>
                                </ItemTemplate>
                            </asp:TemplateField>
                            <%--<asp:TemplateField HeaderText="Correlación">
                                <ItemTemplate>
                                    <asp:Label ID="lblCorrelacion" runat="server" Text='<%#Eval("correlacion") %>'></asp:Label>
                                    <asp:Image ID="imgSemaforo" runat="server" ToolTip='<%#Eval("correlacion") %>' ImageUrl='<%#IIf(Eval("correlacion")>0.5,"~/App_Themes/img/semaforo_verde.jpg",IIf(Eval("correlacion")<-0.5,"~/App_Themes/img/semaforo_rojo.jpg","~/App_Themes/img/semaforo_amarillo.jpg")) %>' />
                                </ItemTemplate>
                            </asp:TemplateField>--%>
                        </Columns>
                    </asp:GridView>
                    <div id="divLeyenda" runat="server" visible="true">
                        <fieldset>
                            <legend>Leyenda</legend>
                            <asp:Image ID="Image1" runat="server" ImageUrl="~/App_Themes/img/semaforo_verde.jpg" />
                            <asp:Label ID="Label1" runat="server" Text="La relación de ambos tipos de actividad es positiva, ambos crecen o decrecen de una forma constante."></asp:Label><br />
                            <asp:Image ID="Image2" runat="server" ImageUrl="~/App_Themes/img/semaforo_amarillo.jpg" />
                            <asp:Label ID="Label2" runat="server" Text="No hay una relación fuerte en el crecimiento de ambos tipos de actividad, el crecimiento de uno no influye en el crecimiento del otro tipo de actividad."></asp:Label><br />
                            <asp:Image ID="Image3" runat="server" ImageUrl="~/App_Themes/img/semaforo_rojo.jpg" />
                            <asp:Label ID="Label3" runat="server" Text="La relación entre las actividades de ambos tipos es negativa. Si una de ellas crece, la otra decrece."></asp:Label><br />                            
                        </fieldset>                        
                    </div>
                </td>
                <td style="width:10px;"></td>
                <td valign="top" style="width:208px;">
                    <fieldset style="width:100%">
                        <legend>Filtros</legend>
                        <table border="0" cellpadding="0" cellspacing="0">
                            <tr>
                                <td>Comité:</td>
                            </tr>
                            <tr>
                                <td><asp:DropDownList ID="ddlComite" runat="server" CssClass="estilo_textbox" AutoPostBack="true"></asp:DropDownList></td>       
                            </tr>
                        </table>
                        <br />
                        <table id="tblTipos" runat="server" border="0" cellpadding="0" cellspacing="0">
                            <tr>
                                <td>Tipos de Actividad:</td>
                            </tr>
                            <tr>
                                <td><asp:DropDownList ID="ddlTipoActividad" runat="server" CssClass="estilo_textbox" AutoPostBack="true"></asp:DropDownList></td>
                            </tr>
                            <tr>
                                <td>Y</td>
                            </tr>
                            <tr>
                                <td><asp:DropDownList ID="ddlTipoActividad2" runat="server" CssClass="estilo_textbox" AutoPostBack="true"></asp:DropDownList></td>
                            </tr>
                        </table>
                        <br />
                        <table id="Table1" runat="server" border="0" cellpadding="0" cellspacing="0">
                            <tr>
                                <td>Otras opciones:</td>
                            </tr>
                            <tr>
                                <td><asp:CheckBox ID="chkTasas" Text="Tasa de Crecimiento" runat="server" /></td>
                            </tr>
                            <tr>
                                <td><asp:CheckBox ID="chkCoeficiente" Text="Coeficiente Correlación" runat="server" /></td>
                            </tr>
                        </table>
                        <br />
                        <table>
                            <tr>
                                <td>
                                    <asp:LinkButton ID="lbtnGenerar" runat="server" OnClick="lbtnGenerar_Click" CssClass="estilo_boton" Text="Generar"></asp:LinkButton>
                                </td>
                            </tr>
                        </table>
                    </fieldset>
                </td>
            </tr>
        </table>
    </div>
    </ContentTemplate>
    </asp:UpdatePanel>
</asp:Content>
