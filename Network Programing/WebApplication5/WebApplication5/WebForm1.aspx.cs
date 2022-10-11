using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication5
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                Circle circle = new Circle(Double.Parse(TextBox1.Text));
                //circle.Radius = Double.Parse(TextBox1.Text);
                Label1.Text = circle.Area().ToString();
                Label2.Text = circle.Circumference().ToString();

            } catch(Exception err)
            {
                Label1.Text = err.Message.ToString();
            }
        }
    }
}