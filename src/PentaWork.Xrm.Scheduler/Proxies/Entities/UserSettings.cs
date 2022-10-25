using System;
using System.Linq;
using System.Diagnostics;
using System.ComponentModel;
using Microsoft.Xrm.Sdk; 
using Microsoft.Xrm.Sdk.Client;
using System.Collections.Generic;

namespace PentaWork.Xrm.Scheduler.Proxies.Entities
{
	
	[EntityLogicalName("usersettings")]
	public sealed class UserSettings : Entity
	{	
		public static readonly int? EntityTypeCode = 150;
		public new const string LogicalName = "usersettings";
		public const string PrimaryIdAttribute = "systemuserid";
		public const string PrimaryNameAttribute = "";
	
		public UserSettings() : base("usersettings") { }

		#region Attributes
		/// <summary>
        /// addressbooksyncinterval
        /// </summary>
		[DisplayName("addressbooksyncinterval")]
		[AttributeLogicalName("addressbooksyncinterval")]
		public int? Addressbooksyncinterval
		{	
			get { return GetAttributeValue<int?>("addressbooksyncinterval"); }
			set
			{ 
				if(value == Addressbooksyncinterval) return;
				SetAttributeValue("addressbooksyncinterval", value);
			}
		}	
			
		/// <summary>
        /// advancedfindstartupmode
        /// </summary>
		[DisplayName("advancedfindstartupmode")]
		[AttributeLogicalName("advancedfindstartupmode")]
		public int? Advancedfindstartupmode
		{	
			get { return GetAttributeValue<int?>("advancedfindstartupmode"); }
			set
			{ 
				if(value == Advancedfindstartupmode) return;
				SetAttributeValue("advancedfindstartupmode", value);
			}
		}	
			
		/// <summary>
        /// allowemailcredentials
        /// </summary>
		[DisplayName("allowemailcredentials")]
		[AttributeLogicalName("allowemailcredentials")]
		public bool? Allowemailcredentials
		{	
			get { return GetAttributeValue<bool?>("allowemailcredentials"); }
			set
			{ 
				if(value == Allowemailcredentials) return;
				SetAttributeValue("allowemailcredentials", value);
			}
		}	
			
		/// <summary>
        /// amdesignator
        /// </summary>
		[DisplayName("amdesignator")]
		[AttributeLogicalName("amdesignator")]
		public string Amdesignator
		{	
			get { return GetAttributeValue<string>("amdesignator"); }
			set
			{ 
				if(value == Amdesignator) return;
				SetAttributeValue("amdesignator", value);
			}
		}	
			
		/// <summary>
        /// autocaptureuserstatus
        /// </summary>
		[DisplayName("autocaptureuserstatus")]
		[AttributeLogicalName("autocaptureuserstatus")]
		public int? Autocaptureuserstatus
		{	
			get { return GetAttributeValue<int?>("autocaptureuserstatus"); }
			set
			{ 
				if(value == Autocaptureuserstatus) return;
				SetAttributeValue("autocaptureuserstatus", value);
			}
		}	
			
		/// <summary>
        /// autocreatecontactonpromote
        /// </summary>
		[DisplayName("autocreatecontactonpromote")]
		[AttributeLogicalName("autocreatecontactonpromote")]
		public int? Autocreatecontactonpromote
		{	
			get { return GetAttributeValue<int?>("autocreatecontactonpromote"); }
			set
			{ 
				if(value == Autocreatecontactonpromote) return;
				SetAttributeValue("autocreatecontactonpromote", value);
			}
		}	
			
		/// <summary>
        /// businessunitid
        /// </summary>
		[DisplayName("businessunitid")]
		[AttributeLogicalName("businessunitid")]
		public Guid BusinessunitId
		{	
			get { return GetAttributeValue<Guid>("businessunitid"); }
			set
			{ 
				if(value == BusinessunitId) return;
				SetAttributeValue("businessunitid", value);
			}
		}	
			
		/// <summary>
        /// businessunitidname
        /// </summary>
		[DisplayName("businessunitidname")]
		[AttributeLogicalName("businessunitidname")]
		public string Businessunitidname
		{	
			get { return GetAttributeValue<string>("businessunitidname"); }
			set
			{ 
				if(value == Businessunitidname) return;
				SetAttributeValue("businessunitidname", value);
			}
		}	
			
		/// <summary>
        /// calendartype
        /// </summary>
		[DisplayName("calendartype")]
		[AttributeLogicalName("calendartype")]
		public int? Calendartype
		{	
			get { return GetAttributeValue<int?>("calendartype"); }
			set
			{ 
				if(value == Calendartype) return;
				SetAttributeValue("calendartype", value);
			}
		}	
			
		/// <summary>
        /// createdby
        /// </summary>
		[DisplayName("createdby")]
		[AttributeLogicalName("createdby")]
		public EntityReference Createdby
		{	
			get { return GetAttributeValue<EntityReference>("createdby"); }
			set
			{ 
				if(value == Createdby) return;
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
		[DisplayName("createdon")]
		[AttributeLogicalName("createdon")]
		public DateTime? Createdon
		{	
			get { return GetAttributeValue<DateTime?>("createdon"); }
			set
			{ 
				if(value == Createdon) return;
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
        /// currencydecimalprecision
        /// </summary>
		[DisplayName("currencydecimalprecision")]
		[AttributeLogicalName("currencydecimalprecision")]
		public int? Currencydecimalprecision
		{	
			get { return GetAttributeValue<int?>("currencydecimalprecision"); }
			set
			{ 
				if(value == Currencydecimalprecision) return;
				SetAttributeValue("currencydecimalprecision", value);
			}
		}	
			
		/// <summary>
        /// currencyformatcode
        /// </summary>
		[DisplayName("currencyformatcode")]
		[AttributeLogicalName("currencyformatcode")]
		public int? Currencyformatcode
		{	
			get { return GetAttributeValue<int?>("currencyformatcode"); }
			set
			{ 
				if(value == Currencyformatcode) return;
				SetAttributeValue("currencyformatcode", value);
			}
		}	
			
		/// <summary>
        /// currencysymbol
        /// </summary>
		[DisplayName("currencysymbol")]
		[AttributeLogicalName("currencysymbol")]
		public string Currencysymbol
		{	
			get { return GetAttributeValue<string>("currencysymbol"); }
			set
			{ 
				if(value == Currencysymbol) return;
				SetAttributeValue("currencysymbol", value);
			}
		}	
			
		/// <summary>
        /// datavalidationmodeforexporttoexcel
        /// </summary>
		[DisplayName("Data Validation Mode For Export To Excel")]
		[AttributeLogicalName("datavalidationmodeforexporttoexcel")]
		public eDataValidationModeForExportToExcel? DataValidationModeForExportToExcel
		{	
			get 
			{ 
				var optionSetValue = GetAttributeValue<OptionSetValue>("datavalidationmodeforexporttoexcel");
				if (optionSetValue != null) return (eDataValidationModeForExportToExcel)optionSetValue.Value;
				else return null;
			}
			set 
			{ 
				if(value == DataValidationModeForExportToExcel) return;

				OptionSetValue optionSetValue = null;
				if(value != null) optionSetValue = new OptionSetValue((int)value);
				SetAttributeValue("datavalidationmodeforexporttoexcel", optionSetValue); 
			}
		}

		/// <summary>
        /// dateformatcode
        /// </summary>
		[DisplayName("dateformatcode")]
		[AttributeLogicalName("dateformatcode")]
		public int? Dateformatcode
		{	
			get { return GetAttributeValue<int?>("dateformatcode"); }
			set
			{ 
				if(value == Dateformatcode) return;
				SetAttributeValue("dateformatcode", value);
			}
		}	
			
		/// <summary>
        /// dateformatstring
        /// </summary>
		[DisplayName("dateformatstring")]
		[AttributeLogicalName("dateformatstring")]
		public string Dateformatstring
		{	
			get { return GetAttributeValue<string>("dateformatstring"); }
			set
			{ 
				if(value == Dateformatstring) return;
				SetAttributeValue("dateformatstring", value);
			}
		}	
			
		/// <summary>
        /// dateseparator
        /// </summary>
		[DisplayName("dateseparator")]
		[AttributeLogicalName("dateseparator")]
		public string Dateseparator
		{	
			get { return GetAttributeValue<string>("dateseparator"); }
			set
			{ 
				if(value == Dateseparator) return;
				SetAttributeValue("dateseparator", value);
			}
		}	
			
		/// <summary>
        /// decimalsymbol
        /// </summary>
		[DisplayName("decimalsymbol")]
		[AttributeLogicalName("decimalsymbol")]
		public string Decimalsymbol
		{	
			get { return GetAttributeValue<string>("decimalsymbol"); }
			set
			{ 
				if(value == Decimalsymbol) return;
				SetAttributeValue("decimalsymbol", value);
			}
		}	
			
		/// <summary>
        /// defaultcalendarview
        /// </summary>
		[DisplayName("defaultcalendarview")]
		[AttributeLogicalName("defaultcalendarview")]
		public int? Defaultcalendarview
		{	
			get { return GetAttributeValue<int?>("defaultcalendarview"); }
			set
			{ 
				if(value == Defaultcalendarview) return;
				SetAttributeValue("defaultcalendarview", value);
			}
		}	
			
		/// <summary>
        /// defaultcountrycode
        /// </summary>
		[DisplayName("Default Country Code")]
		[AttributeLogicalName("defaultcountrycode")]
		public string DefaultCountryCode
		{	
			get { return GetAttributeValue<string>("defaultcountrycode"); }
			set
			{ 
				if(value == DefaultCountryCode) return;
				SetAttributeValue("defaultcountrycode", value);
			}
		}	
			
		/// <summary>
        /// defaultdashboardid
        /// </summary>
		[DisplayName("defaultdashboardid")]
		[AttributeLogicalName("defaultdashboardid")]
		public Guid DefaultdashboardId
		{	
			get { return GetAttributeValue<Guid>("defaultdashboardid"); }
			set
			{ 
				if(value == DefaultdashboardId) return;
				SetAttributeValue("defaultdashboardid", value);
			}
		}	
			
		/// <summary>
        /// defaultsearchexperience
        /// </summary>
		[DisplayName("Default Search Experience")]
		[AttributeLogicalName("defaultsearchexperience")]
		public eDefaultSearchExperience? DefaultSearchExperience
		{	
			get 
			{ 
				var optionSetValue = GetAttributeValue<OptionSetValue>("defaultsearchexperience");
				if (optionSetValue != null) return (eDefaultSearchExperience)optionSetValue.Value;
				else return null;
			}
			set 
			{ 
				if(value == DefaultSearchExperience) return;

				OptionSetValue optionSetValue = null;
				if(value != null) optionSetValue = new OptionSetValue((int)value);
				SetAttributeValue("defaultsearchexperience", optionSetValue); 
			}
		}

		/// <summary>
        /// emailpassword
        /// </summary>
		[DisplayName("emailpassword")]
		[AttributeLogicalName("emailpassword")]
		public string Emailpassword
		{	
			get { return GetAttributeValue<string>("emailpassword"); }
			set
			{ 
				if(value == Emailpassword) return;
				SetAttributeValue("emailpassword", value);
			}
		}	
			
		/// <summary>
        /// emailusername
        /// </summary>
		[DisplayName("emailusername")]
		[AttributeLogicalName("emailusername")]
		public string Emailusername
		{	
			get { return GetAttributeValue<string>("emailusername"); }
			set
			{ 
				if(value == Emailusername) return;
				SetAttributeValue("emailusername", value);
			}
		}	
			
		/// <summary>
        /// entityformmode
        /// </summary>
		[DisplayName("Form Mode")]
		[AttributeLogicalName("entityformmode")]
		public eEntityFormMode? FormMode
		{	
			get 
			{ 
				var optionSetValue = GetAttributeValue<OptionSetValue>("entityformmode");
				if (optionSetValue != null) return (eEntityFormMode)optionSetValue.Value;
				else return null;
			}
			set 
			{ 
				if(value == FormMode) return;

				OptionSetValue optionSetValue = null;
				if(value != null) optionSetValue = new OptionSetValue((int)value);
				SetAttributeValue("entityformmode", optionSetValue); 
			}
		}

		/// <summary>
        /// fullnameconventioncode
        /// </summary>
		[DisplayName("fullnameconventioncode")]
		[AttributeLogicalName("fullnameconventioncode")]
		public int? Fullnameconventioncode
		{	
			get { return GetAttributeValue<int?>("fullnameconventioncode"); }
			set
			{ 
				if(value == Fullnameconventioncode) return;
				SetAttributeValue("fullnameconventioncode", value);
			}
		}	
			
		/// <summary>
        /// getstartedpanecontentenabled
        /// </summary>
		[DisplayName("getstartedpanecontentenabled")]
		[AttributeLogicalName("getstartedpanecontentenabled")]
		public bool? Getstartedpanecontentenabled
		{	
			get { return GetAttributeValue<bool?>("getstartedpanecontentenabled"); }
			set
			{ 
				if(value == Getstartedpanecontentenabled) return;
				SetAttributeValue("getstartedpanecontentenabled", value);
			}
		}	
			
		/// <summary>
        /// helplanguageid
        /// </summary>
		[DisplayName("helplanguageid")]
		[AttributeLogicalName("helplanguageid")]
		public int? Helplanguageid
		{	
			get { return GetAttributeValue<int?>("helplanguageid"); }
			set
			{ 
				if(value == Helplanguageid) return;
				SetAttributeValue("helplanguageid", value);
			}
		}	
			
		/// <summary>
        /// homepagearea
        /// </summary>
		[DisplayName("homepagearea")]
		[AttributeLogicalName("homepagearea")]
		public string Homepagearea
		{	
			get { return GetAttributeValue<string>("homepagearea"); }
			set
			{ 
				if(value == Homepagearea) return;
				SetAttributeValue("homepagearea", value);
			}
		}	
			
		/// <summary>
        /// homepagelayout
        /// </summary>
		[DisplayName("homepagelayout")]
		[AttributeLogicalName("homepagelayout")]
		public string Homepagelayout
		{	
			get { return GetAttributeValue<string>("homepagelayout"); }
			set
			{ 
				if(value == Homepagelayout) return;
				SetAttributeValue("homepagelayout", value);
			}
		}	
			
		/// <summary>
        /// homepagesubarea
        /// </summary>
		[DisplayName("homepagesubarea")]
		[AttributeLogicalName("homepagesubarea")]
		public string Homepagesubarea
		{	
			get { return GetAttributeValue<string>("homepagesubarea"); }
			set
			{ 
				if(value == Homepagesubarea) return;
				SetAttributeValue("homepagesubarea", value);
			}
		}	
			
		/// <summary>
        /// ignoreunsolicitedemail
        /// </summary>
		[DisplayName("ignoreunsolicitedemail")]
		[AttributeLogicalName("ignoreunsolicitedemail")]
		public bool? Ignoreunsolicitedemail
		{	
			get { return GetAttributeValue<bool?>("ignoreunsolicitedemail"); }
			set
			{ 
				if(value == Ignoreunsolicitedemail) return;
				SetAttributeValue("ignoreunsolicitedemail", value);
			}
		}	
			
		/// <summary>
        /// incomingemailfilteringmethod
        /// </summary>
		[DisplayName("Incoming Email Filtering Method")]
		[AttributeLogicalName("incomingemailfilteringmethod")]
		public eIncomingEmailFilteringMethod? IncomingEmailFilteringMethod
		{	
			get 
			{ 
				var optionSetValue = GetAttributeValue<OptionSetValue>("incomingemailfilteringmethod");
				if (optionSetValue != null) return (eIncomingEmailFilteringMethod)optionSetValue.Value;
				else return null;
			}
			set 
			{ 
				if(value == IncomingEmailFilteringMethod) return;

				OptionSetValue optionSetValue = null;
				if(value != null) optionSetValue = new OptionSetValue((int)value);
				SetAttributeValue("incomingemailfilteringmethod", optionSetValue); 
			}
		}

		/// <summary>
        /// isappsforcrmalertdismissed
        /// </summary>
		[DisplayName("Show alert for Apps for 365.")]
		[AttributeLogicalName("isappsforcrmalertdismissed")]
		public bool? ShowAlertForAppsFor365
		{	
			get { return GetAttributeValue<bool?>("isappsforcrmalertdismissed"); }
			set
			{ 
				if(value == ShowAlertForAppsFor365) return;
				SetAttributeValue("isappsforcrmalertdismissed", value);
			}
		}	
			
		/// <summary>
        /// isautodatacaptureenabled
        /// </summary>
		[DisplayName("isautodatacaptureenabled")]
		[AttributeLogicalName("isautodatacaptureenabled")]
		public bool? Isautodatacaptureenabled
		{	
			get { return GetAttributeValue<bool?>("isautodatacaptureenabled"); }
			set
			{ 
				if(value == Isautodatacaptureenabled) return;
				SetAttributeValue("isautodatacaptureenabled", value);
			}
		}	
			
		/// <summary>
        /// isdefaultcountrycodecheckenabled
        /// </summary>
		[DisplayName("Enable Default Country Code")]
		[AttributeLogicalName("isdefaultcountrycodecheckenabled")]
		public bool? EnableDefaultCountryCode
		{	
			get { return GetAttributeValue<bool?>("isdefaultcountrycodecheckenabled"); }
			set
			{ 
				if(value == EnableDefaultCountryCode) return;
				SetAttributeValue("isdefaultcountrycodecheckenabled", value);
			}
		}	
			
		/// <summary>
        /// isduplicatedetectionenabledwhengoingonline
        /// </summary>
		[DisplayName("isduplicatedetectionenabledwhengoingonline")]
		[AttributeLogicalName("isduplicatedetectionenabledwhengoingonline")]
		public bool? Isduplicatedetectionenabledwhengoingonline
		{	
			get { return GetAttributeValue<bool?>("isduplicatedetectionenabledwhengoingonline"); }
			set
			{ 
				if(value == Isduplicatedetectionenabledwhengoingonline) return;
				SetAttributeValue("isduplicatedetectionenabledwhengoingonline", value);
			}
		}	
			
		/// <summary>
        /// isemailconversationviewenabled
        /// </summary>
		[DisplayName("isemailconversationviewenabled")]
		[AttributeLogicalName("isemailconversationviewenabled")]
		public bool? Isemailconversationviewenabled
		{	
			get { return GetAttributeValue<bool?>("isemailconversationviewenabled"); }
			set
			{ 
				if(value == Isemailconversationviewenabled) return;
				SetAttributeValue("isemailconversationviewenabled", value);
			}
		}	
			
		/// <summary>
        /// isguidedhelpenabled
        /// </summary>
		[DisplayName("Enable Default Guided Help")]
		[AttributeLogicalName("isguidedhelpenabled")]
		public bool? EnableDefaultGuidedHelp
		{	
			get { return GetAttributeValue<bool?>("isguidedhelpenabled"); }
			set
			{ 
				if(value == EnableDefaultGuidedHelp) return;
				SetAttributeValue("isguidedhelpenabled", value);
			}
		}	
			
		/// <summary>
        /// isresourcebookingexchangesyncenabled
        /// </summary>
		[DisplayName("Resource booking synchronization enabled")]
		[AttributeLogicalName("isresourcebookingexchangesyncenabled")]
		public bool? ResourceBookingSynchronizationEnabled
		{	
			get { return GetAttributeValue<bool?>("isresourcebookingexchangesyncenabled"); }
			set
			{ 
				if(value == ResourceBookingSynchronizationEnabled) return;
				SetAttributeValue("isresourcebookingexchangesyncenabled", value);
			}
		}	
			
		/// <summary>
        /// issendasallowed
        /// </summary>
		[DisplayName("issendasallowed")]
		[AttributeLogicalName("issendasallowed")]
		public bool? Issendasallowed
		{	
			get { return GetAttributeValue<bool?>("issendasallowed"); }
			set
			{ 
				if(value == Issendasallowed) return;
				SetAttributeValue("issendasallowed", value);
			}
		}	
			
		/// <summary>
        /// lastalertsviewedtime
        /// </summary>
		[DisplayName("lastalertsviewedtime")]
		[AttributeLogicalName("lastalertsviewedtime")]
		public DateTime? Lastalertsviewedtime
		{	
			get { return GetAttributeValue<DateTime?>("lastalertsviewedtime"); }
			set
			{ 
				if(value == Lastalertsviewedtime) return;
				SetAttributeValue("lastalertsviewedtime", value);
			}
		}	
			
		/// <summary>
        /// localeid
        /// </summary>
		[DisplayName("localeid")]
		[AttributeLogicalName("localeid")]
		public int? Localeid
		{	
			get { return GetAttributeValue<int?>("localeid"); }
			set
			{ 
				if(value == Localeid) return;
				SetAttributeValue("localeid", value);
			}
		}	
			
		/// <summary>
        /// longdateformatcode
        /// </summary>
		[DisplayName("longdateformatcode")]
		[AttributeLogicalName("longdateformatcode")]
		public int? Longdateformatcode
		{	
			get { return GetAttributeValue<int?>("longdateformatcode"); }
			set
			{ 
				if(value == Longdateformatcode) return;
				SetAttributeValue("longdateformatcode", value);
			}
		}	
			
		/// <summary>
        /// modifiedby
        /// </summary>
		[DisplayName("modifiedby")]
		[AttributeLogicalName("modifiedby")]
		public EntityReference Modifiedby
		{	
			get { return GetAttributeValue<EntityReference>("modifiedby"); }
			set
			{ 
				if(value == Modifiedby) return;
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
		[DisplayName("modifiedon")]
		[AttributeLogicalName("modifiedon")]
		public DateTime? Modifiedon
		{	
			get { return GetAttributeValue<DateTime?>("modifiedon"); }
			set
			{ 
				if(value == Modifiedon) return;
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
        /// negativecurrencyformatcode
        /// </summary>
		[DisplayName("negativecurrencyformatcode")]
		[AttributeLogicalName("negativecurrencyformatcode")]
		public int? Negativecurrencyformatcode
		{	
			get { return GetAttributeValue<int?>("negativecurrencyformatcode"); }
			set
			{ 
				if(value == Negativecurrencyformatcode) return;
				SetAttributeValue("negativecurrencyformatcode", value);
			}
		}	
			
		/// <summary>
        /// negativeformatcode
        /// </summary>
		[DisplayName("negativeformatcode")]
		[AttributeLogicalName("negativeformatcode")]
		public int? Negativeformatcode
		{	
			get { return GetAttributeValue<int?>("negativeformatcode"); }
			set
			{ 
				if(value == Negativeformatcode) return;
				SetAttributeValue("negativeformatcode", value);
			}
		}	
			
		/// <summary>
        /// nexttrackingnumber
        /// </summary>
		[DisplayName("nexttrackingnumber")]
		[AttributeLogicalName("nexttrackingnumber")]
		public int? Nexttrackingnumber
		{	
			get { return GetAttributeValue<int?>("nexttrackingnumber"); }
			set
			{ 
				if(value == Nexttrackingnumber) return;
				SetAttributeValue("nexttrackingnumber", value);
			}
		}	
			
		/// <summary>
        /// numbergroupformat
        /// </summary>
		[DisplayName("numbergroupformat")]
		[AttributeLogicalName("numbergroupformat")]
		public string Numbergroupformat
		{	
			get { return GetAttributeValue<string>("numbergroupformat"); }
			set
			{ 
				if(value == Numbergroupformat) return;
				SetAttributeValue("numbergroupformat", value);
			}
		}	
			
		/// <summary>
        /// numberseparator
        /// </summary>
		[DisplayName("numberseparator")]
		[AttributeLogicalName("numberseparator")]
		public string Numberseparator
		{	
			get { return GetAttributeValue<string>("numberseparator"); }
			set
			{ 
				if(value == Numberseparator) return;
				SetAttributeValue("numberseparator", value);
			}
		}	
			
		/// <summary>
        /// offlinesyncinterval
        /// </summary>
		[DisplayName("offlinesyncinterval")]
		[AttributeLogicalName("offlinesyncinterval")]
		public int? Offlinesyncinterval
		{	
			get { return GetAttributeValue<int?>("offlinesyncinterval"); }
			set
			{ 
				if(value == Offlinesyncinterval) return;
				SetAttributeValue("offlinesyncinterval", value);
			}
		}	
			
		/// <summary>
        /// outlooksyncinterval
        /// </summary>
		[DisplayName("outlooksyncinterval")]
		[AttributeLogicalName("outlooksyncinterval")]
		public int? Outlooksyncinterval
		{	
			get { return GetAttributeValue<int?>("outlooksyncinterval"); }
			set
			{ 
				if(value == Outlooksyncinterval) return;
				SetAttributeValue("outlooksyncinterval", value);
			}
		}	
			
		/// <summary>
        /// paginglimit
        /// </summary>
		[DisplayName("paginglimit")]
		[AttributeLogicalName("paginglimit")]
		public int? Paginglimit
		{	
			get { return GetAttributeValue<int?>("paginglimit"); }
			set
			{ 
				if(value == Paginglimit) return;
				SetAttributeValue("paginglimit", value);
			}
		}	
			
		/// <summary>
        /// personalizationsettings
        /// </summary>
		[DisplayName("personalizationsettings")]
		[AttributeLogicalName("personalizationsettings")]
		public string Personalizationsettings
		{	
			get { return GetAttributeValue<string>("personalizationsettings"); }
			set
			{ 
				if(value == Personalizationsettings) return;
				SetAttributeValue("personalizationsettings", value);
			}
		}	
			
		/// <summary>
        /// pmdesignator
        /// </summary>
		[DisplayName("pmdesignator")]
		[AttributeLogicalName("pmdesignator")]
		public string Pmdesignator
		{	
			get { return GetAttributeValue<string>("pmdesignator"); }
			set
			{ 
				if(value == Pmdesignator) return;
				SetAttributeValue("pmdesignator", value);
			}
		}	
			
		/// <summary>
        /// pricingdecimalprecision
        /// </summary>
		[DisplayName("pricingdecimalprecision")]
		[AttributeLogicalName("pricingdecimalprecision")]
		public int? Pricingdecimalprecision
		{	
			get { return GetAttributeValue<int?>("pricingdecimalprecision"); }
			set
			{ 
				if(value == Pricingdecimalprecision) return;
				SetAttributeValue("pricingdecimalprecision", value);
			}
		}	
			
		/// <summary>
        /// reportscripterrors
        /// </summary>
		[DisplayName("Report Script Errors")]
		[AttributeLogicalName("reportscripterrors")]
		public eReportScriptErrors? ReportScriptErrors
		{	
			get 
			{ 
				var optionSetValue = GetAttributeValue<OptionSetValue>("reportscripterrors");
				if (optionSetValue != null) return (eReportScriptErrors)optionSetValue.Value;
				else return null;
			}
			set 
			{ 
				if(value == ReportScriptErrors) return;

				OptionSetValue optionSetValue = null;
				if(value != null) optionSetValue = new OptionSetValue((int)value);
				SetAttributeValue("reportscripterrors", optionSetValue); 
			}
		}

		/// <summary>
        /// resourcebookingexchangesyncversion
        /// </summary>
		[DisplayName("User resource booking synchronization version")]
		[AttributeLogicalName("resourcebookingexchangesyncversion")]
		public int? UserResourceBookingSynchronizationVersion
		{	
			get { return GetAttributeValue<int?>("resourcebookingexchangesyncversion"); }
			set
			{ 
				if(value == UserResourceBookingSynchronizationVersion) return;
				SetAttributeValue("resourcebookingexchangesyncversion", value);
			}
		}	
			
		/// <summary>
        /// selectedglobalfilterid
        /// </summary>
		[DisplayName("selectedglobalfilterid")]
		[AttributeLogicalName("selectedglobalfilterid")]
		public Guid SelectedglobalfilterId
		{	
			get { return GetAttributeValue<Guid>("selectedglobalfilterid"); }
			set
			{ 
				if(value == SelectedglobalfilterId) return;
				SetAttributeValue("selectedglobalfilterid", value);
			}
		}	
			
		/// <summary>
        /// showweeknumber
        /// </summary>
		[DisplayName("showweeknumber")]
		[AttributeLogicalName("showweeknumber")]
		public bool? Showweeknumber
		{	
			get { return GetAttributeValue<bool?>("showweeknumber"); }
			set
			{ 
				if(value == Showweeknumber) return;
				SetAttributeValue("showweeknumber", value);
			}
		}	
			
		/// <summary>
        /// splitviewstate
        /// </summary>
		[DisplayName("splitviewstate")]
		[AttributeLogicalName("splitviewstate")]
		public bool? Splitviewstate
		{	
			get { return GetAttributeValue<bool?>("splitviewstate"); }
			set
			{ 
				if(value == Splitviewstate) return;
				SetAttributeValue("splitviewstate", value);
			}
		}	
			
		/// <summary>
        /// synccontactcompany
        /// </summary>
		[DisplayName("synccontactcompany")]
		[AttributeLogicalName("synccontactcompany")]
		public bool? Synccontactcompany
		{	
			get { return GetAttributeValue<bool?>("synccontactcompany"); }
			set
			{ 
				if(value == Synccontactcompany) return;
				SetAttributeValue("synccontactcompany", value);
			}
		}	
			
		/// <summary>
        /// systemuserid
        /// </summary>
		[DisplayName("systemuserid")]
		[AttributeLogicalName("systemuserid")]
		public override Guid Id
		{
			get => base.Id;
			set { base.Id = value; SetAttributeValue("systemuserid", value); }
		}

							/// <summary>
        /// timeformatcode
        /// </summary>
		[DisplayName("timeformatcode")]
		[AttributeLogicalName("timeformatcode")]
		public int? Timeformatcode
		{	
			get { return GetAttributeValue<int?>("timeformatcode"); }
			set
			{ 
				if(value == Timeformatcode) return;
				SetAttributeValue("timeformatcode", value);
			}
		}	
			
		/// <summary>
        /// timeformatstring
        /// </summary>
		[DisplayName("timeformatstring")]
		[AttributeLogicalName("timeformatstring")]
		public string Timeformatstring
		{	
			get { return GetAttributeValue<string>("timeformatstring"); }
			set
			{ 
				if(value == Timeformatstring) return;
				SetAttributeValue("timeformatstring", value);
			}
		}	
			
		/// <summary>
        /// timeseparator
        /// </summary>
		[DisplayName("timeseparator")]
		[AttributeLogicalName("timeseparator")]
		public string Timeseparator
		{	
			get { return GetAttributeValue<string>("timeseparator"); }
			set
			{ 
				if(value == Timeseparator) return;
				SetAttributeValue("timeseparator", value);
			}
		}	
			
		/// <summary>
        /// timezonebias
        /// </summary>
		[DisplayName("timezonebias")]
		[AttributeLogicalName("timezonebias")]
		public int? Timezonebias
		{	
			get { return GetAttributeValue<int?>("timezonebias"); }
			set
			{ 
				if(value == Timezonebias) return;
				SetAttributeValue("timezonebias", value);
			}
		}	
			
		/// <summary>
        /// timezonecode
        /// </summary>
		[DisplayName("timezonecode")]
		[AttributeLogicalName("timezonecode")]
		public int? Timezonecode
		{	
			get { return GetAttributeValue<int?>("timezonecode"); }
			set
			{ 
				if(value == Timezonecode) return;
				SetAttributeValue("timezonecode", value);
			}
		}	
			
		/// <summary>
        /// timezonedaylightbias
        /// </summary>
		[DisplayName("timezonedaylightbias")]
		[AttributeLogicalName("timezonedaylightbias")]
		public int? Timezonedaylightbias
		{	
			get { return GetAttributeValue<int?>("timezonedaylightbias"); }
			set
			{ 
				if(value == Timezonedaylightbias) return;
				SetAttributeValue("timezonedaylightbias", value);
			}
		}	
			
		/// <summary>
        /// timezonedaylightday
        /// </summary>
		[DisplayName("timezonedaylightday")]
		[AttributeLogicalName("timezonedaylightday")]
		public int? Timezonedaylightday
		{	
			get { return GetAttributeValue<int?>("timezonedaylightday"); }
			set
			{ 
				if(value == Timezonedaylightday) return;
				SetAttributeValue("timezonedaylightday", value);
			}
		}	
			
		/// <summary>
        /// timezonedaylightdayofweek
        /// </summary>
		[DisplayName("timezonedaylightdayofweek")]
		[AttributeLogicalName("timezonedaylightdayofweek")]
		public int? Timezonedaylightdayofweek
		{	
			get { return GetAttributeValue<int?>("timezonedaylightdayofweek"); }
			set
			{ 
				if(value == Timezonedaylightdayofweek) return;
				SetAttributeValue("timezonedaylightdayofweek", value);
			}
		}	
			
		/// <summary>
        /// timezonedaylighthour
        /// </summary>
		[DisplayName("timezonedaylighthour")]
		[AttributeLogicalName("timezonedaylighthour")]
		public int? Timezonedaylighthour
		{	
			get { return GetAttributeValue<int?>("timezonedaylighthour"); }
			set
			{ 
				if(value == Timezonedaylighthour) return;
				SetAttributeValue("timezonedaylighthour", value);
			}
		}	
			
		/// <summary>
        /// timezonedaylightminute
        /// </summary>
		[DisplayName("timezonedaylightminute")]
		[AttributeLogicalName("timezonedaylightminute")]
		public int? Timezonedaylightminute
		{	
			get { return GetAttributeValue<int?>("timezonedaylightminute"); }
			set
			{ 
				if(value == Timezonedaylightminute) return;
				SetAttributeValue("timezonedaylightminute", value);
			}
		}	
			
		/// <summary>
        /// timezonedaylightmonth
        /// </summary>
		[DisplayName("timezonedaylightmonth")]
		[AttributeLogicalName("timezonedaylightmonth")]
		public int? Timezonedaylightmonth
		{	
			get { return GetAttributeValue<int?>("timezonedaylightmonth"); }
			set
			{ 
				if(value == Timezonedaylightmonth) return;
				SetAttributeValue("timezonedaylightmonth", value);
			}
		}	
			
		/// <summary>
        /// timezonedaylightsecond
        /// </summary>
		[DisplayName("timezonedaylightsecond")]
		[AttributeLogicalName("timezonedaylightsecond")]
		public int? Timezonedaylightsecond
		{	
			get { return GetAttributeValue<int?>("timezonedaylightsecond"); }
			set
			{ 
				if(value == Timezonedaylightsecond) return;
				SetAttributeValue("timezonedaylightsecond", value);
			}
		}	
			
		/// <summary>
        /// timezonedaylightyear
        /// </summary>
		[DisplayName("timezonedaylightyear")]
		[AttributeLogicalName("timezonedaylightyear")]
		public int? Timezonedaylightyear
		{	
			get { return GetAttributeValue<int?>("timezonedaylightyear"); }
			set
			{ 
				if(value == Timezonedaylightyear) return;
				SetAttributeValue("timezonedaylightyear", value);
			}
		}	
			
		/// <summary>
        /// timezonestandardbias
        /// </summary>
		[DisplayName("timezonestandardbias")]
		[AttributeLogicalName("timezonestandardbias")]
		public int? Timezonestandardbias
		{	
			get { return GetAttributeValue<int?>("timezonestandardbias"); }
			set
			{ 
				if(value == Timezonestandardbias) return;
				SetAttributeValue("timezonestandardbias", value);
			}
		}	
			
		/// <summary>
        /// timezonestandardday
        /// </summary>
		[DisplayName("timezonestandardday")]
		[AttributeLogicalName("timezonestandardday")]
		public int? Timezonestandardday
		{	
			get { return GetAttributeValue<int?>("timezonestandardday"); }
			set
			{ 
				if(value == Timezonestandardday) return;
				SetAttributeValue("timezonestandardday", value);
			}
		}	
			
		/// <summary>
        /// timezonestandarddayofweek
        /// </summary>
		[DisplayName("timezonestandarddayofweek")]
		[AttributeLogicalName("timezonestandarddayofweek")]
		public int? Timezonestandarddayofweek
		{	
			get { return GetAttributeValue<int?>("timezonestandarddayofweek"); }
			set
			{ 
				if(value == Timezonestandarddayofweek) return;
				SetAttributeValue("timezonestandarddayofweek", value);
			}
		}	
			
		/// <summary>
        /// timezonestandardhour
        /// </summary>
		[DisplayName("timezonestandardhour")]
		[AttributeLogicalName("timezonestandardhour")]
		public int? Timezonestandardhour
		{	
			get { return GetAttributeValue<int?>("timezonestandardhour"); }
			set
			{ 
				if(value == Timezonestandardhour) return;
				SetAttributeValue("timezonestandardhour", value);
			}
		}	
			
		/// <summary>
        /// timezonestandardminute
        /// </summary>
		[DisplayName("timezonestandardminute")]
		[AttributeLogicalName("timezonestandardminute")]
		public int? Timezonestandardminute
		{	
			get { return GetAttributeValue<int?>("timezonestandardminute"); }
			set
			{ 
				if(value == Timezonestandardminute) return;
				SetAttributeValue("timezonestandardminute", value);
			}
		}	
			
		/// <summary>
        /// timezonestandardmonth
        /// </summary>
		[DisplayName("timezonestandardmonth")]
		[AttributeLogicalName("timezonestandardmonth")]
		public int? Timezonestandardmonth
		{	
			get { return GetAttributeValue<int?>("timezonestandardmonth"); }
			set
			{ 
				if(value == Timezonestandardmonth) return;
				SetAttributeValue("timezonestandardmonth", value);
			}
		}	
			
		/// <summary>
        /// timezonestandardsecond
        /// </summary>
		[DisplayName("timezonestandardsecond")]
		[AttributeLogicalName("timezonestandardsecond")]
		public int? Timezonestandardsecond
		{	
			get { return GetAttributeValue<int?>("timezonestandardsecond"); }
			set
			{ 
				if(value == Timezonestandardsecond) return;
				SetAttributeValue("timezonestandardsecond", value);
			}
		}	
			
		/// <summary>
        /// timezonestandardyear
        /// </summary>
		[DisplayName("timezonestandardyear")]
		[AttributeLogicalName("timezonestandardyear")]
		public int? Timezonestandardyear
		{	
			get { return GetAttributeValue<int?>("timezonestandardyear"); }
			set
			{ 
				if(value == Timezonestandardyear) return;
				SetAttributeValue("timezonestandardyear", value);
			}
		}	
			
		/// <summary>
        /// trackingtokenid
        /// </summary>
		[DisplayName("trackingtokenid")]
		[AttributeLogicalName("trackingtokenid")]
		public int? Trackingtokenid
		{	
			get { return GetAttributeValue<int?>("trackingtokenid"); }
			set
			{ 
				if(value == Trackingtokenid) return;
				SetAttributeValue("trackingtokenid", value);
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
        /// uilanguageid
        /// </summary>
		[DisplayName("uilanguageid")]
		[AttributeLogicalName("uilanguageid")]
		public int? Uilanguageid
		{	
			get { return GetAttributeValue<int?>("uilanguageid"); }
			set
			{ 
				if(value == Uilanguageid) return;
				SetAttributeValue("uilanguageid", value);
			}
		}	
			
		/// <summary>
        /// usecrmformforappointment
        /// </summary>
		[DisplayName("usecrmformforappointment")]
		[AttributeLogicalName("usecrmformforappointment")]
		public bool? Usecrmformforappointment
		{	
			get { return GetAttributeValue<bool?>("usecrmformforappointment"); }
			set
			{ 
				if(value == Usecrmformforappointment) return;
				SetAttributeValue("usecrmformforappointment", value);
			}
		}	
			
		/// <summary>
        /// usecrmformforcontact
        /// </summary>
		[DisplayName("usecrmformforcontact")]
		[AttributeLogicalName("usecrmformforcontact")]
		public bool? Usecrmformforcontact
		{	
			get { return GetAttributeValue<bool?>("usecrmformforcontact"); }
			set
			{ 
				if(value == Usecrmformforcontact) return;
				SetAttributeValue("usecrmformforcontact", value);
			}
		}	
			
		/// <summary>
        /// usecrmformforemail
        /// </summary>
		[DisplayName("usecrmformforemail")]
		[AttributeLogicalName("usecrmformforemail")]
		public bool? Usecrmformforemail
		{	
			get { return GetAttributeValue<bool?>("usecrmformforemail"); }
			set
			{ 
				if(value == Usecrmformforemail) return;
				SetAttributeValue("usecrmformforemail", value);
			}
		}	
			
		/// <summary>
        /// usecrmformfortask
        /// </summary>
		[DisplayName("usecrmformfortask")]
		[AttributeLogicalName("usecrmformfortask")]
		public bool? Usecrmformfortask
		{	
			get { return GetAttributeValue<bool?>("usecrmformfortask"); }
			set
			{ 
				if(value == Usecrmformfortask) return;
				SetAttributeValue("usecrmformfortask", value);
			}
		}	
			
		/// <summary>
        /// useimagestrips
        /// </summary>
		[DisplayName("useimagestrips")]
		[AttributeLogicalName("useimagestrips")]
		public bool? Useimagestrips
		{	
			get { return GetAttributeValue<bool?>("useimagestrips"); }
			set
			{ 
				if(value == Useimagestrips) return;
				SetAttributeValue("useimagestrips", value);
			}
		}	
			
		/// <summary>
        /// userprofile
        /// </summary>
		[DisplayName("userprofile")]
		[AttributeLogicalName("userprofile")]
		public string Userprofile
		{	
			get { return GetAttributeValue<string>("userprofile"); }
			set
			{ 
				if(value == Userprofile) return;
				SetAttributeValue("userprofile", value);
			}
		}	
			
		/// <summary>
        /// versionnumber
        /// </summary>
		[DisplayName("versionnumber")]
		[AttributeLogicalName("versionnumber")]
		public int? Versionnumber
		{	
			get { return GetAttributeValue<int?>("versionnumber"); }
			set
			{ 
				if(value == Versionnumber) return;
				SetAttributeValue("versionnumber", value);
			}
		}	
			
		/// <summary>
        /// visualizationpanelayout
        /// </summary>
		[DisplayName("Visualization Pane Layout.")]
		[AttributeLogicalName("visualizationpanelayout")]
		public eVisualizationPaneLayout? VisualizationPaneLayout
		{	
			get 
			{ 
				var optionSetValue = GetAttributeValue<OptionSetValue>("visualizationpanelayout");
				if (optionSetValue != null) return (eVisualizationPaneLayout)optionSetValue.Value;
				else return null;
			}
			set 
			{ 
				if(value == VisualizationPaneLayout) return;

				OptionSetValue optionSetValue = null;
				if(value != null) optionSetValue = new OptionSetValue((int)value);
				SetAttributeValue("visualizationpanelayout", optionSetValue); 
			}
		}

		/// <summary>
        /// workdaystarttime
        /// </summary>
		[DisplayName("workdaystarttime")]
		[AttributeLogicalName("workdaystarttime")]
		public string Workdaystarttime
		{	
			get { return GetAttributeValue<string>("workdaystarttime"); }
			set
			{ 
				if(value == Workdaystarttime) return;
				SetAttributeValue("workdaystarttime", value);
			}
		}	
			
		/// <summary>
        /// workdaystoptime
        /// </summary>
		[DisplayName("workdaystoptime")]
		[AttributeLogicalName("workdaystoptime")]
		public string Workdaystoptime
		{	
			get { return GetAttributeValue<string>("workdaystoptime"); }
			set
			{ 
				if(value == Workdaystoptime) return;
				SetAttributeValue("workdaystoptime", value);
			}
		}	
			
		#endregion	

		#region Relations
			#endregion

		#region Actions
		#endregion

		#region OptionSetEnums
		public enum eDataValidationModeForExportToExcel
		{	
		
			[Label("Full")]
			[Description(@"")]
			Full = 0, 
		
			[Label("None")]
			[Description(@"")]
			None = 1, 
		}
		
		public enum eDefaultSearchExperience
		{	
		
			[Label("Use last search")]
			[Description(@"")]
			UseLastSearch = 2, 
		
			[Label("Relevance search")]
			[Description(@"")]
			RelevanceSearch = 0, 
		
			[Label("Categorized search")]
			[Description(@"")]
			CategorizedSearch = 1, 
		
			[Label("Custom search")]
			[Description(@"")]
			CustomSearch = 3, 
		}
		
		public enum eEntityFormMode
		{	
		
			[Label("Organization default")]
			[Description(@"")]
			OrganizationDefault = 0, 
		
			[Label("Read-optimized")]
			[Description(@"")]
			Readoptimized = 1, 
		
			[Label("Edit")]
			[Description(@"")]
			Edit = 2, 
		}
		
		public enum eIncomingEmailFilteringMethod
		{	
		
			[Label("All email messages")]
			[Description(@"")]
			AllEmailMessages = 0, 
		
			[Label("Email messages in response to Dynamics 365 email")]
			[Description(@"")]
			EmailMessagesInResponseToDynamics365Email = 1, 
		
			[Label("Email messages from Dynamics 365 Leads, Contacts and Accounts")]
			[Description(@"")]
			EmailMessagesFromDynamics365LeadsContactsAndAccounts = 2, 
		
			[Label("Email messages from Dynamics 365 records that are email enabled")]
			[Description(@"")]
			EmailMessagesFromDynamics365RecordsThatAreEmailEnabled = 3, 
		
			[Label("No email messages")]
			[Description(@"")]
			NoEmailMessages = 4, 
		}
		
		public enum eReportScriptErrors
		{	
		
			[Label("Ask me for permission to send an error report to Microsoft")]
			[Description(@"")]
			AskMeForPermissionToSendAnErrorReportToMicrosoft = 1, 
		
			[Label("Automatically send an error report to Microsoft without asking me for permission")]
			[Description(@"")]
			AutomaticallySendAnErrorReportToMicrosoftWithoutAskingMeForPermission = 2, 
		
			[Label("Never send an error report to Microsoft about Microsoft Dynamics 365")]
			[Description(@"")]
			NeverSendAnErrorReportToMicrosoftAboutMicrosoftDynamics365 = 3, 
		}
		
		public enum eVisualizationPaneLayout
		{	
		
			[Label("Top-bottom")]
			[Description(@"")]
			Topbottom = 0, 
		
			[Label("Side-by-side")]
			[Description(@"")]
			Sidebyside = 1, 
		}
		
		#endregion	

		#region Properties
		public static class Properties 
		{
			/// <summary>addressbooksyncinterval</summary>
			public const string Addressbooksyncinterval = "addressbooksyncinterval";

			/// <summary>advancedfindstartupmode</summary>
			public const string Advancedfindstartupmode = "advancedfindstartupmode";

			/// <summary>allowemailcredentials</summary>
			public const string Allowemailcredentials = "allowemailcredentials";

			/// <summary>amdesignator</summary>
			public const string Amdesignator = "amdesignator";

			/// <summary>autocaptureuserstatus</summary>
			public const string Autocaptureuserstatus = "autocaptureuserstatus";

			/// <summary>autocreatecontactonpromote</summary>
			public const string Autocreatecontactonpromote = "autocreatecontactonpromote";

			/// <summary>businessunitid</summary>
			public const string BusinessunitId = "businessunitid";

			/// <summary>businessunitidname</summary>
			public const string Businessunitidname = "businessunitidname";

			/// <summary>calendartype</summary>
			public const string Calendartype = "calendartype";

			/// <summary>createdby</summary>
			public const string Createdby = "createdby";

			/// <summary>createdbyname</summary>
			public const string Createdbyname = "createdbyname";

			/// <summary>createdbyyominame</summary>
			public const string Createdbyyominame = "createdbyyominame";

			/// <summary>createdon</summary>
			public const string Createdon = "createdon";

			/// <summary>createdonbehalfby</summary>
			public const string CreatedByDelegate = "createdonbehalfby";

			/// <summary>createdonbehalfbyname</summary>
			public const string Createdonbehalfbyname = "createdonbehalfbyname";

			/// <summary>createdonbehalfbyyominame</summary>
			public const string Createdonbehalfbyyominame = "createdonbehalfbyyominame";

			/// <summary>currencydecimalprecision</summary>
			public const string Currencydecimalprecision = "currencydecimalprecision";

			/// <summary>currencyformatcode</summary>
			public const string Currencyformatcode = "currencyformatcode";

			/// <summary>currencysymbol</summary>
			public const string Currencysymbol = "currencysymbol";

			/// <summary>datavalidationmodeforexporttoexcel</summary>
			public const string DataValidationModeForExportToExcel = "datavalidationmodeforexporttoexcel";

			/// <summary>dateformatcode</summary>
			public const string Dateformatcode = "dateformatcode";

			/// <summary>dateformatstring</summary>
			public const string Dateformatstring = "dateformatstring";

			/// <summary>dateseparator</summary>
			public const string Dateseparator = "dateseparator";

			/// <summary>decimalsymbol</summary>
			public const string Decimalsymbol = "decimalsymbol";

			/// <summary>defaultcalendarview</summary>
			public const string Defaultcalendarview = "defaultcalendarview";

			/// <summary>defaultcountrycode</summary>
			public const string DefaultCountryCode = "defaultcountrycode";

			/// <summary>defaultdashboardid</summary>
			public const string DefaultdashboardId = "defaultdashboardid";

			/// <summary>defaultsearchexperience</summary>
			public const string DefaultSearchExperience = "defaultsearchexperience";

			/// <summary>emailpassword</summary>
			public const string Emailpassword = "emailpassword";

			/// <summary>emailusername</summary>
			public const string Emailusername = "emailusername";

			/// <summary>entityformmode</summary>
			public const string FormMode = "entityformmode";

			/// <summary>fullnameconventioncode</summary>
			public const string Fullnameconventioncode = "fullnameconventioncode";

			/// <summary>getstartedpanecontentenabled</summary>
			public const string Getstartedpanecontentenabled = "getstartedpanecontentenabled";

			/// <summary>helplanguageid</summary>
			public const string Helplanguageid = "helplanguageid";

			/// <summary>homepagearea</summary>
			public const string Homepagearea = "homepagearea";

			/// <summary>homepagelayout</summary>
			public const string Homepagelayout = "homepagelayout";

			/// <summary>homepagesubarea</summary>
			public const string Homepagesubarea = "homepagesubarea";

			/// <summary>ignoreunsolicitedemail</summary>
			public const string Ignoreunsolicitedemail = "ignoreunsolicitedemail";

			/// <summary>incomingemailfilteringmethod</summary>
			public const string IncomingEmailFilteringMethod = "incomingemailfilteringmethod";

			/// <summary>isappsforcrmalertdismissed</summary>
			public const string ShowAlertForAppsFor365 = "isappsforcrmalertdismissed";

			/// <summary>isautodatacaptureenabled</summary>
			public const string Isautodatacaptureenabled = "isautodatacaptureenabled";

			/// <summary>isdefaultcountrycodecheckenabled</summary>
			public const string EnableDefaultCountryCode = "isdefaultcountrycodecheckenabled";

			/// <summary>isduplicatedetectionenabledwhengoingonline</summary>
			public const string Isduplicatedetectionenabledwhengoingonline = "isduplicatedetectionenabledwhengoingonline";

			/// <summary>isemailconversationviewenabled</summary>
			public const string Isemailconversationviewenabled = "isemailconversationviewenabled";

			/// <summary>isguidedhelpenabled</summary>
			public const string EnableDefaultGuidedHelp = "isguidedhelpenabled";

			/// <summary>isresourcebookingexchangesyncenabled</summary>
			public const string ResourceBookingSynchronizationEnabled = "isresourcebookingexchangesyncenabled";

			/// <summary>issendasallowed</summary>
			public const string Issendasallowed = "issendasallowed";

			/// <summary>lastalertsviewedtime</summary>
			public const string Lastalertsviewedtime = "lastalertsviewedtime";

			/// <summary>localeid</summary>
			public const string Localeid = "localeid";

			/// <summary>longdateformatcode</summary>
			public const string Longdateformatcode = "longdateformatcode";

			/// <summary>modifiedby</summary>
			public const string Modifiedby = "modifiedby";

			/// <summary>modifiedbyname</summary>
			public const string Modifiedbyname = "modifiedbyname";

			/// <summary>modifiedbyyominame</summary>
			public const string Modifiedbyyominame = "modifiedbyyominame";

			/// <summary>modifiedon</summary>
			public const string Modifiedon = "modifiedon";

			/// <summary>modifiedonbehalfby</summary>
			public const string ModifiedByDelegate = "modifiedonbehalfby";

			/// <summary>modifiedonbehalfbyname</summary>
			public const string Modifiedonbehalfbyname = "modifiedonbehalfbyname";

			/// <summary>modifiedonbehalfbyyominame</summary>
			public const string Modifiedonbehalfbyyominame = "modifiedonbehalfbyyominame";

			/// <summary>negativecurrencyformatcode</summary>
			public const string Negativecurrencyformatcode = "negativecurrencyformatcode";

			/// <summary>negativeformatcode</summary>
			public const string Negativeformatcode = "negativeformatcode";

			/// <summary>nexttrackingnumber</summary>
			public const string Nexttrackingnumber = "nexttrackingnumber";

			/// <summary>numbergroupformat</summary>
			public const string Numbergroupformat = "numbergroupformat";

			/// <summary>numberseparator</summary>
			public const string Numberseparator = "numberseparator";

			/// <summary>offlinesyncinterval</summary>
			public const string Offlinesyncinterval = "offlinesyncinterval";

			/// <summary>outlooksyncinterval</summary>
			public const string Outlooksyncinterval = "outlooksyncinterval";

			/// <summary>paginglimit</summary>
			public const string Paginglimit = "paginglimit";

			/// <summary>personalizationsettings</summary>
			public const string Personalizationsettings = "personalizationsettings";

			/// <summary>pmdesignator</summary>
			public const string Pmdesignator = "pmdesignator";

			/// <summary>pricingdecimalprecision</summary>
			public const string Pricingdecimalprecision = "pricingdecimalprecision";

			/// <summary>reportscripterrors</summary>
			public const string ReportScriptErrors = "reportscripterrors";

			/// <summary>resourcebookingexchangesyncversion</summary>
			public const string UserResourceBookingSynchronizationVersion = "resourcebookingexchangesyncversion";

			/// <summary>selectedglobalfilterid</summary>
			public const string SelectedglobalfilterId = "selectedglobalfilterid";

			/// <summary>showweeknumber</summary>
			public const string Showweeknumber = "showweeknumber";

			/// <summary>splitviewstate</summary>
			public const string Splitviewstate = "splitviewstate";

			/// <summary>synccontactcompany</summary>
			public const string Synccontactcompany = "synccontactcompany";

			/// <summary>systemuserid</summary>
			public const string SystemuserId = "systemuserid";

			/// <summary>timeformatcode</summary>
			public const string Timeformatcode = "timeformatcode";

			/// <summary>timeformatstring</summary>
			public const string Timeformatstring = "timeformatstring";

			/// <summary>timeseparator</summary>
			public const string Timeseparator = "timeseparator";

			/// <summary>timezonebias</summary>
			public const string Timezonebias = "timezonebias";

			/// <summary>timezonecode</summary>
			public const string Timezonecode = "timezonecode";

			/// <summary>timezonedaylightbias</summary>
			public const string Timezonedaylightbias = "timezonedaylightbias";

			/// <summary>timezonedaylightday</summary>
			public const string Timezonedaylightday = "timezonedaylightday";

			/// <summary>timezonedaylightdayofweek</summary>
			public const string Timezonedaylightdayofweek = "timezonedaylightdayofweek";

			/// <summary>timezonedaylighthour</summary>
			public const string Timezonedaylighthour = "timezonedaylighthour";

			/// <summary>timezonedaylightminute</summary>
			public const string Timezonedaylightminute = "timezonedaylightminute";

			/// <summary>timezonedaylightmonth</summary>
			public const string Timezonedaylightmonth = "timezonedaylightmonth";

			/// <summary>timezonedaylightsecond</summary>
			public const string Timezonedaylightsecond = "timezonedaylightsecond";

			/// <summary>timezonedaylightyear</summary>
			public const string Timezonedaylightyear = "timezonedaylightyear";

			/// <summary>timezonestandardbias</summary>
			public const string Timezonestandardbias = "timezonestandardbias";

			/// <summary>timezonestandardday</summary>
			public const string Timezonestandardday = "timezonestandardday";

			/// <summary>timezonestandarddayofweek</summary>
			public const string Timezonestandarddayofweek = "timezonestandarddayofweek";

			/// <summary>timezonestandardhour</summary>
			public const string Timezonestandardhour = "timezonestandardhour";

			/// <summary>timezonestandardminute</summary>
			public const string Timezonestandardminute = "timezonestandardminute";

			/// <summary>timezonestandardmonth</summary>
			public const string Timezonestandardmonth = "timezonestandardmonth";

			/// <summary>timezonestandardsecond</summary>
			public const string Timezonestandardsecond = "timezonestandardsecond";

			/// <summary>timezonestandardyear</summary>
			public const string Timezonestandardyear = "timezonestandardyear";

			/// <summary>trackingtokenid</summary>
			public const string Trackingtokenid = "trackingtokenid";

			/// <summary>transactioncurrencyid</summary>
			public const string Currency = "transactioncurrencyid";

			/// <summary>transactioncurrencyidname</summary>
			public const string Transactioncurrencyidname = "transactioncurrencyidname";

			/// <summary>uilanguageid</summary>
			public const string Uilanguageid = "uilanguageid";

			/// <summary>usecrmformforappointment</summary>
			public const string Usecrmformforappointment = "usecrmformforappointment";

			/// <summary>usecrmformforcontact</summary>
			public const string Usecrmformforcontact = "usecrmformforcontact";

			/// <summary>usecrmformforemail</summary>
			public const string Usecrmformforemail = "usecrmformforemail";

			/// <summary>usecrmformfortask</summary>
			public const string Usecrmformfortask = "usecrmformfortask";

			/// <summary>useimagestrips</summary>
			public const string Useimagestrips = "useimagestrips";

			/// <summary>userprofile</summary>
			public const string Userprofile = "userprofile";

			/// <summary>versionnumber</summary>
			public const string Versionnumber = "versionnumber";

			/// <summary>visualizationpanelayout</summary>
			public const string VisualizationPaneLayout = "visualizationpanelayout";

			/// <summary>workdaystarttime</summary>
			public const string Workdaystarttime = "workdaystarttime";

			/// <summary>workdaystoptime</summary>
			public const string Workdaystoptime = "workdaystoptime";

		}
		#endregion

		#region Schemas
		public static class Schemas 
		{
		}
		#endregion
	}
}

