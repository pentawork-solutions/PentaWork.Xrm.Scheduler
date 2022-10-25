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
	[EntityLogicalName("processsession")]
	public sealed class ProcessSession : Entity
	{	
		public static readonly int? EntityTypeCode = 4710;
		public new const string LogicalName = "processsession";
		public const string PrimaryIdAttribute = "processsessionid";
		public const string PrimaryNameAttribute = "name";
	
		public ProcessSession() : base("processsession") { }

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
        /// canceledby
        /// </summary>
		[DisplayName("Canceled By")]
		[AttributeLogicalName("canceledby")]
		public EntityReference CanceledBy
		{	
			get { return GetAttributeValue<EntityReference>("canceledby"); }
			set
			{ 
				if(value == CanceledBy) return;
				SetAttributeValue("canceledby", value);
			}
		}	
			
		/// <summary>
        /// canceledbyname
        /// </summary>
		[DisplayName("canceledbyname")]
		[AttributeLogicalName("canceledbyname")]
		public string Canceledbyname
		{	
			get { return GetAttributeValue<string>("canceledbyname"); }
			set
			{ 
				if(value == Canceledbyname) return;
				SetAttributeValue("canceledbyname", value);
			}
		}	
			
		/// <summary>
        /// canceledbyyominame
        /// </summary>
		[DisplayName("canceledbyyominame")]
		[AttributeLogicalName("canceledbyyominame")]
		public string Canceledbyyominame
		{	
			get { return GetAttributeValue<string>("canceledbyyominame"); }
			set
			{ 
				if(value == Canceledbyyominame) return;
				SetAttributeValue("canceledbyyominame", value);
			}
		}	
			
		/// <summary>
        /// canceledon
        /// </summary>
		[DisplayName("Canceled On")]
		[AttributeLogicalName("canceledon")]
		public DateTime? CanceledOn
		{	
			get { return GetAttributeValue<DateTime?>("canceledon"); }
			set
			{ 
				if(value == CanceledOn) return;
				SetAttributeValue("canceledon", value);
			}
		}	
			
		/// <summary>
        /// comments
        /// </summary>
		[DisplayName("Comments")]
		[AttributeLogicalName("comments")]
		public string Comments
		{	
			get { return GetAttributeValue<string>("comments"); }
			set
			{ 
				if(value == Comments) return;
				SetAttributeValue("comments", value);
			}
		}	
			
		/// <summary>
        /// completedby
        /// </summary>
		[DisplayName("Completed By")]
		[AttributeLogicalName("completedby")]
		public EntityReference CompletedBy
		{	
			get { return GetAttributeValue<EntityReference>("completedby"); }
			set
			{ 
				if(value == CompletedBy) return;
				SetAttributeValue("completedby", value);
			}
		}	
			
		/// <summary>
        /// completedbyname
        /// </summary>
		[DisplayName("completedbyname")]
		[AttributeLogicalName("completedbyname")]
		public string Completedbyname
		{	
			get { return GetAttributeValue<string>("completedbyname"); }
			set
			{ 
				if(value == Completedbyname) return;
				SetAttributeValue("completedbyname", value);
			}
		}	
			
		/// <summary>
        /// completedbyyominame
        /// </summary>
		[DisplayName("completedbyyominame")]
		[AttributeLogicalName("completedbyyominame")]
		public string Completedbyyominame
		{	
			get { return GetAttributeValue<string>("completedbyyominame"); }
			set
			{ 
				if(value == Completedbyyominame) return;
				SetAttributeValue("completedbyyominame", value);
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
		[DisplayName("Error Code")]
		[AttributeLogicalName("errorcode")]
		public int? ErrorCode
		{	
			get { return GetAttributeValue<int?>("errorcode"); }
			set
			{ 
				if(value == ErrorCode) return;
				SetAttributeValue("errorcode", value);
			}
		}	
			
		/// <summary>
        /// executedby
        /// </summary>
		[DisplayName("Executed By")]
		[AttributeLogicalName("executedby")]
		public EntityReference ExecutedBy
		{	
			get { return GetAttributeValue<EntityReference>("executedby"); }
			set
			{ 
				if(value == ExecutedBy) return;
				SetAttributeValue("executedby", value);
			}
		}	
			
		/// <summary>
        /// executedbyname
        /// </summary>
		[DisplayName("executedbyname")]
		[AttributeLogicalName("executedbyname")]
		public string Executedbyname
		{	
			get { return GetAttributeValue<string>("executedbyname"); }
			set
			{ 
				if(value == Executedbyname) return;
				SetAttributeValue("executedbyname", value);
			}
		}	
			
		/// <summary>
        /// executedbyyominame
        /// </summary>
		[DisplayName("executedbyyominame")]
		[AttributeLogicalName("executedbyyominame")]
		public string Executedbyyominame
		{	
			get { return GetAttributeValue<string>("executedbyyominame"); }
			set
			{ 
				if(value == Executedbyyominame) return;
				SetAttributeValue("executedbyyominame", value);
			}
		}	
			
		/// <summary>
        /// executedon
        /// </summary>
		[DisplayName("Executed On")]
		[AttributeLogicalName("executedon")]
		public DateTime? ExecutedOn
		{	
			get { return GetAttributeValue<DateTime?>("executedon"); }
			set
			{ 
				if(value == ExecutedOn) return;
				SetAttributeValue("executedon", value);
			}
		}	
			
		/// <summary>
        /// inputarguments
        /// </summary>
		[DisplayName("Input Arguments")]
		[AttributeLogicalName("inputarguments")]
		public string InputArguments
		{	
			get { return GetAttributeValue<string>("inputarguments"); }
			set
			{ 
				if(value == InputArguments) return;
				SetAttributeValue("inputarguments", value);
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
        /// nextlinkedsessionid
        /// </summary>
		[DisplayName("Next Linked Session")]
		[AttributeLogicalName("nextlinkedsessionid")]
		public EntityReference NextLinkedSession
		{	
			get { return GetAttributeValue<EntityReference>("nextlinkedsessionid"); }
			set
			{ 
				if(value == NextLinkedSession) return;
				SetAttributeValue("nextlinkedsessionid", value);
			}
		}	
			
		/// <summary>
        /// nextlinkedsessionidname
        /// </summary>
		[DisplayName("nextlinkedsessionidname")]
		[AttributeLogicalName("nextlinkedsessionidname")]
		public string Nextlinkedsessionidname
		{	
			get { return GetAttributeValue<string>("nextlinkedsessionidname"); }
			set
			{ 
				if(value == Nextlinkedsessionidname) return;
				SetAttributeValue("nextlinkedsessionidname", value);
			}
		}	
			
		/// <summary>
        /// originatingsessionid
        /// </summary>
		[DisplayName("Originating Session")]
		[AttributeLogicalName("originatingsessionid")]
		public EntityReference OriginatingSession
		{	
			get { return GetAttributeValue<EntityReference>("originatingsessionid"); }
			set
			{ 
				if(value == OriginatingSession) return;
				SetAttributeValue("originatingsessionid", value);
			}
		}	
			
		/// <summary>
        /// originatingsessionidname
        /// </summary>
		[DisplayName("originatingsessionidname")]
		[AttributeLogicalName("originatingsessionidname")]
		public string Originatingsessionidname
		{	
			get { return GetAttributeValue<string>("originatingsessionidname"); }
			set
			{ 
				if(value == Originatingsessionidname) return;
				SetAttributeValue("originatingsessionidname", value);
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
        /// previouslinkedsessionid
        /// </summary>
		[DisplayName("Previous Linked Session")]
		[AttributeLogicalName("previouslinkedsessionid")]
		public EntityReference PreviousLinkedSession
		{	
			get { return GetAttributeValue<EntityReference>("previouslinkedsessionid"); }
			set
			{ 
				if(value == PreviousLinkedSession) return;
				SetAttributeValue("previouslinkedsessionid", value);
			}
		}	
			
		/// <summary>
        /// previouslinkedsessionidname
        /// </summary>
		[DisplayName("previouslinkedsessionidname")]
		[AttributeLogicalName("previouslinkedsessionidname")]
		public string Previouslinkedsessionidname
		{	
			get { return GetAttributeValue<string>("previouslinkedsessionidname"); }
			set
			{ 
				if(value == Previouslinkedsessionidname) return;
				SetAttributeValue("previouslinkedsessionidname", value);
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
        /// processsessionid
        /// </summary>
		[DisplayName("Dialog Session")]
		[AttributeLogicalName("processsessionid")]
		public override Guid Id
		{
			get => base.Id;
			set { base.Id = value; SetAttributeValue("processsessionid", value); }
		}

							/// <summary>
        /// processstagename
        /// </summary>
		[DisplayName("Dialog Stage")]
		[AttributeLogicalName("processstagename")]
		public string DialogStage
		{	
			get { return GetAttributeValue<string>("processstagename"); }
			set
			{ 
				if(value == DialogStage) return;
				SetAttributeValue("processstagename", value);
			}
		}	
			
		/// <summary>
        /// processstate
        /// </summary>
		[DisplayName("Process State")]
		[AttributeLogicalName("processstate")]
		public string ProcessState
		{	
			get { return GetAttributeValue<string>("processstate"); }
			set
			{ 
				if(value == ProcessState) return;
				SetAttributeValue("processstate", value);
			}
		}	
			
		/// <summary>
        /// protectionkey
        /// </summary>
		[DisplayName("Protection Key")]
		[AttributeLogicalName("protectionkey")]
		public string ProtectionKey
		{	
			get { return GetAttributeValue<string>("protectionkey"); }
			set
			{ 
				if(value == ProtectionKey) return;
				SetAttributeValue("protectionkey", value);
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
        /// startedby
        /// </summary>
		[DisplayName("Started By")]
		[AttributeLogicalName("startedby")]
		public EntityReference StartedBy
		{	
			get { return GetAttributeValue<EntityReference>("startedby"); }
			set
			{ 
				if(value == StartedBy) return;
				SetAttributeValue("startedby", value);
			}
		}	
			
		/// <summary>
        /// startedbyname
        /// </summary>
		[DisplayName("startedbyname")]
		[AttributeLogicalName("startedbyname")]
		public string Startedbyname
		{	
			get { return GetAttributeValue<string>("startedbyname"); }
			set
			{ 
				if(value == Startedbyname) return;
				SetAttributeValue("startedbyname", value);
			}
		}	
			
		/// <summary>
        /// startedbyyominame
        /// </summary>
		[DisplayName("startedbyyominame")]
		[AttributeLogicalName("startedbyyominame")]
		public string Startedbyyominame
		{	
			get { return GetAttributeValue<string>("startedbyyominame"); }
			set
			{ 
				if(value == Startedbyyominame) return;
				SetAttributeValue("startedbyyominame", value);
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
			
		#endregion	

		#region Relations
			/// <summary>
        /// 1:N Get entities for 'lk_processsession_nextlinkedsessionid'
        /// </summary>
		[RelationshipSchemaName("lk_processsession_nextlinkedsessionid")]
		public IEnumerable<ProcessSession> LkProcesssessionNextlinkedsessionid
		{
			get { return GetRelatedEntities<ProcessSession>("lk_processsession_nextlinkedsessionid", null); }
			set { SetRelatedEntities("lk_processsession_nextlinkedsessionid", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_processsession_originatingsessionid'
        /// </summary>
		[RelationshipSchemaName("lk_processsession_originatingsessionid")]
		public IEnumerable<ProcessSession> LkProcesssessionOriginatingsessionid
		{
			get { return GetRelatedEntities<ProcessSession>("lk_processsession_originatingsessionid", null); }
			set { SetRelatedEntities("lk_processsession_originatingsessionid", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_processsession_previouslinkedsessionid'
        /// </summary>
		[RelationshipSchemaName("lk_processsession_previouslinkedsessionid")]
		public IEnumerable<ProcessSession> LkProcesssessionPreviouslinkedsessionid
		{
			get { return GetRelatedEntities<ProcessSession>("lk_processsession_previouslinkedsessionid", null); }
			set { SetRelatedEntities("lk_processsession_previouslinkedsessionid", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_workflowlog_processsession'
        /// </summary>
		[RelationshipSchemaName("lk_workflowlog_processsession")]
		public IEnumerable<ProcessLog> LkWorkflowlogProcesssession
		{
			get { return GetRelatedEntities<ProcessLog>("lk_workflowlog_processsession", null); }
			set { SetRelatedEntities("lk_workflowlog_processsession", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_workflowlog_processsession_childworkflow'
        /// </summary>
		[RelationshipSchemaName("lk_workflowlog_processsession_childworkflow")]
		public IEnumerable<ProcessLog> LkWorkflowlogProcesssessionChildworkflow
		{
			get { return GetRelatedEntities<ProcessLog>("lk_workflowlog_processsession_childworkflow", null); }
			set { SetRelatedEntities("lk_workflowlog_processsession_childworkflow", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'processsession_connections1'
        /// </summary>
		[RelationshipSchemaName("processsession_connections1")]
		public IEnumerable<Connection> ProcesssessionConnections1
		{
			get { return GetRelatedEntities<Connection>("processsession_connections1", null); }
			set { SetRelatedEntities("processsession_connections1", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'processsession_connections2'
        /// </summary>
		[RelationshipSchemaName("processsession_connections2")]
		public IEnumerable<Connection> ProcesssessionConnections2
		{
			get { return GetRelatedEntities<Connection>("processsession_connections2", null); }
			set { SetRelatedEntities("processsession_connections2", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'processsession_PostFollows'
        /// </summary>
		[RelationshipSchemaName("processsession_PostFollows")]
		public IEnumerable<Follow> ProcesssessionPostFollows
		{
			get { return GetRelatedEntities<Follow>("processsession_PostFollows", null); }
			set { SetRelatedEntities("processsession_PostFollows", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'ProcessSession_SyncErrors'
        /// </summary>
		[RelationshipSchemaName("ProcessSession_SyncErrors")]
		public IEnumerable<SyncError> ProcessSessionSyncErrors
		{
			get { return GetRelatedEntities<SyncError>("ProcessSession_SyncErrors", null); }
			set { SetRelatedEntities("ProcessSession_SyncErrors", null, value); }
		}
		#endregion

		#region Actions
		#endregion

		#region OptionSetEnums
		public enum eStatus
		{	
		
			[Label("Incomplete")]
			[Description(@"")]
			Incomplete = 0, 
		
			[Label("Complete")]
			[Description(@"")]
			Complete = 1, 
		}
		
		public enum eStatusReason
		{	
		
			[Label("Not Started")]
			[Description(@"")]
			NotStarted_Active = 1, 
		
			[Label("In Progress")]
			[Description(@"")]
			InProgress_Active = 2, 
		
			[Label("Paused")]
			[Description(@"")]
			Paused_Active = 3, 
		
			[Label("Completed")]
			[Description(@"")]
			Completed_Inactive = 4, 
		
			[Label("Canceled")]
			[Description(@"")]
			Canceled_Inactive = 5, 
		
			[Label("Failed")]
			[Description(@"")]
			Failed_Inactive = 6, 
		}
		
		#endregion	

		#region Properties
		public static class Properties 
		{
			/// <summary>activityname</summary>
			public const string ActivityName = "activityname";

			/// <summary>canceledby</summary>
			public const string CanceledBy = "canceledby";

			/// <summary>canceledbyname</summary>
			public const string Canceledbyname = "canceledbyname";

			/// <summary>canceledbyyominame</summary>
			public const string Canceledbyyominame = "canceledbyyominame";

			/// <summary>canceledon</summary>
			public const string CanceledOn = "canceledon";

			/// <summary>comments</summary>
			public const string Comments = "comments";

			/// <summary>completedby</summary>
			public const string CompletedBy = "completedby";

			/// <summary>completedbyname</summary>
			public const string Completedbyname = "completedbyname";

			/// <summary>completedbyyominame</summary>
			public const string Completedbyyominame = "completedbyyominame";

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

			/// <summary>errorcode</summary>
			public const string ErrorCode = "errorcode";

			/// <summary>executedby</summary>
			public const string ExecutedBy = "executedby";

			/// <summary>executedbyname</summary>
			public const string Executedbyname = "executedbyname";

			/// <summary>executedbyyominame</summary>
			public const string Executedbyyominame = "executedbyyominame";

			/// <summary>executedon</summary>
			public const string ExecutedOn = "executedon";

			/// <summary>inputarguments</summary>
			public const string InputArguments = "inputarguments";

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

			/// <summary>nextlinkedsessionid</summary>
			public const string NextLinkedSession = "nextlinkedsessionid";

			/// <summary>nextlinkedsessionidname</summary>
			public const string Nextlinkedsessionidname = "nextlinkedsessionidname";

			/// <summary>originatingsessionid</summary>
			public const string OriginatingSession = "originatingsessionid";

			/// <summary>originatingsessionidname</summary>
			public const string Originatingsessionidname = "originatingsessionidname";

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

			/// <summary>previouslinkedsessionid</summary>
			public const string PreviousLinkedSession = "previouslinkedsessionid";

			/// <summary>previouslinkedsessionidname</summary>
			public const string Previouslinkedsessionidname = "previouslinkedsessionidname";

			/// <summary>processid</summary>
			public const string Process = "processid";

			/// <summary>processidname</summary>
			public const string Processidname = "processidname";

			/// <summary>processsessionid</summary>
			public const string DialogSessionId = "processsessionid";

			/// <summary>processstagename</summary>
			public const string DialogStage = "processstagename";

			/// <summary>processstate</summary>
			public const string ProcessState = "processstate";

			/// <summary>protectionkey</summary>
			public const string ProtectionKey = "protectionkey";

			/// <summary>regardingobjectid</summary>
			public const string Regarding = "regardingobjectid";

			/// <summary>regardingobjectidname</summary>
			public const string Regardingobjectidname = "regardingobjectidname";

			/// <summary>regardingobjectidyominame</summary>
			public const string Regardingobjectidyominame = "regardingobjectidyominame";

			/// <summary>regardingobjecttypecode</summary>
			public const string Regardingobjecttypecode = "regardingobjecttypecode";

			/// <summary>startedby</summary>
			public const string StartedBy = "startedby";

			/// <summary>startedbyname</summary>
			public const string Startedbyname = "startedbyname";

			/// <summary>startedbyyominame</summary>
			public const string Startedbyyominame = "startedbyyominame";

			/// <summary>startedon</summary>
			public const string StartedOn = "startedon";

			/// <summary>statecode</summary>
			public const string Status = "statecode";

			/// <summary>statuscode</summary>
			public const string StatusReason = "statuscode";

			/// <summary>stepname</summary>
			public const string StepName = "stepname";

		}
		#endregion

		#region Schemas
		public static class Schemas 
		{
			/// <summary>1:N lk_processsession_nextlinkedsessionid</summary>
			public const string LkProcesssessionNextlinkedsessionid = "lk_processsession_nextlinkedsessionid";

			/// <summary>1:N lk_processsession_originatingsessionid</summary>
			public const string LkProcesssessionOriginatingsessionid = "lk_processsession_originatingsessionid";

			/// <summary>1:N lk_processsession_previouslinkedsessionid</summary>
			public const string LkProcesssessionPreviouslinkedsessionid = "lk_processsession_previouslinkedsessionid";

			/// <summary>1:N lk_workflowlog_processsession</summary>
			public const string LkWorkflowlogProcesssession = "lk_workflowlog_processsession";

			/// <summary>1:N lk_workflowlog_processsession_childworkflow</summary>
			public const string LkWorkflowlogProcesssessionChildworkflow = "lk_workflowlog_processsession_childworkflow";

			/// <summary>1:N processsession_connections1</summary>
			public const string ProcesssessionConnections1 = "processsession_connections1";

			/// <summary>1:N processsession_connections2</summary>
			public const string ProcesssessionConnections2 = "processsession_connections2";

			/// <summary>1:N processsession_PostFollows</summary>
			public const string ProcesssessionPostFollows = "processsession_PostFollows";

			/// <summary>1:N ProcessSession_SyncErrors</summary>
			public const string ProcessSessionSyncErrors = "ProcessSession_SyncErrors";

		}
		#endregion
	}
}

