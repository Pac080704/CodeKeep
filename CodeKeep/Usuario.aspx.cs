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
            /*
            if (Session["cUsuario"] == null ||
            Session["nombre"] == null)
            {
                Response.Redirect("InicioSesion.aspx");                             ESTOOOOOO LO TENGO QUE QUITAR!!!!!!!!!!!!!!!!!!
            }
            else
            {
                Label1.Text = "Bienvenid@ "+ Session["nombre"].ToString();
            }
            */
            consul.Visible = false;
            inser.Visible = false;

            if (DropDownList1.Items.Count == 0)
            {
                DropDownList1.Items.Add("Eventos");
                DropDownList1.Items.Add("Contraseñas");
            }

            if (DropDownList1.Items[0].Selected == true)
            {

            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            adformusu.Visible = false;
            consul.Visible = true;
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            Session.Abandon();
            Response.Redirect("InicioSesion.aspx");
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            adformusu.Visible=false;
            inser.Visible = true;
        }
    }
}