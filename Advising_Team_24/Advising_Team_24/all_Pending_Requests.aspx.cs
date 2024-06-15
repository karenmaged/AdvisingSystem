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
    public partial class all_Pending_Requests : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string connstr = WebConfigurationManager.ConnectionStrings["Advising_System"].ToString();
            SqlConnection conn = new SqlConnection(connstr);

            SqlCommand requests = new SqlCommand("SELECT* FROM all_Pending_Requests", conn);
            requests.CommandType = CommandType.Text;

            conn.Open();
            SqlDataReader rdr = requests.ExecuteReader(CommandBehavior.CloseConnection);

            //status varchar (40) default 'pending',
            //credit_hours int,
            //student_id int ,
            //advisor_id 
            //course_id
            while (rdr.Read())
            {
                int requestID = rdr.GetInt32(rdr.GetOrdinal("request_id"));
                Label ID = new Label();
                ID.Text = requestID + "<br >";
                ID.CssClass = "newlabel";
                form1.Controls.Add(ID);

                String requestType = rdr.GetString(rdr.GetOrdinal("type"));
                Label type = new Label();
                type.Text = requestType + "<br >";
                type.CssClass = "newlabel";
                form1.Controls.Add(type);

                String requestComment = rdr.GetString(rdr.GetOrdinal("comment"));
                Label comment = new Label();
                comment.Text = requestComment + "<br >";
                comment.CssClass = "newlabel";
                form1.Controls.Add(comment);

                String requestStatus = rdr.GetString(rdr.GetOrdinal("status"));
                Label status = new Label();
                status.Text = requestStatus + "<br >";
                status.CssClass = "newlabel";
                form1.Controls.Add(status);


                int creditHoursIndex = rdr.GetOrdinal("credit_hours");

                if (!rdr.IsDBNull(creditHoursIndex))
                {

                    int creditHours = rdr.GetInt32(rdr.GetOrdinal("credit_hours"));
                    Label CH = new Label();
                    CH.Text = creditHours + "<br >";
                    CH.CssClass = "newlabel";
                    form1.Controls.Add(CH);

                }
                else
                {
                    Label CH = new Label();
                    CH.Text = "NULL"+"<br >"; 
                    CH.CssClass = "newlabel";
                    form1.Controls.Add(CH);
                }


                int CourseIDIndex = rdr.GetOrdinal("course_id");

                if (!rdr.IsDBNull(CourseIDIndex))
                {
                    int courseID = rdr.GetInt32(rdr.GetOrdinal("course_id"));
                    Label CID = new Label();
                    CID.Text = courseID + "<br >";
                    CID.CssClass = "newlabel";
                    form1.Controls.Add(CID);
                }
                else
                {
                    Label CID = new Label();
                    CID.Text = "NULL" + "<br >";
                    CID.CssClass = "newlabel";
                    form1.Controls.Add(CID);

                }

                int StudentId = rdr.GetInt32(rdr.GetOrdinal("student_id"));
                Label SID = new Label();
                SID.Text = StudentId + "<br >";
                SID.CssClass = "newlabel";
                form1.Controls.Add(SID);

                int advisorID = rdr.GetInt32(rdr.GetOrdinal("advisor_id"));
                Label AID = new Label();
                AID.Text = advisorID + "<br >";
                AID.CssClass = "newlabel";
                form1.Controls.Add(AID);


               
                    

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