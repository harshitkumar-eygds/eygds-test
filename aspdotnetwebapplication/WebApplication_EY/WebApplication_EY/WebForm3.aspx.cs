using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using System.Data;
using System.Data.SqlClient;
using System.Linq;


namespace WebApplication_EY
{
    //public partial class subject2 
    //{   
    //    public int id { get; set; }
    //    public string sub_name { get; set; }
    //    public int marks { get; set; }
    //}
    public partial class WebForm3 : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection
               (
               "Data source=Lab-Host\\SQLEXPRESS03;Initial Catalog=EYdatabase;Integrated Security=True"
               );
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
           


        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlDataAdapter ad = new SqlDataAdapter("select * from subject2 where marks>90", con);

            DataSet ds = new DataSet();
            ad.Fill(ds);
            GridView1.DataSource = ds;
            GridView1.DataBind();

          //  SampleDataContext dbContext = new SampleDataContext();
         //   GridView2.DataSource = dbContext.Employees;
          //  GridView2.DataBind();

            // var result = from s in subject2
            //select s where s.marks > 80;
        }
    }
}