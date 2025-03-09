<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="Calificaciones.aspx.vb" Inherits="PIA.Calificaciones" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body background="RojoClaro2.jpg">
    <form id="form1" runat="server">
      <div align="center">
            <font size="15" face="Arial">
            <img alt="Facultad de Ingeniería Civil | logos-03" align="left" src="UANL.png" style="height: 175px; width: 202px" /><br />
            <img alt="Preparatoria No. 20" align="right" src="https://preparatoria20.uanl.mx/imagenes/paginas/2020/301r.jpg" style="height: 120px; width: 128px" /><br />
            CALIFICACIONES DE TUS UNIDADES DE APRENDIZAJE </font><br />
            <br />
            <font size="5" face="Arial">&nbsp; Escriba la calificación de la primera etapa</font>
            <asp:TextBox ID="TB_E1" runat="server" Height="26px"></asp:TextBox> 
            <br />
            <br />
            <font size="5" face="Arial">Escriba la calificación de la segunda etapa</font>
            <asp:TextBox ID="TB_E2" runat="server" Height="26px"></asp:TextBox> 
            <br />
            <br />
            &nbsp;<font size="5" face="Arial">&nbsp; Escriba la calificación de la tercera etapa </font>
            <asp:TextBox ID="TB_E3" runat="server" Height="26px"></asp:TextBox> 
            <br />
            <br />
            <font size="5" face="Arial">Escriba la calificación de la segunda etapa</font>
            <asp:TextBox ID="TB_E4" runat="server" Height="26px"></asp:TextBox> 
            <br />
            <br />
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <font size="5" face="Arial">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Escriba la calificación de PIA</font>
            <asp:TextBox ID="TB_PIA" runat="server" Height="26px"></asp:TextBox> 
            <br />
            <br />
            
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            
            &nbsp;
            
            <font size="5" face="Arial">Escriba la calificación del primer parcial</font>
            <asp:TextBox ID="TB_ExPP" runat="server" Height="26px"></asp:TextBox> 
            <br />
            <br />
            &nbsp;<font size="5" face="Arial">&nbsp;&nbsp; Escriba la calificación del medio término</font> 
            <asp:TextBox ID="TB_ExMT" runat="server" Height="26px"></asp:TextBox> 
            <br />
            <br />
           <font size="5" face="Arial"> Escriba la calificación del segundo parcial </font>
            <asp:TextBox ID="TB_ExSP" runat="server" Height="26px"></asp:TextBox> 
            <br />
            <br />
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
           <font size="5" face="Arial"> Escriba la calificación del Global </font>
            <asp:TextBox ID="TB_ExG" runat="server" Height="26px"></asp:TextBox> 
            <br />
            <br />

            <asp:Button ID="BTN_Comprobar" runat="server" Text="Calificar" BackColor="#0066FF" BorderColor="Black" Font-Bold="True" Font-Names="Arial Black" Font-Overline="False" Font-Size="XX-Large" ForeColor="#CCFFFF" Height="67px" Width="200px"/> 
            <br />
            <br />
            <asp:Label ID="LBL_Resultado" runat="server" Font-Names="Arial" Font-Size="Large" ForeColor="Black"></asp:Label>
            <br />
            <br />
        </div>
        <div align="center">

            <asp:Button ID="BTN_Volver" runat="server" BackColor="#CC3300" Font-Names="Comic Sans MS" Font-Size="20pt" Height="55px" Text="Volver" Width="226px" />

        </div>
    </form>
</body>
</html>
