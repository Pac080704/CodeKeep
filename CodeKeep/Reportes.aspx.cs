using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.Odbc;

namespace CodeKeep
{
    public partial class Reportes : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //verificar que las variables de sesion se autenticaron correctamente
            if (Session["cAdmin"] == null || Session["nombre"] == null)
            {
                Response.Redirect("InicioSesion.aspx");
            }

            //Cargar los items del CheckBoxList de los campos
            if(CheckBoxList1.Items.Count == 0)
            {
                CheckBoxList1.Items.Add(new ListItem("Nombre", "Cuenta.nombre as Nombre"));
                CheckBoxList1.Items.Add(new ListItem("Correo", "Cuenta.correo as Correo"));
                CheckBoxList1.Items.Add(new ListItem("Contacto", "Contactos.nombre as Contacto"));
                CheckBoxList1.Items.Add(new ListItem("Telefono", "Contactos.telefono as Telefono"));
                CheckBoxList1.Items.Add(new ListItem("Ciudad", "Ciudad.nombreCiudad as Ciudad"));
                CheckBoxList1.Items.Add(new ListItem("Documento", "Tipo.nombre as Tipo de Documento"));
                CheckBoxList1.Items.Add(new ListItem("Plataforma", "Plataforma.nombre as Plataforma"));
                CheckBoxList1.Items.Add(new ListItem("Contraseña", "Contraseñas.passwrd as Contraseña"));
                CheckBoxList1.Items.Add(new ListItem("Evento", "Eventos.fecha as Fecha Evento"));
            }
            //Cargar los items de las DropDownLists de los filtros
            if(DropDownList1.Items.Count == 0)
            {
                String query = "SELECT Cuenta.claveC, Cuenta.nombre from Cuenta";
                OdbcConnection conexion = new ConexionBD().con;
                OdbcCommand comando = new OdbcCommand(query, conexion);
                OdbcDataReader lector = comando.ExecuteReader();

                DropDownList1.DataSource = lector;
                DropDownList1.DataValueField = "claveC";
                DropDownList1.DataTextField = "nombre";
                DropDownList1.DataBind();
                conexion.Close();
                DropDownList1.Items.Insert(0, new ListItem("(sin selección)", "-1"));
            }
            if(DropDownList2.Items.Count == 0)
            {
                String query = "SELECT Plataforma.claveP, Plataforma.nombre from Plataforma";
                OdbcConnection conexion = new ConexionBD().con;
                OdbcCommand comando = new OdbcCommand(query,conexion);
                OdbcDataReader lector = comando.ExecuteReader();

                DropDownList2.DataSource = lector;
                DropDownList2.DataValueField = "claveP";
                DropDownList2.DataTextField = "nombre";
                DropDownList2.DataBind();
                conexion.Close();
                DropDownList2.Items.Insert(0, new ListItem("(sin selección)", "-1"));
            }
            if(DropDownList3.Items.Count == 0)
            {
                String query = "SELECT Tipo.ClaveTipo, Tipo.nombre from Tipo";
                OdbcConnection conexion = new ConexionBD().con;
                OdbcCommand comando = new OdbcCommand(query, conexion);
                OdbcDataReader lector = comando.ExecuteReader();

                DropDownList3.DataSource = lector;
                DropDownList3.DataValueField = "ClaveTipo";
                DropDownList3.DataTextField = "nombre";
                DropDownList3.DataBind();
                conexion.Close();
                DropDownList3.Items.Insert(0, new ListItem("(sin selección)", "-1"));
            }
            if(DropDownList4.Items.Count == 0)
            {
                String query = "SELECT Tipo.ClaveTipo, Tipo.nombre from Tipo";
                OdbcConnection conexion = new ConexionBD().con;
                OdbcCommand comando = new OdbcCommand(query,conexion);
                OdbcDataReader lector = comando.ExecuteReader();

                DropDownList4.DataSource = lector;
                DropDownList4.DataValueField = "ClaveTipo";
                DropDownList4.DataTextField = "nombre";
                DropDownList4.DataBind();
                conexion.Close();
                DropDownList4.Items.Insert(0, new ListItem("(sin selección)", "-1"));
            }
            
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            String select = "SELECT ";
            String from = " FROM Cuenta inner join Contactos on Contactos.cUsuario = Cuenta.cUsuario inner join Ciudad on Ciudad.claveC = Cuenta.claveC inner join Documentos on Documentos.cUsuario = Cuenta.cUsuario inner join Tipo on Tipo.ClaveTipo = Documentos.ClaveTipo inner join Contraseñas on Contraseñas.cUsuario = Cuenta.cUsuario inner join Plataforma on Plataforma.claveP = Contraseñas.claveP inner join Eventos on Eventos.cUsuario = Cuenta.cUsuario";
            String where = " where 1=1 ";
            String query = "";

            for(int i = 0; i < CheckBoxList1.Items.Count; i++)
            {
                if (CheckBoxList1.Items[i].Selected)
                {
                    select = select + CheckBoxList1.Items[i].Value.ToString();
                    select = select + ",";
                }
            }
            select = select.TrimEnd(',');
            select = select + " ";

            if(DropDownList1.SelectedValue != "-1")
            {
                where = where + " and Cuenta.cUsuario = ? ";
            }
            if(DropDownList2.SelectedValue != "-1")
            {
                where = where + " and Plataforma.claveP = ? ";
            }
            if(DropDownList3.SelectedValue != "-1")
            {
                where = where + " and Tipo.ClaveTipo = ? ";
            }
            if(DropDownList4.SelectedValue != "-1")
            {
                where = where + " and Ciudad.claveC = ? ";
            }

            query = select + from + where;

            OdbcConnection conexion = new ConexionBD().con;
            OdbcCommand comando = new OdbcCommand(query, conexion);

            if(DropDownList1.SelectedValue != "-1")
            {
                comando.Parameters.AddWithValue("cUsuario", DropDownList1.SelectedValue);
            }
            if(DropDownList2.SelectedValue != "-1")
            {
                comando.Parameters.AddWithValue("claveP", DropDownList2.SelectedValue);
            }
            if(DropDownList3.SelectedValue != "-1")
            {
                comando.Parameters.AddWithValue("ClaveTipo", DropDownList3.SelectedValue);
            }
            if(DropDownList4.SelectedValue != "-1")
            {
                comando.Parameters.AddWithValue("claveC", DropDownList4.SelectedValue);
            }

            try
            {
                OdbcDataReader lector = comando.ExecuteReader();
                GridView1.DataSource = lector;
                GridView1.DataBind();
            }
            catch(Exception ex)
            {
                Label1.Text = "ERROR: " + ex.ToString();
            }
            conexion.Close();
        }
    }
}