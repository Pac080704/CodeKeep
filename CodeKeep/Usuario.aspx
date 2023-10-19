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
        <!--DIV CENTRAL-->
        <div id="adformusu" runat="server" class="adformus">
            <br />
            <asp:Label ID="Label1" runat="server" ForeColor="White"></asp:Label>
            <br />
            <br />
            <asp:Label ID="Label2" runat="server" ForeColor="White" Text="¿Qué deseas realizar?"></asp:Label>
            <br />
            <br />
            <br />
            <asp:Button ID="Button1" runat="server" ForeColor="SteelBlue" Height="50px" Text="Consulta de infromación" Width="195px" BackColor="Silver" Font-Size="17px" BorderColor="SteelBlue" OnClick="Button1_Click" />
            <asp:Button ID="Button2" runat="server" ForeColor="SteelBlue" Height="50px" Text="Inserción de infromación" Width="197px" BackColor="Silver" Font-Size="17px" BorderColor="SteelBlue" OnClick="Button2_Click" />
            <br />
            <br />
        </div>
        <!--DIV PARA CONSULTA-->
        <div class="divconsul" id="consul" runat="server">
            
        </div>
        <!--DIV PARA INSERCIÓN-->
        <div class="divinser" id="inser" runat="server">

            <asp:Label ID="Label3" runat="server" Text="Inserción de datos" Font-Size="15pt" ForeColor="White"></asp:Label>
            <br />
            <br />
            <asp:Label ID="Label4" runat="server" Text="Agregar datos a: " Font-Size="15pt" ForeColor="White"></asp:Label>
            <asp:DropDownList ID="DropDownList1" runat="server" BackColor="Silver" ForeColor="SteelBlue" Height="30px" Font-Size="13pt">
            </asp:DropDownList>

        </div>
        <!--DIV BOTON CERRAR-->
        <div class="cerrar">
            <asp:Button ID="Button3" runat="server" Text="Cerrar Sesión" BackColor="DimGray" ForeColor="White" Height="50px" OnClick="Button3_Click" Width="195px" />
        </div>
    </form>
    <!--MARGEN INFERIOR-->
    <div class="marginf"></div>
</body>
</html>
