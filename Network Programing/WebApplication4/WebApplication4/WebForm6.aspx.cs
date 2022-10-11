using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication4
{
    public partial class WebForm6 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Unnamed2_Click(object sender, EventArgs e)
        {
            string r = "";
            string a = TextBox6.Text;
            string[] b = a.Split(',');
            double[] c = new double[b.Length];

            for (int i = 0; i < b.Length; i++)
            {
                c[i] = Double.Parse(b[i]);
            }
            Array.Sort(c);

            foreach(double x in c)
            {
                r += x.ToString() + "<br/>";
            }
            Label6.Text = r;

        }
    }
}