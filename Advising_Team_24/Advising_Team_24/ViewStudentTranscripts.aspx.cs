using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Advising_Team_24
{
    public partial class ViewStudentTranscripts : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
            string connStr = WebConfigurationManager.ConnectionStrings["Advising_System"].ToString();
            SqlConnection conn = new SqlConnection(connStr);
            SqlCommand StudentTranscriptView = new SqlCommand("SELECT * FROM Students_Courses_transcript", conn);
            StudentTranscriptView.CommandType = System.Data.CommandType.Text;
            conn.Open();
            SqlDataReader rdr = StudentTranscriptView.ExecuteReader();

            if (rdr.HasRows)
            {
                while (rdr.Read())
                {

                    int studentID = rdr.GetInt32(rdr.GetOrdinal("student_id"));
                    Label thestudentID = new Label();
                    thestudentID.Text = "Student ID: " + studentID + "";
                    form1.Controls.Add(thestudentID);
                    form1.Controls.Add(new LiteralControl("<br>"));

                    String f_name = rdr.GetString(rdr.GetOrdinal("f_name"));
                    Label firstname = new Label();
                    firstname.Text = "First Name: " + f_name;
                    form1.Controls.Add(firstname);
                    form1.Controls.Add(new LiteralControl("<br>"));

                    String l_name = rdr.GetString(rdr.GetOrdinal("l_name"));
                    Label lastname = new Label();
                    lastname.Text = "Last Name: " + l_name;
                    form1.Controls.Add(lastname);
                    form1.Controls.Add(new LiteralControl("<br>"));

                    int course_id = rdr.GetInt32(rdr.GetOrdinal("course_id"));
                    Label courseID = new Label();
                    courseID.Text = "Course ID: " + course_id + "";
                    form1.Controls.Add(courseID);
                    form1.Controls.Add(new LiteralControl("<br>"));

                    String name = rdr.GetString(rdr.GetOrdinal("name"));
                    Label CourseName = new Label();
                    CourseName.Text = "Name: " + name;
                    form1.Controls.Add(CourseName);
                    form1.Controls.Add(new LiteralControl("<br>"));

                    String exam_type = rdr.GetString(rdr.GetOrdinal("exam_type"));
                    Label examType = new Label();
                    examType.Text = "Exam Type: " + exam_type;
                    form1.Controls.Add(examType);
                    form1.Controls.Add(new LiteralControl("<br>"));


                    int gradeOrdinal = rdr.GetOrdinal("grade");
                    if (!rdr.IsDBNull(gradeOrdinal))
                    {
                        string grade = rdr.GetString(gradeOrdinal);
                        Label Grade = new Label();
                        Grade.Text = "Grade: " + grade;
                        form1.Controls.Add(Grade);
                    }
                    else { 
                        Label grade = new Label();
                        grade.Text = "Grade: Null";
                        form1.Controls.Add(grade);
                    }
                    form1.Controls.Add(new LiteralControl("<br>"));





					String semester_code = rdr.GetString(rdr.GetOrdinal("semester_code"));
                    Label semCode = new Label();
                    semCode.Text = "Semester Code: " + semester_code;
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