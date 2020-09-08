using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


namespace otello
{
    public partial class login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Write("<scrip>window.alert('registrece')</script>");
            Response.Redirect("registrar.aspx");






        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            sincronizar p = new sincronizar();
            string usuario, contraseña;
            usuario = TextBox1.Text;
            contraseña = TextBox2.Text;
           

            if (p.buscar(usuario, contraseña))
            {
                Response.Write("<scrip>window.alert('bienvenido')</script>");
                Response.Redirect("menu.aspx");
            }
            else
            {
                Response.Write("<scrip>window.alert('error')</script>");
            }

        }
    }
}