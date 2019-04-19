//------------------------------------------------------------------------------
// <auto-generated>
//   This code was generated by a tool.
//
//    Umbraco.ModelsBuilder v8.0.4
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

namespace U8StarterKit.Web.Models.Umbraco
{
	/// <summary>Application Configuration</summary>
	[PublishedModel("appConfig")]
	public partial class AppConfig : PublishedContentModel, IFooterSection, INavigation
	{
		// helpers
#pragma warning disable 0109 // new is redundant
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.0.4")]
		public new const string ModelTypeAlias = "appConfig";
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.0.4")]
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.0.4")]
		public new static PublishedContentType GetModelContentType()
			=> PublishedModelUtility.GetModelContentType(ModelItemType, ModelTypeAlias);
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.0.4")]
		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<AppConfig, TValue>> selector)
			=> PublishedModelUtility.GetModelPropertyType(GetModelContentType(), selector);
#pragma warning restore 0109

		// ctor
		public AppConfig(IPublishedContent content)
			: base(content)
		{ }

		// properties

		///<summary>
		/// Nested Footer
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.0.4")]
		[ImplementPropertyType("nestedFooter")]
		public IEnumerable<IPublishedElement> NestedFooter => FooterSection.GetNestedFooter(this);

		///<summary>
		/// Brand Logo: Pick Font Awesome Logo
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.0.4")]
		[ImplementPropertyType("brandLogo")]
		public IEnumerable<FaLinksPropertyEditor.PropertyValueConverters.FaLink> BrandLogo => Navigation.GetBrandLogo(this);

		///<summary>
		/// Left Nav
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.0.4")]
		[ImplementPropertyType("leftNav")]
		public IEnumerable<FaLinksPropertyEditor.PropertyValueConverters.FaLink> LeftNav => Navigation.GetLeftNav(this);

		///<summary>
		/// Right Nav
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.0.4")]
		[ImplementPropertyType("rightNav")]
		public IEnumerable<FaLinksPropertyEditor.PropertyValueConverters.FaLink> RightNav => Navigation.GetRightNav(this);

		///<summary>
		/// Utility Links: Add utility links, eg. "sign up", "log in"
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.0.4")]
		[ImplementPropertyType("utilityLinks")]
		public IEnumerable<FaLinksPropertyEditor.PropertyValueConverters.FaLink> UtilityLinks => Navigation.GetUtilityLinks(this);
	}
}
