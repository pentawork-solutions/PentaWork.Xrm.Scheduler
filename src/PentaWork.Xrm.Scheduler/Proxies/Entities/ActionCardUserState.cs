using System;
using System.Linq;
using System.Diagnostics;
using System.ComponentModel;
using Microsoft.Xrm.Sdk; 
using Microsoft.Xrm.Sdk.Client;
using System.Collections.Generic;

namespace PentaWork.Xrm.Scheduler.Proxies.Entities
{
	
	[EntityLogicalName("actioncarduserstate")]
	public sealed class ActionCardUserState : Entity
	{	
		public static readonly int? EntityTypeCode = 9968;
		public new const string LogicalName = "actioncarduserstate";
		public const string PrimaryIdAttribute = "actioncarduserstateid";
		public const string PrimaryNameAttribute = "";
	
		public ActionCardUserState() : base("actioncarduserstate") { }

		#region Attributes
		/// <summary>
        /// actioncardid
        /// </summary>
		[DisplayName("ActionCardId")]
		[AttributeLogicalName("actioncardid")]
		public EntityReference ActionCardId
		{	
			get { return GetAttributeValue<EntityReference>("actioncardid"); }
			set
			{ 
				if(value == ActionCardId) return;
				SetAttributeValue("actioncardid", value);
			}
		}	
			
		/// <summary>
        /// actioncardidname
        /// </summary>
		[DisplayName("actioncardidname")]
		[AttributeLogicalName("actioncardidname")]
		public string Actioncardidname
		{	
			get { return GetAttributeValue<string>("actioncardidname"); }
			set
			{ 
				if(value == Actioncardidname) return;
				SetAttributeValue("actioncardidname", value);
			}
		}	
			
		/// <summary>
        /// actioncardidobjecttypecode
        /// </summary>
		[DisplayName("ActionCardIdObjectTypeCode")]
		[AttributeLogicalName("actioncardidobjecttypecode")]
		public string ActionCardIdObjectTypeCode
		{	
			get { return GetAttributeValue<string>("actioncardidobjecttypecode"); }
			set
			{ 
				if(value == ActionCardIdObjectTypeCode) return;
				SetAttributeValue("actioncardidobjecttypecode", value);
			}
		}	
			
		/// <summary>
        /// actioncarduserstateid
        /// </summary>
		[DisplayName("ActionCardUserState")]
		[AttributeLogicalName("actioncarduserstateid")]
		public override Guid Id
		{
			get => base.Id;
			set { base.Id = value; SetAttributeValue("actioncarduserstateid", value); }
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
        /// startdate
        /// </summary>
		[DisplayName("Start Date")]
		[AttributeLogicalName("startdate")]
		public DateTime? StartDate
		{	
			get { return GetAttributeValue<DateTime?>("startdate"); }
			set
			{ 
				if(value == StartDate) return;
				SetAttributeValue("startdate", value);
			}
		}	
			
		/// <summary>
        /// state
        /// </summary>
		[DisplayName("Action Card State")]
		[AttributeLogicalName("state")]
		public eActionCardUserState? ActionCardState
		{	
			get 
			{ 
				var optionSetValue = GetAttributeValue<OptionSetValue>("state");
				if (optionSetValue != null) return (eActionCardUserState)optionSetValue.Value;
				else return null;
			}
			set 
			{ 
				if(value == ActionCardState) return;

				OptionSetValue optionSetValue = null;
				if(value != null) optionSetValue = new OptionSetValue((int)value);
				SetAttributeValue("state", optionSetValue); 
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
			#endregion

		#region Actions
		#endregion

		#region OptionSetEnums
		public enum eActionCardUserState
		{	
		
			[Label("Active")]
			[Description(@"")]
			Active = 0, 
		
			[Label("Dismissed")]
			[Description(@"")]
			Dismissed = 1, 
		
			[Label("Completed")]
			[Description(@"")]
			Completed = 2, 
		}
		
		#endregion	

		#region Properties
		public static class Properties 
		{
			/// <summary>actioncardid</summary>
			public const string ActionCardId = "actioncardid";

			/// <summary>actioncardidname</summary>
			public const string Actioncardidname = "actioncardidname";

			/// <summary>actioncardidobjecttypecode</summary>
			public const string ActionCardIdObjectTypeCode = "actioncardidobjecttypecode";

			/// <summary>actioncarduserstateid</summary>
			public const string ActionCardUserStateId = "actioncarduserstateid";

			/// <summary>exchangerate</summary>
			public const string ExchangeRate = "exchangerate";

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

			/// <summary>startdate</summary>
			public const string StartDate = "startdate";

			/// <summary>state</summary>
			public const string ActionCardState = "state";

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
		}
		#endregion
	}
}

