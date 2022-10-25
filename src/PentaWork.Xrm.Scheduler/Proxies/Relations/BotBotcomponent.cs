using System;
using Microsoft.Xrm.Sdk; 
using Microsoft.Xrm.Sdk.Client;

namespace PentaWork.Xrm.Scheduler.Proxies.Relations
{
	/// <summary> 
	/// bot_botcomponent 
	/// </summary>
	[Relation]
	[EntityLogicalName("bot_botcomponent")]
	public sealed class BotBotcomponent : Entity
	{	
		public const string SchemaName = "bot_botcomponent";
	
		public BotBotcomponent() : base("bot_botcomponent") { }

		[AttributeLogicalName("botid")]
		public Guid BotId
		{	
			get { return GetAttributeValue<Guid>("botid"); }
			set { SetAttributeValue("botid", value); }
		}

		[AttributeLogicalName("botcomponentid")]
		public Guid BotcomponentId
		{	
			get { return GetAttributeValue<Guid>("botcomponentid"); }
			set { SetAttributeValue("botcomponentid", value); }
		}
	}
}

