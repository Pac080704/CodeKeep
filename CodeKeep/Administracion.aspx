﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Administracion.aspx.cs" Inherits="CodeKeep.Administracion" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Administración</title>
    <link href="Style.css" rel="stylesheet" type="text/css" />
    <link href="stylemenu.css" rel="stylesheet" type="text/css" />

</head>
<body>
    <div  class="margsup">
        <!--IMAGEN LOGO-->
        <div class="img1"></div>
        <!--ESTO ES PARA EL DROP-DOWN MENÚ-->
        <div class="contmenu">
            <div class="menu">
                <button class="menubtn">MENÚ</button>
                <div class="contenidomenu">
                    <a href="HomePage.html">Página de Inicio</a>
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
    <form class="formad" id="form1" runat="server">
        <div class="adadmin">
            Hola admin
        </div>
        <div class="cerrar">
            <asp:Button ID="Button1" runat="server" Text="Cerrar Sesión" BackColor="DimGray" ForeColor="White" Height="50px" Width="195px" />
        </div>
    </form>
    <!--MARGEN INFERIOR-->
    <div class="marginf"></div>
</body>
</html>
