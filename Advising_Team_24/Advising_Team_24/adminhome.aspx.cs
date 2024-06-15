using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Advising_Team_24
{
    public partial class adminhome : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("listAdvisors.aspx");
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("AdminListStudentsWithAdvisors.aspx");
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            Response.Redirect("all_Pending_Requests.aspx");
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            Response.Redirect("AdminAddingSemester.aspx");
        }

        protected void Button5_Click(object sender, EventArgs e)
        {
            Response.Redirect("AdminAddingCourse.aspx");
        }

        protected void Button6_Click(object sender, EventArgs e)
        {
            Response.Redirect("AdminLinkInstructor.aspx");
        }

        protected void Button7_Click(object sender, EventArgs e)
        {
            Response.Redirect("AdminLinkStudentToAdvisor.aspx"); //call Procedures_AdminLinkStudentToAdvisor
        }

        protected void Button8_Click(object sender, EventArgs e)
        {
            Response.Redirect("AdminLinkStudent.aspx");//call Procedures_AdminLinkStudent
        }

        protected void Button9_Click(object sender, EventArgs e)
        {
            Response.Redirect("Instructors_AssignedCourses.aspx");//call Instructors_AssignedCourses
        }

        protected void Button10_Click(object sender, EventArgs e)
        {
            Response.Redirect("Semster_offered_Courses.aspx");//callSemster_offered_Courses
        }

        protected void Button11_Click(object sender, EventArgs e)
        {
            Response.Redirect("AddMakeupExam.aspx");
        }
        protected void Button12_Click(object sender, EventArgs e)
        {
            Response.Redirect("DeleteCourse.aspx");
        }
        protected void Button13_Click(object sender, EventArgs e)
        {
            Response.Redirect("DeleteSlot.aspx");
        }
        protected void Button14_Click(object sender, EventArgs e)
        {
            Response.Redirect("IssueInstallments.aspx");
        }
        protected void Button15_Click(object sender, EventArgs e)
        {
            Response.Redirect("UpdateStudentStatus.aspx");
        }
        protected void Button16_Click(object sender, EventArgs e)
        {
            Response.Redirect("ViewActiveStudents.aspx");
        }
        protected void Button17_Click(object sender, EventArgs e)
        {
            Response.Redirect("ViewGradPlans.aspx");
        }
        protected void Button18_Click(object sender, EventArgs e)
        {
            Response.Redirect("ViewPayments.aspx");
        }
        protected void Button19_Click(object sender, EventArgs e)
        {
            Response.Redirect("ViewSemesterCourse.aspx");
        }
        protected void Button20_Click(object sender, EventArgs e)
        {
            Response.Redirect("ViewStudentTranscripts.aspx");
        }

		protected void Button21_Click(object sender, EventArgs e)
		{
			Response.Redirect("Studentlogin.aspx");
		}







	}
}