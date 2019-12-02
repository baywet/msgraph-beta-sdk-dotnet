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
    /// The type Device Management Script User State.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public partial class DeviceManagementScriptUserState : Entity
    {
    
		///<summary>
		/// The DeviceManagementScriptUserState constructor
		///</summary>
        public DeviceManagementScriptUserState()
        {
            this.ODataType = "microsoft.graph.deviceManagementScriptUserState";
        }
	
        /// <summary>
        /// Gets or sets success device count.
        /// Success device count for specific user.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "successDeviceCount", Required = Newtonsoft.Json.Required.Default)]
        public Int32? SuccessDeviceCount { get; set; }
    
        /// <summary>
        /// Gets or sets error device count.
        /// Error device count for specific user.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "errorDeviceCount", Required = Newtonsoft.Json.Required.Default)]
        public Int32? ErrorDeviceCount { get; set; }
    
        /// <summary>
        /// Gets or sets user principal name.
        /// User principle name of specific user.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "userPrincipalName", Required = Newtonsoft.Json.Required.Default)]
        public string UserPrincipalName { get; set; }
    
        /// <summary>
        /// Gets or sets device run states.
        /// List of run states for this script across all devices of specific user.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "deviceRunStates", Required = Newtonsoft.Json.Required.Default)]
        public IDeviceManagementScriptUserStateDeviceRunStatesCollectionPage DeviceRunStates { get; set; }
    
    }
}

