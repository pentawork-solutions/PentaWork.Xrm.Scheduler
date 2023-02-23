using System;
using System.Linq;
using System.Diagnostics;
using System.ComponentModel;
using Microsoft.Xrm.Sdk; 
using Microsoft.Xrm.Sdk.Client;
using System.Collections.Generic;

namespace PentaWork.Xrm.Scheduler.Proxies.Entities
{
	[DebuggerDisplay("{ConnectionName}")] 	
	[EntityLogicalName("connection")]
	public sealed class Connection : Entity
	{	
		public static readonly int? EntityTypeCode = 3234;
		public new const string LogicalName = "connection";
		public const string PrimaryIdAttribute = "connectionid";
		public const string PrimaryNameAttribute = "name";
	
		public Connection() : base("connection") { }

		#region Attributes
		/// <summary>
        /// connectionid
        /// </summary>
		[DisplayName("Connection")]
		[AttributeLogicalName("connectionid")]
		public override Guid Id
		{
			get => base.Id;
			set { base.Id = value; SetAttributeValue("connectionid", value); }
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
        /// effectiveend
        /// </summary>
		[DisplayName("Ending")]
		[AttributeLogicalName("effectiveend")]
		public DateTime? Ending
		{	
			get { return GetAttributeValue<DateTime?>("effectiveend"); }
			set
			{ 
				if(value == Ending) return;
				SetAttributeValue("effectiveend", value);
			}
		}	
			
		/// <summary>
        /// effectivestart
        /// </summary>
		[DisplayName("Starting")]
		[AttributeLogicalName("effectivestart")]
		public DateTime? Starting
		{	
			get { return GetAttributeValue<DateTime?>("effectivestart"); }
			set
			{ 
				if(value == Starting) return;
				SetAttributeValue("effectivestart", value);
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
        /// ismaster
        /// </summary>
		[DisplayName("Is Master")]
		[AttributeLogicalName("ismaster")]
		public bool? IsMaster
		{	
			get { return GetAttributeValue<bool?>("ismaster"); }
			set
			{ 
				if(value == IsMaster) return;
				SetAttributeValue("ismaster", value);
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
		[DisplayName("Connection Name")]
		[AttributeLogicalName("name")]
		public string ConnectionName
		{	
			get { return GetAttributeValue<string>("name"); }
			set
			{ 
				if(value == ConnectionName) return;
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
        /// record1id
        /// </summary>
		[DisplayName("Connected From")]
		[AttributeLogicalName("record1id")]
		public EntityReference ConnectedFrom
		{	
			get { return GetAttributeValue<EntityReference>("record1id"); }
			set
			{ 
				if(value == ConnectedFrom) return;
				SetAttributeValue("record1id", value);
			}
		}	
			
		/// <summary>
        /// record1idname
        /// </summary>
		[DisplayName("Name (From)")]
		[AttributeLogicalName("record1idname")]
		public string NameFrom
		{	
			get { return GetAttributeValue<string>("record1idname"); }
			set
			{ 
				if(value == NameFrom) return;
				SetAttributeValue("record1idname", value);
			}
		}	
			
		/// <summary>
        /// record1idobjecttypecode
        /// </summary>
		[DisplayName("record1idobjecttypecode")]
		[AttributeLogicalName("record1idobjecttypecode")]
		public string Record1idobjecttypecode
		{	
			get { return GetAttributeValue<string>("record1idobjecttypecode"); }
			set
			{ 
				if(value == Record1idobjecttypecode) return;
				SetAttributeValue("record1idobjecttypecode", value);
			}
		}	
			
		/// <summary>
        /// record1objecttypecode
        /// </summary>
		[DisplayName("Type (From)")]
		[AttributeLogicalName("record1objecttypecode")]
		public eTypeFrom? TypeFrom
		{	
			get 
			{ 
				var optionSetValue = GetAttributeValue<OptionSetValue>("record1objecttypecode");
				if (optionSetValue != null) return (eTypeFrom)optionSetValue.Value;
				else return null;
			}
			set 
			{ 
				if(value == TypeFrom) return;

				OptionSetValue optionSetValue = null;
				if(value != null) optionSetValue = new OptionSetValue((int)value);
				SetAttributeValue("record1objecttypecode", optionSetValue); 
			}
		}

		/// <summary>
        /// record1roleid
        /// </summary>
		[DisplayName("Role (From)")]
		[AttributeLogicalName("record1roleid")]
		public EntityReference RoleFrom
		{	
			get { return GetAttributeValue<EntityReference>("record1roleid"); }
			set
			{ 
				if(value == RoleFrom) return;
				SetAttributeValue("record1roleid", value);
			}
		}	
			
		/// <summary>
        /// record1roleidname
        /// </summary>
		[DisplayName("record1roleidname")]
		[AttributeLogicalName("record1roleidname")]
		public string Record1roleidname
		{	
			get { return GetAttributeValue<string>("record1roleidname"); }
			set
			{ 
				if(value == Record1roleidname) return;
				SetAttributeValue("record1roleidname", value);
			}
		}	
			
		/// <summary>
        /// record2id
        /// </summary>
		[DisplayName("Connected To")]
		[AttributeLogicalName("record2id")]
		public EntityReference ConnectedTo
		{	
			get { return GetAttributeValue<EntityReference>("record2id"); }
			set
			{ 
				if(value == ConnectedTo) return;
				SetAttributeValue("record2id", value);
			}
		}	
			
		/// <summary>
        /// record2idname
        /// </summary>
		[DisplayName("Name (To)")]
		[AttributeLogicalName("record2idname")]
		public string NameTo
		{	
			get { return GetAttributeValue<string>("record2idname"); }
			set
			{ 
				if(value == NameTo) return;
				SetAttributeValue("record2idname", value);
			}
		}	
			
		/// <summary>
        /// record2idobjecttypecode
        /// </summary>
		[DisplayName("record2idobjecttypecode")]
		[AttributeLogicalName("record2idobjecttypecode")]
		public string Record2idobjecttypecode
		{	
			get { return GetAttributeValue<string>("record2idobjecttypecode"); }
			set
			{ 
				if(value == Record2idobjecttypecode) return;
				SetAttributeValue("record2idobjecttypecode", value);
			}
		}	
			
		/// <summary>
        /// record2objecttypecode
        /// </summary>
		[DisplayName("Type (To)")]
		[AttributeLogicalName("record2objecttypecode")]
		public eTypeTo? TypeTo
		{	
			get 
			{ 
				var optionSetValue = GetAttributeValue<OptionSetValue>("record2objecttypecode");
				if (optionSetValue != null) return (eTypeTo)optionSetValue.Value;
				else return null;
			}
			set 
			{ 
				if(value == TypeTo) return;

				OptionSetValue optionSetValue = null;
				if(value != null) optionSetValue = new OptionSetValue((int)value);
				SetAttributeValue("record2objecttypecode", optionSetValue); 
			}
		}

		/// <summary>
        /// record2roleid
        /// </summary>
		[DisplayName("Role (To)")]
		[AttributeLogicalName("record2roleid")]
		public EntityReference RoleTo
		{	
			get { return GetAttributeValue<EntityReference>("record2roleid"); }
			set
			{ 
				if(value == RoleTo) return;
				SetAttributeValue("record2roleid", value);
			}
		}	
			
		/// <summary>
        /// record2roleidname
        /// </summary>
		[DisplayName("record2roleidname")]
		[AttributeLogicalName("record2roleidname")]
		public string Record2roleidname
		{	
			get { return GetAttributeValue<string>("record2roleidname"); }
			set
			{ 
				if(value == Record2roleidname) return;
				SetAttributeValue("record2roleidname", value);
			}
		}	
			
		/// <summary>
        /// relatedconnectionid
        /// </summary>
		[DisplayName("Reciprocal Connection")]
		[AttributeLogicalName("relatedconnectionid")]
		public EntityReference ReciprocalConnection
		{	
			get { return GetAttributeValue<EntityReference>("relatedconnectionid"); }
			set
			{ 
				if(value == ReciprocalConnection) return;
				SetAttributeValue("relatedconnectionid", value);
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
			
		#endregion	

		#region Relations
			/// <summary>
        /// 1:N Get entities for 'Connection_AsyncOperations'
        /// </summary>
		[RelationshipSchemaName("Connection_AsyncOperations")]
		public IEnumerable<SystemJob> ConnectionAsyncOperations
		{
			get { return GetRelatedEntities<SystemJob>("Connection_AsyncOperations", null); }
			set { SetRelatedEntities("Connection_AsyncOperations", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'connection_principalobjectattributeaccess'
        /// </summary>
		[RelationshipSchemaName("connection_principalobjectattributeaccess")]
		public IEnumerable<FieldSharing> ConnectionPrincipalobjectattributeaccess
		{
			get { return GetRelatedEntities<FieldSharing>("connection_principalobjectattributeaccess", null); }
			set { SetRelatedEntities("connection_principalobjectattributeaccess", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'Connection_ProcessSessions'
        /// </summary>
		[RelationshipSchemaName("Connection_ProcessSessions")]
		public IEnumerable<ProcessSession> ConnectionProcessSessions
		{
			get { return GetRelatedEntities<ProcessSession>("Connection_ProcessSessions", null); }
			set { SetRelatedEntities("Connection_ProcessSessions", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'connection_related_connection'
        /// </summary>
		[RelationshipSchemaName("connection_related_connection")]
		public IEnumerable<Connection> ConnectionRelatedConnection
		{
			get { return GetRelatedEntities<Connection>("connection_related_connection", null); }
			set { SetRelatedEntities("connection_related_connection", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'Connection_SyncErrors'
        /// </summary>
		[RelationshipSchemaName("Connection_SyncErrors")]
		public IEnumerable<SyncError> ConnectionSyncErrors
		{
			get { return GetRelatedEntities<SyncError>("Connection_SyncErrors", null); }
			set { SetRelatedEntities("Connection_SyncErrors", null, value); }
		}
		#endregion

		#region Actions
		#endregion

		#region OptionSetEnums
		public enum eTypeFrom
		{	
		
			[Label("Knowledge Base Record")]
			[Description(@"Metadata of knowledge base (KB) articles associated with Microsoft Dynamics 365 entities.")]
			KnowledgeBaseRecord = 9930, 
		
			[Label("Scheduling Group")]
			[Description(@"Resource group or team whose members can be scheduled for a service.")]
			SchedulingGroup = 4005, 
		
			[Label("Contact")]
			[Description(@"Person with whom a business unit has a relationship, such as customer, supplier, and colleague.")]
			Contact = 2, 
		
			[Label("Account")]
			[Description(@"Business that represents a customer or potential customer. The company that is billed in business transactions.")]
			Account = 1, 
		
			[Label("Campaign")]
			[Description(@"Container for campaign activities and responses, sales literature, products, and lists to create, plan, execute, and track the results of a specific marketing campaign through its life.")]
			Campaign = 4400, 
		
			[Label("Quote")]
			[Description(@"Formal offer for products and/or services, proposed at specific prices and related payment terms, which is sent to a prospective customer.")]
			Quote = 1084, 
		
			[Label("Process Session")]
			[Description(@"Information that is generated when a dialog is run. Every time that you run a dialog, a dialog session is created.")]
			ProcessSession = 4710, 
		
			[Label("Order")]
			[Description(@"Quote that has been accepted.")]
			Order = 1088, 
		
			[Label("Fax")]
			[Description(@"Activity that tracks call outcome and number of pages for a fax and optionally stores an electronic copy of the document.")]
			Fax = 4204, 
		
			[Label("Knowledge Article")]
			[Description(@"Organizational knowledge for internal and external use.")]
			KnowledgeArticle = 9953, 
		
			[Label("Entitlement")]
			[Description(@"Defines the amount and type of support a customer should receive.")]
			Entitlement = 9700, 
		
			[Label("Task")]
			[Description(@"Generic activity representing work needed to be done.")]
			Task = 4212, 
		
			[Label("Contract")]
			[Description(@"Agreement to provide customer service during a specified amount of time or number of cases.")]
			Contract = 1010, 
		
			[Label("Case")]
			[Description(@"Service request case associated with a contract.")]
			Case = 112, 
		
			[Label("Letter")]
			[Description(@"Activity that tracks the delivery of a letter. The activity can contain the electronic copy of the letter.")]
			Letter = 4207, 
		
			[Label("Email")]
			[Description(@"Activity that is delivered using email protocols.")]
			Email = 4202, 
		
			[Label("Social Activity")]
			[Description(@"For internal use only.")]
			SocialActivity = 4216, 
		
			[Label("Social Profile")]
			[Description(@"This entity is used to store social profile information of its associated account and contacts on different social channels.")]
			SocialProfile = 99, 
		
			[Label("Entitlement Template Channel")]
			[Description(@"Contains predefined support terms for a channel to create entitlements for customers.")]
			EntitlementTemplateChannel = 9703, 
		
			[Label("User")]
			[Description(@"Person with access to the Microsoft CRM system and who owns objects in the Microsoft CRM database.")]
			User = 8, 
		
			[Label("Campaign Activity")]
			[Description(@"Task performed, or to be performed, by a user for planning or running a campaign.")]
			CampaignActivity = 4402, 
		
			[Label("Product")]
			[Description(@"Information about products and their pricing information.")]
			Product = 1024, 
		
			[Label("Resource Group")]
			[Description(@"Group or collection of people, equipment, and/or facilities that can be scheduled.")]
			ResourceGroup = 4007, 
		
			[Label("Profile Album")]
			[Description(@"Contains user profile images that are stored as attachments and displayed in posts.")]
			ProfileAlbum = 10101, 
		
			[Label("Recurring Appointment")]
			[Description(@"The Master appointment of a recurring appointment series.")]
			RecurringAppointment = 4251, 
		
			[Label("Appointment")]
			[Description(@"Commitment representing a time interval with start/end times and duration.")]
			Appointment = 4201, 
		
			[Label("Activity")]
			[Description(@"Task performed, or to be performed, by a user. An activity is any action for which an entry can be made on a calendar.")]
			Activity = 4200, 
		
			[Label("Invoice")]
			[Description(@"Order that has been billed.")]
			Invoice = 1090, 
		
			[Label("Opportunity")]
			[Description(@"Potential revenue-generating event, or sale to an account, which needs to be tracked through a sales process to completion.")]
			Opportunity = 3, 
		
			[Label("Goal")]
			[Description(@"Target objective for a user or a team for a specified time period.")]
			Goal = 9600, 
		
			[Label("Position")]
			[Description(@"Position of a user in the hierarchy")]
			Position = 50, 
		
			[Label("Entitlement Channel")]
			[Description(@"Defines the amount and type of support for a channel.")]
			EntitlementChannel = 9701, 
		
			[Label("Competitor")]
			[Description(@"Business competing for the sale represented by a lead or opportunity.")]
			Competitor = 123, 
		
			[Label("Service Activity")]
			[Description(@"Activity offered by the organization to satisfy its customer's needs. Each service activity includes date, time, duration, and required resources.")]
			ServiceActivity = 4214, 
		
			[Label("Team")]
			[Description(@"Collection of system users that routinely collaborate. Teams can be used to simplify record sharing and provide team members with common access to organization data when team members belong to different Business Units.")]
			Team = 9, 
		
			[Label("Facility/Equipment")]
			[Description(@"Resource that can be scheduled.")]
			FacilityEquipment = 4000, 
		
			[Label("Territory")]
			[Description(@"Territory represents sales regions.")]
			Territory = 2013, 
		
			[Label("Channel Access Profile Rule")]
			[Description(@"Defines the rules for automatically associating channel access profiles to external party records.For internal use only")]
			ChannelAccessProfileRule = 9400, 
		
			[Label("Phone Call")]
			[Description(@"Activity to track a telephone call.")]
			PhoneCall = 4210, 
		
			[Label("Lead")]
			[Description(@"Prospect or potential sales opportunity. Leads are converted into accounts, contacts, or opportunities when they are qualified. Otherwise, they are deleted or archived.")]
			Lead = 4, 
		
			[Label("Marketing List")]
			[Description(@"Group of existing or potential customers created for a marketing campaign or other sales purposes.")]
			MarketingList = 4300, 
		
			[Label("Price List")]
			[Description(@"Entity that defines pricing levels.")]
			PriceList = 1022, 
		}
		
		public enum eTypeTo
		{	
		
			[Label("Knowledge Base Record")]
			[Description(@"Metadata of knowledge base (KB) articles associated with Microsoft Dynamics 365 entities.")]
			KnowledgeBaseRecord = 9930, 
		
			[Label("Team")]
			[Description(@"Collection of system users that routinely collaborate. Teams can be used to simplify record sharing and provide team members with common access to organization data when team members belong to different Business Units.")]
			Team = 9, 
		
			[Label("Knowledge Article")]
			[Description(@"Organizational knowledge for internal and external use.")]
			KnowledgeArticle = 9953, 
		
			[Label("Process Session")]
			[Description(@"Information that is generated when a dialog is run. Every time that you run a dialog, a dialog session is created.")]
			ProcessSession = 4710, 
		
			[Label("Letter")]
			[Description(@"Activity that tracks the delivery of a letter. The activity can contain the electronic copy of the letter.")]
			Letter = 4207, 
		
			[Label("Social Activity")]
			[Description(@"For internal use only.")]
			SocialActivity = 4216, 
		
			[Label("Entitlement")]
			[Description(@"Defines the amount and type of support a customer should receive.")]
			Entitlement = 9700, 
		
			[Label("Email")]
			[Description(@"Activity that is delivered using email protocols.")]
			Email = 4202, 
		
			[Label("Order")]
			[Description(@"Quote that has been accepted.")]
			Order = 1088, 
		
			[Label("Invoice")]
			[Description(@"Order that has been billed.")]
			Invoice = 1090, 
		
			[Label("Task")]
			[Description(@"Generic activity representing work needed to be done.")]
			Task = 4212, 
		
			[Label("Marketing List")]
			[Description(@"Group of existing or potential customers created for a marketing campaign or other sales purposes.")]
			MarketingList = 4300, 
		
			[Label("Profile Album")]
			[Description(@"Contains user profile images that are stored as attachments and displayed in posts.")]
			ProfileAlbum = 10101, 
		
			[Label("Entitlement Channel")]
			[Description(@"Defines the amount and type of support for a channel.")]
			EntitlementChannel = 9701, 
		
			[Label("Scheduling Group")]
			[Description(@"Resource group or team whose members can be scheduled for a service.")]
			SchedulingGroup = 4005, 
		
			[Label("Position")]
			[Description(@"Position of a user in the hierarchy")]
			Position = 50, 
		
			[Label("Case")]
			[Description(@"Service request case associated with a contract.")]
			Case = 112, 
		
			[Label("Social Profile")]
			[Description(@"This entity is used to store social profile information of its associated account and contacts on different social channels.")]
			SocialProfile = 99, 
		
			[Label("Campaign Activity")]
			[Description(@"Task performed, or to be performed, by a user for planning or running a campaign.")]
			CampaignActivity = 4402, 
		
			[Label("Quote")]
			[Description(@"Formal offer for products and/or services, proposed at specific prices and related payment terms, which is sent to a prospective customer.")]
			Quote = 1084, 
		
			[Label("Resource Group")]
			[Description(@"Group or collection of people, equipment, and/or facilities that can be scheduled.")]
			ResourceGroup = 4007, 
		
			[Label("Phone Call")]
			[Description(@"Activity to track a telephone call.")]
			PhoneCall = 4210, 
		
			[Label("Product")]
			[Description(@"Information about products and their pricing information.")]
			Product = 1024, 
		
			[Label("Competitor")]
			[Description(@"Business competing for the sale represented by a lead or opportunity.")]
			Competitor = 123, 
		
			[Label("Facility/Equipment")]
			[Description(@"Resource that can be scheduled.")]
			FacilityEquipment = 4000, 
		
			[Label("Appointment")]
			[Description(@"Commitment representing a time interval with start/end times and duration.")]
			Appointment = 4201, 
		
			[Label("Price List")]
			[Description(@"Entity that defines pricing levels.")]
			PriceList = 1022, 
		
			[Label("Territory")]
			[Description(@"Territory represents sales regions.")]
			Territory = 2013, 
		
			[Label("Contract")]
			[Description(@"Agreement to provide customer service during a specified amount of time or number of cases.")]
			Contract = 1010, 
		
			[Label("Recurring Appointment")]
			[Description(@"The Master appointment of a recurring appointment series.")]
			RecurringAppointment = 4251, 
		
			[Label("Contact")]
			[Description(@"Person with whom a business unit has a relationship, such as customer, supplier, and colleague.")]
			Contact = 2, 
		
			[Label("User")]
			[Description(@"Person with access to the Microsoft CRM system and who owns objects in the Microsoft CRM database.")]
			User = 8, 
		
			[Label("Goal")]
			[Description(@"Target objective for a user or a team for a specified time period.")]
			Goal = 9600, 
		
			[Label("Opportunity")]
			[Description(@"Potential revenue-generating event, or sale to an account, which needs to be tracked through a sales process to completion.")]
			Opportunity = 3, 
		
			[Label("Account")]
			[Description(@"Business that represents a customer or potential customer. The company that is billed in business transactions.")]
			Account = 1, 
		
			[Label("Fax")]
			[Description(@"Activity that tracks call outcome and number of pages for a fax and optionally stores an electronic copy of the document.")]
			Fax = 4204, 
		
			[Label("Lead")]
			[Description(@"Prospect or potential sales opportunity. Leads are converted into accounts, contacts, or opportunities when they are qualified. Otherwise, they are deleted or archived.")]
			Lead = 4, 
		
			[Label("Entitlement Template Channel")]
			[Description(@"Contains predefined support terms for a channel to create entitlements for customers.")]
			EntitlementTemplateChannel = 9703, 
		
			[Label("Channel Access Profile Rule")]
			[Description(@"Defines the rules for automatically associating channel access profiles to external party records.For internal use only")]
			ChannelAccessProfileRule = 9400, 
		
			[Label("Campaign")]
			[Description(@"Container for campaign activities and responses, sales literature, products, and lists to create, plan, execute, and track the results of a specific marketing campaign through its life.")]
			Campaign = 4400, 
		
			[Label("Activity")]
			[Description(@"Task performed, or to be performed, by a user. An activity is any action for which an entry can be made on a calendar.")]
			Activity = 4200, 
		
			[Label("Service Activity")]
			[Description(@"Activity offered by the organization to satisfy its customer's needs. Each service activity includes date, time, duration, and required resources.")]
			ServiceActivity = 4214, 
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
			/// <summary>connectionid</summary>
			public const string ConnectionId = "connectionid";

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

			/// <summary>effectiveend</summary>
			public const string Ending = "effectiveend";

			/// <summary>effectivestart</summary>
			public const string Starting = "effectivestart";

			/// <summary>entityimage_timestamp</summary>
			public const string EntityimageTimestamp = "entityimage_timestamp";

			/// <summary>entityimage_url</summary>
			public const string EntityimageUrl = "entityimage_url";

			/// <summary>entityimageid</summary>
			public const string EntityImageId = "entityimageid";

			/// <summary>exchangerate</summary>
			public const string ExchangeRate = "exchangerate";

			/// <summary>importsequencenumber</summary>
			public const string ImportSequenceNumber = "importsequencenumber";

			/// <summary>ismaster</summary>
			public const string IsMaster = "ismaster";

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
			public const string ConnectionName = "name";

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

			/// <summary>record1id</summary>
			public const string ConnectedFrom = "record1id";

			/// <summary>record1idname</summary>
			public const string NameFrom = "record1idname";

			/// <summary>record1idobjecttypecode</summary>
			public const string Record1idobjecttypecode = "record1idobjecttypecode";

			/// <summary>record1objecttypecode</summary>
			public const string TypeFrom = "record1objecttypecode";

			/// <summary>record1roleid</summary>
			public const string RoleFrom = "record1roleid";

			/// <summary>record1roleidname</summary>
			public const string Record1roleidname = "record1roleidname";

			/// <summary>record2id</summary>
			public const string ConnectedTo = "record2id";

			/// <summary>record2idname</summary>
			public const string NameTo = "record2idname";

			/// <summary>record2idobjecttypecode</summary>
			public const string Record2idobjecttypecode = "record2idobjecttypecode";

			/// <summary>record2objecttypecode</summary>
			public const string TypeTo = "record2objecttypecode";

			/// <summary>record2roleid</summary>
			public const string RoleTo = "record2roleid";

			/// <summary>record2roleidname</summary>
			public const string Record2roleidname = "record2roleidname";

			/// <summary>relatedconnectionid</summary>
			public const string ReciprocalConnection = "relatedconnectionid";

			/// <summary>statecode</summary>
			public const string Status = "statecode";

			/// <summary>statuscode</summary>
			public const string StatusReason = "statuscode";

			/// <summary>transactioncurrencyid</summary>
			public const string Currency = "transactioncurrencyid";

			/// <summary>transactioncurrencyidname</summary>
			public const string Transactioncurrencyidname = "transactioncurrencyidname";

			/// <summary>versionnumber</summary>
			public const string VersionNumber = "versionnumber";

		}
		#endregion

		#region Schemas
		public static class Schemas 
		{
			/// <summary>1:N Connection_AsyncOperations</summary>
			public const string ConnectionAsyncOperations = "Connection_AsyncOperations";

			/// <summary>1:N connection_principalobjectattributeaccess</summary>
			public const string ConnectionPrincipalobjectattributeaccess = "connection_principalobjectattributeaccess";

			/// <summary>1:N Connection_ProcessSessions</summary>
			public const string ConnectionProcessSessions = "Connection_ProcessSessions";

			/// <summary>1:N connection_related_connection</summary>
			public const string ConnectionRelatedConnection = "connection_related_connection";

			/// <summary>1:N Connection_SyncErrors</summary>
			public const string ConnectionSyncErrors = "Connection_SyncErrors";

		}
		#endregion
	}
}

