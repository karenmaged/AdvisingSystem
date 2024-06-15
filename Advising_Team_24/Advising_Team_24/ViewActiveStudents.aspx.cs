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
    public partial class ViewActiveStudents : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            string connStr = WebConfigurationManager.ConnectionStrings["Advising_System"].ToString();
            SqlConnection conn = new SqlConnection(connStr);
            SqlCommand StudentsView = new SqlCommand("SELECT * FROM view_Students", conn);
            StudentsView.CommandType = System.Data.CommandType.Text;
            conn.Open();
            SqlDataReader rdr = StudentsView.ExecuteReader();

            if (rdr.HasRows)
            {
                while (rdr.Read())
                {
   
                    int studentID = rdr.GetInt32(rdr.GetOrdinal("student_ID"));
                    Label thestudentID = new Label();
                    thestudentID.Text = "Student ID: " + studentID + " ";
                    form1.Controls.Add(thestudentID);
                    form1.Controls.Add(new LiteralControl("<br>"));

                    String f_name = rdr.GetString(rdr.GetOrdinal("f_name"));
                    Label firstname = new Label();
                    firstname.Text = "First Name: " + f_name;
                    form1.Controls.Add(firstname);
                    form1.Controls.Add(new LiteralControl("<br>"));

                    String l_name = rdr.GetString(rdr.GetOrdinal("l_name"));
                    Label lastname = new Label();
                    lastname.Text = " Last Name: " + l_name;
                    form1.Controls.Add(lastname);
                    form1.Controls.Add(new LiteralControl("<br>"));

                    decimal gpa = rdr.GetDecimal(rdr.GetOrdinal("gpa"));
                    Label GPA = new Label();
                    GPA.Text = "GPA: " + gpa + "";
                    form1.Controls.Add(GPA);
                    form1.Controls.Add(new LiteralControl("<br>"));

                    String faculty = rdr.GetString(rdr.GetOrdinal("faculty"));
                    Label Faculty = new Label();
                    Faculty.Text = "Faculty: " + faculty;
                    form1.Controls.Add(Faculty);

                    form1.Controls.Add(new LiteralControl("<br>"));
                    String email = rdr.GetString(rdr.GetOrdinal("email"));
                    Label Email = new Label();
                    Email.Text = "E-mail: " + email;
                    form1.Controls.Add(Email);
                    form1.Controls.Add(new LiteralControl("<br>"));

                    String major = rdr.GetString(rdr.GetOrdinal("major"));
                    Label Major = new Label();
                    Major.Text = "Major: " + major;
                    form1.Controls.Add(Major);
                    form1.Controls.Add(new LiteralControl("<br>"));

                    String password = rdr.GetString(rdr.GetOrdinal("password"));
                    Label Password = new Label();
                    Password.Text = "Password: " + password;
                    form1.Controls.Add(Password);

                    form1.Controls.Add(new LiteralControl("<br>"));
                    bool financial_status = rdr.GetBoolean(rdr.GetOrdinal("financial_status"));
                    Label financialStatus = new Label();
                    if (financial_status)
                    {
                        financialStatus.Text = "Financial Status: Paid";

                    }
                    else {
                        financialStatus.Text = "Financial Status: Unpaid";
                    }
                    form1.Controls.Add(financialStatus);
                    form1.Controls.Add(new LiteralControl("<br>"));

                    int semester = rdr.GetInt32(rdr.GetOrdinal("semester"));
                    Label Semester = new Label();
                    Semester.Text = "Semester: " + semester + "";
                    form1.Controls.Add(Semester);
                    form1.Controls.Add(new LiteralControl("<br>"));

                    int acquired_hours = rdr.GetInt32(rdr.GetOrdinal("acquired_hours"));
                    Label acquiredHours = new Label();
                    acquiredHours.Text = "Acquired Hours: " + acquired_hours + "";
                    form1.Controls.Add(acquiredHours);
                    form1.Controls.Add(new LiteralControl("<br>"));

                    int assigned_hours = rdr.GetInt32(rdr.GetOrdinal("assigned_hours"));
                    Label assignedHours = new Label();
                    assignedHours.Text = "Assigned Hours: " + assigned_hours + "";
                    form1.Controls.Add(assignedHours);
                    form1.Controls.Add(new LiteralControl("<br>"));

                    int advisor_id = rdr.GetInt32(rdr.GetOrdinal("advisor_id"));
                    Label advisorID = new Label();
                    advisorID.Text = "Advisor ID: " + advisor_id + "";
                    form1.Controls.Add(advisorID);
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