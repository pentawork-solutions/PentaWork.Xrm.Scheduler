using System;
using System.Linq;
using System.Diagnostics;
using System.ComponentModel;
using Microsoft.Xrm.Sdk; 
using Microsoft.Xrm.Sdk.Client;
using System.Collections.Generic;

namespace PentaWork.Xrm.Scheduler.Proxies.Entities
{
	
	[EntityLogicalName("monthlyfiscalcalendar")]
	public sealed class MonthlyFiscalCalendar : Entity
	{	
		public static readonly int? EntityTypeCode = 2003;
		public new const string LogicalName = "monthlyfiscalcalendar";
		public const string PrimaryIdAttribute = "userfiscalcalendarid";
		public const string PrimaryNameAttribute = "";
	
		public MonthlyFiscalCalendar() : base("monthlyfiscalcalendar") { }

		#region Attributes
		/// <summary>
        /// businessunitid
        /// </summary>
		[DisplayName("businessunitid")]
		[AttributeLogicalName("businessunitid")]
		public EntityReference Businessunitid
		{	
			get { return GetAttributeValue<EntityReference>("businessunitid"); }
			set
			{ 
				if(value == Businessunitid) return;
				SetAttributeValue("businessunitid", value);
			}
		}	
			
		/// <summary>
        /// businessunitidname
        /// </summary>
		[DisplayName("businessunitidname")]
		[AttributeLogicalName("businessunitidname")]
		public string Businessunitidname
		{	
			get { return GetAttributeValue<string>("businessunitidname"); }
			set
			{ 
				if(value == Businessunitidname) return;
				SetAttributeValue("businessunitidname", value);
			}
		}	
			
		/// <summary>
        /// createdby
        /// </summary>
		[DisplayName("createdby")]
		[AttributeLogicalName("createdby")]
		public EntityReference Createdby
		{	
			get { return GetAttributeValue<EntityReference>("createdby"); }
			set
			{ 
				if(value == Createdby) return;
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
		[DisplayName("createdon")]
		[AttributeLogicalName("createdon")]
		public DateTime? Createdon
		{	
			get { return GetAttributeValue<DateTime?>("createdon"); }
			set
			{ 
				if(value == Createdon) return;
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
        /// effectiveon
        /// </summary>
		[DisplayName("effectiveon")]
		[AttributeLogicalName("effectiveon")]
		public DateTime? Effectiveon
		{	
			get { return GetAttributeValue<DateTime?>("effectiveon"); }
			set
			{ 
				if(value == Effectiveon) return;
				SetAttributeValue("effectiveon", value);
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
        /// fiscalperiodtype
        /// </summary>
		[DisplayName("fiscalperiodtype")]
		[AttributeLogicalName("fiscalperiodtype")]
		public int? Fiscalperiodtype
		{	
			get { return GetAttributeValue<int?>("fiscalperiodtype"); }
			set
			{ 
				if(value == Fiscalperiodtype) return;
				SetAttributeValue("fiscalperiodtype", value);
			}
		}	
			
		/// <summary>
        /// modifiedby
        /// </summary>
		[DisplayName("modifiedby")]
		[AttributeLogicalName("modifiedby")]
		public EntityReference Modifiedby
		{	
			get { return GetAttributeValue<EntityReference>("modifiedby"); }
			set
			{ 
				if(value == Modifiedby) return;
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
		[DisplayName("modifiedon")]
		[AttributeLogicalName("modifiedon")]
		public DateTime? Modifiedon
		{	
			get { return GetAttributeValue<DateTime?>("modifiedon"); }
			set
			{ 
				if(value == Modifiedon) return;
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
        /// month1
		///
		/// Precision: 2
		/// MaxValue: 100000000000
		/// MinValue: 0
        /// </summary>
		[DisplayName("month1")]
		[AttributeLogicalName("month1")]
		public decimal? Month1
		{	
			get { return GetAttributeValue<Money>("month1")?.Value; }
			set 
			{
				Money moneyValue = null;
				if(value != null) 
				{
					var roundedValue = Decimal.Round(value.Value, 2);
					moneyValue = new Money(roundedValue);
				}

				if(moneyValue.Value == Month1) return;
				SetAttributeValue("month1", moneyValue);  
			}
		}

		/// <summary>
        /// month10
		///
		/// Precision: 2
		/// MaxValue: 100000000000
		/// MinValue: 0
        /// </summary>
		[DisplayName("month10")]
		[AttributeLogicalName("month10")]
		public decimal? Month10
		{	
			get { return GetAttributeValue<Money>("month10")?.Value; }
			set 
			{
				Money moneyValue = null;
				if(value != null) 
				{
					var roundedValue = Decimal.Round(value.Value, 2);
					moneyValue = new Money(roundedValue);
				}

				if(moneyValue.Value == Month10) return;
				SetAttributeValue("month10", moneyValue);  
			}
		}

		/// <summary>
        /// month11
		///
		/// Precision: 2
		/// MaxValue: 100000000000
		/// MinValue: 0
        /// </summary>
		[DisplayName("month11")]
		[AttributeLogicalName("month11")]
		public decimal? Month11
		{	
			get { return GetAttributeValue<Money>("month11")?.Value; }
			set 
			{
				Money moneyValue = null;
				if(value != null) 
				{
					var roundedValue = Decimal.Round(value.Value, 2);
					moneyValue = new Money(roundedValue);
				}

				if(moneyValue.Value == Month11) return;
				SetAttributeValue("month11", moneyValue);  
			}
		}

		/// <summary>
        /// month12
		///
		/// Precision: 2
		/// MaxValue: 100000000000
		/// MinValue: 0
        /// </summary>
		[DisplayName("month12")]
		[AttributeLogicalName("month12")]
		public decimal? Month12
		{	
			get { return GetAttributeValue<Money>("month12")?.Value; }
			set 
			{
				Money moneyValue = null;
				if(value != null) 
				{
					var roundedValue = Decimal.Round(value.Value, 2);
					moneyValue = new Money(roundedValue);
				}

				if(moneyValue.Value == Month12) return;
				SetAttributeValue("month12", moneyValue);  
			}
		}

		/// <summary>
        /// month2
		///
		/// Precision: 2
		/// MaxValue: 100000000000
		/// MinValue: 0
        /// </summary>
		[DisplayName("month2")]
		[AttributeLogicalName("month2")]
		public decimal? Month2
		{	
			get { return GetAttributeValue<Money>("month2")?.Value; }
			set 
			{
				Money moneyValue = null;
				if(value != null) 
				{
					var roundedValue = Decimal.Round(value.Value, 2);
					moneyValue = new Money(roundedValue);
				}

				if(moneyValue.Value == Month2) return;
				SetAttributeValue("month2", moneyValue);  
			}
		}

		/// <summary>
        /// month3
		///
		/// Precision: 2
		/// MaxValue: 100000000000
		/// MinValue: 0
        /// </summary>
		[DisplayName("month3")]
		[AttributeLogicalName("month3")]
		public decimal? Month3
		{	
			get { return GetAttributeValue<Money>("month3")?.Value; }
			set 
			{
				Money moneyValue = null;
				if(value != null) 
				{
					var roundedValue = Decimal.Round(value.Value, 2);
					moneyValue = new Money(roundedValue);
				}

				if(moneyValue.Value == Month3) return;
				SetAttributeValue("month3", moneyValue);  
			}
		}

		/// <summary>
        /// month4
		///
		/// Precision: 2
		/// MaxValue: 100000000000
		/// MinValue: 0
        /// </summary>
		[DisplayName("month4")]
		[AttributeLogicalName("month4")]
		public decimal? Month4
		{	
			get { return GetAttributeValue<Money>("month4")?.Value; }
			set 
			{
				Money moneyValue = null;
				if(value != null) 
				{
					var roundedValue = Decimal.Round(value.Value, 2);
					moneyValue = new Money(roundedValue);
				}

				if(moneyValue.Value == Month4) return;
				SetAttributeValue("month4", moneyValue);  
			}
		}

		/// <summary>
        /// month5
		///
		/// Precision: 2
		/// MaxValue: 100000000000
		/// MinValue: 0
        /// </summary>
		[DisplayName("month5")]
		[AttributeLogicalName("month5")]
		public decimal? Month5
		{	
			get { return GetAttributeValue<Money>("month5")?.Value; }
			set 
			{
				Money moneyValue = null;
				if(value != null) 
				{
					var roundedValue = Decimal.Round(value.Value, 2);
					moneyValue = new Money(roundedValue);
				}

				if(moneyValue.Value == Month5) return;
				SetAttributeValue("month5", moneyValue);  
			}
		}

		/// <summary>
        /// month6
		///
		/// Precision: 2
		/// MaxValue: 100000000000
		/// MinValue: 0
        /// </summary>
		[DisplayName("month6")]
		[AttributeLogicalName("month6")]
		public decimal? Month6
		{	
			get { return GetAttributeValue<Money>("month6")?.Value; }
			set 
			{
				Money moneyValue = null;
				if(value != null) 
				{
					var roundedValue = Decimal.Round(value.Value, 2);
					moneyValue = new Money(roundedValue);
				}

				if(moneyValue.Value == Month6) return;
				SetAttributeValue("month6", moneyValue);  
			}
		}

		/// <summary>
        /// month7
		///
		/// Precision: 2
		/// MaxValue: 100000000000
		/// MinValue: 0
        /// </summary>
		[DisplayName("month7")]
		[AttributeLogicalName("month7")]
		public decimal? Month7
		{	
			get { return GetAttributeValue<Money>("month7")?.Value; }
			set 
			{
				Money moneyValue = null;
				if(value != null) 
				{
					var roundedValue = Decimal.Round(value.Value, 2);
					moneyValue = new Money(roundedValue);
				}

				if(moneyValue.Value == Month7) return;
				SetAttributeValue("month7", moneyValue);  
			}
		}

		/// <summary>
        /// month8
		///
		/// Precision: 2
		/// MaxValue: 100000000000
		/// MinValue: 0
        /// </summary>
		[DisplayName("month8")]
		[AttributeLogicalName("month8")]
		public decimal? Month8
		{	
			get { return GetAttributeValue<Money>("month8")?.Value; }
			set 
			{
				Money moneyValue = null;
				if(value != null) 
				{
					var roundedValue = Decimal.Round(value.Value, 2);
					moneyValue = new Money(roundedValue);
				}

				if(moneyValue.Value == Month8) return;
				SetAttributeValue("month8", moneyValue);  
			}
		}

		/// <summary>
        /// month9
		///
		/// Precision: 2
		/// MaxValue: 100000000000
		/// MinValue: 0
        /// </summary>
		[DisplayName("month9")]
		[AttributeLogicalName("month9")]
		public decimal? Month9
		{	
			get { return GetAttributeValue<Money>("month9")?.Value; }
			set 
			{
				Money moneyValue = null;
				if(value != null) 
				{
					var roundedValue = Decimal.Round(value.Value, 2);
					moneyValue = new Money(roundedValue);
				}

				if(moneyValue.Value == Month9) return;
				SetAttributeValue("month9", moneyValue);  
			}
		}

		/// <summary>
        /// salespersonid
        /// </summary>
		[DisplayName("salespersonid")]
		[AttributeLogicalName("salespersonid")]
		public EntityReference Salespersonid
		{	
			get { return GetAttributeValue<EntityReference>("salespersonid"); }
			set
			{ 
				if(value == Salespersonid) return;
				SetAttributeValue("salespersonid", value);
			}
		}	
			
		/// <summary>
        /// salespersonidname
        /// </summary>
		[DisplayName("salespersonidname")]
		[AttributeLogicalName("salespersonidname")]
		public string Salespersonidname
		{	
			get { return GetAttributeValue<string>("salespersonidname"); }
			set
			{ 
				if(value == Salespersonidname) return;
				SetAttributeValue("salespersonidname", value);
			}
		}	
			
		/// <summary>
        /// salespersonidyominame
        /// </summary>
		[DisplayName("salespersonidyominame")]
		[AttributeLogicalName("salespersonidyominame")]
		public string Salespersonidyominame
		{	
			get { return GetAttributeValue<string>("salespersonidyominame"); }
			set
			{ 
				if(value == Salespersonidyominame) return;
				SetAttributeValue("salespersonidyominame", value);
			}
		}	
			
		/// <summary>
        /// timezoneruleversionnumber
        /// </summary>
		[DisplayName("timezoneruleversionnumber")]
		[AttributeLogicalName("timezoneruleversionnumber")]
		public int? Timezoneruleversionnumber
		{	
			get { return GetAttributeValue<int?>("timezoneruleversionnumber"); }
			set
			{ 
				if(value == Timezoneruleversionnumber) return;
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
        /// userfiscalcalendarid
        /// </summary>
		[DisplayName("userfiscalcalendarid")]
		[AttributeLogicalName("userfiscalcalendarid")]
		public override Guid Id
		{
			get => base.Id;
			set { base.Id = value; SetAttributeValue("userfiscalcalendarid", value); }
		}

							/// <summary>
        /// utcconversiontimezonecode
        /// </summary>
		[DisplayName("utcconversiontimezonecode")]
		[AttributeLogicalName("utcconversiontimezonecode")]
		public int? Utcconversiontimezonecode
		{	
			get { return GetAttributeValue<int?>("utcconversiontimezonecode"); }
			set
			{ 
				if(value == Utcconversiontimezonecode) return;
				SetAttributeValue("utcconversiontimezonecode", value);
			}
		}	
			
		#endregion	

		#region Relations
			/// <summary>
        /// 1:N Get entities for 'MonthlyFiscalCalendar_AsyncOperations'
        /// </summary>
		[RelationshipSchemaName("MonthlyFiscalCalendar_AsyncOperations")]
		public IEnumerable<SystemJob> MonthlyFiscalCalendarAsyncOperations
		{
			get { return GetRelatedEntities<SystemJob>("MonthlyFiscalCalendar_AsyncOperations", null); }
			set { SetRelatedEntities("MonthlyFiscalCalendar_AsyncOperations", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'MonthlyFiscalCalendar_BulkDeleteFailures'
        /// </summary>
		[RelationshipSchemaName("MonthlyFiscalCalendar_BulkDeleteFailures")]
		public IEnumerable<BulkDeleteFailure> MonthlyFiscalCalendarBulkDeleteFailures
		{
			get { return GetRelatedEntities<BulkDeleteFailure>("MonthlyFiscalCalendar_BulkDeleteFailures", null); }
			set { SetRelatedEntities("MonthlyFiscalCalendar_BulkDeleteFailures", null, value); }
		}
		#endregion

		#region Actions
		#endregion

		#region OptionSetEnums
		#endregion	

		#region Properties
		public static class Properties 
		{
			/// <summary>businessunitid</summary>
			public const string Businessunitid = "businessunitid";

			/// <summary>businessunitidname</summary>
			public const string Businessunitidname = "businessunitidname";

			/// <summary>createdby</summary>
			public const string Createdby = "createdby";

			/// <summary>createdbyname</summary>
			public const string Createdbyname = "createdbyname";

			/// <summary>createdbyyominame</summary>
			public const string Createdbyyominame = "createdbyyominame";

			/// <summary>createdon</summary>
			public const string Createdon = "createdon";

			/// <summary>createdonbehalfby</summary>
			public const string CreatedByDelegate = "createdonbehalfby";

			/// <summary>createdonbehalfbyname</summary>
			public const string Createdonbehalfbyname = "createdonbehalfbyname";

			/// <summary>createdonbehalfbyyominame</summary>
			public const string Createdonbehalfbyyominame = "createdonbehalfbyyominame";

			/// <summary>effectiveon</summary>
			public const string Effectiveon = "effectiveon";

			/// <summary>exchangerate</summary>
			public const string ExchangeRate = "exchangerate";

			/// <summary>fiscalperiodtype</summary>
			public const string Fiscalperiodtype = "fiscalperiodtype";

			/// <summary>modifiedby</summary>
			public const string Modifiedby = "modifiedby";

			/// <summary>modifiedbyname</summary>
			public const string Modifiedbyname = "modifiedbyname";

			/// <summary>modifiedbyyominame</summary>
			public const string Modifiedbyyominame = "modifiedbyyominame";

			/// <summary>modifiedon</summary>
			public const string Modifiedon = "modifiedon";

			/// <summary>modifiedonbehalfby</summary>
			public const string ModifiedByDelegate = "modifiedonbehalfby";

			/// <summary>modifiedonbehalfbyname</summary>
			public const string Modifiedonbehalfbyname = "modifiedonbehalfbyname";

			/// <summary>modifiedonbehalfbyyominame</summary>
			public const string Modifiedonbehalfbyyominame = "modifiedonbehalfbyyominame";

			/// <summary>month1</summary>
			public const string Month1 = "month1";

			/// <summary>month10</summary>
			public const string Month10 = "month10";

			/// <summary>month11</summary>
			public const string Month11 = "month11";

			/// <summary>month12</summary>
			public const string Month12 = "month12";

			/// <summary>month2</summary>
			public const string Month2 = "month2";

			/// <summary>month3</summary>
			public const string Month3 = "month3";

			/// <summary>month4</summary>
			public const string Month4 = "month4";

			/// <summary>month5</summary>
			public const string Month5 = "month5";

			/// <summary>month6</summary>
			public const string Month6 = "month6";

			/// <summary>month7</summary>
			public const string Month7 = "month7";

			/// <summary>month8</summary>
			public const string Month8 = "month8";

			/// <summary>month9</summary>
			public const string Month9 = "month9";

			/// <summary>salespersonid</summary>
			public const string Salespersonid = "salespersonid";

			/// <summary>salespersonidname</summary>
			public const string Salespersonidname = "salespersonidname";

			/// <summary>salespersonidyominame</summary>
			public const string Salespersonidyominame = "salespersonidyominame";

			/// <summary>timezoneruleversionnumber</summary>
			public const string Timezoneruleversionnumber = "timezoneruleversionnumber";

			/// <summary>transactioncurrencyid</summary>
			public const string Currency = "transactioncurrencyid";

			/// <summary>transactioncurrencyidname</summary>
			public const string Transactioncurrencyidname = "transactioncurrencyidname";

			/// <summary>userfiscalcalendarid</summary>
			public const string UserfiscalcalendarId = "userfiscalcalendarid";

			/// <summary>utcconversiontimezonecode</summary>
			public const string Utcconversiontimezonecode = "utcconversiontimezonecode";

		}
		#endregion

		#region Schemas
		public static class Schemas 
		{
			/// <summary>1:N MonthlyFiscalCalendar_AsyncOperations</summary>
			public const string MonthlyFiscalCalendarAsyncOperations = "MonthlyFiscalCalendar_AsyncOperations";

			/// <summary>1:N MonthlyFiscalCalendar_BulkDeleteFailures</summary>
			public const string MonthlyFiscalCalendarBulkDeleteFailures = "MonthlyFiscalCalendar_BulkDeleteFailures";

		}
		#endregion
	}
}

