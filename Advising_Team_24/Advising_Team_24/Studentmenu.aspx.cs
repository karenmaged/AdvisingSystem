using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Advising_Team_24
{
    public partial class Studentmenu : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("PhoneNo.aspx");
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("OptionalCourses.aspx");
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            Response.Redirect("AvailableCourses.aspx");
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            Response.Redirect("RequiredCourses.aspx");
        }

        protected void Button5_Click(object sender, EventArgs e)
        {
            Response.Redirect("MissingCourses.aspx");
        }

        protected void Button6_Click(object sender, EventArgs e)
        {
            Response.Redirect("CourseRequest.aspx");
        }

        protected void Button7_Click(object sender, EventArgs e)
        {
            Response.Redirect("CHRequest.aspx");
        }
		protected void Button8_Click(object sender, EventArgs e)
		{
			Response.Redirect("firstmakeup.aspx");
		}
		protected void Button9_Click(object sender, EventArgs e)
		{
			Response.Redirect("secondmakeup.aspx");
		}
		protected void Button10_Click(object sender, EventArgs e)
		{
			Response.Redirect("courseinfo.aspx");
		}
		protected void Button11_Click(object sender, EventArgs e)
		{
			Response.Redirect("c_prerequisites.aspx");
		}

		protected void Button12_Click(object sender, EventArgs e)
		{
			Response.Redirect("choose_instructor.aspx");
		}

		protected void Button13_Click(object sender, EventArgs e)
		{
            Response.Redirect("courses_exams.aspx");
		}

		protected void Button14_Click(object sender, EventArgs e)
		{
            Response.Redirect("courseslotinstr.aspx");
		}

		protected void Button15_Click(object sender, EventArgs e)
		{
			Response.Redirect("gradplan.aspx");
		}

		protected void Button16_Click(object sender, EventArgs e)
		{
            Response.Redirect("installment.aspx");
		}

		protected void Button21_Click(object sender, EventArgs e)
		{
			Response.Redirect("Studentlogin.aspx");
		}
	}
}