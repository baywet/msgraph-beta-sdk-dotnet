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
    /// The type BitLockerFixedDrivePolicy.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    [JsonConverter(typeof(DerivedTypeConverter))]
    public partial class BitLockerFixedDrivePolicy
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BitLockerFixedDrivePolicy"/> class.
        /// </summary>
        public BitLockerFixedDrivePolicy()
        {
            this.ODataType = "microsoft.graph.bitLockerFixedDrivePolicy";
        }

        /// <summary>
        /// Gets or sets encryptionMethod.
        /// Select the encryption method for fixed drives.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "encryptionMethod", Required = Newtonsoft.Json.Required.Default)]
        public BitLockerEncryptionMethod? EncryptionMethod { get; set; }
    
        /// <summary>
        /// Gets or sets requireEncryptionForWriteAccess.
        /// This policy setting determines whether BitLocker protection is required for fixed data drives to be writable on a computer.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "requireEncryptionForWriteAccess", Required = Newtonsoft.Json.Required.Default)]
        public bool? RequireEncryptionForWriteAccess { get; set; }
    
        /// <summary>
        /// Gets or sets recoveryOptions.
        /// This policy setting allows you to control how BitLocker-protected fixed data drives are recovered in the absence of the required credentials. This policy setting is applied when you turn on BitLocker.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "recoveryOptions", Required = Newtonsoft.Json.Required.Default)]
        public BitLockerRecoveryOptions RecoveryOptions { get; set; }
    
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
