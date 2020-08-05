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
    /// The type Device Management Cached Report Configuration.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public partial class DeviceManagementCachedReportConfiguration : Entity
    {
    
		///<summary>
		/// The DeviceManagementCachedReportConfiguration constructor
		///</summary>
        public DeviceManagementCachedReportConfiguration()
        {
            this.ODataType = "microsoft.graph.deviceManagementCachedReportConfiguration";
        }
	
        /// <summary>
        /// Gets or sets report name.
        /// Name of the report
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "reportName", Required = Newtonsoft.Json.Required.Default)]
        public string ReportName { get; set; }
    
        /// <summary>
        /// Gets or sets filter.
        /// Filters applied on report creation.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "filter", Required = Newtonsoft.Json.Required.Default)]
        public string Filter { get; set; }
    
        /// <summary>
        /// Gets or sets select.
        /// Columns selected from the report
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "select", Required = Newtonsoft.Json.Required.Default)]
        public IEnumerable<string> Select { get; set; }
    
        /// <summary>
        /// Gets or sets order by.
        /// Ordering of columns in the report
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "orderBy", Required = Newtonsoft.Json.Required.Default)]
        public IEnumerable<string> OrderBy { get; set; }
    
        /// <summary>
        /// Gets or sets metadata.
        /// Caller-managed metadata associated with the report
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "metadata", Required = Newtonsoft.Json.Required.Default)]
        public string Metadata { get; set; }
    
        /// <summary>
        /// Gets or sets status.
        /// Status of the cached report
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "status", Required = Newtonsoft.Json.Required.Default)]
        public DeviceManagementReportStatus? Status { get; set; }
    
        /// <summary>
        /// Gets or sets last refresh date time.
        /// Time that the cached report was last refreshed
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "lastRefreshDateTime", Required = Newtonsoft.Json.Required.Default)]
        public DateTimeOffset? LastRefreshDateTime { get; set; }
    
        /// <summary>
        /// Gets or sets expiration date time.
        /// Time that the cached report expires
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "expirationDateTime", Required = Newtonsoft.Json.Required.Default)]
        public DateTimeOffset? ExpirationDateTime { get; set; }
    
    }
}

