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
	[EntityLogicalName("provisionlanguageforuser")]
	public sealed class ProvisionLanguageForUser : Entity
	{	
		public static readonly int? EntityTypeCode = 10017;
		public new const string LogicalName = "provisionlanguageforuser";
		public const string PrimaryIdAttribute = "provisionlanguageforuserid";
		public const string PrimaryNameAttribute = "name";
	
		public ProvisionLanguageForUser() : base("provisionlanguageforuser") { }

		#region Attributes
		/// <summary>
        /// asyncoperationid
        /// </summary>
		[DisplayName("AsyncOperationId")]
		[AttributeLogicalName("asyncoperationid")]
		public Guid AsyncOperationId
		{	
			get { return GetAttributeValue<Guid>("asyncoperationid"); }
			set
			{ 
				if(value == AsyncOperationId) return;
				SetAttributeValue("asyncoperationid", value);
			}
		}	
			
		/// <summary>
        /// lcid
        /// </summary>
		[DisplayName("Lcid")]
		[AttributeLogicalName("lcid")]
		public int? Lcid
		{	
			get { return GetAttributeValue<int?>("lcid"); }
			set
			{ 
				if(value == Lcid) return;
				SetAttributeValue("lcid", value);
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
        /// operationstatus
        /// </summary>
		[DisplayName("OperationStatus")]
		[AttributeLogicalName("operationstatus")]
		public eOperationStatus? OperationStatus
		{	
			get 
			{ 
				var optionSetValue = GetAttributeValue<OptionSetValue>("operationstatus");
				if (optionSetValue != null) return (eOperationStatus)optionSetValue.Value;
				else return null;
			}
			set 
			{ 
				if(value == OperationStatus) return;

				OptionSetValue optionSetValue = null;
				if(value != null) optionSetValue = new OptionSetValue((int)value);
				SetAttributeValue("operationstatus", optionSetValue); 
			}
		}

		/// <summary>
        /// organizationid
        /// </summary>
		[DisplayName("Organization Id")]
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
        /// provisionlanguageforuserid
        /// </summary>
		[DisplayName("ProvisionLanguageForUser")]
		[AttributeLogicalName("provisionlanguageforuserid")]
		public override Guid Id
		{
			get => base.Id;
			set { base.Id = value; SetAttributeValue("provisionlanguageforuserid", value); }
		}

							/// <summary>
        /// userid
        /// </summary>
		[DisplayName("UserId")]
		[AttributeLogicalName("userid")]
		public Guid UserId
		{	
			get { return GetAttributeValue<Guid>("userid"); }
			set
			{ 
				if(value == UserId) return;
				SetAttributeValue("userid", value);
			}
		}	
			
		#endregion	

		#region Relations
			/// <summary>
        /// 1:N Get entities for 'provisionlanguageforuser_AsyncOperations'
        /// </summary>
		[RelationshipSchemaName("provisionlanguageforuser_AsyncOperations")]
		public IEnumerable<SystemJob> ProvisionlanguageforuserAsyncOperations
		{
			get { return GetRelatedEntities<SystemJob>("provisionlanguageforuser_AsyncOperations", null); }
			set { SetRelatedEntities("provisionlanguageforuser_AsyncOperations", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'provisionlanguageforuser_BulkDeleteFailures'
        /// </summary>
		[RelationshipSchemaName("provisionlanguageforuser_BulkDeleteFailures")]
		public IEnumerable<BulkDeleteFailure> ProvisionlanguageforuserBulkDeleteFailures
		{
			get { return GetRelatedEntities<BulkDeleteFailure>("provisionlanguageforuser_BulkDeleteFailures", null); }
			set { SetRelatedEntities("provisionlanguageforuser_BulkDeleteFailures", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'provisionlanguageforuser_MailboxTrackingFolders'
        /// </summary>
		[RelationshipSchemaName("provisionlanguageforuser_MailboxTrackingFolders")]
		public IEnumerable<MailboxAutoTrackingFolder> ProvisionlanguageforuserMailboxTrackingFolders
		{
			get { return GetRelatedEntities<MailboxAutoTrackingFolder>("provisionlanguageforuser_MailboxTrackingFolders", null); }
			set { SetRelatedEntities("provisionlanguageforuser_MailboxTrackingFolders", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'provisionlanguageforuser_PrincipalObjectAttributeAccesses'
        /// </summary>
		[RelationshipSchemaName("provisionlanguageforuser_PrincipalObjectAttributeAccesses")]
		public IEnumerable<FieldSharing> ProvisionlanguageforuserPrincipalObjectAttributeAccesses
		{
			get { return GetRelatedEntities<FieldSharing>("provisionlanguageforuser_PrincipalObjectAttributeAccesses", null); }
			set { SetRelatedEntities("provisionlanguageforuser_PrincipalObjectAttributeAccesses", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'provisionlanguageforuser_ProcessSession'
        /// </summary>
		[RelationshipSchemaName("provisionlanguageforuser_ProcessSession")]
		public IEnumerable<ProcessSession> ProvisionlanguageforuserProcessSession
		{
			get { return GetRelatedEntities<ProcessSession>("provisionlanguageforuser_ProcessSession", null); }
			set { SetRelatedEntities("provisionlanguageforuser_ProcessSession", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'provisionlanguageforuser_SyncErrors'
        /// </summary>
		[RelationshipSchemaName("provisionlanguageforuser_SyncErrors")]
		public IEnumerable<SyncError> ProvisionlanguageforuserSyncErrors
		{
			get { return GetRelatedEntities<SyncError>("provisionlanguageforuser_SyncErrors", null); }
			set { SetRelatedEntities("provisionlanguageforuser_SyncErrors", null, value); }
		}
		#endregion

		#region Actions
		#endregion

		#region OptionSetEnums
		public enum eOperationStatus
		{	
		
			[Label("Queued")]
			[Description(@"")]
			Queued = 0, 
		
			[Label("Completed")]
			[Description(@"")]
			Completed = 1, 
		
			[Label("Waiting For Language Provision")]
			[Description(@"")]
			WaitingForLanguageProvision = 2, 
		
			[Label("Failed")]
			[Description(@"")]
			Failed = 3, 
		}
		
		#endregion	

		#region Properties
		public static class Properties 
		{
			/// <summary>asyncoperationid</summary>
			public const string AsyncOperationId = "asyncoperationid";

			/// <summary>lcid</summary>
			public const string Lcid = "lcid";

			/// <summary>name</summary>
			public const string Name = "name";

			/// <summary>operationstatus</summary>
			public const string OperationStatus = "operationstatus";

			/// <summary>organizationid</summary>
			public const string OrganizationId = "organizationid";

			/// <summary>provisionlanguageforuserid</summary>
			public const string ProvisionLanguageForUserId = "provisionlanguageforuserid";

			/// <summary>userid</summary>
			public const string UserId = "userid";

		}
		#endregion

		#region Schemas
		public static class Schemas 
		{
			/// <summary>1:N provisionlanguageforuser_AsyncOperations</summary>
			public const string ProvisionlanguageforuserAsyncOperations = "provisionlanguageforuser_AsyncOperations";

			/// <summary>1:N provisionlanguageforuser_BulkDeleteFailures</summary>
			public const string ProvisionlanguageforuserBulkDeleteFailures = "provisionlanguageforuser_BulkDeleteFailures";

			/// <summary>1:N provisionlanguageforuser_MailboxTrackingFolders</summary>
			public const string ProvisionlanguageforuserMailboxTrackingFolders = "provisionlanguageforuser_MailboxTrackingFolders";

			/// <summary>1:N provisionlanguageforuser_PrincipalObjectAttributeAccesses</summary>
			public const string ProvisionlanguageforuserPrincipalObjectAttributeAccesses = "provisionlanguageforuser_PrincipalObjectAttributeAccesses";

			/// <summary>1:N provisionlanguageforuser_ProcessSession</summary>
			public const string ProvisionlanguageforuserProcessSession = "provisionlanguageforuser_ProcessSession";

			/// <summary>1:N provisionlanguageforuser_SyncErrors</summary>
			public const string ProvisionlanguageforuserSyncErrors = "provisionlanguageforuser_SyncErrors";

		}
		#endregion
	}
}

