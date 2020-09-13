using System;

namespace otello
{
    public partial class menu : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("partidavs.aspx");
        }
    }
}