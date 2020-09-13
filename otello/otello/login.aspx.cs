using System;


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
                Response.Redirect("menu.aspx");
            }
            else
            {
                Response.Write("<scrip>window.alert('incorrectas')</script>");
            }

        }
    }
}