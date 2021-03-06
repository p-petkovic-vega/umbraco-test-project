﻿using Umbraco.Core.Models;
using Umbraco.Core.Models.PublishedContent;
using Umbraco.ModelsBuilder;
using Umbraco.Web;
using UmbracoTestProject.Models.DocumentTypes;
using UmbracoTestProject.Models.Extensions;

namespace UmbracoTestProject.Models
{
	/// <summary>
	/// Navigation node document type model.
	/// </summary>
	/// <seealso cref="UmbracoTestProject.Models.DocumentTypes.INavigationNode"/>
	public partial class NavigationNode : PublishedContentModel, INavigationNode
	{
		public NavigationNode(IPublishedContent content) : base(content)
		{ }

		///<summary>
		/// Hide from Site Navigation: If selected, node will be hidden from site navigation.
		///</summary>
		[ImplementPropertyType("umbracoNaviHide")]
		public virtual bool HideFromSiteNavigation => !this.IsVisible();

		///<summary>
		/// Hide from Sitemap: If selected, node will be hidden from the sitemap.
		///</summary>
		[ImplementPropertyType("hideFromSitemap")]
		public virtual bool HideFromSitemap => this.GetPropertyValue<bool>();
	}
}
