﻿using System.Web.Mvc;

namespace UmbracoTestProject.Web
{
	/// <summary>
	/// Partial view engine with extended support for partial view locations.
	/// </summary>
	public class PartialViewEngine : RazorViewEngine
	{
		public PartialViewEngine()
		{
			PartialViewLocationFormats = new[]
			{
				"~/Views/Partials/{1}/{0}.cshtml",
				"~/Views/Partials/{1}/_{0}.cshtml"
			};
		}
	}
}
