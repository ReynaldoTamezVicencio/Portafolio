<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="HoraServidor.aspx.vb" Inherits="PIA.HoraServidor" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body bgcolor="000000">
    <form id="form1" runat="server">
        <div align="center">
            <h2><font color="white" face="Arial Black">Pulse para saber la hora actual del servidor</font></h2>
            <p style="height: 298px">
                <asp:Button ID="horaButton" runat="server" Text="Hora actual" EnableViewState="false" BackColor="#66FFCC" BorderColor="White" Font-Names="Comic Sans MS" Font-Size="XX-Large" ForeColor="Black" Height="62px" Width="220px" />
                <br />
                <br />
                <asp:Label ID="horaLabel" runat="server" BackColor="Black"
                    Font-Size="XX-Large" ForeColor="Yellow"></asp:Label>
                <br />
                <br />
                <img src="https://imagenpng.com/wp-content/uploads/2015/03/Reloj.png" align="middle" style="height: 125px; width: 124px" />
            </p>
        </div>
    <div align="center">

            <asp:Button ID="BTN_Volver" runat="server" BackColor="#CC3300" Font-Names="Comic Sans MS" Font-Size="20pt" Height="55px" Text="Volver" Width="226px" />

    </div>
    </form>
    </body>
</html>
