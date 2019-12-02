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
    /// The type Chat Activity Statistics.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public partial class ChatActivityStatistics : ActivityStatistics
    {
    
		///<summary>
		/// The ChatActivityStatistics constructor
		///</summary>
        public ChatActivityStatistics()
        {
            this.ODataType = "microsoft.graph.chatActivityStatistics";
        }
	
        /// <summary>
        /// Gets or sets after hours.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "afterHours", Required = Newtonsoft.Json.Required.Default)]
        public Duration AfterHours { get; set; }
    
    }
}

