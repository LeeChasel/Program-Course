using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication7
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            /*HttpCookie aa = Request.Cookies["hello"];
            if (aa is null)
            {
                Label1.Text = "No cookie";
            }
            else
            {
                Label1.Text = aa["name"];
            }*/

            /*Label1.Text = Request.QueryString["a"];
            Label2.Text = Request.QueryString["b"];*/

            //Label1.Text = this.Session["name"].ToString();
            
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            this.Response.Redirect("WebForm3.aspx");
        }
    }
}