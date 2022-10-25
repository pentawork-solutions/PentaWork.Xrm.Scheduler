using System;
using System.Linq;
using System.Diagnostics;
using System.ComponentModel;
using Microsoft.Xrm.Sdk; 
using Microsoft.Xrm.Sdk.Client;
using System.Collections.Generic;

namespace PentaWork.Xrm.Scheduler.Proxies.Entities
{
	
	[EntityLogicalName("audit")]
	public sealed class Auditing : Entity
	{	
		public static readonly int? EntityTypeCode = 4567;
		public new const string LogicalName = "audit";
		public const string PrimaryIdAttribute = "auditid";
		public const string PrimaryNameAttribute = "";
	
		public Auditing() : base("audit") { }

		#region Attributes
		/// <summary>
        /// action
        /// </summary>
		[DisplayName("Event")]
		[AttributeLogicalName("action")]
		public eAction? Event
		{	
			get 
			{ 
				var optionSetValue = GetAttributeValue<OptionSetValue>("action");
				if (optionSetValue != null) return (eAction)optionSetValue.Value;
				else return null;
			}
			set 
			{ 
				if(value == Event) return;

				OptionSetValue optionSetValue = null;
				if(value != null) optionSetValue = new OptionSetValue((int)value);
				SetAttributeValue("action", optionSetValue); 
			}
		}

		/// <summary>
        /// attributemask
        /// </summary>
		[DisplayName("Changed Field")]
		[AttributeLogicalName("attributemask")]
		public string ChangedField
		{	
			get { return GetAttributeValue<string>("attributemask"); }
			set
			{ 
				if(value == ChangedField) return;
				SetAttributeValue("attributemask", value);
			}
		}	
			
		/// <summary>
        /// auditid
        /// </summary>
		[DisplayName("Record Id")]
		[AttributeLogicalName("auditid")]
		public override Guid Id
		{
			get => base.Id;
			set { base.Id = value; SetAttributeValue("auditid", value); }
		}

							/// <summary>
        /// callinguserid
        /// </summary>
		[DisplayName("Calling User")]
		[AttributeLogicalName("callinguserid")]
		public EntityReference CallingUser
		{	
			get { return GetAttributeValue<EntityReference>("callinguserid"); }
			set
			{ 
				if(value == CallingUser) return;
				SetAttributeValue("callinguserid", value);
			}
		}	
			
		/// <summary>
        /// callinguseridname
        /// </summary>
		[DisplayName("callinguseridname")]
		[AttributeLogicalName("callinguseridname")]
		public string Callinguseridname
		{	
			get { return GetAttributeValue<string>("callinguseridname"); }
			set
			{ 
				if(value == Callinguseridname) return;
				SetAttributeValue("callinguseridname", value);
			}
		}	
			
		/// <summary>
        /// changedata
        /// </summary>
		[DisplayName("Change Data")]
		[AttributeLogicalName("changedata")]
		public string ChangeData
		{	
			get { return GetAttributeValue<string>("changedata"); }
			set
			{ 
				if(value == ChangeData) return;
				SetAttributeValue("changedata", value);
			}
		}	
			
		/// <summary>
        /// createdon
        /// </summary>
		[DisplayName("Changed Date")]
		[AttributeLogicalName("createdon")]
		public DateTime? ChangedDate
		{	
			get { return GetAttributeValue<DateTime?>("createdon"); }
			set
			{ 
				if(value == ChangedDate) return;
				SetAttributeValue("createdon", value);
			}
		}	
			
		/// <summary>
        /// objectid
        /// </summary>
		[DisplayName("Record")]
		[AttributeLogicalName("objectid")]
		public EntityReference Record
		{	
			get { return GetAttributeValue<EntityReference>("objectid"); }
			set
			{ 
				if(value == Record) return;
				SetAttributeValue("objectid", value);
			}
		}	
			
		/// <summary>
        /// objectidname
        /// </summary>
		[DisplayName("objectidname")]
		[AttributeLogicalName("objectidname")]
		public string Objectidname
		{	
			get { return GetAttributeValue<string>("objectidname"); }
			set
			{ 
				if(value == Objectidname) return;
				SetAttributeValue("objectidname", value);
			}
		}	
			
		/// <summary>
        /// objecttypecode
        /// </summary>
		[DisplayName("Entity")]
		[AttributeLogicalName("objecttypecode")]
		public string Entity
		{	
			get { return GetAttributeValue<string>("objecttypecode"); }
			set
			{ 
				if(value == Entity) return;
				SetAttributeValue("objecttypecode", value);
			}
		}	
			
		/// <summary>
        /// operation
        /// </summary>
		[DisplayName("Operation")]
		[AttributeLogicalName("operation")]
		public eOperation? Operation
		{	
			get 
			{ 
				var optionSetValue = GetAttributeValue<OptionSetValue>("operation");
				if (optionSetValue != null) return (eOperation)optionSetValue.Value;
				else return null;
			}
			set 
			{ 
				if(value == Operation) return;

				OptionSetValue optionSetValue = null;
				if(value != null) optionSetValue = new OptionSetValue((int)value);
				SetAttributeValue("operation", optionSetValue); 
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
        /// transactionid
        /// </summary>
		[DisplayName("Transaction Id")]
		[AttributeLogicalName("transactionid")]
		public Guid TransactionId
		{	
			get { return GetAttributeValue<Guid>("transactionid"); }
			set
			{ 
				if(value == TransactionId) return;
				SetAttributeValue("transactionid", value);
			}
		}	
			
		/// <summary>
        /// useradditionalinfo
        /// </summary>
		[DisplayName("User Info")]
		[AttributeLogicalName("useradditionalinfo")]
		public string UserInfo
		{	
			get { return GetAttributeValue<string>("useradditionalinfo"); }
			set
			{ 
				if(value == UserInfo) return;
				SetAttributeValue("useradditionalinfo", value);
			}
		}	
			
		/// <summary>
        /// userid
        /// </summary>
		[DisplayName("Changed By")]
		[AttributeLogicalName("userid")]
		public EntityReference ChangedBy
		{	
			get { return GetAttributeValue<EntityReference>("userid"); }
			set
			{ 
				if(value == ChangedBy) return;
				SetAttributeValue("userid", value);
			}
		}	
			
		/// <summary>
        /// useridname
        /// </summary>
		[DisplayName("useridname")]
		[AttributeLogicalName("useridname")]
		public string Useridname
		{	
			get { return GetAttributeValue<string>("useridname"); }
			set
			{ 
				if(value == Useridname) return;
				SetAttributeValue("useridname", value);
			}
		}	
			
		#endregion	

		#region Relations
			#endregion

		#region Actions
		#endregion

		#region OptionSetEnums
		public enum eAction
		{	
		
			[Label("Unknown")]
			[Description(@"")]
			Unknown = 0, 
		
			[Label("Create")]
			[Description(@"")]
			Create = 1, 
		
			[Label("Update")]
			[Description(@"")]
			Update = 2, 
		
			[Label("Delete")]
			[Description(@"")]
			Delete = 3, 
		
			[Label("Activate")]
			[Description(@"")]
			Activate = 4, 
		
			[Label("Deactivate")]
			[Description(@"")]
			Deactivate = 5, 
		
			[Label("Cascade")]
			[Description(@"")]
			Cascade = 11, 
		
			[Label("Merge")]
			[Description(@"")]
			Merge = 12, 
		
			[Label("Assign")]
			[Description(@"")]
			Assign = 13, 
		
			[Label("Share")]
			[Description(@"")]
			Share = 14, 
		
			[Label("Retrieve")]
			[Description(@"")]
			Retrieve = 15, 
		
			[Label("Close")]
			[Description(@"")]
			Close = 16, 
		
			[Label("Cancel")]
			[Description(@"")]
			Cancel = 17, 
		
			[Label("Complete")]
			[Description(@"")]
			Complete = 18, 
		
			[Label("Resolve")]
			[Description(@"")]
			Resolve = 20, 
		
			[Label("Reopen")]
			[Description(@"")]
			Reopen = 21, 
		
			[Label("Fulfill")]
			[Description(@"")]
			Fulfill = 22, 
		
			[Label("Paid")]
			[Description(@"")]
			Paid = 23, 
		
			[Label("Qualify")]
			[Description(@"")]
			Qualify = 24, 
		
			[Label("Disqualify")]
			[Description(@"")]
			Disqualify = 25, 
		
			[Label("Submit")]
			[Description(@"")]
			Submit = 26, 
		
			[Label("Reject")]
			[Description(@"")]
			Reject = 27, 
		
			[Label("Approve")]
			[Description(@"")]
			Approve = 28, 
		
			[Label("Invoice")]
			[Description(@"")]
			Invoice = 29, 
		
			[Label("Hold")]
			[Description(@"")]
			Hold = 30, 
		
			[Label("Add Member")]
			[Description(@"")]
			AddMember = 31, 
		
			[Label("Remove Member")]
			[Description(@"")]
			RemoveMember = 32, 
		
			[Label("Associate Entities")]
			[Description(@"")]
			AssociateEntities = 33, 
		
			[Label("Disassociate Entities")]
			[Description(@"")]
			DisassociateEntities = 34, 
		
			[Label("Add Members")]
			[Description(@"")]
			AddMembers = 35, 
		
			[Label("Remove Members")]
			[Description(@"")]
			RemoveMembers = 36, 
		
			[Label("Add Item")]
			[Description(@"")]
			AddItem = 37, 
		
			[Label("Remove Item")]
			[Description(@"")]
			RemoveItem = 38, 
		
			[Label("Add Substitute")]
			[Description(@"")]
			AddSubstitute = 39, 
		
			[Label("Remove Substitute")]
			[Description(@"")]
			RemoveSubstitute = 40, 
		
			[Label("Set State")]
			[Description(@"")]
			SetState = 41, 
		
			[Label("Renew")]
			[Description(@"")]
			Renew = 42, 
		
			[Label("Revise")]
			[Description(@"")]
			Revise = 43, 
		
			[Label("Win")]
			[Description(@"")]
			Win = 44, 
		
			[Label("Lose")]
			[Description(@"")]
			Lose = 45, 
		
			[Label("Internal Processing")]
			[Description(@"")]
			InternalProcessing = 46, 
		
			[Label("Reschedule")]
			[Description(@"")]
			Reschedule = 47, 
		
			[Label("Modify Share")]
			[Description(@"")]
			ModifyShare = 48, 
		
			[Label("Unshare")]
			[Description(@"")]
			Unshare = 49, 
		
			[Label("Book")]
			[Description(@"")]
			Book = 50, 
		
			[Label("Generate Quote From Opportunity")]
			[Description(@"")]
			GenerateQuoteFromOpportunity = 51, 
		
			[Label("Add To Queue")]
			[Description(@"")]
			AddToQueue = 52, 
		
			[Label("Assign Role To Team")]
			[Description(@"")]
			AssignRoleToTeam = 53, 
		
			[Label("Remove Role From Team")]
			[Description(@"")]
			RemoveRoleFromTeam = 54, 
		
			[Label("Assign Role To User")]
			[Description(@"")]
			AssignRoleToUser = 55, 
		
			[Label("Remove Role From User")]
			[Description(@"")]
			RemoveRoleFromUser = 56, 
		
			[Label("Add Privileges to Role")]
			[Description(@"")]
			AddPrivilegesToRole = 57, 
		
			[Label("Remove Privileges From Role")]
			[Description(@"")]
			RemovePrivilegesFromRole = 58, 
		
			[Label("Replace Privileges In Role")]
			[Description(@"")]
			ReplacePrivilegesInRole = 59, 
		
			[Label("Import Mappings")]
			[Description(@"")]
			ImportMappings = 60, 
		
			[Label("Clone")]
			[Description(@"")]
			Clone = 61, 
		
			[Label("Send Direct Email")]
			[Description(@"")]
			SendDirectEmail = 62, 
		
			[Label("Enabled for organization")]
			[Description(@"")]
			EnabledForOrganization = 63, 
		
			[Label("User Access via Web")]
			[Description(@"")]
			UserAccessViaWeb = 64, 
		
			[Label("User Access via Web Services")]
			[Description(@"")]
			UserAccessViaWebServices = 65, 
		
			[Label("Delete Entity")]
			[Description(@"")]
			DeleteEntity = 100, 
		
			[Label("Delete Attribute")]
			[Description(@"")]
			DeleteAttribute = 101, 
		
			[Label("Audit Change at Entity Level")]
			[Description(@"")]
			AuditChangeAtEntityLevel = 102, 
		
			[Label("Audit Change at Attribute Level")]
			[Description(@"")]
			AuditChangeAtAttributeLevel = 103, 
		
			[Label("Audit Change at Org Level")]
			[Description(@"")]
			AuditChangeAtOrgLevel = 104, 
		
			[Label("Entity Audit Started")]
			[Description(@"")]
			EntityAuditStarted = 105, 
		
			[Label("Attribute Audit Started")]
			[Description(@"")]
			AttributeAuditStarted = 106, 
		
			[Label("Audit Enabled")]
			[Description(@"")]
			AuditEnabled = 107, 
		
			[Label("Entity Audit Stopped")]
			[Description(@"")]
			EntityAuditStopped = 108, 
		
			[Label("Attribute Audit Stopped")]
			[Description(@"")]
			AttributeAuditStopped = 109, 
		
			[Label("Audit Disabled")]
			[Description(@"")]
			AuditDisabled = 110, 
		
			[Label("Audit Log Deletion")]
			[Description(@"")]
			AuditLogDeletion = 111, 
		
			[Label("User Access Audit Started")]
			[Description(@"")]
			UserAccessAuditStarted = 112, 
		
			[Label("User Access Audit Stopped")]
			[Description(@"")]
			UserAccessAuditStopped = 113, 
		}
		
		public enum eOperation
		{	
		
			[Label("Create")]
			[Description(@"")]
			Create = 1, 
		
			[Label("Update")]
			[Description(@"")]
			Update = 2, 
		
			[Label("Delete")]
			[Description(@"")]
			Delete = 3, 
		
			[Label("Access")]
			[Description(@"")]
			Access = 4, 
		}
		
		#endregion	

		#region Properties
		public static class Properties 
		{
			/// <summary>action</summary>
			public const string Event = "action";

			/// <summary>attributemask</summary>
			public const string ChangedField = "attributemask";

			/// <summary>auditid</summary>
			public const string RecordId = "auditid";

			/// <summary>callinguserid</summary>
			public const string CallingUser = "callinguserid";

			/// <summary>callinguseridname</summary>
			public const string Callinguseridname = "callinguseridname";

			/// <summary>changedata</summary>
			public const string ChangeData = "changedata";

			/// <summary>createdon</summary>
			public const string ChangedDate = "createdon";

			/// <summary>objectid</summary>
			public const string Record = "objectid";

			/// <summary>objectidname</summary>
			public const string Objectidname = "objectidname";

			/// <summary>objecttypecode</summary>
			public const string Entity = "objecttypecode";

			/// <summary>operation</summary>
			public const string Operation = "operation";

			/// <summary>regardingobjectid</summary>
			public const string Regarding = "regardingobjectid";

			/// <summary>regardingobjectidname</summary>
			public const string Regardingobjectidname = "regardingobjectidname";

			/// <summary>transactionid</summary>
			public const string TransactionId = "transactionid";

			/// <summary>useradditionalinfo</summary>
			public const string UserInfo = "useradditionalinfo";

			/// <summary>userid</summary>
			public const string ChangedBy = "userid";

			/// <summary>useridname</summary>
			public const string Useridname = "useridname";

		}
		#endregion

		#region Schemas
		public static class Schemas 
		{
		}
		#endregion
	}
}

