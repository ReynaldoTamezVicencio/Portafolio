<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/DiseñoPrincipal.Master" CodeBehind="Interfaz.aspx.vb" Inherits="EQUIPO4_PIA_DSWSQL.Interfaz" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    
    <style type="text/css">
    .auto-style3 {
        height: 23px;
        width: 219px;
    }
    .auto-style2 {
        height: 23px;
    }
    .auto-style1 {
        height: 22px;
    }
    </style>
<style type="text/css">
    .auto-style3 {
        width: 728px;
    }
    .auto-style11 {
        width: 185px;
        height: 26px;
    }
    </style>
    <style type="text/css">
        .auto-style11 {
            width: 161px;
        }
        </style>
    <style type="text/css">
        .auto-style3 {
            width: 219px;
        }
    </style>

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <p>
        <div align="center">
    <asp:Label ID="Label1" runat="server" Text="Consulta, alta, baja y cambios en pedidos" CssClass="FuenteLetraNegro"></asp:Label>
</p>
<p>
    <asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="True" Height="31px" Width="189px" CssClass="FuenteLetraNegro">
        <asp:ListItem>Selecciona accion</asp:ListItem>
        <asp:ListItem>Modificar</asp:ListItem>
        <asp:ListItem>Eliminar</asp:ListItem>
        <asp:ListItem>Agregar</asp:ListItem>
        <asp:ListItem>Consultar</asp:ListItem>
        <asp:ListItem>Cambiar_Estatus</asp:ListItem>
    </asp:DropDownList>
</p>
<p>
    &nbsp;<asp:Button ID="Button1" runat="server" Text="Ejecutar" Height="39px" Width="121px" CssClass="Boton" />
</p>
<p>
    <table class="FuenteLetraNegro">
        <tr>
            <td class="auto-style11">
                <asp:Label ID="Label2" runat="server" Text="ID_Pedidos:"></asp:Label>
            </td>
            <td class="auto-style3">
                <asp:TextBox ID="TB_ID" runat="server" Width="210px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style11">
                <asp:Label ID="Label3" runat="server" Text="Nombre del Cliente:"></asp:Label>
            </td>
            <td class="auto-style3">
                <asp:TextBox ID="TB_Nombre" runat="server" Width="211px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style11">
                <asp:Label ID="Label4" runat="server" Text="Orden:"></asp:Label>
            </td>
            <td class="auto-style3">
                <asp:TextBox ID="TB_Orden" runat="server" Width="207px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style11">
                <asp:Label ID="Label5" runat="server" Text="Notas:"></asp:Label>
            </td>
            <td class="auto-style3">
                <asp:TextBox ID="TB_Notas" runat="server" Width="209px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style11">
                <asp:Label ID="Label6" runat="server" Text="Total de Pago:"></asp:Label>
            </td>
            <td class="auto-style3">
                <asp:TextBox ID="TB_TotalPago" runat="server" Width="209px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style11">
                <asp:Label ID="Label7" runat="server" Text="Envio:"></asp:Label>
            </td>
            <td class="auto-style3">
                <asp:TextBox ID="TB_Envio" runat="server" Width="207px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style11">
                <asp:Label ID="Label8" runat="server" Text="Direccion:"></asp:Label>
            </td>
            <td class="auto-style3">
                <asp:TextBox ID="TB_Direccion" runat="server" Width="206px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style11">
                <asp:Label ID="Label9" runat="server" Text="Estatus del pedido"></asp:Label>
            </td>
            <td class="auto-style3">
                <asp:TextBox ID="TB_Estatus" runat="server" Width="209px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style11">
                <asp:Label ID="Label10" runat="server" Text="Fecha"></asp:Label>
            </td>
            <td class="auto-style3">
                <asp:TextBox ID="TB_Fecha" runat="server" Width="207px"></asp:TextBox>
            </td>
        </tr>
    </table>
</p>
<p>
    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="ID_Pedido" DataSourceID="SQLDS" Visible="False" CssClass="FuenteLetraNegro">
        <Columns>
            <asp:BoundField DataField="ID_Pedido" HeaderText="ID_Pedido" InsertVisible="False" ReadOnly="True" SortExpression="ID_Pedido" />
            <asp:BoundField DataField="Nombre_Cliente" HeaderText="Nombre_Cliente" SortExpression="Nombre_Cliente" />
            <asp:BoundField DataField="Orden" HeaderText="Orden" SortExpression="Orden" />
            <asp:BoundField DataField="Notas" HeaderText="Notas" SortExpression="Notas" />
            <asp:BoundField DataField="Total_Pago" HeaderText="Total_Pago" SortExpression="Total_Pago" />
            <asp:BoundField DataField="Envio" HeaderText="Envio" SortExpression="Envio" />
            <asp:BoundField DataField="Direccion" HeaderText="Direccion" SortExpression="Direccion" />
            <asp:BoundField DataField="Estatus_del_Pedido" HeaderText="Estatus_del_Pedido" SortExpression="Estatus_del_Pedido" />
            <asp:BoundField DataField="Fecha" HeaderText="Fecha" SortExpression="Fecha" />
        </Columns>
    </asp:GridView>
</p>
<p>
    &nbsp;</p>
<p>
    <asp:SqlDataSource ID="SQLDS" runat="server" ConnectionString="<%$ ConnectionStrings:BDNegocioComidaRapidaConnectionString %>" SelectCommand="SELECT * FROM [Pedidos]"></asp:SqlDataSource>
</p>
</div>
</asp:Content>
