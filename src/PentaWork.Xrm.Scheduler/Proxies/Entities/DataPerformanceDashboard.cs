using System;
using System.Linq;
using System.Diagnostics;
using System.ComponentModel;
using Microsoft.Xrm.Sdk; 
using Microsoft.Xrm.Sdk.Client;
using System.Collections.Generic;

namespace PentaWork.Xrm.Scheduler.Proxies.Entities
{
	
	[EntityLogicalName("dataperformance")]
	public sealed class DataPerformanceDashboard : Entity
	{	
		public static readonly int? EntityTypeCode = 4450;
		public new const string LogicalName = "dataperformance";
		public const string PrimaryIdAttribute = "dataperformanceid";
		public const string PrimaryNameAttribute = "";
	
		public DataPerformanceDashboard() : base("dataperformance") { }

		#region Attributes
		/// <summary>
        /// anyoptimizationapplied
        /// </summary>
		[DisplayName("Any Optimization Applied")]
		[AttributeLogicalName("anyoptimizationapplied")]
		public bool? AnyOptimizationApplied
		{	
			get { return GetAttributeValue<bool?>("anyoptimizationapplied"); }
			set
			{ 
				if(value == AnyOptimizationApplied) return;
				SetAttributeValue("anyoptimizationapplied", value);
			}
		}	
			
		/// <summary>
        /// anyoptimizationavailable
        /// </summary>
		[DisplayName("Any Optimization Available")]
		[AttributeLogicalName("anyoptimizationavailable")]
		public bool? AnyOptimizationAvailable
		{	
			get { return GetAttributeValue<bool?>("anyoptimizationavailable"); }
			set
			{ 
				if(value == AnyOptimizationAvailable) return;
				SetAttributeValue("anyoptimizationavailable", value);
			}
		}	
			
		/// <summary>
        /// component
        /// </summary>
		[DisplayName("Component")]
		[AttributeLogicalName("component")]
		public string Component
		{	
			get { return GetAttributeValue<string>("component"); }
			set
			{ 
				if(value == Component) return;
				SetAttributeValue("component", value);
			}
		}	
			
		/// <summary>
        /// count
        /// </summary>
		[DisplayName("Count")]
		[AttributeLogicalName("count")]
		public int? Count
		{	
			get { return GetAttributeValue<int?>("count"); }
			set
			{ 
				if(value == Count) return;
				SetAttributeValue("count", value);
			}
		}	
			
		/// <summary>
        /// dataperformanceid
        /// </summary>
		[DisplayName("Id")]
		[AttributeLogicalName("dataperformanceid")]
		public override Guid Id
		{
			get => base.Id;
			set { base.Id = value; SetAttributeValue("dataperformanceid", value); }
		}

							/// <summary>
        /// entity
        /// </summary>
		[DisplayName("Entity")]
		[AttributeLogicalName("entity")]
		public string Entity
		{	
			get { return GetAttributeValue<string>("entity"); }
			set
			{ 
				if(value == Entity) return;
				SetAttributeValue("entity", value);
			}
		}	
			
		/// <summary>
        /// estimatedoptimizationimpact
		///
		/// Precision: 2
		/// MaxValue: 1000000000
		/// MinValue: 0
        /// </summary>
		[DisplayName("Estimated Optimization Impact")]
		[AttributeLogicalName("estimatedoptimizationimpact")]
		public decimal? EstimatedOptimizationImpact
		{	
			get { return GetAttributeValue<decimal?>("estimatedoptimizationimpact"); }
			set 
			{
				decimal? decimalValue = null;
				if(value != null) decimalValue = Decimal.Round(value.Value, 2);
				if(decimalValue == EstimatedOptimizationImpact) return;
				SetAttributeValue("estimatedoptimizationimpact", decimalValue);  
			}
		}

		/// <summary>
        /// executionperiod
        /// </summary>
		[DisplayName("Execution Period")]
		[AttributeLogicalName("executionperiod")]
		public string ExecutionPeriod
		{	
			get { return GetAttributeValue<string>("executionperiod"); }
			set
			{ 
				if(value == ExecutionPeriod) return;
				SetAttributeValue("executionperiod", value);
			}
		}	
			
		/// <summary>
        /// lastactionresult
        /// </summary>
		[DisplayName("Last Action Result")]
		[AttributeLogicalName("lastactionresult")]
		public string LastActionResult
		{	
			get { return GetAttributeValue<string>("lastactionresult"); }
			set
			{ 
				if(value == LastActionResult) return;
				SetAttributeValue("lastactionresult", value);
			}
		}	
			
		/// <summary>
        /// lastoptimizationdate
        /// </summary>
		[DisplayName("Last Optimization Date")]
		[AttributeLogicalName("lastoptimizationdate")]
		public DateTime? LastOptimizationDate
		{	
			get { return GetAttributeValue<DateTime?>("lastoptimizationdate"); }
			set
			{ 
				if(value == LastOptimizationDate) return;
				SetAttributeValue("lastoptimizationdate", value);
			}
		}	
			
		/// <summary>
        /// maxtime
		///
		/// Precision: 2
		/// MaxValue: 1000000000
		/// MinValue: 0
        /// </summary>
		[DisplayName("Max Time")]
		[AttributeLogicalName("maxtime")]
		public decimal? MaxTime
		{	
			get { return GetAttributeValue<decimal?>("maxtime"); }
			set 
			{
				decimal? decimalValue = null;
				if(value != null) decimalValue = Decimal.Round(value.Value, 2);
				if(decimalValue == MaxTime) return;
				SetAttributeValue("maxtime", decimalValue);  
			}
		}

		/// <summary>
        /// mediantime
		///
		/// Precision: 2
		/// MaxValue: 1000000000
		/// MinValue: 0
        /// </summary>
		[DisplayName("Median Time")]
		[AttributeLogicalName("mediantime")]
		public decimal? MedianTime
		{	
			get { return GetAttributeValue<decimal?>("mediantime"); }
			set 
			{
				decimal? decimalValue = null;
				if(value != null) decimalValue = Decimal.Round(value.Value, 2);
				if(decimalValue == MedianTime) return;
				SetAttributeValue("mediantime", decimalValue);  
			}
		}

		/// <summary>
        /// mintime
		///
		/// Precision: 2
		/// MaxValue: 1000000000
		/// MinValue: 0
        /// </summary>
		[DisplayName("Min Time")]
		[AttributeLogicalName("mintime")]
		public decimal? MinTime
		{	
			get { return GetAttributeValue<decimal?>("mintime"); }
			set 
			{
				decimal? decimalValue = null;
				if(value != null) decimalValue = Decimal.Round(value.Value, 2);
				if(decimalValue == MinTime) return;
				SetAttributeValue("mintime", decimalValue);  
			}
		}

		/// <summary>
        /// operation
        /// </summary>
		[DisplayName("Operation")]
		[AttributeLogicalName("operation")]
		public string Operation
		{	
			get { return GetAttributeValue<string>("operation"); }
			set
			{ 
				if(value == Operation) return;
				SetAttributeValue("operation", value);
			}
		}	
			
		/// <summary>
        /// optimizationstatus
        /// </summary>
		[DisplayName("Optimization Status")]
		[AttributeLogicalName("optimizationstatus")]
		public string OptimizationStatus
		{	
			get { return GetAttributeValue<string>("optimizationstatus"); }
			set
			{ 
				if(value == OptimizationStatus) return;
				SetAttributeValue("optimizationstatus", value);
			}
		}	
			
		/// <summary>
        /// optimizationstorage
		///
		/// Precision: 2
		/// MaxValue: 1000000000
		/// MinValue: 0
        /// </summary>
		[DisplayName("Optimization Storage")]
		[AttributeLogicalName("optimizationstorage")]
		public decimal? OptimizationStorage
		{	
			get { return GetAttributeValue<decimal?>("optimizationstorage"); }
			set 
			{
				decimal? decimalValue = null;
				if(value != null) decimalValue = Decimal.Round(value.Value, 2);
				if(decimalValue == OptimizationStorage) return;
				SetAttributeValue("optimizationstorage", decimalValue);  
			}
		}

		/// <summary>
        /// organizationid
        /// </summary>
		[DisplayName("organizationid")]
		[AttributeLogicalName("organizationid")]
		public EntityReference Organizationid
		{	
			get { return GetAttributeValue<EntityReference>("organizationid"); }
			set
			{ 
				if(value == Organizationid) return;
				SetAttributeValue("organizationid", value);
			}
		}	
			
		/// <summary>
        /// realizedoptimizationimpact
        /// </summary>
		[DisplayName("Optimization Impact (%)")]
		[AttributeLogicalName("realizedoptimizationimpact")]
		public string OptimizationImpact
		{	
			get { return GetAttributeValue<string>("realizedoptimizationimpact"); }
			set
			{ 
				if(value == OptimizationImpact) return;
				SetAttributeValue("realizedoptimizationimpact", value);
			}
		}	
			
		/// <summary>
        /// solution
        /// </summary>
		[DisplayName("Solution")]
		[AttributeLogicalName("solution")]
		public string Solution
		{	
			get { return GetAttributeValue<string>("solution"); }
			set
			{ 
				if(value == Solution) return;
				SetAttributeValue("solution", value);
			}
		}	
			
		/// <summary>
        /// weight
		///
		/// Precision: 2
		/// MaxValue: 1000000000
		/// MinValue: 0
        /// </summary>
		[DisplayName("Weight")]
		[AttributeLogicalName("weight")]
		public decimal? Weight
		{	
			get { return GetAttributeValue<decimal?>("weight"); }
			set 
			{
				decimal? decimalValue = null;
				if(value != null) decimalValue = Decimal.Round(value.Value, 2);
				if(decimalValue == Weight) return;
				SetAttributeValue("weight", decimalValue);  
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
			/// <summary>anyoptimizationapplied</summary>
			public const string AnyOptimizationApplied = "anyoptimizationapplied";

			/// <summary>anyoptimizationavailable</summary>
			public const string AnyOptimizationAvailable = "anyoptimizationavailable";

			/// <summary>component</summary>
			public const string Component = "component";

			/// <summary>count</summary>
			public const string Count = "count";

			/// <summary>dataperformanceid</summary>
			public const string Id = "dataperformanceid";

			/// <summary>entity</summary>
			public const string Entity = "entity";

			/// <summary>estimatedoptimizationimpact</summary>
			public const string EstimatedOptimizationImpact = "estimatedoptimizationimpact";

			/// <summary>executionperiod</summary>
			public const string ExecutionPeriod = "executionperiod";

			/// <summary>lastactionresult</summary>
			public const string LastActionResult = "lastactionresult";

			/// <summary>lastoptimizationdate</summary>
			public const string LastOptimizationDate = "lastoptimizationdate";

			/// <summary>maxtime</summary>
			public const string MaxTime = "maxtime";

			/// <summary>mediantime</summary>
			public const string MedianTime = "mediantime";

			/// <summary>mintime</summary>
			public const string MinTime = "mintime";

			/// <summary>operation</summary>
			public const string Operation = "operation";

			/// <summary>optimizationstatus</summary>
			public const string OptimizationStatus = "optimizationstatus";

			/// <summary>optimizationstorage</summary>
			public const string OptimizationStorage = "optimizationstorage";

			/// <summary>organizationid</summary>
			public const string Organizationid = "organizationid";

			/// <summary>realizedoptimizationimpact</summary>
			public const string OptimizationImpact = "realizedoptimizationimpact";

			/// <summary>solution</summary>
			public const string Solution = "solution";

			/// <summary>weight</summary>
			public const string Weight = "weight";

		}
		#endregion

		#region Schemas
		public static class Schemas 
		{
		}
		#endregion
	}
}

