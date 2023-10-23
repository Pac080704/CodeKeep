<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Administracion.aspx.cs" Inherits="CodeKeep.Administracion" %>

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
            <br />
            &nbsp;<asp:Label ID="Label1" runat="server" ForeColor="White"></asp:Label>
             <br />
             <br />
             <asp:Label ID="Label2" runat="server" ForeColor="White" Text="¿Qué deseas realizar?"></asp:Label>
             <br />
             <br />
             <br />
             <asp:Button ID="Button2" runat="server" ForeColor="SteelBlue" Height="50px" Text="Eliminación de información" Width="210px" BackColor="Silver" Font-Size="17px" BorderColor="SteelBlue" OnClick="Button2_Click" />
             <asp:Button ID="Button3" runat="server" ForeColor="SteelBlue" Height="50px" Text="Inserción de infromación" Width="210px" BackColor="Silver" Font-Size="17px" BorderColor="SteelBlue" OnClick="Button3_Click" />
             <asp:Button ID="Button4" runat="server" OnClick="Button4_Click" Text="Reportes" />
             <br />
             <br />
        </div>
        <div class="cerrar">
            <asp:Button ID="Button1" runat="server" Text="Cerrar Sesión" BackColor="DimGray" ForeColor="White" Height="50px" Width="195px" OnClick="Button1_Click" />
        </div>
    </form>
    <!--MARGEN INFERIOR-->
    <div class="marginf"></div>
</body>
</html>
