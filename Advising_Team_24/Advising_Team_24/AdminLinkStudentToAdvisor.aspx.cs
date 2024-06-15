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
    public partial class AdminLinkStudentToAdvisor : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string connectstr = WebConfigurationManager.ConnectionStrings["Advising_System"].ToString();
            SqlConnection conn = new SqlConnection(connectstr);
            SqlCommand comm = new SqlCommand("Procedures_AdminLinkStudentToAdvisor", conn);
            comm.CommandType = CommandType.StoredProcedure;
            int Sid = int.Parse(TextBox1.Text);
            int Aid = int.Parse(TextBox2.Text);
            comm.Parameters.Add(new SqlParameter("@studentID", Sid));
            comm.Parameters.Add(new SqlParameter("@advisorID", Aid));
            conn.Open();
            comm.ExecuteNonQuery();
            conn.Close();
            TextBox1.Text = "";
            TextBox2.Text = "";
            Response.Write("succesfully submitted");

        }
		protected void Button2_Click(object sender, EventArgs e)
		{
			Response.Redirect("adminhome.aspx");
		}
	}
}