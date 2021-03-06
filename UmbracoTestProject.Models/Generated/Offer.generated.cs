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
	/// <summary>Offer</summary>
	[PublishedContentModel("offer")]
	public partial class Offer : Page
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "offer";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public Offer(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<Offer, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// Link
		///</summary>
		[ImplementPropertyType("leftColumnLink")]
		public RJP.MultiUrlPicker.Models.Link LeftColumnLink
		{
			get { return this.GetPropertyValue<RJP.MultiUrlPicker.Models.Link>("leftColumnLink"); }
		}

		///<summary>
		/// Text
		///</summary>
		[ImplementPropertyType("leftColumnText")]
		public IHtmlString LeftColumnText
		{
			get { return this.GetPropertyValue<IHtmlString>("leftColumnText"); }
		}

		///<summary>
		/// Price
		///</summary>
		[ImplementPropertyType("previewPrice")]
		public string PreviewPrice
		{
			get { return this.GetPropertyValue<string>("previewPrice"); }
		}

		///<summary>
		/// Summary
		///</summary>
		[ImplementPropertyType("previewSummary")]
		public string PreviewSummary
		{
			get { return this.GetPropertyValue<string>("previewSummary"); }
		}

		///<summary>
		/// Title
		///</summary>
		[ImplementPropertyType("previewTitle")]
		public string PreviewTitle
		{
			get { return this.GetPropertyValue<string>("previewTitle"); }
		}

		///<summary>
		/// Text
		///</summary>
		[ImplementPropertyType("rightColumnText")]
		public IHtmlString RightColumnText
		{
			get { return this.GetPropertyValue<IHtmlString>("rightColumnText"); }
		}
	}
}
