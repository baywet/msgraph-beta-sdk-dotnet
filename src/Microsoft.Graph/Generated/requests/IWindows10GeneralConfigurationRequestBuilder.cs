// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: IEntityRequestBuilder.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;

    /// <summary>
    /// The interface IWindows10GeneralConfigurationRequestBuilder.
    /// </summary>
    public partial interface IWindows10GeneralConfigurationRequestBuilder : IDeviceConfigurationRequestBuilder
    {
        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        new IWindows10GeneralConfigurationRequest Request();

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        new IWindows10GeneralConfigurationRequest Request(IEnumerable<Option> options);
    
        /// <summary>
        /// Gets the request builder for PrivacyAccessControls.
        /// </summary>
        /// <returns>The <see cref="IWindows10GeneralConfigurationPrivacyAccessControlsCollectionRequestBuilder"/>.</returns>
        IWindows10GeneralConfigurationPrivacyAccessControlsCollectionRequestBuilder PrivacyAccessControls { get; }
    
    }
}
