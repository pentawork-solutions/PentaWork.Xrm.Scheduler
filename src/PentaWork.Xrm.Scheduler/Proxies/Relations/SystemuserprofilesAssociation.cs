using System;
using Microsoft.Xrm.Sdk; 
using Microsoft.Xrm.Sdk.Client;

namespace PentaWork.Xrm.Scheduler.Proxies.Relations
{
	/// <summary> 
	/// systemuserprofiles_association 
	/// </summary>
	[Relation]
	[EntityLogicalName("systemuserprofiles_association")]
	public sealed class SystemuserprofilesAssociation : Entity
	{	
		public const string SchemaName = "systemuserprofiles_association";
	
		public SystemuserprofilesAssociation() : base("systemuserprofiles_association") { }

		[AttributeLogicalName("systemuserid")]
		public Guid SystemuserId
		{	
			get { return GetAttributeValue<Guid>("systemuserid"); }
			set { SetAttributeValue("systemuserid", value); }
		}

		[AttributeLogicalName("fieldsecurityprofileid")]
		public Guid FieldsecurityprofileId
		{	
			get { return GetAttributeValue<Guid>("fieldsecurityprofileid"); }
			set { SetAttributeValue("fieldsecurityprofileid", value); }
		}
	}
}

