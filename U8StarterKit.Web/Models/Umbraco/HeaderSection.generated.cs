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
	// Mixin Content Type with alias "headerSection"
	/// <summary>Header Section</summary>
	public partial interface IHeaderSection : IPublishedContent
	{
		/// <summary>Subtitle</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.0.4")]
		IHtmlString HeaderSubtitle { get; }

		/// <summary>Title</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.0.4")]
		string HeaderTitle { get; }
	}

	/// <summary>Header Section</summary>
	[PublishedModel("headerSection")]
	public partial class HeaderSection : PublishedContentModel, IHeaderSection
	{
		// helpers
#pragma warning disable 0109 // new is redundant
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.0.4")]
		public new const string ModelTypeAlias = "headerSection";
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.0.4")]
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.0.4")]
		public new static PublishedContentType GetModelContentType()
			=> PublishedModelUtility.GetModelContentType(ModelItemType, ModelTypeAlias);
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.0.4")]
		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<HeaderSection, TValue>> selector)
			=> PublishedModelUtility.GetModelPropertyType(GetModelContentType(), selector);
#pragma warning restore 0109

		// ctor
		public HeaderSection(IPublishedContent content)
			: base(content)
		{ }

		// properties

		///<summary>
		/// Subtitle
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.0.4")]
		[ImplementPropertyType("headerSubtitle")]
		public IHtmlString HeaderSubtitle => GetHeaderSubtitle(this);

		/// <summary>Static getter for Subtitle</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.0.4")]
		public static IHtmlString GetHeaderSubtitle(IHeaderSection that) => that.Value<IHtmlString>("headerSubtitle");

		///<summary>
		/// Title
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.0.4")]
		[ImplementPropertyType("headerTitle")]
		public string HeaderTitle => GetHeaderTitle(this);

		/// <summary>Static getter for Title</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.0.4")]
		public static string GetHeaderTitle(IHeaderSection that) => that.Value<string>("headerTitle");
	}
}
