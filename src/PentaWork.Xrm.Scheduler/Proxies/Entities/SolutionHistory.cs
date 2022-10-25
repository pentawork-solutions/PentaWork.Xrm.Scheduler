using System;
using System.Linq;
using System.Diagnostics;
using System.ComponentModel;
using Microsoft.Xrm.Sdk; 
using Microsoft.Xrm.Sdk.Client;
using System.Collections.Generic;

namespace PentaWork.Xrm.Scheduler.Proxies.Entities
{
	[DebuggerDisplay("{SolutionName}")] 	
	[EntityLogicalName("msdyn_solutionhistory")]
	public sealed class SolutionHistory : Entity
	{	
		public static readonly int? EntityTypeCode = 10000;
		public new const string LogicalName = "msdyn_solutionhistory";
		public const string PrimaryIdAttribute = "msdyn_solutionhistoryid";
		public const string PrimaryNameAttribute = "msdyn_name";
	
		public SolutionHistory() : base("msdyn_solutionhistory") { }

		#region Attributes
		/// <summary>
        /// msdyn_activityid
        /// </summary>
		[DisplayName("Activity Id")]
		[AttributeLogicalName("msdyn_activityid")]
		public string ActivityId
		{	
			get { return GetAttributeValue<string>("msdyn_activityid"); }
			set
			{ 
				if(value == ActivityId) return;
				SetAttributeValue("msdyn_activityid", value);
			}
		}	
			
		/// <summary>
        /// msdyn_correlationid
        /// </summary>
		[DisplayName("Correlation Id")]
		[AttributeLogicalName("msdyn_correlationid")]
		public string CorrelationId
		{	
			get { return GetAttributeValue<string>("msdyn_correlationid"); }
			set
			{ 
				if(value == CorrelationId) return;
				SetAttributeValue("msdyn_correlationid", value);
			}
		}	
			
		/// <summary>
        /// msdyn_endtime
        /// </summary>
		[DisplayName("End Time")]
		[AttributeLogicalName("msdyn_endtime")]
		public DateTime? EndTime
		{	
			get { return GetAttributeValue<DateTime?>("msdyn_endtime"); }
			set
			{ 
				if(value == EndTime) return;
				SetAttributeValue("msdyn_endtime", value);
			}
		}	
			
		/// <summary>
        /// msdyn_errorcode
        /// </summary>
		[DisplayName("Error Code")]
		[AttributeLogicalName("msdyn_errorcode")]
		public string ErrorCode
		{	
			get { return GetAttributeValue<string>("msdyn_errorcode"); }
			set
			{ 
				if(value == ErrorCode) return;
				SetAttributeValue("msdyn_errorcode", value);
			}
		}	
			
		/// <summary>
        /// msdyn_exceptionmessage
        /// </summary>
		[DisplayName("Exception Message")]
		[AttributeLogicalName("msdyn_exceptionmessage")]
		public string ExceptionMessage
		{	
			get { return GetAttributeValue<string>("msdyn_exceptionmessage"); }
			set
			{ 
				if(value == ExceptionMessage) return;
				SetAttributeValue("msdyn_exceptionmessage", value);
			}
		}	
			
		/// <summary>
        /// msdyn_exceptionstack
        /// </summary>
		[DisplayName("Exception Stack")]
		[AttributeLogicalName("msdyn_exceptionstack")]
		public string ExceptionStack
		{	
			get { return GetAttributeValue<string>("msdyn_exceptionstack"); }
			set
			{ 
				if(value == ExceptionStack) return;
				SetAttributeValue("msdyn_exceptionstack", value);
			}
		}	
			
		/// <summary>
        /// msdyn_ismanaged
        /// </summary>
		[DisplayName("Managed")]
		[AttributeLogicalName("msdyn_ismanaged")]
		public bool? Managed
		{	
			get { return GetAttributeValue<bool?>("msdyn_ismanaged"); }
			set
			{ 
				if(value == Managed) return;
				SetAttributeValue("msdyn_ismanaged", value);
			}
		}	
			
		/// <summary>
        /// msdyn_isoverwritecustomizations
        /// </summary>
		[DisplayName("Overwrite Customizations")]
		[AttributeLogicalName("msdyn_isoverwritecustomizations")]
		public bool? OverwriteCustomizations
		{	
			get { return GetAttributeValue<bool?>("msdyn_isoverwritecustomizations"); }
			set
			{ 
				if(value == OverwriteCustomizations) return;
				SetAttributeValue("msdyn_isoverwritecustomizations", value);
			}
		}	
			
		/// <summary>
        /// msdyn_ispatch
        /// </summary>
		[DisplayName("Patch")]
		[AttributeLogicalName("msdyn_ispatch")]
		public bool? Patch
		{	
			get { return GetAttributeValue<bool?>("msdyn_ispatch"); }
			set
			{ 
				if(value == Patch) return;
				SetAttributeValue("msdyn_ispatch", value);
			}
		}	
			
		/// <summary>
        /// msdyn_name
        /// </summary>
		[DisplayName("Solution Name")]
		[AttributeLogicalName("msdyn_name")]
		public string SolutionName
		{	
			get { return GetAttributeValue<string>("msdyn_name"); }
			set
			{ 
				if(value == SolutionName) return;
				SetAttributeValue("msdyn_name", value);
			}
		}	
			
		/// <summary>
        /// msdyn_operation
        /// </summary>
		[DisplayName("Operation")]
		[AttributeLogicalName("msdyn_operation")]
		public eMsdynOperation? Operation
		{	
			get 
			{ 
				var optionSetValue = GetAttributeValue<OptionSetValue>("msdyn_operation");
				if (optionSetValue != null) return (eMsdynOperation)optionSetValue.Value;
				else return null;
			}
			set 
			{ 
				if(value == Operation) return;

				OptionSetValue optionSetValue = null;
				if(value != null) optionSetValue = new OptionSetValue((int)value);
				SetAttributeValue("msdyn_operation", optionSetValue); 
			}
		}

		/// <summary>
        /// msdyn_packagename
        /// </summary>
		[DisplayName("Package Name")]
		[AttributeLogicalName("msdyn_packagename")]
		public string PackageName
		{	
			get { return GetAttributeValue<string>("msdyn_packagename"); }
			set
			{ 
				if(value == PackageName) return;
				SetAttributeValue("msdyn_packagename", value);
			}
		}	
			
		/// <summary>
        /// msdyn_packageversion
        /// </summary>
		[DisplayName("Package Version")]
		[AttributeLogicalName("msdyn_packageversion")]
		public string PackageVersion
		{	
			get { return GetAttributeValue<string>("msdyn_packageversion"); }
			set
			{ 
				if(value == PackageVersion) return;
				SetAttributeValue("msdyn_packageversion", value);
			}
		}	
			
		/// <summary>
        /// msdyn_publisherid
        /// </summary>
		[DisplayName("Publisher Id")]
		[AttributeLogicalName("msdyn_publisherid")]
		public string PublisherId
		{	
			get { return GetAttributeValue<string>("msdyn_publisherid"); }
			set
			{ 
				if(value == PublisherId) return;
				SetAttributeValue("msdyn_publisherid", value);
			}
		}	
			
		/// <summary>
        /// msdyn_publishername
        /// </summary>
		[DisplayName("Publisher Name")]
		[AttributeLogicalName("msdyn_publishername")]
		public string PublisherName
		{	
			get { return GetAttributeValue<string>("msdyn_publishername"); }
			set
			{ 
				if(value == PublisherName) return;
				SetAttributeValue("msdyn_publishername", value);
			}
		}	
			
		/// <summary>
        /// msdyn_result
        /// </summary>
		[DisplayName("Result")]
		[AttributeLogicalName("msdyn_result")]
		public bool? Result
		{	
			get { return GetAttributeValue<bool?>("msdyn_result"); }
			set
			{ 
				if(value == Result) return;
				SetAttributeValue("msdyn_result", value);
			}
		}	
			
		/// <summary>
        /// msdyn_solutionhistoryid
        /// </summary>
		[DisplayName("Solutionhistory")]
		[AttributeLogicalName("msdyn_solutionhistoryid")]
		public override Guid Id
		{
			get => base.Id;
			set { base.Id = value; SetAttributeValue("msdyn_solutionhistoryid", value); }
		}

							/// <summary>
        /// msdyn_solutionid
        /// </summary>
		[DisplayName("Solution Id")]
		[AttributeLogicalName("msdyn_solutionid")]
		public string SolutionId
		{	
			get { return GetAttributeValue<string>("msdyn_solutionid"); }
			set
			{ 
				if(value == SolutionId) return;
				SetAttributeValue("msdyn_solutionid", value);
			}
		}	
			
		/// <summary>
        /// msdyn_solutionversion
        /// </summary>
		[DisplayName("Solution Version")]
		[AttributeLogicalName("msdyn_solutionversion")]
		public string SolutionVersion
		{	
			get { return GetAttributeValue<string>("msdyn_solutionversion"); }
			set
			{ 
				if(value == SolutionVersion) return;
				SetAttributeValue("msdyn_solutionversion", value);
			}
		}	
			
		/// <summary>
        /// msdyn_starttime
        /// </summary>
		[DisplayName("Start Time")]
		[AttributeLogicalName("msdyn_starttime")]
		public DateTime? StartTime
		{	
			get { return GetAttributeValue<DateTime?>("msdyn_starttime"); }
			set
			{ 
				if(value == StartTime) return;
				SetAttributeValue("msdyn_starttime", value);
			}
		}	
			
		/// <summary>
        /// msdyn_status
        /// </summary>
		[DisplayName("Status")]
		[AttributeLogicalName("msdyn_status")]
		public eMsdynStatus? Status
		{	
			get 
			{ 
				var optionSetValue = GetAttributeValue<OptionSetValue>("msdyn_status");
				if (optionSetValue != null) return (eMsdynStatus)optionSetValue.Value;
				else return null;
			}
			set 
			{ 
				if(value == Status) return;

				OptionSetValue optionSetValue = null;
				if(value != null) optionSetValue = new OptionSetValue((int)value);
				SetAttributeValue("msdyn_status", optionSetValue); 
			}
		}

		/// <summary>
        /// msdyn_suboperation
        /// </summary>
		[DisplayName("Suboperation")]
		[AttributeLogicalName("msdyn_suboperation")]
		public eMsdynSuboperation? Suboperation
		{	
			get 
			{ 
				var optionSetValue = GetAttributeValue<OptionSetValue>("msdyn_suboperation");
				if (optionSetValue != null) return (eMsdynSuboperation)optionSetValue.Value;
				else return null;
			}
			set 
			{ 
				if(value == Suboperation) return;

				OptionSetValue optionSetValue = null;
				if(value != null) optionSetValue = new OptionSetValue((int)value);
				SetAttributeValue("msdyn_suboperation", optionSetValue); 
			}
		}

		/// <summary>
        /// msdyn_totaltime
        /// </summary>
		[DisplayName("Total Time (seconds)")]
		[AttributeLogicalName("msdyn_totaltime")]
		public int? TotalTimeseconds
		{	
			get { return GetAttributeValue<int?>("msdyn_totaltime"); }
			set
			{ 
				if(value == TotalTimeseconds) return;
				SetAttributeValue("msdyn_totaltime", value);
			}
		}	
			
		#endregion	

		#region Relations
			#endregion

		#region Actions
		#endregion

		#region OptionSetEnums
		public enum eMsdynOperation
		{	
		
			[Label("Import")]
			[Description(@"")]
			Import = 0, 
		
			[Label("Uninstall")]
			[Description(@"")]
			Uninstall = 1, 
		
			[Label("Export")]
			[Description(@"")]
			Export = 2, 
		
			[Label("Publish")]
			[Description(@"")]
			Publish = 3, 
		
			[Label("PublishAll")]
			[Description(@"")]
			PublishAll = 4, 
		
			[Label("LanguageProvision")]
			[Description(@"")]
			LanguageProvision = 5, 
		
			[Label("ImportTranslation")]
			[Description(@"")]
			ImportTranslation = 6, 
		
			[Label("RibbonMetadataGeneration")]
			[Description(@"")]
			RibbonMetadataGeneration = 7, 
		
			[Label("WorkflowSetState")]
			[Description(@"")]
			WorkflowSetState = 8, 
		
			[Label("None")]
			[Description(@"")]
			None = 9, 
		}
		
		public enum eMsdynStatus
		{	
		
			[Label("Started")]
			[Description(@"")]
			Started = 0, 
		
			[Label("Completed")]
			[Description(@"")]
			Completed = 1, 
		}
		
		public enum eMsdynSuboperation
		{	
		
			[Label("None")]
			[Description(@"")]
			None = 0, 
		
			[Label("New")]
			[Description(@"")]
			New = 1, 
		
			[Label("Upgrade")]
			[Description(@"")]
			Upgrade = 2, 
		
			[Label("Update")]
			[Description(@"")]
			Update = 3, 
		
			[Label("Delete")]
			[Description(@"")]
			Delete = 4, 
		}
		
		#endregion	

		#region Properties
		public static class Properties 
		{
			/// <summary>msdyn_activityid</summary>
			public const string ActivityId = "msdyn_activityid";

			/// <summary>msdyn_correlationid</summary>
			public const string CorrelationId = "msdyn_correlationid";

			/// <summary>msdyn_endtime</summary>
			public const string EndTime = "msdyn_endtime";

			/// <summary>msdyn_errorcode</summary>
			public const string ErrorCode = "msdyn_errorcode";

			/// <summary>msdyn_exceptionmessage</summary>
			public const string ExceptionMessage = "msdyn_exceptionmessage";

			/// <summary>msdyn_exceptionstack</summary>
			public const string ExceptionStack = "msdyn_exceptionstack";

			/// <summary>msdyn_ismanaged</summary>
			public const string Managed = "msdyn_ismanaged";

			/// <summary>msdyn_isoverwritecustomizations</summary>
			public const string OverwriteCustomizations = "msdyn_isoverwritecustomizations";

			/// <summary>msdyn_ispatch</summary>
			public const string Patch = "msdyn_ispatch";

			/// <summary>msdyn_name</summary>
			public const string SolutionName = "msdyn_name";

			/// <summary>msdyn_operation</summary>
			public const string Operation = "msdyn_operation";

			/// <summary>msdyn_packagename</summary>
			public const string PackageName = "msdyn_packagename";

			/// <summary>msdyn_packageversion</summary>
			public const string PackageVersion = "msdyn_packageversion";

			/// <summary>msdyn_publisherid</summary>
			public const string PublisherId = "msdyn_publisherid";

			/// <summary>msdyn_publishername</summary>
			public const string PublisherName = "msdyn_publishername";

			/// <summary>msdyn_result</summary>
			public const string Result = "msdyn_result";

			/// <summary>msdyn_solutionhistoryid</summary>
			public const string SolutionhistoryId = "msdyn_solutionhistoryid";

			/// <summary>msdyn_solutionid</summary>
			public const string SolutionId = "msdyn_solutionid";

			/// <summary>msdyn_solutionversion</summary>
			public const string SolutionVersion = "msdyn_solutionversion";

			/// <summary>msdyn_starttime</summary>
			public const string StartTime = "msdyn_starttime";

			/// <summary>msdyn_status</summary>
			public const string Status = "msdyn_status";

			/// <summary>msdyn_suboperation</summary>
			public const string Suboperation = "msdyn_suboperation";

			/// <summary>msdyn_totaltime</summary>
			public const string TotalTimeseconds = "msdyn_totaltime";

		}
		#endregion

		#region Schemas
		public static class Schemas 
		{
		}
		#endregion
	}
}

