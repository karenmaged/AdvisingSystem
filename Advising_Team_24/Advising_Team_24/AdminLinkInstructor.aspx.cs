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
    public partial class AdminLinkInstructor : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {


        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string connectstr = WebConfigurationManager.ConnectionStrings["Advising_System"].ToString();
            SqlConnection conn = new SqlConnection(connectstr);
            SqlCommand comm = new SqlCommand("Procedures_AdminLinkInstructor", conn);
            comm.CommandType = CommandType.StoredProcedure;
            int Iid = int.Parse(TextBox1.Text);
            int Cid = int.Parse(TextBox2.Text);
            int Sid = int.Parse(TextBox3.Text);
            comm.Parameters.Add(new SqlParameter("@cours_id", Cid));
            comm.Parameters.Add(new SqlParameter("@instructor_id", Iid));
            comm.Parameters.Add(new SqlParameter("@slot_id", Sid));
            conn.Open();
            comm.ExecuteNonQuery();
            conn.Close();
            Response.Write("succesfully submitted");

        }
		protected void Button2_Click(object sender, EventArgs e)
		{
			Response.Redirect("adminhome.aspx");
		}
	}
}