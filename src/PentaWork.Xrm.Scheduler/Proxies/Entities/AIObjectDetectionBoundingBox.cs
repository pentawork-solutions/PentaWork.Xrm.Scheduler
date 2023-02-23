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
	[EntityLogicalName("msdyn_aiodtrainingboundingbox")]
	public sealed class AIObjectDetectionBoundingBox : Entity
	{	
		public static readonly int? EntityTypeCode = 10063;
		public new const string LogicalName = "msdyn_aiodtrainingboundingbox";
		public const string PrimaryIdAttribute = "msdyn_aiodtrainingboundingboxid";
		public const string PrimaryNameAttribute = "msdyn_name";
	
		public AIObjectDetectionBoundingBox() : base("msdyn_aiodtrainingboundingbox") { }

		#region Attributes
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
        /// msdyn_aiodlabelid
        /// </summary>
		[DisplayName("Label")]
		[AttributeLogicalName("msdyn_aiodlabelid")]
		public EntityReference Label
		{	
			get { return GetAttributeValue<EntityReference>("msdyn_aiodlabelid"); }
			set
			{ 
				if(value == Label) return;
				SetAttributeValue("msdyn_aiodlabelid", value);
			}
		}	
			
		/// <summary>
        /// msdyn_aiodlabelidname
        /// </summary>
		[DisplayName("msdyn_aiodlabelidname")]
		[AttributeLogicalName("msdyn_aiodlabelidname")]
		public string MsdynAiodlabelidname
		{	
			get { return GetAttributeValue<string>("msdyn_aiodlabelidname"); }
			set
			{ 
				if(value == MsdynAiodlabelidname) return;
				SetAttributeValue("msdyn_aiodlabelidname", value);
			}
		}	
			
		/// <summary>
        /// msdyn_aiodtrainingboundingboxid
        /// </summary>
		[DisplayName("TrainingBoundingBox")]
		[AttributeLogicalName("msdyn_aiodtrainingboundingboxid")]
		public override Guid Id
		{
			get => base.Id;
			set { base.Id = value; SetAttributeValue("msdyn_aiodtrainingboundingboxid", value); }
		}

							/// <summary>
        /// msdyn_aiodtrainingimageid
        /// </summary>
		[DisplayName("Training Image")]
		[AttributeLogicalName("msdyn_aiodtrainingimageid")]
		public EntityReference TrainingImage
		{	
			get { return GetAttributeValue<EntityReference>("msdyn_aiodtrainingimageid"); }
			set
			{ 
				if(value == TrainingImage) return;
				SetAttributeValue("msdyn_aiodtrainingimageid", value);
			}
		}	
			
		/// <summary>
        /// msdyn_aiodtrainingimageidname
        /// </summary>
		[DisplayName("msdyn_aiodtrainingimageidname")]
		[AttributeLogicalName("msdyn_aiodtrainingimageidname")]
		public string MsdynAiodtrainingimageidname
		{	
			get { return GetAttributeValue<string>("msdyn_aiodtrainingimageidname"); }
			set
			{ 
				if(value == MsdynAiodtrainingimageidname) return;
				SetAttributeValue("msdyn_aiodtrainingimageidname", value);
			}
		}	
			
		/// <summary>
        /// msdyn_height
		///
		/// Precision: 4
		/// MaxValue: 1
		/// MinValue: 0
        /// </summary>
		[DisplayName("Height")]
		[AttributeLogicalName("msdyn_height")]
		public double? Height
		{	
			get { return GetAttributeValue<double?>("msdyn_height"); }
			set 
			{
				double? doubleValue = null;
				if(value != null) doubleValue = Math.Round(value.Value, 4);
				if(doubleValue == Height) return;
				SetAttributeValue("msdyn_height", doubleValue);  
			}
		}

		/// <summary>
        /// msdyn_left
		///
		/// Precision: 4
		/// MaxValue: 1
		/// MinValue: 0
        /// </summary>
		[DisplayName("Left")]
		[AttributeLogicalName("msdyn_left")]
		public double? Left
		{	
			get { return GetAttributeValue<double?>("msdyn_left"); }
			set 
			{
				double? doubleValue = null;
				if(value != null) doubleValue = Math.Round(value.Value, 4);
				if(doubleValue == Left) return;
				SetAttributeValue("msdyn_left", doubleValue);  
			}
		}

		/// <summary>
        /// msdyn_name
        /// </summary>
		[DisplayName("Name")]
		[AttributeLogicalName("msdyn_name")]
		public string Name
		{	
			get { return GetAttributeValue<string>("msdyn_name"); }
			set
			{ 
				if(value == Name) return;
				SetAttributeValue("msdyn_name", value);
			}
		}	
			
		/// <summary>
        /// msdyn_top
		///
		/// Precision: 4
		/// MaxValue: 1
		/// MinValue: 0
        /// </summary>
		[DisplayName("Top")]
		[AttributeLogicalName("msdyn_top")]
		public double? Top
		{	
			get { return GetAttributeValue<double?>("msdyn_top"); }
			set 
			{
				double? doubleValue = null;
				if(value != null) doubleValue = Math.Round(value.Value, 4);
				if(doubleValue == Top) return;
				SetAttributeValue("msdyn_top", doubleValue);  
			}
		}

		/// <summary>
        /// msdyn_width
		///
		/// Precision: 4
		/// MaxValue: 1
		/// MinValue: 0
        /// </summary>
		[DisplayName("Width")]
		[AttributeLogicalName("msdyn_width")]
		public double? Width
		{	
			get { return GetAttributeValue<double?>("msdyn_width"); }
			set 
			{
				double? doubleValue = null;
				if(value != null) doubleValue = Math.Round(value.Value, 4);
				if(doubleValue == Width) return;
				SetAttributeValue("msdyn_width", doubleValue);  
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
        /// 1:N Get entities for 'msdyn_aiodtrainingboundingbox_AsyncOperations'
        /// </summary>
		[RelationshipSchemaName("msdyn_aiodtrainingboundingbox_AsyncOperations")]
		public IEnumerable<SystemJob> MsdynAiodtrainingboundingboxAsyncOperations
		{
			get { return GetRelatedEntities<SystemJob>("msdyn_aiodtrainingboundingbox_AsyncOperations", null); }
			set { SetRelatedEntities("msdyn_aiodtrainingboundingbox_AsyncOperations", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'msdyn_aiodtrainingboundingbox_BulkDeleteFailures'
        /// </summary>
		[RelationshipSchemaName("msdyn_aiodtrainingboundingbox_BulkDeleteFailures")]
		public IEnumerable<BulkDeleteFailure> MsdynAiodtrainingboundingboxBulkDeleteFailures
		{
			get { return GetRelatedEntities<BulkDeleteFailure>("msdyn_aiodtrainingboundingbox_BulkDeleteFailures", null); }
			set { SetRelatedEntities("msdyn_aiodtrainingboundingbox_BulkDeleteFailures", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'msdyn_aiodtrainingboundingbox_DuplicateBaseRecord'
        /// </summary>
		[RelationshipSchemaName("msdyn_aiodtrainingboundingbox_DuplicateBaseRecord")]
		public IEnumerable<DuplicateRecord> MsdynAiodtrainingboundingboxDuplicateBaseRecord
		{
			get { return GetRelatedEntities<DuplicateRecord>("msdyn_aiodtrainingboundingbox_DuplicateBaseRecord", null); }
			set { SetRelatedEntities("msdyn_aiodtrainingboundingbox_DuplicateBaseRecord", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'msdyn_aiodtrainingboundingbox_DuplicateMatchingRecord'
        /// </summary>
		[RelationshipSchemaName("msdyn_aiodtrainingboundingbox_DuplicateMatchingRecord")]
		public IEnumerable<DuplicateRecord> MsdynAiodtrainingboundingboxDuplicateMatchingRecord
		{
			get { return GetRelatedEntities<DuplicateRecord>("msdyn_aiodtrainingboundingbox_DuplicateMatchingRecord", null); }
			set { SetRelatedEntities("msdyn_aiodtrainingboundingbox_DuplicateMatchingRecord", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'msdyn_aiodtrainingboundingbox_MailboxTrackingFolders'
        /// </summary>
		[RelationshipSchemaName("msdyn_aiodtrainingboundingbox_MailboxTrackingFolders")]
		public IEnumerable<MailboxAutoTrackingFolder> MsdynAiodtrainingboundingboxMailboxTrackingFolders
		{
			get { return GetRelatedEntities<MailboxAutoTrackingFolder>("msdyn_aiodtrainingboundingbox_MailboxTrackingFolders", null); }
			set { SetRelatedEntities("msdyn_aiodtrainingboundingbox_MailboxTrackingFolders", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'msdyn_aiodtrainingboundingbox_PrincipalObjectAttributeAccesses'
        /// </summary>
		[RelationshipSchemaName("msdyn_aiodtrainingboundingbox_PrincipalObjectAttributeAccesses")]
		public IEnumerable<FieldSharing> MsdynAiodtrainingboundingboxPrincipalObjectAttributeAccesses
		{
			get { return GetRelatedEntities<FieldSharing>("msdyn_aiodtrainingboundingbox_PrincipalObjectAttributeAccesses", null); }
			set { SetRelatedEntities("msdyn_aiodtrainingboundingbox_PrincipalObjectAttributeAccesses", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'msdyn_aiodtrainingboundingbox_ProcessSession'
        /// </summary>
		[RelationshipSchemaName("msdyn_aiodtrainingboundingbox_ProcessSession")]
		public IEnumerable<ProcessSession> MsdynAiodtrainingboundingboxProcessSession
		{
			get { return GetRelatedEntities<ProcessSession>("msdyn_aiodtrainingboundingbox_ProcessSession", null); }
			set { SetRelatedEntities("msdyn_aiodtrainingboundingbox_ProcessSession", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'msdyn_aiodtrainingboundingbox_SyncErrors'
        /// </summary>
		[RelationshipSchemaName("msdyn_aiodtrainingboundingbox_SyncErrors")]
		public IEnumerable<SyncError> MsdynAiodtrainingboundingboxSyncErrors
		{
			get { return GetRelatedEntities<SyncError>("msdyn_aiodtrainingboundingbox_SyncErrors", null); }
			set { SetRelatedEntities("msdyn_aiodtrainingboundingbox_SyncErrors", null, value); }
		}
		#endregion

		#region Actions
		#endregion

		#region OptionSetEnums
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

			/// <summary>msdyn_aiodlabelid</summary>
			public const string Label = "msdyn_aiodlabelid";

			/// <summary>msdyn_aiodlabelidname</summary>
			public const string MsdynAiodlabelidname = "msdyn_aiodlabelidname";

			/// <summary>msdyn_aiodtrainingboundingboxid</summary>
			public const string TrainingBoundingBoxId = "msdyn_aiodtrainingboundingboxid";

			/// <summary>msdyn_aiodtrainingimageid</summary>
			public const string TrainingImage = "msdyn_aiodtrainingimageid";

			/// <summary>msdyn_aiodtrainingimageidname</summary>
			public const string MsdynAiodtrainingimageidname = "msdyn_aiodtrainingimageidname";

			/// <summary>msdyn_height</summary>
			public const string Height = "msdyn_height";

			/// <summary>msdyn_left</summary>
			public const string Left = "msdyn_left";

			/// <summary>msdyn_name</summary>
			public const string Name = "msdyn_name";

			/// <summary>msdyn_top</summary>
			public const string Top = "msdyn_top";

			/// <summary>msdyn_width</summary>
			public const string Width = "msdyn_width";

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

			/// <summary>statecode</summary>
			public const string Status = "statecode";

			/// <summary>statuscode</summary>
			public const string StatusReason = "statuscode";

			/// <summary>timezoneruleversionnumber</summary>
			public const string TimeZoneRuleVersionNumber = "timezoneruleversionnumber";

			/// <summary>utcconversiontimezonecode</summary>
			public const string UTCConversionTimeZoneCode = "utcconversiontimezonecode";

			/// <summary>versionnumber</summary>
			public const string VersionNumber = "versionnumber";

		}
		#endregion

		#region Schemas
		public static class Schemas 
		{
			/// <summary>1:N msdyn_aiodtrainingboundingbox_AsyncOperations</summary>
			public const string MsdynAiodtrainingboundingboxAsyncOperations = "msdyn_aiodtrainingboundingbox_AsyncOperations";

			/// <summary>1:N msdyn_aiodtrainingboundingbox_BulkDeleteFailures</summary>
			public const string MsdynAiodtrainingboundingboxBulkDeleteFailures = "msdyn_aiodtrainingboundingbox_BulkDeleteFailures";

			/// <summary>1:N msdyn_aiodtrainingboundingbox_DuplicateBaseRecord</summary>
			public const string MsdynAiodtrainingboundingboxDuplicateBaseRecord = "msdyn_aiodtrainingboundingbox_DuplicateBaseRecord";

			/// <summary>1:N msdyn_aiodtrainingboundingbox_DuplicateMatchingRecord</summary>
			public const string MsdynAiodtrainingboundingboxDuplicateMatchingRecord = "msdyn_aiodtrainingboundingbox_DuplicateMatchingRecord";

			/// <summary>1:N msdyn_aiodtrainingboundingbox_MailboxTrackingFolders</summary>
			public const string MsdynAiodtrainingboundingboxMailboxTrackingFolders = "msdyn_aiodtrainingboundingbox_MailboxTrackingFolders";

			/// <summary>1:N msdyn_aiodtrainingboundingbox_PrincipalObjectAttributeAccesses</summary>
			public const string MsdynAiodtrainingboundingboxPrincipalObjectAttributeAccesses = "msdyn_aiodtrainingboundingbox_PrincipalObjectAttributeAccesses";

			/// <summary>1:N msdyn_aiodtrainingboundingbox_ProcessSession</summary>
			public const string MsdynAiodtrainingboundingboxProcessSession = "msdyn_aiodtrainingboundingbox_ProcessSession";

			/// <summary>1:N msdyn_aiodtrainingboundingbox_SyncErrors</summary>
			public const string MsdynAiodtrainingboundingboxSyncErrors = "msdyn_aiodtrainingboundingbox_SyncErrors";

		}
		#endregion
	}
}

