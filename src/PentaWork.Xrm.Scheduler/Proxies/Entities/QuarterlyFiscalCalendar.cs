using System;
using System.Linq;
using System.Diagnostics;
using System.ComponentModel;
using Microsoft.Xrm.Sdk; 
using Microsoft.Xrm.Sdk.Client;
using System.Collections.Generic;

namespace PentaWork.Xrm.Scheduler.Proxies.Entities
{
	
	[EntityLogicalName("quarterlyfiscalcalendar")]
	public sealed class QuarterlyFiscalCalendar : Entity
	{	
		public static readonly int? EntityTypeCode = 2002;
		public new const string LogicalName = "quarterlyfiscalcalendar";
		public const string PrimaryIdAttribute = "userfiscalcalendarid";
		public const string PrimaryNameAttribute = "";
	
		public QuarterlyFiscalCalendar() : base("quarterlyfiscalcalendar") { }

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
        /// quarter1
        /// </summary>
		[DisplayName("quarter1")]
		[AttributeLogicalName("quarter1")]
		public decimal? Quarter1
		{	
			get { return GetAttributeValue<Money>("quarter1")?.Value; }
			set 
			{ 
				if(value == Quarter1) return;

				Money moneyValue = null;
				if(value != null) moneyValue = new Money(value.Value);
				SetAttributeValue("quarter1", moneyValue);  
			}
		}

		/// <summary>
        /// quarter2
        /// </summary>
		[DisplayName("quarter2")]
		[AttributeLogicalName("quarter2")]
		public decimal? Quarter2
		{	
			get { return GetAttributeValue<Money>("quarter2")?.Value; }
			set 
			{ 
				if(value == Quarter2) return;

				Money moneyValue = null;
				if(value != null) moneyValue = new Money(value.Value);
				SetAttributeValue("quarter2", moneyValue);  
			}
		}

		/// <summary>
        /// quarter3
        /// </summary>
		[DisplayName("quarter3")]
		[AttributeLogicalName("quarter3")]
		public decimal? Quarter3
		{	
			get { return GetAttributeValue<Money>("quarter3")?.Value; }
			set 
			{ 
				if(value == Quarter3) return;

				Money moneyValue = null;
				if(value != null) moneyValue = new Money(value.Value);
				SetAttributeValue("quarter3", moneyValue);  
			}
		}

		/// <summary>
        /// quarter4
        /// </summary>
		[DisplayName("quarter4")]
		[AttributeLogicalName("quarter4")]
		public decimal? Quarter4
		{	
			get { return GetAttributeValue<Money>("quarter4")?.Value; }
			set 
			{ 
				if(value == Quarter4) return;

				Money moneyValue = null;
				if(value != null) moneyValue = new Money(value.Value);
				SetAttributeValue("quarter4", moneyValue);  
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
        /// 1:N Get entities for 'QuarterlyFiscalCalendar_AsyncOperations'
        /// </summary>
		[RelationshipSchemaName("QuarterlyFiscalCalendar_AsyncOperations")]
		public IEnumerable<SystemJob> QuarterlyFiscalCalendarAsyncOperations
		{
			get { return GetRelatedEntities<SystemJob>("QuarterlyFiscalCalendar_AsyncOperations", null); }
			set { SetRelatedEntities("QuarterlyFiscalCalendar_AsyncOperations", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'QuarterlyFiscalCalendar_BulkDeleteFailures'
        /// </summary>
		[RelationshipSchemaName("QuarterlyFiscalCalendar_BulkDeleteFailures")]
		public IEnumerable<BulkDeleteFailure> QuarterlyFiscalCalendarBulkDeleteFailures
		{
			get { return GetRelatedEntities<BulkDeleteFailure>("QuarterlyFiscalCalendar_BulkDeleteFailures", null); }
			set { SetRelatedEntities("QuarterlyFiscalCalendar_BulkDeleteFailures", null, value); }
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

			/// <summary>quarter1</summary>
			public const string Quarter1 = "quarter1";

			/// <summary>quarter2</summary>
			public const string Quarter2 = "quarter2";

			/// <summary>quarter3</summary>
			public const string Quarter3 = "quarter3";

			/// <summary>quarter4</summary>
			public const string Quarter4 = "quarter4";

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
			/// <summary>1:N QuarterlyFiscalCalendar_AsyncOperations</summary>
			public const string QuarterlyFiscalCalendarAsyncOperations = "QuarterlyFiscalCalendar_AsyncOperations";

			/// <summary>1:N QuarterlyFiscalCalendar_BulkDeleteFailures</summary>
			public const string QuarterlyFiscalCalendarBulkDeleteFailures = "QuarterlyFiscalCalendar_BulkDeleteFailures";

		}
		#endregion
	}
}

