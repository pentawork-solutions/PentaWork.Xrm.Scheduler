using System;
using System.Linq;
using System.Diagnostics;
using System.ComponentModel;
using Microsoft.Xrm.Sdk; 
using Microsoft.Xrm.Sdk.Client;
using System.Collections.Generic;

namespace PentaWork.Xrm.Scheduler.Proxies.Entities
{
	[DebuggerDisplay("{CanvasAppName}")] 	
	[EntityLogicalName("canvasapp")]
	public sealed class CanvasApp : Entity
	{	
		public static readonly int? EntityTypeCode = 300;
		public new const string LogicalName = "canvasapp";
		public const string PrimaryIdAttribute = "canvasappid";
		public const string PrimaryNameAttribute = "name";
	
		public CanvasApp() : base("canvasapp") { }

		#region Attributes
		/// <summary>
        /// aadcreatedbyid
        /// </summary>
		[DisplayName("Created By")]
		[AttributeLogicalName("aadcreatedbyid")]
		public string CreatedBy
		{	
			get { return GetAttributeValue<string>("aadcreatedbyid"); }
			set
			{ 
				if(value == CreatedBy) return;
				SetAttributeValue("aadcreatedbyid", value);
			}
		}	
			
		/// <summary>
        /// aadlastmodifiedbyid
        /// </summary>
		[DisplayName("Last Modified By")]
		[AttributeLogicalName("aadlastmodifiedbyid")]
		public string LastModifiedBy
		{	
			get { return GetAttributeValue<string>("aadlastmodifiedbyid"); }
			set
			{ 
				if(value == LastModifiedBy) return;
				SetAttributeValue("aadlastmodifiedbyid", value);
			}
		}	
			
		/// <summary>
        /// aadlastpublishedbyid
        /// </summary>
		[DisplayName("Last Published By")]
		[AttributeLogicalName("aadlastpublishedbyid")]
		public string LastPublishedBy
		{	
			get { return GetAttributeValue<string>("aadlastpublishedbyid"); }
			set
			{ 
				if(value == LastPublishedBy) return;
				SetAttributeValue("aadlastpublishedbyid", value);
			}
		}	
			
		/// <summary>
        /// admincontrolbypassconsent
        /// </summary>
		[DisplayName("Admin Control Bypass Consent")]
		[AttributeLogicalName("admincontrolbypassconsent")]
		public bool? AdminControlBypassConsent
		{	
			get { return GetAttributeValue<bool?>("admincontrolbypassconsent"); }
			set
			{ 
				if(value == AdminControlBypassConsent) return;
				SetAttributeValue("admincontrolbypassconsent", value);
			}
		}	
			
		/// <summary>
        /// appcomponentdependencies
        /// </summary>
		[DisplayName("appcomponentdependencies")]
		[AttributeLogicalName("appcomponentdependencies")]
		public string Appcomponentdependencies
		{	
			get { return GetAttributeValue<string>("appcomponentdependencies"); }
			set
			{ 
				if(value == Appcomponentdependencies) return;
				SetAttributeValue("appcomponentdependencies", value);
			}
		}	
			
		/// <summary>
        /// appcomponents
        /// </summary>
		[DisplayName("appcomponents")]
		[AttributeLogicalName("appcomponents")]
		public string Appcomponents
		{	
			get { return GetAttributeValue<string>("appcomponents"); }
			set
			{ 
				if(value == Appcomponents) return;
				SetAttributeValue("appcomponents", value);
			}
		}	
			
		/// <summary>
        /// appopenuri
        /// </summary>
		[DisplayName("appopenuri")]
		[AttributeLogicalName("appopenuri")]
		public string Appopenuri
		{	
			get { return GetAttributeValue<string>("appopenuri"); }
			set
			{ 
				if(value == Appopenuri) return;
				SetAttributeValue("appopenuri", value);
			}
		}	
			
		/// <summary>
        /// appversion
        /// </summary>
		[DisplayName("appversion")]
		[AttributeLogicalName("appversion")]
		public string Appversion
		{	
			get { return GetAttributeValue<string>("appversion"); }
			set
			{ 
				if(value == Appversion) return;
				SetAttributeValue("appversion", value);
			}
		}	
			
		/// <summary>
        /// assets_name
        /// </summary>
		[DisplayName("assets_name")]
		[AttributeLogicalName("assets_name")]
		public string AssetsName
		{	
			get { return GetAttributeValue<string>("assets_name"); }
			set
			{ 
				if(value == AssetsName) return;
				SetAttributeValue("assets_name", value);
			}
		}	
			
		/// <summary>
        /// authorizationreferences
        /// </summary>
		[DisplayName("authorizationreferences")]
		[AttributeLogicalName("authorizationreferences")]
		public string Authorizationreferences
		{	
			get { return GetAttributeValue<string>("authorizationreferences"); }
			set
			{ 
				if(value == Authorizationreferences) return;
				SetAttributeValue("authorizationreferences", value);
			}
		}	
			
		/// <summary>
        /// backgroundcolor
        /// </summary>
		[DisplayName("backgroundcolor")]
		[AttributeLogicalName("backgroundcolor")]
		public string Backgroundcolor
		{	
			get { return GetAttributeValue<string>("backgroundcolor"); }
			set
			{ 
				if(value == Backgroundcolor) return;
				SetAttributeValue("backgroundcolor", value);
			}
		}	
			
		/// <summary>
        /// backgroundimage_name
        /// </summary>
		[DisplayName("backgroundimage_name")]
		[AttributeLogicalName("backgroundimage_name")]
		public string BackgroundimageName
		{	
			get { return GetAttributeValue<string>("backgroundimage_name"); }
			set
			{ 
				if(value == BackgroundimageName) return;
				SetAttributeValue("backgroundimage_name", value);
			}
		}	
			
		/// <summary>
        /// bypassconsent
        /// </summary>
		[DisplayName("Bypass Consent")]
		[AttributeLogicalName("bypassconsent")]
		public bool? BypassConsent
		{	
			get { return GetAttributeValue<bool?>("bypassconsent"); }
			set
			{ 
				if(value == BypassConsent) return;
				SetAttributeValue("bypassconsent", value);
			}
		}	
			
		/// <summary>
        /// canconsumeapppass
        /// </summary>
		[DisplayName("Can Consume App Pass")]
		[AttributeLogicalName("canconsumeapppass")]
		public bool? CanConsumeAppPass
		{	
			get { return GetAttributeValue<bool?>("canconsumeapppass"); }
			set
			{ 
				if(value == CanConsumeAppPass) return;
				SetAttributeValue("canconsumeapppass", value);
			}
		}	
			
		/// <summary>
        /// canvasappid
        /// </summary>
		[DisplayName("canvasappid")]
		[AttributeLogicalName("canvasappid")]
		public override Guid Id
		{
			get => base.Id;
			set { base.Id = value; SetAttributeValue("canvasappid", value); }
		}

							/// <summary>
        /// canvasapprowid
        /// </summary>
		[DisplayName("canvasapprowid")]
		[AttributeLogicalName("canvasapprowid")]
		public Guid CanvasapprowId
		{	
			get { return GetAttributeValue<Guid>("canvasapprowid"); }
			set
			{ 
				if(value == CanvasapprowId) return;
				SetAttributeValue("canvasapprowid", value);
			}
		}	
			
		/// <summary>
        /// canvasapptype
        /// </summary>
		[DisplayName("Canvas App Type")]
		[AttributeLogicalName("canvasapptype")]
		public eCanvasAppType? CanvasAppType
		{	
			get 
			{ 
				var optionSetValue = GetAttributeValue<OptionSetValue>("canvasapptype");
				if (optionSetValue != null) return (eCanvasAppType)optionSetValue.Value;
				else return null;
			}
			set 
			{ 
				if(value == CanvasAppType) return;

				OptionSetValue optionSetValue = null;
				if(value != null) optionSetValue = new OptionSetValue((int)value);
				SetAttributeValue("canvasapptype", optionSetValue); 
			}
		}

		/// <summary>
        /// cdsdependencies
        /// </summary>
		[DisplayName("cdsdependencies")]
		[AttributeLogicalName("cdsdependencies")]
		public string Cdsdependencies
		{	
			get { return GetAttributeValue<string>("cdsdependencies"); }
			set
			{ 
				if(value == Cdsdependencies) return;
				SetAttributeValue("cdsdependencies", value);
			}
		}	
			
		/// <summary>
        /// commitmessage
        /// </summary>
		[DisplayName("The commit message.")]
		[AttributeLogicalName("commitmessage")]
		public string TheCommitMessage
		{	
			get { return GetAttributeValue<string>("commitmessage"); }
			set
			{ 
				if(value == TheCommitMessage) return;
				SetAttributeValue("commitmessage", value);
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
        /// connectionreferences
        /// </summary>
		[DisplayName("connectionreferences")]
		[AttributeLogicalName("connectionreferences")]
		public string Connectionreferences
		{	
			get { return GetAttributeValue<string>("connectionreferences"); }
			set
			{ 
				if(value == Connectionreferences) return;
				SetAttributeValue("connectionreferences", value);
			}
		}	
			
		/// <summary>
        /// createdbyclientversion
        /// </summary>
		[DisplayName("createdbyclientversion")]
		[AttributeLogicalName("createdbyclientversion")]
		public string Createdbyclientversion
		{	
			get { return GetAttributeValue<string>("createdbyclientversion"); }
			set
			{ 
				if(value == Createdbyclientversion) return;
				SetAttributeValue("createdbyclientversion", value);
			}
		}	
			
		/// <summary>
        /// createdtime
        /// </summary>
		[DisplayName("Created Time")]
		[AttributeLogicalName("createdtime")]
		public DateTime? CreatedTime
		{	
			get { return GetAttributeValue<DateTime?>("createdtime"); }
			set
			{ 
				if(value == CreatedTime) return;
				SetAttributeValue("createdtime", value);
			}
		}	
			
		/// <summary>
        /// databasereferences
        /// </summary>
		[DisplayName("databasereferences")]
		[AttributeLogicalName("databasereferences")]
		public string Databasereferences
		{	
			get { return GetAttributeValue<string>("databasereferences"); }
			set
			{ 
				if(value == Databasereferences) return;
				SetAttributeValue("databasereferences", value);
			}
		}	
			
		/// <summary>
        /// description
        /// </summary>
		[DisplayName("The description.")]
		[AttributeLogicalName("description")]
		public string TheDescription
		{	
			get { return GetAttributeValue<string>("description"); }
			set
			{ 
				if(value == TheDescription) return;
				SetAttributeValue("description", value);
			}
		}	
			
		/// <summary>
        /// displayname
        /// </summary>
		[DisplayName("displayname")]
		[AttributeLogicalName("displayname")]
		public string Displayname
		{	
			get { return GetAttributeValue<string>("displayname"); }
			set
			{ 
				if(value == Displayname) return;
				SetAttributeValue("displayname", value);
			}
		}	
			
		/// <summary>
        /// document_name
        /// </summary>
		[DisplayName("document_name")]
		[AttributeLogicalName("document_name")]
		public string DocumentName
		{	
			get { return GetAttributeValue<string>("document_name"); }
			set
			{ 
				if(value == DocumentName) return;
				SetAttributeValue("document_name", value);
			}
		}	
			
		/// <summary>
        /// embeddedapp
        /// </summary>
		[DisplayName("embeddedapp")]
		[AttributeLogicalName("embeddedapp")]
		public string Embeddedapp
		{	
			get { return GetAttributeValue<string>("embeddedapp"); }
			set
			{ 
				if(value == Embeddedapp) return;
				SetAttributeValue("embeddedapp", value);
			}
		}	
			
		/// <summary>
        /// galleryitemid
        /// </summary>
		[DisplayName("The gallery item identifier")]
		[AttributeLogicalName("galleryitemid")]
		public string TheGalleryItemIdentifier
		{	
			get { return GetAttributeValue<string>("galleryitemid"); }
			set
			{ 
				if(value == TheGalleryItemIdentifier) return;
				SetAttributeValue("galleryitemid", value);
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
        /// iscdsupgraded
        /// </summary>
		[DisplayName("Is CDS Upgraded")]
		[AttributeLogicalName("iscdsupgraded")]
		public bool? IsCDSUpgraded
		{	
			get { return GetAttributeValue<bool?>("iscdsupgraded"); }
			set
			{ 
				if(value == IsCDSUpgraded) return;
				SetAttributeValue("iscdsupgraded", value);
			}
		}	
			
		/// <summary>
        /// isfeaturedapp
        /// </summary>
		[DisplayName("Is Featured App")]
		[AttributeLogicalName("isfeaturedapp")]
		public bool? IsFeaturedApp
		{	
			get { return GetAttributeValue<bool?>("isfeaturedapp"); }
			set
			{ 
				if(value == IsFeaturedApp) return;
				SetAttributeValue("isfeaturedapp", value);
			}
		}	
			
		/// <summary>
        /// isheroapp
        /// </summary>
		[DisplayName("Is Hero App")]
		[AttributeLogicalName("isheroapp")]
		public bool? IsHeroApp
		{	
			get { return GetAttributeValue<bool?>("isheroapp"); }
			set
			{ 
				if(value == IsHeroApp) return;
				SetAttributeValue("isheroapp", value);
			}
		}	
			
		/// <summary>
        /// ishidden
        /// </summary>
		[DisplayName("Is Hidden")]
		[AttributeLogicalName("ishidden")]
		public bool? IsHidden
		{	
			get { return GetAttributeValue<bool?>("ishidden"); }
			set
			{ 
				if(value == IsHidden) return;
				SetAttributeValue("ishidden", value);
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
        /// largeicon_name
        /// </summary>
		[DisplayName("largeicon_name")]
		[AttributeLogicalName("largeicon_name")]
		public string LargeiconName
		{	
			get { return GetAttributeValue<string>("largeicon_name"); }
			set
			{ 
				if(value == LargeiconName) return;
				SetAttributeValue("largeicon_name", value);
			}
		}	
			
		/// <summary>
        /// lastmodifiedtime
        /// </summary>
		[DisplayName("Last Modified Time")]
		[AttributeLogicalName("lastmodifiedtime")]
		public DateTime? LastModifiedTime
		{	
			get { return GetAttributeValue<DateTime?>("lastmodifiedtime"); }
			set
			{ 
				if(value == LastModifiedTime) return;
				SetAttributeValue("lastmodifiedtime", value);
			}
		}	
			
		/// <summary>
        /// lastpublishtime
        /// </summary>
		[DisplayName("Last Publish Time")]
		[AttributeLogicalName("lastpublishtime")]
		public DateTime? LastPublishTime
		{	
			get { return GetAttributeValue<DateTime?>("lastpublishtime"); }
			set
			{ 
				if(value == LastPublishTime) return;
				SetAttributeValue("lastpublishtime", value);
			}
		}	
			
		/// <summary>
        /// mediumicon_name
        /// </summary>
		[DisplayName("mediumicon_name")]
		[AttributeLogicalName("mediumicon_name")]
		public string MediumiconName
		{	
			get { return GetAttributeValue<string>("mediumicon_name"); }
			set
			{ 
				if(value == MediumiconName) return;
				SetAttributeValue("mediumicon_name", value);
			}
		}	
			
		/// <summary>
        /// minclientversion
        /// </summary>
		[DisplayName("minclientversion")]
		[AttributeLogicalName("minclientversion")]
		public string Minclientversion
		{	
			get { return GetAttributeValue<string>("minclientversion"); }
			set
			{ 
				if(value == Minclientversion) return;
				SetAttributeValue("minclientversion", value);
			}
		}	
			
		/// <summary>
        /// name
        /// </summary>
		[DisplayName("CanvasApp Name")]
		[AttributeLogicalName("name")]
		public string CanvasAppName
		{	
			get { return GetAttributeValue<string>("name"); }
			set
			{ 
				if(value == CanvasAppName) return;
				SetAttributeValue("name", value);
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
        /// owningbusinessunitname
        /// </summary>
		[DisplayName("owningbusinessunitname")]
		[AttributeLogicalName("owningbusinessunitname")]
		public string Owningbusinessunitname
		{	
			get { return GetAttributeValue<string>("owningbusinessunitname"); }
			set
			{ 
				if(value == Owningbusinessunitname) return;
				SetAttributeValue("owningbusinessunitname", value);
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
        /// publisher
        /// </summary>
		[DisplayName("publisher")]
		[AttributeLogicalName("publisher")]
		public string Publisher
		{	
			get { return GetAttributeValue<string>("publisher"); }
			set
			{ 
				if(value == Publisher) return;
				SetAttributeValue("publisher", value);
			}
		}	
			
		/// <summary>
        /// smallicon_name
        /// </summary>
		[DisplayName("smallicon_name")]
		[AttributeLogicalName("smallicon_name")]
		public string SmalliconName
		{	
			get { return GetAttributeValue<string>("smallicon_name"); }
			set
			{ 
				if(value == SmalliconName) return;
				SetAttributeValue("smallicon_name", value);
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
        /// status
        /// </summary>
		[DisplayName("Status")]
		[AttributeLogicalName("status")]
		public string Status
		{	
			get { return GetAttributeValue<string>("status"); }
			set
			{ 
				if(value == Status) return;
				SetAttributeValue("status", value);
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
        /// tags
        /// </summary>
		[DisplayName("tags")]
		[AttributeLogicalName("tags")]
		public string Tags
		{	
			get { return GetAttributeValue<string>("tags"); }
			set
			{ 
				if(value == Tags) return;
				SetAttributeValue("tags", value);
			}
		}	
			
		/// <summary>
        /// teamsicon_name
        /// </summary>
		[DisplayName("teamsicon_name")]
		[AttributeLogicalName("teamsicon_name")]
		public string TeamsiconName
		{	
			get { return GetAttributeValue<string>("teamsicon_name"); }
			set
			{ 
				if(value == TeamsiconName) return;
				SetAttributeValue("teamsicon_name", value);
			}
		}	
			
		/// <summary>
        /// versionnumber
        /// </summary>
		[DisplayName("versionnumber")]
		[AttributeLogicalName("versionnumber")]
		public int? Versionnumber
		{	
			get { return GetAttributeValue<int?>("versionnumber"); }
			set
			{ 
				if(value == Versionnumber) return;
				SetAttributeValue("versionnumber", value);
			}
		}	
			
		/// <summary>
        /// wideicon_name
        /// </summary>
		[DisplayName("wideicon_name")]
		[AttributeLogicalName("wideicon_name")]
		public string WideiconName
		{	
			get { return GetAttributeValue<string>("wideicon_name"); }
			set
			{ 
				if(value == WideiconName) return;
				SetAttributeValue("wideicon_name", value);
			}
		}	
			
		#endregion	

		#region Relations
			/// <summary>
        /// 1:N Get entities for 'canvasapp_FileAttachments'
        /// </summary>
		[RelationshipSchemaName("canvasapp_FileAttachments")]
		public IEnumerable<FileAttachment> CanvasappFileAttachments
		{
			get { return GetRelatedEntities<FileAttachment>("canvasapp_FileAttachments", null); }
			set { SetRelatedEntities("canvasapp_FileAttachments", null, value); }
		}
		#endregion

		#region Actions
		#endregion

		#region OptionSetEnums
		public enum eCanvasAppType
		{	
		
			[Label("Classic Canvas App")]
			[Description(@"")]
			ClassicCanvasApp = 0, 
		
			[Label("App Component Library")]
			[Description(@"")]
			AppComponentLibrary = 1, 
		
			[Label("Custom Canvas Page")]
			[Description(@"")]
			CustomCanvasPage = 2, 
		
			[Label("Unified App")]
			[Description(@"")]
			UnifiedApp = 3, 
		}
		
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
		
		#endregion	

		#region Properties
		public static class Properties 
		{
			/// <summary>aadcreatedbyid</summary>
			public const string CreatedBy = "aadcreatedbyid";

			/// <summary>aadlastmodifiedbyid</summary>
			public const string LastModifiedBy = "aadlastmodifiedbyid";

			/// <summary>aadlastpublishedbyid</summary>
			public const string LastPublishedBy = "aadlastpublishedbyid";

			/// <summary>admincontrolbypassconsent</summary>
			public const string AdminControlBypassConsent = "admincontrolbypassconsent";

			/// <summary>appcomponentdependencies</summary>
			public const string Appcomponentdependencies = "appcomponentdependencies";

			/// <summary>appcomponents</summary>
			public const string Appcomponents = "appcomponents";

			/// <summary>appopenuri</summary>
			public const string Appopenuri = "appopenuri";

			/// <summary>appversion</summary>
			public const string Appversion = "appversion";

			/// <summary>assets_name</summary>
			public const string AssetsName = "assets_name";

			/// <summary>authorizationreferences</summary>
			public const string Authorizationreferences = "authorizationreferences";

			/// <summary>backgroundcolor</summary>
			public const string Backgroundcolor = "backgroundcolor";

			/// <summary>backgroundimage_name</summary>
			public const string BackgroundimageName = "backgroundimage_name";

			/// <summary>bypassconsent</summary>
			public const string BypassConsent = "bypassconsent";

			/// <summary>canconsumeapppass</summary>
			public const string CanConsumeAppPass = "canconsumeapppass";

			/// <summary>canvasappid</summary>
			public const string CanvasappId = "canvasappid";

			/// <summary>canvasapprowid</summary>
			public const string CanvasapprowId = "canvasapprowid";

			/// <summary>canvasapptype</summary>
			public const string CanvasAppType = "canvasapptype";

			/// <summary>cdsdependencies</summary>
			public const string Cdsdependencies = "cdsdependencies";

			/// <summary>commitmessage</summary>
			public const string TheCommitMessage = "commitmessage";

			/// <summary>componentstate</summary>
			public const string ComponentState = "componentstate";

			/// <summary>connectionreferences</summary>
			public const string Connectionreferences = "connectionreferences";

			/// <summary>createdbyclientversion</summary>
			public const string Createdbyclientversion = "createdbyclientversion";

			/// <summary>createdtime</summary>
			public const string CreatedTime = "createdtime";

			/// <summary>databasereferences</summary>
			public const string Databasereferences = "databasereferences";

			/// <summary>description</summary>
			public const string TheDescription = "description";

			/// <summary>displayname</summary>
			public const string Displayname = "displayname";

			/// <summary>document_name</summary>
			public const string DocumentName = "document_name";

			/// <summary>embeddedapp</summary>
			public const string Embeddedapp = "embeddedapp";

			/// <summary>galleryitemid</summary>
			public const string TheGalleryItemIdentifier = "galleryitemid";

			/// <summary>introducedversion</summary>
			public const string IntroducedVersion = "introducedversion";

			/// <summary>iscdsupgraded</summary>
			public const string IsCDSUpgraded = "iscdsupgraded";

			/// <summary>isfeaturedapp</summary>
			public const string IsFeaturedApp = "isfeaturedapp";

			/// <summary>isheroapp</summary>
			public const string IsHeroApp = "isheroapp";

			/// <summary>ishidden</summary>
			public const string IsHidden = "ishidden";

			/// <summary>ismanaged</summary>
			public const string IsManaged = "ismanaged";

			/// <summary>largeicon_name</summary>
			public const string LargeiconName = "largeicon_name";

			/// <summary>lastmodifiedtime</summary>
			public const string LastModifiedTime = "lastmodifiedtime";

			/// <summary>lastpublishtime</summary>
			public const string LastPublishTime = "lastpublishtime";

			/// <summary>mediumicon_name</summary>
			public const string MediumiconName = "mediumicon_name";

			/// <summary>minclientversion</summary>
			public const string Minclientversion = "minclientversion";

			/// <summary>name</summary>
			public const string CanvasAppName = "name";

			/// <summary>overwritetime</summary>
			public const string RecordOverwriteTime = "overwritetime";

			/// <summary>ownerid</summary>
			public const string Owner = "ownerid";

			/// <summary>owneridname</summary>
			public const string Owneridname = "owneridname";

			/// <summary>owneridtype</summary>
			public const string Owneridtype = "owneridtype";

			/// <summary>owningbusinessunit</summary>
			public const string OwningBusinessUnit = "owningbusinessunit";

			/// <summary>owningbusinessunitname</summary>
			public const string Owningbusinessunitname = "owningbusinessunitname";

			/// <summary>owningteam</summary>
			public const string OwningTeam = "owningteam";

			/// <summary>owninguser</summary>
			public const string OwningUser = "owninguser";

			/// <summary>publisher</summary>
			public const string Publisher = "publisher";

			/// <summary>smallicon_name</summary>
			public const string SmalliconName = "smallicon_name";

			/// <summary>solutionid</summary>
			public const string SolutionId = "solutionid";

			/// <summary>status</summary>
			public const string Status = "status";

			/// <summary>supportingsolutionid</summary>
			public const string SolutionId2 = "supportingsolutionid";

			/// <summary>tags</summary>
			public const string Tags = "tags";

			/// <summary>teamsicon_name</summary>
			public const string TeamsiconName = "teamsicon_name";

			/// <summary>versionnumber</summary>
			public const string Versionnumber = "versionnumber";

			/// <summary>wideicon_name</summary>
			public const string WideiconName = "wideicon_name";

		}
		#endregion

		#region Schemas
		public static class Schemas 
		{
			/// <summary>1:N canvasapp_FileAttachments</summary>
			public const string CanvasappFileAttachments = "canvasapp_FileAttachments";

		}
		#endregion
	}
}

