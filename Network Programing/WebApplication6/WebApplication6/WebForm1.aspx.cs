using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication6
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Employee em = new Employee();
            //new出List物件
            List<string> s = new List<string>();
            em.Name = TextBox1.Text;
            if (RadioButtonList1.SelectedValue == "Male")
            {
                em.Gender = true;
            }
            else
            {
                em.Gender = false;
            }
            foreach (ListItem l in CheckBoxList1.Items)
            {
                if (l.Selected)
                {
                    s.Add(l.Value);
                }
            }
            //將實體的物件指定給Employee的skills
            em.Skills = s;
            Label1.Text = em.getInfo();
        }
    }
}