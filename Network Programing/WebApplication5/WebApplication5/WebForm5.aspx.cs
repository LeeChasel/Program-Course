using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication5
{
    public partial class WebForm5 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Employee em = new Employee();
            em.Name = TextBox1.Text;
            if (RadioButtonList1.SelectedValue == "Male")
            {
                em.Gender = true;
            } else
            {
                em.Gender = false;
            }

            foreach (ListItem i in CheckBoxList1.Items)
            {
                if (i.Selected)
                {
                    em.skills.Add(i.Value);
                }
            }
            Label1.Text = em.getInfo();

        }
    }
}