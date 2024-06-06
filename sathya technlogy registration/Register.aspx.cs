using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace sathya_technlogy_registration
{
    public partial class Register : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string s1 = TextBox1.Text;
            string s2 = TextBox2.Text;
            char[] ch1 = s2.ToCharArray();
            int uc = 0, lc = 0, dc = 0, sc = 0;
            for (int i=0;i<ch1.Length;i++)
            {
                if (ch1[i]>='A' && ch1[i]<='Z') { uc++; }
                else if (ch1[i] >= 'a' && ch1[i] <= 'z') { lc++; }
                else if (ch1[i] >= '0' && ch1[i] <= '9') { sc++; }
                else { sc++; }
            }
            if (sc==0 || lc==0 || uc==0 || dc == 0) { Label1.Text = "password should contain atleast one uppercase, one lowercase, one digit, one special symbol"; }
            else if (TextBox3.Text!=TextBox2.Text) { Label1.Text = "password and confirm password should be same"; }
            string s3 = TextBox4.Text;
            char[] ch2 = s3.ToCharArray(); int c = 0;
            for (int i=0;i<ch2.Length;i++)
            {
                if (ch2[i]>='0' && ch2[i]<='9') { c++; }
            }
            if (c!=10) { Label1.Text = "enter valid phone number"; }

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Server.Transfer("LogIn.aspx");
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            Server.Transfer("Home.aspx");
        }
    }
}