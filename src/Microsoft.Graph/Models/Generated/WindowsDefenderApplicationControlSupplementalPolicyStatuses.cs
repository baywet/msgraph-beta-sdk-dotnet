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
    /// The enum WindowsDefenderApplicationControlSupplementalPolicyStatuses.
    /// </summary>
    [JsonConverter(typeof(EnumConverter))]
    public enum WindowsDefenderApplicationControlSupplementalPolicyStatuses
    {
    
        /// <summary>
        /// Unknown
        /// </summary>
        Unknown = 0,
	
        /// <summary>
        /// Success
        /// </summary>
        Success = 1,
	
        /// <summary>
        /// Token Error
        /// </summary>
        TokenError = 2,
	
        /// <summary>
        /// Not Authorized By Token
        /// </summary>
        NotAuthorizedByToken = 3,
	
        /// <summary>
        /// Policy Not Found
        /// </summary>
        PolicyNotFound = 4,
	
    }
}
