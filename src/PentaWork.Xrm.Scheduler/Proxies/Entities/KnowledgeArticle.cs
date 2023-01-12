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
	[EntityLogicalName("knowledgearticle")]
	public sealed class KnowledgeArticle : Entity
	{	
		public static readonly int? EntityTypeCode = 9953;
		public new const string LogicalName = "knowledgearticle";
		public const string PrimaryIdAttribute = "knowledgearticleid";
		public const string PrimaryNameAttribute = "title";
	
		public KnowledgeArticle() : base("knowledgearticle") { }

		#region Attributes
		/// <summary>
        /// articlepublicnumber
        /// </summary>
		[DisplayName("Article Public Number")]
		[AttributeLogicalName("articlepublicnumber")]
		public string ArticlePublicNumber
		{	
			get { return GetAttributeValue<string>("articlepublicnumber"); }
			set
			{ 
				if(value == ArticlePublicNumber) return;
				SetAttributeValue("articlepublicnumber", value);
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
        /// exchangerate
		///
		/// Precision: 10
		/// MaxValue: 100000000000
		/// MinValue: 0.0000000001
        /// </summary>
		[DisplayName("ExchangeRate")]
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
        /// expirationdate
        /// </summary>
		[DisplayName("Expiration Date")]
		[AttributeLogicalName("expirationdate")]
		public DateTime? ExpirationDate
		{	
			get { return GetAttributeValue<DateTime?>("expirationdate"); }
			set
			{ 
				if(value == ExpirationDate) return;
				SetAttributeValue("expirationdate", value);
			}
		}	
			
		/// <summary>
        /// expirationstateid
        /// </summary>
		[DisplayName("Expiration State Id")]
		[AttributeLogicalName("expirationstateid")]
		public int? ExpirationStateId
		{	
			get { return GetAttributeValue<int?>("expirationstateid"); }
			set
			{ 
				if(value == ExpirationStateId) return;
				SetAttributeValue("expirationstateid", value);
			}
		}	
			
		/// <summary>
        /// expirationstatusid
        /// </summary>
		[DisplayName("Expired Status")]
		[AttributeLogicalName("expirationstatusid")]
		public int? ExpiredStatus
		{	
			get { return GetAttributeValue<int?>("expirationstatusid"); }
			set
			{ 
				if(value == ExpiredStatus) return;
				SetAttributeValue("expirationstatusid", value);
			}
		}	
			
		/// <summary>
        /// expiredreviewoptions
        /// </summary>
		[DisplayName("Expired Review Options")]
		[AttributeLogicalName("expiredreviewoptions")]
		public eExpiredReviewOptions? ExpiredReviewOptions
		{	
			get 
			{ 
				var optionSetValue = GetAttributeValue<OptionSetValue>("expiredreviewoptions");
				if (optionSetValue != null) return (eExpiredReviewOptions)optionSetValue.Value;
				else return null;
			}
			set 
			{ 
				if(value == ExpiredReviewOptions) return;

				OptionSetValue optionSetValue = null;
				if(value != null) optionSetValue = new OptionSetValue((int)value);
				SetAttributeValue("expiredreviewoptions", optionSetValue); 
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
        /// isinternal
        /// </summary>
		[DisplayName("Internal")]
		[AttributeLogicalName("isinternal")]
		public bool? Internal
		{	
			get { return GetAttributeValue<bool?>("isinternal"); }
			set
			{ 
				if(value == Internal) return;
				SetAttributeValue("isinternal", value);
			}
		}	
			
		/// <summary>
        /// islatestversion
        /// </summary>
		[DisplayName("Is Latest Version")]
		[AttributeLogicalName("islatestversion")]
		public bool? IsLatestVersion
		{	
			get { return GetAttributeValue<bool?>("islatestversion"); }
			set
			{ 
				if(value == IsLatestVersion) return;
				SetAttributeValue("islatestversion", value);
			}
		}	
			
		/// <summary>
        /// isprimary
        /// </summary>
		[DisplayName("Primary Article")]
		[AttributeLogicalName("isprimary")]
		public bool? PrimaryArticle
		{	
			get { return GetAttributeValue<bool?>("isprimary"); }
			set
			{ 
				if(value == PrimaryArticle) return;
				SetAttributeValue("isprimary", value);
			}
		}	
			
		/// <summary>
        /// isrootarticle
        /// </summary>
		[DisplayName("Root Article")]
		[AttributeLogicalName("isrootarticle")]
		public bool? RootArticle
		{	
			get { return GetAttributeValue<bool?>("isrootarticle"); }
			set
			{ 
				if(value == RootArticle) return;
				SetAttributeValue("isrootarticle", value);
			}
		}	
			
		/// <summary>
        /// keywords
        /// </summary>
		[DisplayName("Keywords")]
		[AttributeLogicalName("keywords")]
		public string Keywords
		{	
			get { return GetAttributeValue<string>("keywords"); }
			set
			{ 
				if(value == Keywords) return;
				SetAttributeValue("keywords", value);
			}
		}	
			
		/// <summary>
        /// knowledgearticleid
        /// </summary>
		[DisplayName("Knowledge Article")]
		[AttributeLogicalName("knowledgearticleid")]
		public override Guid Id
		{
			get => base.Id;
			set { base.Id = value; SetAttributeValue("knowledgearticleid", value); }
		}

							/// <summary>
        /// knowledgearticleviews
        /// </summary>
		[DisplayName("Knowledge Article Views")]
		[AttributeLogicalName("knowledgearticleviews")]
		public int? KnowledgeArticleViews
		{	
			get { return GetAttributeValue<int?>("knowledgearticleviews"); }
			set
			{ 
				if(value == KnowledgeArticleViews) return;
				SetAttributeValue("knowledgearticleviews", value);
			}
		}	
			
		/// <summary>
        /// knowledgearticleviews_date
        /// </summary>
		[DisplayName("Knowledge Article View(Last Updated Time)")]
		[AttributeLogicalName("knowledgearticleviews_date")]
		public DateTime? KnowledgeArticleViewLastUpdatedTime
		{	
			get { return GetAttributeValue<DateTime?>("knowledgearticleviews_date"); }
			set
			{ 
				if(value == KnowledgeArticleViewLastUpdatedTime) return;
				SetAttributeValue("knowledgearticleviews_date", value);
			}
		}	
			
		/// <summary>
        /// knowledgearticleviews_state
        /// </summary>
		[DisplayName("Knowledge Article View(State)")]
		[AttributeLogicalName("knowledgearticleviews_state")]
		public int? KnowledgeArticleViewState
		{	
			get { return GetAttributeValue<int?>("knowledgearticleviews_state"); }
			set
			{ 
				if(value == KnowledgeArticleViewState) return;
				SetAttributeValue("knowledgearticleviews_state", value);
			}
		}	
			
		/// <summary>
        /// languagelocaleid
        /// </summary>
		[DisplayName("Language")]
		[AttributeLogicalName("languagelocaleid")]
		public EntityReference Language
		{	
			get { return GetAttributeValue<EntityReference>("languagelocaleid"); }
			set
			{ 
				if(value == Language) return;
				SetAttributeValue("languagelocaleid", value);
			}
		}	
			
		/// <summary>
        /// languagelocaleidlocaleid
        /// </summary>
		[DisplayName("languagelocaleidlocaleid")]
		[AttributeLogicalName("languagelocaleidlocaleid")]
		public int? Languagelocaleidlocaleid
		{	
			get { return GetAttributeValue<int?>("languagelocaleidlocaleid"); }
			set
			{ 
				if(value == Languagelocaleidlocaleid) return;
				SetAttributeValue("languagelocaleidlocaleid", value);
			}
		}	
			
		/// <summary>
        /// languagelocaleidname
        /// </summary>
		[DisplayName("languagelocaleidname")]
		[AttributeLogicalName("languagelocaleidname")]
		public string Languagelocaleidname
		{	
			get { return GetAttributeValue<string>("languagelocaleidname"); }
			set
			{ 
				if(value == Languagelocaleidname) return;
				SetAttributeValue("languagelocaleidname", value);
			}
		}	
			
		/// <summary>
        /// majorversionnumber
        /// </summary>
		[DisplayName("Major Version Number")]
		[AttributeLogicalName("majorversionnumber")]
		public int? MajorVersionNumber
		{	
			get { return GetAttributeValue<int?>("majorversionnumber"); }
			set
			{ 
				if(value == MajorVersionNumber) return;
				SetAttributeValue("majorversionnumber", value);
			}
		}	
			
		/// <summary>
        /// minorversionnumber
        /// </summary>
		[DisplayName("Minor Version Number")]
		[AttributeLogicalName("minorversionnumber")]
		public int? MinorVersionNumber
		{	
			get { return GetAttributeValue<int?>("minorversionnumber"); }
			set
			{ 
				if(value == MinorVersionNumber) return;
				SetAttributeValue("minorversionnumber", value);
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
        /// parentarticlecontentid
        /// </summary>
		[DisplayName("Parent Article Content Id")]
		[AttributeLogicalName("parentarticlecontentid")]
		public EntityReference ParentArticleContentId
		{	
			get { return GetAttributeValue<EntityReference>("parentarticlecontentid"); }
			set
			{ 
				if(value == ParentArticleContentId) return;
				SetAttributeValue("parentarticlecontentid", value);
			}
		}	
			
		/// <summary>
        /// parentarticlecontentidname
        /// </summary>
		[DisplayName("parentarticlecontentidname")]
		[AttributeLogicalName("parentarticlecontentidname")]
		public string Parentarticlecontentidname
		{	
			get { return GetAttributeValue<string>("parentarticlecontentidname"); }
			set
			{ 
				if(value == Parentarticlecontentidname) return;
				SetAttributeValue("parentarticlecontentidname", value);
			}
		}	
			
		/// <summary>
        /// previousarticlecontentid
        /// </summary>
		[DisplayName("Previous Article Content ID")]
		[AttributeLogicalName("previousarticlecontentid")]
		public EntityReference PreviousArticleContentID
		{	
			get { return GetAttributeValue<EntityReference>("previousarticlecontentid"); }
			set
			{ 
				if(value == PreviousArticleContentID) return;
				SetAttributeValue("previousarticlecontentid", value);
			}
		}	
			
		/// <summary>
        /// previousarticlecontentidname
        /// </summary>
		[DisplayName("previousarticlecontentidname")]
		[AttributeLogicalName("previousarticlecontentidname")]
		public string Previousarticlecontentidname
		{	
			get { return GetAttributeValue<string>("previousarticlecontentidname"); }
			set
			{ 
				if(value == Previousarticlecontentidname) return;
				SetAttributeValue("previousarticlecontentidname", value);
			}
		}	
			
		/// <summary>
        /// primaryauthorid
        /// </summary>
		[DisplayName("Primary Author Id")]
		[AttributeLogicalName("primaryauthorid")]
		public EntityReference PrimaryAuthorId
		{	
			get { return GetAttributeValue<EntityReference>("primaryauthorid"); }
			set
			{ 
				if(value == PrimaryAuthorId) return;
				SetAttributeValue("primaryauthorid", value);
			}
		}	
			
		/// <summary>
        /// primaryauthoridname
        /// </summary>
		[DisplayName("primaryauthoridname")]
		[AttributeLogicalName("primaryauthoridname")]
		public string Primaryauthoridname
		{	
			get { return GetAttributeValue<string>("primaryauthoridname"); }
			set
			{ 
				if(value == Primaryauthoridname) return;
				SetAttributeValue("primaryauthoridname", value);
			}
		}	
			
		/// <summary>
        /// processid
        /// </summary>
		[DisplayName("Process Id")]
		[AttributeLogicalName("processid")]
		public Guid ProcessId
		{	
			get { return GetAttributeValue<Guid>("processid"); }
			set
			{ 
				if(value == ProcessId) return;
				SetAttributeValue("processid", value);
			}
		}	
			
		/// <summary>
        /// publishon
        /// </summary>
		[DisplayName("Publish On")]
		[AttributeLogicalName("publishon")]
		public DateTime? PublishOn
		{	
			get { return GetAttributeValue<DateTime?>("publishon"); }
			set
			{ 
				if(value == PublishOn) return;
				SetAttributeValue("publishon", value);
			}
		}	
			
		/// <summary>
        /// publishstatusid
        /// </summary>
		[DisplayName("Published Status")]
		[AttributeLogicalName("publishstatusid")]
		public int? PublishedStatus
		{	
			get { return GetAttributeValue<int?>("publishstatusid"); }
			set
			{ 
				if(value == PublishedStatus) return;
				SetAttributeValue("publishstatusid", value);
			}
		}	
			
		/// <summary>
        /// rating
		///
		/// Precision: 2
		/// MaxValue: 100000000000
		/// MinValue: -100000000000
        /// </summary>
		[DisplayName("Rating")]
		[AttributeLogicalName("rating")]
		public decimal? Rating
		{	
			get { return GetAttributeValue<decimal?>("rating"); }
			set 
			{
				decimal? decimalValue = null;
				if(value != null) decimalValue = Decimal.Round(value.Value, 2);
				if(decimalValue == Rating) return;
				SetAttributeValue("rating", decimalValue);  
			}
		}

		/// <summary>
        /// rating_count
        /// </summary>
		[DisplayName("Rating(Count)")]
		[AttributeLogicalName("rating_count")]
		public int? RatingCount
		{	
			get { return GetAttributeValue<int?>("rating_count"); }
			set
			{ 
				if(value == RatingCount) return;
				SetAttributeValue("rating_count", value);
			}
		}	
			
		/// <summary>
        /// rating_date
        /// </summary>
		[DisplayName("Rating(Last Updated Time)")]
		[AttributeLogicalName("rating_date")]
		public DateTime? RatingLastUpdatedTime
		{	
			get { return GetAttributeValue<DateTime?>("rating_date"); }
			set
			{ 
				if(value == RatingLastUpdatedTime) return;
				SetAttributeValue("rating_date", value);
			}
		}	
			
		/// <summary>
        /// rating_state
        /// </summary>
		[DisplayName("Rating(State)")]
		[AttributeLogicalName("rating_state")]
		public int? RatingState
		{	
			get { return GetAttributeValue<int?>("rating_state"); }
			set
			{ 
				if(value == RatingState) return;
				SetAttributeValue("rating_state", value);
			}
		}	
			
		/// <summary>
        /// rating_sum
		///
		/// Precision: 2
		/// MaxValue: 1000000000
		/// MinValue: 0
        /// </summary>
		[DisplayName("Rating(sum)")]
		[AttributeLogicalName("rating_sum")]
		public decimal? Ratingsum
		{	
			get { return GetAttributeValue<decimal?>("rating_sum"); }
			set 
			{
				decimal? decimalValue = null;
				if(value != null) decimalValue = Decimal.Round(value.Value, 2);
				if(decimalValue == Ratingsum) return;
				SetAttributeValue("rating_sum", decimalValue);  
			}
		}

		/// <summary>
        /// readyforreview
        /// </summary>
		[DisplayName("Ready For Review")]
		[AttributeLogicalName("readyforreview")]
		public bool? ReadyForReview
		{	
			get { return GetAttributeValue<bool?>("readyforreview"); }
			set
			{ 
				if(value == ReadyForReview) return;
				SetAttributeValue("readyforreview", value);
			}
		}	
			
		/// <summary>
        /// review
        /// </summary>
		[DisplayName("Review")]
		[AttributeLogicalName("review")]
		public eReview? Review
		{	
			get 
			{ 
				var optionSetValue = GetAttributeValue<OptionSetValue>("review");
				if (optionSetValue != null) return (eReview)optionSetValue.Value;
				else return null;
			}
			set 
			{ 
				if(value == Review) return;

				OptionSetValue optionSetValue = null;
				if(value != null) optionSetValue = new OptionSetValue((int)value);
				SetAttributeValue("review", optionSetValue); 
			}
		}

		/// <summary>
        /// rootarticleid
        /// </summary>
		[DisplayName("Root Article Id")]
		[AttributeLogicalName("rootarticleid")]
		public EntityReference RootArticleId
		{	
			get { return GetAttributeValue<EntityReference>("rootarticleid"); }
			set
			{ 
				if(value == RootArticleId) return;
				SetAttributeValue("rootarticleid", value);
			}
		}	
			
		/// <summary>
        /// rootarticleidname
        /// </summary>
		[DisplayName("rootarticleidname")]
		[AttributeLogicalName("rootarticleidname")]
		public string Rootarticleidname
		{	
			get { return GetAttributeValue<string>("rootarticleidname"); }
			set
			{ 
				if(value == Rootarticleidname) return;
				SetAttributeValue("rootarticleidname", value);
			}
		}	
			
		/// <summary>
        /// scheduledstatusid
        /// </summary>
		[DisplayName("Scheduled Status")]
		[AttributeLogicalName("scheduledstatusid")]
		public int? ScheduledStatus
		{	
			get { return GetAttributeValue<int?>("scheduledstatusid"); }
			set
			{ 
				if(value == ScheduledStatus) return;
				SetAttributeValue("scheduledstatusid", value);
			}
		}	
			
		/// <summary>
        /// setcategoryassociations
        /// </summary>
		[DisplayName("Set Category Associations")]
		[AttributeLogicalName("setcategoryassociations")]
		public bool? SetCategoryAssociations
		{	
			get { return GetAttributeValue<bool?>("setcategoryassociations"); }
			set
			{ 
				if(value == SetCategoryAssociations) return;
				SetAttributeValue("setcategoryassociations", value);
			}
		}	
			
		/// <summary>
        /// setproductassociations
        /// </summary>
		[DisplayName("Set Product Associations")]
		[AttributeLogicalName("setproductassociations")]
		public bool? SetProductAssociations
		{	
			get { return GetAttributeValue<bool?>("setproductassociations"); }
			set
			{ 
				if(value == SetProductAssociations) return;
				SetAttributeValue("setproductassociations", value);
			}
		}	
			
		/// <summary>
        /// stageid
        /// </summary>
		[DisplayName("Stage Id")]
		[AttributeLogicalName("stageid")]
		public Guid StageId
		{	
			get { return GetAttributeValue<Guid>("stageid"); }
			set
			{ 
				if(value == StageId) return;
				SetAttributeValue("stageid", value);
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
        /// subjectid
        /// </summary>
		[DisplayName("Subject")]
		[AttributeLogicalName("subjectid")]
		public EntityReference Subject
		{	
			get { return GetAttributeValue<EntityReference>("subjectid"); }
			set
			{ 
				if(value == Subject) return;
				SetAttributeValue("subjectid", value);
			}
		}	
			
		/// <summary>
        /// subjectiddsc
        /// </summary>
		[DisplayName("subjectiddsc")]
		[AttributeLogicalName("subjectiddsc")]
		public int? Subjectiddsc
		{	
			get { return GetAttributeValue<int?>("subjectiddsc"); }
			set
			{ 
				if(value == Subjectiddsc) return;
				SetAttributeValue("subjectiddsc", value);
			}
		}	
			
		/// <summary>
        /// subjectidname
        /// </summary>
		[DisplayName("subjectidname")]
		[AttributeLogicalName("subjectidname")]
		public string Subjectidname
		{	
			get { return GetAttributeValue<string>("subjectidname"); }
			set
			{ 
				if(value == Subjectidname) return;
				SetAttributeValue("subjectidname", value);
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
        /// traversedpath
        /// </summary>
		[DisplayName("(Deprecated) Traversed Path")]
		[AttributeLogicalName("traversedpath")]
		public string DeprecatedTraversedPath
		{	
			get { return GetAttributeValue<string>("traversedpath"); }
			set
			{ 
				if(value == DeprecatedTraversedPath) return;
				SetAttributeValue("traversedpath", value);
			}
		}	
			
		/// <summary>
        /// updatecontent
        /// </summary>
		[DisplayName("Update Content")]
		[AttributeLogicalName("updatecontent")]
		public bool? UpdateContent
		{	
			get { return GetAttributeValue<bool?>("updatecontent"); }
			set
			{ 
				if(value == UpdateContent) return;
				SetAttributeValue("updatecontent", value);
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
			
		#endregion	

		#region Relations
			/// <summary>
        /// 1:N Get entities for 'incident_knowledgearticles'
        /// </summary>
		[RelationshipSchemaName("incident_knowledgearticles")]
		public IEnumerable<KnowledgeArticleIncident> IncidentKnowledgearticles
		{
			get { return GetRelatedEntities<KnowledgeArticleIncident>("incident_knowledgearticles", null); }
			set { SetRelatedEntities("incident_knowledgearticles", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'knowledgearticle_activity_parties'
        /// </summary>
		[RelationshipSchemaName("knowledgearticle_activity_parties")]
		public IEnumerable<ActivityParty> KnowledgearticleActivityParties
		{
			get { return GetRelatedEntities<ActivityParty>("knowledgearticle_activity_parties", null); }
			set { SetRelatedEntities("knowledgearticle_activity_parties", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'KnowledgeArticle_ActivityPointers'
        /// </summary>
		[RelationshipSchemaName("KnowledgeArticle_ActivityPointers")]
		public IEnumerable<Activity> KnowledgeArticleActivityPointers
		{
			get { return GetRelatedEntities<Activity>("KnowledgeArticle_ActivityPointers", null); }
			set { SetRelatedEntities("KnowledgeArticle_ActivityPointers", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'knowledgearticle_Annotations'
        /// </summary>
		[RelationshipSchemaName("knowledgearticle_Annotations")]
		public IEnumerable<Note> KnowledgearticleAnnotations
		{
			get { return GetRelatedEntities<Note>("knowledgearticle_Annotations", null); }
			set { SetRelatedEntities("knowledgearticle_Annotations", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'KnowledgeArticle_Appointments'
        /// </summary>
		[RelationshipSchemaName("KnowledgeArticle_Appointments")]
		public IEnumerable<Appointment> KnowledgeArticleAppointments
		{
			get { return GetRelatedEntities<Appointment>("KnowledgeArticle_Appointments", null); }
			set { SetRelatedEntities("KnowledgeArticle_Appointments", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'knowledgearticle_AsyncOperations'
        /// </summary>
		[RelationshipSchemaName("knowledgearticle_AsyncOperations")]
		public IEnumerable<SystemJob> KnowledgearticleAsyncOperations
		{
			get { return GetRelatedEntities<SystemJob>("knowledgearticle_AsyncOperations", null); }
			set { SetRelatedEntities("knowledgearticle_AsyncOperations", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'knowledgearticle_BulkDeleteFailures'
        /// </summary>
		[RelationshipSchemaName("knowledgearticle_BulkDeleteFailures")]
		public IEnumerable<BulkDeleteFailure> KnowledgearticleBulkDeleteFailures
		{
			get { return GetRelatedEntities<BulkDeleteFailure>("knowledgearticle_BulkDeleteFailures", null); }
			set { SetRelatedEntities("knowledgearticle_BulkDeleteFailures", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'knowledgearticle_BulkOperations'
        /// </summary>
		[RelationshipSchemaName("knowledgearticle_BulkOperations")]
		public IEnumerable<QuickCampaign> KnowledgearticleBulkOperations
		{
			get { return GetRelatedEntities<QuickCampaign>("knowledgearticle_BulkOperations", null); }
			set { SetRelatedEntities("knowledgearticle_BulkOperations", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'knowledgearticle_CampaignResponses'
        /// </summary>
		[RelationshipSchemaName("knowledgearticle_CampaignResponses")]
		public IEnumerable<CampaignResponse> KnowledgearticleCampaignResponses
		{
			get { return GetRelatedEntities<CampaignResponse>("knowledgearticle_CampaignResponses", null); }
			set { SetRelatedEntities("knowledgearticle_CampaignResponses", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'knowledgearticle_connections1'
        /// </summary>
		[RelationshipSchemaName("knowledgearticle_connections1")]
		public IEnumerable<Connection> KnowledgearticleConnections1
		{
			get { return GetRelatedEntities<Connection>("knowledgearticle_connections1", null); }
			set { SetRelatedEntities("knowledgearticle_connections1", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'knowledgearticle_connections2'
        /// </summary>
		[RelationshipSchemaName("knowledgearticle_connections2")]
		public IEnumerable<Connection> KnowledgearticleConnections2
		{
			get { return GetRelatedEntities<Connection>("knowledgearticle_connections2", null); }
			set { SetRelatedEntities("knowledgearticle_connections2", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'knowledgearticle_DuplicateBaseRecord'
        /// </summary>
		[RelationshipSchemaName("knowledgearticle_DuplicateBaseRecord")]
		public IEnumerable<DuplicateRecord> KnowledgearticleDuplicateBaseRecord
		{
			get { return GetRelatedEntities<DuplicateRecord>("knowledgearticle_DuplicateBaseRecord", null); }
			set { SetRelatedEntities("knowledgearticle_DuplicateBaseRecord", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'knowledgearticle_DuplicateMatchingRecord'
        /// </summary>
		[RelationshipSchemaName("knowledgearticle_DuplicateMatchingRecord")]
		public IEnumerable<DuplicateRecord> KnowledgearticleDuplicateMatchingRecord
		{
			get { return GetRelatedEntities<DuplicateRecord>("knowledgearticle_DuplicateMatchingRecord", null); }
			set { SetRelatedEntities("knowledgearticle_DuplicateMatchingRecord", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'KnowledgeArticle_Emails'
        /// </summary>
		[RelationshipSchemaName("KnowledgeArticle_Emails")]
		public IEnumerable<Email> KnowledgeArticleEmails
		{
			get { return GetRelatedEntities<Email>("KnowledgeArticle_Emails", null); }
			set { SetRelatedEntities("KnowledgeArticle_Emails", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'KnowledgeArticle_Faxes'
        /// </summary>
		[RelationshipSchemaName("KnowledgeArticle_Faxes")]
		public IEnumerable<Fax> KnowledgeArticleFaxes
		{
			get { return GetRelatedEntities<Fax>("KnowledgeArticle_Faxes", null); }
			set { SetRelatedEntities("KnowledgeArticle_Faxes", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'KnowledgeArticle_Feedback'
        /// </summary>
		[RelationshipSchemaName("KnowledgeArticle_Feedback")]
		public IEnumerable<Feedback> KnowledgeArticleFeedback
		{
			get { return GetRelatedEntities<Feedback>("KnowledgeArticle_Feedback", null); }
			set { SetRelatedEntities("KnowledgeArticle_Feedback", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'knowledgearticle_IncidentResolutions'
        /// </summary>
		[RelationshipSchemaName("knowledgearticle_IncidentResolutions")]
		public IEnumerable<CaseResolution> KnowledgearticleIncidentResolutions
		{
			get { return GetRelatedEntities<CaseResolution>("knowledgearticle_IncidentResolutions", null); }
			set { SetRelatedEntities("knowledgearticle_IncidentResolutions", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'KnowledgeArticle_Letters'
        /// </summary>
		[RelationshipSchemaName("KnowledgeArticle_Letters")]
		public IEnumerable<Letter> KnowledgeArticleLetters
		{
			get { return GetRelatedEntities<Letter>("KnowledgeArticle_Letters", null); }
			set { SetRelatedEntities("KnowledgeArticle_Letters", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'knowledgearticle_OpportunityCloses'
        /// </summary>
		[RelationshipSchemaName("knowledgearticle_OpportunityCloses")]
		public IEnumerable<OpportunityClose> KnowledgearticleOpportunityCloses
		{
			get { return GetRelatedEntities<OpportunityClose>("knowledgearticle_OpportunityCloses", null); }
			set { SetRelatedEntities("knowledgearticle_OpportunityCloses", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'knowledgearticle_OrderCloses'
        /// </summary>
		[RelationshipSchemaName("knowledgearticle_OrderCloses")]
		public IEnumerable<OrderClose> KnowledgearticleOrderCloses
		{
			get { return GetRelatedEntities<OrderClose>("knowledgearticle_OrderCloses", null); }
			set { SetRelatedEntities("knowledgearticle_OrderCloses", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'knowledgearticle_parentarticle_contentid'
        /// </summary>
		[RelationshipSchemaName("knowledgearticle_parentarticle_contentid")]
		public IEnumerable<KnowledgeArticle> KnowledgearticleParentarticleContentid
		{
			get { return GetRelatedEntities<KnowledgeArticle>("knowledgearticle_parentarticle_contentid", null); }
			set { SetRelatedEntities("knowledgearticle_parentarticle_contentid", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'KnowledgeArticle_Phonecalls'
        /// </summary>
		[RelationshipSchemaName("KnowledgeArticle_Phonecalls")]
		public IEnumerable<PhoneCall> KnowledgeArticlePhonecalls
		{
			get { return GetRelatedEntities<PhoneCall>("KnowledgeArticle_Phonecalls", null); }
			set { SetRelatedEntities("KnowledgeArticle_Phonecalls", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'knowledgearticle_PostFollows'
        /// </summary>
		[RelationshipSchemaName("knowledgearticle_PostFollows")]
		public IEnumerable<Follow> KnowledgearticlePostFollows
		{
			get { return GetRelatedEntities<Follow>("knowledgearticle_PostFollows", null); }
			set { SetRelatedEntities("knowledgearticle_PostFollows", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'knowledgearticle_previousarticle_contentid'
        /// </summary>
		[RelationshipSchemaName("knowledgearticle_previousarticle_contentid")]
		public IEnumerable<KnowledgeArticle> KnowledgearticlePreviousarticleContentid
		{
			get { return GetRelatedEntities<KnowledgeArticle>("knowledgearticle_previousarticle_contentid", null); }
			set { SetRelatedEntities("knowledgearticle_previousarticle_contentid", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'knowledgearticle_PrincipalObjectAttributeAccess'
        /// </summary>
		[RelationshipSchemaName("knowledgearticle_PrincipalObjectAttributeAccess")]
		public IEnumerable<FieldSharing> KnowledgearticlePrincipalObjectAttributeAccess
		{
			get { return GetRelatedEntities<FieldSharing>("knowledgearticle_PrincipalObjectAttributeAccess", null); }
			set { SetRelatedEntities("knowledgearticle_PrincipalObjectAttributeAccess", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'knowledgearticle_ProcessSession'
        /// </summary>
		[RelationshipSchemaName("knowledgearticle_ProcessSession")]
		public IEnumerable<ProcessSession> KnowledgearticleProcessSession
		{
			get { return GetRelatedEntities<ProcessSession>("knowledgearticle_ProcessSession", null); }
			set { SetRelatedEntities("knowledgearticle_ProcessSession", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'knowledgearticle_QueueItems'
        /// </summary>
		[RelationshipSchemaName("knowledgearticle_QueueItems")]
		public IEnumerable<QueueItem> KnowledgearticleQueueItems
		{
			get { return GetRelatedEntities<QueueItem>("knowledgearticle_QueueItems", null); }
			set { SetRelatedEntities("knowledgearticle_QueueItems", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'knowledgearticle_QuoteCloses'
        /// </summary>
		[RelationshipSchemaName("knowledgearticle_QuoteCloses")]
		public IEnumerable<QuoteClose> KnowledgearticleQuoteCloses
		{
			get { return GetRelatedEntities<QuoteClose>("knowledgearticle_QuoteCloses", null); }
			set { SetRelatedEntities("knowledgearticle_QuoteCloses", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'KnowledgeArticle_RecurringAppointmentMasters'
        /// </summary>
		[RelationshipSchemaName("KnowledgeArticle_RecurringAppointmentMasters")]
		public IEnumerable<RecurringAppointment> KnowledgeArticleRecurringAppointmentMasters
		{
			get { return GetRelatedEntities<RecurringAppointment>("KnowledgeArticle_RecurringAppointmentMasters", null); }
			set { SetRelatedEntities("KnowledgeArticle_RecurringAppointmentMasters", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'knowledgearticle_rootarticle_id'
        /// </summary>
		[RelationshipSchemaName("knowledgearticle_rootarticle_id")]
		public IEnumerable<KnowledgeArticle> KnowledgearticleRootarticleId
		{
			get { return GetRelatedEntities<KnowledgeArticle>("knowledgearticle_rootarticle_id", null); }
			set { SetRelatedEntities("knowledgearticle_rootarticle_id", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'KnowledgeArticle_ServiceAppointments'
        /// </summary>
		[RelationshipSchemaName("KnowledgeArticle_ServiceAppointments")]
		public IEnumerable<ServiceActivity> KnowledgeArticleServiceAppointments
		{
			get { return GetRelatedEntities<ServiceActivity>("KnowledgeArticle_ServiceAppointments", null); }
			set { SetRelatedEntities("KnowledgeArticle_ServiceAppointments", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'knowledgearticle_SharePointDocumentLocations'
        /// </summary>
		[RelationshipSchemaName("knowledgearticle_SharePointDocumentLocations")]
		public IEnumerable<DocumentLocation> KnowledgearticleSharePointDocumentLocations
		{
			get { return GetRelatedEntities<DocumentLocation>("knowledgearticle_SharePointDocumentLocations", null); }
			set { SetRelatedEntities("knowledgearticle_SharePointDocumentLocations", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'KnowledgeArticle_SocialActivities'
        /// </summary>
		[RelationshipSchemaName("KnowledgeArticle_SocialActivities")]
		public IEnumerable<SocialActivity> KnowledgeArticleSocialActivities
		{
			get { return GetRelatedEntities<SocialActivity>("KnowledgeArticle_SocialActivities", null); }
			set { SetRelatedEntities("KnowledgeArticle_SocialActivities", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'KnowledgeArticle_SyncErrors'
        /// </summary>
		[RelationshipSchemaName("KnowledgeArticle_SyncErrors")]
		public IEnumerable<SyncError> KnowledgeArticleSyncErrors
		{
			get { return GetRelatedEntities<SyncError>("KnowledgeArticle_SyncErrors", null); }
			set { SetRelatedEntities("KnowledgeArticle_SyncErrors", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'KnowledgeArticle_Tasks'
        /// </summary>
		[RelationshipSchemaName("KnowledgeArticle_Tasks")]
		public IEnumerable<Task> KnowledgeArticleTasks
		{
			get { return GetRelatedEntities<Task>("KnowledgeArticle_Tasks", null); }
			set { SetRelatedEntities("KnowledgeArticle_Tasks", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'knowledgearticle_Teams'
        /// </summary>
		[RelationshipSchemaName("knowledgearticle_Teams")]
		public IEnumerable<Team> KnowledgearticleTeams
		{
			get { return GetRelatedEntities<Team>("knowledgearticle_Teams", null); }
			set { SetRelatedEntities("knowledgearticle_Teams", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'knowledgearticle_views'
        /// </summary>
		[RelationshipSchemaName("knowledgearticle_views")]
		public IEnumerable<KnowledgeArticleViews> KnowledgearticleViews
		{
			get { return GetRelatedEntities<KnowledgeArticleViews>("knowledgearticle_views", null); }
			set { SetRelatedEntities("knowledgearticle_views", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_expiredprocess_knowledgearticleid'
        /// </summary>
		[RelationshipSchemaName("lk_expiredprocess_knowledgearticleid")]
		public IEnumerable<ExpiredProcess> LkExpiredprocessKnowledgearticleid
		{
			get { return GetRelatedEntities<ExpiredProcess>("lk_expiredprocess_knowledgearticleid", null); }
			set { SetRelatedEntities("lk_expiredprocess_knowledgearticleid", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_newprocess_knowledgearticleid'
        /// </summary>
		[RelationshipSchemaName("lk_newprocess_knowledgearticleid")]
		public IEnumerable<NewProcess> LkNewprocessKnowledgearticleid
		{
			get { return GetRelatedEntities<NewProcess>("lk_newprocess_knowledgearticleid", null); }
			set { SetRelatedEntities("lk_newprocess_knowledgearticleid", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'lk_translationprocess_knowledgearticleid'
        /// </summary>
		[RelationshipSchemaName("lk_translationprocess_knowledgearticleid")]
		public IEnumerable<TranslationProcess> LkTranslationprocessKnowledgearticleid
		{
			get { return GetRelatedEntities<TranslationProcess>("lk_translationprocess_knowledgearticleid", null); }
			set { SetRelatedEntities("lk_translationprocess_knowledgearticleid", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'msdyn_knowledgearticle_feedback_context'
        /// </summary>
		[RelationshipSchemaName("msdyn_knowledgearticle_feedback_context")]
		public IEnumerable<Feedback> MsdynKnowledgearticleFeedbackContext
		{
			get { return GetRelatedEntities<Feedback>("msdyn_knowledgearticle_feedback_context", null); }
			set { SetRelatedEntities("msdyn_knowledgearticle_feedback_context", null, value); }
		}
		/// <summary>
        /// N:N Get entities for 'Category'
        /// </summary>
		[RelationshipSchemaName("knowledgearticle_category")]
		public IEnumerable<Category> KnowledgearticleCategory
		{
			get { return GetRelatedEntities<Category>("knowledgearticle_category", null); }
			set { SetRelatedEntities("knowledgearticle_category", null, value); }
		}
		#endregion

		#region Actions
		#endregion

		#region OptionSetEnums
		public enum eExpiredReviewOptions
		{	
		
			[Label("Needs Updating")]
			[Description(@"")]
			NeedsUpdating = 0, 
		
			[Label("Republish")]
			[Description(@"")]
			Republish = 1, 
		
			[Label("Archive")]
			[Description(@"")]
			Archive = 2, 
		}
		
		public enum eReview
		{	
		
			[Label("Approved")]
			[Description(@"")]
			Approved = 0, 
		
			[Label("Rejected")]
			[Description(@"")]
			Rejected = 1, 
		}
		
		public enum eStatus
		{	
		
			[Label("Draft")]
			[Description(@"")]
			Draft = 0, 
		
			[Label("Approved")]
			[Description(@"")]
			Approved = 1, 
		
			[Label("Scheduled")]
			[Description(@"")]
			Scheduled = 2, 
		
			[Label("Published")]
			[Description(@"")]
			Published = 3, 
		
			[Label("Expired")]
			[Description(@"")]
			Expired = 4, 
		
			[Label("Archived")]
			[Description(@"")]
			Archived = 5, 
		
			[Label("Discarded")]
			[Description(@"")]
			Discarded = 6, 
		}
		
		public enum eStatusReason
		{	
		
			[Label("Proposed")]
			[Description(@"")]
			Proposed_Active = 1, 
		
			[Label("Draft")]
			[Description(@"")]
			Draft_Active = 2, 
		
			[Label("Needs review")]
			[Description(@"")]
			NeedsReview_Active = 3, 
		
			[Label("In review")]
			[Description(@"")]
			InReview_Active = 4, 
		
			[Label("Approved")]
			[Description(@"")]
			Approved_Inactive = 5, 
		
			[Label("Scheduled")]
			[Description(@"")]
			Scheduled = 6, 
		
			[Label("Published")]
			[Description(@"")]
			Published = 7, 
		
			[Label("Needs review")]
			[Description(@"")]
			NeedsReview = 8, 
		
			[Label("Updating")]
			[Description(@"")]
			Updating = 9, 
		
			[Label("Expired")]
			[Description(@"")]
			Expired = 10, 
		
			[Label("Rejected")]
			[Description(@"")]
			Rejected = 11, 
		
			[Label("Archived")]
			[Description(@"")]
			Archived = 12, 
		
			[Label("Discarded")]
			[Description(@"")]
			Discarded = 13, 
		
			[Label("Rejected")]
			[Description(@"")]
			Rejected2 = 14, 
		}
		
		#endregion	

		#region Properties
		public static class Properties 
		{
			/// <summary>articlepublicnumber</summary>
			public const string ArticlePublicNumber = "articlepublicnumber";

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

			/// <summary>description</summary>
			public const string Description = "description";

			/// <summary>exchangerate</summary>
			public const string ExchangeRate = "exchangerate";

			/// <summary>expirationdate</summary>
			public const string ExpirationDate = "expirationdate";

			/// <summary>expirationstateid</summary>
			public const string ExpirationStateId = "expirationstateid";

			/// <summary>expirationstatusid</summary>
			public const string ExpiredStatus = "expirationstatusid";

			/// <summary>expiredreviewoptions</summary>
			public const string ExpiredReviewOptions = "expiredreviewoptions";

			/// <summary>importsequencenumber</summary>
			public const string ImportSequenceNumber = "importsequencenumber";

			/// <summary>isinternal</summary>
			public const string Internal = "isinternal";

			/// <summary>islatestversion</summary>
			public const string IsLatestVersion = "islatestversion";

			/// <summary>isprimary</summary>
			public const string PrimaryArticle = "isprimary";

			/// <summary>isrootarticle</summary>
			public const string RootArticle = "isrootarticle";

			/// <summary>keywords</summary>
			public const string Keywords = "keywords";

			/// <summary>knowledgearticleid</summary>
			public const string KnowledgeArticleId = "knowledgearticleid";

			/// <summary>knowledgearticleviews</summary>
			public const string KnowledgeArticleViews = "knowledgearticleviews";

			/// <summary>knowledgearticleviews_date</summary>
			public const string KnowledgeArticleViewLastUpdatedTime = "knowledgearticleviews_date";

			/// <summary>knowledgearticleviews_state</summary>
			public const string KnowledgeArticleViewState = "knowledgearticleviews_state";

			/// <summary>languagelocaleid</summary>
			public const string Language = "languagelocaleid";

			/// <summary>languagelocaleidlocaleid</summary>
			public const string Languagelocaleidlocaleid = "languagelocaleidlocaleid";

			/// <summary>languagelocaleidname</summary>
			public const string Languagelocaleidname = "languagelocaleidname";

			/// <summary>majorversionnumber</summary>
			public const string MajorVersionNumber = "majorversionnumber";

			/// <summary>minorversionnumber</summary>
			public const string MinorVersionNumber = "minorversionnumber";

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

			/// <summary>parentarticlecontentid</summary>
			public const string ParentArticleContentId = "parentarticlecontentid";

			/// <summary>parentarticlecontentidname</summary>
			public const string Parentarticlecontentidname = "parentarticlecontentidname";

			/// <summary>previousarticlecontentid</summary>
			public const string PreviousArticleContentID = "previousarticlecontentid";

			/// <summary>previousarticlecontentidname</summary>
			public const string Previousarticlecontentidname = "previousarticlecontentidname";

			/// <summary>primaryauthorid</summary>
			public const string PrimaryAuthorId = "primaryauthorid";

			/// <summary>primaryauthoridname</summary>
			public const string Primaryauthoridname = "primaryauthoridname";

			/// <summary>processid</summary>
			public const string ProcessId = "processid";

			/// <summary>publishon</summary>
			public const string PublishOn = "publishon";

			/// <summary>publishstatusid</summary>
			public const string PublishedStatus = "publishstatusid";

			/// <summary>rating</summary>
			public const string Rating = "rating";

			/// <summary>rating_count</summary>
			public const string RatingCount = "rating_count";

			/// <summary>rating_date</summary>
			public const string RatingLastUpdatedTime = "rating_date";

			/// <summary>rating_state</summary>
			public const string RatingState = "rating_state";

			/// <summary>rating_sum</summary>
			public const string Ratingsum = "rating_sum";

			/// <summary>readyforreview</summary>
			public const string ReadyForReview = "readyforreview";

			/// <summary>review</summary>
			public const string Review = "review";

			/// <summary>rootarticleid</summary>
			public const string RootArticleId = "rootarticleid";

			/// <summary>rootarticleidname</summary>
			public const string Rootarticleidname = "rootarticleidname";

			/// <summary>scheduledstatusid</summary>
			public const string ScheduledStatus = "scheduledstatusid";

			/// <summary>setcategoryassociations</summary>
			public const string SetCategoryAssociations = "setcategoryassociations";

			/// <summary>setproductassociations</summary>
			public const string SetProductAssociations = "setproductassociations";

			/// <summary>stageid</summary>
			public const string StageId = "stageid";

			/// <summary>statecode</summary>
			public const string Status = "statecode";

			/// <summary>statuscode</summary>
			public const string StatusReason = "statuscode";

			/// <summary>subjectid</summary>
			public const string Subject = "subjectid";

			/// <summary>subjectiddsc</summary>
			public const string Subjectiddsc = "subjectiddsc";

			/// <summary>subjectidname</summary>
			public const string Subjectidname = "subjectidname";

			/// <summary>timezoneruleversionnumber</summary>
			public const string TimeZoneRuleVersionNumber = "timezoneruleversionnumber";

			/// <summary>title</summary>
			public const string Title = "title";

			/// <summary>transactioncurrencyid</summary>
			public const string Currency = "transactioncurrencyid";

			/// <summary>transactioncurrencyidname</summary>
			public const string Transactioncurrencyidname = "transactioncurrencyidname";

			/// <summary>traversedpath</summary>
			public const string DeprecatedTraversedPath = "traversedpath";

			/// <summary>updatecontent</summary>
			public const string UpdateContent = "updatecontent";

			/// <summary>utcconversiontimezonecode</summary>
			public const string UTCConversionTimeZoneCode = "utcconversiontimezonecode";

			/// <summary>versionnumber</summary>
			public const string Versionnumber = "versionnumber";

		}
		#endregion

		#region Schemas
		public static class Schemas 
		{
			/// <summary>1:N incident_knowledgearticles</summary>
			public const string IncidentKnowledgearticles = "incident_knowledgearticles";

			/// <summary>1:N knowledgearticle_activity_parties</summary>
			public const string KnowledgearticleActivityParties = "knowledgearticle_activity_parties";

			/// <summary>1:N KnowledgeArticle_ActivityPointers</summary>
			public const string KnowledgeArticleActivityPointers = "KnowledgeArticle_ActivityPointers";

			/// <summary>1:N knowledgearticle_Annotations</summary>
			public const string KnowledgearticleAnnotations = "knowledgearticle_Annotations";

			/// <summary>1:N KnowledgeArticle_Appointments</summary>
			public const string KnowledgeArticleAppointments = "KnowledgeArticle_Appointments";

			/// <summary>1:N knowledgearticle_AsyncOperations</summary>
			public const string KnowledgearticleAsyncOperations = "knowledgearticle_AsyncOperations";

			/// <summary>1:N knowledgearticle_BulkDeleteFailures</summary>
			public const string KnowledgearticleBulkDeleteFailures = "knowledgearticle_BulkDeleteFailures";

			/// <summary>1:N knowledgearticle_BulkOperations</summary>
			public const string KnowledgearticleBulkOperations = "knowledgearticle_BulkOperations";

			/// <summary>1:N knowledgearticle_CampaignResponses</summary>
			public const string KnowledgearticleCampaignResponses = "knowledgearticle_CampaignResponses";

			/// <summary>1:N knowledgearticle_connections1</summary>
			public const string KnowledgearticleConnections1 = "knowledgearticle_connections1";

			/// <summary>1:N knowledgearticle_connections2</summary>
			public const string KnowledgearticleConnections2 = "knowledgearticle_connections2";

			/// <summary>1:N knowledgearticle_DuplicateBaseRecord</summary>
			public const string KnowledgearticleDuplicateBaseRecord = "knowledgearticle_DuplicateBaseRecord";

			/// <summary>1:N knowledgearticle_DuplicateMatchingRecord</summary>
			public const string KnowledgearticleDuplicateMatchingRecord = "knowledgearticle_DuplicateMatchingRecord";

			/// <summary>1:N KnowledgeArticle_Emails</summary>
			public const string KnowledgeArticleEmails = "KnowledgeArticle_Emails";

			/// <summary>1:N KnowledgeArticle_Faxes</summary>
			public const string KnowledgeArticleFaxes = "KnowledgeArticle_Faxes";

			/// <summary>1:N KnowledgeArticle_Feedback</summary>
			public const string KnowledgeArticleFeedback = "KnowledgeArticle_Feedback";

			/// <summary>1:N knowledgearticle_IncidentResolutions</summary>
			public const string KnowledgearticleIncidentResolutions = "knowledgearticle_IncidentResolutions";

			/// <summary>1:N KnowledgeArticle_Letters</summary>
			public const string KnowledgeArticleLetters = "KnowledgeArticle_Letters";

			/// <summary>1:N knowledgearticle_OpportunityCloses</summary>
			public const string KnowledgearticleOpportunityCloses = "knowledgearticle_OpportunityCloses";

			/// <summary>1:N knowledgearticle_OrderCloses</summary>
			public const string KnowledgearticleOrderCloses = "knowledgearticle_OrderCloses";

			/// <summary>1:N knowledgearticle_parentarticle_contentid</summary>
			public const string KnowledgearticleParentarticleContentid = "knowledgearticle_parentarticle_contentid";

			/// <summary>1:N KnowledgeArticle_Phonecalls</summary>
			public const string KnowledgeArticlePhonecalls = "KnowledgeArticle_Phonecalls";

			/// <summary>1:N knowledgearticle_PostFollows</summary>
			public const string KnowledgearticlePostFollows = "knowledgearticle_PostFollows";

			/// <summary>1:N knowledgearticle_previousarticle_contentid</summary>
			public const string KnowledgearticlePreviousarticleContentid = "knowledgearticle_previousarticle_contentid";

			/// <summary>1:N knowledgearticle_PrincipalObjectAttributeAccess</summary>
			public const string KnowledgearticlePrincipalObjectAttributeAccess = "knowledgearticle_PrincipalObjectAttributeAccess";

			/// <summary>1:N knowledgearticle_ProcessSession</summary>
			public const string KnowledgearticleProcessSession = "knowledgearticle_ProcessSession";

			/// <summary>1:N knowledgearticle_QueueItems</summary>
			public const string KnowledgearticleQueueItems = "knowledgearticle_QueueItems";

			/// <summary>1:N knowledgearticle_QuoteCloses</summary>
			public const string KnowledgearticleQuoteCloses = "knowledgearticle_QuoteCloses";

			/// <summary>1:N KnowledgeArticle_RecurringAppointmentMasters</summary>
			public const string KnowledgeArticleRecurringAppointmentMasters = "KnowledgeArticle_RecurringAppointmentMasters";

			/// <summary>1:N knowledgearticle_rootarticle_id</summary>
			public const string KnowledgearticleRootarticleId = "knowledgearticle_rootarticle_id";

			/// <summary>1:N KnowledgeArticle_ServiceAppointments</summary>
			public const string KnowledgeArticleServiceAppointments = "KnowledgeArticle_ServiceAppointments";

			/// <summary>1:N knowledgearticle_SharePointDocumentLocations</summary>
			public const string KnowledgearticleSharePointDocumentLocations = "knowledgearticle_SharePointDocumentLocations";

			/// <summary>1:N KnowledgeArticle_SocialActivities</summary>
			public const string KnowledgeArticleSocialActivities = "KnowledgeArticle_SocialActivities";

			/// <summary>1:N KnowledgeArticle_SyncErrors</summary>
			public const string KnowledgeArticleSyncErrors = "KnowledgeArticle_SyncErrors";

			/// <summary>1:N KnowledgeArticle_Tasks</summary>
			public const string KnowledgeArticleTasks = "KnowledgeArticle_Tasks";

			/// <summary>1:N knowledgearticle_Teams</summary>
			public const string KnowledgearticleTeams = "knowledgearticle_Teams";

			/// <summary>1:N knowledgearticle_views</summary>
			public const string KnowledgearticleViews = "knowledgearticle_views";

			/// <summary>1:N lk_expiredprocess_knowledgearticleid</summary>
			public const string LkExpiredprocessKnowledgearticleid = "lk_expiredprocess_knowledgearticleid";

			/// <summary>1:N lk_newprocess_knowledgearticleid</summary>
			public const string LkNewprocessKnowledgearticleid = "lk_newprocess_knowledgearticleid";

			/// <summary>1:N lk_translationprocess_knowledgearticleid</summary>
			public const string LkTranslationprocessKnowledgearticleid = "lk_translationprocess_knowledgearticleid";

			/// <summary>1:N msdyn_knowledgearticle_feedback_context</summary>
			public const string MsdynKnowledgearticleFeedbackContext = "msdyn_knowledgearticle_feedback_context";

			/// <summary>N:N knowledgearticle_category</summary>
			public const string KnowledgearticleCategory = "knowledgearticle_category";

		}
		#endregion
	}
}

