// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: Templates\CSharp\Model\ComplexType.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// The type LicenseInfoDetail.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    [JsonConverter(typeof(DerivedTypeConverter))]
    public partial class LicenseInfoDetail
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LicenseInfoDetail"/> class.
        /// </summary>
        public LicenseInfoDetail()
        {
            this.ODataType = "microsoft.graph.licenseInfoDetail";
        }

        /// <summary>
        /// Gets or sets licenseType.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "licenseType", Required = Newtonsoft.Json.Required.Default)]
        public AzureADLicenseType? LicenseType { get; set; }
    
        /// <summary>
        /// Gets or sets totalLicenseCount.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "totalLicenseCount", Required = Newtonsoft.Json.Required.Default)]
        public Int32? TotalLicenseCount { get; set; }
    
        /// <summary>
        /// Gets or sets totalAssignedCount.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "totalAssignedCount", Required = Newtonsoft.Json.Required.Default)]
        public Int32? TotalAssignedCount { get; set; }
    
        /// <summary>
        /// Gets or sets totalUsageCount.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "totalUsageCount", Required = Newtonsoft.Json.Required.Default)]
        public Int32? TotalUsageCount { get; set; }
    
        /// <summary>
        /// Gets or sets additional data.
        /// </summary>
        [JsonExtensionData(ReadData = true)]
        public IDictionary<string, object> AdditionalData { get; set; }

        /// <summary>
        /// Gets or sets @odata.type.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "@odata.type", Required = Newtonsoft.Json.Required.Default)]
        public string ODataType { get; set; }
    
    }
}
