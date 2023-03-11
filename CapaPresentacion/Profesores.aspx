<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Profesores.aspx.cs" Inherits="CapaPresentacion.Profesores" %>

<%@ Register assembly="Microsoft.ReportViewer.WebForms" namespace="Microsoft.Reporting.WebForms" tagprefix="rsweb" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style5 {
            width: 54px;
        }
        .auto-style8 {
            width: 29px;
        }
        .auto-style9 {
            width: 13px;
        }
        .auto-style10 {
            width: 31px;
        }
        .auto-style11 {
            width: 5px;
        }
        .auto-style12 {
            width: 19px;
        }
        .auto-style13 {
            width: 100%;
            margin-left: 0px;
            margin-right: 0px;
        }
        .auto-style14 {
            width: 52px;
        }
        .auto-style15 {
            width: 54px;
            height: 23px;
        }
        .auto-style16 {
            width: 52px;
            height: 23px;
        }
        .auto-style17 {
            width: 13px;
            height: 23px;
        }
        .auto-style18 {
            width: 29px;
            height: 23px;
        }
        .auto-style19 {
            width: 19px;
            height: 23px;
        }
        .auto-style20 {
            width: 5px;
            height: 23px;
        }
        .auto-style21 {
            width: 31px;
            height: 23px;
        }
        .auto-style22 {
            width: 54px;
            height: 26px;
        }
        .auto-style23 {
            width: 52px;
            height: 26px;
        }
        .auto-style24 {
            width: 13px;
            height: 26px;
        }
        .auto-style25 {
            width: 29px;
            height: 26px;
        }
        .auto-style26 {
            width: 19px;
            height: 26px;
        }
        .auto-style27 {
            width: 5px;
            height: 26px;
        }
        .auto-style28 {
            width: 31px;
            height: 26px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server" visible="True">
        <div>
        </div>
        <table id="Table2" class="auto-style13">
            <tr>
                <td class="auto-style5">Hora/Dia</td>
                <td id="Lunes" class="auto-style14">Lunes</td>
                <td id="Martes" class="auto-style9">Martes</td>
                <td id="Miercoles" class="auto-style8">Miercoles</td>
                <td id="Jueves" class="auto-style12">Jueves</td>
                <td id="viernes" class="auto-style11">Viernes</td>
                <td id="Sabado" class="auto-style10">Sabado</td>
            </tr>
            <tr>
                <td id="7&gt;" class="auto-style5">7:00</td>
                <td class="auto-style14">
                    <asp:Button ID="Button1" runat="server" BackColor="Silver" BorderStyle="None" OnClick="Button1_Click" Width="146px" />
                </td>
                <td class="auto-style9">
                    <asp:Button ID="Button17" runat="server" BackColor="Silver" BorderStyle="None" OnClick="Button17_Click" Width="146px" />
                </td>
                <td class="auto-style8">
                    <asp:Button ID="Button33" runat="server" BackColor="Silver" BorderStyle="None" OnClick="Button33_Click" Width="146px" />
                </td>
                <td class="auto-style12">
                    <asp:Button ID="Button49" runat="server" BackColor="Silver" BorderStyle="None" OnClick="Button12_Click" Width="146px" />
                </td>
                <td class="auto-style11">
                    <asp:Button ID="Button65" runat="server" BackColor="Silver" BorderStyle="None" OnClick="Button65_Click" Width="146px" />
                </td>
                <td class="auto-style10">
                    <asp:Button ID="Button81" runat="server" BackColor="Silver" BorderStyle="None" OnClick="Button81_Click" Width="146px" />
                </td>
            </tr>
            <tr>
                <td class="auto-style5">8:00</td>
                <td class="auto-style14">
                    <asp:Button ID="Button2" runat="server" BackColor="Silver" BorderStyle="None" OnClick="Button2_Click" Width="146px" />
                </td>
                <td class="auto-style9">
                    <asp:Button ID="Button18" runat="server" BackColor="Silver" BorderStyle="None" OnClick="Button18_Click" Width="146px" />
                </td>
                <td class="auto-style8">
                    <asp:Button ID="Button34" runat="server" BackColor="Silver" BorderStyle="None" OnClick="Button34_Click" Width="146px" />
                </td>
                <td class="auto-style12">
                    <asp:Button ID="Button50" runat="server" BackColor="Silver" BorderStyle="None" OnClick="Button50_Click" Width="146px" />
                </td>
                <td class="auto-style11">
                    <asp:Button ID="Button66" runat="server" BackColor="Silver" BorderStyle="None" OnClick="Button66_Click" Width="146px" />
                </td>
                <td class="auto-style10">
                    <asp:Button ID="Button82" runat="server" BackColor="Silver" BorderStyle="None" OnClick="Button82_Click" Width="146px" />
                </td>
            </tr>
            <tr>
                <td class="auto-style5">9:00</td>
                <td class="auto-style14">
                    <asp:Button ID="Button3" runat="server" BackColor="Silver" BorderStyle="None" OnClick="Button3_Click" Width="146px" />
                </td>
                <td class="auto-style9">
                    <asp:Button ID="Button19" runat="server" BackColor="Silver" BorderStyle="None" OnClick="Button19_Click" Width="146px" />
                </td>
                <td class="auto-style8">
                    <asp:Button ID="Button35" runat="server" BackColor="Silver" BorderStyle="None" OnClick="Button35_Click" Width="146px" />
                </td>
                <td class="auto-style12">
                    <asp:Button ID="Button51" runat="server" BackColor="Silver" BorderStyle="None" OnClick="Button51_Click" Width="146px" />
                </td>
                <td class="auto-style11">
                    <asp:Button ID="Button67" runat="server" BackColor="Silver" BorderStyle="None" OnClick="Button67_Click" Width="146px" />
                </td>
                <td class="auto-style10">
                    <asp:Button ID="Button83" runat="server" BackColor="Silver" BorderStyle="None" OnClick="Button83_Click" Width="146px" />
                </td>
            </tr>
            <tr>
                <td class="auto-style5">10:00</td>
                <td class="auto-style14">
                    <asp:Button ID="Button4" runat="server" BackColor="Silver" BorderStyle="None" OnClick="Button4_Click" Width="146px" />
                </td>
                <td class="auto-style9">
                    <asp:Button ID="Button20" runat="server" BackColor="Silver" BorderStyle="None" OnClick="Button20_Click" Width="146px" />
                </td>
                <td class="auto-style8">
                    <asp:Button ID="Button36" runat="server" BackColor="Silver" BorderStyle="None" OnClick="Button36_Click" Width="146px" />
                </td>
                <td class="auto-style12">
                    <asp:Button ID="Button52" runat="server" BackColor="Silver" BorderStyle="None" OnClick="Button52_Click" Width="146px" />
                </td>
                <td class="auto-style11">
                    <asp:Button ID="Button68" runat="server" BackColor="Silver" BorderStyle="None" OnClick="Button68_Click" Width="146px" />
                </td>
                <td class="auto-style10">
                    <asp:Button ID="Button84" runat="server" BackColor="Silver" BorderStyle="None" OnClick="Button84_Click" Width="146px" />
                </td>
            </tr>
            <tr>
                <td class="auto-style5">11:00</td>
                <td class="auto-style14">
                    <asp:Button ID="Button5" runat="server" BackColor="Silver" BorderStyle="None" OnClick="Button5_Click" Width="146px" />
                </td>
                <td class="auto-style9">
                    <asp:Button ID="Button21" runat="server" BackColor="Silver" BorderStyle="None" OnClick="Button21_Click" Width="146px" />
                </td>
                <td class="auto-style8">
                    <asp:Button ID="Button37" runat="server" BackColor="Silver" BorderStyle="None" OnClick="Button37_Click" Width="146px" />
                </td>
                <td class="auto-style12">
                    <asp:Button ID="Button53" runat="server" BackColor="Silver" BorderStyle="None" OnClick="Button53_Click" Width="146px" />
                </td>
                <td class="auto-style11">
                    <asp:Button ID="Button69" runat="server" BackColor="Silver" BorderStyle="None" OnClick="Button69_Click" Width="146px" />
                </td>
                <td class="auto-style10">
                    <asp:Button ID="Button85" runat="server" BackColor="Silver" BorderStyle="None" OnClick="Button85_Click" Width="146px" />
                </td>
            </tr>
            <tr>
                <td class="auto-style5">12:00</td>
                <td class="auto-style14">
                    <asp:Button ID="Button6" runat="server" BackColor="Silver" BorderStyle="None" OnClick="Button6_Click" Width="146px" />
                </td>
                <td class="auto-style9">
                    <asp:Button ID="Button22" runat="server" BackColor="Silver" BorderStyle="None" OnClick="Button22_Click" Width="146px" />
                </td>
                <td class="auto-style8">
                    <asp:Button ID="Button38" runat="server" BackColor="Silver" BorderStyle="None" OnClick="Button38_Click" Width="146px" />
                </td>
                <td class="auto-style12">
                    <asp:Button ID="Button54" runat="server" BackColor="Silver" BorderStyle="None" OnClick="Button54_Click" Width="146px" />
                </td>
                <td class="auto-style11">
                    <asp:Button ID="Button70" runat="server" BackColor="Silver" BorderStyle="None" OnClick="Button70_Click" Width="146px" />
                </td>
                <td class="auto-style10">
                    <asp:Button ID="Button86" runat="server" BackColor="Silver" BorderStyle="None" OnClick="Button86_Click" Width="146px" />
                </td>
            </tr>
            <tr>
                <td class="auto-style15">13:00</td>
                <td class="auto-style16">
                    <asp:Button ID="Button7" runat="server" BackColor="Silver" BorderStyle="None" OnClick="Button7_Click" Width="146px" />
                </td>
                <td class="auto-style17">
                    <asp:Button ID="Button23" runat="server" BackColor="Silver" BorderStyle="None" OnClick="Button23_Click" Width="146px" />
                </td>
                <td class="auto-style18">
                    <asp:Button ID="Button39" runat="server" BackColor="Silver" BorderStyle="None" OnClick="Button39_Click" Width="146px" />
                </td>
                <td class="auto-style19">
                    <asp:Button ID="Button55" runat="server" BackColor="Silver" BorderStyle="None" OnClick="Button55_Click" Width="146px" />
                </td>
                <td class="auto-style20">
                    <asp:Button ID="Button71" runat="server" BackColor="Silver" BorderStyle="None" OnClick="Button71_Click" Width="146px" />
                </td>
                <td class="auto-style21">
                    <asp:Button ID="Button87" runat="server" BackColor="Silver" BorderStyle="None" OnClick="Button87_Click" Width="146px" />
                </td>
            </tr>
            <tr>
                <td class="auto-style5">14:00</td>
                <td class="auto-style14">
                    <asp:Button ID="Button8" runat="server" BackColor="Silver" BorderStyle="None" OnClick="Button8_Click" Width="146px" />
                </td>
                <td class="auto-style9">
                    <asp:Button ID="Button24" runat="server" BackColor="Silver" BorderStyle="None" OnClick="Button24_Click" Width="146px" />
                </td>
                <td class="auto-style8">
                    <asp:Button ID="Button40" runat="server" BackColor="Silver" BorderStyle="None" OnClick="Button40_Click" Width="146px" />
                </td>
                <td class="auto-style12">
                    <asp:Button ID="Button56" runat="server" BackColor="Silver" BorderStyle="None" OnClick="Button56_Click" Width="146px" />
                </td>
                <td class="auto-style11">
                    <asp:Button ID="Button72" runat="server" BackColor="Silver" BorderStyle="None" OnClick="Button72_Click" Width="146px" />
                </td>
                <td class="auto-style10">
                    <asp:Button ID="Button88" runat="server" BackColor="Silver" BorderStyle="None" OnClick="Button88_Click" Width="146px" />
                </td>
            </tr>
            <tr>
                <td class="auto-style22">15:00</td>
                <td class="auto-style23">
                    <asp:Button ID="Button9" runat="server" BackColor="Silver" BorderStyle="None" OnClick="Button9_Click" Width="146px" />
                </td>
                <td class="auto-style24">
                    <asp:Button ID="Button25" runat="server" BackColor="Silver" BorderStyle="None" OnClick="Button25_Click" Width="146px" />
                </td>
                <td class="auto-style25">
                    <asp:Button ID="Button41" runat="server" BackColor="Silver" BorderStyle="None" OnClick="Button41_Click" Width="146px" />
                </td>
                <td class="auto-style26">
                    <asp:Button ID="Button57" runat="server" BackColor="Silver" BorderStyle="None" OnClick="Button57_Click" Width="146px" />
                </td>
                <td class="auto-style27">
                    <asp:Button ID="Button73" runat="server" BackColor="Silver" BorderStyle="None" OnClick="Button73_Click" Width="146px" />
                </td>
                <td class="auto-style28">
                    <asp:Button ID="Button89" runat="server" BackColor="Silver" BorderStyle="None" OnClick="Button89_Click" Width="146px" />
                </td>
            </tr>
            <tr>
                <td class="auto-style5">16:00</td>
                <td class="auto-style14">
                    <asp:Button ID="Button10" runat="server" BackColor="Silver" BorderStyle="None" OnClick="Button10_Click" Width="146px" />
                </td>
                <td class="auto-style9">
                    <asp:Button ID="Button26" runat="server" BackColor="Silver" BorderStyle="None" OnClick="Button26_Click" Width="146px" />
                </td>
                <td class="auto-style8">
                    <asp:Button ID="Button42" runat="server" BackColor="Silver" BorderStyle="None" OnClick="Button42_Click" Width="146px" />
                </td>
                <td class="auto-style12">
                    <asp:Button ID="Button58" runat="server" BackColor="Silver" BorderStyle="None" OnClick="Button58_Click" Width="146px" />
                </td>
                <td class="auto-style11">
                    <asp:Button ID="Button74" runat="server" BackColor="Silver" BorderStyle="None" OnClick="Button74_Click" Width="146px" />
                </td>
                <td class="auto-style10">
                    <asp:Button ID="Button90" runat="server" BackColor="Silver" BorderStyle="None" OnClick="Button90_Click" Width="146px" />
                </td>
            </tr>
            <tr>
                <td class="auto-style5">17:00</td>
                <td class="auto-style14">
                    <asp:Button ID="Button11" runat="server" BackColor="Silver" BorderStyle="None" OnClick="Button11_Click" Width="146px" />
                </td>
                <td class="auto-style9">
                    <asp:Button ID="Button27" runat="server" BackColor="Silver" BorderStyle="None" OnClick="Button27_Click" Width="146px" />
                </td>
                <td class="auto-style8">
                    <asp:Button ID="Button43" runat="server" BackColor="Silver" BorderStyle="None" OnClick="Button43_Click" Width="146px" />
                </td>
                <td class="auto-style12">
                    <asp:Button ID="Button59" runat="server" BackColor="Silver" BorderStyle="None" OnClick="Button59_Click" Width="146px" />
                </td>
                <td class="auto-style11">
                    <asp:Button ID="Button75" runat="server" BackColor="Silver" BorderStyle="None" OnClick="Button75_Click" Width="146px" />
                </td>
                <td class="auto-style10">
                    <asp:Button ID="Button91" runat="server" BackColor="Silver" BorderStyle="None" OnClick="Button91_Click" Width="146px" />
                </td>
            </tr>
            <tr>
                <td class="auto-style5">18:00</td>
                <td class="auto-style14">
                    <asp:Button ID="Button12" runat="server" BackColor="Silver" BorderStyle="None" OnClick="Button12_Click" Width="146px" />
                </td>
                <td class="auto-style9">
                    <asp:Button ID="Button28" runat="server" BackColor="Silver" BorderStyle="None" OnClick="Button28_Click" Width="146px" />
                </td>
                <td class="auto-style8">
                    <asp:Button ID="Button44" runat="server" BackColor="Silver" BorderStyle="None" OnClick="Button44_Click" Width="146px" />
                </td>
                <td class="auto-style12">
                    <asp:Button ID="Button60" runat="server" BackColor="Silver" BorderStyle="None" OnClick="Button60_Click" Width="146px" />
                </td>
                <td class="auto-style11">
                    <asp:Button ID="Button76" runat="server" BackColor="Silver" BorderStyle="None" OnClick="Button76_Click" Width="146px" />
                </td>
                <td class="auto-style10">
                    <asp:Button ID="Button92" runat="server" BackColor="Silver" BorderStyle="None" OnClick="Button92_Click" Width="146px" />
                </td>
            </tr>
            <tr>
                <td class="auto-style5">19:00</td>
                <td class="auto-style14">
                    <asp:Button ID="Button13" runat="server" BackColor="Silver" BorderStyle="None" OnClick="Button13_Click" Width="146px" />
                </td>
                <td class="auto-style9">
                    <asp:Button ID="Button29" runat="server" BackColor="Silver" BorderStyle="None" OnClick="Button29_Click" Width="146px" />
                </td>
                <td class="auto-style8">
                    <asp:Button ID="Button45" runat="server" BackColor="Silver" BorderStyle="None" OnClick="Button45_Click" Width="146px" />
                </td>
                <td class="auto-style12">
                    <asp:Button ID="Button61" runat="server" BackColor="Silver" BorderStyle="None" OnClick="Button61_Click" Width="146px" />
                </td>
                <td class="auto-style11">
                    <asp:Button ID="Button77" runat="server" BackColor="Silver" BorderStyle="None" OnClick="Button77_Click" Width="146px" />
                </td>
                <td class="auto-style10">
                    <asp:Button ID="Button93" runat="server" BackColor="Silver" BorderStyle="None" OnClick="Button93_Click" Width="146px" />
                </td>
            </tr>
            <tr>
                <td class="auto-style5">20:00</td>
                <td class="auto-style14">
                    <asp:Button ID="Button14" runat="server" BackColor="Silver" BorderStyle="None" OnClick="Button14_Click" Width="146px" />
                </td>
                <td class="auto-style9">
                    <asp:Button ID="Button30" runat="server" BackColor="Silver" BorderStyle="None" OnClick="Button30_Click" Width="146px" />
                </td>
                <td class="auto-style8">
                    <asp:Button ID="Button46" runat="server" BackColor="Silver" BorderStyle="None" OnClick="Button46_Click" Width="146px" />
                </td>
                <td class="auto-style12">
                    <asp:Button ID="Button62" runat="server" BackColor="Silver" BorderStyle="None" OnClick="Button62_Click" Width="146px" />
                </td>
                <td class="auto-style11">
                    <asp:Button ID="Button78" runat="server" BackColor="Silver" BorderStyle="None" OnClick="Button78_Click" Width="146px" />
                </td>
                <td class="auto-style10">
                    <asp:Button ID="Button94" runat="server" BackColor="Silver" BorderStyle="None" OnClick="Button94_Click" Width="146px" />
                </td>
            </tr>
            <tr>
                <td class="auto-style5">21:00</td>
                <td class="auto-style14">
                    <asp:Button ID="Button15" runat="server" BackColor="Silver" BorderStyle="None" OnClick="Button15_Click" Width="146px" />
                </td>
                <td class="auto-style9">
                    <asp:Button ID="Button31" runat="server" BackColor="Silver" BorderStyle="None" OnClick="Button31_Click" Width="146px" />
                </td>
                <td class="auto-style8">
                    <asp:Button ID="Button47" runat="server" BackColor="Silver" BorderStyle="None" OnClick="Button47_Click" Width="146px" />
                </td>
                <td class="auto-style12">
                    <asp:Button ID="Button63" runat="server" BackColor="Silver" BorderStyle="None" OnClick="Button63_Click" Width="146px" />
                </td>
                <td class="auto-style11">
                    <asp:Button ID="Button79" runat="server" BackColor="Silver" BorderStyle="None" OnClick="Button79_Click" Width="146px" />
                </td>
                <td class="auto-style10">
                    <asp:Button ID="Button95" runat="server" BackColor="Silver" BorderStyle="None" OnClick="Button95_Click" Width="146px" />
                </td>
            </tr>
            <tr>
                <td class="auto-style5">22:00</td>
                <td class="auto-style14">
                    <asp:Button ID="Button16" runat="server" BackColor="Silver" BorderStyle="None" OnClick="Button16_Click" Width="146px" />
                </td>
                <td class="auto-style9">
                    <asp:Button ID="Button32" runat="server" BackColor="Silver" BorderStyle="None" OnClick="Button32_Click" Width="146px" />
                </td>
                <td class="auto-style8">
                    <asp:Button ID="Button48" runat="server" BackColor="Silver" BorderStyle="None" OnClick="Button48_Click" Width="146px" />
                </td>
                <td class="auto-style12">
                    <asp:Button ID="Button64" runat="server" BackColor="Silver" BorderStyle="None" OnClick="Button64_Click" Width="146px" />
                </td>
                <td class="auto-style11">
                    <asp:Button ID="Button80" runat="server" BackColor="Silver" BorderStyle="None" OnClick="Button80_Click" Width="146px" />
                </td>
                <td class="auto-style10">
                    <asp:Button ID="Button96" runat="server" BackColor="Silver" BorderStyle="None" OnClick="Button96_Click" Width="146px" />
                </td>
            </tr>
        </table>
        <asp:Button ID="Button99" runat="server" Text="Enviar" Visible="False" OnClick="Button99_Click" />
        <asp:Button ID="Button97" runat="server" Text="Siguiente" OnClick="Button97_Click" />
        <asp:Button ID="Button98" runat="server" OnClick="Button98_Click" Text="Cancelar" />
        <br />
    </form>
</body>
</html>
