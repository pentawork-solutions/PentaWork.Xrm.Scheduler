using System;
using System.Linq;
using System.Diagnostics;
using System.ComponentModel;
using Microsoft.Xrm.Sdk; 
using Microsoft.Xrm.Sdk.Client;
using System.Collections.Generic;

namespace PentaWork.Xrm.Scheduler.Proxies.Entities
{
	[DebuggerDisplay("{AttributeName}")] 	
	[EntityLogicalName("msdyn_playbookactivityattribute")]
	public sealed class PlaybookActivityAttribute : Entity
	{	
		public static readonly int? EntityTypeCode = 10078;
		public new const string LogicalName = "msdyn_playbookactivityattribute";
		public const string PrimaryIdAttribute = "msdyn_playbookactivityattributeid";
		public const string PrimaryNameAttribute = "msdyn_attributeLogicalName";
	
		public PlaybookActivityAttribute() : base("msdyn_playbookactivityattribute") { }

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
        /// msdyn_attributeLogicalName
        /// </summary>
		[DisplayName("Attribute Name")]
		[AttributeLogicalName("msdyn_attributeLogicalName")]
		public string AttributeName
		{	
			get { return GetAttributeValue<string>("msdyn_attributeLogicalName"); }
			set
			{ 
				if(value == AttributeName) return;
				SetAttributeValue("msdyn_attributeLogicalName", value);
			}
		}	
			
		/// <summary>
        /// msdyn_attributeType
        /// </summary>
		[DisplayName("Attribute type")]
		[AttributeLogicalName("msdyn_attributeType")]
		public eAttributeTypes? AttributeType
		{	
			get 
			{ 
				var optionSetValue = GetAttributeValue<OptionSetValue>("msdyn_attributeType");
				if (optionSetValue != null) return (eAttributeTypes)optionSetValue.Value;
				else return null;
			}
			set 
			{ 
				if(value == AttributeType) return;

				OptionSetValue optionSetValue = null;
				if(value != null) optionSetValue = new OptionSetValue((int)value);
				SetAttributeValue("msdyn_attributeType", optionSetValue); 
			}
		}

		/// <summary>
        /// msdyn_attributeValue
        /// </summary>
		[DisplayName("Attribute value")]
		[AttributeLogicalName("msdyn_attributeValue")]
		public string AttributeValue
		{	
			get { return GetAttributeValue<string>("msdyn_attributeValue"); }
			set
			{ 
				if(value == AttributeValue) return;
				SetAttributeValue("msdyn_attributeValue", value);
			}
		}	
			
		/// <summary>
        /// msdyn_playbookactivityattributeid
        /// </summary>
		[DisplayName("Playbook activity attribute")]
		[AttributeLogicalName("msdyn_playbookactivityattributeid")]
		public override Guid Id
		{
			get => base.Id;
			set { base.Id = value; SetAttributeValue("msdyn_playbookactivityattributeid", value); }
		}

							/// <summary>
        /// msdyn_playbookactivityid
        /// </summary>
		[DisplayName("Playbook activity ID")]
		[AttributeLogicalName("msdyn_playbookactivityid")]
		public EntityReference PlaybookActivityID
		{	
			get { return GetAttributeValue<EntityReference>("msdyn_playbookactivityid"); }
			set
			{ 
				if(value == PlaybookActivityID) return;
				SetAttributeValue("msdyn_playbookactivityid", value);
			}
		}	
			
		/// <summary>
        /// msdyn_playbookactivityidname
        /// </summary>
		[DisplayName("msdyn_playbookactivityidname")]
		[AttributeLogicalName("msdyn_playbookactivityidname")]
		public string MsdynPlaybookactivityidname
		{	
			get { return GetAttributeValue<string>("msdyn_playbookactivityidname"); }
			set
			{ 
				if(value == MsdynPlaybookactivityidname) return;
				SetAttributeValue("msdyn_playbookactivityidname", value);
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
        /// 1:N Get entities for 'msdyn_playbookactivityattribute_AsyncOperations'
        /// </summary>
		[RelationshipSchemaName("msdyn_playbookactivityattribute_AsyncOperations")]
		public IEnumerable<SystemJob> MsdynPlaybookactivityattributeAsyncOperations
		{
			get { return GetRelatedEntities<SystemJob>("msdyn_playbookactivityattribute_AsyncOperations", null); }
			set { SetRelatedEntities("msdyn_playbookactivityattribute_AsyncOperations", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'msdyn_playbookactivityattribute_BulkDeleteFailures'
        /// </summary>
		[RelationshipSchemaName("msdyn_playbookactivityattribute_BulkDeleteFailures")]
		public IEnumerable<BulkDeleteFailure> MsdynPlaybookactivityattributeBulkDeleteFailures
		{
			get { return GetRelatedEntities<BulkDeleteFailure>("msdyn_playbookactivityattribute_BulkDeleteFailures", null); }
			set { SetRelatedEntities("msdyn_playbookactivityattribute_BulkDeleteFailures", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'msdyn_playbookactivityattribute_DuplicateBaseRecord'
        /// </summary>
		[RelationshipSchemaName("msdyn_playbookactivityattribute_DuplicateBaseRecord")]
		public IEnumerable<DuplicateRecord> MsdynPlaybookactivityattributeDuplicateBaseRecord
		{
			get { return GetRelatedEntities<DuplicateRecord>("msdyn_playbookactivityattribute_DuplicateBaseRecord", null); }
			set { SetRelatedEntities("msdyn_playbookactivityattribute_DuplicateBaseRecord", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'msdyn_playbookactivityattribute_DuplicateMatchingRecord'
        /// </summary>
		[RelationshipSchemaName("msdyn_playbookactivityattribute_DuplicateMatchingRecord")]
		public IEnumerable<DuplicateRecord> MsdynPlaybookactivityattributeDuplicateMatchingRecord
		{
			get { return GetRelatedEntities<DuplicateRecord>("msdyn_playbookactivityattribute_DuplicateMatchingRecord", null); }
			set { SetRelatedEntities("msdyn_playbookactivityattribute_DuplicateMatchingRecord", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'msdyn_playbookactivityattribute_MailboxTrackingFolders'
        /// </summary>
		[RelationshipSchemaName("msdyn_playbookactivityattribute_MailboxTrackingFolders")]
		public IEnumerable<MailboxAutoTrackingFolder> MsdynPlaybookactivityattributeMailboxTrackingFolders
		{
			get { return GetRelatedEntities<MailboxAutoTrackingFolder>("msdyn_playbookactivityattribute_MailboxTrackingFolders", null); }
			set { SetRelatedEntities("msdyn_playbookactivityattribute_MailboxTrackingFolders", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'msdyn_playbookactivityattribute_PrincipalObjectAttributeAccesses'
        /// </summary>
		[RelationshipSchemaName("msdyn_playbookactivityattribute_PrincipalObjectAttributeAccesses")]
		public IEnumerable<FieldSharing> MsdynPlaybookactivityattributePrincipalObjectAttributeAccesses
		{
			get { return GetRelatedEntities<FieldSharing>("msdyn_playbookactivityattribute_PrincipalObjectAttributeAccesses", null); }
			set { SetRelatedEntities("msdyn_playbookactivityattribute_PrincipalObjectAttributeAccesses", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'msdyn_playbookactivityattribute_ProcessSession'
        /// </summary>
		[RelationshipSchemaName("msdyn_playbookactivityattribute_ProcessSession")]
		public IEnumerable<ProcessSession> MsdynPlaybookactivityattributeProcessSession
		{
			get { return GetRelatedEntities<ProcessSession>("msdyn_playbookactivityattribute_ProcessSession", null); }
			set { SetRelatedEntities("msdyn_playbookactivityattribute_ProcessSession", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'msdyn_playbookactivityattribute_SyncErrors'
        /// </summary>
		[RelationshipSchemaName("msdyn_playbookactivityattribute_SyncErrors")]
		public IEnumerable<SyncError> MsdynPlaybookactivityattributeSyncErrors
		{
			get { return GetRelatedEntities<SyncError>("msdyn_playbookactivityattribute_SyncErrors", null); }
			set { SetRelatedEntities("msdyn_playbookactivityattribute_SyncErrors", null, value); }
		}
		#endregion

		#region Actions
		#endregion

		#region OptionSetEnums
		public enum eStatus
		{	
		
			[Label("Draft")]
			[Description(@"")]
			Draft = 0, 
		
			[Label("Published")]
			[Description(@"")]
			Published = 1, 
		}
		
		public enum eStatusReason
		{	
		
			[Label("Draft")]
			[Description(@"")]
			Draft_Active = 1, 
		
			[Label("Published")]
			[Description(@"")]
			Published_Inactive = 2, 
		}
		
		public enum eAttributeTypes
		{	
		
			[Label("string")]
			[Description(@"")]
			String = 1, 
		
			[Label("integer")]
			[Description(@"")]
			Integer = 2, 
		
			[Label("datetime")]
			[Description(@"")]
			Datetime = 3, 
		
			[Label("boolean")]
			[Description(@"")]
			Boolean = 4, 
		
			[Label("optionset")]
			[Description(@"")]
			Optionset = 5, 
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

			/// <summary>msdyn_attributeLogicalName</summary>
			public const string AttributeName = "msdyn_attributeLogicalName";

			/// <summary>msdyn_attributeType</summary>
			public const string AttributeType = "msdyn_attributeType";

			/// <summary>msdyn_attributeValue</summary>
			public const string AttributeValue = "msdyn_attributeValue";

			/// <summary>msdyn_playbookactivityattributeid</summary>
			public const string PlaybookActivityAttributeId = "msdyn_playbookactivityattributeid";

			/// <summary>msdyn_playbookactivityid</summary>
			public const string PlaybookActivityID = "msdyn_playbookactivityid";

			/// <summary>msdyn_playbookactivityidname</summary>
			public const string MsdynPlaybookactivityidname = "msdyn_playbookactivityidname";

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
			/// <summary>1:N msdyn_playbookactivityattribute_AsyncOperations</summary>
			public const string MsdynPlaybookactivityattributeAsyncOperations = "msdyn_playbookactivityattribute_AsyncOperations";

			/// <summary>1:N msdyn_playbookactivityattribute_BulkDeleteFailures</summary>
			public const string MsdynPlaybookactivityattributeBulkDeleteFailures = "msdyn_playbookactivityattribute_BulkDeleteFailures";

			/// <summary>1:N msdyn_playbookactivityattribute_DuplicateBaseRecord</summary>
			public const string MsdynPlaybookactivityattributeDuplicateBaseRecord = "msdyn_playbookactivityattribute_DuplicateBaseRecord";

			/// <summary>1:N msdyn_playbookactivityattribute_DuplicateMatchingRecord</summary>
			public const string MsdynPlaybookactivityattributeDuplicateMatchingRecord = "msdyn_playbookactivityattribute_DuplicateMatchingRecord";

			/// <summary>1:N msdyn_playbookactivityattribute_MailboxTrackingFolders</summary>
			public const string MsdynPlaybookactivityattributeMailboxTrackingFolders = "msdyn_playbookactivityattribute_MailboxTrackingFolders";

			/// <summary>1:N msdyn_playbookactivityattribute_PrincipalObjectAttributeAccesses</summary>
			public const string MsdynPlaybookactivityattributePrincipalObjectAttributeAccesses = "msdyn_playbookactivityattribute_PrincipalObjectAttributeAccesses";

			/// <summary>1:N msdyn_playbookactivityattribute_ProcessSession</summary>
			public const string MsdynPlaybookactivityattributeProcessSession = "msdyn_playbookactivityattribute_ProcessSession";

			/// <summary>1:N msdyn_playbookactivityattribute_SyncErrors</summary>
			public const string MsdynPlaybookactivityattributeSyncErrors = "msdyn_playbookactivityattribute_SyncErrors";

		}
		#endregion
	}
}

