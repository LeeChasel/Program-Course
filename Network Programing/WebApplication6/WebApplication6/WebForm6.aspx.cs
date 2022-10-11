using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication6
{
    public partial class WebForm6 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //Here
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            ViewState["Content"] = TextBox1.Text;
        }  
        protected void Button2_Click(object sender, EventArgs e)
        {
            TextBox1.Text = ViewState["Content"].ToString();
        }
        protected void Button3_Click(object sender, EventArgs e)
        {

        }
    }
}