//------------------------------------------------------------------------------
// <auto-generated>
//   This code was generated by a tool.
//
//    Umbraco.ModelsBuilder.Embedded v10.6.1+82eae48
//
//   Changes to this file will be lost if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Linq.Expressions;
using Umbraco.Cms.Core.Models.PublishedContent;
using Umbraco.Cms.Core.PublishedCache;
using Umbraco.Cms.Infrastructure.ModelsBuilder;
using Umbraco.Cms.Core;
using Umbraco.Extensions;

namespace Crif.It.Models
{
	/// <summary>Trend Topic Tag</summary>
	[PublishedModel("trendTopicTag")]
	public partial class TrendTopicTag : PublishedContentModel, ISEO
	{
		// helpers
#pragma warning disable 0109 // new is redundant
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "10.6.1+82eae48")]
		public new const string ModelTypeAlias = "trendTopicTag";
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "10.6.1+82eae48")]
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "10.6.1+82eae48")]
		[return: global::System.Diagnostics.CodeAnalysis.MaybeNull]
		public new static IPublishedContentType GetModelContentType(IPublishedSnapshotAccessor publishedSnapshotAccessor)
			=> PublishedModelUtility.GetModelContentType(publishedSnapshotAccessor, ModelItemType, ModelTypeAlias);
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "10.6.1+82eae48")]
		[return: global::System.Diagnostics.CodeAnalysis.MaybeNull]
		public static IPublishedPropertyType GetModelPropertyType<TValue>(IPublishedSnapshotAccessor publishedSnapshotAccessor, Expression<Func<TrendTopicTag, TValue>> selector)
			=> PublishedModelUtility.GetModelPropertyType(GetModelContentType(publishedSnapshotAccessor), selector);
#pragma warning restore 0109

		private IPublishedValueFallback _publishedValueFallback;

		// ctor
		public TrendTopicTag(IPublishedContent content, IPublishedValueFallback publishedValueFallback)
			: base(content, publishedValueFallback)
		{
			_publishedValueFallback = publishedValueFallback;
		}

		// properties

		///<summary>
		/// Trend Topic Abstract
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "10.6.1+82eae48")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("abstractTrendTopic")]
		public virtual string AbstractTrendTopic => this.Value<string>(_publishedValueFallback, "abstractTrendTopic");

		///<summary>
		/// More Blocks: These blocks will be shown after the automatic content listing section
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "10.6.1+82eae48")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("altriBlocchi")]
		public virtual global::Umbraco.Cms.Core.Models.Blocks.BlockListModel AltriBlocchi => this.Value<global::Umbraco.Cms.Core.Models.Blocks.BlockListModel>(_publishedValueFallback, "altriBlocchi");

		///<summary>
		/// Items Per Page
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "10.6.1+82eae48")]
		[ImplementPropertyType("elementiPerPagina")]
		public virtual int ElementiPerPagina => this.Value<int>(_publishedValueFallback, "elementiPerPagina");

		///<summary>
		/// Trend Topic Icon
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "10.6.1+82eae48")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("iconaTrendTopic")]
		public virtual global::Umbraco.Cms.Core.Models.MediaWithCrops IconaTrendTopic => this.Value<global::Umbraco.Cms.Core.Models.MediaWithCrops>(_publishedValueFallback, "iconaTrendTopic");

		///<summary>
		/// Trend Topic Image
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "10.6.1+82eae48")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("immagineTrendTopic")]
		public virtual global::Umbraco.Cms.Core.Models.MediaWithCrops ImmagineTrendTopic => this.Value<global::Umbraco.Cms.Core.Models.MediaWithCrops>(_publishedValueFallback, "immagineTrendTopic");

		///<summary>
		/// Show Listings
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "10.6.1+82eae48")]
		[ImplementPropertyType("mostrareListing")]
		public virtual bool MostrareListing => this.Value<bool>(_publishedValueFallback, "mostrareListing");

		///<summary>
		/// Show Automatic Section
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "10.6.1+82eae48")]
		[ImplementPropertyType("mostrareSezioneAutomatica")]
		public virtual bool MostrareSezioneAutomatica => this.Value<bool>(_publishedValueFallback, "mostrareSezioneAutomatica");

		///<summary>
		/// Custom Order
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "10.6.1+82eae48")]
		[ImplementPropertyType("ordineCustom")]
		public virtual int OrdineCustom => this.Value<int>(_publishedValueFallback, "ordineCustom");

		///<summary>
		/// First Blocks: These blocks will be shown before the automatic content listing section
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "10.6.1+82eae48")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("primiBlocchi")]
		public virtual global::Umbraco.Cms.Core.Models.Blocks.BlockListModel PrimiBlocchi => this.Value<global::Umbraco.Cms.Core.Models.Blocks.BlockListModel>(_publishedValueFallback, "primiBlocchi");

		///<summary>
		/// Listing Title
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "10.6.1+82eae48")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("titoloListing")]
		public virtual string TitoloListing => this.Value<string>(_publishedValueFallback, "titoloListing");

		///<summary>
		/// Automatic Section Title
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "10.6.1+82eae48")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("titoloSezioneAutomatica")]
		public virtual string TitoloSezioneAutomatica => this.Value<string>(_publishedValueFallback, "titoloSezioneAutomatica");

		///<summary>
		/// Last Blocks: These blocks will be shown after the automatic section
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "10.6.1+82eae48")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("ultimiBlocchi")]
		public virtual global::Umbraco.Cms.Core.Models.Blocks.BlockListModel UltimiBlocchi => this.Value<global::Umbraco.Cms.Core.Models.Blocks.BlockListModel>(_publishedValueFallback, "ultimiBlocchi");

		///<summary>
		/// Add Special Children
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "10.6.1+82eae48")]
		[ImplementPropertyType("addSpecialChildren")]
		public virtual bool AddSpecialChildren => global::Crif.It.Models.SEO.GetAddSpecialChildren(this, _publishedValueFallback);

		///<summary>
		/// Hide Children In Menu: Hide all the children of this page
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "10.6.1+82eae48")]
		[ImplementPropertyType("hideChildrenInMenu")]
		public virtual bool HideChildrenInMenu => global::Crif.It.Models.SEO.GetHideChildrenInMenu(this, _publishedValueFallback);

		///<summary>
		/// Hide From Xml Sitemap
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "10.6.1+82eae48")]
		[ImplementPropertyType("hideFromXmlSitemap")]
		public virtual bool HideFromXmlSitemap => global::Crif.It.Models.SEO.GetHideFromXmlSitemap(this, _publishedValueFallback);

		///<summary>
		/// Hide In Menu: Hide this page and all its children
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "10.6.1+82eae48")]
		[ImplementPropertyType("hideInMenu")]
		public virtual bool HideInMenu => global::Crif.It.Models.SEO.GetHideInMenu(this, _publishedValueFallback);

		///<summary>
		/// Internal Rewrite: If set, the current document is redirected to the selected page with an internal rewrite (code 200 OK)
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "10.6.1+82eae48")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("internalRewrite")]
		public virtual global::Umbraco.Cms.Core.Models.PublishedContent.IPublishedContent InternalRewrite => global::Crif.It.Models.SEO.GetInternalRewrite(this, _publishedValueFallback);

		///<summary>
		/// Meta Description: Meta descriptions are HTML attributes that provide concise explanations of the content of web pages.
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "10.6.1+82eae48")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("metaDescription")]
		public virtual string MetaDescription => global::Crif.It.Models.SEO.GetMetaDescription(this, _publishedValueFallback);

		///<summary>
		/// Meta Robots: Leave blank if INDEX, FOLLOW is fine for this page; overwrite otherwise.
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "10.6.1+82eae48")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("metaRobots")]
		public virtual string MetaRobots => global::Crif.It.Models.SEO.GetMetaRobots(this, _publishedValueFallback);

		///<summary>
		/// Open Graph Description
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "10.6.1+82eae48")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("openGraphDescription")]
		public virtual string OpenGraphDescription => global::Crif.It.Models.SEO.GetOpenGraphDescription(this, _publishedValueFallback);

		///<summary>
		/// Open Graph Image: The Image to be used as a preview for social media sharing
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "10.6.1+82eae48")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("openGraphImage")]
		public virtual global::Umbraco.Cms.Core.Models.MediaWithCrops OpenGraphImage => global::Crif.It.Models.SEO.GetOpenGraphImage(this, _publishedValueFallback);

		///<summary>
		/// Open Graph title
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "10.6.1+82eae48")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("openGraphTitle")]
		public virtual string OpenGraphTitle => global::Crif.It.Models.SEO.GetOpenGraphTitle(this, _publishedValueFallback);

		///<summary>
		/// Search Engine Change Frequency
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "10.6.1+82eae48")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("searchEngineChangeFrequency")]
		public virtual string SearchEngineChangeFrequency => global::Crif.It.Models.SEO.GetSearchEngineChangeFrequency(this, _publishedValueFallback);

		///<summary>
		/// Search Engine Relative Priority
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "10.6.1+82eae48")]
		[ImplementPropertyType("searchEngineRelativePriority")]
		public virtual decimal SearchEngineRelativePriority => global::Crif.It.Models.SEO.GetSearchEngineRelativePriority(this, _publishedValueFallback);

		///<summary>
		/// Special Child
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "10.6.1+82eae48")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("specialChild")]
		public virtual global::Umbraco.Cms.Core.Models.PublishedContent.IPublishedContent SpecialChild => global::Crif.It.Models.SEO.GetSpecialChild(this, _publishedValueFallback);

		///<summary>
		/// Special Child Label
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "10.6.1+82eae48")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("specialChildLabel")]
		public virtual string SpecialChildLabel => global::Crif.It.Models.SEO.GetSpecialChildLabel(this, _publishedValueFallback);

		///<summary>
		/// Meta Title: The meta title appears in the bar at the top of your browser window
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "10.6.1+82eae48")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("title")]
		public virtual string Title => global::Crif.It.Models.SEO.GetTitle(this, _publishedValueFallback);

		///<summary>
		/// Internal Redirect 302: If set, the current document is redirected to the selected page with a 302 code
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "10.6.1+82eae48")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("umbracoRedirect")]
		public virtual global::Umbraco.Cms.Core.Models.PublishedContent.IPublishedContent UmbracoRedirect => global::Crif.It.Models.SEO.GetUmbracoRedirect(this, _publishedValueFallback);

		///<summary>
		/// Url Alias: This property when created as a text string lets you provide a comma separated list of alternate full URL paths for the node.
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "10.6.1+82eae48")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("umbracoUrlAlias")]
		public virtual string UmbracoUrlAlias => global::Crif.It.Models.SEO.GetUmbracoUrlAlias(this, _publishedValueFallback);

		///<summary>
		/// Url Name: Use this property to override umbraco default url. Use only lowercase and replace gaps with dashes
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "10.6.1+82eae48")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("umbracoUrlName")]
		public virtual string UmbracoUrlName => global::Crif.It.Models.SEO.GetUmbracoUrlName(this, _publishedValueFallback);
	}
}
