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
	[EntityLogicalName("msdyn_playbookinstance")]
	public sealed class Playbook : Entity
	{	
		public static readonly int? EntityTypeCode = 10080;
		public new const string LogicalName = "msdyn_playbookinstance";
		public const string PrimaryIdAttribute = "msdyn_playbookinstanceid";
		public const string PrimaryNameAttribute = "msdyn_name";
	
		public Playbook() : base("msdyn_playbookinstance") { }

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
		[DisplayName("Started On")]
		[AttributeLogicalName("createdon")]
		public DateTime? StartedOn
		{	
			get { return GetAttributeValue<DateTime?>("createdon"); }
			set
			{ 
				if(value == StartedOn) return;
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
        /// msdyn_activitiesassociated
        /// </summary>
		[DisplayName("Total activities")]
		[AttributeLogicalName("msdyn_activitiesassociated")]
		public int? TotalActivities
		{	
			get { return GetAttributeValue<int?>("msdyn_activitiesassociated"); }
			set
			{ 
				if(value == TotalActivities) return;
				SetAttributeValue("msdyn_activitiesassociated", value);
			}
		}	
			
		/// <summary>
        /// msdyn_activitiesclosed
        /// </summary>
		[DisplayName("Completed activities")]
		[AttributeLogicalName("msdyn_activitiesclosed")]
		public int? CompletedActivities
		{	
			get { return GetAttributeValue<int?>("msdyn_activitiesclosed"); }
			set
			{ 
				if(value == CompletedActivities) return;
				SetAttributeValue("msdyn_activitiesclosed", value);
			}
		}	
			
		/// <summary>
        /// msdyn_categoryid
        /// </summary>
		[DisplayName("Category")]
		[AttributeLogicalName("msdyn_categoryid")]
		public EntityReference Category
		{	
			get { return GetAttributeValue<EntityReference>("msdyn_categoryid"); }
			set
			{ 
				if(value == Category) return;
				SetAttributeValue("msdyn_categoryid", value);
			}
		}	
			
		/// <summary>
        /// msdyn_categoryidname
        /// </summary>
		[DisplayName("msdyn_categoryidname")]
		[AttributeLogicalName("msdyn_categoryidname")]
		public string MsdynCategoryidname
		{	
			get { return GetAttributeValue<string>("msdyn_categoryidname"); }
			set
			{ 
				if(value == MsdynCategoryidname) return;
				SetAttributeValue("msdyn_categoryidname", value);
			}
		}	
			
		/// <summary>
        /// msdyn_estimatedclose
        /// </summary>
		[DisplayName("Estimated close")]
		[AttributeLogicalName("msdyn_estimatedclose")]
		public DateTime? EstimatedClose
		{	
			get { return GetAttributeValue<DateTime?>("msdyn_estimatedclose"); }
			set
			{ 
				if(value == EstimatedClose) return;
				SetAttributeValue("msdyn_estimatedclose", value);
			}
		}	
			
		/// <summary>
        /// msdyn_evaluateactivityclosure
        /// </summary>
		[DisplayName("Evaluate Activity Closure")]
		[AttributeLogicalName("msdyn_evaluateactivityclosure")]
		public bool? EvaluateActivityClosure
		{	
			get { return GetAttributeValue<bool?>("msdyn_evaluateactivityclosure"); }
			set
			{ 
				if(value == EvaluateActivityClosure) return;
				SetAttributeValue("msdyn_evaluateactivityclosure", value);
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
        /// msdyn_playbookinstanceid
        /// </summary>
		[DisplayName("Playbook")]
		[AttributeLogicalName("msdyn_playbookinstanceid")]
		public override Guid Id
		{
			get => base.Id;
			set { base.Id = value; SetAttributeValue("msdyn_playbookinstanceid", value); }
		}

							/// <summary>
        /// msdyn_playbooktemplateid
        /// </summary>
		[DisplayName("Playbook Template")]
		[AttributeLogicalName("msdyn_playbooktemplateid")]
		public EntityReference PlaybookTemplate
		{	
			get { return GetAttributeValue<EntityReference>("msdyn_playbooktemplateid"); }
			set
			{ 
				if(value == PlaybookTemplate) return;
				SetAttributeValue("msdyn_playbooktemplateid", value);
			}
		}	
			
		/// <summary>
        /// msdyn_playbooktemplateidname
        /// </summary>
		[DisplayName("msdyn_playbooktemplateidname")]
		[AttributeLogicalName("msdyn_playbooktemplateidname")]
		public string MsdynPlaybooktemplateidname
		{	
			get { return GetAttributeValue<string>("msdyn_playbooktemplateidname"); }
			set
			{ 
				if(value == MsdynPlaybooktemplateidname) return;
				SetAttributeValue("msdyn_playbooktemplateidname", value);
			}
		}	
			
		/// <summary>
        /// msdyn_trackprogress
        /// </summary>
		[DisplayName("Track progress")]
		[AttributeLogicalName("msdyn_trackprogress")]
		public bool? TrackProgress
		{	
			get { return GetAttributeValue<bool?>("msdyn_trackprogress"); }
			set
			{ 
				if(value == TrackProgress) return;
				SetAttributeValue("msdyn_trackprogress", value);
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
        /// regarding
        /// </summary>
		[DisplayName("Regarding")]
		[AttributeLogicalName("regarding")]
		public EntityReference Regarding
		{	
			get { return GetAttributeValue<EntityReference>("regarding"); }
			set
			{ 
				if(value == Regarding) return;
				SetAttributeValue("regarding", value);
			}
		}	
			
		/// <summary>
        /// regardingidname
        /// </summary>
		[DisplayName("regardingidname")]
		[AttributeLogicalName("regardingidname")]
		public string Regardingidname
		{	
			get { return GetAttributeValue<string>("regardingidname"); }
			set
			{ 
				if(value == Regardingidname) return;
				SetAttributeValue("regardingidname", value);
			}
		}	
			
		/// <summary>
        /// regardingobjecttypecode
        /// </summary>
		[DisplayName("regardingobjecttypecode")]
		[AttributeLogicalName("regardingobjecttypecode")]
		public string Regardingobjecttypecode
		{	
			get { return GetAttributeValue<string>("regardingobjecttypecode"); }
			set
			{ 
				if(value == Regardingobjecttypecode) return;
				SetAttributeValue("regardingobjecttypecode", value);
			}
		}	
			
		/// <summary>
        /// regardingyominame
        /// </summary>
		[DisplayName("regardingyominame")]
		[AttributeLogicalName("regardingyominame")]
		public string Regardingyominame
		{	
			get { return GetAttributeValue<string>("regardingyominame"); }
			set
			{ 
				if(value == Regardingyominame) return;
				SetAttributeValue("regardingyominame", value);
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
		[DisplayName("Result")]
		[AttributeLogicalName("statuscode")]
		public eStatusReason? Result
		{	
			get 
			{ 
				var optionSetValue = GetAttributeValue<OptionSetValue>("statuscode");
				if (optionSetValue != null) return (eStatusReason)optionSetValue.Value;
				else return null;
			}
			set 
			{ 
				if(value == Result) return;

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
        /// 1:N Get entities for 'msdyn_playbookinstance_ActivityPointers'
        /// </summary>
		[RelationshipSchemaName("msdyn_playbookinstance_ActivityPointers")]
		public IEnumerable<Activity> MsdynPlaybookinstanceActivityPointers
		{
			get { return GetRelatedEntities<Activity>("msdyn_playbookinstance_ActivityPointers", null); }
			set { SetRelatedEntities("msdyn_playbookinstance_ActivityPointers", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'msdyn_playbookinstance_Annotations'
        /// </summary>
		[RelationshipSchemaName("msdyn_playbookinstance_Annotations")]
		public IEnumerable<Note> MsdynPlaybookinstanceAnnotations
		{
			get { return GetRelatedEntities<Note>("msdyn_playbookinstance_Annotations", null); }
			set { SetRelatedEntities("msdyn_playbookinstance_Annotations", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'msdyn_playbookinstance_Appointments'
        /// </summary>
		[RelationshipSchemaName("msdyn_playbookinstance_Appointments")]
		public IEnumerable<Appointment> MsdynPlaybookinstanceAppointments
		{
			get { return GetRelatedEntities<Appointment>("msdyn_playbookinstance_Appointments", null); }
			set { SetRelatedEntities("msdyn_playbookinstance_Appointments", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'msdyn_playbookinstance_AsyncOperations'
        /// </summary>
		[RelationshipSchemaName("msdyn_playbookinstance_AsyncOperations")]
		public IEnumerable<SystemJob> MsdynPlaybookinstanceAsyncOperations
		{
			get { return GetRelatedEntities<SystemJob>("msdyn_playbookinstance_AsyncOperations", null); }
			set { SetRelatedEntities("msdyn_playbookinstance_AsyncOperations", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'msdyn_playbookinstance_BulkDeleteFailures'
        /// </summary>
		[RelationshipSchemaName("msdyn_playbookinstance_BulkDeleteFailures")]
		public IEnumerable<BulkDeleteFailure> MsdynPlaybookinstanceBulkDeleteFailures
		{
			get { return GetRelatedEntities<BulkDeleteFailure>("msdyn_playbookinstance_BulkDeleteFailures", null); }
			set { SetRelatedEntities("msdyn_playbookinstance_BulkDeleteFailures", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'msdyn_playbookinstance_DuplicateBaseRecord'
        /// </summary>
		[RelationshipSchemaName("msdyn_playbookinstance_DuplicateBaseRecord")]
		public IEnumerable<DuplicateRecord> MsdynPlaybookinstanceDuplicateBaseRecord
		{
			get { return GetRelatedEntities<DuplicateRecord>("msdyn_playbookinstance_DuplicateBaseRecord", null); }
			set { SetRelatedEntities("msdyn_playbookinstance_DuplicateBaseRecord", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'msdyn_playbookinstance_DuplicateMatchingRecord'
        /// </summary>
		[RelationshipSchemaName("msdyn_playbookinstance_DuplicateMatchingRecord")]
		public IEnumerable<DuplicateRecord> MsdynPlaybookinstanceDuplicateMatchingRecord
		{
			get { return GetRelatedEntities<DuplicateRecord>("msdyn_playbookinstance_DuplicateMatchingRecord", null); }
			set { SetRelatedEntities("msdyn_playbookinstance_DuplicateMatchingRecord", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'msdyn_playbookinstance_Emails'
        /// </summary>
		[RelationshipSchemaName("msdyn_playbookinstance_Emails")]
		public IEnumerable<Email> MsdynPlaybookinstanceEmails
		{
			get { return GetRelatedEntities<Email>("msdyn_playbookinstance_Emails", null); }
			set { SetRelatedEntities("msdyn_playbookinstance_Emails", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'msdyn_playbookinstance_Faxes'
        /// </summary>
		[RelationshipSchemaName("msdyn_playbookinstance_Faxes")]
		public IEnumerable<Fax> MsdynPlaybookinstanceFaxes
		{
			get { return GetRelatedEntities<Fax>("msdyn_playbookinstance_Faxes", null); }
			set { SetRelatedEntities("msdyn_playbookinstance_Faxes", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'msdyn_playbookinstance_Letters'
        /// </summary>
		[RelationshipSchemaName("msdyn_playbookinstance_Letters")]
		public IEnumerable<Letter> MsdynPlaybookinstanceLetters
		{
			get { return GetRelatedEntities<Letter>("msdyn_playbookinstance_Letters", null); }
			set { SetRelatedEntities("msdyn_playbookinstance_Letters", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'msdyn_playbookinstance_MailboxTrackingFolders'
        /// </summary>
		[RelationshipSchemaName("msdyn_playbookinstance_MailboxTrackingFolders")]
		public IEnumerable<MailboxAutoTrackingFolder> MsdynPlaybookinstanceMailboxTrackingFolders
		{
			get { return GetRelatedEntities<MailboxAutoTrackingFolder>("msdyn_playbookinstance_MailboxTrackingFolders", null); }
			set { SetRelatedEntities("msdyn_playbookinstance_MailboxTrackingFolders", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'msdyn_playbookinstance_OpportunityCloses'
        /// </summary>
		[RelationshipSchemaName("msdyn_playbookinstance_OpportunityCloses")]
		public IEnumerable<OpportunityClose> MsdynPlaybookinstanceOpportunityCloses
		{
			get { return GetRelatedEntities<OpportunityClose>("msdyn_playbookinstance_OpportunityCloses", null); }
			set { SetRelatedEntities("msdyn_playbookinstance_OpportunityCloses", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'msdyn_playbookinstance_OrderCloses'
        /// </summary>
		[RelationshipSchemaName("msdyn_playbookinstance_OrderCloses")]
		public IEnumerable<OrderClose> MsdynPlaybookinstanceOrderCloses
		{
			get { return GetRelatedEntities<OrderClose>("msdyn_playbookinstance_OrderCloses", null); }
			set { SetRelatedEntities("msdyn_playbookinstance_OrderCloses", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'msdyn_playbookinstance_PhoneCalls'
        /// </summary>
		[RelationshipSchemaName("msdyn_playbookinstance_PhoneCalls")]
		public IEnumerable<PhoneCall> MsdynPlaybookinstancePhoneCalls
		{
			get { return GetRelatedEntities<PhoneCall>("msdyn_playbookinstance_PhoneCalls", null); }
			set { SetRelatedEntities("msdyn_playbookinstance_PhoneCalls", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'msdyn_playbookinstance_PrincipalObjectAttributeAccesses'
        /// </summary>
		[RelationshipSchemaName("msdyn_playbookinstance_PrincipalObjectAttributeAccesses")]
		public IEnumerable<FieldSharing> MsdynPlaybookinstancePrincipalObjectAttributeAccesses
		{
			get { return GetRelatedEntities<FieldSharing>("msdyn_playbookinstance_PrincipalObjectAttributeAccesses", null); }
			set { SetRelatedEntities("msdyn_playbookinstance_PrincipalObjectAttributeAccesses", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'msdyn_playbookinstance_ProcessSession'
        /// </summary>
		[RelationshipSchemaName("msdyn_playbookinstance_ProcessSession")]
		public IEnumerable<ProcessSession> MsdynPlaybookinstanceProcessSession
		{
			get { return GetRelatedEntities<ProcessSession>("msdyn_playbookinstance_ProcessSession", null); }
			set { SetRelatedEntities("msdyn_playbookinstance_ProcessSession", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'msdyn_playbookinstance_QuoteCloses'
        /// </summary>
		[RelationshipSchemaName("msdyn_playbookinstance_QuoteCloses")]
		public IEnumerable<QuoteClose> MsdynPlaybookinstanceQuoteCloses
		{
			get { return GetRelatedEntities<QuoteClose>("msdyn_playbookinstance_QuoteCloses", null); }
			set { SetRelatedEntities("msdyn_playbookinstance_QuoteCloses", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'msdyn_playbookinstance_RecurringAppointmentMasters'
        /// </summary>
		[RelationshipSchemaName("msdyn_playbookinstance_RecurringAppointmentMasters")]
		public IEnumerable<RecurringAppointment> MsdynPlaybookinstanceRecurringAppointmentMasters
		{
			get { return GetRelatedEntities<RecurringAppointment>("msdyn_playbookinstance_RecurringAppointmentMasters", null); }
			set { SetRelatedEntities("msdyn_playbookinstance_RecurringAppointmentMasters", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'msdyn_playbookinstance_ServiceAppointments'
        /// </summary>
		[RelationshipSchemaName("msdyn_playbookinstance_ServiceAppointments")]
		public IEnumerable<ServiceActivity> MsdynPlaybookinstanceServiceAppointments
		{
			get { return GetRelatedEntities<ServiceActivity>("msdyn_playbookinstance_ServiceAppointments", null); }
			set { SetRelatedEntities("msdyn_playbookinstance_ServiceAppointments", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'msdyn_playbookinstance_SocialActivities'
        /// </summary>
		[RelationshipSchemaName("msdyn_playbookinstance_SocialActivities")]
		public IEnumerable<SocialActivity> MsdynPlaybookinstanceSocialActivities
		{
			get { return GetRelatedEntities<SocialActivity>("msdyn_playbookinstance_SocialActivities", null); }
			set { SetRelatedEntities("msdyn_playbookinstance_SocialActivities", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'msdyn_playbookinstance_SyncErrors'
        /// </summary>
		[RelationshipSchemaName("msdyn_playbookinstance_SyncErrors")]
		public IEnumerable<SyncError> MsdynPlaybookinstanceSyncErrors
		{
			get { return GetRelatedEntities<SyncError>("msdyn_playbookinstance_SyncErrors", null); }
			set { SetRelatedEntities("msdyn_playbookinstance_SyncErrors", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'msdyn_playbookinstance_Tasks'
        /// </summary>
		[RelationshipSchemaName("msdyn_playbookinstance_Tasks")]
		public IEnumerable<Task> MsdynPlaybookinstanceTasks
		{
			get { return GetRelatedEntities<Task>("msdyn_playbookinstance_Tasks", null); }
			set { SetRelatedEntities("msdyn_playbookinstance_Tasks", null, value); }
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
		
			[Label("Completed")]
			[Description(@"")]
			Completed = 1, 
		}
		
		public enum eStatusReason
		{	
		
			[Label("In Progress")]
			[Description(@"")]
			InProgress_Active = 1, 
		
			[Label("Successful")]
			[Description(@"")]
			Successful_Inactive = 2, 
		
			[Label("Not Successful")]
			[Description(@"")]
			NotSuccessful_Inactive = 3, 
		
			[Label("Partially Successful")]
			[Description(@"")]
			PartiallySuccessful_Inactive = 4, 
		
			[Label("Not Required")]
			[Description(@"")]
			NotRequired_Inactive = 5, 
		
			[Label("Not Tracked")]
			[Description(@"")]
			NotTracked_Inactive = 6, 
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
			public const string StartedOn = "createdon";

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

			/// <summary>msdyn_activitiesassociated</summary>
			public const string TotalActivities = "msdyn_activitiesassociated";

			/// <summary>msdyn_activitiesclosed</summary>
			public const string CompletedActivities = "msdyn_activitiesclosed";

			/// <summary>msdyn_categoryid</summary>
			public const string Category = "msdyn_categoryid";

			/// <summary>msdyn_categoryidname</summary>
			public const string MsdynCategoryidname = "msdyn_categoryidname";

			/// <summary>msdyn_estimatedclose</summary>
			public const string EstimatedClose = "msdyn_estimatedclose";

			/// <summary>msdyn_evaluateactivityclosure</summary>
			public const string EvaluateActivityClosure = "msdyn_evaluateactivityclosure";

			/// <summary>msdyn_name</summary>
			public const string Name = "msdyn_name";

			/// <summary>msdyn_playbookinstanceid</summary>
			public const string PlaybookId = "msdyn_playbookinstanceid";

			/// <summary>msdyn_playbooktemplateid</summary>
			public const string PlaybookTemplate = "msdyn_playbooktemplateid";

			/// <summary>msdyn_playbooktemplateidname</summary>
			public const string MsdynPlaybooktemplateidname = "msdyn_playbooktemplateidname";

			/// <summary>msdyn_trackprogress</summary>
			public const string TrackProgress = "msdyn_trackprogress";

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

			/// <summary>regarding</summary>
			public const string Regarding = "regarding";

			/// <summary>regardingidname</summary>
			public const string Regardingidname = "regardingidname";

			/// <summary>regardingobjecttypecode</summary>
			public const string Regardingobjecttypecode = "regardingobjecttypecode";

			/// <summary>regardingyominame</summary>
			public const string Regardingyominame = "regardingyominame";

			/// <summary>statecode</summary>
			public const string Status = "statecode";

			/// <summary>statuscode</summary>
			public const string Result = "statuscode";

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
			/// <summary>1:N msdyn_playbookinstance_ActivityPointers</summary>
			public const string MsdynPlaybookinstanceActivityPointers = "msdyn_playbookinstance_ActivityPointers";

			/// <summary>1:N msdyn_playbookinstance_Annotations</summary>
			public const string MsdynPlaybookinstanceAnnotations = "msdyn_playbookinstance_Annotations";

			/// <summary>1:N msdyn_playbookinstance_Appointments</summary>
			public const string MsdynPlaybookinstanceAppointments = "msdyn_playbookinstance_Appointments";

			/// <summary>1:N msdyn_playbookinstance_AsyncOperations</summary>
			public const string MsdynPlaybookinstanceAsyncOperations = "msdyn_playbookinstance_AsyncOperations";

			/// <summary>1:N msdyn_playbookinstance_BulkDeleteFailures</summary>
			public const string MsdynPlaybookinstanceBulkDeleteFailures = "msdyn_playbookinstance_BulkDeleteFailures";

			/// <summary>1:N msdyn_playbookinstance_DuplicateBaseRecord</summary>
			public const string MsdynPlaybookinstanceDuplicateBaseRecord = "msdyn_playbookinstance_DuplicateBaseRecord";

			/// <summary>1:N msdyn_playbookinstance_DuplicateMatchingRecord</summary>
			public const string MsdynPlaybookinstanceDuplicateMatchingRecord = "msdyn_playbookinstance_DuplicateMatchingRecord";

			/// <summary>1:N msdyn_playbookinstance_Emails</summary>
			public const string MsdynPlaybookinstanceEmails = "msdyn_playbookinstance_Emails";

			/// <summary>1:N msdyn_playbookinstance_Faxes</summary>
			public const string MsdynPlaybookinstanceFaxes = "msdyn_playbookinstance_Faxes";

			/// <summary>1:N msdyn_playbookinstance_Letters</summary>
			public const string MsdynPlaybookinstanceLetters = "msdyn_playbookinstance_Letters";

			/// <summary>1:N msdyn_playbookinstance_MailboxTrackingFolders</summary>
			public const string MsdynPlaybookinstanceMailboxTrackingFolders = "msdyn_playbookinstance_MailboxTrackingFolders";

			/// <summary>1:N msdyn_playbookinstance_OpportunityCloses</summary>
			public const string MsdynPlaybookinstanceOpportunityCloses = "msdyn_playbookinstance_OpportunityCloses";

			/// <summary>1:N msdyn_playbookinstance_OrderCloses</summary>
			public const string MsdynPlaybookinstanceOrderCloses = "msdyn_playbookinstance_OrderCloses";

			/// <summary>1:N msdyn_playbookinstance_PhoneCalls</summary>
			public const string MsdynPlaybookinstancePhoneCalls = "msdyn_playbookinstance_PhoneCalls";

			/// <summary>1:N msdyn_playbookinstance_PrincipalObjectAttributeAccesses</summary>
			public const string MsdynPlaybookinstancePrincipalObjectAttributeAccesses = "msdyn_playbookinstance_PrincipalObjectAttributeAccesses";

			/// <summary>1:N msdyn_playbookinstance_ProcessSession</summary>
			public const string MsdynPlaybookinstanceProcessSession = "msdyn_playbookinstance_ProcessSession";

			/// <summary>1:N msdyn_playbookinstance_QuoteCloses</summary>
			public const string MsdynPlaybookinstanceQuoteCloses = "msdyn_playbookinstance_QuoteCloses";

			/// <summary>1:N msdyn_playbookinstance_RecurringAppointmentMasters</summary>
			public const string MsdynPlaybookinstanceRecurringAppointmentMasters = "msdyn_playbookinstance_RecurringAppointmentMasters";

			/// <summary>1:N msdyn_playbookinstance_ServiceAppointments</summary>
			public const string MsdynPlaybookinstanceServiceAppointments = "msdyn_playbookinstance_ServiceAppointments";

			/// <summary>1:N msdyn_playbookinstance_SocialActivities</summary>
			public const string MsdynPlaybookinstanceSocialActivities = "msdyn_playbookinstance_SocialActivities";

			/// <summary>1:N msdyn_playbookinstance_SyncErrors</summary>
			public const string MsdynPlaybookinstanceSyncErrors = "msdyn_playbookinstance_SyncErrors";

			/// <summary>1:N msdyn_playbookinstance_Tasks</summary>
			public const string MsdynPlaybookinstanceTasks = "msdyn_playbookinstance_Tasks";

		}
		#endregion
	}
}

