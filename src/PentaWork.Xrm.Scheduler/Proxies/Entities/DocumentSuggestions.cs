using System;
using System.Linq;
using System.Diagnostics;
using System.ComponentModel;
using Microsoft.Xrm.Sdk; 
using Microsoft.Xrm.Sdk.Client;
using System.Collections.Generic;

namespace PentaWork.Xrm.Scheduler.Proxies.Entities
{
	[DebuggerDisplay("{Title}")] 	
	[EntityLogicalName("recommendeddocument")]
	public sealed class DocumentSuggestions : Entity
	{	
		public static readonly int? EntityTypeCode = 1189;
		public new const string LogicalName = "recommendeddocument";
		public const string PrimaryIdAttribute = "recommendeddocumentid";
		public const string PrimaryNameAttribute = "title";
	
		public DocumentSuggestions() : base("recommendeddocument") { }

		#region Attributes
		/// <summary>
        /// absoluteurl
        /// </summary>
		[DisplayName("Absolute URL")]
		[AttributeLogicalName("absoluteurl")]
		public string AbsoluteURL
		{	
			get { return GetAttributeValue<string>("absoluteurl"); }
			set
			{ 
				if(value == AbsoluteURL) return;
				SetAttributeValue("absoluteurl", value);
			}
		}	
			
		/// <summary>
        /// associatedrecordname
        /// </summary>
		[DisplayName("Associated Record Name")]
		[AttributeLogicalName("associatedrecordname")]
		public string AssociatedRecordName
		{	
			get { return GetAttributeValue<string>("associatedrecordname"); }
			set
			{ 
				if(value == AssociatedRecordName) return;
				SetAttributeValue("associatedrecordname", value);
			}
		}	
			
		/// <summary>
        /// author
        /// </summary>
		[DisplayName("Author")]
		[AttributeLogicalName("author")]
		public string Author
		{	
			get { return GetAttributeValue<string>("author"); }
			set
			{ 
				if(value == Author) return;
				SetAttributeValue("author", value);
			}
		}	
			
		/// <summary>
        /// contenttype
        /// </summary>
		[DisplayName("Content Type")]
		[AttributeLogicalName("contenttype")]
		public string ContentType
		{	
			get { return GetAttributeValue<string>("contenttype"); }
			set
			{ 
				if(value == ContentType) return;
				SetAttributeValue("contenttype", value);
			}
		}	
			
		/// <summary>
        /// createdby
        /// </summary>
		[DisplayName("Created By")]
		[AttributeLogicalName("createdby")]
		public EntityReference CreatedBy
		{	
			get { return GetAttributeValue<EntityReference>("createdby"); }
			set
			{ 
				if(value == CreatedBy) return;
				SetAttributeValue("createdby", value);
			}
		}	
			
		/// <summary>
        /// createdbyname
        /// </summary>
		[DisplayName("createdbyname")]
		[AttributeLogicalName("createdbyname")]
		public string Createdbyname
		{	
			get { return GetAttributeValue<string>("createdbyname"); }
			set
			{ 
				if(value == Createdbyname) return;
				SetAttributeValue("createdbyname", value);
			}
		}	
			
		/// <summary>
        /// createdbyyominame
        /// </summary>
		[DisplayName("createdbyyominame")]
		[AttributeLogicalName("createdbyyominame")]
		public string Createdbyyominame
		{	
			get { return GetAttributeValue<string>("createdbyyominame"); }
			set
			{ 
				if(value == Createdbyyominame) return;
				SetAttributeValue("createdbyyominame", value);
			}
		}	
			
		/// <summary>
        /// createdon
        /// </summary>
		[DisplayName("Created On")]
		[AttributeLogicalName("createdon")]
		public DateTime? CreatedOn
		{	
			get { return GetAttributeValue<DateTime?>("createdon"); }
			set
			{ 
				if(value == CreatedOn) return;
				SetAttributeValue("createdon", value);
			}
		}	
			
		/// <summary>
        /// createdonbehalfby
        /// </summary>
		[DisplayName("Created By (Delegate)")]
		[AttributeLogicalName("createdonbehalfby")]
		public EntityReference CreatedByDelegate
		{	
			get { return GetAttributeValue<EntityReference>("createdonbehalfby"); }
			set
			{ 
				if(value == CreatedByDelegate) return;
				SetAttributeValue("createdonbehalfby", value);
			}
		}	
			
		/// <summary>
        /// createdonbehalfbyname
        /// </summary>
		[DisplayName("createdonbehalfbyname")]
		[AttributeLogicalName("createdonbehalfbyname")]
		public string Createdonbehalfbyname
		{	
			get { return GetAttributeValue<string>("createdonbehalfbyname"); }
			set
			{ 
				if(value == Createdonbehalfbyname) return;
				SetAttributeValue("createdonbehalfbyname", value);
			}
		}	
			
		/// <summary>
        /// createdonbehalfbyyominame
        /// </summary>
		[DisplayName("createdonbehalfbyyominame")]
		[AttributeLogicalName("createdonbehalfbyyominame")]
		public string Createdonbehalfbyyominame
		{	
			get { return GetAttributeValue<string>("createdonbehalfbyyominame"); }
			set
			{ 
				if(value == Createdonbehalfbyyominame) return;
				SetAttributeValue("createdonbehalfbyyominame", value);
			}
		}	
			
		/// <summary>
        /// editurl
        /// </summary>
		[DisplayName("Edit Web App URL")]
		[AttributeLogicalName("editurl")]
		public string EditWebAppURL
		{	
			get { return GetAttributeValue<string>("editurl"); }
			set
			{ 
				if(value == EditWebAppURL) return;
				SetAttributeValue("editurl", value);
			}
		}	
			
		/// <summary>
        /// exchangerate
        /// </summary>
		[DisplayName("ExchangeRate")]
		[AttributeLogicalName("exchangerate")]
		public decimal? ExchangeRate
		{	
			get { return GetAttributeValue<decimal?>("exchangerate"); }
			set
			{ 
				if(value == ExchangeRate) return;
				SetAttributeValue("exchangerate", value);
			}
		}	
			
		/// <summary>
        /// externaldocumentid
        /// </summary>
		[DisplayName("External Document ID")]
		[AttributeLogicalName("externaldocumentid")]
		public string ExternalDocumentID
		{	
			get { return GetAttributeValue<string>("externaldocumentid"); }
			set
			{ 
				if(value == ExternalDocumentID) return;
				SetAttributeValue("externaldocumentid", value);
			}
		}	
			
		/// <summary>
        /// externalmodifiedby
        /// </summary>
		[DisplayName("Modified by")]
		[AttributeLogicalName("externalmodifiedby")]
		public string ModifiedBy
		{	
			get { return GetAttributeValue<string>("externalmodifiedby"); }
			set
			{ 
				if(value == ModifiedBy) return;
				SetAttributeValue("externalmodifiedby", value);
			}
		}	
			
		/// <summary>
        /// filesize
        /// </summary>
		[DisplayName("File Size")]
		[AttributeLogicalName("filesize")]
		public int? FileSize
		{	
			get { return GetAttributeValue<int?>("filesize"); }
			set
			{ 
				if(value == FileSize) return;
				SetAttributeValue("filesize", value);
			}
		}	
			
		/// <summary>
        /// filetype
        /// </summary>
		[DisplayName("File Type")]
		[AttributeLogicalName("filetype")]
		public string FileType
		{	
			get { return GetAttributeValue<string>("filetype"); }
			set
			{ 
				if(value == FileType) return;
				SetAttributeValue("filetype", value);
			}
		}	
			
		/// <summary>
        /// fullname
        /// </summary>
		[DisplayName("Name")]
		[AttributeLogicalName("fullname")]
		public string Name
		{	
			get { return GetAttributeValue<string>("fullname"); }
			set
			{ 
				if(value == Name) return;
				SetAttributeValue("fullname", value);
			}
		}	
			
		/// <summary>
        /// iconclassname
        /// </summary>
		[DisplayName("Icon Class Name")]
		[AttributeLogicalName("iconclassname")]
		public string IconClassName
		{	
			get { return GetAttributeValue<string>("iconclassname"); }
			set
			{ 
				if(value == IconClassName) return;
				SetAttributeValue("iconclassname", value);
			}
		}	
			
		/// <summary>
        /// location
        /// </summary>
		[DisplayName("Path")]
		[AttributeLogicalName("location")]
		public string Path
		{	
			get { return GetAttributeValue<string>("location"); }
			set
			{ 
				if(value == Path) return;
				SetAttributeValue("location", value);
			}
		}	
			
		/// <summary>
        /// modifiedby
        /// </summary>
		[DisplayName("Modified By")]
		[AttributeLogicalName("modifiedby")]
		public EntityReference ModifiedBy2
		{	
			get { return GetAttributeValue<EntityReference>("modifiedby"); }
			set
			{ 
				if(value == ModifiedBy2) return;
				SetAttributeValue("modifiedby", value);
			}
		}	
			
		/// <summary>
        /// modifiedbyname
        /// </summary>
		[DisplayName("modifiedbyname")]
		[AttributeLogicalName("modifiedbyname")]
		public string Modifiedbyname
		{	
			get { return GetAttributeValue<string>("modifiedbyname"); }
			set
			{ 
				if(value == Modifiedbyname) return;
				SetAttributeValue("modifiedbyname", value);
			}
		}	
			
		/// <summary>
        /// modifiedbyyominame
        /// </summary>
		[DisplayName("modifiedbyyominame")]
		[AttributeLogicalName("modifiedbyyominame")]
		public string Modifiedbyyominame
		{	
			get { return GetAttributeValue<string>("modifiedbyyominame"); }
			set
			{ 
				if(value == Modifiedbyyominame) return;
				SetAttributeValue("modifiedbyyominame", value);
			}
		}	
			
		/// <summary>
        /// modifiedon
        /// </summary>
		[DisplayName("Modified On")]
		[AttributeLogicalName("modifiedon")]
		public DateTime? ModifiedOn
		{	
			get { return GetAttributeValue<DateTime?>("modifiedon"); }
			set
			{ 
				if(value == ModifiedOn) return;
				SetAttributeValue("modifiedon", value);
			}
		}	
			
		/// <summary>
        /// modifiedonbehalfby
        /// </summary>
		[DisplayName("Modified By (Delegate)")]
		[AttributeLogicalName("modifiedonbehalfby")]
		public EntityReference ModifiedByDelegate
		{	
			get { return GetAttributeValue<EntityReference>("modifiedonbehalfby"); }
			set
			{ 
				if(value == ModifiedByDelegate) return;
				SetAttributeValue("modifiedonbehalfby", value);
			}
		}	
			
		/// <summary>
        /// modifiedonbehalfbyname
        /// </summary>
		[DisplayName("modifiedonbehalfbyname")]
		[AttributeLogicalName("modifiedonbehalfbyname")]
		public string Modifiedonbehalfbyname
		{	
			get { return GetAttributeValue<string>("modifiedonbehalfbyname"); }
			set
			{ 
				if(value == Modifiedonbehalfbyname) return;
				SetAttributeValue("modifiedonbehalfbyname", value);
			}
		}	
			
		/// <summary>
        /// modifiedonbehalfbyyominame
        /// </summary>
		[DisplayName("modifiedonbehalfbyyominame")]
		[AttributeLogicalName("modifiedonbehalfbyyominame")]
		public string Modifiedonbehalfbyyominame
		{	
			get { return GetAttributeValue<string>("modifiedonbehalfbyyominame"); }
			set
			{ 
				if(value == Modifiedonbehalfbyyominame) return;
				SetAttributeValue("modifiedonbehalfbyyominame", value);
			}
		}	
			
		/// <summary>
        /// organizationid
        /// </summary>
		[DisplayName("Organization ID")]
		[AttributeLogicalName("organizationid")]
		public EntityReference OrganizationID
		{	
			get { return GetAttributeValue<EntityReference>("organizationid"); }
			set
			{ 
				if(value == OrganizationID) return;
				SetAttributeValue("organizationid", value);
			}
		}	
			
		/// <summary>
        /// organizationidname
        /// </summary>
		[DisplayName("organizationidname")]
		[AttributeLogicalName("organizationidname")]
		public string Organizationidname
		{	
			get { return GetAttributeValue<string>("organizationidname"); }
			set
			{ 
				if(value == Organizationidname) return;
				SetAttributeValue("organizationidname", value);
			}
		}	
			
		/// <summary>
        /// readurl
        /// </summary>
		[DisplayName("Read Web App URL")]
		[AttributeLogicalName("readurl")]
		public string ReadWebAppURL
		{	
			get { return GetAttributeValue<string>("readurl"); }
			set
			{ 
				if(value == ReadWebAppURL) return;
				SetAttributeValue("readurl", value);
			}
		}	
			
		/// <summary>
        /// recommendeddocumentid
        /// </summary>
		[DisplayName("Recommended Document")]
		[AttributeLogicalName("recommendeddocumentid")]
		public override Guid Id
		{
			get => base.Id;
			set { base.Id = value; SetAttributeValue("recommendeddocumentid", value); }
		}

							/// <summary>
        /// regardingobjectid
        /// </summary>
		[DisplayName("Regarding")]
		[AttributeLogicalName("regardingobjectid")]
		public EntityReference Regarding
		{	
			get { return GetAttributeValue<EntityReference>("regardingobjectid"); }
			set
			{ 
				if(value == Regarding) return;
				SetAttributeValue("regardingobjectid", value);
			}
		}	
			
		/// <summary>
        /// regardingobjectidname
        /// </summary>
		[DisplayName("regardingobjectidname")]
		[AttributeLogicalName("regardingobjectidname")]
		public string Regardingobjectidname
		{	
			get { return GetAttributeValue<string>("regardingobjectidname"); }
			set
			{ 
				if(value == Regardingobjectidname) return;
				SetAttributeValue("regardingobjectidname", value);
			}
		}	
			
		/// <summary>
        /// regardingobjecttypecode
        /// </summary>
		[DisplayName("regardingobjecttypecode")]
		[AttributeLogicalName("regardingobjecttypecode")]
		public string Regardingobjecttypecode
		{	
			get { return GetAttributeValue<string>("regardingobjecttypecode"); }
			set
			{ 
				if(value == Regardingobjecttypecode) return;
				SetAttributeValue("regardingobjecttypecode", value);
			}
		}	
			
		/// <summary>
        /// source
        /// </summary>
		[DisplayName("Source")]
		[AttributeLogicalName("source")]
		public string Source
		{	
			get { return GetAttributeValue<string>("source"); }
			set
			{ 
				if(value == Source) return;
				SetAttributeValue("source", value);
			}
		}	
			
		/// <summary>
        /// timezoneruleversionnumber
        /// </summary>
		[DisplayName("Time Zone Rule Version Number")]
		[AttributeLogicalName("timezoneruleversionnumber")]
		public int? TimeZoneRuleVersionNumber
		{	
			get { return GetAttributeValue<int?>("timezoneruleversionnumber"); }
			set
			{ 
				if(value == TimeZoneRuleVersionNumber) return;
				SetAttributeValue("timezoneruleversionnumber", value);
			}
		}	
			
		/// <summary>
        /// title
        /// </summary>
		[DisplayName("Title")]
		[AttributeLogicalName("title")]
		public string Title
		{	
			get { return GetAttributeValue<string>("title"); }
			set
			{ 
				if(value == Title) return;
				SetAttributeValue("title", value);
			}
		}	
			
		/// <summary>
        /// transactioncurrencyid
        /// </summary>
		[DisplayName("Currency")]
		[AttributeLogicalName("transactioncurrencyid")]
		public EntityReference Currency
		{	
			get { return GetAttributeValue<EntityReference>("transactioncurrencyid"); }
			set
			{ 
				if(value == Currency) return;
				SetAttributeValue("transactioncurrencyid", value);
			}
		}	
			
		/// <summary>
        /// transactioncurrencyidname
        /// </summary>
		[DisplayName("transactioncurrencyidname")]
		[AttributeLogicalName("transactioncurrencyidname")]
		public string Transactioncurrencyidname
		{	
			get { return GetAttributeValue<string>("transactioncurrencyidname"); }
			set
			{ 
				if(value == Transactioncurrencyidname) return;
				SetAttributeValue("transactioncurrencyidname", value);
			}
		}	
			
		/// <summary>
        /// utcconversiontimezonecode
        /// </summary>
		[DisplayName("UTC Conversion Time Zone Code")]
		[AttributeLogicalName("utcconversiontimezonecode")]
		public int? UTCConversionTimeZoneCode
		{	
			get { return GetAttributeValue<int?>("utcconversiontimezonecode"); }
			set
			{ 
				if(value == UTCConversionTimeZoneCode) return;
				SetAttributeValue("utcconversiontimezonecode", value);
			}
		}	
			
		/// <summary>
        /// version
        /// </summary>
		[DisplayName("Recommended Document Version")]
		[AttributeLogicalName("version")]
		public string RecommendedDocumentVersion
		{	
			get { return GetAttributeValue<string>("version"); }
			set
			{ 
				if(value == RecommendedDocumentVersion) return;
				SetAttributeValue("version", value);
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
			#endregion

		#region Actions
		#endregion

		#region OptionSetEnums
		#endregion	

		#region Properties
		public static class Properties 
		{
			/// <summary>absoluteurl</summary>
			public const string AbsoluteURL = "absoluteurl";

			/// <summary>associatedrecordname</summary>
			public const string AssociatedRecordName = "associatedrecordname";

			/// <summary>author</summary>
			public const string Author = "author";

			/// <summary>contenttype</summary>
			public const string ContentType = "contenttype";

			/// <summary>createdby</summary>
			public const string CreatedBy = "createdby";

			/// <summary>createdbyname</summary>
			public const string Createdbyname = "createdbyname";

			/// <summary>createdbyyominame</summary>
			public const string Createdbyyominame = "createdbyyominame";

			/// <summary>createdon</summary>
			public const string CreatedOn = "createdon";

			/// <summary>createdonbehalfby</summary>
			public const string CreatedByDelegate = "createdonbehalfby";

			/// <summary>createdonbehalfbyname</summary>
			public const string Createdonbehalfbyname = "createdonbehalfbyname";

			/// <summary>createdonbehalfbyyominame</summary>
			public const string Createdonbehalfbyyominame = "createdonbehalfbyyominame";

			/// <summary>editurl</summary>
			public const string EditWebAppURL = "editurl";

			/// <summary>exchangerate</summary>
			public const string ExchangeRate = "exchangerate";

			/// <summary>externaldocumentid</summary>
			public const string ExternalDocumentID = "externaldocumentid";

			/// <summary>externalmodifiedby</summary>
			public const string ModifiedBy = "externalmodifiedby";

			/// <summary>filesize</summary>
			public const string FileSize = "filesize";

			/// <summary>filetype</summary>
			public const string FileType = "filetype";

			/// <summary>fullname</summary>
			public const string Name = "fullname";

			/// <summary>iconclassname</summary>
			public const string IconClassName = "iconclassname";

			/// <summary>location</summary>
			public const string Path = "location";

			/// <summary>modifiedby</summary>
			public const string ModifiedBy2 = "modifiedby";

			/// <summary>modifiedbyname</summary>
			public const string Modifiedbyname = "modifiedbyname";

			/// <summary>modifiedbyyominame</summary>
			public const string Modifiedbyyominame = "modifiedbyyominame";

			/// <summary>modifiedon</summary>
			public const string ModifiedOn = "modifiedon";

			/// <summary>modifiedonbehalfby</summary>
			public const string ModifiedByDelegate = "modifiedonbehalfby";

			/// <summary>modifiedonbehalfbyname</summary>
			public const string Modifiedonbehalfbyname = "modifiedonbehalfbyname";

			/// <summary>modifiedonbehalfbyyominame</summary>
			public const string Modifiedonbehalfbyyominame = "modifiedonbehalfbyyominame";

			/// <summary>organizationid</summary>
			public const string OrganizationID = "organizationid";

			/// <summary>organizationidname</summary>
			public const string Organizationidname = "organizationidname";

			/// <summary>readurl</summary>
			public const string ReadWebAppURL = "readurl";

			/// <summary>recommendeddocumentid</summary>
			public const string RecommendedDocumentId = "recommendeddocumentid";

			/// <summary>regardingobjectid</summary>
			public const string Regarding = "regardingobjectid";

			/// <summary>regardingobjectidname</summary>
			public const string Regardingobjectidname = "regardingobjectidname";

			/// <summary>regardingobjecttypecode</summary>
			public const string Regardingobjecttypecode = "regardingobjecttypecode";

			/// <summary>source</summary>
			public const string Source = "source";

			/// <summary>timezoneruleversionnumber</summary>
			public const string TimeZoneRuleVersionNumber = "timezoneruleversionnumber";

			/// <summary>title</summary>
			public const string Title = "title";

			/// <summary>transactioncurrencyid</summary>
			public const string Currency = "transactioncurrencyid";

			/// <summary>transactioncurrencyidname</summary>
			public const string Transactioncurrencyidname = "transactioncurrencyidname";

			/// <summary>utcconversiontimezonecode</summary>
			public const string UTCConversionTimeZoneCode = "utcconversiontimezonecode";

			/// <summary>version</summary>
			public const string RecommendedDocumentVersion = "version";

			/// <summary>versionnumber</summary>
			public const string Versionnumber = "versionnumber";

		}
		#endregion

		#region Schemas
		public static class Schemas 
		{
		}
		#endregion
	}
}

