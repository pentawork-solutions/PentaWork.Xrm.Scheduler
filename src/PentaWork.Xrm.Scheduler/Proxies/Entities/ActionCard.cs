using System;
using System.Linq;
using System.Diagnostics;
using System.ComponentModel;
using Microsoft.Xrm.Sdk; 
using Microsoft.Xrm.Sdk.Client;
using System.Collections.Generic;

namespace PentaWork.Xrm.Scheduler.Proxies.Entities
{
	[DebuggerDisplay("{Title}")] 	
	[EntityLogicalName("actioncard")]
	public sealed class ActionCard : Entity
	{	
		public static readonly int? EntityTypeCode = 9962;
		public new const string LogicalName = "actioncard";
		public const string PrimaryIdAttribute = "actioncardid";
		public const string PrimaryNameAttribute = "title";
	
		public ActionCard() : base("actioncard") { }

		#region Attributes
		/// <summary>
        /// actioncardid
        /// </summary>
		[DisplayName("Action Card")]
		[AttributeLogicalName("actioncardid")]
		public override Guid Id
		{
			get => base.Id;
			set { base.Id = value; SetAttributeValue("actioncardid", value); }
		}

							/// <summary>
        /// cardtype
        /// </summary>
		[DisplayName("CardType ENUM")]
		[AttributeLogicalName("cardtype")]
		public int? CardTypeENUM
		{	
			get { return GetAttributeValue<int?>("cardtype"); }
			set
			{ 
				if(value == CardTypeENUM) return;
				SetAttributeValue("cardtype", value);
			}
		}	
			
		/// <summary>
        /// cardtypeid
        /// </summary>
		[DisplayName("Card Type")]
		[AttributeLogicalName("cardtypeid")]
		public EntityReference CardType
		{	
			get { return GetAttributeValue<EntityReference>("cardtypeid"); }
			set
			{ 
				if(value == CardType) return;
				SetAttributeValue("cardtypeid", value);
			}
		}	
			
		/// <summary>
        /// cardtypeidname
        /// </summary>
		[DisplayName("cardtypeidname")]
		[AttributeLogicalName("cardtypeidname")]
		public string Cardtypeidname
		{	
			get { return GetAttributeValue<string>("cardtypeidname"); }
			set
			{ 
				if(value == Cardtypeidname) return;
				SetAttributeValue("cardtypeidname", value);
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
        /// data
        /// </summary>
		[DisplayName("Data Associated with Card Commandbar Actions")]
		[AttributeLogicalName("data")]
		public string DataAssociatedWithCardCommandbarActions
		{	
			get { return GetAttributeValue<string>("data"); }
			set
			{ 
				if(value == DataAssociatedWithCardCommandbarActions) return;
				SetAttributeValue("data", value);
			}
		}	
			
		/// <summary>
        /// description
        /// </summary>
		[DisplayName("Card Description")]
		[AttributeLogicalName("description")]
		public string CardDescription
		{	
			get { return GetAttributeValue<string>("description"); }
			set
			{ 
				if(value == CardDescription) return;
				SetAttributeValue("description", value);
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
        /// expirydate
        /// </summary>
		[DisplayName("Expiry Date")]
		[AttributeLogicalName("expirydate")]
		public DateTime? ExpiryDate
		{	
			get { return GetAttributeValue<DateTime?>("expirydate"); }
			set
			{ 
				if(value == ExpiryDate) return;
				SetAttributeValue("expirydate", value);
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
        /// msdyn_actioncardregardingid
        /// </summary>
		[DisplayName("actioncardregardingid")]
		[AttributeLogicalName("msdyn_actioncardregardingid")]
		public string Actioncardregardingid
		{	
			get { return GetAttributeValue<string>("msdyn_actioncardregardingid"); }
			set
			{ 
				if(value == Actioncardregardingid) return;
				SetAttributeValue("msdyn_actioncardregardingid", value);
			}
		}	
			
		/// <summary>
        /// msdyn_regardingobjectid
        /// </summary>
		[DisplayName("regardingobjectid")]
		[AttributeLogicalName("msdyn_regardingobjectid")]
		public string Regardingobjectid
		{	
			get { return GetAttributeValue<string>("msdyn_regardingobjectid"); }
			set
			{ 
				if(value == Regardingobjectid) return;
				SetAttributeValue("msdyn_regardingobjectid", value);
			}
		}	
			
		/// <summary>
        /// msdyn_regardingobjectlogicalname
        /// </summary>
		[DisplayName("regardingobjectlogicalname")]
		[AttributeLogicalName("msdyn_regardingobjectlogicalname")]
		public string Regardingobjectlogicalname
		{	
			get { return GetAttributeValue<string>("msdyn_regardingobjectlogicalname"); }
			set
			{ 
				if(value == Regardingobjectlogicalname) return;
				SetAttributeValue("msdyn_regardingobjectlogicalname", value);
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
        /// parentregardingobjectid
        /// </summary>
		[DisplayName("ParentRegardingObjectId")]
		[AttributeLogicalName("parentregardingobjectid")]
		public EntityReference ParentRegardingObjectId
		{	
			get { return GetAttributeValue<EntityReference>("parentregardingobjectid"); }
			set
			{ 
				if(value == ParentRegardingObjectId) return;
				SetAttributeValue("parentregardingobjectid", value);
			}
		}	
			
		/// <summary>
        /// parentregardingobjectiddata
        /// </summary>
		[DisplayName("ParentRegardingObjectIdData")]
		[AttributeLogicalName("parentregardingobjectiddata")]
		public string ParentRegardingObjectIdData
		{	
			get { return GetAttributeValue<string>("parentregardingobjectiddata"); }
			set
			{ 
				if(value == ParentRegardingObjectIdData) return;
				SetAttributeValue("parentregardingobjectiddata", value);
			}
		}	
			
		/// <summary>
        /// parentregardingobjecttypecode
        /// </summary>
		[DisplayName("ParentRegardingObjectTypeCode")]
		[AttributeLogicalName("parentregardingobjecttypecode")]
		public string ParentRegardingObjectTypeCode
		{	
			get { return GetAttributeValue<string>("parentregardingobjecttypecode"); }
			set
			{ 
				if(value == ParentRegardingObjectTypeCode) return;
				SetAttributeValue("parentregardingobjecttypecode", value);
			}
		}	
			
		/// <summary>
        /// priority
        /// </summary>
		[DisplayName("Priority")]
		[AttributeLogicalName("priority")]
		public int? Priority
		{	
			get { return GetAttributeValue<int?>("priority"); }
			set
			{ 
				if(value == Priority) return;
				SetAttributeValue("priority", value);
			}
		}	
			
		/// <summary>
        /// recordid
        /// </summary>
		[DisplayName("RecordId")]
		[AttributeLogicalName("recordid")]
		public EntityReference RecordId
		{	
			get { return GetAttributeValue<EntityReference>("recordid"); }
			set
			{ 
				if(value == RecordId) return;
				SetAttributeValue("recordid", value);
			}
		}	
			
		/// <summary>
        /// recordidname
        /// </summary>
		[DisplayName("RecordIdName")]
		[AttributeLogicalName("recordidname")]
		public string RecordIdName
		{	
			get { return GetAttributeValue<string>("recordidname"); }
			set
			{ 
				if(value == RecordIdName) return;
				SetAttributeValue("recordidname", value);
			}
		}	
			
		/// <summary>
        /// recordidobjecttypecode
        /// </summary>
		[DisplayName("RecordIdObjectTypeCode")]
		[AttributeLogicalName("recordidobjecttypecode")]
		public string RecordIdObjectTypeCode
		{	
			get { return GetAttributeValue<string>("recordidobjecttypecode"); }
			set
			{ 
				if(value == RecordIdObjectTypeCode) return;
				SetAttributeValue("recordidobjecttypecode", value);
			}
		}	
			
		/// <summary>
        /// recordidobjecttypecode2
        /// </summary>
		[DisplayName("RecordIdObjectTypeCode2")]
		[AttributeLogicalName("recordidobjecttypecode2")]
		public int? RecordIdObjectTypeCode2
		{	
			get { return GetAttributeValue<int?>("recordidobjecttypecode2"); }
			set
			{ 
				if(value == RecordIdObjectTypeCode2) return;
				SetAttributeValue("recordidobjecttypecode2", value);
			}
		}	
			
		/// <summary>
        /// referencetokens
        /// </summary>
		[DisplayName("Data Associated constructing title and body")]
		[AttributeLogicalName("referencetokens")]
		public string DataAssociatedConstructingTitleAndBody
		{	
			get { return GetAttributeValue<string>("referencetokens"); }
			set
			{ 
				if(value == DataAssociatedConstructingTitleAndBody) return;
				SetAttributeValue("referencetokens", value);
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
        /// source
        /// </summary>
		[DisplayName("Action Card Source")]
		[AttributeLogicalName("source")]
		public eActionCardSource? ActionCardSource
		{	
			get 
			{ 
				var optionSetValue = GetAttributeValue<OptionSetValue>("source");
				if (optionSetValue != null) return (eActionCardSource)optionSetValue.Value;
				else return null;
			}
			set 
			{ 
				if(value == ActionCardSource) return;

				OptionSetValue optionSetValue = null;
				if(value != null) optionSetValue = new OptionSetValue((int)value);
				SetAttributeValue("source", optionSetValue); 
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
		public eActionCardState? ActionCardState
		{	
			get 
			{ 
				var optionSetValue = GetAttributeValue<OptionSetValue>("state");
				if (optionSetValue != null) return (eActionCardState)optionSetValue.Value;
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
        /// title
        /// </summary>
		[DisplayName("Title")]
		[AttributeLogicalName("title")]
		public string Title
		{	
			get { return GetAttributeValue<string>("title"); }
			set
			{ 
				if(value == Title) return;
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
			
		/// <summary>
        /// visibility
        /// </summary>
		[DisplayName("Visibiliy Status of ActionCard")]
		[AttributeLogicalName("visibility")]
		public bool? VisibiliyStatusOfActionCard
		{	
			get { return GetAttributeValue<bool?>("visibility"); }
			set
			{ 
				if(value == VisibiliyStatusOfActionCard) return;
				SetAttributeValue("visibility", value);
			}
		}	
			
		#endregion	

		#region Relations
			/// <summary>
        /// 1:N Get entities for 'ActionCardUserState_ActionCard'
        /// </summary>
		[RelationshipSchemaName("ActionCardUserState_ActionCard")]
		public IEnumerable<ActionCardUserState> ActionCardUserStateActionCard
		{
			get { return GetRelatedEntities<ActionCardUserState>("ActionCardUserState_ActionCard", null); }
			set { SetRelatedEntities("ActionCardUserState_ActionCard", null, value); }
		}
		#endregion

		#region Actions
		#endregion

		#region OptionSetEnums
		public enum eActionCardSource
		{	
		
			[Label("CRM")]
			[Description(@"")]
			CRM = 1, 
		
			[Label("Exchange")]
			[Description(@"")]
			Exchange = 2, 
		}
		
		public enum eActionCardState
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

			/// <summary>cardtype</summary>
			public const string CardTypeENUM = "cardtype";

			/// <summary>cardtypeid</summary>
			public const string CardType = "cardtypeid";

			/// <summary>cardtypeidname</summary>
			public const string Cardtypeidname = "cardtypeidname";

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

			/// <summary>data</summary>
			public const string DataAssociatedWithCardCommandbarActions = "data";

			/// <summary>description</summary>
			public const string CardDescription = "description";

			/// <summary>exchangerate</summary>
			public const string ExchangeRate = "exchangerate";

			/// <summary>expirydate</summary>
			public const string ExpiryDate = "expirydate";

			/// <summary>importsequencenumber</summary>
			public const string ImportSequenceNumber = "importsequencenumber";

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

			/// <summary>msdyn_actioncardregardingid</summary>
			public const string Actioncardregardingid = "msdyn_actioncardregardingid";

			/// <summary>msdyn_regardingobjectid</summary>
			public const string Regardingobjectid = "msdyn_regardingobjectid";

			/// <summary>msdyn_regardingobjectlogicalname</summary>
			public const string Regardingobjectlogicalname = "msdyn_regardingobjectlogicalname";

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

			/// <summary>parentregardingobjectid</summary>
			public const string ParentRegardingObjectId = "parentregardingobjectid";

			/// <summary>parentregardingobjectiddata</summary>
			public const string ParentRegardingObjectIdData = "parentregardingobjectiddata";

			/// <summary>parentregardingobjecttypecode</summary>
			public const string ParentRegardingObjectTypeCode = "parentregardingobjecttypecode";

			/// <summary>priority</summary>
			public const string Priority = "priority";

			/// <summary>recordid</summary>
			public const string RecordId = "recordid";

			/// <summary>recordidname</summary>
			public const string RecordIdName = "recordidname";

			/// <summary>recordidobjecttypecode</summary>
			public const string RecordIdObjectTypeCode = "recordidobjecttypecode";

			/// <summary>recordidobjecttypecode2</summary>
			public const string RecordIdObjectTypeCode2 = "recordidobjecttypecode2";

			/// <summary>referencetokens</summary>
			public const string DataAssociatedConstructingTitleAndBody = "referencetokens";

			/// <summary>regardingobjectid</summary>
			public const string Regarding = "regardingobjectid";

			/// <summary>regardingobjectidname</summary>
			public const string Regardingobjectidname = "regardingobjectidname";

			/// <summary>regardingobjecttypecode</summary>
			public const string Regardingobjecttypecode = "regardingobjecttypecode";

			/// <summary>source</summary>
			public const string ActionCardSource = "source";

			/// <summary>startdate</summary>
			public const string StartDate = "startdate";

			/// <summary>state</summary>
			public const string ActionCardState = "state";

			/// <summary>title</summary>
			public const string Title = "title";

			/// <summary>transactioncurrencyid</summary>
			public const string Currency = "transactioncurrencyid";

			/// <summary>transactioncurrencyidname</summary>
			public const string Transactioncurrencyidname = "transactioncurrencyidname";

			/// <summary>versionnumber</summary>
			public const string VersionNumber = "versionnumber";

			/// <summary>visibility</summary>
			public const string VisibiliyStatusOfActionCard = "visibility";

		}
		#endregion

		#region Schemas
		public static class Schemas 
		{
			/// <summary>1:N ActionCardUserState_ActionCard</summary>
			public const string ActionCardUserStateActionCard = "ActionCardUserState_ActionCard";

		}
		#endregion
	}
}

