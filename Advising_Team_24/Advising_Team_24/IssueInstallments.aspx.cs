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
    public partial class IssueInstallments : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                string connectstr = WebConfigurationManager.ConnectionStrings["Advising_System"].ToString();
                SqlConnection conn = new SqlConnection(connectstr);
                SqlCommand pop = new SqlCommand("SELECT payment_id FROM Payment", conn);


                pop.CommandType = CommandType.Text;
                pop.Connection = conn;
                conn.Open();
                DropDownList1.DataSource = pop.ExecuteReader();
                DropDownList1.DataTextField = "payment_id";
                DropDownList1.DataValueField = "payment_id";
                DropDownList1.DataBind();
                conn.Close();
                DropDownList1.Items.Insert(0, new ListItem("---Select Payment ID---", "0"));

            }
            

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string connStr = WebConfigurationManager.ConnectionStrings["Advising_System"].ToString();
            SqlConnection conn = new SqlConnection(connStr);
            SqlCommand issueinstallment = new SqlCommand(" Procedures_AdminIssueInstallment", conn);
            issueinstallment.CommandType = CommandType.StoredProcedure;

            string PID = DropDownList1.SelectedValue;
            issueinstallment.Parameters.Add(new SqlParameter("@payment_id", PID));

            conn.Open();
            issueinstallment.ExecuteNonQuery();
            Response.Write("Procedure Successful");
            conn.Close();
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("adminhome.aspx");
        }
    }
}