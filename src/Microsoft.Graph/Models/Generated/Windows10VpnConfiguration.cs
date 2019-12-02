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
    /// The type Windows10Vpn Configuration.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public partial class Windows10VpnConfiguration : WindowsVpnConfiguration
    {
    
		///<summary>
		/// The Windows10VpnConfiguration constructor
		///</summary>
        public Windows10VpnConfiguration()
        {
            this.ODataType = "microsoft.graph.windows10VpnConfiguration";
        }
	
        /// <summary>
        /// Gets or sets profile target.
        /// Profile target type.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "profileTarget", Required = Newtonsoft.Json.Required.Default)]
        public Windows10VpnProfileTarget? ProfileTarget { get; set; }
    
        /// <summary>
        /// Gets or sets connection type.
        /// Connection type.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "connectionType", Required = Newtonsoft.Json.Required.Default)]
        public Windows10VpnConnectionType? ConnectionType { get; set; }
    
        /// <summary>
        /// Gets or sets enable split tunneling.
        /// Enable split tunneling.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "enableSplitTunneling", Required = Newtonsoft.Json.Required.Default)]
        public bool? EnableSplitTunneling { get; set; }
    
        /// <summary>
        /// Gets or sets enable always on.
        /// Enable Always On mode.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "enableAlwaysOn", Required = Newtonsoft.Json.Required.Default)]
        public bool? EnableAlwaysOn { get; set; }
    
        /// <summary>
        /// Gets or sets enable device tunnel.
        /// Enable device tunnel.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "enableDeviceTunnel", Required = Newtonsoft.Json.Required.Default)]
        public bool? EnableDeviceTunnel { get; set; }
    
        /// <summary>
        /// Gets or sets enable dns registration.
        /// Enable IP address registration with internal DNS.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "enableDnsRegistration", Required = Newtonsoft.Json.Required.Default)]
        public bool? EnableDnsRegistration { get; set; }
    
        /// <summary>
        /// Gets or sets dns suffixes.
        /// Specify DNS suffixes to add to the DNS search list to properly route short names.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "dnsSuffixes", Required = Newtonsoft.Json.Required.Default)]
        public IEnumerable<string> DnsSuffixes { get; set; }
    
        /// <summary>
        /// Gets or sets authentication method.
        /// Authentication method.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "authenticationMethod", Required = Newtonsoft.Json.Required.Default)]
        public Windows10VpnAuthenticationMethod? AuthenticationMethod { get; set; }
    
        /// <summary>
        /// Gets or sets remember user credentials.
        /// Remember user credentials.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "rememberUserCredentials", Required = Newtonsoft.Json.Required.Default)]
        public bool? RememberUserCredentials { get; set; }
    
        /// <summary>
        /// Gets or sets enable conditional access.
        /// Enable conditional access.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "enableConditionalAccess", Required = Newtonsoft.Json.Required.Default)]
        public bool? EnableConditionalAccess { get; set; }
    
        /// <summary>
        /// Gets or sets enable single sign on with alternate certificate.
        /// Enable single sign-on (SSO) with alternate certificate.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "enableSingleSignOnWithAlternateCertificate", Required = Newtonsoft.Json.Required.Default)]
        public bool? EnableSingleSignOnWithAlternateCertificate { get; set; }
    
        /// <summary>
        /// Gets or sets single sign on eku.
        /// Single sign-on Extended Key Usage (EKU).
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "singleSignOnEku", Required = Newtonsoft.Json.Required.Default)]
        public ExtendedKeyUsage SingleSignOnEku { get; set; }
    
        /// <summary>
        /// Gets or sets single sign on issuer hash.
        /// Single sign-on issuer hash.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "singleSignOnIssuerHash", Required = Newtonsoft.Json.Required.Default)]
        public string SingleSignOnIssuerHash { get; set; }
    
        /// <summary>
        /// Gets or sets eap xml.
        /// Extensible Authentication Protocol (EAP) XML. (UTF8 encoded byte array)
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "eapXml", Required = Newtonsoft.Json.Required.Default)]
        public byte[] EapXml { get; set; }
    
        /// <summary>
        /// Gets or sets proxy server.
        /// Proxy Server.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "proxyServer", Required = Newtonsoft.Json.Required.Default)]
        public Windows10VpnProxyServer ProxyServer { get; set; }
    
        /// <summary>
        /// Gets or sets associated apps.
        /// Associated Apps. This collection can contain a maximum of 10000 elements.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "associatedApps", Required = Newtonsoft.Json.Required.Default)]
        public IEnumerable<Windows10AssociatedApps> AssociatedApps { get; set; }
    
        /// <summary>
        /// Gets or sets only associated apps can use connection.
        /// Only associated Apps can use connection (per-app VPN).
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "onlyAssociatedAppsCanUseConnection", Required = Newtonsoft.Json.Required.Default)]
        public bool? OnlyAssociatedAppsCanUseConnection { get; set; }
    
        /// <summary>
        /// Gets or sets windows information protection domain.
        /// Windows Information Protection (WIP) domain to associate with this connection.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "windowsInformationProtectionDomain", Required = Newtonsoft.Json.Required.Default)]
        public string WindowsInformationProtectionDomain { get; set; }
    
        /// <summary>
        /// Gets or sets traffic rules.
        /// Traffic rules. This collection can contain a maximum of 1000 elements.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "trafficRules", Required = Newtonsoft.Json.Required.Default)]
        public IEnumerable<VpnTrafficRule> TrafficRules { get; set; }
    
        /// <summary>
        /// Gets or sets routes.
        /// Routes (optional for third-party providers). This collection can contain a maximum of 1000 elements.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "routes", Required = Newtonsoft.Json.Required.Default)]
        public IEnumerable<VpnRoute> Routes { get; set; }
    
        /// <summary>
        /// Gets or sets dns rules.
        /// DNS rules. This collection can contain a maximum of 1000 elements.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "dnsRules", Required = Newtonsoft.Json.Required.Default)]
        public IEnumerable<VpnDnsRule> DnsRules { get; set; }
    
        /// <summary>
        /// Gets or sets trusted network domains.
        /// Trusted Network Domains
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "trustedNetworkDomains", Required = Newtonsoft.Json.Required.Default)]
        public IEnumerable<string> TrustedNetworkDomains { get; set; }
    
        /// <summary>
        /// Gets or sets identity certificate.
        /// Identity certificate for client authentication when authentication method is certificate.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "identityCertificate", Required = Newtonsoft.Json.Required.Default)]
        public WindowsCertificateProfileBase IdentityCertificate { get; set; }
    
    }
}

