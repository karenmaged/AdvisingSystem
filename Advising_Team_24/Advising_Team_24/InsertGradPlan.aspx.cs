using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml.Linq;

namespace Advising_Team_24
{
    public partial class InsertGradPlan : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            if (!IsPostBack)
            {

                string connStr = WebConfigurationManager.ConnectionStrings["Advising_System"].ToString();
                SqlConnection conn = new SqlConnection(connStr);


                SqlCommand InsertGradPlan = new SqlCommand("SELECT semester_code FROM Semester");
                InsertGradPlan.CommandType = CommandType.Text;
                InsertGradPlan.Connection = conn;
                conn.Open();


                SemDropDown.DataSource = InsertGradPlan.ExecuteReader();
                SemDropDown.DataTextField = "semester_code";
                SemDropDown.DataValueField = "semester_code";
                SemDropDown.DataBind();

                SemDropDown.Items.Insert(0, new ListItem("Select Semester code", "Select Semester code"));
                conn.Close();


                SqlCommand InsertGradPlan1 = new SqlCommand("SELECT student_id FROM Student");
                InsertGradPlan1.CommandType = CommandType.Text;
                InsertGradPlan1.Connection = conn;
                conn.Open();

                StudentDropDown.DataSource = InsertGradPlan1.ExecuteReader();
                StudentDropDown.DataTextField = "student_id";
                StudentDropDown.DataValueField = "student_id";
                StudentDropDown.DataBind();

                StudentDropDown.Items.Insert(0, new ListItem("Select Student", "Select Student"));


                conn.Close();
            }
        }
        //advisor-id using el session men 3nd farahhh VIMPPP
        protected void Submit_GP(object sender, EventArgs e)

        {
            String semcode = SemDropDown.SelectedValue;
            String expDate = selectDate.Value;
            String sID = StudentDropDown.SelectedValue;
            DateTime.TryParse(expDate, out DateTime expcDate);

            if (!(StudentDropDown.SelectedValue == "Select Student") && !(SemDropDown.SelectedValue == "Select Semester code") && !(string.IsNullOrEmpty(expDate)) && !(string.IsNullOrEmpty(sCredit1.Text))) 
            {

                string connStr = WebConfigurationManager.ConnectionStrings["Advising_System"].ToString();
                SqlConnection conn = new SqlConnection(connStr);

                int credithrs = Int16.Parse(sCredit1.Text);

                //String Aid = "";



                if (credithrs <= 34 || credithrs == 0)
                {
                    SqlCommand SubmitGP = new SqlCommand("Procedures_AdvisorCreateGP", conn);
                    SubmitGP.CommandType = CommandType.StoredProcedure;


                    SubmitGP.Parameters.Add(new SqlParameter("@Semester_code", semcode));
                    SubmitGP.Parameters.Add(new SqlParameter("@expected_graduation_date", expcDate));
                    SubmitGP.Parameters.Add(new SqlParameter("@sem_credit_hours", credithrs));
                    SubmitGP.Parameters.Add(new SqlParameter("@advisor_id", 1));
                    SubmitGP.Parameters.Add(new SqlParameter("@student_id", sID));
                    conn.Open();
                    // if (string.IsNullOrEmpty(semcode)|| string.IsNullOrEmpty(expDate) || string.IsNullOrEmpty(sID) || credithrs==0)
                    // {
                    SubmitGP.ExecuteNonQuery();
                    //}
                    /*else
                    {
                        Response.Write("Please Enter all values");
                    }*/
                    conn.Close();
                    Response.Write("Graduation Plan was created Successfully!");
                }

                else
                {
                    Response.Write("Invalid Credit Hours Number, " +
                        "Please Re-enter Value");
                }

            }

            else
            {
                Response.Write("Please insert all values!");
            }
        }

		protected void Button2_Click(object sender, EventArgs e)
		{
			Response.Redirect("Advisor_menu.aspx");
		}


	}
}