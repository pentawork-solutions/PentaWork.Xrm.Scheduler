using Bogus;
using System;
using FakeXrmEasy;
using System.Collections.Generic;
using PentaWork.Xrm.Scheduler.Proxies.Entities;

namespace PentaWork.Xrm.Scheduler.Tests.Fake
{
	public static class FakeBusinessUnit
	{	
		#region FakeRelationships
		public static class Relationships 
		{
			/// <summary>1:N BulkDeleteOperation_BusinessUnit</summary>
			public static readonly XrmFakedRelationship BulkDeleteOperationBusinessUnit = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "businessunitid",
					Entity2Attribute = "owningbusinessunit",
					Entity1LogicalName = "businessunit",
					Entity2LogicalName = "bulkdeleteoperation",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N business_unit_accounts</summary>
			public static readonly XrmFakedRelationship BusinessUnitAccounts = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "businessunitid",
					Entity2Attribute = "owningbusinessunit",
					Entity1LogicalName = "businessunit",
					Entity2LogicalName = "account",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N business_unit_actioncards</summary>
			public static readonly XrmFakedRelationship BusinessUnitActioncards = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "businessunitid",
					Entity2Attribute = "owningbusinessunit",
					Entity1LogicalName = "businessunit",
					Entity2LogicalName = "actioncard",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N business_unit_activitymonitor</summary>
			public static readonly XrmFakedRelationship BusinessUnitActivitymonitor = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "businessunitid",
					Entity2Attribute = "owningbusinessunit",
					Entity1LogicalName = "businessunit",
					Entity2LogicalName = "activitymonitor",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N business_unit_activitypointer</summary>
			public static readonly XrmFakedRelationship BusinessUnitActivitypointer = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "businessunitid",
					Entity2Attribute = "owningbusinessunit",
					Entity1LogicalName = "businessunit",
					Entity2LogicalName = "activitypointer",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N business_unit_adminsettingsentity</summary>
			public static readonly XrmFakedRelationship BusinessUnitAdminsettingsentity = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "businessunitid",
					Entity2Attribute = "owningbusinessunit",
					Entity1LogicalName = "businessunit",
					Entity2LogicalName = "adminsettingsentity",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N business_unit_annotations</summary>
			public static readonly XrmFakedRelationship BusinessUnitAnnotations = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "businessunitid",
					Entity2Attribute = "owningbusinessunit",
					Entity1LogicalName = "businessunit",
					Entity2LogicalName = "annotation",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N business_unit_appointment_activities</summary>
			public static readonly XrmFakedRelationship BusinessUnitAppointmentActivities = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "businessunitid",
					Entity2Attribute = "owningbusinessunit",
					Entity1LogicalName = "businessunit",
					Entity2LogicalName = "appointment",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N business_unit_asyncoperation</summary>
			public static readonly XrmFakedRelationship BusinessUnitAsyncoperation = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "businessunitid",
					Entity2Attribute = "owningbusinessunit",
					Entity1LogicalName = "businessunit",
					Entity2LogicalName = "asyncoperation",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N business_unit_bookableresource</summary>
			public static readonly XrmFakedRelationship BusinessUnitBookableresource = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "businessunitid",
					Entity2Attribute = "owningbusinessunit",
					Entity1LogicalName = "businessunit",
					Entity2LogicalName = "bookableresource",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N business_unit_bookableresourcebooking</summary>
			public static readonly XrmFakedRelationship BusinessUnitBookableresourcebooking = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "businessunitid",
					Entity2Attribute = "owningbusinessunit",
					Entity1LogicalName = "businessunit",
					Entity2LogicalName = "bookableresourcebooking",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N business_unit_bookableresourcebookingheader</summary>
			public static readonly XrmFakedRelationship BusinessUnitBookableresourcebookingheader = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "businessunitid",
					Entity2Attribute = "owningbusinessunit",
					Entity1LogicalName = "businessunit",
					Entity2LogicalName = "bookableresourcebookingheader",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N business_unit_bookableresourcecategory</summary>
			public static readonly XrmFakedRelationship BusinessUnitBookableresourcecategory = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "businessunitid",
					Entity2Attribute = "owningbusinessunit",
					Entity1LogicalName = "businessunit",
					Entity2LogicalName = "bookableresourcecategory",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N business_unit_bookableresourcecategoryassn</summary>
			public static readonly XrmFakedRelationship BusinessUnitBookableresourcecategoryassn = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "businessunitid",
					Entity2Attribute = "owningbusinessunit",
					Entity1LogicalName = "businessunit",
					Entity2LogicalName = "bookableresourcecategoryassn",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N business_unit_bookableresourcecharacteristic</summary>
			public static readonly XrmFakedRelationship BusinessUnitBookableresourcecharacteristic = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "businessunitid",
					Entity2Attribute = "owningbusinessunit",
					Entity1LogicalName = "businessunit",
					Entity2LogicalName = "bookableresourcecharacteristic",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N business_unit_bookableresourcegroup</summary>
			public static readonly XrmFakedRelationship BusinessUnitBookableresourcegroup = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "businessunitid",
					Entity2Attribute = "owningbusinessunit",
					Entity1LogicalName = "businessunit",
					Entity2LogicalName = "bookableresourcegroup",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N business_unit_bookingstatus</summary>
			public static readonly XrmFakedRelationship BusinessUnitBookingstatus = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "businessunitid",
					Entity2Attribute = "owningbusinessunit",
					Entity1LogicalName = "businessunit",
					Entity2LogicalName = "bookingstatus",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N business_unit_bot</summary>
			public static readonly XrmFakedRelationship BusinessUnitBot = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "businessunitid",
					Entity2Attribute = "owningbusinessunit",
					Entity1LogicalName = "businessunit",
					Entity2LogicalName = "bot",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N business_unit_botcomponent</summary>
			public static readonly XrmFakedRelationship BusinessUnitBotcomponent = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "businessunitid",
					Entity2Attribute = "owningbusinessunit",
					Entity1LogicalName = "businessunit",
					Entity2LogicalName = "botcomponent",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N business_unit_BulkOperation_activities</summary>
			public static readonly XrmFakedRelationship BusinessUnitBulkOperationActivities = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "businessunitid",
					Entity2Attribute = "owningbusinessunit",
					Entity1LogicalName = "businessunit",
					Entity2LogicalName = "bulkoperation",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N business_unit_calendars</summary>
			public static readonly XrmFakedRelationship BusinessUnitCalendars = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "businessunitid",
					Entity2Attribute = "businessunitid",
					Entity1LogicalName = "businessunit",
					Entity2LogicalName = "calendar",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N business_unit_campaignactivity_activities</summary>
			public static readonly XrmFakedRelationship BusinessUnitCampaignactivityActivities = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "businessunitid",
					Entity2Attribute = "owningbusinessunit",
					Entity1LogicalName = "businessunit",
					Entity2LogicalName = "campaignactivity",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N business_unit_campaignresponse_activities</summary>
			public static readonly XrmFakedRelationship BusinessUnitCampaignresponseActivities = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "businessunitid",
					Entity2Attribute = "owningbusinessunit",
					Entity1LogicalName = "businessunit",
					Entity2LogicalName = "campaignresponse",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N business_unit_category</summary>
			public static readonly XrmFakedRelationship BusinessUnitCategory = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "businessunitid",
					Entity2Attribute = "owningbusinessunit",
					Entity1LogicalName = "businessunit",
					Entity2LogicalName = "category",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N business_unit_characteristic</summary>
			public static readonly XrmFakedRelationship BusinessUnitCharacteristic = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "businessunitid",
					Entity2Attribute = "owningbusinessunit",
					Entity1LogicalName = "businessunit",
					Entity2LogicalName = "characteristic",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N business_unit_connectionreference</summary>
			public static readonly XrmFakedRelationship BusinessUnitConnectionreference = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "businessunitid",
					Entity2Attribute = "owningbusinessunit",
					Entity1LogicalName = "businessunit",
					Entity2LogicalName = "connectionreference",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N business_unit_connections</summary>
			public static readonly XrmFakedRelationship BusinessUnitConnections = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "businessunitid",
					Entity2Attribute = "owningbusinessunit",
					Entity1LogicalName = "businessunit",
					Entity2LogicalName = "connection",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N business_unit_connector</summary>
			public static readonly XrmFakedRelationship BusinessUnitConnector = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "businessunitid",
					Entity2Attribute = "owningbusinessunit",
					Entity1LogicalName = "businessunit",
					Entity2LogicalName = "connector",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N business_unit_constraint_based_groups</summary>
			public static readonly XrmFakedRelationship BusinessUnitConstraintBasedGroups = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "businessunitid",
					Entity2Attribute = "businessunitid",
					Entity1LogicalName = "businessunit",
					Entity2LogicalName = "constraintbasedgroup",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N business_unit_contacts</summary>
			public static readonly XrmFakedRelationship BusinessUnitContacts = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "businessunitid",
					Entity2Attribute = "owningbusinessunit",
					Entity1LogicalName = "businessunit",
					Entity2LogicalName = "contact",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N business_unit_conversationtranscript</summary>
			public static readonly XrmFakedRelationship BusinessUnitConversationtranscript = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "businessunitid",
					Entity2Attribute = "owningbusinessunit",
					Entity1LogicalName = "businessunit",
					Entity2LogicalName = "conversationtranscript",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N business_unit_customapi</summary>
			public static readonly XrmFakedRelationship BusinessUnitCustomapi = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "businessunitid",
					Entity2Attribute = "owningbusinessunit",
					Entity1LogicalName = "businessunit",
					Entity2LogicalName = "customapi",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N business_unit_customapirequestparameter</summary>
			public static readonly XrmFakedRelationship BusinessUnitCustomapirequestparameter = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "businessunitid",
					Entity2Attribute = "owningbusinessunit",
					Entity1LogicalName = "businessunit",
					Entity2LogicalName = "customapirequestparameter",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N business_unit_customapiresponseproperty</summary>
			public static readonly XrmFakedRelationship BusinessUnitCustomapiresponseproperty = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "businessunitid",
					Entity2Attribute = "owningbusinessunit",
					Entity1LogicalName = "businessunit",
					Entity2LogicalName = "customapiresponseproperty",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N business_unit_datalakefolder</summary>
			public static readonly XrmFakedRelationship BusinessUnitDatalakefolder = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "businessunitid",
					Entity2Attribute = "owningbusinessunit",
					Entity1LogicalName = "businessunit",
					Entity2LogicalName = "datalakefolder",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N business_unit_datalakefolderpermission</summary>
			public static readonly XrmFakedRelationship BusinessUnitDatalakefolderpermission = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "businessunitid",
					Entity2Attribute = "owningbusinessunit",
					Entity1LogicalName = "businessunit",
					Entity2LogicalName = "datalakefolderpermission",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N business_unit_dynamicproperyinstance</summary>
			public static readonly XrmFakedRelationship BusinessUnitDynamicproperyinstance = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "businessunitid",
					Entity2Attribute = "owningbusinessunit",
					Entity1LogicalName = "businessunit",
					Entity2LogicalName = "dynamicpropertyinstance",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N business_unit_email_activities</summary>
			public static readonly XrmFakedRelationship BusinessUnitEmailActivities = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "businessunitid",
					Entity2Attribute = "owningbusinessunit",
					Entity1LogicalName = "businessunit",
					Entity2LogicalName = "email",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N business_unit_emailserverprofile</summary>
			public static readonly XrmFakedRelationship BusinessUnitEmailserverprofile = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "businessunitid",
					Entity2Attribute = "owningbusinessunit",
					Entity1LogicalName = "businessunit",
					Entity2LogicalName = "emailserverprofile",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N business_unit_entitlement</summary>
			public static readonly XrmFakedRelationship BusinessUnitEntitlement = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "businessunitid",
					Entity2Attribute = "owningbusinessunit",
					Entity1LogicalName = "businessunit",
					Entity2LogicalName = "entitlement",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N business_unit_entitlemententityallocationtypemapping</summary>
			public static readonly XrmFakedRelationship BusinessUnitEntitlemententityallocationtypemapping = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "businessunitid",
					Entity2Attribute = "owningbusinessunit",
					Entity1LogicalName = "businessunit",
					Entity2LogicalName = "entitlemententityallocationtypemapping",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N business_unit_environmentvariabledefinition</summary>
			public static readonly XrmFakedRelationship BusinessUnitEnvironmentvariabledefinition = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "businessunitid",
					Entity2Attribute = "owningbusinessunit",
					Entity1LogicalName = "businessunit",
					Entity2LogicalName = "environmentvariabledefinition",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N business_unit_environmentvariablevalue</summary>
			public static readonly XrmFakedRelationship BusinessUnitEnvironmentvariablevalue = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "businessunitid",
					Entity2Attribute = "owningbusinessunit",
					Entity1LogicalName = "businessunit",
					Entity2LogicalName = "environmentvariablevalue",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N business_unit_equipment</summary>
			public static readonly XrmFakedRelationship BusinessUnitEquipment = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "businessunitid",
					Entity2Attribute = "businessunitid",
					Entity1LogicalName = "businessunit",
					Entity2LogicalName = "equipment",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N business_unit_exchangesyncidmapping</summary>
			public static readonly XrmFakedRelationship BusinessUnitExchangesyncidmapping = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "businessunitid",
					Entity2Attribute = "owningbusinessunit",
					Entity1LogicalName = "businessunit",
					Entity2LogicalName = "exchangesyncidmapping",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N business_unit_exportsolutionupload</summary>
			public static readonly XrmFakedRelationship BusinessUnitExportsolutionupload = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "businessunitid",
					Entity2Attribute = "owningbusinessunit",
					Entity1LogicalName = "businessunit",
					Entity2LogicalName = "exportsolutionupload",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N business_unit_fax_activities</summary>
			public static readonly XrmFakedRelationship BusinessUnitFaxActivities = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "businessunitid",
					Entity2Attribute = "owningbusinessunit",
					Entity1LogicalName = "businessunit",
					Entity2LogicalName = "fax",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N business_unit_feedback</summary>
			public static readonly XrmFakedRelationship BusinessUnitFeedback = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "businessunitid",
					Entity2Attribute = "owningbusinessunit",
					Entity1LogicalName = "businessunit",
					Entity2LogicalName = "feedback",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N business_unit_flowsession</summary>
			public static readonly XrmFakedRelationship BusinessUnitFlowsession = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "businessunitid",
					Entity2Attribute = "owningbusinessunit",
					Entity1LogicalName = "businessunit",
					Entity2LogicalName = "flowsession",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N business_unit_goal</summary>
			public static readonly XrmFakedRelationship BusinessUnitGoal = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "businessunitid",
					Entity2Attribute = "owningbusinessunit",
					Entity1LogicalName = "businessunit",
					Entity2LogicalName = "goal",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N business_unit_goalrollupquery</summary>
			public static readonly XrmFakedRelationship BusinessUnitGoalrollupquery = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "businessunitid",
					Entity2Attribute = "owningbusinessunit",
					Entity1LogicalName = "businessunit",
					Entity2LogicalName = "goalrollupquery",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N business_unit_incident_resolution_activities</summary>
			public static readonly XrmFakedRelationship BusinessUnitIncidentResolutionActivities = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "businessunitid",
					Entity2Attribute = "owningbusinessunit",
					Entity1LogicalName = "businessunit",
					Entity2LogicalName = "incidentresolution",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N business_unit_incidents</summary>
			public static readonly XrmFakedRelationship BusinessUnitIncidents = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "businessunitid",
					Entity2Attribute = "owningbusinessunit",
					Entity1LogicalName = "businessunit",
					Entity2LogicalName = "incident",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N business_unit_interactionforemail</summary>
			public static readonly XrmFakedRelationship BusinessUnitInteractionforemail = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "businessunitid",
					Entity2Attribute = "owningbusinessunit",
					Entity1LogicalName = "businessunit",
					Entity2LogicalName = "interactionforemail",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N business_unit_invoices</summary>
			public static readonly XrmFakedRelationship BusinessUnitInvoices = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "businessunitid",
					Entity2Attribute = "owningbusinessunit",
					Entity1LogicalName = "businessunit",
					Entity2LogicalName = "invoice",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N business_unit_knowledgearticle</summary>
			public static readonly XrmFakedRelationship BusinessUnitKnowledgearticle = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "businessunitid",
					Entity2Attribute = "owningbusinessunit",
					Entity1LogicalName = "businessunit",
					Entity2LogicalName = "knowledgearticle",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N business_unit_leads</summary>
			public static readonly XrmFakedRelationship BusinessUnitLeads = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "businessunitid",
					Entity2Attribute = "owningbusinessunit",
					Entity1LogicalName = "businessunit",
					Entity2LogicalName = "lead",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N business_unit_letter_activities</summary>
			public static readonly XrmFakedRelationship BusinessUnitLetterActivities = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "businessunitid",
					Entity2Attribute = "owningbusinessunit",
					Entity1LogicalName = "businessunit",
					Entity2LogicalName = "letter",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N business_unit_list</summary>
			public static readonly XrmFakedRelationship BusinessUnitList = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "businessunitid",
					Entity2Attribute = "owningbusinessunit",
					Entity1LogicalName = "businessunit",
					Entity2LogicalName = "list",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N business_unit_listoperation</summary>
			public static readonly XrmFakedRelationship BusinessUnitListoperation = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "businessunitid",
					Entity2Attribute = "owningbusinessunit",
					Entity1LogicalName = "businessunit",
					Entity2LogicalName = "listoperation",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N business_unit_mailbox</summary>
			public static readonly XrmFakedRelationship BusinessUnitMailbox = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "businessunitid",
					Entity2Attribute = "owningbusinessunit",
					Entity1LogicalName = "businessunit",
					Entity2LogicalName = "mailbox",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N business_unit_mailmergetemplates</summary>
			public static readonly XrmFakedRelationship BusinessUnitMailmergetemplates = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "businessunitid",
					Entity2Attribute = "owningbusinessunit",
					Entity1LogicalName = "businessunit",
					Entity2LogicalName = "mailmergetemplate",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N business_unit_msdyn_actioncardregarding</summary>
			public static readonly XrmFakedRelationship BusinessUnitMsdynActioncardregarding = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "businessunitid",
					Entity2Attribute = "owningbusinessunit",
					Entity1LogicalName = "businessunit",
					Entity2LogicalName = "msdyn_actioncardregarding",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N business_unit_msdyn_actioncardrolesetting</summary>
			public static readonly XrmFakedRelationship BusinessUnitMsdynActioncardrolesetting = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "businessunitid",
					Entity2Attribute = "owningbusinessunit",
					Entity1LogicalName = "businessunit",
					Entity2LogicalName = "msdyn_actioncardrolesetting",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N business_unit_msdyn_aibdataset</summary>
			public static readonly XrmFakedRelationship BusinessUnitMsdynAibdataset = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "businessunitid",
					Entity2Attribute = "owningbusinessunit",
					Entity1LogicalName = "businessunit",
					Entity2LogicalName = "msdyn_aibdataset",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N business_unit_msdyn_aibdatasetfile</summary>
			public static readonly XrmFakedRelationship BusinessUnitMsdynAibdatasetfile = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "businessunitid",
					Entity2Attribute = "owningbusinessunit",
					Entity1LogicalName = "businessunit",
					Entity2LogicalName = "msdyn_aibdatasetfile",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N business_unit_msdyn_aibdatasetrecord</summary>
			public static readonly XrmFakedRelationship BusinessUnitMsdynAibdatasetrecord = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "businessunitid",
					Entity2Attribute = "owningbusinessunit",
					Entity1LogicalName = "businessunit",
					Entity2LogicalName = "msdyn_aibdatasetrecord",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N business_unit_msdyn_aibdatasetscontainer</summary>
			public static readonly XrmFakedRelationship BusinessUnitMsdynAibdatasetscontainer = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "businessunitid",
					Entity2Attribute = "owningbusinessunit",
					Entity1LogicalName = "businessunit",
					Entity2LogicalName = "msdyn_aibdatasetscontainer",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N business_unit_msdyn_aibfile</summary>
			public static readonly XrmFakedRelationship BusinessUnitMsdynAibfile = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "businessunitid",
					Entity2Attribute = "owningbusinessunit",
					Entity1LogicalName = "businessunit",
					Entity2LogicalName = "msdyn_aibfile",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N business_unit_msdyn_aibfileattacheddata</summary>
			public static readonly XrmFakedRelationship BusinessUnitMsdynAibfileattacheddata = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "businessunitid",
					Entity2Attribute = "owningbusinessunit",
					Entity1LogicalName = "businessunit",
					Entity2LogicalName = "msdyn_aibfileattacheddata",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N business_unit_msdyn_aiconfiguration</summary>
			public static readonly XrmFakedRelationship BusinessUnitMsdynAiconfiguration = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "businessunitid",
					Entity2Attribute = "owningbusinessunit",
					Entity1LogicalName = "businessunit",
					Entity2LogicalName = "msdyn_aiconfiguration",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N business_unit_msdyn_aifptrainingdocument</summary>
			public static readonly XrmFakedRelationship BusinessUnitMsdynAifptrainingdocument = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "businessunitid",
					Entity2Attribute = "owningbusinessunit",
					Entity1LogicalName = "businessunit",
					Entity2LogicalName = "msdyn_aifptrainingdocument",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N business_unit_msdyn_aimodel</summary>
			public static readonly XrmFakedRelationship BusinessUnitMsdynAimodel = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "businessunitid",
					Entity2Attribute = "owningbusinessunit",
					Entity1LogicalName = "businessunit",
					Entity2LogicalName = "msdyn_aimodel",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N business_unit_msdyn_aiodimage</summary>
			public static readonly XrmFakedRelationship BusinessUnitMsdynAiodimage = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "businessunitid",
					Entity2Attribute = "owningbusinessunit",
					Entity1LogicalName = "businessunit",
					Entity2LogicalName = "msdyn_aiodimage",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N business_unit_msdyn_aiodlabel</summary>
			public static readonly XrmFakedRelationship BusinessUnitMsdynAiodlabel = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "businessunitid",
					Entity2Attribute = "owningbusinessunit",
					Entity1LogicalName = "businessunit",
					Entity2LogicalName = "msdyn_aiodlabel",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N business_unit_msdyn_aiodtrainingboundingbox</summary>
			public static readonly XrmFakedRelationship BusinessUnitMsdynAiodtrainingboundingbox = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "businessunitid",
					Entity2Attribute = "owningbusinessunit",
					Entity1LogicalName = "businessunit",
					Entity2LogicalName = "msdyn_aiodtrainingboundingbox",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N business_unit_msdyn_aiodtrainingimage</summary>
			public static readonly XrmFakedRelationship BusinessUnitMsdynAiodtrainingimage = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "businessunitid",
					Entity2Attribute = "owningbusinessunit",
					Entity1LogicalName = "businessunit",
					Entity2LogicalName = "msdyn_aiodtrainingimage",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N business_unit_msdyn_aitemplate</summary>
			public static readonly XrmFakedRelationship BusinessUnitMsdynAitemplate = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "businessunitid",
					Entity2Attribute = "owningbusinessunit",
					Entity1LogicalName = "businessunit",
					Entity2LogicalName = "msdyn_aitemplate",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N business_unit_msdyn_autocapturerule</summary>
			public static readonly XrmFakedRelationship BusinessUnitMsdynAutocapturerule = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "businessunitid",
					Entity2Attribute = "owningbusinessunit",
					Entity1LogicalName = "businessunit",
					Entity2LogicalName = "msdyn_autocapturerule",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N business_unit_msdyn_autocapturesettings</summary>
			public static readonly XrmFakedRelationship BusinessUnitMsdynAutocapturesettings = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "businessunitid",
					Entity2Attribute = "owningbusinessunit",
					Entity1LogicalName = "businessunit",
					Entity2LogicalName = "msdyn_autocapturesettings",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N business_unit_msdyn_callablecontext</summary>
			public static readonly XrmFakedRelationship BusinessUnitMsdynCallablecontext = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "businessunitid",
					Entity2Attribute = "owningbusinessunit",
					Entity1LogicalName = "businessunit",
					Entity2LogicalName = "msdyn_callablecontext",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N business_unit_msdyn_entityrankingrule</summary>
			public static readonly XrmFakedRelationship BusinessUnitMsdynEntityrankingrule = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "businessunitid",
					Entity2Attribute = "owningbusinessunit",
					Entity1LogicalName = "businessunit",
					Entity2LogicalName = "msdyn_entityrankingrule",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N business_unit_msdyn_federatedarticle</summary>
			public static readonly XrmFakedRelationship BusinessUnitMsdynFederatedarticle = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "businessunitid",
					Entity2Attribute = "owningbusinessunit",
					Entity1LogicalName = "businessunit",
					Entity2LogicalName = "msdyn_federatedarticle",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N business_unit_msdyn_flowcardtype</summary>
			public static readonly XrmFakedRelationship BusinessUnitMsdynFlowcardtype = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "businessunitid",
					Entity2Attribute = "owningbusinessunit",
					Entity1LogicalName = "businessunit",
					Entity2LogicalName = "msdyn_flowcardtype",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N business_unit_msdyn_icebreakersconfig</summary>
			public static readonly XrmFakedRelationship BusinessUnitMsdynIcebreakersconfig = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "businessunitid",
					Entity2Attribute = "owningbusinessunit",
					Entity1LogicalName = "businessunit",
					Entity2LogicalName = "msdyn_icebreakersconfig",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N business_unit_msdyn_kmfederatedsearchconfig</summary>
			public static readonly XrmFakedRelationship BusinessUnitMsdynKmfederatedsearchconfig = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "businessunitid",
					Entity2Attribute = "owningbusinessunit",
					Entity1LogicalName = "businessunit",
					Entity2LogicalName = "msdyn_kmfederatedsearchconfig",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N business_unit_msdyn_knowledgearticleimage</summary>
			public static readonly XrmFakedRelationship BusinessUnitMsdynKnowledgearticleimage = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "businessunitid",
					Entity2Attribute = "owningbusinessunit",
					Entity1LogicalName = "businessunit",
					Entity2LogicalName = "msdyn_knowledgearticleimage",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N business_unit_msdyn_knowledgearticletemplate</summary>
			public static readonly XrmFakedRelationship BusinessUnitMsdynKnowledgearticletemplate = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "businessunitid",
					Entity2Attribute = "owningbusinessunit",
					Entity1LogicalName = "businessunit",
					Entity2LogicalName = "msdyn_knowledgearticletemplate",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N business_unit_msdyn_knowledgeinteractioninsight</summary>
			public static readonly XrmFakedRelationship BusinessUnitMsdynKnowledgeinteractioninsight = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "businessunitid",
					Entity2Attribute = "owningbusinessunit",
					Entity1LogicalName = "businessunit",
					Entity2LogicalName = "msdyn_knowledgeinteractioninsight",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N business_unit_msdyn_knowledgesearchinsight</summary>
			public static readonly XrmFakedRelationship BusinessUnitMsdynKnowledgesearchinsight = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "businessunitid",
					Entity2Attribute = "owningbusinessunit",
					Entity1LogicalName = "businessunit",
					Entity2LogicalName = "msdyn_knowledgesearchinsight",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N business_unit_msdyn_msteamssetting</summary>
			public static readonly XrmFakedRelationship BusinessUnitMsdynMsteamssetting = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "businessunitid",
					Entity2Attribute = "owningbusinessunit",
					Entity1LogicalName = "businessunit",
					Entity2LogicalName = "msdyn_msteamssetting",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N business_unit_msdyn_notesanalysisconfig</summary>
			public static readonly XrmFakedRelationship BusinessUnitMsdynNotesanalysisconfig = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "businessunitid",
					Entity2Attribute = "owningbusinessunit",
					Entity1LogicalName = "businessunit",
					Entity2LogicalName = "msdyn_notesanalysisconfig",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N business_unit_msdyn_playbookactivity</summary>
			public static readonly XrmFakedRelationship BusinessUnitMsdynPlaybookactivity = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "businessunitid",
					Entity2Attribute = "owningbusinessunit",
					Entity1LogicalName = "businessunit",
					Entity2LogicalName = "msdyn_playbookactivity",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N business_unit_msdyn_playbookactivityattribute</summary>
			public static readonly XrmFakedRelationship BusinessUnitMsdynPlaybookactivityattribute = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "businessunitid",
					Entity2Attribute = "owningbusinessunit",
					Entity1LogicalName = "businessunit",
					Entity2LogicalName = "msdyn_playbookactivityattribute",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N business_unit_msdyn_playbookcategory</summary>
			public static readonly XrmFakedRelationship BusinessUnitMsdynPlaybookcategory = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "businessunitid",
					Entity2Attribute = "owningbusinessunit",
					Entity1LogicalName = "businessunit",
					Entity2LogicalName = "msdyn_playbookcategory",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N business_unit_msdyn_playbookinstance</summary>
			public static readonly XrmFakedRelationship BusinessUnitMsdynPlaybookinstance = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "businessunitid",
					Entity2Attribute = "owningbusinessunit",
					Entity1LogicalName = "businessunit",
					Entity2LogicalName = "msdyn_playbookinstance",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N business_unit_msdyn_playbooktemplate</summary>
			public static readonly XrmFakedRelationship BusinessUnitMsdynPlaybooktemplate = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "businessunitid",
					Entity2Attribute = "owningbusinessunit",
					Entity1LogicalName = "businessunit",
					Entity2LogicalName = "msdyn_playbooktemplate",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N business_unit_msdyn_postalbum</summary>
			public static readonly XrmFakedRelationship BusinessUnitMsdynPostalbum = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "businessunitid",
					Entity2Attribute = "owningbusinessunit",
					Entity1LogicalName = "businessunit",
					Entity2LogicalName = "msdyn_postalbum",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N business_unit_msdyn_relationshipinsightsunifiedconfig</summary>
			public static readonly XrmFakedRelationship BusinessUnitMsdynRelationshipinsightsunifiedconfig = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "businessunitid",
					Entity2Attribute = "owningbusinessunit",
					Entity1LogicalName = "businessunit",
					Entity2LogicalName = "msdyn_relationshipinsightsunifiedconfig",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N business_unit_msdyn_richtextfile</summary>
			public static readonly XrmFakedRelationship BusinessUnitMsdynRichtextfile = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "businessunitid",
					Entity2Attribute = "owningbusinessunit",
					Entity1LogicalName = "businessunit",
					Entity2LogicalName = "msdyn_richtextfile",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N business_unit_msdyn_salesinsightssettings</summary>
			public static readonly XrmFakedRelationship BusinessUnitMsdynSalesinsightssettings = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "businessunitid",
					Entity2Attribute = "owningbusinessunit",
					Entity1LogicalName = "businessunit",
					Entity2LogicalName = "msdyn_salesinsightssettings",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N business_unit_msdyn_siconfig</summary>
			public static readonly XrmFakedRelationship BusinessUnitMsdynSiconfig = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "businessunitid",
					Entity2Attribute = "owningbusinessunit",
					Entity1LogicalName = "businessunit",
					Entity2LogicalName = "msdyn_siconfig",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N business_unit_msdyn_untrackedappointment</summary>
			public static readonly XrmFakedRelationship BusinessUnitMsdynUntrackedappointment = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "businessunitid",
					Entity2Attribute = "owningbusinessunit",
					Entity1LogicalName = "businessunit",
					Entity2LogicalName = "msdyn_untrackedappointment",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N business_unit_msdyn_wallsavedqueryusersettings</summary>
			public static readonly XrmFakedRelationship BusinessUnitMsdynWallsavedqueryusersettings = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "businessunitid",
					Entity2Attribute = "owningbusinessunit",
					Entity1LogicalName = "businessunit",
					Entity2LogicalName = "msdyn_wallsavedqueryusersettings",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N business_unit_msdynce_botcontent</summary>
			public static readonly XrmFakedRelationship BusinessUnitMsdynceBotcontent = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "businessunitid",
					Entity2Attribute = "owningbusinessunit",
					Entity1LogicalName = "businessunit",
					Entity2LogicalName = "msdynce_botcontent",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N business_unit_opportunities</summary>
			public static readonly XrmFakedRelationship BusinessUnitOpportunities = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "businessunitid",
					Entity2Attribute = "owningbusinessunit",
					Entity1LogicalName = "businessunit",
					Entity2LogicalName = "opportunity",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N business_unit_opportunity_close_activities</summary>
			public static readonly XrmFakedRelationship BusinessUnitOpportunityCloseActivities = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "businessunitid",
					Entity2Attribute = "owningbusinessunit",
					Entity1LogicalName = "businessunit",
					Entity2LogicalName = "opportunityclose",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N business_unit_order_close_activities</summary>
			public static readonly XrmFakedRelationship BusinessUnitOrderCloseActivities = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "businessunitid",
					Entity2Attribute = "owningbusinessunit",
					Entity1LogicalName = "businessunit",
					Entity2LogicalName = "orderclose",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N business_unit_orders</summary>
			public static readonly XrmFakedRelationship BusinessUnitOrders = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "businessunitid",
					Entity2Attribute = "owningbusinessunit",
					Entity1LogicalName = "businessunit",
					Entity2LogicalName = "salesorder",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N business_unit_parent_business_unit</summary>
			public static readonly XrmFakedRelationship BusinessUnitParentBusinessUnit = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "businessunitid",
					Entity2Attribute = "parentbusinessunitid",
					Entity1LogicalName = "businessunit",
					Entity2LogicalName = "businessunit",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N business_unit_personaldocumenttemplates</summary>
			public static readonly XrmFakedRelationship BusinessUnitPersonaldocumenttemplates = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "businessunitid",
					Entity2Attribute = "owningbusinessunit",
					Entity1LogicalName = "businessunit",
					Entity2LogicalName = "personaldocumenttemplate",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N business_unit_phone_call_activities</summary>
			public static readonly XrmFakedRelationship BusinessUnitPhoneCallActivities = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "businessunitid",
					Entity2Attribute = "owningbusinessunit",
					Entity1LogicalName = "businessunit",
					Entity2LogicalName = "phonecall",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N business_unit_postfollows</summary>
			public static readonly XrmFakedRelationship BusinessUnitPostfollows = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "businessunitid",
					Entity2Attribute = "owningbusinessunit",
					Entity1LogicalName = "businessunit",
					Entity2LogicalName = "postfollow",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N business_unit_processstageparameter</summary>
			public static readonly XrmFakedRelationship BusinessUnitProcessstageparameter = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "businessunitid",
					Entity2Attribute = "owningbusinessunit",
					Entity1LogicalName = "businessunit",
					Entity2LogicalName = "processstageparameter",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N business_unit_pw_penta_schedule_run</summary>
			public static readonly XrmFakedRelationship BusinessUnitPwPentaScheduleRun = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "businessunitid",
					Entity2Attribute = "owningbusinessunit",
					Entity1LogicalName = "businessunit",
					Entity2LogicalName = "pw_penta_schedule_run",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N business_unit_pw_schedule</summary>
			public static readonly XrmFakedRelationship BusinessUnitPwSchedule = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "businessunitid",
					Entity2Attribute = "owningbusinessunit",
					Entity1LogicalName = "businessunit",
					Entity2LogicalName = "pw_schedule",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N business_unit_queues</summary>
			public static readonly XrmFakedRelationship BusinessUnitQueues = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "businessunitid",
					Entity2Attribute = "businessunitid",
					Entity1LogicalName = "businessunit",
					Entity2LogicalName = "queue",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N business_unit_queues2</summary>
			public static readonly XrmFakedRelationship BusinessUnitQueues2 = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "businessunitid",
					Entity2Attribute = "owningbusinessunit",
					Entity1LogicalName = "businessunit",
					Entity2LogicalName = "queue",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N business_unit_quote_close_activities</summary>
			public static readonly XrmFakedRelationship BusinessUnitQuoteCloseActivities = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "businessunitid",
					Entity2Attribute = "owningbusinessunit",
					Entity1LogicalName = "businessunit",
					Entity2LogicalName = "quoteclose",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N business_unit_quotes</summary>
			public static readonly XrmFakedRelationship BusinessUnitQuotes = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "businessunitid",
					Entity2Attribute = "owningbusinessunit",
					Entity1LogicalName = "businessunit",
					Entity2LogicalName = "quote",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N business_unit_ratingmodel</summary>
			public static readonly XrmFakedRelationship BusinessUnitRatingmodel = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "businessunitid",
					Entity2Attribute = "owningbusinessunit",
					Entity1LogicalName = "businessunit",
					Entity2LogicalName = "ratingmodel",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N business_unit_ratingvalue</summary>
			public static readonly XrmFakedRelationship BusinessUnitRatingvalue = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "businessunitid",
					Entity2Attribute = "owningbusinessunit",
					Entity1LogicalName = "businessunit",
					Entity2LogicalName = "ratingvalue",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N business_unit_recurrencerule</summary>
			public static readonly XrmFakedRelationship BusinessUnitRecurrencerule = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "businessunitid",
					Entity2Attribute = "owningbusinessunit",
					Entity1LogicalName = "businessunit",
					Entity2LogicalName = "recurrencerule",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N business_unit_recurringappointmentmaster_activities</summary>
			public static readonly XrmFakedRelationship BusinessUnitRecurringappointmentmasterActivities = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "businessunitid",
					Entity2Attribute = "owningbusinessunit",
					Entity1LogicalName = "businessunit",
					Entity2LogicalName = "recurringappointmentmaster",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N business_unit_reports</summary>
			public static readonly XrmFakedRelationship BusinessUnitReports = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "businessunitid",
					Entity2Attribute = "owningbusinessunit",
					Entity1LogicalName = "businessunit",
					Entity2LogicalName = "report",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N business_unit_resource_groups</summary>
			public static readonly XrmFakedRelationship BusinessUnitResourceGroups = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "businessunitid",
					Entity2Attribute = "businessunitid",
					Entity1LogicalName = "businessunit",
					Entity2LogicalName = "resourcegroup",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N business_unit_resource_specs</summary>
			public static readonly XrmFakedRelationship BusinessUnitResourceSpecs = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "businessunitid",
					Entity2Attribute = "businessunitid",
					Entity1LogicalName = "businessunit",
					Entity2LogicalName = "resourcespec",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N business_unit_resources</summary>
			public static readonly XrmFakedRelationship BusinessUnitResources = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "businessunitid",
					Entity2Attribute = "businessunitid",
					Entity1LogicalName = "businessunit",
					Entity2LogicalName = "resource",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N business_unit_roles</summary>
			public static readonly XrmFakedRelationship BusinessUnitRoles = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "businessunitid",
					Entity2Attribute = "businessunitid",
					Entity1LogicalName = "businessunit",
					Entity2LogicalName = "role",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N business_unit_service_appointments</summary>
			public static readonly XrmFakedRelationship BusinessUnitServiceAppointments = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "businessunitid",
					Entity2Attribute = "owningbusinessunit",
					Entity1LogicalName = "businessunit",
					Entity2LogicalName = "serviceappointment",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N business_unit_service_contracts</summary>
			public static readonly XrmFakedRelationship BusinessUnitServiceContracts = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "businessunitid",
					Entity2Attribute = "owningbusinessunit",
					Entity1LogicalName = "businessunit",
					Entity2LogicalName = "contract",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N business_unit_sharepointdocumentlocation</summary>
			public static readonly XrmFakedRelationship BusinessUnitSharepointdocumentlocation = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "businessunitid",
					Entity2Attribute = "owningbusinessunit",
					Entity1LogicalName = "businessunit",
					Entity2LogicalName = "sharepointdocumentlocation",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N business_unit_sharepointsites</summary>
			public static readonly XrmFakedRelationship BusinessUnitSharepointsites = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "businessunitid",
					Entity2Attribute = "owningbusinessunit",
					Entity1LogicalName = "businessunit",
					Entity2LogicalName = "sharepointsite",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N business_unit_slabase</summary>
			public static readonly XrmFakedRelationship BusinessUnitSlabase = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "businessunitid",
					Entity2Attribute = "owningbusinessunit",
					Entity1LogicalName = "businessunit",
					Entity2LogicalName = "sla",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N business_unit_slakpiinstance</summary>
			public static readonly XrmFakedRelationship BusinessUnitSlakpiinstance = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "businessunitid",
					Entity2Attribute = "owningbusinessunit",
					Entity1LogicalName = "businessunit",
					Entity2LogicalName = "slakpiinstance",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N business_unit_socialactivity</summary>
			public static readonly XrmFakedRelationship BusinessUnitSocialactivity = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "businessunitid",
					Entity2Attribute = "owningbusinessunit",
					Entity1LogicalName = "businessunit",
					Entity2LogicalName = "socialactivity",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N business_unit_socialprofiles</summary>
			public static readonly XrmFakedRelationship BusinessUnitSocialprofiles = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "businessunitid",
					Entity2Attribute = "owningbusinessunit",
					Entity1LogicalName = "businessunit",
					Entity2LogicalName = "socialprofile",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N business_unit_stagesolutionupload</summary>
			public static readonly XrmFakedRelationship BusinessUnitStagesolutionupload = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "businessunitid",
					Entity2Attribute = "owningbusinessunit",
					Entity1LogicalName = "businessunit",
					Entity2LogicalName = "stagesolutionupload",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N business_unit_system_users</summary>
			public static readonly XrmFakedRelationship BusinessUnitSystemUsers = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "businessunitid",
					Entity2Attribute = "businessunitid",
					Entity1LogicalName = "businessunit",
					Entity2LogicalName = "systemuser",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N business_unit_task_activities</summary>
			public static readonly XrmFakedRelationship BusinessUnitTaskActivities = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "businessunitid",
					Entity2Attribute = "owningbusinessunit",
					Entity1LogicalName = "businessunit",
					Entity2LogicalName = "task",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N business_unit_teams</summary>
			public static readonly XrmFakedRelationship BusinessUnitTeams = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "businessunitid",
					Entity2Attribute = "businessunitid",
					Entity1LogicalName = "businessunit",
					Entity2LogicalName = "team",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N business_unit_templates</summary>
			public static readonly XrmFakedRelationship BusinessUnitTemplates = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "businessunitid",
					Entity2Attribute = "owningbusinessunit",
					Entity1LogicalName = "businessunit",
					Entity2LogicalName = "template",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N business_unit_user_settings</summary>
			public static readonly XrmFakedRelationship BusinessUnitUserSettings = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "businessunitid",
					Entity2Attribute = "businessunitid",
					Entity1LogicalName = "businessunit",
					Entity2LogicalName = "usersettings",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N business_unit_userform</summary>
			public static readonly XrmFakedRelationship BusinessUnitUserform = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "businessunitid",
					Entity2Attribute = "owningbusinessunit",
					Entity1LogicalName = "businessunit",
					Entity2LogicalName = "userform",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N business_unit_userquery</summary>
			public static readonly XrmFakedRelationship BusinessUnitUserquery = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "businessunitid",
					Entity2Attribute = "owningbusinessunit",
					Entity1LogicalName = "businessunit",
					Entity2LogicalName = "userquery",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N business_unit_userqueryvisualizations</summary>
			public static readonly XrmFakedRelationship BusinessUnitUserqueryvisualizations = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "businessunitid",
					Entity2Attribute = "owningbusinessunit",
					Entity1LogicalName = "businessunit",
					Entity2LogicalName = "userqueryvisualization",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N business_unit_workflow</summary>
			public static readonly XrmFakedRelationship BusinessUnitWorkflow = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "businessunitid",
					Entity2Attribute = "owningbusinessunit",
					Entity1LogicalName = "businessunit",
					Entity2LogicalName = "workflow",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N business_unit_workflowbinary</summary>
			public static readonly XrmFakedRelationship BusinessUnitWorkflowbinary = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "businessunitid",
					Entity2Attribute = "owningbusinessunit",
					Entity1LogicalName = "businessunit",
					Entity2LogicalName = "workflowbinary",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N business_unit_workflowlogs</summary>
			public static readonly XrmFakedRelationship BusinessUnitWorkflowlogs = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "businessunitid",
					Entity2Attribute = "owningbusinessunit",
					Entity1LogicalName = "businessunit",
					Entity2LogicalName = "workflowlog",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N BusinessUnit_AsyncOperations</summary>
			public static readonly XrmFakedRelationship BusinessUnitAsyncOperations = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "businessunitid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "businessunit",
					Entity2LogicalName = "asyncoperation",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N BusinessUnit_BulkDeleteFailures</summary>
			public static readonly XrmFakedRelationship BusinessUnitBulkDeleteFailures = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "businessunitid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "businessunit",
					Entity2LogicalName = "bulkdeletefailure",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N businessunit_callbackregistration</summary>
			public static readonly XrmFakedRelationship BusinessunitCallbackregistration = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "businessunitid",
					Entity2Attribute = "owningbusinessunit",
					Entity1LogicalName = "businessunit",
					Entity2LogicalName = "callbackregistration",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N BusinessUnit_Campaigns</summary>
			public static readonly XrmFakedRelationship BusinessUnitCampaigns = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "businessunitid",
					Entity2Attribute = "owningbusinessunit",
					Entity1LogicalName = "businessunit",
					Entity2LogicalName = "campaign",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N businessunit_canvasapp</summary>
			public static readonly XrmFakedRelationship BusinessunitCanvasapp = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "businessunitid",
					Entity2Attribute = "owningbusinessunit",
					Entity1LogicalName = "businessunit",
					Entity2LogicalName = "canvasapp",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N BusinessUnit_DuplicateRules</summary>
			public static readonly XrmFakedRelationship BusinessUnitDuplicateRules = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "businessunitid",
					Entity2Attribute = "owningbusinessunit",
					Entity1LogicalName = "businessunit",
					Entity2LogicalName = "duplicaterule",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N BusinessUnit_ImportData</summary>
			public static readonly XrmFakedRelationship BusinessUnitImportData = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "businessunitid",
					Entity2Attribute = "owningbusinessunit",
					Entity1LogicalName = "businessunit",
					Entity2LogicalName = "importdata",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N BusinessUnit_ImportFiles</summary>
			public static readonly XrmFakedRelationship BusinessUnitImportFiles = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "businessunitid",
					Entity2Attribute = "owningbusinessunit",
					Entity1LogicalName = "businessunit",
					Entity2LogicalName = "importfile",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N BusinessUnit_ImportLogs</summary>
			public static readonly XrmFakedRelationship BusinessUnitImportLogs = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "businessunitid",
					Entity2Attribute = "owningbusinessunit",
					Entity1LogicalName = "businessunit",
					Entity2LogicalName = "importlog",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N BusinessUnit_ImportMaps</summary>
			public static readonly XrmFakedRelationship BusinessUnitImportMaps = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "businessunitid",
					Entity2Attribute = "owningbusinessunit",
					Entity1LogicalName = "businessunit",
					Entity2LogicalName = "importmap",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N BusinessUnit_Imports</summary>
			public static readonly XrmFakedRelationship BusinessUnitImports = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "businessunitid",
					Entity2Attribute = "owningbusinessunit",
					Entity1LogicalName = "businessunit",
					Entity2LogicalName = "import",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N businessunit_mailboxtrackingfolder</summary>
			public static readonly XrmFakedRelationship BusinessunitMailboxtrackingfolder = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "businessunitid",
					Entity2Attribute = "owningbusinessunit",
					Entity1LogicalName = "businessunit",
					Entity2LogicalName = "mailboxtrackingfolder",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N businessunit_principalobjectattributeaccess</summary>
			public static readonly XrmFakedRelationship BusinessunitPrincipalobjectattributeaccess = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "businessunitid",
					Entity2Attribute = "objectid",
					Entity1LogicalName = "businessunit",
					Entity2LogicalName = "principalobjectattributeaccess",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N BusinessUnit_ProcessSessions</summary>
			public static readonly XrmFakedRelationship BusinessUnitProcessSessions = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "businessunitid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "businessunit",
					Entity2LogicalName = "processsession",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N BusinessUnit_SyncError</summary>
			public static readonly XrmFakedRelationship BusinessUnitSyncError = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "businessunitid",
					Entity2Attribute = "owningbusinessunit",
					Entity1LogicalName = "businessunit",
					Entity2LogicalName = "syncerror",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N BusinessUnit_SyncErrors</summary>
			public static readonly XrmFakedRelationship BusinessUnitSyncErrors = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "businessunitid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "businessunit",
					Entity2LogicalName = "syncerror",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N Owning_businessunit_processsessions</summary>
			public static readonly XrmFakedRelationship OwningBusinessunitProcesssessions = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "businessunitid",
					Entity2Attribute = "owningbusinessunit",
					Entity1LogicalName = "businessunit",
					Entity2LogicalName = "processsession",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

		}
		#endregion

		#region Fake
		public static BusinessUnit Create()
		{
			var faker = new Faker<BusinessUnit>()
			.RuleFor(e => e.Address1Id, fake => Guid.NewGuid())
			.RuleFor(e => e.Address1AddressType, fake => fake.PickRandom<BusinessUnit.eAddress1AddressType>())
			.RuleFor(e => e.BillToCity, fake => fake.Lorem.Word())
			.RuleFor(e => e.BillToCountryRegion, fake => fake.Lorem.Word())
			.RuleFor(e => e.Address1County, fake => fake.Lorem.Word())
			.RuleFor(e => e.Address1Fax, fake => fake.Lorem.Word())
			.RuleFor(e => e.Address1Latitude, fake => fake.Random.Double())
			.RuleFor(e => e.BillToStreet1, fake => fake.Lorem.Word())
			.RuleFor(e => e.BillToStreet2, fake => fake.Lorem.Word())
			.RuleFor(e => e.BillToStreet3, fake => fake.Lorem.Word())
			.RuleFor(e => e.Address1Longitude, fake => fake.Random.Double())
			.RuleFor(e => e.Address1Name, fake => fake.Lorem.Word())
			.RuleFor(e => e.BillToZIPPostalCode, fake => fake.Lorem.Word())
			.RuleFor(e => e.Address1PostOfficeBox, fake => fake.Lorem.Word())
			.RuleFor(e => e.Address1ShippingMethod, fake => fake.PickRandom<BusinessUnit.eAddress1ShippingMethod>())
			.RuleFor(e => e.BillToStateProvince, fake => fake.Lorem.Word())
			.RuleFor(e => e.MainPhone, fake => fake.Lorem.Word())
			.RuleFor(e => e.OtherPhone, fake => fake.Lorem.Word())
			.RuleFor(e => e.Address1Telephone3, fake => fake.Lorem.Word())
			.RuleFor(e => e.Address1UPSZone, fake => fake.Lorem.Word())
			.RuleFor(e => e.Address1UTCOffset, fake => fake.Random.Int())
			.RuleFor(e => e.Address2Id, fake => Guid.NewGuid())
			.RuleFor(e => e.Address2AddressType, fake => fake.PickRandom<BusinessUnit.eAddress2AddressType>())
			.RuleFor(e => e.ShipToCity, fake => fake.Lorem.Word())
			.RuleFor(e => e.ShipToCountryRegion, fake => fake.Lorem.Word())
			.RuleFor(e => e.Address2County, fake => fake.Lorem.Word())
			.RuleFor(e => e.Address2Fax, fake => fake.Lorem.Word())
			.RuleFor(e => e.Address2Latitude, fake => fake.Random.Double())
			.RuleFor(e => e.ShipToStreet1, fake => fake.Lorem.Word())
			.RuleFor(e => e.ShipToStreet2, fake => fake.Lorem.Word())
			.RuleFor(e => e.ShipToStreet3, fake => fake.Lorem.Word())
			.RuleFor(e => e.Address2Longitude, fake => fake.Random.Double())
			.RuleFor(e => e.Address2Name, fake => fake.Lorem.Word())
			.RuleFor(e => e.ShipToZIPPostalCode, fake => fake.Lorem.Word())
			.RuleFor(e => e.Address2PostOfficeBox, fake => fake.Lorem.Word())
			.RuleFor(e => e.Address2ShippingMethod, fake => fake.PickRandom<BusinessUnit.eAddress2ShippingMethod>())
			.RuleFor(e => e.ShipToStateProvince, fake => fake.Lorem.Word())
			.RuleFor(e => e.Address2Telephone1, fake => fake.Lorem.Word())
			.RuleFor(e => e.Address2Telephone2, fake => fake.Lorem.Word())
			.RuleFor(e => e.Address2Telephone3, fake => fake.Lorem.Word())
			.RuleFor(e => e.Address2UPSZone, fake => fake.Lorem.Word())
			.RuleFor(e => e.Address2UTCOffset, fake => fake.Random.Int())
			.RuleFor(e => e.Id, fake => Guid.NewGuid())
			.RuleFor(e => e.CostCenter, fake => fake.Lorem.Word())
			.RuleFor(e => e.Createdbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Createdbyyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.CreatedOn, fake => fake.Date.Soon())
			.RuleFor(e => e.Createdonbehalfbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Createdonbehalfbyyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.CreditLimit, fake => fake.Random.Double())
			.RuleFor(e => e.Description, fake => fake.Lorem.Word())
			.RuleFor(e => e.DisableReason, fake => fake.Lorem.Word())
			.RuleFor(e => e.Division, fake => fake.Lorem.Word())
			.RuleFor(e => e.Email, fake => fake.Lorem.Word())
			.RuleFor(e => e.ExchangeRate, fake => fake.Finance.Amount())
			.RuleFor(e => e.FileAsName, fake => fake.Lorem.Word())
			.RuleFor(e => e.FTPSite, fake => fake.Lorem.Word())
			.RuleFor(e => e.ImportSequenceNumber, fake => fake.Random.Int())
			.RuleFor(e => e.InheritanceMask, fake => fake.Random.Int())
			.RuleFor(e => e.IsDisabled, fake => fake.Random.Bool())
			.RuleFor(e => e.Modifiedbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Modifiedbyyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.ModifiedOn, fake => fake.Date.Soon())
			.RuleFor(e => e.Modifiedonbehalfbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Modifiedonbehalfbyyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.Name, fake => fake.Lorem.Word())
			.RuleFor(e => e.Organizationidname, fake => fake.Lorem.Word())
			.RuleFor(e => e.RecordCreatedOn, fake => fake.Date.Soon())
			.RuleFor(e => e.Parentbusinessunitidname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Picture, fake => fake.Lorem.Word())
			.RuleFor(e => e.StockExchange, fake => fake.Lorem.Word())
			.RuleFor(e => e.TickerSymbol, fake => fake.Lorem.Word())
			.RuleFor(e => e.Transactioncurrencyidname, fake => fake.Lorem.Word())
			.RuleFor(e => e.UsergroupId, fake => Guid.NewGuid())
			.RuleFor(e => e.UTCOffset, fake => fake.Random.Int())
			.RuleFor(e => e.VersionNumber, fake => fake.Random.Int())
			.RuleFor(e => e.Website, fake => fake.Lorem.Word())
			.RuleFor(e => e.WorkflowSuspended, fake => fake.Random.Bool());
			return faker.Generate();
		}
		#endregion
	}
}

