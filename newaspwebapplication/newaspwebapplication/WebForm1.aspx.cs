using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace newaspwebapplication
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void main_display_Click(object sender, EventArgs e)
        {
            DataClasses1DataContext LTS = new DataClasses1DataContext
                (@"Data Source=Lab-Host\SQLEXPRESS03; Initial Catalog=EYdatabase; Integrated Security=True");

            var selectQuery = from s in LTS.studentmarks
                              select s;

          //  DataSet ds = new DataSet();
           // selectQuery.Fill(ds);
            main_gridview.DataSource = selectQuery;
            main_gridview.DataBind();


            //main_gridview.DataSource
        }

        protected void main_insert_Click(object sender, EventArgs e)
        {
            panel_insert.Visible = true;
            panel_update.Visible = false;
            panel_delete.Visible = false;

        }

        protected void main_update_Click(object sender, EventArgs e)
        {
            panel_insert.Visible = false;
            panel_update.Visible = true;
            panel_delete.Visible = false;

        }

        protected void main_delete_Click(object sender, EventArgs e)
        {
            panel_insert.Visible = false;
            panel_update.Visible = false;
            panel_delete.Visible = true;

        }

        protected void insert_button_Click(object sender, EventArgs e)
        {
            DataClasses1DataContext LTS = new DataClasses1DataContext
                (@"Data Source=Lab-Host\SQLEXPRESS03; Initial Catalog=EYdatabase; Integrated Security=True");

            studentmark obj = new studentmark();

            // obj.id = p.id;
            obj.stud_name = insert_studname_textbox.Text;
            obj.sub_name = insert_subname_textbox.Text;
            obj.marks = int.Parse(insert_marks_textbox.Text);

            LTS.studentmarks.InsertOnSubmit(obj);
            LTS.SubmitChanges();

            insert_display_label.Text = "Inserted Successfully";
            insert_display_label.Visible = true;



        }

        protected void update_button_Click(object sender, EventArgs e)
        {
            DataClasses1DataContext LTS = new DataClasses1DataContext
               (@"Data Source=Lab-Host\SQLEXPRESS03; Initial Catalog=EYdatabase; Integrated Security=True");


            var updateres = from s in LTS.studentmarks
                            where s.id == int.Parse(update_id_textbox.Text)
                            select s;

            //studentmark obj = new studentmark();

            // obj.id = p.id;
            foreach (var i in updateres)
            {
                i.stud_name = update_studname_textbox.Text;
                i.sub_name = update_subname_textbox.Text;
                i.marks = int.Parse(update_marks_textbox.Text);
            }

            //LTS.studentmarks.InsertOnSubmit(obj);
            LTS.SubmitChanges();
            update_display_label.Text = "Update Successfully";
            update_display_label.Visible = true;

        }

        protected void delete_button_Click(object sender, EventArgs e)
        {
            DataClasses1DataContext LTS = new DataClasses1DataContext
               (@"Data Source=Lab-Host\SQLEXPRESS03; Initial Catalog=EYdatabase; Integrated Security=True");

            studentmark obj = new studentmark();

            var deleterow = from s in LTS.studentmarks
                            where s.id == int.Parse(delete_id_textbox.Text)
                            select s;

            //LTS.studentmarks.Attach(obj);
            LTS.studentmarks.DeleteAllOnSubmit(deleterow);
            LTS.SubmitChanges();

            delete_display_label.Text = "Deleted Successfully";
            delete_display_label.Visible = true;
        }
    }
}