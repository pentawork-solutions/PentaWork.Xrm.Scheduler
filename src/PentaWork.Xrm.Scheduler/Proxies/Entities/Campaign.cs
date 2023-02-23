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
	[EntityLogicalName("campaign")]
	public sealed class Campaign : Entity
	{	
		public static readonly int? EntityTypeCode = 4400;
		public new const string LogicalName = "campaign";
		public const string PrimaryIdAttribute = "campaignid";
		public const string PrimaryNameAttribute = "name";
	
		public Campaign() : base("campaign") { }

		#region Attributes
		/// <summary>
        /// actualend
        /// </summary>
		[DisplayName("Actual End Date")]
		[AttributeLogicalName("actualend")]
		public DateTime? ActualEndDate
		{	
			get { return GetAttributeValue<DateTime?>("actualend"); }
			set
			{ 
				if(value == ActualEndDate) return;
				SetAttributeValue("actualend", value);
			}
		}	
			
		/// <summary>
        /// actualstart
        /// </summary>
		[DisplayName("Actual Start Date")]
		[AttributeLogicalName("actualstart")]
		public DateTime? ActualStartDate
		{	
			get { return GetAttributeValue<DateTime?>("actualstart"); }
			set
			{ 
				if(value == ActualStartDate) return;
				SetAttributeValue("actualstart", value);
			}
		}	
			
		/// <summary>
        /// budgetedcost
		///
		/// Precision: 2
		/// MaxValue: 1000000000000
		/// MinValue: 0
        /// </summary>
		[DisplayName("Budget Allocated")]
		[AttributeLogicalName("budgetedcost")]
		public decimal? BudgetAllocated
		{	
			get { return GetAttributeValue<Money>("budgetedcost")?.Value; }
			set 
			{
				Money moneyValue = null;
				if(value != null) 
				{
					var roundedValue = Decimal.Round(value.Value, 2);
					moneyValue = new Money(roundedValue);
				}

				if(moneyValue.Value == BudgetAllocated) return;
				SetAttributeValue("budgetedcost", moneyValue);  
			}
		}

		/// <summary>
        /// campaignid
        /// </summary>
		[DisplayName("Campaign")]
		[AttributeLogicalName("campaignid")]
		public override Guid Id
		{
			get => base.Id;
			set { base.Id = value; SetAttributeValue("campaignid", value); }
		}

							/// <summary>
        /// codename
        /// </summary>
		[DisplayName("Campaign Code")]
		[AttributeLogicalName("codename")]
		public string CampaignCode
		{	
			get { return GetAttributeValue<string>("codename"); }
			set
			{ 
				if(value == CampaignCode) return;
				SetAttributeValue("codename", value);
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
        /// emailaddress
        /// </summary>
		[DisplayName("Email Address")]
		[AttributeLogicalName("emailaddress")]
		public string EmailAddress
		{	
			get { return GetAttributeValue<string>("emailaddress"); }
			set
			{ 
				if(value == EmailAddress) return;
				SetAttributeValue("emailaddress", value);
			}
		}	
			
		/// <summary>
        /// entityimage_timestamp
        /// </summary>
		[DisplayName("entityimage_timestamp")]
		[AttributeLogicalName("entityimage_timestamp")]
		public int? EntityimageTimestamp
		{	
			get { return GetAttributeValue<int?>("entityimage_timestamp"); }
			set
			{ 
				if(value == EntityimageTimestamp) return;
				SetAttributeValue("entityimage_timestamp", value);
			}
		}	
			
		/// <summary>
        /// entityimage_url
        /// </summary>
		[DisplayName("entityimage_url")]
		[AttributeLogicalName("entityimage_url")]
		public string EntityimageUrl
		{	
			get { return GetAttributeValue<string>("entityimage_url"); }
			set
			{ 
				if(value == EntityimageUrl) return;
				SetAttributeValue("entityimage_url", value);
			}
		}	
			
		/// <summary>
        /// entityimageid
        /// </summary>
		[DisplayName("entityimageid")]
		[AttributeLogicalName("entityimageid")]
		public Guid EntityimageId
		{	
			get { return GetAttributeValue<Guid>("entityimageid"); }
			set
			{ 
				if(value == EntityimageId) return;
				SetAttributeValue("entityimageid", value);
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
        /// expectedresponse
        /// </summary>
		[DisplayName("Expected Response Percentage")]
		[AttributeLogicalName("expectedresponse")]
		public int? ExpectedResponsePercentage
		{	
			get { return GetAttributeValue<int?>("expectedresponse"); }
			set
			{ 
				if(value == ExpectedResponsePercentage) return;
				SetAttributeValue("expectedresponse", value);
			}
		}	
			
		/// <summary>
        /// expectedrevenue
		///
		/// Precision: 2
		/// MaxValue: 1000000000000
		/// MinValue: 0
        /// </summary>
		[DisplayName("Estimated Revenue")]
		[AttributeLogicalName("expectedrevenue")]
		public decimal? EstimatedRevenue
		{	
			get { return GetAttributeValue<Money>("expectedrevenue")?.Value; }
			set 
			{
				Money moneyValue = null;
				if(value != null) 
				{
					var roundedValue = Decimal.Round(value.Value, 2);
					moneyValue = new Money(roundedValue);
				}

				if(moneyValue.Value == EstimatedRevenue) return;
				SetAttributeValue("expectedrevenue", moneyValue);  
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
        /// istemplate
        /// </summary>
		[DisplayName("Template")]
		[AttributeLogicalName("istemplate")]
		public bool? Template
		{	
			get { return GetAttributeValue<bool?>("istemplate"); }
			set
			{ 
				if(value == Template) return;
				SetAttributeValue("istemplate", value);
			}
		}	
			
		/// <summary>
        /// message
        /// </summary>
		[DisplayName("Message")]
		[AttributeLogicalName("message")]
		public string Message
		{	
			get { return GetAttributeValue<string>("message"); }
			set
			{ 
				if(value == Message) return;
				SetAttributeValue("message", value);
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
        /// objective
        /// </summary>
		[DisplayName("Offer")]
		[AttributeLogicalName("objective")]
		public string Offer
		{	
			get { return GetAttributeValue<string>("objective"); }
			set
			{ 
				if(value == Offer) return;
				SetAttributeValue("objective", value);
			}
		}	
			
		/// <summary>
        /// othercost
		///
		/// Precision: 2
		/// MaxValue: 1000000000000
		/// MinValue: 0
        /// </summary>
		[DisplayName("Miscellaneous Costs")]
		[AttributeLogicalName("othercost")]
		public decimal? MiscellaneousCosts
		{	
			get { return GetAttributeValue<Money>("othercost")?.Value; }
			set 
			{
				Money moneyValue = null;
				if(value != null) 
				{
					var roundedValue = Decimal.Round(value.Value, 2);
					moneyValue = new Money(roundedValue);
				}

				if(moneyValue.Value == MiscellaneousCosts) return;
				SetAttributeValue("othercost", moneyValue);  
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
        /// pricelistid
        /// </summary>
		[DisplayName("Price List")]
		[AttributeLogicalName("pricelistid")]
		public EntityReference PriceList
		{	
			get { return GetAttributeValue<EntityReference>("pricelistid"); }
			set
			{ 
				if(value == PriceList) return;
				SetAttributeValue("pricelistid", value);
			}
		}	
			
		/// <summary>
        /// pricelistname
        /// </summary>
		[DisplayName("pricelistname")]
		[AttributeLogicalName("pricelistname")]
		public string Pricelistname
		{	
			get { return GetAttributeValue<string>("pricelistname"); }
			set
			{ 
				if(value == Pricelistname) return;
				SetAttributeValue("pricelistname", value);
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
        /// promotioncodename
        /// </summary>
		[DisplayName("Promotion Code")]
		[AttributeLogicalName("promotioncodename")]
		public string PromotionCode
		{	
			get { return GetAttributeValue<string>("promotioncodename"); }
			set
			{ 
				if(value == PromotionCode) return;
				SetAttributeValue("promotioncodename", value);
			}
		}	
			
		/// <summary>
        /// proposedend
        /// </summary>
		[DisplayName("Proposed End Date")]
		[AttributeLogicalName("proposedend")]
		public DateTime? ProposedEndDate
		{	
			get { return GetAttributeValue<DateTime?>("proposedend"); }
			set
			{ 
				if(value == ProposedEndDate) return;
				SetAttributeValue("proposedend", value);
			}
		}	
			
		/// <summary>
        /// proposedstart
        /// </summary>
		[DisplayName("Proposed Start Date")]
		[AttributeLogicalName("proposedstart")]
		public DateTime? ProposedStartDate
		{	
			get { return GetAttributeValue<DateTime?>("proposedstart"); }
			set
			{ 
				if(value == ProposedStartDate) return;
				SetAttributeValue("proposedstart", value);
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
        /// tmpregardingobjectid
        /// </summary>
		[DisplayName("TmpRegardingObjectId")]
		[AttributeLogicalName("tmpregardingobjectid")]
		public string TmpRegardingObjectId
		{	
			get { return GetAttributeValue<string>("tmpregardingobjectid"); }
			set
			{ 
				if(value == TmpRegardingObjectId) return;
				SetAttributeValue("tmpregardingobjectid", value);
			}
		}	
			
		/// <summary>
        /// totalactualcost
		///
		/// Precision: 2
		/// MaxValue: 1000000000000
		/// MinValue: 0
        /// </summary>
		[DisplayName("Total Cost of Campaign")]
		[AttributeLogicalName("totalactualcost")]
		public decimal? TotalCostOfCampaign
		{	
			get { return GetAttributeValue<Money>("totalactualcost")?.Value; }
			set 
			{
				Money moneyValue = null;
				if(value != null) 
				{
					var roundedValue = Decimal.Round(value.Value, 2);
					moneyValue = new Money(roundedValue);
				}

				if(moneyValue.Value == TotalCostOfCampaign) return;
				SetAttributeValue("totalactualcost", moneyValue);  
			}
		}

		/// <summary>
        /// totalcampaignactivityactualcost
		///
		/// Precision: 2
		/// MaxValue: 1000000000000
		/// MinValue: 0
        /// </summary>
		[DisplayName("Total Cost of Campaign Activities")]
		[AttributeLogicalName("totalcampaignactivityactualcost")]
		public decimal? TotalCostOfCampaignActivities
		{	
			get { return GetAttributeValue<Money>("totalcampaignactivityactualcost")?.Value; }
			set 
			{
				Money moneyValue = null;
				if(value != null) 
				{
					var roundedValue = Decimal.Round(value.Value, 2);
					moneyValue = new Money(roundedValue);
				}

				if(moneyValue.Value == TotalCostOfCampaignActivities) return;
				SetAttributeValue("totalcampaignactivityactualcost", moneyValue);  
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
        /// typecode
        /// </summary>
		[DisplayName("Campaign Type")]
		[AttributeLogicalName("typecode")]
		public eCampaignType? CampaignType
		{	
			get 
			{ 
				var optionSetValue = GetAttributeValue<OptionSetValue>("typecode");
				if (optionSetValue != null) return (eCampaignType)optionSetValue.Value;
				else return null;
			}
			set 
			{ 
				if(value == CampaignType) return;

				OptionSetValue optionSetValue = null;
				if(value != null) optionSetValue = new OptionSetValue((int)value);
				SetAttributeValue("typecode", optionSetValue); 
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
        /// 1:N Get entities for 'campaign_activity_parties'
        /// </summary>
		[RelationshipSchemaName("campaign_activity_parties")]
		public IEnumerable<ActivityParty> CampaignActivityParties
		{
			get { return GetRelatedEntities<ActivityParty>("campaign_activity_parties", null); }
			set { SetRelatedEntities("campaign_activity_parties", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'Campaign_ActivityPointers'
        /// </summary>
		[RelationshipSchemaName("Campaign_ActivityPointers")]
		public IEnumerable<Activity> CampaignActivityPointers
		{
			get { return GetRelatedEntities<Activity>("Campaign_ActivityPointers", null); }
			set { SetRelatedEntities("Campaign_ActivityPointers", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'Campaign_Annotation'
        /// </summary>
		[RelationshipSchemaName("Campaign_Annotation")]
		public IEnumerable<Note> CampaignAnnotation
		{
			get { return GetRelatedEntities<Note>("Campaign_Annotation", null); }
			set { SetRelatedEntities("Campaign_Annotation", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'Campaign_Appointments'
        /// </summary>
		[RelationshipSchemaName("Campaign_Appointments")]
		public IEnumerable<Appointment> CampaignAppointments
		{
			get { return GetRelatedEntities<Appointment>("Campaign_Appointments", null); }
			set { SetRelatedEntities("Campaign_Appointments", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'Campaign_AsyncOperations'
        /// </summary>
		[RelationshipSchemaName("Campaign_AsyncOperations")]
		public IEnumerable<SystemJob> CampaignAsyncOperations
		{
			get { return GetRelatedEntities<SystemJob>("Campaign_AsyncOperations", null); }
			set { SetRelatedEntities("Campaign_AsyncOperations", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'Campaign_BulkDeleteFailures'
        /// </summary>
		[RelationshipSchemaName("Campaign_BulkDeleteFailures")]
		public IEnumerable<BulkDeleteFailure> CampaignBulkDeleteFailures
		{
			get { return GetRelatedEntities<BulkDeleteFailure>("Campaign_BulkDeleteFailures", null); }
			set { SetRelatedEntities("Campaign_BulkDeleteFailures", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'Campaign_CampaignActivities'
        /// </summary>
		[RelationshipSchemaName("Campaign_CampaignActivities")]
		public IEnumerable<CampaignActivity> CampaignCampaignActivities
		{
			get { return GetRelatedEntities<CampaignActivity>("Campaign_CampaignActivities", null); }
			set { SetRelatedEntities("Campaign_CampaignActivities", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'Campaign_CampaignResponses'
        /// </summary>
		[RelationshipSchemaName("Campaign_CampaignResponses")]
		public IEnumerable<CampaignResponse> CampaignCampaignResponses
		{
			get { return GetRelatedEntities<CampaignResponse>("Campaign_CampaignResponses", null); }
			set { SetRelatedEntities("Campaign_CampaignResponses", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'campaign_connections1'
        /// </summary>
		[RelationshipSchemaName("campaign_connections1")]
		public IEnumerable<Connection> CampaignConnections1
		{
			get { return GetRelatedEntities<Connection>("campaign_connections1", null); }
			set { SetRelatedEntities("campaign_connections1", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'campaign_connections2'
        /// </summary>
		[RelationshipSchemaName("campaign_connections2")]
		public IEnumerable<Connection> CampaignConnections2
		{
			get { return GetRelatedEntities<Connection>("campaign_connections2", null); }
			set { SetRelatedEntities("campaign_connections2", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'Campaign_DuplicateBaseRecord'
        /// </summary>
		[RelationshipSchemaName("Campaign_DuplicateBaseRecord")]
		public IEnumerable<DuplicateRecord> CampaignDuplicateBaseRecord
		{
			get { return GetRelatedEntities<DuplicateRecord>("Campaign_DuplicateBaseRecord", null); }
			set { SetRelatedEntities("Campaign_DuplicateBaseRecord", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'Campaign_DuplicateMatchingRecord'
        /// </summary>
		[RelationshipSchemaName("Campaign_DuplicateMatchingRecord")]
		public IEnumerable<DuplicateRecord> CampaignDuplicateMatchingRecord
		{
			get { return GetRelatedEntities<DuplicateRecord>("Campaign_DuplicateMatchingRecord", null); }
			set { SetRelatedEntities("Campaign_DuplicateMatchingRecord", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'Campaign_Emails'
        /// </summary>
		[RelationshipSchemaName("Campaign_Emails")]
		public IEnumerable<Email> CampaignEmails
		{
			get { return GetRelatedEntities<Email>("Campaign_Emails", null); }
			set { SetRelatedEntities("Campaign_Emails", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'Campaign_Faxes'
        /// </summary>
		[RelationshipSchemaName("Campaign_Faxes")]
		public IEnumerable<Fax> CampaignFaxes
		{
			get { return GetRelatedEntities<Fax>("Campaign_Faxes", null); }
			set { SetRelatedEntities("Campaign_Faxes", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'campaign_IncidentResolutions'
        /// </summary>
		[RelationshipSchemaName("campaign_IncidentResolutions")]
		public IEnumerable<CaseResolution> CampaignIncidentResolutions
		{
			get { return GetRelatedEntities<CaseResolution>("campaign_IncidentResolutions", null); }
			set { SetRelatedEntities("campaign_IncidentResolutions", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'campaign_leads'
        /// </summary>
		[RelationshipSchemaName("campaign_leads")]
		public IEnumerable<Lead> CampaignLeads
		{
			get { return GetRelatedEntities<Lead>("campaign_leads", null); }
			set { SetRelatedEntities("campaign_leads", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'Campaign_Letters'
        /// </summary>
		[RelationshipSchemaName("Campaign_Letters")]
		public IEnumerable<Letter> CampaignLetters
		{
			get { return GetRelatedEntities<Letter>("Campaign_Letters", null); }
			set { SetRelatedEntities("Campaign_Letters", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'Campaign_MailboxTrackingFolder'
        /// </summary>
		[RelationshipSchemaName("Campaign_MailboxTrackingFolder")]
		public IEnumerable<MailboxAutoTrackingFolder> CampaignMailboxTrackingFolder
		{
			get { return GetRelatedEntities<MailboxAutoTrackingFolder>("Campaign_MailboxTrackingFolder", null); }
			set { SetRelatedEntities("Campaign_MailboxTrackingFolder", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'campaign_opportunities'
        /// </summary>
		[RelationshipSchemaName("campaign_opportunities")]
		public IEnumerable<Opportunity> CampaignOpportunities
		{
			get { return GetRelatedEntities<Opportunity>("campaign_opportunities", null); }
			set { SetRelatedEntities("campaign_opportunities", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'campaign_OpportunityCloses'
        /// </summary>
		[RelationshipSchemaName("campaign_OpportunityCloses")]
		public IEnumerable<OpportunityClose> CampaignOpportunityCloses
		{
			get { return GetRelatedEntities<OpportunityClose>("campaign_OpportunityCloses", null); }
			set { SetRelatedEntities("campaign_OpportunityCloses", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'campaign_OrderCloses'
        /// </summary>
		[RelationshipSchemaName("campaign_OrderCloses")]
		public IEnumerable<OrderClose> CampaignOrderCloses
		{
			get { return GetRelatedEntities<OrderClose>("campaign_OrderCloses", null); }
			set { SetRelatedEntities("campaign_OrderCloses", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'campaign_orders'
        /// </summary>
		[RelationshipSchemaName("campaign_orders")]
		public IEnumerable<Order> CampaignOrders
		{
			get { return GetRelatedEntities<Order>("campaign_orders", null); }
			set { SetRelatedEntities("campaign_orders", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'Campaign_Phonecalls'
        /// </summary>
		[RelationshipSchemaName("Campaign_Phonecalls")]
		public IEnumerable<PhoneCall> CampaignPhonecalls
		{
			get { return GetRelatedEntities<PhoneCall>("Campaign_Phonecalls", null); }
			set { SetRelatedEntities("Campaign_Phonecalls", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'campaign_principalobjectattributeaccess'
        /// </summary>
		[RelationshipSchemaName("campaign_principalobjectattributeaccess")]
		public IEnumerable<FieldSharing> CampaignPrincipalobjectattributeaccess
		{
			get { return GetRelatedEntities<FieldSharing>("campaign_principalobjectattributeaccess", null); }
			set { SetRelatedEntities("campaign_principalobjectattributeaccess", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'Campaign_ProcessSessions'
        /// </summary>
		[RelationshipSchemaName("Campaign_ProcessSessions")]
		public IEnumerable<ProcessSession> CampaignProcessSessions
		{
			get { return GetRelatedEntities<ProcessSession>("Campaign_ProcessSessions", null); }
			set { SetRelatedEntities("Campaign_ProcessSessions", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'campaign_QuoteCloses'
        /// </summary>
		[RelationshipSchemaName("campaign_QuoteCloses")]
		public IEnumerable<QuoteClose> CampaignQuoteCloses
		{
			get { return GetRelatedEntities<QuoteClose>("campaign_QuoteCloses", null); }
			set { SetRelatedEntities("campaign_QuoteCloses", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'campaign_quotes'
        /// </summary>
		[RelationshipSchemaName("campaign_quotes")]
		public IEnumerable<Quote> CampaignQuotes
		{
			get { return GetRelatedEntities<Quote>("campaign_quotes", null); }
			set { SetRelatedEntities("campaign_quotes", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'Campaign_RecurringAppointmentMasters'
        /// </summary>
		[RelationshipSchemaName("Campaign_RecurringAppointmentMasters")]
		public IEnumerable<RecurringAppointment> CampaignRecurringAppointmentMasters
		{
			get { return GetRelatedEntities<RecurringAppointment>("Campaign_RecurringAppointmentMasters", null); }
			set { SetRelatedEntities("Campaign_RecurringAppointmentMasters", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'Campaign_ServiceAppointments'
        /// </summary>
		[RelationshipSchemaName("Campaign_ServiceAppointments")]
		public IEnumerable<ServiceActivity> CampaignServiceAppointments
		{
			get { return GetRelatedEntities<ServiceActivity>("Campaign_ServiceAppointments", null); }
			set { SetRelatedEntities("Campaign_ServiceAppointments", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'campaign_SocialActivities'
        /// </summary>
		[RelationshipSchemaName("campaign_SocialActivities")]
		public IEnumerable<SocialActivity> CampaignSocialActivities
		{
			get { return GetRelatedEntities<SocialActivity>("campaign_SocialActivities", null); }
			set { SetRelatedEntities("campaign_SocialActivities", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'Campaign_SyncErrors'
        /// </summary>
		[RelationshipSchemaName("Campaign_SyncErrors")]
		public IEnumerable<SyncError> CampaignSyncErrors
		{
			get { return GetRelatedEntities<SyncError>("Campaign_SyncErrors", null); }
			set { SetRelatedEntities("Campaign_SyncErrors", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'Campaign_Tasks'
        /// </summary>
		[RelationshipSchemaName("Campaign_Tasks")]
		public IEnumerable<Task> CampaignTasks
		{
			get { return GetRelatedEntities<Task>("Campaign_Tasks", null); }
			set { SetRelatedEntities("Campaign_Tasks", null, value); }
		}
		/// <summary>
        /// N:N Get entities for 'Campaign'
        /// </summary>
		[RelationshipSchemaName("campaigncampaign_association")]
		public IEnumerable<Campaign> CampaigncampaignAssociation
		{
			get { return GetRelatedEntities<Campaign>("campaigncampaign_association", null); }
			set { SetRelatedEntities("campaigncampaign_association", null, value); }
		}
		/// <summary>
        /// N:N Get entities for 'MarketingList'
        /// </summary>
		[RelationshipSchemaName("campaignlist_association")]
		public IEnumerable<MarketingList> CampaignlistAssociation
		{
			get { return GetRelatedEntities<MarketingList>("campaignlist_association", null); }
			set { SetRelatedEntities("campaignlist_association", null, value); }
		}
		/// <summary>
        /// N:N Get entities for 'Product'
        /// </summary>
		[RelationshipSchemaName("campaignproduct_association")]
		public IEnumerable<Product> CampaignproductAssociation
		{
			get { return GetRelatedEntities<Product>("campaignproduct_association", null); }
			set { SetRelatedEntities("campaignproduct_association", null, value); }
		}
		/// <summary>
        /// N:N Get entities for 'SalesLiterature'
        /// </summary>
		[RelationshipSchemaName("campaignsalesliterature_association")]
		public IEnumerable<SalesLiterature> CampaignsalesliteratureAssociation
		{
			get { return GetRelatedEntities<SalesLiterature>("campaignsalesliterature_association", null); }
			set { SetRelatedEntities("campaignsalesliterature_association", null, value); }
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
		
			[Label("Proposed")]
			[Description(@"")]
			Proposed_Active = 0, 
		
			[Label("Ready To Launch")]
			[Description(@"")]
			ReadyToLaunch_Active = 1, 
		
			[Label("Launched")]
			[Description(@"")]
			Launched_Active = 2, 
		
			[Label("Completed")]
			[Description(@"")]
			Completed_Active = 3, 
		
			[Label("Canceled")]
			[Description(@"")]
			Canceled_Active = 4, 
		
			[Label("Suspended")]
			[Description(@"")]
			Suspended_Active = 5, 
		
			[Label("Inactive")]
			[Description(@"")]
			Inactive_Inactive = 6, 
		}
		
		public enum eCampaignType
		{	
		
			[Label("Advertisement")]
			[Description(@"")]
			Advertisement = 1, 
		
			[Label("Direct Marketing")]
			[Description(@"")]
			DirectMarketing = 2, 
		
			[Label("Event")]
			[Description(@"")]
			Event = 3, 
		
			[Label("Co-branding")]
			[Description(@"")]
			Cobranding = 4, 
		
			[Label("Other")]
			[Description(@"")]
			Other = 5, 
		}
		
		#endregion	

		#region Properties
		public static class Properties 
		{
			/// <summary>actualend</summary>
			public const string ActualEndDate = "actualend";

			/// <summary>actualstart</summary>
			public const string ActualStartDate = "actualstart";

			/// <summary>budgetedcost</summary>
			public const string BudgetAllocated = "budgetedcost";

			/// <summary>campaignid</summary>
			public const string CampaignId = "campaignid";

			/// <summary>codename</summary>
			public const string CampaignCode = "codename";

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

			/// <summary>description</summary>
			public const string Description = "description";

			/// <summary>emailaddress</summary>
			public const string EmailAddress = "emailaddress";

			/// <summary>entityimage_timestamp</summary>
			public const string EntityimageTimestamp = "entityimage_timestamp";

			/// <summary>entityimage_url</summary>
			public const string EntityimageUrl = "entityimage_url";

			/// <summary>entityimageid</summary>
			public const string EntityimageId = "entityimageid";

			/// <summary>exchangerate</summary>
			public const string ExchangeRate = "exchangerate";

			/// <summary>expectedresponse</summary>
			public const string ExpectedResponsePercentage = "expectedresponse";

			/// <summary>expectedrevenue</summary>
			public const string EstimatedRevenue = "expectedrevenue";

			/// <summary>importsequencenumber</summary>
			public const string ImportSequenceNumber = "importsequencenumber";

			/// <summary>istemplate</summary>
			public const string Template = "istemplate";

			/// <summary>message</summary>
			public const string Message = "message";

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

			/// <summary>objective</summary>
			public const string Offer = "objective";

			/// <summary>othercost</summary>
			public const string MiscellaneousCosts = "othercost";

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

			/// <summary>pricelistid</summary>
			public const string PriceList = "pricelistid";

			/// <summary>pricelistname</summary>
			public const string Pricelistname = "pricelistname";

			/// <summary>processid</summary>
			public const string ProcessId = "processid";

			/// <summary>promotioncodename</summary>
			public const string PromotionCode = "promotioncodename";

			/// <summary>proposedend</summary>
			public const string ProposedEndDate = "proposedend";

			/// <summary>proposedstart</summary>
			public const string ProposedStartDate = "proposedstart";

			/// <summary>stageid</summary>
			public const string DeprecatedStageId = "stageid";

			/// <summary>statecode</summary>
			public const string Status = "statecode";

			/// <summary>statuscode</summary>
			public const string StatusReason = "statuscode";

			/// <summary>timezoneruleversionnumber</summary>
			public const string TimeZoneRuleVersionNumber = "timezoneruleversionnumber";

			/// <summary>tmpregardingobjectid</summary>
			public const string TmpRegardingObjectId = "tmpregardingobjectid";

			/// <summary>totalactualcost</summary>
			public const string TotalCostOfCampaign = "totalactualcost";

			/// <summary>totalcampaignactivityactualcost</summary>
			public const string TotalCostOfCampaignActivities = "totalcampaignactivityactualcost";

			/// <summary>transactioncurrencyid</summary>
			public const string Currency = "transactioncurrencyid";

			/// <summary>transactioncurrencyidname</summary>
			public const string Transactioncurrencyidname = "transactioncurrencyidname";

			/// <summary>traversedpath</summary>
			public const string DeprecatedTraversedPath = "traversedpath";

			/// <summary>typecode</summary>
			public const string CampaignType = "typecode";

			/// <summary>utcconversiontimezonecode</summary>
			public const string UTCConversionTimeZoneCode = "utcconversiontimezonecode";

			/// <summary>versionnumber</summary>
			public const string VersionNumber = "versionnumber";

		}
		#endregion

		#region Schemas
		public static class Schemas 
		{
			/// <summary>1:N campaign_activity_parties</summary>
			public const string CampaignActivityParties = "campaign_activity_parties";

			/// <summary>1:N Campaign_ActivityPointers</summary>
			public const string CampaignActivityPointers = "Campaign_ActivityPointers";

			/// <summary>1:N Campaign_Annotation</summary>
			public const string CampaignAnnotation = "Campaign_Annotation";

			/// <summary>1:N Campaign_Appointments</summary>
			public const string CampaignAppointments = "Campaign_Appointments";

			/// <summary>1:N Campaign_AsyncOperations</summary>
			public const string CampaignAsyncOperations = "Campaign_AsyncOperations";

			/// <summary>1:N Campaign_BulkDeleteFailures</summary>
			public const string CampaignBulkDeleteFailures = "Campaign_BulkDeleteFailures";

			/// <summary>1:N Campaign_CampaignActivities</summary>
			public const string CampaignCampaignActivities = "Campaign_CampaignActivities";

			/// <summary>1:N Campaign_CampaignResponses</summary>
			public const string CampaignCampaignResponses = "Campaign_CampaignResponses";

			/// <summary>1:N campaign_connections1</summary>
			public const string CampaignConnections1 = "campaign_connections1";

			/// <summary>1:N campaign_connections2</summary>
			public const string CampaignConnections2 = "campaign_connections2";

			/// <summary>1:N Campaign_DuplicateBaseRecord</summary>
			public const string CampaignDuplicateBaseRecord = "Campaign_DuplicateBaseRecord";

			/// <summary>1:N Campaign_DuplicateMatchingRecord</summary>
			public const string CampaignDuplicateMatchingRecord = "Campaign_DuplicateMatchingRecord";

			/// <summary>1:N Campaign_Emails</summary>
			public const string CampaignEmails = "Campaign_Emails";

			/// <summary>1:N Campaign_Faxes</summary>
			public const string CampaignFaxes = "Campaign_Faxes";

			/// <summary>1:N campaign_IncidentResolutions</summary>
			public const string CampaignIncidentResolutions = "campaign_IncidentResolutions";

			/// <summary>1:N campaign_leads</summary>
			public const string CampaignLeads = "campaign_leads";

			/// <summary>1:N Campaign_Letters</summary>
			public const string CampaignLetters = "Campaign_Letters";

			/// <summary>1:N Campaign_MailboxTrackingFolder</summary>
			public const string CampaignMailboxTrackingFolder = "Campaign_MailboxTrackingFolder";

			/// <summary>1:N campaign_opportunities</summary>
			public const string CampaignOpportunities = "campaign_opportunities";

			/// <summary>1:N campaign_OpportunityCloses</summary>
			public const string CampaignOpportunityCloses = "campaign_OpportunityCloses";

			/// <summary>1:N campaign_OrderCloses</summary>
			public const string CampaignOrderCloses = "campaign_OrderCloses";

			/// <summary>1:N campaign_orders</summary>
			public const string CampaignOrders = "campaign_orders";

			/// <summary>1:N Campaign_Phonecalls</summary>
			public const string CampaignPhonecalls = "Campaign_Phonecalls";

			/// <summary>1:N campaign_principalobjectattributeaccess</summary>
			public const string CampaignPrincipalobjectattributeaccess = "campaign_principalobjectattributeaccess";

			/// <summary>1:N Campaign_ProcessSessions</summary>
			public const string CampaignProcessSessions = "Campaign_ProcessSessions";

			/// <summary>1:N campaign_QuoteCloses</summary>
			public const string CampaignQuoteCloses = "campaign_QuoteCloses";

			/// <summary>1:N campaign_quotes</summary>
			public const string CampaignQuotes = "campaign_quotes";

			/// <summary>1:N Campaign_RecurringAppointmentMasters</summary>
			public const string CampaignRecurringAppointmentMasters = "Campaign_RecurringAppointmentMasters";

			/// <summary>1:N Campaign_ServiceAppointments</summary>
			public const string CampaignServiceAppointments = "Campaign_ServiceAppointments";

			/// <summary>1:N campaign_SocialActivities</summary>
			public const string CampaignSocialActivities = "campaign_SocialActivities";

			/// <summary>1:N Campaign_SyncErrors</summary>
			public const string CampaignSyncErrors = "Campaign_SyncErrors";

			/// <summary>1:N Campaign_Tasks</summary>
			public const string CampaignTasks = "Campaign_Tasks";

			/// <summary>N:N campaigncampaign_association</summary>
			public const string CampaigncampaignAssociation = "campaigncampaign_association";

			/// <summary>N:N campaignlist_association</summary>
			public const string CampaignlistAssociation = "campaignlist_association";

			/// <summary>N:N campaignproduct_association</summary>
			public const string CampaignproductAssociation = "campaignproduct_association";

			/// <summary>N:N campaignsalesliterature_association</summary>
			public const string CampaignsalesliteratureAssociation = "campaignsalesliterature_association";

		}
		#endregion
	}
}

