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
	[EntityLogicalName("interactionforemail")]
	public sealed class InteractionForEmail : Entity
	{	
		public static readonly int? EntityTypeCode = 9986;
		public new const string LogicalName = "interactionforemail";
		public const string PrimaryIdAttribute = "interactionforemailid";
		public const string PrimaryNameAttribute = "name";
	
		public InteractionForEmail() : base("interactionforemail") { }

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
        /// emailactivityid
        /// </summary>
		[DisplayName("Email Activity Id")]
		[AttributeLogicalName("emailactivityid")]
		public Guid EmailActivityId
		{	
			get { return GetAttributeValue<Guid>("emailactivityid"); }
			set
			{ 
				if(value == EmailActivityId) return;
				SetAttributeValue("emailactivityid", value);
			}
		}	
			
		/// <summary>
        /// emailaddress
        /// </summary>
		[DisplayName("Email Interaction Component Related Text")]
		[AttributeLogicalName("emailaddress")]
		public string EmailInteractionComponentRelatedText
		{	
			get { return GetAttributeValue<string>("emailaddress"); }
			set
			{ 
				if(value == EmailInteractionComponentRelatedText) return;
				SetAttributeValue("emailaddress", value);
			}
		}	
			
		/// <summary>
        /// emailinteractionreplyid
        /// </summary>
		[DisplayName("Email Activity Id")]
		[AttributeLogicalName("emailinteractionreplyid")]
		public Guid EmailActivityId2
		{	
			get { return GetAttributeValue<Guid>("emailinteractionreplyid"); }
			set
			{ 
				if(value == EmailActivityId2) return;
				SetAttributeValue("emailinteractionreplyid", value);
			}
		}	
			
		/// <summary>
        /// emailinteractiontime
        /// </summary>
		[DisplayName("Interaction date and time of the an email")]
		[AttributeLogicalName("emailinteractiontime")]
		public DateTime? InteractionDateAndTimeOfTheAnEmail
		{	
			get { return GetAttributeValue<DateTime?>("emailinteractiontime"); }
			set
			{ 
				if(value == InteractionDateAndTimeOfTheAnEmail) return;
				SetAttributeValue("emailinteractiontime", value);
			}
		}	
			
		/// <summary>
        /// exchangerate
        /// </summary>
		[DisplayName("ExchangeRate")]
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
        /// interactedcomponenttext
        /// </summary>
		[DisplayName("Email Interaction Component Related Text")]
		[AttributeLogicalName("interactedcomponenttext")]
		public string EmailInteractionComponentRelatedText2
		{	
			get { return GetAttributeValue<string>("interactedcomponenttext"); }
			set
			{ 
				if(value == EmailInteractionComponentRelatedText2) return;
				SetAttributeValue("interactedcomponenttext", value);
			}
		}	
			
		/// <summary>
        /// interactionforemailid
        /// </summary>
		[DisplayName("Interaction for Email")]
		[AttributeLogicalName("interactionforemailid")]
		public override Guid Id
		{
			get => base.Id;
			set { base.Id = value; SetAttributeValue("interactionforemailid", value); }
		}

							/// <summary>
        /// interactionlocation
        /// </summary>
		[DisplayName("Location for an Interaction")]
		[AttributeLogicalName("interactionlocation")]
		public string LocationForAnInteraction
		{	
			get { return GetAttributeValue<string>("interactionlocation"); }
			set
			{ 
				if(value == LocationForAnInteraction) return;
				SetAttributeValue("interactionlocation", value);
			}
		}	
			
		/// <summary>
        /// interactionpartyid
        /// </summary>
		[DisplayName("Interaction party id.")]
		[AttributeLogicalName("interactionpartyid")]
		public Guid InteractionPartyId
		{	
			get { return GetAttributeValue<Guid>("interactionpartyid"); }
			set
			{ 
				if(value == InteractionPartyId) return;
				SetAttributeValue("interactionpartyid", value);
			}
		}	
			
		/// <summary>
        /// interactionpartytypecode
        /// </summary>
		[DisplayName("Interaction party type code.")]
		[AttributeLogicalName("interactionpartytypecode")]
		public int? InteractionPartyTypeCode
		{	
			get { return GetAttributeValue<int?>("interactionpartytypecode"); }
			set
			{ 
				if(value == InteractionPartyTypeCode) return;
				SetAttributeValue("interactionpartytypecode", value);
			}
		}	
			
		/// <summary>
        /// interactionrepliedby
        /// </summary>
		[DisplayName("Name who replied to email if interaction is reply")]
		[AttributeLogicalName("interactionrepliedby")]
		public string NameWhoRepliedToEmailIfInteractionIsReply
		{	
			get { return GetAttributeValue<string>("interactionrepliedby"); }
			set
			{ 
				if(value == NameWhoRepliedToEmailIfInteractionIsReply) return;
				SetAttributeValue("interactionrepliedby", value);
			}
		}	
			
		/// <summary>
        /// interactionreplyid
        /// </summary>
		[DisplayName("InteractionReplyId")]
		[AttributeLogicalName("interactionreplyid")]
		public string InteractionReplyId
		{	
			get { return GetAttributeValue<string>("interactionreplyid"); }
			set
			{ 
				if(value == InteractionReplyId) return;
				SetAttributeValue("interactionreplyid", value);
			}
		}	
			
		/// <summary>
        /// interactiontype
        /// </summary>
		[DisplayName("Interaction Type")]
		[AttributeLogicalName("interactiontype")]
		public eInteractionType? InteractionType
		{	
			get 
			{ 
				var optionSetValue = GetAttributeValue<OptionSetValue>("interactiontype");
				if (optionSetValue != null) return (eInteractionType)optionSetValue.Value;
				else return null;
			}
			set 
			{ 
				if(value == InteractionType) return;

				OptionSetValue optionSetValue = null;
				if(value != null) optionSetValue = new OptionSetValue((int)value);
				SetAttributeValue("interactiontype", optionSetValue); 
			}
		}

		/// <summary>
        /// interactionuseragent
        /// </summary>
		[DisplayName("User Agent for an Interaction")]
		[AttributeLogicalName("interactionuseragent")]
		public string UserAgentForAnInteraction
		{	
			get { return GetAttributeValue<string>("interactionuseragent"); }
			set
			{ 
				if(value == UserAgentForAnInteraction) return;
				SetAttributeValue("interactionuseragent", value);
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
        /// 1:N Get entities for 'interactionforemail_ActivityPointers'
        /// </summary>
		[RelationshipSchemaName("interactionforemail_ActivityPointers")]
		public IEnumerable<Activity> InteractionforemailActivityPointers
		{
			get { return GetRelatedEntities<Activity>("interactionforemail_ActivityPointers", null); }
			set { SetRelatedEntities("interactionforemail_ActivityPointers", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'interactionforemail_AsyncOperations'
        /// </summary>
		[RelationshipSchemaName("interactionforemail_AsyncOperations")]
		public IEnumerable<SystemJob> InteractionforemailAsyncOperations
		{
			get { return GetRelatedEntities<SystemJob>("interactionforemail_AsyncOperations", null); }
			set { SetRelatedEntities("interactionforemail_AsyncOperations", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'interactionforemail_BulkOperations'
        /// </summary>
		[RelationshipSchemaName("interactionforemail_BulkOperations")]
		public IEnumerable<QuickCampaign> InteractionforemailBulkOperations
		{
			get { return GetRelatedEntities<QuickCampaign>("interactionforemail_BulkOperations", null); }
			set { SetRelatedEntities("interactionforemail_BulkOperations", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'interactionforemail_CampaignResponses'
        /// </summary>
		[RelationshipSchemaName("interactionforemail_CampaignResponses")]
		public IEnumerable<CampaignResponse> InteractionforemailCampaignResponses
		{
			get { return GetRelatedEntities<CampaignResponse>("interactionforemail_CampaignResponses", null); }
			set { SetRelatedEntities("interactionforemail_CampaignResponses", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'interactionforemail_IncidentResolutions'
        /// </summary>
		[RelationshipSchemaName("interactionforemail_IncidentResolutions")]
		public IEnumerable<CaseResolution> InteractionforemailIncidentResolutions
		{
			get { return GetRelatedEntities<CaseResolution>("interactionforemail_IncidentResolutions", null); }
			set { SetRelatedEntities("interactionforemail_IncidentResolutions", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'interactionforemail_OpportunityCloses'
        /// </summary>
		[RelationshipSchemaName("interactionforemail_OpportunityCloses")]
		public IEnumerable<OpportunityClose> InteractionforemailOpportunityCloses
		{
			get { return GetRelatedEntities<OpportunityClose>("interactionforemail_OpportunityCloses", null); }
			set { SetRelatedEntities("interactionforemail_OpportunityCloses", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'interactionforemail_OrderCloses'
        /// </summary>
		[RelationshipSchemaName("interactionforemail_OrderCloses")]
		public IEnumerable<OrderClose> InteractionforemailOrderCloses
		{
			get { return GetRelatedEntities<OrderClose>("interactionforemail_OrderCloses", null); }
			set { SetRelatedEntities("interactionforemail_OrderCloses", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'interactionforemail_QuoteCloses'
        /// </summary>
		[RelationshipSchemaName("interactionforemail_QuoteCloses")]
		public IEnumerable<QuoteClose> InteractionforemailQuoteCloses
		{
			get { return GetRelatedEntities<QuoteClose>("interactionforemail_QuoteCloses", null); }
			set { SetRelatedEntities("interactionforemail_QuoteCloses", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'interactionforemail_ServiceAppointments'
        /// </summary>
		[RelationshipSchemaName("interactionforemail_ServiceAppointments")]
		public IEnumerable<ServiceActivity> InteractionforemailServiceAppointments
		{
			get { return GetRelatedEntities<ServiceActivity>("interactionforemail_ServiceAppointments", null); }
			set { SetRelatedEntities("interactionforemail_ServiceAppointments", null, value); }
		}
		#endregion

		#region Actions
		#endregion

		#region OptionSetEnums
		public enum eInteractionType
		{	
		
			[Label("EmailOpen")]
			[Description(@"")]
			EmailOpen = 0, 
		
			[Label("LinkOpen")]
			[Description(@"")]
			LinkOpen = 1, 
		
			[Label("AttachmentOpen")]
			[Description(@"")]
			AttachmentOpen = 2, 
		
			[Label("EmailReply")]
			[Description(@"")]
			EmailReply = 3, 
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

			/// <summary>emailactivityid</summary>
			public const string EmailActivityId = "emailactivityid";

			/// <summary>emailaddress</summary>
			public const string EmailInteractionComponentRelatedText = "emailaddress";

			/// <summary>emailinteractionreplyid</summary>
			public const string EmailActivityId2 = "emailinteractionreplyid";

			/// <summary>emailinteractiontime</summary>
			public const string InteractionDateAndTimeOfTheAnEmail = "emailinteractiontime";

			/// <summary>exchangerate</summary>
			public const string ExchangeRate = "exchangerate";

			/// <summary>importsequencenumber</summary>
			public const string ImportSequenceNumber = "importsequencenumber";

			/// <summary>interactedcomponenttext</summary>
			public const string EmailInteractionComponentRelatedText2 = "interactedcomponenttext";

			/// <summary>interactionforemailid</summary>
			public const string InteractionForEmailId = "interactionforemailid";

			/// <summary>interactionlocation</summary>
			public const string LocationForAnInteraction = "interactionlocation";

			/// <summary>interactionpartyid</summary>
			public const string InteractionPartyId = "interactionpartyid";

			/// <summary>interactionpartytypecode</summary>
			public const string InteractionPartyTypeCode = "interactionpartytypecode";

			/// <summary>interactionrepliedby</summary>
			public const string NameWhoRepliedToEmailIfInteractionIsReply = "interactionrepliedby";

			/// <summary>interactionreplyid</summary>
			public const string InteractionReplyId = "interactionreplyid";

			/// <summary>interactiontype</summary>
			public const string InteractionType = "interactiontype";

			/// <summary>interactionuseragent</summary>
			public const string UserAgentForAnInteraction = "interactionuseragent";

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

			/// <summary>utcconversiontimezonecode</summary>
			public const string UTCConversionTimeZoneCode = "utcconversiontimezonecode";

			/// <summary>versionnumber</summary>
			public const string Versionnumber = "versionnumber";

		}
		#endregion

		#region Schemas
		public static class Schemas 
		{
			/// <summary>1:N interactionforemail_ActivityPointers</summary>
			public const string InteractionforemailActivityPointers = "interactionforemail_ActivityPointers";

			/// <summary>1:N interactionforemail_AsyncOperations</summary>
			public const string InteractionforemailAsyncOperations = "interactionforemail_AsyncOperations";

			/// <summary>1:N interactionforemail_BulkOperations</summary>
			public const string InteractionforemailBulkOperations = "interactionforemail_BulkOperations";

			/// <summary>1:N interactionforemail_CampaignResponses</summary>
			public const string InteractionforemailCampaignResponses = "interactionforemail_CampaignResponses";

			/// <summary>1:N interactionforemail_IncidentResolutions</summary>
			public const string InteractionforemailIncidentResolutions = "interactionforemail_IncidentResolutions";

			/// <summary>1:N interactionforemail_OpportunityCloses</summary>
			public const string InteractionforemailOpportunityCloses = "interactionforemail_OpportunityCloses";

			/// <summary>1:N interactionforemail_OrderCloses</summary>
			public const string InteractionforemailOrderCloses = "interactionforemail_OrderCloses";

			/// <summary>1:N interactionforemail_QuoteCloses</summary>
			public const string InteractionforemailQuoteCloses = "interactionforemail_QuoteCloses";

			/// <summary>1:N interactionforemail_ServiceAppointments</summary>
			public const string InteractionforemailServiceAppointments = "interactionforemail_ServiceAppointments";

		}
		#endregion
	}
}

