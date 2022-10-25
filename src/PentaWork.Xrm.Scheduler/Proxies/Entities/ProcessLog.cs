using System;
using System.Linq;
using System.Diagnostics;
using System.ComponentModel;
using Microsoft.Xrm.Sdk; 
using Microsoft.Xrm.Sdk.Client;
using System.Collections.Generic;

namespace PentaWork.Xrm.Scheduler.Proxies.Entities
{
	
	[EntityLogicalName("workflowlog")]
	public sealed class ProcessLog : Entity
	{	
		public static readonly int? EntityTypeCode = 4706;
		public new const string LogicalName = "workflowlog";
		public const string PrimaryIdAttribute = "workflowlogid";
		public const string PrimaryNameAttribute = "";
	
		public ProcessLog() : base("workflowlog") { }

		#region Attributes
		/// <summary>
        /// activityname
        /// </summary>
		[DisplayName("Activity Name")]
		[AttributeLogicalName("activityname")]
		public string ActivityName
		{	
			get { return GetAttributeValue<string>("activityname"); }
			set
			{ 
				if(value == ActivityName) return;
				SetAttributeValue("activityname", value);
			}
		}	
			
		/// <summary>
        /// asyncoperationid
        /// </summary>
		[DisplayName("Parent record")]
		[AttributeLogicalName("asyncoperationid")]
		public EntityReference ParentRecord
		{	
			get { return GetAttributeValue<EntityReference>("asyncoperationid"); }
			set
			{ 
				if(value == ParentRecord) return;
				SetAttributeValue("asyncoperationid", value);
			}
		}	
			
		/// <summary>
        /// asyncoperationidname
        /// </summary>
		[DisplayName("Parent record")]
		[AttributeLogicalName("asyncoperationidname")]
		public string ParentRecord2
		{	
			get { return GetAttributeValue<string>("asyncoperationidname"); }
			set
			{ 
				if(value == ParentRecord2) return;
				SetAttributeValue("asyncoperationidname", value);
			}
		}	
			
		/// <summary>
        /// childworkflowinstanceid
        /// </summary>
		[DisplayName("Child Workflow System Job")]
		[AttributeLogicalName("childworkflowinstanceid")]
		public EntityReference ChildWorkflowSystemJob
		{	
			get { return GetAttributeValue<EntityReference>("childworkflowinstanceid"); }
			set
			{ 
				if(value == ChildWorkflowSystemJob) return;
				SetAttributeValue("childworkflowinstanceid", value);
			}
		}	
			
		/// <summary>
        /// childworkflowinstanceidname
        /// </summary>
		[DisplayName("Child Async Operation Name")]
		[AttributeLogicalName("childworkflowinstanceidname")]
		public string ChildAsyncOperationName
		{	
			get { return GetAttributeValue<string>("childworkflowinstanceidname"); }
			set
			{ 
				if(value == ChildAsyncOperationName) return;
				SetAttributeValue("childworkflowinstanceidname", value);
			}
		}	
			
		/// <summary>
        /// childworkflowinstanceobjecttypecode
        /// </summary>
		[DisplayName("Entity")]
		[AttributeLogicalName("childworkflowinstanceobjecttypecode")]
		public string Entity
		{	
			get { return GetAttributeValue<string>("childworkflowinstanceobjecttypecode"); }
			set
			{ 
				if(value == Entity) return;
				SetAttributeValue("childworkflowinstanceobjecttypecode", value);
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
		[DisplayName("Created By Name")]
		[AttributeLogicalName("createdbyname")]
		public string CreatedByName
		{	
			get { return GetAttributeValue<string>("createdbyname"); }
			set
			{ 
				if(value == CreatedByName) return;
				SetAttributeValue("createdbyname", value);
			}
		}	
			
		/// <summary>
        /// createdbyyominame
        /// </summary>
		[DisplayName("Created By Yomi Name")]
		[AttributeLogicalName("createdbyyominame")]
		public string CreatedByYomiName
		{	
			get { return GetAttributeValue<string>("createdbyyominame"); }
			set
			{ 
				if(value == CreatedByYomiName) return;
				SetAttributeValue("createdbyyominame", value);
			}
		}	
			
		/// <summary>
        /// createdon
        /// </summary>
		[DisplayName("Started On")]
		[AttributeLogicalName("createdon")]
		public DateTime? StartedOn
		{	
			get { return GetAttributeValue<DateTime?>("createdon"); }
			set
			{ 
				if(value == StartedOn) return;
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
		[DisplayName("Created By(Delegate) Name")]
		[AttributeLogicalName("createdonbehalfbyname")]
		public string CreatedByDelegateName
		{	
			get { return GetAttributeValue<string>("createdonbehalfbyname"); }
			set
			{ 
				if(value == CreatedByDelegateName) return;
				SetAttributeValue("createdonbehalfbyname", value);
			}
		}	
			
		/// <summary>
        /// createdonbehalfbyyominame
        /// </summary>
		[DisplayName("Created By(Delegate) Yomi Name")]
		[AttributeLogicalName("createdonbehalfbyyominame")]
		public string CreatedByDelegateYomiName
		{	
			get { return GetAttributeValue<string>("createdonbehalfbyyominame"); }
			set
			{ 
				if(value == CreatedByDelegateYomiName) return;
				SetAttributeValue("createdonbehalfbyyominame", value);
			}
		}	
			
		/// <summary>
        /// description
        /// </summary>
		[DisplayName("Step Description")]
		[AttributeLogicalName("description")]
		public string StepDescription
		{	
			get { return GetAttributeValue<string>("description"); }
			set
			{ 
				if(value == StepDescription) return;
				SetAttributeValue("description", value);
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
        /// errorcode
        /// </summary>
		[DisplayName("Error Message")]
		[AttributeLogicalName("errorcode")]
		public int? ErrorMessage
		{	
			get { return GetAttributeValue<int?>("errorcode"); }
			set
			{ 
				if(value == ErrorMessage) return;
				SetAttributeValue("errorcode", value);
			}
		}	
			
		/// <summary>
        /// errortext
        /// </summary>
		[DisplayName("ErrorText")]
		[AttributeLogicalName("errortext")]
		public string ErrorText
		{	
			get { return GetAttributeValue<string>("errortext"); }
			set
			{ 
				if(value == ErrorText) return;
				SetAttributeValue("errortext", value);
			}
		}	
			
		/// <summary>
        /// inputs_name
        /// </summary>
		[DisplayName("inputs_name")]
		[AttributeLogicalName("inputs_name")]
		public string InputsName
		{	
			get { return GetAttributeValue<string>("inputs_name"); }
			set
			{ 
				if(value == InputsName) return;
				SetAttributeValue("inputs_name", value);
			}
		}	
			
		/// <summary>
        /// interactionactivityresult
        /// </summary>
		[DisplayName("Interaction Activity Result")]
		[AttributeLogicalName("interactionactivityresult")]
		public string InteractionActivityResult
		{	
			get { return GetAttributeValue<string>("interactionactivityresult"); }
			set
			{ 
				if(value == InteractionActivityResult) return;
				SetAttributeValue("interactionactivityresult", value);
			}
		}	
			
		/// <summary>
        /// iterationcount
        /// </summary>
		[DisplayName("IterationCount")]
		[AttributeLogicalName("iterationcount")]
		public int? IterationCount
		{	
			get { return GetAttributeValue<int?>("iterationcount"); }
			set
			{ 
				if(value == IterationCount) return;
				SetAttributeValue("iterationcount", value);
			}
		}	
			
		/// <summary>
        /// message
        /// </summary>
		[DisplayName("Message")]
		[AttributeLogicalName("message")]
		public string Message
		{	
			get { return GetAttributeValue<string>("message"); }
			set
			{ 
				if(value == Message) return;
				SetAttributeValue("message", value);
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
		[DisplayName("Modified By Name")]
		[AttributeLogicalName("modifiedbyname")]
		public string ModifiedByName
		{	
			get { return GetAttributeValue<string>("modifiedbyname"); }
			set
			{ 
				if(value == ModifiedByName) return;
				SetAttributeValue("modifiedbyname", value);
			}
		}	
			
		/// <summary>
        /// modifiedbyyominame
        /// </summary>
		[DisplayName("Modified By Yomi Name")]
		[AttributeLogicalName("modifiedbyyominame")]
		public string ModifiedByYomiName
		{	
			get { return GetAttributeValue<string>("modifiedbyyominame"); }
			set
			{ 
				if(value == ModifiedByYomiName) return;
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
		[DisplayName("Modified On Behalf By Name")]
		[AttributeLogicalName("modifiedonbehalfbyname")]
		public string ModifiedOnBehalfByName
		{	
			get { return GetAttributeValue<string>("modifiedonbehalfbyname"); }
			set
			{ 
				if(value == ModifiedOnBehalfByName) return;
				SetAttributeValue("modifiedonbehalfbyname", value);
			}
		}	
			
		/// <summary>
        /// modifiedonbehalfbyyominame
        /// </summary>
		[DisplayName("Modified On Behalf By Yomi Name")]
		[AttributeLogicalName("modifiedonbehalfbyyominame")]
		public string ModifiedOnBehalfByYomiName
		{	
			get { return GetAttributeValue<string>("modifiedonbehalfbyyominame"); }
			set
			{ 
				if(value == ModifiedOnBehalfByYomiName) return;
				SetAttributeValue("modifiedonbehalfbyyominame", value);
			}
		}	
			
		/// <summary>
        /// objecttypecode
        /// </summary>
		[DisplayName("Entity")]
		[AttributeLogicalName("objecttypecode")]
		public string Entity2
		{	
			get { return GetAttributeValue<string>("objecttypecode"); }
			set
			{ 
				if(value == Entity2) return;
				SetAttributeValue("objecttypecode", value);
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
		[DisplayName("Owner Id Type")]
		[AttributeLogicalName("owneridtype")]
		public string OwnerIdType
		{	
			get { return GetAttributeValue<string>("owneridtype"); }
			set
			{ 
				if(value == OwnerIdType) return;
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
		[DisplayName("Regarding Object Id Name")]
		[AttributeLogicalName("regardingobjectidname")]
		public string RegardingObjectIdName
		{	
			get { return GetAttributeValue<string>("regardingobjectidname"); }
			set
			{ 
				if(value == RegardingObjectIdName) return;
				SetAttributeValue("regardingobjectidname", value);
			}
		}	
			
		/// <summary>
        /// regardingobjectidyominame
        /// </summary>
		[DisplayName("Regarding Object Id Yomi Name")]
		[AttributeLogicalName("regardingobjectidyominame")]
		public string RegardingObjectIdYomiName
		{	
			get { return GetAttributeValue<string>("regardingobjectidyominame"); }
			set
			{ 
				if(value == RegardingObjectIdYomiName) return;
				SetAttributeValue("regardingobjectidyominame", value);
			}
		}	
			
		/// <summary>
        /// regardingobjecttypecode
        /// </summary>
		[DisplayName("Regarding Object Type Code")]
		[AttributeLogicalName("regardingobjecttypecode")]
		public string RegardingObjectTypeCode
		{	
			get { return GetAttributeValue<string>("regardingobjecttypecode"); }
			set
			{ 
				if(value == RegardingObjectTypeCode) return;
				SetAttributeValue("regardingobjecttypecode", value);
			}
		}	
			
		/// <summary>
        /// repetitioncount
        /// </summary>
		[DisplayName("RepetitionCount")]
		[AttributeLogicalName("repetitioncount")]
		public int? RepetitionCount
		{	
			get { return GetAttributeValue<int?>("repetitioncount"); }
			set
			{ 
				if(value == RepetitionCount) return;
				SetAttributeValue("repetitioncount", value);
			}
		}	
			
		/// <summary>
        /// repetitionid
        /// </summary>
		[DisplayName("RepetitionId")]
		[AttributeLogicalName("repetitionid")]
		public string RepetitionId
		{	
			get { return GetAttributeValue<string>("repetitionid"); }
			set
			{ 
				if(value == RepetitionId) return;
				SetAttributeValue("repetitionid", value);
			}
		}	
			
		/// <summary>
        /// stagename
        /// </summary>
		[DisplayName("Process Stage")]
		[AttributeLogicalName("stagename")]
		public string ProcessStage
		{	
			get { return GetAttributeValue<string>("stagename"); }
			set
			{ 
				if(value == ProcessStage) return;
				SetAttributeValue("stagename", value);
			}
		}	
			
		/// <summary>
        /// startedon
        /// </summary>
		[DisplayName("Started On")]
		[AttributeLogicalName("startedon")]
		public DateTime? StartedOn2
		{	
			get { return GetAttributeValue<DateTime?>("startedon"); }
			set
			{ 
				if(value == StartedOn2) return;
				SetAttributeValue("startedon", value);
			}
		}	
			
		/// <summary>
        /// status
        /// </summary>
		[DisplayName("Status")]
		[AttributeLogicalName("status")]
		public eStatus? Status
		{	
			get 
			{ 
				var optionSetValue = GetAttributeValue<OptionSetValue>("status");
				if (optionSetValue != null) return (eStatus)optionSetValue.Value;
				else return null;
			}
			set 
			{ 
				if(value == Status) return;

				OptionSetValue optionSetValue = null;
				if(value != null) optionSetValue = new OptionSetValue((int)value);
				SetAttributeValue("status", optionSetValue); 
			}
		}

		/// <summary>
        /// stepname
        /// </summary>
		[DisplayName("Step Name")]
		[AttributeLogicalName("stepname")]
		public string StepName
		{	
			get { return GetAttributeValue<string>("stepname"); }
			set
			{ 
				if(value == StepName) return;
				SetAttributeValue("stepname", value);
			}
		}	
			
		/// <summary>
        /// workflowlogid
        /// </summary>
		[DisplayName("Process Log")]
		[AttributeLogicalName("workflowlogid")]
		public override Guid Id
		{
			get => base.Id;
			set { base.Id = value; SetAttributeValue("workflowlogid", value); }
		}

							#endregion	

		#region Relations
			/// <summary>
        /// 1:N Get entities for 'workflowlog_FileAttachments'
        /// </summary>
		[RelationshipSchemaName("workflowlog_FileAttachments")]
		public IEnumerable<FileAttachment> WorkflowlogFileAttachments
		{
			get { return GetRelatedEntities<FileAttachment>("workflowlog_FileAttachments", null); }
			set { SetRelatedEntities("workflowlog_FileAttachments", null, value); }
		}
		#endregion

		#region Actions
		#endregion

		#region OptionSetEnums
		public enum eStatus
		{	
		
			[Label("In Progress")]
			[Description(@"")]
			InProgress = 1, 
		
			[Label("Succeeded")]
			[Description(@"")]
			Succeeded = 2, 
		
			[Label("Failed")]
			[Description(@"")]
			Failed = 3, 
		
			[Label("Canceled")]
			[Description(@"")]
			Canceled = 4, 
		
			[Label("Waiting")]
			[Description(@"")]
			Waiting = 5, 
		}
		
		#endregion	

		#region Properties
		public static class Properties 
		{
			/// <summary>activityname</summary>
			public const string ActivityName = "activityname";

			/// <summary>asyncoperationid</summary>
			public const string ParentRecord = "asyncoperationid";

			/// <summary>asyncoperationidname</summary>
			public const string ParentRecord2 = "asyncoperationidname";

			/// <summary>childworkflowinstanceid</summary>
			public const string ChildWorkflowSystemJob = "childworkflowinstanceid";

			/// <summary>childworkflowinstanceidname</summary>
			public const string ChildAsyncOperationName = "childworkflowinstanceidname";

			/// <summary>childworkflowinstanceobjecttypecode</summary>
			public const string Entity = "childworkflowinstanceobjecttypecode";

			/// <summary>completedon</summary>
			public const string CompletedOn = "completedon";

			/// <summary>createdby</summary>
			public const string CreatedBy = "createdby";

			/// <summary>createdbyname</summary>
			public const string CreatedByName = "createdbyname";

			/// <summary>createdbyyominame</summary>
			public const string CreatedByYomiName = "createdbyyominame";

			/// <summary>createdon</summary>
			public const string StartedOn = "createdon";

			/// <summary>createdonbehalfby</summary>
			public const string CreatedByDelegate = "createdonbehalfby";

			/// <summary>createdonbehalfbyname</summary>
			public const string CreatedByDelegateName = "createdonbehalfbyname";

			/// <summary>createdonbehalfbyyominame</summary>
			public const string CreatedByDelegateYomiName = "createdonbehalfbyyominame";

			/// <summary>description</summary>
			public const string StepDescription = "description";

			/// <summary>duration</summary>
			public const string Duration = "duration";

			/// <summary>errorcode</summary>
			public const string ErrorMessage = "errorcode";

			/// <summary>errortext</summary>
			public const string ErrorText = "errortext";

			/// <summary>inputs_name</summary>
			public const string InputsName = "inputs_name";

			/// <summary>interactionactivityresult</summary>
			public const string InteractionActivityResult = "interactionactivityresult";

			/// <summary>iterationcount</summary>
			public const string IterationCount = "iterationcount";

			/// <summary>message</summary>
			public const string Message = "message";

			/// <summary>modifiedby</summary>
			public const string ModifiedBy = "modifiedby";

			/// <summary>modifiedbyname</summary>
			public const string ModifiedByName = "modifiedbyname";

			/// <summary>modifiedbyyominame</summary>
			public const string ModifiedByYomiName = "modifiedbyyominame";

			/// <summary>modifiedon</summary>
			public const string ModifiedOn = "modifiedon";

			/// <summary>modifiedonbehalfby</summary>
			public const string ModifiedByDelegate = "modifiedonbehalfby";

			/// <summary>modifiedonbehalfbyname</summary>
			public const string ModifiedOnBehalfByName = "modifiedonbehalfbyname";

			/// <summary>modifiedonbehalfbyyominame</summary>
			public const string ModifiedOnBehalfByYomiName = "modifiedonbehalfbyyominame";

			/// <summary>objecttypecode</summary>
			public const string Entity2 = "objecttypecode";

			/// <summary>outputs_name</summary>
			public const string OutputsName = "outputs_name";

			/// <summary>ownerid</summary>
			public const string Owner = "ownerid";

			/// <summary>owneridtype</summary>
			public const string OwnerIdType = "owneridtype";

			/// <summary>owningbusinessunit</summary>
			public const string OwningBusinessUnit = "owningbusinessunit";

			/// <summary>owningteam</summary>
			public const string OwningTeam = "owningteam";

			/// <summary>owninguser</summary>
			public const string OwningUser = "owninguser";

			/// <summary>regardingobjectid</summary>
			public const string Regarding = "regardingobjectid";

			/// <summary>regardingobjectidname</summary>
			public const string RegardingObjectIdName = "regardingobjectidname";

			/// <summary>regardingobjectidyominame</summary>
			public const string RegardingObjectIdYomiName = "regardingobjectidyominame";

			/// <summary>regardingobjecttypecode</summary>
			public const string RegardingObjectTypeCode = "regardingobjecttypecode";

			/// <summary>repetitioncount</summary>
			public const string RepetitionCount = "repetitioncount";

			/// <summary>repetitionid</summary>
			public const string RepetitionId = "repetitionid";

			/// <summary>stagename</summary>
			public const string ProcessStage = "stagename";

			/// <summary>startedon</summary>
			public const string StartedOn2 = "startedon";

			/// <summary>status</summary>
			public const string Status = "status";

			/// <summary>stepname</summary>
			public const string StepName = "stepname";

			/// <summary>workflowlogid</summary>
			public const string ProcessLogId = "workflowlogid";

		}
		#endregion

		#region Schemas
		public static class Schemas 
		{
			/// <summary>1:N workflowlog_FileAttachments</summary>
			public const string WorkflowlogFileAttachments = "workflowlog_FileAttachments";

		}
		#endregion
	}
}

