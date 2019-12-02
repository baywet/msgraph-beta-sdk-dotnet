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
    /// The type DeviceRestrictionAction.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public partial class DeviceRestrictionAction : DlpActionInfo
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DeviceRestrictionAction"/> class.
        /// </summary>
        public DeviceRestrictionAction()
        {
            this.ODataType = "microsoft.graph.deviceRestrictionAction";
        }

        /// <summary>
        /// Gets or sets restrictionAction.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "restrictionAction", Required = Newtonsoft.Json.Required.Default)]
        public RestrictionAction? RestrictionAction { get; set; }
    
        /// <summary>
        /// Gets or sets triggers.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "triggers", Required = Newtonsoft.Json.Required.Default)]
        public IEnumerable<RestrictionTrigger> Triggers { get; set; }
    
        /// <summary>
        /// Gets or sets message.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "message", Required = Newtonsoft.Json.Required.Default)]
        public string Message { get; set; }
    
    }
}
