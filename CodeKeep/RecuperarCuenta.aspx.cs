using System;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Linq;
using System.Reflection.Emit;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CodeKeep
{
    public partial class RecuperarCuenta : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Label3.Visible = false;
            TextBox2.Visible = false;
            Button2.Visible = false;
            Button3.Visible = false;
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            String query1 = " select pregRescate, respRescate from Cuenta " +
                " where correo= ? ";
            String preguntaResc;
            String respuestaResc;
            OdbcConnection conexion;
            ConexionBD objetoConexionBD = new ConexionBD();
            conexion = objetoConexionBD.con;
            OdbcCommand comando1 = new OdbcCommand(query1, conexion);
            comando1.Parameters.AddWithValue("correo", TextBox1.Text);
            OdbcDataReader lector1 = comando1.ExecuteReader();
            if (lector1.HasRows)
            {
                lector1.Read();
                preguntaResc = lector1.GetString(0);
                respuestaResc = lector1.GetString(1);
                Session.Add("correoc", TextBox1.Text);
                TextBox1.Text = preguntaResc.ToString();
                Label2.Text = "Pregunta de Recuperación";
                Label3.Visible = true;
                TextBox2.Visible = true;
                Label3.Text = "Respuesta";
                Button1.Visible = false;
                Button2.Visible=true;
                Session.Add("respuesta", respuestaResc);
                conexion.Close();
            }
            else
            {
                Label4.Text = "Revisar entrada";
                Session.Abandon();
                conexion.Close ();
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            //Visibilidad
            TextBox2.Visible = true;
            Label3.Visible = true;
            Label3.Text = "Respuesta";
            Button2.Visible = true;
            //Funcionalidad
            if (Session["respuesta"].ToString().Equals(TextBox2.Text.ToString()))
            {
                Button2.Visible = false;
                Button3.Visible = true;
                Label3.Visible = true;
                TextBox2.Visible = true;
                TextBox1.Text = "";
                TextBox2.Text = "";
                Label2.Text = "Nueva Contraseña";
                Label3.Text = "Confrimar Contraseña";
            }
            else
            {
                Session.Abandon();
                Response.Redirect("InicioSesion.aspx");
            }
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            Label3.Visible = true;
            TextBox2.Visible = true;
            Button3.Visible = true;
            String query = " update Cuenta set contraseña= ? where correo= ? ";
            ConexionBD objetoConexionBD = new ConexionBD();
            OdbcConnection conexion = objetoConexionBD.con;
            OdbcCommand comando1 = new OdbcCommand(query, conexion);
            comando1.Parameters.AddWithValue("contrasena", TextBox2.Text);
            comando1.Parameters.AddWithValue("correo", Session["correoc"]);
            if (TextBox1.Text.Equals(TextBox2.Text))
            {
                try
                {
                    comando1.ExecuteNonQuery();
                    conexion.Close();
                    Session.Abandon();
                    Response.Redirect("InicioSesion.aspx");
                }
                catch (Exception ex)
                {
                    Label4.Text = ex.ToString();
                }
                
            }
            else
            {
                Label4.Text = "Revisar Entrada";
                conexion.Close();
                Session.Abandon();
                Response.Redirect("RecuperarCuenta.aspx");
            }
        }
    }
}