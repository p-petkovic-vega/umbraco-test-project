using System.Web.Routing;
using Umbraco.Web;
using UmbracoTestProject.Common;
using UmbracoTestProject.Web.Controllers.RenderMvc;
using UmbracoTestProject.Web.Extensions;

namespace UmbracoTestProject.Web
{
	public class RouteConfig
	{
		public static void RegisterRoutes(RouteCollection routes)
		{
			// Routes for the XML sitemap functionality
			routes.MapUmbracoRoute(
				"SitemapXML",
				AppSettings.XMLSitemapRouteUrl,
				new
				{
					controller = nameof(XMLSitemapController).RemoveControllerSuffix(),
					action = nameof(XMLSitemapController.XMLSitemap)
				},
				new DomainRootRouteHandler()
			);

			// TODO: Remove on single-language site.
			routes.MapUmbracoRoute(
				"LanguageSpecificSitemapXML",
				$"{{language}}/{AppSettings.XMLSitemapRouteUrl}",
				new
				{
					controller = nameof(XMLSitemapController).RemoveControllerSuffix(),
					action = nameof(XMLSitemapController.XMLSitemap)
				},
				new DomainRootRouteHandler(),
				new { language = new ExistingLanguagesRouteConstraint() }
			);
		}
	}
}
