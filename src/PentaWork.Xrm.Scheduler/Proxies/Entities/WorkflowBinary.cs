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
	[EntityLogicalName("workflowbinary")]
	public sealed class WorkflowBinary : Entity
	{	
		public static readonly int? EntityTypeCode = 10029;
		public new const string LogicalName = "workflowbinary";
		public const string PrimaryIdAttribute = "workflowbinaryid";
		public const string PrimaryNameAttribute = "name";
	
		public WorkflowBinary() : base("workflowbinary") { }

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
        /// data_name
        /// </summary>
		[DisplayName("data_name")]
		[AttributeLogicalName("data_name")]
		public string DataName
		{	
			get { return GetAttributeValue<string>("data_name"); }
			set
			{ 
				if(value == DataName) return;
				SetAttributeValue("data_name", value);
			}
		}	
			
		/// <summary>
        /// flowsessionid
        /// </summary>
		[DisplayName("Flow Session Id")]
		[AttributeLogicalName("flowsessionid")]
		public EntityReference FlowSessionId
		{	
			get { return GetAttributeValue<EntityReference>("flowsessionid"); }
			set
			{ 
				if(value == FlowSessionId) return;
				SetAttributeValue("flowsessionid", value);
			}
		}	
			
		/// <summary>
        /// flowsessionidname
        /// </summary>
		[DisplayName("flowsessionidname")]
		[AttributeLogicalName("flowsessionidname")]
		public string Flowsessionidname
		{	
			get { return GetAttributeValue<string>("flowsessionidname"); }
			set
			{ 
				if(value == Flowsessionidname) return;
				SetAttributeValue("flowsessionidname", value);
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
        /// metadata
        /// </summary>
		[DisplayName("Metadata")]
		[AttributeLogicalName("metadata")]
		public string Metadata
		{	
			get { return GetAttributeValue<string>("metadata"); }
			set
			{ 
				if(value == Metadata) return;
				SetAttributeValue("metadata", value);
			}
		}	
			
		/// <summary>
        /// mimetype
        /// </summary>
		[DisplayName("MimeType")]
		[AttributeLogicalName("mimetype")]
		public string MimeType
		{	
			get { return GetAttributeValue<string>("mimetype"); }
			set
			{ 
				if(value == MimeType) return;
				SetAttributeValue("mimetype", value);
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
        /// process
        /// </summary>
		[DisplayName("Process Id")]
		[AttributeLogicalName("process")]
		public EntityReference ProcessId
		{	
			get { return GetAttributeValue<EntityReference>("process"); }
			set
			{ 
				if(value == ProcessId) return;
				SetAttributeValue("process", value);
			}
		}	
			
		/// <summary>
        /// processname
        /// </summary>
		[DisplayName("processname")]
		[AttributeLogicalName("processname")]
		public string Processname
		{	
			get { return GetAttributeValue<string>("processname"); }
			set
			{ 
				if(value == Processname) return;
				SetAttributeValue("processname", value);
			}
		}	
			
		/// <summary>
        /// referencename
        /// </summary>
		[DisplayName("Reference Name")]
		[AttributeLogicalName("referencename")]
		public string ReferenceName
		{	
			get { return GetAttributeValue<string>("referencename"); }
			set
			{ 
				if(value == ReferenceName) return;
				SetAttributeValue("referencename", value);
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
        /// type
        /// </summary>
		[DisplayName("Type")]
		[AttributeLogicalName("type")]
		public string Type
		{	
			get { return GetAttributeValue<string>("type"); }
			set
			{ 
				if(value == Type) return;
				SetAttributeValue("type", value);
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
        /// workflowbinaryid
        /// </summary>
		[DisplayName("Workflow Binary")]
		[AttributeLogicalName("workflowbinaryid")]
		public override Guid Id
		{
			get => base.Id;
			set { base.Id = value; SetAttributeValue("workflowbinaryid", value); }
		}

							#endregion	

		#region Relations
			/// <summary>
        /// 1:N Get entities for 'workflowbinary_AsyncOperations'
        /// </summary>
		[RelationshipSchemaName("workflowbinary_AsyncOperations")]
		public IEnumerable<SystemJob> WorkflowbinaryAsyncOperations
		{
			get { return GetRelatedEntities<SystemJob>("workflowbinary_AsyncOperations", null); }
			set { SetRelatedEntities("workflowbinary_AsyncOperations", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'workflowbinary_BulkDeleteFailures'
        /// </summary>
		[RelationshipSchemaName("workflowbinary_BulkDeleteFailures")]
		public IEnumerable<BulkDeleteFailure> WorkflowbinaryBulkDeleteFailures
		{
			get { return GetRelatedEntities<BulkDeleteFailure>("workflowbinary_BulkDeleteFailures", null); }
			set { SetRelatedEntities("workflowbinary_BulkDeleteFailures", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'workflowbinary_FileAttachments'
        /// </summary>
		[RelationshipSchemaName("workflowbinary_FileAttachments")]
		public IEnumerable<FileAttachment> WorkflowbinaryFileAttachments
		{
			get { return GetRelatedEntities<FileAttachment>("workflowbinary_FileAttachments", null); }
			set { SetRelatedEntities("workflowbinary_FileAttachments", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'workflowbinary_MailboxTrackingFolders'
        /// </summary>
		[RelationshipSchemaName("workflowbinary_MailboxTrackingFolders")]
		public IEnumerable<MailboxAutoTrackingFolder> WorkflowbinaryMailboxTrackingFolders
		{
			get { return GetRelatedEntities<MailboxAutoTrackingFolder>("workflowbinary_MailboxTrackingFolders", null); }
			set { SetRelatedEntities("workflowbinary_MailboxTrackingFolders", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'workflowbinary_PrincipalObjectAttributeAccesses'
        /// </summary>
		[RelationshipSchemaName("workflowbinary_PrincipalObjectAttributeAccesses")]
		public IEnumerable<FieldSharing> WorkflowbinaryPrincipalObjectAttributeAccesses
		{
			get { return GetRelatedEntities<FieldSharing>("workflowbinary_PrincipalObjectAttributeAccesses", null); }
			set { SetRelatedEntities("workflowbinary_PrincipalObjectAttributeAccesses", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'workflowbinary_ProcessSession'
        /// </summary>
		[RelationshipSchemaName("workflowbinary_ProcessSession")]
		public IEnumerable<ProcessSession> WorkflowbinaryProcessSession
		{
			get { return GetRelatedEntities<ProcessSession>("workflowbinary_ProcessSession", null); }
			set { SetRelatedEntities("workflowbinary_ProcessSession", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'workflowbinary_SyncErrors'
        /// </summary>
		[RelationshipSchemaName("workflowbinary_SyncErrors")]
		public IEnumerable<SyncError> WorkflowbinarySyncErrors
		{
			get { return GetRelatedEntities<SyncError>("workflowbinary_SyncErrors", null); }
			set { SetRelatedEntities("workflowbinary_SyncErrors", null, value); }
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
		
			[Label("Inactive")]
			[Description(@"")]
			Inactive_Inactive = 2, 
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

			/// <summary>data_name</summary>
			public const string DataName = "data_name";

			/// <summary>flowsessionid</summary>
			public const string FlowSessionId = "flowsessionid";

			/// <summary>flowsessionidname</summary>
			public const string Flowsessionidname = "flowsessionidname";

			/// <summary>importsequencenumber</summary>
			public const string ImportSequenceNumber = "importsequencenumber";

			/// <summary>metadata</summary>
			public const string Metadata = "metadata";

			/// <summary>mimetype</summary>
			public const string MimeType = "mimetype";

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

			/// <summary>process</summary>
			public const string ProcessId = "process";

			/// <summary>processname</summary>
			public const string Processname = "processname";

			/// <summary>referencename</summary>
			public const string ReferenceName = "referencename";

			/// <summary>statecode</summary>
			public const string Status = "statecode";

			/// <summary>statuscode</summary>
			public const string StatusReason = "statuscode";

			/// <summary>timezoneruleversionnumber</summary>
			public const string TimeZoneRuleVersionNumber = "timezoneruleversionnumber";

			/// <summary>type</summary>
			public const string Type = "type";

			/// <summary>utcconversiontimezonecode</summary>
			public const string UTCConversionTimeZoneCode = "utcconversiontimezonecode";

			/// <summary>versionnumber</summary>
			public const string VersionNumber = "versionnumber";

			/// <summary>workflowbinaryid</summary>
			public const string WorkflowBinaryId = "workflowbinaryid";

		}
		#endregion

		#region Schemas
		public static class Schemas 
		{
			/// <summary>1:N workflowbinary_AsyncOperations</summary>
			public const string WorkflowbinaryAsyncOperations = "workflowbinary_AsyncOperations";

			/// <summary>1:N workflowbinary_BulkDeleteFailures</summary>
			public const string WorkflowbinaryBulkDeleteFailures = "workflowbinary_BulkDeleteFailures";

			/// <summary>1:N workflowbinary_FileAttachments</summary>
			public const string WorkflowbinaryFileAttachments = "workflowbinary_FileAttachments";

			/// <summary>1:N workflowbinary_MailboxTrackingFolders</summary>
			public const string WorkflowbinaryMailboxTrackingFolders = "workflowbinary_MailboxTrackingFolders";

			/// <summary>1:N workflowbinary_PrincipalObjectAttributeAccesses</summary>
			public const string WorkflowbinaryPrincipalObjectAttributeAccesses = "workflowbinary_PrincipalObjectAttributeAccesses";

			/// <summary>1:N workflowbinary_ProcessSession</summary>
			public const string WorkflowbinaryProcessSession = "workflowbinary_ProcessSession";

			/// <summary>1:N workflowbinary_SyncErrors</summary>
			public const string WorkflowbinarySyncErrors = "workflowbinary_SyncErrors";

		}
		#endregion
	}
}

