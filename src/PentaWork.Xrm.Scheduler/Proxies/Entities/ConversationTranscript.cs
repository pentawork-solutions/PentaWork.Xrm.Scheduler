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
	[EntityLogicalName("conversationtranscript")]
	public sealed class ConversationTranscript : Entity
	{	
		public static readonly int? EntityTypeCode = 10033;
		public new const string LogicalName = "conversationtranscript";
		public const string PrimaryIdAttribute = "conversationtranscriptid";
		public const string PrimaryNameAttribute = "name";
	
		public ConversationTranscript() : base("conversationtranscript") { }

		#region Attributes
		/// <summary>
        /// bot_conversationtranscriptid
        /// </summary>
		[DisplayName("bot_conversationtranscript")]
		[AttributeLogicalName("bot_conversationtranscriptid")]
		public EntityReference BotConversationtranscript
		{	
			get { return GetAttributeValue<EntityReference>("bot_conversationtranscriptid"); }
			set
			{ 
				if(value == BotConversationtranscript) return;
				SetAttributeValue("bot_conversationtranscriptid", value);
			}
		}	
			
		/// <summary>
        /// bot_conversationtranscriptidname
        /// </summary>
		[DisplayName("bot_conversationtranscriptidname")]
		[AttributeLogicalName("bot_conversationtranscriptidname")]
		public string BotConversationtranscriptidname
		{	
			get { return GetAttributeValue<string>("bot_conversationtranscriptidname"); }
			set
			{ 
				if(value == BotConversationtranscriptidname) return;
				SetAttributeValue("bot_conversationtranscriptidname", value);
			}
		}	
			
		/// <summary>
        /// content
        /// </summary>
		[DisplayName("Content")]
		[AttributeLogicalName("content")]
		public string Content
		{	
			get { return GetAttributeValue<string>("content"); }
			set
			{ 
				if(value == Content) return;
				SetAttributeValue("content", value);
			}
		}	
			
		/// <summary>
        /// conversationstarttime
        /// </summary>
		[DisplayName("ConversationStartTime")]
		[AttributeLogicalName("conversationstarttime")]
		public DateTime? ConversationStartTime
		{	
			get { return GetAttributeValue<DateTime?>("conversationstarttime"); }
			set
			{ 
				if(value == ConversationStartTime) return;
				SetAttributeValue("conversationstarttime", value);
			}
		}	
			
		/// <summary>
        /// conversationtranscriptid
        /// </summary>
		[DisplayName("conversationtranscript")]
		[AttributeLogicalName("conversationtranscriptid")]
		public override Guid Id
		{
			get => base.Id;
			set { base.Id = value; SetAttributeValue("conversationtranscriptid", value); }
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
        /// metadata
        /// </summary>
		[DisplayName("Metadata")]
		[AttributeLogicalName("metadata")]
		public string Metadata
		{	
			get { return GetAttributeValue<string>("metadata"); }
			set
			{ 
				if(value == Metadata) return;
				SetAttributeValue("metadata", value);
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
        /// schematype
        /// </summary>
		[DisplayName("SchemaType")]
		[AttributeLogicalName("schematype")]
		public string SchemaType
		{	
			get { return GetAttributeValue<string>("schematype"); }
			set
			{ 
				if(value == SchemaType) return;
				SetAttributeValue("schematype", value);
			}
		}	
			
		/// <summary>
        /// schemaversion
        /// </summary>
		[DisplayName("ContentSchemaVersion")]
		[AttributeLogicalName("schemaversion")]
		public string ContentSchemaVersion
		{	
			get { return GetAttributeValue<string>("schemaversion"); }
			set
			{ 
				if(value == ContentSchemaVersion) return;
				SetAttributeValue("schemaversion", value);
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
        /// 1:N Get entities for 'conversationtranscript_AsyncOperations'
        /// </summary>
		[RelationshipSchemaName("conversationtranscript_AsyncOperations")]
		public IEnumerable<SystemJob> ConversationtranscriptAsyncOperations
		{
			get { return GetRelatedEntities<SystemJob>("conversationtranscript_AsyncOperations", null); }
			set { SetRelatedEntities("conversationtranscript_AsyncOperations", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'conversationtranscript_BulkDeleteFailures'
        /// </summary>
		[RelationshipSchemaName("conversationtranscript_BulkDeleteFailures")]
		public IEnumerable<BulkDeleteFailure> ConversationtranscriptBulkDeleteFailures
		{
			get { return GetRelatedEntities<BulkDeleteFailure>("conversationtranscript_BulkDeleteFailures", null); }
			set { SetRelatedEntities("conversationtranscript_BulkDeleteFailures", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'conversationtranscript_DuplicateBaseRecord'
        /// </summary>
		[RelationshipSchemaName("conversationtranscript_DuplicateBaseRecord")]
		public IEnumerable<DuplicateRecord> ConversationtranscriptDuplicateBaseRecord
		{
			get { return GetRelatedEntities<DuplicateRecord>("conversationtranscript_DuplicateBaseRecord", null); }
			set { SetRelatedEntities("conversationtranscript_DuplicateBaseRecord", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'conversationtranscript_DuplicateMatchingRecord'
        /// </summary>
		[RelationshipSchemaName("conversationtranscript_DuplicateMatchingRecord")]
		public IEnumerable<DuplicateRecord> ConversationtranscriptDuplicateMatchingRecord
		{
			get { return GetRelatedEntities<DuplicateRecord>("conversationtranscript_DuplicateMatchingRecord", null); }
			set { SetRelatedEntities("conversationtranscript_DuplicateMatchingRecord", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'conversationtranscript_MailboxTrackingFolders'
        /// </summary>
		[RelationshipSchemaName("conversationtranscript_MailboxTrackingFolders")]
		public IEnumerable<MailboxAutoTrackingFolder> ConversationtranscriptMailboxTrackingFolders
		{
			get { return GetRelatedEntities<MailboxAutoTrackingFolder>("conversationtranscript_MailboxTrackingFolders", null); }
			set { SetRelatedEntities("conversationtranscript_MailboxTrackingFolders", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'conversationtranscript_PrincipalObjectAttributeAccesses'
        /// </summary>
		[RelationshipSchemaName("conversationtranscript_PrincipalObjectAttributeAccesses")]
		public IEnumerable<FieldSharing> ConversationtranscriptPrincipalObjectAttributeAccesses
		{
			get { return GetRelatedEntities<FieldSharing>("conversationtranscript_PrincipalObjectAttributeAccesses", null); }
			set { SetRelatedEntities("conversationtranscript_PrincipalObjectAttributeAccesses", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'conversationtranscript_ProcessSession'
        /// </summary>
		[RelationshipSchemaName("conversationtranscript_ProcessSession")]
		public IEnumerable<ProcessSession> ConversationtranscriptProcessSession
		{
			get { return GetRelatedEntities<ProcessSession>("conversationtranscript_ProcessSession", null); }
			set { SetRelatedEntities("conversationtranscript_ProcessSession", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'conversationtranscript_SyncErrors'
        /// </summary>
		[RelationshipSchemaName("conversationtranscript_SyncErrors")]
		public IEnumerable<SyncError> ConversationtranscriptSyncErrors
		{
			get { return GetRelatedEntities<SyncError>("conversationtranscript_SyncErrors", null); }
			set { SetRelatedEntities("conversationtranscript_SyncErrors", null, value); }
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
			/// <summary>bot_conversationtranscriptid</summary>
			public const string BotConversationtranscript = "bot_conversationtranscriptid";

			/// <summary>bot_conversationtranscriptidname</summary>
			public const string BotConversationtranscriptidname = "bot_conversationtranscriptidname";

			/// <summary>content</summary>
			public const string Content = "content";

			/// <summary>conversationstarttime</summary>
			public const string ConversationStartTime = "conversationstarttime";

			/// <summary>conversationtranscriptid</summary>
			public const string ConversationtranscriptId = "conversationtranscriptid";

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

			/// <summary>metadata</summary>
			public const string Metadata = "metadata";

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

			/// <summary>schematype</summary>
			public const string SchemaType = "schematype";

			/// <summary>schemaversion</summary>
			public const string ContentSchemaVersion = "schemaversion";

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
			/// <summary>1:N conversationtranscript_AsyncOperations</summary>
			public const string ConversationtranscriptAsyncOperations = "conversationtranscript_AsyncOperations";

			/// <summary>1:N conversationtranscript_BulkDeleteFailures</summary>
			public const string ConversationtranscriptBulkDeleteFailures = "conversationtranscript_BulkDeleteFailures";

			/// <summary>1:N conversationtranscript_DuplicateBaseRecord</summary>
			public const string ConversationtranscriptDuplicateBaseRecord = "conversationtranscript_DuplicateBaseRecord";

			/// <summary>1:N conversationtranscript_DuplicateMatchingRecord</summary>
			public const string ConversationtranscriptDuplicateMatchingRecord = "conversationtranscript_DuplicateMatchingRecord";

			/// <summary>1:N conversationtranscript_MailboxTrackingFolders</summary>
			public const string ConversationtranscriptMailboxTrackingFolders = "conversationtranscript_MailboxTrackingFolders";

			/// <summary>1:N conversationtranscript_PrincipalObjectAttributeAccesses</summary>
			public const string ConversationtranscriptPrincipalObjectAttributeAccesses = "conversationtranscript_PrincipalObjectAttributeAccesses";

			/// <summary>1:N conversationtranscript_ProcessSession</summary>
			public const string ConversationtranscriptProcessSession = "conversationtranscript_ProcessSession";

			/// <summary>1:N conversationtranscript_SyncErrors</summary>
			public const string ConversationtranscriptSyncErrors = "conversationtranscript_SyncErrors";

		}
		#endregion
	}
}

