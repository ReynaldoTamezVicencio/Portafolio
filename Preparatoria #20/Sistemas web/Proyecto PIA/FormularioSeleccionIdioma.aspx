<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="FormularioSeleccionIdioma.aspx.vb" Inherits="PIA.FormularioSeleccionIdioma" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body background="FondoCeleste.jpg">
    <form id="form1" runat="server" method="post">
        <div style="height: 1703px">
                <asp:Label ID="Label10" runat="server" Font-Names="Comic Sans MS" Font-Size="30pt" align="center" ForeColor="Black" Text="Seleccione el idioma que le gustaría aprender">
                </asp:Label>
                <br />
                <br />
            <br />
                <asp:Panel ID="Panel_Idiomas" runat="server" Height="190px" Width="221px">
                    <asp:CheckBox ID="ChkB_Todos" runat="server" Font-Names="Comic Sans MS" Font-Size="18pt" Text="Todos" AutoPostBack="True" />
                    <asp:CheckBoxList ID="ChkBL_Idiomas" runat="server" Font-Names="Comic Sans MS" Font-Size="18pt" AutoPostBack="True">
                        <asp:ListItem>Inglés</asp:ListItem>
                        <asp:ListItem>Francés</asp:ListItem>
                        <asp:ListItem>Aleman</asp:ListItem>
                        <asp:ListItem>Italiano</asp:ListItem>
                    </asp:CheckBoxList>
                    <br />
                </asp:Panel>
                <br />
                <asp:Panel ID="Panel_Ingles" runat="server" Height="223px" Width="221px" Visible="false">
                    <asp:Label ID="Label11" runat="server" Font-Names="Comic Sans MS" Font-Size="18pt" ForeColor="Blue" Text="Nivel de inglés "></asp:Label>
                    <asp:CheckBoxList ID="ChBL_Ingles" runat="server" Font-Names="Comic Sans MS" Font-Size="18pt" Width="190px" AutoPostBack="True">
                        <asp:ListItem>Básico</asp:ListItem>
                        <asp:ListItem>Intermedio</asp:ListItem>
                        <asp:ListItem>Avanzado</asp:ListItem>
                        <asp:ListItem>Empresarial</asp:ListItem>
                        <asp:ListItem>Para viajes</asp:ListItem>
                    </asp:CheckBoxList>
                    &nbsp;
                </asp:Panel>
                <br />
                <asp:Panel ID="Panel_Frances" runat="server" Height="225px" Width="218px" Visible="false">
                    <asp:Label ID="Label12" runat="server" Font-Names="Comic Sans MS" Font-Size="18pt" ForeColor="Blue" Text="Nivel de francés"></asp:Label>
                    <asp:CheckBoxList ID="ChBL_Frances" runat="server" Font-Names="Comic Sans MS" Font-Size="18pt" Width="190px" AutoPostBack="True">
                        <asp:ListItem>Básico</asp:ListItem>
                        <asp:ListItem>Intermedio</asp:ListItem>
                        <asp:ListItem>Avanzado</asp:ListItem>
                        <asp:ListItem>Empresarial</asp:ListItem>
                        <asp:ListItem>Para viajes</asp:ListItem>
                    </asp:CheckBoxList>
                </asp:Panel>
                <br />
                <asp:Panel ID="Panel_Aleman" runat="server" Height="226px" Width="214px" Visible="false">
                    <asp:Label ID="Label13" runat="server" Font-Names="Comic Sans MS" Font-Size="18pt" ForeColor="Blue" Text="Nivel de aleman"></asp:Label>
                    <asp:CheckBoxList ID="ChBL_Aleman" runat="server" Font-Names="Comic Sans MS" Font-Size="18pt" Width="190px" Height="188px" AutoPostBack="True">
                        <asp:ListItem>Básico</asp:ListItem>
                        <asp:ListItem>Intermedio</asp:ListItem>
                        <asp:ListItem>Avanzado</asp:ListItem>
                        <asp:ListItem>Empresarial</asp:ListItem>
                        <asp:ListItem>Para viajes</asp:ListItem>
                    </asp:CheckBoxList>
                </asp:Panel>
                <br />
                <asp:Panel ID="Panel_Italiano" runat="server" Height="220px" Width="209px" Visible="false">
                    <asp:Label ID="Label14" runat="server" Font-Names="Comic Sans MS" Font-Size="18pt" ForeColor="Blue" Text="Nivel de italiano"></asp:Label>
                    <asp:CheckBoxList ID="ChBL_Italiano" runat="server" Font-Names="Comic Sans MS" Font-Size="18pt" Width="190px" AutoPostBack="True">
                        <asp:ListItem>Básico</asp:ListItem>
                        <asp:ListItem>Intermedio</asp:ListItem>
                        <asp:ListItem>Avanzado</asp:ListItem>
                        <asp:ListItem>Empresarial</asp:ListItem>
                        <asp:ListItem>Para viajes</asp:ListItem>
                    </asp:CheckBoxList>
                    <br />
                    <br />
                    <br />
                    <br />
                    <br />
                </asp:Panel>
                <br />
                <br />
                <asp:Panel ID="Panel_Hora" runat="server" Height="238px" Width="299px">
                    <asp:Label ID="Label15" runat="server" Font-Names="Comic Sans MS" Font-Size="18pt" ForeColor="Maroon" Text="Elija horario"></asp:Label>
                    <asp:CheckBoxList ID="ChBL_Hora" runat="server" Font-Names="Comic Sans MS" Font-Size="18pt" Width="269px" ValidateRequestMode="Disabled" ValidationGroup="Horas">
                        <asp:ListItem>12:00 P.M. - 1:30 P.M.</asp:ListItem>
                        <asp:ListItem>1:30 P.M. - 3:00 P.M.</asp:ListItem>
                        <asp:ListItem>3:00 P.M. - 4:30 P.M.</asp:ListItem>
                        <asp:ListItem>4:30 P.M. - 6:00 P.M.</asp:ListItem>
                        <asp:ListItem>6:00 P.M. - 7:30 P.M.</asp:ListItem>
                    </asp:CheckBoxList>
                    <br />
                    <br />
                    <br />
                    <br />
                    <br />
                    <br />
                    <br />
                    <br />
                </asp:Panel>
                <br />
                <br />
                <br />
                <br />
                <br />
                <br />
        </div>
            <div align="center">
                <br />
                <br />
            <asp:Button ID="BTN_Anterior" runat="server" Font-Names="Comic Sans MS" Font-Size="30pt" Height="76px" Text="Anterior" Width="179px" BackColor="#3399FF" />
                <br />
            <asp:ImageButton ID="ImageButton1" runat="server" Height="139px" ImageUrl="~/Boton, enviar formulario.png" Width="488px" />
                <br />
                <br />
                <br />
                <br />
                <br />
            <asp:Button ID="BTN_Volver" runat="server" BackColor="#339933" Font-Names="Comic Sans MS" Font-Size="20pt" Height="55px" Text="Volver" Width="226px" />
            </div>
    </form>
</body>
</html>
