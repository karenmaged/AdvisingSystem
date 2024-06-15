using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Advising_Team_24
{
    public partial class RegisterationHome : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (DropDownList1.SelectedValue == "Advisor")
            {
                Response.Redirect("AdvisorRegisteration.aspx");
            }
            else
            {
                Response.Redirect("StudentRegisteration.aspx");
            }
        }
    }
}