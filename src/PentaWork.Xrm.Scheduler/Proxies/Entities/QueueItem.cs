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
	[EntityLogicalName("queueitem")]
	public sealed class QueueItem : Entity
	{	
		public static readonly int? EntityTypeCode = 2029;
		public new const string LogicalName = "queueitem";
		public const string PrimaryIdAttribute = "queueitemid";
		public const string PrimaryNameAttribute = "title";
	
		public QueueItem() : base("queueitem") { }

		#region Attributes
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
        /// enteredon
        /// </summary>
		[DisplayName("Entered Queue")]
		[AttributeLogicalName("enteredon")]
		public DateTime? EnteredQueue
		{	
			get { return GetAttributeValue<DateTime?>("enteredon"); }
			set
			{ 
				if(value == EnteredQueue) return;
				SetAttributeValue("enteredon", value);
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
        /// objectid
        /// </summary>
		[DisplayName("Object")]
		[AttributeLogicalName("objectid")]
		public EntityReference Object
		{	
			get { return GetAttributeValue<EntityReference>("objectid"); }
			set
			{ 
				if(value == Object) return;
				SetAttributeValue("objectid", value);
			}
		}	
			
		/// <summary>
        /// objectidname
        /// </summary>
		[DisplayName("objectidname")]
		[AttributeLogicalName("objectidname")]
		public string Objectidname
		{	
			get { return GetAttributeValue<string>("objectidname"); }
			set
			{ 
				if(value == Objectidname) return;
				SetAttributeValue("objectidname", value);
			}
		}	
			
		/// <summary>
        /// objectidtypecode
        /// </summary>
		[DisplayName("Regarding Object Type")]
		[AttributeLogicalName("objectidtypecode")]
		public string RegardingObjectType
		{	
			get { return GetAttributeValue<string>("objectidtypecode"); }
			set
			{ 
				if(value == RegardingObjectType) return;
				SetAttributeValue("objectidtypecode", value);
			}
		}	
			
		/// <summary>
        /// objecttypecode
        /// </summary>
		[DisplayName("Type")]
		[AttributeLogicalName("objecttypecode")]
		public eType? Type
		{	
			get 
			{ 
				var optionSetValue = GetAttributeValue<OptionSetValue>("objecttypecode");
				if (optionSetValue != null) return (eType)optionSetValue.Value;
				else return null;
			}
			set 
			{ 
				if(value == Type) return;

				OptionSetValue optionSetValue = null;
				if(value != null) optionSetValue = new OptionSetValue((int)value);
				SetAttributeValue("objecttypecode", optionSetValue); 
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
        /// priority
        /// </summary>
		[DisplayName("Priority")]
		[AttributeLogicalName("priority")]
		public int? Priority
		{	
			get { return GetAttributeValue<int?>("priority"); }
			set
			{ 
				if(value == Priority) return;
				SetAttributeValue("priority", value);
			}
		}	
			
		/// <summary>
        /// queueid
        /// </summary>
		[DisplayName("Queue")]
		[AttributeLogicalName("queueid")]
		public EntityReference Queue
		{	
			get { return GetAttributeValue<EntityReference>("queueid"); }
			set
			{ 
				if(value == Queue) return;
				SetAttributeValue("queueid", value);
			}
		}	
			
		/// <summary>
        /// queueidname
        /// </summary>
		[DisplayName("queueidname")]
		[AttributeLogicalName("queueidname")]
		public string Queueidname
		{	
			get { return GetAttributeValue<string>("queueidname"); }
			set
			{ 
				if(value == Queueidname) return;
				SetAttributeValue("queueidname", value);
			}
		}	
			
		/// <summary>
        /// queueitemid
        /// </summary>
		[DisplayName("Queue Item")]
		[AttributeLogicalName("queueitemid")]
		public override Guid Id
		{
			get => base.Id;
			set { base.Id = value; SetAttributeValue("queueitemid", value); }
		}

							/// <summary>
        /// sender
        /// </summary>
		[DisplayName("From")]
		[AttributeLogicalName("sender")]
		public string From
		{	
			get { return GetAttributeValue<string>("sender"); }
			set
			{ 
				if(value == From) return;
				SetAttributeValue("sender", value);
			}
		}	
			
		/// <summary>
        /// state
        /// </summary>
		[DisplayName("Status (deprecated)")]
		[AttributeLogicalName("state")]
		public int? Statusdeprecated
		{	
			get { return GetAttributeValue<int?>("state"); }
			set
			{ 
				if(value == Statusdeprecated) return;
				SetAttributeValue("state", value);
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
        /// status
        /// </summary>
		[DisplayName("Status Reason (deprecated)")]
		[AttributeLogicalName("status")]
		public int? StatusReasondeprecated
		{	
			get { return GetAttributeValue<int?>("status"); }
			set
			{ 
				if(value == StatusReasondeprecated) return;
				SetAttributeValue("status", value);
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
        /// torecipients
        /// </summary>
		[DisplayName("To")]
		[AttributeLogicalName("torecipients")]
		public string To
		{	
			get { return GetAttributeValue<string>("torecipients"); }
			set
			{ 
				if(value == To) return;
				SetAttributeValue("torecipients", value);
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
			
		/// <summary>
        /// workerid
        /// </summary>
		[DisplayName("Worked By")]
		[AttributeLogicalName("workerid")]
		public EntityReference WorkedBy
		{	
			get { return GetAttributeValue<EntityReference>("workerid"); }
			set
			{ 
				if(value == WorkedBy) return;
				SetAttributeValue("workerid", value);
			}
		}	
			
		/// <summary>
        /// workeridmodifiedon
        /// </summary>
		[DisplayName("Worked On")]
		[AttributeLogicalName("workeridmodifiedon")]
		public DateTime? WorkedOn
		{	
			get { return GetAttributeValue<DateTime?>("workeridmodifiedon"); }
			set
			{ 
				if(value == WorkedOn) return;
				SetAttributeValue("workeridmodifiedon", value);
			}
		}	
			
		/// <summary>
        /// workeridname
        /// </summary>
		[DisplayName("workeridname")]
		[AttributeLogicalName("workeridname")]
		public string Workeridname
		{	
			get { return GetAttributeValue<string>("workeridname"); }
			set
			{ 
				if(value == Workeridname) return;
				SetAttributeValue("workeridname", value);
			}
		}	
			
		/// <summary>
        /// workeridtype
        /// </summary>
		[DisplayName("Worker Type")]
		[AttributeLogicalName("workeridtype")]
		public string WorkerType
		{	
			get { return GetAttributeValue<string>("workeridtype"); }
			set
			{ 
				if(value == WorkerType) return;
				SetAttributeValue("workeridtype", value);
			}
		}	
			
		/// <summary>
        /// workeridyominame
        /// </summary>
		[DisplayName("workeridyominame")]
		[AttributeLogicalName("workeridyominame")]
		public string Workeridyominame
		{	
			get { return GetAttributeValue<string>("workeridyominame"); }
			set
			{ 
				if(value == Workeridyominame) return;
				SetAttributeValue("workeridyominame", value);
			}
		}	
			
		#endregion	

		#region Relations
			/// <summary>
        /// 1:N Get entities for 'QueueItem_AsyncOperations'
        /// </summary>
		[RelationshipSchemaName("QueueItem_AsyncOperations")]
		public IEnumerable<SystemJob> QueueItemAsyncOperations
		{
			get { return GetRelatedEntities<SystemJob>("QueueItem_AsyncOperations", null); }
			set { SetRelatedEntities("QueueItem_AsyncOperations", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'QueueItem_BulkDeleteFailures'
        /// </summary>
		[RelationshipSchemaName("QueueItem_BulkDeleteFailures")]
		public IEnumerable<BulkDeleteFailure> QueueItemBulkDeleteFailures
		{
			get { return GetRelatedEntities<BulkDeleteFailure>("QueueItem_BulkDeleteFailures", null); }
			set { SetRelatedEntities("QueueItem_BulkDeleteFailures", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'queueitem_principalobjectattributeaccess'
        /// </summary>
		[RelationshipSchemaName("queueitem_principalobjectattributeaccess")]
		public IEnumerable<FieldSharing> QueueitemPrincipalobjectattributeaccess
		{
			get { return GetRelatedEntities<FieldSharing>("queueitem_principalobjectattributeaccess", null); }
			set { SetRelatedEntities("queueitem_principalobjectattributeaccess", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'QueueItem_ProcessSessions'
        /// </summary>
		[RelationshipSchemaName("QueueItem_ProcessSessions")]
		public IEnumerable<ProcessSession> QueueItemProcessSessions
		{
			get { return GetRelatedEntities<ProcessSession>("QueueItem_ProcessSessions", null); }
			set { SetRelatedEntities("QueueItem_ProcessSessions", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'QueueItem_SyncErrors'
        /// </summary>
		[RelationshipSchemaName("QueueItem_SyncErrors")]
		public IEnumerable<SyncError> QueueItemSyncErrors
		{
			get { return GetRelatedEntities<SyncError>("QueueItem_SyncErrors", null); }
			set { SetRelatedEntities("QueueItem_SyncErrors", null, value); }
		}
		#endregion

		#region Actions
		#endregion

		#region OptionSetEnums
		public enum eType
		{	
		
			[Label("Knowledge Article Template")]
			[Description(@"Organizational Knowledge Article Template for Internal and external creation of Knowledge Articles.")]
			KnowledgeArticleTemplate = 10047, 
		
			[Label("Campaign Activity")]
			[Description(@"Task performed, or to be performed, by a user for planning or running a campaign.")]
			CampaignActivity = 4402, 
		
			[Label("Task")]
			[Description(@"Generic activity representing work needed to be done.")]
			Task = 4212, 
		
			[Label("Email")]
			[Description(@"Activity that is delivered using email protocols.")]
			Email = 4202, 
		
			[Label("Case")]
			[Description(@"Service request case associated with a contract.")]
			Case = 112, 
		
			[Label("Service Activity")]
			[Description(@"Activity offered by the organization to satisfy its customer's needs. Each service activity includes date, time, duration, and required resources.")]
			ServiceActivity = 4214, 
		
			[Label("Campaign Response")]
			[Description(@"Response from an existing or a potential new customer for a campaign.")]
			CampaignResponse = 4401, 
		
			[Label("Quick Campaign")]
			[Description(@"System operation used to perform lengthy and asynchronous operations on large data sets, such as distributing a campaign activity or quick campaign.")]
			QuickCampaign = 4406, 
		
			[Label("Social Activity")]
			[Description(@"For internal use only.")]
			SocialActivity = 4216, 
		
			[Label("Knowledge Article")]
			[Description(@"Organizational knowledge for internal and external use.")]
			KnowledgeArticle = 9953, 
		
			[Label("Fax")]
			[Description(@"Activity that tracks call outcome and number of pages for a fax and optionally stores an electronic copy of the document.")]
			Fax = 4204, 
		
			[Label("Appointment")]
			[Description(@"Commitment representing a time interval with start/end times and duration.")]
			Appointment = 4201, 
		
			[Label("Recurring Appointment")]
			[Description(@"The Master appointment of a recurring appointment series.")]
			RecurringAppointment = 4251, 
		
			[Label("Phone Call")]
			[Description(@"Activity to track a telephone call.")]
			PhoneCall = 4210, 
		
			[Label("Letter")]
			[Description(@"Activity that tracks the delivery of a letter. The activity can contain the electronic copy of the letter.")]
			Letter = 4207, 
		
			[Label("Activity")]
			[Description(@"Task performed, or to be performed, by a user. An activity is any action for which an entry can be made on a calendar.")]
			Activity = 4200, 
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
		
			[Label("Inactive")]
			[Description(@"")]
			Inactive_Inactive = 2, 
		
			[Label("Active")]
			[Description(@"")]
			Active_Active = 1, 
		}
		
		#endregion	

		#region Properties
		public static class Properties 
		{
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

			/// <summary>enteredon</summary>
			public const string EnteredQueue = "enteredon";

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

			/// <summary>objectid</summary>
			public const string Object = "objectid";

			/// <summary>objectidname</summary>
			public const string Objectidname = "objectidname";

			/// <summary>objectidtypecode</summary>
			public const string RegardingObjectType = "objectidtypecode";

			/// <summary>objecttypecode</summary>
			public const string Type = "objecttypecode";

			/// <summary>organizationid</summary>
			public const string Organization = "organizationid";

			/// <summary>organizationidname</summary>
			public const string Organizationidname = "organizationidname";

			/// <summary>overriddencreatedon</summary>
			public const string RecordCreatedOn = "overriddencreatedon";

			/// <summary>ownerid</summary>
			public const string Owner = "ownerid";

			/// <summary>owneridtype</summary>
			public const string Owneridtype = "owneridtype";

			/// <summary>owningbusinessunit</summary>
			public const string OwningBusinessUnit = "owningbusinessunit";

			/// <summary>owninguser</summary>
			public const string OwningUser = "owninguser";

			/// <summary>priority</summary>
			public const string Priority = "priority";

			/// <summary>queueid</summary>
			public const string Queue = "queueid";

			/// <summary>queueidname</summary>
			public const string Queueidname = "queueidname";

			/// <summary>queueitemid</summary>
			public const string QueueItemId = "queueitemid";

			/// <summary>sender</summary>
			public const string From = "sender";

			/// <summary>state</summary>
			public const string Statusdeprecated = "state";

			/// <summary>statecode</summary>
			public const string Status = "statecode";

			/// <summary>status</summary>
			public const string StatusReasondeprecated = "status";

			/// <summary>statuscode</summary>
			public const string StatusReason = "statuscode";

			/// <summary>timezoneruleversionnumber</summary>
			public const string TimeZoneRuleVersionNumber = "timezoneruleversionnumber";

			/// <summary>title</summary>
			public const string Title = "title";

			/// <summary>torecipients</summary>
			public const string To = "torecipients";

			/// <summary>transactioncurrencyid</summary>
			public const string Currency = "transactioncurrencyid";

			/// <summary>transactioncurrencyidname</summary>
			public const string Transactioncurrencyidname = "transactioncurrencyidname";

			/// <summary>utcconversiontimezonecode</summary>
			public const string UTCConversionTimeZoneCode = "utcconversiontimezonecode";

			/// <summary>versionnumber</summary>
			public const string VersionNumber = "versionnumber";

			/// <summary>workerid</summary>
			public const string WorkedBy = "workerid";

			/// <summary>workeridmodifiedon</summary>
			public const string WorkedOn = "workeridmodifiedon";

			/// <summary>workeridname</summary>
			public const string Workeridname = "workeridname";

			/// <summary>workeridtype</summary>
			public const string WorkerType = "workeridtype";

			/// <summary>workeridyominame</summary>
			public const string Workeridyominame = "workeridyominame";

		}
		#endregion

		#region Schemas
		public static class Schemas 
		{
			/// <summary>1:N QueueItem_AsyncOperations</summary>
			public const string QueueItemAsyncOperations = "QueueItem_AsyncOperations";

			/// <summary>1:N QueueItem_BulkDeleteFailures</summary>
			public const string QueueItemBulkDeleteFailures = "QueueItem_BulkDeleteFailures";

			/// <summary>1:N queueitem_principalobjectattributeaccess</summary>
			public const string QueueitemPrincipalobjectattributeaccess = "queueitem_principalobjectattributeaccess";

			/// <summary>1:N QueueItem_ProcessSessions</summary>
			public const string QueueItemProcessSessions = "QueueItem_ProcessSessions";

			/// <summary>1:N QueueItem_SyncErrors</summary>
			public const string QueueItemSyncErrors = "QueueItem_SyncErrors";

		}
		#endregion
	}
}

