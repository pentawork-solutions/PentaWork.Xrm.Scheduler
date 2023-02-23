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
	[EntityLogicalName("bookableresourcecharacteristic")]
	public sealed class BookableResourceCharacteristic : Entity
	{	
		public static readonly int? EntityTypeCode = 1148;
		public new const string LogicalName = "bookableresourcecharacteristic";
		public const string PrimaryIdAttribute = "bookableresourcecharacteristicid";
		public const string PrimaryNameAttribute = "name";
	
		public BookableResourceCharacteristic() : base("bookableresourcecharacteristic") { }

		#region Attributes
		/// <summary>
        /// bookableresourcecharacteristicid
        /// </summary>
		[DisplayName("Bookable Resource Characteristic")]
		[AttributeLogicalName("bookableresourcecharacteristicid")]
		public override Guid Id
		{
			get => base.Id;
			set { base.Id = value; SetAttributeValue("bookableresourcecharacteristicid", value); }
		}

							/// <summary>
        /// characteristic
        /// </summary>
		[DisplayName("Characteristic")]
		[AttributeLogicalName("characteristic")]
		public EntityReference Characteristic
		{	
			get { return GetAttributeValue<EntityReference>("characteristic"); }
			set
			{ 
				if(value == Characteristic) return;
				SetAttributeValue("characteristic", value);
			}
		}	
			
		/// <summary>
        /// characteristicname
        /// </summary>
		[DisplayName("characteristicname")]
		[AttributeLogicalName("characteristicname")]
		public string Characteristicname
		{	
			get { return GetAttributeValue<string>("characteristicname"); }
			set
			{ 
				if(value == Characteristicname) return;
				SetAttributeValue("characteristicname", value);
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
        /// exchangerate
		///
		/// Precision: 10
		/// MaxValue: 100000000000
		/// MinValue: 0.0000000001
        /// </summary>
		[DisplayName("ExchangeRate")]
		[AttributeLogicalName("exchangerate")]
		public decimal? ExchangeRate
		{	
			get { return GetAttributeValue<decimal?>("exchangerate"); }
			set 
			{
				decimal? decimalValue = null;
				if(value != null) decimalValue = Decimal.Round(value.Value, 10);
				if(decimalValue == ExchangeRate) return;
				SetAttributeValue("exchangerate", decimalValue);  
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
        /// ratingvalue
        /// </summary>
		[DisplayName("Rating Value")]
		[AttributeLogicalName("ratingvalue")]
		public EntityReference RatingValue
		{	
			get { return GetAttributeValue<EntityReference>("ratingvalue"); }
			set
			{ 
				if(value == RatingValue) return;
				SetAttributeValue("ratingvalue", value);
			}
		}	
			
		/// <summary>
        /// ratingvaluename
        /// </summary>
		[DisplayName("ratingvaluename")]
		[AttributeLogicalName("ratingvaluename")]
		public string Ratingvaluename
		{	
			get { return GetAttributeValue<string>("ratingvaluename"); }
			set
			{ 
				if(value == Ratingvaluename) return;
				SetAttributeValue("ratingvaluename", value);
			}
		}	
			
		/// <summary>
        /// resource
        /// </summary>
		[DisplayName("Resource")]
		[AttributeLogicalName("resource")]
		public EntityReference Resource
		{	
			get { return GetAttributeValue<EntityReference>("resource"); }
			set
			{ 
				if(value == Resource) return;
				SetAttributeValue("resource", value);
			}
		}	
			
		/// <summary>
        /// resourcename
        /// </summary>
		[DisplayName("resourcename")]
		[AttributeLogicalName("resourcename")]
		public string Resourcename
		{	
			get { return GetAttributeValue<string>("resourcename"); }
			set
			{ 
				if(value == Resourcename) return;
				SetAttributeValue("resourcename", value);
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
        /// 1:N Get entities for 'bookableresourcecharacteristic_Annotations'
        /// </summary>
		[RelationshipSchemaName("bookableresourcecharacteristic_Annotations")]
		public IEnumerable<Note> BookableresourcecharacteristicAnnotations
		{
			get { return GetRelatedEntities<Note>("bookableresourcecharacteristic_Annotations", null); }
			set { SetRelatedEntities("bookableresourcecharacteristic_Annotations", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'bookableresourcecharacteristic_AsyncOperations'
        /// </summary>
		[RelationshipSchemaName("bookableresourcecharacteristic_AsyncOperations")]
		public IEnumerable<SystemJob> BookableresourcecharacteristicAsyncOperations
		{
			get { return GetRelatedEntities<SystemJob>("bookableresourcecharacteristic_AsyncOperations", null); }
			set { SetRelatedEntities("bookableresourcecharacteristic_AsyncOperations", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'bookableresourcecharacteristic_BulkDeleteFailures'
        /// </summary>
		[RelationshipSchemaName("bookableresourcecharacteristic_BulkDeleteFailures")]
		public IEnumerable<BulkDeleteFailure> BookableresourcecharacteristicBulkDeleteFailures
		{
			get { return GetRelatedEntities<BulkDeleteFailure>("bookableresourcecharacteristic_BulkDeleteFailures", null); }
			set { SetRelatedEntities("bookableresourcecharacteristic_BulkDeleteFailures", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'bookableresourcecharacteristic_DuplicateBaseRecord'
        /// </summary>
		[RelationshipSchemaName("bookableresourcecharacteristic_DuplicateBaseRecord")]
		public IEnumerable<DuplicateRecord> BookableresourcecharacteristicDuplicateBaseRecord
		{
			get { return GetRelatedEntities<DuplicateRecord>("bookableresourcecharacteristic_DuplicateBaseRecord", null); }
			set { SetRelatedEntities("bookableresourcecharacteristic_DuplicateBaseRecord", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'bookableresourcecharacteristic_DuplicateMatchingRecord'
        /// </summary>
		[RelationshipSchemaName("bookableresourcecharacteristic_DuplicateMatchingRecord")]
		public IEnumerable<DuplicateRecord> BookableresourcecharacteristicDuplicateMatchingRecord
		{
			get { return GetRelatedEntities<DuplicateRecord>("bookableresourcecharacteristic_DuplicateMatchingRecord", null); }
			set { SetRelatedEntities("bookableresourcecharacteristic_DuplicateMatchingRecord", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'bookableresourcecharacteristic_MailboxTrackingFolders'
        /// </summary>
		[RelationshipSchemaName("bookableresourcecharacteristic_MailboxTrackingFolders")]
		public IEnumerable<MailboxAutoTrackingFolder> BookableresourcecharacteristicMailboxTrackingFolders
		{
			get { return GetRelatedEntities<MailboxAutoTrackingFolder>("bookableresourcecharacteristic_MailboxTrackingFolders", null); }
			set { SetRelatedEntities("bookableresourcecharacteristic_MailboxTrackingFolders", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'bookableresourcecharacteristic_PrincipalObjectAttributeAccess'
        /// </summary>
		[RelationshipSchemaName("bookableresourcecharacteristic_PrincipalObjectAttributeAccess")]
		public IEnumerable<FieldSharing> BookableresourcecharacteristicPrincipalObjectAttributeAccess
		{
			get { return GetRelatedEntities<FieldSharing>("bookableresourcecharacteristic_PrincipalObjectAttributeAccess", null); }
			set { SetRelatedEntities("bookableresourcecharacteristic_PrincipalObjectAttributeAccess", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'bookableresourcecharacteristic_ProcessSession'
        /// </summary>
		[RelationshipSchemaName("bookableresourcecharacteristic_ProcessSession")]
		public IEnumerable<ProcessSession> BookableresourcecharacteristicProcessSession
		{
			get { return GetRelatedEntities<ProcessSession>("bookableresourcecharacteristic_ProcessSession", null); }
			set { SetRelatedEntities("bookableresourcecharacteristic_ProcessSession", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'BookableResourceCharacteristic_SyncErrors'
        /// </summary>
		[RelationshipSchemaName("BookableResourceCharacteristic_SyncErrors")]
		public IEnumerable<SyncError> BookableResourceCharacteristicSyncErrors
		{
			get { return GetRelatedEntities<SyncError>("BookableResourceCharacteristic_SyncErrors", null); }
			set { SetRelatedEntities("BookableResourceCharacteristic_SyncErrors", null, value); }
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
			/// <summary>bookableresourcecharacteristicid</summary>
			public const string BookableResourceCharacteristicId = "bookableresourcecharacteristicid";

			/// <summary>characteristic</summary>
			public const string Characteristic = "characteristic";

			/// <summary>characteristicname</summary>
			public const string Characteristicname = "characteristicname";

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

			/// <summary>exchangerate</summary>
			public const string ExchangeRate = "exchangerate";

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

			/// <summary>processid</summary>
			public const string ProcessId = "processid";

			/// <summary>ratingvalue</summary>
			public const string RatingValue = "ratingvalue";

			/// <summary>ratingvaluename</summary>
			public const string Ratingvaluename = "ratingvaluename";

			/// <summary>resource</summary>
			public const string Resource = "resource";

			/// <summary>resourcename</summary>
			public const string Resourcename = "resourcename";

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

			/// <summary>utcconversiontimezonecode</summary>
			public const string UTCConversionTimeZoneCode = "utcconversiontimezonecode";

			/// <summary>versionnumber</summary>
			public const string VersionNumber = "versionnumber";

		}
		#endregion

		#region Schemas
		public static class Schemas 
		{
			/// <summary>1:N bookableresourcecharacteristic_Annotations</summary>
			public const string BookableresourcecharacteristicAnnotations = "bookableresourcecharacteristic_Annotations";

			/// <summary>1:N bookableresourcecharacteristic_AsyncOperations</summary>
			public const string BookableresourcecharacteristicAsyncOperations = "bookableresourcecharacteristic_AsyncOperations";

			/// <summary>1:N bookableresourcecharacteristic_BulkDeleteFailures</summary>
			public const string BookableresourcecharacteristicBulkDeleteFailures = "bookableresourcecharacteristic_BulkDeleteFailures";

			/// <summary>1:N bookableresourcecharacteristic_DuplicateBaseRecord</summary>
			public const string BookableresourcecharacteristicDuplicateBaseRecord = "bookableresourcecharacteristic_DuplicateBaseRecord";

			/// <summary>1:N bookableresourcecharacteristic_DuplicateMatchingRecord</summary>
			public const string BookableresourcecharacteristicDuplicateMatchingRecord = "bookableresourcecharacteristic_DuplicateMatchingRecord";

			/// <summary>1:N bookableresourcecharacteristic_MailboxTrackingFolders</summary>
			public const string BookableresourcecharacteristicMailboxTrackingFolders = "bookableresourcecharacteristic_MailboxTrackingFolders";

			/// <summary>1:N bookableresourcecharacteristic_PrincipalObjectAttributeAccess</summary>
			public const string BookableresourcecharacteristicPrincipalObjectAttributeAccess = "bookableresourcecharacteristic_PrincipalObjectAttributeAccess";

			/// <summary>1:N bookableresourcecharacteristic_ProcessSession</summary>
			public const string BookableresourcecharacteristicProcessSession = "bookableresourcecharacteristic_ProcessSession";

			/// <summary>1:N BookableResourceCharacteristic_SyncErrors</summary>
			public const string BookableResourceCharacteristicSyncErrors = "BookableResourceCharacteristic_SyncErrors";

		}
		#endregion
	}
}

