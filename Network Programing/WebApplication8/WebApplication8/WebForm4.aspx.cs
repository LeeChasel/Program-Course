using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Web.Configuration;

namespace WebApplication8
{
    public partial class WebForm4 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!this.IsPostBack)
            {
                //避免db連接變動時，所有的connection都要更改，直接取得webconfig裡的連接字串，到webconfig中看要填入的string
                string strcon = WebConfigurationManager.ConnectionStrings["imConnectionString"].ConnectionString;
                try
                {
                    SqlConnection sqlcon = new SqlConnection(strcon);
                    sqlcon.Open();
                    SqlCommand sqlcmd = new SqlCommand();
                    sqlcmd.Connection = sqlcon;
                    sqlcmd.CommandText = "select uid, upass from uaccount";
                    SqlDataReader sqldr = sqlcmd.ExecuteReader();
                    ListBox1.DataSource = sqldr;
                    ListBox1.DataTextField = "UID";
                    ListBox1.DataValueField = "UPASS";
                    ListBox1.DataBind(); //把資料來源與listbox結合
                    /*while (sqldr.Read()) //有就回傳true, 沒了回傳false
                    {
                        ListItem i = new ListItem();
                        i.Text = sqldr.GetString(1);
                        i.Value = sqldr.GetString(0);
                        ListBox1.Items.Add(i);
                    }*/
                    sqldr.Close();
                } catch (SqlException err)
                {

                }
            }
        }
    }
}