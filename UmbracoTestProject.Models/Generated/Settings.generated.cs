//------------------------------------------------------------------------------
// <auto-generated>
//   This code was generated by a tool.
//
//    Umbraco.ModelsBuilder v3.0.10.102
//
//   Changes to this file will be lost if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Web;
using Umbraco.Core.Models;
using Umbraco.Core.Models.PublishedContent;
using Umbraco.Web;
using Umbraco.ModelsBuilder;
using Umbraco.ModelsBuilder.Umbraco;

namespace UmbracoTestProject.Models
{
	/// <summary>Settings</summary>
	[PublishedContentModel("Settings")]
	public partial class Settings : PublishedContentModel
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "Settings";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public Settings(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<Settings, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// Bottom Links
		///</summary>
		[ImplementPropertyType("bottomLinks")]
		public IEnumerable<IPublishedContent> BottomLinks
		{
			get { return this.GetPropertyValue<IEnumerable<IPublishedContent>>("bottomLinks"); }
		}

		///<summary>
		/// Copyright
		///</summary>
		[ImplementPropertyType("copyright")]
		public string Copyright
		{
			get { return this.GetPropertyValue<string>("copyright"); }
		}

		///<summary>
		/// Facebook Url
		///</summary>
		[ImplementPropertyType("facebookUrl")]
		public string FacebookUrl
		{
			get { return this.GetPropertyValue<string>("facebookUrl"); }
		}

		///<summary>
		/// Google Analytics Script: Script for Google Analytics.
		///</summary>
		[ImplementPropertyType("googleAnalyticsScript")]
		public string GoogleAnalyticsScript
		{
			get { return this.GetPropertyValue<string>("googleAnalyticsScript"); }
		}

		///<summary>
		/// Google+ Url
		///</summary>
		[ImplementPropertyType("googleplusUrl")]
		public string GoogleplusUrl
		{
			get { return this.GetPropertyValue<string>("googleplusUrl"); }
		}

		///<summary>
		/// Google Tag Manager NoScript Code: Noscript part of the Google Tag Manager Code.
		///</summary>
		[ImplementPropertyType("googleTagManagerNoScriptCode")]
		public string GoogleTagManagerNoScriptCode
		{
			get { return this.GetPropertyValue<string>("googleTagManagerNoScriptCode"); }
		}

		///<summary>
		/// Google Tag Manager Script Code: Script part of the Google Tag Manager Code.
		///</summary>
		[ImplementPropertyType("googleTagManagerScriptCode")]
		public string GoogleTagManagerScriptCode
		{
			get { return this.GetPropertyValue<string>("googleTagManagerScriptCode"); }
		}

		///<summary>
		/// Left Links
		///</summary>
		[ImplementPropertyType("leftLinks")]
		public IEnumerable<IPublishedContent> LeftLinks
		{
			get { return this.GetPropertyValue<IEnumerable<IPublishedContent>>("leftLinks"); }
		}

		///<summary>
		/// LinkedIn Url
		///</summary>
		[ImplementPropertyType("linkedInUrl")]
		public string LinkedInUrl
		{
			get { return this.GetPropertyValue<string>("linkedInUrl"); }
		}

		///<summary>
		/// Logo
		///</summary>
		[ImplementPropertyType("logo")]
		public IPublishedContent Logo
		{
			get { return this.GetPropertyValue<IPublishedContent>("logo"); }
		}

		///<summary>
		/// Right Links
		///</summary>
		[ImplementPropertyType("rightLinks")]
		public IEnumerable<IPublishedContent> RightLinks
		{
			get { return this.GetPropertyValue<IEnumerable<IPublishedContent>>("rightLinks"); }
		}

		///<summary>
		/// Robots: Content that will be served when Robots.txt is requested.
		///</summary>
		[ImplementPropertyType("robots")]
		public string Robots
		{
			get { return this.GetPropertyValue<string>("robots"); }
		}

		///<summary>
		/// Site Name: Name of the site.
		///</summary>
		[ImplementPropertyType("siteName")]
		public string SiteName
		{
			get { return this.GetPropertyValue<string>("siteName"); }
		}

		///<summary>
		/// Trip Advisor Url
		///</summary>
		[ImplementPropertyType("tripAdvisorUrl")]
		public string TripAdvisorUrl
		{
			get { return this.GetPropertyValue<string>("tripAdvisorUrl"); }
		}

		///<summary>
		/// Twitter Url
		///</summary>
		[ImplementPropertyType("twitterUrl")]
		public string TwitterUrl
		{
			get { return this.GetPropertyValue<string>("twitterUrl"); }
		}
	}
}