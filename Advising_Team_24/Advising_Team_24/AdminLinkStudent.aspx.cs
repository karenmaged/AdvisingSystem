using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Security.Cryptography;

namespace Advising_Team_24
{
    public partial class AdminLinkStudent : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string connectstr = WebConfigurationManager.ConnectionStrings["Advising_System"].ToString();
            SqlConnection conn = new SqlConnection(connectstr);
            SqlCommand comm = new SqlCommand("Procedures_AdminLinkStudent", conn);
            comm.CommandType = CommandType.StoredProcedure;
            int Cid = int.Parse(TextBox1.Text);
            int Iid = int.Parse(TextBox2.Text);
            int Sid = int.Parse(TextBox3.Text);
            String SemID = TextBox4.Text;


            comm.Parameters.Add(new SqlParameter("@cours_id", Cid));
            comm.Parameters.Add(new SqlParameter("@instructor_id", Iid));
            comm.Parameters.Add(new SqlParameter("@studentID", Sid));
            comm.Parameters.Add(new SqlParameter("@semester_code", SemID));

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