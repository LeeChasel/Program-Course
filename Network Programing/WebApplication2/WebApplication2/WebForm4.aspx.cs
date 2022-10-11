using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication2
{
    public partial class WebForm4 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int a, b;
            string str = "";
            try
            {
                a = int.Parse(TextBox1.Text);
                for (int i = 2; i <= a; i++)
                {
                    for (int j = 2; j <= 9; j++)
                    {
                        b = i * j;
                        str = str + i + "*" + j + "=" + b + "<br/>";
                    }
                }
            }
            catch (Exception err)
            {
                str = err.Message.ToString();
            }
            Label1.Text = str;
        }
    }
}