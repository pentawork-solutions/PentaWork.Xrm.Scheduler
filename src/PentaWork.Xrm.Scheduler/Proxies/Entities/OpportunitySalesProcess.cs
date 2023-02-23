using System;
using System.Linq;
using System.Diagnostics;
using System.ComponentModel;
using Microsoft.Xrm.Sdk; 
using Microsoft.Xrm.Sdk.Client;
using System.Collections.Generic;

namespace PentaWork.Xrm.Scheduler.Proxies.Entities
{
	[DebuggerDisplay("{ProcessName}")] 	
	[EntityLogicalName("opportunitysalesprocess")]
	public sealed class OpportunitySalesProcess : Entity
	{	
		public static readonly int? EntityTypeCode = 953;
		public new const string LogicalName = "opportunitysalesprocess";
		public const string PrimaryIdAttribute = "businessprocessflowinstanceid";
		public const string PrimaryNameAttribute = "name";
	
		public OpportunitySalesProcess() : base("opportunitysalesprocess") { }

		#region Attributes
		/// <summary>
        /// activestageid
        /// </summary>
		[DisplayName("Active Stage")]
		[AttributeLogicalName("activestageid")]
		public EntityReference ActiveStage
		{	
			get { return GetAttributeValue<EntityReference>("activestageid"); }
			set
			{ 
				if(value == ActiveStage) return;
				SetAttributeValue("activestageid", value);
			}
		}	
			
		/// <summary>
        /// activestageidname
        /// </summary>
		[DisplayName("activestageidname")]
		[AttributeLogicalName("activestageidname")]
		public string Activestageidname
		{	
			get { return GetAttributeValue<string>("activestageidname"); }
			set
			{ 
				if(value == Activestageidname) return;
				SetAttributeValue("activestageidname", value);
			}
		}	
			
		/// <summary>
        /// activestagestartedon
        /// </summary>
		[DisplayName("Active Stage Started On")]
		[AttributeLogicalName("activestagestartedon")]
		public DateTime? ActiveStageStartedOn
		{	
			get { return GetAttributeValue<DateTime?>("activestagestartedon"); }
			set
			{ 
				if(value == ActiveStageStartedOn) return;
				SetAttributeValue("activestagestartedon", value);
			}
		}	
			
		/// <summary>
        /// businessprocessflowinstanceid
        /// </summary>
		[DisplayName("Opportunity Sales Process Instance Id")]
		[AttributeLogicalName("businessprocessflowinstanceid")]
		public override Guid Id
		{
			get => base.Id;
			set { base.Id = value; SetAttributeValue("businessprocessflowinstanceid", value); }
		}

							/// <summary>
        /// completedon
        /// </summary>
		[DisplayName("Completed On")]
		[AttributeLogicalName("completedon")]
		public DateTime? CompletedOn
		{	
			get { return GetAttributeValue<DateTime?>("completedon"); }
			set
			{ 
				if(value == CompletedOn) return;
				SetAttributeValue("completedon", value);
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
        /// duration
        /// </summary>
		[DisplayName("Duration")]
		[AttributeLogicalName("duration")]
		public int? Duration
		{	
			get { return GetAttributeValue<int?>("duration"); }
			set
			{ 
				if(value == Duration) return;
				SetAttributeValue("duration", value);
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
		[DisplayName("Process Name")]
		[AttributeLogicalName("name")]
		public string ProcessName
		{	
			get { return GetAttributeValue<string>("name"); }
			set
			{ 
				if(value == ProcessName) return;
				SetAttributeValue("name", value);
			}
		}	
			
		/// <summary>
        /// opportunityid
        /// </summary>
		[DisplayName("Opportunity")]
		[AttributeLogicalName("opportunityid")]
		public EntityReference Opportunity
		{	
			get { return GetAttributeValue<EntityReference>("opportunityid"); }
			set
			{ 
				if(value == Opportunity) return;
				SetAttributeValue("opportunityid", value);
			}
		}	
			
		/// <summary>
        /// opportunityidname
        /// </summary>
		[DisplayName("opportunityidname")]
		[AttributeLogicalName("opportunityidname")]
		public string Opportunityidname
		{	
			get { return GetAttributeValue<string>("opportunityidname"); }
			set
			{ 
				if(value == Opportunityidname) return;
				SetAttributeValue("opportunityidname", value);
			}
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
        /// processid
        /// </summary>
		[DisplayName("Process")]
		[AttributeLogicalName("processid")]
		public EntityReference Process
		{	
			get { return GetAttributeValue<EntityReference>("processid"); }
			set
			{ 
				if(value == Process) return;
				SetAttributeValue("processid", value);
			}
		}	
			
		/// <summary>
        /// processidname
        /// </summary>
		[DisplayName("processidname")]
		[AttributeLogicalName("processidname")]
		public string Processidname
		{	
			get { return GetAttributeValue<string>("processidname"); }
			set
			{ 
				if(value == Processidname) return;
				SetAttributeValue("processidname", value);
			}
		}	
			
		/// <summary>
        /// quoteid
        /// </summary>
		[DisplayName("Related Quote")]
		[AttributeLogicalName("quoteid")]
		public EntityReference RelatedQuote
		{	
			get { return GetAttributeValue<EntityReference>("quoteid"); }
			set
			{ 
				if(value == RelatedQuote) return;
				SetAttributeValue("quoteid", value);
			}
		}	
			
		/// <summary>
        /// quoteidname
        /// </summary>
		[DisplayName("quoteidname")]
		[AttributeLogicalName("quoteidname")]
		public string Quoteidname
		{	
			get { return GetAttributeValue<string>("quoteidname"); }
			set
			{ 
				if(value == Quoteidname) return;
				SetAttributeValue("quoteidname", value);
			}
		}	
			
		/// <summary>
        /// salesorderid
        /// </summary>
		[DisplayName("Related Sales Order")]
		[AttributeLogicalName("salesorderid")]
		public EntityReference RelatedSalesOrder
		{	
			get { return GetAttributeValue<EntityReference>("salesorderid"); }
			set
			{ 
				if(value == RelatedSalesOrder) return;
				SetAttributeValue("salesorderid", value);
			}
		}	
			
		/// <summary>
        /// salesorderidname
        /// </summary>
		[DisplayName("salesorderidname")]
		[AttributeLogicalName("salesorderidname")]
		public string Salesorderidname
		{	
			get { return GetAttributeValue<string>("salesorderidname"); }
			set
			{ 
				if(value == Salesorderidname) return;
				SetAttributeValue("salesorderidname", value);
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
		[DisplayName("Traversed Path")]
		[AttributeLogicalName("traversedpath")]
		public string TraversedPath
		{	
			get { return GetAttributeValue<string>("traversedpath"); }
			set
			{ 
				if(value == TraversedPath) return;
				SetAttributeValue("traversedpath", value);
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
        /// 1:N Get entities for 'lk_opportunitysalesprocess_workflowlogs'
        /// </summary>
		[RelationshipSchemaName("lk_opportunitysalesprocess_workflowlogs")]
		public IEnumerable<ProcessLog> LkOpportunitysalesprocessWorkflowlogs
		{
			get { return GetRelatedEntities<ProcessLog>("lk_opportunitysalesprocess_workflowlogs", null); }
			set { SetRelatedEntities("lk_opportunitysalesprocess_workflowlogs", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'opportunitysalesprocess_AsyncOperations'
        /// </summary>
		[RelationshipSchemaName("opportunitysalesprocess_AsyncOperations")]
		public IEnumerable<SystemJob> OpportunitysalesprocessAsyncOperations
		{
			get { return GetRelatedEntities<SystemJob>("opportunitysalesprocess_AsyncOperations", null); }
			set { SetRelatedEntities("opportunitysalesprocess_AsyncOperations", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'opportunitysalesprocess_BulkDeleteFailures'
        /// </summary>
		[RelationshipSchemaName("opportunitysalesprocess_BulkDeleteFailures")]
		public IEnumerable<BulkDeleteFailure> OpportunitysalesprocessBulkDeleteFailures
		{
			get { return GetRelatedEntities<BulkDeleteFailure>("opportunitysalesprocess_BulkDeleteFailures", null); }
			set { SetRelatedEntities("opportunitysalesprocess_BulkDeleteFailures", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'opportunitysalesprocess_MailboxTrackingFolders'
        /// </summary>
		[RelationshipSchemaName("opportunitysalesprocess_MailboxTrackingFolders")]
		public IEnumerable<MailboxAutoTrackingFolder> OpportunitysalesprocessMailboxTrackingFolders
		{
			get { return GetRelatedEntities<MailboxAutoTrackingFolder>("opportunitysalesprocess_MailboxTrackingFolders", null); }
			set { SetRelatedEntities("opportunitysalesprocess_MailboxTrackingFolders", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'opportunitysalesprocess_PrincipalObjectAttributeAccesses'
        /// </summary>
		[RelationshipSchemaName("opportunitysalesprocess_PrincipalObjectAttributeAccesses")]
		public IEnumerable<FieldSharing> OpportunitysalesprocessPrincipalObjectAttributeAccesses
		{
			get { return GetRelatedEntities<FieldSharing>("opportunitysalesprocess_PrincipalObjectAttributeAccesses", null); }
			set { SetRelatedEntities("opportunitysalesprocess_PrincipalObjectAttributeAccesses", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'opportunitysalesprocess_ProcessSession'
        /// </summary>
		[RelationshipSchemaName("opportunitysalesprocess_ProcessSession")]
		public IEnumerable<ProcessSession> OpportunitysalesprocessProcessSession
		{
			get { return GetRelatedEntities<ProcessSession>("opportunitysalesprocess_ProcessSession", null); }
			set { SetRelatedEntities("opportunitysalesprocess_ProcessSession", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'OpportunitySalesProcess_SyncErrors'
        /// </summary>
		[RelationshipSchemaName("OpportunitySalesProcess_SyncErrors")]
		public IEnumerable<SyncError> OpportunitySalesProcessSyncErrors
		{
			get { return GetRelatedEntities<SyncError>("OpportunitySalesProcess_SyncErrors", null); }
			set { SetRelatedEntities("OpportunitySalesProcess_SyncErrors", null, value); }
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
		
		public enum eStatusReason
		{	
		
			[Label("Active")]
			[Description(@"")]
			Active_Active = 1, 
		
			[Label("Finished")]
			[Description(@"")]
			Finished_Inactive = 2, 
		
			[Label("Aborted")]
			[Description(@"")]
			Aborted_Inactive = 3, 
		}
		
		#endregion	

		#region Properties
		public static class Properties 
		{
			/// <summary>activestageid</summary>
			public const string ActiveStage = "activestageid";

			/// <summary>activestageidname</summary>
			public const string Activestageidname = "activestageidname";

			/// <summary>activestagestartedon</summary>
			public const string ActiveStageStartedOn = "activestagestartedon";

			/// <summary>businessprocessflowinstanceid</summary>
			public const string OpportunitySalesProcessInstanceId = "businessprocessflowinstanceid";

			/// <summary>completedon</summary>
			public const string CompletedOn = "completedon";

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

			/// <summary>duration</summary>
			public const string Duration = "duration";

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
			public const string ProcessName = "name";

			/// <summary>opportunityid</summary>
			public const string Opportunity = "opportunityid";

			/// <summary>opportunityidname</summary>
			public const string Opportunityidname = "opportunityidname";

			/// <summary>organizationid</summary>
			public const string OrganizationId = "organizationid";

			/// <summary>organizationidname</summary>
			public const string Organizationidname = "organizationidname";

			/// <summary>overriddencreatedon</summary>
			public const string RecordCreatedOn = "overriddencreatedon";

			/// <summary>processid</summary>
			public const string Process = "processid";

			/// <summary>processidname</summary>
			public const string Processidname = "processidname";

			/// <summary>quoteid</summary>
			public const string RelatedQuote = "quoteid";

			/// <summary>quoteidname</summary>
			public const string Quoteidname = "quoteidname";

			/// <summary>salesorderid</summary>
			public const string RelatedSalesOrder = "salesorderid";

			/// <summary>salesorderidname</summary>
			public const string Salesorderidname = "salesorderidname";

			/// <summary>statecode</summary>
			public const string Status = "statecode";

			/// <summary>statuscode</summary>
			public const string StatusReason = "statuscode";

			/// <summary>timezoneruleversionnumber</summary>
			public const string TimeZoneRuleVersionNumber = "timezoneruleversionnumber";

			/// <summary>transactioncurrencyid</summary>
			public const string Currency = "transactioncurrencyid";

			/// <summary>transactioncurrencyidname</summary>
			public const string Transactioncurrencyidname = "transactioncurrencyidname";

			/// <summary>traversedpath</summary>
			public const string TraversedPath = "traversedpath";

			/// <summary>utcconversiontimezonecode</summary>
			public const string UTCConversionTimeZoneCode = "utcconversiontimezonecode";

			/// <summary>versionnumber</summary>
			public const string VersionNumber = "versionnumber";

		}
		#endregion

		#region Schemas
		public static class Schemas 
		{
			/// <summary>1:N lk_opportunitysalesprocess_workflowlogs</summary>
			public const string LkOpportunitysalesprocessWorkflowlogs = "lk_opportunitysalesprocess_workflowlogs";

			/// <summary>1:N opportunitysalesprocess_AsyncOperations</summary>
			public const string OpportunitysalesprocessAsyncOperations = "opportunitysalesprocess_AsyncOperations";

			/// <summary>1:N opportunitysalesprocess_BulkDeleteFailures</summary>
			public const string OpportunitysalesprocessBulkDeleteFailures = "opportunitysalesprocess_BulkDeleteFailures";

			/// <summary>1:N opportunitysalesprocess_MailboxTrackingFolders</summary>
			public const string OpportunitysalesprocessMailboxTrackingFolders = "opportunitysalesprocess_MailboxTrackingFolders";

			/// <summary>1:N opportunitysalesprocess_PrincipalObjectAttributeAccesses</summary>
			public const string OpportunitysalesprocessPrincipalObjectAttributeAccesses = "opportunitysalesprocess_PrincipalObjectAttributeAccesses";

			/// <summary>1:N opportunitysalesprocess_ProcessSession</summary>
			public const string OpportunitysalesprocessProcessSession = "opportunitysalesprocess_ProcessSession";

			/// <summary>1:N OpportunitySalesProcess_SyncErrors</summary>
			public const string OpportunitySalesProcessSyncErrors = "OpportunitySalesProcess_SyncErrors";

		}
		#endregion
	}
}

