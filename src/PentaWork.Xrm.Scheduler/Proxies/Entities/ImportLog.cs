using System;
using System.Linq;
using System.Diagnostics;
using System.ComponentModel;
using Microsoft.Xrm.Sdk; 
using Microsoft.Xrm.Sdk.Client;
using System.Collections.Generic;

namespace PentaWork.Xrm.Scheduler.Proxies.Entities
{
	
	[EntityLogicalName("importlog")]
	public sealed class ImportLog : Entity
	{	
		public static readonly int? EntityTypeCode = 4423;
		public new const string LogicalName = "importlog";
		public const string PrimaryIdAttribute = "importlogid";
		public const string PrimaryNameAttribute = "";
	
		public ImportLog() : base("importlog") { }

		#region Attributes
		/// <summary>
        /// additionalinfo
        /// </summary>
		[DisplayName("More Information")]
		[AttributeLogicalName("additionalinfo")]
		public string MoreInformation
		{	
			get { return GetAttributeValue<string>("additionalinfo"); }
			set
			{ 
				if(value == MoreInformation) return;
				SetAttributeValue("additionalinfo", value);
			}
		}	
			
		/// <summary>
        /// columnvalue
        /// </summary>
		[DisplayName("Column Value")]
		[AttributeLogicalName("columnvalue")]
		public string ColumnValue
		{	
			get { return GetAttributeValue<string>("columnvalue"); }
			set
			{ 
				if(value == ColumnValue) return;
				SetAttributeValue("columnvalue", value);
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
        /// errordescription
        /// </summary>
		[DisplayName("Description")]
		[AttributeLogicalName("errordescription")]
		public string Description
		{	
			get { return GetAttributeValue<string>("errordescription"); }
			set
			{ 
				if(value == Description) return;
				SetAttributeValue("errordescription", value);
			}
		}	
			
		/// <summary>
        /// errornumber
        /// </summary>
		[DisplayName("Error Code")]
		[AttributeLogicalName("errornumber")]
		public int? ErrorCode
		{	
			get { return GetAttributeValue<int?>("errornumber"); }
			set
			{ 
				if(value == ErrorCode) return;
				SetAttributeValue("errornumber", value);
			}
		}	
			
		/// <summary>
        /// headercolumn
        /// </summary>
		[DisplayName("Column Heading")]
		[AttributeLogicalName("headercolumn")]
		public string ColumnHeading
		{	
			get { return GetAttributeValue<string>("headercolumn"); }
			set
			{ 
				if(value == ColumnHeading) return;
				SetAttributeValue("headercolumn", value);
			}
		}	
			
		/// <summary>
        /// importdataid
        /// </summary>
		[DisplayName("Source Row")]
		[AttributeLogicalName("importdataid")]
		public EntityReference SourceRow
		{	
			get { return GetAttributeValue<EntityReference>("importdataid"); }
			set
			{ 
				if(value == SourceRow) return;
				SetAttributeValue("importdataid", value);
			}
		}	
			
		/// <summary>
        /// importdataidname
        /// </summary>
		[DisplayName("importdataidname")]
		[AttributeLogicalName("importdataidname")]
		public string Importdataidname
		{	
			get { return GetAttributeValue<string>("importdataidname"); }
			set
			{ 
				if(value == Importdataidname) return;
				SetAttributeValue("importdataidname", value);
			}
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
        /// importlogid
        /// </summary>
		[DisplayName("importlogid")]
		[AttributeLogicalName("importlogid")]
		public override Guid Id
		{
			get => base.Id;
			set { base.Id = value; SetAttributeValue("importlogid", value); }
		}

							/// <summary>
        /// linenumber
        /// </summary>
		[DisplayName("Original Row Number")]
		[AttributeLogicalName("linenumber")]
		public int? OriginalRowNumber
		{	
			get { return GetAttributeValue<int?>("linenumber"); }
			set
			{ 
				if(value == OriginalRowNumber) return;
				SetAttributeValue("linenumber", value);
			}
		}	
			
		/// <summary>
        /// logphasecode
        /// </summary>
		[DisplayName("Log Phase")]
		[AttributeLogicalName("logphasecode")]
		public eLogPhase? LogPhase
		{	
			get 
			{ 
				var optionSetValue = GetAttributeValue<OptionSetValue>("logphasecode");
				if (optionSetValue != null) return (eLogPhase)optionSetValue.Value;
				else return null;
			}
			set 
			{ 
				if(value == LogPhase) return;

				OptionSetValue optionSetValue = null;
				if(value != null) optionSetValue = new OptionSetValue((int)value);
				SetAttributeValue("logphasecode", optionSetValue); 
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
        /// sequencenumber
        /// </summary>
		[DisplayName("Sequence Number")]
		[AttributeLogicalName("sequencenumber")]
		public int? SequenceNumber
		{	
			get { return GetAttributeValue<int?>("sequencenumber"); }
			set
			{ 
				if(value == SequenceNumber) return;
				SetAttributeValue("sequencenumber", value);
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
        /// 1:N Get entities for 'ImportLog_AsyncOperations'
        /// </summary>
		[RelationshipSchemaName("ImportLog_AsyncOperations")]
		public IEnumerable<SystemJob> ImportLogAsyncOperations
		{
			get { return GetRelatedEntities<SystemJob>("ImportLog_AsyncOperations", null); }
			set { SetRelatedEntities("ImportLog_AsyncOperations", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'ImportLog_BulkDeleteFailures'
        /// </summary>
		[RelationshipSchemaName("ImportLog_BulkDeleteFailures")]
		public IEnumerable<BulkDeleteFailure> ImportLogBulkDeleteFailures
		{
			get { return GetRelatedEntities<BulkDeleteFailure>("ImportLog_BulkDeleteFailures", null); }
			set { SetRelatedEntities("ImportLog_BulkDeleteFailures", null, value); }
		}
		#endregion

		#region Actions
		#endregion

		#region OptionSetEnums
		public enum eLogPhase
		{	
		
			[Label("Parse")]
			[Description(@"")]
			Parse = 0, 
		
			[Label("Transform")]
			[Description(@"")]
			Transform = 1, 
		
			[Label("Import Create")]
			[Description(@"")]
			ImportCreate = 2, 
		
			[Label("Import Update")]
			[Description(@"")]
			ImportUpdate = 3, 
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
			/// <summary>additionalinfo</summary>
			public const string MoreInformation = "additionalinfo";

			/// <summary>columnvalue</summary>
			public const string ColumnValue = "columnvalue";

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

			/// <summary>errordescription</summary>
			public const string Description = "errordescription";

			/// <summary>errornumber</summary>
			public const string ErrorCode = "errornumber";

			/// <summary>headercolumn</summary>
			public const string ColumnHeading = "headercolumn";

			/// <summary>importdataid</summary>
			public const string SourceRow = "importdataid";

			/// <summary>importdataidname</summary>
			public const string Importdataidname = "importdataidname";

			/// <summary>importfileid</summary>
			public const string ImportFileId = "importfileid";

			/// <summary>importfileidname</summary>
			public const string Importfileidname = "importfileidname";

			/// <summary>importlogid</summary>
			public const string ImportlogId = "importlogid";

			/// <summary>linenumber</summary>
			public const string OriginalRowNumber = "linenumber";

			/// <summary>logphasecode</summary>
			public const string LogPhase = "logphasecode";

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
			public const string OwningBusinessUnit = "owningbusinessunit";

			/// <summary>owningteam</summary>
			public const string OwningTeam = "owningteam";

			/// <summary>owninguser</summary>
			public const string OwningUser = "owninguser";

			/// <summary>sequencenumber</summary>
			public const string SequenceNumber = "sequencenumber";

			/// <summary>statecode</summary>
			public const string Status = "statecode";

			/// <summary>statuscode</summary>
			public const string StatusReason = "statuscode";

		}
		#endregion

		#region Schemas
		public static class Schemas 
		{
			/// <summary>1:N ImportLog_AsyncOperations</summary>
			public const string ImportLogAsyncOperations = "ImportLog_AsyncOperations";

			/// <summary>1:N ImportLog_BulkDeleteFailures</summary>
			public const string ImportLogBulkDeleteFailures = "ImportLog_BulkDeleteFailures";

		}
		#endregion
	}
}

