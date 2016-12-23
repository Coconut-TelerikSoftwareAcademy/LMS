using System;
using System.Web;
using System.Web.UI;

namespace ASP.NETSample
{
	public partial class Default : System.Web.UI.Page
	{
		public void update_courses (object sender, EventArgs args)
		{
			foreach (var item in StudentSystem.Client.Tracks)
			{
				System.Web.UI.HtmlControls.HtmlGenericControl createDiv = new System.Web.UI.HtmlControls.HtmlGenericControl("DIV");      
				createDiv.ID = item.name;
				createDiv.Attributes["class"] = "col-md-4";
				createDiv.InnerHtml = 
					"<h2>"+ item.name + "</h2>\n<p><a href=\""+ item.link + "\" role=\"button\" class=\"btn btn-secondary\">View details »</a></p>";
				courses.Controls.Add(createDiv);
			}
		}
	}
}

