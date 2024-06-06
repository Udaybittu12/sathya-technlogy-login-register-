using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace sathya_technlogy_registration
{
    public partial class LogIn : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            Server.Transfer("Register.aspx");
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Server.Transfer("Home.aspx");
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Label1.Text = "sathya Technology";
            if (TextBox1.Text=="uday" && TextBox2.Text=="Uday@123") { Server.Transfer("welcome.aspx"); }
            else { Label1.Text = "invalid username or password"; }
        }
    }
}