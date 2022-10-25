using Bogus;
using System;
using FakeXrmEasy;
using System.Collections.Generic;
using PentaWork.Xrm.Scheduler.Proxies.Entities;

namespace PentaWork.Xrm.Scheduler.Tests.Fake
{
	public static class FakeUser
	{	
		#region FakeRelationships
		public static class Relationships 
		{
			/// <summary>1:N annotation_owning_user</summary>
			public static readonly XrmFakedRelationship AnnotationOwningUser = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "owninguser",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "annotation",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N constraintbasedgroup_systemuser</summary>
			public static readonly XrmFakedRelationship ConstraintbasedgroupSystemuser = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "businessunitid",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "constraintbasedgroup",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N contact_owning_user</summary>
			public static readonly XrmFakedRelationship ContactOwningUser = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "owninguser",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "contact",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N createdby_connection</summary>
			public static readonly XrmFakedRelationship CreatedbyConnection = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "createdby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "connection",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N createdby_connection_role</summary>
			public static readonly XrmFakedRelationship CreatedbyConnectionRole = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "createdby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "connectionrole",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N createdby_pluginassembly</summary>
			public static readonly XrmFakedRelationship CreatedbyPluginassembly = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "createdby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "pluginassembly",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N createdby_plugintracelog</summary>
			public static readonly XrmFakedRelationship CreatedbyPlugintracelog = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "createdby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "plugintracelog",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N createdby_plugintype</summary>
			public static readonly XrmFakedRelationship CreatedbyPlugintype = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "createdby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "plugintype",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N createdby_plugintypestatistic</summary>
			public static readonly XrmFakedRelationship CreatedbyPlugintypestatistic = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "createdby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "plugintypestatistic",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N createdby_sdkmessage</summary>
			public static readonly XrmFakedRelationship CreatedbySdkmessage = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "createdby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "sdkmessage",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N createdby_sdkmessagefilter</summary>
			public static readonly XrmFakedRelationship CreatedbySdkmessagefilter = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "createdby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "sdkmessagefilter",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N createdby_sdkmessageprocessingstep</summary>
			public static readonly XrmFakedRelationship CreatedbySdkmessageprocessingstep = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "createdby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "sdkmessageprocessingstep",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N createdby_sdkmessageprocessingstepimage</summary>
			public static readonly XrmFakedRelationship CreatedbySdkmessageprocessingstepimage = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "createdby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "sdkmessageprocessingstepimage",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N createdby_sdkmessageprocessingstepsecureconfig</summary>
			public static readonly XrmFakedRelationship CreatedbySdkmessageprocessingstepsecureconfig = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "createdby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "sdkmessageprocessingstepsecureconfig",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N createdby_serviceendpoint</summary>
			public static readonly XrmFakedRelationship CreatedbyServiceendpoint = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "createdby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "serviceendpoint",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N Dynamicpropertyinsatance_createdby</summary>
			public static readonly XrmFakedRelationship DynamicpropertyinsatanceCreatedby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "createdby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "dynamicpropertyinstance",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N equipment_systemuser</summary>
			public static readonly XrmFakedRelationship EquipmentSystemuser = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "businessunitid",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "equipment",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N impersonatinguserid_sdkmessageprocessingstep</summary>
			public static readonly XrmFakedRelationship ImpersonatinguseridSdkmessageprocessingstep = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "impersonatinguserid",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "sdkmessageprocessingstep",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N ImportFile_SystemUser</summary>
			public static readonly XrmFakedRelationship ImportFileSystemUser = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "recordsownerid",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "importfile",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N knowledgearticle_primaryauthorid</summary>
			public static readonly XrmFakedRelationship KnowledgearticlePrimaryauthorid = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "primaryauthorid",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "knowledgearticle",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lead_owning_user</summary>
			public static readonly XrmFakedRelationship LeadOwningUser = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "owninguser",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "lead",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_accountbase_createdby</summary>
			public static readonly XrmFakedRelationship LkAccountbaseCreatedby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "createdby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "account",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_accountbase_createdonbehalfby</summary>
			public static readonly XrmFakedRelationship LkAccountbaseCreatedonbehalfby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "createdonbehalfby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "account",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_accountbase_modifiedby</summary>
			public static readonly XrmFakedRelationship LkAccountbaseModifiedby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "modifiedby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "account",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_accountbase_modifiedonbehalfby</summary>
			public static readonly XrmFakedRelationship LkAccountbaseModifiedonbehalfby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "modifiedonbehalfby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "account",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_ACIViewMapper_createdby</summary>
			public static readonly XrmFakedRelationship LkACIViewMapperCreatedby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "createdby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "aciviewmapper",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_ACIViewMapper_createdonbehalfby</summary>
			public static readonly XrmFakedRelationship LkACIViewMapperCreatedonbehalfby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "createdonbehalfby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "aciviewmapper",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_ACIViewMapper_modifiedby</summary>
			public static readonly XrmFakedRelationship LkACIViewMapperModifiedby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "modifiedby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "aciviewmapper",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_ACIViewMapper_modifiedonbehalfby</summary>
			public static readonly XrmFakedRelationship LkACIViewMapperModifiedonbehalfby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "modifiedonbehalfby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "aciviewmapper",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_actioncardbase_createdby</summary>
			public static readonly XrmFakedRelationship LkActioncardbaseCreatedby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "createdby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "actioncard",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_actioncardbase_createdonbehalfby</summary>
			public static readonly XrmFakedRelationship LkActioncardbaseCreatedonbehalfby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "createdonbehalfby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "actioncard",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_actioncardbase_modifiedby</summary>
			public static readonly XrmFakedRelationship LkActioncardbaseModifiedby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "modifiedby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "actioncard",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_actioncardbase_modifiedonbehalfby</summary>
			public static readonly XrmFakedRelationship LkActioncardbaseModifiedonbehalfby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "modifiedonbehalfby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "actioncard",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_activitymonitor_createdby</summary>
			public static readonly XrmFakedRelationship LkActivitymonitorCreatedby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "createdby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "activitymonitor",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_activitymonitor_createdonbehalfby</summary>
			public static readonly XrmFakedRelationship LkActivitymonitorCreatedonbehalfby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "createdonbehalfby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "activitymonitor",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_activitymonitor_modifiedby</summary>
			public static readonly XrmFakedRelationship LkActivitymonitorModifiedby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "modifiedby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "activitymonitor",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_activitymonitor_modifiedonbehalfby</summary>
			public static readonly XrmFakedRelationship LkActivitymonitorModifiedonbehalfby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "modifiedonbehalfby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "activitymonitor",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_activitypointer_createdby</summary>
			public static readonly XrmFakedRelationship LkActivitypointerCreatedby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "createdby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "activitypointer",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_activitypointer_createdonbehalfby</summary>
			public static readonly XrmFakedRelationship LkActivitypointerCreatedonbehalfby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "createdonbehalfby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "activitypointer",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_activitypointer_modifiedby</summary>
			public static readonly XrmFakedRelationship LkActivitypointerModifiedby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "modifiedby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "activitypointer",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_activitypointer_modifiedonbehalfby</summary>
			public static readonly XrmFakedRelationship LkActivitypointerModifiedonbehalfby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "modifiedonbehalfby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "activitypointer",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_adminsettingsentity_createdby</summary>
			public static readonly XrmFakedRelationship LkAdminsettingsentityCreatedby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "createdby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "adminsettingsentity",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_adminsettingsentity_createdonbehalfby</summary>
			public static readonly XrmFakedRelationship LkAdminsettingsentityCreatedonbehalfby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "createdonbehalfby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "adminsettingsentity",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_adminsettingsentity_modifiedby</summary>
			public static readonly XrmFakedRelationship LkAdminsettingsentityModifiedby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "modifiedby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "adminsettingsentity",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_adminsettingsentity_modifiedonbehalfby</summary>
			public static readonly XrmFakedRelationship LkAdminsettingsentityModifiedonbehalfby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "modifiedonbehalfby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "adminsettingsentity",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_annotationbase_createdby</summary>
			public static readonly XrmFakedRelationship LkAnnotationbaseCreatedby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "createdby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "annotation",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_annotationbase_createdonbehalfby</summary>
			public static readonly XrmFakedRelationship LkAnnotationbaseCreatedonbehalfby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "createdonbehalfby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "annotation",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_annotationbase_modifiedby</summary>
			public static readonly XrmFakedRelationship LkAnnotationbaseModifiedby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "modifiedby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "annotation",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_annotationbase_modifiedonbehalfby</summary>
			public static readonly XrmFakedRelationship LkAnnotationbaseModifiedonbehalfby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "modifiedonbehalfby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "annotation",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_annualfiscalcalendar_createdby</summary>
			public static readonly XrmFakedRelationship LkAnnualfiscalcalendarCreatedby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "createdby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "annualfiscalcalendar",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_annualfiscalcalendar_createdonbehalfby</summary>
			public static readonly XrmFakedRelationship LkAnnualfiscalcalendarCreatedonbehalfby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "createdonbehalfby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "annualfiscalcalendar",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_annualfiscalcalendar_modifiedby</summary>
			public static readonly XrmFakedRelationship LkAnnualfiscalcalendarModifiedby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "modifiedby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "annualfiscalcalendar",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_annualfiscalcalendar_modifiedonbehalfby</summary>
			public static readonly XrmFakedRelationship LkAnnualfiscalcalendarModifiedonbehalfby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "modifiedonbehalfby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "annualfiscalcalendar",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_annualfiscalcalendar_salespersonid</summary>
			public static readonly XrmFakedRelationship LkAnnualfiscalcalendarSalespersonid = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "salespersonid",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "annualfiscalcalendar",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_appconfig_createdby</summary>
			public static readonly XrmFakedRelationship LkAppconfigCreatedby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "createdby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "appconfig",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_appconfig_createdonbehalfby</summary>
			public static readonly XrmFakedRelationship LkAppconfigCreatedonbehalfby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "createdonbehalfby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "appconfig",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_appconfig_modifiedby</summary>
			public static readonly XrmFakedRelationship LkAppconfigModifiedby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "modifiedby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "appconfig",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_appconfig_modifiedonbehalfby</summary>
			public static readonly XrmFakedRelationship LkAppconfigModifiedonbehalfby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "modifiedonbehalfby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "appconfig",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_appconfiginstance_createdby</summary>
			public static readonly XrmFakedRelationship LkAppconfiginstanceCreatedby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "createdby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "appconfiginstance",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_appconfiginstance_createdonbehalfby</summary>
			public static readonly XrmFakedRelationship LkAppconfiginstanceCreatedonbehalfby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "createdonbehalfby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "appconfiginstance",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_appconfiginstance_modifiedby</summary>
			public static readonly XrmFakedRelationship LkAppconfiginstanceModifiedby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "modifiedby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "appconfiginstance",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_appconfiginstance_modifiedonbehalfby</summary>
			public static readonly XrmFakedRelationship LkAppconfiginstanceModifiedonbehalfby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "modifiedonbehalfby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "appconfiginstance",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_appconfigmaster_createdby</summary>
			public static readonly XrmFakedRelationship LkAppconfigmasterCreatedby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "createdby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "appconfigmaster",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_appconfigmaster_createdonbehalfby</summary>
			public static readonly XrmFakedRelationship LkAppconfigmasterCreatedonbehalfby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "createdonbehalfby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "appconfigmaster",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_appconfigmaster_modifiedby</summary>
			public static readonly XrmFakedRelationship LkAppconfigmasterModifiedby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "modifiedby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "appconfigmaster",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_appconfigmaster_modifiedonbehalfby</summary>
			public static readonly XrmFakedRelationship LkAppconfigmasterModifiedonbehalfby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "modifiedonbehalfby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "appconfigmaster",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_appmodule_createdby</summary>
			public static readonly XrmFakedRelationship LkAppmoduleCreatedby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "createdby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "appmodule",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_appmodule_createdonbehalfby</summary>
			public static readonly XrmFakedRelationship LkAppmoduleCreatedonbehalfby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "createdonbehalfby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "appmodule",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_appmodule_modifiedby</summary>
			public static readonly XrmFakedRelationship LkAppmoduleModifiedby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "modifiedby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "appmodule",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_appmodule_modifiedonbehalfby</summary>
			public static readonly XrmFakedRelationship LkAppmoduleModifiedonbehalfby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "modifiedonbehalfby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "appmodule",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_appmodulecomponent_createdby</summary>
			public static readonly XrmFakedRelationship LkAppmodulecomponentCreatedby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "createdby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "appmodulecomponent",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_appmodulecomponent_createdonbehalfby</summary>
			public static readonly XrmFakedRelationship LkAppmodulecomponentCreatedonbehalfby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "createdonbehalfby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "appmodulecomponent",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_appmodulecomponent_modifiedby</summary>
			public static readonly XrmFakedRelationship LkAppmodulecomponentModifiedby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "modifiedby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "appmodulecomponent",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_appmodulecomponent_modifiedonbehalfby</summary>
			public static readonly XrmFakedRelationship LkAppmodulecomponentModifiedonbehalfby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "modifiedonbehalfby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "appmodulecomponent",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_appointment_createdby</summary>
			public static readonly XrmFakedRelationship LkAppointmentCreatedby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "createdby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "appointment",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_appointment_createdonbehalfby</summary>
			public static readonly XrmFakedRelationship LkAppointmentCreatedonbehalfby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "createdonbehalfby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "appointment",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_appointment_modifiedby</summary>
			public static readonly XrmFakedRelationship LkAppointmentModifiedby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "modifiedby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "appointment",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_appointment_modifiedonbehalfby</summary>
			public static readonly XrmFakedRelationship LkAppointmentModifiedonbehalfby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "modifiedonbehalfby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "appointment",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_asyncoperation_createdby</summary>
			public static readonly XrmFakedRelationship LkAsyncoperationCreatedby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "createdby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "asyncoperation",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_asyncoperation_createdonbehalfby</summary>
			public static readonly XrmFakedRelationship LkAsyncoperationCreatedonbehalfby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "createdonbehalfby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "asyncoperation",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_asyncoperation_modifiedby</summary>
			public static readonly XrmFakedRelationship LkAsyncoperationModifiedby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "modifiedby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "asyncoperation",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_asyncoperation_modifiedonbehalfby</summary>
			public static readonly XrmFakedRelationship LkAsyncoperationModifiedonbehalfby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "modifiedonbehalfby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "asyncoperation",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_audit_callinguserid</summary>
			public static readonly XrmFakedRelationship LkAuditCallinguserid = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "callinguserid",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "audit",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_audit_userid</summary>
			public static readonly XrmFakedRelationship LkAuditUserid = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "userid",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "audit",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_bookableresource_createdby</summary>
			public static readonly XrmFakedRelationship LkBookableresourceCreatedby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "createdby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "bookableresource",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_bookableresource_createdonbehalfby</summary>
			public static readonly XrmFakedRelationship LkBookableresourceCreatedonbehalfby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "createdonbehalfby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "bookableresource",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_bookableresource_modifiedby</summary>
			public static readonly XrmFakedRelationship LkBookableresourceModifiedby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "modifiedby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "bookableresource",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_bookableresource_modifiedonbehalfby</summary>
			public static readonly XrmFakedRelationship LkBookableresourceModifiedonbehalfby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "modifiedonbehalfby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "bookableresource",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_bookableresourcebooking_createdby</summary>
			public static readonly XrmFakedRelationship LkBookableresourcebookingCreatedby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "createdby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "bookableresourcebooking",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_bookableresourcebooking_createdonbehalfby</summary>
			public static readonly XrmFakedRelationship LkBookableresourcebookingCreatedonbehalfby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "createdonbehalfby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "bookableresourcebooking",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_bookableresourcebooking_modifiedby</summary>
			public static readonly XrmFakedRelationship LkBookableresourcebookingModifiedby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "modifiedby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "bookableresourcebooking",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_bookableresourcebooking_modifiedonbehalfby</summary>
			public static readonly XrmFakedRelationship LkBookableresourcebookingModifiedonbehalfby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "modifiedonbehalfby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "bookableresourcebooking",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_bookableresourcebookingheader_createdby</summary>
			public static readonly XrmFakedRelationship LkBookableresourcebookingheaderCreatedby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "createdby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "bookableresourcebookingheader",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_bookableresourcebookingheader_createdonbehalfby</summary>
			public static readonly XrmFakedRelationship LkBookableresourcebookingheaderCreatedonbehalfby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "createdonbehalfby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "bookableresourcebookingheader",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_bookableresourcebookingheader_modifiedby</summary>
			public static readonly XrmFakedRelationship LkBookableresourcebookingheaderModifiedby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "modifiedby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "bookableresourcebookingheader",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_bookableresourcebookingheader_modifiedonbehalfby</summary>
			public static readonly XrmFakedRelationship LkBookableresourcebookingheaderModifiedonbehalfby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "modifiedonbehalfby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "bookableresourcebookingheader",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_bookableresourcecategory_createdby</summary>
			public static readonly XrmFakedRelationship LkBookableresourcecategoryCreatedby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "createdby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "bookableresourcecategory",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_bookableresourcecategory_createdonbehalfby</summary>
			public static readonly XrmFakedRelationship LkBookableresourcecategoryCreatedonbehalfby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "createdonbehalfby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "bookableresourcecategory",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_bookableresourcecategory_modifiedby</summary>
			public static readonly XrmFakedRelationship LkBookableresourcecategoryModifiedby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "modifiedby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "bookableresourcecategory",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_bookableresourcecategory_modifiedonbehalfby</summary>
			public static readonly XrmFakedRelationship LkBookableresourcecategoryModifiedonbehalfby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "modifiedonbehalfby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "bookableresourcecategory",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_bookableresourcecategoryassn_createdby</summary>
			public static readonly XrmFakedRelationship LkBookableresourcecategoryassnCreatedby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "createdby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "bookableresourcecategoryassn",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_bookableresourcecategoryassn_createdonbehalfby</summary>
			public static readonly XrmFakedRelationship LkBookableresourcecategoryassnCreatedonbehalfby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "createdonbehalfby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "bookableresourcecategoryassn",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_bookableresourcecategoryassn_modifiedby</summary>
			public static readonly XrmFakedRelationship LkBookableresourcecategoryassnModifiedby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "modifiedby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "bookableresourcecategoryassn",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_bookableresourcecategoryassn_modifiedonbehalfby</summary>
			public static readonly XrmFakedRelationship LkBookableresourcecategoryassnModifiedonbehalfby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "modifiedonbehalfby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "bookableresourcecategoryassn",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_bookableresourcecharacteristic_createdby</summary>
			public static readonly XrmFakedRelationship LkBookableresourcecharacteristicCreatedby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "createdby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "bookableresourcecharacteristic",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_bookableresourcecharacteristic_createdonbehalfby</summary>
			public static readonly XrmFakedRelationship LkBookableresourcecharacteristicCreatedonbehalfby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "createdonbehalfby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "bookableresourcecharacteristic",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_bookableresourcecharacteristic_modifiedby</summary>
			public static readonly XrmFakedRelationship LkBookableresourcecharacteristicModifiedby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "modifiedby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "bookableresourcecharacteristic",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_bookableresourcecharacteristic_modifiedonbehalfby</summary>
			public static readonly XrmFakedRelationship LkBookableresourcecharacteristicModifiedonbehalfby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "modifiedonbehalfby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "bookableresourcecharacteristic",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_bookableresourcegroup_createdby</summary>
			public static readonly XrmFakedRelationship LkBookableresourcegroupCreatedby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "createdby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "bookableresourcegroup",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_bookableresourcegroup_createdonbehalfby</summary>
			public static readonly XrmFakedRelationship LkBookableresourcegroupCreatedonbehalfby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "createdonbehalfby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "bookableresourcegroup",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_bookableresourcegroup_modifiedby</summary>
			public static readonly XrmFakedRelationship LkBookableresourcegroupModifiedby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "modifiedby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "bookableresourcegroup",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_bookableresourcegroup_modifiedonbehalfby</summary>
			public static readonly XrmFakedRelationship LkBookableresourcegroupModifiedonbehalfby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "modifiedonbehalfby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "bookableresourcegroup",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_bookingstatus_createdby</summary>
			public static readonly XrmFakedRelationship LkBookingstatusCreatedby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "createdby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "bookingstatus",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_bookingstatus_createdonbehalfby</summary>
			public static readonly XrmFakedRelationship LkBookingstatusCreatedonbehalfby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "createdonbehalfby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "bookingstatus",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_bookingstatus_modifiedby</summary>
			public static readonly XrmFakedRelationship LkBookingstatusModifiedby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "modifiedby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "bookingstatus",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_bookingstatus_modifiedonbehalfby</summary>
			public static readonly XrmFakedRelationship LkBookingstatusModifiedonbehalfby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "modifiedonbehalfby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "bookingstatus",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_bot_createdby</summary>
			public static readonly XrmFakedRelationship LkBotCreatedby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "createdby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "bot",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_bot_createdonbehalfby</summary>
			public static readonly XrmFakedRelationship LkBotCreatedonbehalfby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "createdonbehalfby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "bot",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_bot_modifiedby</summary>
			public static readonly XrmFakedRelationship LkBotModifiedby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "modifiedby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "bot",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_bot_modifiedonbehalfby</summary>
			public static readonly XrmFakedRelationship LkBotModifiedonbehalfby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "modifiedonbehalfby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "bot",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_botcomponent_createdby</summary>
			public static readonly XrmFakedRelationship LkBotcomponentCreatedby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "createdby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "botcomponent",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_botcomponent_createdonbehalfby</summary>
			public static readonly XrmFakedRelationship LkBotcomponentCreatedonbehalfby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "createdonbehalfby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "botcomponent",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_botcomponent_modifiedby</summary>
			public static readonly XrmFakedRelationship LkBotcomponentModifiedby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "modifiedby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "botcomponent",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_botcomponent_modifiedonbehalfby</summary>
			public static readonly XrmFakedRelationship LkBotcomponentModifiedonbehalfby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "modifiedonbehalfby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "botcomponent",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_bulkdeleteoperation_createdonbehalfby</summary>
			public static readonly XrmFakedRelationship LkBulkdeleteoperationCreatedonbehalfby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "createdonbehalfby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "bulkdeleteoperation",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_bulkdeleteoperation_modifiedonbehalfby</summary>
			public static readonly XrmFakedRelationship LkBulkdeleteoperationModifiedonbehalfby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "modifiedonbehalfby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "bulkdeleteoperation",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_bulkdeleteoperationbase_createdby</summary>
			public static readonly XrmFakedRelationship LkBulkdeleteoperationbaseCreatedby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "createdby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "bulkdeleteoperation",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_bulkdeleteoperationbase_modifiedby</summary>
			public static readonly XrmFakedRelationship LkBulkdeleteoperationbaseModifiedby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "modifiedby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "bulkdeleteoperation",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_BulkOperation_createdby</summary>
			public static readonly XrmFakedRelationship LkBulkOperationCreatedby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "createdby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "bulkoperation",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_BulkOperation_createdonbehalfby</summary>
			public static readonly XrmFakedRelationship LkBulkOperationCreatedonbehalfby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "createdonbehalfby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "bulkoperation",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_BulkOperation_modifiedby</summary>
			public static readonly XrmFakedRelationship LkBulkOperationModifiedby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "modifiedby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "bulkoperation",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_BulkOperation_modifiedonbehalfby</summary>
			public static readonly XrmFakedRelationship LkBulkOperationModifiedonbehalfby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "modifiedonbehalfby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "bulkoperation",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_businessunit_createdonbehalfby</summary>
			public static readonly XrmFakedRelationship LkBusinessunitCreatedonbehalfby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "createdonbehalfby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "businessunit",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_businessunit_modifiedonbehalfby</summary>
			public static readonly XrmFakedRelationship LkBusinessunitModifiedonbehalfby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "modifiedonbehalfby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "businessunit",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_businessunitbase_createdby</summary>
			public static readonly XrmFakedRelationship LkBusinessunitbaseCreatedby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "createdby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "businessunit",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_businessunitbase_modifiedby</summary>
			public static readonly XrmFakedRelationship LkBusinessunitbaseModifiedby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "modifiedby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "businessunit",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_businessunitnewsarticle_createdonbehalfby</summary>
			public static readonly XrmFakedRelationship LkBusinessunitnewsarticleCreatedonbehalfby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "createdonbehalfby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "businessunitnewsarticle",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_businessunitnewsarticle_modifiedonbehalfby</summary>
			public static readonly XrmFakedRelationship LkBusinessunitnewsarticleModifiedonbehalfby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "modifiedonbehalfby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "businessunitnewsarticle",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_businessunitnewsarticlebase_createdby</summary>
			public static readonly XrmFakedRelationship LkBusinessunitnewsarticlebaseCreatedby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "createdby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "businessunitnewsarticle",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_businessunitnewsarticlebase_modifiedby</summary>
			public static readonly XrmFakedRelationship LkBusinessunitnewsarticlebaseModifiedby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "modifiedby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "businessunitnewsarticle",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_calendar_createdby</summary>
			public static readonly XrmFakedRelationship LkCalendarCreatedby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "createdby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "calendar",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_calendar_createdonbehalfby</summary>
			public static readonly XrmFakedRelationship LkCalendarCreatedonbehalfby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "createdonbehalfby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "calendar",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_calendar_modifiedby</summary>
			public static readonly XrmFakedRelationship LkCalendarModifiedby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "modifiedby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "calendar",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_calendar_modifiedonbehalfby</summary>
			public static readonly XrmFakedRelationship LkCalendarModifiedonbehalfby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "modifiedonbehalfby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "calendar",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_callbackregistration_createdby</summary>
			public static readonly XrmFakedRelationship LkCallbackregistrationCreatedby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "createdby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "callbackregistration",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_callbackregistration_createdonbehalfby</summary>
			public static readonly XrmFakedRelationship LkCallbackregistrationCreatedonbehalfby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "createdonbehalfby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "callbackregistration",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_callbackregistration_modifiedby</summary>
			public static readonly XrmFakedRelationship LkCallbackregistrationModifiedby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "modifiedby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "callbackregistration",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_callbackregistration_modifiedonbehalfby</summary>
			public static readonly XrmFakedRelationship LkCallbackregistrationModifiedonbehalfby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "modifiedonbehalfby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "callbackregistration",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_campaign_createdby</summary>
			public static readonly XrmFakedRelationship LkCampaignCreatedby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "createdby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "campaign",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_campaign_createdonbehalfby</summary>
			public static readonly XrmFakedRelationship LkCampaignCreatedonbehalfby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "createdonbehalfby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "campaign",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_campaign_modifiedby</summary>
			public static readonly XrmFakedRelationship LkCampaignModifiedby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "modifiedby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "campaign",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_campaign_modifiedonbehalfby</summary>
			public static readonly XrmFakedRelationship LkCampaignModifiedonbehalfby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "modifiedonbehalfby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "campaign",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_campaignactivity_createdby</summary>
			public static readonly XrmFakedRelationship LkCampaignactivityCreatedby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "createdby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "campaignactivity",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_campaignactivity_createdonbehalfby</summary>
			public static readonly XrmFakedRelationship LkCampaignactivityCreatedonbehalfby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "createdonbehalfby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "campaignactivity",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_campaignactivity_modifiedby</summary>
			public static readonly XrmFakedRelationship LkCampaignactivityModifiedby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "modifiedby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "campaignactivity",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_campaignactivity_modifiedonbehalfby</summary>
			public static readonly XrmFakedRelationship LkCampaignactivityModifiedonbehalfby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "modifiedonbehalfby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "campaignactivity",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_campaignresponse_createdby</summary>
			public static readonly XrmFakedRelationship LkCampaignresponseCreatedby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "createdby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "campaignresponse",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_campaignresponse_createdonbehalfby</summary>
			public static readonly XrmFakedRelationship LkCampaignresponseCreatedonbehalfby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "createdonbehalfby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "campaignresponse",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_campaignresponse_modifiedby</summary>
			public static readonly XrmFakedRelationship LkCampaignresponseModifiedby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "modifiedby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "campaignresponse",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_campaignresponse_modifiedonbehalfby</summary>
			public static readonly XrmFakedRelationship LkCampaignresponseModifiedonbehalfby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "modifiedonbehalfby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "campaignresponse",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_catalog_createdby</summary>
			public static readonly XrmFakedRelationship LkCatalogCreatedby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "createdby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "catalog",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_catalog_createdonbehalfby</summary>
			public static readonly XrmFakedRelationship LkCatalogCreatedonbehalfby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "createdonbehalfby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "catalog",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_catalog_modifiedby</summary>
			public static readonly XrmFakedRelationship LkCatalogModifiedby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "modifiedby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "catalog",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_catalog_modifiedonbehalfby</summary>
			public static readonly XrmFakedRelationship LkCatalogModifiedonbehalfby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "modifiedonbehalfby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "catalog",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_catalogassignment_createdby</summary>
			public static readonly XrmFakedRelationship LkCatalogassignmentCreatedby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "createdby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "catalogassignment",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_catalogassignment_createdonbehalfby</summary>
			public static readonly XrmFakedRelationship LkCatalogassignmentCreatedonbehalfby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "createdonbehalfby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "catalogassignment",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_catalogassignment_modifiedby</summary>
			public static readonly XrmFakedRelationship LkCatalogassignmentModifiedby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "modifiedby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "catalogassignment",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_catalogassignment_modifiedonbehalfby</summary>
			public static readonly XrmFakedRelationship LkCatalogassignmentModifiedonbehalfby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "modifiedonbehalfby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "catalogassignment",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_category_createdby</summary>
			public static readonly XrmFakedRelationship LkCategoryCreatedby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "createdby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "category",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_category_createdonbehalfby</summary>
			public static readonly XrmFakedRelationship LkCategoryCreatedonbehalfby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "createdonbehalfby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "category",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_category_modifiedby</summary>
			public static readonly XrmFakedRelationship LkCategoryModifiedby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "modifiedby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "category",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_category_modifiedonbehalfby</summary>
			public static readonly XrmFakedRelationship LkCategoryModifiedonbehalfby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "modifiedonbehalfby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "category",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_characteristic_createdby</summary>
			public static readonly XrmFakedRelationship LkCharacteristicCreatedby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "createdby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "characteristic",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_characteristic_createdonbehalfby</summary>
			public static readonly XrmFakedRelationship LkCharacteristicCreatedonbehalfby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "createdonbehalfby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "characteristic",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_characteristic_modifiedby</summary>
			public static readonly XrmFakedRelationship LkCharacteristicModifiedby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "modifiedby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "characteristic",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_characteristic_modifiedonbehalfby</summary>
			public static readonly XrmFakedRelationship LkCharacteristicModifiedonbehalfby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "modifiedonbehalfby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "characteristic",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_columnmapping_createdby</summary>
			public static readonly XrmFakedRelationship LkColumnmappingCreatedby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "createdby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "columnmapping",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_columnmapping_createdonbehalfby</summary>
			public static readonly XrmFakedRelationship LkColumnmappingCreatedonbehalfby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "createdonbehalfby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "columnmapping",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_columnmapping_modifiedby</summary>
			public static readonly XrmFakedRelationship LkColumnmappingModifiedby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "modifiedby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "columnmapping",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_columnmapping_modifiedonbehalfby</summary>
			public static readonly XrmFakedRelationship LkColumnmappingModifiedonbehalfby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "modifiedonbehalfby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "columnmapping",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_competitor_createdonbehalfby</summary>
			public static readonly XrmFakedRelationship LkCompetitorCreatedonbehalfby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "createdonbehalfby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "competitor",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_competitor_modifiedonbehalfby</summary>
			public static readonly XrmFakedRelationship LkCompetitorModifiedonbehalfby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "modifiedonbehalfby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "competitor",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_competitoraddress_createdonbehalfby</summary>
			public static readonly XrmFakedRelationship LkCompetitoraddressCreatedonbehalfby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "createdonbehalfby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "competitoraddress",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_competitoraddress_modifiedonbehalfby</summary>
			public static readonly XrmFakedRelationship LkCompetitoraddressModifiedonbehalfby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "modifiedonbehalfby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "competitoraddress",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_competitoraddressbase_createdby</summary>
			public static readonly XrmFakedRelationship LkCompetitoraddressbaseCreatedby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "createdby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "competitoraddress",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_competitoraddressbase_modifiedby</summary>
			public static readonly XrmFakedRelationship LkCompetitoraddressbaseModifiedby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "modifiedby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "competitoraddress",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_competitorbase_createdby</summary>
			public static readonly XrmFakedRelationship LkCompetitorbaseCreatedby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "createdby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "competitor",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_competitorbase_modifiedby</summary>
			public static readonly XrmFakedRelationship LkCompetitorbaseModifiedby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "modifiedby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "competitor",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_connectionbase_createdonbehalfby</summary>
			public static readonly XrmFakedRelationship LkConnectionbaseCreatedonbehalfby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "createdonbehalfby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "connection",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_connectionbase_modifiedonbehalfby</summary>
			public static readonly XrmFakedRelationship LkConnectionbaseModifiedonbehalfby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "modifiedonbehalfby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "connection",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_connectionreference_createdby</summary>
			public static readonly XrmFakedRelationship LkConnectionreferenceCreatedby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "createdby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "connectionreference",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_connectionreference_createdonbehalfby</summary>
			public static readonly XrmFakedRelationship LkConnectionreferenceCreatedonbehalfby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "createdonbehalfby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "connectionreference",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_connectionreference_modifiedby</summary>
			public static readonly XrmFakedRelationship LkConnectionreferenceModifiedby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "modifiedby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "connectionreference",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_connectionreference_modifiedonbehalfby</summary>
			public static readonly XrmFakedRelationship LkConnectionreferenceModifiedonbehalfby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "modifiedonbehalfby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "connectionreference",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_connectionrolebase_createdonbehalfby</summary>
			public static readonly XrmFakedRelationship LkConnectionrolebaseCreatedonbehalfby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "createdonbehalfby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "connectionrole",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_connectionrolebase_modifiedonbehalfby</summary>
			public static readonly XrmFakedRelationship LkConnectionrolebaseModifiedonbehalfby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "modifiedonbehalfby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "connectionrole",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_connector_createdby</summary>
			public static readonly XrmFakedRelationship LkConnectorCreatedby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "createdby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "connector",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_connector_createdonbehalfby</summary>
			public static readonly XrmFakedRelationship LkConnectorCreatedonbehalfby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "createdonbehalfby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "connector",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_connector_modifiedby</summary>
			public static readonly XrmFakedRelationship LkConnectorModifiedby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "modifiedby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "connector",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_connector_modifiedonbehalfby</summary>
			public static readonly XrmFakedRelationship LkConnectorModifiedonbehalfby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "modifiedonbehalfby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "connector",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_constraintbasedgroup_createdby</summary>
			public static readonly XrmFakedRelationship LkConstraintbasedgroupCreatedby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "createdby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "constraintbasedgroup",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_constraintbasedgroup_createdonbehalfby</summary>
			public static readonly XrmFakedRelationship LkConstraintbasedgroupCreatedonbehalfby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "createdonbehalfby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "constraintbasedgroup",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_constraintbasedgroup_modifiedby</summary>
			public static readonly XrmFakedRelationship LkConstraintbasedgroupModifiedby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "modifiedby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "constraintbasedgroup",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_constraintbasedgroup_modifiedonbehalfby</summary>
			public static readonly XrmFakedRelationship LkConstraintbasedgroupModifiedonbehalfby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "modifiedonbehalfby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "constraintbasedgroup",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_contact_createdonbehalfby</summary>
			public static readonly XrmFakedRelationship LkContactCreatedonbehalfby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "createdonbehalfby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "contact",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_contact_modifiedonbehalfby</summary>
			public static readonly XrmFakedRelationship LkContactModifiedonbehalfby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "modifiedonbehalfby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "contact",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_contactbase_createdby</summary>
			public static readonly XrmFakedRelationship LkContactbaseCreatedby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "createdby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "contact",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_contactbase_modifiedby</summary>
			public static readonly XrmFakedRelationship LkContactbaseModifiedby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "modifiedby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "contact",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_contract_createdonbehalfby</summary>
			public static readonly XrmFakedRelationship LkContractCreatedonbehalfby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "createdonbehalfby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "contract",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_contract_modifiedonbehalfby</summary>
			public static readonly XrmFakedRelationship LkContractModifiedonbehalfby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "modifiedonbehalfby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "contract",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_contractbase_createdby</summary>
			public static readonly XrmFakedRelationship LkContractbaseCreatedby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "createdby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "contract",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_contractbase_modifiedby</summary>
			public static readonly XrmFakedRelationship LkContractbaseModifiedby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "modifiedby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "contract",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_contractdetail_createdonbehalfby</summary>
			public static readonly XrmFakedRelationship LkContractdetailCreatedonbehalfby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "createdonbehalfby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "contractdetail",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_contractdetail_modifiedonbehalfby</summary>
			public static readonly XrmFakedRelationship LkContractdetailModifiedonbehalfby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "modifiedonbehalfby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "contractdetail",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_contractdetailbase_createdby</summary>
			public static readonly XrmFakedRelationship LkContractdetailbaseCreatedby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "createdby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "contractdetail",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_contractdetailbase_modifiedby</summary>
			public static readonly XrmFakedRelationship LkContractdetailbaseModifiedby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "modifiedby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "contractdetail",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_contracttemplate_createdonbehalfby</summary>
			public static readonly XrmFakedRelationship LkContracttemplateCreatedonbehalfby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "createdonbehalfby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "contracttemplate",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_contracttemplate_modifiedonbehalfby</summary>
			public static readonly XrmFakedRelationship LkContracttemplateModifiedonbehalfby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "modifiedonbehalfby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "contracttemplate",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_contracttemplatebase_createdby</summary>
			public static readonly XrmFakedRelationship LkContracttemplatebaseCreatedby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "createdby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "contracttemplate",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_contracttemplatebase_modifiedby</summary>
			public static readonly XrmFakedRelationship LkContracttemplatebaseModifiedby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "modifiedby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "contracttemplate",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_conversationtranscript_createdby</summary>
			public static readonly XrmFakedRelationship LkConversationtranscriptCreatedby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "createdby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "conversationtranscript",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_conversationtranscript_createdonbehalfby</summary>
			public static readonly XrmFakedRelationship LkConversationtranscriptCreatedonbehalfby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "createdonbehalfby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "conversationtranscript",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_conversationtranscript_modifiedby</summary>
			public static readonly XrmFakedRelationship LkConversationtranscriptModifiedby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "modifiedby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "conversationtranscript",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_conversationtranscript_modifiedonbehalfby</summary>
			public static readonly XrmFakedRelationship LkConversationtranscriptModifiedonbehalfby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "modifiedonbehalfby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "conversationtranscript",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_customapi_createdby</summary>
			public static readonly XrmFakedRelationship LkCustomapiCreatedby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "createdby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "customapi",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_customapi_createdonbehalfby</summary>
			public static readonly XrmFakedRelationship LkCustomapiCreatedonbehalfby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "createdonbehalfby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "customapi",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_customapi_modifiedby</summary>
			public static readonly XrmFakedRelationship LkCustomapiModifiedby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "modifiedby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "customapi",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_customapi_modifiedonbehalfby</summary>
			public static readonly XrmFakedRelationship LkCustomapiModifiedonbehalfby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "modifiedonbehalfby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "customapi",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_customapirequestparameter_createdby</summary>
			public static readonly XrmFakedRelationship LkCustomapirequestparameterCreatedby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "createdby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "customapirequestparameter",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_customapirequestparameter_createdonbehalfby</summary>
			public static readonly XrmFakedRelationship LkCustomapirequestparameterCreatedonbehalfby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "createdonbehalfby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "customapirequestparameter",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_customapirequestparameter_modifiedby</summary>
			public static readonly XrmFakedRelationship LkCustomapirequestparameterModifiedby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "modifiedby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "customapirequestparameter",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_customapirequestparameter_modifiedonbehalfby</summary>
			public static readonly XrmFakedRelationship LkCustomapirequestparameterModifiedonbehalfby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "modifiedonbehalfby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "customapirequestparameter",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_customapiresponseproperty_createdby</summary>
			public static readonly XrmFakedRelationship LkCustomapiresponsepropertyCreatedby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "createdby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "customapiresponseproperty",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_customapiresponseproperty_createdonbehalfby</summary>
			public static readonly XrmFakedRelationship LkCustomapiresponsepropertyCreatedonbehalfby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "createdonbehalfby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "customapiresponseproperty",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_customapiresponseproperty_modifiedby</summary>
			public static readonly XrmFakedRelationship LkCustomapiresponsepropertyModifiedby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "modifiedby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "customapiresponseproperty",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_customapiresponseproperty_modifiedonbehalfby</summary>
			public static readonly XrmFakedRelationship LkCustomapiresponsepropertyModifiedonbehalfby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "modifiedonbehalfby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "customapiresponseproperty",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_customcontrol_createdby</summary>
			public static readonly XrmFakedRelationship LkCustomcontrolCreatedby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "createdby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "customcontrol",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_customcontrol_createdonbehalfby</summary>
			public static readonly XrmFakedRelationship LkCustomcontrolCreatedonbehalfby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "createdonbehalfby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "customcontrol",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_customcontrol_modifiedby</summary>
			public static readonly XrmFakedRelationship LkCustomcontrolModifiedby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "modifiedby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "customcontrol",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_customcontrol_modifiedonbehalfby</summary>
			public static readonly XrmFakedRelationship LkCustomcontrolModifiedonbehalfby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "modifiedonbehalfby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "customcontrol",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_customcontroldefaultconfig_createdby</summary>
			public static readonly XrmFakedRelationship LkCustomcontroldefaultconfigCreatedby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "createdby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "customcontroldefaultconfig",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_customcontroldefaultconfig_createdonbehalfby</summary>
			public static readonly XrmFakedRelationship LkCustomcontroldefaultconfigCreatedonbehalfby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "createdonbehalfby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "customcontroldefaultconfig",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_customcontroldefaultconfig_modifiedby</summary>
			public static readonly XrmFakedRelationship LkCustomcontroldefaultconfigModifiedby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "modifiedby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "customcontroldefaultconfig",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_customcontroldefaultconfig_modifiedonbehalfby</summary>
			public static readonly XrmFakedRelationship LkCustomcontroldefaultconfigModifiedonbehalfby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "modifiedonbehalfby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "customcontroldefaultconfig",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_customcontrolresource_createdby</summary>
			public static readonly XrmFakedRelationship LkCustomcontrolresourceCreatedby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "createdby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "customcontrolresource",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_customcontrolresource_createdonbehalfby</summary>
			public static readonly XrmFakedRelationship LkCustomcontrolresourceCreatedonbehalfby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "createdonbehalfby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "customcontrolresource",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_customcontrolresource_modifiedby</summary>
			public static readonly XrmFakedRelationship LkCustomcontrolresourceModifiedby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "modifiedby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "customcontrolresource",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_customcontrolresource_modifiedonbehalfby</summary>
			public static readonly XrmFakedRelationship LkCustomcontrolresourceModifiedonbehalfby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "modifiedonbehalfby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "customcontrolresource",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_customeraddress_createdonbehalfby</summary>
			public static readonly XrmFakedRelationship LkCustomeraddressCreatedonbehalfby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "createdonbehalfby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "customeraddress",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_customeraddress_modifiedonbehalfby</summary>
			public static readonly XrmFakedRelationship LkCustomeraddressModifiedonbehalfby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "modifiedonbehalfby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "customeraddress",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_customeraddressbase_createdby</summary>
			public static readonly XrmFakedRelationship LkCustomeraddressbaseCreatedby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "createdby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "customeraddress",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_customeraddressbase_modifiedby</summary>
			public static readonly XrmFakedRelationship LkCustomeraddressbaseModifiedby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "modifiedby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "customeraddress",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_datalakefolder_createdby</summary>
			public static readonly XrmFakedRelationship LkDatalakefolderCreatedby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "createdby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "datalakefolder",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_datalakefolder_createdonbehalfby</summary>
			public static readonly XrmFakedRelationship LkDatalakefolderCreatedonbehalfby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "createdonbehalfby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "datalakefolder",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_datalakefolder_modifiedby</summary>
			public static readonly XrmFakedRelationship LkDatalakefolderModifiedby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "modifiedby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "datalakefolder",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_datalakefolder_modifiedonbehalfby</summary>
			public static readonly XrmFakedRelationship LkDatalakefolderModifiedonbehalfby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "modifiedonbehalfby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "datalakefolder",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_datalakefolderpermission_createdby</summary>
			public static readonly XrmFakedRelationship LkDatalakefolderpermissionCreatedby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "createdby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "datalakefolderpermission",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_datalakefolderpermission_createdonbehalfby</summary>
			public static readonly XrmFakedRelationship LkDatalakefolderpermissionCreatedonbehalfby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "createdonbehalfby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "datalakefolderpermission",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_datalakefolderpermission_modifiedby</summary>
			public static readonly XrmFakedRelationship LkDatalakefolderpermissionModifiedby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "modifiedby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "datalakefolderpermission",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_datalakefolderpermission_modifiedonbehalfby</summary>
			public static readonly XrmFakedRelationship LkDatalakefolderpermissionModifiedonbehalfby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "modifiedonbehalfby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "datalakefolderpermission",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_datalakeworkspace_createdby</summary>
			public static readonly XrmFakedRelationship LkDatalakeworkspaceCreatedby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "createdby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "datalakeworkspace",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_datalakeworkspace_createdonbehalfby</summary>
			public static readonly XrmFakedRelationship LkDatalakeworkspaceCreatedonbehalfby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "createdonbehalfby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "datalakeworkspace",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_datalakeworkspace_modifiedby</summary>
			public static readonly XrmFakedRelationship LkDatalakeworkspaceModifiedby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "modifiedby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "datalakeworkspace",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_datalakeworkspace_modifiedonbehalfby</summary>
			public static readonly XrmFakedRelationship LkDatalakeworkspaceModifiedonbehalfby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "modifiedonbehalfby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "datalakeworkspace",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_datalakeworkspacepermission_createdby</summary>
			public static readonly XrmFakedRelationship LkDatalakeworkspacepermissionCreatedby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "createdby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "datalakeworkspacepermission",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_datalakeworkspacepermission_createdonbehalfby</summary>
			public static readonly XrmFakedRelationship LkDatalakeworkspacepermissionCreatedonbehalfby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "createdonbehalfby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "datalakeworkspacepermission",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_datalakeworkspacepermission_modifiedby</summary>
			public static readonly XrmFakedRelationship LkDatalakeworkspacepermissionModifiedby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "modifiedby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "datalakeworkspacepermission",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_datalakeworkspacepermission_modifiedonbehalfby</summary>
			public static readonly XrmFakedRelationship LkDatalakeworkspacepermissionModifiedonbehalfby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "modifiedonbehalfby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "datalakeworkspacepermission",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_discount_createdonbehalfby</summary>
			public static readonly XrmFakedRelationship LkDiscountCreatedonbehalfby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "createdonbehalfby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "discount",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_discount_modifiedonbehalfby</summary>
			public static readonly XrmFakedRelationship LkDiscountModifiedonbehalfby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "modifiedonbehalfby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "discount",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_discountbase_createdby</summary>
			public static readonly XrmFakedRelationship LkDiscountbaseCreatedby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "createdby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "discount",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_discountbase_modifiedby</summary>
			public static readonly XrmFakedRelationship LkDiscountbaseModifiedby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "modifiedby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "discount",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_discounttype_createdonbehalfby</summary>
			public static readonly XrmFakedRelationship LkDiscounttypeCreatedonbehalfby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "createdonbehalfby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "discounttype",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_discounttype_modifiedonbehalfby</summary>
			public static readonly XrmFakedRelationship LkDiscounttypeModifiedonbehalfby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "modifiedonbehalfby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "discounttype",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_discounttypebase_createdby</summary>
			public static readonly XrmFakedRelationship LkDiscounttypebaseCreatedby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "createdby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "discounttype",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_discounttypebase_modifiedby</summary>
			public static readonly XrmFakedRelationship LkDiscounttypebaseModifiedby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "modifiedby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "discounttype",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_DisplayStringbase_createdby</summary>
			public static readonly XrmFakedRelationship LkDisplayStringbaseCreatedby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "createdby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "displaystring",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_DisplayStringbase_createdonbehalfby</summary>
			public static readonly XrmFakedRelationship LkDisplayStringbaseCreatedonbehalfby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "createdonbehalfby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "displaystring",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_DisplayStringbase_modifiedby</summary>
			public static readonly XrmFakedRelationship LkDisplayStringbaseModifiedby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "modifiedby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "displaystring",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_DisplayStringbase_modifiedonbehalfby</summary>
			public static readonly XrmFakedRelationship LkDisplayStringbaseModifiedonbehalfby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "modifiedonbehalfby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "displaystring",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_documenttemplatebase_createdby</summary>
			public static readonly XrmFakedRelationship LkDocumenttemplatebaseCreatedby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "createdby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "documenttemplate",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_documenttemplatebase_createdonbehalfby</summary>
			public static readonly XrmFakedRelationship LkDocumenttemplatebaseCreatedonbehalfby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "createdonbehalfby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "documenttemplate",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_documenttemplatebase_modifiedby</summary>
			public static readonly XrmFakedRelationship LkDocumenttemplatebaseModifiedby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "modifiedby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "documenttemplate",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_documenttemplatebase_modifiedonbehalfby</summary>
			public static readonly XrmFakedRelationship LkDocumenttemplatebaseModifiedonbehalfby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "modifiedonbehalfby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "documenttemplate",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_duplicaterule_createdonbehalfby</summary>
			public static readonly XrmFakedRelationship LkDuplicateruleCreatedonbehalfby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "createdonbehalfby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "duplicaterule",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_duplicaterule_modifiedonbehalfby</summary>
			public static readonly XrmFakedRelationship LkDuplicateruleModifiedonbehalfby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "modifiedonbehalfby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "duplicaterule",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_duplicaterulebase_createdby</summary>
			public static readonly XrmFakedRelationship LkDuplicaterulebaseCreatedby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "createdby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "duplicaterule",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_duplicaterulebase_modifiedby</summary>
			public static readonly XrmFakedRelationship LkDuplicaterulebaseModifiedby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "modifiedby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "duplicaterule",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_duplicaterulecondition_createdonbehalfby</summary>
			public static readonly XrmFakedRelationship LkDuplicateruleconditionCreatedonbehalfby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "createdonbehalfby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "duplicaterulecondition",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_duplicaterulecondition_modifiedonbehalfby</summary>
			public static readonly XrmFakedRelationship LkDuplicateruleconditionModifiedonbehalfby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "modifiedonbehalfby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "duplicaterulecondition",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_duplicateruleconditionbase_createdby</summary>
			public static readonly XrmFakedRelationship LkDuplicateruleconditionbaseCreatedby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "createdby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "duplicaterulecondition",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_duplicateruleconditionbase_modifiedby</summary>
			public static readonly XrmFakedRelationship LkDuplicateruleconditionbaseModifiedby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "modifiedby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "duplicaterulecondition",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_DynamicProperty_createdby</summary>
			public static readonly XrmFakedRelationship LkDynamicPropertyCreatedby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "createdby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "dynamicproperty",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_DynamicProperty_createdonbehalfby</summary>
			public static readonly XrmFakedRelationship LkDynamicPropertyCreatedonbehalfby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "createdonbehalfby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "dynamicproperty",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_DynamicProperty_modifiedby</summary>
			public static readonly XrmFakedRelationship LkDynamicPropertyModifiedby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "modifiedby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "dynamicproperty",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_DynamicProperty_modifiedonbehalfby</summary>
			public static readonly XrmFakedRelationship LkDynamicPropertyModifiedonbehalfby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "modifiedonbehalfby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "dynamicproperty",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_DynamicPropertyAssociationattribute_createdby</summary>
			public static readonly XrmFakedRelationship LkDynamicPropertyAssociationattributeCreatedby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "createdby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "dynamicpropertyassociation",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_DynamicPropertyAssociationattribute_CreatedOnBehalfBy</summary>
			public static readonly XrmFakedRelationship LkDynamicPropertyAssociationattributeCreatedOnBehalfBy = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "createdonbehalfby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "dynamicpropertyassociation",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_DynamicPropertyAssociationattribute_ModifiedBy</summary>
			public static readonly XrmFakedRelationship LkDynamicPropertyAssociationattributeModifiedBy = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "modifiedby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "dynamicpropertyassociation",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_DynamicPropertyAssociationattribute_ModifiedOnBehalfBy</summary>
			public static readonly XrmFakedRelationship LkDynamicPropertyAssociationattributeModifiedOnBehalfBy = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "modifiedonbehalfby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "dynamicpropertyassociation",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_Dynamicpropertyinsatanceattribute_createdonbehalfby</summary>
			public static readonly XrmFakedRelationship LkDynamicpropertyinsatanceattributeCreatedonbehalfby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "createdonbehalfby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "dynamicpropertyinstance",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_Dynamicpropertyinsatanceattribute_ModifiedBy</summary>
			public static readonly XrmFakedRelationship LkDynamicpropertyinsatanceattributeModifiedBy = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "modifiedby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "dynamicpropertyinstance",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_Dynamicpropertyinsatanceattribute_ModifiedOnBehalfBy</summary>
			public static readonly XrmFakedRelationship LkDynamicpropertyinsatanceattributeModifiedOnBehalfBy = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "modifiedonbehalfby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "dynamicpropertyinstance",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_DynamicPropertyOptionSetItem_createdby</summary>
			public static readonly XrmFakedRelationship LkDynamicPropertyOptionSetItemCreatedby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "createdby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "dynamicpropertyoptionsetitem",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_DynamicPropertyOptionSetItem_createdonbehalfby</summary>
			public static readonly XrmFakedRelationship LkDynamicPropertyOptionSetItemCreatedonbehalfby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "createdonbehalfby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "dynamicpropertyoptionsetitem",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_DynamicPropertyOptionSetItem_modifiedby</summary>
			public static readonly XrmFakedRelationship LkDynamicPropertyOptionSetItemModifiedby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "modifiedby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "dynamicpropertyoptionsetitem",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_DynamicPropertyOptionSetItem_modifiedonbehalfby</summary>
			public static readonly XrmFakedRelationship LkDynamicPropertyOptionSetItemModifiedonbehalfby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "modifiedonbehalfby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "dynamicpropertyoptionsetitem",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_email_createdby</summary>
			public static readonly XrmFakedRelationship LkEmailCreatedby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "createdby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "email",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_email_createdonbehalfby</summary>
			public static readonly XrmFakedRelationship LkEmailCreatedonbehalfby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "createdonbehalfby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "email",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_email_modifiedby</summary>
			public static readonly XrmFakedRelationship LkEmailModifiedby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "modifiedby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "email",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_email_modifiedonbehalfby</summary>
			public static readonly XrmFakedRelationship LkEmailModifiedonbehalfby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "modifiedonbehalfby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "email",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_emailserverprofile_createdby</summary>
			public static readonly XrmFakedRelationship LkEmailserverprofileCreatedby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "createdby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "emailserverprofile",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_emailserverprofile_createdonbehalfby</summary>
			public static readonly XrmFakedRelationship LkEmailserverprofileCreatedonbehalfby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "createdonbehalfby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "emailserverprofile",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_emailserverprofile_modifiedby</summary>
			public static readonly XrmFakedRelationship LkEmailserverprofileModifiedby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "modifiedby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "emailserverprofile",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_emailserverprofile_modifiedonbehalfby</summary>
			public static readonly XrmFakedRelationship LkEmailserverprofileModifiedonbehalfby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "modifiedonbehalfby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "emailserverprofile",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_entitlement_createdby</summary>
			public static readonly XrmFakedRelationship LkEntitlementCreatedby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "createdby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "entitlement",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_entitlement_createdonbehalfby</summary>
			public static readonly XrmFakedRelationship LkEntitlementCreatedonbehalfby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "createdonbehalfby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "entitlement",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_entitlement_modifiedby</summary>
			public static readonly XrmFakedRelationship LkEntitlementModifiedby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "modifiedby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "entitlement",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_entitlement_modifiedonbehalfby</summary>
			public static readonly XrmFakedRelationship LkEntitlementModifiedonbehalfby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "modifiedonbehalfby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "entitlement",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_entitlementchannel_createdby</summary>
			public static readonly XrmFakedRelationship LkEntitlementchannelCreatedby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "createdby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "entitlementchannel",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_entitlementchannel_createdonbehalfby</summary>
			public static readonly XrmFakedRelationship LkEntitlementchannelCreatedonbehalfby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "createdonbehalfby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "entitlementchannel",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_entitlementchannel_modifiedby</summary>
			public static readonly XrmFakedRelationship LkEntitlementchannelModifiedby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "modifiedby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "entitlementchannel",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_entitlementchannel_modifiedonbehalfby</summary>
			public static readonly XrmFakedRelationship LkEntitlementchannelModifiedonbehalfby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "modifiedonbehalfby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "entitlementchannel",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_entitlemententityallocationtypemapping_createdby</summary>
			public static readonly XrmFakedRelationship LkEntitlemententityallocationtypemappingCreatedby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "createdby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "entitlemententityallocationtypemapping",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_entitlemententityallocationtypemapping_createdonbehalfby</summary>
			public static readonly XrmFakedRelationship LkEntitlemententityallocationtypemappingCreatedonbehalfby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "createdonbehalfby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "entitlemententityallocationtypemapping",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_entitlemententityallocationtypemapping_modifiedby</summary>
			public static readonly XrmFakedRelationship LkEntitlemententityallocationtypemappingModifiedby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "modifiedby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "entitlemententityallocationtypemapping",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_entitlemententityallocationtypemapping_modifiedonbehalfby</summary>
			public static readonly XrmFakedRelationship LkEntitlemententityallocationtypemappingModifiedonbehalfby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "modifiedonbehalfby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "entitlemententityallocationtypemapping",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_entitlementtemplate_createdby</summary>
			public static readonly XrmFakedRelationship LkEntitlementtemplateCreatedby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "createdby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "entitlementtemplate",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_entitlementtemplate_createdonbehalfby</summary>
			public static readonly XrmFakedRelationship LkEntitlementtemplateCreatedonbehalfby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "createdonbehalfby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "entitlementtemplate",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_entitlementtemplate_modifiedby</summary>
			public static readonly XrmFakedRelationship LkEntitlementtemplateModifiedby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "modifiedby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "entitlementtemplate",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_entitlementtemplate_modifiedonbehalfby</summary>
			public static readonly XrmFakedRelationship LkEntitlementtemplateModifiedonbehalfby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "modifiedonbehalfby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "entitlementtemplate",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_entitlementtemplatechannel_createdby</summary>
			public static readonly XrmFakedRelationship LkEntitlementtemplatechannelCreatedby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "createdby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "entitlementtemplatechannel",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_entitlementtemplatechannel_createdonbehalfby</summary>
			public static readonly XrmFakedRelationship LkEntitlementtemplatechannelCreatedonbehalfby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "createdonbehalfby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "entitlementtemplatechannel",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_entitlementtemplatechannel_modifiedby</summary>
			public static readonly XrmFakedRelationship LkEntitlementtemplatechannelModifiedby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "modifiedby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "entitlementtemplatechannel",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_entitlementtemplatechannel_modifiedonbehalfby</summary>
			public static readonly XrmFakedRelationship LkEntitlementtemplatechannelModifiedonbehalfby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "modifiedonbehalfby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "entitlementtemplatechannel",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_environmentvariabledefinition_createdby</summary>
			public static readonly XrmFakedRelationship LkEnvironmentvariabledefinitionCreatedby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "createdby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "environmentvariabledefinition",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_environmentvariabledefinition_createdonbehalfby</summary>
			public static readonly XrmFakedRelationship LkEnvironmentvariabledefinitionCreatedonbehalfby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "createdonbehalfby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "environmentvariabledefinition",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_environmentvariabledefinition_modifiedby</summary>
			public static readonly XrmFakedRelationship LkEnvironmentvariabledefinitionModifiedby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "modifiedby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "environmentvariabledefinition",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_environmentvariabledefinition_modifiedonbehalfby</summary>
			public static readonly XrmFakedRelationship LkEnvironmentvariabledefinitionModifiedonbehalfby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "modifiedonbehalfby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "environmentvariabledefinition",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_environmentvariablevalue_createdby</summary>
			public static readonly XrmFakedRelationship LkEnvironmentvariablevalueCreatedby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "createdby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "environmentvariablevalue",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_environmentvariablevalue_createdonbehalfby</summary>
			public static readonly XrmFakedRelationship LkEnvironmentvariablevalueCreatedonbehalfby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "createdonbehalfby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "environmentvariablevalue",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_environmentvariablevalue_modifiedby</summary>
			public static readonly XrmFakedRelationship LkEnvironmentvariablevalueModifiedby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "modifiedby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "environmentvariablevalue",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_environmentvariablevalue_modifiedonbehalfby</summary>
			public static readonly XrmFakedRelationship LkEnvironmentvariablevalueModifiedonbehalfby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "modifiedonbehalfby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "environmentvariablevalue",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_equipment_createdby</summary>
			public static readonly XrmFakedRelationship LkEquipmentCreatedby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "createdby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "equipment",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_equipment_createdonbehalfby</summary>
			public static readonly XrmFakedRelationship LkEquipmentCreatedonbehalfby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "createdonbehalfby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "equipment",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_equipment_modifiedby</summary>
			public static readonly XrmFakedRelationship LkEquipmentModifiedby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "modifiedby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "equipment",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_equipment_modifiedonbehalfby</summary>
			public static readonly XrmFakedRelationship LkEquipmentModifiedonbehalfby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "modifiedonbehalfby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "equipment",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_expiredprocess_createdby</summary>
			public static readonly XrmFakedRelationship LkExpiredprocessCreatedby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "createdby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "expiredprocess",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_expiredprocess_createdonbehalfby</summary>
			public static readonly XrmFakedRelationship LkExpiredprocessCreatedonbehalfby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "createdonbehalfby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "expiredprocess",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_expiredprocess_modifiedby</summary>
			public static readonly XrmFakedRelationship LkExpiredprocessModifiedby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "modifiedby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "expiredprocess",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_expiredprocess_modifiedonbehalfby</summary>
			public static readonly XrmFakedRelationship LkExpiredprocessModifiedonbehalfby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "modifiedonbehalfby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "expiredprocess",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_exportsolutionupload_createdby</summary>
			public static readonly XrmFakedRelationship LkExportsolutionuploadCreatedby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "createdby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "exportsolutionupload",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_exportsolutionupload_createdonbehalfby</summary>
			public static readonly XrmFakedRelationship LkExportsolutionuploadCreatedonbehalfby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "createdonbehalfby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "exportsolutionupload",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_exportsolutionupload_modifiedby</summary>
			public static readonly XrmFakedRelationship LkExportsolutionuploadModifiedby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "modifiedby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "exportsolutionupload",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_exportsolutionupload_modifiedonbehalfby</summary>
			public static readonly XrmFakedRelationship LkExportsolutionuploadModifiedonbehalfby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "modifiedonbehalfby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "exportsolutionupload",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_fax_createdby</summary>
			public static readonly XrmFakedRelationship LkFaxCreatedby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "createdby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "fax",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_fax_createdonbehalfby</summary>
			public static readonly XrmFakedRelationship LkFaxCreatedonbehalfby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "createdonbehalfby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "fax",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_fax_modifiedby</summary>
			public static readonly XrmFakedRelationship LkFaxModifiedby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "modifiedby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "fax",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_fax_modifiedonbehalfby</summary>
			public static readonly XrmFakedRelationship LkFaxModifiedonbehalfby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "modifiedonbehalfby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "fax",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_feedback_closedby</summary>
			public static readonly XrmFakedRelationship LkFeedbackClosedby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "closedby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "feedback",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_feedback_createdby</summary>
			public static readonly XrmFakedRelationship LkFeedbackCreatedby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "createdby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "feedback",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_feedback_createdonbehalfby</summary>
			public static readonly XrmFakedRelationship LkFeedbackCreatedonbehalfby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "createdonbehalfby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "feedback",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_feedback_modifiedby</summary>
			public static readonly XrmFakedRelationship LkFeedbackModifiedby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "modifiedby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "feedback",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_feedback_modifiedonbehalfby</summary>
			public static readonly XrmFakedRelationship LkFeedbackModifiedonbehalfby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "modifiedonbehalfby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "feedback",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_fieldsecurityprofile_createdby</summary>
			public static readonly XrmFakedRelationship LkFieldsecurityprofileCreatedby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "createdby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "fieldsecurityprofile",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_fieldsecurityprofile_createdonbehalfby</summary>
			public static readonly XrmFakedRelationship LkFieldsecurityprofileCreatedonbehalfby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "createdonbehalfby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "fieldsecurityprofile",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_fieldsecurityprofile_modifiedby</summary>
			public static readonly XrmFakedRelationship LkFieldsecurityprofileModifiedby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "modifiedby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "fieldsecurityprofile",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_fieldsecurityprofile_modifiedonbehalfby</summary>
			public static readonly XrmFakedRelationship LkFieldsecurityprofileModifiedonbehalfby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "modifiedonbehalfby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "fieldsecurityprofile",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_fixedmonthlyfiscalcalendar_createdby</summary>
			public static readonly XrmFakedRelationship LkFixedmonthlyfiscalcalendarCreatedby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "createdby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "fixedmonthlyfiscalcalendar",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_fixedmonthlyfiscalcalendar_createdonbehalfby</summary>
			public static readonly XrmFakedRelationship LkFixedmonthlyfiscalcalendarCreatedonbehalfby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "createdonbehalfby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "fixedmonthlyfiscalcalendar",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_fixedmonthlyfiscalcalendar_modifiedby</summary>
			public static readonly XrmFakedRelationship LkFixedmonthlyfiscalcalendarModifiedby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "modifiedby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "fixedmonthlyfiscalcalendar",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_fixedmonthlyfiscalcalendar_modifiedonbehalfby</summary>
			public static readonly XrmFakedRelationship LkFixedmonthlyfiscalcalendarModifiedonbehalfby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "modifiedonbehalfby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "fixedmonthlyfiscalcalendar",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_fixedmonthlyfiscalcalendar_salespersonid</summary>
			public static readonly XrmFakedRelationship LkFixedmonthlyfiscalcalendarSalespersonid = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "salespersonid",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "fixedmonthlyfiscalcalendar",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_flowsession_createdby</summary>
			public static readonly XrmFakedRelationship LkFlowsessionCreatedby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "createdby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "flowsession",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_flowsession_createdonbehalfby</summary>
			public static readonly XrmFakedRelationship LkFlowsessionCreatedonbehalfby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "createdonbehalfby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "flowsession",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_flowsession_modifiedby</summary>
			public static readonly XrmFakedRelationship LkFlowsessionModifiedby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "modifiedby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "flowsession",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_flowsession_modifiedonbehalfby</summary>
			public static readonly XrmFakedRelationship LkFlowsessionModifiedonbehalfby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "modifiedonbehalfby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "flowsession",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_goal_createdby</summary>
			public static readonly XrmFakedRelationship LkGoalCreatedby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "createdby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "goal",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_goal_createdonbehalfby</summary>
			public static readonly XrmFakedRelationship LkGoalCreatedonbehalfby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "createdonbehalfby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "goal",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_goal_modifiedby</summary>
			public static readonly XrmFakedRelationship LkGoalModifiedby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "modifiedby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "goal",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_goal_modifiedonbehalfby</summary>
			public static readonly XrmFakedRelationship LkGoalModifiedonbehalfby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "modifiedonbehalfby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "goal",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_goalrollupquery_createdby</summary>
			public static readonly XrmFakedRelationship LkGoalrollupqueryCreatedby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "createdby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "goalrollupquery",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_goalrollupquery_createdonbehalfby</summary>
			public static readonly XrmFakedRelationship LkGoalrollupqueryCreatedonbehalfby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "createdonbehalfby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "goalrollupquery",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_goalrollupquery_modifiedby</summary>
			public static readonly XrmFakedRelationship LkGoalrollupqueryModifiedby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "modifiedby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "goalrollupquery",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_goalrollupquery_modifiedonbehalfby</summary>
			public static readonly XrmFakedRelationship LkGoalrollupqueryModifiedonbehalfby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "modifiedonbehalfby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "goalrollupquery",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_import_createdonbehalfby</summary>
			public static readonly XrmFakedRelationship LkImportCreatedonbehalfby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "createdonbehalfby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "import",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_import_modifiedonbehalfby</summary>
			public static readonly XrmFakedRelationship LkImportModifiedonbehalfby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "modifiedonbehalfby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "import",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_importbase_createdby</summary>
			public static readonly XrmFakedRelationship LkImportbaseCreatedby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "createdby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "import",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_importbase_modifiedby</summary>
			public static readonly XrmFakedRelationship LkImportbaseModifiedby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "modifiedby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "import",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_importdata_createdonbehalfby</summary>
			public static readonly XrmFakedRelationship LkImportdataCreatedonbehalfby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "createdonbehalfby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "importdata",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_importdata_modifiedonbehalfby</summary>
			public static readonly XrmFakedRelationship LkImportdataModifiedonbehalfby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "modifiedonbehalfby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "importdata",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_importdatabase_createdby</summary>
			public static readonly XrmFakedRelationship LkImportdatabaseCreatedby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "createdby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "importdata",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_importdatabase_modifiedby</summary>
			public static readonly XrmFakedRelationship LkImportdatabaseModifiedby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "modifiedby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "importdata",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_importentitymapping_createdby</summary>
			public static readonly XrmFakedRelationship LkImportentitymappingCreatedby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "createdby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "importentitymapping",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_importentitymapping_createdonbehalfby</summary>
			public static readonly XrmFakedRelationship LkImportentitymappingCreatedonbehalfby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "createdonbehalfby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "importentitymapping",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_importentitymapping_modifiedby</summary>
			public static readonly XrmFakedRelationship LkImportentitymappingModifiedby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "modifiedby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "importentitymapping",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_importentitymapping_modifiedonbehalfby</summary>
			public static readonly XrmFakedRelationship LkImportentitymappingModifiedonbehalfby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "modifiedonbehalfby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "importentitymapping",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_importfilebase_createdby</summary>
			public static readonly XrmFakedRelationship LkImportfilebaseCreatedby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "createdby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "importfile",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_importfilebase_createdonbehalfby</summary>
			public static readonly XrmFakedRelationship LkImportfilebaseCreatedonbehalfby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "createdonbehalfby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "importfile",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_importfilebase_modifiedby</summary>
			public static readonly XrmFakedRelationship LkImportfilebaseModifiedby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "modifiedby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "importfile",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_importfilebase_modifiedonbehalfby</summary>
			public static readonly XrmFakedRelationship LkImportfilebaseModifiedonbehalfby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "modifiedonbehalfby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "importfile",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_importjobbase_createdby</summary>
			public static readonly XrmFakedRelationship LkImportjobbaseCreatedby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "createdby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "importjob",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_importjobbase_createdonbehalfby</summary>
			public static readonly XrmFakedRelationship LkImportjobbaseCreatedonbehalfby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "createdonbehalfby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "importjob",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_importjobbase_modifiedby</summary>
			public static readonly XrmFakedRelationship LkImportjobbaseModifiedby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "modifiedby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "importjob",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_importjobbase_modifiedonbehalfby</summary>
			public static readonly XrmFakedRelationship LkImportjobbaseModifiedonbehalfby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "modifiedonbehalfby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "importjob",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_importlog_createdonbehalfby</summary>
			public static readonly XrmFakedRelationship LkImportlogCreatedonbehalfby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "createdonbehalfby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "importlog",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_importlog_modifiedonbehalfby</summary>
			public static readonly XrmFakedRelationship LkImportlogModifiedonbehalfby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "modifiedonbehalfby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "importlog",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_importlogbase_createdby</summary>
			public static readonly XrmFakedRelationship LkImportlogbaseCreatedby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "createdby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "importlog",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_importlogbase_modifiedby</summary>
			public static readonly XrmFakedRelationship LkImportlogbaseModifiedby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "modifiedby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "importlog",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_importmap_createdonbehalfby</summary>
			public static readonly XrmFakedRelationship LkImportmapCreatedonbehalfby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "createdonbehalfby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "importmap",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_importmap_modifiedonbehalfby</summary>
			public static readonly XrmFakedRelationship LkImportmapModifiedonbehalfby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "modifiedonbehalfby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "importmap",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_importmapbase_createdby</summary>
			public static readonly XrmFakedRelationship LkImportmapbaseCreatedby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "createdby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "importmap",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_importmapbase_modifiedby</summary>
			public static readonly XrmFakedRelationship LkImportmapbaseModifiedby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "modifiedby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "importmap",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_incidentbase_createdby</summary>
			public static readonly XrmFakedRelationship LkIncidentbaseCreatedby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "createdby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "incident",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_incidentbase_createdonbehalfby</summary>
			public static readonly XrmFakedRelationship LkIncidentbaseCreatedonbehalfby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "createdonbehalfby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "incident",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_incidentbase_modifiedby</summary>
			public static readonly XrmFakedRelationship LkIncidentbaseModifiedby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "modifiedby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "incident",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_incidentbase_modifiedonbehalfby</summary>
			public static readonly XrmFakedRelationship LkIncidentbaseModifiedonbehalfby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "modifiedonbehalfby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "incident",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_incidentresolution_createdby</summary>
			public static readonly XrmFakedRelationship LkIncidentresolutionCreatedby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "createdby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "incidentresolution",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_incidentresolution_createdonbehalfby</summary>
			public static readonly XrmFakedRelationship LkIncidentresolutionCreatedonbehalfby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "createdonbehalfby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "incidentresolution",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_incidentresolution_modifiedby</summary>
			public static readonly XrmFakedRelationship LkIncidentresolutionModifiedby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "modifiedby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "incidentresolution",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_incidentresolution_modifiedonbehalfby</summary>
			public static readonly XrmFakedRelationship LkIncidentresolutionModifiedonbehalfby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "modifiedonbehalfby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "incidentresolution",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_interactionforemail_createdby</summary>
			public static readonly XrmFakedRelationship LkInteractionforemailCreatedby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "createdby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "interactionforemail",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_interactionforemail_createdonbehalfby</summary>
			public static readonly XrmFakedRelationship LkInteractionforemailCreatedonbehalfby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "createdonbehalfby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "interactionforemail",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_interactionforemail_modifiedby</summary>
			public static readonly XrmFakedRelationship LkInteractionforemailModifiedby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "modifiedby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "interactionforemail",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_interactionforemail_modifiedonbehalfby</summary>
			public static readonly XrmFakedRelationship LkInteractionforemailModifiedonbehalfby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "modifiedonbehalfby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "interactionforemail",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_invoice_createdonbehalfby</summary>
			public static readonly XrmFakedRelationship LkInvoiceCreatedonbehalfby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "createdonbehalfby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "invoice",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_invoice_modifiedonbehalfby</summary>
			public static readonly XrmFakedRelationship LkInvoiceModifiedonbehalfby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "modifiedonbehalfby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "invoice",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_invoicebase_createdby</summary>
			public static readonly XrmFakedRelationship LkInvoicebaseCreatedby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "createdby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "invoice",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_invoicebase_modifiedby</summary>
			public static readonly XrmFakedRelationship LkInvoicebaseModifiedby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "modifiedby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "invoice",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_invoicedetail_createdonbehalfby</summary>
			public static readonly XrmFakedRelationship LkInvoicedetailCreatedonbehalfby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "createdonbehalfby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "invoicedetail",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_invoicedetail_modifiedonbehalfby</summary>
			public static readonly XrmFakedRelationship LkInvoicedetailModifiedonbehalfby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "modifiedonbehalfby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "invoicedetail",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_invoicedetailbase_createdby</summary>
			public static readonly XrmFakedRelationship LkInvoicedetailbaseCreatedby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "createdby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "invoicedetail",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_invoicedetailbase_modifiedby</summary>
			public static readonly XrmFakedRelationship LkInvoicedetailbaseModifiedby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "modifiedby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "invoicedetail",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_kbarticle_createdonbehalfby</summary>
			public static readonly XrmFakedRelationship LkKbarticleCreatedonbehalfby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "createdonbehalfby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "kbarticle",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_kbarticle_modifiedonbehalfby</summary>
			public static readonly XrmFakedRelationship LkKbarticleModifiedonbehalfby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "modifiedonbehalfby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "kbarticle",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_kbarticlebase_createdby</summary>
			public static readonly XrmFakedRelationship LkKbarticlebaseCreatedby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "createdby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "kbarticle",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_kbarticlebase_modifiedby</summary>
			public static readonly XrmFakedRelationship LkKbarticlebaseModifiedby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "modifiedby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "kbarticle",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_kbarticlecomment_createdonbehalfby</summary>
			public static readonly XrmFakedRelationship LkKbarticlecommentCreatedonbehalfby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "createdonbehalfby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "kbarticlecomment",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_kbarticlecomment_modifiedonbehalfby</summary>
			public static readonly XrmFakedRelationship LkKbarticlecommentModifiedonbehalfby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "modifiedonbehalfby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "kbarticlecomment",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_kbarticlecommentbase_createdby</summary>
			public static readonly XrmFakedRelationship LkKbarticlecommentbaseCreatedby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "createdby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "kbarticlecomment",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_kbarticlecommentbase_modifiedby</summary>
			public static readonly XrmFakedRelationship LkKbarticlecommentbaseModifiedby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "modifiedby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "kbarticlecomment",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_kbarticletemplate_createdonbehalfby</summary>
			public static readonly XrmFakedRelationship LkKbarticletemplateCreatedonbehalfby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "createdonbehalfby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "kbarticletemplate",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_kbarticletemplate_modifiedonbehalfby</summary>
			public static readonly XrmFakedRelationship LkKbarticletemplateModifiedonbehalfby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "modifiedonbehalfby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "kbarticletemplate",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_kbarticletemplatebase_createdby</summary>
			public static readonly XrmFakedRelationship LkKbarticletemplatebaseCreatedby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "createdby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "kbarticletemplate",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_kbarticletemplatebase_modifiedby</summary>
			public static readonly XrmFakedRelationship LkKbarticletemplatebaseModifiedby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "modifiedby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "kbarticletemplate",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_knowledgearticle_createdby</summary>
			public static readonly XrmFakedRelationship LkKnowledgearticleCreatedby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "createdby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "knowledgearticle",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_knowledgearticle_createdonbehalfby</summary>
			public static readonly XrmFakedRelationship LkKnowledgearticleCreatedonbehalfby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "createdonbehalfby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "knowledgearticle",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_knowledgearticle_modifiedby</summary>
			public static readonly XrmFakedRelationship LkKnowledgearticleModifiedby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "modifiedby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "knowledgearticle",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_knowledgearticle_modifiedonbehalfby</summary>
			public static readonly XrmFakedRelationship LkKnowledgearticleModifiedonbehalfby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "modifiedonbehalfby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "knowledgearticle",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_knowledgearticleincident_createdby</summary>
			public static readonly XrmFakedRelationship LkKnowledgearticleincidentCreatedby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "createdby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "knowledgearticleincident",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_knowledgearticleincident_createdonbehalfby</summary>
			public static readonly XrmFakedRelationship LkKnowledgearticleincidentCreatedonbehalfby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "createdonbehalfby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "knowledgearticleincident",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_knowledgearticleincident_modifiedby</summary>
			public static readonly XrmFakedRelationship LkKnowledgearticleincidentModifiedby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "modifiedby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "knowledgearticleincident",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_knowledgearticleincident_modifiedonbehalfby</summary>
			public static readonly XrmFakedRelationship LkKnowledgearticleincidentModifiedonbehalfby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "modifiedonbehalfby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "knowledgearticleincident",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_knowledgearticleviews_createdby</summary>
			public static readonly XrmFakedRelationship LkKnowledgearticleviewsCreatedby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "createdby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "knowledgearticleviews",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_knowledgearticleviews_createdonbehalfby</summary>
			public static readonly XrmFakedRelationship LkKnowledgearticleviewsCreatedonbehalfby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "createdonbehalfby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "knowledgearticleviews",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_knowledgearticleviews_modifiedby</summary>
			public static readonly XrmFakedRelationship LkKnowledgearticleviewsModifiedby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "modifiedby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "knowledgearticleviews",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_knowledgearticleviews_modifiedonbehalfby</summary>
			public static readonly XrmFakedRelationship LkKnowledgearticleviewsModifiedonbehalfby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "modifiedonbehalfby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "knowledgearticleviews",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_KnowledgeBaseRecord_createdby</summary>
			public static readonly XrmFakedRelationship LkKnowledgeBaseRecordCreatedby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "createdby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "knowledgebaserecord",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_KnowledgeBaseRecord_createdonbehalfby</summary>
			public static readonly XrmFakedRelationship LkKnowledgeBaseRecordCreatedonbehalfby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "createdonbehalfby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "knowledgebaserecord",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_KnowledgeBaseRecord_modifiedby</summary>
			public static readonly XrmFakedRelationship LkKnowledgeBaseRecordModifiedby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "modifiedby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "knowledgebaserecord",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_KnowledgeBaseRecord_modifiedonbehalfby</summary>
			public static readonly XrmFakedRelationship LkKnowledgeBaseRecordModifiedonbehalfby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "modifiedonbehalfby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "knowledgebaserecord",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_lead_createdonbehalfby</summary>
			public static readonly XrmFakedRelationship LkLeadCreatedonbehalfby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "createdonbehalfby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "lead",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_lead_modifiedonbehalfby</summary>
			public static readonly XrmFakedRelationship LkLeadModifiedonbehalfby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "modifiedonbehalfby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "lead",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_leadaddress_createdonbehalfby</summary>
			public static readonly XrmFakedRelationship LkLeadaddressCreatedonbehalfby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "createdonbehalfby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "leadaddress",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_leadaddress_modifiedonbehalfby</summary>
			public static readonly XrmFakedRelationship LkLeadaddressModifiedonbehalfby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "modifiedonbehalfby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "leadaddress",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_leadaddressbase_createdby</summary>
			public static readonly XrmFakedRelationship LkLeadaddressbaseCreatedby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "createdby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "leadaddress",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_leadaddressbase_modifiedby</summary>
			public static readonly XrmFakedRelationship LkLeadaddressbaseModifiedby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "modifiedby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "leadaddress",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_leadbase_createdby</summary>
			public static readonly XrmFakedRelationship LkLeadbaseCreatedby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "createdby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "lead",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_leadbase_modifiedby</summary>
			public static readonly XrmFakedRelationship LkLeadbaseModifiedby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "modifiedby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "lead",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_leadtoopportunitysalesprocess_createdby</summary>
			public static readonly XrmFakedRelationship LkLeadtoopportunitysalesprocessCreatedby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "createdby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "leadtoopportunitysalesprocess",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_leadtoopportunitysalesprocess_createdonbehalfby</summary>
			public static readonly XrmFakedRelationship LkLeadtoopportunitysalesprocessCreatedonbehalfby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "createdonbehalfby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "leadtoopportunitysalesprocess",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_leadtoopportunitysalesprocess_modifiedby</summary>
			public static readonly XrmFakedRelationship LkLeadtoopportunitysalesprocessModifiedby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "modifiedby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "leadtoopportunitysalesprocess",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_leadtoopportunitysalesprocess_modifiedonbehalfby</summary>
			public static readonly XrmFakedRelationship LkLeadtoopportunitysalesprocessModifiedonbehalfby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "modifiedonbehalfby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "leadtoopportunitysalesprocess",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_letter_createdby</summary>
			public static readonly XrmFakedRelationship LkLetterCreatedby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "createdby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "letter",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_letter_createdonbehalfby</summary>
			public static readonly XrmFakedRelationship LkLetterCreatedonbehalfby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "createdonbehalfby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "letter",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_letter_modifiedby</summary>
			public static readonly XrmFakedRelationship LkLetterModifiedby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "modifiedby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "letter",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_letter_modifiedonbehalfby</summary>
			public static readonly XrmFakedRelationship LkLetterModifiedonbehalfby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "modifiedonbehalfby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "letter",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_list_createdby</summary>
			public static readonly XrmFakedRelationship LkListCreatedby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "createdby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "list",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_list_createdonbehalfby</summary>
			public static readonly XrmFakedRelationship LkListCreatedonbehalfby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "createdonbehalfby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "list",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_list_modifiedby</summary>
			public static readonly XrmFakedRelationship LkListModifiedby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "modifiedby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "list",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_list_modifiedonbehalfby</summary>
			public static readonly XrmFakedRelationship LkListModifiedonbehalfby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "modifiedonbehalfby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "list",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_listoperation_createdby</summary>
			public static readonly XrmFakedRelationship LkListoperationCreatedby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "createdby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "listoperation",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_listoperation_createdonbehalfby</summary>
			public static readonly XrmFakedRelationship LkListoperationCreatedonbehalfby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "createdonbehalfby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "listoperation",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_listoperation_modifiedby</summary>
			public static readonly XrmFakedRelationship LkListoperationModifiedby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "modifiedby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "listoperation",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_listoperation_modifiedonbehalfby</summary>
			public static readonly XrmFakedRelationship LkListoperationModifiedonbehalfby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "modifiedonbehalfby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "listoperation",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_lookupmapping_createdby</summary>
			public static readonly XrmFakedRelationship LkLookupmappingCreatedby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "createdby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "lookupmapping",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_lookupmapping_createdonbehalfby</summary>
			public static readonly XrmFakedRelationship LkLookupmappingCreatedonbehalfby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "createdonbehalfby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "lookupmapping",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_lookupmapping_modifiedby</summary>
			public static readonly XrmFakedRelationship LkLookupmappingModifiedby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "modifiedby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "lookupmapping",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_lookupmapping_modifiedonbehalfby</summary>
			public static readonly XrmFakedRelationship LkLookupmappingModifiedonbehalfby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "modifiedonbehalfby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "lookupmapping",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_mailbox_createdby</summary>
			public static readonly XrmFakedRelationship LkMailboxCreatedby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "createdby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "mailbox",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_mailbox_createdonbehalfby</summary>
			public static readonly XrmFakedRelationship LkMailboxCreatedonbehalfby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "createdonbehalfby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "mailbox",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_mailbox_modifiedby</summary>
			public static readonly XrmFakedRelationship LkMailboxModifiedby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "modifiedby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "mailbox",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_mailbox_modifiedonbehalfby</summary>
			public static readonly XrmFakedRelationship LkMailboxModifiedonbehalfby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "modifiedonbehalfby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "mailbox",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_mailboxtrackingfolder_createdby</summary>
			public static readonly XrmFakedRelationship LkMailboxtrackingfolderCreatedby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "createdby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "mailboxtrackingfolder",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_mailboxtrackingfolder_createdonbehalfby</summary>
			public static readonly XrmFakedRelationship LkMailboxtrackingfolderCreatedonbehalfby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "createdonbehalfby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "mailboxtrackingfolder",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_mailboxtrackingfolder_modifiedby</summary>
			public static readonly XrmFakedRelationship LkMailboxtrackingfolderModifiedby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "modifiedby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "mailboxtrackingfolder",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_mailboxtrackingfolder_modifiedonbehalfby</summary>
			public static readonly XrmFakedRelationship LkMailboxtrackingfolderModifiedonbehalfby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "modifiedonbehalfby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "mailboxtrackingfolder",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_mailmergetemplate_createdonbehalfby</summary>
			public static readonly XrmFakedRelationship LkMailmergetemplateCreatedonbehalfby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "createdonbehalfby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "mailmergetemplate",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_mailmergetemplate_modifiedonbehalfby</summary>
			public static readonly XrmFakedRelationship LkMailmergetemplateModifiedonbehalfby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "modifiedonbehalfby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "mailmergetemplate",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_mailmergetemplatebase_createdby</summary>
			public static readonly XrmFakedRelationship LkMailmergetemplatebaseCreatedby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "createdby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "mailmergetemplate",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_mailmergetemplatebase_modifiedby</summary>
			public static readonly XrmFakedRelationship LkMailmergetemplatebaseModifiedby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "modifiedby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "mailmergetemplate",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_marketingformdisplayattributes_createdby</summary>
			public static readonly XrmFakedRelationship LkMarketingformdisplayattributesCreatedby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "createdby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "marketingformdisplayattributes",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_marketingformdisplayattributes_createdonbehalfby</summary>
			public static readonly XrmFakedRelationship LkMarketingformdisplayattributesCreatedonbehalfby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "createdonbehalfby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "marketingformdisplayattributes",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_marketingformdisplayattributes_modifiedby</summary>
			public static readonly XrmFakedRelationship LkMarketingformdisplayattributesModifiedby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "modifiedby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "marketingformdisplayattributes",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_marketingformdisplayattributes_modifiedonbehalfby</summary>
			public static readonly XrmFakedRelationship LkMarketingformdisplayattributesModifiedonbehalfby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "modifiedonbehalfby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "marketingformdisplayattributes",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_metric_createdby</summary>
			public static readonly XrmFakedRelationship LkMetricCreatedby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "createdby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "metric",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_metric_createdonbehalfby</summary>
			public static readonly XrmFakedRelationship LkMetricCreatedonbehalfby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "createdonbehalfby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "metric",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_metric_modifiedby</summary>
			public static readonly XrmFakedRelationship LkMetricModifiedby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "modifiedby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "metric",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_metric_modifiedonbehalfby</summary>
			public static readonly XrmFakedRelationship LkMetricModifiedonbehalfby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "modifiedonbehalfby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "metric",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_MobileOfflineProfile_createdby</summary>
			public static readonly XrmFakedRelationship LkMobileOfflineProfileCreatedby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "createdby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "mobileofflineprofile",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_MobileOfflineProfile_createdonbehalfby</summary>
			public static readonly XrmFakedRelationship LkMobileOfflineProfileCreatedonbehalfby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "createdonbehalfby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "mobileofflineprofile",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_MobileOfflineProfile_modifiedby</summary>
			public static readonly XrmFakedRelationship LkMobileOfflineProfileModifiedby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "modifiedby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "mobileofflineprofile",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_MobileOfflineProfile_modifiedonbehalfby</summary>
			public static readonly XrmFakedRelationship LkMobileOfflineProfileModifiedonbehalfby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "modifiedonbehalfby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "mobileofflineprofile",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_MobileOfflineProfileItem_createdby</summary>
			public static readonly XrmFakedRelationship LkMobileOfflineProfileItemCreatedby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "createdby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "mobileofflineprofileitem",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_mobileofflineprofileitem_createdonbehalfby</summary>
			public static readonly XrmFakedRelationship LkMobileofflineprofileitemCreatedonbehalfby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "createdonbehalfby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "mobileofflineprofileitem",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_mobileofflineprofileitem_modifiedby</summary>
			public static readonly XrmFakedRelationship LkMobileofflineprofileitemModifiedby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "modifiedby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "mobileofflineprofileitem",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_mobileofflineprofileitem_modifiedonbehalfby</summary>
			public static readonly XrmFakedRelationship LkMobileofflineprofileitemModifiedonbehalfby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "modifiedonbehalfby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "mobileofflineprofileitem",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_MobileOfflineProfileItemAssociation_createdby</summary>
			public static readonly XrmFakedRelationship LkMobileOfflineProfileItemAssociationCreatedby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "createdby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "mobileofflineprofileitemassociation",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_mobileofflineprofileitemassociation_createdonbehalfby</summary>
			public static readonly XrmFakedRelationship LkMobileofflineprofileitemassociationCreatedonbehalfby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "createdonbehalfby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "mobileofflineprofileitemassociation",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_mobileofflineprofileitemassociation_modifiedby</summary>
			public static readonly XrmFakedRelationship LkMobileofflineprofileitemassociationModifiedby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "modifiedby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "mobileofflineprofileitemassociation",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_mobileofflineprofileitemassociation_modifiedonbehalfby</summary>
			public static readonly XrmFakedRelationship LkMobileofflineprofileitemassociationModifiedonbehalfby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "modifiedonbehalfby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "mobileofflineprofileitemassociation",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_monthlyfiscalcalendar_createdby</summary>
			public static readonly XrmFakedRelationship LkMonthlyfiscalcalendarCreatedby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "createdby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "monthlyfiscalcalendar",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_monthlyfiscalcalendar_createdonbehalfby</summary>
			public static readonly XrmFakedRelationship LkMonthlyfiscalcalendarCreatedonbehalfby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "createdonbehalfby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "monthlyfiscalcalendar",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_monthlyfiscalcalendar_modifiedby</summary>
			public static readonly XrmFakedRelationship LkMonthlyfiscalcalendarModifiedby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "modifiedby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "monthlyfiscalcalendar",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_monthlyfiscalcalendar_modifiedonbehalfby</summary>
			public static readonly XrmFakedRelationship LkMonthlyfiscalcalendarModifiedonbehalfby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "modifiedonbehalfby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "monthlyfiscalcalendar",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_monthlyfiscalcalendar_salespersonid</summary>
			public static readonly XrmFakedRelationship LkMonthlyfiscalcalendarSalespersonid = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "salespersonid",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "monthlyfiscalcalendar",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_msdyn_actioncardregarding_createdby</summary>
			public static readonly XrmFakedRelationship LkMsdynActioncardregardingCreatedby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "createdby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "msdyn_actioncardregarding",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_msdyn_actioncardregarding_createdonbehalfby</summary>
			public static readonly XrmFakedRelationship LkMsdynActioncardregardingCreatedonbehalfby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "createdonbehalfby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "msdyn_actioncardregarding",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_msdyn_actioncardregarding_modifiedby</summary>
			public static readonly XrmFakedRelationship LkMsdynActioncardregardingModifiedby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "modifiedby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "msdyn_actioncardregarding",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_msdyn_actioncardregarding_modifiedonbehalfby</summary>
			public static readonly XrmFakedRelationship LkMsdynActioncardregardingModifiedonbehalfby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "modifiedonbehalfby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "msdyn_actioncardregarding",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_msdyn_actioncardrolesetting_createdby</summary>
			public static readonly XrmFakedRelationship LkMsdynActioncardrolesettingCreatedby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "createdby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "msdyn_actioncardrolesetting",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_msdyn_actioncardrolesetting_createdonbehalfby</summary>
			public static readonly XrmFakedRelationship LkMsdynActioncardrolesettingCreatedonbehalfby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "createdonbehalfby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "msdyn_actioncardrolesetting",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_msdyn_actioncardrolesetting_modifiedby</summary>
			public static readonly XrmFakedRelationship LkMsdynActioncardrolesettingModifiedby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "modifiedby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "msdyn_actioncardrolesetting",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_msdyn_actioncardrolesetting_modifiedonbehalfby</summary>
			public static readonly XrmFakedRelationship LkMsdynActioncardrolesettingModifiedonbehalfby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "modifiedonbehalfby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "msdyn_actioncardrolesetting",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_msdyn_aibdataset_createdby</summary>
			public static readonly XrmFakedRelationship LkMsdynAibdatasetCreatedby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "createdby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "msdyn_aibdataset",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_msdyn_aibdataset_createdonbehalfby</summary>
			public static readonly XrmFakedRelationship LkMsdynAibdatasetCreatedonbehalfby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "createdonbehalfby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "msdyn_aibdataset",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_msdyn_aibdataset_modifiedby</summary>
			public static readonly XrmFakedRelationship LkMsdynAibdatasetModifiedby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "modifiedby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "msdyn_aibdataset",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_msdyn_aibdataset_modifiedonbehalfby</summary>
			public static readonly XrmFakedRelationship LkMsdynAibdatasetModifiedonbehalfby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "modifiedonbehalfby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "msdyn_aibdataset",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_msdyn_aibdatasetfile_createdby</summary>
			public static readonly XrmFakedRelationship LkMsdynAibdatasetfileCreatedby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "createdby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "msdyn_aibdatasetfile",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_msdyn_aibdatasetfile_createdonbehalfby</summary>
			public static readonly XrmFakedRelationship LkMsdynAibdatasetfileCreatedonbehalfby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "createdonbehalfby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "msdyn_aibdatasetfile",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_msdyn_aibdatasetfile_modifiedby</summary>
			public static readonly XrmFakedRelationship LkMsdynAibdatasetfileModifiedby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "modifiedby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "msdyn_aibdatasetfile",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_msdyn_aibdatasetfile_modifiedonbehalfby</summary>
			public static readonly XrmFakedRelationship LkMsdynAibdatasetfileModifiedonbehalfby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "modifiedonbehalfby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "msdyn_aibdatasetfile",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_msdyn_aibdatasetrecord_createdby</summary>
			public static readonly XrmFakedRelationship LkMsdynAibdatasetrecordCreatedby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "createdby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "msdyn_aibdatasetrecord",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_msdyn_aibdatasetrecord_createdonbehalfby</summary>
			public static readonly XrmFakedRelationship LkMsdynAibdatasetrecordCreatedonbehalfby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "createdonbehalfby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "msdyn_aibdatasetrecord",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_msdyn_aibdatasetrecord_modifiedby</summary>
			public static readonly XrmFakedRelationship LkMsdynAibdatasetrecordModifiedby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "modifiedby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "msdyn_aibdatasetrecord",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_msdyn_aibdatasetrecord_modifiedonbehalfby</summary>
			public static readonly XrmFakedRelationship LkMsdynAibdatasetrecordModifiedonbehalfby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "modifiedonbehalfby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "msdyn_aibdatasetrecord",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_msdyn_aibdatasetscontainer_createdby</summary>
			public static readonly XrmFakedRelationship LkMsdynAibdatasetscontainerCreatedby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "createdby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "msdyn_aibdatasetscontainer",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_msdyn_aibdatasetscontainer_createdonbehalfby</summary>
			public static readonly XrmFakedRelationship LkMsdynAibdatasetscontainerCreatedonbehalfby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "createdonbehalfby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "msdyn_aibdatasetscontainer",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_msdyn_aibdatasetscontainer_modifiedby</summary>
			public static readonly XrmFakedRelationship LkMsdynAibdatasetscontainerModifiedby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "modifiedby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "msdyn_aibdatasetscontainer",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_msdyn_aibdatasetscontainer_modifiedonbehalfby</summary>
			public static readonly XrmFakedRelationship LkMsdynAibdatasetscontainerModifiedonbehalfby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "modifiedonbehalfby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "msdyn_aibdatasetscontainer",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_msdyn_aibfile_createdby</summary>
			public static readonly XrmFakedRelationship LkMsdynAibfileCreatedby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "createdby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "msdyn_aibfile",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_msdyn_aibfile_createdonbehalfby</summary>
			public static readonly XrmFakedRelationship LkMsdynAibfileCreatedonbehalfby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "createdonbehalfby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "msdyn_aibfile",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_msdyn_aibfile_modifiedby</summary>
			public static readonly XrmFakedRelationship LkMsdynAibfileModifiedby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "modifiedby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "msdyn_aibfile",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_msdyn_aibfile_modifiedonbehalfby</summary>
			public static readonly XrmFakedRelationship LkMsdynAibfileModifiedonbehalfby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "modifiedonbehalfby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "msdyn_aibfile",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_msdyn_aibfileattacheddata_createdby</summary>
			public static readonly XrmFakedRelationship LkMsdynAibfileattacheddataCreatedby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "createdby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "msdyn_aibfileattacheddata",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_msdyn_aibfileattacheddata_createdonbehalfby</summary>
			public static readonly XrmFakedRelationship LkMsdynAibfileattacheddataCreatedonbehalfby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "createdonbehalfby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "msdyn_aibfileattacheddata",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_msdyn_aibfileattacheddata_modifiedby</summary>
			public static readonly XrmFakedRelationship LkMsdynAibfileattacheddataModifiedby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "modifiedby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "msdyn_aibfileattacheddata",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_msdyn_aibfileattacheddata_modifiedonbehalfby</summary>
			public static readonly XrmFakedRelationship LkMsdynAibfileattacheddataModifiedonbehalfby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "modifiedonbehalfby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "msdyn_aibfileattacheddata",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_msdyn_aiconfiguration_createdby</summary>
			public static readonly XrmFakedRelationship LkMsdynAiconfigurationCreatedby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "createdby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "msdyn_aiconfiguration",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_msdyn_aiconfiguration_createdonbehalfby</summary>
			public static readonly XrmFakedRelationship LkMsdynAiconfigurationCreatedonbehalfby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "createdonbehalfby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "msdyn_aiconfiguration",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_msdyn_aiconfiguration_modifiedby</summary>
			public static readonly XrmFakedRelationship LkMsdynAiconfigurationModifiedby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "modifiedby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "msdyn_aiconfiguration",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_msdyn_aiconfiguration_modifiedonbehalfby</summary>
			public static readonly XrmFakedRelationship LkMsdynAiconfigurationModifiedonbehalfby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "modifiedonbehalfby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "msdyn_aiconfiguration",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_msdyn_aifptrainingdocument_createdby</summary>
			public static readonly XrmFakedRelationship LkMsdynAifptrainingdocumentCreatedby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "createdby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "msdyn_aifptrainingdocument",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_msdyn_aifptrainingdocument_createdonbehalfby</summary>
			public static readonly XrmFakedRelationship LkMsdynAifptrainingdocumentCreatedonbehalfby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "createdonbehalfby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "msdyn_aifptrainingdocument",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_msdyn_aifptrainingdocument_modifiedby</summary>
			public static readonly XrmFakedRelationship LkMsdynAifptrainingdocumentModifiedby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "modifiedby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "msdyn_aifptrainingdocument",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_msdyn_aifptrainingdocument_modifiedonbehalfby</summary>
			public static readonly XrmFakedRelationship LkMsdynAifptrainingdocumentModifiedonbehalfby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "modifiedonbehalfby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "msdyn_aifptrainingdocument",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_msdyn_aimodel_createdby</summary>
			public static readonly XrmFakedRelationship LkMsdynAimodelCreatedby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "createdby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "msdyn_aimodel",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_msdyn_aimodel_createdonbehalfby</summary>
			public static readonly XrmFakedRelationship LkMsdynAimodelCreatedonbehalfby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "createdonbehalfby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "msdyn_aimodel",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_msdyn_aimodel_modifiedby</summary>
			public static readonly XrmFakedRelationship LkMsdynAimodelModifiedby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "modifiedby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "msdyn_aimodel",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_msdyn_aimodel_modifiedonbehalfby</summary>
			public static readonly XrmFakedRelationship LkMsdynAimodelModifiedonbehalfby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "modifiedonbehalfby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "msdyn_aimodel",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_msdyn_aiodimage_createdby</summary>
			public static readonly XrmFakedRelationship LkMsdynAiodimageCreatedby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "createdby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "msdyn_aiodimage",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_msdyn_aiodimage_createdonbehalfby</summary>
			public static readonly XrmFakedRelationship LkMsdynAiodimageCreatedonbehalfby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "createdonbehalfby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "msdyn_aiodimage",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_msdyn_aiodimage_modifiedby</summary>
			public static readonly XrmFakedRelationship LkMsdynAiodimageModifiedby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "modifiedby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "msdyn_aiodimage",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_msdyn_aiodimage_modifiedonbehalfby</summary>
			public static readonly XrmFakedRelationship LkMsdynAiodimageModifiedonbehalfby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "modifiedonbehalfby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "msdyn_aiodimage",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_msdyn_aiodlabel_createdby</summary>
			public static readonly XrmFakedRelationship LkMsdynAiodlabelCreatedby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "createdby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "msdyn_aiodlabel",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_msdyn_aiodlabel_createdonbehalfby</summary>
			public static readonly XrmFakedRelationship LkMsdynAiodlabelCreatedonbehalfby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "createdonbehalfby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "msdyn_aiodlabel",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_msdyn_aiodlabel_modifiedby</summary>
			public static readonly XrmFakedRelationship LkMsdynAiodlabelModifiedby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "modifiedby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "msdyn_aiodlabel",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_msdyn_aiodlabel_modifiedonbehalfby</summary>
			public static readonly XrmFakedRelationship LkMsdynAiodlabelModifiedonbehalfby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "modifiedonbehalfby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "msdyn_aiodlabel",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_msdyn_aiodtrainingboundingbox_createdby</summary>
			public static readonly XrmFakedRelationship LkMsdynAiodtrainingboundingboxCreatedby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "createdby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "msdyn_aiodtrainingboundingbox",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_msdyn_aiodtrainingboundingbox_createdonbehalfby</summary>
			public static readonly XrmFakedRelationship LkMsdynAiodtrainingboundingboxCreatedonbehalfby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "createdonbehalfby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "msdyn_aiodtrainingboundingbox",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_msdyn_aiodtrainingboundingbox_modifiedby</summary>
			public static readonly XrmFakedRelationship LkMsdynAiodtrainingboundingboxModifiedby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "modifiedby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "msdyn_aiodtrainingboundingbox",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_msdyn_aiodtrainingboundingbox_modifiedonbehalfby</summary>
			public static readonly XrmFakedRelationship LkMsdynAiodtrainingboundingboxModifiedonbehalfby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "modifiedonbehalfby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "msdyn_aiodtrainingboundingbox",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_msdyn_aiodtrainingimage_createdby</summary>
			public static readonly XrmFakedRelationship LkMsdynAiodtrainingimageCreatedby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "createdby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "msdyn_aiodtrainingimage",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_msdyn_aiodtrainingimage_createdonbehalfby</summary>
			public static readonly XrmFakedRelationship LkMsdynAiodtrainingimageCreatedonbehalfby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "createdonbehalfby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "msdyn_aiodtrainingimage",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_msdyn_aiodtrainingimage_modifiedby</summary>
			public static readonly XrmFakedRelationship LkMsdynAiodtrainingimageModifiedby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "modifiedby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "msdyn_aiodtrainingimage",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_msdyn_aiodtrainingimage_modifiedonbehalfby</summary>
			public static readonly XrmFakedRelationship LkMsdynAiodtrainingimageModifiedonbehalfby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "modifiedonbehalfby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "msdyn_aiodtrainingimage",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_msdyn_aitemplate_createdby</summary>
			public static readonly XrmFakedRelationship LkMsdynAitemplateCreatedby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "createdby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "msdyn_aitemplate",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_msdyn_aitemplate_createdonbehalfby</summary>
			public static readonly XrmFakedRelationship LkMsdynAitemplateCreatedonbehalfby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "createdonbehalfby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "msdyn_aitemplate",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_msdyn_aitemplate_modifiedby</summary>
			public static readonly XrmFakedRelationship LkMsdynAitemplateModifiedby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "modifiedby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "msdyn_aitemplate",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_msdyn_aitemplate_modifiedonbehalfby</summary>
			public static readonly XrmFakedRelationship LkMsdynAitemplateModifiedonbehalfby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "modifiedonbehalfby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "msdyn_aitemplate",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_msdyn_autocapturerule_createdby</summary>
			public static readonly XrmFakedRelationship LkMsdynAutocaptureruleCreatedby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "createdby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "msdyn_autocapturerule",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_msdyn_autocapturerule_createdonbehalfby</summary>
			public static readonly XrmFakedRelationship LkMsdynAutocaptureruleCreatedonbehalfby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "createdonbehalfby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "msdyn_autocapturerule",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_msdyn_autocapturerule_modifiedby</summary>
			public static readonly XrmFakedRelationship LkMsdynAutocaptureruleModifiedby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "modifiedby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "msdyn_autocapturerule",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_msdyn_autocapturerule_modifiedonbehalfby</summary>
			public static readonly XrmFakedRelationship LkMsdynAutocaptureruleModifiedonbehalfby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "modifiedonbehalfby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "msdyn_autocapturerule",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_msdyn_autocapturesettings_createdby</summary>
			public static readonly XrmFakedRelationship LkMsdynAutocapturesettingsCreatedby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "createdby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "msdyn_autocapturesettings",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_msdyn_autocapturesettings_createdonbehalfby</summary>
			public static readonly XrmFakedRelationship LkMsdynAutocapturesettingsCreatedonbehalfby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "createdonbehalfby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "msdyn_autocapturesettings",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_msdyn_autocapturesettings_modifiedby</summary>
			public static readonly XrmFakedRelationship LkMsdynAutocapturesettingsModifiedby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "modifiedby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "msdyn_autocapturesettings",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_msdyn_autocapturesettings_modifiedonbehalfby</summary>
			public static readonly XrmFakedRelationship LkMsdynAutocapturesettingsModifiedonbehalfby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "modifiedonbehalfby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "msdyn_autocapturesettings",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_msdyn_callablecontext_createdby</summary>
			public static readonly XrmFakedRelationship LkMsdynCallablecontextCreatedby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "createdby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "msdyn_callablecontext",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_msdyn_callablecontext_createdonbehalfby</summary>
			public static readonly XrmFakedRelationship LkMsdynCallablecontextCreatedonbehalfby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "createdonbehalfby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "msdyn_callablecontext",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_msdyn_callablecontext_modifiedby</summary>
			public static readonly XrmFakedRelationship LkMsdynCallablecontextModifiedby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "modifiedby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "msdyn_callablecontext",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_msdyn_callablecontext_modifiedonbehalfby</summary>
			public static readonly XrmFakedRelationship LkMsdynCallablecontextModifiedonbehalfby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "modifiedonbehalfby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "msdyn_callablecontext",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_msdyn_collabgraphresource_createdby</summary>
			public static readonly XrmFakedRelationship LkMsdynCollabgraphresourceCreatedby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "createdby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "msdyn_collabgraphresource",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_msdyn_collabgraphresource_createdonbehalfby</summary>
			public static readonly XrmFakedRelationship LkMsdynCollabgraphresourceCreatedonbehalfby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "createdonbehalfby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "msdyn_collabgraphresource",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_msdyn_collabgraphresource_modifiedby</summary>
			public static readonly XrmFakedRelationship LkMsdynCollabgraphresourceModifiedby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "modifiedby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "msdyn_collabgraphresource",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_msdyn_collabgraphresource_modifiedonbehalfby</summary>
			public static readonly XrmFakedRelationship LkMsdynCollabgraphresourceModifiedonbehalfby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "modifiedonbehalfby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "msdyn_collabgraphresource",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_msdyn_databaseversion_createdby</summary>
			public static readonly XrmFakedRelationship LkMsdynDatabaseversionCreatedby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "createdby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "msdyn_databaseversion",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_msdyn_databaseversion_createdonbehalfby</summary>
			public static readonly XrmFakedRelationship LkMsdynDatabaseversionCreatedonbehalfby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "createdonbehalfby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "msdyn_databaseversion",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_msdyn_databaseversion_modifiedby</summary>
			public static readonly XrmFakedRelationship LkMsdynDatabaseversionModifiedby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "modifiedby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "msdyn_databaseversion",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_msdyn_databaseversion_modifiedonbehalfby</summary>
			public static readonly XrmFakedRelationship LkMsdynDatabaseversionModifiedonbehalfby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "modifiedonbehalfby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "msdyn_databaseversion",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_msdyn_entityrankingrule_createdby</summary>
			public static readonly XrmFakedRelationship LkMsdynEntityrankingruleCreatedby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "createdby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "msdyn_entityrankingrule",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_msdyn_entityrankingrule_createdonbehalfby</summary>
			public static readonly XrmFakedRelationship LkMsdynEntityrankingruleCreatedonbehalfby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "createdonbehalfby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "msdyn_entityrankingrule",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_msdyn_entityrankingrule_modifiedby</summary>
			public static readonly XrmFakedRelationship LkMsdynEntityrankingruleModifiedby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "modifiedby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "msdyn_entityrankingrule",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_msdyn_entityrankingrule_modifiedonbehalfby</summary>
			public static readonly XrmFakedRelationship LkMsdynEntityrankingruleModifiedonbehalfby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "modifiedonbehalfby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "msdyn_entityrankingrule",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_msdyn_federatedarticle_createdby</summary>
			public static readonly XrmFakedRelationship LkMsdynFederatedarticleCreatedby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "createdby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "msdyn_federatedarticle",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_msdyn_federatedarticle_createdonbehalfby</summary>
			public static readonly XrmFakedRelationship LkMsdynFederatedarticleCreatedonbehalfby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "createdonbehalfby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "msdyn_federatedarticle",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_msdyn_federatedarticle_modifiedby</summary>
			public static readonly XrmFakedRelationship LkMsdynFederatedarticleModifiedby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "modifiedby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "msdyn_federatedarticle",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_msdyn_federatedarticle_modifiedonbehalfby</summary>
			public static readonly XrmFakedRelationship LkMsdynFederatedarticleModifiedonbehalfby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "modifiedonbehalfby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "msdyn_federatedarticle",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_msdyn_federatedarticleincident_createdby</summary>
			public static readonly XrmFakedRelationship LkMsdynFederatedarticleincidentCreatedby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "createdby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "msdyn_federatedarticleincident",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_msdyn_federatedarticleincident_createdonbehalfby</summary>
			public static readonly XrmFakedRelationship LkMsdynFederatedarticleincidentCreatedonbehalfby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "createdonbehalfby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "msdyn_federatedarticleincident",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_msdyn_federatedarticleincident_modifiedby</summary>
			public static readonly XrmFakedRelationship LkMsdynFederatedarticleincidentModifiedby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "modifiedby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "msdyn_federatedarticleincident",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_msdyn_federatedarticleincident_modifiedonbehalfby</summary>
			public static readonly XrmFakedRelationship LkMsdynFederatedarticleincidentModifiedonbehalfby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "modifiedonbehalfby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "msdyn_federatedarticleincident",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_msdyn_flowcardtype_createdby</summary>
			public static readonly XrmFakedRelationship LkMsdynFlowcardtypeCreatedby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "createdby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "msdyn_flowcardtype",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_msdyn_flowcardtype_createdonbehalfby</summary>
			public static readonly XrmFakedRelationship LkMsdynFlowcardtypeCreatedonbehalfby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "createdonbehalfby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "msdyn_flowcardtype",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_msdyn_flowcardtype_modifiedby</summary>
			public static readonly XrmFakedRelationship LkMsdynFlowcardtypeModifiedby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "modifiedby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "msdyn_flowcardtype",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_msdyn_flowcardtype_modifiedonbehalfby</summary>
			public static readonly XrmFakedRelationship LkMsdynFlowcardtypeModifiedonbehalfby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "modifiedonbehalfby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "msdyn_flowcardtype",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_msdyn_helppage_createdby</summary>
			public static readonly XrmFakedRelationship LkMsdynHelppageCreatedby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "createdby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "msdyn_helppage",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_msdyn_helppage_createdonbehalfby</summary>
			public static readonly XrmFakedRelationship LkMsdynHelppageCreatedonbehalfby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "createdonbehalfby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "msdyn_helppage",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_msdyn_helppage_modifiedby</summary>
			public static readonly XrmFakedRelationship LkMsdynHelppageModifiedby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "modifiedby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "msdyn_helppage",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_msdyn_helppage_modifiedonbehalfby</summary>
			public static readonly XrmFakedRelationship LkMsdynHelppageModifiedonbehalfby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "modifiedonbehalfby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "msdyn_helppage",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_msdyn_icebreakersconfig_createdby</summary>
			public static readonly XrmFakedRelationship LkMsdynIcebreakersconfigCreatedby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "createdby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "msdyn_icebreakersconfig",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_msdyn_icebreakersconfig_createdonbehalfby</summary>
			public static readonly XrmFakedRelationship LkMsdynIcebreakersconfigCreatedonbehalfby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "createdonbehalfby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "msdyn_icebreakersconfig",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_msdyn_icebreakersconfig_modifiedby</summary>
			public static readonly XrmFakedRelationship LkMsdynIcebreakersconfigModifiedby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "modifiedby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "msdyn_icebreakersconfig",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_msdyn_icebreakersconfig_modifiedonbehalfby</summary>
			public static readonly XrmFakedRelationship LkMsdynIcebreakersconfigModifiedonbehalfby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "modifiedonbehalfby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "msdyn_icebreakersconfig",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_msdyn_kmfederatedsearchconfig_createdby</summary>
			public static readonly XrmFakedRelationship LkMsdynKmfederatedsearchconfigCreatedby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "createdby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "msdyn_kmfederatedsearchconfig",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_msdyn_kmfederatedsearchconfig_createdonbehalfby</summary>
			public static readonly XrmFakedRelationship LkMsdynKmfederatedsearchconfigCreatedonbehalfby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "createdonbehalfby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "msdyn_kmfederatedsearchconfig",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_msdyn_kmfederatedsearchconfig_modifiedby</summary>
			public static readonly XrmFakedRelationship LkMsdynKmfederatedsearchconfigModifiedby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "modifiedby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "msdyn_kmfederatedsearchconfig",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_msdyn_kmfederatedsearchconfig_modifiedonbehalfby</summary>
			public static readonly XrmFakedRelationship LkMsdynKmfederatedsearchconfigModifiedonbehalfby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "modifiedonbehalfby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "msdyn_kmfederatedsearchconfig",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_msdyn_knowledgearticleimage_createdby</summary>
			public static readonly XrmFakedRelationship LkMsdynKnowledgearticleimageCreatedby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "createdby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "msdyn_knowledgearticleimage",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_msdyn_knowledgearticleimage_createdonbehalfby</summary>
			public static readonly XrmFakedRelationship LkMsdynKnowledgearticleimageCreatedonbehalfby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "createdonbehalfby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "msdyn_knowledgearticleimage",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_msdyn_knowledgearticleimage_modifiedby</summary>
			public static readonly XrmFakedRelationship LkMsdynKnowledgearticleimageModifiedby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "modifiedby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "msdyn_knowledgearticleimage",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_msdyn_knowledgearticleimage_modifiedonbehalfby</summary>
			public static readonly XrmFakedRelationship LkMsdynKnowledgearticleimageModifiedonbehalfby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "modifiedonbehalfby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "msdyn_knowledgearticleimage",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_msdyn_knowledgearticletemplate_createdby</summary>
			public static readonly XrmFakedRelationship LkMsdynKnowledgearticletemplateCreatedby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "createdby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "msdyn_knowledgearticletemplate",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_msdyn_knowledgearticletemplate_createdonbehalfby</summary>
			public static readonly XrmFakedRelationship LkMsdynKnowledgearticletemplateCreatedonbehalfby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "createdonbehalfby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "msdyn_knowledgearticletemplate",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_msdyn_knowledgearticletemplate_modifiedby</summary>
			public static readonly XrmFakedRelationship LkMsdynKnowledgearticletemplateModifiedby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "modifiedby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "msdyn_knowledgearticletemplate",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_msdyn_knowledgearticletemplate_modifiedonbehalfby</summary>
			public static readonly XrmFakedRelationship LkMsdynKnowledgearticletemplateModifiedonbehalfby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "modifiedonbehalfby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "msdyn_knowledgearticletemplate",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_msdyn_knowledgeinteractioninsight_createdby</summary>
			public static readonly XrmFakedRelationship LkMsdynKnowledgeinteractioninsightCreatedby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "createdby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "msdyn_knowledgeinteractioninsight",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_msdyn_knowledgeinteractioninsight_createdonbehalfby</summary>
			public static readonly XrmFakedRelationship LkMsdynKnowledgeinteractioninsightCreatedonbehalfby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "createdonbehalfby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "msdyn_knowledgeinteractioninsight",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_msdyn_knowledgeinteractioninsight_modifiedby</summary>
			public static readonly XrmFakedRelationship LkMsdynKnowledgeinteractioninsightModifiedby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "modifiedby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "msdyn_knowledgeinteractioninsight",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_msdyn_knowledgeinteractioninsight_modifiedonbehalfby</summary>
			public static readonly XrmFakedRelationship LkMsdynKnowledgeinteractioninsightModifiedonbehalfby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "modifiedonbehalfby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "msdyn_knowledgeinteractioninsight",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_msdyn_knowledgesearchinsight_createdby</summary>
			public static readonly XrmFakedRelationship LkMsdynKnowledgesearchinsightCreatedby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "createdby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "msdyn_knowledgesearchinsight",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_msdyn_knowledgesearchinsight_createdonbehalfby</summary>
			public static readonly XrmFakedRelationship LkMsdynKnowledgesearchinsightCreatedonbehalfby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "createdonbehalfby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "msdyn_knowledgesearchinsight",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_msdyn_knowledgesearchinsight_modifiedby</summary>
			public static readonly XrmFakedRelationship LkMsdynKnowledgesearchinsightModifiedby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "modifiedby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "msdyn_knowledgesearchinsight",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_msdyn_knowledgesearchinsight_modifiedonbehalfby</summary>
			public static readonly XrmFakedRelationship LkMsdynKnowledgesearchinsightModifiedonbehalfby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "modifiedonbehalfby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "msdyn_knowledgesearchinsight",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_msdyn_msteamssetting_createdby</summary>
			public static readonly XrmFakedRelationship LkMsdynMsteamssettingCreatedby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "createdby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "msdyn_msteamssetting",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_msdyn_msteamssetting_createdonbehalfby</summary>
			public static readonly XrmFakedRelationship LkMsdynMsteamssettingCreatedonbehalfby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "createdonbehalfby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "msdyn_msteamssetting",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_msdyn_msteamssetting_modifiedby</summary>
			public static readonly XrmFakedRelationship LkMsdynMsteamssettingModifiedby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "modifiedby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "msdyn_msteamssetting",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_msdyn_msteamssetting_modifiedonbehalfby</summary>
			public static readonly XrmFakedRelationship LkMsdynMsteamssettingModifiedonbehalfby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "modifiedonbehalfby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "msdyn_msteamssetting",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_msdyn_msteamssettingsv2_createdby</summary>
			public static readonly XrmFakedRelationship LkMsdynMsteamssettingsv2Createdby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "createdby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "msdyn_msteamssettingsv2",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_msdyn_msteamssettingsv2_createdonbehalfby</summary>
			public static readonly XrmFakedRelationship LkMsdynMsteamssettingsv2Createdonbehalfby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "createdonbehalfby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "msdyn_msteamssettingsv2",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_msdyn_msteamssettingsv2_modifiedby</summary>
			public static readonly XrmFakedRelationship LkMsdynMsteamssettingsv2Modifiedby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "modifiedby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "msdyn_msteamssettingsv2",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_msdyn_msteamssettingsv2_modifiedonbehalfby</summary>
			public static readonly XrmFakedRelationship LkMsdynMsteamssettingsv2Modifiedonbehalfby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "modifiedonbehalfby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "msdyn_msteamssettingsv2",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_msdyn_notesanalysisconfig_createdby</summary>
			public static readonly XrmFakedRelationship LkMsdynNotesanalysisconfigCreatedby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "createdby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "msdyn_notesanalysisconfig",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_msdyn_notesanalysisconfig_createdonbehalfby</summary>
			public static readonly XrmFakedRelationship LkMsdynNotesanalysisconfigCreatedonbehalfby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "createdonbehalfby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "msdyn_notesanalysisconfig",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_msdyn_notesanalysisconfig_modifiedby</summary>
			public static readonly XrmFakedRelationship LkMsdynNotesanalysisconfigModifiedby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "modifiedby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "msdyn_notesanalysisconfig",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_msdyn_notesanalysisconfig_modifiedonbehalfby</summary>
			public static readonly XrmFakedRelationship LkMsdynNotesanalysisconfigModifiedonbehalfby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "modifiedonbehalfby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "msdyn_notesanalysisconfig",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_msdyn_playbookactivity_createdby</summary>
			public static readonly XrmFakedRelationship LkMsdynPlaybookactivityCreatedby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "createdby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "msdyn_playbookactivity",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_msdyn_playbookactivity_createdonbehalfby</summary>
			public static readonly XrmFakedRelationship LkMsdynPlaybookactivityCreatedonbehalfby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "createdonbehalfby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "msdyn_playbookactivity",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_msdyn_playbookactivity_modifiedby</summary>
			public static readonly XrmFakedRelationship LkMsdynPlaybookactivityModifiedby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "modifiedby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "msdyn_playbookactivity",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_msdyn_playbookactivity_modifiedonbehalfby</summary>
			public static readonly XrmFakedRelationship LkMsdynPlaybookactivityModifiedonbehalfby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "modifiedonbehalfby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "msdyn_playbookactivity",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_msdyn_playbookactivityattribute_createdby</summary>
			public static readonly XrmFakedRelationship LkMsdynPlaybookactivityattributeCreatedby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "createdby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "msdyn_playbookactivityattribute",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_msdyn_playbookactivityattribute_createdonbehalfby</summary>
			public static readonly XrmFakedRelationship LkMsdynPlaybookactivityattributeCreatedonbehalfby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "createdonbehalfby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "msdyn_playbookactivityattribute",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_msdyn_playbookactivityattribute_modifiedby</summary>
			public static readonly XrmFakedRelationship LkMsdynPlaybookactivityattributeModifiedby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "modifiedby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "msdyn_playbookactivityattribute",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_msdyn_playbookactivityattribute_modifiedonbehalfby</summary>
			public static readonly XrmFakedRelationship LkMsdynPlaybookactivityattributeModifiedonbehalfby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "modifiedonbehalfby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "msdyn_playbookactivityattribute",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_msdyn_playbookcategory_createdby</summary>
			public static readonly XrmFakedRelationship LkMsdynPlaybookcategoryCreatedby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "createdby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "msdyn_playbookcategory",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_msdyn_playbookcategory_createdonbehalfby</summary>
			public static readonly XrmFakedRelationship LkMsdynPlaybookcategoryCreatedonbehalfby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "createdonbehalfby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "msdyn_playbookcategory",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_msdyn_playbookcategory_modifiedby</summary>
			public static readonly XrmFakedRelationship LkMsdynPlaybookcategoryModifiedby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "modifiedby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "msdyn_playbookcategory",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_msdyn_playbookcategory_modifiedonbehalfby</summary>
			public static readonly XrmFakedRelationship LkMsdynPlaybookcategoryModifiedonbehalfby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "modifiedonbehalfby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "msdyn_playbookcategory",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_msdyn_playbookinstance_createdby</summary>
			public static readonly XrmFakedRelationship LkMsdynPlaybookinstanceCreatedby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "createdby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "msdyn_playbookinstance",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_msdyn_playbookinstance_createdonbehalfby</summary>
			public static readonly XrmFakedRelationship LkMsdynPlaybookinstanceCreatedonbehalfby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "createdonbehalfby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "msdyn_playbookinstance",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_msdyn_playbookinstance_modifiedby</summary>
			public static readonly XrmFakedRelationship LkMsdynPlaybookinstanceModifiedby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "modifiedby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "msdyn_playbookinstance",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_msdyn_playbookinstance_modifiedonbehalfby</summary>
			public static readonly XrmFakedRelationship LkMsdynPlaybookinstanceModifiedonbehalfby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "modifiedonbehalfby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "msdyn_playbookinstance",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_msdyn_playbooktemplate_createdby</summary>
			public static readonly XrmFakedRelationship LkMsdynPlaybooktemplateCreatedby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "createdby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "msdyn_playbooktemplate",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_msdyn_playbooktemplate_createdonbehalfby</summary>
			public static readonly XrmFakedRelationship LkMsdynPlaybooktemplateCreatedonbehalfby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "createdonbehalfby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "msdyn_playbooktemplate",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_msdyn_playbooktemplate_modifiedby</summary>
			public static readonly XrmFakedRelationship LkMsdynPlaybooktemplateModifiedby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "modifiedby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "msdyn_playbooktemplate",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_msdyn_playbooktemplate_modifiedonbehalfby</summary>
			public static readonly XrmFakedRelationship LkMsdynPlaybooktemplateModifiedonbehalfby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "modifiedonbehalfby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "msdyn_playbooktemplate",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_msdyn_postalbum_createdby</summary>
			public static readonly XrmFakedRelationship LkMsdynPostalbumCreatedby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "createdby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "msdyn_postalbum",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_msdyn_postalbum_createdonbehalfby</summary>
			public static readonly XrmFakedRelationship LkMsdynPostalbumCreatedonbehalfby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "createdonbehalfby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "msdyn_postalbum",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_msdyn_postalbum_modifiedby</summary>
			public static readonly XrmFakedRelationship LkMsdynPostalbumModifiedby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "modifiedby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "msdyn_postalbum",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_msdyn_postalbum_modifiedonbehalfby</summary>
			public static readonly XrmFakedRelationship LkMsdynPostalbumModifiedonbehalfby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "modifiedonbehalfby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "msdyn_postalbum",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_msdyn_postconfig_createdby</summary>
			public static readonly XrmFakedRelationship LkMsdynPostconfigCreatedby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "createdby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "msdyn_postconfig",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_msdyn_postconfig_createdonbehalfby</summary>
			public static readonly XrmFakedRelationship LkMsdynPostconfigCreatedonbehalfby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "createdonbehalfby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "msdyn_postconfig",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_msdyn_postconfig_modifiedby</summary>
			public static readonly XrmFakedRelationship LkMsdynPostconfigModifiedby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "modifiedby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "msdyn_postconfig",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_msdyn_postconfig_modifiedonbehalfby</summary>
			public static readonly XrmFakedRelationship LkMsdynPostconfigModifiedonbehalfby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "modifiedonbehalfby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "msdyn_postconfig",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_msdyn_postruleconfig_createdby</summary>
			public static readonly XrmFakedRelationship LkMsdynPostruleconfigCreatedby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "createdby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "msdyn_postruleconfig",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_msdyn_postruleconfig_createdonbehalfby</summary>
			public static readonly XrmFakedRelationship LkMsdynPostruleconfigCreatedonbehalfby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "createdonbehalfby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "msdyn_postruleconfig",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_msdyn_postruleconfig_modifiedby</summary>
			public static readonly XrmFakedRelationship LkMsdynPostruleconfigModifiedby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "modifiedby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "msdyn_postruleconfig",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_msdyn_postruleconfig_modifiedonbehalfby</summary>
			public static readonly XrmFakedRelationship LkMsdynPostruleconfigModifiedonbehalfby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "modifiedonbehalfby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "msdyn_postruleconfig",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_msdyn_relationshipinsightsunifiedconfig_createdby</summary>
			public static readonly XrmFakedRelationship LkMsdynRelationshipinsightsunifiedconfigCreatedby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "createdby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "msdyn_relationshipinsightsunifiedconfig",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_msdyn_relationshipinsightsunifiedconfig_createdonbehalfby</summary>
			public static readonly XrmFakedRelationship LkMsdynRelationshipinsightsunifiedconfigCreatedonbehalfby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "createdonbehalfby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "msdyn_relationshipinsightsunifiedconfig",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_msdyn_relationshipinsightsunifiedconfig_modifiedby</summary>
			public static readonly XrmFakedRelationship LkMsdynRelationshipinsightsunifiedconfigModifiedby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "modifiedby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "msdyn_relationshipinsightsunifiedconfig",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_msdyn_relationshipinsightsunifiedconfig_modifiedonbehalfby</summary>
			public static readonly XrmFakedRelationship LkMsdynRelationshipinsightsunifiedconfigModifiedonbehalfby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "modifiedonbehalfby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "msdyn_relationshipinsightsunifiedconfig",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_msdyn_richtextfile_createdby</summary>
			public static readonly XrmFakedRelationship LkMsdynRichtextfileCreatedby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "createdby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "msdyn_richtextfile",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_msdyn_richtextfile_createdonbehalfby</summary>
			public static readonly XrmFakedRelationship LkMsdynRichtextfileCreatedonbehalfby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "createdonbehalfby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "msdyn_richtextfile",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_msdyn_richtextfile_modifiedby</summary>
			public static readonly XrmFakedRelationship LkMsdynRichtextfileModifiedby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "modifiedby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "msdyn_richtextfile",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_msdyn_richtextfile_modifiedonbehalfby</summary>
			public static readonly XrmFakedRelationship LkMsdynRichtextfileModifiedonbehalfby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "modifiedonbehalfby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "msdyn_richtextfile",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_msdyn_salesinsightssettings_createdby</summary>
			public static readonly XrmFakedRelationship LkMsdynSalesinsightssettingsCreatedby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "createdby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "msdyn_salesinsightssettings",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_msdyn_salesinsightssettings_createdonbehalfby</summary>
			public static readonly XrmFakedRelationship LkMsdynSalesinsightssettingsCreatedonbehalfby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "createdonbehalfby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "msdyn_salesinsightssettings",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_msdyn_salesinsightssettings_modifiedby</summary>
			public static readonly XrmFakedRelationship LkMsdynSalesinsightssettingsModifiedby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "modifiedby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "msdyn_salesinsightssettings",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_msdyn_salesinsightssettings_modifiedonbehalfby</summary>
			public static readonly XrmFakedRelationship LkMsdynSalesinsightssettingsModifiedonbehalfby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "modifiedonbehalfby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "msdyn_salesinsightssettings",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_msdyn_siconfig_createdby</summary>
			public static readonly XrmFakedRelationship LkMsdynSiconfigCreatedby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "createdby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "msdyn_siconfig",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_msdyn_siconfig_createdonbehalfby</summary>
			public static readonly XrmFakedRelationship LkMsdynSiconfigCreatedonbehalfby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "createdonbehalfby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "msdyn_siconfig",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_msdyn_siconfig_modifiedby</summary>
			public static readonly XrmFakedRelationship LkMsdynSiconfigModifiedby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "modifiedby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "msdyn_siconfig",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_msdyn_siconfig_modifiedonbehalfby</summary>
			public static readonly XrmFakedRelationship LkMsdynSiconfigModifiedonbehalfby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "modifiedonbehalfby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "msdyn_siconfig",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_msdyn_sikeyvalueconfig_createdby</summary>
			public static readonly XrmFakedRelationship LkMsdynSikeyvalueconfigCreatedby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "createdby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "msdyn_sikeyvalueconfig",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_msdyn_sikeyvalueconfig_createdonbehalfby</summary>
			public static readonly XrmFakedRelationship LkMsdynSikeyvalueconfigCreatedonbehalfby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "createdonbehalfby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "msdyn_sikeyvalueconfig",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_msdyn_sikeyvalueconfig_modifiedby</summary>
			public static readonly XrmFakedRelationship LkMsdynSikeyvalueconfigModifiedby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "modifiedby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "msdyn_sikeyvalueconfig",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_msdyn_sikeyvalueconfig_modifiedonbehalfby</summary>
			public static readonly XrmFakedRelationship LkMsdynSikeyvalueconfigModifiedonbehalfby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "modifiedonbehalfby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "msdyn_sikeyvalueconfig",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_msdyn_teamscollaboration_createdby</summary>
			public static readonly XrmFakedRelationship LkMsdynTeamscollaborationCreatedby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "createdby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "msdyn_teamscollaboration",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_msdyn_teamscollaboration_createdonbehalfby</summary>
			public static readonly XrmFakedRelationship LkMsdynTeamscollaborationCreatedonbehalfby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "createdonbehalfby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "msdyn_teamscollaboration",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_msdyn_teamscollaboration_modifiedby</summary>
			public static readonly XrmFakedRelationship LkMsdynTeamscollaborationModifiedby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "modifiedby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "msdyn_teamscollaboration",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_msdyn_teamscollaboration_modifiedonbehalfby</summary>
			public static readonly XrmFakedRelationship LkMsdynTeamscollaborationModifiedonbehalfby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "modifiedonbehalfby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "msdyn_teamscollaboration",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_msdyn_tour_createdby</summary>
			public static readonly XrmFakedRelationship LkMsdynTourCreatedby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "createdby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "msdyn_tour",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_msdyn_tour_createdonbehalfby</summary>
			public static readonly XrmFakedRelationship LkMsdynTourCreatedonbehalfby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "createdonbehalfby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "msdyn_tour",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_msdyn_tour_modifiedby</summary>
			public static readonly XrmFakedRelationship LkMsdynTourModifiedby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "modifiedby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "msdyn_tour",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_msdyn_tour_modifiedonbehalfby</summary>
			public static readonly XrmFakedRelationship LkMsdynTourModifiedonbehalfby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "modifiedonbehalfby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "msdyn_tour",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_msdyn_untrackedappointment_createdby</summary>
			public static readonly XrmFakedRelationship LkMsdynUntrackedappointmentCreatedby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "createdby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "msdyn_untrackedappointment",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_msdyn_untrackedappointment_createdonbehalfby</summary>
			public static readonly XrmFakedRelationship LkMsdynUntrackedappointmentCreatedonbehalfby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "createdonbehalfby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "msdyn_untrackedappointment",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_msdyn_untrackedappointment_modifiedby</summary>
			public static readonly XrmFakedRelationship LkMsdynUntrackedappointmentModifiedby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "modifiedby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "msdyn_untrackedappointment",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_msdyn_untrackedappointment_modifiedonbehalfby</summary>
			public static readonly XrmFakedRelationship LkMsdynUntrackedappointmentModifiedonbehalfby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "modifiedonbehalfby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "msdyn_untrackedappointment",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_msdyn_upgraderun_createdby</summary>
			public static readonly XrmFakedRelationship LkMsdynUpgraderunCreatedby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "createdby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "msdyn_upgraderun",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_msdyn_upgraderun_createdonbehalfby</summary>
			public static readonly XrmFakedRelationship LkMsdynUpgraderunCreatedonbehalfby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "createdonbehalfby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "msdyn_upgraderun",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_msdyn_upgraderun_modifiedby</summary>
			public static readonly XrmFakedRelationship LkMsdynUpgraderunModifiedby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "modifiedby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "msdyn_upgraderun",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_msdyn_upgraderun_modifiedonbehalfby</summary>
			public static readonly XrmFakedRelationship LkMsdynUpgraderunModifiedonbehalfby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "modifiedonbehalfby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "msdyn_upgraderun",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_msdyn_upgradestep_createdby</summary>
			public static readonly XrmFakedRelationship LkMsdynUpgradestepCreatedby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "createdby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "msdyn_upgradestep",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_msdyn_upgradestep_createdonbehalfby</summary>
			public static readonly XrmFakedRelationship LkMsdynUpgradestepCreatedonbehalfby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "createdonbehalfby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "msdyn_upgradestep",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_msdyn_upgradestep_modifiedby</summary>
			public static readonly XrmFakedRelationship LkMsdynUpgradestepModifiedby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "modifiedby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "msdyn_upgradestep",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_msdyn_upgradestep_modifiedonbehalfby</summary>
			public static readonly XrmFakedRelationship LkMsdynUpgradestepModifiedonbehalfby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "modifiedonbehalfby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "msdyn_upgradestep",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_msdyn_upgradeversion_createdby</summary>
			public static readonly XrmFakedRelationship LkMsdynUpgradeversionCreatedby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "createdby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "msdyn_upgradeversion",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_msdyn_upgradeversion_createdonbehalfby</summary>
			public static readonly XrmFakedRelationship LkMsdynUpgradeversionCreatedonbehalfby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "createdonbehalfby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "msdyn_upgradeversion",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_msdyn_upgradeversion_modifiedby</summary>
			public static readonly XrmFakedRelationship LkMsdynUpgradeversionModifiedby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "modifiedby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "msdyn_upgradeversion",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_msdyn_upgradeversion_modifiedonbehalfby</summary>
			public static readonly XrmFakedRelationship LkMsdynUpgradeversionModifiedonbehalfby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "modifiedonbehalfby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "msdyn_upgradeversion",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_msdyn_wallsavedquery_createdby</summary>
			public static readonly XrmFakedRelationship LkMsdynWallsavedqueryCreatedby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "createdby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "msdyn_wallsavedquery",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_msdyn_wallsavedquery_createdonbehalfby</summary>
			public static readonly XrmFakedRelationship LkMsdynWallsavedqueryCreatedonbehalfby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "createdonbehalfby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "msdyn_wallsavedquery",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_msdyn_wallsavedquery_modifiedby</summary>
			public static readonly XrmFakedRelationship LkMsdynWallsavedqueryModifiedby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "modifiedby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "msdyn_wallsavedquery",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_msdyn_wallsavedquery_modifiedonbehalfby</summary>
			public static readonly XrmFakedRelationship LkMsdynWallsavedqueryModifiedonbehalfby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "modifiedonbehalfby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "msdyn_wallsavedquery",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_msdyn_wallsavedqueryusersettings_createdby</summary>
			public static readonly XrmFakedRelationship LkMsdynWallsavedqueryusersettingsCreatedby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "createdby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "msdyn_wallsavedqueryusersettings",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_msdyn_wallsavedqueryusersettings_createdonbehalfby</summary>
			public static readonly XrmFakedRelationship LkMsdynWallsavedqueryusersettingsCreatedonbehalfby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "createdonbehalfby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "msdyn_wallsavedqueryusersettings",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_msdyn_wallsavedqueryusersettings_modifiedby</summary>
			public static readonly XrmFakedRelationship LkMsdynWallsavedqueryusersettingsModifiedby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "modifiedby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "msdyn_wallsavedqueryusersettings",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_msdyn_wallsavedqueryusersettings_modifiedonbehalfby</summary>
			public static readonly XrmFakedRelationship LkMsdynWallsavedqueryusersettingsModifiedonbehalfby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "modifiedonbehalfby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "msdyn_wallsavedqueryusersettings",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_msdynce_botcontent_createdby</summary>
			public static readonly XrmFakedRelationship LkMsdynceBotcontentCreatedby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "createdby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "msdynce_botcontent",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_msdynce_botcontent_createdonbehalfby</summary>
			public static readonly XrmFakedRelationship LkMsdynceBotcontentCreatedonbehalfby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "createdonbehalfby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "msdynce_botcontent",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_msdynce_botcontent_modifiedby</summary>
			public static readonly XrmFakedRelationship LkMsdynceBotcontentModifiedby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "modifiedby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "msdynce_botcontent",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_msdynce_botcontent_modifiedonbehalfby</summary>
			public static readonly XrmFakedRelationship LkMsdynceBotcontentModifiedonbehalfby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "modifiedonbehalfby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "msdynce_botcontent",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_navigationsetting_createdby</summary>
			public static readonly XrmFakedRelationship LkNavigationsettingCreatedby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "createdby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "navigationsetting",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_navigationsetting_createdonbehalfby</summary>
			public static readonly XrmFakedRelationship LkNavigationsettingCreatedonbehalfby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "createdonbehalfby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "navigationsetting",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_navigationsetting_modifiedby</summary>
			public static readonly XrmFakedRelationship LkNavigationsettingModifiedby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "modifiedby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "navigationsetting",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_navigationsetting_modifiedonbehalfby</summary>
			public static readonly XrmFakedRelationship LkNavigationsettingModifiedonbehalfby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "modifiedonbehalfby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "navigationsetting",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_newprocess_createdby</summary>
			public static readonly XrmFakedRelationship LkNewprocessCreatedby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "createdby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "newprocess",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_newprocess_createdonbehalfby</summary>
			public static readonly XrmFakedRelationship LkNewprocessCreatedonbehalfby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "createdonbehalfby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "newprocess",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_newprocess_modifiedby</summary>
			public static readonly XrmFakedRelationship LkNewprocessModifiedby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "modifiedby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "newprocess",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_newprocess_modifiedonbehalfby</summary>
			public static readonly XrmFakedRelationship LkNewprocessModifiedonbehalfby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "modifiedonbehalfby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "newprocess",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_officegraphdocument_createdonbehalfby</summary>
			public static readonly XrmFakedRelationship LkOfficegraphdocumentCreatedonbehalfby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "createdonbehalfby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "officegraphdocument",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_officegraphdocument_modifiedonbehalfby</summary>
			public static readonly XrmFakedRelationship LkOfficegraphdocumentModifiedonbehalfby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "modifiedonbehalfby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "officegraphdocument",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_opportunity_createdonbehalfby</summary>
			public static readonly XrmFakedRelationship LkOpportunityCreatedonbehalfby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "createdonbehalfby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "opportunity",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_opportunity_modifiedonbehalfby</summary>
			public static readonly XrmFakedRelationship LkOpportunityModifiedonbehalfby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "modifiedonbehalfby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "opportunity",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_opportunitybase_createdby</summary>
			public static readonly XrmFakedRelationship LkOpportunitybaseCreatedby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "createdby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "opportunity",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_opportunitybase_modifiedby</summary>
			public static readonly XrmFakedRelationship LkOpportunitybaseModifiedby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "modifiedby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "opportunity",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_opportunityclose_createdby</summary>
			public static readonly XrmFakedRelationship LkOpportunitycloseCreatedby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "createdby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "opportunityclose",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_opportunityclose_createdonbehalfby</summary>
			public static readonly XrmFakedRelationship LkOpportunitycloseCreatedonbehalfby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "createdonbehalfby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "opportunityclose",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_opportunityclose_modifiedby</summary>
			public static readonly XrmFakedRelationship LkOpportunitycloseModifiedby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "modifiedby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "opportunityclose",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_opportunityclose_modifiedonbehalfby</summary>
			public static readonly XrmFakedRelationship LkOpportunitycloseModifiedonbehalfby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "modifiedonbehalfby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "opportunityclose",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_opportunityproduct_createdonbehalfby</summary>
			public static readonly XrmFakedRelationship LkOpportunityproductCreatedonbehalfby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "createdonbehalfby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "opportunityproduct",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_opportunityproduct_modifiedonbehalfby</summary>
			public static readonly XrmFakedRelationship LkOpportunityproductModifiedonbehalfby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "modifiedonbehalfby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "opportunityproduct",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_opportunityproductbase_createdby</summary>
			public static readonly XrmFakedRelationship LkOpportunityproductbaseCreatedby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "createdby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "opportunityproduct",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_opportunityproductbase_modifiedby</summary>
			public static readonly XrmFakedRelationship LkOpportunityproductbaseModifiedby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "modifiedby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "opportunityproduct",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_opportunitysalesprocess_createdby</summary>
			public static readonly XrmFakedRelationship LkOpportunitysalesprocessCreatedby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "createdby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "opportunitysalesprocess",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_opportunitysalesprocess_createdonbehalfby</summary>
			public static readonly XrmFakedRelationship LkOpportunitysalesprocessCreatedonbehalfby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "createdonbehalfby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "opportunitysalesprocess",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_opportunitysalesprocess_modifiedby</summary>
			public static readonly XrmFakedRelationship LkOpportunitysalesprocessModifiedby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "modifiedby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "opportunitysalesprocess",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_opportunitysalesprocess_modifiedonbehalfby</summary>
			public static readonly XrmFakedRelationship LkOpportunitysalesprocessModifiedonbehalfby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "modifiedonbehalfby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "opportunitysalesprocess",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_orderclose_createdby</summary>
			public static readonly XrmFakedRelationship LkOrdercloseCreatedby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "createdby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "orderclose",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_orderclose_createdonbehalfby</summary>
			public static readonly XrmFakedRelationship LkOrdercloseCreatedonbehalfby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "createdonbehalfby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "orderclose",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_orderclose_modifiedby</summary>
			public static readonly XrmFakedRelationship LkOrdercloseModifiedby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "modifiedby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "orderclose",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_orderclose_modifiedonbehalfby</summary>
			public static readonly XrmFakedRelationship LkOrdercloseModifiedonbehalfby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "modifiedonbehalfby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "orderclose",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_organization_createdonbehalfby</summary>
			public static readonly XrmFakedRelationship LkOrganizationCreatedonbehalfby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "createdonbehalfby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "organization",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_organization_modifiedonbehalfby</summary>
			public static readonly XrmFakedRelationship LkOrganizationModifiedonbehalfby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "modifiedonbehalfby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "organization",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_organizationbase_createdby</summary>
			public static readonly XrmFakedRelationship LkOrganizationbaseCreatedby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "createdby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "organization",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_organizationbase_modifiedby</summary>
			public static readonly XrmFakedRelationship LkOrganizationbaseModifiedby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "modifiedby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "organization",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_ownermapping_createdby</summary>
			public static readonly XrmFakedRelationship LkOwnermappingCreatedby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "createdby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "ownermapping",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_ownermapping_createdonbehalfby</summary>
			public static readonly XrmFakedRelationship LkOwnermappingCreatedonbehalfby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "createdonbehalfby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "ownermapping",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_ownermapping_modifiedby</summary>
			public static readonly XrmFakedRelationship LkOwnermappingModifiedby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "modifiedby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "ownermapping",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_ownermapping_modifiedonbehalfby</summary>
			public static readonly XrmFakedRelationship LkOwnermappingModifiedonbehalfby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "modifiedonbehalfby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "ownermapping",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_package_createdby</summary>
			public static readonly XrmFakedRelationship LkPackageCreatedby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "createdby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "package",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_package_createdonbehalfby</summary>
			public static readonly XrmFakedRelationship LkPackageCreatedonbehalfby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "createdonbehalfby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "package",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_package_modifiedby</summary>
			public static readonly XrmFakedRelationship LkPackageModifiedby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "modifiedby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "package",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_package_modifiedonbehalfby</summary>
			public static readonly XrmFakedRelationship LkPackageModifiedonbehalfby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "modifiedonbehalfby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "package",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_personaldocumenttemplatebase_createdby</summary>
			public static readonly XrmFakedRelationship LkPersonaldocumenttemplatebaseCreatedby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "createdby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "personaldocumenttemplate",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_personaldocumenttemplatebase_createdonbehalfby</summary>
			public static readonly XrmFakedRelationship LkPersonaldocumenttemplatebaseCreatedonbehalfby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "createdonbehalfby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "personaldocumenttemplate",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_personaldocumenttemplatebase_modifiedby</summary>
			public static readonly XrmFakedRelationship LkPersonaldocumenttemplatebaseModifiedby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "modifiedby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "personaldocumenttemplate",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_personaldocumenttemplatebase_modifiedonbehalfby</summary>
			public static readonly XrmFakedRelationship LkPersonaldocumenttemplatebaseModifiedonbehalfby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "modifiedonbehalfby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "personaldocumenttemplate",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_phonecall_createdby</summary>
			public static readonly XrmFakedRelationship LkPhonecallCreatedby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "createdby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "phonecall",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_phonecall_createdonbehalfby</summary>
			public static readonly XrmFakedRelationship LkPhonecallCreatedonbehalfby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "createdonbehalfby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "phonecall",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_phonecall_modifiedby</summary>
			public static readonly XrmFakedRelationship LkPhonecallModifiedby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "modifiedby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "phonecall",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_phonecall_modifiedonbehalfby</summary>
			public static readonly XrmFakedRelationship LkPhonecallModifiedonbehalfby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "modifiedonbehalfby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "phonecall",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_phonetocaseprocess_createdby</summary>
			public static readonly XrmFakedRelationship LkPhonetocaseprocessCreatedby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "createdby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "phonetocaseprocess",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_phonetocaseprocess_createdonbehalfby</summary>
			public static readonly XrmFakedRelationship LkPhonetocaseprocessCreatedonbehalfby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "createdonbehalfby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "phonetocaseprocess",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_phonetocaseprocess_modifiedby</summary>
			public static readonly XrmFakedRelationship LkPhonetocaseprocessModifiedby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "modifiedby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "phonetocaseprocess",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_phonetocaseprocess_modifiedonbehalfby</summary>
			public static readonly XrmFakedRelationship LkPhonetocaseprocessModifiedonbehalfby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "modifiedonbehalfby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "phonetocaseprocess",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_picklistmapping_createdby</summary>
			public static readonly XrmFakedRelationship LkPicklistmappingCreatedby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "createdby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "picklistmapping",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_picklistmapping_createdonbehalfby</summary>
			public static readonly XrmFakedRelationship LkPicklistmappingCreatedonbehalfby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "createdonbehalfby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "picklistmapping",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_picklistmapping_modifiedby</summary>
			public static readonly XrmFakedRelationship LkPicklistmappingModifiedby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "modifiedby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "picklistmapping",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_picklistmapping_modifiedonbehalfby</summary>
			public static readonly XrmFakedRelationship LkPicklistmappingModifiedonbehalfby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "modifiedonbehalfby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "picklistmapping",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_pluginassembly_createdonbehalfby</summary>
			public static readonly XrmFakedRelationship LkPluginassemblyCreatedonbehalfby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "createdonbehalfby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "pluginassembly",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_pluginassembly_modifiedonbehalfby</summary>
			public static readonly XrmFakedRelationship LkPluginassemblyModifiedonbehalfby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "modifiedonbehalfby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "pluginassembly",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_plugintracelogbase_createdonbehalfby</summary>
			public static readonly XrmFakedRelationship LkPlugintracelogbaseCreatedonbehalfby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "createdonbehalfby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "plugintracelog",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_plugintype_createdonbehalfby</summary>
			public static readonly XrmFakedRelationship LkPlugintypeCreatedonbehalfby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "createdonbehalfby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "plugintype",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_plugintype_modifiedonbehalfby</summary>
			public static readonly XrmFakedRelationship LkPlugintypeModifiedonbehalfby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "modifiedonbehalfby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "plugintype",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_plugintypestatisticbase_createdonbehalfby</summary>
			public static readonly XrmFakedRelationship LkPlugintypestatisticbaseCreatedonbehalfby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "createdonbehalfby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "plugintypestatistic",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_plugintypestatisticbase_modifiedonbehalfby</summary>
			public static readonly XrmFakedRelationship LkPlugintypestatisticbaseModifiedonbehalfby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "modifiedonbehalfby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "plugintypestatistic",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_position_createdby</summary>
			public static readonly XrmFakedRelationship LkPositionCreatedby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "createdby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "position",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_position_createdonbehalfby</summary>
			public static readonly XrmFakedRelationship LkPositionCreatedonbehalfby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "createdonbehalfby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "position",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_position_modifiedby</summary>
			public static readonly XrmFakedRelationship LkPositionModifiedby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "modifiedby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "position",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_position_modifiedonbehalfby</summary>
			public static readonly XrmFakedRelationship LkPositionModifiedonbehalfby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "modifiedonbehalfby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "position",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_post_createdby</summary>
			public static readonly XrmFakedRelationship LkPostCreatedby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "createdby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "post",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_post_createdonbehalfby</summary>
			public static readonly XrmFakedRelationship LkPostCreatedonbehalfby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "createdonbehalfby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "post",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_post_modifiedby</summary>
			public static readonly XrmFakedRelationship LkPostModifiedby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "modifiedby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "post",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_post_modifiedonbehalfby</summary>
			public static readonly XrmFakedRelationship LkPostModifiedonbehalfby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "modifiedonbehalfby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "post",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_postcomment_createdby</summary>
			public static readonly XrmFakedRelationship LkPostcommentCreatedby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "createdby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "postcomment",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_postcomment_createdonbehalfby</summary>
			public static readonly XrmFakedRelationship LkPostcommentCreatedonbehalfby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "createdonbehalfby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "postcomment",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_PostFollow_createdby</summary>
			public static readonly XrmFakedRelationship LkPostFollowCreatedby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "createdby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "postfollow",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_postfollow_createdonbehalfby</summary>
			public static readonly XrmFakedRelationship LkPostfollowCreatedonbehalfby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "createdonbehalfby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "postfollow",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_postlike_createdby</summary>
			public static readonly XrmFakedRelationship LkPostlikeCreatedby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "createdby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "postlike",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_postlike_createdonbehalfby</summary>
			public static readonly XrmFakedRelationship LkPostlikeCreatedonbehalfby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "createdonbehalfby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "postlike",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_pricelevel_createdonbehalfby</summary>
			public static readonly XrmFakedRelationship LkPricelevelCreatedonbehalfby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "createdonbehalfby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "pricelevel",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_pricelevel_modifiedonbehalfby</summary>
			public static readonly XrmFakedRelationship LkPricelevelModifiedonbehalfby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "modifiedonbehalfby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "pricelevel",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_pricelevelbase_createdby</summary>
			public static readonly XrmFakedRelationship LkPricelevelbaseCreatedby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "createdby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "pricelevel",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_pricelevelbase_modifiedby</summary>
			public static readonly XrmFakedRelationship LkPricelevelbaseModifiedby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "modifiedby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "pricelevel",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_processsession_canceledby</summary>
			public static readonly XrmFakedRelationship LkProcesssessionCanceledby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "canceledby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "processsession",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_processsession_completedby</summary>
			public static readonly XrmFakedRelationship LkProcesssessionCompletedby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "completedby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "processsession",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_processsession_createdby</summary>
			public static readonly XrmFakedRelationship LkProcesssessionCreatedby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "createdby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "processsession",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_processsession_executedby</summary>
			public static readonly XrmFakedRelationship LkProcesssessionExecutedby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "executedby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "processsession",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_processsession_modifiedby</summary>
			public static readonly XrmFakedRelationship LkProcesssessionModifiedby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "modifiedby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "processsession",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_processsession_startedby</summary>
			public static readonly XrmFakedRelationship LkProcesssessionStartedby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "startedby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "processsession",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_processsessionbase_createdonbehalfby</summary>
			public static readonly XrmFakedRelationship LkProcesssessionbaseCreatedonbehalfby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "createdonbehalfby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "processsession",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_processsessionbase_modifiedonbehalfby</summary>
			public static readonly XrmFakedRelationship LkProcesssessionbaseModifiedonbehalfby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "modifiedonbehalfby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "processsession",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_processstageparameter_createdby</summary>
			public static readonly XrmFakedRelationship LkProcessstageparameterCreatedby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "createdby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "processstageparameter",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_processstageparameter_createdonbehalfby</summary>
			public static readonly XrmFakedRelationship LkProcessstageparameterCreatedonbehalfby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "createdonbehalfby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "processstageparameter",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_processstageparameter_modifiedby</summary>
			public static readonly XrmFakedRelationship LkProcessstageparameterModifiedby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "modifiedby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "processstageparameter",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_processstageparameter_modifiedonbehalfby</summary>
			public static readonly XrmFakedRelationship LkProcessstageparameterModifiedonbehalfby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "modifiedonbehalfby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "processstageparameter",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_processtriggerbase_createdby</summary>
			public static readonly XrmFakedRelationship LkProcesstriggerbaseCreatedby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "createdby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "processtrigger",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_processtriggerbase_createdonbehalfby</summary>
			public static readonly XrmFakedRelationship LkProcesstriggerbaseCreatedonbehalfby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "createdonbehalfby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "processtrigger",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_processtriggerbase_modifiedby</summary>
			public static readonly XrmFakedRelationship LkProcesstriggerbaseModifiedby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "modifiedby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "processtrigger",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_processtriggerbase_modifiedonbehalfby</summary>
			public static readonly XrmFakedRelationship LkProcesstriggerbaseModifiedonbehalfby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "modifiedonbehalfby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "processtrigger",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_product_createdonbehalfby</summary>
			public static readonly XrmFakedRelationship LkProductCreatedonbehalfby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "createdonbehalfby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "product",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_product_modifiedonbehalfby</summary>
			public static readonly XrmFakedRelationship LkProductModifiedonbehalfby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "modifiedonbehalfby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "product",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_ProductAssociate_createdby</summary>
			public static readonly XrmFakedRelationship LkProductAssociateCreatedby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "createdby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "productassociation",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_ProductAssociation_createdonbehalfby</summary>
			public static readonly XrmFakedRelationship LkProductAssociationCreatedonbehalfby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "createdonbehalfby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "productassociation",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_ProductAssociation_modifiedby</summary>
			public static readonly XrmFakedRelationship LkProductAssociationModifiedby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "modifiedby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "productassociation",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_ProductAssociation_modifiedonbehalfby</summary>
			public static readonly XrmFakedRelationship LkProductAssociationModifiedonbehalfby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "modifiedonbehalfby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "productassociation",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_productbase_createdby</summary>
			public static readonly XrmFakedRelationship LkProductbaseCreatedby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "createdby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "product",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_productbase_modifiedby</summary>
			public static readonly XrmFakedRelationship LkProductbaseModifiedby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "modifiedby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "product",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_productpricelevel_createdonbehalfby</summary>
			public static readonly XrmFakedRelationship LkProductpricelevelCreatedonbehalfby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "createdonbehalfby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "productpricelevel",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_productpricelevel_modifiedonbehalfby</summary>
			public static readonly XrmFakedRelationship LkProductpricelevelModifiedonbehalfby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "modifiedonbehalfby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "productpricelevel",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_productpricelevelbase_createdby</summary>
			public static readonly XrmFakedRelationship LkProductpricelevelbaseCreatedby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "createdby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "productpricelevel",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_productpricelevelbase_modifiedby</summary>
			public static readonly XrmFakedRelationship LkProductpricelevelbaseModifiedby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "modifiedby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "productpricelevel",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_ProductSubstitute_createdby</summary>
			public static readonly XrmFakedRelationship LkProductSubstituteCreatedby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "createdby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "productsubstitute",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_ProductSubstitute_createdonbehalfby</summary>
			public static readonly XrmFakedRelationship LkProductSubstituteCreatedonbehalfby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "createdonbehalfby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "productsubstitute",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_ProductSubstitute_modifiedby</summary>
			public static readonly XrmFakedRelationship LkProductSubstituteModifiedby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "modifiedby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "productsubstitute",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_ProductSubstitute_modifiedonbehalfby</summary>
			public static readonly XrmFakedRelationship LkProductSubstituteModifiedonbehalfby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "modifiedonbehalfby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "productsubstitute",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_publisher_createdby</summary>
			public static readonly XrmFakedRelationship LkPublisherCreatedby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "createdby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "publisher",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_publisher_modifiedby</summary>
			public static readonly XrmFakedRelationship LkPublisherModifiedby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "modifiedby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "publisher",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_publisheraddressbase_createdby</summary>
			public static readonly XrmFakedRelationship LkPublisheraddressbaseCreatedby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "createdby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "publisheraddress",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_publisheraddressbase_createdonbehalfby</summary>
			public static readonly XrmFakedRelationship LkPublisheraddressbaseCreatedonbehalfby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "createdonbehalfby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "publisheraddress",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_publisheraddressbase_modifiedby</summary>
			public static readonly XrmFakedRelationship LkPublisheraddressbaseModifiedby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "modifiedby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "publisheraddress",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_publisheraddressbase_modifiedonbehalfby</summary>
			public static readonly XrmFakedRelationship LkPublisheraddressbaseModifiedonbehalfby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "modifiedonbehalfby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "publisheraddress",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_publisherbase_createdonbehalfby</summary>
			public static readonly XrmFakedRelationship LkPublisherbaseCreatedonbehalfby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "createdonbehalfby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "publisher",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_publisherbase_modifiedonbehalfby</summary>
			public static readonly XrmFakedRelationship LkPublisherbaseModifiedonbehalfby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "modifiedonbehalfby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "publisher",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_pw_penta_schedule_run_createdby</summary>
			public static readonly XrmFakedRelationship LkPwPentaScheduleRunCreatedby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "createdby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "pw_penta_schedule_run",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_pw_penta_schedule_run_createdonbehalfby</summary>
			public static readonly XrmFakedRelationship LkPwPentaScheduleRunCreatedonbehalfby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "createdonbehalfby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "pw_penta_schedule_run",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_pw_penta_schedule_run_modifiedby</summary>
			public static readonly XrmFakedRelationship LkPwPentaScheduleRunModifiedby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "modifiedby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "pw_penta_schedule_run",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_pw_penta_schedule_run_modifiedonbehalfby</summary>
			public static readonly XrmFakedRelationship LkPwPentaScheduleRunModifiedonbehalfby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "modifiedonbehalfby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "pw_penta_schedule_run",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_pw_schedule_createdby</summary>
			public static readonly XrmFakedRelationship LkPwScheduleCreatedby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "createdby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "pw_schedule",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_pw_schedule_createdonbehalfby</summary>
			public static readonly XrmFakedRelationship LkPwScheduleCreatedonbehalfby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "createdonbehalfby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "pw_schedule",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_pw_schedule_modifiedby</summary>
			public static readonly XrmFakedRelationship LkPwScheduleModifiedby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "modifiedby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "pw_schedule",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_pw_schedule_modifiedonbehalfby</summary>
			public static readonly XrmFakedRelationship LkPwScheduleModifiedonbehalfby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "modifiedonbehalfby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "pw_schedule",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_quarterlyfiscalcalendar_createdby</summary>
			public static readonly XrmFakedRelationship LkQuarterlyfiscalcalendarCreatedby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "createdby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "quarterlyfiscalcalendar",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_quarterlyfiscalcalendar_createdonbehalfby</summary>
			public static readonly XrmFakedRelationship LkQuarterlyfiscalcalendarCreatedonbehalfby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "createdonbehalfby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "quarterlyfiscalcalendar",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_quarterlyfiscalcalendar_modifiedby</summary>
			public static readonly XrmFakedRelationship LkQuarterlyfiscalcalendarModifiedby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "modifiedby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "quarterlyfiscalcalendar",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_quarterlyfiscalcalendar_modifiedonbehalfby</summary>
			public static readonly XrmFakedRelationship LkQuarterlyfiscalcalendarModifiedonbehalfby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "modifiedonbehalfby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "quarterlyfiscalcalendar",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_quarterlyfiscalcalendar_salespersonid</summary>
			public static readonly XrmFakedRelationship LkQuarterlyfiscalcalendarSalespersonid = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "salespersonid",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "quarterlyfiscalcalendar",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_queue_createdonbehalfby</summary>
			public static readonly XrmFakedRelationship LkQueueCreatedonbehalfby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "createdonbehalfby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "queue",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_queue_modifiedonbehalfby</summary>
			public static readonly XrmFakedRelationship LkQueueModifiedonbehalfby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "modifiedonbehalfby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "queue",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_queuebase_createdby</summary>
			public static readonly XrmFakedRelationship LkQueuebaseCreatedby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "createdby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "queue",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_queuebase_modifiedby</summary>
			public static readonly XrmFakedRelationship LkQueuebaseModifiedby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "modifiedby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "queue",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_queueitem_createdonbehalfby</summary>
			public static readonly XrmFakedRelationship LkQueueitemCreatedonbehalfby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "createdonbehalfby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "queueitem",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_queueitem_modifiedonbehalfby</summary>
			public static readonly XrmFakedRelationship LkQueueitemModifiedonbehalfby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "modifiedonbehalfby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "queueitem",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_queueitembase_createdby</summary>
			public static readonly XrmFakedRelationship LkQueueitembaseCreatedby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "createdby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "queueitem",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_queueitembase_modifiedby</summary>
			public static readonly XrmFakedRelationship LkQueueitembaseModifiedby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "modifiedby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "queueitem",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_queueitembase_workerid</summary>
			public static readonly XrmFakedRelationship LkQueueitembaseWorkerid = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "workerid",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "queueitem",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_quote_createdonbehalfby</summary>
			public static readonly XrmFakedRelationship LkQuoteCreatedonbehalfby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "createdonbehalfby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "quote",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_quote_modifiedonbehalfby</summary>
			public static readonly XrmFakedRelationship LkQuoteModifiedonbehalfby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "modifiedonbehalfby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "quote",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_quotebase_createdby</summary>
			public static readonly XrmFakedRelationship LkQuotebaseCreatedby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "createdby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "quote",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_quotebase_modifiedby</summary>
			public static readonly XrmFakedRelationship LkQuotebaseModifiedby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "modifiedby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "quote",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_quoteclose_createdby</summary>
			public static readonly XrmFakedRelationship LkQuotecloseCreatedby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "createdby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "quoteclose",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_quoteclose_createdonbehalfby</summary>
			public static readonly XrmFakedRelationship LkQuotecloseCreatedonbehalfby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "createdonbehalfby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "quoteclose",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_quoteclose_modifiedby</summary>
			public static readonly XrmFakedRelationship LkQuotecloseModifiedby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "modifiedby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "quoteclose",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_quoteclose_modifiedonbehalfby</summary>
			public static readonly XrmFakedRelationship LkQuotecloseModifiedonbehalfby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "modifiedonbehalfby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "quoteclose",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_quotedetail_createdonbehalfby</summary>
			public static readonly XrmFakedRelationship LkQuotedetailCreatedonbehalfby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "createdonbehalfby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "quotedetail",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_quotedetail_modifiedonbehalfby</summary>
			public static readonly XrmFakedRelationship LkQuotedetailModifiedonbehalfby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "modifiedonbehalfby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "quotedetail",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_quotedetailbase_createdby</summary>
			public static readonly XrmFakedRelationship LkQuotedetailbaseCreatedby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "createdby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "quotedetail",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_quotedetailbase_modifiedby</summary>
			public static readonly XrmFakedRelationship LkQuotedetailbaseModifiedby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "modifiedby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "quotedetail",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_ratingmodel_createdby</summary>
			public static readonly XrmFakedRelationship LkRatingmodelCreatedby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "createdby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "ratingmodel",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_ratingmodel_createdonbehalfby</summary>
			public static readonly XrmFakedRelationship LkRatingmodelCreatedonbehalfby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "createdonbehalfby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "ratingmodel",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_ratingmodel_modifiedby</summary>
			public static readonly XrmFakedRelationship LkRatingmodelModifiedby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "modifiedby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "ratingmodel",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_ratingmodel_modifiedonbehalfby</summary>
			public static readonly XrmFakedRelationship LkRatingmodelModifiedonbehalfby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "modifiedonbehalfby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "ratingmodel",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_ratingvalue_createdby</summary>
			public static readonly XrmFakedRelationship LkRatingvalueCreatedby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "createdby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "ratingvalue",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_ratingvalue_createdonbehalfby</summary>
			public static readonly XrmFakedRelationship LkRatingvalueCreatedonbehalfby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "createdonbehalfby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "ratingvalue",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_ratingvalue_modifiedby</summary>
			public static readonly XrmFakedRelationship LkRatingvalueModifiedby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "modifiedby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "ratingvalue",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_ratingvalue_modifiedonbehalfby</summary>
			public static readonly XrmFakedRelationship LkRatingvalueModifiedonbehalfby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "modifiedonbehalfby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "ratingvalue",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_recommendeddocument_createdby</summary>
			public static readonly XrmFakedRelationship LkRecommendeddocumentCreatedby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "createdby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "recommendeddocument",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_recommendeddocument_createdonbehalfby</summary>
			public static readonly XrmFakedRelationship LkRecommendeddocumentCreatedonbehalfby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "createdonbehalfby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "recommendeddocument",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_recommendeddocument_modifiedby</summary>
			public static readonly XrmFakedRelationship LkRecommendeddocumentModifiedby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "modifiedby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "recommendeddocument",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_recommendeddocument_modifiedonbehalfby</summary>
			public static readonly XrmFakedRelationship LkRecommendeddocumentModifiedonbehalfby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "modifiedonbehalfby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "recommendeddocument",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_recurrencerule_createdby</summary>
			public static readonly XrmFakedRelationship LkRecurrenceruleCreatedby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "createdby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "recurrencerule",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_recurrencerule_modifiedby</summary>
			public static readonly XrmFakedRelationship LkRecurrenceruleModifiedby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "modifiedby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "recurrencerule",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_recurrencerulebase_createdonbehalfby</summary>
			public static readonly XrmFakedRelationship LkRecurrencerulebaseCreatedonbehalfby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "createdonbehalfby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "recurrencerule",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_recurrencerulebase_modifiedonbehalfby</summary>
			public static readonly XrmFakedRelationship LkRecurrencerulebaseModifiedonbehalfby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "modifiedonbehalfby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "recurrencerule",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_recurringappointmentmaster_createdby</summary>
			public static readonly XrmFakedRelationship LkRecurringappointmentmasterCreatedby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "createdby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "recurringappointmentmaster",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_recurringappointmentmaster_createdonbehalfby</summary>
			public static readonly XrmFakedRelationship LkRecurringappointmentmasterCreatedonbehalfby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "createdonbehalfby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "recurringappointmentmaster",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_recurringappointmentmaster_modifiedby</summary>
			public static readonly XrmFakedRelationship LkRecurringappointmentmasterModifiedby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "modifiedby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "recurringappointmentmaster",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_recurringappointmentmaster_modifiedonbehalfby</summary>
			public static readonly XrmFakedRelationship LkRecurringappointmentmasterModifiedonbehalfby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "modifiedonbehalfby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "recurringappointmentmaster",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_report_createdonbehalfby</summary>
			public static readonly XrmFakedRelationship LkReportCreatedonbehalfby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "createdonbehalfby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "report",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_report_modifiedonbehalfby</summary>
			public static readonly XrmFakedRelationship LkReportModifiedonbehalfby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "modifiedonbehalfby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "report",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_reportbase_createdby</summary>
			public static readonly XrmFakedRelationship LkReportbaseCreatedby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "createdby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "report",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_reportbase_modifiedby</summary>
			public static readonly XrmFakedRelationship LkReportbaseModifiedby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "modifiedby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "report",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_reportcategory_createdonbehalfby</summary>
			public static readonly XrmFakedRelationship LkReportcategoryCreatedonbehalfby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "createdonbehalfby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "reportcategory",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_reportcategory_modifiedonbehalfby</summary>
			public static readonly XrmFakedRelationship LkReportcategoryModifiedonbehalfby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "modifiedonbehalfby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "reportcategory",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_reportcategorybase_createdby</summary>
			public static readonly XrmFakedRelationship LkReportcategorybaseCreatedby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "createdby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "reportcategory",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_reportcategorybase_modifiedby</summary>
			public static readonly XrmFakedRelationship LkReportcategorybaseModifiedby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "modifiedby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "reportcategory",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_resourcespec_createdby</summary>
			public static readonly XrmFakedRelationship LkResourcespecCreatedby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "createdby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "resourcespec",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_resourcespec_createdonbehalfby</summary>
			public static readonly XrmFakedRelationship LkResourcespecCreatedonbehalfby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "createdonbehalfby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "resourcespec",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_resourcespec_modifiedby</summary>
			public static readonly XrmFakedRelationship LkResourcespecModifiedby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "modifiedby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "resourcespec",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_resourcespec_modifiedonbehalfby</summary>
			public static readonly XrmFakedRelationship LkResourcespecModifiedonbehalfby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "modifiedonbehalfby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "resourcespec",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_role_createdonbehalfby</summary>
			public static readonly XrmFakedRelationship LkRoleCreatedonbehalfby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "createdonbehalfby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "role",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_role_modifiedonbehalfby</summary>
			public static readonly XrmFakedRelationship LkRoleModifiedonbehalfby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "modifiedonbehalfby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "role",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_rolebase_createdby</summary>
			public static readonly XrmFakedRelationship LkRolebaseCreatedby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "createdby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "role",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_rolebase_modifiedby</summary>
			public static readonly XrmFakedRelationship LkRolebaseModifiedby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "modifiedby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "role",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_rollupfield_createdby</summary>
			public static readonly XrmFakedRelationship LkRollupfieldCreatedby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "createdby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "rollupfield",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_rollupfield_createdonbehalfby</summary>
			public static readonly XrmFakedRelationship LkRollupfieldCreatedonbehalfby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "createdonbehalfby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "rollupfield",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_rollupfield_modifiedby</summary>
			public static readonly XrmFakedRelationship LkRollupfieldModifiedby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "modifiedby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "rollupfield",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_rollupfield_modifiedonbehalfby</summary>
			public static readonly XrmFakedRelationship LkRollupfieldModifiedonbehalfby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "modifiedonbehalfby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "rollupfield",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_salesliterature_createdonbehalfby</summary>
			public static readonly XrmFakedRelationship LkSalesliteratureCreatedonbehalfby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "createdonbehalfby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "salesliterature",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_salesliterature_modifiedonbehalfby</summary>
			public static readonly XrmFakedRelationship LkSalesliteratureModifiedonbehalfby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "modifiedonbehalfby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "salesliterature",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_salesliteraturebase_createdby</summary>
			public static readonly XrmFakedRelationship LkSalesliteraturebaseCreatedby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "createdby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "salesliterature",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_salesliteraturebase_modifiedby</summary>
			public static readonly XrmFakedRelationship LkSalesliteraturebaseModifiedby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "modifiedby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "salesliterature",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_salesliteratureitem_createdonbehalfby</summary>
			public static readonly XrmFakedRelationship LkSalesliteratureitemCreatedonbehalfby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "createdonbehalfby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "salesliteratureitem",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_salesliteratureitem_modifiedonbehalfby</summary>
			public static readonly XrmFakedRelationship LkSalesliteratureitemModifiedonbehalfby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "modifiedonbehalfby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "salesliteratureitem",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_salesliteratureitembase_createdby</summary>
			public static readonly XrmFakedRelationship LkSalesliteratureitembaseCreatedby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "createdby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "salesliteratureitem",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_salesliteratureitembase_modifiedby</summary>
			public static readonly XrmFakedRelationship LkSalesliteratureitembaseModifiedby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "modifiedby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "salesliteratureitem",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_salesorder_createdonbehalfby</summary>
			public static readonly XrmFakedRelationship LkSalesorderCreatedonbehalfby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "createdonbehalfby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "salesorder",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_salesorder_modifiedonbehalfby</summary>
			public static readonly XrmFakedRelationship LkSalesorderModifiedonbehalfby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "modifiedonbehalfby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "salesorder",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_salesorderbase_createdby</summary>
			public static readonly XrmFakedRelationship LkSalesorderbaseCreatedby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "createdby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "salesorder",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_salesorderbase_modifiedby</summary>
			public static readonly XrmFakedRelationship LkSalesorderbaseModifiedby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "modifiedby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "salesorder",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_salesorderdetail_createdonbehalfby</summary>
			public static readonly XrmFakedRelationship LkSalesorderdetailCreatedonbehalfby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "createdonbehalfby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "salesorderdetail",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_salesorderdetail_modifiedonbehalfby</summary>
			public static readonly XrmFakedRelationship LkSalesorderdetailModifiedonbehalfby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "modifiedonbehalfby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "salesorderdetail",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_salesorderdetailbase_createdby</summary>
			public static readonly XrmFakedRelationship LkSalesorderdetailbaseCreatedby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "createdby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "salesorderdetail",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_salesorderdetailbase_modifiedby</summary>
			public static readonly XrmFakedRelationship LkSalesorderdetailbaseModifiedby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "modifiedby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "salesorderdetail",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_savedquery_createdonbehalfby</summary>
			public static readonly XrmFakedRelationship LkSavedqueryCreatedonbehalfby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "createdonbehalfby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "savedquery",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_savedquery_modifiedonbehalfby</summary>
			public static readonly XrmFakedRelationship LkSavedqueryModifiedonbehalfby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "modifiedonbehalfby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "savedquery",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_savedquerybase_createdby</summary>
			public static readonly XrmFakedRelationship LkSavedquerybaseCreatedby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "createdby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "savedquery",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_savedquerybase_modifiedby</summary>
			public static readonly XrmFakedRelationship LkSavedquerybaseModifiedby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "modifiedby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "savedquery",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_savedqueryvisualizationbase_createdby</summary>
			public static readonly XrmFakedRelationship LkSavedqueryvisualizationbaseCreatedby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "createdby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "savedqueryvisualization",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_savedqueryvisualizationbase_createdonbehalfby</summary>
			public static readonly XrmFakedRelationship LkSavedqueryvisualizationbaseCreatedonbehalfby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "createdonbehalfby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "savedqueryvisualization",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_savedqueryvisualizationbase_modifiedby</summary>
			public static readonly XrmFakedRelationship LkSavedqueryvisualizationbaseModifiedby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "modifiedby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "savedqueryvisualization",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_savedqueryvisualizationbase_modifiedonbehalfby</summary>
			public static readonly XrmFakedRelationship LkSavedqueryvisualizationbaseModifiedonbehalfby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "modifiedonbehalfby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "savedqueryvisualization",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_sdkmessage_createdonbehalfby</summary>
			public static readonly XrmFakedRelationship LkSdkmessageCreatedonbehalfby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "createdonbehalfby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "sdkmessage",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_sdkmessage_modifiedonbehalfby</summary>
			public static readonly XrmFakedRelationship LkSdkmessageModifiedonbehalfby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "modifiedonbehalfby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "sdkmessage",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_sdkmessagefilter_createdonbehalfby</summary>
			public static readonly XrmFakedRelationship LkSdkmessagefilterCreatedonbehalfby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "createdonbehalfby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "sdkmessagefilter",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_sdkmessagefilter_modifiedonbehalfby</summary>
			public static readonly XrmFakedRelationship LkSdkmessagefilterModifiedonbehalfby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "modifiedonbehalfby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "sdkmessagefilter",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_sdkmessageprocessingstep_createdonbehalfby</summary>
			public static readonly XrmFakedRelationship LkSdkmessageprocessingstepCreatedonbehalfby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "createdonbehalfby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "sdkmessageprocessingstep",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_sdkmessageprocessingstep_modifiedonbehalfby</summary>
			public static readonly XrmFakedRelationship LkSdkmessageprocessingstepModifiedonbehalfby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "modifiedonbehalfby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "sdkmessageprocessingstep",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_sdkmessageprocessingstepimage_createdonbehalfby</summary>
			public static readonly XrmFakedRelationship LkSdkmessageprocessingstepimageCreatedonbehalfby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "createdonbehalfby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "sdkmessageprocessingstepimage",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_sdkmessageprocessingstepimage_modifiedonbehalfby</summary>
			public static readonly XrmFakedRelationship LkSdkmessageprocessingstepimageModifiedonbehalfby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "modifiedonbehalfby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "sdkmessageprocessingstepimage",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_sdkmessageprocessingstepsecureconfig_createdonbehalfby</summary>
			public static readonly XrmFakedRelationship LkSdkmessageprocessingstepsecureconfigCreatedonbehalfby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "createdonbehalfby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "sdkmessageprocessingstepsecureconfig",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_sdkmessageprocessingstepsecureconfig_modifiedonbehalfby</summary>
			public static readonly XrmFakedRelationship LkSdkmessageprocessingstepsecureconfigModifiedonbehalfby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "modifiedonbehalfby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "sdkmessageprocessingstepsecureconfig",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_semiannualfiscalcalendar_createdby</summary>
			public static readonly XrmFakedRelationship LkSemiannualfiscalcalendarCreatedby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "createdby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "semiannualfiscalcalendar",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_semiannualfiscalcalendar_createdonbehalfby</summary>
			public static readonly XrmFakedRelationship LkSemiannualfiscalcalendarCreatedonbehalfby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "createdonbehalfby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "semiannualfiscalcalendar",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_semiannualfiscalcalendar_modifiedby</summary>
			public static readonly XrmFakedRelationship LkSemiannualfiscalcalendarModifiedby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "modifiedby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "semiannualfiscalcalendar",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_semiannualfiscalcalendar_modifiedonbehalfby</summary>
			public static readonly XrmFakedRelationship LkSemiannualfiscalcalendarModifiedonbehalfby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "modifiedonbehalfby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "semiannualfiscalcalendar",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_semiannualfiscalcalendar_salespersonid</summary>
			public static readonly XrmFakedRelationship LkSemiannualfiscalcalendarSalespersonid = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "salespersonid",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "semiannualfiscalcalendar",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_service_createdby</summary>
			public static readonly XrmFakedRelationship LkServiceCreatedby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "createdby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "service",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_service_createdonbehalfby</summary>
			public static readonly XrmFakedRelationship LkServiceCreatedonbehalfby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "createdonbehalfby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "service",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_service_modifiedby</summary>
			public static readonly XrmFakedRelationship LkServiceModifiedby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "modifiedby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "service",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_service_modifiedonbehalfby</summary>
			public static readonly XrmFakedRelationship LkServiceModifiedonbehalfby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "modifiedonbehalfby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "service",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_serviceappointment_createdby</summary>
			public static readonly XrmFakedRelationship LkServiceappointmentCreatedby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "createdby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "serviceappointment",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_serviceappointment_createdonbehalfby</summary>
			public static readonly XrmFakedRelationship LkServiceappointmentCreatedonbehalfby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "createdonbehalfby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "serviceappointment",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_serviceappointment_modifiedby</summary>
			public static readonly XrmFakedRelationship LkServiceappointmentModifiedby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "modifiedby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "serviceappointment",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_serviceappointment_modifiedonbehalfby</summary>
			public static readonly XrmFakedRelationship LkServiceappointmentModifiedonbehalfby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "modifiedonbehalfby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "serviceappointment",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_serviceendpointbase_createdonbehalfby</summary>
			public static readonly XrmFakedRelationship LkServiceendpointbaseCreatedonbehalfby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "createdonbehalfby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "serviceendpoint",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_serviceendpointbase_modifiedonbehalfby</summary>
			public static readonly XrmFakedRelationship LkServiceendpointbaseModifiedonbehalfby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "modifiedonbehalfby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "serviceendpoint",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_serviceplan_createdby</summary>
			public static readonly XrmFakedRelationship LkServiceplanCreatedby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "createdby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "serviceplan",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_serviceplan_createdonbehalfby</summary>
			public static readonly XrmFakedRelationship LkServiceplanCreatedonbehalfby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "createdonbehalfby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "serviceplan",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_serviceplan_modifiedby</summary>
			public static readonly XrmFakedRelationship LkServiceplanModifiedby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "modifiedby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "serviceplan",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_serviceplan_modifiedonbehalfby</summary>
			public static readonly XrmFakedRelationship LkServiceplanModifiedonbehalfby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "modifiedonbehalfby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "serviceplan",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_sharepointdocumentlocationbase_createdby</summary>
			public static readonly XrmFakedRelationship LkSharepointdocumentlocationbaseCreatedby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "createdby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "sharepointdocumentlocation",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_sharepointdocumentlocationbase_createdonbehalfby</summary>
			public static readonly XrmFakedRelationship LkSharepointdocumentlocationbaseCreatedonbehalfby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "createdonbehalfby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "sharepointdocumentlocation",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_sharepointdocumentlocationbase_modifiedby</summary>
			public static readonly XrmFakedRelationship LkSharepointdocumentlocationbaseModifiedby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "modifiedby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "sharepointdocumentlocation",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_sharepointdocumentlocationbase_modifiedonbehalfby</summary>
			public static readonly XrmFakedRelationship LkSharepointdocumentlocationbaseModifiedonbehalfby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "modifiedonbehalfby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "sharepointdocumentlocation",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_sharepointsitebase_createdby</summary>
			public static readonly XrmFakedRelationship LkSharepointsitebaseCreatedby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "createdby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "sharepointsite",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_sharepointsitebase_createdonbehalfby</summary>
			public static readonly XrmFakedRelationship LkSharepointsitebaseCreatedonbehalfby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "createdonbehalfby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "sharepointsite",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_sharepointsitebase_modifiedby</summary>
			public static readonly XrmFakedRelationship LkSharepointsitebaseModifiedby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "modifiedby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "sharepointsite",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_sharepointsitebase_modifiedonbehalfby</summary>
			public static readonly XrmFakedRelationship LkSharepointsitebaseModifiedonbehalfby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "modifiedonbehalfby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "sharepointsite",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_site_createdonbehalfby</summary>
			public static readonly XrmFakedRelationship LkSiteCreatedonbehalfby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "createdonbehalfby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "site",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_site_modifiedonbehalfby</summary>
			public static readonly XrmFakedRelationship LkSiteModifiedonbehalfby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "modifiedonbehalfby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "site",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_sitebase_createdby</summary>
			public static readonly XrmFakedRelationship LkSitebaseCreatedby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "createdby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "site",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_sitebase_modifiedby</summary>
			public static readonly XrmFakedRelationship LkSitebaseModifiedby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "modifiedby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "site",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_SiteMap_createdby</summary>
			public static readonly XrmFakedRelationship LkSiteMapCreatedby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "createdby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "sitemap",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_SiteMap_createdonbehalfby</summary>
			public static readonly XrmFakedRelationship LkSiteMapCreatedonbehalfby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "createdonbehalfby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "sitemap",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_SiteMap_modifiedby</summary>
			public static readonly XrmFakedRelationship LkSiteMapModifiedby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "modifiedby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "sitemap",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_SiteMap_modifiedonbehalfby</summary>
			public static readonly XrmFakedRelationship LkSiteMapModifiedonbehalfby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "modifiedonbehalfby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "sitemap",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_slabase_createdby</summary>
			public static readonly XrmFakedRelationship LkSlabaseCreatedby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "createdby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "sla",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_slabase_createdonbehalfby</summary>
			public static readonly XrmFakedRelationship LkSlabaseCreatedonbehalfby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "createdonbehalfby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "sla",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_slabase_modifiedby</summary>
			public static readonly XrmFakedRelationship LkSlabaseModifiedby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "modifiedby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "sla",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_slabase_modifiedonbehalfby</summary>
			public static readonly XrmFakedRelationship LkSlabaseModifiedonbehalfby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "modifiedonbehalfby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "sla",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_slaitembase_createdby</summary>
			public static readonly XrmFakedRelationship LkSlaitembaseCreatedby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "createdby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "slaitem",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_slaitembase_createdonbehalfby</summary>
			public static readonly XrmFakedRelationship LkSlaitembaseCreatedonbehalfby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "createdonbehalfby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "slaitem",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_slaitembase_modifiedby</summary>
			public static readonly XrmFakedRelationship LkSlaitembaseModifiedby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "modifiedby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "slaitem",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_slaitembase_modifiedonbehalfby</summary>
			public static readonly XrmFakedRelationship LkSlaitembaseModifiedonbehalfby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "modifiedonbehalfby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "slaitem",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_slakpiinstancebase_createdby</summary>
			public static readonly XrmFakedRelationship LkSlakpiinstancebaseCreatedby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "createdby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "slakpiinstance",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_slakpiinstancebase_createdonbehalfby</summary>
			public static readonly XrmFakedRelationship LkSlakpiinstancebaseCreatedonbehalfby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "createdonbehalfby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "slakpiinstance",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_slakpiinstancebase_modifiedby</summary>
			public static readonly XrmFakedRelationship LkSlakpiinstancebaseModifiedby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "modifiedby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "slakpiinstance",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_slakpiinstancebase_modifiedonbehalfby</summary>
			public static readonly XrmFakedRelationship LkSlakpiinstancebaseModifiedonbehalfby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "modifiedonbehalfby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "slakpiinstance",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_socialactivity_createdby</summary>
			public static readonly XrmFakedRelationship LkSocialactivityCreatedby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "createdby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "socialactivity",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_socialactivity_modifiedby</summary>
			public static readonly XrmFakedRelationship LkSocialactivityModifiedby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "modifiedby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "socialactivity",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_socialactivitybase_createdonbehalfby</summary>
			public static readonly XrmFakedRelationship LkSocialactivitybaseCreatedonbehalfby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "createdonbehalfby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "socialactivity",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_socialactivitybase_modifiedonbehalfby</summary>
			public static readonly XrmFakedRelationship LkSocialactivitybaseModifiedonbehalfby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "modifiedonbehalfby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "socialactivity",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_SocialProfile_createdonbehalfby</summary>
			public static readonly XrmFakedRelationship LkSocialProfileCreatedonbehalfby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "createdonbehalfby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "socialprofile",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_SocialProfile_modifiedonbehalfby</summary>
			public static readonly XrmFakedRelationship LkSocialProfileModifiedonbehalfby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "modifiedonbehalfby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "socialprofile",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_solution_createdby</summary>
			public static readonly XrmFakedRelationship LkSolutionCreatedby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "createdby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "solution",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_solution_modifiedby</summary>
			public static readonly XrmFakedRelationship LkSolutionModifiedby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "modifiedby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "solution",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_solutionbase_createdonbehalfby</summary>
			public static readonly XrmFakedRelationship LkSolutionbaseCreatedonbehalfby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "createdonbehalfby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "solution",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_solutionbase_modifiedonbehalfby</summary>
			public static readonly XrmFakedRelationship LkSolutionbaseModifiedonbehalfby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "modifiedonbehalfby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "solution",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_solutioncomponentattributeconfiguration_createdby</summary>
			public static readonly XrmFakedRelationship LkSolutioncomponentattributeconfigurationCreatedby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "createdby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "solutioncomponentattributeconfiguration",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_solutioncomponentattributeconfiguration_createdonbehalfby</summary>
			public static readonly XrmFakedRelationship LkSolutioncomponentattributeconfigurationCreatedonbehalfby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "createdonbehalfby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "solutioncomponentattributeconfiguration",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_solutioncomponentattributeconfiguration_modifiedby</summary>
			public static readonly XrmFakedRelationship LkSolutioncomponentattributeconfigurationModifiedby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "modifiedby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "solutioncomponentattributeconfiguration",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_solutioncomponentattributeconfiguration_modifiedonbehalfby</summary>
			public static readonly XrmFakedRelationship LkSolutioncomponentattributeconfigurationModifiedonbehalfby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "modifiedonbehalfby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "solutioncomponentattributeconfiguration",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_solutioncomponentbase_createdonbehalfby</summary>
			public static readonly XrmFakedRelationship LkSolutioncomponentbaseCreatedonbehalfby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "createdonbehalfby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "solutioncomponent",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_solutioncomponentbase_modifiedonbehalfby</summary>
			public static readonly XrmFakedRelationship LkSolutioncomponentbaseModifiedonbehalfby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "modifiedonbehalfby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "solutioncomponent",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_solutioncomponentconfiguration_createdby</summary>
			public static readonly XrmFakedRelationship LkSolutioncomponentconfigurationCreatedby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "createdby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "solutioncomponentconfiguration",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_solutioncomponentconfiguration_createdonbehalfby</summary>
			public static readonly XrmFakedRelationship LkSolutioncomponentconfigurationCreatedonbehalfby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "createdonbehalfby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "solutioncomponentconfiguration",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_solutioncomponentconfiguration_modifiedby</summary>
			public static readonly XrmFakedRelationship LkSolutioncomponentconfigurationModifiedby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "modifiedby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "solutioncomponentconfiguration",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_solutioncomponentconfiguration_modifiedonbehalfby</summary>
			public static readonly XrmFakedRelationship LkSolutioncomponentconfigurationModifiedonbehalfby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "modifiedonbehalfby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "solutioncomponentconfiguration",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_solutioncomponentrelationshipconfiguration_createdby</summary>
			public static readonly XrmFakedRelationship LkSolutioncomponentrelationshipconfigurationCreatedby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "createdby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "solutioncomponentrelationshipconfiguration",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_solutioncomponentrelationshipconfiguration_createdonbehalfby</summary>
			public static readonly XrmFakedRelationship LkSolutioncomponentrelationshipconfigurationCreatedonbehalfby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "createdonbehalfby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "solutioncomponentrelationshipconfiguration",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_solutioncomponentrelationshipconfiguration_modifiedby</summary>
			public static readonly XrmFakedRelationship LkSolutioncomponentrelationshipconfigurationModifiedby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "modifiedby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "solutioncomponentrelationshipconfiguration",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_solutioncomponentrelationshipconfiguration_modifiedonbehalfby</summary>
			public static readonly XrmFakedRelationship LkSolutioncomponentrelationshipconfigurationModifiedonbehalfby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "modifiedonbehalfby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "solutioncomponentrelationshipconfiguration",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_stagesolutionupload_createdby</summary>
			public static readonly XrmFakedRelationship LkStagesolutionuploadCreatedby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "createdby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "stagesolutionupload",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_stagesolutionupload_createdonbehalfby</summary>
			public static readonly XrmFakedRelationship LkStagesolutionuploadCreatedonbehalfby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "createdonbehalfby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "stagesolutionupload",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_stagesolutionupload_modifiedby</summary>
			public static readonly XrmFakedRelationship LkStagesolutionuploadModifiedby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "modifiedby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "stagesolutionupload",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_stagesolutionupload_modifiedonbehalfby</summary>
			public static readonly XrmFakedRelationship LkStagesolutionuploadModifiedonbehalfby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "modifiedonbehalfby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "stagesolutionupload",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_subject_createdonbehalfby</summary>
			public static readonly XrmFakedRelationship LkSubjectCreatedonbehalfby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "createdonbehalfby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "subject",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_subject_modifiedonbehalfby</summary>
			public static readonly XrmFakedRelationship LkSubjectModifiedonbehalfby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "modifiedonbehalfby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "subject",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_subjectbase_createdby</summary>
			public static readonly XrmFakedRelationship LkSubjectbaseCreatedby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "createdby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "subject",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_subjectbase_modifiedby</summary>
			public static readonly XrmFakedRelationship LkSubjectbaseModifiedby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "modifiedby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "subject",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_syncerrorbase_createdby</summary>
			public static readonly XrmFakedRelationship LkSyncerrorbaseCreatedby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "createdby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "syncerror",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_syncerrorbase_createdonbehalfby</summary>
			public static readonly XrmFakedRelationship LkSyncerrorbaseCreatedonbehalfby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "createdonbehalfby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "syncerror",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_syncerrorbase_modifiedby</summary>
			public static readonly XrmFakedRelationship LkSyncerrorbaseModifiedby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "modifiedby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "syncerror",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_syncerrorbase_modifiedonbehalfby</summary>
			public static readonly XrmFakedRelationship LkSyncerrorbaseModifiedonbehalfby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "modifiedonbehalfby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "syncerror",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_systemuser_createdonbehalfby</summary>
			public static readonly XrmFakedRelationship LkSystemuserCreatedonbehalfby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "createdonbehalfby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "systemuser",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_systemuser_modifiedonbehalfby</summary>
			public static readonly XrmFakedRelationship LkSystemuserModifiedonbehalfby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "modifiedonbehalfby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "systemuser",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_systemuserbase_createdby</summary>
			public static readonly XrmFakedRelationship LkSystemuserbaseCreatedby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "createdby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "systemuser",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_systemuserbase_modifiedby</summary>
			public static readonly XrmFakedRelationship LkSystemuserbaseModifiedby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "modifiedby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "systemuser",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_task_createdby</summary>
			public static readonly XrmFakedRelationship LkTaskCreatedby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "createdby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "task",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_task_createdonbehalfby</summary>
			public static readonly XrmFakedRelationship LkTaskCreatedonbehalfby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "createdonbehalfby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "task",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_task_modifiedby</summary>
			public static readonly XrmFakedRelationship LkTaskModifiedby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "modifiedby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "task",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_task_modifiedonbehalfby</summary>
			public static readonly XrmFakedRelationship LkTaskModifiedonbehalfby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "modifiedonbehalfby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "task",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_team_createdonbehalfby</summary>
			public static readonly XrmFakedRelationship LkTeamCreatedonbehalfby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "createdonbehalfby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "team",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_team_modifiedonbehalfby</summary>
			public static readonly XrmFakedRelationship LkTeamModifiedonbehalfby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "modifiedonbehalfby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "team",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_teambase_administratorid</summary>
			public static readonly XrmFakedRelationship LkTeambaseAdministratorid = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "administratorid",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "team",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_teambase_createdby</summary>
			public static readonly XrmFakedRelationship LkTeambaseCreatedby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "createdby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "team",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_teambase_modifiedby</summary>
			public static readonly XrmFakedRelationship LkTeambaseModifiedby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "modifiedby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "team",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_teamtemplate_createdby</summary>
			public static readonly XrmFakedRelationship LkTeamtemplateCreatedby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "createdby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "teamtemplate",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_teamtemplate_createdonbehalfby</summary>
			public static readonly XrmFakedRelationship LkTeamtemplateCreatedonbehalfby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "createdonbehalfby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "teamtemplate",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_teamtemplate_modifiedby</summary>
			public static readonly XrmFakedRelationship LkTeamtemplateModifiedby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "modifiedby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "teamtemplate",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_teamtemplate_modifiedonbehalfby</summary>
			public static readonly XrmFakedRelationship LkTeamtemplateModifiedonbehalfby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "modifiedonbehalfby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "teamtemplate",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_templatebase_createdby</summary>
			public static readonly XrmFakedRelationship LkTemplatebaseCreatedby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "createdby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "template",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_templatebase_createdonbehalfby</summary>
			public static readonly XrmFakedRelationship LkTemplatebaseCreatedonbehalfby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "createdonbehalfby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "template",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_templatebase_modifiedby</summary>
			public static readonly XrmFakedRelationship LkTemplatebaseModifiedby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "modifiedby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "template",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_templatebase_modifiedonbehalfby</summary>
			public static readonly XrmFakedRelationship LkTemplatebaseModifiedonbehalfby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "modifiedonbehalfby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "template",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_territory_createdonbehalfby</summary>
			public static readonly XrmFakedRelationship LkTerritoryCreatedonbehalfby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "createdonbehalfby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "territory",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_territory_modifiedonbehalfby</summary>
			public static readonly XrmFakedRelationship LkTerritoryModifiedonbehalfby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "modifiedonbehalfby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "territory",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_territorybase_createdby</summary>
			public static readonly XrmFakedRelationship LkTerritorybaseCreatedby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "createdby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "territory",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_territorybase_modifiedby</summary>
			public static readonly XrmFakedRelationship LkTerritorybaseModifiedby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "modifiedby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "territory",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_theme_createdby</summary>
			public static readonly XrmFakedRelationship LkThemeCreatedby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "createdby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "theme",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_theme_createdonbehalfby</summary>
			public static readonly XrmFakedRelationship LkThemeCreatedonbehalfby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "createdonbehalfby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "theme",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_theme_modifiedby</summary>
			public static readonly XrmFakedRelationship LkThemeModifiedby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "modifiedby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "theme",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_theme_modifiedonbehalfby</summary>
			public static readonly XrmFakedRelationship LkThemeModifiedonbehalfby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "modifiedonbehalfby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "theme",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_timezonedefinition_createdby</summary>
			public static readonly XrmFakedRelationship LkTimezonedefinitionCreatedby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "createdby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "timezonedefinition",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_timezonedefinition_createdonbehalfby</summary>
			public static readonly XrmFakedRelationship LkTimezonedefinitionCreatedonbehalfby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "createdonbehalfby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "timezonedefinition",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_timezonedefinition_modifiedby</summary>
			public static readonly XrmFakedRelationship LkTimezonedefinitionModifiedby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "modifiedby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "timezonedefinition",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_timezonedefinition_modifiedonbehalfby</summary>
			public static readonly XrmFakedRelationship LkTimezonedefinitionModifiedonbehalfby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "modifiedonbehalfby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "timezonedefinition",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_timezonelocalizedname_createdby</summary>
			public static readonly XrmFakedRelationship LkTimezonelocalizednameCreatedby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "createdby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "timezonelocalizedname",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_timezonelocalizedname_createdonbehalfby</summary>
			public static readonly XrmFakedRelationship LkTimezonelocalizednameCreatedonbehalfby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "createdonbehalfby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "timezonelocalizedname",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_timezonelocalizedname_modifiedby</summary>
			public static readonly XrmFakedRelationship LkTimezonelocalizednameModifiedby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "modifiedby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "timezonelocalizedname",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_timezonelocalizedname_modifiedonbehalfby</summary>
			public static readonly XrmFakedRelationship LkTimezonelocalizednameModifiedonbehalfby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "modifiedonbehalfby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "timezonelocalizedname",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_timezonerule_createdby</summary>
			public static readonly XrmFakedRelationship LkTimezoneruleCreatedby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "createdby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "timezonerule",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_timezonerule_createdonbehalfby</summary>
			public static readonly XrmFakedRelationship LkTimezoneruleCreatedonbehalfby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "createdonbehalfby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "timezonerule",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_timezonerule_modifiedby</summary>
			public static readonly XrmFakedRelationship LkTimezoneruleModifiedby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "modifiedby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "timezonerule",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_timezonerule_modifiedonbehalfby</summary>
			public static readonly XrmFakedRelationship LkTimezoneruleModifiedonbehalfby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "modifiedonbehalfby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "timezonerule",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_tracelog_createdby</summary>
			public static readonly XrmFakedRelationship LkTracelogCreatedby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "createdby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "tracelog",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_tracelog_createdonbehalfby</summary>
			public static readonly XrmFakedRelationship LkTracelogCreatedonbehalfby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "createdonbehalfby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "tracelog",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_tracelog_modifiedby</summary>
			public static readonly XrmFakedRelationship LkTracelogModifiedby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "modifiedby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "tracelog",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_tracelog_modifiedonbehalfby</summary>
			public static readonly XrmFakedRelationship LkTracelogModifiedonbehalfby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "modifiedonbehalfby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "tracelog",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_transactioncurrency_createdonbehalfby</summary>
			public static readonly XrmFakedRelationship LkTransactioncurrencyCreatedonbehalfby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "createdonbehalfby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "transactioncurrency",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_transactioncurrency_modifiedonbehalfby</summary>
			public static readonly XrmFakedRelationship LkTransactioncurrencyModifiedonbehalfby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "modifiedonbehalfby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "transactioncurrency",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_transactioncurrencybase_createdby</summary>
			public static readonly XrmFakedRelationship LkTransactioncurrencybaseCreatedby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "createdby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "transactioncurrency",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_transactioncurrencybase_modifiedby</summary>
			public static readonly XrmFakedRelationship LkTransactioncurrencybaseModifiedby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "modifiedby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "transactioncurrency",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_transformationmapping_createdby</summary>
			public static readonly XrmFakedRelationship LkTransformationmappingCreatedby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "createdby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "transformationmapping",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_transformationmapping_createdonbehalfby</summary>
			public static readonly XrmFakedRelationship LkTransformationmappingCreatedonbehalfby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "createdonbehalfby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "transformationmapping",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_transformationmapping_modifiedby</summary>
			public static readonly XrmFakedRelationship LkTransformationmappingModifiedby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "modifiedby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "transformationmapping",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_transformationmapping_modifiedonbehalfby</summary>
			public static readonly XrmFakedRelationship LkTransformationmappingModifiedonbehalfby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "modifiedonbehalfby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "transformationmapping",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_transformationparametermapping_createdby</summary>
			public static readonly XrmFakedRelationship LkTransformationparametermappingCreatedby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "createdby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "transformationparametermapping",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_transformationparametermapping_createdonbehalfby</summary>
			public static readonly XrmFakedRelationship LkTransformationparametermappingCreatedonbehalfby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "createdonbehalfby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "transformationparametermapping",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_transformationparametermapping_modifiedby</summary>
			public static readonly XrmFakedRelationship LkTransformationparametermappingModifiedby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "modifiedby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "transformationparametermapping",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_transformationparametermapping_modifiedonbehalfby</summary>
			public static readonly XrmFakedRelationship LkTransformationparametermappingModifiedonbehalfby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "modifiedonbehalfby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "transformationparametermapping",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_translationprocess_createdby</summary>
			public static readonly XrmFakedRelationship LkTranslationprocessCreatedby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "createdby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "translationprocess",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_translationprocess_createdonbehalfby</summary>
			public static readonly XrmFakedRelationship LkTranslationprocessCreatedonbehalfby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "createdonbehalfby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "translationprocess",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_translationprocess_modifiedby</summary>
			public static readonly XrmFakedRelationship LkTranslationprocessModifiedby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "modifiedby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "translationprocess",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_translationprocess_modifiedonbehalfby</summary>
			public static readonly XrmFakedRelationship LkTranslationprocessModifiedonbehalfby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "modifiedonbehalfby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "translationprocess",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_uom_createdonbehalfby</summary>
			public static readonly XrmFakedRelationship LkUomCreatedonbehalfby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "createdonbehalfby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "uom",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_uom_modifiedonbehalfby</summary>
			public static readonly XrmFakedRelationship LkUomModifiedonbehalfby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "modifiedonbehalfby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "uom",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_uombase_createdby</summary>
			public static readonly XrmFakedRelationship LkUombaseCreatedby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "createdby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "uom",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_uombase_modifiedby</summary>
			public static readonly XrmFakedRelationship LkUombaseModifiedby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "modifiedby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "uom",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_uomschedule_createdonbehalfby</summary>
			public static readonly XrmFakedRelationship LkUomscheduleCreatedonbehalfby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "createdonbehalfby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "uomschedule",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_uomschedule_modifiedonbehalfby</summary>
			public static readonly XrmFakedRelationship LkUomscheduleModifiedonbehalfby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "modifiedonbehalfby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "uomschedule",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_uomschedulebase_createdby</summary>
			public static readonly XrmFakedRelationship LkUomschedulebaseCreatedby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "createdby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "uomschedule",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_uomschedulebase_modifiedby</summary>
			public static readonly XrmFakedRelationship LkUomschedulebaseModifiedby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "modifiedby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "uomschedule",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_userform_createdby</summary>
			public static readonly XrmFakedRelationship LkUserformCreatedby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "createdby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "userform",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_userform_modifiedby</summary>
			public static readonly XrmFakedRelationship LkUserformModifiedby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "modifiedby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "userform",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_userformbase_createdonbehalfby</summary>
			public static readonly XrmFakedRelationship LkUserformbaseCreatedonbehalfby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "createdonbehalfby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "userform",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_userformbase_modifiedonbehalfby</summary>
			public static readonly XrmFakedRelationship LkUserformbaseModifiedonbehalfby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "modifiedonbehalfby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "userform",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_usermapping_createdby</summary>
			public static readonly XrmFakedRelationship LkUsermappingCreatedby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "createdby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "usermapping",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_usermapping_createdonbehalfby</summary>
			public static readonly XrmFakedRelationship LkUsermappingCreatedonbehalfby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "createdonbehalfby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "usermapping",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_usermapping_modifiedby</summary>
			public static readonly XrmFakedRelationship LkUsermappingModifiedby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "modifiedby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "usermapping",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_usermapping_modifiedonbehalfby</summary>
			public static readonly XrmFakedRelationship LkUsermappingModifiedonbehalfby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "modifiedonbehalfby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "usermapping",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_userquery_createdby</summary>
			public static readonly XrmFakedRelationship LkUserqueryCreatedby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "createdby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "userquery",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_userquery_createdonbehalfby</summary>
			public static readonly XrmFakedRelationship LkUserqueryCreatedonbehalfby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "createdonbehalfby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "userquery",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_userquery_modifiedby</summary>
			public static readonly XrmFakedRelationship LkUserqueryModifiedby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "modifiedby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "userquery",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_userquery_modifiedonbehalfby</summary>
			public static readonly XrmFakedRelationship LkUserqueryModifiedonbehalfby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "modifiedonbehalfby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "userquery",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_userqueryvisualization_createdby</summary>
			public static readonly XrmFakedRelationship LkUserqueryvisualizationCreatedby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "createdby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "userqueryvisualization",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_userqueryvisualization_modifiedby</summary>
			public static readonly XrmFakedRelationship LkUserqueryvisualizationModifiedby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "modifiedby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "userqueryvisualization",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_userqueryvisualizationbase_createdonbehalfby</summary>
			public static readonly XrmFakedRelationship LkUserqueryvisualizationbaseCreatedonbehalfby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "createdonbehalfby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "userqueryvisualization",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_userqueryvisualizationbase_modifiedonbehalfby</summary>
			public static readonly XrmFakedRelationship LkUserqueryvisualizationbaseModifiedonbehalfby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "modifiedonbehalfby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "userqueryvisualization",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_usersettings_createdonbehalfby</summary>
			public static readonly XrmFakedRelationship LkUsersettingsCreatedonbehalfby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "createdonbehalfby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "usersettings",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_usersettings_modifiedonbehalfby</summary>
			public static readonly XrmFakedRelationship LkUsersettingsModifiedonbehalfby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "modifiedonbehalfby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "usersettings",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_usersettingsbase_createdby</summary>
			public static readonly XrmFakedRelationship LkUsersettingsbaseCreatedby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "createdby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "usersettings",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_usersettingsbase_modifiedby</summary>
			public static readonly XrmFakedRelationship LkUsersettingsbaseModifiedby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "modifiedby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "usersettings",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_webresourcebase_createdonbehalfby</summary>
			public static readonly XrmFakedRelationship LkWebresourcebaseCreatedonbehalfby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "createdonbehalfby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "webresource",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_webresourcebase_modifiedonbehalfby</summary>
			public static readonly XrmFakedRelationship LkWebresourcebaseModifiedonbehalfby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "modifiedonbehalfby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "webresource",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_webwizard_createdby</summary>
			public static readonly XrmFakedRelationship LkWebwizardCreatedby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "createdby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "webwizard",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_webwizard_createdonbehalfby</summary>
			public static readonly XrmFakedRelationship LkWebwizardCreatedonbehalfby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "createdonbehalfby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "webwizard",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_webwizard_modifiedby</summary>
			public static readonly XrmFakedRelationship LkWebwizardModifiedby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "modifiedby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "webwizard",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_webwizard_modifiedonbehalfby</summary>
			public static readonly XrmFakedRelationship LkWebwizardModifiedonbehalfby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "modifiedonbehalfby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "webwizard",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_workflowbinary_createdby</summary>
			public static readonly XrmFakedRelationship LkWorkflowbinaryCreatedby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "createdby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "workflowbinary",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_workflowbinary_createdonbehalfby</summary>
			public static readonly XrmFakedRelationship LkWorkflowbinaryCreatedonbehalfby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "createdonbehalfby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "workflowbinary",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_workflowbinary_modifiedby</summary>
			public static readonly XrmFakedRelationship LkWorkflowbinaryModifiedby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "modifiedby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "workflowbinary",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_workflowbinary_modifiedonbehalfby</summary>
			public static readonly XrmFakedRelationship LkWorkflowbinaryModifiedonbehalfby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "modifiedonbehalfby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "workflowbinary",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_workflowlog_createdby</summary>
			public static readonly XrmFakedRelationship LkWorkflowlogCreatedby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "createdby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "workflowlog",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_workflowlog_createdonbehalfby</summary>
			public static readonly XrmFakedRelationship LkWorkflowlogCreatedonbehalfby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "createdonbehalfby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "workflowlog",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_workflowlog_modifiedby</summary>
			public static readonly XrmFakedRelationship LkWorkflowlogModifiedby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "modifiedby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "workflowlog",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N lk_workflowlog_modifiedonbehalfby</summary>
			public static readonly XrmFakedRelationship LkWorkflowlogModifiedonbehalfby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "modifiedonbehalfby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "workflowlog",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N mailbox_regarding_systemuser</summary>
			public static readonly XrmFakedRelationship MailboxRegardingSystemuser = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "mailbox",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N modifiedby_connection</summary>
			public static readonly XrmFakedRelationship ModifiedbyConnection = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "modifiedby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "connection",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N modifiedby_connection_role</summary>
			public static readonly XrmFakedRelationship ModifiedbyConnectionRole = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "modifiedby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "connectionrole",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N modifiedby_pluginassembly</summary>
			public static readonly XrmFakedRelationship ModifiedbyPluginassembly = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "modifiedby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "pluginassembly",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N modifiedby_plugintype</summary>
			public static readonly XrmFakedRelationship ModifiedbyPlugintype = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "modifiedby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "plugintype",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N modifiedby_plugintypestatistic</summary>
			public static readonly XrmFakedRelationship ModifiedbyPlugintypestatistic = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "modifiedby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "plugintypestatistic",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N modifiedby_sdkmessage</summary>
			public static readonly XrmFakedRelationship ModifiedbySdkmessage = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "modifiedby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "sdkmessage",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N modifiedby_sdkmessagefilter</summary>
			public static readonly XrmFakedRelationship ModifiedbySdkmessagefilter = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "modifiedby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "sdkmessagefilter",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N modifiedby_sdkmessageprocessingstep</summary>
			public static readonly XrmFakedRelationship ModifiedbySdkmessageprocessingstep = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "modifiedby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "sdkmessageprocessingstep",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N modifiedby_sdkmessageprocessingstepimage</summary>
			public static readonly XrmFakedRelationship ModifiedbySdkmessageprocessingstepimage = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "modifiedby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "sdkmessageprocessingstepimage",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N modifiedby_sdkmessageprocessingstepsecureconfig</summary>
			public static readonly XrmFakedRelationship ModifiedbySdkmessageprocessingstepsecureconfig = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "modifiedby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "sdkmessageprocessingstepsecureconfig",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N modifiedby_serviceendpoint</summary>
			public static readonly XrmFakedRelationship ModifiedbyServiceendpoint = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "modifiedby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "serviceendpoint",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N msdyn_systemuser_wallsavedqueryusersettings_userid</summary>
			public static readonly XrmFakedRelationship MsdynSystemuserWallsavedqueryusersettingsUserid = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "msdyn_userid",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "msdyn_wallsavedqueryusersettings",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N opportunity_owning_user</summary>
			public static readonly XrmFakedRelationship OpportunityOwningUser = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "owninguser",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "opportunity",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N OwnerMapping_SystemUser</summary>
			public static readonly XrmFakedRelationship OwnerMappingSystemUser = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "targetsystemuserid",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "ownermapping",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N OwningUser_Dynamicpropertyinsatance</summary>
			public static readonly XrmFakedRelationship OwningUserDynamicpropertyinsatance = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "dynamicpropertyinstanceid",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "dynamicpropertyinstance",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N queue_primary_user</summary>
			public static readonly XrmFakedRelationship QueuePrimaryUser = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "primaryuserid",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "queue",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N socialProfile_owning_user</summary>
			public static readonly XrmFakedRelationship SocialProfileOwningUser = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "owninguser",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "socialprofile",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N system_user_accounts</summary>
			public static readonly XrmFakedRelationship SystemUserAccounts = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "preferredsystemuserid",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "account",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N system_user_activity_parties</summary>
			public static readonly XrmFakedRelationship SystemUserActivityParties = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "partyid",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "activityparty",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N system_user_asyncoperation</summary>
			public static readonly XrmFakedRelationship SystemUserAsyncoperation = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "owninguser",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "asyncoperation",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N system_user_contacts</summary>
			public static readonly XrmFakedRelationship SystemUserContacts = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "preferredsystemuserid",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "contact",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N system_user_email_templates</summary>
			public static readonly XrmFakedRelationship SystemUserEmailTemplates = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "owninguser",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "template",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N system_user_incidents</summary>
			public static readonly XrmFakedRelationship SystemUserIncidents = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "owninguser",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "incident",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N system_user_invoicedetail</summary>
			public static readonly XrmFakedRelationship SystemUserInvoicedetail = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "salesrepid",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "invoicedetail",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N system_user_invoices</summary>
			public static readonly XrmFakedRelationship SystemUserInvoices = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "owninguser",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "invoice",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N system_user_orders</summary>
			public static readonly XrmFakedRelationship SystemUserOrders = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "owninguser",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "salesorder",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N system_user_quotedetail</summary>
			public static readonly XrmFakedRelationship SystemUserQuotedetail = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "salesrepid",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "quotedetail",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N system_user_quotes</summary>
			public static readonly XrmFakedRelationship SystemUserQuotes = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "owninguser",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "quote",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N system_user_sales_literature</summary>
			public static readonly XrmFakedRelationship SystemUserSalesLiterature = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "employeecontactid",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "salesliterature",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N system_user_salesorderdetail</summary>
			public static readonly XrmFakedRelationship SystemUserSalesorderdetail = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "salesrepid",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "salesorderdetail",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N system_user_service_appointments</summary>
			public static readonly XrmFakedRelationship SystemUserServiceAppointments = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "owninguser",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "serviceappointment",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N system_user_service_contracts</summary>
			public static readonly XrmFakedRelationship SystemUserServiceContracts = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "owninguser",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "contract",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N system_user_territories</summary>
			public static readonly XrmFakedRelationship SystemUserTerritories = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "managerid",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "territory",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N system_user_workflow</summary>
			public static readonly XrmFakedRelationship SystemUserWorkflow = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "owninguser",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "workflow",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N SystemUser_AsyncOperations</summary>
			public static readonly XrmFakedRelationship SystemUserAsyncOperations = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "asyncoperation",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N systemuser_bookableresource_UserId</summary>
			public static readonly XrmFakedRelationship SystemuserBookableresourceUserId = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "userid",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "bookableresource",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N systemuser_bot_publishedby</summary>
			public static readonly XrmFakedRelationship SystemuserBotPublishedby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "publishedby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "bot",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N SystemUser_BulkDeleteFailures</summary>
			public static readonly XrmFakedRelationship SystemUserBulkDeleteFailures = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "bulkdeletefailure",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N SystemUser_Campaigns</summary>
			public static readonly XrmFakedRelationship SystemUserCampaigns = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "owninguser",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "campaign",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N systemuser_connections1</summary>
			public static readonly XrmFakedRelationship SystemuserConnections1 = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "record1id",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "connection",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N systemuser_connections2</summary>
			public static readonly XrmFakedRelationship SystemuserConnections2 = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "record2id",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "connection",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N SystemUser_DuplicateBaseRecord</summary>
			public static readonly XrmFakedRelationship SystemUserDuplicateBaseRecord = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "baserecordid",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "duplicaterecord",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N SystemUser_DuplicateMatchingRecord</summary>
			public static readonly XrmFakedRelationship SystemUserDuplicateMatchingRecord = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "duplicaterecordid",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "duplicaterecord",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N SystemUser_DuplicateRules</summary>
			public static readonly XrmFakedRelationship SystemUserDuplicateRules = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "owninguser",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "duplicaterule",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N SystemUser_Email_EmailSender</summary>
			public static readonly XrmFakedRelationship SystemUserEmailEmailSender = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "emailsender",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "email",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N SystemUser_ImportData</summary>
			public static readonly XrmFakedRelationship SystemUserImportData = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "owninguser",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "importdata",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N SystemUser_ImportFiles</summary>
			public static readonly XrmFakedRelationship SystemUserImportFiles = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "owninguser",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "importfile",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N SystemUser_ImportLogs</summary>
			public static readonly XrmFakedRelationship SystemUserImportLogs = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "owninguser",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "importlog",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N SystemUser_ImportMaps</summary>
			public static readonly XrmFakedRelationship SystemUserImportMaps = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "owninguser",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "importmap",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N SystemUser_Imports</summary>
			public static readonly XrmFakedRelationship SystemUserImports = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "owninguser",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "import",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N systemuser_PostFollows</summary>
			public static readonly XrmFakedRelationship SystemuserPostFollows = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "postfollow",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N systemuser_principalobjectattributeaccess</summary>
			public static readonly XrmFakedRelationship SystemuserPrincipalobjectattributeaccess = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "objectid",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "principalobjectattributeaccess",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N systemuser_principalobjectattributeaccess_principalid</summary>
			public static readonly XrmFakedRelationship SystemuserPrincipalobjectattributeaccessPrincipalid = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "principalid",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "principalobjectattributeaccess",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N SystemUser_ProcessSessions</summary>
			public static readonly XrmFakedRelationship SystemUserProcessSessions = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "processsession",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N systemuser_resources</summary>
			public static readonly XrmFakedRelationship SystemuserResources = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "resourceid",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "resource",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N SystemUser_SyncError</summary>
			public static readonly XrmFakedRelationship SystemUserSyncError = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "owninguser",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "syncerror",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N SystemUser_SyncErrors</summary>
			public static readonly XrmFakedRelationship SystemUserSyncErrors = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "regardingobjectid",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "syncerror",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N user_accounts</summary>
			public static readonly XrmFakedRelationship UserAccounts = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "owninguser",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "account",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N user_activity</summary>
			public static readonly XrmFakedRelationship UserActivity = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "owninguser",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "activitypointer",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N user_activitymonitor</summary>
			public static readonly XrmFakedRelationship UserActivitymonitor = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "owninguser",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "activitymonitor",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N user_adminsettingsentity</summary>
			public static readonly XrmFakedRelationship UserAdminsettingsentity = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "owninguser",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "adminsettingsentity",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N user_appointment</summary>
			public static readonly XrmFakedRelationship UserAppointment = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "owninguser",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "appointment",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N user_bookableresource</summary>
			public static readonly XrmFakedRelationship UserBookableresource = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "owninguser",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "bookableresource",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N user_bookableresourcebooking</summary>
			public static readonly XrmFakedRelationship UserBookableresourcebooking = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "owninguser",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "bookableresourcebooking",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N user_bookableresourcebookingheader</summary>
			public static readonly XrmFakedRelationship UserBookableresourcebookingheader = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "owninguser",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "bookableresourcebookingheader",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N user_bookableresourcecategory</summary>
			public static readonly XrmFakedRelationship UserBookableresourcecategory = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "owninguser",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "bookableresourcecategory",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N user_bookableresourcecategoryassn</summary>
			public static readonly XrmFakedRelationship UserBookableresourcecategoryassn = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "owninguser",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "bookableresourcecategoryassn",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N user_bookableresourcecharacteristic</summary>
			public static readonly XrmFakedRelationship UserBookableresourcecharacteristic = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "owninguser",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "bookableresourcecharacteristic",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N user_bookableresourcegroup</summary>
			public static readonly XrmFakedRelationship UserBookableresourcegroup = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "owninguser",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "bookableresourcegroup",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N user_bookingstatus</summary>
			public static readonly XrmFakedRelationship UserBookingstatus = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "owninguser",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "bookingstatus",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N user_bot</summary>
			public static readonly XrmFakedRelationship UserBot = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "owninguser",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "bot",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N user_botcomponent</summary>
			public static readonly XrmFakedRelationship UserBotcomponent = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "owninguser",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "botcomponent",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N user_BulkOperation</summary>
			public static readonly XrmFakedRelationship UserBulkOperation = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "owninguser",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "bulkoperation",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N user_campaignactivity</summary>
			public static readonly XrmFakedRelationship UserCampaignactivity = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "owninguser",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "campaignactivity",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N user_campaignresponse</summary>
			public static readonly XrmFakedRelationship UserCampaignresponse = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "owninguser",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "campaignresponse",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N user_characteristic</summary>
			public static readonly XrmFakedRelationship UserCharacteristic = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "owninguser",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "characteristic",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N user_connectionreference</summary>
			public static readonly XrmFakedRelationship UserConnectionreference = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "owninguser",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "connectionreference",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N user_connector</summary>
			public static readonly XrmFakedRelationship UserConnector = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "owninguser",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "connector",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N user_contractdetail</summary>
			public static readonly XrmFakedRelationship UserContractdetail = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "owninguser",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "contractdetail",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N user_conversationtranscript</summary>
			public static readonly XrmFakedRelationship UserConversationtranscript = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "owninguser",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "conversationtranscript",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N user_customapi</summary>
			public static readonly XrmFakedRelationship UserCustomapi = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "owninguser",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "customapi",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N user_customapirequestparameter</summary>
			public static readonly XrmFakedRelationship UserCustomapirequestparameter = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "owninguser",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "customapirequestparameter",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N user_customapiresponseproperty</summary>
			public static readonly XrmFakedRelationship UserCustomapiresponseproperty = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "owninguser",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "customapiresponseproperty",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N user_datalakefolder</summary>
			public static readonly XrmFakedRelationship UserDatalakefolder = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "owninguser",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "datalakefolder",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N user_datalakefolderpermission</summary>
			public static readonly XrmFakedRelationship UserDatalakefolderpermission = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "owninguser",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "datalakefolderpermission",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N user_email</summary>
			public static readonly XrmFakedRelationship UserEmail = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "owninguser",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "email",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N user_entitlement</summary>
			public static readonly XrmFakedRelationship UserEntitlement = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "owninguser",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "entitlement",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N user_entitlementchannel</summary>
			public static readonly XrmFakedRelationship UserEntitlementchannel = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "owninguser",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "entitlementchannel",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N user_entitlemententityallocationtypemapping</summary>
			public static readonly XrmFakedRelationship UserEntitlemententityallocationtypemapping = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "owninguser",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "entitlemententityallocationtypemapping",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N user_environmentvariabledefinition</summary>
			public static readonly XrmFakedRelationship UserEnvironmentvariabledefinition = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "owninguser",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "environmentvariabledefinition",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N user_environmentvariablevalue</summary>
			public static readonly XrmFakedRelationship UserEnvironmentvariablevalue = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "owninguser",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "environmentvariablevalue",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N user_exchangesyncidmapping</summary>
			public static readonly XrmFakedRelationship UserExchangesyncidmapping = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "owninguser",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "exchangesyncidmapping",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N user_exportsolutionupload</summary>
			public static readonly XrmFakedRelationship UserExportsolutionupload = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "owninguser",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "exportsolutionupload",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N user_fax</summary>
			public static readonly XrmFakedRelationship UserFax = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "owninguser",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "fax",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N user_flowsession</summary>
			public static readonly XrmFakedRelationship UserFlowsession = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "owninguser",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "flowsession",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N user_goal</summary>
			public static readonly XrmFakedRelationship UserGoal = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "owninguser",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "goal",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N user_goal_goalowner</summary>
			public static readonly XrmFakedRelationship UserGoalGoalowner = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "goalownerid",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "goal",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N user_incidentresolution</summary>
			public static readonly XrmFakedRelationship UserIncidentresolution = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "owninguser",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "incidentresolution",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N user_interactionforemail</summary>
			public static readonly XrmFakedRelationship UserInteractionforemail = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "owninguser",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "interactionforemail",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N user_invoicedetail</summary>
			public static readonly XrmFakedRelationship UserInvoicedetail = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "owninguser",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "invoicedetail",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N user_knowledgearticle</summary>
			public static readonly XrmFakedRelationship UserKnowledgearticle = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "owninguser",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "knowledgearticle",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N user_knowledgearticleincident</summary>
			public static readonly XrmFakedRelationship UserKnowledgearticleincident = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "owninguser",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "knowledgearticleincident",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N user_letter</summary>
			public static readonly XrmFakedRelationship UserLetter = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "owninguser",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "letter",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N user_list</summary>
			public static readonly XrmFakedRelationship UserList = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "owninguser",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "list",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N user_listoperation</summary>
			public static readonly XrmFakedRelationship UserListoperation = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "owninguser",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "listoperation",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N user_mailbox</summary>
			public static readonly XrmFakedRelationship UserMailbox = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "owninguser",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "mailbox",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N user_msdyn_actioncardregarding</summary>
			public static readonly XrmFakedRelationship UserMsdynActioncardregarding = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "owninguser",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "msdyn_actioncardregarding",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N user_msdyn_actioncardrolesetting</summary>
			public static readonly XrmFakedRelationship UserMsdynActioncardrolesetting = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "owninguser",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "msdyn_actioncardrolesetting",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N user_msdyn_aibdataset</summary>
			public static readonly XrmFakedRelationship UserMsdynAibdataset = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "owninguser",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "msdyn_aibdataset",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N user_msdyn_aibdatasetfile</summary>
			public static readonly XrmFakedRelationship UserMsdynAibdatasetfile = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "owninguser",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "msdyn_aibdatasetfile",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N user_msdyn_aibdatasetrecord</summary>
			public static readonly XrmFakedRelationship UserMsdynAibdatasetrecord = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "owninguser",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "msdyn_aibdatasetrecord",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N user_msdyn_aibdatasetscontainer</summary>
			public static readonly XrmFakedRelationship UserMsdynAibdatasetscontainer = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "owninguser",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "msdyn_aibdatasetscontainer",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N user_msdyn_aibfile</summary>
			public static readonly XrmFakedRelationship UserMsdynAibfile = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "owninguser",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "msdyn_aibfile",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N user_msdyn_aibfileattacheddata</summary>
			public static readonly XrmFakedRelationship UserMsdynAibfileattacheddata = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "owninguser",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "msdyn_aibfileattacheddata",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N user_msdyn_aiconfiguration</summary>
			public static readonly XrmFakedRelationship UserMsdynAiconfiguration = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "owninguser",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "msdyn_aiconfiguration",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N user_msdyn_aifptrainingdocument</summary>
			public static readonly XrmFakedRelationship UserMsdynAifptrainingdocument = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "owninguser",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "msdyn_aifptrainingdocument",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N user_msdyn_aimodel</summary>
			public static readonly XrmFakedRelationship UserMsdynAimodel = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "owninguser",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "msdyn_aimodel",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N user_msdyn_aiodimage</summary>
			public static readonly XrmFakedRelationship UserMsdynAiodimage = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "owninguser",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "msdyn_aiodimage",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N user_msdyn_aiodlabel</summary>
			public static readonly XrmFakedRelationship UserMsdynAiodlabel = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "owninguser",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "msdyn_aiodlabel",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N user_msdyn_aiodtrainingboundingbox</summary>
			public static readonly XrmFakedRelationship UserMsdynAiodtrainingboundingbox = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "owninguser",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "msdyn_aiodtrainingboundingbox",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N user_msdyn_aiodtrainingimage</summary>
			public static readonly XrmFakedRelationship UserMsdynAiodtrainingimage = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "owninguser",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "msdyn_aiodtrainingimage",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N user_msdyn_aitemplate</summary>
			public static readonly XrmFakedRelationship UserMsdynAitemplate = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "owninguser",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "msdyn_aitemplate",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N user_msdyn_autocapturerule</summary>
			public static readonly XrmFakedRelationship UserMsdynAutocapturerule = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "owninguser",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "msdyn_autocapturerule",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N user_msdyn_autocapturesettings</summary>
			public static readonly XrmFakedRelationship UserMsdynAutocapturesettings = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "owninguser",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "msdyn_autocapturesettings",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N user_msdyn_callablecontext</summary>
			public static readonly XrmFakedRelationship UserMsdynCallablecontext = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "owninguser",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "msdyn_callablecontext",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N user_msdyn_entityrankingrule</summary>
			public static readonly XrmFakedRelationship UserMsdynEntityrankingrule = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "owninguser",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "msdyn_entityrankingrule",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N user_msdyn_federatedarticle</summary>
			public static readonly XrmFakedRelationship UserMsdynFederatedarticle = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "owninguser",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "msdyn_federatedarticle",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N user_msdyn_flowcardtype</summary>
			public static readonly XrmFakedRelationship UserMsdynFlowcardtype = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "owninguser",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "msdyn_flowcardtype",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N user_msdyn_icebreakersconfig</summary>
			public static readonly XrmFakedRelationship UserMsdynIcebreakersconfig = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "owninguser",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "msdyn_icebreakersconfig",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N user_msdyn_kmfederatedsearchconfig</summary>
			public static readonly XrmFakedRelationship UserMsdynKmfederatedsearchconfig = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "owninguser",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "msdyn_kmfederatedsearchconfig",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N user_msdyn_knowledgearticleimage</summary>
			public static readonly XrmFakedRelationship UserMsdynKnowledgearticleimage = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "owninguser",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "msdyn_knowledgearticleimage",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N user_msdyn_knowledgearticletemplate</summary>
			public static readonly XrmFakedRelationship UserMsdynKnowledgearticletemplate = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "owninguser",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "msdyn_knowledgearticletemplate",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N user_msdyn_knowledgeinteractioninsight</summary>
			public static readonly XrmFakedRelationship UserMsdynKnowledgeinteractioninsight = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "owninguser",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "msdyn_knowledgeinteractioninsight",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N user_msdyn_knowledgesearchinsight</summary>
			public static readonly XrmFakedRelationship UserMsdynKnowledgesearchinsight = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "owninguser",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "msdyn_knowledgesearchinsight",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N user_msdyn_msteamssetting</summary>
			public static readonly XrmFakedRelationship UserMsdynMsteamssetting = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "owninguser",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "msdyn_msteamssetting",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N user_msdyn_notesanalysisconfig</summary>
			public static readonly XrmFakedRelationship UserMsdynNotesanalysisconfig = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "owninguser",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "msdyn_notesanalysisconfig",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N user_msdyn_playbookactivity</summary>
			public static readonly XrmFakedRelationship UserMsdynPlaybookactivity = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "owninguser",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "msdyn_playbookactivity",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N user_msdyn_playbookactivityattribute</summary>
			public static readonly XrmFakedRelationship UserMsdynPlaybookactivityattribute = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "owninguser",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "msdyn_playbookactivityattribute",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N user_msdyn_playbookcategory</summary>
			public static readonly XrmFakedRelationship UserMsdynPlaybookcategory = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "owninguser",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "msdyn_playbookcategory",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N user_msdyn_playbookinstance</summary>
			public static readonly XrmFakedRelationship UserMsdynPlaybookinstance = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "owninguser",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "msdyn_playbookinstance",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N user_msdyn_playbooktemplate</summary>
			public static readonly XrmFakedRelationship UserMsdynPlaybooktemplate = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "owninguser",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "msdyn_playbooktemplate",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N user_msdyn_postalbum</summary>
			public static readonly XrmFakedRelationship UserMsdynPostalbum = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "owninguser",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "msdyn_postalbum",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N user_msdyn_relationshipinsightsunifiedconfig</summary>
			public static readonly XrmFakedRelationship UserMsdynRelationshipinsightsunifiedconfig = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "owninguser",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "msdyn_relationshipinsightsunifiedconfig",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N user_msdyn_richtextfile</summary>
			public static readonly XrmFakedRelationship UserMsdynRichtextfile = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "owninguser",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "msdyn_richtextfile",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N user_msdyn_salesinsightssettings</summary>
			public static readonly XrmFakedRelationship UserMsdynSalesinsightssettings = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "owninguser",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "msdyn_salesinsightssettings",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N user_msdyn_siconfig</summary>
			public static readonly XrmFakedRelationship UserMsdynSiconfig = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "owninguser",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "msdyn_siconfig",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N user_msdyn_untrackedappointment</summary>
			public static readonly XrmFakedRelationship UserMsdynUntrackedappointment = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "owninguser",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "msdyn_untrackedappointment",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N user_msdyn_wallsavedqueryusersettings</summary>
			public static readonly XrmFakedRelationship UserMsdynWallsavedqueryusersettings = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "owninguser",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "msdyn_wallsavedqueryusersettings",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N user_msdynce_botcontent</summary>
			public static readonly XrmFakedRelationship UserMsdynceBotcontent = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "owninguser",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "msdynce_botcontent",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N user_opportunityclose</summary>
			public static readonly XrmFakedRelationship UserOpportunityclose = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "owninguser",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "opportunityclose",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N user_opportunityproduct</summary>
			public static readonly XrmFakedRelationship UserOpportunityproduct = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "owninguser",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "opportunityproduct",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N user_orderclose</summary>
			public static readonly XrmFakedRelationship UserOrderclose = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "owninguser",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "orderclose",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N user_owner_postfollows</summary>
			public static readonly XrmFakedRelationship UserOwnerPostfollows = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "owninguser",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "postfollow",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N user_parent_user</summary>
			public static readonly XrmFakedRelationship UserParentUser = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "parentsystemuserid",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "systemuser",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N user_phonecall</summary>
			public static readonly XrmFakedRelationship UserPhonecall = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "owninguser",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "phonecall",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N user_processstageparameter</summary>
			public static readonly XrmFakedRelationship UserProcessstageparameter = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "owninguser",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "processstageparameter",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N user_pw_penta_schedule_run</summary>
			public static readonly XrmFakedRelationship UserPwPentaScheduleRun = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "owninguser",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "pw_penta_schedule_run",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N user_pw_schedule</summary>
			public static readonly XrmFakedRelationship UserPwSchedule = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "owninguser",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "pw_schedule",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N user_quoteclose</summary>
			public static readonly XrmFakedRelationship UserQuoteclose = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "owninguser",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "quoteclose",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N user_quotedetail</summary>
			public static readonly XrmFakedRelationship UserQuotedetail = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "owninguser",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "quotedetail",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N user_ratingmodel</summary>
			public static readonly XrmFakedRelationship UserRatingmodel = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "owninguser",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "ratingmodel",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N user_ratingvalue</summary>
			public static readonly XrmFakedRelationship UserRatingvalue = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "owninguser",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "ratingvalue",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N user_recurringappointmentmaster</summary>
			public static readonly XrmFakedRelationship UserRecurringappointmentmaster = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "owninguser",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "recurringappointmentmaster",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N user_salesorderdetail</summary>
			public static readonly XrmFakedRelationship UserSalesorderdetail = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "owninguser",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "salesorderdetail",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N user_settings</summary>
			public static readonly XrmFakedRelationship UserSettings = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "systemuserid",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "usersettings",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N user_sharepointdocumentlocation</summary>
			public static readonly XrmFakedRelationship UserSharepointdocumentlocation = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "owninguser",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "sharepointdocumentlocation",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N user_sharepointsite</summary>
			public static readonly XrmFakedRelationship UserSharepointsite = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "owninguser",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "sharepointsite",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N user_slabase</summary>
			public static readonly XrmFakedRelationship UserSlabase = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "owninguser",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "sla",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N user_socialactivity</summary>
			public static readonly XrmFakedRelationship UserSocialactivity = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "owninguser",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "socialactivity",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N user_stagesolutionupload</summary>
			public static readonly XrmFakedRelationship UserStagesolutionupload = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "owninguser",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "stagesolutionupload",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N user_task</summary>
			public static readonly XrmFakedRelationship UserTask = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "owninguser",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "task",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N user_userform</summary>
			public static readonly XrmFakedRelationship UserUserform = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "owninguser",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "userform",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N user_userquery</summary>
			public static readonly XrmFakedRelationship UserUserquery = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "owninguser",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "userquery",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N user_userqueryvisualizations</summary>
			public static readonly XrmFakedRelationship UserUserqueryvisualizations = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "owninguser",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "userqueryvisualization",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N user_workflowbinary</summary>
			public static readonly XrmFakedRelationship UserWorkflowbinary = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "owninguser",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "workflowbinary",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N webresource_createdby</summary>
			public static readonly XrmFakedRelationship WebresourceCreatedby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "createdby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "webresource",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N webresource_modifiedby</summary>
			public static readonly XrmFakedRelationship WebresourceModifiedby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "modifiedby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "webresource",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N workflow_createdby</summary>
			public static readonly XrmFakedRelationship WorkflowCreatedby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "createdby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "workflow",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N workflow_createdonbehalfby</summary>
			public static readonly XrmFakedRelationship WorkflowCreatedonbehalfby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "createdonbehalfby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "workflow",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N workflow_modifiedby</summary>
			public static readonly XrmFakedRelationship WorkflowModifiedby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "modifiedby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "workflow",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>1:N workflow_modifiedonbehalfby</summary>
			public static readonly XrmFakedRelationship WorkflowModifiedonbehalfby = 
				new XrmFakedRelationship
				{
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "modifiedonbehalfby",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "workflow",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.OneToMany
				};

			/// <summary>N:N queuemembership_association</summary>
			public static readonly XrmFakedRelationship QueuemembershipAssociation = 
				new XrmFakedRelationship
				{
					IntersectEntity = "queuemembership_association",
					Entity1Attribute = "queueid",
					Entity2Attribute = "systemuserid",
					Entity1LogicalName = "queue",
					Entity2LogicalName = "systemuser",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.ManyToMany
				};

			/// <summary>N:N systemuserprofiles_association</summary>
			public static readonly XrmFakedRelationship SystemuserprofilesAssociation = 
				new XrmFakedRelationship
				{
					IntersectEntity = "systemuserprofiles_association",
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "fieldsecurityprofileid",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "fieldsecurityprofile",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.ManyToMany
				};

			/// <summary>N:N systemuserroles_association</summary>
			public static readonly XrmFakedRelationship SystemuserrolesAssociation = 
				new XrmFakedRelationship
				{
					IntersectEntity = "systemuserroles_association",
					Entity1Attribute = "systemuserid",
					Entity2Attribute = "roleid",
					Entity1LogicalName = "systemuser",
					Entity2LogicalName = "role",
					RelationshipType = XrmFakedRelationship.enmFakeRelationshipType.ManyToMany
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

		}
		#endregion

		#region Fake
		public static User Create()
		{
			var faker = new Faker<User>()
			.RuleFor(e => e.AccessMode, fake => fake.PickRandom<User.eAccessMode>())
			.RuleFor(e => e.ActiveDirectoryGuId, fake => Guid.NewGuid())
			.RuleFor(e => e.Address1Id, fake => Guid.NewGuid())
			.RuleFor(e => e.Address1AddressType, fake => fake.PickRandom<User.eAddress1AddressType>())
			.RuleFor(e => e.City, fake => fake.Lorem.Word())
			.RuleFor(e => e.Address, fake => fake.Lorem.Word())
			.RuleFor(e => e.CountryRegion, fake => fake.Lorem.Word())
			.RuleFor(e => e.Address1County, fake => fake.Lorem.Word())
			.RuleFor(e => e.Address1Fax, fake => fake.Lorem.Word())
			.RuleFor(e => e.Address1Latitude, fake => fake.Random.Double())
			.RuleFor(e => e.Street1, fake => fake.Lorem.Word())
			.RuleFor(e => e.Street2, fake => fake.Lorem.Word())
			.RuleFor(e => e.Street3, fake => fake.Lorem.Word())
			.RuleFor(e => e.Address1Longitude, fake => fake.Random.Double())
			.RuleFor(e => e.Address1Name, fake => fake.Lorem.Word())
			.RuleFor(e => e.ZIPPostalCode, fake => fake.Lorem.Word())
			.RuleFor(e => e.Address1PostOfficeBox, fake => fake.Lorem.Word())
			.RuleFor(e => e.Address1ShippingMethod, fake => fake.PickRandom<User.eAddress1ShippingMethod>())
			.RuleFor(e => e.StateProvince, fake => fake.Lorem.Word())
			.RuleFor(e => e.MainPhone, fake => fake.Lorem.Word())
			.RuleFor(e => e.OtherPhone, fake => fake.Lorem.Word())
			.RuleFor(e => e.Pager, fake => fake.Lorem.Word())
			.RuleFor(e => e.Address1UPSZone, fake => fake.Lorem.Word())
			.RuleFor(e => e.Address1UTCOffset, fake => fake.Random.Int())
			.RuleFor(e => e.Address2Id, fake => Guid.NewGuid())
			.RuleFor(e => e.Address2AddressType, fake => fake.PickRandom<User.eAddress2AddressType>())
			.RuleFor(e => e.OtherCity, fake => fake.Lorem.Word())
			.RuleFor(e => e.OtherAddress, fake => fake.Lorem.Word())
			.RuleFor(e => e.OtherCountryRegion, fake => fake.Lorem.Word())
			.RuleFor(e => e.Address2County, fake => fake.Lorem.Word())
			.RuleFor(e => e.Address2Fax, fake => fake.Lorem.Word())
			.RuleFor(e => e.Address2Latitude, fake => fake.Random.Double())
			.RuleFor(e => e.OtherStreet1, fake => fake.Lorem.Word())
			.RuleFor(e => e.OtherStreet2, fake => fake.Lorem.Word())
			.RuleFor(e => e.OtherStreet3, fake => fake.Lorem.Word())
			.RuleFor(e => e.Address2Longitude, fake => fake.Random.Double())
			.RuleFor(e => e.Address2Name, fake => fake.Lorem.Word())
			.RuleFor(e => e.OtherZIPPostalCode, fake => fake.Lorem.Word())
			.RuleFor(e => e.Address2PostOfficeBox, fake => fake.Lorem.Word())
			.RuleFor(e => e.Address2ShippingMethod, fake => fake.PickRandom<User.eAddress2ShippingMethod>())
			.RuleFor(e => e.OtherStateProvince, fake => fake.Lorem.Word())
			.RuleFor(e => e.Address2Telephone1, fake => fake.Lorem.Word())
			.RuleFor(e => e.Address2Telephone2, fake => fake.Lorem.Word())
			.RuleFor(e => e.Address2Telephone3, fake => fake.Lorem.Word())
			.RuleFor(e => e.Address2UPSZone, fake => fake.Lorem.Word())
			.RuleFor(e => e.Address2UTCOffset, fake => fake.Random.Int())
			.RuleFor(e => e.ApplicationId, fake => Guid.NewGuid())
			.RuleFor(e => e.ApplicationIDURI, fake => fake.Lorem.Word())
			.RuleFor(e => e.AzureADObjectId, fake => Guid.NewGuid())
			.RuleFor(e => e.Businessunitidname, fake => fake.Lorem.Word())
			.RuleFor(e => e.LicenseType, fake => fake.PickRandom<User.eCALTypes>())
			.RuleFor(e => e.Createdbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Createdbyyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.CreatedOn, fake => fake.Date.Soon())
			.RuleFor(e => e.Createdonbehalfbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Createdonbehalfbyyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.DefaultFiltersPopulated, fake => fake.Random.Bool())
			.RuleFor(e => e.Defaultmailboxname, fake => fake.Lorem.Word())
			.RuleFor(e => e.DefaultOneDriveForBusinessFolderName, fake => fake.Lorem.Word())
			.RuleFor(e => e.DisabledReason, fake => fake.Lorem.Word())
			.RuleFor(e => e.DisplayInServiceViews, fake => fake.Random.Bool())
			.RuleFor(e => e.UserName, fake => fake.Lorem.Word())
			.RuleFor(e => e.PrimaryEmailStatus, fake => fake.PickRandom<User.eShowsWhetherTheEmailAddressIsApprovedForEachMailboxForProcessingEmailThroughServersideSynchronizationOrTheEmailRouter>())
			.RuleFor(e => e.Employee, fake => fake.Lorem.Word())
			.RuleFor(e => e.EntityimageTimestamp, fake => fake.Random.Int())
			.RuleFor(e => e.EntityimageUrl, fake => fake.Lorem.Word())
			.RuleFor(e => e.EntityImageId, fake => Guid.NewGuid())
			.RuleFor(e => e.ExchangeRate, fake => fake.Finance.Amount())
			.RuleFor(e => e.FirstName, fake => fake.Lorem.Word())
			.RuleFor(e => e.FullName, fake => fake.Lorem.Word())
			.RuleFor(e => e.Government, fake => fake.Lorem.Word())
			.RuleFor(e => e.HomePhone, fake => fake.Lorem.Word())
			.RuleFor(e => e.UniqueUserIdentityId, fake => fake.Random.Int())
			.RuleFor(e => e.ImportSequenceNumber, fake => fake.Random.Int())
			.RuleFor(e => e.IncomingEmailDeliveryMethod, fake => fake.PickRandom<User.eIncomingEmailDeliveryMethod>())
			.RuleFor(e => e.PrimaryEmail, fake => fake.Lorem.Word())
			.RuleFor(e => e.InvitationStatus, fake => fake.PickRandom<User.eInvitationStatus>())
			.RuleFor(e => e.IsActiveDirectoryUser, fake => fake.Random.Bool())
			.RuleFor(e => e.Status, fake => fake.Random.Bool())
			.RuleFor(e => e.EmailAddressO365AdminApprovalStatus, fake => fake.Random.Bool())
			.RuleFor(e => e.IntegrationUserMode, fake => fake.Random.Bool())
			.RuleFor(e => e.UserLicensed, fake => fake.Random.Bool())
			.RuleFor(e => e.UserSynced, fake => fake.Random.Bool())
			.RuleFor(e => e.JobTitle, fake => fake.Lorem.Word())
			.RuleFor(e => e.LastName, fake => fake.Lorem.Word())
			.RuleFor(e => e.LatestUserUpdateTime, fake => fake.Date.Soon())
			.RuleFor(e => e.MiddleName, fake => fake.Lorem.Word())
			.RuleFor(e => e.MobileAlertEmail, fake => fake.Lorem.Word())
			.RuleFor(e => e.Mobileofflineprofileidname, fake => fake.Lorem.Word())
			.RuleFor(e => e.MobilePhone, fake => fake.Lorem.Word())
			.RuleFor(e => e.Modifiedbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Modifiedbyyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.ModifiedOn, fake => fake.Date.Soon())
			.RuleFor(e => e.Modifiedonbehalfbyname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Modifiedonbehalfbyyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.GDPROptout, fake => fake.Random.Bool())
			.RuleFor(e => e.Nickname, fake => fake.Lorem.Word())
			.RuleFor(e => e.OrganizationId, fake => Guid.NewGuid())
			.RuleFor(e => e.Organizationidname, fake => fake.Lorem.Word())
			.RuleFor(e => e.OutgoingEmailDeliveryMethod, fake => fake.PickRandom<User.eOutgoingEmailDeliveryMethod>())
			.RuleFor(e => e.RecordCreatedOn, fake => fake.Date.Soon())
			.RuleFor(e => e.Parentsystemuseridname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Parentsystemuseridyominame, fake => fake.Lorem.Word())
			.RuleFor(e => e.PassportHi, fake => fake.Random.Int())
			.RuleFor(e => e.PassportLo, fake => fake.Random.Int())
			.RuleFor(e => e.Email2, fake => fake.Lorem.Word())
			.RuleFor(e => e.PhotoURL, fake => fake.Lorem.Word())
			.RuleFor(e => e.Positionidname, fake => fake.Lorem.Word())
			.RuleFor(e => e.PreferredAddress, fake => fake.PickRandom<User.ePreferredAddress>())
			.RuleFor(e => e.PreferredEmail, fake => fake.PickRandom<User.ePreferredEmail>())
			.RuleFor(e => e.PreferredPhone, fake => fake.PickRandom<User.ePreferredPhone>())
			.RuleFor(e => e.ProcessId, fake => Guid.NewGuid())
			.RuleFor(e => e.Queueidname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Salutation, fake => fake.Lorem.Word())
			.RuleFor(e => e.RestrictedAccessMode, fake => fake.Random.Bool())
			.RuleFor(e => e.SharePointEmailAddress, fake => fake.Lorem.Word())
			.RuleFor(e => e.Siteidname, fake => fake.Lorem.Word())
			.RuleFor(e => e.Skills, fake => fake.Lorem.Word())
			.RuleFor(e => e.DeprecatedProcessStageId, fake => Guid.NewGuid())
			.RuleFor(e => e.Id, fake => Guid.NewGuid())
			.RuleFor(e => e.Territoryidname, fake => fake.Lorem.Word())
			.RuleFor(e => e.TimeZoneRuleVersionNumber, fake => fake.Random.Int())
			.RuleFor(e => e.Title, fake => fake.Lorem.Word())
			.RuleFor(e => e.Transactioncurrencyidname, fake => fake.Lorem.Word())
			.RuleFor(e => e.DeprecatedTraversedPath, fake => fake.Lorem.Word())
			.RuleFor(e => e.UserLicenseType, fake => fake.Random.Int())
			.RuleFor(e => e.UserPUID, fake => fake.Lorem.Word())
			.RuleFor(e => e.UTCConversionTimeZoneCode, fake => fake.Random.Int())
			.RuleFor(e => e.VersionNumber, fake => fake.Random.Int())
			.RuleFor(e => e.WindowsLiveID, fake => fake.Lorem.Word())
			.RuleFor(e => e.YammerEmail, fake => fake.Lorem.Word())
			.RuleFor(e => e.YammerUserID, fake => fake.Lorem.Word())
			.RuleFor(e => e.YomiFirstName, fake => fake.Lorem.Word())
			.RuleFor(e => e.YomiFullName, fake => fake.Lorem.Word())
			.RuleFor(e => e.YomiLastName, fake => fake.Lorem.Word())
			.RuleFor(e => e.YomiMiddleName, fake => fake.Lorem.Word());
			return faker.Generate();
		}
		#endregion
	}
}

