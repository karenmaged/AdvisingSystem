using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;
using static System.Net.Mime.MediaTypeNames;

namespace Advising_Team_24
{
    public partial class StudentRegisteration : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Sign_in(object sender, EventArgs e)
        {
            string connStr = WebConfigurationManager.ConnectionStrings["Advising_System"].ToString();
            SqlConnection conn = new SqlConnection(connStr);

            String fname = name1.Text;
            String lname = name2.Text;
            String pass = password1.Text;
            String fac = TextBox1.Text;
            String email = email1.Text;
            String major = major1.Text;
            String semester = TextBox2.Text;
            int test;
            if (fname == null || fname == "" || lname == null || lname == "" || pass == null || pass == "" || email == null || email == ""
                || fac == null || fac == "" || major == null || major == "" || semester == null || semester == "")
            {
                Response.Write("please enter all inputs");
            }
            else if (!int.TryParse(semester, out test))
            {
                Response.Write("please enter semester as int");
            }
            else
            {
                SqlCommand Sign_inproc = new SqlCommand("Procedures_StudentRegistration", conn);
                Sign_inproc.CommandType = CommandType.StoredProcedure;
                Sign_inproc.Parameters.Add(new SqlParameter("@first_name", fname));
                Sign_inproc.Parameters.Add(new SqlParameter("@last_name", lname));
                Sign_inproc.Parameters.Add(new SqlParameter("@password", pass));
                Sign_inproc.Parameters.Add(new SqlParameter("@faculty", fac));
                Sign_inproc.Parameters.Add(new SqlParameter("@email", email));
                Sign_inproc.Parameters.Add(new SqlParameter("@major", major));
                Sign_inproc.Parameters.Add(new SqlParameter("@Semester", semester));
                SqlParameter id = Sign_inproc.Parameters.Add("@Student_id", SqlDbType.Int);

                id.Direction = ParameterDirection.Output;


                conn.Open();
                try
                {
                    Sign_inproc.ExecuteNonQuery();
                    ADid.Text = "Student ID: " + id.Value;
                }
                catch (Exception ex)
                {
                    Response.Write("Something went wrong please try again");
                }
				conn.Close();
            }

        }

		protected void Button2_Click(object sender, EventArgs e)
		{

            Response.Redirect("Studentlogin.aspx");
		}
	}
}