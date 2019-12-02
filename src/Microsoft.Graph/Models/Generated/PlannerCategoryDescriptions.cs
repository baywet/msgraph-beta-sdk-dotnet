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
    /// The type PlannerCategoryDescriptions.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    [JsonConverter(typeof(DerivedTypeConverter))]
    public partial class PlannerCategoryDescriptions
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PlannerCategoryDescriptions"/> class.
        /// </summary>
        public PlannerCategoryDescriptions()
        {
            this.ODataType = "microsoft.graph.plannerCategoryDescriptions";
        }

        /// <summary>
        /// Gets or sets category1.
        /// The label associated with Category 1
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "category1", Required = Newtonsoft.Json.Required.Default)]
        public string Category1 { get; set; }
    
        /// <summary>
        /// Gets or sets category2.
        /// The label associated with Category 2
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "category2", Required = Newtonsoft.Json.Required.Default)]
        public string Category2 { get; set; }
    
        /// <summary>
        /// Gets or sets category3.
        /// The label associated with Category 3
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "category3", Required = Newtonsoft.Json.Required.Default)]
        public string Category3 { get; set; }
    
        /// <summary>
        /// Gets or sets category4.
        /// The label associated with Category 4
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "category4", Required = Newtonsoft.Json.Required.Default)]
        public string Category4 { get; set; }
    
        /// <summary>
        /// Gets or sets category5.
        /// The label associated with Category 5
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "category5", Required = Newtonsoft.Json.Required.Default)]
        public string Category5 { get; set; }
    
        /// <summary>
        /// Gets or sets category6.
        /// The label associated with Category 6
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "category6", Required = Newtonsoft.Json.Required.Default)]
        public string Category6 { get; set; }
    
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
