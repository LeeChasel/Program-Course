using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Web.Configuration;

namespace WebApplication9
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string strcon = WebConfigurationManager.ConnectionStrings["productConnectionString"].ConnectionString;
            SqlConnection sqlcon = new SqlConnection(strcon);
            sqlcon.Open();
            try
            {
                SqlCommand sqlcmd = new SqlCommand();
                sqlcmd.Connection = sqlcon;
                sqlcmd.CommandText = "select name, price from product where id='" + TextBox1.Text + "'";
                SqlDataReader sqldr = sqlcmd.ExecuteReader();
                string l1 = "";
                string l2 = "";
                if (sqldr.Read())
                {
                    l1 = sqldr.GetString(0);
                    l2 = sqldr.GetString(1);
                } else
                {
                    l1 = "Can't find data";
                    l2 = "Can't find data";
                }
                Label1.Text = l1;
                Label2.Text = l2;

            } catch (SqlException err)
            {
                Label1.Text = err.ToString();
            }
            

        }
    }
}