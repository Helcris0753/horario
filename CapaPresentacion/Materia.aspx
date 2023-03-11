<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Materia.aspx.cs" Inherits="CapaPresentacion.Materia" %>

<%@ Register assembly="Microsoft.ReportViewer.WebForms" namespace="Microsoft.Reporting.WebForms" tagprefix="rsweb" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style1 {
            height: 128px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server" class="auto-style1">
        <div>
            <asp:Button ID="Button3" runat="server" OnClick="Button3_Click" Text="Mostrar Tabla de secciones" />
        </div>
        <asp:Label ID="Label1" runat="server" Text="ID del profesor"></asp:Label>
&nbsp;<asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Validar" />
        <asp:Label ID="Label5" runat="server" Text="Label" Visible="False"></asp:Label>
        <br />
        <br />
        <asp:Label ID="Label2" runat="server" Text="Materia a seleccionar" Visible="False"></asp:Label>
        <br />

        <asp:DropDownList ID="DropDownList1" runat="server" DataSourceID="SqlDataSource1" DataTextField="nombre_asignatura" DataValueField="codigo_asignatura" Visible="False" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged">
        </asp:DropDownList>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:horariosConnectionString %>" SelectCommand="SELECT codigo_asignatura, nombre_asignatura FROM horarios.asignatura order by nombre_asignatura asc"></asp:SqlDataSource>
        <br />
        <asp:Label ID="Label4" runat="server" Text="Seleccione la modalidad" Visible="False"></asp:Label>
        <br />
        <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:horariosConnectionString %>" SelectCommand="SELECT id_modalidad, nombre_modalidad FROM horarios.modalidad"></asp:SqlDataSource>
        <asp:RadioButtonList ID="RadioButtonList1" runat="server" DataSourceID="SqlDataSource2" DataTextField="nombre_modalidad" DataValueField="id_modalidad" Visible="False">
        </asp:RadioButtonList>
        <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Guardar" Visible="False" />
        <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" OldValuesParameterFormatString="original_{0}" SelectMethod="GetData" TypeName="CapaPresentacion.DataSet1TableAdapters.Ver_SeccionTableAdapter"></asp:ObjectDataSource>
        <asp:ScriptManager ID="ScriptManager1" runat="server">
        </asp:ScriptManager>
        <rsweb:ReportViewer ID="ReportViewer1" runat="server" BackColor="" ClientIDMode="AutoID" HighlightBackgroundColor="" InternalBorderColor="204, 204, 204" InternalBorderStyle="Solid" InternalBorderWidth="1px" LinkActiveColor="" LinkActiveHoverColor="" LinkDisabledColor="" PrimaryButtonBackgroundColor="" PrimaryButtonForegroundColor="" PrimaryButtonHoverBackgroundColor="" PrimaryButtonHoverForegroundColor="" SecondaryButtonBackgroundColor="" SecondaryButtonForegroundColor="" SecondaryButtonHoverBackgroundColor="" SecondaryButtonHoverForegroundColor="" SplitterBackColor="" ToolbarDividerColor="" ToolbarForegroundColor="" ToolbarForegroundDisabledColor="" ToolbarHoverBackgroundColor="" ToolbarHoverForegroundColor="" ToolBarItemBorderColor="" ToolBarItemBorderStyle="Solid" ToolBarItemBorderWidth="1px" ToolBarItemHoverBackColor="" ToolBarItemPressedBorderColor="51, 102, 153" ToolBarItemPressedBorderStyle="Solid" ToolBarItemPressedBorderWidth="1px" ToolBarItemPressedHoverBackColor="153, 187, 226" Width="1226px">
            <LocalReport ReportPath="Seccion.rdlc">
                <DataSources>
                    <rsweb:ReportDataSource DataSourceId="ObjectDataSource1" Name="DataSet1" />
                </DataSources>
            </LocalReport>
        </rsweb:ReportViewer>
        <br />
        <br />
    </form>
</body>
</html>
