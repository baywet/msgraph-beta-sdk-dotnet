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
    /// The type WindowsKioskLocalUser.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public partial class WindowsKioskLocalUser : WindowsKioskUser
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WindowsKioskLocalUser"/> class.
        /// </summary>
        public WindowsKioskLocalUser()
        {
            this.ODataType = "microsoft.graph.windowsKioskLocalUser";
        }

        /// <summary>
        /// Gets or sets userName.
        /// The local user that will be locked to this kiosk configuration
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "userName", Required = Newtonsoft.Json.Required.Default)]
        public string UserName { get; set; }
    
    }
}
