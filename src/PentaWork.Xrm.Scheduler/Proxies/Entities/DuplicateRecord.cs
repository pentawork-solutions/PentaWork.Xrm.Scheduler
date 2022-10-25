using System;
using System.Linq;
using System.Diagnostics;
using System.ComponentModel;
using Microsoft.Xrm.Sdk; 
using Microsoft.Xrm.Sdk.Client;
using System.Collections.Generic;

namespace PentaWork.Xrm.Scheduler.Proxies.Entities
{
	
	[EntityLogicalName("duplicaterecord")]
	public sealed class DuplicateRecord : Entity
	{	
		public static readonly int? EntityTypeCode = 4415;
		public new const string LogicalName = "duplicaterecord";
		public const string PrimaryIdAttribute = "duplicateid";
		public const string PrimaryNameAttribute = "";
	
		public DuplicateRecord() : base("duplicaterecord") { }

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
        /// baserecordid
        /// </summary>
		[DisplayName("Base Record ID")]
		[AttributeLogicalName("baserecordid")]
		public EntityReference BaseRecordID
		{	
			get { return GetAttributeValue<EntityReference>("baserecordid"); }
			set
			{ 
				if(value == BaseRecordID) return;
				SetAttributeValue("baserecordid", value);
			}
		}	
			
		/// <summary>
        /// baserecordidname
        /// </summary>
		[DisplayName("baserecordidname")]
		[AttributeLogicalName("baserecordidname")]
		public string Baserecordidname
		{	
			get { return GetAttributeValue<string>("baserecordidname"); }
			set
			{ 
				if(value == Baserecordidname) return;
				SetAttributeValue("baserecordidname", value);
			}
		}	
			
		/// <summary>
        /// baserecordidtypecode
        /// </summary>
		[DisplayName("baserecordidtypecode")]
		[AttributeLogicalName("baserecordidtypecode")]
		public string Baserecordidtypecode
		{	
			get { return GetAttributeValue<string>("baserecordidtypecode"); }
			set
			{ 
				if(value == Baserecordidtypecode) return;
				SetAttributeValue("baserecordidtypecode", value);
			}
		}	
			
		/// <summary>
        /// baserecordidyominame
        /// </summary>
		[DisplayName("baserecordidyominame")]
		[AttributeLogicalName("baserecordidyominame")]
		public string Baserecordidyominame
		{	
			get { return GetAttributeValue<string>("baserecordidyominame"); }
			set
			{ 
				if(value == Baserecordidyominame) return;
				SetAttributeValue("baserecordidyominame", value);
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
        /// duplicateid
        /// </summary>
		[DisplayName("duplicateid")]
		[AttributeLogicalName("duplicateid")]
		public override Guid Id
		{
			get => base.Id;
			set { base.Id = value; SetAttributeValue("duplicateid", value); }
		}

							/// <summary>
        /// duplicaterecordid
        /// </summary>
		[DisplayName("Duplicate Record ID")]
		[AttributeLogicalName("duplicaterecordid")]
		public EntityReference DuplicateRecordID
		{	
			get { return GetAttributeValue<EntityReference>("duplicaterecordid"); }
			set
			{ 
				if(value == DuplicateRecordID) return;
				SetAttributeValue("duplicaterecordid", value);
			}
		}	
			
		/// <summary>
        /// duplicaterecordidname
        /// </summary>
		[DisplayName("duplicaterecordidname")]
		[AttributeLogicalName("duplicaterecordidname")]
		public string Duplicaterecordidname
		{	
			get { return GetAttributeValue<string>("duplicaterecordidname"); }
			set
			{ 
				if(value == Duplicaterecordidname) return;
				SetAttributeValue("duplicaterecordidname", value);
			}
		}	
			
		/// <summary>
        /// duplicaterecordidtypecode
        /// </summary>
		[DisplayName("duplicaterecordidtypecode")]
		[AttributeLogicalName("duplicaterecordidtypecode")]
		public string Duplicaterecordidtypecode
		{	
			get { return GetAttributeValue<string>("duplicaterecordidtypecode"); }
			set
			{ 
				if(value == Duplicaterecordidtypecode) return;
				SetAttributeValue("duplicaterecordidtypecode", value);
			}
		}	
			
		/// <summary>
        /// duplicaterecordidyominame
        /// </summary>
		[DisplayName("duplicaterecordidyominame")]
		[AttributeLogicalName("duplicaterecordidyominame")]
		public string Duplicaterecordidyominame
		{	
			get { return GetAttributeValue<string>("duplicaterecordidyominame"); }
			set
			{ 
				if(value == Duplicaterecordidyominame) return;
				SetAttributeValue("duplicaterecordidyominame", value);
			}
		}	
			
		/// <summary>
        /// duplicateruleid
        /// </summary>
		[DisplayName("duplicateruleid")]
		[AttributeLogicalName("duplicateruleid")]
		public EntityReference Duplicateruleid
		{	
			get { return GetAttributeValue<EntityReference>("duplicateruleid"); }
			set
			{ 
				if(value == Duplicateruleid) return;
				SetAttributeValue("duplicateruleid", value);
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
			/// <summary>asyncoperationid</summary>
			public const string SystemJob = "asyncoperationid";

			/// <summary>baserecordid</summary>
			public const string BaseRecordID = "baserecordid";

			/// <summary>baserecordidname</summary>
			public const string Baserecordidname = "baserecordidname";

			/// <summary>baserecordidtypecode</summary>
			public const string Baserecordidtypecode = "baserecordidtypecode";

			/// <summary>baserecordidyominame</summary>
			public const string Baserecordidyominame = "baserecordidyominame";

			/// <summary>createdon</summary>
			public const string Createdon = "createdon";

			/// <summary>duplicateid</summary>
			public const string DuplicateId = "duplicateid";

			/// <summary>duplicaterecordid</summary>
			public const string DuplicateRecordID = "duplicaterecordid";

			/// <summary>duplicaterecordidname</summary>
			public const string Duplicaterecordidname = "duplicaterecordidname";

			/// <summary>duplicaterecordidtypecode</summary>
			public const string Duplicaterecordidtypecode = "duplicaterecordidtypecode";

			/// <summary>duplicaterecordidyominame</summary>
			public const string Duplicaterecordidyominame = "duplicaterecordidyominame";

			/// <summary>duplicateruleid</summary>
			public const string Duplicateruleid = "duplicateruleid";

			/// <summary>ownerid</summary>
			public const string Owner = "ownerid";

			/// <summary>owneridtype</summary>
			public const string Owneridtype = "owneridtype";

			/// <summary>owningbusinessunit</summary>
			public const string OwningBusinessUnitId = "owningbusinessunit";

			/// <summary>owninguser</summary>
			public const string OwningUserId = "owninguser";

		}
		#endregion

		#region Schemas
		public static class Schemas 
		{
		}
		#endregion
	}
}

