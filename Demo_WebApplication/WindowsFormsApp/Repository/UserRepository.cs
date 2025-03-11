using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WindowsFormsApp.Model;

namespace WindowsFormsApp.Repository
{
	public static class UserRepository
	{
		//create a list
		//AddUser()--registered users here
		//avoid Duplicate Entries in Registration--GetUserByName()
		//CheckLoginCredential()----Validate userName and Password
		static List<User> users = new List<User>();

		public static User GetUserByName(string userName)
		{
			return users.Find(u => u.Name == userName);
		}

		public static string AddUser(User user)
		{
			users.Add(user);
			return "Success";
		}

		public static User CheckLoginCredentials(string userName,string password)
		{
			return users.Where(u => u.Name == userName && u.Password == password).FirstOrDefault();

		}


	}
}