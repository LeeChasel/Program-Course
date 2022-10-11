using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication4
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int[] ary = { 1, 2, 3, 4, 5 };
            string s = "";
            for (int i = 1; i <= 5; i++)
            {
                s += ary[i - 1].ToString();
            }
            Label1.Text = s;
        }
    }
}