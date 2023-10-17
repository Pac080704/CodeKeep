<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RegistroCuenta.aspx.cs" Inherits="CodeKeep.RegistroCuenta" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Registro</title>
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
                    <a href="InicioSesion.aspx">Inicio de sesión</a><!--falta poner las referencias-->
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
    <form class="formreg" id="form1" runat="server">
        <!--DIV TITULO-->
        <div class="titulo">

            <asp:Label ID="Label9" runat="server" ForeColor="White" Text="Nueva Cuenta"></asp:Label>

        </div>
        <!--DIV FORM DERECHO-->
        <div class="adformreg">
            <br />
            <br />
&nbsp;<asp:Label ID="Label2" runat="server" ForeColor="White" Text="Correo:"></asp:Label>
            <br />
            <asp:TextBox ID="TextBox1" runat="server" BackColor="Silver" ForeColor="SteelBlue" Height="35px" Width="182px" Font-Size="17px"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="Label3" runat="server" ForeColor="White" Text="Contraseña:"></asp:Label>
            <br />
            <asp:TextBox ID="TextBox2" runat="server" BackColor="Silver" ForeColor="SteelBlue" Height="35px" Width="182px" Font-Size="17px" TextMode="Password"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="Label4" runat="server" ForeColor="White" Text="Pregunta de Rescate:"></asp:Label>
            <br />
            
            <asp:TextBox ID="TextBox3" runat="server" BackColor="Silver" ForeColor="SteelBlue" Height="35px" Width="182px" Font-Size="17px"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="Label5" runat="server" ForeColor="White" Text="Respuesta de Rescate:"></asp:Label>
            <asp:TextBox ID="TextBox4" runat="server" BackColor="Silver" ForeColor="SteelBlue" Height="35px" Width="182px" Font-Size="17px" TextMode="Password"></asp:TextBox>
            
        </div>
        <!--DIV DE LA IZQUIERDA-->
        <div class="adformregizq">
            
            <br />
            <br />
            <asp:Label ID="Label6" runat="server" ForeColor="White" Text="Dirección:"></asp:Label>
            <br />
            <asp:TextBox ID="TextBox5" runat="server" BackColor="Silver" ForeColor="SteelBlue" Height="35px" Width="182px" Font-Size="17px"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="Label7" runat="server" ForeColor="White" Text="Nombre:"></asp:Label>
            <br />
            <asp:TextBox ID="TextBox6" runat="server" BackColor="Silver" ForeColor="SteelBlue" Height="35px" Width="182px" Font-Size="17px"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="Label8" runat="server" ForeColor="White" Text="Fecha de nacimiento:"></asp:Label> 
            <br />
            <asp:TextBox ID="TextBox7" runat="server" BackColor="Silver" ForeColor="SteelBlue" Height="35px" Width="182px" Font-Size="17px" TextMode="DateTime"></asp:TextBox>
        </div>
        <!--DIV BOTON-->
        <div class="botoncarga">
            <asp:Button ID="Button1" runat="server" BackColor="Silver" ForeColor="SteelBlue" Height="41px" Text="Crear Cuenta" Width="131px" />
        </div>
    </form>

    <!--MARGEN INFERIOR-->
    <div class="marginf"></div>
</body>
</html>
