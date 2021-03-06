// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: EntityType.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// The type Classification Job Response.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public partial class ClassificationJobResponse : JobResponseBase
    {
    
		///<summary>
		/// The ClassificationJobResponse constructor
		///</summary>
        public ClassificationJobResponse()
        {
            this.ODataType = "microsoft.graph.classificationJobResponse";
        }
	
        /// <summary>
        /// Gets or sets result.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "result", Required = Newtonsoft.Json.Required.Default)]
        public DetectedSensitiveContentWrapper Result { get; set; }
    
    }
}

