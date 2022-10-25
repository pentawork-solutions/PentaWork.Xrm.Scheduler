using System;
using System.Linq;
using System.Diagnostics;
using System.ComponentModel;
using Microsoft.Xrm.Sdk; 
using Microsoft.Xrm.Sdk.Client;
using System.Collections.Generic;

namespace PentaWork.Xrm.Scheduler.Proxies.Entities
{
	
	[EntityLogicalName("duplicaterulecondition")]
	public sealed class DuplicateRuleCondition : Entity
	{	
		public static readonly int? EntityTypeCode = 4416;
		public new const string LogicalName = "duplicaterulecondition";
		public const string PrimaryIdAttribute = "duplicateruleconditionid";
		public const string PrimaryNameAttribute = "";
	
		public DuplicateRuleCondition() : base("duplicaterulecondition") { }

		#region Attributes
		/// <summary>
        /// baseattributename
        /// </summary>
		[DisplayName("Base Field")]
		[AttributeLogicalName("baseattributename")]
		public string BaseField
		{	
			get { return GetAttributeValue<string>("baseattributename"); }
			set
			{ 
				if(value == BaseField) return;
				SetAttributeValue("baseattributename", value);
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
        /// duplicateruleconditionid
        /// </summary>
		[DisplayName("Duplicate Rule Condition")]
		[AttributeLogicalName("duplicateruleconditionid")]
		public override Guid Id
		{
			get => base.Id;
			set { base.Id = value; SetAttributeValue("duplicateruleconditionid", value); }
		}

							/// <summary>
        /// ignoreblankvalues
        /// </summary>
		[DisplayName("Ignore Blank Values")]
		[AttributeLogicalName("ignoreblankvalues")]
		public bool? IgnoreBlankValues
		{	
			get { return GetAttributeValue<bool?>("ignoreblankvalues"); }
			set
			{ 
				if(value == IgnoreBlankValues) return;
				SetAttributeValue("ignoreblankvalues", value);
			}
		}	
			
		/// <summary>
        /// matchingattributename
        /// </summary>
		[DisplayName("Matching Field")]
		[AttributeLogicalName("matchingattributename")]
		public string MatchingField
		{	
			get { return GetAttributeValue<string>("matchingattributename"); }
			set
			{ 
				if(value == MatchingField) return;
				SetAttributeValue("matchingattributename", value);
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
        /// operatorcode
        /// </summary>
		[DisplayName("Operator Code")]
		[AttributeLogicalName("operatorcode")]
		public eOperatorCode? OperatorCode
		{	
			get 
			{ 
				var optionSetValue = GetAttributeValue<OptionSetValue>("operatorcode");
				if (optionSetValue != null) return (eOperatorCode)optionSetValue.Value;
				else return null;
			}
			set 
			{ 
				if(value == OperatorCode) return;

				OptionSetValue optionSetValue = null;
				if(value != null) optionSetValue = new OptionSetValue((int)value);
				SetAttributeValue("operatorcode", optionSetValue); 
			}
		}

		/// <summary>
        /// operatorparam
        /// </summary>
		[DisplayName("Operator Parameter")]
		[AttributeLogicalName("operatorparam")]
		public int? OperatorParameter
		{	
			get { return GetAttributeValue<int?>("operatorparam"); }
			set
			{ 
				if(value == OperatorParameter) return;
				SetAttributeValue("operatorparam", value);
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
		public Guid OwningBusinessUnitId
		{	
			get { return GetAttributeValue<Guid>("owningbusinessunit"); }
			set
			{ 
				if(value == OwningBusinessUnitId) return;
				SetAttributeValue("owningbusinessunit", value);
			}
		}	
			
		/// <summary>
        /// owninguser
        /// </summary>
		[DisplayName("Owning User")]
		[AttributeLogicalName("owninguser")]
		public Guid OwningUserId
		{	
			get { return GetAttributeValue<Guid>("owninguser"); }
			set
			{ 
				if(value == OwningUserId) return;
				SetAttributeValue("owninguser", value);
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
			
		#endregion	

		#region Relations
			/// <summary>
        /// 1:N Get entities for 'DuplicateRuleCondition_SyncErrors'
        /// </summary>
		[RelationshipSchemaName("DuplicateRuleCondition_SyncErrors")]
		public IEnumerable<SyncError> DuplicateRuleConditionSyncErrors
		{
			get { return GetRelatedEntities<SyncError>("DuplicateRuleCondition_SyncErrors", null); }
			set { SetRelatedEntities("DuplicateRuleCondition_SyncErrors", null, value); }
		}
		#endregion

		#region Actions
		#endregion

		#region OptionSetEnums
		public enum eOperatorCode
		{	
		
			[Label("Exact Match")]
			[Description(@"")]
			ExactMatch = 0, 
		
			[Label("Same First Characters")]
			[Description(@"")]
			SameFirstCharacters = 1, 
		
			[Label("Same Last Characters")]
			[Description(@"")]
			SameLastCharacters = 2, 
		
			[Label("Same Date")]
			[Description(@"")]
			SameDate = 3, 
		
			[Label("Same Date and Time")]
			[Description(@"")]
			SameDateAndTime = 4, 
		
			[Label("Exact Match (Pick List Label)")]
			[Description(@"")]
			ExactMatchPickListLabel = 5, 
		
			[Label("Exact Match (Pick List Value)")]
			[Description(@"")]
			ExactMatchPickListValue = 6, 
		}
		
		#endregion	

		#region Properties
		public static class Properties 
		{
			/// <summary>baseattributename</summary>
			public const string BaseField = "baseattributename";

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

			/// <summary>duplicateruleconditionid</summary>
			public const string DuplicateRuleConditionId = "duplicateruleconditionid";

			/// <summary>ignoreblankvalues</summary>
			public const string IgnoreBlankValues = "ignoreblankvalues";

			/// <summary>matchingattributename</summary>
			public const string MatchingField = "matchingattributename";

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

			/// <summary>operatorcode</summary>
			public const string OperatorCode = "operatorcode";

			/// <summary>operatorparam</summary>
			public const string OperatorParameter = "operatorparam";

			/// <summary>ownerid</summary>
			public const string Owner = "ownerid";

			/// <summary>owneridtype</summary>
			public const string Owneridtype = "owneridtype";

			/// <summary>owningbusinessunit</summary>
			public const string OwningBusinessUnitId = "owningbusinessunit";

			/// <summary>owninguser</summary>
			public const string OwningUserId = "owninguser";

			/// <summary>regardingobjectid</summary>
			public const string Regarding = "regardingobjectid";

		}
		#endregion

		#region Schemas
		public static class Schemas 
		{
			/// <summary>1:N DuplicateRuleCondition_SyncErrors</summary>
			public const string DuplicateRuleConditionSyncErrors = "DuplicateRuleCondition_SyncErrors";

		}
		#endregion
	}
}

