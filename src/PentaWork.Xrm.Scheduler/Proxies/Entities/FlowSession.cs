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
	[EntityLogicalName("flowsession")]
	public sealed class FlowSession : Entity
	{	
		public static readonly int? EntityTypeCode = 4720;
		public new const string LogicalName = "flowsession";
		public const string PrimaryIdAttribute = "flowsessionid";
		public const string PrimaryNameAttribute = "name";
	
		public FlowSession() : base("flowsession") { }

		#region Attributes
		/// <summary>
        /// additionalcontext_name
        /// </summary>
		[DisplayName("additionalcontext_name")]
		[AttributeLogicalName("additionalcontext_name")]
		public string AdditionalcontextName
		{	
			get { return GetAttributeValue<string>("additionalcontext_name"); }
			set
			{ 
				if(value == AdditionalcontextName) return;
				SetAttributeValue("additionalcontext_name", value);
			}
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
        /// context
        /// </summary>
		[DisplayName("Context")]
		[AttributeLogicalName("context")]
		public string Context
		{	
			get { return GetAttributeValue<string>("context"); }
			set
			{ 
				if(value == Context) return;
				SetAttributeValue("context", value);
			}
		}	
			
		/// <summary>
        /// correlationid
        /// </summary>
		[DisplayName("CorrelationId")]
		[AttributeLogicalName("correlationid")]
		public string CorrelationId
		{	
			get { return GetAttributeValue<string>("correlationid"); }
			set
			{ 
				if(value == CorrelationId) return;
				SetAttributeValue("correlationid", value);
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
        /// errorcode
        /// </summary>
		[DisplayName("ErrorCode")]
		[AttributeLogicalName("errorcode")]
		public string ErrorCode
		{	
			get { return GetAttributeValue<string>("errorcode"); }
			set
			{ 
				if(value == ErrorCode) return;
				SetAttributeValue("errorcode", value);
			}
		}	
			
		/// <summary>
        /// errormessage
        /// </summary>
		[DisplayName("ErrorMessage")]
		[AttributeLogicalName("errormessage")]
		public string ErrorMessage
		{	
			get { return GetAttributeValue<string>("errormessage"); }
			set
			{ 
				if(value == ErrorMessage) return;
				SetAttributeValue("errormessage", value);
			}
		}	
			
		/// <summary>
        /// flowsessionid
        /// </summary>
		[DisplayName("FlowSession")]
		[AttributeLogicalName("flowsessionid")]
		public override Guid Id
		{
			get => base.Id;
			set { base.Id = value; SetAttributeValue("flowsessionid", value); }
		}

							/// <summary>
        /// gateway
        /// </summary>
		[DisplayName("Gateway")]
		[AttributeLogicalName("gateway")]
		public string Gateway
		{	
			get { return GetAttributeValue<string>("gateway"); }
			set
			{ 
				if(value == Gateway) return;
				SetAttributeValue("gateway", value);
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
        /// outputs_name
        /// </summary>
		[DisplayName("outputs_name")]
		[AttributeLogicalName("outputs_name")]
		public string OutputsName
		{	
			get { return GetAttributeValue<string>("outputs_name"); }
			set
			{ 
				if(value == OutputsName) return;
				SetAttributeValue("outputs_name", value);
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
        /// processversion
        /// </summary>
		[DisplayName("Process Version")]
		[AttributeLogicalName("processversion")]
		public string ProcessVersion
		{	
			get { return GetAttributeValue<string>("processversion"); }
			set
			{ 
				if(value == ProcessVersion) return;
				SetAttributeValue("processversion", value);
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
        /// startedon
        /// </summary>
		[DisplayName("Started On")]
		[AttributeLogicalName("startedon")]
		public DateTime? StartedOn
		{	
			get { return GetAttributeValue<DateTime?>("startedon"); }
			set
			{ 
				if(value == StartedOn) return;
				SetAttributeValue("startedon", value);
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
        /// 1:N Get entities for 'flowsession_AsyncOperations'
        /// </summary>
		[RelationshipSchemaName("flowsession_AsyncOperations")]
		public IEnumerable<SystemJob> FlowsessionAsyncOperations
		{
			get { return GetRelatedEntities<SystemJob>("flowsession_AsyncOperations", null); }
			set { SetRelatedEntities("flowsession_AsyncOperations", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'flowsession_BulkDeleteFailures'
        /// </summary>
		[RelationshipSchemaName("flowsession_BulkDeleteFailures")]
		public IEnumerable<BulkDeleteFailure> FlowsessionBulkDeleteFailures
		{
			get { return GetRelatedEntities<BulkDeleteFailure>("flowsession_BulkDeleteFailures", null); }
			set { SetRelatedEntities("flowsession_BulkDeleteFailures", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'flowsession_FileAttachments'
        /// </summary>
		[RelationshipSchemaName("flowsession_FileAttachments")]
		public IEnumerable<FileAttachment> FlowsessionFileAttachments
		{
			get { return GetRelatedEntities<FileAttachment>("flowsession_FileAttachments", null); }
			set { SetRelatedEntities("flowsession_FileAttachments", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'flowsession_MailboxTrackingFolders'
        /// </summary>
		[RelationshipSchemaName("flowsession_MailboxTrackingFolders")]
		public IEnumerable<MailboxAutoTrackingFolder> FlowsessionMailboxTrackingFolders
		{
			get { return GetRelatedEntities<MailboxAutoTrackingFolder>("flowsession_MailboxTrackingFolders", null); }
			set { SetRelatedEntities("flowsession_MailboxTrackingFolders", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'flowsession_PrincipalObjectAttributeAccesses'
        /// </summary>
		[RelationshipSchemaName("flowsession_PrincipalObjectAttributeAccesses")]
		public IEnumerable<FieldSharing> FlowsessionPrincipalObjectAttributeAccesses
		{
			get { return GetRelatedEntities<FieldSharing>("flowsession_PrincipalObjectAttributeAccesses", null); }
			set { SetRelatedEntities("flowsession_PrincipalObjectAttributeAccesses", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'flowsession_SyncErrors'
        /// </summary>
		[RelationshipSchemaName("flowsession_SyncErrors")]
		public IEnumerable<SyncError> FlowsessionSyncErrors
		{
			get { return GetRelatedEntities<SyncError>("flowsession_SyncErrors", null); }
			set { SetRelatedEntities("flowsession_SyncErrors", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'flowsession_workflowbinary_FlowSessionId'
        /// </summary>
		[RelationshipSchemaName("flowsession_workflowbinary_FlowSessionId")]
		public IEnumerable<WorkflowBinary> FlowsessionWorkflowbinaryFlowSessionId
		{
			get { return GetRelatedEntities<WorkflowBinary>("flowsession_workflowbinary_FlowSessionId", null); }
			set { SetRelatedEntities("flowsession_workflowbinary_FlowSessionId", null, value); }
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
		
			[Label("NotSpecified")]
			[Description(@"")]
			NotSpecified_Inactive = 0, 
		
			[Label("Paused")]
			[Description(@"")]
			Paused_Active = 1, 
		
			[Label("Running")]
			[Description(@"")]
			Running_Active = 2, 
		
			[Label("Waiting")]
			[Description(@"")]
			Waiting_Active = 3, 
		
			[Label("Succeeded")]
			[Description(@"")]
			Succeeded_Active = 4, 
		
			[Label("Skipped")]
			[Description(@"")]
			Skipped_Active = 5, 
		
			[Label("Suspended")]
			[Description(@"")]
			Suspended_Active = 6, 
		
			[Label("Cancelled")]
			[Description(@"")]
			Cancelled_Active = 7, 
		
			[Label("Failed")]
			[Description(@"")]
			Failed_Active = 8, 
		
			[Label("Faulted")]
			[Description(@"")]
			Faulted_Active = 9, 
		
			[Label("TimedOut")]
			[Description(@"")]
			TimedOut_Active = 10, 
		
			[Label("Aborted")]
			[Description(@"")]
			Aborted_Active = 11, 
		
			[Label("Ignored")]
			[Description(@"")]
			Ignored_Active = 12, 
		
			[Label("Deleted")]
			[Description(@"")]
			Deleted_Inactive = 13, 
		
			[Label("Terminated")]
			[Description(@"")]
			Terminated_Inactive = 14, 
		}
		
		#endregion	

		#region Properties
		public static class Properties 
		{
			/// <summary>additionalcontext_name</summary>
			public const string AdditionalcontextName = "additionalcontext_name";

			/// <summary>completedon</summary>
			public const string CompletedOn = "completedon";

			/// <summary>context</summary>
			public const string Context = "context";

			/// <summary>correlationid</summary>
			public const string CorrelationId = "correlationid";

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

			/// <summary>errorcode</summary>
			public const string ErrorCode = "errorcode";

			/// <summary>errormessage</summary>
			public const string ErrorMessage = "errormessage";

			/// <summary>flowsessionid</summary>
			public const string FlowSessionId = "flowsessionid";

			/// <summary>gateway</summary>
			public const string Gateway = "gateway";

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

			/// <summary>outputs_name</summary>
			public const string OutputsName = "outputs_name";

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

			/// <summary>processversion</summary>
			public const string ProcessVersion = "processversion";

			/// <summary>regardingobjectid</summary>
			public const string Regarding = "regardingobjectid";

			/// <summary>regardingobjectidname</summary>
			public const string Regardingobjectidname = "regardingobjectidname";

			/// <summary>regardingobjectidyominame</summary>
			public const string Regardingobjectidyominame = "regardingobjectidyominame";

			/// <summary>regardingobjecttypecode</summary>
			public const string Regardingobjecttypecode = "regardingobjecttypecode";

			/// <summary>startedon</summary>
			public const string StartedOn = "startedon";

			/// <summary>statecode</summary>
			public const string Status = "statecode";

			/// <summary>statuscode</summary>
			public const string StatusReason = "statuscode";

			/// <summary>timezoneruleversionnumber</summary>
			public const string TimeZoneRuleVersionNumber = "timezoneruleversionnumber";

			/// <summary>utcconversiontimezonecode</summary>
			public const string UTCConversionTimeZoneCode = "utcconversiontimezonecode";

			/// <summary>versionnumber</summary>
			public const string VersionNumber = "versionnumber";

		}
		#endregion

		#region Schemas
		public static class Schemas 
		{
			/// <summary>1:N flowsession_AsyncOperations</summary>
			public const string FlowsessionAsyncOperations = "flowsession_AsyncOperations";

			/// <summary>1:N flowsession_BulkDeleteFailures</summary>
			public const string FlowsessionBulkDeleteFailures = "flowsession_BulkDeleteFailures";

			/// <summary>1:N flowsession_FileAttachments</summary>
			public const string FlowsessionFileAttachments = "flowsession_FileAttachments";

			/// <summary>1:N flowsession_MailboxTrackingFolders</summary>
			public const string FlowsessionMailboxTrackingFolders = "flowsession_MailboxTrackingFolders";

			/// <summary>1:N flowsession_PrincipalObjectAttributeAccesses</summary>
			public const string FlowsessionPrincipalObjectAttributeAccesses = "flowsession_PrincipalObjectAttributeAccesses";

			/// <summary>1:N flowsession_SyncErrors</summary>
			public const string FlowsessionSyncErrors = "flowsession_SyncErrors";

			/// <summary>1:N flowsession_workflowbinary_FlowSessionId</summary>
			public const string FlowsessionWorkflowbinaryFlowSessionId = "flowsession_workflowbinary_FlowSessionId";

		}
		#endregion
	}
}

