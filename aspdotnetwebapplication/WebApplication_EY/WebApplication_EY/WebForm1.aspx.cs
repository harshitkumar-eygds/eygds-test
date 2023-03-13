using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using System.Data;
using System.Data.SqlClient;

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

        protected void Button2_Click(object sender, EventArgs e)
        {
            Label1.Text = "selected city from dropdown is : " + DropDownList1.SelectedItem.Text.ToString();

            Label2.Text = "selected city from listbox is : " + ListBox1.SelectedItem.Text.ToString();


        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection
                (
                "Data source=Lab-Host\\SQLEXPRESS03;Initial Catalog=EYdatabase;Integrated Security=True"
                );
            con.Open();

            Response.Write("Connection is succesfull");
        }
    }
}