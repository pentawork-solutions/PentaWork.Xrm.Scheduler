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
	[EntityLogicalName("botcomponent")]
	public sealed class ChatbotSubcomponent : Entity
	{	
		public static readonly int? EntityTypeCode = 10035;
		public new const string LogicalName = "botcomponent";
		public const string PrimaryIdAttribute = "botcomponentid";
		public const string PrimaryNameAttribute = "name";
	
		public ChatbotSubcomponent() : base("botcomponent") { }

		#region Attributes
		/// <summary>
        /// botcomponentid
        /// </summary>
		[DisplayName("BotComponent")]
		[AttributeLogicalName("botcomponentid")]
		public override Guid Id
		{
			get => base.Id;
			set { base.Id = value; SetAttributeValue("botcomponentid", value); }
		}

							/// <summary>
        /// category
        /// </summary>
		[DisplayName("Category")]
		[AttributeLogicalName("category")]
		public string Category
		{	
			get { return GetAttributeValue<string>("category"); }
			set
			{ 
				if(value == Category) return;
				SetAttributeValue("category", value);
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
        /// componenttype
        /// </summary>
		[DisplayName("ComponentType")]
		[AttributeLogicalName("componenttype")]
		public eComponentType? ComponentType
		{	
			get 
			{ 
				var optionSetValue = GetAttributeValue<OptionSetValue>("componenttype");
				if (optionSetValue != null) return (eComponentType)optionSetValue.Value;
				else return null;
			}
			set 
			{ 
				if(value == ComponentType) return;

				OptionSetValue optionSetValue = null;
				if(value != null) optionSetValue = new OptionSetValue((int)value);
				SetAttributeValue("componenttype", optionSetValue); 
			}
		}

		/// <summary>
        /// content
        /// </summary>
		[DisplayName("Content")]
		[AttributeLogicalName("content")]
		public string Content
		{	
			get { return GetAttributeValue<string>("content"); }
			set
			{ 
				if(value == Content) return;
				SetAttributeValue("content", value);
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
        /// data
        /// </summary>
		[DisplayName("Obi Data")]
		[AttributeLogicalName("data")]
		public string ObiData
		{	
			get { return GetAttributeValue<string>("data"); }
			set
			{ 
				if(value == ObiData) return;
				SetAttributeValue("data", value);
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
		public egChatbotLanguage? Language
		{	
			get 
			{ 
				var optionSetValue = GetAttributeValue<OptionSetValue>("language");
				if (optionSetValue != null) return (egChatbotLanguage)optionSetValue.Value;
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
        /// parentbotcomponentid
        /// </summary>
		[DisplayName("Parent chatbot subcomponent")]
		[AttributeLogicalName("parentbotcomponentid")]
		public EntityReference ParentChatbotSubcomponent
		{	
			get { return GetAttributeValue<EntityReference>("parentbotcomponentid"); }
			set
			{ 
				if(value == ParentChatbotSubcomponent) return;
				SetAttributeValue("parentbotcomponentid", value);
			}
		}	
			
		/// <summary>
        /// parentbotcomponentidname
        /// </summary>
		[DisplayName("parentbotcomponentidname")]
		[AttributeLogicalName("parentbotcomponentidname")]
		public string Parentbotcomponentidname
		{	
			get { return GetAttributeValue<string>("parentbotcomponentidname"); }
			set
			{ 
				if(value == Parentbotcomponentidname) return;
				SetAttributeValue("parentbotcomponentidname", value);
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
        /// 1:N Get entities for 'botcomponent_AsyncOperations'
        /// </summary>
		[RelationshipSchemaName("botcomponent_AsyncOperations")]
		public IEnumerable<SystemJob> BotcomponentAsyncOperations
		{
			get { return GetRelatedEntities<SystemJob>("botcomponent_AsyncOperations", null); }
			set { SetRelatedEntities("botcomponent_AsyncOperations", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'botcomponent_BulkDeleteFailures'
        /// </summary>
		[RelationshipSchemaName("botcomponent_BulkDeleteFailures")]
		public IEnumerable<BulkDeleteFailure> BotcomponentBulkDeleteFailures
		{
			get { return GetRelatedEntities<BulkDeleteFailure>("botcomponent_BulkDeleteFailures", null); }
			set { SetRelatedEntities("botcomponent_BulkDeleteFailures", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'botcomponent_MailboxTrackingFolders'
        /// </summary>
		[RelationshipSchemaName("botcomponent_MailboxTrackingFolders")]
		public IEnumerable<MailboxAutoTrackingFolder> BotcomponentMailboxTrackingFolders
		{
			get { return GetRelatedEntities<MailboxAutoTrackingFolder>("botcomponent_MailboxTrackingFolders", null); }
			set { SetRelatedEntities("botcomponent_MailboxTrackingFolders", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'botcomponent_parent_botcomponent'
        /// </summary>
		[RelationshipSchemaName("botcomponent_parent_botcomponent")]
		public IEnumerable<ChatbotSubcomponent> BotcomponentParentBotcomponent
		{
			get { return GetRelatedEntities<ChatbotSubcomponent>("botcomponent_parent_botcomponent", null); }
			set { SetRelatedEntities("botcomponent_parent_botcomponent", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'botcomponent_PrincipalObjectAttributeAccesses'
        /// </summary>
		[RelationshipSchemaName("botcomponent_PrincipalObjectAttributeAccesses")]
		public IEnumerable<FieldSharing> BotcomponentPrincipalObjectAttributeAccesses
		{
			get { return GetRelatedEntities<FieldSharing>("botcomponent_PrincipalObjectAttributeAccesses", null); }
			set { SetRelatedEntities("botcomponent_PrincipalObjectAttributeAccesses", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'botcomponent_ProcessSession'
        /// </summary>
		[RelationshipSchemaName("botcomponent_ProcessSession")]
		public IEnumerable<ProcessSession> BotcomponentProcessSession
		{
			get { return GetRelatedEntities<ProcessSession>("botcomponent_ProcessSession", null); }
			set { SetRelatedEntities("botcomponent_ProcessSession", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'botcomponent_SyncErrors'
        /// </summary>
		[RelationshipSchemaName("botcomponent_SyncErrors")]
		public IEnumerable<SyncError> BotcomponentSyncErrors
		{
			get { return GetRelatedEntities<SyncError>("botcomponent_SyncErrors", null); }
			set { SetRelatedEntities("botcomponent_SyncErrors", null, value); }
		}
		/// <summary>
        /// N:N Get entities for 'Chatbot'
        /// </summary>
		[RelationshipSchemaName("bot_botcomponent")]
		public IEnumerable<Chatbot> BotBotcomponent
		{
			get { return GetRelatedEntities<Chatbot>("bot_botcomponent", null); }
			set { SetRelatedEntities("bot_botcomponent", null, value); }
		}
		/// <summary>
        /// N:N Get entities for 'ChatbotSubcomponent'
        /// </summary>
		[RelationshipSchemaName("botcomponent_botcomponent")]
		public IEnumerable<ChatbotSubcomponent> BotcomponentBotcomponent
		{
			get { return GetRelatedEntities<ChatbotSubcomponent>("botcomponent_botcomponent", null); }
			set { SetRelatedEntities("botcomponent_botcomponent", null, value); }
		}
		/// <summary>
        /// N:N Get entities for 'Process'
        /// </summary>
		[RelationshipSchemaName("botcomponent_workflow")]
		public IEnumerable<Process> BotcomponentWorkflow
		{
			get { return GetRelatedEntities<Process>("botcomponent_workflow", null); }
			set { SetRelatedEntities("botcomponent_workflow", null, value); }
		}
		#endregion

		#region Actions
		#endregion

		#region OptionSetEnums
		public enum eComponentType
		{	
		
			[Label("Topic")]
			[Description(@"A topic defines a how a bot conversation plays out. A topic has trigger phrases - these are phrases, keywords, or questions - and conversation nodes - these are what you use to define how a bot should respond and what it should do.")]
			Topic = 0, 
		
			[Label("Skill")]
			[Description(@"Power Virtual Agents enables you to extend your bot using Bot Framework Skills. Bot Framework Skills are re-usable conversational skill building-blocks covering conversational use-cases.")]
			Skill = 1, 
		
			[Label("Bot variable")]
			[Description(@"Variables let you save responses from your customers in a conversation with your bot so that you can reuse them later in the conversation.")]
			BotVariable = 2, 
		
			[Label("Bot entity")]
			[Description(@"An entity can be viewed as an information unit that represents a certain type of a real-world subject, like a phone number, zip code, city, or even a person's name.")]
			BotEntity = 3, 
		
			[Label("Dialog")]
			[Description(@"Dialogs provide more advanced functionality than topics and integrate with Bot Framework Composer.")]
			Dialog = 4, 
		
			[Label("Language understanding")]
			[Description(@"Language Understanding (LU) is used by a bot to understand language naturally and contextually to determine what next to do in a conversation flow.")]
			LanguageUnderstanding = 6, 
		
			[Label("Language generation")]
			[Description(@"Language Generation (LG) lets you define multiple variations of a phrase, execute simple expressions based on context, and refer to conversational memory.")]
			LanguageGeneration = 7, 
		
			[Label("Trigger")]
			[Description(@"Trigger defines how the topic is triggered and/or what actions are executed.")]
			Trigger = 5, 
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
		
		public enum egChatbotLanguage
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
			/// <summary>botcomponentid</summary>
			public const string BotComponentId = "botcomponentid";

			/// <summary>category</summary>
			public const string Category = "category";

			/// <summary>componentidunique</summary>
			public const string RowIdUniqueId = "componentidunique";

			/// <summary>componentstate</summary>
			public const string ComponentState = "componentstate";

			/// <summary>componenttype</summary>
			public const string ComponentType = "componenttype";

			/// <summary>content</summary>
			public const string Content = "content";

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

			/// <summary>data</summary>
			public const string ObiData = "data";

			/// <summary>description</summary>
			public const string Description = "description";

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

			/// <summary>parentbotcomponentid</summary>
			public const string ParentChatbotSubcomponent = "parentbotcomponentid";

			/// <summary>parentbotcomponentidname</summary>
			public const string Parentbotcomponentidname = "parentbotcomponentidname";

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
			/// <summary>1:N botcomponent_AsyncOperations</summary>
			public const string BotcomponentAsyncOperations = "botcomponent_AsyncOperations";

			/// <summary>1:N botcomponent_BulkDeleteFailures</summary>
			public const string BotcomponentBulkDeleteFailures = "botcomponent_BulkDeleteFailures";

			/// <summary>1:N botcomponent_MailboxTrackingFolders</summary>
			public const string BotcomponentMailboxTrackingFolders = "botcomponent_MailboxTrackingFolders";

			/// <summary>1:N botcomponent_parent_botcomponent</summary>
			public const string BotcomponentParentBotcomponent = "botcomponent_parent_botcomponent";

			/// <summary>1:N botcomponent_PrincipalObjectAttributeAccesses</summary>
			public const string BotcomponentPrincipalObjectAttributeAccesses = "botcomponent_PrincipalObjectAttributeAccesses";

			/// <summary>1:N botcomponent_ProcessSession</summary>
			public const string BotcomponentProcessSession = "botcomponent_ProcessSession";

			/// <summary>1:N botcomponent_SyncErrors</summary>
			public const string BotcomponentSyncErrors = "botcomponent_SyncErrors";

			/// <summary>N:N bot_botcomponent</summary>
			public const string BotBotcomponent = "bot_botcomponent";

			/// <summary>N:N botcomponent_botcomponent</summary>
			public const string BotcomponentBotcomponent = "botcomponent_botcomponent";

			/// <summary>N:N botcomponent_workflow</summary>
			public const string BotcomponentWorkflow = "botcomponent_workflow";

		}
		#endregion
	}
}

