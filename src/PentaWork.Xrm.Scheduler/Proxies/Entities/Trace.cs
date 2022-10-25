using System;
using System.Linq;
using System.Diagnostics;
using System.ComponentModel;
using Microsoft.Xrm.Sdk; 
using Microsoft.Xrm.Sdk.Client;
using System.Collections.Generic;

namespace PentaWork.Xrm.Scheduler.Proxies.Entities
{
	[DebuggerDisplay("{Text}")] 	
	[EntityLogicalName("tracelog")]
	public sealed class Trace : Entity
	{	
		public static readonly int? EntityTypeCode = 8050;
		public new const string LogicalName = "tracelog";
		public const string PrimaryIdAttribute = "tracelogid";
		public const string PrimaryNameAttribute = "text";
	
		public Trace() : base("tracelog") { }

		#region Attributes
		/// <summary>
        /// canbedeleted
        /// </summary>
		[DisplayName("Trace CanBeDeleted Flag")]
		[AttributeLogicalName("canbedeleted")]
		public bool? TraceCanBeDeletedFlag
		{	
			get { return GetAttributeValue<bool?>("canbedeleted"); }
			set
			{ 
				if(value == TraceCanBeDeletedFlag) return;
				SetAttributeValue("canbedeleted", value);
			}
		}	
			
		/// <summary>
        /// collationlevel
        /// </summary>
		[DisplayName("Collation Level")]
		[AttributeLogicalName("collationlevel")]
		public int? CollationLevel
		{	
			get { return GetAttributeValue<int?>("collationlevel"); }
			set
			{ 
				if(value == CollationLevel) return;
				SetAttributeValue("collationlevel", value);
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
        /// errordetails
        /// </summary>
		[DisplayName("errordetails")]
		[AttributeLogicalName("errordetails")]
		public string Errordetails
		{	
			get { return GetAttributeValue<string>("errordetails"); }
			set
			{ 
				if(value == Errordetails) return;
				SetAttributeValue("errordetails", value);
			}
		}	
			
		/// <summary>
        /// errortypedisplay
        /// </summary>
		[DisplayName("Trace Error Details")]
		[AttributeLogicalName("errortypedisplay")]
		public string TraceErrorDetails
		{	
			get { return GetAttributeValue<string>("errortypedisplay"); }
			set
			{ 
				if(value == TraceErrorDetails) return;
				SetAttributeValue("errortypedisplay", value);
			}
		}	
			
		/// <summary>
        /// isunique
        /// </summary>
		[DisplayName("Is Unique Trace")]
		[AttributeLogicalName("isunique")]
		public bool? IsUniqueTrace
		{	
			get { return GetAttributeValue<bool?>("isunique"); }
			set
			{ 
				if(value == IsUniqueTrace) return;
				SetAttributeValue("isunique", value);
			}
		}	
			
		/// <summary>
        /// level
        /// </summary>
		[DisplayName("Level")]
		[AttributeLogicalName("level")]
		public eLevel? Level
		{	
			get 
			{ 
				var optionSetValue = GetAttributeValue<OptionSetValue>("level");
				if (optionSetValue != null) return (eLevel)optionSetValue.Value;
				else return null;
			}
			set 
			{ 
				if(value == Level) return;

				OptionSetValue optionSetValue = null;
				if(value != null) optionSetValue = new OptionSetValue((int)value);
				SetAttributeValue("level", optionSetValue); 
			}
		}

		/// <summary>
        /// machinename
        /// </summary>
		[DisplayName("machinename")]
		[AttributeLogicalName("machinename")]
		public string Machinename
		{	
			get { return GetAttributeValue<string>("machinename"); }
			set
			{ 
				if(value == Machinename) return;
				SetAttributeValue("machinename", value);
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
		[DisplayName("Last Update On")]
		[AttributeLogicalName("modifiedon")]
		public DateTime? LastUpdateOn
		{	
			get { return GetAttributeValue<DateTime?>("modifiedon"); }
			set
			{ 
				if(value == LastUpdateOn) return;
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
		[DisplayName("Organization")]
		[AttributeLogicalName("organizationid")]
		public EntityReference Organization
		{	
			get { return GetAttributeValue<EntityReference>("organizationid"); }
			set
			{ 
				if(value == Organization) return;
				SetAttributeValue("organizationid", value);
			}
		}	
			
		/// <summary>
        /// organizationidname
        /// </summary>
		[DisplayName("organizationidname")]
		[AttributeLogicalName("organizationidname")]
		public string Organizationidname
		{	
			get { return GetAttributeValue<string>("organizationidname"); }
			set
			{ 
				if(value == Organizationidname) return;
				SetAttributeValue("organizationidname", value);
			}
		}	
			
		/// <summary>
        /// parenttracelogid
        /// </summary>
		[DisplayName("Parent Id")]
		[AttributeLogicalName("parenttracelogid")]
		public EntityReference ParentId
		{	
			get { return GetAttributeValue<EntityReference>("parenttracelogid"); }
			set
			{ 
				if(value == ParentId) return;
				SetAttributeValue("parenttracelogid", value);
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
        /// regardingobjectownerid
        /// </summary>
		[DisplayName("Owner")]
		[AttributeLogicalName("regardingobjectownerid")]
		public EntityReference Owner
		{	
			get { return GetAttributeValue<EntityReference>("regardingobjectownerid"); }
			set
			{ 
				if(value == Owner) return;
				SetAttributeValue("regardingobjectownerid", value);
			}
		}	
			
		/// <summary>
        /// regardingobjectowneridtype
        /// </summary>
		[DisplayName("Owner Type")]
		[AttributeLogicalName("regardingobjectowneridtype")]
		public string OwnerType
		{	
			get { return GetAttributeValue<string>("regardingobjectowneridtype"); }
			set
			{ 
				if(value == OwnerType) return;
				SetAttributeValue("regardingobjectowneridtype", value);
			}
		}	
			
		/// <summary>
        /// regardingobjectowningbusinessunit
        /// </summary>
		[DisplayName("Owning Business Unit")]
		[AttributeLogicalName("regardingobjectowningbusinessunit")]
		public EntityReference OwningBusinessUnit
		{	
			get { return GetAttributeValue<EntityReference>("regardingobjectowningbusinessunit"); }
			set
			{ 
				if(value == OwningBusinessUnit) return;
				SetAttributeValue("regardingobjectowningbusinessunit", value);
			}
		}	
			
		/// <summary>
        /// regardingobjecttypecode
        /// </summary>
		[DisplayName("Regarding Object Type")]
		[AttributeLogicalName("regardingobjecttypecode")]
		public string RegardingObjectType
		{	
			get { return GetAttributeValue<string>("regardingobjecttypecode"); }
			set
			{ 
				if(value == RegardingObjectType) return;
				SetAttributeValue("regardingobjecttypecode", value);
			}
		}	
			
		/// <summary>
        /// text
        /// </summary>
		[DisplayName("Text")]
		[AttributeLogicalName("text")]
		public string Text
		{	
			get { return GetAttributeValue<string>("text"); }
			set
			{ 
				if(value == Text) return;
				SetAttributeValue("text", value);
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
				if(value == TimeZoneRuleVersionNumber) return;
				SetAttributeValue("timezoneruleversionnumber", value);
			}
		}	
			
		/// <summary>
        /// traceactionxml
        /// </summary>
		[DisplayName("Trace Actions XML")]
		[AttributeLogicalName("traceactionxml")]
		public string TraceActionsXML
		{	
			get { return GetAttributeValue<string>("traceactionxml"); }
			set
			{ 
				if(value == TraceActionsXML) return;
				SetAttributeValue("traceactionxml", value);
			}
		}	
			
		/// <summary>
        /// tracecode
        /// </summary>
		[DisplayName("Error Code")]
		[AttributeLogicalName("tracecode")]
		public int? ErrorCode
		{	
			get { return GetAttributeValue<int?>("tracecode"); }
			set
			{ 
				if(value == ErrorCode) return;
				SetAttributeValue("tracecode", value);
			}
		}	
			
		/// <summary>
        /// tracedetailxml
        /// </summary>
		[DisplayName("Trace Detail XML")]
		[AttributeLogicalName("tracedetailxml")]
		public string TraceDetailXML
		{	
			get { return GetAttributeValue<string>("tracedetailxml"); }
			set
			{ 
				if(value == TraceDetailXML) return;
				SetAttributeValue("tracedetailxml", value);
			}
		}	
			
		/// <summary>
        /// tracelogid
        /// </summary>
		[DisplayName("Trace")]
		[AttributeLogicalName("tracelogid")]
		public override Guid Id
		{
			get => base.Id;
			set { base.Id = value; SetAttributeValue("tracelogid", value); }
		}

							/// <summary>
        /// traceparameterhash
        /// </summary>
		[DisplayName("Trace Parameter Hash")]
		[AttributeLogicalName("traceparameterhash")]
		public int? TraceParameterHash
		{	
			get { return GetAttributeValue<int?>("traceparameterhash"); }
			set
			{ 
				if(value == TraceParameterHash) return;
				SetAttributeValue("traceparameterhash", value);
			}
		}	
			
		/// <summary>
        /// traceparameterxml
        /// </summary>
		[DisplayName("Trace Parameter XML")]
		[AttributeLogicalName("traceparameterxml")]
		public string TraceParameterXML
		{	
			get { return GetAttributeValue<string>("traceparameterxml"); }
			set
			{ 
				if(value == TraceParameterXML) return;
				SetAttributeValue("traceparameterxml", value);
			}
		}	
			
		/// <summary>
        /// traceregardingid
        /// </summary>
		[DisplayName("Trace Regarding")]
		[AttributeLogicalName("traceregardingid")]
		public EntityReference TraceRegarding
		{	
			get { return GetAttributeValue<EntityReference>("traceregardingid"); }
			set
			{ 
				if(value == TraceRegarding) return;
				SetAttributeValue("traceregardingid", value);
			}
		}	
			
		/// <summary>
        /// tracestatus
        /// </summary>
		[DisplayName("Trace Status")]
		[AttributeLogicalName("tracestatus")]
		public bool? TraceStatus
		{	
			get { return GetAttributeValue<bool?>("tracestatus"); }
			set
			{ 
				if(value == TraceStatus) return;
				SetAttributeValue("tracestatus", value);
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
				if(value == UTCConversionTimeZoneCode) return;
				SetAttributeValue("utcconversiontimezonecode", value);
			}
		}	
			
		#endregion	

		#region Relations
			/// <summary>
        /// 1:N Get entities for 'tracelog_parent_tracelog'
        /// </summary>
		[RelationshipSchemaName("tracelog_parent_tracelog")]
		public IEnumerable<Trace> TracelogParentTracelog
		{
			get { return GetRelatedEntities<Trace>("tracelog_parent_tracelog", null); }
			set { SetRelatedEntities("tracelog_parent_tracelog", null, value); }
		}
		#endregion

		#region Actions
		#endregion

		#region OptionSetEnums
		public enum eLevel
		{	
		
			[Label("Information")]
			[Description(@"")]
			Information = 1, 
		
			[Label("Warning")]
			[Description(@"")]
			Warning = 2, 
		
			[Label("Error")]
			[Description(@"")]
			Error = 3, 
		}
		
		#endregion	

		#region Properties
		public static class Properties 
		{
			/// <summary>canbedeleted</summary>
			public const string TraceCanBeDeletedFlag = "canbedeleted";

			/// <summary>collationlevel</summary>
			public const string CollationLevel = "collationlevel";

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

			/// <summary>errordetails</summary>
			public const string Errordetails = "errordetails";

			/// <summary>errortypedisplay</summary>
			public const string TraceErrorDetails = "errortypedisplay";

			/// <summary>isunique</summary>
			public const string IsUniqueTrace = "isunique";

			/// <summary>level</summary>
			public const string Level = "level";

			/// <summary>machinename</summary>
			public const string Machinename = "machinename";

			/// <summary>modifiedby</summary>
			public const string ModifiedBy = "modifiedby";

			/// <summary>modifiedbyname</summary>
			public const string Modifiedbyname = "modifiedbyname";

			/// <summary>modifiedbyyominame</summary>
			public const string Modifiedbyyominame = "modifiedbyyominame";

			/// <summary>modifiedon</summary>
			public const string LastUpdateOn = "modifiedon";

			/// <summary>modifiedonbehalfby</summary>
			public const string ModifiedByDelegate = "modifiedonbehalfby";

			/// <summary>modifiedonbehalfbyname</summary>
			public const string Modifiedonbehalfbyname = "modifiedonbehalfbyname";

			/// <summary>modifiedonbehalfbyyominame</summary>
			public const string Modifiedonbehalfbyyominame = "modifiedonbehalfbyyominame";

			/// <summary>organizationid</summary>
			public const string Organization = "organizationid";

			/// <summary>organizationidname</summary>
			public const string Organizationidname = "organizationidname";

			/// <summary>parenttracelogid</summary>
			public const string ParentId = "parenttracelogid";

			/// <summary>regardingobjectid</summary>
			public const string Regarding = "regardingobjectid";

			/// <summary>regardingobjectidname</summary>
			public const string Regardingobjectidname = "regardingobjectidname";

			/// <summary>regardingobjectidyominame</summary>
			public const string Regardingobjectidyominame = "regardingobjectidyominame";

			/// <summary>regardingobjectownerid</summary>
			public const string Owner = "regardingobjectownerid";

			/// <summary>regardingobjectowneridtype</summary>
			public const string OwnerType = "regardingobjectowneridtype";

			/// <summary>regardingobjectowningbusinessunit</summary>
			public const string OwningBusinessUnit = "regardingobjectowningbusinessunit";

			/// <summary>regardingobjecttypecode</summary>
			public const string RegardingObjectType = "regardingobjecttypecode";

			/// <summary>text</summary>
			public const string Text = "text";

			/// <summary>timezoneruleversionnumber</summary>
			public const string TimeZoneRuleVersionNumber = "timezoneruleversionnumber";

			/// <summary>traceactionxml</summary>
			public const string TraceActionsXML = "traceactionxml";

			/// <summary>tracecode</summary>
			public const string ErrorCode = "tracecode";

			/// <summary>tracedetailxml</summary>
			public const string TraceDetailXML = "tracedetailxml";

			/// <summary>tracelogid</summary>
			public const string TraceId = "tracelogid";

			/// <summary>traceparameterhash</summary>
			public const string TraceParameterHash = "traceparameterhash";

			/// <summary>traceparameterxml</summary>
			public const string TraceParameterXML = "traceparameterxml";

			/// <summary>traceregardingid</summary>
			public const string TraceRegarding = "traceregardingid";

			/// <summary>tracestatus</summary>
			public const string TraceStatus = "tracestatus";

			/// <summary>utcconversiontimezonecode</summary>
			public const string UTCConversionTimeZoneCode = "utcconversiontimezonecode";

		}
		#endregion

		#region Schemas
		public static class Schemas 
		{
			/// <summary>1:N tracelog_parent_tracelog</summary>
			public const string TracelogParentTracelog = "tracelog_parent_tracelog";

		}
		#endregion
	}
}

