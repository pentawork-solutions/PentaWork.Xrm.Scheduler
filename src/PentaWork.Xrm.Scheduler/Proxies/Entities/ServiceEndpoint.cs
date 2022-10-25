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
	[EntityLogicalName("serviceendpoint")]
	public sealed class ServiceEndpoint : Entity
	{	
		public static readonly int? EntityTypeCode = 4618;
		public new const string LogicalName = "serviceendpoint";
		public const string PrimaryIdAttribute = "serviceendpointid";
		public const string PrimaryNameAttribute = "name";
	
		public ServiceEndpoint() : base("serviceendpoint") { }

		#region Attributes
		/// <summary>
        /// authtype
        /// </summary>
		[DisplayName("Specifies mode of authentication with SB")]
		[AttributeLogicalName("authtype")]
		public eAuthenticationTypeForServiceBus? SpecifiesModeOfAuthenticationWithSB
		{	
			get 
			{ 
				var optionSetValue = GetAttributeValue<OptionSetValue>("authtype");
				if (optionSetValue != null) return (eAuthenticationTypeForServiceBus)optionSetValue.Value;
				else return null;
			}
			set 
			{ 
				if(value == SpecifiesModeOfAuthenticationWithSB) return;

				OptionSetValue optionSetValue = null;
				if(value != null) optionSetValue = new OptionSetValue((int)value);
				SetAttributeValue("authtype", optionSetValue); 
			}
		}

		/// <summary>
        /// authvalue
        /// </summary>
		[DisplayName("Authentication Value")]
		[AttributeLogicalName("authvalue")]
		public string AuthenticationValue
		{	
			get { return GetAttributeValue<string>("authvalue"); }
			set
			{ 
				if(value == AuthenticationValue) return;
				SetAttributeValue("authvalue", value);
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
        /// connectionmode
        /// </summary>
		[DisplayName("Connection Mode")]
		[AttributeLogicalName("connectionmode")]
		public eConnectionMode? ConnectionMode
		{	
			get 
			{ 
				var optionSetValue = GetAttributeValue<OptionSetValue>("connectionmode");
				if (optionSetValue != null) return (eConnectionMode)optionSetValue.Value;
				else return null;
			}
			set 
			{ 
				if(value == ConnectionMode) return;

				OptionSetValue optionSetValue = null;
				if(value != null) optionSetValue = new OptionSetValue((int)value);
				SetAttributeValue("connectionmode", optionSetValue); 
			}
		}

		/// <summary>
        /// contract
        /// </summary>
		[DisplayName("Contract")]
		[AttributeLogicalName("contract")]
		public eContract? Contract
		{	
			get 
			{ 
				var optionSetValue = GetAttributeValue<OptionSetValue>("contract");
				if (optionSetValue != null) return (eContract)optionSetValue.Value;
				else return null;
			}
			set 
			{ 
				if(value == Contract) return;

				OptionSetValue optionSetValue = null;
				if(value != null) optionSetValue = new OptionSetValue((int)value);
				SetAttributeValue("contract", optionSetValue); 
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
        /// isauthvalueset
        /// </summary>
		[DisplayName("isauthvalueset")]
		[AttributeLogicalName("isauthvalueset")]
		public bool? Isauthvalueset
		{	
			get { return GetAttributeValue<bool?>("isauthvalueset"); }
			set
			{ 
				if(value == Isauthvalueset) return;
				SetAttributeValue("isauthvalueset", value);
			}
		}	
			
		/// <summary>
        /// ismanaged
        /// </summary>
		[DisplayName("State")]
		[AttributeLogicalName("ismanaged")]
		public bool? State
		{	
			get { return GetAttributeValue<bool?>("ismanaged"); }
			set
			{ 
				if(value == State) return;
				SetAttributeValue("ismanaged", value);
			}
		}	
			
		/// <summary>
        /// issaskeyset
        /// </summary>
		[DisplayName("issaskeyset")]
		[AttributeLogicalName("issaskeyset")]
		public bool? Issaskeyset
		{	
			get { return GetAttributeValue<bool?>("issaskeyset"); }
			set
			{ 
				if(value == Issaskeyset) return;
				SetAttributeValue("issaskeyset", value);
			}
		}	
			
		/// <summary>
        /// issastokenset
        /// </summary>
		[DisplayName("issastokenset")]
		[AttributeLogicalName("issastokenset")]
		public bool? Issastokenset
		{	
			get { return GetAttributeValue<bool?>("issastokenset"); }
			set
			{ 
				if(value == Issastokenset) return;
				SetAttributeValue("issastokenset", value);
			}
		}	
			
		/// <summary>
        /// messageformat
        /// </summary>
		[DisplayName("Content type of the message")]
		[AttributeLogicalName("messageformat")]
		public eMessageFormat? ContentTypeOfTheMessage
		{	
			get 
			{ 
				var optionSetValue = GetAttributeValue<OptionSetValue>("messageformat");
				if (optionSetValue != null) return (eMessageFormat)optionSetValue.Value;
				else return null;
			}
			set 
			{ 
				if(value == ContentTypeOfTheMessage) return;

				OptionSetValue optionSetValue = null;
				if(value != null) optionSetValue = new OptionSetValue((int)value);
				SetAttributeValue("messageformat", optionSetValue); 
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
        /// namespaceaddress
        /// </summary>
		[DisplayName("Namespace Address")]
		[AttributeLogicalName("namespaceaddress")]
		public string NamespaceAddress
		{	
			get { return GetAttributeValue<string>("namespaceaddress"); }
			set
			{ 
				if(value == NamespaceAddress) return;
				SetAttributeValue("namespaceaddress", value);
			}
		}	
			
		/// <summary>
        /// namespaceformat
        /// </summary>
		[DisplayName("Format of Service Bus Namespace")]
		[AttributeLogicalName("namespaceformat")]
		public eFormatForServiceBusNamespace? FormatOfServiceBusNamespace
		{	
			get 
			{ 
				var optionSetValue = GetAttributeValue<OptionSetValue>("namespaceformat");
				if (optionSetValue != null) return (eFormatForServiceBusNamespace)optionSetValue.Value;
				else return null;
			}
			set 
			{ 
				if(value == FormatOfServiceBusNamespace) return;

				OptionSetValue optionSetValue = null;
				if(value != null) optionSetValue = new OptionSetValue((int)value);
				SetAttributeValue("namespaceformat", optionSetValue); 
			}
		}

		/// <summary>
        /// organizationid
        /// </summary>
		[DisplayName("organizationid")]
		[AttributeLogicalName("organizationid")]
		public EntityReference Organizationid
		{	
			get { return GetAttributeValue<EntityReference>("organizationid"); }
			set
			{ 
				if(value == Organizationid) return;
				SetAttributeValue("organizationid", value);
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
        /// path
        /// </summary>
		[DisplayName("Path")]
		[AttributeLogicalName("path")]
		public string Path
		{	
			get { return GetAttributeValue<string>("path"); }
			set
			{ 
				if(value == Path) return;
				SetAttributeValue("path", value);
			}
		}	
			
		/// <summary>
        /// saskey
        /// </summary>
		[DisplayName("Shared Access Key")]
		[AttributeLogicalName("saskey")]
		public string SharedAccessKey
		{	
			get { return GetAttributeValue<string>("saskey"); }
			set
			{ 
				if(value == SharedAccessKey) return;
				SetAttributeValue("saskey", value);
			}
		}	
			
		/// <summary>
        /// saskeyname
        /// </summary>
		[DisplayName("Shared Access Key Name")]
		[AttributeLogicalName("saskeyname")]
		public string SharedAccessKeyName
		{	
			get { return GetAttributeValue<string>("saskeyname"); }
			set
			{ 
				if(value == SharedAccessKeyName) return;
				SetAttributeValue("saskeyname", value);
			}
		}	
			
		/// <summary>
        /// sastoken
        /// </summary>
		[DisplayName("Shared Access Token")]
		[AttributeLogicalName("sastoken")]
		public string SharedAccessToken
		{	
			get { return GetAttributeValue<string>("sastoken"); }
			set
			{ 
				if(value == SharedAccessToken) return;
				SetAttributeValue("sastoken", value);
			}
		}	
			
		/// <summary>
        /// serviceendpointid
        /// </summary>
		[DisplayName("serviceendpointid")]
		[AttributeLogicalName("serviceendpointid")]
		public override Guid Id
		{
			get => base.Id;
			set { base.Id = value; SetAttributeValue("serviceendpointid", value); }
		}

							/// <summary>
        /// serviceendpointidunique
        /// </summary>
		[DisplayName("serviceendpointidunique")]
		[AttributeLogicalName("serviceendpointidunique")]
		public Guid ServiceendpointiduniqueId
		{	
			get { return GetAttributeValue<Guid>("serviceendpointidunique"); }
			set
			{ 
				if(value == ServiceendpointiduniqueId) return;
				SetAttributeValue("serviceendpointidunique", value);
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
        /// solutionnamespace
        /// </summary>
		[DisplayName("Service Namespace")]
		[AttributeLogicalName("solutionnamespace")]
		public string ServiceNamespace
		{	
			get { return GetAttributeValue<string>("solutionnamespace"); }
			set
			{ 
				if(value == ServiceNamespace) return;
				SetAttributeValue("solutionnamespace", value);
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
        /// userclaim
        /// </summary>
		[DisplayName("User Claim")]
		[AttributeLogicalName("userclaim")]
		public eUserClaim? UserClaim
		{	
			get 
			{ 
				var optionSetValue = GetAttributeValue<OptionSetValue>("userclaim");
				if (optionSetValue != null) return (eUserClaim)optionSetValue.Value;
				else return null;
			}
			set 
			{ 
				if(value == UserClaim) return;

				OptionSetValue optionSetValue = null;
				if(value != null) optionSetValue = new OptionSetValue((int)value);
				SetAttributeValue("userclaim", optionSetValue); 
			}
		}

		#endregion	

		#region Relations
			/// <summary>
        /// 1:N Get entities for 'serviceendpoint_sdkmessageprocessingstep'
        /// </summary>
		[RelationshipSchemaName("serviceendpoint_sdkmessageprocessingstep")]
		public IEnumerable<SdkMessageProcessingStep> ServiceendpointSdkmessageprocessingstep
		{
			get { return GetRelatedEntities<SdkMessageProcessingStep>("serviceendpoint_sdkmessageprocessingstep", null); }
			set { SetRelatedEntities("serviceendpoint_sdkmessageprocessingstep", null, value); }
		}
		#endregion

		#region Actions
		#endregion

		#region OptionSetEnums
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
		
		public enum eAuthenticationTypeForServiceBus
		{	
		
			[Label("ACS")]
			[Description(@"")]
			ACS = 1, 
		
			[Label("SAS Key")]
			[Description(@"")]
			SASKey = 2, 
		
			[Label("SAS Token")]
			[Description(@"")]
			SASToken = 3, 
		
			[Label("Webhook Key")]
			[Description(@"")]
			WebhookKey = 4, 
		
			[Label("Http Header")]
			[Description(@"")]
			HttpHeader = 5, 
		
			[Label("Http Query String")]
			[Description(@"")]
			HttpQueryString = 6, 
		}
		
		public enum eConnectionMode
		{	
		
			[Label("Normal")]
			[Description(@"")]
			Normal = 1, 
		
			[Label("Federated")]
			[Description(@"")]
			Federated = 2, 
		}
		
		public enum eContract
		{	
		
			[Label("OneWay")]
			[Description(@"")]
			OneWay = 1, 
		
			[Label("Queue")]
			[Description(@"")]
			Queue = 2, 
		
			[Label("Rest")]
			[Description(@"")]
			Rest = 3, 
		
			[Label("TwoWay")]
			[Description(@"")]
			TwoWay = 4, 
		
			[Label("Topic")]
			[Description(@"")]
			Topic = 5, 
		
			[Label("Queue (Persistent)")]
			[Description(@"")]
			QueuePersistent = 6, 
		
			[Label("Event Hub")]
			[Description(@"")]
			EventHub = 7, 
		
			[Label("Webhook")]
			[Description(@"")]
			Webhook = 8, 
		}
		
		public enum eMessageFormat
		{	
		
			[Label("Binary XML")]
			[Description(@"")]
			BinaryXML = 1, 
		
			[Label("Json")]
			[Description(@"")]
			Json = 2, 
		
			[Label("Text XML")]
			[Description(@"")]
			TextXML = 3, 
		}
		
		public enum eFormatForServiceBusNamespace
		{	
		
			[Label("Namespace Name")]
			[Description(@"")]
			NamespaceName = 1, 
		
			[Label("Namespace Address")]
			[Description(@"")]
			NamespaceAddress = 2, 
		}
		
		public enum eUserClaim
		{	
		
			[Label("None")]
			[Description(@"")]
			None = 1, 
		
			[Label("UserId")]
			[Description(@"")]
			UserId = 2, 
		
			[Label("UserInfo")]
			[Description(@"")]
			UserInfo = 3, 
		}
		
		#endregion	

		#region Properties
		public static class Properties 
		{
			/// <summary>authtype</summary>
			public const string SpecifiesModeOfAuthenticationWithSB = "authtype";

			/// <summary>authvalue</summary>
			public const string AuthenticationValue = "authvalue";

			/// <summary>componentstate</summary>
			public const string ComponentState = "componentstate";

			/// <summary>connectionmode</summary>
			public const string ConnectionMode = "connectionmode";

			/// <summary>contract</summary>
			public const string Contract = "contract";

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

			/// <summary>description</summary>
			public const string Description = "description";

			/// <summary>introducedversion</summary>
			public const string IntroducedVersion = "introducedversion";

			/// <summary>isauthvalueset</summary>
			public const string Isauthvalueset = "isauthvalueset";

			/// <summary>ismanaged</summary>
			public const string State = "ismanaged";

			/// <summary>issaskeyset</summary>
			public const string Issaskeyset = "issaskeyset";

			/// <summary>issastokenset</summary>
			public const string Issastokenset = "issastokenset";

			/// <summary>messageformat</summary>
			public const string ContentTypeOfTheMessage = "messageformat";

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

			/// <summary>name</summary>
			public const string Name = "name";

			/// <summary>namespaceaddress</summary>
			public const string NamespaceAddress = "namespaceaddress";

			/// <summary>namespaceformat</summary>
			public const string FormatOfServiceBusNamespace = "namespaceformat";

			/// <summary>organizationid</summary>
			public const string Organizationid = "organizationid";

			/// <summary>overwritetime</summary>
			public const string RecordOverwriteTime = "overwritetime";

			/// <summary>path</summary>
			public const string Path = "path";

			/// <summary>saskey</summary>
			public const string SharedAccessKey = "saskey";

			/// <summary>saskeyname</summary>
			public const string SharedAccessKeyName = "saskeyname";

			/// <summary>sastoken</summary>
			public const string SharedAccessToken = "sastoken";

			/// <summary>serviceendpointid</summary>
			public const string ServiceendpointId = "serviceendpointid";

			/// <summary>serviceendpointidunique</summary>
			public const string ServiceendpointiduniqueId = "serviceendpointidunique";

			/// <summary>solutionid</summary>
			public const string SolutionId = "solutionid";

			/// <summary>solutionnamespace</summary>
			public const string ServiceNamespace = "solutionnamespace";

			/// <summary>supportingsolutionid</summary>
			public const string SolutionId2 = "supportingsolutionid";

			/// <summary>url</summary>
			public const string UrlAddress = "url";

			/// <summary>userclaim</summary>
			public const string UserClaim = "userclaim";

		}
		#endregion

		#region Schemas
		public static class Schemas 
		{
			/// <summary>1:N serviceendpoint_sdkmessageprocessingstep</summary>
			public const string ServiceendpointSdkmessageprocessingstep = "serviceendpoint_sdkmessageprocessingstep";

		}
		#endregion
	}
}

