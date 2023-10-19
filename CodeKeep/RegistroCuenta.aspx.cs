using System;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CodeKeep
{
    public partial class RegistroCuenta : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            String query = "insert into Cuenta values( ? , ? , ? , ? , ? , ? , ? , ? )";
            String queryClave = "select max(cUsuario) from Cuenta";
            int claveCuenta;
            OdbcConnection conexion;
            ConexionBD objetoConexionBD = new ConexionBD();
            conexion = objetoConexionBD.con;
            OdbcCommand comando = new OdbcCommand(queryClave, conexion);
            OdbcDataReader lector = comando.ExecuteReader();
            lector.Read();
            try
            {
                claveCuenta = lector.GetInt32(0) + 1;
            }
            catch (Exception ex)
            {
                claveCuenta = 1;
            }
            comando = new OdbcCommand(query, conexion);
            comando.Parameters.AddWithValue("cUsuario", claveCuenta);
            comando.Parameters.AddWithValue("correo", TextBox1.Text);
            comando.Parameters.AddWithValue("contraseña", TextBox2.Text);
            comando.Parameters.AddWithValue("pregRescate", TextBox3.Text);
            comando.Parameters.AddWithValue("respRescate", TextBox4.Text);
            comando.Parameters.AddWithValue("direccion", TextBox5.Text);
            comando.Parameters.AddWithValue("nombre", TextBox6.Text);
            comando.Parameters.AddWithValue("fechaNac", TextBox7.Text);
            try
            {
                comando.ExecuteNonQuery();
                Response.Redirect("InicioSesion.aspx");
            }
            catch (Exception ex)
            {

            }
            conexion.Close();
        }
    }
}