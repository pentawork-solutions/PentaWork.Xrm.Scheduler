using System;
using System.Linq;
using System.Diagnostics;
using System.ComponentModel;
using Microsoft.Xrm.Sdk; 
using Microsoft.Xrm.Sdk.Client;
using System.Collections.Generic;

namespace PentaWork.Xrm.Scheduler.Proxies.Entities
{
	[DebuggerDisplay("{FullName}")] 	
	[EntityLogicalName("msdyn_suggestedcontact")]
	public sealed class SuggestedContact : Entity
	{	
		public static readonly int? EntityTypeCode = 10097;
		public new const string LogicalName = "msdyn_suggestedcontact";
		public const string PrimaryIdAttribute = "msdyn_suggestedcontactid";
		public const string PrimaryNameAttribute = "msdyn_fullname";
	
		public SuggestedContact() : base("msdyn_suggestedcontact") { }

		#region Attributes
		/// <summary>
        /// msdyn_accountid
        /// </summary>
		[DisplayName("Account Name")]
		[AttributeLogicalName("msdyn_accountid")]
		public EntityReference AccountName
		{	
			get { return GetAttributeValue<EntityReference>("msdyn_accountid"); }
			set
			{ 
				if(value == AccountName) return;
				SetAttributeValue("msdyn_accountid", value);
			}
		}	
			
		/// <summary>
        /// msdyn_accountidname
        /// </summary>
		[DisplayName("Account Name")]
		[AttributeLogicalName("msdyn_accountidname")]
		public string AccountName2
		{	
			get { return GetAttributeValue<string>("msdyn_accountidname"); }
			set
			{ 
				if(value == AccountName2) return;
				SetAttributeValue("msdyn_accountidname", value);
			}
		}	
			
		/// <summary>
        /// msdyn_accountname
        /// </summary>
		[DisplayName("Account Name")]
		[AttributeLogicalName("msdyn_accountname")]
		public string AccountName3
		{	
			get { return GetAttributeValue<string>("msdyn_accountname"); }
			set
			{ 
				if(value == AccountName3) return;
				SetAttributeValue("msdyn_accountname", value);
			}
		}	
			
		/// <summary>
        /// msdyn_addresscity
        /// </summary>
		[DisplayName("Address City")]
		[AttributeLogicalName("msdyn_addresscity")]
		public string AddressCity
		{	
			get { return GetAttributeValue<string>("msdyn_addresscity"); }
			set
			{ 
				if(value == AddressCity) return;
				SetAttributeValue("msdyn_addresscity", value);
			}
		}	
			
		/// <summary>
        /// msdyn_addressline1
        /// </summary>
		[DisplayName("AddressLine1")]
		[AttributeLogicalName("msdyn_addressline1")]
		public string AddressLine1
		{	
			get { return GetAttributeValue<string>("msdyn_addressline1"); }
			set
			{ 
				if(value == AddressLine1) return;
				SetAttributeValue("msdyn_addressline1", value);
			}
		}	
			
		/// <summary>
        /// msdyn_addressline2
        /// </summary>
		[DisplayName("AddressLine2")]
		[AttributeLogicalName("msdyn_addressline2")]
		public string AddressLine2
		{	
			get { return GetAttributeValue<string>("msdyn_addressline2"); }
			set
			{ 
				if(value == AddressLine2) return;
				SetAttributeValue("msdyn_addressline2", value);
			}
		}	
			
		/// <summary>
        /// msdyn_addresspostalcode
        /// </summary>
		[DisplayName("Address Postal Code")]
		[AttributeLogicalName("msdyn_addresspostalcode")]
		public string AddressPostalCode
		{	
			get { return GetAttributeValue<string>("msdyn_addresspostalcode"); }
			set
			{ 
				if(value == AddressPostalCode) return;
				SetAttributeValue("msdyn_addresspostalcode", value);
			}
		}	
			
		/// <summary>
        /// msdyn_companyname
        /// </summary>
		[DisplayName("Company Name")]
		[AttributeLogicalName("msdyn_companyname")]
		public string CompanyName
		{	
			get { return GetAttributeValue<string>("msdyn_companyname"); }
			set
			{ 
				if(value == CompanyName) return;
				SetAttributeValue("msdyn_companyname", value);
			}
		}	
			
		/// <summary>
        /// msdyn_createdon
        /// </summary>
		[DisplayName("Date")]
		[AttributeLogicalName("msdyn_createdon")]
		public DateTime? Date
		{	
			get { return GetAttributeValue<DateTime?>("msdyn_createdon"); }
			set
			{ 
				if(value == Date) return;
				SetAttributeValue("msdyn_createdon", value);
			}
		}	
			
		/// <summary>
        /// msdyn_description
        /// </summary>
		[DisplayName("Description")]
		[AttributeLogicalName("msdyn_description")]
		public string Description
		{	
			get { return GetAttributeValue<string>("msdyn_description"); }
			set
			{ 
				if(value == Description) return;
				SetAttributeValue("msdyn_description", value);
			}
		}	
			
		/// <summary>
        /// msdyn_email
        /// </summary>
		[DisplayName("Email")]
		[AttributeLogicalName("msdyn_email")]
		public string Email
		{	
			get { return GetAttributeValue<string>("msdyn_email"); }
			set
			{ 
				if(value == Email) return;
				SetAttributeValue("msdyn_email", value);
			}
		}	
			
		/// <summary>
        /// msdyn_firstname
        /// </summary>
		[DisplayName("First Name")]
		[AttributeLogicalName("msdyn_firstname")]
		public string FirstName
		{	
			get { return GetAttributeValue<string>("msdyn_firstname"); }
			set
			{ 
				if(value == FirstName) return;
				SetAttributeValue("msdyn_firstname", value);
			}
		}	
			
		/// <summary>
        /// msdyn_fullname
        /// </summary>
		[DisplayName("Full Name")]
		[AttributeLogicalName("msdyn_fullname")]
		public string FullName
		{	
			get { return GetAttributeValue<string>("msdyn_fullname"); }
			set
			{ 
				if(value == FullName) return;
				SetAttributeValue("msdyn_fullname", value);
			}
		}	
			
		/// <summary>
        /// msdyn_jobtitle
        /// </summary>
		[DisplayName("Job Title")]
		[AttributeLogicalName("msdyn_jobtitle")]
		public string JobTitle
		{	
			get { return GetAttributeValue<string>("msdyn_jobtitle"); }
			set
			{ 
				if(value == JobTitle) return;
				SetAttributeValue("msdyn_jobtitle", value);
			}
		}	
			
		/// <summary>
        /// msdyn_lastname
        /// </summary>
		[DisplayName("Last Name")]
		[AttributeLogicalName("msdyn_lastname")]
		public string LastName
		{	
			get { return GetAttributeValue<string>("msdyn_lastname"); }
			set
			{ 
				if(value == LastName) return;
				SetAttributeValue("msdyn_lastname", value);
			}
		}	
			
		/// <summary>
        /// msdyn_mobilephone
        /// </summary>
		[DisplayName("Mobile Phone")]
		[AttributeLogicalName("msdyn_mobilephone")]
		public string MobilePhone
		{	
			get { return GetAttributeValue<string>("msdyn_mobilephone"); }
			set
			{ 
				if(value == MobilePhone) return;
				SetAttributeValue("msdyn_mobilephone", value);
			}
		}	
			
		/// <summary>
        /// msdyn_preferredcontactmethodcode
        /// </summary>
		[DisplayName("Preferred Contact Method Code")]
		[AttributeLogicalName("msdyn_preferredcontactmethodcode")]
		public string PreferredContactMethodCode
		{	
			get { return GetAttributeValue<string>("msdyn_preferredcontactmethodcode"); }
			set
			{ 
				if(value == PreferredContactMethodCode) return;
				SetAttributeValue("msdyn_preferredcontactmethodcode", value);
			}
		}	
			
		/// <summary>
        /// msdyn_suggestedcontactid
        /// </summary>
		[DisplayName("Suggested Contact")]
		[AttributeLogicalName("msdyn_suggestedcontactid")]
		public override Guid Id
		{
			get => base.Id;
			set { base.Id = value; SetAttributeValue("msdyn_suggestedcontactid", value); }
		}

							/// <summary>
        /// msdyn_telephone
        /// </summary>
		[DisplayName("Telephone")]
		[AttributeLogicalName("msdyn_telephone")]
		public string Telephone
		{	
			get { return GetAttributeValue<string>("msdyn_telephone"); }
			set
			{ 
				if(value == Telephone) return;
				SetAttributeValue("msdyn_telephone", value);
			}
		}	
			
		#endregion	

		#region Relations
			#endregion

		#region Actions
		#endregion

		#region OptionSetEnums
		#endregion	

		#region Properties
		public static class Properties 
		{
			/// <summary>msdyn_accountid</summary>
			public const string AccountName = "msdyn_accountid";

			/// <summary>msdyn_accountidname</summary>
			public const string AccountName2 = "msdyn_accountidname";

			/// <summary>msdyn_accountname</summary>
			public const string AccountName3 = "msdyn_accountname";

			/// <summary>msdyn_addresscity</summary>
			public const string AddressCity = "msdyn_addresscity";

			/// <summary>msdyn_addressline1</summary>
			public const string AddressLine1 = "msdyn_addressline1";

			/// <summary>msdyn_addressline2</summary>
			public const string AddressLine2 = "msdyn_addressline2";

			/// <summary>msdyn_addresspostalcode</summary>
			public const string AddressPostalCode = "msdyn_addresspostalcode";

			/// <summary>msdyn_companyname</summary>
			public const string CompanyName = "msdyn_companyname";

			/// <summary>msdyn_createdon</summary>
			public const string Date = "msdyn_createdon";

			/// <summary>msdyn_description</summary>
			public const string Description = "msdyn_description";

			/// <summary>msdyn_email</summary>
			public const string Email = "msdyn_email";

			/// <summary>msdyn_firstname</summary>
			public const string FirstName = "msdyn_firstname";

			/// <summary>msdyn_fullname</summary>
			public const string FullName = "msdyn_fullname";

			/// <summary>msdyn_jobtitle</summary>
			public const string JobTitle = "msdyn_jobtitle";

			/// <summary>msdyn_lastname</summary>
			public const string LastName = "msdyn_lastname";

			/// <summary>msdyn_mobilephone</summary>
			public const string MobilePhone = "msdyn_mobilephone";

			/// <summary>msdyn_preferredcontactmethodcode</summary>
			public const string PreferredContactMethodCode = "msdyn_preferredcontactmethodcode";

			/// <summary>msdyn_suggestedcontactid</summary>
			public const string SuggestedContactId = "msdyn_suggestedcontactid";

			/// <summary>msdyn_telephone</summary>
			public const string Telephone = "msdyn_telephone";

		}
		#endregion

		#region Schemas
		public static class Schemas 
		{
		}
		#endregion
	}
}

