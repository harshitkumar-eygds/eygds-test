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

        protected void Calendar1_SelectionChanged(object sender, EventArgs e)
        {
            Label2.Text = "Selected Date is : " +  Calendar1.SelectedDate.Date.ToString();
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Calendar2.Visible = true;
            Calendar3.Visible = false;

        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            Calendar2.Visible = false;
            Calendar3.Visible = true;

        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        protected void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            DateTime cin = Calendar2.SelectedDate.Date;
            DateTime cout = Calendar3.SelectedDate.Date;
            if (cout >= cin)
            {
                var output = (cout - cin).Days;
                Label6.Text = $"You stayed from {cin.ToShortDateString()} to {cout.ToShortDateString()}. Your total stay is {output} ";
            }
            else 
            {
                Label6.Text = "Check IN date cannot be after Check OUT date. Please select dates again";
            }
        }

        protected void Calendar2_SelectionChanged(object sender, EventArgs e)
        {
            TextBox1.Text = Calendar2.SelectedDate.Date.ToShortDateString().ToString();
        }

        protected void Calendar3_SelectionChanged(object sender, EventArgs e)
        {
            TextBox2.Text = Calendar3.SelectedDate.Date.ToShortDateString().ToString();
        }

        protected void displayall_Click(object sender, EventArgs e)
        {
            SqlDataAdapter ad = new SqlDataAdapter("select * from subject2", con);

            DataSet ds = new DataSet();
            ad.Fill(ds);
            GridView2.DataSource = ds;
            GridView2.DataBind();
        }

        protected void ins_panel_Click(object sender, EventArgs e)
        {
            inspanel.Visible = true;
            delpanel.Visible = false;
            updpanel.Visible = false;
        }

        protected void del_panel_button_Click(object sender, EventArgs e)
        {
            inspanel.Visible = false;
            delpanel.Visible = true;
            updpanel.Visible = false;
        }

        protected void upd_panel_button_Click(object sender, EventArgs e)
        {
            inspanel.Visible = false;
            delpanel.Visible = false;
            updpanel.Visible = true;
        }

        protected void ins_data_button_Click(object sender, EventArgs e)
        {
            con.Open();
            int id = int.Parse(TextBox3.Text);
            string sub = TextBox4.Text;
            int marks = int.Parse(TextBox5.Text);
            SqlCommand cmd = new SqlCommand("insert into subject2(studid, sub_name, marks) values( '"+ id + "' , '" + sub + "'  , '" +marks + "' )", con);
            cmd.ExecuteNonQuery();

            //Response.Write("Inserted successfully");
            Label7.Text = "Inserted Successfully";
            Label7.Visible = true;
        }

        protected void del_data_button_Click(object sender, EventArgs e)
        {
            con.Open();
            int id = int.Parse(TextBox6.Text);
           // string sub = TextBox4.Text;
            //int marks = int.Parse(TextBox5.Text);
            SqlCommand cmd = new SqlCommand("Delete from subject2 where studid = '"+ id +"' ", con);
            cmd.ExecuteNonQuery();

            //Response.Write("Inserted successfully");
            Label8.Text = "Deleted Successfully";
            Label8.Visible = true;
        }

        protected void upd_data_button_Click(object sender, EventArgs e)
        {
            con.Open();
            int id = int.Parse(TextBox7.Text);
            string sub = TextBox8.Text;
            int marks = int.Parse(TextBox9.Text);
            SqlCommand cmd = new SqlCommand("Update subject2 SET marks = '"+ marks +"'  WHERE studid = '"+ id + "' AND sub_name = '" + sub + "' ", con);
            cmd.ExecuteNonQuery();

            //Response.Write("Inserted successfully");
            Label9.Text = "Updated Successfully";
            Label9.Visible = true;
        }

        protected void Button5_Click(object sender, EventArgs e)
        {
            con.Open();
            //int id = int.Parse(TextBox3.Text);
            //string sub = TextBox4.Text;
            //int marks = int.Parse(TextBox5.Text);
            SqlCommand cmd = new SqlCommand("insert into subject2(studid, sub_name, marks) values( 10,'sst',100 )", con);
            cmd.ExecuteNonQuery();

            //Response.Write("Inserted successfully");
            Label7.Text = "Inserted Hard Coded Successfully";
            Label7.Visible = true;

        }

        protected void Button6_Click(object sender, EventArgs e)
        {
            con.Open();
            //int id = int.Parse(TextBox6.Text);
            // string sub = TextBox4.Text;
            //int marks = int.Parse(TextBox5.Text);
            SqlCommand cmd = new SqlCommand("Delete from subject2 where studid = 10", con);
            cmd.ExecuteNonQuery();

            //Response.Write("Inserted successfully");
            Label8.Text = "Deleted Hard Coded Successfully";
            Label8.Visible = true;

        }

        protected void Button7_Click(object sender, EventArgs e)
        {
            con.Open();
            //int id = int.Parse(TextBox7.Text);
            //string sub = TextBox8.Text;
            //int marks = int.Parse(TextBox9.Text);
            SqlCommand cmd = new SqlCommand("Update subject2 SET marks = 88  WHERE studid = 1 AND sub_name = 'English' ", con);
            cmd.ExecuteNonQuery();

            //Response.Write("Inserted successfully");
            Label9.Text = "Updated Hard Coded Successfully";
            Label9.Visible = true;
        }

        protected void sql_reader_button_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from subject2",con);

            SqlDataReader rdr = cmd.ExecuteReader();
            sqlrdr_label.Text = "";


            while (rdr.Read()) 
            {
                //Response.Write(rdr["studid"] + " " + rdr["sub_name"] + " " + rdr["marks"]);
                sqlrdr_label.Text += rdr["studid"] + " " + rdr["sub_name"] + " " + rdr["marks"];
                sqlrdr_label.Visible = true;
            }
        }
    }
}