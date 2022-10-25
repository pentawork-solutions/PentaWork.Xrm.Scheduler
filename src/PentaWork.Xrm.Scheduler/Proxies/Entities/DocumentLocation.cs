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
	[EntityLogicalName("sharepointdocumentlocation")]
	public sealed class DocumentLocation : Entity
	{	
		public static readonly int? EntityTypeCode = 9508;
		public new const string LogicalName = "sharepointdocumentlocation";
		public const string PrimaryIdAttribute = "sharepointdocumentlocationid";
		public const string PrimaryNameAttribute = "name";
	
		public DocumentLocation() : base("sharepointdocumentlocation") { }

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
        /// description
        /// </summary>
		[DisplayName("Description")]
		[AttributeLogicalName("description")]
		public string Description
		{	
			get { return GetAttributeValue<string>("description"); }
			set
			{ 
				if(value == Description) return;
				SetAttributeValue("description", value);
			}
		}	
			
		/// <summary>
        /// exchangerate
        /// </summary>
		[DisplayName("Exchange Rate")]
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
        /// locationtype
        /// </summary>
		[DisplayName("Location Type")]
		[AttributeLogicalName("locationtype")]
		public egLocationType? LocationType
		{	
			get 
			{ 
				var optionSetValue = GetAttributeValue<OptionSetValue>("locationtype");
				if (optionSetValue != null) return (egLocationType)optionSetValue.Value;
				else return null;
			}
			set 
			{ 
				if(value == LocationType) return;

				OptionSetValue optionSetValue = null;
				if(value != null) optionSetValue = new OptionSetValue((int)value);
				SetAttributeValue("locationtype", optionSetValue); 
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
        /// ownerid
        /// </summary>
		[DisplayName("Owner")]
		[AttributeLogicalName("ownerid")]
		public EntityReference Owner
		{	
			get { return GetAttributeValue<EntityReference>("ownerid"); }
			set
			{ 
				if(value == Owner) return;
				SetAttributeValue("ownerid", value);
			}
		}	
			
		/// <summary>
        /// owneridname
        /// </summary>
		[DisplayName("owneridname")]
		[AttributeLogicalName("owneridname")]
		public string Owneridname
		{	
			get { return GetAttributeValue<string>("owneridname"); }
			set
			{ 
				if(value == Owneridname) return;
				SetAttributeValue("owneridname", value);
			}
		}	
			
		/// <summary>
        /// owneridtype
        /// </summary>
		[DisplayName("owneridtype")]
		[AttributeLogicalName("owneridtype")]
		public string Owneridtype
		{	
			get { return GetAttributeValue<string>("owneridtype"); }
			set
			{ 
				if(value == Owneridtype) return;
				SetAttributeValue("owneridtype", value);
			}
		}	
			
		/// <summary>
        /// owneridyominame
        /// </summary>
		[DisplayName("owneridyominame")]
		[AttributeLogicalName("owneridyominame")]
		public string Owneridyominame
		{	
			get { return GetAttributeValue<string>("owneridyominame"); }
			set
			{ 
				if(value == Owneridyominame) return;
				SetAttributeValue("owneridyominame", value);
			}
		}	
			
		/// <summary>
        /// owningbusinessunit
        /// </summary>
		[DisplayName("Owning Business Unit")]
		[AttributeLogicalName("owningbusinessunit")]
		public EntityReference OwningBusinessUnit
		{	
			get { return GetAttributeValue<EntityReference>("owningbusinessunit"); }
			set
			{ 
				if(value == OwningBusinessUnit) return;
				SetAttributeValue("owningbusinessunit", value);
			}
		}	
			
		/// <summary>
        /// owningteam
        /// </summary>
		[DisplayName("Owning Team")]
		[AttributeLogicalName("owningteam")]
		public EntityReference OwningTeam
		{	
			get { return GetAttributeValue<EntityReference>("owningteam"); }
			set
			{ 
				if(value == OwningTeam) return;
				SetAttributeValue("owningteam", value);
			}
		}	
			
		/// <summary>
        /// owninguser
        /// </summary>
		[DisplayName("Owning User")]
		[AttributeLogicalName("owninguser")]
		public EntityReference OwningUser
		{	
			get { return GetAttributeValue<EntityReference>("owninguser"); }
			set
			{ 
				if(value == OwningUser) return;
				SetAttributeValue("owninguser", value);
			}
		}	
			
		/// <summary>
        /// parentsiteorlocation
        /// </summary>
		[DisplayName("Parent Site or Location")]
		[AttributeLogicalName("parentsiteorlocation")]
		public EntityReference ParentSiteOrLocation
		{	
			get { return GetAttributeValue<EntityReference>("parentsiteorlocation"); }
			set
			{ 
				if(value == ParentSiteOrLocation) return;
				SetAttributeValue("parentsiteorlocation", value);
			}
		}	
			
		/// <summary>
        /// parentsiteorlocationname
        /// </summary>
		[DisplayName("parentsiteorlocationname")]
		[AttributeLogicalName("parentsiteorlocationname")]
		public string Parentsiteorlocationname
		{	
			get { return GetAttributeValue<string>("parentsiteorlocationname"); }
			set
			{ 
				if(value == Parentsiteorlocationname) return;
				SetAttributeValue("parentsiteorlocationname", value);
			}
		}	
			
		/// <summary>
        /// parentsiteorlocationtypecode
        /// </summary>
		[DisplayName("parentsiteorlocationtypecode")]
		[AttributeLogicalName("parentsiteorlocationtypecode")]
		public string Parentsiteorlocationtypecode
		{	
			get { return GetAttributeValue<string>("parentsiteorlocationtypecode"); }
			set
			{ 
				if(value == Parentsiteorlocationtypecode) return;
				SetAttributeValue("parentsiteorlocationtypecode", value);
			}
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
        /// regardingobjectidyominame
        /// </summary>
		[DisplayName("regardingobjectidyominame")]
		[AttributeLogicalName("regardingobjectidyominame")]
		public string Regardingobjectidyominame
		{	
			get { return GetAttributeValue<string>("regardingobjectidyominame"); }
			set
			{ 
				if(value == Regardingobjectidyominame) return;
				SetAttributeValue("regardingobjectidyominame", value);
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
        /// relativeurl
        /// </summary>
		[DisplayName("Relative URL")]
		[AttributeLogicalName("relativeurl")]
		public string RelativeURL
		{	
			get { return GetAttributeValue<string>("relativeurl"); }
			set
			{ 
				if(value == RelativeURL) return;
				SetAttributeValue("relativeurl", value);
			}
		}	
			
		/// <summary>
        /// servicetype
        /// </summary>
		[DisplayName("Service Type")]
		[AttributeLogicalName("servicetype")]
		public egServiceType? ServiceType
		{	
			get 
			{ 
				var optionSetValue = GetAttributeValue<OptionSetValue>("servicetype");
				if (optionSetValue != null) return (egServiceType)optionSetValue.Value;
				else return null;
			}
			set 
			{ 
				if(value == ServiceType) return;

				OptionSetValue optionSetValue = null;
				if(value != null) optionSetValue = new OptionSetValue((int)value);
				SetAttributeValue("servicetype", optionSetValue); 
			}
		}

		/// <summary>
        /// sharepointdocumentlocationid
        /// </summary>
		[DisplayName("SharePoint Document Location ID")]
		[AttributeLogicalName("sharepointdocumentlocationid")]
		public override Guid Id
		{
			get => base.Id;
			set { base.Id = value; SetAttributeValue("sharepointdocumentlocationid", value); }
		}

							/// <summary>
        /// sitecollectionid
        /// </summary>
		[DisplayName("sitecollectionid")]
		[AttributeLogicalName("sitecollectionid")]
		public Guid SitecollectionId
		{	
			get { return GetAttributeValue<Guid>("sitecollectionid"); }
			set
			{ 
				if(value == SitecollectionId) return;
				SetAttributeValue("sitecollectionid", value);
			}
		}	
			
		/// <summary>
        /// statecode
        /// </summary>
		[DisplayName("Status")]
		[AttributeLogicalName("statecode")]
		public eStatus? Status
		{	
			get 
			{ 
				var optionSetValue = GetAttributeValue<OptionSetValue>("statecode");
				if (optionSetValue != null) return (eStatus)optionSetValue.Value;
				else return null;
			}
			set 
			{ 
				if(value == Status) return;

				OptionSetValue optionSetValue = null;
				if(value != null) optionSetValue = new OptionSetValue((int)value);
				SetAttributeValue("statecode", optionSetValue); 
			}
		}

		/// <summary>
        /// statuscode
        /// </summary>
		[DisplayName("Status Reason")]
		[AttributeLogicalName("statuscode")]
		public eStatusReason? StatusReason
		{	
			get 
			{ 
				var optionSetValue = GetAttributeValue<OptionSetValue>("statuscode");
				if (optionSetValue != null) return (eStatusReason)optionSetValue.Value;
				else return null;
			}
			set 
			{ 
				if(value == StatusReason) return;

				OptionSetValue optionSetValue = null;
				if(value != null) optionSetValue = new OptionSetValue((int)value);
				SetAttributeValue("statuscode", optionSetValue); 
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
        /// userid
        /// </summary>
		[DisplayName("SharePoint Document Location Owner")]
		[AttributeLogicalName("userid")]
		public Guid SharePointDocumentLocationOwnerId
		{	
			get { return GetAttributeValue<Guid>("userid"); }
			set
			{ 
				if(value == SharePointDocumentLocationOwnerId) return;
				SetAttributeValue("userid", value);
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
        /// 1:N Get entities for 'SharePointDocumentLocation_AsyncOperations'
        /// </summary>
		[RelationshipSchemaName("SharePointDocumentLocation_AsyncOperations")]
		public IEnumerable<SystemJob> SharePointDocumentLocationAsyncOperations
		{
			get { return GetRelatedEntities<SystemJob>("SharePointDocumentLocation_AsyncOperations", null); }
			set { SetRelatedEntities("SharePointDocumentLocation_AsyncOperations", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'SharePointDocumentLocation_DuplicateBaseRecord'
        /// </summary>
		[RelationshipSchemaName("SharePointDocumentLocation_DuplicateBaseRecord")]
		public IEnumerable<DuplicateRecord> SharePointDocumentLocationDuplicateBaseRecord
		{
			get { return GetRelatedEntities<DuplicateRecord>("SharePointDocumentLocation_DuplicateBaseRecord", null); }
			set { SetRelatedEntities("SharePointDocumentLocation_DuplicateBaseRecord", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'SharePointDocumentLocation_DuplicateMatchingRecord'
        /// </summary>
		[RelationshipSchemaName("SharePointDocumentLocation_DuplicateMatchingRecord")]
		public IEnumerable<DuplicateRecord> SharePointDocumentLocationDuplicateMatchingRecord
		{
			get { return GetRelatedEntities<DuplicateRecord>("SharePointDocumentLocation_DuplicateMatchingRecord", null); }
			set { SetRelatedEntities("SharePointDocumentLocation_DuplicateMatchingRecord", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'sharepointdocumentlocation_parent_sharepointdocumentlocation'
        /// </summary>
		[RelationshipSchemaName("sharepointdocumentlocation_parent_sharepointdocumentlocation")]
		public IEnumerable<DocumentLocation> SharepointdocumentlocationParentSharepointdocumentlocation
		{
			get { return GetRelatedEntities<DocumentLocation>("sharepointdocumentlocation_parent_sharepointdocumentlocation", null); }
			set { SetRelatedEntities("sharepointdocumentlocation_parent_sharepointdocumentlocation", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'sharepointdocumentlocation_principalobjectattributeaccess'
        /// </summary>
		[RelationshipSchemaName("sharepointdocumentlocation_principalobjectattributeaccess")]
		public IEnumerable<FieldSharing> SharepointdocumentlocationPrincipalobjectattributeaccess
		{
			get { return GetRelatedEntities<FieldSharing>("sharepointdocumentlocation_principalobjectattributeaccess", null); }
			set { SetRelatedEntities("sharepointdocumentlocation_principalobjectattributeaccess", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'SharePointDocumentLocation_ProcessSessions'
        /// </summary>
		[RelationshipSchemaName("SharePointDocumentLocation_ProcessSessions")]
		public IEnumerable<ProcessSession> SharePointDocumentLocationProcessSessions
		{
			get { return GetRelatedEntities<ProcessSession>("SharePointDocumentLocation_ProcessSessions", null); }
			set { SetRelatedEntities("SharePointDocumentLocation_ProcessSessions", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'SharePointDocumentLocation_SyncErrors'
        /// </summary>
		[RelationshipSchemaName("SharePointDocumentLocation_SyncErrors")]
		public IEnumerable<SyncError> SharePointDocumentLocationSyncErrors
		{
			get { return GetRelatedEntities<SyncError>("SharePointDocumentLocation_SyncErrors", null); }
			set { SetRelatedEntities("SharePointDocumentLocation_SyncErrors", null, value); }
		}
		#endregion

		#region Actions
		#endregion

		#region OptionSetEnums
		public enum egLocationType
		{	
		
			[Label("General")]
			[Description(@"")]
			General = 0, 
		
			[Label("Dedicated for OneNote Integration")]
			[Description(@"")]
			DedicatedForOneNoteIntegration = 1, 
		}
		
		public enum eStatus
		{	
		
			[Label("Active")]
			[Description(@"")]
			Active = 0, 
		
			[Label("Inactive")]
			[Description(@"")]
			Inactive = 1, 
		}
		
		public enum eStatusReason
		{	
		
			[Label("Active")]
			[Description(@"")]
			Active_Active = 1, 
		
			[Label("Inactive")]
			[Description(@"")]
			Inactive_Inactive = 2, 
		}
		
		public enum egServiceType
		{	
		
			[Label("SharePoint")]
			[Description(@"")]
			SharePoint = 0, 
		
			[Label("OneDrive")]
			[Description(@"")]
			OneDrive = 1, 
		
			[Label("Shared with me")]
			[Description(@"")]
			SharedWithMe = 2, 
		
			[Label("MS Teams")]
			[Description(@"")]
			MSTeams = 3, 
		}
		
		#endregion	

		#region Properties
		public static class Properties 
		{
			/// <summary>absoluteurl</summary>
			public const string AbsoluteURL = "absoluteurl";

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

			/// <summary>description</summary>
			public const string Description = "description";

			/// <summary>exchangerate</summary>
			public const string ExchangeRate = "exchangerate";

			/// <summary>importsequencenumber</summary>
			public const string ImportSequenceNumber = "importsequencenumber";

			/// <summary>locationtype</summary>
			public const string LocationType = "locationtype";

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

			/// <summary>name</summary>
			public const string Name = "name";

			/// <summary>overriddencreatedon</summary>
			public const string RecordCreatedOn = "overriddencreatedon";

			/// <summary>ownerid</summary>
			public const string Owner = "ownerid";

			/// <summary>owneridname</summary>
			public const string Owneridname = "owneridname";

			/// <summary>owneridtype</summary>
			public const string Owneridtype = "owneridtype";

			/// <summary>owneridyominame</summary>
			public const string Owneridyominame = "owneridyominame";

			/// <summary>owningbusinessunit</summary>
			public const string OwningBusinessUnit = "owningbusinessunit";

			/// <summary>owningteam</summary>
			public const string OwningTeam = "owningteam";

			/// <summary>owninguser</summary>
			public const string OwningUser = "owninguser";

			/// <summary>parentsiteorlocation</summary>
			public const string ParentSiteOrLocation = "parentsiteorlocation";

			/// <summary>parentsiteorlocationname</summary>
			public const string Parentsiteorlocationname = "parentsiteorlocationname";

			/// <summary>parentsiteorlocationtypecode</summary>
			public const string Parentsiteorlocationtypecode = "parentsiteorlocationtypecode";

			/// <summary>regardingobjectid</summary>
			public const string Regarding = "regardingobjectid";

			/// <summary>regardingobjectidname</summary>
			public const string Regardingobjectidname = "regardingobjectidname";

			/// <summary>regardingobjectidyominame</summary>
			public const string Regardingobjectidyominame = "regardingobjectidyominame";

			/// <summary>regardingobjecttypecode</summary>
			public const string Regardingobjecttypecode = "regardingobjecttypecode";

			/// <summary>relativeurl</summary>
			public const string RelativeURL = "relativeurl";

			/// <summary>servicetype</summary>
			public const string ServiceType = "servicetype";

			/// <summary>sharepointdocumentlocationid</summary>
			public const string SharePointDocumentLocationId = "sharepointdocumentlocationid";

			/// <summary>sitecollectionid</summary>
			public const string SitecollectionId = "sitecollectionid";

			/// <summary>statecode</summary>
			public const string Status = "statecode";

			/// <summary>statuscode</summary>
			public const string StatusReason = "statuscode";

			/// <summary>timezoneruleversionnumber</summary>
			public const string Timezoneruleversionnumber = "timezoneruleversionnumber";

			/// <summary>transactioncurrencyid</summary>
			public const string Currency = "transactioncurrencyid";

			/// <summary>transactioncurrencyidname</summary>
			public const string Transactioncurrencyidname = "transactioncurrencyidname";

			/// <summary>userid</summary>
			public const string SharePointDocumentLocationOwnerId = "userid";

			/// <summary>utcconversiontimezonecode</summary>
			public const string Utcconversiontimezonecode = "utcconversiontimezonecode";

			/// <summary>versionnumber</summary>
			public const string Versionnumber = "versionnumber";

		}
		#endregion

		#region Schemas
		public static class Schemas 
		{
			/// <summary>1:N SharePointDocumentLocation_AsyncOperations</summary>
			public const string SharePointDocumentLocationAsyncOperations = "SharePointDocumentLocation_AsyncOperations";

			/// <summary>1:N SharePointDocumentLocation_DuplicateBaseRecord</summary>
			public const string SharePointDocumentLocationDuplicateBaseRecord = "SharePointDocumentLocation_DuplicateBaseRecord";

			/// <summary>1:N SharePointDocumentLocation_DuplicateMatchingRecord</summary>
			public const string SharePointDocumentLocationDuplicateMatchingRecord = "SharePointDocumentLocation_DuplicateMatchingRecord";

			/// <summary>1:N sharepointdocumentlocation_parent_sharepointdocumentlocation</summary>
			public const string SharepointdocumentlocationParentSharepointdocumentlocation = "sharepointdocumentlocation_parent_sharepointdocumentlocation";

			/// <summary>1:N sharepointdocumentlocation_principalobjectattributeaccess</summary>
			public const string SharepointdocumentlocationPrincipalobjectattributeaccess = "sharepointdocumentlocation_principalobjectattributeaccess";

			/// <summary>1:N SharePointDocumentLocation_ProcessSessions</summary>
			public const string SharePointDocumentLocationProcessSessions = "SharePointDocumentLocation_ProcessSessions";

			/// <summary>1:N SharePointDocumentLocation_SyncErrors</summary>
			public const string SharePointDocumentLocationSyncErrors = "SharePointDocumentLocation_SyncErrors";

		}
		#endregion
	}
}

