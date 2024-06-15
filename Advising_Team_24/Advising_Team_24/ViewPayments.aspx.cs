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
    public partial class ViewInstallments : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            string connStr = WebConfigurationManager.ConnectionStrings["Advising_System"].ToString();
            SqlConnection conn = new SqlConnection(connStr);
            SqlCommand PaymentView = new SqlCommand("SELECT * FROM Student_Payment", conn);
            PaymentView.CommandType = System.Data.CommandType.Text;
            conn.Open();
            SqlDataReader rdr = PaymentView.ExecuteReader();

            if (rdr.HasRows)
            {
                while (rdr.Read())
                {
                
                    int studentID = rdr.GetInt32(rdr.GetOrdinal("studentID"));
                    Label thestudentID = new Label();
                    thestudentID.Text = "Student ID: " + studentID + "";
                    form1.Controls.Add(thestudentID);
                    form1.Controls.Add(new LiteralControl("<br>"));

                    String f_name = rdr.GetString(rdr.GetOrdinal("f_name"));
                    Label firstname = new Label();
                    firstname.Text = "First Name: " + f_name;
                    form1.Controls.Add(firstname);
                    form1.Controls.Add(new LiteralControl("<br>"));

                    String l_name = rdr.GetString(rdr.GetOrdinal("l_name"));
                    Label lastname = new Label();
                    lastname.Text = "Last Name: " + l_name;
                    form1.Controls.Add(lastname);
                    form1.Controls.Add(new LiteralControl("<br>"));

                    int payment_id = rdr.GetInt32(rdr.GetOrdinal("payment_id"));
                    Label paymentID = new Label();
                    paymentID.Text = "Payment ID: " + payment_id + "";
                    form1.Controls.Add(paymentID);
                    form1.Controls.Add(new LiteralControl("<br>"));

                    int amount = rdr.GetInt32(rdr.GetOrdinal("amount"));
                    Label Amount = new Label();
                    Amount.Text = "Amount: " + amount + "";
                    form1.Controls.Add(Amount);
                    form1.Controls.Add(new LiteralControl("<br>"));

                    DateTime deadline = rdr.GetDateTime(rdr.GetOrdinal("deadline"));
                    Label Deadline = new Label();
                    Deadline.Text = "Deadline: " + deadline + "";
                    form1.Controls.Add(Deadline);
                    form1.Controls.Add(new LiteralControl("<br>"));

                    int n_installments = rdr.GetInt32(rdr.GetOrdinal("n_installments"));
                    Label no_instlmnts = new Label();
                    no_instlmnts.Text = "Number of Installments: " + n_installments + "";
                    form1.Controls.Add(no_instlmnts);
                    form1.Controls.Add(new LiteralControl("<br>"));

                    String status = rdr.GetString(rdr.GetOrdinal("status"));
                    Label Status = new Label();
                    Status.Text = "Status: " + status;
                    form1.Controls.Add(Status);
                    form1.Controls.Add(new LiteralControl("<br>"));

                    decimal fund_percentage = rdr.GetDecimal(rdr.GetOrdinal("fund_percentage"));
                    Label Fund_percentage = new Label();
                    Fund_percentage.Text = "Fund Percentage: " + fund_percentage + "";
                    form1.Controls.Add(Fund_percentage);
                    form1.Controls.Add(new LiteralControl("<br>"));

                    DateTime startdate = rdr.GetDateTime(rdr.GetOrdinal("startdate"));
                    Label StartDate = new Label();
                    StartDate.Text = "Start Date: " + startdate + "";
                    form1.Controls.Add(StartDate);
                    form1.Controls.Add(new LiteralControl("<br>"));

                    form1.Controls.Add(thestudentID);
                    form1.Controls.Add(new LiteralControl("<br>"));

                    String semester_code = rdr.GetString(rdr.GetOrdinal("semester_code"));
                    Label sem_code = new Label();
                    sem_code.Text = "Semester Code: " + semester_code;
                    form1.Controls.Add(sem_code);
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