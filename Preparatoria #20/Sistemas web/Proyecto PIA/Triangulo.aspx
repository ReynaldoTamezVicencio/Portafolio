<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="Triangulo.aspx.vb" Inherits="PIA.Triangulo" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body background="Amarillo.jpg">
    <form id="form1" runat="server">
     <div style="height: 148px; width: 744px">
            <h1>Programa para indicar el tipo de triángulo</h1>
            Coloque aqui el lado 1
            <asp:TextBox ID="TB_1" runat="server"></asp:TextBox>
            <br />
            Coloque aqui el lado 2
            <asp:TextBox ID="TB_2" runat="server"></asp:TextBox>
            <br />
            Coloque aqui el lado 3
            <asp:TextBox ID="TB_3" runat="server"></asp:TextBox>
            <br />
            <asp:Button ID="BTNComprobar" runat="server" Text="Comprobar" Height="26px" Width="96px" />
            <br />
            <asp:Label ID="LBL1" runat="server"></asp:Label>
            <br />
            Equipo 4
            <br />
            <br />
        
            <br />
            <br />
            <br />
        </div>
        <div align="center" style="width: 980px">

            <br />
            <br />
            <br />
            <br />

            <asp:Button ID="BTN_Volver" runat="server" BackColor="#CCFF66" Font-Names="Comic Sans MS" Font-Size="20pt" Height="55px" Text="Volver" Width="226px" />

        </div>
    </form>
        </body>
</html>
