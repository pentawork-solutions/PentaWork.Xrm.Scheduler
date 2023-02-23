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
	[EntityLogicalName("bookableresourcebookingheader")]
	public sealed class BookableResourceBookingHeader : Entity
	{	
		public static readonly int? EntityTypeCode = 1146;
		public new const string LogicalName = "bookableresourcebookingheader";
		public const string PrimaryIdAttribute = "bookableresourcebookingheaderid";
		public const string PrimaryNameAttribute = "name";
	
		public BookableResourceBookingHeader() : base("bookableresourcebookingheader") { }

		#region Attributes
		/// <summary>
        /// bookableresourcebookingheaderid
        /// </summary>
		[DisplayName("Bookable Resource Booking Header")]
		[AttributeLogicalName("bookableresourcebookingheaderid")]
		public override Guid Id
		{
			get => base.Id;
			set { base.Id = value; SetAttributeValue("bookableresourcebookingheaderid", value); }
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
        /// duration
        /// </summary>
		[DisplayName("Duration")]
		[AttributeLogicalName("duration")]
		public int? Duration
		{	
			get { return GetAttributeValue<int?>("duration"); }
			set
			{ 
				if(value == Duration) return;
				SetAttributeValue("duration", value);
			}
		}	
			
		/// <summary>
        /// endtime
        /// </summary>
		[DisplayName("End Time")]
		[AttributeLogicalName("endtime")]
		public DateTime? EndTime
		{	
			get { return GetAttributeValue<DateTime?>("endtime"); }
			set
			{ 
				if(value == EndTime) return;
				SetAttributeValue("endtime", value);
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
        /// starttime
        /// </summary>
		[DisplayName("Start Time")]
		[AttributeLogicalName("starttime")]
		public DateTime? StartTime
		{	
			get { return GetAttributeValue<DateTime?>("starttime"); }
			set
			{ 
				if(value == StartTime) return;
				SetAttributeValue("starttime", value);
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
        /// 1:N Get entities for 'bookableresourcebookingheader_ActivityPointers'
        /// </summary>
		[RelationshipSchemaName("bookableresourcebookingheader_ActivityPointers")]
		public IEnumerable<Activity> BookableresourcebookingheaderActivityPointers
		{
			get { return GetRelatedEntities<Activity>("bookableresourcebookingheader_ActivityPointers", null); }
			set { SetRelatedEntities("bookableresourcebookingheader_ActivityPointers", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'bookableresourcebookingheader_Annotations'
        /// </summary>
		[RelationshipSchemaName("bookableresourcebookingheader_Annotations")]
		public IEnumerable<Note> BookableresourcebookingheaderAnnotations
		{
			get { return GetRelatedEntities<Note>("bookableresourcebookingheader_Annotations", null); }
			set { SetRelatedEntities("bookableresourcebookingheader_Annotations", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'bookableresourcebookingheader_Appointments'
        /// </summary>
		[RelationshipSchemaName("bookableresourcebookingheader_Appointments")]
		public IEnumerable<Appointment> BookableresourcebookingheaderAppointments
		{
			get { return GetRelatedEntities<Appointment>("bookableresourcebookingheader_Appointments", null); }
			set { SetRelatedEntities("bookableresourcebookingheader_Appointments", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'bookableresourcebookingheader_AsyncOperations'
        /// </summary>
		[RelationshipSchemaName("bookableresourcebookingheader_AsyncOperations")]
		public IEnumerable<SystemJob> BookableresourcebookingheaderAsyncOperations
		{
			get { return GetRelatedEntities<SystemJob>("bookableresourcebookingheader_AsyncOperations", null); }
			set { SetRelatedEntities("bookableresourcebookingheader_AsyncOperations", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'bookableresourcebookingheader_bookableresourcebooking_Header'
        /// </summary>
		[RelationshipSchemaName("bookableresourcebookingheader_bookableresourcebooking_Header")]
		public IEnumerable<BookableResourceBooking> BookableresourcebookingheaderBookableresourcebookingHeader
		{
			get { return GetRelatedEntities<BookableResourceBooking>("bookableresourcebookingheader_bookableresourcebooking_Header", null); }
			set { SetRelatedEntities("bookableresourcebookingheader_bookableresourcebooking_Header", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'bookableresourcebookingheader_BulkDeleteFailures'
        /// </summary>
		[RelationshipSchemaName("bookableresourcebookingheader_BulkDeleteFailures")]
		public IEnumerable<BulkDeleteFailure> BookableresourcebookingheaderBulkDeleteFailures
		{
			get { return GetRelatedEntities<BulkDeleteFailure>("bookableresourcebookingheader_BulkDeleteFailures", null); }
			set { SetRelatedEntities("bookableresourcebookingheader_BulkDeleteFailures", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'bookableresourcebookingheader_BulkOperations'
        /// </summary>
		[RelationshipSchemaName("bookableresourcebookingheader_BulkOperations")]
		public IEnumerable<QuickCampaign> BookableresourcebookingheaderBulkOperations
		{
			get { return GetRelatedEntities<QuickCampaign>("bookableresourcebookingheader_BulkOperations", null); }
			set { SetRelatedEntities("bookableresourcebookingheader_BulkOperations", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'bookableresourcebookingheader_CampaignActivities'
        /// </summary>
		[RelationshipSchemaName("bookableresourcebookingheader_CampaignActivities")]
		public IEnumerable<CampaignActivity> BookableresourcebookingheaderCampaignActivities
		{
			get { return GetRelatedEntities<CampaignActivity>("bookableresourcebookingheader_CampaignActivities", null); }
			set { SetRelatedEntities("bookableresourcebookingheader_CampaignActivities", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'bookableresourcebookingheader_CampaignResponses'
        /// </summary>
		[RelationshipSchemaName("bookableresourcebookingheader_CampaignResponses")]
		public IEnumerable<CampaignResponse> BookableresourcebookingheaderCampaignResponses
		{
			get { return GetRelatedEntities<CampaignResponse>("bookableresourcebookingheader_CampaignResponses", null); }
			set { SetRelatedEntities("bookableresourcebookingheader_CampaignResponses", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'bookableresourcebookingheader_DuplicateBaseRecord'
        /// </summary>
		[RelationshipSchemaName("bookableresourcebookingheader_DuplicateBaseRecord")]
		public IEnumerable<DuplicateRecord> BookableresourcebookingheaderDuplicateBaseRecord
		{
			get { return GetRelatedEntities<DuplicateRecord>("bookableresourcebookingheader_DuplicateBaseRecord", null); }
			set { SetRelatedEntities("bookableresourcebookingheader_DuplicateBaseRecord", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'bookableresourcebookingheader_DuplicateMatchingRecord'
        /// </summary>
		[RelationshipSchemaName("bookableresourcebookingheader_DuplicateMatchingRecord")]
		public IEnumerable<DuplicateRecord> BookableresourcebookingheaderDuplicateMatchingRecord
		{
			get { return GetRelatedEntities<DuplicateRecord>("bookableresourcebookingheader_DuplicateMatchingRecord", null); }
			set { SetRelatedEntities("bookableresourcebookingheader_DuplicateMatchingRecord", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'bookableresourcebookingheader_Emails'
        /// </summary>
		[RelationshipSchemaName("bookableresourcebookingheader_Emails")]
		public IEnumerable<Email> BookableresourcebookingheaderEmails
		{
			get { return GetRelatedEntities<Email>("bookableresourcebookingheader_Emails", null); }
			set { SetRelatedEntities("bookableresourcebookingheader_Emails", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'bookableresourcebookingheader_Faxes'
        /// </summary>
		[RelationshipSchemaName("bookableresourcebookingheader_Faxes")]
		public IEnumerable<Fax> BookableresourcebookingheaderFaxes
		{
			get { return GetRelatedEntities<Fax>("bookableresourcebookingheader_Faxes", null); }
			set { SetRelatedEntities("bookableresourcebookingheader_Faxes", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'bookableresourcebookingheader_IncidentResolutions'
        /// </summary>
		[RelationshipSchemaName("bookableresourcebookingheader_IncidentResolutions")]
		public IEnumerable<CaseResolution> BookableresourcebookingheaderIncidentResolutions
		{
			get { return GetRelatedEntities<CaseResolution>("bookableresourcebookingheader_IncidentResolutions", null); }
			set { SetRelatedEntities("bookableresourcebookingheader_IncidentResolutions", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'bookableresourcebookingheader_Letters'
        /// </summary>
		[RelationshipSchemaName("bookableresourcebookingheader_Letters")]
		public IEnumerable<Letter> BookableresourcebookingheaderLetters
		{
			get { return GetRelatedEntities<Letter>("bookableresourcebookingheader_Letters", null); }
			set { SetRelatedEntities("bookableresourcebookingheader_Letters", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'bookableresourcebookingheader_MailboxTrackingFolders'
        /// </summary>
		[RelationshipSchemaName("bookableresourcebookingheader_MailboxTrackingFolders")]
		public IEnumerable<MailboxAutoTrackingFolder> BookableresourcebookingheaderMailboxTrackingFolders
		{
			get { return GetRelatedEntities<MailboxAutoTrackingFolder>("bookableresourcebookingheader_MailboxTrackingFolders", null); }
			set { SetRelatedEntities("bookableresourcebookingheader_MailboxTrackingFolders", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'bookableresourcebookingheader_OpportunityCloses'
        /// </summary>
		[RelationshipSchemaName("bookableresourcebookingheader_OpportunityCloses")]
		public IEnumerable<OpportunityClose> BookableresourcebookingheaderOpportunityCloses
		{
			get { return GetRelatedEntities<OpportunityClose>("bookableresourcebookingheader_OpportunityCloses", null); }
			set { SetRelatedEntities("bookableresourcebookingheader_OpportunityCloses", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'bookableresourcebookingheader_OrderCloses'
        /// </summary>
		[RelationshipSchemaName("bookableresourcebookingheader_OrderCloses")]
		public IEnumerable<OrderClose> BookableresourcebookingheaderOrderCloses
		{
			get { return GetRelatedEntities<OrderClose>("bookableresourcebookingheader_OrderCloses", null); }
			set { SetRelatedEntities("bookableresourcebookingheader_OrderCloses", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'bookableresourcebookingheader_PhoneCalls'
        /// </summary>
		[RelationshipSchemaName("bookableresourcebookingheader_PhoneCalls")]
		public IEnumerable<PhoneCall> BookableresourcebookingheaderPhoneCalls
		{
			get { return GetRelatedEntities<PhoneCall>("bookableresourcebookingheader_PhoneCalls", null); }
			set { SetRelatedEntities("bookableresourcebookingheader_PhoneCalls", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'bookableresourcebookingheader_PrincipalObjectAttributeAccess'
        /// </summary>
		[RelationshipSchemaName("bookableresourcebookingheader_PrincipalObjectAttributeAccess")]
		public IEnumerable<FieldSharing> BookableresourcebookingheaderPrincipalObjectAttributeAccess
		{
			get { return GetRelatedEntities<FieldSharing>("bookableresourcebookingheader_PrincipalObjectAttributeAccess", null); }
			set { SetRelatedEntities("bookableresourcebookingheader_PrincipalObjectAttributeAccess", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'bookableresourcebookingheader_ProcessSession'
        /// </summary>
		[RelationshipSchemaName("bookableresourcebookingheader_ProcessSession")]
		public IEnumerable<ProcessSession> BookableresourcebookingheaderProcessSession
		{
			get { return GetRelatedEntities<ProcessSession>("bookableresourcebookingheader_ProcessSession", null); }
			set { SetRelatedEntities("bookableresourcebookingheader_ProcessSession", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'bookableresourcebookingheader_QuoteCloses'
        /// </summary>
		[RelationshipSchemaName("bookableresourcebookingheader_QuoteCloses")]
		public IEnumerable<QuoteClose> BookableresourcebookingheaderQuoteCloses
		{
			get { return GetRelatedEntities<QuoteClose>("bookableresourcebookingheader_QuoteCloses", null); }
			set { SetRelatedEntities("bookableresourcebookingheader_QuoteCloses", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'bookableresourcebookingheader_RecurringAppointmentMasters'
        /// </summary>
		[RelationshipSchemaName("bookableresourcebookingheader_RecurringAppointmentMasters")]
		public IEnumerable<RecurringAppointment> BookableresourcebookingheaderRecurringAppointmentMasters
		{
			get { return GetRelatedEntities<RecurringAppointment>("bookableresourcebookingheader_RecurringAppointmentMasters", null); }
			set { SetRelatedEntities("bookableresourcebookingheader_RecurringAppointmentMasters", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'bookableresourcebookingheader_ServiceAppointments'
        /// </summary>
		[RelationshipSchemaName("bookableresourcebookingheader_ServiceAppointments")]
		public IEnumerable<ServiceActivity> BookableresourcebookingheaderServiceAppointments
		{
			get { return GetRelatedEntities<ServiceActivity>("bookableresourcebookingheader_ServiceAppointments", null); }
			set { SetRelatedEntities("bookableresourcebookingheader_ServiceAppointments", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'bookableresourcebookingheader_SocialActivities'
        /// </summary>
		[RelationshipSchemaName("bookableresourcebookingheader_SocialActivities")]
		public IEnumerable<SocialActivity> BookableresourcebookingheaderSocialActivities
		{
			get { return GetRelatedEntities<SocialActivity>("bookableresourcebookingheader_SocialActivities", null); }
			set { SetRelatedEntities("bookableresourcebookingheader_SocialActivities", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'BookableResourceBookingHeader_SyncErrors'
        /// </summary>
		[RelationshipSchemaName("BookableResourceBookingHeader_SyncErrors")]
		public IEnumerable<SyncError> BookableResourceBookingHeaderSyncErrors
		{
			get { return GetRelatedEntities<SyncError>("BookableResourceBookingHeader_SyncErrors", null); }
			set { SetRelatedEntities("BookableResourceBookingHeader_SyncErrors", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'bookableresourcebookingheader_Tasks'
        /// </summary>
		[RelationshipSchemaName("bookableresourcebookingheader_Tasks")]
		public IEnumerable<Task> BookableresourcebookingheaderTasks
		{
			get { return GetRelatedEntities<Task>("bookableresourcebookingheader_Tasks", null); }
			set { SetRelatedEntities("bookableresourcebookingheader_Tasks", null, value); }
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
			/// <summary>bookableresourcebookingheaderid</summary>
			public const string BookableResourceBookingHeaderId = "bookableresourcebookingheaderid";

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

			/// <summary>duration</summary>
			public const string Duration = "duration";

			/// <summary>endtime</summary>
			public const string EndTime = "endtime";

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

			/// <summary>stageid</summary>
			public const string DeprecatedStageId = "stageid";

			/// <summary>starttime</summary>
			public const string StartTime = "starttime";

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
			/// <summary>1:N bookableresourcebookingheader_ActivityPointers</summary>
			public const string BookableresourcebookingheaderActivityPointers = "bookableresourcebookingheader_ActivityPointers";

			/// <summary>1:N bookableresourcebookingheader_Annotations</summary>
			public const string BookableresourcebookingheaderAnnotations = "bookableresourcebookingheader_Annotations";

			/// <summary>1:N bookableresourcebookingheader_Appointments</summary>
			public const string BookableresourcebookingheaderAppointments = "bookableresourcebookingheader_Appointments";

			/// <summary>1:N bookableresourcebookingheader_AsyncOperations</summary>
			public const string BookableresourcebookingheaderAsyncOperations = "bookableresourcebookingheader_AsyncOperations";

			/// <summary>1:N bookableresourcebookingheader_bookableresourcebooking_Header</summary>
			public const string BookableresourcebookingheaderBookableresourcebookingHeader = "bookableresourcebookingheader_bookableresourcebooking_Header";

			/// <summary>1:N bookableresourcebookingheader_BulkDeleteFailures</summary>
			public const string BookableresourcebookingheaderBulkDeleteFailures = "bookableresourcebookingheader_BulkDeleteFailures";

			/// <summary>1:N bookableresourcebookingheader_BulkOperations</summary>
			public const string BookableresourcebookingheaderBulkOperations = "bookableresourcebookingheader_BulkOperations";

			/// <summary>1:N bookableresourcebookingheader_CampaignActivities</summary>
			public const string BookableresourcebookingheaderCampaignActivities = "bookableresourcebookingheader_CampaignActivities";

			/// <summary>1:N bookableresourcebookingheader_CampaignResponses</summary>
			public const string BookableresourcebookingheaderCampaignResponses = "bookableresourcebookingheader_CampaignResponses";

			/// <summary>1:N bookableresourcebookingheader_DuplicateBaseRecord</summary>
			public const string BookableresourcebookingheaderDuplicateBaseRecord = "bookableresourcebookingheader_DuplicateBaseRecord";

			/// <summary>1:N bookableresourcebookingheader_DuplicateMatchingRecord</summary>
			public const string BookableresourcebookingheaderDuplicateMatchingRecord = "bookableresourcebookingheader_DuplicateMatchingRecord";

			/// <summary>1:N bookableresourcebookingheader_Emails</summary>
			public const string BookableresourcebookingheaderEmails = "bookableresourcebookingheader_Emails";

			/// <summary>1:N bookableresourcebookingheader_Faxes</summary>
			public const string BookableresourcebookingheaderFaxes = "bookableresourcebookingheader_Faxes";

			/// <summary>1:N bookableresourcebookingheader_IncidentResolutions</summary>
			public const string BookableresourcebookingheaderIncidentResolutions = "bookableresourcebookingheader_IncidentResolutions";

			/// <summary>1:N bookableresourcebookingheader_Letters</summary>
			public const string BookableresourcebookingheaderLetters = "bookableresourcebookingheader_Letters";

			/// <summary>1:N bookableresourcebookingheader_MailboxTrackingFolders</summary>
			public const string BookableresourcebookingheaderMailboxTrackingFolders = "bookableresourcebookingheader_MailboxTrackingFolders";

			/// <summary>1:N bookableresourcebookingheader_OpportunityCloses</summary>
			public const string BookableresourcebookingheaderOpportunityCloses = "bookableresourcebookingheader_OpportunityCloses";

			/// <summary>1:N bookableresourcebookingheader_OrderCloses</summary>
			public const string BookableresourcebookingheaderOrderCloses = "bookableresourcebookingheader_OrderCloses";

			/// <summary>1:N bookableresourcebookingheader_PhoneCalls</summary>
			public const string BookableresourcebookingheaderPhoneCalls = "bookableresourcebookingheader_PhoneCalls";

			/// <summary>1:N bookableresourcebookingheader_PrincipalObjectAttributeAccess</summary>
			public const string BookableresourcebookingheaderPrincipalObjectAttributeAccess = "bookableresourcebookingheader_PrincipalObjectAttributeAccess";

			/// <summary>1:N bookableresourcebookingheader_ProcessSession</summary>
			public const string BookableresourcebookingheaderProcessSession = "bookableresourcebookingheader_ProcessSession";

			/// <summary>1:N bookableresourcebookingheader_QuoteCloses</summary>
			public const string BookableresourcebookingheaderQuoteCloses = "bookableresourcebookingheader_QuoteCloses";

			/// <summary>1:N bookableresourcebookingheader_RecurringAppointmentMasters</summary>
			public const string BookableresourcebookingheaderRecurringAppointmentMasters = "bookableresourcebookingheader_RecurringAppointmentMasters";

			/// <summary>1:N bookableresourcebookingheader_ServiceAppointments</summary>
			public const string BookableresourcebookingheaderServiceAppointments = "bookableresourcebookingheader_ServiceAppointments";

			/// <summary>1:N bookableresourcebookingheader_SocialActivities</summary>
			public const string BookableresourcebookingheaderSocialActivities = "bookableresourcebookingheader_SocialActivities";

			/// <summary>1:N BookableResourceBookingHeader_SyncErrors</summary>
			public const string BookableResourceBookingHeaderSyncErrors = "BookableResourceBookingHeader_SyncErrors";

			/// <summary>1:N bookableresourcebookingheader_Tasks</summary>
			public const string BookableresourcebookingheaderTasks = "bookableresourcebookingheader_Tasks";

		}
		#endregion
	}
}

