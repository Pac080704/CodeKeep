using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CodeKeep
{
    public partial class Usuario : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["cUsuario"] == null ||
            Session["nombre"] == null)
            {
                Response.Redirect("InicioSesion.aspx");
            }
            else
            {
                Label1.Text = "Bienvenid@ "+ Session["nombre"].ToString();
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("Consulta.aspx");
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            Session.Abandon();
            Response.Redirect("InicioSesion.aspx");
        }
    }
}