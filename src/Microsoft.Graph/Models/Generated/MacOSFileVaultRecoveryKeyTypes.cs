// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: Templates\CSharp\Model\EnumType.cs.tt


namespace Microsoft.Graph
{
    using Newtonsoft.Json;

    /// <summary>
    /// The enum MacOSFileVaultRecoveryKeyTypes.
    /// </summary>
    [JsonConverter(typeof(EnumConverter))]
	[System.Flags]
    public enum MacOSFileVaultRecoveryKeyTypes
    {
    
        /// <summary>
        /// Not Configured
        /// </summary>
        NotConfigured = 0,
	
        /// <summary>
        /// Institutional Recovery Key
        /// </summary>
        InstitutionalRecoveryKey = 1,
	
        /// <summary>
        /// Personal Recovery Key
        /// </summary>
        PersonalRecoveryKey = 2,
	
    }
}
