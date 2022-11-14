using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication10_1114
{
    public partial class WebForm3 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            int sum = 0;
            foreach (GridViewRow i in GridView1.Rows)
            {
                string qty = ((TextBox)i.Cells[4].FindControl("TextBox2")).Text;
                if (qty.Equals("") || Int32.Parse(qty) < 0)
                {
                    qty = "0";
                }
                sum += Int32.Parse(i.Cells[2].Text) * Int32.Parse(qty);
            }
            Label1.Text= sum.ToString();
        }
    }
}