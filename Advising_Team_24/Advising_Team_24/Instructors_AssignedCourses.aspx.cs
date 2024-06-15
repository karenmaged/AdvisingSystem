using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Net.NetworkInformation;

namespace Advising_Team_24
{
    public partial class Instructors_AssignedCourses : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string connstr = WebConfigurationManager.ConnectionStrings["Advising_System"].ToString();
            SqlConnection conn = new SqlConnection(connstr);

            SqlCommand requests = new SqlCommand("SELECT* FROM Instructors_AssignedCourses", conn);
            requests.CommandType = CommandType.Text;

            conn.Open();
            SqlDataReader rdr = requests.ExecuteReader(CommandBehavior.CloseConnection);

            while (rdr.Read())
            {
                int instrucrorID = rdr.GetInt32(rdr.GetOrdinal("instructor_id"));
                Label ID = new Label();
                ID.Text = instrucrorID + "<br >";
                ID.CssClass = "newlabel";
                form1.Controls.Add(ID);

                String instrucrorName = rdr.GetString(rdr.GetOrdinal("Instructor"));
                Label name = new Label();
                name.Text = instrucrorName + "<br >";
                name.CssClass = "newlabel";
                form1.Controls.Add(name);

                int courseID = rdr.GetInt32(rdr.GetOrdinal("course_id"));
                Label CID = new Label();
                CID.Text = courseID + "<br >";
                CID.CssClass = "newLabel";
                form1.Controls.Add(CID);

                String courseName = rdr.GetString(rdr.GetOrdinal("Course"));
                Label Cname = new Label();
                Cname.Text = courseName + "<br >";
                Cname.CssClass = "newlabel";
                form1.Controls.Add(Cname);


                String x = "/////////////////////////////";
                Label xx = new Label();
                xx.Text = x + "<br >";
                xx.CssClass = "newlabel";
                form1.Controls.Add(xx);

            }
            rdr.Close();
            conn.Close();
        }
		protected void Button2_Click(object sender, EventArgs e)
		{
			Response.Redirect("adminhome.aspx");
		}
	}
}