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
	[EntityLogicalName("pw_penta_schedule_run")]
	public sealed class PentaScheduleRun : Entity
	{	
		public static readonly int? EntityTypeCode = 10396;
		public new const string LogicalName = "pw_penta_schedule_run";
		public const string PrimaryIdAttribute = "pw_penta_schedule_runid";
		public const string PrimaryNameAttribute = "pw_name";
	
		public PentaScheduleRun() : base("pw_penta_schedule_run") { }

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
				if(Attributes.ContainsKey("createdby") && value == CreatedBy) return;
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
				if(Attributes.ContainsKey("createdbyname") && value == Createdbyname) return;
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
				if(Attributes.ContainsKey("createdbyyominame") && value == Createdbyyominame) return;
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
				if(Attributes.ContainsKey("createdon") && value == CreatedOn) return;
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
				if(Attributes.ContainsKey("createdonbehalfby") && value == CreatedByDelegate) return;
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
				if(Attributes.ContainsKey("createdonbehalfbyname") && value == Createdonbehalfbyname) return;
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
				if(Attributes.ContainsKey("createdonbehalfbyyominame") && value == Createdonbehalfbyyominame) return;
				SetAttributeValue("createdonbehalfbyyominame", value);
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
				if(Attributes.ContainsKey("importsequencenumber") && value == ImportSequenceNumber) return;
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
				if(Attributes.ContainsKey("modifiedby") && value == ModifiedBy) return;
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
				if(Attributes.ContainsKey("modifiedbyname") && value == Modifiedbyname) return;
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
				if(Attributes.ContainsKey("modifiedbyyominame") && value == Modifiedbyyominame) return;
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
				if(Attributes.ContainsKey("modifiedon") && value == ModifiedOn) return;
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
				if(Attributes.ContainsKey("modifiedonbehalfby") && value == ModifiedByDelegate) return;
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
				if(Attributes.ContainsKey("modifiedonbehalfbyname") && value == Modifiedonbehalfbyname) return;
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
				if(Attributes.ContainsKey("modifiedonbehalfbyyominame") && value == Modifiedonbehalfbyyominame) return;
				SetAttributeValue("modifiedonbehalfbyyominame", value);
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
				if(Attributes.ContainsKey("overriddencreatedon") && value == RecordCreatedOn) return;
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
				if(Attributes.ContainsKey("ownerid") && value == Owner) return;
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
				if(Attributes.ContainsKey("owneridname") && value == Owneridname) return;
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
				if(Attributes.ContainsKey("owneridtype") && value == Owneridtype) return;
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
				if(Attributes.ContainsKey("owneridyominame") && value == Owneridyominame) return;
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
				if(Attributes.ContainsKey("owningbusinessunit") && value == OwningBusinessUnit) return;
				SetAttributeValue("owningbusinessunit", value);
			}
		}	
			
		/// <summary>
        /// owningbusinessunitname
        /// </summary>
		[DisplayName("owningbusinessunitname")]
		[AttributeLogicalName("owningbusinessunitname")]
		public string Owningbusinessunitname
		{	
			get { return GetAttributeValue<string>("owningbusinessunitname"); }
			set
			{ 
				if(Attributes.ContainsKey("owningbusinessunitname") && value == Owningbusinessunitname) return;
				SetAttributeValue("owningbusinessunitname", value);
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
				if(Attributes.ContainsKey("owningteam") && value == OwningTeam) return;
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
				if(Attributes.ContainsKey("owninguser") && value == OwningUser) return;
				SetAttributeValue("owninguser", value);
			}
		}	
			
		/// <summary>
        /// pw_current_page
        /// </summary>
		[DisplayName("Current Page")]
		[AttributeLogicalName("pw_current_page")]
		public int? CurrentPage
		{	
			get { return GetAttributeValue<int?>("pw_current_page"); }
			set
			{ 
				if(Attributes.ContainsKey("pw_current_page") && value == CurrentPage) return;
				SetAttributeValue("pw_current_page", value);
			}
		}	
			
		/// <summary>
        /// pw_log
        /// </summary>
		[DisplayName("Log")]
		[AttributeLogicalName("pw_log")]
		public string Log
		{	
			get { return GetAttributeValue<string>("pw_log"); }
			set
			{ 
				if(Attributes.ContainsKey("pw_log") && value == Log) return;
				SetAttributeValue("pw_log", value);
			}
		}	
			
		/// <summary>
        /// pw_name
        /// </summary>
		[DisplayName("Name")]
		[AttributeLogicalName("pw_name")]
		public string Name
		{	
			get { return GetAttributeValue<string>("pw_name"); }
			set
			{ 
				if(Attributes.ContainsKey("pw_name") && value == Name) return;
				SetAttributeValue("pw_name", value);
			}
		}	
			
		/// <summary>
        /// pw_page_size
        /// </summary>
		[DisplayName("Page Size")]
		[AttributeLogicalName("pw_page_size")]
		public int? PageSize
		{	
			get { return GetAttributeValue<int?>("pw_page_size"); }
			set
			{ 
				if(Attributes.ContainsKey("pw_page_size") && value == PageSize) return;
				SetAttributeValue("pw_page_size", value);
			}
		}	
			
		/// <summary>
        /// pw_penta_schedule
        /// </summary>
		[DisplayName("Penta Schedule")]
		[AttributeLogicalName("pw_penta_schedule")]
		public EntityReference PentaSchedule
		{	
			get { return GetAttributeValue<EntityReference>("pw_penta_schedule"); }
			set
			{ 
				if(Attributes.ContainsKey("pw_penta_schedule") && value == PentaSchedule) return;
				SetAttributeValue("pw_penta_schedule", value);
			}
		}	
			
		/// <summary>
        /// pw_penta_schedule_runid
        /// </summary>
		[DisplayName("Penta Schedule Run")]
		[AttributeLogicalName("pw_penta_schedule_runid")]
		public override Guid Id
		{
			get => base.Id;
			set { base.Id = value; SetAttributeValue("pw_penta_schedule_runid", value); }
		}

							/// <summary>
        /// pw_penta_schedulename
        /// </summary>
		[DisplayName("pw_penta_schedulename")]
		[AttributeLogicalName("pw_penta_schedulename")]
		public string PwPentaSchedulename
		{	
			get { return GetAttributeValue<string>("pw_penta_schedulename"); }
			set
			{ 
				if(Attributes.ContainsKey("pw_penta_schedulename") && value == PwPentaSchedulename) return;
				SetAttributeValue("pw_penta_schedulename", value);
			}
		}	
			
		/// <summary>
        /// pw_run_datetime
        /// </summary>
		[DisplayName("Run DateTime")]
		[AttributeLogicalName("pw_run_datetime")]
		public DateTime? RunDateTime
		{	
			get { return GetAttributeValue<DateTime?>("pw_run_datetime"); }
			set
			{ 
				if(Attributes.ContainsKey("pw_run_datetime") && value == RunDateTime) return;
				SetAttributeValue("pw_run_datetime", value);
			}
		}	
			
		/// <summary>
        /// pw_total_pages
        /// </summary>
		[DisplayName("Total Pages")]
		[AttributeLogicalName("pw_total_pages")]
		public int? TotalPages
		{	
			get { return GetAttributeValue<int?>("pw_total_pages"); }
			set
			{ 
				if(Attributes.ContainsKey("pw_total_pages") && value == TotalPages) return;
				SetAttributeValue("pw_total_pages", value);
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
				if(Attributes.ContainsKey("statecode") && value == Status) return;

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
				if(Attributes.ContainsKey("statuscode") && value == StatusReason) return;

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
				if(Attributes.ContainsKey("timezoneruleversionnumber") && value == TimeZoneRuleVersionNumber) return;
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
				if(Attributes.ContainsKey("utcconversiontimezonecode") && value == UTCConversionTimeZoneCode) return;
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
				if(Attributes.ContainsKey("versionnumber") && value == VersionNumber) return;
				SetAttributeValue("versionnumber", value);
			}
		}	
			
		#endregion	

		#region Relations
			/// <summary>
        /// 1:N Get entities for 'pw_penta_schedule_run_AsyncOperations'
        /// </summary>
		[RelationshipSchemaName("pw_penta_schedule_run_AsyncOperations")]
		public IEnumerable<SystemJob> PwPentaScheduleRunAsyncOperations
		{
			get { return GetRelatedEntities<SystemJob>("pw_penta_schedule_run_AsyncOperations", null); }
			set { SetRelatedEntities("pw_penta_schedule_run_AsyncOperations", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'pw_pw_penta_schedule_run_pw_schedule_next_run'
        /// </summary>
		[RelationshipSchemaName("pw_pw_penta_schedule_run_pw_schedule_next_run")]
		public IEnumerable<PentaSchedule> PwPwPentaScheduleRunPwScheduleNextRun
		{
			get { return GetRelatedEntities<PentaSchedule>("pw_pw_penta_schedule_run_pw_schedule_next_run", null); }
			set { SetRelatedEntities("pw_pw_penta_schedule_run_pw_schedule_next_run", null, value); }
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
		
			[Label("Waiting")]
			[Description(@"")]
			Waiting_Active = 1, 
		
			[Label("Waiting (Depth Reset)")]
			[Description(@"")]
			WaitingDepthReset_Active = 266890002, 
		
			[Label("In Progress")]
			[Description(@"")]
			InProgress_Active = 266890000, 
		
			[Label("Ended")]
			[Description(@"")]
			Ended_Inactive = 2, 
		
			[Label("Error")]
			[Description(@"")]
			Error_Inactive = 266890001, 
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

			/// <summary>owningbusinessunitname</summary>
			public const string Owningbusinessunitname = "owningbusinessunitname";

			/// <summary>owningteam</summary>
			public const string OwningTeam = "owningteam";

			/// <summary>owninguser</summary>
			public const string OwningUser = "owninguser";

			/// <summary>pw_current_page</summary>
			public const string CurrentPage = "pw_current_page";

			/// <summary>pw_log</summary>
			public const string Log = "pw_log";

			/// <summary>pw_name</summary>
			public const string Name = "pw_name";

			/// <summary>pw_page_size</summary>
			public const string PageSize = "pw_page_size";

			/// <summary>pw_penta_schedule</summary>
			public const string PentaSchedule = "pw_penta_schedule";

			/// <summary>pw_penta_schedule_runid</summary>
			public const string PentaScheduleRunId = "pw_penta_schedule_runid";

			/// <summary>pw_penta_schedulename</summary>
			public const string PwPentaSchedulename = "pw_penta_schedulename";

			/// <summary>pw_run_datetime</summary>
			public const string RunDateTime = "pw_run_datetime";

			/// <summary>pw_total_pages</summary>
			public const string TotalPages = "pw_total_pages";

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
			/// <summary>1:N pw_penta_schedule_run_AsyncOperations</summary>
			public const string PwPentaScheduleRunAsyncOperations = "pw_penta_schedule_run_AsyncOperations";

			/// <summary>1:N pw_pw_penta_schedule_run_pw_schedule_next_run</summary>
			public const string PwPwPentaScheduleRunPwScheduleNextRun = "pw_pw_penta_schedule_run_pw_schedule_next_run";

		}
		#endregion
	}
}

