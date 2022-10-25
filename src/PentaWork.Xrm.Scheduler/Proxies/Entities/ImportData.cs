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
	[EntityLogicalName("importdata")]
	public sealed class ImportData : Entity
	{	
		public static readonly int? EntityTypeCode = 4413;
		public new const string LogicalName = "importdata";
		public const string PrimaryIdAttribute = "importdataid";
		public const string PrimaryNameAttribute = "data";
	
		public ImportData() : base("importdata") { }

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
		[DisplayName("createdon")]
		[AttributeLogicalName("createdon")]
		public DateTime? Createdon
		{	
			get { return GetAttributeValue<DateTime?>("createdon"); }
			set
			{ 
				if(value == Createdon) return;
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
        /// errortype
        /// </summary>
		[DisplayName("Error Type")]
		[AttributeLogicalName("errortype")]
		public eErrorType? ErrorType
		{	
			get 
			{ 
				var optionSetValue = GetAttributeValue<OptionSetValue>("errortype");
				if (optionSetValue != null) return (eErrorType)optionSetValue.Value;
				else return null;
			}
			set 
			{ 
				if(value == ErrorType) return;

				OptionSetValue optionSetValue = null;
				if(value != null) optionSetValue = new OptionSetValue((int)value);
				SetAttributeValue("errortype", optionSetValue); 
			}
		}

		/// <summary>
        /// haserror
        /// </summary>
		[DisplayName("Has Error")]
		[AttributeLogicalName("haserror")]
		public bool? HasError
		{	
			get { return GetAttributeValue<bool?>("haserror"); }
			set
			{ 
				if(value == HasError) return;
				SetAttributeValue("haserror", value);
			}
		}	
			
		/// <summary>
        /// importdataid
        /// </summary>
		[DisplayName("importdataid")]
		[AttributeLogicalName("importdataid")]
		public override Guid Id
		{
			get => base.Id;
			set { base.Id = value; SetAttributeValue("importdataid", value); }
		}

							/// <summary>
        /// importfileid
        /// </summary>
		[DisplayName("Import File Id")]
		[AttributeLogicalName("importfileid")]
		public EntityReference ImportFileId
		{	
			get { return GetAttributeValue<EntityReference>("importfileid"); }
			set
			{ 
				if(value == ImportFileId) return;
				SetAttributeValue("importfileid", value);
			}
		}	
			
		/// <summary>
        /// importfileidname
        /// </summary>
		[DisplayName("importfileidname")]
		[AttributeLogicalName("importfileidname")]
		public string Importfileidname
		{	
			get { return GetAttributeValue<string>("importfileidname"); }
			set
			{ 
				if(value == Importfileidname) return;
				SetAttributeValue("importfileidname", value);
			}
		}	
			
		/// <summary>
        /// linenumber
        /// </summary>
		[DisplayName("Line Number")]
		[AttributeLogicalName("linenumber")]
		public int? LineNumber
		{	
			get { return GetAttributeValue<int?>("linenumber"); }
			set
			{ 
				if(value == LineNumber) return;
				SetAttributeValue("linenumber", value);
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
		[DisplayName("owningbusinessunit")]
		[AttributeLogicalName("owningbusinessunit")]
		public EntityReference Owningbusinessunit
		{	
			get { return GetAttributeValue<EntityReference>("owningbusinessunit"); }
			set
			{ 
				if(value == Owningbusinessunit) return;
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
        /// recordid
        /// </summary>
		[DisplayName("Record")]
		[AttributeLogicalName("recordid")]
		public Guid RecordId
		{	
			get { return GetAttributeValue<Guid>("recordid"); }
			set
			{ 
				if(value == RecordId) return;
				SetAttributeValue("recordid", value);
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

		#endregion	

		#region Relations
			/// <summary>
        /// 1:N Get entities for 'ImportData_AsyncOperations'
        /// </summary>
		[RelationshipSchemaName("ImportData_AsyncOperations")]
		public IEnumerable<SystemJob> ImportDataAsyncOperations
		{
			get { return GetRelatedEntities<SystemJob>("ImportData_AsyncOperations", null); }
			set { SetRelatedEntities("ImportData_AsyncOperations", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'ImportData_BulkDeleteFailures'
        /// </summary>
		[RelationshipSchemaName("ImportData_BulkDeleteFailures")]
		public IEnumerable<BulkDeleteFailure> ImportDataBulkDeleteFailures
		{
			get { return GetRelatedEntities<BulkDeleteFailure>("ImportData_BulkDeleteFailures", null); }
			set { SetRelatedEntities("ImportData_BulkDeleteFailures", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'ImportLog_ImportData'
        /// </summary>
		[RelationshipSchemaName("ImportLog_ImportData")]
		public IEnumerable<ImportLog> ImportLogImportData
		{
			get { return GetRelatedEntities<ImportLog>("ImportLog_ImportData", null); }
			set { SetRelatedEntities("ImportLog_ImportData", null, value); }
		}
		#endregion

		#region Actions
		#endregion

		#region OptionSetEnums
		public enum eErrorType
		{	
		
			[Label("Create")]
			[Description(@"")]
			Create = 0, 
		
			[Label("Update")]
			[Description(@"")]
			Update = 1, 
		}
		
		public enum eStatus
		{	
		
			[Label("Active")]
			[Description(@"")]
			Active = 0, 
		}
		
		public enum eStatusReason
		{	
		
			[Label("Active")]
			[Description(@"")]
			Active_Active = 0, 
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
			public const string Createdon = "createdon";

			/// <summary>createdonbehalfby</summary>
			public const string CreatedByDelegate = "createdonbehalfby";

			/// <summary>createdonbehalfbyname</summary>
			public const string Createdonbehalfbyname = "createdonbehalfbyname";

			/// <summary>createdonbehalfbyyominame</summary>
			public const string Createdonbehalfbyyominame = "createdonbehalfbyyominame";

			/// <summary>data</summary>
			public const string Data = "data";

			/// <summary>errortype</summary>
			public const string ErrorType = "errortype";

			/// <summary>haserror</summary>
			public const string HasError = "haserror";

			/// <summary>importdataid</summary>
			public const string ImportdataId = "importdataid";

			/// <summary>importfileid</summary>
			public const string ImportFileId = "importfileid";

			/// <summary>importfileidname</summary>
			public const string Importfileidname = "importfileidname";

			/// <summary>linenumber</summary>
			public const string LineNumber = "linenumber";

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

			/// <summary>ownerid</summary>
			public const string Owner = "ownerid";

			/// <summary>owneridname</summary>
			public const string Owneridname = "owneridname";

			/// <summary>owneridtype</summary>
			public const string Owneridtype = "owneridtype";

			/// <summary>owneridyominame</summary>
			public const string Owneridyominame = "owneridyominame";

			/// <summary>owningbusinessunit</summary>
			public const string Owningbusinessunit = "owningbusinessunit";

			/// <summary>owningteam</summary>
			public const string OwningTeam = "owningteam";

			/// <summary>owninguser</summary>
			public const string OwningUser = "owninguser";

			/// <summary>recordid</summary>
			public const string RecordId = "recordid";

			/// <summary>statecode</summary>
			public const string Status = "statecode";

			/// <summary>statuscode</summary>
			public const string StatusReason = "statuscode";

		}
		#endregion

		#region Schemas
		public static class Schemas 
		{
			/// <summary>1:N ImportData_AsyncOperations</summary>
			public const string ImportDataAsyncOperations = "ImportData_AsyncOperations";

			/// <summary>1:N ImportData_BulkDeleteFailures</summary>
			public const string ImportDataBulkDeleteFailures = "ImportData_BulkDeleteFailures";

			/// <summary>1:N ImportLog_ImportData</summary>
			public const string ImportLogImportData = "ImportLog_ImportData";

		}
		#endregion
	}
}

