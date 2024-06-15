using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.Services.Description;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Advising_Team_24
{
    public partial class DeleteCourseinGP : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {

                string connStr = WebConfigurationManager.ConnectionStrings["Advising_System"].ToString();
                SqlConnection conn = new SqlConnection(connStr);

                SqlCommand DeletCourse = new SqlCommand("SELECT student_id FROM Student");
                DeletCourse.CommandType = CommandType.Text;
                DeletCourse.Connection = conn;
                conn.Open();

                StudentDropDown3.DataSource = DeletCourse.ExecuteReader();
                StudentDropDown3.DataTextField = "student_id";
                StudentDropDown3.DataValueField = "student_id";
                StudentDropDown3.DataBind();

                StudentDropDown3.Items.Insert(0, new ListItem("Select Student", "Select Student"));
                conn.Close();

                SqlCommand DeletCourse1 = new SqlCommand("SELECT semester_code FROM Semester");
                DeletCourse1.CommandType = CommandType.Text;
                DeletCourse1.Connection = conn;
                conn.Open();


                SemDropDown2.DataSource = DeletCourse1.ExecuteReader();
                SemDropDown2.DataTextField = "semester_code";
                SemDropDown2.DataValueField = "semester_code";
                SemDropDown2.DataBind();

                SemDropDown2.Items.Insert(0, new ListItem("Select Semester code", "Select Semseter code"));
                conn.Close();


                SqlCommand DeletCourse2 = new SqlCommand("SELECT course_id, name FROM Course");
                DeletCourse2.CommandType = CommandType.Text;
                DeletCourse2.Connection = conn;
                conn.Open();
                CourseDropd.DataSource = DeletCourse2.ExecuteReader();
                CourseDropd.DataTextField = "name";
                CourseDropd.DataValueField = "course_id";
                CourseDropd.DataBind();

                CourseDropd.Items.Insert(0, new ListItem("Select Course", "Select Course"));

                conn.Close();

            }
        }

        protected void Delete_Course(object sender, EventArgs e)
        {
            if (!(CourseDropd.SelectedValue == "Select Course") && !(StudentDropDown3.SelectedValue=="Select Student") && !(SemDropDown2.SelectedValue=="Select Semester code"))
            {

                string connStr = WebConfigurationManager.ConnectionStrings["Advising_System"].ToString();
                SqlConnection conn = new SqlConnection(connStr);



                String StudentID = StudentDropDown3.SelectedValue;
                String Semcode = SemDropDown2.SelectedValue;
                String Cid = CourseDropd.SelectedValue;

                SqlCommand check = new SqlCommand("select count(*) from GradPlan_Course where " +
           "course_id = @cID", conn);
                check.Parameters.Add(new SqlParameter("@cID", int.Parse(Cid)));
                conn.Open();
                int rem = (int)check.ExecuteScalar();
                conn.Close();
                String msg;
                if (rem == 0)
                {
                    msg = "Course Does not exist in Plan!";
                }
                else
                {
                    msg = "Course was successfully deleted from plan!";
                }
                Label l1 = new Label();
                l1.Text = msg;
                this.Controls.Add(l1);

                SqlCommand DeleteC1 = new SqlCommand("Procedures_AdvisorDeleteFromGP", conn);
                DeleteC1.CommandType = CommandType.StoredProcedure;



                DeleteC1.Parameters.Add(new SqlParameter("@studentID", StudentID));
                DeleteC1.Parameters.Add(new SqlParameter("@sem_code", Semcode));
                DeleteC1.Parameters.Add(new SqlParameter("@courseID", Cid));
                conn.Open();
                

                
                DeleteC1.ExecuteNonQuery();
                conn.Close();



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