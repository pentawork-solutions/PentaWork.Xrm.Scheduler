using System;
using System.Linq;
using System.Diagnostics;
using System.ComponentModel;
using Microsoft.Xrm.Sdk; 
using Microsoft.Xrm.Sdk.Client;
using System.Collections.Generic;

namespace PentaWork.Xrm.Scheduler.Proxies.Entities
{
	
	[EntityLogicalName("ribbonmetadatatoprocess")]
	public sealed class RibbonMetadataToProcess : Entity
	{	
		public static readonly int? EntityTypeCode = 9880;
		public new const string LogicalName = "ribbonmetadatatoprocess";
		public const string PrimaryIdAttribute = "ribbonmetadatarowid";
		public const string PrimaryNameAttribute = "";
	
		public RibbonMetadataToProcess() : base("ribbonmetadatatoprocess") { }

		#region Attributes
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
        /// entityname
        /// </summary>
		[DisplayName("Entity Logical Name")]
		[AttributeLogicalName("entityname")]
		public string EntityLogicalName
		{	
			get { return GetAttributeValue<string>("entityname"); }
			set
			{ 
				if(value == EntityLogicalName) return;
				SetAttributeValue("entityname", value);
			}
		}	
			
		/// <summary>
        /// exceptionmessage
        /// </summary>
		[DisplayName("Exception message which occurred during ribbon entity processing.")]
		[AttributeLogicalName("exceptionmessage")]
		public string ExceptionMessageWhichOccurredDuringRibbonEntityProcessing
		{	
			get { return GetAttributeValue<string>("exceptionmessage"); }
			set
			{ 
				if(value == ExceptionMessageWhichOccurredDuringRibbonEntityProcessing) return;
				SetAttributeValue("exceptionmessage", value);
			}
		}	
			
		/// <summary>
        /// isdbupdate
        /// </summary>
		[DisplayName("Is entity created via Db Update")]
		[AttributeLogicalName("isdbupdate")]
		public int? IsEntityCreatedViaDbUpdate
		{	
			get { return GetAttributeValue<int?>("isdbupdate"); }
			set
			{ 
				if(value == IsEntityCreatedViaDbUpdate) return;
				SetAttributeValue("isdbupdate", value);
			}
		}	
			
		/// <summary>
        /// processedon
        /// </summary>
		[DisplayName("Processed On")]
		[AttributeLogicalName("processedon")]
		public DateTime? ProcessedOn
		{	
			get { return GetAttributeValue<DateTime?>("processedon"); }
			set
			{ 
				if(value == ProcessedOn) return;
				SetAttributeValue("processedon", value);
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
        /// ribbonmetadatarowid
        /// </summary>
		[DisplayName("Ribbon Metadata To Process")]
		[AttributeLogicalName("ribbonmetadatarowid")]
		public override Guid Id
		{
			get => base.Id;
			set { base.Id = value; SetAttributeValue("ribbonmetadatarowid", value); }
		}

							/// <summary>
        /// solutionid
        /// </summary>
		[DisplayName("Solution Id")]
		[AttributeLogicalName("solutionid")]
		public Guid SolutionId
		{	
			get { return GetAttributeValue<Guid>("solutionid"); }
			set
			{ 
				if(value == SolutionId) return;
				SetAttributeValue("solutionid", value);
			}
		}	
			
		/// <summary>
        /// solutionname
        /// </summary>
		[DisplayName("Solution Name of the ribbon entity.")]
		[AttributeLogicalName("solutionname")]
		public string SolutionNameOfTheRibbonEntity
		{	
			get { return GetAttributeValue<string>("solutionname"); }
			set
			{ 
				if(value == SolutionNameOfTheRibbonEntity) return;
				SetAttributeValue("solutionname", value);
			}
		}	
			
		/// <summary>
        /// status
        /// </summary>
		[DisplayName("Status")]
		[AttributeLogicalName("status")]
		public int? Status
		{	
			get { return GetAttributeValue<int?>("status"); }
			set
			{ 
				if(value == Status) return;
				SetAttributeValue("status", value);
			}
		}	
			
		#endregion	

		#region Relations
			#endregion

		#region Actions
		#endregion

		#region OptionSetEnums
		#endregion	

		#region Properties
		public static class Properties 
		{
			/// <summary>completedon</summary>
			public const string CompletedOn = "completedon";

			/// <summary>createdon</summary>
			public const string CreatedOn = "createdon";

			/// <summary>entityname</summary>
			public const string EntityLogicalName = "entityname";

			/// <summary>exceptionmessage</summary>
			public const string ExceptionMessageWhichOccurredDuringRibbonEntityProcessing = "exceptionmessage";

			/// <summary>isdbupdate</summary>
			public const string IsEntityCreatedViaDbUpdate = "isdbupdate";

			/// <summary>processedon</summary>
			public const string ProcessedOn = "processedon";

			/// <summary>retrycount</summary>
			public const string RetryCount = "retrycount";

			/// <summary>ribbonmetadatarowid</summary>
			public const string RibbonMetadataToProcessId = "ribbonmetadatarowid";

			/// <summary>solutionid</summary>
			public const string SolutionId = "solutionid";

			/// <summary>solutionname</summary>
			public const string SolutionNameOfTheRibbonEntity = "solutionname";

			/// <summary>status</summary>
			public const string Status = "status";

		}
		#endregion

		#region Schemas
		public static class Schemas 
		{
		}
		#endregion
	}
}

