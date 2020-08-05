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
    /// The type DetectedSensitiveContent.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public partial class DetectedSensitiveContent : DetectedSensitiveContentBase
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DetectedSensitiveContent"/> class.
        /// </summary>
        public DetectedSensitiveContent()
        {
            this.ODataType = "microsoft.graph.detectedSensitiveContent";
        }

        /// <summary>
        /// Gets or sets scope.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "scope", Required = Newtonsoft.Json.Required.Default)]
        public SensitiveTypeScope? Scope { get; set; }
    
    }
}
