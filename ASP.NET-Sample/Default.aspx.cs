using System;
using System.Web;
using System.Web.UI;

namespace ASP.NETSample
{
	public partial class Default : System.Web.UI.Page
	{
		public void get_user (object sender, EventArgs args)
		{
			System.Web.UI.HtmlControls.HtmlGenericControl createDiv = new System.Web.UI.HtmlControls.HtmlGenericControl("span");      
			createDiv.ID = "username_span";
			createDiv.InnerHtml = (((string)(Application ["name"]) != "")?((string)(Application ["name"])):("User"));
			username.Controls.Add(createDiv);
		}
		public void update_courses (object sender, EventArgs args)
		{
			foreach (var item in StudentSystem.Client.Tracks)
			{
				System.Web.UI.HtmlControls.HtmlGenericControl createDiv = new System.Web.UI.HtmlControls.HtmlGenericControl("DIV");      
				createDiv.ID = item.name;
				createDiv.Attributes["class"] = "col-md-4";
				createDiv.InnerHtml = 
					"<h2>"+ item.name + "</h2>\n<p><a href=\"/GetTrack.aspx?link="+ item.link + "\" role=\"button\" class=\"btn btn-secondary\">View details »</a></p>";
				courses.Controls.Add(createDiv);
			}
		}
	}
}

