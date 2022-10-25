using System;
using Microsoft.Xrm.Sdk; 
using Microsoft.Xrm.Sdk.Client;

namespace PentaWork.Xrm.Scheduler.Proxies.Relations
{
	/// <summary> 
	/// teamprofiles_association 
	/// </summary>
	[Relation]
	[EntityLogicalName("teamprofiles_association")]
	public sealed class TeamprofilesAssociation : Entity
	{	
		public const string SchemaName = "teamprofiles_association";
	
		public TeamprofilesAssociation() : base("teamprofiles_association") { }

		[AttributeLogicalName("teamid")]
		public Guid TeamId
		{	
			get { return GetAttributeValue<Guid>("teamid"); }
			set { SetAttributeValue("teamid", value); }
		}

		[AttributeLogicalName("fieldsecurityprofileid")]
		public Guid FieldsecurityprofileId
		{	
			get { return GetAttributeValue<Guid>("fieldsecurityprofileid"); }
			set { SetAttributeValue("fieldsecurityprofileid", value); }
		}
	}
}

