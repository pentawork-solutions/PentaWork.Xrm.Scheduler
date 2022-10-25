using Bogus;
using System;
using FakeXrmEasy;
using System.Collections.Generic;
using PentaWork.Xrm.Scheduler.Proxies.Entities;

namespace PentaWork.Xrm.Scheduler.Tests.Fake
{
	public static class FakeOwner
	{	
		#region FakeRelationships
		public static class Relationships 
		{
			/// <summary>1:N ActionCardUserState_Owner</summary>
			public static readonly XrmFakedRelationship ActionCardUserStateOwner = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "ownerid",
					Entity2Attribute = "ownerid",
					Entity1LogicalName = "owner",
					Entity2LogicalName = "actioncarduserstate",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N bulkoperation_owner_ownerid</summary>
			public static readonly XrmFakedRelationship BulkoperationOwnerOwnerid = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "ownerid",
					Entity2Attribute = "ownerid",
					Entity1LogicalName = "owner",
					Entity2LogicalName = "bulkoperation",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N campaignactivity_owner_ownerid</summary>
			public static readonly XrmFakedRelationship CampaignactivityOwnerOwnerid = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "ownerid",
					Entity2Attribute = "ownerid",
					Entity1LogicalName = "owner",
					Entity2LogicalName = "campaignactivity",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N campaignresponse_owner_ownerid</summary>
			public static readonly XrmFakedRelationship CampaignresponseOwnerOwnerid = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "ownerid",
					Entity2Attribute = "ownerid",
					Entity1LogicalName = "owner",
					Entity2LogicalName = "campaignresponse",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N incidentresolution_owner_ownerid</summary>
			public static readonly XrmFakedRelationship IncidentresolutionOwnerOwnerid = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "ownerid",
					Entity2Attribute = "ownerid",
					Entity1LogicalName = "owner",
					Entity2LogicalName = "incidentresolution",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N opportunityclose_owner_ownerid</summary>
			public static readonly XrmFakedRelationship OpportunitycloseOwnerOwnerid = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "ownerid",
					Entity2Attribute = "ownerid",
					Entity1LogicalName = "owner",
					Entity2LogicalName = "opportunityclose",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N orderclose_owner_ownerid</summary>
			public static readonly XrmFakedRelationship OrdercloseOwnerOwnerid = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "ownerid",
					Entity2Attribute = "ownerid",
					Entity1LogicalName = "owner",
					Entity2LogicalName = "orderclose",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N owner_accounts</summary>
			public static readonly XrmFakedRelationship OwnerAccounts = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "ownerid",
					Entity2Attribute = "ownerid",
					Entity1LogicalName = "owner",
					Entity2LogicalName = "account",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N owner_actioncards</summary>
			public static readonly XrmFakedRelationship OwnerActioncards = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "ownerid",
					Entity2Attribute = "ownerid",
					Entity1LogicalName = "owner",
					Entity2LogicalName = "actioncard",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N owner_activitymonitor</summary>
			public static readonly XrmFakedRelationship OwnerActivitymonitor = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "ownerid",
					Entity2Attribute = "ownerid",
					Entity1LogicalName = "owner",
					Entity2LogicalName = "activitymonitor",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N owner_activitypointers</summary>
			public static readonly XrmFakedRelationship OwnerActivitypointers = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "ownerid",
					Entity2Attribute = "ownerid",
					Entity1LogicalName = "owner",
					Entity2LogicalName = "activitypointer",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N owner_adminsettingsentity</summary>
			public static readonly XrmFakedRelationship OwnerAdminsettingsentity = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "ownerid",
					Entity2Attribute = "ownerid",
					Entity1LogicalName = "owner",
					Entity2LogicalName = "adminsettingsentity",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N owner_annotations</summary>
			public static readonly XrmFakedRelationship OwnerAnnotations = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "ownerid",
					Entity2Attribute = "ownerid",
					Entity1LogicalName = "owner",
					Entity2LogicalName = "annotation",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N owner_appointments</summary>
			public static readonly XrmFakedRelationship OwnerAppointments = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "ownerid",
					Entity2Attribute = "ownerid",
					Entity1LogicalName = "owner",
					Entity2LogicalName = "appointment",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N owner_asyncoperations</summary>
			public static readonly XrmFakedRelationship OwnerAsyncoperations = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "ownerid",
					Entity2Attribute = "ownerid",
					Entity1LogicalName = "owner",
					Entity2LogicalName = "asyncoperation",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N owner_bookableresource</summary>
			public static readonly XrmFakedRelationship OwnerBookableresource = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "ownerid",
					Entity2Attribute = "ownerid",
					Entity1LogicalName = "owner",
					Entity2LogicalName = "bookableresource",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N owner_bookableresourcebooking</summary>
			public static readonly XrmFakedRelationship OwnerBookableresourcebooking = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "ownerid",
					Entity2Attribute = "ownerid",
					Entity1LogicalName = "owner",
					Entity2LogicalName = "bookableresourcebooking",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N owner_bookableresourcebookingheader</summary>
			public static readonly XrmFakedRelationship OwnerBookableresourcebookingheader = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "ownerid",
					Entity2Attribute = "ownerid",
					Entity1LogicalName = "owner",
					Entity2LogicalName = "bookableresourcebookingheader",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N owner_bookableresourcecategory</summary>
			public static readonly XrmFakedRelationship OwnerBookableresourcecategory = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "ownerid",
					Entity2Attribute = "ownerid",
					Entity1LogicalName = "owner",
					Entity2LogicalName = "bookableresourcecategory",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N owner_bookableresourcecategoryassn</summary>
			public static readonly XrmFakedRelationship OwnerBookableresourcecategoryassn = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "ownerid",
					Entity2Attribute = "ownerid",
					Entity1LogicalName = "owner",
					Entity2LogicalName = "bookableresourcecategoryassn",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N owner_bookableresourcecharacteristic</summary>
			public static readonly XrmFakedRelationship OwnerBookableresourcecharacteristic = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "ownerid",
					Entity2Attribute = "ownerid",
					Entity1LogicalName = "owner",
					Entity2LogicalName = "bookableresourcecharacteristic",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N owner_bookableresourcegroup</summary>
			public static readonly XrmFakedRelationship OwnerBookableresourcegroup = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "ownerid",
					Entity2Attribute = "ownerid",
					Entity1LogicalName = "owner",
					Entity2LogicalName = "bookableresourcegroup",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N owner_bookingstatus</summary>
			public static readonly XrmFakedRelationship OwnerBookingstatus = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "ownerid",
					Entity2Attribute = "ownerid",
					Entity1LogicalName = "owner",
					Entity2LogicalName = "bookingstatus",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N owner_bot</summary>
			public static readonly XrmFakedRelationship OwnerBot = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "ownerid",
					Entity2Attribute = "ownerid",
					Entity1LogicalName = "owner",
					Entity2LogicalName = "bot",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N owner_botcomponent</summary>
			public static readonly XrmFakedRelationship OwnerBotcomponent = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "ownerid",
					Entity2Attribute = "ownerid",
					Entity1LogicalName = "owner",
					Entity2LogicalName = "botcomponent",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N owner_callbackregistration</summary>
			public static readonly XrmFakedRelationship OwnerCallbackregistration = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "ownerid",
					Entity2Attribute = "ownerid",
					Entity1LogicalName = "owner",
					Entity2LogicalName = "callbackregistration",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N owner_campaigns</summary>
			public static readonly XrmFakedRelationship OwnerCampaigns = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "ownerid",
					Entity2Attribute = "ownerid",
					Entity1LogicalName = "owner",
					Entity2LogicalName = "campaign",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N owner_canvasapp</summary>
			public static readonly XrmFakedRelationship OwnerCanvasapp = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "ownerid",
					Entity2Attribute = "ownerid",
					Entity1LogicalName = "owner",
					Entity2LogicalName = "canvasapp",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N owner_categories</summary>
			public static readonly XrmFakedRelationship OwnerCategories = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "ownerid",
					Entity2Attribute = "ownerid",
					Entity1LogicalName = "owner",
					Entity2LogicalName = "category",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N owner_characteristic</summary>
			public static readonly XrmFakedRelationship OwnerCharacteristic = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "ownerid",
					Entity2Attribute = "ownerid",
					Entity1LogicalName = "owner",
					Entity2LogicalName = "characteristic",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N owner_connectionreference</summary>
			public static readonly XrmFakedRelationship OwnerConnectionreference = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "ownerid",
					Entity2Attribute = "ownerid",
					Entity1LogicalName = "owner",
					Entity2LogicalName = "connectionreference",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N owner_connections</summary>
			public static readonly XrmFakedRelationship OwnerConnections = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "ownerid",
					Entity2Attribute = "ownerid",
					Entity1LogicalName = "owner",
					Entity2LogicalName = "connection",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N owner_connector</summary>
			public static readonly XrmFakedRelationship OwnerConnector = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "ownerid",
					Entity2Attribute = "ownerid",
					Entity1LogicalName = "owner",
					Entity2LogicalName = "connector",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N owner_contacts</summary>
			public static readonly XrmFakedRelationship OwnerContacts = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "ownerid",
					Entity2Attribute = "ownerid",
					Entity1LogicalName = "owner",
					Entity2LogicalName = "contact",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N owner_contracts</summary>
			public static readonly XrmFakedRelationship OwnerContracts = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "ownerid",
					Entity2Attribute = "ownerid",
					Entity1LogicalName = "owner",
					Entity2LogicalName = "contract",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N owner_conversationtranscript</summary>
			public static readonly XrmFakedRelationship OwnerConversationtranscript = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "ownerid",
					Entity2Attribute = "ownerid",
					Entity1LogicalName = "owner",
					Entity2LogicalName = "conversationtranscript",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N owner_customapi</summary>
			public static readonly XrmFakedRelationship OwnerCustomapi = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "ownerid",
					Entity2Attribute = "ownerid",
					Entity1LogicalName = "owner",
					Entity2LogicalName = "customapi",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N owner_customapirequestparameter</summary>
			public static readonly XrmFakedRelationship OwnerCustomapirequestparameter = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "ownerid",
					Entity2Attribute = "ownerid",
					Entity1LogicalName = "owner",
					Entity2LogicalName = "customapirequestparameter",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N owner_customapiresponseproperty</summary>
			public static readonly XrmFakedRelationship OwnerCustomapiresponseproperty = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "ownerid",
					Entity2Attribute = "ownerid",
					Entity1LogicalName = "owner",
					Entity2LogicalName = "customapiresponseproperty",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N owner_datalakefolder</summary>
			public static readonly XrmFakedRelationship OwnerDatalakefolder = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "ownerid",
					Entity2Attribute = "ownerid",
					Entity1LogicalName = "owner",
					Entity2LogicalName = "datalakefolder",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N owner_datalakefolderpermission</summary>
			public static readonly XrmFakedRelationship OwnerDatalakefolderpermission = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "ownerid",
					Entity2Attribute = "ownerid",
					Entity1LogicalName = "owner",
					Entity2LogicalName = "datalakefolderpermission",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N owner_duplicaterules</summary>
			public static readonly XrmFakedRelationship OwnerDuplicaterules = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "ownerid",
					Entity2Attribute = "ownerid",
					Entity1LogicalName = "owner",
					Entity2LogicalName = "duplicaterule",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N Owner_dynamicproperyinstance</summary>
			public static readonly XrmFakedRelationship OwnerDynamicproperyinstance = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "ownerid",
					Entity2Attribute = "ownerid",
					Entity1LogicalName = "owner",
					Entity2LogicalName = "dynamicpropertyinstance",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N owner_emails</summary>
			public static readonly XrmFakedRelationship OwnerEmails = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "ownerid",
					Entity2Attribute = "ownerid",
					Entity1LogicalName = "owner",
					Entity2LogicalName = "email",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N owner_emailserverprofile</summary>
			public static readonly XrmFakedRelationship OwnerEmailserverprofile = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "ownerid",
					Entity2Attribute = "ownerid",
					Entity1LogicalName = "owner",
					Entity2LogicalName = "emailserverprofile",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N owner_entitlement</summary>
			public static readonly XrmFakedRelationship OwnerEntitlement = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "ownerid",
					Entity2Attribute = "ownerid",
					Entity1LogicalName = "owner",
					Entity2LogicalName = "entitlement",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N owner_entitlemententityallocationtypemapping</summary>
			public static readonly XrmFakedRelationship OwnerEntitlemententityallocationtypemapping = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "ownerid",
					Entity2Attribute = "ownerid",
					Entity1LogicalName = "owner",
					Entity2LogicalName = "entitlemententityallocationtypemapping",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N owner_environmentvariabledefinition</summary>
			public static readonly XrmFakedRelationship OwnerEnvironmentvariabledefinition = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "ownerid",
					Entity2Attribute = "ownerid",
					Entity1LogicalName = "owner",
					Entity2LogicalName = "environmentvariabledefinition",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N owner_environmentvariablevalue</summary>
			public static readonly XrmFakedRelationship OwnerEnvironmentvariablevalue = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "ownerid",
					Entity2Attribute = "ownerid",
					Entity1LogicalName = "owner",
					Entity2LogicalName = "environmentvariablevalue",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N owner_exchangesyncidmapping</summary>
			public static readonly XrmFakedRelationship OwnerExchangesyncidmapping = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "ownerid",
					Entity2Attribute = "ownerid",
					Entity1LogicalName = "owner",
					Entity2LogicalName = "exchangesyncidmapping",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N owner_exportsolutionupload</summary>
			public static readonly XrmFakedRelationship OwnerExportsolutionupload = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "ownerid",
					Entity2Attribute = "ownerid",
					Entity1LogicalName = "owner",
					Entity2LogicalName = "exportsolutionupload",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N owner_faxes</summary>
			public static readonly XrmFakedRelationship OwnerFaxes = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "ownerid",
					Entity2Attribute = "ownerid",
					Entity1LogicalName = "owner",
					Entity2LogicalName = "fax",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N owner_feedback</summary>
			public static readonly XrmFakedRelationship OwnerFeedback = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "ownerid",
					Entity2Attribute = "ownerid",
					Entity1LogicalName = "owner",
					Entity2LogicalName = "feedback",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N owner_flowsession</summary>
			public static readonly XrmFakedRelationship OwnerFlowsession = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "ownerid",
					Entity2Attribute = "ownerid",
					Entity1LogicalName = "owner",
					Entity2LogicalName = "flowsession",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N owner_goal</summary>
			public static readonly XrmFakedRelationship OwnerGoal = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "ownerid",
					Entity2Attribute = "ownerid",
					Entity1LogicalName = "owner",
					Entity2LogicalName = "goal",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N owner_goalrollupquery</summary>
			public static readonly XrmFakedRelationship OwnerGoalrollupquery = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "ownerid",
					Entity2Attribute = "ownerid",
					Entity1LogicalName = "owner",
					Entity2LogicalName = "goalrollupquery",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N owner_importdatas</summary>
			public static readonly XrmFakedRelationship OwnerImportdatas = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "ownerid",
					Entity2Attribute = "ownerid",
					Entity1LogicalName = "owner",
					Entity2LogicalName = "importdata",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N owner_importfiles</summary>
			public static readonly XrmFakedRelationship OwnerImportfiles = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "ownerid",
					Entity2Attribute = "ownerid",
					Entity1LogicalName = "owner",
					Entity2LogicalName = "importfile",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N owner_importlogs</summary>
			public static readonly XrmFakedRelationship OwnerImportlogs = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "ownerid",
					Entity2Attribute = "ownerid",
					Entity1LogicalName = "owner",
					Entity2LogicalName = "importlog",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N owner_importmaps</summary>
			public static readonly XrmFakedRelationship OwnerImportmaps = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "ownerid",
					Entity2Attribute = "ownerid",
					Entity1LogicalName = "owner",
					Entity2LogicalName = "importmap",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N owner_imports</summary>
			public static readonly XrmFakedRelationship OwnerImports = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "ownerid",
					Entity2Attribute = "ownerid",
					Entity1LogicalName = "owner",
					Entity2LogicalName = "import",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N owner_incidents</summary>
			public static readonly XrmFakedRelationship OwnerIncidents = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "ownerid",
					Entity2Attribute = "ownerid",
					Entity1LogicalName = "owner",
					Entity2LogicalName = "incident",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N owner_interactionforemail</summary>
			public static readonly XrmFakedRelationship OwnerInteractionforemail = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "ownerid",
					Entity2Attribute = "ownerid",
					Entity1LogicalName = "owner",
					Entity2LogicalName = "interactionforemail",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N owner_invoices</summary>
			public static readonly XrmFakedRelationship OwnerInvoices = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "ownerid",
					Entity2Attribute = "ownerid",
					Entity1LogicalName = "owner",
					Entity2LogicalName = "invoice",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N owner_knowledgearticle</summary>
			public static readonly XrmFakedRelationship OwnerKnowledgearticle = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "ownerid",
					Entity2Attribute = "ownerid",
					Entity1LogicalName = "owner",
					Entity2LogicalName = "knowledgearticle",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N owner_leads</summary>
			public static readonly XrmFakedRelationship OwnerLeads = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "ownerid",
					Entity2Attribute = "ownerid",
					Entity1LogicalName = "owner",
					Entity2LogicalName = "lead",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N owner_letters</summary>
			public static readonly XrmFakedRelationship OwnerLetters = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "ownerid",
					Entity2Attribute = "ownerid",
					Entity1LogicalName = "owner",
					Entity2LogicalName = "letter",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N owner_listoperation</summary>
			public static readonly XrmFakedRelationship OwnerListoperation = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "ownerid",
					Entity2Attribute = "ownerid",
					Entity1LogicalName = "owner",
					Entity2LogicalName = "listoperation",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N owner_lists</summary>
			public static readonly XrmFakedRelationship OwnerLists = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "ownerid",
					Entity2Attribute = "ownerid",
					Entity1LogicalName = "owner",
					Entity2LogicalName = "list",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N owner_mailbox</summary>
			public static readonly XrmFakedRelationship OwnerMailbox = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "ownerid",
					Entity2Attribute = "ownerid",
					Entity1LogicalName = "owner",
					Entity2LogicalName = "mailbox",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N owner_mailboxtrackingfolder</summary>
			public static readonly XrmFakedRelationship OwnerMailboxtrackingfolder = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "ownerid",
					Entity2Attribute = "ownerid",
					Entity1LogicalName = "owner",
					Entity2LogicalName = "mailboxtrackingfolder",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N owner_mailmergetemplates</summary>
			public static readonly XrmFakedRelationship OwnerMailmergetemplates = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "ownerid",
					Entity2Attribute = "ownerid",
					Entity1LogicalName = "owner",
					Entity2LogicalName = "mailmergetemplate",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N owner_msdyn_actioncardregarding</summary>
			public static readonly XrmFakedRelationship OwnerMsdynActioncardregarding = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "ownerid",
					Entity2Attribute = "ownerid",
					Entity1LogicalName = "owner",
					Entity2LogicalName = "msdyn_actioncardregarding",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N owner_msdyn_actioncardrolesetting</summary>
			public static readonly XrmFakedRelationship OwnerMsdynActioncardrolesetting = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "ownerid",
					Entity2Attribute = "ownerid",
					Entity1LogicalName = "owner",
					Entity2LogicalName = "msdyn_actioncardrolesetting",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N owner_msdyn_aibdataset</summary>
			public static readonly XrmFakedRelationship OwnerMsdynAibdataset = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "ownerid",
					Entity2Attribute = "ownerid",
					Entity1LogicalName = "owner",
					Entity2LogicalName = "msdyn_aibdataset",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N owner_msdyn_aibdatasetfile</summary>
			public static readonly XrmFakedRelationship OwnerMsdynAibdatasetfile = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "ownerid",
					Entity2Attribute = "ownerid",
					Entity1LogicalName = "owner",
					Entity2LogicalName = "msdyn_aibdatasetfile",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N owner_msdyn_aibdatasetrecord</summary>
			public static readonly XrmFakedRelationship OwnerMsdynAibdatasetrecord = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "ownerid",
					Entity2Attribute = "ownerid",
					Entity1LogicalName = "owner",
					Entity2LogicalName = "msdyn_aibdatasetrecord",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N owner_msdyn_aibdatasetscontainer</summary>
			public static readonly XrmFakedRelationship OwnerMsdynAibdatasetscontainer = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "ownerid",
					Entity2Attribute = "ownerid",
					Entity1LogicalName = "owner",
					Entity2LogicalName = "msdyn_aibdatasetscontainer",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N owner_msdyn_aibfile</summary>
			public static readonly XrmFakedRelationship OwnerMsdynAibfile = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "ownerid",
					Entity2Attribute = "ownerid",
					Entity1LogicalName = "owner",
					Entity2LogicalName = "msdyn_aibfile",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N owner_msdyn_aibfileattacheddata</summary>
			public static readonly XrmFakedRelationship OwnerMsdynAibfileattacheddata = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "ownerid",
					Entity2Attribute = "ownerid",
					Entity1LogicalName = "owner",
					Entity2LogicalName = "msdyn_aibfileattacheddata",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N owner_msdyn_aiconfiguration</summary>
			public static readonly XrmFakedRelationship OwnerMsdynAiconfiguration = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "ownerid",
					Entity2Attribute = "ownerid",
					Entity1LogicalName = "owner",
					Entity2LogicalName = "msdyn_aiconfiguration",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N owner_msdyn_aifptrainingdocument</summary>
			public static readonly XrmFakedRelationship OwnerMsdynAifptrainingdocument = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "ownerid",
					Entity2Attribute = "ownerid",
					Entity1LogicalName = "owner",
					Entity2LogicalName = "msdyn_aifptrainingdocument",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N owner_msdyn_aimodel</summary>
			public static readonly XrmFakedRelationship OwnerMsdynAimodel = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "ownerid",
					Entity2Attribute = "ownerid",
					Entity1LogicalName = "owner",
					Entity2LogicalName = "msdyn_aimodel",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N owner_msdyn_aiodimage</summary>
			public static readonly XrmFakedRelationship OwnerMsdynAiodimage = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "ownerid",
					Entity2Attribute = "ownerid",
					Entity1LogicalName = "owner",
					Entity2LogicalName = "msdyn_aiodimage",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N owner_msdyn_aiodlabel</summary>
			public static readonly XrmFakedRelationship OwnerMsdynAiodlabel = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "ownerid",
					Entity2Attribute = "ownerid",
					Entity1LogicalName = "owner",
					Entity2LogicalName = "msdyn_aiodlabel",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N owner_msdyn_aiodtrainingboundingbox</summary>
			public static readonly XrmFakedRelationship OwnerMsdynAiodtrainingboundingbox = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "ownerid",
					Entity2Attribute = "ownerid",
					Entity1LogicalName = "owner",
					Entity2LogicalName = "msdyn_aiodtrainingboundingbox",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N owner_msdyn_aiodtrainingimage</summary>
			public static readonly XrmFakedRelationship OwnerMsdynAiodtrainingimage = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "ownerid",
					Entity2Attribute = "ownerid",
					Entity1LogicalName = "owner",
					Entity2LogicalName = "msdyn_aiodtrainingimage",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N owner_msdyn_aitemplate</summary>
			public static readonly XrmFakedRelationship OwnerMsdynAitemplate = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "ownerid",
					Entity2Attribute = "ownerid",
					Entity1LogicalName = "owner",
					Entity2LogicalName = "msdyn_aitemplate",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N owner_msdyn_autocapturerule</summary>
			public static readonly XrmFakedRelationship OwnerMsdynAutocapturerule = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "ownerid",
					Entity2Attribute = "ownerid",
					Entity1LogicalName = "owner",
					Entity2LogicalName = "msdyn_autocapturerule",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N owner_msdyn_autocapturesettings</summary>
			public static readonly XrmFakedRelationship OwnerMsdynAutocapturesettings = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "ownerid",
					Entity2Attribute = "ownerid",
					Entity1LogicalName = "owner",
					Entity2LogicalName = "msdyn_autocapturesettings",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N owner_msdyn_callablecontext</summary>
			public static readonly XrmFakedRelationship OwnerMsdynCallablecontext = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "ownerid",
					Entity2Attribute = "ownerid",
					Entity1LogicalName = "owner",
					Entity2LogicalName = "msdyn_callablecontext",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N owner_msdyn_entityrankingrule</summary>
			public static readonly XrmFakedRelationship OwnerMsdynEntityrankingrule = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "ownerid",
					Entity2Attribute = "ownerid",
					Entity1LogicalName = "owner",
					Entity2LogicalName = "msdyn_entityrankingrule",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N owner_msdyn_federatedarticle</summary>
			public static readonly XrmFakedRelationship OwnerMsdynFederatedarticle = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "ownerid",
					Entity2Attribute = "ownerid",
					Entity1LogicalName = "owner",
					Entity2LogicalName = "msdyn_federatedarticle",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N owner_msdyn_flowcardtype</summary>
			public static readonly XrmFakedRelationship OwnerMsdynFlowcardtype = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "ownerid",
					Entity2Attribute = "ownerid",
					Entity1LogicalName = "owner",
					Entity2LogicalName = "msdyn_flowcardtype",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N owner_msdyn_icebreakersconfig</summary>
			public static readonly XrmFakedRelationship OwnerMsdynIcebreakersconfig = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "ownerid",
					Entity2Attribute = "ownerid",
					Entity1LogicalName = "owner",
					Entity2LogicalName = "msdyn_icebreakersconfig",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N owner_msdyn_kmfederatedsearchconfig</summary>
			public static readonly XrmFakedRelationship OwnerMsdynKmfederatedsearchconfig = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "ownerid",
					Entity2Attribute = "ownerid",
					Entity1LogicalName = "owner",
					Entity2LogicalName = "msdyn_kmfederatedsearchconfig",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N owner_msdyn_knowledgearticleimage</summary>
			public static readonly XrmFakedRelationship OwnerMsdynKnowledgearticleimage = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "ownerid",
					Entity2Attribute = "ownerid",
					Entity1LogicalName = "owner",
					Entity2LogicalName = "msdyn_knowledgearticleimage",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N owner_msdyn_knowledgearticletemplate</summary>
			public static readonly XrmFakedRelationship OwnerMsdynKnowledgearticletemplate = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "ownerid",
					Entity2Attribute = "ownerid",
					Entity1LogicalName = "owner",
					Entity2LogicalName = "msdyn_knowledgearticletemplate",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N owner_msdyn_knowledgeinteractioninsight</summary>
			public static readonly XrmFakedRelationship OwnerMsdynKnowledgeinteractioninsight = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "ownerid",
					Entity2Attribute = "ownerid",
					Entity1LogicalName = "owner",
					Entity2LogicalName = "msdyn_knowledgeinteractioninsight",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N owner_msdyn_knowledgesearchinsight</summary>
			public static readonly XrmFakedRelationship OwnerMsdynKnowledgesearchinsight = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "ownerid",
					Entity2Attribute = "ownerid",
					Entity1LogicalName = "owner",
					Entity2LogicalName = "msdyn_knowledgesearchinsight",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N owner_msdyn_msteamssetting</summary>
			public static readonly XrmFakedRelationship OwnerMsdynMsteamssetting = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "ownerid",
					Entity2Attribute = "ownerid",
					Entity1LogicalName = "owner",
					Entity2LogicalName = "msdyn_msteamssetting",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N owner_msdyn_notesanalysisconfig</summary>
			public static readonly XrmFakedRelationship OwnerMsdynNotesanalysisconfig = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "ownerid",
					Entity2Attribute = "ownerid",
					Entity1LogicalName = "owner",
					Entity2LogicalName = "msdyn_notesanalysisconfig",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N owner_msdyn_playbookactivity</summary>
			public static readonly XrmFakedRelationship OwnerMsdynPlaybookactivity = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "ownerid",
					Entity2Attribute = "ownerid",
					Entity1LogicalName = "owner",
					Entity2LogicalName = "msdyn_playbookactivity",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N owner_msdyn_playbookactivityattribute</summary>
			public static readonly XrmFakedRelationship OwnerMsdynPlaybookactivityattribute = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "ownerid",
					Entity2Attribute = "ownerid",
					Entity1LogicalName = "owner",
					Entity2LogicalName = "msdyn_playbookactivityattribute",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N owner_msdyn_playbookcategory</summary>
			public static readonly XrmFakedRelationship OwnerMsdynPlaybookcategory = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "ownerid",
					Entity2Attribute = "ownerid",
					Entity1LogicalName = "owner",
					Entity2LogicalName = "msdyn_playbookcategory",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N owner_msdyn_playbookinstance</summary>
			public static readonly XrmFakedRelationship OwnerMsdynPlaybookinstance = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "ownerid",
					Entity2Attribute = "ownerid",
					Entity1LogicalName = "owner",
					Entity2LogicalName = "msdyn_playbookinstance",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N owner_msdyn_playbooktemplate</summary>
			public static readonly XrmFakedRelationship OwnerMsdynPlaybooktemplate = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "ownerid",
					Entity2Attribute = "ownerid",
					Entity1LogicalName = "owner",
					Entity2LogicalName = "msdyn_playbooktemplate",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N owner_msdyn_postalbum</summary>
			public static readonly XrmFakedRelationship OwnerMsdynPostalbum = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "ownerid",
					Entity2Attribute = "ownerid",
					Entity1LogicalName = "owner",
					Entity2LogicalName = "msdyn_postalbum",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N owner_msdyn_relationshipinsightsunifiedconfig</summary>
			public static readonly XrmFakedRelationship OwnerMsdynRelationshipinsightsunifiedconfig = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "ownerid",
					Entity2Attribute = "ownerid",
					Entity1LogicalName = "owner",
					Entity2LogicalName = "msdyn_relationshipinsightsunifiedconfig",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N owner_msdyn_richtextfile</summary>
			public static readonly XrmFakedRelationship OwnerMsdynRichtextfile = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "ownerid",
					Entity2Attribute = "ownerid",
					Entity1LogicalName = "owner",
					Entity2LogicalName = "msdyn_richtextfile",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N owner_msdyn_salesinsightssettings</summary>
			public static readonly XrmFakedRelationship OwnerMsdynSalesinsightssettings = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "ownerid",
					Entity2Attribute = "ownerid",
					Entity1LogicalName = "owner",
					Entity2LogicalName = "msdyn_salesinsightssettings",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N owner_msdyn_siconfig</summary>
			public static readonly XrmFakedRelationship OwnerMsdynSiconfig = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "ownerid",
					Entity2Attribute = "ownerid",
					Entity1LogicalName = "owner",
					Entity2LogicalName = "msdyn_siconfig",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N owner_msdyn_untrackedappointment</summary>
			public static readonly XrmFakedRelationship OwnerMsdynUntrackedappointment = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "ownerid",
					Entity2Attribute = "ownerid",
					Entity1LogicalName = "owner",
					Entity2LogicalName = "msdyn_untrackedappointment",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N owner_msdyn_wallsavedqueryusersettings</summary>
			public static readonly XrmFakedRelationship OwnerMsdynWallsavedqueryusersettings = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "ownerid",
					Entity2Attribute = "ownerid",
					Entity1LogicalName = "owner",
					Entity2LogicalName = "msdyn_wallsavedqueryusersettings",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N owner_msdynce_botcontent</summary>
			public static readonly XrmFakedRelationship OwnerMsdynceBotcontent = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "ownerid",
					Entity2Attribute = "ownerid",
					Entity1LogicalName = "owner",
					Entity2LogicalName = "msdynce_botcontent",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N owner_opportunitys</summary>
			public static readonly XrmFakedRelationship OwnerOpportunitys = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "ownerid",
					Entity2Attribute = "ownerid",
					Entity1LogicalName = "owner",
					Entity2LogicalName = "opportunity",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N owner_personaldocumenttemplates</summary>
			public static readonly XrmFakedRelationship OwnerPersonaldocumenttemplates = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "ownerid",
					Entity2Attribute = "ownerid",
					Entity1LogicalName = "owner",
					Entity2LogicalName = "personaldocumenttemplate",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N owner_phonecalls</summary>
			public static readonly XrmFakedRelationship OwnerPhonecalls = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "ownerid",
					Entity2Attribute = "ownerid",
					Entity1LogicalName = "owner",
					Entity2LogicalName = "phonecall",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N owner_postfollows</summary>
			public static readonly XrmFakedRelationship OwnerPostfollows = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "ownerid",
					Entity2Attribute = "ownerid",
					Entity1LogicalName = "owner",
					Entity2LogicalName = "postfollow",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N owner_processsessions</summary>
			public static readonly XrmFakedRelationship OwnerProcesssessions = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "ownerid",
					Entity2Attribute = "ownerid",
					Entity1LogicalName = "owner",
					Entity2LogicalName = "processsession",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N owner_processstageparameter</summary>
			public static readonly XrmFakedRelationship OwnerProcessstageparameter = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "ownerid",
					Entity2Attribute = "ownerid",
					Entity1LogicalName = "owner",
					Entity2LogicalName = "processstageparameter",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N owner_pw_penta_schedule_run</summary>
			public static readonly XrmFakedRelationship OwnerPwPentaScheduleRun = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "ownerid",
					Entity2Attribute = "ownerid",
					Entity1LogicalName = "owner",
					Entity2LogicalName = "pw_penta_schedule_run",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N owner_pw_schedule</summary>
			public static readonly XrmFakedRelationship OwnerPwSchedule = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "ownerid",
					Entity2Attribute = "ownerid",
					Entity1LogicalName = "owner",
					Entity2LogicalName = "pw_schedule",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N owner_queues</summary>
			public static readonly XrmFakedRelationship OwnerQueues = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "ownerid",
					Entity2Attribute = "ownerid",
					Entity1LogicalName = "owner",
					Entity2LogicalName = "queue",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N owner_quotes</summary>
			public static readonly XrmFakedRelationship OwnerQuotes = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "ownerid",
					Entity2Attribute = "ownerid",
					Entity1LogicalName = "owner",
					Entity2LogicalName = "quote",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N owner_ratingmodel</summary>
			public static readonly XrmFakedRelationship OwnerRatingmodel = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "ownerid",
					Entity2Attribute = "ownerid",
					Entity1LogicalName = "owner",
					Entity2LogicalName = "ratingmodel",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N owner_ratingvalue</summary>
			public static readonly XrmFakedRelationship OwnerRatingvalue = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "ownerid",
					Entity2Attribute = "ownerid",
					Entity1LogicalName = "owner",
					Entity2LogicalName = "ratingvalue",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N owner_recurrencerules</summary>
			public static readonly XrmFakedRelationship OwnerRecurrencerules = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "ownerid",
					Entity2Attribute = "ownerid",
					Entity1LogicalName = "owner",
					Entity2LogicalName = "recurrencerule",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N owner_recurringappointmentmasters</summary>
			public static readonly XrmFakedRelationship OwnerRecurringappointmentmasters = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "ownerid",
					Entity2Attribute = "ownerid",
					Entity1LogicalName = "owner",
					Entity2LogicalName = "recurringappointmentmaster",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N owner_reports</summary>
			public static readonly XrmFakedRelationship OwnerReports = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "ownerid",
					Entity2Attribute = "ownerid",
					Entity1LogicalName = "owner",
					Entity2LogicalName = "report",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N owner_salesorders</summary>
			public static readonly XrmFakedRelationship OwnerSalesorders = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "ownerid",
					Entity2Attribute = "ownerid",
					Entity1LogicalName = "owner",
					Entity2LogicalName = "salesorder",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N owner_sharepointdocumentlocation</summary>
			public static readonly XrmFakedRelationship OwnerSharepointdocumentlocation = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "ownerid",
					Entity2Attribute = "ownerid",
					Entity1LogicalName = "owner",
					Entity2LogicalName = "sharepointdocumentlocation",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N owner_sharepointsite</summary>
			public static readonly XrmFakedRelationship OwnerSharepointsite = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "ownerid",
					Entity2Attribute = "ownerid",
					Entity1LogicalName = "owner",
					Entity2LogicalName = "sharepointsite",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N owner_slas</summary>
			public static readonly XrmFakedRelationship OwnerSlas = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "ownerid",
					Entity2Attribute = "ownerid",
					Entity1LogicalName = "owner",
					Entity2LogicalName = "sla",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N owner_socialactivities</summary>
			public static readonly XrmFakedRelationship OwnerSocialactivities = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "ownerid",
					Entity2Attribute = "ownerid",
					Entity1LogicalName = "owner",
					Entity2LogicalName = "socialactivity",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N owner_SocialProfile</summary>
			public static readonly XrmFakedRelationship OwnerSocialProfile = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "ownerid",
					Entity2Attribute = "ownerid",
					Entity1LogicalName = "owner",
					Entity2LogicalName = "socialprofile",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N owner_stagesolutionupload</summary>
			public static readonly XrmFakedRelationship OwnerStagesolutionupload = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "ownerid",
					Entity2Attribute = "ownerid",
					Entity1LogicalName = "owner",
					Entity2LogicalName = "stagesolutionupload",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N owner_SyncError</summary>
			public static readonly XrmFakedRelationship OwnerSyncError = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "ownerid",
					Entity2Attribute = "ownerid",
					Entity1LogicalName = "owner",
					Entity2LogicalName = "syncerror",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N owner_tasks</summary>
			public static readonly XrmFakedRelationship OwnerTasks = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "ownerid",
					Entity2Attribute = "ownerid",
					Entity1LogicalName = "owner",
					Entity2LogicalName = "task",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N owner_templates</summary>
			public static readonly XrmFakedRelationship OwnerTemplates = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "ownerid",
					Entity2Attribute = "ownerid",
					Entity1LogicalName = "owner",
					Entity2LogicalName = "template",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N owner_userform</summary>
			public static readonly XrmFakedRelationship OwnerUserform = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "ownerid",
					Entity2Attribute = "ownerid",
					Entity1LogicalName = "owner",
					Entity2LogicalName = "userform",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N owner_userquerys</summary>
			public static readonly XrmFakedRelationship OwnerUserquerys = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "ownerid",
					Entity2Attribute = "ownerid",
					Entity1LogicalName = "owner",
					Entity2LogicalName = "userquery",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N owner_userqueryvisualizations</summary>
			public static readonly XrmFakedRelationship OwnerUserqueryvisualizations = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "ownerid",
					Entity2Attribute = "ownerid",
					Entity1LogicalName = "owner",
					Entity2LogicalName = "userqueryvisualization",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N owner_workflowbinary</summary>
			public static readonly XrmFakedRelationship OwnerWorkflowbinary = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "ownerid",
					Entity2Attribute = "ownerid",
					Entity1LogicalName = "owner",
					Entity2LogicalName = "workflowbinary",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N owner_workflows</summary>
			public static readonly XrmFakedRelationship OwnerWorkflows = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "ownerid",
					Entity2Attribute = "ownerid",
					Entity1LogicalName = "owner",
					Entity2LogicalName = "workflow",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N quoteclose_owner_ownerid</summary>
			public static readonly XrmFakedRelationship QuotecloseOwnerOwnerid = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "ownerid",
					Entity2Attribute = "ownerid",
					Entity1LogicalName = "owner",
					Entity2LogicalName = "quoteclose",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N serviceappointment_owner_ownerid</summary>
			public static readonly XrmFakedRelationship ServiceappointmentOwnerOwnerid = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "ownerid",
					Entity2Attribute = "ownerid",
					Entity1LogicalName = "owner",
					Entity2LogicalName = "serviceappointment",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N slakpiinstance_owner</summary>
			public static readonly XrmFakedRelationship SlakpiinstanceOwner = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "ownerid",
					Entity2Attribute = "ownerid",
					Entity1LogicalName = "owner",
					Entity2LogicalName = "slakpiinstance",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

		}
		#endregion

		#region Fake
		public static Owner Create()
		{
			var faker = new Faker<Owner>()
			.RuleFor(e => e.OwnerName, fake => fake.Lorem.Word())
			.RuleFor(e => e.Id, fake => Guid.NewGuid())
			.RuleFor(e => e.Owneridtype, fake => fake.Lorem.Word())
			.RuleFor(e => e.Versionnumber, fake => fake.Random.Int())
			.RuleFor(e => e.YomiName, fake => fake.Lorem.Word());
			return faker.Generate();
		}
		#endregion
	}
}

