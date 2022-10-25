using System;
using Microsoft.Xrm.Sdk; 
using Microsoft.Xrm.Sdk.Client;

namespace PentaWork.Xrm.Scheduler.Proxies.Relations
{
	/// <summary> 
	/// botcomponent_botcomponent 
	/// </summary>
	[Relation]
	[EntityLogicalName("botcomponent_botcomponent")]
	public sealed class BotcomponentBotcomponent : Entity
	{	
		public const string SchemaName = "botcomponent_botcomponent";
	
		public BotcomponentBotcomponent() : base("botcomponent_botcomponent") { }

		[AttributeLogicalName("botcomponentidone")]
		public Guid BotcomponentidoneId
		{	
			get { return GetAttributeValue<Guid>("botcomponentidone"); }
			set { SetAttributeValue("botcomponentidone", value); }
		}

		[AttributeLogicalName("botcomponentidtwo")]
		public Guid BotcomponentidtwoId
		{	
			get { return GetAttributeValue<Guid>("botcomponentidtwo"); }
			set { SetAttributeValue("botcomponentidtwo", value); }
		}
	}
}

