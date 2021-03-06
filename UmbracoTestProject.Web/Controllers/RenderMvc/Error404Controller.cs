﻿using System.Net;
using System.Web.Mvc;
using Umbraco.Web.Mvc;
using UmbracoTestProject.Models.DocumentTypes;

namespace UmbracoTestProject.Web.Controllers.RenderMvc
{
	public class Error404Controller : RenderMvcController
	{
		public ActionResult Index(IPage model)
		{
			Response.StatusCode = (int)HttpStatusCode.NotFound;
			Response.Status = "404 not found";
			Response.TrySkipIisCustomErrors = true;

			return CurrentTemplate(model);
		}
	}
}
