using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Net;
using System.Security.Cryptography;

namespace Advising_Team_24
{
	public partial class c_prerequisites : System.Web.UI.Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{
			string connstring = WebConfigurationManager.ConnectionStrings["Advising_System"].ToString();
			SqlConnection conn = new SqlConnection(connstring);
			SqlCommand pre = new SqlCommand("select * from view_Course_prerequisites", conn);
			pre.CommandType = System.Data.CommandType.Text;
			conn.Open();
			SqlDataReader dr = pre.ExecuteReader(CommandBehavior.CloseConnection);
			while (dr.Read())
			{
				int cid = dr.GetInt32(dr.GetOrdinal("course_id"));
				String cname = dr.GetString(dr.GetOrdinal("name"));
				String major = dr.GetString(dr.GetOrdinal("major"));
				bool isoffered = dr.GetBoolean(dr.GetOrdinal("is_offered"));
				int ch = dr.GetInt32(dr.GetOrdinal("credit_hours"));
				int sem = dr.GetInt32(dr.GetOrdinal("semester"));
				int precid = dr.GetInt32(dr.GetOrdinal("preRequsite_course_id"));
				String precname = dr.GetString(dr.GetOrdinal("preRequsite_course_name"));

				Label l_cid = new Label();
				l_cid.Text = "Course ID: " + cid.ToString();
				this.Controls.Add(l_cid);
				this.Controls.Add(new LiteralControl("<br>"));
				Label l_cname = new Label();
				l_cname.Text = "Course Name: " + cname;
				this.Controls.Add(l_cname);
				this.Controls.Add(new LiteralControl("<br>"));
				Label l_major = new Label();
				l_major.Text = "Major: " + major;
				this.Controls.Add(l_major);
				this.Controls.Add(new LiteralControl("<br>"));
				Label l_isoffered = new Label();
				l_isoffered.Text = "Offered: " + isoffered;
				this.Controls.Add(l_isoffered);
				this.Controls.Add(new LiteralControl("<br>"));
				Label l_ch = new Label();
				l_ch.Text = "Credit Hours: " + ch.ToString();
				this.Controls.Add(l_ch);
				this.Controls.Add(new LiteralControl("<br>"));
				Label l_sem = new Label();
				l_sem.Text = "Semester: " + sem.ToString();
				this.Controls.Add(l_sem);
				this.Controls.Add(new LiteralControl("<br>"));
				Label l_precid = new Label();
				l_precid.Text = "Prerequisite Course ID: " + precid.ToString();
				this.Controls.Add(l_precid);
				this.Controls.Add(new LiteralControl("<br>"));
				Label l_precname = new Label();
				l_precname.Text = "Prerequisite Course Name: " + precname;
				this.Controls.Add(l_precname);
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