using System;
using System.Linq;
using System.Diagnostics;
using System.ComponentModel;
using Microsoft.Xrm.Sdk; 
using Microsoft.Xrm.Sdk.Client;
using System.Collections.Generic;

namespace PentaWork.Xrm.Scheduler.Proxies.Entities
{
	
	[EntityLogicalName("exchangesyncidmapping")]
	public sealed class ExchangeSyncIdMapping : Entity
	{	
		public static readonly int? EntityTypeCode = 4120;
		public new const string LogicalName = "exchangesyncidmapping";
		public const string PrimaryIdAttribute = "exchangesyncidmappingid";
		public const string PrimaryNameAttribute = "";
	
		public ExchangeSyncIdMapping() : base("exchangesyncidmapping") { }

		#region Attributes
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
        /// exchangeentryid
        /// </summary>
		[DisplayName("Exchange Id")]
		[AttributeLogicalName("exchangeentryid")]
		public string ExchangeId
		{	
			get { return GetAttributeValue<string>("exchangeentryid"); }
			set
			{ 
				if(value == ExchangeId) return;
				SetAttributeValue("exchangeentryid", value);
			}
		}	
			
		/// <summary>
        /// exchangesyncidmappingid
        /// </summary>
		[DisplayName("exchangesyncidmappingid")]
		[AttributeLogicalName("exchangesyncidmappingid")]
		public override Guid Id
		{
			get => base.Id;
			set { base.Id = value; SetAttributeValue("exchangesyncidmappingid", value); }
		}

							/// <summary>
        /// fromcrmchangetype
        /// </summary>
		[DisplayName("fromcrmchangetype")]
		[AttributeLogicalName("fromcrmchangetype")]
		public int? Fromcrmchangetype
		{	
			get { return GetAttributeValue<int?>("fromcrmchangetype"); }
			set
			{ 
				if(value == Fromcrmchangetype) return;
				SetAttributeValue("fromcrmchangetype", value);
			}
		}	
			
		/// <summary>
        /// isdeletedinexchange
        /// </summary>
		[DisplayName("isdeletedinexchange")]
		[AttributeLogicalName("isdeletedinexchange")]
		public bool? Isdeletedinexchange
		{	
			get { return GetAttributeValue<bool?>("isdeletedinexchange"); }
			set
			{ 
				if(value == Isdeletedinexchange) return;
				SetAttributeValue("isdeletedinexchange", value);
			}
		}	
			
		/// <summary>
        /// isunlinkedincrm
        /// </summary>
		[DisplayName("isunlinkedincrm")]
		[AttributeLogicalName("isunlinkedincrm")]
		public bool? Isunlinkedincrm
		{	
			get { return GetAttributeValue<bool?>("isunlinkedincrm"); }
			set
			{ 
				if(value == Isunlinkedincrm) return;
				SetAttributeValue("isunlinkedincrm", value);
			}
		}	
			
		/// <summary>
        /// itemsubject
        /// </summary>
		[DisplayName("Item Subject")]
		[AttributeLogicalName("itemsubject")]
		public string ItemSubject
		{	
			get { return GetAttributeValue<string>("itemsubject"); }
			set
			{ 
				if(value == ItemSubject) return;
				SetAttributeValue("itemsubject", value);
			}
		}	
			
		/// <summary>
        /// lastsyncerror
        /// </summary>
		[DisplayName("Sync Error")]
		[AttributeLogicalName("lastsyncerror")]
		public string SyncError
		{	
			get { return GetAttributeValue<string>("lastsyncerror"); }
			set
			{ 
				if(value == SyncError) return;
				SetAttributeValue("lastsyncerror", value);
			}
		}	
			
		/// <summary>
        /// lastsyncerrorcode
        /// </summary>
		[DisplayName("lastsyncerrorcode")]
		[AttributeLogicalName("lastsyncerrorcode")]
		public int? Lastsyncerrorcode
		{	
			get { return GetAttributeValue<int?>("lastsyncerrorcode"); }
			set
			{ 
				if(value == Lastsyncerrorcode) return;
				SetAttributeValue("lastsyncerrorcode", value);
			}
		}	
			
		/// <summary>
        /// lastsyncerroroccurredon
        /// </summary>
		[DisplayName("Last Sync Error Time")]
		[AttributeLogicalName("lastsyncerroroccurredon")]
		public DateTime? LastSyncErrorTime
		{	
			get { return GetAttributeValue<DateTime?>("lastsyncerroroccurredon"); }
			set
			{ 
				if(value == LastSyncErrorTime) return;
				SetAttributeValue("lastsyncerroroccurredon", value);
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
        /// objectid
        /// </summary>
		[DisplayName("Crm Id")]
		[AttributeLogicalName("objectid")]
		public Guid CrmId
		{	
			get { return GetAttributeValue<Guid>("objectid"); }
			set
			{ 
				if(value == CrmId) return;
				SetAttributeValue("objectid", value);
			}
		}	
			
		/// <summary>
        /// objecttypecode
        /// </summary>
		[DisplayName("Object Type Code")]
		[AttributeLogicalName("objecttypecode")]
		public int? ObjectTypeCode
		{	
			get { return GetAttributeValue<int?>("objecttypecode"); }
			set
			{ 
				if(value == ObjectTypeCode) return;
				SetAttributeValue("objecttypecode", value);
			}
		}	
			
		/// <summary>
        /// ownerid
        /// </summary>
		[DisplayName("ownerid")]
		[AttributeLogicalName("ownerid")]
		public EntityReference Ownerid
		{	
			get { return GetAttributeValue<EntityReference>("ownerid"); }
			set
			{ 
				if(value == Ownerid) return;
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
		[DisplayName("owningteam")]
		[AttributeLogicalName("owningteam")]
		public EntityReference Owningteam
		{	
			get { return GetAttributeValue<EntityReference>("owningteam"); }
			set
			{ 
				if(value == Owningteam) return;
				SetAttributeValue("owningteam", value);
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
        /// retries
        /// </summary>
		[DisplayName("retries")]
		[AttributeLogicalName("retries")]
		public int? Retries
		{	
			get { return GetAttributeValue<int?>("retries"); }
			set
			{ 
				if(value == Retries) return;
				SetAttributeValue("retries", value);
			}
		}	
			
		/// <summary>
        /// tocrmchangetype
        /// </summary>
		[DisplayName("tocrmchangetype")]
		[AttributeLogicalName("tocrmchangetype")]
		public int? Tocrmchangetype
		{	
			get { return GetAttributeValue<int?>("tocrmchangetype"); }
			set
			{ 
				if(value == Tocrmchangetype) return;
				SetAttributeValue("tocrmchangetype", value);
			}
		}	
			
		/// <summary>
        /// userdecision
        /// </summary>
		[DisplayName("userdecision")]
		[AttributeLogicalName("userdecision")]
		public int? Userdecision
		{	
			get { return GetAttributeValue<int?>("userdecision"); }
			set
			{ 
				if(value == Userdecision) return;
				SetAttributeValue("userdecision", value);
			}
		}	
			
		/// <summary>
        /// versionnumber
        /// </summary>
		[DisplayName("versionnumber")]
		[AttributeLogicalName("versionnumber")]
		public int? Versionnumber
		{	
			get { return GetAttributeValue<int?>("versionnumber"); }
			set
			{ 
				if(value == Versionnumber) return;
				SetAttributeValue("versionnumber", value);
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
			/// <summary>createdon</summary>
			public const string CreatedOn = "createdon";

			/// <summary>exchangeentryid</summary>
			public const string ExchangeId = "exchangeentryid";

			/// <summary>exchangesyncidmappingid</summary>
			public const string ExchangesyncidmappingId = "exchangesyncidmappingid";

			/// <summary>fromcrmchangetype</summary>
			public const string Fromcrmchangetype = "fromcrmchangetype";

			/// <summary>isdeletedinexchange</summary>
			public const string Isdeletedinexchange = "isdeletedinexchange";

			/// <summary>isunlinkedincrm</summary>
			public const string Isunlinkedincrm = "isunlinkedincrm";

			/// <summary>itemsubject</summary>
			public const string ItemSubject = "itemsubject";

			/// <summary>lastsyncerror</summary>
			public const string SyncError = "lastsyncerror";

			/// <summary>lastsyncerrorcode</summary>
			public const string Lastsyncerrorcode = "lastsyncerrorcode";

			/// <summary>lastsyncerroroccurredon</summary>
			public const string LastSyncErrorTime = "lastsyncerroroccurredon";

			/// <summary>modifiedon</summary>
			public const string ModifiedOn = "modifiedon";

			/// <summary>objectid</summary>
			public const string CrmId = "objectid";

			/// <summary>objecttypecode</summary>
			public const string ObjectTypeCode = "objecttypecode";

			/// <summary>ownerid</summary>
			public const string Ownerid = "ownerid";

			/// <summary>owneridname</summary>
			public const string Owneridname = "owneridname";

			/// <summary>owneridtype</summary>
			public const string Owneridtype = "owneridtype";

			/// <summary>owneridyominame</summary>
			public const string Owneridyominame = "owneridyominame";

			/// <summary>owningbusinessunit</summary>
			public const string Owningbusinessunit = "owningbusinessunit";

			/// <summary>owningteam</summary>
			public const string Owningteam = "owningteam";

			/// <summary>owninguser</summary>
			public const string Owninguser = "owninguser";

			/// <summary>retries</summary>
			public const string Retries = "retries";

			/// <summary>tocrmchangetype</summary>
			public const string Tocrmchangetype = "tocrmchangetype";

			/// <summary>userdecision</summary>
			public const string Userdecision = "userdecision";

			/// <summary>versionnumber</summary>
			public const string Versionnumber = "versionnumber";

		}
		#endregion

		#region Schemas
		public static class Schemas 
		{
		}
		#endregion
	}
}

