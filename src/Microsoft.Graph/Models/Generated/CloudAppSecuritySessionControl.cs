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
    /// The type CloudAppSecuritySessionControl.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public partial class CloudAppSecuritySessionControl : ConditionalAccessSessionControl
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CloudAppSecuritySessionControl"/> class.
        /// </summary>
        public CloudAppSecuritySessionControl()
        {
            this.ODataType = "microsoft.graph.cloudAppSecuritySessionControl";
        }

        /// <summary>
        /// Gets or sets cloudAppSecurityType.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "cloudAppSecurityType", Required = Newtonsoft.Json.Required.Default)]
        public CloudAppSecuritySessionControlType? CloudAppSecurityType { get; set; }
    
    }
}
