using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HW1
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string height_opt = DropDownList1.SelectedValue;
            string weight_opt = DropDownList2.SelectedValue;
            double height = Double.Parse(TextBox1.Text);
            double weight = Double.Parse(TextBox2.Text);
            if (height_opt == "Inch")
            {
                height *= 2.54;
            }
            height = height / 100.0;
            if (weight_opt == "Pound")
            {
                weight *= 0.453;
            }
            double bmi = weight / (height * height);
            string r = "";
            r = r + "BMI : " + bmi.ToString() + "<br/>";
            if (bmi < 18.5)
            {
                r = r + "體重過輕";
            } else if (bmi < 24)
            {
                r = r + "體重正常";
            } else if (bmi < 27)
            {
                r = r + "體重過重";
            } else if (bmi < 30)
            {
                r = r + "輕度肥胖";
            } else if (bmi < 35)
            {
                r = r + "中度肥胖";
            } else if (bmi >= 35)
            {
                r = r + "重度肥胖";
            } else
            {
                r = r + "輸入數值錯誤，或你不是人";
            }
            Label1.Text = r;
        }
    }
}