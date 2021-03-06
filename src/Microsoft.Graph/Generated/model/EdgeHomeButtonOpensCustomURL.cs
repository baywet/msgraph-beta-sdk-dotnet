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
    /// The type EdgeHomeButtonOpensCustomURL.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public partial class EdgeHomeButtonOpensCustomURL : EdgeHomeButtonConfiguration
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EdgeHomeButtonOpensCustomURL"/> class.
        /// </summary>
        public EdgeHomeButtonOpensCustomURL()
        {
            this.ODataType = "microsoft.graph.edgeHomeButtonOpensCustomURL";
        }

        /// <summary>
        /// Gets or sets homeButtonCustomURL.
        /// The specific URL to load.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "homeButtonCustomURL", Required = Newtonsoft.Json.Required.Default)]
        public string HomeButtonCustomURL { get; set; }
    
    }
}
