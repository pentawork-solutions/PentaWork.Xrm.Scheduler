using System;
using System.Linq;
using System.Diagnostics;
using System.ComponentModel;
using Microsoft.Xrm.Sdk; 
using Microsoft.Xrm.Sdk.Client;
using System.Collections.Generic;

namespace PentaWork.Xrm.Scheduler.Proxies.Entities
{
	[DebuggerDisplay("{Name}")] 	
	[EntityLogicalName("report")]
	public sealed class Report : Entity
	{	
		public static readonly int? EntityTypeCode = 9100;
		public new const string LogicalName = "report";
		public const string PrimaryIdAttribute = "reportid";
		public const string PrimaryNameAttribute = "name";
	
		public Report() : base("report") { }

		#region Attributes
		/// <summary>
        /// bodybinary
        /// </summary>
		[DisplayName("Body Binary")]
		[AttributeLogicalName("bodybinary")]
		public string BodyBinary
		{	
			get { return GetAttributeValue<string>("bodybinary"); }
			set
			{ 
				if(value == BodyBinary) return;
				SetAttributeValue("bodybinary", value);
			}
		}	
			
		/// <summary>
        /// bodytext
        /// </summary>
		[DisplayName("Body Text")]
		[AttributeLogicalName("bodytext")]
		public string BodyText
		{	
			get { return GetAttributeValue<string>("bodytext"); }
			set
			{ 
				if(value == BodyText) return;
				SetAttributeValue("bodytext", value);
			}
		}	
			
		/// <summary>
        /// bodyurl
        /// </summary>
		[DisplayName("Linked Report URL")]
		[AttributeLogicalName("bodyurl")]
		public string LinkedReportURL
		{	
			get { return GetAttributeValue<string>("bodyurl"); }
			set
			{ 
				if(value == LinkedReportURL) return;
				SetAttributeValue("bodyurl", value);
			}
		}	
			
		/// <summary>
        /// componentstate
        /// </summary>
		[DisplayName("Component State")]
		[AttributeLogicalName("componentstate")]
		public egComponentState? ComponentState
		{	
			get 
			{ 
				var optionSetValue = GetAttributeValue<OptionSetValue>("componentstate");
				if (optionSetValue != null) return (egComponentState)optionSetValue.Value;
				else return null;
			}
			set 
			{ 
				if(value == ComponentState) return;

				OptionSetValue optionSetValue = null;
				if(value != null) optionSetValue = new OptionSetValue((int)value);
				SetAttributeValue("componentstate", optionSetValue); 
			}
		}

		/// <summary>
        /// createdby
        /// </summary>
		[DisplayName("Created By")]
		[AttributeLogicalName("createdby")]
		public EntityReference CreatedBy
		{	
			get { return GetAttributeValue<EntityReference>("createdby"); }
			set
			{ 
				if(value == CreatedBy) return;
				SetAttributeValue("createdby", value);
			}
		}	
			
		/// <summary>
        /// createdbyname
        /// </summary>
		[DisplayName("createdbyname")]
		[AttributeLogicalName("createdbyname")]
		public string Createdbyname
		{	
			get { return GetAttributeValue<string>("createdbyname"); }
			set
			{ 
				if(value == Createdbyname) return;
				SetAttributeValue("createdbyname", value);
			}
		}	
			
		/// <summary>
        /// createdbyyominame
        /// </summary>
		[DisplayName("createdbyyominame")]
		[AttributeLogicalName("createdbyyominame")]
		public string Createdbyyominame
		{	
			get { return GetAttributeValue<string>("createdbyyominame"); }
			set
			{ 
				if(value == Createdbyyominame) return;
				SetAttributeValue("createdbyyominame", value);
			}
		}	
			
		/// <summary>
        /// createdinmajorversion
        /// </summary>
		[DisplayName("Crm Version in which the Report is created")]
		[AttributeLogicalName("createdinmajorversion")]
		public int? CrmVersionInWhichTheReportIsCreated
		{	
			get { return GetAttributeValue<int?>("createdinmajorversion"); }
			set
			{ 
				if(value == CrmVersionInWhichTheReportIsCreated) return;
				SetAttributeValue("createdinmajorversion", value);
			}
		}	
			
		/// <summary>
        /// createdon
        /// </summary>
		[DisplayName("Created On")]
		[AttributeLogicalName("createdon")]
		public DateTime? CreatedOn
		{	
			get { return GetAttributeValue<DateTime?>("createdon"); }
			set
			{ 
				if(value == CreatedOn) return;
				SetAttributeValue("createdon", value);
			}
		}	
			
		/// <summary>
        /// createdonbehalfby
        /// </summary>
		[DisplayName("Created By (Delegate)")]
		[AttributeLogicalName("createdonbehalfby")]
		public EntityReference CreatedByDelegate
		{	
			get { return GetAttributeValue<EntityReference>("createdonbehalfby"); }
			set
			{ 
				if(value == CreatedByDelegate) return;
				SetAttributeValue("createdonbehalfby", value);
			}
		}	
			
		/// <summary>
        /// createdonbehalfbyname
        /// </summary>
		[DisplayName("createdonbehalfbyname")]
		[AttributeLogicalName("createdonbehalfbyname")]
		public string Createdonbehalfbyname
		{	
			get { return GetAttributeValue<string>("createdonbehalfbyname"); }
			set
			{ 
				if(value == Createdonbehalfbyname) return;
				SetAttributeValue("createdonbehalfbyname", value);
			}
		}	
			
		/// <summary>
        /// createdonbehalfbyyominame
        /// </summary>
		[DisplayName("createdonbehalfbyyominame")]
		[AttributeLogicalName("createdonbehalfbyyominame")]
		public string Createdonbehalfbyyominame
		{	
			get { return GetAttributeValue<string>("createdonbehalfbyyominame"); }
			set
			{ 
				if(value == Createdonbehalfbyyominame) return;
				SetAttributeValue("createdonbehalfbyyominame", value);
			}
		}	
			
		/// <summary>
        /// customreportxml
        /// </summary>
		[DisplayName("Custom Report XML")]
		[AttributeLogicalName("customreportxml")]
		public string CustomReportXML
		{	
			get { return GetAttributeValue<string>("customreportxml"); }
			set
			{ 
				if(value == CustomReportXML) return;
				SetAttributeValue("customreportxml", value);
			}
		}	
			
		/// <summary>
        /// defaultfilter
        /// </summary>
		[DisplayName("Default filter")]
		[AttributeLogicalName("defaultfilter")]
		public string DefaultFilter
		{	
			get { return GetAttributeValue<string>("defaultfilter"); }
			set
			{ 
				if(value == DefaultFilter) return;
				SetAttributeValue("defaultfilter", value);
			}
		}	
			
		/// <summary>
        /// description
        /// </summary>
		[DisplayName("Description")]
		[AttributeLogicalName("description")]
		public string Description
		{	
			get { return GetAttributeValue<string>("description"); }
			set
			{ 
				if(value == Description) return;
				SetAttributeValue("description", value);
			}
		}	
			
		/// <summary>
        /// filename
        /// </summary>
		[DisplayName("File Name")]
		[AttributeLogicalName("filename")]
		public string FileName
		{	
			get { return GetAttributeValue<string>("filename"); }
			set
			{ 
				if(value == FileName) return;
				SetAttributeValue("filename", value);
			}
		}	
			
		/// <summary>
        /// filesize
        /// </summary>
		[DisplayName("File Size (Bytes)")]
		[AttributeLogicalName("filesize")]
		public int? FileSizeBytes
		{	
			get { return GetAttributeValue<int?>("filesize"); }
			set
			{ 
				if(value == FileSizeBytes) return;
				SetAttributeValue("filesize", value);
			}
		}	
			
		/// <summary>
        /// introducedversion
        /// </summary>
		[DisplayName("Introduced Version")]
		[AttributeLogicalName("introducedversion")]
		public string IntroducedVersion
		{	
			get { return GetAttributeValue<string>("introducedversion"); }
			set
			{ 
				if(value == IntroducedVersion) return;
				SetAttributeValue("introducedversion", value);
			}
		}	
			
		/// <summary>
        /// iscustomreport
        /// </summary>
		[DisplayName("Is Custom Report")]
		[AttributeLogicalName("iscustomreport")]
		public bool? IsCustomReport
		{	
			get { return GetAttributeValue<bool?>("iscustomreport"); }
			set
			{ 
				if(value == IsCustomReport) return;
				SetAttributeValue("iscustomreport", value);
			}
		}	
			
		/// <summary>
        /// ismanaged
        /// </summary>
		[DisplayName("Is Managed")]
		[AttributeLogicalName("ismanaged")]
		public bool? IsManaged
		{	
			get { return GetAttributeValue<bool?>("ismanaged"); }
			set
			{ 
				if(value == IsManaged) return;
				SetAttributeValue("ismanaged", value);
			}
		}	
			
		/// <summary>
        /// ispersonal
        /// </summary>
		[DisplayName("Viewable By")]
		[AttributeLogicalName("ispersonal")]
		public bool? ViewableBy
		{	
			get { return GetAttributeValue<bool?>("ispersonal"); }
			set
			{ 
				if(value == ViewableBy) return;
				SetAttributeValue("ispersonal", value);
			}
		}	
			
		/// <summary>
        /// isscheduledreport
        /// </summary>
		[DisplayName("Is Scheduled Report")]
		[AttributeLogicalName("isscheduledreport")]
		public bool? IsScheduledReport
		{	
			get { return GetAttributeValue<bool?>("isscheduledreport"); }
			set
			{ 
				if(value == IsScheduledReport) return;
				SetAttributeValue("isscheduledreport", value);
			}
		}	
			
		/// <summary>
        /// languagecode
        /// </summary>
		[DisplayName("Language")]
		[AttributeLogicalName("languagecode")]
		public int? Language
		{	
			get { return GetAttributeValue<int?>("languagecode"); }
			set
			{ 
				if(value == Language) return;
				SetAttributeValue("languagecode", value);
			}
		}	
			
		/// <summary>
        /// mimetype
        /// </summary>
		[DisplayName("Mime Type")]
		[AttributeLogicalName("mimetype")]
		public string MimeType
		{	
			get { return GetAttributeValue<string>("mimetype"); }
			set
			{ 
				if(value == MimeType) return;
				SetAttributeValue("mimetype", value);
			}
		}	
			
		/// <summary>
        /// modifiedby
        /// </summary>
		[DisplayName("Modified By")]
		[AttributeLogicalName("modifiedby")]
		public EntityReference ModifiedBy
		{	
			get { return GetAttributeValue<EntityReference>("modifiedby"); }
			set
			{ 
				if(value == ModifiedBy) return;
				SetAttributeValue("modifiedby", value);
			}
		}	
			
		/// <summary>
        /// modifiedbyname
        /// </summary>
		[DisplayName("modifiedbyname")]
		[AttributeLogicalName("modifiedbyname")]
		public string Modifiedbyname
		{	
			get { return GetAttributeValue<string>("modifiedbyname"); }
			set
			{ 
				if(value == Modifiedbyname) return;
				SetAttributeValue("modifiedbyname", value);
			}
		}	
			
		/// <summary>
        /// modifiedbyyominame
        /// </summary>
		[DisplayName("modifiedbyyominame")]
		[AttributeLogicalName("modifiedbyyominame")]
		public string Modifiedbyyominame
		{	
			get { return GetAttributeValue<string>("modifiedbyyominame"); }
			set
			{ 
				if(value == Modifiedbyyominame) return;
				SetAttributeValue("modifiedbyyominame", value);
			}
		}	
			
		/// <summary>
        /// modifiedon
        /// </summary>
		[DisplayName("Modified On")]
		[AttributeLogicalName("modifiedon")]
		public DateTime? ModifiedOn
		{	
			get { return GetAttributeValue<DateTime?>("modifiedon"); }
			set
			{ 
				if(value == ModifiedOn) return;
				SetAttributeValue("modifiedon", value);
			}
		}	
			
		/// <summary>
        /// modifiedonbehalfby
        /// </summary>
		[DisplayName("Modified By (Delegate)")]
		[AttributeLogicalName("modifiedonbehalfby")]
		public EntityReference ModifiedByDelegate
		{	
			get { return GetAttributeValue<EntityReference>("modifiedonbehalfby"); }
			set
			{ 
				if(value == ModifiedByDelegate) return;
				SetAttributeValue("modifiedonbehalfby", value);
			}
		}	
			
		/// <summary>
        /// modifiedonbehalfbyname
        /// </summary>
		[DisplayName("modifiedonbehalfbyname")]
		[AttributeLogicalName("modifiedonbehalfbyname")]
		public string Modifiedonbehalfbyname
		{	
			get { return GetAttributeValue<string>("modifiedonbehalfbyname"); }
			set
			{ 
				if(value == Modifiedonbehalfbyname) return;
				SetAttributeValue("modifiedonbehalfbyname", value);
			}
		}	
			
		/// <summary>
        /// modifiedonbehalfbyyominame
        /// </summary>
		[DisplayName("modifiedonbehalfbyyominame")]
		[AttributeLogicalName("modifiedonbehalfbyyominame")]
		public string Modifiedonbehalfbyyominame
		{	
			get { return GetAttributeValue<string>("modifiedonbehalfbyyominame"); }
			set
			{ 
				if(value == Modifiedonbehalfbyyominame) return;
				SetAttributeValue("modifiedonbehalfbyyominame", value);
			}
		}	
			
		/// <summary>
        /// name
        /// </summary>
		[DisplayName("Name")]
		[AttributeLogicalName("name")]
		public string Name
		{	
			get { return GetAttributeValue<string>("name"); }
			set
			{ 
				if(value == Name) return;
				SetAttributeValue("name", value);
			}
		}	
			
		/// <summary>
        /// originalbodytext
        /// </summary>
		[DisplayName("Body Text")]
		[AttributeLogicalName("originalbodytext")]
		public string BodyText2
		{	
			get { return GetAttributeValue<string>("originalbodytext"); }
			set
			{ 
				if(value == BodyText2) return;
				SetAttributeValue("originalbodytext", value);
			}
		}	
			
		/// <summary>
        /// overwritetime
        /// </summary>
		[DisplayName("Record Overwrite Time")]
		[AttributeLogicalName("overwritetime")]
		public DateTime? RecordOverwriteTime
		{	
			get { return GetAttributeValue<DateTime?>("overwritetime"); }
			set
			{ 
				if(value == RecordOverwriteTime) return;
				SetAttributeValue("overwritetime", value);
			}
		}	
			
		/// <summary>
        /// ownerid
        /// </summary>
		[DisplayName("Owner")]
		[AttributeLogicalName("ownerid")]
		public EntityReference Owner
		{	
			get { return GetAttributeValue<EntityReference>("ownerid"); }
			set
			{ 
				if(value == Owner) return;
				SetAttributeValue("ownerid", value);
			}
		}	
			
		/// <summary>
        /// owneridname
        /// </summary>
		[DisplayName("owneridname")]
		[AttributeLogicalName("owneridname")]
		public string Owneridname
		{	
			get { return GetAttributeValue<string>("owneridname"); }
			set
			{ 
				if(value == Owneridname) return;
				SetAttributeValue("owneridname", value);
			}
		}	
			
		/// <summary>
        /// owneridtype
        /// </summary>
		[DisplayName("owneridtype")]
		[AttributeLogicalName("owneridtype")]
		public string Owneridtype
		{	
			get { return GetAttributeValue<string>("owneridtype"); }
			set
			{ 
				if(value == Owneridtype) return;
				SetAttributeValue("owneridtype", value);
			}
		}	
			
		/// <summary>
        /// owneridyominame
        /// </summary>
		[DisplayName("owneridyominame")]
		[AttributeLogicalName("owneridyominame")]
		public string Owneridyominame
		{	
			get { return GetAttributeValue<string>("owneridyominame"); }
			set
			{ 
				if(value == Owneridyominame) return;
				SetAttributeValue("owneridyominame", value);
			}
		}	
			
		/// <summary>
        /// owningbusinessunit
        /// </summary>
		[DisplayName("Owning Business Unit")]
		[AttributeLogicalName("owningbusinessunit")]
		public EntityReference OwningBusinessUnit
		{	
			get { return GetAttributeValue<EntityReference>("owningbusinessunit"); }
			set
			{ 
				if(value == OwningBusinessUnit) return;
				SetAttributeValue("owningbusinessunit", value);
			}
		}	
			
		/// <summary>
        /// owningteam
        /// </summary>
		[DisplayName("Owning Team")]
		[AttributeLogicalName("owningteam")]
		public EntityReference OwningTeam
		{	
			get { return GetAttributeValue<EntityReference>("owningteam"); }
			set
			{ 
				if(value == OwningTeam) return;
				SetAttributeValue("owningteam", value);
			}
		}	
			
		/// <summary>
        /// owninguser
        /// </summary>
		[DisplayName("Owning User")]
		[AttributeLogicalName("owninguser")]
		public EntityReference OwningUser
		{	
			get { return GetAttributeValue<EntityReference>("owninguser"); }
			set
			{ 
				if(value == OwningUser) return;
				SetAttributeValue("owninguser", value);
			}
		}	
			
		/// <summary>
        /// parentreportid
        /// </summary>
		[DisplayName("Parent Report")]
		[AttributeLogicalName("parentreportid")]
		public EntityReference ParentReport
		{	
			get { return GetAttributeValue<EntityReference>("parentreportid"); }
			set
			{ 
				if(value == ParentReport) return;
				SetAttributeValue("parentreportid", value);
			}
		}	
			
		/// <summary>
        /// parentreportidname
        /// </summary>
		[DisplayName("parentreportidname")]
		[AttributeLogicalName("parentreportidname")]
		public string Parentreportidname
		{	
			get { return GetAttributeValue<string>("parentreportidname"); }
			set
			{ 
				if(value == Parentreportidname) return;
				SetAttributeValue("parentreportidname", value);
			}
		}	
			
		/// <summary>
        /// queryinfo
        /// </summary>
		[DisplayName("Query Info Structure")]
		[AttributeLogicalName("queryinfo")]
		public string QueryInfoStructure
		{	
			get { return GetAttributeValue<string>("queryinfo"); }
			set
			{ 
				if(value == QueryInfoStructure) return;
				SetAttributeValue("queryinfo", value);
			}
		}	
			
		/// <summary>
        /// rdlhash
        /// </summary>
		[DisplayName("Body Text Hash")]
		[AttributeLogicalName("rdlhash")]
		public int? BodyTextHash
		{	
			get { return GetAttributeValue<int?>("rdlhash"); }
			set
			{ 
				if(value == BodyTextHash) return;
				SetAttributeValue("rdlhash", value);
			}
		}	
			
		/// <summary>
        /// reportid
        /// </summary>
		[DisplayName("Report")]
		[AttributeLogicalName("reportid")]
		public override Guid Id
		{
			get => base.Id;
			set { base.Id = value; SetAttributeValue("reportid", value); }
		}

							/// <summary>
        /// reportidunique
        /// </summary>
		[DisplayName("Report")]
		[AttributeLogicalName("reportidunique")]
		public Guid ReportId2
		{	
			get { return GetAttributeValue<Guid>("reportidunique"); }
			set
			{ 
				if(value == ReportId2) return;
				SetAttributeValue("reportidunique", value);
			}
		}	
			
		/// <summary>
        /// reportnameonsrs
        /// </summary>
		[DisplayName("Name on SRS")]
		[AttributeLogicalName("reportnameonsrs")]
		public string NameOnSRS
		{	
			get { return GetAttributeValue<string>("reportnameonsrs"); }
			set
			{ 
				if(value == NameOnSRS) return;
				SetAttributeValue("reportnameonsrs", value);
			}
		}	
			
		/// <summary>
        /// reporttypecode
        /// </summary>
		[DisplayName("Report Type")]
		[AttributeLogicalName("reporttypecode")]
		public eReportType? ReportType
		{	
			get 
			{ 
				var optionSetValue = GetAttributeValue<OptionSetValue>("reporttypecode");
				if (optionSetValue != null) return (eReportType)optionSetValue.Value;
				else return null;
			}
			set 
			{ 
				if(value == ReportType) return;

				OptionSetValue optionSetValue = null;
				if(value != null) optionSetValue = new OptionSetValue((int)value);
				SetAttributeValue("reporttypecode", optionSetValue); 
			}
		}

		/// <summary>
        /// schedulexml
        /// </summary>
		[DisplayName("Schedule Definition XML")]
		[AttributeLogicalName("schedulexml")]
		public string ScheduleDefinitionXML
		{	
			get { return GetAttributeValue<string>("schedulexml"); }
			set
			{ 
				if(value == ScheduleDefinitionXML) return;
				SetAttributeValue("schedulexml", value);
			}
		}	
			
		/// <summary>
        /// signaturedate
        /// </summary>
		[DisplayName("Report Signature Date")]
		[AttributeLogicalName("signaturedate")]
		public DateTime? ReportSignatureDate
		{	
			get { return GetAttributeValue<DateTime?>("signaturedate"); }
			set
			{ 
				if(value == ReportSignatureDate) return;
				SetAttributeValue("signaturedate", value);
			}
		}	
			
		/// <summary>
        /// signatureid
        /// </summary>
		[DisplayName("Signature")]
		[AttributeLogicalName("signatureid")]
		public Guid SignatureId
		{	
			get { return GetAttributeValue<Guid>("signatureid"); }
			set
			{ 
				if(value == SignatureId) return;
				SetAttributeValue("signatureid", value);
			}
		}	
			
		/// <summary>
        /// signaturelcid
        /// </summary>
		[DisplayName("Signature Language Code")]
		[AttributeLogicalName("signaturelcid")]
		public int? SignatureLanguageCode
		{	
			get { return GetAttributeValue<int?>("signaturelcid"); }
			set
			{ 
				if(value == SignatureLanguageCode) return;
				SetAttributeValue("signaturelcid", value);
			}
		}	
			
		/// <summary>
        /// signaturemajorversion
        /// </summary>
		[DisplayName("Report Signature Major Version")]
		[AttributeLogicalName("signaturemajorversion")]
		public int? ReportSignatureMajorVersion
		{	
			get { return GetAttributeValue<int?>("signaturemajorversion"); }
			set
			{ 
				if(value == ReportSignatureMajorVersion) return;
				SetAttributeValue("signaturemajorversion", value);
			}
		}	
			
		/// <summary>
        /// signatureminorversion
        /// </summary>
		[DisplayName("Report Signature Minor Version")]
		[AttributeLogicalName("signatureminorversion")]
		public int? ReportSignatureMinorVersion
		{	
			get { return GetAttributeValue<int?>("signatureminorversion"); }
			set
			{ 
				if(value == ReportSignatureMinorVersion) return;
				SetAttributeValue("signatureminorversion", value);
			}
		}	
			
		/// <summary>
        /// solutionid
        /// </summary>
		[DisplayName("Solution")]
		[AttributeLogicalName("solutionid")]
		public Guid SolutionId
		{	
			get { return GetAttributeValue<Guid>("solutionid"); }
			set
			{ 
				if(value == SolutionId) return;
				SetAttributeValue("solutionid", value);
			}
		}	
			
		/// <summary>
        /// supportingsolutionid
        /// </summary>
		[DisplayName("Solution")]
		[AttributeLogicalName("supportingsolutionid")]
		public Guid SolutionId2
		{	
			get { return GetAttributeValue<Guid>("supportingsolutionid"); }
			set
			{ 
				if(value == SolutionId2) return;
				SetAttributeValue("supportingsolutionid", value);
			}
		}	
			
		/// <summary>
        /// timezoneruleversionnumber
        /// </summary>
		[DisplayName("Time Zone Rule Version Number")]
		[AttributeLogicalName("timezoneruleversionnumber")]
		public int? TimeZoneRuleVersionNumber
		{	
			get { return GetAttributeValue<int?>("timezoneruleversionnumber"); }
			set
			{ 
				if(value == TimeZoneRuleVersionNumber) return;
				SetAttributeValue("timezoneruleversionnumber", value);
			}
		}	
			
		/// <summary>
        /// utcconversiontimezonecode
        /// </summary>
		[DisplayName("UTC Conversion Time Zone Code")]
		[AttributeLogicalName("utcconversiontimezonecode")]
		public int? UTCConversionTimeZoneCode
		{	
			get { return GetAttributeValue<int?>("utcconversiontimezonecode"); }
			set
			{ 
				if(value == UTCConversionTimeZoneCode) return;
				SetAttributeValue("utcconversiontimezonecode", value);
			}
		}	
			
		/// <summary>
        /// versionnumber
        /// </summary>
		[DisplayName("Version Number")]
		[AttributeLogicalName("versionnumber")]
		public int? VersionNumber
		{	
			get { return GetAttributeValue<int?>("versionnumber"); }
			set
			{ 
				if(value == VersionNumber) return;
				SetAttributeValue("versionnumber", value);
			}
		}	
			
		#endregion	

		#region Relations
			/// <summary>
        /// 1:N Get entities for 'Report_AsyncOperations'
        /// </summary>
		[RelationshipSchemaName("Report_AsyncOperations")]
		public IEnumerable<SystemJob> ReportAsyncOperations
		{
			get { return GetRelatedEntities<SystemJob>("Report_AsyncOperations", null); }
			set { SetRelatedEntities("Report_AsyncOperations", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'report_parent_report'
        /// </summary>
		[RelationshipSchemaName("report_parent_report")]
		public IEnumerable<Report> ReportParentReport
		{
			get { return GetRelatedEntities<Report>("report_parent_report", null); }
			set { SetRelatedEntities("report_parent_report", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'Report_ProcessSessions'
        /// </summary>
		[RelationshipSchemaName("Report_ProcessSessions")]
		public IEnumerable<ProcessSession> ReportProcessSessions
		{
			get { return GetRelatedEntities<ProcessSession>("Report_ProcessSessions", null); }
			set { SetRelatedEntities("Report_ProcessSessions", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'report_reportcategories'
        /// </summary>
		[RelationshipSchemaName("report_reportcategories")]
		public IEnumerable<ReportRelatedCategory> ReportReportcategories
		{
			get { return GetRelatedEntities<ReportRelatedCategory>("report_reportcategories", null); }
			set { SetRelatedEntities("report_reportcategories", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'Report_SyncErrors'
        /// </summary>
		[RelationshipSchemaName("Report_SyncErrors")]
		public IEnumerable<SyncError> ReportSyncErrors
		{
			get { return GetRelatedEntities<SyncError>("Report_SyncErrors", null); }
			set { SetRelatedEntities("Report_SyncErrors", null, value); }
		}
		#endregion

		#region Actions
		#endregion

		#region OptionSetEnums
		public enum egComponentState
		{	
		
			[Label("Published")]
			[Description(@"")]
			Published = 0, 
		
			[Label("Unpublished")]
			[Description(@"")]
			Unpublished = 1, 
		
			[Label("Deleted")]
			[Description(@"")]
			Deleted = 2, 
		
			[Label("Deleted Unpublished")]
			[Description(@"")]
			DeletedUnpublished = 3, 
		}
		
		public enum eReportType
		{	
		
			[Label("Reporting Services Report")]
			[Description(@"")]
			ReportingServicesReport = 1, 
		
			[Label("Other Report")]
			[Description(@"")]
			OtherReport = 2, 
		
			[Label("Linked Report")]
			[Description(@"")]
			LinkedReport = 3, 
		}
		
		#endregion	

		#region Properties
		public static class Properties 
		{
			/// <summary>bodybinary</summary>
			public const string BodyBinary = "bodybinary";

			/// <summary>bodytext</summary>
			public const string BodyText = "bodytext";

			/// <summary>bodyurl</summary>
			public const string LinkedReportURL = "bodyurl";

			/// <summary>componentstate</summary>
			public const string ComponentState = "componentstate";

			/// <summary>createdby</summary>
			public const string CreatedBy = "createdby";

			/// <summary>createdbyname</summary>
			public const string Createdbyname = "createdbyname";

			/// <summary>createdbyyominame</summary>
			public const string Createdbyyominame = "createdbyyominame";

			/// <summary>createdinmajorversion</summary>
			public const string CrmVersionInWhichTheReportIsCreated = "createdinmajorversion";

			/// <summary>createdon</summary>
			public const string CreatedOn = "createdon";

			/// <summary>createdonbehalfby</summary>
			public const string CreatedByDelegate = "createdonbehalfby";

			/// <summary>createdonbehalfbyname</summary>
			public const string Createdonbehalfbyname = "createdonbehalfbyname";

			/// <summary>createdonbehalfbyyominame</summary>
			public const string Createdonbehalfbyyominame = "createdonbehalfbyyominame";

			/// <summary>customreportxml</summary>
			public const string CustomReportXML = "customreportxml";

			/// <summary>defaultfilter</summary>
			public const string DefaultFilter = "defaultfilter";

			/// <summary>description</summary>
			public const string Description = "description";

			/// <summary>filename</summary>
			public const string FileName = "filename";

			/// <summary>filesize</summary>
			public const string FileSizeBytes = "filesize";

			/// <summary>introducedversion</summary>
			public const string IntroducedVersion = "introducedversion";

			/// <summary>iscustomreport</summary>
			public const string IsCustomReport = "iscustomreport";

			/// <summary>ismanaged</summary>
			public const string IsManaged = "ismanaged";

			/// <summary>ispersonal</summary>
			public const string ViewableBy = "ispersonal";

			/// <summary>isscheduledreport</summary>
			public const string IsScheduledReport = "isscheduledreport";

			/// <summary>languagecode</summary>
			public const string Language = "languagecode";

			/// <summary>mimetype</summary>
			public const string MimeType = "mimetype";

			/// <summary>modifiedby</summary>
			public const string ModifiedBy = "modifiedby";

			/// <summary>modifiedbyname</summary>
			public const string Modifiedbyname = "modifiedbyname";

			/// <summary>modifiedbyyominame</summary>
			public const string Modifiedbyyominame = "modifiedbyyominame";

			/// <summary>modifiedon</summary>
			public const string ModifiedOn = "modifiedon";

			/// <summary>modifiedonbehalfby</summary>
			public const string ModifiedByDelegate = "modifiedonbehalfby";

			/// <summary>modifiedonbehalfbyname</summary>
			public const string Modifiedonbehalfbyname = "modifiedonbehalfbyname";

			/// <summary>modifiedonbehalfbyyominame</summary>
			public const string Modifiedonbehalfbyyominame = "modifiedonbehalfbyyominame";

			/// <summary>name</summary>
			public const string Name = "name";

			/// <summary>originalbodytext</summary>
			public const string BodyText2 = "originalbodytext";

			/// <summary>overwritetime</summary>
			public const string RecordOverwriteTime = "overwritetime";

			/// <summary>ownerid</summary>
			public const string Owner = "ownerid";

			/// <summary>owneridname</summary>
			public const string Owneridname = "owneridname";

			/// <summary>owneridtype</summary>
			public const string Owneridtype = "owneridtype";

			/// <summary>owneridyominame</summary>
			public const string Owneridyominame = "owneridyominame";

			/// <summary>owningbusinessunit</summary>
			public const string OwningBusinessUnit = "owningbusinessunit";

			/// <summary>owningteam</summary>
			public const string OwningTeam = "owningteam";

			/// <summary>owninguser</summary>
			public const string OwningUser = "owninguser";

			/// <summary>parentreportid</summary>
			public const string ParentReport = "parentreportid";

			/// <summary>parentreportidname</summary>
			public const string Parentreportidname = "parentreportidname";

			/// <summary>queryinfo</summary>
			public const string QueryInfoStructure = "queryinfo";

			/// <summary>rdlhash</summary>
			public const string BodyTextHash = "rdlhash";

			/// <summary>reportid</summary>
			public const string ReportId = "reportid";

			/// <summary>reportidunique</summary>
			public const string ReportId2 = "reportidunique";

			/// <summary>reportnameonsrs</summary>
			public const string NameOnSRS = "reportnameonsrs";

			/// <summary>reporttypecode</summary>
			public const string ReportType = "reporttypecode";

			/// <summary>schedulexml</summary>
			public const string ScheduleDefinitionXML = "schedulexml";

			/// <summary>signaturedate</summary>
			public const string ReportSignatureDate = "signaturedate";

			/// <summary>signatureid</summary>
			public const string SignatureId = "signatureid";

			/// <summary>signaturelcid</summary>
			public const string SignatureLanguageCode = "signaturelcid";

			/// <summary>signaturemajorversion</summary>
			public const string ReportSignatureMajorVersion = "signaturemajorversion";

			/// <summary>signatureminorversion</summary>
			public const string ReportSignatureMinorVersion = "signatureminorversion";

			/// <summary>solutionid</summary>
			public const string SolutionId = "solutionid";

			/// <summary>supportingsolutionid</summary>
			public const string SolutionId2 = "supportingsolutionid";

			/// <summary>timezoneruleversionnumber</summary>
			public const string TimeZoneRuleVersionNumber = "timezoneruleversionnumber";

			/// <summary>utcconversiontimezonecode</summary>
			public const string UTCConversionTimeZoneCode = "utcconversiontimezonecode";

			/// <summary>versionnumber</summary>
			public const string VersionNumber = "versionnumber";

		}
		#endregion

		#region Schemas
		public static class Schemas 
		{
			/// <summary>1:N Report_AsyncOperations</summary>
			public const string ReportAsyncOperations = "Report_AsyncOperations";

			/// <summary>1:N report_parent_report</summary>
			public const string ReportParentReport = "report_parent_report";

			/// <summary>1:N Report_ProcessSessions</summary>
			public const string ReportProcessSessions = "Report_ProcessSessions";

			/// <summary>1:N report_reportcategories</summary>
			public const string ReportReportcategories = "report_reportcategories";

			/// <summary>1:N Report_SyncErrors</summary>
			public const string ReportSyncErrors = "Report_SyncErrors";

		}
		#endregion
	}
}

