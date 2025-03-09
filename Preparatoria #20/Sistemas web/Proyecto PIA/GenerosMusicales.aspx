<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="GenerosMusicales.aspx.vb" Inherits="PIA.GenerosMusicales" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
    <body background="FondoAzul.jpg" style="height: 1187px">
    <form id="form1" runat="server">
        <div style="height: 1209px">
           <div align="center">
            <asp:Image ID="Image1" runat="server" Height="455px" ImageAlign="AbsMiddle" ImageUrl="~/Imagenes/1Rock.jpg" Width="667px" />
            </div>
               <br />
            <br />
            <br />
             <div align="center">
            <asp:Panel ID="PanelRock" runat="server" Height="111px" HorizontalAlign="Center" Visible="False" Width="868px">
                <asp:Label ID="Label1" runat="server" Text="Rock" Font-Names="Comic Sans MS" Font-Size="20pt" ForeColor="White"></asp:Label>
                <br />
                <asp:Label ID="Label5" runat="server" Font-Names="Comic Sans MS" Font-Size="18pt" ForeColor="White" 
                    Text="En la imagen se puede apreciar al vocalista Gustavo Cerati de la banda Soda Stereo cantando mientras toca su guitarra azul"></asp:Label>
            </asp:Panel>
            <br />
            <asp:Panel ID="PanelPop" runat="server" HorizontalAlign="Center" Visible="False" Width="444px">
                <asp:Label ID="Label2" runat="server" Text="Pop" Font-Names="Comic Sans MS" Font-Size="20pt" ForeColor="White"></asp:Label>
                <br />
                <asp:Label ID="Label6" runat="server" Font-Names="Comic Sans MS" Font-Size="18pt" ForeColor="White" Text="Imagen del vocalista de Maroon 5"></asp:Label>
                <br />
            </asp:Panel>
            <br />
            <asp:Panel ID="PanelHipHop" runat="server" HorizontalAlign="Center" Visible="False" Width="450px">
                <asp:Label ID="Label3" runat="server" Text="Hip Hop" Font-Names="Comic Sans MS" Font-Size="20pt" ForeColor="White"></asp:Label>
                <br />
                <asp:Label ID="Label7" runat="server" Font-Names="Comic Sans MS" Font-Size="18pt" ForeColor="White" Text="Imagen con varios artistas de hip hop"></asp:Label>
                <br />
            </asp:Panel>
            <br />
            <asp:Panel ID="PanelClasica" runat="server" HorizontalAlign="Center" Visible="False" Width="857px">
                <asp:Label ID="Clasica" runat="server" Text="Clasica" Font-Names="Comic Sans MS" Font-Size="20pt" ForeColor="White"></asp:Label>
                <br />
                <asp:Label ID="Label8" runat="server" Font-Names="Comic Sans MS" Font-Size="18pt" ForeColor="White" Text="En esta imagen podemos ver a varias personas tocando sus instrumentos, generando diferentes sonidos para formar musica clasica."></asp:Label>
                <br />
            </asp:Panel>
            <br />
            <asp:Panel ID="PanelElectronica" runat="server" HorizontalAlign="Center" Visible="False" Width="853px">
                <asp:Label ID="Label4" runat="server" Text="Electrónica" Font-Names="Comic Sans MS" Font-Size="20pt" ForeColor="White"></asp:Label>
                <br />
                <asp:Label ID="Label9" runat="server" Font-Names="Comic Sans MS" Font-Size="18pt" ForeColor="White" Text="En la imagen se puede ver a un duo de músicos llamado Daft Punk, dedicados a hacer musica electrónica y rock con diferentes estilos, recientemente anunciaron su retiro.  "></asp:Label>
                <br />
            </asp:Panel>
         </div>
            <br />
            <br />
           
            <div align="center">
            <asp:DropDownList ID="DropDownList1" runat="server" BackColor="Aqua" Font-Names="Comic Sans MS" Font-Size="20pt" Height="60px" Width="249px">
                <asp:ListItem>1Rock</asp:ListItem>
                <asp:ListItem>2Pop</asp:ListItem>
                <asp:ListItem>3HipHop</asp:ListItem>
                <asp:ListItem>4Clasica</asp:ListItem>
                <asp:ListItem>5Electronica</asp:ListItem>
            </asp:DropDownList>
&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="BTN_Elegir" runat="server" BackColor="#FF9933" Font-Names="Comic Sans MS" Font-Size="20pt" Height="62px" style="margin-left: 0px" Text="Elegir" Width="152px" />
&nbsp;      
                <br />
                <br />
                <br />
            <asp:Button ID="BTN_Volver" runat="server" BackColor="#3366FF" Font-Names="Comic Sans MS" Font-Size="20pt" Height="55px" Text="Volver" Width="226px" />
            </div>
           
        </div>
    </form>
</body>
</html>
