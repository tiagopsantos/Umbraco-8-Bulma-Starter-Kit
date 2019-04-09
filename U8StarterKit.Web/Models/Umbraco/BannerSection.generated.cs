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
	/// <summary>Banner</summary>
	[PublishedModel("bannerSection")]
	public partial class BannerSection : PublishedElementModel, IColourSettingsComposition, IFontAwesomeComposition
	{
		// helpers
#pragma warning disable 0109 // new is redundant
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.0.4")]
		public new const string ModelTypeAlias = "bannerSection";
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.0.4")]
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.0.4")]
		public new static PublishedContentType GetModelContentType()
			=> PublishedModelUtility.GetModelContentType(ModelItemType, ModelTypeAlias);
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.0.4")]
		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<BannerSection, TValue>> selector)
			=> PublishedModelUtility.GetModelPropertyType(GetModelContentType(), selector);
#pragma warning restore 0109

		// ctor
		public BannerSection(IPublishedElement content)
			: base(content)
		{ }

		// properties

		///<summary>
		/// Background
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.0.4")]
		[ImplementPropertyType("background")]
		public IPublishedContent Background => this.Value<IPublishedContent>("background");

		///<summary>
		/// Primary Link
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.0.4")]
		[ImplementPropertyType("primaryLink")]
		public global::Umbraco.Web.Models.Link PrimaryLink => this.Value<global::Umbraco.Web.Models.Link>("primaryLink");

		///<summary>
		/// Secondary Link
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.0.4")]
		[ImplementPropertyType("secondaryLink")]
		public global::Umbraco.Web.Models.Link SecondaryLink => this.Value<global::Umbraco.Web.Models.Link>("secondaryLink");

		///<summary>
		/// Secondary Link Before Text
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.0.4")]
		[ImplementPropertyType("secondaryLinkBeforeText")]
		public string SecondaryLinkBeforeText => this.Value<string>("secondaryLinkBeforeText");

		///<summary>
		/// Subtitle
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.0.4")]
		[ImplementPropertyType("subtitle")]
		public IHtmlString Subtitle => this.Value<IHtmlString>("subtitle");

		///<summary>
		/// Title
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.0.4")]
		[ImplementPropertyType("title")]
		public string Title => this.Value<string>("title");

		///<summary>
		/// Background Color
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.0.4")]
		[ImplementPropertyType("backgroundColor")]
		public global::Umbraco.Core.PropertyEditors.ValueConverters.ColorPickerValueConverter.PickedColor BackgroundColor => ColourSettingsComposition.GetBackgroundColor(this);

		///<summary>
		/// Font Awesome Class: See the font awesome icon class name. Eg. "fas fa-cube"
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.0.4")]
		[ImplementPropertyType("fontAwesomeClass")]
		public string FontAwesomeClass => FontAwesomeComposition.GetFontAwesomeClass(this);

		///<summary>
		/// Font Awesome Size
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.0.4")]
		[ImplementPropertyType("fontAwesomeSize")]
		public string FontAwesomeSize => FontAwesomeComposition.GetFontAwesomeSize(this);
	}
}