using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace WebApplication8
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            //Option 1
            //using System.Data.SqlClient;
            //from db's 屬性欄的'連結字串'
            string strcon = @"Data Source=(localdb)\mssqllocaldb;Initial Catalog=im;Integrated Security=True";
            SqlConnection sqlcon = new SqlConnection(strcon);
            //SqlConnection sqlcon = new SqlConnection();
            //sqlcon.ConnectionString = strcon;
            sqlcon.Open();
            try
            {
                SqlCommand sqlcmd = new SqlCommand();
                sqlcmd.Connection = sqlcon;
                //字串要放單引號裡
                //can't prevent sql injecting
                //sqlcmd.CommandText = "select uid,upass from uaccount where uid='" + TextBox1.Text + "' and upass='" + TextBox2.Text + "'";
                //分段驗證
                sqlcmd.CommandText = "select uid,upass from uaccount where uid='" + TextBox1.Text + "'";

                SqlDataReader sqldr = sqlcmd.ExecuteReader();

                //若sqldr有紀錄
                if (sqldr.HasRows)
                {
                    sqldr.Read();
                    //取出upass
                    //比較輸入資料的UID對應的Upass有沒有在DB中
                    if (sqldr.GetString(1).Equals(TextBox2.Text))
                    {
                        Response.Redirect("WebForm2.aspx");
                    }
                }
            } catch(SqlException err)
            {

            } finally
            {
                sqlcon.Close();
            }




        }
    }
}