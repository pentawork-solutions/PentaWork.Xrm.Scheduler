using System;
using System.Linq;
using System.Diagnostics;
using System.ComponentModel;
using Microsoft.Xrm.Sdk; 
using Microsoft.Xrm.Sdk.Client;
using System.Collections.Generic;

namespace PentaWork.Xrm.Scheduler.Proxies.Entities
{
	[DebuggerDisplay("{Topic}")] 	
	[EntityLogicalName("opportunity")]
	public sealed class Opportunity : Entity
	{	
		public static readonly int? EntityTypeCode = 3;
		public new const string LogicalName = "opportunity";
		public const string PrimaryIdAttribute = "opportunityid";
		public const string PrimaryNameAttribute = "name";
	
		public Opportunity() : base("opportunity") { }

		#region Attributes
		/// <summary>
        /// accountid
        /// </summary>
		[DisplayName("Account")]
		[AttributeLogicalName("accountid")]
		public EntityReference Account
		{	
			get { return GetAttributeValue<EntityReference>("accountid"); }
			set
			{ 
				if(value == Account) return;
				SetAttributeValue("accountid", value);
			}
		}	
			
		/// <summary>
        /// accountidname
        /// </summary>
		[DisplayName("accountidname")]
		[AttributeLogicalName("accountidname")]
		public string Accountidname
		{	
			get { return GetAttributeValue<string>("accountidname"); }
			set
			{ 
				if(value == Accountidname) return;
				SetAttributeValue("accountidname", value);
			}
		}	
			
		/// <summary>
        /// accountidyominame
        /// </summary>
		[DisplayName("accountidyominame")]
		[AttributeLogicalName("accountidyominame")]
		public string Accountidyominame
		{	
			get { return GetAttributeValue<string>("accountidyominame"); }
			set
			{ 
				if(value == Accountidyominame) return;
				SetAttributeValue("accountidyominame", value);
			}
		}	
			
		/// <summary>
        /// actualclosedate
        /// </summary>
		[DisplayName("Actual Close Date")]
		[AttributeLogicalName("actualclosedate")]
		public DateTime? ActualCloseDate
		{	
			get { return GetAttributeValue<DateTime?>("actualclosedate"); }
			set
			{ 
				if(value == ActualCloseDate) return;
				SetAttributeValue("actualclosedate", value);
			}
		}	
			
		/// <summary>
        /// actualvalue
		///
		/// Precision: 2
		/// MaxValue: 1000000000000
		/// MinValue: -1000000000000
        /// </summary>
		[DisplayName("Actual Revenue")]
		[AttributeLogicalName("actualvalue")]
		public decimal? ActualRevenue
		{	
			get { return GetAttributeValue<Money>("actualvalue")?.Value; }
			set 
			{
				Money moneyValue = null;
				if(value != null) 
				{
					var roundedValue = Decimal.Round(value.Value, 2);
					moneyValue = new Money(roundedValue);
				}

				if(moneyValue.Value == ActualRevenue) return;
				SetAttributeValue("actualvalue", moneyValue);  
			}
		}

		/// <summary>
        /// budgetamount
		///
		/// Precision: 2
		/// MaxValue: 1000000000000
		/// MinValue: 0
        /// </summary>
		[DisplayName("Budget Amount")]
		[AttributeLogicalName("budgetamount")]
		public decimal? BudgetAmount
		{	
			get { return GetAttributeValue<Money>("budgetamount")?.Value; }
			set 
			{
				Money moneyValue = null;
				if(value != null) 
				{
					var roundedValue = Decimal.Round(value.Value, 2);
					moneyValue = new Money(roundedValue);
				}

				if(moneyValue.Value == BudgetAmount) return;
				SetAttributeValue("budgetamount", moneyValue);  
			}
		}

		/// <summary>
        /// budgetstatus
        /// </summary>
		[DisplayName("Budget")]
		[AttributeLogicalName("budgetstatus")]
		public egBudget? Budget
		{	
			get 
			{ 
				var optionSetValue = GetAttributeValue<OptionSetValue>("budgetstatus");
				if (optionSetValue != null) return (egBudget)optionSetValue.Value;
				else return null;
			}
			set 
			{ 
				if(value == Budget) return;

				OptionSetValue optionSetValue = null;
				if(value != null) optionSetValue = new OptionSetValue((int)value);
				SetAttributeValue("budgetstatus", optionSetValue); 
			}
		}

		/// <summary>
        /// campaignid
        /// </summary>
		[DisplayName("Source Campaign")]
		[AttributeLogicalName("campaignid")]
		public EntityReference SourceCampaign
		{	
			get { return GetAttributeValue<EntityReference>("campaignid"); }
			set
			{ 
				if(value == SourceCampaign) return;
				SetAttributeValue("campaignid", value);
			}
		}	
			
		/// <summary>
        /// campaignidname
        /// </summary>
		[DisplayName("campaignidname")]
		[AttributeLogicalName("campaignidname")]
		public string Campaignidname
		{	
			get { return GetAttributeValue<string>("campaignidname"); }
			set
			{ 
				if(value == Campaignidname) return;
				SetAttributeValue("campaignidname", value);
			}
		}	
			
		/// <summary>
        /// captureproposalfeedback
        /// </summary>
		[DisplayName("Proposal Feedback Captured")]
		[AttributeLogicalName("captureproposalfeedback")]
		public bool? ProposalFeedbackCaptured
		{	
			get { return GetAttributeValue<bool?>("captureproposalfeedback"); }
			set
			{ 
				if(value == ProposalFeedbackCaptured) return;
				SetAttributeValue("captureproposalfeedback", value);
			}
		}	
			
		/// <summary>
        /// closeprobability
        /// </summary>
		[DisplayName("Probability")]
		[AttributeLogicalName("closeprobability")]
		public int? Probability
		{	
			get { return GetAttributeValue<int?>("closeprobability"); }
			set
			{ 
				if(value == Probability) return;
				SetAttributeValue("closeprobability", value);
			}
		}	
			
		/// <summary>
        /// completefinalproposal
        /// </summary>
		[DisplayName("Final Proposal Ready")]
		[AttributeLogicalName("completefinalproposal")]
		public bool? FinalProposalReady
		{	
			get { return GetAttributeValue<bool?>("completefinalproposal"); }
			set
			{ 
				if(value == FinalProposalReady) return;
				SetAttributeValue("completefinalproposal", value);
			}
		}	
			
		/// <summary>
        /// completeinternalreview
        /// </summary>
		[DisplayName("Complete Internal Review")]
		[AttributeLogicalName("completeinternalreview")]
		public bool? CompleteInternalReview
		{	
			get { return GetAttributeValue<bool?>("completeinternalreview"); }
			set
			{ 
				if(value == CompleteInternalReview) return;
				SetAttributeValue("completeinternalreview", value);
			}
		}	
			
		/// <summary>
        /// confirminterest
        /// </summary>
		[DisplayName("Confirm Interest")]
		[AttributeLogicalName("confirminterest")]
		public bool? ConfirmInterest
		{	
			get { return GetAttributeValue<bool?>("confirminterest"); }
			set
			{ 
				if(value == ConfirmInterest) return;
				SetAttributeValue("confirminterest", value);
			}
		}	
			
		/// <summary>
        /// contactid
        /// </summary>
		[DisplayName("Contact")]
		[AttributeLogicalName("contactid")]
		public EntityReference Contact
		{	
			get { return GetAttributeValue<EntityReference>("contactid"); }
			set
			{ 
				if(value == Contact) return;
				SetAttributeValue("contactid", value);
			}
		}	
			
		/// <summary>
        /// contactidname
        /// </summary>
		[DisplayName("contactidname")]
		[AttributeLogicalName("contactidname")]
		public string Contactidname
		{	
			get { return GetAttributeValue<string>("contactidname"); }
			set
			{ 
				if(value == Contactidname) return;
				SetAttributeValue("contactidname", value);
			}
		}	
			
		/// <summary>
        /// contactidyominame
        /// </summary>
		[DisplayName("contactidyominame")]
		[AttributeLogicalName("contactidyominame")]
		public string Contactidyominame
		{	
			get { return GetAttributeValue<string>("contactidyominame"); }
			set
			{ 
				if(value == Contactidyominame) return;
				SetAttributeValue("contactidyominame", value);
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
        /// currentsituation
        /// </summary>
		[DisplayName("Current Situation")]
		[AttributeLogicalName("currentsituation")]
		public string CurrentSituation
		{	
			get { return GetAttributeValue<string>("currentsituation"); }
			set
			{ 
				if(value == CurrentSituation) return;
				SetAttributeValue("currentsituation", value);
			}
		}	
			
		/// <summary>
        /// customerid
        /// </summary>
		[DisplayName("Potential Customer")]
		[AttributeLogicalName("customerid")]
		public EntityReference PotentialCustomer
		{	
			get { return GetAttributeValue<EntityReference>("customerid"); }
			set
			{ 
				if(value == PotentialCustomer) return;
				SetAttributeValue("customerid", value);
			}
		}	
			
		/// <summary>
        /// customeridname
        /// </summary>
		[DisplayName("customeridname")]
		[AttributeLogicalName("customeridname")]
		public string Customeridname
		{	
			get { return GetAttributeValue<string>("customeridname"); }
			set
			{ 
				if(value == Customeridname) return;
				SetAttributeValue("customeridname", value);
			}
		}	
			
		/// <summary>
        /// customeridtype
        /// </summary>
		[DisplayName("Potential Customer Type")]
		[AttributeLogicalName("customeridtype")]
		public string PotentialCustomerType
		{	
			get { return GetAttributeValue<string>("customeridtype"); }
			set
			{ 
				if(value == PotentialCustomerType) return;
				SetAttributeValue("customeridtype", value);
			}
		}	
			
		/// <summary>
        /// customeridyominame
        /// </summary>
		[DisplayName("customeridyominame")]
		[AttributeLogicalName("customeridyominame")]
		public string Customeridyominame
		{	
			get { return GetAttributeValue<string>("customeridyominame"); }
			set
			{ 
				if(value == Customeridyominame) return;
				SetAttributeValue("customeridyominame", value);
			}
		}	
			
		/// <summary>
        /// customerneed
        /// </summary>
		[DisplayName("Customer Need")]
		[AttributeLogicalName("customerneed")]
		public string CustomerNeed
		{	
			get { return GetAttributeValue<string>("customerneed"); }
			set
			{ 
				if(value == CustomerNeed) return;
				SetAttributeValue("customerneed", value);
			}
		}	
			
		/// <summary>
        /// customerpainpoints
        /// </summary>
		[DisplayName("Customer Pain Points")]
		[AttributeLogicalName("customerpainpoints")]
		public string CustomerPainPoints
		{	
			get { return GetAttributeValue<string>("customerpainpoints"); }
			set
			{ 
				if(value == CustomerPainPoints) return;
				SetAttributeValue("customerpainpoints", value);
			}
		}	
			
		/// <summary>
        /// decisionmaker
        /// </summary>
		[DisplayName("Decision Maker?")]
		[AttributeLogicalName("decisionmaker")]
		public bool? DecisionMaker
		{	
			get { return GetAttributeValue<bool?>("decisionmaker"); }
			set
			{ 
				if(value == DecisionMaker) return;
				SetAttributeValue("decisionmaker", value);
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
        /// developproposal
        /// </summary>
		[DisplayName("Develop Proposal")]
		[AttributeLogicalName("developproposal")]
		public bool? DevelopProposal
		{	
			get { return GetAttributeValue<bool?>("developproposal"); }
			set
			{ 
				if(value == DevelopProposal) return;
				SetAttributeValue("developproposal", value);
			}
		}	
			
		/// <summary>
        /// discountamount
		///
		/// Precision: 2
		/// MaxValue: 1000000000000
		/// MinValue: 0
        /// </summary>
		[DisplayName("Opportunity Discount Amount")]
		[AttributeLogicalName("discountamount")]
		public decimal? OpportunityDiscountAmount
		{	
			get { return GetAttributeValue<Money>("discountamount")?.Value; }
			set 
			{
				Money moneyValue = null;
				if(value != null) 
				{
					var roundedValue = Decimal.Round(value.Value, 2);
					moneyValue = new Money(roundedValue);
				}

				if(moneyValue.Value == OpportunityDiscountAmount) return;
				SetAttributeValue("discountamount", moneyValue);  
			}
		}

		/// <summary>
        /// discountpercentage
		///
		/// Precision: 2
		/// MaxValue: 100
		/// MinValue: 0
        /// </summary>
		[DisplayName("Opportunity Discount (%)")]
		[AttributeLogicalName("discountpercentage")]
		public decimal? OpportunityDiscount
		{	
			get { return GetAttributeValue<decimal?>("discountpercentage"); }
			set 
			{
				decimal? decimalValue = null;
				if(value != null) decimalValue = Decimal.Round(value.Value, 2);
				if(decimalValue == OpportunityDiscount) return;
				SetAttributeValue("discountpercentage", decimalValue);  
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
        /// estimatedclosedate
        /// </summary>
		[DisplayName("Est. Close Date")]
		[AttributeLogicalName("estimatedclosedate")]
		public DateTime? EstCloseDate
		{	
			get { return GetAttributeValue<DateTime?>("estimatedclosedate"); }
			set
			{ 
				if(value == EstCloseDate) return;
				SetAttributeValue("estimatedclosedate", value);
			}
		}	
			
		/// <summary>
        /// estimatedvalue
		///
		/// Precision: 2
		/// MaxValue: 1000000000000
		/// MinValue: -1000000000000
        /// </summary>
		[DisplayName("Est. Revenue")]
		[AttributeLogicalName("estimatedvalue")]
		public decimal? EstRevenue
		{	
			get { return GetAttributeValue<Money>("estimatedvalue")?.Value; }
			set 
			{
				Money moneyValue = null;
				if(value != null) 
				{
					var roundedValue = Decimal.Round(value.Value, 2);
					moneyValue = new Money(roundedValue);
				}

				if(moneyValue.Value == EstRevenue) return;
				SetAttributeValue("estimatedvalue", moneyValue);  
			}
		}

		/// <summary>
        /// evaluatefit
        /// </summary>
		[DisplayName("Evaluate Fit")]
		[AttributeLogicalName("evaluatefit")]
		public bool? EvaluateFit
		{	
			get { return GetAttributeValue<bool?>("evaluatefit"); }
			set
			{ 
				if(value == EvaluateFit) return;
				SetAttributeValue("evaluatefit", value);
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
        /// filedebrief
        /// </summary>
		[DisplayName("File Debrief")]
		[AttributeLogicalName("filedebrief")]
		public bool? FileDebrief
		{	
			get { return GetAttributeValue<bool?>("filedebrief"); }
			set
			{ 
				if(value == FileDebrief) return;
				SetAttributeValue("filedebrief", value);
			}
		}	
			
		/// <summary>
        /// finaldecisiondate
        /// </summary>
		[DisplayName("Final Decision Date")]
		[AttributeLogicalName("finaldecisiondate")]
		public DateTime? FinalDecisionDate
		{	
			get { return GetAttributeValue<DateTime?>("finaldecisiondate"); }
			set
			{ 
				if(value == FinalDecisionDate) return;
				SetAttributeValue("finaldecisiondate", value);
			}
		}	
			
		/// <summary>
        /// freightamount
		///
		/// Precision: 2
		/// MaxValue: 1000000000000
		/// MinValue: 0
        /// </summary>
		[DisplayName("Freight Amount")]
		[AttributeLogicalName("freightamount")]
		public decimal? FreightAmount
		{	
			get { return GetAttributeValue<Money>("freightamount")?.Value; }
			set 
			{
				Money moneyValue = null;
				if(value != null) 
				{
					var roundedValue = Decimal.Round(value.Value, 2);
					moneyValue = new Money(roundedValue);
				}

				if(moneyValue.Value == FreightAmount) return;
				SetAttributeValue("freightamount", moneyValue);  
			}
		}

		/// <summary>
        /// identifycompetitors
        /// </summary>
		[DisplayName("Identify Competitors")]
		[AttributeLogicalName("identifycompetitors")]
		public bool? IdentifyCompetitors
		{	
			get { return GetAttributeValue<bool?>("identifycompetitors"); }
			set
			{ 
				if(value == IdentifyCompetitors) return;
				SetAttributeValue("identifycompetitors", value);
			}
		}	
			
		/// <summary>
        /// identifycustomercontacts
        /// </summary>
		[DisplayName("Identify Customer Contacts")]
		[AttributeLogicalName("identifycustomercontacts")]
		public bool? IdentifyCustomerContacts
		{	
			get { return GetAttributeValue<bool?>("identifycustomercontacts"); }
			set
			{ 
				if(value == IdentifyCustomerContacts) return;
				SetAttributeValue("identifycustomercontacts", value);
			}
		}	
			
		/// <summary>
        /// identifypursuitteam
        /// </summary>
		[DisplayName("Identify Sales Team")]
		[AttributeLogicalName("identifypursuitteam")]
		public bool? IdentifySalesTeam
		{	
			get { return GetAttributeValue<bool?>("identifypursuitteam"); }
			set
			{ 
				if(value == IdentifySalesTeam) return;
				SetAttributeValue("identifypursuitteam", value);
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
        /// initialcommunication
        /// </summary>
		[DisplayName("Initial Communication")]
		[AttributeLogicalName("initialcommunication")]
		public egInitialCommunication? InitialCommunication
		{	
			get 
			{ 
				var optionSetValue = GetAttributeValue<OptionSetValue>("initialcommunication");
				if (optionSetValue != null) return (egInitialCommunication)optionSetValue.Value;
				else return null;
			}
			set 
			{ 
				if(value == InitialCommunication) return;

				OptionSetValue optionSetValue = null;
				if(value != null) optionSetValue = new OptionSetValue((int)value);
				SetAttributeValue("initialcommunication", optionSetValue); 
			}
		}

		/// <summary>
        /// isprivate
        /// </summary>
		[DisplayName("Is Private")]
		[AttributeLogicalName("isprivate")]
		public bool? IsPrivate
		{	
			get { return GetAttributeValue<bool?>("isprivate"); }
			set
			{ 
				if(value == IsPrivate) return;
				SetAttributeValue("isprivate", value);
			}
		}	
			
		/// <summary>
        /// isrevenuesystemcalculated
        /// </summary>
		[DisplayName("Revenue")]
		[AttributeLogicalName("isrevenuesystemcalculated")]
		public bool? Revenue
		{	
			get { return GetAttributeValue<bool?>("isrevenuesystemcalculated"); }
			set
			{ 
				if(value == Revenue) return;
				SetAttributeValue("isrevenuesystemcalculated", value);
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
		[DisplayName("Topic")]
		[AttributeLogicalName("name")]
		public string Topic
		{	
			get { return GetAttributeValue<string>("name"); }
			set
			{ 
				if(value == Topic) return;
				SetAttributeValue("name", value);
			}
		}	
			
		/// <summary>
        /// need
        /// </summary>
		[DisplayName("Need")]
		[AttributeLogicalName("need")]
		public egNeed? Need
		{	
			get 
			{ 
				var optionSetValue = GetAttributeValue<OptionSetValue>("need");
				if (optionSetValue != null) return (egNeed)optionSetValue.Value;
				else return null;
			}
			set 
			{ 
				if(value == Need) return;

				OptionSetValue optionSetValue = null;
				if(value != null) optionSetValue = new OptionSetValue((int)value);
				SetAttributeValue("need", optionSetValue); 
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
        /// opportunityid
        /// </summary>
		[DisplayName("Opportunity")]
		[AttributeLogicalName("opportunityid")]
		public override Guid Id
		{
			get => base.Id;
			set { base.Id = value; SetAttributeValue("opportunityid", value); }
		}

							/// <summary>
        /// opportunityratingcode
        /// </summary>
		[DisplayName("Rating")]
		[AttributeLogicalName("opportunityratingcode")]
		public eRating? Rating
		{	
			get 
			{ 
				var optionSetValue = GetAttributeValue<OptionSetValue>("opportunityratingcode");
				if (optionSetValue != null) return (eRating)optionSetValue.Value;
				else return null;
			}
			set 
			{ 
				if(value == Rating) return;

				OptionSetValue optionSetValue = null;
				if(value != null) optionSetValue = new OptionSetValue((int)value);
				SetAttributeValue("opportunityratingcode", optionSetValue); 
			}
		}

		/// <summary>
        /// originatingleadid
        /// </summary>
		[DisplayName("Originating Lead")]
		[AttributeLogicalName("originatingleadid")]
		public EntityReference OriginatingLead
		{	
			get { return GetAttributeValue<EntityReference>("originatingleadid"); }
			set
			{ 
				if(value == OriginatingLead) return;
				SetAttributeValue("originatingleadid", value);
			}
		}	
			
		/// <summary>
        /// originatingleadidname
        /// </summary>
		[DisplayName("originatingleadidname")]
		[AttributeLogicalName("originatingleadidname")]
		public string Originatingleadidname
		{	
			get { return GetAttributeValue<string>("originatingleadidname"); }
			set
			{ 
				if(value == Originatingleadidname) return;
				SetAttributeValue("originatingleadidname", value);
			}
		}	
			
		/// <summary>
        /// originatingleadidyominame
        /// </summary>
		[DisplayName("originatingleadidyominame")]
		[AttributeLogicalName("originatingleadidyominame")]
		public string Originatingleadidyominame
		{	
			get { return GetAttributeValue<string>("originatingleadidyominame"); }
			set
			{ 
				if(value == Originatingleadidyominame) return;
				SetAttributeValue("originatingleadidyominame", value);
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
        /// parentaccountid
        /// </summary>
		[DisplayName("Account")]
		[AttributeLogicalName("parentaccountid")]
		public EntityReference Account2
		{	
			get { return GetAttributeValue<EntityReference>("parentaccountid"); }
			set
			{ 
				if(value == Account2) return;
				SetAttributeValue("parentaccountid", value);
			}
		}	
			
		/// <summary>
        /// parentaccountidname
        /// </summary>
		[DisplayName("parentaccountidname")]
		[AttributeLogicalName("parentaccountidname")]
		public string Parentaccountidname
		{	
			get { return GetAttributeValue<string>("parentaccountidname"); }
			set
			{ 
				if(value == Parentaccountidname) return;
				SetAttributeValue("parentaccountidname", value);
			}
		}	
			
		/// <summary>
        /// parentaccountidyominame
        /// </summary>
		[DisplayName("parentaccountidyominame")]
		[AttributeLogicalName("parentaccountidyominame")]
		public string Parentaccountidyominame
		{	
			get { return GetAttributeValue<string>("parentaccountidyominame"); }
			set
			{ 
				if(value == Parentaccountidyominame) return;
				SetAttributeValue("parentaccountidyominame", value);
			}
		}	
			
		/// <summary>
        /// parentcontactid
        /// </summary>
		[DisplayName("Contact")]
		[AttributeLogicalName("parentcontactid")]
		public EntityReference Contact2
		{	
			get { return GetAttributeValue<EntityReference>("parentcontactid"); }
			set
			{ 
				if(value == Contact2) return;
				SetAttributeValue("parentcontactid", value);
			}
		}	
			
		/// <summary>
        /// parentcontactidname
        /// </summary>
		[DisplayName("parentcontactidname")]
		[AttributeLogicalName("parentcontactidname")]
		public string Parentcontactidname
		{	
			get { return GetAttributeValue<string>("parentcontactidname"); }
			set
			{ 
				if(value == Parentcontactidname) return;
				SetAttributeValue("parentcontactidname", value);
			}
		}	
			
		/// <summary>
        /// parentcontactidyominame
        /// </summary>
		[DisplayName("parentcontactidyominame")]
		[AttributeLogicalName("parentcontactidyominame")]
		public string Parentcontactidyominame
		{	
			get { return GetAttributeValue<string>("parentcontactidyominame"); }
			set
			{ 
				if(value == Parentcontactidyominame) return;
				SetAttributeValue("parentcontactidyominame", value);
			}
		}	
			
		/// <summary>
        /// participatesinworkflow
        /// </summary>
		[DisplayName("Participates in Workflow")]
		[AttributeLogicalName("participatesinworkflow")]
		public bool? ParticipatesInWorkflow
		{	
			get { return GetAttributeValue<bool?>("participatesinworkflow"); }
			set
			{ 
				if(value == ParticipatesInWorkflow) return;
				SetAttributeValue("participatesinworkflow", value);
			}
		}	
			
		/// <summary>
        /// presentfinalproposal
        /// </summary>
		[DisplayName("Present Final Proposal")]
		[AttributeLogicalName("presentfinalproposal")]
		public bool? PresentFinalProposal
		{	
			get { return GetAttributeValue<bool?>("presentfinalproposal"); }
			set
			{ 
				if(value == PresentFinalProposal) return;
				SetAttributeValue("presentfinalproposal", value);
			}
		}	
			
		/// <summary>
        /// presentproposal
        /// </summary>
		[DisplayName("Presented Proposal")]
		[AttributeLogicalName("presentproposal")]
		public bool? PresentedProposal
		{	
			get { return GetAttributeValue<bool?>("presentproposal"); }
			set
			{ 
				if(value == PresentedProposal) return;
				SetAttributeValue("presentproposal", value);
			}
		}	
			
		/// <summary>
        /// pricelevelid
        /// </summary>
		[DisplayName("Price List")]
		[AttributeLogicalName("pricelevelid")]
		public EntityReference PriceList
		{	
			get { return GetAttributeValue<EntityReference>("pricelevelid"); }
			set
			{ 
				if(value == PriceList) return;
				SetAttributeValue("pricelevelid", value);
			}
		}	
			
		/// <summary>
        /// pricelevelidname
        /// </summary>
		[DisplayName("pricelevelidname")]
		[AttributeLogicalName("pricelevelidname")]
		public string Pricelevelidname
		{	
			get { return GetAttributeValue<string>("pricelevelidname"); }
			set
			{ 
				if(value == Pricelevelidname) return;
				SetAttributeValue("pricelevelidname", value);
			}
		}	
			
		/// <summary>
        /// pricingerrorcode
        /// </summary>
		[DisplayName("Pricing Error")]
		[AttributeLogicalName("pricingerrorcode")]
		public egPricingError? PricingError
		{	
			get 
			{ 
				var optionSetValue = GetAttributeValue<OptionSetValue>("pricingerrorcode");
				if (optionSetValue != null) return (egPricingError)optionSetValue.Value;
				else return null;
			}
			set 
			{ 
				if(value == PricingError) return;

				OptionSetValue optionSetValue = null;
				if(value != null) optionSetValue = new OptionSetValue((int)value);
				SetAttributeValue("pricingerrorcode", optionSetValue); 
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
        /// proposedsolution
        /// </summary>
		[DisplayName("Proposed Solution")]
		[AttributeLogicalName("proposedsolution")]
		public string ProposedSolution
		{	
			get { return GetAttributeValue<string>("proposedsolution"); }
			set
			{ 
				if(value == ProposedSolution) return;
				SetAttributeValue("proposedsolution", value);
			}
		}	
			
		/// <summary>
        /// purchaseprocess
        /// </summary>
		[DisplayName("Purchase Process")]
		[AttributeLogicalName("purchaseprocess")]
		public egPurchaseProcess? PurchaseProcess
		{	
			get 
			{ 
				var optionSetValue = GetAttributeValue<OptionSetValue>("purchaseprocess");
				if (optionSetValue != null) return (egPurchaseProcess)optionSetValue.Value;
				else return null;
			}
			set 
			{ 
				if(value == PurchaseProcess) return;

				OptionSetValue optionSetValue = null;
				if(value != null) optionSetValue = new OptionSetValue((int)value);
				SetAttributeValue("purchaseprocess", optionSetValue); 
			}
		}

		/// <summary>
        /// purchasetimeframe
        /// </summary>
		[DisplayName("Purchase Timeframe")]
		[AttributeLogicalName("purchasetimeframe")]
		public egPurchaseTimeframe? PurchaseTimeframe
		{	
			get 
			{ 
				var optionSetValue = GetAttributeValue<OptionSetValue>("purchasetimeframe");
				if (optionSetValue != null) return (egPurchaseTimeframe)optionSetValue.Value;
				else return null;
			}
			set 
			{ 
				if(value == PurchaseTimeframe) return;

				OptionSetValue optionSetValue = null;
				if(value != null) optionSetValue = new OptionSetValue((int)value);
				SetAttributeValue("purchasetimeframe", optionSetValue); 
			}
		}

		/// <summary>
        /// pursuitdecision
        /// </summary>
		[DisplayName("Decide Go/No-Go")]
		[AttributeLogicalName("pursuitdecision")]
		public bool? DecideGoNoGo
		{	
			get { return GetAttributeValue<bool?>("pursuitdecision"); }
			set
			{ 
				if(value == DecideGoNoGo) return;
				SetAttributeValue("pursuitdecision", value);
			}
		}	
			
		/// <summary>
        /// qualificationcomments
        /// </summary>
		[DisplayName("Qualification Comments")]
		[AttributeLogicalName("qualificationcomments")]
		public string QualificationComments
		{	
			get { return GetAttributeValue<string>("qualificationcomments"); }
			set
			{ 
				if(value == QualificationComments) return;
				SetAttributeValue("qualificationcomments", value);
			}
		}	
			
		/// <summary>
        /// quotecomments
        /// </summary>
		[DisplayName("Quote Comments")]
		[AttributeLogicalName("quotecomments")]
		public string QuoteComments
		{	
			get { return GetAttributeValue<string>("quotecomments"); }
			set
			{ 
				if(value == QuoteComments) return;
				SetAttributeValue("quotecomments", value);
			}
		}	
			
		/// <summary>
        /// resolvefeedback
        /// </summary>
		[DisplayName("Feedback Resolved")]
		[AttributeLogicalName("resolvefeedback")]
		public bool? FeedbackResolved
		{	
			get { return GetAttributeValue<bool?>("resolvefeedback"); }
			set
			{ 
				if(value == FeedbackResolved) return;
				SetAttributeValue("resolvefeedback", value);
			}
		}	
			
		/// <summary>
        /// salesstage
        /// </summary>
		[DisplayName("Sales Stage")]
		[AttributeLogicalName("salesstage")]
		public egOpportunitySalesstage? SalesStage
		{	
			get 
			{ 
				var optionSetValue = GetAttributeValue<OptionSetValue>("salesstage");
				if (optionSetValue != null) return (egOpportunitySalesstage)optionSetValue.Value;
				else return null;
			}
			set 
			{ 
				if(value == SalesStage) return;

				OptionSetValue optionSetValue = null;
				if(value != null) optionSetValue = new OptionSetValue((int)value);
				SetAttributeValue("salesstage", optionSetValue); 
			}
		}

		/// <summary>
        /// salesstagecode
        /// </summary>
		[DisplayName("Process Code")]
		[AttributeLogicalName("salesstagecode")]
		public eProcessCode? ProcessCode
		{	
			get 
			{ 
				var optionSetValue = GetAttributeValue<OptionSetValue>("salesstagecode");
				if (optionSetValue != null) return (eProcessCode)optionSetValue.Value;
				else return null;
			}
			set 
			{ 
				if(value == ProcessCode) return;

				OptionSetValue optionSetValue = null;
				if(value != null) optionSetValue = new OptionSetValue((int)value);
				SetAttributeValue("salesstagecode", optionSetValue); 
			}
		}

		/// <summary>
        /// schedulefollowup_prospect
        /// </summary>
		[DisplayName("Scheduled Follow up (Prospect)")]
		[AttributeLogicalName("schedulefollowup_prospect")]
		public DateTime? ScheduledFollowUpProspect
		{	
			get { return GetAttributeValue<DateTime?>("schedulefollowup_prospect"); }
			set
			{ 
				if(value == ScheduledFollowUpProspect) return;
				SetAttributeValue("schedulefollowup_prospect", value);
			}
		}	
			
		/// <summary>
        /// schedulefollowup_qualify
        /// </summary>
		[DisplayName("Scheduled Follow up (Qualify)")]
		[AttributeLogicalName("schedulefollowup_qualify")]
		public DateTime? ScheduledFollowUpQualify
		{	
			get { return GetAttributeValue<DateTime?>("schedulefollowup_qualify"); }
			set
			{ 
				if(value == ScheduledFollowUpQualify) return;
				SetAttributeValue("schedulefollowup_qualify", value);
			}
		}	
			
		/// <summary>
        /// scheduleproposalmeeting
        /// </summary>
		[DisplayName("Schedule Proposal Meeting")]
		[AttributeLogicalName("scheduleproposalmeeting")]
		public DateTime? ScheduleProposalMeeting
		{	
			get { return GetAttributeValue<DateTime?>("scheduleproposalmeeting"); }
			set
			{ 
				if(value == ScheduleProposalMeeting) return;
				SetAttributeValue("scheduleproposalmeeting", value);
			}
		}	
			
		/// <summary>
        /// sendthankyounote
        /// </summary>
		[DisplayName("Send Thank You Note")]
		[AttributeLogicalName("sendthankyounote")]
		public bool? SendThankYouNote
		{	
			get { return GetAttributeValue<bool?>("sendthankyounote"); }
			set
			{ 
				if(value == SendThankYouNote) return;
				SetAttributeValue("sendthankyounote", value);
			}
		}	
			
		/// <summary>
        /// skippricecalculation
        /// </summary>
		[DisplayName("Skip Price Calculation")]
		[AttributeLogicalName("skippricecalculation")]
		public egSkipPriceCalculationOptionSet? SkipPriceCalculation
		{	
			get 
			{ 
				var optionSetValue = GetAttributeValue<OptionSetValue>("skippricecalculation");
				if (optionSetValue != null) return (egSkipPriceCalculationOptionSet)optionSetValue.Value;
				else return null;
			}
			set 
			{ 
				if(value == SkipPriceCalculation) return;

				OptionSetValue optionSetValue = null;
				if(value != null) optionSetValue = new OptionSetValue((int)value);
				SetAttributeValue("skippricecalculation", optionSetValue); 
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
        /// stepid
        /// </summary>
		[DisplayName("Step")]
		[AttributeLogicalName("stepid")]
		public Guid StepId
		{	
			get { return GetAttributeValue<Guid>("stepid"); }
			set
			{ 
				if(value == StepId) return;
				SetAttributeValue("stepid", value);
			}
		}	
			
		/// <summary>
        /// stepname
        /// </summary>
		[DisplayName("Pipeline Phase")]
		[AttributeLogicalName("stepname")]
		public string PipelinePhase
		{	
			get { return GetAttributeValue<string>("stepname"); }
			set
			{ 
				if(value == PipelinePhase) return;
				SetAttributeValue("stepname", value);
			}
		}	
			
		/// <summary>
        /// teamsfollowed
        /// </summary>
		[DisplayName("TeamsFollowed")]
		[AttributeLogicalName("teamsfollowed")]
		public int? TeamsFollowed
		{	
			get { return GetAttributeValue<int?>("teamsfollowed"); }
			set
			{ 
				if(value == TeamsFollowed) return;
				SetAttributeValue("teamsfollowed", value);
			}
		}	
			
		/// <summary>
        /// timeline
        /// </summary>
		[DisplayName("Timeline")]
		[AttributeLogicalName("timeline")]
		public eTimeline? Timeline
		{	
			get 
			{ 
				var optionSetValue = GetAttributeValue<OptionSetValue>("timeline");
				if (optionSetValue != null) return (eTimeline)optionSetValue.Value;
				else return null;
			}
			set 
			{ 
				if(value == Timeline) return;

				OptionSetValue optionSetValue = null;
				if(value != null) optionSetValue = new OptionSetValue((int)value);
				SetAttributeValue("timeline", optionSetValue); 
			}
		}

		/// <summary>
        /// timespentbymeonemailandmeetings
        /// </summary>
		[DisplayName("Time Spent by me")]
		[AttributeLogicalName("timespentbymeonemailandmeetings")]
		public string TimeSpentByMe
		{	
			get { return GetAttributeValue<string>("timespentbymeonemailandmeetings"); }
			set
			{ 
				if(value == TimeSpentByMe) return;
				SetAttributeValue("timespentbymeonemailandmeetings", value);
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
        /// totalamount
		///
		/// Precision: 2
		/// MaxValue: 922337203685477
		/// MinValue: -922337203685477
        /// </summary>
		[DisplayName("Total Amount")]
		[AttributeLogicalName("totalamount")]
		public decimal? TotalAmount
		{	
			get { return GetAttributeValue<Money>("totalamount")?.Value; }
			set 
			{
				Money moneyValue = null;
				if(value != null) 
				{
					var roundedValue = Decimal.Round(value.Value, 2);
					moneyValue = new Money(roundedValue);
				}

				if(moneyValue.Value == TotalAmount) return;
				SetAttributeValue("totalamount", moneyValue);  
			}
		}

		/// <summary>
        /// totalamountlessfreight
		///
		/// Precision: 2
		/// MaxValue: 922337203685477
		/// MinValue: -922337203685477
        /// </summary>
		[DisplayName("Total Pre-Freight Amount")]
		[AttributeLogicalName("totalamountlessfreight")]
		public decimal? TotalPreFreightAmount
		{	
			get { return GetAttributeValue<Money>("totalamountlessfreight")?.Value; }
			set 
			{
				Money moneyValue = null;
				if(value != null) 
				{
					var roundedValue = Decimal.Round(value.Value, 2);
					moneyValue = new Money(roundedValue);
				}

				if(moneyValue.Value == TotalPreFreightAmount) return;
				SetAttributeValue("totalamountlessfreight", moneyValue);  
			}
		}

		/// <summary>
        /// totaldiscountamount
		///
		/// Precision: 2
		/// MaxValue: 922337203685477
		/// MinValue: -922337203685477
        /// </summary>
		[DisplayName("Total Discount Amount")]
		[AttributeLogicalName("totaldiscountamount")]
		public decimal? TotalDiscountAmount
		{	
			get { return GetAttributeValue<Money>("totaldiscountamount")?.Value; }
			set 
			{
				Money moneyValue = null;
				if(value != null) 
				{
					var roundedValue = Decimal.Round(value.Value, 2);
					moneyValue = new Money(roundedValue);
				}

				if(moneyValue.Value == TotalDiscountAmount) return;
				SetAttributeValue("totaldiscountamount", moneyValue);  
			}
		}

		/// <summary>
        /// totallineitemamount
		///
		/// Precision: 2
		/// MaxValue: 922337203685477
		/// MinValue: -922337203685477
        /// </summary>
		[DisplayName("Total Detail Amount")]
		[AttributeLogicalName("totallineitemamount")]
		public decimal? TotalDetailAmount
		{	
			get { return GetAttributeValue<Money>("totallineitemamount")?.Value; }
			set 
			{
				Money moneyValue = null;
				if(value != null) 
				{
					var roundedValue = Decimal.Round(value.Value, 2);
					moneyValue = new Money(roundedValue);
				}

				if(moneyValue.Value == TotalDetailAmount) return;
				SetAttributeValue("totallineitemamount", moneyValue);  
			}
		}

		/// <summary>
        /// totallineitemdiscountamount
		///
		/// Precision: 2
		/// MaxValue: 922337203685477
		/// MinValue: -922337203685477
        /// </summary>
		[DisplayName("Total Line Item Discount Amount")]
		[AttributeLogicalName("totallineitemdiscountamount")]
		public decimal? TotalLineItemDiscountAmount
		{	
			get { return GetAttributeValue<Money>("totallineitemdiscountamount")?.Value; }
			set 
			{
				Money moneyValue = null;
				if(value != null) 
				{
					var roundedValue = Decimal.Round(value.Value, 2);
					moneyValue = new Money(roundedValue);
				}

				if(moneyValue.Value == TotalLineItemDiscountAmount) return;
				SetAttributeValue("totallineitemdiscountamount", moneyValue);  
			}
		}

		/// <summary>
        /// totaltax
		///
		/// Precision: 2
		/// MaxValue: 922337203685477
		/// MinValue: -922337203685477
        /// </summary>
		[DisplayName("Total Tax")]
		[AttributeLogicalName("totaltax")]
		public decimal? TotalTax
		{	
			get { return GetAttributeValue<Money>("totaltax")?.Value; }
			set 
			{
				Money moneyValue = null;
				if(value != null) 
				{
					var roundedValue = Decimal.Round(value.Value, 2);
					moneyValue = new Money(roundedValue);
				}

				if(moneyValue.Value == TotalTax) return;
				SetAttributeValue("totaltax", moneyValue);  
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
        /// 1:N Get entities for 'lead_qualifying_opportunity'
        /// </summary>
		[RelationshipSchemaName("lead_qualifying_opportunity")]
		public IEnumerable<Lead> LeadQualifyingOpportunity
		{
			get { return GetRelatedEntities<Lead>("lead_qualifying_opportunity", null); }
			set { SetRelatedEntities("lead_qualifying_opportunity", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_leadtoopportunitysalesprocess_opportunityid'
        /// </summary>
		[RelationshipSchemaName("lk_leadtoopportunitysalesprocess_opportunityid")]
		public IEnumerable<LeadToOpportunitySalesProcess> LkLeadtoopportunitysalesprocessOpportunityid
		{
			get { return GetRelatedEntities<LeadToOpportunitySalesProcess>("lk_leadtoopportunitysalesprocess_opportunityid", null); }
			set { SetRelatedEntities("lk_leadtoopportunitysalesprocess_opportunityid", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_opportunitysalesprocess_opportunityid'
        /// </summary>
		[RelationshipSchemaName("lk_opportunitysalesprocess_opportunityid")]
		public IEnumerable<OpportunitySalesProcess> LkOpportunitysalesprocessOpportunityid
		{
			get { return GetRelatedEntities<OpportunitySalesProcess>("lk_opportunitysalesprocess_opportunityid", null); }
			set { SetRelatedEntities("lk_opportunitysalesprocess_opportunityid", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'msdyn_playbookinstance_opportunity'
        /// </summary>
		[RelationshipSchemaName("msdyn_playbookinstance_opportunity")]
		public IEnumerable<Playbook> MsdynPlaybookinstanceOpportunity
		{
			get { return GetRelatedEntities<Playbook>("msdyn_playbookinstance_opportunity", null); }
			set { SetRelatedEntities("msdyn_playbookinstance_opportunity", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'opportunity_actioncard'
        /// </summary>
		[RelationshipSchemaName("opportunity_actioncard")]
		public IEnumerable<ActionCard> OpportunityActioncard
		{
			get { return GetRelatedEntities<ActionCard>("opportunity_actioncard", null); }
			set { SetRelatedEntities("opportunity_actioncard", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'opportunity_activity_parties'
        /// </summary>
		[RelationshipSchemaName("opportunity_activity_parties")]
		public IEnumerable<ActivityParty> OpportunityActivityParties
		{
			get { return GetRelatedEntities<ActivityParty>("opportunity_activity_parties", null); }
			set { SetRelatedEntities("opportunity_activity_parties", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'Opportunity_ActivityPointers'
        /// </summary>
		[RelationshipSchemaName("Opportunity_ActivityPointers")]
		public IEnumerable<Activity> OpportunityActivityPointers
		{
			get { return GetRelatedEntities<Activity>("Opportunity_ActivityPointers", null); }
			set { SetRelatedEntities("Opportunity_ActivityPointers", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'Opportunity_Annotation'
        /// </summary>
		[RelationshipSchemaName("Opportunity_Annotation")]
		public IEnumerable<Note> OpportunityAnnotation
		{
			get { return GetRelatedEntities<Note>("Opportunity_Annotation", null); }
			set { SetRelatedEntities("Opportunity_Annotation", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'Opportunity_Appointments'
        /// </summary>
		[RelationshipSchemaName("Opportunity_Appointments")]
		public IEnumerable<Appointment> OpportunityAppointments
		{
			get { return GetRelatedEntities<Appointment>("Opportunity_Appointments", null); }
			set { SetRelatedEntities("Opportunity_Appointments", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'Opportunity_AsyncOperations'
        /// </summary>
		[RelationshipSchemaName("Opportunity_AsyncOperations")]
		public IEnumerable<SystemJob> OpportunityAsyncOperations
		{
			get { return GetRelatedEntities<SystemJob>("Opportunity_AsyncOperations", null); }
			set { SetRelatedEntities("Opportunity_AsyncOperations", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'Opportunity_BulkDeleteFailures'
        /// </summary>
		[RelationshipSchemaName("Opportunity_BulkDeleteFailures")]
		public IEnumerable<BulkDeleteFailure> OpportunityBulkDeleteFailures
		{
			get { return GetRelatedEntities<BulkDeleteFailure>("Opportunity_BulkDeleteFailures", null); }
			set { SetRelatedEntities("Opportunity_BulkDeleteFailures", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'opportunity_connections1'
        /// </summary>
		[RelationshipSchemaName("opportunity_connections1")]
		public IEnumerable<Connection> OpportunityConnections1
		{
			get { return GetRelatedEntities<Connection>("opportunity_connections1", null); }
			set { SetRelatedEntities("opportunity_connections1", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'opportunity_connections2'
        /// </summary>
		[RelationshipSchemaName("opportunity_connections2")]
		public IEnumerable<Connection> OpportunityConnections2
		{
			get { return GetRelatedEntities<Connection>("opportunity_connections2", null); }
			set { SetRelatedEntities("opportunity_connections2", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'Opportunity_DuplicateBaseRecord'
        /// </summary>
		[RelationshipSchemaName("Opportunity_DuplicateBaseRecord")]
		public IEnumerable<DuplicateRecord> OpportunityDuplicateBaseRecord
		{
			get { return GetRelatedEntities<DuplicateRecord>("Opportunity_DuplicateBaseRecord", null); }
			set { SetRelatedEntities("Opportunity_DuplicateBaseRecord", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'Opportunity_DuplicateMatchingRecord'
        /// </summary>
		[RelationshipSchemaName("Opportunity_DuplicateMatchingRecord")]
		public IEnumerable<DuplicateRecord> OpportunityDuplicateMatchingRecord
		{
			get { return GetRelatedEntities<DuplicateRecord>("Opportunity_DuplicateMatchingRecord", null); }
			set { SetRelatedEntities("Opportunity_DuplicateMatchingRecord", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'Opportunity_Emails'
        /// </summary>
		[RelationshipSchemaName("Opportunity_Emails")]
		public IEnumerable<Email> OpportunityEmails
		{
			get { return GetRelatedEntities<Email>("Opportunity_Emails", null); }
			set { SetRelatedEntities("Opportunity_Emails", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'Opportunity_Faxes'
        /// </summary>
		[RelationshipSchemaName("Opportunity_Faxes")]
		public IEnumerable<Fax> OpportunityFaxes
		{
			get { return GetRelatedEntities<Fax>("Opportunity_Faxes", null); }
			set { SetRelatedEntities("Opportunity_Faxes", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'opportunity_invoices'
        /// </summary>
		[RelationshipSchemaName("opportunity_invoices")]
		public IEnumerable<Invoice> OpportunityInvoices
		{
			get { return GetRelatedEntities<Invoice>("opportunity_invoices", null); }
			set { SetRelatedEntities("opportunity_invoices", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'Opportunity_Letters'
        /// </summary>
		[RelationshipSchemaName("Opportunity_Letters")]
		public IEnumerable<Letter> OpportunityLetters
		{
			get { return GetRelatedEntities<Letter>("Opportunity_Letters", null); }
			set { SetRelatedEntities("Opportunity_Letters", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'Opportunity_MailboxTrackingFolder'
        /// </summary>
		[RelationshipSchemaName("Opportunity_MailboxTrackingFolder")]
		public IEnumerable<MailboxAutoTrackingFolder> OpportunityMailboxTrackingFolder
		{
			get { return GetRelatedEntities<MailboxAutoTrackingFolder>("Opportunity_MailboxTrackingFolder", null); }
			set { SetRelatedEntities("Opportunity_MailboxTrackingFolder", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'Opportunity_OpportunityClose'
        /// </summary>
		[RelationshipSchemaName("Opportunity_OpportunityClose")]
		public IEnumerable<OpportunityClose> OpportunityOpportunityClose
		{
			get { return GetRelatedEntities<OpportunityClose>("Opportunity_OpportunityClose", null); }
			set { SetRelatedEntities("Opportunity_OpportunityClose", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'opportunity_OpportunityCloses'
        /// </summary>
		[RelationshipSchemaName("opportunity_OpportunityCloses")]
		public IEnumerable<OpportunityClose> OpportunityOpportunityCloses
		{
			get { return GetRelatedEntities<OpportunityClose>("opportunity_OpportunityCloses", null); }
			set { SetRelatedEntities("opportunity_OpportunityCloses", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'opportunity_OrderCloses'
        /// </summary>
		[RelationshipSchemaName("opportunity_OrderCloses")]
		public IEnumerable<OrderClose> OpportunityOrderCloses
		{
			get { return GetRelatedEntities<OrderClose>("opportunity_OrderCloses", null); }
			set { SetRelatedEntities("opportunity_OrderCloses", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'Opportunity_Phonecalls'
        /// </summary>
		[RelationshipSchemaName("Opportunity_Phonecalls")]
		public IEnumerable<PhoneCall> OpportunityPhonecalls
		{
			get { return GetRelatedEntities<PhoneCall>("Opportunity_Phonecalls", null); }
			set { SetRelatedEntities("Opportunity_Phonecalls", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'opportunity_PostFollows'
        /// </summary>
		[RelationshipSchemaName("opportunity_PostFollows")]
		public IEnumerable<Follow> OpportunityPostFollows
		{
			get { return GetRelatedEntities<Follow>("opportunity_PostFollows", null); }
			set { SetRelatedEntities("opportunity_PostFollows", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'opportunity_principalobjectattributeaccess'
        /// </summary>
		[RelationshipSchemaName("opportunity_principalobjectattributeaccess")]
		public IEnumerable<FieldSharing> OpportunityPrincipalobjectattributeaccess
		{
			get { return GetRelatedEntities<FieldSharing>("opportunity_principalobjectattributeaccess", null); }
			set { SetRelatedEntities("opportunity_principalobjectattributeaccess", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'Opportunity_ProcessSessions'
        /// </summary>
		[RelationshipSchemaName("Opportunity_ProcessSessions")]
		public IEnumerable<ProcessSession> OpportunityProcessSessions
		{
			get { return GetRelatedEntities<ProcessSession>("Opportunity_ProcessSessions", null); }
			set { SetRelatedEntities("Opportunity_ProcessSessions", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'opportunity_QuoteCloses'
        /// </summary>
		[RelationshipSchemaName("opportunity_QuoteCloses")]
		public IEnumerable<QuoteClose> OpportunityQuoteCloses
		{
			get { return GetRelatedEntities<QuoteClose>("opportunity_QuoteCloses", null); }
			set { SetRelatedEntities("opportunity_QuoteCloses", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'opportunity_quotes'
        /// </summary>
		[RelationshipSchemaName("opportunity_quotes")]
		public IEnumerable<Quote> OpportunityQuotes
		{
			get { return GetRelatedEntities<Quote>("opportunity_quotes", null); }
			set { SetRelatedEntities("opportunity_quotes", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'Opportunity_RecurringAppointmentMasters'
        /// </summary>
		[RelationshipSchemaName("Opportunity_RecurringAppointmentMasters")]
		public IEnumerable<RecurringAppointment> OpportunityRecurringAppointmentMasters
		{
			get { return GetRelatedEntities<RecurringAppointment>("Opportunity_RecurringAppointmentMasters", null); }
			set { SetRelatedEntities("Opportunity_RecurringAppointmentMasters", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'opportunity_sales_orders'
        /// </summary>
		[RelationshipSchemaName("opportunity_sales_orders")]
		public IEnumerable<Order> OpportunitySalesOrders
		{
			get { return GetRelatedEntities<Order>("opportunity_sales_orders", null); }
			set { SetRelatedEntities("opportunity_sales_orders", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'Opportunity_ServiceAppointments'
        /// </summary>
		[RelationshipSchemaName("Opportunity_ServiceAppointments")]
		public IEnumerable<ServiceActivity> OpportunityServiceAppointments
		{
			get { return GetRelatedEntities<ServiceActivity>("Opportunity_ServiceAppointments", null); }
			set { SetRelatedEntities("Opportunity_ServiceAppointments", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'Opportunity_SharepointDocumentLocation'
        /// </summary>
		[RelationshipSchemaName("Opportunity_SharepointDocumentLocation")]
		public IEnumerable<DocumentLocation> OpportunitySharepointDocumentLocation
		{
			get { return GetRelatedEntities<DocumentLocation>("Opportunity_SharepointDocumentLocation", null); }
			set { SetRelatedEntities("Opportunity_SharepointDocumentLocation", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'Opportunity_SocialActivities'
        /// </summary>
		[RelationshipSchemaName("Opportunity_SocialActivities")]
		public IEnumerable<SocialActivity> OpportunitySocialActivities
		{
			get { return GetRelatedEntities<SocialActivity>("Opportunity_SocialActivities", null); }
			set { SetRelatedEntities("Opportunity_SocialActivities", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'Opportunity_SyncErrors'
        /// </summary>
		[RelationshipSchemaName("Opportunity_SyncErrors")]
		public IEnumerable<SyncError> OpportunitySyncErrors
		{
			get { return GetRelatedEntities<SyncError>("Opportunity_SyncErrors", null); }
			set { SetRelatedEntities("Opportunity_SyncErrors", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'Opportunity_Tasks'
        /// </summary>
		[RelationshipSchemaName("Opportunity_Tasks")]
		public IEnumerable<Task> OpportunityTasks
		{
			get { return GetRelatedEntities<Task>("Opportunity_Tasks", null); }
			set { SetRelatedEntities("Opportunity_Tasks", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'opportunity_Teams'
        /// </summary>
		[RelationshipSchemaName("opportunity_Teams")]
		public IEnumerable<Team> OpportunityTeams
		{
			get { return GetRelatedEntities<Team>("opportunity_Teams", null); }
			set { SetRelatedEntities("opportunity_Teams", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'product_opportunities'
        /// </summary>
		[RelationshipSchemaName("product_opportunities")]
		public IEnumerable<OpportunityProduct> ProductOpportunities
		{
			get { return GetRelatedEntities<OpportunityProduct>("product_opportunities", null); }
			set { SetRelatedEntities("product_opportunities", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'slakpiinstance_opportunity'
        /// </summary>
		[RelationshipSchemaName("slakpiinstance_opportunity")]
		public IEnumerable<SLAKPIInstance> SlakpiinstanceOpportunity
		{
			get { return GetRelatedEntities<SLAKPIInstance>("slakpiinstance_opportunity", null); }
			set { SetRelatedEntities("slakpiinstance_opportunity", null, value); }
		}
		/// <summary>
        /// N:N Get entities for 'Competitor'
        /// </summary>
		[RelationshipSchemaName("opportunitycompetitors_association")]
		public IEnumerable<Competitor> OpportunitycompetitorsAssociation
		{
			get { return GetRelatedEntities<Competitor>("opportunitycompetitors_association", null); }
			set { SetRelatedEntities("opportunitycompetitors_association", null, value); }
		}
		#endregion

		#region Actions
		#endregion

		#region OptionSetEnums
		public enum egBudget
		{	
		
			[Label("No Committed Budget")]
			[Description(@"")]
			NoCommittedBudget = 0, 
		
			[Label("May Buy")]
			[Description(@"")]
			MayBuy = 1, 
		
			[Label("Can Buy")]
			[Description(@"")]
			CanBuy = 2, 
		
			[Label("Will Buy")]
			[Description(@"")]
			WillBuy = 3, 
		}
		
		public enum egInitialCommunication
		{	
		
			[Label("Contacted")]
			[Description(@"")]
			Contacted = 0, 
		
			[Label("Not Contacted")]
			[Description(@"")]
			NotContacted = 1, 
		}
		
		public enum egNeed
		{	
		
			[Label("Must have")]
			[Description(@"")]
			MustHave = 0, 
		
			[Label("Should have")]
			[Description(@"")]
			ShouldHave = 1, 
		
			[Label("Good to have")]
			[Description(@"")]
			GoodToHave = 2, 
		
			[Label("No need")]
			[Description(@"")]
			NoNeed = 3, 
		}
		
		public enum eRating
		{	
		
			[Label("Hot")]
			[Description(@"")]
			Hot = 1, 
		
			[Label("Warm")]
			[Description(@"")]
			Warm = 2, 
		
			[Label("Cold")]
			[Description(@"")]
			Cold = 3, 
		}
		
		public enum ePriority
		{	
		
			[Label("Default Value")]
			[Description(@"")]
			DefaultValue = 1, 
		}
		
		public enum egOpportunitySalesstage
		{	
		
			[Label("Qualify")]
			[Description(@"")]
			Qualify = 0, 
		
			[Label("Develop")]
			[Description(@"")]
			Develop = 1, 
		
			[Label("Propose")]
			[Description(@"")]
			Propose = 2, 
		
			[Label("Close")]
			[Description(@"")]
			Close = 3, 
		}
		
		public enum eProcessCode
		{	
		
			[Label("Default Value")]
			[Description(@"")]
			DefaultValue = 1, 
		}
		
		public enum eStatus
		{	
		
			[Label("Open")]
			[Description(@"")]
			Open = 0, 
		
			[Label("Won")]
			[Description(@"")]
			Won = 1, 
		
			[Label("Lost")]
			[Description(@"")]
			Lost = 2, 
		}
		
		public enum eStatusReason
		{	
		
			[Label("In Progress")]
			[Description(@"")]
			InProgress_Active = 1, 
		
			[Label("On Hold")]
			[Description(@"")]
			OnHold_Active = 2, 
		
			[Label("Won")]
			[Description(@"")]
			Won_Inactive = 3, 
		
			[Label("Canceled")]
			[Description(@"")]
			Canceled = 4, 
		
			[Label("Out-Sold")]
			[Description(@"")]
			OutSold = 5, 
		}
		
		public enum eTimeline
		{	
		
			[Label("Immediate")]
			[Description(@"")]
			Immediate = 0, 
		
			[Label("This Quarter")]
			[Description(@"")]
			ThisQuarter = 1, 
		
			[Label("Next Quarter")]
			[Description(@"")]
			NextQuarter = 2, 
		
			[Label("This Year")]
			[Description(@"")]
			ThisYear = 3, 
		
			[Label("Not known")]
			[Description(@"")]
			NotKnown = 4, 
		}
		
		public enum egPurchaseProcess
		{	
		
			[Label("Individual")]
			[Description(@"")]
			Individual = 0, 
		
			[Label("Committee")]
			[Description(@"")]
			Committee = 1, 
		
			[Label("Unknown")]
			[Description(@"")]
			Unknown = 2, 
		}
		
		public enum egPurchaseTimeframe
		{	
		
			[Label("Immediate")]
			[Description(@"")]
			Immediate = 0, 
		
			[Label("This Quarter")]
			[Description(@"")]
			ThisQuarter = 1, 
		
			[Label("Next Quarter")]
			[Description(@"")]
			NextQuarter = 2, 
		
			[Label("This Year")]
			[Description(@"")]
			ThisYear = 3, 
		
			[Label("Unknown")]
			[Description(@"")]
			Unknown = 4, 
		}
		
		public enum egPricingError
		{	
		
			[Label("None")]
			[Description(@"")]
			None = 0, 
		
			[Label("Detail Error")]
			[Description(@"")]
			DetailError = 1, 
		
			[Label("Missing Price Level")]
			[Description(@"")]
			MissingPriceLevel = 2, 
		
			[Label("Inactive Price Level")]
			[Description(@"")]
			InactivePriceLevel = 3, 
		
			[Label("Missing Quantity")]
			[Description(@"")]
			MissingQuantity = 4, 
		
			[Label("Missing Unit Price")]
			[Description(@"")]
			MissingUnitPrice = 5, 
		
			[Label("Missing Product")]
			[Description(@"")]
			MissingProduct = 6, 
		
			[Label("Invalid Product")]
			[Description(@"")]
			InvalidProduct = 7, 
		
			[Label("Missing Pricing Code")]
			[Description(@"")]
			MissingPricingCode = 8, 
		
			[Label("Invalid Pricing Code")]
			[Description(@"")]
			InvalidPricingCode = 9, 
		
			[Label("Missing UOM")]
			[Description(@"")]
			MissingUOM = 10, 
		
			[Label("Product Not In Price Level")]
			[Description(@"")]
			ProductNotInPriceLevel = 11, 
		
			[Label("Missing Price Level Amount")]
			[Description(@"")]
			MissingPriceLevelAmount = 12, 
		
			[Label("Missing Price Level Percentage")]
			[Description(@"")]
			MissingPriceLevelPercentage = 13, 
		
			[Label("Missing Price")]
			[Description(@"")]
			MissingPrice = 14, 
		
			[Label("Missing Current Cost")]
			[Description(@"")]
			MissingCurrentCost = 15, 
		
			[Label("Missing Standard Cost")]
			[Description(@"")]
			MissingStandardCost = 16, 
		
			[Label("Invalid Price Level Amount")]
			[Description(@"")]
			InvalidPriceLevelAmount = 17, 
		
			[Label("Invalid Price Level Percentage")]
			[Description(@"")]
			InvalidPriceLevelPercentage = 18, 
		
			[Label("Invalid Price")]
			[Description(@"")]
			InvalidPrice = 19, 
		
			[Label("Invalid Current Cost")]
			[Description(@"")]
			InvalidCurrentCost = 20, 
		
			[Label("Invalid Standard Cost")]
			[Description(@"")]
			InvalidStandardCost = 21, 
		
			[Label("Invalid Rounding Policy")]
			[Description(@"")]
			InvalidRoundingPolicy = 22, 
		
			[Label("Invalid Rounding Option")]
			[Description(@"")]
			InvalidRoundingOption = 23, 
		
			[Label("Invalid Rounding Amount")]
			[Description(@"")]
			InvalidRoundingAmount = 24, 
		
			[Label("Price Calculation Error")]
			[Description(@"")]
			PriceCalculationError = 25, 
		
			[Label("Invalid Discount Type")]
			[Description(@"")]
			InvalidDiscountType = 26, 
		
			[Label("Discount Type Invalid State")]
			[Description(@"")]
			DiscountTypeInvalidState = 27, 
		
			[Label("Invalid Discount")]
			[Description(@"")]
			InvalidDiscount = 28, 
		
			[Label("Invalid Quantity")]
			[Description(@"")]
			InvalidQuantity = 29, 
		
			[Label("Invalid Pricing Precision")]
			[Description(@"")]
			InvalidPricingPrecision = 30, 
		
			[Label("Missing Product Default UOM")]
			[Description(@"")]
			MissingProductDefaultUOM = 31, 
		
			[Label("Missing Product UOM Schedule")]
			[Description(@"")]
			MissingProductUOMSchedule = 32, 
		
			[Label("Inactive Discount Type")]
			[Description(@"")]
			InactiveDiscountType = 33, 
		
			[Label("Invalid Price Level Currency")]
			[Description(@"")]
			InvalidPriceLevelCurrency = 34, 
		
			[Label("Price Attribute Out Of Range")]
			[Description(@"")]
			PriceAttributeOutOfRange = 35, 
		
			[Label("Base Currency Attribute Overflow")]
			[Description(@"")]
			BaseCurrencyAttributeOverflow = 36, 
		
			[Label("Base Currency Attribute Underflow")]
			[Description(@"")]
			BaseCurrencyAttributeUnderflow = 37, 
		
			[Label("Transaction currency is not set for the product price list item")]
			[Description(@"")]
			TransactionCurrencyIsNotSetForTheProductPriceListItem = 38, 
		}
		
		public enum egSkipPriceCalculationOptionSet
		{	
		
			[Label("DoPriceCalcAlways")]
			[Description(@"")]
			DoPriceCalcAlways = 0, 
		
			[Label("SkipPriceCalcOnRetrieve")]
			[Description(@"")]
			SkipPriceCalcOnRetrieve = 1, 
		}
		
		#endregion	

		#region Properties
		public static class Properties 
		{
			/// <summary>accountid</summary>
			public const string Account = "accountid";

			/// <summary>accountidname</summary>
			public const string Accountidname = "accountidname";

			/// <summary>accountidyominame</summary>
			public const string Accountidyominame = "accountidyominame";

			/// <summary>actualclosedate</summary>
			public const string ActualCloseDate = "actualclosedate";

			/// <summary>actualvalue</summary>
			public const string ActualRevenue = "actualvalue";

			/// <summary>budgetamount</summary>
			public const string BudgetAmount = "budgetamount";

			/// <summary>budgetstatus</summary>
			public const string Budget = "budgetstatus";

			/// <summary>campaignid</summary>
			public const string SourceCampaign = "campaignid";

			/// <summary>campaignidname</summary>
			public const string Campaignidname = "campaignidname";

			/// <summary>captureproposalfeedback</summary>
			public const string ProposalFeedbackCaptured = "captureproposalfeedback";

			/// <summary>closeprobability</summary>
			public const string Probability = "closeprobability";

			/// <summary>completefinalproposal</summary>
			public const string FinalProposalReady = "completefinalproposal";

			/// <summary>completeinternalreview</summary>
			public const string CompleteInternalReview = "completeinternalreview";

			/// <summary>confirminterest</summary>
			public const string ConfirmInterest = "confirminterest";

			/// <summary>contactid</summary>
			public const string Contact = "contactid";

			/// <summary>contactidname</summary>
			public const string Contactidname = "contactidname";

			/// <summary>contactidyominame</summary>
			public const string Contactidyominame = "contactidyominame";

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

			/// <summary>currentsituation</summary>
			public const string CurrentSituation = "currentsituation";

			/// <summary>customerid</summary>
			public const string PotentialCustomer = "customerid";

			/// <summary>customeridname</summary>
			public const string Customeridname = "customeridname";

			/// <summary>customeridtype</summary>
			public const string PotentialCustomerType = "customeridtype";

			/// <summary>customeridyominame</summary>
			public const string Customeridyominame = "customeridyominame";

			/// <summary>customerneed</summary>
			public const string CustomerNeed = "customerneed";

			/// <summary>customerpainpoints</summary>
			public const string CustomerPainPoints = "customerpainpoints";

			/// <summary>decisionmaker</summary>
			public const string DecisionMaker = "decisionmaker";

			/// <summary>description</summary>
			public const string Description = "description";

			/// <summary>developproposal</summary>
			public const string DevelopProposal = "developproposal";

			/// <summary>discountamount</summary>
			public const string OpportunityDiscountAmount = "discountamount";

			/// <summary>discountpercentage</summary>
			public const string OpportunityDiscount = "discountpercentage";

			/// <summary>emailaddress</summary>
			public const string EmailAddress = "emailaddress";

			/// <summary>estimatedclosedate</summary>
			public const string EstCloseDate = "estimatedclosedate";

			/// <summary>estimatedvalue</summary>
			public const string EstRevenue = "estimatedvalue";

			/// <summary>evaluatefit</summary>
			public const string EvaluateFit = "evaluatefit";

			/// <summary>exchangerate</summary>
			public const string ExchangeRate = "exchangerate";

			/// <summary>filedebrief</summary>
			public const string FileDebrief = "filedebrief";

			/// <summary>finaldecisiondate</summary>
			public const string FinalDecisionDate = "finaldecisiondate";

			/// <summary>freightamount</summary>
			public const string FreightAmount = "freightamount";

			/// <summary>identifycompetitors</summary>
			public const string IdentifyCompetitors = "identifycompetitors";

			/// <summary>identifycustomercontacts</summary>
			public const string IdentifyCustomerContacts = "identifycustomercontacts";

			/// <summary>identifypursuitteam</summary>
			public const string IdentifySalesTeam = "identifypursuitteam";

			/// <summary>importsequencenumber</summary>
			public const string ImportSequenceNumber = "importsequencenumber";

			/// <summary>initialcommunication</summary>
			public const string InitialCommunication = "initialcommunication";

			/// <summary>isprivate</summary>
			public const string IsPrivate = "isprivate";

			/// <summary>isrevenuesystemcalculated</summary>
			public const string Revenue = "isrevenuesystemcalculated";

			/// <summary>lastonholdtime</summary>
			public const string LastOnHoldTime = "lastonholdtime";

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
			public const string Topic = "name";

			/// <summary>need</summary>
			public const string Need = "need";

			/// <summary>onholdtime</summary>
			public const string OnHoldTimeMinutes = "onholdtime";

			/// <summary>opportunityid</summary>
			public const string OpportunityId = "opportunityid";

			/// <summary>opportunityratingcode</summary>
			public const string Rating = "opportunityratingcode";

			/// <summary>originatingleadid</summary>
			public const string OriginatingLead = "originatingleadid";

			/// <summary>originatingleadidname</summary>
			public const string Originatingleadidname = "originatingleadidname";

			/// <summary>originatingleadidyominame</summary>
			public const string Originatingleadidyominame = "originatingleadidyominame";

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

			/// <summary>parentaccountid</summary>
			public const string Account2 = "parentaccountid";

			/// <summary>parentaccountidname</summary>
			public const string Parentaccountidname = "parentaccountidname";

			/// <summary>parentaccountidyominame</summary>
			public const string Parentaccountidyominame = "parentaccountidyominame";

			/// <summary>parentcontactid</summary>
			public const string Contact2 = "parentcontactid";

			/// <summary>parentcontactidname</summary>
			public const string Parentcontactidname = "parentcontactidname";

			/// <summary>parentcontactidyominame</summary>
			public const string Parentcontactidyominame = "parentcontactidyominame";

			/// <summary>participatesinworkflow</summary>
			public const string ParticipatesInWorkflow = "participatesinworkflow";

			/// <summary>presentfinalproposal</summary>
			public const string PresentFinalProposal = "presentfinalproposal";

			/// <summary>presentproposal</summary>
			public const string PresentedProposal = "presentproposal";

			/// <summary>pricelevelid</summary>
			public const string PriceList = "pricelevelid";

			/// <summary>pricelevelidname</summary>
			public const string Pricelevelidname = "pricelevelidname";

			/// <summary>pricingerrorcode</summary>
			public const string PricingError = "pricingerrorcode";

			/// <summary>prioritycode</summary>
			public const string Priority = "prioritycode";

			/// <summary>processid</summary>
			public const string ProcessId = "processid";

			/// <summary>proposedsolution</summary>
			public const string ProposedSolution = "proposedsolution";

			/// <summary>purchaseprocess</summary>
			public const string PurchaseProcess = "purchaseprocess";

			/// <summary>purchasetimeframe</summary>
			public const string PurchaseTimeframe = "purchasetimeframe";

			/// <summary>pursuitdecision</summary>
			public const string DecideGoNoGo = "pursuitdecision";

			/// <summary>qualificationcomments</summary>
			public const string QualificationComments = "qualificationcomments";

			/// <summary>quotecomments</summary>
			public const string QuoteComments = "quotecomments";

			/// <summary>resolvefeedback</summary>
			public const string FeedbackResolved = "resolvefeedback";

			/// <summary>salesstage</summary>
			public const string SalesStage = "salesstage";

			/// <summary>salesstagecode</summary>
			public const string ProcessCode = "salesstagecode";

			/// <summary>schedulefollowup_prospect</summary>
			public const string ScheduledFollowUpProspect = "schedulefollowup_prospect";

			/// <summary>schedulefollowup_qualify</summary>
			public const string ScheduledFollowUpQualify = "schedulefollowup_qualify";

			/// <summary>scheduleproposalmeeting</summary>
			public const string ScheduleProposalMeeting = "scheduleproposalmeeting";

			/// <summary>sendthankyounote</summary>
			public const string SendThankYouNote = "sendthankyounote";

			/// <summary>skippricecalculation</summary>
			public const string SkipPriceCalculation = "skippricecalculation";

			/// <summary>slaid</summary>
			public const string SLA = "slaid";

			/// <summary>slainvokedid</summary>
			public const string LastSLAApplied = "slainvokedid";

			/// <summary>slainvokedidname</summary>
			public const string Slainvokedidname = "slainvokedidname";

			/// <summary>slaname</summary>
			public const string Slaname = "slaname";

			/// <summary>stageid</summary>
			public const string DeprecatedStageId = "stageid";

			/// <summary>statecode</summary>
			public const string Status = "statecode";

			/// <summary>statuscode</summary>
			public const string StatusReason = "statuscode";

			/// <summary>stepid</summary>
			public const string StepId = "stepid";

			/// <summary>stepname</summary>
			public const string PipelinePhase = "stepname";

			/// <summary>teamsfollowed</summary>
			public const string TeamsFollowed = "teamsfollowed";

			/// <summary>timeline</summary>
			public const string Timeline = "timeline";

			/// <summary>timespentbymeonemailandmeetings</summary>
			public const string TimeSpentByMe = "timespentbymeonemailandmeetings";

			/// <summary>timezoneruleversionnumber</summary>
			public const string TimeZoneRuleVersionNumber = "timezoneruleversionnumber";

			/// <summary>totalamount</summary>
			public const string TotalAmount = "totalamount";

			/// <summary>totalamountlessfreight</summary>
			public const string TotalPreFreightAmount = "totalamountlessfreight";

			/// <summary>totaldiscountamount</summary>
			public const string TotalDiscountAmount = "totaldiscountamount";

			/// <summary>totallineitemamount</summary>
			public const string TotalDetailAmount = "totallineitemamount";

			/// <summary>totallineitemdiscountamount</summary>
			public const string TotalLineItemDiscountAmount = "totallineitemdiscountamount";

			/// <summary>totaltax</summary>
			public const string TotalTax = "totaltax";

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
			/// <summary>1:N lead_qualifying_opportunity</summary>
			public const string LeadQualifyingOpportunity = "lead_qualifying_opportunity";

			/// <summary>1:N lk_leadtoopportunitysalesprocess_opportunityid</summary>
			public const string LkLeadtoopportunitysalesprocessOpportunityid = "lk_leadtoopportunitysalesprocess_opportunityid";

			/// <summary>1:N lk_opportunitysalesprocess_opportunityid</summary>
			public const string LkOpportunitysalesprocessOpportunityid = "lk_opportunitysalesprocess_opportunityid";

			/// <summary>1:N msdyn_playbookinstance_opportunity</summary>
			public const string MsdynPlaybookinstanceOpportunity = "msdyn_playbookinstance_opportunity";

			/// <summary>1:N opportunity_actioncard</summary>
			public const string OpportunityActioncard = "opportunity_actioncard";

			/// <summary>1:N opportunity_activity_parties</summary>
			public const string OpportunityActivityParties = "opportunity_activity_parties";

			/// <summary>1:N Opportunity_ActivityPointers</summary>
			public const string OpportunityActivityPointers = "Opportunity_ActivityPointers";

			/// <summary>1:N Opportunity_Annotation</summary>
			public const string OpportunityAnnotation = "Opportunity_Annotation";

			/// <summary>1:N Opportunity_Appointments</summary>
			public const string OpportunityAppointments = "Opportunity_Appointments";

			/// <summary>1:N Opportunity_AsyncOperations</summary>
			public const string OpportunityAsyncOperations = "Opportunity_AsyncOperations";

			/// <summary>1:N Opportunity_BulkDeleteFailures</summary>
			public const string OpportunityBulkDeleteFailures = "Opportunity_BulkDeleteFailures";

			/// <summary>1:N opportunity_connections1</summary>
			public const string OpportunityConnections1 = "opportunity_connections1";

			/// <summary>1:N opportunity_connections2</summary>
			public const string OpportunityConnections2 = "opportunity_connections2";

			/// <summary>1:N Opportunity_DuplicateBaseRecord</summary>
			public const string OpportunityDuplicateBaseRecord = "Opportunity_DuplicateBaseRecord";

			/// <summary>1:N Opportunity_DuplicateMatchingRecord</summary>
			public const string OpportunityDuplicateMatchingRecord = "Opportunity_DuplicateMatchingRecord";

			/// <summary>1:N Opportunity_Emails</summary>
			public const string OpportunityEmails = "Opportunity_Emails";

			/// <summary>1:N Opportunity_Faxes</summary>
			public const string OpportunityFaxes = "Opportunity_Faxes";

			/// <summary>1:N opportunity_invoices</summary>
			public const string OpportunityInvoices = "opportunity_invoices";

			/// <summary>1:N Opportunity_Letters</summary>
			public const string OpportunityLetters = "Opportunity_Letters";

			/// <summary>1:N Opportunity_MailboxTrackingFolder</summary>
			public const string OpportunityMailboxTrackingFolder = "Opportunity_MailboxTrackingFolder";

			/// <summary>1:N Opportunity_OpportunityClose</summary>
			public const string OpportunityOpportunityClose = "Opportunity_OpportunityClose";

			/// <summary>1:N opportunity_OpportunityCloses</summary>
			public const string OpportunityOpportunityCloses = "opportunity_OpportunityCloses";

			/// <summary>1:N opportunity_OrderCloses</summary>
			public const string OpportunityOrderCloses = "opportunity_OrderCloses";

			/// <summary>1:N Opportunity_Phonecalls</summary>
			public const string OpportunityPhonecalls = "Opportunity_Phonecalls";

			/// <summary>1:N opportunity_PostFollows</summary>
			public const string OpportunityPostFollows = "opportunity_PostFollows";

			/// <summary>1:N opportunity_principalobjectattributeaccess</summary>
			public const string OpportunityPrincipalobjectattributeaccess = "opportunity_principalobjectattributeaccess";

			/// <summary>1:N Opportunity_ProcessSessions</summary>
			public const string OpportunityProcessSessions = "Opportunity_ProcessSessions";

			/// <summary>1:N opportunity_QuoteCloses</summary>
			public const string OpportunityQuoteCloses = "opportunity_QuoteCloses";

			/// <summary>1:N opportunity_quotes</summary>
			public const string OpportunityQuotes = "opportunity_quotes";

			/// <summary>1:N Opportunity_RecurringAppointmentMasters</summary>
			public const string OpportunityRecurringAppointmentMasters = "Opportunity_RecurringAppointmentMasters";

			/// <summary>1:N opportunity_sales_orders</summary>
			public const string OpportunitySalesOrders = "opportunity_sales_orders";

			/// <summary>1:N Opportunity_ServiceAppointments</summary>
			public const string OpportunityServiceAppointments = "Opportunity_ServiceAppointments";

			/// <summary>1:N Opportunity_SharepointDocumentLocation</summary>
			public const string OpportunitySharepointDocumentLocation = "Opportunity_SharepointDocumentLocation";

			/// <summary>1:N Opportunity_SocialActivities</summary>
			public const string OpportunitySocialActivities = "Opportunity_SocialActivities";

			/// <summary>1:N Opportunity_SyncErrors</summary>
			public const string OpportunitySyncErrors = "Opportunity_SyncErrors";

			/// <summary>1:N Opportunity_Tasks</summary>
			public const string OpportunityTasks = "Opportunity_Tasks";

			/// <summary>1:N opportunity_Teams</summary>
			public const string OpportunityTeams = "opportunity_Teams";

			/// <summary>1:N product_opportunities</summary>
			public const string ProductOpportunities = "product_opportunities";

			/// <summary>1:N slakpiinstance_opportunity</summary>
			public const string SlakpiinstanceOpportunity = "slakpiinstance_opportunity";

			/// <summary>N:N opportunitycompetitors_association</summary>
			public const string OpportunitycompetitorsAssociation = "opportunitycompetitors_association";

		}
		#endregion
	}
}

