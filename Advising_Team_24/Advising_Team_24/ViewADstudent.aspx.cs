using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net.NetworkInformation;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml.Linq;

namespace Advising_Team_24
{
    public partial class ViewADstudent : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string connStr = WebConfigurationManager.ConnectionStrings["Advising_System"].ToString();
            SqlConnection conn = new SqlConnection(connStr);
            String temp= Session["user"] as String;
            SqlCommand ViewADstudent = new SqlCommand("AdminListStudentsWithAdvisors", conn);
           ViewADstudent.CommandType = CommandType.StoredProcedure;

            conn.Open();
            SqlDataReader read = ViewADstudent.ExecuteReader(CommandBehavior.CloseConnection);
            while (read.Read())
            {
                //session mn 3nd farah VIMPPPP
                int Aid = read.GetInt32(read.GetOrdinal("advisor_id"));
                if (Aid == int.Parse(temp))
                {
                    int Sid = read.GetInt32(read.GetOrdinal("student_id"));
                    Label student_id = new Label();
                    student_id.Text = "Student ID: " +Sid + "";
                    form1.Controls.Add(student_id);
                    form1.Controls.Add(new LiteralControl("<br>"));
                    

                    String Sf_name = read.GetString(read.GetOrdinal("f_name"));
                    Label f_name = new Label();
                    f_name.Text = "Student Name: " +Sf_name+" ";
                    form1.Controls.Add(f_name);
                   


                    String Sl_name = read.GetString(read.GetOrdinal("l_name"));
                    Label l_name = new Label();
                    l_name.Text = Sl_name;
                    form1.Controls.Add(l_name);
                    form1.Controls.Add(new LiteralControl("<br>"));

                    //Label advisor_id = new Label();
                    //advisor_id.Text = "Advisor ID: "+ Aid + "";
                    //form1.Controls.Add(advisor_id);
                    //form1.Controls.Add(new LiteralControl("<br>"));
                    //Label l4 = new Label();
                    //l4.Text = "-----------------------------------------------------";
                    //form1.Controls.Add(l4);
                    //form1.Controls.Add(new LiteralControl("<br>"));


                    /* String Aname = read.GetString(read.GetOrdinal("advisor_name"));
                     Label advisor_name = new Label();
                     advisor_name.Text = "Advisor Name: "+Aname;
                     form1.Controls.Add(advisor_name);
                     form1.Controls.Add(new LiteralControl("<br>"));
                     Label l5 = new Label();
                     l5.Text = "-----------------------------------------------------";
                     form1.Controls.Add(l5);
                     form1.Controls.Add(new LiteralControl("<br>"));

                     form1.Controls.Add(new LiteralControl("<br>"));*/

                    form1.Controls.Add(new LiteralControl("<br>"));
                    Label l5 = new Label();
                    l5.Text = "-----------------------------------------------------";
                    form1.Controls.Add(l5);
                    form1.Controls.Add(new LiteralControl("<br>"));





                }

            }

			



		}
		protected void Button2_Click(object sender, EventArgs e)
		{
			Response.Redirect("Advisor_menu.aspx");
		}
	}
}