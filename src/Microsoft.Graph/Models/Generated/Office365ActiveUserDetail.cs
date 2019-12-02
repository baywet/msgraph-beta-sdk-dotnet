// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: Templates\CSharp\Model\EntityType.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// The type Office365Active User Detail.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public partial class Office365ActiveUserDetail : Entity
    {
    
		///<summary>
		/// The Office365ActiveUserDetail constructor
		///</summary>
        public Office365ActiveUserDetail()
        {
            this.ODataType = "microsoft.graph.office365ActiveUserDetail";
        }
	
        /// <summary>
        /// Gets or sets report refresh date.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "reportRefreshDate", Required = Newtonsoft.Json.Required.Default)]
        public Date ReportRefreshDate { get; set; }
    
        /// <summary>
        /// Gets or sets user principal name.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "userPrincipalName", Required = Newtonsoft.Json.Required.Default)]
        public string UserPrincipalName { get; set; }
    
        /// <summary>
        /// Gets or sets display name.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "displayName", Required = Newtonsoft.Json.Required.Default)]
        public string DisplayName { get; set; }
    
        /// <summary>
        /// Gets or sets is deleted.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "isDeleted", Required = Newtonsoft.Json.Required.Default)]
        public bool? IsDeleted { get; set; }
    
        /// <summary>
        /// Gets or sets deleted date.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "deletedDate", Required = Newtonsoft.Json.Required.Default)]
        public Date DeletedDate { get; set; }
    
        /// <summary>
        /// Gets or sets has exchange license.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "hasExchangeLicense", Required = Newtonsoft.Json.Required.Default)]
        public bool? HasExchangeLicense { get; set; }
    
        /// <summary>
        /// Gets or sets has one drive license.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "hasOneDriveLicense", Required = Newtonsoft.Json.Required.Default)]
        public bool? HasOneDriveLicense { get; set; }
    
        /// <summary>
        /// Gets or sets has share point license.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "hasSharePointLicense", Required = Newtonsoft.Json.Required.Default)]
        public bool? HasSharePointLicense { get; set; }
    
        /// <summary>
        /// Gets or sets has skype for business license.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "hasSkypeForBusinessLicense", Required = Newtonsoft.Json.Required.Default)]
        public bool? HasSkypeForBusinessLicense { get; set; }
    
        /// <summary>
        /// Gets or sets has yammer license.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "hasYammerLicense", Required = Newtonsoft.Json.Required.Default)]
        public bool? HasYammerLicense { get; set; }
    
        /// <summary>
        /// Gets or sets has teams license.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "hasTeamsLicense", Required = Newtonsoft.Json.Required.Default)]
        public bool? HasTeamsLicense { get; set; }
    
        /// <summary>
        /// Gets or sets exchange last activity date.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "exchangeLastActivityDate", Required = Newtonsoft.Json.Required.Default)]
        public Date ExchangeLastActivityDate { get; set; }
    
        /// <summary>
        /// Gets or sets one drive last activity date.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "oneDriveLastActivityDate", Required = Newtonsoft.Json.Required.Default)]
        public Date OneDriveLastActivityDate { get; set; }
    
        /// <summary>
        /// Gets or sets share point last activity date.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "sharePointLastActivityDate", Required = Newtonsoft.Json.Required.Default)]
        public Date SharePointLastActivityDate { get; set; }
    
        /// <summary>
        /// Gets or sets skype for business last activity date.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "skypeForBusinessLastActivityDate", Required = Newtonsoft.Json.Required.Default)]
        public Date SkypeForBusinessLastActivityDate { get; set; }
    
        /// <summary>
        /// Gets or sets yammer last activity date.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "yammerLastActivityDate", Required = Newtonsoft.Json.Required.Default)]
        public Date YammerLastActivityDate { get; set; }
    
        /// <summary>
        /// Gets or sets teams last activity date.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "teamsLastActivityDate", Required = Newtonsoft.Json.Required.Default)]
        public Date TeamsLastActivityDate { get; set; }
    
        /// <summary>
        /// Gets or sets exchange license assign date.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "exchangeLicenseAssignDate", Required = Newtonsoft.Json.Required.Default)]
        public Date ExchangeLicenseAssignDate { get; set; }
    
        /// <summary>
        /// Gets or sets one drive license assign date.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "oneDriveLicenseAssignDate", Required = Newtonsoft.Json.Required.Default)]
        public Date OneDriveLicenseAssignDate { get; set; }
    
        /// <summary>
        /// Gets or sets share point license assign date.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "sharePointLicenseAssignDate", Required = Newtonsoft.Json.Required.Default)]
        public Date SharePointLicenseAssignDate { get; set; }
    
        /// <summary>
        /// Gets or sets skype for business license assign date.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "skypeForBusinessLicenseAssignDate", Required = Newtonsoft.Json.Required.Default)]
        public Date SkypeForBusinessLicenseAssignDate { get; set; }
    
        /// <summary>
        /// Gets or sets yammer license assign date.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "yammerLicenseAssignDate", Required = Newtonsoft.Json.Required.Default)]
        public Date YammerLicenseAssignDate { get; set; }
    
        /// <summary>
        /// Gets or sets teams license assign date.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "teamsLicenseAssignDate", Required = Newtonsoft.Json.Required.Default)]
        public Date TeamsLicenseAssignDate { get; set; }
    
        /// <summary>
        /// Gets or sets assigned products.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "assignedProducts", Required = Newtonsoft.Json.Required.Default)]
        public IEnumerable<string> AssignedProducts { get; set; }
    
    }
}

