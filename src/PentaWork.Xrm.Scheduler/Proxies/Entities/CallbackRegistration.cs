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
	[EntityLogicalName("callbackregistration")]
	public sealed class CallbackRegistration : Entity
	{	
		public static readonly int? EntityTypeCode = 301;
		public new const string LogicalName = "callbackregistration";
		public const string PrimaryIdAttribute = "callbackregistrationid";
		public const string PrimaryNameAttribute = "name";
	
		public CallbackRegistration() : base("callbackregistration") { }

		#region Attributes
		/// <summary>
        /// callbackregistrationid
        /// </summary>
		[DisplayName("callbackregistrationid")]
		[AttributeLogicalName("callbackregistrationid")]
		public override Guid Id
		{
			get => base.Id;
			set { base.Id = value; SetAttributeValue("callbackregistrationid", value); }
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
        /// entityname
        /// </summary>
		[DisplayName("Entity Name")]
		[AttributeLogicalName("entityname")]
		public string EntityName
		{	
			get { return GetAttributeValue<string>("entityname"); }
			set
			{ 
				if(value == EntityName) return;
				SetAttributeValue("entityname", value);
			}
		}	
			
		/// <summary>
        /// filterexpression
        /// </summary>
		[DisplayName("Filter Expression")]
		[AttributeLogicalName("filterexpression")]
		public string FilterExpression
		{	
			get { return GetAttributeValue<string>("filterexpression"); }
			set
			{ 
				if(value == FilterExpression) return;
				SetAttributeValue("filterexpression", value);
			}
		}	
			
		/// <summary>
        /// filteringattributes
        /// </summary>
		[DisplayName("Filtering Attributes")]
		[AttributeLogicalName("filteringattributes")]
		public string FilteringAttributes
		{	
			get { return GetAttributeValue<string>("filteringattributes"); }
			set
			{ 
				if(value == FilteringAttributes) return;
				SetAttributeValue("filteringattributes", value);
			}
		}	
			
		/// <summary>
        /// message
        /// </summary>
		[DisplayName("Specifies the message type")]
		[AttributeLogicalName("message")]
		public eMessage? SpecifiesTheMessageType
		{	
			get 
			{ 
				var optionSetValue = GetAttributeValue<OptionSetValue>("message");
				if (optionSetValue != null) return (eMessage)optionSetValue.Value;
				else return null;
			}
			set 
			{ 
				if(value == SpecifiesTheMessageType) return;

				OptionSetValue optionSetValue = null;
				if(value != null) optionSetValue = new OptionSetValue((int)value);
				SetAttributeValue("message", optionSetValue); 
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
        /// postponeuntil
        /// </summary>
		[DisplayName("Postpone Until")]
		[AttributeLogicalName("postponeuntil")]
		public string PostponeUntil
		{	
			get { return GetAttributeValue<string>("postponeuntil"); }
			set
			{ 
				if(value == PostponeUntil) return;
				SetAttributeValue("postponeuntil", value);
			}
		}	
			
		/// <summary>
        /// runas
        /// </summary>
		[DisplayName("RunAs")]
		[AttributeLogicalName("runas")]
		public eRunAs? RunAs
		{	
			get 
			{ 
				var optionSetValue = GetAttributeValue<OptionSetValue>("runas");
				if (optionSetValue != null) return (eRunAs)optionSetValue.Value;
				else return null;
			}
			set 
			{ 
				if(value == RunAs) return;

				OptionSetValue optionSetValue = null;
				if(value != null) optionSetValue = new OptionSetValue((int)value);
				SetAttributeValue("runas", optionSetValue); 
			}
		}

		/// <summary>
        /// scope
        /// </summary>
		[DisplayName("Specifies the scope type")]
		[AttributeLogicalName("scope")]
		public eScope? SpecifiesTheScopeType
		{	
			get 
			{ 
				var optionSetValue = GetAttributeValue<OptionSetValue>("scope");
				if (optionSetValue != null) return (eScope)optionSetValue.Value;
				else return null;
			}
			set 
			{ 
				if(value == SpecifiesTheScopeType) return;

				OptionSetValue optionSetValue = null;
				if(value != null) optionSetValue = new OptionSetValue((int)value);
				SetAttributeValue("scope", optionSetValue); 
			}
		}

		/// <summary>
        /// url
        /// </summary>
		[DisplayName("Url Address")]
		[AttributeLogicalName("url")]
		public string UrlAddress
		{	
			get { return GetAttributeValue<string>("url"); }
			set
			{ 
				if(value == UrlAddress) return;
				SetAttributeValue("url", value);
			}
		}	
			
		/// <summary>
        /// version
        /// </summary>
		[DisplayName("Specifies the Callback registration version type")]
		[AttributeLogicalName("version")]
		public eEndpointVersion? SpecifiesTheCallbackRegistrationVersionType
		{	
			get 
			{ 
				var optionSetValue = GetAttributeValue<OptionSetValue>("version");
				if (optionSetValue != null) return (eEndpointVersion)optionSetValue.Value;
				else return null;
			}
			set 
			{ 
				if(value == SpecifiesTheCallbackRegistrationVersionType) return;

				OptionSetValue optionSetValue = null;
				if(value != null) optionSetValue = new OptionSetValue((int)value);
				SetAttributeValue("version", optionSetValue); 
			}
		}

		#endregion	

		#region Relations
			#endregion

		#region Actions
		#endregion

		#region OptionSetEnums
		public enum eMessage
		{	
		
			[Label("Create")]
			[Description(@"")]
			Create = 1, 
		
			[Label("Delete")]
			[Description(@"")]
			Delete = 2, 
		
			[Label("Update")]
			[Description(@"")]
			Update = 3, 
		
			[Label("Create or Update")]
			[Description(@"")]
			CreateOrUpdate = 4, 
		
			[Label("Create or Delete")]
			[Description(@"")]
			CreateOrDelete = 5, 
		
			[Label("Update or Delete")]
			[Description(@"")]
			UpdateOrDelete = 6, 
		
			[Label("Create or Update or Delete")]
			[Description(@"")]
			CreateOrUpdateOrDelete = 7, 
		}
		
		public enum eRunAs
		{	
		
			[Label("Triggering User")]
			[Description(@"")]
			TriggeringUser = 1, 
		
			[Label("Record Owner")]
			[Description(@"")]
			RecordOwner = 2, 
		
			[Label("Process Owner")]
			[Description(@"")]
			ProcessOwner = 3, 
		}
		
		public enum eScope
		{	
		
			[Label("User")]
			[Description(@"")]
			User = 1, 
		
			[Label("BusinessUnit")]
			[Description(@"")]
			BusinessUnit = 2, 
		
			[Label("ParentChildBusinessUnit")]
			[Description(@"")]
			ParentChildBusinessUnit = 3, 
		
			[Label("Organization")]
			[Description(@"")]
			Organization = 4, 
		}
		
		public enum eEndpointVersion
		{	
		
			[Label("V1")]
			[Description(@"")]
			V1 = 1, 
		
			[Label("V2")]
			[Description(@"")]
			V2 = 2, 
		}
		
		#endregion	

		#region Properties
		public static class Properties 
		{
			/// <summary>callbackregistrationid</summary>
			public const string CallbackregistrationId = "callbackregistrationid";

			/// <summary>createdby</summary>
			public const string CreatedBy = "createdby";

			/// <summary>createdbyname</summary>
			public const string Createdbyname = "createdbyname";

			/// <summary>createdon</summary>
			public const string CreatedOn = "createdon";

			/// <summary>createdonbehalfby</summary>
			public const string CreatedByDelegate = "createdonbehalfby";

			/// <summary>createdonbehalfbyname</summary>
			public const string Createdonbehalfbyname = "createdonbehalfbyname";

			/// <summary>createdonbehalfbyyominame</summary>
			public const string Createdonbehalfbyyominame = "createdonbehalfbyyominame";

			/// <summary>entityname</summary>
			public const string EntityName = "entityname";

			/// <summary>filterexpression</summary>
			public const string FilterExpression = "filterexpression";

			/// <summary>filteringattributes</summary>
			public const string FilteringAttributes = "filteringattributes";

			/// <summary>message</summary>
			public const string SpecifiesTheMessageType = "message";

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

			/// <summary>name</summary>
			public const string Name = "name";

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

			/// <summary>postponeuntil</summary>
			public const string PostponeUntil = "postponeuntil";

			/// <summary>runas</summary>
			public const string RunAs = "runas";

			/// <summary>scope</summary>
			public const string SpecifiesTheScopeType = "scope";

			/// <summary>url</summary>
			public const string UrlAddress = "url";

			/// <summary>version</summary>
			public const string SpecifiesTheCallbackRegistrationVersionType = "version";

		}
		#endregion

		#region Schemas
		public static class Schemas 
		{
		}
		#endregion
	}
}

