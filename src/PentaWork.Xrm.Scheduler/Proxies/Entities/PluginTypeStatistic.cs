using System;
using System.Linq;
using System.Diagnostics;
using System.ComponentModel;
using Microsoft.Xrm.Sdk; 
using Microsoft.Xrm.Sdk.Client;
using System.Collections.Generic;

namespace PentaWork.Xrm.Scheduler.Proxies.Entities
{
	
	[EntityLogicalName("plugintypestatistic")]
	public sealed class PluginTypeStatistic : Entity
	{	
		public static readonly int? EntityTypeCode = 4603;
		public new const string LogicalName = "plugintypestatistic";
		public const string PrimaryIdAttribute = "plugintypestatisticid";
		public const string PrimaryNameAttribute = "";
	
		public PluginTypeStatistic() : base("plugintypestatistic") { }

		#region Attributes
		/// <summary>
        /// averageexecutetimeinmilliseconds
        /// </summary>
		[DisplayName("The average execution time")]
		[AttributeLogicalName("averageexecutetimeinmilliseconds")]
		public int? TheAverageExecutionTime
		{	
			get { return GetAttributeValue<int?>("averageexecutetimeinmilliseconds"); }
			set
			{ 
				if(value == TheAverageExecutionTime) return;
				SetAttributeValue("averageexecutetimeinmilliseconds", value);
			}
		}	
			
		/// <summary>
        /// crashcontributionpercent
        /// </summary>
		[DisplayName("Percentage contribution to crashes")]
		[AttributeLogicalName("crashcontributionpercent")]
		public int? PercentageContributionToCrashes
		{	
			get { return GetAttributeValue<int?>("crashcontributionpercent"); }
			set
			{ 
				if(value == PercentageContributionToCrashes) return;
				SetAttributeValue("crashcontributionpercent", value);
			}
		}	
			
		/// <summary>
        /// crashcount
        /// </summary>
		[DisplayName("Number of times crashed")]
		[AttributeLogicalName("crashcount")]
		public int? NumberOfTimesCrashed
		{	
			get { return GetAttributeValue<int?>("crashcount"); }
			set
			{ 
				if(value == NumberOfTimesCrashed) return;
				SetAttributeValue("crashcount", value);
			}
		}	
			
		/// <summary>
        /// crashpercent
        /// </summary>
		[DisplayName("Percentage of crashes")]
		[AttributeLogicalName("crashpercent")]
		public int? PercentageOfCrashes
		{	
			get { return GetAttributeValue<int?>("crashpercent"); }
			set
			{ 
				if(value == PercentageOfCrashes) return;
				SetAttributeValue("crashpercent", value);
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
        /// executecount
        /// </summary>
		[DisplayName("Execution Count")]
		[AttributeLogicalName("executecount")]
		public int? ExecutionCount
		{	
			get { return GetAttributeValue<int?>("executecount"); }
			set
			{ 
				if(value == ExecutionCount) return;
				SetAttributeValue("executecount", value);
			}
		}	
			
		/// <summary>
        /// failurecount
        /// </summary>
		[DisplayName("Failure Count")]
		[AttributeLogicalName("failurecount")]
		public int? FailureCount
		{	
			get { return GetAttributeValue<int?>("failurecount"); }
			set
			{ 
				if(value == FailureCount) return;
				SetAttributeValue("failurecount", value);
			}
		}	
			
		/// <summary>
        /// failurepercent
        /// </summary>
		[DisplayName("Failure Percent")]
		[AttributeLogicalName("failurepercent")]
		public int? FailurePercent
		{	
			get { return GetAttributeValue<int?>("failurepercent"); }
			set
			{ 
				if(value == FailurePercent) return;
				SetAttributeValue("failurepercent", value);
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
        /// organizationid
        /// </summary>
		[DisplayName("organizationid")]
		[AttributeLogicalName("organizationid")]
		public EntityReference Organizationid
		{	
			get { return GetAttributeValue<EntityReference>("organizationid"); }
			set
			{ 
				if(value == Organizationid) return;
				SetAttributeValue("organizationid", value);
			}
		}	
			
		/// <summary>
        /// plugintypeid
        /// </summary>
		[DisplayName("Plugin Type")]
		[AttributeLogicalName("plugintypeid")]
		public EntityReference PluginType
		{	
			get { return GetAttributeValue<EntityReference>("plugintypeid"); }
			set
			{ 
				if(value == PluginType) return;
				SetAttributeValue("plugintypeid", value);
			}
		}	
			
		/// <summary>
        /// plugintypeidname
        /// </summary>
		[DisplayName("plugintypeidname")]
		[AttributeLogicalName("plugintypeidname")]
		public string Plugintypeidname
		{	
			get { return GetAttributeValue<string>("plugintypeidname"); }
			set
			{ 
				if(value == Plugintypeidname) return;
				SetAttributeValue("plugintypeidname", value);
			}
		}	
			
		/// <summary>
        /// plugintypestatisticid
        /// </summary>
		[DisplayName("plugintypestatisticid")]
		[AttributeLogicalName("plugintypestatisticid")]
		public override Guid Id
		{
			get => base.Id;
			set { base.Id = value; SetAttributeValue("plugintypestatisticid", value); }
		}

							/// <summary>
        /// terminatecpucontributionpercent
        /// </summary>
		[DisplayName("Terminate CPU Contribution Percent")]
		[AttributeLogicalName("terminatecpucontributionpercent")]
		public int? TerminateCPUContributionPercent
		{	
			get { return GetAttributeValue<int?>("terminatecpucontributionpercent"); }
			set
			{ 
				if(value == TerminateCPUContributionPercent) return;
				SetAttributeValue("terminatecpucontributionpercent", value);
			}
		}	
			
		/// <summary>
        /// terminatehandlescontributionpercent
        /// </summary>
		[DisplayName("Terminate Handles Contribution Percent")]
		[AttributeLogicalName("terminatehandlescontributionpercent")]
		public int? TerminateHandlesContributionPercent
		{	
			get { return GetAttributeValue<int?>("terminatehandlescontributionpercent"); }
			set
			{ 
				if(value == TerminateHandlesContributionPercent) return;
				SetAttributeValue("terminatehandlescontributionpercent", value);
			}
		}	
			
		/// <summary>
        /// terminatememorycontributionpercent
        /// </summary>
		[DisplayName("Terminate Memory Contribution Percent")]
		[AttributeLogicalName("terminatememorycontributionpercent")]
		public int? TerminateMemoryContributionPercent
		{	
			get { return GetAttributeValue<int?>("terminatememorycontributionpercent"); }
			set
			{ 
				if(value == TerminateMemoryContributionPercent) return;
				SetAttributeValue("terminatememorycontributionpercent", value);
			}
		}	
			
		/// <summary>
        /// terminateothercontributionpercent
        /// </summary>
		[DisplayName("Terminate Other Contribution Percent")]
		[AttributeLogicalName("terminateothercontributionpercent")]
		public int? TerminateOtherContributionPercent
		{	
			get { return GetAttributeValue<int?>("terminateothercontributionpercent"); }
			set
			{ 
				if(value == TerminateOtherContributionPercent) return;
				SetAttributeValue("terminateothercontributionpercent", value);
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
			/// <summary>averageexecutetimeinmilliseconds</summary>
			public const string TheAverageExecutionTime = "averageexecutetimeinmilliseconds";

			/// <summary>crashcontributionpercent</summary>
			public const string PercentageContributionToCrashes = "crashcontributionpercent";

			/// <summary>crashcount</summary>
			public const string NumberOfTimesCrashed = "crashcount";

			/// <summary>crashpercent</summary>
			public const string PercentageOfCrashes = "crashpercent";

			/// <summary>createdby</summary>
			public const string CreatedBy = "createdby";

			/// <summary>createdbyname</summary>
			public const string Createdbyname = "createdbyname";

			/// <summary>createdon</summary>
			public const string CreatedOn = "createdon";

			/// <summary>createdonbehalfby</summary>
			public const string CreatedByDelegate = "createdonbehalfby";

			/// <summary>createdonbehalfbyname</summary>
			public const string Createdonbehalfbyname = "createdonbehalfbyname";

			/// <summary>createdonbehalfbyyominame</summary>
			public const string Createdonbehalfbyyominame = "createdonbehalfbyyominame";

			/// <summary>executecount</summary>
			public const string ExecutionCount = "executecount";

			/// <summary>failurecount</summary>
			public const string FailureCount = "failurecount";

			/// <summary>failurepercent</summary>
			public const string FailurePercent = "failurepercent";

			/// <summary>modifiedby</summary>
			public const string ModifiedBy = "modifiedby";

			/// <summary>modifiedbyname</summary>
			public const string Modifiedbyname = "modifiedbyname";

			/// <summary>modifiedon</summary>
			public const string ModifiedOn = "modifiedon";

			/// <summary>modifiedonbehalfby</summary>
			public const string ModifiedByDelegate = "modifiedonbehalfby";

			/// <summary>modifiedonbehalfbyname</summary>
			public const string Modifiedonbehalfbyname = "modifiedonbehalfbyname";

			/// <summary>modifiedonbehalfbyyominame</summary>
			public const string Modifiedonbehalfbyyominame = "modifiedonbehalfbyyominame";

			/// <summary>organizationid</summary>
			public const string Organizationid = "organizationid";

			/// <summary>plugintypeid</summary>
			public const string PluginType = "plugintypeid";

			/// <summary>plugintypeidname</summary>
			public const string Plugintypeidname = "plugintypeidname";

			/// <summary>plugintypestatisticid</summary>
			public const string PlugintypestatisticId = "plugintypestatisticid";

			/// <summary>terminatecpucontributionpercent</summary>
			public const string TerminateCPUContributionPercent = "terminatecpucontributionpercent";

			/// <summary>terminatehandlescontributionpercent</summary>
			public const string TerminateHandlesContributionPercent = "terminatehandlescontributionpercent";

			/// <summary>terminatememorycontributionpercent</summary>
			public const string TerminateMemoryContributionPercent = "terminatememorycontributionpercent";

			/// <summary>terminateothercontributionpercent</summary>
			public const string TerminateOtherContributionPercent = "terminateothercontributionpercent";

		}
		#endregion

		#region Schemas
		public static class Schemas 
		{
		}
		#endregion
	}
}

