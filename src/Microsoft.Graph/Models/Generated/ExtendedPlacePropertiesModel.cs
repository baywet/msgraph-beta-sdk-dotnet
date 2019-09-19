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
    /// The type ExtendedPlacePropertiesModel.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    [JsonConverter(typeof(DerivedTypeConverter))]
    public partial class ExtendedPlacePropertiesModel
    {

        /// <summary>
        /// Gets or sets priceRange.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "priceRange", Required = Newtonsoft.Json.Required.Default)]
        public string PriceRange { get; set; }
    
        /// <summary>
        /// Gets or sets menuUrl.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "menuUrl", Required = Newtonsoft.Json.Required.Default)]
        public string MenuUrl { get; set; }
    
        /// <summary>
        /// Gets or sets businessUrl.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "businessUrl", Required = Newtonsoft.Json.Required.Default)]
        public string BusinessUrl { get; set; }
    
        /// <summary>
        /// Gets or sets formattedAddress.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "formattedAddress", Required = Newtonsoft.Json.Required.Default)]
        public string FormattedAddress { get; set; }
    
        /// <summary>
        /// Gets or sets openingHoursSpecifications.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "openingHoursSpecifications", Required = Newtonsoft.Json.Required.Default)]
        public IEnumerable<OpeningHoursSpecification> OpeningHoursSpecifications { get; set; }
    
        /// <summary>
        /// Gets or sets timeZone.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "timeZone", Required = Newtonsoft.Json.Required.Default)]
        public string TimeZone { get; set; }
    
        /// <summary>
        /// Gets or sets additional data.
        /// </summary>
        [JsonExtensionData(ReadData = true)]
        public IDictionary<string, object> AdditionalData { get; set; }

        /// <summary>
        /// Gets or sets @odata.type.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "@odata.type", Required = Newtonsoft.Json.Required.Default)]
        public string ODataType { get; set; }
    
    }
}