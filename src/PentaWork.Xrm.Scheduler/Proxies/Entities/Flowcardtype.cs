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
	[EntityLogicalName("msdyn_flowcardtype")]
	public sealed class Flowcardtype : Entity
	{	
		public static readonly int? EntityTypeCode = 10090;
		public new const string LogicalName = "msdyn_flowcardtype";
		public const string PrimaryIdAttribute = "msdyn_flowcardtypeid";
		public const string PrimaryNameAttribute = "msdyn_name";
	
		public Flowcardtype() : base("msdyn_flowcardtype") { }

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
        /// importsequencenumber
        /// </summary>
		[DisplayName("Import Sequence Number")]
		[AttributeLogicalName("importsequencenumber")]
		public int? ImportSequenceNumber
		{	
			get { return GetAttributeValue<int?>("importsequencenumber"); }
			set
			{ 
				if(value == ImportSequenceNumber) return;
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
        /// msdyn_actioncommand
        /// </summary>
		[DisplayName("actionCommand")]
		[AttributeLogicalName("msdyn_actioncommand")]
		public string ActionCommand
		{	
			get { return GetAttributeValue<string>("msdyn_actioncommand"); }
			set
			{ 
				if(value == ActionCommand) return;
				SetAttributeValue("msdyn_actioncommand", value);
			}
		}	
			
		/// <summary>
        /// msdyn_actionname
        /// </summary>
		[DisplayName("actionname")]
		[AttributeLogicalName("msdyn_actionname")]
		public string Actionname
		{	
			get { return GetAttributeValue<string>("msdyn_actionname"); }
			set
			{ 
				if(value == Actionname) return;
				SetAttributeValue("msdyn_actionname", value);
			}
		}	
			
		/// <summary>
        /// msdyn_cardname
        /// </summary>
		[DisplayName("cardname")]
		[AttributeLogicalName("msdyn_cardname")]
		public string Cardname
		{	
			get { return GetAttributeValue<string>("msdyn_cardname"); }
			set
			{ 
				if(value == Cardname) return;
				SetAttributeValue("msdyn_cardname", value);
			}
		}	
			
		/// <summary>
        /// msdyn_cardtypeid
        /// </summary>
		[DisplayName("cardtypeid")]
		[AttributeLogicalName("msdyn_cardtypeid")]
		public EntityReference Cardtypeid
		{	
			get { return GetAttributeValue<EntityReference>("msdyn_cardtypeid"); }
			set
			{ 
				if(value == Cardtypeid) return;
				SetAttributeValue("msdyn_cardtypeid", value);
			}
		}	
			
		/// <summary>
        /// msdyn_cardtypeidname
        /// </summary>
		[DisplayName("msdyn_cardtypeidname")]
		[AttributeLogicalName("msdyn_cardtypeidname")]
		public string MsdynCardtypeidname
		{	
			get { return GetAttributeValue<string>("msdyn_cardtypeidname"); }
			set
			{ 
				if(value == MsdynCardtypeidname) return;
				SetAttributeValue("msdyn_cardtypeidname", value);
			}
		}	
			
		/// <summary>
        /// msdyn_description
        /// </summary>
		[DisplayName("description")]
		[AttributeLogicalName("msdyn_description")]
		public string Description
		{	
			get { return GetAttributeValue<string>("msdyn_description"); }
			set
			{ 
				if(value == Description) return;
				SetAttributeValue("msdyn_description", value);
			}
		}	
			
		/// <summary>
        /// msdyn_flowcardtypeid
        /// </summary>
		[DisplayName("flowcardtype")]
		[AttributeLogicalName("msdyn_flowcardtypeid")]
		public override Guid Id
		{
			get => base.Id;
			set { base.Id = value; SetAttributeValue("msdyn_flowcardtypeid", value); }
		}

							/// <summary>
        /// msdyn_flowname
        /// </summary>
		[DisplayName("flowname")]
		[AttributeLogicalName("msdyn_flowname")]
		public string Flowname
		{	
			get { return GetAttributeValue<string>("msdyn_flowname"); }
			set
			{ 
				if(value == Flowname) return;
				SetAttributeValue("msdyn_flowname", value);
			}
		}	
			
		/// <summary>
        /// msdyn_iscdsflow
        /// </summary>
		[DisplayName("iscdsflow")]
		[AttributeLogicalName("msdyn_iscdsflow")]
		public bool? Iscdsflow
		{	
			get { return GetAttributeValue<bool?>("msdyn_iscdsflow"); }
			set
			{ 
				if(value == Iscdsflow) return;
				SetAttributeValue("msdyn_iscdsflow", value);
			}
		}	
			
		/// <summary>
        /// msdyn_isdeleted
        /// </summary>
		[DisplayName("isdeleted")]
		[AttributeLogicalName("msdyn_isdeleted")]
		public bool? Isdeleted
		{	
			get { return GetAttributeValue<bool?>("msdyn_isdeleted"); }
			set
			{ 
				if(value == Isdeleted) return;
				SetAttributeValue("msdyn_isdeleted", value);
			}
		}	
			
		/// <summary>
        /// msdyn_name
        /// </summary>
		[DisplayName("Name")]
		[AttributeLogicalName("msdyn_name")]
		public string Name
		{	
			get { return GetAttributeValue<string>("msdyn_name"); }
			set
			{ 
				if(value == Name) return;
				SetAttributeValue("msdyn_name", value);
			}
		}	
			
		/// <summary>
        /// msdyn_samplebody
        /// </summary>
		[DisplayName("samplebody")]
		[AttributeLogicalName("msdyn_samplebody")]
		public string Samplebody
		{	
			get { return GetAttributeValue<string>("msdyn_samplebody"); }
			set
			{ 
				if(value == Samplebody) return;
				SetAttributeValue("msdyn_samplebody", value);
			}
		}	
			
		/// <summary>
        /// msdyn_sampletitle
        /// </summary>
		[DisplayName("sampletitle")]
		[AttributeLogicalName("msdyn_sampletitle")]
		public string Sampletitle
		{	
			get { return GetAttributeValue<string>("msdyn_sampletitle"); }
			set
			{ 
				if(value == Sampletitle) return;
				SetAttributeValue("msdyn_sampletitle", value);
			}
		}	
			
		/// <summary>
        /// msdyn_workflowid
        /// </summary>
		[DisplayName("workflowid")]
		[AttributeLogicalName("msdyn_workflowid")]
		public string Workflowid
		{	
			get { return GetAttributeValue<string>("msdyn_workflowid"); }
			set
			{ 
				if(value == Workflowid) return;
				SetAttributeValue("msdyn_workflowid", value);
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
				if(value == RecordCreatedOn) return;
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
			
		#endregion	

		#region Relations
			/// <summary>
        /// 1:N Get entities for 'msdyn_flowcardtype_AsyncOperations'
        /// </summary>
		[RelationshipSchemaName("msdyn_flowcardtype_AsyncOperations")]
		public IEnumerable<SystemJob> MsdynFlowcardtypeAsyncOperations
		{
			get { return GetRelatedEntities<SystemJob>("msdyn_flowcardtype_AsyncOperations", null); }
			set { SetRelatedEntities("msdyn_flowcardtype_AsyncOperations", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'msdyn_flowcardtype_BulkDeleteFailures'
        /// </summary>
		[RelationshipSchemaName("msdyn_flowcardtype_BulkDeleteFailures")]
		public IEnumerable<BulkDeleteFailure> MsdynFlowcardtypeBulkDeleteFailures
		{
			get { return GetRelatedEntities<BulkDeleteFailure>("msdyn_flowcardtype_BulkDeleteFailures", null); }
			set { SetRelatedEntities("msdyn_flowcardtype_BulkDeleteFailures", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'msdyn_flowcardtype_DuplicateBaseRecord'
        /// </summary>
		[RelationshipSchemaName("msdyn_flowcardtype_DuplicateBaseRecord")]
		public IEnumerable<DuplicateRecord> MsdynFlowcardtypeDuplicateBaseRecord
		{
			get { return GetRelatedEntities<DuplicateRecord>("msdyn_flowcardtype_DuplicateBaseRecord", null); }
			set { SetRelatedEntities("msdyn_flowcardtype_DuplicateBaseRecord", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'msdyn_flowcardtype_DuplicateMatchingRecord'
        /// </summary>
		[RelationshipSchemaName("msdyn_flowcardtype_DuplicateMatchingRecord")]
		public IEnumerable<DuplicateRecord> MsdynFlowcardtypeDuplicateMatchingRecord
		{
			get { return GetRelatedEntities<DuplicateRecord>("msdyn_flowcardtype_DuplicateMatchingRecord", null); }
			set { SetRelatedEntities("msdyn_flowcardtype_DuplicateMatchingRecord", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'msdyn_flowcardtype_MailboxTrackingFolders'
        /// </summary>
		[RelationshipSchemaName("msdyn_flowcardtype_MailboxTrackingFolders")]
		public IEnumerable<MailboxAutoTrackingFolder> MsdynFlowcardtypeMailboxTrackingFolders
		{
			get { return GetRelatedEntities<MailboxAutoTrackingFolder>("msdyn_flowcardtype_MailboxTrackingFolders", null); }
			set { SetRelatedEntities("msdyn_flowcardtype_MailboxTrackingFolders", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'msdyn_flowcardtype_PrincipalObjectAttributeAccesses'
        /// </summary>
		[RelationshipSchemaName("msdyn_flowcardtype_PrincipalObjectAttributeAccesses")]
		public IEnumerable<FieldSharing> MsdynFlowcardtypePrincipalObjectAttributeAccesses
		{
			get { return GetRelatedEntities<FieldSharing>("msdyn_flowcardtype_PrincipalObjectAttributeAccesses", null); }
			set { SetRelatedEntities("msdyn_flowcardtype_PrincipalObjectAttributeAccesses", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'msdyn_flowcardtype_ProcessSession'
        /// </summary>
		[RelationshipSchemaName("msdyn_flowcardtype_ProcessSession")]
		public IEnumerable<ProcessSession> MsdynFlowcardtypeProcessSession
		{
			get { return GetRelatedEntities<ProcessSession>("msdyn_flowcardtype_ProcessSession", null); }
			set { SetRelatedEntities("msdyn_flowcardtype_ProcessSession", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'msdyn_flowcardtype_SyncErrors'
        /// </summary>
		[RelationshipSchemaName("msdyn_flowcardtype_SyncErrors")]
		public IEnumerable<SyncError> MsdynFlowcardtypeSyncErrors
		{
			get { return GetRelatedEntities<SyncError>("msdyn_flowcardtype_SyncErrors", null); }
			set { SetRelatedEntities("msdyn_flowcardtype_SyncErrors", null, value); }
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
		
			[Label("Active")]
			[Description(@"")]
			Active_Active = 1, 
		
			[Label("Inactive")]
			[Description(@"")]
			Inactive_Inactive = 2, 
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

			/// <summary>msdyn_actioncommand</summary>
			public const string ActionCommand = "msdyn_actioncommand";

			/// <summary>msdyn_actionname</summary>
			public const string Actionname = "msdyn_actionname";

			/// <summary>msdyn_cardname</summary>
			public const string Cardname = "msdyn_cardname";

			/// <summary>msdyn_cardtypeid</summary>
			public const string Cardtypeid = "msdyn_cardtypeid";

			/// <summary>msdyn_cardtypeidname</summary>
			public const string MsdynCardtypeidname = "msdyn_cardtypeidname";

			/// <summary>msdyn_description</summary>
			public const string Description = "msdyn_description";

			/// <summary>msdyn_flowcardtypeid</summary>
			public const string FlowcardtypeId = "msdyn_flowcardtypeid";

			/// <summary>msdyn_flowname</summary>
			public const string Flowname = "msdyn_flowname";

			/// <summary>msdyn_iscdsflow</summary>
			public const string Iscdsflow = "msdyn_iscdsflow";

			/// <summary>msdyn_isdeleted</summary>
			public const string Isdeleted = "msdyn_isdeleted";

			/// <summary>msdyn_name</summary>
			public const string Name = "msdyn_name";

			/// <summary>msdyn_samplebody</summary>
			public const string Samplebody = "msdyn_samplebody";

			/// <summary>msdyn_sampletitle</summary>
			public const string Sampletitle = "msdyn_sampletitle";

			/// <summary>msdyn_workflowid</summary>
			public const string Workflowid = "msdyn_workflowid";

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

			/// <summary>owningteam</summary>
			public const string OwningTeam = "owningteam";

			/// <summary>owninguser</summary>
			public const string OwningUser = "owninguser";

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
			/// <summary>1:N msdyn_flowcardtype_AsyncOperations</summary>
			public const string MsdynFlowcardtypeAsyncOperations = "msdyn_flowcardtype_AsyncOperations";

			/// <summary>1:N msdyn_flowcardtype_BulkDeleteFailures</summary>
			public const string MsdynFlowcardtypeBulkDeleteFailures = "msdyn_flowcardtype_BulkDeleteFailures";

			/// <summary>1:N msdyn_flowcardtype_DuplicateBaseRecord</summary>
			public const string MsdynFlowcardtypeDuplicateBaseRecord = "msdyn_flowcardtype_DuplicateBaseRecord";

			/// <summary>1:N msdyn_flowcardtype_DuplicateMatchingRecord</summary>
			public const string MsdynFlowcardtypeDuplicateMatchingRecord = "msdyn_flowcardtype_DuplicateMatchingRecord";

			/// <summary>1:N msdyn_flowcardtype_MailboxTrackingFolders</summary>
			public const string MsdynFlowcardtypeMailboxTrackingFolders = "msdyn_flowcardtype_MailboxTrackingFolders";

			/// <summary>1:N msdyn_flowcardtype_PrincipalObjectAttributeAccesses</summary>
			public const string MsdynFlowcardtypePrincipalObjectAttributeAccesses = "msdyn_flowcardtype_PrincipalObjectAttributeAccesses";

			/// <summary>1:N msdyn_flowcardtype_ProcessSession</summary>
			public const string MsdynFlowcardtypeProcessSession = "msdyn_flowcardtype_ProcessSession";

			/// <summary>1:N msdyn_flowcardtype_SyncErrors</summary>
			public const string MsdynFlowcardtypeSyncErrors = "msdyn_flowcardtype_SyncErrors";

		}
		#endregion
	}
}

