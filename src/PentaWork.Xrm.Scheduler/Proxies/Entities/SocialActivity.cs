using System;
using System.Linq;
using System.Diagnostics;
using System.ComponentModel;
using Microsoft.Xrm.Sdk; 
using Microsoft.Xrm.Sdk.Client;
using System.Collections.Generic;

namespace PentaWork.Xrm.Scheduler.Proxies.Entities
{
	[DebuggerDisplay("{Subject}")] 	
	[EntityLogicalName("socialactivity")]
	public sealed class SocialActivity : Entity
	{	
		public static readonly int? EntityTypeCode = 4216;
		public new const string LogicalName = "socialactivity";
		public const string PrimaryIdAttribute = "activityid";
		public const string PrimaryNameAttribute = "subject";
	
		public SocialActivity() : base("socialactivity") { }

		#region Attributes
		/// <summary>
        /// activityadditionalparams
        /// </summary>
		[DisplayName("Additional Parameters")]
		[AttributeLogicalName("activityadditionalparams")]
		public string AdditionalParameters
		{	
			get { return GetAttributeValue<string>("activityadditionalparams"); }
			set
			{ 
				if(value == AdditionalParameters) return;
				SetAttributeValue("activityadditionalparams", value);
			}
		}	
			
		/// <summary>
        /// activityid
        /// </summary>
		[DisplayName("Activity")]
		[AttributeLogicalName("activityid")]
		public override Guid Id
		{
			get => base.Id;
			set { base.Id = value; SetAttributeValue("activityid", value); }
		}

							/// <summary>
        /// activitytypecode
        /// </summary>
		[DisplayName("Activity Type")]
		[AttributeLogicalName("activitytypecode")]
		public string ActivityType
		{	
			get { return GetAttributeValue<string>("activitytypecode"); }
			set
			{ 
				if(value == ActivityType) return;
				SetAttributeValue("activitytypecode", value);
			}
		}	
			
		/// <summary>
        /// actualdurationminutes
        /// </summary>
		[DisplayName("Actual Duration")]
		[AttributeLogicalName("actualdurationminutes")]
		public int? ActualDuration
		{	
			get { return GetAttributeValue<int?>("actualdurationminutes"); }
			set
			{ 
				if(value == ActualDuration) return;
				SetAttributeValue("actualdurationminutes", value);
			}
		}	
			
		/// <summary>
        /// actualend
        /// </summary>
		[DisplayName("Actual End")]
		[AttributeLogicalName("actualend")]
		public DateTime? ActualEnd
		{	
			get { return GetAttributeValue<DateTime?>("actualend"); }
			set
			{ 
				if(value == ActualEnd) return;
				SetAttributeValue("actualend", value);
			}
		}	
			
		/// <summary>
        /// actualstart
        /// </summary>
		[DisplayName("Actual Start")]
		[AttributeLogicalName("actualstart")]
		public DateTime? ActualStart
		{	
			get { return GetAttributeValue<DateTime?>("actualstart"); }
			set
			{ 
				if(value == ActualStart) return;
				SetAttributeValue("actualstart", value);
			}
		}	
			
		/// <summary>
        /// community
        /// </summary>
		[DisplayName("Social Channel")]
		[AttributeLogicalName("community")]
		public egSocialChannel? SocialChannel
		{	
			get 
			{ 
				var optionSetValue = GetAttributeValue<OptionSetValue>("community");
				if (optionSetValue != null) return (egSocialChannel)optionSetValue.Value;
				else return null;
			}
			set 
			{ 
				if(value == SocialChannel) return;

				OptionSetValue optionSetValue = null;
				if(value != null) optionSetValue = new OptionSetValue((int)value);
				SetAttributeValue("community", optionSetValue); 
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
        /// createdon
        /// </summary>
		[DisplayName("Created Date")]
		[AttributeLogicalName("createdon")]
		public DateTime? CreatedDate
		{	
			get { return GetAttributeValue<DateTime?>("createdon"); }
			set
			{ 
				if(value == CreatedDate) return;
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
		[DisplayName("Post Description")]
		[AttributeLogicalName("description")]
		public string PostDescription
		{	
			get { return GetAttributeValue<string>("description"); }
			set
			{ 
				if(value == PostDescription) return;
				SetAttributeValue("description", value);
			}
		}	
			
		/// <summary>
        /// directioncode
        /// </summary>
		[DisplayName("Direction")]
		[AttributeLogicalName("directioncode")]
		public bool? Direction
		{	
			get { return GetAttributeValue<bool?>("directioncode"); }
			set
			{ 
				if(value == Direction) return;
				SetAttributeValue("directioncode", value);
			}
		}	
			
		/// <summary>
        /// exchangerate
		///
		/// Precision: 10
		/// MaxValue: 100000000000
		/// MinValue: 0.0000000001
        /// </summary>
		[DisplayName("Exchange Rate")]
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
        /// from
        /// </summary>
		[DisplayName("From")]
		[AttributeLogicalName("from")]
		public EntityCollection From
		{	
			get { return GetAttributeValue<EntityCollection>("from"); }
			set
			{ 
				if(value == From) return;
				SetAttributeValue("from", value);
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
        /// inresponseto
        /// </summary>
		[DisplayName("In Response To")]
		[AttributeLogicalName("inresponseto")]
		public string InResponseTo
		{	
			get { return GetAttributeValue<string>("inresponseto"); }
			set
			{ 
				if(value == InResponseTo) return;
				SetAttributeValue("inresponseto", value);
			}
		}	
			
		/// <summary>
        /// isbilled
        /// </summary>
		[DisplayName("Is Billed")]
		[AttributeLogicalName("isbilled")]
		public bool? IsBilled
		{	
			get { return GetAttributeValue<bool?>("isbilled"); }
			set
			{ 
				if(value == IsBilled) return;
				SetAttributeValue("isbilled", value);
			}
		}	
			
		/// <summary>
        /// isregularactivity
        /// </summary>
		[DisplayName("Is Regular Activity")]
		[AttributeLogicalName("isregularactivity")]
		public bool? IsRegularActivity
		{	
			get { return GetAttributeValue<bool?>("isregularactivity"); }
			set
			{ 
				if(value == IsRegularActivity) return;
				SetAttributeValue("isregularactivity", value);
			}
		}	
			
		/// <summary>
        /// isworkflowcreated
        /// </summary>
		[DisplayName("Is Workflow Created")]
		[AttributeLogicalName("isworkflowcreated")]
		public bool? IsWorkflowCreated
		{	
			get { return GetAttributeValue<bool?>("isworkflowcreated"); }
			set
			{ 
				if(value == IsWorkflowCreated) return;
				SetAttributeValue("isworkflowcreated", value);
			}
		}	
			
		/// <summary>
        /// lastonholdtime
        /// </summary>
		[DisplayName("Last On Hold Time")]
		[AttributeLogicalName("lastonholdtime")]
		public DateTime? LastOnHoldTime
		{	
			get { return GetAttributeValue<DateTime?>("lastonholdtime"); }
			set
			{ 
				if(value == LastOnHoldTime) return;
				SetAttributeValue("lastonholdtime", value);
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
        /// modifiedon
        /// </summary>
		[DisplayName("Last Updated")]
		[AttributeLogicalName("modifiedon")]
		public DateTime? LastUpdated
		{	
			get { return GetAttributeValue<DateTime?>("modifiedon"); }
			set
			{ 
				if(value == LastUpdated) return;
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
        /// onholdtime
        /// </summary>
		[DisplayName("On Hold Time (Minutes)")]
		[AttributeLogicalName("onholdtime")]
		public int? OnHoldTimeMinutes
		{	
			get { return GetAttributeValue<int?>("onholdtime"); }
			set
			{ 
				if(value == OnHoldTimeMinutes) return;
				SetAttributeValue("onholdtime", value);
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
        /// postauthor
        /// </summary>
		[DisplayName("Post Author")]
		[AttributeLogicalName("postauthor")]
		public EntityReference PostAuthor
		{	
			get { return GetAttributeValue<EntityReference>("postauthor"); }
			set
			{ 
				if(value == PostAuthor) return;
				SetAttributeValue("postauthor", value);
			}
		}	
			
		/// <summary>
        /// postauthoraccount
        /// </summary>
		[DisplayName("Post Author Account")]
		[AttributeLogicalName("postauthoraccount")]
		public EntityReference PostAuthorAccount
		{	
			get { return GetAttributeValue<EntityReference>("postauthoraccount"); }
			set
			{ 
				if(value == PostAuthorAccount) return;
				SetAttributeValue("postauthoraccount", value);
			}
		}	
			
		/// <summary>
        /// postauthoraccountname
        /// </summary>
		[DisplayName("Post author parent")]
		[AttributeLogicalName("postauthoraccountname")]
		public string PostAuthorParent
		{	
			get { return GetAttributeValue<string>("postauthoraccountname"); }
			set
			{ 
				if(value == PostAuthorParent) return;
				SetAttributeValue("postauthoraccountname", value);
			}
		}	
			
		/// <summary>
        /// postauthoraccounttype
        /// </summary>
		[DisplayName("Post author parent")]
		[AttributeLogicalName("postauthoraccounttype")]
		public string PostAuthorParent2
		{	
			get { return GetAttributeValue<string>("postauthoraccounttype"); }
			set
			{ 
				if(value == PostAuthorParent2) return;
				SetAttributeValue("postauthoraccounttype", value);
			}
		}	
			
		/// <summary>
        /// postauthoraccountyominame
        /// </summary>
		[DisplayName("Post author parent")]
		[AttributeLogicalName("postauthoraccountyominame")]
		public string PostAuthorParent3
		{	
			get { return GetAttributeValue<string>("postauthoraccountyominame"); }
			set
			{ 
				if(value == PostAuthorParent3) return;
				SetAttributeValue("postauthoraccountyominame", value);
			}
		}	
			
		/// <summary>
        /// postauthorname
        /// </summary>
		[DisplayName("Post Author Name")]
		[AttributeLogicalName("postauthorname")]
		public string PostAuthorName
		{	
			get { return GetAttributeValue<string>("postauthorname"); }
			set
			{ 
				if(value == PostAuthorName) return;
				SetAttributeValue("postauthorname", value);
			}
		}	
			
		/// <summary>
        /// postauthortype
        /// </summary>
		[DisplayName("Post Author Type")]
		[AttributeLogicalName("postauthortype")]
		public string PostAuthorType
		{	
			get { return GetAttributeValue<string>("postauthortype"); }
			set
			{ 
				if(value == PostAuthorType) return;
				SetAttributeValue("postauthortype", value);
			}
		}	
			
		/// <summary>
        /// postauthoryominame
        /// </summary>
		[DisplayName("Post Author Yomi Name")]
		[AttributeLogicalName("postauthoryominame")]
		public string PostAuthorYomiName
		{	
			get { return GetAttributeValue<string>("postauthoryominame"); }
			set
			{ 
				if(value == PostAuthorYomiName) return;
				SetAttributeValue("postauthoryominame", value);
			}
		}	
			
		/// <summary>
        /// postedbyname
        /// </summary>
		[DisplayName("postedbyname")]
		[AttributeLogicalName("postedbyname")]
		public string Postedbyname
		{	
			get { return GetAttributeValue<string>("postedbyname"); }
			set
			{ 
				if(value == Postedbyname) return;
				SetAttributeValue("postedbyname", value);
			}
		}	
			
		/// <summary>
        /// postedon
        /// </summary>
		[DisplayName("Created On")]
		[AttributeLogicalName("postedon")]
		public DateTime? CreatedOn
		{	
			get { return GetAttributeValue<DateTime?>("postedon"); }
			set
			{ 
				if(value == CreatedOn) return;
				SetAttributeValue("postedon", value);
			}
		}	
			
		/// <summary>
        /// postfromprofileid
        /// </summary>
		[DisplayName("Posted By")]
		[AttributeLogicalName("postfromprofileid")]
		public EntityReference PostedBy
		{	
			get { return GetAttributeValue<EntityReference>("postfromprofileid"); }
			set
			{ 
				if(value == PostedBy) return;
				SetAttributeValue("postfromprofileid", value);
			}
		}	
			
		/// <summary>
        /// postid
        /// </summary>
		[DisplayName("Post ID")]
		[AttributeLogicalName("postid")]
		public string PostID
		{	
			get { return GetAttributeValue<string>("postid"); }
			set
			{ 
				if(value == PostID) return;
				SetAttributeValue("postid", value);
			}
		}	
			
		/// <summary>
        /// postmessagetype
        /// </summary>
		[DisplayName("Received As")]
		[AttributeLogicalName("postmessagetype")]
		public egPostMessageType? ReceivedAs
		{	
			get 
			{ 
				var optionSetValue = GetAttributeValue<OptionSetValue>("postmessagetype");
				if (optionSetValue != null) return (egPostMessageType)optionSetValue.Value;
				else return null;
			}
			set 
			{ 
				if(value == ReceivedAs) return;

				OptionSetValue optionSetValue = null;
				if(value != null) optionSetValue = new OptionSetValue((int)value);
				SetAttributeValue("postmessagetype", optionSetValue); 
			}
		}

		/// <summary>
        /// posttoprofileid
        /// </summary>
		[DisplayName("Posted To")]
		[AttributeLogicalName("posttoprofileid")]
		public string PostedTo
		{	
			get { return GetAttributeValue<string>("posttoprofileid"); }
			set
			{ 
				if(value == PostedTo) return;
				SetAttributeValue("posttoprofileid", value);
			}
		}	
			
		/// <summary>
        /// posturl
        /// </summary>
		[DisplayName("Post URL")]
		[AttributeLogicalName("posturl")]
		public string PostURL
		{	
			get { return GetAttributeValue<string>("posturl"); }
			set
			{ 
				if(value == PostURL) return;
				SetAttributeValue("posturl", value);
			}
		}	
			
		/// <summary>
        /// prioritycode
        /// </summary>
		[DisplayName("Priority")]
		[AttributeLogicalName("prioritycode")]
		public ePriority? Priority
		{	
			get 
			{ 
				var optionSetValue = GetAttributeValue<OptionSetValue>("prioritycode");
				if (optionSetValue != null) return (ePriority)optionSetValue.Value;
				else return null;
			}
			set 
			{ 
				if(value == Priority) return;

				OptionSetValue optionSetValue = null;
				if(value != null) optionSetValue = new OptionSetValue((int)value);
				SetAttributeValue("prioritycode", optionSetValue); 
			}
		}

		/// <summary>
        /// processid
        /// </summary>
		[DisplayName("Process")]
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
        /// regardingobjecttypecode
        /// </summary>
		[DisplayName("regardingobjecttypecode")]
		[AttributeLogicalName("regardingobjecttypecode")]
		public string Regardingobjecttypecode
		{	
			get { return GetAttributeValue<string>("regardingobjecttypecode"); }
			set
			{ 
				if(value == Regardingobjecttypecode) return;
				SetAttributeValue("regardingobjecttypecode", value);
			}
		}	
			
		/// <summary>
        /// resources
        /// </summary>
		[DisplayName("Resources")]
		[AttributeLogicalName("resources")]
		public EntityCollection Resources
		{	
			get { return GetAttributeValue<EntityCollection>("resources"); }
			set
			{ 
				if(value == Resources) return;
				SetAttributeValue("resources", value);
			}
		}	
			
		/// <summary>
        /// scheduleddurationminutes
        /// </summary>
		[DisplayName("Scheduled Duration")]
		[AttributeLogicalName("scheduleddurationminutes")]
		public int? ScheduledDuration
		{	
			get { return GetAttributeValue<int?>("scheduleddurationminutes"); }
			set
			{ 
				if(value == ScheduledDuration) return;
				SetAttributeValue("scheduleddurationminutes", value);
			}
		}	
			
		/// <summary>
        /// scheduledend
        /// </summary>
		[DisplayName("Due Date")]
		[AttributeLogicalName("scheduledend")]
		public DateTime? DueDate
		{	
			get { return GetAttributeValue<DateTime?>("scheduledend"); }
			set
			{ 
				if(value == DueDate) return;
				SetAttributeValue("scheduledend", value);
			}
		}	
			
		/// <summary>
        /// scheduledstart
        /// </summary>
		[DisplayName("Start Date")]
		[AttributeLogicalName("scheduledstart")]
		public DateTime? StartDate
		{	
			get { return GetAttributeValue<DateTime?>("scheduledstart"); }
			set
			{ 
				if(value == StartDate) return;
				SetAttributeValue("scheduledstart", value);
			}
		}	
			
		/// <summary>
        /// sentimentvalue
		///
		/// Precision: 2
		/// MaxValue: 100000000000
		/// MinValue: -100000000000
        /// </summary>
		[DisplayName("Sentiment Value")]
		[AttributeLogicalName("sentimentvalue")]
		public double? SentimentValue
		{	
			get { return GetAttributeValue<double?>("sentimentvalue"); }
			set 
			{
				double? doubleValue = null;
				if(value != null) doubleValue = Math.Round(value.Value, 2);
				if(doubleValue == SentimentValue) return;
				SetAttributeValue("sentimentvalue", doubleValue);  
			}
		}

		/// <summary>
        /// serviceid
        /// </summary>
		[DisplayName("Service")]
		[AttributeLogicalName("serviceid")]
		public EntityReference Service
		{	
			get { return GetAttributeValue<EntityReference>("serviceid"); }
			set
			{ 
				if(value == Service) return;
				SetAttributeValue("serviceid", value);
			}
		}	
			
		/// <summary>
        /// serviceidname
        /// </summary>
		[DisplayName("serviceidname")]
		[AttributeLogicalName("serviceidname")]
		public string Serviceidname
		{	
			get { return GetAttributeValue<string>("serviceidname"); }
			set
			{ 
				if(value == Serviceidname) return;
				SetAttributeValue("serviceidname", value);
			}
		}	
			
		/// <summary>
        /// slaid
        /// </summary>
		[DisplayName("SLA")]
		[AttributeLogicalName("slaid")]
		public EntityReference SLA
		{	
			get { return GetAttributeValue<EntityReference>("slaid"); }
			set
			{ 
				if(value == SLA) return;
				SetAttributeValue("slaid", value);
			}
		}	
			
		/// <summary>
        /// slainvokedid
        /// </summary>
		[DisplayName("Last SLA applied")]
		[AttributeLogicalName("slainvokedid")]
		public EntityReference LastSLAApplied
		{	
			get { return GetAttributeValue<EntityReference>("slainvokedid"); }
			set
			{ 
				if(value == LastSLAApplied) return;
				SetAttributeValue("slainvokedid", value);
			}
		}	
			
		/// <summary>
        /// slainvokedidname
        /// </summary>
		[DisplayName("slainvokedidname")]
		[AttributeLogicalName("slainvokedidname")]
		public string Slainvokedidname
		{	
			get { return GetAttributeValue<string>("slainvokedidname"); }
			set
			{ 
				if(value == Slainvokedidname) return;
				SetAttributeValue("slainvokedidname", value);
			}
		}	
			
		/// <summary>
        /// slaname
        /// </summary>
		[DisplayName("slaname")]
		[AttributeLogicalName("slaname")]
		public string Slaname
		{	
			get { return GetAttributeValue<string>("slaname"); }
			set
			{ 
				if(value == Slaname) return;
				SetAttributeValue("slaname", value);
			}
		}	
			
		/// <summary>
        /// socialadditionalparams
        /// </summary>
		[DisplayName("Social Additional Parameters")]
		[AttributeLogicalName("socialadditionalparams")]
		public string SocialAdditionalParameters
		{	
			get { return GetAttributeValue<string>("socialadditionalparams"); }
			set
			{ 
				if(value == SocialAdditionalParameters) return;
				SetAttributeValue("socialadditionalparams", value);
			}
		}	
			
		/// <summary>
        /// sortdate
        /// </summary>
		[DisplayName("Sort Date")]
		[AttributeLogicalName("sortdate")]
		public DateTime? SortDate
		{	
			get { return GetAttributeValue<DateTime?>("sortdate"); }
			set
			{ 
				if(value == SortDate) return;
				SetAttributeValue("sortdate", value);
			}
		}	
			
		/// <summary>
        /// stageid
        /// </summary>
		[DisplayName("(Deprecated) Process Stage")]
		[AttributeLogicalName("stageid")]
		public Guid DeprecatedProcessStageId
		{	
			get { return GetAttributeValue<Guid>("stageid"); }
			set
			{ 
				if(value == DeprecatedProcessStageId) return;
				SetAttributeValue("stageid", value);
			}
		}	
			
		/// <summary>
        /// statecode
        /// </summary>
		[DisplayName("Status")]
		[AttributeLogicalName("statecode")]
		public eActivityStatus? Status
		{	
			get 
			{ 
				var optionSetValue = GetAttributeValue<OptionSetValue>("statecode");
				if (optionSetValue != null) return (eActivityStatus)optionSetValue.Value;
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
        /// subject
        /// </summary>
		[DisplayName("Subject")]
		[AttributeLogicalName("subject")]
		public string Subject
		{	
			get { return GetAttributeValue<string>("subject"); }
			set
			{ 
				if(value == Subject) return;
				SetAttributeValue("subject", value);
			}
		}	
			
		/// <summary>
        /// threadid
        /// </summary>
		[DisplayName("Thread ID")]
		[AttributeLogicalName("threadid")]
		public string ThreadID
		{	
			get { return GetAttributeValue<string>("threadid"); }
			set
			{ 
				if(value == ThreadID) return;
				SetAttributeValue("threadid", value);
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
        /// to
        /// </summary>
		[DisplayName("To")]
		[AttributeLogicalName("to")]
		public EntityCollection To
		{	
			get { return GetAttributeValue<EntityCollection>("to"); }
			set
			{ 
				if(value == To) return;
				SetAttributeValue("to", value);
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
        /// 1:N Get entities for 'slakpiinstance_socialactivity'
        /// </summary>
		[RelationshipSchemaName("slakpiinstance_socialactivity")]
		public IEnumerable<SLAKPIInstance> SlakpiinstanceSocialactivity
		{
			get { return GetRelatedEntities<SLAKPIInstance>("slakpiinstance_socialactivity", null); }
			set { SetRelatedEntities("slakpiinstance_socialactivity", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'socialactivity_activity_parties'
        /// </summary>
		[RelationshipSchemaName("socialactivity_activity_parties")]
		public IEnumerable<ActivityParty> SocialactivityActivityParties
		{
			get { return GetRelatedEntities<ActivityParty>("socialactivity_activity_parties", null); }
			set { SetRelatedEntities("socialactivity_activity_parties", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'SocialActivity_Annotation'
        /// </summary>
		[RelationshipSchemaName("SocialActivity_Annotation")]
		public IEnumerable<Note> SocialActivityAnnotation
		{
			get { return GetRelatedEntities<Note>("SocialActivity_Annotation", null); }
			set { SetRelatedEntities("SocialActivity_Annotation", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'SocialActivity_AsyncOperations'
        /// </summary>
		[RelationshipSchemaName("SocialActivity_AsyncOperations")]
		public IEnumerable<SystemJob> SocialActivityAsyncOperations
		{
			get { return GetRelatedEntities<SystemJob>("SocialActivity_AsyncOperations", null); }
			set { SetRelatedEntities("SocialActivity_AsyncOperations", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'SocialActivity_BulkDeleteFailures'
        /// </summary>
		[RelationshipSchemaName("SocialActivity_BulkDeleteFailures")]
		public IEnumerable<BulkDeleteFailure> SocialActivityBulkDeleteFailures
		{
			get { return GetRelatedEntities<BulkDeleteFailure>("SocialActivity_BulkDeleteFailures", null); }
			set { SetRelatedEntities("SocialActivity_BulkDeleteFailures", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'socialactivity_connections1'
        /// </summary>
		[RelationshipSchemaName("socialactivity_connections1")]
		public IEnumerable<Connection> SocialactivityConnections1
		{
			get { return GetRelatedEntities<Connection>("socialactivity_connections1", null); }
			set { SetRelatedEntities("socialactivity_connections1", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'socialactivity_connections2'
        /// </summary>
		[RelationshipSchemaName("socialactivity_connections2")]
		public IEnumerable<Connection> SocialactivityConnections2
		{
			get { return GetRelatedEntities<Connection>("socialactivity_connections2", null); }
			set { SetRelatedEntities("socialactivity_connections2", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'SocialActivity_DuplicateBaseRecord'
        /// </summary>
		[RelationshipSchemaName("SocialActivity_DuplicateBaseRecord")]
		public IEnumerable<DuplicateRecord> SocialActivityDuplicateBaseRecord
		{
			get { return GetRelatedEntities<DuplicateRecord>("SocialActivity_DuplicateBaseRecord", null); }
			set { SetRelatedEntities("SocialActivity_DuplicateBaseRecord", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'SocialActivity_DuplicateMatchingRecord'
        /// </summary>
		[RelationshipSchemaName("SocialActivity_DuplicateMatchingRecord")]
		public IEnumerable<DuplicateRecord> SocialActivityDuplicateMatchingRecord
		{
			get { return GetRelatedEntities<DuplicateRecord>("SocialActivity_DuplicateMatchingRecord", null); }
			set { SetRelatedEntities("SocialActivity_DuplicateMatchingRecord", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'socialactivity_principalobjectattributeaccess'
        /// </summary>
		[RelationshipSchemaName("socialactivity_principalobjectattributeaccess")]
		public IEnumerable<FieldSharing> SocialactivityPrincipalobjectattributeaccess
		{
			get { return GetRelatedEntities<FieldSharing>("socialactivity_principalobjectattributeaccess", null); }
			set { SetRelatedEntities("socialactivity_principalobjectattributeaccess", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'SocialActivity_ProcessSessions'
        /// </summary>
		[RelationshipSchemaName("SocialActivity_ProcessSessions")]
		public IEnumerable<ProcessSession> SocialActivityProcessSessions
		{
			get { return GetRelatedEntities<ProcessSession>("SocialActivity_ProcessSessions", null); }
			set { SetRelatedEntities("SocialActivity_ProcessSessions", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'SocialActivity_QueueItem'
        /// </summary>
		[RelationshipSchemaName("SocialActivity_QueueItem")]
		public IEnumerable<QueueItem> SocialActivityQueueItem
		{
			get { return GetRelatedEntities<QueueItem>("SocialActivity_QueueItem", null); }
			set { SetRelatedEntities("SocialActivity_QueueItem", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'SocialActivity_SyncErrors'
        /// </summary>
		[RelationshipSchemaName("SocialActivity_SyncErrors")]
		public IEnumerable<SyncError> SocialActivitySyncErrors
		{
			get { return GetRelatedEntities<SyncError>("SocialActivity_SyncErrors", null); }
			set { SetRelatedEntities("SocialActivity_SyncErrors", null, value); }
		}
		#endregion

		#region Actions
		#endregion

		#region OptionSetEnums
		public enum egPostMessageType
		{	
		
			[Label("Public Message")]
			[Description(@"")]
			PublicMessage = 0, 
		
			[Label("Private Message")]
			[Description(@"")]
			PrivateMessage = 1, 
		}
		
		public enum ePriority
		{	
		
			[Label("Low")]
			[Description(@"")]
			Low = 0, 
		
			[Label("Normal")]
			[Description(@"")]
			Normal = 1, 
		
			[Label("High")]
			[Description(@"")]
			High = 2, 
		}
		
		public enum eActivityStatus
		{	
		
			[Label("Open")]
			[Description(@"")]
			Open = 0, 
		
			[Label("Completed")]
			[Description(@"")]
			Completed = 1, 
		
			[Label("Canceled")]
			[Description(@"")]
			Canceled = 2, 
		}
		
		public enum eStatusReason
		{	
		
			[Label("Completed")]
			[Description(@"")]
			Completed_Inactive = 1, 
		
			[Label("Failed")]
			[Description(@"")]
			Failed_Inactive = 2, 
		
			[Label("Processing")]
			[Description(@"")]
			Processing_Inactive = 3, 
		
			[Label("Open")]
			[Description(@"")]
			Open_Active = 4, 
		
			[Label("Canceled")]
			[Description(@"")]
			Canceled = 5, 
		}
		
		public enum egSocialChannel
		{	
		
			[Label("Facebook")]
			[Description(@"Facebook item.")]
			Facebook = 1, 
		
			[Label("Twitter")]
			[Description(@"Twitter.")]
			Twitter = 2, 
		
			[Label("Other")]
			[Description(@"Other default")]
			Other = 0, 
		}
		
		#endregion	

		#region Properties
		public static class Properties 
		{
			/// <summary>activityadditionalparams</summary>
			public const string AdditionalParameters = "activityadditionalparams";

			/// <summary>activityid</summary>
			public const string ActivityId = "activityid";

			/// <summary>activitytypecode</summary>
			public const string ActivityType = "activitytypecode";

			/// <summary>actualdurationminutes</summary>
			public const string ActualDuration = "actualdurationminutes";

			/// <summary>actualend</summary>
			public const string ActualEnd = "actualend";

			/// <summary>actualstart</summary>
			public const string ActualStart = "actualstart";

			/// <summary>community</summary>
			public const string SocialChannel = "community";

			/// <summary>createdby</summary>
			public const string CreatedBy = "createdby";

			/// <summary>createdon</summary>
			public const string CreatedDate = "createdon";

			/// <summary>createdonbehalfby</summary>
			public const string CreatedByDelegate = "createdonbehalfby";

			/// <summary>createdonbehalfbyname</summary>
			public const string Createdonbehalfbyname = "createdonbehalfbyname";

			/// <summary>createdonbehalfbyyominame</summary>
			public const string Createdonbehalfbyyominame = "createdonbehalfbyyominame";

			/// <summary>description</summary>
			public const string PostDescription = "description";

			/// <summary>directioncode</summary>
			public const string Direction = "directioncode";

			/// <summary>exchangerate</summary>
			public const string ExchangeRate = "exchangerate";

			/// <summary>from</summary>
			public const string From = "from";

			/// <summary>importsequencenumber</summary>
			public const string ImportSequenceNumber = "importsequencenumber";

			/// <summary>inresponseto</summary>
			public const string InResponseTo = "inresponseto";

			/// <summary>isbilled</summary>
			public const string IsBilled = "isbilled";

			/// <summary>isregularactivity</summary>
			public const string IsRegularActivity = "isregularactivity";

			/// <summary>isworkflowcreated</summary>
			public const string IsWorkflowCreated = "isworkflowcreated";

			/// <summary>lastonholdtime</summary>
			public const string LastOnHoldTime = "lastonholdtime";

			/// <summary>modifiedby</summary>
			public const string ModifiedBy = "modifiedby";

			/// <summary>modifiedon</summary>
			public const string LastUpdated = "modifiedon";

			/// <summary>modifiedonbehalfby</summary>
			public const string ModifiedByDelegate = "modifiedonbehalfby";

			/// <summary>modifiedonbehalfbyname</summary>
			public const string Modifiedonbehalfbyname = "modifiedonbehalfbyname";

			/// <summary>modifiedonbehalfbyyominame</summary>
			public const string Modifiedonbehalfbyyominame = "modifiedonbehalfbyyominame";

			/// <summary>onholdtime</summary>
			public const string OnHoldTimeMinutes = "onholdtime";

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

			/// <summary>postauthor</summary>
			public const string PostAuthor = "postauthor";

			/// <summary>postauthoraccount</summary>
			public const string PostAuthorAccount = "postauthoraccount";

			/// <summary>postauthoraccountname</summary>
			public const string PostAuthorParent = "postauthoraccountname";

			/// <summary>postauthoraccounttype</summary>
			public const string PostAuthorParent2 = "postauthoraccounttype";

			/// <summary>postauthoraccountyominame</summary>
			public const string PostAuthorParent3 = "postauthoraccountyominame";

			/// <summary>postauthorname</summary>
			public const string PostAuthorName = "postauthorname";

			/// <summary>postauthortype</summary>
			public const string PostAuthorType = "postauthortype";

			/// <summary>postauthoryominame</summary>
			public const string PostAuthorYomiName = "postauthoryominame";

			/// <summary>postedbyname</summary>
			public const string Postedbyname = "postedbyname";

			/// <summary>postedon</summary>
			public const string CreatedOn = "postedon";

			/// <summary>postfromprofileid</summary>
			public const string PostedBy = "postfromprofileid";

			/// <summary>postid</summary>
			public const string PostID = "postid";

			/// <summary>postmessagetype</summary>
			public const string ReceivedAs = "postmessagetype";

			/// <summary>posttoprofileid</summary>
			public const string PostedTo = "posttoprofileid";

			/// <summary>posturl</summary>
			public const string PostURL = "posturl";

			/// <summary>prioritycode</summary>
			public const string Priority = "prioritycode";

			/// <summary>processid</summary>
			public const string ProcessId = "processid";

			/// <summary>regardingobjectid</summary>
			public const string Regarding = "regardingobjectid";

			/// <summary>regardingobjectidname</summary>
			public const string Regardingobjectidname = "regardingobjectidname";

			/// <summary>regardingobjectidyominame</summary>
			public const string Regardingobjectidyominame = "regardingobjectidyominame";

			/// <summary>regardingobjecttypecode</summary>
			public const string Regardingobjecttypecode = "regardingobjecttypecode";

			/// <summary>resources</summary>
			public const string Resources = "resources";

			/// <summary>scheduleddurationminutes</summary>
			public const string ScheduledDuration = "scheduleddurationminutes";

			/// <summary>scheduledend</summary>
			public const string DueDate = "scheduledend";

			/// <summary>scheduledstart</summary>
			public const string StartDate = "scheduledstart";

			/// <summary>sentimentvalue</summary>
			public const string SentimentValue = "sentimentvalue";

			/// <summary>serviceid</summary>
			public const string Service = "serviceid";

			/// <summary>serviceidname</summary>
			public const string Serviceidname = "serviceidname";

			/// <summary>slaid</summary>
			public const string SLA = "slaid";

			/// <summary>slainvokedid</summary>
			public const string LastSLAApplied = "slainvokedid";

			/// <summary>slainvokedidname</summary>
			public const string Slainvokedidname = "slainvokedidname";

			/// <summary>slaname</summary>
			public const string Slaname = "slaname";

			/// <summary>socialadditionalparams</summary>
			public const string SocialAdditionalParameters = "socialadditionalparams";

			/// <summary>sortdate</summary>
			public const string SortDate = "sortdate";

			/// <summary>stageid</summary>
			public const string DeprecatedProcessStageId = "stageid";

			/// <summary>statecode</summary>
			public const string Status = "statecode";

			/// <summary>statuscode</summary>
			public const string StatusReason = "statuscode";

			/// <summary>subject</summary>
			public const string Subject = "subject";

			/// <summary>threadid</summary>
			public const string ThreadID = "threadid";

			/// <summary>timezoneruleversionnumber</summary>
			public const string TimeZoneRuleVersionNumber = "timezoneruleversionnumber";

			/// <summary>to</summary>
			public const string To = "to";

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
			/// <summary>1:N slakpiinstance_socialactivity</summary>
			public const string SlakpiinstanceSocialactivity = "slakpiinstance_socialactivity";

			/// <summary>1:N socialactivity_activity_parties</summary>
			public const string SocialactivityActivityParties = "socialactivity_activity_parties";

			/// <summary>1:N SocialActivity_Annotation</summary>
			public const string SocialActivityAnnotation = "SocialActivity_Annotation";

			/// <summary>1:N SocialActivity_AsyncOperations</summary>
			public const string SocialActivityAsyncOperations = "SocialActivity_AsyncOperations";

			/// <summary>1:N SocialActivity_BulkDeleteFailures</summary>
			public const string SocialActivityBulkDeleteFailures = "SocialActivity_BulkDeleteFailures";

			/// <summary>1:N socialactivity_connections1</summary>
			public const string SocialactivityConnections1 = "socialactivity_connections1";

			/// <summary>1:N socialactivity_connections2</summary>
			public const string SocialactivityConnections2 = "socialactivity_connections2";

			/// <summary>1:N SocialActivity_DuplicateBaseRecord</summary>
			public const string SocialActivityDuplicateBaseRecord = "SocialActivity_DuplicateBaseRecord";

			/// <summary>1:N SocialActivity_DuplicateMatchingRecord</summary>
			public const string SocialActivityDuplicateMatchingRecord = "SocialActivity_DuplicateMatchingRecord";

			/// <summary>1:N socialactivity_principalobjectattributeaccess</summary>
			public const string SocialactivityPrincipalobjectattributeaccess = "socialactivity_principalobjectattributeaccess";

			/// <summary>1:N SocialActivity_ProcessSessions</summary>
			public const string SocialActivityProcessSessions = "SocialActivity_ProcessSessions";

			/// <summary>1:N SocialActivity_QueueItem</summary>
			public const string SocialActivityQueueItem = "SocialActivity_QueueItem";

			/// <summary>1:N SocialActivity_SyncErrors</summary>
			public const string SocialActivitySyncErrors = "SocialActivity_SyncErrors";

		}
		#endregion
	}
}

