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
    public partial class Semster_offered_Courses : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string connstr = WebConfigurationManager.ConnectionStrings["Advising_System"].ToString();
            SqlConnection conn = new SqlConnection(connstr);

            SqlCommand requests = new SqlCommand("SELECT* FROM Semster_offered_Courses", conn);
            requests.CommandType = CommandType.Text;

            conn.Open();
            SqlDataReader rdr = requests.ExecuteReader(CommandBehavior.CloseConnection);

            while (rdr.Read())
            {
                int courseID = rdr.GetInt32(rdr.GetOrdinal("course_id"));
                Label CID = new Label();
                CID.Text = courseID + "<br >";
                CID.CssClass = "newlabel";
                form1.Controls.Add(CID);

                String Cname = rdr.GetString(rdr.GetOrdinal("name"));
                Label Name = new Label();
                Name.Text = Cname + "<br >";
                Name.CssClass = "newlabel";
                form1.Controls.Add(Name);

                
                String semCode = rdr.GetString(rdr.GetOrdinal("semester_code"));
                Label code = new Label();
                code.Text = semCode + "<br >";
                code.CssClass = "newlabel";
                form1.Controls.Add(code);

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