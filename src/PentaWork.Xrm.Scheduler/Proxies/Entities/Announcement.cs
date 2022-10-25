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
	[EntityLogicalName("businessunitnewsarticle")]
	public sealed class Announcement : Entity
	{	
		public static readonly int? EntityTypeCode = 132;
		public new const string LogicalName = "businessunitnewsarticle";
		public const string PrimaryIdAttribute = "businessunitnewsarticleid";
		public const string PrimaryNameAttribute = "articletitle";
	
		public Announcement() : base("businessunitnewsarticle") { }

		#region Attributes
		/// <summary>
        /// activeon
        /// </summary>
		[DisplayName("Active On")]
		[AttributeLogicalName("activeon")]
		public DateTime? ActiveOn
		{	
			get { return GetAttributeValue<DateTime?>("activeon"); }
			set
			{ 
				if(value == ActiveOn) return;
				SetAttributeValue("activeon", value);
			}
		}	
			
		/// <summary>
        /// activeuntil
        /// </summary>
		[DisplayName("Expiration Date")]
		[AttributeLogicalName("activeuntil")]
		public DateTime? ExpirationDate
		{	
			get { return GetAttributeValue<DateTime?>("activeuntil"); }
			set
			{ 
				if(value == ExpirationDate) return;
				SetAttributeValue("activeuntil", value);
			}
		}	
			
		/// <summary>
        /// articletitle
        /// </summary>
		[DisplayName("Title")]
		[AttributeLogicalName("articletitle")]
		public string Title
		{	
			get { return GetAttributeValue<string>("articletitle"); }
			set
			{ 
				if(value == Title) return;
				SetAttributeValue("articletitle", value);
			}
		}	
			
		/// <summary>
        /// articletypecode
        /// </summary>
		[DisplayName("Visible To")]
		[AttributeLogicalName("articletypecode")]
		public eVisibleTo? VisibleTo
		{	
			get 
			{ 
				var optionSetValue = GetAttributeValue<OptionSetValue>("articletypecode");
				if (optionSetValue != null) return (eVisibleTo)optionSetValue.Value;
				else return null;
			}
			set 
			{ 
				if(value == VisibleTo) return;

				OptionSetValue optionSetValue = null;
				if(value != null) optionSetValue = new OptionSetValue((int)value);
				SetAttributeValue("articletypecode", optionSetValue); 
			}
		}

		/// <summary>
        /// articleurl
        /// </summary>
		[DisplayName("More Information URL")]
		[AttributeLogicalName("articleurl")]
		public string MoreInformationURL
		{	
			get { return GetAttributeValue<string>("articleurl"); }
			set
			{ 
				if(value == MoreInformationURL) return;
				SetAttributeValue("articleurl", value);
			}
		}	
			
		/// <summary>
        /// businessunitnewsarticleid
        /// </summary>
		[DisplayName("Announcement")]
		[AttributeLogicalName("businessunitnewsarticleid")]
		public override Guid Id
		{
			get => base.Id;
			set { base.Id = value; SetAttributeValue("businessunitnewsarticleid", value); }
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
        /// importsequencenumber
        /// </summary>
		[DisplayName("Import Sequence Number")]
		[AttributeLogicalName("importsequencenumber")]
		public int? ImportSequenceNumber
		{	
			get { return GetAttributeValue<int?>("importsequencenumber"); }
			set
			{ 
				if(value == ImportSequenceNumber) return;
				SetAttributeValue("importsequencenumber", value);
			}
		}	
			
		/// <summary>
        /// modifiedby
        /// </summary>
		[DisplayName("Modified By")]
		[AttributeLogicalName("modifiedby")]
		public EntityReference ModifiedBy
		{	
			get { return GetAttributeValue<EntityReference>("modifiedby"); }
			set
			{ 
				if(value == ModifiedBy) return;
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
        /// newsarticle
        /// </summary>
		[DisplayName("Description")]
		[AttributeLogicalName("newsarticle")]
		public string Description
		{	
			get { return GetAttributeValue<string>("newsarticle"); }
			set
			{ 
				if(value == Description) return;
				SetAttributeValue("newsarticle", value);
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
        /// overriddencreatedon
        /// </summary>
		[DisplayName("Record Created On")]
		[AttributeLogicalName("overriddencreatedon")]
		public DateTime? RecordCreatedOn
		{	
			get { return GetAttributeValue<DateTime?>("overriddencreatedon"); }
			set
			{ 
				if(value == RecordCreatedOn) return;
				SetAttributeValue("overriddencreatedon", value);
			}
		}	
			
		/// <summary>
        /// showonhomepage
        /// </summary>
		[DisplayName("Show in Workplace")]
		[AttributeLogicalName("showonhomepage")]
		public bool? ShowInWorkplace
		{	
			get { return GetAttributeValue<bool?>("showonhomepage"); }
			set
			{ 
				if(value == ShowInWorkplace) return;
				SetAttributeValue("showonhomepage", value);
			}
		}	
			
		/// <summary>
        /// timezoneruleversionnumber
        /// </summary>
		[DisplayName("timezoneruleversionnumber")]
		[AttributeLogicalName("timezoneruleversionnumber")]
		public int? Timezoneruleversionnumber
		{	
			get { return GetAttributeValue<int?>("timezoneruleversionnumber"); }
			set
			{ 
				if(value == Timezoneruleversionnumber) return;
				SetAttributeValue("timezoneruleversionnumber", value);
			}
		}	
			
		/// <summary>
        /// utcconversiontimezonecode
        /// </summary>
		[DisplayName("utcconversiontimezonecode")]
		[AttributeLogicalName("utcconversiontimezonecode")]
		public int? Utcconversiontimezonecode
		{	
			get { return GetAttributeValue<int?>("utcconversiontimezonecode"); }
			set
			{ 
				if(value == Utcconversiontimezonecode) return;
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
			
		#endregion	

		#region Relations
			/// <summary>
        /// 1:N Get entities for 'BusinessUnitNewsArticle_AsyncOperations'
        /// </summary>
		[RelationshipSchemaName("BusinessUnitNewsArticle_AsyncOperations")]
		public IEnumerable<SystemJob> BusinessUnitNewsArticleAsyncOperations
		{
			get { return GetRelatedEntities<SystemJob>("BusinessUnitNewsArticle_AsyncOperations", null); }
			set { SetRelatedEntities("BusinessUnitNewsArticle_AsyncOperations", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'BusinessUnitNewsArticle_BulkDeleteFailures'
        /// </summary>
		[RelationshipSchemaName("BusinessUnitNewsArticle_BulkDeleteFailures")]
		public IEnumerable<BulkDeleteFailure> BusinessUnitNewsArticleBulkDeleteFailures
		{
			get { return GetRelatedEntities<BulkDeleteFailure>("BusinessUnitNewsArticle_BulkDeleteFailures", null); }
			set { SetRelatedEntities("BusinessUnitNewsArticle_BulkDeleteFailures", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'BusinessUnitNewsArticle_ProcessSessions'
        /// </summary>
		[RelationshipSchemaName("BusinessUnitNewsArticle_ProcessSessions")]
		public IEnumerable<ProcessSession> BusinessUnitNewsArticleProcessSessions
		{
			get { return GetRelatedEntities<ProcessSession>("BusinessUnitNewsArticle_ProcessSessions", null); }
			set { SetRelatedEntities("BusinessUnitNewsArticle_ProcessSessions", null, value); }
		}
		#endregion

		#region Actions
		#endregion

		#region OptionSetEnums
		public enum eVisibleTo
		{	
		
			[Label("All Users")]
			[Description(@"")]
			AllUsers = 1, 
		
			[Label("Sales Users")]
			[Description(@"")]
			SalesUsers = 2, 
		
			[Label("Service Users")]
			[Description(@"")]
			ServiceUsers = 3, 
		}
		
		#endregion	

		#region Properties
		public static class Properties 
		{
			/// <summary>activeon</summary>
			public const string ActiveOn = "activeon";

			/// <summary>activeuntil</summary>
			public const string ExpirationDate = "activeuntil";

			/// <summary>articletitle</summary>
			public const string Title = "articletitle";

			/// <summary>articletypecode</summary>
			public const string VisibleTo = "articletypecode";

			/// <summary>articleurl</summary>
			public const string MoreInformationURL = "articleurl";

			/// <summary>businessunitnewsarticleid</summary>
			public const string AnnouncementId = "businessunitnewsarticleid";

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

			/// <summary>importsequencenumber</summary>
			public const string ImportSequenceNumber = "importsequencenumber";

			/// <summary>modifiedby</summary>
			public const string ModifiedBy = "modifiedby";

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

			/// <summary>newsarticle</summary>
			public const string Description = "newsarticle";

			/// <summary>organizationid</summary>
			public const string Organization = "organizationid";

			/// <summary>organizationidname</summary>
			public const string Organizationidname = "organizationidname";

			/// <summary>overriddencreatedon</summary>
			public const string RecordCreatedOn = "overriddencreatedon";

			/// <summary>showonhomepage</summary>
			public const string ShowInWorkplace = "showonhomepage";

			/// <summary>timezoneruleversionnumber</summary>
			public const string Timezoneruleversionnumber = "timezoneruleversionnumber";

			/// <summary>utcconversiontimezonecode</summary>
			public const string Utcconversiontimezonecode = "utcconversiontimezonecode";

			/// <summary>versionnumber</summary>
			public const string Versionnumber = "versionnumber";

		}
		#endregion

		#region Schemas
		public static class Schemas 
		{
			/// <summary>1:N BusinessUnitNewsArticle_AsyncOperations</summary>
			public const string BusinessUnitNewsArticleAsyncOperations = "BusinessUnitNewsArticle_AsyncOperations";

			/// <summary>1:N BusinessUnitNewsArticle_BulkDeleteFailures</summary>
			public const string BusinessUnitNewsArticleBulkDeleteFailures = "BusinessUnitNewsArticle_BulkDeleteFailures";

			/// <summary>1:N BusinessUnitNewsArticle_ProcessSessions</summary>
			public const string BusinessUnitNewsArticleProcessSessions = "BusinessUnitNewsArticle_ProcessSessions";

		}
		#endregion
	}
}

