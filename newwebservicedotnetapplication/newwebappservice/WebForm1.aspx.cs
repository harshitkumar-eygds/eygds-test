using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace newwebappservice
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            ServiceReference1.WebService1SoapClient c1 = new ServiceReference1.WebService1SoapClient();

            int n1 = int.Parse(TextBox1.Text);
            int n2 = int.Parse(TextBox2.Text);

            int result = c1.Addition(n1, n2);
            Label3.Text = result.ToString();
            Label3.Visible = true;
        }
    }
}