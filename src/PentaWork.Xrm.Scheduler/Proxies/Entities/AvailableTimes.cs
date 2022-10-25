using System;
using System.Linq;
using System.Diagnostics;
using System.ComponentModel;
using Microsoft.Xrm.Sdk; 
using Microsoft.Xrm.Sdk.Client;
using System.Collections.Generic;

namespace PentaWork.Xrm.Scheduler.Proxies.Entities
{
	[DebuggerDisplay("{Name}")] 	
	[EntityLogicalName("availabletimes")]
	public sealed class AvailableTimes : Entity
	{	
		public static readonly int? EntityTypeCode = 10072;
		public new const string LogicalName = "availabletimes";
		public const string PrimaryIdAttribute = "availabletimesid";
		public const string PrimaryNameAttribute = "name";
	
		public AvailableTimes() : base("availabletimes") { }

		#region Attributes
		/// <summary>
        /// availabletimesid
        /// </summary>
		[DisplayName("AvailableTimes")]
		[AttributeLogicalName("availabletimesid")]
		public override Guid Id
		{
			get => base.Id;
			set { base.Id = value; SetAttributeValue("availabletimesid", value); }
		}

							/// <summary>
        /// name
        /// </summary>
		[DisplayName("Name")]
		[AttributeLogicalName("name")]
		public string Name
		{	
			get { return GetAttributeValue<string>("name"); }
			set
			{ 
				if(value == Name) return;
				SetAttributeValue("name", value);
			}
		}	
			
		/// <summary>
        /// resources
        /// </summary>
		[DisplayName("Resources")]
		[AttributeLogicalName("resources")]
		public string Resources
		{	
			get { return GetAttributeValue<string>("resources"); }
			set
			{ 
				if(value == Resources) return;
				SetAttributeValue("resources", value);
			}
		}	
			
		/// <summary>
        /// resourcesJson
        /// </summary>
		[DisplayName("Resources IDs")]
		[AttributeLogicalName("resourcesJson")]
		public string ResourcesIDs
		{	
			get { return GetAttributeValue<string>("resourcesJson"); }
			set
			{ 
				if(value == ResourcesIDs) return;
				SetAttributeValue("resourcesJson", value);
			}
		}	
			
		/// <summary>
        /// scheduledend
        /// </summary>
		[DisplayName("Scheduled End UTC time")]
		[AttributeLogicalName("scheduledend")]
		public DateTime? ScheduledEndUTCTime
		{	
			get { return GetAttributeValue<DateTime?>("scheduledend"); }
			set
			{ 
				if(value == ScheduledEndUTCTime) return;
				SetAttributeValue("scheduledend", value);
			}
		}	
			
		/// <summary>
        /// scheduledendlocaltime
        /// </summary>
		[DisplayName("Scheduled End")]
		[AttributeLogicalName("scheduledendlocaltime")]
		public string ScheduledEnd
		{	
			get { return GetAttributeValue<string>("scheduledendlocaltime"); }
			set
			{ 
				if(value == ScheduledEnd) return;
				SetAttributeValue("scheduledendlocaltime", value);
			}
		}	
			
		/// <summary>
        /// scheduledstart
        /// </summary>
		[DisplayName("Scheduled Start UTC time")]
		[AttributeLogicalName("scheduledstart")]
		public DateTime? ScheduledStartUTCTime
		{	
			get { return GetAttributeValue<DateTime?>("scheduledstart"); }
			set
			{ 
				if(value == ScheduledStartUTCTime) return;
				SetAttributeValue("scheduledstart", value);
			}
		}	
			
		/// <summary>
        /// scheduledstartlocaltime
        /// </summary>
		[DisplayName("Scheduled Start")]
		[AttributeLogicalName("scheduledstartlocaltime")]
		public string ScheduledStart
		{	
			get { return GetAttributeValue<string>("scheduledstartlocaltime"); }
			set
			{ 
				if(value == ScheduledStart) return;
				SetAttributeValue("scheduledstartlocaltime", value);
			}
		}	
			
		/// <summary>
        /// site
        /// </summary>
		[DisplayName("Site")]
		[AttributeLogicalName("site")]
		public string Site
		{	
			get { return GetAttributeValue<string>("site"); }
			set
			{ 
				if(value == Site) return;
				SetAttributeValue("site", value);
			}
		}	
			
		/// <summary>
        /// siteid
        /// </summary>
		[DisplayName("Site Identifier")]
		[AttributeLogicalName("siteid")]
		public Guid SiteIdentifierId
		{	
			get { return GetAttributeValue<Guid>("siteid"); }
			set
			{ 
				if(value == SiteIdentifierId) return;
				SetAttributeValue("siteid", value);
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
			/// <summary>availabletimesid</summary>
			public const string AvailableTimesId = "availabletimesid";

			/// <summary>name</summary>
			public const string Name = "name";

			/// <summary>resources</summary>
			public const string Resources = "resources";

			/// <summary>resourcesJson</summary>
			public const string ResourcesIDs = "resourcesJson";

			/// <summary>scheduledend</summary>
			public const string ScheduledEndUTCTime = "scheduledend";

			/// <summary>scheduledendlocaltime</summary>
			public const string ScheduledEnd = "scheduledendlocaltime";

			/// <summary>scheduledstart</summary>
			public const string ScheduledStartUTCTime = "scheduledstart";

			/// <summary>scheduledstartlocaltime</summary>
			public const string ScheduledStart = "scheduledstartlocaltime";

			/// <summary>site</summary>
			public const string Site = "site";

			/// <summary>siteid</summary>
			public const string SiteIdentifierId = "siteid";

		}
		#endregion

		#region Schemas
		public static class Schemas 
		{
		}
		#endregion
	}
}

