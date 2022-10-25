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
	[EntityLogicalName("contracttemplate")]
	public sealed class ContractTemplate : Entity
	{	
		public static readonly int? EntityTypeCode = 2011;
		public new const string LogicalName = "contracttemplate";
		public const string PrimaryIdAttribute = "contracttemplateid";
		public const string PrimaryNameAttribute = "name";
	
		public ContractTemplate() : base("contracttemplate") { }

		#region Attributes
		/// <summary>
        /// abbreviation
        /// </summary>
		[DisplayName("Abbreviation")]
		[AttributeLogicalName("abbreviation")]
		public string Abbreviation
		{	
			get { return GetAttributeValue<string>("abbreviation"); }
			set
			{ 
				if(value == Abbreviation) return;
				SetAttributeValue("abbreviation", value);
			}
		}	
			
		/// <summary>
        /// allotmenttypecode
        /// </summary>
		[DisplayName("Allotment Type")]
		[AttributeLogicalName("allotmenttypecode")]
		public eAllotmentType? AllotmentType
		{	
			get 
			{ 
				var optionSetValue = GetAttributeValue<OptionSetValue>("allotmenttypecode");
				if (optionSetValue != null) return (eAllotmentType)optionSetValue.Value;
				else return null;
			}
			set 
			{ 
				if(value == AllotmentType) return;

				OptionSetValue optionSetValue = null;
				if(value != null) optionSetValue = new OptionSetValue((int)value);
				SetAttributeValue("allotmenttypecode", optionSetValue); 
			}
		}

		/// <summary>
        /// billingfrequencycode
        /// </summary>
		[DisplayName("Billing Frequency")]
		[AttributeLogicalName("billingfrequencycode")]
		public eBillingFrequency? BillingFrequency
		{	
			get 
			{ 
				var optionSetValue = GetAttributeValue<OptionSetValue>("billingfrequencycode");
				if (optionSetValue != null) return (eBillingFrequency)optionSetValue.Value;
				else return null;
			}
			set 
			{ 
				if(value == BillingFrequency) return;

				OptionSetValue optionSetValue = null;
				if(value != null) optionSetValue = new OptionSetValue((int)value);
				SetAttributeValue("billingfrequencycode", optionSetValue); 
			}
		}

		/// <summary>
        /// componentstate
        /// </summary>
		[DisplayName("Component State")]
		[AttributeLogicalName("componentstate")]
		public egComponentState? ComponentState
		{	
			get 
			{ 
				var optionSetValue = GetAttributeValue<OptionSetValue>("componentstate");
				if (optionSetValue != null) return (egComponentState)optionSetValue.Value;
				else return null;
			}
			set 
			{ 
				if(value == ComponentState) return;

				OptionSetValue optionSetValue = null;
				if(value != null) optionSetValue = new OptionSetValue((int)value);
				SetAttributeValue("componentstate", optionSetValue); 
			}
		}

		/// <summary>
        /// contractservicelevelcode
        /// </summary>
		[DisplayName("Contract Service Level")]
		[AttributeLogicalName("contractservicelevelcode")]
		public eContractServiceLevel? ContractServiceLevel
		{	
			get 
			{ 
				var optionSetValue = GetAttributeValue<OptionSetValue>("contractservicelevelcode");
				if (optionSetValue != null) return (eContractServiceLevel)optionSetValue.Value;
				else return null;
			}
			set 
			{ 
				if(value == ContractServiceLevel) return;

				OptionSetValue optionSetValue = null;
				if(value != null) optionSetValue = new OptionSetValue((int)value);
				SetAttributeValue("contractservicelevelcode", optionSetValue); 
			}
		}

		/// <summary>
        /// contracttemplateid
        /// </summary>
		[DisplayName("Contract Template")]
		[AttributeLogicalName("contracttemplateid")]
		public override Guid Id
		{
			get => base.Id;
			set { base.Id = value; SetAttributeValue("contracttemplateid", value); }
		}

							/// <summary>
        /// contracttemplateidunique
        /// </summary>
		[DisplayName("contracttemplateidunique")]
		[AttributeLogicalName("contracttemplateidunique")]
		public Guid ContracttemplateiduniqueId
		{	
			get { return GetAttributeValue<Guid>("contracttemplateidunique"); }
			set
			{ 
				if(value == ContracttemplateiduniqueId) return;
				SetAttributeValue("contracttemplateidunique", value);
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
        /// effectivitycalendar
        /// </summary>
		[DisplayName("Support Calendar")]
		[AttributeLogicalName("effectivitycalendar")]
		public string SupportCalendar
		{	
			get { return GetAttributeValue<string>("effectivitycalendar"); }
			set
			{ 
				if(value == SupportCalendar) return;
				SetAttributeValue("effectivitycalendar", value);
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
        /// introducedversion
        /// </summary>
		[DisplayName("Introduced Version")]
		[AttributeLogicalName("introducedversion")]
		public string IntroducedVersion
		{	
			get { return GetAttributeValue<string>("introducedversion"); }
			set
			{ 
				if(value == IntroducedVersion) return;
				SetAttributeValue("introducedversion", value);
			}
		}	
			
		/// <summary>
        /// ismanaged
        /// </summary>
		[DisplayName("Is Managed")]
		[AttributeLogicalName("ismanaged")]
		public bool? IsManaged
		{	
			get { return GetAttributeValue<bool?>("ismanaged"); }
			set
			{ 
				if(value == IsManaged) return;
				SetAttributeValue("ismanaged", value);
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
        /// organizationid
        /// </summary>
		[DisplayName("Organization Id")]
		[AttributeLogicalName("organizationid")]
		public EntityReference OrganizationId
		{	
			get { return GetAttributeValue<EntityReference>("organizationid"); }
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
        /// overwritetime
        /// </summary>
		[DisplayName("Record Overwrite Time")]
		[AttributeLogicalName("overwritetime")]
		public DateTime? RecordOverwriteTime
		{	
			get { return GetAttributeValue<DateTime?>("overwritetime"); }
			set
			{ 
				if(value == RecordOverwriteTime) return;
				SetAttributeValue("overwritetime", value);
			}
		}	
			
		/// <summary>
        /// solutionid
        /// </summary>
		[DisplayName("Solution")]
		[AttributeLogicalName("solutionid")]
		public Guid SolutionId
		{	
			get { return GetAttributeValue<Guid>("solutionid"); }
			set
			{ 
				if(value == SolutionId) return;
				SetAttributeValue("solutionid", value);
			}
		}	
			
		/// <summary>
        /// supportingsolutionid
        /// </summary>
		[DisplayName("Solution")]
		[AttributeLogicalName("supportingsolutionid")]
		public Guid SolutionId2
		{	
			get { return GetAttributeValue<Guid>("supportingsolutionid"); }
			set
			{ 
				if(value == SolutionId2) return;
				SetAttributeValue("supportingsolutionid", value);
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
        /// usediscountaspercentage
        /// </summary>
		[DisplayName("Use Discount as Percentage")]
		[AttributeLogicalName("usediscountaspercentage")]
		public bool? UseDiscountAsPercentage
		{	
			get { return GetAttributeValue<bool?>("usediscountaspercentage"); }
			set
			{ 
				if(value == UseDiscountAsPercentage) return;
				SetAttributeValue("usediscountaspercentage", value);
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
        /// 1:N Get entities for 'contract_template_contracts'
        /// </summary>
		[RelationshipSchemaName("contract_template_contracts")]
		public IEnumerable<Contract> ContractTemplateContracts
		{
			get { return GetRelatedEntities<Contract>("contract_template_contracts", null); }
			set { SetRelatedEntities("contract_template_contracts", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'ContractTemplate_AsyncOperations'
        /// </summary>
		[RelationshipSchemaName("ContractTemplate_AsyncOperations")]
		public IEnumerable<SystemJob> ContractTemplateAsyncOperations
		{
			get { return GetRelatedEntities<SystemJob>("ContractTemplate_AsyncOperations", null); }
			set { SetRelatedEntities("ContractTemplate_AsyncOperations", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'ContractTemplate_BulkDeleteFailures'
        /// </summary>
		[RelationshipSchemaName("ContractTemplate_BulkDeleteFailures")]
		public IEnumerable<BulkDeleteFailure> ContractTemplateBulkDeleteFailures
		{
			get { return GetRelatedEntities<BulkDeleteFailure>("ContractTemplate_BulkDeleteFailures", null); }
			set { SetRelatedEntities("ContractTemplate_BulkDeleteFailures", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'contracttemplate_MailboxTrackingFolders'
        /// </summary>
		[RelationshipSchemaName("contracttemplate_MailboxTrackingFolders")]
		public IEnumerable<MailboxAutoTrackingFolder> ContracttemplateMailboxTrackingFolders
		{
			get { return GetRelatedEntities<MailboxAutoTrackingFolder>("contracttemplate_MailboxTrackingFolders", null); }
			set { SetRelatedEntities("contracttemplate_MailboxTrackingFolders", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'contracttemplate_PrincipalObjectAttributeAccesses'
        /// </summary>
		[RelationshipSchemaName("contracttemplate_PrincipalObjectAttributeAccesses")]
		public IEnumerable<FieldSharing> ContracttemplatePrincipalObjectAttributeAccesses
		{
			get { return GetRelatedEntities<FieldSharing>("contracttemplate_PrincipalObjectAttributeAccesses", null); }
			set { SetRelatedEntities("contracttemplate_PrincipalObjectAttributeAccesses", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'ContractTemplate_ProcessSessions'
        /// </summary>
		[RelationshipSchemaName("ContractTemplate_ProcessSessions")]
		public IEnumerable<ProcessSession> ContractTemplateProcessSessions
		{
			get { return GetRelatedEntities<ProcessSession>("ContractTemplate_ProcessSessions", null); }
			set { SetRelatedEntities("ContractTemplate_ProcessSessions", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'ContractTemplate_SyncErrors'
        /// </summary>
		[RelationshipSchemaName("ContractTemplate_SyncErrors")]
		public IEnumerable<SyncError> ContractTemplateSyncErrors
		{
			get { return GetRelatedEntities<SyncError>("ContractTemplate_SyncErrors", null); }
			set { SetRelatedEntities("ContractTemplate_SyncErrors", null, value); }
		}
		#endregion

		#region Actions
		#endregion

		#region OptionSetEnums
		public enum egComponentState
		{	
		
			[Label("Published")]
			[Description(@"")]
			Published = 0, 
		
			[Label("Unpublished")]
			[Description(@"")]
			Unpublished = 1, 
		
			[Label("Deleted")]
			[Description(@"")]
			Deleted = 2, 
		
			[Label("Deleted Unpublished")]
			[Description(@"")]
			DeletedUnpublished = 3, 
		}
		
		public enum eAllotmentType
		{	
		
			[Label("Number of Cases")]
			[Description(@"")]
			NumberOfCases = 1, 
		
			[Label("Time")]
			[Description(@"")]
			Time = 2, 
		
			[Label("Coverage Dates")]
			[Description(@"")]
			CoverageDates = 3, 
		}
		
		public enum eBillingFrequency
		{	
		
			[Label("Monthly")]
			[Description(@"")]
			Monthly = 1, 
		
			[Label("Bimonthly")]
			[Description(@"")]
			Bimonthly = 2, 
		
			[Label("Quarterly")]
			[Description(@"")]
			Quarterly = 3, 
		
			[Label("Semiannually")]
			[Description(@"")]
			Semiannually = 4, 
		
			[Label("Annually")]
			[Description(@"")]
			Annually = 5, 
		}
		
		public enum eContractServiceLevel
		{	
		
			[Label("Gold")]
			[Description(@"")]
			Gold = 1, 
		
			[Label("Silver")]
			[Description(@"")]
			Silver = 2, 
		
			[Label("Bronze")]
			[Description(@"")]
			Bronze = 3, 
		}
		
		#endregion	

		#region Properties
		public static class Properties 
		{
			/// <summary>abbreviation</summary>
			public const string Abbreviation = "abbreviation";

			/// <summary>allotmenttypecode</summary>
			public const string AllotmentType = "allotmenttypecode";

			/// <summary>billingfrequencycode</summary>
			public const string BillingFrequency = "billingfrequencycode";

			/// <summary>componentstate</summary>
			public const string ComponentState = "componentstate";

			/// <summary>contractservicelevelcode</summary>
			public const string ContractServiceLevel = "contractservicelevelcode";

			/// <summary>contracttemplateid</summary>
			public const string ContractTemplateId = "contracttemplateid";

			/// <summary>contracttemplateidunique</summary>
			public const string ContracttemplateiduniqueId = "contracttemplateidunique";

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

			/// <summary>effectivitycalendar</summary>
			public const string SupportCalendar = "effectivitycalendar";

			/// <summary>importsequencenumber</summary>
			public const string ImportSequenceNumber = "importsequencenumber";

			/// <summary>introducedversion</summary>
			public const string IntroducedVersion = "introducedversion";

			/// <summary>ismanaged</summary>
			public const string IsManaged = "ismanaged";

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

			/// <summary>organizationid</summary>
			public const string OrganizationId = "organizationid";

			/// <summary>organizationidname</summary>
			public const string Organizationidname = "organizationidname";

			/// <summary>overriddencreatedon</summary>
			public const string RecordCreatedOn = "overriddencreatedon";

			/// <summary>overwritetime</summary>
			public const string RecordOverwriteTime = "overwritetime";

			/// <summary>solutionid</summary>
			public const string SolutionId = "solutionid";

			/// <summary>supportingsolutionid</summary>
			public const string SolutionId2 = "supportingsolutionid";

			/// <summary>timezoneruleversionnumber</summary>
			public const string TimeZoneRuleVersionNumber = "timezoneruleversionnumber";

			/// <summary>usediscountaspercentage</summary>
			public const string UseDiscountAsPercentage = "usediscountaspercentage";

			/// <summary>utcconversiontimezonecode</summary>
			public const string UTCConversionTimeZoneCode = "utcconversiontimezonecode";

			/// <summary>versionnumber</summary>
			public const string VersionNumber = "versionnumber";

		}
		#endregion

		#region Schemas
		public static class Schemas 
		{
			/// <summary>1:N contract_template_contracts</summary>
			public const string ContractTemplateContracts = "contract_template_contracts";

			/// <summary>1:N ContractTemplate_AsyncOperations</summary>
			public const string ContractTemplateAsyncOperations = "ContractTemplate_AsyncOperations";

			/// <summary>1:N ContractTemplate_BulkDeleteFailures</summary>
			public const string ContractTemplateBulkDeleteFailures = "ContractTemplate_BulkDeleteFailures";

			/// <summary>1:N contracttemplate_MailboxTrackingFolders</summary>
			public const string ContracttemplateMailboxTrackingFolders = "contracttemplate_MailboxTrackingFolders";

			/// <summary>1:N contracttemplate_PrincipalObjectAttributeAccesses</summary>
			public const string ContracttemplatePrincipalObjectAttributeAccesses = "contracttemplate_PrincipalObjectAttributeAccesses";

			/// <summary>1:N ContractTemplate_ProcessSessions</summary>
			public const string ContractTemplateProcessSessions = "ContractTemplate_ProcessSessions";

			/// <summary>1:N ContractTemplate_SyncErrors</summary>
			public const string ContractTemplateSyncErrors = "ContractTemplate_SyncErrors";

		}
		#endregion
	}
}

