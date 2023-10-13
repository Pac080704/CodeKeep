<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Usuario.aspx.cs" Inherits="CodeKeep.Usuario" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Vista Usuario</title>
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
    <form class="formus" id="form1" runat="server">
        <div class="adformus">
            <br />
            <asp:Label ID="Label1" runat="server" ForeColor="White"></asp:Label>
            <br />
            <br />
            <asp:Label ID="Label2" runat="server" ForeColor="White" Text="¿Qué deseas consultar?"></asp:Label>
            <br />
            <br />
            <br />
            <asp:Button ID="Button1" runat="server" ForeColor="SteelBlue" Height="50px" Text="Consulta de infromación" Width="195px" BackColor="Silver" Font-Size="17px" BorderColor="SteelBlue" OnClick="Button1_Click" />
            <asp:Button ID="Button2" runat="server" ForeColor="SteelBlue" Height="50px" Text="Inserción de infromación" Width="197px" BackColor="Silver" Font-Size="17px" BorderColor="SteelBlue" />
            <br />
            <br />
        </div>
    </form>
    <!--MARGEN INFERIOR-->
    <div class="marginf"></div>
</body>
</html>
