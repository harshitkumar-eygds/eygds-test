using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication_EY
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int num1 = int.Parse(TextBox1.Text);
            int num2 = int.Parse(TextBox2.Text);

            Response.Write(" Addition result is : " + (num1 + num2));
            Response.Write(" Subtraction result is : " + (num1 - num2));
            Response.Write(" Multiplication result is : " + (num1 * num2));
            Response.Write(" Division result is : " + (num1 / num2));
            Response.Write(" Modulus result is : " + (num1 % num2));


        }
    }
}