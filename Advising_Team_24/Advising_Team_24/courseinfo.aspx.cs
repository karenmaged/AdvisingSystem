using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Advising_Team_24
{
	public partial class courseinfo : System.Web.UI.Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{
			if (!IsPostBack)
			{
				string connstring = WebConfigurationManager.ConnectionStrings["Advising_System"].ToString();
				SqlConnection conn = new SqlConnection(connstring);
				SqlCommand i = new SqlCommand("select instructor_id , name from Instructor", conn);
				i.CommandType = System.Data.CommandType.Text;
				conn.Open();
				alo2.DataSource = i.ExecuteReader();
				alo2.DataTextField = "name";
				alo2.DataValueField = "instructor_id";
				alo2.DataBind();
				conn.Close();
				alo2.Items.Insert(0, new ListItem("Select Instructor", "Select Instructor"));

				SqlCommand c = new SqlCommand("select course_id, name from Course", conn);
				c.CommandType = System.Data.CommandType.Text;
				conn.Open();
				alo1.DataSource = c.ExecuteReader();
				alo1.DataTextField = "name";
				alo1.DataValueField = "course_id";
				alo1.DataBind();
				conn.Close();
				alo1.Items.Insert(0, new ListItem("Select Course", "Select Course"));
			}
		}

		public void b_click(object sender, EventArgs e)
		{
			string connstring = WebConfigurationManager.ConnectionStrings["Advising_System"].ToString();
			SqlConnection conn = new SqlConnection(connstring);
			String  chosen_i = alo2.SelectedValue;
			String chosen_c = alo1.SelectedValue;
			if (string.Equals(chosen_c, "Select Course", StringComparison.OrdinalIgnoreCase))
			{
				Response.Write("Please choose a course");
			}
			else if (string.Equals(chosen_i, "Select Instructor", StringComparison.OrdinalIgnoreCase))
			{
				Response.Write("Please choose an instructor");
			}
			else
			{
				//String studentid = Session["user"] as string;
				SqlCommand c_info = new SqlCommand("select * from FN_StudentViewSlot(@CourseID, @InstructorID)", conn);
				c_info.CommandType = System.Data.CommandType.Text;
				c_info.Parameters.Add(new SqlParameter("@CourseID", chosen_c));
				c_info.Parameters.Add(new SqlParameter("@InstructorID", chosen_i));
				conn.Open();
				SqlDataReader dr = c_info.ExecuteReader(CommandBehavior.CloseConnection);
				while (dr.Read())
				{
					int cid = dr.GetInt32(dr.GetOrdinal("CourseID"));
					String course = dr.GetString(dr.GetOrdinal("Course"));
					int sid = dr.GetInt32(dr.GetOrdinal("slot_id"));

					String day = dr.GetString(dr.GetOrdinal("day"));
					String slot = dr.GetString(dr.GetOrdinal("time"));
					String loc = dr.GetString(dr.GetOrdinal("location"));
					int insid = dr.GetInt32(dr.GetOrdinal("instructor_id"));
					//int ccid = dr.GetInt32(dr.GetOrdinal("course_id"));
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
                    line.Text = "________";
                    this.Controls.Add(line);
                    this.Controls.Add(new LiteralControl("<br>"));

                }

				conn.Close();
			}
		}

		protected void mainmenu_Click(object sender, EventArgs e)
		{
			Response.Redirect("Studentmenu.aspx");
		}
	}
}