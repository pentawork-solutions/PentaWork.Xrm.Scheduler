using System;
using System.Linq;
using System.Diagnostics;
using System.ComponentModel;
using Microsoft.Xrm.Sdk; 
using Microsoft.Xrm.Sdk.Client;
using System.Collections.Generic;

namespace PentaWork.Xrm.Scheduler.Proxies.Entities
{
	[DebuggerDisplay("{TeamName}")] 	
	[EntityLogicalName("team")]
	public sealed class Team : Entity
	{	
		public static readonly int? EntityTypeCode = 9;
		public new const string LogicalName = "team";
		public const string PrimaryIdAttribute = "teamid";
		public const string PrimaryNameAttribute = "name";
	
		public Team() : base("team") { }

		#region Attributes
		/// <summary>
        /// administratorid
        /// </summary>
		[DisplayName("Administrator")]
		[AttributeLogicalName("administratorid")]
		public EntityReference Administrator
		{	
			get { return GetAttributeValue<EntityReference>("administratorid"); }
			set
			{ 
				if(value == Administrator) return;
				SetAttributeValue("administratorid", value);
			}
		}	
			
		/// <summary>
        /// administratoridname
        /// </summary>
		[DisplayName("administratoridname")]
		[AttributeLogicalName("administratoridname")]
		public string Administratoridname
		{	
			get { return GetAttributeValue<string>("administratoridname"); }
			set
			{ 
				if(value == Administratoridname) return;
				SetAttributeValue("administratoridname", value);
			}
		}	
			
		/// <summary>
        /// administratoridyominame
        /// </summary>
		[DisplayName("administratoridyominame")]
		[AttributeLogicalName("administratoridyominame")]
		public string Administratoridyominame
		{	
			get { return GetAttributeValue<string>("administratoridyominame"); }
			set
			{ 
				if(value == Administratoridyominame) return;
				SetAttributeValue("administratoridyominame", value);
			}
		}	
			
		/// <summary>
        /// azureactivedirectoryobjectid
        /// </summary>
		[DisplayName("Azure AD Object Id for a group")]
		[AttributeLogicalName("azureactivedirectoryobjectid")]
		public Guid AzureADObjectIdForAGroupId
		{	
			get { return GetAttributeValue<Guid>("azureactivedirectoryobjectid"); }
			set
			{ 
				if(value == AzureADObjectIdForAGroupId) return;
				SetAttributeValue("azureactivedirectoryobjectid", value);
			}
		}	
			
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
		[DisplayName("Email")]
		[AttributeLogicalName("emailaddress")]
		public string Email
		{	
			get { return GetAttributeValue<string>("emailaddress"); }
			set
			{ 
				if(value == Email) return;
				SetAttributeValue("emailaddress", value);
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
        /// isdefault
        /// </summary>
		[DisplayName("Is Default")]
		[AttributeLogicalName("isdefault")]
		public bool? IsDefault
		{	
			get { return GetAttributeValue<bool?>("isdefault"); }
			set
			{ 
				if(value == IsDefault) return;
				SetAttributeValue("isdefault", value);
			}
		}	
			
		/// <summary>
        /// membershiptype
        /// </summary>
		[DisplayName("Membership Type")]
		[AttributeLogicalName("membershiptype")]
		public eMembershipType? MembershipType
		{	
			get 
			{ 
				var optionSetValue = GetAttributeValue<OptionSetValue>("membershiptype");
				if (optionSetValue != null) return (eMembershipType)optionSetValue.Value;
				else return null;
			}
			set 
			{ 
				if(value == MembershipType) return;

				OptionSetValue optionSetValue = null;
				if(value != null) optionSetValue = new OptionSetValue((int)value);
				SetAttributeValue("membershiptype", optionSetValue); 
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
		[DisplayName("Team Name")]
		[AttributeLogicalName("name")]
		public string TeamName
		{	
			get { return GetAttributeValue<string>("name"); }
			set
			{ 
				if(value == TeamName) return;
				SetAttributeValue("name", value);
			}
		}	
			
		/// <summary>
        /// organizationid
        /// </summary>
		[DisplayName("Organization")]
		[AttributeLogicalName("organizationid")]
		public Guid OrganizationId
		{	
			get { return GetAttributeValue<Guid>("organizationid"); }
			set
			{ 
				if(value == OrganizationId) return;
				SetAttributeValue("organizationid", value);
			}
		}	
			
		/// <summary>
        /// organizationidname
        /// </summary>
		[DisplayName("organizationidname")]
		[AttributeLogicalName("organizationidname")]
		public string Organizationidname
		{	
			get { return GetAttributeValue<string>("organizationidname"); }
			set
			{ 
				if(value == Organizationidname) return;
				SetAttributeValue("organizationidname", value);
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
        /// processid
        /// </summary>
		[DisplayName("Process")]
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
        /// queueid
        /// </summary>
		[DisplayName("Default Queue")]
		[AttributeLogicalName("queueid")]
		public EntityReference DefaultQueue
		{	
			get { return GetAttributeValue<EntityReference>("queueid"); }
			set
			{ 
				if(value == DefaultQueue) return;
				SetAttributeValue("queueid", value);
			}
		}	
			
		/// <summary>
        /// queueidname
        /// </summary>
		[DisplayName("queueidname")]
		[AttributeLogicalName("queueidname")]
		public string Queueidname
		{	
			get { return GetAttributeValue<string>("queueidname"); }
			set
			{ 
				if(value == Queueidname) return;
				SetAttributeValue("queueidname", value);
			}
		}	
			
		/// <summary>
        /// regardingobjectid
        /// </summary>
		[DisplayName("Regarding Object Id")]
		[AttributeLogicalName("regardingobjectid")]
		public EntityReference RegardingObjectId
		{	
			get { return GetAttributeValue<EntityReference>("regardingobjectid"); }
			set
			{ 
				if(value == RegardingObjectId) return;
				SetAttributeValue("regardingobjectid", value);
			}
		}	
			
		/// <summary>
        /// regardingobjecttypecode
        /// </summary>
		[DisplayName("Regarding Object Type")]
		[AttributeLogicalName("regardingobjecttypecode")]
		public string RegardingObjectType
		{	
			get { return GetAttributeValue<string>("regardingobjecttypecode"); }
			set
			{ 
				if(value == RegardingObjectType) return;
				SetAttributeValue("regardingobjecttypecode", value);
			}
		}	
			
		/// <summary>
        /// stageid
        /// </summary>
		[DisplayName("(Deprecated) Process Stage")]
		[AttributeLogicalName("stageid")]
		public Guid DeprecatedProcessStageId
		{	
			get { return GetAttributeValue<Guid>("stageid"); }
			set
			{ 
				if(value == DeprecatedProcessStageId) return;
				SetAttributeValue("stageid", value);
			}
		}	
			
		/// <summary>
        /// systemmanaged
        /// </summary>
		[DisplayName("Is System Managed")]
		[AttributeLogicalName("systemmanaged")]
		public bool? IsSystemManaged
		{	
			get { return GetAttributeValue<bool?>("systemmanaged"); }
			set
			{ 
				if(value == IsSystemManaged) return;
				SetAttributeValue("systemmanaged", value);
			}
		}	
			
		/// <summary>
        /// teamid
        /// </summary>
		[DisplayName("Team")]
		[AttributeLogicalName("teamid")]
		public override Guid Id
		{
			get => base.Id;
			set { base.Id = value; SetAttributeValue("teamid", value); }
		}

							/// <summary>
        /// teamtemplateid
        /// </summary>
		[DisplayName("Team Template Identifier")]
		[AttributeLogicalName("teamtemplateid")]
		public EntityReference TeamTemplateIdentifier
		{	
			get { return GetAttributeValue<EntityReference>("teamtemplateid"); }
			set
			{ 
				if(value == TeamTemplateIdentifier) return;
				SetAttributeValue("teamtemplateid", value);
			}
		}	
			
		/// <summary>
        /// teamtype
        /// </summary>
		[DisplayName("Team Type")]
		[AttributeLogicalName("teamtype")]
		public eTeamType? TeamType
		{	
			get 
			{ 
				var optionSetValue = GetAttributeValue<OptionSetValue>("teamtype");
				if (optionSetValue != null) return (eTeamType)optionSetValue.Value;
				else return null;
			}
			set 
			{ 
				if(value == TeamType) return;

				OptionSetValue optionSetValue = null;
				if(value != null) optionSetValue = new OptionSetValue((int)value);
				SetAttributeValue("teamtype", optionSetValue); 
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
        /// versionnumber
        /// </summary>
		[DisplayName("Version number")]
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
        /// yominame
        /// </summary>
		[DisplayName("Yomi Name")]
		[AttributeLogicalName("yominame")]
		public string YomiName
		{	
			get { return GetAttributeValue<string>("yominame"); }
			set
			{ 
				if(value == YomiName) return;
				SetAttributeValue("yominame", value);
			}
		}	
			
		#endregion	

		#region Relations
			/// <summary>
        /// 1:N Get entities for 'ImportFile_Team'
        /// </summary>
		[RelationshipSchemaName("ImportFile_Team")]
		public IEnumerable<ImportSourceFile> ImportFileTeam
		{
			get { return GetRelatedEntities<ImportSourceFile>("ImportFile_Team", null); }
			set { SetRelatedEntities("ImportFile_Team", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lead_owning_team'
        /// </summary>
		[RelationshipSchemaName("lead_owning_team")]
		public IEnumerable<Lead> LeadOwningTeam
		{
			get { return GetRelatedEntities<Lead>("lead_owning_team", null); }
			set { SetRelatedEntities("lead_owning_team", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'OwningTeam_postfollows'
        /// </summary>
		[RelationshipSchemaName("OwningTeam_postfollows")]
		public IEnumerable<Follow> OwningTeamPostfollows
		{
			get { return GetRelatedEntities<Follow>("OwningTeam_postfollows", null); }
			set { SetRelatedEntities("OwningTeam_postfollows", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'team_accounts'
        /// </summary>
		[RelationshipSchemaName("team_accounts")]
		public IEnumerable<Account> TeamAccounts
		{
			get { return GetRelatedEntities<Account>("team_accounts", null); }
			set { SetRelatedEntities("team_accounts", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'team_activity'
        /// </summary>
		[RelationshipSchemaName("team_activity")]
		public IEnumerable<Activity> TeamActivity
		{
			get { return GetRelatedEntities<Activity>("team_activity", null); }
			set { SetRelatedEntities("team_activity", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'team_activitymonitor'
        /// </summary>
		[RelationshipSchemaName("team_activitymonitor")]
		public IEnumerable<ActivityMonitor> TeamActivitymonitor
		{
			get { return GetRelatedEntities<ActivityMonitor>("team_activitymonitor", null); }
			set { SetRelatedEntities("team_activitymonitor", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'team_adminsettingsentity'
        /// </summary>
		[RelationshipSchemaName("team_adminsettingsentity")]
		public IEnumerable<AdminSettingsEntity> TeamAdminsettingsentity
		{
			get { return GetRelatedEntities<AdminSettingsEntity>("team_adminsettingsentity", null); }
			set { SetRelatedEntities("team_adminsettingsentity", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'team_annotations'
        /// </summary>
		[RelationshipSchemaName("team_annotations")]
		public IEnumerable<Note> TeamAnnotations
		{
			get { return GetRelatedEntities<Note>("team_annotations", null); }
			set { SetRelatedEntities("team_annotations", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'team_appointment'
        /// </summary>
		[RelationshipSchemaName("team_appointment")]
		public IEnumerable<Appointment> TeamAppointment
		{
			get { return GetRelatedEntities<Appointment>("team_appointment", null); }
			set { SetRelatedEntities("team_appointment", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'team_asyncoperation'
        /// </summary>
		[RelationshipSchemaName("team_asyncoperation")]
		public IEnumerable<SystemJob> TeamAsyncoperation
		{
			get { return GetRelatedEntities<SystemJob>("team_asyncoperation", null); }
			set { SetRelatedEntities("team_asyncoperation", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'Team_AsyncOperations'
        /// </summary>
		[RelationshipSchemaName("Team_AsyncOperations")]
		public IEnumerable<SystemJob> TeamAsyncOperations
		{
			get { return GetRelatedEntities<SystemJob>("Team_AsyncOperations", null); }
			set { SetRelatedEntities("Team_AsyncOperations", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'team_bookableresource'
        /// </summary>
		[RelationshipSchemaName("team_bookableresource")]
		public IEnumerable<BookableResource> TeamBookableresource
		{
			get { return GetRelatedEntities<BookableResource>("team_bookableresource", null); }
			set { SetRelatedEntities("team_bookableresource", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'team_bookableresourcebooking'
        /// </summary>
		[RelationshipSchemaName("team_bookableresourcebooking")]
		public IEnumerable<BookableResourceBooking> TeamBookableresourcebooking
		{
			get { return GetRelatedEntities<BookableResourceBooking>("team_bookableresourcebooking", null); }
			set { SetRelatedEntities("team_bookableresourcebooking", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'team_bookableresourcebookingheader'
        /// </summary>
		[RelationshipSchemaName("team_bookableresourcebookingheader")]
		public IEnumerable<BookableResourceBookingHeader> TeamBookableresourcebookingheader
		{
			get { return GetRelatedEntities<BookableResourceBookingHeader>("team_bookableresourcebookingheader", null); }
			set { SetRelatedEntities("team_bookableresourcebookingheader", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'team_bookableresourcecategory'
        /// </summary>
		[RelationshipSchemaName("team_bookableresourcecategory")]
		public IEnumerable<BookableResourceCategory> TeamBookableresourcecategory
		{
			get { return GetRelatedEntities<BookableResourceCategory>("team_bookableresourcecategory", null); }
			set { SetRelatedEntities("team_bookableresourcecategory", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'team_bookableresourcecategoryassn'
        /// </summary>
		[RelationshipSchemaName("team_bookableresourcecategoryassn")]
		public IEnumerable<BookableResourceCategoryAssn> TeamBookableresourcecategoryassn
		{
			get { return GetRelatedEntities<BookableResourceCategoryAssn>("team_bookableresourcecategoryassn", null); }
			set { SetRelatedEntities("team_bookableresourcecategoryassn", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'team_bookableresourcecharacteristic'
        /// </summary>
		[RelationshipSchemaName("team_bookableresourcecharacteristic")]
		public IEnumerable<BookableResourceCharacteristic> TeamBookableresourcecharacteristic
		{
			get { return GetRelatedEntities<BookableResourceCharacteristic>("team_bookableresourcecharacteristic", null); }
			set { SetRelatedEntities("team_bookableresourcecharacteristic", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'team_bookableresourcegroup'
        /// </summary>
		[RelationshipSchemaName("team_bookableresourcegroup")]
		public IEnumerable<BookableResourceGroup> TeamBookableresourcegroup
		{
			get { return GetRelatedEntities<BookableResourceGroup>("team_bookableresourcegroup", null); }
			set { SetRelatedEntities("team_bookableresourcegroup", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'team_bookingstatus'
        /// </summary>
		[RelationshipSchemaName("team_bookingstatus")]
		public IEnumerable<BookingStatus> TeamBookingstatus
		{
			get { return GetRelatedEntities<BookingStatus>("team_bookingstatus", null); }
			set { SetRelatedEntities("team_bookingstatus", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'team_bot'
        /// </summary>
		[RelationshipSchemaName("team_bot")]
		public IEnumerable<Chatbot> TeamBot
		{
			get { return GetRelatedEntities<Chatbot>("team_bot", null); }
			set { SetRelatedEntities("team_bot", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'team_botcomponent'
        /// </summary>
		[RelationshipSchemaName("team_botcomponent")]
		public IEnumerable<ChatbotSubcomponent> TeamBotcomponent
		{
			get { return GetRelatedEntities<ChatbotSubcomponent>("team_botcomponent", null); }
			set { SetRelatedEntities("team_botcomponent", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'Team_BulkDeleteFailures'
        /// </summary>
		[RelationshipSchemaName("Team_BulkDeleteFailures")]
		public IEnumerable<BulkDeleteFailure> TeamBulkDeleteFailures
		{
			get { return GetRelatedEntities<BulkDeleteFailure>("Team_BulkDeleteFailures", null); }
			set { SetRelatedEntities("Team_BulkDeleteFailures", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'team_BulkOperation'
        /// </summary>
		[RelationshipSchemaName("team_BulkOperation")]
		public IEnumerable<QuickCampaign> TeamBulkOperation
		{
			get { return GetRelatedEntities<QuickCampaign>("team_BulkOperation", null); }
			set { SetRelatedEntities("team_BulkOperation", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'team_campaignactivity'
        /// </summary>
		[RelationshipSchemaName("team_campaignactivity")]
		public IEnumerable<CampaignActivity> TeamCampaignactivity
		{
			get { return GetRelatedEntities<CampaignActivity>("team_campaignactivity", null); }
			set { SetRelatedEntities("team_campaignactivity", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'team_campaignresponse'
        /// </summary>
		[RelationshipSchemaName("team_campaignresponse")]
		public IEnumerable<CampaignResponse> TeamCampaignresponse
		{
			get { return GetRelatedEntities<CampaignResponse>("team_campaignresponse", null); }
			set { SetRelatedEntities("team_campaignresponse", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'team_Campaigns'
        /// </summary>
		[RelationshipSchemaName("team_Campaigns")]
		public IEnumerable<Campaign> TeamCampaigns
		{
			get { return GetRelatedEntities<Campaign>("team_Campaigns", null); }
			set { SetRelatedEntities("team_Campaigns", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'team_characteristic'
        /// </summary>
		[RelationshipSchemaName("team_characteristic")]
		public IEnumerable<Characteristic> TeamCharacteristic
		{
			get { return GetRelatedEntities<Characteristic>("team_characteristic", null); }
			set { SetRelatedEntities("team_characteristic", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'team_connectionreference'
        /// </summary>
		[RelationshipSchemaName("team_connectionreference")]
		public IEnumerable<ConnectionReference> TeamConnectionreference
		{
			get { return GetRelatedEntities<ConnectionReference>("team_connectionreference", null); }
			set { SetRelatedEntities("team_connectionreference", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'team_connections1'
        /// </summary>
		[RelationshipSchemaName("team_connections1")]
		public IEnumerable<Connection> TeamConnections1
		{
			get { return GetRelatedEntities<Connection>("team_connections1", null); }
			set { SetRelatedEntities("team_connections1", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'team_connections2'
        /// </summary>
		[RelationshipSchemaName("team_connections2")]
		public IEnumerable<Connection> TeamConnections2
		{
			get { return GetRelatedEntities<Connection>("team_connections2", null); }
			set { SetRelatedEntities("team_connections2", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'team_connector'
        /// </summary>
		[RelationshipSchemaName("team_connector")]
		public IEnumerable<Connector> TeamConnector
		{
			get { return GetRelatedEntities<Connector>("team_connector", null); }
			set { SetRelatedEntities("team_connector", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'team_contacts'
        /// </summary>
		[RelationshipSchemaName("team_contacts")]
		public IEnumerable<Contact> TeamContacts
		{
			get { return GetRelatedEntities<Contact>("team_contacts", null); }
			set { SetRelatedEntities("team_contacts", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'team_contractdetail'
        /// </summary>
		[RelationshipSchemaName("team_contractdetail")]
		public IEnumerable<ContractLine> TeamContractdetail
		{
			get { return GetRelatedEntities<ContractLine>("team_contractdetail", null); }
			set { SetRelatedEntities("team_contractdetail", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'team_conversationtranscript'
        /// </summary>
		[RelationshipSchemaName("team_conversationtranscript")]
		public IEnumerable<ConversationTranscript> TeamConversationtranscript
		{
			get { return GetRelatedEntities<ConversationTranscript>("team_conversationtranscript", null); }
			set { SetRelatedEntities("team_conversationtranscript", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'team_customapi'
        /// </summary>
		[RelationshipSchemaName("team_customapi")]
		public IEnumerable<CustomAPI> TeamCustomapi
		{
			get { return GetRelatedEntities<CustomAPI>("team_customapi", null); }
			set { SetRelatedEntities("team_customapi", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'team_customapirequestparameter'
        /// </summary>
		[RelationshipSchemaName("team_customapirequestparameter")]
		public IEnumerable<CustomAPIRequestParameter> TeamCustomapirequestparameter
		{
			get { return GetRelatedEntities<CustomAPIRequestParameter>("team_customapirequestparameter", null); }
			set { SetRelatedEntities("team_customapirequestparameter", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'team_customapiresponseproperty'
        /// </summary>
		[RelationshipSchemaName("team_customapiresponseproperty")]
		public IEnumerable<CustomAPIResponseProperty> TeamCustomapiresponseproperty
		{
			get { return GetRelatedEntities<CustomAPIResponseProperty>("team_customapiresponseproperty", null); }
			set { SetRelatedEntities("team_customapiresponseproperty", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'team_datalakefolder'
        /// </summary>
		[RelationshipSchemaName("team_datalakefolder")]
		public IEnumerable<DataLakeFolder> TeamDatalakefolder
		{
			get { return GetRelatedEntities<DataLakeFolder>("team_datalakefolder", null); }
			set { SetRelatedEntities("team_datalakefolder", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'team_datalakefolderpermission'
        /// </summary>
		[RelationshipSchemaName("team_datalakefolderpermission")]
		public IEnumerable<DataLakeFolderPermission> TeamDatalakefolderpermission
		{
			get { return GetRelatedEntities<DataLakeFolderPermission>("team_datalakefolderpermission", null); }
			set { SetRelatedEntities("team_datalakefolderpermission", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'Team_DuplicateBaseRecord'
        /// </summary>
		[RelationshipSchemaName("Team_DuplicateBaseRecord")]
		public IEnumerable<DuplicateRecord> TeamDuplicateBaseRecord
		{
			get { return GetRelatedEntities<DuplicateRecord>("Team_DuplicateBaseRecord", null); }
			set { SetRelatedEntities("Team_DuplicateBaseRecord", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'Team_DuplicateMatchingRecord'
        /// </summary>
		[RelationshipSchemaName("Team_DuplicateMatchingRecord")]
		public IEnumerable<DuplicateRecord> TeamDuplicateMatchingRecord
		{
			get { return GetRelatedEntities<DuplicateRecord>("Team_DuplicateMatchingRecord", null); }
			set { SetRelatedEntities("Team_DuplicateMatchingRecord", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'team_DuplicateRules'
        /// </summary>
		[RelationshipSchemaName("team_DuplicateRules")]
		public IEnumerable<DuplicateDetectionRule> TeamDuplicateRules
		{
			get { return GetRelatedEntities<DuplicateDetectionRule>("team_DuplicateRules", null); }
			set { SetRelatedEntities("team_DuplicateRules", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'team_DynamicPropertyInstance'
        /// </summary>
		[RelationshipSchemaName("team_DynamicPropertyInstance")]
		public IEnumerable<PropertyInstance> TeamDynamicPropertyInstance
		{
			get { return GetRelatedEntities<PropertyInstance>("team_DynamicPropertyInstance", null); }
			set { SetRelatedEntities("team_DynamicPropertyInstance", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'team_email'
        /// </summary>
		[RelationshipSchemaName("team_email")]
		public IEnumerable<Email> TeamEmail
		{
			get { return GetRelatedEntities<Email>("team_email", null); }
			set { SetRelatedEntities("team_email", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'team_email_templates'
        /// </summary>
		[RelationshipSchemaName("team_email_templates")]
		public IEnumerable<EmailTemplate> TeamEmailTemplates
		{
			get { return GetRelatedEntities<EmailTemplate>("team_email_templates", null); }
			set { SetRelatedEntities("team_email_templates", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'team_emailserverprofile'
        /// </summary>
		[RelationshipSchemaName("team_emailserverprofile")]
		public IEnumerable<EmailServerProfile> TeamEmailserverprofile
		{
			get { return GetRelatedEntities<EmailServerProfile>("team_emailserverprofile", null); }
			set { SetRelatedEntities("team_emailserverprofile", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'team_entitlement'
        /// </summary>
		[RelationshipSchemaName("team_entitlement")]
		public IEnumerable<Entitlement> TeamEntitlement
		{
			get { return GetRelatedEntities<Entitlement>("team_entitlement", null); }
			set { SetRelatedEntities("team_entitlement", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'team_entitlementchannel'
        /// </summary>
		[RelationshipSchemaName("team_entitlementchannel")]
		public IEnumerable<EntitlementChannel> TeamEntitlementchannel
		{
			get { return GetRelatedEntities<EntitlementChannel>("team_entitlementchannel", null); }
			set { SetRelatedEntities("team_entitlementchannel", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'team_entitlemententityallocationtypemapping'
        /// </summary>
		[RelationshipSchemaName("team_entitlemententityallocationtypemapping")]
		public IEnumerable<EntitlementEntityAllocationTypeMapping> TeamEntitlemententityallocationtypemapping
		{
			get { return GetRelatedEntities<EntitlementEntityAllocationTypeMapping>("team_entitlemententityallocationtypemapping", null); }
			set { SetRelatedEntities("team_entitlemententityallocationtypemapping", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'team_environmentvariabledefinition'
        /// </summary>
		[RelationshipSchemaName("team_environmentvariabledefinition")]
		public IEnumerable<EnvironmentVariableDefinition> TeamEnvironmentvariabledefinition
		{
			get { return GetRelatedEntities<EnvironmentVariableDefinition>("team_environmentvariabledefinition", null); }
			set { SetRelatedEntities("team_environmentvariabledefinition", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'team_environmentvariablevalue'
        /// </summary>
		[RelationshipSchemaName("team_environmentvariablevalue")]
		public IEnumerable<EnvironmentVariableValue> TeamEnvironmentvariablevalue
		{
			get { return GetRelatedEntities<EnvironmentVariableValue>("team_environmentvariablevalue", null); }
			set { SetRelatedEntities("team_environmentvariablevalue", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'team_exchangesyncidmapping'
        /// </summary>
		[RelationshipSchemaName("team_exchangesyncidmapping")]
		public IEnumerable<ExchangeSyncIdMapping> TeamExchangesyncidmapping
		{
			get { return GetRelatedEntities<ExchangeSyncIdMapping>("team_exchangesyncidmapping", null); }
			set { SetRelatedEntities("team_exchangesyncidmapping", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'team_exportsolutionupload'
        /// </summary>
		[RelationshipSchemaName("team_exportsolutionupload")]
		public IEnumerable<ExportSolutionUpload> TeamExportsolutionupload
		{
			get { return GetRelatedEntities<ExportSolutionUpload>("team_exportsolutionupload", null); }
			set { SetRelatedEntities("team_exportsolutionupload", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'team_fax'
        /// </summary>
		[RelationshipSchemaName("team_fax")]
		public IEnumerable<Fax> TeamFax
		{
			get { return GetRelatedEntities<Fax>("team_fax", null); }
			set { SetRelatedEntities("team_fax", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'team_flowsession'
        /// </summary>
		[RelationshipSchemaName("team_flowsession")]
		public IEnumerable<FlowSession> TeamFlowsession
		{
			get { return GetRelatedEntities<FlowSession>("team_flowsession", null); }
			set { SetRelatedEntities("team_flowsession", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'team_goal'
        /// </summary>
		[RelationshipSchemaName("team_goal")]
		public IEnumerable<Goal> TeamGoal
		{
			get { return GetRelatedEntities<Goal>("team_goal", null); }
			set { SetRelatedEntities("team_goal", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'team_goal_goalowner'
        /// </summary>
		[RelationshipSchemaName("team_goal_goalowner")]
		public IEnumerable<Goal> TeamGoalGoalowner
		{
			get { return GetRelatedEntities<Goal>("team_goal_goalowner", null); }
			set { SetRelatedEntities("team_goal_goalowner", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'team_goalrollupquery'
        /// </summary>
		[RelationshipSchemaName("team_goalrollupquery")]
		public IEnumerable<RollupQuery> TeamGoalrollupquery
		{
			get { return GetRelatedEntities<RollupQuery>("team_goalrollupquery", null); }
			set { SetRelatedEntities("team_goalrollupquery", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'team_ImportData'
        /// </summary>
		[RelationshipSchemaName("team_ImportData")]
		public IEnumerable<ImportData> TeamImportData
		{
			get { return GetRelatedEntities<ImportData>("team_ImportData", null); }
			set { SetRelatedEntities("team_ImportData", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'team_ImportFiles'
        /// </summary>
		[RelationshipSchemaName("team_ImportFiles")]
		public IEnumerable<ImportSourceFile> TeamImportFiles
		{
			get { return GetRelatedEntities<ImportSourceFile>("team_ImportFiles", null); }
			set { SetRelatedEntities("team_ImportFiles", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'team_ImportLogs'
        /// </summary>
		[RelationshipSchemaName("team_ImportLogs")]
		public IEnumerable<ImportLog> TeamImportLogs
		{
			get { return GetRelatedEntities<ImportLog>("team_ImportLogs", null); }
			set { SetRelatedEntities("team_ImportLogs", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'team_ImportMaps'
        /// </summary>
		[RelationshipSchemaName("team_ImportMaps")]
		public IEnumerable<DataMap> TeamImportMaps
		{
			get { return GetRelatedEntities<DataMap>("team_ImportMaps", null); }
			set { SetRelatedEntities("team_ImportMaps", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'team_Imports'
        /// </summary>
		[RelationshipSchemaName("team_Imports")]
		public IEnumerable<DataImport> TeamImports
		{
			get { return GetRelatedEntities<DataImport>("team_Imports", null); }
			set { SetRelatedEntities("team_Imports", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'team_incidentresolution'
        /// </summary>
		[RelationshipSchemaName("team_incidentresolution")]
		public IEnumerable<CaseResolution> TeamIncidentresolution
		{
			get { return GetRelatedEntities<CaseResolution>("team_incidentresolution", null); }
			set { SetRelatedEntities("team_incidentresolution", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'team_incidents'
        /// </summary>
		[RelationshipSchemaName("team_incidents")]
		public IEnumerable<Case> TeamIncidents
		{
			get { return GetRelatedEntities<Case>("team_incidents", null); }
			set { SetRelatedEntities("team_incidents", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'team_interactionforemail'
        /// </summary>
		[RelationshipSchemaName("team_interactionforemail")]
		public IEnumerable<InteractionForEmail> TeamInteractionforemail
		{
			get { return GetRelatedEntities<InteractionForEmail>("team_interactionforemail", null); }
			set { SetRelatedEntities("team_interactionforemail", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'team_invoicedetail'
        /// </summary>
		[RelationshipSchemaName("team_invoicedetail")]
		public IEnumerable<InvoiceProduct> TeamInvoicedetail
		{
			get { return GetRelatedEntities<InvoiceProduct>("team_invoicedetail", null); }
			set { SetRelatedEntities("team_invoicedetail", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'team_invoices'
        /// </summary>
		[RelationshipSchemaName("team_invoices")]
		public IEnumerable<Invoice> TeamInvoices
		{
			get { return GetRelatedEntities<Invoice>("team_invoices", null); }
			set { SetRelatedEntities("team_invoices", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'team_knowledgearticle'
        /// </summary>
		[RelationshipSchemaName("team_knowledgearticle")]
		public IEnumerable<KnowledgeArticle> TeamKnowledgearticle
		{
			get { return GetRelatedEntities<KnowledgeArticle>("team_knowledgearticle", null); }
			set { SetRelatedEntities("team_knowledgearticle", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'team_knowledgearticleincident'
        /// </summary>
		[RelationshipSchemaName("team_knowledgearticleincident")]
		public IEnumerable<KnowledgeArticleIncident> TeamKnowledgearticleincident
		{
			get { return GetRelatedEntities<KnowledgeArticleIncident>("team_knowledgearticleincident", null); }
			set { SetRelatedEntities("team_knowledgearticleincident", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'team_letter'
        /// </summary>
		[RelationshipSchemaName("team_letter")]
		public IEnumerable<Letter> TeamLetter
		{
			get { return GetRelatedEntities<Letter>("team_letter", null); }
			set { SetRelatedEntities("team_letter", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'team_list'
        /// </summary>
		[RelationshipSchemaName("team_list")]
		public IEnumerable<MarketingList> TeamList
		{
			get { return GetRelatedEntities<MarketingList>("team_list", null); }
			set { SetRelatedEntities("team_list", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'team_listoperation'
        /// </summary>
		[RelationshipSchemaName("team_listoperation")]
		public IEnumerable<ListOperation> TeamListoperation
		{
			get { return GetRelatedEntities<ListOperation>("team_listoperation", null); }
			set { SetRelatedEntities("team_listoperation", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'team_mailbox'
        /// </summary>
		[RelationshipSchemaName("team_mailbox")]
		public IEnumerable<Mailbox> TeamMailbox
		{
			get { return GetRelatedEntities<Mailbox>("team_mailbox", null); }
			set { SetRelatedEntities("team_mailbox", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'team_mailboxtrackingfolder'
        /// </summary>
		[RelationshipSchemaName("team_mailboxtrackingfolder")]
		public IEnumerable<MailboxAutoTrackingFolder> TeamMailboxtrackingfolder
		{
			get { return GetRelatedEntities<MailboxAutoTrackingFolder>("team_mailboxtrackingfolder", null); }
			set { SetRelatedEntities("team_mailboxtrackingfolder", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'team_msdyn_actioncardregarding'
        /// </summary>
		[RelationshipSchemaName("team_msdyn_actioncardregarding")]
		public IEnumerable<ActionCardRegarding> TeamMsdynActioncardregarding
		{
			get { return GetRelatedEntities<ActionCardRegarding>("team_msdyn_actioncardregarding", null); }
			set { SetRelatedEntities("team_msdyn_actioncardregarding", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'team_msdyn_actioncardrolesetting'
        /// </summary>
		[RelationshipSchemaName("team_msdyn_actioncardrolesetting")]
		public IEnumerable<ActionCardRoleSetting> TeamMsdynActioncardrolesetting
		{
			get { return GetRelatedEntities<ActionCardRoleSetting>("team_msdyn_actioncardrolesetting", null); }
			set { SetRelatedEntities("team_msdyn_actioncardrolesetting", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'team_msdyn_aibdataset'
        /// </summary>
		[RelationshipSchemaName("team_msdyn_aibdataset")]
		public IEnumerable<AIBuilderDataset> TeamMsdynAibdataset
		{
			get { return GetRelatedEntities<AIBuilderDataset>("team_msdyn_aibdataset", null); }
			set { SetRelatedEntities("team_msdyn_aibdataset", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'team_msdyn_aibdatasetfile'
        /// </summary>
		[RelationshipSchemaName("team_msdyn_aibdatasetfile")]
		public IEnumerable<AIBuilderDatasetFile> TeamMsdynAibdatasetfile
		{
			get { return GetRelatedEntities<AIBuilderDatasetFile>("team_msdyn_aibdatasetfile", null); }
			set { SetRelatedEntities("team_msdyn_aibdatasetfile", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'team_msdyn_aibdatasetrecord'
        /// </summary>
		[RelationshipSchemaName("team_msdyn_aibdatasetrecord")]
		public IEnumerable<AIBuilderDatasetRecord> TeamMsdynAibdatasetrecord
		{
			get { return GetRelatedEntities<AIBuilderDatasetRecord>("team_msdyn_aibdatasetrecord", null); }
			set { SetRelatedEntities("team_msdyn_aibdatasetrecord", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'team_msdyn_aibdatasetscontainer'
        /// </summary>
		[RelationshipSchemaName("team_msdyn_aibdatasetscontainer")]
		public IEnumerable<AIBuilderDatasetsContainer> TeamMsdynAibdatasetscontainer
		{
			get { return GetRelatedEntities<AIBuilderDatasetsContainer>("team_msdyn_aibdatasetscontainer", null); }
			set { SetRelatedEntities("team_msdyn_aibdatasetscontainer", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'team_msdyn_aibfile'
        /// </summary>
		[RelationshipSchemaName("team_msdyn_aibfile")]
		public IEnumerable<AIBuilderFile> TeamMsdynAibfile
		{
			get { return GetRelatedEntities<AIBuilderFile>("team_msdyn_aibfile", null); }
			set { SetRelatedEntities("team_msdyn_aibfile", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'team_msdyn_aibfileattacheddata'
        /// </summary>
		[RelationshipSchemaName("team_msdyn_aibfileattacheddata")]
		public IEnumerable<AIBuilderFileAttachedData> TeamMsdynAibfileattacheddata
		{
			get { return GetRelatedEntities<AIBuilderFileAttachedData>("team_msdyn_aibfileattacheddata", null); }
			set { SetRelatedEntities("team_msdyn_aibfileattacheddata", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'team_msdyn_aiconfiguration'
        /// </summary>
		[RelationshipSchemaName("team_msdyn_aiconfiguration")]
		public IEnumerable<AIConfiguration> TeamMsdynAiconfiguration
		{
			get { return GetRelatedEntities<AIConfiguration>("team_msdyn_aiconfiguration", null); }
			set { SetRelatedEntities("team_msdyn_aiconfiguration", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'team_msdyn_aifptrainingdocument'
        /// </summary>
		[RelationshipSchemaName("team_msdyn_aifptrainingdocument")]
		public IEnumerable<AIFormProcessingDocument> TeamMsdynAifptrainingdocument
		{
			get { return GetRelatedEntities<AIFormProcessingDocument>("team_msdyn_aifptrainingdocument", null); }
			set { SetRelatedEntities("team_msdyn_aifptrainingdocument", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'team_msdyn_aimodel'
        /// </summary>
		[RelationshipSchemaName("team_msdyn_aimodel")]
		public IEnumerable<AIModel> TeamMsdynAimodel
		{
			get { return GetRelatedEntities<AIModel>("team_msdyn_aimodel", null); }
			set { SetRelatedEntities("team_msdyn_aimodel", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'team_msdyn_aiodimage'
        /// </summary>
		[RelationshipSchemaName("team_msdyn_aiodimage")]
		public IEnumerable<AIObjectDetectionImage> TeamMsdynAiodimage
		{
			get { return GetRelatedEntities<AIObjectDetectionImage>("team_msdyn_aiodimage", null); }
			set { SetRelatedEntities("team_msdyn_aiodimage", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'team_msdyn_aiodlabel'
        /// </summary>
		[RelationshipSchemaName("team_msdyn_aiodlabel")]
		public IEnumerable<AIObjectDetectionLabel> TeamMsdynAiodlabel
		{
			get { return GetRelatedEntities<AIObjectDetectionLabel>("team_msdyn_aiodlabel", null); }
			set { SetRelatedEntities("team_msdyn_aiodlabel", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'team_msdyn_aiodtrainingboundingbox'
        /// </summary>
		[RelationshipSchemaName("team_msdyn_aiodtrainingboundingbox")]
		public IEnumerable<AIObjectDetectionBoundingBox> TeamMsdynAiodtrainingboundingbox
		{
			get { return GetRelatedEntities<AIObjectDetectionBoundingBox>("team_msdyn_aiodtrainingboundingbox", null); }
			set { SetRelatedEntities("team_msdyn_aiodtrainingboundingbox", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'team_msdyn_aiodtrainingimage'
        /// </summary>
		[RelationshipSchemaName("team_msdyn_aiodtrainingimage")]
		public IEnumerable<AIObjectDetectionImageMapping> TeamMsdynAiodtrainingimage
		{
			get { return GetRelatedEntities<AIObjectDetectionImageMapping>("team_msdyn_aiodtrainingimage", null); }
			set { SetRelatedEntities("team_msdyn_aiodtrainingimage", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'team_msdyn_aitemplate'
        /// </summary>
		[RelationshipSchemaName("team_msdyn_aitemplate")]
		public IEnumerable<AITemplate> TeamMsdynAitemplate
		{
			get { return GetRelatedEntities<AITemplate>("team_msdyn_aitemplate", null); }
			set { SetRelatedEntities("team_msdyn_aitemplate", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'team_msdyn_autocapturerule'
        /// </summary>
		[RelationshipSchemaName("team_msdyn_autocapturerule")]
		public IEnumerable<AutoCaptureRule> TeamMsdynAutocapturerule
		{
			get { return GetRelatedEntities<AutoCaptureRule>("team_msdyn_autocapturerule", null); }
			set { SetRelatedEntities("team_msdyn_autocapturerule", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'team_msdyn_autocapturesettings'
        /// </summary>
		[RelationshipSchemaName("team_msdyn_autocapturesettings")]
		public IEnumerable<AutoCaptureSettings> TeamMsdynAutocapturesettings
		{
			get { return GetRelatedEntities<AutoCaptureSettings>("team_msdyn_autocapturesettings", null); }
			set { SetRelatedEntities("team_msdyn_autocapturesettings", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'team_msdyn_callablecontext'
        /// </summary>
		[RelationshipSchemaName("team_msdyn_callablecontext")]
		public IEnumerable<PlaybookCallableContext> TeamMsdynCallablecontext
		{
			get { return GetRelatedEntities<PlaybookCallableContext>("team_msdyn_callablecontext", null); }
			set { SetRelatedEntities("team_msdyn_callablecontext", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'team_msdyn_entityrankingrule'
        /// </summary>
		[RelationshipSchemaName("team_msdyn_entityrankingrule")]
		public IEnumerable<EntityRankingRule> TeamMsdynEntityrankingrule
		{
			get { return GetRelatedEntities<EntityRankingRule>("team_msdyn_entityrankingrule", null); }
			set { SetRelatedEntities("team_msdyn_entityrankingrule", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'team_msdyn_federatedarticle'
        /// </summary>
		[RelationshipSchemaName("team_msdyn_federatedarticle")]
		public IEnumerable<KnowledgeFederatedArticle> TeamMsdynFederatedarticle
		{
			get { return GetRelatedEntities<KnowledgeFederatedArticle>("team_msdyn_federatedarticle", null); }
			set { SetRelatedEntities("team_msdyn_federatedarticle", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'team_msdyn_flowcardtype'
        /// </summary>
		[RelationshipSchemaName("team_msdyn_flowcardtype")]
		public IEnumerable<Flowcardtype> TeamMsdynFlowcardtype
		{
			get { return GetRelatedEntities<Flowcardtype>("team_msdyn_flowcardtype", null); }
			set { SetRelatedEntities("team_msdyn_flowcardtype", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'team_msdyn_icebreakersconfig'
        /// </summary>
		[RelationshipSchemaName("team_msdyn_icebreakersconfig")]
		public IEnumerable<Icebreakersconfig> TeamMsdynIcebreakersconfig
		{
			get { return GetRelatedEntities<Icebreakersconfig>("team_msdyn_icebreakersconfig", null); }
			set { SetRelatedEntities("team_msdyn_icebreakersconfig", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'team_msdyn_kmfederatedsearchconfig'
        /// </summary>
		[RelationshipSchemaName("team_msdyn_kmfederatedsearchconfig")]
		public IEnumerable<SearchProvider> TeamMsdynKmfederatedsearchconfig
		{
			get { return GetRelatedEntities<SearchProvider>("team_msdyn_kmfederatedsearchconfig", null); }
			set { SetRelatedEntities("team_msdyn_kmfederatedsearchconfig", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'team_msdyn_knowledgearticleimage'
        /// </summary>
		[RelationshipSchemaName("team_msdyn_knowledgearticleimage")]
		public IEnumerable<KnowledgeArticleImage> TeamMsdynKnowledgearticleimage
		{
			get { return GetRelatedEntities<KnowledgeArticleImage>("team_msdyn_knowledgearticleimage", null); }
			set { SetRelatedEntities("team_msdyn_knowledgearticleimage", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'team_msdyn_knowledgearticletemplate'
        /// </summary>
		[RelationshipSchemaName("team_msdyn_knowledgearticletemplate")]
		public IEnumerable<KnowledgeArticleTemplate> TeamMsdynKnowledgearticletemplate
		{
			get { return GetRelatedEntities<KnowledgeArticleTemplate>("team_msdyn_knowledgearticletemplate", null); }
			set { SetRelatedEntities("team_msdyn_knowledgearticletemplate", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'team_msdyn_knowledgeinteractioninsight'
        /// </summary>
		[RelationshipSchemaName("team_msdyn_knowledgeinteractioninsight")]
		public IEnumerable<KnowledgeInteractionInsight> TeamMsdynKnowledgeinteractioninsight
		{
			get { return GetRelatedEntities<KnowledgeInteractionInsight>("team_msdyn_knowledgeinteractioninsight", null); }
			set { SetRelatedEntities("team_msdyn_knowledgeinteractioninsight", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'team_msdyn_knowledgesearchinsight'
        /// </summary>
		[RelationshipSchemaName("team_msdyn_knowledgesearchinsight")]
		public IEnumerable<KnowledgeSearchInsight> TeamMsdynKnowledgesearchinsight
		{
			get { return GetRelatedEntities<KnowledgeSearchInsight>("team_msdyn_knowledgesearchinsight", null); }
			set { SetRelatedEntities("team_msdyn_knowledgesearchinsight", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'team_msdyn_msteamssetting'
        /// </summary>
		[RelationshipSchemaName("team_msdyn_msteamssetting")]
		public IEnumerable<MsdynMsteamssetting> TeamMsdynMsteamssetting
		{
			get { return GetRelatedEntities<MsdynMsteamssetting>("team_msdyn_msteamssetting", null); }
			set { SetRelatedEntities("team_msdyn_msteamssetting", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'team_msdyn_notesanalysisconfig'
        /// </summary>
		[RelationshipSchemaName("team_msdyn_notesanalysisconfig")]
		public IEnumerable<NotesAnalysisConfig> TeamMsdynNotesanalysisconfig
		{
			get { return GetRelatedEntities<NotesAnalysisConfig>("team_msdyn_notesanalysisconfig", null); }
			set { SetRelatedEntities("team_msdyn_notesanalysisconfig", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'team_msdyn_playbookactivity'
        /// </summary>
		[RelationshipSchemaName("team_msdyn_playbookactivity")]
		public IEnumerable<PlaybookActivity> TeamMsdynPlaybookactivity
		{
			get { return GetRelatedEntities<PlaybookActivity>("team_msdyn_playbookactivity", null); }
			set { SetRelatedEntities("team_msdyn_playbookactivity", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'team_msdyn_playbookactivityattribute'
        /// </summary>
		[RelationshipSchemaName("team_msdyn_playbookactivityattribute")]
		public IEnumerable<PlaybookActivityAttribute> TeamMsdynPlaybookactivityattribute
		{
			get { return GetRelatedEntities<PlaybookActivityAttribute>("team_msdyn_playbookactivityattribute", null); }
			set { SetRelatedEntities("team_msdyn_playbookactivityattribute", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'team_msdyn_playbookcategory'
        /// </summary>
		[RelationshipSchemaName("team_msdyn_playbookcategory")]
		public IEnumerable<PlaybookCategory> TeamMsdynPlaybookcategory
		{
			get { return GetRelatedEntities<PlaybookCategory>("team_msdyn_playbookcategory", null); }
			set { SetRelatedEntities("team_msdyn_playbookcategory", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'team_msdyn_playbookinstance'
        /// </summary>
		[RelationshipSchemaName("team_msdyn_playbookinstance")]
		public IEnumerable<Playbook> TeamMsdynPlaybookinstance
		{
			get { return GetRelatedEntities<Playbook>("team_msdyn_playbookinstance", null); }
			set { SetRelatedEntities("team_msdyn_playbookinstance", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'team_msdyn_playbooktemplate'
        /// </summary>
		[RelationshipSchemaName("team_msdyn_playbooktemplate")]
		public IEnumerable<PlaybookTemplate> TeamMsdynPlaybooktemplate
		{
			get { return GetRelatedEntities<PlaybookTemplate>("team_msdyn_playbooktemplate", null); }
			set { SetRelatedEntities("team_msdyn_playbooktemplate", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'team_msdyn_postalbum'
        /// </summary>
		[RelationshipSchemaName("team_msdyn_postalbum")]
		public IEnumerable<ProfileAlbum> TeamMsdynPostalbum
		{
			get { return GetRelatedEntities<ProfileAlbum>("team_msdyn_postalbum", null); }
			set { SetRelatedEntities("team_msdyn_postalbum", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'team_msdyn_relationshipinsightsunifiedconfig'
        /// </summary>
		[RelationshipSchemaName("team_msdyn_relationshipinsightsunifiedconfig")]
		public IEnumerable<MsdynRelationshipinsightsunifiedconfig> TeamMsdynRelationshipinsightsunifiedconfig
		{
			get { return GetRelatedEntities<MsdynRelationshipinsightsunifiedconfig>("team_msdyn_relationshipinsightsunifiedconfig", null); }
			set { SetRelatedEntities("team_msdyn_relationshipinsightsunifiedconfig", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'team_msdyn_richtextfile'
        /// </summary>
		[RelationshipSchemaName("team_msdyn_richtextfile")]
		public IEnumerable<RichTextAttachment> TeamMsdynRichtextfile
		{
			get { return GetRelatedEntities<RichTextAttachment>("team_msdyn_richtextfile", null); }
			set { SetRelatedEntities("team_msdyn_richtextfile", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'team_msdyn_salesinsightssettings'
        /// </summary>
		[RelationshipSchemaName("team_msdyn_salesinsightssettings")]
		public IEnumerable<Salesinsightssettings> TeamMsdynSalesinsightssettings
		{
			get { return GetRelatedEntities<Salesinsightssettings>("team_msdyn_salesinsightssettings", null); }
			set { SetRelatedEntities("team_msdyn_salesinsightssettings", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'team_msdyn_siconfig'
        /// </summary>
		[RelationshipSchemaName("team_msdyn_siconfig")]
		public IEnumerable<Siconfig> TeamMsdynSiconfig
		{
			get { return GetRelatedEntities<Siconfig>("team_msdyn_siconfig", null); }
			set { SetRelatedEntities("team_msdyn_siconfig", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'team_msdyn_untrackedappointment'
        /// </summary>
		[RelationshipSchemaName("team_msdyn_untrackedappointment")]
		public IEnumerable<UntrackedAppointment> TeamMsdynUntrackedappointment
		{
			get { return GetRelatedEntities<UntrackedAppointment>("team_msdyn_untrackedappointment", null); }
			set { SetRelatedEntities("team_msdyn_untrackedappointment", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'team_msdyn_wallsavedqueryusersettings'
        /// </summary>
		[RelationshipSchemaName("team_msdyn_wallsavedqueryusersettings")]
		public IEnumerable<Filter> TeamMsdynWallsavedqueryusersettings
		{
			get { return GetRelatedEntities<Filter>("team_msdyn_wallsavedqueryusersettings", null); }
			set { SetRelatedEntities("team_msdyn_wallsavedqueryusersettings", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'team_msdynce_botcontent'
        /// </summary>
		[RelationshipSchemaName("team_msdynce_botcontent")]
		public IEnumerable<BotContent> TeamMsdynceBotcontent
		{
			get { return GetRelatedEntities<BotContent>("team_msdynce_botcontent", null); }
			set { SetRelatedEntities("team_msdynce_botcontent", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'team_opportunities'
        /// </summary>
		[RelationshipSchemaName("team_opportunities")]
		public IEnumerable<Opportunity> TeamOpportunities
		{
			get { return GetRelatedEntities<Opportunity>("team_opportunities", null); }
			set { SetRelatedEntities("team_opportunities", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'team_opportunityclose'
        /// </summary>
		[RelationshipSchemaName("team_opportunityclose")]
		public IEnumerable<OpportunityClose> TeamOpportunityclose
		{
			get { return GetRelatedEntities<OpportunityClose>("team_opportunityclose", null); }
			set { SetRelatedEntities("team_opportunityclose", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'team_opportunityproduct'
        /// </summary>
		[RelationshipSchemaName("team_opportunityproduct")]
		public IEnumerable<OpportunityProduct> TeamOpportunityproduct
		{
			get { return GetRelatedEntities<OpportunityProduct>("team_opportunityproduct", null); }
			set { SetRelatedEntities("team_opportunityproduct", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'team_orderclose'
        /// </summary>
		[RelationshipSchemaName("team_orderclose")]
		public IEnumerable<OrderClose> TeamOrderclose
		{
			get { return GetRelatedEntities<OrderClose>("team_orderclose", null); }
			set { SetRelatedEntities("team_orderclose", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'team_orders'
        /// </summary>
		[RelationshipSchemaName("team_orders")]
		public IEnumerable<Order> TeamOrders
		{
			get { return GetRelatedEntities<Order>("team_orders", null); }
			set { SetRelatedEntities("team_orders", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'team_phonecall'
        /// </summary>
		[RelationshipSchemaName("team_phonecall")]
		public IEnumerable<PhoneCall> TeamPhonecall
		{
			get { return GetRelatedEntities<PhoneCall>("team_phonecall", null); }
			set { SetRelatedEntities("team_phonecall", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'team_principalobjectattributeaccess'
        /// </summary>
		[RelationshipSchemaName("team_principalobjectattributeaccess")]
		public IEnumerable<FieldSharing> TeamPrincipalobjectattributeaccess
		{
			get { return GetRelatedEntities<FieldSharing>("team_principalobjectattributeaccess", null); }
			set { SetRelatedEntities("team_principalobjectattributeaccess", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'team_principalobjectattributeaccess_principalid'
        /// </summary>
		[RelationshipSchemaName("team_principalobjectattributeaccess_principalid")]
		public IEnumerable<FieldSharing> TeamPrincipalobjectattributeaccessPrincipalid
		{
			get { return GetRelatedEntities<FieldSharing>("team_principalobjectattributeaccess_principalid", null); }
			set { SetRelatedEntities("team_principalobjectattributeaccess_principalid", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'team_processsession'
        /// </summary>
		[RelationshipSchemaName("team_processsession")]
		public IEnumerable<ProcessSession> TeamProcesssession
		{
			get { return GetRelatedEntities<ProcessSession>("team_processsession", null); }
			set { SetRelatedEntities("team_processsession", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'Team_ProcessSessions'
        /// </summary>
		[RelationshipSchemaName("Team_ProcessSessions")]
		public IEnumerable<ProcessSession> TeamProcessSessions
		{
			get { return GetRelatedEntities<ProcessSession>("Team_ProcessSessions", null); }
			set { SetRelatedEntities("Team_ProcessSessions", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'team_processstageparameter'
        /// </summary>
		[RelationshipSchemaName("team_processstageparameter")]
		public IEnumerable<ProcessStageParameter> TeamProcessstageparameter
		{
			get { return GetRelatedEntities<ProcessStageParameter>("team_processstageparameter", null); }
			set { SetRelatedEntities("team_processstageparameter", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'team_pw_penta_schedule_run'
        /// </summary>
		[RelationshipSchemaName("team_pw_penta_schedule_run")]
		public IEnumerable<PentaScheduleRun> TeamPwPentaScheduleRun
		{
			get { return GetRelatedEntities<PentaScheduleRun>("team_pw_penta_schedule_run", null); }
			set { SetRelatedEntities("team_pw_penta_schedule_run", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'team_pw_schedule'
        /// </summary>
		[RelationshipSchemaName("team_pw_schedule")]
		public IEnumerable<PentaSchedule> TeamPwSchedule
		{
			get { return GetRelatedEntities<PentaSchedule>("team_pw_schedule", null); }
			set { SetRelatedEntities("team_pw_schedule", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'team_queueitembase_workerid'
        /// </summary>
		[RelationshipSchemaName("team_queueitembase_workerid")]
		public IEnumerable<QueueItem> TeamQueueitembaseWorkerid
		{
			get { return GetRelatedEntities<QueueItem>("team_queueitembase_workerid", null); }
			set { SetRelatedEntities("team_queueitembase_workerid", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'team_quoteclose'
        /// </summary>
		[RelationshipSchemaName("team_quoteclose")]
		public IEnumerable<QuoteClose> TeamQuoteclose
		{
			get { return GetRelatedEntities<QuoteClose>("team_quoteclose", null); }
			set { SetRelatedEntities("team_quoteclose", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'team_quotedetail'
        /// </summary>
		[RelationshipSchemaName("team_quotedetail")]
		public IEnumerable<QuoteProduct> TeamQuotedetail
		{
			get { return GetRelatedEntities<QuoteProduct>("team_quotedetail", null); }
			set { SetRelatedEntities("team_quotedetail", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'team_quotes'
        /// </summary>
		[RelationshipSchemaName("team_quotes")]
		public IEnumerable<Quote> TeamQuotes
		{
			get { return GetRelatedEntities<Quote>("team_quotes", null); }
			set { SetRelatedEntities("team_quotes", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'team_ratingmodel'
        /// </summary>
		[RelationshipSchemaName("team_ratingmodel")]
		public IEnumerable<RatingModel> TeamRatingmodel
		{
			get { return GetRelatedEntities<RatingModel>("team_ratingmodel", null); }
			set { SetRelatedEntities("team_ratingmodel", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'team_ratingvalue'
        /// </summary>
		[RelationshipSchemaName("team_ratingvalue")]
		public IEnumerable<RatingValue> TeamRatingvalue
		{
			get { return GetRelatedEntities<RatingValue>("team_ratingvalue", null); }
			set { SetRelatedEntities("team_ratingvalue", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'team_recurringappointmentmaster'
        /// </summary>
		[RelationshipSchemaName("team_recurringappointmentmaster")]
		public IEnumerable<RecurringAppointment> TeamRecurringappointmentmaster
		{
			get { return GetRelatedEntities<RecurringAppointment>("team_recurringappointmentmaster", null); }
			set { SetRelatedEntities("team_recurringappointmentmaster", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'team_resource_groups'
        /// </summary>
		[RelationshipSchemaName("team_resource_groups")]
		public IEnumerable<SchedulingGroup> TeamResourceGroups
		{
			get { return GetRelatedEntities<SchedulingGroup>("team_resource_groups", null); }
			set { SetRelatedEntities("team_resource_groups", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'team_resource_specs'
        /// </summary>
		[RelationshipSchemaName("team_resource_specs")]
		public IEnumerable<ResourceSpecification> TeamResourceSpecs
		{
			get { return GetRelatedEntities<ResourceSpecification>("team_resource_specs", null); }
			set { SetRelatedEntities("team_resource_specs", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'team_salesorderdetail'
        /// </summary>
		[RelationshipSchemaName("team_salesorderdetail")]
		public IEnumerable<OrderProduct> TeamSalesorderdetail
		{
			get { return GetRelatedEntities<OrderProduct>("team_salesorderdetail", null); }
			set { SetRelatedEntities("team_salesorderdetail", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'team_service_appointments'
        /// </summary>
		[RelationshipSchemaName("team_service_appointments")]
		public IEnumerable<ServiceActivity> TeamServiceAppointments
		{
			get { return GetRelatedEntities<ServiceActivity>("team_service_appointments", null); }
			set { SetRelatedEntities("team_service_appointments", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'team_service_contracts'
        /// </summary>
		[RelationshipSchemaName("team_service_contracts")]
		public IEnumerable<Contract> TeamServiceContracts
		{
			get { return GetRelatedEntities<Contract>("team_service_contracts", null); }
			set { SetRelatedEntities("team_service_contracts", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'team_sharepointdocumentlocation'
        /// </summary>
		[RelationshipSchemaName("team_sharepointdocumentlocation")]
		public IEnumerable<DocumentLocation> TeamSharepointdocumentlocation
		{
			get { return GetRelatedEntities<DocumentLocation>("team_sharepointdocumentlocation", null); }
			set { SetRelatedEntities("team_sharepointdocumentlocation", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'team_sharepointsite'
        /// </summary>
		[RelationshipSchemaName("team_sharepointsite")]
		public IEnumerable<SharePointSite> TeamSharepointsite
		{
			get { return GetRelatedEntities<SharePointSite>("team_sharepointsite", null); }
			set { SetRelatedEntities("team_sharepointsite", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'team_slaBase'
        /// </summary>
		[RelationshipSchemaName("team_slaBase")]
		public IEnumerable<SLA> TeamSlaBase
		{
			get { return GetRelatedEntities<SLA>("team_slaBase", null); }
			set { SetRelatedEntities("team_slaBase", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'team_socialactivity'
        /// </summary>
		[RelationshipSchemaName("team_socialactivity")]
		public IEnumerable<SocialActivity> TeamSocialactivity
		{
			get { return GetRelatedEntities<SocialActivity>("team_socialactivity", null); }
			set { SetRelatedEntities("team_socialactivity", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'team_stagesolutionupload'
        /// </summary>
		[RelationshipSchemaName("team_stagesolutionupload")]
		public IEnumerable<StageSolutionUpload> TeamStagesolutionupload
		{
			get { return GetRelatedEntities<StageSolutionUpload>("team_stagesolutionupload", null); }
			set { SetRelatedEntities("team_stagesolutionupload", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'team_SyncError'
        /// </summary>
		[RelationshipSchemaName("team_SyncError")]
		public IEnumerable<SyncError> TeamSyncError
		{
			get { return GetRelatedEntities<SyncError>("team_SyncError", null); }
			set { SetRelatedEntities("team_SyncError", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'Team_SyncErrors'
        /// </summary>
		[RelationshipSchemaName("Team_SyncErrors")]
		public IEnumerable<SyncError> TeamSyncErrors
		{
			get { return GetRelatedEntities<SyncError>("Team_SyncErrors", null); }
			set { SetRelatedEntities("Team_SyncErrors", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'team_task'
        /// </summary>
		[RelationshipSchemaName("team_task")]
		public IEnumerable<Task> TeamTask
		{
			get { return GetRelatedEntities<Task>("team_task", null); }
			set { SetRelatedEntities("team_task", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'team_userform'
        /// </summary>
		[RelationshipSchemaName("team_userform")]
		public IEnumerable<UserDashboard> TeamUserform
		{
			get { return GetRelatedEntities<UserDashboard>("team_userform", null); }
			set { SetRelatedEntities("team_userform", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'team_userquery'
        /// </summary>
		[RelationshipSchemaName("team_userquery")]
		public IEnumerable<SavedView> TeamUserquery
		{
			get { return GetRelatedEntities<SavedView>("team_userquery", null); }
			set { SetRelatedEntities("team_userquery", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'team_userqueryvisualizations'
        /// </summary>
		[RelationshipSchemaName("team_userqueryvisualizations")]
		public IEnumerable<UserChart> TeamUserqueryvisualizations
		{
			get { return GetRelatedEntities<UserChart>("team_userqueryvisualizations", null); }
			set { SetRelatedEntities("team_userqueryvisualizations", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'team_workflow'
        /// </summary>
		[RelationshipSchemaName("team_workflow")]
		public IEnumerable<Process> TeamWorkflow
		{
			get { return GetRelatedEntities<Process>("team_workflow", null); }
			set { SetRelatedEntities("team_workflow", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'team_workflowbinary'
        /// </summary>
		[RelationshipSchemaName("team_workflowbinary")]
		public IEnumerable<WorkflowBinary> TeamWorkflowbinary
		{
			get { return GetRelatedEntities<WorkflowBinary>("team_workflowbinary", null); }
			set { SetRelatedEntities("team_workflowbinary", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'team_workflowlog'
        /// </summary>
		[RelationshipSchemaName("team_workflowlog")]
		public IEnumerable<ProcessLog> TeamWorkflowlog
		{
			get { return GetRelatedEntities<ProcessLog>("team_workflowlog", null); }
			set { SetRelatedEntities("team_workflowlog", null, value); }
		}
		/// <summary>
        /// N:N Get entities for 'User'
        /// </summary>
		[RelationshipSchemaName("teammembership_association")]
		public IEnumerable<User> TeammembershipAssociation
		{
			get { return GetRelatedEntities<User>("teammembership_association", null); }
			set { SetRelatedEntities("teammembership_association", null, value); }
		}
		/// <summary>
        /// N:N Get entities for 'FieldSecurityProfile'
        /// </summary>
		[RelationshipSchemaName("teamprofiles_association")]
		public IEnumerable<FieldSecurityProfile> TeamprofilesAssociation
		{
			get { return GetRelatedEntities<FieldSecurityProfile>("teamprofiles_association", null); }
			set { SetRelatedEntities("teamprofiles_association", null, value); }
		}
		/// <summary>
        /// N:N Get entities for 'SecurityRole'
        /// </summary>
		[RelationshipSchemaName("teamroles_association")]
		public IEnumerable<SecurityRole> TeamrolesAssociation
		{
			get { return GetRelatedEntities<SecurityRole>("teamroles_association", null); }
			set { SetRelatedEntities("teamroles_association", null, value); }
		}
		#endregion

		#region Actions
		#endregion

		#region OptionSetEnums
		public enum eMembershipType
		{	
		
			[Label("Members and guests")]
			[Description(@"")]
			MembersAndGuests = 0, 
		
			[Label("Members")]
			[Description(@"")]
			Members = 1, 
		
			[Label("Owners")]
			[Description(@"")]
			Owners = 2, 
		
			[Label("Guests")]
			[Description(@"")]
			Guests = 3, 
		}
		
		public enum eTeamType
		{	
		
			[Label("Owner")]
			[Description(@"")]
			Owner = 0, 
		
			[Label("Access")]
			[Description(@"")]
			Access = 1, 
		
			[Label("AAD Security Group")]
			[Description(@"")]
			AADSecurityGroup = 2, 
		
			[Label("AAD Office Group")]
			[Description(@"")]
			AADOfficeGroup = 3, 
		}
		
		#endregion	

		#region Properties
		public static class Properties 
		{
			/// <summary>administratorid</summary>
			public const string Administrator = "administratorid";

			/// <summary>administratoridname</summary>
			public const string Administratoridname = "administratoridname";

			/// <summary>administratoridyominame</summary>
			public const string Administratoridyominame = "administratoridyominame";

			/// <summary>azureactivedirectoryobjectid</summary>
			public const string AzureADObjectIdForAGroupId = "azureactivedirectoryobjectid";

			/// <summary>businessunitid</summary>
			public const string BusinessUnit = "businessunitid";

			/// <summary>businessunitidname</summary>
			public const string Businessunitidname = "businessunitidname";

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
			public const string Email = "emailaddress";

			/// <summary>exchangerate</summary>
			public const string ExchangeRate = "exchangerate";

			/// <summary>importsequencenumber</summary>
			public const string ImportSequenceNumber = "importsequencenumber";

			/// <summary>isdefault</summary>
			public const string IsDefault = "isdefault";

			/// <summary>membershiptype</summary>
			public const string MembershipType = "membershiptype";

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
			public const string TeamName = "name";

			/// <summary>organizationid</summary>
			public const string OrganizationId = "organizationid";

			/// <summary>organizationidname</summary>
			public const string Organizationidname = "organizationidname";

			/// <summary>overriddencreatedon</summary>
			public const string RecordCreatedOn = "overriddencreatedon";

			/// <summary>processid</summary>
			public const string ProcessId = "processid";

			/// <summary>queueid</summary>
			public const string DefaultQueue = "queueid";

			/// <summary>queueidname</summary>
			public const string Queueidname = "queueidname";

			/// <summary>regardingobjectid</summary>
			public const string RegardingObjectId = "regardingobjectid";

			/// <summary>regardingobjecttypecode</summary>
			public const string RegardingObjectType = "regardingobjecttypecode";

			/// <summary>stageid</summary>
			public const string DeprecatedProcessStageId = "stageid";

			/// <summary>systemmanaged</summary>
			public const string IsSystemManaged = "systemmanaged";

			/// <summary>teamid</summary>
			public const string TeamId = "teamid";

			/// <summary>teamtemplateid</summary>
			public const string TeamTemplateIdentifier = "teamtemplateid";

			/// <summary>teamtype</summary>
			public const string TeamType = "teamtype";

			/// <summary>transactioncurrencyid</summary>
			public const string Currency = "transactioncurrencyid";

			/// <summary>transactioncurrencyidname</summary>
			public const string Transactioncurrencyidname = "transactioncurrencyidname";

			/// <summary>traversedpath</summary>
			public const string DeprecatedTraversedPath = "traversedpath";

			/// <summary>versionnumber</summary>
			public const string VersionNumber = "versionnumber";

			/// <summary>yominame</summary>
			public const string YomiName = "yominame";

		}
		#endregion

		#region Schemas
		public static class Schemas 
		{
			/// <summary>1:N ImportFile_Team</summary>
			public const string ImportFileTeam = "ImportFile_Team";

			/// <summary>1:N lead_owning_team</summary>
			public const string LeadOwningTeam = "lead_owning_team";

			/// <summary>1:N OwningTeam_postfollows</summary>
			public const string OwningTeamPostfollows = "OwningTeam_postfollows";

			/// <summary>1:N team_accounts</summary>
			public const string TeamAccounts = "team_accounts";

			/// <summary>1:N team_activity</summary>
			public const string TeamActivity = "team_activity";

			/// <summary>1:N team_activitymonitor</summary>
			public const string TeamActivitymonitor = "team_activitymonitor";

			/// <summary>1:N team_adminsettingsentity</summary>
			public const string TeamAdminsettingsentity = "team_adminsettingsentity";

			/// <summary>1:N team_annotations</summary>
			public const string TeamAnnotations = "team_annotations";

			/// <summary>1:N team_appointment</summary>
			public const string TeamAppointment = "team_appointment";

			/// <summary>1:N team_asyncoperation</summary>
			public const string TeamAsyncoperation = "team_asyncoperation";

			/// <summary>1:N Team_AsyncOperations</summary>
			public const string TeamAsyncOperations = "Team_AsyncOperations";

			/// <summary>1:N team_bookableresource</summary>
			public const string TeamBookableresource = "team_bookableresource";

			/// <summary>1:N team_bookableresourcebooking</summary>
			public const string TeamBookableresourcebooking = "team_bookableresourcebooking";

			/// <summary>1:N team_bookableresourcebookingheader</summary>
			public const string TeamBookableresourcebookingheader = "team_bookableresourcebookingheader";

			/// <summary>1:N team_bookableresourcecategory</summary>
			public const string TeamBookableresourcecategory = "team_bookableresourcecategory";

			/// <summary>1:N team_bookableresourcecategoryassn</summary>
			public const string TeamBookableresourcecategoryassn = "team_bookableresourcecategoryassn";

			/// <summary>1:N team_bookableresourcecharacteristic</summary>
			public const string TeamBookableresourcecharacteristic = "team_bookableresourcecharacteristic";

			/// <summary>1:N team_bookableresourcegroup</summary>
			public const string TeamBookableresourcegroup = "team_bookableresourcegroup";

			/// <summary>1:N team_bookingstatus</summary>
			public const string TeamBookingstatus = "team_bookingstatus";

			/// <summary>1:N team_bot</summary>
			public const string TeamBot = "team_bot";

			/// <summary>1:N team_botcomponent</summary>
			public const string TeamBotcomponent = "team_botcomponent";

			/// <summary>1:N Team_BulkDeleteFailures</summary>
			public const string TeamBulkDeleteFailures = "Team_BulkDeleteFailures";

			/// <summary>1:N team_BulkOperation</summary>
			public const string TeamBulkOperation = "team_BulkOperation";

			/// <summary>1:N team_campaignactivity</summary>
			public const string TeamCampaignactivity = "team_campaignactivity";

			/// <summary>1:N team_campaignresponse</summary>
			public const string TeamCampaignresponse = "team_campaignresponse";

			/// <summary>1:N team_Campaigns</summary>
			public const string TeamCampaigns = "team_Campaigns";

			/// <summary>1:N team_characteristic</summary>
			public const string TeamCharacteristic = "team_characteristic";

			/// <summary>1:N team_connectionreference</summary>
			public const string TeamConnectionreference = "team_connectionreference";

			/// <summary>1:N team_connections1</summary>
			public const string TeamConnections1 = "team_connections1";

			/// <summary>1:N team_connections2</summary>
			public const string TeamConnections2 = "team_connections2";

			/// <summary>1:N team_connector</summary>
			public const string TeamConnector = "team_connector";

			/// <summary>1:N team_contacts</summary>
			public const string TeamContacts = "team_contacts";

			/// <summary>1:N team_contractdetail</summary>
			public const string TeamContractdetail = "team_contractdetail";

			/// <summary>1:N team_conversationtranscript</summary>
			public const string TeamConversationtranscript = "team_conversationtranscript";

			/// <summary>1:N team_customapi</summary>
			public const string TeamCustomapi = "team_customapi";

			/// <summary>1:N team_customapirequestparameter</summary>
			public const string TeamCustomapirequestparameter = "team_customapirequestparameter";

			/// <summary>1:N team_customapiresponseproperty</summary>
			public const string TeamCustomapiresponseproperty = "team_customapiresponseproperty";

			/// <summary>1:N team_datalakefolder</summary>
			public const string TeamDatalakefolder = "team_datalakefolder";

			/// <summary>1:N team_datalakefolderpermission</summary>
			public const string TeamDatalakefolderpermission = "team_datalakefolderpermission";

			/// <summary>1:N Team_DuplicateBaseRecord</summary>
			public const string TeamDuplicateBaseRecord = "Team_DuplicateBaseRecord";

			/// <summary>1:N Team_DuplicateMatchingRecord</summary>
			public const string TeamDuplicateMatchingRecord = "Team_DuplicateMatchingRecord";

			/// <summary>1:N team_DuplicateRules</summary>
			public const string TeamDuplicateRules = "team_DuplicateRules";

			/// <summary>1:N team_DynamicPropertyInstance</summary>
			public const string TeamDynamicPropertyInstance = "team_DynamicPropertyInstance";

			/// <summary>1:N team_email</summary>
			public const string TeamEmail = "team_email";

			/// <summary>1:N team_email_templates</summary>
			public const string TeamEmailTemplates = "team_email_templates";

			/// <summary>1:N team_emailserverprofile</summary>
			public const string TeamEmailserverprofile = "team_emailserverprofile";

			/// <summary>1:N team_entitlement</summary>
			public const string TeamEntitlement = "team_entitlement";

			/// <summary>1:N team_entitlementchannel</summary>
			public const string TeamEntitlementchannel = "team_entitlementchannel";

			/// <summary>1:N team_entitlemententityallocationtypemapping</summary>
			public const string TeamEntitlemententityallocationtypemapping = "team_entitlemententityallocationtypemapping";

			/// <summary>1:N team_environmentvariabledefinition</summary>
			public const string TeamEnvironmentvariabledefinition = "team_environmentvariabledefinition";

			/// <summary>1:N team_environmentvariablevalue</summary>
			public const string TeamEnvironmentvariablevalue = "team_environmentvariablevalue";

			/// <summary>1:N team_exchangesyncidmapping</summary>
			public const string TeamExchangesyncidmapping = "team_exchangesyncidmapping";

			/// <summary>1:N team_exportsolutionupload</summary>
			public const string TeamExportsolutionupload = "team_exportsolutionupload";

			/// <summary>1:N team_fax</summary>
			public const string TeamFax = "team_fax";

			/// <summary>1:N team_flowsession</summary>
			public const string TeamFlowsession = "team_flowsession";

			/// <summary>1:N team_goal</summary>
			public const string TeamGoal = "team_goal";

			/// <summary>1:N team_goal_goalowner</summary>
			public const string TeamGoalGoalowner = "team_goal_goalowner";

			/// <summary>1:N team_goalrollupquery</summary>
			public const string TeamGoalrollupquery = "team_goalrollupquery";

			/// <summary>1:N team_ImportData</summary>
			public const string TeamImportData = "team_ImportData";

			/// <summary>1:N team_ImportFiles</summary>
			public const string TeamImportFiles = "team_ImportFiles";

			/// <summary>1:N team_ImportLogs</summary>
			public const string TeamImportLogs = "team_ImportLogs";

			/// <summary>1:N team_ImportMaps</summary>
			public const string TeamImportMaps = "team_ImportMaps";

			/// <summary>1:N team_Imports</summary>
			public const string TeamImports = "team_Imports";

			/// <summary>1:N team_incidentresolution</summary>
			public const string TeamIncidentresolution = "team_incidentresolution";

			/// <summary>1:N team_incidents</summary>
			public const string TeamIncidents = "team_incidents";

			/// <summary>1:N team_interactionforemail</summary>
			public const string TeamInteractionforemail = "team_interactionforemail";

			/// <summary>1:N team_invoicedetail</summary>
			public const string TeamInvoicedetail = "team_invoicedetail";

			/// <summary>1:N team_invoices</summary>
			public const string TeamInvoices = "team_invoices";

			/// <summary>1:N team_knowledgearticle</summary>
			public const string TeamKnowledgearticle = "team_knowledgearticle";

			/// <summary>1:N team_knowledgearticleincident</summary>
			public const string TeamKnowledgearticleincident = "team_knowledgearticleincident";

			/// <summary>1:N team_letter</summary>
			public const string TeamLetter = "team_letter";

			/// <summary>1:N team_list</summary>
			public const string TeamList = "team_list";

			/// <summary>1:N team_listoperation</summary>
			public const string TeamListoperation = "team_listoperation";

			/// <summary>1:N team_mailbox</summary>
			public const string TeamMailbox = "team_mailbox";

			/// <summary>1:N team_mailboxtrackingfolder</summary>
			public const string TeamMailboxtrackingfolder = "team_mailboxtrackingfolder";

			/// <summary>1:N team_msdyn_actioncardregarding</summary>
			public const string TeamMsdynActioncardregarding = "team_msdyn_actioncardregarding";

			/// <summary>1:N team_msdyn_actioncardrolesetting</summary>
			public const string TeamMsdynActioncardrolesetting = "team_msdyn_actioncardrolesetting";

			/// <summary>1:N team_msdyn_aibdataset</summary>
			public const string TeamMsdynAibdataset = "team_msdyn_aibdataset";

			/// <summary>1:N team_msdyn_aibdatasetfile</summary>
			public const string TeamMsdynAibdatasetfile = "team_msdyn_aibdatasetfile";

			/// <summary>1:N team_msdyn_aibdatasetrecord</summary>
			public const string TeamMsdynAibdatasetrecord = "team_msdyn_aibdatasetrecord";

			/// <summary>1:N team_msdyn_aibdatasetscontainer</summary>
			public const string TeamMsdynAibdatasetscontainer = "team_msdyn_aibdatasetscontainer";

			/// <summary>1:N team_msdyn_aibfile</summary>
			public const string TeamMsdynAibfile = "team_msdyn_aibfile";

			/// <summary>1:N team_msdyn_aibfileattacheddata</summary>
			public const string TeamMsdynAibfileattacheddata = "team_msdyn_aibfileattacheddata";

			/// <summary>1:N team_msdyn_aiconfiguration</summary>
			public const string TeamMsdynAiconfiguration = "team_msdyn_aiconfiguration";

			/// <summary>1:N team_msdyn_aifptrainingdocument</summary>
			public const string TeamMsdynAifptrainingdocument = "team_msdyn_aifptrainingdocument";

			/// <summary>1:N team_msdyn_aimodel</summary>
			public const string TeamMsdynAimodel = "team_msdyn_aimodel";

			/// <summary>1:N team_msdyn_aiodimage</summary>
			public const string TeamMsdynAiodimage = "team_msdyn_aiodimage";

			/// <summary>1:N team_msdyn_aiodlabel</summary>
			public const string TeamMsdynAiodlabel = "team_msdyn_aiodlabel";

			/// <summary>1:N team_msdyn_aiodtrainingboundingbox</summary>
			public const string TeamMsdynAiodtrainingboundingbox = "team_msdyn_aiodtrainingboundingbox";

			/// <summary>1:N team_msdyn_aiodtrainingimage</summary>
			public const string TeamMsdynAiodtrainingimage = "team_msdyn_aiodtrainingimage";

			/// <summary>1:N team_msdyn_aitemplate</summary>
			public const string TeamMsdynAitemplate = "team_msdyn_aitemplate";

			/// <summary>1:N team_msdyn_autocapturerule</summary>
			public const string TeamMsdynAutocapturerule = "team_msdyn_autocapturerule";

			/// <summary>1:N team_msdyn_autocapturesettings</summary>
			public const string TeamMsdynAutocapturesettings = "team_msdyn_autocapturesettings";

			/// <summary>1:N team_msdyn_callablecontext</summary>
			public const string TeamMsdynCallablecontext = "team_msdyn_callablecontext";

			/// <summary>1:N team_msdyn_entityrankingrule</summary>
			public const string TeamMsdynEntityrankingrule = "team_msdyn_entityrankingrule";

			/// <summary>1:N team_msdyn_federatedarticle</summary>
			public const string TeamMsdynFederatedarticle = "team_msdyn_federatedarticle";

			/// <summary>1:N team_msdyn_flowcardtype</summary>
			public const string TeamMsdynFlowcardtype = "team_msdyn_flowcardtype";

			/// <summary>1:N team_msdyn_icebreakersconfig</summary>
			public const string TeamMsdynIcebreakersconfig = "team_msdyn_icebreakersconfig";

			/// <summary>1:N team_msdyn_kmfederatedsearchconfig</summary>
			public const string TeamMsdynKmfederatedsearchconfig = "team_msdyn_kmfederatedsearchconfig";

			/// <summary>1:N team_msdyn_knowledgearticleimage</summary>
			public const string TeamMsdynKnowledgearticleimage = "team_msdyn_knowledgearticleimage";

			/// <summary>1:N team_msdyn_knowledgearticletemplate</summary>
			public const string TeamMsdynKnowledgearticletemplate = "team_msdyn_knowledgearticletemplate";

			/// <summary>1:N team_msdyn_knowledgeinteractioninsight</summary>
			public const string TeamMsdynKnowledgeinteractioninsight = "team_msdyn_knowledgeinteractioninsight";

			/// <summary>1:N team_msdyn_knowledgesearchinsight</summary>
			public const string TeamMsdynKnowledgesearchinsight = "team_msdyn_knowledgesearchinsight";

			/// <summary>1:N team_msdyn_msteamssetting</summary>
			public const string TeamMsdynMsteamssetting = "team_msdyn_msteamssetting";

			/// <summary>1:N team_msdyn_notesanalysisconfig</summary>
			public const string TeamMsdynNotesanalysisconfig = "team_msdyn_notesanalysisconfig";

			/// <summary>1:N team_msdyn_playbookactivity</summary>
			public const string TeamMsdynPlaybookactivity = "team_msdyn_playbookactivity";

			/// <summary>1:N team_msdyn_playbookactivityattribute</summary>
			public const string TeamMsdynPlaybookactivityattribute = "team_msdyn_playbookactivityattribute";

			/// <summary>1:N team_msdyn_playbookcategory</summary>
			public const string TeamMsdynPlaybookcategory = "team_msdyn_playbookcategory";

			/// <summary>1:N team_msdyn_playbookinstance</summary>
			public const string TeamMsdynPlaybookinstance = "team_msdyn_playbookinstance";

			/// <summary>1:N team_msdyn_playbooktemplate</summary>
			public const string TeamMsdynPlaybooktemplate = "team_msdyn_playbooktemplate";

			/// <summary>1:N team_msdyn_postalbum</summary>
			public const string TeamMsdynPostalbum = "team_msdyn_postalbum";

			/// <summary>1:N team_msdyn_relationshipinsightsunifiedconfig</summary>
			public const string TeamMsdynRelationshipinsightsunifiedconfig = "team_msdyn_relationshipinsightsunifiedconfig";

			/// <summary>1:N team_msdyn_richtextfile</summary>
			public const string TeamMsdynRichtextfile = "team_msdyn_richtextfile";

			/// <summary>1:N team_msdyn_salesinsightssettings</summary>
			public const string TeamMsdynSalesinsightssettings = "team_msdyn_salesinsightssettings";

			/// <summary>1:N team_msdyn_siconfig</summary>
			public const string TeamMsdynSiconfig = "team_msdyn_siconfig";

			/// <summary>1:N team_msdyn_untrackedappointment</summary>
			public const string TeamMsdynUntrackedappointment = "team_msdyn_untrackedappointment";

			/// <summary>1:N team_msdyn_wallsavedqueryusersettings</summary>
			public const string TeamMsdynWallsavedqueryusersettings = "team_msdyn_wallsavedqueryusersettings";

			/// <summary>1:N team_msdynce_botcontent</summary>
			public const string TeamMsdynceBotcontent = "team_msdynce_botcontent";

			/// <summary>1:N team_opportunities</summary>
			public const string TeamOpportunities = "team_opportunities";

			/// <summary>1:N team_opportunityclose</summary>
			public const string TeamOpportunityclose = "team_opportunityclose";

			/// <summary>1:N team_opportunityproduct</summary>
			public const string TeamOpportunityproduct = "team_opportunityproduct";

			/// <summary>1:N team_orderclose</summary>
			public const string TeamOrderclose = "team_orderclose";

			/// <summary>1:N team_orders</summary>
			public const string TeamOrders = "team_orders";

			/// <summary>1:N team_phonecall</summary>
			public const string TeamPhonecall = "team_phonecall";

			/// <summary>1:N team_principalobjectattributeaccess</summary>
			public const string TeamPrincipalobjectattributeaccess = "team_principalobjectattributeaccess";

			/// <summary>1:N team_principalobjectattributeaccess_principalid</summary>
			public const string TeamPrincipalobjectattributeaccessPrincipalid = "team_principalobjectattributeaccess_principalid";

			/// <summary>1:N team_processsession</summary>
			public const string TeamProcesssession = "team_processsession";

			/// <summary>1:N Team_ProcessSessions</summary>
			public const string TeamProcessSessions = "Team_ProcessSessions";

			/// <summary>1:N team_processstageparameter</summary>
			public const string TeamProcessstageparameter = "team_processstageparameter";

			/// <summary>1:N team_pw_penta_schedule_run</summary>
			public const string TeamPwPentaScheduleRun = "team_pw_penta_schedule_run";

			/// <summary>1:N team_pw_schedule</summary>
			public const string TeamPwSchedule = "team_pw_schedule";

			/// <summary>1:N team_queueitembase_workerid</summary>
			public const string TeamQueueitembaseWorkerid = "team_queueitembase_workerid";

			/// <summary>1:N team_quoteclose</summary>
			public const string TeamQuoteclose = "team_quoteclose";

			/// <summary>1:N team_quotedetail</summary>
			public const string TeamQuotedetail = "team_quotedetail";

			/// <summary>1:N team_quotes</summary>
			public const string TeamQuotes = "team_quotes";

			/// <summary>1:N team_ratingmodel</summary>
			public const string TeamRatingmodel = "team_ratingmodel";

			/// <summary>1:N team_ratingvalue</summary>
			public const string TeamRatingvalue = "team_ratingvalue";

			/// <summary>1:N team_recurringappointmentmaster</summary>
			public const string TeamRecurringappointmentmaster = "team_recurringappointmentmaster";

			/// <summary>1:N team_resource_groups</summary>
			public const string TeamResourceGroups = "team_resource_groups";

			/// <summary>1:N team_resource_specs</summary>
			public const string TeamResourceSpecs = "team_resource_specs";

			/// <summary>1:N team_salesorderdetail</summary>
			public const string TeamSalesorderdetail = "team_salesorderdetail";

			/// <summary>1:N team_service_appointments</summary>
			public const string TeamServiceAppointments = "team_service_appointments";

			/// <summary>1:N team_service_contracts</summary>
			public const string TeamServiceContracts = "team_service_contracts";

			/// <summary>1:N team_sharepointdocumentlocation</summary>
			public const string TeamSharepointdocumentlocation = "team_sharepointdocumentlocation";

			/// <summary>1:N team_sharepointsite</summary>
			public const string TeamSharepointsite = "team_sharepointsite";

			/// <summary>1:N team_slaBase</summary>
			public const string TeamSlaBase = "team_slaBase";

			/// <summary>1:N team_socialactivity</summary>
			public const string TeamSocialactivity = "team_socialactivity";

			/// <summary>1:N team_stagesolutionupload</summary>
			public const string TeamStagesolutionupload = "team_stagesolutionupload";

			/// <summary>1:N team_SyncError</summary>
			public const string TeamSyncError = "team_SyncError";

			/// <summary>1:N Team_SyncErrors</summary>
			public const string TeamSyncErrors = "Team_SyncErrors";

			/// <summary>1:N team_task</summary>
			public const string TeamTask = "team_task";

			/// <summary>1:N team_userform</summary>
			public const string TeamUserform = "team_userform";

			/// <summary>1:N team_userquery</summary>
			public const string TeamUserquery = "team_userquery";

			/// <summary>1:N team_userqueryvisualizations</summary>
			public const string TeamUserqueryvisualizations = "team_userqueryvisualizations";

			/// <summary>1:N team_workflow</summary>
			public const string TeamWorkflow = "team_workflow";

			/// <summary>1:N team_workflowbinary</summary>
			public const string TeamWorkflowbinary = "team_workflowbinary";

			/// <summary>1:N team_workflowlog</summary>
			public const string TeamWorkflowlog = "team_workflowlog";

			/// <summary>N:N teammembership_association</summary>
			public const string TeammembershipAssociation = "teammembership_association";

			/// <summary>N:N teamprofiles_association</summary>
			public const string TeamprofilesAssociation = "teamprofiles_association";

			/// <summary>N:N teamroles_association</summary>
			public const string TeamrolesAssociation = "teamroles_association";

		}
		#endregion
	}
}

