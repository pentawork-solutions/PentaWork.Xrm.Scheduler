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
	[EntityLogicalName("bot")]
	public sealed class Chatbot : Entity
	{	
		public static readonly int? EntityTypeCode = 10034;
		public new const string LogicalName = "bot";
		public const string PrimaryIdAttribute = "botid";
		public const string PrimaryNameAttribute = "name";
	
		public Chatbot() : base("bot") { }

		#region Attributes
		/// <summary>
        /// accesscontrolpolicy
        /// </summary>
		[DisplayName("Access Control Policy")]
		[AttributeLogicalName("accesscontrolpolicy")]
		public eAccessControlPolicy? AccessControlPolicy
		{	
			get 
			{ 
				var optionSetValue = GetAttributeValue<OptionSetValue>("accesscontrolpolicy");
				if (optionSetValue != null) return (eAccessControlPolicy)optionSetValue.Value;
				else return null;
			}
			set 
			{ 
				if(value == AccessControlPolicy) return;

				OptionSetValue optionSetValue = null;
				if(value != null) optionSetValue = new OptionSetValue((int)value);
				SetAttributeValue("accesscontrolpolicy", optionSetValue); 
			}
		}

		/// <summary>
        /// applicationmanifestinformation
        /// </summary>
		[DisplayName("Application Manifest Information")]
		[AttributeLogicalName("applicationmanifestinformation")]
		public string ApplicationManifestInformation
		{	
			get { return GetAttributeValue<string>("applicationmanifestinformation"); }
			set
			{ 
				if(value == ApplicationManifestInformation) return;
				SetAttributeValue("applicationmanifestinformation", value);
			}
		}	
			
		/// <summary>
        /// authenticationmode
        /// </summary>
		[DisplayName("Authentication Mode")]
		[AttributeLogicalName("authenticationmode")]
		public eAuthenticationMode? AuthenticationMode
		{	
			get 
			{ 
				var optionSetValue = GetAttributeValue<OptionSetValue>("authenticationmode");
				if (optionSetValue != null) return (eAuthenticationMode)optionSetValue.Value;
				else return null;
			}
			set 
			{ 
				if(value == AuthenticationMode) return;

				OptionSetValue optionSetValue = null;
				if(value != null) optionSetValue = new OptionSetValue((int)value);
				SetAttributeValue("authenticationmode", optionSetValue); 
			}
		}

		/// <summary>
        /// authenticationtrigger
        /// </summary>
		[DisplayName("Authentication trigger")]
		[AttributeLogicalName("authenticationtrigger")]
		public eAuthenticationTrigger? AuthenticationTrigger
		{	
			get 
			{ 
				var optionSetValue = GetAttributeValue<OptionSetValue>("authenticationtrigger");
				if (optionSetValue != null) return (eAuthenticationTrigger)optionSetValue.Value;
				else return null;
			}
			set 
			{ 
				if(value == AuthenticationTrigger) return;

				OptionSetValue optionSetValue = null;
				if(value != null) optionSetValue = new OptionSetValue((int)value);
				SetAttributeValue("authenticationtrigger", optionSetValue); 
			}
		}

		/// <summary>
        /// authorizedsecuritygroupids
        /// </summary>
		[DisplayName("Authorized Security Groups")]
		[AttributeLogicalName("authorizedsecuritygroupids")]
		public string AuthorizedSecurityGroups
		{	
			get { return GetAttributeValue<string>("authorizedsecuritygroupids"); }
			set
			{ 
				if(value == AuthorizedSecurityGroups) return;
				SetAttributeValue("authorizedsecuritygroupids", value);
			}
		}	
			
		/// <summary>
        /// botid
        /// </summary>
		[DisplayName("Bot")]
		[AttributeLogicalName("botid")]
		public override Guid Id
		{
			get => base.Id;
			set { base.Id = value; SetAttributeValue("botid", value); }
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
        /// configuration
        /// </summary>
		[DisplayName("Configuration")]
		[AttributeLogicalName("configuration")]
		public string Configuration
		{	
			get { return GetAttributeValue<string>("configuration"); }
			set
			{ 
				if(value == Configuration) return;
				SetAttributeValue("configuration", value);
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
        /// iconbase64
        /// </summary>
		[DisplayName("Icon (Base64)")]
		[AttributeLogicalName("iconbase64")]
		public string IconBase64
		{	
			get { return GetAttributeValue<string>("iconbase64"); }
			set
			{ 
				if(value == IconBase64) return;
				SetAttributeValue("iconbase64", value);
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
        /// language
        /// </summary>
		[DisplayName("Language")]
		[AttributeLogicalName("language")]
		public eLanguage? Language
		{	
			get 
			{ 
				var optionSetValue = GetAttributeValue<OptionSetValue>("language");
				if (optionSetValue != null) return (eLanguage)optionSetValue.Value;
				else return null;
			}
			set 
			{ 
				if(value == Language) return;

				OptionSetValue optionSetValue = null;
				if(value != null) optionSetValue = new OptionSetValue((int)value);
				SetAttributeValue("language", optionSetValue); 
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
        /// publishedby
        /// </summary>
		[DisplayName("Published By")]
		[AttributeLogicalName("publishedby")]
		public EntityReference PublishedBy
		{	
			get { return GetAttributeValue<EntityReference>("publishedby"); }
			set
			{ 
				if(value == PublishedBy) return;
				SetAttributeValue("publishedby", value);
			}
		}	
			
		/// <summary>
        /// publishedbyname
        /// </summary>
		[DisplayName("publishedbyname")]
		[AttributeLogicalName("publishedbyname")]
		public string Publishedbyname
		{	
			get { return GetAttributeValue<string>("publishedbyname"); }
			set
			{ 
				if(value == Publishedbyname) return;
				SetAttributeValue("publishedbyname", value);
			}
		}	
			
		/// <summary>
        /// publishedbyyominame
        /// </summary>
		[DisplayName("publishedbyyominame")]
		[AttributeLogicalName("publishedbyyominame")]
		public string Publishedbyyominame
		{	
			get { return GetAttributeValue<string>("publishedbyyominame"); }
			set
			{ 
				if(value == Publishedbyyominame) return;
				SetAttributeValue("publishedbyyominame", value);
			}
		}	
			
		/// <summary>
        /// publishedon
        /// </summary>
		[DisplayName("Published On")]
		[AttributeLogicalName("publishedon")]
		public DateTime? PublishedOn
		{	
			get { return GetAttributeValue<DateTime?>("publishedon"); }
			set
			{ 
				if(value == PublishedOn) return;
				SetAttributeValue("publishedon", value);
			}
		}	
			
		/// <summary>
        /// schemaname
        /// </summary>
		[DisplayName("SchemaName")]
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
        /// 1:N Get entities for 'bot_AsyncOperations'
        /// </summary>
		[RelationshipSchemaName("bot_AsyncOperations")]
		public IEnumerable<SystemJob> BotAsyncOperations
		{
			get { return GetRelatedEntities<SystemJob>("bot_AsyncOperations", null); }
			set { SetRelatedEntities("bot_AsyncOperations", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'bot_BulkDeleteFailures'
        /// </summary>
		[RelationshipSchemaName("bot_BulkDeleteFailures")]
		public IEnumerable<BulkDeleteFailure> BotBulkDeleteFailures
		{
			get { return GetRelatedEntities<BulkDeleteFailure>("bot_BulkDeleteFailures", null); }
			set { SetRelatedEntities("bot_BulkDeleteFailures", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'bot_conversationtranscript'
        /// </summary>
		[RelationshipSchemaName("bot_conversationtranscript")]
		public IEnumerable<ConversationTranscript> BotConversationtranscript
		{
			get { return GetRelatedEntities<ConversationTranscript>("bot_conversationtranscript", null); }
			set { SetRelatedEntities("bot_conversationtranscript", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'bot_MailboxTrackingFolders'
        /// </summary>
		[RelationshipSchemaName("bot_MailboxTrackingFolders")]
		public IEnumerable<MailboxAutoTrackingFolder> BotMailboxTrackingFolders
		{
			get { return GetRelatedEntities<MailboxAutoTrackingFolder>("bot_MailboxTrackingFolders", null); }
			set { SetRelatedEntities("bot_MailboxTrackingFolders", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'bot_PrincipalObjectAttributeAccesses'
        /// </summary>
		[RelationshipSchemaName("bot_PrincipalObjectAttributeAccesses")]
		public IEnumerable<FieldSharing> BotPrincipalObjectAttributeAccesses
		{
			get { return GetRelatedEntities<FieldSharing>("bot_PrincipalObjectAttributeAccesses", null); }
			set { SetRelatedEntities("bot_PrincipalObjectAttributeAccesses", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'bot_ProcessSession'
        /// </summary>
		[RelationshipSchemaName("bot_ProcessSession")]
		public IEnumerable<ProcessSession> BotProcessSession
		{
			get { return GetRelatedEntities<ProcessSession>("bot_ProcessSession", null); }
			set { SetRelatedEntities("bot_ProcessSession", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'bot_SyncErrors'
        /// </summary>
		[RelationshipSchemaName("bot_SyncErrors")]
		public IEnumerable<SyncError> BotSyncErrors
		{
			get { return GetRelatedEntities<SyncError>("bot_SyncErrors", null); }
			set { SetRelatedEntities("bot_SyncErrors", null, value); }
		}
		/// <summary>
        /// N:N Get entities for 'ChatbotSubcomponent'
        /// </summary>
		[RelationshipSchemaName("bot_botcomponent")]
		public IEnumerable<ChatbotSubcomponent> BotBotcomponent
		{
			get { return GetRelatedEntities<ChatbotSubcomponent>("bot_botcomponent", null); }
			set { SetRelatedEntities("bot_botcomponent", null, value); }
		}
		#endregion

		#region Actions
		public OrganizationResponse ExecutePvaGetDirectLineEndpoint(OrganizationServiceContext serviceContext)
		{
			var orgRequest = new OrganizationRequest("PvaGetDirectLineEndpoint");
			orgRequest["Target"] = ToEntityReference();
            return serviceContext.Execute(orgRequest);
		}
		public OrganizationResponse ExecutePvaAuthorize(OrganizationServiceContext serviceContext)
		{
			var orgRequest = new OrganizationRequest("PvaAuthorize");
			orgRequest["Target"] = ToEntityReference();
            return serviceContext.Execute(orgRequest);
		}
		public OrganizationResponse ExecutePvaPublish(OrganizationServiceContext serviceContext)
		{
			var orgRequest = new OrganizationRequest("PvaPublish");
			orgRequest["Target"] = ToEntityReference();
            return serviceContext.Execute(orgRequest);
		}
		public OrganizationResponse ExecutePvaDeleteBot(OrganizationServiceContext serviceContext)
		{
			var orgRequest = new OrganizationRequest("PvaDeleteBot");
			orgRequest["Target"] = ToEntityReference();
            return serviceContext.Execute(orgRequest);
		}
		public OrganizationResponse ExecutePvaCreateBotComponents(OrganizationServiceContext serviceContext)
		{
			var orgRequest = new OrganizationRequest("PvaCreateBotComponents");
			orgRequest["Target"] = ToEntityReference();
            return serviceContext.Execute(orgRequest);
		}
		public OrganizationResponse ExecutePvaCreateContentSnapshot(OrganizationServiceContext serviceContext)
		{
			var orgRequest = new OrganizationRequest("PvaCreateContentSnapshot");
			orgRequest["Target"] = ToEntityReference();
            return serviceContext.Execute(orgRequest);
		}
		#endregion

		#region OptionSetEnums
		public enum eAccessControlPolicy
		{	
		
			[Label("Any")]
			[Description(@"Any signed in user is allowed to interact with the bot.")]
			Any = 0, 
		
			[Label("Chatbot readers")]
			[Description(@"Authentication mode must be Integrated or Custom Azure Active Directory. User must have at least Read access to the Chatbot record.")]
			ChatbotReaders = 1, 
		
			[Label("Group membership")]
			[Description(@"Authentication mode must be Integrated or Custom Azure Active Directory. To interact with the bot, users must be member of one of the security groups configured in the Authorized Security Groups field OR have Read access to the Chatbot.")]
			GroupMembership = 2, 
		}
		
		public enum eAuthenticationMode
		{	
		
			[Label("Unspecified")]
			[Description(@"Chatbot was created before the introduction of this field. The mode is either 'None' if no authentication was configured, or 'Generic OAuth2' if the bot had an authentication node.")]
			Unspecified = 0, 
		
			[Label("None")]
			[Description(@"The chatbot does not require authentication.")]
			None = 1, 
		
			[Label("Integrated")]
			[Description(@"Authentication uses integrated Azure AD configuration. Supports security group access control. The bot has access to the UserId and UserDisplayName variables and will be able to invoke Flows on behalf of the end user. No additional configuration required.")]
			Integrated = 2, 
		
			[Label("Custom Azure Active Directory")]
			[Description(@"Provide a custom Azure AD application. Supports security group access control. The bot has access to the IsLoggedIn, AuthToken, UserId and UserDisplayName variables and will be able to invoke Flows on behalf of the user. Skills can leverage the auth token")]
			CustomAzureActiveDirectory = 3, 
		
			[Label("Generic OAuth2")]
			[Description(@"A custom OAuth provider is configured. The chatbot will have access to the IsLoggedIn and AuthToken variables.")]
			GenericOAuth2 = 4, 
		}
		
		public enum eAuthenticationTrigger
		{	
		
			[Label("As Needed")]
			[Description(@"Sign in happens when the bot reaches an authentication node or when an action requires user authentication.")]
			AsNeeded = 0, 
		
			[Label("Always")]
			[Description(@"Sign-in happens when the conversation starts and any time a token expires.")]
			Always = 1, 
		}
		
		public enum eLanguage
		{	
		
			[Label("English")]
			[Description(@"")]
			English = 1033, 
		
			[Label("Spanish")]
			[Description(@"")]
			Spanish = 1034, 
		
			[Label("Portuguese (Brazilian)")]
			[Description(@"")]
			PortugueseBrazilian = 1046, 
		
			[Label("French")]
			[Description(@"")]
			French = 1036, 
		
			[Label("Dutch")]
			[Description(@"")]
			Dutch = 1043, 
		
			[Label("Norwegian")]
			[Description(@"")]
			Norwegian = 1044, 
		
			[Label("Danish")]
			[Description(@"")]
			Danish = 1030, 
		
			[Label("Swedish")]
			[Description(@"")]
			Swedish = 1053, 
		
			[Label("Italian")]
			[Description(@"")]
			Italian = 1040, 
		
			[Label("German")]
			[Description(@"")]
			German = 1031, 
		
			[Label("Chinese (Simplified)")]
			[Description(@"")]
			ChineseSimplified = 2052, 
		
			[Label("Chinese (Traditional)")]
			[Description(@"")]
			ChineseTraditional = 1028, 
		
			[Label("Arabic")]
			[Description(@"")]
			Arabic = 1025, 
		
			[Label("Japanese")]
			[Description(@"")]
			Japanese = 1041, 
		
			[Label("Korean")]
			[Description(@"")]
			Korean = 1042, 
		
			[Label("Hindi")]
			[Description(@"")]
			Hindi = 1081, 
		
			[Label("Indonesian")]
			[Description(@"")]
			Indonesian = 1057, 
		
			[Label("Russian")]
			[Description(@"")]
			Russian = 1049, 
		
			[Label("Polish")]
			[Description(@"")]
			Polish = 1045, 
		
			[Label("Turkish")]
			[Description(@"")]
			Turkish = 1055, 
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
		
			[Label("Provisioned")]
			[Description(@"")]
			Provisioned_Active = 1, 
		
			[Label("Deprovisioned")]
			[Description(@"")]
			Deprovisioned_Inactive = 2, 
		
			[Label("Provisioning")]
			[Description(@"")]
			Provisioning_Inactive = 3, 
		
			[Label("ProvisionFailed")]
			[Description(@"")]
			ProvisionFailed_Inactive = 4, 
		
			[Label("MissingLicense")]
			[Description(@"")]
			MissingLicense_Inactive = 5, 
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
			/// <summary>accesscontrolpolicy</summary>
			public const string AccessControlPolicy = "accesscontrolpolicy";

			/// <summary>applicationmanifestinformation</summary>
			public const string ApplicationManifestInformation = "applicationmanifestinformation";

			/// <summary>authenticationmode</summary>
			public const string AuthenticationMode = "authenticationmode";

			/// <summary>authenticationtrigger</summary>
			public const string AuthenticationTrigger = "authenticationtrigger";

			/// <summary>authorizedsecuritygroupids</summary>
			public const string AuthorizedSecurityGroups = "authorizedsecuritygroupids";

			/// <summary>botid</summary>
			public const string BotId = "botid";

			/// <summary>componentidunique</summary>
			public const string RowIdUniqueId = "componentidunique";

			/// <summary>componentstate</summary>
			public const string ComponentState = "componentstate";

			/// <summary>configuration</summary>
			public const string Configuration = "configuration";

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

			/// <summary>iconbase64</summary>
			public const string IconBase64 = "iconbase64";

			/// <summary>importsequencenumber</summary>
			public const string ImportSequenceNumber = "importsequencenumber";

			/// <summary>ismanaged</summary>
			public const string IsManaged = "ismanaged";

			/// <summary>language</summary>
			public const string Language = "language";

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

			/// <summary>publishedby</summary>
			public const string PublishedBy = "publishedby";

			/// <summary>publishedbyname</summary>
			public const string Publishedbyname = "publishedbyname";

			/// <summary>publishedbyyominame</summary>
			public const string Publishedbyyominame = "publishedbyyominame";

			/// <summary>publishedon</summary>
			public const string PublishedOn = "publishedon";

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

			/// <summary>versionnumber</summary>
			public const string VersionNumber = "versionnumber";

		}
		#endregion

		#region Schemas
		public static class Schemas 
		{
			/// <summary>1:N bot_AsyncOperations</summary>
			public const string BotAsyncOperations = "bot_AsyncOperations";

			/// <summary>1:N bot_BulkDeleteFailures</summary>
			public const string BotBulkDeleteFailures = "bot_BulkDeleteFailures";

			/// <summary>1:N bot_conversationtranscript</summary>
			public const string BotConversationtranscript = "bot_conversationtranscript";

			/// <summary>1:N bot_MailboxTrackingFolders</summary>
			public const string BotMailboxTrackingFolders = "bot_MailboxTrackingFolders";

			/// <summary>1:N bot_PrincipalObjectAttributeAccesses</summary>
			public const string BotPrincipalObjectAttributeAccesses = "bot_PrincipalObjectAttributeAccesses";

			/// <summary>1:N bot_ProcessSession</summary>
			public const string BotProcessSession = "bot_ProcessSession";

			/// <summary>1:N bot_SyncErrors</summary>
			public const string BotSyncErrors = "bot_SyncErrors";

			/// <summary>N:N bot_botcomponent</summary>
			public const string BotBotcomponent = "bot_botcomponent";

		}
		#endregion
	}
}

