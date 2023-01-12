using System;
using System.Linq;
using System.Diagnostics;
using System.ComponentModel;
using Microsoft.Xrm.Sdk; 
using Microsoft.Xrm.Sdk.Client;
using System.Collections.Generic;

namespace PentaWork.Xrm.Scheduler.Proxies.Entities
{
	[DebuggerDisplay("{MsdynName}")] 	
	[EntityLogicalName("msdyn_solutioncomponentsummary")]
	public sealed class SolutionComponentSummary : Entity
	{	
		public static readonly int? EntityTypeCode = 10011;
		public new const string LogicalName = "msdyn_solutioncomponentsummary";
		public const string PrimaryIdAttribute = "msdyn_solutioncomponentsummaryid";
		public const string PrimaryNameAttribute = "msdyn_name";
	
		public SolutionComponentSummary() : base("msdyn_solutioncomponentsummary") { }

		#region Attributes
		/// <summary>
        /// msdyn_canvasappuniqueid
        /// </summary>
		[DisplayName("Canvas App Unique Id")]
		[AttributeLogicalName("msdyn_canvasappuniqueid")]
		public string CanvasAppUniqueId
		{	
			get { return GetAttributeValue<string>("msdyn_canvasappuniqueid"); }
			set
			{ 
				if(value == CanvasAppUniqueId) return;
				SetAttributeValue("msdyn_canvasappuniqueid", value);
			}
		}	
			
		/// <summary>
        /// msdyn_componentlogicalname
        /// </summary>
		[DisplayName("Component Logical Name")]
		[AttributeLogicalName("msdyn_componentlogicalname")]
		public string ComponentLogicalName
		{	
			get { return GetAttributeValue<string>("msdyn_componentlogicalname"); }
			set
			{ 
				if(value == ComponentLogicalName) return;
				SetAttributeValue("msdyn_componentlogicalname", value);
			}
		}	
			
		/// <summary>
        /// msdyn_componenttype
		///
		/// Precision: 2
		/// MaxValue: 100000000000
		/// MinValue: -100000000000
        /// </summary>
		[DisplayName("msdyn_componenttype")]
		[AttributeLogicalName("msdyn_componenttype")]
		public decimal? MsdynComponenttype
		{	
			get { return GetAttributeValue<decimal?>("msdyn_componenttype"); }
			set 
			{
				decimal? decimalValue = null;
				if(value != null) decimalValue = Decimal.Round(value.Value, 2);
				if(decimalValue == MsdynComponenttype) return;
				SetAttributeValue("msdyn_componenttype", decimalValue);  
			}
		}

		/// <summary>
        /// msdyn_componenttypename
        /// </summary>
		[DisplayName("Component Type Name")]
		[AttributeLogicalName("msdyn_componenttypename")]
		public string ComponentTypeName
		{	
			get { return GetAttributeValue<string>("msdyn_componenttypename"); }
			set
			{ 
				if(value == ComponentTypeName) return;
				SetAttributeValue("msdyn_componenttypename", value);
			}
		}	
			
		/// <summary>
        /// msdyn_connectorinternalid
        /// </summary>
		[DisplayName("Connector Internal Id")]
		[AttributeLogicalName("msdyn_connectorinternalid")]
		public string ConnectorInternalId
		{	
			get { return GetAttributeValue<string>("msdyn_connectorinternalid"); }
			set
			{ 
				if(value == ConnectorInternalId) return;
				SetAttributeValue("msdyn_connectorinternalid", value);
			}
		}	
			
		/// <summary>
        /// msdyn_createdon
        /// </summary>
		[DisplayName("msdyn_createdon")]
		[AttributeLogicalName("msdyn_createdon")]
		public string MsdynCreatedon
		{	
			get { return GetAttributeValue<string>("msdyn_createdon"); }
			set
			{ 
				if(value == MsdynCreatedon) return;
				SetAttributeValue("msdyn_createdon", value);
			}
		}	
			
		/// <summary>
        /// msdyn_culture
        /// </summary>
		[DisplayName("msdyn_culture")]
		[AttributeLogicalName("msdyn_culture")]
		public string MsdynCulture
		{	
			get { return GetAttributeValue<string>("msdyn_culture"); }
			set
			{ 
				if(value == MsdynCulture) return;
				SetAttributeValue("msdyn_culture", value);
			}
		}	
			
		/// <summary>
        /// msdyn_deployment
        /// </summary>
		[DisplayName("msdyn_deployment")]
		[AttributeLogicalName("msdyn_deployment")]
		public string MsdynDeployment
		{	
			get { return GetAttributeValue<string>("msdyn_deployment"); }
			set
			{ 
				if(value == MsdynDeployment) return;
				SetAttributeValue("msdyn_deployment", value);
			}
		}	
			
		/// <summary>
        /// msdyn_description
        /// </summary>
		[DisplayName("msdyn_description")]
		[AttributeLogicalName("msdyn_description")]
		public string MsdynDescription
		{	
			get { return GetAttributeValue<string>("msdyn_description"); }
			set
			{ 
				if(value == MsdynDescription) return;
				SetAttributeValue("msdyn_description", value);
			}
		}	
			
		/// <summary>
        /// msdyn_displayname
        /// </summary>
		[DisplayName("msdyn_displayname")]
		[AttributeLogicalName("msdyn_displayname")]
		public string MsdynDisplayname
		{	
			get { return GetAttributeValue<string>("msdyn_displayname"); }
			set
			{ 
				if(value == MsdynDisplayname) return;
				SetAttributeValue("msdyn_displayname", value);
			}
		}	
			
		/// <summary>
        /// msdyn_eventhandler
        /// </summary>
		[DisplayName("msdyn_eventhandler")]
		[AttributeLogicalName("msdyn_eventhandler")]
		public string MsdynEventhandler
		{	
			get { return GetAttributeValue<string>("msdyn_eventhandler"); }
			set
			{ 
				if(value == MsdynEventhandler) return;
				SetAttributeValue("msdyn_eventhandler", value);
			}
		}	
			
		/// <summary>
        /// msdyn_executionorder
        /// </summary>
		[DisplayName("msdyn_executionorder")]
		[AttributeLogicalName("msdyn_executionorder")]
		public string MsdynExecutionorder
		{	
			get { return GetAttributeValue<string>("msdyn_executionorder"); }
			set
			{ 
				if(value == MsdynExecutionorder) return;
				SetAttributeValue("msdyn_executionorder", value);
			}
		}	
			
		/// <summary>
        /// msdyn_executionstage
        /// </summary>
		[DisplayName("msdyn_executionstage")]
		[AttributeLogicalName("msdyn_executionstage")]
		public string MsdynExecutionstage
		{	
			get { return GetAttributeValue<string>("msdyn_executionstage"); }
			set
			{ 
				if(value == MsdynExecutionstage) return;
				SetAttributeValue("msdyn_executionstage", value);
			}
		}	
			
		/// <summary>
        /// msdyn_fieldsecurity
        /// </summary>
		[DisplayName("Field Security")]
		[AttributeLogicalName("msdyn_fieldsecurity")]
		public string FieldSecurity
		{	
			get { return GetAttributeValue<string>("msdyn_fieldsecurity"); }
			set
			{ 
				if(value == FieldSecurity) return;
				SetAttributeValue("msdyn_fieldsecurity", value);
			}
		}	
			
		/// <summary>
        /// msdyn_fieldtype
        /// </summary>
		[DisplayName("Field Type")]
		[AttributeLogicalName("msdyn_fieldtype")]
		public string FieldType
		{	
			get { return GetAttributeValue<string>("msdyn_fieldtype"); }
			set
			{ 
				if(value == FieldType) return;
				SetAttributeValue("msdyn_fieldtype", value);
			}
		}	
			
		/// <summary>
        /// msdyn_isappaware
        /// </summary>
		[DisplayName("msdyn_isappaware")]
		[AttributeLogicalName("msdyn_isappaware")]
		public string MsdynIsappaware
		{	
			get { return GetAttributeValue<string>("msdyn_isappaware"); }
			set
			{ 
				if(value == MsdynIsappaware) return;
				SetAttributeValue("msdyn_isappaware", value);
			}
		}	
			
		/// <summary>
        /// msdyn_isappawarename
        /// </summary>
		[DisplayName("App Aware Name")]
		[AttributeLogicalName("msdyn_isappawarename")]
		public string AppAwareName
		{	
			get { return GetAttributeValue<string>("msdyn_isappawarename"); }
			set
			{ 
				if(value == AppAwareName) return;
				SetAttributeValue("msdyn_isappawarename", value);
			}
		}	
			
		/// <summary>
        /// msdyn_isauditenabled
        /// </summary>
		[DisplayName("msdyn_isauditenabled")]
		[AttributeLogicalName("msdyn_isauditenabled")]
		public string MsdynIsauditenabled
		{	
			get { return GetAttributeValue<string>("msdyn_isauditenabled"); }
			set
			{ 
				if(value == MsdynIsauditenabled) return;
				SetAttributeValue("msdyn_isauditenabled", value);
			}
		}	
			
		/// <summary>
        /// msdyn_isauditenabledname
        /// </summary>
		[DisplayName("Audit Name")]
		[AttributeLogicalName("msdyn_isauditenabledname")]
		public string AuditName
		{	
			get { return GetAttributeValue<string>("msdyn_isauditenabledname"); }
			set
			{ 
				if(value == AuditName) return;
				SetAttributeValue("msdyn_isauditenabledname", value);
			}
		}	
			
		/// <summary>
        /// msdyn_iscustom
        /// </summary>
		[DisplayName("msdyn_iscustom")]
		[AttributeLogicalName("msdyn_iscustom")]
		public string MsdynIscustom
		{	
			get { return GetAttributeValue<string>("msdyn_iscustom"); }
			set
			{ 
				if(value == MsdynIscustom) return;
				SetAttributeValue("msdyn_iscustom", value);
			}
		}	
			
		/// <summary>
        /// msdyn_iscustomizable
        /// </summary>
		[DisplayName("msdyn_iscustomizable")]
		[AttributeLogicalName("msdyn_iscustomizable")]
		public string MsdynIscustomizable
		{	
			get { return GetAttributeValue<string>("msdyn_iscustomizable"); }
			set
			{ 
				if(value == MsdynIscustomizable) return;
				SetAttributeValue("msdyn_iscustomizable", value);
			}
		}	
			
		/// <summary>
        /// msdyn_iscustomizablename
        /// </summary>
		[DisplayName("Customizable Name")]
		[AttributeLogicalName("msdyn_iscustomizablename")]
		public string CustomizableName
		{	
			get { return GetAttributeValue<string>("msdyn_iscustomizablename"); }
			set
			{ 
				if(value == CustomizableName) return;
				SetAttributeValue("msdyn_iscustomizablename", value);
			}
		}	
			
		/// <summary>
        /// msdyn_iscustomname
        /// </summary>
		[DisplayName("Is Custom Name")]
		[AttributeLogicalName("msdyn_iscustomname")]
		public string IsCustomName
		{	
			get { return GetAttributeValue<string>("msdyn_iscustomname"); }
			set
			{ 
				if(value == IsCustomName) return;
				SetAttributeValue("msdyn_iscustomname", value);
			}
		}	
			
		/// <summary>
        /// msdyn_isdefault
        /// </summary>
		[DisplayName("Default")]
		[AttributeLogicalName("msdyn_isdefault")]
		public string Default
		{	
			get { return GetAttributeValue<string>("msdyn_isdefault"); }
			set
			{ 
				if(value == Default) return;
				SetAttributeValue("msdyn_isdefault", value);
			}
		}	
			
		/// <summary>
        /// msdyn_isdefaultname
        /// </summary>
		[DisplayName("Default Name")]
		[AttributeLogicalName("msdyn_isdefaultname")]
		public string DefaultName
		{	
			get { return GetAttributeValue<string>("msdyn_isdefaultname"); }
			set
			{ 
				if(value == DefaultName) return;
				SetAttributeValue("msdyn_isdefaultname", value);
			}
		}	
			
		/// <summary>
        /// msdyn_ismanaged
        /// </summary>
		[DisplayName("msdyn_ismanaged")]
		[AttributeLogicalName("msdyn_ismanaged")]
		public string MsdynIsmanaged
		{	
			get { return GetAttributeValue<string>("msdyn_ismanaged"); }
			set
			{ 
				if(value == MsdynIsmanaged) return;
				SetAttributeValue("msdyn_ismanaged", value);
			}
		}	
			
		/// <summary>
        /// msdyn_ismanagedname
        /// </summary>
		[DisplayName("Managed Name")]
		[AttributeLogicalName("msdyn_ismanagedname")]
		public string ManagedName
		{	
			get { return GetAttributeValue<string>("msdyn_ismanagedname"); }
			set
			{ 
				if(value == ManagedName) return;
				SetAttributeValue("msdyn_ismanagedname", value);
			}
		}	
			
		/// <summary>
        /// msdyn_isolationmode
        /// </summary>
		[DisplayName("msdyn_isolationmode")]
		[AttributeLogicalName("msdyn_isolationmode")]
		public string MsdynIsolationmode
		{	
			get { return GetAttributeValue<string>("msdyn_isolationmode"); }
			set
			{ 
				if(value == MsdynIsolationmode) return;
				SetAttributeValue("msdyn_isolationmode", value);
			}
		}	
			
		/// <summary>
        /// msdyn_istableenabled
        /// </summary>
		[DisplayName("msdyn_istableenabled")]
		[AttributeLogicalName("msdyn_istableenabled")]
		public string MsdynIstableenabled
		{	
			get { return GetAttributeValue<string>("msdyn_istableenabled"); }
			set
			{ 
				if(value == MsdynIstableenabled) return;
				SetAttributeValue("msdyn_istableenabled", value);
			}
		}	
			
		/// <summary>
        /// msdyn_logicalcollectionname
        /// </summary>
		[DisplayName("Logical Collection Name")]
		[AttributeLogicalName("msdyn_logicalcollectionname")]
		public string LogicalCollectionName
		{	
			get { return GetAttributeValue<string>("msdyn_logicalcollectionname"); }
			set
			{ 
				if(value == LogicalCollectionName) return;
				SetAttributeValue("msdyn_logicalcollectionname", value);
			}
		}	
			
		/// <summary>
        /// msdyn_modifiedon
        /// </summary>
		[DisplayName("msdyn_modifiedon")]
		[AttributeLogicalName("msdyn_modifiedon")]
		public string MsdynModifiedon
		{	
			get { return GetAttributeValue<string>("msdyn_modifiedon"); }
			set
			{ 
				if(value == MsdynModifiedon) return;
				SetAttributeValue("msdyn_modifiedon", value);
			}
		}	
			
		/// <summary>
        /// msdyn_name
        /// </summary>
		[DisplayName("msdyn_name")]
		[AttributeLogicalName("msdyn_name")]
		public string MsdynName
		{	
			get { return GetAttributeValue<string>("msdyn_name"); }
			set
			{ 
				if(value == MsdynName) return;
				SetAttributeValue("msdyn_name", value);
			}
		}	
			
		/// <summary>
        /// msdyn_objectid
        /// </summary>
		[DisplayName("msdyn_objectid")]
		[AttributeLogicalName("msdyn_objectid")]
		public string MsdynObjectid
		{	
			get { return GetAttributeValue<string>("msdyn_objectid"); }
			set
			{ 
				if(value == MsdynObjectid) return;
				SetAttributeValue("msdyn_objectid", value);
			}
		}	
			
		/// <summary>
        /// msdyn_objecttypecode
        /// </summary>
		[DisplayName("msdyn_objecttypecode")]
		[AttributeLogicalName("msdyn_objecttypecode")]
		public string MsdynObjecttypecode
		{	
			get { return GetAttributeValue<string>("msdyn_objecttypecode"); }
			set
			{ 
				if(value == MsdynObjecttypecode) return;
				SetAttributeValue("msdyn_objecttypecode", value);
			}
		}	
			
		/// <summary>
        /// msdyn_owner
        /// </summary>
		[DisplayName("msdyn_owner")]
		[AttributeLogicalName("msdyn_owner")]
		public string MsdynOwner
		{	
			get { return GetAttributeValue<string>("msdyn_owner"); }
			set
			{ 
				if(value == MsdynOwner) return;
				SetAttributeValue("msdyn_owner", value);
			}
		}	
			
		/// <summary>
        /// msdyn_owningbusinessunit
        /// </summary>
		[DisplayName("owning business unit")]
		[AttributeLogicalName("msdyn_owningbusinessunit")]
		public string OwningBusinessUnit
		{	
			get { return GetAttributeValue<string>("msdyn_owningbusinessunit"); }
			set
			{ 
				if(value == OwningBusinessUnit) return;
				SetAttributeValue("msdyn_owningbusinessunit", value);
			}
		}	
			
		/// <summary>
        /// msdyn_primaryentityname
        /// </summary>
		[DisplayName("Primary Entity Name")]
		[AttributeLogicalName("msdyn_primaryentityname")]
		public string PrimaryEntityName
		{	
			get { return GetAttributeValue<string>("msdyn_primaryentityname"); }
			set
			{ 
				if(value == PrimaryEntityName) return;
				SetAttributeValue("msdyn_primaryentityname", value);
			}
		}	
			
		/// <summary>
        /// msdyn_publickeytoken
        /// </summary>
		[DisplayName("msdyn_publickeytoken")]
		[AttributeLogicalName("msdyn_publickeytoken")]
		public string MsdynPublickeytoken
		{	
			get { return GetAttributeValue<string>("msdyn_publickeytoken"); }
			set
			{ 
				if(value == MsdynPublickeytoken) return;
				SetAttributeValue("msdyn_publickeytoken", value);
			}
		}	
			
		/// <summary>
        /// msdyn_relatedentity
        /// </summary>
		[DisplayName("Related Entity")]
		[AttributeLogicalName("msdyn_relatedentity")]
		public string RelatedEntity
		{	
			get { return GetAttributeValue<string>("msdyn_relatedentity"); }
			set
			{ 
				if(value == RelatedEntity) return;
				SetAttributeValue("msdyn_relatedentity", value);
			}
		}	
			
		/// <summary>
        /// msdyn_relatedentityattribute
        /// </summary>
		[DisplayName("Related Entity Attribute Name")]
		[AttributeLogicalName("msdyn_relatedentityattribute")]
		public string RelatedEntityAttributeName
		{	
			get { return GetAttributeValue<string>("msdyn_relatedentityattribute"); }
			set
			{ 
				if(value == RelatedEntityAttributeName) return;
				SetAttributeValue("msdyn_relatedentityattribute", value);
			}
		}	
			
		/// <summary>
        /// msdyn_schemaname
        /// </summary>
		[DisplayName("msdyn_schemaname")]
		[AttributeLogicalName("msdyn_schemaname")]
		public string MsdynSchemaname
		{	
			get { return GetAttributeValue<string>("msdyn_schemaname"); }
			set
			{ 
				if(value == MsdynSchemaname) return;
				SetAttributeValue("msdyn_schemaname", value);
			}
		}	
			
		/// <summary>
        /// msdyn_sdkmessagename
        /// </summary>
		[DisplayName("msdyn_sdkmessagename")]
		[AttributeLogicalName("msdyn_sdkmessagename")]
		public string MsdynSdkmessagename
		{	
			get { return GetAttributeValue<string>("msdyn_sdkmessagename"); }
			set
			{ 
				if(value == MsdynSdkmessagename) return;
				SetAttributeValue("msdyn_sdkmessagename", value);
			}
		}	
			
		/// <summary>
        /// msdyn_solutioncomponentsummaryid
        /// </summary>
		[DisplayName("SolutionComponentSummary")]
		[AttributeLogicalName("msdyn_solutioncomponentsummaryid")]
		public override Guid Id
		{
			get => base.Id;
			set { base.Id = value; SetAttributeValue("msdyn_solutioncomponentsummaryid", value); }
		}

							/// <summary>
        /// msdyn_solutionid
        /// </summary>
		[DisplayName("msdyn_solutionid")]
		[AttributeLogicalName("msdyn_solutionid")]
		public string MsdynSolutionid
		{	
			get { return GetAttributeValue<string>("msdyn_solutionid"); }
			set
			{ 
				if(value == MsdynSolutionid) return;
				SetAttributeValue("msdyn_solutionid", value);
			}
		}	
			
		/// <summary>
        /// msdyn_status
        /// </summary>
		[DisplayName("msdyn_status")]
		[AttributeLogicalName("msdyn_status")]
		public string MsdynStatus
		{	
			get { return GetAttributeValue<string>("msdyn_status"); }
			set
			{ 
				if(value == MsdynStatus) return;
				SetAttributeValue("msdyn_status", value);
			}
		}	
			
		/// <summary>
        /// msdyn_statusname
        /// </summary>
		[DisplayName("Status Name")]
		[AttributeLogicalName("msdyn_statusname")]
		public string StatusName
		{	
			get { return GetAttributeValue<string>("msdyn_statusname"); }
			set
			{ 
				if(value == StatusName) return;
				SetAttributeValue("msdyn_statusname", value);
			}
		}	
			
		/// <summary>
        /// msdyn_subtype
        /// </summary>
		[DisplayName("msdyn_subtype")]
		[AttributeLogicalName("msdyn_subtype")]
		public string MsdynSubtype
		{	
			get { return GetAttributeValue<string>("msdyn_subtype"); }
			set
			{ 
				if(value == MsdynSubtype) return;
				SetAttributeValue("msdyn_subtype", value);
			}
		}	
			
		/// <summary>
        /// msdyn_synctoexternalsearchindex
        /// </summary>
		[DisplayName("msdyn_synctoexternalsearchindex")]
		[AttributeLogicalName("msdyn_synctoexternalsearchindex")]
		public string MsdynSynctoexternalsearchindex
		{	
			get { return GetAttributeValue<string>("msdyn_synctoexternalsearchindex"); }
			set
			{ 
				if(value == MsdynSynctoexternalsearchindex) return;
				SetAttributeValue("msdyn_synctoexternalsearchindex", value);
			}
		}	
			
		/// <summary>
        /// msdyn_total
		///
		/// Precision: 2
		/// MaxValue: 100000000000
		/// MinValue: -100000000000
        /// </summary>
		[DisplayName("msdyn_total")]
		[AttributeLogicalName("msdyn_total")]
		public decimal? MsdynTotal
		{	
			get { return GetAttributeValue<decimal?>("msdyn_total"); }
			set 
			{
				decimal? decimalValue = null;
				if(value != null) decimalValue = Decimal.Round(value.Value, 2);
				if(decimalValue == MsdynTotal) return;
				SetAttributeValue("msdyn_total", decimalValue);  
			}
		}

		/// <summary>
        /// msdyn_typename
        /// </summary>
		[DisplayName("msdyn_typename")]
		[AttributeLogicalName("msdyn_typename")]
		public string MsdynTypename
		{	
			get { return GetAttributeValue<string>("msdyn_typename"); }
			set
			{ 
				if(value == MsdynTypename) return;
				SetAttributeValue("msdyn_typename", value);
			}
		}	
			
		/// <summary>
        /// msdyn_uniquename
        /// </summary>
		[DisplayName("msdyn_uniquename")]
		[AttributeLogicalName("msdyn_uniquename")]
		public string MsdynUniquename
		{	
			get { return GetAttributeValue<string>("msdyn_uniquename"); }
			set
			{ 
				if(value == MsdynUniquename) return;
				SetAttributeValue("msdyn_uniquename", value);
			}
		}	
			
		/// <summary>
        /// msdyn_version
        /// </summary>
		[DisplayName("msdyn_version")]
		[AttributeLogicalName("msdyn_version")]
		public string MsdynVersion
		{	
			get { return GetAttributeValue<string>("msdyn_version"); }
			set
			{ 
				if(value == MsdynVersion) return;
				SetAttributeValue("msdyn_version", value);
			}
		}	
			
		/// <summary>
        /// msdyn_workflowcategory
        /// </summary>
		[DisplayName("msdyn_workflowcategory")]
		[AttributeLogicalName("msdyn_workflowcategory")]
		public string MsdynWorkflowcategory
		{	
			get { return GetAttributeValue<string>("msdyn_workflowcategory"); }
			set
			{ 
				if(value == MsdynWorkflowcategory) return;
				SetAttributeValue("msdyn_workflowcategory", value);
			}
		}	
			
		/// <summary>
        /// msdyn_workflowcategoryname
        /// </summary>
		[DisplayName("Workflow Category Name")]
		[AttributeLogicalName("msdyn_workflowcategoryname")]
		public string WorkflowCategoryName
		{	
			get { return GetAttributeValue<string>("msdyn_workflowcategoryname"); }
			set
			{ 
				if(value == WorkflowCategoryName) return;
				SetAttributeValue("msdyn_workflowcategoryname", value);
			}
		}	
			
		/// <summary>
        /// msdyn_workflowidunique
        /// </summary>
		[DisplayName("Workflow Id Unique")]
		[AttributeLogicalName("msdyn_workflowidunique")]
		public string WorkflowIdUnique
		{	
			get { return GetAttributeValue<string>("msdyn_workflowidunique"); }
			set
			{ 
				if(value == WorkflowIdUnique) return;
				SetAttributeValue("msdyn_workflowidunique", value);
			}
		}	
			
		/// <summary>
        /// organizationid
        /// </summary>
		[DisplayName("Organization Id")]
		[AttributeLogicalName("organizationid")]
		public Guid OrganizationId
		{	
			get { return GetAttributeValue<Guid>("organizationid"); }
			set
			{ 
				if(value == OrganizationId) return;
				SetAttributeValue("organizationid", value);
			}
		}	
			
		#endregion	

		#region Relations
			#endregion

		#region Actions
		#endregion

		#region OptionSetEnums
		#endregion	

		#region Properties
		public static class Properties 
		{
			/// <summary>msdyn_canvasappuniqueid</summary>
			public const string CanvasAppUniqueId = "msdyn_canvasappuniqueid";

			/// <summary>msdyn_componentlogicalname</summary>
			public const string ComponentLogicalName = "msdyn_componentlogicalname";

			/// <summary>msdyn_componenttype</summary>
			public const string MsdynComponenttype = "msdyn_componenttype";

			/// <summary>msdyn_componenttypename</summary>
			public const string ComponentTypeName = "msdyn_componenttypename";

			/// <summary>msdyn_connectorinternalid</summary>
			public const string ConnectorInternalId = "msdyn_connectorinternalid";

			/// <summary>msdyn_createdon</summary>
			public const string MsdynCreatedon = "msdyn_createdon";

			/// <summary>msdyn_culture</summary>
			public const string MsdynCulture = "msdyn_culture";

			/// <summary>msdyn_deployment</summary>
			public const string MsdynDeployment = "msdyn_deployment";

			/// <summary>msdyn_description</summary>
			public const string MsdynDescription = "msdyn_description";

			/// <summary>msdyn_displayname</summary>
			public const string MsdynDisplayname = "msdyn_displayname";

			/// <summary>msdyn_eventhandler</summary>
			public const string MsdynEventhandler = "msdyn_eventhandler";

			/// <summary>msdyn_executionorder</summary>
			public const string MsdynExecutionorder = "msdyn_executionorder";

			/// <summary>msdyn_executionstage</summary>
			public const string MsdynExecutionstage = "msdyn_executionstage";

			/// <summary>msdyn_fieldsecurity</summary>
			public const string FieldSecurity = "msdyn_fieldsecurity";

			/// <summary>msdyn_fieldtype</summary>
			public const string FieldType = "msdyn_fieldtype";

			/// <summary>msdyn_isappaware</summary>
			public const string MsdynIsappaware = "msdyn_isappaware";

			/// <summary>msdyn_isappawarename</summary>
			public const string AppAwareName = "msdyn_isappawarename";

			/// <summary>msdyn_isauditenabled</summary>
			public const string MsdynIsauditenabled = "msdyn_isauditenabled";

			/// <summary>msdyn_isauditenabledname</summary>
			public const string AuditName = "msdyn_isauditenabledname";

			/// <summary>msdyn_iscustom</summary>
			public const string MsdynIscustom = "msdyn_iscustom";

			/// <summary>msdyn_iscustomizable</summary>
			public const string MsdynIscustomizable = "msdyn_iscustomizable";

			/// <summary>msdyn_iscustomizablename</summary>
			public const string CustomizableName = "msdyn_iscustomizablename";

			/// <summary>msdyn_iscustomname</summary>
			public const string IsCustomName = "msdyn_iscustomname";

			/// <summary>msdyn_isdefault</summary>
			public const string Default = "msdyn_isdefault";

			/// <summary>msdyn_isdefaultname</summary>
			public const string DefaultName = "msdyn_isdefaultname";

			/// <summary>msdyn_ismanaged</summary>
			public const string MsdynIsmanaged = "msdyn_ismanaged";

			/// <summary>msdyn_ismanagedname</summary>
			public const string ManagedName = "msdyn_ismanagedname";

			/// <summary>msdyn_isolationmode</summary>
			public const string MsdynIsolationmode = "msdyn_isolationmode";

			/// <summary>msdyn_istableenabled</summary>
			public const string MsdynIstableenabled = "msdyn_istableenabled";

			/// <summary>msdyn_logicalcollectionname</summary>
			public const string LogicalCollectionName = "msdyn_logicalcollectionname";

			/// <summary>msdyn_modifiedon</summary>
			public const string MsdynModifiedon = "msdyn_modifiedon";

			/// <summary>msdyn_name</summary>
			public const string MsdynName = "msdyn_name";

			/// <summary>msdyn_objectid</summary>
			public const string MsdynObjectid = "msdyn_objectid";

			/// <summary>msdyn_objecttypecode</summary>
			public const string MsdynObjecttypecode = "msdyn_objecttypecode";

			/// <summary>msdyn_owner</summary>
			public const string MsdynOwner = "msdyn_owner";

			/// <summary>msdyn_owningbusinessunit</summary>
			public const string OwningBusinessUnit = "msdyn_owningbusinessunit";

			/// <summary>msdyn_primaryentityname</summary>
			public const string PrimaryEntityName = "msdyn_primaryentityname";

			/// <summary>msdyn_publickeytoken</summary>
			public const string MsdynPublickeytoken = "msdyn_publickeytoken";

			/// <summary>msdyn_relatedentity</summary>
			public const string RelatedEntity = "msdyn_relatedentity";

			/// <summary>msdyn_relatedentityattribute</summary>
			public const string RelatedEntityAttributeName = "msdyn_relatedentityattribute";

			/// <summary>msdyn_schemaname</summary>
			public const string MsdynSchemaname = "msdyn_schemaname";

			/// <summary>msdyn_sdkmessagename</summary>
			public const string MsdynSdkmessagename = "msdyn_sdkmessagename";

			/// <summary>msdyn_solutioncomponentsummaryid</summary>
			public const string SolutionComponentSummaryId = "msdyn_solutioncomponentsummaryid";

			/// <summary>msdyn_solutionid</summary>
			public const string MsdynSolutionid = "msdyn_solutionid";

			/// <summary>msdyn_status</summary>
			public const string MsdynStatus = "msdyn_status";

			/// <summary>msdyn_statusname</summary>
			public const string StatusName = "msdyn_statusname";

			/// <summary>msdyn_subtype</summary>
			public const string MsdynSubtype = "msdyn_subtype";

			/// <summary>msdyn_synctoexternalsearchindex</summary>
			public const string MsdynSynctoexternalsearchindex = "msdyn_synctoexternalsearchindex";

			/// <summary>msdyn_total</summary>
			public const string MsdynTotal = "msdyn_total";

			/// <summary>msdyn_typename</summary>
			public const string MsdynTypename = "msdyn_typename";

			/// <summary>msdyn_uniquename</summary>
			public const string MsdynUniquename = "msdyn_uniquename";

			/// <summary>msdyn_version</summary>
			public const string MsdynVersion = "msdyn_version";

			/// <summary>msdyn_workflowcategory</summary>
			public const string MsdynWorkflowcategory = "msdyn_workflowcategory";

			/// <summary>msdyn_workflowcategoryname</summary>
			public const string WorkflowCategoryName = "msdyn_workflowcategoryname";

			/// <summary>msdyn_workflowidunique</summary>
			public const string WorkflowIdUnique = "msdyn_workflowidunique";

			/// <summary>organizationid</summary>
			public const string OrganizationId = "organizationid";

		}
		#endregion

		#region Schemas
		public static class Schemas 
		{
		}
		#endregion
	}
}

