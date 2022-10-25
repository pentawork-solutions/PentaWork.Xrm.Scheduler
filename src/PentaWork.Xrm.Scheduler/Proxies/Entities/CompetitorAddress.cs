using System;
using System.Linq;
using System.Diagnostics;
using System.ComponentModel;
using Microsoft.Xrm.Sdk; 
using Microsoft.Xrm.Sdk.Client;
using System.Collections.Generic;

namespace PentaWork.Xrm.Scheduler.Proxies.Entities
{
	[DebuggerDisplay("{AddressName}")] 	
	[EntityLogicalName("competitoraddress")]
	public sealed class CompetitorAddress : Entity
	{	
		public static readonly int? EntityTypeCode = 1004;
		public new const string LogicalName = "competitoraddress";
		public const string PrimaryIdAttribute = "competitoraddressid";
		public const string PrimaryNameAttribute = "name";
	
		public CompetitorAddress() : base("competitoraddress") { }

		#region Attributes
		/// <summary>
        /// addressnumber
        /// </summary>
		[DisplayName("Address Number")]
		[AttributeLogicalName("addressnumber")]
		public int? AddressNumber
		{	
			get { return GetAttributeValue<int?>("addressnumber"); }
			set
			{ 
				if(value == AddressNumber) return;
				SetAttributeValue("addressnumber", value);
			}
		}	
			
		/// <summary>
        /// addresstypecode
        /// </summary>
		[DisplayName("Address Type")]
		[AttributeLogicalName("addresstypecode")]
		public eCompetitoraddressAddresstypecode? AddressType
		{	
			get 
			{ 
				var optionSetValue = GetAttributeValue<OptionSetValue>("addresstypecode");
				if (optionSetValue != null) return (eCompetitoraddressAddresstypecode)optionSetValue.Value;
				else return null;
			}
			set 
			{ 
				if(value == AddressType) return;

				OptionSetValue optionSetValue = null;
				if(value != null) optionSetValue = new OptionSetValue((int)value);
				SetAttributeValue("addresstypecode", optionSetValue); 
			}
		}

		/// <summary>
        /// city
        /// </summary>
		[DisplayName("City")]
		[AttributeLogicalName("city")]
		public string City
		{	
			get { return GetAttributeValue<string>("city"); }
			set
			{ 
				if(value == City) return;
				SetAttributeValue("city", value);
			}
		}	
			
		/// <summary>
        /// competitoraddressid
        /// </summary>
		[DisplayName("Competitor Address")]
		[AttributeLogicalName("competitoraddressid")]
		public override Guid Id
		{
			get => base.Id;
			set { base.Id = value; SetAttributeValue("competitoraddressid", value); }
		}

							/// <summary>
        /// composite
        /// </summary>
		[DisplayName("Address")]
		[AttributeLogicalName("composite")]
		public string Address
		{	
			get { return GetAttributeValue<string>("composite"); }
			set
			{ 
				if(value == Address) return;
				SetAttributeValue("composite", value);
			}
		}	
			
		/// <summary>
        /// country
        /// </summary>
		[DisplayName("Country/Region")]
		[AttributeLogicalName("country")]
		public string CountryRegion
		{	
			get { return GetAttributeValue<string>("country"); }
			set
			{ 
				if(value == CountryRegion) return;
				SetAttributeValue("country", value);
			}
		}	
			
		/// <summary>
        /// county
        /// </summary>
		[DisplayName("County")]
		[AttributeLogicalName("county")]
		public string County
		{	
			get { return GetAttributeValue<string>("county"); }
			set
			{ 
				if(value == County) return;
				SetAttributeValue("county", value);
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
        /// fax
        /// </summary>
		[DisplayName("Fax")]
		[AttributeLogicalName("fax")]
		public string Fax
		{	
			get { return GetAttributeValue<string>("fax"); }
			set
			{ 
				if(value == Fax) return;
				SetAttributeValue("fax", value);
			}
		}	
			
		/// <summary>
        /// importsequencenumber
        /// </summary>
		[DisplayName("Import Sequence Number")]
		[AttributeLogicalName("importsequencenumber")]
		public int? ImportSequenceNumber
		{	
			get { return GetAttributeValue<int?>("importsequencenumber"); }
			set
			{ 
				if(value == ImportSequenceNumber) return;
				SetAttributeValue("importsequencenumber", value);
			}
		}	
			
		/// <summary>
        /// latitude
        /// </summary>
		[DisplayName("Latitude")]
		[AttributeLogicalName("latitude")]
		public double? Latitude
		{	
			get { return GetAttributeValue<double?>("latitude"); }
			set
			{ 
				if(value == Latitude) return;
				SetAttributeValue("latitude", value);
			}
		}	
			
		/// <summary>
        /// line1
        /// </summary>
		[DisplayName("Street 1")]
		[AttributeLogicalName("line1")]
		public string Street1
		{	
			get { return GetAttributeValue<string>("line1"); }
			set
			{ 
				if(value == Street1) return;
				SetAttributeValue("line1", value);
			}
		}	
			
		/// <summary>
        /// line2
        /// </summary>
		[DisplayName("Street 2")]
		[AttributeLogicalName("line2")]
		public string Street2
		{	
			get { return GetAttributeValue<string>("line2"); }
			set
			{ 
				if(value == Street2) return;
				SetAttributeValue("line2", value);
			}
		}	
			
		/// <summary>
        /// line3
        /// </summary>
		[DisplayName("Street 3")]
		[AttributeLogicalName("line3")]
		public string Street3
		{	
			get { return GetAttributeValue<string>("line3"); }
			set
			{ 
				if(value == Street3) return;
				SetAttributeValue("line3", value);
			}
		}	
			
		/// <summary>
        /// longitude
        /// </summary>
		[DisplayName("Longitude")]
		[AttributeLogicalName("longitude")]
		public double? Longitude
		{	
			get { return GetAttributeValue<double?>("longitude"); }
			set
			{ 
				if(value == Longitude) return;
				SetAttributeValue("longitude", value);
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
		[DisplayName("Address Name")]
		[AttributeLogicalName("name")]
		public string AddressName
		{	
			get { return GetAttributeValue<string>("name"); }
			set
			{ 
				if(value == AddressName) return;
				SetAttributeValue("name", value);
			}
		}	
			
		/// <summary>
        /// overriddencreatedon
        /// </summary>
		[DisplayName("Record Created On")]
		[AttributeLogicalName("overriddencreatedon")]
		public DateTime? RecordCreatedOn
		{	
			get { return GetAttributeValue<DateTime?>("overriddencreatedon"); }
			set
			{ 
				if(value == RecordCreatedOn) return;
				SetAttributeValue("overriddencreatedon", value);
			}
		}	
			
		/// <summary>
        /// parentid
        /// </summary>
		[DisplayName("Parent")]
		[AttributeLogicalName("parentid")]
		public EntityReference Parent
		{	
			get { return GetAttributeValue<EntityReference>("parentid"); }
			set
			{ 
				if(value == Parent) return;
				SetAttributeValue("parentid", value);
			}
		}	
			
		/// <summary>
        /// parentidname
        /// </summary>
		[DisplayName("parentidname")]
		[AttributeLogicalName("parentidname")]
		public string Parentidname
		{	
			get { return GetAttributeValue<string>("parentidname"); }
			set
			{ 
				if(value == Parentidname) return;
				SetAttributeValue("parentidname", value);
			}
		}	
			
		/// <summary>
        /// parentidyominame
        /// </summary>
		[DisplayName("parentidyominame")]
		[AttributeLogicalName("parentidyominame")]
		public string Parentidyominame
		{	
			get { return GetAttributeValue<string>("parentidyominame"); }
			set
			{ 
				if(value == Parentidyominame) return;
				SetAttributeValue("parentidyominame", value);
			}
		}	
			
		/// <summary>
        /// postalcode
        /// </summary>
		[DisplayName("ZIP/Postal Code")]
		[AttributeLogicalName("postalcode")]
		public string ZIPPostalCode
		{	
			get { return GetAttributeValue<string>("postalcode"); }
			set
			{ 
				if(value == ZIPPostalCode) return;
				SetAttributeValue("postalcode", value);
			}
		}	
			
		/// <summary>
        /// postofficebox
        /// </summary>
		[DisplayName("Post Office Box")]
		[AttributeLogicalName("postofficebox")]
		public string PostOfficeBox
		{	
			get { return GetAttributeValue<string>("postofficebox"); }
			set
			{ 
				if(value == PostOfficeBox) return;
				SetAttributeValue("postofficebox", value);
			}
		}	
			
		/// <summary>
        /// shippingmethodcode
        /// </summary>
		[DisplayName("Shipping Method")]
		[AttributeLogicalName("shippingmethodcode")]
		public eCompetitoraddressShippingmethodcode? ShippingMethod
		{	
			get 
			{ 
				var optionSetValue = GetAttributeValue<OptionSetValue>("shippingmethodcode");
				if (optionSetValue != null) return (eCompetitoraddressShippingmethodcode)optionSetValue.Value;
				else return null;
			}
			set 
			{ 
				if(value == ShippingMethod) return;

				OptionSetValue optionSetValue = null;
				if(value != null) optionSetValue = new OptionSetValue((int)value);
				SetAttributeValue("shippingmethodcode", optionSetValue); 
			}
		}

		/// <summary>
        /// stateorprovince
        /// </summary>
		[DisplayName("State/Province")]
		[AttributeLogicalName("stateorprovince")]
		public string StateProvince
		{	
			get { return GetAttributeValue<string>("stateorprovince"); }
			set
			{ 
				if(value == StateProvince) return;
				SetAttributeValue("stateorprovince", value);
			}
		}	
			
		/// <summary>
        /// telephone1
        /// </summary>
		[DisplayName("Main Phone")]
		[AttributeLogicalName("telephone1")]
		public string MainPhone
		{	
			get { return GetAttributeValue<string>("telephone1"); }
			set
			{ 
				if(value == MainPhone) return;
				SetAttributeValue("telephone1", value);
			}
		}	
			
		/// <summary>
        /// telephone2
        /// </summary>
		[DisplayName("Phone 2")]
		[AttributeLogicalName("telephone2")]
		public string Phone2
		{	
			get { return GetAttributeValue<string>("telephone2"); }
			set
			{ 
				if(value == Phone2) return;
				SetAttributeValue("telephone2", value);
			}
		}	
			
		/// <summary>
        /// telephone3
        /// </summary>
		[DisplayName("Phone 3")]
		[AttributeLogicalName("telephone3")]
		public string Phone3
		{	
			get { return GetAttributeValue<string>("telephone3"); }
			set
			{ 
				if(value == Phone3) return;
				SetAttributeValue("telephone3", value);
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
        /// upszone
        /// </summary>
		[DisplayName("UPS Zone")]
		[AttributeLogicalName("upszone")]
		public string UPSZone
		{	
			get { return GetAttributeValue<string>("upszone"); }
			set
			{ 
				if(value == UPSZone) return;
				SetAttributeValue("upszone", value);
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
        /// utcoffset
        /// </summary>
		[DisplayName("UTC Offset")]
		[AttributeLogicalName("utcoffset")]
		public int? UTCOffset
		{	
			get { return GetAttributeValue<int?>("utcoffset"); }
			set
			{ 
				if(value == UTCOffset) return;
				SetAttributeValue("utcoffset", value);
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
        /// 1:N Get entities for 'competitoraddress_AsyncOperations'
        /// </summary>
		[RelationshipSchemaName("competitoraddress_AsyncOperations")]
		public IEnumerable<SystemJob> CompetitoraddressAsyncOperations
		{
			get { return GetRelatedEntities<SystemJob>("competitoraddress_AsyncOperations", null); }
			set { SetRelatedEntities("competitoraddress_AsyncOperations", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'competitoraddress_BulkDeleteFailures'
        /// </summary>
		[RelationshipSchemaName("competitoraddress_BulkDeleteFailures")]
		public IEnumerable<BulkDeleteFailure> CompetitoraddressBulkDeleteFailures
		{
			get { return GetRelatedEntities<BulkDeleteFailure>("competitoraddress_BulkDeleteFailures", null); }
			set { SetRelatedEntities("competitoraddress_BulkDeleteFailures", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'competitoraddress_MailboxTrackingFolders'
        /// </summary>
		[RelationshipSchemaName("competitoraddress_MailboxTrackingFolders")]
		public IEnumerable<MailboxAutoTrackingFolder> CompetitoraddressMailboxTrackingFolders
		{
			get { return GetRelatedEntities<MailboxAutoTrackingFolder>("competitoraddress_MailboxTrackingFolders", null); }
			set { SetRelatedEntities("competitoraddress_MailboxTrackingFolders", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'competitoraddress_PrincipalObjectAttributeAccesses'
        /// </summary>
		[RelationshipSchemaName("competitoraddress_PrincipalObjectAttributeAccesses")]
		public IEnumerable<FieldSharing> CompetitoraddressPrincipalObjectAttributeAccesses
		{
			get { return GetRelatedEntities<FieldSharing>("competitoraddress_PrincipalObjectAttributeAccesses", null); }
			set { SetRelatedEntities("competitoraddress_PrincipalObjectAttributeAccesses", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'CompetitorAddress_SyncErrors'
        /// </summary>
		[RelationshipSchemaName("CompetitorAddress_SyncErrors")]
		public IEnumerable<SyncError> CompetitorAddressSyncErrors
		{
			get { return GetRelatedEntities<SyncError>("CompetitorAddress_SyncErrors", null); }
			set { SetRelatedEntities("CompetitorAddress_SyncErrors", null, value); }
		}
		#endregion

		#region Actions
		#endregion

		#region OptionSetEnums
		public enum eCompetitoraddressAddresstypecode
		{	
		}
		
		public enum eCompetitoraddressShippingmethodcode
		{	
		}
		
		#endregion	

		#region Properties
		public static class Properties 
		{
			/// <summary>addressnumber</summary>
			public const string AddressNumber = "addressnumber";

			/// <summary>addresstypecode</summary>
			public const string AddressType = "addresstypecode";

			/// <summary>city</summary>
			public const string City = "city";

			/// <summary>competitoraddressid</summary>
			public const string CompetitorAddressId = "competitoraddressid";

			/// <summary>composite</summary>
			public const string Address = "composite";

			/// <summary>country</summary>
			public const string CountryRegion = "country";

			/// <summary>county</summary>
			public const string County = "county";

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

			/// <summary>fax</summary>
			public const string Fax = "fax";

			/// <summary>importsequencenumber</summary>
			public const string ImportSequenceNumber = "importsequencenumber";

			/// <summary>latitude</summary>
			public const string Latitude = "latitude";

			/// <summary>line1</summary>
			public const string Street1 = "line1";

			/// <summary>line2</summary>
			public const string Street2 = "line2";

			/// <summary>line3</summary>
			public const string Street3 = "line3";

			/// <summary>longitude</summary>
			public const string Longitude = "longitude";

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
			public const string AddressName = "name";

			/// <summary>overriddencreatedon</summary>
			public const string RecordCreatedOn = "overriddencreatedon";

			/// <summary>parentid</summary>
			public const string Parent = "parentid";

			/// <summary>parentidname</summary>
			public const string Parentidname = "parentidname";

			/// <summary>parentidyominame</summary>
			public const string Parentidyominame = "parentidyominame";

			/// <summary>postalcode</summary>
			public const string ZIPPostalCode = "postalcode";

			/// <summary>postofficebox</summary>
			public const string PostOfficeBox = "postofficebox";

			/// <summary>shippingmethodcode</summary>
			public const string ShippingMethod = "shippingmethodcode";

			/// <summary>stateorprovince</summary>
			public const string StateProvince = "stateorprovince";

			/// <summary>telephone1</summary>
			public const string MainPhone = "telephone1";

			/// <summary>telephone2</summary>
			public const string Phone2 = "telephone2";

			/// <summary>telephone3</summary>
			public const string Phone3 = "telephone3";

			/// <summary>timezoneruleversionnumber</summary>
			public const string TimeZoneRuleVersionNumber = "timezoneruleversionnumber";

			/// <summary>upszone</summary>
			public const string UPSZone = "upszone";

			/// <summary>utcconversiontimezonecode</summary>
			public const string UTCConversionTimeZoneCode = "utcconversiontimezonecode";

			/// <summary>utcoffset</summary>
			public const string UTCOffset = "utcoffset";

			/// <summary>versionnumber</summary>
			public const string VersionNumber = "versionnumber";

		}
		#endregion

		#region Schemas
		public static class Schemas 
		{
			/// <summary>1:N competitoraddress_AsyncOperations</summary>
			public const string CompetitoraddressAsyncOperations = "competitoraddress_AsyncOperations";

			/// <summary>1:N competitoraddress_BulkDeleteFailures</summary>
			public const string CompetitoraddressBulkDeleteFailures = "competitoraddress_BulkDeleteFailures";

			/// <summary>1:N competitoraddress_MailboxTrackingFolders</summary>
			public const string CompetitoraddressMailboxTrackingFolders = "competitoraddress_MailboxTrackingFolders";

			/// <summary>1:N competitoraddress_PrincipalObjectAttributeAccesses</summary>
			public const string CompetitoraddressPrincipalObjectAttributeAccesses = "competitoraddress_PrincipalObjectAttributeAccesses";

			/// <summary>1:N CompetitorAddress_SyncErrors</summary>
			public const string CompetitorAddressSyncErrors = "CompetitorAddress_SyncErrors";

		}
		#endregion
	}
}

