using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication6
{
    public partial class WebForm3 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            ListItem a = new ListItem();
            double b = 0;
            a.Text = ListBox1.SelectedItem.Text;
            a.Value = ListBox1.SelectedValue;
            ListBox2.Items.Add(a);
            foreach (ListItem i in ListBox2.Items)
            {
                b = b + Double.Parse(i.Value);
            }
            Label1.Text = b.ToString();
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            ListBox2.Items.Remove(ListBox2.SelectedItem);
            double b = 0;
            foreach (ListItem i in ListBox2.Items)
            {
                b = b + Double.Parse(i.Value);
            }
            Label1.Text = b.ToString();
        }
    }
}