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
	[EntityLogicalName("list")]
	public sealed class MarketingList : Entity
	{	
		public static readonly int? EntityTypeCode = 4300;
		public new const string LogicalName = "list";
		public const string PrimaryIdAttribute = "listid";
		public const string PrimaryNameAttribute = "listname";
	
		public MarketingList() : base("list") { }

		#region Attributes
		/// <summary>
        /// cost
        /// </summary>
		[DisplayName("Cost")]
		[AttributeLogicalName("cost")]
		public decimal? Cost
		{	
			get { return GetAttributeValue<Money>("cost")?.Value; }
			set 
			{ 
				if(value == Cost) return;

				Money moneyValue = null;
				if(value != null) moneyValue = new Money(value.Value);
				SetAttributeValue("cost", moneyValue);  
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
        /// createdfromcode
        /// </summary>
		[DisplayName("Marketing List Member Type")]
		[AttributeLogicalName("createdfromcode")]
		public eMarketingListMemberType? MarketingListMemberType
		{	
			get 
			{ 
				var optionSetValue = GetAttributeValue<OptionSetValue>("createdfromcode");
				if (optionSetValue != null) return (eMarketingListMemberType)optionSetValue.Value;
				else return null;
			}
			set 
			{ 
				if(value == MarketingListMemberType) return;

				OptionSetValue optionSetValue = null;
				if(value != null) optionSetValue = new OptionSetValue((int)value);
				SetAttributeValue("createdfromcode", optionSetValue); 
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
        /// description
        /// </summary>
		[DisplayName("Description")]
		[AttributeLogicalName("description")]
		public string Description
		{	
			get { return GetAttributeValue<string>("description"); }
			set
			{ 
				if(value == Description) return;
				SetAttributeValue("description", value);
			}
		}	
			
		/// <summary>
        /// donotsendonoptout
        /// </summary>
		[DisplayName("Exclude Members Who Opt Out")]
		[AttributeLogicalName("donotsendonoptout")]
		public bool? ExcludeMembersWhoOptOut
		{	
			get { return GetAttributeValue<bool?>("donotsendonoptout"); }
			set
			{ 
				if(value == ExcludeMembersWhoOptOut) return;
				SetAttributeValue("donotsendonoptout", value);
			}
		}	
			
		/// <summary>
        /// exchangerate
        /// </summary>
		[DisplayName("Exchange Rate")]
		[AttributeLogicalName("exchangerate")]
		public decimal? ExchangeRate
		{	
			get { return GetAttributeValue<decimal?>("exchangerate"); }
			set
			{ 
				if(value == ExchangeRate) return;
				SetAttributeValue("exchangerate", value);
			}
		}	
			
		/// <summary>
        /// ignoreinactivelistmembers
        /// </summary>
		[DisplayName("Ignore Inactive List Members")]
		[AttributeLogicalName("ignoreinactivelistmembers")]
		public bool? IgnoreInactiveListMembers
		{	
			get { return GetAttributeValue<bool?>("ignoreinactivelistmembers"); }
			set
			{ 
				if(value == IgnoreInactiveListMembers) return;
				SetAttributeValue("ignoreinactivelistmembers", value);
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
        /// lastusedon
        /// </summary>
		[DisplayName("Last Used On")]
		[AttributeLogicalName("lastusedon")]
		public DateTime? LastUsedOn
		{	
			get { return GetAttributeValue<DateTime?>("lastusedon"); }
			set
			{ 
				if(value == LastUsedOn) return;
				SetAttributeValue("lastusedon", value);
			}
		}	
			
		/// <summary>
        /// listid
        /// </summary>
		[DisplayName("Marketing List")]
		[AttributeLogicalName("listid")]
		public override Guid Id
		{
			get => base.Id;
			set { base.Id = value; SetAttributeValue("listid", value); }
		}

							/// <summary>
        /// listname
        /// </summary>
		[DisplayName("Name")]
		[AttributeLogicalName("listname")]
		public string Name
		{	
			get { return GetAttributeValue<string>("listname"); }
			set
			{ 
				if(value == Name) return;
				SetAttributeValue("listname", value);
			}
		}	
			
		/// <summary>
        /// lockstatus
        /// </summary>
		[DisplayName("Locked")]
		[AttributeLogicalName("lockstatus")]
		public bool? Locked
		{	
			get { return GetAttributeValue<bool?>("lockstatus"); }
			set
			{ 
				if(value == Locked) return;
				SetAttributeValue("lockstatus", value);
			}
		}	
			
		/// <summary>
        /// membercount
        /// </summary>
		[DisplayName("Members Count")]
		[AttributeLogicalName("membercount")]
		public int? MembersCount
		{	
			get { return GetAttributeValue<int?>("membercount"); }
			set
			{ 
				if(value == MembersCount) return;
				SetAttributeValue("membercount", value);
			}
		}	
			
		/// <summary>
        /// membertype
        /// </summary>
		[DisplayName("Member Type")]
		[AttributeLogicalName("membertype")]
		public int? MemberType
		{	
			get { return GetAttributeValue<int?>("membertype"); }
			set
			{ 
				if(value == MemberType) return;
				SetAttributeValue("membertype", value);
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
        /// processedmembercount
        /// </summary>
		[DisplayName("processedMemberCount")]
		[AttributeLogicalName("processedmembercount")]
		public int? ProcessedMemberCount
		{	
			get { return GetAttributeValue<int?>("processedmembercount"); }
			set
			{ 
				if(value == ProcessedMemberCount) return;
				SetAttributeValue("processedmembercount", value);
			}
		}	
			
		/// <summary>
        /// processfetchxml
        /// </summary>
		[DisplayName("processFetchXML")]
		[AttributeLogicalName("processfetchxml")]
		public string ProcessFetchXML
		{	
			get { return GetAttributeValue<string>("processfetchxml"); }
			set
			{ 
				if(value == ProcessFetchXML) return;
				SetAttributeValue("processfetchxml", value);
			}
		}	
			
		/// <summary>
        /// processid
        /// </summary>
		[DisplayName("Process Id")]
		[AttributeLogicalName("processid")]
		public Guid ProcessId
		{	
			get { return GetAttributeValue<Guid>("processid"); }
			set
			{ 
				if(value == ProcessId) return;
				SetAttributeValue("processid", value);
			}
		}	
			
		/// <summary>
        /// purpose
        /// </summary>
		[DisplayName("Purpose")]
		[AttributeLogicalName("purpose")]
		public string Purpose
		{	
			get { return GetAttributeValue<string>("purpose"); }
			set
			{ 
				if(value == Purpose) return;
				SetAttributeValue("purpose", value);
			}
		}	
			
		/// <summary>
        /// query
        /// </summary>
		[DisplayName("Query")]
		[AttributeLogicalName("query")]
		public string Query
		{	
			get { return GetAttributeValue<string>("query"); }
			set
			{ 
				if(value == Query) return;
				SetAttributeValue("query", value);
			}
		}	
			
		/// <summary>
        /// source
        /// </summary>
		[DisplayName("Source")]
		[AttributeLogicalName("source")]
		public string Source
		{	
			get { return GetAttributeValue<string>("source"); }
			set
			{ 
				if(value == Source) return;
				SetAttributeValue("source", value);
			}
		}	
			
		/// <summary>
        /// stageid
        /// </summary>
		[DisplayName("(Deprecated) Stage Id")]
		[AttributeLogicalName("stageid")]
		public Guid DeprecatedStageId
		{	
			get { return GetAttributeValue<Guid>("stageid"); }
			set
			{ 
				if(value == DeprecatedStageId) return;
				SetAttributeValue("stageid", value);
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
        /// transactioncurrencyid
        /// </summary>
		[DisplayName("Currency")]
		[AttributeLogicalName("transactioncurrencyid")]
		public EntityReference Currency
		{	
			get { return GetAttributeValue<EntityReference>("transactioncurrencyid"); }
			set
			{ 
				if(value == Currency) return;
				SetAttributeValue("transactioncurrencyid", value);
			}
		}	
			
		/// <summary>
        /// transactioncurrencyidname
        /// </summary>
		[DisplayName("transactioncurrencyidname")]
		[AttributeLogicalName("transactioncurrencyidname")]
		public string Transactioncurrencyidname
		{	
			get { return GetAttributeValue<string>("transactioncurrencyidname"); }
			set
			{ 
				if(value == Transactioncurrencyidname) return;
				SetAttributeValue("transactioncurrencyidname", value);
			}
		}	
			
		/// <summary>
        /// traversedpath
        /// </summary>
		[DisplayName("(Deprecated) Traversed Path")]
		[AttributeLogicalName("traversedpath")]
		public string DeprecatedTraversedPath
		{	
			get { return GetAttributeValue<string>("traversedpath"); }
			set
			{ 
				if(value == DeprecatedTraversedPath) return;
				SetAttributeValue("traversedpath", value);
			}
		}	
			
		/// <summary>
        /// type
        /// </summary>
		[DisplayName("Type")]
		[AttributeLogicalName("type")]
		public bool? Type
		{	
			get { return GetAttributeValue<bool?>("type"); }
			set
			{ 
				if(value == Type) return;
				SetAttributeValue("type", value);
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
        /// 1:N Get entities for 'List_Annotation'
        /// </summary>
		[RelationshipSchemaName("List_Annotation")]
		public IEnumerable<Note> ListAnnotation
		{
			get { return GetRelatedEntities<Note>("List_Annotation", null); }
			set { SetRelatedEntities("List_Annotation", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'List_AsyncOperations'
        /// </summary>
		[RelationshipSchemaName("List_AsyncOperations")]
		public IEnumerable<SystemJob> ListAsyncOperations
		{
			get { return GetRelatedEntities<SystemJob>("List_AsyncOperations", null); }
			set { SetRelatedEntities("List_AsyncOperations", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'List_BulkDeleteFailures'
        /// </summary>
		[RelationshipSchemaName("List_BulkDeleteFailures")]
		public IEnumerable<BulkDeleteFailure> ListBulkDeleteFailures
		{
			get { return GetRelatedEntities<BulkDeleteFailure>("List_BulkDeleteFailures", null); }
			set { SetRelatedEntities("List_BulkDeleteFailures", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'List_BulkOperations'
        /// </summary>
		[RelationshipSchemaName("List_BulkOperations")]
		public IEnumerable<QuickCampaign> ListBulkOperations
		{
			get { return GetRelatedEntities<QuickCampaign>("List_BulkOperations", null); }
			set { SetRelatedEntities("List_BulkOperations", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'list_connections1'
        /// </summary>
		[RelationshipSchemaName("list_connections1")]
		public IEnumerable<Connection> ListConnections1
		{
			get { return GetRelatedEntities<Connection>("list_connections1", null); }
			set { SetRelatedEntities("list_connections1", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'list_connections2'
        /// </summary>
		[RelationshipSchemaName("list_connections2")]
		public IEnumerable<Connection> ListConnections2
		{
			get { return GetRelatedEntities<Connection>("list_connections2", null); }
			set { SetRelatedEntities("list_connections2", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'List_DuplicateBaseRecord'
        /// </summary>
		[RelationshipSchemaName("List_DuplicateBaseRecord")]
		public IEnumerable<DuplicateRecord> ListDuplicateBaseRecord
		{
			get { return GetRelatedEntities<DuplicateRecord>("List_DuplicateBaseRecord", null); }
			set { SetRelatedEntities("List_DuplicateBaseRecord", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'List_DuplicateMatchingRecord'
        /// </summary>
		[RelationshipSchemaName("List_DuplicateMatchingRecord")]
		public IEnumerable<DuplicateRecord> ListDuplicateMatchingRecord
		{
			get { return GetRelatedEntities<DuplicateRecord>("List_DuplicateMatchingRecord", null); }
			set { SetRelatedEntities("List_DuplicateMatchingRecord", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'list_listoperation_ListId'
        /// </summary>
		[RelationshipSchemaName("list_listoperation_ListId")]
		public IEnumerable<ListOperation> ListListoperationListId
		{
			get { return GetRelatedEntities<ListOperation>("list_listoperation_ListId", null); }
			set { SetRelatedEntities("list_listoperation_ListId", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'list_MailboxTrackingFolders'
        /// </summary>
		[RelationshipSchemaName("list_MailboxTrackingFolders")]
		public IEnumerable<MailboxAutoTrackingFolder> ListMailboxTrackingFolders
		{
			get { return GetRelatedEntities<MailboxAutoTrackingFolder>("list_MailboxTrackingFolders", null); }
			set { SetRelatedEntities("list_MailboxTrackingFolders", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'list_principalobjectattributeaccess'
        /// </summary>
		[RelationshipSchemaName("list_principalobjectattributeaccess")]
		public IEnumerable<FieldSharing> ListPrincipalobjectattributeaccess
		{
			get { return GetRelatedEntities<FieldSharing>("list_principalobjectattributeaccess", null); }
			set { SetRelatedEntities("list_principalobjectattributeaccess", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'List_ProcessSessions'
        /// </summary>
		[RelationshipSchemaName("List_ProcessSessions")]
		public IEnumerable<ProcessSession> ListProcessSessions
		{
			get { return GetRelatedEntities<ProcessSession>("List_ProcessSessions", null); }
			set { SetRelatedEntities("List_ProcessSessions", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'List_SyncErrors'
        /// </summary>
		[RelationshipSchemaName("List_SyncErrors")]
		public IEnumerable<SyncError> ListSyncErrors
		{
			get { return GetRelatedEntities<SyncError>("List_SyncErrors", null); }
			set { SetRelatedEntities("List_SyncErrors", null, value); }
		}
		/// <summary>
        /// N:N Get entities for 'CampaignActivity'
        /// </summary>
		[RelationshipSchemaName("campaignactivitylist_association")]
		public IEnumerable<CampaignActivity> CampaignactivitylistAssociation
		{
			get { return GetRelatedEntities<CampaignActivity>("campaignactivitylist_association", null); }
			set { SetRelatedEntities("campaignactivitylist_association", null, value); }
		}
		/// <summary>
        /// N:N Get entities for 'Campaign'
        /// </summary>
		[RelationshipSchemaName("campaignlist_association")]
		public IEnumerable<Campaign> CampaignlistAssociation
		{
			get { return GetRelatedEntities<Campaign>("campaignlist_association", null); }
			set { SetRelatedEntities("campaignlist_association", null, value); }
		}
		/// <summary>
        /// N:N Get entities for 'Account'
        /// </summary>
		[RelationshipSchemaName("listaccount_association")]
		public IEnumerable<Account> ListaccountAssociation
		{
			get { return GetRelatedEntities<Account>("listaccount_association", null); }
			set { SetRelatedEntities("listaccount_association", null, value); }
		}
		/// <summary>
        /// N:N Get entities for 'Contact'
        /// </summary>
		[RelationshipSchemaName("listcontact_association")]
		public IEnumerable<Contact> ListcontactAssociation
		{
			get { return GetRelatedEntities<Contact>("listcontact_association", null); }
			set { SetRelatedEntities("listcontact_association", null, value); }
		}
		/// <summary>
        /// N:N Get entities for 'Lead'
        /// </summary>
		[RelationshipSchemaName("listlead_association")]
		public IEnumerable<Lead> ListleadAssociation
		{
			get { return GetRelatedEntities<Lead>("listlead_association", null); }
			set { SetRelatedEntities("listlead_association", null, value); }
		}
		#endregion

		#region Actions
		#endregion

		#region OptionSetEnums
		public enum eMarketingListMemberType
		{	
		
			[Label("Account")]
			[Description(@"")]
			Account = 1, 
		
			[Label("Contact")]
			[Description(@"")]
			Contact = 2, 
		
			[Label("Lead")]
			[Description(@"")]
			Lead = 4, 
		}
		
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
			Active_Active = 0, 
		
			[Label("Inactive")]
			[Description(@"")]
			Inactive_Inactive = 1, 
		}
		
		#endregion	

		#region Properties
		public static class Properties 
		{
			/// <summary>cost</summary>
			public const string Cost = "cost";

			/// <summary>createdby</summary>
			public const string CreatedBy = "createdby";

			/// <summary>createdbyname</summary>
			public const string Createdbyname = "createdbyname";

			/// <summary>createdbyyominame</summary>
			public const string Createdbyyominame = "createdbyyominame";

			/// <summary>createdfromcode</summary>
			public const string MarketingListMemberType = "createdfromcode";

			/// <summary>createdon</summary>
			public const string CreatedOn = "createdon";

			/// <summary>createdonbehalfby</summary>
			public const string CreatedByDelegate = "createdonbehalfby";

			/// <summary>createdonbehalfbyname</summary>
			public const string Createdonbehalfbyname = "createdonbehalfbyname";

			/// <summary>createdonbehalfbyyominame</summary>
			public const string Createdonbehalfbyyominame = "createdonbehalfbyyominame";

			/// <summary>description</summary>
			public const string Description = "description";

			/// <summary>donotsendonoptout</summary>
			public const string ExcludeMembersWhoOptOut = "donotsendonoptout";

			/// <summary>exchangerate</summary>
			public const string ExchangeRate = "exchangerate";

			/// <summary>ignoreinactivelistmembers</summary>
			public const string IgnoreInactiveListMembers = "ignoreinactivelistmembers";

			/// <summary>importsequencenumber</summary>
			public const string ImportSequenceNumber = "importsequencenumber";

			/// <summary>lastusedon</summary>
			public const string LastUsedOn = "lastusedon";

			/// <summary>listid</summary>
			public const string MarketingListId = "listid";

			/// <summary>listname</summary>
			public const string Name = "listname";

			/// <summary>lockstatus</summary>
			public const string Locked = "lockstatus";

			/// <summary>membercount</summary>
			public const string MembersCount = "membercount";

			/// <summary>membertype</summary>
			public const string MemberType = "membertype";

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

			/// <summary>processedmembercount</summary>
			public const string ProcessedMemberCount = "processedmembercount";

			/// <summary>processfetchxml</summary>
			public const string ProcessFetchXML = "processfetchxml";

			/// <summary>processid</summary>
			public const string ProcessId = "processid";

			/// <summary>purpose</summary>
			public const string Purpose = "purpose";

			/// <summary>query</summary>
			public const string Query = "query";

			/// <summary>source</summary>
			public const string Source = "source";

			/// <summary>stageid</summary>
			public const string DeprecatedStageId = "stageid";

			/// <summary>statecode</summary>
			public const string Status = "statecode";

			/// <summary>statuscode</summary>
			public const string StatusReason = "statuscode";

			/// <summary>timezoneruleversionnumber</summary>
			public const string TimeZoneRuleVersionNumber = "timezoneruleversionnumber";

			/// <summary>transactioncurrencyid</summary>
			public const string Currency = "transactioncurrencyid";

			/// <summary>transactioncurrencyidname</summary>
			public const string Transactioncurrencyidname = "transactioncurrencyidname";

			/// <summary>traversedpath</summary>
			public const string DeprecatedTraversedPath = "traversedpath";

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
			/// <summary>1:N List_Annotation</summary>
			public const string ListAnnotation = "List_Annotation";

			/// <summary>1:N List_AsyncOperations</summary>
			public const string ListAsyncOperations = "List_AsyncOperations";

			/// <summary>1:N List_BulkDeleteFailures</summary>
			public const string ListBulkDeleteFailures = "List_BulkDeleteFailures";

			/// <summary>1:N List_BulkOperations</summary>
			public const string ListBulkOperations = "List_BulkOperations";

			/// <summary>1:N list_connections1</summary>
			public const string ListConnections1 = "list_connections1";

			/// <summary>1:N list_connections2</summary>
			public const string ListConnections2 = "list_connections2";

			/// <summary>1:N List_DuplicateBaseRecord</summary>
			public const string ListDuplicateBaseRecord = "List_DuplicateBaseRecord";

			/// <summary>1:N List_DuplicateMatchingRecord</summary>
			public const string ListDuplicateMatchingRecord = "List_DuplicateMatchingRecord";

			/// <summary>1:N list_listoperation_ListId</summary>
			public const string ListListoperationListId = "list_listoperation_ListId";

			/// <summary>1:N list_MailboxTrackingFolders</summary>
			public const string ListMailboxTrackingFolders = "list_MailboxTrackingFolders";

			/// <summary>1:N list_principalobjectattributeaccess</summary>
			public const string ListPrincipalobjectattributeaccess = "list_principalobjectattributeaccess";

			/// <summary>1:N List_ProcessSessions</summary>
			public const string ListProcessSessions = "List_ProcessSessions";

			/// <summary>1:N List_SyncErrors</summary>
			public const string ListSyncErrors = "List_SyncErrors";

			/// <summary>N:N campaignactivitylist_association</summary>
			public const string CampaignactivitylistAssociation = "campaignactivitylist_association";

			/// <summary>N:N campaignlist_association</summary>
			public const string CampaignlistAssociation = "campaignlist_association";

			/// <summary>N:N listaccount_association</summary>
			public const string ListaccountAssociation = "listaccount_association";

			/// <summary>N:N listcontact_association</summary>
			public const string ListcontactAssociation = "listcontact_association";

			/// <summary>N:N listlead_association</summary>
			public const string ListleadAssociation = "listlead_association";

		}
		#endregion
	}
}

