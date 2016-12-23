using System;
using System.Web;
using System.Web.UI;

namespace ASP.NETSample
{	
	public partial class Login : System.Web.UI.Page
	{
		public void make_pass (object sender, EventArgs args)
		{
			password.Attributes ["type"] = "password";
		}
		public void make_email (object sender, EventArgs args)
		{
			email.Attributes ["type"] = "email";
		}
		public void login (object sender, EventArgs args)
		{
			bool valid = !StudentSystem.Client.Users.ContainsKey (email.Text);
			if (valid)
				Server.Transfer ("/", true);
			else 
			{
				Server.Transfer ("/Failed_login.aspx", false);
			}
		}
	}
}

