using System;
using System.Linq;
using System.Diagnostics;
using System.ComponentModel;
using Microsoft.Xrm.Sdk; 
using Microsoft.Xrm.Sdk.Client;
using System.Collections.Generic;

namespace PentaWork.Xrm.Scheduler.Proxies.Entities
{
	
	[EntityLogicalName("solutionhistorydata")]
	public sealed class SolutionHistoryData : Entity
	{	
		public static readonly int? EntityTypeCode = 9890;
		public new const string LogicalName = "solutionhistorydata";
		public const string PrimaryIdAttribute = "solutionhistorydataid";
		public const string PrimaryNameAttribute = "";
	
		public SolutionHistoryData() : base("solutionhistorydata") { }

		#region Attributes
		/// <summary>
        /// activityid
        /// </summary>
		[DisplayName("The Activity Id")]
		[AttributeLogicalName("activityid")]
		public Guid TheActivityId
		{	
			get { return GetAttributeValue<Guid>("activityid"); }
			set
			{ 
				if(value == TheActivityId) return;
				SetAttributeValue("activityid", value);
			}
		}	
			
		/// <summary>
        /// correlationid
        /// </summary>
		[DisplayName("The Correlation Id")]
		[AttributeLogicalName("correlationid")]
		public Guid TheCorrelationId
		{	
			get { return GetAttributeValue<Guid>("correlationid"); }
			set
			{ 
				if(value == TheCorrelationId) return;
				SetAttributeValue("correlationid", value);
			}
		}	
			
		/// <summary>
        /// endtime
        /// </summary>
		[DisplayName("End Time")]
		[AttributeLogicalName("endtime")]
		public DateTime? EndTime
		{	
			get { return GetAttributeValue<DateTime?>("endtime"); }
			set
			{ 
				if(value == EndTime) return;
				SetAttributeValue("endtime", value);
			}
		}	
			
		/// <summary>
        /// errorcode
        /// </summary>
		[DisplayName("ErrorCode")]
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
        /// exceptionmessage
        /// </summary>
		[DisplayName("ExceptionMessage")]
		[AttributeLogicalName("exceptionmessage")]
		public string ExceptionMessage
		{	
			get { return GetAttributeValue<string>("exceptionmessage"); }
			set
			{ 
				if(value == ExceptionMessage) return;
				SetAttributeValue("exceptionmessage", value);
			}
		}	
			
		/// <summary>
        /// exceptionstack
        /// </summary>
		[DisplayName("ExceptionStack")]
		[AttributeLogicalName("exceptionstack")]
		public string ExceptionStack
		{	
			get { return GetAttributeValue<string>("exceptionstack"); }
			set
			{ 
				if(value == ExceptionStack) return;
				SetAttributeValue("exceptionstack", value);
			}
		}	
			
		/// <summary>
        /// ismanaged
        /// </summary>
		[DisplayName("Is Solution Managed")]
		[AttributeLogicalName("ismanaged")]
		public bool? IsSolutionManaged
		{	
			get { return GetAttributeValue<bool?>("ismanaged"); }
			set
			{ 
				if(value == IsSolutionManaged) return;
				SetAttributeValue("ismanaged", value);
			}
		}	
			
		/// <summary>
        /// ismicrosoftpublisher
        /// </summary>
		[DisplayName("Is Published by Microsoft")]
		[AttributeLogicalName("ismicrosoftpublisher")]
		public bool? IsPublishedByMicrosoft
		{	
			get { return GetAttributeValue<bool?>("ismicrosoftpublisher"); }
			set
			{ 
				if(value == IsPublishedByMicrosoft) return;
				SetAttributeValue("ismicrosoftpublisher", value);
			}
		}	
			
		/// <summary>
        /// isoverwritecustomizations
        /// </summary>
		[DisplayName("Is Overwrite Customizations")]
		[AttributeLogicalName("isoverwritecustomizations")]
		public bool? IsOverwriteCustomizations
		{	
			get { return GetAttributeValue<bool?>("isoverwritecustomizations"); }
			set
			{ 
				if(value == IsOverwriteCustomizations) return;
				SetAttributeValue("isoverwritecustomizations", value);
			}
		}	
			
		/// <summary>
        /// ispatch
        /// </summary>
		[DisplayName("Is Solution Patch")]
		[AttributeLogicalName("ispatch")]
		public bool? IsSolutionPatch
		{	
			get { return GetAttributeValue<bool?>("ispatch"); }
			set
			{ 
				if(value == IsSolutionPatch) return;
				SetAttributeValue("ispatch", value);
			}
		}	
			
		/// <summary>
        /// operation
        /// </summary>
		[DisplayName("Operation")]
		[AttributeLogicalName("operation")]
		public eOperation? Operation
		{	
			get 
			{ 
				var optionSetValue = GetAttributeValue<OptionSetValue>("operation");
				if (optionSetValue != null) return (eOperation)optionSetValue.Value;
				else return null;
			}
			set 
			{ 
				if(value == Operation) return;

				OptionSetValue optionSetValue = null;
				if(value != null) optionSetValue = new OptionSetValue((int)value);
				SetAttributeValue("operation", optionSetValue); 
			}
		}

		/// <summary>
        /// packagename
        /// </summary>
		[DisplayName("PackageName")]
		[AttributeLogicalName("packagename")]
		public string PackageName
		{	
			get { return GetAttributeValue<string>("packagename"); }
			set
			{ 
				if(value == PackageName) return;
				SetAttributeValue("packagename", value);
			}
		}	
			
		/// <summary>
        /// packageversion
        /// </summary>
		[DisplayName("PackageVersion")]
		[AttributeLogicalName("packageversion")]
		public string PackageVersion
		{	
			get { return GetAttributeValue<string>("packageversion"); }
			set
			{ 
				if(value == PackageVersion) return;
				SetAttributeValue("packageversion", value);
			}
		}	
			
		/// <summary>
        /// publishername
        /// </summary>
		[DisplayName("PublisherName")]
		[AttributeLogicalName("publishername")]
		public string PublisherName
		{	
			get { return GetAttributeValue<string>("publishername"); }
			set
			{ 
				if(value == PublisherName) return;
				SetAttributeValue("publishername", value);
			}
		}	
			
		/// <summary>
        /// result
        /// </summary>
		[DisplayName("Result")]
		[AttributeLogicalName("result")]
		public int? Result
		{	
			get { return GetAttributeValue<int?>("result"); }
			set
			{ 
				if(value == Result) return;
				SetAttributeValue("result", value);
			}
		}	
			
		/// <summary>
        /// solutionhistorydataid
        /// </summary>
		[DisplayName("SolutionHistoryDataId")]
		[AttributeLogicalName("solutionhistorydataid")]
		public override Guid Id
		{
			get => base.Id;
			set { base.Id = value; SetAttributeValue("solutionhistorydataid", value); }
		}

							/// <summary>
        /// solutionid
        /// </summary>
		[DisplayName("The Solution")]
		[AttributeLogicalName("solutionid")]
		public Guid TheSolutionId
		{	
			get { return GetAttributeValue<Guid>("solutionid"); }
			set
			{ 
				if(value == TheSolutionId) return;
				SetAttributeValue("solutionid", value);
			}
		}	
			
		/// <summary>
        /// solutionname
        /// </summary>
		[DisplayName("SolutionName")]
		[AttributeLogicalName("solutionname")]
		public string SolutionName
		{	
			get { return GetAttributeValue<string>("solutionname"); }
			set
			{ 
				if(value == SolutionName) return;
				SetAttributeValue("solutionname", value);
			}
		}	
			
		/// <summary>
        /// solutionversion
        /// </summary>
		[DisplayName("SolutionVersion")]
		[AttributeLogicalName("solutionversion")]
		public string SolutionVersion
		{	
			get { return GetAttributeValue<string>("solutionversion"); }
			set
			{ 
				if(value == SolutionVersion) return;
				SetAttributeValue("solutionversion", value);
			}
		}	
			
		/// <summary>
        /// starttime
        /// </summary>
		[DisplayName("Start Time")]
		[AttributeLogicalName("starttime")]
		public DateTime? StartTime
		{	
			get { return GetAttributeValue<DateTime?>("starttime"); }
			set
			{ 
				if(value == StartTime) return;
				SetAttributeValue("starttime", value);
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
        /// suboperation
        /// </summary>
		[DisplayName("SubOperation")]
		[AttributeLogicalName("suboperation")]
		public eSubOperation? SubOperation
		{	
			get 
			{ 
				var optionSetValue = GetAttributeValue<OptionSetValue>("suboperation");
				if (optionSetValue != null) return (eSubOperation)optionSetValue.Value;
				else return null;
			}
			set 
			{ 
				if(value == SubOperation) return;

				OptionSetValue optionSetValue = null;
				if(value != null) optionSetValue = new OptionSetValue((int)value);
				SetAttributeValue("suboperation", optionSetValue); 
			}
		}

		#endregion	

		#region Relations
			#endregion

		#region Actions
		#endregion

		#region OptionSetEnums
		public enum eOperation
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
		}
		
		public enum eStatus
		{	
		
			[Label("Start")]
			[Description(@"")]
			Start = 0, 
		
			[Label("End")]
			[Description(@"")]
			End = 1, 
		}
		
		public enum eSubOperation
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
			/// <summary>activityid</summary>
			public const string TheActivityId = "activityid";

			/// <summary>correlationid</summary>
			public const string TheCorrelationId = "correlationid";

			/// <summary>endtime</summary>
			public const string EndTime = "endtime";

			/// <summary>errorcode</summary>
			public const string ErrorCode = "errorcode";

			/// <summary>exceptionmessage</summary>
			public const string ExceptionMessage = "exceptionmessage";

			/// <summary>exceptionstack</summary>
			public const string ExceptionStack = "exceptionstack";

			/// <summary>ismanaged</summary>
			public const string IsSolutionManaged = "ismanaged";

			/// <summary>ismicrosoftpublisher</summary>
			public const string IsPublishedByMicrosoft = "ismicrosoftpublisher";

			/// <summary>isoverwritecustomizations</summary>
			public const string IsOverwriteCustomizations = "isoverwritecustomizations";

			/// <summary>ispatch</summary>
			public const string IsSolutionPatch = "ispatch";

			/// <summary>operation</summary>
			public const string Operation = "operation";

			/// <summary>packagename</summary>
			public const string PackageName = "packagename";

			/// <summary>packageversion</summary>
			public const string PackageVersion = "packageversion";

			/// <summary>publishername</summary>
			public const string PublisherName = "publishername";

			/// <summary>result</summary>
			public const string Result = "result";

			/// <summary>solutionhistorydataid</summary>
			public const string SolutionHistoryDataId = "solutionhistorydataid";

			/// <summary>solutionid</summary>
			public const string TheSolutionId = "solutionid";

			/// <summary>solutionname</summary>
			public const string SolutionName = "solutionname";

			/// <summary>solutionversion</summary>
			public const string SolutionVersion = "solutionversion";

			/// <summary>starttime</summary>
			public const string StartTime = "starttime";

			/// <summary>status</summary>
			public const string Status = "status";

			/// <summary>suboperation</summary>
			public const string SubOperation = "suboperation";

		}
		#endregion

		#region Schemas
		public static class Schemas 
		{
		}
		#endregion
	}
}

