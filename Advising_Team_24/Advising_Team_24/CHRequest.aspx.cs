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
    public partial class CHRequest : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string connectstr = WebConfigurationManager.ConnectionStrings["Advising_System"].ToString();
            SqlConnection conn = new SqlConnection(connectstr);
            SqlCommand pop = new SqlCommand("Procedures_StudentSendingCHRequest", conn);
            pop.CommandType = CommandType.StoredProcedure;
            String temp = Session["user"] as string;
            String temp2 = TextBox2.Text;
            String temp4 = TextBox1.Text;
            int test;
            if (temp2 == null || temp2 == "") 
            {
                Response.Write("Please enter credit hours to be requested");
            }
            else if (!int.TryParse(temp2, out test))
            {
              
                Response.Write("Please write credit hours as integer");

            }
            else
            {
                pop.Parameters.Add(new SqlParameter("@StudentID", temp));
                pop.Parameters.Add(new SqlParameter("@credit_hours", temp2));
                pop.Parameters.Add(new SqlParameter("@comment", temp4));
                pop.Parameters.Add(new SqlParameter("@type", "credit_hours"));
                conn.Open();
                try
                {
                    pop.ExecuteNonQuery();
                    TextBox2.Text = "";
                    TextBox1.Text = "";
                    Response.Write("succesfully submitted");
                }
                catch (Exception ex)
                {
                    Response.Write("something went wrong please try again");
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
