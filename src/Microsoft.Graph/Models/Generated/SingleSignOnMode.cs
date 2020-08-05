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
    /// The enum SingleSignOnMode.
    /// </summary>
    [JsonConverter(typeof(EnumConverter))]
    public enum SingleSignOnMode
    {
    
        /// <summary>
        /// None
        /// </summary>
        None = 0,
	
        /// <summary>
        /// On Premises Kerberos
        /// </summary>
        OnPremisesKerberos = 1,
	
        /// <summary>
        /// Saml
        /// </summary>
        Saml = 3,
	
    }
}
