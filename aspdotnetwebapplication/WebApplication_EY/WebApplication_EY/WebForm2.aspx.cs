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
            SqlDataAdapter radio = new SqlDataAdapter("select studid from subject2 where marks>80", con);
            SqlDataAdapter check = new SqlDataAdapter("select sub_name from subject2 where marks>80", con);
            SqlDataAdapter dplist = new SqlDataAdapter("select  marks from subject2 where marks>80", con);


            DataSet ds = new DataSet();

            ad.Fill(ds);

            GridView1.DataSource = ds;
            GridView1.DataBind();

            radio.Fill(ds);
            RadioButtonList1.DataSource = ds;
            RadioButtonList1.DataBind();

            check.Fill(ds);
            CheckBoxList1.DataSource = ds;
            CheckBoxList1.DataBind();

            dplist.Fill(ds);
            DropDownList1.DataSource = ds;
            DropDownList1.DataBind();

        }
    }
}