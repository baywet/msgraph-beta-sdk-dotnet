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
    /// The type Shared Drive Item.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public partial class SharedDriveItem : BaseItem
    {
    
		///<summary>
		/// The SharedDriveItem constructor
		///</summary>
        public SharedDriveItem()
        {
            this.ODataType = "microsoft.graph.sharedDriveItem";
        }
	
        /// <summary>
        /// Gets or sets owner.
        /// Information about the owner of the shared item being referenced.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "owner", Required = Newtonsoft.Json.Required.Default)]
        public IdentitySet Owner { get; set; }
    
        /// <summary>
        /// Gets or sets drive item.
        /// Used to access the underlying driveItem
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "driveItem", Required = Newtonsoft.Json.Required.Default)]
        public DriveItem DriveItem { get; set; }
    
        /// <summary>
        /// Gets or sets items.
        /// All driveItems contained in the sharing root. This collection cannot be enumerated.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "items", Required = Newtonsoft.Json.Required.Default)]
        public ISharedDriveItemItemsCollectionPage Items { get; set; }
    
        /// <summary>
        /// Gets or sets list.
        /// Used to access the underlying list
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "list", Required = Newtonsoft.Json.Required.Default)]
        public List List { get; set; }
    
        /// <summary>
        /// Gets or sets list item.
        /// Used to access the underlying listItem
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "listItem", Required = Newtonsoft.Json.Required.Default)]
        public ListItem ListItem { get; set; }
    
        /// <summary>
        /// Gets or sets permission.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "permission", Required = Newtonsoft.Json.Required.Default)]
        public Permission Permission { get; set; }
    
        /// <summary>
        /// Gets or sets root.
        /// Used to access the underlying driveItem. Deprecated -- use driveItem instead.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "root", Required = Newtonsoft.Json.Required.Default)]
        public DriveItem Root { get; set; }
    
        /// <summary>
        /// Gets or sets site.
        /// Used to access the underlying site
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "site", Required = Newtonsoft.Json.Required.Default)]
        public Site Site { get; set; }
    
    }
}

