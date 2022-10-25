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
	[EntityLogicalName("resource")]
	public sealed class Resource : Entity
	{	
		public static readonly int? EntityTypeCode = 4002;
		public new const string LogicalName = "resource";
		public const string PrimaryIdAttribute = "resourceid";
		public const string PrimaryNameAttribute = "name";
	
		public Resource() : base("resource") { }

		#region Attributes
		/// <summary>
        /// businessunitid
        /// </summary>
		[DisplayName("Business Unit Id")]
		[AttributeLogicalName("businessunitid")]
		public EntityReference BusinessUnitId
		{	
			get { return GetAttributeValue<EntityReference>("businessunitid"); }
			set
			{ 
				if(value == BusinessUnitId) return;
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
        /// calendarid
        /// </summary>
		[DisplayName("Calendar")]
		[AttributeLogicalName("calendarid")]
		public Guid CalendarId
		{	
			get { return GetAttributeValue<Guid>("calendarid"); }
			set
			{ 
				if(value == CalendarId) return;
				SetAttributeValue("calendarid", value);
			}
		}	
			
		/// <summary>
        /// displayinserviceviews
        /// </summary>
		[DisplayName("Display in Service Views")]
		[AttributeLogicalName("displayinserviceviews")]
		public bool? DisplayInServiceViews
		{	
			get { return GetAttributeValue<bool?>("displayinserviceviews"); }
			set
			{ 
				if(value == DisplayInServiceViews) return;
				SetAttributeValue("displayinserviceviews", value);
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
		[DisplayName("entityimageid")]
		[AttributeLogicalName("entityimageid")]
		public Guid EntityimageId
		{	
			get { return GetAttributeValue<Guid>("entityimageid"); }
			set
			{ 
				if(value == EntityimageId) return;
				SetAttributeValue("entityimageid", value);
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
        /// isdisabled
        /// </summary>
		[DisplayName("Is Disabled")]
		[AttributeLogicalName("isdisabled")]
		public bool? IsDisabled
		{	
			get { return GetAttributeValue<bool?>("isdisabled"); }
			set
			{ 
				if(value == IsDisabled) return;
				SetAttributeValue("isdisabled", value);
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
        /// objecttypecode
        /// </summary>
		[DisplayName("Object Type")]
		[AttributeLogicalName("objecttypecode")]
		public string ObjectType
		{	
			get { return GetAttributeValue<string>("objecttypecode"); }
			set
			{ 
				if(value == ObjectType) return;
				SetAttributeValue("objecttypecode", value);
			}
		}	
			
		/// <summary>
        /// organizationid
        /// </summary>
		[DisplayName("Organization")]
		[AttributeLogicalName("organizationid")]
		public EntityReference Organization
		{	
			get { return GetAttributeValue<EntityReference>("organizationid"); }
			set
			{ 
				if(value == Organization) return;
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
        /// resourceid
        /// </summary>
		[DisplayName("Resource")]
		[AttributeLogicalName("resourceid")]
		public override Guid Id
		{
			get => base.Id;
			set { base.Id = value; SetAttributeValue("resourceid", value); }
		}

							/// <summary>
        /// siteid
        /// </summary>
		[DisplayName("Site")]
		[AttributeLogicalName("siteid")]
		public EntityReference Site
		{	
			get { return GetAttributeValue<EntityReference>("siteid"); }
			set
			{ 
				if(value == Site) return;
				SetAttributeValue("siteid", value);
			}
		}	
			
		/// <summary>
        /// siteidname
        /// </summary>
		[DisplayName("siteidname")]
		[AttributeLogicalName("siteidname")]
		public string Siteidname
		{	
			get { return GetAttributeValue<string>("siteidname"); }
			set
			{ 
				if(value == Siteidname) return;
				SetAttributeValue("siteidname", value);
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
        /// 1:N Get entities for 'Resource_AsyncOperations'
        /// </summary>
		[RelationshipSchemaName("Resource_AsyncOperations")]
		public IEnumerable<SystemJob> ResourceAsyncOperations
		{
			get { return GetRelatedEntities<SystemJob>("Resource_AsyncOperations", null); }
			set { SetRelatedEntities("Resource_AsyncOperations", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'Resource_BulkDeleteFailures'
        /// </summary>
		[RelationshipSchemaName("Resource_BulkDeleteFailures")]
		public IEnumerable<BulkDeleteFailure> ResourceBulkDeleteFailures
		{
			get { return GetRelatedEntities<BulkDeleteFailure>("Resource_BulkDeleteFailures", null); }
			set { SetRelatedEntities("Resource_BulkDeleteFailures", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'resource_MailboxTrackingFolders'
        /// </summary>
		[RelationshipSchemaName("resource_MailboxTrackingFolders")]
		public IEnumerable<MailboxAutoTrackingFolder> ResourceMailboxTrackingFolders
		{
			get { return GetRelatedEntities<MailboxAutoTrackingFolder>("resource_MailboxTrackingFolders", null); }
			set { SetRelatedEntities("resource_MailboxTrackingFolders", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'resource_PrincipalObjectAttributeAccesses'
        /// </summary>
		[RelationshipSchemaName("resource_PrincipalObjectAttributeAccesses")]
		public IEnumerable<FieldSharing> ResourcePrincipalObjectAttributeAccesses
		{
			get { return GetRelatedEntities<FieldSharing>("resource_PrincipalObjectAttributeAccesses", null); }
			set { SetRelatedEntities("resource_PrincipalObjectAttributeAccesses", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'Resource_SyncErrors'
        /// </summary>
		[RelationshipSchemaName("Resource_SyncErrors")]
		public IEnumerable<SyncError> ResourceSyncErrors
		{
			get { return GetRelatedEntities<SyncError>("Resource_SyncErrors", null); }
			set { SetRelatedEntities("Resource_SyncErrors", null, value); }
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
			public const string BusinessUnitId = "businessunitid";

			/// <summary>businessunitidname</summary>
			public const string Businessunitidname = "businessunitidname";

			/// <summary>calendarid</summary>
			public const string CalendarId = "calendarid";

			/// <summary>displayinserviceviews</summary>
			public const string DisplayInServiceViews = "displayinserviceviews";

			/// <summary>entityimage_timestamp</summary>
			public const string EntityimageTimestamp = "entityimage_timestamp";

			/// <summary>entityimage_url</summary>
			public const string EntityimageUrl = "entityimage_url";

			/// <summary>entityimageid</summary>
			public const string EntityimageId = "entityimageid";

			/// <summary>importsequencenumber</summary>
			public const string ImportSequenceNumber = "importsequencenumber";

			/// <summary>isdisabled</summary>
			public const string IsDisabled = "isdisabled";

			/// <summary>name</summary>
			public const string Name = "name";

			/// <summary>objecttypecode</summary>
			public const string ObjectType = "objecttypecode";

			/// <summary>organizationid</summary>
			public const string Organization = "organizationid";

			/// <summary>organizationidname</summary>
			public const string Organizationidname = "organizationidname";

			/// <summary>overriddencreatedon</summary>
			public const string RecordCreatedOn = "overriddencreatedon";

			/// <summary>resourceid</summary>
			public const string ResourceId = "resourceid";

			/// <summary>siteid</summary>
			public const string Site = "siteid";

			/// <summary>siteidname</summary>
			public const string Siteidname = "siteidname";

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
			/// <summary>1:N Resource_AsyncOperations</summary>
			public const string ResourceAsyncOperations = "Resource_AsyncOperations";

			/// <summary>1:N Resource_BulkDeleteFailures</summary>
			public const string ResourceBulkDeleteFailures = "Resource_BulkDeleteFailures";

			/// <summary>1:N resource_MailboxTrackingFolders</summary>
			public const string ResourceMailboxTrackingFolders = "resource_MailboxTrackingFolders";

			/// <summary>1:N resource_PrincipalObjectAttributeAccesses</summary>
			public const string ResourcePrincipalObjectAttributeAccesses = "resource_PrincipalObjectAttributeAccesses";

			/// <summary>1:N Resource_SyncErrors</summary>
			public const string ResourceSyncErrors = "Resource_SyncErrors";

		}
		#endregion
	}
}

