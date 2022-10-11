﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication4
{
    public partial class WebForm3 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            double[] b = new double[5];
            double temp;
            string itemID;
            string ss = "";
            for (int i = 1; i<=5; i++)
            {
                TextBox a;
                itemID = "TextBox" + i.ToString();
                a = (TextBox) this.FindControl(itemID);
                b[i-1] = Double.Parse(a.Text);
            }

            for (int i = 1; i<=5; i++)
            {
                for (int j = i + 1; j<=5; j++)
                {
                    if (b[i-1] < b[j-1])
                    {
                        temp = b[i - 1];
                        b[i - 1] = b[j - 1];
                        b[j - 1] = temp;
                    }
                }
            }
            for (int i = 1; i<=5; i++)
            {
                ss += b[i-1].ToString() + "<br/>";
            }
            Label1.Text = ss;
        }
    }
}