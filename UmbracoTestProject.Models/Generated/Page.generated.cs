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
	/// <summary>Page</summary>
	[PublishedContentModel("Page")]
	public partial class Page
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "Page";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<Page, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// Hide from Site Search: If selected, page will be hidden from site search.
		///</summary>
		[ImplementPropertyType("hideFromSiteSearch")]
		public bool HideFromSiteSearch
		{
			get { return this.GetPropertyValue<bool>("hideFromSiteSearch"); }
		}

		///<summary>
		/// Author: Page author, used by search engines.
		///</summary>
		[ImplementPropertyType("seoAuthor")]
		public string SeoAuthor
		{
			get { return this.GetPropertyValue<string>("seoAuthor"); }
		}

		///<summary>
		/// Description: A general description of the page, used by search engines.
		///</summary>
		[ImplementPropertyType("seoDescription")]
		public string SeoDescription
		{
			get { return this.GetPropertyValue<string>("seoDescription"); }
		}

		///<summary>
		/// Keywords: Keywords related to the page content, used by search engines. Separate with commas.
		///</summary>
		[ImplementPropertyType("seoKeywords")]
		public string SeoKeywords
		{
			get { return this.GetPropertyValue<string>("seoKeywords"); }
		}

		///<summary>
		/// Title: Optional page title, used by search engines. If omitted, title (from Content tab) will be used.
		///</summary>
		[ImplementPropertyType("seoTitle")]
		public string SeoTitle
		{
			get { return this.GetPropertyValue<string>("seoTitle"); }
		}

		///<summary>
		/// Items
		///</summary>
		[ImplementPropertyType("sliderItems")]
		public IEnumerable<IPublishedContent> SliderItems
		{
			get { return this.GetPropertyValue<IEnumerable<IPublishedContent>>("sliderItems"); }
		}
	}
}
