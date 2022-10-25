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
	[EntityLogicalName("goal")]
	public sealed class Goal : Entity
	{	
		public static readonly int? EntityTypeCode = 9600;
		public new const string LogicalName = "goal";
		public const string PrimaryIdAttribute = "goalid";
		public const string PrimaryNameAttribute = "title";
	
		public Goal() : base("goal") { }

		#region Attributes
		/// <summary>
        /// actualdecimal
        /// </summary>
		[DisplayName("Actual (Decimal)")]
		[AttributeLogicalName("actualdecimal")]
		public decimal? ActualDecimal
		{	
			get { return GetAttributeValue<decimal?>("actualdecimal"); }
			set
			{ 
				if(value == ActualDecimal) return;
				SetAttributeValue("actualdecimal", value);
			}
		}	
			
		/// <summary>
        /// actualinteger
        /// </summary>
		[DisplayName("Actual (Integer)")]
		[AttributeLogicalName("actualinteger")]
		public int? ActualInteger
		{	
			get { return GetAttributeValue<int?>("actualinteger"); }
			set
			{ 
				if(value == ActualInteger) return;
				SetAttributeValue("actualinteger", value);
			}
		}	
			
		/// <summary>
        /// actualmoney
        /// </summary>
		[DisplayName("Actual (Money)")]
		[AttributeLogicalName("actualmoney")]
		public decimal? ActualMoney
		{	
			get { return GetAttributeValue<Money>("actualmoney")?.Value; }
			set 
			{ 
				if(value == ActualMoney) return;

				Money moneyValue = null;
				if(value != null) moneyValue = new Money(value.Value);
				SetAttributeValue("actualmoney", moneyValue);  
			}
		}

		/// <summary>
        /// actualstring
        /// </summary>
		[DisplayName("Actual")]
		[AttributeLogicalName("actualstring")]
		public string Actual
		{	
			get { return GetAttributeValue<string>("actualstring"); }
			set
			{ 
				if(value == Actual) return;
				SetAttributeValue("actualstring", value);
			}
		}	
			
		/// <summary>
        /// amountdatatype
        /// </summary>
		[DisplayName("Amount Data Type")]
		[AttributeLogicalName("amountdatatype")]
		public egGoalType? AmountDataType
		{	
			get 
			{ 
				var optionSetValue = GetAttributeValue<OptionSetValue>("amountdatatype");
				if (optionSetValue != null) return (egGoalType)optionSetValue.Value;
				else return null;
			}
			set 
			{ 
				if(value == AmountDataType) return;

				OptionSetValue optionSetValue = null;
				if(value != null) optionSetValue = new OptionSetValue((int)value);
				SetAttributeValue("amountdatatype", optionSetValue); 
			}
		}

		/// <summary>
        /// computedtargetasoftodaydecimal
        /// </summary>
		[DisplayName("Today's Target (Decimal)")]
		[AttributeLogicalName("computedtargetasoftodaydecimal")]
		public decimal? TodaysTargetDecimal
		{	
			get { return GetAttributeValue<decimal?>("computedtargetasoftodaydecimal"); }
			set
			{ 
				if(value == TodaysTargetDecimal) return;
				SetAttributeValue("computedtargetasoftodaydecimal", value);
			}
		}	
			
		/// <summary>
        /// computedtargetasoftodayinteger
        /// </summary>
		[DisplayName("Today's Target (Integer)")]
		[AttributeLogicalName("computedtargetasoftodayinteger")]
		public int? TodaysTargetInteger
		{	
			get { return GetAttributeValue<int?>("computedtargetasoftodayinteger"); }
			set
			{ 
				if(value == TodaysTargetInteger) return;
				SetAttributeValue("computedtargetasoftodayinteger", value);
			}
		}	
			
		/// <summary>
        /// computedtargetasoftodaymoney
        /// </summary>
		[DisplayName("Today's Target (Money)")]
		[AttributeLogicalName("computedtargetasoftodaymoney")]
		public decimal? TodaysTargetMoney
		{	
			get { return GetAttributeValue<Money>("computedtargetasoftodaymoney")?.Value; }
			set 
			{ 
				if(value == TodaysTargetMoney) return;

				Money moneyValue = null;
				if(value != null) moneyValue = new Money(value.Value);
				SetAttributeValue("computedtargetasoftodaymoney", moneyValue);  
			}
		}

		/// <summary>
        /// computedtargetasoftodaypercentageachieved
        /// </summary>
		[DisplayName("Today's Target (Percentage Achieved)")]
		[AttributeLogicalName("computedtargetasoftodaypercentageachieved")]
		public decimal? TodaysTargetPercentageAchieved
		{	
			get { return GetAttributeValue<decimal?>("computedtargetasoftodaypercentageachieved"); }
			set
			{ 
				if(value == TodaysTargetPercentageAchieved) return;
				SetAttributeValue("computedtargetasoftodaypercentageachieved", value);
			}
		}	
			
		/// <summary>
        /// consideronlygoalownersrecords
        /// </summary>
		[DisplayName("Record Set for Rollup")]
		[AttributeLogicalName("consideronlygoalownersrecords")]
		public bool? RecordSetForRollup
		{	
			get { return GetAttributeValue<bool?>("consideronlygoalownersrecords"); }
			set
			{ 
				if(value == RecordSetForRollup) return;
				SetAttributeValue("consideronlygoalownersrecords", value);
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
        /// customrollupfielddecimal
        /// </summary>
		[DisplayName("Custom Rollup Field (Decimal)")]
		[AttributeLogicalName("customrollupfielddecimal")]
		public decimal? CustomRollupFieldDecimal
		{	
			get { return GetAttributeValue<decimal?>("customrollupfielddecimal"); }
			set
			{ 
				if(value == CustomRollupFieldDecimal) return;
				SetAttributeValue("customrollupfielddecimal", value);
			}
		}	
			
		/// <summary>
        /// customrollupfieldinteger
        /// </summary>
		[DisplayName("Custom Rollup Field (Integer)")]
		[AttributeLogicalName("customrollupfieldinteger")]
		public int? CustomRollupFieldInteger
		{	
			get { return GetAttributeValue<int?>("customrollupfieldinteger"); }
			set
			{ 
				if(value == CustomRollupFieldInteger) return;
				SetAttributeValue("customrollupfieldinteger", value);
			}
		}	
			
		/// <summary>
        /// customrollupfieldmoney
        /// </summary>
		[DisplayName("Custom Rollup Field (Money)")]
		[AttributeLogicalName("customrollupfieldmoney")]
		public decimal? CustomRollupFieldMoney
		{	
			get { return GetAttributeValue<Money>("customrollupfieldmoney")?.Value; }
			set 
			{ 
				if(value == CustomRollupFieldMoney) return;

				Money moneyValue = null;
				if(value != null) moneyValue = new Money(value.Value);
				SetAttributeValue("customrollupfieldmoney", moneyValue);  
			}
		}

		/// <summary>
        /// customrollupfieldstring
        /// </summary>
		[DisplayName("Custom Rollup Field")]
		[AttributeLogicalName("customrollupfieldstring")]
		public string CustomRollupField
		{	
			get { return GetAttributeValue<string>("customrollupfieldstring"); }
			set
			{ 
				if(value == CustomRollupField) return;
				SetAttributeValue("customrollupfieldstring", value);
			}
		}	
			
		/// <summary>
        /// depth
        /// </summary>
		[DisplayName("Depth")]
		[AttributeLogicalName("depth")]
		public int? Depth
		{	
			get { return GetAttributeValue<int?>("depth"); }
			set
			{ 
				if(value == Depth) return;
				SetAttributeValue("depth", value);
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
		[DisplayName("Entity Image Id")]
		[AttributeLogicalName("entityimageid")]
		public Guid EntityImageId
		{	
			get { return GetAttributeValue<Guid>("entityimageid"); }
			set
			{ 
				if(value == EntityImageId) return;
				SetAttributeValue("entityimageid", value);
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
        /// fiscalperiod
        /// </summary>
		[DisplayName("Fiscal Period")]
		[AttributeLogicalName("fiscalperiod")]
		public egFiscalPeriod? FiscalPeriod
		{	
			get 
			{ 
				var optionSetValue = GetAttributeValue<OptionSetValue>("fiscalperiod");
				if (optionSetValue != null) return (egFiscalPeriod)optionSetValue.Value;
				else return null;
			}
			set 
			{ 
				if(value == FiscalPeriod) return;

				OptionSetValue optionSetValue = null;
				if(value != null) optionSetValue = new OptionSetValue((int)value);
				SetAttributeValue("fiscalperiod", optionSetValue); 
			}
		}

		/// <summary>
        /// fiscalyear
        /// </summary>
		[DisplayName("Fiscal Year")]
		[AttributeLogicalName("fiscalyear")]
		public egFiscalYear? FiscalYear
		{	
			get 
			{ 
				var optionSetValue = GetAttributeValue<OptionSetValue>("fiscalyear");
				if (optionSetValue != null) return (egFiscalYear)optionSetValue.Value;
				else return null;
			}
			set 
			{ 
				if(value == FiscalYear) return;

				OptionSetValue optionSetValue = null;
				if(value != null) optionSetValue = new OptionSetValue((int)value);
				SetAttributeValue("fiscalyear", optionSetValue); 
			}
		}

		/// <summary>
        /// goalenddate
        /// </summary>
		[DisplayName("To")]
		[AttributeLogicalName("goalenddate")]
		public DateTime? To
		{	
			get { return GetAttributeValue<DateTime?>("goalenddate"); }
			set
			{ 
				if(value == To) return;
				SetAttributeValue("goalenddate", value);
			}
		}	
			
		/// <summary>
        /// goalid
        /// </summary>
		[DisplayName("Goal")]
		[AttributeLogicalName("goalid")]
		public override Guid Id
		{
			get => base.Id;
			set { base.Id = value; SetAttributeValue("goalid", value); }
		}

							/// <summary>
        /// goalownerid
        /// </summary>
		[DisplayName("Goal Owner")]
		[AttributeLogicalName("goalownerid")]
		public EntityReference GoalOwner
		{	
			get { return GetAttributeValue<EntityReference>("goalownerid"); }
			set
			{ 
				if(value == GoalOwner) return;
				SetAttributeValue("goalownerid", value);
			}
		}	
			
		/// <summary>
        /// goalowneridname
        /// </summary>
		[DisplayName("goalowneridname")]
		[AttributeLogicalName("goalowneridname")]
		public string Goalowneridname
		{	
			get { return GetAttributeValue<string>("goalowneridname"); }
			set
			{ 
				if(value == Goalowneridname) return;
				SetAttributeValue("goalowneridname", value);
			}
		}	
			
		/// <summary>
        /// goalowneridtype
        /// </summary>
		[DisplayName("Goal Owner Type")]
		[AttributeLogicalName("goalowneridtype")]
		public string GoalOwnerType
		{	
			get { return GetAttributeValue<string>("goalowneridtype"); }
			set
			{ 
				if(value == GoalOwnerType) return;
				SetAttributeValue("goalowneridtype", value);
			}
		}	
			
		/// <summary>
        /// goalowneridyominame
        /// </summary>
		[DisplayName("goalowneridyominame")]
		[AttributeLogicalName("goalowneridyominame")]
		public string Goalowneridyominame
		{	
			get { return GetAttributeValue<string>("goalowneridyominame"); }
			set
			{ 
				if(value == Goalowneridyominame) return;
				SetAttributeValue("goalowneridyominame", value);
			}
		}	
			
		/// <summary>
        /// goalstartdate
        /// </summary>
		[DisplayName("From")]
		[AttributeLogicalName("goalstartdate")]
		public DateTime? From
		{	
			get { return GetAttributeValue<DateTime?>("goalstartdate"); }
			set
			{ 
				if(value == From) return;
				SetAttributeValue("goalstartdate", value);
			}
		}	
			
		/// <summary>
        /// goalwitherrorid
        /// </summary>
		[DisplayName("Goal With Error")]
		[AttributeLogicalName("goalwitherrorid")]
		public EntityReference GoalWithError
		{	
			get { return GetAttributeValue<EntityReference>("goalwitherrorid"); }
			set
			{ 
				if(value == GoalWithError) return;
				SetAttributeValue("goalwitherrorid", value);
			}
		}	
			
		/// <summary>
        /// goalwitherroridname
        /// </summary>
		[DisplayName("goalwitherroridname")]
		[AttributeLogicalName("goalwitherroridname")]
		public string Goalwitherroridname
		{	
			get { return GetAttributeValue<string>("goalwitherroridname"); }
			set
			{ 
				if(value == Goalwitherroridname) return;
				SetAttributeValue("goalwitherroridname", value);
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
        /// inprogressdecimal
        /// </summary>
		[DisplayName("In-progress (Decimal)")]
		[AttributeLogicalName("inprogressdecimal")]
		public decimal? InprogressDecimal
		{	
			get { return GetAttributeValue<decimal?>("inprogressdecimal"); }
			set
			{ 
				if(value == InprogressDecimal) return;
				SetAttributeValue("inprogressdecimal", value);
			}
		}	
			
		/// <summary>
        /// inprogressinteger
        /// </summary>
		[DisplayName("In-progress (Integer)")]
		[AttributeLogicalName("inprogressinteger")]
		public int? InprogressInteger
		{	
			get { return GetAttributeValue<int?>("inprogressinteger"); }
			set
			{ 
				if(value == InprogressInteger) return;
				SetAttributeValue("inprogressinteger", value);
			}
		}	
			
		/// <summary>
        /// inprogressmoney
        /// </summary>
		[DisplayName("In-progress (Money)")]
		[AttributeLogicalName("inprogressmoney")]
		public decimal? InprogressMoney
		{	
			get { return GetAttributeValue<Money>("inprogressmoney")?.Value; }
			set 
			{ 
				if(value == InprogressMoney) return;

				Money moneyValue = null;
				if(value != null) moneyValue = new Money(value.Value);
				SetAttributeValue("inprogressmoney", moneyValue);  
			}
		}

		/// <summary>
        /// inprogressstring
        /// </summary>
		[DisplayName("In-Progress")]
		[AttributeLogicalName("inprogressstring")]
		public string InProgress
		{	
			get { return GetAttributeValue<string>("inprogressstring"); }
			set
			{ 
				if(value == InProgress) return;
				SetAttributeValue("inprogressstring", value);
			}
		}	
			
		/// <summary>
        /// isamount
        /// </summary>
		[DisplayName("Metric Type")]
		[AttributeLogicalName("isamount")]
		public bool? MetricType
		{	
			get { return GetAttributeValue<bool?>("isamount"); }
			set
			{ 
				if(value == MetricType) return;
				SetAttributeValue("isamount", value);
			}
		}	
			
		/// <summary>
        /// isfiscalperiodgoal
        /// </summary>
		[DisplayName("Goal Period Type")]
		[AttributeLogicalName("isfiscalperiodgoal")]
		public bool? GoalPeriodType
		{	
			get { return GetAttributeValue<bool?>("isfiscalperiodgoal"); }
			set
			{ 
				if(value == GoalPeriodType) return;
				SetAttributeValue("isfiscalperiodgoal", value);
			}
		}	
			
		/// <summary>
        /// isoverridden
        /// </summary>
		[DisplayName("Overridden")]
		[AttributeLogicalName("isoverridden")]
		public bool? Overridden
		{	
			get { return GetAttributeValue<bool?>("isoverridden"); }
			set
			{ 
				if(value == Overridden) return;
				SetAttributeValue("isoverridden", value);
			}
		}	
			
		/// <summary>
        /// isoverride
        /// </summary>
		[DisplayName("Override")]
		[AttributeLogicalName("isoverride")]
		public bool? Override
		{	
			get { return GetAttributeValue<bool?>("isoverride"); }
			set
			{ 
				if(value == Override) return;
				SetAttributeValue("isoverride", value);
			}
		}	
			
		/// <summary>
        /// lastrolledupdate
        /// </summary>
		[DisplayName("Last Rolled Up Date")]
		[AttributeLogicalName("lastrolledupdate")]
		public DateTime? LastRolledUpDate
		{	
			get { return GetAttributeValue<DateTime?>("lastrolledupdate"); }
			set
			{ 
				if(value == LastRolledUpDate) return;
				SetAttributeValue("lastrolledupdate", value);
			}
		}	
			
		/// <summary>
        /// metricid
        /// </summary>
		[DisplayName("Goal Metric")]
		[AttributeLogicalName("metricid")]
		public EntityReference GoalMetric
		{	
			get { return GetAttributeValue<EntityReference>("metricid"); }
			set
			{ 
				if(value == GoalMetric) return;
				SetAttributeValue("metricid", value);
			}
		}	
			
		/// <summary>
        /// metricidname
        /// </summary>
		[DisplayName("metricidname")]
		[AttributeLogicalName("metricidname")]
		public string Metricidname
		{	
			get { return GetAttributeValue<string>("metricidname"); }
			set
			{ 
				if(value == Metricidname) return;
				SetAttributeValue("metricidname", value);
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
		[DisplayName("Manager")]
		[AttributeLogicalName("ownerid")]
		public EntityReference Manager
		{	
			get { return GetAttributeValue<EntityReference>("ownerid"); }
			set
			{ 
				if(value == Manager) return;
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
        /// parentgoalid
        /// </summary>
		[DisplayName("Parent Goal")]
		[AttributeLogicalName("parentgoalid")]
		public EntityReference ParentGoal
		{	
			get { return GetAttributeValue<EntityReference>("parentgoalid"); }
			set
			{ 
				if(value == ParentGoal) return;
				SetAttributeValue("parentgoalid", value);
			}
		}	
			
		/// <summary>
        /// parentgoalidname
        /// </summary>
		[DisplayName("parentgoalidname")]
		[AttributeLogicalName("parentgoalidname")]
		public string Parentgoalidname
		{	
			get { return GetAttributeValue<string>("parentgoalidname"); }
			set
			{ 
				if(value == Parentgoalidname) return;
				SetAttributeValue("parentgoalidname", value);
			}
		}	
			
		/// <summary>
        /// percentage
        /// </summary>
		[DisplayName("Percentage Achieved")]
		[AttributeLogicalName("percentage")]
		public decimal? PercentageAchieved
		{	
			get { return GetAttributeValue<decimal?>("percentage"); }
			set
			{ 
				if(value == PercentageAchieved) return;
				SetAttributeValue("percentage", value);
			}
		}	
			
		/// <summary>
        /// rolluperrorcode
        /// </summary>
		[DisplayName("Rollup Error Code")]
		[AttributeLogicalName("rolluperrorcode")]
		public int? RollupErrorCode
		{	
			get { return GetAttributeValue<int?>("rolluperrorcode"); }
			set
			{ 
				if(value == RollupErrorCode) return;
				SetAttributeValue("rolluperrorcode", value);
			}
		}	
			
		/// <summary>
        /// rolluponlyfromchildgoals
        /// </summary>
		[DisplayName("Roll Up Only from Child Goals")]
		[AttributeLogicalName("rolluponlyfromchildgoals")]
		public bool? RollUpOnlyFromChildGoals
		{	
			get { return GetAttributeValue<bool?>("rolluponlyfromchildgoals"); }
			set
			{ 
				if(value == RollUpOnlyFromChildGoals) return;
				SetAttributeValue("rolluponlyfromchildgoals", value);
			}
		}	
			
		/// <summary>
        /// rollupqueryactualdecimalid
        /// </summary>
		[DisplayName("Rollup Query - Actual(Decimal)")]
		[AttributeLogicalName("rollupqueryactualdecimalid")]
		public EntityReference RollupQueryActualDecimal
		{	
			get { return GetAttributeValue<EntityReference>("rollupqueryactualdecimalid"); }
			set
			{ 
				if(value == RollupQueryActualDecimal) return;
				SetAttributeValue("rollupqueryactualdecimalid", value);
			}
		}	
			
		/// <summary>
        /// rollupqueryactualdecimalidname
        /// </summary>
		[DisplayName("rollupqueryactualdecimalidname")]
		[AttributeLogicalName("rollupqueryactualdecimalidname")]
		public string Rollupqueryactualdecimalidname
		{	
			get { return GetAttributeValue<string>("rollupqueryactualdecimalidname"); }
			set
			{ 
				if(value == Rollupqueryactualdecimalidname) return;
				SetAttributeValue("rollupqueryactualdecimalidname", value);
			}
		}	
			
		/// <summary>
        /// rollupqueryactualintegerid
        /// </summary>
		[DisplayName("Rollup Query - Actual(Integer)")]
		[AttributeLogicalName("rollupqueryactualintegerid")]
		public EntityReference RollupQueryActualInteger
		{	
			get { return GetAttributeValue<EntityReference>("rollupqueryactualintegerid"); }
			set
			{ 
				if(value == RollupQueryActualInteger) return;
				SetAttributeValue("rollupqueryactualintegerid", value);
			}
		}	
			
		/// <summary>
        /// rollupqueryactualintegeridname
        /// </summary>
		[DisplayName("rollupqueryactualintegeridname")]
		[AttributeLogicalName("rollupqueryactualintegeridname")]
		public string Rollupqueryactualintegeridname
		{	
			get { return GetAttributeValue<string>("rollupqueryactualintegeridname"); }
			set
			{ 
				if(value == Rollupqueryactualintegeridname) return;
				SetAttributeValue("rollupqueryactualintegeridname", value);
			}
		}	
			
		/// <summary>
        /// rollupqueryactualmoneyid
        /// </summary>
		[DisplayName("Rollup Query - Actual(Money)")]
		[AttributeLogicalName("rollupqueryactualmoneyid")]
		public EntityReference RollupQueryActualMoney
		{	
			get { return GetAttributeValue<EntityReference>("rollupqueryactualmoneyid"); }
			set
			{ 
				if(value == RollupQueryActualMoney) return;
				SetAttributeValue("rollupqueryactualmoneyid", value);
			}
		}	
			
		/// <summary>
        /// rollupqueryactualmoneyidname
        /// </summary>
		[DisplayName("rollupqueryactualmoneyidname")]
		[AttributeLogicalName("rollupqueryactualmoneyidname")]
		public string Rollupqueryactualmoneyidname
		{	
			get { return GetAttributeValue<string>("rollupqueryactualmoneyidname"); }
			set
			{ 
				if(value == Rollupqueryactualmoneyidname) return;
				SetAttributeValue("rollupqueryactualmoneyidname", value);
			}
		}	
			
		/// <summary>
        /// rollupquerycustomdecimalid
        /// </summary>
		[DisplayName("Rollup Query - Custom Rollup Field (Decimal)")]
		[AttributeLogicalName("rollupquerycustomdecimalid")]
		public EntityReference RollupQueryCustomRollupFieldDecimal
		{	
			get { return GetAttributeValue<EntityReference>("rollupquerycustomdecimalid"); }
			set
			{ 
				if(value == RollupQueryCustomRollupFieldDecimal) return;
				SetAttributeValue("rollupquerycustomdecimalid", value);
			}
		}	
			
		/// <summary>
        /// rollupquerycustomdecimalidname
        /// </summary>
		[DisplayName("rollupquerycustomdecimalidname")]
		[AttributeLogicalName("rollupquerycustomdecimalidname")]
		public string Rollupquerycustomdecimalidname
		{	
			get { return GetAttributeValue<string>("rollupquerycustomdecimalidname"); }
			set
			{ 
				if(value == Rollupquerycustomdecimalidname) return;
				SetAttributeValue("rollupquerycustomdecimalidname", value);
			}
		}	
			
		/// <summary>
        /// rollupquerycustomintegerid
        /// </summary>
		[DisplayName("Rollup Query - Custom Rollup Field (Integer)")]
		[AttributeLogicalName("rollupquerycustomintegerid")]
		public EntityReference RollupQueryCustomRollupFieldInteger
		{	
			get { return GetAttributeValue<EntityReference>("rollupquerycustomintegerid"); }
			set
			{ 
				if(value == RollupQueryCustomRollupFieldInteger) return;
				SetAttributeValue("rollupquerycustomintegerid", value);
			}
		}	
			
		/// <summary>
        /// rollupquerycustomintegeridname
        /// </summary>
		[DisplayName("rollupquerycustomintegeridname")]
		[AttributeLogicalName("rollupquerycustomintegeridname")]
		public string Rollupquerycustomintegeridname
		{	
			get { return GetAttributeValue<string>("rollupquerycustomintegeridname"); }
			set
			{ 
				if(value == Rollupquerycustomintegeridname) return;
				SetAttributeValue("rollupquerycustomintegeridname", value);
			}
		}	
			
		/// <summary>
        /// rollupquerycustommoneyid
        /// </summary>
		[DisplayName("Rollup Query - Custom Rollup Field (Money)")]
		[AttributeLogicalName("rollupquerycustommoneyid")]
		public EntityReference RollupQueryCustomRollupFieldMoney
		{	
			get { return GetAttributeValue<EntityReference>("rollupquerycustommoneyid"); }
			set
			{ 
				if(value == RollupQueryCustomRollupFieldMoney) return;
				SetAttributeValue("rollupquerycustommoneyid", value);
			}
		}	
			
		/// <summary>
        /// rollupquerycustommoneyidname
        /// </summary>
		[DisplayName("rollupquerycustommoneyidname")]
		[AttributeLogicalName("rollupquerycustommoneyidname")]
		public string Rollupquerycustommoneyidname
		{	
			get { return GetAttributeValue<string>("rollupquerycustommoneyidname"); }
			set
			{ 
				if(value == Rollupquerycustommoneyidname) return;
				SetAttributeValue("rollupquerycustommoneyidname", value);
			}
		}	
			
		/// <summary>
        /// rollupqueryinprogressdecimalid
        /// </summary>
		[DisplayName("Rollup Query - In-progress(Decimal)")]
		[AttributeLogicalName("rollupqueryinprogressdecimalid")]
		public EntityReference RollupQueryInprogressDecimal
		{	
			get { return GetAttributeValue<EntityReference>("rollupqueryinprogressdecimalid"); }
			set
			{ 
				if(value == RollupQueryInprogressDecimal) return;
				SetAttributeValue("rollupqueryinprogressdecimalid", value);
			}
		}	
			
		/// <summary>
        /// rollupqueryinprogressdecimalidname
        /// </summary>
		[DisplayName("rollupqueryinprogressdecimalidname")]
		[AttributeLogicalName("rollupqueryinprogressdecimalidname")]
		public string Rollupqueryinprogressdecimalidname
		{	
			get { return GetAttributeValue<string>("rollupqueryinprogressdecimalidname"); }
			set
			{ 
				if(value == Rollupqueryinprogressdecimalidname) return;
				SetAttributeValue("rollupqueryinprogressdecimalidname", value);
			}
		}	
			
		/// <summary>
        /// rollupqueryinprogressintegerid
        /// </summary>
		[DisplayName("Rollup Query - In-progress(Integer)")]
		[AttributeLogicalName("rollupqueryinprogressintegerid")]
		public EntityReference RollupQueryInprogressInteger
		{	
			get { return GetAttributeValue<EntityReference>("rollupqueryinprogressintegerid"); }
			set
			{ 
				if(value == RollupQueryInprogressInteger) return;
				SetAttributeValue("rollupqueryinprogressintegerid", value);
			}
		}	
			
		/// <summary>
        /// rollupqueryinprogressintegeridname
        /// </summary>
		[DisplayName("rollupqueryinprogressintegeridname")]
		[AttributeLogicalName("rollupqueryinprogressintegeridname")]
		public string Rollupqueryinprogressintegeridname
		{	
			get { return GetAttributeValue<string>("rollupqueryinprogressintegeridname"); }
			set
			{ 
				if(value == Rollupqueryinprogressintegeridname) return;
				SetAttributeValue("rollupqueryinprogressintegeridname", value);
			}
		}	
			
		/// <summary>
        /// rollupqueryinprogressmoneyid
        /// </summary>
		[DisplayName("Rollup Query - In-progress(Money)")]
		[AttributeLogicalName("rollupqueryinprogressmoneyid")]
		public EntityReference RollupQueryInprogressMoney
		{	
			get { return GetAttributeValue<EntityReference>("rollupqueryinprogressmoneyid"); }
			set
			{ 
				if(value == RollupQueryInprogressMoney) return;
				SetAttributeValue("rollupqueryinprogressmoneyid", value);
			}
		}	
			
		/// <summary>
        /// rollupqueryinprogressmoneyidname
        /// </summary>
		[DisplayName("rollupqueryinprogressmoneyidname")]
		[AttributeLogicalName("rollupqueryinprogressmoneyidname")]
		public string Rollupqueryinprogressmoneyidname
		{	
			get { return GetAttributeValue<string>("rollupqueryinprogressmoneyidname"); }
			set
			{ 
				if(value == Rollupqueryinprogressmoneyidname) return;
				SetAttributeValue("rollupqueryinprogressmoneyidname", value);
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
        /// stretchtargetdecimal
        /// </summary>
		[DisplayName("Stretch Target (Decimal)")]
		[AttributeLogicalName("stretchtargetdecimal")]
		public decimal? StretchTargetDecimal
		{	
			get { return GetAttributeValue<decimal?>("stretchtargetdecimal"); }
			set
			{ 
				if(value == StretchTargetDecimal) return;
				SetAttributeValue("stretchtargetdecimal", value);
			}
		}	
			
		/// <summary>
        /// stretchtargetinteger
        /// </summary>
		[DisplayName("Stretch Target (Integer)")]
		[AttributeLogicalName("stretchtargetinteger")]
		public int? StretchTargetInteger
		{	
			get { return GetAttributeValue<int?>("stretchtargetinteger"); }
			set
			{ 
				if(value == StretchTargetInteger) return;
				SetAttributeValue("stretchtargetinteger", value);
			}
		}	
			
		/// <summary>
        /// stretchtargetmoney
        /// </summary>
		[DisplayName("Stretch Target (Money)")]
		[AttributeLogicalName("stretchtargetmoney")]
		public decimal? StretchTargetMoney
		{	
			get { return GetAttributeValue<Money>("stretchtargetmoney")?.Value; }
			set 
			{ 
				if(value == StretchTargetMoney) return;

				Money moneyValue = null;
				if(value != null) moneyValue = new Money(value.Value);
				SetAttributeValue("stretchtargetmoney", moneyValue);  
			}
		}

		/// <summary>
        /// stretchtargetstring
        /// </summary>
		[DisplayName("Stretched Target")]
		[AttributeLogicalName("stretchtargetstring")]
		public string StretchedTarget
		{	
			get { return GetAttributeValue<string>("stretchtargetstring"); }
			set
			{ 
				if(value == StretchedTarget) return;
				SetAttributeValue("stretchtargetstring", value);
			}
		}	
			
		/// <summary>
        /// targetdecimal
        /// </summary>
		[DisplayName("Target (Decimal)")]
		[AttributeLogicalName("targetdecimal")]
		public decimal? TargetDecimal
		{	
			get { return GetAttributeValue<decimal?>("targetdecimal"); }
			set
			{ 
				if(value == TargetDecimal) return;
				SetAttributeValue("targetdecimal", value);
			}
		}	
			
		/// <summary>
        /// targetinteger
        /// </summary>
		[DisplayName("Target (Integer)")]
		[AttributeLogicalName("targetinteger")]
		public int? TargetInteger
		{	
			get { return GetAttributeValue<int?>("targetinteger"); }
			set
			{ 
				if(value == TargetInteger) return;
				SetAttributeValue("targetinteger", value);
			}
		}	
			
		/// <summary>
        /// targetmoney
        /// </summary>
		[DisplayName("Target (Money)")]
		[AttributeLogicalName("targetmoney")]
		public decimal? TargetMoney
		{	
			get { return GetAttributeValue<Money>("targetmoney")?.Value; }
			set 
			{ 
				if(value == TargetMoney) return;

				Money moneyValue = null;
				if(value != null) moneyValue = new Money(value.Value);
				SetAttributeValue("targetmoney", moneyValue);  
			}
		}

		/// <summary>
        /// targetstring
        /// </summary>
		[DisplayName("Target")]
		[AttributeLogicalName("targetstring")]
		public string Target
		{	
			get { return GetAttributeValue<string>("targetstring"); }
			set
			{ 
				if(value == Target) return;
				SetAttributeValue("targetstring", value);
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
        /// title
        /// </summary>
		[DisplayName("Name")]
		[AttributeLogicalName("title")]
		public string Name
		{	
			get { return GetAttributeValue<string>("title"); }
			set
			{ 
				if(value == Name) return;
				SetAttributeValue("title", value);
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
        /// treeid
        /// </summary>
		[DisplayName("Tree ID")]
		[AttributeLogicalName("treeid")]
		public Guid TreeId
		{	
			get { return GetAttributeValue<Guid>("treeid"); }
			set
			{ 
				if(value == TreeId) return;
				SetAttributeValue("treeid", value);
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
        /// 1:N Get entities for 'Goal_Annotation'
        /// </summary>
		[RelationshipSchemaName("Goal_Annotation")]
		public IEnumerable<Note> GoalAnnotation
		{
			get { return GetRelatedEntities<Note>("Goal_Annotation", null); }
			set { SetRelatedEntities("Goal_Annotation", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'Goal_AsyncOperations'
        /// </summary>
		[RelationshipSchemaName("Goal_AsyncOperations")]
		public IEnumerable<SystemJob> GoalAsyncOperations
		{
			get { return GetRelatedEntities<SystemJob>("Goal_AsyncOperations", null); }
			set { SetRelatedEntities("Goal_AsyncOperations", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'goal_connections1'
        /// </summary>
		[RelationshipSchemaName("goal_connections1")]
		public IEnumerable<Connection> GoalConnections1
		{
			get { return GetRelatedEntities<Connection>("goal_connections1", null); }
			set { SetRelatedEntities("goal_connections1", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'goal_connections2'
        /// </summary>
		[RelationshipSchemaName("goal_connections2")]
		public IEnumerable<Connection> GoalConnections2
		{
			get { return GetRelatedEntities<Connection>("goal_connections2", null); }
			set { SetRelatedEntities("goal_connections2", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'Goal_DuplicateBaseRecord'
        /// </summary>
		[RelationshipSchemaName("Goal_DuplicateBaseRecord")]
		public IEnumerable<DuplicateRecord> GoalDuplicateBaseRecord
		{
			get { return GetRelatedEntities<DuplicateRecord>("Goal_DuplicateBaseRecord", null); }
			set { SetRelatedEntities("Goal_DuplicateBaseRecord", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'Goal_DuplicateMatchingRecord'
        /// </summary>
		[RelationshipSchemaName("Goal_DuplicateMatchingRecord")]
		public IEnumerable<DuplicateRecord> GoalDuplicateMatchingRecord
		{
			get { return GetRelatedEntities<DuplicateRecord>("Goal_DuplicateMatchingRecord", null); }
			set { SetRelatedEntities("Goal_DuplicateMatchingRecord", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'goal_parent_goal'
        /// </summary>
		[RelationshipSchemaName("goal_parent_goal")]
		public IEnumerable<Goal> GoalParentGoal
		{
			get { return GetRelatedEntities<Goal>("goal_parent_goal", null); }
			set { SetRelatedEntities("goal_parent_goal", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'goal_principalobjectattributeaccess'
        /// </summary>
		[RelationshipSchemaName("goal_principalobjectattributeaccess")]
		public IEnumerable<FieldSharing> GoalPrincipalobjectattributeaccess
		{
			get { return GetRelatedEntities<FieldSharing>("goal_principalobjectattributeaccess", null); }
			set { SetRelatedEntities("goal_principalobjectattributeaccess", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'Goal_ProcessSessions'
        /// </summary>
		[RelationshipSchemaName("Goal_ProcessSessions")]
		public IEnumerable<ProcessSession> GoalProcessSessions
		{
			get { return GetRelatedEntities<ProcessSession>("Goal_ProcessSessions", null); }
			set { SetRelatedEntities("Goal_ProcessSessions", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'Goal_RollupError_Goal'
        /// </summary>
		[RelationshipSchemaName("Goal_RollupError_Goal")]
		public IEnumerable<Goal> GoalRollupErrorGoal
		{
			get { return GetRelatedEntities<Goal>("Goal_RollupError_Goal", null); }
			set { SetRelatedEntities("Goal_RollupError_Goal", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'Goal_SyncErrors'
        /// </summary>
		[RelationshipSchemaName("Goal_SyncErrors")]
		public IEnumerable<SyncError> GoalSyncErrors
		{
			get { return GetRelatedEntities<SyncError>("Goal_SyncErrors", null); }
			set { SetRelatedEntities("Goal_SyncErrors", null, value); }
		}
		#endregion

		#region Actions
		#endregion

		#region OptionSetEnums
		public enum egFiscalPeriod
		{	
		
			[Label("Quarter 1")]
			[Description(@"")]
			Quarter1 = 1, 
		
			[Label("Quarter 2")]
			[Description(@"")]
			Quarter2 = 2, 
		
			[Label("Quarter 3")]
			[Description(@"")]
			Quarter3 = 3, 
		
			[Label("Quarter 4")]
			[Description(@"")]
			Quarter4 = 4, 
		
			[Label("January")]
			[Description(@"")]
			January = 101, 
		
			[Label("February")]
			[Description(@"")]
			February = 102, 
		
			[Label("March")]
			[Description(@"")]
			March = 103, 
		
			[Label("April")]
			[Description(@"")]
			April = 104, 
		
			[Label("May")]
			[Description(@"")]
			May = 105, 
		
			[Label("June")]
			[Description(@"")]
			June = 106, 
		
			[Label("July")]
			[Description(@"")]
			July = 107, 
		
			[Label("August")]
			[Description(@"")]
			August = 108, 
		
			[Label("September")]
			[Description(@"")]
			September = 109, 
		
			[Label("October")]
			[Description(@"")]
			October = 110, 
		
			[Label("November")]
			[Description(@"")]
			November = 111, 
		
			[Label("December")]
			[Description(@"")]
			December = 112, 
		
			[Label("Semester 1")]
			[Description(@"")]
			Semester1 = 201, 
		
			[Label("Semester 2")]
			[Description(@"")]
			Semester2 = 202, 
		
			[Label("Annual")]
			[Description(@"")]
			Annual = 301, 
		
			[Label("P1")]
			[Description(@"")]
			P1 = 401, 
		
			[Label("P2")]
			[Description(@"")]
			P2 = 402, 
		
			[Label("P3")]
			[Description(@"")]
			P3 = 403, 
		
			[Label("P4")]
			[Description(@"")]
			P4 = 404, 
		
			[Label("P5")]
			[Description(@"")]
			P5 = 405, 
		
			[Label("P6")]
			[Description(@"")]
			P6 = 406, 
		
			[Label("P7")]
			[Description(@"")]
			P7 = 407, 
		
			[Label("P8")]
			[Description(@"")]
			P8 = 408, 
		
			[Label("P9")]
			[Description(@"")]
			P9 = 409, 
		
			[Label("P10")]
			[Description(@"")]
			P10 = 410, 
		
			[Label("P11")]
			[Description(@"")]
			P11 = 411, 
		
			[Label("P12")]
			[Description(@"")]
			P12 = 412, 
		
			[Label("P13")]
			[Description(@"")]
			P13 = 413, 
		}
		
		public enum egFiscalYear
		{	
		
			[Label("FY2038")]
			[Description(@"")]
			FY2038 = 2038, 
		
			[Label("FY2037")]
			[Description(@"")]
			FY2037 = 2037, 
		
			[Label("FY2036")]
			[Description(@"")]
			FY2036 = 2036, 
		
			[Label("FY2035")]
			[Description(@"")]
			FY2035 = 2035, 
		
			[Label("FY2034")]
			[Description(@"")]
			FY2034 = 2034, 
		
			[Label("FY2033")]
			[Description(@"")]
			FY2033 = 2033, 
		
			[Label("FY2032")]
			[Description(@"")]
			FY2032 = 2032, 
		
			[Label("FY2031")]
			[Description(@"")]
			FY2031 = 2031, 
		
			[Label("FY2030")]
			[Description(@"")]
			FY2030 = 2030, 
		
			[Label("FY2029")]
			[Description(@"")]
			FY2029 = 2029, 
		
			[Label("FY2028")]
			[Description(@"")]
			FY2028 = 2028, 
		
			[Label("FY2027")]
			[Description(@"")]
			FY2027 = 2027, 
		
			[Label("FY2026")]
			[Description(@"")]
			FY2026 = 2026, 
		
			[Label("FY2025")]
			[Description(@"")]
			FY2025 = 2025, 
		
			[Label("FY2024")]
			[Description(@"")]
			FY2024 = 2024, 
		
			[Label("FY2023")]
			[Description(@"")]
			FY2023 = 2023, 
		
			[Label("FY2022")]
			[Description(@"")]
			FY2022 = 2022, 
		
			[Label("FY2021")]
			[Description(@"")]
			FY2021 = 2021, 
		
			[Label("FY2020")]
			[Description(@"")]
			FY2020 = 2020, 
		
			[Label("FY2019")]
			[Description(@"")]
			FY2019 = 2019, 
		
			[Label("FY2018")]
			[Description(@"")]
			FY2018 = 2018, 
		
			[Label("FY2017")]
			[Description(@"")]
			FY2017 = 2017, 
		
			[Label("FY2016")]
			[Description(@"")]
			FY2016 = 2016, 
		
			[Label("FY2015")]
			[Description(@"")]
			FY2015 = 2015, 
		
			[Label("FY2014")]
			[Description(@"")]
			FY2014 = 2014, 
		
			[Label("FY2013")]
			[Description(@"")]
			FY2013 = 2013, 
		
			[Label("FY2012")]
			[Description(@"")]
			FY2012 = 2012, 
		
			[Label("FY2011")]
			[Description(@"")]
			FY2011 = 2011, 
		
			[Label("FY2010")]
			[Description(@"")]
			FY2010 = 2010, 
		
			[Label("FY2009")]
			[Description(@"")]
			FY2009 = 2009, 
		
			[Label("FY2008")]
			[Description(@"")]
			FY2008 = 2008, 
		
			[Label("FY2007")]
			[Description(@"")]
			FY2007 = 2007, 
		
			[Label("FY2006")]
			[Description(@"")]
			FY2006 = 2006, 
		
			[Label("FY2005")]
			[Description(@"")]
			FY2005 = 2005, 
		
			[Label("FY2004")]
			[Description(@"")]
			FY2004 = 2004, 
		
			[Label("FY2003")]
			[Description(@"")]
			FY2003 = 2003, 
		
			[Label("FY2002")]
			[Description(@"")]
			FY2002 = 2002, 
		
			[Label("FY2001")]
			[Description(@"")]
			FY2001 = 2001, 
		
			[Label("FY2000")]
			[Description(@"")]
			FY2000 = 2000, 
		
			[Label("FY1999")]
			[Description(@"")]
			FY1999 = 1999, 
		
			[Label("FY1998")]
			[Description(@"")]
			FY1998 = 1998, 
		
			[Label("FY1997")]
			[Description(@"")]
			FY1997 = 1997, 
		
			[Label("FY1996")]
			[Description(@"")]
			FY1996 = 1996, 
		
			[Label("FY1995")]
			[Description(@"")]
			FY1995 = 1995, 
		
			[Label("FY1994")]
			[Description(@"")]
			FY1994 = 1994, 
		
			[Label("FY1993")]
			[Description(@"")]
			FY1993 = 1993, 
		
			[Label("FY1992")]
			[Description(@"")]
			FY1992 = 1992, 
		
			[Label("FY1991")]
			[Description(@"")]
			FY1991 = 1991, 
		
			[Label("FY1990")]
			[Description(@"")]
			FY1990 = 1990, 
		
			[Label("FY1989")]
			[Description(@"")]
			FY1989 = 1989, 
		
			[Label("FY1988")]
			[Description(@"")]
			FY1988 = 1988, 
		
			[Label("FY1987")]
			[Description(@"")]
			FY1987 = 1987, 
		
			[Label("FY1986")]
			[Description(@"")]
			FY1986 = 1986, 
		
			[Label("FY1985")]
			[Description(@"")]
			FY1985 = 1985, 
		
			[Label("FY1984")]
			[Description(@"")]
			FY1984 = 1984, 
		
			[Label("FY1983")]
			[Description(@"")]
			FY1983 = 1983, 
		
			[Label("FY1982")]
			[Description(@"")]
			FY1982 = 1982, 
		
			[Label("FY1981")]
			[Description(@"")]
			FY1981 = 1981, 
		
			[Label("FY1980")]
			[Description(@"")]
			FY1980 = 1980, 
		
			[Label("FY1979")]
			[Description(@"")]
			FY1979 = 1979, 
		
			[Label("FY1978")]
			[Description(@"")]
			FY1978 = 1978, 
		
			[Label("FY1977")]
			[Description(@"")]
			FY1977 = 1977, 
		
			[Label("FY1976")]
			[Description(@"")]
			FY1976 = 1976, 
		
			[Label("FY1975")]
			[Description(@"")]
			FY1975 = 1975, 
		
			[Label("FY1974")]
			[Description(@"")]
			FY1974 = 1974, 
		
			[Label("FY1973")]
			[Description(@"")]
			FY1973 = 1973, 
		
			[Label("FY1972")]
			[Description(@"")]
			FY1972 = 1972, 
		
			[Label("FY1971")]
			[Description(@"")]
			FY1971 = 1971, 
		
			[Label("FY1970")]
			[Description(@"")]
			FY1970 = 1970, 
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
		
			[Label("Open")]
			[Description(@"")]
			Open_Active = 0, 
		
			[Label("Closed")]
			[Description(@"")]
			Closed_Inactive = 1, 
		
			[Label("Discarded")]
			[Description(@"")]
			Discarded_Inactive = 2, 
		}
		
		public enum egGoalType
		{	
		
			[Label("Money")]
			[Description(@"")]
			Money = 0, 
		
			[Label("Decimal")]
			[Description(@"")]
			Decimal = 1, 
		
			[Label("Integer")]
			[Description(@"")]
			Integer = 2, 
		}
		
		#endregion	

		#region Properties
		public static class Properties 
		{
			/// <summary>actualdecimal</summary>
			public const string ActualDecimal = "actualdecimal";

			/// <summary>actualinteger</summary>
			public const string ActualInteger = "actualinteger";

			/// <summary>actualmoney</summary>
			public const string ActualMoney = "actualmoney";

			/// <summary>actualstring</summary>
			public const string Actual = "actualstring";

			/// <summary>amountdatatype</summary>
			public const string AmountDataType = "amountdatatype";

			/// <summary>computedtargetasoftodaydecimal</summary>
			public const string TodaysTargetDecimal = "computedtargetasoftodaydecimal";

			/// <summary>computedtargetasoftodayinteger</summary>
			public const string TodaysTargetInteger = "computedtargetasoftodayinteger";

			/// <summary>computedtargetasoftodaymoney</summary>
			public const string TodaysTargetMoney = "computedtargetasoftodaymoney";

			/// <summary>computedtargetasoftodaypercentageachieved</summary>
			public const string TodaysTargetPercentageAchieved = "computedtargetasoftodaypercentageachieved";

			/// <summary>consideronlygoalownersrecords</summary>
			public const string RecordSetForRollup = "consideronlygoalownersrecords";

			/// <summary>createdby</summary>
			public const string CreatedBy = "createdby";

			/// <summary>createdbyname</summary>
			public const string Createdbyname = "createdbyname";

			/// <summary>createdon</summary>
			public const string CreatedOn = "createdon";

			/// <summary>createdonbehalfby</summary>
			public const string CreatedByDelegate = "createdonbehalfby";

			/// <summary>createdonbehalfbyname</summary>
			public const string Createdonbehalfbyname = "createdonbehalfbyname";

			/// <summary>createdonbehalfbyyominame</summary>
			public const string Createdonbehalfbyyominame = "createdonbehalfbyyominame";

			/// <summary>customrollupfielddecimal</summary>
			public const string CustomRollupFieldDecimal = "customrollupfielddecimal";

			/// <summary>customrollupfieldinteger</summary>
			public const string CustomRollupFieldInteger = "customrollupfieldinteger";

			/// <summary>customrollupfieldmoney</summary>
			public const string CustomRollupFieldMoney = "customrollupfieldmoney";

			/// <summary>customrollupfieldstring</summary>
			public const string CustomRollupField = "customrollupfieldstring";

			/// <summary>depth</summary>
			public const string Depth = "depth";

			/// <summary>entityimage_timestamp</summary>
			public const string EntityimageTimestamp = "entityimage_timestamp";

			/// <summary>entityimage_url</summary>
			public const string EntityimageUrl = "entityimage_url";

			/// <summary>entityimageid</summary>
			public const string EntityImageId = "entityimageid";

			/// <summary>exchangerate</summary>
			public const string ExchangeRate = "exchangerate";

			/// <summary>fiscalperiod</summary>
			public const string FiscalPeriod = "fiscalperiod";

			/// <summary>fiscalyear</summary>
			public const string FiscalYear = "fiscalyear";

			/// <summary>goalenddate</summary>
			public const string To = "goalenddate";

			/// <summary>goalid</summary>
			public const string GoalId = "goalid";

			/// <summary>goalownerid</summary>
			public const string GoalOwner = "goalownerid";

			/// <summary>goalowneridname</summary>
			public const string Goalowneridname = "goalowneridname";

			/// <summary>goalowneridtype</summary>
			public const string GoalOwnerType = "goalowneridtype";

			/// <summary>goalowneridyominame</summary>
			public const string Goalowneridyominame = "goalowneridyominame";

			/// <summary>goalstartdate</summary>
			public const string From = "goalstartdate";

			/// <summary>goalwitherrorid</summary>
			public const string GoalWithError = "goalwitherrorid";

			/// <summary>goalwitherroridname</summary>
			public const string Goalwitherroridname = "goalwitherroridname";

			/// <summary>importsequencenumber</summary>
			public const string ImportSequenceNumber = "importsequencenumber";

			/// <summary>inprogressdecimal</summary>
			public const string InprogressDecimal = "inprogressdecimal";

			/// <summary>inprogressinteger</summary>
			public const string InprogressInteger = "inprogressinteger";

			/// <summary>inprogressmoney</summary>
			public const string InprogressMoney = "inprogressmoney";

			/// <summary>inprogressstring</summary>
			public const string InProgress = "inprogressstring";

			/// <summary>isamount</summary>
			public const string MetricType = "isamount";

			/// <summary>isfiscalperiodgoal</summary>
			public const string GoalPeriodType = "isfiscalperiodgoal";

			/// <summary>isoverridden</summary>
			public const string Overridden = "isoverridden";

			/// <summary>isoverride</summary>
			public const string Override = "isoverride";

			/// <summary>lastrolledupdate</summary>
			public const string LastRolledUpDate = "lastrolledupdate";

			/// <summary>metricid</summary>
			public const string GoalMetric = "metricid";

			/// <summary>metricidname</summary>
			public const string Metricidname = "metricidname";

			/// <summary>modifiedby</summary>
			public const string ModifiedBy = "modifiedby";

			/// <summary>modifiedbyname</summary>
			public const string Modifiedbyname = "modifiedbyname";

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
			public const string Manager = "ownerid";

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

			/// <summary>parentgoalid</summary>
			public const string ParentGoal = "parentgoalid";

			/// <summary>parentgoalidname</summary>
			public const string Parentgoalidname = "parentgoalidname";

			/// <summary>percentage</summary>
			public const string PercentageAchieved = "percentage";

			/// <summary>rolluperrorcode</summary>
			public const string RollupErrorCode = "rolluperrorcode";

			/// <summary>rolluponlyfromchildgoals</summary>
			public const string RollUpOnlyFromChildGoals = "rolluponlyfromchildgoals";

			/// <summary>rollupqueryactualdecimalid</summary>
			public const string RollupQueryActualDecimal = "rollupqueryactualdecimalid";

			/// <summary>rollupqueryactualdecimalidname</summary>
			public const string Rollupqueryactualdecimalidname = "rollupqueryactualdecimalidname";

			/// <summary>rollupqueryactualintegerid</summary>
			public const string RollupQueryActualInteger = "rollupqueryactualintegerid";

			/// <summary>rollupqueryactualintegeridname</summary>
			public const string Rollupqueryactualintegeridname = "rollupqueryactualintegeridname";

			/// <summary>rollupqueryactualmoneyid</summary>
			public const string RollupQueryActualMoney = "rollupqueryactualmoneyid";

			/// <summary>rollupqueryactualmoneyidname</summary>
			public const string Rollupqueryactualmoneyidname = "rollupqueryactualmoneyidname";

			/// <summary>rollupquerycustomdecimalid</summary>
			public const string RollupQueryCustomRollupFieldDecimal = "rollupquerycustomdecimalid";

			/// <summary>rollupquerycustomdecimalidname</summary>
			public const string Rollupquerycustomdecimalidname = "rollupquerycustomdecimalidname";

			/// <summary>rollupquerycustomintegerid</summary>
			public const string RollupQueryCustomRollupFieldInteger = "rollupquerycustomintegerid";

			/// <summary>rollupquerycustomintegeridname</summary>
			public const string Rollupquerycustomintegeridname = "rollupquerycustomintegeridname";

			/// <summary>rollupquerycustommoneyid</summary>
			public const string RollupQueryCustomRollupFieldMoney = "rollupquerycustommoneyid";

			/// <summary>rollupquerycustommoneyidname</summary>
			public const string Rollupquerycustommoneyidname = "rollupquerycustommoneyidname";

			/// <summary>rollupqueryinprogressdecimalid</summary>
			public const string RollupQueryInprogressDecimal = "rollupqueryinprogressdecimalid";

			/// <summary>rollupqueryinprogressdecimalidname</summary>
			public const string Rollupqueryinprogressdecimalidname = "rollupqueryinprogressdecimalidname";

			/// <summary>rollupqueryinprogressintegerid</summary>
			public const string RollupQueryInprogressInteger = "rollupqueryinprogressintegerid";

			/// <summary>rollupqueryinprogressintegeridname</summary>
			public const string Rollupqueryinprogressintegeridname = "rollupqueryinprogressintegeridname";

			/// <summary>rollupqueryinprogressmoneyid</summary>
			public const string RollupQueryInprogressMoney = "rollupqueryinprogressmoneyid";

			/// <summary>rollupqueryinprogressmoneyidname</summary>
			public const string Rollupqueryinprogressmoneyidname = "rollupqueryinprogressmoneyidname";

			/// <summary>statecode</summary>
			public const string Status = "statecode";

			/// <summary>statuscode</summary>
			public const string StatusReason = "statuscode";

			/// <summary>stretchtargetdecimal</summary>
			public const string StretchTargetDecimal = "stretchtargetdecimal";

			/// <summary>stretchtargetinteger</summary>
			public const string StretchTargetInteger = "stretchtargetinteger";

			/// <summary>stretchtargetmoney</summary>
			public const string StretchTargetMoney = "stretchtargetmoney";

			/// <summary>stretchtargetstring</summary>
			public const string StretchedTarget = "stretchtargetstring";

			/// <summary>targetdecimal</summary>
			public const string TargetDecimal = "targetdecimal";

			/// <summary>targetinteger</summary>
			public const string TargetInteger = "targetinteger";

			/// <summary>targetmoney</summary>
			public const string TargetMoney = "targetmoney";

			/// <summary>targetstring</summary>
			public const string Target = "targetstring";

			/// <summary>timezoneruleversionnumber</summary>
			public const string TimeZoneRuleVersionNumber = "timezoneruleversionnumber";

			/// <summary>title</summary>
			public const string Name = "title";

			/// <summary>transactioncurrencyid</summary>
			public const string Currency = "transactioncurrencyid";

			/// <summary>transactioncurrencyidname</summary>
			public const string Transactioncurrencyidname = "transactioncurrencyidname";

			/// <summary>treeid</summary>
			public const string TreeId = "treeid";

			/// <summary>utcconversiontimezonecode</summary>
			public const string UTCConversionTimeZoneCode = "utcconversiontimezonecode";

			/// <summary>versionnumber</summary>
			public const string VersionNumber = "versionnumber";

		}
		#endregion

		#region Schemas
		public static class Schemas 
		{
			/// <summary>1:N Goal_Annotation</summary>
			public const string GoalAnnotation = "Goal_Annotation";

			/// <summary>1:N Goal_AsyncOperations</summary>
			public const string GoalAsyncOperations = "Goal_AsyncOperations";

			/// <summary>1:N goal_connections1</summary>
			public const string GoalConnections1 = "goal_connections1";

			/// <summary>1:N goal_connections2</summary>
			public const string GoalConnections2 = "goal_connections2";

			/// <summary>1:N Goal_DuplicateBaseRecord</summary>
			public const string GoalDuplicateBaseRecord = "Goal_DuplicateBaseRecord";

			/// <summary>1:N Goal_DuplicateMatchingRecord</summary>
			public const string GoalDuplicateMatchingRecord = "Goal_DuplicateMatchingRecord";

			/// <summary>1:N goal_parent_goal</summary>
			public const string GoalParentGoal = "goal_parent_goal";

			/// <summary>1:N goal_principalobjectattributeaccess</summary>
			public const string GoalPrincipalobjectattributeaccess = "goal_principalobjectattributeaccess";

			/// <summary>1:N Goal_ProcessSessions</summary>
			public const string GoalProcessSessions = "Goal_ProcessSessions";

			/// <summary>1:N Goal_RollupError_Goal</summary>
			public const string GoalRollupErrorGoal = "Goal_RollupError_Goal";

			/// <summary>1:N Goal_SyncErrors</summary>
			public const string GoalSyncErrors = "Goal_SyncErrors";

		}
		#endregion
	}
}

