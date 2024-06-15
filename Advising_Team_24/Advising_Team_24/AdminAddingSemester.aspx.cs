using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Configuration;

namespace Advising_Team_24
{
    public partial class AdminAddingSemester : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {



        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string startDateText = StartDate.Value;
            string endDateText = EndDate.Value;


            if (DateTime.TryParse(startDateText, out DateTime startDate) && DateTime.TryParse(endDateText, out DateTime endDate))
            {
                if (startDate < endDate.AddMonths(-4) && !string.IsNullOrEmpty(TextBox1.Text))
                {

                    string connectstr = WebConfigurationManager.ConnectionStrings["Advising_System"].ToString();
                    SqlConnection conn = new SqlConnection(connectstr);
                    SqlCommand comm = new SqlCommand("AdminAddingSemester", conn);

                    SqlCommand checkCommand = new SqlCommand("SELECT COUNT(*) FROM Semester WHERE semester_code = @semesterCode", conn);
                    checkCommand.Parameters.AddWithValue("@semesterCode", TextBox1.Text);

                    conn.Open();
                    int existingCount = (int)checkCommand.ExecuteScalar();
                    conn.Close();

                    if (existingCount == 0)
                    {
                        comm.CommandType = CommandType.StoredProcedure;
                        String SemCode = TextBox1.Text;

                        comm.Parameters.Add(new SqlParameter("@start_date", startDate));
                        comm.Parameters.Add(new SqlParameter("@end_date", endDate));
                        comm.Parameters.Add(new SqlParameter("@semester_code", SemCode));
                        conn.Open();
                        comm.ExecuteNonQuery();
                        conn.Close();
                        Response.Write("succesfully submitted");


                    }
                    else
                    {
                        Response.Write("invalid semester code : already exists");
                    }

                }
                else
                {
                    if (string.IsNullOrEmpty(TextBox1.Text))
                    {
                        Response.Write("please enter semester code");

                    }
                    if (!(startDate < endDate.AddMonths(-4)))
                    {
                        Response.Write("invalid start or end date");

                    }

                }

            }
        }
		protected void Button2_Click(object sender, EventArgs e)
		{
			Response.Redirect("adminhome.aspx");
		}
	}
}
