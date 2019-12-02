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
    /// The type AssignedLicense.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    [JsonConverter(typeof(DerivedTypeConverter))]
    public partial class AssignedLicense
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AssignedLicense"/> class.
        /// </summary>
        public AssignedLicense()
        {
            this.ODataType = "microsoft.graph.assignedLicense";
        }

        /// <summary>
        /// Gets or sets disabledPlans.
        /// A collection of the unique identifiers for plans that have been disabled.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "disabledPlans", Required = Newtonsoft.Json.Required.Default)]
        public IEnumerable<Guid> DisabledPlans { get; set; }
    
        /// <summary>
        /// Gets or sets skuId.
        /// The unique identifier for the SKU.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "skuId", Required = Newtonsoft.Json.Required.Default)]
        public Guid? SkuId { get; set; }
    
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
