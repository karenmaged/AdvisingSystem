using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Advising_Team_24
{
    public partial class ViewSemesterCourse : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {


            string connStr = WebConfigurationManager.ConnectionStrings["Advising_System"].ToString();
            SqlConnection conn = new SqlConnection(connStr);
            SqlCommand SemCourseView = new SqlCommand("SELECT * FROM Semster_offered_Courses", conn);
            SemCourseView.CommandType = System.Data.CommandType.Text;
            conn.Open();
            SqlDataReader rdr = SemCourseView.ExecuteReader();

            if (rdr.HasRows)
            {
                while (rdr.Read())
                {

                    int course_id = rdr.GetInt32(rdr.GetOrdinal("course_id"));
                    Label courseID = new Label();
                    courseID.Text = "Course ID: " + course_id + " ";
                    form1.Controls.Add(courseID);
                    form1.Controls.Add(new LiteralControl("<br>"));


                    String name = rdr.GetString(rdr.GetOrdinal("name"));
                    Label CourseName = new Label();
                    CourseName.Text = "Name: " + name + " ";
                    form1.Controls.Add(CourseName);
                    form1.Controls.Add(new LiteralControl("<br>"));

                    String semester_code = rdr.GetString(rdr.GetOrdinal("semester_code"));
                    Label semCode = new Label();
                    semCode.Text = "Semester Code: " + semester_code + " ";
                    form1.Controls.Add(semCode);
                    form1.Controls.Add(new LiteralControl("<br>"));

                    Label line = new Label();
                    line.Text = "-----------------------------------------------------------";

                    form1.Controls.Add(line);
                    form1.Controls.Add(new LiteralControl("<br>"));

                }
            }
            
            Response.Write("Procedure Successful");
            conn.Close();

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("adminhome.aspx");
        }
    }
}