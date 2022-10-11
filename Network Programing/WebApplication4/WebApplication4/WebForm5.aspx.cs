using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication4
{
    public partial class WebForm5 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string s = "";
            List<int> myArray = new List<int>();
            myArray.Add(5);
            myArray.Add(19);
            myArray.Add(3);
            myArray.Sort();
            foreach(int num in myArray)
            {
                s += num.ToString() + "<br/>";
            }
            Label1.Text = s;
        }

    }
}