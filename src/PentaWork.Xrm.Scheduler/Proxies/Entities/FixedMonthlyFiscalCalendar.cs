using System;
using System.Linq;
using System.Diagnostics;
using System.ComponentModel;
using Microsoft.Xrm.Sdk; 
using Microsoft.Xrm.Sdk.Client;
using System.Collections.Generic;

namespace PentaWork.Xrm.Scheduler.Proxies.Entities
{
	
	[EntityLogicalName("fixedmonthlyfiscalcalendar")]
	public sealed class FixedMonthlyFiscalCalendar : Entity
	{	
		public static readonly int? EntityTypeCode = 2004;
		public new const string LogicalName = "fixedmonthlyfiscalcalendar";
		public const string PrimaryIdAttribute = "userfiscalcalendarid";
		public const string PrimaryNameAttribute = "";
	
		public FixedMonthlyFiscalCalendar() : base("fixedmonthlyfiscalcalendar") { }

		#region Attributes
		/// <summary>
        /// businessunitid
        /// </summary>
		[DisplayName("Business Unit")]
		[AttributeLogicalName("businessunitid")]
		public EntityReference BusinessUnit
		{	
			get { return GetAttributeValue<EntityReference>("businessunitid"); }
			set
			{ 
				if(value == BusinessUnit) return;
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
		[DisplayName("createdonbehalfby")]
		[AttributeLogicalName("createdonbehalfby")]
		public EntityReference Createdonbehalfby
		{	
			get { return GetAttributeValue<EntityReference>("createdonbehalfby"); }
			set
			{ 
				if(value == Createdonbehalfby) return;
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
		[DisplayName("modifiedonbehalfby")]
		[AttributeLogicalName("modifiedonbehalfby")]
		public EntityReference Modifiedonbehalfby
		{	
			get { return GetAttributeValue<EntityReference>("modifiedonbehalfby"); }
			set
			{ 
				if(value == Modifiedonbehalfby) return;
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
        /// period1
        /// </summary>
		[DisplayName("period1")]
		[AttributeLogicalName("period1")]
		public decimal? Period1
		{	
			get { return GetAttributeValue<Money>("period1")?.Value; }
			set 
			{ 
				if(value == Period1) return;

				Money moneyValue = null;
				if(value != null) moneyValue = new Money(value.Value);
				SetAttributeValue("period1", moneyValue);  
			}
		}

		/// <summary>
        /// period10
        /// </summary>
		[DisplayName("period10")]
		[AttributeLogicalName("period10")]
		public decimal? Period10
		{	
			get { return GetAttributeValue<Money>("period10")?.Value; }
			set 
			{ 
				if(value == Period10) return;

				Money moneyValue = null;
				if(value != null) moneyValue = new Money(value.Value);
				SetAttributeValue("period10", moneyValue);  
			}
		}

		/// <summary>
        /// period11
        /// </summary>
		[DisplayName("period11")]
		[AttributeLogicalName("period11")]
		public decimal? Period11
		{	
			get { return GetAttributeValue<Money>("period11")?.Value; }
			set 
			{ 
				if(value == Period11) return;

				Money moneyValue = null;
				if(value != null) moneyValue = new Money(value.Value);
				SetAttributeValue("period11", moneyValue);  
			}
		}

		/// <summary>
        /// period12
        /// </summary>
		[DisplayName("period12")]
		[AttributeLogicalName("period12")]
		public decimal? Period12
		{	
			get { return GetAttributeValue<Money>("period12")?.Value; }
			set 
			{ 
				if(value == Period12) return;

				Money moneyValue = null;
				if(value != null) moneyValue = new Money(value.Value);
				SetAttributeValue("period12", moneyValue);  
			}
		}

		/// <summary>
        /// period13
        /// </summary>
		[DisplayName("period13")]
		[AttributeLogicalName("period13")]
		public decimal? Period13
		{	
			get { return GetAttributeValue<Money>("period13")?.Value; }
			set 
			{ 
				if(value == Period13) return;

				Money moneyValue = null;
				if(value != null) moneyValue = new Money(value.Value);
				SetAttributeValue("period13", moneyValue);  
			}
		}

		/// <summary>
        /// period2
        /// </summary>
		[DisplayName("period2")]
		[AttributeLogicalName("period2")]
		public decimal? Period2
		{	
			get { return GetAttributeValue<Money>("period2")?.Value; }
			set 
			{ 
				if(value == Period2) return;

				Money moneyValue = null;
				if(value != null) moneyValue = new Money(value.Value);
				SetAttributeValue("period2", moneyValue);  
			}
		}

		/// <summary>
        /// period3
        /// </summary>
		[DisplayName("period3")]
		[AttributeLogicalName("period3")]
		public decimal? Period3
		{	
			get { return GetAttributeValue<Money>("period3")?.Value; }
			set 
			{ 
				if(value == Period3) return;

				Money moneyValue = null;
				if(value != null) moneyValue = new Money(value.Value);
				SetAttributeValue("period3", moneyValue);  
			}
		}

		/// <summary>
        /// period4
        /// </summary>
		[DisplayName("period4")]
		[AttributeLogicalName("period4")]
		public decimal? Period4
		{	
			get { return GetAttributeValue<Money>("period4")?.Value; }
			set 
			{ 
				if(value == Period4) return;

				Money moneyValue = null;
				if(value != null) moneyValue = new Money(value.Value);
				SetAttributeValue("period4", moneyValue);  
			}
		}

		/// <summary>
        /// period5
        /// </summary>
		[DisplayName("period5")]
		[AttributeLogicalName("period5")]
		public decimal? Period5
		{	
			get { return GetAttributeValue<Money>("period5")?.Value; }
			set 
			{ 
				if(value == Period5) return;

				Money moneyValue = null;
				if(value != null) moneyValue = new Money(value.Value);
				SetAttributeValue("period5", moneyValue);  
			}
		}

		/// <summary>
        /// period6
        /// </summary>
		[DisplayName("period6")]
		[AttributeLogicalName("period6")]
		public decimal? Period6
		{	
			get { return GetAttributeValue<Money>("period6")?.Value; }
			set 
			{ 
				if(value == Period6) return;

				Money moneyValue = null;
				if(value != null) moneyValue = new Money(value.Value);
				SetAttributeValue("period6", moneyValue);  
			}
		}

		/// <summary>
        /// period7
        /// </summary>
		[DisplayName("period7")]
		[AttributeLogicalName("period7")]
		public decimal? Period7
		{	
			get { return GetAttributeValue<Money>("period7")?.Value; }
			set 
			{ 
				if(value == Period7) return;

				Money moneyValue = null;
				if(value != null) moneyValue = new Money(value.Value);
				SetAttributeValue("period7", moneyValue);  
			}
		}

		/// <summary>
        /// period8
        /// </summary>
		[DisplayName("period8")]
		[AttributeLogicalName("period8")]
		public decimal? Period8
		{	
			get { return GetAttributeValue<Money>("period8")?.Value; }
			set 
			{ 
				if(value == Period8) return;

				Money moneyValue = null;
				if(value != null) moneyValue = new Money(value.Value);
				SetAttributeValue("period8", moneyValue);  
			}
		}

		/// <summary>
        /// period9
        /// </summary>
		[DisplayName("period9")]
		[AttributeLogicalName("period9")]
		public decimal? Period9
		{	
			get { return GetAttributeValue<Money>("period9")?.Value; }
			set 
			{ 
				if(value == Period9) return;

				Money moneyValue = null;
				if(value != null) moneyValue = new Money(value.Value);
				SetAttributeValue("period9", moneyValue);  
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
        /// 1:N Get entities for 'FixedMonthlyFiscalCalendar_AsyncOperations'
        /// </summary>
		[RelationshipSchemaName("FixedMonthlyFiscalCalendar_AsyncOperations")]
		public IEnumerable<SystemJob> FixedMonthlyFiscalCalendarAsyncOperations
		{
			get { return GetRelatedEntities<SystemJob>("FixedMonthlyFiscalCalendar_AsyncOperations", null); }
			set { SetRelatedEntities("FixedMonthlyFiscalCalendar_AsyncOperations", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'FixedMonthlyFiscalCalendar_BulkDeleteFailures'
        /// </summary>
		[RelationshipSchemaName("FixedMonthlyFiscalCalendar_BulkDeleteFailures")]
		public IEnumerable<BulkDeleteFailure> FixedMonthlyFiscalCalendarBulkDeleteFailures
		{
			get { return GetRelatedEntities<BulkDeleteFailure>("FixedMonthlyFiscalCalendar_BulkDeleteFailures", null); }
			set { SetRelatedEntities("FixedMonthlyFiscalCalendar_BulkDeleteFailures", null, value); }
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
			public const string BusinessUnit = "businessunitid";

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
			public const string Createdonbehalfby = "createdonbehalfby";

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
			public const string Modifiedonbehalfby = "modifiedonbehalfby";

			/// <summary>modifiedonbehalfbyname</summary>
			public const string Modifiedonbehalfbyname = "modifiedonbehalfbyname";

			/// <summary>modifiedonbehalfbyyominame</summary>
			public const string Modifiedonbehalfbyyominame = "modifiedonbehalfbyyominame";

			/// <summary>period1</summary>
			public const string Period1 = "period1";

			/// <summary>period10</summary>
			public const string Period10 = "period10";

			/// <summary>period11</summary>
			public const string Period11 = "period11";

			/// <summary>period12</summary>
			public const string Period12 = "period12";

			/// <summary>period13</summary>
			public const string Period13 = "period13";

			/// <summary>period2</summary>
			public const string Period2 = "period2";

			/// <summary>period3</summary>
			public const string Period3 = "period3";

			/// <summary>period4</summary>
			public const string Period4 = "period4";

			/// <summary>period5</summary>
			public const string Period5 = "period5";

			/// <summary>period6</summary>
			public const string Period6 = "period6";

			/// <summary>period7</summary>
			public const string Period7 = "period7";

			/// <summary>period8</summary>
			public const string Period8 = "period8";

			/// <summary>period9</summary>
			public const string Period9 = "period9";

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
			/// <summary>1:N FixedMonthlyFiscalCalendar_AsyncOperations</summary>
			public const string FixedMonthlyFiscalCalendarAsyncOperations = "FixedMonthlyFiscalCalendar_AsyncOperations";

			/// <summary>1:N FixedMonthlyFiscalCalendar_BulkDeleteFailures</summary>
			public const string FixedMonthlyFiscalCalendarBulkDeleteFailures = "FixedMonthlyFiscalCalendar_BulkDeleteFailures";

		}
		#endregion
	}
}

