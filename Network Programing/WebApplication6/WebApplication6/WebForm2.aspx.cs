using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication6
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //DropDownList1.Items.Clear();
            if (!this.IsPostBack)
            {
                ListItem a = new ListItem();
                ListItem b = new ListItem();
                //定義與解釋
                a.Text = "Find";
                a.Value = "Discover something";
                DropDownList1.Items.Add(a);

                b.Text = "Kill";
                b.Value = "Let someone die";
                DropDownList1.Items.Add(b);
            }
        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Label1.Text = DropDownList1.SelectedValue;
        }
    }
}