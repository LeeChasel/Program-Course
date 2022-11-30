using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Midterm
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            foreach (GridViewRow i in GridView1.Rows)
            {
                int salary = 0;
                int basic_salary = 0;
                string days = ((TextBox)i.Cells[3].FindControl("TextBox1")).Text;
                if (days.Equals("") || Int32.Parse(days) < 0)
                {
                    days = "0";
                }
                switch (i.Cells[2].Text)
                {
                    case "A":
                        basic_salary = 1500;
                        break;
                    case "B":
                        basic_salary = 1800;
                        break;
                    case "C":
                        basic_salary = 2000;
                        break;
                }
                salary = basic_salary * Int32.Parse(days);   
                i.Cells[4].Text = salary.ToString();
            }
        }
    }
}