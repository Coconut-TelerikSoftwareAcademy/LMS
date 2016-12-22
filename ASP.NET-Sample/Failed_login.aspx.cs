using System;
using System.Web;
using System.Web.UI;

namespace ASP.NETSample
{
	
	public partial class Failed_login : System.Web.UI.Page
	{
		public void login (object sender, EventArgs args)
		{
			bool valid = true;
			//TODO: check valid values
			if (valid)
				Server.Transfer ("/", true);
			else {
				Server.Transfer ("/Failed_login.aspx", false);
			}
		}
	}
}

