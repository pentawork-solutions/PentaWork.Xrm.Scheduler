using System;
using System.Linq;
using System.Diagnostics;
using System.ComponentModel;
using Microsoft.Xrm.Sdk; 
using Microsoft.Xrm.Sdk.Client;
using System.Collections.Generic;

namespace PentaWork.Xrm.Scheduler.Proxies.Entities
{
	[DebuggerDisplay("{Name}")] 	
	[EntityLogicalName("languagelocale")]
	public sealed class Language : Entity
	{	
		public static readonly int? EntityTypeCode = 9957;
		public new const string LogicalName = "languagelocale";
		public const string PrimaryIdAttribute = "languagelocaleid";
		public const string PrimaryNameAttribute = "name";
	
		public Language() : base("languagelocale") { }

		#region Attributes
		/// <summary>
        /// code
        /// </summary>
		[DisplayName("Code")]
		[AttributeLogicalName("code")]
		public string Code
		{	
			get { return GetAttributeValue<string>("code"); }
			set
			{ 
				if(value == Code) return;
				SetAttributeValue("code", value);
			}
		}	
			
		/// <summary>
        /// language
        /// </summary>
		[DisplayName("Language")]
		[AttributeLogicalName("language")]
		public string Language2
		{	
			get { return GetAttributeValue<string>("language"); }
			set
			{ 
				if(value == Language2) return;
				SetAttributeValue("language", value);
			}
		}	
			
		/// <summary>
        /// languagelocaleid
        /// </summary>
		[DisplayName("languagelocaleid")]
		[AttributeLogicalName("languagelocaleid")]
		public override Guid Id
		{
			get => base.Id;
			set { base.Id = value; SetAttributeValue("languagelocaleid", value); }
		}

							/// <summary>
        /// localeid
        /// </summary>
		[DisplayName("Locale ID")]
		[AttributeLogicalName("localeid")]
		public int? LocaleID
		{	
			get { return GetAttributeValue<int?>("localeid"); }
			set
			{ 
				if(value == LocaleID) return;
				SetAttributeValue("localeid", value);
			}
		}	
			
		/// <summary>
        /// name
        /// </summary>
		[DisplayName("Name")]
		[AttributeLogicalName("name")]
		public string Name
		{	
			get { return GetAttributeValue<string>("name"); }
			set
			{ 
				if(value == Name) return;
				SetAttributeValue("name", value);
			}
		}	
			
		/// <summary>
        /// organizationid
        /// </summary>
		[DisplayName("Organization")]
		[AttributeLogicalName("organizationid")]
		public EntityReference Organization
		{	
			get { return GetAttributeValue<EntityReference>("organizationid"); }
			set
			{ 
				if(value == Organization) return;
				SetAttributeValue("organizationid", value);
			}
		}	
			
		/// <summary>
        /// region
        /// </summary>
		[DisplayName("Region")]
		[AttributeLogicalName("region")]
		public string Region
		{	
			get { return GetAttributeValue<string>("region"); }
			set
			{ 
				if(value == Region) return;
				SetAttributeValue("region", value);
			}
		}	
			
		/// <summary>
        /// statecode
        /// </summary>
		[DisplayName("State Code")]
		[AttributeLogicalName("statecode")]
		public eStatus? StateCode
		{	
			get 
			{ 
				var optionSetValue = GetAttributeValue<OptionSetValue>("statecode");
				if (optionSetValue != null) return (eStatus)optionSetValue.Value;
				else return null;
			}
			set 
			{ 
				if(value == StateCode) return;

				OptionSetValue optionSetValue = null;
				if(value != null) optionSetValue = new OptionSetValue((int)value);
				SetAttributeValue("statecode", optionSetValue); 
			}
		}

		/// <summary>
        /// statuscode
        /// </summary>
		[DisplayName("Language Status Code")]
		[AttributeLogicalName("statuscode")]
		public eStatus2? LanguageStatusCode
		{	
			get 
			{ 
				var optionSetValue = GetAttributeValue<OptionSetValue>("statuscode");
				if (optionSetValue != null) return (eStatus2)optionSetValue.Value;
				else return null;
			}
			set 
			{ 
				if(value == LanguageStatusCode) return;

				OptionSetValue optionSetValue = null;
				if(value != null) optionSetValue = new OptionSetValue((int)value);
				SetAttributeValue("statuscode", optionSetValue); 
			}
		}

		/// <summary>
        /// versionnumber
        /// </summary>
		[DisplayName("versionnumber")]
		[AttributeLogicalName("versionnumber")]
		public int? Versionnumber
		{	
			get { return GetAttributeValue<int?>("versionnumber"); }
			set
			{ 
				if(value == Versionnumber) return;
				SetAttributeValue("versionnumber", value);
			}
		}	
			
		#endregion	

		#region Relations
			/// <summary>
        /// 1:N Get entities for 'knowledgearticle_languagelocaleid'
        /// </summary>
		[RelationshipSchemaName("knowledgearticle_languagelocaleid")]
		public IEnumerable<KnowledgeArticle> KnowledgearticleLanguagelocaleid
		{
			get { return GetRelatedEntities<KnowledgeArticle>("knowledgearticle_languagelocaleid", null); }
			set { SetRelatedEntities("knowledgearticle_languagelocaleid", null, value); }
		}
		#endregion

		#region Actions
		#endregion

		#region OptionSetEnums
		public enum eStatus
		{	
		
			[Label("Active")]
			[Description(@"")]
			Active = 0, 
		
			[Label("Inactive")]
			[Description(@"")]
			Inactive = 1, 
		}
		
		public enum eStatus2
		{	
		
			[Label("Active")]
			[Description(@"")]
			Active_Active = 1, 
		
			[Label("Inactive")]
			[Description(@"")]
			Inactive_Inactive = 2, 
		}
		
		#endregion	

		#region Properties
		public static class Properties 
		{
			/// <summary>code</summary>
			public const string Code = "code";

			/// <summary>language</summary>
			public const string Language2 = "language";

			/// <summary>languagelocaleid</summary>
			public const string LanguagelocaleId = "languagelocaleid";

			/// <summary>localeid</summary>
			public const string LocaleID = "localeid";

			/// <summary>name</summary>
			public const string Name = "name";

			/// <summary>organizationid</summary>
			public const string Organization = "organizationid";

			/// <summary>region</summary>
			public const string Region = "region";

			/// <summary>statecode</summary>
			public const string StateCode = "statecode";

			/// <summary>statuscode</summary>
			public const string LanguageStatusCode = "statuscode";

			/// <summary>versionnumber</summary>
			public const string Versionnumber = "versionnumber";

		}
		#endregion

		#region Schemas
		public static class Schemas 
		{
			/// <summary>1:N knowledgearticle_languagelocaleid</summary>
			public const string KnowledgearticleLanguagelocaleid = "knowledgearticle_languagelocaleid";

		}
		#endregion
	}
}

