<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Menu.aspx.cs" Inherits="CapaPresentacion.Menu" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Menu ID="Menu1" runat="server" BackColor="Red" BorderColor="White" BorderStyle="Ridge" DynamicHorizontalOffset="2" Font-Bold="True" Font-Names="Verdana" Font-Size="0.8em" ForeColor="Black" Height="186px" OnMenuItemClick="Menu1_MenuItemClick" StaticSubMenuIndent="10px">
            <DynamicHoverStyle BackColor="White" BorderStyle="Solid" ForeColor="White" />
            <DynamicMenuItemStyle BackColor="White" BorderStyle="Solid" ForeColor="Black" HorizontalPadding="5px" VerticalPadding="2px" />
            <DynamicMenuStyle BackColor="Red" BorderColor="White" BorderStyle="Dotted" />
            <DynamicSelectedStyle BackColor="White" BorderStyle="Solid" ForeColor="White" />
            <Items>
                <asp:MenuItem Text="Inicio" Value="Inicio"></asp:MenuItem>
                <asp:MenuItem NavigateUrl="~/Profesores.aspx" Text="LLena formulario" Value="LLena formulario"></asp:MenuItem>
                <asp:MenuItem Text="Profesor" Value="Profesor">
                    <asp:MenuItem Text="Horario" Value="Horario" NavigateUrl="~/Vista_Horario.aspx"></asp:MenuItem>
                    <asp:MenuItem NavigateUrl="~/Materia.aspx" Text="Materia" Value="Materia"></asp:MenuItem>
                </asp:MenuItem>
            </Items>
            <StaticHoverStyle BackColor="#7C6F57" ForeColor="White" />
            <StaticMenuItemStyle HorizontalPadding="5px" VerticalPadding="2px" />
            <StaticSelectedStyle BackColor="#5D7B9D" />
        </asp:Menu>
    </form>
</body>
</html>
