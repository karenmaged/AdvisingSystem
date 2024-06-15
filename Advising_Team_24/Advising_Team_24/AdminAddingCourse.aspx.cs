using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Runtime.InteropServices.ComTypes;

namespace Advising_Team_24
{
    public partial class Procedures_AdminAddingCourse : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {


            if (!string.IsNullOrEmpty(TextBox1.Text) && !string.IsNullOrEmpty(TextBox2.Text) && int.TryParse(TextBox2.Text, out int inputValue) && !string.IsNullOrEmpty(TextBox3.Text) && RadioButtonList1.SelectedIndex > 0)
            {
                string Major = TextBox1.Text;
                string Name = TextBox3.Text;
                int CH = int.Parse(TextBox2.Text);
                int selectedSemester = int.Parse(DropDownList2.SelectedValue);
                string isCourseOfferedValue = RadioButtonList1.SelectedValue;
                bool isCourseOffered = (isCourseOfferedValue == "Yes");

                string connectstr = WebConfigurationManager.ConnectionStrings["Advising_System"].ToString();
                SqlConnection conn = new SqlConnection(connectstr);
                SqlCommand comm = new SqlCommand("Procedures_AdminAddingCourse", conn);
                comm.CommandType = CommandType.StoredProcedure;
                comm.Parameters.Add(new SqlParameter("@major", Major));
                comm.Parameters.Add(new SqlParameter("@semester", selectedSemester));
                comm.Parameters.Add(new SqlParameter("@credit_hours", CH));
                comm.Parameters.Add(new SqlParameter("@name", Name));
                comm.Parameters.Add(new SqlParameter("@is_offered", isCourseOffered));
                conn.Open();
                comm.ExecuteNonQuery();
                conn.Close();
                Response.Write("succesfully submitted");

            }
            else
            {
                Response.Write("please insert all the required data");
            }

        }
		protected void Button2_Click(object sender, EventArgs e)
		{
			Response.Redirect("adminhome.aspx");
		}
	}
}