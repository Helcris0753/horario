<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="CapaPresentacion.Login" %>

<!DOCTYPE html>
<!-- FONDO DE PAGINA "bg-white" -->
<html class="bg-white" xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Acceso al Sistema de Horarios</title>
    <link href="//maxcdn.bootstrapcdn.com/bootstrap/3.2.0/css/bootstrap.min.css" rel="stylesheet" type="text/css" />
    <link href="//cdnjs.cloudflare.com/ajax/libs/font-awesome/4.1.0/css/font-awesome.min.css" rel="stylesheet" type="text/css" />
    <link href="css/AdminLTE.css" rel="stylesheet" type="text/css" />
</head>
<body class="bg-white">
    <header style="max-width: 1600px; padding: 0px 30px">
        <div style="padding-left: 30px; padding-right: 30px">
            <a href="https://intec.edu.do/">
                <img src="https://www.intec.edu.do/images/logos/logo-intec.svg" alt="Instituto Tecnológico de Santo Domingo" style="width: 150px"/>
            </a>
        </div>
    </header>
    <h1 style="margin-top: 25px; margin-bottom: 15px; font-weight: 600; text-align: center; font-size: 25px; background-color: #F5F5F5">Acceso administrativo a generación de horarios</h1>
    <div class="form-box" id="login-box">
        <form id="form1" runat="server">
            <asp:Label ID="Label1" runat="server" BackColor="#FF9797" BorderColor="#FFD2D2" CssClass="alert-info" Font-Bold="True" Font-Overline="False" Font-Size="Medium" ForeColor="Red" Text="ID/Contraseña Incorrecta" Visible="False" Width="360px"></asp:Label>
        <div class="header" style="background-color: #DB332C">Iniciar sesión</div>
            <div class="body bg-gray">
                <div class="form-group">
                    <asp:TextBox ID="txtUsuario" runat="server" CssClass="form-control" placeholder="ID"> </asp:TextBox>
                </div>
                <div class="form-group">
                    <asp:TextBox ID="txtPassword" runat="server" CssClass="form-control" placeholder="PIN/Contraseña" TextMode="Password" OnTextChanged="txtPassword_TextChanged"> </asp:TextBox>
                </div>
            </div>
            <div class="footer">
                <asp:Button ID="btnIngresar" runat="server" Text="Acceder" CssClass="btn bg-acceder btn-block text-white" OnClick="btnIngresar_Click"/>
            </div>
        </form>
    </div>
    <script src="//ajax.googleapis.com/ajax/libs/jquery/2.1.1/jquery.min.js"></script>
    <script src="//maxcdn.bootstrapcdn.com/bootstrap/3.2.0/js/bootstrap.min.js" type="text/javascript"></script>
</body>
</html>
