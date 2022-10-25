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
	[EntityLogicalName("customapirequestparameter")]
	public sealed class CustomAPIRequestParameter : Entity
	{	
		public static readonly int? EntityTypeCode = 10052;
		public new const string LogicalName = "customapirequestparameter";
		public const string PrimaryIdAttribute = "customapirequestparameterid";
		public const string PrimaryNameAttribute = "name";
	
		public CustomAPIRequestParameter() : base("customapirequestparameter") { }

		#region Attributes
		/// <summary>
        /// componentidunique
        /// </summary>
		[DisplayName("Row id unique")]
		[AttributeLogicalName("componentidunique")]
		public Guid RowIdUniqueId
		{	
			get { return GetAttributeValue<Guid>("componentidunique"); }
			set
			{ 
				if(value == RowIdUniqueId) return;
				SetAttributeValue("componentidunique", value);
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
        /// customapiid
        /// </summary>
		[DisplayName("Custom API")]
		[AttributeLogicalName("customapiid")]
		public EntityReference CustomAPI
		{	
			get { return GetAttributeValue<EntityReference>("customapiid"); }
			set
			{ 
				if(value == CustomAPI) return;
				SetAttributeValue("customapiid", value);
			}
		}	
			
		/// <summary>
        /// customapiidname
        /// </summary>
		[DisplayName("customapiidname")]
		[AttributeLogicalName("customapiidname")]
		public string Customapiidname
		{	
			get { return GetAttributeValue<string>("customapiidname"); }
			set
			{ 
				if(value == Customapiidname) return;
				SetAttributeValue("customapiidname", value);
			}
		}	
			
		/// <summary>
        /// customapirequestparameterid
        /// </summary>
		[DisplayName("Custom API Request Parameter")]
		[AttributeLogicalName("customapirequestparameterid")]
		public override Guid Id
		{
			get => base.Id;
			set { base.Id = value; SetAttributeValue("customapirequestparameterid", value); }
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
        /// displayname
        /// </summary>
		[DisplayName("Display Name")]
		[AttributeLogicalName("displayname")]
		public string DisplayName
		{	
			get { return GetAttributeValue<string>("displayname"); }
			set
			{ 
				if(value == DisplayName) return;
				SetAttributeValue("displayname", value);
			}
		}	
			
		/// <summary>
        /// entitylogicalname
        /// </summary>
		[DisplayName("Entity Logical Name")]
		[AttributeLogicalName("entitylogicalname")]
		public string EntityLogicalName
		{	
			get { return GetAttributeValue<string>("entitylogicalname"); }
			set
			{ 
				if(value == EntityLogicalName) return;
				SetAttributeValue("entitylogicalname", value);
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
        /// isoptional
        /// </summary>
		[DisplayName("Is Optional")]
		[AttributeLogicalName("isoptional")]
		public bool? IsOptional
		{	
			get { return GetAttributeValue<bool?>("isoptional"); }
			set
			{ 
				if(value == IsOptional) return;
				SetAttributeValue("isoptional", value);
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
        /// type
        /// </summary>
		[DisplayName("Type")]
		[AttributeLogicalName("type")]
		public egCustomAPIFieldType? Type
		{	
			get 
			{ 
				var optionSetValue = GetAttributeValue<OptionSetValue>("type");
				if (optionSetValue != null) return (egCustomAPIFieldType)optionSetValue.Value;
				else return null;
			}
			set 
			{ 
				if(value == Type) return;

				OptionSetValue optionSetValue = null;
				if(value != null) optionSetValue = new OptionSetValue((int)value);
				SetAttributeValue("type", optionSetValue); 
			}
		}

		/// <summary>
        /// uniquename
        /// </summary>
		[DisplayName("Unique Name")]
		[AttributeLogicalName("uniquename")]
		public string UniqueName
		{	
			get { return GetAttributeValue<string>("uniquename"); }
			set
			{ 
				if(value == UniqueName) return;
				SetAttributeValue("uniquename", value);
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
        /// 1:N Get entities for 'customapirequestparameter_AsyncOperations'
        /// </summary>
		[RelationshipSchemaName("customapirequestparameter_AsyncOperations")]
		public IEnumerable<SystemJob> CustomapirequestparameterAsyncOperations
		{
			get { return GetRelatedEntities<SystemJob>("customapirequestparameter_AsyncOperations", null); }
			set { SetRelatedEntities("customapirequestparameter_AsyncOperations", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'customapirequestparameter_BulkDeleteFailures'
        /// </summary>
		[RelationshipSchemaName("customapirequestparameter_BulkDeleteFailures")]
		public IEnumerable<BulkDeleteFailure> CustomapirequestparameterBulkDeleteFailures
		{
			get { return GetRelatedEntities<BulkDeleteFailure>("customapirequestparameter_BulkDeleteFailures", null); }
			set { SetRelatedEntities("customapirequestparameter_BulkDeleteFailures", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'customapirequestparameter_MailboxTrackingFolders'
        /// </summary>
		[RelationshipSchemaName("customapirequestparameter_MailboxTrackingFolders")]
		public IEnumerable<MailboxAutoTrackingFolder> CustomapirequestparameterMailboxTrackingFolders
		{
			get { return GetRelatedEntities<MailboxAutoTrackingFolder>("customapirequestparameter_MailboxTrackingFolders", null); }
			set { SetRelatedEntities("customapirequestparameter_MailboxTrackingFolders", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'customapirequestparameter_PrincipalObjectAttributeAccesses'
        /// </summary>
		[RelationshipSchemaName("customapirequestparameter_PrincipalObjectAttributeAccesses")]
		public IEnumerable<FieldSharing> CustomapirequestparameterPrincipalObjectAttributeAccesses
		{
			get { return GetRelatedEntities<FieldSharing>("customapirequestparameter_PrincipalObjectAttributeAccesses", null); }
			set { SetRelatedEntities("customapirequestparameter_PrincipalObjectAttributeAccesses", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'customapirequestparameter_ProcessSession'
        /// </summary>
		[RelationshipSchemaName("customapirequestparameter_ProcessSession")]
		public IEnumerable<ProcessSession> CustomapirequestparameterProcessSession
		{
			get { return GetRelatedEntities<ProcessSession>("customapirequestparameter_ProcessSession", null); }
			set { SetRelatedEntities("customapirequestparameter_ProcessSession", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'customapirequestparameter_SyncErrors'
        /// </summary>
		[RelationshipSchemaName("customapirequestparameter_SyncErrors")]
		public IEnumerable<SyncError> CustomapirequestparameterSyncErrors
		{
			get { return GetRelatedEntities<SyncError>("customapirequestparameter_SyncErrors", null); }
			set { SetRelatedEntities("customapirequestparameter_SyncErrors", null, value); }
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
		
		public enum egCustomAPIFieldType
		{	
		
			[Label("Boolean")]
			[Description(@"")]
			Boolean = 0, 
		
			[Label("DateTime")]
			[Description(@"")]
			DateTime = 1, 
		
			[Label("Decimal")]
			[Description(@"")]
			Decimal = 2, 
		
			[Label("Entity")]
			[Description(@"")]
			Entity = 3, 
		
			[Label("EntityCollection")]
			[Description(@"")]
			EntityCollection = 4, 
		
			[Label("EntityReference")]
			[Description(@"")]
			EntityReference = 5, 
		
			[Label("Float")]
			[Description(@"")]
			Float = 6, 
		
			[Label("Integer")]
			[Description(@"")]
			Integer = 7, 
		
			[Label("Money")]
			[Description(@"")]
			Money = 8, 
		
			[Label("Picklist")]
			[Description(@"")]
			Picklist = 9, 
		
			[Label("String")]
			[Description(@"")]
			String = 10, 
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
			/// <summary>componentidunique</summary>
			public const string RowIdUniqueId = "componentidunique";

			/// <summary>componentstate</summary>
			public const string ComponentState = "componentstate";

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

			/// <summary>customapiid</summary>
			public const string CustomAPI = "customapiid";

			/// <summary>customapiidname</summary>
			public const string Customapiidname = "customapiidname";

			/// <summary>customapirequestparameterid</summary>
			public const string CustomAPIRequestParameterId = "customapirequestparameterid";

			/// <summary>description</summary>
			public const string Description = "description";

			/// <summary>displayname</summary>
			public const string DisplayName = "displayname";

			/// <summary>entitylogicalname</summary>
			public const string EntityLogicalName = "entitylogicalname";

			/// <summary>importsequencenumber</summary>
			public const string ImportSequenceNumber = "importsequencenumber";

			/// <summary>ismanaged</summary>
			public const string IsManaged = "ismanaged";

			/// <summary>isoptional</summary>
			public const string IsOptional = "isoptional";

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

			/// <summary>overriddencreatedon</summary>
			public const string RecordCreatedOn = "overriddencreatedon";

			/// <summary>overwritetime</summary>
			public const string RecordOverwriteTime = "overwritetime";

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

			/// <summary>solutionid</summary>
			public const string SolutionId = "solutionid";

			/// <summary>statecode</summary>
			public const string Status = "statecode";

			/// <summary>statuscode</summary>
			public const string StatusReason = "statuscode";

			/// <summary>supportingsolutionid</summary>
			public const string SolutionId2 = "supportingsolutionid";

			/// <summary>timezoneruleversionnumber</summary>
			public const string TimeZoneRuleVersionNumber = "timezoneruleversionnumber";

			/// <summary>type</summary>
			public const string Type = "type";

			/// <summary>uniquename</summary>
			public const string UniqueName = "uniquename";

			/// <summary>utcconversiontimezonecode</summary>
			public const string UTCConversionTimeZoneCode = "utcconversiontimezonecode";

			/// <summary>versionnumber</summary>
			public const string VersionNumber = "versionnumber";

		}
		#endregion

		#region Schemas
		public static class Schemas 
		{
			/// <summary>1:N customapirequestparameter_AsyncOperations</summary>
			public const string CustomapirequestparameterAsyncOperations = "customapirequestparameter_AsyncOperations";

			/// <summary>1:N customapirequestparameter_BulkDeleteFailures</summary>
			public const string CustomapirequestparameterBulkDeleteFailures = "customapirequestparameter_BulkDeleteFailures";

			/// <summary>1:N customapirequestparameter_MailboxTrackingFolders</summary>
			public const string CustomapirequestparameterMailboxTrackingFolders = "customapirequestparameter_MailboxTrackingFolders";

			/// <summary>1:N customapirequestparameter_PrincipalObjectAttributeAccesses</summary>
			public const string CustomapirequestparameterPrincipalObjectAttributeAccesses = "customapirequestparameter_PrincipalObjectAttributeAccesses";

			/// <summary>1:N customapirequestparameter_ProcessSession</summary>
			public const string CustomapirequestparameterProcessSession = "customapirequestparameter_ProcessSession";

			/// <summary>1:N customapirequestparameter_SyncErrors</summary>
			public const string CustomapirequestparameterSyncErrors = "customapirequestparameter_SyncErrors";

		}
		#endregion
	}
}

