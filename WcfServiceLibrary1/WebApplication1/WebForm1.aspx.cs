using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            ServiceReference1.Service1Client obj = new ServiceReference1.Service1Client();
            int result = obj.addition(int.Parse(TextBox1.Text), int.Parse(TextBox2.Text));
            Label3.Text = result.ToString();


        }
    }
}