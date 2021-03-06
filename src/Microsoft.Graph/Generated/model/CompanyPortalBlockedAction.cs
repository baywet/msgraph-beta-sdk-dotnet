// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: ComplexType.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// The type CompanyPortalBlockedAction.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    [JsonConverter(typeof(DerivedTypeConverter))]
    public partial class CompanyPortalBlockedAction
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CompanyPortalBlockedAction"/> class.
        /// </summary>
        public CompanyPortalBlockedAction()
        {
            this.ODataType = "microsoft.graph.companyPortalBlockedAction";
        }

        /// <summary>
        /// Gets or sets action.
        /// Device Action. Possible values are: unknown, remove, reset.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "action", Required = Newtonsoft.Json.Required.Default)]
        public CompanyPortalAction? Action { get; set; }
    
        /// <summary>
        /// Gets or sets ownerType.
        /// Device ownership type. Possible values are: unknown, company, personal.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "ownerType", Required = Newtonsoft.Json.Required.Default)]
        public OwnerType? OwnerType { get; set; }
    
        /// <summary>
        /// Gets or sets platform.
        /// Device OS/Platform. Possible values are: android, androidForWork, iOS, macOS, windowsPhone81, windows81AndLater, windows10AndLater, androidWorkProfile, unknown.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "platform", Required = Newtonsoft.Json.Required.Default)]
        public DevicePlatformType? Platform { get; set; }
    
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
