using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CodeKeep
{
    public partial class Consulta : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["cUsuario"] == null ||
            Session["nombre"] == null)
            {
                Response.Redirect("InicioSesion.aspx");
            }
        }
    }
}