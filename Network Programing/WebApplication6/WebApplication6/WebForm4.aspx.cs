using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication6
{
    public partial class WebForm4 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int counter;
            //若key值 counter不存在
            if (this.ViewState["counter"] == null)
            {
                counter = 1;
            }
            else
            {
                counter = (int)this.ViewState["counter"] + 1;
            }
            this.ViewState["counter"] = counter;
            Label1.Text = counter.ToString();
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            HttpCookie cook = new HttpCookie("Hello");
            cook["name"] = TextBox1.Text;
            cook.Expires = DateTime.Now.AddYears(1);
            this.Response.Cookies.Add(cook);

            //Function 1
            //server丟response給client後，client再要求server導向WebForm6.aspx
            //URL會變化
            this.Response.Redirect("WebForm6.aspx");

            //Function 2
            //在server執行時直接連接到WebFomr6.aspx，response再給client
            //URL不變，速度較快，對外的網址只有第一次進去的網頁，可以隱藏呼叫的網頁
            //this.Server.Transfer("WebForm6.aspx");
            
        }
    }
}