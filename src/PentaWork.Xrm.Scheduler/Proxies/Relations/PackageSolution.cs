using System;
using Microsoft.Xrm.Sdk; 
using Microsoft.Xrm.Sdk.Client;

namespace PentaWork.Xrm.Scheduler.Proxies.Relations
{
	/// <summary> 
	/// package_solution 
	/// </summary>
	[Relation]
	[EntityLogicalName("package_solution")]
	public sealed class PackageSolution : Entity
	{	
		public const string SchemaName = "package_solution";
	
		public PackageSolution() : base("package_solution") { }

		[AttributeLogicalName("packageid")]
		public Guid PackageId
		{	
			get { return GetAttributeValue<Guid>("packageid"); }
			set { SetAttributeValue("packageid", value); }
		}

		[AttributeLogicalName("solutionid")]
		public Guid SolutionId
		{	
			get { return GetAttributeValue<Guid>("solutionid"); }
			set { SetAttributeValue("solutionid", value); }
		}
	}
}

