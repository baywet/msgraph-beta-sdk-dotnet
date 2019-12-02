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
    /// The type Default Managed App Protection.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public partial class DefaultManagedAppProtection : ManagedAppProtection
    {
    
		///<summary>
		/// The DefaultManagedAppProtection constructor
		///</summary>
        public DefaultManagedAppProtection()
        {
            this.ODataType = "microsoft.graph.defaultManagedAppProtection";
        }
	
        /// <summary>
        /// Gets or sets app data encryption type.
        /// Type of encryption which should be used for data in a managed app. (iOS Only). Possible values are: useDeviceSettings, afterDeviceRestart, whenDeviceLockedExceptOpenFiles, whenDeviceLocked.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "appDataEncryptionType", Required = Newtonsoft.Json.Required.Default)]
        public ManagedAppDataEncryptionType? AppDataEncryptionType { get; set; }
    
        /// <summary>
        /// Gets or sets screen capture blocked.
        /// Indicates whether screen capture is blocked. (Android only)
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "screenCaptureBlocked", Required = Newtonsoft.Json.Required.Default)]
        public bool? ScreenCaptureBlocked { get; set; }
    
        /// <summary>
        /// Gets or sets encrypt app data.
        /// Indicates whether managed-app data should be encrypted. (Android only)
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "encryptAppData", Required = Newtonsoft.Json.Required.Default)]
        public bool? EncryptAppData { get; set; }
    
        /// <summary>
        /// Gets or sets disable app encryption if device encryption is enabled.
        /// When this setting is enabled, app level encryption is disabled if device level encryption is enabled. (Android only)
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "disableAppEncryptionIfDeviceEncryptionIsEnabled", Required = Newtonsoft.Json.Required.Default)]
        public bool? DisableAppEncryptionIfDeviceEncryptionIsEnabled { get; set; }
    
        /// <summary>
        /// Gets or sets minimum required sdk version.
        /// Versions less than the specified version will block the managed app from accessing company data. (iOS Only)
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "minimumRequiredSdkVersion", Required = Newtonsoft.Json.Required.Default)]
        public string MinimumRequiredSdkVersion { get; set; }
    
        /// <summary>
        /// Gets or sets custom settings.
        /// A set of string key and string value pairs to be sent to the affected users, unalterned by this service
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "customSettings", Required = Newtonsoft.Json.Required.Default)]
        public IEnumerable<KeyValuePair> CustomSettings { get; set; }
    
        /// <summary>
        /// Gets or sets deployed app count.
        /// Count of apps to which the current policy is deployed.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "deployedAppCount", Required = Newtonsoft.Json.Required.Default)]
        public Int32? DeployedAppCount { get; set; }
    
        /// <summary>
        /// Gets or sets minimum required patch version.
        /// Define the oldest required Android security patch level a user can have to gain secure access to the app. (Android only)
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "minimumRequiredPatchVersion", Required = Newtonsoft.Json.Required.Default)]
        public string MinimumRequiredPatchVersion { get; set; }
    
        /// <summary>
        /// Gets or sets minimum warning patch version.
        /// Define the oldest recommended Android security patch level a user can have for secure access to the app. (Android only)
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "minimumWarningPatchVersion", Required = Newtonsoft.Json.Required.Default)]
        public string MinimumWarningPatchVersion { get; set; }
    
        /// <summary>
        /// Gets or sets exempted app protocols.
        /// iOS Apps in this list will be exempt from the policy and will be able to receive data from managed apps. (iOS Only)
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "exemptedAppProtocols", Required = Newtonsoft.Json.Required.Default)]
        public IEnumerable<KeyValuePair> ExemptedAppProtocols { get; set; }
    
        /// <summary>
        /// Gets or sets exempted app packages.
        /// Android App packages in this list will be exempt from the policy and will be able to receive data from managed apps. (Android only)
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "exemptedAppPackages", Required = Newtonsoft.Json.Required.Default)]
        public IEnumerable<KeyValuePair> ExemptedAppPackages { get; set; }
    
        /// <summary>
        /// Gets or sets face id blocked.
        /// Indicates whether use of the FaceID is allowed in place of a pin if PinRequired is set to True. (iOS Only)
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "faceIdBlocked", Required = Newtonsoft.Json.Required.Default)]
        public bool? FaceIdBlocked { get; set; }
    
        /// <summary>
        /// Gets or sets minimum wipe sdk version.
        /// Versions less than the specified version will block the managed app from accessing company data.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "minimumWipeSdkVersion", Required = Newtonsoft.Json.Required.Default)]
        public string MinimumWipeSdkVersion { get; set; }
    
        /// <summary>
        /// Gets or sets minimum wipe patch version.
        /// Android security patch level  less than or equal to the specified value will wipe the managed app and the associated company data. (Android only)
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "minimumWipePatchVersion", Required = Newtonsoft.Json.Required.Default)]
        public string MinimumWipePatchVersion { get; set; }
    
        /// <summary>
        /// Gets or sets allowed ios device models.
        /// Semicolon seperated list of device models allowed, as a string, for the managed app to work. (iOS Only)
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "allowedIosDeviceModels", Required = Newtonsoft.Json.Required.Default)]
        public string AllowedIosDeviceModels { get; set; }
    
        /// <summary>
        /// Gets or sets app action if ios device model not allowed.
        /// Defines a managed app behavior, either block or wipe, if the specified device model is not allowed. (iOS Only)
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "appActionIfIosDeviceModelNotAllowed", Required = Newtonsoft.Json.Required.Default)]
        public ManagedAppRemediationAction? AppActionIfIosDeviceModelNotAllowed { get; set; }
    
        /// <summary>
        /// Gets or sets allowed android device manufacturers.
        /// Semicolon seperated list of device manufacturers allowed, as a string, for the managed app to work. (Android only)
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "allowedAndroidDeviceManufacturers", Required = Newtonsoft.Json.Required.Default)]
        public string AllowedAndroidDeviceManufacturers { get; set; }
    
        /// <summary>
        /// Gets or sets app action if android device manufacturer not allowed.
        /// Defines a managed app behavior, either block or wipe, if the specified device manufacturer is not allowed. (Android only)
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "appActionIfAndroidDeviceManufacturerNotAllowed", Required = Newtonsoft.Json.Required.Default)]
        public ManagedAppRemediationAction? AppActionIfAndroidDeviceManufacturerNotAllowed { get; set; }
    
        /// <summary>
        /// Gets or sets filter open in to only managed apps.
        /// Defines if open-in operation is supported from the managed app to the filesharing locations selected. This setting only applies when AllowedOutboundDataTransferDestinations is set to ManagedApps and DisableProtectionOfManagedOutboundOpenInData is set to False. (iOS Only)
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "filterOpenInToOnlyManagedApps", Required = Newtonsoft.Json.Required.Default)]
        public bool? FilterOpenInToOnlyManagedApps { get; set; }
    
        /// <summary>
        /// Gets or sets disable protection of managed outbound open in data.
        /// Disable protection of data transferred to other apps through IOS OpenIn option. This setting is only allowed to be True when AllowedOutboundDataTransferDestinations is set to ManagedApps. (iOS Only)
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "disableProtectionOfManagedOutboundOpenInData", Required = Newtonsoft.Json.Required.Default)]
        public bool? DisableProtectionOfManagedOutboundOpenInData { get; set; }
    
        /// <summary>
        /// Gets or sets protect inbound data from unknown sources.
        /// Protect incoming data from unknown source. This setting is only allowed to be True when AllowedInboundDataTransferSources is set to AllApps. (iOS Only)
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "protectInboundDataFromUnknownSources", Required = Newtonsoft.Json.Required.Default)]
        public bool? ProtectInboundDataFromUnknownSources { get; set; }
    
        /// <summary>
        /// Gets or sets required android safety net device attestation type.
        /// Defines the Android SafetyNet Device Attestation requirement for a managed app to work.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "requiredAndroidSafetyNetDeviceAttestationType", Required = Newtonsoft.Json.Required.Default)]
        public AndroidManagedAppSafetyNetDeviceAttestationType? RequiredAndroidSafetyNetDeviceAttestationType { get; set; }
    
        /// <summary>
        /// Gets or sets app action if android safety net device attestation failed.
        /// Defines a managed app behavior, either warn or block, if the specified Android SafetyNet Attestation requirment fails.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "appActionIfAndroidSafetyNetDeviceAttestationFailed", Required = Newtonsoft.Json.Required.Default)]
        public ManagedAppRemediationAction? AppActionIfAndroidSafetyNetDeviceAttestationFailed { get; set; }
    
        /// <summary>
        /// Gets or sets required android safety net apps verification type.
        /// Defines the Android SafetyNet Apps Verification requirement for a managed app to work.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "requiredAndroidSafetyNetAppsVerificationType", Required = Newtonsoft.Json.Required.Default)]
        public AndroidManagedAppSafetyNetAppsVerificationType? RequiredAndroidSafetyNetAppsVerificationType { get; set; }
    
        /// <summary>
        /// Gets or sets app action if android safety net apps verification failed.
        /// Defines a managed app behavior, either warn or block, if the specified Android App Verification requirment fails.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "appActionIfAndroidSafetyNetAppsVerificationFailed", Required = Newtonsoft.Json.Required.Default)]
        public ManagedAppRemediationAction? AppActionIfAndroidSafetyNetAppsVerificationFailed { get; set; }
    
        /// <summary>
        /// Gets or sets custom browser protocol.
        /// A custom browser protocol to open weblink on iOS. (iOS only)
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "customBrowserProtocol", Required = Newtonsoft.Json.Required.Default)]
        public string CustomBrowserProtocol { get; set; }
    
        /// <summary>
        /// Gets or sets custom browser package id.
        /// Unique identifier of a custom browser to open weblink on Android. (Android only)
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "customBrowserPackageId", Required = Newtonsoft.Json.Required.Default)]
        public string CustomBrowserPackageId { get; set; }
    
        /// <summary>
        /// Gets or sets custom browser display name.
        /// Friendly name of the preferred custom browser to open weblink on Android. (Android only)
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "customBrowserDisplayName", Required = Newtonsoft.Json.Required.Default)]
        public string CustomBrowserDisplayName { get; set; }
    
        /// <summary>
        /// Gets or sets minimum required company portal version.
        /// Minimum version of the Company portal that must be installed on the device or app access will be blocked
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "minimumRequiredCompanyPortalVersion", Required = Newtonsoft.Json.Required.Default)]
        public string MinimumRequiredCompanyPortalVersion { get; set; }
    
        /// <summary>
        /// Gets or sets minimum warning company portal version.
        /// Minimum version of the Company portal that must be installed on the device or the user will receive a warning
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "minimumWarningCompanyPortalVersion", Required = Newtonsoft.Json.Required.Default)]
        public string MinimumWarningCompanyPortalVersion { get; set; }
    
        /// <summary>
        /// Gets or sets minimum wipe company portal version.
        /// Minimum version of the Company portal that must be installed on the device or the company data on the app will be wiped
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "minimumWipeCompanyPortalVersion", Required = Newtonsoft.Json.Required.Default)]
        public string MinimumWipeCompanyPortalVersion { get; set; }
    
        /// <summary>
        /// Gets or sets apps.
        /// List of apps to which the policy is deployed.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "apps", Required = Newtonsoft.Json.Required.Default)]
        public IDefaultManagedAppProtectionAppsCollectionPage Apps { get; set; }
    
        /// <summary>
        /// Gets or sets deployment summary.
        /// Navigation property to deployment summary of the configuration.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "deploymentSummary", Required = Newtonsoft.Json.Required.Default)]
        public ManagedAppPolicyDeploymentSummary DeploymentSummary { get; set; }
    
    }
}

