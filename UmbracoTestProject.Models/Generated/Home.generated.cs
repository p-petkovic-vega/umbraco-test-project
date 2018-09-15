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
	/// <summary>Home</summary>
	[PublishedContentModel("home")]
	public partial class Home : Page
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "home";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public Home(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<Home, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// Boxes
		///</summary>
		[ImplementPropertyType("boxes")]
		public IEnumerable<IPublishedContent> Boxes
		{
			get { return this.GetPropertyValue<IEnumerable<IPublishedContent>>("boxes"); }
		}

		///<summary>
		/// Subtitle: Note: Starting and ending em tags could be used.
		///</summary>
		[ImplementPropertyType("subtitle")]
		public string Subtitle
		{
			get { return this.GetPropertyValue<string>("subtitle"); }
		}
	}
}
