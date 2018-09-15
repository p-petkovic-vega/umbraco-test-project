using System.Web.Mvc;
using UmbracoTestProject.Common;
using WebMarkupMin.AspNet4.Mvc;

namespace UmbracoTestProject.Web
{
	public class FilterConfig
	{
		public static void RegisterGlobalFilters(GlobalFilterCollection filters)
		{
			if (AppSettings.DisableHttpCompression != true)
			{
				filters.Add(new CompressContentAttribute());
			}

			filters.Add(new MinifyHtmlAttribute());
		}
	}
}
