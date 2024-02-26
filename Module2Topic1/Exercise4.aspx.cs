using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Module1Exercise1
{
    public partial class Exercise4 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            

        }

        protected void Submit_button(object sender, EventArgs e)
        {
            if (Page.IsValid)
            {
                string full_name = fullName.Text;
                string user_email = email.Text;
                string user_age = age.Text;

                result.Text = $"{full_name} \n {user_email} \n {user_age}";
            }
        }
    }
}