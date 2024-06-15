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
using System.Security.Cryptography;

namespace Advising_Team_24
{
    public partial class UpdateGdate : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                string connStr = WebConfigurationManager.ConnectionStrings["Advising_System"].ToString();
                SqlConnection conn = new SqlConnection(connStr);


                SqlCommand UpdateGdate1 = new SqlCommand("SELECT student_id FROM Student");
                UpdateGdate1.CommandType = CommandType.Text;
                UpdateGdate1.Connection = conn;
                conn.Open();

                StudentDropDown2.DataSource = UpdateGdate1.ExecuteReader();
                StudentDropDown2.DataTextField = "student_id";
                StudentDropDown2.DataValueField = "student_id";
                StudentDropDown2.DataBind();

                StudentDropDown2.Items.Insert(0, new ListItem("Select Student", "Select Student"));

                conn.Close();

            }
        }

        protected void Update_GDate(object sender, EventArgs e)
        {
            String studentId = StudentDropDown2.SelectedValue;
            String newEDate = newGdate.Value;
            DateTime.TryParse(newEDate, out DateTime newEDate1);
            if (!(StudentDropDown2.SelectedValue == "Select Student") && !(string.IsNullOrEmpty(newEDate)))
            {
                string connStr = WebConfigurationManager.ConnectionStrings["Advising_System"].ToString();
                SqlConnection conn1 = new SqlConnection(connStr);



                SqlCommand UpdateGD = new SqlCommand("Procedures_AdvisorUpdateGP", conn1);
                UpdateGD.CommandType = CommandType.StoredProcedure;

                UpdateGD.Parameters.Add(new SqlParameter("@expected_grad_date", newEDate1));
                UpdateGD.Parameters.Add(new SqlParameter("@studentID", studentId));
                conn1.Open();
                UpdateGD.ExecuteNonQuery();
                conn1.Close();

                Response.Write("EXPECTED GRADUATION DATE WAS UPDATED SUCCESSFULLY!");

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