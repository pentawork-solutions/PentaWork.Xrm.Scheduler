using Bogus;
using System;
using FakeXrmEasy;
using System.Collections.Generic;
using PentaWork.Xrm.Scheduler.Proxies.Entities;

namespace PentaWork.Xrm.Scheduler.Tests.Fake
{
	public static class FakeReport
	{	
		#region FakeRelationships
		public static class Relationships 
		{
			/// <summary>1:N Report_AsyncOperations</summary>
			public static readonly XrmFakedRelationship ReportAsyncOperations = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "reportid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "report",
					Entity2LogicalName = "asyncoperation",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N report_parent_report</summary>
			public static readonly XrmFakedRelationship ReportParentReport = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "reportid",
					Entity2Attribute = "parentreportid",
					Entity1LogicalName = "report",
					Entity2LogicalName = "report",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N Report_ProcessSessions</summary>
			public static readonly XrmFakedRelationship ReportProcessSessions = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "reportid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "report",
					Entity2LogicalName = "processsession",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N report_reportcategories</summary>
			public static readonly XrmFakedRelationship ReportReportcategories = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "reportid",
					Entity2Attribute = "reportid",
					Entity1LogicalName = "report",
					Entity2LogicalName = "reportcategory",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N Report_SyncErrors</summary>
			public static readonly XrmFakedRelationship ReportSyncErrors = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "reportid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "report",
					Entity2LogicalName = "syncerror",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

		}
		#endregion

		#region Fake
		public static Report Create()
		{
			var faker = new Faker<Report>()
			.RuleFor(e => e.BodyBinary, fake => fake.Lorem.Word())
			.RuleFor(e => e.BodyText, fake => fake.Lorem.Word())
			.RuleFor(e => e.LinkedReportURL, fake => fake.Lorem.Word())
			.RuleFor(e => e.ComponentState, fake => fake.PickRandom<Report.egComponentState>())
			.RuleFor(e => e.Createdbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Createdbyyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.CrmVersionInWhichTheReportIsCreated, fake => fake.Random.Int())
			.RuleFor(e => e.CreatedOn, fake => fake.Date.Soon())
			.RuleFor(e => e.Createdonbehalfbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Createdonbehalfbyyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.CustomReportXML, fake => fake.Lorem.Word())
			.RuleFor(e => e.DefaultFilter, fake => fake.Lorem.Word())
			.RuleFor(e => e.Description, fake => fake.Lorem.Word())
			.RuleFor(e => e.FileName, fake => fake.Lorem.Word())
			.RuleFor(e => e.FileSizeBytes, fake => fake.Random.Int())
			.RuleFor(e => e.IntroducedVersion, fake => fake.Lorem.Word())
			.RuleFor(e => e.IsCustomReport, fake => fake.Random.Bool())
			.RuleFor(e => e.IsManaged, fake => fake.Random.Bool())
			.RuleFor(e => e.ViewableBy, fake => fake.Random.Bool())
			.RuleFor(e => e.IsScheduledReport, fake => fake.Random.Bool())
			.RuleFor(e => e.Language, fake => fake.Random.Int())
			.RuleFor(e => e.MimeType, fake => fake.Lorem.Word())
			.RuleFor(e => e.Modifiedbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Modifiedbyyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.ModifiedOn, fake => fake.Date.Soon())
			.RuleFor(e => e.Modifiedonbehalfbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Modifiedonbehalfbyyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.Name, fake => fake.Lorem.Word())
			.RuleFor(e => e.BodyText2, fake => fake.Lorem.Word())
			.RuleFor(e => e.RecordOverwriteTime, fake => fake.Date.Soon())
			.RuleFor(e => e.Owneridname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Owneridtype, fake => fake.Lorem.Word())
			.RuleFor(e => e.Owneridyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.Parentreportidname, fake => fake.Lorem.Word())
			.RuleFor(e => e.QueryInfoStructure, fake => fake.Lorem.Word())
			.RuleFor(e => e.BodyTextHash, fake => fake.Random.Int())
			.RuleFor(e => e.Id, fake => Guid.NewGuid())
			.RuleFor(e => e.ReportId2, fake => Guid.NewGuid())
			.RuleFor(e => e.NameOnSRS, fake => fake.Lorem.Word())
			.RuleFor(e => e.ReportType, fake => fake.PickRandom<Report.eReportType>())
			.RuleFor(e => e.ScheduleDefinitionXML, fake => fake.Lorem.Word())
			.RuleFor(e => e.ReportSignatureDate, fake => fake.Date.Soon())
			.RuleFor(e => e.SignatureId, fake => Guid.NewGuid())
			.RuleFor(e => e.SignatureLanguageCode, fake => fake.Random.Int())
			.RuleFor(e => e.ReportSignatureMajorVersion, fake => fake.Random.Int())
			.RuleFor(e => e.ReportSignatureMinorVersion, fake => fake.Random.Int())
			.RuleFor(e => e.SolutionId, fake => Guid.NewGuid())
			.RuleFor(e => e.SolutionId2, fake => Guid.NewGuid())
			.RuleFor(e => e.TimeZoneRuleVersionNumber, fake => fake.Random.Int())
			.RuleFor(e => e.UTCConversionTimeZoneCode, fake => fake.Random.Int())
			.RuleFor(e => e.VersionNumber, fake => fake.Random.Int());
			return faker.Generate();
		}
		#endregion
	}
}

