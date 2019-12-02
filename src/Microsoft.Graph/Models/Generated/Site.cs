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
    /// The type Site.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public partial class Site : BaseItem
    {
    
		///<summary>
		/// The Site constructor
		///</summary>
        public Site()
        {
            this.ODataType = "microsoft.graph.site";
        }
	
        /// <summary>
        /// Gets or sets display name.
        /// The full title for the site. Read-only.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "displayName", Required = Newtonsoft.Json.Required.Default)]
        public string DisplayName { get; set; }
    
        /// <summary>
        /// Gets or sets root.
        /// If present, indicates that this is the root site in the site collection. Read-only.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "root", Required = Newtonsoft.Json.Required.Default)]
        public Root Root { get; set; }
    
        /// <summary>
        /// Gets or sets sharepoint ids.
        /// Returns identifiers useful for SharePoint REST compatibility. Read-only.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "sharepointIds", Required = Newtonsoft.Json.Required.Default)]
        public SharepointIds SharepointIds { get; set; }
    
        /// <summary>
        /// Gets or sets site collection.
        /// Provides details about the site's site collection. Available only on the root site. Read-only.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "siteCollection", Required = Newtonsoft.Json.Required.Default)]
        public SiteCollection SiteCollection { get; set; }
    
        /// <summary>
        /// Gets or sets analytics.
        /// Analytics about the view activities that took place in this site.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "analytics", Required = Newtonsoft.Json.Required.Default)]
        public ItemAnalytics Analytics { get; set; }
    
        /// <summary>
        /// Gets or sets columns.
        /// The collection of column definitions reusable across lists under this site.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "columns", Required = Newtonsoft.Json.Required.Default)]
        public ISiteColumnsCollectionPage Columns { get; set; }
    
        /// <summary>
        /// Gets or sets content types.
        /// The collection of content types defined for this site.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "contentTypes", Required = Newtonsoft.Json.Required.Default)]
        public ISiteContentTypesCollectionPage ContentTypes { get; set; }
    
        /// <summary>
        /// Gets or sets drive.
        /// The default drive (document library) for this site.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "drive", Required = Newtonsoft.Json.Required.Default)]
        public Drive Drive { get; set; }
    
        /// <summary>
        /// Gets or sets drives.
        /// The collection of drives (document libraries) under this site.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "drives", Required = Newtonsoft.Json.Required.Default)]
        public ISiteDrivesCollectionPage Drives { get; set; }
    
        /// <summary>
        /// Gets or sets items.
        /// Used to address any item contained in this site. This collection cannot be enumerated.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "items", Required = Newtonsoft.Json.Required.Default)]
        public ISiteItemsCollectionPage Items { get; set; }
    
        /// <summary>
        /// Gets or sets lists.
        /// The collection of lists under this site.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "lists", Required = Newtonsoft.Json.Required.Default)]
        public ISiteListsCollectionPage Lists { get; set; }
    
        /// <summary>
        /// Gets or sets pages.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "pages", Required = Newtonsoft.Json.Required.Default)]
        public ISitePagesCollectionPage Pages { get; set; }
    
        /// <summary>
        /// Gets or sets sites.
        /// The collection of the sub-sites under this site.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "sites", Required = Newtonsoft.Json.Required.Default)]
        public ISiteSitesCollectionPage Sites { get; set; }
    
        /// <summary>
        /// Gets or sets onenote.
        /// Calls the OneNote service for notebook related operations.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "onenote", Required = Newtonsoft.Json.Required.Default)]
        public Onenote Onenote { get; set; }
    
    }
}

