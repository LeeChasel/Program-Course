using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication5
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                Product p = new Product();
                p.Price = 100;
                int volume = Int32.Parse(TextBox1.Text);
                Label1.Text = p.totalSales(volume).ToString();

            } catch (Exception err)
            {
                Label1.Text = err.Message.ToString();  
            }
        }
    }
}