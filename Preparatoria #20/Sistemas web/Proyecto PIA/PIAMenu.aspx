<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="PIAMenu.aspx.vb" Inherits="PIA.PIAMenu" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body background="GrisClaro.jpg">
    <form id="form1" runat="server">
       <div align="left">
           <asp:Image ID="Image2" runat="server" Height="125px" ImageUrl="~/UANL.png" Width="136px" ImageAlign="Left" />
           <asp:Image ID="Image3" runat="server" Height="122px" ImageAlign="Right" ImageUrl="~/Prepa20Logo.png" Width="120px" />
       </div>
        <div align="center">
            <asp:Label ID="Label1" runat="server" Font-Bold="True" Font-Size="25pt" Text="UNIVERSIDAD AUTÓNOMA DE NUEVO LEÓN"></asp:Label>
            <br />
            <asp:Label ID="Label2" runat="server" Font-Bold="True" Font-Size="25pt" Text="Preparatoria 20"></asp:Label>
            <br />
            <br />
            <asp:Label ID="Label3" runat="server" Font-Bold="False" Font-Size="25pt" Text="Desarrollo de Sistemas Web"></asp:Label>
            <br />
            <asp:Label ID="Label4" runat="server" Font-Bold="False" Font-Size="25pt" Text="Semestre 4"></asp:Label>
            <br />
            <asp:Label ID="Label5" runat="server" Font-Bold="False" Font-Size="25pt" Text="Etapa 4: PIA"></asp:Label>
            <br />
            <asp:Label ID="Label6" runat="server" Font-Bold="False" Font-Size="25pt" Text="MD: Raquel Morales Marroquín"></asp:Label>
            <br />
            <asp:Label ID="Label7" runat="server" Font-Bold="False" Font-Size="25pt" Text="Grupo 407"></asp:Label>
            <br />
            <br />
            <asp:Image ID="Image1" runat="server" Height="283px" ImageUrl="~/Equipo4.png" Width="580px" />
            <br />
            <br />
            <asp:Label ID="Label8" runat="server" Font-Bold="False" Font-Size="25pt" Text="Etapa 1" Font-Names="Comic Sans MS"></asp:Label>
            <br />
            <br />
            <asp:Button ID="BTN_BlocDeNotas" runat="server" BackColor="#CCFF66" Font-Names="Comic Sans MS" Font-Size="20pt" Height="55px" Text="Bloc de notas" Width="226px" />
&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="BTN_Nombre" runat="server" BackColor="#CCFF66" Font-Names="Comic Sans MS" Font-Size="20pt" Height="55px" Text="Nombre" Width="226px" />
&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="BTN_Triangulo" runat="server" BackColor="#CCFF66" Font-Names="Comic Sans MS" Font-Size="20pt" Height="55px" Text="Triangulo" Width="226px" />
            <br />
            <br />
            <br />
            <asp:Label ID="Label9" runat="server" Font-Bold="False" Font-Size="25pt" Text="Etapa 2" Font-Names="Comic Sans MS"></asp:Label>
            <br />
            <br />
            <asp:Button ID="BTN_Hobbie" runat="server" BackColor="#FF6600" Font-Names="Comic Sans MS" Font-Size="20pt" Height="55px" Text="Hobbie" Width="226px" />
&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="BTN_HoraServidor" runat="server" BackColor="#FF6600" Font-Names="Comic Sans MS" Font-Size="20pt" Height="55px" Text="Hora Servidor" Width="226px" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="BTN_Calificaciones" runat="server" BackColor="#FF6600" Font-Names="Comic Sans MS" Font-Size="20pt" Height="55px" Text="Calificaciones" Width="226px" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="BTN_Formulario" runat="server" BackColor="#FF6600" Font-Names="Comic Sans MS" Font-Size="20pt" Height="55px" Text="Formularios" Width="226px" />
            <br />
&nbsp;&nbsp;
            <br />
            <br />
            <asp:Label ID="Label10" runat="server" Font-Bold="False" Font-Size="25pt" Text="Etapa 3" Font-Names="Comic Sans MS"></asp:Label>
            <br />
            <br />
            <asp:Button ID="BTN_FormIdiomas" runat="server" BackColor="#33CC33" Font-Names="Comic Sans MS" Font-Size="20pt" Height="60px" Text="Formulario de idiomas" Width="317px" />
            <br />
            <br />
            <br />
            <asp:Label ID="Label11" runat="server" Font-Bold="False" Font-Size="25pt" Text="Etapa 4" Font-Names="Comic Sans MS"></asp:Label>
            <br />
            <br />
            <asp:Button ID="BTN_GenerosMusicales" runat="server" BackColor="#3366FF" Font-Names="Comic Sans MS" Font-Size="20pt" Height="55px" Text="Géneros musicales" Width="284px" />
&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="BTN_MultivistaInscripcion" runat="server" BackColor="#3366FF" Font-Names="Comic Sans MS" Font-Size="20pt" Height="55px" Text="Multivista Inscripción" 
                Width="284px" />
            <br />
        </div>
    </form>
</body>
</html>
