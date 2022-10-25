using System;
using System.Linq;
using System.Diagnostics;
using System.ComponentModel;
using Microsoft.Xrm.Sdk; 
using Microsoft.Xrm.Sdk.Client;
using System.Collections.Generic;

namespace PentaWork.Xrm.Scheduler.Proxies.Entities
{
	[DebuggerDisplay("{Subject}")] 	
	[EntityLogicalName("msdyn_suggestedactivity")]
	public sealed class SuggestedActivity : Entity
	{	
		public static readonly int? EntityTypeCode = 10095;
		public new const string LogicalName = "msdyn_suggestedactivity";
		public const string PrimaryIdAttribute = "msdyn_suggestedactivityid";
		public const string PrimaryNameAttribute = "msdyn_subject";
	
		public SuggestedActivity() : base("msdyn_suggestedactivity") { }

		#region Attributes
		/// <summary>
        /// msdyn_activitytype
        /// </summary>
		[DisplayName("Activity")]
		[AttributeLogicalName("msdyn_activitytype")]
		public string Activity
		{	
			get { return GetAttributeValue<string>("msdyn_activitytype"); }
			set
			{ 
				if(value == Activity) return;
				SetAttributeValue("msdyn_activitytype", value);
			}
		}	
			
		/// <summary>
        /// msdyn_bodypreview
        /// </summary>
		[DisplayName("BodyPreview")]
		[AttributeLogicalName("msdyn_bodypreview")]
		public string BodyPreview
		{	
			get { return GetAttributeValue<string>("msdyn_bodypreview"); }
			set
			{ 
				if(value == BodyPreview) return;
				SetAttributeValue("msdyn_bodypreview", value);
			}
		}	
			
		/// <summary>
        /// msdyn_createddate
        /// </summary>
		[DisplayName("Created Date")]
		[AttributeLogicalName("msdyn_createddate")]
		public DateTime? CreatedDate
		{	
			get { return GetAttributeValue<DateTime?>("msdyn_createddate"); }
			set
			{ 
				if(value == CreatedDate) return;
				SetAttributeValue("msdyn_createddate", value);
			}
		}	
			
		/// <summary>
        /// msdyn_duration
        /// </summary>
		[DisplayName("Duration")]
		[AttributeLogicalName("msdyn_duration")]
		public string Duration
		{	
			get { return GetAttributeValue<string>("msdyn_duration"); }
			set
			{ 
				if(value == Duration) return;
				SetAttributeValue("msdyn_duration", value);
			}
		}	
			
		/// <summary>
        /// msdyn_endtime
        /// </summary>
		[DisplayName("End Time")]
		[AttributeLogicalName("msdyn_endtime")]
		public DateTime? EndTime
		{	
			get { return GetAttributeValue<DateTime?>("msdyn_endtime"); }
			set
			{ 
				if(value == EndTime) return;
				SetAttributeValue("msdyn_endtime", value);
			}
		}	
			
		/// <summary>
        /// msdyn_exchangeweblink
        /// </summary>
		[DisplayName("Exchange web link")]
		[AttributeLogicalName("msdyn_exchangeweblink")]
		public string ExchangeWebLink
		{	
			get { return GetAttributeValue<string>("msdyn_exchangeweblink"); }
			set
			{ 
				if(value == ExchangeWebLink) return;
				SetAttributeValue("msdyn_exchangeweblink", value);
			}
		}	
			
		/// <summary>
        /// msdyn_importance
        /// </summary>
		[DisplayName("Importance")]
		[AttributeLogicalName("msdyn_importance")]
		public string Importance
		{	
			get { return GetAttributeValue<string>("msdyn_importance"); }
			set
			{ 
				if(value == Importance) return;
				SetAttributeValue("msdyn_importance", value);
			}
		}	
			
		/// <summary>
        /// msdyn_location
        /// </summary>
		[DisplayName("Location")]
		[AttributeLogicalName("msdyn_location")]
		public string Location
		{	
			get { return GetAttributeValue<string>("msdyn_location"); }
			set
			{ 
				if(value == Location) return;
				SetAttributeValue("msdyn_location", value);
			}
		}	
			
		/// <summary>
        /// msdyn_regardingid
        /// </summary>
		[DisplayName("Regarding")]
		[AttributeLogicalName("msdyn_regardingid")]
		public EntityReference Regarding
		{	
			get { return GetAttributeValue<EntityReference>("msdyn_regardingid"); }
			set
			{ 
				if(value == Regarding) return;
				SetAttributeValue("msdyn_regardingid", value);
			}
		}	
			
		/// <summary>
        /// msdyn_regardingname
        /// </summary>
		[DisplayName("Regarding Entity")]
		[AttributeLogicalName("msdyn_regardingname")]
		public string RegardingEntity
		{	
			get { return GetAttributeValue<string>("msdyn_regardingname"); }
			set
			{ 
				if(value == RegardingEntity) return;
				SetAttributeValue("msdyn_regardingname", value);
			}
		}	
			
		/// <summary>
        /// msdyn_sender
        /// </summary>
		[DisplayName("Sender")]
		[AttributeLogicalName("msdyn_sender")]
		public string Sender
		{	
			get { return GetAttributeValue<string>("msdyn_sender"); }
			set
			{ 
				if(value == Sender) return;
				SetAttributeValue("msdyn_sender", value);
			}
		}	
			
		/// <summary>
        /// msdyn_sendername
        /// </summary>
		[DisplayName("Sender's Name")]
		[AttributeLogicalName("msdyn_sendername")]
		public string SendersName
		{	
			get { return GetAttributeValue<string>("msdyn_sendername"); }
			set
			{ 
				if(value == SendersName) return;
				SetAttributeValue("msdyn_sendername", value);
			}
		}	
			
		/// <summary>
        /// msdyn_starttime
        /// </summary>
		[DisplayName("Start Time")]
		[AttributeLogicalName("msdyn_starttime")]
		public DateTime? StartTime
		{	
			get { return GetAttributeValue<DateTime?>("msdyn_starttime"); }
			set
			{ 
				if(value == StartTime) return;
				SetAttributeValue("msdyn_starttime", value);
			}
		}	
			
		/// <summary>
        /// msdyn_subject
        /// </summary>
		[DisplayName("Subject")]
		[AttributeLogicalName("msdyn_subject")]
		public string Subject
		{	
			get { return GetAttributeValue<string>("msdyn_subject"); }
			set
			{ 
				if(value == Subject) return;
				SetAttributeValue("msdyn_subject", value);
			}
		}	
			
		/// <summary>
        /// msdyn_suggestedactivityid
        /// </summary>
		[DisplayName("Suggested Activity")]
		[AttributeLogicalName("msdyn_suggestedactivityid")]
		public override Guid Id
		{
			get => base.Id;
			set { base.Id = value; SetAttributeValue("msdyn_suggestedactivityid", value); }
		}

							/// <summary>
        /// msdyn_to
        /// </summary>
		[DisplayName("To")]
		[AttributeLogicalName("msdyn_to")]
		public string To
		{	
			get { return GetAttributeValue<string>("msdyn_to"); }
			set
			{ 
				if(value == To) return;
				SetAttributeValue("msdyn_to", value);
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
			/// <summary>msdyn_activitytype</summary>
			public const string Activity = "msdyn_activitytype";

			/// <summary>msdyn_bodypreview</summary>
			public const string BodyPreview = "msdyn_bodypreview";

			/// <summary>msdyn_createddate</summary>
			public const string CreatedDate = "msdyn_createddate";

			/// <summary>msdyn_duration</summary>
			public const string Duration = "msdyn_duration";

			/// <summary>msdyn_endtime</summary>
			public const string EndTime = "msdyn_endtime";

			/// <summary>msdyn_exchangeweblink</summary>
			public const string ExchangeWebLink = "msdyn_exchangeweblink";

			/// <summary>msdyn_importance</summary>
			public const string Importance = "msdyn_importance";

			/// <summary>msdyn_location</summary>
			public const string Location = "msdyn_location";

			/// <summary>msdyn_regardingid</summary>
			public const string Regarding = "msdyn_regardingid";

			/// <summary>msdyn_regardingname</summary>
			public const string RegardingEntity = "msdyn_regardingname";

			/// <summary>msdyn_sender</summary>
			public const string Sender = "msdyn_sender";

			/// <summary>msdyn_sendername</summary>
			public const string SendersName = "msdyn_sendername";

			/// <summary>msdyn_starttime</summary>
			public const string StartTime = "msdyn_starttime";

			/// <summary>msdyn_subject</summary>
			public const string Subject = "msdyn_subject";

			/// <summary>msdyn_suggestedactivityid</summary>
			public const string SuggestedActivityId = "msdyn_suggestedactivityid";

			/// <summary>msdyn_to</summary>
			public const string To = "msdyn_to";

		}
		#endregion

		#region Schemas
		public static class Schemas 
		{
		}
		#endregion
	}
}

