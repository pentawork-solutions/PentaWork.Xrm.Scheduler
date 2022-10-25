using System;
using System.Linq;
using System.Diagnostics;
using System.ComponentModel;
using Microsoft.Xrm.Sdk; 
using Microsoft.Xrm.Sdk.Client;
using System.Collections.Generic;

namespace PentaWork.Xrm.Scheduler.Proxies.Entities
{
	[DebuggerDisplay("{ListOperationPrimaryName}")] 	
	[EntityLogicalName("listoperation")]
	public sealed class ListOperation : Entity
	{	
		public static readonly int? EntityTypeCode = 10066;
		public new const string LogicalName = "listoperation";
		public const string PrimaryIdAttribute = "listoperationid";
		public const string PrimaryNameAttribute = "listoperationprimaryname";
	
		public ListOperation() : base("listoperation") { }

		#region Attributes
		/// <summary>
        /// added
        /// </summary>
		[DisplayName("Added")]
		[AttributeLogicalName("added")]
		public int? Added
		{	
			get { return GetAttributeValue<int?>("added"); }
			set
			{ 
				if(value == Added) return;
				SetAttributeValue("added", value);
			}
		}	
			
		/// <summary>
        /// batchinput
        /// </summary>
		[DisplayName("BatchInput")]
		[AttributeLogicalName("batchinput")]
		public string BatchInput
		{	
			get { return GetAttributeValue<string>("batchinput"); }
			set
			{ 
				if(value == BatchInput) return;
				SetAttributeValue("batchinput", value);
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
        /// errordescription
        /// </summary>
		[DisplayName("ErrorDescription")]
		[AttributeLogicalName("errordescription")]
		public string ErrorDescription
		{	
			get { return GetAttributeValue<string>("errordescription"); }
			set
			{ 
				if(value == ErrorDescription) return;
				SetAttributeValue("errordescription", value);
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
        /// input
        /// </summary>
		[DisplayName("Input")]
		[AttributeLogicalName("input")]
		public string Input
		{	
			get { return GetAttributeValue<string>("input"); }
			set
			{ 
				if(value == Input) return;
				SetAttributeValue("input", value);
			}
		}	
			
		/// <summary>
        /// listid
        /// </summary>
		[DisplayName("List Id")]
		[AttributeLogicalName("listid")]
		public EntityReference ListId
		{	
			get { return GetAttributeValue<EntityReference>("listid"); }
			set
			{ 
				if(value == ListId) return;
				SetAttributeValue("listid", value);
			}
		}	
			
		/// <summary>
        /// listidname
        /// </summary>
		[DisplayName("listidname")]
		[AttributeLogicalName("listidname")]
		public string Listidname
		{	
			get { return GetAttributeValue<string>("listidname"); }
			set
			{ 
				if(value == Listidname) return;
				SetAttributeValue("listidname", value);
			}
		}	
			
		/// <summary>
        /// listoperationid
        /// </summary>
		[DisplayName("List Operation")]
		[AttributeLogicalName("listoperationid")]
		public override Guid Id
		{
			get => base.Id;
			set { base.Id = value; SetAttributeValue("listoperationid", value); }
		}

							/// <summary>
        /// listoperationname
        /// </summary>
		[DisplayName("List Operation Name")]
		[AttributeLogicalName("listoperationname")]
		public string ListOperationName
		{	
			get { return GetAttributeValue<string>("listoperationname"); }
			set
			{ 
				if(value == ListOperationName) return;
				SetAttributeValue("listoperationname", value);
			}
		}	
			
		/// <summary>
        /// listoperationprimaryname
        /// </summary>
		[DisplayName("List Operation Primary Name")]
		[AttributeLogicalName("listoperationprimaryname")]
		public string ListOperationPrimaryName
		{	
			get { return GetAttributeValue<string>("listoperationprimaryname"); }
			set
			{ 
				if(value == ListOperationPrimaryName) return;
				SetAttributeValue("listoperationprimaryname", value);
			}
		}	
			
		/// <summary>
        /// log
        /// </summary>
		[DisplayName("Log")]
		[AttributeLogicalName("log")]
		public string Log
		{	
			get { return GetAttributeValue<string>("log"); }
			set
			{ 
				if(value == Log) return;
				SetAttributeValue("log", value);
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
        /// processed
        /// </summary>
		[DisplayName("Processed")]
		[AttributeLogicalName("processed")]
		public int? Processed
		{	
			get { return GetAttributeValue<int?>("processed"); }
			set
			{ 
				if(value == Processed) return;
				SetAttributeValue("processed", value);
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
        /// type
        /// </summary>
		[DisplayName("Type")]
		[AttributeLogicalName("type")]
		public eType? Type
		{	
			get 
			{ 
				var optionSetValue = GetAttributeValue<OptionSetValue>("type");
				if (optionSetValue != null) return (eType)optionSetValue.Value;
				else return null;
			}
			set 
			{ 
				if(value == Type) return;

				OptionSetValue optionSetValue = null;
				if(value != null) optionSetValue = new OptionSetValue((int)value);
				SetAttributeValue("type", optionSetValue); 
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
        /// 1:N Get entities for 'listoperation_AsyncOperations'
        /// </summary>
		[RelationshipSchemaName("listoperation_AsyncOperations")]
		public IEnumerable<SystemJob> ListoperationAsyncOperations
		{
			get { return GetRelatedEntities<SystemJob>("listoperation_AsyncOperations", null); }
			set { SetRelatedEntities("listoperation_AsyncOperations", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'listoperation_BulkDeleteFailures'
        /// </summary>
		[RelationshipSchemaName("listoperation_BulkDeleteFailures")]
		public IEnumerable<BulkDeleteFailure> ListoperationBulkDeleteFailures
		{
			get { return GetRelatedEntities<BulkDeleteFailure>("listoperation_BulkDeleteFailures", null); }
			set { SetRelatedEntities("listoperation_BulkDeleteFailures", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'listoperation_MailboxTrackingFolders'
        /// </summary>
		[RelationshipSchemaName("listoperation_MailboxTrackingFolders")]
		public IEnumerable<MailboxAutoTrackingFolder> ListoperationMailboxTrackingFolders
		{
			get { return GetRelatedEntities<MailboxAutoTrackingFolder>("listoperation_MailboxTrackingFolders", null); }
			set { SetRelatedEntities("listoperation_MailboxTrackingFolders", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'listoperation_PrincipalObjectAttributeAccesses'
        /// </summary>
		[RelationshipSchemaName("listoperation_PrincipalObjectAttributeAccesses")]
		public IEnumerable<FieldSharing> ListoperationPrincipalObjectAttributeAccesses
		{
			get { return GetRelatedEntities<FieldSharing>("listoperation_PrincipalObjectAttributeAccesses", null); }
			set { SetRelatedEntities("listoperation_PrincipalObjectAttributeAccesses", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'listoperation_ProcessSession'
        /// </summary>
		[RelationshipSchemaName("listoperation_ProcessSession")]
		public IEnumerable<ProcessSession> ListoperationProcessSession
		{
			get { return GetRelatedEntities<ProcessSession>("listoperation_ProcessSession", null); }
			set { SetRelatedEntities("listoperation_ProcessSession", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'listoperation_SyncErrors'
        /// </summary>
		[RelationshipSchemaName("listoperation_SyncErrors")]
		public IEnumerable<SyncError> ListoperationSyncErrors
		{
			get { return GetRelatedEntities<SyncError>("listoperation_SyncErrors", null); }
			set { SetRelatedEntities("listoperation_SyncErrors", null, value); }
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
		
			[Label("Created")]
			[Description(@"")]
			Created_Active = 100000001, 
		
			[Label("In Progress")]
			[Description(@"")]
			InProgress_Active = 100000000, 
		
			[Label("Completed")]
			[Description(@"")]
			Completed_Active = 100000002, 
		
			[Label("Failed")]
			[Description(@"")]
			Failed_Active = 100000003, 
		
			[Label("Inactive")]
			[Description(@"")]
			Inactive_Inactive = 2, 
		}
		
		public enum eType
		{	
		
			[Label("Add members by query")]
			[Description(@"Adds members given a FetchXML query.")]
			AddMembersByQuery = 100000000, 
		
			[Label("Add members by id")]
			[Description(@"Adds a list of members given their identifiers.")]
			AddMembersById = 100000001, 
		
			[Label("Remove members by query")]
			[Description(@"Remove members given a FetchXML query.")]
			RemoveMembersByQuery = 100000002, 
		
			[Label("Remove members by id")]
			[Description(@"Removes a list of members given their identifiers.")]
			RemoveMembersById = 100000003, 
		}
		
		#endregion	

		#region Properties
		public static class Properties 
		{
			/// <summary>added</summary>
			public const string Added = "added";

			/// <summary>batchinput</summary>
			public const string BatchInput = "batchinput";

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

			/// <summary>errorcode</summary>
			public const string ErrorCode = "errorcode";

			/// <summary>errordescription</summary>
			public const string ErrorDescription = "errordescription";

			/// <summary>importsequencenumber</summary>
			public const string ImportSequenceNumber = "importsequencenumber";

			/// <summary>input</summary>
			public const string Input = "input";

			/// <summary>listid</summary>
			public const string ListId = "listid";

			/// <summary>listidname</summary>
			public const string Listidname = "listidname";

			/// <summary>listoperationid</summary>
			public const string ListOperationId = "listoperationid";

			/// <summary>listoperationname</summary>
			public const string ListOperationName = "listoperationname";

			/// <summary>listoperationprimaryname</summary>
			public const string ListOperationPrimaryName = "listoperationprimaryname";

			/// <summary>log</summary>
			public const string Log = "log";

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

			/// <summary>owningteam</summary>
			public const string OwningTeam = "owningteam";

			/// <summary>owninguser</summary>
			public const string OwningUser = "owninguser";

			/// <summary>processed</summary>
			public const string Processed = "processed";

			/// <summary>statecode</summary>
			public const string Status = "statecode";

			/// <summary>statuscode</summary>
			public const string StatusReason = "statuscode";

			/// <summary>timezoneruleversionnumber</summary>
			public const string TimeZoneRuleVersionNumber = "timezoneruleversionnumber";

			/// <summary>type</summary>
			public const string Type = "type";

			/// <summary>utcconversiontimezonecode</summary>
			public const string UTCConversionTimeZoneCode = "utcconversiontimezonecode";

			/// <summary>versionnumber</summary>
			public const string VersionNumber = "versionnumber";

		}
		#endregion

		#region Schemas
		public static class Schemas 
		{
			/// <summary>1:N listoperation_AsyncOperations</summary>
			public const string ListoperationAsyncOperations = "listoperation_AsyncOperations";

			/// <summary>1:N listoperation_BulkDeleteFailures</summary>
			public const string ListoperationBulkDeleteFailures = "listoperation_BulkDeleteFailures";

			/// <summary>1:N listoperation_MailboxTrackingFolders</summary>
			public const string ListoperationMailboxTrackingFolders = "listoperation_MailboxTrackingFolders";

			/// <summary>1:N listoperation_PrincipalObjectAttributeAccesses</summary>
			public const string ListoperationPrincipalObjectAttributeAccesses = "listoperation_PrincipalObjectAttributeAccesses";

			/// <summary>1:N listoperation_ProcessSession</summary>
			public const string ListoperationProcessSession = "listoperation_ProcessSession";

			/// <summary>1:N listoperation_SyncErrors</summary>
			public const string ListoperationSyncErrors = "listoperation_SyncErrors";

		}
		#endregion
	}
}

