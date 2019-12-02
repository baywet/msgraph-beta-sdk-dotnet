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
    /// The type Secure Score.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public partial class SecureScore : Entity
    {
    
		///<summary>
		/// The SecureScore constructor
		///</summary>
        public SecureScore()
        {
            this.ODataType = "microsoft.graph.secureScore";
        }
	
        /// <summary>
        /// Gets or sets active user count.
        /// Active user count of the given tenant.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "activeUserCount", Required = Newtonsoft.Json.Required.Default)]
        public Int32? ActiveUserCount { get; set; }
    
        /// <summary>
        /// Gets or sets average comparative scores.
        /// Average score by different scopes (for example, average by industry, average by seating) and control category (Identity, Data, Device, Apps, Infrastructure) within the scope.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "averageComparativeScores", Required = Newtonsoft.Json.Required.Default)]
        public IEnumerable<AverageComparativeScore> AverageComparativeScores { get; set; }
    
        /// <summary>
        /// Gets or sets azure tenant id.
        /// GUID string for tenant ID.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "azureTenantId", Required = Newtonsoft.Json.Required.Default)]
        public string AzureTenantId { get; set; }
    
        /// <summary>
        /// Gets or sets control scores.
        /// Contains tenant scores for a set of controls.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "controlScores", Required = Newtonsoft.Json.Required.Default)]
        public IEnumerable<ControlScore> ControlScores { get; set; }
    
        /// <summary>
        /// Gets or sets created date time.
        /// The date when the entity is created.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "createdDateTime", Required = Newtonsoft.Json.Required.Default)]
        public DateTimeOffset? CreatedDateTime { get; set; }
    
        /// <summary>
        /// Gets or sets current score.
        /// Tenant current attained score on specified date.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "currentScore", Required = Newtonsoft.Json.Required.Default)]
        public double? CurrentScore { get; set; }
    
        /// <summary>
        /// Gets or sets enabled services.
        /// Microsoft-provided services for the tenant (for example, Exchange online, Skype, Sharepoint).
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "enabledServices", Required = Newtonsoft.Json.Required.Default)]
        public IEnumerable<string> EnabledServices { get; set; }
    
        /// <summary>
        /// Gets or sets licensed user count.
        /// Licensed user count of the given tenant.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "licensedUserCount", Required = Newtonsoft.Json.Required.Default)]
        public Int32? LicensedUserCount { get; set; }
    
        /// <summary>
        /// Gets or sets max score.
        /// Tenant maximum possible score on specified date.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "maxScore", Required = Newtonsoft.Json.Required.Default)]
        public double? MaxScore { get; set; }
    
        /// <summary>
        /// Gets or sets vendor information.
        /// Complex type containing details about the security product/service vendor, provider, and subprovider (for example, vendor=Microsoft; provider=SecureScore). Required.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "vendorInformation", Required = Newtonsoft.Json.Required.Default)]
        public SecurityVendorInformation VendorInformation { get; set; }
    
    }
}

