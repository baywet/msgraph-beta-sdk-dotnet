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
    /// The type Group Policy Presentation Value Text.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public partial class GroupPolicyPresentationValueText : GroupPolicyPresentationValue
    {
    
		///<summary>
		/// The GroupPolicyPresentationValueText constructor
		///</summary>
        public GroupPolicyPresentationValueText()
        {
            this.ODataType = "microsoft.graph.groupPolicyPresentationValueText";
        }
	
        /// <summary>
        /// Gets or sets value.
        /// A string value for the associated presentation.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "value", Required = Newtonsoft.Json.Required.Default)]
        public string Value { get; set; }
    
    }
}

