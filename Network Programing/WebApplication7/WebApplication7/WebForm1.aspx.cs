using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication7
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            /*Cookie
            HttpCookie ck = new HttpCookie("hello");
            ck["name"] = TextBox1.Text;
            ck.Expires = DateTime.Now.AddYears(1);
            Response.Cookies.Add(ck);
            Response.Redirect("WebForm2.aspx");*/

            /*QuerryString
            string r = this.Server.UrlEncode(TextBox1.Text);
            string s = this.Server.UrlEncode(TextBox2.Text);
            Response.Redirect("WebForm2.aspx?a=" + r + "&b=" + s);*/

            this.Session["name"] = TextBox1.Text;
            this.Response.Redirect("WebForm2.aspx");
        }
    }
}