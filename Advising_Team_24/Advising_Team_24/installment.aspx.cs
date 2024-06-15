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
	public partial class installment : System.Web.UI.Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{
			string connstring = WebConfigurationManager.ConnectionStrings["Advising_System"].ToString();
			SqlConnection conn = new SqlConnection(connstring);
			SqlCommand ins = new SqlCommand("FN_StudentUpcoming_installment", conn);
			ins.CommandType = System.Data.CommandType.StoredProcedure;
			String temp = Session["user"] as String;
			ins.Parameters.Add(new SqlParameter("@student_ID", temp));
			SqlParameter dl = ins.Parameters.Add("@installdeadline", SqlDbType.DateTime);
			dl.Direction = ParameterDirection.ReturnValue;
			conn.Open();
			ins.ExecuteNonQuery();
			conn.Close();

			Label l = new Label();
			l.Text = "The deadline for your first unpaid installment is: " + dl.Value.ToString();
			this.Controls.Add(l);


		}

		protected void mainmenu_Click(object sender, EventArgs e)
		{
			Response.Redirect("Studentmenu.aspx");
		}
	}
}