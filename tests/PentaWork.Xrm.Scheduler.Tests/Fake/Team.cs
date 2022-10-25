using Bogus;
using System;
using FakeXrmEasy;
using System.Collections.Generic;
using PentaWork.Xrm.Scheduler.Proxies.Entities;

namespace PentaWork.Xrm.Scheduler.Tests.Fake
{
	public static class FakeTeam
	{	
		#region FakeRelationships
		public static class Relationships 
		{
			/// <summary>1:N ImportFile_Team</summary>
			public static readonly XrmFakedRelationship ImportFileTeam = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "teamid",
					Entity2Attribute = "recordsownerid",
					Entity1LogicalName = "team",
					Entity2LogicalName = "importfile",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lead_owning_team</summary>
			public static readonly XrmFakedRelationship LeadOwningTeam = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "teamid",
					Entity2Attribute = "owningteam",
					Entity1LogicalName = "team",
					Entity2LogicalName = "lead",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N OwningTeam_postfollows</summary>
			public static readonly XrmFakedRelationship OwningTeamPostfollows = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "teamid",
					Entity2Attribute = "owningteam",
					Entity1LogicalName = "team",
					Entity2LogicalName = "postfollow",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N team_accounts</summary>
			public static readonly XrmFakedRelationship TeamAccounts = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "teamid",
					Entity2Attribute = "owningteam",
					Entity1LogicalName = "team",
					Entity2LogicalName = "account",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N team_activity</summary>
			public static readonly XrmFakedRelationship TeamActivity = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "teamid",
					Entity2Attribute = "owningteam",
					Entity1LogicalName = "team",
					Entity2LogicalName = "activitypointer",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N team_activitymonitor</summary>
			public static readonly XrmFakedRelationship TeamActivitymonitor = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "teamid",
					Entity2Attribute = "owningteam",
					Entity1LogicalName = "team",
					Entity2LogicalName = "activitymonitor",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N team_adminsettingsentity</summary>
			public static readonly XrmFakedRelationship TeamAdminsettingsentity = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "teamid",
					Entity2Attribute = "owningteam",
					Entity1LogicalName = "team",
					Entity2LogicalName = "adminsettingsentity",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N team_annotations</summary>
			public static readonly XrmFakedRelationship TeamAnnotations = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "teamid",
					Entity2Attribute = "owningteam",
					Entity1LogicalName = "team",
					Entity2LogicalName = "annotation",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N team_appointment</summary>
			public static readonly XrmFakedRelationship TeamAppointment = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "teamid",
					Entity2Attribute = "owningteam",
					Entity1LogicalName = "team",
					Entity2LogicalName = "appointment",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N team_asyncoperation</summary>
			public static readonly XrmFakedRelationship TeamAsyncoperation = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "teamid",
					Entity2Attribute = "owningteam",
					Entity1LogicalName = "team",
					Entity2LogicalName = "asyncoperation",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N Team_AsyncOperations</summary>
			public static readonly XrmFakedRelationship TeamAsyncOperations = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "teamid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "team",
					Entity2LogicalName = "asyncoperation",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N team_bookableresource</summary>
			public static readonly XrmFakedRelationship TeamBookableresource = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "teamid",
					Entity2Attribute = "owningteam",
					Entity1LogicalName = "team",
					Entity2LogicalName = "bookableresource",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N team_bookableresourcebooking</summary>
			public static readonly XrmFakedRelationship TeamBookableresourcebooking = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "teamid",
					Entity2Attribute = "owningteam",
					Entity1LogicalName = "team",
					Entity2LogicalName = "bookableresourcebooking",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N team_bookableresourcebookingheader</summary>
			public static readonly XrmFakedRelationship TeamBookableresourcebookingheader = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "teamid",
					Entity2Attribute = "owningteam",
					Entity1LogicalName = "team",
					Entity2LogicalName = "bookableresourcebookingheader",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N team_bookableresourcecategory</summary>
			public static readonly XrmFakedRelationship TeamBookableresourcecategory = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "teamid",
					Entity2Attribute = "owningteam",
					Entity1LogicalName = "team",
					Entity2LogicalName = "bookableresourcecategory",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N team_bookableresourcecategoryassn</summary>
			public static readonly XrmFakedRelationship TeamBookableresourcecategoryassn = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "teamid",
					Entity2Attribute = "owningteam",
					Entity1LogicalName = "team",
					Entity2LogicalName = "bookableresourcecategoryassn",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N team_bookableresourcecharacteristic</summary>
			public static readonly XrmFakedRelationship TeamBookableresourcecharacteristic = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "teamid",
					Entity2Attribute = "owningteam",
					Entity1LogicalName = "team",
					Entity2LogicalName = "bookableresourcecharacteristic",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N team_bookableresourcegroup</summary>
			public static readonly XrmFakedRelationship TeamBookableresourcegroup = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "teamid",
					Entity2Attribute = "owningteam",
					Entity1LogicalName = "team",
					Entity2LogicalName = "bookableresourcegroup",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N team_bookingstatus</summary>
			public static readonly XrmFakedRelationship TeamBookingstatus = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "teamid",
					Entity2Attribute = "owningteam",
					Entity1LogicalName = "team",
					Entity2LogicalName = "bookingstatus",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N team_bot</summary>
			public static readonly XrmFakedRelationship TeamBot = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "teamid",
					Entity2Attribute = "owningteam",
					Entity1LogicalName = "team",
					Entity2LogicalName = "bot",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N team_botcomponent</summary>
			public static readonly XrmFakedRelationship TeamBotcomponent = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "teamid",
					Entity2Attribute = "owningteam",
					Entity1LogicalName = "team",
					Entity2LogicalName = "botcomponent",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N Team_BulkDeleteFailures</summary>
			public static readonly XrmFakedRelationship TeamBulkDeleteFailures = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "teamid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "team",
					Entity2LogicalName = "bulkdeletefailure",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N team_BulkOperation</summary>
			public static readonly XrmFakedRelationship TeamBulkOperation = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "teamid",
					Entity2Attribute = "owningteam",
					Entity1LogicalName = "team",
					Entity2LogicalName = "bulkoperation",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N team_campaignactivity</summary>
			public static readonly XrmFakedRelationship TeamCampaignactivity = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "teamid",
					Entity2Attribute = "owningteam",
					Entity1LogicalName = "team",
					Entity2LogicalName = "campaignactivity",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N team_campaignresponse</summary>
			public static readonly XrmFakedRelationship TeamCampaignresponse = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "teamid",
					Entity2Attribute = "owningteam",
					Entity1LogicalName = "team",
					Entity2LogicalName = "campaignresponse",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N team_Campaigns</summary>
			public static readonly XrmFakedRelationship TeamCampaigns = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "teamid",
					Entity2Attribute = "owningteam",
					Entity1LogicalName = "team",
					Entity2LogicalName = "campaign",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N team_characteristic</summary>
			public static readonly XrmFakedRelationship TeamCharacteristic = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "teamid",
					Entity2Attribute = "owningteam",
					Entity1LogicalName = "team",
					Entity2LogicalName = "characteristic",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N team_connectionreference</summary>
			public static readonly XrmFakedRelationship TeamConnectionreference = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "teamid",
					Entity2Attribute = "owningteam",
					Entity1LogicalName = "team",
					Entity2LogicalName = "connectionreference",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N team_connections1</summary>
			public static readonly XrmFakedRelationship TeamConnections1 = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "teamid",
					Entity2Attribute = "record1id",
					Entity1LogicalName = "team",
					Entity2LogicalName = "connection",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N team_connections2</summary>
			public static readonly XrmFakedRelationship TeamConnections2 = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "teamid",
					Entity2Attribute = "record2id",
					Entity1LogicalName = "team",
					Entity2LogicalName = "connection",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N team_connector</summary>
			public static readonly XrmFakedRelationship TeamConnector = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "teamid",
					Entity2Attribute = "owningteam",
					Entity1LogicalName = "team",
					Entity2LogicalName = "connector",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N team_contacts</summary>
			public static readonly XrmFakedRelationship TeamContacts = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "teamid",
					Entity2Attribute = "owningteam",
					Entity1LogicalName = "team",
					Entity2LogicalName = "contact",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N team_contractdetail</summary>
			public static readonly XrmFakedRelationship TeamContractdetail = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "teamid",
					Entity2Attribute = "owningteam",
					Entity1LogicalName = "team",
					Entity2LogicalName = "contractdetail",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N team_conversationtranscript</summary>
			public static readonly XrmFakedRelationship TeamConversationtranscript = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "teamid",
					Entity2Attribute = "owningteam",
					Entity1LogicalName = "team",
					Entity2LogicalName = "conversationtranscript",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N team_customapi</summary>
			public static readonly XrmFakedRelationship TeamCustomapi = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "teamid",
					Entity2Attribute = "owningteam",
					Entity1LogicalName = "team",
					Entity2LogicalName = "customapi",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N team_customapirequestparameter</summary>
			public static readonly XrmFakedRelationship TeamCustomapirequestparameter = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "teamid",
					Entity2Attribute = "owningteam",
					Entity1LogicalName = "team",
					Entity2LogicalName = "customapirequestparameter",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N team_customapiresponseproperty</summary>
			public static readonly XrmFakedRelationship TeamCustomapiresponseproperty = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "teamid",
					Entity2Attribute = "owningteam",
					Entity1LogicalName = "team",
					Entity2LogicalName = "customapiresponseproperty",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N team_datalakefolder</summary>
			public static readonly XrmFakedRelationship TeamDatalakefolder = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "teamid",
					Entity2Attribute = "owningteam",
					Entity1LogicalName = "team",
					Entity2LogicalName = "datalakefolder",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N team_datalakefolderpermission</summary>
			public static readonly XrmFakedRelationship TeamDatalakefolderpermission = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "teamid",
					Entity2Attribute = "owningteam",
					Entity1LogicalName = "team",
					Entity2LogicalName = "datalakefolderpermission",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N Team_DuplicateBaseRecord</summary>
			public static readonly XrmFakedRelationship TeamDuplicateBaseRecord = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "teamid",
					Entity2Attribute = "baserecordid",
					Entity1LogicalName = "team",
					Entity2LogicalName = "duplicaterecord",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N Team_DuplicateMatchingRecord</summary>
			public static readonly XrmFakedRelationship TeamDuplicateMatchingRecord = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "teamid",
					Entity2Attribute = "duplicaterecordid",
					Entity1LogicalName = "team",
					Entity2LogicalName = "duplicaterecord",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N team_DuplicateRules</summary>
			public static readonly XrmFakedRelationship TeamDuplicateRules = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "teamid",
					Entity2Attribute = "owningteam",
					Entity1LogicalName = "team",
					Entity2LogicalName = "duplicaterule",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N team_DynamicPropertyInstance</summary>
			public static readonly XrmFakedRelationship TeamDynamicPropertyInstance = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "teamid",
					Entity2Attribute = "owningteam",
					Entity1LogicalName = "team",
					Entity2LogicalName = "dynamicpropertyinstance",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N team_email</summary>
			public static readonly XrmFakedRelationship TeamEmail = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "teamid",
					Entity2Attribute = "owningteam",
					Entity1LogicalName = "team",
					Entity2LogicalName = "email",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N team_email_templates</summary>
			public static readonly XrmFakedRelationship TeamEmailTemplates = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "teamid",
					Entity2Attribute = "owningteam",
					Entity1LogicalName = "team",
					Entity2LogicalName = "template",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N team_emailserverprofile</summary>
			public static readonly XrmFakedRelationship TeamEmailserverprofile = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "teamid",
					Entity2Attribute = "owningteam",
					Entity1LogicalName = "team",
					Entity2LogicalName = "emailserverprofile",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N team_entitlement</summary>
			public static readonly XrmFakedRelationship TeamEntitlement = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "teamid",
					Entity2Attribute = "owningteam",
					Entity1LogicalName = "team",
					Entity2LogicalName = "entitlement",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N team_entitlementchannel</summary>
			public static readonly XrmFakedRelationship TeamEntitlementchannel = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "teamid",
					Entity2Attribute = "owningteam",
					Entity1LogicalName = "team",
					Entity2LogicalName = "entitlementchannel",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N team_entitlemententityallocationtypemapping</summary>
			public static readonly XrmFakedRelationship TeamEntitlemententityallocationtypemapping = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "teamid",
					Entity2Attribute = "owningteam",
					Entity1LogicalName = "team",
					Entity2LogicalName = "entitlemententityallocationtypemapping",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N team_environmentvariabledefinition</summary>
			public static readonly XrmFakedRelationship TeamEnvironmentvariabledefinition = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "teamid",
					Entity2Attribute = "owningteam",
					Entity1LogicalName = "team",
					Entity2LogicalName = "environmentvariabledefinition",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N team_environmentvariablevalue</summary>
			public static readonly XrmFakedRelationship TeamEnvironmentvariablevalue = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "teamid",
					Entity2Attribute = "owningteam",
					Entity1LogicalName = "team",
					Entity2LogicalName = "environmentvariablevalue",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N team_exchangesyncidmapping</summary>
			public static readonly XrmFakedRelationship TeamExchangesyncidmapping = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "teamid",
					Entity2Attribute = "owningteam",
					Entity1LogicalName = "team",
					Entity2LogicalName = "exchangesyncidmapping",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N team_exportsolutionupload</summary>
			public static readonly XrmFakedRelationship TeamExportsolutionupload = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "teamid",
					Entity2Attribute = "owningteam",
					Entity1LogicalName = "team",
					Entity2LogicalName = "exportsolutionupload",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N team_fax</summary>
			public static readonly XrmFakedRelationship TeamFax = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "teamid",
					Entity2Attribute = "owningteam",
					Entity1LogicalName = "team",
					Entity2LogicalName = "fax",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N team_flowsession</summary>
			public static readonly XrmFakedRelationship TeamFlowsession = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "teamid",
					Entity2Attribute = "owningteam",
					Entity1LogicalName = "team",
					Entity2LogicalName = "flowsession",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N team_goal</summary>
			public static readonly XrmFakedRelationship TeamGoal = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "teamid",
					Entity2Attribute = "owningteam",
					Entity1LogicalName = "team",
					Entity2LogicalName = "goal",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N team_goal_goalowner</summary>
			public static readonly XrmFakedRelationship TeamGoalGoalowner = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "teamid",
					Entity2Attribute = "goalownerid",
					Entity1LogicalName = "team",
					Entity2LogicalName = "goal",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N team_goalrollupquery</summary>
			public static readonly XrmFakedRelationship TeamGoalrollupquery = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "teamid",
					Entity2Attribute = "owningteam",
					Entity1LogicalName = "team",
					Entity2LogicalName = "goalrollupquery",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N team_ImportData</summary>
			public static readonly XrmFakedRelationship TeamImportData = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "teamid",
					Entity2Attribute = "owningteam",
					Entity1LogicalName = "team",
					Entity2LogicalName = "importdata",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N team_ImportFiles</summary>
			public static readonly XrmFakedRelationship TeamImportFiles = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "teamid",
					Entity2Attribute = "owningteam",
					Entity1LogicalName = "team",
					Entity2LogicalName = "importfile",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N team_ImportLogs</summary>
			public static readonly XrmFakedRelationship TeamImportLogs = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "teamid",
					Entity2Attribute = "owningteam",
					Entity1LogicalName = "team",
					Entity2LogicalName = "importlog",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N team_ImportMaps</summary>
			public static readonly XrmFakedRelationship TeamImportMaps = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "teamid",
					Entity2Attribute = "owningteam",
					Entity1LogicalName = "team",
					Entity2LogicalName = "importmap",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N team_Imports</summary>
			public static readonly XrmFakedRelationship TeamImports = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "teamid",
					Entity2Attribute = "owningteam",
					Entity1LogicalName = "team",
					Entity2LogicalName = "import",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N team_incidentresolution</summary>
			public static readonly XrmFakedRelationship TeamIncidentresolution = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "teamid",
					Entity2Attribute = "owningteam",
					Entity1LogicalName = "team",
					Entity2LogicalName = "incidentresolution",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N team_incidents</summary>
			public static readonly XrmFakedRelationship TeamIncidents = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "teamid",
					Entity2Attribute = "owningteam",
					Entity1LogicalName = "team",
					Entity2LogicalName = "incident",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N team_interactionforemail</summary>
			public static readonly XrmFakedRelationship TeamInteractionforemail = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "teamid",
					Entity2Attribute = "owningteam",
					Entity1LogicalName = "team",
					Entity2LogicalName = "interactionforemail",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N team_invoicedetail</summary>
			public static readonly XrmFakedRelationship TeamInvoicedetail = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "teamid",
					Entity2Attribute = "owningteam",
					Entity1LogicalName = "team",
					Entity2LogicalName = "invoicedetail",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N team_invoices</summary>
			public static readonly XrmFakedRelationship TeamInvoices = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "teamid",
					Entity2Attribute = "owningteam",
					Entity1LogicalName = "team",
					Entity2LogicalName = "invoice",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N team_knowledgearticle</summary>
			public static readonly XrmFakedRelationship TeamKnowledgearticle = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "teamid",
					Entity2Attribute = "owningteam",
					Entity1LogicalName = "team",
					Entity2LogicalName = "knowledgearticle",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N team_knowledgearticleincident</summary>
			public static readonly XrmFakedRelationship TeamKnowledgearticleincident = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "teamid",
					Entity2Attribute = "owningteam",
					Entity1LogicalName = "team",
					Entity2LogicalName = "knowledgearticleincident",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N team_letter</summary>
			public static readonly XrmFakedRelationship TeamLetter = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "teamid",
					Entity2Attribute = "owningteam",
					Entity1LogicalName = "team",
					Entity2LogicalName = "letter",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N team_list</summary>
			public static readonly XrmFakedRelationship TeamList = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "teamid",
					Entity2Attribute = "owningteam",
					Entity1LogicalName = "team",
					Entity2LogicalName = "list",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N team_listoperation</summary>
			public static readonly XrmFakedRelationship TeamListoperation = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "teamid",
					Entity2Attribute = "owningteam",
					Entity1LogicalName = "team",
					Entity2LogicalName = "listoperation",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N team_mailbox</summary>
			public static readonly XrmFakedRelationship TeamMailbox = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "teamid",
					Entity2Attribute = "owningteam",
					Entity1LogicalName = "team",
					Entity2LogicalName = "mailbox",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N team_mailboxtrackingfolder</summary>
			public static readonly XrmFakedRelationship TeamMailboxtrackingfolder = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "teamid",
					Entity2Attribute = "owningteam",
					Entity1LogicalName = "team",
					Entity2LogicalName = "mailboxtrackingfolder",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N team_msdyn_actioncardregarding</summary>
			public static readonly XrmFakedRelationship TeamMsdynActioncardregarding = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "teamid",
					Entity2Attribute = "owningteam",
					Entity1LogicalName = "team",
					Entity2LogicalName = "msdyn_actioncardregarding",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N team_msdyn_actioncardrolesetting</summary>
			public static readonly XrmFakedRelationship TeamMsdynActioncardrolesetting = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "teamid",
					Entity2Attribute = "owningteam",
					Entity1LogicalName = "team",
					Entity2LogicalName = "msdyn_actioncardrolesetting",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N team_msdyn_aibdataset</summary>
			public static readonly XrmFakedRelationship TeamMsdynAibdataset = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "teamid",
					Entity2Attribute = "owningteam",
					Entity1LogicalName = "team",
					Entity2LogicalName = "msdyn_aibdataset",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N team_msdyn_aibdatasetfile</summary>
			public static readonly XrmFakedRelationship TeamMsdynAibdatasetfile = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "teamid",
					Entity2Attribute = "owningteam",
					Entity1LogicalName = "team",
					Entity2LogicalName = "msdyn_aibdatasetfile",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N team_msdyn_aibdatasetrecord</summary>
			public static readonly XrmFakedRelationship TeamMsdynAibdatasetrecord = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "teamid",
					Entity2Attribute = "owningteam",
					Entity1LogicalName = "team",
					Entity2LogicalName = "msdyn_aibdatasetrecord",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N team_msdyn_aibdatasetscontainer</summary>
			public static readonly XrmFakedRelationship TeamMsdynAibdatasetscontainer = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "teamid",
					Entity2Attribute = "owningteam",
					Entity1LogicalName = "team",
					Entity2LogicalName = "msdyn_aibdatasetscontainer",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N team_msdyn_aibfile</summary>
			public static readonly XrmFakedRelationship TeamMsdynAibfile = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "teamid",
					Entity2Attribute = "owningteam",
					Entity1LogicalName = "team",
					Entity2LogicalName = "msdyn_aibfile",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N team_msdyn_aibfileattacheddata</summary>
			public static readonly XrmFakedRelationship TeamMsdynAibfileattacheddata = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "teamid",
					Entity2Attribute = "owningteam",
					Entity1LogicalName = "team",
					Entity2LogicalName = "msdyn_aibfileattacheddata",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N team_msdyn_aiconfiguration</summary>
			public static readonly XrmFakedRelationship TeamMsdynAiconfiguration = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "teamid",
					Entity2Attribute = "owningteam",
					Entity1LogicalName = "team",
					Entity2LogicalName = "msdyn_aiconfiguration",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N team_msdyn_aifptrainingdocument</summary>
			public static readonly XrmFakedRelationship TeamMsdynAifptrainingdocument = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "teamid",
					Entity2Attribute = "owningteam",
					Entity1LogicalName = "team",
					Entity2LogicalName = "msdyn_aifptrainingdocument",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N team_msdyn_aimodel</summary>
			public static readonly XrmFakedRelationship TeamMsdynAimodel = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "teamid",
					Entity2Attribute = "owningteam",
					Entity1LogicalName = "team",
					Entity2LogicalName = "msdyn_aimodel",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N team_msdyn_aiodimage</summary>
			public static readonly XrmFakedRelationship TeamMsdynAiodimage = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "teamid",
					Entity2Attribute = "owningteam",
					Entity1LogicalName = "team",
					Entity2LogicalName = "msdyn_aiodimage",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N team_msdyn_aiodlabel</summary>
			public static readonly XrmFakedRelationship TeamMsdynAiodlabel = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "teamid",
					Entity2Attribute = "owningteam",
					Entity1LogicalName = "team",
					Entity2LogicalName = "msdyn_aiodlabel",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N team_msdyn_aiodtrainingboundingbox</summary>
			public static readonly XrmFakedRelationship TeamMsdynAiodtrainingboundingbox = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "teamid",
					Entity2Attribute = "owningteam",
					Entity1LogicalName = "team",
					Entity2LogicalName = "msdyn_aiodtrainingboundingbox",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N team_msdyn_aiodtrainingimage</summary>
			public static readonly XrmFakedRelationship TeamMsdynAiodtrainingimage = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "teamid",
					Entity2Attribute = "owningteam",
					Entity1LogicalName = "team",
					Entity2LogicalName = "msdyn_aiodtrainingimage",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N team_msdyn_aitemplate</summary>
			public static readonly XrmFakedRelationship TeamMsdynAitemplate = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "teamid",
					Entity2Attribute = "owningteam",
					Entity1LogicalName = "team",
					Entity2LogicalName = "msdyn_aitemplate",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N team_msdyn_autocapturerule</summary>
			public static readonly XrmFakedRelationship TeamMsdynAutocapturerule = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "teamid",
					Entity2Attribute = "owningteam",
					Entity1LogicalName = "team",
					Entity2LogicalName = "msdyn_autocapturerule",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N team_msdyn_autocapturesettings</summary>
			public static readonly XrmFakedRelationship TeamMsdynAutocapturesettings = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "teamid",
					Entity2Attribute = "owningteam",
					Entity1LogicalName = "team",
					Entity2LogicalName = "msdyn_autocapturesettings",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N team_msdyn_callablecontext</summary>
			public static readonly XrmFakedRelationship TeamMsdynCallablecontext = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "teamid",
					Entity2Attribute = "owningteam",
					Entity1LogicalName = "team",
					Entity2LogicalName = "msdyn_callablecontext",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N team_msdyn_entityrankingrule</summary>
			public static readonly XrmFakedRelationship TeamMsdynEntityrankingrule = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "teamid",
					Entity2Attribute = "owningteam",
					Entity1LogicalName = "team",
					Entity2LogicalName = "msdyn_entityrankingrule",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N team_msdyn_federatedarticle</summary>
			public static readonly XrmFakedRelationship TeamMsdynFederatedarticle = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "teamid",
					Entity2Attribute = "owningteam",
					Entity1LogicalName = "team",
					Entity2LogicalName = "msdyn_federatedarticle",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N team_msdyn_flowcardtype</summary>
			public static readonly XrmFakedRelationship TeamMsdynFlowcardtype = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "teamid",
					Entity2Attribute = "owningteam",
					Entity1LogicalName = "team",
					Entity2LogicalName = "msdyn_flowcardtype",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N team_msdyn_icebreakersconfig</summary>
			public static readonly XrmFakedRelationship TeamMsdynIcebreakersconfig = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "teamid",
					Entity2Attribute = "owningteam",
					Entity1LogicalName = "team",
					Entity2LogicalName = "msdyn_icebreakersconfig",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N team_msdyn_kmfederatedsearchconfig</summary>
			public static readonly XrmFakedRelationship TeamMsdynKmfederatedsearchconfig = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "teamid",
					Entity2Attribute = "owningteam",
					Entity1LogicalName = "team",
					Entity2LogicalName = "msdyn_kmfederatedsearchconfig",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N team_msdyn_knowledgearticleimage</summary>
			public static readonly XrmFakedRelationship TeamMsdynKnowledgearticleimage = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "teamid",
					Entity2Attribute = "owningteam",
					Entity1LogicalName = "team",
					Entity2LogicalName = "msdyn_knowledgearticleimage",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N team_msdyn_knowledgearticletemplate</summary>
			public static readonly XrmFakedRelationship TeamMsdynKnowledgearticletemplate = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "teamid",
					Entity2Attribute = "owningteam",
					Entity1LogicalName = "team",
					Entity2LogicalName = "msdyn_knowledgearticletemplate",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N team_msdyn_knowledgeinteractioninsight</summary>
			public static readonly XrmFakedRelationship TeamMsdynKnowledgeinteractioninsight = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "teamid",
					Entity2Attribute = "owningteam",
					Entity1LogicalName = "team",
					Entity2LogicalName = "msdyn_knowledgeinteractioninsight",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N team_msdyn_knowledgesearchinsight</summary>
			public static readonly XrmFakedRelationship TeamMsdynKnowledgesearchinsight = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "teamid",
					Entity2Attribute = "owningteam",
					Entity1LogicalName = "team",
					Entity2LogicalName = "msdyn_knowledgesearchinsight",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N team_msdyn_msteamssetting</summary>
			public static readonly XrmFakedRelationship TeamMsdynMsteamssetting = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "teamid",
					Entity2Attribute = "owningteam",
					Entity1LogicalName = "team",
					Entity2LogicalName = "msdyn_msteamssetting",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N team_msdyn_notesanalysisconfig</summary>
			public static readonly XrmFakedRelationship TeamMsdynNotesanalysisconfig = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "teamid",
					Entity2Attribute = "owningteam",
					Entity1LogicalName = "team",
					Entity2LogicalName = "msdyn_notesanalysisconfig",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N team_msdyn_playbookactivity</summary>
			public static readonly XrmFakedRelationship TeamMsdynPlaybookactivity = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "teamid",
					Entity2Attribute = "owningteam",
					Entity1LogicalName = "team",
					Entity2LogicalName = "msdyn_playbookactivity",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N team_msdyn_playbookactivityattribute</summary>
			public static readonly XrmFakedRelationship TeamMsdynPlaybookactivityattribute = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "teamid",
					Entity2Attribute = "owningteam",
					Entity1LogicalName = "team",
					Entity2LogicalName = "msdyn_playbookactivityattribute",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N team_msdyn_playbookcategory</summary>
			public static readonly XrmFakedRelationship TeamMsdynPlaybookcategory = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "teamid",
					Entity2Attribute = "owningteam",
					Entity1LogicalName = "team",
					Entity2LogicalName = "msdyn_playbookcategory",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N team_msdyn_playbookinstance</summary>
			public static readonly XrmFakedRelationship TeamMsdynPlaybookinstance = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "teamid",
					Entity2Attribute = "owningteam",
					Entity1LogicalName = "team",
					Entity2LogicalName = "msdyn_playbookinstance",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N team_msdyn_playbooktemplate</summary>
			public static readonly XrmFakedRelationship TeamMsdynPlaybooktemplate = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "teamid",
					Entity2Attribute = "owningteam",
					Entity1LogicalName = "team",
					Entity2LogicalName = "msdyn_playbooktemplate",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N team_msdyn_postalbum</summary>
			public static readonly XrmFakedRelationship TeamMsdynPostalbum = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "teamid",
					Entity2Attribute = "owningteam",
					Entity1LogicalName = "team",
					Entity2LogicalName = "msdyn_postalbum",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N team_msdyn_relationshipinsightsunifiedconfig</summary>
			public static readonly XrmFakedRelationship TeamMsdynRelationshipinsightsunifiedconfig = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "teamid",
					Entity2Attribute = "owningteam",
					Entity1LogicalName = "team",
					Entity2LogicalName = "msdyn_relationshipinsightsunifiedconfig",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N team_msdyn_richtextfile</summary>
			public static readonly XrmFakedRelationship TeamMsdynRichtextfile = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "teamid",
					Entity2Attribute = "owningteam",
					Entity1LogicalName = "team",
					Entity2LogicalName = "msdyn_richtextfile",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N team_msdyn_salesinsightssettings</summary>
			public static readonly XrmFakedRelationship TeamMsdynSalesinsightssettings = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "teamid",
					Entity2Attribute = "owningteam",
					Entity1LogicalName = "team",
					Entity2LogicalName = "msdyn_salesinsightssettings",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N team_msdyn_siconfig</summary>
			public static readonly XrmFakedRelationship TeamMsdynSiconfig = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "teamid",
					Entity2Attribute = "owningteam",
					Entity1LogicalName = "team",
					Entity2LogicalName = "msdyn_siconfig",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N team_msdyn_untrackedappointment</summary>
			public static readonly XrmFakedRelationship TeamMsdynUntrackedappointment = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "teamid",
					Entity2Attribute = "owningteam",
					Entity1LogicalName = "team",
					Entity2LogicalName = "msdyn_untrackedappointment",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N team_msdyn_wallsavedqueryusersettings</summary>
			public static readonly XrmFakedRelationship TeamMsdynWallsavedqueryusersettings = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "teamid",
					Entity2Attribute = "owningteam",
					Entity1LogicalName = "team",
					Entity2LogicalName = "msdyn_wallsavedqueryusersettings",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N team_msdynce_botcontent</summary>
			public static readonly XrmFakedRelationship TeamMsdynceBotcontent = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "teamid",
					Entity2Attribute = "owningteam",
					Entity1LogicalName = "team",
					Entity2LogicalName = "msdynce_botcontent",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N team_opportunities</summary>
			public static readonly XrmFakedRelationship TeamOpportunities = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "teamid",
					Entity2Attribute = "owningteam",
					Entity1LogicalName = "team",
					Entity2LogicalName = "opportunity",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N team_opportunityclose</summary>
			public static readonly XrmFakedRelationship TeamOpportunityclose = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "teamid",
					Entity2Attribute = "owningteam",
					Entity1LogicalName = "team",
					Entity2LogicalName = "opportunityclose",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N team_opportunityproduct</summary>
			public static readonly XrmFakedRelationship TeamOpportunityproduct = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "teamid",
					Entity2Attribute = "owningteam",
					Entity1LogicalName = "team",
					Entity2LogicalName = "opportunityproduct",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N team_orderclose</summary>
			public static readonly XrmFakedRelationship TeamOrderclose = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "teamid",
					Entity2Attribute = "owningteam",
					Entity1LogicalName = "team",
					Entity2LogicalName = "orderclose",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N team_orders</summary>
			public static readonly XrmFakedRelationship TeamOrders = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "teamid",
					Entity2Attribute = "owningteam",
					Entity1LogicalName = "team",
					Entity2LogicalName = "salesorder",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N team_phonecall</summary>
			public static readonly XrmFakedRelationship TeamPhonecall = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "teamid",
					Entity2Attribute = "owningteam",
					Entity1LogicalName = "team",
					Entity2LogicalName = "phonecall",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N team_principalobjectattributeaccess</summary>
			public static readonly XrmFakedRelationship TeamPrincipalobjectattributeaccess = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "teamid",
					Entity2Attribute = "objectid",
					Entity1LogicalName = "team",
					Entity2LogicalName = "principalobjectattributeaccess",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N team_principalobjectattributeaccess_principalid</summary>
			public static readonly XrmFakedRelationship TeamPrincipalobjectattributeaccessPrincipalid = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "teamid",
					Entity2Attribute = "principalid",
					Entity1LogicalName = "team",
					Entity2LogicalName = "principalobjectattributeaccess",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N team_processsession</summary>
			public static readonly XrmFakedRelationship TeamProcesssession = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "teamid",
					Entity2Attribute = "owningteam",
					Entity1LogicalName = "team",
					Entity2LogicalName = "processsession",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N Team_ProcessSessions</summary>
			public static readonly XrmFakedRelationship TeamProcessSessions = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "teamid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "team",
					Entity2LogicalName = "processsession",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N team_processstageparameter</summary>
			public static readonly XrmFakedRelationship TeamProcessstageparameter = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "teamid",
					Entity2Attribute = "owningteam",
					Entity1LogicalName = "team",
					Entity2LogicalName = "processstageparameter",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N team_pw_penta_schedule_run</summary>
			public static readonly XrmFakedRelationship TeamPwPentaScheduleRun = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "teamid",
					Entity2Attribute = "owningteam",
					Entity1LogicalName = "team",
					Entity2LogicalName = "pw_penta_schedule_run",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N team_pw_schedule</summary>
			public static readonly XrmFakedRelationship TeamPwSchedule = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "teamid",
					Entity2Attribute = "owningteam",
					Entity1LogicalName = "team",
					Entity2LogicalName = "pw_schedule",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N team_queueitembase_workerid</summary>
			public static readonly XrmFakedRelationship TeamQueueitembaseWorkerid = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "teamid",
					Entity2Attribute = "workerid",
					Entity1LogicalName = "team",
					Entity2LogicalName = "queueitem",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N team_quoteclose</summary>
			public static readonly XrmFakedRelationship TeamQuoteclose = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "teamid",
					Entity2Attribute = "owningteam",
					Entity1LogicalName = "team",
					Entity2LogicalName = "quoteclose",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N team_quotedetail</summary>
			public static readonly XrmFakedRelationship TeamQuotedetail = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "teamid",
					Entity2Attribute = "owningteam",
					Entity1LogicalName = "team",
					Entity2LogicalName = "quotedetail",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N team_quotes</summary>
			public static readonly XrmFakedRelationship TeamQuotes = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "teamid",
					Entity2Attribute = "owningteam",
					Entity1LogicalName = "team",
					Entity2LogicalName = "quote",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N team_ratingmodel</summary>
			public static readonly XrmFakedRelationship TeamRatingmodel = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "teamid",
					Entity2Attribute = "owningteam",
					Entity1LogicalName = "team",
					Entity2LogicalName = "ratingmodel",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N team_ratingvalue</summary>
			public static readonly XrmFakedRelationship TeamRatingvalue = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "teamid",
					Entity2Attribute = "owningteam",
					Entity1LogicalName = "team",
					Entity2LogicalName = "ratingvalue",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N team_recurringappointmentmaster</summary>
			public static readonly XrmFakedRelationship TeamRecurringappointmentmaster = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "teamid",
					Entity2Attribute = "owningteam",
					Entity1LogicalName = "team",
					Entity2LogicalName = "recurringappointmentmaster",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N team_resource_groups</summary>
			public static readonly XrmFakedRelationship TeamResourceGroups = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "teamid",
					Entity2Attribute = "resourcegroupid",
					Entity1LogicalName = "team",
					Entity2LogicalName = "resourcegroup",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N team_resource_specs</summary>
			public static readonly XrmFakedRelationship TeamResourceSpecs = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "teamid",
					Entity2Attribute = "groupobjectid",
					Entity1LogicalName = "team",
					Entity2LogicalName = "resourcespec",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N team_salesorderdetail</summary>
			public static readonly XrmFakedRelationship TeamSalesorderdetail = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "teamid",
					Entity2Attribute = "owningteam",
					Entity1LogicalName = "team",
					Entity2LogicalName = "salesorderdetail",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N team_service_appointments</summary>
			public static readonly XrmFakedRelationship TeamServiceAppointments = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "teamid",
					Entity2Attribute = "owningteam",
					Entity1LogicalName = "team",
					Entity2LogicalName = "serviceappointment",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N team_service_contracts</summary>
			public static readonly XrmFakedRelationship TeamServiceContracts = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "teamid",
					Entity2Attribute = "owningteam",
					Entity1LogicalName = "team",
					Entity2LogicalName = "contract",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N team_sharepointdocumentlocation</summary>
			public static readonly XrmFakedRelationship TeamSharepointdocumentlocation = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "teamid",
					Entity2Attribute = "owningteam",
					Entity1LogicalName = "team",
					Entity2LogicalName = "sharepointdocumentlocation",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N team_sharepointsite</summary>
			public static readonly XrmFakedRelationship TeamSharepointsite = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "teamid",
					Entity2Attribute = "owningteam",
					Entity1LogicalName = "team",
					Entity2LogicalName = "sharepointsite",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N team_slaBase</summary>
			public static readonly XrmFakedRelationship TeamSlaBase = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "teamid",
					Entity2Attribute = "owningteam",
					Entity1LogicalName = "team",
					Entity2LogicalName = "sla",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N team_socialactivity</summary>
			public static readonly XrmFakedRelationship TeamSocialactivity = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "teamid",
					Entity2Attribute = "owningteam",
					Entity1LogicalName = "team",
					Entity2LogicalName = "socialactivity",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N team_stagesolutionupload</summary>
			public static readonly XrmFakedRelationship TeamStagesolutionupload = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "teamid",
					Entity2Attribute = "owningteam",
					Entity1LogicalName = "team",
					Entity2LogicalName = "stagesolutionupload",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N team_SyncError</summary>
			public static readonly XrmFakedRelationship TeamSyncError = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "teamid",
					Entity2Attribute = "owningteam",
					Entity1LogicalName = "team",
					Entity2LogicalName = "syncerror",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N Team_SyncErrors</summary>
			public static readonly XrmFakedRelationship TeamSyncErrors = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "teamid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "team",
					Entity2LogicalName = "syncerror",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N team_task</summary>
			public static readonly XrmFakedRelationship TeamTask = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "teamid",
					Entity2Attribute = "owningteam",
					Entity1LogicalName = "team",
					Entity2LogicalName = "task",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N team_userform</summary>
			public static readonly XrmFakedRelationship TeamUserform = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "teamid",
					Entity2Attribute = "owningteam",
					Entity1LogicalName = "team",
					Entity2LogicalName = "userform",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N team_userquery</summary>
			public static readonly XrmFakedRelationship TeamUserquery = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "teamid",
					Entity2Attribute = "owningteam",
					Entity1LogicalName = "team",
					Entity2LogicalName = "userquery",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N team_userqueryvisualizations</summary>
			public static readonly XrmFakedRelationship TeamUserqueryvisualizations = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "teamid",
					Entity2Attribute = "owningteam",
					Entity1LogicalName = "team",
					Entity2LogicalName = "userqueryvisualization",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N team_workflow</summary>
			public static readonly XrmFakedRelationship TeamWorkflow = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "teamid",
					Entity2Attribute = "owningteam",
					Entity1LogicalName = "team",
					Entity2LogicalName = "workflow",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N team_workflowbinary</summary>
			public static readonly XrmFakedRelationship TeamWorkflowbinary = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "teamid",
					Entity2Attribute = "owningteam",
					Entity1LogicalName = "team",
					Entity2LogicalName = "workflowbinary",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N team_workflowlog</summary>
			public static readonly XrmFakedRelationship TeamWorkflowlog = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "teamid",
					Entity2Attribute = "owningteam",
					Entity1LogicalName = "team",
					Entity2LogicalName = "workflowlog",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>N:N teammembership_association</summary>
			public static readonly XrmFakedRelationship TeammembershipAssociation = 
				new XrmFakedRelationship
				{
					IntersectEntity = "teammembership_association",
					Entity1Attribute = "teamid",
					Entity2Attribute = "systemuserid",
					Entity1LogicalName = "team",
					Entity2LogicalName = "systemuser",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.ManyToMany
				};

			/// <summary>N:N teamprofiles_association</summary>
			public static readonly XrmFakedRelationship TeamprofilesAssociation = 
				new XrmFakedRelationship
				{
					IntersectEntity = "teamprofiles_association",
					Entity1Attribute = "teamid",
					Entity2Attribute = "fieldsecurityprofileid",
					Entity1LogicalName = "team",
					Entity2LogicalName = "fieldsecurityprofile",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.ManyToMany
				};

			/// <summary>N:N teamroles_association</summary>
			public static readonly XrmFakedRelationship TeamrolesAssociation = 
				new XrmFakedRelationship
				{
					IntersectEntity = "teamroles_association",
					Entity1Attribute = "teamid",
					Entity2Attribute = "roleid",
					Entity1LogicalName = "team",
					Entity2LogicalName = "role",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.ManyToMany
				};

		}
		#endregion

		#region Fake
		public static Team Create()
		{
			var faker = new Faker<Team>()
			.RuleFor(e => e.Administratoridname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Administratoridyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.AzureADObjectIdForAGroupId, fake => Guid.NewGuid())
			.RuleFor(e => e.Businessunitidname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Createdbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Createdbyyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.CreatedOn, fake => fake.Date.Soon())
			.RuleFor(e => e.Createdonbehalfbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Createdonbehalfbyyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.Description, fake => fake.Lorem.Word())
			.RuleFor(e => e.Email, fake => fake.Lorem.Word())
			.RuleFor(e => e.ExchangeRate, fake => fake.Finance.Amount())
			.RuleFor(e => e.ImportSequenceNumber, fake => fake.Random.Int())
			.RuleFor(e => e.IsDefault, fake => fake.Random.Bool())
			.RuleFor(e => e.MembershipType, fake => fake.PickRandom<Team.eMembershipType>())
			.RuleFor(e => e.Modifiedbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Modifiedbyyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.ModifiedOn, fake => fake.Date.Soon())
			.RuleFor(e => e.Modifiedonbehalfbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Modifiedonbehalfbyyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.TeamName, fake => fake.Lorem.Word())
			.RuleFor(e => e.OrganizationId, fake => Guid.NewGuid())
			.RuleFor(e => e.Organizationidname, fake => fake.Lorem.Word())
			.RuleFor(e => e.RecordCreatedOn, fake => fake.Date.Soon())
			.RuleFor(e => e.ProcessId, fake => Guid.NewGuid())
			.RuleFor(e => e.Queueidname, fake => fake.Lorem.Word())
			.RuleFor(e => e.RegardingObjectType, fake => fake.Lorem.Word())
			.RuleFor(e => e.DeprecatedProcessStageId, fake => Guid.NewGuid())
			.RuleFor(e => e.IsSystemManaged, fake => fake.Random.Bool())
			.RuleFor(e => e.Id, fake => Guid.NewGuid())
			.RuleFor(e => e.TeamType, fake => fake.PickRandom<Team.eTeamType>())
			.RuleFor(e => e.Transactioncurrencyidname, fake => fake.Lorem.Word())
			.RuleFor(e => e.DeprecatedTraversedPath, fake => fake.Lorem.Word())
			.RuleFor(e => e.VersionNumber, fake => fake.Random.Int())
			.RuleFor(e => e.YomiName, fake => fake.Lorem.Word());
			return faker.Generate();
		}
		#endregion
	}
}

