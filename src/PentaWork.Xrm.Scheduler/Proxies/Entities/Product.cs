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
	[EntityLogicalName("product")]
	public sealed class Product : Entity
	{	
		public static readonly int? EntityTypeCode = 1024;
		public new const string LogicalName = "product";
		public const string PrimaryIdAttribute = "productid";
		public const string PrimaryNameAttribute = "name";
	
		public Product() : base("product") { }

		#region Attributes
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
        /// createdbyexternalparty
        /// </summary>
		[DisplayName("Created By (External Party)")]
		[AttributeLogicalName("createdbyexternalparty")]
		public EntityReference CreatedByExternalParty
		{	
			get { return GetAttributeValue<EntityReference>("createdbyexternalparty"); }
			set
			{ 
				if(value == CreatedByExternalParty) return;
				SetAttributeValue("createdbyexternalparty", value);
			}
		}	
			
		/// <summary>
        /// createdbyexternalpartyname
        /// </summary>
		[DisplayName("createdbyexternalpartyname")]
		[AttributeLogicalName("createdbyexternalpartyname")]
		public string Createdbyexternalpartyname
		{	
			get { return GetAttributeValue<string>("createdbyexternalpartyname"); }
			set
			{ 
				if(value == Createdbyexternalpartyname) return;
				SetAttributeValue("createdbyexternalpartyname", value);
			}
		}	
			
		/// <summary>
        /// createdbyexternalpartyyominame
        /// </summary>
		[DisplayName("createdbyexternalpartyyominame")]
		[AttributeLogicalName("createdbyexternalpartyyominame")]
		public string Createdbyexternalpartyyominame
		{	
			get { return GetAttributeValue<string>("createdbyexternalpartyyominame"); }
			set
			{ 
				if(value == Createdbyexternalpartyyominame) return;
				SetAttributeValue("createdbyexternalpartyyominame", value);
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
        /// currentcost
        /// </summary>
		[DisplayName("Current Cost")]
		[AttributeLogicalName("currentcost")]
		public decimal? CurrentCost
		{	
			get { return GetAttributeValue<Money>("currentcost")?.Value; }
			set 
			{ 
				if(value == CurrentCost) return;

				Money moneyValue = null;
				if(value != null) moneyValue = new Money(value.Value);
				SetAttributeValue("currentcost", moneyValue);  
			}
		}

		/// <summary>
        /// defaultuomid
        /// </summary>
		[DisplayName("Default Unit")]
		[AttributeLogicalName("defaultuomid")]
		public EntityReference DefaultUnit
		{	
			get { return GetAttributeValue<EntityReference>("defaultuomid"); }
			set
			{ 
				if(value == DefaultUnit) return;
				SetAttributeValue("defaultuomid", value);
			}
		}	
			
		/// <summary>
        /// defaultuomidname
        /// </summary>
		[DisplayName("defaultuomidname")]
		[AttributeLogicalName("defaultuomidname")]
		public string Defaultuomidname
		{	
			get { return GetAttributeValue<string>("defaultuomidname"); }
			set
			{ 
				if(value == Defaultuomidname) return;
				SetAttributeValue("defaultuomidname", value);
			}
		}	
			
		/// <summary>
        /// defaultuomscheduleid
        /// </summary>
		[DisplayName("Unit Group")]
		[AttributeLogicalName("defaultuomscheduleid")]
		public EntityReference UnitGroup
		{	
			get { return GetAttributeValue<EntityReference>("defaultuomscheduleid"); }
			set
			{ 
				if(value == UnitGroup) return;
				SetAttributeValue("defaultuomscheduleid", value);
			}
		}	
			
		/// <summary>
        /// defaultuomscheduleidname
        /// </summary>
		[DisplayName("defaultuomscheduleidname")]
		[AttributeLogicalName("defaultuomscheduleidname")]
		public string Defaultuomscheduleidname
		{	
			get { return GetAttributeValue<string>("defaultuomscheduleidname"); }
			set
			{ 
				if(value == Defaultuomscheduleidname) return;
				SetAttributeValue("defaultuomscheduleidname", value);
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
        /// dmtimportstate
        /// </summary>
		[DisplayName("Internal Use Only")]
		[AttributeLogicalName("dmtimportstate")]
		public int? InternalUseOnly
		{	
			get { return GetAttributeValue<int?>("dmtimportstate"); }
			set
			{ 
				if(value == InternalUseOnly) return;
				SetAttributeValue("dmtimportstate", value);
			}
		}	
			
		/// <summary>
        /// entityimage_timestamp
        /// </summary>
		[DisplayName("entityimage_timestamp")]
		[AttributeLogicalName("entityimage_timestamp")]
		public int? EntityimageTimestamp
		{	
			get { return GetAttributeValue<int?>("entityimage_timestamp"); }
			set
			{ 
				if(value == EntityimageTimestamp) return;
				SetAttributeValue("entityimage_timestamp", value);
			}
		}	
			
		/// <summary>
        /// entityimage_url
        /// </summary>
		[DisplayName("entityimage_url")]
		[AttributeLogicalName("entityimage_url")]
		public string EntityimageUrl
		{	
			get { return GetAttributeValue<string>("entityimage_url"); }
			set
			{ 
				if(value == EntityimageUrl) return;
				SetAttributeValue("entityimage_url", value);
			}
		}	
			
		/// <summary>
        /// entityimageid
        /// </summary>
		[DisplayName("entityimageid")]
		[AttributeLogicalName("entityimageid")]
		public Guid EntityimageId
		{	
			get { return GetAttributeValue<Guid>("entityimageid"); }
			set
			{ 
				if(value == EntityimageId) return;
				SetAttributeValue("entityimageid", value);
			}
		}	
			
		/// <summary>
        /// exchangerate
        /// </summary>
		[DisplayName("Exchange Rate")]
		[AttributeLogicalName("exchangerate")]
		public decimal? ExchangeRate
		{	
			get { return GetAttributeValue<decimal?>("exchangerate"); }
			set
			{ 
				if(value == ExchangeRate) return;
				SetAttributeValue("exchangerate", value);
			}
		}	
			
		/// <summary>
        /// hierarchypath
        /// </summary>
		[DisplayName("Hierarchy Path")]
		[AttributeLogicalName("hierarchypath")]
		public string HierarchyPath
		{	
			get { return GetAttributeValue<string>("hierarchypath"); }
			set
			{ 
				if(value == HierarchyPath) return;
				SetAttributeValue("hierarchypath", value);
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
        /// iskit
        /// </summary>
		[DisplayName("Is Kit")]
		[AttributeLogicalName("iskit")]
		public bool? IsKit
		{	
			get { return GetAttributeValue<bool?>("iskit"); }
			set
			{ 
				if(value == IsKit) return;
				SetAttributeValue("iskit", value);
			}
		}	
			
		/// <summary>
        /// isreparented
        /// </summary>
		[DisplayName("Is Reparented")]
		[AttributeLogicalName("isreparented")]
		public bool? IsReparented
		{	
			get { return GetAttributeValue<bool?>("isreparented"); }
			set
			{ 
				if(value == IsReparented) return;
				SetAttributeValue("isreparented", value);
			}
		}	
			
		/// <summary>
        /// isstockitem
        /// </summary>
		[DisplayName("Stock Item")]
		[AttributeLogicalName("isstockitem")]
		public bool? StockItem
		{	
			get { return GetAttributeValue<bool?>("isstockitem"); }
			set
			{ 
				if(value == StockItem) return;
				SetAttributeValue("isstockitem", value);
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
        /// modifiedbyexternalparty
        /// </summary>
		[DisplayName("Modified By (External Party)")]
		[AttributeLogicalName("modifiedbyexternalparty")]
		public EntityReference ModifiedByExternalParty
		{	
			get { return GetAttributeValue<EntityReference>("modifiedbyexternalparty"); }
			set
			{ 
				if(value == ModifiedByExternalParty) return;
				SetAttributeValue("modifiedbyexternalparty", value);
			}
		}	
			
		/// <summary>
        /// modifiedbyexternalpartyname
        /// </summary>
		[DisplayName("modifiedbyexternalpartyname")]
		[AttributeLogicalName("modifiedbyexternalpartyname")]
		public string Modifiedbyexternalpartyname
		{	
			get { return GetAttributeValue<string>("modifiedbyexternalpartyname"); }
			set
			{ 
				if(value == Modifiedbyexternalpartyname) return;
				SetAttributeValue("modifiedbyexternalpartyname", value);
			}
		}	
			
		/// <summary>
        /// modifiedbyexternalpartyyominame
        /// </summary>
		[DisplayName("modifiedbyexternalpartyyominame")]
		[AttributeLogicalName("modifiedbyexternalpartyyominame")]
		public string Modifiedbyexternalpartyyominame
		{	
			get { return GetAttributeValue<string>("modifiedbyexternalpartyyominame"); }
			set
			{ 
				if(value == Modifiedbyexternalpartyyominame) return;
				SetAttributeValue("modifiedbyexternalpartyyominame", value);
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
        /// organizationid
        /// </summary>
		[DisplayName("Organization Id")]
		[AttributeLogicalName("organizationid")]
		public EntityReference OrganizationId
		{	
			get { return GetAttributeValue<EntityReference>("organizationid"); }
			set
			{ 
				if(value == OrganizationId) return;
				SetAttributeValue("organizationid", value);
			}
		}	
			
		/// <summary>
        /// organizationidname
        /// </summary>
		[DisplayName("organizationidname")]
		[AttributeLogicalName("organizationidname")]
		public string Organizationidname
		{	
			get { return GetAttributeValue<string>("organizationidname"); }
			set
			{ 
				if(value == Organizationidname) return;
				SetAttributeValue("organizationidname", value);
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
        /// parentproductid
        /// </summary>
		[DisplayName("Parent")]
		[AttributeLogicalName("parentproductid")]
		public EntityReference Parent
		{	
			get { return GetAttributeValue<EntityReference>("parentproductid"); }
			set
			{ 
				if(value == Parent) return;
				SetAttributeValue("parentproductid", value);
			}
		}	
			
		/// <summary>
        /// parentproductidname
        /// </summary>
		[DisplayName("parentproductidname")]
		[AttributeLogicalName("parentproductidname")]
		public string Parentproductidname
		{	
			get { return GetAttributeValue<string>("parentproductidname"); }
			set
			{ 
				if(value == Parentproductidname) return;
				SetAttributeValue("parentproductidname", value);
			}
		}	
			
		/// <summary>
        /// price
        /// </summary>
		[DisplayName("List Price")]
		[AttributeLogicalName("price")]
		public decimal? ListPrice
		{	
			get { return GetAttributeValue<Money>("price")?.Value; }
			set 
			{ 
				if(value == ListPrice) return;

				Money moneyValue = null;
				if(value != null) moneyValue = new Money(value.Value);
				SetAttributeValue("price", moneyValue);  
			}
		}

		/// <summary>
        /// pricelevelid
        /// </summary>
		[DisplayName("Default Price List")]
		[AttributeLogicalName("pricelevelid")]
		public EntityReference DefaultPriceList
		{	
			get { return GetAttributeValue<EntityReference>("pricelevelid"); }
			set
			{ 
				if(value == DefaultPriceList) return;
				SetAttributeValue("pricelevelid", value);
			}
		}	
			
		/// <summary>
        /// pricelevelidname
        /// </summary>
		[DisplayName("pricelevelidname")]
		[AttributeLogicalName("pricelevelidname")]
		public string Pricelevelidname
		{	
			get { return GetAttributeValue<string>("pricelevelidname"); }
			set
			{ 
				if(value == Pricelevelidname) return;
				SetAttributeValue("pricelevelidname", value);
			}
		}	
			
		/// <summary>
        /// processid
        /// </summary>
		[DisplayName("Process Id")]
		[AttributeLogicalName("processid")]
		public Guid ProcessId
		{	
			get { return GetAttributeValue<Guid>("processid"); }
			set
			{ 
				if(value == ProcessId) return;
				SetAttributeValue("processid", value);
			}
		}	
			
		/// <summary>
        /// productid
        /// </summary>
		[DisplayName("Product")]
		[AttributeLogicalName("productid")]
		public override Guid Id
		{
			get => base.Id;
			set { base.Id = value; SetAttributeValue("productid", value); }
		}

							/// <summary>
        /// productnumber
        /// </summary>
		[DisplayName("Product ID")]
		[AttributeLogicalName("productnumber")]
		public string ProductID
		{	
			get { return GetAttributeValue<string>("productnumber"); }
			set
			{ 
				if(value == ProductID) return;
				SetAttributeValue("productnumber", value);
			}
		}	
			
		/// <summary>
        /// productstructure
        /// </summary>
		[DisplayName("Product Structure")]
		[AttributeLogicalName("productstructure")]
		public eProductClassification? ProductStructure
		{	
			get 
			{ 
				var optionSetValue = GetAttributeValue<OptionSetValue>("productstructure");
				if (optionSetValue != null) return (eProductClassification)optionSetValue.Value;
				else return null;
			}
			set 
			{ 
				if(value == ProductStructure) return;

				OptionSetValue optionSetValue = null;
				if(value != null) optionSetValue = new OptionSetValue((int)value);
				SetAttributeValue("productstructure", optionSetValue); 
			}
		}

		/// <summary>
        /// producttypecode
        /// </summary>
		[DisplayName("Product Type")]
		[AttributeLogicalName("producttypecode")]
		public eProductType? ProductType
		{	
			get 
			{ 
				var optionSetValue = GetAttributeValue<OptionSetValue>("producttypecode");
				if (optionSetValue != null) return (eProductType)optionSetValue.Value;
				else return null;
			}
			set 
			{ 
				if(value == ProductType) return;

				OptionSetValue optionSetValue = null;
				if(value != null) optionSetValue = new OptionSetValue((int)value);
				SetAttributeValue("producttypecode", optionSetValue); 
			}
		}

		/// <summary>
        /// producturl
        /// </summary>
		[DisplayName("URL")]
		[AttributeLogicalName("producturl")]
		public string URL
		{	
			get { return GetAttributeValue<string>("producturl"); }
			set
			{ 
				if(value == URL) return;
				SetAttributeValue("producturl", value);
			}
		}	
			
		/// <summary>
        /// quantitydecimal
        /// </summary>
		[DisplayName("Decimals Supported")]
		[AttributeLogicalName("quantitydecimal")]
		public int? DecimalsSupported
		{	
			get { return GetAttributeValue<int?>("quantitydecimal"); }
			set
			{ 
				if(value == DecimalsSupported) return;
				SetAttributeValue("quantitydecimal", value);
			}
		}	
			
		/// <summary>
        /// quantityonhand
        /// </summary>
		[DisplayName("Quantity On Hand")]
		[AttributeLogicalName("quantityonhand")]
		public decimal? QuantityOnHand
		{	
			get { return GetAttributeValue<decimal?>("quantityonhand"); }
			set
			{ 
				if(value == QuantityOnHand) return;
				SetAttributeValue("quantityonhand", value);
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
        /// stageid
        /// </summary>
		[DisplayName("(Deprecated) Stage Id")]
		[AttributeLogicalName("stageid")]
		public Guid DeprecatedStageId
		{	
			get { return GetAttributeValue<Guid>("stageid"); }
			set
			{ 
				if(value == DeprecatedStageId) return;
				SetAttributeValue("stageid", value);
			}
		}	
			
		/// <summary>
        /// standardcost
        /// </summary>
		[DisplayName("Standard Cost")]
		[AttributeLogicalName("standardcost")]
		public decimal? StandardCost
		{	
			get { return GetAttributeValue<Money>("standardcost")?.Value; }
			set 
			{ 
				if(value == StandardCost) return;

				Money moneyValue = null;
				if(value != null) moneyValue = new Money(value.Value);
				SetAttributeValue("standardcost", moneyValue);  
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
        /// stockvolume
        /// </summary>
		[DisplayName("Stock Volume")]
		[AttributeLogicalName("stockvolume")]
		public decimal? StockVolume
		{	
			get { return GetAttributeValue<decimal?>("stockvolume"); }
			set
			{ 
				if(value == StockVolume) return;
				SetAttributeValue("stockvolume", value);
			}
		}	
			
		/// <summary>
        /// stockweight
        /// </summary>
		[DisplayName("Stock Weight")]
		[AttributeLogicalName("stockweight")]
		public decimal? StockWeight
		{	
			get { return GetAttributeValue<decimal?>("stockweight"); }
			set
			{ 
				if(value == StockWeight) return;
				SetAttributeValue("stockweight", value);
			}
		}	
			
		/// <summary>
        /// subjectid
        /// </summary>
		[DisplayName("Subject")]
		[AttributeLogicalName("subjectid")]
		public EntityReference Subject
		{	
			get { return GetAttributeValue<EntityReference>("subjectid"); }
			set
			{ 
				if(value == Subject) return;
				SetAttributeValue("subjectid", value);
			}
		}	
			
		/// <summary>
        /// subjectidname
        /// </summary>
		[DisplayName("subjectidname")]
		[AttributeLogicalName("subjectidname")]
		public string Subjectidname
		{	
			get { return GetAttributeValue<string>("subjectidname"); }
			set
			{ 
				if(value == Subjectidname) return;
				SetAttributeValue("subjectidname", value);
			}
		}	
			
		/// <summary>
        /// suppliername
        /// </summary>
		[DisplayName("Supplier Name")]
		[AttributeLogicalName("suppliername")]
		public string SupplierName
		{	
			get { return GetAttributeValue<string>("suppliername"); }
			set
			{ 
				if(value == SupplierName) return;
				SetAttributeValue("suppliername", value);
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
        /// transactioncurrencyid
        /// </summary>
		[DisplayName("Currency")]
		[AttributeLogicalName("transactioncurrencyid")]
		public EntityReference Currency
		{	
			get { return GetAttributeValue<EntityReference>("transactioncurrencyid"); }
			set
			{ 
				if(value == Currency) return;
				SetAttributeValue("transactioncurrencyid", value);
			}
		}	
			
		/// <summary>
        /// transactioncurrencyidname
        /// </summary>
		[DisplayName("transactioncurrencyidname")]
		[AttributeLogicalName("transactioncurrencyidname")]
		public string Transactioncurrencyidname
		{	
			get { return GetAttributeValue<string>("transactioncurrencyidname"); }
			set
			{ 
				if(value == Transactioncurrencyidname) return;
				SetAttributeValue("transactioncurrencyidname", value);
			}
		}	
			
		/// <summary>
        /// traversedpath
        /// </summary>
		[DisplayName("(Deprecated) Traversed Path")]
		[AttributeLogicalName("traversedpath")]
		public string DeprecatedTraversedPath
		{	
			get { return GetAttributeValue<string>("traversedpath"); }
			set
			{ 
				if(value == DeprecatedTraversedPath) return;
				SetAttributeValue("traversedpath", value);
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
        /// validfromdate
        /// </summary>
		[DisplayName("Valid From")]
		[AttributeLogicalName("validfromdate")]
		public DateTime? ValidFrom
		{	
			get { return GetAttributeValue<DateTime?>("validfromdate"); }
			set
			{ 
				if(value == ValidFrom) return;
				SetAttributeValue("validfromdate", value);
			}
		}	
			
		/// <summary>
        /// validtodate
        /// </summary>
		[DisplayName("Valid To")]
		[AttributeLogicalName("validtodate")]
		public DateTime? ValidTo
		{	
			get { return GetAttributeValue<DateTime?>("validtodate"); }
			set
			{ 
				if(value == ValidTo) return;
				SetAttributeValue("validtodate", value);
			}
		}	
			
		/// <summary>
        /// vendorid
        /// </summary>
		[DisplayName("Vendor ID")]
		[AttributeLogicalName("vendorid")]
		public string VendorID
		{	
			get { return GetAttributeValue<string>("vendorid"); }
			set
			{ 
				if(value == VendorID) return;
				SetAttributeValue("vendorid", value);
			}
		}	
			
		/// <summary>
        /// vendorname
        /// </summary>
		[DisplayName("Vendor")]
		[AttributeLogicalName("vendorname")]
		public string Vendor
		{	
			get { return GetAttributeValue<string>("vendorname"); }
			set
			{ 
				if(value == Vendor) return;
				SetAttributeValue("vendorname", value);
			}
		}	
			
		/// <summary>
        /// vendorpartnumber
        /// </summary>
		[DisplayName("Vendor Name")]
		[AttributeLogicalName("vendorpartnumber")]
		public string VendorName
		{	
			get { return GetAttributeValue<string>("vendorpartnumber"); }
			set
			{ 
				if(value == VendorName) return;
				SetAttributeValue("vendorpartnumber", value);
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
        /// 1:N Get entities for 'opportunity_products'
        /// </summary>
		[RelationshipSchemaName("opportunity_products")]
		public IEnumerable<OpportunityProduct> OpportunityProducts
		{
			get { return GetRelatedEntities<OpportunityProduct>("opportunity_products", null); }
			set { SetRelatedEntities("opportunity_products", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'Product_Annotation'
        /// </summary>
		[RelationshipSchemaName("Product_Annotation")]
		public IEnumerable<Note> ProductAnnotation
		{
			get { return GetRelatedEntities<Note>("Product_Annotation", null); }
			set { SetRelatedEntities("Product_Annotation", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'Product_AsyncOperations'
        /// </summary>
		[RelationshipSchemaName("Product_AsyncOperations")]
		public IEnumerable<SystemJob> ProductAsyncOperations
		{
			get { return GetRelatedEntities<SystemJob>("Product_AsyncOperations", null); }
			set { SetRelatedEntities("Product_AsyncOperations", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'Product_BulkDeleteFailures'
        /// </summary>
		[RelationshipSchemaName("Product_BulkDeleteFailures")]
		public IEnumerable<BulkDeleteFailure> ProductBulkDeleteFailures
		{
			get { return GetRelatedEntities<BulkDeleteFailure>("Product_BulkDeleteFailures", null); }
			set { SetRelatedEntities("Product_BulkDeleteFailures", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'product_connections1'
        /// </summary>
		[RelationshipSchemaName("product_connections1")]
		public IEnumerable<Connection> ProductConnections1
		{
			get { return GetRelatedEntities<Connection>("product_connections1", null); }
			set { SetRelatedEntities("product_connections1", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'product_connections2'
        /// </summary>
		[RelationshipSchemaName("product_connections2")]
		public IEnumerable<Connection> ProductConnections2
		{
			get { return GetRelatedEntities<Connection>("product_connections2", null); }
			set { SetRelatedEntities("product_connections2", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'product_contract_line_items'
        /// </summary>
		[RelationshipSchemaName("product_contract_line_items")]
		public IEnumerable<ContractLine> ProductContractLineItems
		{
			get { return GetRelatedEntities<ContractLine>("product_contract_line_items", null); }
			set { SetRelatedEntities("product_contract_line_items", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'Product_DynamicProperty'
        /// </summary>
		[RelationshipSchemaName("Product_DynamicProperty")]
		public IEnumerable<Property> ProductDynamicProperty
		{
			get { return GetRelatedEntities<Property>("Product_DynamicProperty", null); }
			set { SetRelatedEntities("Product_DynamicProperty", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'Product_DynamicPropertyAssociation'
        /// </summary>
		[RelationshipSchemaName("Product_DynamicPropertyAssociation")]
		public IEnumerable<PropertyAssociation> ProductDynamicPropertyAssociation
		{
			get { return GetRelatedEntities<PropertyAssociation>("Product_DynamicPropertyAssociation", null); }
			set { SetRelatedEntities("Product_DynamicPropertyAssociation", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'product_incidents'
        /// </summary>
		[RelationshipSchemaName("product_incidents")]
		public IEnumerable<Case> ProductIncidents
		{
			get { return GetRelatedEntities<Case>("product_incidents", null); }
			set { SetRelatedEntities("product_incidents", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'product_invoice_details'
        /// </summary>
		[RelationshipSchemaName("product_invoice_details")]
		public IEnumerable<InvoiceProduct> ProductInvoiceDetails
		{
			get { return GetRelatedEntities<InvoiceProduct>("product_invoice_details", null); }
			set { SetRelatedEntities("product_invoice_details", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'product_MailboxTrackingFolders'
        /// </summary>
		[RelationshipSchemaName("product_MailboxTrackingFolders")]
		public IEnumerable<MailboxAutoTrackingFolder> ProductMailboxTrackingFolders
		{
			get { return GetRelatedEntities<MailboxAutoTrackingFolder>("product_MailboxTrackingFolders", null); }
			set { SetRelatedEntities("product_MailboxTrackingFolders", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'product_order_details'
        /// </summary>
		[RelationshipSchemaName("product_order_details")]
		public IEnumerable<OrderProduct> ProductOrderDetails
		{
			get { return GetRelatedEntities<OrderProduct>("product_order_details", null); }
			set { SetRelatedEntities("product_order_details", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'product_parent_product'
        /// </summary>
		[RelationshipSchemaName("product_parent_product")]
		public IEnumerable<Product> ProductParentProduct
		{
			get { return GetRelatedEntities<Product>("product_parent_product", null); }
			set { SetRelatedEntities("product_parent_product", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'product_price_levels'
        /// </summary>
		[RelationshipSchemaName("product_price_levels")]
		public IEnumerable<PriceListItem> ProductPriceLevels
		{
			get { return GetRelatedEntities<PriceListItem>("product_price_levels", null); }
			set { SetRelatedEntities("product_price_levels", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'product_principalobjectattributeaccess'
        /// </summary>
		[RelationshipSchemaName("product_principalobjectattributeaccess")]
		public IEnumerable<FieldSharing> ProductPrincipalobjectattributeaccess
		{
			get { return GetRelatedEntities<FieldSharing>("product_principalobjectattributeaccess", null); }
			set { SetRelatedEntities("product_principalobjectattributeaccess", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'Product_ProcessSessions'
        /// </summary>
		[RelationshipSchemaName("Product_ProcessSessions")]
		public IEnumerable<ProcessSession> ProductProcessSessions
		{
			get { return GetRelatedEntities<ProcessSession>("Product_ProcessSessions", null); }
			set { SetRelatedEntities("Product_ProcessSessions", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'Product_ProductAssociation_AssocProd'
        /// </summary>
		[RelationshipSchemaName("Product_ProductAssociation_AssocProd")]
		public IEnumerable<ProductAssociation> ProductProductAssociationAssocProd
		{
			get { return GetRelatedEntities<ProductAssociation>("Product_ProductAssociation_AssocProd", null); }
			set { SetRelatedEntities("Product_ProductAssociation_AssocProd", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'Product_ProductAssociation_Prod'
        /// </summary>
		[RelationshipSchemaName("Product_ProductAssociation_Prod")]
		public IEnumerable<ProductAssociation> ProductProductAssociationProd
		{
			get { return GetRelatedEntities<ProductAssociation>("Product_ProductAssociation_Prod", null); }
			set { SetRelatedEntities("Product_ProductAssociation_Prod", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'product_ProductSubstitute_productid'
        /// </summary>
		[RelationshipSchemaName("product_ProductSubstitute_productid")]
		public IEnumerable<ProductRelationship> ProductProductSubstituteProductid
		{
			get { return GetRelatedEntities<ProductRelationship>("product_ProductSubstitute_productid", null); }
			set { SetRelatedEntities("product_ProductSubstitute_productid", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'product_ProductSubstitute_substitutedproductid'
        /// </summary>
		[RelationshipSchemaName("product_ProductSubstitute_substitutedproductid")]
		public IEnumerable<ProductRelationship> ProductProductSubstituteSubstitutedproductid
		{
			get { return GetRelatedEntities<ProductRelationship>("product_ProductSubstitute_substitutedproductid", null); }
			set { SetRelatedEntities("product_ProductSubstitute_substitutedproductid", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'product_quote_details'
        /// </summary>
		[RelationshipSchemaName("product_quote_details")]
		public IEnumerable<QuoteProduct> ProductQuoteDetails
		{
			get { return GetRelatedEntities<QuoteProduct>("product_quote_details", null); }
			set { SetRelatedEntities("product_quote_details", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'Product_SharepointDocumentLocation'
        /// </summary>
		[RelationshipSchemaName("Product_SharepointDocumentLocation")]
		public IEnumerable<DocumentLocation> ProductSharepointDocumentLocation
		{
			get { return GetRelatedEntities<DocumentLocation>("Product_SharepointDocumentLocation", null); }
			set { SetRelatedEntities("Product_SharepointDocumentLocation", null, value); }
		}
		/// <summary>
        /// 1:N Get entities for 'Product_SyncErrors'
        /// </summary>
		[RelationshipSchemaName("Product_SyncErrors")]
		public IEnumerable<SyncError> ProductSyncErrors
		{
			get { return GetRelatedEntities<SyncError>("Product_SyncErrors", null); }
			set { SetRelatedEntities("Product_SyncErrors", null, value); }
		}
		/// <summary>
        /// N:N Get entities for 'Campaign'
        /// </summary>
		[RelationshipSchemaName("campaignproduct_association")]
		public IEnumerable<Campaign> CampaignproductAssociation
		{
			get { return GetRelatedEntities<Campaign>("campaignproduct_association", null); }
			set { SetRelatedEntities("campaignproduct_association", null, value); }
		}
		/// <summary>
        /// N:N Get entities for 'Competitor'
        /// </summary>
		[RelationshipSchemaName("competitorproduct_association")]
		public IEnumerable<Competitor> CompetitorproductAssociation
		{
			get { return GetRelatedEntities<Competitor>("competitorproduct_association", null); }
			set { SetRelatedEntities("competitorproduct_association", null, value); }
		}
		/// <summary>
        /// N:N Get entities for 'Lead'
        /// </summary>
		[RelationshipSchemaName("leadproduct_association")]
		public IEnumerable<Lead> LeadproductAssociation
		{
			get { return GetRelatedEntities<Lead>("leadproduct_association", null); }
			set { SetRelatedEntities("leadproduct_association", null, value); }
		}
		/// <summary>
        /// N:N Get entities for 'Entitlement'
        /// </summary>
		[RelationshipSchemaName("product_entitlement_association")]
		public IEnumerable<Entitlement> ProductEntitlementAssociation
		{
			get { return GetRelatedEntities<Entitlement>("product_entitlement_association", null); }
			set { SetRelatedEntities("product_entitlement_association", null, value); }
		}
		/// <summary>
        /// N:N Get entities for 'EntitlementTemplate'
        /// </summary>
		[RelationshipSchemaName("product_entitlementtemplate_association")]
		public IEnumerable<EntitlementTemplate> ProductEntitlementtemplateAssociation
		{
			get { return GetRelatedEntities<EntitlementTemplate>("product_entitlementtemplate_association", null); }
			set { SetRelatedEntities("product_entitlementtemplate_association", null, value); }
		}
		/// <summary>
        /// N:N Get entities for 'SalesLiterature'
        /// </summary>
		[RelationshipSchemaName("productsalesliterature_association")]
		public IEnumerable<SalesLiterature> ProductsalesliteratureAssociation
		{
			get { return GetRelatedEntities<SalesLiterature>("productsalesliterature_association", null); }
			set { SetRelatedEntities("productsalesliterature_association", null, value); }
		}
		#endregion

		#region Actions
		#endregion

		#region OptionSetEnums
		public enum eProductClassification
		{	
		
			[Label("Product")]
			[Description(@"")]
			Product = 1, 
		
			[Label("Product Family")]
			[Description(@"")]
			ProductFamily = 2, 
		
			[Label("Product Bundle")]
			[Description(@"")]
			ProductBundle = 3, 
		}
		
		public enum eProductType
		{	
		
			[Label("Sales Inventory")]
			[Description(@"")]
			SalesInventory = 1, 
		
			[Label("Miscellaneous Charges")]
			[Description(@"")]
			MiscellaneousCharges = 2, 
		
			[Label("Services")]
			[Description(@"")]
			Services = 3, 
		
			[Label("Flat Fees")]
			[Description(@"")]
			FlatFees = 4, 
		}
		
		public enum eStatus
		{	
		
			[Label("Active")]
			[Description(@"")]
			Active = 0, 
		
			[Label("Retired")]
			[Description(@"")]
			Retired = 1, 
		
			[Label("Draft")]
			[Description(@"")]
			Draft = 2, 
		
			[Label("Under Revision")]
			[Description(@"")]
			UnderRevision = 3, 
		}
		
		public enum eStatusReason
		{	
		
			[Label("Active")]
			[Description(@"")]
			Active_Active = 1, 
		
			[Label("Retired")]
			[Description(@"")]
			Retired_Inactive = 2, 
		
			[Label("Draft")]
			[Description(@"")]
			Draft = 0, 
		
			[Label("Under Revision")]
			[Description(@"")]
			UnderRevision = 3, 
		}
		
		#endregion	

		#region Properties
		public static class Properties 
		{
			/// <summary>createdby</summary>
			public const string CreatedBy = "createdby";

			/// <summary>createdbyexternalparty</summary>
			public const string CreatedByExternalParty = "createdbyexternalparty";

			/// <summary>createdbyexternalpartyname</summary>
			public const string Createdbyexternalpartyname = "createdbyexternalpartyname";

			/// <summary>createdbyexternalpartyyominame</summary>
			public const string Createdbyexternalpartyyominame = "createdbyexternalpartyyominame";

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

			/// <summary>currentcost</summary>
			public const string CurrentCost = "currentcost";

			/// <summary>defaultuomid</summary>
			public const string DefaultUnit = "defaultuomid";

			/// <summary>defaultuomidname</summary>
			public const string Defaultuomidname = "defaultuomidname";

			/// <summary>defaultuomscheduleid</summary>
			public const string UnitGroup = "defaultuomscheduleid";

			/// <summary>defaultuomscheduleidname</summary>
			public const string Defaultuomscheduleidname = "defaultuomscheduleidname";

			/// <summary>description</summary>
			public const string Description = "description";

			/// <summary>dmtimportstate</summary>
			public const string InternalUseOnly = "dmtimportstate";

			/// <summary>entityimage_timestamp</summary>
			public const string EntityimageTimestamp = "entityimage_timestamp";

			/// <summary>entityimage_url</summary>
			public const string EntityimageUrl = "entityimage_url";

			/// <summary>entityimageid</summary>
			public const string EntityimageId = "entityimageid";

			/// <summary>exchangerate</summary>
			public const string ExchangeRate = "exchangerate";

			/// <summary>hierarchypath</summary>
			public const string HierarchyPath = "hierarchypath";

			/// <summary>importsequencenumber</summary>
			public const string ImportSequenceNumber = "importsequencenumber";

			/// <summary>iskit</summary>
			public const string IsKit = "iskit";

			/// <summary>isreparented</summary>
			public const string IsReparented = "isreparented";

			/// <summary>isstockitem</summary>
			public const string StockItem = "isstockitem";

			/// <summary>modifiedby</summary>
			public const string ModifiedBy = "modifiedby";

			/// <summary>modifiedbyexternalparty</summary>
			public const string ModifiedByExternalParty = "modifiedbyexternalparty";

			/// <summary>modifiedbyexternalpartyname</summary>
			public const string Modifiedbyexternalpartyname = "modifiedbyexternalpartyname";

			/// <summary>modifiedbyexternalpartyyominame</summary>
			public const string Modifiedbyexternalpartyyominame = "modifiedbyexternalpartyyominame";

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

			/// <summary>organizationid</summary>
			public const string OrganizationId = "organizationid";

			/// <summary>organizationidname</summary>
			public const string Organizationidname = "organizationidname";

			/// <summary>overriddencreatedon</summary>
			public const string RecordCreatedOn = "overriddencreatedon";

			/// <summary>parentproductid</summary>
			public const string Parent = "parentproductid";

			/// <summary>parentproductidname</summary>
			public const string Parentproductidname = "parentproductidname";

			/// <summary>price</summary>
			public const string ListPrice = "price";

			/// <summary>pricelevelid</summary>
			public const string DefaultPriceList = "pricelevelid";

			/// <summary>pricelevelidname</summary>
			public const string Pricelevelidname = "pricelevelidname";

			/// <summary>processid</summary>
			public const string ProcessId = "processid";

			/// <summary>productid</summary>
			public const string ProductId = "productid";

			/// <summary>productnumber</summary>
			public const string ProductID = "productnumber";

			/// <summary>productstructure</summary>
			public const string ProductStructure = "productstructure";

			/// <summary>producttypecode</summary>
			public const string ProductType = "producttypecode";

			/// <summary>producturl</summary>
			public const string URL = "producturl";

			/// <summary>quantitydecimal</summary>
			public const string DecimalsSupported = "quantitydecimal";

			/// <summary>quantityonhand</summary>
			public const string QuantityOnHand = "quantityonhand";

			/// <summary>size</summary>
			public const string Size = "size";

			/// <summary>stageid</summary>
			public const string DeprecatedStageId = "stageid";

			/// <summary>standardcost</summary>
			public const string StandardCost = "standardcost";

			/// <summary>statecode</summary>
			public const string Status = "statecode";

			/// <summary>statuscode</summary>
			public const string StatusReason = "statuscode";

			/// <summary>stockvolume</summary>
			public const string StockVolume = "stockvolume";

			/// <summary>stockweight</summary>
			public const string StockWeight = "stockweight";

			/// <summary>subjectid</summary>
			public const string Subject = "subjectid";

			/// <summary>subjectidname</summary>
			public const string Subjectidname = "subjectidname";

			/// <summary>suppliername</summary>
			public const string SupplierName = "suppliername";

			/// <summary>timezoneruleversionnumber</summary>
			public const string TimeZoneRuleVersionNumber = "timezoneruleversionnumber";

			/// <summary>transactioncurrencyid</summary>
			public const string Currency = "transactioncurrencyid";

			/// <summary>transactioncurrencyidname</summary>
			public const string Transactioncurrencyidname = "transactioncurrencyidname";

			/// <summary>traversedpath</summary>
			public const string DeprecatedTraversedPath = "traversedpath";

			/// <summary>utcconversiontimezonecode</summary>
			public const string UTCConversionTimeZoneCode = "utcconversiontimezonecode";

			/// <summary>validfromdate</summary>
			public const string ValidFrom = "validfromdate";

			/// <summary>validtodate</summary>
			public const string ValidTo = "validtodate";

			/// <summary>vendorid</summary>
			public const string VendorID = "vendorid";

			/// <summary>vendorname</summary>
			public const string Vendor = "vendorname";

			/// <summary>vendorpartnumber</summary>
			public const string VendorName = "vendorpartnumber";

			/// <summary>versionnumber</summary>
			public const string VersionNumber = "versionnumber";

		}
		#endregion

		#region Schemas
		public static class Schemas 
		{
			/// <summary>1:N opportunity_products</summary>
			public const string OpportunityProducts = "opportunity_products";

			/// <summary>1:N Product_Annotation</summary>
			public const string ProductAnnotation = "Product_Annotation";

			/// <summary>1:N Product_AsyncOperations</summary>
			public const string ProductAsyncOperations = "Product_AsyncOperations";

			/// <summary>1:N Product_BulkDeleteFailures</summary>
			public const string ProductBulkDeleteFailures = "Product_BulkDeleteFailures";

			/// <summary>1:N product_connections1</summary>
			public const string ProductConnections1 = "product_connections1";

			/// <summary>1:N product_connections2</summary>
			public const string ProductConnections2 = "product_connections2";

			/// <summary>1:N product_contract_line_items</summary>
			public const string ProductContractLineItems = "product_contract_line_items";

			/// <summary>1:N Product_DynamicProperty</summary>
			public const string ProductDynamicProperty = "Product_DynamicProperty";

			/// <summary>1:N Product_DynamicPropertyAssociation</summary>
			public const string ProductDynamicPropertyAssociation = "Product_DynamicPropertyAssociation";

			/// <summary>1:N product_incidents</summary>
			public const string ProductIncidents = "product_incidents";

			/// <summary>1:N product_invoice_details</summary>
			public const string ProductInvoiceDetails = "product_invoice_details";

			/// <summary>1:N product_MailboxTrackingFolders</summary>
			public const string ProductMailboxTrackingFolders = "product_MailboxTrackingFolders";

			/// <summary>1:N product_order_details</summary>
			public const string ProductOrderDetails = "product_order_details";

			/// <summary>1:N product_parent_product</summary>
			public const string ProductParentProduct = "product_parent_product";

			/// <summary>1:N product_price_levels</summary>
			public const string ProductPriceLevels = "product_price_levels";

			/// <summary>1:N product_principalobjectattributeaccess</summary>
			public const string ProductPrincipalobjectattributeaccess = "product_principalobjectattributeaccess";

			/// <summary>1:N Product_ProcessSessions</summary>
			public const string ProductProcessSessions = "Product_ProcessSessions";

			/// <summary>1:N Product_ProductAssociation_AssocProd</summary>
			public const string ProductProductAssociationAssocProd = "Product_ProductAssociation_AssocProd";

			/// <summary>1:N Product_ProductAssociation_Prod</summary>
			public const string ProductProductAssociationProd = "Product_ProductAssociation_Prod";

			/// <summary>1:N product_ProductSubstitute_productid</summary>
			public const string ProductProductSubstituteProductid = "product_ProductSubstitute_productid";

			/// <summary>1:N product_ProductSubstitute_substitutedproductid</summary>
			public const string ProductProductSubstituteSubstitutedproductid = "product_ProductSubstitute_substitutedproductid";

			/// <summary>1:N product_quote_details</summary>
			public const string ProductQuoteDetails = "product_quote_details";

			/// <summary>1:N Product_SharepointDocumentLocation</summary>
			public const string ProductSharepointDocumentLocation = "Product_SharepointDocumentLocation";

			/// <summary>1:N Product_SyncErrors</summary>
			public const string ProductSyncErrors = "Product_SyncErrors";

			/// <summary>N:N campaignproduct_association</summary>
			public const string CampaignproductAssociation = "campaignproduct_association";

			/// <summary>N:N competitorproduct_association</summary>
			public const string CompetitorproductAssociation = "competitorproduct_association";

			/// <summary>N:N leadproduct_association</summary>
			public const string LeadproductAssociation = "leadproduct_association";

			/// <summary>N:N product_entitlement_association</summary>
			public const string ProductEntitlementAssociation = "product_entitlement_association";

			/// <summary>N:N product_entitlementtemplate_association</summary>
			public const string ProductEntitlementtemplateAssociation = "product_entitlementtemplate_association";

			/// <summary>N:N productsalesliterature_association</summary>
			public const string ProductsalesliteratureAssociation = "productsalesliterature_association";

		}
		#endregion
	}
}

