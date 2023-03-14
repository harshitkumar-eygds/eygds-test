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


            //  DataSet a1 = new DataSet();
            DataSet ds1 = new DataSet();
            radio.Fill(ds1);
            RadioButtonList1.DataSource = ds1;
            RadioButtonList1.DataTextField = "studid";
            RadioButtonList1.DataValueField = "studid";
            RadioButtonList1.DataBind();

            DataSet ds2 = new DataSet();
            check.Fill(ds2);
            CheckBoxList1.DataSource = ds2;
            CheckBoxList1.DataTextField = "sub_name";
            CheckBoxList1.DataValueField = "sub_name";
            CheckBoxList1.DataBind();

            DataSet ds3 = new DataSet();
            dplist.Fill(ds3);
            DropDownList1.DataSource = ds3;
            DropDownList1.DataTextField = "marks";
            DropDownList1.DataValueField = "marks";
            DropDownList1.DataBind();

        }
    }
}