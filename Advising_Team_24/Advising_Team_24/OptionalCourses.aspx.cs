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
    public partial class OptionalCourses : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
				string connectstr = WebConfigurationManager.ConnectionStrings["Advising_System"].ToString();
				SqlConnection conn = new SqlConnection(connectstr);
				SqlCommand pop2 = new SqlCommand("select semester_code from semester", conn);
				pop2.CommandType = CommandType.Text;
				conn.Open();
				DropDownList1.DataSource = pop2.ExecuteReader();
				DropDownList1.DataTextField = "semester_code";
				DropDownList1.DataValueField = "semester_code";
				DropDownList1.DataBind();
				conn.Close();
				DropDownList1.Items.Insert(0, new ListItem("Select Semester", "Select Semester"));
			}
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string connectstr = WebConfigurationManager.ConnectionStrings["Advising_System"].ToString();
            SqlConnection conn = new SqlConnection(connectstr);

            String sem = DropDownList1.SelectedValue;
            String temp = Session["user"] as string;
            if (sem == "Select Semester")
            {
                Response.Write("select a semester");
            }
            else
            {
                SqlCommand opt = new SqlCommand("Procedures_ViewOptionalCourse", conn);
                opt.CommandType = CommandType.StoredProcedure;
                opt.Parameters.Add(new SqlParameter("@StudentID", temp));
                opt.Parameters.Add(new SqlParameter("@current_semester_code", sem));

                conn.Open();
                try
                {
                    SqlDataReader rdr = opt.ExecuteReader(CommandBehavior.CloseConnection);
                    if (rdr.HasRows)
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
                        thecoursename.Text = "No Optional courses in this semester";
                        exist.Controls.Add(thecoursename);
                    }
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