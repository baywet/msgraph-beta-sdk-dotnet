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
    /// The type Android Work Profile Vpn Configuration.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public partial class AndroidWorkProfileVpnConfiguration : DeviceConfiguration
    {
    
		///<summary>
		/// The AndroidWorkProfileVpnConfiguration constructor
		///</summary>
        public AndroidWorkProfileVpnConfiguration()
        {
            this.ODataType = "microsoft.graph.androidWorkProfileVpnConfiguration";
        }
	
        /// <summary>
        /// Gets or sets connection name.
        /// Connection name displayed to the user.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "connectionName", Required = Newtonsoft.Json.Required.Default)]
        public string ConnectionName { get; set; }
    
        /// <summary>
        /// Gets or sets connection type.
        /// Connection type.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "connectionType", Required = Newtonsoft.Json.Required.Default)]
        public AndroidWorkProfileVpnConnectionType? ConnectionType { get; set; }
    
        /// <summary>
        /// Gets or sets role.
        /// Role when connection type is set to Pulse Secure.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "role", Required = Newtonsoft.Json.Required.Default)]
        public string Role { get; set; }
    
        /// <summary>
        /// Gets or sets realm.
        /// Realm when connection type is set to Pulse Secure.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "realm", Required = Newtonsoft.Json.Required.Default)]
        public string Realm { get; set; }
    
        /// <summary>
        /// Gets or sets servers.
        /// List of VPN Servers on the network. Make sure end users can access these network locations. This collection can contain a maximum of 500 elements.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "servers", Required = Newtonsoft.Json.Required.Default)]
        public IEnumerable<VpnServer> Servers { get; set; }
    
        /// <summary>
        /// Gets or sets fingerprint.
        /// Fingerprint is a string that will be used to verify the VPN server can be trusted, which is only applicable when connection type is Check Point Capsule VPN.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "fingerprint", Required = Newtonsoft.Json.Required.Default)]
        public string Fingerprint { get; set; }
    
        /// <summary>
        /// Gets or sets custom data.
        /// Custom data when connection type is set to Citrix. This collection can contain a maximum of 25 elements.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "customData", Required = Newtonsoft.Json.Required.Default)]
        public IEnumerable<KeyValue> CustomData { get; set; }
    
        /// <summary>
        /// Gets or sets custom key value data.
        /// Custom data when connection type is set to Citrix. This collection can contain a maximum of 25 elements.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "customKeyValueData", Required = Newtonsoft.Json.Required.Default)]
        public IEnumerable<KeyValuePair> CustomKeyValueData { get; set; }
    
        /// <summary>
        /// Gets or sets authentication method.
        /// Authentication method.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "authenticationMethod", Required = Newtonsoft.Json.Required.Default)]
        public VpnAuthenticationMethod? AuthenticationMethod { get; set; }
    
        /// <summary>
        /// Gets or sets proxy server.
        /// Proxy server.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "proxyServer", Required = Newtonsoft.Json.Required.Default)]
        public VpnProxyServer ProxyServer { get; set; }
    
        /// <summary>
        /// Gets or sets targeted package ids.
        /// Targeted App package IDs.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "targetedPackageIds", Required = Newtonsoft.Json.Required.Default)]
        public IEnumerable<string> TargetedPackageIds { get; set; }
    
        /// <summary>
        /// Gets or sets always on.
        /// Whether or not to enable always-on VPN connection.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "alwaysOn", Required = Newtonsoft.Json.Required.Default)]
        public bool? AlwaysOn { get; set; }
    
        /// <summary>
        /// Gets or sets always on lockdown.
        /// If always-on VPN connection is enabled, whether or not to lock network traffic when that VPN is disconnected.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "alwaysOnLockdown", Required = Newtonsoft.Json.Required.Default)]
        public bool? AlwaysOnLockdown { get; set; }
    
        /// <summary>
        /// Gets or sets identity certificate.
        /// Identity certificate for client authentication when authentication method is certificate.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "identityCertificate", Required = Newtonsoft.Json.Required.Default)]
        public AndroidWorkProfileCertificateProfileBase IdentityCertificate { get; set; }
    
    }
}

