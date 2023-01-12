using System;
using System.Linq;
using System.Diagnostics;
using System.ComponentModel;
using Microsoft.Xrm.Sdk; 
using Microsoft.Xrm.Sdk.Client;
using System.Collections.Generic;

namespace PentaWork.Xrm.Scheduler.Proxies.Entities
{
	[DebuggerDisplay("{Title}")] 	
	[EntityLogicalName("feedback")]
	public sealed class Feedback : Entity
	{	
		public static readonly int? EntityTypeCode = 9958;
		public new const string LogicalName = "feedback";
		public const string PrimaryIdAttribute = "feedbackid";
		public const string PrimaryNameAttribute = "title";
	
		public Feedback() : base("feedback") { }

		#region Attributes
		/// <summary>
        /// closedby
        /// </summary>
		[DisplayName("Closed By")]
		[AttributeLogicalName("closedby")]
		public EntityReference ClosedBy
		{	
			get { return GetAttributeValue<EntityReference>("closedby"); }
			set
			{ 
				if(value == ClosedBy) return;
				SetAttributeValue("closedby", value);
			}
		}	
			
		/// <summary>
        /// closedbyname
        /// </summary>
		[DisplayName("closedbyname")]
		[AttributeLogicalName("closedbyname")]
		public string Closedbyname
		{	
			get { return GetAttributeValue<string>("closedbyname"); }
			set
			{ 
				if(value == Closedbyname) return;
				SetAttributeValue("closedbyname", value);
			}
		}	
			
		/// <summary>
        /// closedbyyominame
        /// </summary>
		[DisplayName("closedbyyominame")]
		[AttributeLogicalName("closedbyyominame")]
		public string Closedbyyominame
		{	
			get { return GetAttributeValue<string>("closedbyyominame"); }
			set
			{ 
				if(value == Closedbyyominame) return;
				SetAttributeValue("closedbyyominame", value);
			}
		}	
			
		/// <summary>
        /// closedon
        /// </summary>
		[DisplayName("Closed On")]
		[AttributeLogicalName("closedon")]
		public DateTime? ClosedOn
		{	
			get { return GetAttributeValue<DateTime?>("closedon"); }
			set
			{ 
				if(value == ClosedOn) return;
				SetAttributeValue("closedon", value);
			}
		}	
			
		/// <summary>
        /// comments
        /// </summary>
		[DisplayName("Comments")]
		[AttributeLogicalName("comments")]
		public string Comments
		{	
			get { return GetAttributeValue<string>("comments"); }
			set
			{ 
				if(value == Comments) return;
				SetAttributeValue("comments", value);
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
        /// createdbycontact
        /// </summary>
		[DisplayName("Created By (Contact)")]
		[AttributeLogicalName("createdbycontact")]
		public EntityReference CreatedByContact
		{	
			get { return GetAttributeValue<EntityReference>("createdbycontact"); }
			set
			{ 
				if(value == CreatedByContact) return;
				SetAttributeValue("createdbycontact", value);
			}
		}	
			
		/// <summary>
        /// createdbycontactname
        /// </summary>
		[DisplayName("createdbycontactname")]
		[AttributeLogicalName("createdbycontactname")]
		public string Createdbycontactname
		{	
			get { return GetAttributeValue<string>("createdbycontactname"); }
			set
			{ 
				if(value == Createdbycontactname) return;
				SetAttributeValue("createdbycontactname", value);
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
        /// createdonbehalfbycontact
        /// </summary>
		[DisplayName("Created OnBelhalfBy (Contact)")]
		[AttributeLogicalName("createdonbehalfbycontact")]
		public EntityReference CreatedOnBelhalfByContact
		{	
			get { return GetAttributeValue<EntityReference>("createdonbehalfbycontact"); }
			set
			{ 
				if(value == CreatedOnBelhalfByContact) return;
				SetAttributeValue("createdonbehalfbycontact", value);
			}
		}	
			
		/// <summary>
        /// createdonbehalfbycontactname
        /// </summary>
		[DisplayName("createdonbehalfbycontactname")]
		[AttributeLogicalName("createdonbehalfbycontactname")]
		public string Createdonbehalfbycontactname
		{	
			get { return GetAttributeValue<string>("createdonbehalfbycontactname"); }
			set
			{ 
				if(value == Createdonbehalfbycontactname) return;
				SetAttributeValue("createdonbehalfbycontactname", value);
			}
		}	
			
		/// <summary>
        /// createdonbehalfbycontactyominame
        /// </summary>
		[DisplayName("createdonbehalfbycontactyominame")]
		[AttributeLogicalName("createdonbehalfbycontactyominame")]
		public string Createdonbehalfbycontactyominame
		{	
			get { return GetAttributeValue<string>("createdonbehalfbycontactyominame"); }
			set
			{ 
				if(value == Createdonbehalfbycontactyominame) return;
				SetAttributeValue("createdonbehalfbycontactyominame", value);
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
        /// exchangerate
		///
		/// Precision: 10
		/// MaxValue: 100000000000
		/// MinValue: 0.0000000001
        /// </summary>
		[DisplayName("Exchange Rate")]
		[AttributeLogicalName("exchangerate")]
		public decimal? ExchangeRate
		{	
			get { return GetAttributeValue<decimal?>("exchangerate"); }
			set 
			{
				decimal? decimalValue = null;
				if(value != null) decimalValue = Decimal.Round(value.Value, 10);
				if(decimalValue == ExchangeRate) return;
				SetAttributeValue("exchangerate", decimalValue);  
			}
		}

		/// <summary>
        /// feedbackid
        /// </summary>
		[DisplayName("Feedback")]
		[AttributeLogicalName("feedbackid")]
		public override Guid Id
		{
			get => base.Id;
			set { base.Id = value; SetAttributeValue("feedbackid", value); }
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
        /// maxrating
        /// </summary>
		[DisplayName("Maximum Rating")]
		[AttributeLogicalName("maxrating")]
		public int? MaximumRating
		{	
			get { return GetAttributeValue<int?>("maxrating"); }
			set
			{ 
				if(value == MaximumRating) return;
				SetAttributeValue("maxrating", value);
			}
		}	
			
		/// <summary>
        /// minrating
        /// </summary>
		[DisplayName("Minimum Rating")]
		[AttributeLogicalName("minrating")]
		public int? MinimumRating
		{	
			get { return GetAttributeValue<int?>("minrating"); }
			set
			{ 
				if(value == MinimumRating) return;
				SetAttributeValue("minrating", value);
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
        /// msdyn_contextobjectid
        /// </summary>
		[DisplayName("Context")]
		[AttributeLogicalName("msdyn_contextobjectid")]
		public EntityReference Context
		{	
			get { return GetAttributeValue<EntityReference>("msdyn_contextobjectid"); }
			set
			{ 
				if(value == Context) return;
				SetAttributeValue("msdyn_contextobjectid", value);
			}
		}	
			
		/// <summary>
        /// msdyn_contextobjectidname
        /// </summary>
		[DisplayName("msdyn_contextobjectidname")]
		[AttributeLogicalName("msdyn_contextobjectidname")]
		public string MsdynContextobjectidname
		{	
			get { return GetAttributeValue<string>("msdyn_contextobjectidname"); }
			set
			{ 
				if(value == MsdynContextobjectidname) return;
				SetAttributeValue("msdyn_contextobjectidname", value);
			}
		}	
			
		/// <summary>
        /// msdyn_contextobjectidtype
        /// </summary>
		[DisplayName("msdyn_contextobjectidtype")]
		[AttributeLogicalName("msdyn_contextobjectidtype")]
		public string MsdynContextobjectidtype
		{	
			get { return GetAttributeValue<string>("msdyn_contextobjectidtype"); }
			set
			{ 
				if(value == MsdynContextobjectidtype) return;
				SetAttributeValue("msdyn_contextobjectidtype", value);
			}
		}	
			
		/// <summary>
        /// msdyn_contextobjectidyominame
        /// </summary>
		[DisplayName("msdyn_contextobjectidyominame")]
		[AttributeLogicalName("msdyn_contextobjectidyominame")]
		public string MsdynContextobjectidyominame
		{	
			get { return GetAttributeValue<string>("msdyn_contextobjectidyominame"); }
			set
			{ 
				if(value == MsdynContextobjectidyominame) return;
				SetAttributeValue("msdyn_contextobjectidyominame", value);
			}
		}	
			
		/// <summary>
        /// normalizedrating
		///
		/// Precision: 2
		/// MaxValue: 1000000000
		/// MinValue: -100000000000
        /// </summary>
		[DisplayName("Normalized Rating")]
		[AttributeLogicalName("normalizedrating")]
		public decimal? NormalizedRating
		{	
			get { return GetAttributeValue<decimal?>("normalizedrating"); }
			set 
			{
				decimal? decimalValue = null;
				if(value != null) decimalValue = Decimal.Round(value.Value, 2);
				if(decimalValue == NormalizedRating) return;
				SetAttributeValue("normalizedrating", decimalValue);  
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
        /// rating
        /// </summary>
		[DisplayName("Rating")]
		[AttributeLogicalName("rating")]
		public int? Rating
		{	
			get { return GetAttributeValue<int?>("rating"); }
			set
			{ 
				if(value == Rating) return;
				SetAttributeValue("rating", value);
			}
		}	
			
		/// <summary>
        /// regardingobjectid
        /// </summary>
		[DisplayName("Regarding")]
		[AttributeLogicalName("regardingobjectid")]
		public EntityReference Regarding
		{	
			get { return GetAttributeValue<EntityReference>("regardingobjectid"); }
			set
			{ 
				if(value == Regarding) return;
				SetAttributeValue("regardingobjectid", value);
			}
		}	
			
		/// <summary>
        /// regardingobjectidname
        /// </summary>
		[DisplayName("regardingobjectidname")]
		[AttributeLogicalName("regardingobjectidname")]
		public string Regardingobjectidname
		{	
			get { return GetAttributeValue<string>("regardingobjectidname"); }
			set
			{ 
				if(value == Regardingobjectidname) return;
				SetAttributeValue("regardingobjectidname", value);
			}
		}	
			
		/// <summary>
        /// regardingobjectidyominame
        /// </summary>
		[DisplayName("regardingobjectidyominame")]
		[AttributeLogicalName("regardingobjectidyominame")]
		public string Regardingobjectidyominame
		{	
			get { return GetAttributeValue<string>("regardingobjectidyominame"); }
			set
			{ 
				if(value == Regardingobjectidyominame) return;
				SetAttributeValue("regardingobjectidyominame", value);
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
        /// source
        /// </summary>
		[DisplayName("Source")]
		[AttributeLogicalName("source")]
		public eSource? Source
		{	
			get 
			{ 
				var optionSetValue = GetAttributeValue<OptionSetValue>("source");
				if (optionSetValue != null) return (eSource)optionSetValue.Value;
				else return null;
			}
			set 
			{ 
				if(value == Source) return;

				OptionSetValue optionSetValue = null;
				if(value != null) optionSetValue = new OptionSetValue((int)value);
				SetAttributeValue("source", optionSetValue); 
			}
		}

		/// <summary>
        /// statecode
        /// </summary>
		[DisplayName("Status")]
		[AttributeLogicalName("statecode")]
		public eState? Status
		{	
			get 
			{ 
				var optionSetValue = GetAttributeValue<OptionSetValue>("statecode");
				if (optionSetValue != null) return (eState)optionSetValue.Value;
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
		public eStatus? StatusReason
		{	
			get 
			{ 
				var optionSetValue = GetAttributeValue<OptionSetValue>("statuscode");
				if (optionSetValue != null) return (eStatus)optionSetValue.Value;
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
        /// title
        /// </summary>
		[DisplayName("Title")]
		[AttributeLogicalName("title")]
		public string Title
		{	
			get { return GetAttributeValue<string>("title"); }
			set
			{ 
				if(value == Title) return;
				SetAttributeValue("title", value);
			}
		}	
			
		/// <summary>
        /// transactioncurrencyid
        /// </summary>
		[DisplayName("Currency")]
		[AttributeLogicalName("transactioncurrencyid")]
		public EntityReference Currency
		{	
			get { return GetAttributeValue<EntityReference>("transactioncurrencyid"); }
			set
			{ 
				if(value == Currency) return;
				SetAttributeValue("transactioncurrencyid", value);
			}
		}	
			
		/// <summary>
        /// transactioncurrencyidname
        /// </summary>
		[DisplayName("transactioncurrencyidname")]
		[AttributeLogicalName("transactioncurrencyidname")]
		public string Transactioncurrencyidname
		{	
			get { return GetAttributeValue<string>("transactioncurrencyidname"); }
			set
			{ 
				if(value == Transactioncurrencyidname) return;
				SetAttributeValue("transactioncurrencyidname", value);
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
        /// 1:N Get entities for 'feedback_DuplicateBaseRecord'
        /// </summary>
		[RelationshipSchemaName("feedback_DuplicateBaseRecord")]
		public IEnumerable<DuplicateRecord> FeedbackDuplicateBaseRecord
		{
			get { return GetRelatedEntities<DuplicateRecord>("feedback_DuplicateBaseRecord", null); }
			set { SetRelatedEntities("feedback_DuplicateBaseRecord", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'feedback_DuplicateMatchingRecord'
        /// </summary>
		[RelationshipSchemaName("feedback_DuplicateMatchingRecord")]
		public IEnumerable<DuplicateRecord> FeedbackDuplicateMatchingRecord
		{
			get { return GetRelatedEntities<DuplicateRecord>("feedback_DuplicateMatchingRecord", null); }
			set { SetRelatedEntities("feedback_DuplicateMatchingRecord", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'feedback_feedback'
        /// </summary>
		[RelationshipSchemaName("feedback_feedback")]
		public IEnumerable<Feedback> FeedbackFeedback
		{
			get { return GetRelatedEntities<Feedback>("feedback_feedback", null); }
			set { SetRelatedEntities("feedback_feedback", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'feedback_principalobjectattributeaccess'
        /// </summary>
		[RelationshipSchemaName("feedback_principalobjectattributeaccess")]
		public IEnumerable<FieldSharing> FeedbackPrincipalobjectattributeaccess
		{
			get { return GetRelatedEntities<FieldSharing>("feedback_principalobjectattributeaccess", null); }
			set { SetRelatedEntities("feedback_principalobjectattributeaccess", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'Feedback_SyncErrors'
        /// </summary>
		[RelationshipSchemaName("Feedback_SyncErrors")]
		public IEnumerable<SyncError> FeedbackSyncErrors
		{
			get { return GetRelatedEntities<SyncError>("Feedback_SyncErrors", null); }
			set { SetRelatedEntities("Feedback_SyncErrors", null, value); }
		}
		#endregion

		#region Actions
		#endregion

		#region OptionSetEnums
		public enum eSource
		{	
		
			[Label("Internal")]
			[Description(@"")]
			Internal = 0, 
		
			[Label("Portal")]
			[Description(@"")]
			Portal = 1, 
		}
		
		public enum eState
		{	
		
			[Label("Open")]
			[Description(@"")]
			Open = 0, 
		
			[Label("Closed")]
			[Description(@"")]
			Closed = 1, 
		}
		
		public enum eStatus
		{	
		
			[Label("Proposed")]
			[Description(@"")]
			Proposed_Active = 1, 
		
			[Label("Accepted")]
			[Description(@"")]
			Accepted_Active = 2, 
		
			[Label("Closed")]
			[Description(@"")]
			Closed_Inactive = 3, 
		
			[Label("Rejected")]
			[Description(@"")]
			Rejected_Inactive = 4, 
		}
		
		#endregion	

		#region Properties
		public static class Properties 
		{
			/// <summary>closedby</summary>
			public const string ClosedBy = "closedby";

			/// <summary>closedbyname</summary>
			public const string Closedbyname = "closedbyname";

			/// <summary>closedbyyominame</summary>
			public const string Closedbyyominame = "closedbyyominame";

			/// <summary>closedon</summary>
			public const string ClosedOn = "closedon";

			/// <summary>comments</summary>
			public const string Comments = "comments";

			/// <summary>createdby</summary>
			public const string CreatedBy = "createdby";

			/// <summary>createdbycontact</summary>
			public const string CreatedByContact = "createdbycontact";

			/// <summary>createdbycontactname</summary>
			public const string Createdbycontactname = "createdbycontactname";

			/// <summary>createdbyname</summary>
			public const string Createdbyname = "createdbyname";

			/// <summary>createdbyyominame</summary>
			public const string Createdbyyominame = "createdbyyominame";

			/// <summary>createdon</summary>
			public const string CreatedOn = "createdon";

			/// <summary>createdonbehalfby</summary>
			public const string CreatedByDelegate = "createdonbehalfby";

			/// <summary>createdonbehalfbycontact</summary>
			public const string CreatedOnBelhalfByContact = "createdonbehalfbycontact";

			/// <summary>createdonbehalfbycontactname</summary>
			public const string Createdonbehalfbycontactname = "createdonbehalfbycontactname";

			/// <summary>createdonbehalfbycontactyominame</summary>
			public const string Createdonbehalfbycontactyominame = "createdonbehalfbycontactyominame";

			/// <summary>createdonbehalfbyname</summary>
			public const string Createdonbehalfbyname = "createdonbehalfbyname";

			/// <summary>createdonbehalfbyyominame</summary>
			public const string Createdonbehalfbyyominame = "createdonbehalfbyyominame";

			/// <summary>exchangerate</summary>
			public const string ExchangeRate = "exchangerate";

			/// <summary>feedbackid</summary>
			public const string FeedbackId = "feedbackid";

			/// <summary>importsequencenumber</summary>
			public const string ImportSequenceNumber = "importsequencenumber";

			/// <summary>maxrating</summary>
			public const string MaximumRating = "maxrating";

			/// <summary>minrating</summary>
			public const string MinimumRating = "minrating";

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

			/// <summary>msdyn_contextobjectid</summary>
			public const string Context = "msdyn_contextobjectid";

			/// <summary>msdyn_contextobjectidname</summary>
			public const string MsdynContextobjectidname = "msdyn_contextobjectidname";

			/// <summary>msdyn_contextobjectidtype</summary>
			public const string MsdynContextobjectidtype = "msdyn_contextobjectidtype";

			/// <summary>msdyn_contextobjectidyominame</summary>
			public const string MsdynContextobjectidyominame = "msdyn_contextobjectidyominame";

			/// <summary>normalizedrating</summary>
			public const string NormalizedRating = "normalizedrating";

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

			/// <summary>rating</summary>
			public const string Rating = "rating";

			/// <summary>regardingobjectid</summary>
			public const string Regarding = "regardingobjectid";

			/// <summary>regardingobjectidname</summary>
			public const string Regardingobjectidname = "regardingobjectidname";

			/// <summary>regardingobjectidyominame</summary>
			public const string Regardingobjectidyominame = "regardingobjectidyominame";

			/// <summary>regardingobjecttypecode</summary>
			public const string Regardingobjecttypecode = "regardingobjecttypecode";

			/// <summary>source</summary>
			public const string Source = "source";

			/// <summary>statecode</summary>
			public const string Status = "statecode";

			/// <summary>statuscode</summary>
			public const string StatusReason = "statuscode";

			/// <summary>title</summary>
			public const string Title = "title";

			/// <summary>transactioncurrencyid</summary>
			public const string Currency = "transactioncurrencyid";

			/// <summary>transactioncurrencyidname</summary>
			public const string Transactioncurrencyidname = "transactioncurrencyidname";

			/// <summary>versionnumber</summary>
			public const string VersionNumber = "versionnumber";

		}
		#endregion

		#region Schemas
		public static class Schemas 
		{
			/// <summary>1:N feedback_DuplicateBaseRecord</summary>
			public const string FeedbackDuplicateBaseRecord = "feedback_DuplicateBaseRecord";

			/// <summary>1:N feedback_DuplicateMatchingRecord</summary>
			public const string FeedbackDuplicateMatchingRecord = "feedback_DuplicateMatchingRecord";

			/// <summary>1:N feedback_feedback</summary>
			public const string FeedbackFeedback = "feedback_feedback";

			/// <summary>1:N feedback_principalobjectattributeaccess</summary>
			public const string FeedbackPrincipalobjectattributeaccess = "feedback_principalobjectattributeaccess";

			/// <summary>1:N Feedback_SyncErrors</summary>
			public const string FeedbackSyncErrors = "Feedback_SyncErrors";

		}
		#endregion
	}
}

