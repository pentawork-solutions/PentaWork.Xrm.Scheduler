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
	[EntityLogicalName("bookableresourcebooking")]
	public sealed class BookableResourceBooking : Entity
	{	
		public static readonly int? EntityTypeCode = 1145;
		public new const string LogicalName = "bookableresourcebooking";
		public const string PrimaryIdAttribute = "bookableresourcebookingid";
		public const string PrimaryNameAttribute = "name";
	
		public BookableResourceBooking() : base("bookableresourcebooking") { }

		#region Attributes
		/// <summary>
        /// bookableresourcebookingid
        /// </summary>
		[DisplayName("Bookable Resource Booking")]
		[AttributeLogicalName("bookableresourcebookingid")]
		public override Guid Id
		{
			get => base.Id;
			set { base.Id = value; SetAttributeValue("bookableresourcebookingid", value); }
		}

							/// <summary>
        /// bookingstatus
        /// </summary>
		[DisplayName("Booking Status")]
		[AttributeLogicalName("bookingstatus")]
		public EntityReference BookingStatus
		{	
			get { return GetAttributeValue<EntityReference>("bookingstatus"); }
			set
			{ 
				if(value == BookingStatus) return;
				SetAttributeValue("bookingstatus", value);
			}
		}	
			
		/// <summary>
        /// bookingstatusname
        /// </summary>
		[DisplayName("bookingstatusname")]
		[AttributeLogicalName("bookingstatusname")]
		public string Bookingstatusname
		{	
			get { return GetAttributeValue<string>("bookingstatusname"); }
			set
			{ 
				if(value == Bookingstatusname) return;
				SetAttributeValue("bookingstatusname", value);
			}
		}	
			
		/// <summary>
        /// bookingtype
        /// </summary>
		[DisplayName("Booking Type")]
		[AttributeLogicalName("bookingtype")]
		public eBookingType? BookingType
		{	
			get 
			{ 
				var optionSetValue = GetAttributeValue<OptionSetValue>("bookingtype");
				if (optionSetValue != null) return (eBookingType)optionSetValue.Value;
				else return null;
			}
			set 
			{ 
				if(value == BookingType) return;

				OptionSetValue optionSetValue = null;
				if(value != null) optionSetValue = new OptionSetValue((int)value);
				SetAttributeValue("bookingtype", optionSetValue); 
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
        /// header
        /// </summary>
		[DisplayName("Header")]
		[AttributeLogicalName("header")]
		public EntityReference Header
		{	
			get { return GetAttributeValue<EntityReference>("header"); }
			set
			{ 
				if(value == Header) return;
				SetAttributeValue("header", value);
			}
		}	
			
		/// <summary>
        /// headername
        /// </summary>
		[DisplayName("headername")]
		[AttributeLogicalName("headername")]
		public string Headername
		{	
			get { return GetAttributeValue<string>("headername"); }
			set
			{ 
				if(value == Headername) return;
				SetAttributeValue("headername", value);
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
        /// 1:N Get entities for 'bookableresourcebooking_ActivityPointers'
        /// </summary>
		[RelationshipSchemaName("bookableresourcebooking_ActivityPointers")]
		public IEnumerable<Activity> BookableresourcebookingActivityPointers
		{
			get { return GetRelatedEntities<Activity>("bookableresourcebooking_ActivityPointers", null); }
			set { SetRelatedEntities("bookableresourcebooking_ActivityPointers", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'bookableresourcebooking_Annotations'
        /// </summary>
		[RelationshipSchemaName("bookableresourcebooking_Annotations")]
		public IEnumerable<Note> BookableresourcebookingAnnotations
		{
			get { return GetRelatedEntities<Note>("bookableresourcebooking_Annotations", null); }
			set { SetRelatedEntities("bookableresourcebooking_Annotations", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'bookableresourcebooking_Appointments'
        /// </summary>
		[RelationshipSchemaName("bookableresourcebooking_Appointments")]
		public IEnumerable<Appointment> BookableresourcebookingAppointments
		{
			get { return GetRelatedEntities<Appointment>("bookableresourcebooking_Appointments", null); }
			set { SetRelatedEntities("bookableresourcebooking_Appointments", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'bookableresourcebooking_AsyncOperations'
        /// </summary>
		[RelationshipSchemaName("bookableresourcebooking_AsyncOperations")]
		public IEnumerable<SystemJob> BookableresourcebookingAsyncOperations
		{
			get { return GetRelatedEntities<SystemJob>("bookableresourcebooking_AsyncOperations", null); }
			set { SetRelatedEntities("bookableresourcebooking_AsyncOperations", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'bookableresourcebooking_BulkDeleteFailures'
        /// </summary>
		[RelationshipSchemaName("bookableresourcebooking_BulkDeleteFailures")]
		public IEnumerable<BulkDeleteFailure> BookableresourcebookingBulkDeleteFailures
		{
			get { return GetRelatedEntities<BulkDeleteFailure>("bookableresourcebooking_BulkDeleteFailures", null); }
			set { SetRelatedEntities("bookableresourcebooking_BulkDeleteFailures", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'bookableresourcebooking_BulkOperations'
        /// </summary>
		[RelationshipSchemaName("bookableresourcebooking_BulkOperations")]
		public IEnumerable<QuickCampaign> BookableresourcebookingBulkOperations
		{
			get { return GetRelatedEntities<QuickCampaign>("bookableresourcebooking_BulkOperations", null); }
			set { SetRelatedEntities("bookableresourcebooking_BulkOperations", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'bookableresourcebooking_CampaignActivities'
        /// </summary>
		[RelationshipSchemaName("bookableresourcebooking_CampaignActivities")]
		public IEnumerable<CampaignActivity> BookableresourcebookingCampaignActivities
		{
			get { return GetRelatedEntities<CampaignActivity>("bookableresourcebooking_CampaignActivities", null); }
			set { SetRelatedEntities("bookableresourcebooking_CampaignActivities", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'bookableresourcebooking_CampaignResponses'
        /// </summary>
		[RelationshipSchemaName("bookableresourcebooking_CampaignResponses")]
		public IEnumerable<CampaignResponse> BookableresourcebookingCampaignResponses
		{
			get { return GetRelatedEntities<CampaignResponse>("bookableresourcebooking_CampaignResponses", null); }
			set { SetRelatedEntities("bookableresourcebooking_CampaignResponses", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'bookableresourcebooking_DuplicateBaseRecord'
        /// </summary>
		[RelationshipSchemaName("bookableresourcebooking_DuplicateBaseRecord")]
		public IEnumerable<DuplicateRecord> BookableresourcebookingDuplicateBaseRecord
		{
			get { return GetRelatedEntities<DuplicateRecord>("bookableresourcebooking_DuplicateBaseRecord", null); }
			set { SetRelatedEntities("bookableresourcebooking_DuplicateBaseRecord", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'bookableresourcebooking_DuplicateMatchingRecord'
        /// </summary>
		[RelationshipSchemaName("bookableresourcebooking_DuplicateMatchingRecord")]
		public IEnumerable<DuplicateRecord> BookableresourcebookingDuplicateMatchingRecord
		{
			get { return GetRelatedEntities<DuplicateRecord>("bookableresourcebooking_DuplicateMatchingRecord", null); }
			set { SetRelatedEntities("bookableresourcebooking_DuplicateMatchingRecord", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'bookableresourcebooking_Emails'
        /// </summary>
		[RelationshipSchemaName("bookableresourcebooking_Emails")]
		public IEnumerable<Email> BookableresourcebookingEmails
		{
			get { return GetRelatedEntities<Email>("bookableresourcebooking_Emails", null); }
			set { SetRelatedEntities("bookableresourcebooking_Emails", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'bookableresourcebooking_Faxes'
        /// </summary>
		[RelationshipSchemaName("bookableresourcebooking_Faxes")]
		public IEnumerable<Fax> BookableresourcebookingFaxes
		{
			get { return GetRelatedEntities<Fax>("bookableresourcebooking_Faxes", null); }
			set { SetRelatedEntities("bookableresourcebooking_Faxes", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'bookableresourcebooking_IncidentResolutions'
        /// </summary>
		[RelationshipSchemaName("bookableresourcebooking_IncidentResolutions")]
		public IEnumerable<CaseResolution> BookableresourcebookingIncidentResolutions
		{
			get { return GetRelatedEntities<CaseResolution>("bookableresourcebooking_IncidentResolutions", null); }
			set { SetRelatedEntities("bookableresourcebooking_IncidentResolutions", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'bookableresourcebooking_Letters'
        /// </summary>
		[RelationshipSchemaName("bookableresourcebooking_Letters")]
		public IEnumerable<Letter> BookableresourcebookingLetters
		{
			get { return GetRelatedEntities<Letter>("bookableresourcebooking_Letters", null); }
			set { SetRelatedEntities("bookableresourcebooking_Letters", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'bookableresourcebooking_MailboxTrackingFolders'
        /// </summary>
		[RelationshipSchemaName("bookableresourcebooking_MailboxTrackingFolders")]
		public IEnumerable<MailboxAutoTrackingFolder> BookableresourcebookingMailboxTrackingFolders
		{
			get { return GetRelatedEntities<MailboxAutoTrackingFolder>("bookableresourcebooking_MailboxTrackingFolders", null); }
			set { SetRelatedEntities("bookableresourcebooking_MailboxTrackingFolders", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'bookableresourcebooking_OpportunityCloses'
        /// </summary>
		[RelationshipSchemaName("bookableresourcebooking_OpportunityCloses")]
		public IEnumerable<OpportunityClose> BookableresourcebookingOpportunityCloses
		{
			get { return GetRelatedEntities<OpportunityClose>("bookableresourcebooking_OpportunityCloses", null); }
			set { SetRelatedEntities("bookableresourcebooking_OpportunityCloses", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'bookableresourcebooking_OrderCloses'
        /// </summary>
		[RelationshipSchemaName("bookableresourcebooking_OrderCloses")]
		public IEnumerable<OrderClose> BookableresourcebookingOrderCloses
		{
			get { return GetRelatedEntities<OrderClose>("bookableresourcebooking_OrderCloses", null); }
			set { SetRelatedEntities("bookableresourcebooking_OrderCloses", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'bookableresourcebooking_PhoneCalls'
        /// </summary>
		[RelationshipSchemaName("bookableresourcebooking_PhoneCalls")]
		public IEnumerable<PhoneCall> BookableresourcebookingPhoneCalls
		{
			get { return GetRelatedEntities<PhoneCall>("bookableresourcebooking_PhoneCalls", null); }
			set { SetRelatedEntities("bookableresourcebooking_PhoneCalls", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'bookableresourcebooking_PrincipalObjectAttributeAccess'
        /// </summary>
		[RelationshipSchemaName("bookableresourcebooking_PrincipalObjectAttributeAccess")]
		public IEnumerable<FieldSharing> BookableresourcebookingPrincipalObjectAttributeAccess
		{
			get { return GetRelatedEntities<FieldSharing>("bookableresourcebooking_PrincipalObjectAttributeAccess", null); }
			set { SetRelatedEntities("bookableresourcebooking_PrincipalObjectAttributeAccess", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'bookableresourcebooking_ProcessSession'
        /// </summary>
		[RelationshipSchemaName("bookableresourcebooking_ProcessSession")]
		public IEnumerable<ProcessSession> BookableresourcebookingProcessSession
		{
			get { return GetRelatedEntities<ProcessSession>("bookableresourcebooking_ProcessSession", null); }
			set { SetRelatedEntities("bookableresourcebooking_ProcessSession", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'bookableresourcebooking_QuoteCloses'
        /// </summary>
		[RelationshipSchemaName("bookableresourcebooking_QuoteCloses")]
		public IEnumerable<QuoteClose> BookableresourcebookingQuoteCloses
		{
			get { return GetRelatedEntities<QuoteClose>("bookableresourcebooking_QuoteCloses", null); }
			set { SetRelatedEntities("bookableresourcebooking_QuoteCloses", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'bookableresourcebooking_RecurringAppointmentMasters'
        /// </summary>
		[RelationshipSchemaName("bookableresourcebooking_RecurringAppointmentMasters")]
		public IEnumerable<RecurringAppointment> BookableresourcebookingRecurringAppointmentMasters
		{
			get { return GetRelatedEntities<RecurringAppointment>("bookableresourcebooking_RecurringAppointmentMasters", null); }
			set { SetRelatedEntities("bookableresourcebooking_RecurringAppointmentMasters", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'bookableresourcebooking_ServiceAppointments'
        /// </summary>
		[RelationshipSchemaName("bookableresourcebooking_ServiceAppointments")]
		public IEnumerable<ServiceActivity> BookableresourcebookingServiceAppointments
		{
			get { return GetRelatedEntities<ServiceActivity>("bookableresourcebooking_ServiceAppointments", null); }
			set { SetRelatedEntities("bookableresourcebooking_ServiceAppointments", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'bookableresourcebooking_SocialActivities'
        /// </summary>
		[RelationshipSchemaName("bookableresourcebooking_SocialActivities")]
		public IEnumerable<SocialActivity> BookableresourcebookingSocialActivities
		{
			get { return GetRelatedEntities<SocialActivity>("bookableresourcebooking_SocialActivities", null); }
			set { SetRelatedEntities("bookableresourcebooking_SocialActivities", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'BookableResourceBooking_SyncErrors'
        /// </summary>
		[RelationshipSchemaName("BookableResourceBooking_SyncErrors")]
		public IEnumerable<SyncError> BookableResourceBookingSyncErrors
		{
			get { return GetRelatedEntities<SyncError>("BookableResourceBooking_SyncErrors", null); }
			set { SetRelatedEntities("BookableResourceBooking_SyncErrors", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'bookableresourcebooking_Tasks'
        /// </summary>
		[RelationshipSchemaName("bookableresourcebooking_Tasks")]
		public IEnumerable<Task> BookableresourcebookingTasks
		{
			get { return GetRelatedEntities<Task>("bookableresourcebooking_Tasks", null); }
			set { SetRelatedEntities("bookableresourcebooking_Tasks", null, value); }
		}
		#endregion

		#region Actions
		#endregion

		#region OptionSetEnums
		public enum eBookingType
		{	
		
			[Label("Liquid")]
			[Description(@"")]
			Liquid = 2, 
		
			[Label("Solid")]
			[Description(@"")]
			Solid = 1, 
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
			Active_Active = 1, 
		
			[Label("Inactive")]
			[Description(@"")]
			Inactive_Inactive = 2, 
		}
		
		#endregion	

		#region Properties
		public static class Properties 
		{
			/// <summary>bookableresourcebookingid</summary>
			public const string BookableResourceBookingId = "bookableresourcebookingid";

			/// <summary>bookingstatus</summary>
			public const string BookingStatus = "bookingstatus";

			/// <summary>bookingstatusname</summary>
			public const string Bookingstatusname = "bookingstatusname";

			/// <summary>bookingtype</summary>
			public const string BookingType = "bookingtype";

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

			/// <summary>header</summary>
			public const string Header = "header";

			/// <summary>headername</summary>
			public const string Headername = "headername";

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

			/// <summary>resource</summary>
			public const string Resource = "resource";

			/// <summary>resourcename</summary>
			public const string Resourcename = "resourcename";

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
			/// <summary>1:N bookableresourcebooking_ActivityPointers</summary>
			public const string BookableresourcebookingActivityPointers = "bookableresourcebooking_ActivityPointers";

			/// <summary>1:N bookableresourcebooking_Annotations</summary>
			public const string BookableresourcebookingAnnotations = "bookableresourcebooking_Annotations";

			/// <summary>1:N bookableresourcebooking_Appointments</summary>
			public const string BookableresourcebookingAppointments = "bookableresourcebooking_Appointments";

			/// <summary>1:N bookableresourcebooking_AsyncOperations</summary>
			public const string BookableresourcebookingAsyncOperations = "bookableresourcebooking_AsyncOperations";

			/// <summary>1:N bookableresourcebooking_BulkDeleteFailures</summary>
			public const string BookableresourcebookingBulkDeleteFailures = "bookableresourcebooking_BulkDeleteFailures";

			/// <summary>1:N bookableresourcebooking_BulkOperations</summary>
			public const string BookableresourcebookingBulkOperations = "bookableresourcebooking_BulkOperations";

			/// <summary>1:N bookableresourcebooking_CampaignActivities</summary>
			public const string BookableresourcebookingCampaignActivities = "bookableresourcebooking_CampaignActivities";

			/// <summary>1:N bookableresourcebooking_CampaignResponses</summary>
			public const string BookableresourcebookingCampaignResponses = "bookableresourcebooking_CampaignResponses";

			/// <summary>1:N bookableresourcebooking_DuplicateBaseRecord</summary>
			public const string BookableresourcebookingDuplicateBaseRecord = "bookableresourcebooking_DuplicateBaseRecord";

			/// <summary>1:N bookableresourcebooking_DuplicateMatchingRecord</summary>
			public const string BookableresourcebookingDuplicateMatchingRecord = "bookableresourcebooking_DuplicateMatchingRecord";

			/// <summary>1:N bookableresourcebooking_Emails</summary>
			public const string BookableresourcebookingEmails = "bookableresourcebooking_Emails";

			/// <summary>1:N bookableresourcebooking_Faxes</summary>
			public const string BookableresourcebookingFaxes = "bookableresourcebooking_Faxes";

			/// <summary>1:N bookableresourcebooking_IncidentResolutions</summary>
			public const string BookableresourcebookingIncidentResolutions = "bookableresourcebooking_IncidentResolutions";

			/// <summary>1:N bookableresourcebooking_Letters</summary>
			public const string BookableresourcebookingLetters = "bookableresourcebooking_Letters";

			/// <summary>1:N bookableresourcebooking_MailboxTrackingFolders</summary>
			public const string BookableresourcebookingMailboxTrackingFolders = "bookableresourcebooking_MailboxTrackingFolders";

			/// <summary>1:N bookableresourcebooking_OpportunityCloses</summary>
			public const string BookableresourcebookingOpportunityCloses = "bookableresourcebooking_OpportunityCloses";

			/// <summary>1:N bookableresourcebooking_OrderCloses</summary>
			public const string BookableresourcebookingOrderCloses = "bookableresourcebooking_OrderCloses";

			/// <summary>1:N bookableresourcebooking_PhoneCalls</summary>
			public const string BookableresourcebookingPhoneCalls = "bookableresourcebooking_PhoneCalls";

			/// <summary>1:N bookableresourcebooking_PrincipalObjectAttributeAccess</summary>
			public const string BookableresourcebookingPrincipalObjectAttributeAccess = "bookableresourcebooking_PrincipalObjectAttributeAccess";

			/// <summary>1:N bookableresourcebooking_ProcessSession</summary>
			public const string BookableresourcebookingProcessSession = "bookableresourcebooking_ProcessSession";

			/// <summary>1:N bookableresourcebooking_QuoteCloses</summary>
			public const string BookableresourcebookingQuoteCloses = "bookableresourcebooking_QuoteCloses";

			/// <summary>1:N bookableresourcebooking_RecurringAppointmentMasters</summary>
			public const string BookableresourcebookingRecurringAppointmentMasters = "bookableresourcebooking_RecurringAppointmentMasters";

			/// <summary>1:N bookableresourcebooking_ServiceAppointments</summary>
			public const string BookableresourcebookingServiceAppointments = "bookableresourcebooking_ServiceAppointments";

			/// <summary>1:N bookableresourcebooking_SocialActivities</summary>
			public const string BookableresourcebookingSocialActivities = "bookableresourcebooking_SocialActivities";

			/// <summary>1:N BookableResourceBooking_SyncErrors</summary>
			public const string BookableResourceBookingSyncErrors = "BookableResourceBooking_SyncErrors";

			/// <summary>1:N bookableresourcebooking_Tasks</summary>
			public const string BookableresourcebookingTasks = "bookableresourcebooking_Tasks";

		}
		#endregion
	}
}

