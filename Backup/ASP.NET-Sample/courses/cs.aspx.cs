using System;
using System.Web;
using System.Web.UI;

namespace ASP.NETSample
{
	public partial class cs : System.Web.UI.Page
	{
		public void get_user (object sender, EventArgs args)
		{
			System.Web.UI.HtmlControls.HtmlGenericControl createDiv = new System.Web.UI.HtmlControls.HtmlGenericControl("span");      
			createDiv.ID = "username_span";
			createDiv.InnerHtml = (((string)(Application ["name"]) != "")?((string)(Application ["name"])):("User"));
			username.Controls.Add(createDiv);
		}
	}
}

