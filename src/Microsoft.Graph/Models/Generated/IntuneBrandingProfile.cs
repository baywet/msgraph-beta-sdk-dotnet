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
    /// The type Intune Branding Profile.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public partial class IntuneBrandingProfile : Entity
    {
    
        /// <summary>
        /// Gets or sets profile name.
        /// Name of the profile
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "profileName", Required = Newtonsoft.Json.Required.Default)]
        public string ProfileName { get; set; }
    
        /// <summary>
        /// Gets or sets profile description.
        /// Description of the profile
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "profileDescription", Required = Newtonsoft.Json.Required.Default)]
        public string ProfileDescription { get; set; }
    
        /// <summary>
        /// Gets or sets is default profile.
        /// Boolean that represents whether the profile is used as default or not
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "isDefaultProfile", Required = Newtonsoft.Json.Required.Default)]
        public bool? IsDefaultProfile { get; set; }
    
        /// <summary>
        /// Gets or sets created date time.
        /// Time when the BrandingProfile was created
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "createdDateTime", Required = Newtonsoft.Json.Required.Default)]
        public DateTimeOffset? CreatedDateTime { get; set; }
    
        /// <summary>
        /// Gets or sets last modified date time.
        /// Time when the BrandingProfile was last modified
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "lastModifiedDateTime", Required = Newtonsoft.Json.Required.Default)]
        public DateTimeOffset? LastModifiedDateTime { get; set; }
    
        /// <summary>
        /// Gets or sets display name.
        /// Company/organization name that is displayed to end users
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "displayName", Required = Newtonsoft.Json.Required.Default)]
        public string DisplayName { get; set; }
    
        /// <summary>
        /// Gets or sets contact itname.
        /// Name of the person/organization responsible for IT support
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "contactITName", Required = Newtonsoft.Json.Required.Default)]
        public string ContactITName { get; set; }
    
        /// <summary>
        /// Gets or sets contact itphone number.
        /// Phone number of the person/organization responsible for IT support
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "contactITPhoneNumber", Required = Newtonsoft.Json.Required.Default)]
        public string ContactITPhoneNumber { get; set; }
    
        /// <summary>
        /// Gets or sets contact itemail address.
        /// E-mail address of the person/organization responsible for IT support
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "contactITEmailAddress", Required = Newtonsoft.Json.Required.Default)]
        public string ContactITEmailAddress { get; set; }
    
        /// <summary>
        /// Gets or sets contact itnotes.
        /// Text comments regarding the person/organization responsible for IT support
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "contactITNotes", Required = Newtonsoft.Json.Required.Default)]
        public string ContactITNotes { get; set; }
    
        /// <summary>
        /// Gets or sets privacy url.
        /// URL to the company/organizationâ€™s privacy policy
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "privacyUrl", Required = Newtonsoft.Json.Required.Default)]
        public string PrivacyUrl { get; set; }
    
        /// <summary>
        /// Gets or sets online support site url.
        /// URL to the company/organizationâ€™s IT helpdesk site
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "onlineSupportSiteUrl", Required = Newtonsoft.Json.Required.Default)]
        public string OnlineSupportSiteUrl { get; set; }
    
        /// <summary>
        /// Gets or sets online support site name.
        /// Display name of the company/organizationâ€™s IT helpdesk site
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "onlineSupportSiteName", Required = Newtonsoft.Json.Required.Default)]
        public string OnlineSupportSiteName { get; set; }
    
        /// <summary>
        /// Gets or sets theme color.
        /// Primary theme color used in the Company Portal applications and web portal
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "themeColor", Required = Newtonsoft.Json.Required.Default)]
        public RgbColor ThemeColor { get; set; }
    
        /// <summary>
        /// Gets or sets show logo.
        /// Boolean that represents whether the administrator-supplied logo images are shown or not
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "showLogo", Required = Newtonsoft.Json.Required.Default)]
        public bool? ShowLogo { get; set; }
    
        /// <summary>
        /// Gets or sets show display name next to logo.
        /// Boolean that represents whether the administrator-supplied display name will be shown next to the logo image or not
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "showDisplayNameNextToLogo", Required = Newtonsoft.Json.Required.Default)]
        public bool? ShowDisplayNameNextToLogo { get; set; }
    
        /// <summary>
        /// Gets or sets theme color logo.
        /// Logo image displayed in Company Portal apps which have a theme color background behind the logo
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "themeColorLogo", Required = Newtonsoft.Json.Required.Default)]
        public MimeContent ThemeColorLogo { get; set; }
    
        /// <summary>
        /// Gets or sets light background logo.
        /// Logo image displayed in Company Portal apps which have a light background behind the logo
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "lightBackgroundLogo", Required = Newtonsoft.Json.Required.Default)]
        public MimeContent LightBackgroundLogo { get; set; }
    
        /// <summary>
        /// Gets or sets landing page customized image.
        /// Customized image displayed in Company Portal apps landing page
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "landingPageCustomizedImage", Required = Newtonsoft.Json.Required.Default)]
        public MimeContent LandingPageCustomizedImage { get; set; }
    
        /// <summary>
        /// Gets or sets custom privacy message.
        /// Text comments regarding what the admin has access to on the device
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "customPrivacyMessage", Required = Newtonsoft.Json.Required.Default)]
        public string CustomPrivacyMessage { get; set; }
    
        /// <summary>
        /// Gets or sets assignments.
        /// The list of group assignments for the branding profile
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "assignments", Required = Newtonsoft.Json.Required.Default)]
        public IIntuneBrandingProfileAssignmentsCollectionPage Assignments { get; set; }
    
    }
}

