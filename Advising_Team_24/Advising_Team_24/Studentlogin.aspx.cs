using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Principal;
using System.Web;
using System.Web.Caching;
using System.Web.Configuration;
using System.Web.Services.Description;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Advising_Team_24
{
    public partial class Studentlogin : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
		
		}

		protected void Login_Click(object sender, EventArgs e)
        {
            string connectstr = WebConfigurationManager.ConnectionStrings["Advising_System"].ToString();
            SqlConnection conn = new SqlConnection(connectstr);

            int id = Int16.Parse(ID.Text);
            String temp1 = Password.Text;



            if (ID.Text == "" || temp1 == null || temp1 == "")
            {
                Response.Write("Please enter username and password");
            }
            else
            {

                SqlCommand loginproc = new SqlCommand("FN_StudentLogin", conn);

                loginproc.CommandType = CommandType.StoredProcedure;

                loginproc.Parameters.Add(new SqlParameter("@Student_id", id));
                loginproc.Parameters.Add(new SqlParameter("@password", temp1));

                SqlParameter success = loginproc.Parameters.Add("@success", SqlDbType.Bit);
                success.Direction = ParameterDirection.ReturnValue;
                conn.Open();
                loginproc.ExecuteNonQuery();
                conn.Close();

                SqlCommand loginprocAdvisor = new SqlCommand("FN_AdvisorLogin", conn);

                loginprocAdvisor.CommandType = CommandType.StoredProcedure;

                loginprocAdvisor.Parameters.Add(new SqlParameter("@advisor_Id", id));
                loginprocAdvisor.Parameters.Add(new SqlParameter("@password", temp1));

                SqlParameter successAdvisor = loginprocAdvisor.Parameters.Add("@success", SqlDbType.Bit);
                successAdvisor.Direction = ParameterDirection.ReturnValue;
                conn.Open();
                loginprocAdvisor.ExecuteNonQuery();
                conn.Close();


                Boolean succussAdmin;
                if (id == 1 && temp1 == "rose")
                    succussAdmin = true;
                else
                    succussAdmin = false;
                if (Convert.ToBoolean(success.Value))
                {
                    Session["user"] = id.ToString();
                    Response.Redirect("Studentmenu.aspx");
                }
                else if (Convert.ToBoolean(successAdvisor.Value))
                {
                    Session["user"] = id.ToString();
                    Response.Redirect("Advisor_menu.aspx");
                }
                else if (succussAdmin)
                {
                    Session["user"] = id.ToString();
                    Response.Redirect("adminhome.aspx");

                }
                else
                {
                    
                    

                        SqlCommand fs = new SqlCommand("select financial_status from student where student_id=@sid and password=@pass", conn);
                        fs.CommandType = CommandType.Text;
                        fs.Parameters.Add(new SqlParameter("@sid", id));
                        fs.Parameters.Add(new SqlParameter("@pass", temp1));
                        SqlCommand fs2 = new SqlCommand("select count(*) from student where student_id=@sid1 and password=@pass1", conn);
                        fs2.CommandType = CommandType.Text;
                        fs2.Parameters.Add(new SqlParameter("@sid1", id));
                        fs2.Parameters.Add(new SqlParameter("@pass1", temp1));
                        conn.Open();
                        object res = fs.ExecuteScalar();
                        int res2 = (int)fs2.ExecuteScalar();
                        conn.Close();

                    if (res2 > 0)
                    {
                        if(res == null || res == DBNull.Value)
                        {
                            Response.Write("User Blocked");
                        }
                        else
                        {
                            Boolean fin = (Boolean)res;
                            if (fin == false )
                            {
                                Response.Write("User Blocked");
                            }
                        }
                    }
                    else
                    {
                        Response.Write("Invalid username or password");
                    }
                    
                }

            }

        }

        protected void Signup_Click(object sender, EventArgs e)
        {
            Response.Redirect("RegisterationHome.aspx");
        }
    }
}