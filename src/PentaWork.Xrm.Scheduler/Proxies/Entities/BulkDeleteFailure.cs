using System;
using System.Linq;
using System.Diagnostics;
using System.ComponentModel;
using Microsoft.Xrm.Sdk; 
using Microsoft.Xrm.Sdk.Client;
using System.Collections.Generic;

namespace PentaWork.Xrm.Scheduler.Proxies.Entities
{
	
	[EntityLogicalName("bulkdeletefailure")]
	public sealed class BulkDeleteFailure : Entity
	{	
		public static readonly int? EntityTypeCode = 4425;
		public new const string LogicalName = "bulkdeletefailure";
		public const string PrimaryIdAttribute = "bulkdeletefailureid";
		public const string PrimaryNameAttribute = "";
	
		public BulkDeleteFailure() : base("bulkdeletefailure") { }

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
        /// bulkdeletefailureid
        /// </summary>
		[DisplayName("Bulk Deletion Failure")]
		[AttributeLogicalName("bulkdeletefailureid")]
		public override Guid Id
		{
			get => base.Id;
			set { base.Id = value; SetAttributeValue("bulkdeletefailureid", value); }
		}

							/// <summary>
        /// bulkdeleteoperationid
        /// </summary>
		[DisplayName("bulkdeleteoperationid")]
		[AttributeLogicalName("bulkdeleteoperationid")]
		public EntityReference Bulkdeleteoperationid
		{	
			get { return GetAttributeValue<EntityReference>("bulkdeleteoperationid"); }
			set
			{ 
				if(value == Bulkdeleteoperationid) return;
				SetAttributeValue("bulkdeleteoperationid", value);
			}
		}	
			
		/// <summary>
        /// errordescription
        /// </summary>
		[DisplayName("Error Description")]
		[AttributeLogicalName("errordescription")]
		public string ErrorDescription
		{	
			get { return GetAttributeValue<string>("errordescription"); }
			set
			{ 
				if(value == ErrorDescription) return;
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
        /// orderedqueryindex
        /// </summary>
		[DisplayName("Index")]
		[AttributeLogicalName("orderedqueryindex")]
		public int? Index
		{	
			get { return GetAttributeValue<int?>("orderedqueryindex"); }
			set
			{ 
				if(value == Index) return;
				SetAttributeValue("orderedqueryindex", value);
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
		[DisplayName("Name")]
		[AttributeLogicalName("regardingobjectid")]
		public EntityReference Name
		{	
			get { return GetAttributeValue<EntityReference>("regardingobjectid"); }
			set
			{ 
				if(value == Name) return;
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

			/// <summary>bulkdeletefailureid</summary>
			public const string BulkDeletionFailureId = "bulkdeletefailureid";

			/// <summary>bulkdeleteoperationid</summary>
			public const string Bulkdeleteoperationid = "bulkdeleteoperationid";

			/// <summary>errordescription</summary>
			public const string ErrorDescription = "errordescription";

			/// <summary>errornumber</summary>
			public const string ErrorCode = "errornumber";

			/// <summary>orderedqueryindex</summary>
			public const string Index = "orderedqueryindex";

			/// <summary>ownerid</summary>
			public const string Owner = "ownerid";

			/// <summary>owneridtype</summary>
			public const string Owneridtype = "owneridtype";

			/// <summary>owningbusinessunit</summary>
			public const string OwningBusinessUnitId = "owningbusinessunit";

			/// <summary>owninguser</summary>
			public const string OwningUserId = "owninguser";

			/// <summary>regardingobjectid</summary>
			public const string Name = "regardingobjectid";

			/// <summary>regardingobjectidname</summary>
			public const string Regardingobjectidname = "regardingobjectidname";

			/// <summary>regardingobjectidyominame</summary>
			public const string Regardingobjectidyominame = "regardingobjectidyominame";

			/// <summary>regardingobjecttypecode</summary>
			public const string Regardingobjecttypecode = "regardingobjecttypecode";

		}
		#endregion

		#region Schemas
		public static class Schemas 
		{
		}
		#endregion
	}
}

