using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
using System.Data.SqlTypes;

namespace WebApplication9
{
    public partial class WebForm3 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!this.IsPostBack)
            {
                string strcon = @"Data Source=(localdb)\mssqllocaldb;Initial Catalog=product;Integrated Security=True;Pooling=False";
                SqlConnection sqlcon = new SqlConnection(strcon);
                sqlcon.Open();
                /*SqlCommand sqlcmd = new SqlCommand();
                sqlcmd.Connection = sqlcon;
                sqlcmd.CommandText = "select cid, cname from customer";*/
                //SqlDataAdapter sqldr = new SqlDataAdapter(sqlcmd);
                SqlDataAdapter sqldr = new SqlDataAdapter("select cid, cname from customer", sqlcon);
                DataSet ds = new DataSet();
                sqldr.Fill(ds, "cust"); //將回傳資料放到dataset ds中，名稱為cust
                ListBox1.DataSource = ds.Tables["cust"];
                ListBox1.DataTextField = "cname";
                ListBox1.DataValueField = "cname";
                ListBox1.DataBind();
                sqlcon.Close();
            };
        }
    }
}