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
    public partial class PhoneNo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Label2.Text = "";
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            string connectstr = WebConfigurationManager.ConnectionStrings["Advising_System"].ToString();
            SqlConnection conn = new SqlConnection(connectstr);
            String id = Session["user"] as string;
            String mob = TextBox1.Text;
           
            conn.Open();
           
            if (mob == null || mob == "")
            {
                Response.Write("Please enter a mobile number");
            }
            else
            {
				SqlCommand cmd = new SqlCommand("select count(*) from student_phone where student_id=@id and phone_number=@mob", conn);
				cmd.Parameters.Add(new SqlParameter("@id", id));
				cmd.Parameters.Add(new SqlParameter("@mob", mob));
				int res = (int)cmd.ExecuteScalar();
                if (res != 0)
                {
                    Response.Write("This number already exists");
                }
                else
                {
                    SqlCommand mobile = new SqlCommand("Procedures_StudentaddMobile", conn);
                    mobile.CommandType = CommandType.StoredProcedure;
                    mobile.Parameters.Add(new SqlParameter("@StudentID", id));
                    mobile.Parameters.Add(new SqlParameter("@mobile_number", mob));


                    try
                    {
                        mobile.ExecuteNonQuery();
                        Label2.Text = " Your mobile number is successfully added. You may choose to add another one or leave the page";
                        TextBox1.Text = "";
                        Response.Write("");
                    }
                    catch (Exception ex)
                    {
                        Response.Write("something went wrong please try again");
                    }
                }
               

            }
			conn.Close();
		}

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("Studentmenu.aspx");
        }
    }
}