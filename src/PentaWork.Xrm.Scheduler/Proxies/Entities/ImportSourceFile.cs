using System;
using System.Linq;
using System.Diagnostics;
using System.ComponentModel;
using Microsoft.Xrm.Sdk; 
using Microsoft.Xrm.Sdk.Client;
using System.Collections.Generic;

namespace PentaWork.Xrm.Scheduler.Proxies.Entities
{
	[DebuggerDisplay("{ImportName}")] 	
	[EntityLogicalName("importfile")]
	public sealed class ImportSourceFile : Entity
	{	
		public static readonly int? EntityTypeCode = 4412;
		public new const string LogicalName = "importfile";
		public const string PrimaryIdAttribute = "importfileid";
		public const string PrimaryNameAttribute = "name";
	
		public ImportSourceFile() : base("importfile") { }

		#region Attributes
		/// <summary>
        /// additionalheaderrow
        /// </summary>
		[DisplayName("Additional Header")]
		[AttributeLogicalName("additionalheaderrow")]
		public string AdditionalHeader
		{	
			get { return GetAttributeValue<string>("additionalheaderrow"); }
			set
			{ 
				if(value == AdditionalHeader) return;
				SetAttributeValue("additionalheaderrow", value);
			}
		}	
			
		/// <summary>
        /// completedon
        /// </summary>
		[DisplayName("Completed On")]
		[AttributeLogicalName("completedon")]
		public DateTime? CompletedOn
		{	
			get { return GetAttributeValue<DateTime?>("completedon"); }
			set
			{ 
				if(value == CompletedOn) return;
				SetAttributeValue("completedon", value);
			}
		}	
			
		/// <summary>
        /// content
        /// </summary>
		[DisplayName("content")]
		[AttributeLogicalName("content")]
		public string Content
		{	
			get { return GetAttributeValue<string>("content"); }
			set
			{ 
				if(value == Content) return;
				SetAttributeValue("content", value);
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
        /// datadelimitercode
        /// </summary>
		[DisplayName("Data Delimiter")]
		[AttributeLogicalName("datadelimitercode")]
		public eDataDelimiter? DataDelimiter
		{	
			get 
			{ 
				var optionSetValue = GetAttributeValue<OptionSetValue>("datadelimitercode");
				if (optionSetValue != null) return (eDataDelimiter)optionSetValue.Value;
				else return null;
			}
			set 
			{ 
				if(value == DataDelimiter) return;

				OptionSetValue optionSetValue = null;
				if(value != null) optionSetValue = new OptionSetValue((int)value);
				SetAttributeValue("datadelimitercode", optionSetValue); 
			}
		}

		/// <summary>
        /// enableduplicatedetection
        /// </summary>
		[DisplayName("Enable Duplicate Detection")]
		[AttributeLogicalName("enableduplicatedetection")]
		public bool? EnableDuplicateDetection
		{	
			get { return GetAttributeValue<bool?>("enableduplicatedetection"); }
			set
			{ 
				if(value == EnableDuplicateDetection) return;
				SetAttributeValue("enableduplicatedetection", value);
			}
		}	
			
		/// <summary>
        /// entitykeyid
        /// </summary>
		[DisplayName("Entity Key ID")]
		[AttributeLogicalName("entitykeyid")]
		public Guid EntityKeyId
		{	
			get { return GetAttributeValue<Guid>("entitykeyid"); }
			set
			{ 
				if(value == EntityKeyId) return;
				SetAttributeValue("entitykeyid", value);
			}
		}	
			
		/// <summary>
        /// failurecount
        /// </summary>
		[DisplayName("Errors")]
		[AttributeLogicalName("failurecount")]
		public int? Errors
		{	
			get { return GetAttributeValue<int?>("failurecount"); }
			set
			{ 
				if(value == Errors) return;
				SetAttributeValue("failurecount", value);
			}
		}	
			
		/// <summary>
        /// fielddelimitercode
        /// </summary>
		[DisplayName("Field Delimiter")]
		[AttributeLogicalName("fielddelimitercode")]
		public eFieldDelimiter? FieldDelimiter
		{	
			get 
			{ 
				var optionSetValue = GetAttributeValue<OptionSetValue>("fielddelimitercode");
				if (optionSetValue != null) return (eFieldDelimiter)optionSetValue.Value;
				else return null;
			}
			set 
			{ 
				if(value == FieldDelimiter) return;

				OptionSetValue optionSetValue = null;
				if(value != null) optionSetValue = new OptionSetValue((int)value);
				SetAttributeValue("fielddelimitercode", optionSetValue); 
			}
		}

		/// <summary>
        /// filetypecode
        /// </summary>
		[DisplayName("File Type")]
		[AttributeLogicalName("filetypecode")]
		public eFileType? FileType
		{	
			get 
			{ 
				var optionSetValue = GetAttributeValue<OptionSetValue>("filetypecode");
				if (optionSetValue != null) return (eFileType)optionSetValue.Value;
				else return null;
			}
			set 
			{ 
				if(value == FileType) return;

				OptionSetValue optionSetValue = null;
				if(value != null) optionSetValue = new OptionSetValue((int)value);
				SetAttributeValue("filetypecode", optionSetValue); 
			}
		}

		/// <summary>
        /// headerrow
        /// </summary>
		[DisplayName("Header")]
		[AttributeLogicalName("headerrow")]
		public string Header
		{	
			get { return GetAttributeValue<string>("headerrow"); }
			set
			{ 
				if(value == Header) return;
				SetAttributeValue("headerrow", value);
			}
		}	
			
		/// <summary>
        /// importfileid
        /// </summary>
		[DisplayName("Import")]
		[AttributeLogicalName("importfileid")]
		public override Guid Id
		{
			get => base.Id;
			set { base.Id = value; SetAttributeValue("importfileid", value); }
		}

							/// <summary>
        /// importid
        /// </summary>
		[DisplayName("Import Job ID")]
		[AttributeLogicalName("importid")]
		public EntityReference ImportJobID
		{	
			get { return GetAttributeValue<EntityReference>("importid"); }
			set
			{ 
				if(value == ImportJobID) return;
				SetAttributeValue("importid", value);
			}
		}	
			
		/// <summary>
        /// importidname
        /// </summary>
		[DisplayName("importidname")]
		[AttributeLogicalName("importidname")]
		public string Importidname
		{	
			get { return GetAttributeValue<string>("importidname"); }
			set
			{ 
				if(value == Importidname) return;
				SetAttributeValue("importidname", value);
			}
		}	
			
		/// <summary>
        /// importmapid
        /// </summary>
		[DisplayName("Data Map")]
		[AttributeLogicalName("importmapid")]
		public EntityReference DataMap
		{	
			get { return GetAttributeValue<EntityReference>("importmapid"); }
			set
			{ 
				if(value == DataMap) return;
				SetAttributeValue("importmapid", value);
			}
		}	
			
		/// <summary>
        /// importmapidname
        /// </summary>
		[DisplayName("importmapidname")]
		[AttributeLogicalName("importmapidname")]
		public string Importmapidname
		{	
			get { return GetAttributeValue<string>("importmapidname"); }
			set
			{ 
				if(value == Importmapidname) return;
				SetAttributeValue("importmapidname", value);
			}
		}	
			
		/// <summary>
        /// isfirstrowheader
        /// </summary>
		[DisplayName("Is First Row Header")]
		[AttributeLogicalName("isfirstrowheader")]
		public bool? IsFirstRowHeader
		{	
			get { return GetAttributeValue<bool?>("isfirstrowheader"); }
			set
			{ 
				if(value == IsFirstRowHeader) return;
				SetAttributeValue("isfirstrowheader", value);
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
		[DisplayName("Import Name")]
		[AttributeLogicalName("name")]
		public string ImportName
		{	
			get { return GetAttributeValue<string>("name"); }
			set
			{ 
				if(value == ImportName) return;
				SetAttributeValue("name", value);
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
		[DisplayName("owningbusinessunit")]
		[AttributeLogicalName("owningbusinessunit")]
		public EntityReference Owningbusinessunit
		{	
			get { return GetAttributeValue<EntityReference>("owningbusinessunit"); }
			set
			{ 
				if(value == Owningbusinessunit) return;
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
        /// parsedtablecolumnprefix
        /// </summary>
		[DisplayName("Parse Table Column Prefix")]
		[AttributeLogicalName("parsedtablecolumnprefix")]
		public string ParseTableColumnPrefix
		{	
			get { return GetAttributeValue<string>("parsedtablecolumnprefix"); }
			set
			{ 
				if(value == ParseTableColumnPrefix) return;
				SetAttributeValue("parsedtablecolumnprefix", value);
			}
		}	
			
		/// <summary>
        /// parsedtablecolumnsnumber
        /// </summary>
		[DisplayName("Parse Table Column Number")]
		[AttributeLogicalName("parsedtablecolumnsnumber")]
		public int? ParseTableColumnNumber
		{	
			get { return GetAttributeValue<int?>("parsedtablecolumnsnumber"); }
			set
			{ 
				if(value == ParseTableColumnNumber) return;
				SetAttributeValue("parsedtablecolumnsnumber", value);
			}
		}	
			
		/// <summary>
        /// parsedtablename
        /// </summary>
		[DisplayName("Parse Table")]
		[AttributeLogicalName("parsedtablename")]
		public string ParseTable
		{	
			get { return GetAttributeValue<string>("parsedtablename"); }
			set
			{ 
				if(value == ParseTable) return;
				SetAttributeValue("parsedtablename", value);
			}
		}	
			
		/// <summary>
        /// partialfailurecount
        /// </summary>
		[DisplayName("Partial Failures")]
		[AttributeLogicalName("partialfailurecount")]
		public int? PartialFailures
		{	
			get { return GetAttributeValue<int?>("partialfailurecount"); }
			set
			{ 
				if(value == PartialFailures) return;
				SetAttributeValue("partialfailurecount", value);
			}
		}	
			
		/// <summary>
        /// processcode
        /// </summary>
		[DisplayName("Process Code")]
		[AttributeLogicalName("processcode")]
		public eProcessCode? ProcessCode
		{	
			get 
			{ 
				var optionSetValue = GetAttributeValue<OptionSetValue>("processcode");
				if (optionSetValue != null) return (eProcessCode)optionSetValue.Value;
				else return null;
			}
			set 
			{ 
				if(value == ProcessCode) return;

				OptionSetValue optionSetValue = null;
				if(value != null) optionSetValue = new OptionSetValue((int)value);
				SetAttributeValue("processcode", optionSetValue); 
			}
		}

		/// <summary>
        /// processingstatus
        /// </summary>
		[DisplayName("Processing Status")]
		[AttributeLogicalName("processingstatus")]
		public eProcessingStatus? ProcessingStatus
		{	
			get 
			{ 
				var optionSetValue = GetAttributeValue<OptionSetValue>("processingstatus");
				if (optionSetValue != null) return (eProcessingStatus)optionSetValue.Value;
				else return null;
			}
			set 
			{ 
				if(value == ProcessingStatus) return;

				OptionSetValue optionSetValue = null;
				if(value != null) optionSetValue = new OptionSetValue((int)value);
				SetAttributeValue("processingstatus", optionSetValue); 
			}
		}

		/// <summary>
        /// progresscounter
        /// </summary>
		[DisplayName("Progress Counter")]
		[AttributeLogicalName("progresscounter")]
		public int? ProgressCounter
		{	
			get { return GetAttributeValue<int?>("progresscounter"); }
			set
			{ 
				if(value == ProgressCounter) return;
				SetAttributeValue("progresscounter", value);
			}
		}	
			
		/// <summary>
        /// recordsownerid
        /// </summary>
		[DisplayName("Records Owner")]
		[AttributeLogicalName("recordsownerid")]
		public EntityReference RecordsOwner
		{	
			get { return GetAttributeValue<EntityReference>("recordsownerid"); }
			set
			{ 
				if(value == RecordsOwner) return;
				SetAttributeValue("recordsownerid", value);
			}
		}	
			
		/// <summary>
        /// recordsowneridname
        /// </summary>
		[DisplayName("recordsowneridname")]
		[AttributeLogicalName("recordsowneridname")]
		public string Recordsowneridname
		{	
			get { return GetAttributeValue<string>("recordsowneridname"); }
			set
			{ 
				if(value == Recordsowneridname) return;
				SetAttributeValue("recordsowneridname", value);
			}
		}	
			
		/// <summary>
        /// recordsowneridtype
        /// </summary>
		[DisplayName("recordsowneridtype")]
		[AttributeLogicalName("recordsowneridtype")]
		public string Recordsowneridtype
		{	
			get { return GetAttributeValue<string>("recordsowneridtype"); }
			set
			{ 
				if(value == Recordsowneridtype) return;
				SetAttributeValue("recordsowneridtype", value);
			}
		}	
			
		/// <summary>
        /// relatedentitycolumns
        /// </summary>
		[DisplayName("relatedentitycolumns")]
		[AttributeLogicalName("relatedentitycolumns")]
		public string Relatedentitycolumns
		{	
			get { return GetAttributeValue<string>("relatedentitycolumns"); }
			set
			{ 
				if(value == Relatedentitycolumns) return;
				SetAttributeValue("relatedentitycolumns", value);
			}
		}	
			
		/// <summary>
        /// size
        /// </summary>
		[DisplayName("Size")]
		[AttributeLogicalName("size")]
		public string Size
		{	
			get { return GetAttributeValue<string>("size"); }
			set
			{ 
				if(value == Size) return;
				SetAttributeValue("size", value);
			}
		}	
			
		/// <summary>
        /// source
        /// </summary>
		[DisplayName("Source")]
		[AttributeLogicalName("source")]
		public string Source
		{	
			get { return GetAttributeValue<string>("source"); }
			set
			{ 
				if(value == Source) return;
				SetAttributeValue("source", value);
			}
		}	
			
		/// <summary>
        /// sourceentityname
        /// </summary>
		[DisplayName("Source Entity")]
		[AttributeLogicalName("sourceentityname")]
		public string SourceEntity
		{	
			get { return GetAttributeValue<string>("sourceentityname"); }
			set
			{ 
				if(value == SourceEntity) return;
				SetAttributeValue("sourceentityname", value);
			}
		}	
			
		/// <summary>
        /// statecode
        /// </summary>
		[DisplayName("Status")]
		[AttributeLogicalName("statecode")]
		public eStatus? Status
		{	
			get 
			{ 
				var optionSetValue = GetAttributeValue<OptionSetValue>("statecode");
				if (optionSetValue != null) return (eStatus)optionSetValue.Value;
				else return null;
			}
			set 
			{ 
				if(value == Status) return;

				OptionSetValue optionSetValue = null;
				if(value != null) optionSetValue = new OptionSetValue((int)value);
				SetAttributeValue("statecode", optionSetValue); 
			}
		}

		/// <summary>
        /// statuscode
        /// </summary>
		[DisplayName("Status Reason")]
		[AttributeLogicalName("statuscode")]
		public eStatusReason? StatusReason
		{	
			get 
			{ 
				var optionSetValue = GetAttributeValue<OptionSetValue>("statuscode");
				if (optionSetValue != null) return (eStatusReason)optionSetValue.Value;
				else return null;
			}
			set 
			{ 
				if(value == StatusReason) return;

				OptionSetValue optionSetValue = null;
				if(value != null) optionSetValue = new OptionSetValue((int)value);
				SetAttributeValue("statuscode", optionSetValue); 
			}
		}

		/// <summary>
        /// successcount
        /// </summary>
		[DisplayName("Successes")]
		[AttributeLogicalName("successcount")]
		public int? Successes
		{	
			get { return GetAttributeValue<int?>("successcount"); }
			set
			{ 
				if(value == Successes) return;
				SetAttributeValue("successcount", value);
			}
		}	
			
		/// <summary>
        /// targetentityname
        /// </summary>
		[DisplayName("Target Entity")]
		[AttributeLogicalName("targetentityname")]
		public string TargetEntity
		{	
			get { return GetAttributeValue<string>("targetentityname"); }
			set
			{ 
				if(value == TargetEntity) return;
				SetAttributeValue("targetentityname", value);
			}
		}	
			
		/// <summary>
        /// timezoneruleversionnumber
        /// </summary>
		[DisplayName("timezoneruleversionnumber")]
		[AttributeLogicalName("timezoneruleversionnumber")]
		public int? Timezoneruleversionnumber
		{	
			get { return GetAttributeValue<int?>("timezoneruleversionnumber"); }
			set
			{ 
				if(value == Timezoneruleversionnumber) return;
				SetAttributeValue("timezoneruleversionnumber", value);
			}
		}	
			
		/// <summary>
        /// totalcount
        /// </summary>
		[DisplayName("Total Processed")]
		[AttributeLogicalName("totalcount")]
		public int? TotalProcessed
		{	
			get { return GetAttributeValue<int?>("totalcount"); }
			set
			{ 
				if(value == TotalProcessed) return;
				SetAttributeValue("totalcount", value);
			}
		}	
			
		/// <summary>
        /// upsertmodecode
        /// </summary>
		[DisplayName("Upsert Mode")]
		[AttributeLogicalName("upsertmodecode")]
		public eUpsertMode? UpsertMode
		{	
			get 
			{ 
				var optionSetValue = GetAttributeValue<OptionSetValue>("upsertmodecode");
				if (optionSetValue != null) return (eUpsertMode)optionSetValue.Value;
				else return null;
			}
			set 
			{ 
				if(value == UpsertMode) return;

				OptionSetValue optionSetValue = null;
				if(value != null) optionSetValue = new OptionSetValue((int)value);
				SetAttributeValue("upsertmodecode", optionSetValue); 
			}
		}

		/// <summary>
        /// usesystemmap
        /// </summary>
		[DisplayName("Use System Map")]
		[AttributeLogicalName("usesystemmap")]
		public bool? UseSystemMap
		{	
			get { return GetAttributeValue<bool?>("usesystemmap"); }
			set
			{ 
				if(value == UseSystemMap) return;
				SetAttributeValue("usesystemmap", value);
			}
		}	
			
		/// <summary>
        /// utcconversiontimezonecode
        /// </summary>
		[DisplayName("utcconversiontimezonecode")]
		[AttributeLogicalName("utcconversiontimezonecode")]
		public int? Utcconversiontimezonecode
		{	
			get { return GetAttributeValue<int?>("utcconversiontimezonecode"); }
			set
			{ 
				if(value == Utcconversiontimezonecode) return;
				SetAttributeValue("utcconversiontimezonecode", value);
			}
		}	
			
		#endregion	

		#region Relations
			/// <summary>
        /// 1:N Get entities for 'ImportFile_AsyncOperations'
        /// </summary>
		[RelationshipSchemaName("ImportFile_AsyncOperations")]
		public IEnumerable<SystemJob> ImportFileAsyncOperations
		{
			get { return GetRelatedEntities<SystemJob>("ImportFile_AsyncOperations", null); }
			set { SetRelatedEntities("ImportFile_AsyncOperations", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'ImportFile_BulkDeleteFailures'
        /// </summary>
		[RelationshipSchemaName("ImportFile_BulkDeleteFailures")]
		public IEnumerable<BulkDeleteFailure> ImportFileBulkDeleteFailures
		{
			get { return GetRelatedEntities<BulkDeleteFailure>("ImportFile_BulkDeleteFailures", null); }
			set { SetRelatedEntities("ImportFile_BulkDeleteFailures", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'ImportFile_ImportData'
        /// </summary>
		[RelationshipSchemaName("ImportFile_ImportData")]
		public IEnumerable<ImportData> ImportFileImportData
		{
			get { return GetRelatedEntities<ImportData>("ImportFile_ImportData", null); }
			set { SetRelatedEntities("ImportFile_ImportData", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'ImportLog_ImportFile'
        /// </summary>
		[RelationshipSchemaName("ImportLog_ImportFile")]
		public IEnumerable<ImportLog> ImportLogImportFile
		{
			get { return GetRelatedEntities<ImportLog>("ImportLog_ImportFile", null); }
			set { SetRelatedEntities("ImportLog_ImportFile", null, value); }
		}
		#endregion

		#region Actions
		#endregion

		#region OptionSetEnums
		public enum eDataDelimiter
		{	
		
			[Label("DoubleQuote")]
			[Description(@"")]
			DoubleQuote = 1, 
		
			[Label("None")]
			[Description(@"")]
			None = 2, 
		
			[Label("SingleQuote")]
			[Description(@"")]
			SingleQuote = 3, 
		}
		
		public enum eFieldDelimiter
		{	
		
			[Label("Colon")]
			[Description(@"")]
			Colon = 1, 
		
			[Label("Comma")]
			[Description(@"")]
			Comma = 2, 
		
			[Label("Tab")]
			[Description(@"")]
			Tab = 3, 
		
			[Label("Semicolon")]
			[Description(@"")]
			Semicolon = 4, 
		}
		
		public enum eFileType
		{	
		
			[Label("CSV")]
			[Description(@"")]
			CSV = 0, 
		
			[Label("XML Spreadsheet 2003")]
			[Description(@"")]
			XMLSpreadsheet2003 = 1, 
		
			[Label("Attachment")]
			[Description(@"")]
			Attachment = 2, 
		
			[Label("XLSX")]
			[Description(@"")]
			XLSX = 3, 
		}
		
		public enum eProcessCode
		{	
		
			[Label("Process")]
			[Description(@"")]
			Process = 1, 
		
			[Label("Ignore")]
			[Description(@"")]
			Ignore = 2, 
		
			[Label("Internal")]
			[Description(@"")]
			Internal = 3, 
		}
		
		public enum eProcessingStatus
		{	
		
			[Label("Not Started")]
			[Description(@"")]
			NotStarted = 1, 
		
			[Label("Parsing")]
			[Description(@"")]
			Parsing = 2, 
		
			[Label("Parsing Complete")]
			[Description(@"")]
			ParsingComplete = 3, 
		
			[Label("Complex Transformation")]
			[Description(@"")]
			ComplexTransformation = 4, 
		
			[Label("Lookup Transformation")]
			[Description(@"")]
			LookupTransformation = 5, 
		
			[Label("Picklist Transformation")]
			[Description(@"")]
			PicklistTransformation = 6, 
		
			[Label("Owner Transformation")]
			[Description(@"")]
			OwnerTransformation = 7, 
		
			[Label("Transformation Complete")]
			[Description(@"")]
			TransformationComplete = 8, 
		
			[Label("Import Pass 1")]
			[Description(@"")]
			ImportPass1 = 9, 
		
			[Label("Import Pass 2")]
			[Description(@"")]
			ImportPass2 = 10, 
		
			[Label("Import Complete")]
			[Description(@"")]
			ImportComplete = 11, 
		
			[Label("Primary Key Transformation")]
			[Description(@"")]
			PrimaryKeyTransformation = 12, 
		}
		
		public enum eStatus
		{	
		
			[Label("Active")]
			[Description(@"")]
			Active = 0, 
		}
		
		public enum eStatusReason
		{	
		
			[Label("Submitted")]
			[Description(@"")]
			Submitted_Active = 0, 
		
			[Label("Parsing")]
			[Description(@"")]
			Parsing_Active = 1, 
		
			[Label("Transforming")]
			[Description(@"")]
			Transforming_Active = 2, 
		
			[Label("Importing")]
			[Description(@"")]
			Importing_Active = 3, 
		
			[Label("Completed")]
			[Description(@"")]
			Completed_Active = 4, 
		
			[Label("Failed")]
			[Description(@"")]
			Failed_Active = 5, 
		}
		
		public enum eUpsertMode
		{	
		
			[Label("Create")]
			[Description(@"")]
			Create = 0, 
		
			[Label("Update")]
			[Description(@"")]
			Update = 1, 
		
			[Label("Ignore")]
			[Description(@"")]
			Ignore = 2, 
		}
		
		#endregion	

		#region Properties
		public static class Properties 
		{
			/// <summary>additionalheaderrow</summary>
			public const string AdditionalHeader = "additionalheaderrow";

			/// <summary>completedon</summary>
			public const string CompletedOn = "completedon";

			/// <summary>content</summary>
			public const string Content = "content";

			/// <summary>createdby</summary>
			public const string CreatedBy = "createdby";

			/// <summary>createdbyname</summary>
			public const string Createdbyname = "createdbyname";

			/// <summary>createdbyyominame</summary>
			public const string Createdbyyominame = "createdbyyominame";

			/// <summary>createdon</summary>
			public const string CreatedOn = "createdon";

			/// <summary>createdonbehalfby</summary>
			public const string CreatedByDelegate = "createdonbehalfby";

			/// <summary>createdonbehalfbyname</summary>
			public const string Createdonbehalfbyname = "createdonbehalfbyname";

			/// <summary>createdonbehalfbyyominame</summary>
			public const string Createdonbehalfbyyominame = "createdonbehalfbyyominame";

			/// <summary>datadelimitercode</summary>
			public const string DataDelimiter = "datadelimitercode";

			/// <summary>enableduplicatedetection</summary>
			public const string EnableDuplicateDetection = "enableduplicatedetection";

			/// <summary>entitykeyid</summary>
			public const string EntityKeyId = "entitykeyid";

			/// <summary>failurecount</summary>
			public const string Errors = "failurecount";

			/// <summary>fielddelimitercode</summary>
			public const string FieldDelimiter = "fielddelimitercode";

			/// <summary>filetypecode</summary>
			public const string FileType = "filetypecode";

			/// <summary>headerrow</summary>
			public const string Header = "headerrow";

			/// <summary>importfileid</summary>
			public const string ImportId = "importfileid";

			/// <summary>importid</summary>
			public const string ImportJobID = "importid";

			/// <summary>importidname</summary>
			public const string Importidname = "importidname";

			/// <summary>importmapid</summary>
			public const string DataMap = "importmapid";

			/// <summary>importmapidname</summary>
			public const string Importmapidname = "importmapidname";

			/// <summary>isfirstrowheader</summary>
			public const string IsFirstRowHeader = "isfirstrowheader";

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
			public const string ImportName = "name";

			/// <summary>ownerid</summary>
			public const string Owner = "ownerid";

			/// <summary>owneridname</summary>
			public const string Owneridname = "owneridname";

			/// <summary>owneridtype</summary>
			public const string Owneridtype = "owneridtype";

			/// <summary>owneridyominame</summary>
			public const string Owneridyominame = "owneridyominame";

			/// <summary>owningbusinessunit</summary>
			public const string Owningbusinessunit = "owningbusinessunit";

			/// <summary>owningteam</summary>
			public const string OwningTeam = "owningteam";

			/// <summary>owninguser</summary>
			public const string OwningUser = "owninguser";

			/// <summary>parsedtablecolumnprefix</summary>
			public const string ParseTableColumnPrefix = "parsedtablecolumnprefix";

			/// <summary>parsedtablecolumnsnumber</summary>
			public const string ParseTableColumnNumber = "parsedtablecolumnsnumber";

			/// <summary>parsedtablename</summary>
			public const string ParseTable = "parsedtablename";

			/// <summary>partialfailurecount</summary>
			public const string PartialFailures = "partialfailurecount";

			/// <summary>processcode</summary>
			public const string ProcessCode = "processcode";

			/// <summary>processingstatus</summary>
			public const string ProcessingStatus = "processingstatus";

			/// <summary>progresscounter</summary>
			public const string ProgressCounter = "progresscounter";

			/// <summary>recordsownerid</summary>
			public const string RecordsOwner = "recordsownerid";

			/// <summary>recordsowneridname</summary>
			public const string Recordsowneridname = "recordsowneridname";

			/// <summary>recordsowneridtype</summary>
			public const string Recordsowneridtype = "recordsowneridtype";

			/// <summary>relatedentitycolumns</summary>
			public const string Relatedentitycolumns = "relatedentitycolumns";

			/// <summary>size</summary>
			public const string Size = "size";

			/// <summary>source</summary>
			public const string Source = "source";

			/// <summary>sourceentityname</summary>
			public const string SourceEntity = "sourceentityname";

			/// <summary>statecode</summary>
			public const string Status = "statecode";

			/// <summary>statuscode</summary>
			public const string StatusReason = "statuscode";

			/// <summary>successcount</summary>
			public const string Successes = "successcount";

			/// <summary>targetentityname</summary>
			public const string TargetEntity = "targetentityname";

			/// <summary>timezoneruleversionnumber</summary>
			public const string Timezoneruleversionnumber = "timezoneruleversionnumber";

			/// <summary>totalcount</summary>
			public const string TotalProcessed = "totalcount";

			/// <summary>upsertmodecode</summary>
			public const string UpsertMode = "upsertmodecode";

			/// <summary>usesystemmap</summary>
			public const string UseSystemMap = "usesystemmap";

			/// <summary>utcconversiontimezonecode</summary>
			public const string Utcconversiontimezonecode = "utcconversiontimezonecode";

		}
		#endregion

		#region Schemas
		public static class Schemas 
		{
			/// <summary>1:N ImportFile_AsyncOperations</summary>
			public const string ImportFileAsyncOperations = "ImportFile_AsyncOperations";

			/// <summary>1:N ImportFile_BulkDeleteFailures</summary>
			public const string ImportFileBulkDeleteFailures = "ImportFile_BulkDeleteFailures";

			/// <summary>1:N ImportFile_ImportData</summary>
			public const string ImportFileImportData = "ImportFile_ImportData";

			/// <summary>1:N ImportLog_ImportFile</summary>
			public const string ImportLogImportFile = "ImportLog_ImportFile";

		}
		#endregion
	}
}

