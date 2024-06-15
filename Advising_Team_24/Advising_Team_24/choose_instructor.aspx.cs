using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Runtime.InteropServices;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Advising_Team_24
{
	public partial class choose_instructor : System.Web.UI.Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{
			if (!IsPostBack)
			{

				string connstring = WebConfigurationManager.ConnectionStrings["Advising_System"].ToString();
				SqlConnection conn = new SqlConnection(connstring);
				SqlCommand i = new SqlCommand("select instructor_id, name from Instructor", conn);
				i.CommandType = System.Data.CommandType.Text;
				conn.Open();
				ddm_i.DataSource = i.ExecuteReader();
				ddm_i.DataTextField = "name";
				ddm_i.DataValueField = "instructor_id";
				ddm_i.DataBind();
				conn.Close();
				ddm_i.Items.Insert(0, new ListItem("Select Instructor", "Select Instructor"));

				SqlCommand c = new SqlCommand("select course_id, name from Course", conn);
				c.CommandType = System.Data.CommandType.Text;
				conn.Open();
				ddm_c.DataSource = c.ExecuteReader();
				ddm_c.DataTextField = "name";
				ddm_c.DataValueField = "course_id";
				ddm_c.DataBind();
				conn.Close();
				ddm_c.Items.Insert(0, new ListItem("Select Course", "Select Course"));

				SqlCommand s = new SqlCommand("select semester_code from Semester", conn);
				s.CommandType = System.Data.CommandType.Text;
				conn.Open();
				ddm_s.DataSource = s.ExecuteReader();
				ddm_s.DataTextField = "semester_code";
				ddm_s.DataValueField = "semester_code";
				ddm_s.DataBind();
				conn.Close();
				ddm_s.Items.Insert(0, new ListItem("Select Semester", "Select Semester"));


			}

		}

		public void b_click(object sender, EventArgs e)
		{
			string connstring = WebConfigurationManager.ConnectionStrings["Advising_System"].ToString();
			SqlConnection conn = new SqlConnection(connstring);
			String chosen_i = ddm_i.SelectedValue;
			String chosen_c = ddm_c.SelectedValue;
			String chosen_s = ddm_s.SelectedValue;
			if (string.Equals(chosen_c, "Select Course", StringComparison.OrdinalIgnoreCase))
			{
				Response.Write("Please choose a course");
			}
			else if (string.Equals(chosen_s, "Select Semester", StringComparison.OrdinalIgnoreCase))
			{
				Response.Write("Please choose a semester");
			}
			else if (string.Equals(chosen_i, "Select Instructor", StringComparison.OrdinalIgnoreCase))
			{
				Response.Write("Please choose an instructor");
			}
			else
			{


				SqlCommand ci = new SqlCommand("Procedures_Chooseinstructor", conn);
				ci.Parameters.Add(new SqlParameter("@StudentID", 5));
				ci.Parameters.Add(new SqlParameter("@instrucorID", int.Parse(chosen_i)));
				ci.Parameters.Add(new SqlParameter("@CourseID", int.Parse(chosen_c)));
				ci.Parameters.Add(new SqlParameter("@current_semester_code", chosen_s));
				ci.CommandType = System.Data.CommandType.StoredProcedure;
				conn.Open();
				ci.ExecuteNonQuery();
				conn.Close();
				String temp = Session["user"] as String;
				SqlCommand check = new SqlCommand("select count(*) from Student_Instructor_Course_Take where " +
					"student_id = @s_id and course_id = @c_id and semester_code = @sc", conn);
				check.Parameters.Add(new SqlParameter("@s_id", temp));
				check.Parameters.Add(new SqlParameter("@c_id", int.Parse(chosen_c)));
				check.Parameters.Add(new SqlParameter("@sc", chosen_s));
				conn.Open();
				int result = (int)check.ExecuteScalar();
				conn.Close();
				String message;
				if (result == 0)
				{
					message = "You cannot choose this instructor as you do not take this course in this semester";
				}
				else
				{
					message = "Instructor successfully chosen";
				}
				Label l_message = new Label();
				l_message.Text = message;
				this.Controls.Add(l_message);
			}

		}

		protected void mainmenu_Click(object sender, EventArgs e)
		{
			Response.Redirect("Studentmenu.aspx");
		}

		
	}
}