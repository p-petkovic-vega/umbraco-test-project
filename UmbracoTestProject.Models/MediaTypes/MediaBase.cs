﻿using Umbraco.Core.Models;
using Umbraco.Core.Models.PublishedContent;
using Umbraco.Web;
using UmbracoTestProject.Models.Extensions;

namespace UmbracoTestProject.Models.MediaTypes
{
	/// <summary>
	/// Base media type model.
	/// </summary>
	public abstract class MediaBase : PublishedContentModel
	{
		public MediaBase(IPublishedContent content) : base(content)
		{ }

		/// <summary>
		/// Returns full (absolute) URL to the media.
		/// </summary>
		/// <remarks>
		/// This is replacement for IPublishedContent.UrlAbsolute() which is not working for media types.
		/// </remarks>
		public string FullUrl => UmbracoContext.Current?.HttpContext?.Request?.GetAbsoluteUrl(Url);
	}
}
