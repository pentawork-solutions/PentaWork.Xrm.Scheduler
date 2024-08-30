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
	[EntityLogicalName("customapi")]
	public sealed class CustomAPI : Entity
	{	
		public static readonly int? EntityTypeCode = 10026;
		public new const string LogicalName = "customapi";
		public const string PrimaryIdAttribute = "customapiid";
		public const string PrimaryNameAttribute = "name";
	
		public CustomAPI() : base("customapi") { }

		#region Attributes
		/// <summary>
        /// allowedcustomprocessingsteptype
        /// </summary>
		[DisplayName("Allowed Custom Processing Step Type")]
		[AttributeLogicalName("allowedcustomprocessingsteptype")]
		public eAllowedCustomProcessingStepType? AllowedCustomProcessingStepType
		{	
			get 
			{ 
				var optionSetValue = GetAttributeValue<OptionSetValue>("allowedcustomprocessingsteptype");
				if (optionSetValue != null) return (eAllowedCustomProcessingStepType)optionSetValue.Value;
				else return null;
			}
			set 
			{ 
				if(Attributes.ContainsKey("allowedcustomprocessingsteptype") && value == AllowedCustomProcessingStepType) return;

				OptionSetValue optionSetValue = null;
				if(value != null) optionSetValue = new OptionSetValue((int)value);
				SetAttributeValue("allowedcustomprocessingsteptype", optionSetValue); 
			}
		}

		/// <summary>
        /// bindingtype
        /// </summary>
		[DisplayName("Binding Type")]
		[AttributeLogicalName("bindingtype")]
		public eBindingType? BindingType
		{	
			get 
			{ 
				var optionSetValue = GetAttributeValue<OptionSetValue>("bindingtype");
				if (optionSetValue != null) return (eBindingType)optionSetValue.Value;
				else return null;
			}
			set 
			{ 
				if(Attributes.ContainsKey("bindingtype") && value == BindingType) return;

				OptionSetValue optionSetValue = null;
				if(value != null) optionSetValue = new OptionSetValue((int)value);
				SetAttributeValue("bindingtype", optionSetValue); 
			}
		}

		/// <summary>
        /// boundentitylogicalname
        /// </summary>
		[DisplayName("Bound Entity Logical Name")]
		[AttributeLogicalName("boundentitylogicalname")]
		public string BoundEntityLogicalName
		{	
			get { return GetAttributeValue<string>("boundentitylogicalname"); }
			set
			{ 
				if(Attributes.ContainsKey("boundentitylogicalname") && value == BoundEntityLogicalName) return;
				SetAttributeValue("boundentitylogicalname", value);
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
				if(Attributes.ContainsKey("componentidunique") && value == RowIdUniqueId) return;
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
				if(Attributes.ContainsKey("componentstate") && value == ComponentState) return;

				OptionSetValue optionSetValue = null;
				if(value != null) optionSetValue = new OptionSetValue((int)value);
				SetAttributeValue("componentstate", optionSetValue); 
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
				if(Attributes.ContainsKey("createdby") && value == CreatedBy) return;
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
				if(Attributes.ContainsKey("createdbyname") && value == Createdbyname) return;
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
				if(Attributes.ContainsKey("createdbyyominame") && value == Createdbyyominame) return;
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
				if(Attributes.ContainsKey("createdon") && value == CreatedOn) return;
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
				if(Attributes.ContainsKey("createdonbehalfby") && value == CreatedByDelegate) return;
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
				if(Attributes.ContainsKey("createdonbehalfbyname") && value == Createdonbehalfbyname) return;
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
				if(Attributes.ContainsKey("createdonbehalfbyyominame") && value == Createdonbehalfbyyominame) return;
				SetAttributeValue("createdonbehalfbyyominame", value);
			}
		}	
			
		/// <summary>
        /// customapiid
        /// </summary>
		[DisplayName("Custom API")]
		[AttributeLogicalName("customapiid")]
		public override Guid Id
		{
			get => base.Id;
			set { base.Id = value; SetAttributeValue("customapiid", value); }
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
				if(Attributes.ContainsKey("description") && value == Description) return;
				SetAttributeValue("description", value);
			}
		}	
			
		/// <summary>
        /// displayname
        /// </summary>
		[DisplayName("Display Name")]
		[AttributeLogicalName("displayname")]
		public string DisplayName
		{	
			get { return GetAttributeValue<string>("displayname"); }
			set
			{ 
				if(Attributes.ContainsKey("displayname") && value == DisplayName) return;
				SetAttributeValue("displayname", value);
			}
		}	
			
		/// <summary>
        /// executeprivilegename
        /// </summary>
		[DisplayName("Execute Privilege Name")]
		[AttributeLogicalName("executeprivilegename")]
		public string ExecutePrivilegeName
		{	
			get { return GetAttributeValue<string>("executeprivilegename"); }
			set
			{ 
				if(Attributes.ContainsKey("executeprivilegename") && value == ExecutePrivilegeName) return;
				SetAttributeValue("executeprivilegename", value);
			}
		}	
			
		/// <summary>
        /// fxexpressionid
        /// </summary>
		[DisplayName("FxExpression")]
		[AttributeLogicalName("fxexpressionid")]
		public EntityReference FxExpression
		{	
			get { return GetAttributeValue<EntityReference>("fxexpressionid"); }
			set
			{ 
				if(Attributes.ContainsKey("fxexpressionid") && value == FxExpression) return;
				SetAttributeValue("fxexpressionid", value);
			}
		}	
			
		/// <summary>
        /// fxexpressionidname
        /// </summary>
		[DisplayName("fxexpressionidname")]
		[AttributeLogicalName("fxexpressionidname")]
		public string Fxexpressionidname
		{	
			get { return GetAttributeValue<string>("fxexpressionidname"); }
			set
			{ 
				if(Attributes.ContainsKey("fxexpressionidname") && value == Fxexpressionidname) return;
				SetAttributeValue("fxexpressionidname", value);
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
				if(Attributes.ContainsKey("importsequencenumber") && value == ImportSequenceNumber) return;
				SetAttributeValue("importsequencenumber", value);
			}
		}	
			
		/// <summary>
        /// isfunction
        /// </summary>
		[DisplayName("Is Function")]
		[AttributeLogicalName("isfunction")]
		public bool? IsFunction
		{	
			get { return GetAttributeValue<bool?>("isfunction"); }
			set
			{ 
				if(Attributes.ContainsKey("isfunction") && value == IsFunction) return;
				SetAttributeValue("isfunction", value);
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
				if(Attributes.ContainsKey("ismanaged") && value == IsManaged) return;
				SetAttributeValue("ismanaged", value);
			}
		}	
			
		/// <summary>
        /// isprivate
        /// </summary>
		[DisplayName("Is Private")]
		[AttributeLogicalName("isprivate")]
		public bool? IsPrivate
		{	
			get { return GetAttributeValue<bool?>("isprivate"); }
			set
			{ 
				if(Attributes.ContainsKey("isprivate") && value == IsPrivate) return;
				SetAttributeValue("isprivate", value);
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
				if(Attributes.ContainsKey("modifiedby") && value == ModifiedBy) return;
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
				if(Attributes.ContainsKey("modifiedbyname") && value == Modifiedbyname) return;
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
				if(Attributes.ContainsKey("modifiedbyyominame") && value == Modifiedbyyominame) return;
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
				if(Attributes.ContainsKey("modifiedon") && value == ModifiedOn) return;
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
				if(Attributes.ContainsKey("modifiedonbehalfby") && value == ModifiedByDelegate) return;
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
				if(Attributes.ContainsKey("modifiedonbehalfbyname") && value == Modifiedonbehalfbyname) return;
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
				if(Attributes.ContainsKey("modifiedonbehalfbyyominame") && value == Modifiedonbehalfbyyominame) return;
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
				if(Attributes.ContainsKey("name") && value == Name) return;
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
				if(Attributes.ContainsKey("overriddencreatedon") && value == RecordCreatedOn) return;
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
				if(Attributes.ContainsKey("overwritetime") && value == RecordOverwriteTime) return;
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
				if(Attributes.ContainsKey("ownerid") && value == Owner) return;
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
				if(Attributes.ContainsKey("owneridname") && value == Owneridname) return;
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
				if(Attributes.ContainsKey("owneridtype") && value == Owneridtype) return;
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
				if(Attributes.ContainsKey("owneridyominame") && value == Owneridyominame) return;
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
				if(Attributes.ContainsKey("owningbusinessunit") && value == OwningBusinessUnit) return;
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
				if(Attributes.ContainsKey("owningbusinessunitname") && value == Owningbusinessunitname) return;
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
				if(Attributes.ContainsKey("owningteam") && value == OwningTeam) return;
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
				if(Attributes.ContainsKey("owninguser") && value == OwningUser) return;
				SetAttributeValue("owninguser", value);
			}
		}	
			
		/// <summary>
        /// plugintypeid
        /// </summary>
		[DisplayName("Plugin Type")]
		[AttributeLogicalName("plugintypeid")]
		public EntityReference PluginType
		{	
			get { return GetAttributeValue<EntityReference>("plugintypeid"); }
			set
			{ 
				if(Attributes.ContainsKey("plugintypeid") && value == PluginType) return;
				SetAttributeValue("plugintypeid", value);
			}
		}	
			
		/// <summary>
        /// plugintypeidname
        /// </summary>
		[DisplayName("plugintypeidname")]
		[AttributeLogicalName("plugintypeidname")]
		public string Plugintypeidname
		{	
			get { return GetAttributeValue<string>("plugintypeidname"); }
			set
			{ 
				if(Attributes.ContainsKey("plugintypeidname") && value == Plugintypeidname) return;
				SetAttributeValue("plugintypeidname", value);
			}
		}	
			
		/// <summary>
        /// powerfxruleid
        /// </summary>
		[DisplayName("PowerFx Rule")]
		[AttributeLogicalName("powerfxruleid")]
		public EntityReference PowerFxRule
		{	
			get { return GetAttributeValue<EntityReference>("powerfxruleid"); }
			set
			{ 
				if(Attributes.ContainsKey("powerfxruleid") && value == PowerFxRule) return;
				SetAttributeValue("powerfxruleid", value);
			}
		}	
			
		/// <summary>
        /// powerfxruleidname
        /// </summary>
		[DisplayName("powerfxruleidname")]
		[AttributeLogicalName("powerfxruleidname")]
		public string Powerfxruleidname
		{	
			get { return GetAttributeValue<string>("powerfxruleidname"); }
			set
			{ 
				if(Attributes.ContainsKey("powerfxruleidname") && value == Powerfxruleidname) return;
				SetAttributeValue("powerfxruleidname", value);
			}
		}	
			
		/// <summary>
        /// sdkmessageid
        /// </summary>
		[DisplayName("Sdk Message")]
		[AttributeLogicalName("sdkmessageid")]
		public EntityReference SdkMessage
		{	
			get { return GetAttributeValue<EntityReference>("sdkmessageid"); }
			set
			{ 
				if(Attributes.ContainsKey("sdkmessageid") && value == SdkMessage) return;
				SetAttributeValue("sdkmessageid", value);
			}
		}	
			
		/// <summary>
        /// sdkmessageidname
        /// </summary>
		[DisplayName("sdkmessageidname")]
		[AttributeLogicalName("sdkmessageidname")]
		public string Sdkmessageidname
		{	
			get { return GetAttributeValue<string>("sdkmessageidname"); }
			set
			{ 
				if(Attributes.ContainsKey("sdkmessageidname") && value == Sdkmessageidname) return;
				SetAttributeValue("sdkmessageidname", value);
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
				if(Attributes.ContainsKey("solutionid") && value == SolutionId) return;
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
				if(Attributes.ContainsKey("statecode") && value == Status) return;

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
				if(Attributes.ContainsKey("statuscode") && value == StatusReason) return;

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
				if(Attributes.ContainsKey("supportingsolutionid") && value == SolutionId2) return;
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
				if(Attributes.ContainsKey("timezoneruleversionnumber") && value == TimeZoneRuleVersionNumber) return;
				SetAttributeValue("timezoneruleversionnumber", value);
			}
		}	
			
		/// <summary>
        /// uniquename
        /// </summary>
		[DisplayName("Unique Name")]
		[AttributeLogicalName("uniquename")]
		public string UniqueName
		{	
			get { return GetAttributeValue<string>("uniquename"); }
			set
			{ 
				if(Attributes.ContainsKey("uniquename") && value == UniqueName) return;
				SetAttributeValue("uniquename", value);
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
				if(Attributes.ContainsKey("utcconversiontimezonecode") && value == UTCConversionTimeZoneCode) return;
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
				if(Attributes.ContainsKey("versionnumber") && value == VersionNumber) return;
				SetAttributeValue("versionnumber", value);
			}
		}	
			
		/// <summary>
        /// workflowsdkstepenabled
        /// </summary>
		[DisplayName("Enabled for Workflow")]
		[AttributeLogicalName("workflowsdkstepenabled")]
		public bool? EnabledForWorkflow
		{	
			get { return GetAttributeValue<bool?>("workflowsdkstepenabled"); }
			set
			{ 
				if(Attributes.ContainsKey("workflowsdkstepenabled") && value == EnabledForWorkflow) return;
				SetAttributeValue("workflowsdkstepenabled", value);
			}
		}	
			
		#endregion	

		#region Relations
			/// <summary>
        /// 1:N Get entities for 'customapi_AsyncOperations'
        /// </summary>
		[RelationshipSchemaName("customapi_AsyncOperations")]
		public IEnumerable<SystemJob> CustomapiAsyncOperations
		{
			get { return GetRelatedEntities<SystemJob>("customapi_AsyncOperations", null); }
			set { SetRelatedEntities("customapi_AsyncOperations", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'pw_schedule_custom_api_id_customapi'
        /// </summary>
		[RelationshipSchemaName("pw_schedule_custom_api_id_customapi")]
		public IEnumerable<PentaSchedule> PwScheduleCustomApiIdCustomapi
		{
			get { return GetRelatedEntities<PentaSchedule>("pw_schedule_custom_api_id_customapi", null); }
			set { SetRelatedEntities("pw_schedule_custom_api_id_customapi", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'pw_schedule_global_custom_api_id_customapi'
        /// </summary>
		[RelationshipSchemaName("pw_schedule_global_custom_api_id_customapi")]
		public IEnumerable<PentaSchedule> PwScheduleGlobalCustomApiIdCustomapi
		{
			get { return GetRelatedEntities<PentaSchedule>("pw_schedule_global_custom_api_id_customapi", null); }
			set { SetRelatedEntities("pw_schedule_global_custom_api_id_customapi", null, value); }
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
		
		public enum eAllowedCustomProcessingStepType
		{	
		
			[Label("None")]
			[Description(@"")]
			None = 0, 
		
			[Label("Async Only")]
			[Description(@"")]
			AsyncOnly = 1, 
		
			[Label("Sync and Async")]
			[Description(@"")]
			SyncAndAsync = 2, 
		}
		
		public enum eBindingType
		{	
		
			[Label("Global")]
			[Description(@"")]
			Global = 0, 
		
			[Label("Entity")]
			[Description(@"")]
			Entity = 1, 
		
			[Label("Entity Collection")]
			[Description(@"")]
			EntityCollection = 2, 
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
			/// <summary>allowedcustomprocessingsteptype</summary>
			public const string AllowedCustomProcessingStepType = "allowedcustomprocessingsteptype";

			/// <summary>bindingtype</summary>
			public const string BindingType = "bindingtype";

			/// <summary>boundentitylogicalname</summary>
			public const string BoundEntityLogicalName = "boundentitylogicalname";

			/// <summary>componentidunique</summary>
			public const string RowIdUniqueId = "componentidunique";

			/// <summary>componentstate</summary>
			public const string ComponentState = "componentstate";

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

			/// <summary>customapiid</summary>
			public const string CustomAPIId = "customapiid";

			/// <summary>description</summary>
			public const string Description = "description";

			/// <summary>displayname</summary>
			public const string DisplayName = "displayname";

			/// <summary>executeprivilegename</summary>
			public const string ExecutePrivilegeName = "executeprivilegename";

			/// <summary>fxexpressionid</summary>
			public const string FxExpression = "fxexpressionid";

			/// <summary>fxexpressionidname</summary>
			public const string Fxexpressionidname = "fxexpressionidname";

			/// <summary>importsequencenumber</summary>
			public const string ImportSequenceNumber = "importsequencenumber";

			/// <summary>isfunction</summary>
			public const string IsFunction = "isfunction";

			/// <summary>ismanaged</summary>
			public const string IsManaged = "ismanaged";

			/// <summary>isprivate</summary>
			public const string IsPrivate = "isprivate";

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

			/// <summary>owningbusinessunitname</summary>
			public const string Owningbusinessunitname = "owningbusinessunitname";

			/// <summary>owningteam</summary>
			public const string OwningTeam = "owningteam";

			/// <summary>owninguser</summary>
			public const string OwningUser = "owninguser";

			/// <summary>plugintypeid</summary>
			public const string PluginType = "plugintypeid";

			/// <summary>plugintypeidname</summary>
			public const string Plugintypeidname = "plugintypeidname";

			/// <summary>powerfxruleid</summary>
			public const string PowerFxRule = "powerfxruleid";

			/// <summary>powerfxruleidname</summary>
			public const string Powerfxruleidname = "powerfxruleidname";

			/// <summary>sdkmessageid</summary>
			public const string SdkMessage = "sdkmessageid";

			/// <summary>sdkmessageidname</summary>
			public const string Sdkmessageidname = "sdkmessageidname";

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

			/// <summary>uniquename</summary>
			public const string UniqueName = "uniquename";

			/// <summary>utcconversiontimezonecode</summary>
			public const string UTCConversionTimeZoneCode = "utcconversiontimezonecode";

			/// <summary>versionnumber</summary>
			public const string VersionNumber = "versionnumber";

			/// <summary>workflowsdkstepenabled</summary>
			public const string EnabledForWorkflow = "workflowsdkstepenabled";

		}
		#endregion

		#region Schemas
		public static class Schemas 
		{
			/// <summary>1:N customapi_AsyncOperations</summary>
			public const string CustomapiAsyncOperations = "customapi_AsyncOperations";

			/// <summary>1:N pw_schedule_custom_api_id_customapi</summary>
			public const string PwScheduleCustomApiIdCustomapi = "pw_schedule_custom_api_id_customapi";

			/// <summary>1:N pw_schedule_global_custom_api_id_customapi</summary>
			public const string PwScheduleGlobalCustomApiIdCustomapi = "pw_schedule_global_custom_api_id_customapi";

		}
		#endregion
	}
}

