using System;
using System.Linq;
using System.Diagnostics;
using System.ComponentModel;
using Microsoft.Xrm.Sdk; 
using Microsoft.Xrm.Sdk.Client;
using System.Collections.Generic;

namespace PentaWork.Xrm.Scheduler.Proxies.Entities
{
	[DebuggerDisplay("{SchemaName}")] 	
	[EntityLogicalName("environmentvariablevalue")]
	public sealed class EnvironmentVariableValue : Entity
	{	
		public static readonly int? EntityTypeCode = 381;
		public new const string LogicalName = "environmentvariablevalue";
		public const string PrimaryIdAttribute = "environmentvariablevalueid";
		public const string PrimaryNameAttribute = "schemaname";
	
		public EnvironmentVariableValue() : base("environmentvariablevalue") { }

		#region Attributes
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
        /// environmentvariabledefinitionid
        /// </summary>
		[DisplayName("Environment Variable Definition")]
		[AttributeLogicalName("environmentvariabledefinitionid")]
		public EntityReference EnvironmentVariableDefinition
		{	
			get { return GetAttributeValue<EntityReference>("environmentvariabledefinitionid"); }
			set
			{ 
				if(value == EnvironmentVariableDefinition) return;
				SetAttributeValue("environmentvariabledefinitionid", value);
			}
		}	
			
		/// <summary>
        /// environmentvariabledefinitionidname
        /// </summary>
		[DisplayName("environmentvariabledefinitionidname")]
		[AttributeLogicalName("environmentvariabledefinitionidname")]
		public string Environmentvariabledefinitionidname
		{	
			get { return GetAttributeValue<string>("environmentvariabledefinitionidname"); }
			set
			{ 
				if(value == Environmentvariabledefinitionidname) return;
				SetAttributeValue("environmentvariabledefinitionidname", value);
			}
		}	
			
		/// <summary>
        /// environmentvariablevalueid
        /// </summary>
		[DisplayName("Environment Variable Value")]
		[AttributeLogicalName("environmentvariablevalueid")]
		public override Guid Id
		{
			get => base.Id;
			set { base.Id = value; SetAttributeValue("environmentvariablevalueid", value); }
		}

							/// <summary>
        /// environmentvariablevalueidunique
        /// </summary>
		[DisplayName("environmentvariablevalueidunique")]
		[AttributeLogicalName("environmentvariablevalueidunique")]
		public Guid EnvironmentvariablevalueiduniqueId
		{	
			get { return GetAttributeValue<Guid>("environmentvariablevalueidunique"); }
			set
			{ 
				if(value == EnvironmentvariablevalueiduniqueId) return;
				SetAttributeValue("environmentvariablevalueidunique", value);
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
        /// schemaname
        /// </summary>
		[DisplayName("Schema Name")]
		[AttributeLogicalName("schemaname")]
		public string SchemaName
		{	
			get { return GetAttributeValue<string>("schemaname"); }
			set
			{ 
				if(value == SchemaName) return;
				SetAttributeValue("schemaname", value);
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
        /// value
        /// </summary>
		[DisplayName("Value")]
		[AttributeLogicalName("value")]
		public string Value
		{	
			get { return GetAttributeValue<string>("value"); }
			set
			{ 
				if(value == Value) return;
				SetAttributeValue("value", value);
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
        /// 1:N Get entities for 'environmentvariablevalue_AsyncOperations'
        /// </summary>
		[RelationshipSchemaName("environmentvariablevalue_AsyncOperations")]
		public IEnumerable<SystemJob> EnvironmentvariablevalueAsyncOperations
		{
			get { return GetRelatedEntities<SystemJob>("environmentvariablevalue_AsyncOperations", null); }
			set { SetRelatedEntities("environmentvariablevalue_AsyncOperations", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'environmentvariablevalue_BulkDeleteFailures'
        /// </summary>
		[RelationshipSchemaName("environmentvariablevalue_BulkDeleteFailures")]
		public IEnumerable<BulkDeleteFailure> EnvironmentvariablevalueBulkDeleteFailures
		{
			get { return GetRelatedEntities<BulkDeleteFailure>("environmentvariablevalue_BulkDeleteFailures", null); }
			set { SetRelatedEntities("environmentvariablevalue_BulkDeleteFailures", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'environmentvariablevalue_DuplicateBaseRecord'
        /// </summary>
		[RelationshipSchemaName("environmentvariablevalue_DuplicateBaseRecord")]
		public IEnumerable<DuplicateRecord> EnvironmentvariablevalueDuplicateBaseRecord
		{
			get { return GetRelatedEntities<DuplicateRecord>("environmentvariablevalue_DuplicateBaseRecord", null); }
			set { SetRelatedEntities("environmentvariablevalue_DuplicateBaseRecord", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'environmentvariablevalue_DuplicateMatchingRecord'
        /// </summary>
		[RelationshipSchemaName("environmentvariablevalue_DuplicateMatchingRecord")]
		public IEnumerable<DuplicateRecord> EnvironmentvariablevalueDuplicateMatchingRecord
		{
			get { return GetRelatedEntities<DuplicateRecord>("environmentvariablevalue_DuplicateMatchingRecord", null); }
			set { SetRelatedEntities("environmentvariablevalue_DuplicateMatchingRecord", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'environmentvariablevalue_MailboxTrackingFolders'
        /// </summary>
		[RelationshipSchemaName("environmentvariablevalue_MailboxTrackingFolders")]
		public IEnumerable<MailboxAutoTrackingFolder> EnvironmentvariablevalueMailboxTrackingFolders
		{
			get { return GetRelatedEntities<MailboxAutoTrackingFolder>("environmentvariablevalue_MailboxTrackingFolders", null); }
			set { SetRelatedEntities("environmentvariablevalue_MailboxTrackingFolders", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'environmentvariablevalue_PrincipalObjectAttributeAccesses'
        /// </summary>
		[RelationshipSchemaName("environmentvariablevalue_PrincipalObjectAttributeAccesses")]
		public IEnumerable<FieldSharing> EnvironmentvariablevaluePrincipalObjectAttributeAccesses
		{
			get { return GetRelatedEntities<FieldSharing>("environmentvariablevalue_PrincipalObjectAttributeAccesses", null); }
			set { SetRelatedEntities("environmentvariablevalue_PrincipalObjectAttributeAccesses", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'environmentvariablevalue_ProcessSession'
        /// </summary>
		[RelationshipSchemaName("environmentvariablevalue_ProcessSession")]
		public IEnumerable<ProcessSession> EnvironmentvariablevalueProcessSession
		{
			get { return GetRelatedEntities<ProcessSession>("environmentvariablevalue_ProcessSession", null); }
			set { SetRelatedEntities("environmentvariablevalue_ProcessSession", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'environmentvariablevalue_SyncErrors'
        /// </summary>
		[RelationshipSchemaName("environmentvariablevalue_SyncErrors")]
		public IEnumerable<SyncError> EnvironmentvariablevalueSyncErrors
		{
			get { return GetRelatedEntities<SyncError>("environmentvariablevalue_SyncErrors", null); }
			set { SetRelatedEntities("environmentvariablevalue_SyncErrors", null, value); }
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

			/// <summary>environmentvariabledefinitionid</summary>
			public const string EnvironmentVariableDefinition = "environmentvariabledefinitionid";

			/// <summary>environmentvariabledefinitionidname</summary>
			public const string Environmentvariabledefinitionidname = "environmentvariabledefinitionidname";

			/// <summary>environmentvariablevalueid</summary>
			public const string EnvironmentVariableValueId = "environmentvariablevalueid";

			/// <summary>environmentvariablevalueidunique</summary>
			public const string EnvironmentvariablevalueiduniqueId = "environmentvariablevalueidunique";

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

			/// <summary>schemaname</summary>
			public const string SchemaName = "schemaname";

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

			/// <summary>utcconversiontimezonecode</summary>
			public const string UTCConversionTimeZoneCode = "utcconversiontimezonecode";

			/// <summary>value</summary>
			public const string Value = "value";

			/// <summary>versionnumber</summary>
			public const string VersionNumber = "versionnumber";

		}
		#endregion

		#region Schemas
		public static class Schemas 
		{
			/// <summary>1:N environmentvariablevalue_AsyncOperations</summary>
			public const string EnvironmentvariablevalueAsyncOperations = "environmentvariablevalue_AsyncOperations";

			/// <summary>1:N environmentvariablevalue_BulkDeleteFailures</summary>
			public const string EnvironmentvariablevalueBulkDeleteFailures = "environmentvariablevalue_BulkDeleteFailures";

			/// <summary>1:N environmentvariablevalue_DuplicateBaseRecord</summary>
			public const string EnvironmentvariablevalueDuplicateBaseRecord = "environmentvariablevalue_DuplicateBaseRecord";

			/// <summary>1:N environmentvariablevalue_DuplicateMatchingRecord</summary>
			public const string EnvironmentvariablevalueDuplicateMatchingRecord = "environmentvariablevalue_DuplicateMatchingRecord";

			/// <summary>1:N environmentvariablevalue_MailboxTrackingFolders</summary>
			public const string EnvironmentvariablevalueMailboxTrackingFolders = "environmentvariablevalue_MailboxTrackingFolders";

			/// <summary>1:N environmentvariablevalue_PrincipalObjectAttributeAccesses</summary>
			public const string EnvironmentvariablevaluePrincipalObjectAttributeAccesses = "environmentvariablevalue_PrincipalObjectAttributeAccesses";

			/// <summary>1:N environmentvariablevalue_ProcessSession</summary>
			public const string EnvironmentvariablevalueProcessSession = "environmentvariablevalue_ProcessSession";

			/// <summary>1:N environmentvariablevalue_SyncErrors</summary>
			public const string EnvironmentvariablevalueSyncErrors = "environmentvariablevalue_SyncErrors";

		}
		#endregion
	}
}

