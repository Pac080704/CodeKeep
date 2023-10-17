﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RecuperarCuenta.aspx.cs" Inherits="CodeKeep.RecuperarCuenta" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Recuperación</title>
    <link href="Style.css" rel="stylesheet" type="text/css" />
    <link href="stylemenu.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <!--MARGEN SUPERIOR-->
    <div  class="margsup">
        <!--IMAGEN LOGO-->
        <div class="img1"></div>
        <!--ESTO ES PARA EL DROP-DOWN MENÚ-->
        <div class="contmenu">
            <div class="menu">
                <button class="menubtn">MENÚ</button>
                <div class="contenidomenu">
                    <a href="HomePage.html">Página de Inicio</a>
                    <a href="InicioSesion.aspx">Inicio de sesión</a> <!--falta poner las referencias-->
                </div>
            </div>
        </div>
        <!--ESTO ES PARA EL DROP-DOWN AYUDA-->
        <div class="contayuda">
            <div class="ayuda">
                <button class="ayudabtn">AYUDA</button>
                <div class="contenidoayuda">
                    <a href="#">Contacto</a> <!--falta poner las referencias-->
                    <a href="#">Tutorial</a>
                </div>
            </div>
        </div>
        <!--TÍTULO-->
        <a class="titu">CodeKeep</a>
    </div>

    <!--FORM-->
    <form class="form1" id="form1" runat="server">
        <div class="adform1">
            
            <br />
            <asp:Label ID="Label1" runat="server" ForeColor="White" Text="Recuperación de Contraseña"></asp:Label>
            <br />
            <br />
&nbsp;<asp:Label ID="Label2" runat="server" ForeColor="White" Text="Correo:"></asp:Label>
            <br />
            <asp:TextBox ID="TextBox1" runat="server" BackColor="Silver" ForeColor="SteelBlue" Height="35px" Width="195px" Font-Size="17px"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="Button1" runat="server" BackColor="Silver" ForeColor="SteelBlue" Height="41px" Text="Ingresar" Width="131px" Font-Size="17px" Font-Bold="true" OnClick="Button1_Click"/>
            <br />
            <asp:Label ID="Label3" runat="server" ForeColor="White" Text="Aquí va el hint"></asp:Label>
            <br />
            <asp:TextBox ID="TextBox2" runat="server" BackColor="Silver" ForeColor="SteelBlue" Height="35px" Width="182px" Font-Size="17px" TextMode="Password"></asp:TextBox>

            <br />
            <br />
            <br />
            <asp:Button ID="Button2" runat="server" BackColor="Silver" ForeColor="SteelBlue" Height="41px" OnClick="Button2_Click" Text="Recuperar" Width="131px" />
            <asp:Button ID="Button3" runat="server" BackColor="Silver" ForeColor="SteelBlue" Height="41px" OnClick="Button3_Click" Text="Nueva Contraseña" Width="150px" />
            <br />
            <br />
            <br />

            <asp:Label ID="Label4" runat="server" ForeColor="White"></asp:Label>
        </div>
    </form>

    <!--MARGEN INFERIOR-->
    <div class="marginf"></div>
</body>
</html>
