using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication4
{
    public partial class WebForm7 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Unnamed1_Click(object sender, EventArgs e)
        {
            string name = TextBox1.Text;
            string mes = TextBox2.Text;
            // 若mes有換行(/r/n)，要把ascii字元替換成讀得懂的<br/>，不然不會換行
            mes = mes.Replace("\r\n", "<br/>");
            mes = "<hr/>" + DateTime.Now.ToString() + "<br/>" + name + ": <br/>" + mes;
            Label1.Text += mes;
        }

        protected void Unnamed2_Click(object sender, EventArgs e)
        {
            TextBox2.Text = "";
        }
    }
}