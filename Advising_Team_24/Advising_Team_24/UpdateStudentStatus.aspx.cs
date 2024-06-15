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
    public partial class UpdateStudentStatus : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                string connectstr = WebConfigurationManager.ConnectionStrings["Advising_System"].ToString();
                SqlConnection conn = new SqlConnection(connectstr);
                SqlCommand pop = new SqlCommand("SELECT student_id FROM Student", conn);

                pop.CommandType = CommandType.Text;
                pop.Connection = conn;
                conn.Open();
                DropDownList1.DataSource = pop.ExecuteReader();
                DropDownList1.DataTextField = "student_id";
                DropDownList1.DataValueField = "student_id";
                DropDownList1.DataBind();
                conn.Close();
                DropDownList1.Items.Insert(0, new ListItem("---Select Student ID---", "0"));
            }

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string connStr = WebConfigurationManager.ConnectionStrings["Advising_System"].ToString();
            SqlConnection conn = new SqlConnection(connStr);
            SqlCommand updateStatus = new SqlCommand("Procedure_AdminUpdateStudentStatus", conn);
            updateStatus.CommandType = CommandType.StoredProcedure;

            string SID = DropDownList1.SelectedValue;
            updateStatus.Parameters.Add(new SqlParameter("@student_id", SID));

            conn.Open();
            updateStatus.ExecuteNonQuery();
            Response.Write("Procedure Successful");
            conn.Close();

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("adminhome.aspx");
        }
    }
}