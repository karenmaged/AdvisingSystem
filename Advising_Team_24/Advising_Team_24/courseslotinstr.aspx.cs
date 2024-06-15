using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml.Linq;

namespace Advising_Team_24
{
	public partial class courseslotinstr : System.Web.UI.Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{
			string connstring = WebConfigurationManager.ConnectionStrings["Advising_System"].ToString();
			SqlConnection conn = new SqlConnection(connstring);
			SqlCommand csi = new SqlCommand("select * from Courses_Slots_Instructor", conn);
			csi.CommandType = System.Data.CommandType.Text;
			conn.Open();
			SqlDataReader dr = csi.ExecuteReader(CommandBehavior.CloseConnection);
			while (dr.Read())
			{
				int cid = dr.GetInt32(dr.GetOrdinal("CourseID"));
				String course = dr.GetString(dr.GetOrdinal("Course"));
				int sid = dr.GetInt32(dr.GetOrdinal("slot_id"));
				String day = dr.GetString(dr.GetOrdinal("day"));
				String slot = dr.GetString(dr.GetOrdinal("time"));
				String loc = dr.GetString(dr.GetOrdinal("location"));
				int insid = dr.GetInt32(dr.GetOrdinal("instructor_id"));
				String ins = dr.GetString(dr.GetOrdinal("instructor"));

				Label l_cid = new Label();
				l_cid.Text = "Course ID: " + cid.ToString();
				this.Controls.Add(l_cid);
				this.Controls.Add(new LiteralControl("<br>"));
				Label l_course = new Label();
				l_course.Text = "Course Name: " + course;
				this.Controls.Add(l_course);
				this.Controls.Add(new LiteralControl("<br>"));
				Label l_sid = new Label();
				l_sid.Text = "Slot ID: " + sid.ToString();
				this.Controls.Add(l_sid);
				this.Controls.Add(new LiteralControl("<br>"));
				Label l_day = new Label();
				l_day.Text = "Day: " + day;
				this.Controls.Add(l_day);
				this.Controls.Add(new LiteralControl("<br>"));
				Label l_slot = new Label();
				l_slot.Text = "Time: " + slot;
				this.Controls.Add(l_slot);
				this.Controls.Add(new LiteralControl("<br>"));
				Label l_loc = new Label();
				l_loc.Text = "Location: " + loc;
				this.Controls.Add(l_loc);
				this.Controls.Add(new LiteralControl("<br>"));
				Label l_insid = new Label();
				l_insid.Text = "Instructor ID: " + insid.ToString();
				this.Controls.Add(l_insid);
				this.Controls.Add(new LiteralControl("<br>"));
				Label l_ins = new Label();
				l_ins.Text = "Instructor: " + ins;
				this.Controls.Add(l_ins);
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