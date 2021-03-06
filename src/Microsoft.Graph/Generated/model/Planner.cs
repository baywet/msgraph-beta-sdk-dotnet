// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: EntityType.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// The type Planner.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public partial class Planner : Entity
    {
    
		///<summary>
		/// The Planner constructor
		///</summary>
        public Planner()
        {
            this.ODataType = "microsoft.graph.planner";
        }
	
        /// <summary>
        /// Gets or sets buckets.
        /// Read-only. Nullable. Returns a collection of the specified buckets
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "buckets", Required = Newtonsoft.Json.Required.Default)]
        public IPlannerBucketsCollectionPage Buckets { get; set; }
    
        /// <summary>
        /// Gets or sets plans.
        /// Read-only. Nullable. Returns a collection of the specified plans
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "plans", Required = Newtonsoft.Json.Required.Default)]
        public IPlannerPlansCollectionPage Plans { get; set; }
    
        /// <summary>
        /// Gets or sets tasks.
        /// Read-only. Nullable. Returns a collection of the specified tasks
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "tasks", Required = Newtonsoft.Json.Required.Default)]
        public IPlannerTasksCollectionPage Tasks { get; set; }
    
    }
}

