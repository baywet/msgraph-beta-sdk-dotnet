// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: IEntityCollectionRequestBuilder.cs.tt
namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// The interface IDeviceAppManagementIosManagedAppProtectionsCollectionRequestBuilder.
    /// </summary>
    public partial interface IDeviceAppManagementIosManagedAppProtectionsCollectionRequestBuilder : IBaseRequestBuilder
    {
        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        IDeviceAppManagementIosManagedAppProtectionsCollectionRequest Request();

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        IDeviceAppManagementIosManagedAppProtectionsCollectionRequest Request(IEnumerable<Option> options);

        /// <summary>
        /// Gets an <see cref="IIosManagedAppProtectionRequestBuilder"/> for the specified IosManagedAppProtection.
        /// </summary>
        /// <param name="id">The ID for the IosManagedAppProtection.</param>
        /// <returns>The <see cref="IIosManagedAppProtectionRequestBuilder"/>.</returns>
        IIosManagedAppProtectionRequestBuilder this[string id] { get; }

        /// <summary>
        /// Gets the request builder for IosManagedAppProtectionHasPayloadLinks.
        /// </summary>
        /// <returns>The <see cref="IIosManagedAppProtectionHasPayloadLinksRequestBuilder"/>.</returns>
        IIosManagedAppProtectionHasPayloadLinksRequestBuilder HasPayloadLinks(
            IEnumerable<string> payloadIds = null);
    }
}
