using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication11_1121
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            int total = 0;
            int temp_price = 0;
            int temp_qty = 0;
            foreach (GridViewRow i in GridView1.Rows)
            {
                temp_price = int.Parse(i.Cells[2].Text);
                if (((TextBox)i.Cells[4].FindControl("TextBox2")).Text == "")
                {
                    temp_qty = 0;
                } else
                {
                    temp_qty = int.Parse(((TextBox)i.Cells[4].FindControl("TextBox2")).Text);
                }
                total += temp_price * temp_qty;
            }
            Label1.Text = total.ToString();
        }
    }
}