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
    public partial class MissingCourses : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string connectstr = WebConfigurationManager.ConnectionStrings["Advising_System"].ToString();
            SqlConnection conn = new SqlConnection(connectstr);


            String temp = Session["user"] as string;
            SqlCommand opt = new SqlCommand("Procedures_ViewMS", conn);
            opt.CommandType = CommandType.StoredProcedure;
            opt.Parameters.Add(new SqlParameter("@StudentID", temp));

            conn.Open();
            try
            {
                SqlDataReader rdr = opt.ExecuteReader(CommandBehavior.CloseConnection);
                if (rdr.Read())
                {
                    while (rdr.Read())
                    {
                        int courseid = rdr.GetInt32(rdr.GetOrdinal("course_id"));
                        Label thecourseid = new Label();
                        thecourseid.Text = "Course ID:  " + courseid + "";

                        exist.Controls.Add(thecourseid);
                        exist.Controls.Add(new LiteralControl("<br>"));

                        String coursename = rdr.GetString(rdr.GetOrdinal("name"));
                        Label thecoursename = new Label();
                        thecoursename.Text = "Course Name:  " + coursename;

                        exist.Controls.Add(thecoursename);
                        exist.Controls.Add(new LiteralControl("<br>"));
                        Label line1 = new Label();
                        line1.Text = "-----------------------------------------------------------";

                        exist.Controls.Add(line1);
                        exist.Controls.Add(new LiteralControl("<br>"));

                    }
                    rdr.Close();
                    Response.Write("");
                }
                else
                {
                    Label thecoursename = new Label();
                    thecoursename.Text = "No Missing courses";
                    exist.Controls.Add(thecoursename);
                }
            }
            catch (Exception ex)
            {
                Response.Write("something went wrong please try again");
            }
            conn.Close();
        
        
    }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("Studentmenu.aspx");
        }
    }
}