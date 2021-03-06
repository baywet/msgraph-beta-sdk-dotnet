// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: MethodRequestBody.cs.tt

namespace Microsoft.Graph
{
    using Newtonsoft.Json;
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Runtime.Serialization;

    /// <summary>
    /// The type GroupEvaluateDynamicMembershipRequestBody.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public partial class GroupEvaluateDynamicMembershipRequestBody
    {
    
        /// <summary>
        /// Gets or sets MemberId.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "memberId", Required = Newtonsoft.Json.Required.Default)]
        public string MemberId { get; set; }
    
        /// <summary>
        /// Gets or sets MembershipRule.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "membershipRule", Required = Newtonsoft.Json.Required.Default)]
        public string MembershipRule { get; set; }
    
    }
}
