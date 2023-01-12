using System;
using System.Linq;
using System.Diagnostics;
using System.ComponentModel;
using Microsoft.Xrm.Sdk; 
using Microsoft.Xrm.Sdk.Client;
using System.Collections.Generic;

namespace PentaWork.Xrm.Scheduler.Proxies.Entities
{
	[DebuggerDisplay("{ProfileName}")] 	
	[EntityLogicalName("socialprofile")]
	public sealed class SocialProfile : Entity
	{	
		public static readonly int? EntityTypeCode = 99;
		public new const string LogicalName = "socialprofile";
		public const string PrimaryIdAttribute = "socialprofileid";
		public const string PrimaryNameAttribute = "profilename";
	
		public SocialProfile() : base("socialprofile") { }

		#region Attributes
		/// <summary>
        /// blocked
        /// </summary>
		[DisplayName("Blocked")]
		[AttributeLogicalName("blocked")]
		public bool? Blocked
		{	
			get { return GetAttributeValue<bool?>("blocked"); }
			set
			{ 
				if(value == Blocked) return;
				SetAttributeValue("blocked", value);
			}
		}	
			
		/// <summary>
        /// community
        /// </summary>
		[DisplayName("Social Channel")]
		[AttributeLogicalName("community")]
		public egSocialChannel? SocialChannel
		{	
			get 
			{ 
				var optionSetValue = GetAttributeValue<OptionSetValue>("community");
				if (optionSetValue != null) return (egSocialChannel)optionSetValue.Value;
				else return null;
			}
			set 
			{ 
				if(value == SocialChannel) return;

				OptionSetValue optionSetValue = null;
				if(value != null) optionSetValue = new OptionSetValue((int)value);
				SetAttributeValue("community", optionSetValue); 
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
        /// customerid
        /// </summary>
		[DisplayName("Customer")]
		[AttributeLogicalName("customerid")]
		public EntityReference Customer
		{	
			get { return GetAttributeValue<EntityReference>("customerid"); }
			set
			{ 
				if(value == Customer) return;
				SetAttributeValue("customerid", value);
			}
		}	
			
		/// <summary>
        /// customeridname
        /// </summary>
		[DisplayName("Parent Customer Type")]
		[AttributeLogicalName("customeridname")]
		public string ParentCustomerType
		{	
			get { return GetAttributeValue<string>("customeridname"); }
			set
			{ 
				if(value == ParentCustomerType) return;
				SetAttributeValue("customeridname", value);
			}
		}	
			
		/// <summary>
        /// customeridtype
        /// </summary>
		[DisplayName("Parent Customer Type")]
		[AttributeLogicalName("customeridtype")]
		public string ParentCustomerType2
		{	
			get { return GetAttributeValue<string>("customeridtype"); }
			set
			{ 
				if(value == ParentCustomerType2) return;
				SetAttributeValue("customeridtype", value);
			}
		}	
			
		/// <summary>
        /// customeridyominame
        /// </summary>
		[DisplayName("Parent Customer Type")]
		[AttributeLogicalName("customeridyominame")]
		public string ParentCustomerType3
		{	
			get { return GetAttributeValue<string>("customeridyominame"); }
			set
			{ 
				if(value == ParentCustomerType3) return;
				SetAttributeValue("customeridyominame", value);
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
        /// influencescore
		///
		/// Precision: 2
		/// MaxValue: 1000000000
		/// MinValue: 0
        /// </summary>
		[DisplayName("Influence Score")]
		[AttributeLogicalName("influencescore")]
		public double? InfluenceScore
		{	
			get { return GetAttributeValue<double?>("influencescore"); }
			set 
			{
				double? doubleValue = null;
				if(value != null) doubleValue = Math.Round(value.Value, 2);
				if(doubleValue == InfluenceScore) return;
				SetAttributeValue("influencescore", doubleValue);  
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
        /// profilefullname
        /// </summary>
		[DisplayName("Full Name")]
		[AttributeLogicalName("profilefullname")]
		public string FullName
		{	
			get { return GetAttributeValue<string>("profilefullname"); }
			set
			{ 
				if(value == FullName) return;
				SetAttributeValue("profilefullname", value);
			}
		}	
			
		/// <summary>
        /// profilelink
        /// </summary>
		[DisplayName("Profile Link")]
		[AttributeLogicalName("profilelink")]
		public string ProfileLink
		{	
			get { return GetAttributeValue<string>("profilelink"); }
			set
			{ 
				if(value == ProfileLink) return;
				SetAttributeValue("profilelink", value);
			}
		}	
			
		/// <summary>
        /// profilename
        /// </summary>
		[DisplayName("Profile Name")]
		[AttributeLogicalName("profilename")]
		public string ProfileName
		{	
			get { return GetAttributeValue<string>("profilename"); }
			set
			{ 
				if(value == ProfileName) return;
				SetAttributeValue("profilename", value);
			}
		}	
			
		/// <summary>
        /// socialprofileid
        /// </summary>
		[DisplayName("Social Profile ID")]
		[AttributeLogicalName("socialprofileid")]
		public override Guid Id
		{
			get => base.Id;
			set { base.Id = value; SetAttributeValue("socialprofileid", value); }
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
        /// uniqueprofileid
        /// </summary>
		[DisplayName("Unique Profile ID")]
		[AttributeLogicalName("uniqueprofileid")]
		public string UniqueProfileID
		{	
			get { return GetAttributeValue<string>("uniqueprofileid"); }
			set
			{ 
				if(value == UniqueProfileID) return;
				SetAttributeValue("uniqueprofileid", value);
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
        /// 1:N Get entities for 'SocialProfile_AsyncOperations'
        /// </summary>
		[RelationshipSchemaName("SocialProfile_AsyncOperations")]
		public IEnumerable<SystemJob> SocialProfileAsyncOperations
		{
			get { return GetRelatedEntities<SystemJob>("SocialProfile_AsyncOperations", null); }
			set { SetRelatedEntities("SocialProfile_AsyncOperations", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'socialprofile_cases'
        /// </summary>
		[RelationshipSchemaName("socialprofile_cases")]
		public IEnumerable<Case> SocialprofileCases
		{
			get { return GetRelatedEntities<Case>("socialprofile_cases", null); }
			set { SetRelatedEntities("socialprofile_cases", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'socialprofile_connections1'
        /// </summary>
		[RelationshipSchemaName("socialprofile_connections1")]
		public IEnumerable<Connection> SocialprofileConnections1
		{
			get { return GetRelatedEntities<Connection>("socialprofile_connections1", null); }
			set { SetRelatedEntities("socialprofile_connections1", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'socialprofile_connections2'
        /// </summary>
		[RelationshipSchemaName("socialprofile_connections2")]
		public IEnumerable<Connection> SocialprofileConnections2
		{
			get { return GetRelatedEntities<Connection>("socialprofile_connections2", null); }
			set { SetRelatedEntities("socialprofile_connections2", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'SocialProfile_DuplicateBaseRecord'
        /// </summary>
		[RelationshipSchemaName("SocialProfile_DuplicateBaseRecord")]
		public IEnumerable<DuplicateRecord> SocialProfileDuplicateBaseRecord
		{
			get { return GetRelatedEntities<DuplicateRecord>("SocialProfile_DuplicateBaseRecord", null); }
			set { SetRelatedEntities("SocialProfile_DuplicateBaseRecord", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'SocialProfile_DuplicateMatchingRecord'
        /// </summary>
		[RelationshipSchemaName("SocialProfile_DuplicateMatchingRecord")]
		public IEnumerable<DuplicateRecord> SocialProfileDuplicateMatchingRecord
		{
			get { return GetRelatedEntities<DuplicateRecord>("SocialProfile_DuplicateMatchingRecord", null); }
			set { SetRelatedEntities("SocialProfile_DuplicateMatchingRecord", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'socialprofile_principalobjectattributeaccess'
        /// </summary>
		[RelationshipSchemaName("socialprofile_principalobjectattributeaccess")]
		public IEnumerable<FieldSharing> SocialprofilePrincipalobjectattributeaccess
		{
			get { return GetRelatedEntities<FieldSharing>("socialprofile_principalobjectattributeaccess", null); }
			set { SetRelatedEntities("socialprofile_principalobjectattributeaccess", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'SocialProfile_ProcessSessions'
        /// </summary>
		[RelationshipSchemaName("SocialProfile_ProcessSessions")]
		public IEnumerable<ProcessSession> SocialProfileProcessSessions
		{
			get { return GetRelatedEntities<ProcessSession>("SocialProfile_ProcessSessions", null); }
			set { SetRelatedEntities("SocialProfile_ProcessSessions", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'Socialprofile_SocialActivities'
        /// </summary>
		[RelationshipSchemaName("Socialprofile_SocialActivities")]
		public IEnumerable<SocialActivity> SocialprofileSocialActivities
		{
			get { return GetRelatedEntities<SocialActivity>("Socialprofile_SocialActivities", null); }
			set { SetRelatedEntities("Socialprofile_SocialActivities", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'SocialProfile_SyncErrors'
        /// </summary>
		[RelationshipSchemaName("SocialProfile_SyncErrors")]
		public IEnumerable<SyncError> SocialProfileSyncErrors
		{
			get { return GetRelatedEntities<SyncError>("SocialProfile_SyncErrors", null); }
			set { SetRelatedEntities("SocialProfile_SyncErrors", null, value); }
		}
		#endregion

		#region Actions
		#endregion

		#region OptionSetEnums
		public enum egSocialChannel
		{	
		
			[Label("Facebook")]
			[Description(@"Facebook item.")]
			Facebook = 1, 
		
			[Label("Twitter")]
			[Description(@"Twitter.")]
			Twitter = 2, 
		
			[Label("Other")]
			[Description(@"Other default")]
			Other = 0, 
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
			/// <summary>blocked</summary>
			public const string Blocked = "blocked";

			/// <summary>community</summary>
			public const string SocialChannel = "community";

			/// <summary>createdby</summary>
			public const string CreatedBy = "createdby";

			/// <summary>createdon</summary>
			public const string CreatedOn = "createdon";

			/// <summary>createdonbehalfby</summary>
			public const string CreatedByDelegate = "createdonbehalfby";

			/// <summary>createdonbehalfbyname</summary>
			public const string Createdonbehalfbyname = "createdonbehalfbyname";

			/// <summary>createdonbehalfbyyominame</summary>
			public const string Createdonbehalfbyyominame = "createdonbehalfbyyominame";

			/// <summary>customerid</summary>
			public const string Customer = "customerid";

			/// <summary>customeridname</summary>
			public const string ParentCustomerType = "customeridname";

			/// <summary>customeridtype</summary>
			public const string ParentCustomerType2 = "customeridtype";

			/// <summary>customeridyominame</summary>
			public const string ParentCustomerType3 = "customeridyominame";

			/// <summary>exchangerate</summary>
			public const string ExchangeRate = "exchangerate";

			/// <summary>importsequencenumber</summary>
			public const string ImportSequenceNumber = "importsequencenumber";

			/// <summary>influencescore</summary>
			public const string InfluenceScore = "influencescore";

			/// <summary>modifiedby</summary>
			public const string ModifiedBy = "modifiedby";

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

			/// <summary>profilefullname</summary>
			public const string FullName = "profilefullname";

			/// <summary>profilelink</summary>
			public const string ProfileLink = "profilelink";

			/// <summary>profilename</summary>
			public const string ProfileName = "profilename";

			/// <summary>socialprofileid</summary>
			public const string SocialProfileId = "socialprofileid";

			/// <summary>statecode</summary>
			public const string Status = "statecode";

			/// <summary>statuscode</summary>
			public const string StatusReason = "statuscode";

			/// <summary>timezoneruleversionnumber</summary>
			public const string TimeZoneRuleVersionNumber = "timezoneruleversionnumber";

			/// <summary>transactioncurrencyid</summary>
			public const string Currency = "transactioncurrencyid";

			/// <summary>transactioncurrencyidname</summary>
			public const string Transactioncurrencyidname = "transactioncurrencyidname";

			/// <summary>uniqueprofileid</summary>
			public const string UniqueProfileID = "uniqueprofileid";

			/// <summary>utcconversiontimezonecode</summary>
			public const string UTCConversionTimeZoneCode = "utcconversiontimezonecode";

			/// <summary>versionnumber</summary>
			public const string VersionNumber = "versionnumber";

		}
		#endregion

		#region Schemas
		public static class Schemas 
		{
			/// <summary>1:N SocialProfile_AsyncOperations</summary>
			public const string SocialProfileAsyncOperations = "SocialProfile_AsyncOperations";

			/// <summary>1:N socialprofile_cases</summary>
			public const string SocialprofileCases = "socialprofile_cases";

			/// <summary>1:N socialprofile_connections1</summary>
			public const string SocialprofileConnections1 = "socialprofile_connections1";

			/// <summary>1:N socialprofile_connections2</summary>
			public const string SocialprofileConnections2 = "socialprofile_connections2";

			/// <summary>1:N SocialProfile_DuplicateBaseRecord</summary>
			public const string SocialProfileDuplicateBaseRecord = "SocialProfile_DuplicateBaseRecord";

			/// <summary>1:N SocialProfile_DuplicateMatchingRecord</summary>
			public const string SocialProfileDuplicateMatchingRecord = "SocialProfile_DuplicateMatchingRecord";

			/// <summary>1:N socialprofile_principalobjectattributeaccess</summary>
			public const string SocialprofilePrincipalobjectattributeaccess = "socialprofile_principalobjectattributeaccess";

			/// <summary>1:N SocialProfile_ProcessSessions</summary>
			public const string SocialProfileProcessSessions = "SocialProfile_ProcessSessions";

			/// <summary>1:N Socialprofile_SocialActivities</summary>
			public const string SocialprofileSocialActivities = "Socialprofile_SocialActivities";

			/// <summary>1:N SocialProfile_SyncErrors</summary>
			public const string SocialProfileSyncErrors = "SocialProfile_SyncErrors";

		}
		#endregion
	}
}

