<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="FormularioIdiomasDatos.aspx.vb" Inherits="PIA.FormularioIdiomasDatos" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body style="height: 494px" background="FondoCeleste.jpg">
    <form id="form1" runat="server" method="post">
        <div style="height: 994px">
            <div align="center">
            <asp:Label ID="Label5" runat="server" Font-Names="Comic Sans MS" Font-Size="30pt" ForeColor="Black" Text="Registro de cursos de idiomas"></asp:Label>
            </div>
            <br />
            <asp:Label ID="Label12" runat="server" Font-Names="Comic Sans MS" Font-Size="18pt" Text="Registra tus datos personales"></asp:Label>
            <br />
            <br />
            <asp:Label ID="Label1" runat="server" Font-Names="Comic Sans MS" Font-Size="18pt" ForeColor="Black" Text="Nombre"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="TB_Nombre" runat="server" Height="29px" style="margin-left: 0px" Width="238px" Font-Size="16pt"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label ID="Label2" runat="server" Font-Names="Comic Sans MS" Font-Size="18pt" Text="Apellidos"></asp:Label>
            <asp:TextBox ID="TB_Apellidos" runat="server" Height="28px" style="margin-left: 17px" Width="255px" Font-Size="16pt"></asp:TextBox>
            <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:RequiredFieldValidator ID="Valid_Nombre" runat="server" ControlToValidate="TB_Nombre" 
                ErrorMessage="Porfavor coloque su nombre" Font-Names="Comic Sans MS" Font-Size="14pt" ForeColor="#CC0000"></asp:RequiredFieldValidator>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:RequiredFieldValidator ID="Valid_Apellidos" runat="server" ControlToValidate="TB_Apellidos" 
                ErrorMessage="Porfavor coloque sus apellidos " Font-Names="Comic Sans MS" Font-Size="14pt" ForeColor="#CC0000"></asp:RequiredFieldValidator>
            <br />
            <br />
            <br />
            <asp:Label ID="Label3" runat="server" Font-Names="Comic Sans MS" Font-Size="18pt" ForeColor="Black" Text="Teléfono"></asp:Label>
&nbsp;&nbsp;
            <asp:TextBox ID="TB_Teléfono" runat="server" Height="29px" style="margin-left: 0px" Width="238px" Font-Size="16pt"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label ID="Label4" runat="server" Font-Names="Comic Sans MS" Font-Size="18pt" Text="Email"></asp:Label>
            <asp:TextBox ID="TB_Email" runat="server" Height="28px" style="margin-left: 17px" Width="255px" Font-Size="16pt"></asp:TextBox>
            <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:RequiredFieldValidator ID="Valid_Telefono" runat="server" ControlToValidate="TB_Teléfono" 
                ErrorMessage="Porfavor coloque su teléfono" Font-Names="Comic Sans MS" Font-Size="14pt" ForeColor="#CC0000"></asp:RequiredFieldValidator>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:RequiredFieldValidator ID="Valid_Email" runat="server" ControlToValidate="TB_Email" 
                ErrorMessage="Porfavor coloque su Email" Font-Names="Comic Sans MS" Font-Size="14pt" ForeColor="#CC0000"></asp:RequiredFieldValidator>
            <br />
            <br />
            <asp:Label ID="Label11" runat="server" Font-Names="Comic Sans MS" Font-Size="18pt" ForeColor="Black" Text="Dirección"></asp:Label>
&nbsp;
            <asp:TextBox ID="TB_Direccion" runat="server" Height="29px" style="margin-left: 0px" Width="238px" Font-Size="16pt"></asp:TextBox>
&nbsp;
            <asp:RequiredFieldValidator ID="Valid_Direccion" runat="server" ControlToValidate="TB_Direccion" 
                ErrorMessage="Porfavor coloque su direccion" Font-Names="Comic Sans MS" Font-Size="14pt" ForeColor="#CC0000"></asp:RequiredFieldValidator>
            <br />
            <br />
            <br />
            <asp:Label ID="Label7" runat="server" Font-Names="Comic Sans MS" Font-Size="18pt" ForeColor="Black" Text="Fecha de nacimiento"></asp:Label>
&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="TB_FechaNaci" runat="server" Height="29px" Width="241px" Font-Size="16pt"></asp:TextBox>
&nbsp;
            <asp:RequiredFieldValidator ID="Valid_Fecha" runat="server" ControlToValidate="TB_FechaNaci" 
                ErrorMessage="Porfavor coloque su  fecha de nacimiento" Font-Names="Comic Sans MS" Font-Size="14pt" ForeColor="#CC0000"></asp:RequiredFieldValidator>
            <br />
            <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="TB_FechaNaci" 
                ErrorMessage="Formato de fecha inválido" Font-Names="Comic Sans MS" Font-Size="14pt" ForeColor="#CC0000" 
                ValidationExpression="[0-3][0-9]/[0-1][0-9]/[1-2][0-9][0-9][0-9]"></asp:RegularExpressionValidator>
            <br />
            <br />
            <br />
            <asp:Panel ID="Panel1" runat="server" Height="121px" Width="264px">
                <asp:Label ID="Label6" runat="server" Font-Names="Comic Sans MS" Font-Size="18pt" ForeColor="Black" Text="Género:"></asp:Label>
                <br />
                <asp:RadioButtonList ID="RadBTNList_Genero" runat="server" Font-Names="Comic Sans MS" Font-Size="16pt" Width="127px" ValidateRequestMode="Disabled" ValidationGroup="Genero">
                    <asp:ListItem>Masculino</asp:ListItem>
                    <asp:ListItem>Femenino</asp:ListItem>
                </asp:RadioButtonList>
                <br />
                <br />
            </asp:Panel>
            <asp:RequiredFieldValidator ID="Valid_Genero" runat="server" ControlToValidate="RadBTNList_Genero" 
                ErrorMessage="Porfavor coloque su genero" Font-Names="Comic Sans MS" Font-Size="14pt" ForeColor="#CC0000"></asp:RequiredFieldValidator>
            <br />
            <br />
&nbsp;<asp:Label ID="Label8" runat="server" Font-Names="Comic Sans MS" Font-Size="18pt" ForeColor="Black" Text="Ciudad"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:DropDownList ID="DDL_Ciudad" runat="server" BackColor="#66FFCC" Font-Names="Comic Sans MS" Font-Size="18pt" Height="50px" Width="145px">
                <asp:ListItem>Monterrey</asp:ListItem>
                <asp:ListItem>San Pedro</asp:ListItem>
                <asp:ListItem>Apodaca</asp:ListItem>
                <asp:ListItem>San Nicolás</asp:ListItem>
                <asp:ListItem>Guadalupe</asp:ListItem>
                <asp:ListItem>Santiago</asp:ListItem>
                <asp:ListItem>García</asp:ListItem>
            </asp:DropDownList>
&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label ID="Label9" runat="server" Font-Names="Comic Sans MS" Font-Size="18pt" ForeColor="Black" Text="Estado Civil"></asp:Label>
&nbsp;&nbsp;&nbsp;
            <asp:DropDownList ID="DDL_EstadoCivil" runat="server" BackColor="#66FFCC" Font-Names="Comic Sans MS" Font-Size="18pt" Height="50px" Width="145px">
                <asp:ListItem>Casado/a</asp:ListItem>
                <asp:ListItem>Divorciado/a</asp:ListItem>
                <asp:ListItem>Soltero/a</asp:ListItem>
                <asp:ListItem>Viudo/a</asp:ListItem>
            </asp:DropDownList>
            <br />
            <asp:RequiredFieldValidator ID="Valid_Ciudad" runat="server" ControlToValidate="DDL_Ciudad" 
                ErrorMessage="Porfavor coloque su ciudad" Font-Names="Comic Sans MS" Font-Size="14pt" ForeColor="#CC0000"></asp:RequiredFieldValidator>
            <br />
            <asp:RequiredFieldValidator ID="Valid_EstadoCivil" runat="server" ControlToValidate="DDL_EstadoCivil" 
                ErrorMessage="Porfavor coloque su estado civil" Font-Names="Comic Sans MS" Font-Size="14pt" ForeColor="#CC0000"></asp:RequiredFieldValidator>
            <br />
            <br />
            <br />
            <asp:Button ID="BTN_Ingresar" runat="server" BackColor="#33CC33" Font-Names="Comic Sans MS" Font-Size="16pt" Height="52px" Text="Ingresar" Width="165px" />
            <br />
            <br />
            <br /
            <br />
            <asp:Label ID="InicioTab" runat="server" Text="-" Font-Names="Comic Sans MS" Font-Size="16pt"></asp:Label>
            <asp:Label ID="InfoTab" runat="server" Text="-" Font-Names="Comic Sans MS" Font-Size="16pt"></asp:Label>
            <asp:Label ID="FinTab" runat="server" Text="-" Font-Names="Comic Sans MS" Font-Size="16pt"></asp:Label>
            <br />
            <br />
            <br />
            <div align="center">
            <asp:Button ID="BTN_Siguiente" runat="server" Font-Names="Comic Sans MS" Font-Size="30pt" Height="76px" Text="Siguiente " Width="209px" BackColor="#3399FF" />
                <br />
                <br />
                <br />
            <asp:Button ID="BTN_Volver" runat="server" BackColor="#339933" Font-Names="Comic Sans MS" Font-Size="20pt" Height="55px" Text="Volver" Width="226px" />
            </div>
            <br />
            
        </div>
    </form>
</body>
</html>
