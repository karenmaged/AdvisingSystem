using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Advising_Team_24
{
	public partial class courses_exams : System.Web.UI.Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{
			string connstring = WebConfigurationManager.ConnectionStrings["Advising_System"].ToString();
			SqlConnection conn = new SqlConnection(connstring);
			SqlCommand ce = new SqlCommand("select * from Courses_MakeupExams", conn);
			ce.CommandType = System.Data.CommandType.Text;
			//gp.Parameters.Add(new SqlParameter("@student_ID", 6));
			conn.Open();
			SqlDataReader dr = ce.ExecuteReader(CommandBehavior.CloseConnection);
			while (dr.Read())
			{
				int examid = dr.GetInt32(dr.GetOrdinal("exam_id"));
				DateTime edate = dr.GetDateTime(dr.GetOrdinal("date"));
				String type = dr.GetString(dr.GetOrdinal("type"));
				int courseid = dr.GetInt32(dr.GetOrdinal("course_id"));
				String cname = dr.GetString(dr.GetOrdinal("name"));
				int sem = dr.GetInt32(dr.GetOrdinal("semester"));

				Label l_examid = new Label();
				l_examid.Text = "Exam ID: " + examid.ToString();
				this.Controls.Add(l_examid);
				this.Controls.Add(new LiteralControl("<br>"));
				Label l_edate = new Label();
				l_edate.Text = "Exam Date: " + edate.ToString();
				this.Controls.Add(l_edate);
				this.Controls.Add(new LiteralControl("<br>"));
				Label l_type = new Label();
				l_type.Text = "Exam Type: " + type;
				this.Controls.Add(l_type);
				this.Controls.Add(new LiteralControl("<br>"));
				Label l_courseid = new Label();
				l_courseid.Text = "Course ID: " + courseid.ToString();
				this.Controls.Add(l_courseid);
				this.Controls.Add(new LiteralControl("<br>"));
				Label l_cname = new Label();
				l_cname.Text = "Course Name: " + cname;
				this.Controls.Add(l_cname);
				this.Controls.Add(new LiteralControl("<br>"));
				Label l_sem = new Label();
				l_sem.Text = "Semester: " + sem.ToString();
				this.Controls.Add(l_sem);
				this.Controls.Add(new LiteralControl("<br>"));
				Label line = new Label();
				line.Text = "____________________";
				this.Controls.Add(line);
				this.Controls.Add(new LiteralControl("<br>"));


			}
			conn.Close();
		}

		protected void mainmenu_Click(object sender, EventArgs e)
		{
			Response.Redirect("Studentmenu.aspx");
		}
	}
}