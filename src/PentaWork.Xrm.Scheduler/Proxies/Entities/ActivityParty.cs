using System;
using System.Linq;
using System.Diagnostics;
using System.ComponentModel;
using Microsoft.Xrm.Sdk; 
using Microsoft.Xrm.Sdk.Client;
using System.Collections.Generic;

namespace PentaWork.Xrm.Scheduler.Proxies.Entities
{
	[DebuggerDisplay("{Partyidname}")] 	
	[EntityLogicalName("activityparty")]
	public sealed class ActivityParty : Entity
	{	
		public static readonly int? EntityTypeCode = 135;
		public new const string LogicalName = "activityparty";
		public const string PrimaryIdAttribute = "activitypartyid";
		public const string PrimaryNameAttribute = "partyidname";
	
		public ActivityParty() : base("activityparty") { }

		#region Attributes
		/// <summary>
        /// activityid
        /// </summary>
		[DisplayName("Activity")]
		[AttributeLogicalName("activityid")]
		public EntityReference Activity
		{	
			get { return GetAttributeValue<EntityReference>("activityid"); }
			set
			{ 
				if(value == Activity) return;
				SetAttributeValue("activityid", value);
			}
		}	
			
		/// <summary>
        /// activitypartyid
        /// </summary>
		[DisplayName("Activity Party")]
		[AttributeLogicalName("activitypartyid")]
		public override Guid Id
		{
			get => base.Id;
			set { base.Id = value; SetAttributeValue("activitypartyid", value); }
		}

							/// <summary>
        /// addressused
        /// </summary>
		[DisplayName("Address")]
		[AttributeLogicalName("addressused")]
		public string Address
		{	
			get { return GetAttributeValue<string>("addressused"); }
			set
			{ 
				if(value == Address) return;
				SetAttributeValue("addressused", value);
			}
		}	
			
		/// <summary>
        /// addressusedemailcolumnnumber
        /// </summary>
		[DisplayName("Email column number of party")]
		[AttributeLogicalName("addressusedemailcolumnnumber")]
		public int? EmailColumnNumberOfParty
		{	
			get { return GetAttributeValue<int?>("addressusedemailcolumnnumber"); }
			set
			{ 
				if(value == EmailColumnNumberOfParty) return;
				SetAttributeValue("addressusedemailcolumnnumber", value);
			}
		}	
			
		/// <summary>
        /// donotemail
        /// </summary>
		[DisplayName("Do not allow Emails")]
		[AttributeLogicalName("donotemail")]
		public bool? DoNotAllowEmails
		{	
			get { return GetAttributeValue<bool?>("donotemail"); }
			set
			{ 
				if(value == DoNotAllowEmails) return;
				SetAttributeValue("donotemail", value);
			}
		}	
			
		/// <summary>
        /// donotfax
        /// </summary>
		[DisplayName("Do not allow Faxes")]
		[AttributeLogicalName("donotfax")]
		public bool? DoNotAllowFaxes
		{	
			get { return GetAttributeValue<bool?>("donotfax"); }
			set
			{ 
				if(value == DoNotAllowFaxes) return;
				SetAttributeValue("donotfax", value);
			}
		}	
			
		/// <summary>
        /// donotphone
        /// </summary>
		[DisplayName("Do not allow Phone Calls")]
		[AttributeLogicalName("donotphone")]
		public bool? DoNotAllowPhoneCalls
		{	
			get { return GetAttributeValue<bool?>("donotphone"); }
			set
			{ 
				if(value == DoNotAllowPhoneCalls) return;
				SetAttributeValue("donotphone", value);
			}
		}	
			
		/// <summary>
        /// donotpostalmail
        /// </summary>
		[DisplayName("Do not allow Postal Mails")]
		[AttributeLogicalName("donotpostalmail")]
		public bool? DoNotAllowPostalMails
		{	
			get { return GetAttributeValue<bool?>("donotpostalmail"); }
			set
			{ 
				if(value == DoNotAllowPostalMails) return;
				SetAttributeValue("donotpostalmail", value);
			}
		}	
			
		/// <summary>
        /// effort
        /// </summary>
		[DisplayName("Effort")]
		[AttributeLogicalName("effort")]
		public double? Effort
		{	
			get { return GetAttributeValue<double?>("effort"); }
			set
			{ 
				if(value == Effort) return;
				SetAttributeValue("effort", value);
			}
		}	
			
		/// <summary>
        /// exchangeentryid
        /// </summary>
		[DisplayName("Exchange Entry")]
		[AttributeLogicalName("exchangeentryid")]
		public string ExchangeEntry
		{	
			get { return GetAttributeValue<string>("exchangeentryid"); }
			set
			{ 
				if(value == ExchangeEntry) return;
				SetAttributeValue("exchangeentryid", value);
			}
		}	
			
		/// <summary>
        /// instancetypecode
        /// </summary>
		[DisplayName("Appointment Type")]
		[AttributeLogicalName("instancetypecode")]
		public eAppointmentType? AppointmentType
		{	
			get 
			{ 
				var optionSetValue = GetAttributeValue<OptionSetValue>("instancetypecode");
				if (optionSetValue != null) return (eAppointmentType)optionSetValue.Value;
				else return null;
			}
			set 
			{ 
				if(value == AppointmentType) return;

				OptionSetValue optionSetValue = null;
				if(value != null) optionSetValue = new OptionSetValue((int)value);
				SetAttributeValue("instancetypecode", optionSetValue); 
			}
		}

		/// <summary>
        /// ispartydeleted
        /// </summary>
		[DisplayName("Is Party Deleted")]
		[AttributeLogicalName("ispartydeleted")]
		public bool? IsPartyDeleted
		{	
			get { return GetAttributeValue<bool?>("ispartydeleted"); }
			set
			{ 
				if(value == IsPartyDeleted) return;
				SetAttributeValue("ispartydeleted", value);
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
        /// owningbusinessunit
        /// </summary>
		[DisplayName("owningbusinessunit")]
		[AttributeLogicalName("owningbusinessunit")]
		public Guid OwningbusinessunitId
		{	
			get { return GetAttributeValue<Guid>("owningbusinessunit"); }
			set
			{ 
				if(value == OwningbusinessunitId) return;
				SetAttributeValue("owningbusinessunit", value);
			}
		}	
			
		/// <summary>
        /// owninguser
        /// </summary>
		[DisplayName("owninguser")]
		[AttributeLogicalName("owninguser")]
		public Guid OwninguserId
		{	
			get { return GetAttributeValue<Guid>("owninguser"); }
			set
			{ 
				if(value == OwninguserId) return;
				SetAttributeValue("owninguser", value);
			}
		}	
			
		/// <summary>
        /// participationtypemask
        /// </summary>
		[DisplayName("Participation Type")]
		[AttributeLogicalName("participationtypemask")]
		public eParticipationType? ParticipationType
		{	
			get 
			{ 
				var optionSetValue = GetAttributeValue<OptionSetValue>("participationtypemask");
				if (optionSetValue != null) return (eParticipationType)optionSetValue.Value;
				else return null;
			}
			set 
			{ 
				if(value == ParticipationType) return;

				OptionSetValue optionSetValue = null;
				if(value != null) optionSetValue = new OptionSetValue((int)value);
				SetAttributeValue("participationtypemask", optionSetValue); 
			}
		}

		/// <summary>
        /// partyid
        /// </summary>
		[DisplayName("Party")]
		[AttributeLogicalName("partyid")]
		public EntityReference Party
		{	
			get { return GetAttributeValue<EntityReference>("partyid"); }
			set
			{ 
				if(value == Party) return;
				SetAttributeValue("partyid", value);
			}
		}	
			
		/// <summary>
        /// partyidname
        /// </summary>
		[DisplayName("partyidname")]
		[AttributeLogicalName("partyidname")]
		public string Partyidname
		{	
			get { return GetAttributeValue<string>("partyidname"); }
			set
			{ 
				if(value == Partyidname) return;
				SetAttributeValue("partyidname", value);
			}
		}	
			
		/// <summary>
        /// partyobjecttypecode
        /// </summary>
		[DisplayName("partyobjecttypecode")]
		[AttributeLogicalName("partyobjecttypecode")]
		public string Partyobjecttypecode
		{	
			get { return GetAttributeValue<string>("partyobjecttypecode"); }
			set
			{ 
				if(value == Partyobjecttypecode) return;
				SetAttributeValue("partyobjecttypecode", value);
			}
		}	
			
		/// <summary>
        /// resourcespecid
        /// </summary>
		[DisplayName("Resource Specification")]
		[AttributeLogicalName("resourcespecid")]
		public EntityReference ResourceSpecification
		{	
			get { return GetAttributeValue<EntityReference>("resourcespecid"); }
			set
			{ 
				if(value == ResourceSpecification) return;
				SetAttributeValue("resourcespecid", value);
			}
		}	
			
		/// <summary>
        /// resourcespecidname
        /// </summary>
		[DisplayName("resourcespecidname")]
		[AttributeLogicalName("resourcespecidname")]
		public string Resourcespecidname
		{	
			get { return GetAttributeValue<string>("resourcespecidname"); }
			set
			{ 
				if(value == Resourcespecidname) return;
				SetAttributeValue("resourcespecidname", value);
			}
		}	
			
		/// <summary>
        /// scheduledend
        /// </summary>
		[DisplayName("Scheduled End")]
		[AttributeLogicalName("scheduledend")]
		public DateTime? ScheduledEnd
		{	
			get { return GetAttributeValue<DateTime?>("scheduledend"); }
			set
			{ 
				if(value == ScheduledEnd) return;
				SetAttributeValue("scheduledend", value);
			}
		}	
			
		/// <summary>
        /// scheduledstart
        /// </summary>
		[DisplayName("Scheduled Start")]
		[AttributeLogicalName("scheduledstart")]
		public DateTime? ScheduledStart
		{	
			get { return GetAttributeValue<DateTime?>("scheduledstart"); }
			set
			{ 
				if(value == ScheduledStart) return;
				SetAttributeValue("scheduledstart", value);
			}
		}	
			
		/// <summary>
        /// versionnumber
        /// </summary>
		[DisplayName("versionnumber")]
		[AttributeLogicalName("versionnumber")]
		public int? Versionnumber
		{	
			get { return GetAttributeValue<int?>("versionnumber"); }
			set
			{ 
				if(value == Versionnumber) return;
				SetAttributeValue("versionnumber", value);
			}
		}	
			
		#endregion	

		#region Relations
			/// <summary>
        /// 1:N Get entities for 'ActivityParty_SyncErrors'
        /// </summary>
		[RelationshipSchemaName("ActivityParty_SyncErrors")]
		public IEnumerable<SyncError> ActivityPartySyncErrors
		{
			get { return GetRelatedEntities<SyncError>("ActivityParty_SyncErrors", null); }
			set { SetRelatedEntities("ActivityParty_SyncErrors", null, value); }
		}
		#endregion

		#region Actions
		#endregion

		#region OptionSetEnums
		public enum eAppointmentType
		{	
		
			[Label("Not Recurring")]
			[Description(@"")]
			NotRecurring = 0, 
		
			[Label("Recurring Master")]
			[Description(@"")]
			RecurringMaster = 1, 
		
			[Label("Recurring Instance")]
			[Description(@"")]
			RecurringInstance = 2, 
		
			[Label("Recurring Exception")]
			[Description(@"")]
			RecurringException = 3, 
		
			[Label("Recurring Future Exception")]
			[Description(@"")]
			RecurringFutureException = 4, 
		}
		
		public enum eParticipationType
		{	
		
			[Label("Sender")]
			[Description(@"")]
			Sender = 1, 
		
			[Label("To Recipient")]
			[Description(@"")]
			ToRecipient = 2, 
		
			[Label("CC Recipient")]
			[Description(@"")]
			CCRecipient = 3, 
		
			[Label("BCC Recipient")]
			[Description(@"")]
			BCCRecipient = 4, 
		
			[Label("Required attendee")]
			[Description(@"")]
			RequiredAttendee = 5, 
		
			[Label("Optional attendee")]
			[Description(@"")]
			OptionalAttendee = 6, 
		
			[Label("Organizer")]
			[Description(@"")]
			Organizer = 7, 
		
			[Label("Regarding")]
			[Description(@"")]
			Regarding = 8, 
		
			[Label("Owner")]
			[Description(@"")]
			Owner = 9, 
		
			[Label("Resource")]
			[Description(@"")]
			Resource = 10, 
		
			[Label("Customer")]
			[Description(@"")]
			Customer = 11, 
		}
		
		#endregion	

		#region Properties
		public static class Properties 
		{
			/// <summary>activityid</summary>
			public const string Activity = "activityid";

			/// <summary>activitypartyid</summary>
			public const string ActivityPartyId = "activitypartyid";

			/// <summary>addressused</summary>
			public const string Address = "addressused";

			/// <summary>addressusedemailcolumnnumber</summary>
			public const string EmailColumnNumberOfParty = "addressusedemailcolumnnumber";

			/// <summary>donotemail</summary>
			public const string DoNotAllowEmails = "donotemail";

			/// <summary>donotfax</summary>
			public const string DoNotAllowFaxes = "donotfax";

			/// <summary>donotphone</summary>
			public const string DoNotAllowPhoneCalls = "donotphone";

			/// <summary>donotpostalmail</summary>
			public const string DoNotAllowPostalMails = "donotpostalmail";

			/// <summary>effort</summary>
			public const string Effort = "effort";

			/// <summary>exchangeentryid</summary>
			public const string ExchangeEntry = "exchangeentryid";

			/// <summary>instancetypecode</summary>
			public const string AppointmentType = "instancetypecode";

			/// <summary>ispartydeleted</summary>
			public const string IsPartyDeleted = "ispartydeleted";

			/// <summary>ownerid</summary>
			public const string Owner = "ownerid";

			/// <summary>owneridtype</summary>
			public const string Owneridtype = "owneridtype";

			/// <summary>owningbusinessunit</summary>
			public const string OwningbusinessunitId = "owningbusinessunit";

			/// <summary>owninguser</summary>
			public const string OwninguserId = "owninguser";

			/// <summary>participationtypemask</summary>
			public const string ParticipationType = "participationtypemask";

			/// <summary>partyid</summary>
			public const string Party = "partyid";

			/// <summary>partyidname</summary>
			public const string Partyidname = "partyidname";

			/// <summary>partyobjecttypecode</summary>
			public const string Partyobjecttypecode = "partyobjecttypecode";

			/// <summary>resourcespecid</summary>
			public const string ResourceSpecification = "resourcespecid";

			/// <summary>resourcespecidname</summary>
			public const string Resourcespecidname = "resourcespecidname";

			/// <summary>scheduledend</summary>
			public const string ScheduledEnd = "scheduledend";

			/// <summary>scheduledstart</summary>
			public const string ScheduledStart = "scheduledstart";

			/// <summary>versionnumber</summary>
			public const string Versionnumber = "versionnumber";

		}
		#endregion

		#region Schemas
		public static class Schemas 
		{
			/// <summary>1:N ActivityParty_SyncErrors</summary>
			public const string ActivityPartySyncErrors = "ActivityParty_SyncErrors";

		}
		#endregion
	}
}

