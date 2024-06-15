using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml.Linq;

namespace Advising_Team_24
{
	public partial class WebForm1 : System.Web.UI.Page
	{
		protected void Sign_in(object sender, EventArgs e)
		{
			string connStr = WebConfigurationManager.ConnectionStrings["Advising_System"].ToString();
			SqlConnection conn = new SqlConnection(connStr);

			String name = name1.Text;
			String pass = password1.Text;
			String ADVemail = email1.Text;
			String ADVoffice = office1.Text;
			if (name == null || name == "" || pass == null || pass == "" || ADVemail == null || ADVemail == ""
				|| ADVoffice == null || ADVoffice == "")
			{
				Response.Write("please enter all inputs");
			}
			else
			{
				SqlCommand Sign_inproc = new SqlCommand("Procedures_AdvisorRegistration", conn);
				Sign_inproc.CommandType = CommandType.StoredProcedure;
				Sign_inproc.Parameters.Add(new SqlParameter("@advisor_name", name));
				Sign_inproc.Parameters.Add(new SqlParameter("@password", pass));
				Sign_inproc.Parameters.Add(new SqlParameter("@email", ADVemail));
				Sign_inproc.Parameters.Add(new SqlParameter("@office", ADVoffice));

				SqlParameter id = Sign_inproc.Parameters.Add("@Advisor_id", SqlDbType.Int);

				id.Direction = ParameterDirection.Output;


				conn.Open();
				try
				{
					Sign_inproc.ExecuteNonQuery();
					ADid.Text = "Advisor ID: " + id.Value;
				}
				catch (Exception ex)
				{
					Response.Write("something went wrong please try again");
				}

				conn.Close();
			}



			//Response.Write("Welcome");
			//Response.Redirect("ViewADstudent.aspx");
			//Redirect to a new web page if not an advisor? (student's registartion page)


		}
		protected void login(object sender, EventArgs e)
		{
			Response.Redirect("Studentlogin.aspx");
		}

	}
}