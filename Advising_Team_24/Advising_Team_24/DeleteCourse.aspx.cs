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
    public partial class DeleteCourse : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                string constr = WebConfigurationManager.ConnectionStrings["Advising_System"].ToString();
                SqlConnection con = new SqlConnection(constr);

                SqlCommand cmd = new SqlCommand("SELECT course_id, name FROM Course");

                cmd.CommandType = CommandType.Text;
                cmd.Connection = con;
                con.Open();
                DropDownList1.DataSource = cmd.ExecuteReader();
                DropDownList1.DataTextField = "name";
                DropDownList1.DataValueField = "course_id";
                DropDownList1.DataBind();
                con.Close();
                DropDownList1.Items.Insert(0, new ListItem("---Select Course---", "0"));

                
                

            }
        }

            

        protected void Button1_Click(object sender, EventArgs e)
        {
            string connStr = WebConfigurationManager.ConnectionStrings["Advising_System"].ToString();
            SqlConnection conn = new SqlConnection(connStr);
            SqlCommand deleteCourse = new SqlCommand("Procedures_AdminDeleteCourse", conn);
            deleteCourse.CommandType = CommandType.StoredProcedure;


            string CID= DropDownList1.SelectedValue;
            deleteCourse.Parameters.Add(new SqlParameter("@courseID", CID));

            conn.Open();
            deleteCourse.ExecuteNonQuery();
            Response.Write("Procedure Successful");
            conn.Close();
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("adminhome.aspx");
        }
    }
}