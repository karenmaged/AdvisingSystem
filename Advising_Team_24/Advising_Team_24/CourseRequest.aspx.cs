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
    public partial class Request : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
				string connectstr = WebConfigurationManager.ConnectionStrings["Advising_System"].ToString();
				SqlConnection conn = new SqlConnection(connectstr);
				SqlCommand pop2 = new SqlCommand("select name,course_id from course", conn);
				pop2.CommandType = CommandType.Text;
				conn.Open();
				DropDownList1.DataSource = pop2.ExecuteReader();
				DropDownList1.DataTextField = "name";
				DropDownList1.DataValueField = "course_id";
				DropDownList1.DataBind();
				conn.Close();
				DropDownList1.Items.Insert(0, new ListItem("Select Course", "Select Course"));
			}
        }



        protected void Button1_Click(object sender, EventArgs e)
        {
            string connectstr = WebConfigurationManager.ConnectionStrings["Advising_System"].ToString();
            SqlConnection conn = new SqlConnection(connectstr);
            SqlCommand pop = new SqlCommand("Procedures_StudentSendingCourseRequest", conn);
        
			String temp2 = DropDownList1.SelectedValue;
			
           
            pop.CommandType = CommandType.StoredProcedure;
            String temp = Session["user"] as string;
            String temp4 = TextBox1.Text;
            if (temp2 == "Select Course")
            {
                Response.Write("please select a course");
            }
            else
            {
                conn.Open();
               
                pop.Parameters.Add(new SqlParameter("@StudentID", temp));
                pop.Parameters.Add(new SqlParameter("@courseID", temp2));
                pop.Parameters.Add(new SqlParameter("@comment", temp4));
                pop.Parameters.Add(new SqlParameter("@type", "course"));
               try
                {
                    pop.ExecuteNonQuery();
                   DropDownList1.SelectedValue = "Select Course";
                    TextBox1.Text = "";
                    Response.Write("succesfully submitted");
                }
                catch (Exception ex)
                {
                    Response.Write(" something went wrong please try again");

                }
                conn.Close();
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("Studentmenu.aspx");
        }
    }
}