//------------------------------------------------------------------------------
// <auto-generated>
//   This code was generated by a tool.
//
//    Umbraco.ModelsBuilder.Embedded v9.0.0-rc001+4f06c1f33a54daf4752a439778626202960db68c
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

namespace Umbraco.Cms.Web.Common.PublishedModels
{
	/// <summary>Chef</summary>
	[PublishedModel("chef")]
	public partial class Chef : PublishedElementModel
	{
		// helpers
#pragma warning disable 0109 // new is redundant
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "9.0.0-rc001+4f06c1f33a54daf4752a439778626202960db68c")]
		public new const string ModelTypeAlias = "chef";
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "9.0.0-rc001+4f06c1f33a54daf4752a439778626202960db68c")]
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "9.0.0-rc001+4f06c1f33a54daf4752a439778626202960db68c")]
		public new static IPublishedContentType GetModelContentType(IPublishedSnapshotAccessor publishedSnapshotAccessor)
			=> PublishedModelUtility.GetModelContentType(publishedSnapshotAccessor, ModelItemType, ModelTypeAlias);
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "9.0.0-rc001+4f06c1f33a54daf4752a439778626202960db68c")]
		public static IPublishedPropertyType GetModelPropertyType<TValue>(IPublishedSnapshotAccessor publishedSnapshotAccessor, Expression<Func<Chef, TValue>> selector)
			=> PublishedModelUtility.GetModelPropertyType(GetModelContentType(publishedSnapshotAccessor), selector);
#pragma warning restore 0109

		private IPublishedValueFallback _publishedValueFallback;

		// ctor
		public Chef(IPublishedElement content, IPublishedValueFallback publishedValueFallback)
			: base(content, publishedValueFallback)
		{
			_publishedValueFallback = publishedValueFallback;
		}

		// properties

		///<summary>
		/// Chef Designation
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "9.0.0-rc001+4f06c1f33a54daf4752a439778626202960db68c")]
		[ImplementPropertyType("chefDesignation")]
		public virtual string ChefDesignation => this.Value<string>(_publishedValueFallback, "chefDesignation");

		///<summary>
		/// Chef Facebook link
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "9.0.0-rc001+4f06c1f33a54daf4752a439778626202960db68c")]
		[ImplementPropertyType("chefFacebookLink")]
		public virtual global::Umbraco.Cms.Core.Models.Link ChefFacebookLink => this.Value<global::Umbraco.Cms.Core.Models.Link>(_publishedValueFallback, "chefFacebookLink");

		///<summary>
		/// Chef Image
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "9.0.0-rc001+4f06c1f33a54daf4752a439778626202960db68c")]
		[ImplementPropertyType("chefImage")]
		public virtual global::Umbraco.Core.Models.MediaWithCrops ChefImage => this.Value<global::Umbraco.Core.Models.MediaWithCrops>(_publishedValueFallback, "chefImage");

		///<summary>
		/// Chef Instagram link
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "9.0.0-rc001+4f06c1f33a54daf4752a439778626202960db68c")]
		[ImplementPropertyType("chefInstagramLink")]
		public virtual global::Umbraco.Cms.Core.Models.Link ChefInstagramLink => this.Value<global::Umbraco.Cms.Core.Models.Link>(_publishedValueFallback, "chefInstagramLink");

		///<summary>
		/// Chef Name
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "9.0.0-rc001+4f06c1f33a54daf4752a439778626202960db68c")]
		[ImplementPropertyType("chefName")]
		public virtual string ChefName => this.Value<string>(_publishedValueFallback, "chefName");

		///<summary>
		/// Chef profile link
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "9.0.0-rc001+4f06c1f33a54daf4752a439778626202960db68c")]
		[ImplementPropertyType("chefProfileLink")]
		public virtual global::Umbraco.Cms.Core.Models.Link ChefProfileLink => this.Value<global::Umbraco.Cms.Core.Models.Link>(_publishedValueFallback, "chefProfileLink");

		///<summary>
		/// Chef twitter link
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "9.0.0-rc001+4f06c1f33a54daf4752a439778626202960db68c")]
		[ImplementPropertyType("chefTwitterLink")]
		public virtual global::Umbraco.Cms.Core.Models.Link ChefTwitterLink => this.Value<global::Umbraco.Cms.Core.Models.Link>(_publishedValueFallback, "chefTwitterLink");
	}
}