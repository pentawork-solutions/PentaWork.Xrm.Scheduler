using System;
using System.Linq;
using System.Diagnostics;
using System.ComponentModel;
using Microsoft.Xrm.Sdk; 
using Microsoft.Xrm.Sdk.Client;
using System.Collections.Generic;

namespace PentaWork.Xrm.Scheduler.Proxies.Entities
{
	[DebuggerDisplay("{SystemJobName}")] 	
	[EntityLogicalName("bulkdeleteoperation")]
	public sealed class BulkDeleteOperation : Entity
	{	
		public static readonly int? EntityTypeCode = 4424;
		public new const string LogicalName = "bulkdeleteoperation";
		public const string PrimaryIdAttribute = "bulkdeleteoperationid";
		public const string PrimaryNameAttribute = "name";
	
		public BulkDeleteOperation() : base("bulkdeleteoperation") { }

		#region Attributes
		/// <summary>
        /// asyncoperationid
        /// </summary>
		[DisplayName("System Job")]
		[AttributeLogicalName("asyncoperationid")]
		public EntityReference SystemJob
		{	
			get { return GetAttributeValue<EntityReference>("asyncoperationid"); }
			set
			{ 
				if(value == SystemJob) return;
				SetAttributeValue("asyncoperationid", value);
			}
		}	
			
		/// <summary>
        /// bulkdeleteoperationid
        /// </summary>
		[DisplayName("Bulk Deletion Job")]
		[AttributeLogicalName("bulkdeleteoperationid")]
		public override Guid Id
		{
			get => base.Id;
			set { base.Id = value; SetAttributeValue("bulkdeleteoperationid", value); }
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
		[DisplayName("createdonbehalfby")]
		[AttributeLogicalName("createdonbehalfby")]
		public EntityReference Createdonbehalfby
		{	
			get { return GetAttributeValue<EntityReference>("createdonbehalfby"); }
			set
			{ 
				if(value == Createdonbehalfby) return;
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
        /// failurecount
        /// </summary>
		[DisplayName("Failures")]
		[AttributeLogicalName("failurecount")]
		public int? Failures
		{	
			get { return GetAttributeValue<int?>("failurecount"); }
			set
			{ 
				if(value == Failures) return;
				SetAttributeValue("failurecount", value);
			}
		}	
			
		/// <summary>
        /// isrecurring
        /// </summary>
		[DisplayName("Is Recurring")]
		[AttributeLogicalName("isrecurring")]
		public bool? IsRecurring
		{	
			get { return GetAttributeValue<bool?>("isrecurring"); }
			set
			{ 
				if(value == IsRecurring) return;
				SetAttributeValue("isrecurring", value);
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
		[DisplayName("modifiedonbehalfby")]
		[AttributeLogicalName("modifiedonbehalfby")]
		public EntityReference Modifiedonbehalfby
		{	
			get { return GetAttributeValue<EntityReference>("modifiedonbehalfby"); }
			set
			{ 
				if(value == Modifiedonbehalfby) return;
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
		[DisplayName("System Job Name")]
		[AttributeLogicalName("name")]
		public string SystemJobName
		{	
			get { return GetAttributeValue<string>("name"); }
			set
			{ 
				if(value == SystemJobName) return;
				SetAttributeValue("name", value);
			}
		}	
			
		/// <summary>
        /// nextrun
        /// </summary>
		[DisplayName("Next Run")]
		[AttributeLogicalName("nextrun")]
		public DateTime? NextRun
		{	
			get { return GetAttributeValue<DateTime?>("nextrun"); }
			set
			{ 
				if(value == NextRun) return;
				SetAttributeValue("nextrun", value);
			}
		}	
			
		/// <summary>
        /// orderedquerysetxml
        /// </summary>
		[DisplayName("orderedquerysetxml")]
		[AttributeLogicalName("orderedquerysetxml")]
		public string Orderedquerysetxml
		{	
			get { return GetAttributeValue<string>("orderedquerysetxml"); }
			set
			{ 
				if(value == Orderedquerysetxml) return;
				SetAttributeValue("orderedquerysetxml", value);
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
        /// owninguser
        /// </summary>
		[DisplayName("owninguser")]
		[AttributeLogicalName("owninguser")]
		public EntityReference Owninguser
		{	
			get { return GetAttributeValue<EntityReference>("owninguser"); }
			set
			{ 
				if(value == Owninguser) return;
				SetAttributeValue("owninguser", value);
			}
		}	
			
		/// <summary>
        /// processingqeindex
        /// </summary>
		[DisplayName("Query Index")]
		[AttributeLogicalName("processingqeindex")]
		public int? QueryIndex
		{	
			get { return GetAttributeValue<int?>("processingqeindex"); }
			set
			{ 
				if(value == QueryIndex) return;
				SetAttributeValue("processingqeindex", value);
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

		/// <summary>
        /// successcount
        /// </summary>
		[DisplayName("Deleted")]
		[AttributeLogicalName("successcount")]
		public int? Deleted
		{	
			get { return GetAttributeValue<int?>("successcount"); }
			set
			{ 
				if(value == Deleted) return;
				SetAttributeValue("successcount", value);
			}
		}	
			
		/// <summary>
        /// timezoneruleversionnumber
        /// </summary>
		[DisplayName("timezoneruleversionnumber")]
		[AttributeLogicalName("timezoneruleversionnumber")]
		public int? Timezoneruleversionnumber
		{	
			get { return GetAttributeValue<int?>("timezoneruleversionnumber"); }
			set
			{ 
				if(value == Timezoneruleversionnumber) return;
				SetAttributeValue("timezoneruleversionnumber", value);
			}
		}	
			
		/// <summary>
        /// utcconversiontimezonecode
        /// </summary>
		[DisplayName("utcconversiontimezonecode")]
		[AttributeLogicalName("utcconversiontimezonecode")]
		public int? Utcconversiontimezonecode
		{	
			get { return GetAttributeValue<int?>("utcconversiontimezonecode"); }
			set
			{ 
				if(value == Utcconversiontimezonecode) return;
				SetAttributeValue("utcconversiontimezonecode", value);
			}
		}	
			
		#endregion	

		#region Relations
			/// <summary>
        /// 1:N Get entities for 'BulkDeleteOperation_BulkDeleteFailure'
        /// </summary>
		[RelationshipSchemaName("BulkDeleteOperation_BulkDeleteFailure")]
		public IEnumerable<BulkDeleteFailure> BulkDeleteOperationBulkDeleteFailure
		{
			get { return GetRelatedEntities<BulkDeleteFailure>("BulkDeleteOperation_BulkDeleteFailure", null); }
			set { SetRelatedEntities("BulkDeleteOperation_BulkDeleteFailure", null, value); }
		}
		#endregion

		#region Actions
		#endregion

		#region OptionSetEnums
		public enum eStatus
		{	
		
			[Label("Ready")]
			[Description(@"")]
			Ready = 0, 
		
			[Label("Suspended")]
			[Description(@"")]
			Suspended = 1, 
		
			[Label("Locked")]
			[Description(@"")]
			Locked = 2, 
		
			[Label("Completed")]
			[Description(@"")]
			Completed = 3, 
		}
		
		public enum eStatusReason
		{	
		
			[Label("Waiting For Resources")]
			[Description(@"")]
			WaitingForResources_Active = 0, 
		
			[Label("Waiting")]
			[Description(@"")]
			Waiting_Inactive = 10, 
		
			[Label("Retrying")]
			[Description(@"")]
			Retrying_Inactive = 11, 
		
			[Label("Paused")]
			[Description(@"")]
			Paused_Inactive = 12, 
		
			[Label("In Progress")]
			[Description(@"")]
			InProgress = 20, 
		
			[Label("Pausing")]
			[Description(@"")]
			Pausing = 21, 
		
			[Label("Canceling")]
			[Description(@"")]
			Canceling = 22, 
		
			[Label("Succeeded")]
			[Description(@"")]
			Succeeded = 30, 
		
			[Label("Failed")]
			[Description(@"")]
			Failed = 31, 
		
			[Label("Canceled")]
			[Description(@"")]
			Canceled = 32, 
		}
		
		#endregion	

		#region Properties
		public static class Properties 
		{
			/// <summary>asyncoperationid</summary>
			public const string SystemJob = "asyncoperationid";

			/// <summary>bulkdeleteoperationid</summary>
			public const string BulkDeletionJobId = "bulkdeleteoperationid";

			/// <summary>createdby</summary>
			public const string CreatedBy = "createdby";

			/// <summary>createdbyname</summary>
			public const string Createdbyname = "createdbyname";

			/// <summary>createdbyyominame</summary>
			public const string Createdbyyominame = "createdbyyominame";

			/// <summary>createdon</summary>
			public const string Createdon = "createdon";

			/// <summary>createdonbehalfby</summary>
			public const string Createdonbehalfby = "createdonbehalfby";

			/// <summary>createdonbehalfbyname</summary>
			public const string Createdonbehalfbyname = "createdonbehalfbyname";

			/// <summary>createdonbehalfbyyominame</summary>
			public const string Createdonbehalfbyyominame = "createdonbehalfbyyominame";

			/// <summary>failurecount</summary>
			public const string Failures = "failurecount";

			/// <summary>isrecurring</summary>
			public const string IsRecurring = "isrecurring";

			/// <summary>modifiedby</summary>
			public const string ModifiedBy = "modifiedby";

			/// <summary>modifiedbyname</summary>
			public const string Modifiedbyname = "modifiedbyname";

			/// <summary>modifiedbyyominame</summary>
			public const string Modifiedbyyominame = "modifiedbyyominame";

			/// <summary>modifiedon</summary>
			public const string ModifiedOn = "modifiedon";

			/// <summary>modifiedonbehalfby</summary>
			public const string Modifiedonbehalfby = "modifiedonbehalfby";

			/// <summary>modifiedonbehalfbyname</summary>
			public const string Modifiedonbehalfbyname = "modifiedonbehalfbyname";

			/// <summary>modifiedonbehalfbyyominame</summary>
			public const string Modifiedonbehalfbyyominame = "modifiedonbehalfbyyominame";

			/// <summary>name</summary>
			public const string SystemJobName = "name";

			/// <summary>nextrun</summary>
			public const string NextRun = "nextrun";

			/// <summary>orderedquerysetxml</summary>
			public const string Orderedquerysetxml = "orderedquerysetxml";

			/// <summary>ownerid</summary>
			public const string Owner = "ownerid";

			/// <summary>owneridtype</summary>
			public const string Owneridtype = "owneridtype";

			/// <summary>owningbusinessunit</summary>
			public const string OwningBusinessUnit = "owningbusinessunit";

			/// <summary>owninguser</summary>
			public const string Owninguser = "owninguser";

			/// <summary>processingqeindex</summary>
			public const string QueryIndex = "processingqeindex";

			/// <summary>statecode</summary>
			public const string Status = "statecode";

			/// <summary>statuscode</summary>
			public const string StatusReason = "statuscode";

			/// <summary>successcount</summary>
			public const string Deleted = "successcount";

			/// <summary>timezoneruleversionnumber</summary>
			public const string Timezoneruleversionnumber = "timezoneruleversionnumber";

			/// <summary>utcconversiontimezonecode</summary>
			public const string Utcconversiontimezonecode = "utcconversiontimezonecode";

		}
		#endregion

		#region Schemas
		public static class Schemas 
		{
			/// <summary>1:N BulkDeleteOperation_BulkDeleteFailure</summary>
			public const string BulkDeleteOperationBulkDeleteFailure = "BulkDeleteOperation_BulkDeleteFailure";

		}
		#endregion
	}
}

