using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Advising_Team_24
{
    public partial class AddMakeupExam : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!this.IsPostBack)
            {
                string constr = WebConfigurationManager.ConnectionStrings["Advising_System"].ToString();
                SqlConnection con = new SqlConnection(constr);




                DropDownList1.Items.Insert(0, new ListItem("---Select Exam Type---", "0"));

                SqlCommand pop2 = new SqlCommand("select course_id, name from course", con);
                pop2.CommandType = CommandType.Text;
                con.Open();
                DropDownList2.DataSource = pop2.ExecuteReader();
                DropDownList2.DataTextField = "name";
                DropDownList2.DataValueField = "course_id";
                DropDownList2.DataBind();
                con.Close();
                DropDownList2.Items.Insert(0, new ListItem("---Select Course ID---", "0"));

            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("adminhome.aspx");
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string connStr = WebConfigurationManager.ConnectionStrings["Advising_System"].ToString();
            SqlConnection conn = new SqlConnection(connStr);
            SqlCommand addExam = new SqlCommand("Procedures_AdminAddExam", conn);
            addExam.CommandType = CommandType.StoredProcedure;
            string type = DropDownList1.SelectedValue;
            addExam.Parameters.Add(new SqlParameter("@Type", type));

            DateTime date = Calendar1.SelectedDate;
            addExam.Parameters.Add(new SqlParameter("@date", date));

            string CID = DropDownList2.SelectedValue;
            addExam.Parameters.Add(new SqlParameter("@courseID", CID));

            conn.Open();
            addExam.ExecuteNonQuery();
            Response.Write("Procedure Successful");
            conn.Close();
        }
    }
}