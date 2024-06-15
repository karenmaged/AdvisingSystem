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
    public partial class ViewallReqs : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            string connStr = WebConfigurationManager.ConnectionStrings["Advising_System"].ToString();
            SqlConnection conn = new SqlConnection(connStr);

            String temp = Session["user"] as String;

            SqlCommand ViewR = new SqlCommand("Select * From  FN_Advisors_Requests(@advisor_id)", conn);

            ViewR.CommandType = System.Data.CommandType.Text;
            ViewR.Parameters.Add(new SqlParameter("@advisor_id", 2));

            conn.Open();
            SqlDataReader rdr = ViewR.ExecuteReader(CommandBehavior.CloseConnection);
            while (rdr.Read())
            {
                int Aid = rdr.GetInt32(rdr.GetOrdinal("advisor_id"));
                

                if (Aid == int.Parse(temp))
                {
                    int reqID = rdr.GetInt32(rdr.GetOrdinal("request_id"));
                    Label request_id = new Label();
                    request_id.Text = "Request ID: " + reqID;
                    form1.Controls.Add(request_id);
                    form1.Controls.Add(new LiteralControl("<br>"));


                    String Type = rdr.GetString(rdr.GetOrdinal("type"));
                    Label type = new Label();
                    type.Text = "Request Type: " + Type;
                    form1.Controls.Add(type);
                    form1.Controls.Add(new LiteralControl("<br>"));



                    String Com = rdr.GetString(rdr.GetOrdinal("comment"));
                    Label comment = new Label();
                    comment.Text = "Comment: " + Com;
                    form1.Controls.Add(comment);
                    form1.Controls.Add(new LiteralControl("<br>"));


                    String ST = rdr.GetString(rdr.GetOrdinal("status"));
                    Label status = new Label();
                    status.Text = "Request Status: " + ST;
                    form1.Controls.Add(status);
                    form1.Controls.Add(new LiteralControl("<br>"));


                    int CreditHrs = rdr.GetOrdinal("credit_hours");
                    if (!rdr.IsDBNull(CreditHrs))
                    {
                        int creditHrs = rdr.GetInt32(rdr.GetOrdinal("credit_hours"));
                        Label credit_hours = new Label();
                        credit_hours.Text = "Credit Hours: " + creditHrs + "";
                        credit_hours.CssClass = "newlabel";
                        form1.Controls.Add(credit_hours);
                    }
                    else
                    {
                        Label credit_hours = new Label();
                        credit_hours.Text = "<br> ";
                        credit_hours.CssClass = "newlabel";
                        form1.Controls.Add(credit_hours);
                    }
                    form1.Controls.Add(new LiteralControl("<br>"));

                    int Course_id = rdr.GetOrdinal("course_id");
                    if (!rdr.IsDBNull(Course_id))
                    {
                        int Cid = rdr.GetInt32(rdr.GetOrdinal("course_id"));
                        Label course_id = new Label();
                        course_id.Text = "Course ID: " + Cid + "";
                        course_id.CssClass = "newlabel";
                        form1.Controls.Add(course_id);
                    }
                    else
                    {
                        Label course_id = new Label();
                        course_id.Text = "<br>";
                        course_id.CssClass = "newlabel";
                        form1.Controls.Add(course_id);
                    }
                    form1.Controls.Add(new LiteralControl("<br>"));

                    int Sid = rdr.GetInt32(rdr.GetOrdinal("student_id"));
                    Label student_id = new Label();
                    student_id.Text = "Student ID: " + Sid + "";
                    form1.Controls.Add(student_id);
                    form1.Controls.Add(new LiteralControl("<br>"));


                    // int Adid = read.GetInt32(read.GetOrdinal("advisor_id"));
                    //Label advisor_id = new Label();
                    //advisor_id.Text = "Advisor ID: "+ Adid + "";
                    // form1.Controls.Add(advisor_id);
                    //form1.Controls.Add(new LiteralControl("<br>"));

                    Label l1 = new Label();
                    l1.Text = "-----------------------------------------------------";
                    form1.Controls.Add(l1);
                    form1.Controls.Add(new LiteralControl("<br>"));


                }

            }


        }
		protected void Button2_Click(object sender, EventArgs e)
		{
			Response.Redirect("Advisor_menu.aspx");
		}
	}
}