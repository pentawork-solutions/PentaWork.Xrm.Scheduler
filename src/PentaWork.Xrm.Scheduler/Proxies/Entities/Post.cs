using System;
using System.Linq;
using System.Diagnostics;
using System.ComponentModel;
using Microsoft.Xrm.Sdk; 
using Microsoft.Xrm.Sdk.Client;
using System.Collections.Generic;

namespace PentaWork.Xrm.Scheduler.Proxies.Entities
{
	[DebuggerDisplay("{Text}")] 	
	[EntityLogicalName("post")]
	public sealed class Post : Entity
	{	
		public static readonly int? EntityTypeCode = 8000;
		public new const string LogicalName = "post";
		public const string PrimaryIdAttribute = "postid";
		public const string PrimaryNameAttribute = "text";
	
		public Post() : base("post") { }

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
        /// postid
        /// </summary>
		[DisplayName("Post")]
		[AttributeLogicalName("postid")]
		public override Guid Id
		{
			get => base.Id;
			set { base.Id = value; SetAttributeValue("postid", value); }
		}

							/// <summary>
        /// postregardingid
        /// </summary>
		[DisplayName("Post Regarding")]
		[AttributeLogicalName("postregardingid")]
		public EntityReference PostRegarding
		{	
			get { return GetAttributeValue<EntityReference>("postregardingid"); }
			set
			{ 
				if(value == PostRegarding) return;
				SetAttributeValue("postregardingid", value);
			}
		}	
			
		/// <summary>
        /// posttoyammer
        /// </summary>
		[DisplayName("post to yammer")]
		[AttributeLogicalName("posttoyammer")]
		public bool? PostToYammer
		{	
			get { return GetAttributeValue<bool?>("posttoyammer"); }
			set
			{ 
				if(value == PostToYammer) return;
				SetAttributeValue("posttoyammer", value);
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
        /// regardingobjectownerid
        /// </summary>
		[DisplayName("Owner")]
		[AttributeLogicalName("regardingobjectownerid")]
		public EntityReference Owner
		{	
			get { return GetAttributeValue<EntityReference>("regardingobjectownerid"); }
			set
			{ 
				if(value == Owner) return;
				SetAttributeValue("regardingobjectownerid", value);
			}
		}	
			
		/// <summary>
        /// regardingobjectowneridtype
        /// </summary>
		[DisplayName("RegardingObjectOwnerIdType")]
		[AttributeLogicalName("regardingobjectowneridtype")]
		public string RegardingObjectOwnerIdType
		{	
			get { return GetAttributeValue<string>("regardingobjectowneridtype"); }
			set
			{ 
				if(value == RegardingObjectOwnerIdType) return;
				SetAttributeValue("regardingobjectowneridtype", value);
			}
		}	
			
		/// <summary>
        /// regardingobjectowningbusinessunit
        /// </summary>
		[DisplayName("Regarding object owning Business Unit")]
		[AttributeLogicalName("regardingobjectowningbusinessunit")]
		public EntityReference RegardingObjectOwningBusinessUnit
		{	
			get { return GetAttributeValue<EntityReference>("regardingobjectowningbusinessunit"); }
			set
			{ 
				if(value == RegardingObjectOwningBusinessUnit) return;
				SetAttributeValue("regardingobjectowningbusinessunit", value);
			}
		}	
			
		/// <summary>
        /// regardingobjecttypecode
        /// </summary>
		[DisplayName("RegardingObjectTypeCode")]
		[AttributeLogicalName("regardingobjecttypecode")]
		public string RegardingObjectTypeCode
		{	
			get { return GetAttributeValue<string>("regardingobjecttypecode"); }
			set
			{ 
				if(value == RegardingObjectTypeCode) return;
				SetAttributeValue("regardingobjecttypecode", value);
			}
		}	
			
		/// <summary>
        /// source
        /// </summary>
		[DisplayName("Source")]
		[AttributeLogicalName("source")]
		public ePostType? Source
		{	
			get 
			{ 
				var optionSetValue = GetAttributeValue<OptionSetValue>("source");
				if (optionSetValue != null) return (ePostType)optionSetValue.Value;
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
        /// text
        /// </summary>
		[DisplayName("Text")]
		[AttributeLogicalName("text")]
		public string Text
		{	
			get { return GetAttributeValue<string>("text"); }
			set
			{ 
				if(value == Text) return;
				SetAttributeValue("text", value);
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
        /// type
        /// </summary>
		[DisplayName("Type")]
		[AttributeLogicalName("type")]
		public eType? Type
		{	
			get 
			{ 
				var optionSetValue = GetAttributeValue<OptionSetValue>("type");
				if (optionSetValue != null) return (eType)optionSetValue.Value;
				else return null;
			}
			set 
			{ 
				if(value == Type) return;

				OptionSetValue optionSetValue = null;
				if(value != null) optionSetValue = new OptionSetValue((int)value);
				SetAttributeValue("type", optionSetValue); 
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
        /// yammerpoststate
        /// </summary>
		[DisplayName("Yammer Post State")]
		[AttributeLogicalName("yammerpoststate")]
		public int? YammerPostState
		{	
			get { return GetAttributeValue<int?>("yammerpoststate"); }
			set
			{ 
				if(value == YammerPostState) return;
				SetAttributeValue("yammerpoststate", value);
			}
		}	
			
		/// <summary>
        /// yammerretrycount
        /// </summary>
		[DisplayName("Yammer Retry Count")]
		[AttributeLogicalName("yammerretrycount")]
		public int? YammerRetryCount
		{	
			get { return GetAttributeValue<int?>("yammerretrycount"); }
			set
			{ 
				if(value == YammerRetryCount) return;
				SetAttributeValue("yammerretrycount", value);
			}
		}	
			
		#endregion	

		#region Relations
			/// <summary>
        /// 1:N Get entities for 'post_AsyncOperations'
        /// </summary>
		[RelationshipSchemaName("post_AsyncOperations")]
		public IEnumerable<SystemJob> PostAsyncOperations
		{
			get { return GetRelatedEntities<SystemJob>("post_AsyncOperations", null); }
			set { SetRelatedEntities("post_AsyncOperations", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'post_BulkDeleteFailures'
        /// </summary>
		[RelationshipSchemaName("post_BulkDeleteFailures")]
		public IEnumerable<BulkDeleteFailure> PostBulkDeleteFailures
		{
			get { return GetRelatedEntities<BulkDeleteFailure>("post_BulkDeleteFailures", null); }
			set { SetRelatedEntities("post_BulkDeleteFailures", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'Post_Comments'
        /// </summary>
		[RelationshipSchemaName("Post_Comments")]
		public IEnumerable<Comment> PostComments
		{
			get { return GetRelatedEntities<Comment>("Post_Comments", null); }
			set { SetRelatedEntities("Post_Comments", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'Post_Likes'
        /// </summary>
		[RelationshipSchemaName("Post_Likes")]
		public IEnumerable<Like> PostLikes
		{
			get { return GetRelatedEntities<Like>("Post_Likes", null); }
			set { SetRelatedEntities("Post_Likes", null, value); }
		}
		#endregion

		#region Actions
		#endregion

		#region OptionSetEnums
		public enum ePostType
		{	
		
			[Label("Auto Post")]
			[Description(@"")]
			AutoPost = 1, 
		
			[Label("Manual Post")]
			[Description(@"")]
			ManualPost = 2, 
		
			[Label("ActionHub Post")]
			[Description(@"")]
			ActionHubPost = 3, 
		}
		
		public enum eType
		{	
		
			[Label("Check-in")]
			[Description(@"")]
			Checkin = 1, 
		
			[Label("Idea")]
			[Description(@"")]
			Idea = 2, 
		
			[Label("News")]
			[Description(@"")]
			News = 3, 
		
			[Label("Private Message")]
			[Description(@"")]
			PrivateMessage = 4, 
		
			[Label("Question")]
			[Description(@"")]
			Question = 5, 
		
			[Label("Re-post")]
			[Description(@"")]
			Repost = 6, 
		
			[Label("Status")]
			[Description(@"")]
			Status = 7, 
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

			/// <summary>modifiedby</summary>
			public const string ModifiedBy = "modifiedby";

			/// <summary>modifiedbyname</summary>
			public const string Modifiedbyname = "modifiedbyname";

			/// <summary>modifiedon</summary>
			public const string ModifiedOn = "modifiedon";

			/// <summary>modifiedonbehalfby</summary>
			public const string ModifiedByDelegate = "modifiedonbehalfby";

			/// <summary>modifiedonbehalfbyname</summary>
			public const string Modifiedonbehalfbyname = "modifiedonbehalfbyname";

			/// <summary>modifiedonbehalfbyyominame</summary>
			public const string Modifiedonbehalfbyyominame = "modifiedonbehalfbyyominame";

			/// <summary>organizationid</summary>
			public const string Organization = "organizationid";

			/// <summary>organizationidname</summary>
			public const string Organizationidname = "organizationidname";

			/// <summary>postid</summary>
			public const string PostId = "postid";

			/// <summary>postregardingid</summary>
			public const string PostRegarding = "postregardingid";

			/// <summary>posttoyammer</summary>
			public const string PostToYammer = "posttoyammer";

			/// <summary>regardingobjectid</summary>
			public const string Regarding = "regardingobjectid";

			/// <summary>regardingobjectidname</summary>
			public const string Regardingobjectidname = "regardingobjectidname";

			/// <summary>regardingobjectidyominame</summary>
			public const string Regardingobjectidyominame = "regardingobjectidyominame";

			/// <summary>regardingobjectownerid</summary>
			public const string Owner = "regardingobjectownerid";

			/// <summary>regardingobjectowneridtype</summary>
			public const string RegardingObjectOwnerIdType = "regardingobjectowneridtype";

			/// <summary>regardingobjectowningbusinessunit</summary>
			public const string RegardingObjectOwningBusinessUnit = "regardingobjectowningbusinessunit";

			/// <summary>regardingobjecttypecode</summary>
			public const string RegardingObjectTypeCode = "regardingobjecttypecode";

			/// <summary>source</summary>
			public const string Source = "source";

			/// <summary>text</summary>
			public const string Text = "text";

			/// <summary>timezoneruleversionnumber</summary>
			public const string TimeZoneRuleVersionNumber = "timezoneruleversionnumber";

			/// <summary>type</summary>
			public const string Type = "type";

			/// <summary>utcconversiontimezonecode</summary>
			public const string UTCConversionTimeZoneCode = "utcconversiontimezonecode";

			/// <summary>yammerpoststate</summary>
			public const string YammerPostState = "yammerpoststate";

			/// <summary>yammerretrycount</summary>
			public const string YammerRetryCount = "yammerretrycount";

		}
		#endregion

		#region Schemas
		public static class Schemas 
		{
			/// <summary>1:N post_AsyncOperations</summary>
			public const string PostAsyncOperations = "post_AsyncOperations";

			/// <summary>1:N post_BulkDeleteFailures</summary>
			public const string PostBulkDeleteFailures = "post_BulkDeleteFailures";

			/// <summary>1:N Post_Comments</summary>
			public const string PostComments = "Post_Comments";

			/// <summary>1:N Post_Likes</summary>
			public const string PostLikes = "Post_Likes";

		}
		#endregion
	}
}

