using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication6
{
    public partial class WebForm5 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!this.IsPostBack)
            {
                //key, value值都為string的dictionary
                Dictionary<string, string> dic = new Dictionary<string, string>();
                dic.Add("Find", "Discover something.");
                dic.Add("Kill", "Let someone die.");
                //item的text, value都會為Let someone die.
                DropDownList1.Items.Add(dic["Find"]);
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {

        }
    }
}