using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Advising_Team_24
{
    public partial class ViewGradPlans : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string connStr = WebConfigurationManager.ConnectionStrings["Advising_System"].ToString();
            SqlConnection conn = new SqlConnection(connStr);
            SqlCommand ViewGradPlans = new SqlCommand("SELECT * FROM Advisors_Graduation_Plan", conn);
            ViewGradPlans.CommandType = System.Data.CommandType.Text;
            conn.Open();
            SqlDataReader rdr = ViewGradPlans.ExecuteReader();

            if (rdr.HasRows)
            {
                while (rdr.Read())
                {
                   
                    int plan_id = rdr.GetInt32(rdr.GetOrdinal("plan_id"));
                    Label planID = new Label();
                    planID.Text ="Plan ID: " + plan_id + "";
                    form1.Controls.Add(planID);
                    form1.Controls.Add(new LiteralControl("<br>"));

                    String semester_code = rdr.GetString(rdr.GetOrdinal("semester_code"));
                    Label semCode = new Label();
                    semCode.Text = "Semester Code: " + semester_code;
                    form1.Controls.Add(semCode);
                    form1.Controls.Add(new LiteralControl("<br>"));

                    int semester_credit_hours = rdr.GetInt32(rdr.GetOrdinal("semester_credit_hours"));
                    Label semCRHRS = new Label();
                    semCRHRS.Text = "Semester Credit Hours: " + semester_credit_hours + "";
                    form1.Controls.Add(semCRHRS);
                    form1.Controls.Add(new LiteralControl("<br>"));

                    DateTime expected_grad_date = rdr.GetDateTime(rdr.GetOrdinal("expected_grad_date"));
                    Label expectedGradDate = new Label();
                    expectedGradDate.Text = "Expected Graduation Date: " + expected_grad_date + "";
                    form1.Controls.Add(expectedGradDate);
                   

                    int advisor_id = rdr.GetInt32(rdr.GetOrdinal("advisor_id"));
                    Label advisorID = new Label();
                    advisorID.Text = "Advisor ID: " + advisor_id + "";
                    form1.Controls.Add(advisorID);
                    form1.Controls.Add(new LiteralControl("<br>"));

                    int studentID = rdr.GetInt32(rdr.GetOrdinal("student_id"));
                    Label thestudentID = new Label();
                    thestudentID.Text = "Student ID: " + studentID + "";
                    form1.Controls.Add(thestudentID);
                    form1.Controls.Add(new LiteralControl("<br>"));

                    form1.Controls.Add(advisorID);
                    form1.Controls.Add(new LiteralControl("<br>"));

                    String advisor_name = rdr.GetString(rdr.GetOrdinal("advisor_name"));
                    Label advisorname = new Label();
                    advisorname.Text = "Advisor Name: " + advisor_name;
                    form1.Controls.Add(advisorname);
                    form1.Controls.Add(new LiteralControl("<br>"));

                    Label line = new Label();
                    line.Text = "-----------------------------------------------------------";

                    form1.Controls.Add(line);
                    form1.Controls.Add(new LiteralControl("<br>"));

                }
            }
            
            Response.Write("Procedure Successful");
            conn.Close();
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("adminhome.aspx");
        }
    }
}