using System;
using System.Web;
using System.Web.UI;

namespace ASP.NETSample
{
	
	public partial class Recovery : System.Web.UI.Page
	{
		public void recovery (object sender, EventArgs args)
		{
			Server.Transfer("/Login.aspx", false);
			return;
		}
	}
}

