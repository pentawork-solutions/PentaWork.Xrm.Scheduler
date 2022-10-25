using Bogus;
using System;
using FakeXrmEasy;
using System.Collections.Generic;
using PentaWork.Xrm.Scheduler.Proxies.Entities;

namespace PentaWork.Xrm.Scheduler.Tests.Fake
{
	public static class FakeMailMergeTemplate
	{	
		#region FakeRelationships
		public static class Relationships 
		{
			/// <summary>1:N MailMergeTemplate_AsyncOperations</summary>
			public static readonly XrmFakedRelationship MailMergeTemplateAsyncOperations = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "mailmergetemplateid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "mailmergetemplate",
					Entity2LogicalName = "asyncoperation",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N mailmergetemplate_principalobjectattributeaccess</summary>
			public static readonly XrmFakedRelationship MailmergetemplatePrincipalobjectattributeaccess = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "mailmergetemplateid",
					Entity2Attribute = "objectid",
					Entity1LogicalName = "mailmergetemplate",
					Entity2LogicalName = "principalobjectattributeaccess",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N MailMergeTemplate_ProcessSessions</summary>
			public static readonly XrmFakedRelationship MailMergeTemplateProcessSessions = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "mailmergetemplateid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "mailmergetemplate",
					Entity2LogicalName = "processsession",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N MailMergeTemplate_SyncErrors</summary>
			public static readonly XrmFakedRelationship MailMergeTemplateSyncErrors = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "mailmergetemplateid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "mailmergetemplate",
					Entity2LogicalName = "syncerror",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

		}
		#endregion

		#region Fake
		public static MailMergeTemplate Create()
		{
			var faker = new Faker<MailMergeTemplate>()
			.RuleFor(e => e.Body, fake => fake.Lorem.Word())
			.RuleFor(e => e.ComponentState, fake => fake.PickRandom<MailMergeTemplate.egComponentState>())
			.RuleFor(e => e.Createdbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Createdbyyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.CreatedOn, fake => fake.Date.Soon())
			.RuleFor(e => e.Createdonbehalfbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Createdonbehalfbyyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.DefaultFilter, fake => fake.Lorem.Word())
			.RuleFor(e => e.Description, fake => fake.Lorem.Word())
			.RuleFor(e => e.DocumentFormat, fake => fake.PickRandom<MailMergeTemplate.eDocumentFormat>())
			.RuleFor(e => e.ExchangeRate, fake => fake.Finance.Amount())
			.RuleFor(e => e.FileName, fake => fake.Lorem.Word())
			.RuleFor(e => e.FileSizeBytes, fake => fake.Random.Int())
			.RuleFor(e => e.IntroducedVersion, fake => fake.Lorem.Word())
			.RuleFor(e => e.IsManaged, fake => fake.Random.Bool())
			.RuleFor(e => e.ViewableBy, fake => fake.Random.Bool())
			.RuleFor(e => e.Language, fake => fake.Random.Int())
			.RuleFor(e => e.Id, fake => Guid.NewGuid())
			.RuleFor(e => e.MailmergetemplateiduniqueId, fake => Guid.NewGuid())
			.RuleFor(e => e.MailMergeType, fake => fake.PickRandom<MailMergeTemplate.eMailMergeType>())
			.RuleFor(e => e.MimeType, fake => fake.Lorem.Word())
			.RuleFor(e => e.Modifiedbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Modifiedbyyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.ModifiedOn, fake => fake.Date.Soon())
			.RuleFor(e => e.Modifiedonbehalfbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Modifiedonbehalfbyyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.Name, fake => fake.Lorem.Word())
			.RuleFor(e => e.RecordOverwriteTime, fake => fake.Date.Soon())
			.RuleFor(e => e.Owneridname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Owneridtype, fake => fake.Lorem.Word())
			.RuleFor(e => e.Owneridyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.ParameterXml, fake => fake.Lorem.Word())
			.RuleFor(e => e.SolutionId, fake => Guid.NewGuid())
			.RuleFor(e => e.Status, fake => fake.PickRandom<MailMergeTemplate.eStatus>())
			.RuleFor(e => e.StatusReason, fake => fake.PickRandom<MailMergeTemplate.eStatusReason>())
			.RuleFor(e => e.SolutionId2, fake => Guid.NewGuid())
			.RuleFor(e => e.AssociatedEntity, fake => fake.Lorem.Word())
			.RuleFor(e => e.TimeZoneRuleVersionNumber, fake => fake.Random.Int())
			.RuleFor(e => e.Transactioncurrencyidname, fake => fake.Lorem.Word())
			.RuleFor(e => e.UTCConversionTimeZoneCode, fake => fake.Random.Int())
			.RuleFor(e => e.VersionNumber, fake => fake.Random.Int());
			return faker.Generate();
		}
		#endregion
	}
}

