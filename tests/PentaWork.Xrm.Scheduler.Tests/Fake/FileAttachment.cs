using Bogus;
using System;
using FakeXrmEasy;
using System.Collections.Generic;
using PentaWork.Xrm.Scheduler.Proxies.Entities;

namespace PentaWork.Xrm.Scheduler.Tests.Fake
{
	public static class FakeFileAttachment
	{	
		#region FakeRelationships
		public static class Relationships 
		{
			/// <summary>1:N FileAttachment_AsyncOperation_DataBlobId</summary>
			public static readonly XrmFakedRelationship FileAttachmentAsyncOperationDataBlobId = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "fileattachmentid",
					Entity2Attribute = "datablobid",
					Entity1LogicalName = "fileattachment",
					Entity2LogicalName = "asyncoperation",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N FileAttachment_CanvasApp_Assets</summary>
			public static readonly XrmFakedRelationship FileAttachmentCanvasAppAssets = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "fileattachmentid",
					Entity2Attribute = "assets",
					Entity1LogicalName = "fileattachment",
					Entity2LogicalName = "canvasapp",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N FileAttachment_CanvasApp_BackgroundImage</summary>
			public static readonly XrmFakedRelationship FileAttachmentCanvasAppBackgroundImage = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "fileattachmentid",
					Entity2Attribute = "background_image",
					Entity1LogicalName = "fileattachment",
					Entity2LogicalName = "canvasapp",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N FileAttachment_CanvasApp_Document</summary>
			public static readonly XrmFakedRelationship FileAttachmentCanvasAppDocument = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "fileattachmentid",
					Entity2Attribute = "document",
					Entity1LogicalName = "fileattachment",
					Entity2LogicalName = "canvasapp",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N FileAttachment_CanvasApp_LargeIcon</summary>
			public static readonly XrmFakedRelationship FileAttachmentCanvasAppLargeIcon = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "fileattachmentid",
					Entity2Attribute = "large_icon",
					Entity1LogicalName = "fileattachment",
					Entity2LogicalName = "canvasapp",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N FileAttachment_CanvasApp_MediumIcon</summary>
			public static readonly XrmFakedRelationship FileAttachmentCanvasAppMediumIcon = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "fileattachmentid",
					Entity2Attribute = "medium_icon",
					Entity1LogicalName = "fileattachment",
					Entity2LogicalName = "canvasapp",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N FileAttachment_CanvasApp_SmallIcon</summary>
			public static readonly XrmFakedRelationship FileAttachmentCanvasAppSmallIcon = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "fileattachmentid",
					Entity2Attribute = "small_icon",
					Entity1LogicalName = "fileattachment",
					Entity2LogicalName = "canvasapp",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N FileAttachment_CanvasApp_TeamsIcon</summary>
			public static readonly XrmFakedRelationship FileAttachmentCanvasAppTeamsIcon = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "fileattachmentid",
					Entity2Attribute = "teams_icon",
					Entity1LogicalName = "fileattachment",
					Entity2LogicalName = "canvasapp",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N FileAttachment_CanvasApp_WideIcon</summary>
			public static readonly XrmFakedRelationship FileAttachmentCanvasAppWideIcon = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "fileattachmentid",
					Entity2Attribute = "wide_icon",
					Entity1LogicalName = "fileattachment",
					Entity2LogicalName = "canvasapp",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N FileAttachment_ExportSolutionUpload_SolutionFile</summary>
			public static readonly XrmFakedRelationship FileAttachmentExportSolutionUploadSolutionFile = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "fileattachmentid",
					Entity2Attribute = "solutionfile",
					Entity1LogicalName = "fileattachment",
					Entity2LogicalName = "exportsolutionupload",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N FileAttachment_FlowSession_AdditionalContext</summary>
			public static readonly XrmFakedRelationship FileAttachmentFlowSessionAdditionalContext = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "fileattachmentid",
					Entity2Attribute = "additionalcontext",
					Entity1LogicalName = "fileattachment",
					Entity2LogicalName = "flowsession",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N FileAttachment_FlowSession_Outputs</summary>
			public static readonly XrmFakedRelationship FileAttachmentFlowSessionOutputs = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "fileattachmentid",
					Entity2Attribute = "outputs",
					Entity1LogicalName = "fileattachment",
					Entity2LogicalName = "flowsession",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N FileAttachment_Mailbox_ExchangeSyncStateXmlFileRef</summary>
			public static readonly XrmFakedRelationship FileAttachmentMailboxExchangeSyncStateXmlFileRef = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "fileattachmentid",
					Entity2Attribute = "exchangesyncstatexmlfileref",
					Entity1LogicalName = "fileattachment",
					Entity2LogicalName = "mailbox",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N FileAttachment_msdyn_AIBFile_msdyn_File</summary>
			public static readonly XrmFakedRelationship FileAttachmentMsdynAIBFileMsdynFile = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "fileattachmentid",
					Entity2Attribute = "msdyn_file",
					Entity1LogicalName = "fileattachment",
					Entity2LogicalName = "msdyn_aibfile",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N FileAttachment_msdyn_AIConfiguration_msdyn_Model</summary>
			public static readonly XrmFakedRelationship FileAttachmentMsdynAIConfigurationMsdynModel = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "fileattachmentid",
					Entity2Attribute = "msdyn_model",
					Entity1LogicalName = "fileattachment",
					Entity2LogicalName = "msdyn_aiconfiguration",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N FileAttachment_msdyn_knowledgearticleimage_msdyn_BlobFile</summary>
			public static readonly XrmFakedRelationship FileAttachmentMsdynKnowledgearticleimageMsdynBlobFile = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "fileattachmentid",
					Entity2Attribute = "msdyn_blobfile",
					Entity1LogicalName = "fileattachment",
					Entity2LogicalName = "msdyn_knowledgearticleimage",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N FileAttachment_msdyn_richtextfile_msdyn_fileblob</summary>
			public static readonly XrmFakedRelationship FileAttachmentMsdynRichtextfileMsdynFileblob = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "fileattachmentid",
					Entity2Attribute = "msdyn_fileblob",
					Entity1LogicalName = "fileattachment",
					Entity2LogicalName = "msdyn_richtextfile",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N fileattachment_solution_fileid</summary>
			public static readonly XrmFakedRelationship FileattachmentSolutionFileid = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "fileattachmentid",
					Entity2Attribute = "fileid",
					Entity1LogicalName = "fileattachment",
					Entity2LogicalName = "solution",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N FileAttachment_StageSolutionUpload_SolutionFile</summary>
			public static readonly XrmFakedRelationship FileAttachmentStageSolutionUploadSolutionFile = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "fileattachmentid",
					Entity2Attribute = "solutionfile",
					Entity1LogicalName = "fileattachment",
					Entity2LogicalName = "stagesolutionupload",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N FileAttachment_SyncErrors</summary>
			public static readonly XrmFakedRelationship FileAttachmentSyncErrors = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "fileattachmentid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "fileattachment",
					Entity2LogicalName = "syncerror",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N FileAttachment_workflowbinary_Data</summary>
			public static readonly XrmFakedRelationship FileAttachmentWorkflowbinaryData = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "fileattachmentid",
					Entity2Attribute = "data",
					Entity1LogicalName = "fileattachment",
					Entity2LogicalName = "workflowbinary",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N FileAttachment_WorkflowLog_Inputs</summary>
			public static readonly XrmFakedRelationship FileAttachmentWorkflowLogInputs = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "fileattachmentid",
					Entity2Attribute = "inputs",
					Entity1LogicalName = "fileattachment",
					Entity2LogicalName = "workflowlog",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N FileAttachment_WorkflowLog_Outputs</summary>
			public static readonly XrmFakedRelationship FileAttachmentWorkflowLogOutputs = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "fileattachmentid",
					Entity2Attribute = "outputs",
					Entity1LogicalName = "fileattachment",
					Entity2LogicalName = "workflowlog",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

		}
		#endregion

		#region Fake
		public static FileAttachment Create()
		{
			var faker = new Faker<FileAttachment>()
			.RuleFor(e => e.Body, fake => fake.Lorem.Word())
			.RuleFor(e => e.CreatedOn, fake => fake.Date.Soon())
			.RuleFor(e => e.Id, fake => Guid.NewGuid())
			.RuleFor(e => e.FileName, fake => fake.Lorem.Word())
			.RuleFor(e => e.FilePointer, fake => fake.Lorem.Word())
			.RuleFor(e => e.FileSizeBytes, fake => fake.Random.Int())
			.RuleFor(e => e.IsCommitted, fake => fake.Random.Bool())
			.RuleFor(e => e.MIMEType, fake => fake.Lorem.Word())
			.RuleFor(e => e.ObjectIdTypeCode, fake => fake.Lorem.Word())
			.RuleFor(e => e.ObjectType, fake => fake.Lorem.Word())
			.RuleFor(e => e.Prefix, fake => fake.Lorem.Word())
			.RuleFor(e => e.RegardingAttributeSchemaName, fake => fake.Lorem.Word())
			.RuleFor(e => e.StoragePointer, fake => fake.Lorem.Word())
			.RuleFor(e => e.VersionNumber, fake => fake.Random.Int());
			return faker.Generate();
		}
		#endregion
	}
}

