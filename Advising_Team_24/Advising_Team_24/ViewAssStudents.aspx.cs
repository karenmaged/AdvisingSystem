using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Security.Cryptography;

namespace Advising_Team_24
{
    public partial class ViewAssStudents : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            



                


        }

        protected void Enter_maj(object sender, EventArgs e)
        {
            string connStr = WebConfigurationManager.ConnectionStrings["Advising_System"].ToString();
            SqlConnection conn = new SqlConnection(connStr);


            String temp = Session["user"] as String;
            String Major = majjj.Text;


            SqlCommand ViewS = new SqlCommand("Procedures_AdvisorViewAssignedStudents", conn);
            ViewS.CommandType = CommandType.StoredProcedure;
            ViewS.Parameters.Add(new SqlParameter("@AdvisorID", temp));
            ViewS.Parameters.Add(new SqlParameter("@major", Major));



            conn.Open();
            SqlDataReader read = ViewS.ExecuteReader();
            while (read.Read())
            {
                String maj = read.GetString(read.GetOrdinal("major"));
                // int Aid = read.GetInt32(read.GetOrdinal("advisor_id"));


                int sid = read.GetInt32(read.GetOrdinal("student_id"));
                Label student_id = new Label();
                student_id.Text = "Student ID: " + sid + "";
                form1.Controls.Add(student_id);
                form1.Controls.Add(new LiteralControl("<br>"));

                String Sname = read.GetString(read.GetOrdinal("Student_name"));
                Label Student_name = new Label();
                Student_name.Text = "Student Name: " + Sname + " ";
                form1.Controls.Add(Student_name);
                form1.Controls.Add(new LiteralControl("<br>"));

                //String maj = read.GetString(read.GetOrdinal("major"));
                //Label major = new Label();
                //major.Text = "Student Major: " + maj + " ";
                // form1.Controls.Add(major);
                //form1.Controls.Add(new LiteralControl("<br>"));

                String courseN = read.GetString(read.GetOrdinal("Course_name"));
                Label Course_name = new Label();
                Course_name.Text = "Course Name: " + courseN + " ";
                form1.Controls.Add(Course_name);
                form1.Controls.Add(new LiteralControl("<br>"));
                Label l1 = new Label();
                l1.Text = "-----------------------------------------------------";
                form1.Controls.Add(l1);
                form1.Controls.Add(new LiteralControl("<br>"));

            }

            }
		protected void Button2_Click(object sender, EventArgs e)
		{
			Response.Redirect("Advisor_menu.aspx");
		}
	}
}