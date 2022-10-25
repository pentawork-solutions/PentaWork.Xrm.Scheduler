using Bogus;
using System;
using FakeXrmEasy;
using System.Collections.Generic;
using PentaWork.Xrm.Scheduler.Proxies.Entities;

namespace PentaWork.Xrm.Scheduler.Tests.Fake
{
	public static class FakeOrganization
	{	
		#region FakeRelationships
		public static class Relationships 
		{
			/// <summary>1:N customcontrol_organization</summary>
			public static readonly XrmFakedRelationship CustomcontrolOrganization = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "organizationid",
					Entity2Attribute = "organizationid",
					Entity1LogicalName = "organization",
					Entity2LogicalName = "customcontrol",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N customcontroldefaultconfig_organization</summary>
			public static readonly XrmFakedRelationship CustomcontroldefaultconfigOrganization = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "organizationid",
					Entity2Attribute = "organizationid",
					Entity1LogicalName = "organization",
					Entity2LogicalName = "customcontroldefaultconfig",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N customcontrolresource_organization</summary>
			public static readonly XrmFakedRelationship CustomcontrolresourceOrganization = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "organizationid",
					Entity2Attribute = "organizationid",
					Entity1LogicalName = "organization",
					Entity2LogicalName = "customcontrolresource",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N dynamicproperty_organization</summary>
			public static readonly XrmFakedRelationship DynamicpropertyOrganization = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "organizationid",
					Entity2Attribute = "organizationid",
					Entity1LogicalName = "organization",
					Entity2LogicalName = "dynamicproperty",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N DynamicPropertyAssociation_organization</summary>
			public static readonly XrmFakedRelationship DynamicPropertyAssociationOrganization = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "organizationid",
					Entity2Attribute = "organizationid",
					Entity1LogicalName = "organization",
					Entity2LogicalName = "dynamicpropertyassociation",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N DynamicPropertyOptionSetItem_organization</summary>
			public static readonly XrmFakedRelationship DynamicPropertyOptionSetItemOrganization = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "organizationid",
					Entity2Attribute = "organizationid",
					Entity1LogicalName = "organization",
					Entity2LogicalName = "dynamicpropertyoptionsetitem",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N entitlementchannel_organization</summary>
			public static readonly XrmFakedRelationship EntitlementchannelOrganization = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "organizationid",
					Entity2Attribute = "organizationid",
					Entity1LogicalName = "organization",
					Entity2LogicalName = "entitlementchannel",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N entitlementtemplate_organization</summary>
			public static readonly XrmFakedRelationship EntitlementtemplateOrganization = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "organizationid",
					Entity2Attribute = "organizationid",
					Entity1LogicalName = "organization",
					Entity2LogicalName = "entitlementtemplate",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N entitlementtemplatechannel_organization</summary>
			public static readonly XrmFakedRelationship EntitlementtemplatechannelOrganization = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "organizationid",
					Entity2Attribute = "organizationid",
					Entity1LogicalName = "organization",
					Entity2LogicalName = "entitlementtemplatechannel",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N languagelocale_organization</summary>
			public static readonly XrmFakedRelationship LanguagelocaleOrganization = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "organizationid",
					Entity2Attribute = "organizationid",
					Entity1LogicalName = "organization",
					Entity2LogicalName = "languagelocale",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_dataperformance_organizationid</summary>
			public static readonly XrmFakedRelationship LkDataperformanceOrganizationid = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "organizationid",
					Entity2Attribute = "organizationid",
					Entity1LogicalName = "organization",
					Entity2LogicalName = "dataperformance",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_documenttemplatebase_organization</summary>
			public static readonly XrmFakedRelationship LkDocumenttemplatebaseOrganization = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "organizationid",
					Entity2Attribute = "organizationid",
					Entity1LogicalName = "organization",
					Entity2LogicalName = "documenttemplate",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_fieldsecurityprofile_organizationid</summary>
			public static readonly XrmFakedRelationship LkFieldsecurityprofileOrganizationid = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "organizationid",
					Entity2Attribute = "organizationid",
					Entity1LogicalName = "organization",
					Entity2LogicalName = "fieldsecurityprofile",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_principalobjectattributeaccess_organizationid</summary>
			public static readonly XrmFakedRelationship LkPrincipalobjectattributeaccessOrganizationid = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "organizationid",
					Entity2Attribute = "organizationid",
					Entity1LogicalName = "organization",
					Entity2LogicalName = "principalobjectattributeaccess",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N MobileOfflineProfile_organization</summary>
			public static readonly XrmFakedRelationship MobileOfflineProfileOrganization = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "organizationid",
					Entity2Attribute = "organizationid",
					Entity1LogicalName = "organization",
					Entity2LogicalName = "mobileofflineprofile",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N MobileOfflineProfileItem_organization</summary>
			public static readonly XrmFakedRelationship MobileOfflineProfileItemOrganization = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "organizationid",
					Entity2Attribute = "organizationid",
					Entity1LogicalName = "organization",
					Entity2LogicalName = "mobileofflineprofileitem",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N MobileOfflineProfileItemAssociation_organization</summary>
			public static readonly XrmFakedRelationship MobileOfflineProfileItemAssociationOrganization = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "organizationid",
					Entity2Attribute = "organizationid",
					Entity1LogicalName = "organization",
					Entity2LogicalName = "mobileofflineprofileitemassociation",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N organization_aciviewmapper</summary>
			public static readonly XrmFakedRelationship OrganizationAciviewmapper = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "organizationid",
					Entity2Attribute = "organizationid",
					Entity1LogicalName = "organization",
					Entity2LogicalName = "aciviewmapper",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N organization_appconfig</summary>
			public static readonly XrmFakedRelationship OrganizationAppconfig = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "organizationid",
					Entity2Attribute = "organizationid",
					Entity1LogicalName = "organization",
					Entity2LogicalName = "appconfig",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N organization_appconfiginstance</summary>
			public static readonly XrmFakedRelationship OrganizationAppconfiginstance = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "organizationid",
					Entity2Attribute = "organizationid",
					Entity1LogicalName = "organization",
					Entity2LogicalName = "appconfiginstance",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N organization_appconfigmaster</summary>
			public static readonly XrmFakedRelationship OrganizationAppconfigmaster = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "organizationid",
					Entity2Attribute = "organizationid",
					Entity1LogicalName = "organization",
					Entity2LogicalName = "appconfigmaster",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N organization_appmodule</summary>
			public static readonly XrmFakedRelationship OrganizationAppmodule = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "organizationid",
					Entity2Attribute = "organizationid",
					Entity1LogicalName = "organization",
					Entity2LogicalName = "appmodule",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N Organization_AsyncOperations</summary>
			public static readonly XrmFakedRelationship OrganizationAsyncOperations = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "organizationid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "organization",
					Entity2LogicalName = "asyncoperation",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N Organization_BulkDeleteFailures</summary>
			public static readonly XrmFakedRelationship OrganizationBulkDeleteFailures = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "organizationid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "organization",
					Entity2LogicalName = "bulkdeletefailure",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N organization_business_unit_news_articles</summary>
			public static readonly XrmFakedRelationship OrganizationBusinessUnitNewsArticles = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "organizationid",
					Entity2Attribute = "organizationid",
					Entity1LogicalName = "organization",
					Entity2LogicalName = "businessunitnewsarticle",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N organization_business_units</summary>
			public static readonly XrmFakedRelationship OrganizationBusinessUnits = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "organizationid",
					Entity2Attribute = "organizationid",
					Entity1LogicalName = "organization",
					Entity2LogicalName = "businessunit",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N organization_calendars</summary>
			public static readonly XrmFakedRelationship OrganizationCalendars = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "organizationid",
					Entity2Attribute = "organizationid",
					Entity1LogicalName = "organization",
					Entity2LogicalName = "calendar",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N organization_catalog</summary>
			public static readonly XrmFakedRelationship OrganizationCatalog = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "organizationid",
					Entity2Attribute = "organizationid",
					Entity1LogicalName = "organization",
					Entity2LogicalName = "catalog",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N organization_catalogassignment</summary>
			public static readonly XrmFakedRelationship OrganizationCatalogassignment = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "organizationid",
					Entity2Attribute = "organizationid",
					Entity1LogicalName = "organization",
					Entity2LogicalName = "catalogassignment",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N organization_competitors</summary>
			public static readonly XrmFakedRelationship OrganizationCompetitors = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "organizationid",
					Entity2Attribute = "organizationid",
					Entity1LogicalName = "organization",
					Entity2LogicalName = "competitor",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N organization_complexcontrols</summary>
			public static readonly XrmFakedRelationship OrganizationComplexcontrols = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "organizationid",
					Entity2Attribute = "organizationid",
					Entity1LogicalName = "organization",
					Entity2LogicalName = "complexcontrol",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N organization_connection_roles</summary>
			public static readonly XrmFakedRelationship OrganizationConnectionRoles = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "organizationid",
					Entity2Attribute = "organizationid",
					Entity1LogicalName = "organization",
					Entity2LogicalName = "connectionrole",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N organization_constraint_based_groups</summary>
			public static readonly XrmFakedRelationship OrganizationConstraintBasedGroups = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "organizationid",
					Entity2Attribute = "organizationid",
					Entity1LogicalName = "organization",
					Entity2LogicalName = "constraintbasedgroup",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N organization_contract_templates</summary>
			public static readonly XrmFakedRelationship OrganizationContractTemplates = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "organizationid",
					Entity2Attribute = "organizationid",
					Entity1LogicalName = "organization",
					Entity2LogicalName = "contracttemplate",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N organization_custom_displaystrings</summary>
			public static readonly XrmFakedRelationship OrganizationCustomDisplaystrings = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "organizationid",
					Entity2Attribute = "organizationid",
					Entity1LogicalName = "organization",
					Entity2LogicalName = "displaystring",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N organization_datalakeworkspace</summary>
			public static readonly XrmFakedRelationship OrganizationDatalakeworkspace = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "organizationid",
					Entity2Attribute = "organizationid",
					Entity1LogicalName = "organization",
					Entity2LogicalName = "datalakeworkspace",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N organization_datalakeworkspacepermission</summary>
			public static readonly XrmFakedRelationship OrganizationDatalakeworkspacepermission = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "organizationid",
					Entity2Attribute = "organizationid",
					Entity1LogicalName = "organization",
					Entity2LogicalName = "datalakeworkspacepermission",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N organization_discount_types</summary>
			public static readonly XrmFakedRelationship OrganizationDiscountTypes = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "organizationid",
					Entity2Attribute = "organizationid",
					Entity1LogicalName = "organization",
					Entity2LogicalName = "discounttype",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N organization_emailserverprofile</summary>
			public static readonly XrmFakedRelationship OrganizationEmailserverprofile = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "organizationid",
					Entity2Attribute = "organizationid",
					Entity1LogicalName = "organization",
					Entity2LogicalName = "emailserverprofile",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N organization_entityanalyticsconfig</summary>
			public static readonly XrmFakedRelationship OrganizationEntityanalyticsconfig = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "organizationid",
					Entity2Attribute = "organizationid",
					Entity1LogicalName = "organization",
					Entity2LogicalName = "entityanalyticsconfig",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N organization_entitydataprovider</summary>
			public static readonly XrmFakedRelationship OrganizationEntitydataprovider = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "organizationid",
					Entity2Attribute = "organizationid",
					Entity1LogicalName = "organization",
					Entity2LogicalName = "entitydataprovider",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N organization_equipment</summary>
			public static readonly XrmFakedRelationship OrganizationEquipment = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "organizationid",
					Entity2Attribute = "organizationid",
					Entity1LogicalName = "organization",
					Entity2LogicalName = "equipment",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N organization_expiredprocess</summary>
			public static readonly XrmFakedRelationship OrganizationExpiredprocess = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "organizationid",
					Entity2Attribute = "organizationid",
					Entity1LogicalName = "organization",
					Entity2LogicalName = "expiredprocess",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N organization_importjob</summary>
			public static readonly XrmFakedRelationship OrganizationImportjob = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "organizationid",
					Entity2Attribute = "organizationid",
					Entity1LogicalName = "organization",
					Entity2LogicalName = "importjob",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N organization_kb_article_templates</summary>
			public static readonly XrmFakedRelationship OrganizationKbArticleTemplates = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "organizationid",
					Entity2Attribute = "organizationid",
					Entity1LogicalName = "organization",
					Entity2LogicalName = "kbarticletemplate",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N organization_kb_articles</summary>
			public static readonly XrmFakedRelationship OrganizationKbArticles = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "organizationid",
					Entity2Attribute = "organizationid",
					Entity1LogicalName = "organization",
					Entity2LogicalName = "kbarticle",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N organization_KnowledgeBaseRecord</summary>
			public static readonly XrmFakedRelationship OrganizationKnowledgeBaseRecord = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "organizationid",
					Entity2Attribute = "organizationid",
					Entity1LogicalName = "organization",
					Entity2LogicalName = "knowledgebaserecord",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N organization_leadtoopportunitysalesprocess</summary>
			public static readonly XrmFakedRelationship OrganizationLeadtoopportunitysalesprocess = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "organizationid",
					Entity2Attribute = "organizationid",
					Entity1LogicalName = "organization",
					Entity2LogicalName = "leadtoopportunitysalesprocess",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N organization_mailbox</summary>
			public static readonly XrmFakedRelationship OrganizationMailbox = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "organizationid",
					Entity2Attribute = "organizationid",
					Entity1LogicalName = "organization",
					Entity2LogicalName = "mailbox",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N Organization_MailboxTrackingFolder</summary>
			public static readonly XrmFakedRelationship OrganizationMailboxTrackingFolder = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "organizationid",
					Entity2Attribute = "organizationid",
					Entity1LogicalName = "organization",
					Entity2LogicalName = "mailboxtrackingfolder",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N organization_marketingformdisplayattributes</summary>
			public static readonly XrmFakedRelationship OrganizationMarketingformdisplayattributes = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "organizationid",
					Entity2Attribute = "organizationid",
					Entity1LogicalName = "organization",
					Entity2LogicalName = "marketingformdisplayattributes",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N organization_metric</summary>
			public static readonly XrmFakedRelationship OrganizationMetric = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "organizationid",
					Entity2Attribute = "organizationid",
					Entity1LogicalName = "organization",
					Entity2LogicalName = "metric",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N organization_msdyn_databaseversion</summary>
			public static readonly XrmFakedRelationship OrganizationMsdynDatabaseversion = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "organizationid",
					Entity2Attribute = "organizationid",
					Entity1LogicalName = "organization",
					Entity2LogicalName = "msdyn_databaseversion",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N organization_msdyn_federatedarticleincident</summary>
			public static readonly XrmFakedRelationship OrganizationMsdynFederatedarticleincident = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "organizationid",
					Entity2Attribute = "organizationid",
					Entity1LogicalName = "organization",
					Entity2LogicalName = "msdyn_federatedarticleincident",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N organization_msdyn_helppage</summary>
			public static readonly XrmFakedRelationship OrganizationMsdynHelppage = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "organizationid",
					Entity2Attribute = "organizationid",
					Entity1LogicalName = "organization",
					Entity2LogicalName = "msdyn_helppage",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N organization_msdyn_postconfig</summary>
			public static readonly XrmFakedRelationship OrganizationMsdynPostconfig = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "organizationid",
					Entity2Attribute = "organizationid",
					Entity1LogicalName = "organization",
					Entity2LogicalName = "msdyn_postconfig",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N organization_msdyn_postruleconfig</summary>
			public static readonly XrmFakedRelationship OrganizationMsdynPostruleconfig = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "organizationid",
					Entity2Attribute = "organizationid",
					Entity1LogicalName = "organization",
					Entity2LogicalName = "msdyn_postruleconfig",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N organization_msdyn_sikeyvalueconfig</summary>
			public static readonly XrmFakedRelationship OrganizationMsdynSikeyvalueconfig = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "organizationid",
					Entity2Attribute = "organizationid",
					Entity1LogicalName = "organization",
					Entity2LogicalName = "msdyn_sikeyvalueconfig",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N organization_msdyn_tour</summary>
			public static readonly XrmFakedRelationship OrganizationMsdynTour = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "organizationid",
					Entity2Attribute = "organizationid",
					Entity1LogicalName = "organization",
					Entity2LogicalName = "msdyn_tour",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N organization_msdyn_upgraderun</summary>
			public static readonly XrmFakedRelationship OrganizationMsdynUpgraderun = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "organizationid",
					Entity2Attribute = "organizationid",
					Entity1LogicalName = "organization",
					Entity2LogicalName = "msdyn_upgraderun",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N organization_msdyn_upgradestep</summary>
			public static readonly XrmFakedRelationship OrganizationMsdynUpgradestep = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "organizationid",
					Entity2Attribute = "organizationid",
					Entity1LogicalName = "organization",
					Entity2LogicalName = "msdyn_upgradestep",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N organization_msdyn_upgradeversion</summary>
			public static readonly XrmFakedRelationship OrganizationMsdynUpgradeversion = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "organizationid",
					Entity2Attribute = "organizationid",
					Entity1LogicalName = "organization",
					Entity2LogicalName = "msdyn_upgradeversion",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N organization_msdyn_wallsavedquery</summary>
			public static readonly XrmFakedRelationship OrganizationMsdynWallsavedquery = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "organizationid",
					Entity2Attribute = "organizationid",
					Entity1LogicalName = "organization",
					Entity2LogicalName = "msdyn_wallsavedquery",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N organization_navigationsetting</summary>
			public static readonly XrmFakedRelationship OrganizationNavigationsetting = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "organizationid",
					Entity2Attribute = "organizationid",
					Entity1LogicalName = "organization",
					Entity2LogicalName = "navigationsetting",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N organization_newprocess</summary>
			public static readonly XrmFakedRelationship OrganizationNewprocess = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "organizationid",
					Entity2Attribute = "organizationid",
					Entity1LogicalName = "organization",
					Entity2LogicalName = "newprocess",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N organization_officegraphdocument</summary>
			public static readonly XrmFakedRelationship OrganizationOfficegraphdocument = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "organizationid",
					Entity2Attribute = "organizationid",
					Entity1LogicalName = "organization",
					Entity2LogicalName = "officegraphdocument",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N organization_opportunitysalesprocess</summary>
			public static readonly XrmFakedRelationship OrganizationOpportunitysalesprocess = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "organizationid",
					Entity2Attribute = "organizationid",
					Entity1LogicalName = "organization",
					Entity2LogicalName = "opportunitysalesprocess",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N organization_package</summary>
			public static readonly XrmFakedRelationship OrganizationPackage = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "organizationid",
					Entity2Attribute = "organizationid",
					Entity1LogicalName = "organization",
					Entity2LogicalName = "package",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N organization_phonetocaseprocess</summary>
			public static readonly XrmFakedRelationship OrganizationPhonetocaseprocess = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "organizationid",
					Entity2Attribute = "organizationid",
					Entity1LogicalName = "organization",
					Entity2LogicalName = "phonetocaseprocess",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N organization_pluginassembly</summary>
			public static readonly XrmFakedRelationship OrganizationPluginassembly = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "organizationid",
					Entity2Attribute = "organizationid",
					Entity1LogicalName = "organization",
					Entity2LogicalName = "pluginassembly",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N organization_plugintype</summary>
			public static readonly XrmFakedRelationship OrganizationPlugintype = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "organizationid",
					Entity2Attribute = "organizationid",
					Entity1LogicalName = "organization",
					Entity2LogicalName = "plugintype",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N organization_plugintypestatistic</summary>
			public static readonly XrmFakedRelationship OrganizationPlugintypestatistic = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "organizationid",
					Entity2Attribute = "organizationid",
					Entity1LogicalName = "organization",
					Entity2LogicalName = "plugintypestatistic",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N organization_position</summary>
			public static readonly XrmFakedRelationship OrganizationPosition = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "organizationid",
					Entity2Attribute = "organizationid",
					Entity1LogicalName = "organization",
					Entity2LogicalName = "position",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N organization_post</summary>
			public static readonly XrmFakedRelationship OrganizationPost = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "organizationid",
					Entity2Attribute = "organizationid",
					Entity1LogicalName = "organization",
					Entity2LogicalName = "post",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N organization_PostComment</summary>
			public static readonly XrmFakedRelationship OrganizationPostComment = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "organizationid",
					Entity2Attribute = "organizationid",
					Entity1LogicalName = "organization",
					Entity2LogicalName = "postcomment",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N organization_postlike</summary>
			public static readonly XrmFakedRelationship OrganizationPostlike = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "organizationid",
					Entity2Attribute = "organizationid",
					Entity1LogicalName = "organization",
					Entity2LogicalName = "postlike",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N organization_price_levels</summary>
			public static readonly XrmFakedRelationship OrganizationPriceLevels = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "organizationid",
					Entity2Attribute = "organizationid",
					Entity1LogicalName = "organization",
					Entity2LogicalName = "pricelevel",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N organization_ProductAssociation</summary>
			public static readonly XrmFakedRelationship OrganizationProductAssociation = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "organizationid",
					Entity2Attribute = "organizationid",
					Entity1LogicalName = "organization",
					Entity2LogicalName = "productassociation",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N organization_products</summary>
			public static readonly XrmFakedRelationship OrganizationProducts = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "organizationid",
					Entity2Attribute = "organizationid",
					Entity1LogicalName = "organization",
					Entity2LogicalName = "product",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N organization_ProductSubstitute</summary>
			public static readonly XrmFakedRelationship OrganizationProductSubstitute = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "organizationid",
					Entity2Attribute = "organizationid",
					Entity1LogicalName = "organization",
					Entity2LogicalName = "productsubstitute",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N organization_publisher</summary>
			public static readonly XrmFakedRelationship OrganizationPublisher = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "organizationid",
					Entity2Attribute = "organizationid",
					Entity1LogicalName = "organization",
					Entity2LogicalName = "publisher",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N organization_queueitems</summary>
			public static readonly XrmFakedRelationship OrganizationQueueitems = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "organizationid",
					Entity2Attribute = "organizationid",
					Entity1LogicalName = "organization",
					Entity2LogicalName = "queueitem",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N organization_queues</summary>
			public static readonly XrmFakedRelationship OrganizationQueues = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "organizationid",
					Entity2Attribute = "organizationid",
					Entity1LogicalName = "organization",
					Entity2LogicalName = "queue",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N organization_recommendeddocument</summary>
			public static readonly XrmFakedRelationship OrganizationRecommendeddocument = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "organizationid",
					Entity2Attribute = "organizationid",
					Entity1LogicalName = "organization",
					Entity2LogicalName = "recommendeddocument",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N organization_resource_groups</summary>
			public static readonly XrmFakedRelationship OrganizationResourceGroups = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "organizationid",
					Entity2Attribute = "organizationid",
					Entity1LogicalName = "organization",
					Entity2LogicalName = "resourcegroup",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N organization_resource_specs</summary>
			public static readonly XrmFakedRelationship OrganizationResourceSpecs = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "organizationid",
					Entity2Attribute = "organizationid",
					Entity1LogicalName = "organization",
					Entity2LogicalName = "resourcespec",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N organization_resources</summary>
			public static readonly XrmFakedRelationship OrganizationResources = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "organizationid",
					Entity2Attribute = "organizationid",
					Entity1LogicalName = "organization",
					Entity2LogicalName = "resource",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N organization_roles</summary>
			public static readonly XrmFakedRelationship OrganizationRoles = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "organizationid",
					Entity2Attribute = "organizationid",
					Entity1LogicalName = "organization",
					Entity2LogicalName = "role",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N organization_sales_literature</summary>
			public static readonly XrmFakedRelationship OrganizationSalesLiterature = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "organizationid",
					Entity2Attribute = "organizationid",
					Entity1LogicalName = "organization",
					Entity2LogicalName = "salesliterature",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N organization_saved_queries</summary>
			public static readonly XrmFakedRelationship OrganizationSavedQueries = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "organizationid",
					Entity2Attribute = "organizationid",
					Entity1LogicalName = "organization",
					Entity2LogicalName = "savedquery",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N organization_saved_query_visualizations</summary>
			public static readonly XrmFakedRelationship OrganizationSavedQueryVisualizations = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "organizationid",
					Entity2Attribute = "organizationid",
					Entity1LogicalName = "organization",
					Entity2LogicalName = "savedqueryvisualization",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N organization_sdkmessage</summary>
			public static readonly XrmFakedRelationship OrganizationSdkmessage = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "organizationid",
					Entity2Attribute = "organizationid",
					Entity1LogicalName = "organization",
					Entity2LogicalName = "sdkmessage",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N organization_sdkmessagefilter</summary>
			public static readonly XrmFakedRelationship OrganizationSdkmessagefilter = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "organizationid",
					Entity2Attribute = "organizationid",
					Entity1LogicalName = "organization",
					Entity2LogicalName = "sdkmessagefilter",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N organization_sdkmessageprocessingstep</summary>
			public static readonly XrmFakedRelationship OrganizationSdkmessageprocessingstep = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "organizationid",
					Entity2Attribute = "organizationid",
					Entity1LogicalName = "organization",
					Entity2LogicalName = "sdkmessageprocessingstep",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N organization_sdkmessageprocessingstepimage</summary>
			public static readonly XrmFakedRelationship OrganizationSdkmessageprocessingstepimage = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "organizationid",
					Entity2Attribute = "organizationid",
					Entity1LogicalName = "organization",
					Entity2LogicalName = "sdkmessageprocessingstepimage",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N organization_sdkmessageprocessingstepsecureconfig</summary>
			public static readonly XrmFakedRelationship OrganizationSdkmessageprocessingstepsecureconfig = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "organizationid",
					Entity2Attribute = "organizationid",
					Entity1LogicalName = "organization",
					Entity2LogicalName = "sdkmessageprocessingstepsecureconfig",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N organization_serviceendpoint</summary>
			public static readonly XrmFakedRelationship OrganizationServiceendpoint = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "organizationid",
					Entity2Attribute = "organizationid",
					Entity1LogicalName = "organization",
					Entity2LogicalName = "serviceendpoint",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N organization_services</summary>
			public static readonly XrmFakedRelationship OrganizationServices = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "organizationid",
					Entity2Attribute = "organizationid",
					Entity1LogicalName = "organization",
					Entity2LogicalName = "service",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N organization_sitemap</summary>
			public static readonly XrmFakedRelationship OrganizationSitemap = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "organizationid",
					Entity2Attribute = "organizationid",
					Entity1LogicalName = "organization",
					Entity2LogicalName = "sitemap",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N organization_sites</summary>
			public static readonly XrmFakedRelationship OrganizationSites = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "organizationid",
					Entity2Attribute = "organizationid",
					Entity1LogicalName = "organization",
					Entity2LogicalName = "site",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N organization_solution</summary>
			public static readonly XrmFakedRelationship OrganizationSolution = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "organizationid",
					Entity2Attribute = "organizationid",
					Entity1LogicalName = "organization",
					Entity2LogicalName = "solution",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N organization_solutioncomponentattributeconfiguration</summary>
			public static readonly XrmFakedRelationship OrganizationSolutioncomponentattributeconfiguration = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "organizationid",
					Entity2Attribute = "organizationid",
					Entity1LogicalName = "organization",
					Entity2LogicalName = "solutioncomponentattributeconfiguration",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N organization_solutioncomponentconfiguration</summary>
			public static readonly XrmFakedRelationship OrganizationSolutioncomponentconfiguration = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "organizationid",
					Entity2Attribute = "organizationid",
					Entity1LogicalName = "organization",
					Entity2LogicalName = "solutioncomponentconfiguration",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N organization_solutioncomponentrelationshipconfiguration</summary>
			public static readonly XrmFakedRelationship OrganizationSolutioncomponentrelationshipconfiguration = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "organizationid",
					Entity2Attribute = "organizationid",
					Entity1LogicalName = "organization",
					Entity2LogicalName = "solutioncomponentrelationshipconfiguration",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N organization_subjects</summary>
			public static readonly XrmFakedRelationship OrganizationSubjects = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "organizationid",
					Entity2Attribute = "organizationid",
					Entity1LogicalName = "organization",
					Entity2LogicalName = "subject",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N Organization_SyncErrors</summary>
			public static readonly XrmFakedRelationship OrganizationSyncErrors = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "organizationid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "organization",
					Entity2LogicalName = "syncerror",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N organization_system_users</summary>
			public static readonly XrmFakedRelationship OrganizationSystemUsers = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "organizationid",
					Entity2Attribute = "organizationid",
					Entity1LogicalName = "organization",
					Entity2LogicalName = "systemuser",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N organization_systemforms</summary>
			public static readonly XrmFakedRelationship OrganizationSystemforms = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "organizationid",
					Entity2Attribute = "organizationid",
					Entity1LogicalName = "organization",
					Entity2LogicalName = "systemform",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N organization_teams</summary>
			public static readonly XrmFakedRelationship OrganizationTeams = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "organizationid",
					Entity2Attribute = "organizationid",
					Entity1LogicalName = "organization",
					Entity2LogicalName = "team",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N organization_territories</summary>
			public static readonly XrmFakedRelationship OrganizationTerritories = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "organizationid",
					Entity2Attribute = "organizationid",
					Entity1LogicalName = "organization",
					Entity2LogicalName = "territory",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N organization_theme</summary>
			public static readonly XrmFakedRelationship OrganizationTheme = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "organizationid",
					Entity2Attribute = "organizationid",
					Entity1LogicalName = "organization",
					Entity2LogicalName = "theme",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N organization_tracelog</summary>
			public static readonly XrmFakedRelationship OrganizationTracelog = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "organizationid",
					Entity2Attribute = "organizationid",
					Entity1LogicalName = "organization",
					Entity2LogicalName = "tracelog",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N organization_transactioncurrencies</summary>
			public static readonly XrmFakedRelationship OrganizationTransactioncurrencies = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "organizationid",
					Entity2Attribute = "organizationid",
					Entity1LogicalName = "organization",
					Entity2LogicalName = "transactioncurrency",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N organization_translationprocess</summary>
			public static readonly XrmFakedRelationship OrganizationTranslationprocess = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "organizationid",
					Entity2Attribute = "organizationid",
					Entity1LogicalName = "organization",
					Entity2LogicalName = "translationprocess",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N organization_uof_schedules</summary>
			public static readonly XrmFakedRelationship OrganizationUofSchedules = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "organizationid",
					Entity2Attribute = "organizationid",
					Entity1LogicalName = "organization",
					Entity2LogicalName = "uomschedule",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N organization_UserMapping</summary>
			public static readonly XrmFakedRelationship OrganizationUserMapping = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "organizationid",
					Entity2Attribute = "organizationid",
					Entity1LogicalName = "organization",
					Entity2LogicalName = "usermapping",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N organization_webwizard</summary>
			public static readonly XrmFakedRelationship OrganizationWebwizard = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "organizationid",
					Entity2Attribute = "organizationid",
					Entity1LogicalName = "organization",
					Entity2LogicalName = "webwizard",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N webresource_organization</summary>
			public static readonly XrmFakedRelationship WebresourceOrganization = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "organizationid",
					Entity2Attribute = "organizationid",
					Entity1LogicalName = "organization",
					Entity2LogicalName = "webresource",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

		}
		#endregion

		#region Fake
		public static Organization Create()
		{
			var faker = new Faker<Organization>()
			.RuleFor(e => e.ACITenantURL, fake => fake.Lorem.Word())
			.RuleFor(e => e.Acknowledgementtemplateidname, fake => fake.Lorem.Word())
			.RuleFor(e => e.AllowAddressBookSynchronization, fake => fake.Random.Bool())
			.RuleFor(e => e.AllowAutomaticResponseCreation, fake => fake.Random.Bool())
			.RuleFor(e => e.AllowAutomaticUnsubscribe, fake => fake.Random.Bool())
			.RuleFor(e => e.AllowAutomaticUnsubscribeAcknowledgement, fake => fake.Random.Bool())
			.RuleFor(e => e.AllowOutlookClientMessageBarAdvertisement, fake => fake.Random.Bool())
			.RuleFor(e => e.AllowEntityLevelAuditing, fake => fake.Random.Bool())
			.RuleFor(e => e.EnableAccessToLegacyWebClientUI, fake => fake.Random.Bool())
			.RuleFor(e => e.EnableEmbeddingOfCertainLegacyDialogsInUnifiedInterfaceBrowserClient, fake => fake.Random.Bool())
			.RuleFor(e => e.AllowMarketingEmailExecution, fake => fake.Random.Bool())
			.RuleFor(e => e.AllowOfflineScheduledSynchronization, fake => fake.Random.Bool())
			.RuleFor(e => e.AllowScheduledSynchronization, fake => fake.Random.Bool())
			.RuleFor(e => e.AllowUnresolvedAddressEmailSend, fake => fake.Random.Bool())
			.RuleFor(e => e.AllowUserFormModePreference, fake => fake.Random.Bool())
			.RuleFor(e => e.AllowTheShowingTabletApplicationNotificationBarsInABrowser, fake => fake.Random.Bool())
			.RuleFor(e => e.AllowExportToExcel, fake => fake.Random.Bool())
			.RuleFor(e => e.AMDesignator, fake => fake.Lorem.Word())
			.RuleFor(e => e.EnableAppDesignerExperienceForThisOrganization, fake => fake.Random.Bool())
			.RuleFor(e => e.EnableRichEditingExperienceForAppointment, fake => fake.Random.Bool())
			.RuleFor(e => e.AuditRetentionPeriodSettings, fake => fake.Random.Int())
			.RuleFor(e => e.AuditRetentionPeriodSettings2, fake => fake.Random.Int())
			.RuleFor(e => e.AutoApplyDefaultEntitlementOnCaseCreate, fake => fake.Random.Bool())
			.RuleFor(e => e.AutoApplyDefaultEntitlementOnCaseUpdate, fake => fake.Random.Bool())
			.RuleFor(e => e.IsAutoapplySLAAfterManuallyOverriding, fake => fake.Random.Bool())
			.RuleFor(e => e.ForInternalUseOnly, fake => fake.Lorem.Word())
			.RuleFor(e => e.Basecurrencyidname, fake => fake.Lorem.Word())
			.RuleFor(e => e.BaseCurrencyPrecision, fake => fake.Random.Int())
			.RuleFor(e => e.BaseCurrencySymbol, fake => fake.Lorem.Word())
			.RuleFor(e => e.BaseISOCurrencyCode, fake => fake.Lorem.Word())
			.RuleFor(e => e.BingMapsAPIKey, fake => fake.Lorem.Word())
			.RuleFor(e => e.BlockAttachments, fake => fake.Lorem.Word())
			.RuleFor(e => e.DisplayCardsInExpandedStateForInteractiveDashboard, fake => fake.Random.Bool())
			.RuleFor(e => e.BulkOperationPrefix, fake => fake.Lorem.Word())
			.RuleFor(e => e.EnableNewBusinessCardOptions, fake => fake.Lorem.Word())
			.RuleFor(e => e.BusinessClosureCalendarId, fake => Guid.NewGuid())
			.RuleFor(e => e.CalendarType, fake => fake.Random.Int())
			.RuleFor(e => e.CampaignPrefix, fake => fake.Lorem.Word())
			.RuleFor(e => e.CascadeStatusUpdate, fake => fake.Random.Bool())
			.RuleFor(e => e.CasePrefix, fake => fake.Lorem.Word())
			.RuleFor(e => e.CategoryPrefix, fake => fake.Lorem.Word())
			.RuleFor(e => e.ClientFeatureSet, fake => fake.Lorem.Word())
			.RuleFor(e => e.ContentSecurityPolicyConfiguration, fake => fake.Lorem.Word())
			.RuleFor(e => e.ContractPrefix, fake => fake.Lorem.Word())
			.RuleFor(e => e.EnableCortanaProactiveExperienceFlowProcessesForThisOrganization, fake => fake.Random.Bool())
			.RuleFor(e => e.Createdbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Createdbyyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.CreatedOn, fake => fake.Date.Soon())
			.RuleFor(e => e.Createdonbehalfbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Createdonbehalfbyyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.EnableActiveInitialProductState, fake => fake.Random.Bool())
			.RuleFor(e => e.CurrencyDecimalPrecision, fake => fake.Random.Int())
			.RuleFor(e => e.DisplayCurrenciesUsing, fake => fake.PickRandom<Organization.eDisplayCurrenciesUsing>())
			.RuleFor(e => e.CurrencyFormatCode, fake => fake.PickRandom<Organization.eOrganizationCurrencyformatcode>())
			.RuleFor(e => e.CurrencySymbol, fake => fake.Lorem.Word())
			.RuleFor(e => e.CurrentBulkOperationNumber, fake => fake.Random.Int())
			.RuleFor(e => e.CurrentCampaignNumber, fake => fake.Random.Int())
			.RuleFor(e => e.CurrentCaseNumber, fake => fake.Random.Int())
			.RuleFor(e => e.CurrentCategoryNumber, fake => fake.Random.Int())
			.RuleFor(e => e.CurrentContractNumber, fake => fake.Random.Int())
			.RuleFor(e => e.CurrentImportSequenceNumber, fake => fake.Random.Int())
			.RuleFor(e => e.CurrentInvoiceNumber, fake => fake.Random.Int())
			.RuleFor(e => e.CurrentKnowledgeArticleNumber, fake => fake.Random.Int())
			.RuleFor(e => e.CurrentArticleNumber, fake => fake.Random.Int())
			.RuleFor(e => e.CurrentOrderNumber, fake => fake.Random.Int())
			.RuleFor(e => e.CurrentParsedTableNumber, fake => fake.Random.Int())
			.RuleFor(e => e.CurrentQuoteNumber, fake => fake.Random.Int())
			.RuleFor(e => e.DateFormatCode, fake => fake.PickRandom<Organization.eOrganizationDateformatcode>())
			.RuleFor(e => e.DateFormatString, fake => fake.Lorem.Word())
			.RuleFor(e => e.DateSeparator, fake => fake.Lorem.Word())
			.RuleFor(e => e.MaxValueOfDaysSinceRecordLastModified, fake => fake.Random.Int())
			.RuleFor(e => e.DecimalSymbol, fake => fake.Lorem.Word())
			.RuleFor(e => e.DefaultCountryCode, fake => fake.Lorem.Word())
			.RuleFor(e => e.NameOfTheDefaultApp, fake => fake.Lorem.Word())
			.RuleFor(e => e.Defaultemailserverprofileidname, fake => fake.Lorem.Word())
			.RuleFor(e => e.DefaultEmailSettings, fake => fake.Lorem.Word())
			.RuleFor(e => e.Defaultmobileofflineprofileidname, fake => fake.Lorem.Word())
			.RuleFor(e => e.DefaultRecurrenceEndRangeType, fake => fake.PickRandom<Organization.eDefaultRecurrenceEndRangeType>())
			.RuleFor(e => e.DefaultThemeData, fake => fake.Lorem.Word())
			.RuleFor(e => e.DelegatedAdminId, fake => Guid.NewGuid())
			.RuleFor(e => e.DisabledReason, fake => fake.Lorem.Word())
			.RuleFor(e => e.IsSocialCareDisabled, fake => fake.Random.Bool())
			.RuleFor(e => e.DiscountCalculationMethod, fake => fake.PickRandom<Organization.eDiscountCalculationMethod>())
			.RuleFor(e => e.DisplayNavigationTour, fake => fake.Random.Bool())
			.RuleFor(e => e.EmailConnectionChannel, fake => fake.PickRandom<Organization.eOrganizationEmailconnectionchannel>())
			.RuleFor(e => e.UseEmailCorrelation, fake => fake.Random.Bool())
			.RuleFor(e => e.EmailSendPollingFrequency, fake => fake.Random.Int())
			.RuleFor(e => e.EnableIntegrationWithBingMaps, fake => fake.Random.Bool())
			.RuleFor(e => e.EnableIntegrationWithImmersiveSkype, fake => fake.Random.Bool())
			.RuleFor(e => e.IndicatesWhetherTheUserHasEnabledOrDisabledLivePersonaCardFeatureInUCI, fake => fake.Random.Bool())
			.RuleFor(e => e.IndicatesWhetherTheUserHasEnabledOrDisabledLivePersonCardIntegrationInOffice, fake => fake.Random.Bool())
			.RuleFor(e => e.EnableLearningPathAuthoring, fake => fake.Random.Bool())
			.RuleFor(e => e.EnableIntegrationWithMicrosoftFlow, fake => fake.Random.Bool())
			.RuleFor(e => e.EnablePricingOnCreate, fake => fake.Random.Bool())
			.RuleFor(e => e.EnableSmartMatching, fake => fake.Random.Bool())
			.RuleFor(e => e.EnableSiteMapAndCommandingUpdate, fake => fake.Random.Bool())
			.RuleFor(e => e.OrganizationSettingToEnforceReadOnlyPlugins, fake => fake.Random.Bool())
			.RuleFor(e => e.EntityimageTimestamp, fake => fake.Random.Int())
			.RuleFor(e => e.EntityimageUrl, fake => fake.Lorem.Word())
			.RuleFor(e => e.EntityImageId, fake => Guid.NewGuid())
			.RuleFor(e => e.DaysToExpireChangeTrackingDeletedRecords, fake => fake.Random.Int())
			.RuleFor(e => e.DaysToExpireSubscriptions, fake => fake.Random.Int())
			.RuleFor(e => e.ExternalBaseURL, fake => fake.Lorem.Word())
			.RuleFor(e => e.ExternalPartyEnabledEntitiesCorrelationKeys, fake => fake.Lorem.Word())
			.RuleFor(e => e.ExternalPartyEnabledEntitiesSettingsForInternalUseOnly, fake => fake.Lorem.Word())
			.RuleFor(e => e.FeatureSet, fake => fake.Lorem.Word())
			.RuleFor(e => e.FiscalCalendarStart, fake => fake.Date.Soon())
			.RuleFor(e => e.FiscalPeriodFormat, fake => fake.Lorem.Word())
			.RuleFor(e => e.FormatForFiscalPeriod, fake => fake.PickRandom<Organization.eFiscalPeriodFormat>())
			.RuleFor(e => e.FiscalPeriodType, fake => fake.Random.Int())
			.RuleFor(e => e.IsFiscalSettingsUpdated, fake => fake.Random.Bool())
			.RuleFor(e => e.FiscalYearDisplay, fake => fake.Random.Int())
			.RuleFor(e => e.FiscalYearFormat, fake => fake.Lorem.Word())
			.RuleFor(e => e.PrefixForFiscalYear, fake => fake.PickRandom<Organization.eFiscalYearFormatPrefix>())
			.RuleFor(e => e.SuffixForFiscalYear, fake => fake.PickRandom<Organization.eFiscalYearFormatSuffix>())
			.RuleFor(e => e.FiscalYearFormatYear, fake => fake.PickRandom<Organization.eFiscalYearFormat>())
			.RuleFor(e => e.FiscalYearPeriodConnector, fake => fake.Lorem.Word())
			.RuleFor(e => e.FullNameDisplayOrder, fake => fake.PickRandom<Organization.eOrganizationFullnameconventioncode>())
			.RuleFor(e => e.FutureExpansionWindow, fake => fake.Random.Int())
			.RuleFor(e => e.GenerateAlertsForErrors, fake => fake.Random.Bool())
			.RuleFor(e => e.GenerateAlertsForInformation, fake => fake.Random.Bool())
			.RuleFor(e => e.GenerateAlertsForWarnings, fake => fake.Random.Bool())
			.RuleFor(e => e.IsGetStartedPaneContentEnabled, fake => fake.Random.Bool())
			.RuleFor(e => e.IsAppendUrlParametersEnabled, fake => fake.Random.Bool())
			.RuleFor(e => e.GlobalHelpURL, fake => fake.Lorem.Word())
			.RuleFor(e => e.IsCustomizableGlobalHelpEnabled, fake => fake.Random.Bool())
			.RuleFor(e => e.RollupExpirationTimeForGoal, fake => fake.Random.Int())
			.RuleFor(e => e.AutomaticRollupFrequencyForGoal, fake => fake.Random.Int())
			.RuleFor(e => e.GrantAccessToNetworkService, fake => fake.Random.Bool())
			.RuleFor(e => e.HashDeltaSubjectCount, fake => fake.Random.Int())
			.RuleFor(e => e.HashFilterKeywords, fake => fake.Lorem.Word())
			.RuleFor(e => e.HashMaxCount, fake => fake.Random.Int())
			.RuleFor(e => e.HashMinAddressCount, fake => fake.Random.Int())
			.RuleFor(e => e.HighContrastThemeData, fake => fake.Lorem.Word())
			.RuleFor(e => e.IgnoreInternalEmail, fake => fake.Random.Bool())
			.RuleFor(e => e.InactivityTimeoutEnabled, fake => fake.Random.Bool())
			.RuleFor(e => e.InactivityTimeoutInMinutes, fake => fake.Random.Int())
			.RuleFor(e => e.InactivityTimeoutReminderInMinutes, fake => fake.Random.Int())
			.RuleFor(e => e.ExchangeEmailRetrievalBatchSize, fake => fake.Random.Int())
			.RuleFor(e => e.InitialVersion, fake => fake.Lorem.Word())
			.RuleFor(e => e.IntegrationUserId, fake => Guid.NewGuid())
			.RuleFor(e => e.InvoicePrefix, fake => fake.Lorem.Word())
			.RuleFor(e => e.EnableActionCardForThisOrganization, fake => fake.Random.Bool())
			.RuleFor(e => e.ActionSupportFeatureEnabled, fake => fake.Random.Bool())
			.RuleFor(e => e.EnableRelationshipAnalyticsForThisOrganization, fake => fake.Random.Bool())
			.RuleFor(e => e.SetIfAllMoneyAttributesAreConvertedToDecimal, fake => fake.Random.Bool())
			.RuleFor(e => e.IsApplicationModeEnabled, fake => fake.Random.Bool())
			.RuleFor(e => e.IsAttachmentSyncEnabled, fake => fake.Random.Bool())
			.RuleFor(e => e.IsAssignedTasksSyncEnabled, fake => fake.Random.Bool())
			.RuleFor(e => e.IsAuditingEnabled, fake => fake.Random.Bool())
			.RuleFor(e => e.EnableAutoCaptureForThisOrganization, fake => fake.Random.Bool())
			.RuleFor(e => e.EnableAutoCaptureV2ForThisOrganization, fake => fake.Random.Bool())
			.RuleFor(e => e.AutoSaveEnabled, fake => fake.Random.Bool())
			.RuleFor(e => e.BPFEntityCustomizationFeatureEnabled, fake => fake.Random.Bool())
			.RuleFor(e => e.IsConflictDetectionForMobileClientEnabled, fake => fake.Random.Bool())
			.RuleFor(e => e.IsMailingAddressSyncEnabled, fake => fake.Random.Bool())
			.RuleFor(e => e.EnableContentSecurityPolicyForThisOrganization, fake => fake.Random.Bool())
			.RuleFor(e => e.IndicatesWhetherContextualEmailExperienceIsEnabledOnThisOrganization, fake => fake.Random.Bool())
			.RuleFor(e => e.EnablesContextualHelpInUCI, fake => fake.Random.Bool())
			.RuleFor(e => e.EnableCustomControlsInCanvasPowerAppsFeatureForThisOrganization, fake => fake.Random.Bool())
			.RuleFor(e => e.EnableOrDisableCountryCodeSelection, fake => fake.Random.Bool())
			.RuleFor(e => e.IsDelegationAccessEnabled, fake => fake.Random.Bool())
			.RuleFor(e => e.EnableActionHubForThisOrganization, fake => fake.Random.Bool())
			.RuleFor(e => e.IsOrganizationDisabled, fake => fake.Random.Bool())
			.RuleFor(e => e.IsDuplicateDetectionEnabled, fake => fake.Random.Bool())
			.RuleFor(e => e.IsDuplicateDetectionEnabledForImport, fake => fake.Random.Bool())
			.RuleFor(e => e.IsDuplicateDetectionEnabledForOfflineSynchronization, fake => fake.Random.Bool())
			.RuleFor(e => e.IsDuplicateDetectionEnabledForOnlineCreateUpdate, fake => fake.Random.Bool())
			.RuleFor(e => e.AllowTrackingRecipientActivityOnSentEmails, fake => fake.Random.Bool())
			.RuleFor(e => e.IsEmailServerProfileContentFilteringEnabled, fake => fake.Random.Bool())
			.RuleFor(e => e.OptionSetValuesForIsenabledforallroles, fake => fake.Random.Bool())
			.RuleFor(e => e.EnableExternalFileStorage, fake => fake.Random.Bool())
			.RuleFor(e => e.EnableExternalSearchDataSyncing, fake => fake.Random.Bool())
			.RuleFor(e => e.IsFiscalPeriodMonthly, fake => fake.Random.Bool())
			.RuleFor(e => e.AutomaticallyCreateFolders, fake => fake.Random.Bool())
			.RuleFor(e => e.IsFolderBasedTrackingEnabled, fake => fake.Random.Bool())
			.RuleFor(e => e.EnableFulltextSearchForQuickFind, fake => fake.Random.Bool())
			.RuleFor(e => e.EnableGeospatialAzureMapsIntegration, fake => fake.Random.Bool())
			.RuleFor(e => e.EnableHierarchicalSecurityModel, fake => fake.Random.Bool())
			.RuleFor(e => e.LUISConsentForDynamics365Bot, fake => fake.Random.Bool())
			.RuleFor(e => e.IsMailboxForcedUnlockingEnabled, fake => fake.Random.Bool())
			.RuleFor(e => e.IsMailboxKeepAliveEnabled, fake => fake.Random.Bool())
			.RuleFor(e => e.EnableManualSalesForecastingFeatureForThisOrganization, fake => fake.Random.Bool())
			.RuleFor(e => e.IsMobileClientOnDemandSyncEnabled, fake => fake.Random.Bool())
			.RuleFor(e => e.EnableMobileOfflineForThisOrganization, fake => fake.Random.Bool())
			.RuleFor(e => e.EnableEmbeddingModelAppsInMicrosoftTeams, fake => fake.Random.Bool())
			.RuleFor(e => e.EnableMicrosoftTeamsCollaborationForThisOrganization, fake => fake.Random.Bool())
			.RuleFor(e => e.EnableMicrosoftTeamsIntegration, fake => fake.Random.Bool())
			.RuleFor(e => e.MicrosoftTeamsIntegrationChangedByUser, fake => fake.Random.Bool())
			.RuleFor(e => e.EnableMicrosoftTeamsUserSyncForThisOrganization, fake => fake.Random.Bool())
			.RuleFor(e => e.IndicatesWhetherNewAddProductExperienceIsEnabledInOpportunityForm, fake => fake.Random.Bool())
			.RuleFor(e => e.EnableNotesAnalysisForThisOrganization, fake => fake.Random.Bool())
			.RuleFor(e => e.EnableOfficeGraphForThisOrganization, fake => fake.Random.Bool())
			.RuleFor(e => e.EnableOneDriveForThisOrganization, fake => fake.Random.Bool())
			.RuleFor(e => e.EnablePAIFeatureForThisOrganization, fake => fake.Random.Bool())
			.RuleFor(e => e.EnablePDFGenerationFeatureForThisOrganization, fake => fake.Lorem.Word())
			.RuleFor(e => e.EnablePlaybookFeatureForThisOrganization, fake => fake.Random.Bool())
			.RuleFor(e => e.PresenceEnabled, fake => fake.Random.Bool())
			.RuleFor(e => e.EnablePreviewActionCardFeatureForThisOrganization, fake => fake.Random.Bool())
			.RuleFor(e => e.EnableAutoCaptureForThisOrganizationAtPreviewSettings, fake => fake.Random.Bool())
			.RuleFor(e => e.AllowsPreviewForEmailMonitoring, fake => fake.Random.Bool())
			.RuleFor(e => e.IndicatesWhetherPriceListIsMandatoryForAddingExistingProductsToSalesEntities, fake => fake.Random.Bool())
			.RuleFor(e => e.EnableQuickCreateFormForOpportunityCloseFeatureForThisOrganization, fake => fake.Random.Bool())
			.RuleFor(e => e.IsReadAuditingEnabled, fake => fake.Random.Bool())
			.RuleFor(e => e.EnableRelationshipInsightsForThisOrganization, fake => fake.Random.Bool())
			.RuleFor(e => e.ResourceBookingSynchronizationEnabled, fake => fake.Random.Bool())
			.RuleFor(e => e.IndicatesWhetherRichTextEditorForNotesExperienceIsEnabledOnThisOrganization, fake => fake.Random.Bool())
			.RuleFor(e => e.EnableSalesAssistantMobileApp, fake => fake.Random.Bool())
			.RuleFor(e => e.IsSalesOrderIntegrationEnabled, fake => fake.Random.Bool())
			.RuleFor(e => e.EnableTextWrap, fake => fake.Random.Bool())
			.RuleFor(e => e.IsUserAccessAuditingEnabled, fake => fake.Random.Bool())
			.RuleFor(e => e.ISVIntegrationMode, fake => fake.PickRandom<Organization.eOrganizationIsvintegrationcode>())
			.RuleFor(e => e.IndicatesWhetherWriteinProductsCanBeAddedToOpportunityQuoteOrderInvoiceOrNot, fake => fake.Random.Bool())
			.RuleFor(e => e.KnowledgeArticlePrefix, fake => fake.Lorem.Word())
			.RuleFor(e => e.ArticlePrefix, fake => fake.Lorem.Word())
			.RuleFor(e => e.KnowledgeManagementSettings, fake => fake.Lorem.Word())
			.RuleFor(e => e.Language, fake => fake.Random.Int())
			.RuleFor(e => e.Locale, fake => fake.Random.Int())
			.RuleFor(e => e.LongDateFormat, fake => fake.Random.Int())
			.RuleFor(e => e.LowerThresholdForMailboxIntermittentIssue, fake => fake.Random.Int())
			.RuleFor(e => e.LowerThresholdForMailboxPermanentIssue, fake => fake.Random.Int())
			.RuleFor(e => e.MaximumNumberOfActionstepsAllowedInABPF, fake => fake.Random.Int())
			.RuleFor(e => e.MaxAppointmentDuration, fake => fake.Random.Int())
			.RuleFor(e => e.MaximumNumberOfConditionsAllowedForMobileOfflineFilters, fake => fake.Random.Int())
			.RuleFor(e => e.MaximumDepthForHierarchySecurityPropagation, fake => fake.Random.Int())
			.RuleFor(e => e.MaxFolderBasedTrackingMappings, fake => fake.Random.Int())
			.RuleFor(e => e.MaximumActiveBusinessProcessFlowsPerEntity, fake => fake.Random.Int())
			.RuleFor(e => e.ProductPropertiesItemLimit, fake => fake.Random.Int())
			.RuleFor(e => e.MaximumNumberOfActiveSLAAllowedPerEntityInOnline, fake => fake.Random.Int())
			.RuleFor(e => e.MaximumNumberOfActiveSLAKPIAllowedPerEntityInOnline, fake => fake.Random.Int())
			.RuleFor(e => e.MaxTrackingNumber, fake => fake.Random.Int())
			.RuleFor(e => e.BundleItemLimit, fake => fake.Random.Int())
			.RuleFor(e => e.MaxRecordsForExcelExport, fake => fake.Random.Int())
			.RuleFor(e => e.MaxRecordsFilterSelection, fake => fake.Random.Int())
			.RuleFor(e => e.MaxSLAItemsPerSLA, fake => fake.Random.Int())
			.RuleFor(e => e.MaxSupportedIEVersion, fake => fake.Random.Int())
			.RuleFor(e => e.MaxUploadFileSize, fake => fake.Random.Int())
			.RuleFor(e => e.MaxNoOfMailboxesToEnableForVerboseLogging, fake => fake.Random.Int())
			.RuleFor(e => e.MaximumNumberOfSyncCyclesForWhichVerboseLoggingWillBeEnabledByDefault, fake => fake.Random.Int())
			.RuleFor(e => e.TheLastDatetimeForNeverExpiredMetadataTrackingDeletedObjects, fake => fake.Date.Soon())
			.RuleFor(e => e.MetadataSyncVersion, fake => fake.Random.Int())
			.RuleFor(e => e.DeprecatedEnvironmentSelectedForIntegrationWithMicrosoftFlow, fake => fake.Lorem.Word())
			.RuleFor(e => e.MinAddressSynchronizationFrequency, fake => fake.Random.Int())
			.RuleFor(e => e.MinOfflineSynchronizationFrequency, fake => fake.Random.Int())
			.RuleFor(e => e.MinSynchronizationFrequency, fake => fake.Random.Int())
			.RuleFor(e => e.MinimumNumberOfUserLicenseRequiredForMobileOfflineServiceByProductionpreviewOrganization, fake => fake.Random.Int())
			.RuleFor(e => e.MinimumNumberOfUserLicenseRequiredForMobileOfflineServiceByTrialOrganization, fake => fake.Random.Int())
			.RuleFor(e => e.SyncIntervalForMobileOffline, fake => fake.Random.Int())
			.RuleFor(e => e.Modifiedbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Modifiedbyyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.ModifiedOn, fake => fake.Date.Soon())
			.RuleFor(e => e.Modifiedonbehalfbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Modifiedonbehalfbyyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.OrganizationName, fake => fake.Lorem.Word())
			.RuleFor(e => e.NegativeCurrencyFormat, fake => fake.Random.Int())
			.RuleFor(e => e.NegativeFormat, fake => fake.PickRandom<Organization.eOrganizationNegativeformatcode>())
			.RuleFor(e => e.NextEntityTypeCode, fake => fake.Random.Int())
			.RuleFor(e => e.NextTrackingNumber, fake => fake.Random.Int())
			.RuleFor(e => e.NotifyMailboxOwnerOfEmailServerLevelAlerts, fake => fake.Random.Bool())
			.RuleFor(e => e.NumberFormat, fake => fake.Lorem.Word())
			.RuleFor(e => e.NumberGroupingFormat, fake => fake.Lorem.Word())
			.RuleFor(e => e.NumberSeparator, fake => fake.Lorem.Word())
			.RuleFor(e => e.EnableOfficeAppsAutoDeploymentForThisOrganization, fake => fake.Random.Bool())
			.RuleFor(e => e.TheUrlToOpenTheDelve, fake => fake.Lorem.Word())
			.RuleFor(e => e.EnableOOBPriceCalculation, fake => fake.Random.Bool())
			.RuleFor(e => e.OrderPrefix, fake => fake.Lorem.Word())
			.RuleFor(e => e.Id, fake => Guid.NewGuid())
			.RuleFor(e => e.OrganizationState, fake => fake.PickRandom<Organization.eOrganizationState>())
			.RuleFor(e => e.OrganizationDatabaseOrganizationSettings, fake => fake.Lorem.Word())
			.RuleFor(e => e.EnableOrgInsightsForThisOrganization, fake => fake.Random.Bool())
			.RuleFor(e => e.DisplayPreviewFeatureForThisOrganization, fake => fake.Random.Bool())
			.RuleFor(e => e.ParsedTableColumnPrefix, fake => fake.Lorem.Word())
			.RuleFor(e => e.ParsedTablePrefix, fake => fake.Lorem.Word())
			.RuleFor(e => e.PastExpansionWindow, fake => fake.Random.Int())
			.RuleFor(e => e.Picture, fake => fake.Lorem.Word())
			.RuleFor(e => e.Pinpointlanguagecode, fake => fake.Random.Int())
			.RuleFor(e => e.PluginTraceLogSetting, fake => fake.PickRandom<Organization.eOrganizationPlugintracelogsetting>())
			.RuleFor(e => e.PMDesignator, fake => fake.Lorem.Word())
			.RuleFor(e => e.ForInternalUseOnly2, fake => fake.Lorem.Word())
			.RuleFor(e => e.EnablePowerBIFeatureForThisOrganization, fake => fake.Random.Bool())
			.RuleFor(e => e.PricingDecimalPrecision, fake => fake.Random.Int())
			.RuleFor(e => e.PrivacyStatementURL, fake => fake.Lorem.Word())
			.RuleFor(e => e.PrivilegeUserGroupId, fake => Guid.NewGuid())
			.RuleFor(e => e.PrivilegeReportingGroupId, fake => Guid.NewGuid())
			.RuleFor(e => e.PrivilegeReportingGroupName, fake => fake.Lorem.Word())
			.RuleFor(e => e.EnableProductRecommendationsForThisOrganization, fake => fake.Random.Bool())
			.RuleFor(e => e.EnableNewQualifyLeadExperienceWithConfigurationMDD, fake => fake.Lorem.Word())
			.RuleFor(e => e.QuickFindRecordLimitEnabled, fake => fake.Random.Bool())
			.RuleFor(e => e.QuotePrefix, fake => fake.Lorem.Word())
			.RuleFor(e => e.RecurrenceDefaultNumberOfOccurrences, fake => fake.Random.Int())
			.RuleFor(e => e.RecurrenceExpansionJobBatchInterval, fake => fake.Random.Int())
			.RuleFor(e => e.RecurrenceExpansionOnDemandJobBatchSize, fake => fake.Random.Int())
			.RuleFor(e => e.RecurrenceExpansionSynchronizationCreateMaximum, fake => fake.Random.Int())
			.RuleFor(e => e.ReferenceSiteMapXML, fake => fake.Lorem.Word())
			.RuleFor(e => e.RenderSecureFrameForEmail, fake => fake.Random.Bool())
			.RuleFor(e => e.ReportingGroupId, fake => Guid.NewGuid())
			.RuleFor(e => e.ReportingGroupName, fake => fake.Lorem.Word())
			.RuleFor(e => e.ReportScriptErrors, fake => fake.PickRandom<Organization.eReportScriptErrors>())
			.RuleFor(e => e.IsApprovalForQueueEmailRequired, fake => fake.Random.Bool())
			.RuleFor(e => e.IsApprovalForUserEmailRequired, fake => fake.Random.Bool())
			.RuleFor(e => e.ApplySameEmailAddressToAllUnresolvedMatchesWhenYouManuallyResolveItForOne, fake => fake.Random.Bool())
			.RuleFor(e => e.RestrictStatusUpdate, fake => fake.Random.Bool())
			.RuleFor(e => e.ErrorStatusOfRelationshipInsightsProvisioning, fake => fake.Random.Int())
			.RuleFor(e => e.SampleDataImportId, fake => Guid.NewGuid())
			.RuleFor(e => e.SchedulingEngineForAppointmentsAndServiceActivities, fake => fake.PickRandom<Organization.eSchedulingEngineForAppointmentsAndServiceActivities>())
			.RuleFor(e => e.CustomizationNamePrefix, fake => fake.Lorem.Word())
			.RuleFor(e => e.SendBulkEmailInUCI, fake => fake.Random.Bool())
			.RuleFor(e => e.ServeStaticContentFromCDN, fake => fake.Random.Bool())
			.RuleFor(e => e.SessionTimeoutEnabled, fake => fake.Random.Bool())
			.RuleFor(e => e.SessionTimeoutInMinutes, fake => fake.Random.Int())
			.RuleFor(e => e.SessionTimeoutReminderInMinutes, fake => fake.Random.Int())
			.RuleFor(e => e.ChooseSharePointDeploymentType, fake => fake.PickRandom<Organization.eOrganizationSharepointdeploymenttype>())
			.RuleFor(e => e.ShareToPreviousOwnerOnAssign, fake => fake.Random.Bool())
			.RuleFor(e => e.ShowKBArticleDeprecationMessageToUser, fake => fake.Random.Bool())
			.RuleFor(e => e.ShowWeekNumber, fake => fake.Random.Bool())
			.RuleFor(e => e.CRMForOutlookDownloadURL, fake => fake.Lorem.Word())
			.RuleFor(e => e.SiteMapXML, fake => fake.Lorem.Word())
			.RuleFor(e => e.SLAPauseStates, fake => fake.Lorem.Word())
			.RuleFor(e => e.SocialInsightsEnabled, fake => fake.Random.Bool())
			.RuleFor(e => e.SocialInsightsInstanceIdentifier, fake => fake.Lorem.Word())
			.RuleFor(e => e.SocialInsightsTermsOfUse, fake => fake.Random.Bool())
			.RuleFor(e => e.Sort, fake => fake.Random.Int())
			.RuleFor(e => e.SQLAccessGroupId, fake => Guid.NewGuid())
			.RuleFor(e => e.SQLAccessGroupName, fake => fake.Lorem.Word())
			.RuleFor(e => e.IsSQMEnabled, fake => fake.Random.Bool())
			.RuleFor(e => e.SupportUserId, fake => Guid.NewGuid())
			.RuleFor(e => e.IsSLASuppressed, fake => fake.Random.Bool())
			.RuleFor(e => e.NumberOfRecordsToUpdatePerOperationInSyncBulkPauseResumeCancel, fake => fake.Random.Int())
			.RuleFor(e => e.MaxTotalNumberOfRecordsToUpdateInDatabaseForSyncBulkPauseResumeCancel, fake => fake.Random.Int())
			.RuleFor(e => e.EnableDynamics365AzureSyncFrameworkForThisOrganization, fake => fake.Random.Bool())
			.RuleFor(e => e.StatusOfOptinOrOptoutOperationForDynamics365AzureSync, fake => fake.PickRandom<Organization.eOrganizationSyncoptinselectionstatus>())
			.RuleFor(e => e.SystemUserId, fake => Guid.NewGuid())
			.RuleFor(e => e.AutoTagMaxCycles, fake => fake.Random.Int())
			.RuleFor(e => e.AutoTagInterval, fake => fake.Random.Int())
			.RuleFor(e => e.EnableTaskFlowProcessesForThisOrganization, fake => fake.Random.Bool())
			.RuleFor(e => e.EnableTextAnalyticsForThisOrganization, fake => fake.Random.Bool())
			.RuleFor(e => e.TimeFormatCode, fake => fake.PickRandom<Organization.eOrganizationTimeformatcode>())
			.RuleFor(e => e.TimeFormatString, fake => fake.Lorem.Word())
			.RuleFor(e => e.TimeSeparator, fake => fake.Lorem.Word())
			.RuleFor(e => e.TimeZoneRuleVersionNumber, fake => fake.Random.Int())
			.RuleFor(e => e.TokenExpirationDuration, fake => fake.Random.Int())
			.RuleFor(e => e.TokenKey, fake => fake.Lorem.Word())
			.RuleFor(e => e.TracelogRecordMaximumAgeInDays, fake => fake.Random.Int())
			.RuleFor(e => e.TrackingPrefix, fake => fake.Lorem.Word())
			.RuleFor(e => e.TrackingTokenBase, fake => fake.Random.Int())
			.RuleFor(e => e.TrackingTokenDigits, fake => fake.Random.Int())
			.RuleFor(e => e.UniqueStringLength, fake => fake.Random.Int())
			.RuleFor(e => e.SetToccbccFieldsAsUnresolvedIfMultipleMatchesAreFound, fake => fake.Random.Bool())
			.RuleFor(e => e.UseInbuiltRuleForDefaultPricelistSelection, fake => fake.Random.Bool())
			.RuleFor(e => e.LegacyFormRendering, fake => fake.Random.Bool())
			.RuleFor(e => e.UsePositionHierarchy, fake => fake.Random.Bool())
			.RuleFor(e => e.UseQuickFindViewWhenSearchingInGrids, fake => fake.Random.Bool())
			.RuleFor(e => e.UserAuthenticationAuditingInterval, fake => fake.Random.Int())
			.RuleFor(e => e.UseReadOptimizedForm, fake => fake.Random.Bool())
			.RuleFor(e => e.UserGroupId, fake => Guid.NewGuid())
			.RuleFor(e => e.UserSkypeProtocol, fake => fake.Random.Bool())
			.RuleFor(e => e.UTCConversionTimeZoneCode, fake => fake.Random.Int())
			.RuleFor(e => e.V3CalloutHash, fake => fake.Lorem.Word())
			.RuleFor(e => e.VersionNumber, fake => fake.Random.Int())
			.RuleFor(e => e.WebResourceHash, fake => fake.Lorem.Word())
			.RuleFor(e => e.WeekStartDayCode, fake => fake.PickRandom<Organization.eOrganizationWeekstartdaycode>())
			.RuleFor(e => e.ForInternalUseOnly3, fake => fake.Lorem.Word())
			.RuleFor(e => e.YammerGroupId, fake => fake.Random.Int())
			.RuleFor(e => e.YammerNetworkPermalink, fake => fake.Lorem.Word())
			.RuleFor(e => e.YammerOAuthAccessTokenExpired, fake => fake.Random.Bool())
			.RuleFor(e => e.InternalUseOnly, fake => fake.PickRandom<Organization.eOrganizationYammerpostmethod>())
			.RuleFor(e => e.YearStartWeekCode, fake => fake.Random.Int());
			return faker.Generate();
		}
		#endregion
	}
}

