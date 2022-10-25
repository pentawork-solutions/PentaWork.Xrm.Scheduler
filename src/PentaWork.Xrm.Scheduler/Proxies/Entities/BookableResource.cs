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
	[EntityLogicalName("bookableresource")]
	public sealed class BookableResource : Entity
	{	
		public static readonly int? EntityTypeCode = 1150;
		public new const string LogicalName = "bookableresource";
		public const string PrimaryIdAttribute = "bookableresourceid";
		public const string PrimaryNameAttribute = "name";
	
		public BookableResource() : base("bookableresource") { }

		#region Attributes
		/// <summary>
        /// accountid
        /// </summary>
		[DisplayName("Account")]
		[AttributeLogicalName("accountid")]
		public EntityReference Account
		{	
			get { return GetAttributeValue<EntityReference>("accountid"); }
			set
			{ 
				if(value == Account) return;
				SetAttributeValue("accountid", value);
			}
		}	
			
		/// <summary>
        /// accountidname
        /// </summary>
		[DisplayName("accountidname")]
		[AttributeLogicalName("accountidname")]
		public string Accountidname
		{	
			get { return GetAttributeValue<string>("accountidname"); }
			set
			{ 
				if(value == Accountidname) return;
				SetAttributeValue("accountidname", value);
			}
		}	
			
		/// <summary>
        /// accountidyominame
        /// </summary>
		[DisplayName("accountidyominame")]
		[AttributeLogicalName("accountidyominame")]
		public string Accountidyominame
		{	
			get { return GetAttributeValue<string>("accountidyominame"); }
			set
			{ 
				if(value == Accountidyominame) return;
				SetAttributeValue("accountidyominame", value);
			}
		}	
			
		/// <summary>
        /// bookableresourceid
        /// </summary>
		[DisplayName("Bookable Resource")]
		[AttributeLogicalName("bookableresourceid")]
		public override Guid Id
		{
			get => base.Id;
			set { base.Id = value; SetAttributeValue("bookableresourceid", value); }
		}

							/// <summary>
        /// calendarid
        /// </summary>
		[DisplayName("Calendar")]
		[AttributeLogicalName("calendarid")]
		public EntityReference Calendar
		{	
			get { return GetAttributeValue<EntityReference>("calendarid"); }
			set
			{ 
				if(value == Calendar) return;
				SetAttributeValue("calendarid", value);
			}
		}	
			
		/// <summary>
        /// calendaridname
        /// </summary>
		[DisplayName("calendaridname")]
		[AttributeLogicalName("calendaridname")]
		public string Calendaridname
		{	
			get { return GetAttributeValue<string>("calendaridname"); }
			set
			{ 
				if(value == Calendaridname) return;
				SetAttributeValue("calendaridname", value);
			}
		}	
			
		/// <summary>
        /// contactid
        /// </summary>
		[DisplayName("Contact")]
		[AttributeLogicalName("contactid")]
		public EntityReference Contact
		{	
			get { return GetAttributeValue<EntityReference>("contactid"); }
			set
			{ 
				if(value == Contact) return;
				SetAttributeValue("contactid", value);
			}
		}	
			
		/// <summary>
        /// contactidname
        /// </summary>
		[DisplayName("contactidname")]
		[AttributeLogicalName("contactidname")]
		public string Contactidname
		{	
			get { return GetAttributeValue<string>("contactidname"); }
			set
			{ 
				if(value == Contactidname) return;
				SetAttributeValue("contactidname", value);
			}
		}	
			
		/// <summary>
        /// contactidyominame
        /// </summary>
		[DisplayName("contactidyominame")]
		[AttributeLogicalName("contactidyominame")]
		public string Contactidyominame
		{	
			get { return GetAttributeValue<string>("contactidyominame"); }
			set
			{ 
				if(value == Contactidyominame) return;
				SetAttributeValue("contactidyominame", value);
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
        /// processid
        /// </summary>
		[DisplayName("Process Id")]
		[AttributeLogicalName("processid")]
		public Guid ProcessId
		{	
			get { return GetAttributeValue<Guid>("processid"); }
			set
			{ 
				if(value == ProcessId) return;
				SetAttributeValue("processid", value);
			}
		}	
			
		/// <summary>
        /// resourcetype
        /// </summary>
		[DisplayName("Resource Type")]
		[AttributeLogicalName("resourcetype")]
		public eTypeOfTheResource? ResourceType
		{	
			get 
			{ 
				var optionSetValue = GetAttributeValue<OptionSetValue>("resourcetype");
				if (optionSetValue != null) return (eTypeOfTheResource)optionSetValue.Value;
				else return null;
			}
			set 
			{ 
				if(value == ResourceType) return;

				OptionSetValue optionSetValue = null;
				if(value != null) optionSetValue = new OptionSetValue((int)value);
				SetAttributeValue("resourcetype", optionSetValue); 
			}
		}

		/// <summary>
        /// stageid
        /// </summary>
		[DisplayName("(Deprecated) Stage Id")]
		[AttributeLogicalName("stageid")]
		public Guid DeprecatedStageId
		{	
			get { return GetAttributeValue<Guid>("stageid"); }
			set
			{ 
				if(value == DeprecatedStageId) return;
				SetAttributeValue("stageid", value);
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
        /// timezone
        /// </summary>
		[DisplayName("Time Zone")]
		[AttributeLogicalName("timezone")]
		public int? TimeZone
		{	
			get { return GetAttributeValue<int?>("timezone"); }
			set
			{ 
				if(value == TimeZone) return;
				SetAttributeValue("timezone", value);
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
        /// traversedpath
        /// </summary>
		[DisplayName("(Deprecated) Traversed Path")]
		[AttributeLogicalName("traversedpath")]
		public string DeprecatedTraversedPath
		{	
			get { return GetAttributeValue<string>("traversedpath"); }
			set
			{ 
				if(value == DeprecatedTraversedPath) return;
				SetAttributeValue("traversedpath", value);
			}
		}	
			
		/// <summary>
        /// userid
        /// </summary>
		[DisplayName("User")]
		[AttributeLogicalName("userid")]
		public EntityReference User
		{	
			get { return GetAttributeValue<EntityReference>("userid"); }
			set
			{ 
				if(value == User) return;
				SetAttributeValue("userid", value);
			}
		}	
			
		/// <summary>
        /// useridname
        /// </summary>
		[DisplayName("useridname")]
		[AttributeLogicalName("useridname")]
		public string Useridname
		{	
			get { return GetAttributeValue<string>("useridname"); }
			set
			{ 
				if(value == Useridname) return;
				SetAttributeValue("useridname", value);
			}
		}	
			
		/// <summary>
        /// useridyominame
        /// </summary>
		[DisplayName("useridyominame")]
		[AttributeLogicalName("useridyominame")]
		public string Useridyominame
		{	
			get { return GetAttributeValue<string>("useridyominame"); }
			set
			{ 
				if(value == Useridyominame) return;
				SetAttributeValue("useridyominame", value);
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
		[DisplayName("Version Number")]
		[AttributeLogicalName("versionnumber")]
		public int? VersionNumber
		{	
			get { return GetAttributeValue<int?>("versionnumber"); }
			set
			{ 
				if(value == VersionNumber) return;
				SetAttributeValue("versionnumber", value);
			}
		}	
			
		#endregion	

		#region Relations
			/// <summary>
        /// 1:N Get entities for 'bookableresource_Annotations'
        /// </summary>
		[RelationshipSchemaName("bookableresource_Annotations")]
		public IEnumerable<Note> BookableresourceAnnotations
		{
			get { return GetRelatedEntities<Note>("bookableresource_Annotations", null); }
			set { SetRelatedEntities("bookableresource_Annotations", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'bookableresource_AsyncOperations'
        /// </summary>
		[RelationshipSchemaName("bookableresource_AsyncOperations")]
		public IEnumerable<SystemJob> BookableresourceAsyncOperations
		{
			get { return GetRelatedEntities<SystemJob>("bookableresource_AsyncOperations", null); }
			set { SetRelatedEntities("bookableresource_AsyncOperations", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'bookableresource_bookableresourcebooking_Resource'
        /// </summary>
		[RelationshipSchemaName("bookableresource_bookableresourcebooking_Resource")]
		public IEnumerable<BookableResourceBooking> BookableresourceBookableresourcebookingResource
		{
			get { return GetRelatedEntities<BookableResourceBooking>("bookableresource_bookableresourcebooking_Resource", null); }
			set { SetRelatedEntities("bookableresource_bookableresourcebooking_Resource", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'bookableresource_bookableresourcecategoryassn_Resource'
        /// </summary>
		[RelationshipSchemaName("bookableresource_bookableresourcecategoryassn_Resource")]
		public IEnumerable<BookableResourceCategoryAssn> BookableresourceBookableresourcecategoryassnResource
		{
			get { return GetRelatedEntities<BookableResourceCategoryAssn>("bookableresource_bookableresourcecategoryassn_Resource", null); }
			set { SetRelatedEntities("bookableresource_bookableresourcecategoryassn_Resource", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'bookableresource_bookableresourcecharacteristic_Resource'
        /// </summary>
		[RelationshipSchemaName("bookableresource_bookableresourcecharacteristic_Resource")]
		public IEnumerable<BookableResourceCharacteristic> BookableresourceBookableresourcecharacteristicResource
		{
			get { return GetRelatedEntities<BookableResourceCharacteristic>("bookableresource_bookableresourcecharacteristic_Resource", null); }
			set { SetRelatedEntities("bookableresource_bookableresourcecharacteristic_Resource", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'bookableresource_bookableresourcegroup_ChildResource'
        /// </summary>
		[RelationshipSchemaName("bookableresource_bookableresourcegroup_ChildResource")]
		public IEnumerable<BookableResourceGroup> BookableresourceBookableresourcegroupChildResource
		{
			get { return GetRelatedEntities<BookableResourceGroup>("bookableresource_bookableresourcegroup_ChildResource", null); }
			set { SetRelatedEntities("bookableresource_bookableresourcegroup_ChildResource", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'bookableresource_bookableresourcegroup_ParentResource'
        /// </summary>
		[RelationshipSchemaName("bookableresource_bookableresourcegroup_ParentResource")]
		public IEnumerable<BookableResourceGroup> BookableresourceBookableresourcegroupParentResource
		{
			get { return GetRelatedEntities<BookableResourceGroup>("bookableresource_bookableresourcegroup_ParentResource", null); }
			set { SetRelatedEntities("bookableresource_bookableresourcegroup_ParentResource", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'bookableresource_BulkDeleteFailures'
        /// </summary>
		[RelationshipSchemaName("bookableresource_BulkDeleteFailures")]
		public IEnumerable<BulkDeleteFailure> BookableresourceBulkDeleteFailures
		{
			get { return GetRelatedEntities<BulkDeleteFailure>("bookableresource_BulkDeleteFailures", null); }
			set { SetRelatedEntities("bookableresource_BulkDeleteFailures", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'bookableresource_DuplicateBaseRecord'
        /// </summary>
		[RelationshipSchemaName("bookableresource_DuplicateBaseRecord")]
		public IEnumerable<DuplicateRecord> BookableresourceDuplicateBaseRecord
		{
			get { return GetRelatedEntities<DuplicateRecord>("bookableresource_DuplicateBaseRecord", null); }
			set { SetRelatedEntities("bookableresource_DuplicateBaseRecord", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'bookableresource_DuplicateMatchingRecord'
        /// </summary>
		[RelationshipSchemaName("bookableresource_DuplicateMatchingRecord")]
		public IEnumerable<DuplicateRecord> BookableresourceDuplicateMatchingRecord
		{
			get { return GetRelatedEntities<DuplicateRecord>("bookableresource_DuplicateMatchingRecord", null); }
			set { SetRelatedEntities("bookableresource_DuplicateMatchingRecord", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'bookableresource_MailboxTrackingFolders'
        /// </summary>
		[RelationshipSchemaName("bookableresource_MailboxTrackingFolders")]
		public IEnumerable<MailboxAutoTrackingFolder> BookableresourceMailboxTrackingFolders
		{
			get { return GetRelatedEntities<MailboxAutoTrackingFolder>("bookableresource_MailboxTrackingFolders", null); }
			set { SetRelatedEntities("bookableresource_MailboxTrackingFolders", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'bookableresource_PrincipalObjectAttributeAccess'
        /// </summary>
		[RelationshipSchemaName("bookableresource_PrincipalObjectAttributeAccess")]
		public IEnumerable<FieldSharing> BookableresourcePrincipalObjectAttributeAccess
		{
			get { return GetRelatedEntities<FieldSharing>("bookableresource_PrincipalObjectAttributeAccess", null); }
			set { SetRelatedEntities("bookableresource_PrincipalObjectAttributeAccess", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'bookableresource_ProcessSession'
        /// </summary>
		[RelationshipSchemaName("bookableresource_ProcessSession")]
		public IEnumerable<ProcessSession> BookableresourceProcessSession
		{
			get { return GetRelatedEntities<ProcessSession>("bookableresource_ProcessSession", null); }
			set { SetRelatedEntities("bookableresource_ProcessSession", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'BookableResource_SyncErrors'
        /// </summary>
		[RelationshipSchemaName("BookableResource_SyncErrors")]
		public IEnumerable<SyncError> BookableResourceSyncErrors
		{
			get { return GetRelatedEntities<SyncError>("BookableResource_SyncErrors", null); }
			set { SetRelatedEntities("BookableResource_SyncErrors", null, value); }
		}
		#endregion

		#region Actions
		#endregion

		#region OptionSetEnums
		public enum eTypeOfTheResource
		{	
		
			[Label("Generic")]
			[Description(@"")]
			Generic = 1, 
		
			[Label("Contact")]
			[Description(@"")]
			Contact = 2, 
		
			[Label("User")]
			[Description(@"")]
			User = 3, 
		
			[Label("Equipment")]
			[Description(@"")]
			Equipment = 4, 
		
			[Label("Account")]
			[Description(@"")]
			Account = 5, 
		
			[Label("Crew")]
			[Description(@"")]
			Crew = 6, 
		
			[Label("Facility")]
			[Description(@"")]
			Facility = 7, 
		
			[Label("Pool")]
			[Description(@"")]
			Pool = 8, 
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
			/// <summary>accountid</summary>
			public const string Account = "accountid";

			/// <summary>accountidname</summary>
			public const string Accountidname = "accountidname";

			/// <summary>accountidyominame</summary>
			public const string Accountidyominame = "accountidyominame";

			/// <summary>bookableresourceid</summary>
			public const string BookableResourceId = "bookableresourceid";

			/// <summary>calendarid</summary>
			public const string Calendar = "calendarid";

			/// <summary>calendaridname</summary>
			public const string Calendaridname = "calendaridname";

			/// <summary>contactid</summary>
			public const string Contact = "contactid";

			/// <summary>contactidname</summary>
			public const string Contactidname = "contactidname";

			/// <summary>contactidyominame</summary>
			public const string Contactidyominame = "contactidyominame";

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

			/// <summary>exchangerate</summary>
			public const string ExchangeRate = "exchangerate";

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

			/// <summary>processid</summary>
			public const string ProcessId = "processid";

			/// <summary>resourcetype</summary>
			public const string ResourceType = "resourcetype";

			/// <summary>stageid</summary>
			public const string DeprecatedStageId = "stageid";

			/// <summary>statecode</summary>
			public const string Status = "statecode";

			/// <summary>statuscode</summary>
			public const string StatusReason = "statuscode";

			/// <summary>timezone</summary>
			public const string TimeZone = "timezone";

			/// <summary>timezoneruleversionnumber</summary>
			public const string TimeZoneRuleVersionNumber = "timezoneruleversionnumber";

			/// <summary>transactioncurrencyid</summary>
			public const string Currency = "transactioncurrencyid";

			/// <summary>transactioncurrencyidname</summary>
			public const string Transactioncurrencyidname = "transactioncurrencyidname";

			/// <summary>traversedpath</summary>
			public const string DeprecatedTraversedPath = "traversedpath";

			/// <summary>userid</summary>
			public const string User = "userid";

			/// <summary>useridname</summary>
			public const string Useridname = "useridname";

			/// <summary>useridyominame</summary>
			public const string Useridyominame = "useridyominame";

			/// <summary>utcconversiontimezonecode</summary>
			public const string UTCConversionTimeZoneCode = "utcconversiontimezonecode";

			/// <summary>versionnumber</summary>
			public const string VersionNumber = "versionnumber";

		}
		#endregion

		#region Schemas
		public static class Schemas 
		{
			/// <summary>1:N bookableresource_Annotations</summary>
			public const string BookableresourceAnnotations = "bookableresource_Annotations";

			/// <summary>1:N bookableresource_AsyncOperations</summary>
			public const string BookableresourceAsyncOperations = "bookableresource_AsyncOperations";

			/// <summary>1:N bookableresource_bookableresourcebooking_Resource</summary>
			public const string BookableresourceBookableresourcebookingResource = "bookableresource_bookableresourcebooking_Resource";

			/// <summary>1:N bookableresource_bookableresourcecategoryassn_Resource</summary>
			public const string BookableresourceBookableresourcecategoryassnResource = "bookableresource_bookableresourcecategoryassn_Resource";

			/// <summary>1:N bookableresource_bookableresourcecharacteristic_Resource</summary>
			public const string BookableresourceBookableresourcecharacteristicResource = "bookableresource_bookableresourcecharacteristic_Resource";

			/// <summary>1:N bookableresource_bookableresourcegroup_ChildResource</summary>
			public const string BookableresourceBookableresourcegroupChildResource = "bookableresource_bookableresourcegroup_ChildResource";

			/// <summary>1:N bookableresource_bookableresourcegroup_ParentResource</summary>
			public const string BookableresourceBookableresourcegroupParentResource = "bookableresource_bookableresourcegroup_ParentResource";

			/// <summary>1:N bookableresource_BulkDeleteFailures</summary>
			public const string BookableresourceBulkDeleteFailures = "bookableresource_BulkDeleteFailures";

			/// <summary>1:N bookableresource_DuplicateBaseRecord</summary>
			public const string BookableresourceDuplicateBaseRecord = "bookableresource_DuplicateBaseRecord";

			/// <summary>1:N bookableresource_DuplicateMatchingRecord</summary>
			public const string BookableresourceDuplicateMatchingRecord = "bookableresource_DuplicateMatchingRecord";

			/// <summary>1:N bookableresource_MailboxTrackingFolders</summary>
			public const string BookableresourceMailboxTrackingFolders = "bookableresource_MailboxTrackingFolders";

			/// <summary>1:N bookableresource_PrincipalObjectAttributeAccess</summary>
			public const string BookableresourcePrincipalObjectAttributeAccess = "bookableresource_PrincipalObjectAttributeAccess";

			/// <summary>1:N bookableresource_ProcessSession</summary>
			public const string BookableresourceProcessSession = "bookableresource_ProcessSession";

			/// <summary>1:N BookableResource_SyncErrors</summary>
			public const string BookableResourceSyncErrors = "BookableResource_SyncErrors";

		}
		#endregion
	}
}

