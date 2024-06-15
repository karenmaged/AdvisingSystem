using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Advising_Team_24
{
    public partial class Advisor_menu : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("InsertGradplan.aspx");

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("InsertcourseinGP.aspx");
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            Response.Redirect("DeleteCourseinGP.aspx");
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            Response.Redirect("UpdateGdate.aspx");
        }

        protected void Button5_Click(object sender, EventArgs e)
        {
            Response.Redirect("ViewADstudent.aspx");
        }

        protected void Button6_Click(object sender, EventArgs e)
        {
            Response.Redirect("ViewPendingReq.aspx");
        }

        protected void Button7_Click(object sender, EventArgs e)
        {
            Response.Redirect("ViewallReqs.aspx");
        }

        protected void Button8_Click(object sender, EventArgs e)
        {
            Response.Redirect("ViewAssStudents.aspx");
        }

        protected void Button9_Click(object sender, EventArgs e)
        {
            Response.Redirect("CHApproveReject.aspx");
        }
        protected void Button10_Click(object sender, EventArgs e)
        {
            Response.Redirect("ApproveRejectCourse.aspx");
        }

		protected void Button21_Click(object sender, EventArgs e)
		{
			Response.Redirect("Studentlogin.aspx");
		}
	}
}