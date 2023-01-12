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
	[EntityLogicalName("officegraphdocument")]
	public sealed class OfficeGraphDocument : Entity
	{	
		public static readonly int? EntityTypeCode = 9950;
		public new const string LogicalName = "officegraphdocument";
		public const string PrimaryIdAttribute = "officegraphdocumentid";
		public const string PrimaryNameAttribute = "title";
	
		public OfficeGraphDocument() : base("officegraphdocument") { }

		#region Attributes
		/// <summary>
        /// authornames
        /// </summary>
		[DisplayName("Author Names")]
		[AttributeLogicalName("authornames")]
		public string AuthorNames
		{	
			get { return GetAttributeValue<string>("authornames"); }
			set
			{ 
				if(value == AuthorNames) return;
				SetAttributeValue("authornames", value);
			}
		}	
			
		/// <summary>
        /// createdby
        /// </summary>
		[DisplayName("Created By")]
		[AttributeLogicalName("createdby")]
		public string CreatedBy
		{	
			get { return GetAttributeValue<string>("createdby"); }
			set
			{ 
				if(value == CreatedBy) return;
				SetAttributeValue("createdby", value);
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
        /// createdtime
        /// </summary>
		[DisplayName("Created Time")]
		[AttributeLogicalName("createdtime")]
		public DateTime? CreatedTime
		{	
			get { return GetAttributeValue<DateTime?>("createdtime"); }
			set
			{ 
				if(value == CreatedTime) return;
				SetAttributeValue("createdtime", value);
			}
		}	
			
		/// <summary>
        /// documentid
        /// </summary>
		[DisplayName("Document Id")]
		[AttributeLogicalName("documentid")]
		public string DocumentId
		{	
			get { return GetAttributeValue<string>("documentid"); }
			set
			{ 
				if(value == DocumentId) return;
				SetAttributeValue("documentid", value);
			}
		}	
			
		/// <summary>
        /// documentlastmodifiedby
        /// </summary>
		[DisplayName("Document Last Modified By")]
		[AttributeLogicalName("documentlastmodifiedby")]
		public string DocumentLastModifiedBy
		{	
			get { return GetAttributeValue<string>("documentlastmodifiedby"); }
			set
			{ 
				if(value == DocumentLastModifiedBy) return;
				SetAttributeValue("documentlastmodifiedby", value);
			}
		}	
			
		/// <summary>
        /// documentlastmodifiedon
        /// </summary>
		[DisplayName("Document Last Modified On")]
		[AttributeLogicalName("documentlastmodifiedon")]
		public DateTime? DocumentLastModifiedOn
		{	
			get { return GetAttributeValue<DateTime?>("documentlastmodifiedon"); }
			set
			{ 
				if(value == DocumentLastModifiedOn) return;
				SetAttributeValue("documentlastmodifiedon", value);
			}
		}	
			
		/// <summary>
        /// documentpreviewmetadata
        /// </summary>
		[DisplayName("document preview metadata")]
		[AttributeLogicalName("documentpreviewmetadata")]
		public string DocumentPreviewMetadata
		{	
			get { return GetAttributeValue<string>("documentpreviewmetadata"); }
			set
			{ 
				if(value == DocumentPreviewMetadata) return;
				SetAttributeValue("documentpreviewmetadata", value);
			}
		}	
			
		/// <summary>
        /// exchangerate
		///
		/// Precision: 10
		/// MaxValue: 100000000000
		/// MinValue: 0.0000000001
        /// </summary>
		[DisplayName("ExchangeRate")]
		[AttributeLogicalName("exchangerate")]
		public decimal? ExchangeRate
		{	
			get { return GetAttributeValue<decimal?>("exchangerate"); }
			set 
			{
				decimal? decimalValue = null;
				if(value != null) decimalValue = Decimal.Round(value.Value, 10);
				if(decimalValue == ExchangeRate) return;
				SetAttributeValue("exchangerate", decimalValue);  
			}
		}

		/// <summary>
        /// fileextension
        /// </summary>
		[DisplayName("File Extension")]
		[AttributeLogicalName("fileextension")]
		public string FileExtension
		{	
			get { return GetAttributeValue<string>("fileextension"); }
			set
			{ 
				if(value == FileExtension) return;
				SetAttributeValue("fileextension", value);
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
        /// modifiedby
        /// </summary>
		[DisplayName("Modified By")]
		[AttributeLogicalName("modifiedby")]
		public string ModifiedBy
		{	
			get { return GetAttributeValue<string>("modifiedby"); }
			set
			{ 
				if(value == ModifiedBy) return;
				SetAttributeValue("modifiedby", value);
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
        /// modifiedtime
        /// </summary>
		[DisplayName("Modified Time")]
		[AttributeLogicalName("modifiedtime")]
		public DateTime? ModifiedTime
		{	
			get { return GetAttributeValue<DateTime?>("modifiedtime"); }
			set
			{ 
				if(value == ModifiedTime) return;
				SetAttributeValue("modifiedtime", value);
			}
		}	
			
		/// <summary>
        /// officegraphdocumentid
        /// </summary>
		[DisplayName("OfficeGraphDocument")]
		[AttributeLogicalName("officegraphdocumentid")]
		public override Guid Id
		{
			get => base.Id;
			set { base.Id = value; SetAttributeValue("officegraphdocumentid", value); }
		}

							/// <summary>
        /// organizationid
        /// </summary>
		[DisplayName("Organization Id")]
		[AttributeLogicalName("organizationid")]
		public EntityReference OrganizationId
		{	
			get { return GetAttributeValue<EntityReference>("organizationid"); }
			set
			{ 
				if(value == OrganizationId) return;
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
        /// previewimageurl
        /// </summary>
		[DisplayName("Preview Image Url")]
		[AttributeLogicalName("previewimageurl")]
		public string PreviewImageUrl
		{	
			get { return GetAttributeValue<string>("previewimageurl"); }
			set
			{ 
				if(value == PreviewImageUrl) return;
				SetAttributeValue("previewimageurl", value);
			}
		}	
			
		/// <summary>
        /// querytype
        /// </summary>
		[DisplayName("Query Type")]
		[AttributeLogicalName("querytype")]
		public int? QueryType
		{	
			get { return GetAttributeValue<int?>("querytype"); }
			set
			{ 
				if(value == QueryType) return;
				SetAttributeValue("querytype", value);
			}
		}	
			
		/// <summary>
        /// rank
        /// </summary>
		[DisplayName("Relevancy Rank of the Document")]
		[AttributeLogicalName("rank")]
		public int? RelevancyRankOfTheDocument
		{	
			get { return GetAttributeValue<int?>("rank"); }
			set
			{ 
				if(value == RelevancyRankOfTheDocument) return;
				SetAttributeValue("rank", value);
			}
		}	
			
		/// <summary>
        /// readurl
        /// </summary>
		[DisplayName("Read Url")]
		[AttributeLogicalName("readurl")]
		public string ReadUrl
		{	
			get { return GetAttributeValue<string>("readurl"); }
			set
			{ 
				if(value == ReadUrl) return;
				SetAttributeValue("readurl", value);
			}
		}	
			
		/// <summary>
        /// secondaryfileextension
        /// </summary>
		[DisplayName("Secondary File Extension")]
		[AttributeLogicalName("secondaryfileextension")]
		public string SecondaryFileExtension
		{	
			get { return GetAttributeValue<string>("secondaryfileextension"); }
			set
			{ 
				if(value == SecondaryFileExtension) return;
				SetAttributeValue("secondaryfileextension", value);
			}
		}	
			
		/// <summary>
        /// sitetitle
        /// </summary>
		[DisplayName("Parent Site Title")]
		[AttributeLogicalName("sitetitle")]
		public string ParentSiteTitle
		{	
			get { return GetAttributeValue<string>("sitetitle"); }
			set
			{ 
				if(value == ParentSiteTitle) return;
				SetAttributeValue("sitetitle", value);
			}
		}	
			
		/// <summary>
        /// siteurl
        /// </summary>
		[DisplayName("Site Url")]
		[AttributeLogicalName("siteurl")]
		public string SiteUrl
		{	
			get { return GetAttributeValue<string>("siteurl"); }
			set
			{ 
				if(value == SiteUrl) return;
				SetAttributeValue("siteurl", value);
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
			
		/// <summary>
        /// viewcount
        /// </summary>
		[DisplayName("View Count")]
		[AttributeLogicalName("viewcount")]
		public int? ViewCount
		{	
			get { return GetAttributeValue<int?>("viewcount"); }
			set
			{ 
				if(value == ViewCount) return;
				SetAttributeValue("viewcount", value);
			}
		}	
			
		/// <summary>
        /// weblocationurl
        /// </summary>
		[DisplayName("Web Location Url")]
		[AttributeLogicalName("weblocationurl")]
		public string WebLocationUrl
		{	
			get { return GetAttributeValue<string>("weblocationurl"); }
			set
			{ 
				if(value == WebLocationUrl) return;
				SetAttributeValue("weblocationurl", value);
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
			/// <summary>authornames</summary>
			public const string AuthorNames = "authornames";

			/// <summary>createdby</summary>
			public const string CreatedBy = "createdby";

			/// <summary>createdonbehalfby</summary>
			public const string CreatedByDelegate = "createdonbehalfby";

			/// <summary>createdonbehalfbyname</summary>
			public const string Createdonbehalfbyname = "createdonbehalfbyname";

			/// <summary>createdonbehalfbyyominame</summary>
			public const string Createdonbehalfbyyominame = "createdonbehalfbyyominame";

			/// <summary>createdtime</summary>
			public const string CreatedTime = "createdtime";

			/// <summary>documentid</summary>
			public const string DocumentId = "documentid";

			/// <summary>documentlastmodifiedby</summary>
			public const string DocumentLastModifiedBy = "documentlastmodifiedby";

			/// <summary>documentlastmodifiedon</summary>
			public const string DocumentLastModifiedOn = "documentlastmodifiedon";

			/// <summary>documentpreviewmetadata</summary>
			public const string DocumentPreviewMetadata = "documentpreviewmetadata";

			/// <summary>exchangerate</summary>
			public const string ExchangeRate = "exchangerate";

			/// <summary>fileextension</summary>
			public const string FileExtension = "fileextension";

			/// <summary>filetype</summary>
			public const string FileType = "filetype";

			/// <summary>modifiedby</summary>
			public const string ModifiedBy = "modifiedby";

			/// <summary>modifiedonbehalfby</summary>
			public const string ModifiedByDelegate = "modifiedonbehalfby";

			/// <summary>modifiedonbehalfbyname</summary>
			public const string Modifiedonbehalfbyname = "modifiedonbehalfbyname";

			/// <summary>modifiedonbehalfbyyominame</summary>
			public const string Modifiedonbehalfbyyominame = "modifiedonbehalfbyyominame";

			/// <summary>modifiedtime</summary>
			public const string ModifiedTime = "modifiedtime";

			/// <summary>officegraphdocumentid</summary>
			public const string OfficeGraphDocumentId = "officegraphdocumentid";

			/// <summary>organizationid</summary>
			public const string OrganizationId = "organizationid";

			/// <summary>organizationidname</summary>
			public const string Organizationidname = "organizationidname";

			/// <summary>previewimageurl</summary>
			public const string PreviewImageUrl = "previewimageurl";

			/// <summary>querytype</summary>
			public const string QueryType = "querytype";

			/// <summary>rank</summary>
			public const string RelevancyRankOfTheDocument = "rank";

			/// <summary>readurl</summary>
			public const string ReadUrl = "readurl";

			/// <summary>secondaryfileextension</summary>
			public const string SecondaryFileExtension = "secondaryfileextension";

			/// <summary>sitetitle</summary>
			public const string ParentSiteTitle = "sitetitle";

			/// <summary>siteurl</summary>
			public const string SiteUrl = "siteurl";

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

			/// <summary>versionnumber</summary>
			public const string Versionnumber = "versionnumber";

			/// <summary>viewcount</summary>
			public const string ViewCount = "viewcount";

			/// <summary>weblocationurl</summary>
			public const string WebLocationUrl = "weblocationurl";

		}
		#endregion

		#region Schemas
		public static class Schemas 
		{
		}
		#endregion
	}
}

