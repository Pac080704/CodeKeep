using System;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CodeKeep
{
    public partial class IncioSesion : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            String query1 = " select nombre, cAdmin from Admini "
                + " where correo= ? "
                + " and contraseña= ? ";
            String nombreUsuario;
            int claveAdmin;
            int claveUsuario;
            String query2 = " select nombre, cUsuario from Cuenta "
                + " where correo= ? "
                + " and contraseña= ? ";
            OdbcConnection conexion;
            ConexionBD objetoConexionBD = new ConexionBD();
            conexion = objetoConexionBD.con;
            OdbcCommand comando1= new OdbcCommand(query1,conexion);
            OdbcCommand comando2=new OdbcCommand(query2,conexion);
            comando1.Parameters.AddWithValue("correo", TextBox1.Text);
            comando1.Parameters.AddWithValue("contraseña", TextBox2.Text);
            //Comandos
            comando2.Parameters.AddWithValue("correo", TextBox1.Text);
            comando2.Parameters.AddWithValue("contraseña", TextBox2.Text);
            //Lectores
            OdbcDataReader lector1=comando1.ExecuteReader();

            if(lector1.HasRows)
            {
                lector1.Read();
                nombreUsuario = lector1.GetString(0);
                claveAdmin = lector1.GetInt32(1);
                Session.Timeout = 10;
                Session.Add("nombre", nombreUsuario);
                Session.Add("cAdmin", claveAdmin);
                Response.Redirect("Administracion.aspx"); 
            }
            else
            {
                OdbcDataReader lector2=comando2.ExecuteReader();
                if (lector2.HasRows)
                {
                    lector2.Read();
                    nombreUsuario = lector2.GetString(0);
                    claveUsuario = lector2.GetInt32(1);
                    Session.Timeout = 10;
                    Session.Add("nombre", nombreUsuario);
                    Session.Add("cUsuario", claveUsuario);
                    Response.Redirect("Usuario.aspx");
                }
                else
                {
                    Label4.Text = "Revisar entrada";
                    Session.Abandon();
                }
            }
        }
    }
}