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
using System.Web.Caching;

namespace Advising_Team_24
{
    public partial class InsertCourseinGP : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                string connStr = WebConfigurationManager.ConnectionStrings["Advising_System"].ToString();
                SqlConnection conn = new SqlConnection(connStr);


                SqlCommand InsertCourseinGP = new SqlCommand("SELECT semester_code FROM Semester");
                InsertCourseinGP.CommandType = CommandType.Text;
                InsertCourseinGP.Connection = conn;
                conn.Open();
                SemDropDown1.DataSource = InsertCourseinGP.ExecuteReader();
                SemDropDown1.DataTextField = "semester_code";
                SemDropDown1.DataValueField = "semester_code";
                SemDropDown1.DataBind();

                SemDropDown1.Items.Insert(0, new ListItem("Select Semester code", "Select Semester code"));
                conn.Close();


                SqlCommand InsertCourseinGP1 = new SqlCommand("SELECT student_id FROM Student");
                InsertCourseinGP1.CommandType = CommandType.Text;
                InsertCourseinGP1.Connection = conn;
                conn.Open();
                StudentDropDown1.DataSource = InsertCourseinGP1.ExecuteReader();
                StudentDropDown1.DataTextField = "student_id";
                StudentDropDown1.DataValueField = "student_id";
                StudentDropDown1.DataBind();

                StudentDropDown1.Items.Insert(0, new ListItem("Select Student", "Select Student"));

                conn.Close();


                SqlCommand InsertCourseinGP2 = new SqlCommand("SELECT name,course_id FROM Course");
                InsertCourseinGP2.CommandType = CommandType.Text;
                InsertCourseinGP2.Connection = conn;
                conn.Open();
                CourseDropDown.DataSource = InsertCourseinGP2.ExecuteReader();
                CourseDropDown.DataTextField = "name";
                CourseDropDown.DataValueField = "course_id";
                CourseDropDown.DataBind();

                CourseDropDown.Items.Insert(0, new ListItem("Select Course", "Select Course"));

                conn.Close();

            }
        }

        protected void Submit_Course(object sender, EventArgs e)
        {
            if (!(CourseDropDown.SelectedValue == "Select Course") && !(StudentDropDown1.SelectedValue == "Select Student") && !(SemDropDown1.SelectedValue == "Select Semester code"))
            {


                string connStr = WebConfigurationManager.ConnectionStrings["Advising_System"].ToString();
                SqlConnection conn = new SqlConnection(connStr);

                String StudentId = StudentDropDown1.SelectedValue;
                String semcode1 = SemDropDown1.SelectedValue;
                String Cname = CourseDropDown.SelectedValue;

                SqlCommand submitCourse = new SqlCommand("Procedures_AdvisorAddCourseGP", conn);
                submitCourse.CommandType = CommandType.StoredProcedure;

                submitCourse.Parameters.Add(new SqlParameter("@student_id", StudentId));
                submitCourse.Parameters.Add(new SqlParameter("@Semester_code", semcode1));
                submitCourse.Parameters.Add(new SqlParameter("@course_name", Cname));

                conn.Open();
                submitCourse.ExecuteNonQuery();

                conn.Close();

                Response.Write("Course was inserted into Graduation plan successfully!");

            }
            else
            {
                Response.Write("Please insert all values!");
            }
        }

		protected void Button2_Click(object sender, EventArgs e)
		{
			Response.Redirect("Advisor_menu.aspx");
		}
	}
}
