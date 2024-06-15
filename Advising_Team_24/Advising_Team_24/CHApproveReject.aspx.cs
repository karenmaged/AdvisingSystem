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
	public partial class CHApproveReject : System.Web.UI.Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{
			if (!IsPostBack)
			{

				string connectstr = WebConfigurationManager.ConnectionStrings["Advising_System"].ToString();
				SqlConnection conn = new SqlConnection(connectstr);
				SqlCommand pop = new SqlCommand("select request_id from request where type='credit_hours'", conn);
				pop.CommandType = CommandType.Text;
				conn.Open();
				DropDownList1.DataSource = pop.ExecuteReader();
				DropDownList1.DataTextField = "request_id";
				DropDownList1.DataValueField = "request_id";
				DropDownList1.DataBind();
				conn.Close();
				DropDownList1.Items.Insert(0, new ListItem("Select Request", "Select Request"));

				SqlCommand pop2 = new SqlCommand("select semester_code from semester", conn);
				pop2.CommandType = CommandType.Text;
				conn.Open();
				DropDownList2.DataSource = pop2.ExecuteReader();
				DropDownList2.DataTextField = "semester_code";
				DropDownList2.DataValueField = "semester_code";
				DropDownList2.DataBind();
				conn.Close();
				DropDownList2.Items.Insert(0, new ListItem("Select Semester", "Select Semester"));

			}
		}

		protected void Button1_Click(object sender, EventArgs e)
		{
			string connectstr = WebConfigurationManager.ConnectionStrings["Advising_System"].ToString();
			SqlConnection conn = new SqlConnection(connectstr);
			String temp = DropDownList1.SelectedValue;
			String temp1 = DropDownList2.SelectedValue;
			SqlCommand st = new SqlCommand("Procedures_AdvisorApproveRejectCHRequest", conn);
			st.CommandType = CommandType.StoredProcedure;
			st.Parameters.Add(new SqlParameter("@requestID", temp));
			st.Parameters.Add(new SqlParameter("@current_sem_code", temp1));
			conn.Open();
			if (DropDownList1.SelectedValue == "Select Request" || DropDownList2.SelectedValue == "Select Semester")
			{
				Response.Write("Please enter all inputs");
			}
			else
			{
				try
				{
					st.ExecuteNonQuery();
				}
				catch (Exception ex)
				{
					Response.Write("Something went wrong please try again");
				}
				SqlCommand st2 = new SqlCommand("select status from request where request_id=@temp", conn);
				st2.Parameters.Add(new SqlParameter("@temp", temp));
				st2.CommandType = CommandType.Text;

				try
				{
					String x = (String)st2.ExecuteScalar();
					if (x == "Accept") Response.Write("Request has been successfully accepted");
					else Response.Write("Request has been successfully rejected");
				}
				catch (Exception ex)
				{
					Response.Write("Something went wrong please try again");
				}

			}
			conn.Close();


		}
		protected void Button2_Click(object sender, EventArgs e)
		{
			Response.Redirect("Advisor_menu.aspx");
		}
	}
}