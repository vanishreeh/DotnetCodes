using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WindowsFormsApp.Model;
using WindowsFormsApp.Repository;

namespace WindowsFormsApp
{
	public partial class Login : System.Web.UI.Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{

		}

        protected void btnLogin_Click(object sender, EventArgs e)
        {
			User userExists = UserRepository.CheckLoginCredentials(txtUserName.Text, txtPassword.Text);
			if (userExists == null)
			{
				Response.Write("<script> alert('WrongCredentials');</script>");
			}
			else
			{
				Session["userData"] = userExists.Name;
                Response.Redirect("Welcome.aspx");
            }
				
        }
    }
}