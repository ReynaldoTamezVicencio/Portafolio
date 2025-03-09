<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="Multivista.aspx.vb" Inherits="Multivista.Multivista" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body background="FondoCelesteCian.jpg">
    <form id="form1" runat="server">
        <div>
            <asp:MultiView ID="MultiView1" runat="server" ActiveViewIndex="0">
                <asp:View ID="View_DatosPersonales" runat="server">
                    <asp:Label ID="Label1" runat="server" Font-Names="Georgia" Font-Size="25pt" Text="DATOS PERSONALES" Font-Bold="True"></asp:Label>
                    <br />
                    <br />
                    <br />
                    <asp:Label ID="Label2" runat="server" Font-Names="Arial" Font-Size="18pt" Text="NOMBRE:"></asp:Label>
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:TextBox ID="TB_Nombre" runat="server" Height="28px" Width="322px" Font-Size="16pt"></asp:TextBox>
                    &nbsp;&nbsp;
                    <asp:RequiredFieldValidator ID="Validator_Nombre" runat="server" ControlToValidate="TB_Nombre" ErrorMessage="Favor de colocar el nombre"
                     Font-Names="Arial" Font-Size="15pt" ForeColor="#990000"></asp:RequiredFieldValidator>
                    <br />
                    <br />
                    <asp:Label ID="Label3" runat="server" Font-Names="Arial" Font-Size="18pt" Text="APELLIDOS:"></asp:Label>
                    &nbsp;&nbsp;
                    <asp:TextBox ID="TB_Apellidos" runat="server" Height="29px" Width="322px" Font-Size="16pt"></asp:TextBox>
                    &nbsp;&nbsp;
                    <asp:RequiredFieldValidator ID="Validator_Nombre0" runat="server" ControlToValidate="TB_Apellidos" 
                        ErrorMessage="Favor de colocar apellidos" Font-Names="Arial" Font-Size="15pt" ForeColor="#990000"></asp:RequiredFieldValidator>
                    <br />
                    <br />
                    <asp:Label ID="Label4" runat="server" Font-Names="Arial" Font-Size="18pt" Text="EDAD:"></asp:Label>
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:TextBox ID="TB_Edad" runat="server" Height="32px" Width="319px" Font-Size="16pt"></asp:TextBox>
                    &nbsp;&nbsp;
                    <asp:RequiredFieldValidator ID="Validator_Nombre1" runat="server" ControlToValidate="TB_Edad" ErrorMessage="Favor de colocar edad" 
                        Font-Names="Arial" Font-Size="15pt" ForeColor="#990000"></asp:RequiredFieldValidator>
                    <br />
                    <br />
                    <asp:Label ID="Label5" runat="server" Font-Names="Arial" Font-Size="18pt" Text="GÉNERO:"></asp:Label>
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <br />
                    <asp:RadioButtonList ID="R_BTN_L_Genero" runat="server" Font-Names="Arial" Font-Size="18pt" RepeatDirection="Horizontal" 
                        ValidationGroup="Genero" Width="274px">
                        <asp:ListItem>Masculino</asp:ListItem>
                        <asp:ListItem>Femenino</asp:ListItem>
                    </asp:RadioButtonList>
                    &nbsp;<br />
                    <asp:RequiredFieldValidator ID="Validator_Nombre2" runat="server" ControlToValidate="R_BTN_L_Genero" 
                        ErrorMessage="Favor de colocar genero" Font-Names="Arial" Font-Size="15pt" ForeColor="#990000"></asp:RequiredFieldValidator>
                    <br />
                    <br />
                    <br />
                    <asp:Button ID="BTN_ContinuarViewDatosAcademicos" runat="server" BackColor="#009933" Font-Names="Arial" Font-Size="30pt" Height="63px" 
                        Text="Continuar &gt;&gt;" Width="344px" />
                </asp:View>
                <asp:View ID="View_DatosAcademicos" runat="server">

                    <asp:Label ID="Label6" runat="server" Font-Bold="True" Font-Names="Georgia" Font-Size="25pt" Text="DATOS ACADEMICOS"></asp:Label>
                    <br />
                    <br />
                    <br />
                    <asp:Label ID="Label7" runat="server" Font-Names="Arial" Font-Size="18pt" Text="ESTUDIOS REALIZADOS:"></asp:Label>
                    &nbsp;&nbsp;
                    <asp:DropDownList ID="DDL_EstudiosRealizados" runat="server" Font-Names="Arial" Font-Size="18pt" Height="35px" Width="184px">
                        <asp:ListItem>Seleccionar...</asp:ListItem>
                        <asp:ListItem>Secundaria Completa</asp:ListItem>
                        <asp:ListItem>Preparatoria</asp:ListItem>
                        <asp:ListItem>Estudios Universitarios</asp:ListItem>
                        <asp:ListItem>Posgrado</asp:ListItem>
                        <asp:ListItem>Doctorado</asp:ListItem>
                    </asp:DropDownList>
                    &nbsp;&nbsp;
                    <br />
                    <br />
                    <asp:Label ID="Label8" runat="server" Font-Names="Arial" Font-Size="18pt" Text="CONDICIÓN:"></asp:Label>
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:DropDownList ID="DDL_Condicion" runat="server" Font-Names="Arial" Font-Size="18pt" Height="35px" Width="184px">
                        <asp:ListItem>Seleccionar...</asp:ListItem>
                        <asp:ListItem>Finalizados</asp:ListItem>
                        <asp:ListItem>Sin Concluir</asp:ListItem>
                        <asp:ListItem>Cursando</asp:ListItem>
                    </asp:DropDownList>
                    <br />
                    <br />
                    <asp:Button ID="BTN_VolverViewDatosPersonales" runat="server" BackColor="#009933" Font-Names="Arial" Font-Size="30pt" 
                        Height="63px" Text="&lt;&lt; Volver " Width="344px" />
                    &nbsp;&nbsp;&nbsp;
                    <asp:Button ID="BTN_ContinuarViewVistaPrevia" runat="server" BackColor="#009933" Font-Names="Arial" Font-Size="30pt" 
                        Height="63px" Text="Continuar &gt;&gt;" Width="344px" />

                </asp:View>
                 
                <asp:View ID="View_VistaPrevia" runat="server">

                     <asp:Label ID="Label9" runat="server" Font-Bold="True" Font-Names="Georgia" Font-Size="25pt" Text="VISTA PREVIA"></asp:Label>
                     <br />
                     <br />
                     <asp:Label ID="Label10" runat="server" Font-Bold="True" Font-Names="Georgia" Font-Size="20pt" Text="DATOS PERSONALES"></asp:Label>
                     <br />
                     <asp:Label ID="Label11" runat="server" Font-Names="Arial" Font-Size="18pt" Text="NOMBRE:"></asp:Label>
                     &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                     <asp:Label ID="LBL_Nombre" runat="server" Font-Names="Arial" Font-Size="18pt" Text="LBL_Nombre"></asp:Label>
                     <br />
                     <asp:Label ID="Label12" runat="server" Font-Names="Arial" Font-Size="18pt" Text="APELLIDOS:"></asp:Label>
                     &nbsp;&nbsp;&nbsp;
                     <asp:Label ID="LBL_Apellidos" runat="server" Font-Names="Arial" Font-Size="18pt" Text="LBL_Apellidos"></asp:Label>
                     <br />
                     <asp:Label ID="Label13" runat="server" Font-Names="Arial" Font-Size="18pt" Text="EDAD:"></asp:Label>
                     &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                     <asp:Label ID="LBL_Edad" runat="server" Font-Names="Arial" Font-Size="18pt" Text="LBL_Edad"></asp:Label>
                     <br />
                     <asp:Label ID="Label14" runat="server" Font-Names="Arial" Font-Size="18pt" Text="GÉNERO:"></asp:Label>
                     &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                     <asp:Label ID="LBL_Genero" runat="server" Font-Names="Arial" Font-Size="18pt" Text="LBL_Genero"></asp:Label>
                     <br />
                     <br />
                     <asp:Label ID="Label15" runat="server" Font-Bold="True" Font-Names="Georgia" Font-Size="20pt" Text="DATOS ACADEMICOS"></asp:Label>
                     <br />
                     <asp:Label ID="Label16" runat="server" Font-Names="Arial" Font-Size="18pt" Text="ESTUDIOS REALIZADOS:"></asp:Label>
                     &nbsp;&nbsp;&nbsp;
                     <asp:Label ID="LBL_EstudiosRealizados" runat="server" Font-Names="Arial" Font-Size="18pt" Text="LBL_EstudiosRealizados"></asp:Label>
                     <br />
                     <asp:Label ID="Label17" runat="server" Font-Names="Arial" Font-Size="18pt" Text="CONDICIÓN:"></asp:Label>
                     &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                     <asp:Label ID="LBL_Condicion" runat="server" Font-Names="Arial" Font-Size="18pt" Text="LBL_Condicion"></asp:Label>
                     <br />
                     <br />
                     <asp:Button ID="BTN_VolverViewDatosAcademicos" runat="server" BackColor="#009933" Font-Names="Arial" Font-Size="30pt" Height="63px" 
                         Text="&lt;&lt; Volver " Width="344px" />
                     &nbsp;&nbsp;&nbsp;
                     <asp:Button ID="BTN_ConfirmarDatos" runat="server" BackColor="#009933" Font-Names="Arial" Font-Size="30pt" Height="63px" 
                         Text="Confirmar Datos " Width="344px" />

                </asp:View>
            </asp:MultiView>
        </div>
    </form>
</body>
</html>
