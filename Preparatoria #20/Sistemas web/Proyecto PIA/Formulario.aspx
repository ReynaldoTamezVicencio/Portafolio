<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="Formulario.aspx.vb" Inherits="PIA.Formulario" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body background="https://www.wallpapertip.com/wmimgs/135-1356005_website-backgrounds-wallpaper-fondos-de-pagina-web-azul.jpg">
    <form id="form1" runat="server">
        <div style="height: 1439px">
           <p align="center"><font size="12" face="Arial"><b><mark>Carrera Favorita</mark></b></font></p><br />
            <br />
            <br />
            <font size="6" face="Arial">Nombre</font>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="TB_Nombre" runat="server" style="margin-left: 12px" Height="29px" Width="340px" Font-Size="14"></asp:TextBox>
            &nbsp;<asp:RequiredFieldValidator ID="Nombre" runat="server" ControlToValidate="TB_Nombre" ErrorMessage="Favor de colocar nombre" Font-Size="18pt"></asp:RequiredFieldValidator>
            <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <font size="6" face="Arial">
            <br />
            Apellido&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <asp:TextBox ID="TB_Apellido" runat="server" Height="29px" Width="342px" Font-Size="14"></asp:TextBox>
            </font>&nbsp
            &nbsp;<asp:RequiredFieldValidator ID="Apellido" runat="server" ControlToValidate="TB_Apellido" ErrorMessage="Favor de colocar apellido" Font-Size="18pt"></asp:RequiredFieldValidator>
            <br />
            <br />
            <font size="6" face="Arial">Edad</font>&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp; &nbsp;
            <asp:TextBox ID="TB_Edad" runat="server" Height="29px" Width="75px" Font-Size="14"></asp:TextBox>
            &nbsp;<asp:RequiredFieldValidator ID="Edad" runat="server" ControlToValidate="TB_Edad" ErrorMessage="Favor de colocar edad" Font-Size="18pt"></asp:RequiredFieldValidator>
            <br />
            <font size="6" face="Arial">
            <br />
            Email</font>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp; &nbsp;
            <asp:TextBox ID="TB_Email" runat="server" Height="29px" Width="343px" Font-Size="14"></asp:TextBox>
&nbsp;<asp:RequiredFieldValidator ID="Email" runat="server" ControlToValidate="TB_Email" ErrorMessage="Favor de colocar email" Font-Size="18pt"></asp:RequiredFieldValidator>
            &nbsp;
            &nbsp;&nbsp;&nbsp;
            <br />
            <img align="Right" alt="Es UANL la mejor universidad pública estatal - Punto U - Universidad  Autónoma de Nuevo León" src="https://puntou.uanl.mx/wp-content/uploads/2020/02/rectoria-uanl.jpg" style="height: 215px; width: 397px" /><br />
            <font size="6" face="Arial"><asp:Label ID="Label3" runat="server" Text="Telefono"></asp:Label></font>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;
            <asp:TextBox ID="TB_Telefono" runat="server" Height="29px" Width="343px" Font-Size="14"></asp:TextBox>
&nbsp;
            <asp:RequiredFieldValidator ID="Teléfono" runat="server" ControlToValidate="TB_Telefono" ErrorMessage="Favor de colocar el teléfono" Font-Size="18pt"></asp:RequiredFieldValidator>
            <br />
            <br />
            <font size="6" face="Arial"><asp:Label ID="Label1" runat="server" Text="Dirección"></asp:Label></font>
&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="TB_Direccion" runat="server" Height="29px" Width="344px" Font-Size="14"></asp:TextBox>
&nbsp;<asp:RequiredFieldValidator ID="Direccion" runat="server" ControlToValidate="TB_Direccion" ErrorMessage="Favor de colocar dirección" Font-Size="18pt"></asp:RequiredFieldValidator>
&nbsp;&nbsp;&nbsp;<br />
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <br />
            <font size="6" face="Arial"><asp:Label ID="Label2" runat="server" Text="Colonia"></asp:Label>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </font>
&nbsp;<asp:TextBox ID="TB_Colonia" runat="server" Height="29px" Width="346px" Font-Size="14"></asp:TextBox>
            <asp:RequiredFieldValidator ID="Colonia" runat="server" ControlToValidate="TB_Colonia" ErrorMessage="Favor de colocar colonia" Font-Size="18pt"></asp:RequiredFieldValidator>
            <br />
            <br />
            <br />
                  <font size="6" face="Arial">Ciudad&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </font>&nbsp;<asp:DropDownList ID="DropDownList1" runat="server" Height="38px" style="margin-bottom: 0px" Width="145px" Font-Size="14">
                    <asp:ListItem>Monterrey</asp:ListItem>
                    <asp:ListItem>Santiago</asp:ListItem>
                    <asp:ListItem>San Pedro</asp:ListItem>
                    <asp:ListItem>San Nicolás</asp:ListItem>
                    <asp:ListItem>Guadalupe</asp:ListItem>
                    <asp:ListItem>Apodaca</asp:ListItem>
                    <asp:ListItem>García</asp:ListItem>
                    <asp:ListItem>Montemorelos</asp:ListItem>
                </asp:DropDownList>
            <br />
            <br />
            <br />
            <asp:Panel ID="Panel3" runat="server" Font-Size="6pt" Height="123px" Width="321px">
               <font size="6" face="Arial"> <asp:Label ID="Label5" runat="server" Text="Género  "></asp:Label>
                <br />
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:RadioButton ID="RadioButton1" runat="server" Text="Masculino" GroupName="Genero" />
                <br />
                
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                
                <asp:RadioButton ID="RadioButton2" runat="server" Text="Femenino" GroupName="Genero" />
                </font>
            </asp:Panel>
            <br />
            <br />
            <asp:Panel ID="Panel2" runat="server" Height="294px" Width="750px">
                <font size="7" face="Arial"><asp:Label ID="Label4" runat="server" Text="Selecciona tu carrera preferida"></asp:Label></font>
                <br />
                <br />
                <font size="6" face="Arial"><asp:CheckBox ID="ChB_Arquitectura" runat="server" Text=" Arquitectura" /></font>
                <br />
                <font size="6" face="Arial"><asp:CheckBox ID="ChB_IngProgramacion" runat="server" Text=" Ing. Sistemas" /></font>
                <br />
               <font size="6" face="Arial"> <asp:CheckBox ID="ChB_Contaduria" runat="server" Text=" Contaduría" /></font>
                <br />
               <font size="6" face="Arial"> <asp:CheckBox ID="ChB_Medicina" runat="server" Text=" Medicina" /></font>
                <br />
               <font size="6" face="Arial"> <asp:CheckBox ID="ChB_Quimica" runat="server" Text=" Química" /></font>
                <br />
                <font size="6" face="Arial"> <asp:CheckBox ID="ChB_Otros" runat="server" Text=" Otros" /></font>
            </asp:Panel>
            <br />
      
            &nbsp;&nbsp;<p align="center"><asp:ImageButton ID="ImgBTN_EnviarForm" runat="server" Height="102px" ImageUrl="~/Boton, enviar formulario.png" Width="407px" /></p>
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
        </div>
    <div align="center">
            <asp:Button ID="BTN_Volver" runat="server" BackColor="#CC3300" Font-Names="Comic Sans MS" Font-Size="20pt" Height="55px" Text="Volver" Width="226px" />
    </div>
    </form>
    </body>
</html>
