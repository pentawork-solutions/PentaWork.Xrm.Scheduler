using System;
using System.Linq;
using System.Diagnostics;
using System.ComponentModel;
using Microsoft.Xrm.Sdk; 
using Microsoft.Xrm.Sdk.Client;
using System.Collections.Generic;

namespace PentaWork.Xrm.Scheduler.Proxies.Entities
{
	[DebuggerDisplay("{SystemJobName}")] 	
	[EntityLogicalName("asyncoperation")]
	public sealed class SystemJob : Entity
	{	
		public static readonly int? EntityTypeCode = 4700;
		public new const string LogicalName = "asyncoperation";
		public const string PrimaryIdAttribute = "asyncoperationid";
		public const string PrimaryNameAttribute = "name";
	
		public SystemJob() : base("asyncoperation") { }

		#region Attributes
		/// <summary>
        /// asyncoperationid
        /// </summary>
		[DisplayName("System Job")]
		[AttributeLogicalName("asyncoperationid")]
		public override Guid Id
		{
			get => base.Id;
			set { base.Id = value; SetAttributeValue("asyncoperationid", value); }
		}

							/// <summary>
        /// breadcrumbid
        /// </summary>
		[DisplayName("Breadcrumb ID")]
		[AttributeLogicalName("breadcrumbid")]
		public Guid BreadcrumbId
		{	
			get { return GetAttributeValue<Guid>("breadcrumbid"); }
			set
			{ 
				if(value == BreadcrumbId) return;
				SetAttributeValue("breadcrumbid", value);
			}
		}	
			
		/// <summary>
        /// callerorigin
        /// </summary>
		[DisplayName("Caller Origin")]
		[AttributeLogicalName("callerorigin")]
		public string CallerOrigin
		{	
			get { return GetAttributeValue<string>("callerorigin"); }
			set
			{ 
				if(value == CallerOrigin) return;
				SetAttributeValue("callerorigin", value);
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
        /// correlationid
        /// </summary>
		[DisplayName("Correlation Id")]
		[AttributeLogicalName("correlationid")]
		public Guid CorrelationId
		{	
			get { return GetAttributeValue<Guid>("correlationid"); }
			set
			{ 
				if(value == CorrelationId) return;
				SetAttributeValue("correlationid", value);
			}
		}	
			
		/// <summary>
        /// correlationupdatedtime
        /// </summary>
		[DisplayName("Correlation Updated Time")]
		[AttributeLogicalName("correlationupdatedtime")]
		public DateTime? CorrelationUpdatedTime
		{	
			get { return GetAttributeValue<DateTime?>("correlationupdatedtime"); }
			set
			{ 
				if(value == CorrelationUpdatedTime) return;
				SetAttributeValue("correlationupdatedtime", value);
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
        /// data
        /// </summary>
		[DisplayName("Data")]
		[AttributeLogicalName("data")]
		public string Data
		{	
			get { return GetAttributeValue<string>("data"); }
			set
			{ 
				if(value == Data) return;
				SetAttributeValue("data", value);
			}
		}	
			
		/// <summary>
        /// datablobid_name
        /// </summary>
		[DisplayName("datablobid_name")]
		[AttributeLogicalName("datablobid_name")]
		public string DatablobidName
		{	
			get { return GetAttributeValue<string>("datablobid_name"); }
			set
			{ 
				if(value == DatablobidName) return;
				SetAttributeValue("datablobid_name", value);
			}
		}	
			
		/// <summary>
        /// dependencytoken
        /// </summary>
		[DisplayName("Dependency Token")]
		[AttributeLogicalName("dependencytoken")]
		public string DependencyToken
		{	
			get { return GetAttributeValue<string>("dependencytoken"); }
			set
			{ 
				if(value == DependencyToken) return;
				SetAttributeValue("dependencytoken", value);
			}
		}	
			
		/// <summary>
        /// depth
        /// </summary>
		[DisplayName("Depth")]
		[AttributeLogicalName("depth")]
		public int? Depth
		{	
			get { return GetAttributeValue<int?>("depth"); }
			set
			{ 
				if(value == Depth) return;
				SetAttributeValue("depth", value);
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
        /// executiontimespan
        /// </summary>
		[DisplayName("ExecutionTimeSpan")]
		[AttributeLogicalName("executiontimespan")]
		public double? ExecutionTimeSpan
		{	
			get { return GetAttributeValue<double?>("executiontimespan"); }
			set
			{ 
				if(value == ExecutionTimeSpan) return;
				SetAttributeValue("executiontimespan", value);
			}
		}	
			
		/// <summary>
        /// expanderstarttime
        /// </summary>
		[DisplayName("Expander Start Time")]
		[AttributeLogicalName("expanderstarttime")]
		public DateTime? ExpanderStartTime
		{	
			get { return GetAttributeValue<DateTime?>("expanderstarttime"); }
			set
			{ 
				if(value == ExpanderStartTime) return;
				SetAttributeValue("expanderstarttime", value);
			}
		}	
			
		/// <summary>
        /// friendlymessage
        /// </summary>
		[DisplayName("Friendly message")]
		[AttributeLogicalName("friendlymessage")]
		public string FriendlyMessage
		{	
			get { return GetAttributeValue<string>("friendlymessage"); }
			set
			{ 
				if(value == FriendlyMessage) return;
				SetAttributeValue("friendlymessage", value);
			}
		}	
			
		/// <summary>
        /// hostid
        /// </summary>
		[DisplayName("Host")]
		[AttributeLogicalName("hostid")]
		public string Host
		{	
			get { return GetAttributeValue<string>("hostid"); }
			set
			{ 
				if(value == Host) return;
				SetAttributeValue("hostid", value);
			}
		}	
			
		/// <summary>
        /// iswaitingforevent
        /// </summary>
		[DisplayName("Waiting for Event")]
		[AttributeLogicalName("iswaitingforevent")]
		public bool? WaitingForEvent
		{	
			get { return GetAttributeValue<bool?>("iswaitingforevent"); }
			set
			{ 
				if(value == WaitingForEvent) return;
				SetAttributeValue("iswaitingforevent", value);
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
        /// messagename
        /// </summary>
		[DisplayName("Message Name")]
		[AttributeLogicalName("messagename")]
		public string MessageName
		{	
			get { return GetAttributeValue<string>("messagename"); }
			set
			{ 
				if(value == MessageName) return;
				SetAttributeValue("messagename", value);
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
		[DisplayName("System Job Name")]
		[AttributeLogicalName("name")]
		public string SystemJobName
		{	
			get { return GetAttributeValue<string>("name"); }
			set
			{ 
				if(value == SystemJobName) return;
				SetAttributeValue("name", value);
			}
		}	
			
		/// <summary>
        /// operationtype
        /// </summary>
		[DisplayName("System Job Type")]
		[AttributeLogicalName("operationtype")]
		public eSystemJobType? SystemJobType
		{	
			get 
			{ 
				var optionSetValue = GetAttributeValue<OptionSetValue>("operationtype");
				if (optionSetValue != null) return (eSystemJobType)optionSetValue.Value;
				else return null;
			}
			set 
			{ 
				if(value == SystemJobType) return;

				OptionSetValue optionSetValue = null;
				if(value != null) optionSetValue = new OptionSetValue((int)value);
				SetAttributeValue("operationtype", optionSetValue); 
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
        /// owningextensionid
        /// </summary>
		[DisplayName("Owning Extension")]
		[AttributeLogicalName("owningextensionid")]
		public EntityReference OwningExtension
		{	
			get { return GetAttributeValue<EntityReference>("owningextensionid"); }
			set
			{ 
				if(value == OwningExtension) return;
				SetAttributeValue("owningextensionid", value);
			}
		}	
			
		/// <summary>
        /// owningextensionidname
        /// </summary>
		[DisplayName("owningextensionidname")]
		[AttributeLogicalName("owningextensionidname")]
		public string Owningextensionidname
		{	
			get { return GetAttributeValue<string>("owningextensionidname"); }
			set
			{ 
				if(value == Owningextensionidname) return;
				SetAttributeValue("owningextensionidname", value);
			}
		}	
			
		/// <summary>
        /// owningextensiontypecode
        /// </summary>
		[DisplayName("owningextensiontypecode")]
		[AttributeLogicalName("owningextensiontypecode")]
		public string Owningextensiontypecode
		{	
			get { return GetAttributeValue<string>("owningextensiontypecode"); }
			set
			{ 
				if(value == Owningextensiontypecode) return;
				SetAttributeValue("owningextensiontypecode", value);
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
        /// parentpluginexecutionid
        /// </summary>
		[DisplayName("parentpluginexecutionid")]
		[AttributeLogicalName("parentpluginexecutionid")]
		public Guid ParentpluginexecutionId
		{	
			get { return GetAttributeValue<Guid>("parentpluginexecutionid"); }
			set
			{ 
				if(value == ParentpluginexecutionId) return;
				SetAttributeValue("parentpluginexecutionid", value);
			}
		}	
			
		/// <summary>
        /// postponeuntil
        /// </summary>
		[DisplayName("Postpone Until")]
		[AttributeLogicalName("postponeuntil")]
		public DateTime? PostponeUntil
		{	
			get { return GetAttributeValue<DateTime?>("postponeuntil"); }
			set
			{ 
				if(value == PostponeUntil) return;
				SetAttributeValue("postponeuntil", value);
			}
		}	
			
		/// <summary>
        /// primaryentitytype
        /// </summary>
		[DisplayName("Primary Entity Type")]
		[AttributeLogicalName("primaryentitytype")]
		public string PrimaryEntityType
		{	
			get { return GetAttributeValue<string>("primaryentitytype"); }
			set
			{ 
				if(value == PrimaryEntityType) return;
				SetAttributeValue("primaryentitytype", value);
			}
		}	
			
		/// <summary>
        /// recurrencepattern
        /// </summary>
		[DisplayName("Recurrence Pattern")]
		[AttributeLogicalName("recurrencepattern")]
		public string RecurrencePattern
		{	
			get { return GetAttributeValue<string>("recurrencepattern"); }
			set
			{ 
				if(value == RecurrencePattern) return;
				SetAttributeValue("recurrencepattern", value);
			}
		}	
			
		/// <summary>
        /// recurrencestarttime
        /// </summary>
		[DisplayName("Recurrence Start")]
		[AttributeLogicalName("recurrencestarttime")]
		public DateTime? RecurrenceStart
		{	
			get { return GetAttributeValue<DateTime?>("recurrencestarttime"); }
			set
			{ 
				if(value == RecurrenceStart) return;
				SetAttributeValue("recurrencestarttime", value);
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
        /// requestid
        /// </summary>
		[DisplayName("Request")]
		[AttributeLogicalName("requestid")]
		public Guid RequestId
		{	
			get { return GetAttributeValue<Guid>("requestid"); }
			set
			{ 
				if(value == RequestId) return;
				SetAttributeValue("requestid", value);
			}
		}	
			
		/// <summary>
        /// retainjobhistory
        /// </summary>
		[DisplayName("Retain Job History")]
		[AttributeLogicalName("retainjobhistory")]
		public bool? RetainJobHistory
		{	
			get { return GetAttributeValue<bool?>("retainjobhistory"); }
			set
			{ 
				if(value == RetainJobHistory) return;
				SetAttributeValue("retainjobhistory", value);
			}
		}	
			
		/// <summary>
        /// retrycount
        /// </summary>
		[DisplayName("Retry Count")]
		[AttributeLogicalName("retrycount")]
		public int? RetryCount
		{	
			get { return GetAttributeValue<int?>("retrycount"); }
			set
			{ 
				if(value == RetryCount) return;
				SetAttributeValue("retrycount", value);
			}
		}	
			
		/// <summary>
        /// rootexecutioncontext
        /// </summary>
		[DisplayName("RootExecutionContext")]
		[AttributeLogicalName("rootexecutioncontext")]
		public string RootExecutionContext
		{	
			get { return GetAttributeValue<string>("rootexecutioncontext"); }
			set
			{ 
				if(value == RootExecutionContext) return;
				SetAttributeValue("rootexecutioncontext", value);
			}
		}	
			
		/// <summary>
        /// sequence
        /// </summary>
		[DisplayName("Sequence")]
		[AttributeLogicalName("sequence")]
		public int? Sequence
		{	
			get { return GetAttributeValue<int?>("sequence"); }
			set
			{ 
				if(value == Sequence) return;
				SetAttributeValue("sequence", value);
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
        /// subtype
        /// </summary>
		[DisplayName("Subtype")]
		[AttributeLogicalName("subtype")]
		public int? Subtype
		{	
			get { return GetAttributeValue<int?>("subtype"); }
			set
			{ 
				if(value == Subtype) return;
				SetAttributeValue("subtype", value);
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
        /// workflowactivationid
        /// </summary>
		[DisplayName("Workflow Activation Id")]
		[AttributeLogicalName("workflowactivationid")]
		public EntityReference WorkflowActivationId
		{	
			get { return GetAttributeValue<EntityReference>("workflowactivationid"); }
			set
			{ 
				if(value == WorkflowActivationId) return;
				SetAttributeValue("workflowactivationid", value);
			}
		}	
			
		/// <summary>
        /// workflowactivationidname
        /// </summary>
		[DisplayName("workflowactivationidname")]
		[AttributeLogicalName("workflowactivationidname")]
		public string Workflowactivationidname
		{	
			get { return GetAttributeValue<string>("workflowactivationidname"); }
			set
			{ 
				if(value == Workflowactivationidname) return;
				SetAttributeValue("workflowactivationidname", value);
			}
		}	
			
		/// <summary>
        /// workflowisblocked
        /// </summary>
		[DisplayName("Workflow Is Blocked")]
		[AttributeLogicalName("workflowisblocked")]
		public bool? WorkflowIsBlocked
		{	
			get { return GetAttributeValue<bool?>("workflowisblocked"); }
			set
			{ 
				if(value == WorkflowIsBlocked) return;
				SetAttributeValue("workflowisblocked", value);
			}
		}	
			
		/// <summary>
        /// workflowstagename
        /// </summary>
		[DisplayName("Workflow Stage")]
		[AttributeLogicalName("workflowstagename")]
		public string WorkflowStage
		{	
			get { return GetAttributeValue<string>("workflowstagename"); }
			set
			{ 
				if(value == WorkflowStage) return;
				SetAttributeValue("workflowstagename", value);
			}
		}	
			
		/// <summary>
        /// workflowstate
        /// </summary>
		[DisplayName("Workflow State")]
		[AttributeLogicalName("workflowstate")]
		public string WorkflowState
		{	
			get { return GetAttributeValue<string>("workflowstate"); }
			set
			{ 
				if(value == WorkflowState) return;
				SetAttributeValue("workflowstate", value);
			}
		}	
			
		/// <summary>
        /// workload
        /// </summary>
		[DisplayName("Workload")]
		[AttributeLogicalName("workload")]
		public string Workload
		{	
			get { return GetAttributeValue<string>("workload"); }
			set
			{ 
				if(value == Workload) return;
				SetAttributeValue("workload", value);
			}
		}	
			
		#endregion	

		#region Relations
			/// <summary>
        /// 1:N Get entities for 'AsyncOperation_BulkDeleteOperation'
        /// </summary>
		[RelationshipSchemaName("AsyncOperation_BulkDeleteOperation")]
		public IEnumerable<BulkDeleteOperation> AsyncOperationBulkDeleteOperation
		{
			get { return GetRelatedEntities<BulkDeleteOperation>("AsyncOperation_BulkDeleteOperation", null); }
			set { SetRelatedEntities("AsyncOperation_BulkDeleteOperation", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'AsyncOperation_DuplicateBaseRecord'
        /// </summary>
		[RelationshipSchemaName("AsyncOperation_DuplicateBaseRecord")]
		public IEnumerable<DuplicateRecord> AsyncOperationDuplicateBaseRecord
		{
			get { return GetRelatedEntities<DuplicateRecord>("AsyncOperation_DuplicateBaseRecord", null); }
			set { SetRelatedEntities("AsyncOperation_DuplicateBaseRecord", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'AsyncOperation_Emails'
        /// </summary>
		[RelationshipSchemaName("AsyncOperation_Emails")]
		public IEnumerable<Email> AsyncOperationEmails
		{
			get { return GetRelatedEntities<Email>("AsyncOperation_Emails", null); }
			set { SetRelatedEntities("AsyncOperation_Emails", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'asyncoperation_FileAttachments'
        /// </summary>
		[RelationshipSchemaName("asyncoperation_FileAttachments")]
		public IEnumerable<FileAttachment> AsyncoperationFileAttachments
		{
			get { return GetRelatedEntities<FileAttachment>("asyncoperation_FileAttachments", null); }
			set { SetRelatedEntities("asyncoperation_FileAttachments", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'AsyncOperation_MailboxTrackingFolder'
        /// </summary>
		[RelationshipSchemaName("AsyncOperation_MailboxTrackingFolder")]
		public IEnumerable<MailboxAutoTrackingFolder> AsyncOperationMailboxTrackingFolder
		{
			get { return GetRelatedEntities<MailboxAutoTrackingFolder>("AsyncOperation_MailboxTrackingFolder", null); }
			set { SetRelatedEntities("AsyncOperation_MailboxTrackingFolder", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'AsyncOperation_SocialActivities'
        /// </summary>
		[RelationshipSchemaName("AsyncOperation_SocialActivities")]
		public IEnumerable<SocialActivity> AsyncOperationSocialActivities
		{
			get { return GetRelatedEntities<SocialActivity>("AsyncOperation_SocialActivities", null); }
			set { SetRelatedEntities("AsyncOperation_SocialActivities", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_workflowlog_asyncoperation_childworkflow'
        /// </summary>
		[RelationshipSchemaName("lk_workflowlog_asyncoperation_childworkflow")]
		public IEnumerable<ProcessLog> LkWorkflowlogAsyncoperationChildworkflow
		{
			get { return GetRelatedEntities<ProcessLog>("lk_workflowlog_asyncoperation_childworkflow", null); }
			set { SetRelatedEntities("lk_workflowlog_asyncoperation_childworkflow", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_workflowlog_asyncoperations'
        /// </summary>
		[RelationshipSchemaName("lk_workflowlog_asyncoperations")]
		public IEnumerable<ProcessLog> LkWorkflowlogAsyncoperations
		{
			get { return GetRelatedEntities<ProcessLog>("lk_workflowlog_asyncoperations", null); }
			set { SetRelatedEntities("lk_workflowlog_asyncoperations", null, value); }
		}
		#endregion

		#region Actions
		#endregion

		#region OptionSetEnums
		public enum eSystemJobType
		{	
		
			[Label("System Event")]
			[Description(@"")]
			SystemEvent = 1, 
		
			[Label("Bulk Email")]
			[Description(@"")]
			BulkEmail = 2, 
		
			[Label("Import File Parse")]
			[Description(@"")]
			ImportFileParse = 3, 
		
			[Label("Transform Parse Data")]
			[Description(@"")]
			TransformParseData = 4, 
		
			[Label("Import")]
			[Description(@"")]
			Import = 5, 
		
			[Label("Activity Propagation")]
			[Description(@"")]
			ActivityPropagation = 6, 
		
			[Label("Duplicate Detection Rule Publish")]
			[Description(@"")]
			DuplicateDetectionRulePublish = 7, 
		
			[Label("Bulk Duplicate Detection")]
			[Description(@"")]
			BulkDuplicateDetection = 8, 
		
			[Label("SQM Data Collection")]
			[Description(@"")]
			SQMDataCollection = 9, 
		
			[Label("Workflow")]
			[Description(@"")]
			Workflow = 10, 
		
			[Label("Quick Campaign")]
			[Description(@"")]
			QuickCampaign = 11, 
		
			[Label("Matchcode Update")]
			[Description(@"")]
			MatchcodeUpdate = 12, 
		
			[Label("Bulk Delete")]
			[Description(@"")]
			BulkDelete = 13, 
		
			[Label("Deletion Service")]
			[Description(@"")]
			DeletionService = 14, 
		
			[Label("Index Management")]
			[Description(@"")]
			IndexManagement = 15, 
		
			[Label("Collect Organization Statistics")]
			[Description(@"")]
			CollectOrganizationStatistics = 16, 
		
			[Label("Import Subprocess")]
			[Description(@"")]
			ImportSubprocess = 17, 
		
			[Label("Calculate Organization Storage Size")]
			[Description(@"")]
			CalculateOrganizationStorageSize = 18, 
		
			[Label("Collect Organization Database Statistics")]
			[Description(@"")]
			CollectOrganizationDatabaseStatistics = 19, 
		
			[Label("Collection Organization Size Statistics")]
			[Description(@"")]
			CollectionOrganizationSizeStatistics = 20, 
		
			[Label("Database Tuning")]
			[Description(@"")]
			DatabaseTuning = 21, 
		
			[Label("Calculate Organization Maximum Storage Size")]
			[Description(@"")]
			CalculateOrganizationMaximumStorageSize = 22, 
		
			[Label("Bulk Delete Subprocess")]
			[Description(@"")]
			BulkDeleteSubprocess = 23, 
		
			[Label("Update Statistic Intervals")]
			[Description(@"")]
			UpdateStatisticIntervals = 24, 
		
			[Label("Organization Full Text Catalog Index")]
			[Description(@"")]
			OrganizationFullTextCatalogIndex = 25, 
		
			[Label("Database log backup")]
			[Description(@"")]
			DatabaseLogBackup = 26, 
		
			[Label("Update Contract States")]
			[Description(@"")]
			UpdateContractStates = 27, 
		
			[Label("DBCC SHRINKDATABASE maintenance job")]
			[Description(@"")]
			DBCCSHRINKDATABASEMaintenanceJob = 28, 
		
			[Label("DBCC SHRINKFILE maintenance job")]
			[Description(@"")]
			DBCCSHRINKFILEMaintenanceJob = 29, 
		
			[Label("Reindex all indices maintenance job")]
			[Description(@"")]
			ReindexAllIndicesMaintenanceJob = 30, 
		
			[Label("Storage Limit Notification")]
			[Description(@"")]
			StorageLimitNotification = 31, 
		
			[Label("Cleanup inactive workflow assemblies")]
			[Description(@"")]
			CleanupInactiveWorkflowAssemblies = 32, 
		
			[Label("Recurring Series Expansion")]
			[Description(@"")]
			RecurringSeriesExpansion = 35, 
		
			[Label("Import Sample Data")]
			[Description(@"")]
			ImportSampleData = 38, 
		
			[Label("Goal Roll Up")]
			[Description(@"")]
			GoalRollUp = 40, 
		
			[Label("Audit Partition Creation")]
			[Description(@"")]
			AuditPartitionCreation = 41, 
		
			[Label("Check For Language Pack Updates")]
			[Description(@"")]
			CheckForLanguagePackUpdates = 42, 
		
			[Label("Provision Language Pack")]
			[Description(@"")]
			ProvisionLanguagePack = 43, 
		
			[Label("Update Organization Database")]
			[Description(@"")]
			UpdateOrganizationDatabase = 44, 
		
			[Label("Update Solution")]
			[Description(@"")]
			UpdateSolution = 45, 
		
			[Label("Regenerate Entity Row Count Snapshot Data")]
			[Description(@"")]
			RegenerateEntityRowCountSnapshotData = 46, 
		
			[Label("Regenerate Read Share Snapshot Data")]
			[Description(@"")]
			RegenerateReadShareSnapshotData = 47, 
		
			[Label("Outgoing Activity")]
			[Description(@"")]
			OutgoingActivity = 50, 
		
			[Label("Incoming Email Processing")]
			[Description(@"")]
			IncomingEmailProcessing = 51, 
		
			[Label("Mailbox Test Access")]
			[Description(@"")]
			MailboxTestAccess = 52, 
		
			[Label("Encryption Health Check")]
			[Description(@"")]
			EncryptionHealthCheck = 53, 
		
			[Label("Execute Async Request")]
			[Description(@"")]
			ExecuteAsyncRequest = 54, 
		
			[Label("Post to Yammer")]
			[Description(@"")]
			PostToYammer = 49, 
		
			[Label("Update Entitlement States")]
			[Description(@"")]
			UpdateEntitlementStates = 56, 
		
			[Label("Calculate Rollup Field")]
			[Description(@"")]
			CalculateRollupField = 57, 
		
			[Label("Mass Calculate Rollup Field")]
			[Description(@"")]
			MassCalculateRollupField = 58, 
		
			[Label("Import Translation")]
			[Description(@"")]
			ImportTranslation = 59, 
		
			[Label("Convert Date And Time Behavior")]
			[Description(@"")]
			ConvertDateAndTimeBehavior = 62, 
		
			[Label("EntityKey Index Creation")]
			[Description(@"")]
			EntityKeyIndexCreation = 63, 
		
			[Label("Update Knowledge Article States")]
			[Description(@"")]
			UpdateKnowledgeArticleStates = 65, 
		
			[Label("Resource Booking Sync")]
			[Description(@"")]
			ResourceBookingSync = 68, 
		
			[Label("Relationship Assistant Cards")]
			[Description(@"")]
			RelationshipAssistantCards = 69, 
		
			[Label("Cleanup Solution Components")]
			[Description(@"")]
			CleanupSolutionComponents = 71, 
		
			[Label("App Module Metadata Operation")]
			[Description(@"")]
			AppModuleMetadataOperation = 72, 
		
			[Label("ALM Anomaly Detection Operation")]
			[Description(@"")]
			ALMAnomalyDetectionOperation = 73, 
		
			[Label("Flow Notification")]
			[Description(@"")]
			FlowNotification = 75, 
		
			[Label("Ribbon Client Metadata Operation")]
			[Description(@"")]
			RibbonClientMetadataOperation = 76, 
		
			[Label("CallbackRegistration Expander Operation")]
			[Description(@"")]
			CallbackRegistrationExpanderOperation = 79, 
		
			[Label("CascadeAssign")]
			[Description(@"")]
			CascadeAssign = 90, 
		
			[Label("CascadeDelete")]
			[Description(@"")]
			CascadeDelete = 91, 
		
			[Label("Event Expander Operation")]
			[Description(@"")]
			EventExpanderOperation = 92, 
		
			[Label("Import Solution Metadata")]
			[Description(@"")]
			ImportSolutionMetadata = 93, 
		
			[Label("Bulk Delete File Attachment")]
			[Description(@"")]
			BulkDeleteFileAttachment = 94, 
		
			[Label("Refresh Business Unit for Records Owned By Principal")]
			[Description(@"")]
			RefreshBusinessUnitForRecordsOwnedByPrincipal = 95, 
		
			[Label("Revoke Inherited Access")]
			[Description(@"")]
			RevokeInheritedAccess = 96, 
		
			[Label("Provision language for user")]
			[Description(@"")]
			ProvisionLanguageForUser = 201, 
		
			[Label("Cascade Grant or Revoke Access Version Tracking Async Operation")]
			[Description(@"")]
			CascadeGrantOrRevokeAccessVersionTrackingAsyncOperation = 12801, 
		
			[Label("Create Or Refresh Virtual Entity")]
			[Description(@"")]
			CreateOrRefreshVirtualEntity = 98, 
		
			[Label("AI Builder Training Events")]
			[Description(@"")]
			AIBuilderTrainingEvents = 190690091, 
		
			[Label("AI Builder Prediction Events")]
			[Description(@"")]
			AIBuilderPredictionEvents = 190690092, 
		}
		
		public enum eStatus
		{	
		
			[Label("Ready")]
			[Description(@"")]
			Ready = 0, 
		
			[Label("Suspended")]
			[Description(@"")]
			Suspended = 1, 
		
			[Label("Locked")]
			[Description(@"")]
			Locked = 2, 
		
			[Label("Completed")]
			[Description(@"")]
			Completed = 3, 
		}
		
		public enum eStatusReason
		{	
		
			[Label("Waiting For Resources")]
			[Description(@"")]
			WaitingForResources_Active = 0, 
		
			[Label("Waiting")]
			[Description(@"")]
			Waiting_Inactive = 10, 
		
			[Label("In Progress")]
			[Description(@"")]
			InProgress = 20, 
		
			[Label("Pausing")]
			[Description(@"")]
			Pausing = 21, 
		
			[Label("Canceling")]
			[Description(@"")]
			Canceling = 22, 
		
			[Label("Succeeded")]
			[Description(@"")]
			Succeeded = 30, 
		
			[Label("Failed")]
			[Description(@"")]
			Failed = 31, 
		
			[Label("Canceled")]
			[Description(@"")]
			Canceled = 32, 
		}
		
		#endregion	

		#region Properties
		public static class Properties 
		{
			/// <summary>asyncoperationid</summary>
			public const string SystemJobId = "asyncoperationid";

			/// <summary>breadcrumbid</summary>
			public const string BreadcrumbId = "breadcrumbid";

			/// <summary>callerorigin</summary>
			public const string CallerOrigin = "callerorigin";

			/// <summary>completedon</summary>
			public const string CompletedOn = "completedon";

			/// <summary>correlationid</summary>
			public const string CorrelationId = "correlationid";

			/// <summary>correlationupdatedtime</summary>
			public const string CorrelationUpdatedTime = "correlationupdatedtime";

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

			/// <summary>data</summary>
			public const string Data = "data";

			/// <summary>datablobid_name</summary>
			public const string DatablobidName = "datablobid_name";

			/// <summary>dependencytoken</summary>
			public const string DependencyToken = "dependencytoken";

			/// <summary>depth</summary>
			public const string Depth = "depth";

			/// <summary>errorcode</summary>
			public const string ErrorCode = "errorcode";

			/// <summary>executiontimespan</summary>
			public const string ExecutionTimeSpan = "executiontimespan";

			/// <summary>expanderstarttime</summary>
			public const string ExpanderStartTime = "expanderstarttime";

			/// <summary>friendlymessage</summary>
			public const string FriendlyMessage = "friendlymessage";

			/// <summary>hostid</summary>
			public const string Host = "hostid";

			/// <summary>iswaitingforevent</summary>
			public const string WaitingForEvent = "iswaitingforevent";

			/// <summary>message</summary>
			public const string Message = "message";

			/// <summary>messagename</summary>
			public const string MessageName = "messagename";

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
			public const string SystemJobName = "name";

			/// <summary>operationtype</summary>
			public const string SystemJobType = "operationtype";

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

			/// <summary>owningextensionid</summary>
			public const string OwningExtension = "owningextensionid";

			/// <summary>owningextensionidname</summary>
			public const string Owningextensionidname = "owningextensionidname";

			/// <summary>owningextensiontypecode</summary>
			public const string Owningextensiontypecode = "owningextensiontypecode";

			/// <summary>owningteam</summary>
			public const string OwningTeam = "owningteam";

			/// <summary>owninguser</summary>
			public const string OwningUser = "owninguser";

			/// <summary>parentpluginexecutionid</summary>
			public const string ParentpluginexecutionId = "parentpluginexecutionid";

			/// <summary>postponeuntil</summary>
			public const string PostponeUntil = "postponeuntil";

			/// <summary>primaryentitytype</summary>
			public const string PrimaryEntityType = "primaryentitytype";

			/// <summary>recurrencepattern</summary>
			public const string RecurrencePattern = "recurrencepattern";

			/// <summary>recurrencestarttime</summary>
			public const string RecurrenceStart = "recurrencestarttime";

			/// <summary>regardingobjectid</summary>
			public const string Regarding = "regardingobjectid";

			/// <summary>regardingobjectidname</summary>
			public const string Regardingobjectidname = "regardingobjectidname";

			/// <summary>regardingobjectidyominame</summary>
			public const string Regardingobjectidyominame = "regardingobjectidyominame";

			/// <summary>regardingobjecttypecode</summary>
			public const string Regardingobjecttypecode = "regardingobjecttypecode";

			/// <summary>requestid</summary>
			public const string RequestId = "requestid";

			/// <summary>retainjobhistory</summary>
			public const string RetainJobHistory = "retainjobhistory";

			/// <summary>retrycount</summary>
			public const string RetryCount = "retrycount";

			/// <summary>rootexecutioncontext</summary>
			public const string RootExecutionContext = "rootexecutioncontext";

			/// <summary>sequence</summary>
			public const string Sequence = "sequence";

			/// <summary>startedon</summary>
			public const string StartedOn = "startedon";

			/// <summary>statecode</summary>
			public const string Status = "statecode";

			/// <summary>statuscode</summary>
			public const string StatusReason = "statuscode";

			/// <summary>subtype</summary>
			public const string Subtype = "subtype";

			/// <summary>timezoneruleversionnumber</summary>
			public const string Timezoneruleversionnumber = "timezoneruleversionnumber";

			/// <summary>utcconversiontimezonecode</summary>
			public const string Utcconversiontimezonecode = "utcconversiontimezonecode";

			/// <summary>workflowactivationid</summary>
			public const string WorkflowActivationId = "workflowactivationid";

			/// <summary>workflowactivationidname</summary>
			public const string Workflowactivationidname = "workflowactivationidname";

			/// <summary>workflowisblocked</summary>
			public const string WorkflowIsBlocked = "workflowisblocked";

			/// <summary>workflowstagename</summary>
			public const string WorkflowStage = "workflowstagename";

			/// <summary>workflowstate</summary>
			public const string WorkflowState = "workflowstate";

			/// <summary>workload</summary>
			public const string Workload = "workload";

		}
		#endregion

		#region Schemas
		public static class Schemas 
		{
			/// <summary>1:N AsyncOperation_BulkDeleteOperation</summary>
			public const string AsyncOperationBulkDeleteOperation = "AsyncOperation_BulkDeleteOperation";

			/// <summary>1:N AsyncOperation_DuplicateBaseRecord</summary>
			public const string AsyncOperationDuplicateBaseRecord = "AsyncOperation_DuplicateBaseRecord";

			/// <summary>1:N AsyncOperation_Emails</summary>
			public const string AsyncOperationEmails = "AsyncOperation_Emails";

			/// <summary>1:N asyncoperation_FileAttachments</summary>
			public const string AsyncoperationFileAttachments = "asyncoperation_FileAttachments";

			/// <summary>1:N AsyncOperation_MailboxTrackingFolder</summary>
			public const string AsyncOperationMailboxTrackingFolder = "AsyncOperation_MailboxTrackingFolder";

			/// <summary>1:N AsyncOperation_SocialActivities</summary>
			public const string AsyncOperationSocialActivities = "AsyncOperation_SocialActivities";

			/// <summary>1:N lk_workflowlog_asyncoperation_childworkflow</summary>
			public const string LkWorkflowlogAsyncoperationChildworkflow = "lk_workflowlog_asyncoperation_childworkflow";

			/// <summary>1:N lk_workflowlog_asyncoperations</summary>
			public const string LkWorkflowlogAsyncoperations = "lk_workflowlog_asyncoperations";

		}
		#endregion
	}
}

