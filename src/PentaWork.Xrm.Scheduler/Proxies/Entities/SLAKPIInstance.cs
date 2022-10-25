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
	[EntityLogicalName("slakpiinstance")]
	public sealed class SLAKPIInstance : Entity
	{	
		public static readonly int? EntityTypeCode = 9752;
		public new const string LogicalName = "slakpiinstance";
		public const string PrimaryIdAttribute = "slakpiinstanceid";
		public const string PrimaryNameAttribute = "name";
	
		public SLAKPIInstance() : base("slakpiinstance") { }

		#region Attributes
		/// <summary>
        /// applicablefromvalue
        /// </summary>
		[DisplayName("Applicable From Value")]
		[AttributeLogicalName("applicablefromvalue")]
		public DateTime? ApplicableFromValue
		{	
			get { return GetAttributeValue<DateTime?>("applicablefromvalue"); }
			set
			{ 
				if(value == ApplicableFromValue) return;
				SetAttributeValue("applicablefromvalue", value);
			}
		}	
			
		/// <summary>
        /// computedfailuretime
        /// </summary>
		[DisplayName("Computed Failure Time")]
		[AttributeLogicalName("computedfailuretime")]
		public DateTime? ComputedFailureTime
		{	
			get { return GetAttributeValue<DateTime?>("computedfailuretime"); }
			set
			{ 
				if(value == ComputedFailureTime) return;
				SetAttributeValue("computedfailuretime", value);
			}
		}	
			
		/// <summary>
        /// computedwarningtime
        /// </summary>
		[DisplayName("Computed Warning Time")]
		[AttributeLogicalName("computedwarningtime")]
		public DateTime? ComputedWarningTime
		{	
			get { return GetAttributeValue<DateTime?>("computedwarningtime"); }
			set
			{ 
				if(value == ComputedWarningTime) return;
				SetAttributeValue("computedwarningtime", value);
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
        /// elapsedtime
        /// </summary>
		[DisplayName("Elapsed Time")]
		[AttributeLogicalName("elapsedtime")]
		public int? ElapsedTime
		{	
			get { return GetAttributeValue<int?>("elapsedtime"); }
			set
			{ 
				if(value == ElapsedTime) return;
				SetAttributeValue("elapsedtime", value);
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
        /// failuretime
        /// </summary>
		[DisplayName("Failure Time")]
		[AttributeLogicalName("failuretime")]
		public DateTime? FailureTime
		{	
			get { return GetAttributeValue<DateTime?>("failuretime"); }
			set
			{ 
				if(value == FailureTime) return;
				SetAttributeValue("failuretime", value);
			}
		}	
			
		/// <summary>
        /// lastresumetime
        /// </summary>
		[DisplayName("Last Resume Time")]
		[AttributeLogicalName("lastresumetime")]
		public DateTime? LastResumeTime
		{	
			get { return GetAttributeValue<DateTime?>("lastresumetime"); }
			set
			{ 
				if(value == LastResumeTime) return;
				SetAttributeValue("lastresumetime", value);
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
        /// pausedon
        /// </summary>
		[DisplayName("Paused On")]
		[AttributeLogicalName("pausedon")]
		public DateTime? PausedOn
		{	
			get { return GetAttributeValue<DateTime?>("pausedon"); }
			set
			{ 
				if(value == PausedOn) return;
				SetAttributeValue("pausedon", value);
			}
		}	
			
		/// <summary>
        /// regarding
        /// </summary>
		[DisplayName("Regarding")]
		[AttributeLogicalName("regarding")]
		public EntityReference Regarding
		{	
			get { return GetAttributeValue<EntityReference>("regarding"); }
			set
			{ 
				if(value == Regarding) return;
				SetAttributeValue("regarding", value);
			}
		}	
			
		/// <summary>
        /// regardingentityid
        /// </summary>
		[DisplayName("Regarding ID")]
		[AttributeLogicalName("regardingentityid")]
		public string RegardingID
		{	
			get { return GetAttributeValue<string>("regardingentityid"); }
			set
			{ 
				if(value == RegardingID) return;
				SetAttributeValue("regardingentityid", value);
			}
		}	
			
		/// <summary>
        /// regardingidname
        /// </summary>
		[DisplayName("RegardingName")]
		[AttributeLogicalName("regardingidname")]
		public string RegardingName
		{	
			get { return GetAttributeValue<string>("regardingidname"); }
			set
			{ 
				if(value == RegardingName) return;
				SetAttributeValue("regardingidname", value);
			}
		}	
			
		/// <summary>
        /// regardingname
        /// </summary>
		[DisplayName("regardingname")]
		[AttributeLogicalName("regardingname")]
		public string Regardingname
		{	
			get { return GetAttributeValue<string>("regardingname"); }
			set
			{ 
				if(value == Regardingname) return;
				SetAttributeValue("regardingname", value);
			}
		}	
			
		/// <summary>
        /// regardingobjecttypecode
        /// </summary>
		[DisplayName("RegardingObjectTypeCode")]
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
        /// regardingyominame
        /// </summary>
		[DisplayName("RegardingYomiName")]
		[AttributeLogicalName("regardingyominame")]
		public string RegardingYomiName
		{	
			get { return GetAttributeValue<string>("regardingyominame"); }
			set
			{ 
				if(value == RegardingYomiName) return;
				SetAttributeValue("regardingyominame", value);
			}
		}	
			
		/// <summary>
        /// slakpiinstanceid
        /// </summary>
		[DisplayName("SLA KPI InstanceId")]
		[AttributeLogicalName("slakpiinstanceid")]
		public override Guid Id
		{
			get => base.Id;
			set { base.Id = value; SetAttributeValue("slakpiinstanceid", value); }
		}

							/// <summary>
        /// status
        /// </summary>
		[DisplayName("Status")]
		[AttributeLogicalName("status")]
		public eSLAKPIInstanceType? Status
		{	
			get 
			{ 
				var optionSetValue = GetAttributeValue<OptionSetValue>("status");
				if (optionSetValue != null) return (eSLAKPIInstanceType)optionSetValue.Value;
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
        /// succeededon
        /// </summary>
		[DisplayName("Succeeded On")]
		[AttributeLogicalName("succeededon")]
		public DateTime? SucceededOn
		{	
			get { return GetAttributeValue<DateTime?>("succeededon"); }
			set
			{ 
				if(value == SucceededOn) return;
				SetAttributeValue("succeededon", value);
			}
		}	
			
		/// <summary>
        /// successcheckedat
        /// </summary>
		[DisplayName("SuccessCheckedAt")]
		[AttributeLogicalName("successcheckedat")]
		public DateTime? SuccessCheckedAt
		{	
			get { return GetAttributeValue<DateTime?>("successcheckedat"); }
			set
			{ 
				if(value == SuccessCheckedAt) return;
				SetAttributeValue("successcheckedat", value);
			}
		}	
			
		/// <summary>
        /// terminalstatereached
        /// </summary>
		[DisplayName("Terminal State Reached")]
		[AttributeLogicalName("terminalstatereached")]
		public bool? TerminalStateReached
		{	
			get { return GetAttributeValue<bool?>("terminalstatereached"); }
			set
			{ 
				if(value == TerminalStateReached) return;
				SetAttributeValue("terminalstatereached", value);
			}
		}	
			
		/// <summary>
        /// terminalstatetime
        /// </summary>
		[DisplayName("Terminal State Time")]
		[AttributeLogicalName("terminalstatetime")]
		public DateTime? TerminalStateTime
		{	
			get { return GetAttributeValue<DateTime?>("terminalstatetime"); }
			set
			{ 
				if(value == TerminalStateTime) return;
				SetAttributeValue("terminalstatetime", value);
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
        /// warningtime
        /// </summary>
		[DisplayName("Warning Time")]
		[AttributeLogicalName("warningtime")]
		public DateTime? WarningTime
		{	
			get { return GetAttributeValue<DateTime?>("warningtime"); }
			set
			{ 
				if(value == WarningTime) return;
				SetAttributeValue("warningtime", value);
			}
		}	
			
		/// <summary>
        /// warningtimereached
        /// </summary>
		[DisplayName("Warning Time Reached")]
		[AttributeLogicalName("warningtimereached")]
		public eWarningTimeReached? WarningTimeReached
		{	
			get 
			{ 
				var optionSetValue = GetAttributeValue<OptionSetValue>("warningtimereached");
				if (optionSetValue != null) return (eWarningTimeReached)optionSetValue.Value;
				else return null;
			}
			set 
			{ 
				if(value == WarningTimeReached) return;

				OptionSetValue optionSetValue = null;
				if(value != null) optionSetValue = new OptionSetValue((int)value);
				SetAttributeValue("warningtimereached", optionSetValue); 
			}
		}

		#endregion	

		#region Relations
			/// <summary>
        /// 1:N Get entities for 'slakpiinstance_incident_firstresponsebykpi'
        /// </summary>
		[RelationshipSchemaName("slakpiinstance_incident_firstresponsebykpi")]
		public IEnumerable<Case> SlakpiinstanceIncidentFirstresponsebykpi
		{
			get { return GetRelatedEntities<Case>("slakpiinstance_incident_firstresponsebykpi", null); }
			set { SetRelatedEntities("slakpiinstance_incident_firstresponsebykpi", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'slakpiinstance_incident_resolvebykpi'
        /// </summary>
		[RelationshipSchemaName("slakpiinstance_incident_resolvebykpi")]
		public IEnumerable<Case> SlakpiinstanceIncidentResolvebykpi
		{
			get { return GetRelatedEntities<Case>("slakpiinstance_incident_resolvebykpi", null); }
			set { SetRelatedEntities("slakpiinstance_incident_resolvebykpi", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'SLAKPIInstance_SyncErrors'
        /// </summary>
		[RelationshipSchemaName("SLAKPIInstance_SyncErrors")]
		public IEnumerable<SyncError> SLAKPIInstanceSyncErrors
		{
			get { return GetRelatedEntities<SyncError>("SLAKPIInstance_SyncErrors", null); }
			set { SetRelatedEntities("SLAKPIInstance_SyncErrors", null, value); }
		}
		#endregion

		#region Actions
		#endregion

		#region OptionSetEnums
		public enum eSLAKPIInstanceType
		{	
		
			[Label("In Progress")]
			[Description(@"")]
			InProgress = 0, 
		
			[Label("Noncompliant")]
			[Description(@"")]
			Noncompliant = 1, 
		
			[Label("Nearing Noncompliance")]
			[Description(@"")]
			NearingNoncompliance = 2, 
		
			[Label("Paused")]
			[Description(@"")]
			Paused = 3, 
		
			[Label("Succeeded")]
			[Description(@"")]
			Succeeded = 4, 
		
			[Label("Canceled")]
			[Description(@"")]
			Canceled = 5, 
		}
		
		public enum eWarningTimeReached
		{	
		
			[Label("No")]
			[Description(@"")]
			No = 0, 
		
			[Label("Yes")]
			[Description(@"")]
			Yes = 1, 
		}
		
		#endregion	

		#region Properties
		public static class Properties 
		{
			/// <summary>applicablefromvalue</summary>
			public const string ApplicableFromValue = "applicablefromvalue";

			/// <summary>computedfailuretime</summary>
			public const string ComputedFailureTime = "computedfailuretime";

			/// <summary>computedwarningtime</summary>
			public const string ComputedWarningTime = "computedwarningtime";

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

			/// <summary>elapsedtime</summary>
			public const string ElapsedTime = "elapsedtime";

			/// <summary>exchangerate</summary>
			public const string ExchangeRate = "exchangerate";

			/// <summary>failuretime</summary>
			public const string FailureTime = "failuretime";

			/// <summary>lastresumetime</summary>
			public const string LastResumeTime = "lastresumetime";

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

			/// <summary>pausedon</summary>
			public const string PausedOn = "pausedon";

			/// <summary>regarding</summary>
			public const string Regarding = "regarding";

			/// <summary>regardingentityid</summary>
			public const string RegardingID = "regardingentityid";

			/// <summary>regardingidname</summary>
			public const string RegardingName = "regardingidname";

			/// <summary>regardingname</summary>
			public const string Regardingname = "regardingname";

			/// <summary>regardingobjecttypecode</summary>
			public const string RegardingObjectTypeCode = "regardingobjecttypecode";

			/// <summary>regardingyominame</summary>
			public const string RegardingYomiName = "regardingyominame";

			/// <summary>slakpiinstanceid</summary>
			public const string SLAKPIInstanceId = "slakpiinstanceid";

			/// <summary>status</summary>
			public const string Status = "status";

			/// <summary>succeededon</summary>
			public const string SucceededOn = "succeededon";

			/// <summary>successcheckedat</summary>
			public const string SuccessCheckedAt = "successcheckedat";

			/// <summary>terminalstatereached</summary>
			public const string TerminalStateReached = "terminalstatereached";

			/// <summary>terminalstatetime</summary>
			public const string TerminalStateTime = "terminalstatetime";

			/// <summary>transactioncurrencyid</summary>
			public const string Currency = "transactioncurrencyid";

			/// <summary>transactioncurrencyidname</summary>
			public const string Transactioncurrencyidname = "transactioncurrencyidname";

			/// <summary>versionnumber</summary>
			public const string VersionNumber = "versionnumber";

			/// <summary>warningtime</summary>
			public const string WarningTime = "warningtime";

			/// <summary>warningtimereached</summary>
			public const string WarningTimeReached = "warningtimereached";

		}
		#endregion

		#region Schemas
		public static class Schemas 
		{
			/// <summary>1:N slakpiinstance_incident_firstresponsebykpi</summary>
			public const string SlakpiinstanceIncidentFirstresponsebykpi = "slakpiinstance_incident_firstresponsebykpi";

			/// <summary>1:N slakpiinstance_incident_resolvebykpi</summary>
			public const string SlakpiinstanceIncidentResolvebykpi = "slakpiinstance_incident_resolvebykpi";

			/// <summary>1:N SLAKPIInstance_SyncErrors</summary>
			public const string SLAKPIInstanceSyncErrors = "SLAKPIInstance_SyncErrors";

		}
		#endregion
	}
}

