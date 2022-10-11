using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication2
{
    public partial class WebForm3 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                double a = Double.Parse(TextBox1.Text);
                double b = Double.Parse(TextBox2.Text);
                double c = Math.Pow(a, b);
                Label1.Text = c.ToString();
            } catch (Exception err)
            {
                Label1.Text = err.Message.ToString();
            }

        }
    }
}