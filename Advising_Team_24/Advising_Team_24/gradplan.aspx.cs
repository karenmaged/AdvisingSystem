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
	public partial class WebForm1 : System.Web.UI.Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{

			string connstring = WebConfigurationManager.ConnectionStrings["Advising_System"].ToString();
			SqlConnection conn = new SqlConnection(connstring);
			String studentid = Session["user"] as String;
			SqlCommand gp = new SqlCommand("select * from FN_StudentViewGP(@student_ID)", conn);
			gp.CommandType = System.Data.CommandType.Text;
			gp.Parameters.Add(new SqlParameter("@student_ID", studentid));

			conn.Open();
			SqlDataReader dr = gp.ExecuteReader(CommandBehavior.CloseConnection);
			while (dr.Read())
			{
				String sname = dr.GetString(dr.GetOrdinal("Student_name"));
				int pid = dr.GetInt32(dr.GetOrdinal("plan_id"));
				String scode = dr.GetString(dr.GetOrdinal("semester_code"));
				int sch = dr.GetInt32(dr.GetOrdinal("semester_credit_hours"));
				DateTime gdate = dr.GetDateTime(dr.GetOrdinal("expected_grad_date"));
				int aid = dr.GetInt32(dr.GetOrdinal("advisor_id"));
				int sid = dr.GetInt32(dr.GetOrdinal("student_id"));
				int cid = dr.GetInt32(dr.GetOrdinal("course_id"));
				String cname = dr.GetString(dr.GetOrdinal("name"));

				Label l_sname = new Label();
				l_sname.Text = "Student Name: " + sname ;
				this.Controls.Add(l_sname);
				this.Controls.Add(new LiteralControl("<br>"));
				Label l_pid = new Label();
				l_pid.Text = "Plan ID: " + pid.ToString();
				this.Controls.Add(l_pid);
				this.Controls.Add(new LiteralControl("<br>"));
				Label l_scode = new Label();
				l_scode.Text = "Semester Code: " + scode;
				this.Controls.Add(l_scode);
				this.Controls.Add(new LiteralControl("<br>"));
				Label l_sch = new Label();
				l_sch.Text = "Semester Credit Hours: " + sch.ToString();
				this.Controls.Add(l_sch);
				this.Controls.Add(new LiteralControl("<br>"));
				Label l_date = new Label();
				l_date.Text = "Expected Graduation Date: " + gdate.ToString();
				this.Controls.Add(l_date);
				this.Controls.Add(new LiteralControl("<br>"));
				Label l_aid = new Label();
				l_aid.Text = "Advisor ID: " + aid.ToString();
				this.Controls.Add(l_aid);
				this.Controls.Add(new LiteralControl("<br>"));
				Label l_sid = new Label();
				l_sid.Text = "Student ID: " + sid.ToString();
				this.Controls.Add(l_sid);
				this.Controls.Add(new LiteralControl("<br>"));
				Label l_cid = new Label();
				l_cid.Text = "Course ID: " + cid.ToString();
				this.Controls.Add(l_cid);
				this.Controls.Add(new LiteralControl("<br>"));
				Label l_cname = new Label();
				l_cname.Text = "Course Name: " + cname;
				this.Controls.Add(l_cname);
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