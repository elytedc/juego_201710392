using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


namespace otello
{
    public partial class registrar : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            sincronizar p = new sincronizar();
            string nombre, apellido, usuario, contraseña, nacimiento, pais, correo;
            nombre = TextBox1.Text;
            apellido= TextBox2.Text;
            usuario = TextBox3.Text;
            contraseña = TextBox4.Text;
            nacimiento = TextBox5.Text;
            pais = TextBox6.Text;
            correo = TextBox7.Text;

            if (p.validar(usuario))
            {
                Response.Write("<scrip>window.alert('error usuario ya existe')</script>");
                
            }
            else
            {
                if (p.insertar(nombre, apellido, usuario, contraseña, nacimiento, pais, correo))
                {
                    Response.Write("<scrip>window.alert('persona ingresada bien')</script>");
                }
                else
                {
                    Response.Write("<scrip>window.alert('error')</script>");
                }
            }



            

        }
    }
}