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
	public partial class Register : System.Web.UI.Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{

		}

        protected void Button2_Click(object sender, EventArgs e)
        {

        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            User userExists = UserRepository.GetUserByName(txtUserName.Text);
            if (userExists == null)
            {
           
            User user = new User();
            user.Name = txtUserName.Text;
            user.Password = txtPassword.Text;
            UserRepository.AddUser(user);
            Response.Redirect("Login.aspx");
            }
            else
            {
                Response.Write("Username Already Taken");
            }

        }
    }
}