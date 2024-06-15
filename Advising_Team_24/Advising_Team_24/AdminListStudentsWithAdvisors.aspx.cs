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
    public partial class AdminListStudentsWithAdvisors : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string connstr = WebConfigurationManager.ConnectionStrings["Advising_System"].ToString();
            SqlConnection conn = new SqlConnection(connstr);

            SqlCommand students = new SqlCommand("AdminListStudentsWithAdvisors", conn);
            students.CommandType = CommandType.StoredProcedure;

            conn.Open();
            SqlDataReader rdr = students.ExecuteReader(CommandBehavior.CloseConnection);
            //Select Student.student_id, Student.f_name, Student.l_name, Advisor.advisor_id, Advisor.advisor_name

            while (rdr.Read())
            {
                int StudentId = rdr.GetInt32(rdr.GetOrdinal("student_id"));
                Label ID = new Label();
                ID.Text = StudentId + "<br >";
                ID.CssClass = "newlabel";
                form1.Controls.Add(ID);

                String studentFName = rdr.GetString(rdr.GetOrdinal("f_name"));
                Label fname = new Label();
                fname.Text = studentFName + "<br >";
                fname.CssClass = "newlabel";
                form1.Controls.Add(fname);

                String studentLName = rdr.GetString(rdr.GetOrdinal("l_name"));
                Label lname = new Label();
                lname.Text = studentLName + "<br >";
                lname.CssClass = "newlabel";
                form1.Controls.Add(lname);

                int advisorID = rdr.GetInt32(rdr.GetOrdinal("advisor_id"));
                Label AID = new Label();
                AID.Text = advisorID + "<br >";
                AID.CssClass = "newlabel";
                form1.Controls.Add(AID);

                String advisorName = rdr.GetString(rdr.GetOrdinal("advisor_name"));
                Label Aname = new Label();
                Aname.Text = advisorName + "<br >";
                Aname.CssClass = "newlabel";
                form1.Controls.Add(Aname);

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