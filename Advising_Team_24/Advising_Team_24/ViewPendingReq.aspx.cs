using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Security.Cryptography;

namespace Advising_Team_24
{
    public partial class ViewPendingReq : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string connStr = WebConfigurationManager.ConnectionStrings["Advising_System"].ToString();
            SqlConnection conn = new SqlConnection(connStr);

            String temp = Session["user"] as String;

            SqlCommand ViewPR = new SqlCommand("Procedures_AdvisorViewPendingRequests", conn);
            ViewPR.CommandType = CommandType.StoredProcedure;
            ViewPR.Parameters.Add(new SqlParameter("@Advisor_ID", temp));

            conn.Open();
            ViewPR.ExecuteNonQuery();

            SqlDataReader read = ViewPR.ExecuteReader(CommandBehavior.CloseConnection);
            while (read.Read())
            {

                int Adid = read.GetInt32(read.GetOrdinal("advisor_id"));
                //String ST = read.GetString(read.GetOrdinal("status"));

                if (Adid==2)
                {

                    int reqID = read.GetInt32(read.GetOrdinal("request_id"));
                    Label request_id = new Label();
                    request_id.Text = "Request ID: " + reqID;
                    form1.Controls.Add(request_id);
                    form1.Controls.Add(new LiteralControl("<br>"));


                    String Type = read.GetString(read.GetOrdinal("type"));
                    Label type = new Label();
                    type.Text = "Request Type: " + Type;
                    form1.Controls.Add(type);
                    form1.Controls.Add(new LiteralControl("<br>"));



                    String Com = read.GetString(read.GetOrdinal("comment"));
                    Label comment = new Label();
                    comment.Text = "Comment: " + Com;
                    form1.Controls.Add(comment);
                    form1.Controls.Add(new LiteralControl("<br>"));

                    
                    //String ST = read.GetString(read.GetOrdinal("status"));
                    


                    int CreditHrs =read.GetOrdinal("credit_hours");
                    if (!read.IsDBNull(CreditHrs))
                    {
                        int creditHrs = read.GetInt32(read.GetOrdinal("credit_hours"));
                        Label credit_hours = new Label();
                        credit_hours.Text = "Credit Hours: " + creditHrs + "";
                        credit_hours.CssClass = "newlabel";
                        form1.Controls.Add(credit_hours);
                    }
                    else
                    {
                        Label credit_hours = new Label();
                        credit_hours.Text =  "<br> ";
                        credit_hours.CssClass = "newlabel";
                        form1.Controls.Add(credit_hours);
                    }
                    form1.Controls.Add(new LiteralControl("<br>"));

                    int Course_id = read.GetOrdinal("course_id");
                    if (!read.IsDBNull(Course_id))
                    {
                        int Cid = read.GetInt32(read.GetOrdinal("course_id"));
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

                    int Sid = read.GetInt32(read.GetOrdinal("student_id"));
                    Label student_id = new Label();
                    student_id.Text = "Student ID: " + Sid + "";
                    form1.Controls.Add(student_id);
                    form1.Controls.Add(new LiteralControl("<br>"));


                    // int Adid = read.GetInt32(read.GetOrdinal("advisor_id"));
                    //Label advisor_id = new Label();
                    //advisor_id.Text = "Advisor ID: "+ Adid + "";
                    // form1.Controls.Add(advisor_id);
                    //form1.Controls.Add(new LiteralControl("<br>"));

                    Label l = new Label();
                    l.Text = "-----------------------------------------------------";
                    form1.Controls.Add(l);
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