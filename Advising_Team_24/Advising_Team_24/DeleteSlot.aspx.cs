using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Advising_Team_24
{
    public partial class DeleteSlot : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                string connectstr = WebConfigurationManager.ConnectionStrings["Advising_System"].ToString();
                SqlConnection conn = new SqlConnection(connectstr);
                SqlCommand pop = new SqlCommand("SELECT semester_code FROM Semester", conn);
                
                pop.CommandType = CommandType.Text;
                pop.Connection = conn;
                conn.Open();
                DropDownList1.DataSource = pop.ExecuteReader();
                DropDownList1.DataTextField = "semester_code";
                DropDownList1.DataValueField = "semester_code";
                DropDownList1.DataBind();
                conn.Close();
                DropDownList1.Items.Insert(0, new ListItem("---Select Semester Code---", "0"));

            }

        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            string connStr = WebConfigurationManager.ConnectionStrings["Advising_System"].ToString();
            SqlConnection conn = new SqlConnection(connStr);
            SqlCommand deleteSlot = new SqlCommand("Procedures_AdminDeleteSlots", conn);
            deleteSlot.CommandType = CommandType.StoredProcedure;

            string SID = DropDownList1.SelectedValue;
            deleteSlot.Parameters.Add(new SqlParameter("@current_semester", SID));

            conn.Open();
            deleteSlot.ExecuteNonQuery();
            Response.Write("Procedure Successful");
            conn.Close();
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("adminhome.aspx");
        }
    }
}