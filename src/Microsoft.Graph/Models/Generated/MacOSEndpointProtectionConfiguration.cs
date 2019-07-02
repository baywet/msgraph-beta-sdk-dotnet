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
    /// The type Mac OSEndpoint Protection Configuration.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public partial class MacOSEndpointProtectionConfiguration : DeviceConfiguration
    {
    
        /// <summary>
        /// Gets or sets gatekeeper allowed app source.
        /// System and Privacy setting that determines which download locations apps can be run from on a macOS device.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "gatekeeperAllowedAppSource", Required = Newtonsoft.Json.Required.Default)]
        public MacOSGatekeeperAppSources? GatekeeperAllowedAppSource { get; set; }
    
        /// <summary>
        /// Gets or sets gatekeeper block override.
        /// If set to true, the user override for Gatekeeper will be disabled.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "gatekeeperBlockOverride", Required = Newtonsoft.Json.Required.Default)]
        public bool? GatekeeperBlockOverride { get; set; }
    
        /// <summary>
        /// Gets or sets firewall enabled.
        /// Whether the firewall should be enabled or not.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "firewallEnabled", Required = Newtonsoft.Json.Required.Default)]
        public bool? FirewallEnabled { get; set; }
    
        /// <summary>
        /// Gets or sets firewall block all incoming.
        /// Corresponds to the â€œBlock all incoming connectionsâ€ option.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "firewallBlockAllIncoming", Required = Newtonsoft.Json.Required.Default)]
        public bool? FirewallBlockAllIncoming { get; set; }
    
        /// <summary>
        /// Gets or sets firewall enable stealth mode.
        /// Corresponds to â€œEnable stealth mode.â€
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "firewallEnableStealthMode", Required = Newtonsoft.Json.Required.Default)]
        public bool? FirewallEnableStealthMode { get; set; }
    
        /// <summary>
        /// Gets or sets firewall applications.
        /// List of applications with firewall settings. Firewall settings for applications not on this list are determined by the user. This collection can contain a maximum of 500 elements.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "firewallApplications", Required = Newtonsoft.Json.Required.Default)]
        public IEnumerable<MacOSFirewallApplication> FirewallApplications { get; set; }
    
        /// <summary>
        /// Gets or sets file vault enabled.
        /// Whether FileVault should be enabled or not.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "fileVaultEnabled", Required = Newtonsoft.Json.Required.Default)]
        public bool? FileVaultEnabled { get; set; }
    
        /// <summary>
        /// Gets or sets file vault selected recovery key types.
        /// Required if FileVault is enabled, determines the type(s) of recovery key to use. 
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "fileVaultSelectedRecoveryKeyTypes", Required = Newtonsoft.Json.Required.Default)]
        public MacOSFileVaultRecoveryKeyTypes? FileVaultSelectedRecoveryKeyTypes { get; set; }
    
        /// <summary>
        /// Gets or sets file vault institutional recovery key certificate.
        /// Required if selected recovery key type(s) include InstitutionalRecoveryKey. The DER Encoded certificate file used to set an institutional recovery key.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "fileVaultInstitutionalRecoveryKeyCertificate", Required = Newtonsoft.Json.Required.Default)]
        public byte[] FileVaultInstitutionalRecoveryKeyCertificate { get; set; }
    
        /// <summary>
        /// Gets or sets file vault institutional recovery key certificate file name.
        /// File name of the institutional recovery key certificate to display in UI. (*.der).
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "fileVaultInstitutionalRecoveryKeyCertificateFileName", Required = Newtonsoft.Json.Required.Default)]
        public string FileVaultInstitutionalRecoveryKeyCertificateFileName { get; set; }
    
        /// <summary>
        /// Gets or sets file vault personal recovery key help message.
        /// Required if selected recovery key type(s) include PersonalRecoveryKey. A short message displayed to the user that explains how they can retrieve their personal recovery key.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "fileVaultPersonalRecoveryKeyHelpMessage", Required = Newtonsoft.Json.Required.Default)]
        public string FileVaultPersonalRecoveryKeyHelpMessage { get; set; }
    
        /// <summary>
        /// Gets or sets file vault allow deferral until sign out.
        /// Optional. If set to true, the user can defer the enabling of FileVault until they sign out.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "fileVaultAllowDeferralUntilSignOut", Required = Newtonsoft.Json.Required.Default)]
        public bool? FileVaultAllowDeferralUntilSignOut { get; set; }
    
        /// <summary>
        /// Gets or sets file vault number of times user can ignore.
        /// Optional. When using the Defer option, this is the maximum number of times the user can ignore prompts to enable FileVault before FileVault will be required for the user to sign in. If set to -1, it will always prompt to enable FileVault until FileVault is enabled, though it will allow the user to bypass enabling FileVault. Setting this to 0 will disable the feature.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "fileVaultNumberOfTimesUserCanIgnore", Required = Newtonsoft.Json.Required.Default)]
        public Int32? FileVaultNumberOfTimesUserCanIgnore { get; set; }
    
        /// <summary>
        /// Gets or sets file vault disable prompt at sign out.
        /// Optional. When using the Defer option, if set to true, the user is not prompted to enable FileVault at sign-out.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "fileVaultDisablePromptAtSignOut", Required = Newtonsoft.Json.Required.Default)]
        public bool? FileVaultDisablePromptAtSignOut { get; set; }
    
        /// <summary>
        /// Gets or sets file vault personal recovery key rotation in months.
        /// Optional. If selected recovery key type(s) include PersonalRecoveryKey, the frequency to rotate that key, in months.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "fileVaultPersonalRecoveryKeyRotationInMonths", Required = Newtonsoft.Json.Required.Default)]
        public Int32? FileVaultPersonalRecoveryKeyRotationInMonths { get; set; }
    
    }
}

