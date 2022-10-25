using System;
using System.Linq;
using System.Diagnostics;
using System.ComponentModel;
using Microsoft.Xrm.Sdk; 
using Microsoft.Xrm.Sdk.Client;
using System.Collections.Generic;

namespace PentaWork.Xrm.Scheduler.Proxies.Entities
{
	[DebuggerDisplay("{TypeName}")] 	
	[EntityLogicalName("plugintracelog")]
	public sealed class PluginTraceLog : Entity
	{	
		public static readonly int? EntityTypeCode = 4619;
		public new const string LogicalName = "plugintracelog";
		public const string PrimaryIdAttribute = "plugintracelogid";
		public const string PrimaryNameAttribute = "typename";
	
		public PluginTraceLog() : base("plugintracelog") { }

		#region Attributes
		/// <summary>
        /// configuration
        /// </summary>
		[DisplayName("Configuration")]
		[AttributeLogicalName("configuration")]
		public string Configuration
		{	
			get { return GetAttributeValue<string>("configuration"); }
			set
			{ 
				if(value == Configuration) return;
				SetAttributeValue("configuration", value);
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
        /// createdby
        /// </summary>
		[DisplayName("Created By (Delegate)")]
		[AttributeLogicalName("createdby")]
		public EntityReference CreatedByDelegate
		{	
			get { return GetAttributeValue<EntityReference>("createdby"); }
			set
			{ 
				if(value == CreatedByDelegate) return;
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
		public EntityReference CreatedByDelegate2
		{	
			get { return GetAttributeValue<EntityReference>("createdonbehalfby"); }
			set
			{ 
				if(value == CreatedByDelegate2) return;
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
        /// exceptiondetails
        /// </summary>
		[DisplayName("Exception Details")]
		[AttributeLogicalName("exceptiondetails")]
		public string ExceptionDetails
		{	
			get { return GetAttributeValue<string>("exceptiondetails"); }
			set
			{ 
				if(value == ExceptionDetails) return;
				SetAttributeValue("exceptiondetails", value);
			}
		}	
			
		/// <summary>
        /// issystemcreated
        /// </summary>
		[DisplayName("System Created")]
		[AttributeLogicalName("issystemcreated")]
		public bool? SystemCreated
		{	
			get { return GetAttributeValue<bool?>("issystemcreated"); }
			set
			{ 
				if(value == SystemCreated) return;
				SetAttributeValue("issystemcreated", value);
			}
		}	
			
		/// <summary>
        /// messageblock
        /// </summary>
		[DisplayName("Message Block")]
		[AttributeLogicalName("messageblock")]
		public string MessageBlock
		{	
			get { return GetAttributeValue<string>("messageblock"); }
			set
			{ 
				if(value == MessageBlock) return;
				SetAttributeValue("messageblock", value);
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
        /// mode
        /// </summary>
		[DisplayName("Mode")]
		[AttributeLogicalName("mode")]
		public eMode? Mode
		{	
			get 
			{ 
				var optionSetValue = GetAttributeValue<OptionSetValue>("mode");
				if (optionSetValue != null) return (eMode)optionSetValue.Value;
				else return null;
			}
			set 
			{ 
				if(value == Mode) return;

				OptionSetValue optionSetValue = null;
				if(value != null) optionSetValue = new OptionSetValue((int)value);
				SetAttributeValue("mode", optionSetValue); 
			}
		}

		/// <summary>
        /// operationtype
        /// </summary>
		[DisplayName("Operation Type")]
		[AttributeLogicalName("operationtype")]
		public eOperationType? OperationType
		{	
			get 
			{ 
				var optionSetValue = GetAttributeValue<OptionSetValue>("operationtype");
				if (optionSetValue != null) return (eOperationType)optionSetValue.Value;
				else return null;
			}
			set 
			{ 
				if(value == OperationType) return;

				OptionSetValue optionSetValue = null;
				if(value != null) optionSetValue = new OptionSetValue((int)value);
				SetAttributeValue("operationtype", optionSetValue); 
			}
		}

		/// <summary>
        /// organizationid
        /// </summary>
		[DisplayName("Organization Id")]
		[AttributeLogicalName("organizationid")]
		public Guid OrganizationId
		{	
			get { return GetAttributeValue<Guid>("organizationid"); }
			set
			{ 
				if(value == OrganizationId) return;
				SetAttributeValue("organizationid", value);
			}
		}	
			
		/// <summary>
        /// performanceconstructorduration
        /// </summary>
		[DisplayName("Constructor Duration")]
		[AttributeLogicalName("performanceconstructorduration")]
		public int? ConstructorDuration
		{	
			get { return GetAttributeValue<int?>("performanceconstructorduration"); }
			set
			{ 
				if(value == ConstructorDuration) return;
				SetAttributeValue("performanceconstructorduration", value);
			}
		}	
			
		/// <summary>
        /// performanceconstructorstarttime
        /// </summary>
		[DisplayName("Constructor Start Time")]
		[AttributeLogicalName("performanceconstructorstarttime")]
		public DateTime? ConstructorStartTime
		{	
			get { return GetAttributeValue<DateTime?>("performanceconstructorstarttime"); }
			set
			{ 
				if(value == ConstructorStartTime) return;
				SetAttributeValue("performanceconstructorstarttime", value);
			}
		}	
			
		/// <summary>
        /// performanceexecutionduration
        /// </summary>
		[DisplayName("Execution Duration")]
		[AttributeLogicalName("performanceexecutionduration")]
		public int? ExecutionDuration
		{	
			get { return GetAttributeValue<int?>("performanceexecutionduration"); }
			set
			{ 
				if(value == ExecutionDuration) return;
				SetAttributeValue("performanceexecutionduration", value);
			}
		}	
			
		/// <summary>
        /// performanceexecutionstarttime
        /// </summary>
		[DisplayName("Execution Start Time")]
		[AttributeLogicalName("performanceexecutionstarttime")]
		public DateTime? ExecutionStartTime
		{	
			get { return GetAttributeValue<DateTime?>("performanceexecutionstarttime"); }
			set
			{ 
				if(value == ExecutionStartTime) return;
				SetAttributeValue("performanceexecutionstarttime", value);
			}
		}	
			
		/// <summary>
        /// persistencekey
        /// </summary>
		[DisplayName("Persistence Key")]
		[AttributeLogicalName("persistencekey")]
		public Guid PersistenceKeyId
		{	
			get { return GetAttributeValue<Guid>("persistencekey"); }
			set
			{ 
				if(value == PersistenceKeyId) return;
				SetAttributeValue("persistencekey", value);
			}
		}	
			
		/// <summary>
        /// pluginstepid
        /// </summary>
		[DisplayName("Plugin Step ID")]
		[AttributeLogicalName("pluginstepid")]
		public Guid PluginStepId
		{	
			get { return GetAttributeValue<Guid>("pluginstepid"); }
			set
			{ 
				if(value == PluginStepId) return;
				SetAttributeValue("pluginstepid", value);
			}
		}	
			
		/// <summary>
        /// plugintracelogid
        /// </summary>
		[DisplayName("Plug-in Trace Log")]
		[AttributeLogicalName("plugintracelogid")]
		public override Guid Id
		{
			get => base.Id;
			set { base.Id = value; SetAttributeValue("plugintracelogid", value); }
		}

							/// <summary>
        /// primaryentity
        /// </summary>
		[DisplayName("Primary Entity")]
		[AttributeLogicalName("primaryentity")]
		public string PrimaryEntity
		{	
			get { return GetAttributeValue<string>("primaryentity"); }
			set
			{ 
				if(value == PrimaryEntity) return;
				SetAttributeValue("primaryentity", value);
			}
		}	
			
		/// <summary>
        /// profile
        /// </summary>
		[DisplayName("Profile")]
		[AttributeLogicalName("profile")]
		public string Profile
		{	
			get { return GetAttributeValue<string>("profile"); }
			set
			{ 
				if(value == Profile) return;
				SetAttributeValue("profile", value);
			}
		}	
			
		/// <summary>
        /// requestid
        /// </summary>
		[DisplayName("Request ID")]
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
        /// secureconfiguration
        /// </summary>
		[DisplayName("Secure Configuration")]
		[AttributeLogicalName("secureconfiguration")]
		public string SecureConfiguration
		{	
			get { return GetAttributeValue<string>("secureconfiguration"); }
			set
			{ 
				if(value == SecureConfiguration) return;
				SetAttributeValue("secureconfiguration", value);
			}
		}	
			
		/// <summary>
        /// typename
        /// </summary>
		[DisplayName("Type Name")]
		[AttributeLogicalName("typename")]
		public string TypeName
		{	
			get { return GetAttributeValue<string>("typename"); }
			set
			{ 
				if(value == TypeName) return;
				SetAttributeValue("typename", value);
			}
		}	
			
		#endregion	

		#region Relations
			#endregion

		#region Actions
		#endregion

		#region OptionSetEnums
		public enum eMode
		{	
		
			[Label("Synchronous")]
			[Description(@"")]
			Synchronous = 0, 
		
			[Label("Asynchronous")]
			[Description(@"")]
			Asynchronous = 1, 
		}
		
		public enum eOperationType
		{	
		
			[Label("Unknown")]
			[Description(@"")]
			Unknown = 0, 
		
			[Label("Plug-in")]
			[Description(@"")]
			Plugin = 1, 
		
			[Label("Workflow Activity")]
			[Description(@"")]
			WorkflowActivity = 2, 
		}
		
		#endregion	

		#region Properties
		public static class Properties 
		{
			/// <summary>configuration</summary>
			public const string Configuration = "configuration";

			/// <summary>correlationid</summary>
			public const string CorrelationId = "correlationid";

			/// <summary>createdby</summary>
			public const string CreatedByDelegate = "createdby";

			/// <summary>createdbyname</summary>
			public const string Createdbyname = "createdbyname";

			/// <summary>createdbyyominame</summary>
			public const string Createdbyyominame = "createdbyyominame";

			/// <summary>createdon</summary>
			public const string CreatedOn = "createdon";

			/// <summary>createdonbehalfby</summary>
			public const string CreatedByDelegate2 = "createdonbehalfby";

			/// <summary>createdonbehalfbyname</summary>
			public const string Createdonbehalfbyname = "createdonbehalfbyname";

			/// <summary>createdonbehalfbyyominame</summary>
			public const string Createdonbehalfbyyominame = "createdonbehalfbyyominame";

			/// <summary>depth</summary>
			public const string Depth = "depth";

			/// <summary>exceptiondetails</summary>
			public const string ExceptionDetails = "exceptiondetails";

			/// <summary>issystemcreated</summary>
			public const string SystemCreated = "issystemcreated";

			/// <summary>messageblock</summary>
			public const string MessageBlock = "messageblock";

			/// <summary>messagename</summary>
			public const string MessageName = "messagename";

			/// <summary>mode</summary>
			public const string Mode = "mode";

			/// <summary>operationtype</summary>
			public const string OperationType = "operationtype";

			/// <summary>organizationid</summary>
			public const string OrganizationId = "organizationid";

			/// <summary>performanceconstructorduration</summary>
			public const string ConstructorDuration = "performanceconstructorduration";

			/// <summary>performanceconstructorstarttime</summary>
			public const string ConstructorStartTime = "performanceconstructorstarttime";

			/// <summary>performanceexecutionduration</summary>
			public const string ExecutionDuration = "performanceexecutionduration";

			/// <summary>performanceexecutionstarttime</summary>
			public const string ExecutionStartTime = "performanceexecutionstarttime";

			/// <summary>persistencekey</summary>
			public const string PersistenceKeyId = "persistencekey";

			/// <summary>pluginstepid</summary>
			public const string PluginStepId = "pluginstepid";

			/// <summary>plugintracelogid</summary>
			public const string PluginTraceLogId = "plugintracelogid";

			/// <summary>primaryentity</summary>
			public const string PrimaryEntity = "primaryentity";

			/// <summary>profile</summary>
			public const string Profile = "profile";

			/// <summary>requestid</summary>
			public const string RequestId = "requestid";

			/// <summary>secureconfiguration</summary>
			public const string SecureConfiguration = "secureconfiguration";

			/// <summary>typename</summary>
			public const string TypeName = "typename";

		}
		#endregion

		#region Schemas
		public static class Schemas 
		{
		}
		#endregion
	}
}

