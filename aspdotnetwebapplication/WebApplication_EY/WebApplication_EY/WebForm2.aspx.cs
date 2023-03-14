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
    public partial class WebForm2 : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection
                (
                "Data source=Lab-Host\\SQLEXPRESS03;Initial Catalog=EYdatabase;Integrated Security=True"
                );
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            con.Open();

            SqlDataAdapter ad = new SqlDataAdapter("select * from subject2 where marks>80", con);
            SqlDataAdapter radio = new SqlDataAdapter("select * from subject2 where marks>80", con);
            SqlDataAdapter c = new SqlDataAdapter("select * from subject2 where marks>80", con);


            DataSet ds = new DataSet();

            ad.Fill(ds);

            GridView1.DataSource = ds;
            GridView1.DataBind();
        }
    }
}