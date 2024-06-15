using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace Advising_Team_24
{
    public partial class listAdvisors : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //advisor_id int primary key identity, 
            // advisor_name varchar(40),
            //email varchar(40),
            //office
            //Procedures_AdminListAdvisors
            string connstr = WebConfigurationManager.ConnectionStrings["Advising_System"].ToString();
            SqlConnection conn = new SqlConnection(connstr);

            SqlCommand advisors = new SqlCommand("Procedures_AdminListAdvisors", conn);
            advisors.CommandType = CommandType.StoredProcedure;

            conn.Open();
            SqlDataReader rdr = advisors.ExecuteReader(CommandBehavior.CloseConnection);

            while (rdr.Read() )
            {
                

                int advisorID = rdr.GetInt32(rdr.GetOrdinal("advisor_id"));
                Label ID = new Label();
                ID.Text = advisorID + "<br >";
                ID.CssClass = "newlabel";
                form1.Controls.Add(ID);


                String advisorName = rdr.GetString(rdr.GetOrdinal("advisor_name"));
                Label name = new Label();
                name.Text = advisorName + "<br >";
                name.CssClass = "newlabel";
                form1.Controls.Add(name);

                String advisorEmail = rdr.GetString(rdr.GetOrdinal("email"));
                Label email = new Label();
                email.Text = advisorEmail + "<br >";
                email.CssClass = "newlabel";
                form1.Controls.Add(email);

                String adviorOffice = rdr.GetString(rdr.GetOrdinal("office"));
                Label office = new Label();
                office.Text = adviorOffice + "<br >";
                office.CssClass = "newlabel";
                form1.Controls.Add(office);

                String advisorPassword = rdr.GetString(rdr.GetOrdinal("password"));
                Label password = new Label();
                password.Text = advisorPassword + "<br >";
                password.CssClass = "newlabel";
                form1.Controls.Add(password);

                String x = "/////////////////////////////";
                Label xx = new Label();
                xx.Text = x + "<br >";
                xx.CssClass = "newlabel";
                form1.Controls.Add(xx);


            }
            rdr.Close();
            conn.Close();
        }
		protected void Button2_Click(object sender, EventArgs e)
		{
			Response.Redirect("adminhome.aspx");
		}
	}
}