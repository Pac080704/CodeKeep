using System;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CodeKeep
{
    public partial class InsertarInfoAdmi : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //verificar que las variables de sesion se autenticaron correctamente
            if (Session["cAdmin"] == null || Session["nombre"] == null)
            {
                Response.Redirect("InicioSesion.aspx");
            }
        }

        protected void CargarGridView(int n)
        {
            String select = "";
            String query = "";
            switch (n)
            {
                case 1:
                    select = "SELECT * from Ciudad ";
                break;
                case 2:
                    select = "SELECT * from Plataforma ";
                break;
                case 3:
                    select = "SELECT * from Tipo ";
                break;
            }
            query = select;

            OdbcConnection conexion = new ConexionBD().con;
            OdbcCommand comando = new OdbcCommand(query, conexion);
            OdbcDataReader lector = comando.ExecuteReader();

            GridView1.DataSource = lector;
            GridView1.DataBind();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            String query = "INSERT into Ciudad values((select Isnull(max(claveC), 0) + 10 from Ciudad), ?)";
            OdbcConnection conexion = new ConexionBD().con;
            OdbcCommand comando = new OdbcCommand(query, conexion);
            comando.Parameters.AddWithValue("nombreCiudad", TextBox1.Text);
            try
            {
                comando.ExecuteNonQuery();
                CargarGridView(1);
                TextBox1.Text = "";
            }
            catch (Exception ex)
            {
                Label1.Text = "Error: " + ex.ToString();
            }
            conexion.Close();
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            String query = "INSERT into Plataforma values ((SELECT Isnull(max(claveP), 0) + 10 from Plataforma), ?)";
            OdbcConnection conexion = new ConexionBD().con;
            OdbcCommand comando = new OdbcCommand(query, conexion);
            comando.Parameters.AddWithValue("nombre", TextBox2.Text);
            try
            {
                comando.ExecuteNonQuery();
                CargarGridView(2);
                TextBox2.Text = "";
            }
            catch (Exception ex)
            {
                Label1.Text = "ERROR: " + ex.ToString();
            }
            conexion.Close();
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            String query = "INSERT into Tipo values((SELECT Isnull(max(ClaveTipo), 0) + 10 from Tipo), ?)";
            OdbcConnection conexion = new ConexionBD().con;
            OdbcCommand comando = new OdbcCommand(query, conexion);
            comando.Parameters.AddWithValue("nombre", TextBox3.Text);
            try
            {
                comando.ExecuteNonQuery();
                CargarGridView(3);
                TextBox3.Text = "";
            }
            catch (Exception ex)
            {
                Label1.Text = "ERROR: " + ex.ToString();
            }
            conexion.Close();
        }
    }
}