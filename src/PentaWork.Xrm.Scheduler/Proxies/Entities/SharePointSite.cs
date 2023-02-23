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
	[EntityLogicalName("sharepointsite")]
	public sealed class SharePointSite : Entity
	{	
		public static readonly int? EntityTypeCode = 9502;
		public new const string LogicalName = "sharepointsite";
		public const string PrimaryIdAttribute = "sharepointsiteid";
		public const string PrimaryNameAttribute = "name";
	
		public SharePointSite() : base("sharepointsite") { }

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
		///
		/// Precision: 10
		/// MaxValue: 100000000000
		/// MinValue: 0.0000000001
        /// </summary>
		[DisplayName("Exchange Rate")]
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
        /// folderstructureentity
        /// </summary>
		[DisplayName("Entity for SharePoint Folder Structure")]
		[AttributeLogicalName("folderstructureentity")]
		public string EntityForSharePointFolderStructure
		{	
			get { return GetAttributeValue<string>("folderstructureentity"); }
			set
			{ 
				if(value == EntityForSharePointFolderStructure) return;
				SetAttributeValue("folderstructureentity", value);
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
        /// isdefault
        /// </summary>
		[DisplayName("Default Site")]
		[AttributeLogicalName("isdefault")]
		public bool? DefaultSite
		{	
			get { return GetAttributeValue<bool?>("isdefault"); }
			set
			{ 
				if(value == DefaultSite) return;
				SetAttributeValue("isdefault", value);
			}
		}	
			
		/// <summary>
        /// isgridpresent
        /// </summary>
		[DisplayName("List component is installed")]
		[AttributeLogicalName("isgridpresent")]
		public bool? ListComponentIsInstalled
		{	
			get { return GetAttributeValue<bool?>("isgridpresent"); }
			set
			{ 
				if(value == ListComponentIsInstalled) return;
				SetAttributeValue("isgridpresent", value);
			}
		}	
			
		/// <summary>
        /// ispowerbisite
        /// </summary>
		[DisplayName("Allow Embedding of Power BI Reports")]
		[AttributeLogicalName("ispowerbisite")]
		public bool? AllowEmbeddingOfPowerBIReports
		{	
			get { return GetAttributeValue<bool?>("ispowerbisite"); }
			set
			{ 
				if(value == AllowEmbeddingOfPowerBIReports) return;
				SetAttributeValue("ispowerbisite", value);
			}
		}	
			
		/// <summary>
        /// lastvalidated
        /// </summary>
		[DisplayName("Last Validated")]
		[AttributeLogicalName("lastvalidated")]
		public DateTime? LastValidated
		{	
			get { return GetAttributeValue<DateTime?>("lastvalidated"); }
			set
			{ 
				if(value == LastValidated) return;
				SetAttributeValue("lastvalidated", value);
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
        /// parentsite
        /// </summary>
		[DisplayName("Parent Site")]
		[AttributeLogicalName("parentsite")]
		public EntityReference ParentSite
		{	
			get { return GetAttributeValue<EntityReference>("parentsite"); }
			set
			{ 
				if(value == ParentSite) return;
				SetAttributeValue("parentsite", value);
			}
		}	
			
		/// <summary>
        /// parentsitename
        /// </summary>
		[DisplayName("parentsitename")]
		[AttributeLogicalName("parentsitename")]
		public string Parentsitename
		{	
			get { return GetAttributeValue<string>("parentsitename"); }
			set
			{ 
				if(value == Parentsitename) return;
				SetAttributeValue("parentsitename", value);
			}
		}	
			
		/// <summary>
        /// parentsiteobjecttypecode
        /// </summary>
		[DisplayName("parentsiteobjecttypecode")]
		[AttributeLogicalName("parentsiteobjecttypecode")]
		public string Parentsiteobjecttypecode
		{	
			get { return GetAttributeValue<string>("parentsiteobjecttypecode"); }
			set
			{ 
				if(value == Parentsiteobjecttypecode) return;
				SetAttributeValue("parentsiteobjecttypecode", value);
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
        /// sharepointsiteid
        /// </summary>
		[DisplayName("SharePoint Site ID")]
		[AttributeLogicalName("sharepointsiteid")]
		public override Guid Id
		{
			get => base.Id;
			set { base.Id = value; SetAttributeValue("sharepointsiteid", value); }
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
		[DisplayName("SharePoint Site Owner")]
		[AttributeLogicalName("userid")]
		public Guid SharePointSiteOwnerId
		{	
			get { return GetAttributeValue<Guid>("userid"); }
			set
			{ 
				if(value == SharePointSiteOwnerId) return;
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
        /// validationstatus
        /// </summary>
		[DisplayName("Last Validation Status")]
		[AttributeLogicalName("validationstatus")]
		public egValidationStatus? LastValidationStatus
		{	
			get 
			{ 
				var optionSetValue = GetAttributeValue<OptionSetValue>("validationstatus");
				if (optionSetValue != null) return (egValidationStatus)optionSetValue.Value;
				else return null;
			}
			set 
			{ 
				if(value == LastValidationStatus) return;

				OptionSetValue optionSetValue = null;
				if(value != null) optionSetValue = new OptionSetValue((int)value);
				SetAttributeValue("validationstatus", optionSetValue); 
			}
		}

		/// <summary>
        /// validationstatuserrorcode
        /// </summary>
		[DisplayName("Additional Information")]
		[AttributeLogicalName("validationstatuserrorcode")]
		public egValidationStatusReason? AdditionalInformation
		{	
			get 
			{ 
				var optionSetValue = GetAttributeValue<OptionSetValue>("validationstatuserrorcode");
				if (optionSetValue != null) return (egValidationStatusReason)optionSetValue.Value;
				else return null;
			}
			set 
			{ 
				if(value == AdditionalInformation) return;

				OptionSetValue optionSetValue = null;
				if(value != null) optionSetValue = new OptionSetValue((int)value);
				SetAttributeValue("validationstatuserrorcode", optionSetValue); 
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
        /// 1:N Get entities for 'sharepointdocumentlocation_parent_sharepointsite'
        /// </summary>
		[RelationshipSchemaName("sharepointdocumentlocation_parent_sharepointsite")]
		public IEnumerable<DocumentLocation> SharepointdocumentlocationParentSharepointsite
		{
			get { return GetRelatedEntities<DocumentLocation>("sharepointdocumentlocation_parent_sharepointsite", null); }
			set { SetRelatedEntities("sharepointdocumentlocation_parent_sharepointsite", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'SharePointSite_AsyncOperations'
        /// </summary>
		[RelationshipSchemaName("SharePointSite_AsyncOperations")]
		public IEnumerable<SystemJob> SharePointSiteAsyncOperations
		{
			get { return GetRelatedEntities<SystemJob>("SharePointSite_AsyncOperations", null); }
			set { SetRelatedEntities("SharePointSite_AsyncOperations", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'SharePointSite_DuplicateBaseRecord'
        /// </summary>
		[RelationshipSchemaName("SharePointSite_DuplicateBaseRecord")]
		public IEnumerable<DuplicateRecord> SharePointSiteDuplicateBaseRecord
		{
			get { return GetRelatedEntities<DuplicateRecord>("SharePointSite_DuplicateBaseRecord", null); }
			set { SetRelatedEntities("SharePointSite_DuplicateBaseRecord", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'SharePointSite_DuplicateMatchingRecord'
        /// </summary>
		[RelationshipSchemaName("SharePointSite_DuplicateMatchingRecord")]
		public IEnumerable<DuplicateRecord> SharePointSiteDuplicateMatchingRecord
		{
			get { return GetRelatedEntities<DuplicateRecord>("SharePointSite_DuplicateMatchingRecord", null); }
			set { SetRelatedEntities("SharePointSite_DuplicateMatchingRecord", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'sharepointsite_parentsite_sharepointsite'
        /// </summary>
		[RelationshipSchemaName("sharepointsite_parentsite_sharepointsite")]
		public IEnumerable<SharePointSite> SharepointsiteParentsiteSharepointsite
		{
			get { return GetRelatedEntities<SharePointSite>("sharepointsite_parentsite_sharepointsite", null); }
			set { SetRelatedEntities("sharepointsite_parentsite_sharepointsite", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'sharepointsite_principalobjectattributeaccess'
        /// </summary>
		[RelationshipSchemaName("sharepointsite_principalobjectattributeaccess")]
		public IEnumerable<FieldSharing> SharepointsitePrincipalobjectattributeaccess
		{
			get { return GetRelatedEntities<FieldSharing>("sharepointsite_principalobjectattributeaccess", null); }
			set { SetRelatedEntities("sharepointsite_principalobjectattributeaccess", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'SharePointSite_ProcessSessions'
        /// </summary>
		[RelationshipSchemaName("SharePointSite_ProcessSessions")]
		public IEnumerable<ProcessSession> SharePointSiteProcessSessions
		{
			get { return GetRelatedEntities<ProcessSession>("SharePointSite_ProcessSessions", null); }
			set { SetRelatedEntities("SharePointSite_ProcessSessions", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'SharePointSite_SyncErrors'
        /// </summary>
		[RelationshipSchemaName("SharePointSite_SyncErrors")]
		public IEnumerable<SyncError> SharePointSiteSyncErrors
		{
			get { return GetRelatedEntities<SyncError>("SharePointSite_SyncErrors", null); }
			set { SetRelatedEntities("SharePointSite_SyncErrors", null, value); }
		}
		#endregion

		#region Actions
		#endregion

		#region OptionSetEnums
		public enum egValidationStatus
		{	
		
			[Label("Not Validated")]
			[Description(@"")]
			NotValidated = 1, 
		
			[Label("In Progress")]
			[Description(@"")]
			InProgress = 2, 
		
			[Label("Invalid")]
			[Description(@"")]
			Invalid = 3, 
		
			[Label("Valid")]
			[Description(@"")]
			Valid = 4, 
		
			[Label("Could not validate")]
			[Description(@"")]
			CouldNotValidate = 5, 
		}
		
		public enum egValidationStatusReason
		{	
		
			[Label("This record's URL has not been validated.")]
			[Description(@"")]
			ThisRecordsURLHasNotBeenValidated = 1, 
		
			[Label("This record's URL is valid.")]
			[Description(@"")]
			ThisRecordsURLIsValid = 2, 
		
			[Label("This record's URL is not valid.")]
			[Description(@"")]
			ThisRecordsURLIsNotValid = 3, 
		
			[Label("The URL schemes of Microsoft Dynamics 365 and SharePoint are different.")]
			[Description(@"")]
			TheURLSchemesOfMicrosoftDynamics365AndSharePointAreDifferent = 4, 
		
			[Label("The URL could not be accessed because of Internet Explorer security settings.")]
			[Description(@"")]
			TheURLCouldNotBeAccessedBecauseOfInternetExplorerSecuritySettings = 5, 
		
			[Label("Authentication failure.")]
			[Description(@"")]
			AuthenticationFailure = 6, 
		
			[Label("Invalid certificates.")]
			[Description(@"")]
			InvalidCertificates = 7, 
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

			/// <summary>folderstructureentity</summary>
			public const string EntityForSharePointFolderStructure = "folderstructureentity";

			/// <summary>importsequencenumber</summary>
			public const string ImportSequenceNumber = "importsequencenumber";

			/// <summary>isdefault</summary>
			public const string DefaultSite = "isdefault";

			/// <summary>isgridpresent</summary>
			public const string ListComponentIsInstalled = "isgridpresent";

			/// <summary>ispowerbisite</summary>
			public const string AllowEmbeddingOfPowerBIReports = "ispowerbisite";

			/// <summary>lastvalidated</summary>
			public const string LastValidated = "lastvalidated";

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

			/// <summary>parentsite</summary>
			public const string ParentSite = "parentsite";

			/// <summary>parentsitename</summary>
			public const string Parentsitename = "parentsitename";

			/// <summary>parentsiteobjecttypecode</summary>
			public const string Parentsiteobjecttypecode = "parentsiteobjecttypecode";

			/// <summary>relativeurl</summary>
			public const string RelativeURL = "relativeurl";

			/// <summary>servicetype</summary>
			public const string ServiceType = "servicetype";

			/// <summary>sharepointsiteid</summary>
			public const string SharePointSiteId = "sharepointsiteid";

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
			public const string SharePointSiteOwnerId = "userid";

			/// <summary>utcconversiontimezonecode</summary>
			public const string Utcconversiontimezonecode = "utcconversiontimezonecode";

			/// <summary>validationstatus</summary>
			public const string LastValidationStatus = "validationstatus";

			/// <summary>validationstatuserrorcode</summary>
			public const string AdditionalInformation = "validationstatuserrorcode";

			/// <summary>versionnumber</summary>
			public const string Versionnumber = "versionnumber";

		}
		#endregion

		#region Schemas
		public static class Schemas 
		{
			/// <summary>1:N sharepointdocumentlocation_parent_sharepointsite</summary>
			public const string SharepointdocumentlocationParentSharepointsite = "sharepointdocumentlocation_parent_sharepointsite";

			/// <summary>1:N SharePointSite_AsyncOperations</summary>
			public const string SharePointSiteAsyncOperations = "SharePointSite_AsyncOperations";

			/// <summary>1:N SharePointSite_DuplicateBaseRecord</summary>
			public const string SharePointSiteDuplicateBaseRecord = "SharePointSite_DuplicateBaseRecord";

			/// <summary>1:N SharePointSite_DuplicateMatchingRecord</summary>
			public const string SharePointSiteDuplicateMatchingRecord = "SharePointSite_DuplicateMatchingRecord";

			/// <summary>1:N sharepointsite_parentsite_sharepointsite</summary>
			public const string SharepointsiteParentsiteSharepointsite = "sharepointsite_parentsite_sharepointsite";

			/// <summary>1:N sharepointsite_principalobjectattributeaccess</summary>
			public const string SharepointsitePrincipalobjectattributeaccess = "sharepointsite_principalobjectattributeaccess";

			/// <summary>1:N SharePointSite_ProcessSessions</summary>
			public const string SharePointSiteProcessSessions = "SharePointSite_ProcessSessions";

			/// <summary>1:N SharePointSite_SyncErrors</summary>
			public const string SharePointSiteSyncErrors = "SharePointSite_SyncErrors";

		}
		#endregion
	}
}

