// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: Templates\CSharp\Model\MethodRequestBody.cs.tt

namespace Microsoft.Graph
{
    using Newtonsoft.Json;
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Runtime.Serialization;

    /// <summary>
    /// The type TeamworkGenerateActivityNotificationRequestBody.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public partial class TeamworkGenerateActivityNotificationRequestBody
    {
    
        /// <summary>
        /// Gets or sets About.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "about", Required = Newtonsoft.Json.Required.Default)]
        public string About { get; set; }
    
        /// <summary>
        /// Gets or sets ActivityType.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "activityType", Required = Newtonsoft.Json.Required.Default)]
        public string ActivityType { get; set; }
    
        /// <summary>
        /// Gets or sets AggregationId.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "aggregationId", Required = Newtonsoft.Json.Required.Default)]
        public Int64? AggregationId { get; set; }
    
        /// <summary>
        /// Gets or sets OnClickWebUrl.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "onClickWebUrl", Required = Newtonsoft.Json.Required.Default)]
        public string OnClickWebUrl { get; set; }
    
        /// <summary>
        /// Gets or sets PreviewText.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "previewText", Required = Newtonsoft.Json.Required.Default)]
        public string PreviewText { get; set; }
    
        /// <summary>
        /// Gets or sets TeamsAppId.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "teamsAppId", Required = Newtonsoft.Json.Required.Default)]
        public string TeamsAppId { get; set; }
    
        /// <summary>
        /// Gets or sets TemplateParameters.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "templateParameters", Required = Newtonsoft.Json.Required.Default)]
        public IEnumerable<KeyValuePair> TemplateParameters { get; set; }
    
        /// <summary>
        /// Gets or sets Recipient.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "recipient", Required = Newtonsoft.Json.Required.Default)]
        public TeamworkNotificationAudience Recipient { get; set; }
    
    }
}