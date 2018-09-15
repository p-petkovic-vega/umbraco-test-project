using System.Web.Mvc;
using Umbraco.Web.Mvc;
using UmbracoTestProject.Models.DocumentTypes;

namespace UmbracoTestProject.Web.Controllers.RenderMvc
{
	public class XMLSitemapController : RenderMvcController
	{
		public ActionResult XMLSitemap(IDomainRoot model)
			=> CurrentTemplate(model);
	}
}
