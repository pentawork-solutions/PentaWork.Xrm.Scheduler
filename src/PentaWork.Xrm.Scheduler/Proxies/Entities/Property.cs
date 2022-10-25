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
	[EntityLogicalName("dynamicproperty")]
	public sealed class Property : Entity
	{	
		public static readonly int? EntityTypeCode = 1048;
		public new const string LogicalName = "dynamicproperty";
		public const string PrimaryIdAttribute = "dynamicpropertyid";
		public const string PrimaryNameAttribute = "name";
	
		public Property() : base("dynamicproperty") { }

		#region Attributes
		/// <summary>
        /// basedynamicpropertyid
        /// </summary>
		[DisplayName("Base Property")]
		[AttributeLogicalName("basedynamicpropertyid")]
		public EntityReference BaseProperty
		{	
			get { return GetAttributeValue<EntityReference>("basedynamicpropertyid"); }
			set
			{ 
				if(value == BaseProperty) return;
				SetAttributeValue("basedynamicpropertyid", value);
			}
		}	
			
		/// <summary>
        /// basedynamicpropertyidname
        /// </summary>
		[DisplayName("basedynamicpropertyidname")]
		[AttributeLogicalName("basedynamicpropertyidname")]
		public string Basedynamicpropertyidname
		{	
			get { return GetAttributeValue<string>("basedynamicpropertyidname"); }
			set
			{ 
				if(value == Basedynamicpropertyidname) return;
				SetAttributeValue("basedynamicpropertyidname", value);
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
        /// datatype
        /// </summary>
		[DisplayName("Data Type")]
		[AttributeLogicalName("datatype")]
		public ePropertyDataType? DataType
		{	
			get 
			{ 
				var optionSetValue = GetAttributeValue<OptionSetValue>("datatype");
				if (optionSetValue != null) return (ePropertyDataType)optionSetValue.Value;
				else return null;
			}
			set 
			{ 
				if(value == DataType) return;

				OptionSetValue optionSetValue = null;
				if(value != null) optionSetValue = new OptionSetValue((int)value);
				SetAttributeValue("datatype", optionSetValue); 
			}
		}

		/// <summary>
        /// defaultattributevalue
        /// </summary>
		[DisplayName("Default Value")]
		[AttributeLogicalName("defaultattributevalue")]
		public string DefaultValue
		{	
			get { return GetAttributeValue<string>("defaultattributevalue"); }
			set
			{ 
				if(value == DefaultValue) return;
				SetAttributeValue("defaultattributevalue", value);
			}
		}	
			
		/// <summary>
        /// defaultvaluedecimal
        /// </summary>
		[DisplayName("Default Decimal Value")]
		[AttributeLogicalName("defaultvaluedecimal")]
		public decimal? DefaultDecimalValue
		{	
			get { return GetAttributeValue<decimal?>("defaultvaluedecimal"); }
			set
			{ 
				if(value == DefaultDecimalValue) return;
				SetAttributeValue("defaultvaluedecimal", value);
			}
		}	
			
		/// <summary>
        /// defaultvaluedouble
        /// </summary>
		[DisplayName("Default Double Value")]
		[AttributeLogicalName("defaultvaluedouble")]
		public double? DefaultDoubleValue
		{	
			get { return GetAttributeValue<double?>("defaultvaluedouble"); }
			set
			{ 
				if(value == DefaultDoubleValue) return;
				SetAttributeValue("defaultvaluedouble", value);
			}
		}	
			
		/// <summary>
        /// defaultvalueinteger
        /// </summary>
		[DisplayName("Default Whole Number Value")]
		[AttributeLogicalName("defaultvalueinteger")]
		public int? DefaultWholeNumberValue
		{	
			get { return GetAttributeValue<int?>("defaultvalueinteger"); }
			set
			{ 
				if(value == DefaultWholeNumberValue) return;
				SetAttributeValue("defaultvalueinteger", value);
			}
		}	
			
		/// <summary>
        /// defaultvalueoptionset
        /// </summary>
		[DisplayName("Default OptionSet Value")]
		[AttributeLogicalName("defaultvalueoptionset")]
		public EntityReference DefaultOptionSetValue
		{	
			get { return GetAttributeValue<EntityReference>("defaultvalueoptionset"); }
			set
			{ 
				if(value == DefaultOptionSetValue) return;
				SetAttributeValue("defaultvalueoptionset", value);
			}
		}	
			
		/// <summary>
        /// defaultvalueoptionsetname
        /// </summary>
		[DisplayName("defaultvalueoptionsetname")]
		[AttributeLogicalName("defaultvalueoptionsetname")]
		public string Defaultvalueoptionsetname
		{	
			get { return GetAttributeValue<string>("defaultvalueoptionsetname"); }
			set
			{ 
				if(value == Defaultvalueoptionsetname) return;
				SetAttributeValue("defaultvalueoptionsetname", value);
			}
		}	
			
		/// <summary>
        /// defaultvaluestring
        /// </summary>
		[DisplayName("Default String Value")]
		[AttributeLogicalName("defaultvaluestring")]
		public string DefaultStringValue
		{	
			get { return GetAttributeValue<string>("defaultvaluestring"); }
			set
			{ 
				if(value == DefaultStringValue) return;
				SetAttributeValue("defaultvaluestring", value);
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
        /// dmtimportstate
        /// </summary>
		[DisplayName("Internal Use Only")]
		[AttributeLogicalName("dmtimportstate")]
		public int? InternalUseOnly
		{	
			get { return GetAttributeValue<int?>("dmtimportstate"); }
			set
			{ 
				if(value == InternalUseOnly) return;
				SetAttributeValue("dmtimportstate", value);
			}
		}	
			
		/// <summary>
        /// dynamicpropertyid
        /// </summary>
		[DisplayName("Property ID")]
		[AttributeLogicalName("dynamicpropertyid")]
		public override Guid Id
		{
			get => base.Id;
			set { base.Id = value; SetAttributeValue("dynamicpropertyid", value); }
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
        /// ishidden
        /// </summary>
		[DisplayName("Hidden")]
		[AttributeLogicalName("ishidden")]
		public bool? Hidden
		{	
			get { return GetAttributeValue<bool?>("ishidden"); }
			set
			{ 
				if(value == Hidden) return;
				SetAttributeValue("ishidden", value);
			}
		}	
			
		/// <summary>
        /// isreadonly
        /// </summary>
		[DisplayName("Read-Only")]
		[AttributeLogicalName("isreadonly")]
		public bool? ReadOnly
		{	
			get { return GetAttributeValue<bool?>("isreadonly"); }
			set
			{ 
				if(value == ReadOnly) return;
				SetAttributeValue("isreadonly", value);
			}
		}	
			
		/// <summary>
        /// isrequired
        /// </summary>
		[DisplayName("Required")]
		[AttributeLogicalName("isrequired")]
		public bool? Required
		{	
			get { return GetAttributeValue<bool?>("isrequired"); }
			set
			{ 
				if(value == Required) return;
				SetAttributeValue("isrequired", value);
			}
		}	
			
		/// <summary>
        /// maxlengthstring
        /// </summary>
		[DisplayName("Maximum String Length")]
		[AttributeLogicalName("maxlengthstring")]
		public int? MaximumStringLength
		{	
			get { return GetAttributeValue<int?>("maxlengthstring"); }
			set
			{ 
				if(value == MaximumStringLength) return;
				SetAttributeValue("maxlengthstring", value);
			}
		}	
			
		/// <summary>
        /// maxvaluedecimal
        /// </summary>
		[DisplayName("Maximum Decimal Value")]
		[AttributeLogicalName("maxvaluedecimal")]
		public decimal? MaximumDecimalValue
		{	
			get { return GetAttributeValue<decimal?>("maxvaluedecimal"); }
			set
			{ 
				if(value == MaximumDecimalValue) return;
				SetAttributeValue("maxvaluedecimal", value);
			}
		}	
			
		/// <summary>
        /// maxvaluedouble
        /// </summary>
		[DisplayName("Maximum Double Value")]
		[AttributeLogicalName("maxvaluedouble")]
		public double? MaximumDoubleValue
		{	
			get { return GetAttributeValue<double?>("maxvaluedouble"); }
			set
			{ 
				if(value == MaximumDoubleValue) return;
				SetAttributeValue("maxvaluedouble", value);
			}
		}	
			
		/// <summary>
        /// maxvalueinteger
        /// </summary>
		[DisplayName("Maximum Whole Number Value")]
		[AttributeLogicalName("maxvalueinteger")]
		public int? MaximumWholeNumberValue
		{	
			get { return GetAttributeValue<int?>("maxvalueinteger"); }
			set
			{ 
				if(value == MaximumWholeNumberValue) return;
				SetAttributeValue("maxvalueinteger", value);
			}
		}	
			
		/// <summary>
        /// minvaluedecimal
        /// </summary>
		[DisplayName("Minimum Decimal Value")]
		[AttributeLogicalName("minvaluedecimal")]
		public decimal? MinimumDecimalValue
		{	
			get { return GetAttributeValue<decimal?>("minvaluedecimal"); }
			set
			{ 
				if(value == MinimumDecimalValue) return;
				SetAttributeValue("minvaluedecimal", value);
			}
		}	
			
		/// <summary>
        /// minvaluedouble
        /// </summary>
		[DisplayName("Minimum Double Value")]
		[AttributeLogicalName("minvaluedouble")]
		public double? MinimumDoubleValue
		{	
			get { return GetAttributeValue<double?>("minvaluedouble"); }
			set
			{ 
				if(value == MinimumDoubleValue) return;
				SetAttributeValue("minvaluedouble", value);
			}
		}	
			
		/// <summary>
        /// minvalueinteger
        /// </summary>
		[DisplayName("Minimum Whole Number Value")]
		[AttributeLogicalName("minvalueinteger")]
		public int? MinimumWholeNumberValue
		{	
			get { return GetAttributeValue<int?>("minvalueinteger"); }
			set
			{ 
				if(value == MinimumWholeNumberValue) return;
				SetAttributeValue("minvalueinteger", value);
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
        /// organizationid
        /// </summary>
		[DisplayName("Organization Id")]
		[AttributeLogicalName("organizationid")]
		public EntityReference OrganizationId
		{	
			get { return GetAttributeValue<EntityReference>("organizationid"); }
			set
			{ 
				if(value == OrganizationId) return;
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
        /// overwrittendynamicpropertyid
        /// </summary>
		[DisplayName("Overwritten Property")]
		[AttributeLogicalName("overwrittendynamicpropertyid")]
		public Guid OverwrittenPropertyId
		{	
			get { return GetAttributeValue<Guid>("overwrittendynamicpropertyid"); }
			set
			{ 
				if(value == OverwrittenPropertyId) return;
				SetAttributeValue("overwrittendynamicpropertyid", value);
			}
		}	
			
		/// <summary>
        /// precision
        /// </summary>
		[DisplayName("Precision")]
		[AttributeLogicalName("precision")]
		public int? Precision
		{	
			get { return GetAttributeValue<int?>("precision"); }
			set
			{ 
				if(value == Precision) return;
				SetAttributeValue("precision", value);
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
        /// rootdynamicpropertyid
        /// </summary>
		[DisplayName("Root Property")]
		[AttributeLogicalName("rootdynamicpropertyid")]
		public Guid RootPropertyId
		{	
			get { return GetAttributeValue<Guid>("rootdynamicpropertyid"); }
			set
			{ 
				if(value == RootPropertyId) return;
				SetAttributeValue("rootdynamicpropertyid", value);
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
		public eStatusCode? StatusReason
		{	
			get 
			{ 
				var optionSetValue = GetAttributeValue<OptionSetValue>("statuscode");
				if (optionSetValue != null) return (eStatusCode)optionSetValue.Value;
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
        /// 1:N Get entities for 'dynamicproperty_AsyncOperations'
        /// </summary>
		[RelationshipSchemaName("dynamicproperty_AsyncOperations")]
		public IEnumerable<SystemJob> DynamicpropertyAsyncOperations
		{
			get { return GetRelatedEntities<SystemJob>("dynamicproperty_AsyncOperations", null); }
			set { SetRelatedEntities("dynamicproperty_AsyncOperations", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'dynamicproperty_base_dynamicproperty'
        /// </summary>
		[RelationshipSchemaName("dynamicproperty_base_dynamicproperty")]
		public IEnumerable<Property> DynamicpropertyBaseDynamicproperty
		{
			get { return GetRelatedEntities<Property>("dynamicproperty_base_dynamicproperty", null); }
			set { SetRelatedEntities("dynamicproperty_base_dynamicproperty", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'dynamicproperty_BulkDeleteFailures'
        /// </summary>
		[RelationshipSchemaName("dynamicproperty_BulkDeleteFailures")]
		public IEnumerable<BulkDeleteFailure> DynamicpropertyBulkDeleteFailures
		{
			get { return GetRelatedEntities<BulkDeleteFailure>("dynamicproperty_BulkDeleteFailures", null); }
			set { SetRelatedEntities("dynamicproperty_BulkDeleteFailures", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'Dynamicproperty_DynamicPropertyAssociation'
        /// </summary>
		[RelationshipSchemaName("Dynamicproperty_DynamicPropertyAssociation")]
		public IEnumerable<PropertyAssociation> DynamicpropertyDynamicPropertyAssociation
		{
			get { return GetRelatedEntities<PropertyAssociation>("Dynamicproperty_DynamicPropertyAssociation", null); }
			set { SetRelatedEntities("Dynamicproperty_DynamicPropertyAssociation", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'DynamicProperty_DynamicPropertyInstance'
        /// </summary>
		[RelationshipSchemaName("DynamicProperty_DynamicPropertyInstance")]
		public IEnumerable<PropertyInstance> DynamicPropertyDynamicPropertyInstance
		{
			get { return GetRelatedEntities<PropertyInstance>("DynamicProperty_DynamicPropertyInstance", null); }
			set { SetRelatedEntities("DynamicProperty_DynamicPropertyInstance", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'DynamicProperty_DynamicPropertyOptionSetItem'
        /// </summary>
		[RelationshipSchemaName("DynamicProperty_DynamicPropertyOptionSetItem")]
		public IEnumerable<PropertyOptionSetItem> DynamicPropertyDynamicPropertyOptionSetItem
		{
			get { return GetRelatedEntities<PropertyOptionSetItem>("DynamicProperty_DynamicPropertyOptionSetItem", null); }
			set { SetRelatedEntities("DynamicProperty_DynamicPropertyOptionSetItem", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'dynamicproperty_MailboxTrackingFolders'
        /// </summary>
		[RelationshipSchemaName("dynamicproperty_MailboxTrackingFolders")]
		public IEnumerable<MailboxAutoTrackingFolder> DynamicpropertyMailboxTrackingFolders
		{
			get { return GetRelatedEntities<MailboxAutoTrackingFolder>("dynamicproperty_MailboxTrackingFolders", null); }
			set { SetRelatedEntities("dynamicproperty_MailboxTrackingFolders", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'dynamicproperty_PrincipalObjectAttributeAccesses'
        /// </summary>
		[RelationshipSchemaName("dynamicproperty_PrincipalObjectAttributeAccesses")]
		public IEnumerable<FieldSharing> DynamicpropertyPrincipalObjectAttributeAccesses
		{
			get { return GetRelatedEntities<FieldSharing>("dynamicproperty_PrincipalObjectAttributeAccesses", null); }
			set { SetRelatedEntities("dynamicproperty_PrincipalObjectAttributeAccesses", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'dynamicproperty_SyncErrors'
        /// </summary>
		[RelationshipSchemaName("dynamicproperty_SyncErrors")]
		public IEnumerable<SyncError> DynamicpropertySyncErrors
		{
			get { return GetRelatedEntities<SyncError>("dynamicproperty_SyncErrors", null); }
			set { SetRelatedEntities("dynamicproperty_SyncErrors", null, value); }
		}
		#endregion

		#region Actions
		#endregion

		#region OptionSetEnums
		public enum ePropertyDataType
		{	
		
			[Label("Option Set")]
			[Description(@"")]
			OptionSet = 0, 
		
			[Label("Decimal")]
			[Description(@"")]
			Decimal = 1, 
		
			[Label("Floating Point Number")]
			[Description(@"")]
			FloatingPointNumber = 2, 
		
			[Label("Single Line Of Text")]
			[Description(@"")]
			SingleLineOfText = 3, 
		
			[Label("Whole Number")]
			[Description(@"")]
			WholeNumber = 4, 
		}
		
		public enum eStatus
		{	
		
			[Label("Active")]
			[Description(@"")]
			Active = 0, 
		
			[Label("Draft")]
			[Description(@"")]
			Draft = 1, 
		
			[Label("Retired")]
			[Description(@"")]
			Retired = 2, 
		}
		
		public enum eStatusCode
		{	
		
			[Label("Active")]
			[Description(@"")]
			Active_Active = 1, 
		
			[Label("Draft")]
			[Description(@"")]
			Draft_Inactive = 0, 
		
			[Label("Retired")]
			[Description(@"")]
			Retired = 2, 
		}
		
		#endregion	

		#region Properties
		public static class Properties 
		{
			/// <summary>basedynamicpropertyid</summary>
			public const string BaseProperty = "basedynamicpropertyid";

			/// <summary>basedynamicpropertyidname</summary>
			public const string Basedynamicpropertyidname = "basedynamicpropertyidname";

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

			/// <summary>datatype</summary>
			public const string DataType = "datatype";

			/// <summary>defaultattributevalue</summary>
			public const string DefaultValue = "defaultattributevalue";

			/// <summary>defaultvaluedecimal</summary>
			public const string DefaultDecimalValue = "defaultvaluedecimal";

			/// <summary>defaultvaluedouble</summary>
			public const string DefaultDoubleValue = "defaultvaluedouble";

			/// <summary>defaultvalueinteger</summary>
			public const string DefaultWholeNumberValue = "defaultvalueinteger";

			/// <summary>defaultvalueoptionset</summary>
			public const string DefaultOptionSetValue = "defaultvalueoptionset";

			/// <summary>defaultvalueoptionsetname</summary>
			public const string Defaultvalueoptionsetname = "defaultvalueoptionsetname";

			/// <summary>defaultvaluestring</summary>
			public const string DefaultStringValue = "defaultvaluestring";

			/// <summary>description</summary>
			public const string Description = "description";

			/// <summary>dmtimportstate</summary>
			public const string InternalUseOnly = "dmtimportstate";

			/// <summary>dynamicpropertyid</summary>
			public const string PropertyId = "dynamicpropertyid";

			/// <summary>importsequencenumber</summary>
			public const string ImportSequenceNumber = "importsequencenumber";

			/// <summary>ishidden</summary>
			public const string Hidden = "ishidden";

			/// <summary>isreadonly</summary>
			public const string ReadOnly = "isreadonly";

			/// <summary>isrequired</summary>
			public const string Required = "isrequired";

			/// <summary>maxlengthstring</summary>
			public const string MaximumStringLength = "maxlengthstring";

			/// <summary>maxvaluedecimal</summary>
			public const string MaximumDecimalValue = "maxvaluedecimal";

			/// <summary>maxvaluedouble</summary>
			public const string MaximumDoubleValue = "maxvaluedouble";

			/// <summary>maxvalueinteger</summary>
			public const string MaximumWholeNumberValue = "maxvalueinteger";

			/// <summary>minvaluedecimal</summary>
			public const string MinimumDecimalValue = "minvaluedecimal";

			/// <summary>minvaluedouble</summary>
			public const string MinimumDoubleValue = "minvaluedouble";

			/// <summary>minvalueinteger</summary>
			public const string MinimumWholeNumberValue = "minvalueinteger";

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

			/// <summary>organizationid</summary>
			public const string OrganizationId = "organizationid";

			/// <summary>organizationidname</summary>
			public const string Organizationidname = "organizationidname";

			/// <summary>overriddencreatedon</summary>
			public const string RecordCreatedOn = "overriddencreatedon";

			/// <summary>overwrittendynamicpropertyid</summary>
			public const string OverwrittenPropertyId = "overwrittendynamicpropertyid";

			/// <summary>precision</summary>
			public const string Precision = "precision";

			/// <summary>regardingobjectid</summary>
			public const string Regarding = "regardingobjectid";

			/// <summary>regardingobjectidname</summary>
			public const string Regardingobjectidname = "regardingobjectidname";

			/// <summary>regardingobjectidyominame</summary>
			public const string Regardingobjectidyominame = "regardingobjectidyominame";

			/// <summary>regardingobjecttypecode</summary>
			public const string Regardingobjecttypecode = "regardingobjecttypecode";

			/// <summary>rootdynamicpropertyid</summary>
			public const string RootPropertyId = "rootdynamicpropertyid";

			/// <summary>statecode</summary>
			public const string Status = "statecode";

			/// <summary>statuscode</summary>
			public const string StatusReason = "statuscode";

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
			/// <summary>1:N dynamicproperty_AsyncOperations</summary>
			public const string DynamicpropertyAsyncOperations = "dynamicproperty_AsyncOperations";

			/// <summary>1:N dynamicproperty_base_dynamicproperty</summary>
			public const string DynamicpropertyBaseDynamicproperty = "dynamicproperty_base_dynamicproperty";

			/// <summary>1:N dynamicproperty_BulkDeleteFailures</summary>
			public const string DynamicpropertyBulkDeleteFailures = "dynamicproperty_BulkDeleteFailures";

			/// <summary>1:N Dynamicproperty_DynamicPropertyAssociation</summary>
			public const string DynamicpropertyDynamicPropertyAssociation = "Dynamicproperty_DynamicPropertyAssociation";

			/// <summary>1:N DynamicProperty_DynamicPropertyInstance</summary>
			public const string DynamicPropertyDynamicPropertyInstance = "DynamicProperty_DynamicPropertyInstance";

			/// <summary>1:N DynamicProperty_DynamicPropertyOptionSetItem</summary>
			public const string DynamicPropertyDynamicPropertyOptionSetItem = "DynamicProperty_DynamicPropertyOptionSetItem";

			/// <summary>1:N dynamicproperty_MailboxTrackingFolders</summary>
			public const string DynamicpropertyMailboxTrackingFolders = "dynamicproperty_MailboxTrackingFolders";

			/// <summary>1:N dynamicproperty_PrincipalObjectAttributeAccesses</summary>
			public const string DynamicpropertyPrincipalObjectAttributeAccesses = "dynamicproperty_PrincipalObjectAttributeAccesses";

			/// <summary>1:N dynamicproperty_SyncErrors</summary>
			public const string DynamicpropertySyncErrors = "dynamicproperty_SyncErrors";

		}
		#endregion
	}
}

