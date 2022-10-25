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
	[EntityLogicalName("customapi")]
	public sealed class CustomAPI : Entity
	{	
		public static readonly int? EntityTypeCode = 10051;
		public new const string LogicalName = "customapi";
		public const string PrimaryIdAttribute = "customapiid";
		public const string PrimaryNameAttribute = "name";
	
		public CustomAPI() : base("customapi") { }

		#region Attributes
		/// <summary>
        /// allowedcustomprocessingsteptype
        /// </summary>
		[DisplayName("Allowed Custom Processing Step Type")]
		[AttributeLogicalName("allowedcustomprocessingsteptype")]
		public eAllowedCustomProcessingStepType? AllowedCustomProcessingStepType
		{	
			get 
			{ 
				var optionSetValue = GetAttributeValue<OptionSetValue>("allowedcustomprocessingsteptype");
				if (optionSetValue != null) return (eAllowedCustomProcessingStepType)optionSetValue.Value;
				else return null;
			}
			set 
			{ 
				if(value == AllowedCustomProcessingStepType) return;

				OptionSetValue optionSetValue = null;
				if(value != null) optionSetValue = new OptionSetValue((int)value);
				SetAttributeValue("allowedcustomprocessingsteptype", optionSetValue); 
			}
		}

		/// <summary>
        /// bindingtype
        /// </summary>
		[DisplayName("Binding Type")]
		[AttributeLogicalName("bindingtype")]
		public eBindingType? BindingType
		{	
			get 
			{ 
				var optionSetValue = GetAttributeValue<OptionSetValue>("bindingtype");
				if (optionSetValue != null) return (eBindingType)optionSetValue.Value;
				else return null;
			}
			set 
			{ 
				if(value == BindingType) return;

				OptionSetValue optionSetValue = null;
				if(value != null) optionSetValue = new OptionSetValue((int)value);
				SetAttributeValue("bindingtype", optionSetValue); 
			}
		}

		/// <summary>
        /// boundentitylogicalname
        /// </summary>
		[DisplayName("Bound Entity Logical Name")]
		[AttributeLogicalName("boundentitylogicalname")]
		public string BoundEntityLogicalName
		{	
			get { return GetAttributeValue<string>("boundentitylogicalname"); }
			set
			{ 
				if(value == BoundEntityLogicalName) return;
				SetAttributeValue("boundentitylogicalname", value);
			}
		}	
			
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
		public override Guid Id
		{
			get => base.Id;
			set { base.Id = value; SetAttributeValue("customapiid", value); }
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
        /// executeprivilegename
        /// </summary>
		[DisplayName("Execute Privilege Name")]
		[AttributeLogicalName("executeprivilegename")]
		public string ExecutePrivilegeName
		{	
			get { return GetAttributeValue<string>("executeprivilegename"); }
			set
			{ 
				if(value == ExecutePrivilegeName) return;
				SetAttributeValue("executeprivilegename", value);
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
        /// isfunction
        /// </summary>
		[DisplayName("Is Function")]
		[AttributeLogicalName("isfunction")]
		public bool? IsFunction
		{	
			get { return GetAttributeValue<bool?>("isfunction"); }
			set
			{ 
				if(value == IsFunction) return;
				SetAttributeValue("isfunction", value);
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
        /// isprivate
        /// </summary>
		[DisplayName("Is Private")]
		[AttributeLogicalName("isprivate")]
		public bool? IsPrivate
		{	
			get { return GetAttributeValue<bool?>("isprivate"); }
			set
			{ 
				if(value == IsPrivate) return;
				SetAttributeValue("isprivate", value);
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
        /// plugintypeid
        /// </summary>
		[DisplayName("Plugin Type")]
		[AttributeLogicalName("plugintypeid")]
		public EntityReference PluginType
		{	
			get { return GetAttributeValue<EntityReference>("plugintypeid"); }
			set
			{ 
				if(value == PluginType) return;
				SetAttributeValue("plugintypeid", value);
			}
		}	
			
		/// <summary>
        /// plugintypeidname
        /// </summary>
		[DisplayName("plugintypeidname")]
		[AttributeLogicalName("plugintypeidname")]
		public string Plugintypeidname
		{	
			get { return GetAttributeValue<string>("plugintypeidname"); }
			set
			{ 
				if(value == Plugintypeidname) return;
				SetAttributeValue("plugintypeidname", value);
			}
		}	
			
		/// <summary>
        /// sdkmessageid
        /// </summary>
		[DisplayName("Sdk Message")]
		[AttributeLogicalName("sdkmessageid")]
		public EntityReference SdkMessage
		{	
			get { return GetAttributeValue<EntityReference>("sdkmessageid"); }
			set
			{ 
				if(value == SdkMessage) return;
				SetAttributeValue("sdkmessageid", value);
			}
		}	
			
		/// <summary>
        /// sdkmessageidname
        /// </summary>
		[DisplayName("sdkmessageidname")]
		[AttributeLogicalName("sdkmessageidname")]
		public string Sdkmessageidname
		{	
			get { return GetAttributeValue<string>("sdkmessageidname"); }
			set
			{ 
				if(value == Sdkmessageidname) return;
				SetAttributeValue("sdkmessageidname", value);
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
        /// 1:N Get entities for 'catalogassignment_customapi'
        /// </summary>
		[RelationshipSchemaName("catalogassignment_customapi")]
		public IEnumerable<CatalogAssignment> CatalogassignmentCustomapi
		{
			get { return GetRelatedEntities<CatalogAssignment>("catalogassignment_customapi", null); }
			set { SetRelatedEntities("catalogassignment_customapi", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'customapi_AsyncOperations'
        /// </summary>
		[RelationshipSchemaName("customapi_AsyncOperations")]
		public IEnumerable<SystemJob> CustomapiAsyncOperations
		{
			get { return GetRelatedEntities<SystemJob>("customapi_AsyncOperations", null); }
			set { SetRelatedEntities("customapi_AsyncOperations", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'customapi_BulkDeleteFailures'
        /// </summary>
		[RelationshipSchemaName("customapi_BulkDeleteFailures")]
		public IEnumerable<BulkDeleteFailure> CustomapiBulkDeleteFailures
		{
			get { return GetRelatedEntities<BulkDeleteFailure>("customapi_BulkDeleteFailures", null); }
			set { SetRelatedEntities("customapi_BulkDeleteFailures", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'customapi_customapirequestparameter'
        /// </summary>
		[RelationshipSchemaName("customapi_customapirequestparameter")]
		public IEnumerable<CustomAPIRequestParameter> CustomapiCustomapirequestparameter
		{
			get { return GetRelatedEntities<CustomAPIRequestParameter>("customapi_customapirequestparameter", null); }
			set { SetRelatedEntities("customapi_customapirequestparameter", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'customapi_customapiresponseproperty'
        /// </summary>
		[RelationshipSchemaName("customapi_customapiresponseproperty")]
		public IEnumerable<CustomAPIResponseProperty> CustomapiCustomapiresponseproperty
		{
			get { return GetRelatedEntities<CustomAPIResponseProperty>("customapi_customapiresponseproperty", null); }
			set { SetRelatedEntities("customapi_customapiresponseproperty", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'customapi_MailboxTrackingFolders'
        /// </summary>
		[RelationshipSchemaName("customapi_MailboxTrackingFolders")]
		public IEnumerable<MailboxAutoTrackingFolder> CustomapiMailboxTrackingFolders
		{
			get { return GetRelatedEntities<MailboxAutoTrackingFolder>("customapi_MailboxTrackingFolders", null); }
			set { SetRelatedEntities("customapi_MailboxTrackingFolders", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'customapi_PrincipalObjectAttributeAccesses'
        /// </summary>
		[RelationshipSchemaName("customapi_PrincipalObjectAttributeAccesses")]
		public IEnumerable<FieldSharing> CustomapiPrincipalObjectAttributeAccesses
		{
			get { return GetRelatedEntities<FieldSharing>("customapi_PrincipalObjectAttributeAccesses", null); }
			set { SetRelatedEntities("customapi_PrincipalObjectAttributeAccesses", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'customapi_ProcessSession'
        /// </summary>
		[RelationshipSchemaName("customapi_ProcessSession")]
		public IEnumerable<ProcessSession> CustomapiProcessSession
		{
			get { return GetRelatedEntities<ProcessSession>("customapi_ProcessSession", null); }
			set { SetRelatedEntities("customapi_ProcessSession", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'customapi_SyncErrors'
        /// </summary>
		[RelationshipSchemaName("customapi_SyncErrors")]
		public IEnumerable<SyncError> CustomapiSyncErrors
		{
			get { return GetRelatedEntities<SyncError>("customapi_SyncErrors", null); }
			set { SetRelatedEntities("customapi_SyncErrors", null, value); }
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
		
		public enum eAllowedCustomProcessingStepType
		{	
		
			[Label("None")]
			[Description(@"")]
			None = 0, 
		
			[Label("Async Only")]
			[Description(@"")]
			AsyncOnly = 1, 
		
			[Label("Sync and Async")]
			[Description(@"")]
			SyncAndAsync = 2, 
		}
		
		public enum eBindingType
		{	
		
			[Label("Global")]
			[Description(@"")]
			Global = 0, 
		
			[Label("Entity")]
			[Description(@"")]
			Entity = 1, 
		
			[Label("Entity Collection")]
			[Description(@"")]
			EntityCollection = 2, 
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
			/// <summary>allowedcustomprocessingsteptype</summary>
			public const string AllowedCustomProcessingStepType = "allowedcustomprocessingsteptype";

			/// <summary>bindingtype</summary>
			public const string BindingType = "bindingtype";

			/// <summary>boundentitylogicalname</summary>
			public const string BoundEntityLogicalName = "boundentitylogicalname";

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
			public const string CustomAPIId = "customapiid";

			/// <summary>description</summary>
			public const string Description = "description";

			/// <summary>displayname</summary>
			public const string DisplayName = "displayname";

			/// <summary>executeprivilegename</summary>
			public const string ExecutePrivilegeName = "executeprivilegename";

			/// <summary>importsequencenumber</summary>
			public const string ImportSequenceNumber = "importsequencenumber";

			/// <summary>isfunction</summary>
			public const string IsFunction = "isfunction";

			/// <summary>ismanaged</summary>
			public const string IsManaged = "ismanaged";

			/// <summary>isprivate</summary>
			public const string IsPrivate = "isprivate";

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

			/// <summary>plugintypeid</summary>
			public const string PluginType = "plugintypeid";

			/// <summary>plugintypeidname</summary>
			public const string Plugintypeidname = "plugintypeidname";

			/// <summary>sdkmessageid</summary>
			public const string SdkMessage = "sdkmessageid";

			/// <summary>sdkmessageidname</summary>
			public const string Sdkmessageidname = "sdkmessageidname";

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
			/// <summary>1:N catalogassignment_customapi</summary>
			public const string CatalogassignmentCustomapi = "catalogassignment_customapi";

			/// <summary>1:N customapi_AsyncOperations</summary>
			public const string CustomapiAsyncOperations = "customapi_AsyncOperations";

			/// <summary>1:N customapi_BulkDeleteFailures</summary>
			public const string CustomapiBulkDeleteFailures = "customapi_BulkDeleteFailures";

			/// <summary>1:N customapi_customapirequestparameter</summary>
			public const string CustomapiCustomapirequestparameter = "customapi_customapirequestparameter";

			/// <summary>1:N customapi_customapiresponseproperty</summary>
			public const string CustomapiCustomapiresponseproperty = "customapi_customapiresponseproperty";

			/// <summary>1:N customapi_MailboxTrackingFolders</summary>
			public const string CustomapiMailboxTrackingFolders = "customapi_MailboxTrackingFolders";

			/// <summary>1:N customapi_PrincipalObjectAttributeAccesses</summary>
			public const string CustomapiPrincipalObjectAttributeAccesses = "customapi_PrincipalObjectAttributeAccesses";

			/// <summary>1:N customapi_ProcessSession</summary>
			public const string CustomapiProcessSession = "customapi_ProcessSession";

			/// <summary>1:N customapi_SyncErrors</summary>
			public const string CustomapiSyncErrors = "customapi_SyncErrors";

		}
		#endregion
	}
}

