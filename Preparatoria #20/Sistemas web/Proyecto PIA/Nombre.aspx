<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="Nombre.aspx.vb" Inherits="PIA.Nombre" %>

<script runat="server">
    Sub HandleSubmit(sender As Object, e As EventArgs)
        ResponseText.Text = "Tu nombre es: " & Nombre.Text
    End Sub
</script>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body background="Amarillo.jpg">
    <form id="form1" runat="server">
        <div>
             Escribe tu nombre
            <asp:TextBox runat="server" ID="Nombre" />
            <br />
            <asp:Button runat="server" Text="Presioname" ID="ClicBoton" OnClick="HandleSubmit" Width="187px" />
            <br />
            <asp:Literal ID="ResponseText" runat="server" />
            <br />
             Equipo 4
        </div>
        <div align="center">

            <asp:Button ID="BTN_Volver" runat="server" BackColor="#CCFF66" Font-Names="Comic Sans MS" Font-Size="20pt" Height="55px" Text="Volver" Width="226px" />

        </div>
    </form>
</body>
</html>
