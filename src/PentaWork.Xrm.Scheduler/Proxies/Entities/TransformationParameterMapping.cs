using System;
using System.Linq;
using System.Diagnostics;
using System.ComponentModel;
using Microsoft.Xrm.Sdk; 
using Microsoft.Xrm.Sdk.Client;
using System.Collections.Generic;

namespace PentaWork.Xrm.Scheduler.Proxies.Entities
{
	[DebuggerDisplay("{Data}")] 	
	[EntityLogicalName("transformationparametermapping")]
	public sealed class TransformationParameterMapping : Entity
	{	
		public static readonly int? EntityTypeCode = 4427;
		public new const string LogicalName = "transformationparametermapping";
		public const string PrimaryIdAttribute = "transformationparametermappingid";
		public const string PrimaryNameAttribute = "data";
	
		public TransformationParameterMapping() : base("transformationparametermapping") { }

		#region Attributes
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
        /// data
        /// </summary>
		[DisplayName("Data")]
		[AttributeLogicalName("data")]
		public string Data
		{	
			get { return GetAttributeValue<string>("data"); }
			set
			{ 
				if(value == Data) return;
				SetAttributeValue("data", value);
			}
		}	
			
		/// <summary>
        /// datatypecode
        /// </summary>
		[DisplayName("Parameter Data Type")]
		[AttributeLogicalName("datatypecode")]
		public eParameterDataType? ParameterDataType
		{	
			get 
			{ 
				var optionSetValue = GetAttributeValue<OptionSetValue>("datatypecode");
				if (optionSetValue != null) return (eParameterDataType)optionSetValue.Value;
				else return null;
			}
			set 
			{ 
				if(value == ParameterDataType) return;

				OptionSetValue optionSetValue = null;
				if(value != null) optionSetValue = new OptionSetValue((int)value);
				SetAttributeValue("datatypecode", optionSetValue); 
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
        /// parameterarrayindex
        /// </summary>
		[DisplayName("Parameter Array Index")]
		[AttributeLogicalName("parameterarrayindex")]
		public int? ParameterArrayIndex
		{	
			get { return GetAttributeValue<int?>("parameterarrayindex"); }
			set
			{ 
				if(value == ParameterArrayIndex) return;
				SetAttributeValue("parameterarrayindex", value);
			}
		}	
			
		/// <summary>
        /// parametersequence
        /// </summary>
		[DisplayName("Parameter Sequence")]
		[AttributeLogicalName("parametersequence")]
		public int? ParameterSequence
		{	
			get { return GetAttributeValue<int?>("parametersequence"); }
			set
			{ 
				if(value == ParameterSequence) return;
				SetAttributeValue("parametersequence", value);
			}
		}	
			
		/// <summary>
        /// parametertypecode
        /// </summary>
		[DisplayName("Parameter Type")]
		[AttributeLogicalName("parametertypecode")]
		public eParameterType? ParameterType
		{	
			get 
			{ 
				var optionSetValue = GetAttributeValue<OptionSetValue>("parametertypecode");
				if (optionSetValue != null) return (eParameterType)optionSetValue.Value;
				else return null;
			}
			set 
			{ 
				if(value == ParameterType) return;

				OptionSetValue optionSetValue = null;
				if(value != null) optionSetValue = new OptionSetValue((int)value);
				SetAttributeValue("parametertypecode", optionSetValue); 
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
        /// transformationmappingid
        /// </summary>
		[DisplayName("Transformation Mapping Id")]
		[AttributeLogicalName("transformationmappingid")]
		public EntityReference TransformationMappingId
		{	
			get { return GetAttributeValue<EntityReference>("transformationmappingid"); }
			set
			{ 
				if(value == TransformationMappingId) return;
				SetAttributeValue("transformationmappingid", value);
			}
		}	
			
		/// <summary>
        /// transformationmappingidname
        /// </summary>
		[DisplayName("transformationmappingidname")]
		[AttributeLogicalName("transformationmappingidname")]
		public string Transformationmappingidname
		{	
			get { return GetAttributeValue<string>("transformationmappingidname"); }
			set
			{ 
				if(value == Transformationmappingidname) return;
				SetAttributeValue("transformationmappingidname", value);
			}
		}	
			
		/// <summary>
        /// transformationparametermappingid
        /// </summary>
		[DisplayName("transformationparametermappingid")]
		[AttributeLogicalName("transformationparametermappingid")]
		public override Guid Id
		{
			get => base.Id;
			set { base.Id = value; SetAttributeValue("transformationparametermappingid", value); }
		}

							/// <summary>
        /// transformationparametermappingidunique
        /// </summary>
		[DisplayName("transformationparametermappingidunique")]
		[AttributeLogicalName("transformationparametermappingidunique")]
		public Guid TransformationparametermappingiduniqueId
		{	
			get { return GetAttributeValue<Guid>("transformationparametermappingidunique"); }
			set
			{ 
				if(value == TransformationparametermappingiduniqueId) return;
				SetAttributeValue("transformationparametermappingidunique", value);
			}
		}	
			
		#endregion	

		#region Relations
			/// <summary>
        /// 1:N Get entities for 'LookUpMapping_TransformationParameterMapping'
        /// </summary>
		[RelationshipSchemaName("LookUpMapping_TransformationParameterMapping")]
		public IEnumerable<LookupMapping> LookUpMappingTransformationParameterMapping
		{
			get { return GetRelatedEntities<LookupMapping>("LookUpMapping_TransformationParameterMapping", null); }
			set { SetRelatedEntities("LookUpMapping_TransformationParameterMapping", null, value); }
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
		
		public enum eParameterDataType
		{	
		
			[Label("Reference")]
			[Description(@"")]
			Reference = 0, 
		
			[Label("Value")]
			[Description(@"")]
			Value = 1, 
		}
		
		public enum eParameterType
		{	
		
			[Label("Input")]
			[Description(@"")]
			Input = 0, 
		
			[Label("Output")]
			[Description(@"")]
			Output = 1, 
		}
		
		#endregion	

		#region Properties
		public static class Properties 
		{
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

			/// <summary>data</summary>
			public const string Data = "data";

			/// <summary>datatypecode</summary>
			public const string ParameterDataType = "datatypecode";

			/// <summary>introducedversion</summary>
			public const string IntroducedVersion = "introducedversion";

			/// <summary>ismanaged</summary>
			public const string State = "ismanaged";

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

			/// <summary>overwritetime</summary>
			public const string RecordOverwriteTime = "overwritetime";

			/// <summary>parameterarrayindex</summary>
			public const string ParameterArrayIndex = "parameterarrayindex";

			/// <summary>parametersequence</summary>
			public const string ParameterSequence = "parametersequence";

			/// <summary>parametertypecode</summary>
			public const string ParameterType = "parametertypecode";

			/// <summary>solutionid</summary>
			public const string SolutionId = "solutionid";

			/// <summary>supportingsolutionid</summary>
			public const string SolutionId2 = "supportingsolutionid";

			/// <summary>transformationmappingid</summary>
			public const string TransformationMappingId = "transformationmappingid";

			/// <summary>transformationmappingidname</summary>
			public const string Transformationmappingidname = "transformationmappingidname";

			/// <summary>transformationparametermappingid</summary>
			public const string TransformationparametermappingId = "transformationparametermappingid";

			/// <summary>transformationparametermappingidunique</summary>
			public const string TransformationparametermappingiduniqueId = "transformationparametermappingidunique";

		}
		#endregion

		#region Schemas
		public static class Schemas 
		{
			/// <summary>1:N LookUpMapping_TransformationParameterMapping</summary>
			public const string LookUpMappingTransformationParameterMapping = "LookUpMapping_TransformationParameterMapping";

		}
		#endregion
	}
}

